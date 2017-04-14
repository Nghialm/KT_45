using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmKhaiBaoCCDC_ChiTiet : DevExpress.XtraEditors.XtraForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhaiBaoCCDC_ChiTiet));
            this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.C_filter_TKCP = new Vns.Erp.Core.CustomFilter();
            this.C_filter_TKPB = new Vns.Erp.Core.CustomFilter();
            this.C_filter_TKCC = new Vns.Erp.Core.CustomFilter();
            this.dteNgayBDSD = new DevExpress.XtraEditors.DateEdit();
            this.grlNhom3 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlNhom2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlBoPhanSd = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grlNhom1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlDVT = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grlKieuPb = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtGTCL = new DevExpress.XtraEditors.TextEdit();
            this.txtNguyenGia = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoKyPb = new DevExpress.XtraEditors.TextEdit();
            this.txtTenCC = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaCC = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.XtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtNamSx = new DevExpress.XtraEditors.TextEdit();
            this.txtNuocSx = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.txtTskt = new DevExpress.XtraEditors.TextEdit();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.XtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.grcNGUON_VON = new DevExpress.XtraGrid.GridControl();
            this.grvNGUON_VON = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DM_NGUON_TSCD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNguonVon = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TenNguon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TkTaisan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTkPhanbo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTkChiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpTkCP = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.HeSoPbKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NguyenGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HaoMonLuyKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTriConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rpTkTS = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.rpTkKH = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.XtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this._grcPhuTung = new DevExpress.XtraGrid.GridControl();
            this._grvPhuTung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.GridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).BeginInit();
            this.XtraTabControl1.SuspendLayout();
            this.XtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBDSD.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBDSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlBoPhanSd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlKieuPb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGTCL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKyPb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCC.Properties)).BeginInit();
            this.XtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTskt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl2)).BeginInit();
            this.XtraTabControl2.SuspendLayout();
            this.XtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkKH)).BeginInit();
            this.XtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grcPhuTung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._grvPhuTung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // XtraTabControl1
            // 
            this.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.XtraTabControl1.Location = new System.Drawing.Point(4, 4);
            this.XtraTabControl1.Name = "XtraTabControl1";
            this.XtraTabControl1.SelectedTabPage = this.XtraTabPage1;
            this.XtraTabControl1.Size = new System.Drawing.Size(880, 269);
            this.XtraTabControl1.TabIndex = 0;
            this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraTabPage1,
            this.XtraTabPage2});
            // 
            // XtraTabPage1
            // 
            this.XtraTabPage1.Controls.Add(this.C_filter_TKCP);
            this.XtraTabPage1.Controls.Add(this.C_filter_TKPB);
            this.XtraTabPage1.Controls.Add(this.C_filter_TKCC);
            this.XtraTabPage1.Controls.Add(this.dteNgayBDSD);
            this.XtraTabPage1.Controls.Add(this.grlNhom3);
            this.XtraTabPage1.Controls.Add(this.grlNhom2);
            this.XtraTabPage1.Controls.Add(this.grlBoPhanSd);
            this.XtraTabPage1.Controls.Add(this.grlNhom1);
            this.XtraTabPage1.Controls.Add(this.grlDVT);
            this.XtraTabPage1.Controls.Add(this.grlKieuPb);
            this.XtraTabPage1.Controls.Add(this.LabelControl18);
            this.XtraTabPage1.Controls.Add(this.txtSoLuong);
            this.XtraTabPage1.Controls.Add(this.LabelControl17);
            this.XtraTabPage1.Controls.Add(this.LabelControl7);
            this.XtraTabPage1.Controls.Add(this.LabelControl21);
            this.XtraTabPage1.Controls.Add(this.LabelControl16);
            this.XtraTabPage1.Controls.Add(this.LabelControl15);
            this.XtraTabPage1.Controls.Add(this.LabelControl20);
            this.XtraTabPage1.Controls.Add(this.txtGTCL);
            this.XtraTabPage1.Controls.Add(this.txtNguyenGia);
            this.XtraTabPage1.Controls.Add(this.LabelControl19);
            this.XtraTabPage1.Controls.Add(this.txtSoKyPb);
            this.XtraTabPage1.Controls.Add(this.txtTenCC);
            this.XtraTabPage1.Controls.Add(this.LabelControl3);
            this.XtraTabPage1.Controls.Add(this.LabelControl4);
            this.XtraTabPage1.Controls.Add(this.LabelControl12);
            this.XtraTabPage1.Controls.Add(this.LabelControl10);
            this.XtraTabPage1.Controls.Add(this.LabelControl9);
            this.XtraTabPage1.Controls.Add(this.LabelControl8);
            this.XtraTabPage1.Controls.Add(this.LabelControl2);
            this.XtraTabPage1.Controls.Add(this.txtMaCC);
            this.XtraTabPage1.Controls.Add(this.LabelControl1);
            this.XtraTabPage1.Name = "XtraTabPage1";
            this.XtraTabPage1.Size = new System.Drawing.Size(873, 240);
            this.XtraTabPage1.Text = "&1.Thông tin &chính";
            // 
            // C_filter_TKCP
            // 
            this.C_filter_TKCP.AllowNull = true;
            this.C_filter_TKCP.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.C_filter_TKCP.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.C_filter_TKCP.C_DATA_SOURCE = null;
            this.C_filter_TKCP.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.C_filter_TKCP.C_FORM_TITLE = "Chọn tài khoản";
            this.C_filter_TKCP.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.C_filter_TKCP.C_IS_CHECK_OTHER = "=";
            this.C_filter_TKCP.C_IS_CHECK_STRING = "=";
            this.C_filter_TKCP.C_IS_FILTER_STRING = "";
            this.C_filter_TKCP.C_IS_QUICKADD = false;
            this.C_filter_TKCP.C_IS_SORT_ORDER_STRING = "";
            this.C_filter_TKCP.C_KEY_NAME = "MaTaikhoan";
            this.C_filter_TKCP.EditValue = "";
            this.C_filter_TKCP.EditValues = "";
            this.C_filter_TKCP.ENABLES = true;
            this.C_filter_TKCP.IsNotTextChanged = true;
            this.C_filter_TKCP.ListEditValue = ((System.Collections.Generic.List<string>)(resources.GetObject("C_filter_TKCP.ListEditValue")));
            this.C_filter_TKCP.Location = new System.Drawing.Point(109, 206);
            this.C_filter_TKCP.MessageWarning = "Giá trị không hợp lệ";
            this.C_filter_TKCP.Name = "C_filter_TKCP";
            this.C_filter_TKCP.NEXT_TAB = 0;
            this.C_filter_TKCP.Size = new System.Drawing.Size(150, 20);
            this.C_filter_TKCP.TabIndex = 8;
            // 
            // C_filter_TKPB
            // 
            this.C_filter_TKPB.AllowNull = true;
            this.C_filter_TKPB.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.C_filter_TKPB.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.C_filter_TKPB.C_DATA_SOURCE = null;
            this.C_filter_TKPB.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.C_filter_TKPB.C_FORM_TITLE = "Chọn tài khoản";
            this.C_filter_TKPB.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.C_filter_TKPB.C_IS_CHECK_OTHER = "=";
            this.C_filter_TKPB.C_IS_CHECK_STRING = "=";
            this.C_filter_TKPB.C_IS_FILTER_STRING = "";
            this.C_filter_TKPB.C_IS_QUICKADD = false;
            this.C_filter_TKPB.C_IS_SORT_ORDER_STRING = "";
            this.C_filter_TKPB.C_KEY_NAME = "MaTaikhoan";
            this.C_filter_TKPB.EditValue = "";
            this.C_filter_TKPB.EditValues = "";
            this.C_filter_TKPB.ENABLES = true;
            this.C_filter_TKPB.IsNotTextChanged = true;
            this.C_filter_TKPB.ListEditValue = ((System.Collections.Generic.List<string>)(resources.GetObject("C_filter_TKPB.ListEditValue")));
            this.C_filter_TKPB.Location = new System.Drawing.Point(109, 180);
            this.C_filter_TKPB.MessageWarning = "Giá trị không hợp lệ";
            this.C_filter_TKPB.Name = "C_filter_TKPB";
            this.C_filter_TKPB.NEXT_TAB = 0;
            this.C_filter_TKPB.Size = new System.Drawing.Size(150, 20);
            this.C_filter_TKPB.TabIndex = 7;
            // 
            // C_filter_TKCC
            // 
            this.C_filter_TKCC.AllowNull = true;
            this.C_filter_TKCC.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.C_filter_TKCC.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.C_filter_TKCC.C_DATA_SOURCE = null;
            this.C_filter_TKCC.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.C_filter_TKCC.C_FORM_TITLE = "Chọn tài khoản";
            this.C_filter_TKCC.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.C_filter_TKCC.C_IS_CHECK_OTHER = "=";
            this.C_filter_TKCC.C_IS_CHECK_STRING = "=";
            this.C_filter_TKCC.C_IS_FILTER_STRING = "";
            this.C_filter_TKCC.C_IS_QUICKADD = false;
            this.C_filter_TKCC.C_IS_SORT_ORDER_STRING = "";
            this.C_filter_TKCC.C_KEY_NAME = "MaTaikhoan";
            this.C_filter_TKCC.EditValue = "";
            this.C_filter_TKCC.EditValues = "";
            this.C_filter_TKCC.ENABLES = true;
            this.C_filter_TKCC.IsNotTextChanged = true;
            this.C_filter_TKCC.ListEditValue = ((System.Collections.Generic.List<string>)(resources.GetObject("C_filter_TKCC.ListEditValue")));
            this.C_filter_TKCC.Location = new System.Drawing.Point(109, 154);
            this.C_filter_TKCC.MessageWarning = "Giá trị không hợp lệ";
            this.C_filter_TKCC.Name = "C_filter_TKCC";
            this.C_filter_TKCC.NEXT_TAB = 0;
            this.C_filter_TKCC.Size = new System.Drawing.Size(150, 20);
            this.C_filter_TKCC.TabIndex = 6;
            // 
            // dteNgayBDSD
            // 
            this.dteNgayBDSD.EditValue = null;
            this.dteNgayBDSD.EnterMoveNextControl = true;
            this.dteNgayBDSD.Location = new System.Drawing.Point(718, 72);
            this.dteNgayBDSD.Name = "dteNgayBDSD";
            this.dteNgayBDSD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayBDSD.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgayBDSD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNgayBDSD.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNgayBDSD.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgayBDSD.Size = new System.Drawing.Size(150, 20);
            this.dteNgayBDSD.TabIndex = 12;
            // 
            // grlNhom3
            // 
            this.grlNhom3.EnterMoveNextControl = true;
            this.grlNhom3.Location = new System.Drawing.Point(718, 203);
            this.grlNhom3.Name = "grlNhom3";
            this.grlNhom3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNhom3.Properties.NullText = "";
            this.grlNhom3.Properties.View = this.GridView9;
            this.grlNhom3.Size = new System.Drawing.Size(150, 20);
            this.grlNhom3.TabIndex = 19;
            // 
            // GridView9
            // 
            this.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView9.Name = "GridView9";
            this.GridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView9.OptionsView.ShowGroupPanel = false;
            // 
            // grlNhom2
            // 
            this.grlNhom2.EnterMoveNextControl = true;
            this.grlNhom2.Location = new System.Drawing.Point(718, 177);
            this.grlNhom2.Name = "grlNhom2";
            this.grlNhom2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNhom2.Properties.NullText = "";
            this.grlNhom2.Properties.View = this.GridView8;
            this.grlNhom2.Size = new System.Drawing.Size(150, 20);
            this.grlNhom2.TabIndex = 18;
            // 
            // GridView8
            // 
            this.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView8.Name = "GridView8";
            this.GridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView8.OptionsView.ShowGroupPanel = false;
            // 
            // grlBoPhanSd
            // 
            this.grlBoPhanSd.EnterMoveNextControl = true;
            this.grlBoPhanSd.Location = new System.Drawing.Point(109, 128);
            this.grlBoPhanSd.Name = "grlBoPhanSd";
            this.grlBoPhanSd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlBoPhanSd.Properties.NullText = "";
            this.grlBoPhanSd.Properties.View = this.GridView6;
            this.grlBoPhanSd.Size = new System.Drawing.Size(150, 20);
            this.grlBoPhanSd.TabIndex = 5;
            // 
            // GridView6
            // 
            this.GridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn4,
            this.GridColumn5,
            this.GridColumn6});
            this.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView6.Name = "GridView6";
            this.GridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView6.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn4
            // 
            this.GridColumn4.Caption = "Mã phòng ban";
            this.GridColumn4.FieldName = "MaPhongban";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 0;
            // 
            // GridColumn5
            // 
            this.GridColumn5.Caption = "Tên phòng ban";
            this.GridColumn5.FieldName = "TenPhongban";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 1;
            // 
            // GridColumn6
            // 
            this.GridColumn6.Caption = "Id";
            this.GridColumn6.FieldName = "Id";
            this.GridColumn6.Name = "GridColumn6";
            // 
            // grlNhom1
            // 
            this.grlNhom1.EnterMoveNextControl = true;
            this.grlNhom1.Location = new System.Drawing.Point(718, 151);
            this.grlNhom1.Name = "grlNhom1";
            this.grlNhom1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNhom1.Properties.NullText = "";
            this.grlNhom1.Properties.View = this.GridView7;
            this.grlNhom1.Size = new System.Drawing.Size(150, 20);
            this.grlNhom1.TabIndex = 17;
            // 
            // GridView7
            // 
            this.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView7.Name = "GridView7";
            this.GridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView7.OptionsView.ShowGroupPanel = false;
            // 
            // grlDVT
            // 
            this.grlDVT.EnterMoveNextControl = true;
            this.grlDVT.Location = new System.Drawing.Point(109, 99);
            this.grlDVT.Name = "grlDVT";
            this.grlDVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlDVT.Properties.NullText = "";
            this.grlDVT.Properties.View = this.GridView3;
            this.grlDVT.Size = new System.Drawing.Size(150, 20);
            this.grlDVT.TabIndex = 3;
            // 
            // GridView3
            // 
            this.GridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn16});
            this.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView3.Name = "GridView3";
            this.GridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView3.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn16
            // 
            this.GridColumn16.Caption = "Tên ĐVT";
            this.GridColumn16.FieldName = "TenDvt";
            this.GridColumn16.Name = "GridColumn16";
            this.GridColumn16.Visible = true;
            this.GridColumn16.VisibleIndex = 0;
            // 
            // grlKieuPb
            // 
            this.grlKieuPb.EnterMoveNextControl = true;
            this.grlKieuPb.Location = new System.Drawing.Point(718, 46);
            this.grlKieuPb.Name = "grlKieuPb";
            this.grlKieuPb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlKieuPb.Properties.NullText = "";
            this.grlKieuPb.Properties.View = this.GridView2;
            this.grlKieuPb.Size = new System.Drawing.Size(150, 20);
            this.grlKieuPb.TabIndex = 10;
            // 
            // GridView2
            // 
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn7,
            this.GridColumn8});
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn7
            // 
            this.GridColumn7.Caption = "ID";
            this.GridColumn7.FieldName = "Id";
            this.GridColumn7.Name = "GridColumn7";
            // 
            // GridColumn8
            // 
            this.GridColumn8.Caption = "Tên loại pb";
            this.GridColumn8.FieldName = "Ten";
            this.GridColumn8.Name = "GridColumn8";
            this.GridColumn8.Visible = true;
            this.GridColumn8.VisibleIndex = 0;
            // 
            // LabelControl18
            // 
            this.LabelControl18.Location = new System.Drawing.Point(10, 209);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(45, 13);
            this.LabelControl18.TabIndex = 23;
            this.LabelControl18.Text = "TK chi phí";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EnterMoveNextControl = true;
            this.txtSoLuong.Location = new System.Drawing.Point(109, 73);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSoLuong.Properties.Mask.EditMask = "n0";
            this.txtSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoLuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoLuong.Size = new System.Drawing.Size(150, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // LabelControl17
            // 
            this.LabelControl17.Location = new System.Drawing.Point(10, 183);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(54, 13);
            this.LabelControl17.TabIndex = 25;
            this.LabelControl17.Text = "TK phân bổ";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(621, 75);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(55, 13);
            this.LabelControl7.TabIndex = 11;
            this.LabelControl7.Text = "Ngày BĐSD";
            // 
            // LabelControl21
            // 
            this.LabelControl21.Location = new System.Drawing.Point(621, 206);
            this.LabelControl21.Name = "LabelControl21";
            this.LabelControl21.Size = new System.Drawing.Size(62, 13);
            this.LabelControl21.TabIndex = 10;
            this.LabelControl21.Text = "Phân nhóm 3";
            // 
            // LabelControl16
            // 
            this.LabelControl16.Location = new System.Drawing.Point(10, 157);
            this.LabelControl16.Name = "LabelControl16";
            this.LabelControl16.Size = new System.Drawing.Size(52, 13);
            this.LabelControl16.TabIndex = 24;
            this.LabelControl16.Text = "TK công cụ";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Location = new System.Drawing.Point(10, 131);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(81, 13);
            this.LabelControl15.TabIndex = 12;
            this.LabelControl15.Text = "Bộ phận sử dụng";
            // 
            // LabelControl20
            // 
            this.LabelControl20.Location = new System.Drawing.Point(621, 180);
            this.LabelControl20.Name = "LabelControl20";
            this.LabelControl20.Size = new System.Drawing.Size(62, 13);
            this.LabelControl20.TabIndex = 9;
            this.LabelControl20.Text = "Phân nhóm 2";
            // 
            // txtGTCL
            // 
            this.txtGTCL.EnterMoveNextControl = true;
            this.txtGTCL.Location = new System.Drawing.Point(718, 125);
            this.txtGTCL.Name = "txtGTCL";
            this.txtGTCL.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGTCL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGTCL.Properties.Mask.EditMask = "n0";
            this.txtGTCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGTCL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGTCL.Size = new System.Drawing.Size(150, 20);
            this.txtGTCL.TabIndex = 16;
            // 
            // txtNguyenGia
            // 
            this.txtNguyenGia.EnterMoveNextControl = true;
            this.txtNguyenGia.Location = new System.Drawing.Point(718, 99);
            this.txtNguyenGia.Name = "txtNguyenGia";
            this.txtNguyenGia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNguyenGia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNguyenGia.Properties.Mask.EditMask = "n0";
            this.txtNguyenGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNguyenGia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNguyenGia.Size = new System.Drawing.Size(150, 20);
            this.txtNguyenGia.TabIndex = 15;
            // 
            // LabelControl19
            // 
            this.LabelControl19.Location = new System.Drawing.Point(621, 154);
            this.LabelControl19.Name = "LabelControl19";
            this.LabelControl19.Size = new System.Drawing.Size(62, 13);
            this.LabelControl19.TabIndex = 5;
            this.LabelControl19.Text = "Phân nhóm 1";
            // 
            // txtSoKyPb
            // 
            this.txtSoKyPb.EnterMoveNextControl = true;
            this.txtSoKyPb.Location = new System.Drawing.Point(718, 20);
            this.txtSoKyPb.Name = "txtSoKyPb";
            this.txtSoKyPb.Properties.Mask.EditMask = "n0";
            this.txtSoKyPb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoKyPb.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoKyPb.Size = new System.Drawing.Size(150, 20);
            this.txtSoKyPb.TabIndex = 9;
            // 
            // txtTenCC
            // 
            this.txtTenCC.EnterMoveNextControl = true;
            this.txtTenCC.Location = new System.Drawing.Point(109, 46);
            this.txtTenCC.Name = "txtTenCC";
            this.txtTenCC.Size = new System.Drawing.Size(425, 20);
            this.txtTenCC.TabIndex = 1;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(10, 102);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(20, 13);
            this.LabelControl3.TabIndex = 19;
            this.LabelControl3.Text = "ĐVT";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(10, 76);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(42, 13);
            this.LabelControl4.TabIndex = 22;
            this.LabelControl4.Text = "Số lượng";
            // 
            // LabelControl12
            // 
            this.LabelControl12.Location = new System.Drawing.Point(621, 128);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new System.Drawing.Size(61, 13);
            this.LabelControl12.TabIndex = 18;
            this.LabelControl12.Text = "Giá trị còn lại";
            // 
            // LabelControl10
            // 
            this.LabelControl10.Location = new System.Drawing.Point(621, 102);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(54, 13);
            this.LabelControl10.TabIndex = 18;
            this.LabelControl10.Text = "Nguyên giá";
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(619, 49);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(62, 13);
            this.LabelControl9.TabIndex = 15;
            this.LabelControl9.Text = "Kiểu phân bổ";
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(619, 23);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(68, 13);
            this.LabelControl8.TabIndex = 14;
            this.LabelControl8.Text = "Số kỳ phân bổ";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(10, 49);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(58, 13);
            this.LabelControl2.TabIndex = 16;
            this.LabelControl2.Text = "Tên công cụ";
            // 
            // txtMaCC
            // 
            this.txtMaCC.EnterMoveNextControl = true;
            this.txtMaCC.Location = new System.Drawing.Point(109, 20);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.Size = new System.Drawing.Size(150, 20);
            this.txtMaCC.TabIndex = 0;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(10, 23);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(54, 13);
            this.LabelControl1.TabIndex = 13;
            this.LabelControl1.Text = "Mã công cụ";
            // 
            // XtraTabPage2
            // 
            this.XtraTabPage2.Controls.Add(this.txtNamSx);
            this.XtraTabPage2.Controls.Add(this.txtNuocSx);
            this.XtraTabPage2.Controls.Add(this.LabelControl34);
            this.XtraTabPage2.Controls.Add(this.LabelControl35);
            this.XtraTabPage2.Controls.Add(this.LabelControl40);
            this.XtraTabPage2.Controls.Add(this.txtTskt);
            this.XtraTabPage2.Name = "XtraTabPage2";
            this.XtraTabPage2.Size = new System.Drawing.Size(873, 240);
            this.XtraTabPage2.Text = "&2.Thông tin bổ xung";
            // 
            // txtNamSx
            // 
            this.txtNamSx.EnterMoveNextControl = true;
            this.txtNamSx.Location = new System.Drawing.Point(110, 69);
            this.txtNamSx.Name = "txtNamSx";
            this.txtNamSx.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNamSx.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNamSx.Properties.Mask.EditMask = "[0-9]{4}";
            this.txtNamSx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNamSx.Properties.Mask.ShowPlaceHolders = false;
            this.txtNamSx.Size = new System.Drawing.Size(150, 20);
            this.txtNamSx.TabIndex = 4;
            // 
            // txtNuocSx
            // 
            this.txtNuocSx.EnterMoveNextControl = true;
            this.txtNuocSx.Location = new System.Drawing.Point(110, 43);
            this.txtNuocSx.Name = "txtNuocSx";
            this.txtNuocSx.Size = new System.Drawing.Size(150, 20);
            this.txtNuocSx.TabIndex = 3;
            // 
            // LabelControl34
            // 
            this.LabelControl34.Location = new System.Drawing.Point(13, 72);
            this.LabelControl34.Name = "LabelControl34";
            this.LabelControl34.Size = new System.Drawing.Size(66, 13);
            this.LabelControl34.TabIndex = 19;
            this.LabelControl34.Text = "Năm sản xuất";
            // 
            // LabelControl35
            // 
            this.LabelControl35.Location = new System.Drawing.Point(13, 46);
            this.LabelControl35.Name = "LabelControl35";
            this.LabelControl35.Size = new System.Drawing.Size(70, 13);
            this.LabelControl35.TabIndex = 22;
            this.LabelControl35.Text = "Nước sản xuất";
            // 
            // LabelControl40
            // 
            this.LabelControl40.Location = new System.Drawing.Point(13, 20);
            this.LabelControl40.Name = "LabelControl40";
            this.LabelControl40.Size = new System.Drawing.Size(87, 13);
            this.LabelControl40.TabIndex = 17;
            this.LabelControl40.Text = "Thông số kỹ thuật";
            // 
            // txtTskt
            // 
            this.txtTskt.EnterMoveNextControl = true;
            this.txtTskt.Location = new System.Drawing.Point(110, 17);
            this.txtTskt.Name = "txtTskt";
            this.txtTskt.Size = new System.Drawing.Size(150, 20);
            this.txtTskt.TabIndex = 2;
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(4, 273);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(880, 4);
            this.PanelControl1.TabIndex = 1;
            // 
            // XtraTabControl2
            // 
            this.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XtraTabControl2.Location = new System.Drawing.Point(4, 277);
            this.XtraTabControl2.Name = "XtraTabControl2";
            this.XtraTabControl2.SelectedTabPage = this.XtraTabPage3;
            this.XtraTabControl2.Size = new System.Drawing.Size(880, 297);
            this.XtraTabControl2.TabIndex = 2;
            this.XtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraTabPage3,
            this.XtraTabPage4});
            // 
            // XtraTabPage3
            // 
            this.XtraTabPage3.Controls.Add(this.grcNGUON_VON);
            this.XtraTabPage3.Name = "XtraTabPage3";
            this.XtraTabPage3.Size = new System.Drawing.Size(873, 268);
            this.XtraTabPage3.Text = "&3.Chi tiết nguồn vốn";
            // 
            // grcNGUON_VON
            // 
            this.grcNGUON_VON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNGUON_VON.Location = new System.Drawing.Point(0, 0);
            this.grcNGUON_VON.MainView = this.grvNGUON_VON;
            this.grcNGUON_VON.Name = "grcNGUON_VON";
            this.grcNGUON_VON.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemTextEdit8,
            this.RepositoryItemTextEdit9,
            this.cboNguonVon,
            this.rpTkTS,
            this.rpTkKH,
            this.rpTkCP});
            this.grcNGUON_VON.Size = new System.Drawing.Size(873, 268);
            this.grcNGUON_VON.TabIndex = 3;
            this.grcNGUON_VON.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNGUON_VON});
            // 
            // grvNGUON_VON
            // 
            this.grvNGUON_VON.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DM_NGUON_TSCD_ID,
            this.TenNguon,
            this.GridColumn2,
            this.GridColumn1,
            this.TkTaisan,
            this.MaTkPhanbo,
            this.MaTkChiphi,
            this.HeSoPbKh,
            this.NguyenGia,
            this.HaoMonLuyKe,
            this.GiaTriConLai,
            this.GridColumn3,
            this.DienGiai});
            this.grvNGUON_VON.GridControl = this.grcNGUON_VON;
            this.grvNGUON_VON.Name = "grvNGUON_VON";
            this.grvNGUON_VON.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvNGUON_VON.OptionsView.ColumnAutoWidth = false;
            this.grvNGUON_VON.OptionsView.ShowGroupPanel = false;
            // 
            // DM_NGUON_TSCD_ID
            // 
            this.DM_NGUON_TSCD_ID.Caption = "Nguồn";
            this.DM_NGUON_TSCD_ID.ColumnEdit = this.cboNguonVon;
            this.DM_NGUON_TSCD_ID.FieldName = "DmNguonTscdId";
            this.DM_NGUON_TSCD_ID.Name = "DM_NGUON_TSCD_ID";
            this.DM_NGUON_TSCD_ID.Visible = true;
            this.DM_NGUON_TSCD_ID.VisibleIndex = 0;
            this.DM_NGUON_TSCD_ID.Width = 173;
            // 
            // cboNguonVon
            // 
            this.cboNguonVon.AutoHeight = false;
            this.cboNguonVon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguonVon.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Mã nguồn vốn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDmNguonTscd", "Tên nguồn vốn")});
            this.cboNguonVon.DisplayMember = "TenDmNguonTscd";
            this.cboNguonVon.Name = "cboNguonVon";
            this.cboNguonVon.NullText = "";
            this.cboNguonVon.ValueMember = "Id";
            // 
            // TenNguon
            // 
            this.TenNguon.Caption = "Tên nguồn";
            this.TenNguon.FieldName = "TenNguon";
            this.TenNguon.Name = "TenNguon";
            this.TenNguon.Width = 241;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Ngày chứng từ";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Width = 109;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Số chứng từ";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Width = 110;
            // 
            // TkTaisan
            // 
            this.TkTaisan.Caption = "TK tài sản";
            this.TkTaisan.FieldName = "MaTkCcdc";
            this.TkTaisan.Name = "TkTaisan";
            this.TkTaisan.OptionsColumn.ReadOnly = true;
            this.TkTaisan.OptionsColumn.TabStop = false;
            this.TkTaisan.Visible = true;
            this.TkTaisan.VisibleIndex = 1;
            this.TkTaisan.Width = 128;
            // 
            // MaTkPhanbo
            // 
            this.MaTkPhanbo.Caption = "TK phân bổ";
            this.MaTkPhanbo.FieldName = "MaTkPhanbo";
            this.MaTkPhanbo.Name = "MaTkPhanbo";
            this.MaTkPhanbo.OptionsColumn.ReadOnly = true;
            this.MaTkPhanbo.OptionsColumn.TabStop = false;
            this.MaTkPhanbo.Visible = true;
            this.MaTkPhanbo.VisibleIndex = 2;
            this.MaTkPhanbo.Width = 130;
            // 
            // MaTkChiphi
            // 
            this.MaTkChiphi.Caption = "TK chi phí";
            this.MaTkChiphi.ColumnEdit = this.rpTkCP;
            this.MaTkChiphi.FieldName = "MaTkChiphi";
            this.MaTkChiphi.Name = "MaTkChiphi";
            this.MaTkChiphi.Visible = true;
            this.MaTkChiphi.VisibleIndex = 3;
            this.MaTkChiphi.Width = 144;
            // 
            // rpTkCP
            // 
            this.rpTkCP.AutoHeight = false;
            this.rpTkCP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpTkCP.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tk chi phí-80-1;TenTaikhoan-Tên tk chi phí-200-1;Id-Tkid-80-0";
            this.rpTkCP.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.rpTkCP.C_DATA_SOURCE = null;
            this.rpTkCP.C_FORM_DANHSACH = "";
            this.rpTkCP.C_FORM_TITLE = "Chọn tài khoản";
            this.rpTkCP.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.rpTkCP.C_IS_CHECK_OTHER = "=";
            this.rpTkCP.C_IS_CHECK_STRING = "=";
            this.rpTkCP.C_IS_CHI_TIET = "";
            this.rpTkCP.C_IS_FILTER_STRING = "";
            this.rpTkCP.C_IS_QUICKADD = false;
            this.rpTkCP.C_IS_SORT_ORDER_STRING = "";
            this.rpTkCP.C_KEY_NAME = "MaTaikhoan";
            this.rpTkCP.Editors = null;
            this.rpTkCP.EditValues = "";
            this.rpTkCP.ListEditValues = null;
            this.rpTkCP.Name = "rpTkCP";
            this.rpTkCP.NEXT_TAB = 0;
            this.rpTkCP.OBJ_CONDITITION = null;
            // 
            // HeSoPbKh
            // 
            this.HeSoPbKh.Caption = "Hệ số phân bổ";
            this.HeSoPbKh.ColumnEdit = this.RepositoryItemTextEdit9;
            this.HeSoPbKh.FieldName = "HeSoPbKh";
            this.HeSoPbKh.Name = "HeSoPbKh";
            this.HeSoPbKh.Visible = true;
            this.HeSoPbKh.VisibleIndex = 4;
            this.HeSoPbKh.Width = 141;
            // 
            // RepositoryItemTextEdit9
            // 
            this.RepositoryItemTextEdit9.AutoHeight = false;
            this.RepositoryItemTextEdit9.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9";
            // 
            // NguyenGia
            // 
            this.NguyenGia.Caption = "Nguyên giá";
            this.NguyenGia.DisplayFormat.FormatString = "#,###0";
            this.NguyenGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NguyenGia.FieldName = "NguyenGia";
            this.NguyenGia.Name = "NguyenGia";
            this.NguyenGia.Width = 108;
            // 
            // HaoMonLuyKe
            // 
            this.HaoMonLuyKe.Caption = "Giá trị đã khấu hao";
            this.HaoMonLuyKe.FieldName = "HaoMonLuyKe";
            this.HaoMonLuyKe.Name = "HaoMonLuyKe";
            this.HaoMonLuyKe.Width = 119;
            // 
            // GiaTriConLai
            // 
            this.GiaTriConLai.Caption = "Giá trị còn lại";
            this.GiaTriConLai.FieldName = "GiaTriConLai";
            this.GiaTriConLai.Name = "GiaTriConLai";
            this.GiaTriConLai.Width = 110;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Giá trị KH 1 tháng";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Width = 113;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn giải";
            this.DienGiai.FieldName = "DienGiai";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 5;
            this.DienGiai.Width = 302;
            // 
            // RepositoryItemTextEdit8
            // 
            this.RepositoryItemTextEdit8.AutoHeight = false;
            this.RepositoryItemTextEdit8.MaxLength = 256;
            this.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8";
            // 
            // rpTkTS
            // 
            this.rpTkTS.AutoHeight = false;
            this.rpTkTS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpTkTS.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tk chi phí-80-1;TenTaikhoan-Tên tk chi phí-200-1;Id-Tkid-80-0";
            this.rpTkTS.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan";
            this.rpTkTS.C_DATA_SOURCE = null;
            this.rpTkTS.C_FORM_DANHSACH = "";
            this.rpTkTS.C_FORM_TITLE = "";
            this.rpTkTS.C_IS_CHECK_NUMBER = "=";
            this.rpTkTS.C_IS_CHECK_OTHER = "=";
            this.rpTkTS.C_IS_CHECK_STRING = "=";
            this.rpTkTS.C_IS_CHI_TIET = "";
            this.rpTkTS.C_IS_FILTER_STRING = "";
            this.rpTkTS.C_IS_QUICKADD = false;
            this.rpTkTS.C_IS_SORT_ORDER_STRING = "";
            this.rpTkTS.C_KEY_NAME = "";
            this.rpTkTS.Editors = null;
            this.rpTkTS.EditValues = "";
            this.rpTkTS.ListEditValues = null;
            this.rpTkTS.Name = "rpTkTS";
            this.rpTkTS.NEXT_TAB = 0;
            this.rpTkTS.OBJ_CONDITITION = null;
            // 
            // rpTkKH
            // 
            this.rpTkKH.AutoHeight = false;
            this.rpTkKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpTkKH.C_ARR_COLS_DISPLAY = "";
            this.rpTkKH.C_ARR_COLS_RETURN = "";
            this.rpTkKH.C_DATA_SOURCE = null;
            this.rpTkKH.C_FORM_DANHSACH = "";
            this.rpTkKH.C_FORM_TITLE = "";
            this.rpTkKH.C_IS_CHECK_NUMBER = "=";
            this.rpTkKH.C_IS_CHECK_OTHER = "=";
            this.rpTkKH.C_IS_CHECK_STRING = "=";
            this.rpTkKH.C_IS_CHI_TIET = "ChiTiet=1";
            this.rpTkKH.C_IS_FILTER_STRING = "";
            this.rpTkKH.C_IS_QUICKADD = false;
            this.rpTkKH.C_IS_SORT_ORDER_STRING = "";
            this.rpTkKH.C_KEY_NAME = "";
            this.rpTkKH.Editors = null;
            this.rpTkKH.EditValues = "";
            this.rpTkKH.ListEditValues = null;
            this.rpTkKH.Name = "rpTkKH";
            this.rpTkKH.NEXT_TAB = 0;
            this.rpTkKH.OBJ_CONDITITION = null;
            // 
            // XtraTabPage4
            // 
            this.XtraTabPage4.Controls.Add(this._grcPhuTung);
            this.XtraTabPage4.Name = "XtraTabPage4";
            this.XtraTabPage4.PageVisible = false;
            this.XtraTabPage4.Size = new System.Drawing.Size(873, 268);
            this.XtraTabPage4.Text = "4.Phụ tùng kèm theo";
            // 
            // _grcPhuTung
            // 
            this._grcPhuTung.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grcPhuTung.Location = new System.Drawing.Point(0, 0);
            this._grcPhuTung.MainView = this._grvPhuTung;
            this._grcPhuTung.Name = "_grcPhuTung";
            this._grcPhuTung.Size = new System.Drawing.Size(873, 268);
            this._grcPhuTung.TabIndex = 2;
            this._grcPhuTung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._grvPhuTung});
            // 
            // _grvPhuTung
            // 
            this._grvPhuTung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn10,
            this.GridColumn11,
            this.GridColumn12,
            this.GridColumn13,
            this.GridColumn14,
            this.GridColumn15});
            this._grvPhuTung.GridControl = this._grcPhuTung;
            this._grvPhuTung.Name = "_grvPhuTung";
            this._grvPhuTung.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn10
            // 
            this.GridColumn10.Caption = "STT";
            this.GridColumn10.Name = "GridColumn10";
            this.GridColumn10.Visible = true;
            this.GridColumn10.VisibleIndex = 0;
            this.GridColumn10.Width = 33;
            // 
            // GridColumn11
            // 
            this.GridColumn11.Caption = "Tên phụ tùng kèm theo";
            this.GridColumn11.Name = "GridColumn11";
            this.GridColumn11.Visible = true;
            this.GridColumn11.VisibleIndex = 1;
            this.GridColumn11.Width = 216;
            // 
            // GridColumn12
            // 
            this.GridColumn12.Caption = "ĐVT";
            this.GridColumn12.Name = "GridColumn12";
            this.GridColumn12.Visible = true;
            this.GridColumn12.VisibleIndex = 2;
            this.GridColumn12.Width = 60;
            // 
            // GridColumn13
            // 
            this.GridColumn13.Caption = "Số lượng";
            this.GridColumn13.Name = "GridColumn13";
            this.GridColumn13.Visible = true;
            this.GridColumn13.VisibleIndex = 3;
            this.GridColumn13.Width = 86;
            // 
            // GridColumn14
            // 
            this.GridColumn14.Caption = "Giá trị";
            this.GridColumn14.Name = "GridColumn14";
            this.GridColumn14.Visible = true;
            this.GridColumn14.VisibleIndex = 4;
            this.GridColumn14.Width = 104;
            // 
            // GridColumn15
            // 
            this.GridColumn15.Name = "GridColumn15";
            this.GridColumn15.Visible = true;
            this.GridColumn15.VisibleIndex = 5;
            this.GridColumn15.Width = 475;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnPrint);
            this.PanelControl2.Controls.Add(this.btnQuit);
            this.PanelControl2.Controls.Add(this.btnSave);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(4, 574);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(880, 34);
            this.PanelControl2.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(86, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "In thẻ";
            this.btnPrint.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.ImageIndex = 8;
            this.btnQuit.Location = new System.Drawing.Point(800, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "&Quay ra";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            // 
            // GridColumn17
            // 
            this.GridColumn17.Caption = "Ký hiệu";
            this.GridColumn17.FieldName = "KyHieu";
            this.GridColumn17.Name = "GridColumn17";
            this.GridColumn17.Visible = true;
            this.GridColumn17.VisibleIndex = 0;
            // 
            // GridColumn18
            // 
            this.GridColumn18.Caption = "Tên phòng ban";
            this.GridColumn18.FieldName = "TenPhongban";
            this.GridColumn18.Name = "GridColumn18";
            this.GridColumn18.Visible = true;
            this.GridColumn18.VisibleIndex = 1;
            // 
            // GridColumn20
            // 
            this.GridColumn20.Caption = "Mã phòng ban";
            this.GridColumn20.FieldName = "MaPhongban";
            this.GridColumn20.Name = "GridColumn20";
            this.GridColumn20.Visible = true;
            this.GridColumn20.VisibleIndex = 0;
            // 
            // GridColumn19
            // 
            this.GridColumn19.Caption = "Tên phòng ban";
            this.GridColumn19.FieldName = "TenPhongban";
            this.GridColumn19.Name = "GridColumn19";
            this.GridColumn19.Visible = true;
            this.GridColumn19.VisibleIndex = 1;
            // 
            // frmKhaiBaoCCDC_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(888, 612);
            this.Controls.Add(this.XtraTabControl2);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.XtraTabControl1);
            this.KeyPreview = true;
            this.Name = "frmKhaiBaoCCDC_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khai báo CCDC";
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).EndInit();
            this.XtraTabControl1.ResumeLayout(false);
            this.XtraTabPage1.ResumeLayout(false);
            this.XtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBDSD.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBDSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlBoPhanSd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNhom1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlKieuPb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGTCL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKyPb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCC.Properties)).EndInit();
            this.XtraTabPage2.ResumeLayout(false);
            this.XtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTskt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl2)).EndInit();
            this.XtraTabControl2.ResumeLayout(false);
            this.XtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTkKH)).EndInit();
            this.XtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grcPhuTung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grvPhuTung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraTab.XtraTabControl XtraTabControl1;
        internal DevExpress.XtraTab.XtraTabPage XtraTabPage1;
        internal DevExpress.XtraTab.XtraTabPage XtraTabPage2;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraTab.XtraTabControl XtraTabControl2;
        internal DevExpress.XtraTab.XtraTabPage XtraTabPage3;
        internal DevExpress.XtraTab.XtraTabPage XtraTabPage4;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnQuit;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraGrid.GridControl _grcPhuTung;
        internal DevExpress.XtraGrid.Views.Grid.GridView _grvPhuTung;
        internal DevExpress.XtraEditors.DateEdit dteNgayBDSD;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNhom3;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView9;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNhom2;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView8;
        internal DevExpress.XtraEditors.GridLookUpEdit grlBoPhanSd;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView6;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNhom1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView7;
        internal DevExpress.XtraEditors.GridLookUpEdit grlKieuPb;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraEditors.LabelControl LabelControl18;
        internal DevExpress.XtraEditors.TextEdit txtSoLuong;
        internal DevExpress.XtraEditors.LabelControl LabelControl17;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl21;
        internal DevExpress.XtraEditors.LabelControl LabelControl16;
        internal DevExpress.XtraEditors.LabelControl LabelControl15;
        internal DevExpress.XtraEditors.LabelControl LabelControl20;
        internal DevExpress.XtraEditors.TextEdit txtNguyenGia;
        internal DevExpress.XtraEditors.LabelControl LabelControl19;
        internal DevExpress.XtraEditors.TextEdit txtSoKyPb;
        internal DevExpress.XtraEditors.TextEdit txtTenCC;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl10;
        internal DevExpress.XtraEditors.LabelControl LabelControl9;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtMaCC;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtNamSx;
        internal DevExpress.XtraEditors.TextEdit txtNuocSx;
        internal DevExpress.XtraEditors.LabelControl LabelControl34;
        internal DevExpress.XtraEditors.LabelControl LabelControl35;
        internal DevExpress.XtraEditors.LabelControl LabelControl40;
        internal DevExpress.XtraEditors.TextEdit txtTskt;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn10;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn11;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn12;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn13;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn14;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn15;
        internal DevExpress.XtraEditors.TextEdit txtGTCL;
        internal DevExpress.XtraEditors.LabelControl LabelControl12;
        internal DevExpress.XtraEditors.GridLookUpEdit grlDVT;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn16;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn17;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn18;
        internal Vns.Erp.Core.CustomFilter C_filter_TKCP;
        internal Vns.Erp.Core.CustomFilter C_filter_TKPB;
        internal Vns.Erp.Core.CustomFilter C_filter_TKCC;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn20;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn19;
        internal DevExpress.XtraGrid.GridControl grcNGUON_VON;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvNGUON_VON;
        internal DevExpress.XtraGrid.Columns.GridColumn DM_NGUON_TSCD_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn TenNguon;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn TkTaisan;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTkPhanbo;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTkChiphi;
        internal DevExpress.XtraGrid.Columns.GridColumn HeSoPbKh;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit9;
        internal DevExpress.XtraGrid.Columns.GridColumn NguyenGia;
        internal DevExpress.XtraGrid.Columns.GridColumn HaoMonLuyKe;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaTriConLai;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit8;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboNguonVon;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpTkTS;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpTkKH;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpTkCP;

    }
}