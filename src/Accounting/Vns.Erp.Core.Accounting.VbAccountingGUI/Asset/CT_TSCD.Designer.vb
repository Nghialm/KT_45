<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CT_TSCD
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_TSCD))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.CT_CHCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CT_NGAY = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CT_DIEN_GIAI = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CT_NGUEN_GIA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CT_NAM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CT_GTHM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'table3
        '
        Me.table3.BackColor = System.Drawing.Color.Transparent
        Me.table3.BorderColor = System.Drawing.SystemColors.ControlText
        Me.table3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table3.BorderWidth = 1
        Me.table3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.table3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table3.Name = "table3"
        Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(765.0!, 20.0!)
        Me.table3.StylePriority.UseBorders = False
        Me.table3.StylePriority.UseTextAlignment = False
        Me.table3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.CT_CHCT, Me.CT_NGAY, Me.CT_DIEN_GIAI, Me.CT_NGUEN_GIA, Me.CT_NAM, Me.CT_GTHM})
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 1.0R
        '
        'CT_CHCT
        '
        Me.CT_CHCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.SoCt")})
        Me.CT_CHCT.Name = "CT_CHCT"
        Me.CT_CHCT.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.CT_CHCT.StylePriority.UsePadding = False
        Me.CT_CHCT.StylePriority.UseTextAlignment = False
        Me.CT_CHCT.Text = "CT_CHCT"
        Me.CT_CHCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CT_CHCT.Weight = 0.22549019607843138R
        '
        'CT_NGAY
        '
        Me.CT_NGAY.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.NgayCt", "{0:dd/MM/yyyy}")})
        Me.CT_NGAY.Name = "CT_NGAY"
        Me.CT_NGAY.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.CT_NGAY.StylePriority.UsePadding = False
        Me.CT_NGAY.StylePriority.UseTextAlignment = False
        Me.CT_NGAY.Text = "CT_NGAY"
        Me.CT_NGAY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CT_NGAY.Weight = 0.39117647058823535R
        '
        'CT_DIEN_GIAI
        '
        Me.CT_DIEN_GIAI.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.TenLydoTanggiam")})
        Me.CT_DIEN_GIAI.Name = "CT_DIEN_GIAI"
        Me.CT_DIEN_GIAI.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.CT_DIEN_GIAI.StylePriority.UsePadding = False
        Me.CT_DIEN_GIAI.StylePriority.UseTextAlignment = False
        Me.CT_DIEN_GIAI.Text = "CT_DIEN_GIAI"
        Me.CT_DIEN_GIAI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CT_DIEN_GIAI.Weight = 0.85R
        '
        'CT_NGUEN_GIA
        '
        Me.CT_NGUEN_GIA.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.NguyenGia", "{0:n0}")})
        Me.CT_NGUEN_GIA.Name = "CT_NGUEN_GIA"
        Me.CT_NGUEN_GIA.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.CT_NGUEN_GIA.StylePriority.UsePadding = False
        Me.CT_NGUEN_GIA.StylePriority.UseTextAlignment = False
        Me.CT_NGUEN_GIA.Text = "CT_NGUEN_GIA"
        Me.CT_NGUEN_GIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.CT_NGUEN_GIA.Weight = 0.35686274509803917R
        '
        'CT_NAM
        '
        Me.CT_NAM.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.Nam")})
        Me.CT_NAM.Name = "CT_NAM"
        Me.CT_NAM.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.CT_NAM.StylePriority.UsePadding = False
        Me.CT_NAM.StylePriority.UseTextAlignment = False
        Me.CT_NAM.Text = "CT_NAM"
        Me.CT_NAM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.CT_NAM.Weight = 0.29411764705882354R
        '
        'CT_GTHM
        '
        Me.CT_GTHM.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.MucKhauHao", "{0:n0}")})
        Me.CT_GTHM.Name = "CT_GTHM"
        Me.CT_GTHM.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.CT_GTHM.StylePriority.UsePadding = False
        Me.CT_GTHM.StylePriority.UseTextAlignment = False
        Me.CT_GTHM.Text = "CT_GTHM"
        Me.CT_GTHM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.CT_GTHM.Weight = 0.88235294117647056R
        '
        'table1
        '
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(766.0!, 60.0!)
        Me.table1.StylePriority.UseTextAlignment = False
        Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4, Me.tableCell6, Me.tableCell3})
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1.0R
        '
        'tableCell4
        '
        Me.tableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell4.Multiline = True
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBorders = False
        Me.tableCell4.Text = "Số hiệu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chứng từ"
        Me.tableCell4.Weight = 0.22620599739243805R
        '
        'tableCell6
        '
        Me.tableCell6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.label4, Me.label3, Me.label2})
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.Weight = 1.5945241199478488R
        '
        'label1
        '
        Me.label1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.SizeF = New System.Drawing.SizeF(408.0!, 25.0!)
        Me.label1.StylePriority.UseBorders = False
        Me.label1.Text = "Nguyên giá tài sản cố định"
        '
        'label4
        '
        Me.label4.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(317.0!, 25.0!)
        Me.label4.Multiline = True
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label4.SizeF = New System.Drawing.SizeF(91.0!, 35.0!)
        Me.label4.StylePriority.UseBorders = False
        Me.label4.Text = "Nguyên " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "giá"
        '
        'label3
        '
        Me.label3.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 25.0!)
        Me.label3.Multiline = True
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label3.SizeF = New System.Drawing.SizeF(217.0!, 35.0!)
        Me.label3.StylePriority.UseBorders = False
        Me.label3.Text = "Diễn giải"
        '
        'label2
        '
        Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.0!)
        Me.label2.Multiline = True
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label2.SizeF = New System.Drawing.SizeF(100.0!, 35.0!)
        Me.label2.StylePriority.UseBorders = False
        Me.label2.Text = "Ngày" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tháng, năm"
        '
        'tableCell3
        '
        Me.tableCell3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label7, Me.label6, Me.label5})
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.Weight = 1.1753585397653192R
        '
        'label7
        '
        Me.label7.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(84.0!, 25.0!)
        Me.label7.Multiline = True
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label7.SizeF = New System.Drawing.SizeF(216.0!, 35.0!)
        Me.label7.StylePriority.UseBorders = False
        Me.label7.Text = "Giá trị hao mòn"
        '
        'label6
        '
        Me.label6.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.0!)
        Me.label6.Multiline = True
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label6.SizeF = New System.Drawing.SizeF(75.0!, 35.0!)
        Me.label6.StylePriority.UseBorders = False
        Me.label6.Text = "Năm"
        '
        'label5
        '
        Me.label5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label5.SizeF = New System.Drawing.SizeF(300.0!, 25.0!)
        Me.label5.StylePriority.UseBorders = False
        Me.label5.Text = "Giá trị hao mòn tài sản cố định"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2, Me.table1})
        Me.GroupHeader2.HeightF = 78.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'table2
        '
        Me.table2.BackColor = System.Drawing.Color.Transparent
        Me.table2.BorderColor = System.Drawing.SystemColors.ControlText
        Me.table2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table2.BorderWidth = 1
        Me.table2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.table2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 58.0!)
        Me.table2.Name = "table2"
        Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(765.0!, 20.0!)
        Me.table2.StylePriority.UseBorders = False
        Me.table2.StylePriority.UseTextAlignment = False
        Me.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell8, Me.tableCell1, Me.tableCell2, Me.tableCell10, Me.tableCell9})
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1.0R
        '
        'tableCell7
        '
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.Text = "A"
        Me.tableCell7.Weight = 0.22549019607843138R
        '
        'tableCell8
        '
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.Text = "B"
        Me.tableCell8.Weight = 0.39117647058823535R
        '
        'tableCell1
        '
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.Text = "C"
        Me.tableCell1.Weight = 0.85R
        '
        'tableCell2
        '
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.Text = "1"
        Me.tableCell2.Weight = 0.35686274509803917R
        '
        'tableCell10
        '
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.Text = "2"
        Me.tableCell10.Weight = 0.29411764705882354R
        '
        'tableCell9
        '
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.Text = "3"
        Me.tableCell9.Weight = 0.88235294117647056R
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.HaoMonLk")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(467.0!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(139.0!, 18.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n0}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel2.Summary = XrSummary1
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(358.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Tổng hao mòn :"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Nam", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 20.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(765.25!, 20.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CtTscd.Nam")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 0.61586162074681317R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel3})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Weight = 2.3812010424385655R
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'CT_TSCD
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Margins = New System.Drawing.Printing.Margins(40, 40, 100, 100)
        Me.Version = "10.2"
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents CT_CHCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CT_NGAY As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CT_DIEN_GIAI As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CT_NGUEN_GIA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CT_NAM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CT_GTHM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
