using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDanhMucLoaiTaiSan1_DanhSach : DevExpress.XtraEditors.XtraForm
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
            this._GroupControlList = new DevExpress.XtraEditors.GroupControl();
            this._TreeList = new DevExpress.XtraTreeList.TreeList();
            this.lkeCoSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btExport = new Vns.Erp.Core.MultiExportButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this._FieldChooser = new DevExpress.XtraEditors.GridLookUpEdit();
            this._FieldChooserView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._SearchHelper = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._GroupControlSearch = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlList)).BeginInit();
            this._GroupControlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCoSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooserView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).BeginInit();
            this._GroupControlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // _GroupControlList
            // 
            this._GroupControlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._GroupControlList.Controls.Add(this._TreeList);
            this._GroupControlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GroupControlList.Location = new System.Drawing.Point(4, 54);
            this._GroupControlList.Name = "_GroupControlList";
            this._GroupControlList.Size = new System.Drawing.Size(1000, 520);
            this._GroupControlList.TabIndex = 16;
            this._GroupControlList.Text = "Danh sách...";
            // 
            // _TreeList
            // 
            this._TreeList.CustomizationFormBounds = new System.Drawing.Rectangle(749, 385, 216, 178);
            this._TreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TreeList.KeyFieldName = "LOAITAISAN_ID";
            this._TreeList.Location = new System.Drawing.Point(0, 0);
            this._TreeList.Name = "_TreeList";
            this._TreeList.ParentFieldName = "LOAITAISAN_ID_CHA";
            this._TreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkeCoSuDung});
            this._TreeList.Size = new System.Drawing.Size(1000, 520);
            this._TreeList.TabIndex = 0;
            // 
            // lkeCoSuDung
            // 
            this.lkeCoSuDung.AutoHeight = false;
            this.lkeCoSuDung.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeCoSuDung.Name = "lkeCoSuDung";
            // 
            // _ActionPanel
            // 
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnDelete);
            this._ActionPanel.Controls.Add(this.btExport);
            this._ActionPanel.Controls.Add(this.btnPrint);
            this._ActionPanel.Controls.Add(this.btnClose);
            this._ActionPanel.Controls.Add(this.btnModify);
            this._ActionPanel.Controls.Add(this.btnCreate);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(4, 574);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(1000, 38);
            this._ActionPanel.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(173, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btExport
            // 
            this.btExport.GRID_VIEW = this._TreeList;
            this.btExport.Location = new System.Drawing.Point(259, 6);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(135, 30);
            this.btExport.TabIndex = 12;
            this.btExport.Visible = false;
            this.btExport.Load += new System.EventHandler(this.btExport_Load);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.ImageIndex = 15;
            this.btnPrint.Location = new System.Drawing.Point(566, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&In";
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.Location = new System.Drawing.Point(920, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Ðó&ng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.ImageIndex = 3;
            this.btnModify.Location = new System.Drawing.Point(87, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Sửa";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.Location = new System.Drawing.Point(1, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // _FieldChooser
            // 
            this._FieldChooser.EditValue = "";
            this._FieldChooser.Location = new System.Drawing.Point(90, 24);
            this._FieldChooser.Name = "_FieldChooser";
            this._FieldChooser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this._FieldChooser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._FieldChooser.Properties.ImmediatePopup = true;
            this._FieldChooser.Properties.NullText = "";
            this._FieldChooser.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            this._FieldChooser.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this._FieldChooser.Properties.ShowFooter = false;
            this._FieldChooser.Properties.ShowPopupShadow = false;
            this._FieldChooser.Properties.View = this._FieldChooserView;
            this._FieldChooser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._FieldChooser.Size = new System.Drawing.Size(141, 20);
            this._FieldChooser.TabIndex = 0;
            // 
            // _FieldChooserView
            // 
            this._FieldChooserView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._FieldChooserView.Name = "_FieldChooserView";
            this._FieldChooserView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._FieldChooserView.OptionsView.ShowGroupPanel = false;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // _SearchHelper
            // 
            this._SearchHelper.EditValue = "";
            this._SearchHelper.Location = new System.Drawing.Point(296, 24);
            this._SearchHelper.Name = "_SearchHelper";
            this._SearchHelper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._SearchHelper.Properties.ImmediatePopup = true;
            this._SearchHelper.Properties.NullText = "";
            this._SearchHelper.Properties.View = this.gridLookUpEdit1View;
            this._SearchHelper.Size = new System.Drawing.Size(141, 20);
            this._SearchHelper.TabIndex = 1;
            // 
            // GridView4
            // 
            this.GridView4.Name = "GridView4";
            // 
            // GridView3
            // 
            this.GridView3.Name = "GridView3";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(262, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Giá trị";
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
            this._GroupControlSearch.Size = new System.Drawing.Size(1000, 50);
            this._GroupControlSearch.TabIndex = 14;
            this._GroupControlSearch.Text = "Tìm kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tìm kiếm theo";
            // 
            // frmDanhMucLoaiTaiSan1_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 616);
            this.Controls.Add(this._GroupControlList);
            this.Controls.Add(this._ActionPanel);
            this.Controls.Add(this._GroupControlSearch);
            this.KeyPreview = true;
            this.Name = "frmDanhMucLoaiTaiSan1_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại tài sản";
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlList)).EndInit();
            this._GroupControlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCoSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooserView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).EndInit();
            this._GroupControlSearch.ResumeLayout(false);
            this._GroupControlSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl _GroupControlList;
        private DevExpress.XtraTreeList.TreeList _TreeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkeCoSuDung;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnCreate;
        //Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
        private DevExpress.XtraEditors.GridLookUpEdit _FieldChooser;
        private DevExpress.XtraGrid.Views.Grid.GridView _FieldChooserView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit _SearchHelper;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal DevExpress.XtraEditors.GroupControl _GroupControlSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal MultiExportButton btExport;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        //public frmDanhMucLoaiTaiSan1_DanhSach()
        //{
        //    InitializeComponent();
        //}
    }
}