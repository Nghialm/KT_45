namespace Vns.Erp.Core.Common.Controls
{
    partial class PagerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.txtPage = new DevExpress.XtraEditors.TextEdit();
            this.lblPageSizePrefix = new System.Windows.Forms.Label();
            this.txtPageSize = new DevExpress.XtraEditors.TextEdit();
            this.lblPageSizePostFix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Trang trước";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(192, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Trang sau";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPage
            // 
            this.txtPage.EditValue = "";
            this.txtPage.Location = new System.Drawing.Point(92, 4);
            this.txtPage.Name = "txtPage";
            this.txtPage.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPage.Size = new System.Drawing.Size(93, 20);
            this.txtPage.TabIndex = 2;
            this.txtPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPage_KeyDown);
            // 
            // lblPageSizePrefix
            // 
            this.lblPageSizePrefix.AutoSize = true;
            this.lblPageSizePrefix.Location = new System.Drawing.Point(274, 7);
            this.lblPageSizePrefix.Name = "lblPageSizePrefix";
            this.lblPageSizePrefix.Size = new System.Drawing.Size(46, 13);
            this.lblPageSizePrefix.TabIndex = 3;
            this.lblPageSizePrefix.Text = "Hiển thị ";
            // 
            // txtPageSize
            // 
            this.txtPageSize.Location = new System.Drawing.Point(319, 5);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(41, 20);
            this.txtPageSize.TabIndex = 4;
            this.txtPageSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageSize_KeyDown);
            // 
            // lblPageSizePostFix
            // 
            this.lblPageSizePostFix.AutoSize = true;
            this.lblPageSizePostFix.Location = new System.Drawing.Point(366, 8);
            this.lblPageSizePostFix.Name = "lblPageSizePostFix";
            this.lblPageSizePostFix.Size = new System.Drawing.Size(111, 13);
            this.lblPageSizePostFix.TabIndex = 5;
            this.lblPageSizePostFix.Text = "kết quả trên một trang";
            // 
            // PagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageSizePostFix);
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.lblPageSizePrefix);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "PagerControl";
            this.Size = new System.Drawing.Size(540, 30);
            this.Load += new System.EventHandler(this.PagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.TextEdit txtPage;
        private System.Windows.Forms.Label lblPageSizePrefix;
        private DevExpress.XtraEditors.TextEdit txtPageSize;
        private System.Windows.Forms.Label lblPageSizePostFix;
    }
}
