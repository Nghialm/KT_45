using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Vns.Erp.Core.Accounting.Domain.Extend;
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtDService : GenericService<CtD, System.Guid>, ICtDService
    {
        #region Property

        public ICtDDao CtDDao
        {
            get { return (ICtDDao)Dao; }
            set { Dao = value; }
        }

        private IDmTkChitietDao _DmTkChitietDao;

        public IDmTkChitietDao DmTkChitietDao
        {
            get { return _DmTkChitietDao; }
            set { _DmTkChitietDao = value; }
        }

        private ICtHDao _CtHDao;

        public ICtHDao CtHDao
        {
            get { return _CtHDao; }
            set { _CtHDao = value; }
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
        public bool KiemTraChiTietDinhKhoan(ref string ErpMessage, CtD objValue)
        {
            IList<DmTkChitiet> _lstDMTKChiTiet = new List<DmTkChitiet>();
            IList<DmTkChitiet> _lstDMTKChiTietNO = new List<DmTkChitiet>();
            IList<DmTkChitiet> _lstDMTKChiTietCO = new List<DmTkChitiet>();

            //Kiem tra neu List da co du lieu
            _lstDMTKChiTietNO = _DmTkChitietDao.SelectAllListByTaiKhoanID(objValue.TkNoId);
            if (_lstDMTKChiTietNO == null)
            {
                _lstDMTKChiTietNO = new List<DmTkChitiet>();
            }

            _lstDMTKChiTietCO = _DmTkChitietDao.SelectAllListByTaiKhoanID(objValue.TkCoId);
            if (_lstDMTKChiTietCO == null)
            {
                _lstDMTKChiTietCO = new List<DmTkChitiet>();
            }

            foreach (DmTkChitiet _temp in _lstDMTKChiTietNO)
            {
                _lstDMTKChiTiet.Add(_temp);
            }

            foreach (DmTkChitiet _temp in _lstDMTKChiTietCO)
            {
                _lstDMTKChiTiet.Add(_temp);
            }

            foreach (DmTkChitiet _temp in _lstDMTKChiTiet)
            {
                if (!KiemTraChiTietDinhKhoan_ALL(_temp, objValue, ref ErpMessage))
                {
                    return false;
                }

                //KiemTraChiTietDinhKhoan(_temp, objValue, ErpMessage)
            }

            return true;
        }

        /// <summary>
        /// Kiem tra dieu kien (Chi can no hoac co co gia tri)
        /// </summary>
        /// <param name="objDK"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool KiemTraChiTietDinhKhoan_ALL(DmTkChitiet objDK, CtD objValue, ref string erpString)
        {
            if (objDK == null)
            {
                return true;
            }

            switch (objDK.DmLienquan)
            {
                case "DM_KHANG":
                    if ((objDK.BatBuoc == 1))
                    {
                        erpString = "Ma khach hang da duoc chon!";
                        return !(objValue.IdKhangNo == new Guid()) | !(objValue.IdKhangCo == new Guid());
                    }
                    break;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra dieu kien (Chinh xac theo doi tuong)
        /// </summary>
        /// <param name="objDK"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool KiemTraChiTietDinhKhoan(DmTkChitiet objDK, CtD objValue, ref string erpString)
        {
            if (objDK == null)
            {
                return true;
            }

            switch (objDK.DmLienquan)
            {
                case "DM_KHANG":
                    if ((objDK.BatBuoc == 1))
                    {
                        erpString = "KHANG";
                        return ((objDK.TaikhoanId == objValue.TkNoId) & !(objValue.IdKhangNo == new Guid()))
                            | ((objDK.TaikhoanId == objValue.TkCoId) & !(objValue.IdKhangCo == new Guid()));
                    }
                    break;
            }
            return true;
        }

        public IList<CtD> GetByCtHandNghiepVu(Guid CthId, Decimal LoaiNghiepVu)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CthId");
            values.Add(CthId);
            if (LoaiNghiepVu != -1)
            {
                props.Add("LoaiNghiepVu");
                values.Add(LoaiNghiepVu);
            }
            return List(-1, -1, props, values, null);
        }

        #region CtDK
        // Get Object CT_D_K All By DonviID
        public List<CT_D_KInfo> ConvertToCtDK(List<CtD> lstCTD)
        {
            List<CT_D_KInfo> lstCTDK = ListConvertCTD2CTDK(lstCTD);

            foreach (CT_D_KInfo ctDKInfo in lstCTDK)
            {
                if (ctDKInfo.LstCtThue == null)
                {
                    ctDKInfo.LstCtThue = new List<CtThue>();
                }
                if (ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) | ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri))
                {
                    IList<CtThue> lstCT_Thue = _CtThueDao.GetObjectbyCtHoaDon(ctDKInfo.ID_DOITUONG_HOADON);

                    if (lstCT_Thue.Count != 0)
                    {
                        foreach (CtThue ctThueInfo in lstCT_Thue)
                        {
                            if (ctDKInfo.MA_TK == ctThueInfo.MaTaikhoan)
                            {
                                ctDKInfo.LstCtThue.Add(ctThueInfo);
                            }
                        }
                    }

                    CtHoadon CT_HOADON = _CtHoadonDao.Get(ctDKInfo.ID_DOITUONG_HOADON);
                    if (CT_HOADON != null)
                    {
                        if (ctDKInfo.MA_TK != null)
                        {
                            ctDKInfo.CT_HOADON = CT_HOADON;
                        }
                    }
                }
            }
            return lstCTDK;
        }

        // Chuyển list ct_d sang ct_d_k
        public List<CT_D_KInfo> ListConvertCTD2CTDK(List<CtD> lstCTD)
        {
            List<CT_D_KInfo> lstCTDK = new List<CT_D_KInfo>();
            List<CT_D_KInfo> TempLstCTDK = new List<CT_D_KInfo>();
            foreach (CtD objCT_D in lstCTD)
            {
                // CT_D_K nợ
                CT_D_KInfo objCT_D_K_NO = new CT_D_KInfo();
                CT_D_KInfo objCT_D_K_CO = new CT_D_KInfo();
                CtD tmp = objCT_D;
                InfoConvertCTD2CTDK(ref tmp, ref objCT_D_K_NO, ref objCT_D_K_CO);
                // CT_D_K có
                lstCTDK.Add(objCT_D_K_NO);
                lstCTDK.Add(objCT_D_K_CO);
            }
            foreach (CT_D_KInfo ctDKInfo in lstCTDK)
            {
                if (TempLstCTDK.Count == 0)
                {
                    TempLstCTDK.Add(ctDKInfo);
                }
                else
                {
                    bool isTrue = false;
                    foreach (CT_D_KInfo dKInfo in TempLstCTDK)
                    {
                        if (Compare2CT_D_KInfo(ctDKInfo, dKInfo))
                        {
                            dKInfo.PS_NO = dKInfo.PS_NO + ctDKInfo.PS_NO;
                            dKInfo.PS_CO = dKInfo.PS_CO + ctDKInfo.PS_CO;
                            dKInfo.PS_NO_NT = dKInfo.PS_NO_NT + ctDKInfo.PS_NO_NT;
                            dKInfo.PS_CO_NT = dKInfo.PS_CO_NT + ctDKInfo.PS_CO_NT;
                            isTrue = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (isTrue == false)
                    {
                        TempLstCTDK.Add(ctDKInfo);
                    }
                }
            }
            return TempLstCTDK;
        }

        private void InfoConvertCTD2CTDK(ref CtD objCT_D, ref CT_D_KInfo p_ctd_k_no, ref CT_D_KInfo p_ctd_k_co)
        {
            //Chuyen thong tin tu CT_D sang 2 bien CT_D_K
            CT_D_KInfo objCT_D_K_NO = new CT_D_KInfo();
            CT_D_KInfo objCT_D_K_CO = new CT_D_KInfo();

            objCT_D_K_CO.CTD_ID = objCT_D.Id;
            objCT_D_K_CO.CTH_ID = objCT_D.CthId;

            //if (objCT_D.CtGhisoNgay != null)
            objCT_D_K_CO.CT_GHISO_NGAY = objCT_D.CtGhisoNgay;

            objCT_D_K_CO.CT_GHISO_TRICHYEU = objCT_D.CtGhisoTrichyeu;
            objCT_D_K_CO.ID_DOITUONG_HOADON = objCT_D.IdDoituongHoadon;
            objCT_D_K_CO.DA_GHISO = objCT_D.DaGhiso;
            objCT_D_K_CO.ID_CT_GHISO = objCT_D.IdCtGhiso;
            objCT_D_K_CO.ID_DM_HOPDONG = objCT_D.IdDmHopdongCo;
            objCT_D_K_CO.ID_DM_KHOANPHI = objCT_D.IdDmKhoanphiCo;
            objCT_D_K_CO.ID_DM_PHONGBAN = objCT_D.IdDmPhongbanCo;
            objCT_D_K_CO.ID_DM_PTQT = objCT_D.IdDmPtqtCo;
            objCT_D_K_CO.ID_DM_TUDO_1 = objCT_D.IdDmTudo1Co;
            objCT_D_K_CO.ID_DM_TUDO_2 = objCT_D.IdDmTudo2Co;
            objCT_D_K_CO.ID_DM_TUDO_3 = objCT_D.IdDmTudo3Co;
            objCT_D_K_CO.ID_DM_TUDO_4 = objCT_D.IdDmTudo4Co;
            objCT_D_K_CO.ID_DM_TUDO_5 = objCT_D.IdDmTudo5Co;
            objCT_D_K_CO.ID_DM_VUVIEC = objCT_D.IdDmVuviecCo;
            objCT_D_K_CO.ID_DOITUONG_1 = objCT_D.IdDoituong1;
            objCT_D_K_CO.ID_DOITUONG_2 = objCT_D.IdDoituong2;
            objCT_D_K_CO.ID_DOITUONG_3 = objCT_D.IdDoituong3;
            objCT_D_K_CO.ID_KHANG = objCT_D.IdKhangCo;
            objCT_D_K_CO.KY_HIEU_KHANG = objCT_D.KyHieuKhangCo;
            objCT_D_K_CO.KY_HIEU_HOPDONG = objCT_D.KyHieuHopdongCo;
            objCT_D_K_CO.KY_HIEU_VUVIEC = objCT_D.KyHieuVuviecCo;
            objCT_D_K_CO.LOAI_NGHIEP_VU = objCT_D.LoaiNghiepVu;
            objCT_D_K_CO.MA_CT_GHISO_SO = objCT_D.MaCtGhisoSo;
            objCT_D_K_CO.MA_DOITUONG_1 = objCT_D.MaDoituong1;
            objCT_D_K_CO.MA_DOITUONG_2 = objCT_D.MaDoituong2;
            objCT_D_K_CO.MA_DOITUONG_3 = objCT_D.MaDoituong3;
            objCT_D_K_CO.MA_HOPDONG = objCT_D.MaHopdongCo;
            objCT_D_K_CO.MA_KHANG = objCT_D.MaKhangCo;
            objCT_D_K_CO.MA_TK = objCT_D.MaTkCo;
            objCT_D_K_CO.MA_VUVIEC = objCT_D.MaVuviecCo;
            objCT_D_K_CO.NHOM = objCT_D.Nhom;
            objCT_D_K_CO.NOI_DUNG = objCT_D.NoiDung;
            objCT_D_K_CO.PS_CO = objCT_D.SoTien;
            objCT_D_K_CO.PS_CO_NT = objCT_D.SoTienNte;
            objCT_D_K_CO.TEN_DOITUONG_1 = objCT_D.TenDoituong1;
            objCT_D_K_CO.TEN_DOITUONG_2 = objCT_D.TenDoituong2;
            objCT_D_K_CO.TEN_DOITUONG_3 = objCT_D.TenDoituong3;
            objCT_D_K_CO.TEN_HOPDONG = objCT_D.TenHopdongCo;
            objCT_D_K_CO.TEN_TK = objCT_D.TenTkCo;
            objCT_D_K_CO.TK_ID = objCT_D.TkCoId;
            objCT_D_K_CO.TEN_KHANG = objCT_D.TenKhangCo;
            p_ctd_k_co = objCT_D_K_CO;


            objCT_D_K_NO.CTD_ID = objCT_D.Id;
            objCT_D_K_NO.CTH_ID = objCT_D.CthId;
            objCT_D_K_NO.CT_GHISO_NGAY = objCT_D.CtGhisoNgay;
            objCT_D_K_NO.CT_GHISO_TRICHYEU = objCT_D.CtGhisoTrichyeu;
            objCT_D_K_NO.DA_GHISO = objCT_D.DaGhiso;
            objCT_D_K_NO.ID_DOITUONG_HOADON = objCT_D.IdDoituongHoadon;
            objCT_D_K_NO.ID_CT_GHISO = objCT_D.IdCtGhiso;
            objCT_D_K_NO.ID_DM_HOPDONG = objCT_D.IdDmHopdongNo;
            objCT_D_K_NO.ID_DM_KHOANPHI = objCT_D.IdDmKhoanphiNo;
            objCT_D_K_NO.ID_DM_PHONGBAN = objCT_D.IdDmPhongbanNo;
            objCT_D_K_NO.ID_DM_PTQT = objCT_D.IdDmPtqtNo;
            objCT_D_K_NO.ID_DM_TUDO_1 = objCT_D.IdDmTudo1No;
            objCT_D_K_NO.ID_DM_TUDO_2 = objCT_D.IdDmTudo2No;
            objCT_D_K_NO.ID_DM_TUDO_3 = objCT_D.IdDmTudo3No;
            objCT_D_K_NO.ID_DM_TUDO_4 = objCT_D.IdDmTudo4No;
            objCT_D_K_NO.ID_DM_TUDO_5 = objCT_D.IdDmTudo5No;
            objCT_D_K_NO.ID_DM_VUVIEC = objCT_D.IdDmVuviecNo;
            objCT_D_K_NO.ID_DOITUONG_1 = objCT_D.IdDoituong1;
            objCT_D_K_NO.ID_DOITUONG_2 = objCT_D.IdDoituong2;
            objCT_D_K_NO.ID_DOITUONG_3 = objCT_D.IdDoituong3;
            objCT_D_K_NO.ID_KHANG = objCT_D.IdKhangNo;
            objCT_D_K_NO.KY_HIEU_KHANG = objCT_D.KyHieuKhangNo;
            objCT_D_K_NO.KY_HIEU_HOPDONG = objCT_D.KyHieuHopdongNo;
            objCT_D_K_NO.KY_HIEU_VUVIEC = objCT_D.KyHieuVuviecNo;
            objCT_D_K_NO.LOAI_NGHIEP_VU = objCT_D.LoaiNghiepVu;
            objCT_D_K_NO.MA_CT_GHISO_SO = objCT_D.MaCtGhisoSo;
            objCT_D_K_NO.MA_DOITUONG_1 = objCT_D.MaDoituong1;
            objCT_D_K_NO.MA_DOITUONG_2 = objCT_D.MaDoituong2;
            objCT_D_K_NO.MA_DOITUONG_3 = objCT_D.MaDoituong3;
            objCT_D_K_NO.MA_HOPDONG = objCT_D.MaHopdongNo;
            objCT_D_K_NO.MA_KHANG = objCT_D.MaKhangNo;
            objCT_D_K_NO.MA_TK = objCT_D.MaTkNo;
            objCT_D_K_NO.MA_VUVIEC = objCT_D.MaVuviecNo;
            objCT_D_K_NO.NHOM = objCT_D.Nhom;
            objCT_D_K_NO.NOI_DUNG = objCT_D.NoiDung;
            objCT_D_K_NO.PS_NO = objCT_D.SoTien;
            objCT_D_K_NO.PS_NO_NT = objCT_D.SoTienNte;
            objCT_D_K_NO.TEN_DOITUONG_1 = objCT_D.TenDoituong1;
            objCT_D_K_NO.TEN_DOITUONG_2 = objCT_D.TenDoituong2;
            objCT_D_K_NO.TEN_DOITUONG_3 = objCT_D.TenDoituong3;
            objCT_D_K_NO.TEN_HOPDONG = objCT_D.TenHopdongNo;
            objCT_D_K_NO.TEN_TK = objCT_D.TenTkNo;
            objCT_D_K_NO.TK_ID = objCT_D.TkNoId;
            objCT_D_K_NO.TEN_KHANG = objCT_D.TenKhangNo;
            p_ctd_k_no = objCT_D_K_NO;

        }

        public List<List<CT_D_KInfo>> GetLstNhom(List<CT_D_KInfo> lstCTDK)
        {

            List<List<CT_D_KInfo>> lstNhom = new List<List<CT_D_KInfo>>();
            foreach (CT_D_KInfo ctDKInfo in lstCTDK)
            {
                if (lstNhom.Count == 0)
                {
                    List<CT_D_KInfo> nhom = new List<CT_D_KInfo>();
                    nhom.Add(ctDKInfo);
                    lstNhom.Add(nhom);
                }
                else
                {
                    bool isTrue = false;
                    foreach (List<CT_D_KInfo> inhom in lstNhom)
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
                        List<CT_D_KInfo> nhom = new List<CT_D_KInfo>();
                        nhom.Add(ctDKInfo);
                        lstNhom.Add(nhom);
                    }
                }
            }
            return lstNhom;
        }

        public int Count_tk_thue(List<CT_D_KInfo> lstCTDK)
        {
            int count = 0;

            foreach (CT_D_KInfo obj_ctk in lstCTDK)
            {
                if (obj_ctk.MA_TK == null)
                {
                    obj_ctk.MA_TK = "";
                }

                if ((obj_ctk.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) | (obj_ctk.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)))
                {
                    count = count + 1;
                }
            }

            return count;
        }

        public bool CheckValidateCTDK(List<CT_D_KInfo> lstCTDK, bool save)
        {
            int i = 0;
            bool check = false;
            int countC = 0;
            int countN = 0;
            decimal PSNO = 0;
            decimal PSCO = 0;
            decimal PSNO_NT = 0;
            decimal PSCO_NT = 0;
            string ID_TK_NO = "";
            string ID_TK_CO = "";

            //Lay list chua tung list nhom
            List<List<CT_D_KInfo>> lstNhom = GetLstNhom(lstCTDK);
            foreach (List<CT_D_KInfo> lstCTDKBYNHOM in lstNhom)
            {
                countC = 0;
                countN = 0;
                PSNO = 0;
                PSCO = 0;
                PSNO_NT = 0;
                PSCO_NT = 0;
                ID_TK_NO = "";
                ID_TK_CO = "";
                i = 0;
                for (int j = 0; j <= lstCTDKBYNHOM.Count - 1; j++)
                {
                    //check nhap tai khoan no/co
                    if (VnsCheck.IsNullGuid(lstCTDKBYNHOM[j].TK_ID))
                    {
                        //Message_Warning("Bạn chưa nhập đủ định khoản!");
                        return false;
                    }

                    //Kiem tra list thue neu co tai khoan la tai khoan thue
                    if (lstCTDKBYNHOM[j].MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) | lstCTDKBYNHOM[j].MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri))
                    {
                        i = i + 1;

                        if (lstCTDKBYNHOM[j].LstCtThue == null)
                        {
                            check = false;
                        }
                        else
                        {
                            if (lstCTDKBYNHOM[j].LstCtThue.Count == 0)
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }
                        }
                    }

                    //If (i = 1) And Not check Then
                    //    Message_Warning("Bạn chưa nhập thuế GTGT đầu vào!")
                    //    Return False
                    //End If

                    //Check tai khoan co khac tai khoan no
                    //Check truong hop trong cung mot nhom co cac dong du lieu giong nhau
                    if (!Check_id_tai_khoan(lstCTDKBYNHOM[j], lstCTDKBYNHOM[j].PS_NO, lstCTDKBYNHOM, j))
                    {
                        return false;
                    }

                    //check truong hop nhieu no nhieu co
                    if (lstCTDKBYNHOM[j].PS_CO != 0 | lstCTDKBYNHOM[j].PS_CO_NT != 0)
                    {
                        countC = countC + 1;
                        PSCO = PSCO + lstCTDKBYNHOM[j].PS_CO;
                        PSCO_NT = PSCO_NT + lstCTDKBYNHOM[j].PS_CO_NT;
                    }
                    if (lstCTDKBYNHOM[j].PS_NO != 0 | lstCTDKBYNHOM[j].PS_NO_NT != 0)
                    {
                        countN = countN + 1;
                        PSNO = PSNO + lstCTDKBYNHOM[j].PS_NO;
                        PSNO_NT = PSNO_NT + lstCTDKBYNHOM[j].PS_NO_NT;
                    }
                }

                if ((i == 1) & !check)
                {
                    //Message_Warning("Bạn chưa nhập thuế GTGT đầu vào!");
                    return false;
                }

                if (save == true)
                {
                    if (PSNO != PSCO | PSNO_NT != PSCO_NT)
                    {
                        //Message_Warning("Tổng PS nợ và tổng PS có trong cùng một nhóm phải bằng nhau");
                        return false;
                    }
                    if (countC > 1 & countN > 1)
                    {
                        //Message_Warning("Trong cùng một nhóm chỉ có một PS nợ nhiều PS có hoặc một PS có nhiều PS nợ");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Check_id_tai_khoan(CT_D_KInfo obj_ctdk, decimal PS_NO, List<CT_D_KInfo> lst, int j)
        {
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                if (PS_NO == 0)
                {
                    if (lst[i].PS_CO == 0)
                    {
                        if (lst[i].TK_ID == obj_ctdk.TK_ID)
                        {
                            //Message_Warning("Trong 1 nhóm tài khoản nợ phải khác tài khoản có và ngược lại!");
                            return false;
                        }
                    }
                }
                else
                {
                    if (lst[i].PS_NO == 0)
                    {
                        if (lst[i].TK_ID == obj_ctdk.TK_ID)
                        {
                            //Message_Warning("Trong 1 nhóm tài khoản nợ phải khác tài khoản có và ngược lại!");
                            return false;
                        }
                    }
                }

                if (j != i)
                {
                    if (Compare2CT_D_KInfo(obj_ctdk, lst[i]))
                    {
                        //Message_Warning("Dữ liệu nhóm " + lst[i].NHOM + " trùng nhau, vui lòng kiểm tra lại!");
                        return false;
                    }
                }

            }
            return true;
        }

        private bool Compare2CT_D_KInfo(CT_D_KInfo ctDKDich, CT_D_KInfo ctDKNguon)
        {
            //Return true neu cac danh muc & ben phas sinh giong nhau
            //Return false neu cac danh muc & ben phas sinh khac nhau

            return false;

            if (ctDKDich.ID_DM_HOPDONG == ctDKNguon.ID_DM_HOPDONG & ctDKDich.ID_DM_KHOANPHI == ctDKNguon.ID_DM_KHOANPHI
                & ctDKDich.ID_DM_PHONGBAN == ctDKNguon.ID_DM_PHONGBAN & ctDKDich.ID_DM_PTQT == ctDKNguon.ID_DM_PTQT
                & ctDKDich.ID_DM_TUDO_1 == ctDKNguon.ID_DM_TUDO_1 & ctDKDich.ID_DM_TUDO_2 == ctDKNguon.ID_DM_TUDO_2
                & ctDKDich.ID_DM_TUDO_3 == ctDKNguon.ID_DM_TUDO_3 & ctDKDich.ID_DM_TUDO_4 == ctDKNguon.ID_DM_TUDO_4
                & ctDKDich.ID_DM_TUDO_5 == ctDKNguon.ID_DM_TUDO_5 & ctDKDich.ID_DM_VUVIEC == ctDKNguon.ID_DM_VUVIEC
                & ctDKDich.ID_DOITUONG_1 == ctDKNguon.ID_DOITUONG_1 & ctDKDich.ID_DOITUONG_2 == ctDKNguon.ID_DOITUONG_2
                & ctDKDich.ID_DOITUONG_3 == ctDKNguon.ID_DOITUONG_3 & ctDKDich.ID_KHANG == ctDKNguon.ID_KHANG
                & ctDKDich.NHOM == ctDKNguon.NHOM & ctDKDich.TK_ID == ctDKNguon.TK_ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public List<CtD> ListConvertCTDK2CTD(List<CT_D_KInfo> lstCTDK)
        {
            List<CtD> lstTempCTD = new List<CtD>();
            List<List<CT_D_KInfo>> lstNhom = GetLstNhom(lstCTDK);
            foreach (List<CT_D_KInfo> lstCTDKBYNHOM in lstNhom)
            {
                int c = 0;
                int n = 0;
                foreach (CT_D_KInfo ctDKInfo in lstCTDKBYNHOM)
                {
                    if (ctDKInfo.PS_CO != 0 | ctDKInfo.PS_CO_NT != 0)
                    {
                        c = c + 1;
                    }
                    if (ctDKInfo.PS_NO != 0 | ctDKInfo.PS_NO_NT != 0)
                    {
                        n = n + 1;
                    }
                }
                //CT_D_K 1'
                //Truong hop 1:1: gan No TempCTDK; Gan Co vao list
                //Truong hop 1:n or n:1 nhu nhau
                CT_D_KInfo TempCTDK = new CT_D_KInfo();
                //List CTD_K n
                List<CT_D_KInfo> lstTempCTDK = new List<CT_D_KInfo>();

                if (c == n)
                {
                    foreach (CT_D_KInfo ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PS_NO != 0 | ctDKInfo.PS_NO_NT != 0)
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
                    foreach (CT_D_KInfo ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PS_NO != 0 | ctDKInfo.PS_NO_NT != 0)
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
                    foreach (CT_D_KInfo ctDKInfo in lstCTDKBYNHOM)
                    {
                        if (ctDKInfo.PS_CO != 0 | ctDKInfo.PS_CO_NT != 0)
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
                foreach (CT_D_KInfo ctDKInfo in lstTempCTDK)
                {
                    CtD TempctDInfo = new CtD();
                    TempctDInfo = InfoConvertCTDK2CTD(TempCTDK, TempctDInfo);
                    TempctDInfo = InfoConvertCTDK2CTD(ctDKInfo, TempctDInfo);
                    lstTempCTD.Add(TempctDInfo);
                }
            }
            return lstTempCTD;
        }

        //Kiem tra xem ben n co bi trung ID khong
        //Neu trung thi thuc hien doi ID cho ben 1
        private List<CT_D_KInfo> Check_id_CTDK(List<CT_D_KInfo> lst, CT_D_KInfo obj_1n)
        {
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                if (!VnsCheck.IsNullGuid(lst[i].CTD_ID))
                {
                    for (int j = 0; j <= lst.Count - 1; j++)
                    {
                        if (i != j)
                        {
                            if (lst[i].CTD_ID == lst[j].CTD_ID)
                            {
                                Guid str = lst[j].CTD_ID;
                                lst[j].CTD_ID = obj_1n.CTD_ID;
                                obj_1n.CTD_ID = str;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                }
            }
            return lst;
        }

        private CtD InfoConvertCTDK2CTD(CT_D_KInfo objct_d_k, CtD objct_d)
        {
            CtD ctd = objct_d;
            //Truyen gia tri vao tu p1 sang ctd
            //2 Truong hop:
            //1:PS No
            //2:PS Co
            //3:PS No = PS Co = 0
            if (objct_d_k.PS_CO != 0 | objct_d_k.PS_CO_NT != 0)
            {
                objct_d.Id = objct_d_k.CTD_ID;
                objct_d.CthId = objct_d_k.CTH_ID;
                objct_d.CtGhisoNgay = objct_d_k.CT_GHISO_NGAY;
                objct_d.CtGhisoTrichyeu = objct_d_k.CT_GHISO_TRICHYEU;
                objct_d.DaGhiso = objct_d_k.DA_GHISO;
                objct_d.IdCtGhiso = objct_d_k.ID_CT_GHISO;
                objct_d.IdDmHopdongCo = objct_d_k.ID_DM_HOPDONG;
                objct_d.IdDmKhoanphiCo = objct_d_k.ID_DM_KHOANPHI;
                objct_d.IdDmPhongbanCo = objct_d_k.ID_DM_PHONGBAN;
                objct_d.IdDmPtqtCo = objct_d_k.ID_DM_PTQT;
                objct_d.IdDmTudo1Co = objct_d_k.ID_DM_TUDO_1;
                objct_d.IdDmTudo2Co = objct_d_k.ID_DM_TUDO_2;
                objct_d.IdDmTudo3Co = objct_d_k.ID_DM_TUDO_3;
                objct_d.IdDmTudo4Co = objct_d_k.ID_DM_TUDO_4;
                objct_d.IdDmTudo5Co = objct_d_k.ID_DM_TUDO_5;
                objct_d.IdDmVuviecCo = objct_d_k.ID_DM_VUVIEC;
                objct_d.IdDoituong1 = objct_d_k.ID_DOITUONG_1;
                objct_d.IdDoituong2 = objct_d_k.ID_DOITUONG_2;
                objct_d.IdDoituong3 = objct_d_k.ID_DOITUONG_3;
                objct_d.IdKhangCo = objct_d_k.ID_KHANG;
                objct_d.KyHieuKhangCo = objct_d_k.KY_HIEU_KHANG;
                objct_d.KyHieuHopdongCo = objct_d_k.KY_HIEU_HOPDONG;
                objct_d.KyHieuVuviecCo = objct_d_k.KY_HIEU_VUVIEC;
                objct_d.LoaiNghiepVu = objct_d_k.LOAI_NGHIEP_VU;
                objct_d.MaCtGhisoSo = objct_d_k.MA_CT_GHISO_SO;
                objct_d.MaDoituong1 = objct_d_k.MA_DOITUONG_1;
                objct_d.MaDoituong2 = objct_d_k.MA_DOITUONG_2;
                objct_d.MaDoituong3 = objct_d_k.MA_DOITUONG_3;
                objct_d.MaHopdongCo = objct_d_k.MA_HOPDONG;
                objct_d.MaKhangCo = objct_d_k.MA_KHANG;
                objct_d.MaTkCo = objct_d_k.MA_TK;
                objct_d.MaVuviecCo = objct_d_k.MA_VUVIEC;
                objct_d.Nhom = objct_d_k.NHOM;
                objct_d.NoiDung = objct_d_k.NOI_DUNG;
                objct_d.SoTien = objct_d_k.PS_CO;
                objct_d.SoTienNte = objct_d_k.PS_CO_NT;
                objct_d.TenDoituong1 = objct_d_k.TEN_DOITUONG_1;
                objct_d.TenDoituong2 = objct_d_k.TEN_DOITUONG_2;
                objct_d.TenDoituong3 = objct_d_k.TEN_DOITUONG_3;
                objct_d.TenHopdongCo = objct_d_k.TEN_HOPDONG;
                objct_d.TenTkCo = objct_d_k.TEN_TK;
                objct_d.TkCoId = objct_d_k.TK_ID;
                objct_d.TenKhangCo = objct_d_k.TEN_KHANG;
                //objct_d.ID_DOITUONG_HOADON = objct_d_k.ID_DOITUONG_HOADON
                //objct_d.MA_HOADON = objct_d_k.MA_HOADON
                //objct_d.KY_HIEU_HOADON = objct_d_k.KY_HIEU_HOADON
                objct_d.MaRo = objct_d_k.MA_RO;
                objct_d.TenRo = objct_d_k.TEN_RO;
                objct_d.PhanHe = objct_d_k.PHAN_HE;
                objct_d.Bx1 = objct_d_k.BX_1;
                objct_d.Bx2 = objct_d_k.BX_2;
                objct_d.Bx3 = objct_d_k.BX_3;
            }
            else if (objct_d_k.PS_NO != 0 | objct_d_k.PS_NO_NT != 0)
            {
                objct_d.Id = objct_d_k.CTD_ID;
                objct_d.CthId = objct_d_k.CTH_ID;
                objct_d.CtGhisoNgay = objct_d_k.CT_GHISO_NGAY;
                objct_d.CtGhisoTrichyeu = objct_d_k.CT_GHISO_TRICHYEU;
                objct_d.DaGhiso = objct_d_k.DA_GHISO;
                objct_d.IdCtGhiso = objct_d_k.ID_CT_GHISO;
                objct_d.IdDmHopdongNo = objct_d_k.ID_DM_HOPDONG;
                objct_d.IdDmKhoanphiNo = objct_d_k.ID_DM_KHOANPHI;
                objct_d.IdDmPhongbanNo = objct_d_k.ID_DM_PHONGBAN;
                objct_d.IdDmPtqtNo = objct_d_k.ID_DM_PTQT;
                objct_d.IdDmTudo1No = objct_d_k.ID_DM_TUDO_1;
                objct_d.IdDmTudo2No = objct_d_k.ID_DM_TUDO_2;
                objct_d.IdDmTudo3No = objct_d_k.ID_DM_TUDO_3;
                objct_d.IdDmTudo4No = objct_d_k.ID_DM_TUDO_4;
                objct_d.IdDmTudo5No = objct_d_k.ID_DM_TUDO_5;
                objct_d.IdDmVuviecNo = objct_d_k.ID_DM_VUVIEC;
                objct_d.IdDoituong1 = objct_d_k.ID_DOITUONG_1;
                objct_d.IdDoituong2 = objct_d_k.ID_DOITUONG_2;
                objct_d.IdDoituong3 = objct_d_k.ID_DOITUONG_3;
                objct_d.IdKhangNo = objct_d_k.ID_KHANG;
                objct_d.KyHieuKhangNo = objct_d_k.KY_HIEU_KHANG;
                objct_d.KyHieuHopdongNo = objct_d_k.KY_HIEU_HOPDONG;
                objct_d.KyHieuVuviecNo = objct_d_k.KY_HIEU_VUVIEC;
                objct_d.LoaiNghiepVu = objct_d_k.LOAI_NGHIEP_VU;
                objct_d.MaCtGhisoSo = objct_d_k.MA_CT_GHISO_SO;
                objct_d.MaDoituong1 = objct_d_k.MA_DOITUONG_1;
                objct_d.MaDoituong2 = objct_d_k.MA_DOITUONG_2;
                objct_d.MaDoituong3 = objct_d_k.MA_DOITUONG_3;
                objct_d.MaHopdongNo = objct_d_k.MA_HOPDONG;
                objct_d.MaKhangNo = objct_d_k.MA_KHANG;
                objct_d.MaTkNo = objct_d_k.MA_TK;
                objct_d.MaVuviecNo = objct_d_k.MA_VUVIEC;
                objct_d.Nhom = objct_d_k.NHOM;
                objct_d.NoiDung = objct_d_k.NOI_DUNG;
                objct_d.SoTien = objct_d_k.PS_NO;
                objct_d.SoTienNte = objct_d_k.PS_NO_NT;
                objct_d.TenDoituong1 = objct_d_k.TEN_DOITUONG_1;
                objct_d.TenDoituong2 = objct_d_k.TEN_DOITUONG_2;
                objct_d.TenDoituong3 = objct_d_k.TEN_DOITUONG_3;
                objct_d.TenHopdongNo = objct_d_k.TEN_HOPDONG;
                objct_d.TenTkNo = objct_d_k.TEN_TK;
                objct_d.TkNoId = objct_d_k.TK_ID;
                objct_d.TenKhangNo = objct_d_k.TEN_KHANG;
                //objct_d.ID_DOITUONG_HOADON = objct_d_k.ID_DOITUONG_HOADON
                //objct_d.MA_HOADON = objct_d_k.MA_HOADON
                //objct_d.KY_HIEU_HOADON = objct_d_k.KY_HIEU_HOADON
                objct_d.MaRo = objct_d_k.MA_RO;
                objct_d.TenRo = objct_d_k.TEN_RO;
                objct_d.PhanHe = objct_d_k.PHAN_HE;
                objct_d.Bx1 = objct_d_k.BX_1;
                objct_d.Bx2 = objct_d_k.BX_2;
                objct_d.Bx3 = objct_d_k.BX_3;
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
            if (!VnsCheck.IsNullGuid(objct_d_k.ID_DOITUONG_HOADON))
            {
                objct_d.IdDoituongHoadon = objct_d_k.ID_DOITUONG_HOADON;
                objct_d.MaHoadon = objct_d_k.MA_HOADON;
                objct_d.KyHieuHoadon = objct_d_k.KY_HIEU_HOADON;
            }
            return objct_d;
        }
        #endregion

        


    }
}
