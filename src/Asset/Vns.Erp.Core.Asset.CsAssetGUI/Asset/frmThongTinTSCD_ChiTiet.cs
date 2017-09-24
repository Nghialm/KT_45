using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Reflection;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Controls.Commons;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmThongTinTSCD_ChiTiet
    {

        #region Property
        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }

        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }


        private IDmNguonTscdService _DmNguonTscdService;
        public IDmNguonTscdService DmNguonTscdService
        {
            get { return _DmNguonTscdService; }
            set { _DmNguonTscdService = value; }
        }

        private ITsCtTscdNvonService _TsCtTscdNvonService;
        public ITsCtTscdNvonService TsCtTscdNvonService
        {
            get { return _TsCtTscdNvonService; }
            set { _TsCtTscdNvonService = value; }
        }

        private ITsTscdPtungService _TsTscdPtungService;
        public ITsTscdPtungService TsTscdPtungService
        {
            get { return _TsTscdPtungService; }
            set { _TsTscdPtungService = value; }
        }

        private IDmLoaitaisanService _DmLoaitaisanService;
        public IDmLoaitaisanService DmLoaitaisanService
        {
            get { return _DmLoaitaisanService; }
            set { _DmLoaitaisanService = value; }
        }

        private IDmDvtService _DmDvtService;
        public IDmDvtService DmDvtService
        {
            get { return _DmDvtService; }
            set { _DmDvtService = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private IHtDanhmucService _HtDanhmucService;
        public IHtDanhmucService HtDanhmucService
        {
            get { return _HtDanhmucService; }
            set { _HtDanhmucService = value; }
        }

        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }

        private IDmNhomTscdService _DmNhomTscdService;
        public IDmNhomTscdService DmNhomTscdService
        {
            get { return _DmNhomTscdService; }
            set { _DmNhomTscdService = value; }
        }
        #endregion

        #region Constructor

        private void AddEvents()
        {
            //btnSave.Click += btnSave_Click;
            btnRow.Click += btnRow_Click;
            btnDeRow.Click += btnDeRow_Click;
            grlNHOM1.EditValueChanged += grlNHOM_1_EditValueChanged;
            grlNHOM2.EditValueChanged += grlNHOM_2_EditValueChanged;
            grlNHOM3.EditValueChanged += grlNHOM_3_EditValueChanged;
            this.KeyDown += frmThongTinTSCD_ChiTiet_KeyDown;
            btnQuit.Click += btn_Click;
            grlLYDO_TANGGIAM.Validated += grlLYDO_TANGGIAM_Validated;
            btnPrint.Click += btnIn_Click;
            txtMA_TSCD1.Validating += txtMA_TSCD_Validating;
            grvPHU_TUNG_KEM_THEO.InvalidRowException += grvPHU_TUNG_KEM_THEO_InvalidRowException;
            grvNGUON_VON.KeyDown += grvNGUON_VON_KeyDown;
            grvPHU_TUNG_KEM_THEO.KeyDown += grvPHU_TUNG_KEM_THEO_KeyDown;
            grvPHU_TUNG_KEM_THEO.MouseDown += grvPHU_TUNG_KEM_THEO_MouseDown;
            grvNGUON_VON.MouseDown += grvNGUON_VON_MouseDown;
            grvNGUON_VON.CellValueChanged += grvNGUON_VON_CellValueChanged;
            grlMD_TK_KHAUHAO.Validated += grlMD_TK_KHAUHAO_Validated;
            grlMD_TK_CHIPHI.Validated += grlMD_TK_CHIPHI_Validated;
            grlMD_TK_TS.Validated += grlMD_TK_TS_Validated;
            grlLOAITAISAN_ID.Validated += grlLoaiTS_Validated;
            rpeTK_CHIPHI.AfterFilter += rpeTK_CHIPHI_AfterFilter;
            rpeTK_CHIPHI.ClearDataFilter += rpeTK_CHIPHI_ClearDataFilter;
            rpeTK_CHIPHI.FisrtBinddata += rpeTK_CHIPHI_FisrtBinddata;

        }

        public frmThongTinTSCD_ChiTiet()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }
        #endregion

        #region Variables
        private FormGlobals.DataInputState m_InputState;
        private Guid m_TSCD_ID;
        private DmTscd dm_TSCD = new DmTscd();
        private CtTscd CT_TSCD = new CtTscd();
        private List<TsTscdPtung> dt_PhuTung = new List<TsTscdPtung>();
        private List<TsTscdPtung> lst_del_PhuTung = new List<TsTscdPtung>();
        private List<TsCtTscdNvon> dt_nguonvon = new List<TsCtTscdNvon>();
        private List<TsCtTscdNvon> lst_del_nguonvon = new List<TsCtTscdNvon>();
        private TsCtTscdNvon obj_nguonVon = new TsCtTscdNvon();
        private TsTscdPtung obj_PhuTung = new TsTscdPtung();
        private bool bo_pt;
        private bool bo_nv;
        string tk_chi_phi;
        private string Ki_hieu = "";
        private string nhom1 = "";
        private string nhom2 = "";
        private string nhom3 = "";
        #endregion
        List<DmTaikhoan> dt_tk = new List<DmTaikhoan>();

        #region Show_form
        public DmTscd Show_Form(Guid p_TSCD_ID, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_SetText(this, "Thông tin chi tiết", eState);
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_TSCD_ID = p_TSCD_ID;
                Control_set_Require();
                FormGlobals.Control_SetRequire(txtMA_TSCD1, true);
                Check_view();
                this.ActiveControl = grlNHOM1;
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();

            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            if ((this.ShowDialog() == DialogResult.OK))
            {
                return dm_TSCD;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Private functions

        private void Check_view()
        {
            if (m_InputState == FormGlobals.DataInputState.ViewMode)
            {
                FormGlobals.Control_SetState(pn_TSCD_1, FormGlobals.DataInputState.ViewMode);
                FormGlobals.Control_SetState(pn_TSCD_2, FormGlobals.DataInputState.ViewMode);
                FormGlobals.Control_SetState(pn_CT_TSCD, FormGlobals.DataInputState.ViewMode);
                FormGlobals.Control_SetState(grc_PTKT, FormGlobals.DataInputState.ViewMode);
                grvNGUON_VON.OptionsBehavior.Editable = false;
                grvPHU_TUNG_KEM_THEO.OptionsBehavior.Editable = false;
                btnSave.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void Init_Data()
        {
            BindLookup();
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    TsCtTscdNvon obj = new TsCtTscdNvon();
                    obj.LyDoTanggiam = VnsConvert.CGuid(grlLYDO_TANGGIAM.EditValue);

                    dt_nguonvon = new List<TsCtTscdNvon>();
                    grcNGUON_VON.DataSource = dt_nguonvon;

                    dt_PhuTung = new List<TsTscdPtung>();
                    grcPHU_TUNG_KEM_THEO.DataSource = dt_PhuTung;
                    break;
                default:
                    SetObjectToControl();
                    break;
            }
        }

        private void Control_set_Require()
        {
            FormGlobals.Control_SetRequire(txtSO_THANG_SD1, true);
            FormGlobals.Control_SetRequire(txtNGUYEN_GIA1, true);
            FormGlobals.Control_SetRequire(txtGIA_TRI_CL1, true);
            FormGlobals.Control_SetRequire(dteNGAY_BDSD1, true);
            FormGlobals.Control_SetRequire(dteNGAY_TANG1, true);
            FormGlobals.Control_SetRequire(dtxNGAY_BDKH1, true);
            //Control_SetRequire(txtTY_LE_HAOMON1, True)
            FormGlobals.Control_SetRequire(dteNGAY_CT, true);
            FormGlobals.Control_SetRequire(txtSO_CT, true);
            FormGlobals.Control_SetRequire(dteNGAY_TANG1, true);
            FormGlobals.Control_SetRequire(grlMD_TK_CHIPHI, true);
            FormGlobals.Control_SetRequire(grlMD_TK_KHAUHAO, true);
            FormGlobals.Control_SetRequire(grlMD_TK_TS, true);
        }

        private bool Check_InPut()
        {
            if ((string.IsNullOrEmpty(txtSO_THANG_SD1.Text.Trim()) || 
                string.IsNullOrEmpty(txtGIA_TRI_CL1.Text.Trim()) || 
                string.IsNullOrEmpty(txtNGUYEN_GIA1.Text.Trim()) ||
                (dteNGAY_BDSD1.DateTime == null) || 
                string.IsNullOrEmpty(txtSO_CT.Text) || 
                (dteNGAY_TANG1.DateTime == null) || 
                //VnsCheck.IsNullGuid(grlMD_TK_CHIPHI.EditValue) ||
                //VnsCheck.IsNullGuid(grlMD_TK_KHAUHAO.EditValue) ||
                //VnsCheck.IsNullGuid(grlMD_TK_TS.EditValue) ||
                dteNGAY_CT.DateTime == null ||
                dtxNGAY_BDKH1.DateTime == null) ||
                string.IsNullOrEmpty(txtMA_TSCD1.Text))
            {
                FormGlobals.Message_Information("Bạn chưa nhập giá trị cho trường bắt buộc");
                return false;
            }

            decimal he_so = 0;

            if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtNGUYEN_GIA1.Text)))
            {
                FormGlobals.Message_Warning("Giá trị nguyên giá không hợp lệ");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                txtNGUYEN_GIA1.Focus();
                return false;
            }

            if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtGIA_TRI_CL1.Text)))
            {
                FormGlobals.Message_Warning("Giá trị giá trị còn lại không hợp lệ");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                txtGIA_TRI_CL1.Focus();
                return false;
            }

            if (dtxNGAY_MUA1.DateTime != null && dteNGAY_BDSD1.DateTime < dtxNGAY_MUA1.DateTime)
            {
                FormGlobals.Message_Warning("Ngày bắt đầu sử dụng phải > ngày mua");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                dteNGAY_BDSD1.Focus();
                return false;
            }

            if (dteNGAY_BDSD1.DateTime != null && dtxNGAY_BDKH1.DateTime < dteNGAY_BDSD1.DateTime)
            {
                FormGlobals.Message_Warning("Ngày bắt đầu khấu hao >= ngày bắt đầu sử dụng");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                dtxNGAY_BDKH1.Focus();
                return false;
            }

            if (dtxNGAY_MUA1.DateTime != null && dteNGAY_TANG1.DateTime < dtxNGAY_MUA1.DateTime)
            {
                FormGlobals.Message_Warning("Ngày tăng phải >= ngày mua");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                dteNGAY_TANG1.Focus();
                return false;
            }

            if (dteNGAY_KTKH1.DateTime != null && dteNGAY_KTKH1.DateTime < dtxNGAY_BDKH1.DateTime)
            {
                FormGlobals.Message_Warning("Ngày kết thúc khấu hao phải >= ngày bắt đầu khấu hao");
                xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH;
                dteNGAY_KTKH1.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtNGUYEN_GIA1.Text) & !string.IsNullOrEmpty(txtGIA_TRI_CL1.Text))
            {
                if (decimal.Parse(txtNGUYEN_GIA1.Text) < decimal.Parse(txtGIA_TRI_CL1.Text))
                {
                    FormGlobals.Message_Warning("Giá trị còn lại phải nhỏ hơn hoặc bằng nguyên giá!");
                    txtNGUYEN_GIA1.Focus();
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(txtCHIPHI_DV_SD1.Text))
            {
                if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtCHIPHI_DV_SD1.Text)))
                {
                    FormGlobals.Message_Warning("Giá trị chi phí đưa vào sử dụng không hợp lệ");
                    xtpMain.SelectedTabPage = xtpTHONG_TIN_BO_XUNG;
                    txtCHIPHI_DV_SD1.Focus();
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(txtCHIPHI_MUA1.Text))
            {
                if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtCHIPHI_MUA1.Text)))
                {
                    FormGlobals.Message_Warning("Giá trị chi phí mua TSCD không hợp lệ");
                    xtpMain.SelectedTabPage = xtpTHONG_TIN_BO_XUNG;
                    txtCHIPHI_MUA1.Focus();
                    return false;
                }
            }

            List<TsCtTscdNvon> dv = new List<TsCtTscdNvon>();
            dv.AddRange((List<TsCtTscdNvon>)grvNGUON_VON.DataSource);
            if ((dv.Count != 0))
            {

                foreach (TsCtTscdNvon drv in dv)
                {
                    if ((drv.DmNguonTscdId == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa chọn nguồn cho nguồn vốn!");
                        return false;
                    }

                    if ((drv.TkChiphi == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập tài khoản chi phí cho nguồn vốn!");
                        return false;
                    }

                    if (drv.HeSoPbKh < 0)
                    {
                        FormGlobals.Message_Warning("Hệ số phải lớn hơn 0");
                        return false;
                    }
                    else
                    {
                        he_so = he_so + drv.HeSoPbKh;
                    }
                    //If String.IsNullOrEmpty(DB_GetString(drv("HE_SO_PB_KH"))) Then
                    //    Message_Warning("Hệ số phân bổ không được để trống")
                    //    Return False
                    //Else

                    //End If

                    if (string.IsNullOrEmpty(drv.MaTkChiphi))
                    {
                        FormGlobals.Message_Warning("Tài khoản chi phí không được để trống");
                        return false;
                    }
                }

                if ((he_so != 100))
                {
                    FormGlobals.Message_Warning("Tổng hệ số phân bổ của nguồn vốn phải bằng 100%");
                    return false;
                }
            }

            List<TsTscdPtung> dv_phutung = new List<TsTscdPtung>();
            dv_phutung.AddRange((List<TsTscdPtung>)grvPHU_TUNG_KEM_THEO.DataSource);
            if (dv_phutung.Count != 0)
            {

                foreach (TsTscdPtung drv in dv_phutung)
                {
                    if (string.IsNullOrEmpty(drv.TenPtung))
                    {
                        FormGlobals.Message_Warning("Tên phụ tùng không được để trống!");
                        xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO;
                        return false;
                    }

                    if (drv.SoLuong < 0 | drv.SoLuong >= 1000)
                    {
                        FormGlobals.Message_Warning("Giá trị số lượng nhập vào không hợp lệ!");
                        xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO;
                        return false;
                    }
                    //If Not String.IsNullOrEmpty(DB_GetString(drv("SO_LUONG"))) Then

                    //End If

                    if (!LimitValue.CheckVNDCurrency(drv.SoTien))
                    {
                        FormGlobals.Message_Warning("Giá trị số tiền mua vật tư phụ tùng không hợp lệ!");
                        xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO;
                        return false;
                    }
                    //If Not String.IsNullOrEmpty(DB_GetString(drv("SO_TIEN"))) Then

                    //End If

                    if (!LimitValue.CheckQuantity(drv.SoTienNte))
                    {
                        FormGlobals.Message_Warning("Giá trị số tiền ngoại tệ mua vật tư phụ tùng không hợp lệ!");
                        xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO;
                        return false;
                    }
                    //If Not String.IsNullOrEmpty(DB_GetString(drv("SO_TIEN_NTE"))) Then

                    //End If
                }
            }
            return true;
        }


        private void BindLookup()
        {
            //Dim dr As DataRow

            Guid DON_VI_ID = Generals.DON_VI.Id;
            ArrayList objColumnDefine = null;

            List<DmLoaitaisan> dt_DM_LoaiTS = new List<DmLoaitaisan>();
            dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAll());
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenLoaitaisan", "Tên tài sản"));
            FormGlobals.GridLookupEdit_BindData(grlLOAITAISAN_ID, dt_DM_LoaiTS, "KyHieu", "Id", FormGlobals.COMBO_ITEM_REQUIRE, "TenLoaitaisan", txtTenTaiSan, objColumnDefine);

            //bind don vi tinh
            List<DmDvt> dt_DM_DVT = new List<DmDvt>();
            dt_DM_DVT.AddRange(_DmDvtService.GetAllByDonviID(DON_VI_ID));
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenDvt", "Tên đơn vị tính"));
            FormGlobals.GridLookupEdit_BindData(grlDVT_ID, dt_DM_DVT, "TenDvt", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);
            //bind phong ban
            List<DmPhongban> dt_DM_PHONGBAN = new List<DmPhongban>();
            dt_DM_PHONGBAN.AddRange(_DmPhongbanService.GetAllByDonviID(DON_VI_ID));
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"));
            FormGlobals.GridLookupEdit_BindData(grlPHONGBAN_ID, dt_DM_PHONGBAN, "KyHieu", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);
            //'gọi nhiều lần để cho tránh lặp lại phần "Chọn giá trị"

            //bind tai khoan tai san
            List<DmTaikhoan> dt = new List<DmTaikhoan>();
            dt.AddRange(_DmTaikhoanService.GetAllByDonviID(DON_VI_ID));
            IList<DmTaikhoan> dt_DM_Tkhoan = dt;
            objColumnDefine = new ArrayList();

            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"));
            FormGlobals.GridLookupEdit_BindData(grlMD_TK_TS, dt_DM_Tkhoan, "MaTaikhoan", "MaTaikhoan", FormGlobals.COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKTaiSan, objColumnDefine);
            //bind tài khoản khấu hao
            List<DmTaikhoan> dt_DM_Tkhoan_KH = new List<DmTaikhoan>();
            dt_DM_Tkhoan_KH.AddRange(dt);
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"));
            FormGlobals.GridLookupEdit_BindData(grlMD_TK_KHAUHAO, dt_DM_Tkhoan_KH, "MaTaikhoan", "MaTaikhoan", FormGlobals.COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKKhauHao, objColumnDefine);
            //Bind tài khoản chi phí
            List<DmTaikhoan> dt_DM_Tkhoan_CP = new List<DmTaikhoan>();
            dt_DM_Tkhoan_CP.AddRange(dt);
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"));
            FormGlobals.GridLookupEdit_BindData(grlMD_TK_CHIPHI, dt_DM_Tkhoan_CP, "MaTaikhoan", "MaTaikhoan", FormGlobals.COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKChiPhi, objColumnDefine);

            //bind tkts nguon von
            List<DmTaikhoan> dt_tkts = new List<DmTaikhoan>();
            dt_tkts.AddRange(dt);
            cboTK_TAISAN.DataSource = dt_tkts;
            cboTK_TAISAN.DisplayMember = "MaTaikhoan";
            cboTK_TAISAN.ValueMember = "Id";
            cboTK_TAISAN.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            cboTK_TAISAN.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));
            //bind tkcp nguon von
            dt_tk = dt;

            List<DmTaikhoan> dt_tkkh = new List<DmTaikhoan>();
            dt_tkkh.AddRange(dt);
            cboTK_KHAUHAO.DataSource = dt_tkkh;
            cboTK_KHAUHAO.DisplayMember = "MaTaikhoan";
            cboTK_KHAUHAO.ValueMember = "Id";
            cboTK_KHAUHAO.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            cboTK_KHAUHAO.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));
            //bind dm nguon
            List<DmNguonTscd> dt_DM_nguon = new List<DmNguonTscd>();
            dt_DM_nguon.AddRange(_DmNguonTscdService.GetAllByDonviID(DON_VI_ID));
            cboDM_NGUON_TSCD_ID.DataSource = dt_DM_nguon;
            cboDM_NGUON_TSCD_ID.ValueMember = "Id";
            cboDM_NGUON_TSCD_ID.DisplayMember = "KyHieu";
            cboDM_NGUON_TSCD_ID.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboDM_NGUON_TSCD_ID.Columns.Add(new LookUpColumnInfo("TenDmNguonTscd", "Tên nguồn vốn"));

            //bind CBO DVT
            cboDVT.DataSource = dt_DM_DVT;
            cboDVT.ValueMember = "Id";
            cboDVT.DisplayMember = "KyHieu";
            cboDVT.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboDVT.Columns.Add(new LookUpColumnInfo("TenDvt", "Tên đơn vị tính"));

            //bind loai phuong phap tinh khau hao
            List<HtDanhmuc> lst_KH = new List<HtDanhmuc>();
            lst_KH.AddRange(_HtDanhmucService.GetByDoiTuong("PP_TINH_KHAUHAO"));
            objColumnDefine = new ArrayList();
            //objColumnDefine.Add(New LookupEdit_ColumnInfo("DANHMUC_ID", "ID"))
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenDanhmuc", "Tên phương pháp khấu hao"));
            FormGlobals.GridLookupEdit_BindData(grlLOAI_PP_KH, lst_KH, "TenDanhmuc", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);

            //bind Ly do tang giam tai san
            List<DmLydoTgTscd> dt_LyDo_Tang_giam = new List<DmLydoTgTscd>();
            dt_LyDo_Tang_giam.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(1, DON_VI_ID));

            DmLydoTgTscd drlydotg = new DmLydoTgTscd();
            drlydotg.KyHieu = "<Không xác định>";
            drlydotg.Id = Null.NullGuid;
            drlydotg.TenLydoTgTscd = "";
            dt_LyDo_Tang_giam.Insert(0, drlydotg);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenLydoTgTscd", "Tên lý do tăng giảm"));
            FormGlobals.GridLookupEdit_BindData(grlLYDO_TANGGIAM, dt_LyDo_Tang_giam, "KyHieu", "Id", FormGlobals.COMBO_ITEM_REQUIRE, "TenLydoTgTscd", txtTenLyDoTang, objColumnDefine);

            List<DmNhomTscd> dt_NHOM1 = new List<DmNhomTscd>();
            dt_NHOM1.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 1));
            DmNhomTscd drnhom1 = new DmNhomTscd();
            drnhom1.MaNhomTscd = "<Không xác định>";
            drnhom1.Id = Null.NullGuid;
            drnhom1.TenNhomTscd = "";
            dt_NHOM1.Insert(0, drnhom1);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"));
            FormGlobals.GridLookupEdit_BindData(grlNHOM1, dt_NHOM1, "MaNhomTscd", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);

            //bind nhom 2
            List<DmNhomTscd> dt_NHOM2 = new List<DmNhomTscd>();
            dt_NHOM2.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 2));

            DmNhomTscd drnhom2 = new DmNhomTscd();
            drnhom2.MaNhomTscd = "<Không xác định>";
            drnhom2.Id = Null.NullGuid;
            drnhom2.TenNhomTscd = "";
            dt_NHOM2.Insert(0, drnhom2);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"));
            FormGlobals.GridLookupEdit_BindData(grlNHOM2, dt_NHOM2, "MaNhomTscd", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);

            //bind nhom 3
            List<DmNhomTscd> dt_NHOM3 = new List<DmNhomTscd>();
            dt_NHOM3.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 3));

            DmNhomTscd drnhom3 = new DmNhomTscd();
            drnhom3.MaNhomTscd = "<Không xác định>";
            drnhom3.Id = Null.NullGuid;
            drnhom3.TenNhomTscd = "";
            dt_NHOM3.Insert(0, drnhom3);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"));
            FormGlobals.GridLookupEdit_BindData(grlNHOM3, dt_NHOM3, "MaNhomTscd", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);
        }

        private DmTscd KiemTraMa()
        {
            //Dim lst_ma As List(Of DmTscd) = New List(Of DmTscd)
            string ma = "";
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    ma = txtMA_TSCD1.Text;
                    break;
                case FormGlobals.DataInputState.EditMode:
                    if ((dm_TSCD.MaTscd != txtMA_TSCD1.Text))
                    {
                        ma = txtMA_TSCD1.Text;
                    }
                    break;
            }
            return _DmTscdService.GetByMaTSCD(ma, Generals.DON_VI.Id);
        }

        private void GetControlToOBject()
        {
            dm_TSCD.Nhom1 = VnsConvert.CGuid(grlNHOM1.EditValue);
            dm_TSCD.Nhom2 = VnsConvert.CGuid(grlNHOM2.EditValue);
            dm_TSCD.Nhom3 = VnsConvert.CGuid(grlNHOM3.EditValue);
            dm_TSCD.MaTscd = txtMA_TSCD1.Text;
            dm_TSCD.TenTscd = txtTEN_TSCD.Text;
            dm_TSCD.KyHieu = txtKY_HIEU.Text;

            DmLoaitaisan dr_LTS = (DmLoaitaisan)ComboHelper.GetSelectData(grlLOAITAISAN_ID);
            dm_TSCD.LoaitaisanId = dr_LTS.Id;
            //dm_TSCD.MaLoaitaisan = dr_LTS.MaLoaitaisan;
            dm_TSCD.TenLoaitaisan = dr_LTS.TenLoaitaisan;
            dm_TSCD.MaLoaitaisan = dr_LTS.MaLoaitaisan;
            CT_TSCD.LoaitaisanId = dr_LTS.Id;
            CT_TSCD.MaLoaitaisan = dr_LTS.MaLoaitaisan;

            DmTaikhoan dr_TK_TSCD = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_TS);
            if ((dr_TK_TSCD != null))
            {
                dm_TSCD.MdTkTs = dr_TK_TSCD.MaTaikhoan;
            }

            DmTaikhoan dr_TK_KhauHao = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_KHAUHAO);
            if ((dr_TK_KhauHao != null))
            {
                dm_TSCD.MdTkKhauhao = dr_TK_KhauHao.MaTaikhoan;
            }

            DmTaikhoan dr_TK_CHI_PHI = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_CHIPHI);
            if ((dr_TK_CHI_PHI != null))
            {
                CT_TSCD.TkChiphi = dr_TK_CHI_PHI.Id;
                CT_TSCD.MaTkChiphi = dr_TK_CHI_PHI.MaTaikhoan;
                dm_TSCD.MdTkChiphi = dr_TK_CHI_PHI.MaTaikhoan;
            }

            if ((VnsConvert.CGuid(grlLYDO_TANGGIAM.EditValue) != Null.NullGuid))
            {
                //Dim dr_LDTG As DmLydoTgTscd = DirectCast(grlLYDO_TANGGIAM.Properties.DataSource, DataTable).Rows(iRowIdx)
                DmLydoTgTscd dr_LDTG = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLYDO_TANGGIAM);

                CT_TSCD.LydoTanggiam = dr_LDTG.Id;
                CT_TSCD.TenLydoTanggiam = dr_LDTG.TenLydoTgTscd;
                CT_TSCD.LydoTanggiam = dr_LDTG.Id;
            }

            if (grlDVT_ID.EditValue != null)
            {
                DmDvt dr_DVT = (DmDvt)ComboHelper.GetSelectData(grlDVT_ID);
                dm_TSCD.TenDvt = dr_DVT.TenDvt;
                dm_TSCD.MaDvt = dr_DVT.MaDvt;
                CT_TSCD.DvtId = dr_DVT.Id;
                CT_TSCD.MaDvt = dr_DVT.MaDvt;
                CT_TSCD.TenDvt = dr_DVT.TenDvt;
            }

            if (VnsConvert.CGuid(grlPHONGBAN_ID.EditValue) != Null.NullGuid)
            {
                DmPhongban dr_PB = (DmPhongban)ComboHelper.GetSelectData(grlPHONGBAN_ID);
                dm_TSCD.TenPhongban = dr_PB.TenPhongban;
                dm_TSCD.MaPhongban = dr_PB.MaPhongban;
                dm_TSCD.PhongbanId = dr_PB.Id;
            }

            CT_TSCD.NgayCt = dteNGAY_CT.DateTime;
            CT_TSCD.SoCt = txtSO_CT.Text;

            dm_TSCD.NgayMua = dtxNGAY_MUA1.DateTime;
            dm_TSCD.NgayTang = dteNGAY_TANG1.DateTime;
            dm_TSCD.NgayBdsd = dteNGAY_BDSD1.DateTime;
            dm_TSCD.NgayBdkh = dtxNGAY_BDKH1.DateTime;
            dm_TSCD.NgayKtkh = dteNGAY_KTKH1.DateTime;
            CT_TSCD.SoThangSd = VnsConvert.CDecimal(txtSO_THANG_SD1.Text);
            dm_TSCD.NgayGiam = Null.NullDate;
            CT_TSCD.ThuTu = 1;
            CT_TSCD.TenTscd = dm_TSCD.TenTscd;
            CT_TSCD.KyHieuTscd = dm_TSCD.KyHieu;
            CT_TSCD.MaTscd = dm_TSCD.MaTscd;
            CT_TSCD.NgayBdKh = dm_TSCD.NgayBdkh;
            CT_TSCD.NgayKtKh = dteNGAY_KTKH1.DateTime;
            CT_TSCD.NguyenGia = VnsConvert.CDecimal(txtNGUYEN_GIA1.Text);
            CT_TSCD.GiaTriCl = VnsConvert.CDecimal(txtGIA_TRI_CL1.Text);
            dm_TSCD.GiaTriCl = CT_TSCD.GiaTriCl;
            dm_TSCD.NguyenGia = CT_TSCD.NguyenGia;
            dm_TSCD.SoThangSd = CT_TSCD.SoThangSd;

            //CT_TSCD.TY_LE_HAOMON = txtTY_LE_HAOMON1.Text

            //dm_TSCD.MdTkChiphi = grlMD_TK_CHIPHI.EditValue
            //dm_TSCD.MdTkKhauhao = grlMD_TK_KHAUHAO.EditValue
            //dm_TSCD.MdTkTs = grlMD_TK_TS.EditValue

            //grlDVT_ID.EditValue = CT_TSCD.DvtId
            //grlPHONGBAN_ID.EditValue = dm_TSCD.PhongbanId
            //dteNGAY_CT.EditValue = CT_TSCD.NgayCt
            //txtSO_CT.Text = CT_TSCD.SoCt

            //dm_TSCD.MaTscd = txtMA_TSCD1.Text
            //If Not String.IsNullOrEmpty(txtCHIPHI_DV_SD1.Text) Then
            //    dm_TSCD.ChiphiDvSd = Decimal.Parse(txtCHIPHI_DV_SD1.Text)
            //Else
            //    dm_TSCD.ChiphiDvSd = 0
            //End If

            //If Not String.IsNullOrEmpty(txtCHIPHI_MUA1.Text) Then
            //    dm_TSCD.ChiphiMua = Decimal.Parse(txtCHIPHI_MUA1.Text)
            //Else
            //    dm_TSCD.ChiphiMua = 0
            //End If
            //lay cac gia tri con lai
            dm_TSCD.GiamTscd = 0;
            dm_TSCD.DonviId = Generals.DON_VI.Id;
            dm_TSCD.MaDonvi = Generals.DON_VI.MaDonvi;

            dm_TSCD.ChiphiMua = VnsConvert.CDecimal(txtCHIPHI_MUA1.Text);
            dm_TSCD.ChiphiDvSd = VnsConvert.CDecimal(txtCHIPHI_DV_SD1.Text);
            dm_TSCD.ThongsoKythuat = txtTHONGSO_KYTHUAT.Text;
            dm_TSCD.NuocSx = txtNUOC_SX.Text;
            dm_TSCD.NamSx = VnsConvert.CDecimal(txtNAM_SX1.Text);
            dm_TSCD.LoaiPpKh = VnsConvert.CDecimal(grlLOAI_PP_KH.EditValue);
            dm_TSCD.HaoMonLkNte = VnsConvert.CDecimal(txtHAO_MON_LK_NTE.Text);
            dm_TSCD.GiaTriClNte = VnsConvert.CDecimal(txtGIA_TRI_CL_NTE.Text);
            dm_TSCD.SanluongCongsuat = VnsConvert.CDecimal(txtSANLUONG_CONGSUAT.Text);
            dm_TSCD.HeSoDieuChinh = VnsConvert.CDecimal(txtHE_SO_DIEU_CHINH.Text);
            dm_TSCD.TyleKhNhanh = VnsConvert.CDecimal(txtTYLE_KH_NHANH.Text);
            dm_TSCD.HaoMonNam = VnsConvert.CDecimal(txtHAO_MON_NAM.Text);
            dm_TSCD.HaoMonNamNte = VnsConvert.CDecimal(txtHAO_MON_NAM_NTE.Text);
            dm_TSCD.HaoMonLkNte = VnsConvert.CDecimal(txtHAO_MON_LK_NTE.Text);

            dm_TSCD.HaoMonLk = VnsConvert.CDecimal(txtHAO_MON_LK.Text);
            CT_TSCD.HaoMonLuyKe = dm_TSCD.HaoMonLk;
            CT_TSCD.TyLeHaomon = VnsConvert.CDecimal(txtTY_LE_HAOMON1.Text);
            dm_TSCD.TyleKh = VnsConvert.CDecimal(txtTY_LE_HAOMON1.Text);

            IList<TsTscdPtung> dv_PT = null;
            IList<TsCtTscdNvon> dv_NV = null;

            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    dm_TSCD = _DmTscdService.Save(dm_TSCD);
                    //lay gia tri DM_TSCD vua insert dua vao CT_TSCD va insert vao CSDL
                    //Dim obj_dmtscd_new As DmTscd = New DmTscd()
                    CT_TSCD.TscdId = dm_TSCD.Id;

                    if ((dm_TSCD.HaoMonLk != 0))
                    {
                        CT_TSCD.HaoMonLuyKe = dm_TSCD.HaoMonLk;
                    }

                    CT_TSCD.TangTscd = 1;
                    _CtTscdService.Save(CT_TSCD);

                    //insert Nguon von vao CSDL
                    dv_NV = (IList<TsCtTscdNvon>)grvNGUON_VON.DataSource;

                    if ((dv_NV.Count != 0))
                    {
                        foreach (TsCtTscdNvon drv_NV in dv_NV)
                        {
                            //Object_GetDataRawView(obj_nguonVon, drv_NV)
                            drv_NV.CtTscdId = CT_TSCD.Id;
                            drv_NV.MaTkTaisan = dm_TSCD.MdTkTs;
                            drv_NV.MaTkKhauhao = dm_TSCD.MdTkKhauhao;
                            _TsCtTscdNvonService.Save(drv_NV);
                        }
                    }

                    //'insert phu tung
                    dv_PT = (IList<TsTscdPtung>)grvPHU_TUNG_KEM_THEO.DataSource;

                    if (dv_PT.Count != 0)
                    {
                        foreach (TsTscdPtung drw_PT in dv_PT)
                        {
                            //Object_GetDataRawView(obj_PhuTung, drw_PT)
                            drw_PT.DmTscdId = dm_TSCD.Id;
                            _TsTscdPtungService.Save(drw_PT);
                        }
                    }
                    break;
                default:
                    //update DM_TSCD
                    _DmTscdService.SaveOrUpdate(dm_TSCD);
                    //update CT_TSCD
                    _CtTscdService.SaveOrUpdate(CT_TSCD);

                    //'Lấy ra những row được sửa chữa và update vào CSDL 
                    dv_NV = (List<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                    if (dv_NV.Count != 0)
                    {
                        foreach (TsCtTscdNvon drw_NV_Update in dv_NV)
                        {
                            //Object_GetDataRawView(obj_nguonVon, drw_NV_Update)
                            drw_NV_Update.CtTscdId = CT_TSCD.Id;
                            _TsCtTscdNvonService.SaveOrUpdate(drw_NV_Update);
                        }
                    }
                    //'Lấy ra những row dc delete và delete
                    dv_NV = lst_del_nguonvon;
                    if (dv_NV.Count != 0)
                    {
                        foreach (TsCtTscdNvon drw_Delete in dv_NV)
                        {
                            _TsCtTscdNvonService.Delete(drw_Delete);
                        }
                    }

                    //'Update phu phu tung
                    //'Lấy ra những rows dc thêm mới khi update và insert vào CSDl
                    //dv_PT = Grid_GetAddedRows(grvPHU_TUNG_KEM_THEO)
                    //If dv_PT.Count <> 0 Then
                    //    For Each drw_PT_new As TsTscdPtung In dv_PT
                    //        'Object_GetDataRawView(obj_PhuTung, drw_PT_new)
                    //        obj_PhuTung.DmTscdId = dm_TSCD.Id
                    //        _TsTscdPtungService.Save(obj_PhuTung)
                    //    Next
                    //End If
                    //'Lấy ra những rows được update khi update và update vào CSDL
                    dv_PT = (List<TsTscdPtung>)grvPHU_TUNG_KEM_THEO.DataSource;
                    if (dv_PT.Count != 0)
                    {
                        foreach (TsTscdPtung drw_PT_Update in dv_PT)
                        {
                            //Object_GetDataRawView(obj_PhuTung, drw_PT_Update)
                            drw_PT_Update.DmTscdId = dm_TSCD.Id;
                            _TsTscdPtungService.SaveOrUpdate(drw_PT_Update);
                        }
                    }
                    //'Lấy ra những rows dc delete khi update và delete khỏi CSDL
                    dv_PT = lst_del_PhuTung;
                    if (dv_PT.Count != 0)
                    {
                        foreach (TsTscdPtung drw_Delete in dv_PT)
                        {
                            _TsTscdPtungService.Delete(drw_Delete);
                        }
                    }

                    break;
            }
        }

        private void SetObjectToControl()
        {
            //DM_TSCD
            dm_TSCD = _DmTscdService.GetById(m_TSCD_ID);

            grlNHOM1.EditValue = dm_TSCD.Nhom1;
            grlNHOM2.EditValue = dm_TSCD.Nhom2;
            grlNHOM3.EditValue = dm_TSCD.Nhom3;
            txtMA_TSCD1.Text = dm_TSCD.MaTscd;
            txtTEN_TSCD.Text = dm_TSCD.TenTscd;
            txtKY_HIEU.Text = dm_TSCD.KyHieu;

            grlLOAITAISAN_ID.EditValue = dm_TSCD.LoaitaisanId;
            txtTenTaiSan.Text = dm_TSCD.TenLoaitaisan;

            //Lay ten tk chi phi
            grlMD_TK_CHIPHI.EditValue = dm_TSCD.MdTkChiphi;
            DmTaikhoan dr_CP = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_CHIPHI);
            if (dr_CP != null)
            {
                txtTenTKChiPhi.Text = dr_CP.TenTaikhoan;
            }
            grlMD_TK_KHAUHAO.EditValue = dm_TSCD.MdTkKhauhao;
            //Lay ten Tk khau hao
            DmTaikhoan dr_KH = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_KHAUHAO);
            if (dr_KH != null)
            {
                txtTenTKKhauHao.Text = dr_KH.TenTaikhoan;
            }

            grlMD_TK_TS.EditValue = dm_TSCD.MdTkTs;
            //Lay ten tk tài sản
            DmTaikhoan dr_TS = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_TS);
            if (dr_TS != null)
            {
                txtTenTKTaiSan.Text = dr_TS.TenTaikhoan;
            }

            CT_TSCD = _CtTscdService.GetByIdDM_TSCD(m_TSCD_ID);
            if ((CT_TSCD.LydoTanggiam != Null.NullGuid))
            {
                grlLYDO_TANGGIAM.EditValue = CT_TSCD.LydoTanggiam;
                txtTenLyDoTang.Text = CT_TSCD.TenLydoTanggiam;
            }

            grlDVT_ID.EditValue = CT_TSCD.DvtId;
            grlPHONGBAN_ID.EditValue = dm_TSCD.PhongbanId;
            dteNGAY_CT.EditValue = CT_TSCD.NgayCt;
            txtSO_CT.Text = CT_TSCD.SoCt;

            if ((dm_TSCD.NgayMua == null))
            {
                dtxNGAY_MUA1.EditValue = "";
            }
            else
            {
                dtxNGAY_MUA1.DateTime = dm_TSCD.NgayMua.Value;
            }
            dteNGAY_TANG1.DateTime = dm_TSCD.NgayTang.Value;
            dteNGAY_BDSD1.DateTime = dm_TSCD.NgayBdsd.Value;
            dtxNGAY_BDKH1.DateTime = dm_TSCD.NgayBdkh.Value;
            if ((dm_TSCD.NgayKtkh == DateTime.MinValue))
            {
                dteNGAY_KTKH1.EditValue = "";
            }
            else
            {
                dteNGAY_KTKH1.DateTime = dm_TSCD.NgayKtkh.Value;
            }
            txtSO_THANG_SD1.EditValue = dm_TSCD.SoThangSd;
            txtNGUYEN_GIA1.EditValue = CT_TSCD.NguyenGia;
            txtGIA_TRI_CL1.EditValue = CT_TSCD.GiaTriCl;
            txtTY_LE_HAOMON1.EditValue = CT_TSCD.TyLeHaomon;

            txtCHIPHI_DV_SD1.EditValue = dm_TSCD.ChiphiDvSd;
            txtCHIPHI_MUA1.EditValue = dm_TSCD.ChiphiMua;
            txtNAM_SX1.EditValue = dm_TSCD.NamSx;

            txtCHIPHI_MUA1.Text = dm_TSCD.ChiphiMua.ToString();
            txtCHIPHI_DV_SD1.EditValue = dm_TSCD.ChiphiDvSd;
            txtTHONGSO_KYTHUAT.Text = dm_TSCD.ThongsoKythuat;
            txtNUOC_SX.Text = dm_TSCD.NuocSx;
            txtNAM_SX1.EditValue = dm_TSCD.NamSx;
            grlLOAI_PP_KH.EditValue = dm_TSCD.LoaiPpKh;

            txtHAO_MON_LK_NTE.Text = "";
            txtGIA_TRI_CL_NTE.Text = "";
            txtSANLUONG_CONGSUAT.Text = "";
            txtHE_SO_DIEU_CHINH.Text = dm_TSCD.HeSoDieuChinh.ToString();
            txtTYLE_KH_NHANH.Text = dm_TSCD.TyleKhNhanh.ToString();
            txtHAO_MON_NAM.Text = dm_TSCD.HaoMonNam.ToString();
            txtHAO_MON_NAM_NTE.Text = dm_TSCD.HaoMonNamNte.ToString();
            txtHAO_MON_LK.Text = dm_TSCD.HaoMonLk.ToString();

            //PHU_TUNG
            dt_PhuTung.AddRange(_TsTscdPtungService.GetAllByTSCD_ID(m_TSCD_ID));
            grcPHU_TUNG_KEM_THEO.DataSource = dt_PhuTung;
            //'NGUON_VON
            dt_nguonvon.AddRange(TsCtTscdNvonService.GetAllByCT_TSCD_ID(CT_TSCD.Id));
            grcNGUON_VON.DataSource = dt_nguonvon;
        }

        private void Set_TK(string str)
        {
            TsCtTscdNvon dr = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);

            if (dr == null)
                return;

            if (!VnsCheck.IsNullGuid(grlMD_TK_TS.EditValue))
            {
                DmTaikhoan dr_TS = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_TS);

                dr.TkTaisan = dr_TS.Id;
                dr.MaTkTaisan = dr_TS.MaTaikhoan;
            }

            if (!VnsCheck.IsNullGuid(grlMD_TK_KHAUHAO.EditValue))
            {
                DmTaikhoan dr_TS = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_KHAUHAO);
                dr.TkKhauhao = dr_TS.Id;
                dr.MaTkKhauhao = dr_TS.MaTaikhoan;
            }

            if (!VnsCheck.IsNullGuid(grlMD_TK_CHIPHI.EditValue))
            {
                if (string.IsNullOrEmpty(str))
                {
                    DmTaikhoan dr_CP = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_CHIPHI);

                    if (dr_CP != null)
                    {

                        TsCtTscdNvon dr_Nguonvon = (TsCtTscdNvon)ComboHelper.GetSelectData(grvNGUON_VON);
                        dr_Nguonvon.MaTkChiphi = dr_CP.MaTaikhoan;
                        dr_Nguonvon.TkChiphi = dr_CP.Id;
                    }
                }
            }
        }

        #endregion

        #region Events

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!Check_InPut())
                {
                    return;
                }
                if ((FormGlobals.Panel_CheckError(pn_TSCD_1) & FormGlobals.Panel_CheckError(pn_TSCD_2) & FormGlobals.Panel_CheckError(pn_CT_TSCD)))
                {
                    if ((string.IsNullOrEmpty(err.GetError(txtMA_TSCD1)) & string.IsNullOrEmpty(err.GetError(dteNGAY_TANG1)) & string.IsNullOrEmpty(err.GetError(dtxNGAY_BDKH1)) & 
                        string.IsNullOrEmpty(err.GetError(dtxNGAY_MUA1)) & string.IsNullOrEmpty(err.GetError(dteNGAY_KTKH1)) & string.IsNullOrEmpty(err.GetError(dteNGAY_BDSD1))))
                    {
                        frmProgress.Instance().Thread = GetControlToOBject;
                        frmProgress.Instance().Show_Progress();
                        frmProgress.Instance().SetFinishText("Ghi dữ liệu thành công");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        FormGlobals.Message_Warning("Bạn không thể lưu, xin kiểm tra lại dữ liệu!");
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnRow_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if ((xtpMain.SelectedTabPageIndex == 2 & bo_pt == true & ExistError(grvPHU_TUNG_KEM_THEO)))
                {
                    FormGlobals.Grid_AddRow(grvPHU_TUNG_KEM_THEO);
                }
                else if (bo_nv == true & ExistError(grvNGUON_VON))
                {
                    FormGlobals.Grid_AddRow(grvNGUON_VON);
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDeRow_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if ((xtpMain.SelectedTabPageIndex == 2) & bo_pt == true & ExistError(grvPHU_TUNG_KEM_THEO))
                {
                    grvPHU_TUNG_KEM_THEO.DeleteSelectedRows();
                }
                else if (bo_nv == true & ExistError(grvNGUON_VON))
                {
                    grvNGUON_VON.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private string A;
        private string B;

        private string C;
        private void MA_TSCD()
        {
            if (VnsConvert.CGuid(grlNHOM1.EditValue) != Null.NullGuid)
            {
                A = grlNHOM1.Text.ToString() + ".";
            }
            else
            {
                A = "";
            }
            if (VnsConvert.CGuid(grlNHOM2.EditValue) != Null.NullGuid)
            {
                B = grlNHOM2.Text.ToString() + ".";
            }
            else
            {
                B = "";
            }
            if (VnsConvert.CGuid(grlNHOM3.EditValue) != Null.NullGuid)
            {
                C = grlNHOM3.Text.ToString() + ".";
            }
            else
            {
                C = "";
            }
            string str = "";
            //Dim Ma_TS As Integer = _DmTscdService.GetLikeMa(A + B + C, Generals.DON_VI.Id)
            int Ma_TS = 1;

            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    if ((Ma_TS < 10))
                    {
                        str = "000" + Ma_TS.ToString();
                    }
                    else if (Ma_TS > 9 & Ma_TS < 100)
                    {
                        str = "00" + Ma_TS.ToString();
                    }
                    else if (Ma_TS > 99 & Ma_TS < 1000)
                    {
                        str = "0" + Ma_TS.ToString();
                    }
                    else
                    {
                        str = Ma_TS.ToString();
                    }
                    txtMA_TSCD1.Text = A + B + C + str;
                    break;
            }
        }

        private void grlNHOM_1_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        MA_TSCD();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlNHOM_2_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        MA_TSCD();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlNHOM_3_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        MA_TSCD();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmThongTinTSCD_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {

            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                    case Keys.F2:
                        if (m_InputState != FormGlobals.DataInputState.ViewMode)
                        {
                            btnSave_Click(btnSave, e);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btn_Click(System.Object sender, System.EventArgs e)
        {
           
        }

        private void grlLYDO_TANGGIAM_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmLydoTgTscd dr = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLYDO_TANGGIAM);
                if ((dr != null))
                {
                    txtTenLyDoTang.Text = dr.TenLydoTgTscd;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnIn_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string str = dm_TSCD.Id.ToString();
                List<DmTscd> lstTscd = new List<DmTscd>();
                lstTscd.Add(dm_TSCD);

                if ((!string.IsNullOrEmpty(str)))
                {
                    The_TSCD rpt = (The_TSCD) ObjectFactory.GetObject("The_TSCD", new object[] {
					str,
					lstTscd
				});
                    rpt.ShowPreview();
                }
                else
                {
                    FormGlobals.Message_Information("Không có bản ghi nào được lựa chọn");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion

        #region Validate

        private void txtMA_TSCD_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if ((KiemTraMa() != null))
                {
                    err.SetError(txtMA_TSCD1, "Mã này đã tồn tại");
                    err.SetIconAlignment(txtMA_TSCD1, ErrorIconAlignment.MiddleRight);
                    e.Cancel = true;
                }
                else
                {
                    err.SetError(txtMA_TSCD1, "");
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvPHU_TUNG_KEM_THEO_InvalidRowException(System.Object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        //Private Sub grvNGUON_VON_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grvNGUON_VON.ValidateRow
        //    Try
        //        Dim view As ColumnView = CType(sender, ColumnView)
        //        Dim NGUON As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("DM_NGUON_TSCD_ID"))
        //        If (NGUON = "") Then
        //            e.Valid = False
        //            view.SetColumnError(view.Columns("DM_NGUON_TSCD_ID"), "Nguồn vốn không được để trống")
        //        End If

        //    Catch ex As Exception
        //        Message_Error(ex)
        //    End Try
        //End Sub

        //Private Sub grvNGUON_VON_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grvNGUON_VON.InvalidRowException
        //    e.ExceptionMode = ExceptionMode.NoAction
        //End Sub
        #endregion

        #region Danh cho grid

        //Check Validate cho Grid
        private bool ExistError(GridView grv)
        {
            foreach (GridColumn gcol in grv.Columns)
            {
                if (!string.IsNullOrEmpty(grv.GetColumnError(gcol)) | grv.GetColumnError(gcol) == null)
                {
                    return true;
                }
            }
            //
            return false;
        }
       

        private void GridAddNewRow(DevExpress.XtraGrid.Views.Grid.GridView grv, bool byTab = false)
        {
            //Chưa có DataSource
            if (grv.DataSource == null)
            {
                FormGlobals.Message_Warning("Chưa có thì thêm vào!!!");
                return;
            }

            //--- Trường hợp: Là dòng dưới cùng thực sự
            switch (grv.Name)
            {
                case "grvNGUON_VON":
                    if ((GridHelper.CheckAddNewRow(grvNGUON_VON) | !byTab))
                    {
                        if (dt_nguonvon == null)
                        {
                            dt_nguonvon = new List<TsCtTscdNvon>();
                        }

                        dt_nguonvon.Add(new TsCtTscdNvon());
                        grvNGUON_VON.RefreshData();
                    }
                    break;
                case "grvPHU_TUNG_KEM_THEO":
                    if ((GridHelper.CheckAddNewRow(grvPHU_TUNG_KEM_THEO) | !byTab))
                    {
                        if (dt_PhuTung == null)
                        {
                            dt_PhuTung = new List<TsTscdPtung>();
                        }

                        dt_PhuTung.Add(new TsTscdPtung());
                        grvPHU_TUNG_KEM_THEO.RefreshData();
                    }

                    break;
            }
        }

        private void grvNGUON_VON_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                //'Bắt sự kiện khi enter thêm dòng mới vào gridview
                ColumnView view = (ColumnView)sender;

                if (m_InputState == FormGlobals.DataInputState.ViewMode)
                {
                    return;
                }
                // Dim obj As DataRowView = grvNGUON_VON.GetDataRow(grvNGUON_VON.FocusedRowHandle)
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, true);
                        string str = view.GetRowCellDisplayText(grvNGUON_VON.FocusedRowHandle, view.Columns["MaTkChiphi"]);
                        Set_TK(str);
                        break;
                    case Keys.F4:
                        if (FormGlobals.Message_Confirm("Bạn có muốn thêm dòng mới?"))
                        {
                            //Grid_AddRow(sender)
                            GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, false);
                            string str1 = view.GetRowCellDisplayText(grvNGUON_VON.FocusedRowHandle, view.Columns["MaTkChiphi"]);
                            Set_TK(str1);
                        }
                        break;
                    case Keys.F8:
                        if (grvNGUON_VON.RowCount != 0)
                        {
                            if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa?"))
                            {
                                //Grid_DeleteSelectRows(grvNGUON_VON)
                                TsCtTscdNvon delnv = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                                lst_del_nguonvon.Add(delnv);
                                FormGlobals.Grid_DeleteSelectRows(grvNGUON_VON);
                            }
                        }
                        else
                        {
                            FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvPHU_TUNG_KEM_THEO_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //'Bắt sự kiện khi enter thêm dòng mới vào gridview
            try
            {
                if (m_InputState != FormGlobals.DataInputState.ViewMode)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, true);
                            break;
                        case Keys.F4:
                            if (FormGlobals.Message_Confirm("Bạn có muốn thêm 1 dòng mới"))
                            {
                                GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, false);
                                //Grid_AddRow(grvPHU_TUNG_KEM_THEO)
                            }
                            break;
                        case Keys.F8:
                            if (grvPHU_TUNG_KEM_THEO.RowCount != 0)
                            {
                                if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa?"))
                                {
                                    TsTscdPtung delpt = (TsTscdPtung)grvPHU_TUNG_KEM_THEO.GetRow(grvPHU_TUNG_KEM_THEO.FocusedRowHandle);
                                    lst_del_PhuTung.Add(delpt);
                                    FormGlobals.Grid_DeleteSelectRows(grvPHU_TUNG_KEM_THEO);
                                }
                            }
                            else
                            {
                                FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvPHU_TUNG_KEM_THEO_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bo_nv = false;
            bo_pt = true;
        }

        private void grvNGUON_VON_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bo_nv = true;
            bo_pt = false;
        }

        private void grvNGUON_VON_CellValueChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                TsCtTscdNvon dr_view = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                switch (e.Column.Name)
                {
                    //Case "TK_TAISAN"
                    //    Dim cboTK_TS As DataRowView = CType(cboTK_TAISAN.GetDataSourceRowByKeyValue(Grid_GetDataRowItemString(grvNGUON_VON, "TK_TAISAN")), DataRowView)
                    //    If cboTK_TS IsNot Nothing Then
                    //        dr_view("MA_TK_TAISAN") = cboTK_TS("MaTaikhoan")
                    //    End If
                    //    dr_view("TK_TAISAN") = cboTK_TS("Id")
                    //    'dr_view("TK_CHIPHI") = cboTK_CP("Id")
                    //Case "TK_KHAUHAO"
                    //    Dim cboTK_KH As DataRowView = CType(cboTK_KHAUHAO.GetDataSourceRowByKeyValue(Grid_GetDataRowItemString(grvNGUON_VON, "TK_KHAUHAO")), DataRowView)
                    //    If cboTK_KH IsNot Nothing Then
                    //        dr_view("MA_TK_KHAUHAO") = cboTK_KH("MaTaikhoan")
                    //    End If
                    //Case "MA_TK_CHIPHI"
                    case "DM_NGUON_TSCD_ID":
                        DmNguonTscd dr_nguon = (DmNguonTscd)ComboHelper.GetSelectData(cboDM_NGUON_TSCD_ID, dr_view.DmNguonTscdId);
                        dr_view.DmNguonTscdId = dr_nguon.Id;
                        break;
                    //If dr_nguon IsNot Nothing Then
                    //    dr_view("TEN_NGUON") = dr_nguon.TenDmNguonTscd
                    //End If
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlMD_TK_KHAUHAO_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmTaikhoan dr_KH = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_KHAUHAO);


                if (dr_KH != null)
                {
                    if (dr_KH.ChiTiet != 1)
                    {
                        FormGlobals.Message_Warning("Giá trị lựa chọn không hợp lệ");
                        grlMD_TK_KHAUHAO.EditValue = null;
                        txtTenTKKhauHao.Text = "";
                        grlMD_TK_KHAUHAO.Focus();
                        return;
                    }
                    else
                    {
                        txtTenTKKhauHao.Text = dr_KH.TenTaikhoan;
                    }

                    if ((grvNGUON_VON.RowCount != 0))
                    {
                        List<TsCtTscdNvon> dv = (List<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                        if ((dr_KH != null))
                        {
                            foreach (TsCtTscdNvon drv in dv)
                            {
                                drv.TkKhauhao = dr_KH.Id;
                                drv.MaTkKhauhao = dr_KH.MaTaikhoan;
                            }
                        }
                        grvNGUON_VON.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlMD_TK_CHIPHI_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmTaikhoan dr_CP = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_CHIPHI);


                if (dr_CP != null)
                {
                    if (dr_CP.ChiTiet != 1)
                    {
                        FormGlobals.Message_Warning("Giá trị lựa chọn không hợp lệ");
                        grlMD_TK_CHIPHI.EditValue = null;
                        txtTenTKChiPhi.Text = "";
                        grlMD_TK_CHIPHI.Focus();
                        return;
                    }
                    else
                    {
                        txtTenTKChiPhi.Text = dr_CP.TenTaikhoan;
                    }

                    if ((grvNGUON_VON.RowCount != 0))
                    {
                        List<TsCtTscdNvon> dv = (List<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                        if ((dr_CP != null))
                        {
                            foreach (TsCtTscdNvon drv in dv)
                            {
                                drv.MaTkChiphi = dr_CP.MaTaikhoan;
                                drv.TkChiphi = dr_CP.Id;
                            }
                        }
                        grvNGUON_VON.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlMD_TK_TS_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmTaikhoan dr_TS = (DmTaikhoan)ComboHelper.GetSelectData(grlMD_TK_TS);

                if (dr_TS != null)
                {
                    if (dr_TS.ChiTiet != 1)
                    {
                        FormGlobals.Message_Warning("Giá trị lựa chọn không hợp lệ");
                        grlMD_TK_TS.EditValue = null;
                        txtTenTKTaiSan.Text = "";
                        grlMD_TK_TS.Focus();
                        return;
                    }
                    else
                    {
                        txtTenTKTaiSan.Text = dr_TS.TenTaikhoan;
                    }

                    if ((grvNGUON_VON.RowCount != 0))
                    {
                        List<TsCtTscdNvon> dv = (List<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                        foreach (TsCtTscdNvon drv in dv)
                        {
                            drv.TkTaisan = dr_TS.Id;
                            drv.MaTkTaisan = dr_TS.MaTaikhoan;
                        }
                        grvNGUON_VON.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlLoaiTS_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmLoaitaisan dr_LTS = (DmLoaitaisan)ComboHelper.GetSelectData(grlLOAITAISAN_ID);
                if (dr_LTS != null)
                {
                    txtTenTaiSan.Text = dr_LTS.TenLoaitaisan;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeTK_CHIPHI_AfterFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                TsCtTscdNvon dr_grv_NGUONVON = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                int rowHandle = grvNGUON_VON.FocusedRowHandle;
                string columnName = grvNGUON_VON.FocusedColumn.Name;
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                switch (columnName)
                {
                    case "MaTkChiphi":
                        List<string> arr = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES;
                        grvNGUON_VON.BeginDataUpdate();
                        if ((arr.Count > 1))
                        {
                            dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(arr[0]);
                            dr_grv_NGUONVON.MaTkChiphi = arr[1];
                            grvNGUON_VON.SetRowCellValue(rowHandle, "MaTkChiphi", arr[1]);
                        }
                        grvNGUON_VON.EndDataUpdate();
                        break;
                }
                SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeTK_CHIPHI_ClearDataFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                TsCtTscdNvon dr_grv_NGUONVON = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                int rowHandle = grvNGUON_VON.FocusedRowHandle;
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                if (rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[1];
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeTK_CHIPHI_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                rpeTK_CHIPHI.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt_tk);
                rpeTK_CHIPHI.Editors.A_DATA_SOURCE = rpeTK_CHIPHI.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        private void btnQuit_Click(object sender, EventArgs e)
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




    }
}