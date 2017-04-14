using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucNhomTSCD_ChiTiet
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
            this.components = new System.ComponentModel.Container();
            this.depDM_NKH = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnNHOM_TSCD = new DevExpress.XtraEditors.PanelControl();
            this.txtLOAI_NHOM = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN_NHOM_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.txtMA_NHOM_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depDM_NKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnNHOM_TSCD)).BeginInit();
            this.pnNHOM_TSCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOAI_NHOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_NHOM_TSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_NHOM_TSCD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // depDM_NKH
            // 
            this.depDM_NKH.ContainerControl = this;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnClose);
            this.PanelControl2.Controls.Add(this.btnXoaTrang);
            this.PanelControl2.Controls.Add(this.btnSave);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(4, 101);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(428, 39);
            this.PanelControl2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 8;
            this.btnClose.Location = new System.Drawing.Point(262, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Quay ra";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaTrang.ImageIndex = 24;
            this.btnXoaTrang.Location = new System.Drawing.Point(176, 8);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(80, 30);
            this.btnXoaTrang.TabIndex = 1;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.ImageIndex = 0;
            this.btnSave.Location = new System.Drawing.Point(90, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnNHOM_TSCD
            // 
            this.pnNHOM_TSCD.Controls.Add(this.txtLOAI_NHOM);
            this.pnNHOM_TSCD.Controls.Add(this.txtTEN_NHOM_TSCD);
            this.pnNHOM_TSCD.Controls.Add(this.txtMA_NHOM_TSCD);
            this.pnNHOM_TSCD.Controls.Add(this.Label5);
            this.pnNHOM_TSCD.Controls.Add(this.Label4);
            this.pnNHOM_TSCD.Controls.Add(this.Label2);
            this.pnNHOM_TSCD.Controls.Add(this.Label1);
            this.pnNHOM_TSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNHOM_TSCD.Location = new System.Drawing.Point(4, 4);
            this.pnNHOM_TSCD.Name = "pnNHOM_TSCD";
            this.pnNHOM_TSCD.Size = new System.Drawing.Size(428, 97);
            this.pnNHOM_TSCD.TabIndex = 0;
            // 
            // txtLOAI_NHOM
            // 
            this.txtLOAI_NHOM.EnterMoveNextControl = true;
            this.txtLOAI_NHOM.Location = new System.Drawing.Point(114, 62);
            this.txtLOAI_NHOM.Name = "txtLOAI_NHOM";
            this.txtLOAI_NHOM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLOAI_NHOM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLOAI_NHOM.Properties.Mask.EditMask = "[1-3]{1}";
            this.txtLOAI_NHOM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLOAI_NHOM.Properties.MaxLength = 1;
            this.txtLOAI_NHOM.Size = new System.Drawing.Size(31, 20);
            this.txtLOAI_NHOM.TabIndex = 12;
            // 
            // txtTEN_NHOM_TSCD
            // 
            this.txtTEN_NHOM_TSCD.EnterMoveNextControl = true;
            this.txtTEN_NHOM_TSCD.Location = new System.Drawing.Point(114, 36);
            this.txtTEN_NHOM_TSCD.Name = "txtTEN_NHOM_TSCD";
            this.txtTEN_NHOM_TSCD.Size = new System.Drawing.Size(304, 20);
            this.txtTEN_NHOM_TSCD.TabIndex = 10;
            // 
            // txtMA_NHOM_TSCD
            // 
            this.txtMA_NHOM_TSCD.EnterMoveNextControl = true;
            this.txtMA_NHOM_TSCD.Location = new System.Drawing.Point(114, 9);
            this.txtMA_NHOM_TSCD.Name = "txtMA_NHOM_TSCD";
            this.txtMA_NHOM_TSCD.Size = new System.Drawing.Size(142, 20);
            this.txtMA_NHOM_TSCD.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(151, 65);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(149, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "(Nhập giá trị 1 hoặc 2 hoặc 3)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(15, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Loại nhóm TSCD";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Tên nhóm TSCD";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Mã nhóm TSCD";
            // 
            // frmDanhMucNhomTSCD_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(436, 144);
            this.Controls.Add(this.pnNHOM_TSCD);
            this.Controls.Add(this.PanelControl2);
            this.Name = "frmDanhMucNhomTSCD_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhóm tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)(this.depDM_NKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnNHOM_TSCD)).EndInit();
            this.pnNHOM_TSCD.ResumeLayout(false);
            this.pnNHOM_TSCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOAI_NHOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_NHOM_TSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_NHOM_TSCD.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider depDM_NKH;
        internal DevExpress.XtraEditors.PanelControl pnNHOM_TSCD;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.TextEdit txtLOAI_NHOM;
        internal DevExpress.XtraEditors.TextEdit txtTEN_NHOM_TSCD;
        internal DevExpress.XtraEditors.TextEdit txtMA_NHOM_TSCD;
        //public frmDanhMucNhomTSCD_ChiTiet()
        //{
        //    InitializeComponent();
        //}
    }
}