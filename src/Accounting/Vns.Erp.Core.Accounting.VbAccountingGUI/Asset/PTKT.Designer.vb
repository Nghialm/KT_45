<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PTKT
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PTKT))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.table6 = New DevExpress.XtraReports.UI.XRTable
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.PT_ = New DevExpress.XtraReports.UI.XRTableCell
        Me.PT_TEN_PT = New DevExpress.XtraReports.UI.XRTableCell
        Me.PT_DON_VI = New DevExpress.XtraReports.UI.XRTableCell
        Me.PT_SO_LUONG = New DevExpress.XtraReports.UI.XRTableCell
        Me.PT_GT = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel
        Me.table5 = New DevExpress.XtraReports.UI.XRTable
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.table4 = New DevExpress.XtraReports.UI.XRTable
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PT = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table6})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'table6
        '
        Me.table6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table6.Location = New System.Drawing.Point(0, 0)
        Me.table6.Name = "table6"
        Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6})
        Me.table6.Size = New System.Drawing.Size(765, 25)
        Me.table6.StylePriority.UseBorders = False
        Me.table6.StylePriority.UseTextAlignment = False
        Me.table6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.PT_, Me.PT_TEN_PT, Me.PT_DON_VI, Me.PT_SO_LUONG, Me.PT_GT})
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 1
        '
        'PT_
        '
        Me.PT_.Name = "PT_"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.PT_.Summary = XrSummary1
        Me.PT_.Text = "A1"
        Me.PT_.Weight = 0.25294117647058822
        '
        'PT_TEN_PT
        '
        Me.PT_TEN_PT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DmPtkt.TenPtung", "")})
        Me.PT_TEN_PT.Name = "PT_TEN_PT"
        Me.PT_TEN_PT.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.PT_TEN_PT.StylePriority.UsePadding = False
        Me.PT_TEN_PT.StylePriority.UseTextAlignment = False
        Me.PT_TEN_PT.Text = "PT_TEN_PT"
        Me.PT_TEN_PT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.PT_TEN_PT.Weight = 1.4058823529411766
        '
        'PT_DON_VI
        '
        Me.PT_DON_VI.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DmPtkt.TenDvt", "")})
        Me.PT_DON_VI.Name = "PT_DON_VI"
        Me.PT_DON_VI.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.PT_DON_VI.StylePriority.UsePadding = False
        Me.PT_DON_VI.StylePriority.UseTextAlignment = False
        Me.PT_DON_VI.Text = "PT_DON_VI"
        Me.PT_DON_VI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.PT_DON_VI.Weight = 0.42352941176470588
        '
        'PT_SO_LUONG
        '
        Me.PT_SO_LUONG.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DmPtkt.SoLuong", "")})
        Me.PT_SO_LUONG.Name = "PT_SO_LUONG"
        Me.PT_SO_LUONG.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.PT_SO_LUONG.StylePriority.UsePadding = False
        Me.PT_SO_LUONG.StylePriority.UseTextAlignment = False
        Me.PT_SO_LUONG.Text = "PT_SO_LUONG"
        Me.PT_SO_LUONG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PT_SO_LUONG.Weight = 0.49215686274509807
        '
        'PT_GT
        '
        Me.PT_GT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DmPtkt.SoTien", "{0:n0}")})
        Me.PT_GT.Multiline = True
        Me.PT_GT.Name = "PT_GT"
        Me.PT_GT.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.PT_GT.StylePriority.UsePadding = False
        Me.PT_GT.StylePriority.UseTextAlignment = False
        Me.PT_GT.Text = "PT_GT"
        Me.PT_GT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PT_GT.Weight = 0.42549019607843136
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label10, Me.table5, Me.table4})
        Me.GroupHeader1.Height = 92
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'label10
        '
        Me.label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(0, 0)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label10.Size = New System.Drawing.Size(758, 25)
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "Dụng cụ, phụ tùng kèm theo"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'table5
        '
        Me.table5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table5.Location = New System.Drawing.Point(0, 67)
        Me.table5.Name = "table5"
        Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.table5.Size = New System.Drawing.Size(765, 25)
        Me.table5.StylePriority.UseBorders = False
        Me.table5.StylePriority.UseTextAlignment = False
        Me.table5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26, Me.tableCell27})
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 1
        '
        'tableCell23
        '
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.Text = "A"
        Me.tableCell23.Weight = 0.25294117647058822
        '
        'tableCell24
        '
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.Text = "B"
        Me.tableCell24.Weight = 1.4058823529411766
        '
        'tableCell25
        '
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Text = "C"
        Me.tableCell25.Weight = 0.42352941176470588
        '
        'tableCell26
        '
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.Text = "1"
        Me.tableCell26.Weight = 0.49215686274509807
        '
        'tableCell27
        '
        Me.tableCell27.Name = "tableCell27"
        Me.tableCell27.Text = "2"
        Me.tableCell27.Weight = 0.42549019607843136
        '
        'table4
        '
        Me.table4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.table4.Location = New System.Drawing.Point(0, 42)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.Size = New System.Drawing.Size(765, 25)
        Me.table4.StylePriority.UseBorders = False
        Me.table4.StylePriority.UseTextAlignment = False
        Me.table4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21, Me.tableCell18, Me.tableCell19, Me.tableCell22, Me.tableCell20})
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 1
        '
        'tableCell21
        '
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Text = "STT"
        Me.tableCell21.Weight = 0.25294117647058822
        '
        'tableCell18
        '
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.Text = "Tên, quy cách dụng cụ, phụ tùng"
        Me.tableCell18.Weight = 1.4058823529411766
        '
        'tableCell19
        '
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.Text = "Đon vị"
        Me.tableCell19.Weight = 0.42352941176470588
        '
        'tableCell22
        '
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.Text = "Số lượng"
        Me.tableCell22.Weight = 0.49215686274509807
        '
        'tableCell20
        '
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.Text = "Giá trị"
        Me.tableCell20.Weight = 0.42549019607843136
        '
        'PT
        '
        Me.PT.DataSetName = "NewDataSet"
        Me.PT.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "PT"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "DM_TSCD_ID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TEN_PTUNG"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TEN_DVT"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "SO_LUONG"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "SO_TIEN"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label12, Me.label15, Me.label14, Me.label13, Me.label16})
        Me.ReportFooter.Name = "ReportFooter"
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label12.Location = New System.Drawing.Point(25, 17)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label12.Size = New System.Drawing.Size(133, 20)
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = " Người ghi sổ"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label15
        '
        Me.label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.label15.Location = New System.Drawing.Point(575, 67)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label15.Size = New System.Drawing.Size(150, 17)
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "(Ký, họ tên, đóng dấu)"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label14
        '
        Me.label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.label14.Location = New System.Drawing.Point(25, 42)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label14.Size = New System.Drawing.Size(100, 17)
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "(Ký, họ tên)"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label13
        '
        Me.label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label13.Location = New System.Drawing.Point(575, 42)
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label13.Size = New System.Drawing.Size(133, 20)
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "Kế toán trưởng"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'label16
        '
        Me.label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.label16.Location = New System.Drawing.Point(525, 17)
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label16.Size = New System.Drawing.Size(217, 20)
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Lập, ngày..........tháng.........năm.........."
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PTKT
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader1, Me.ReportFooter})
        Me.DataSource = Me.PT
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Margins = New System.Drawing.Printing.Margins(40, 41, 100, 100)
        Me.Name = "PTKT"
        Me.PageHeight = 1100
        Me.PageWidth = 850
        Me.Version = "9.1"
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents table6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents PT_ As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PT_TEN_PT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PT_DON_VI As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PT_SO_LUONG As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PT_GT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PT As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
End Class
