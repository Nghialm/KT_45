using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmTinhKhauHaoCCDC : DevExpress.XtraEditors.XtraForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            this.SoKyPhanbo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SoTienPb = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnKHThang = new DevExpress.XtraEditors.SimpleButton();
            this.txtNAM = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTHANG = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.MA_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeMA_TK_NO = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.TEN_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeMA_TK_CO = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.grvDINH_KHOAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NOI_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDINH_KHOAN = new DevExpress.XtraGrid.GridControl();
            this.cboDM_NGUON_TSCD_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboLY_DO_TANGGIAM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_TAISAN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMA_TK_NO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMA_TK_CO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RepositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.RepositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.xtrDINH_KHOAN = new DevExpress.XtraTab.XtraTabPage();
            this.txtSO_TIEN = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RepositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.THANG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.NAM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.GiaTriCl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this._Control = new DevExpress.XtraTab.XtraTabControl();
            this.xtrLSHM = new DevExpress.XtraTab.XtraTabPage();
            this._TreeList = new DevExpress.XtraTreeList.TreeList();
            this.MaCcdc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TenCcdc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ID_CHA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).BeginInit();
            this.GroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_CO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDINH_KHOAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDINH_KHOAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_CO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemResourcesComboBox1)).BeginInit();
            this.xtrDINH_KHOAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_TIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            this.PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Control)).BeginInit();
            this._Control.SuspendLayout();
            this.xtrLSHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // SoKyPhanbo
            // 
            this.SoKyPhanbo.AppearanceCell.Options.UseTextOptions = true;
            this.SoKyPhanbo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SoKyPhanbo.Caption = "Số kỳ PB";
            this.SoKyPhanbo.FieldName = "SoKyPhanbo";
            this.SoKyPhanbo.Name = "SoKyPhanbo";
            this.SoKyPhanbo.OptionsColumn.ReadOnly = true;
            this.SoKyPhanbo.Visible = true;
            this.SoKyPhanbo.VisibleIndex = 3;
            // 
            // SoTienPb
            // 
            this.SoTienPb.AppearanceHeader.Options.UseImage = true;
            this.SoTienPb.Caption = "Số tiền phân bổ tháng";
            this.SoTienPb.ColumnEdit = this.RepositoryItemTextEdit2;
            this.SoTienPb.FieldName = "SoTienPb";
            this.SoTienPb.Format.FormatString = "n0";
            this.SoTienPb.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoTienPb.ImageIndex = 1;
            this.SoTienPb.Name = "SoTienPb";
            this.SoTienPb.Visible = true;
            this.SoTienPb.VisibleIndex = 2;
            this.SoTienPb.Width = 152;
            // 
            // RepositoryItemTextEdit2
            // 
            this.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit2.AutoHeight = false;
            this.RepositoryItemTextEdit2.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2";
            // 
            // GroupControl3
            // 
            this.GroupControl3.Controls.Add(this.btnKHThang);
            this.GroupControl3.Controls.Add(this.txtNAM);
            this.GroupControl3.Controls.Add(this.LabelControl2);
            this.GroupControl3.Controls.Add(this.txtTHANG);
            this.GroupControl3.Controls.Add(this.LabelControl1);
            this.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl3.Location = new System.Drawing.Point(0, 0);
            this.GroupControl3.Name = "GroupControl3";
            this.GroupControl3.Size = new System.Drawing.Size(1008, 66);
            this.GroupControl3.TabIndex = 8;
            this.GroupControl3.Text = "Tính khấu hao";
            // 
            // btnKHThang
            // 
            this.btnKHThang.Location = new System.Drawing.Point(367, 28);
            this.btnKHThang.Name = "btnKHThang";
            this.btnKHThang.Size = new System.Drawing.Size(111, 30);
            this.btnKHThang.TabIndex = 3;
            this.btnKHThang.Text = "Tính phân bổ tháng";
            this.btnKHThang.Click += new System.EventHandler(this.btnKHThang_Click);
            // 
            // txtNAM
            // 
            this.txtNAM.EnterMoveNextControl = true;
            this.txtNAM.Location = new System.Drawing.Point(241, 33);
            this.txtNAM.Name = "txtNAM";
            this.txtNAM.Properties.Mask.EditMask = "[0-9]+";
            this.txtNAM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNAM.Properties.Mask.ShowPlaceHolders = false;
            this.txtNAM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNAM.Size = new System.Drawing.Size(108, 20);
            this.txtNAM.TabIndex = 1;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(198, 36);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(21, 13);
            this.LabelControl2.TabIndex = 4;
            this.LabelControl2.Text = "Năm";
            // 
            // txtTHANG
            // 
            this.txtTHANG.EnterMoveNextControl = true;
            this.txtTHANG.Location = new System.Drawing.Point(68, 33);
            this.txtTHANG.Name = "txtTHANG";
            this.txtTHANG.Properties.Mask.EditMask = "[0-9]+";
            this.txtTHANG.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTHANG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTHANG.Size = new System.Drawing.Size(108, 20);
            this.txtTHANG.TabIndex = 0;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(13, 36);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(30, 13);
            this.LabelControl1.TabIndex = 3;
            this.LabelControl1.Text = "Tháng";
            // 
            // MA_TK_NO
            // 
            this.MA_TK_NO.Caption = "Mã TK nợ";
            this.MA_TK_NO.ColumnEdit = this.rpeMA_TK_NO;
            this.MA_TK_NO.FieldName = "MaTkNo";
            this.MA_TK_NO.ImageIndex = 1;
            this.MA_TK_NO.Name = "MA_TK_NO";
            this.MA_TK_NO.Visible = true;
            this.MA_TK_NO.VisibleIndex = 0;
            this.MA_TK_NO.Width = 97;
            // 
            // rpeMA_TK_NO
            // 
            this.rpeMA_TK_NO.AutoHeight = false;
            this.rpeMA_TK_NO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpeMA_TK_NO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tk nợ-80-1;TenTaikhoan-Tên tk nợ-200-1;Id-tkid-80-0";
            this.rpeMA_TK_NO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan";
            this.rpeMA_TK_NO.C_DATA_SOURCE = null;
            this.rpeMA_TK_NO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.rpeMA_TK_NO.C_FORM_TITLE = "Chọn tài khoản";
            this.rpeMA_TK_NO.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.rpeMA_TK_NO.C_IS_CHECK_OTHER = "=";
            this.rpeMA_TK_NO.C_IS_CHECK_STRING = "=";
            this.rpeMA_TK_NO.C_IS_CHI_TIET = "";
            this.rpeMA_TK_NO.C_IS_FILTER_STRING = "";
            this.rpeMA_TK_NO.C_IS_QUICKADD = false;
            this.rpeMA_TK_NO.C_IS_SORT_ORDER_STRING = "";
            this.rpeMA_TK_NO.C_KEY_NAME = "MaTaikhoan";
            this.rpeMA_TK_NO.Editors = null;
            this.rpeMA_TK_NO.EditValues = "";
            this.rpeMA_TK_NO.ListEditValues = null;
            this.rpeMA_TK_NO.Name = "rpeMA_TK_NO";
            this.rpeMA_TK_NO.NEXT_TAB = 0;
            this.rpeMA_TK_NO.OBJ_CONDITITION = null;
            // 
            // TEN_TK_NO
            // 
            this.TEN_TK_NO.Caption = "Tên TK nợ";
            this.TEN_TK_NO.FieldName = "TenTkNo";
            this.TEN_TK_NO.Name = "TEN_TK_NO";
            this.TEN_TK_NO.OptionsColumn.ReadOnly = true;
            this.TEN_TK_NO.Visible = true;
            this.TEN_TK_NO.VisibleIndex = 1;
            this.TEN_TK_NO.Width = 215;
            // 
            // MA_TK_CO
            // 
            this.MA_TK_CO.Caption = "Mã TK có";
            this.MA_TK_CO.ColumnEdit = this.rpeMA_TK_CO;
            this.MA_TK_CO.FieldName = "MaTkCo";
            this.MA_TK_CO.ImageIndex = 1;
            this.MA_TK_CO.Name = "MA_TK_CO";
            this.MA_TK_CO.Visible = true;
            this.MA_TK_CO.VisibleIndex = 2;
            this.MA_TK_CO.Width = 97;
            // 
            // rpeMA_TK_CO
            // 
            this.rpeMA_TK_CO.AutoHeight = false;
            this.rpeMA_TK_CO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpeMA_TK_CO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tk có-80-1;TenTaikhoan-Tên tk có-200-1;Id-tkid-80-0";
            this.rpeMA_TK_CO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan";
            this.rpeMA_TK_CO.C_DATA_SOURCE = null;
            this.rpeMA_TK_CO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.rpeMA_TK_CO.C_FORM_TITLE = "Chọn tài khoản";
            this.rpeMA_TK_CO.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.rpeMA_TK_CO.C_IS_CHECK_OTHER = "=";
            this.rpeMA_TK_CO.C_IS_CHECK_STRING = "=";
            this.rpeMA_TK_CO.C_IS_CHI_TIET = "";
            this.rpeMA_TK_CO.C_IS_FILTER_STRING = "";
            this.rpeMA_TK_CO.C_IS_QUICKADD = false;
            this.rpeMA_TK_CO.C_IS_SORT_ORDER_STRING = "";
            this.rpeMA_TK_CO.C_KEY_NAME = "MaTaikhoan";
            this.rpeMA_TK_CO.Editors = null;
            this.rpeMA_TK_CO.EditValues = "";
            this.rpeMA_TK_CO.ListEditValues = null;
            this.rpeMA_TK_CO.Name = "rpeMA_TK_CO";
            this.rpeMA_TK_CO.NEXT_TAB = 0;
            this.rpeMA_TK_CO.OBJ_CONDITITION = null;
            // 
            // grvDINH_KHOAN
            // 
            this.grvDINH_KHOAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_TK_NO,
            this.TEN_TK_NO,
            this.MA_TK_CO,
            this.TEN_TK_CO,
            this.SO_TIEN,
            this.NOI_DUNG});
            this.grvDINH_KHOAN.GridControl = this.grcDINH_KHOAN;
            this.grvDINH_KHOAN.Name = "grvDINH_KHOAN";
            this.grvDINH_KHOAN.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDINH_KHOAN.OptionsView.ColumnAutoWidth = false;
            this.grvDINH_KHOAN.OptionsView.ShowGroupPanel = false;
            // 
            // TEN_TK_CO
            // 
            this.TEN_TK_CO.Caption = "Tên TK có";
            this.TEN_TK_CO.FieldName = "TenTkCo";
            this.TEN_TK_CO.Name = "TEN_TK_CO";
            this.TEN_TK_CO.OptionsColumn.ReadOnly = true;
            this.TEN_TK_CO.Visible = true;
            this.TEN_TK_CO.VisibleIndex = 3;
            this.TEN_TK_CO.Width = 263;
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.ColumnEdit = this.RepositoryItemTextEdit5;
            this.SO_TIEN.DisplayFormat.FormatString = "n0";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN.FieldName = "SoTien";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.OptionsColumn.ReadOnly = true;
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 4;
            this.SO_TIEN.Width = 122;
            // 
            // RepositoryItemTextEdit5
            // 
            this.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.RepositoryItemTextEdit5.AutoHeight = false;
            this.RepositoryItemTextEdit5.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5";
            // 
            // NOI_DUNG
            // 
            this.NOI_DUNG.Caption = "Nội dung";
            this.NOI_DUNG.FieldName = "NoiDung";
            this.NOI_DUNG.ImageIndex = 1;
            this.NOI_DUNG.Name = "NOI_DUNG";
            this.NOI_DUNG.Visible = true;
            this.NOI_DUNG.VisibleIndex = 5;
            this.NOI_DUNG.Width = 481;
            // 
            // grcDINH_KHOAN
            // 
            this.grcDINH_KHOAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDINH_KHOAN.Location = new System.Drawing.Point(0, 0);
            this.grcDINH_KHOAN.MainView = this.grvDINH_KHOAN;
            this.grcDINH_KHOAN.Name = "grcDINH_KHOAN";
            this.grcDINH_KHOAN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboDM_NGUON_TSCD_ID,
            this.cboLY_DO_TANGGIAM,
            this.cboTK_TAISAN,
            this.cboTK_CHIPHI,
            this.cboMA_TK_NO,
            this.cboMA_TK_CO,
            this.RepositoryItemPopupContainerEdit1,
            this.RepositoryItemResourcesComboBox1,
            this.rpeMA_TK_NO,
            this.rpeMA_TK_CO,
            this.RepositoryItemTextEdit5});
            this.grcDINH_KHOAN.Size = new System.Drawing.Size(997, 479);
            this.grcDINH_KHOAN.TabIndex = 5010;
            this.grcDINH_KHOAN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDINH_KHOAN});
            // 
            // cboDM_NGUON_TSCD_ID
            // 
            this.cboDM_NGUON_TSCD_ID.AutoHeight = false;
            this.cboDM_NGUON_TSCD_ID.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboDM_NGUON_TSCD_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDM_NGUON_TSCD_ID.Name = "cboDM_NGUON_TSCD_ID";
            this.cboDM_NGUON_TSCD_ID.NullText = "";
            // 
            // cboLY_DO_TANGGIAM
            // 
            this.cboLY_DO_TANGGIAM.AutoHeight = false;
            this.cboLY_DO_TANGGIAM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLY_DO_TANGGIAM.Name = "cboLY_DO_TANGGIAM";
            this.cboLY_DO_TANGGIAM.NullText = "";
            // 
            // cboTK_TAISAN
            // 
            this.cboTK_TAISAN.AutoHeight = false;
            this.cboTK_TAISAN.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_TAISAN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_TAISAN.Name = "cboTK_TAISAN";
            this.cboTK_TAISAN.NullText = "";
            // 
            // cboTK_CHIPHI
            // 
            this.cboTK_CHIPHI.AutoHeight = false;
            this.cboTK_CHIPHI.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_CHIPHI.Name = "cboTK_CHIPHI";
            this.cboTK_CHIPHI.NullText = "";
            // 
            // cboMA_TK_NO
            // 
            this.cboMA_TK_NO.AutoHeight = false;
            this.cboMA_TK_NO.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMA_TK_NO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMA_TK_NO.Name = "cboMA_TK_NO";
            this.cboMA_TK_NO.NullText = "";
            // 
            // cboMA_TK_CO
            // 
            this.cboMA_TK_CO.AutoHeight = false;
            this.cboMA_TK_CO.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMA_TK_CO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMA_TK_CO.Name = "cboMA_TK_CO";
            this.cboMA_TK_CO.NullText = "";
            // 
            // RepositoryItemPopupContainerEdit1
            // 
            this.RepositoryItemPopupContainerEdit1.AutoHeight = false;
            this.RepositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1";
            // 
            // RepositoryItemResourcesComboBox1
            // 
            this.RepositoryItemResourcesComboBox1.AutoHeight = false;
            this.RepositoryItemResourcesComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemResourcesComboBox1.Name = "RepositoryItemResourcesComboBox1";
            // 
            // xtrDINH_KHOAN
            // 
            this.xtrDINH_KHOAN.Controls.Add(this.grcDINH_KHOAN);
            this.xtrDINH_KHOAN.Controls.Add(this.txtSO_TIEN);
            this.xtrDINH_KHOAN.Controls.Add(this.LabelControl3);
            this.xtrDINH_KHOAN.Name = "xtrDINH_KHOAN";
            this.xtrDINH_KHOAN.Size = new System.Drawing.Size(997, 479);
            this.xtrDINH_KHOAN.Text = "Định khoản         ";
            // 
            // txtSO_TIEN
            // 
            this.txtSO_TIEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSO_TIEN.Location = new System.Drawing.Point(854, 441);
            this.txtSO_TIEN.Name = "txtSO_TIEN";
            this.txtSO_TIEN.Properties.ReadOnly = true;
            this.txtSO_TIEN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSO_TIEN.Size = new System.Drawing.Size(137, 20);
            this.txtSO_TIEN.TabIndex = 5012;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl3.Location = new System.Drawing.Point(790, 444);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(45, 13);
            this.LabelControl3.TabIndex = 5011;
            this.LabelControl3.Text = "Tổng tiền";
            // 
            // RepositoryItemTextEdit4
            // 
            this.RepositoryItemTextEdit4.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit4.AutoHeight = false;
            this.RepositoryItemTextEdit4.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4";
            // 
            // THANG
            // 
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "Thang";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.ReadOnly = true;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 5;
            this.THANG.Width = 82;
            // 
            // NAM
            // 
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "Nam";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.ReadOnly = true;
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 6;
            this.NAM.Width = 69;
            // 
            // GiaTriCl
            // 
            this.GiaTriCl.Caption = "Giá trị còn lại";
            this.GiaTriCl.ColumnEdit = this.RepositoryItemTextEdit4;
            this.GiaTriCl.FieldName = "GiaTriCl";
            this.GiaTriCl.Format.FormatString = "n0";
            this.GiaTriCl.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTriCl.Name = "GiaTriCl";
            this.GiaTriCl.OptionsColumn.ReadOnly = true;
            this.GiaTriCl.Visible = true;
            this.GiaTriCl.VisibleIndex = 4;
            this.GiaTriCl.Width = 124;
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnXoa);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(0, 578);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1008, 34);
            this.PanelControl1.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(86, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa phân bổ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(925, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Đóng";
            // 
            // PanelControl3
            // 
            this.PanelControl3.Controls.Add(this._Control);
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl3.Location = new System.Drawing.Point(0, 66);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(1008, 512);
            this.PanelControl3.TabIndex = 11;
            // 
            // _Control
            // 
            this._Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Control.Location = new System.Drawing.Point(2, 2);
            this._Control.Name = "_Control";
            this._Control.SelectedTabPage = this.xtrLSHM;
            this._Control.Size = new System.Drawing.Size(1004, 508);
            this._Control.TabIndex = 2;
            this._Control.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtrLSHM,
            this.xtrDINH_KHOAN});
            // 
            // xtrLSHM
            // 
            this.xtrLSHM.AutoScroll = true;
            this.xtrLSHM.Controls.Add(this._TreeList);
            this.xtrLSHM.Name = "xtrLSHM";
            this.xtrLSHM.Size = new System.Drawing.Size(997, 479);
            this.xtrLSHM.Text = "Lịch sử hao mòn";
            // 
            // _TreeList
            // 
            this._TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.MaCcdc,
            this.TenCcdc,
            this.SoTienPb,
            this.SoKyPhanbo,
            this.GiaTriCl,
            this.THANG,
            this.NAM,
            this.ID_CHA});
            this._TreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.LightGray;
            styleFormatCondition5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.Appearance.Options.UseFont = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Column = this.SoKyPhanbo;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition5.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Column = this.SoTienPb;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition6.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._TreeList.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition5,
            styleFormatCondition6});
            this._TreeList.KeyFieldName = "TS_LS_KHAUHAO_ID";
            this._TreeList.Location = new System.Drawing.Point(0, 0);
            this._TreeList.Name = "_TreeList";
            this._TreeList.OptionsBehavior.EnterMovesNextColumn = true;
            this._TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this._TreeList.ParentFieldName = "ID_CHA";
            this._TreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2,
            this.RepositoryItemTextEdit3,
            this.RepositoryItemTextEdit4});
            this._TreeList.Size = new System.Drawing.Size(997, 479);
            this._TreeList.TabIndex = 1;
            // 
            // MaCcdc
            // 
            this.MaCcdc.Caption = "Mã CCDC";
            this.MaCcdc.FieldName = "MaCcdc";
            this.MaCcdc.MinWidth = 35;
            this.MaCcdc.Name = "MaCcdc";
            this.MaCcdc.OptionsColumn.ReadOnly = true;
            this.MaCcdc.Visible = true;
            this.MaCcdc.VisibleIndex = 0;
            this.MaCcdc.Width = 141;
            // 
            // TenCcdc
            // 
            this.TenCcdc.Caption = "Tên CCDC";
            this.TenCcdc.FieldName = "TenCcdc";
            this.TenCcdc.Name = "TenCcdc";
            this.TenCcdc.OptionsColumn.ReadOnly = true;
            this.TenCcdc.Visible = true;
            this.TenCcdc.VisibleIndex = 1;
            this.TenCcdc.Width = 312;
            // 
            // ID_CHA
            // 
            this.ID_CHA.FieldName = "ID_CHA";
            this.ID_CHA.Name = "ID_CHA";
            this.ID_CHA.OptionsColumn.ReadOnly = true;
            // 
            // RepositoryItemTextEdit3
            // 
            this.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit3.AutoHeight = false;
            this.RepositoryItemTextEdit3.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl2.Location = new System.Drawing.Point(0, 66);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(1008, 4);
            this.PanelControl2.TabIndex = 9;
            // 
            // frmTinhKhauHaoCCDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.PanelControl3);
            this.Controls.Add(this.GroupControl3);
            this.Controls.Add(this.PanelControl1);
            this.Name = "frmTinhKhauHaoCCDC";
            this.Text = "Phân bổ CCDC";
            this.Load += new System.EventHandler(this.frmTinhKhauHaoCCDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).EndInit();
            this.GroupControl3.ResumeLayout(false);
            this.GroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_CO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDINH_KHOAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDINH_KHOAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_CO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemResourcesComboBox1)).EndInit();
            this.xtrDINH_KHOAN.ResumeLayout(false);
            this.xtrDINH_KHOAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_TIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            this.PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Control)).EndInit();
            this._Control.ResumeLayout(false);
            this.xtrLSHM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl3;
        internal DevExpress.XtraEditors.SimpleButton btnKHThang;
        internal DevExpress.XtraEditors.TextEdit txtNAM;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtTHANG;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_NO;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeMA_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_CO;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeMA_TK_CO;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvDINH_KHOAN;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit5;
        internal DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG;
        internal DevExpress.XtraGrid.GridControl grcDINH_KHOAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDM_NGUON_TSCD_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboLY_DO_TANGGIAM;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_TAISAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_CHIPHI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_NO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_CO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit RepositoryItemPopupContainerEdit1;
        internal DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox RepositoryItemResourcesComboBox1;
        internal DevExpress.XtraTab.XtraTabPage xtrDINH_KHOAN;
        internal DevExpress.XtraEditors.TextEdit txtSO_TIEN;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit4;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn THANG;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn NAM;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn GiaTriCl;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnXoa;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraTab.XtraTabControl _Control;
        internal DevExpress.XtraTab.XtraTabPage xtrLSHM;
        internal DevExpress.XtraTreeList.TreeList _TreeList;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn MaCcdc;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn TenCcdc;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn SoTienPb;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn SoKyPhanbo;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit3;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn ID_CHA;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;

    }
}