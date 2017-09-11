using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;
using Spring.Transaction.Interceptor;
using Vns.Erp.Core.Accounting.Domain.Extend;
using Vns.Erp.Core.Admin.Domain;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtCtHKhacService:GenericService<KtCtHKhac,System.Guid>, IKtCtHKhacService
    {
        #region Property
        
        public IKtCtHKhacDao KtCtHKhacDao
        {
            get { return (IKtCtHKhacDao)Dao; }
            set { Dao = value; }
        }
        private IKtCtDKhacDao _KtCtDKhacDao;
        public IKtCtDKhacDao KtCtDKhacDao
        {
            get { return _KtCtDKhacDao; }
            set { _KtCtDKhacDao = value; }
        }

        private ICtThueDao _CtThueDao;
        public ICtThueDao CtThueDao
        {
            get { return _CtThueDao; }
            set { _CtThueDao = value; }
        }

        private ICtHoadonDao _CtHoadonDao;
        public ICtHoadonDao CtHoadonDao
        {
            get { return _CtHoadonDao; }
            set { _CtHoadonDao = value; }
        }

        private IBcKetoanDao _BcKetoanDao;
        public IBcKetoanDao BcKetoanDao
        {
            get { return _BcKetoanDao; }
            set { _BcKetoanDao = value; }
        }
        #endregion

        public IList<KtCtHKhac> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<KtCtHKhac> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            IList<VnsOrder> orders = new List<VnsOrder>();
            props.Add("DonviId");
            values.Add(DonviId);
            props.Add("MaLoaiCt");
            values.Add(MaLoaiCt);
            orders.Add(new VnsOrder(false, "NgayCt"));
            orders.Add(new VnsOrder(false, "CtSo"));
            return List(-1, -1, props, values, orders);
        }

        public IList<KtCtHKhac> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult)
        {
            return KtCtHKhacDao.GetByLoaiChungTu(PageIndex, PageSize, DonviId, MaLoaiCt, out TotalResult);
        }

        [Transaction]
        public Boolean DeleteChungTu(KtCtHKhac objCtH, IList<KtCtDKhac> lstCtD)
        {
            _BcKetoanDao.DeleteByChungTu(objCtH.Id, new Guid());

            if (lstCtD == null) lstCtD = new List<KtCtDKhac>();
            foreach (KtCtDKhac tmpctd in lstCtD)
            {
                _CtThueDao.DeleteByCtD(tmpctd.IdDoituongHoadon);
                _CtHoadonDao.DeleteByChungTu(tmpctd.IdDoituongHoadon, 1);
            }

            objCtH.IsDeleted = 1;
            objCtH.SynDate = Null.MIN_DATE;
            SaveOrUpdate(objCtH);
            return true;
        }

        [Transaction]
        public void SaveCTDK(Vns.Erp.Core.FormGlobals.DataInputState status, ref KtCtHKhac _cthInfo, List<KtCtDKhac> lstCTDK, List<KtCtDKhac> del_lstobj_ct_d_k)
        {
            KtCtHKhac obj = _cthInfo;
            try
            {
                obj.SynDate = Null.MIN_DATE;
                //Insert update CT_H
                switch (status)
                {
                    case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:
                        obj.NgayTao = DateTime.Now;
                        obj = KtCtHKhacDao.Save(obj);
                        break;
                    case Vns.Erp.Core.FormGlobals.DataInputState.CopyMode:
                        obj.NgayTao = DateTime.Now;
                        obj = KtCtHKhacDao.Save(obj);
                        break;
                    case Vns.Erp.Core.FormGlobals.DataInputState.EditMode:
                        obj.NgaySua = DateTime.Now;
                        _BcKetoanDao.DeleteByChungTu(obj.Id, Null.NullGuid);
                        KtCtHKhacDao.Update(obj);
                        break;
                }

                Guid str_ct_hoaDon_id = new Guid();
                int count_thue = 0;
                //Khai bai list cua list nhom
                CtDService _ctdService = new CtDService();
                List<List<KtCtDKhac>> lstnhomctdk = GetLstNhom(lstCTDK);
                //Khai bao list thue
                List<CtThue> lstCT_Thue = null;
                //list del thue
                List<CtThue> lstDelCT_Thue = null;
                //object hoa don
                CtHoadon CT_HOADON = default(CtHoadon);

                foreach (List<KtCtDKhac> ctDKInfos in lstnhomctdk)
                {
                    count_thue = 0;
                    lstCT_Thue = new List<CtThue>();
                    lstDelCT_Thue = new List<CtThue>();
                    CT_HOADON = new CtHoadon();

                    //Dem so tai khoan thue trong 1 nhom
                    count_thue = Count_tk_thue(ctDKInfos);

                    foreach (KtCtDKhac ctDKInfo in ctDKInfos)
                    {
                        if (ctDKInfo.MaTk == null)
                        {
                            ctDKInfo.MaTk = "";
                        }

                        //Neu so tai khoan thue =1
                        if (count_thue == 1)
                        {
                            //Thuc hien xoa CT_THUE va CT_HOADON trong nhung tk ko phai tk thue
                            if ((!ctDKInfo.MaTk.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) & (!ctDKInfo.MaTk.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)))
                            {
                                ctDKInfo.LstDelCtThue = ctDKInfo.LstCtThue;
                                ctDKInfo.LstCtThue = null;
                                if (ctDKInfo.CT_HOADON != null)
                                {
                                    str_ct_hoaDon_id = ctDKInfo.CT_HOADON.Id;
                                    ctDKInfo.CT_HOADON = null;
                                    CT_HOADON = null;
                                }
                                ctDKInfo.IdDoituongHoadon = new Guid();
                            }
                            //Neu so tai khoan thue khac >1 thuc hien xoa CT_THUE va CT_HOADON trong tat ca cac tk
                        }
                        else
                        {
                            ctDKInfo.LstDelCtThue = ctDKInfo.LstCtThue;
                            ctDKInfo.LstCtThue = null;
                            if (ctDKInfo.CT_HOADON != null)
                            {
                                str_ct_hoaDon_id = ctDKInfo.CT_HOADON.Id;
                                ctDKInfo.CT_HOADON = null;
                            }
                            ctDKInfo.IdDoituongHoadon = new Guid();
                            CT_HOADON = null;
                        }

                        //Lay ra lst_thue trong CTDK
                        if (ctDKInfo.LstCtThue != null)
                        {
                            if (ctDKInfo.LstCtThue.Count != 0)
                            {
                                foreach (CtThue ctThueInfo in ctDKInfo.LstCtThue)
                                {
                                    lstCT_Thue.Add(ctThueInfo);
                                }
                            }
                        }

                        //Lay ra CT_HOADON trong CTDK
                        if (ctDKInfo.CT_HOADON != null)
                        {
                            CT_HOADON = ctDKInfo.CT_HOADON;
                        }

                        //Lay ta list del_thue trong CTD_K
                        if (ctDKInfo.LstDelCtThue != null)
                        {
                            if (ctDKInfo.LstDelCtThue.Count != 0)
                            {
                                foreach (CtThue ctThueInfo in ctDKInfo.LstDelCtThue)
                                {
                                    lstDelCT_Thue.Add(ctThueInfo);
                                }
                            }
                        }
                    }

                    ////Thuc hien insert, update CT_HOADON
                    if (CT_HOADON != null)
                    {
                        CT_HOADON.SynDate = Null.MIN_DATE;
                        if (VnsCheck.IsNullGuid(CT_HOADON.Id))
                        {
                            _CtHoadonDao.Save(CT_HOADON);
                        }
                        else
                        {
                            _CtHoadonDao.Update(CT_HOADON);
                        }
                    }

                    ////Thuc hien gan doi tuong hoa don cho CTD_K
                    foreach (KtCtDKhac ctDKInfo_1 in lstCTDK)
                    {
                        if (ctDKInfo_1.CT_HOADON != null)
                        {
                            if (CT_HOADON != null)
                            {
                                ctDKInfo_1.IdDoituongHoadon = CT_HOADON.Id;
                                ctDKInfo_1.KyHieuHoadon = CT_HOADON.SoSeri;
                                ctDKInfo_1.MaHoadon = CT_HOADON.SoHoadon;
                            }
                        }
                    }

                    //Save KtCtDKhac
                    foreach (KtCtDKhac ctDInfo in ctDKInfos)
                    {
                        ctDInfo.SoDu = 0;
                        ctDInfo.PhanHe = 0;
                        if (ctDInfo.Id == Null.NullGuid)
                        {
                            ctDInfo.CthId = obj.Id;
                            _KtCtDKhacDao.Save(ctDInfo);
                        }
                        else
                        {
                            _KtCtDKhacDao.SaveOrUpdate(ctDInfo);
                        }
                    }

                    //Lay CT_D tu CTD_K
                    List<CtD> lstCT_D = ListConvertCTDK2CTD(ctDKInfos);

                    // Dim ctDInfo As CT_DInfo = New CT_DInfo()
                    foreach (CtD ctDInfo in lstCT_D)
                    {
                        //Save BcKeToan
                        BcKetoan objbcKeToan = new BcKetoan(_cthInfo, ctDInfo);
                        _BcKetoanDao.Save(objbcKeToan);
                    }


                    if (lstCT_Thue.Count != 0)
                    {
                        foreach (CtThue objcthue in lstCT_Thue)
                        {
                            if (CT_HOADON != null)
                            {
                                objcthue.CtHoadonId = CT_HOADON.Id;
                            }
                            objcthue.PhanHe = 0;
                            if (VnsCheck.IsNullGuid(objcthue.Id))
                            {
                                objcthue.SoTienNte = 0;
                                _CtThueDao.Save(objcthue);
                            }
                            else
                            {
                                _CtThueDao.Update(objcthue);
                            }
                        }
                    }

                    //Xoa CT_THUE
                    foreach (CtThue del_objcthue in lstDelCT_Thue)
                    {
                        _CtThueDao.Delete(del_objcthue);
                    }
                    //Xoa CT_HOADON
                    if (!VnsCheck.IsNullGuid(str_ct_hoaDon_id))
                    {
                        CtHoadon tmp = new CtHoadon();
                        tmp.Id = str_ct_hoaDon_id;
                        _CtHoadonDao.DeleteById(tmp.Id);
                    }
                }
                
                foreach (KtCtDKhac ctDKInfo in del_lstobj_ct_d_k)
                {
                    _KtCtDKhacDao.DeleteByCtH(ctDKInfo.CthId, ctDKInfo.NHOM);

                    CtHoadon tmp = new CtHoadon();
                    tmp.Id = ctDKInfo.IdDoituongHoadon;
                    _CtHoadonDao.DeleteById(tmp.Id);
                }
            }
            catch (Exception ex)
            {
                //Message_Error(ex);
            }
        }

        public List<List<KtCtDKhac>> GetLstNhom(List<KtCtDKhac> lstCTDK)
        {

            List<List<KtCtDKhac>> lstNhom = new List<List<KtCtDKhac>>();
            foreach (KtCtDKhac ctDKInfo in lstCTDK)
            {
                if (lstNhom.Count == 0)
                {
                    List<KtCtDKhac> nhom = new List<KtCtDKhac>();
                    nhom.Add(ctDKInfo);
                    lstNhom.Add(nhom);
                }
                else
                {
                    bool isTrue = false;
                    foreach (List<KtCtDKhac> inhom in lstNhom)
                    {
                        if (ctDKInfo.NHOM == inhom[0].NHOM)
                        {
                            inhom.Add(ctDKInfo);
                            isTrue = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (isTrue == false)
                    {
                        List<KtCtDKhac> nhom = new List<KtCtDKhac>();
                        nhom.Add(ctDKInfo);
                        lstNhom.Add(nhom);
                    }
                }
            }
            return lstNhom;
        }

        public int Count_tk_thue(List<KtCtDKhac> lstCTDK)
        {
            int count = 0;

            foreach (KtCtDKhac obj_ctk in lstCTDK)
            {
                if (obj_ctk.MaTk == null)
                {
                    obj_ctk.MaTk = "";
                }

                if ((obj_ctk.MaTk.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) | (obj_ctk.MaTk.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)))
                {
                    count = count + 1;
                }
            }

            return count;
        }

        public List<CtD> ListConvertCTDK2CTD(List<KtCtDKhac> lstCTDK)
        {
            List<CtD> lstTempCTD = new List<CtD>();
            List<List<KtCtDKhac>> lstNhom = GetLstNhom(lstCTDK);
            foreach (List<KtCtDKhac> lstCTDKBYNHOM in lstNhom)
            {
                int c = 0;
                int n = 0;
                foreach (KtCtDKhac ctDKInfo in lstCTDKBYNHOM)
                {
                    if (ctDKInfo.PsCo != 0 | ctDKInfo.PsCoNt != 0)
                    {
                        c = c + 1;
                    }
                    if (ctDKInfo.PsNo != 0 | ctDKInfo.PsNoNt != 0)
                    {
                        n = n + 1;
                    }
                }
                //CT_D_K 1'
                //Truong hop 1:1: gan No TempCTDK; Gan Co vao list
                //Truong hop 1:n or n:1 nhu nhau
                KtCtDKhac TempCTDK = new KtCtDKhac();
                //List CTD_K n
                List<KtCtDKhac> lstTempCTDK = new List<KtCtDKhac>();

                if (c == n)
                {
                    foreach (KtCtDKhac ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PsNo != 0 | ctDKInfo.PsNoNt != 0)
                        {
                            TempCTDK = ctDKInfo;
                        }
                        else
                        {
                            lstTempCTDK.Add(ctDKInfo);
                        }
                    }

                }
                else if (c > n)
                {
                    foreach (KtCtDKhac ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PsNo != 0 | ctDKInfo.PsNoNt != 0)
                        {
                            TempCTDK = ctDKInfo;
                        }
                        else
                        {
                            lstTempCTDK.Add(ctDKInfo);
                        }
                    }
                }
                else if (c < n)
                {
                    foreach (KtCtDKhac ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PsCo != 0 | ctDKInfo.PsCoNt != 0)
                        {
                            TempCTDK = ctDKInfo;
                        }
                        else
                        {
                            lstTempCTDK.Add(ctDKInfo);
                        }
                    }
                }
                //For ListTemp

                if (c > n | n > c)
                {
                    lstTempCTDK = Check_id_CTDK(lstTempCTDK, TempCTDK);
                }

                //List CTD Luu vao db
                foreach (KtCtDKhac ctDKInfo in lstTempCTDK)
                {
                    CtD TempctDInfo = new CtD();
                    TempctDInfo = InfoConvertCTDK2CTD(TempCTDK, TempctDInfo);
                    TempctDInfo = InfoConvertCTDK2CTD(ctDKInfo, TempctDInfo);
                    lstTempCTD.Add(TempctDInfo);
                }
            }
            return lstTempCTD;
        }

        private List<KtCtDKhac> Check_id_CTDK(List<KtCtDKhac> lst, KtCtDKhac obj_1n)
        {
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                if (!VnsCheck.IsNullGuid(lst[i].Id))
                {
                    for (int j = 0; j <= lst.Count - 1; j++)
                    {
                        if (i != j)
                        {
                            if (lst[i].Id == lst[j].Id)
                            {
                                Guid str = lst[j].Id;
                                lst[j].Id = obj_1n.Id;
                                obj_1n.Id = str;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                }
            }
            return lst;
        }

        private CtD InfoConvertCTDK2CTD(KtCtDKhac objct_d_k, CtD objct_d)
        {
            CtD ctd = objct_d;
            //Truyen gia tri vao tu p1 sang ctd
            //2 Truong hop:
            //1:PS No
            //2:PS Co
            //3:PS No = PS Co = 0
            if (objct_d_k.PsCo != 0 | objct_d_k.PsCoNt != 0)
            {
                objct_d.Id = objct_d_k.Id;
                objct_d.CthId = objct_d_k.CthId;
                objct_d.CtGhisoNgay = objct_d_k.CtGhisoNgay;
                objct_d.CtGhisoTrichyeu = objct_d_k.CtGhisoTrichyeu;
                objct_d.DaGhiso = objct_d_k.DaGhiso;
                objct_d.IdCtGhiso = objct_d_k.IdCtGhiso;
                objct_d.IdDmHopdongCo = objct_d_k.IdDmHopdong;
                objct_d.IdDmKhoanphiCo = objct_d_k.IdDmKhoanphi;
                objct_d.IdDmPhongbanCo = objct_d_k.IdDmPhongban;
                objct_d.IdDmPtqtCo = objct_d_k.IdDmPtqt;
                objct_d.IdDmTudo1Co = objct_d_k.IdDmTudo1;
                objct_d.IdDmTudo2Co = objct_d_k.IdDmTudo2;
                objct_d.IdDmTudo3Co = objct_d_k.IdDmTudo3;
                objct_d.IdDmTudo4Co = objct_d_k.IdDmTudo4;
                objct_d.IdDmTudo5Co = objct_d_k.IdDmTudo5;
                objct_d.IdDmVuviecCo = objct_d_k.IdDmVuviec;
                objct_d.IdDoituong1 = objct_d_k.IdDoituong1;
                objct_d.IdDoituong2 = objct_d_k.IdDoituong2;
                objct_d.IdDoituong3 = objct_d_k.IdDoituong3;
                objct_d.IdKhangCo = objct_d_k.IdKhang;
                objct_d.KyHieuKhangCo = objct_d_k.KyHieuKhang;
                objct_d.KyHieuHopdongCo = objct_d_k.KyHieuHopdong;
                objct_d.KyHieuVuviecCo = objct_d_k.KyHieuVuviec;
                objct_d.LoaiNghiepVu = objct_d_k.LoaiNghiepVu;
                objct_d.MaCtGhisoSo = objct_d_k.MaCtGhisoSo;
                objct_d.MaDoituong1 = objct_d_k.MaDoituong1;
                objct_d.MaDoituong2 = objct_d_k.MaDoituong2;
                objct_d.MaDoituong3 = objct_d_k.MaDoituong3;
                objct_d.MaHopdongCo = objct_d_k.MaHopdong;
                objct_d.MaKhangCo = objct_d_k.MaKhang;
                objct_d.MaTkCo = objct_d_k.MaTk;
                objct_d.MaVuviecCo = objct_d_k.MaVuviec;
                objct_d.Nhom = objct_d_k.NHOM;
                objct_d.NoiDung = objct_d_k.NoiDung;
                objct_d.SoTien = objct_d_k.PsCo;
                objct_d.SoTienNte = objct_d_k.PsCoNt;
                objct_d.TenDoituong1 = objct_d_k.TenDoituong1;
                objct_d.TenDoituong2 = objct_d_k.TenDoituong2;
                objct_d.TenDoituong3 = objct_d_k.TenDoituong3;
                objct_d.TenHopdongCo = objct_d_k.TenHopdong;
                objct_d.TenTkCo = objct_d_k.TenTk;
                objct_d.TkCoId = objct_d_k.TkId;
                objct_d.TenKhangCo = objct_d_k.TenKhang;
                //objct_d.ID_DOITUONG_HOADON = objct_d_k.ID_DOITUONG_HOADON
                //objct_d.MA_HOADON = objct_d_k.MA_HOADON
                //objct_d.KY_HIEU_HOADON = objct_d_k.KY_HIEU_HOADON
                objct_d.MaRo = objct_d_k.MaRo;
                objct_d.TenRo = objct_d_k.TenRo;
                objct_d.PhanHe = objct_d_k.PhanHe;
                objct_d.Bx1 = objct_d_k.Bx1;
                objct_d.Bx2 = objct_d_k.Bx2;
                objct_d.Bx3 = objct_d_k.Bx3;
            }
            else if (objct_d_k.PsNo != 0 | objct_d_k.PsNoNt != 0)
            {
                objct_d.Id = objct_d_k.Id;
                objct_d.CthId = objct_d_k.CthId;
                objct_d.CtGhisoNgay = objct_d_k.CtGhisoNgay;
                objct_d.CtGhisoTrichyeu = objct_d_k.CtGhisoTrichyeu;
                objct_d.DaGhiso = objct_d_k.DaGhiso;
                objct_d.IdCtGhiso = objct_d_k.IdCtGhiso;
                objct_d.IdDmHopdongNo = objct_d_k.IdDmHopdong;
                objct_d.IdDmKhoanphiNo = objct_d_k.IdDmKhoanphi;
                objct_d.IdDmPhongbanNo = objct_d_k.IdDmPhongban;
                objct_d.IdDmPtqtNo = objct_d_k.IdDmPtqt;
                objct_d.IdDmTudo1No = objct_d_k.IdDmTudo1;
                objct_d.IdDmTudo2No = objct_d_k.IdDmTudo2;
                objct_d.IdDmTudo3No = objct_d_k.IdDmTudo3;
                objct_d.IdDmTudo4No = objct_d_k.IdDmTudo4;
                objct_d.IdDmTudo5No = objct_d_k.IdDmTudo5;
                objct_d.IdDmVuviecNo = objct_d_k.IdDmVuviec;
                objct_d.IdDoituong1 = objct_d_k.IdDoituong1;
                objct_d.IdDoituong2 = objct_d_k.IdDoituong2;
                objct_d.IdDoituong3 = objct_d_k.IdDoituong3;
                objct_d.IdKhangNo = objct_d_k.IdKhang;
                objct_d.KyHieuKhangNo = objct_d_k.KyHieuKhang;
                objct_d.KyHieuHopdongNo = objct_d_k.KyHieuHopdong;
                objct_d.KyHieuVuviecNo = objct_d_k.KyHieuVuviec;
                objct_d.LoaiNghiepVu = objct_d_k.LoaiNghiepVu;
                objct_d.MaCtGhisoSo = objct_d_k.MaCtGhisoSo;
                objct_d.MaDoituong1 = objct_d_k.MaDoituong1;
                objct_d.MaDoituong2 = objct_d_k.MaDoituong2;
                objct_d.MaDoituong3 = objct_d_k.MaDoituong3;
                objct_d.MaHopdongNo = objct_d_k.MaHopdong;
                objct_d.MaKhangNo = objct_d_k.MaKhang;
                objct_d.MaTkNo = objct_d_k.MaTk;
                objct_d.MaVuviecNo = objct_d_k.MaVuviec;
                objct_d.Nhom = objct_d_k.NHOM;
                objct_d.NoiDung = objct_d_k.NoiDung;
                objct_d.SoTien = objct_d_k.PsNo;
                objct_d.SoTienNte = objct_d_k.PsNoNt;
                objct_d.TenDoituong1 = objct_d_k.TenDoituong1;
                objct_d.TenDoituong2 = objct_d_k.TenDoituong1;
                objct_d.TenDoituong3 = objct_d_k.TenDoituong1;
                objct_d.TenHopdongNo = objct_d_k.TenHopdong;
                objct_d.TenTkNo = objct_d_k.TenTk;
                objct_d.TkNoId = objct_d_k.TkId;
                objct_d.TenKhangNo = objct_d_k.TenKhang;
                //objct_d.ID_DOITUONG_HOADON = objct_d_k.ID_DOITUONG_HOADON
                //objct_d.MA_HOADON = objct_d_k.MA_HOADON
                //objct_d.KY_HIEU_HOADON = objct_d_k.KY_HIEU_HOADON
                objct_d.MaRo = objct_d_k.MaRo;
                objct_d.TenRo = objct_d_k.TenRo;
                objct_d.PhanHe = objct_d_k.PhanHe;
                objct_d.Bx1 = objct_d_k.Bx1;
                objct_d.Bx2 = objct_d_k.Bx2;
                objct_d.Bx3 = objct_d_k.Bx3;
                //ElseIf objct_d_k.PS_NO = 0 And objct_d_k.PS_NO_NT = 0 And objct_d_k.PS_CO = 0 Or objct_d_k.PS_CO_NT = 0 Then
                //    objct_d.CTD_ID = objct_d_k.CTD_ID
                //    objct_d.CTH_ID = objct_d_k.CTH_ID
                //    objct_d.CT_GHISO_NGAY = objct_d_k.CT_GHISO_NGAY
                //    objct_d.CT_GHISO_TRICHYEU = objct_d_k.CT_GHISO_TRICHYEU
                //    objct_d.DA_GHISO = objct_d_k.DA_GHISO
                //    objct_d.ID_CT_GHISO = objct_d_k.ID_CT_GHISO
                //    'objct_d.ID_DOITUONG_HOADON = objct_d_k.ID_DOITUONG_HOADON
                //    'objct_d.MA_HOADON = objct_d_k.MA_HOADON
                //    'objct_d.KY_HIEU_HOADON = objct_d_k.KY_HIEU_HOADON
                //    objct_d.MA_RO = objct_d_k.MA_RO
                //    objct_d.TEN_RO = objct_d_k.TEN_RO
                //    objct_d.PHAN_HE = objct_d_k.PHAN_HE
                //    objct_d.BX_1 = objct_d_k.BX_1
                //    objct_d.BX_2 = objct_d_k.BX_2
                //    objct_d.BX_3 = objct_d_k.BX_3
                //    objct_d.ID_DM_HOPDONG_CO = objct_d_k.ID_DM_HOPDONG
                //    objct_d.ID_DM_KHOANPHI_CO = objct_d_k.ID_DM_KHOANPHI
                //    objct_d.ID_DM_PHONGBAN_CO = objct_d_k.ID_DM_PHONGBAN
                //    objct_d.ID_DM_PTQT_CO = objct_d_k.ID_DM_PTQT
                //    objct_d.ID_DM_TUDO_1_CO = objct_d_k.ID_DM_TUDO_1
                //    objct_d.ID_DM_TUDO_2_CO = objct_d_k.ID_DM_TUDO_2
                //    objct_d.ID_DM_TUDO_3_CO = objct_d_k.ID_DM_TUDO_3
                //    objct_d.ID_DM_TUDO_4_CO = objct_d_k.ID_DM_TUDO_4
                //    objct_d.ID_DM_TUDO_5_CO = objct_d_k.ID_DM_TUDO_5
                //    objct_d.ID_DM_VUVIEC_CO = objct_d_k.ID_DM_VUVIEC
                //    objct_d.ID_DOITUONG_1 = objct_d_k.ID_DOITUONG_1
                //    objct_d.ID_DOITUONG_2 = objct_d_k.ID_DOITUONG_2
                //    objct_d.ID_DOITUONG_3 = objct_d_k.ID_DOITUONG_3
                //    objct_d.ID_KHANG_CO = objct_d_k.ID_KHANG
                //    objct_d.KY_HIEU_KHANG_CO = objct_d_k.KY_HIEU_KHANG
                //    objct_d.KY_HIEU_HOPDONG_CO = objct_d_k.KY_HIEU_HOPDONG
                //    objct_d.KY_HIEU_VUVIEC_CO = objct_d_k.KY_HIEU_VUVIEC
                //    objct_d.LOAI_NGHIEP_VU = objct_d_k.LOAI_NGHIEP_VU
                //    objct_d.MA_CT_GHISO_SO = objct_d_k.MA_CT_GHISO_SO
                //    objct_d.MA_DOITUONG_1 = objct_d_k.MA_DOITUONG_1
                //    objct_d.MA_DOITUONG_2 = objct_d_k.MA_DOITUONG_2
                //    objct_d.MA_DOITUONG_3 = objct_d_k.MA_DOITUONG_3
                //    objct_d.MA_HOPDONG_CO = objct_d_k.MA_HOPDONG
                //    objct_d.MA_KHANG_CO = objct_d_k.MA_KHANG
                //    objct_d.MA_TK_CO = objct_d_k.MA_TK
                //    objct_d.MA_VUVIEC_CO = objct_d_k.MA_VUVIEC
                //    objct_d.NHOM = objct_d_k.NHOM
                //    objct_d.NOI_DUNG = objct_d_k.NOI_DUNG
                //    objct_d.SO_TIEN = objct_d_k.PS_CO
                //    objct_d.SO_TIEN_NTE = objct_d_k.PS_CO_NT
                //    objct_d.TEN_DOITUONG_1 = objct_d_k.TEN_DOITUONG_1
                //    objct_d.TEN_DOITUONG_2 = objct_d_k.TEN_DOITUONG_2
                //    objct_d.TEN_DOITUONG_3 = objct_d_k.TEN_DOITUONG_3
                //    objct_d.TEN_HOPDONG_CO = objct_d_k.TEN_HOPDONG
                //    objct_d.TEN_TK_CO = objct_d_k.TEN_TK
                //    objct_d.TK_CO_ID = objct_d_k.TK_ID
                //    objct_d.TEN_KHANG_CO = objct_d_k.TEN_TK

                //    objct_d.ID_DM_HOPDONG_NO = objct_d_k.ID_DM_HOPDONG
                //    objct_d.ID_DM_KHOANPHI_NO = objct_d_k.ID_DM_KHOANPHI
                //    objct_d.ID_DM_PHONGBAN_NO = objct_d_k.ID_DM_PHONGBAN
                //    objct_d.ID_DM_PTQT_NO = objct_d_k.ID_DM_PTQT
                //    objct_d.ID_DM_TUDO_1_NO = objct_d_k.ID_DM_TUDO_1
                //    objct_d.ID_DM_TUDO_2_NO = objct_d_k.ID_DM_TUDO_2
                //    objct_d.ID_DM_TUDO_3_NO = objct_d_k.ID_DM_TUDO_3
                //    objct_d.ID_DM_TUDO_4_NO = objct_d_k.ID_DM_TUDO_4
                //    objct_d.ID_DM_TUDO_5_NO = objct_d_k.ID_DM_TUDO_5
                //    objct_d.ID_DM_VUVIEC_NO = objct_d_k.ID_DM_VUVIEC
                //    objct_d.ID_KHANG_NO = objct_d_k.ID_KHANG
                //    objct_d.KY_HIEU_KHANG_NO = objct_d_k.KY_HIEU_KHANG
                //    objct_d.KY_HIEU_HOPDONG_NO = objct_d_k.KY_HIEU_HOPDONG
                //    objct_d.KY_HIEU_VUVIEC_NO = objct_d_k.KY_HIEU_VUVIEC
                //    objct_d.MA_HOPDONG_NO = objct_d_k.MA_HOPDONG
                //    objct_d.MA_KHANG_NO = objct_d_k.MA_KHANG
                //    objct_d.MA_TK_NO = objct_d_k.MA_TK
                //    objct_d.MA_VUVIEC_NO = objct_d_k.MA_VUVIEC
                //    objct_d.TEN_HOPDONG_NO = objct_d_k.TEN_HOPDONG
                //    objct_d.TEN_TK_NO = objct_d_k.TEN_TK
                //    objct_d.TK_NO_ID = objct_d_k.TK_ID
                //    objct_d.TEN_KHANG_NO = objct_d_k.TEN_TK
            }
            if (!VnsCheck.IsNullGuid(objct_d_k.IdDoituongHoadon))
            {
                objct_d.IdDoituongHoadon = objct_d_k.IdDoituongHoadon;
                objct_d.MaHoadon = objct_d_k.MaHoadon;
                objct_d.KyHieuHoadon = objct_d_k.KyHieuHoadon;
            }
            return objct_d;
        }

        #region Syn function
        [Transaction]
        public void SaveData4Syn(KtCtHKhac _cth, List<KtCtDKhac> _lstctd)
        {
            //Xoa du lieu
            //_cth. = null;
            _cth.LstKtCtDKhac = null;
            KtCtHKhacDao.SaveOrUpdate(_cth);

            if (_cth.IsDeleted != 1)
            {
                _KtCtDKhacDao.DeleteByCtH(_cth.Id);
                foreach (KtCtDKhac _tempctdnx in _lstctd)
                {
                    _KtCtDKhacDao.SaveOrUpdate(_tempctdnx);
                }
            }
        }
        #endregion
    }
}