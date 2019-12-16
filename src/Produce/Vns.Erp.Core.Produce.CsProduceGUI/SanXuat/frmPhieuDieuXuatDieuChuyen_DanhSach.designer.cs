namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    partial class frmPhieuDieuXuatDieuChuyen_DanhSach
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
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcLPN_Hnx = new DevExpress.XtraGrid.GridControl();
            this.grvLPX_Hnx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ghi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CtSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KyHieuKhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MstKhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayGhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiGiaoNhanHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClo = new DevExpress.XtraEditors.SimpleButton();
            this.btnMod = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.grvLPN_Dnx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KyHieuHanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaVon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLPN_Dnx = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CtlPagerControl = new Vns.Erp.Core.Common.Controls.PagerControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPN_Dnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Dnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.grcLPN_Hnx);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1162, 302);
            this.GroupControl1.TabIndex = 22;
            this.GroupControl1.Text = "Danh sách...";
            // 
            // grcLPN_Hnx
            // 
            this.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLPN_Hnx.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcLPN_Hnx.Location = new System.Drawing.Point(2, 24);
            this.grcLPN_Hnx.MainView = this.grvLPX_Hnx;
            this.grcLPN_Hnx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcLPN_Hnx.Name = "grcLPN_Hnx";
            this.grcLPN_Hnx.Size = new System.Drawing.Size(1158, 276);
            this.grcLPN_Hnx.TabIndex = 1;
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
            this.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
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
            this.Ghi,
            this.CtSo,
            this.NgayCt,
            this.KyHieuKhang,
            this.TenKhang,
            this.MstKhang,
            this.NgayGhi,
            this.DienGiai,
            this.NguoiGiaoNhanHang});
            this.grvLPX_Hnx.GridControl = this.grcLPN_Hnx;
            this.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvLPX_Hnx.Name = "grvLPX_Hnx";
            this.grvLPX_Hnx.OptionsBehavior.Editable = false;
            this.grvLPX_Hnx.OptionsView.ColumnAutoWidth = false;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = true;
            this.grvLPX_Hnx.OptionsView.ShowGroupPanel = false;
            // 
            // Ghi
            // 
            this.Ghi.Caption = "Trạng thái";
            this.Ghi.FieldName = "Ghi";
            this.Ghi.Name = "Ghi";
            this.Ghi.Visible = true;
            this.Ghi.VisibleIndex = 0;
            // 
            // CtSo
            // 
            this.CtSo.Caption = "Số chứng từ";
            this.CtSo.FieldName = "CtSo";
            this.CtSo.Name = "CtSo";
            this.CtSo.Visible = true;
            this.CtSo.VisibleIndex = 1;
            this.CtSo.Width = 90;
            // 
            // NgayCt
            // 
            this.NgayCt.Caption = "Ngày chứng từ";
            this.NgayCt.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayCt.FieldName = "NgayCt";
            this.NgayCt.Name = "NgayCt";
            this.NgayCt.Visible = true;
            this.NgayCt.VisibleIndex = 2;
            this.NgayCt.Width = 100;
            // 
            // KyHieuKhang
            // 
            this.KyHieuKhang.Caption = "Mã khách ";
            this.KyHieuKhang.FieldName = "KyHieuKhang";
            this.KyHieuKhang.Name = "KyHieuKhang";
            this.KyHieuKhang.Width = 100;
            // 
            // TenKhang
            // 
            this.TenKhang.Caption = "Tên khách";
            this.TenKhang.FieldName = "TenKhang";
            this.TenKhang.Name = "TenKhang";
            this.TenKhang.Width = 250;
            // 
            // MstKhang
            // 
            this.MstKhang.Caption = "Mã số thuế";
            this.MstKhang.FieldName = "MstKhang";
            this.MstKhang.Name = "MstKhang";
            this.MstKhang.Width = 100;
            // 
            // NgayGhi
            // 
            this.NgayGhi.Caption = "Ngày hạch toán";
            this.NgayGhi.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayGhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayGhi.FieldName = "NgayGhi";
            this.NgayGhi.Name = "NgayGhi";
            this.NgayGhi.Visible = true;
            this.NgayGhi.VisibleIndex = 3;
            this.NgayGhi.Width = 90;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn giải";
            this.DienGiai.FieldName = "DienGiai";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 4;
            this.DienGiai.Width = 250;
            // 
            // NguoiGiaoNhanHang
            // 
            this.NguoiGiaoNhanHang.Caption = "Người giao hàng";
            this.NguoiGiaoNhanHang.FieldName = "NguoiGiaoNhanHang";
            this.NguoiGiaoNhanHang.Name = "NguoiGiaoNhanHang";
            this.NguoiGiaoNhanHang.Visible = true;
            this.NguoiGiaoNhanHang.VisibleIndex = 5;
            this.NguoiGiaoNhanHang.Width = 200;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnClo);
            this.PanelControl2.Controls.Add(this.btnMod);
            this.PanelControl2.Controls.Add(this.btnAdd);
            this.PanelControl2.Controls.Add(this.btnDel);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(7, 704);
            this.PanelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelControl2.Size = new System.Drawing.Size(1162, 42);
            this.PanelControl2.TabIndex = 24;
            // 
            // btnClo
            // 
            this.btnClo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClo.ImageIndex = 1;
            this.btnClo.Location = new System.Drawing.Point(1067, 4);
            this.btnClo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClo.Name = "btnClo";
            this.btnClo.Size = new System.Drawing.Size(93, 37);
            this.btnClo.TabIndex = 6;
            this.btnClo.Text = "&Đóng";
            this.btnClo.Click += new System.EventHandler(this.btnClo_Click);
            // 
            // btnMod
            // 
            this.btnMod.ImageIndex = 4;
            this.btnMod.Location = new System.Drawing.Point(103, 4);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(93, 37);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "&Sửa";
            this.btnMod.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 18;
            this.btnAdd.Location = new System.Drawing.Point(2, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageIndex = 3;
            this.btnDel.Location = new System.Drawing.Point(203, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 37);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "&Xóa";
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
            this.KyHieuHanghoa,
            this.TenHanghoa,
            this.TenDvt,
            this.SoLuong,
            this.GridColumn1,
            this.GiaVon});
            this.grvLPN_Dnx.GridControl = this.grcLPN_Dnx;
            this.grvLPN_Dnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvLPN_Dnx.Name = "grvLPN_Dnx";
            this.grvLPN_Dnx.OptionsBehavior.Editable = false;
            this.grvLPN_Dnx.OptionsView.ColumnAutoWidth = false;
            this.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = true;
            this.grvLPN_Dnx.OptionsView.ShowGroupPanel = false;
            // 
            // KyHieuHanghoa
            // 
            this.KyHieuHanghoa.Caption = "Mã hàng";
            this.KyHieuHanghoa.FieldName = "KyHieuHanghoa";
            this.KyHieuHanghoa.Name = "KyHieuHanghoa";
            this.KyHieuHanghoa.Visible = true;
            this.KyHieuHanghoa.VisibleIndex = 0;
            this.KyHieuHanghoa.Width = 110;
            // 
            // TenHanghoa
            // 
            this.TenHanghoa.Caption = "Tên hàng / Vật tư";
            this.TenHanghoa.FieldName = "TenHanghoa";
            this.TenHanghoa.Name = "TenHanghoa";
            this.TenHanghoa.Visible = true;
            this.TenHanghoa.VisibleIndex = 1;
            this.TenHanghoa.Width = 120;
            // 
            // TenDvt
            // 
            this.TenDvt.Caption = "ĐVT";
            this.TenDvt.FieldName = "TenDvt";
            this.TenDvt.Name = "TenDvt";
            this.TenDvt.Visible = true;
            this.TenDvt.VisibleIndex = 2;
            this.TenDvt.Width = 80;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "n2";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 120;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Đơn giá";
            this.GridColumn1.DisplayFormat.FormatString = "n2";
            this.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumn1.FieldName = "DonGiaVon";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 4;
            // 
            // GiaVon
            // 
            this.GiaVon.Caption = "Tổng tiền";
            this.GiaVon.DisplayFormat.FormatString = "n0";
            this.GiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaVon.FieldName = "GiaVon";
            this.GiaVon.Name = "GiaVon";
            this.GiaVon.Visible = true;
            this.GiaVon.VisibleIndex = 5;
            this.GiaVon.Width = 120;
            // 
            // grcLPN_Dnx
            // 
            this.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLPN_Dnx.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcLPN_Dnx.Location = new System.Drawing.Point(2, 24);
            this.grcLPN_Dnx.MainView = this.grvLPN_Dnx;
            this.grcLPN_Dnx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcLPN_Dnx.Name = "grcLPN_Dnx";
            this.grcLPN_Dnx.Size = new System.Drawing.Size(1158, 325);
            this.grcLPN_Dnx.TabIndex = 1;
            this.grcLPN_Dnx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLPN_Dnx});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grcLPN_Dnx);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1162, 351);
            this.groupControl2.TabIndex = 23;
            this.groupControl2.Text = "Danh sách...";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(7, 7);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.GroupControl1);
            this.SplitContainer1.Panel1.Controls.Add(this.PanelControl1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.SplitContainer1.Size = new System.Drawing.Size(1162, 697);
            this.SplitContainer1.SplitterDistance = 341;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 25;
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.CtlPagerControl);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(0, 302);
            this.PanelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1162, 39);
            this.PanelControl1.TabIndex = 23;
            // 
            // CtlPagerControl
            // 
            this.CtlPagerControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CtlPagerControl.Location = new System.Drawing.Point(597, 2);
            this.CtlPagerControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CtlPagerControl.Name = "CtlPagerControl";
            this.CtlPagerControl.PageIndex = 1;
            this.CtlPagerControl.PageSize = 100;
            this.CtlPagerControl.Size = new System.Drawing.Size(563, 35);
            this.CtlPagerControl.TabIndex = 0;
            this.CtlPagerControl.TotalPage = 0;
            this.CtlPagerControl.TotalResult = 0;
            // 
            // frmPhieuDieuXuatDieuChuyen_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 753);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.PanelControl2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhieuDieuXuatDieuChuyen_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu điều chuyển [ Danh sách ]";
            this.Load += new System.EventHandler(this.frmPhieuDieuXuatDieuChuyen_DanhSach_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuDieuXuatDieuChuyen_DanhSach_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvLPN_Dnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Dnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl grcLPN_Hnx;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvLPX_Hnx;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvLPN_Dnx;
        internal DevExpress.XtraGrid.GridControl grcLPN_Dnx;
        internal DevExpress.XtraEditors.GroupControl groupControl2;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_GHI;
        internal DevExpress.XtraGrid.Columns.GridColumn CT_SO;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_CT;
        internal DevExpress.XtraGrid.Columns.GridColumn DIEN_GIAI;
        internal DevExpress.XtraGrid.Columns.GridColumn NGUOI_GIAO_NHAN_HANG;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU_KHANG;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_HANGHOA;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_LUONG;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal DevExpress.XtraEditors.SimpleButton btnMod;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraEditors.SimpleButton btnDel;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON;
        internal DevExpress.XtraEditors.SimpleButton btnClo;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_KHANG;
        internal DevExpress.XtraGrid.Columns.GridColumn MST_KHANG;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU_HANGHOA;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_DVT;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn CtSo;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayCt;
        internal DevExpress.XtraGrid.Columns.GridColumn KyHieuKhang;
        internal DevExpress.XtraGrid.Columns.GridColumn TenKhang;
        internal DevExpress.XtraGrid.Columns.GridColumn MstKhang;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayGhi;
        internal DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        internal DevExpress.XtraGrid.Columns.GridColumn NguoiGiaoNhanHang;
        internal DevExpress.XtraGrid.Columns.GridColumn KyHieuHanghoa;
        internal DevExpress.XtraGrid.Columns.GridColumn TenHanghoa;
        internal DevExpress.XtraGrid.Columns.GridColumn TenDvt;
        internal DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaVon;
        internal DevExpress.XtraGrid.Columns.GridColumn Ghi;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal Vns.Erp.Core.Common.Controls.PagerControl CtlPagerControl;
        //public frmPhieuDieuXuatDieuChuyen_DanhSach()
        //{
        //    InitializeComponent();
        //}
    }
}