using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucLoaiTaiSan1_ChiTiet
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
            this._GroupControlObjectInfo = new DevExpress.XtraEditors.GroupControl();
            this.cboLOAITAISAN_ID_CHA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKy_Hieu = new DevExpress.XtraEditors.TextEdit();
            this.lblCarFarmily_Code = new DevExpress.XtraEditors.LabelControl();
            this.txtKHUNG_TGSD1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN_LOAITAISAN = new DevExpress.XtraEditors.TextEdit();
            this.chkCO_SU_DUNG = new DevExpress.XtraEditors.CheckEdit();
            this.chkCHO_PHEP_SUA = new DevExpress.XtraEditors.CheckEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblValue = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TenLoaitaisan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlObjectInfo)).BeginInit();
            this._GroupControlObjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLOAITAISAN_ID_CHA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKy_Hieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHUNG_TGSD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_LOAITAISAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCO_SU_DUNG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCHO_PHEP_SUA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _GroupControlObjectInfo
            // 
            this._GroupControlObjectInfo.Controls.Add(this.cboLOAITAISAN_ID_CHA);
            this._GroupControlObjectInfo.Controls.Add(this.labelControl1);
            this._GroupControlObjectInfo.Controls.Add(this.txtKy_Hieu);
            this._GroupControlObjectInfo.Controls.Add(this.lblCarFarmily_Code);
            this._GroupControlObjectInfo.Controls.Add(this.txtKHUNG_TGSD1);
            this._GroupControlObjectInfo.Controls.Add(this.txtTEN_LOAITAISAN);
            this._GroupControlObjectInfo.Controls.Add(this.chkCO_SU_DUNG);
            this._GroupControlObjectInfo.Controls.Add(this.chkCHO_PHEP_SUA);
            this._GroupControlObjectInfo.Controls.Add(this.LabelControl17);
            this._GroupControlObjectInfo.Controls.Add(this.labelControl4);
            this._GroupControlObjectInfo.Controls.Add(this.labelControl3);
            this._GroupControlObjectInfo.Controls.Add(this.lblValue);
            this._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GroupControlObjectInfo.Location = new System.Drawing.Point(4, 4);
            this._GroupControlObjectInfo.Name = "_GroupControlObjectInfo";
            this._GroupControlObjectInfo.ShowCaption = false;
            this._GroupControlObjectInfo.Size = new System.Drawing.Size(317, 116);
            this._GroupControlObjectInfo.TabIndex = 0;
            this._GroupControlObjectInfo.Text = "Thông tin Mã danh mục tự do 2";
            // 
            // cboLOAITAISAN_ID_CHA
            // 
            this.cboLOAITAISAN_ID_CHA.Location = new System.Drawing.Point(103, 62);
            this.cboLOAITAISAN_ID_CHA.Name = "cboLOAITAISAN_ID_CHA";
            this.cboLOAITAISAN_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboLOAITAISAN_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboLOAITAISAN_ID_CHA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLOAITAISAN_ID_CHA.Properties.NullText = "";
            this.cboLOAITAISAN_ID_CHA.Properties.View = this.GridLookUpEdit1View;
            this.cboLOAITAISAN_ID_CHA.Size = new System.Drawing.Size(200, 20);
            this.cboLOAITAISAN_ID_CHA.TabIndex = 100;
            // 
            // GridLookUpEdit1View
            // 
            this.GridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenLoaitaisan});
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Số năm sử dụng";
            // 
            // txtKy_Hieu
            // 
            this.txtKy_Hieu.EnterMoveNextControl = true;
            this.txtKy_Hieu.Location = new System.Drawing.Point(103, 9);
            this.txtKy_Hieu.Name = "txtKy_Hieu";
            this.txtKy_Hieu.Size = new System.Drawing.Size(200, 20);
            this.txtKy_Hieu.TabIndex = 0;
            // 
            // lblCarFarmily_Code
            // 
            this.lblCarFarmily_Code.Location = new System.Drawing.Point(51, 12);
            this.lblCarFarmily_Code.Name = "lblCarFarmily_Code";
            this.lblCarFarmily_Code.Size = new System.Drawing.Size(35, 13);
            this.lblCarFarmily_Code.TabIndex = 98;
            this.lblCarFarmily_Code.Text = "Ký hiệu";
            // 
            // txtKHUNG_TGSD1
            // 
            this.txtKHUNG_TGSD1.EnterMoveNextControl = true;
            this.txtKHUNG_TGSD1.Location = new System.Drawing.Point(103, 87);
            this.txtKHUNG_TGSD1.Name = "txtKHUNG_TGSD1";
            this.txtKHUNG_TGSD1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKHUNG_TGSD1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtKHUNG_TGSD1.Properties.Mask.EditMask = "n2";
            this.txtKHUNG_TGSD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKHUNG_TGSD1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtKHUNG_TGSD1.Size = new System.Drawing.Size(200, 20);
            this.txtKHUNG_TGSD1.TabIndex = 3;
            // 
            // txtTEN_LOAITAISAN
            // 
            this.txtTEN_LOAITAISAN.EnterMoveNextControl = true;
            this.txtTEN_LOAITAISAN.Location = new System.Drawing.Point(103, 35);
            this.txtTEN_LOAITAISAN.Name = "txtTEN_LOAITAISAN";
            this.txtTEN_LOAITAISAN.Size = new System.Drawing.Size(200, 20);
            this.txtTEN_LOAITAISAN.TabIndex = 1;
            // 
            // chkCO_SU_DUNG
            // 
            this.chkCO_SU_DUNG.EditValue = true;
            this.chkCO_SU_DUNG.Location = new System.Drawing.Point(101, 117);
            this.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG";
            this.chkCO_SU_DUNG.Properties.Caption = "";
            this.chkCO_SU_DUNG.Size = new System.Drawing.Size(23, 19);
            this.chkCO_SU_DUNG.TabIndex = 4;
            // 
            // chkCHO_PHEP_SUA
            // 
            this.chkCHO_PHEP_SUA.EditValue = true;
            this.chkCHO_PHEP_SUA.Location = new System.Drawing.Point(217, 117);
            this.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA";
            this.chkCHO_PHEP_SUA.Properties.Caption = "";
            this.chkCHO_PHEP_SUA.Size = new System.Drawing.Size(23, 19);
            this.chkCHO_PHEP_SUA.TabIndex = 5;
            // 
            // LabelControl17
            // 
            this.LabelControl17.Location = new System.Drawing.Point(19, 64);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(67, 13);
            this.LabelControl17.TabIndex = 97;
            this.LabelControl17.Text = "Danh mục cha";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 96;
            this.labelControl4.Text = "Có sử dụng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(140, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 95;
            this.labelControl3.Text = "Cho phép sửa";
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(11, 38);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(75, 13);
            this.lblValue.TabIndex = 94;
            this.lblValue.Text = "Tên loại tài sản ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(237, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ð&óng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.ImageIndex = 32;
            this.btnClear.Location = new System.Drawing.Point(118, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Xóa trắng";
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // _ActionPanel
            // 
            this._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black;
            this._ActionPanel.Appearance.Options.UseForeColor = true;
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnCancel);
            this._ActionPanel.Controls.Add(this.btnClear);
            this._ActionPanel.Controls.Add(this.btnSave);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(4, 120);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(317, 38);
            this._ActionPanel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(0, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TenLoaitaisan
            // 
            this.TenLoaitaisan.Caption = "Tên loại tài sản";
            this.TenLoaitaisan.FieldName = "TenLoaitaisan";
            this.TenLoaitaisan.Name = "TenLoaitaisan";
            this.TenLoaitaisan.Visible = true;
            this.TenLoaitaisan.VisibleIndex = 0;
            // 
            // frmDanhMucLoaiTaiSan1_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 162);
            this.Controls.Add(this._GroupControlObjectInfo);
            this.Controls.Add(this._ActionPanel);
            this.KeyPreview = true;
            this.Name = "frmDanhMucLoaiTaiSan1_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục tự do 1";
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlObjectInfo)).EndInit();
            this._GroupControlObjectInfo.ResumeLayout(false);
            this._GroupControlObjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLOAITAISAN_ID_CHA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKy_Hieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHUNG_TGSD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_LOAITAISAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCO_SU_DUNG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCHO_PHEP_SUA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl _GroupControlObjectInfo;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnClear;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKy_Hieu;
        internal DevExpress.XtraEditors.LabelControl lblCarFarmily_Code;
        private DevExpress.XtraEditors.TextEdit txtTEN_LOAITAISAN;
        private DevExpress.XtraEditors.CheckEdit chkCO_SU_DUNG;
        private DevExpress.XtraEditors.CheckEdit chkCHO_PHEP_SUA;
        internal DevExpress.XtraEditors.LabelControl LabelControl17;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        internal DevExpress.XtraEditors.LabelControl labelControl3;
        internal DevExpress.XtraEditors.LabelControl lblValue;
        private DevExpress.XtraEditors.TextEdit txtKHUNG_TGSD1;
        internal DevExpress.XtraEditors.GridLookUpEdit cboLOAITAISAN_ID_CHA;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LOAITAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn TenLoaitaisan;
        //public frmDanhMucLoaiTaiSan1_ChiTiet()
        //{
        //    InitializeComponent();
        //}
    }
}