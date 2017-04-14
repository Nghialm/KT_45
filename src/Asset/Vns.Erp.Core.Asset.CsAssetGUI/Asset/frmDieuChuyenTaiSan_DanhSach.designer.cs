using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDieuChuyenTaiSan_DanhSach : DevExpress.XtraEditors.XtraForm
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcTSCD = new DevExpress.XtraGrid.GridControl();
            this.grvTSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcBoPhan = new DevExpress.XtraGrid.GridControl();
            this.grvBoPhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGAY_DC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BO_PHAN_DC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBO_PHAN_DC_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LY_DO_DC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grcTSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvTSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grcBoPhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvBoPhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboBO_PHAN_DC_ID).BeginInit();
            this.SuspendLayout();
            //
            //PanelControl1
            //
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Controls.Add(this.btnModify);
            this.PanelControl1.Controls.Add(this.btnChuyen);
            this.PanelControl1.Controls.Add(this.btnDelete);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(0, 570);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1008, 42);
            this.PanelControl1.TabIndex = 1;
            //
            //btnClose
            //
            this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.Location = new System.Drawing.Point(923, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Đó&ng";
            //
            //btnModify
            //
            this.btnModify.ImageIndex = 4;
            this.btnModify.Location = new System.Drawing.Point(89, 7);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "&Sửa";
            //
            //btnChuyen
            //
            this.btnChuyen.ImageIndex = 2;
            this.btnChuyen.Location = new System.Drawing.Point(3, 7);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(80, 30);
            this.btnChuyen.TabIndex = 13;
            this.btnChuyen.Text = "&Chuyển";
            //
            //btnDelete
            //
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(175, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Xóa";
            //
            //SplitContainerControl1
            //
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.GroupControl1);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.GroupControl2);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(1008, 570);
            this.SplitContainerControl1.SplitterPosition = 303;
            this.SplitContainerControl1.TabIndex = 2;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            //
            //GroupControl1
            //
            this.GroupControl1.Controls.Add(this.grcTSCD);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(303, 570);
            this.GroupControl1.TabIndex = 1;
            this.GroupControl1.Text = "Danh sách tài sản";
            //
            //grcTSCD
            //
            this.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTSCD.Location = new System.Drawing.Point(2, 22);
            this.grcTSCD.MainView = this.grvTSCD;
            this.grcTSCD.Name = "grcTSCD";
            this.grcTSCD.Size = new System.Drawing.Size(299, 546);
            this.grcTSCD.TabIndex = 0;
            this.grcTSCD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.grvTSCD });
            //
            //grvTSCD
            //
            this.grvTSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvTSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvTSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvTSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvTSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvTSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvTSCD.Appearance.Empty.Options.UseBackColor = true;
            this.grvTSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvTSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvTSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvTSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvTSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvTSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvTSCD.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvTSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvTSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(171)), Convert.ToInt32(Convert.ToByte(177)));
            this.grvTSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvTSCD.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvTSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvTSCD.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvTSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvTSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvTSCD.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvTSCD.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvTSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvTSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvTSCD.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvTSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvTSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvTSCD.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvTSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvTSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvTSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvTSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvTSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvTSCD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvTSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(186)), Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(215)));
            this.grvTSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvTSCD.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvTSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvTSCD.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvTSCD.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.OddRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvTSCD.Appearance.OddRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(240)));
            this.grvTSCD.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5f);
            this.grvTSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvTSCD.Appearance.Preview.Options.UseBackColor = true;
            this.grvTSCD.Appearance.Preview.Options.UseFont = true;
            this.grvTSCD.Appearance.Preview.Options.UseForeColor = true;
            this.grvTSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.Row.Options.UseBackColor = true;
            this.grvTSCD.Appearance.Row.Options.UseForeColor = true;
            this.grvTSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvTSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvTSCD.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvTSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(159)), Convert.ToInt32(Convert.ToByte(201)), Convert.ToInt32(Convert.ToByte(207)));
            this.grvTSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvTSCD.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvTSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvTSCD.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvTSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvTSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvTSCD.Appearance.VertLine.Options.UseBackColor = true;
            this.grvTSCD.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvTSCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.MA_TSCD,
			this.TEN_TSCD
		});
            this.grvTSCD.GridControl = this.grcTSCD;
            this.grvTSCD.Name = "grvTSCD";
            this.grvTSCD.OptionsView.ColumnAutoWidth = false;
            this.grvTSCD.OptionsView.EnableAppearanceEvenRow = true;
            this.grvTSCD.OptionsView.EnableAppearanceOddRow = true;
            this.grvTSCD.OptionsView.ShowGroupPanel = false;
            //
            //MA_TSCD
            //
            this.MA_TSCD.Caption = "Mã tài sản";
            this.MA_TSCD.FieldName = "MaTscd";
            this.MA_TSCD.Name = "MA_TSCD";
            this.MA_TSCD.OptionsColumn.ReadOnly = true;
            this.MA_TSCD.Visible = true;
            this.MA_TSCD.VisibleIndex = 0;
            this.MA_TSCD.Width = 124;
            //
            //TEN_TSCD
            //
            this.TEN_TSCD.Caption = "Tên tài sản";
            this.TEN_TSCD.FieldName = "TenTscd";
            this.TEN_TSCD.Name = "TEN_TSCD";
            this.TEN_TSCD.OptionsColumn.ReadOnly = true;
            this.TEN_TSCD.Visible = true;
            this.TEN_TSCD.VisibleIndex = 1;
            this.TEN_TSCD.Width = 165;
            //
            //GroupControl2
            //
            this.GroupControl2.Controls.Add(this.grcBoPhan);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(0, 0);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.Size = new System.Drawing.Size(700, 570);
            this.GroupControl2.TabIndex = 3;
            this.GroupControl2.Text = "Bộ phận điều chuyển";
            //
            //grcBoPhan
            //
            this.grcBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBoPhan.Location = new System.Drawing.Point(2, 22);
            this.grcBoPhan.MainView = this.grvBoPhan;
            this.grcBoPhan.Name = "grcBoPhan";
            this.grcBoPhan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { this.cboBO_PHAN_DC_ID });
            this.grcBoPhan.Size = new System.Drawing.Size(696, 546);
            this.grcBoPhan.TabIndex = 0;
            this.grcBoPhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.grvBoPhan });
            //
            //grvBoPhan
            //
            this.grvBoPhan.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.Empty.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvBoPhan.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvBoPhan.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvBoPhan.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(171)), Convert.ToInt32(Convert.ToByte(177)));
            this.grvBoPhan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvBoPhan.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvBoPhan.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvBoPhan.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvBoPhan.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvBoPhan.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvBoPhan.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvBoPhan.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvBoPhan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvBoPhan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(186)), Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(215)));
            this.grvBoPhan.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvBoPhan.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvBoPhan.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvBoPhan.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.OddRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvBoPhan.Appearance.OddRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(240)));
            this.grvBoPhan.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5f);
            this.grvBoPhan.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvBoPhan.Appearance.Preview.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.Preview.Options.UseFont = true;
            this.grvBoPhan.Appearance.Preview.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.Row.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.Row.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvBoPhan.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(159)), Convert.ToInt32(Convert.ToByte(201)), Convert.ToInt32(Convert.ToByte(207)));
            this.grvBoPhan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvBoPhan.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvBoPhan.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvBoPhan.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvBoPhan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvBoPhan.Appearance.VertLine.Options.UseBackColor = true;
            this.grvBoPhan.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvBoPhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.NGAY_DC,
			this.BO_PHAN_DC_ID,
			this.LY_DO_DC
		});
            this.grvBoPhan.GridControl = this.grcBoPhan;
            this.grvBoPhan.Name = "grvBoPhan";
            this.grvBoPhan.OptionsBehavior.Editable = false;
            this.grvBoPhan.OptionsView.ColumnAutoWidth = false;
            this.grvBoPhan.OptionsView.EnableAppearanceEvenRow = true;
            this.grvBoPhan.OptionsView.EnableAppearanceOddRow = true;
            this.grvBoPhan.OptionsView.ShowGroupPanel = false;
            //
            //NGAY_DC
            //
            this.NGAY_DC.Caption = "Ngày điều chuyển";
            this.NGAY_DC.FieldName = "NgayDc";
            this.NGAY_DC.Name = "NGAY_DC";
            this.NGAY_DC.OptionsColumn.ReadOnly = true;
            this.NGAY_DC.Visible = true;
            this.NGAY_DC.VisibleIndex = 0;
            this.NGAY_DC.Width = 151;
            //
            //BO_PHAN_DC_ID
            //
            this.BO_PHAN_DC_ID.Caption = "Bộ phận điều chuyển";
            this.BO_PHAN_DC_ID.ColumnEdit = this.cboBO_PHAN_DC_ID;
            this.BO_PHAN_DC_ID.FieldName = "BoPhanDcId";
            this.BO_PHAN_DC_ID.Name = "BO_PHAN_DC_ID";
            this.BO_PHAN_DC_ID.OptionsColumn.ReadOnly = true;
            this.BO_PHAN_DC_ID.Visible = true;
            this.BO_PHAN_DC_ID.VisibleIndex = 1;
            this.BO_PHAN_DC_ID.Width = 157;
            //
            //cboBO_PHAN_DC_ID
            //
            this.cboBO_PHAN_DC_ID.AutoHeight = false;
            this.cboBO_PHAN_DC_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboBO_PHAN_DC_ID.Name = "cboBO_PHAN_DC_ID";
            this.cboBO_PHAN_DC_ID.NullText = "";
            //
            //LY_DO_DC
            //
            this.LY_DO_DC.Caption = "Lý do điều chuyển";
            this.LY_DO_DC.FieldName = "LyDoDc";
            this.LY_DO_DC.Name = "LY_DO_DC";
            this.LY_DO_DC.OptionsColumn.ReadOnly = true;
            this.LY_DO_DC.Visible = true;
            this.LY_DO_DC.VisibleIndex = 2;
            this.LY_DO_DC.Width = 201;
            //
            //frmDieuChuyenTaiSan_DanhSach
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "frmDieuChuyenTaiSan_DanhSach";
            this.Text = "Điều chuyển tài sản";
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grcTSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvTSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grcBoPhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvBoPhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboBO_PHAN_DC_ID).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnChuyen;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl grcTSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvTSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TSCD;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraGrid.GridControl grcBoPhan;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvBoPhan;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_DC;
        internal DevExpress.XtraGrid.Columns.GridColumn BO_PHAN_DC_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboBO_PHAN_DC_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn LY_DO_DC;
        
    }
}