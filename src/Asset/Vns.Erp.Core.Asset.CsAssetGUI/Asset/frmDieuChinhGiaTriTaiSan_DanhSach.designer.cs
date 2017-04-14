using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDieuChinhGiaTriTaiSan_DanhSach : DevExpress.XtraEditors.XtraForm
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grc_CT_TSCD = new DevExpress.XtraGrid.GridControl();
            this.grvCT_TSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TANG_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LYDO_TANGGIAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUYEN_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIA_TRI_CL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HAO_MON_LUY_KE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TY_LE_HAOMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcDM_TSCD = new DevExpress.XtraGrid.GridControl();
            this.grvDM_TSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_NAM_SD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MD_TK_TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMD_TK_TS = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MD_TK_KHAUHAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMD_TK_KHAUHAO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MD_TK_CHIPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMD_TK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grc_CT_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvCT_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grcDM_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvDM_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_TS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_KHAUHAO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_CHIPHI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            //
            //PanelControl1
            //
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Controls.Add(this.btnModify);
            this.PanelControl1.Controls.Add(this.btnAdd);
            this.PanelControl1.Controls.Add(this.btnDelete);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 574);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1000, 34);
            this.PanelControl1.TabIndex = 1;
            //
            //btnClose
            //
            this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.Location = new System.Drawing.Point(919, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đó&ng";
            //
            //btnModify
            //
            this.btnModify.ImageIndex = 4;
            this.btnModify.Location = new System.Drawing.Point(86, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "&Sửa";
            //
            //btnAdd
            //
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(0, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Mới";
            //
            //btnDelete
            //
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(172, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Xóa";
            //
            //GridView1
            //
            this.GridView1.Name = "GridView1";
            //
            //GridView2
            //
            this.GridView2.Name = "GridView2";
            //
            //GridView3
            //
            this.GridView3.Name = "GridView3";
            //
            //GroupControl2
            //
            this.GroupControl2.Controls.Add(this.grc_CT_TSCD);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(4, 294);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.Size = new System.Drawing.Size(1000, 280);
            this.GroupControl2.TabIndex = 4;
            this.GroupControl2.Text = "Thông tin điều chỉnh";
            //
            //grc_CT_TSCD
            //
            this.grc_CT_TSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_CT_TSCD.Location = new System.Drawing.Point(2, 22);
            this.grc_CT_TSCD.MainView = this.grvCT_TSCD;
            this.grc_CT_TSCD.Name = "grc_CT_TSCD";
            this.grc_CT_TSCD.Size = new System.Drawing.Size(996, 256);
            this.grc_CT_TSCD.TabIndex = 0;
            this.grc_CT_TSCD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.grvCT_TSCD });
            //
            //grvCT_TSCD
            //
            this.grvCT_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.Empty.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvCT_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvCT_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvCT_TSCD.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(171)), Convert.ToInt32(Convert.ToByte(177)));
            this.grvCT_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvCT_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvCT_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvCT_TSCD.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvCT_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvCT_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvCT_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvCT_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvCT_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvCT_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(186)), Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(215)));
            this.grvCT_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvCT_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvCT_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvCT_TSCD.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.OddRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvCT_TSCD.Appearance.OddRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(240)));
            this.grvCT_TSCD.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5f);
            this.grvCT_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvCT_TSCD.Appearance.Preview.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.Preview.Options.UseFont = true;
            this.grvCT_TSCD.Appearance.Preview.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.Row.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.Row.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvCT_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(159)), Convert.ToInt32(Convert.ToByte(201)), Convert.ToInt32(Convert.ToByte(207)));
            this.grvCT_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvCT_TSCD.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvCT_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvCT_TSCD.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvCT_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvCT_TSCD.Appearance.VertLine.Options.UseBackColor = true;
            this.grvCT_TSCD.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvCT_TSCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.TANG_TSCD,
			this.TEN_LYDO_TANGGIAM,
			this.NGUYEN_GIA,
			this.GIA_TRI_CL,
			this.HAO_MON_LUY_KE,
			this.TY_LE_HAOMON,
			this.GridColumn2
		});
            this.grvCT_TSCD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvCT_TSCD.GridControl = this.grc_CT_TSCD;
            this.grvCT_TSCD.Name = "grvCT_TSCD";
            this.grvCT_TSCD.OptionsView.EnableAppearanceEvenRow = true;
            this.grvCT_TSCD.OptionsView.EnableAppearanceOddRow = true;
            this.grvCT_TSCD.OptionsView.ShowGroupPanel = false;
            //
            //TANG_TSCD
            //
            this.TANG_TSCD.Caption = "Tăng/giảm";
            this.TANG_TSCD.FieldName = "TangTscd";
            this.TANG_TSCD.Name = "TANG_TSCD";
            this.TANG_TSCD.OptionsColumn.ReadOnly = true;
            this.TANG_TSCD.Visible = true;
            this.TANG_TSCD.VisibleIndex = 0;
            this.TANG_TSCD.Width = 105;
            //
            //TEN_LYDO_TANGGIAM
            //
            this.TEN_LYDO_TANGGIAM.Caption = "Lý do tăng giảm";
            this.TEN_LYDO_TANGGIAM.FieldName = "TenLydoTanggiam";
            this.TEN_LYDO_TANGGIAM.Name = "TEN_LYDO_TANGGIAM";
            this.TEN_LYDO_TANGGIAM.OptionsColumn.ReadOnly = true;
            this.TEN_LYDO_TANGGIAM.Visible = true;
            this.TEN_LYDO_TANGGIAM.VisibleIndex = 1;
            this.TEN_LYDO_TANGGIAM.Width = 243;
            //
            //NGUYEN_GIA
            //
            this.NGUYEN_GIA.Caption = "Nguyên giá";
            this.NGUYEN_GIA.DisplayFormat.FormatString = "#,###0";
            this.NGUYEN_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGUYEN_GIA.FieldName = "NguyenGia";
            this.NGUYEN_GIA.Name = "NGUYEN_GIA";
            this.NGUYEN_GIA.OptionsColumn.ReadOnly = true;
            this.NGUYEN_GIA.Visible = true;
            this.NGUYEN_GIA.VisibleIndex = 2;
            this.NGUYEN_GIA.Width = 102;
            //
            //GIA_TRI_CL
            //
            this.GIA_TRI_CL.Caption = "Giá trị còn lại";
            this.GIA_TRI_CL.DisplayFormat.FormatString = "#,###0";
            this.GIA_TRI_CL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIA_TRI_CL.FieldName = "GiaTriCl";
            this.GIA_TRI_CL.Name = "GIA_TRI_CL";
            this.GIA_TRI_CL.OptionsColumn.ReadOnly = true;
            this.GIA_TRI_CL.Visible = true;
            this.GIA_TRI_CL.VisibleIndex = 3;
            this.GIA_TRI_CL.Width = 103;
            //
            //HAO_MON_LUY_KE
            //
            this.HAO_MON_LUY_KE.Caption = "Hao mòn lũy kế";
            this.HAO_MON_LUY_KE.DisplayFormat.FormatString = "#,###";
            this.HAO_MON_LUY_KE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HAO_MON_LUY_KE.FieldName = "HaoMonLuyKe";
            this.HAO_MON_LUY_KE.Name = "HAO_MON_LUY_KE";
            this.HAO_MON_LUY_KE.OptionsColumn.ReadOnly = true;
            this.HAO_MON_LUY_KE.Visible = true;
            this.HAO_MON_LUY_KE.VisibleIndex = 4;
            this.HAO_MON_LUY_KE.Width = 113;
            //
            //TY_LE_HAOMON
            //
            this.TY_LE_HAOMON.Caption = "Tỷ lệ hao mòn";
            this.TY_LE_HAOMON.FieldName = "TyLeHaomon";
            this.TY_LE_HAOMON.Name = "TY_LE_HAOMON";
            this.TY_LE_HAOMON.OptionsColumn.ReadOnly = true;
            this.TY_LE_HAOMON.Visible = true;
            this.TY_LE_HAOMON.VisibleIndex = 5;
            this.TY_LE_HAOMON.Width = 96;
            //
            //GridColumn2
            //
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 6;
            this.GridColumn2.Width = 396;
            //
            //GridView4
            //
            this.GridView4.GridControl = this.grcDM_TSCD;
            this.GridView4.Name = "GridView4";
            //
            //grcDM_TSCD
            //
            this.grcDM_TSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDM_TSCD.Location = new System.Drawing.Point(2, 22);
            this.grcDM_TSCD.MainView = this.grvDM_TSCD;
            this.grcDM_TSCD.Name = "grcDM_TSCD";
            this.grcDM_TSCD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
			this.cboMD_TK_TS,
			this.cboMD_TK_KHAUHAO,
			this.cboMD_TK_CHIPHI
		});
            this.grcDM_TSCD.Size = new System.Drawing.Size(996, 266);
            this.grcDM_TSCD.TabIndex = 0;
            this.grcDM_TSCD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
			this.grvDM_TSCD,
			this.GridView5,
			this.GridView4
		});
            //
            //grvDM_TSCD
            //
            this.grvDM_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.Empty.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvDM_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grvDM_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvDM_TSCD.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(171)), Convert.ToInt32(Convert.ToByte(177)));
            this.grvDM_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grvDM_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvDM_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grvDM_TSCD.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvDM_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvDM_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvDM_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grvDM_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvDM_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grvDM_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(186)), Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(215)));
            this.grvDM_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvDM_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvDM_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvDM_TSCD.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.OddRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvDM_TSCD.Appearance.OddRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(240)));
            this.grvDM_TSCD.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5f);
            this.grvDM_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grvDM_TSCD.Appearance.Preview.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.Preview.Options.UseFont = true;
            this.grvDM_TSCD.Appearance.Preview.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.Row.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.Row.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grvDM_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(159)), Convert.ToInt32(Convert.ToByte(201)), Convert.ToInt32(Convert.ToByte(207)));
            this.grvDM_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvDM_TSCD.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvDM_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvDM_TSCD.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grvDM_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grvDM_TSCD.Appearance.VertLine.Options.UseBackColor = true;
            this.grvDM_TSCD.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvDM_TSCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.MA_TSCD,
			this.TEN_TSCD,
			this.NGAY_BDSD,
			this.SO_NAM_SD,
			this.MD_TK_TS,
			this.MD_TK_KHAUHAO,
			this.MD_TK_CHIPHI,
			this.GridColumn1
		});
            this.grvDM_TSCD.GridControl = this.grcDM_TSCD;
            this.grvDM_TSCD.Name = "grvDM_TSCD";
            this.grvDM_TSCD.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDM_TSCD.OptionsView.EnableAppearanceOddRow = true;
            this.grvDM_TSCD.OptionsView.ShowGroupPanel = false;
            //
            //MA_TSCD
            //
            this.MA_TSCD.Caption = "Mã tài sản";
            this.MA_TSCD.FieldName = "MaTscd";
            this.MA_TSCD.Name = "MA_TSCD";
            this.MA_TSCD.OptionsColumn.FixedWidth = true;
            this.MA_TSCD.OptionsColumn.ReadOnly = true;
            this.MA_TSCD.Visible = true;
            this.MA_TSCD.VisibleIndex = 0;
            this.MA_TSCD.Width = 114;
            //
            //TEN_TSCD
            //
            this.TEN_TSCD.Caption = "Tên tài sản";
            this.TEN_TSCD.FieldName = "TenTscd";
            this.TEN_TSCD.Name = "TEN_TSCD";
            this.TEN_TSCD.OptionsColumn.FixedWidth = true;
            this.TEN_TSCD.OptionsColumn.ReadOnly = true;
            this.TEN_TSCD.Visible = true;
            this.TEN_TSCD.VisibleIndex = 1;
            this.TEN_TSCD.Width = 300;
            //
            //NGAY_BDSD
            //
            this.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng";
            this.NGAY_BDSD.FieldName = "NgayBdsd";
            this.NGAY_BDSD.Name = "NGAY_BDSD";
            this.NGAY_BDSD.OptionsColumn.FixedWidth = true;
            this.NGAY_BDSD.OptionsColumn.ReadOnly = true;
            this.NGAY_BDSD.Visible = true;
            this.NGAY_BDSD.VisibleIndex = 2;
            this.NGAY_BDSD.Width = 135;
            //
            //SO_NAM_SD
            //
            this.SO_NAM_SD.Caption = "Số tháng sử dụng";
            this.SO_NAM_SD.FieldName = "SoThangSd";
            this.SO_NAM_SD.Name = "SO_NAM_SD";
            this.SO_NAM_SD.OptionsColumn.FixedWidth = true;
            this.SO_NAM_SD.OptionsColumn.ReadOnly = true;
            this.SO_NAM_SD.Visible = true;
            this.SO_NAM_SD.VisibleIndex = 3;
            this.SO_NAM_SD.Width = 111;
            //
            //MD_TK_TS
            //
            this.MD_TK_TS.Caption = "Tài khoản tài sản";
            this.MD_TK_TS.ColumnEdit = this.cboMD_TK_TS;
            this.MD_TK_TS.FieldName = "MdTkTs";
            this.MD_TK_TS.Name = "MD_TK_TS";
            this.MD_TK_TS.OptionsColumn.FixedWidth = true;
            this.MD_TK_TS.OptionsColumn.ReadOnly = true;
            this.MD_TK_TS.Visible = true;
            this.MD_TK_TS.VisibleIndex = 4;
            this.MD_TK_TS.Width = 111;
            //
            //cboMD_TK_TS
            //
            this.cboMD_TK_TS.AutoHeight = false;
            this.cboMD_TK_TS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboMD_TK_TS.Name = "cboMD_TK_TS";
            this.cboMD_TK_TS.NullText = "";
            //
            //MD_TK_KHAUHAO
            //
            this.MD_TK_KHAUHAO.Caption = "Tài khoản khấu hao";
            this.MD_TK_KHAUHAO.ColumnEdit = this.cboMD_TK_KHAUHAO;
            this.MD_TK_KHAUHAO.FieldName = "MdTkKhauhao";
            this.MD_TK_KHAUHAO.Name = "MD_TK_KHAUHAO";
            this.MD_TK_KHAUHAO.OptionsColumn.FixedWidth = true;
            this.MD_TK_KHAUHAO.OptionsColumn.ReadOnly = true;
            this.MD_TK_KHAUHAO.Visible = true;
            this.MD_TK_KHAUHAO.VisibleIndex = 5;
            this.MD_TK_KHAUHAO.Width = 120;
            //
            //cboMD_TK_KHAUHAO
            //
            this.cboMD_TK_KHAUHAO.AutoHeight = false;
            this.cboMD_TK_KHAUHAO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboMD_TK_KHAUHAO.Name = "cboMD_TK_KHAUHAO";
            this.cboMD_TK_KHAUHAO.NullText = "";
            //
            //MD_TK_CHIPHI
            //
            this.MD_TK_CHIPHI.Caption = "Tài khoản chi phí";
            this.MD_TK_CHIPHI.ColumnEdit = this.cboMD_TK_CHIPHI;
            this.MD_TK_CHIPHI.FieldName = "MdTkChiphi";
            this.MD_TK_CHIPHI.Name = "MD_TK_CHIPHI";
            this.MD_TK_CHIPHI.OptionsColumn.FixedWidth = true;
            this.MD_TK_CHIPHI.OptionsColumn.ReadOnly = true;
            this.MD_TK_CHIPHI.Visible = true;
            this.MD_TK_CHIPHI.VisibleIndex = 6;
            this.MD_TK_CHIPHI.Width = 121;
            //
            //cboMD_TK_CHIPHI
            //
            this.cboMD_TK_CHIPHI.AutoHeight = false;
            this.cboMD_TK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboMD_TK_CHIPHI.Name = "cboMD_TK_CHIPHI";
            this.cboMD_TK_CHIPHI.NullText = "";
            //
            //GridColumn1
            //
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 7;
            this.GridColumn1.Width = 146;
            //
            //GridView5
            //
            this.GridView5.GridControl = this.grcDM_TSCD;
            this.GridView5.Name = "GridView5";
            //
            //GroupControl1
            //
            this.GroupControl1.Controls.Add(this.grcDM_TSCD);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1000, 290);
            this.GroupControl1.TabIndex = 5;
            this.GroupControl1.Text = "Thông tin tài sản cố định";
            //
            //frmDieuChinhGiaTriTaiSan_DanhSach
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl2);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "frmDieuChinhGiaTriTaiSan_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Điều chỉnh giá trị tài sản";
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grc_CT_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvCT_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grcDM_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvDM_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_TS).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_KHAUHAO).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMD_TK_CHIPHI).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraGrid.GridControl grc_CT_TSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvCT_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TANG_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LYDO_TANGGIAM;
        internal DevExpress.XtraGrid.Columns.GridColumn NGUYEN_GIA;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_TRI_CL;
        internal DevExpress.XtraGrid.Columns.GridColumn HAO_MON_LUY_KE;
        internal DevExpress.XtraGrid.Columns.GridColumn TY_LE_HAOMON;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        internal DevExpress.XtraGrid.GridControl grcDM_TSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvDM_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDSD;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_NAM_SD;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_TS;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_KHAUHAO;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_CHIPHI;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView5;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMD_TK_TS;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMD_TK_KHAUHAO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMD_TK_CHIPHI;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
       
    }
}