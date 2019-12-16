using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Vns.Erp.Core.Accounting.Domain.Extend;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;
using DevExpress.Utils;

using Vns.Erp.Core;
using Vns.Erp.Core.Controls.Commons;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmPhieuNhapKho_ChiTiet
    {

        #region "Property"

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private IDmKhoService _DmKhoService;
        public IDmKhoService DmKhoService
        {
            get { return _DmKhoService; }
            set { _DmKhoService = value; }
        }

        private IDmVuviecService _DmVuviecService;
        public IDmVuviecService DmVuviecService
        {
            get { return _DmVuviecService; }
            set { _DmVuviecService = value; }
        }

        private IDmPtqtService _DmPtqtService;
        public IDmPtqtService DmPtqtService
        {
            get { return _DmPtqtService; }
            set { _DmPtqtService = value; }
        }

        private IDmTudo1Service _DmTudo1Service;
        public IDmTudo1Service DmTudo1Service
        {
            get { return _DmTudo1Service; }
            set { _DmTudo1Service = value; }
        }

        private IDmTudo2Service _DmTudo2Service;
        public IDmTudo2Service DmTudo2Service
        {
            get { return _DmTudo2Service; }
            set { _DmTudo2Service = value; }
        }

        private IDmTudo3Service _DmTudo3Service;
        public IDmTudo3Service DmTudo3Service
        {
            get { return _DmTudo3Service; }
            set { _DmTudo3Service = value; }
        }

        private IDmTudo4Service _DmTudo4Service;
        public IDmTudo4Service DmTudo4Service
        {
            get { return _DmTudo4Service; }
            set { _DmTudo4Service = value; }
        }

        private IDmTudo5Service _DmTudo5Service;
        public IDmTudo5Service DmTudo5Service
        {
            get { return _DmTudo5Service; }
            set { _DmTudo5Service = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private IDmKhoanphiService _DmKhoanphiService;
        public IDmKhoanphiService DmKhoanphiService
        {
            get { return _DmKhoanphiService; }
            set { _DmKhoanphiService = value; }
        }

        private IDmHopdongService _DmHopdongService;
        public IDmHopdongService DmHopdongService
        {
            get { return _DmHopdongService; }
            set { _DmHopdongService = value; }
        }

        private ICtHNxService _CtHNxService;
        public ICtHNxService CtHNxService
        {
            get { return _CtHNxService; }
            set { _CtHNxService = value; }
        }

        private ICtDNxService _CtDNxService;
        public ICtDNxService CtDNxService
        {
            get { return _CtDNxService; }
            set { _CtDNxService = value; }
        }

        private IHtSoChungtuMaxService _HtSoChungtuMaxService;
        public IHtSoChungtuMaxService HtSoChungtuMaxService
        {
            get { return _HtSoChungtuMaxService; }
            set { _HtSoChungtuMaxService = value; }
        }

        private IKtKhoasoThangService _KtKhoasoThangService;
        public IKtKhoasoThangService KtKhoasoThangService
        {
            get { return _KtKhoasoThangService; }
            set { _KtKhoasoThangService = value; }
        }

        private IDmHanghoaService _DmHanghoaService;
        public IDmHanghoaService DmHanghoaService
        {
            get { return _DmHanghoaService; }
            set { _DmHanghoaService = value; }
        }

        private IDmKhangService _DmKhangService;
        public IDmKhangService DmKhangService
        {
            get { return _DmKhangService; }
            set { _DmKhangService = value; }
        }

        private IDmNgoaiteService _DmNgoaiteService;
        public IDmNgoaiteService DmNgoaiteService
        {
            get { return _DmNgoaiteService; }
            set { _DmNgoaiteService = value; }
        }


        private ISxLenhsanxuatService _SxLenhsanxuatService;
        public ISxLenhsanxuatService SxLenhsanxuatService
        {
            get { return _SxLenhsanxuatService; }
            set { _SxLenhsanxuatService = value; }
        }

        private ILsTygiaService _LsTygiaService;
        public ILsTygiaService LsTygiaService
        {
            get { return _LsTygiaService; }
            set { _LsTygiaService = value; }
        }
        #endregion

        #region "Variables and Messages"
        List<DmTaikhoan> lstTk = new List<DmTaikhoan>();


        public frmPhieuNhapKho_ChiTiet()
        {
            InitializeComponent();

            FormClosed += frmPhieuNhapKho_ChiTiet_FormClosed;
            KeyDown += frmPhieuNhapKho_ChiTiet_KeyDown;
            TNCommon.setIconControl(this);

            //Validate control
            FormHelper.RequireInputControls = new Control[] {
			dteNGAY_CT,
			dteNGAY_GHI
		        };
            FormHelper.ApplyRequireInputValidate(FormHelper.RequireInputControls);
            if (UR_STATUS == null)
            {
                UR_STATUS = new Controls.UserControl.Status_LoaiCT();
            }
            UR_STATUS.LCT_STATUS = objLoaiChungTu.Id;
            UR_STATUS.Visible = Generals.Ts_PheDuyetChungTu;
            UR_STATUS.Enabled = Generals.Ts_PheDuyetChungTu;
        }

        /// <summary>
        ///  khai bao 1 obj de Set,Get data tren form cua bang CT_H_NX va insert,update
        /// </summary>
        /// <remarks></remarks>

        private CtHNx obj_ct_h_nx = new CtHNx();
        /// <summary>
        /// khai bao 1 list obj de chua cac obj la cac record trong bang CT_D_NX dung de su ly insert,update
        /// </summary>
        /// <remarks></remarks>

        private List<CtDNx> lstobj_ct_d_nx = new List<CtDNx>();
        /// <summary>
        /// khai bao 1 list obj chua cac record delete cua bang CT_D_NX
        /// </summary>
        /// <remarks></remarks>

        private List<CtDNx> del_lstobj_ct_d_nx = new List<CtDNx>();
        /// <summary>
        /// khai bao bien kieu truyen vao cua trang thai tu ben list
        /// </summary>
        /// <remarks></remarks>

        private FormGlobals.DataInputState m_InputState;
        /// <summary>
        /// khao bao bien chua ID dung de load du lieu cho bang duoi theo ID bang tren
        /// </summary>
        /// <remarks></remarks>

        Guid CTHNXID;
        /// <summary>
        /// khai bao 1 bien chua ID de truyen sang form chi tiet de xu ly
        /// </summary>
        /// <remarks></remarks>

        Guid mCTHNXID;
        /// <summary>
        /// khai bao bien chua ma loai chung tu truyen vao tu form list
        /// </summary>
        /// <remarks></remarks>

        string m_Ma_Loai_CT;
        /// <summary>
        /// khai bao 1 kieu obj de su dung lay ma loai chung tu tuong ung ung voi loai phieu,xet trang thai cho cac cot tren luoi
        /// </summary>
        /// <remarks></remarks>

        public HtLoaichungtu obj_lct = new HtLoaichungtu();
        /// <summary>
        /// khai bao 1 bien luu ten form
        /// </summary>
        /// <remarks></remarks>

        private string m_setText;
        /// <summary>
        /// khai bao 1 list obj chua list obj da dc conver
        /// </summary>
        /// <remarks></remarks>
        private List<CT_H_GInfo> lstobj_ct_h_gg = new List<CT_H_GInfo>();
        private bool closeForm = false;
        private HtLoaichungtu objLoaiChungTu = new HtLoaichungtu();
        //DataTable Hang Hoa
        private DataTable Kry_DATASOURE;
        //DataTable Tai khoan
        private DataTable Ji_DATASOURE;
        //Bien xac dinh thoi diem load ty gia ngoai te
        private Boolean OnLoadData = false;
        string msgKhoaSo = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!";

        string msgTTChungTu = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!";
        #endregion

        #region "Load Form"
        private DmTaikhoan GetByMa(List<DmTaikhoan> lst, string MaTk)
        {
            if (lst == null) return null;
            foreach (DmTaikhoan tmp in lst)
            {
                if (tmp.MaTaikhoan == MaTk) return tmp;
            }
            return null;
        }
        /// <summary>
        /// xu ly khi load form
        /// </summary>
        /// <param name="ID_CT"></param>
        /// <param name="eState"></param>
        /// <param name="Ten_Loai_CT"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool Show_Form(Guid ID_CT, string Ma_Loai_CT, string Ten_Loai_CT, List<CT_H_GInfo> lstCTH_G, Vns.Erp.Core.FormGlobals.DataInputState eState)
        {
            try
            {
                grvLPX_Hnx.Columns["Ghi"].Visible = Generals.Ts_PheDuyetChungTu;
                objLoaiChungTu = _HtLoaichungtuService.GetByMA_LOAI_CT(Ma_Loai_CT, Generals.DON_VI.Id);
                lstTk = new List<DmTaikhoan>(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
                //xet loai phieu de hien thi cot kho tren luoi            
                if (objLoaiChungTu.KhoXuat == 1)
                {
                    grvPhieuNhapKho.Columns["KhoXuatId"].Visible = true;
                    grvPhieuNhapKho.Columns["KhoNhapId"].Visible = false;
                    grvPhieuNhapKho.Columns["PhanXuongXuatId"].Visible = true;
                    grvPhieuNhapKho.Columns["PhanXuongNhapId"].Visible = false;
                    grvPhieuNhapKho.Columns["LenhSanXuatXuatId"].Visible = true;
                    grvPhieuNhapKho.Columns["LenhSanXuatNhapId"].Visible = false;
                    grvPhieuNhapKho.Columns["MaTknGiavon"].Visible = false;
                    grvPhieuNhapKho.Columns["MaTkcGiavon"].Visible = false;
                    grvPhieuNhapKho.Columns["DonGiaVonNte"].Visible = false;
                    grvPhieuNhapKho.Columns["GiaVonNt"].Visible = false;
                    grvPhieuNhapKho.Columns["DonGiaVon"].Visible = false;
                    grvPhieuNhapKho.Columns["GiaVon"].Visible = false;

                    

                    DmTaikhoan tmp = GetByMa(lstTk, objLoaiChungTu.MaTkNoLq);
                    GFilter_TK.Text = objLoaiChungTu.MaTkNoLq;
                    GFilter_TK.Tag = tmp.Id;

                    lblTK.Text = "TK nợ";
                    lblHDPN.Visible = false;
                    lblNgayHDPN.Visible = false;
                    txtHDPN.Visible = false;
                    dteHDPN.Visible = false;
                }
                else
                {
                    grvPhieuNhapKho.Columns["KhoXuatId"].Visible = false;
                    grvPhieuNhapKho.Columns["KhoNhapId"].Visible = true;
                    grvPhieuNhapKho.Columns["PhanXuongXuatId"].Visible = false;
                    grvPhieuNhapKho.Columns["PhanXuongNhapId"].Visible = true;
                    grvPhieuNhapKho.Columns["LenhSanXuatXuatId"].Visible = false;
                    grvPhieuNhapKho.Columns["LenhSanXuatNhapId"].Visible = true;
                    grvPhieuNhapKho.Columns["MaTkcGiavon"].Visible = false;
                    grvPhieuNhapKho.Columns["MaTknGiavon"].Visible = false;
                    grvPhieuNhapKho.Columns["DonGiaVonNte"].Visible = false;
                    grvPhieuNhapKho.Columns["GiaVonNt"].Visible = false;
                    grvPhieuNhapKho.Columns["DonGiaVon"].Visible = false;
                    grvPhieuNhapKho.Columns["GiaVon"].Visible = false;
                    lblTK.Text = "TK có";

                    DmTaikhoan tmp = GetByMa(lstTk, objLoaiChungTu.MaTkCoLq);
                    GFilter_TK.Text = objLoaiChungTu.MaTkCoLq;
                    GFilter_TK.Tag = tmp.Id;
                }

                if (lstCTH_G != null)
                {
                    lstobj_ct_h_gg = lstCTH_G;
                }

                mCTHNXID = ID_CT;
                m_Ma_Loai_CT = Ma_Loai_CT;

                m_setText = Ten_Loai_CT;
                //hien thi ten header form theo loai phieu va xet cac icon cho nut            
                //TNCommon.setIconControl(Me)
                FormGlobals.Form_SetText(this, Ten_Loai_CT, eState);
                FormGlobals.Form_InitDialog(this);
                //dat cac truong not null
                //Control_SetRequire(grlKHANG_ID, True)
                //Control_SetRequire(dteNGAY_GHI, True)

                // gan cho bien trang thai form dang xu ly
                m_InputState = eState;

                // goi khoi xu ly form
                frmProgress.Instance().Thread = InitForm;
                frmProgress.Instance().Show_Progress();
                grvLPX_Hnx.FocusedRowChanged += grvLPX_Hnx_FocusedRowChanged;

                if (closeForm == true)
                {
                    FormGlobals.Message_Warning(ConstantMsgs.MSG_ALERT_FOR_RECENT_DELETE);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    return true;
                }
                else
                {
                    return (this.ShowDialog() == System.Windows.Forms.DialogResult.OK);
                }


            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
                return false;
            }
        }
        #endregion

        #region "Private Function and Procedures"

        /// <summary>
        /// khoi xu ly form
        /// </summary>
        /// <remarks></remarks>
        private void InitForm()
        {
            try
            {
                //
                InitControl();
                // 
                InitData();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// khoi xu ly control 
        /// </summary>
        /// <remarks></remarks>
        private void InitControl()
        {
            //
            BindLoookUpNX();

        }

        /// <summary>
        /// khoi xu ly data tren form
        /// </summary>
        /// <remarks></remarks>
        private void InitData()
        {
            try
            {
                OnLoadData = true;
                switch (m_InputState)
                {

                    case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:

                        // dat gia tri mac dinh khi them moi
                        // goi ham xu ly cac control trong form
                        DatTrangThaiControl();

                        //gan gia tri cho combox
                        grlLoaiPhieuNhap.EditValue = obj_lct.MaLoaiCt;

                        //gan 1 list obj
                        // lstobj_ct_d_nx.Add(New CtDNx())

                        //bind list obj len luoi
                        grcPhieuPhapKho.DataSource = lstobj_ct_d_nx;

                        //gan tri mac dinh cho o text , o chon ngay thang , ty gia ,gia tri mac dinh combobox ma ngoai te
                        //txtGHI.Text = "1"                    
                        //txtTY_GIA.Text = 1                    
                        SetVisible();
                        //txtCT_SO.Text = Nothing
                        //txtCT_SO.Properties.ReadOnly = True
                        ClearPage();
                        ConfigGrid.GridConfig(this.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT, grvPhieuNhapKho.Name, grvPhieuNhapKho);

                        break;
                    case Vns.Erp.Core.FormGlobals.DataInputState.EditMode:
                        DatTrangThaiControl();
                        //goi ham load data theo gia tri truyen vao trang thai la Edit
                        SetObjectToControl();
                        //TongTien()
                        SetVisible();
                        break;
                }
                Load_Grid(lstobj_ct_h_gg);

            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
            OnLoadData = false;
        }

        /// <summary>
        /// ham xu ly load form danh sach
        /// </summary>
        /// <remarks></remarks>

        private void Load_Grid(List<CT_H_GInfo> lstobj_ct_h_gg)
        {
            if (lstobj_ct_h_gg != null & lstobj_ct_h_gg.Count > 0)
            {
                grcLPN_Hnx.DataSource = lstobj_ct_h_gg;
                for (int i = 0; i <= lstobj_ct_h_gg.Count - 1; i++)
                {
                    if (mCTHNXID == lstobj_ct_h_gg[i].Id)
                    {
                        this.grvLPX_Hnx.FocusedRowHandle = i;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

        }

        /// <summary>
        /// bind data vao comobox
        /// </summary>
        /// <remarks></remarks>

        private DmNgoaite TienTienNoiTe = null;
        private void BindLoookUpNX()
        {

            //Kry_DATASOURE = DM_HanghoaBO.Instance.GetAllByDonviID(Generals.DON_VI.DONVI_ID).Tables(0)
            Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));


            //GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
            //GFilter.C_DATA_SOURCE = DM_KhangBO.Instance().GetAllBy_CO_SU_DUNG_DS(Generals.DON_VI.Id).Tables(0)

            // Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
            //Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
            // Bind loại chứng từ
            List<HtLoaichungtu> listLCTu = new List<HtLoaichungtu>();
            listLCTu.AddRange(_HtLoaichungtuService.GetByDonvi(Generals.DonviID));
            grlLoaiPhieuNhap.Properties.DataSource = listLCTu;
            grlLoaiPhieuNhap.Properties.DisplayMember = "KyHieu";
            grlLoaiPhieuNhap.Properties.ValueMember = "MaLoaiCt";

            //Bind ngoai te
            TienTienNoiTe = _DmNgoaiteService.Get(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri));
            //List<DmNgoaite> lstNgoaite = new List<DmNgoaite>();
            //lstNgoaite.AddRange(_DmNgoaiteService.GetAll());
            //cboTyGia.Properties.DisplayMember = "KyHieu";
            //cboTyGia.Properties.ValueMember = "Id";
            //cboTyGia.Properties.DataSource = lstNgoaite;
            //cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri);
            //txtTY_GIA.Text = "1";

            //Bind TK No
            //lstTk = new List<DmTaikhoan>();
            //lstTk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
            //cboTKno.DataSource = lstTKNo;
            //cboTKno.DisplayMember = "MaTaikhoan";
            //cboTKno.ValueMember = "Id";
            //cboTKno.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            //cboTKno.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));

            ////Bind TK Có
            //List<DmTaikhoan> lstTKCo = new List<DmTaikhoan>();
            //lstTKCo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
            //cboTKco.DataSource = lstTKCo;
            //cboTKco.DisplayMember = "MaTaikhoan";
            //cboTKco.ValueMember = "Id";
            //cboTKco.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            //cboTKco.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));

            //'Bind mã kho nhap
            List<DmKho> lstMaKho = new List<DmKho>();
            lstMaKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id));
            cboMaKho.DataSource = lstMaKho;
            cboMaKho.DisplayMember = "KyHieu";
            cboMaKho.ValueMember = "Id";
            cboMaKho.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboMaKho.Columns.Add(new LookUpColumnInfo("TenKho", "Tên kho"));

            //'Bind mã kho xuat
            List<DmKho> lstMaKhoXuat = new List<DmKho>();
            lstMaKhoXuat.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id));
            cboMakhoxuat.DataSource = lstMaKhoXuat;
            cboMakhoxuat.DisplayMember = "KyHieu";
            cboMakhoxuat.ValueMember = "Id";
            cboMakhoxuat.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboMakhoxuat.Columns.Add(new LookUpColumnInfo("TenKho", "Tên kho"));

            //Bind vụ việc
            List<DmVuviec> lstVuViecTemp = new List<DmVuviec>();
            lstVuViecTemp.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmVuviec> lstVuviec = new List<DmVuviec>();
            DmVuviec objvuviec = new DmVuviec();
            lstVuviec.Add(objvuviec);
            lstVuviec.AddRange(lstVuViecTemp);
            cboVuViec.DataSource = lstVuviec;
            cboVuViec.DisplayMember = "KyHieu";
            cboVuViec.ValueMember = "Id";
            cboVuViec.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboVuViec.Columns.Add(new LookUpColumnInfo("TenVuviec", "Tên vụ việc"));

            //Bind PTQT
            List<DmPtqt> lstPTQTTemp = new List<DmPtqt>();
            lstPTQTTemp.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmPtqt> lstPTQT = new List<DmPtqt>();
            DmPtqt objPTQT = new DmPtqt();
            lstPTQT.Add(objPTQT);
            lstPTQT.AddRange(lstPTQTTemp);
            cboPTQT.DataSource = lstPTQT;
            cboPTQT.DisplayMember = "KyHieu";
            cboPTQT.ValueMember = "Id";
            cboPTQT.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã PTQT"));
            cboPTQT.Columns.Add(new LookUpColumnInfo("TenPtqt", "Tên PTQT"));

            //Bind tu do1
            List<DmTudo1> lsttudo1Temp = new List<DmTudo1>();
            lsttudo1Temp.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmTudo1> lsttudo1 = new List<DmTudo1>();
            DmTudo1 objTudo1 = new DmTudo1();
            lsttudo1.Add(objTudo1);
            lsttudo1.AddRange(lsttudo1Temp);
            cboTudo1.DataSource = lsttudo1;
            cboTudo1.DisplayMember = "KyHieu";
            cboTudo1.ValueMember = "Id";
            cboTudo1.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã tự do 1"));
            cboTudo1.Columns.Add(new LookUpColumnInfo("TenDmTudo1", "Tên danh mục 1"));

            //Bind tu do 2
            List<DmTudo2> lsttudo2Temp = new List<DmTudo2>();
            lsttudo2Temp.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmTudo2> lsttudo2 = new List<DmTudo2>();
            DmTudo2 objTudo2 = new DmTudo2();
            lsttudo2.Add(objTudo2);
            lsttudo2.AddRange(lsttudo2Temp);
            cboTudo2.DataSource = lsttudo2;
            cboTudo2.DisplayMember = "KyHieu";
            cboTudo2.ValueMember = "Id";
            cboTudo2.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã tự do 2"));
            cboTudo2.Columns.Add(new LookUpColumnInfo("TenDmTudo2", "Tên danh mục 2"));

            //Bind tu do 3
            List<DmTudo3> lsttudo3Temp = new List<DmTudo3>();
            lsttudo3Temp.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmTudo3> lsttudo3 = new List<DmTudo3>();
            DmTudo3 objtudo3 = new DmTudo3();
            lsttudo3.Add(objtudo3);
            lsttudo3.AddRange(lsttudo3Temp);
            cboTudo3.DataSource = lsttudo3;
            cboTudo3.DisplayMember = "KyHieu";
            cboTudo3.ValueMember = "Id";
            cboTudo3.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã tự do 3"));
            cboTudo3.Columns.Add(new LookUpColumnInfo("TenDmTudo3", "Tên danh mục 3"));

            //Bind tu do 4
            List<DmTudo4> lsttudo4Temp = new List<DmTudo4>();
            lsttudo4Temp.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmTudo4> lsttudo4 = new List<DmTudo4>();
            DmTudo4 objtudo4 = new DmTudo4();
            lsttudo4.Add(objtudo4);
            lsttudo4.AddRange(lsttudo4Temp);
            cboTudo4.DataSource = lsttudo4;
            cboTudo4.DisplayMember = "KyHieu";
            cboTudo4.ValueMember = "Id";
            cboTudo4.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã tự do 4"));
            cboTudo4.Columns.Add(new LookUpColumnInfo("TenDmTudo4", "Tên danh mục 4"));

            //Bind tu do 5
            List<DmTudo5> lsttudo5Temp = new List<DmTudo5>();
            lsttudo5Temp.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmTudo5> lsttudo5 = new List<DmTudo5>();
            DmTudo5 objtudo5 = new DmTudo5();
            lsttudo5.Add(objtudo5);
            lsttudo5.AddRange(lsttudo5Temp);
            cboTudo5.DataSource = lsttudo5;
            cboTudo5.DisplayMember = "KyHieu";
            cboTudo5.ValueMember = "Id";
            cboTudo5.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã tự do 5"));
            cboTudo5.Columns.Add(new LookUpColumnInfo("TenDmTudo5", "Tên danh mục 5"));

            //Bind phong ban 
            List<DmPhongban> lstPhongBanTemp = new List<DmPhongban>();
            lstPhongBanTemp.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmPhongban> lstPhongBan1 = new List<DmPhongban>();
            DmPhongban objphongban = new DmPhongban();
            lstPhongBan1.Add(objphongban);
            lstPhongBan1.AddRange(lstPhongBanTemp);
            cboPhongban.DataSource = lstPhongBan1;
            cboPhongban.DisplayMember = "KyHieu";
            cboPhongban.ValueMember = "Id";
            cboPhongban.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã phòng ban"));
            cboPhongban.Columns.Add(new LookUpColumnInfo("TenPhongban", "Tên phòng ban"));


            //Bind khoan phi
            List<DmKhoanphi> lstkhoanphiTemp = new List<DmKhoanphi>();
            lstkhoanphiTemp.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmKhoanphi> lstkhoanphi = new List<DmKhoanphi>();
            DmKhoanphi objkhoanphi = new DmKhoanphi();
            lstkhoanphi.Add(objkhoanphi);
            lstkhoanphi.AddRange(lstkhoanphiTemp);
            cboKhoanphi.DataSource = lstkhoanphi;
            cboKhoanphi.DisplayMember = "KyHieu";
            cboKhoanphi.ValueMember = "Id";
            cboKhoanphi.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã khoản phí"));
            cboKhoanphi.Columns.Add(new LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"));

            //Bind hợp đồng
            List<DmHopdong> lsthopdongTemp = new List<DmHopdong>();
            lsthopdongTemp.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id));
            List<DmHopdong> lsthopdong = new List<DmHopdong>();
            DmHopdong objhopdong = new DmHopdong();
            lsthopdong.Add(objhopdong);
            lsthopdong.AddRange(lsthopdongTemp);
            cboHopdong.DataSource = lsthopdong;
            cboHopdong.DisplayMember = "KyHieu";
            cboHopdong.ValueMember = "Id";
            cboHopdong.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã hợp đồng"));
            cboHopdong.Columns.Add(new LookUpColumnInfo("TenHopdong", "Tên hợp đồng"));


            IList<SxLenhsanxuat> lstLenhSx = _SxLenhsanxuatService.GetbyDonviId(Generals.DonviID);
            cboLenhSxNhap.DataSource = lstLenhSx;
            cboLenhSxXuat.DataSource = lstLenhSx;

            cboPhanXuongXuat.DataSource = lstPhongBanTemp;
            cboPhanXuongNhap.DataSource = lstPhongBanTemp;
        }

        /// <summary>
        /// lay ID cua row dang focus
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool GetRowSelect()
        {
            if ((grvLPX_Hnx.GetSelectedRows().Length > 0))
            {
                if ((grvLPX_Hnx.RowCount != 0))
                {
                    CT_H_GInfo grtCTH_NX = (CT_H_GInfo)grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows()[0]);
                    // DMBTKC = grtCTH_NX
                    mCTHNXID = grtCTH_NX.Id;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// xu ly hien thi mot so truong
        /// </summary>
        /// <remarks></remarks>
        private void SetVisible()
        {
            if (obj_lct.DmPhongban != 1)
            {
                grvPhieuNhapKho.Columns["IdDmPhongbanCo"].Visible = false;
            }
            if (obj_lct.DmKhoanphi != 1)
            {
                grvPhieuNhapKho.Columns["IdDmKhoanphiCo"].Visible = false;
            }
            if (obj_lct.DmTudo1 != 1)
            {
                grvPhieuNhapKho.Columns["IdDmTudo1Co"].Visible = false;
            }
            if (obj_lct.DmTudo2 != 1)
            {
                grvPhieuNhapKho.Columns["IdDmTudo2Co"].Visible = false;
            }
            if (obj_lct.DmTudo3 != 1)
            {
                grvPhieuNhapKho.Columns["IdDmTudo3Co"].Visible = false;
            }
            if (obj_lct.DmTudo4 != 1)
            {
                grvPhieuNhapKho.Columns["IdDmTudo4Co"].Visible = false;
            }
            if (obj_lct.DmTudo5 != 1)
            {
                grvPhieuNhapKho.Columns["IdDmTudo5Co"].Visible = false;
            }
            if (obj_lct.DmVuviec != 1)
            {
                grvPhieuNhapKho.Columns["VuviecId"].Visible = false;
            }
            if (obj_lct.DmPtqt != 1)
            {
                grvPhieuNhapKho.Columns["IdDmPtqtCo"].Visible = false;
            }
            if (obj_lct.DmHopdong != 1)
            {
                grvPhieuNhapKho.Columns["IdDmHopdongCo"].Visible = false;
            }
        }

        /// <summary>
        /// ham xu ly lay data tren form de su ly insert va update
        /// </summary>
        /// <remarks></remarks>
        private void GetControlToOBject()
        {
            try
            {
                //lay nhieu gia tri trong 1 table khac
                HtLoaichungtu drLPNhap = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);
                obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt;
                obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu;
                obj_ct_h_nx.IdLoaiCt = drLPNhap.Id;
                //add cac truong can vao obj
                //obj_ct_h_nx.NTE_ID = cboTyGia.EditValue
                //obj_ct_h_nx.TY_GIA = txtTY_GIA.Text

                obj_ct_h_nx.TyGia = 1; //Mac dinh VND
                obj_ct_h_nx.MaNte = TienTienNoiTe.MaNte;
                obj_ct_h_nx.NteId = TienTienNoiTe.Id;
                obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(false); //Mac dinh VND

                ////
                //if ((GFilter.ListEditValue.Count > 0))
                //{
                //    obj_ct_h_nx.KhangId = VnsConvert.CGuid(GFilter.ListEditValue[0]);
                //    obj_ct_h_nx.MaKhang = GFilter.ListEditValue[2];
                //    obj_ct_h_nx.KyHieuKhang = GFilter.ListEditValue[3];
                //}
                //else
                //{
                //    obj_ct_h_nx.KhangId = Null.NullGuid;
                //    obj_ct_h_nx.MaKhang = string.Empty;
                //    obj_ct_h_nx.KyHieuKhang = string.Empty;
                //}

                //obj_ct_h_nx.TenKhang = txtTEN_KHANG.Text;
                //obj_ct_h_nx.MstKhang = txtMST_KHANG.Text;
                obj_ct_h_nx.DiaChi = txtDIA_CHI.Text;

                obj_ct_h_nx.NguoiGiaoNhanHang = txtNGUOI_GIAO_NHAN_HANG.Text;
                obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text;
                obj_ct_h_nx.NgayGhi = dteNGAY_GHI.DateTime;
                obj_ct_h_nx.NgayCt = dteNGAY_CT.DateTime;
                //obj_ct_h_nx.GHI = txtGHI.Text
                obj_ct_h_nx.Ghi = Convert.ToDecimal(UR_STATUS.Value_info.ParameterValue);
                obj_ct_h_nx.NguoiTao = Generals.USER.Id.ToString();
                obj_ct_h_nx.NguoiSua = Generals.USER.Id.ToString();
                obj_ct_h_nx.DonviId = Generals.DON_VI.Id;
                obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi;
                obj_ct_h_nx.SoDu = 0;

                Boolean flgUpdate = true;
                // Sử lý insert,update
                switch (m_InputState)
                {
                    case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:
                        int strmMonth = 0;
                        strmMonth = dteNGAY_CT.DateTime.Month;
                        int strYear = 0;
                        strYear = dteNGAY_CT.DateTime.Year;
                        C_SoChungTu_RP.r_SoCTPREFIX(obj_ct_h_nx.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id);
                        obj_ct_h_nx.CtSo = C_SoChungTu_RP.SO_CHUNG_TU;
                        obj_ct_h_nx.PrefixCt = C_SoChungTu_RP.PREFIX;
                        flgUpdate = false;
                        break;
                    default:
                        break;
                }

                //lay gia trị control tren luoi gan cho obj
                foreach (CtDNx objctdnx in lstobj_ct_d_nx)
                {
                    //objctdnx.CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID
                    objctdnx.Xuat = drLPNhap.KhoXuat;
                    //
                    objctdnx.IdKhang = obj_ct_h_nx.KhangId;
                    objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId;
                    objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang;
                    objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang;
                    objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId;
                    objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang;
                    objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang;
                    //
                    objctdnx.IdDmHopdongNo = objctdnx.IdDmHopdongCo;
                    objctdnx.IdDmKhoanphiNo = objctdnx.IdDmKhoanphiCo;
                    objctdnx.IdDmTudo1No = objctdnx.IdDmTudo1Co;
                    objctdnx.IdDmTudo2No = objctdnx.IdDmTudo2Co;
                    objctdnx.IdDmTudo3No = objctdnx.IdDmTudo3Co;
                    objctdnx.IdDmTudo4No = objctdnx.IdDmTudo4Co;
                    objctdnx.IdDmTudo5No = objctdnx.IdDmTudo5Co;
                    objctdnx.IdDmPtqtNo = objctdnx.IdDmPtqtCo;
                    objctdnx.IdDmVuviecCo = objctdnx.VuviecId;
                    objctdnx.IdDmVuviecNo = objctdnx.VuviecId;

                    if (objLoaiChungTu.KhoXuat == 1)
                    {
                        objctdnx.MaTknGiavon = GFilter_TK.ListEditValue[1];
                        objctdnx.TknGiavon = VnsConvert.CGuid(GFilter_TK.ListEditValue[0]);
                    }
                    else
                    {
                        objctdnx.MaTkcGiavon = GFilter_TK.ListEditValue[1];
                        objctdnx.TkcGiavon = VnsConvert.CGuid(GFilter_TK.ListEditValue[0]);
                    }
                }

                _CtHNxService.SaveChungTuKho(flgUpdate, ref obj_ct_h_nx, ref lstobj_ct_d_nx, del_lstobj_ct_d_nx);
                //Gán lại giá trị so chung tu sau khi luu
                C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// ham xu ly load data len form theo Id tuong ung
        /// </summary>
        /// <remarks></remarks>
        private void SetObjectToControl()
        {
            //load data theo Id truyen vao
            obj_ct_h_nx = _CtHNxService.GetById(mCTHNXID);
            if (obj_ct_h_nx == null)
            {
                closeForm = true;
                return;
            }
            else
            {
                closeForm = false;
            }
            grlLoaiPhieuNhap.EditValue = obj_ct_h_nx.MaLoaiCt;
            //grlKHANG_ID.EditValue = obj_ct_h_nx.KHANG_ID
            //
            //GFilter.Text = obj_ct_h_nx.KyHieuKhang;
            //GFilter.Tag = obj_ct_h_nx.KhangId;

            //txtDIA_CHI.Text = obj_ct_h_nx.DiaChi;
            //txtTEN_KHANG.Text = obj_ct_h_nx.TenKhang;
            //txtMST_KHANG.Text = obj_ct_h_nx.MstKhang;
           
            //txtGHI.Text = obj_ct_h_nx.GHI
            UR_STATUS.Set_Status(obj_ct_h_nx.Ghi.ToString());
            UR_STATUS.cboStatus.EditValue = obj_ct_h_nx.Ghi;
            txtNGUOI_GIAO_NHAN_HANG.Text = obj_ct_h_nx.NguoiGiaoNhanHang;
            txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai;
            dteNGAY_CT.DateTime = obj_ct_h_nx.NgayCt.Value;
            dteNGAY_GHI.DateTime = obj_ct_h_nx.NgayGhi.Value;

            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo;
            
            lstobj_ct_d_nx = new List<CtDNx>();
            lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(mCTHNXID));

            if (lstobj_ct_d_nx.Count != 0)
            {
                grcPhieuPhapKho.DataSource = lstobj_ct_d_nx;
                TongTien();
                //GFilter_TK.ClearFilterData -= GFilter_TK_ClearFilterData;
                //if (objLoaiChungTu.KhoXuat == 1)
                //{
                //    GFilter_TK.Tag = lstobj_ct_d_nx[0].TknGiavon;
                //    GFilter_TK.Text = lstobj_ct_d_nx[0].MaTknGiavon;
                //}
                //else
                //{
                //    GFilter_TK.Tag = lstobj_ct_d_nx[0].TkcGiavon;
                //    GFilter_TK.Text = lstobj_ct_d_nx[0].MaTkcGiavon;
                //}
                //GFilter_TK.ClearFilterData += GFilter_TK_ClearFilterData;
            }
            TongTien();
            //
            ConfigGrid.GridConfig(this.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT, grvPhieuNhapKho.Name, grvPhieuNhapKho);
            //'Kiểm tra trạng thái có cho phép sửa hay không
            if (!(UR_STATUS.ChoPhepSuaCT()))
            {
                UR_STATUS.Enabled = false;
            }
            else
            {
                UR_STATUS.Enabled = true;
            }
        }


        /// <summary>
        /// ham tinh tong tien cot trong luoi
        /// </summary>
        /// <remarks></remarks>
        private void TongTien()
        {
            decimal sumTongTien = default(decimal);
            decimal sumTongSoLuong = default(decimal);
            int i = 0;
            for (i = 0; i <= grvPhieuNhapKho.RowCount - 1; i++)
            {
                CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(i);

                sumTongTien = sumTongTien + gridctdnx.GiaVon;
                sumTongSoLuong = sumTongSoLuong + gridctdnx.SoLuong;
            }
            TxtTongTien.EditValue = sumTongTien;
            //Format(CLng(sumTongTien.ToString), "n0")
            txtTongSoLuong.EditValue = sumTongSoLuong;
            //Format(CLng(sumTongSoLuong.ToString), "n0")
        }

        /// <summary>
        /// xu ly btn LUU
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnLuu_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                grvPhieuNhapKho.RowCellStyle += grvPhieuNhapKho_RowCellStyle;
                this.ValidateChildren();
                //'check trang thai co thuoc quyen cua user hay ko
                if (!UR_STATUS.ChoPhepSuaCT())
                {
                    FormGlobals.Message_Warning(msgTTChungTu);
                    return;
                }

                if ((obj_ct_h_nx == null))
                {
                    obj_ct_h_nx = new CtHNx();
                }

                if ((obj_ct_h_nx.DaKhoaSo == 1))
                {
                    FormGlobals.Message_Warning(msgKhoaSo);
                    return;
                }

                //Check khoa so thang
                if (_KtKhoasoThangService.KiemTraKhoaSo(dteNGAY_CT.DateTime, Generals.DON_VI.Id))
                {
                    FormGlobals.Message_Warning(msgKhoaSo);
                    return;
                }

                if (GFilter_TK.Tag == null)
                {
                    if (objLoaiChungTu.KhoXuat == 1)
                    {
                        FormGlobals.Message_Warning("Bạn chưa chọn giá trị cho tài khoản nợ");
                    }
                    else
                    {
                        FormGlobals.Message_Warning("Bạn chưa chọn giá trị cho tài khoản có");
                    }
                    GFilter_TK.Focus();
                    return;
                }

                // goi ham check null cac gia tri cua form
                if (!CheckNull(lstobj_ct_d_nx))
                {
                    return;
                }

                try
                {
                    //xu ly check so luong ton kho trong phieu xuat kho
                    if ((objLoaiChungTu.KhoXuat == 1))
                    {
                        List<DmKho> lst = new List<DmKho>();
                        lst = (List<DmKho>)cboMaKho.DataSource;
                        if (!(_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, dteNGAY_CT.DateTime, ref lstobj_ct_d_nx, lst, Generals.DON_VI.Id)))
                        {
                            FormGlobals.Message_Warning("Kho không cho phép xuất âm");
                            grvPhieuNhapKho.RefreshData();
                            return;
                        }
                    }

                    //goi ham xu ly data tren form
                    frmProgress.Instance().Thread = GetControlToOBject;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Data saved");

                    //Refesh Grid
                    mCTHNXID = obj_ct_h_nx.Id;
                    CT_H_GInfo editObject = new CT_H_GInfo(obj_ct_h_nx);
                    Vns.Erp.Core.Controls.Commons.GridHelper.RefreshLeftGrid(ref grvLPX_Hnx, ref lstobj_ct_h_gg, editObject, m_InputState);

                    m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.ViewMode;
                    DatTrangThaiControl();
                    btnAdd.Focus();
                    grvPhieuNhapKho.RowCellStyle -= grvPhieuNhapKho_RowCellStyle;
                }
                catch (Exception ex)
                {
                    FormGlobals.Message_Error(ex);
                }

            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// ham kiem tra null cua form
        /// </summary>
        /// <param name="lstobj_ct_d_nx"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool CheckNull(List<CtDNx> lstobj_ct_d_nx)
        {

            // kiem tra null cua comobox ma khach
            //If (New Guid(GFilter.ListEditValue(0)) = Null.NullGuid) Then
            //    Message_Warning("Bạn chưa nhập mã khách hàng.")
            //    Return False
            //End If

            //kiem tra null cua comobox ngay hach toan
            if ((dteNGAY_GHI.DateTime == null))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập ngày hạch toán.");
                dteNGAY_GHI.Focus();
                return false;
            }

            if ((dteNGAY_GHI.DateTime.Date > dteNGAY_CT.DateTime.Date))
            {
                FormGlobals.Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ");
                dteNGAY_GHI.Focus();
                return false;
            }

            if (VnsCheck.IsNullGuid(GFilter_TK.Tag))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập " + lblTK.Text);
                GFilter_TK.Focus();
                return false;
            }


            //vong lap kiem tra cac cot tren luoi

            if (grvPhieuNhapKho.RowCount != 0)
            {

                foreach (CtDNx objctd in lstobj_ct_d_nx)
                {
                    //kiem tra gia tri null cua cot Hang hoa
                    if (objctd.HanghoaId == Null.NullGuid)
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập mã hàng hóa.");
                        return false;
                    }

                    if (string.IsNullOrEmpty(objctd.KyHieuHanghoa))
                    {
                        FormGlobals.Message_Warning("Bạn để trống cột mã hàng hóa");
                        return false;
                    }

                    //xet loai phieu de hien thi cot kho tren luoi
                    if (obj_lct.PhieuXuat == (int)LoaiKho.NhapKho)
                    {
                        //kiem tra gia tri null cua cot kho nhap
                        if (VnsCheck.IsNullGuid(objctd.KhoNhapId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn kho nhập.");
                            return false;
                        }

                        if (VnsCheck.IsNullGuid(objctd.LenhSanXuatNhapId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn lệnh sản xuất.");
                            return false;
                        }
                        if (VnsCheck.IsNullGuid(objctd.PhanXuongNhapId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn phân xưởng.");
                            return false;
                        }
                    }
                    else if (obj_lct.PhieuXuat == (int)LoaiKho.XuatKho)
                    {
                        //kiem tra gia tri null cua cot kho xuat
                        if (VnsCheck.IsNullGuid(objctd.KhoXuatId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn kho xuất.");
                            return false;
                        }

                        if (VnsCheck.IsNullGuid(objctd.LenhSanXuatXuatId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn lệnh sản xuất.");
                            return false;
                        }
                        if (VnsCheck.IsNullGuid(objctd.PhanXuongXuatId))
                        {
                            FormGlobals.Message_Warning("Bạn chưa lựa chọn phân xưởng.");
                            return false;
                        }
                    }

                    //kiem tra gia tri cua cot so luong

                    if (objctd.SoLuong == 0)
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập số lượng.");
                        return false;
                    }

                    //kiem tra gia tri cua cot don gia

                    if (objctd.DonGiaVon == 0)
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập đơn giá.");
                        return false;
                    }

                    //kiem tra gia tri cot tong tien
                    if (LimitValue.CheckCurrency(objctd.GiaVon) == false)
                    {
                        FormGlobals.Message_Warning("Giá vốn không hợp lệ");
                        return false;
                    }

                    // kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                    if (VnsCheck.IsNullGuid(objctd.TkcGiavon) & VnsCheck.IsNullGuid(objctd.TknGiavon))
                    {
                        FormGlobals.Message_Warning("Định khoản chưa nhập đủ.");
                        return false;
                    }

                    //Kiem tra các giá trị số trên lưới
                    if (LimitValue.CheckQuantity(objctd.SoLuong) == false)
                    {
                        FormGlobals.Message_Warning("Giá trị số lượng không hợp lệ");
                        return false;
                    }
                    // Kiem tra length nhap lieu
                    // Vi tri

                    if (objctd.ViTri.Trim().Length > 128)
                    {
                        FormGlobals.Message_Warning("Độ dài ký tự nhập liệu cho [Vị trí] quá lớn.");
                        return false;
                    }
                }
            }
            else
            {
                FormGlobals.Message_Warning("Chi tiết định khoản không được để trống");
                return false;
            }

            return true;
        }

        /// <summary>
        /// xu ly btn Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!UR_STATUS.ChoPhepSuaCT())
                {
                    FormGlobals.Message_Warning(msgTTChungTu);
                    return;
                }
                //Check kho'a so? tha'ng
                if (obj_ct_h_nx.DaKhoaSo == 1)
                {
                    FormGlobals.Message_Warning(msgKhoaSo);
                    return;
                }

                if (lstobj_ct_h_gg.Count > 0)
                {
                    if (!(FormGlobals.Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)))
                    {
                        return;
                    }

                    _CtHNxService.DeleteChungTu(obj_ct_h_nx);

                    mCTHNXID = Vns.Erp.Core.Controls.Commons.GridHelper.RemoveLeftGrid(ref lstobj_ct_h_gg, mCTHNXID);
                    if (!(mCTHNXID == Null.NullGuid))
                    {
                        SetObjectToControl();
                    }

                    //refresh lai data tren luoi
                    grvLPX_Hnx.RefreshData();

                    m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.ViewMode;

                    //txtCT_SO.Properties.ReadOnly = True
                }

                if (lstobj_ct_h_gg.Count == 0)
                {
                    ClearPage();
                    m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.AddMode;
                }
                btnAdd.Focus();
                DatTrangThaiControl();
                SetFocus_FirstCell();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// ham xu ly delete record tren luoi
        /// </summary>
        /// <remarks></remarks>
        private void DeleteRow()
        {
            CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle);
            del_lstobj_ct_d_nx.Add(gridctdnx);
            grvPhieuNhapKho.DeleteSelectedRows();
            //Message_Information("Xóa thành công")
        }

        /// <summary>
        /// xu ly btn quay ra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnQuit_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// xu ly btn search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnSea_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                //frmTimKiemChungTuKho fr = ObjectFactory.GetObject("frmTimKiemChungTuKho");
                //fr.MaCT = obj_lct.MaLoaiCt;
                //fr.ShowDialog();

                //if (fr.lstobj_ct_h_g.Count > 0)
                //{
                //    //
                //    lstobj_ct_h_gg = fr.lstobj_ct_h_g;
                //    mCTHNXID = lstobj_ct_h_gg[0].Id;
                //    //
                //    Load_Grid(lstobj_ct_h_gg);
                //    //
                //    SetObjectToControl();
                //    TongTien();
                //}
                //else
                //{
                //    //ClearPage()
                //}

                //ClearPage()
                //m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.ViewMode;
                //DatTrangThaiControl();

            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// xu ly btn Huy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (lstobj_ct_h_gg.Count > 0)
                {
                    if (m_InputState == Vns.Erp.Core.FormGlobals.DataInputState.AddMode)
                    {
                        mCTHNXID = lstobj_ct_h_gg[lstobj_ct_h_gg.Count - 1].Id;
                        grvLPX_Hnx.FocusedRowHandle = lstobj_ct_h_gg.Count - 1;
                    }
                    SetObjectToControl();
                    TongTien();
                    m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.ViewMode;
                }
                else
                {
                    m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.AddMode;
                }
                DatTrangThaiControl();
                btnAdd.Focus();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                grvPhieuNhapKho.RowCellStyle -= grvPhieuNhapKho_RowCellStyle;
                obj_ct_h_nx = new CtHNx();
                m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.AddMode;
                DatTrangThaiControl();
                //txtCT_SO.Text = Nothing
                //txtCT_SO.Properties.ReadOnly = True
                grlLoaiPhieuNhap.Properties.ReadOnly = true;
                ClearPage();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// xu ly btn Sua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnMod_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (obj_ct_h_nx.DaKhoaSo == 0)
                {
                    try
                    {
                        // Set state
                        m_InputState = Vns.Erp.Core.FormGlobals.DataInputState.EditMode;

                        // Set trang thai control
                        DatTrangThaiControl();
                        TongTien();

                    }
                    catch (Exception ex)
                    {
                        FormGlobals.Message_Error(ex);
                    }
                }
                else
                {
                    FormGlobals.Message_Information("Chứng từ đã được khóa nên không thể sửa!");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// xu ly btn in chung tu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnInCtu_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                HtLoaichungtu obj_htchungtu = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);
                Form obj_form = (Form)ObjectFactory.GetObject("frmKho_Input", new object[] {
				mCTHNXID,
				obj_htchungtu
			});
                obj_form.ShowInTaskbar = false;
                obj_form.ShowDialog();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// ham xet trang thai control tren form
        /// </summary>
        /// <remarks></remarks>
        private void DatTrangThaiControl()
        {
            switch (m_InputState)
            {
                case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:
                    FormGlobals.Control_SetState(GroupControl1, m_InputState);
                    FormGlobals.Control_SetState(GroupControl2, m_InputState);
                    //Control_SetState(GroupControl3, DataInputState.AddMode)
                    FormGlobals.Control_SetState(GroupControl4, m_InputState);
                    grvPhieuNhapKho.OptionsBehavior.Editable = true;
                    btnAdd.Enabled = false;
                    btnMod.Enabled = false;
                    btnSav.Enabled = true;
                    btnDel.Enabled = false;
                    btnPri.Enabled = false;
                    btnCan.Enabled = true;
                    btnSea.Enabled = false;
                    grcLPN_Hnx.Enabled = false;
                    //txtCT_SO.Properties.ReadOnly = True
                    grlLoaiPhieuNhap.Properties.ReadOnly = true;
                    GFilter_TK.ENABLES = true;
                    navWelding1.Enabled = false;

                    break;
                case Vns.Erp.Core.FormGlobals.DataInputState.EditMode:
                    FormGlobals.Control_SetState(GroupControl1, m_InputState);
                    FormGlobals.Control_SetState(GroupControl2, m_InputState);
                    //Control_SetState(GroupControl3, DataInputState.EditMode)
                    FormGlobals.Control_SetState(GroupControl4, m_InputState);
                    grvPhieuNhapKho.OptionsBehavior.Editable = true;
                    btnAdd.Enabled = false;
                    btnMod.Enabled = false;
                    btnSav.Enabled = true;
                    btnDel.Enabled = true;
                    btnPri.Enabled = true;
                    btnCan.Enabled = true;
                    btnSea.Enabled = false;
                    grcLPN_Hnx.Enabled = false;
                    //txtCT_SO.Properties.ReadOnly = True
                    grlLoaiPhieuNhap.Properties.ReadOnly = true;
                    GFilter_TK.ENABLES = true;
                    navWelding1.Enabled = false;
                    break;
                default:
                    FormGlobals.Control_SetState(GroupControl1, m_InputState);
                    FormGlobals.Control_SetState(GroupControl2, m_InputState);
                    //Control_SetState(GroupControl3, DataInputState.ViewMode)
                    FormGlobals.Control_SetState(GroupControl4, m_InputState);
                    grvPhieuNhapKho.OptionsBehavior.Editable = false;
                    btnAdd.Enabled = true;
                    btnMod.Enabled = true;
                    btnSav.Enabled = false;
                    btnPri.Enabled = true;
                    btnDel.Enabled = true;
                    btnCan.Enabled = false;
                    btnSea.Enabled = true;
                    grcLPN_Hnx.Enabled = true;
                    grlLoaiPhieuNhap.Properties.ReadOnly = true;
                    GFilter_TK.ENABLES = false;
                    navWelding1.Enabled = true;
                    break;
            }
            GroupControl1.Focus();
            txtTongSoLuong.Properties.ReadOnly = true;
            TxtTongTien.Properties.ReadOnly = true;
            grlLoaiPhieuNhap.Focus();
        }

        /// <summary>
        /// ham xoa trang data tren form
        /// </summary>
        /// <remarks></remarks>

        public void ClearPage()
        {
            //FormGlobals.Control_ClearData(GroupControl1);
            //FormGlobals.Control_ClearData(GroupControl2);
            //txtMST_KHANG.Text = null;
            //GFilter.Text = "";
            //GFilter.Tag = "";
            //txtTEN_KHANG.Text = null;

            txtDIA_CHI.Text = null;
            
            C_SoChungTu_RP.Text = "";
            txtNGUOI_GIAO_NHAN_HANG.Text = "";
            txtDIEN_GIAI.Text = "";
            dteNGAY_CT.EditValue = DateTime.Now;
            dteNGAY_GHI.EditValue = DateTime.Now;
            dteHDPN.EditValue = null;
            
            TxtTongTien.Text = null;
            txtTongSoLuong.Text = null;
            if (UR_STATUS != null)
            {
                UR_STATUS.cboStatus.EditValue = 1;
                UR_STATUS.Set_Status("1");
            }
            txtTongSoLuong.Enabled = false;
            TxtTongTien.Enabled = false;
            //GFilter_TK.Text = "";
            //GFilter_TK.Tag = "";
            grlLoaiPhieuNhap.EditValue = obj_lct.MaLoaiCt;
            lstobj_ct_d_nx = new List<CtDNx>();
            lstobj_ct_d_nx.Add(new CtDNx());
            grcPhieuPhapKho.DataSource = lstobj_ct_d_nx;
            grvPhieuNhapKho.RefreshData();

        }

        #endregion

        #region "Events"

        /// <summary>
        /// xu ly bind data vao luoi khac khi dang focus row hien tai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void grvLPX_Hnx_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if ((m_InputState == Vns.Erp.Core.FormGlobals.DataInputState.EditMode) & (btnMod.Enabled == false))
                {
                    //SetObjectToControl()
                }
                else if ((m_InputState == Vns.Erp.Core.FormGlobals.DataInputState.AddMode) & (btnMod.Enabled == false))
                {
                    return;
                }
                else
                {
                    if (GetRowSelect())
                    {
                        SetObjectToControl();

                    }
                }

            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

        }

        /// <summary>
        /// trong su kien cua luoi xu ly cac gia tri tren luoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void grvPhieuNhapKho_CellValueChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle);
            if (gridctdnx == null) return;
            switch (e.Column.Name)
            {
                case "KhoNhapId":
                    DmKho cboKhoNhap = (DmKho)cboMaKho.GetDataSourceRowByKeyValue(gridctdnx.KhoNhapId);
                    if ((gridctdnx == null))
                    {
                        return;
                    }

                    break;
                case "KhoXuatId":
                    DmKho cboKhoXuat = (DmKho)cboMakhoxuat.GetDataSourceRowByKeyValue(gridctdnx.KhoXuatId);
                    if ((gridctdnx.HanghoaId == Null.NullGuid))
                    {
                    }
                    else
                    {
                        gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.DateTime, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id);
                    }
                    break;
                case "TKN_GIAVON":
                    DmTaikhoan cboTKNGiaVon = (DmTaikhoan)cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TknGiavon);
                    gridctdnx.MaTknGiavon = cboTKNGiaVon.MaTaikhoan;
                    break;
                //gridctdnx.TKN_GIAVON = cboTKNGiaVon.TAIKHOAN_ID

                case "TKC_GIAVON":
                    DmTaikhoan cboTKCGiaVon = (DmTaikhoan)cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TkcGiavon);
                    gridctdnx.MaTkcGiavon = cboTKCGiaVon.MaTaikhoan;
                    break;
                case "VUVIEC_ID":
                    DmVuviec cboVViec = (DmVuviec)cboVuViec.GetDataSourceRowByKeyValue(gridctdnx.VuviecId);                                        //Gan vao GridView
                    gridctdnx.VuviecId = cboVViec.Id;
                    gridctdnx.KyHieuVuviec = cboVViec.KyHieu;
                    gridctdnx.TenVuviec = cboVViec.TenVuviec;
                    gridctdnx.MaVuviec = cboVViec.MaVuviec;
                    break;
                case "ID_DM_KHOANPHI_CO":
                    DmKhoanphi cboKPhi = (DmKhoanphi)cboKhoanphi.GetDataSourceRowByKeyValue(gridctdnx.IdDmKhoanphiCo);
                    break;
                case "colLenhSxNhap":
                    SxLenhsanxuat lenhSx = (SxLenhsanxuat)ComboHelper.GetSelectData(cboLenhSxNhap, gridctdnx.LenhSanXuatNhapId);
                        //.GetRowByKeyValue(gridctdnx.LenhSanXuatNhapId);
                    if (lenhSx != null)
                    {
                        gridctdnx.MaLenhSanXuatNhap = lenhSx.SoLenhSanXuat;
                        gridctdnx.MaLenhSanXuatXuat = String.Empty;
                        gridctdnx.LenhSanXuatXuatId = new Guid();
                    }
                    break;
                case "colLenhSxXuat":
                    SxLenhsanxuat lenhSxX = (SxLenhsanxuat)ComboHelper.GetSelectData(cboLenhSxXuat, gridctdnx.LenhSanXuatXuatId);
                    if (lenhSxX != null)
                    {
                        gridctdnx.MaLenhSanXuatXuat = lenhSxX.SoLenhSanXuat;
                        gridctdnx.MaLenhSanXuatNhap = String.Empty;
                        gridctdnx.LenhSanXuatNhapId = new Guid();
                    }
                    break;
                case "colPhanXuongXuat":
                    DmPhongban cbophongbanXuat = (DmPhongban)cboPhanXuongXuat.GetRowByKeyValue(gridctdnx.PhanXuongXuatId);
                    if ((gridctdnx.PhanXuongXuatId == Null.NullGuid))
                    {
                    }
                    else
                    {
                        gridctdnx.MaPhanXuongXuat = cbophongbanXuat.KyHieu;

                    }
                    break;
                case "colPhanXuongNhap":
                    DmPhongban cbophongbanNhap = (DmPhongban)cboPhanXuongNhap.GetRowByKeyValue(gridctdnx.PhanXuongNhapId);
                    if ((gridctdnx.PhanXuongNhapId == Null.NullGuid))
                    {
                    }
                    else
                    {
                        gridctdnx.MaPhanXuongNhap = cbophongbanNhap.KyHieu;
                    }
                    break;
            }

            if (e.Column.FieldName.Equals("DonGiaVon") | e.Column.FieldName.Equals("SoLuong"))
            {
                decimal Total = gridctdnx.DonGiaVon * gridctdnx.SoLuong;
                gridctdnx.GiaVon = Total;
            }


            if (e.Column.FieldName.Equals("DonGiaVonNte") | e.Column.FieldName.Equals("SoLuong"))
            {
                decimal Total = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong;
                gridctdnx.GiaVonNt = Total;
            }

            TongTien();

        }

        /// <summary>
        /// xu ly su kien enter xuong dong tren luoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void grvPhieuNhapKho_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if ((GridHelper.CheckAddNewRow(grvPhieuNhapKho)))
                    {
                        lstobj_ct_d_nx.Add(new CtDNx());
                        grvPhieuNhapKho.RefreshData();
                        SetFocus_FirstCell();
                    }
                    break;
            }
            //
            if (e.KeyCode == Keys.F12)
            {
                string FormID = this.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT;
                List<ColInfo> lstColInfo = new List<ColInfo>();
                ConfigGrid.GetGridColInfo(grvPhieuNhapKho, lstColInfo);
                ConfigGrid f = new ConfigGrid();
                if (f.Show_Form(grvPhieuNhapKho.Name, FormID, lstColInfo))
                {
                    ConfigGrid.GridConfig(FormID, grvPhieuNhapKho.Name, grvPhieuNhapKho);
                }
            }
        }

        private void SetFocus_FirstCell()
        {
            grvPhieuNhapKho.FocusedRowHandle = grvPhieuNhapKho.RowCount - 1;
            grvPhieuNhapKho.SelectRow(grvPhieuNhapKho.FocusedRowHandle);
            try
            {
                grvPhieuNhapKho.FocusedColumn = grvPhieuNhapKho.VisibleColumns[0];
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// xu ly phim tat tren form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmPhieuNhapKho_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        if (Vns.Erp.Core.Controls.Commons.FormHelper.CheckStatusEscape(m_InputState))
                        {
                            this.Close();
                        }
                        break; // TODO: might not be correct. Was : Exit Select
                    case Keys.F4:
                        //Try
                        //kiem tra dang o trang thai gi de xet xem co su dung them dong ko
                        if (m_InputState != Vns.Erp.Core.FormGlobals.DataInputState.ViewMode)
                        {
                            lstobj_ct_d_nx.Add(new CtDNx());
                            SetFocus_FirstCell();
                            grvPhieuNhapKho.RefreshData();
                        }
                        //Catch ex As Exception
                        //    Message_Error(ex)
                        //End Try
                        break; // TODO: might not be correct. Was : Exit Select
                    case Keys.F8:
                        //Try
                        //kiem tra dang o trang thai gi de xet xem co su dung xoa dong ko
                        if (m_InputState != Vns.Erp.Core.FormGlobals.DataInputState.ViewMode)
                        {
                            if (grvPhieuNhapKho.RowCount != 0)
                            {
                                DeleteRow();
                                TongTien();
                            }
                            else
                            {
                                FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
                            }
                        }
                        //Catch ex As Exception
                        //    Message_Error(ex)
                        //End Try
                        break; // TODO: might not be correct. Was : Exit Select
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// ham xu ly cua form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmPhieuNhapKho_ChiTiet_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Khi chon ngay CT thi ngay HT load theo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void dteNGAY_CT_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dteNGAY_GHI == null)
            {
            }
            else
            {
                dteNGAY_GHI.EditValue = dteNGAY_CT.EditValue;
            }
        }

        private void GFilter_HANGHOA_ID_AfterFilter(object senders, EventArgs e)
        {
            try
            {
                int rowHandle = grvPhieuNhapKho.FocusedRowHandle;
                string columnName = grvPhieuNhapKho.FocusedColumn.Name;
                CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle);
                switch (columnName)
                {
                    case "HanghoaId":
                        //Gan vao GridView
                        gridctdnx.TenHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[2];
                        gridctdnx.MaHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[3];
                        gridctdnx.KyHieuHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[1];
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[0]);
                        gridctdnx.TenDvt = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[4];
                        gridctdnx.ViTri = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[9];
                        gridctdnx.DonGiaVon = 1; //Mac dinh
                        
                        // bind ma tai khoan no va co theo hang hoa co ma TK kho
                        string strMaTaiKhoan = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[8];
                        if (string.IsNullOrEmpty(strMaTaiKhoan))
                        {
                        }
                        else
                        {
                            string[] strMTK = strMaTaiKhoan.Split(';');
                            strMaTaiKhoan = strMTK[0];
                            DmTaikhoan obj_taikhoan = new DmTaikhoan();
                            obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id);
                            // kiem tra loai phieu xuat hay nhap kho de bind ma tai khoan kho lien quan
                            if (objLoaiChungTu.KhoXuat == 1)
                            {
                                gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan;
                                gridctdnx.TkcGiavon = obj_taikhoan.Id;
                            }
                            else
                            {
                                gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan;
                                gridctdnx.TknGiavon = obj_taikhoan.Id;
                            }

                        }

                        if ((gridctdnx.HanghoaId == Null.NullGuid))
                        {
                        }
                        else
                        {
                            gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.DateTime, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id);
                        }

                        grvPhieuNhapKho.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa);
                        break;
                    case "MaTknGiavon":
                        if ((gridctdnx == null))
                        {
                            return;
                        }
                        if (Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0)
                        {
                            gridctdnx.MaTknGiavon = Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[1];
                            gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
                        }
                        grvPhieuNhapKho.SetRowCellValue(rowHandle, "MaTknGiavon", gridctdnx.MaTknGiavon);
                        break;
                    case "MaTkcGiavon":
                        if ((gridctdnx == null))
                        {
                            return;
                        }
                        if (Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0)
                        {
                            gridctdnx.MaTkcGiavon = Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[1];
                            gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
                        }
                        grvPhieuNhapKho.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon);
                        break;
                }
                SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
            }
        }

        private void GFilter_HANGHOA_ID_ClearFilter(object senders, EventArgs e)
        {

            try
            {
                int rowHandle = grvPhieuNhapKho.FocusedRowHandle;
                string columnName = grvPhieuNhapKho.FocusedColumn.Name;
                CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle);
                switch (columnName)
                {
                    case "HanghoaId":
                        if ((gridctdnx == null))
                        {
                            return;
                        }
                        if (GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0)
                        {
                            //Gan vao GridView
                            gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[0]);
                        }
                        break;
                    case "MaTknGiavon":
                        if ((gridctdnx == null))
                        {
                            return;
                        }
                        if (Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0)
                        {
                            gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
                        }
                        break;
                    case "MaTkcGiavon":
                        if ((gridctdnx == null))
                        {
                            return;
                        }
                        if (Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0)
                        {
                            gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void CheckEdit1_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            EnterNext(sender, e);
        }

        private void EnterNext(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        private void GFilterEdit_HANGHOA_ID_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                CtDNx gridctdnx = (CtDNx)grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle);
                switch (grvPhieuNhapKho.FocusedColumn.Name)
                {
                    case "HanghoaId":
                        if (GFilterEdit_HANGHOA_ID.C_DATA_SOURCE == null)
                        {
                            if (Kry_DATASOURE == null)
                            {
                                GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id));
                            }
                            else
                            {
                                GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE;
                            }
                            if ((gridctdnx.KhoXuatId == Null.NullGuid))
                            {
                            }
                            else
                            {
                                gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.DateTime, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id);
                            }
                            GFilterEdit_HANGHOA_ID.Editors.A_DATA_SOURCE = GFilterEdit_HANGHOA_ID.C_DATA_SOURCE;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void Gfilter_MA_TKN_GIAVON_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                switch (grvPhieuNhapKho.FocusedColumn.Name)
                {
                    case "MaTknGiavon":
                        if (Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE == null)
                        {
                            if (Ji_DATASOURE == null)
                            {
                                Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
                            }
                            else
                            {
                                Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE;
                            }
                            Gfilter_MA_TKN_GIAVON.Editors.A_DATA_SOURCE = Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE;
                        }
                        break;
                    case "MaTkcGiavon":
                        if (Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE == null)
                        {
                            if (Ji_DATASOURE == null)
                            {
                                Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
                            }
                            else
                            {
                                Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE;
                            }
                            Gfilter_MA_TKC_GIAVON.Editors.A_DATA_SOURCE = Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void GFilter_TK_AfterFilter(System.Object sender, System.EventArgs e)
        {
            try
            {
                GFilter_TK.Tag = GFilter_TK.ListEditValue[0];
                //GFilter_TK.Text = GFilter_TK.ListEditValue(1)
                if (GFilter_TK.IsNotTextChanged)
                    SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void GFilter_TK_ClearFilterData(System.Object sender, System.EventArgs e)
        {
            try
            {
                GFilter_TK.Tag = GFilter_TK.ListEditValue[0];
                GFilter_TK.Text = GFilter_TK.ListEditValue[1];
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void GFilter_TK_FirstBinddata(System.Object sender, System.EventArgs e)
        {
            try
            {
                GFilter_TK.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
                int i = Convert.ToInt32(objLoaiChungTu.KhoXuat);
                switch (i)
                {
                    case (int)LoaiKho.XuatKho:
                        //Xuat kho
                        GFilter_TK.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", objLoaiChungTu.MaTkCoLq);
                        break;
                    case (int)LoaiKho.NhapKho:
                        //Nhap kho
                        GFilter_TK.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", objLoaiChungTu.MaTkNoLq);
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvPhieuNhapKho_RowCellStyle(System.Object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                object val = grvPhieuNhapKho.GetRowCellValue(e.RowHandle, e.Column);
                switch (e.Column.FieldName)
                {
                    case "KyHieuHanghoa":
                        if (string.IsNullOrEmpty(val.ToString()))
                        {
                            AppearanceHelper.Apply(e.Appearance, Generals.appError);
                        }
                        break;
                    case "KhoXuatId":
                        if (VnsCheck.IsNullGuid(VnsConvert.CGuid(val.ToString())))
                        {
                            AppearanceHelper.Apply(e.Appearance, Generals.appError);
                        }
                        break;
                    case "KhoNhapId":
                        if (VnsCheck.IsNullGuid(VnsConvert.CGuid(val.ToString())))
                        {
                            AppearanceHelper.Apply(e.Appearance, Generals.appError);
                        }
                        break;
                    case "SoLuong":
                        if (Convert.ToDecimal(val) <= 0 | Convert.ToDecimal(val) >= decimal.MaxValue)
                        {
                            AppearanceHelper.Apply(e.Appearance, Generals.appError);
                        }
                        break;
                    case "DonGiaVon":
                        if (Convert.ToDecimal(val) <= 0 | Convert.ToDecimal(val) >= decimal.MaxValue)
                        {
                            AppearanceHelper.Apply(e.Appearance, Generals.appError);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmPhieuNhapKho_ChiTiet_Load(object sender, EventArgs e)
        {

        }
    }


}