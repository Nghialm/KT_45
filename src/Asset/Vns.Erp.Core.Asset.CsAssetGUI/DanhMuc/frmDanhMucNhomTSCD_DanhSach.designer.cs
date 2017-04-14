using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucNhomTSCD_DanhSach : FrmBaseDmDanhSach
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
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btExport = new Vns.Erp.Core.MultiExportButton();
            this._GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhomTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhomTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this._GridControl = new DevExpress.XtraGrid.GridControl();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this._GroupControlSearch = new DevExpress.XtraEditors.GroupControl();
            this._FieldChooser = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._SearchHelper = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).BeginInit();
            this._GroupControlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.ImageIndex = 3;
            this.btnModify.Location = new System.Drawing.Point(88, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Sửa";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.Location = new System.Drawing.Point(2, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 6;
            this.btnClose.Location = new System.Drawing.Point(919, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Ð&óng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // _ActionPanel
            // 
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnDelete);
            this._ActionPanel.Controls.Add(this.btExport);
            this._ActionPanel.Controls.Add(this.btnPri);
            this._ActionPanel.Controls.Add(this.btnClose);
            this._ActionPanel.Controls.Add(this.btnCreate);
            this._ActionPanel.Controls.Add(this.btnModify);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(4, 574);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(1000, 34);
            this._ActionPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(174, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btExport
            // 
            this.btExport.GRID_VIEW = this._GridView;
            this.btExport.Location = new System.Drawing.Point(259, 4);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(135, 30);
            this.btExport.TabIndex = 11;
            this.btExport.Visible = false;
            this.btExport.Load += new System.EventHandler(this.btExport_Load);
            // 
            // _GridView
            // 
            this._GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.MaNhomTscd,
            this.TenNhomTscd,
            this.LoaiNhom,
            this.GridColumn1});
            this._GridView.GridControl = this._GridControl;
            this._GridView.Name = "_GridView";
            this._GridView.OptionsView.ShowAutoFilterRow = true;
            this._GridView.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "GridColumn2";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.ReadOnly = true;
            // 
            // MaNhomTscd
            // 
            this.MaNhomTscd.Caption = "Mã nhóm TSCD";
            this.MaNhomTscd.FieldName = "MaNhomTscd";
            this.MaNhomTscd.Name = "MaNhomTscd";
            this.MaNhomTscd.OptionsColumn.FixedWidth = true;
            this.MaNhomTscd.OptionsColumn.ReadOnly = true;
            this.MaNhomTscd.Visible = true;
            this.MaNhomTscd.VisibleIndex = 0;
            this.MaNhomTscd.Width = 106;
            // 
            // TenNhomTscd
            // 
            this.TenNhomTscd.Caption = "Tên nhóm TSCD";
            this.TenNhomTscd.FieldName = "TenNhomTscd";
            this.TenNhomTscd.Name = "TenNhomTscd";
            this.TenNhomTscd.OptionsColumn.FixedWidth = true;
            this.TenNhomTscd.OptionsColumn.ReadOnly = true;
            this.TenNhomTscd.Visible = true;
            this.TenNhomTscd.VisibleIndex = 1;
            this.TenNhomTscd.Width = 173;
            // 
            // LoaiNhom
            // 
            this.LoaiNhom.Caption = "Loại nhóm";
            this.LoaiNhom.FieldName = "LoaiNhom";
            this.LoaiNhom.Name = "LoaiNhom";
            this.LoaiNhom.OptionsColumn.FixedWidth = true;
            this.LoaiNhom.OptionsColumn.ReadOnly = true;
            this.LoaiNhom.Visible = true;
            this.LoaiNhom.VisibleIndex = 2;
            this.LoaiNhom.Width = 125;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 3;
            this.GridColumn1.Width = 575;
            // 
            // _GridControl
            // 
            this._GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridControl.Location = new System.Drawing.Point(0, 0);
            this._GridControl.MainView = this._GridView;
            this._GridControl.Name = "_GridControl";
            this._GridControl.Size = new System.Drawing.Size(1000, 501);
            this._GridControl.TabIndex = 25;
            this._GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._GridView});
            // 
            // btnPri
            // 
            this.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPri.ImageIndex = 5;
            this.btnPri.Location = new System.Drawing.Point(575, 4);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(80, 30);
            this.btnPri.TabIndex = 8;
            this.btnPri.Text = "&In";
            this.btnPri.Visible = false;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // _GroupControlSearch
            // 
            this._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White;
            this._GroupControlSearch.Appearance.Options.UseBackColor = true;
            this._GroupControlSearch.Appearance.Options.UseBorderColor = true;
            this._GroupControlSearch.Controls.Add(this._FieldChooser);
            this._GroupControlSearch.Controls.Add(this._SearchHelper);
            this._GroupControlSearch.Controls.Add(this.labelControl2);
            this._GroupControlSearch.Controls.Add(this.labelControl1);
            this._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this._GroupControlSearch.Location = new System.Drawing.Point(4, 4);
            this._GroupControlSearch.Name = "_GroupControlSearch";
            this._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._GroupControlSearch.Size = new System.Drawing.Size(1000, 69);
            this._GroupControlSearch.TabIndex = 25;
            this._GroupControlSearch.Text = "Tìm kiếm";
            this._GroupControlSearch.Visible = false;
            // 
            // _FieldChooser
            // 
            this._FieldChooser.EditValue = "";
            this._FieldChooser.Location = new System.Drawing.Point(83, 32);
            this._FieldChooser.Name = "_FieldChooser";
            this._FieldChooser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._FieldChooser.Properties.ImmediatePopup = true;
            this._FieldChooser.Properties.NullText = "";
            this._FieldChooser.Properties.View = this.gridView1;
            this._FieldChooser.Size = new System.Drawing.Size(115, 20);
            this._FieldChooser.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // _SearchHelper
            // 
            this._SearchHelper.EditValue = "";
            this._SearchHelper.Location = new System.Drawing.Point(270, 32);
            this._SearchHelper.Name = "_SearchHelper";
            this._SearchHelper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._SearchHelper.Properties.ImmediatePopup = true;
            this._SearchHelper.Properties.NullText = "";
            this._SearchHelper.Properties.View = this.gridLookUpEdit1View;
            this._SearchHelper.Size = new System.Drawing.Size(141, 20);
            this._SearchHelper.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(236, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Giá trị";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tìm kiếm theo";
            // 
            // GroupControl1
            // 
            this.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GroupControl1.Controls.Add(this._GridControl);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 73);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1000, 501);
            this.GroupControl1.TabIndex = 26;
            this.GroupControl1.Text = "GroupControl1";
            // 
            // frmDanhMucNhomTSCD_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this._GroupControlSearch);
            this.Controls.Add(this._ActionPanel);
            this.KeyPreview = true;
            this.Name = "frmDanhMucNhomTSCD_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Danh mục nhóm tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).EndInit();
            this._GroupControlSearch.ResumeLayout(false);
            this._GroupControlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnCreate;
        //Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnPri;
        internal DevExpress.XtraEditors.GroupControl _GroupControlSearch;
        private DevExpress.XtraEditors.GridLookUpEdit _FieldChooser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit _SearchHelper;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl _GridControl;
        internal DevExpress.XtraGrid.Views.Grid.GridView _GridView;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_NHOM_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_NHOM_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn LOAI_NHOM;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_NHOM_TSCD;
        internal MultiExportButton btExport;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraGrid.Columns.GridColumn Id;
        internal DevExpress.XtraGrid.Columns.GridColumn MaNhomTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn TenNhomTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn LoaiNhom;
        //public frmDanhMucNhomTSCD_DanhSach()
        //{
        //    InitializeComponent();
        //}
    }

}