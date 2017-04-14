using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucNguonVon_tscd_DanhSach
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
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._GridControl = new DevExpress.XtraGrid.GridControl();
            this._GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDmNguonTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDmNguonTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChoPhepSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._GroupControlSearch = new DevExpress.XtraEditors.GroupControl();
            this._FieldChooser = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._SearchHelper = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btExport = new Vns.Erp.Core.MultiExportButton();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).BeginInit();
            this._GroupControlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this._GridControl);
            this.PanelControl1.Controls.Add(this._GroupControlSearch);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(950, 457);
            this.PanelControl1.TabIndex = 2;
            // 
            // _GridControl
            // 
            this._GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridControl.Location = new System.Drawing.Point(2, 57);
            this._GridControl.MainView = this._GridView;
            this._GridControl.Name = "_GridControl";
            this._GridControl.Size = new System.Drawing.Size(946, 398);
            this._GridControl.TabIndex = 1;
            this._GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._GridView,
            this.GridView1});
            // 
            // _GridView
            // 
            this._GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDmNguonTscd,
            this.KyHieu,
            this.TenDmNguonTscd,
            this.MoTa,
            this.CoSuDung,
            this.ChoPhepSua});
            this._GridView.GridControl = this._GridControl;
            this._GridView.Name = "_GridView";
            this._GridView.OptionsBehavior.Editable = false;
            this._GridView.OptionsView.ShowAutoFilterRow = true;
            this._GridView.OptionsView.ShowGroupPanel = false;
            // 
            // MaDmNguonTscd
            // 
            this.MaDmNguonTscd.Caption = "Mã nguồn vốn TSCD";
            this.MaDmNguonTscd.FieldName = "MaDmNguonTscd";
            this.MaDmNguonTscd.Name = "MaDmNguonTscd";
            this.MaDmNguonTscd.OptionsColumn.ReadOnly = true;
            this.MaDmNguonTscd.Visible = true;
            this.MaDmNguonTscd.VisibleIndex = 0;
            this.MaDmNguonTscd.Width = 100;
            // 
            // KyHieu
            // 
            this.KyHieu.Caption = "Ký hiệu";
            this.KyHieu.FieldName = "KyHieu";
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.OptionsColumn.ReadOnly = true;
            this.KyHieu.Visible = true;
            this.KyHieu.VisibleIndex = 1;
            this.KyHieu.Width = 100;
            // 
            // TenDmNguonTscd
            // 
            this.TenDmNguonTscd.Caption = "Tên nguồn vốn TSCD";
            this.TenDmNguonTscd.FieldName = "TenDmNguonTscd";
            this.TenDmNguonTscd.Name = "TenDmNguonTscd";
            this.TenDmNguonTscd.OptionsColumn.ReadOnly = true;
            this.TenDmNguonTscd.Visible = true;
            this.TenDmNguonTscd.VisibleIndex = 2;
            this.TenDmNguonTscd.Width = 100;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Mô tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.OptionsColumn.ReadOnly = true;
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 3;
            this.MoTa.Width = 100;
            // 
            // CoSuDung
            // 
            this.CoSuDung.Caption = "Có sử dụng";
            this.CoSuDung.FieldName = "CoSuDung";
            this.CoSuDung.Name = "CoSuDung";
            this.CoSuDung.OptionsColumn.ReadOnly = true;
            this.CoSuDung.Visible = true;
            this.CoSuDung.VisibleIndex = 4;
            this.CoSuDung.Width = 100;
            // 
            // ChoPhepSua
            // 
            this.ChoPhepSua.Caption = "Cho phép sửa";
            this.ChoPhepSua.FieldName = "ChoPhepSua";
            this.ChoPhepSua.Name = "ChoPhepSua";
            this.ChoPhepSua.OptionsColumn.ReadOnly = true;
            this.ChoPhepSua.Visible = true;
            this.ChoPhepSua.VisibleIndex = 5;
            this.ChoPhepSua.Width = 152;
            // 
            // GridView1
            // 
            this.GridView1.GridControl = this._GridControl;
            this.GridView1.Name = "GridView1";
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
            this._GroupControlSearch.Location = new System.Drawing.Point(2, 2);
            this._GroupControlSearch.Name = "_GroupControlSearch";
            this._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._GroupControlSearch.Size = new System.Drawing.Size(946, 55);
            this._GroupControlSearch.TabIndex = 2;
            this._GroupControlSearch.Text = "Tìm kiếm";
            this._GroupControlSearch.Visible = false;
            // 
            // _FieldChooser
            // 
            this._FieldChooser.EditValue = "";
            this._FieldChooser.Location = new System.Drawing.Point(84, 25);
            this._FieldChooser.Name = "_FieldChooser";
            this._FieldChooser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._FieldChooser.Properties.ImmediatePopup = true;
            this._FieldChooser.Properties.NullText = "";
            this._FieldChooser.Properties.View = this.GridView2;
            this._FieldChooser.Size = new System.Drawing.Size(141, 20);
            this._FieldChooser.TabIndex = 0;
            // 
            // GridView2
            // 
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // _SearchHelper
            // 
            this._SearchHelper.EditValue = "";
            this._SearchHelper.Location = new System.Drawing.Point(280, 25);
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
            this.labelControl2.Location = new System.Drawing.Point(242, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Giá trị";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tím kiếm theo";
            // 
            // _ActionPanel
            // 
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btExport);
            this._ActionPanel.Controls.Add(this.btnPri);
            this._ActionPanel.Controls.Add(this.btnClose);
            this._ActionPanel.Controls.Add(this.btnModify);
            this._ActionPanel.Controls.Add(this.btnCreate);
            this._ActionPanel.Controls.Add(this.btnDelete);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(0, 457);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(950, 34);
            this._ActionPanel.TabIndex = 3;
            // 
            // btExport
            // 
            this.btExport.GRID_VIEW = this._GridView;
            this.btExport.Location = new System.Drawing.Point(261, 3);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(135, 30);
            this.btExport.TabIndex = 11;
            this.btExport.Visible = false;
            // 
            // btnPri
            // 
            this.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPri.ImageIndex = 5;
            this.btnPri.Location = new System.Drawing.Point(530, 3);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(80, 30);
            this.btnPri.TabIndex = 7;
            this.btnPri.Text = "&In";
            this.btnPri.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 6;
            this.btnClose.Location = new System.Drawing.Point(869, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Ðó&ng";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.ImageIndex = 3;
            this.btnModify.Location = new System.Drawing.Point(88, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Sửa";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.Location = new System.Drawing.Point(2, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Mới";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(175, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            // 
            // frmDanhMucNguonVon_tscd_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(950, 491);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this._ActionPanel);
            this.KeyPreview = true;
            this.Name = "frmDanhMucNguonVon_tscd_DanhSach";
            this.Text = "Danh mục nguồn vốn tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).EndInit();
            this._GroupControlSearch.ResumeLayout(false);
            this._GroupControlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraGrid.GridControl _GridControl;
        internal DevExpress.XtraGrid.Views.Grid.GridView _GridView;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_DM_NGUON_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_DM_NGUON_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU;
        internal DevExpress.XtraGrid.Columns.GridColumn MO_TA;
        internal DevExpress.XtraGrid.Columns.GridColumn CO_SU_DUNG;
        internal DevExpress.XtraGrid.Columns.GridColumn CHO_PHEP_SUA;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnPri;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnCreate;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.GroupControl _GroupControlSearch;
        private DevExpress.XtraEditors.GridLookUpEdit _FieldChooser;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        private DevExpress.XtraEditors.GridLookUpEdit _SearchHelper;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal MultiExportButton btExport;
        internal DevExpress.XtraGrid.Columns.GridColumn MaDmNguonTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn KyHieu;
        internal DevExpress.XtraGrid.Columns.GridColumn TenDmNguonTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn MoTa;
        internal DevExpress.XtraGrid.Columns.GridColumn CoSuDung;
        internal DevExpress.XtraGrid.Columns.GridColumn ChoPhepSua;
        //public frmDanhMucNguonVon_tscd_DanhSach()
        //{
        //    InitializeComponent();
        //}
    }
}