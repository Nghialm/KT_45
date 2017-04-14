namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    partial class frmDanhMucQuyTrinh_Detail
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xrQuyTrinh = new DevExpress.XtraTab.XtraTabPage();
            this.xrDinhMuc = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xrQuyTrinh;
            this.xtraTabControl1.Size = new System.Drawing.Size(1000, 604);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xrQuyTrinh,
            this.xrDinhMuc});
            // 
            // xrQuyTrinh
            // 
            this.xrQuyTrinh.Name = "xrQuyTrinh";
            this.xrQuyTrinh.Size = new System.Drawing.Size(995, 578);
            this.xrQuyTrinh.Text = "Quy trình sản xuất";
            // 
            // xrDinhMuc
            // 
            this.xrDinhMuc.Name = "xrDinhMuc";
            this.xrDinhMuc.Size = new System.Drawing.Size(995, 578);
            this.xrDinhMuc.Text = "Quy trình định mức";
            // 
            // frmDanhMucQuyTrinh_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.Name = "frmDanhMucQuyTrinh_Detail";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quy trình chi tiết";
            this.Load += new System.EventHandler(this.frmDanhMucQuyTrinh_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xrQuyTrinh;
        private DevExpress.XtraTab.XtraTabPage xrDinhMuc;

    }
}