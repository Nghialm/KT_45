using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDieuChuyenTaiSan_ChiTiet : DevExpress.XtraEditors.XtraForm
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
            this.txtLY_DO_DC = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAY_DC = new DevExpress.XtraEditors.DateEdit();
            this.grlPHONG_BAN_DC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPHONG_BAN_HT = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGAY_MUA = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTS = new DevExpress.XtraEditors.TextEdit();
            this.txtMA_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtLY_DO_DC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_DC.Properties.VistaTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_DC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grlPHONG_BAN_DC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtPHONG_BAN_HT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_MUA.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_TSCD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            //
            //GroupControl1
            //
            this.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GroupControl1.Controls.Add(this.txtLY_DO_DC);
            this.GroupControl1.Controls.Add(this.dteNGAY_DC);
            this.GroupControl1.Controls.Add(this.grlPHONG_BAN_DC);
            this.GroupControl1.Controls.Add(this.txtPHONG_BAN_HT);
            this.GroupControl1.Controls.Add(this.LabelControl6);
            this.GroupControl1.Controls.Add(this.txtNGAY_MUA);
            this.GroupControl1.Controls.Add(this.LabelControl2);
            this.GroupControl1.Controls.Add(this.LabelControl5);
            this.GroupControl1.Controls.Add(this.txtTenTS);
            this.GroupControl1.Controls.Add(this.txtMA_TSCD);
            this.GroupControl1.Controls.Add(this.LabelControl4);
            this.GroupControl1.Controls.Add(this.LabelControl3);
            this.GroupControl1.Controls.Add(this.LabelControl1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.ShowCaption = false;
            this.GroupControl1.Size = new System.Drawing.Size(573, 123);
            this.GroupControl1.TabIndex = 0;
            //
            //txtLY_DO_DC
            //
            this.txtLY_DO_DC.EnterMoveNextControl = true;
            this.txtLY_DO_DC.Location = new System.Drawing.Point(127, 92);
            this.txtLY_DO_DC.Name = "txtLY_DO_DC";
            this.txtLY_DO_DC.Size = new System.Drawing.Size(434, 20);
            this.txtLY_DO_DC.TabIndex = 5;
            //
            //dteNGAY_DC
            //
            this.dteNGAY_DC.EditValue = null;
            this.dteNGAY_DC.EnterMoveNextControl = true;
            this.dteNGAY_DC.Location = new System.Drawing.Point(127, 65);
            this.dteNGAY_DC.Name = "dteNGAY_DC";
            this.dteNGAY_DC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dteNGAY_DC.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_DC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_DC.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_DC.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_DC.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            this.dteNGAY_DC.Size = new System.Drawing.Size(112, 20);
            this.dteNGAY_DC.TabIndex = 2;
            //
            //grlPHONG_BAN_DC
            //
            this.grlPHONG_BAN_DC.EnterMoveNextControl = true;
            this.grlPHONG_BAN_DC.Location = new System.Drawing.Point(384, 66);
            this.grlPHONG_BAN_DC.Name = "grlPHONG_BAN_DC";
            this.grlPHONG_BAN_DC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.grlPHONG_BAN_DC.Properties.NullText = "";
            this.grlPHONG_BAN_DC.Properties.View = this.GridLookUpEdit1View;
            this.grlPHONG_BAN_DC.Size = new System.Drawing.Size(177, 20);
            this.grlPHONG_BAN_DC.TabIndex = 4;
            //
            //GridLookUpEdit1View
            //
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            //
            //txtPHONG_BAN_HT
            //
            this.txtPHONG_BAN_HT.EnterMoveNextControl = true;
            this.txtPHONG_BAN_HT.Location = new System.Drawing.Point(384, 39);
            this.txtPHONG_BAN_HT.Name = "txtPHONG_BAN_HT";
            this.txtPHONG_BAN_HT.Properties.ReadOnly = true;
            this.txtPHONG_BAN_HT.Size = new System.Drawing.Size(177, 20);
            this.txtPHONG_BAN_HT.TabIndex = 3;
            //
            //LabelControl6
            //
            this.LabelControl6.Location = new System.Drawing.Point(12, 99);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(87, 13);
            this.LabelControl6.TabIndex = 2;
            this.LabelControl6.Text = "Lý do điều chuyển";
            //
            //txtNGAY_MUA
            //
            this.txtNGAY_MUA.EnterMoveNextControl = true;
            this.txtNGAY_MUA.Location = new System.Drawing.Point(127, 39);
            this.txtNGAY_MUA.Name = "txtNGAY_MUA";
            this.txtNGAY_MUA.Properties.ReadOnly = true;
            this.txtNGAY_MUA.Size = new System.Drawing.Size(112, 20);
            this.txtNGAY_MUA.TabIndex = 1;
            //
            //LabelControl2
            //
            this.LabelControl2.Location = new System.Drawing.Point(13, 69);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(86, 13);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Ngày điều chuyển";
            //
            //LabelControl5
            //
            this.LabelControl5.Location = new System.Drawing.Point(266, 68);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(112, 13);
            this.LabelControl5.TabIndex = 2;
            this.LabelControl5.Text = "Phòng ban điều chuyển";
            //
            //txtTenTS
            //
            this.txtTenTS.EnterMoveNextControl = true;
            this.txtTenTS.Location = new System.Drawing.Point(245, 11);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Properties.ReadOnly = true;
            this.txtTenTS.Size = new System.Drawing.Size(318, 20);
            this.txtTenTS.TabIndex = 0;
            this.txtTenTS.TabStop = false;
            //
            //txtMA_TSCD
            //
            this.txtMA_TSCD.EnterMoveNextControl = true;
            this.txtMA_TSCD.Location = new System.Drawing.Point(127, 11);
            this.txtMA_TSCD.Name = "txtMA_TSCD";
            this.txtMA_TSCD.Properties.ReadOnly = true;
            this.txtMA_TSCD.Size = new System.Drawing.Size(112, 20);
            this.txtMA_TSCD.TabIndex = 0;
            //
            //LabelControl4
            //
            this.LabelControl4.Location = new System.Drawing.Point(289, 42);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(89, 13);
            this.LabelControl4.TabIndex = 2;
            this.LabelControl4.Text = "Phòng ban hiện tại";
            //
            //LabelControl3
            //
            this.LabelControl3.Location = new System.Drawing.Point(51, 42);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(48, 13);
            this.LabelControl3.TabIndex = 2;
            this.LabelControl3.Text = "Ngày mua";
            //
            //LabelControl1
            //
            this.LabelControl1.Location = new System.Drawing.Point(50, 14);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(49, 13);
            this.LabelControl1.TabIndex = 2;
            this.LabelControl1.Text = "Mã tài sản";
            //
            //PanelControl1
            //
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnCancel);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 127);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(573, 34);
            this.PanelControl1.TabIndex = 1;
            //
            //btnCancel
            //
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(492, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ð&óng";
            //
            //btnSave
            //
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            //
            //frmDieuChuyenTaiSan_ChiTiet
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 165);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "frmDieuChuyenTaiSan_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "frmDieuChuyenTaiSan_ChiTiet";
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtLY_DO_DC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_DC.Properties.VistaTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_DC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grlPHONG_BAN_DC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtPHONG_BAN_HT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_MUA.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_TSCD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlPHONG_BAN_DC;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraEditors.TextEdit txtPHONG_BAN_HT;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.TextEdit txtNGAY_MUA;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.TextEdit txtMA_TSCD;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_DC;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtTenTS;
        internal DevExpress.XtraEditors.TextEdit txtLY_DO_DC;
    }
}