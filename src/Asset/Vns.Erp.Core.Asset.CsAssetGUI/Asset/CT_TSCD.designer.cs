using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class CT_TSCD : DevExpress.XtraReports.UI.XtraReport
    {

        //XtraReport overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Designer
        //It can be modified using the Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CT_TSCD));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.CT_CHCT = new DevExpress.XtraReports.UI.XRTableCell();
            this.CT_NGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.CT_DIEN_GIAI = new DevExpress.XtraReports.UI.XRTableCell();
            this.CT_NGUEN_GIA = new DevExpress.XtraReports.UI.XRTableCell();
            this.CT_NAM = new DevExpress.XtraReports.UI.XRTableCell();
            this.CT_GTHM = new DevExpress.XtraReports.UI.XRTableCell();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.XrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.XrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.XrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 20F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table3
            // 
            this.table3.BackColor = System.Drawing.Color.Transparent;
            this.table3.BorderColor = System.Drawing.SystemColors.ControlText;
            this.table3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.table3.BorderWidth = 1;
            this.table3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.table3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table3.Name = "table3";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(765F, 20F);
            this.table3.StylePriority.UseBorders = false;
            this.table3.StylePriority.UseTextAlignment = false;
            this.table3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.CT_CHCT,
            this.CT_NGAY,
            this.CT_DIEN_GIAI,
            this.CT_NGUEN_GIA,
            this.CT_NAM,
            this.CT_GTHM});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1D;
            // 
            // CT_CHCT
            // 
            this.CT_CHCT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.SoCt")});
            this.CT_CHCT.Name = "CT_CHCT";
            this.CT_CHCT.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.CT_CHCT.StylePriority.UsePadding = false;
            this.CT_CHCT.StylePriority.UseTextAlignment = false;
            this.CT_CHCT.Text = "CT_CHCT";
            this.CT_CHCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.CT_CHCT.Weight = 0.225490196078431D;
            // 
            // CT_NGAY
            // 
            this.CT_NGAY.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.NgayCt", "{0:dd/MM/yyyy}")});
            this.CT_NGAY.Name = "CT_NGAY";
            this.CT_NGAY.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.CT_NGAY.StylePriority.UsePadding = false;
            this.CT_NGAY.StylePriority.UseTextAlignment = false;
            this.CT_NGAY.Text = "CT_NGAY";
            this.CT_NGAY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.CT_NGAY.Weight = 0.391176470588235D;
            // 
            // CT_DIEN_GIAI
            // 
            this.CT_DIEN_GIAI.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.TenLydoTanggiam")});
            this.CT_DIEN_GIAI.Name = "CT_DIEN_GIAI";
            this.CT_DIEN_GIAI.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.CT_DIEN_GIAI.StylePriority.UsePadding = false;
            this.CT_DIEN_GIAI.StylePriority.UseTextAlignment = false;
            this.CT_DIEN_GIAI.Text = "CT_DIEN_GIAI";
            this.CT_DIEN_GIAI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.CT_DIEN_GIAI.Weight = 0.85D;
            // 
            // CT_NGUEN_GIA
            // 
            this.CT_NGUEN_GIA.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.NguyenGia", "{0:n0}")});
            this.CT_NGUEN_GIA.Name = "CT_NGUEN_GIA";
            this.CT_NGUEN_GIA.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.CT_NGUEN_GIA.StylePriority.UsePadding = false;
            this.CT_NGUEN_GIA.StylePriority.UseTextAlignment = false;
            this.CT_NGUEN_GIA.Text = "CT_NGUEN_GIA";
            this.CT_NGUEN_GIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.CT_NGUEN_GIA.Weight = 0.356862745098039D;
            // 
            // CT_NAM
            // 
            this.CT_NAM.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.Nam")});
            this.CT_NAM.Name = "CT_NAM";
            this.CT_NAM.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.CT_NAM.StylePriority.UsePadding = false;
            this.CT_NAM.StylePriority.UseTextAlignment = false;
            this.CT_NAM.Text = "CT_NAM";
            this.CT_NAM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.CT_NAM.Weight = 0.294117647058824D;
            // 
            // CT_GTHM
            // 
            this.CT_GTHM.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.HaoMonThang", "{0:n0}")});
            this.CT_GTHM.Name = "CT_GTHM";
            this.CT_GTHM.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.CT_GTHM.StylePriority.UsePadding = false;
            this.CT_GTHM.StylePriority.UseTextAlignment = false;
            this.CT_GTHM.Text = "CT_GTHM";
            this.CT_GTHM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.CT_GTHM.Weight = 0.882352941176471D;
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(766F, 60F);
            this.table1.StylePriority.UseTextAlignment = false;
            this.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell4,
            this.tableCell6,
            this.tableCell3});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell4
            // 
            this.tableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StylePriority.UseBorders = false;
            this.tableCell4.Text = "Số hiệu Chứng từ";
            this.tableCell4.Weight = 0.226205997392438D;
            // 
            // tableCell6
            // 
            this.tableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1,
            this.label4,
            this.label3,
            this.label2});
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Weight = 1.59452411994785D;
            // 
            // label1
            // 
            this.label1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(408F, 25F);
            this.label1.StylePriority.UseBorders = false;
            this.label1.Text = "Nguyên giá tài sản cố định";
            // 
            // label4
            // 
            this.label4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(317F, 25F);
            this.label4.Multiline = true;
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(91F, 35F);
            this.label4.StylePriority.UseBorders = false;
            this.label4.Text = "Nguyên giá";
            // 
            // label3
            // 
            this.label3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(100F, 25F);
            this.label3.Multiline = true;
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(217F, 35F);
            this.label3.StylePriority.UseBorders = false;
            this.label3.Text = "Diễn giải";
            // 
            // label2
            // 
            this.label2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.label2.Multiline = true;
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.SizeF = new System.Drawing.SizeF(100F, 35F);
            this.label2.StylePriority.UseBorders = false;
            this.label2.Text = "Ngày, Tháng, năm";
            // 
            // tableCell3
            // 
            this.tableCell3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label7,
            this.label6,
            this.label5});
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.Weight = 1.17535853976532D;
            // 
            // label7
            // 
            this.label7.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(84F, 25F);
            this.label7.Multiline = true;
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label7.SizeF = new System.Drawing.SizeF(216F, 35F);
            this.label7.StylePriority.UseBorders = false;
            this.label7.Text = "Giá trị hao mòn";
            // 
            // label6
            // 
            this.label6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.label6.Multiline = true;
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(75F, 35F);
            this.label6.StylePriority.UseBorders = false;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label5.Name = "label5";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label5.SizeF = new System.Drawing.SizeF(300F, 25F);
            this.label5.StylePriority.UseBorders = false;
            this.label5.Text = "Giá trị hao mòn tài sản cố định";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2,
            this.table1});
            this.GroupHeader2.HeightF = 78F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.Transparent;
            this.table2.BorderColor = System.Drawing.SystemColors.ControlText;
            this.table2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.table2.BorderWidth = 1;
            this.table2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.table2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 58F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(765F, 20F);
            this.table2.StylePriority.UseBorders = false;
            this.table2.StylePriority.UseTextAlignment = false;
            this.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8,
            this.tableCell1,
            this.tableCell2,
            this.tableCell10,
            this.tableCell9});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell7
            // 
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Text = "A";
            this.tableCell7.Weight = 0.225490196078431D;
            // 
            // tableCell8
            // 
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Text = "B";
            this.tableCell8.Weight = 0.391176470588235D;
            // 
            // tableCell1
            // 
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.Text = "C";
            this.tableCell1.Weight = 0.85D;
            // 
            // tableCell2
            // 
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.Text = "1";
            this.tableCell2.Weight = 0.356862745098039D;
            // 
            // tableCell10
            // 
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Text = "2";
            this.tableCell10.Weight = 0.294117647058824D;
            // 
            // tableCell9
            // 
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Text = "3";
            this.tableCell9.Weight = 0.882352941176471D;
            // 
            // XrLabel2
            // 
            this.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.HaoMonThang")});
            this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(467F, 0F);
            this.XrLabel2.Name = "XrLabel2";
            this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel2.SizeF = new System.Drawing.SizeF(139F, 18F);
            this.XrLabel2.StylePriority.UseBorders = false;
            this.XrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n0}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.XrLabel2.Summary = xrSummary1;
            this.XrLabel2.Text = "XrLabel2";
            this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // XrLabel3
            // 
            this.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(358F, 0F);
            this.XrLabel3.Name = "XrLabel3";
            this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel3.SizeF = new System.Drawing.SizeF(100F, 18F);
            this.XrLabel3.StylePriority.UseBorders = false;
            this.XrLabel3.StylePriority.UseTextAlignment = false;
            this.XrLabel3.Text = "Tổng hao mòn :";
            this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrTable1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Nam", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 20F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // XrTable1
            // 
            this.XrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.XrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.XrTable1.Name = "XrTable1";
            this.XrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.XrTableRow1});
            this.XrTable1.SizeF = new System.Drawing.SizeF(765.25F, 20F);
            this.XrTable1.StylePriority.UseBorders = false;
            // 
            // XrTableRow1
            // 
            this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.XrTableCell1,
            this.XrTableCell2});
            this.XrTableRow1.Name = "XrTableRow1";
            this.XrTableRow1.Weight = 1D;
            // 
            // XrTableCell1
            // 
            this.XrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CtTscd.Nam")});
            this.XrTableCell1.Name = "XrTableCell1";
            this.XrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.XrTableCell1.StylePriority.UsePadding = false;
            this.XrTableCell1.StylePriority.UseTextAlignment = false;
            this.XrTableCell1.Text = "XrTableCell1";
            this.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.XrTableCell1.Weight = 0.615861620746813D;
            // 
            // XrTableCell2
            // 
            this.XrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel2,
            this.XrLabel3});
            this.XrTableCell2.Name = "XrTableCell2";
            this.XrTableCell2.Weight = 2.38120104243857D;
            // 
            // TopMarginBand1
            // 
            this.TopMarginBand1.Name = "TopMarginBand1";
            // 
            // BottomMarginBand1
            // 
            this.BottomMarginBand1.Name = "BottomMarginBand1";
            // 
            // CT_TSCD
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1,
            this.TopMarginBand1,
            this.BottomMarginBand1});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Margins = new System.Drawing.Printing.Margins(40, 40, 100, 100);
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        internal DevExpress.XtraReports.UI.DetailBand Detail;
        internal DevExpress.XtraReports.UI.XRTable table1;
        internal DevExpress.XtraReports.UI.XRTableRow tableRow1;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell4;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell6;
        internal DevExpress.XtraReports.UI.XRLabel label1;
        internal DevExpress.XtraReports.UI.XRLabel label4;
        internal DevExpress.XtraReports.UI.XRLabel label3;
        internal DevExpress.XtraReports.UI.XRLabel label2;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell3;
        internal DevExpress.XtraReports.UI.XRLabel label7;
        internal DevExpress.XtraReports.UI.XRLabel label6;
        internal DevExpress.XtraReports.UI.XRLabel label5;
        internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        internal DevExpress.XtraReports.UI.XRTable table3;
        internal DevExpress.XtraReports.UI.XRTableRow tableRow3;
        internal DevExpress.XtraReports.UI.XRTableCell CT_CHCT;
        internal DevExpress.XtraReports.UI.XRTableCell CT_NGAY;
        internal DevExpress.XtraReports.UI.XRTableCell CT_DIEN_GIAI;
        internal DevExpress.XtraReports.UI.XRTableCell CT_NGUEN_GIA;
        internal DevExpress.XtraReports.UI.XRTableCell CT_NAM;
        internal DevExpress.XtraReports.UI.XRTableCell CT_GTHM;
        internal DevExpress.XtraReports.UI.XRTable table2;
        internal DevExpress.XtraReports.UI.XRTableRow tableRow2;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell7;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell8;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell1;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell2;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell10;
        internal DevExpress.XtraReports.UI.XRTableCell tableCell9;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
        internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
        internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        internal DevExpress.XtraReports.UI.XRTable XrTable1;
        internal DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell2;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell1;
        internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
        internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
        public CT_TSCD()
        {
            InitializeComponent();
        }
    }
}