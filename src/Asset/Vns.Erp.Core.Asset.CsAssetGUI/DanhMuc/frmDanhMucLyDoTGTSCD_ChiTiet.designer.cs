using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLyDoTGTSCD_ChiTiet
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
            if (disposing && ((components != null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region "Windows Form Designer generated code"

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._GroupControlObjectInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtMA_LYDO_TG_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.cboLOAI_LG1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTEN_LYDO_TG_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.lblValue = new DevExpress.XtraEditors.LabelControl();
            this.txtKY_HIEU = new DevExpress.XtraEditors.TextEdit();
            this.chkCO_SU_DUNG = new DevExpress.XtraEditors.CheckEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblCarFarmily_Code = new DevExpress.XtraEditors.LabelControl();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)this._GroupControlObjectInfo).BeginInit();
            this._GroupControlObjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_LYDO_TG_TSCD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboLOAI_LG1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTEN_LYDO_TG_TSCD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtKY_HIEU.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.chkCO_SU_DUNG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this._ActionPanel).BeginInit();
            this._ActionPanel.SuspendLayout();
            this.SuspendLayout();
            //
            //_GroupControlObjectInfo
            //
            this._GroupControlObjectInfo.Controls.Add(this.txtMA_LYDO_TG_TSCD);
            this._GroupControlObjectInfo.Controls.Add(this.cboLOAI_LG1);
            this._GroupControlObjectInfo.Controls.Add(this.labelControl1);
            this._GroupControlObjectInfo.Controls.Add(this.txtTEN_LYDO_TG_TSCD);
            this._GroupControlObjectInfo.Controls.Add(this.lblValue);
            this._GroupControlObjectInfo.Controls.Add(this.txtKY_HIEU);
            this._GroupControlObjectInfo.Controls.Add(this.chkCO_SU_DUNG);
            this._GroupControlObjectInfo.Controls.Add(this.LabelControl17);
            this._GroupControlObjectInfo.Controls.Add(this.labelControl4);
            this._GroupControlObjectInfo.Controls.Add(this.lblCarFarmily_Code);
            this._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GroupControlObjectInfo.Location = new System.Drawing.Point(6, 6);
            this._GroupControlObjectInfo.Name = "_GroupControlObjectInfo";
            this._GroupControlObjectInfo.ShowCaption = false;
            this._GroupControlObjectInfo.Size = new System.Drawing.Size(334, 143);
            this._GroupControlObjectInfo.TabIndex = 0;
            this._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2";
            //
            //txtMA_LYDO_TG_TSCD
            //
            this.txtMA_LYDO_TG_TSCD.EnterMoveNextControl = true;
            this.txtMA_LYDO_TG_TSCD.Location = new System.Drawing.Point(119, 14);
            this.txtMA_LYDO_TG_TSCD.Name = "txtMA_LYDO_TG_TSCD";
            this.txtMA_LYDO_TG_TSCD.Properties.Mask.EditMask = "[a-zA-Z0-9_]+";
            this.txtMA_LYDO_TG_TSCD.Properties.Mask.IgnoreMaskBlank = false;
            this.txtMA_LYDO_TG_TSCD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMA_LYDO_TG_TSCD.Properties.Mask.ShowPlaceHolders = false;
            this.txtMA_LYDO_TG_TSCD.Properties.MaxLength = 32;
            this.txtMA_LYDO_TG_TSCD.Size = new System.Drawing.Size(200, 20);
            this.txtMA_LYDO_TG_TSCD.TabIndex = 0;
            //
            //cboLOAI_LG1
            //
            this.cboLOAI_LG1.EnterMoveNextControl = true;
            this.cboLOAI_LG1.Location = new System.Drawing.Point(119, 92);
            this.cboLOAI_LG1.Name = "cboLOAI_LG1";
            this.cboLOAI_LG1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboLOAI_LG1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboLOAI_LG1.Properties.ImmediatePopup = true;
            this.cboLOAI_LG1.Properties.NullText = "";
            this.cboLOAI_LG1.Size = new System.Drawing.Size(200, 20);
            this.cboLOAI_LG1.TabIndex = 3;
            //
            //labelControl1
            //
            this.labelControl1.Location = new System.Drawing.Point(83, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Loại";
            //
            //txtTEN_LYDO_TG_TSCD
            //
            this.txtTEN_LYDO_TG_TSCD.EnterMoveNextControl = true;
            this.txtTEN_LYDO_TG_TSCD.Location = new System.Drawing.Point(119, 40);
            this.txtTEN_LYDO_TG_TSCD.Name = "txtTEN_LYDO_TG_TSCD";
            this.txtTEN_LYDO_TG_TSCD.Size = new System.Drawing.Size(200, 20);
            this.txtTEN_LYDO_TG_TSCD.TabIndex = 1;
            //
            //lblValue
            //
            this.lblValue.Location = new System.Drawing.Point(13, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(89, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Tên lý do TG TSCD";
            //
            //txtKY_HIEU
            //
            this.txtKY_HIEU.EnterMoveNextControl = true;
            this.txtKY_HIEU.Location = new System.Drawing.Point(119, 66);
            this.txtKY_HIEU.Name = "txtKY_HIEU";
            this.txtKY_HIEU.Size = new System.Drawing.Size(200, 20);
            this.txtKY_HIEU.TabIndex = 2;
            //
            //chkCO_SU_DUNG
            //
            this.chkCO_SU_DUNG.EditValue = true;
            this.chkCO_SU_DUNG.Location = new System.Drawing.Point(117, 118);
            this.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG";
            this.chkCO_SU_DUNG.Properties.Caption = "";
            this.chkCO_SU_DUNG.Size = new System.Drawing.Size(79, 19);
            this.chkCO_SU_DUNG.TabIndex = 4;
            //
            //LabelControl17
            //
            this.LabelControl17.Location = new System.Drawing.Point(67, 69);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(35, 13);
            this.LabelControl17.TabIndex = 6;
            this.LabelControl17.Text = "Ký hiệu";
            //
            //labelControl4
            //
            this.labelControl4.Location = new System.Drawing.Point(47, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Có sử dụng";
            //
            //lblCarFarmily_Code
            //
            this.lblCarFarmily_Code.Location = new System.Drawing.Point(17, 17);
            this.lblCarFarmily_Code.Name = "lblCarFarmily_Code";
            this.lblCarFarmily_Code.Size = new System.Drawing.Size(85, 13);
            this.lblCarFarmily_Code.TabIndex = 0;
            this.lblCarFarmily_Code.Text = "Mă lý do TG TSCD";
            //
            //_ActionPanel
            //
            this._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black;
            this._ActionPanel.Appearance.Options.UseForeColor = true;
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnCancel);
            this._ActionPanel.Controls.Add(this.btnClear);
            this._ActionPanel.Controls.Add(this.btnSave);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(6, 149);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(334, 40);
            this._ActionPanel.TabIndex = 1;
            //
            //btnCancel
            //
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(254, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ð&óng";
            //
            //btnClear
            //
            this.btnClear.ImageIndex = 32;
            this.btnClear.Location = new System.Drawing.Point(119, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Xóa trắng";
            this.btnClear.Visible = false;
            //
            //btnSave
            //
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(0, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            //
            //frmDanhMucLyDoTGTSCD_ChiTiet
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(346, 195);
            this.Controls.Add(this._GroupControlObjectInfo);
            this.Controls.Add(this._ActionPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhMucLyDoTGTSCD_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục lý do tăng giảm tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)this._GroupControlObjectInfo).EndInit();
            this._GroupControlObjectInfo.ResumeLayout(false);
            this._GroupControlObjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_LYDO_TG_TSCD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboLOAI_LG1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTEN_LYDO_TG_TSCD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtKY_HIEU.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.chkCO_SU_DUNG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this._ActionPanel).EndInit();
            this._ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.GroupControl _GroupControlObjectInfo;
        internal DevExpress.XtraEditors.LabelControl LabelControl17;
        internal DevExpress.XtraEditors.LabelControl lblCarFarmily_Code;
        private DevExpress.XtraEditors.CheckEdit chkCO_SU_DUNG;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKY_HIEU;
        private DevExpress.XtraEditors.TextEdit txtTEN_LYDO_TG_TSCD;
        internal DevExpress.XtraEditors.LabelControl lblValue;
        internal DevExpress.XtraEditors.LookUpEdit cboLOAI_LG1;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMA_LYDO_TG_TSCD;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnClear;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
    }
}