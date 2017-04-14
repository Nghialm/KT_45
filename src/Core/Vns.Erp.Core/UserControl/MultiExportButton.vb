Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports System.Windows.Forms

Public Class MultiExportButton

#Region "Variables"
    Private _GRID_VIEW As Object
    'XLS : EXCEL
    'PDF : PDF
    'RTF : RTF
    'TXT : TEXT
    'HTML : HTML
    '* : OTHER

    Public Property GRID_VIEW() As Object
        Get
            Return _GRID_VIEW
        End Get
        Set(ByVal value As Object)
            _GRID_VIEW = value
        End Set
    End Property
#End Region

#Region "Export"

    Private Sub MultiExportButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.DesignMode Then
                Return
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            DoExport()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Sub DoExport()
        'Try
        If Not GRID_VIEW Is Nothing Then
            Dim _gridview As GridView = New GridView()
            _gridview = TryCast(GRID_VIEW, GridView)
            If Not (_gridview Is Nothing) Then
                ExportOption(GRID_VIEW)
                Return
            End If

            Dim _treeview As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            _treeview = TryCast(GRID_VIEW, DevExpress.XtraTreeList.TreeList)
            If Not (_treeview Is Nothing) Then
                ExportOption(_treeview)
            End If
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Public Sub ExportOption(ByVal grvMain As GridView)
        Dim sfd As New SaveFileDialog
        If String.IsNullOrEmpty(Me.AccessibleDescription) Then
            sfd.FileName = "VKeToanExport"
        Else
            sfd.FileName = Me.AccessibleDescription
        End If

        Dim filter_str = "Excel file (*.xls)|*.xls"
        filter_str = filter_str + "|" + "PDF file (*.pdf)|*.pdf"
        filter_str = filter_str + "|" + "RTF file (*.rtf)|*.rtf"
        filter_str = filter_str + "|" + "TEXT file (*.txt)|*.txt"
        filter_str = filter_str + "|" + "HTML file (*.html)|*.html"
        filter_str = filter_str + "|" + "All file (*.*)|*.*"
        sfd.Filter = filter_str
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim ext As String = Path.GetExtension(sfd.FileName).ToUpper()
            Dim options As New DevExpress.XtraPrinting.XlsExportOptions()
            'options.UseNativeFormat = False
            options.ShowGridLines = True
            options.ExportHyperlinks = True
            'options.Ignore256ColumnsLimit = True
            'options.Ignore65536RowsLimit = True
            options.SheetName = "KTY"
            'options.UseNativeFormat = False
            Select Case ext
                Case ".XLS" 'EXCEL
                    grvMain.ExportToXls(sfd.FileName, options)
                Case ".PDF" 'PDF
                    grvMain.ExportToPdf(sfd.FileName)
                Case ".RTF" 'RTF
                    grvMain.ExportToRtf(sfd.FileName)
                Case ".TXT" 'TEXT
                    grvMain.ExportToText(sfd.FileName)
                Case ".HTML" 'HTML
                    grvMain.ExportToHtml(sfd.FileName)
                Case "" 'OTHER
                    grvMain.ExportToText(sfd.FileName)
            End Select
            Message_Information("File đã được lưu tới " + sfd.FileName)
        End If
    End Sub

    Public Sub ExportOption(ByVal grvMain As DevExpress.XtraTreeList.TreeList)
        Dim sfd As New SaveFileDialog
        Dim filter_str = "Excel file (*.xls)|*.xls"
        filter_str = filter_str + "|" + "PDF file (*.pdf)|*.pdf"
        filter_str = filter_str + "|" + "RTF file (*.rtf)|*.rtf"
        filter_str = filter_str + "|" + "TEXT file (*.txt)|*.txt"
        filter_str = filter_str + "|" + "HTML file (*.html)|*.html"
        filter_str = filter_str + "|" + "All file (*.*)|*.*"
        sfd.Filter = filter_str
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim ext As String = Path.GetExtension(sfd.FileName).ToUpper()
            Dim options As New DevExpress.XtraPrinting.XlsExportOptions()
            'options.UseNativeFormat = False
            options.ShowGridLines = True
            options.ExportHyperlinks = True
            'options.Ignore256ColumnsLimit = True
            'options.Ignore65536RowsLimit = True
            options.SheetName = "KTY"
            'options.UseNativeFormat = False
            Select Case ext
                Case ".XLS" 'EXCEL
                    grvMain.ExportToXls(sfd.FileName, options)
                Case ".PDF" 'PDF
                    grvMain.ExportToPdf(sfd.FileName)
                Case ".RTF" 'RTF
                    grvMain.ExportToRtf(sfd.FileName)
                Case ".TXT" 'TEXT
                    grvMain.ExportToText(sfd.FileName)
                Case ".HTML" 'HTML
                    grvMain.ExportToHtml(sfd.FileName)
                Case "" 'OTHER
                    grvMain.ExportToText(sfd.FileName)
            End Select
            Message_Information("File đã được lưu tới " + sfd.FileName)
        End If
    End Sub
#End Region

End Class
