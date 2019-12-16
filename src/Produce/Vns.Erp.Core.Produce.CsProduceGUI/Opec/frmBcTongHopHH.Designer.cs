namespace Vns.Erp.Core.Produce.CsProduceGUI.Opec
{
    partial class frmBcTongHopHH
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
            this.grcReport = new DevExpress.XtraGrid.GridControl();
            this.grvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboTaiKhoan = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboApplication = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboHanghoa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaVC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtextN0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDiaLy = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddnew = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuBangGia = new DevExpress.XtraEditors.SimpleButton();
            this.txtNgayBangGia = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnTongHop = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvBangGiaH = new DevExpress.XtraGrid.GridControl();
            this.grvLPX_Hnx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.grcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtextN0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBangGia.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBangGia.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBangGiaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcReport
            // 
            this.grcReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcReport.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcReport.Location = new System.Drawing.Point(0, 80);
            this.grcReport.MainView = this.grvReport;
            this.grcReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcReport.Name = "grcReport";
            this.grcReport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboHanghoa,
            this.cboType,
            this.cboApplication,
            this.repositoryItemTextEdit1,
            this.rtextN0,
            this.cboTaiKhoan,
            this.cboDiaLy});
            this.grcReport.Size = new System.Drawing.Size(962, 663);
            this.grcReport.TabIndex = 0;
            this.grcReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReport});
            // 
            // grvReport
            // 
            this.grvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn15,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.MaVC,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn12,
            this.gridColumn14});
            this.grvReport.GridControl = this.grcReport;
            this.grvReport.GroupCount = 2;
            this.grvReport.Name = "grvReport";
            this.grvReport.OptionsBehavior.AutoExpandAllGroups = true;
            this.grvReport.OptionsView.ShowAutoFilterRow = true;
            this.grvReport.OptionsView.ShowGroupPanel = false;
            this.grvReport.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn13, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn15, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grvReport.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grvReport_RowStyle);
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.Caption = "Tình trạng";
            this.gridColumn13.ColumnEdit = this.cboTaiKhoan;
            this.gridColumn13.FieldName = "MaNghiepVu";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 114;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.AutoHeight = false;
            this.cboTaiKhoan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTaiKhoan.DisplayMember = "MoTa";
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.ValidateOnEnterKey = true;
            this.cboTaiKhoan.ValueMember = "MaTaikhoan";
            this.cboTaiKhoan.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Khu vực";
            this.gridColumn15.FieldName = "KhuVuc";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            this.gridColumn15.Width = 80;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Nhóm";
            this.gridColumn1.ColumnEdit = this.cboType;
            this.gridColumn1.FieldName = "TypeId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 79;
            // 
            // cboType
            // 
            this.cboType.AutoHeight = false;
            this.cboType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.DisplayMember = "TenNhomVt1";
            this.cboType.Name = "cboType";
            this.cboType.NullText = "";
            this.cboType.ValueMember = "Id";
            this.cboType.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Ứng dụng";
            this.gridColumn2.ColumnEdit = this.cboApplication;
            this.gridColumn2.FieldName = "ApplicationId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 123;
            // 
            // cboApplication
            // 
            this.cboApplication.AutoHeight = false;
            this.cboApplication.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboApplication.DisplayMember = "TenNhomVt1";
            this.cboApplication.Name = "cboApplication";
            this.cboApplication.ValueMember = "Id";
            this.cboApplication.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "Tên hàng";
            this.gridColumn3.ColumnEdit = this.cboHanghoa;
            this.gridColumn3.FieldName = "HanghoaId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 360;
            // 
            // cboHanghoa
            // 
            this.cboHanghoa.AutoHeight = false;
            this.cboHanghoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHanghoa.DisplayMember = "TenHanghoa";
            this.cboHanghoa.Name = "cboHanghoa";
            this.cboHanghoa.ValueMember = "Id";
            // 
            // MaVC
            // 
            this.MaVC.Caption = "Code";
            this.MaVC.FieldName = "MaVanChuyen";
            this.MaVC.Name = "MaVC";
            this.MaVC.OptionsColumn.AllowEdit = false;
            this.MaVC.Visible = true;
            this.MaVC.VisibleIndex = 0;
            this.MaVC.Width = 243;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "SoLuongTon";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 128;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Giá bán VNĐ";
            this.gridColumn5.ColumnEdit = this.rtextN0;
            this.gridColumn5.DisplayFormat.FormatString = "n0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "DonGia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 131;
            // 
            // rtextN0
            // 
            this.rtextN0.AutoHeight = false;
            this.rtextN0.Mask.EditMask = "n0";
            this.rtextN0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.rtextN0.Name = "rtextN0";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.Caption = "Giá bán USD";
            this.gridColumn7.ColumnEdit = this.rtextN0;
            this.gridColumn7.DisplayFormat.FormatString = "n2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "DonGiaUsd";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 124;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn12.Caption = "Thông tin khác";
            this.gridColumn12.DisplayFormat.FormatString = "n2";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            this.gridColumn12.Width = 247;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn14.Caption = "Ghi chú";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            this.gridColumn14.Width = 299;
            // 
            // cboDiaLy
            // 
            this.cboDiaLy.AutoHeight = false;
            this.cboDiaLy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDiaLy.DisplayMember = "TenDanhmuc";
            this.cboDiaLy.Name = "cboDiaLy";
            this.cboDiaLy.ValueMember = "GiaTri";
            this.cboDiaLy.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAddnew);
            this.groupControl1.Controls.Add(this.btnLuuBangGia);
            this.groupControl1.Controls.Add(this.txtNgayBangGia);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnTongHop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(962, 80);
            this.groupControl1.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 20;
            this.btnEdit.Location = new System.Drawing.Point(254, 36);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 25);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.ImageIndex = 20;
            this.btnAddnew.Location = new System.Drawing.Point(155, 36);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(93, 25);
            this.btnAddnew.TabIndex = 26;
            this.btnAddnew.Text = "Thêm";
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnLuuBangGia
            // 
            this.btnLuuBangGia.ImageIndex = 20;
            this.btnLuuBangGia.Location = new System.Drawing.Point(353, 36);
            this.btnLuuBangGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuBangGia.Name = "btnLuuBangGia";
            this.btnLuuBangGia.Size = new System.Drawing.Size(93, 25);
            this.btnLuuBangGia.TabIndex = 25;
            this.btnLuuBangGia.Text = "Lưu";
            this.btnLuuBangGia.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtNgayBangGia
            // 
            this.txtNgayBangGia.EditValue = null;
            this.txtNgayBangGia.EnterMoveNextControl = true;
            this.txtNgayBangGia.Location = new System.Drawing.Point(155, 6);
            this.txtNgayBangGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayBangGia.Name = "txtNgayBangGia";
            this.txtNgayBangGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBangGia.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgayBangGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBangGia.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtNgayBangGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtNgayBangGia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNgayBangGia.Properties.MaxValue = new System.DateTime(2088, 1, 5, 0, 0, 0, 0);
            this.txtNgayBangGia.Properties.MinValue = new System.DateTime(1988, 1, 5, 0, 0, 0, 0);
            this.txtNgayBangGia.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgayBangGia.Size = new System.Drawing.Size(192, 22);
            this.txtNgayBangGia.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(44, 9);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(95, 16);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Ngày lập báo giá";
            // 
            // btnTongHop
            // 
            this.btnTongHop.ImageIndex = 20;
            this.btnTongHop.Location = new System.Drawing.Point(353, 3);
            this.btnTongHop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(93, 25);
            this.btnTongHop.TabIndex = 3;
            this.btnTongHop.Text = "Lấy thông tin";
            this.btnTongHop.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grcReport);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 743);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvBangGiaH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 743);
            this.panel2.TabIndex = 3;
            // 
            // grvBangGiaH
            // 
            this.grvBangGiaH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvBangGiaH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvBangGiaH.Location = new System.Drawing.Point(0, 0);
            this.grvBangGiaH.MainView = this.grvLPX_Hnx;
            this.grvBangGiaH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvBangGiaH.Name = "grvBangGiaH";
            this.grvBangGiaH.Size = new System.Drawing.Size(200, 743);
            this.grvBangGiaH.TabIndex = 4;
            this.grvBangGiaH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colNgayBangGia});
            this.grvLPX_Hnx.GridControl = this.grvBangGiaH;
            this.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvLPX_Hnx.Name = "grvLPX_Hnx";
            this.grvLPX_Hnx.OptionsBehavior.Editable = false;
            this.grvLPX_Hnx.OptionsView.ColumnAutoWidth = false;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = true;
            this.grvLPX_Hnx.OptionsView.ShowGroupPanel = false;
            this.grvLPX_Hnx.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayBangGia, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grvLPX_Hnx.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvLPX_Hnx_SelectionChanged);
            this.grvLPX_Hnx.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvLPX_Hnx_FocusedRowChanged);
            // 
            // colNgayBangGia
            // 
            this.colNgayBangGia.Caption = "Ngày báo giá";
            this.colNgayBangGia.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayBangGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayBangGia.FieldName = "NgayBangGia";
            this.colNgayBangGia.Name = "colNgayBangGia";
            this.colNgayBangGia.Visible = true;
            this.colNgayBangGia.VisibleIndex = 0;
            this.colNgayBangGia.Width = 185;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 743);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmBcTongHopHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 753);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBcTongHopHH";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Báo cáo tổng hợp hàng hóa";
            this.Load += new System.EventHandler(this.frmBcKeHoachSanXuat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBcKeHoachSanXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtextN0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBangGia.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBangGia.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvBangGiaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcReport;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTongHop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboHanghoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboType;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboApplication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtextN0;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboDiaLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn MaVC;
        private DevExpress.XtraEditors.SimpleButton btnLuuBangGia;
        private DevExpress.XtraEditors.DateEdit txtNgayBangGia;
        internal DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal DevExpress.XtraGrid.GridControl grvBangGiaH;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvLPX_Hnx;
        internal DevExpress.XtraGrid.Columns.GridColumn colNgayBangGia;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAddnew;
    }
}