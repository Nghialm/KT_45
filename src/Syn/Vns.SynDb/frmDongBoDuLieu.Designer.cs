namespace Vns.Erp.Core.SynDb
{
    partial class frmDongBoDuLieu
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
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.cbkDongBoCt = new DevExpress.XtraEditors.CheckEdit();
            this.cbkSynDanhMuc = new DevExpress.XtraEditors.CheckEdit();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbkDongBoCt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbkSynDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageIndex = 20;
            this.btnThucHien.Location = new System.Drawing.Point(535, 9);
            this.btnThucHien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(93, 37);
            this.btnThucHien.TabIndex = 10;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.TableLayoutPanel1.Size = new System.Drawing.Size(742, 388);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.simpleButton1);
            this.Panel1.Controls.Add(this.checkEdit3);
            this.Panel1.Controls.Add(this.cbkDongBoCt);
            this.Panel1.Controls.Add(this.cbkSynDanhMuc);
            this.Panel1.Controls.Add(this.btnThucHien);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 4);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(736, 169);
            this.Panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 20;
            this.simpleButton1.Location = new System.Drawing.Point(634, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 37);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(27, 52);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Đồng bộ hệ thống";
            this.checkEdit3.Size = new System.Drawing.Size(218, 22);
            this.checkEdit3.TabIndex = 14;
            // 
            // cbkDongBoCt
            // 
            this.cbkDongBoCt.Location = new System.Drawing.Point(27, 80);
            this.cbkDongBoCt.Name = "cbkDongBoCt";
            this.cbkDongBoCt.Properties.Caption = "Đồng bộ chứng từ";
            this.cbkDongBoCt.Size = new System.Drawing.Size(218, 22);
            this.cbkDongBoCt.TabIndex = 13;
            // 
            // cbkSynDanhMuc
            // 
            this.cbkSynDanhMuc.Location = new System.Drawing.Point(27, 24);
            this.cbkSynDanhMuc.Name = "cbkSynDanhMuc";
            this.cbkSynDanhMuc.Properties.Caption = "Đồng bộ danh mục";
            this.cbkSynDanhMuc.Size = new System.Drawing.Size(218, 22);
            this.cbkSynDanhMuc.TabIndex = 12;
            // 
            // Panel2
            // 
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 181);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(736, 203);
            this.Panel2.TabIndex = 1;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmDongBoDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 388);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDongBoDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng bộ dữ liệu";
            this.Load += new System.EventHandler(this.frmBaoCaoKhachHang_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbkDongBoCt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbkSynDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit cbkDongBoCt;
        private DevExpress.XtraEditors.CheckEdit cbkSynDanhMuc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}