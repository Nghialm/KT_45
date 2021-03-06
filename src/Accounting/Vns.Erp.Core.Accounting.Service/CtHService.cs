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
    public class CtHService : GenericService<CtH, System.Guid>, ICtHService
    {
        #region Property
        private ICtHDao _CtHDao;
        public ICtHDao CtHDao
        {
            get { return (ICtHDao)Dao; }
            set { Dao = value; }
        }

        private ICtDDao _CtDDao;
        public ICtDDao CtDDao
        {
            get { return _CtDDao; }
            set { _CtDDao = value; }
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

        private IKtThBtPhanboDao _KtThBtPhanboDao;

        public IKtThBtPhanboDao KtThBtPhanboDao
        {
            get { return _KtThBtPhanboDao; }
            set { _KtThBtPhanboDao = value; }
        }

        #endregion
        public IList<CtH> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<CtH> GetSoDu(Guid DonviId, int NamKeToan)
        {
            return CtHDao.GetSoDu(DonviId, NamKeToan);
        }

        public IList<CtD> GetAllSoDu(Guid DonviId, int NamKeToan)
        {
            return CtHDao.GetAllSoDu(DonviId, NamKeToan);
        }

        public IList<CtH> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt)
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

        public IList<CtH> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult)
        {
            return CtHDao.GetByLoaiChungTu(PageIndex,PageSize,DonviId, MaLoaiCt, out TotalResult);
        }

        public IList<CtH> GetByLoaiChungTu(Guid DonviId, int NamKeToan)
        {
            throw new NotImplementedException();
        }

        public CtH GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, DateTime NgayCt)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            IList<VnsOrder> orders = new List<VnsOrder>();
            props.Add("DonviId");
            values.Add(DonviId);
            props.Add("MaLoaiCt");
            values.Add(MaLoaiCt);
            props.Add("NgayCt");
            values.Add(NgayCt);
            IList<CtH> lst = List(-1, -1, props, values, null);
            if (lst.Count > 0)
                return lst[0];
            else
                return null;
        }

        [Transaction]
        public Boolean DeleteChungTu(CtH objCtH, IList<CtD> lstCtD)
        {
            _BcKetoanDao.DeleteByChungTu(objCtH.Id, new Guid());
            if (lstCtD == null) lstCtD = new List<CtD>();

            foreach (CtD tmpctd in lstCtD)
            {
                if (CheckThue(tmpctd))
                {
                    _CtThueDao.DeleteByCtD(tmpctd.Id);
                    _CtHoadonDao.DeleteByChungTu(tmpctd.Id, 1);
                }
            }
            _CtDDao.DeleteByCtH(objCtH.Id);
            //Delete(objCtH);
            DeleteById(objCtH.Id);
            return true;
        }

        public Boolean DeleteMa(Guid IdLoaiCt, DateTime NgayCt, Guid DonviId)
        {
            return CtHDao.DeleteMa(IdLoaiCt, NgayCt, DonviId);
        }



        [Transaction]
        public void SaveChungTuKeToan(Boolean IsInsert, ref CtHoadon _ctHoaDonInfo, ref CtH _cthInfo, ref List<CtD> _lstctdInfo, List<CtD> _lstDelCtdInfo, Guid TK_THUE, ref List<CtD> _lstCT_DInfo_Thue, ref CtD _objctdthue, ref List<CtThue> _lstCT_Thue, ref List<CtThue> _lstDel_CT_Thue)
        {
            CtH obj = _cthInfo;

            try
            {
                // Start a local transaction
                //Delete old in BcKeToan

                // Assign transaction object for a pending local transaction

                //Insert update CT_H
                if (IsInsert)
                {
                    obj.NgayTao = DateTime.Now;
                    CtHDao.Save(obj);
                }
                else
                {
                    //Delete BcKeToan
                    _BcKetoanDao.DeleteByChungTu(_cthInfo.Id, Null.NullGuid);
                    CtHDao.SaveOrUpdate(obj);
                }



                //Insert update CT_D
                foreach (CtD _tempctdnx in _lstctdInfo)
                {
                    _tempctdnx.CthId = obj.Id;
                    if ((_tempctdnx.Id == new Guid()))
                    {
                        _CtDDao.Save(_tempctdnx);
                    }
                    else
                    {
                        _CtDDao.SaveOrUpdate(_tempctdnx);
                    }
                    //Save BcKeToan
                    BcKetoan objbcKeToan = new BcKetoan(_cthInfo, _tempctdnx);
                    _BcKetoanDao.Save(objbcKeToan);
                }

                //Delete CT_D
                if ((_lstDelCtdInfo != null))
                {
                    foreach (CtD _tempdelctdnx in _lstDelCtdInfo)
                    {
                        if (_tempdelctdnx.Id != new Guid())
                        {
                            _CtDDao.Delete(_tempdelctdnx);
                        }
                    }
                }

                //Neu Tk thue blank=>xoa ct_thue, Xoa CT_HD
                if ((TK_THUE == Null.NullGuid))
                {
                    //Dim temp As CT_DInfo
                    foreach (CtD del_objctdThue in _lstCT_DInfo_Thue)
                    {
                        //temp = del_objctdThue
                        if (!IsInsert)
                        {
                            _CtThueDao.DeleteByCtD(del_objctdThue.Id);
                            _CtDDao.Delete(del_objctdThue);
                            _CtHoadonDao.DeleteById(_lstCT_Thue[0].CtHoadonId);// Mac dinh

                        }
                    }
                    _ctHoaDonInfo = new CtHoadon();
                    _lstCT_DInfo_Thue = new List<CtD>();
                    _objctdthue = new CtD();
                    _lstCT_Thue =new  List<CtThue>();
                }
                else
                {
                    //Insert ct_dThue, ct_thue(Chung tu thue)
                    //'Insert ct_dThue
                    _objctdthue.CthId = _cthInfo.Id;
                    if (VnsCheck.IsNullGuid(_objctdthue.Id))
                    {
                        _CtDDao.Save(_objctdthue);
                    }
                    else
                    {
                        _CtDDao.SaveOrUpdate(_objctdthue);
                    }

                    //Save BcKeToan
                    BcKetoan objbcKeToan = new BcKetoan(_cthInfo, _objctdthue);
                    _BcKetoanDao.Save(objbcKeToan);

                    //Insert update CT_HOADON
                    if (_ctHoaDonInfo != null)
                    {
                        _ctHoaDonInfo.CtLienQuan = _objctdthue.Id;
                        if (VnsCheck.IsNullGuid(_ctHoaDonInfo.Id))
                        {
                            _CtHoadonDao.Save(_ctHoaDonInfo);
                        }
                        else
                        {
                            _CtHoadonDao.SaveOrUpdate(_ctHoaDonInfo);
                        }
                    }

                    //'Insert ct_thue(Chung tu thue)
                    foreach (CtThue objThue in _lstCT_Thue)
                    {
                        objThue.CtdId = _objctdthue.Id;
                        objThue.CtHoadonId = _ctHoaDonInfo.Id;

                        if (VnsCheck.IsNullGuid(objThue.Id))
                        {
                            objThue.SoTienNte = 0;
                            _CtThueDao.Save(objThue);
                        }
                        else
                        {
                            //Them DONVI_ID vao tbl CT_Thue, dung tap de update DONVI_ID cho cac ban ghi cu
                            //objcthue.DONVI_ID = Generals.DON_VI.DONVI_ID.Replace("-", "")
                            _CtThueDao.SaveOrUpdate(objThue);
                        }
                    }
                }

                foreach (CtThue objDel_thue in _lstDel_CT_Thue)
                {
                    if (!VnsCheck.IsNullGuid(objDel_thue.Id))
                    {
                        _CtThueDao.Delete(objDel_thue);
                    }
                }
            }
            catch (Exception ex)
            {
                //obj = Nothing
                //Rollback transaction
            }
        }

        [Transaction]
        public void SaveChungTuKeToan(Boolean IsInsert, ref CtH _cthInfo, ref List<CtD> _lstctdInfo)
        {
            CtH obj = _cthInfo;

            try
            {
                // Start a local transaction
                //Delete old in BcKeToan

                // Assign transaction object for a pending local transaction

                //Insert update CT_H
                if (IsInsert)
                {
                    obj.NgayTao = DateTime.Now;
                    CtHDao.Save(obj);
                }
                else
                {
                    //Delete BcKeToan
                    CtHDao.SaveOrUpdate(obj);
                    _BcKetoanDao.DeleteByChungTu(_cthInfo.Id, Null.NullGuid);
                }

                //Insert update CT_D
                foreach (CtD _tempctdnx in _lstctdInfo)
                {
                    _tempctdnx.CthId = obj.Id;
                    if ((_tempctdnx.Id == new Guid()))
                    {
                        _CtDDao.Save(_tempctdnx);
                    }
                    else
                    {
                        _CtDDao.SaveOrUpdate(_tempctdnx);
                    }
                    //Save BcKeToan
                    BcKetoan objbcKeToan = new BcKetoan(_cthInfo, _tempctdnx);
                    _BcKetoanDao.Save(objbcKeToan);
                }
            }
            catch (Exception ex)
            {
                //obj = Nothing
                //Rollback transaction
            }
        }

        [Transaction]
        public void SaveCTDK(Vns.Erp.Core.FormGlobals.DataInputState status, ref CtH _cthInfo, List<CT_D_KInfo> lstCTDK, List<CT_D_KInfo> del_lstobj_ct_d_k)
        {
            CtH obj = _cthInfo;
            try
            {
                //Insert update CT_H
                switch (status)
                {
                    case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:
                        obj.NgayTao = DateTime.Now;
                        obj = CtHDao.Save(obj);
                        break;
                    case Vns.Erp.Core.FormGlobals.DataInputState.CopyMode:
                        obj.NgayTao = DateTime.Now;
                        obj = CtHDao.Save(obj);
                        break;
                    case Vns.Erp.Core.FormGlobals.DataInputState.EditMode:
                        obj.NgaySua = DateTime.Now;
                        _BcKetoanDao.DeleteByChungTu(obj.Id, Null.NullGuid);
                        CtHDao.Update(obj);
                        break;
                }

                Guid str_ct_hoaDon_id = new Guid();
                int count_thue = 0;
                //Khai bai list cua list nhom
                CtDService _ctdService = new CtDService();
                List<List<CT_D_KInfo>> lstnhomctdk = _ctdService.GetLstNhom(lstCTDK);
                //Khai bao list thue
                List<CtThue> lstCT_Thue = null;
                //list del thue
                List<CtThue> lstDelCT_Thue = null;
                //object hoa don
                CtHoadon CT_HOADON = default(CtHoadon);

                foreach (List<CT_D_KInfo> ctDKInfos in lstnhomctdk)
                {
                    count_thue = 0;
                    lstCT_Thue = new List<CtThue>();
                    lstDelCT_Thue = new List<CtThue>();
                    CT_HOADON = new CtHoadon();

                    //Dem so tai khoan thue trong 1 nhom
                    count_thue = _ctdService.Count_tk_thue(ctDKInfos);

                    foreach (CT_D_KInfo ctDKInfo in ctDKInfos)
                    {
                        if (ctDKInfo.MA_TK == null)
                        {
                            ctDKInfo.MA_TK = "";
                        }

                        //Neu so tai khoan thue =1
                        if (count_thue == 1)
                        {
                            //Thuc hien xoa CT_THUE va CT_HOADON trong nhung tk ko phai tk thue
                            if ((!ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) & (!ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)))
                            {
                                ctDKInfo.LstDelCtThue = ctDKInfo.LstCtThue;
                                ctDKInfo.LstCtThue = null;
                                if (ctDKInfo.CT_HOADON != null)
                                {
                                    str_ct_hoaDon_id = ctDKInfo.CT_HOADON.Id;
                                    ctDKInfo.CT_HOADON = null;
                                    CT_HOADON = null;
                                }
                                ctDKInfo.ID_DOITUONG_HOADON = new Guid();
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
                            ctDKInfo.ID_DOITUONG_HOADON = new Guid();
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
                    foreach (CT_D_KInfo ctDKInfo_1 in lstCTDK)
                    {
                        if (ctDKInfo_1.CT_HOADON != null)
                        {
                            if (CT_HOADON != null)
                            {
                                ctDKInfo_1.ID_DOITUONG_HOADON = CT_HOADON.Id;
                                ctDKInfo_1.KY_HIEU_HOADON = CT_HOADON.SoSeri;
                                ctDKInfo_1.MA_HOADON = CT_HOADON.SoHoadon;
                            }
                        }
                    }

                    //Lay CT_D tu CTD_K
                    List<CtD> lstCT_D = _ctdService.ListConvertCTDK2CTD(ctDKInfos);

                    // Dim ctDInfo As CT_DInfo = New CT_DInfo()
                    foreach (CtD ctDInfo in lstCT_D)
                    {
                        ctDInfo.SoDu = 0;
                        ctDInfo.PhanHe = 0;
                        if (ctDInfo.Id == Null.NullGuid)
                        {
                            ctDInfo.CthId = obj.Id;
                            _CtDDao.Save(ctDInfo);
                        }
                        else
                        {
                            _CtDDao.SaveOrUpdate(ctDInfo);
                        }

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
                        _CtHoadonDao.Delete(tmp);
                    }
                }

                //CT_DBO.Instance.DeleteAllCTDBYCTHID(del_lstobj_ct_d_k)
                foreach (CT_D_KInfo ctDKInfo in del_lstobj_ct_d_k)
                {
                    CtDDao.DeleteByCtH(ctDKInfo.CTH_ID, ctDKInfo.NHOM);

                    CtHoadon tmp = new CtHoadon();
                    tmp.Id = ctDKInfo.ID_DOITUONG_HOADON;
                    _CtHoadonDao.Delete(tmp);
                }
            }
            catch (Exception ex)
            {
                //Message_Error(ex);
            }
        }

        private Boolean CheckThue(CtD objCtD)
        {
            if (objCtD.Nhom == 1)
                return true;
            else
                return false;
        }

        public void SaveChungTuPhanBo(ref CtH _cthInfo, ref List<CtD> _lstctdInfo, ref List<KtThBtPhanbo> _lstctPhanBoNamInfo, decimal _month)
        {
            CtH objCth = _cthInfo;

            //Insert ct_phan bo nam
            if (_lstctPhanBoNamInfo != null)
            {
                //Xoa Cth cu va Insert Cth moi
                CtHDao.DeleteMa(objCth.IdLoaiCt, objCth.NgayCt.Value, objCth.DonviId);
                //objCth = CtHDao.Save( objCth);
                int i = 0;
                CtD objctd = default(CtD);
                _KtThBtPhanboDao.DeleteByThangNam(_lstctPhanBoNamInfo[0].Thang, _lstctPhanBoNamInfo[0].Nam, _cthInfo.DonviId);
                List<CtD> lstCtD = new List<CtD>();
                foreach (KtThBtPhanbo obj_all in _lstctPhanBoNamInfo)
                {
                    if ((obj_all.LoaiPhanbo <= 0))
                    {
                    }
                    else
                    {
                        objctd = new CtD();
                        objctd.CthId = objCth.Id;
                        i = i + 1;
                        objctd.Nhom = i;
                        if (obj_all.LoaiPhanbo == 1)
                        {
                            objctd.MaTkNo = obj_all.MaTkPhanbo;
                            objctd.MaTkCo = obj_all.MaTkDich;
                            objctd.TkNoId = obj_all.TkPhanboId;
                            objctd.TkCoId = obj_all.TkDichId;
                        }
                        else
                        {
                            objctd.MaTkCo = obj_all.MaTkPhanbo;
                            objctd.MaTkNo = obj_all.MaTkDich;
                            objctd.TkCoId = obj_all.TkPhanboId;
                            objctd.TkNoId = obj_all.TkDichId;
                        }
                        objctd.SoTien = obj_all.SoTienPb;
                        objctd.NoiDung = obj_all.MoTa;

                        //_CtDDao.Save(objctd);
                        lstCtD.Add(objctd);
                    }
                    if (VnsCheck.IsNullGuid(obj_all.Id))
                    {
                        obj_all.MaDonvi = Generals.DON_VI.MaDonvi;
                        _KtThBtPhanboDao.Save(obj_all);
                    }
                    else
                    {
                        _KtThBtPhanboDao.Save(obj_all);
                    }
                }
                SaveChungTuKeToan(true, ref _cthInfo, ref lstCtD);

            }

        }

        #region Search
        public IList<CtH> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5)
        {
            return CtHDao.SearchChungTu(DONVI_ID, MA_LOAI_CT, CT_SO_TU, CT_SO_DEN, NGAY_CT_TU, NGAY_CT_DEN, GHI, MA_KHANG,
                MA_TK_CO, MA_TK_NO, SO_TIEN_TU, SO_TIEN_DEN, NOI_DUNG, ID_DM_KHOANPHI,
                ID_DM_VUVIEC, ID_DM_HOPDONG, ID_DM_PHONGBAN,
                ID_DM_TUDO_1, ID_DM_TUDO_2, ID_DM_TUDO_3, ID_DM_TUDO_4, ID_DM_TUDO_5);
        }
        #endregion

        #region Asset
        //public void SaveChungTuKhauHao(Decimal Thang, Decimal Nam, Guid DonviId, CtH objCth, IList<CtD> lstCtD, IList<TsLsKhauhao> lstLsKhauHao)
        //{
 
        //}

        public void DeleteChungTuKhauHao(Decimal Thang, Decimal Nam, Guid DonviId, string MaLoaiCt)
        {
            
            DateTime NgayCt = new DateTime(Convert.ToInt32(Nam), Convert.ToInt32(Thang), 1);
            NgayCt = NgayCt.AddMonths(1).AddDays(-1);
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            IList<VnsOrder> orders = new List<VnsOrder>();
            props.Add("DonviId");
            values.Add(DonviId);
            props.Add("MaLoaiCt");
            values.Add(MaLoaiCt);
            props.Add("NgayCt");
            values.Add(NgayCt);
            IList<CtH> lst = List(-1, -1, props, values, null);

            if (lst.Count >0)
            {
                DeleteChungTu(lst[0], null);
            }
            
        }


        [Transaction]
        public Boolean DeleteChungTuCTH(CtH objCtH, IList<CtD> lstCtD,CtHoadon objHoaDon)
        {
            _BcKetoanDao.DeleteByChungTu(objCtH.Id, new Guid());
            if (lstCtD == null) lstCtD = new List<CtD>();

            if (objHoaDon != null)
            {
                _CtThueDao.DeleteByHoaDon(objHoaDon.Id);
                _CtHoadonDao.Delete(objHoaDon);
            }
            _CtDDao.DeleteByCtH(objCtH.Id);
            //Delete(objCtH);
            DeleteById(objCtH.Id);
            return true;
        }


        [Transaction]
        public Boolean DeleteChungTuCTHK(CtH objCtH, List<CT_D_KInfo> lstCTDK)
        {

           _BcKetoanDao.DeleteByChungTu(objCtH.Id, new Guid());

           foreach (CT_D_KInfo ctDKInfo in lstCTDK)
           {
               if (ctDKInfo.CT_HOADON != null)
               {
                   _CtThueDao.DeleteByHoaDon(ctDKInfo.CT_HOADON.Id );
                   _CtHoadonDao.Delete(ctDKInfo.CT_HOADON);
               }
           }
            _CtDDao.DeleteByCtH(objCtH.Id);
            //Delete(objCtH);
            DeleteById(objCtH.Id);
            return true;
        }


        #endregion

    }
}
