using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class In_The_TSCD : DevExpress.XtraEditors.XtraForm
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
            this.grcTSCD = new DevExpress.XtraGrid.GridControl();
            this.grvTSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KY_HIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOAITAISAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_MUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KTKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_NAM_SD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkChon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txttenLoaiTS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTS = new DevExpress.XtraEditors.TextEdit();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.grlLoaiTSCD = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grcTSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvTSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.chkChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.txttenLoaiTS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteDenNgay.Properties.VistaTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteDenNgay.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteTuNgay.Properties.VistaTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteTuNgay.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grlLoaiTSCD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl2).BeginInit();
            this.SuspendLayout();
            //
            //GroupControl1
            //
            this.GroupControl1.Controls.Add(this.grcTSCD);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 116);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(887, 369);
            this.GroupControl1.TabIndex = 1;
            this.GroupControl1.Text = "Danh sách tài sản cố định";
            //
            //grcTSCD
            //
            this.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTSCD.Location = new System.Drawing.Point(2, 22);
            this.grcTSCD.MainView = this.grvTSCD;
            this.grcTSCD.Name = "grcTSCD";
            this.grcTSCD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { this.chkChon });
            this.grcTSCD.Size = new System.Drawing.Size(883, 345);
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
			this.TEN_TSCD,
			this.KY_HIEU,
			this.TEN_LOAITAISAN,
			this.NGAY_MUA,
			this.NGAY_BDSD,
			this.NGAY_BDKH,
			this.NGAY_KTKH,
			this.SO_NAM_SD
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
            this.MA_TSCD.Caption = "Mã TSCD";
            this.MA_TSCD.FieldName = "MaTscd";
            this.MA_TSCD.Name = "MA_TSCD";
            this.MA_TSCD.OptionsColumn.ReadOnly = true;
            this.MA_TSCD.Visible = true;
            this.MA_TSCD.VisibleIndex = 0;
            this.MA_TSCD.Width = 145;
            //
            //TEN_TSCD
            //
            this.TEN_TSCD.Caption = "Tên TSCD";
            this.TEN_TSCD.FieldName = "TenTscd";
            this.TEN_TSCD.Name = "TEN_TSCD";
            this.TEN_TSCD.OptionsColumn.ReadOnly = true;
            this.TEN_TSCD.Visible = true;
            this.TEN_TSCD.VisibleIndex = 1;
            this.TEN_TSCD.Width = 191;
            //
            //KY_HIEU
            //
            this.KY_HIEU.Caption = "Ký hiệu";
            this.KY_HIEU.FieldName = "KyHieu";
            this.KY_HIEU.Name = "KY_HIEU";
            this.KY_HIEU.OptionsColumn.ReadOnly = true;
            this.KY_HIEU.Visible = true;
            this.KY_HIEU.VisibleIndex = 2;
            this.KY_HIEU.Width = 150;
            //
            //TEN_LOAITAISAN
            //
            this.TEN_LOAITAISAN.Caption = "Tên loại TSCD";
            this.TEN_LOAITAISAN.FieldName = "TenLoaitaisan";
            this.TEN_LOAITAISAN.Name = "TEN_LOAITAISAN";
            this.TEN_LOAITAISAN.OptionsColumn.ReadOnly = true;
            this.TEN_LOAITAISAN.Visible = true;
            this.TEN_LOAITAISAN.VisibleIndex = 3;
            this.TEN_LOAITAISAN.Width = 187;
            //
            //NGAY_MUA
            //
            this.NGAY_MUA.Caption = "Ngày mua";
            this.NGAY_MUA.FieldName = "NgayMua";
            this.NGAY_MUA.Name = "NGAY_MUA";
            this.NGAY_MUA.OptionsColumn.AllowEdit = false;
            this.NGAY_MUA.OptionsColumn.ReadOnly = true;
            this.NGAY_MUA.Visible = true;
            this.NGAY_MUA.VisibleIndex = 4;
            this.NGAY_MUA.Width = 122;
            //
            //NGAY_BDSD
            //
            this.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng";
            this.NGAY_BDSD.FieldName = "NgayBdsd";
            this.NGAY_BDSD.Name = "NGAY_BDSD";
            this.NGAY_BDSD.OptionsColumn.AllowEdit = false;
            this.NGAY_BDSD.OptionsColumn.ReadOnly = true;
            this.NGAY_BDSD.Visible = true;
            this.NGAY_BDSD.VisibleIndex = 5;
            this.NGAY_BDSD.Width = 167;
            //
            //NGAY_BDKH
            //
            this.NGAY_BDKH.Caption = "Ngày bắt đầu khấu hao";
            this.NGAY_BDKH.FieldName = "NgayBdkh";
            this.NGAY_BDKH.Name = "NGAY_BDKH";
            this.NGAY_BDKH.OptionsColumn.AllowEdit = false;
            this.NGAY_BDKH.OptionsColumn.ReadOnly = true;
            this.NGAY_BDKH.Visible = true;
            this.NGAY_BDKH.VisibleIndex = 6;
            this.NGAY_BDKH.Width = 147;
            //
            //NGAY_KTKH
            //
            this.NGAY_KTKH.Caption = "Ngày kết thúc khấu hao";
            this.NGAY_KTKH.FieldName = "NgayKtkh";
            this.NGAY_KTKH.Name = "NGAY_KTKH";
            this.NGAY_KTKH.OptionsColumn.AllowEdit = false;
            this.NGAY_KTKH.OptionsColumn.ReadOnly = true;
            this.NGAY_KTKH.Visible = true;
            this.NGAY_KTKH.VisibleIndex = 7;
            this.NGAY_KTKH.Width = 167;
            //
            //SO_NAM_SD
            //
            this.SO_NAM_SD.Caption = "Số tháng sử dụng";
            this.SO_NAM_SD.FieldName = "SoThangSd";
            this.SO_NAM_SD.Name = "SO_NAM_SD";
            this.SO_NAM_SD.OptionsColumn.ReadOnly = true;
            this.SO_NAM_SD.Visible = true;
            this.SO_NAM_SD.VisibleIndex = 8;
            this.SO_NAM_SD.Width = 172;
            //
            //chkChon
            //
            this.chkChon.AutoHeight = false;
            this.chkChon.Name = "chkChon";
            this.chkChon.ValueChecked = new decimal(new int[] {
			1,
			0,
			0,
			0
		});
            this.chkChon.ValueUnchecked = new decimal(new int[] {
			0,
			0,
			0,
			0
		});
            //
            //PanelControl1
            //
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnQuit);
            this.PanelControl1.Controls.Add(this.btnPrint);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 485);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(887, 34);
            this.PanelControl1.TabIndex = 2;
            //
            //btnQuit
            //
            this.btnQuit.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnQuit.Location = new System.Drawing.Point(807, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quay ra";
            //
            //btnPrint
            //
            this.btnPrint.Location = new System.Drawing.Point(0, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "&In";
            //
            //GroupControl2
            //
            this.GroupControl2.Controls.Add(this.txttenLoaiTS);
            this.GroupControl2.Controls.Add(this.txtTenTS);
            this.GroupControl2.Controls.Add(this.dteDenNgay);
            this.GroupControl2.Controls.Add(this.LabelControl5);
            this.GroupControl2.Controls.Add(this.dteTuNgay);
            this.GroupControl2.Controls.Add(this.LabelControl4);
            this.GroupControl2.Controls.Add(this.btnSearch);
            this.GroupControl2.Controls.Add(this.grlLoaiTSCD);
            this.GroupControl2.Controls.Add(this.LabelControl3);
            this.GroupControl2.Controls.Add(this.LabelControl1);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl2.Location = new System.Drawing.Point(4, 4);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.Size = new System.Drawing.Size(887, 108);
            this.GroupControl2.TabIndex = 0;
            this.GroupControl2.Text = "Tìm kiếm";
            //
            //txttenLoaiTS
            //
            this.txttenLoaiTS.Location = new System.Drawing.Point(182, 55);
            this.txttenLoaiTS.Name = "txttenLoaiTS";
            this.txttenLoaiTS.Properties.ReadOnly = true;
            this.txttenLoaiTS.Size = new System.Drawing.Size(172, 20);
            this.txttenLoaiTS.TabIndex = 3;
            this.txttenLoaiTS.TabStop = false;
            //
            //txtTenTS
            //
            this.txtTenTS.EnterMoveNextControl = true;
            this.txtTenTS.Location = new System.Drawing.Point(76, 79);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(278, 20);
            this.txtTenTS.TabIndex = 4;
            //
            //dteDenNgay
            //
            this.dteDenNgay.EditValue = null;
            this.dteDenNgay.EnterMoveNextControl = true;
            this.dteDenNgay.Location = new System.Drawing.Point(254, 29);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteDenNgay.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            this.dteDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dteDenNgay.TabIndex = 1;
            //
            //LabelControl5
            //
            this.LabelControl5.Location = new System.Drawing.Point(195, 32);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(47, 13);
            this.LabelControl5.TabIndex = 3;
            this.LabelControl5.Text = "Đến ngày";
            //
            //dteTuNgay
            //
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.EnterMoveNextControl = true;
            this.dteTuNgay.Location = new System.Drawing.Point(76, 29);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteTuNgay.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            this.dteTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dteTuNgay.TabIndex = 0;
            //
            //LabelControl4
            //
            this.LabelControl4.Location = new System.Drawing.Point(21, 32);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(40, 13);
            this.LabelControl4.TabIndex = 3;
            this.LabelControl4.Text = "Từ ngày";
            //
            //btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(360, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            //
            //grlLoaiTSCD
            //
            this.grlLoaiTSCD.EnterMoveNextControl = true;
            this.grlLoaiTSCD.Location = new System.Drawing.Point(76, 55);
            this.grlLoaiTSCD.Name = "grlLoaiTSCD";
            this.grlLoaiTSCD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLoaiTSCD.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.grlLoaiTSCD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.grlLoaiTSCD.Properties.ImmediatePopup = true;
            this.grlLoaiTSCD.Properties.NullText = "";
            this.grlLoaiTSCD.Properties.View = this.GridView2;
            this.grlLoaiTSCD.Size = new System.Drawing.Size(100, 20);
            this.grlLoaiTSCD.TabIndex = 2;
            //
            //GridView2
            //
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            //
            //LabelControl3
            //
            this.LabelControl3.Location = new System.Drawing.Point(13, 58);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(48, 13);
            this.LabelControl3.TabIndex = 0;
            this.LabelControl3.Text = "Loại TSCD";
            //
            //LabelControl1
            //
            this.LabelControl1.Location = new System.Drawing.Point(14, 82);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(47, 13);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Tên TSCD";
            //
            //PanelControl2
            //
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl2.Location = new System.Drawing.Point(4, 112);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(887, 4);
            this.PanelControl2.TabIndex = 3;
            //
            //In_The_TSCD
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 523);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.GroupControl2);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "In_The_TSCD";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In thẻ tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grcTSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvTSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.chkChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
            this.GroupControl2.ResumeLayout(false);
            this.GroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txttenLoaiTS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteDenNgay.Properties.VistaTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteDenNgay.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteTuNgay.Properties.VistaTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteTuNgay.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grlLoaiTSCD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl2).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraGrid.GridControl grcTSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvTSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LOAITAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_MUA;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDSD;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDKH;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_KTKH;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_NAM_SD;
        internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkChon;
        internal DevExpress.XtraEditors.SimpleButton btnQuit;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLoaiTSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnSearch;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.DateEdit dteDenNgay;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.DateEdit dteTuNgay;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.TextEdit txttenLoaiTS;
        internal DevExpress.XtraEditors.TextEdit txtTenTS;
        
    }
}