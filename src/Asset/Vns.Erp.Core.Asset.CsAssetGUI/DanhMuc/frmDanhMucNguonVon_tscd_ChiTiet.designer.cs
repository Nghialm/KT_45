using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;


namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucNguonVon_tscd_ChiTiet
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
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTSCD = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTSCD = new DevExpress.XtraEditors.TextEdit();
            this.txtKYHIEU = new DevExpress.XtraEditors.TextEdit();
            this.txtMOTA = new DevExpress.XtraEditors.TextEdit();
            this.chkCHO_PHEP_SUA = new DevExpress.XtraEditors.CheckEdit();
            this.chkCO_SU_DUNG = new DevExpress.XtraEditors.CheckEdit();
            this.grpSMQR = new DevExpress.XtraEditors.GroupControl();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKYHIEU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMOTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCHO_PHEP_SUA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCO_SU_DUNG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSMQR)).BeginInit();
            this.grpSMQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl11.Location = new System.Drawing.Point(81, 90);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(27, 13);
            this.labelControl11.TabIndex = 82;
            this.labelControl11.Text = "Mô tả";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl12.Location = new System.Drawing.Point(73, 38);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(35, 13);
            this.labelControl12.TabIndex = 81;
            this.labelControl12.Text = "Ký hiệu";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelControl5.Location = new System.Drawing.Point(12, 64);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(101, 13);
            this.LabelControl5.TabIndex = 80;
            this.LabelControl5.Text = "Tên nguồn vốn TSCD";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelControl1.Location = new System.Drawing.Point(16, 12);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(97, 13);
            this.LabelControl1.TabIndex = 79;
            this.LabelControl1.Text = "Mã nguồn vốn TSCD";
            // 
            // txtMaTSCD
            // 
            this.txtMaTSCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaTSCD.EnterMoveNextControl = true;
            this.txtMaTSCD.Location = new System.Drawing.Point(127, 9);
            this.txtMaTSCD.Name = "txtMaTSCD";
            this.txtMaTSCD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaTSCD.Size = new System.Drawing.Size(82, 20);
            this.txtMaTSCD.TabIndex = 0;
            // 
            // txtTenTSCD
            // 
            this.txtTenTSCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenTSCD.EnterMoveNextControl = true;
            this.txtTenTSCD.Location = new System.Drawing.Point(127, 61);
            this.txtTenTSCD.Name = "txtTenTSCD";
            this.txtTenTSCD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenTSCD.Size = new System.Drawing.Size(263, 20);
            this.txtTenTSCD.TabIndex = 2;
            // 
            // txtKYHIEU
            // 
            this.txtKYHIEU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKYHIEU.EnterMoveNextControl = true;
            this.txtKYHIEU.Location = new System.Drawing.Point(127, 35);
            this.txtKYHIEU.Name = "txtKYHIEU";
            this.txtKYHIEU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKYHIEU.Size = new System.Drawing.Size(133, 20);
            this.txtKYHIEU.TabIndex = 1;
            // 
            // txtMOTA
            // 
            this.txtMOTA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMOTA.EnterMoveNextControl = true;
            this.txtMOTA.Location = new System.Drawing.Point(127, 87);
            this.txtMOTA.Name = "txtMOTA";
            this.txtMOTA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMOTA.Size = new System.Drawing.Size(263, 20);
            this.txtMOTA.TabIndex = 3;
            // 
            // chkCHO_PHEP_SUA
            // 
            this.chkCHO_PHEP_SUA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCHO_PHEP_SUA.Location = new System.Drawing.Point(283, 113);
            this.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA";
            this.chkCHO_PHEP_SUA.Properties.Caption = "Cho phép sửa";
            this.chkCHO_PHEP_SUA.Size = new System.Drawing.Size(107, 19);
            this.chkCHO_PHEP_SUA.TabIndex = 5;
            // 
            // chkCO_SU_DUNG
            // 
            this.chkCO_SU_DUNG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCO_SU_DUNG.Location = new System.Drawing.Point(125, 113);
            this.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG";
            this.chkCO_SU_DUNG.Properties.Caption = "Có sử dụng";
            this.chkCO_SU_DUNG.Size = new System.Drawing.Size(117, 19);
            this.chkCO_SU_DUNG.TabIndex = 4;
            // 
            // grpSMQR
            // 
            this.grpSMQR.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpSMQR.Appearance.BorderColor = System.Drawing.Color.White;
            this.grpSMQR.Appearance.Options.UseBackColor = true;
            this.grpSMQR.Appearance.Options.UseBorderColor = true;
            this.grpSMQR.Controls.Add(this.LabelControl1);
            this.grpSMQR.Controls.Add(this.chkCHO_PHEP_SUA);
            this.grpSMQR.Controls.Add(this.LabelControl5);
            this.grpSMQR.Controls.Add(this.chkCO_SU_DUNG);
            this.grpSMQR.Controls.Add(this.labelControl12);
            this.grpSMQR.Controls.Add(this.labelControl11);
            this.grpSMQR.Controls.Add(this.txtTenTSCD);
            this.grpSMQR.Controls.Add(this.txtKYHIEU);
            this.grpSMQR.Controls.Add(this.txtMaTSCD);
            this.grpSMQR.Controls.Add(this.txtMOTA);
            this.grpSMQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSMQR.Location = new System.Drawing.Point(6, 6);
            this.grpSMQR.Name = "grpSMQR";
            this.grpSMQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSMQR.ShowCaption = false;
            this.grpSMQR.Size = new System.Drawing.Size(405, 143);
            this.grpSMQR.TabIndex = 96;
            this.grpSMQR.Text = "Chi tiết....";
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnCancel);
            this.PanelControl2.Controls.Add(this.btnClear);
            this.PanelControl2.Controls.Add(this.btnSave);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(6, 150);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(405, 34);
            this.PanelControl2.TabIndex = 97;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(324, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Ð&óng";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.ImageIndex = 32;
            this.btnClear.Location = new System.Drawing.Point(162, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Xóa trắng";
            this.btnClear.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(1, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Lưu";
            // 
            // frmDanhMucNguonVon_tscd_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 190);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.grpSMQR);
            this.KeyPreview = true;
            this.Name = "frmDanhMucNguonVon_tscd_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nguồn vốn [Chi tiết]";
            this.Load += new System.EventHandler(this.frmDanhMucNguonVon_tscd_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKYHIEU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMOTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCHO_PHEP_SUA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCO_SU_DUNG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSMQR)).EndInit();
            this.grpSMQR.ResumeLayout(false);
            this.grpSMQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.LabelControl labelControl11;
        internal DevExpress.XtraEditors.LabelControl labelControl12;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtKYHIEU;
        internal DevExpress.XtraEditors.TextEdit txtMOTA;
        internal DevExpress.XtraEditors.TextEdit txtMaTSCD;
        internal DevExpress.XtraEditors.TextEdit txtTenTSCD;
        internal DevExpress.XtraEditors.CheckEdit chkCHO_PHEP_SUA;
        internal DevExpress.XtraEditors.CheckEdit chkCO_SU_DUNG;
        internal DevExpress.XtraEditors.GroupControl grpSMQR;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnClear;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        
    }
}