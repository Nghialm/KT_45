using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmKhaiBaoGiamCCDC_DanhSach : DevExpress.XtraEditors.XtraForm
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
            this._gridControl = new DevExpress.XtraGrid.GridControl();
            this._gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this._gridControl);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.ShowCaption = false;
            this.GroupControl1.Size = new System.Drawing.Size(1000, 570);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "GroupControl1";
            // 
            // _gridControl
            // 
            this._gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridControl.Location = new System.Drawing.Point(2, 2);
            this._gridControl.MainView = this._gridView;
            this._gridControl.Name = "_gridControl";
            this._gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemDateEdit1});
            this._gridControl.Size = new System.Drawing.Size(996, 566);
            this._gridControl.TabIndex = 0;
            this._gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gridView});
            // 
            // _gridView
            // 
            this._gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2,
            this.GridColumn3,
            this.GridColumn4,
            this.GridColumn5,
            this.GridColumn6,
            this.GridColumn7});
            this._gridView.GridControl = this._gridControl;
            this._gridView.Name = "_gridView";
            this._gridView.OptionsView.ShowAutoFilterRow = true;
            this._gridView.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Mã CCDC";
            this.GridColumn1.FieldName = "MaCcdc";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.AllowEdit = false;
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 107;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Tên CCDC";
            this.GridColumn2.FieldName = "TenCcdc";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.AllowEdit = false;
            this.GridColumn2.OptionsColumn.ReadOnly = true;
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            this.GridColumn2.Width = 196;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Ngày giảm";
            this.GridColumn3.FieldName = "NgayGiam";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.OptionsColumn.AllowEdit = false;
            this.GridColumn3.OptionsColumn.ReadOnly = true;
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 2;
            this.GridColumn3.Width = 102;
            // 
            // GridColumn4
            // 
            this.GridColumn4.Caption = "Mã giảm CCDC";
            this.GridColumn4.FieldName = "TenLydoTgCcdc";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.OptionsColumn.AllowEdit = false;
            this.GridColumn4.OptionsColumn.ReadOnly = true;
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 3;
            this.GridColumn4.Width = 104;
            // 
            // GridColumn5
            // 
            this.GridColumn5.Caption = "Ngày kết thúc";
            this.GridColumn5.FieldName = "NgayGiam";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.OptionsColumn.AllowEdit = false;
            this.GridColumn5.OptionsColumn.ReadOnly = true;
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 4;
            this.GridColumn5.Width = 109;
            // 
            // GridColumn6
            // 
            this.GridColumn6.Caption = "Số C.từ";
            this.GridColumn6.FieldName = "SoCt";
            this.GridColumn6.Name = "GridColumn6";
            this.GridColumn6.OptionsColumn.AllowEdit = false;
            this.GridColumn6.OptionsColumn.ReadOnly = true;
            this.GridColumn6.Visible = true;
            this.GridColumn6.VisibleIndex = 5;
            this.GridColumn6.Width = 102;
            // 
            // GridColumn7
            // 
            this.GridColumn7.Caption = "Ghi chú";
            this.GridColumn7.FieldName = "GhiChu";
            this.GridColumn7.Name = "GridColumn7";
            this.GridColumn7.OptionsColumn.AllowEdit = false;
            this.GridColumn7.OptionsColumn.ReadOnly = true;
            this.GridColumn7.Visible = true;
            this.GridColumn7.VisibleIndex = 6;
            this.GridColumn7.Width = 260;
            // 
            // RepositoryItemDateEdit1
            // 
            this.RepositoryItemDateEdit1.AutoHeight = false;
            this.RepositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1";
            this.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Controls.Add(this.btnDelete);
            this.PanelControl1.Controls.Add(this.btnModify);
            this.PanelControl1.Controls.Add(this.btnAdd);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 574);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1000, 34);
            this.PanelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(920, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Đóng";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(172, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(86, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Sửa";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            // 
            // frmKhaiBaoGiamCCDC_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.Name = "frmKhaiBaoGiamCCDC_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Khai báo giảm CCDC";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl _gridControl;
        internal DevExpress.XtraGrid.Views.Grid.GridView _gridView;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit1;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
    }
}