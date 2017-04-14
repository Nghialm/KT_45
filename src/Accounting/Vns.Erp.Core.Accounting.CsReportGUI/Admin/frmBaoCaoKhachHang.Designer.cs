namespace Vns.Erp.Core.Accounting.CsReportGUI.Admin
{
    partial class frmBaoCaoKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ucDate = new Vns.Erp.Core.Controls.UserControl.DateTimeInput();
            this.cboTaiKhoan = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboKhachHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.grcData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboKhang = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 20;
            this.btnSearch.Location = new System.Drawing.Point(132, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 37);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(10, 94);
            this.LabelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(66, 16);
            this.LabelControl4.TabIndex = 7;
            this.LabelControl4.Text = "Khách hàng";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(972, 628);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ucDate);
            this.Panel1.Controls.Add(this.cboTaiKhoan);
            this.Panel1.Controls.Add(this.cboKhachHang);
            this.Panel1.Controls.Add(this.btnSearch);
            this.Panel1.Controls.Add(this.LabelControl4);
            this.Panel1.Controls.Add(this.LabelControl1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 4);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(966, 169);
            this.Panel1.TabIndex = 0;
            // 
            // ucDate
            // 
            this.ucDate.EndDate = new System.DateTime(((long)(0)));
            this.ucDate.Location = new System.Drawing.Point(10, 8);
            this.ucDate.Name = "ucDate";
            this.ucDate.Size = new System.Drawing.Size(520, 25);
            this.ucDate.StartDate = new System.DateTime(((long)(0)));
            this.ucDate.TabIndex = 13;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.Location = new System.Drawing.Point(132, 50);
            this.cboTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTaiKhoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTaiKhoan.Properties.DisplayMember = "MaTaikhoan";
            this.cboTaiKhoan.Properties.NullText = "";
            this.cboTaiKhoan.Properties.ValueMember = "Id";
            this.cboTaiKhoan.Properties.View = this.GridView2;
            this.cboTaiKhoan.Size = new System.Drawing.Size(315, 22);
            this.cboTaiKhoan.TabIndex = 12;
            this.cboTaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.cboTaiKhoan_Validating);
            // 
            // GridView2
            // 
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2});
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowAutoFilterRow = true;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Mã tài khoản";
            this.GridColumn1.FieldName = "MaTaikhoan";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Tên tài khoản";
            this.GridColumn2.FieldName = "TenTaikhoan";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Location = new System.Drawing.Point(132, 91);
            this.cboKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhachHang.Properties.DisplayMember = "TenKhang";
            this.cboKhachHang.Properties.NullText = "";
            this.cboKhachHang.Properties.ValueMember = "Id";
            this.cboKhachHang.Properties.View = this.gridView4;
            this.cboKhachHang.Size = new System.Drawing.Size(315, 22);
            this.cboKhachHang.TabIndex = 11;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã khách hàng";
            this.gridColumn7.FieldName = "KyHieu";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên khách hàng";
            this.gridColumn8.FieldName = "TenKhang";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(10, 53);
            this.LabelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(62, 17);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Nghiệp vụ";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.grcData);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 181);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(966, 443);
            this.Panel2.TabIndex = 1;
            // 
            // grcData
            // 
            this.grcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcData.Location = new System.Drawing.Point(0, 0);
            this.grcData.MainView = this.gridView1;
            this.grcData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcData.Name = "grcData";
            this.grcData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboKhang});
            this.grcData.Size = new System.Drawing.Size(966, 443);
            this.grcData.TabIndex = 0;
            this.grcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView1.GridControl = this.grcData;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày chứng từ";
            this.gridColumn3.FieldName = "NgayCt";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số chứng từ";
            this.gridColumn4.FieldName = "CtSo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Khách hàng";
            this.gridColumn5.ColumnEdit = this.cboKhang;
            this.gridColumn5.FieldName = "IdKhang";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // cboKhang
            // 
            this.cboKhang.AutoHeight = false;
            this.cboKhang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhang.DisplayMember = "TenKhang";
            this.cboKhang.Name = "cboKhang";
            this.cboKhang.ValueMember = "Id";
            this.cboKhang.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã tài khoản";
            this.gridColumn6.FieldName = "MaTk";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã tài khoản đư";
            this.gridColumn9.FieldName = "MaTkDu";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Phát sinh nợ";
            this.gridColumn10.DisplayFormat.FormatString = "n0";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "PsNo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Phát sinh có";
            this.gridColumn11.DisplayFormat.FormatString = "n0";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "PsCo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Diễn giải";
            this.gridColumn12.FieldName = "DienGiai";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 628);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmBaoCaoKhachHang";
            this.Text = "Báo cáo theo khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoKhachHang_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Panel Panel1;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal System.Windows.Forms.Panel Panel2;
        private DevExpress.XtraGrid.GridControl grcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit cboTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        private DevExpress.XtraEditors.GridLookUpEdit cboKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboKhang;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private Controls.UserControl.DateTimeInput ucDate;
    }
}