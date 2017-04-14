namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    partial class frmDanhMucQuyTrinh_DanhSach
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
            this.gbQuyTrinh = new DevExpress.XtraEditors.GroupControl();
            this.grcQuyTrinh = new DevExpress.XtraGrid.GridControl();
            this.grvQuyTrinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbQuyTrinh)).BeginInit();
            this.gbQuyTrinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcQuyTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuyTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuyTrinh
            // 
            this.gbQuyTrinh.Controls.Add(this.grcQuyTrinh);
            this.gbQuyTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuyTrinh.Location = new System.Drawing.Point(4, 4);
            this.gbQuyTrinh.Name = "gbQuyTrinh";
            this.gbQuyTrinh.Size = new System.Drawing.Size(776, 355);
            this.gbQuyTrinh.TabIndex = 3;
            this.gbQuyTrinh.Text = "Danh mục quy trình";
            // 
            // grcQuyTrinh
            // 
            this.grcQuyTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcQuyTrinh.Location = new System.Drawing.Point(2, 22);
            this.grcQuyTrinh.MainView = this.grvQuyTrinh;
            this.grcQuyTrinh.Name = "grcQuyTrinh";
            this.grcQuyTrinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcQuyTrinh.Size = new System.Drawing.Size(772, 331);
            this.grcQuyTrinh.TabIndex = 0;
            this.grcQuyTrinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuyTrinh});
            // 
            // grvQuyTrinh
            // 
            this.grvQuyTrinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grvQuyTrinh.GridControl = this.grcQuyTrinh;
            this.grvQuyTrinh.Name = "grvQuyTrinh";
            this.grvQuyTrinh.OptionsView.ShowGroupPanel = false;
            this.grvQuyTrinh.DoubleClick += new System.EventHandler(this.grvQuyTrinh_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã quy trình";
            this.gridColumn1.FieldName = "MaQuytrinh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên quy trình";
            this.gridColumn3.FieldName = "TenQuytrinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mô tả";
            this.gridColumn4.FieldName = "MoTa";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Có sử dụng";
            this.gridColumn5.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn5.FieldName = "CoSuDung";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnImport);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnModify);
            this.groupControl1.Controls.Add(this.btnAddNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(4, 359);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(776, 34);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 20;
            this.btnClose.Location = new System.Drawing.Point(696, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 8;
            this.btnDelete.Location = new System.Drawing.Point(172, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnModify
            // 
            this.btnModify.ImageIndex = 2;
            this.btnModify.Location = new System.Drawing.Point(86, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 29;
            this.btnModify.Text = "&Sửa";
            this.btnModify.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.ImageIndex = 16;
            this.btnAddNew.Location = new System.Drawing.Point(0, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(80, 30);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "&Thêm";
            this.btnAddNew.ToolTip = "Phím tắt Ctrl R";
            this.btnAddNew.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAddNew.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.ImageIndex = 2;
            this.btnImport.Location = new System.Drawing.Point(258, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 30);
            this.btnImport.TabIndex = 32;
            this.btnImport.Text = "&Nhập dữ liệu";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmDanhMucQuyTrinh_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 397);
            this.Controls.Add(this.gbQuyTrinh);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmDanhMucQuyTrinh_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Danh mục quy trình";
            this.Load += new System.EventHandler(this.FrmDanhMucQuyTrinhDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbQuyTrinh)).EndInit();
            this.gbQuyTrinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcQuyTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuyTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbQuyTrinh;
        private DevExpress.XtraGrid.GridControl grcQuyTrinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvQuyTrinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        internal DevExpress.XtraEditors.SimpleButton btnImport;
    }
}