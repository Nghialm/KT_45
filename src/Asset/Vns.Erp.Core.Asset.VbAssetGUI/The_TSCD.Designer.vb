<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class The_TSCD
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(The_TSCD))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.CT_TSCD1 = New CT_TSCD()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.Ptkt1 = New PTKT()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDia_Chi = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDon_VI = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.TSCD_ID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_Ten_TSCD = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSoHieu = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNuocSanXuat = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNamSanXuat = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblBoPhanQuanLy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNamSuDung = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblLyDoDC = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPage = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.CT_TSCD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ptkt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 277.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 275.0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 33.0!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = Me.CT_TSCD1
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(783.0!, 100.0!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 150.0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.Ptkt1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(783.0!, 83.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel16, Me.lblDia_Chi, Me.XrLabel15, Me.lblDon_VI, Me.XrLabel1})
        Me.PageHeader.HeightF = 102.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(442.0!, 42.0!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(333.0!, 42.0!)
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "(Ban hành theo QĐ số 15/2006/QĐ-BTC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ngày 20/03/2006 của Bộ trưởng BTC)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(442.0!, 8.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(333.0!, 25.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Mẫu số S23-DN"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblDia_Chi
        '
        Me.lblDia_Chi.LocationFloat = New DevExpress.Utils.PointFloat(83.0!, 42.0!)
        Me.lblDia_Chi.Name = "lblDia_Chi"
        Me.lblDia_Chi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDia_Chi.SizeF = New System.Drawing.SizeF(325.0!, 25.0!)
        '
        'XrLabel15
        '
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 42.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(58.0!, 25.0!)
        Me.XrLabel15.Text = "Địa chỉ :"
        '
        'lblDon_VI
        '
        Me.lblDon_VI.LocationFloat = New DevExpress.Utils.PointFloat(83.0!, 8.0!)
        Me.lblDon_VI.Name = "lblDon_VI"
        Me.lblDon_VI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDon_VI.SizeF = New System.Drawing.SizeF(325.0!, 25.0!)
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 8.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(58.0!, 25.0!)
        Me.XrLabel1.Text = "Đơn vị :"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TSCD_ID, Me.XrLabel18, Me.label9, Me.XrLabel14, Me.XrLabel2, Me.XrLabel3, Me.lbl_Ten_TSCD, Me.XrLabel4, Me.lblSoHieu, Me.XrLabel5, Me.XrLabel6, Me.lblNuocSanXuat, Me.lblNamSanXuat, Me.XrLabel7, Me.lblBoPhanQuanLy, Me.XrLabel8, Me.lblNamSuDung, Me.XrLabel10, Me.XrLabel13, Me.lblLyDoDC, Me.XrLabel9})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 267.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'TSCD_ID
        '
        Me.TSCD_ID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.Id")})
        Me.TSCD_ID.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 83.0!)
        Me.TSCD_ID.Name = "TSCD_ID"
        Me.TSCD_ID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TSCD_ID.SizeF = New System.Drawing.SizeF(192.0!, 25.0!)
        Me.TSCD_ID.Text = "TSCD_ID"
        Me.TSCD_ID.Visible = False
        '
        'XrLabel18
        '
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 117.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(750.0!, 25.0!)
        Me.XrLabel18.Text = "Căn cứ vào biên bản giao nhận TSCD số :.........................................." & _
            "....Ngày..................Tháng......................Năm........................" & _
            "...."
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 0.0!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label9.SizeF = New System.Drawing.SizeF(758.0!, 25.0!)
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "Thẻ tài sản cố định"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(758.0!, 25.0!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Số:........................"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 50.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(758.0!, 25.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Ngày .................tháng .......................Năm..................."
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 142.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel3.Text = "Tên, kí hiệu, quy cách TSCD :"
        '
        'lbl_Ten_TSCD
        '
        Me.lbl_Ten_TSCD.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.TenTscd")})
        Me.lbl_Ten_TSCD.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 142.0!)
        Me.lbl_Ten_TSCD.Name = "lbl_Ten_TSCD"
        Me.lbl_Ten_TSCD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_Ten_TSCD.SizeF = New System.Drawing.SizeF(233.0!, 25.0!)
        Me.lbl_Ten_TSCD.Text = "lbl_Ten_TSCD"
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 142.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(108.0!, 25.0!)
        Me.XrLabel4.Text = "Số hiệu TSCD :"
        '
        'lblSoHieu
        '
        Me.lblSoHieu.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.MaTscd")})
        Me.lblSoHieu.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 142.0!)
        Me.lblSoHieu.Name = "lblSoHieu"
        Me.lblSoHieu.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSoHieu.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.lblSoHieu.Text = "lblSoHieu"
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 167.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel5.Text = "Nước sản suất(xây dựng) :"
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 167.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(108.0!, 25.0!)
        Me.XrLabel6.Text = "Năm sản suất :"
        '
        'lblNuocSanXuat
        '
        Me.lblNuocSanXuat.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.NuocSx")})
        Me.lblNuocSanXuat.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 167.0!)
        Me.lblNuocSanXuat.Name = "lblNuocSanXuat"
        Me.lblNuocSanXuat.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNuocSanXuat.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.lblNuocSanXuat.Text = "lblNuocSanXuat"
        '
        'lblNamSanXuat
        '
        Me.lblNamSanXuat.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.NamSx")})
        Me.lblNamSanXuat.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 167.0!)
        Me.lblNamSanXuat.Name = "lblNamSanXuat"
        Me.lblNamSanXuat.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNamSanXuat.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.lblNamSanXuat.Text = "lblNamSanXuat"
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 192.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel7.Text = "Bộ phận quản lý (sử dụng)"
        '
        'lblBoPhanQuanLy
        '
        Me.lblBoPhanQuanLy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.TenPhongban")})
        Me.lblBoPhanQuanLy.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 192.0!)
        Me.lblBoPhanQuanLy.Name = "lblBoPhanQuanLy"
        Me.lblBoPhanQuanLy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblBoPhanQuanLy.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.lblBoPhanQuanLy.Text = "lblBoPhanQuanLy"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 192.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(108.0!, 25.0!)
        Me.XrLabel8.Text = "Số tháng sử dụng :"
        '
        'lblNamSuDung
        '
        Me.lblNamSuDung.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.SoThangSd")})
        Me.lblNamSuDung.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 192.0!)
        Me.lblNamSuDung.Name = "lblNamSuDung"
        Me.lblNamSuDung.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNamSuDung.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.lblNamSuDung.Text = "lblNamSuDung"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 217.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel10.Text = "Đình chỉ sử dụng TSCD ngày :"
        '
        'XrLabel13
        '
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 242.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel13.Text = "Lý do đình chỉ :"
        '
        'lblLyDoDC
        '
        Me.lblLyDoDC.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 242.0!)
        Me.lblLyDoDC.Name = "lblLyDoDC"
        Me.lblLyDoDC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLyDoDC.SizeF = New System.Drawing.SizeF(575.0!, 25.0!)
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tscd.NgayBdKh", "{0:dd/MM/yyyy}")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 217.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(283.0!, 25.0!)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPage})
        Me.PageFooter.HeightF = 33.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrPage
        '
        Me.xrPage.LocationFloat = New DevExpress.Utils.PointFloat(650.0!, 8.0!)
        Me.xrPage.Name = "xrPage"
        Me.xrPage.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPage.SizeF = New System.Drawing.SizeF(142.0!, 25.0!)
        Me.xrPage.StylePriority.UseTextAlignment = False
        Me.xrPage.Text = "xrPage"
        Me.xrPage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 50.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 50.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'The_TSCD
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.GroupHeader2, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Margins = New System.Drawing.Printing.Margins(40, 0, 50, 50)
        Me.Version = "10.2"
        CType(Me.CT_TSCD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ptkt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents Ptkt1 As PTKT
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl_Ten_TSCD As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSoHieu As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNuocSanXuat As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNamSanXuat As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBoPhanQuanLy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNamSuDung As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLyDoDC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents CT_TSCD1 As CT_TSCD
    Friend WithEvents TSCD_ID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDia_Chi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDon_VI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents xrPage As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
