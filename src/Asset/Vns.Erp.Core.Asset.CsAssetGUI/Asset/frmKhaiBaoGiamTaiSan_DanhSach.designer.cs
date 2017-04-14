using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmKhaiBaoGiamTaiSan_DanhSach : DevExpress.XtraEditors.XtraForm
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
            DevExpress.XtraGrid.StyleFormatCondition StyleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.GIAM_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grc_TSCD = new DevExpress.XtraGrid.GridControl();
            this.grv_TSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KY_HIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOAITAISAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_MUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KTKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_NAM_SD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiam = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.PagerControl1 = new Vns.Erp.Core.Common.Controls.PagerControl();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grc_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grv_TSCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
            this.GroupControl2.SuspendLayout();
            this.SuspendLayout();
            //
            //GIAM_TSCD
            //
            this.GIAM_TSCD.Caption = "Trạng thái";
            this.GIAM_TSCD.FieldName = "GiamTscd";
            this.GIAM_TSCD.Name = "GIAM_TSCD";
            this.GIAM_TSCD.OptionsColumn.FixedWidth = true;
            this.GIAM_TSCD.OptionsColumn.ReadOnly = true;
            this.GIAM_TSCD.Visible = true;
            this.GIAM_TSCD.VisibleIndex = 8;
            //
            //GroupControl1
            //
            this.GroupControl1.Controls.Add(this.grc_TSCD);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1008, 534);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "Danh sách tài sản cố định";
            //
            //grc_TSCD
            //
            this.grc_TSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_TSCD.Location = new System.Drawing.Point(2, 22);
            this.grc_TSCD.MainView = this.grv_TSCD;
            this.grc_TSCD.Name = "grc_TSCD";
            this.grc_TSCD.Size = new System.Drawing.Size(1004, 510);
            this.grc_TSCD.TabIndex = 1;
            this.grc_TSCD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.grv_TSCD });
            //
            //grv_TSCD
            //
            this.grv_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.Empty.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grv_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(227)), Convert.ToInt32(Convert.ToByte(245)));
            this.grv_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.EvenRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.EvenRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grv_TSCD.Appearance.FixedLine.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(171)), Convert.ToInt32(Convert.ToByte(177)));
            this.grv_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(202)), Convert.ToInt32(Convert.ToByte(221)), Convert.ToInt32(Convert.ToByte(208)));
            this.grv_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grv_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(178)), Convert.ToInt32(Convert.ToByte(209)), Convert.ToInt32(Convert.ToByte(188)));
            this.grv_TSCD.Appearance.GroupButton.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grv_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grv_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grv_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(215)), Convert.ToInt32(Convert.ToByte(234)), Convert.ToInt32(Convert.ToByte(221)));
            this.grv_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.GroupRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.GroupRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grv_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(226)), Convert.ToInt32(Convert.ToByte(216)));
            this.grv_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(186)), Convert.ToInt32(Convert.ToByte(211)), Convert.ToInt32(Convert.ToByte(215)));
            this.grv_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grv_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grv_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grv_TSCD.Appearance.HorzLine.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.OddRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.OddRow.Options.UseBorderColor = true;
            this.grv_TSCD.Appearance.OddRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(240)));
            this.grv_TSCD.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5f);
            this.grv_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(104)), Convert.ToInt32(Convert.ToByte(130)), Convert.ToInt32(Convert.ToByte(134)));
            this.grv_TSCD.Appearance.Preview.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.Preview.Options.UseFont = true;
            this.grv_TSCD.Appearance.Preview.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.Row.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.Row.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(242)), Convert.ToInt32(Convert.ToByte(244)), Convert.ToInt32(Convert.ToByte(236)));
            this.grv_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(159)), Convert.ToInt32(Convert.ToByte(201)), Convert.ToInt32(Convert.ToByte(207)));
            this.grv_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grv_TSCD.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grv_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grv_TSCD.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(172)), Convert.ToInt32(Convert.ToByte(197)), Convert.ToInt32(Convert.ToByte(180)));
            this.grv_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(117)), Convert.ToInt32(Convert.ToByte(136)), Convert.ToInt32(Convert.ToByte(122)));
            this.grv_TSCD.Appearance.VertLine.Options.UseBackColor = true;
            this.grv_TSCD.Appearance.VertLine.Options.UseBorderColor = true;
            this.grv_TSCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.MA_TSCD,
			this.TEN_TSCD,
			this.KY_HIEU,
			this.TEN_LOAITAISAN,
			this.NGAY_MUA,
			this.NGAY_BDKH,
			this.NGAY_KTKH,
			this.SO_NAM_SD,
			this.GIAM_TSCD,
			this.GridColumn1
		});
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            StyleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
            StyleFormatCondition1.Appearance.Options.UseBackColor = true;
            StyleFormatCondition1.Appearance.Options.UseFont = true;
            StyleFormatCondition1.ApplyToRow = true;
            StyleFormatCondition1.Column = this.GIAM_TSCD;
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            StyleFormatCondition1.Value1 = 1;
            StyleFormatCondition1.Value2 = 1;
            this.grv_TSCD.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { StyleFormatCondition1 });
            this.grv_TSCD.GridControl = this.grc_TSCD;
            this.grv_TSCD.Name = "grv_TSCD";
            this.grv_TSCD.OptionsView.EnableAppearanceEvenRow = true;
            this.grv_TSCD.OptionsView.EnableAppearanceOddRow = true;
            this.grv_TSCD.OptionsView.ShowGroupPanel = false;
            //
            //MA_TSCD
            //
            this.MA_TSCD.Caption = "Mã TSCD";
            this.MA_TSCD.FieldName = "MaTscd";
            this.MA_TSCD.Name = "MA_TSCD";
            this.MA_TSCD.OptionsColumn.FixedWidth = true;
            this.MA_TSCD.OptionsColumn.ReadOnly = true;
            this.MA_TSCD.Visible = true;
            this.MA_TSCD.VisibleIndex = 0;
            this.MA_TSCD.Width = 88;
            //
            //TEN_TSCD
            //
            this.TEN_TSCD.Caption = "Tên TSCD";
            this.TEN_TSCD.FieldName = "TenTscd";
            this.TEN_TSCD.Name = "TEN_TSCD";
            this.TEN_TSCD.OptionsColumn.FixedWidth = true;
            this.TEN_TSCD.OptionsColumn.ReadOnly = true;
            this.TEN_TSCD.Visible = true;
            this.TEN_TSCD.VisibleIndex = 2;
            this.TEN_TSCD.Width = 255;
            //
            //KY_HIEU
            //
            this.KY_HIEU.Caption = "Ký hiệu";
            this.KY_HIEU.FieldName = "KyHieu";
            this.KY_HIEU.Name = "KY_HIEU";
            this.KY_HIEU.OptionsColumn.FixedWidth = true;
            this.KY_HIEU.OptionsColumn.ReadOnly = true;
            this.KY_HIEU.Visible = true;
            this.KY_HIEU.VisibleIndex = 1;
            this.KY_HIEU.Width = 193;
            //
            //TEN_LOAITAISAN
            //
            this.TEN_LOAITAISAN.Caption = "Tên loại TSCD";
            this.TEN_LOAITAISAN.FieldName = "TenLoaitaisan";
            this.TEN_LOAITAISAN.Name = "TEN_LOAITAISAN";
            this.TEN_LOAITAISAN.OptionsColumn.FixedWidth = true;
            this.TEN_LOAITAISAN.OptionsColumn.ReadOnly = true;
            this.TEN_LOAITAISAN.Visible = true;
            this.TEN_LOAITAISAN.VisibleIndex = 3;
            this.TEN_LOAITAISAN.Width = 225;
            //
            //NGAY_MUA
            //
            this.NGAY_MUA.Caption = "Ngày mua";
            this.NGAY_MUA.FieldName = "NgayMua";
            this.NGAY_MUA.Name = "NGAY_MUA";
            this.NGAY_MUA.OptionsColumn.FixedWidth = true;
            this.NGAY_MUA.OptionsColumn.ReadOnly = true;
            this.NGAY_MUA.Visible = true;
            this.NGAY_MUA.VisibleIndex = 4;
            this.NGAY_MUA.Width = 114;
            //
            //NGAY_BDKH
            //
            this.NGAY_BDKH.Caption = "Ngày BDKH";
            this.NGAY_BDKH.FieldName = "NgayBdkh";
            this.NGAY_BDKH.Name = "NGAY_BDKH";
            this.NGAY_BDKH.OptionsColumn.FixedWidth = true;
            this.NGAY_BDKH.OptionsColumn.ReadOnly = true;
            this.NGAY_BDKH.Visible = true;
            this.NGAY_BDKH.VisibleIndex = 5;
            this.NGAY_BDKH.Width = 105;
            //
            //NGAY_KTKH
            //
            this.NGAY_KTKH.Caption = "Ngày giảm";
            this.NGAY_KTKH.FieldName = "NgayKtkh";
            this.NGAY_KTKH.Name = "NGAY_KTKH";
            this.NGAY_KTKH.OptionsColumn.FixedWidth = true;
            this.NGAY_KTKH.OptionsColumn.ReadOnly = true;
            this.NGAY_KTKH.Visible = true;
            this.NGAY_KTKH.VisibleIndex = 6;
            this.NGAY_KTKH.Width = 95;
            //
            //SO_NAM_SD
            //
            this.SO_NAM_SD.Caption = "Số năm sử dụng";
            this.SO_NAM_SD.FieldName = "SoNamSd";
            this.SO_NAM_SD.Name = "SO_NAM_SD";
            this.SO_NAM_SD.OptionsColumn.FixedWidth = true;
            this.SO_NAM_SD.OptionsColumn.ReadOnly = true;
            this.SO_NAM_SD.Visible = true;
            this.SO_NAM_SD.VisibleIndex = 7;
            this.SO_NAM_SD.Width = 103;
            //
            //GridColumn1
            //
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 9;
            this.GridColumn1.Width = 20;
            //
            //PanelControl1
            //
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnClose);
            this.PanelControl1.Controls.Add(this.btnModify);
            this.PanelControl1.Controls.Add(this.btnGiam);
            this.PanelControl1.Controls.Add(this.btnDelete);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(0, 574);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1008, 38);
            this.PanelControl1.TabIndex = 2;
            //
            //btnClose
            //
            this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 1;
            this.btnClose.Location = new System.Drawing.Point(928, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đó&ng";
            //
            //btnModify
            //
            this.btnModify.ImageIndex = 4;
            this.btnModify.Location = new System.Drawing.Point(89, 7);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "&Sửa";
            //
            //btnGiam
            //
            this.btnGiam.ImageIndex = 2;
            this.btnGiam.Location = new System.Drawing.Point(3, 7);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(80, 30);
            this.btnGiam.TabIndex = 9;
            this.btnGiam.Text = "&Giảm TS";
            //
            //btnDelete
            //
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(175, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Xóa";
            //
            //PagerControl1
            //
            this.PagerControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PagerControl1.Location = new System.Drawing.Point(520, 2);
            this.PagerControl1.Name = "PagerControl1";
            this.PagerControl1.PageIndex = 1;
            this.PagerControl1.PageSize = 5;
            this.PagerControl1.Size = new System.Drawing.Size(486, 36);
            this.PagerControl1.TabIndex = 13;
            this.PagerControl1.TotalPage = 0;
            this.PagerControl1.TotalResult = 0;
            //
            //GroupControl2
            //
            this.GroupControl2.Controls.Add(this.PagerControl1);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl2.Location = new System.Drawing.Point(0, 534);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.ShowCaption = false;
            this.GroupControl2.Size = new System.Drawing.Size(1008, 40);
            this.GroupControl2.TabIndex = 3;
            this.GroupControl2.Text = "GroupControl2";
            //
            //frmKhaiBaoGiamTaiSan_DanhSach
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.GroupControl2);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "frmKhaiBaoGiamTaiSan_DanhSach";
            this.Text = "Khai báo giảm tài sản";
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grc_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grv_TSCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
            this.GroupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnGiam;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraGrid.GridControl grc_TSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grv_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LOAITAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_MUA;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDKH;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_NAM_SD;
        internal DevExpress.XtraGrid.Columns.GridColumn GIAM_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_KTKH;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal Vns.Erp.Core.Common.Controls.PagerControl PagerControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
       
    }
}