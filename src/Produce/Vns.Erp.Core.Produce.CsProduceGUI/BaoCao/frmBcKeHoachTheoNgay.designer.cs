﻿namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    partial class frmBcKeHoachTheoNgay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pvNgayChungTu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvSoLuongNhap = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvSoLuongXuat = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiVatLieu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cboKeHoachSx = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gvKeHoach = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pvTenHangHoa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.cboPhanXuong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKeHoachSx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKeHoach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pvNgayChungTu
            // 
            this.pvNgayChungTu.Appearance.Cell.Options.UseTextOptions = true;
            this.pvNgayChungTu.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pvNgayChungTu.Appearance.Cell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pvNgayChungTu.Appearance.Header.Options.UseTextOptions = true;
            this.pvNgayChungTu.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pvNgayChungTu.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pvNgayChungTu.Appearance.Value.Options.UseTextOptions = true;
            this.pvNgayChungTu.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pvNgayChungTu.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pvNgayChungTu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pvNgayChungTu.AreaIndex = 0;
            this.pvNgayChungTu.Caption = "Ngày";
            this.pvNgayChungTu.CellFormat.FormatString = "d";
            this.pvNgayChungTu.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pvNgayChungTu.FieldName = "NgayChungTu";
            this.pvNgayChungTu.Name = "pvNgayChungTu";
            this.pvNgayChungTu.ValueFormat.FormatString = "d";
            this.pvNgayChungTu.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pvSoLuongNhap
            // 
            this.pvSoLuongNhap.Appearance.Header.Options.UseTextOptions = true;
            this.pvSoLuongNhap.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pvSoLuongNhap.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pvSoLuongNhap.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pvSoLuongNhap.AreaIndex = 0;
            this.pvSoLuongNhap.Caption = "Số lượng nhập";
            this.pvSoLuongNhap.CellFormat.FormatString = "n2";
            this.pvSoLuongNhap.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pvSoLuongNhap.FieldName = "SoLuongNhap";
            this.pvSoLuongNhap.Name = "pvSoLuongNhap";
            this.pvSoLuongNhap.ValueFormat.FormatString = "n2";
            this.pvSoLuongNhap.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pvSoLuongXuat
            // 
            this.pvSoLuongXuat.Appearance.Header.Options.UseTextOptions = true;
            this.pvSoLuongXuat.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pvSoLuongXuat.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pvSoLuongXuat.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pvSoLuongXuat.AreaIndex = 1;
            this.pvSoLuongXuat.Caption = "Số lượng xuất";
            this.pvSoLuongXuat.CellFormat.FormatString = "n2";
            this.pvSoLuongXuat.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pvSoLuongXuat.FieldName = "SoLuongXuat";
            this.pvSoLuongXuat.Name = "pvSoLuongXuat";
            this.pvSoLuongXuat.ValueFormat.FormatString = "n2";
            this.pvSoLuongXuat.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvKeHoach, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 406);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cboLoaiVatLieu);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.cboKeHoachSx);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dteDenNgay);
            this.groupControl1.Controls.Add(this.dteTuNgay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(686, 94);
            this.groupControl1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(263, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Loại nguyên liệu";
            // 
            // cboLoaiVatLieu
            // 
            this.cboLoaiVatLieu.EnterMoveNextControl = true;
            this.cboLoaiVatLieu.Location = new System.Drawing.Point(357, 31);
            this.cboLoaiVatLieu.Name = "cboLoaiVatLieu";
            this.cboLoaiVatLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiVatLieu.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Vật tư",
            "Nguyên vật liệu khác"});
            this.cboLoaiVatLieu.Size = new System.Drawing.Size(153, 20);
            this.cboLoaiVatLieu.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 20;
            this.btnSearch.Location = new System.Drawing.Point(94, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboKeHoachSx
            // 
            this.cboKeHoachSx.EnterMoveNextControl = true;
            this.cboKeHoachSx.Location = new System.Drawing.Point(94, 31);
            this.cboKeHoachSx.Name = "cboKeHoachSx";
            this.cboKeHoachSx.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboKeHoachSx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKeHoachSx.Properties.NullText = "";
            this.cboKeHoachSx.Properties.View = this.gridView1;
            this.cboKeHoachSx.Size = new System.Drawing.Size(153, 20);
            this.cboKeHoachSx.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày kế hoạch";
            this.gridColumn8.FieldName = "NgayKeHoach";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Số kế hoạch";
            this.gridColumn9.FieldName = "SoLenh";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã khách hàng";
            this.gridColumn10.FieldName = "MaKhachhang";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Mã sản phẩm";
            this.gridColumn11.FieldName = "MaSanpham";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(290, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Đến ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày";
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = null;
            this.dteDenNgay.EnterMoveNextControl = true;
            this.dteDenNgay.Location = new System.Drawing.Point(357, 5);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteDenNgay.Properties.MaxValue = new System.DateTime(2999, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDenNgay.Size = new System.Drawing.Size(153, 20);
            this.dteDenNgay.TabIndex = 1;
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.EnterMoveNextControl = true;
            this.dteTuNgay.Location = new System.Drawing.Point(94, 5);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteTuNgay.Properties.MaxValue = new System.DateTime(2999, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteTuNgay.Size = new System.Drawing.Size(153, 20);
            this.dteTuNgay.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kế hoạch ";
            // 
            // gvKeHoach
            // 
            this.gvKeHoach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvKeHoach.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pvSoLuongNhap,
            this.pvSoLuongXuat,
            this.pvNgayChungTu,
            this.pvTenHangHoa,
            this.pivotGridField1,
            this.pivotGridField2});
            pivotGridGroup1.Fields.Add(this.pvNgayChungTu);
            pivotGridGroup1.Hierarchy = null;
            this.gvKeHoach.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.gvKeHoach.Location = new System.Drawing.Point(3, 103);
            this.gvKeHoach.Name = "gvKeHoach";
            this.gvKeHoach.OptionsView.GroupFieldsInCustomizationWindow = false;
            this.gvKeHoach.OptionsView.ShowColumnGrandTotalHeader = false;
            this.gvKeHoach.OptionsView.ShowColumnGrandTotals = false;
            this.gvKeHoach.OptionsView.ShowColumnHeaders = false;
            this.gvKeHoach.OptionsView.ShowColumnTotals = false;
            this.gvKeHoach.OptionsView.ShowDataHeaders = false;
            this.gvKeHoach.OptionsView.ShowFilterHeaders = false;
            this.gvKeHoach.OptionsView.ShowRowGrandTotalHeader = false;
            this.gvKeHoach.OptionsView.ShowRowGrandTotals = false;
            this.gvKeHoach.OptionsView.ShowRowTotals = false;
            this.gvKeHoach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboPhanXuong});
            this.gvKeHoach.Size = new System.Drawing.Size(686, 300);
            this.gvKeHoach.TabIndex = 4;
            this.gvKeHoach.CustomCellDisplayText += new DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(this.gvKeHoach_CustomCellDisplayText);
            // 
            // pvTenHangHoa
            // 
            this.pvTenHangHoa.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pvTenHangHoa.AreaIndex = 2;
            this.pvTenHangHoa.Caption = "Vật tư, hàng hóa";
            this.pvTenHangHoa.FieldName = "TenHanghoa";
            this.pvTenHangHoa.Name = "pvTenHangHoa";
            this.pvTenHangHoa.Width = 190;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Lệnh sản xuất";
            this.pivotGridField1.FieldName = "LenhSanXuat_QuyTrinh";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.ShowGrandTotal = false;
            this.pivotGridField1.Options.ShowTotals = false;
            this.pivotGridField1.Width = 150;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Tổ sản xuất";
            this.pivotGridField2.FieldName = "MaPhanXuong";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Options.AllowEdit = false;
            this.pivotGridField2.Options.ReadOnly = true;
            this.pivotGridField2.Options.ShowGrandTotal = false;
            this.pivotGridField2.Options.ShowTotals = false;
            // 
            // cboPhanXuong
            // 
            this.cboPhanXuong.AutoHeight = false;
            this.cboPhanXuong.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboPhanXuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhanXuong.DisplayMember = "TenPhongban";
            this.cboPhanXuong.Name = "cboPhanXuong";
            this.cboPhanXuong.NullText = "";
            this.cboPhanXuong.ValueMember = "Id";
            // 
            // frmBcKeHoachTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBcKeHoachTheoNgay";
            this.Text = "Báo cáo tiến độ sản xuất";
            this.Load += new System.EventHandler(this.frmBcSanXuatTheoNgay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKeHoachSx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKeHoach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiVatLieu;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GridLookUpEdit cboKeHoachSx;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteDenNgay;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl gvKeHoach;
        private DevExpress.XtraPivotGrid.PivotGridField pvSoLuongNhap;
        private DevExpress.XtraPivotGrid.PivotGridField pvSoLuongXuat;
        private DevExpress.XtraPivotGrid.PivotGridField pvNgayChungTu;
        private DevExpress.XtraPivotGrid.PivotGridField pvTenHangHoa;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPhanXuong;
    }
}