using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
partial class frmPhieuNhapKho_DanhSach : DevExpress.XtraEditors.XtraForm
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null) {
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
        this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
        this.btnClo = new DevExpress.XtraEditors.SimpleButton();
        this.btnMod = new DevExpress.XtraEditors.SimpleButton();
        this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
        this.btnDel = new DevExpress.XtraEditors.SimpleButton();
        this.grvLPN_Dnx = new DevExpress.XtraGrid.Views.Grid.GridView();
        this.KHO_NHAP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
        this.cboKhoNhap1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        this.KHO_XUAT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
        this.cboKhoXuat1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        this.KY_HIEU_HANGHOA = new DevExpress.XtraGrid.Columns.GridColumn();
        this.TEN_HANGHOA = new DevExpress.XtraGrid.Columns.GridColumn();
        this.TEN_DVT = new DevExpress.XtraGrid.Columns.GridColumn();
        this.SO_LUONG = new DevExpress.XtraGrid.Columns.GridColumn();
        this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
        this.GIA_VON = new DevExpress.XtraGrid.Columns.GridColumn();
        this.grcLPN_Dnx = new DevExpress.XtraGrid.GridControl();
        this.cboKhoNhap = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        this.cboKhoXuat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
        this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
        this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
        this.grcLPN_Hnx = new DevExpress.XtraGrid.GridControl();
        this.grvLPX_Hnx = new DevExpress.XtraGrid.Views.Grid.GridView();
        this.GHI = new DevExpress.XtraGrid.Columns.GridColumn();
        this.CT_SO = new DevExpress.XtraGrid.Columns.GridColumn();
        this.NGAY_CT = new DevExpress.XtraGrid.Columns.GridColumn();
        this.NGAY_GHI = new DevExpress.XtraGrid.Columns.GridColumn();
        this.TEN_KHANG = new DevExpress.XtraGrid.Columns.GridColumn();
        this.KY_HIEU_KHANG = new DevExpress.XtraGrid.Columns.GridColumn();
        this.MST_KHANG = new DevExpress.XtraGrid.Columns.GridColumn();
        this.DIEN_GIAI = new DevExpress.XtraGrid.Columns.GridColumn();
        this.NGUOI_GIAO_NHAN_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
        this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
        this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
        this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
        ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
        this.PanelControl2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.grvLPN_Dnx)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Dnx)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
        this.groupControl2.SuspendLayout();
        this.SplitContainer1.Panel1.SuspendLayout();
        this.SplitContainer1.Panel2.SuspendLayout();
        this.SplitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
        this.GroupControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).BeginInit();
        this.SuspendLayout();
        // 
        // PanelControl2
        // 
        this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        this.PanelControl2.Controls.Add(this.btnClo);
        this.PanelControl2.Controls.Add(this.btnMod);
        this.PanelControl2.Controls.Add(this.btnAdd);
        this.PanelControl2.Controls.Add(this.btnDel);
        this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.PanelControl2.Location = new System.Drawing.Point(4, 574);
        this.PanelControl2.Name = "PanelControl2";
        this.PanelControl2.Size = new System.Drawing.Size(1000, 34);
        this.PanelControl2.TabIndex = 24;
        // 
        // btnClo
        // 
        this.btnClo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClo.ImageIndex = 1;
        this.btnClo.Location = new System.Drawing.Point(919, 3);
        this.btnClo.Name = "btnClo";
        this.btnClo.Size = new System.Drawing.Size(80, 30);
        this.btnClo.TabIndex = 6;
        this.btnClo.Text = "&Đóng";
        this.btnClo.Click += new System.EventHandler(this.btnClo_Click);
        // 
        // btnMod
        // 
        this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnMod.ImageIndex = 4;
        this.btnMod.Location = new System.Drawing.Point(87, 3);
        this.btnMod.Name = "btnMod";
        this.btnMod.Size = new System.Drawing.Size(80, 30);
        this.btnMod.TabIndex = 4;
        this.btnMod.Text = "&Sửa";
        this.btnMod.Click += new System.EventHandler(this.btnModify_Click);
        // 
        // btnAdd
        // 
        this.btnAdd.ImageIndex = 2;
        this.btnAdd.Location = new System.Drawing.Point(1, 3);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(80, 30);
        this.btnAdd.TabIndex = 3;
        this.btnAdd.Text = "&Mới";
        this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
        // 
        // btnDel
        // 
        this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnDel.ImageIndex = 3;
        this.btnDel.Location = new System.Drawing.Point(173, 3);
        this.btnDel.Name = "btnDel";
        this.btnDel.Size = new System.Drawing.Size(80, 30);
        this.btnDel.TabIndex = 5;
        this.btnDel.Text = "Xóa";
        this.btnDel.Visible = false;
        // 
        // grvLPN_Dnx
        // 
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.Empty.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
        this.grvLPN_Dnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
        this.grvLPN_Dnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.EvenRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.EvenRow.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.EvenRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.FilterPanel.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FilterPanel.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPN_Dnx.Appearance.FixedLine.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.FocusedCell.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FocusedCell.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
        this.grvLPN_Dnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.FocusedRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FocusedRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPN_Dnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.FooterPanel.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.FooterPanel.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.FooterPanel.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
        this.grvLPN_Dnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
        this.grvLPN_Dnx.Appearance.GroupButton.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.GroupButton.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPN_Dnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPN_Dnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.GroupFooter.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.GroupFooter.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.GroupFooter.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.GroupPanel.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.GroupPanel.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPN_Dnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPN_Dnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.GroupRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.GroupRow.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.GroupRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPN_Dnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPN_Dnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
        this.grvLPN_Dnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
        this.grvLPN_Dnx.Appearance.HideSelectionRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.HideSelectionRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
        this.grvLPN_Dnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPN_Dnx.Appearance.HorzLine.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.HorzLine.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.OddRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.OddRow.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Appearance.OddRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
        this.grvLPN_Dnx.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
        this.grvLPN_Dnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
        this.grvLPN_Dnx.Appearance.Preview.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.Preview.Options.UseFont = true;
        this.grvLPN_Dnx.Appearance.Preview.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.Row.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.Row.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.Row.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPN_Dnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.RowSeparator.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
        this.grvLPN_Dnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPN_Dnx.Appearance.SelectedRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.SelectedRow.Options.UseForeColor = true;
        this.grvLPN_Dnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
        this.grvLPN_Dnx.Appearance.TopNewRow.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
        this.grvLPN_Dnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPN_Dnx.Appearance.VertLine.Options.UseBackColor = true;
        this.grvLPN_Dnx.Appearance.VertLine.Options.UseBorderColor = true;
        this.grvLPN_Dnx.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KHO_NHAP_ID,
            this.KHO_XUAT_ID,
            this.KY_HIEU_HANGHOA,
            this.TEN_HANGHOA,
            this.TEN_DVT,
            this.SO_LUONG,
            this.GridColumn1,
            this.GIA_VON,
            this.gridColumn4});
        this.grvLPN_Dnx.GridControl = this.grcLPN_Dnx;
        this.grvLPN_Dnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
        this.grvLPN_Dnx.Name = "grvLPN_Dnx";
        this.grvLPN_Dnx.OptionsBehavior.Editable = false;
        this.grvLPN_Dnx.OptionsView.ColumnAutoWidth = false;
        this.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = true;
        this.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = true;
        this.grvLPN_Dnx.OptionsView.ShowGroupPanel = false;
        this.grvLPN_Dnx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvLPN_Dnx_KeyDown);
        // 
        // KHO_NHAP_ID
        // 
        this.KHO_NHAP_ID.AppearanceHeader.Options.UseTextOptions = true;
        this.KHO_NHAP_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.KHO_NHAP_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.KHO_NHAP_ID.Caption = "Mã kho nhập";
        this.KHO_NHAP_ID.ColumnEdit = this.cboKhoNhap1;
        this.KHO_NHAP_ID.FieldName = "KhoNhapId";
        this.KHO_NHAP_ID.Name = "KHO_NHAP_ID";
        this.KHO_NHAP_ID.OptionsColumn.ReadOnly = true;
        this.KHO_NHAP_ID.Visible = true;
        this.KHO_NHAP_ID.VisibleIndex = 0;
        this.KHO_NHAP_ID.Width = 101;
        // 
        // cboKhoNhap1
        // 
        this.cboKhoNhap1.AutoHeight = false;
        this.cboKhoNhap1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        this.cboKhoNhap1.Name = "cboKhoNhap1";
        this.cboKhoNhap1.NullText = "";
        // 
        // KHO_XUAT_ID
        // 
        this.KHO_XUAT_ID.AppearanceHeader.Options.UseTextOptions = true;
        this.KHO_XUAT_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.KHO_XUAT_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.KHO_XUAT_ID.Caption = "Mã kho xuất";
        this.KHO_XUAT_ID.ColumnEdit = this.cboKhoXuat1;
        this.KHO_XUAT_ID.FieldName = "KhoXuatId";
        this.KHO_XUAT_ID.Name = "KHO_XUAT_ID";
        this.KHO_XUAT_ID.OptionsColumn.ReadOnly = true;
        this.KHO_XUAT_ID.Visible = true;
        this.KHO_XUAT_ID.VisibleIndex = 1;
        this.KHO_XUAT_ID.Width = 97;
        // 
        // cboKhoXuat1
        // 
        this.cboKhoXuat1.AutoHeight = false;
        this.cboKhoXuat1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        this.cboKhoXuat1.Name = "cboKhoXuat1";
        this.cboKhoXuat1.NullText = "";
        // 
        // KY_HIEU_HANGHOA
        // 
        this.KY_HIEU_HANGHOA.AppearanceHeader.Options.UseTextOptions = true;
        this.KY_HIEU_HANGHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.KY_HIEU_HANGHOA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.KY_HIEU_HANGHOA.Caption = "Mã hàng";
        this.KY_HIEU_HANGHOA.FieldName = "KyHieuHanghoa";
        this.KY_HIEU_HANGHOA.Name = "KY_HIEU_HANGHOA";
        this.KY_HIEU_HANGHOA.Visible = true;
        this.KY_HIEU_HANGHOA.VisibleIndex = 2;
        this.KY_HIEU_HANGHOA.Width = 134;
        // 
        // TEN_HANGHOA
        // 
        this.TEN_HANGHOA.AppearanceHeader.Options.UseTextOptions = true;
        this.TEN_HANGHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.TEN_HANGHOA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.TEN_HANGHOA.Caption = "Tên hàng / Vật tư";
        this.TEN_HANGHOA.FieldName = "TenHanghoa";
        this.TEN_HANGHOA.Name = "TEN_HANGHOA";
        this.TEN_HANGHOA.Visible = true;
        this.TEN_HANGHOA.VisibleIndex = 3;
        this.TEN_HANGHOA.Width = 375;
        // 
        // TEN_DVT
        // 
        this.TEN_DVT.AppearanceHeader.Options.UseTextOptions = true;
        this.TEN_DVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.TEN_DVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.TEN_DVT.Caption = "ĐVT";
        this.TEN_DVT.FieldName = "TenDvt";
        this.TEN_DVT.Name = "TEN_DVT";
        this.TEN_DVT.Visible = true;
        this.TEN_DVT.VisibleIndex = 4;
        // 
        // SO_LUONG
        // 
        this.SO_LUONG.AppearanceHeader.Options.UseTextOptions = true;
        this.SO_LUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.SO_LUONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.SO_LUONG.Caption = "Số lượng";
        this.SO_LUONG.DisplayFormat.FormatString = "n2";
        this.SO_LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        this.SO_LUONG.FieldName = "SoLuong";
        this.SO_LUONG.Name = "SO_LUONG";
        this.SO_LUONG.Visible = true;
        this.SO_LUONG.VisibleIndex = 5;
        this.SO_LUONG.Width = 100;
        // 
        // GridColumn1
        // 
        this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
        this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.GridColumn1.Caption = "Đơn giá";
        this.GridColumn1.DisplayFormat.FormatString = "n2";
        this.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        this.GridColumn1.FieldName = "DonGiaVon";
        this.GridColumn1.Name = "GridColumn1";
        // 
        // GIA_VON
        // 
        this.GIA_VON.AppearanceHeader.Options.UseTextOptions = true;
        this.GIA_VON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.GIA_VON.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.GIA_VON.Caption = "Tổng tiền";
        this.GIA_VON.DisplayFormat.FormatString = "n0";
        this.GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        this.GIA_VON.FieldName = "GiaVon";
        this.GIA_VON.Name = "GIA_VON";
        this.GIA_VON.Width = 150;
        // 
        // grcLPN_Dnx
        // 
        this.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grcLPN_Dnx.Location = new System.Drawing.Point(2, 22);
        this.grcLPN_Dnx.MainView = this.grvLPN_Dnx;
        this.grcLPN_Dnx.Name = "grcLPN_Dnx";
        this.grcLPN_Dnx.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboKhoNhap,
            this.cboKhoXuat,
            this.cboKhoNhap1,
            this.cboKhoXuat1});
        this.grcLPN_Dnx.Size = new System.Drawing.Size(996, 263);
        this.grcLPN_Dnx.TabIndex = 1;
        this.grcLPN_Dnx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLPN_Dnx});
        // 
        // cboKhoNhap
        // 
        this.cboKhoNhap.AutoHeight = false;
        this.cboKhoNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        this.cboKhoNhap.Name = "cboKhoNhap";
        this.cboKhoNhap.NullText = "";
        // 
        // cboKhoXuat
        // 
        this.cboKhoXuat.AutoHeight = false;
        this.cboKhoXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        this.cboKhoXuat.Name = "cboKhoXuat";
        this.cboKhoXuat.NullText = "";
        // 
        // groupControl2
        // 
        this.groupControl2.Controls.Add(this.grcLPN_Dnx);
        this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupControl2.Location = new System.Drawing.Point(0, 0);
        this.groupControl2.Name = "groupControl2";
        this.groupControl2.Size = new System.Drawing.Size(1000, 287);
        this.groupControl2.TabIndex = 23;
        this.groupControl2.Text = "Danh sách...";
        // 
        // SplitContainer1
        // 
        this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.SplitContainer1.Location = new System.Drawing.Point(4, 4);
        this.SplitContainer1.Name = "SplitContainer1";
        this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        // 
        // SplitContainer1.Panel1
        // 
        this.SplitContainer1.Panel1.Controls.Add(this.GroupControl1);
        // 
        // SplitContainer1.Panel2
        // 
        this.SplitContainer1.Panel2.Controls.Add(this.groupControl2);
        this.SplitContainer1.Size = new System.Drawing.Size(1000, 570);
        this.SplitContainer1.SplitterDistance = 279;
        this.SplitContainer1.TabIndex = 25;
        // 
        // GroupControl1
        // 
        this.GroupControl1.Controls.Add(this.grcLPN_Hnx);
        this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.GroupControl1.Location = new System.Drawing.Point(0, 0);
        this.GroupControl1.Name = "GroupControl1";
        this.GroupControl1.Size = new System.Drawing.Size(1000, 279);
        this.GroupControl1.TabIndex = 24;
        this.GroupControl1.Text = "Danh sách...";
        // 
        // grcLPN_Hnx
        // 
        this.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grcLPN_Hnx.Location = new System.Drawing.Point(2, 22);
        this.grcLPN_Hnx.MainView = this.grvLPX_Hnx;
        this.grcLPN_Hnx.Name = "grcLPN_Hnx";
        this.grcLPN_Hnx.Size = new System.Drawing.Size(996, 255);
        this.grcLPN_Hnx.TabIndex = 2;
        this.grcLPN_Hnx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLPX_Hnx});
        // 
        // grvLPX_Hnx
        // 
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.Empty.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
        this.grvLPX_Hnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
        this.grvLPX_Hnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.EvenRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.EvenRow.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.EvenRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.FilterPanel.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FilterPanel.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPX_Hnx.Appearance.FixedLine.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.FocusedCell.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FocusedCell.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
        this.grvLPX_Hnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.FocusedRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FocusedRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
        this.grvLPX_Hnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
        this.grvLPX_Hnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
        this.grvLPX_Hnx.Appearance.GroupButton.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.GroupButton.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPX_Hnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPX_Hnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.GroupPanel.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.GroupPanel.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPX_Hnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
        this.grvLPX_Hnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.GroupRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.GroupRow.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.GroupRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPX_Hnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
        this.grvLPX_Hnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
        this.grvLPX_Hnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
        this.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
        this.grvLPX_Hnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPX_Hnx.Appearance.HorzLine.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.HorzLine.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.OddRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.OddRow.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Appearance.OddRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
        this.grvLPX_Hnx.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
        this.grvLPX_Hnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
        this.grvLPX_Hnx.Appearance.Preview.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.Preview.Options.UseFont = true;
        this.grvLPX_Hnx.Appearance.Preview.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.Row.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.Row.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.Row.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
        this.grvLPX_Hnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.RowSeparator.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
        this.grvLPX_Hnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
        this.grvLPX_Hnx.Appearance.SelectedRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.SelectedRow.Options.UseForeColor = true;
        this.grvLPX_Hnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
        this.grvLPX_Hnx.Appearance.TopNewRow.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
        this.grvLPX_Hnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
        this.grvLPX_Hnx.Appearance.VertLine.Options.UseBackColor = true;
        this.grvLPX_Hnx.Appearance.VertLine.Options.UseBorderColor = true;
        this.grvLPX_Hnx.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GHI,
            this.CT_SO,
            this.NGAY_CT,
            this.NGAY_GHI,
            this.TEN_KHANG,
            this.KY_HIEU_KHANG,
            this.MST_KHANG,
            this.DIEN_GIAI,
            this.NGUOI_GIAO_NHAN_HANG,
            this.gridColumn2,
            this.gridColumn3});
        this.grvLPX_Hnx.GridControl = this.grcLPN_Hnx;
        this.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
        this.grvLPX_Hnx.Name = "grvLPX_Hnx";
        this.grvLPX_Hnx.OptionsBehavior.Editable = false;
        this.grvLPX_Hnx.OptionsView.ColumnAutoWidth = false;
        this.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = true;
        this.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = true;
        this.grvLPX_Hnx.OptionsView.ShowGroupPanel = false;
        this.grvLPX_Hnx.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvLPX_Hnx_FocusedRowChanged);
        this.grvLPX_Hnx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvLPX_Hnx_KeyDown);
        // 
        // GHI
        // 
        this.GHI.AppearanceHeader.Options.UseTextOptions = true;
        this.GHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.GHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.GHI.Caption = "Trạng thái";
        this.GHI.FieldName = "Ghi";
        this.GHI.Name = "GHI";
        this.GHI.Visible = true;
        this.GHI.VisibleIndex = 0;
        // 
        // CT_SO
        // 
        this.CT_SO.AppearanceHeader.Options.UseTextOptions = true;
        this.CT_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.CT_SO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.CT_SO.Caption = "Số chứng từ";
        this.CT_SO.FieldName = "CtSo";
        this.CT_SO.Name = "CT_SO";
        this.CT_SO.Visible = true;
        this.CT_SO.VisibleIndex = 1;
        this.CT_SO.Width = 80;
        // 
        // NGAY_CT
        // 
        this.NGAY_CT.AppearanceHeader.Options.UseTextOptions = true;
        this.NGAY_CT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.NGAY_CT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.NGAY_CT.Caption = "Ngày chứng từ";
        this.NGAY_CT.DisplayFormat.FormatString = "dd/MM/yyyy";
        this.NGAY_CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        this.NGAY_CT.FieldName = "NgayCt";
        this.NGAY_CT.Name = "NGAY_CT";
        this.NGAY_CT.Visible = true;
        this.NGAY_CT.VisibleIndex = 2;
        this.NGAY_CT.Width = 100;
        // 
        // NGAY_GHI
        // 
        this.NGAY_GHI.AppearanceHeader.Options.UseTextOptions = true;
        this.NGAY_GHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.NGAY_GHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.NGAY_GHI.Caption = "Ngày hạch toán";
        this.NGAY_GHI.DisplayFormat.FormatString = "dd/MM/yyyy";
        this.NGAY_GHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        this.NGAY_GHI.FieldName = "NgayGhi";
        this.NGAY_GHI.Name = "NGAY_GHI";
        this.NGAY_GHI.Visible = true;
        this.NGAY_GHI.VisibleIndex = 3;
        this.NGAY_GHI.Width = 112;
        // 
        // TEN_KHANG
        // 
        this.TEN_KHANG.AppearanceHeader.Options.UseTextOptions = true;
        this.TEN_KHANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.TEN_KHANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.TEN_KHANG.Caption = "Tên khách hàng";
        this.TEN_KHANG.FieldName = "TenKhang";
        this.TEN_KHANG.Name = "TEN_KHANG";
        this.TEN_KHANG.Width = 220;
        // 
        // KY_HIEU_KHANG
        // 
        this.KY_HIEU_KHANG.AppearanceHeader.Options.UseTextOptions = true;
        this.KY_HIEU_KHANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.KY_HIEU_KHANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.KY_HIEU_KHANG.Caption = "Mã khách ";
        this.KY_HIEU_KHANG.FieldName = "KyHieuKhang";
        this.KY_HIEU_KHANG.Name = "KY_HIEU_KHANG";
        this.KY_HIEU_KHANG.Width = 100;
        // 
        // MST_KHANG
        // 
        this.MST_KHANG.AppearanceHeader.Options.UseTextOptions = true;
        this.MST_KHANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.MST_KHANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.MST_KHANG.Caption = "Mã số thuế";
        this.MST_KHANG.FieldName = "MstKhang";
        this.MST_KHANG.Name = "MST_KHANG";
        this.MST_KHANG.Width = 100;
        // 
        // DIEN_GIAI
        // 
        this.DIEN_GIAI.AppearanceHeader.Options.UseTextOptions = true;
        this.DIEN_GIAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.DIEN_GIAI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.DIEN_GIAI.Caption = "Diễn giải";
        this.DIEN_GIAI.FieldName = "DienGiai";
        this.DIEN_GIAI.Name = "DIEN_GIAI";
        this.DIEN_GIAI.Visible = true;
        this.DIEN_GIAI.VisibleIndex = 4;
        this.DIEN_GIAI.Width = 318;
        // 
        // NGUOI_GIAO_NHAN_HANG
        // 
        this.NGUOI_GIAO_NHAN_HANG.AppearanceHeader.Options.UseTextOptions = true;
        this.NGUOI_GIAO_NHAN_HANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.NGUOI_GIAO_NHAN_HANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.NGUOI_GIAO_NHAN_HANG.Caption = "Người giao hàng";
        this.NGUOI_GIAO_NHAN_HANG.FieldName = "NguoiGiaoNhanHang";
        this.NGUOI_GIAO_NHAN_HANG.Name = "NGUOI_GIAO_NHAN_HANG";
        this.NGUOI_GIAO_NHAN_HANG.Visible = true;
        this.NGUOI_GIAO_NHAN_HANG.VisibleIndex = 5;
        this.NGUOI_GIAO_NHAN_HANG.Width = 130;
        // 
        // gridColumn2
        // 
        this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
        this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.gridColumn2.Caption = "Lệnh sản xuất";
        this.gridColumn2.FieldName = "LenhSanXuatLq";
        this.gridColumn2.Name = "gridColumn2";
        this.gridColumn2.Visible = true;
        this.gridColumn2.VisibleIndex = 6;
        this.gridColumn2.Width = 106;
        // 
        // gridColumn3
        // 
        this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
        this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.gridColumn3.Caption = "Phân xưởng";
        this.gridColumn3.FieldName = "PhanXuongLq";
        this.gridColumn3.Name = "gridColumn3";
        this.gridColumn3.Visible = true;
        this.gridColumn3.VisibleIndex = 7;
        // 
        // gridColumn4
        // 
        this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
        this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        this.gridColumn4.Caption = "Nội dung";
        this.gridColumn4.FieldName = "NoiDung";
        this.gridColumn4.Name = "gridColumn4";
        this.gridColumn4.Visible = true;
        this.gridColumn4.VisibleIndex = 6;
        this.gridColumn4.Width = 260;
        // 
        // frmPhieuNhapKho_DanhSach
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1008, 612);
        this.Controls.Add(this.SplitContainer1);
        this.Controls.Add(this.PanelControl2);
        this.KeyPreview = true;
        this.Name = "frmPhieuNhapKho_DanhSach";
        this.Padding = new System.Windows.Forms.Padding(4);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Loại phiếu nhập kho";
        this.Load += new System.EventHandler(this.frmPhieuNhapKho_DanhSach_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuNhapKho_DanhSach_KeyDown);
        ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
        this.PanelControl2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.grvLPN_Dnx)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Dnx)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
        this.groupControl2.ResumeLayout(false);
        this.SplitContainer1.Panel1.ResumeLayout(false);
        this.SplitContainer1.Panel2.ResumeLayout(false);
        this.SplitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
        this.GroupControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).EndInit();
        this.ResumeLayout(false);

	}
	internal DevExpress.XtraEditors.PanelControl PanelControl2;
	internal DevExpress.XtraGrid.Views.Grid.GridView grvLPN_Dnx;
	internal DevExpress.XtraGrid.GridControl grcLPN_Dnx;
	internal DevExpress.XtraEditors.GroupControl groupControl2;
	internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU_HANGHOA;
	internal DevExpress.XtraGrid.Columns.GridColumn SO_LUONG;
	internal System.Windows.Forms.SplitContainer SplitContainer1;
	internal DevExpress.XtraEditors.SimpleButton btnMod;
	internal DevExpress.XtraEditors.SimpleButton btnAdd;
	internal DevExpress.XtraEditors.SimpleButton btnDel;
	internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON;
	internal DevExpress.XtraEditors.SimpleButton btnClo;
	internal DevExpress.XtraGrid.Columns.GridColumn TEN_HANGHOA;
	internal DevExpress.XtraGrid.Columns.GridColumn TEN_DVT;
	internal DevExpress.XtraGrid.Columns.GridColumn KHO_NHAP_ID;
	internal DevExpress.XtraGrid.Columns.GridColumn KHO_XUAT_ID;
	internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboKhoNhap;
	internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboKhoXuat;
	internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboKhoNhap1;
	internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboKhoXuat1;
    internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
	internal DevExpress.XtraEditors.GroupControl GroupControl1;
	internal DevExpress.XtraGrid.GridControl grcLPN_Hnx;
	internal DevExpress.XtraGrid.Views.Grid.GridView grvLPX_Hnx;
	internal DevExpress.XtraGrid.Columns.GridColumn GHI;
	internal DevExpress.XtraGrid.Columns.GridColumn CT_SO;
	internal DevExpress.XtraGrid.Columns.GridColumn NGAY_CT;
	internal DevExpress.XtraGrid.Columns.GridColumn TEN_KHANG;
	internal DevExpress.XtraGrid.Columns.GridColumn NGAY_GHI;
	internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU_KHANG;
	internal DevExpress.XtraGrid.Columns.GridColumn MST_KHANG;
	internal DevExpress.XtraGrid.Columns.GridColumn DIEN_GIAI;
	internal DevExpress.XtraGrid.Columns.GridColumn NGUOI_GIAO_NHAN_HANG;

    
	public frmPhieuNhapKho_DanhSach()
	{
		InitializeComponent();
	}

    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
}
}