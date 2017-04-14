using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class The_TSCD : DevExpress.XtraReports.UI.XtraReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_TSCD));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.XrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.XrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.CT_TSCD1 = new Vns.Erp.Core.Asset.CsAssetGUI.CT_TSCD();
            this.XrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Ptkt1 = new Vns.Erp.Core.Asset.CsAssetGUI.PTKT();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDia_Chi = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDon_VI = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.TSCD_ID = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbl_Ten_TSCD = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSoHieu = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNuocSanXuat = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNamSanXuat = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBoPhanQuanLy = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNamSuDung = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLyDoDC = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPage = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.CT_TSCD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptkt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrPageBreak1,
            this.XrSubreport2,
            this.XrSubreport1});
            this.Detail.HeightF = 277F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrPageBreak1
            // 
            this.XrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 275F);
            this.XrPageBreak1.Name = "XrPageBreak1";
            // 
            // XrSubreport2
            // 
            this.XrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(8F, 33F);
            this.XrSubreport2.Name = "XrSubreport2";
            this.XrSubreport2.ReportSource = this.CT_TSCD1;
            this.XrSubreport2.SizeF = new System.Drawing.SizeF(783F, 100F);
            // 
            // XrSubreport1
            // 
            this.XrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(8F, 150F);
            this.XrSubreport1.Name = "XrSubreport1";
            this.XrSubreport1.ReportSource = this.Ptkt1;
            this.XrSubreport1.SizeF = new System.Drawing.SizeF(783F, 83F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel17,
            this.XrLabel16,
            this.lblDia_Chi,
            this.XrLabel15,
            this.lblDon_VI,
            this.XrLabel1});
            this.PageHeader.HeightF = 102F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrLabel17
            // 
            this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(442F, 42F);
            this.XrLabel17.Multiline = true;
            this.XrLabel17.Name = "XrLabel17";
            this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel17.SizeF = new System.Drawing.SizeF(333F, 42F);
            this.XrLabel17.StylePriority.UseTextAlignment = false;
            this.XrLabel17.Text = "(Ban hành theo QĐ số 15/2006/QĐ-BTCngày 20/03/2006 của Bộ trưởng BTC)";
            this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // XrLabel16
            // 
            this.XrLabel16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(442F, 8F);
            this.XrLabel16.Name = "XrLabel16";
            this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel16.SizeF = new System.Drawing.SizeF(333F, 25F);
            this.XrLabel16.StylePriority.UseFont = false;
            this.XrLabel16.StylePriority.UseTextAlignment = false;
            this.XrLabel16.Text = "Mẫu số S23-DN";
            this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblDia_Chi
            // 
            this.lblDia_Chi.LocationFloat = new DevExpress.Utils.PointFloat(83F, 42F);
            this.lblDia_Chi.Name = "lblDia_Chi";
            this.lblDia_Chi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDia_Chi.SizeF = new System.Drawing.SizeF(325F, 25F);
            // 
            // XrLabel15
            // 
            this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(17F, 42F);
            this.XrLabel15.Name = "XrLabel15";
            this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel15.SizeF = new System.Drawing.SizeF(58F, 25F);
            this.XrLabel15.Text = "Địa chỉ :";
            // 
            // lblDon_VI
            // 
            this.lblDon_VI.LocationFloat = new DevExpress.Utils.PointFloat(83F, 8F);
            this.lblDon_VI.Name = "lblDon_VI";
            this.lblDon_VI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDon_VI.SizeF = new System.Drawing.SizeF(325F, 25F);
            // 
            // XrLabel1
            // 
            this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(17F, 8F);
            this.XrLabel1.Name = "XrLabel1";
            this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel1.SizeF = new System.Drawing.SizeF(58F, 25F);
            this.XrLabel1.Text = "Đơn vị :";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TSCD_ID,
            this.XrLabel18,
            this.label9,
            this.XrLabel14,
            this.XrLabel2,
            this.XrLabel3,
            this.lbl_Ten_TSCD,
            this.XrLabel4,
            this.lblSoHieu,
            this.XrLabel5,
            this.XrLabel6,
            this.lblNuocSanXuat,
            this.lblNamSanXuat,
            this.XrLabel7,
            this.lblBoPhanQuanLy,
            this.XrLabel8,
            this.lblNamSuDung,
            this.XrLabel10,
            this.XrLabel13,
            this.lblLyDoDC,
            this.XrLabel9});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.HeightF = 267F;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            // 
            // TSCD_ID
            // 
            this.TSCD_ID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.Id")});
            this.TSCD_ID.LocationFloat = new DevExpress.Utils.PointFloat(25F, 83F);
            this.TSCD_ID.Name = "TSCD_ID";
            this.TSCD_ID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TSCD_ID.SizeF = new System.Drawing.SizeF(192F, 25F);
            this.TSCD_ID.Text = "TSCD_ID";
            this.TSCD_ID.Visible = false;
            // 
            // XrLabel18
            // 
            this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(17F, 117F);
            this.XrLabel18.Name = "XrLabel18";
            this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel18.SizeF = new System.Drawing.SizeF(750F, 25F);
            this.XrLabel18.Text = "Căn cứ vào biên bản giao nhận TSCD số :.........................................." +
                "....Ngày..................Tháng......................Năm........................" +
                "....";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0F);
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label9.SizeF = new System.Drawing.SizeF(758F, 25F);
            this.label9.StylePriority.UseFont = false;
            this.label9.StylePriority.UseTextAlignment = false;
            this.label9.Text = "Thẻ tài sản cố định";
            this.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrLabel14
            // 
            this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            this.XrLabel14.Name = "XrLabel14";
            this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel14.SizeF = new System.Drawing.SizeF(758F, 25F);
            this.XrLabel14.StylePriority.UseTextAlignment = false;
            this.XrLabel14.Text = "Số:........................";
            this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // XrLabel2
            // 
            this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(25F, 50F);
            this.XrLabel2.Name = "XrLabel2";
            this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel2.SizeF = new System.Drawing.SizeF(758F, 25F);
            this.XrLabel2.StylePriority.UseTextAlignment = false;
            this.XrLabel2.Text = "Ngày .................tháng .......................Năm...................";
            this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // XrLabel3
            // 
            this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(17F, 142F);
            this.XrLabel3.Name = "XrLabel3";
            this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel3.SizeF = new System.Drawing.SizeF(175F, 25F);
            this.XrLabel3.Text = "Tên, kí hiệu, quy cách TSCD :";
            // 
            // lbl_Ten_TSCD
            // 
            this.lbl_Ten_TSCD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.TenTscd")});
            this.lbl_Ten_TSCD.LocationFloat = new DevExpress.Utils.PointFloat(192F, 142F);
            this.lbl_Ten_TSCD.Name = "lbl_Ten_TSCD";
            this.lbl_Ten_TSCD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbl_Ten_TSCD.SizeF = new System.Drawing.SizeF(233F, 25F);
            this.lbl_Ten_TSCD.Text = "lbl_Ten_TSCD";
            // 
            // XrLabel4
            // 
            this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(450F, 142F);
            this.XrLabel4.Name = "XrLabel4";
            this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel4.SizeF = new System.Drawing.SizeF(108F, 25F);
            this.XrLabel4.Text = "Số hiệu TSCD :";
            // 
            // lblSoHieu
            // 
            this.lblSoHieu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.MaTscd")});
            this.lblSoHieu.LocationFloat = new DevExpress.Utils.PointFloat(567F, 142F);
            this.lblSoHieu.Name = "lblSoHieu";
            this.lblSoHieu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSoHieu.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.lblSoHieu.Text = "lblSoHieu";
            // 
            // XrLabel5
            // 
            this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(17F, 167F);
            this.XrLabel5.Name = "XrLabel5";
            this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel5.SizeF = new System.Drawing.SizeF(175F, 25F);
            this.XrLabel5.Text = "Nước sản suất(xây dựng) :";
            // 
            // XrLabel6
            // 
            this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(450F, 167F);
            this.XrLabel6.Name = "XrLabel6";
            this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel6.SizeF = new System.Drawing.SizeF(108F, 25F);
            this.XrLabel6.Text = "Năm sản suất :";
            // 
            // lblNuocSanXuat
            // 
            this.lblNuocSanXuat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.NuocSx")});
            this.lblNuocSanXuat.LocationFloat = new DevExpress.Utils.PointFloat(192F, 167F);
            this.lblNuocSanXuat.Name = "lblNuocSanXuat";
            this.lblNuocSanXuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNuocSanXuat.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.lblNuocSanXuat.Text = "lblNuocSanXuat";
            // 
            // lblNamSanXuat
            // 
            this.lblNamSanXuat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.NamSx")});
            this.lblNamSanXuat.LocationFloat = new DevExpress.Utils.PointFloat(567F, 167F);
            this.lblNamSanXuat.Name = "lblNamSanXuat";
            this.lblNamSanXuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNamSanXuat.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.lblNamSanXuat.Text = "lblNamSanXuat";
            // 
            // XrLabel7
            // 
            this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(17F, 192F);
            this.XrLabel7.Name = "XrLabel7";
            this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel7.SizeF = new System.Drawing.SizeF(175F, 25F);
            this.XrLabel7.Text = "Bộ phận quản lý (sử dụng)";
            // 
            // lblBoPhanQuanLy
            // 
            this.lblBoPhanQuanLy.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.TenPhongban")});
            this.lblBoPhanQuanLy.LocationFloat = new DevExpress.Utils.PointFloat(192F, 192F);
            this.lblBoPhanQuanLy.Name = "lblBoPhanQuanLy";
            this.lblBoPhanQuanLy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBoPhanQuanLy.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.lblBoPhanQuanLy.Text = "lblBoPhanQuanLy";
            // 
            // XrLabel8
            // 
            this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(450F, 192F);
            this.XrLabel8.Name = "XrLabel8";
            this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel8.SizeF = new System.Drawing.SizeF(108F, 25F);
            this.XrLabel8.Text = "Số tháng sử dụng :";
            // 
            // lblNamSuDung
            // 
            this.lblNamSuDung.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tscd.SoThangSd")});
            this.lblNamSuDung.LocationFloat = new DevExpress.Utils.PointFloat(567F, 192F);
            this.lblNamSuDung.Name = "lblNamSuDung";
            this.lblNamSuDung.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNamSuDung.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.lblNamSuDung.Text = "lblNamSuDung";
            // 
            // XrLabel10
            // 
            this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(17F, 217F);
            this.XrLabel10.Name = "XrLabel10";
            this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel10.SizeF = new System.Drawing.SizeF(175F, 25F);
            this.XrLabel10.Text = "Đình chỉ sử dụng TSCD ngày :";
            // 
            // XrLabel13
            // 
            this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(17F, 242F);
            this.XrLabel13.Name = "XrLabel13";
            this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel13.SizeF = new System.Drawing.SizeF(175F, 25F);
            this.XrLabel13.Text = "Lý do đình chỉ :";
            // 
            // lblLyDoDC
            // 
            this.lblLyDoDC.LocationFloat = new DevExpress.Utils.PointFloat(192F, 242F);
            this.lblLyDoDC.Name = "lblLyDoDC";
            this.lblLyDoDC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLyDoDC.SizeF = new System.Drawing.SizeF(575F, 25F);
            // 
            // XrLabel9
            // 
            this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(192F, 217F);
            this.XrLabel9.Name = "XrLabel9";
            this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel9.SizeF = new System.Drawing.SizeF(283F, 25F);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPage});
            this.PageFooter.HeightF = 33F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPage
            // 
            this.xrPage.LocationFloat = new DevExpress.Utils.PointFloat(650F, 8F);
            this.xrPage.Name = "xrPage";
            this.xrPage.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPage.SizeF = new System.Drawing.SizeF(142F, 25F);
            this.xrPage.StylePriority.UseTextAlignment = false;
            this.xrPage.Text = "xrPage";
            this.xrPage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // TopMarginBand1
            // 
            this.TopMarginBand1.HeightF = 50F;
            this.TopMarginBand1.Name = "TopMarginBand1";
            // 
            // BottomMarginBand1
            // 
            this.BottomMarginBand1.HeightF = 50F;
            this.BottomMarginBand1.Name = "BottomMarginBand1";
            // 
            // The_TSCD
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.GroupHeader2,
            this.PageFooter,
            this.TopMarginBand1,
            this.BottomMarginBand1});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Margins = new System.Drawing.Printing.Margins(40, 0, 50, 50);
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.CT_TSCD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptkt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        internal DevExpress.XtraReports.UI.DetailBand Detail;
        internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        internal DevExpress.XtraReports.UI.XRSubreport XrSubreport1;
        private PTKT Ptkt1;
        internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
        internal DevExpress.XtraReports.UI.XRLabel label9;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
        internal DevExpress.XtraReports.UI.XRLabel lbl_Ten_TSCD;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
        internal DevExpress.XtraReports.UI.XRLabel lblSoHieu;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
        internal DevExpress.XtraReports.UI.XRLabel lblNuocSanXuat;
        internal DevExpress.XtraReports.UI.XRLabel lblNamSanXuat;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
        internal DevExpress.XtraReports.UI.XRLabel lblBoPhanQuanLy;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
        internal DevExpress.XtraReports.UI.XRLabel lblNamSuDung;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
        internal DevExpress.XtraReports.UI.XRLabel lblLyDoDC;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
        internal DevExpress.XtraReports.UI.XRSubreport XrSubreport2;
        private CT_TSCD CT_TSCD1;
        internal DevExpress.XtraReports.UI.XRLabel TSCD_ID;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
        internal DevExpress.XtraReports.UI.XRLabel lblDia_Chi;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
        internal DevExpress.XtraReports.UI.XRLabel lblDon_VI;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
        internal DevExpress.XtraReports.UI.XRPageBreak XrPageBreak1;
        internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        internal DevExpress.XtraReports.UI.XRLabel xrPage;
        internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
        internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
        public The_TSCD()
        {
            InitializeComponent();
        }
    }
}