using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Accounting.Service.Interface;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoGiamTaiSan_ChiTiet
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

        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private IDmNgoaiteService _DmNgoaiteService;
        public IDmNgoaiteService DmNgoaiteService
        {
            get { return _DmNgoaiteService; }
            set { _DmNgoaiteService = value; }
        }
        #endregion

        #region Variables

        private Guid m_DM_TSCD_ID;
        private FormGlobals.DataInputState m_InputState;
        private Guid m_CT_TSCD_ID;
        private string m_CT_GIAM_TSCD;
        private DmTscd dm_tscd = new DmTscd();
        private CtTscd ct_tscd = new CtTscd();
        private List<CtD> lst_CTD = new List<CtD>();
        private CtH obj_CTH;
        TsLsKhauhao LS_TSCD = new TsLsKhauhao();
        #endregion
        List<DmTaikhoan> lst_tk = new List<DmTaikhoan>();

        #region Show_form

        private void AddEvents()
        {
            KeyDown += frmKhaiBaoGiamTaiSan_ChiTiet_KeyDown;
            ckeGIAM_TS.CheckedChanged += ckeGIAM_TS_CheckedChanged;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            grlLY_DO_GIAM.EditValueChanged += grlLY_DO_GIAM_EditValueChanged;
            txtNGAY_KT_KH.Validated += txtNGAY_KT_KH_Validated;
            btnDINH_KHOAN.Click += btnDINH_KHOAN_Click;
            grvDINH_KHOAN.CellValueChanged += grvDINH_KHOAN_CellValueChanged;
        }

        public frmKhaiBaoGiamTaiSan_ChiTiet()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        public bool Show_Form(Guid p_DM_TSCD_ID, FormGlobals.DataInputState eState, string p_CT_GIAM_TSCD)
        {
            try
            {
                FormGlobals.Form_SetText(this, "Khai báo giảm trị tài sản", eState);
                FormGlobals.Form_InitDialog(this);
                m_DM_TSCD_ID = p_DM_TSCD_ID;
                m_InputState = eState;
                m_CT_GIAM_TSCD = p_CT_GIAM_TSCD;
                FormGlobals.Control_SetRequire(dteNGAY_CT, true);
                FormGlobals.Control_SetRequire(txtNGAY_KT_KH, true);
                FormGlobals.Control_SetRequire(txtSO_CT, true);
                FormGlobals.Control_SetRequire(ckeGIAM_TS, true);

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

        #region Private function

        private void Init_Data()
        {
            LoadCBO();
            SetObjectToControl();
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    dteNGAY_CT.DateTime = System.DateTime.Now.Date;
                    break;
            }
        }

        //'Lay gia tri tu Control gan cho object
        //'Thuc hien insert, update, delele
        private void GetControlToOBject()
        {
            //Lay gia tri tu DM_TSCD gan vao CT_TSCD va insert và CT_TSCD
            int thu_tu = _CtTscdService.GetObjectByIdDM_TSCD_DC(dm_tscd.Id).Count + 1;

            if (!VnsCheck.IsNullGuid( grlLY_DO_GIAM.EditValue))
            {
                DmLydoTgTscd obj_LDTG = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLY_DO_GIAM);
                ct_tscd.TenLydoTanggiam = obj_LDTG.TenLydoTgTscd;
                ct_tscd.LydoTanggiam = obj_LDTG.Id;
            }

            ct_tscd.NgayBdKh = txtNGAY_KT_KH.DateTime;
            ct_tscd.NgayCt = dteNGAY_CT.DateTime;
            ct_tscd.NgayKtKh = txtNGAY_KT_KH.DateTime;
            ct_tscd.SoCt = txtSO_CT.Text;

            dm_tscd.NgayKtkh = txtNGAY_KT_KH.DateTime;
            dm_tscd.NgayGiam = dteNGAY_CT.DateTime;

            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    if ((ckeGIAM_TS.Checked))
                    {
                        //insert CT_TSCD
                        ct_tscd.TscdId = dm_tscd.Id;
                        ct_tscd.MaTscd = dm_tscd.MaTscd;
                        ct_tscd.KyHieuTscd = dm_tscd.KyHieu;
                        ct_tscd.TenTscd = dm_tscd.TenTscd;

                        ct_tscd.DvtId = dm_tscd.DvtId;
                        ct_tscd.TenDvt = dm_tscd.TenDvt;
                        ct_tscd.MaDvt = dm_tscd.MaDvt;
                        ct_tscd.LoaitaisanId = dm_tscd.LoaitaisanId;
                        ct_tscd.MaLoaitaisan = dm_tscd.MaLoaitaisan;
                        ct_tscd.ThuTu = thu_tu;

                        ct_tscd.TangTscd = 4;
                        ct_tscd.HaoMonLuyKe = 0;

                        dm_tscd.GiamTscd = 1;
                        //update DM_TSCD
                        _DmTscdService.SaveOrUpdate(dm_tscd);
                        //insert CT_DM_TSCD
                        _CtTscdService.Save(ct_tscd);
                        //insert CT_H
                    }
                    break;
                default:
                    _CtTscdService.SaveOrUpdate(ct_tscd);
                    _DmTscdService.SaveOrUpdate(dm_tscd);
                    break;
            }
            CTH_CTD();
        }
        //'insert , update CTH, CTD
        private void CTH_CTD()
        {
            if ((obj_CTH != null))
            {
                obj_CTH.NgayTao = DateTime.Now;
                obj_CTH.NguoiTao = Generals.USER.Id;

                obj_CTH.NgaySua = DateTime.Now;
                obj_CTH.NguoiSua = Generals.USER.Id;

                if (obj_CTH.Id == Null.NullGuid)
                {
                    _CtHService.SaveChungTuKeToan(true, ref obj_CTH, ref lst_CTD);
                }
                else
                {
                    _CtHService.SaveChungTuKeToan(false,ref obj_CTH,ref lst_CTD);
                }

                //'update lai ct_tscd
                ct_tscd.CthId = obj_CTH.Id;
                _CtTscdService.SaveOrUpdate(ct_tscd);
            }
        }

        //'Lay gia tri tu object gan cho control khi update
        private void SetObjectToControl()
        {
            //Lay thong tin tu DM_TSCD gan vao control
            dm_tscd = _DmTscdService.GetById(m_DM_TSCD_ID);
            txtMA_TS.Text = dm_tscd.MaTscd;
            txtTenTaiSan.Text = dm_tscd.TenTscd;
            txtKY_HIEU.Text = dm_tscd.KyHieu;
            txtNGAY_BDKH.EditValue = dm_tscd.NgayBdkh;
            txtNGAY_MUA.EditValue = dm_tscd.NgayMua;
            //txtNGAY_KT_KH.Text = dm_tscd.NGAY_KTKH

            if ((dm_tscd.GiamTscd == 1))
            {
                ckeGIAM_TS.Checked = true;
                ckeGIAM_TS.Enabled = false;
            }
            else
            {
                ckeGIAM_TS.Checked = false;
                ckeGIAM_TS.Enabled = true;
            }

            //lay ly do ung voi trang thai giam
            if ((dm_tscd.GiamTscd == 1))
            {
                ct_tscd = _CtTscdService.GetByTRANG_THAI(m_DM_TSCD_ID, 4);
                if ((ct_tscd != null))
                {
                    grlLY_DO_GIAM.EditValue = ct_tscd.LydoTanggiam;
                    dteNGAY_CT.DateTime = ct_tscd.NgayCt.Value;
                    txtNGAY_KT_KH.DateTime = ct_tscd.NgayKtKh.Value;
                    txtSO_CT.Text = ct_tscd.SoCt;
                }

                //Lay gia tri con lại va hao mon luy ke
                LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(dm_tscd.Id, ct_tscd.NgayKtKh.Value);
                if ((LS_TSCD != null))
                {
                    //If (ct_tscd.NGAY_KT_KH.Month = LS_TSCD.THANG And ct_tscd.NGAY_KT_KH.Year = LS_TSCD.NAM) Then
                    txtGTCL.EditValue = LS_TSCD.GiaTriCl;
                    txtHMLK.EditValue = LS_TSCD.HaoMonLk;
                    //End If
                }
                //lay ctd ung với CT_TSCD
                obj_CTH = _CtHService.GetById(ct_tscd.CthId);
                lst_CTD = new List<CtD>(_CtDService.GetByCtHandNghiepVu(ct_tscd.CthId, 0));

                grcDINH_KHOAN.DataSource = lst_CTD;

            }
        }

        //'Lay ra gia tri con lai va hao mon luy ke 
        private void TS_LS_KHAUHAO()
        {
            if (txtNGAY_KT_KH.EditValue != null)
            {
                LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(dm_tscd.Id, txtNGAY_KT_KH.DateTime);
            }
            else
            {
                return;
            }

            DateTime ngay = txtNGAY_KT_KH.DateTime;

            if (LS_TSCD == null)
            {
                FormGlobals. Message_Warning("Bạn chưa tính khấu hao cho TSCD");
                return;
            }
            if (txtNGAY_KT_KH.EditValue != null & LS_TSCD != null)
            {
                if (ngay.Day < 15)
                {
                    ngay = ngay.AddMonths(-1);
                }

                DateTime ngay_tinh = new DateTime((Int16)LS_TSCD.Nam, (Int16)LS_TSCD.Thang, ngay.Day);

                if ((ngay_tinh.Year == ngay.Year & ngay_tinh.Month == ngay.Month))
                {
                    txtGTCL.EditValue = LS_TSCD.GiaTriCl;
                    txtHMLK.EditValue = LS_TSCD.HaoMonLk;
                }

                if ((ngay_tinh < ngay))
                {
                    if ((LS_TSCD.GiaTriCl == 0))
                    {
                        txtGTCL.Text = "0";
                        txtHMLK.EditValue = LS_TSCD.HaoMonLk;
                    }
                    else
                    {
                        FormGlobals.Message_Warning("Khấu hao được tính đến tháng " + LS_TSCD.Thang.ToString() + " năm " + LS_TSCD.Nam.ToString());
                        txtGTCL.Text = "";
                        txtHMLK.Text = "0";
                    }
                }

                if ((ngay_tinh > ngay))
                {
                    FormGlobals.Message_Warning("Khấu hao được tính đến tháng " + LS_TSCD.Thang.ToString() + " năm " + LS_TSCD.Nam.ToString());
                    txtGTCL.Text = "0";
                    txtHMLK.EditValue = 0;
                }

            }
        }

        private void Save()
        {
            if ((dteNGAY_CT.DateTime == null) || txtNGAY_KT_KH.DateTime == null || String.IsNullOrEmpty(txtSO_CT.Text))
            {
               FormGlobals. Message_Warning("Bạn chưa nhập giá trị cho trường bắt buộc!");
                return;
            }

            System.DateTime ngay_BDKH = Convert.ToDateTime(txtNGAY_BDKH.Text);
            if ((txtNGAY_KT_KH.DateTime < ngay_BDKH))
            {
                FormGlobals.Message_Warning("Ngày kết thúc khấu hao >= ngày bắt đầu khấu hao");
                txtNGAY_KT_KH.Focus();
                return;
            }
            else if (txtNGAY_KT_KH.DateTime > dteNGAY_CT.DateTime)
            {
                FormGlobals.Message_Warning("Ngày kết thúc khấu hao phải <= ngày chứng từ");
                txtNGAY_KT_KH.Focus();
                return;
            }

            if ((ckeGIAM_TS.Checked == true))
            {
                frmProgress.Instance().Thread = GetControlToOBject;
                frmProgress.Instance().Show_Progress();
                frmProgress.Instance().SetFinishText("Ghi dữ liệu thành công");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                FormGlobals.Message_Warning("Bạn chưa chọn khai báo giảm tài sản");
            }
        }

        #endregion

        #region Events

        private void ckeGIAM_TS_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if ((ckeGIAM_TS.Checked))
                {
                    grlLY_DO_GIAM.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        //Bind grlLY_DO_TG
        private void LoadCBO()
        {
            List<DmLydoTgTscd> lst_LDG_TSCD = new List<DmLydoTgTscd>();
            lst_LDG_TSCD.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(4, Generals.DON_VI.Id));
            ArrayList objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenLydoTgTscd", "Tên lý do giảm tài sản"));
            FormGlobals.GridLookupEdit_BindData(grlLY_DO_GIAM, lst_LDG_TSCD, "KyHieu", "Id", FormGlobals.COMBO_ITEM_REQUIRE, "TenLydoTgTscd", txttenlydo, objColumnDefine);

            lst_tk = new List<DmTaikhoan>();
            lst_tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
            //lst_tk = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

            List<DmTaikhoan> dt_TK_CO = new List<DmTaikhoan>();
            dt_TK_CO.AddRange(lst_tk);
            cboMA_TK_CO.DataSource = dt_TK_CO;
            cboMA_TK_CO.DisplayMember = "MaTaikhoan";
            cboMA_TK_CO.ValueMember = "Id";
            cboMA_TK_CO.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            cboMA_TK_CO.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));

            List<DmTaikhoan> dt_TK_NO = new List<DmTaikhoan>();
            dt_TK_NO.AddRange(lst_tk);
            cboMA_TK_NO.DataSource = dt_TK_NO;
            cboMA_TK_NO.DisplayMember = "MaTaikhoan";
            cboMA_TK_NO.ValueMember = "Id";
            cboMA_TK_NO.Columns.Add(new LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"));
            cboMA_TK_NO.Columns.Add(new LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"));
        }

        private DmTaikhoan Tai_Khoan(Guid TAI_KHOAN_ID)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan obj in lst_tk)
            {
                if (obj.Id == TAI_KHOAN_ID)
                {
                    obj_tk = obj;
                }
            }
            return obj_tk;
        }

        private DmTaikhoan Tai_Khoan(string Ma_Taikhoan)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan obj in lst_tk)
            {
                if (obj.MaTaikhoan == Ma_Taikhoan)
                {
                    obj_tk = obj;
                }
            }
            return obj_tk;
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmKhaiBaoGiamTaiSan_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void btnClear_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                ckeGIAM_TS.Checked = false;
                grlLY_DO_GIAM.EditValue = null;
                txttenlydo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlLY_DO_GIAM_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmLydoTgTscd obj_LDTG = (DmLydoTgTscd)ComboHelper.GetSelectData(grlLY_DO_GIAM);
                if ((obj_LDTG != null))
                {
                    txttenlydo.Text = obj_LDTG.TenLydoTgTscd;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void txtNGAY_KT_KH_Validated(System.Object sender, System.EventArgs e)
        {
            try
            {
                TS_LS_KHAUHAO();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDINH_KHOAN_Click(System.Object sender, System.EventArgs e)
        {
            //CT_H
            try
            {
                frmProgress.Instance().Thread = DINH_KHOAN;
                frmProgress.Instance().Show_Progress();
                frmProgress.Instance().SetFinishText("Hoàn thành");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void DINH_KHOAN()
        {
            if (ct_tscd.CthId == Null.NullGuid)
            {
                obj_CTH = new CtH();
                obj_CTH.DonviId = Generals.DON_VI.Id;
                obj_CTH.MaDonvi = Generals.DON_VI.MaDonvi;
                obj_CTH.NgayCt = dteNGAY_CT.DateTime;
                obj_CTH.NgayGhi = dteNGAY_CT.DateTime;

                HtLoaichungtu obj_HT_LOAICT = _HtLoaichungtuService.GetByMA_LOAI_CT(m_CT_GIAM_TSCD, Generals.DON_VI.Id);
                obj_CTH.IdLoaiCt = obj_HT_LOAICT.Id;
                obj_CTH.KyHieuLoaiCt = obj_HT_LOAICT.KyHieu;
                obj_CTH.MaLoaiCt = obj_HT_LOAICT.MaLoaiCt;
                obj_CTH.SoTienNte = 0;
                obj_CTH.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri);
                obj_CTH.MaNte = _DmNgoaiteService.GetById(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)).MaNte;
                lst_CTD.Clear();
                //CT_D(CT_D gia tri con lai)
                CtD obj_CTD_GTCL = new CtD();
                obj_CTD_GTCL.PhanHe = 4;
                //obj_CTD.CTH_ID = obj_CTH.CTH_ID id lấy sau khi nhấn lưu
                DmTaikhoan obj_tk_No_CL = _DmTaikhoanService.GetObjectByMaTK("411", Generals.DON_VI.Id);
                obj_CTD_GTCL.TkNoId = obj_tk_No_CL.Id;
                obj_CTD_GTCL.TenTkNo = obj_tk_No_CL.TenTaikhoan;
                obj_CTD_GTCL.MaTkNo = obj_tk_No_CL.MaTaikhoan;

                DmTaikhoan obj_tk_CO_CL = Tai_Khoan(dm_tscd.MdTkTs);

                if ((obj_tk_CO_CL != null))
                {
                    obj_CTD_GTCL.MaTkCo = obj_tk_CO_CL.MaTaikhoan;
                    obj_CTD_GTCL.TkCoId = obj_tk_CO_CL.Id;
                    obj_CTD_GTCL.TenTkCo = obj_tk_CO_CL.TenTaikhoan;
                    if (!string.IsNullOrEmpty(txtGTCL.Text))
                    {
                        obj_CTD_GTCL.SoTien = (Decimal)txtGTCL.EditValue;
                    }
                    lst_CTD.Add(obj_CTD_GTCL);
                }
                //CT_D(CT_D Hao mon luy ke)
                CtD obj_CTD_HMLK = new CtD();
                obj_CTD_HMLK.PhanHe = 4;
                DmTaikhoan obj_tk_no_LK = Tai_Khoan(dm_tscd.MdTkKhauhao);
                if (obj_tk_no_LK != null)
                {
                    obj_CTD_HMLK.MaTkNo = obj_tk_no_LK.MaTaikhoan;
                    obj_CTD_HMLK.TenTkNo = obj_tk_no_LK.TenTaikhoan;
                    obj_CTD_HMLK.TkNoId = obj_tk_no_LK.Id;
                }

                if ((obj_tk_CO_CL != null))
                {
                    obj_CTD_HMLK.TkCoId = obj_tk_CO_CL.Id;
                    obj_CTD_HMLK.MaTkCo = obj_tk_CO_CL.MaTaikhoan;
                    obj_CTD_HMLK.TenTkCo = obj_tk_CO_CL.TenTaikhoan;
                    if (!string.IsNullOrEmpty(txtHMLK.Text))
                    {
                        obj_CTD_HMLK.SoTien = (Decimal)txtHMLK.EditValue;
                        lst_CTD.Add(obj_CTD_HMLK);
                    }
                }
            }
            else
            {
                obj_CTH = _CtHService.GetById(ct_tscd.CthId);
                lst_CTD = new List<CtD>(_CtDService.GetByCtHandNghiepVu(ct_tscd.CthId, 0));
            }

            decimal so_tien = 0;

            foreach (CtD obj in lst_CTD)
            {
                    so_tien = so_tien + obj.SoTien;
            }

            obj_CTH.SoTien = so_tien;
            grcDINH_KHOAN.DataSource = lst_CTD;
            grvDINH_KHOAN.RefreshData();
        }

        private void grvDINH_KHOAN_CellValueChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                CtD obj_grv_DINH_KHOAN = (CtD)grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle);
                switch (e.Column.Name)
                {
                    case "MA_TK_NO":
                        DmTaikhoan cboTK_NO = (DmTaikhoan)cboMA_TK_NO.GetDataSourceRowByKeyValue(obj_grv_DINH_KHOAN.TkNoId);
                        obj_grv_DINH_KHOAN.MaTkNo = cboTK_NO.MaTaikhoan;
                        obj_grv_DINH_KHOAN.TenTkNo = cboTK_NO.TenTaikhoan;
                        break;
                    case "MA_TK_CO":
                        DmTaikhoan cboTK_CO = (DmTaikhoan)cboMA_TK_CO.GetDataSourceRowByKeyValue(obj_grv_DINH_KHOAN.TkCoId);
                        obj_grv_DINH_KHOAN.MaTkCo = cboTK_CO.MaTaikhoan;
                        obj_grv_DINH_KHOAN.TenTkCo = cboTK_CO.TenTaikhoan;
                        break;
                }
                grvDINH_KHOAN.RefreshData();
            }
            catch (Exception ex)
            {
               FormGlobals. Message_Error(ex);
            }
        }
        #endregion

    }
}