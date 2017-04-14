using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDieuChinhGiaTriTaiSan_ChiTiet
    {
        #region Property

        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private ITsCtTscdNvonService _TsCtTscdNvonService;
        public ITsCtTscdNvonService TsCtTscdNvonService
        {
            get { return _TsCtTscdNvonService; }
            set { _TsCtTscdNvonService = value; }
        }

        private IHtDanhmucService _HtDanhmucService;
        public IHtDanhmucService HtDanhmucService
        {
            get { return _HtDanhmucService; }
            set { _HtDanhmucService = value; }
        }

        private IDmNguonTscdService _DmNguonTscdService;
        public IDmNguonTscdService DmNguonTscdService
        {
            get { return _DmNguonTscdService; }
            set { _DmNguonTscdService = value; }
        }

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }

        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }
        #endregion

        #region Variable

        private FormGlobals.DataInputState m_InputState;
        private Guid m_CT_TSCD_ID;
        private Guid m_DM_TSCD_ID;
        private CtTscd obj_CT_TSCD = new CtTscd();
        private DmTscd obj_DM_TSCD = new DmTscd();
        private List<CtTscd> lst_CT_TSCD = new List<CtTscd>();
        private List<TsCtTscdNvon> dt_nguonvon = new List<TsCtTscdNvon>();
        private IList<TsCtTscdNvon> lst_del = new List<TsCtTscdNvon>();
        private TsCtTscdNvon obj_nguonVon = new TsCtTscdNvon();
        private TsLsKhauhao LS_TSCD = new TsLsKhauhao();
        private DataTable dt_tk_khauhao;
        #endregion
        private DataTable dt_tk_chiphi;

        #region Show_form
        private void AddEvents()
        {
            grlTANG_TSCD1.EditValueChanged += grlTANG_TSCD_EditValueChanged;
            KeyDown += frmDieuChinhGiaTriTaiSan_ChiTiet_KeyDown;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            dteNgay_BD_KH1.Validating += dteNgay_BD_KH_Validating;
            grlLYDO_TANGGIAM.EditValueChanged += grlLYDO_TANGGIAM_EditValueChanged;
            txtNGUYEN_GIA1.TextChanged += txtNGUYEN_GIA1_TextChanged;
            grvNGUON_VON.KeyDown += grvNGUON_VON_KeyDown;
            dteNgay_BD_KH1.Validated += dteNgay_BD_KH_Validated;
            dteNGAY_KT_KH1.Validating += dteNGAY_KT_KH_Validating;
            rpeTK_TAISAN.FisrtBinddata += rpeTK_TAISAN_FisrtBinddata;
            rpeTK_TAISAN.AfterFilter += rpeTK_TAISAN_AfterFilter;
            rpeTK_TAISAN.ClearDataFilter += rpeTK_TAISAN_ClearDataFilter;
            rpeTK_CHIPHI.FisrtBinddata += rpeTK_CHIPHI_FisrtBinddata;
            rpeTK_CHIPHI.AfterFilter += rpeTK_CHIPHI_AfterFilter;
            rpeTK_CHIPHI.ClearDataFilter += rpeTK_CHIPHI_ClearDataFilter;
        }

        public frmDieuChinhGiaTriTaiSan_ChiTiet()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        public bool Show_Form(Guid p_CT_TSCD_ID, Guid p_DM_TSCD_ID, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_SetText(this, "Điều chỉnh giá trị tài sản", eState);
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_CT_TSCD_ID = p_CT_TSCD_ID;
                m_DM_TSCD_ID = p_DM_TSCD_ID;
                //Control_SetRequire(txtTY_LE_HAOMON1, True)
                SetRequire();

                obj_DM_TSCD = _DmTscdService.GetById(p_DM_TSCD_ID);
                txtMA_TSCD.Text = obj_DM_TSCD.MaTscd;
                txtTenTS.Text = obj_DM_TSCD.TenTscd;

                FormGlobals.Panel_InitControl(grcTHONG_TIN_CHINH, "CT_TSCD");
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
            return (this.ShowDialog() == DialogResult.OK);
        }
        #endregion

        #region Functions

        private void Init_Data()
        {
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    BindLookup();
                    dt_nguonvon = new List<TsCtTscdNvon>();
                    grcNGUON_VON.DataSource = dt_nguonvon;
                    break;
                default:
                    BindLookup();
                    SetObjectToControl();
                    break;
            }
        }

        private void SetRequire()
        {
            FormGlobals.Control_SetRequire(txtSO_THANG_SD1, true);
            FormGlobals.Control_SetRequire(txtNGUYEN_GIA1, true);
            FormGlobals.Control_SetRequire(txtHAO_MON_LUY_KE1, true);
            FormGlobals.Control_SetRequire(txtGIA_TRI_CL1, true);
            FormGlobals.Control_SetRequire(dteNgay_BD_KH1, true);
            FormGlobals.Control_SetRequire(grlTANG_TSCD1, true);
            FormGlobals.Control_SetRequire(dteNGAY_CT1, true);
            FormGlobals.Control_SetRequire(txtSO_CT1, true);
            FormGlobals.Control_SetRequire(grlLYDO_TANGGIAM, true);
        }

        private bool Check_Input()
        {

            if ((string.IsNullOrEmpty(txtGIA_TRI_CL1.Text) | string.IsNullOrEmpty(txtHAO_MON_LUY_KE1.Text) | string.IsNullOrEmpty(txtNGUYEN_GIA1.Text) | 
                string.IsNullOrEmpty(txtSO_THANG_SD1.Text) | 
                //VnsCheck.IsNullGuid(grlTANG_TSCD1.EditValue) |
                //VnsCheck.IsNullGuid(grlLYDO_TANGGIAM.EditValue) |
                dteNGAY_CT1.DateTime == null | string.IsNullOrEmpty(txtSO_CT1.Text)))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập giá trị cho trường bắt buộc");
                return false;
            }

            if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtNGUYEN_GIA1.Text)))
            {
                FormGlobals.Message_Warning("Giá trị nguyên giá không hợp lệ");
                txtNGUYEN_GIA1.Focus();
                return false;
            }

            if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtGIA_TRI_CL1.Text)))
            {
                FormGlobals.Message_Warning("Giá trị giá trị còn lại không hợp lệ");
                txtGIA_TRI_CL1.Focus();
                return false;
            }

            if (!LimitValue.CheckVNDCurrency(decimal.Parse(txtHAO_MON_LUY_KE1.Text)))
            {
                FormGlobals.Message_Warning("Giá trị hao mòn lũy kế không hợp lệ");
                txtHAO_MON_LUY_KE1.Focus();
                return false;
            }

            decimal he_so = 0;
            IList<TsCtTscdNvon> dv = (IList<TsCtTscdNvon>)grvNGUON_VON.DataSource;
            if ((dv.Count != 0))
            {

                foreach (TsCtTscdNvon drv in dv)
                {
                    if ((drv.DmNguonTscdId == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa chọn nguồn vốn!");
                        return false;
                    }

                    if ((drv.TkKhauhao == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập tài khoản khấu hao!");
                        return false;
                    }

                    if ((drv.TkChiphi == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Tài khoản chi phí nhập vào không đúng!");
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
                }

                if ((he_so != 100))
                {
                    FormGlobals.Message_Warning("Tổng hệ số phân bổ của nguồn vốn phải bằng 100%");
                    return false;
                }
            }

            return true;
        }


        private void BindLookup()
        {
            IList<HtDanhmuc> dt = new List<HtDanhmuc>();

            List<HtDanhmuc> dt_All = new List<HtDanhmuc>();
            dt_All.AddRange(_HtDanhmucService.GetByDoiTuong("KIEU_THAYDOI_TSCD"));

            foreach (HtDanhmuc dr_all in dt_All)
            {
                HtDanhmuc dr = new HtDanhmuc();
                if ((dr_all.GiaTri == 2 | dr_all.GiaTri == 3))
                {
                    dr.GiaTri = dr_all.GiaTri;
                    dr.TenDanhmuc = dr_all.TenDanhmuc;
                    dt.Add(dr);
                }
            }
            grlTANG_TSCD1.Properties.DataSource = dt;
            grlTANG_TSCD1.Properties.ValueMember = "GiaTri";
            grlTANG_TSCD1.Properties.DisplayMember = "TenDanhmuc";

            ArrayList objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("GiaTri", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenDanhmuc", "Loại tăng giảm"));
            FormGlobals.GridLookupEdit_BindData(grlTANG_TSCD1, dt, "TenDanhmuc", "GiaTri", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);

            List<DmNguonTscd> dt_DM_nguon = new List<DmNguonTscd>();
            dt_DM_nguon.AddRange(_DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id));
            cboDM_NGUON_TSCD_ID.DataSource = dt_DM_nguon;
            cboDM_NGUON_TSCD_ID.ValueMember = "Id";
            cboDM_NGUON_TSCD_ID.DisplayMember = "KyHieu";
            cboDM_NGUON_TSCD_ID.Columns.Add(new LookUpColumnInfo("KyHieu", "Ký hiệu"));
            cboDM_NGUON_TSCD_ID.Columns.Add(new LookUpColumnInfo("TenDmNguonTscd", "Tên nguồn vốn"));

            //bind tkts nguon von
            List<DmTaikhoan> dt_Tk = new List<DmTaikhoan>();
            dt_Tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));

            dt_tk_khauhao = Vns.Erp.Core.DataHelper.ToDataTable(dt_Tk);
            dt_tk_chiphi = Vns.Erp.Core.DataHelper.ToDataTable(dt_Tk);
        }

        private void GetControlToOBject()
        {
            decimal Thu_Tu = default(decimal);
            List<CtTscd> lst = new List<CtTscd>();
            lst.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(m_DM_TSCD_ID));

            Thu_Tu = lst.Count + 1;
            //Panel_GetControlValue(grcTHONG_TIN_CHINH, obj_CT_TSCD)
            obj_CT_TSCD.MaTscd = obj_DM_TSCD.MaTscd;
            obj_CT_TSCD.TscdId = obj_DM_TSCD.Id;
            obj_CT_TSCD.TenTscd = obj_DM_TSCD.TenTscd;
            obj_CT_TSCD.KyHieuTscd = obj_DM_TSCD.KyHieu;
            obj_CT_TSCD.DvtId = obj_DM_TSCD.DvtId;
            obj_CT_TSCD.TenDvt = obj_DM_TSCD.TenDvt;
            obj_CT_TSCD.LoaitaisanId = obj_DM_TSCD.LoaitaisanId;
            obj_CT_TSCD.MaLoaitaisan = obj_DM_TSCD.MaLoaitaisan;
            //obj_CT_TSCD.TkChiphi = obj_DM_TSCD.MdTkChiphi

            obj_CT_TSCD.NgayBdKh = dteNgay_BD_KH1.DateTime;
            obj_CT_TSCD.NgayKtKh = dteNGAY_KT_KH1.DateTime;
            obj_CT_TSCD.TangTscd = VnsConvert.CDecimal(grlTANG_TSCD1.EditValue);

            if (grlLYDO_TANGGIAM.EditValue != null)
            {
                DmLydoTgTscd obj_LYDOTG = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLYDO_TANGGIAM);
                obj_CT_TSCD.LydoTanggiam = obj_LYDOTG.Id;
                obj_CT_TSCD.TenLydoTanggiam = obj_LYDOTG.TenLydoTgTscd;
            }
            else
            {
                obj_CT_TSCD.LydoTanggiam = Null.NullGuid;
                obj_CT_TSCD.TenLydoTanggiam = "";
            }

            obj_CT_TSCD.GiaTriCl = VnsConvert.CDecimal(txtGIA_TRI_CL1.Text);
            obj_CT_TSCD.HaoMonLuyKe = VnsConvert.CDecimal(txtHAO_MON_LUY_KE1.Text);
            obj_CT_TSCD.NguyenGia = VnsConvert.CDecimal(txtNGUYEN_GIA1.Text);
            obj_CT_TSCD.NgayKtKh = dteNGAY_KT_KH1.DateTime;
            obj_CT_TSCD.SoThangSd = VnsConvert.CDecimal(txtSO_THANG_SD1.Text);
            obj_CT_TSCD.SoCt = txtSO_CT1.Text;
            obj_CT_TSCD.NgayCt = dteNGAY_CT1.DateTime;

            IList<TsCtTscdNvon> dv_NV = new List<TsCtTscdNvon>();

            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    obj_CT_TSCD.ThuTu = Thu_Tu;
                    _CtTscdService.Save(obj_CT_TSCD);

                    dv_NV = (IList<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                    if (dv_NV.Count != 0)
                    {
                        foreach (TsCtTscdNvon drw_NV in dv_NV)
                        {
                            //Object_GetDataRawView(obj_nguonVon, drw_NV)
                            drw_NV.CtTscdId = obj_CT_TSCD.Id;
                            _TsCtTscdNvonService.Save(drw_NV);
                        }
                    }
                    break;
                default:
                    _CtTscdService.SaveOrUpdate(obj_CT_TSCD);

                    //Update NGUON_VON
                    //'lấy ra những row dc thêm mới khi update và insert vào CSDL
                    //dv_NV = Grid_GetAddedRows(grvNGUON_VON)
                    dv_NV = (IList<TsCtTscdNvon>)grvNGUON_VON.DataSource;
                    if (dv_NV.Count != 0)
                    {
                        foreach (TsCtTscdNvon drw_NV_new in dv_NV)
                        {
                            //Object_GetDataRawView(obj_nguonVon, drw_NV_new)
                            drw_NV_new.CtTscdId = m_CT_TSCD_ID;
                            //drw_NV_new.MaTkTaisan = obj_CT_TSCD.md;
                            //drw_NV_new.MaTkKhauhao = obj_CT_TSCD.MdTkKhauhao;
                            if ((drw_NV_new.Id == Null.NullGuid))
                            {
                                _TsCtTscdNvonService.Save(drw_NV_new);
                            }
                            else
                            {
                                _TsCtTscdNvonService.SaveOrUpdate(drw_NV_new);
                            }
                        }
                    }
                    //'Lấy ra những row dc delete và delete
                    //dv_NV = Grid_GetDeletedRows(grvNGUON_VON)
                    if (dv_NV.Count != 0)
                    {
                        foreach (TsCtTscdNvon drw_Delete in lst_del)
                        {
                            _TsCtTscdNvonService.DeleteById(drw_Delete.Id);
                        }
                    }
                    break;
            }

        }

        private void SetObjectToControl()
        {
            obj_CT_TSCD = _CtTscdService.GetById(m_CT_TSCD_ID);

            txtGIA_TRI_CL1.EditValue = obj_CT_TSCD.GiaTriCl;
            txtSO_THANG_SD1.EditValue = obj_CT_TSCD.SoThangSd;
            txtNGUYEN_GIA1.EditValue = obj_CT_TSCD.NguyenGia;
            //txtNGUYEN_GIA1.EditValue = Format(CLng(obj_CT_TSCD.NGUYEN_GIA.ToString()), "n0")
            txtHAO_MON_LUY_KE1.EditValue = obj_CT_TSCD.HaoMonLuyKe;
            //txtTY_LE_HAOMON1.Text = obj_CT_TSCD.TY_LE_HAOMON.ToString()
            grlTANG_TSCD1.EditValue = obj_CT_TSCD.TangTscd;
            grlLYDO_TANGGIAM.EditValue = obj_CT_TSCD.LydoTanggiam;

            txtSO_CT1.Text = obj_CT_TSCD.SoCt;
            dteNGAY_CT1.DateTime = obj_CT_TSCD.NgayCt.Value;
            dteNgay_BD_KH1.DateTime = obj_CT_TSCD.NgayBdKh.Value;

            if (obj_CT_TSCD.NgayKtKh == null)
            {
                dteNGAY_KT_KH1.DateTime = obj_CT_TSCD.NgayKtKh.Value;
            }
            else
            {
                dteNGAY_KT_KH1.EditValue = null;
            }

            dteNGAY_CT1.DateTime = obj_CT_TSCD.NgayCt.Value;
            //dteNGAY_KT_KH1.DateTime = Date.Parse(obj_CT_TSCD.NGAY_KT_KH)

            bindLyTangGiam(obj_CT_TSCD.TangTscd);
            //Panel_SetControlValue(grcTHONG_TIN_CHINH, obj_CT_TSCD, True)

            //bind  nguon von
            dt_nguonvon = new List<TsCtTscdNvon>();
            dt_nguonvon.AddRange(_TsCtTscdNvonService.GetAllByCT_TSCD_ID(m_CT_TSCD_ID));
            grcNGUON_VON.DataSource = dt_nguonvon;

            LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(m_DM_TSCD_ID, obj_CT_TSCD.NgayBdKh.Value);
        }

        private void bindLyTangGiam(decimal i)
        {
            List<DmLydoTgTscd> lst_LyDo_Tang_giam = new List<DmLydoTgTscd>();
            lst_LyDo_Tang_giam.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(i, Generals.DON_VI.Id));
            grlLYDO_TANGGIAM.Properties.DataSource = lst_LyDo_Tang_giam;
            grlLYDO_TANGGIAM.Properties.ValueMember = "Id";
            grlLYDO_TANGGIAM.Properties.DisplayMember = "KyHieu";
        }

        #endregion

        #region Events

        private void grlTANG_TSCD_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                grlLYDO_TANGGIAM.Properties.ReadOnly = false;
                txtNGUYEN_GIA1.Properties.ReadOnly = false;
                txtGIA_TRI_CL1.Properties.ReadOnly = false;
                txtHAO_MON_LUY_KE1.Properties.ReadOnly = false;
                bindLyTangGiam(Convert.ToDecimal(grlTANG_TSCD1.EditValue));
                grlLYDO_TANGGIAM.EditValue = null;
                //grlMD_TK_CHIPHI
                HtDanhmuc htdm = (HtDanhmuc)ComboHelper.GetSelectData(grlTANG_TSCD1);
                if ((htdm != null))
                {
                    txtTenTangGiam.Text = htdm.GiaTri.ToString();
                    txtNGUYEN_GIA1_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!Check_Input())
                {
                    return;
                }

                if (string.IsNullOrEmpty(err.GetError(dteNgay_BD_KH1)) & string.IsNullOrEmpty(err.GetError(dteNGAY_KT_KH1)))
                {
                    frmProgress.Instance().Thread = GetControlToOBject;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Ghi dữ liệu thành công");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    FormGlobals.Message_Warning("Vui lòng kiểm tra lại dữ liệu đã nhập");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnCancel_Click(System.Object sender, System.EventArgs e)
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

        private void frmDieuChinhGiaTriTaiSan_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void dteNgay_BD_KH_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                lst_CT_TSCD = new List<CtTscd>();
                lst_CT_TSCD.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(m_DM_TSCD_ID));
                if (dteNgay_BD_KH1.DateTime == null)
                {
                    err.SetError(dteNgay_BD_KH1, "Bạn chưa nhập ngày khấu hao");
                    err.SetIconAlignment(dteNgay_BD_KH1, ErrorIconAlignment.MiddleRight);
                    e.Cancel = true;
                }
                else if ((dteNgay_BD_KH1.DateTime < lst_CT_TSCD[lst_CT_TSCD.Count - 1].NgayBdKh & m_InputState == FormGlobals.DataInputState.AddMode))
                {
                    err.SetError(dteNgay_BD_KH1, "Ngày khấu hao phải lớn hơn ngày khấu hao của vệt trước :" + lst_CT_TSCD[lst_CT_TSCD.Count - 1].NgayBdKh);
                    err.SetIconAlignment(dteNgay_BD_KH1, ErrorIconAlignment.MiddleRight);
                    e.Cancel = true;
                }
                else
                {
                    err.SetError(dteNgay_BD_KH1, "");
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlLYDO_TANGGIAM_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmLydoTgTscd obj = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLYDO_TANGGIAM);
                if ((obj != null))
                {
                    txtTenLyDo.Text = obj.TenLydoTgTscd;
                }
                else
                {
                    txtTenLyDo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void Tinh()
        {
            if (LS_TSCD != null)
            {
                if (!string.IsNullOrEmpty(txtNGUYEN_GIA1.Text))
                {
                    if (Convert.ToDecimal(grlTANG_TSCD1.EditValue) == 3)
                    {
                        txtGIA_TRI_CL1.EditValue = (LS_TSCD.GiaTriCl - VnsConvert.CDecimal(txtNGUYEN_GIA1.Text));
                        txtHAO_MON_LUY_KE1.EditValue = LS_TSCD.HaoMonLk;
                    }
                    else if (Convert.ToDecimal(grlTANG_TSCD1.EditValue) == 2)
                    {
                        txtGIA_TRI_CL1.EditValue = (LS_TSCD.GiaTriCl + VnsConvert.CDecimal(txtNGUYEN_GIA1.Text));
                        txtHAO_MON_LUY_KE1.EditValue = LS_TSCD.HaoMonLk;
                    }
                }
            }
        }

        private void txtNGUYEN_GIA1_TextChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (dteNgay_BD_KH1.DateTime != null)
                {
                    Tinh();
                }
            }
            catch (Exception ex)
            {
                 FormGlobals.Message_Error(ex);
            }
        }

        private void grvNGUON_VON_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F8:
                        if (grvNGUON_VON.RowCount != 0)
                        {
                            TsCtTscdNvon del = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                            lst_del.Add(del);
                            FormGlobals.Grid_DeleteSelectRows(grvNGUON_VON);
                        }
                        else
                        {
                            FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
                        }
                        break;
                    case Keys.F4:
                        GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, true);
                        break;
                    //dt_nguonvon.Add(New TsCtTscdNvon())
                    //grvNGUON_VON.RefreshData()
                    //Grid_AddRow(grvNGUON_VON)
                    case Keys.Enter:
                        GridAddNewRow((DevExpress.XtraGrid.Views.Grid.GridView)sender, true);
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void dteNgay_BD_KH_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(m_DM_TSCD_ID, dteNgay_BD_KH1.DateTime);

                if (LS_TSCD == null)
                {
                    FormGlobals.Message_Warning("Bạn chưa tính khấu hao cho vệt trước hoặc ngày BDKH nhỏ hơn ngày tính khấu hao nhỏ nhất!");
                    return;
                }

                Tinh();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void dteNGAY_KT_KH_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if ((dteNGAY_KT_KH1.DateTime != null) & (dteNGAY_KT_KH1.DateTime < dteNgay_BD_KH1.DateTime))
                {
                    err.SetError(dteNGAY_KT_KH1, "Ngày kết thúc khấu hao phải >= ngày bắt đầu khấu hao");
                    err.SetIconAlignment(dteNGAY_KT_KH1, ErrorIconAlignment.MiddleRight);
                    e.Cancel = true;
                }
                else
                {
                    err.SetError(dteNGAY_KT_KH1, "");
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        #region "Dành cho grid"

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
            //Trường hợp Grid rỗng
            if (grv.RowCount == 0)
            {
                dt_nguonvon.Add(new TsCtTscdNvon());
                grv.RefreshData();
                //Nếu là Enter key --> Nhảy 1 tab (bỏ qua cell check Xóa)
                if (!byTab)
                {
                    SendKeys.Send("{TAB}");
                }
                //
                return;
            }
            //Trường hợp ở dòng dưới cùng của Grid
            Int16 maxIndex = -1;
            //Xét Grid đang ở dòng dưới cùng (không sử dụng đc grv.IsLastRow)
            //Tình trạng đang có 1 dòng thêm mới --> Focus chắc chắn đang ở dòng dưới cùng của Grid
            //Khi có 1 dòng được thêm mới sẽ chưa có sự tương ứng giữa View & DataSource cho đến khi dữ liệu đc cập nhật
            //Ví dụ: FocusRowHandle là Null, DataRowCount < RowCount...
            //--- Trường hợp: Là dòng dưới cùng thực sự
            if ((GridHelper.CheckAddNewRow(grv)))
            {
                dt_nguonvon.Add(new TsCtTscdNvon());
                grv.RefreshData();
            }

        }


        private void rpeTK_TAISAN_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                rpeTK_TAISAN.C_DATA_SOURCE = dt_tk_khauhao;
                rpeTK_TAISAN.Editors.A_DATA_SOURCE = rpeTK_TAISAN.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeTK_TAISAN_AfterFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                TsCtTscdNvon dr_grv_NGUONVON = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                if (rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpeTK_TAISAN.Tag = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkKhauhao = VnsConvert.CGuid(rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkKhauhao = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[1];
                    grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MaTkKhauhao", dr_grv_NGUONVON.MaTkKhauhao);
                }
                SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeTK_TAISAN_ClearDataFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                TsCtTscdNvon dr_grv_NGUONVON = (TsCtTscdNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                if (rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpeTK_TAISAN.Tag = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkKhauhao = VnsConvert.CGuid(rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkKhauhao = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES[1];
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
                rpeTK_CHIPHI.C_DATA_SOURCE = dt_tk_khauhao;
                rpeTK_CHIPHI.Editors.A_DATA_SOURCE = rpeTK_CHIPHI.C_DATA_SOURCE;
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
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                if (rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[1];
                    grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MaTkChiphi", dr_grv_NGUONVON.MaTkChiphi);
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
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }

                if (rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES[1];
                    //grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MA_TK_CHIPHI", dr_grv_NGUONVON("MA_TK_CHIPHI"))
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion


    }
}