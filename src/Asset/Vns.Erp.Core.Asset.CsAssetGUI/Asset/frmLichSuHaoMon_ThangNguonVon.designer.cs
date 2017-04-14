using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmLichSuHaoMon_ThangNguonVon : DevExpress.XtraEditors.XtraForm
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
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition9 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition10 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuHaoMon_ThangNguonVon));
            this.HE_SO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.HAO_MON_THANG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_CHA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ckeHienThi = new DevExpress.XtraEditors.CheckEdit();
            this.ckeXoaDL = new DevExpress.XtraEditors.CheckEdit();
            this.btnKHThang = new DevExpress.XtraEditors.SimpleButton();
            this.txtNAM = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTHANG = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDINH_KHOAN = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this._Control = new DevExpress.XtraTab.XtraTabControl();
            this.xtrLSHM = new DevExpress.XtraTab.XtraTabPage();
            this._TreeList = new DevExpress.XtraTreeList.TreeList();
            this.MA_TSCD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TEN_TSCD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.HAO_MON_NAM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.HAO_MON_LK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GIA_TRI_CL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RepositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.THANG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.NAM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imglImporter = new System.Windows.Forms.ImageList(this.components);
            this.xtrDINH_KHOAN = new DevExpress.XtraTab.XtraTabPage();
            this.grcDINH_KHOAN = new DevExpress.XtraGrid.GridControl();
            this.grvDINH_KHOAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeMA_TK_NO = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.TEN_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeMA_TK_CO = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.TEN_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NOI_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDM_NGUON_TSCD_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboLY_DO_TANGGIAM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_TAISAN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMA_TK_NO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMA_TK_CO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RepositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.RepositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.txtSO_TIEN = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).BeginInit();
            this.GroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHienThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeXoaDL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            this.PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Control)).BeginInit();
            this._Control.SuspendLayout();
            this.xtrLSHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).BeginInit();
            this.xtrDINH_KHOAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDINH_KHOAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDINH_KHOAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_CO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_CO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemResourcesComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_TIEN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HE_SO
            // 
            this.HE_SO.AppearanceCell.Options.UseTextOptions = true;
            this.HE_SO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HE_SO.Caption = "Hệ số";
            this.HE_SO.FieldName = "HE_SO";
            this.HE_SO.Name = "HE_SO";
            this.HE_SO.OptionsColumn.ReadOnly = true;
            this.HE_SO.Visible = true;
            this.HE_SO.VisibleIndex = 3;
            // 
            // HAO_MON_THANG
            // 
            this.HAO_MON_THANG.AppearanceHeader.Options.UseImage = true;
            this.HAO_MON_THANG.Caption = "Hao mòn tháng";
            this.HAO_MON_THANG.ColumnEdit = this.RepositoryItemTextEdit2;
            this.HAO_MON_THANG.FieldName = "HAO_MON_THANG";
            this.HAO_MON_THANG.Format.FormatString = "n0";
            this.HAO_MON_THANG.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HAO_MON_THANG.ImageIndex = 1;
            this.HAO_MON_THANG.Name = "HAO_MON_THANG";
            this.HAO_MON_THANG.Visible = true;
            this.HAO_MON_THANG.VisibleIndex = 2;
            this.HAO_MON_THANG.Width = 152;
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
            // ID_CHA
            // 
            this.ID_CHA.FieldName = "ID_CHA";
            this.ID_CHA.Name = "ID_CHA";
            this.ID_CHA.OptionsColumn.ReadOnly = true;
            // 
            // GroupControl3
            // 
            this.GroupControl3.Controls.Add(this.ckeHienThi);
            this.GroupControl3.Controls.Add(this.ckeXoaDL);
            this.GroupControl3.Controls.Add(this.btnKHThang);
            this.GroupControl3.Controls.Add(this.txtNAM);
            this.GroupControl3.Controls.Add(this.LabelControl2);
            this.GroupControl3.Controls.Add(this.txtTHANG);
            this.GroupControl3.Controls.Add(this.LabelControl1);
            this.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl3.Location = new System.Drawing.Point(4, 4);
            this.GroupControl3.Name = "GroupControl3";
            this.GroupControl3.Size = new System.Drawing.Size(1001, 66);
            this.GroupControl3.TabIndex = 0;
            this.GroupControl3.Text = "Tính khấu hao";
            // 
            // ckeHienThi
            // 
            this.ckeHienThi.Location = new System.Drawing.Point(596, 33);
            this.ckeHienThi.Name = "ckeHienThi";
            this.ckeHienThi.Properties.Caption = "Hiển thị TS được tính khấu hao";
            this.ckeHienThi.Size = new System.Drawing.Size(167, 19);
            this.ckeHienThi.TabIndex = 4;
            this.ckeHienThi.CheckedChanged += new System.EventHandler(this.ckeHienThi_CheckedChanged);
            // 
            // ckeXoaDL
            // 
            this.ckeXoaDL.Location = new System.Drawing.Point(496, 33);
            this.ckeXoaDL.Name = "ckeXoaDL";
            this.ckeXoaDL.Properties.Caption = "Xóa dữ liệu cũ";
            this.ckeXoaDL.Size = new System.Drawing.Size(108, 19);
            this.ckeXoaDL.TabIndex = 4;
            // 
            // btnKHThang
            // 
            this.btnKHThang.Location = new System.Drawing.Point(367, 28);
            this.btnKHThang.Name = "btnKHThang";
            this.btnKHThang.Size = new System.Drawing.Size(111, 30);
            this.btnKHThang.TabIndex = 3;
            this.btnKHThang.Text = "Tính khấu hao tháng";
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
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl2.Location = new System.Drawing.Point(4, 70);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(1001, 4);
            this.PanelControl2.TabIndex = 4;
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnDINH_KHOAN);
            this.PanelControl1.Controls.Add(this.btnXoa);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 574);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1001, 34);
            this.PanelControl1.TabIndex = 6;
            // 
            // btnDINH_KHOAN
            // 
            this.btnDINH_KHOAN.Location = new System.Drawing.Point(172, 3);
            this.btnDINH_KHOAN.Name = "btnDINH_KHOAN";
            this.btnDINH_KHOAN.Size = new System.Drawing.Size(80, 30);
            this.btnDINH_KHOAN.TabIndex = 3;
            this.btnDINH_KHOAN.Text = "&Định khoản";
            this.btnDINH_KHOAN.Click += new System.EventHandler(this.btnDINH_KHOAN_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(86, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa khấu hao";
            this.btnXoa.Click += new System.EventHandler(this.btnRod_Click);
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
            this.btnClose.Location = new System.Drawing.Point(918, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PanelControl3
            // 
            this.PanelControl3.Controls.Add(this._Control);
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl3.Location = new System.Drawing.Point(4, 74);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(1001, 500);
            this.PanelControl3.TabIndex = 7;
            // 
            // _Control
            // 
            this._Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Control.Location = new System.Drawing.Point(2, 2);
            this._Control.Name = "_Control";
            this._Control.SelectedTabPage = this.xtrLSHM;
            this._Control.Size = new System.Drawing.Size(997, 496);
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
            this.xtrLSHM.Size = new System.Drawing.Size(990, 467);
            this.xtrLSHM.Text = "Lịch sử hao mòn";
            // 
            // _TreeList
            // 
            this._TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.MA_TSCD,
            this.TEN_TSCD,
            this.HAO_MON_THANG,
            this.HE_SO,
            this.HAO_MON_NAM,
            this.HAO_MON_LK,
            this.GIA_TRI_CL,
            this.THANG,
            this.NAM,
            this.ID_CHA});
            this._TreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition9.Appearance.BackColor = System.Drawing.Color.LightGray;
            styleFormatCondition9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition9.Appearance.Options.UseBackColor = true;
            styleFormatCondition9.Appearance.Options.UseFont = true;
            styleFormatCondition9.ApplyToRow = true;
            styleFormatCondition9.Column = this.HE_SO;
            styleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition9.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition10.Appearance.Options.UseForeColor = true;
            styleFormatCondition10.ApplyToRow = true;
            styleFormatCondition10.Column = this.HAO_MON_THANG;
            styleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition10.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._TreeList.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition9,
            styleFormatCondition10});
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
            this._TreeList.Size = new System.Drawing.Size(990, 467);
            this._TreeList.StateImageList = this.imglImporter;
            this._TreeList.TabIndex = 1;
            // 
            // MA_TSCD
            // 
            this.MA_TSCD.Caption = "Mã TSCD";
            this.MA_TSCD.FieldName = "MA_TSCD";
            this.MA_TSCD.MinWidth = 35;
            this.MA_TSCD.Name = "MA_TSCD";
            this.MA_TSCD.OptionsColumn.ReadOnly = true;
            this.MA_TSCD.Visible = true;
            this.MA_TSCD.VisibleIndex = 0;
            this.MA_TSCD.Width = 141;
            // 
            // TEN_TSCD
            // 
            this.TEN_TSCD.Caption = "Tên TSCD";
            this.TEN_TSCD.FieldName = "TEN_TSCD";
            this.TEN_TSCD.Name = "TEN_TSCD";
            this.TEN_TSCD.OptionsColumn.ReadOnly = true;
            this.TEN_TSCD.Visible = true;
            this.TEN_TSCD.VisibleIndex = 1;
            this.TEN_TSCD.Width = 312;
            // 
            // HAO_MON_NAM
            // 
            this.HAO_MON_NAM.AppearanceCell.Options.UseTextOptions = true;
            this.HAO_MON_NAM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HAO_MON_NAM.Caption = "Hao mòn năm";
            this.HAO_MON_NAM.ColumnEdit = this.RepositoryItemTextEdit3;
            this.HAO_MON_NAM.FieldName = "HAO_MON_NAM";
            this.HAO_MON_NAM.Format.FormatString = "n0";
            this.HAO_MON_NAM.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HAO_MON_NAM.Name = "HAO_MON_NAM";
            this.HAO_MON_NAM.OptionsColumn.ReadOnly = true;
            this.HAO_MON_NAM.Visible = true;
            this.HAO_MON_NAM.VisibleIndex = 4;
            this.HAO_MON_NAM.Width = 151;
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
            // HAO_MON_LK
            // 
            this.HAO_MON_LK.Caption = "Hao mòn lũy kế";
            this.HAO_MON_LK.ColumnEdit = this.RepositoryItemTextEdit1;
            this.HAO_MON_LK.FieldName = "HAO_MON_LK";
            this.HAO_MON_LK.Format.FormatString = "n0";
            this.HAO_MON_LK.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HAO_MON_LK.Name = "HAO_MON_LK";
            this.HAO_MON_LK.OptionsColumn.ReadOnly = true;
            this.HAO_MON_LK.Visible = true;
            this.HAO_MON_LK.VisibleIndex = 5;
            this.HAO_MON_LK.Width = 143;
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
            // GIA_TRI_CL
            // 
            this.GIA_TRI_CL.Caption = "Giá trị còn lại";
            this.GIA_TRI_CL.ColumnEdit = this.RepositoryItemTextEdit4;
            this.GIA_TRI_CL.FieldName = "GIA_TRI_CL";
            this.GIA_TRI_CL.Format.FormatString = "n0";
            this.GIA_TRI_CL.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIA_TRI_CL.Name = "GIA_TRI_CL";
            this.GIA_TRI_CL.OptionsColumn.ReadOnly = true;
            this.GIA_TRI_CL.Visible = true;
            this.GIA_TRI_CL.VisibleIndex = 6;
            this.GIA_TRI_CL.Width = 124;
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
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.ReadOnly = true;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 7;
            this.THANG.Width = 82;
            // 
            // NAM
            // 
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.ReadOnly = true;
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 8;
            this.NAM.Width = 69;
            // 
            // imglImporter
            // 
            this.imglImporter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglImporter.ImageStream")));
            this.imglImporter.TransparentColor = System.Drawing.Color.Transparent;
            this.imglImporter.Images.SetKeyName(0, "EDITITEM.GIF");
            this.imglImporter.Images.SetKeyName(1, "Book-Edit-32.png");
            this.imglImporter.Images.SetKeyName(2, "BtnSave.png");
            // 
            // xtrDINH_KHOAN
            // 
            this.xtrDINH_KHOAN.Controls.Add(this.grcDINH_KHOAN);
            this.xtrDINH_KHOAN.Controls.Add(this.txtSO_TIEN);
            this.xtrDINH_KHOAN.Controls.Add(this.LabelControl3);
            this.xtrDINH_KHOAN.Name = "xtrDINH_KHOAN";
            this.xtrDINH_KHOAN.Size = new System.Drawing.Size(990, 467);
            this.xtrDINH_KHOAN.Text = "Định khoản         ";
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
            this.grcDINH_KHOAN.Size = new System.Drawing.Size(990, 467);
            this.grcDINH_KHOAN.TabIndex = 5010;
            this.grcDINH_KHOAN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDINH_KHOAN});
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
            this.rpeMA_TK_NO.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("rpeMA_TK_NO.ListEditValues")));
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
            this.rpeMA_TK_CO.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("rpeMA_TK_CO.ListEditValues")));
            this.rpeMA_TK_CO.Name = "rpeMA_TK_CO";
            this.rpeMA_TK_CO.NEXT_TAB = 0;
            this.rpeMA_TK_CO.OBJ_CONDITITION = null;
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
            // txtSO_TIEN
            // 
            this.txtSO_TIEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSO_TIEN.Location = new System.Drawing.Point(847, 441);
            this.txtSO_TIEN.Name = "txtSO_TIEN";
            this.txtSO_TIEN.Properties.ReadOnly = true;
            this.txtSO_TIEN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSO_TIEN.Size = new System.Drawing.Size(137, 20);
            this.txtSO_TIEN.TabIndex = 5012;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl3.Location = new System.Drawing.Point(783, 444);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(45, 13);
            this.LabelControl3.TabIndex = 5011;
            this.LabelControl3.Text = "Tổng tiền";
            // 
            // frmLichSuHaoMon_ThangNguonVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1009, 612);
            this.Controls.Add(this.PanelControl3);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.GroupControl3);
            this.KeyPreview = true;
            this.Name = "frmLichSuHaoMon_ThangNguonVon";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Tính khấu hao tháng";
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).EndInit();
            this.GroupControl3.ResumeLayout(false);
            this.GroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHienThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeXoaDL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            this.PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Control)).EndInit();
            this._Control.ResumeLayout(false);
            this.xtrLSHM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).EndInit();
            this.xtrDINH_KHOAN.ResumeLayout(false);
            this.xtrDINH_KHOAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDINH_KHOAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDINH_KHOAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeMA_TK_CO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMA_TK_CO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemResourcesComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_TIEN.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl3;
        internal DevExpress.XtraEditors.TextEdit txtNAM;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtTHANG;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        internal DevExpress.XtraEditors.SimpleButton btnKHThang;
        internal DevExpress.XtraEditors.CheckEdit ckeXoaDL;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnDINH_KHOAN;
        internal DevExpress.XtraEditors.SimpleButton btnXoa;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraTab.XtraTabControl _Control;
        internal DevExpress.XtraTab.XtraTabPage xtrLSHM;
        internal DevExpress.XtraTab.XtraTabPage xtrDINH_KHOAN;
        internal DevExpress.XtraEditors.TextEdit txtSO_TIEN;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraGrid.GridControl grcDINH_KHOAN;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvDINH_KHOAN;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_NO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_CO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        internal DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDM_NGUON_TSCD_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboLY_DO_TANGGIAM;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_TAISAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_CHIPHI;
        internal DevExpress.XtraTreeList.TreeList _TreeList;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn MA_TSCD;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn TEN_TSCD;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn HAO_MON_THANG;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn HAO_MON_NAM;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn HAO_MON_LK;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn GIA_TRI_CL;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn THANG;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn NAM;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn ID_CHA;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn HE_SO;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeMA_TK_NO;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeMA_TK_CO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit RepositoryItemPopupContainerEdit1;
        internal DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox RepositoryItemResourcesComboBox1;
        internal DevExpress.XtraEditors.CheckEdit ckeHienThi;
        internal System.Windows.Forms.ImageList imglImporter;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit5;
    }
}