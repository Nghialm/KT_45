using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmKhaiBaoGiamCCDC_ChiTiet : DevExpress.XtraEditors.XtraForm
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
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoCt = new DevExpress.XtraEditors.TextEdit();
            this.dteNgayHetPb = new DevExpress.XtraEditors.DateEdit();
            this.dteNgayGiam = new DevExpress.XtraEditors.DateEdit();
            this.grlMaGiam = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenMaGiam = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grlMaCCDC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenCCDC = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHetPb.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHetPb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayGiam.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMaGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMaCCDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.txtGhiChu);
            this.GroupControl1.Controls.Add(this.txtSoCt);
            this.GroupControl1.Controls.Add(this.dteNgayHetPb);
            this.GroupControl1.Controls.Add(this.dteNgayGiam);
            this.GroupControl1.Controls.Add(this.grlMaGiam);
            this.GroupControl1.Controls.Add(this.LabelControl8);
            this.GroupControl1.Controls.Add(this.lblTenMaGiam);
            this.GroupControl1.Controls.Add(this.LabelControl7);
            this.GroupControl1.Controls.Add(this.LabelControl6);
            this.GroupControl1.Controls.Add(this.grlMaCCDC);
            this.GroupControl1.Controls.Add(this.LabelControl5);
            this.GroupControl1.Controls.Add(this.LabelControl3);
            this.GroupControl1.Controls.Add(this.lblTenCCDC);
            this.GroupControl1.Controls.Add(this.LabelControl1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.ShowCaption = false;
            this.GroupControl1.Size = new System.Drawing.Size(530, 167);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "GroupControl1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.EnterMoveNextControl = true;
            this.txtGhiChu.Location = new System.Drawing.Point(96, 140);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(427, 20);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtSoCt
            // 
            this.txtSoCt.EnterMoveNextControl = true;
            this.txtSoCt.Location = new System.Drawing.Point(96, 114);
            this.txtSoCt.Name = "txtSoCt";
            this.txtSoCt.Size = new System.Drawing.Size(134, 20);
            this.txtSoCt.TabIndex = 6;
            // 
            // dteNgayHetPb
            // 
            this.dteNgayHetPb.EditValue = null;
            this.dteNgayHetPb.EnterMoveNextControl = true;
            this.dteNgayHetPb.Location = new System.Drawing.Point(96, 87);
            this.dteNgayHetPb.Name = "dteNgayHetPb";
            this.dteNgayHetPb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayHetPb.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgayHetPb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNgayHetPb.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNgayHetPb.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgayHetPb.Size = new System.Drawing.Size(134, 20);
            this.dteNgayHetPb.TabIndex = 5;
            // 
            // dteNgayGiam
            // 
            this.dteNgayGiam.EditValue = null;
            this.dteNgayGiam.EnterMoveNextControl = true;
            this.dteNgayGiam.Location = new System.Drawing.Point(96, 61);
            this.dteNgayGiam.Name = "dteNgayGiam";
            this.dteNgayGiam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayGiam.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgayGiam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNgayGiam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNgayGiam.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgayGiam.Size = new System.Drawing.Size(134, 20);
            this.dteNgayGiam.TabIndex = 4;
            // 
            // grlMaGiam
            // 
            this.grlMaGiam.EnterMoveNextControl = true;
            this.grlMaGiam.Location = new System.Drawing.Point(96, 34);
            this.grlMaGiam.Name = "grlMaGiam";
            this.grlMaGiam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlMaGiam.Properties.NullText = "";
            this.grlMaGiam.Properties.View = this.GridView1;
            this.grlMaGiam.Size = new System.Drawing.Size(134, 20);
            this.grlMaGiam.TabIndex = 2;
            // 
            // GridView1
            // 
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn3,
            this.GridColumn4});
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(55, 143);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(35, 13);
            this.LabelControl8.TabIndex = 0;
            this.LabelControl8.Text = "Ghi chú";
            // 
            // lblTenMaGiam
            // 
            this.lblTenMaGiam.Location = new System.Drawing.Point(236, 38);
            this.lblTenMaGiam.Name = "lblTenMaGiam";
            this.lblTenMaGiam.Size = new System.Drawing.Size(0, 13);
            this.lblTenMaGiam.TabIndex = 3;
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(53, 117);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(37, 13);
            this.LabelControl7.TabIndex = 0;
            this.LabelControl7.Text = "Số C.từ";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(8, 90);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(82, 13);
            this.LabelControl6.TabIndex = 0;
            this.LabelControl6.Text = "Ngày kết thúc Pb";
            // 
            // grlMaCCDC
            // 
            this.grlMaCCDC.EnterMoveNextControl = true;
            this.grlMaCCDC.Location = new System.Drawing.Point(96, 8);
            this.grlMaCCDC.Name = "grlMaCCDC";
            this.grlMaCCDC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlMaCCDC.Properties.NullText = "";
            this.grlMaCCDC.Properties.View = this.GridLookUpEdit1View;
            this.grlMaCCDC.Size = new System.Drawing.Size(134, 20);
            this.grlMaCCDC.TabIndex = 0;
            // 
            // GridLookUpEdit1View
            // 
            this.GridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2});
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(40, 64);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(50, 13);
            this.LabelControl5.TabIndex = 0;
            this.LabelControl5.Text = "Ngày giảm";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(39, 38);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(51, 13);
            this.LabelControl3.TabIndex = 0;
            this.LabelControl3.Text = "Lý do giảm";
            // 
            // lblTenCCDC
            // 
            this.lblTenCCDC.Location = new System.Drawing.Point(236, 12);
            this.lblTenCCDC.Name = "lblTenCCDC";
            this.lblTenCCDC.Size = new System.Drawing.Size(0, 13);
            this.lblTenCCDC.TabIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(45, 12);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(45, 13);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Mã CCDC";
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnQuit);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 171);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(530, 34);
            this.PanelControl1.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(86, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Hủy bỏ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Xác nhận";
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.Location = new System.Drawing.Point(0, 3);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(80, 30);
            this.SimpleButton1.TabIndex = 0;
            this.SimpleButton1.Text = "&Xác nhận";
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Mã lý do";
            this.GridColumn3.FieldName = "MaLydoTgTscd";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 0;
            // 
            // GridColumn4
            // 
            this.GridColumn4.Caption = "Tên lý do ";
            this.GridColumn4.FieldName = "TenLydoTgTscd";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 1;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Mã CCDC";
            this.GridColumn1.FieldName = "MaCcdc";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Tên CCDC";
            this.GridColumn2.FieldName = "TenCcdc";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            // 
            // frmKhaiBaoGiamCCDC_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 209);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.Name = "frmKhaiBaoGiamCCDC_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Khai báo giảm CCDC";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHetPb.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHetPb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayGiam.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMaGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMaCCDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnQuit;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.GridLookUpEdit grlMaCCDC;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraEditors.TextEdit txtGhiChu;
        internal DevExpress.XtraEditors.TextEdit txtSoCt;
        internal DevExpress.XtraEditors.DateEdit dteNgayHetPb;
        internal DevExpress.XtraEditors.DateEdit dteNgayGiam;
        internal DevExpress.XtraEditors.GridLookUpEdit grlMaGiam;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal DevExpress.XtraEditors.LabelControl lblTenMaGiam;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl lblTenCCDC;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
    }
}