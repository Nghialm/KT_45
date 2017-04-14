using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLyDoTGTSCD_DanhSach : Vns.Erp.Core.FrmBaseDmDanhSach
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
            this._GroupControlList = new DevExpress.XtraEditors.GroupControl();
            this._GridControl = new DevExpress.XtraGrid.GridControl();
            this._GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._GroupControlSearch = new DevExpress.XtraEditors.GroupControl();
            this._FieldChooser = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._SearchHelper = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btExport = new Vns.Erp.Core.MultiExportButton();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlList)).BeginInit();
            this._GroupControlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).BeginInit();
            this._GroupControlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _GroupControlList
            // 
            this._GroupControlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._GroupControlList.Controls.Add(this._GridControl);
            this._GroupControlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GroupControlList.Location = new System.Drawing.Point(6, 67);
            this._GroupControlList.Name = "_GroupControlList";
            this._GroupControlList.Size = new System.Drawing.Size(996, 499);
            this._GroupControlList.TabIndex = 13;
            this._GroupControlList.Text = "Danh sách...";
            // 
            // _GridControl
            // 
            this._GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridControl.Location = new System.Drawing.Point(0, 0);
            this._GridControl.MainView = this._GridView;
            this._GridControl.Name = "_GridControl";
            this._GridControl.Size = new System.Drawing.Size(996, 499);
            this._GridControl.TabIndex = 0;
            this._GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._GridView});
            // 
            // _GridView
            // 
            this._GridView.GridControl = this._GridControl;
            this._GridView.Name = "_GridView";
            this._GridView.OptionsView.ShowAutoFilterRow = true;
            this._GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this._GridView.OptionsView.ShowGroupPanel = false;
            // 
            // GridView4
            // 
            this.GridView4.Name = "GridView4";
            // 
            // GridView3
            // 
            this.GridView3.Name = "GridView3";
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
            this._GroupControlSearch.Location = new System.Drawing.Point(6, 6);
            this._GroupControlSearch.Name = "_GroupControlSearch";
            this._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._GroupControlSearch.Size = new System.Drawing.Size(996, 61);
            this._GroupControlSearch.TabIndex = 0;
            this._GroupControlSearch.Text = "Tìm kiếm ";
            this._GroupControlSearch.Visible = false;
            // 
            // _FieldChooser
            // 
            this._FieldChooser.EditValue = "";
            this._FieldChooser.Location = new System.Drawing.Point(90, 29);
            this._FieldChooser.Name = "_FieldChooser";
            this._FieldChooser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._FieldChooser.Properties.ImmediatePopup = true;
            this._FieldChooser.Properties.View = this.gridView1;
            this._FieldChooser.Size = new System.Drawing.Size(141, 20);
            this._FieldChooser.TabIndex = 1;
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
            this._SearchHelper.Location = new System.Drawing.Point(292, 29);
            this._SearchHelper.Name = "_SearchHelper";
            this._SearchHelper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._SearchHelper.Properties.ImmediatePopup = true;
            this._SearchHelper.Properties.View = this.gridLookUpEdit1View;
            this._SearchHelper.Size = new System.Drawing.Size(141, 20);
            this._SearchHelper.TabIndex = 3;
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
            this.labelControl2.Location = new System.Drawing.Point(251, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Giá trị";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm theo";
            // 
            // _ActionPanel
            // 
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnDelete);
            this._ActionPanel.Controls.Add(this.btExport);
            this._ActionPanel.Controls.Add(this.btnPri);
            this._ActionPanel.Controls.Add(this.btnClose);
            this._ActionPanel.Controls.Add(this.btnModify);
            this._ActionPanel.Controls.Add(this.btnCreate);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(6, 566);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(996, 40);
            this._ActionPanel.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(173, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Xóa";
            // 
            // btExport
            // 
            this.btExport.GRID_VIEW = this._GridView;
            this.btExport.Location = new System.Drawing.Point(261, 6);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(135, 30);
            this.btExport.TabIndex = 11;
            this.btExport.Visible = false;
            // 
            // btnPri
            // 
            this.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPri.ImageIndex = 5;
            this.btnPri.Location = new System.Drawing.Point(553, 6);
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
            this.btnClose.Location = new System.Drawing.Point(911, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Ðó&ng";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.ImageIndex = 3;
            this.btnModify.Location = new System.Drawing.Point(88, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Sửa";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.Location = new System.Drawing.Point(2, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Mới";
            // 
            // frmDanhMucLyDoTGTSCD_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this._GroupControlList);
            this.Controls.Add(this._ActionPanel);
            this.Controls.Add(this._GroupControlSearch);
            this.Name = "frmDanhMucLyDoTGTSCD_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục lý do tăng giảm tài sản cố định [Danh sách]";
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlList)).EndInit();
            this._GroupControlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).EndInit();
            this._GroupControlSearch.ResumeLayout(false);
            this._GroupControlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FieldChooser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SearchHelper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.GroupControl _GroupControlList;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        private DevExpress.XtraGrid.GridControl _GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView _GridView;
        internal DevExpress.XtraEditors.GroupControl _GroupControlSearch;
        private DevExpress.XtraEditors.GridLookUpEdit _FieldChooser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit _SearchHelper;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnPri;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnCreate;
        internal MultiExportButton btExport;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        //Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton

    }
}