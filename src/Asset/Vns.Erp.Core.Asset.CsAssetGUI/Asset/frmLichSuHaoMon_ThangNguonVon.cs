using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.Reflection;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Accounting.Service.Interface;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmLichSuHaoMon_ThangNguonVon
    {

        #region variables

        //'list danh mục tai san co dinh

        private List<DmTscd> lst_DM_TSCD = new List<DmTscd>();
        //object info lich su hao mon

        private TsLsKhauhao obj_LS_HM;
        private List<TsLsKhauhao> lst_LS_HM = new List<TsLsKhauhao>();
        //list chứa tất cả tai san lich su khau hao da tinh

        private List<TsLsKhauhao> lst_fist_LS = new List<TsLsKhauhao>();
        //list chua lich su tai san da bi xoa

        private List<TsLsKhauhao> lst_del = new List<TsLsKhauhao>();
        //cờ nhan biet xem co xoa du lieu cu hay ko

        private bool flag = false;
        //phuong phap tinh khau hao la ntn(o day tinh theo tung thang)
        //true= khau hao  , false = khau hao theo thang
        private bool PP_Tinh = false;

        private Function_KH fn;
        //object info CT_H

        private CtH obj_CTH;
        //list CT_D

        private List<CtD> lst_CTD = new List<CtD>();
        private List<Guid> lst_del_cth = new List<Guid>();
        private string LOAI_CT;

        private List<Khau_hao_tung_thangInfo> lst_KH_Thang = new List<Khau_hao_tung_thangInfo>();

        List<Khau_hao_tung_thangInfo> lst_temp_kh_thang = new List<Khau_hao_tung_thangInfo>();

        private DateTime NGAY_TINH;
        //list khấu hao nguon

        private List<Ts_Ls_KhauHao_ThangNGuonVoninfo> lst_kh_thang_nguon = new List<Ts_Ls_KhauHao_ThangNGuonVoninfo>();

        private List<Khau_hao_tung_thangInfo> lst_del_khNguon = new List<Khau_hao_tung_thangInfo>();
        private List<DmTaikhoan> dt;
        //Quy định
        //'obj_LSHM.BAO_CAO=1(Tất cả cha) (Phục vụ báo cáo)
        //'obj_LSHM.CHITIET=1 (Con) (Phục vụ tính định khoản)
        //'Nếu không có chi tiết(ko được phân bổ theo nguồn vốn):obj_LSHM.BAO_CAO=obj_LSHM.CHITIET=1
        #endregion

        #region Property
        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private ITsLsKhauhaoService _TsLsKhauhaoService;
        public ITsLsKhauhaoService TsLsKhauhaoService
        {
            get { return _TsLsKhauhaoService; }
            set { _TsLsKhauhaoService = value; }
        }

        private ITsCtTscdNvonService _TsCtTscdNvonService;
        public ITsCtTscdNvonService TsCtTscdNvonService
        {
            get { return _TsCtTscdNvonService; }
            set { _TsCtTscdNvonService = value; }
        }

        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private ICtHService _CtHService;
        public ICtHService CtHService
        {
            get { return _CtHService; }
            set { _CtHService = value; }
        }

        private ICtDService _CtDService;
        public ICtDService CtDService
        {
            get { return _CtDService; }
            set { _CtDService = value; }
        }

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        private IDmNgoaiteService _DmNgoaiteService;
        public IDmNgoaiteService DmNgoaiteService
        {
            get { return _DmNgoaiteService; }
            set { _DmNgoaiteService = value; }
        }

        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }

        private IKtKhoasoThangService _KtKhoasoThangService;
        public IKtKhoasoThangService KtKhoasoThangService
        {
            get { return _KtKhoasoThangService; }
            set { _KtKhoasoThangService = value; }
        }
        #endregion

        #region private functions

        private void AddEvents()
        {
            KeyDown += frmLichSuHaoMon_ChiTiet_KeyDown;
            Load += frmLichSuHaoMon_ChiTiet_Load;
            _TreeList.CellValueChanged += _TreeList_CellValueChanged;
            _TreeList.FocusedNodeChanged += _TreeList_FocusedNodeChanged;
            btnSave.Click += btnSave_Click;
            btnXoa.Click += btnRod_Click;
            btnKHThang.Click += btnKHThang_Click;
            btnDINH_KHOAN.Click += btnDINH_KHOAN_Click;
            _Control.SelectedPageChanged += _Control_SelectedPageChanged;
            btnClose.Click += btnClose_Click;
            rpeMA_TK_CO.ClearDataFilter += MyRepositoryItem_CleanDFilter;
            rpeMA_TK_NO.ClearDataFilter += MyRepositoryItem_CleanDFilter;
            rpeMA_TK_CO.AfterFilter += MyRepositoryItem_AfterFilter;
            rpeMA_TK_NO.AfterFilter += MyRepositoryItem_AfterFilter;
            ckeHienThi.CheckedChanged += ckeHienThi_CheckedChanged;
            rpeMA_TK_CO.FisrtBinddata += rpeMA_TK_CO_FisrtBinddata;
            rpeMA_TK_NO.FisrtBinddata += rpeMA_TK_NO_FisrtBinddata;
        }

        public frmLichSuHaoMon_ThangNguonVon()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        ///' <summary>
        ///' Bind data vào cbo tk có và tk nợ
        ///' </summary>
        ///' <remarks></remarks>
        private void BindData()
        {
            dt = new List<DmTaikhoan>();
            dt.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
            lst_DM_TSCD = new List<DmTscd>();
            int TotalResult = 0;
            lst_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, out TotalResult));
        }

        private DmTaikhoan GetTen_TK(Guid TAI_KHOAN_ID)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.Id == TAI_KHOAN_ID)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }

        private DmTaikhoan GetTen_TK(string MaTaikhoan)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.MaTaikhoan == MaTaikhoan)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }

        /// <summary>
        /// Tính khấu hao cho TSCD
        /// </summary>
        /// <remarks></remarks>

        private void KHAU_HAO()
        {
            if ((ckeXoaDL.Checked))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            //Lấy ra ngày tính khấu hao ứng với tháng,năm nhập vào
            int p_year = 0;
            int p_month = 0;
            p_year = int.Parse(txtNAM.Text);
            p_month = int.Parse(txtTHANG.Text);

            NGAY_TINH = new DateTime(p_year, p_month, 1);

            fn = new Function_KH();
            fn.DmTscdService = _DmTscdService;
            fn.CtTscdService = _CtTscdService;
            //'List chứa vệt cuối của TSCD ứng với ngày tính khấu hao

            List<CtTscd> lst_vc_ct_tscd = new List<CtTscd>();

            lst_fist_LS.AddRange(_TsLsKhauhaoService.GetByThangNam(Generals.DON_VI.Id, NGAY_TINH.AddMonths(-1).Month, NGAY_TINH.AddMonths(-1).Year));
            lst_KH_Thang.Clear();
            lst_LS_HM.Clear();



            //'truong hop ghi de (tính mới từ đầu)
            if ((flag))
            {
                //lấy list dm_tscd
                //lst_DM_TSCD = _DmTscdService.GetObjectAllByDonviID(Generals.DON_VI.Id)
                //lay list vet cuoi
                lst_vc_ct_tscd = fn.Vet_Cuoi_CT_TSCD(NGAY_TINH, lst_DM_TSCD);

                //If lst_vc_ct_tscd.Count = 0 Then
                //    Exit Sub
                //End If
                //lấy ra CTH_ID
                //For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
                //    If Not VnsCheck.IsNullGuid(obj.CTH_ID) Then
                //        lst_del_cth.Add(obj.CTH_ID)
                //    End If
                //    obj.CTD_ID = Nothing
                //    obj.CTH_ID = Nothing
                //Next
                //tính lại khấu hao
                IList<Khau_hao_tung_thangInfo> lstTmp = new List<Khau_hao_tung_thangInfo>();
                foreach (CtTscd obj_VC in lst_vc_ct_tscd)
                {
                    obj_LS_HM = new TsLsKhauhao();
                    obj_LS_HM = fn.Khau_Hao_Tung_Thang(NGAY_TINH, obj_VC, PP_Tinh, lst_fist_LS);
                    if ((obj_LS_HM != null))
                    {
                        obj_LS_HM.BaoCao = 1;
                        obj_LS_HM.ChiTiet = 1;
                        lst_LS_HM.Add(obj_LS_HM);
                        obj_LS_HM.Id = Guid.NewGuid();
                        lstTmp.Add(new Khau_hao_tung_thangInfo(obj_LS_HM, obj_VC));
                    }
                }

                //Tính tiếp khấu hao theo nguồn vốn
                lst_KH_Thang = Khau_Hao_Nguon(new List<Khau_hao_tung_thangInfo>(lstTmp));
                //'truong hop khong ghi de(Tính tscd được thêm mới)
            }
            else
            {
                //tính khấu hao tscd ứng từ list vc tscd
                lst_KH_Thang = LoadTSCD(NGAY_TINH.Month, NGAY_TINH.Year);
                //list ts_ls_khauhao 
                //'truyen dc vet cuoi sang, lay dc ts_ls_khau_hao
                DmTscd obj_tscd = default(DmTscd);
                IList<DmTscd> not_define_tscd = new List<DmTscd>();

                //lấy ra những danh mục tài sản cố định chưa được tính khấu hao
                foreach (DmTscd tmpTSCD in lst_DM_TSCD)
                {
                    bool flg = true;
                    foreach (Khau_hao_tung_thangInfo obj_kh_thang in lst_KH_Thang)
                    {
                        if (tmpTSCD.Id == obj_kh_thang.DM_TSCD_ID)
                        {
                            flg = false;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                        else
                        {
                            flg = true;
                        }
                    }
                    if (flg)
                    {
                        not_define_tscd.Add(tmpTSCD);
                    }
                }


                //lấy vệt cuối tscd ứng với list dm tscd (lst_vc_ct_tscd)
                lst_vc_ct_tscd = fn.Vet_Cuoi_CT_TSCD(NGAY_TINH, new List<DmTscd>(not_define_tscd));

                //tính khấu hao với list vệt cuối
                List<Khau_hao_tung_thangInfo> lstTmp = new List<Khau_hao_tung_thangInfo>();
                foreach (CtTscd obj_VC in lst_vc_ct_tscd)
                {
                    obj_LS_HM = new TsLsKhauhao();
                    obj_LS_HM = fn.Khau_Hao_Tung_Thang(NGAY_TINH, obj_VC, PP_Tinh, lst_fist_LS);
                    if ((obj_LS_HM != null))
                    {
                        obj_LS_HM.BaoCao = 1;
                        obj_LS_HM.ChiTiet = 1;
                        lst_LS_HM.Add(obj_LS_HM);
                        obj_LS_HM.Id = Guid.NewGuid();
                        lstTmp.Add(new Khau_hao_tung_thangInfo(obj_LS_HM, obj_VC));
                    }
                }

                lstTmp = Khau_Hao_Nguon(lstTmp);

                lst_KH_Thang.AddRange(lstTmp);
            }

            if ((ckeXoaDL.Checked & obj_CTH != null))
            {
                obj_CTH = null;
                lst_CTD.Clear();
            }

            if ((ckeXoaDL.Checked))
            {

            }

            lst_temp_kh_thang.Clear();
            foreach (Khau_hao_tung_thangInfo obj_thang in lst_KH_Thang)
            {
                if ((obj_thang.HAO_MON_THANG != 0))
                {
                    lst_temp_kh_thang.Add(obj_thang);
                }
            }

            if ((ckeHienThi.Checked))
            {
                _TreeList.DataSource = lst_temp_kh_thang;
            }
            else
            {
                _TreeList.DataSource = lst_KH_Thang;
            }
            _TreeList.RefreshDataSource();
            grvDINH_KHOAN.RefreshData();
        }

        /// <summary>
        /// Khấu hao phân bổ theo nguồn
        /// </summary>
        /// <remarks></remarks>
        private List<Khau_hao_tung_thangInfo> Khau_Hao_Nguon(List<Khau_hao_tung_thangInfo> lstKhauHaoThang)
        {

            //'list_nguonvon ung voi TSCD
            List<TsCtTscdNvon> lst_Nguon = new List<TsCtTscdNvon>();
            //lấy giá trị list nguồn 
            lst_Nguon.AddRange(_TsCtTscdNvonService.GetAll());

            //list temp là list sau khi đã được phân bổ theo các nguồn vốn
            List<Khau_hao_tung_thangInfo> lst_temp_Nguon = new List<Khau_hao_tung_thangInfo>();

            lst_temp_Nguon = Tinh_khau_hao_nguon(lstKhauHaoThang, lst_Nguon, flag);
            //add list temp vào list all nguon
            foreach (Khau_hao_tung_thangInfo obj in lst_temp_Nguon)
            {
                lstKhauHaoThang.Add(obj);
            }

            return lstKhauHaoThang;
        }

        /// <summary>
        /// Tính khấu hao nguồn
        /// </summary>
        /// <param name="p_lst_KH_Thang"></param>
        /// <param name="p_lst_Nguon"></param>
        /// <param name="p_flag"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private List<Khau_hao_tung_thangInfo> Tinh_khau_hao_nguon(List<Khau_hao_tung_thangInfo> p_lst_KH_Thang, List<TsCtTscdNvon> p_lst_Nguon, bool p_flag)
        {
            Khau_hao_tung_thangInfo obj_kh_nguon = default(Khau_hao_tung_thangInfo);
            List<Khau_hao_tung_thangInfo> lst_temp = new List<Khau_hao_tung_thangInfo>();

            foreach (Khau_hao_tung_thangInfo obj_ts in p_lst_KH_Thang)
            {
                //Nếu không xóa dữ liệu cũ thì lấy từ CSDL lên
                //If Not p_flag Then
                //    lst_nguon_ID_cha = _TsLsKhauhaoService.GetByID_CHA(obj_ts.TS_LS_KHAUHAO_ID)
                //End If
                //Nếu ko xóa dữ liệu cũ mà chưa được tính thì tính tiếp
                //Nếu xóa dữ liệu cũ thì tính lại
                foreach (TsCtTscdNvon obj in p_lst_Nguon)
                {
                    if ((obj.CtTscdId == VnsConvert.CGuid(obj_ts.CT_TSCD_ID) & VnsCheck.IsNullGuid(obj_ts.ID_CHA)))
                    {
                        obj_ts.CHI_TIET = 0;
                        obj_kh_nguon = new Khau_hao_tung_thangInfo();
                        obj_kh_nguon.TS_LS_KHAUHAO_ID = Guid.NewGuid();
                        obj_kh_nguon.IS_INSERT = 1;
                        obj_kh_nguon.HE_SO = obj.HeSoPbKh;
                        obj_kh_nguon.DM_TSCD_ID = obj_ts.DM_TSCD_ID;
                        obj_kh_nguon.THANG = obj_ts.THANG;
                        obj_kh_nguon.NAM = obj_ts.NAM;
                        obj_kh_nguon.HAO_MON_THANG = obj_ts.HAO_MON_THANG * obj_kh_nguon.HE_SO / 100;
                        obj_kh_nguon.ID_CHA = obj_ts.TS_LS_KHAUHAO_ID;
                        obj_kh_nguon.CHI_TIET = 1;
                        obj_kh_nguon.BAO_CAO = 0;
                        obj_kh_nguon.CT_TSCD_ID = obj_ts.CT_TSCD_ID;
                        obj_kh_nguon.DONVI_ID = obj_ts.DONVI_ID;
                        obj_kh_nguon.MA_DONVI = obj_ts.MA_DONVI;
                        obj_kh_nguon.MA_TSCD = obj_ts.MA_TSCD;
                        obj_kh_nguon.TEN_TSCD = obj_ts.TEN_TSCD;
                        obj_kh_nguon.NGUON_VON_ID = obj.Id;
                        lst_temp.Add(obj_kh_nguon);
                    }
                }

            }
            return lst_temp;
        }

        /// <summary>
        /// Load TSCD và convert sang list object
        /// </summary>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private List<Khau_hao_tung_thangInfo> LoadTSCD(Int32 thang, Int32 nam)
        {
            List<TsLsKhauhao> dt = new List<TsLsKhauhao>();
            dt.AddRange(_TsLsKhauhaoService.GetByThangNam(Generals.DON_VI.Id, thang, nam));
            //dt = Nothing
            List<Khau_hao_tung_thangInfo> lst = new List<Khau_hao_tung_thangInfo>();
            //'convert datatable sang list
            Khau_hao_tung_thangInfo obj = default(Khau_hao_tung_thangInfo);
            lst.Clear();
            foreach (DmTscd dr in lst_DM_TSCD)
            {
                foreach (TsLsKhauhao tmp in dt)
                {
                    if ((tmp.DmTscdId == dr.Id))
                    {
                        obj = new Khau_hao_tung_thangInfo(tmp, dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        private bool Check_list(TsLsKhauhao obj, List<TsLsKhauhao> lst_All_LS)
        {
            bool bo = false;
            foreach (TsLsKhauhao obj_all in lst_All_LS)
            {
                if ((obj_all.CtTscdId == obj.CtTscdId & obj.Thang == obj_all.Thang & obj.Nam == obj_all.Nam))
                {
                    bo = true;
                }
            }
            return bo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        public bool Check_Input()
        {
            if ((string.IsNullOrEmpty(txtTHANG.Text)))
            {
                FormGlobals.Message_Information("Bạn chưa nhập tháng");
                txtTHANG.Focus();
                return false;
            }

            if ((decimal.Parse(txtTHANG.Text) > 12) | (decimal.Parse(txtTHANG.Text) <= 0))
            {
                FormGlobals.Message_Information("Tháng nhập vào không hợp lệ!");
                txtTHANG.Focus();
                return false;
            }

            if ((string.IsNullOrEmpty(txtNAM.Text)))
            {
                FormGlobals.Message_Information("bạn chưa nhập năm");
                txtNAM.Focus();
                return false;
            }
            else if ((decimal.Parse(txtNAM.Text) > 2999 | decimal.Parse(txtNAM.Text) < 2000))
            {
                FormGlobals.Message_Information("Năm nhập vào không hợp lệ!");
                txtNAM.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Save data vào CSDL
        /// </summary>
        /// <remarks></remarks>

        private void SaveData()
        {
            decimal Thang = VnsConvert.CDecimal(txtTHANG.Text);
            decimal Nam = VnsConvert.CDecimal(txtNAM.Text);
            System.DateTime lastdateofmonth = new System.DateTime((Int32)Nam, (Int32)Thang, 1);
            lastdateofmonth = lastdateofmonth.AddMonths(1).AddDays(-1);

            _CtHService.DeleteMa(obj_LoaiCT.Id, lastdateofmonth, Generals.DON_VI.Id);

            _TsLsKhauhaoService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam);

            //'insert, update CT_H
            if ((obj_CTH != null))
            {
                _CtHService.SaveChungTuKeToan(false, ref obj_CTH, ref lst_CTD);

                foreach (TsLsKhauhao obj in lst_LS_HM)
                {
                    if ((obj_CTH.NgayCt.Value.Year == obj.Nam & obj_CTH.NgayCt.Value.Month == obj.Thang & obj.ChiTiet == 1))
                    {
                        obj.CthId = obj_CTH.Id;
                    }
                }

                //'insert, update CTD
                foreach (CtD obj in lst_CTD)
                {
                    if ((obj.CthId == Null.NullGuid))
                    {
                        obj.CthId = obj_CTH.Id;
                    }
                    else
                    {
                    }
                }

                foreach (Khau_hao_tung_thangInfo obj in lst_KH_Thang)
                {
                    if (obj.CHI_TIET == 1)
                    {
                        obj.CTH_ID = obj_CTH.Id;
                    }
                }
            }


            //'chuyen tu list khau hao thang (Lst_kh_Thang)-> obj_ls_hm de luu vao csdl
            //lst_LS_HM.Clear()
            foreach (Khau_hao_tung_thangInfo obj in lst_KH_Thang)
            {
                if ((obj.HAO_MON_THANG != 0))
                {
                    obj_LS_HM = obj.GenTsLsKhauhao();
                    lst_LS_HM.Add(obj_LS_HM);

                    if (VnsCheck.IsNullGuid(obj_LS_HM.Id))
                    {
                        _TsLsKhauhaoService.Save(obj_LS_HM);
                        obj.IS_INSERT = 0;
                        obj.TS_LS_KHAUHAO_ID = obj_LS_HM.Id;
                    }
                    else
                    {
                        obj_LS_HM.NguoiSua = Generals.USER.Id;
                        _TsLsKhauhaoService.SaveOrUpdate(obj_LS_HM);
                    }
                }
            }
        }

        /// <summary>
        /// DELETE khấu hao tháng
        /// </summary>
        /// <remarks></remarks>
        private void Delete()
        {
            decimal Thang = VnsConvert.CDecimal(txtTHANG.Text);
            decimal Nam = VnsConvert.CDecimal(txtNAM.Text);
            _CtHService.DeleteChungTuKhauHao(Thang, Nam, Generals.DON_VI.Id, LOAI_CT);

            _TsLsKhauhaoService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam);

            lst_KH_Thang.Clear();
            //_TreeList.RefreshDataSource()
            _TreeList.DataSource = null;
            lst_CTD.Clear();
            grvDINH_KHOAN.RefreshData();
            obj_CTH = null;
        }

        HtLoaichungtu obj_LoaiCT = new HtLoaichungtu();
        /// <summary>
        /// ĐỊNH KHOẢN
        /// </summary>
        /// <remarks></remarks>
        private void DINH_KHOAN()
        {
            _Control.SelectedTabPage = xtrDINH_KHOAN;
            Guid don_vi_id = Generals.DON_VI.Id;
            CtD obj_CTD = default(CtD);

            //CT_H
            DateTime ngay_CT = new DateTime((Int32)txtNAM.EditValue, (Int32)txtTHANG.EditValue, 1).AddMonths(1).AddDays(-1);
            //obj_CTH = New CtH
            if (!flag)
            {
                obj_CTH = _CtHService.GetByLoaiChungTu(don_vi_id, LOAI_CT, ngay_CT);
            }

            if (obj_CTH == null)
            {
                obj_CTH = new CtH();
            }

            if ((VnsCheck.IsNullGuid(obj_CTH.Id)))
            {
                obj_CTH.NgayCt = ngay_CT;
                obj_CTH.NgayGhi = ngay_CT;
                obj_CTH.DonviId = don_vi_id;
                obj_CTH.NgayTao = System.DateTime.Now;
                obj_CTH.NgaySua = System.DateTime.Now;
                obj_CTH.MaDonvi = Generals.DON_VI.MaDonvi;

                obj_LoaiCT = _HtLoaichungtuService.GetByMA_LOAI_CT(LOAI_CT, Generals.DON_VI.Id);
                obj_CTH.IdLoaiCt = obj_LoaiCT.Id;
                obj_CTH.MaLoaiCt = obj_LoaiCT.MaLoaiCt;
                obj_CTH.KyHieuLoaiCt = obj_LoaiCT.KyHieu;
                obj_CTH.SoTienNte = 0;
                obj_CTH.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri);
                obj_CTH.MaNte = _DmNgoaiteService.GetById(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)).MaNte;
            }

            //CT_D
            lst_CTD.Clear();
            if ((VnsCheck.IsNullGuid(obj_CTH.Id)))
            {
                foreach (Khau_hao_tung_thangInfo obj in lst_KH_Thang)
                {
                    if ((obj.CHI_TIET == 1 & obj.HAO_MON_THANG > 0))
                    {
                        if ((obj.THANG == decimal.Parse(txtTHANG.Text) & obj.NAM == decimal.Parse(txtNAM.Text)))
                        {
                            obj_CTD = new CtD();

                            obj_CTD.SoTien = obj.HAO_MON_THANG;

                            //Lay tài khoản nợ (Tài khoản chi phí)
                            //Lay tai khoan co(tk khấu hao)
                            if (VnsCheck.IsNullGuid(obj.ID_CHA))
                            {
                                DmTscd obj_tscd = _DmTscdService.GetById(VnsConvert.CGuid(obj.DM_TSCD_ID));
                                DmTaikhoan dmno = GetTen_TK(obj_tscd.MdTkChiphi);
                                DmTaikhoan dmco = GetTen_TK(obj_tscd.MdTkKhauhao);
                                obj_CTD.TkNoId = dmno.Id;
                                obj_CTD.MaTkNo = dmno.MaTaikhoan;
                                obj_CTD.TenTkNo = dmno.TenTaikhoan;

                                obj_CTD.TkCoId = dmco.Id;
                                obj_CTD.TenTkCo = dmco.TenTaikhoan;
                                obj_CTD.MaTkCo = dmco.MaTaikhoan;
                            }
                            else
                            {
                                TsCtTscdNvon obj_tsnv = _TsCtTscdNvonService.GetById(VnsConvert.CGuid(obj.NGUON_VON_ID));
                                DmTaikhoan dmno = GetTen_TK(obj_tsnv.TkChiphi);
                                DmTaikhoan dmco = GetTen_TK(obj_tsnv.TkKhauhao);
                                obj_CTD.TkNoId = dmno.Id;
                                obj_CTD.MaTkNo = dmno.MaTaikhoan;
                                obj_CTD.TenTkNo = dmno.TenTaikhoan;

                                obj_CTD.TkCoId = dmco.Id;
                                obj_CTD.TenTkCo = dmco.TenTaikhoan;
                                obj_CTD.MaTkCo = dmco.MaTaikhoan;
                            }
                            obj_CTD.NoiDung = "CT khấu hao tháng " + obj.THANG.ToString() + " Năm " + obj.NAM.ToString() + " của TSCD: " + obj.TEN_TSCD.ToString();
                            obj_CTD.PhanHe = 4;

                            lst_CTD.Add(obj_CTD);
                        }

                    }
                }
            }
            else
            {
                lst_CTD.Clear();
                foreach (CtD tmp in obj_CTH.LstCtD)
                {
                    lst_CTD.Add(tmp);
                }
                //lst_CTD = obj_CTH.LstCtD
            }

            grcDINH_KHOAN.DataSource = lst_CTD;
            grvDINH_KHOAN.RefreshData();

            if (lst_CTD == null)
            {
                return;
            }

            decimal so_tien = 0;
            if (lst_CTD.Count > 0)
            {
                foreach (CtD obj in lst_CTD)
                {
                    if (obj != null)
                    {
                        so_tien = so_tien + obj.SoTien;
                    }
                }
            }

            obj_CTH.SoTien = so_tien;
        }

        #endregion

        #region Events

        private void frmLichSuHaoMon_ChiTiet_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                BindData();
                string para_str = this.AccessibleDescription;
                List<ParamInfo> lst_para = DataMining.GetParams(para_str);
                if (lst_para.Count > 0)
                {
                    LOAI_CT = lst_para[0].PARAMVALUE;
                }

                txtTHANG.Text = System.DateTime.Now.Month.ToString();
                txtNAM.Text = System.DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// Tính khấu hao 
        /// </summary>
        /// <remarks></remarks>
        private void btnTinh_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                PP_Tinh = true;
                if (Check_Input())
                {
                    frmProgress.Instance().Thread = KHAU_HAO;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Hoàn thành");
                    //"Data saved"
                    //load_LS_TSCD(DM_TSCD_ID)
                    _Control.SelectedTabPage = xtrLSHM;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void _TreeList_CellValueChanged(System.Object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            try
            {
                TsLsKhauhao obj_LT = new TsLsKhauhao();

                Khau_hao_tung_thangInfo obj_KH = (Khau_hao_tung_thangInfo)_TreeList.GetDataRecordByNode(e.Node);

                CtTscd obj_ct_TSCD = _CtTscdService.GetById(VnsConvert.CGuid(obj_KH.CT_TSCD_ID));

                if ((obj_ct_TSCD == null))
                {
                    return;
                }

                Int32 year_KH = obj_ct_TSCD.NgayBdKh.Value.Year;
                Int32 month_KH = obj_ct_TSCD.NgayBdKh.Value.Month;
                if ((obj_ct_TSCD.NgayBdKh.Value.Day < 15))
                {
                    obj_ct_TSCD.NgayBdKh = new DateTime(year_KH, month_KH, 1);
                }
                else
                {
                    obj_ct_TSCD.NgayBdKh = new DateTime(year_KH, month_KH, 1).AddMonths(1);
                }

                obj_LT = fn.LS_KH_First(new System.DateTime((Int32)obj_KH.NAM, (Int32)obj_KH.THANG, 1), obj_ct_TSCD, lst_fist_LS);

                try
                {
                    //Or e.Column.Name.Equals("HAO_MON_NAM") Or e.Column.Name.Equals("HAO_MON_LK") Or e.Column.Name.Equals("GIA_TRI_CL")) Then
                    if ((e.Column.Name.Equals("HAO_MON_THANG")))
                    {
                        if ((!string.IsNullOrEmpty(_TreeList.FocusedNode["HAO_MON_THANG"].ToString())))
                        {
                            decimal HMT = decimal.Parse(_TreeList.FocusedNode["HAO_MON_THANG"].ToString());
                            //If (obj_LT.CT_TSCD_ID IsNot Nothing) Then
                            foreach (Khau_hao_tung_thangInfo obj in lst_KH_Thang)
                            {
                                if ((obj.ID_CHA == VnsConvert.CGuid(TNCommon.TreeList_FocusKeyValue(_TreeList))))
                                {
                                    obj.HAO_MON_THANG = (Decimal)_TreeList.FocusedNode["HAO_MON_THANG"] * obj.HE_SO / 100;
                                }
                            }
                            _TreeList.FocusedNode.SetValue("HAO_MON_NAM", HMT * 12);
                            _TreeList.FocusedNode.SetValue("HAO_MON_LK", obj_LT.HaoMonLk + HMT);
                            if (obj_LT.GiaTriCl - HMT > 0)
                            {
                                _TreeList.FocusedNode.SetValue("GIA_TRI_CL", obj_LT.GiaTriCl - HMT);
                            }
                            else
                            {
                                _TreeList.FocusedNode.SetValue("GIA_TRI_CL", 0);
                            }
                            _TreeList.RefreshDataSource();
                        }
                        else
                        {
                            FormGlobals.Message_Warning("Giá trị hao mòn tháng không được trống");
                        }
                    }
                }
                catch (OverflowException ex)
                {
                    FormGlobals.Message_Warning("Giá trị nhập vào không hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void _TreeList_FocusedNodeChanged(System.Object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                Khau_hao_tung_thangInfo obj_KH = (Khau_hao_tung_thangInfo)_TreeList.GetDataRecordByNode(e.Node);
                if ((obj_KH != null))
                {
                    if (obj_KH.CHI_TIET == 1)
                    {
                        _TreeList.Columns["HAO_MON_THANG"].OptionsColumn.AllowEdit = true;
                    }
                    else
                    {
                        _TreeList.Columns["HAO_MON_THANG"].OptionsColumn.AllowEdit = false;
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private bool check_grid()
        {
            //Kiem tra ct_d hop le
            foreach (CtD obj in lst_CTD)
            {
                if ((obj.TkNoId == Null.NullGuid | obj.TkCoId == Null.NullGuid))
                {
                    FormGlobals.Message_Information("Bạn phải nhập đầy đủ tài khoản mới lưu được bút toán Khấu hao!");
                    _Control.SelectedTabPage = xtrDINH_KHOAN;
                    return false;
                }
            }

            foreach (Khau_hao_tung_thangInfo obj in lst_KH_Thang)
            {
                if (!LimitValue.CheckVNDCurrency(obj.HAO_MON_THANG) | obj.HAO_MON_THANG < 0)
                {
                    FormGlobals.Message_Warning("Giá trị hao mòn tháng không hợp lệ");
                    _Control.SelectedTabPage = xtrLSHM;
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {

            try
            {
                if (_KtKhoasoThangService.KiemTraKhoaSo(NGAY_TINH, Generals.DON_VI.Id))
                {
                    FormGlobals.Message_Warning("Tháng này đã được khóa sổ bạn không thể lưu dữ liệu!");
                    return;
                }

                if (_TreeList.Nodes.Count == 0)
                {
                    FormGlobals.Message_Warning("Không tồn tại bản ghi nào!");
                    return;
                }
                if (check_grid())
                {
                    frmProgress.Instance().Thread = SaveData;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Lưu dữ liệu thành công");
                    //"Data saved" 
                    flag = false;
                    ckeXoaDL.Checked = false;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmLichSuHaoMon_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnRod_Click(System.Object sender, System.EventArgs e)
        {
            try
            {

                if (_TreeList.Nodes.Count != 0)
                {
                    if (_KtKhoasoThangService.KiemTraKhoaSo(NGAY_TINH, Generals.DON_VI.Id))
                    {
                        FormGlobals.Message_Warning("Tháng này đã được khóa sổ bạn không thể xóa dữ liệu!");
                        return;
                    }

                    if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa tháng khấu hao này?"))
                    {
                        Delete();
                    }
                }
                else
                {
                    FormGlobals.Message_Warning("Không tồn tại bản ghi nào");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnKHThang_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                PP_Tinh = false;
                if (Check_Input())
                {
                    frmProgress.Instance().Thread = KHAU_HAO;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Hoàn thành");
                    //"Data saved"
                    //load_LS_TSCD(DM_TSCD_ID)
                    _Control.SelectedTabPage = xtrLSHM;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDINH_KHOAN_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (_TreeList.Nodes.Count == 0)
                {
                    FormGlobals.Message_Warning("Bạn phải tính khấu hao trước!");
                    return;
                }

                if (!Check_Input())
                {
                    return;
                }

                frmProgress.Instance().Thread = DINH_KHOAN;
                frmProgress.Instance().Show_Progress();
                frmProgress.Instance().SetFinishText("Hoàn thành");
            }
            catch (Exception ex)
            {
                //Message_Warning("Dữ liệu không hợp lệ đề nghị bạn xóa dữ liệu cũ và định khoản lại")
                FormGlobals.Message_Error(ex);
            }
        }

        private void _Control_SelectedPageChanged(System.Object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                switch (_Control.SelectedTabPageIndex)
                {
                    case 0:
                        btnXoa.Enabled = true;
                        break;
                    case 1:
                        btnXoa.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnClose_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void MyRepositoryItem_CleanDFilter(System.Object senders, System.EventArgs e)
        {
            CtD obj_grv_DINH_KHOAN = (CtD)grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle);
            int rowHandle = grvDINH_KHOAN.FocusedRowHandle;
            string columnName = grvDINH_KHOAN.FocusedColumn.Name;
            List<string> arr = new List<string>();
            switch (columnName)
            {
                case "MA_TK_NO":
                    arr = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES;
                    obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr[0]);
                    obj_grv_DINH_KHOAN.MaTkNo = arr[1];
                    obj_grv_DINH_KHOAN.TenTkNo = arr[2];
                    break;
                case "MA_TK_CO":
                    arr = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES;
                    obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr[0]);
                    obj_grv_DINH_KHOAN.MaTkCo = arr[1];
                    obj_grv_DINH_KHOAN.TenTkCo = arr[2];
                    break;
            }
        }

        private void MyRepositoryItem_AfterFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                CtD obj_grv_DINH_KHOAN = (CtD)grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle);
                int rowHandle = grvDINH_KHOAN.FocusedRowHandle;
                string columnName = grvDINH_KHOAN.FocusedColumn.Name;
                switch (columnName)
                {
                    case "MA_TK_NO":
                        List<string> arr = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES;
                        if ((arr.Count > 1))
                        {
                            //grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_NO", arr(2))
                            obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr[0]);
                            obj_grv_DINH_KHOAN.MaTkNo = arr[1];
                            obj_grv_DINH_KHOAN.TenTkNo = arr[2];
                            grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkNo", arr[1]);
                            SendKeys.Send("{TAB}");
                        }
                        break;
                    case "MA_TK_CO":
                        List<string> arr1 = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES;
                        if ((arr1.Count > 1))
                        {
                            //grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_CO", arr(2))
                            obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr1[0]);
                            obj_grv_DINH_KHOAN.MaTkCo = arr1[1];
                            obj_grv_DINH_KHOAN.TenTkCo = arr1[2];
                            grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkCo", arr1[1]);
                            SendKeys.Send("{TAB}");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void ckeHienThi_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if ((ckeHienThi.Checked))
                {
                    _TreeList.DataSource = lst_temp_kh_thang;
                }
                else
                {
                    _TreeList.DataSource = lst_KH_Thang;
                }
                _TreeList.RefreshDataSource();
                _Control.SelectedTabPage = xtrLSHM;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeMA_TK_CO_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                //rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt);
                rpeMA_TK_CO.Editors.A_DATA_SOURCE = rpeMA_TK_CO.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeMA_TK_NO_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                //rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt);
                rpeMA_TK_NO.Editors.A_DATA_SOURCE = rpeMA_TK_NO.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion


    }

    public class Ts_Ls_KhauHao_ThangNGuonVoninfo
    {

        #region "Private Variable"
        private string _TS_LS_KHAUHAO_ID;
        private Guid _DM_TSCD_ID;
        private string _TEN_TSCD;
        private string _MA_TSCD;
        private Guid _CT_TSCD_ID;
        private decimal _HAO_MON_LK;
        private decimal _HAO_MON_THANG;
        private decimal _HAO_MON_NAM;
        private decimal _NGUYEN_GIA;
        private decimal _GIA_TRI_CL;
        private decimal _THANG;
        private decimal _NAM;
        private Guid _DONVI_ID;
        private string _MA_DONVI;
        private Guid _CTD_ID;
        private Guid _CTH_ID;
        private DateTime _NGAY_TAO;
        private Guid _NGUOI_TAO;
        private DateTime _NGAY_SUA;
        private Guid _NGUOI_SUA;
        private Guid _ID_CHA;
        private decimal _HE_SO;
        private decimal _BAO_CAO;
        #endregion
        private decimal _CHI_TIET;

        #region "Property"

        public Guid CTH_ID
        {
            get { return _CTH_ID; }
            set { _CTH_ID = value; }
        }


        public string MA_TSCD
        {
            get { return _MA_TSCD; }
            set { _MA_TSCD = value; }
        }

        public string TEN_TSCD
        {
            get { return _TEN_TSCD; }
            set { _TEN_TSCD = value; }
        }


        public decimal CHI_TIET
        {
            get { return _CHI_TIET; }
            set { _CHI_TIET = value; }
        }

        public decimal BAO_CAO
        {
            get { return _BAO_CAO; }
            set { _BAO_CAO = value; }
        }

        public decimal HE_SO
        {
            get { return _HE_SO; }
            set { _HE_SO = value; }
        }

        public string TS_LS_KHAUHAO_ID
        {
            get { return _TS_LS_KHAUHAO_ID; }
            set { _TS_LS_KHAUHAO_ID = value; }
        }

        public Guid DM_TSCD_ID
        {
            get { return _DM_TSCD_ID; }
            set { _DM_TSCD_ID = value; }
        }

        public Guid CT_TSCD_ID
        {
            get { return _CT_TSCD_ID; }
            set { _CT_TSCD_ID = value; }
        }

        public decimal HAO_MON_LK
        {
            get { return _HAO_MON_LK; }
            set { _HAO_MON_LK = value; }
        }

        public decimal HAO_MON_THANG
        {
            get { return _HAO_MON_THANG; }
            set { _HAO_MON_THANG = value; }
        }

        public decimal HAO_MON_NAM
        {
            get { return _HAO_MON_NAM; }
            set { _HAO_MON_NAM = value; }
        }

        public decimal NGUYEN_GIA
        {
            get { return _NGUYEN_GIA; }
            set { _NGUYEN_GIA = value; }
        }

        public decimal GIA_TRI_CL
        {
            get { return _GIA_TRI_CL; }
            set { _GIA_TRI_CL = value; }
        }

        public decimal THANG
        {
            get { return _THANG; }
            set { _THANG = value; }
        }

        public decimal NAM
        {
            get { return _NAM; }
            set { _NAM = value; }
        }

        public Guid DONVI_ID
        {
            get { return _DONVI_ID; }
            set { _DONVI_ID = value; }
        }

        public string MA_DONVI
        {
            get { return _MA_DONVI; }
            set { _MA_DONVI = value; }
        }

        public Guid CTD_ID
        {
            get { return _CTD_ID; }
            set { _CTD_ID = value; }
        }

        public DateTime NGAY_TAO
        {
            get { return _NGAY_TAO; }
            set { _NGAY_TAO = value; }
        }

        public Guid NGUOI_TAO
        {
            get { return _NGUOI_TAO; }
            set { _NGUOI_TAO = value; }
        }

        public DateTime NGAY_SUA
        {
            get { return _NGAY_SUA; }
            set { _NGAY_SUA = value; }
        }

        public Guid NGUOI_SUA
        {
            get { return _NGUOI_SUA; }
            set { _NGUOI_SUA = value; }
        }

        public Guid ID_CHA
        {
            get { return _ID_CHA; }
            set { _ID_CHA = value; }
        }
        #endregion

        #region "Init Class"
        public Ts_Ls_KhauHao_ThangNGuonVoninfo()
        {
        }

        public Ts_Ls_KhauHao_ThangNGuonVoninfo(Khau_hao_tung_thangInfo obj)
        {
            // Me.TS_LS_KHAUHAO_ID = Guid.NewGuid().ToString().Replace("-", "").ToUpper
            this.DM_TSCD_ID = obj.DM_TSCD_ID;
            this.TEN_TSCD = obj.TEN_TSCD;
            this.MA_TSCD = obj.MA_TSCD;
            this.CT_TSCD_ID = obj.CT_TSCD_ID;
            this.HAO_MON_LK = obj.HAO_MON_LK;
            this.HAO_MON_THANG = obj.HAO_MON_THANG;
            this.HAO_MON_NAM = obj.HAO_MON_NAM;
            this.NGUYEN_GIA = obj.NGUYEN_GIA;
            this.GIA_TRI_CL = obj.GIA_TRI_CL;
            this.THANG = obj.THANG;
            this.NAM = obj.NAM;
            this.DONVI_ID = obj.DONVI_ID;
            this.MA_DONVI = obj.MA_DONVI;
            this.CTD_ID = obj.CTD_ID;
            this.NGAY_TAO = obj.NGAY_TAO.Value;
            this.NGUOI_TAO = obj.NGUOI_TAO;
            this.NGAY_SUA = obj.NGAY_SUA.Value;
            this.NGUOI_SUA = obj.NGUOI_SUA;
            this.ID_CHA = obj.ID_CHA;
            this.HE_SO = obj.HE_SO;
            this.BAO_CAO = obj.BAO_CAO;
            this.CHI_TIET = obj.CHI_TIET;
            this.CTH_ID = obj.CTH_ID;
        }

        public Ts_Ls_KhauHao_ThangNGuonVoninfo(TsCtTscdNvon obj)
        {
            this.TS_LS_KHAUHAO_ID = Guid.NewGuid().ToString();
            this.HE_SO = obj.HeSoPbKh;
        }
        #endregion

    }
}