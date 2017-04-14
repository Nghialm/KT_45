Imports System.Text

Public Class ExportExcelAutoDefine

#Region "Variable"

    Public gridData As DevExpress.XtraGrid.GridControl

    Private m_grvMain As DevExpress.XtraGrid.Views.Grid.GridView

    'Directory File
    Public file As String = String.Empty

    'Number Of File To Export
    Private fileNumber As Integer = Nothing

    'Show Process
    Public flagProcess As Boolean = True

#End Region

#Region "Function"

    Private Sub ExportData()
        'Try
        '    SetLicenseSpreadsheet()
        '    m_grvMain = gridData.MainView

        '    If Not gridData Is Nothing Then
        '        Select Case cboType.Text
        '            Case "XLS"
        '                Dim excelFile As ExcelFile = New ExcelFile
        '                excelFile.GroupMethodsAffectedCellsLimit = 90000000
        '                Dim worksheets As ExcelWorksheetCollection = excelFile.Worksheets

        '                AutoDefineExcel(worksheets.Add("DataExport"))

        '                worksheets.ActiveWorksheet = worksheets("DataExport")

        '                excelFile.SaveXls(file)

        '            Case "PDF"
        '                gridData.ExportToPdf(file)
        '            Case "RTF"
        '                gridData.ExportToText(file)
        '            Case "HTML"
        '                gridData.ExportToHtml(file)
        '            Case Else
        '                gridData.ExportToText(file)
        '        End Select
        '    End If

        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
        Throw New ApplicationException("Exception Occured")
    End Sub

    '    Private Sub AutoDefineExcel(ByVal ws As ExcelWorksheet)

    '        Dim tmpStyle As New CellStyle

    '        Dim dt2 As DataTable = gridData.DataSource

    '        Dim ds As New DataSet

    '        ds.Tables.Add(dt2.Copy)

    '        Dim dt As DataTable = ds.Tables(0)

    '        Dim str As New List(Of String)

    '        Dim isRemove As Boolean = True

    '        If dt.Columns.Contains("ROWNUM") Then

    '            dt.Columns.Remove(dt.Columns("ROWNUM"))

    '        End If

    '        If dt.Columns.Contains("ID") Then

    '            dt.Columns.Remove(dt.Columns("ID"))

    '        End If

    'RemoveBreak:

    '        'Lấy ra các cột trong Datatable không có trong Gridview
    '        For x As Integer = 0 To dt.Columns.Count - 1
    '            For y As Integer = 0 To m_grvMain.Columns.Count - 1

    '                If dt.Columns(x).ToString.Equals(m_grvMain.Columns(y).FieldName) Then
    '                    If m_grvMain.Columns(y).Visible = False Then
    '                        dt.Columns.Remove(dt.Columns(x))
    '                        GoTo RemoveBreak
    '                    Else
    '                        isRemove = True
    '                        Exit For
    '                    End If
    '                Else
    '                    isRemove = False
    '                End If
    '            Next

    '            If isRemove = False Then
    '                dt.Columns.Remove(dt.Columns(x))
    '                GoTo RemoveBreak
    '            End If
    '        Next

    '        tmpStyle.HorizontalAlignment = HorizontalAlignmentStyle.Center
    '        tmpStyle.VerticalAlignment = VerticalAlignmentStyle.Center
    '        tmpStyle.FillPattern.SetSolid(Color.FromArgb(255, 200, 200, 200))
    '        tmpStyle.Font.Name = "Tahoma"
    '        tmpStyle.WrapText = True
    '        tmpStyle.Borders.SetBorders(MultipleBorders.Right Or MultipleBorders.Top Or MultipleBorders.Bottom, m_grvMain.Appearance.Row.BorderColor, LineStyle.Thin)
    '        ws.Cells.GetSubrangeAbsolute(0, 0, 0, dt.Columns.Count - 1).Style = tmpStyle
    '        tmpStyle = New CellStyle

    '        'Bind columns name to excel from gridview
    '        For x As Integer = 0 To dt.Columns.Count - 1
    '            For y As Integer = 0 To m_grvMain.Columns.Count - 1
    '                If dt.Columns(x).ToString.Equals(m_grvMain.Columns(y).FieldName) Then
    '                    ws.Columns(x).Width = m_grvMain.Columns(y).Width * 50
    '                    ws.Columns(x).Style.Font.Name = m_grvMain.Columns(y).AppearanceCell.Font.Name
    '                    ws.Cells(0, x).Value = m_grvMain.Columns(y).Caption
    '                    ws.Columns(x).Style.NumberFormat = m_grvMain.Columns(y).DisplayFormat.FormatString
    '                    ws.Cells(0, x).Style.Font.Color = m_grvMain.Columns(y).AppearanceHeader.ForeColor
    '                    Exit For
    '                End If
    '            Next
    '        Next

    '        'Bind data to excel from datatable
    '        If dt.Rows.Count > 0 Then
    '            For x As Integer = 0 To dt.Rows.Count - 1

    '                For k As Integer = 0 To dt.Columns.Count - 1

    '                    ws.Cells(x + 1, k).Value = dt.Rows(x)(k)

    '                Next

    '            Next

    '            'tmpStyle.Borders.SetBorders(MultipleBorders.Right Or MultipleBorders.Top Or MultipleBorders.Bottom, m_grvMain.Appearance.Row.BorderColor, LineStyle.Thin)
    '            'tmpStyle.FillPattern.SetSolid(m_grvMain.Appearance.Row.BackColor)
    '            'ws.Cells.GetSubrangeAbsolute(1, 0, dt.Rows.Count, dt.Columns.Count - 1).Style = tmpStyle
    '            'tmpStyle = New CellStyle

    '        End If

    '    End Sub

#End Region

#Region "Event Handles"

    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click
        'Try
        '    Dim dialog As New FolderBrowserDialog
        '    dialog.SelectedPath = Me.txtPath.Text
        '    If (dialog.ShowDialog = DialogResult.OK) Then
        '        Me.txtPath.Text = dialog.SelectedPath
        '        Me.txtPath.Tag = dialog.SelectedPath
        '    End If
        'Catch exception As Exception
        'End Try
        Throw New ApplicationException("Exception Occured")
    End Sub

    Private Sub frmGridExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtPath.Text = "C:\"
            txtFileName.Text = gridData.Name
            cboType.SelectedText = "XLS"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        'Try
        '    If gridData.DataSource IsNot Nothing Then
        '        If txtPath.Text.Trim = String.Empty Then
        '            Message_Information("Invalid directory.")
        '            Return
        '        End If

        '        If Not My.Computer.FileSystem.DirectoryExists(txtPath.Text) Then
        '            Message_Information("File path is incorrect")
        '            Return
        '        End If

        '        If txtFileName.Text.Trim = String.Empty Then
        '            Message_Information("File name can not be blank.")
        '            Return
        '        End If

        '        file = txtPath.Text.Trim("\") & "\" & txtFileName.Text.Trim & "." & cboType.Text.ToLower
        '        If My.Computer.FileSystem.FileExists(file) Then
        '            If (MessageBox.Show(txtFileName.Text.Trim & "." & cboType.Text.ToLower & " already exist. Do you want to replace it?", "Confirmation", _
        '                    MessageBoxButtons.YesNo) = DialogResult.Yes) Then
        '                My.Computer.FileSystem.DeleteFile(file)
        '            Else
        '                Return
        '            End If
        '        End If

        '        If flagProcess = False Then
        '            ExportData()
        '        Else
        '            frmProgress.Instance.Thread = AddressOf ExportData
        '            frmProgress.Instance.Show_Progress()
        '        End If

        '        DialogResult = Windows.Forms.DialogResult.OK
        '    Else
        '        DialogResult = Windows.Forms.DialogResult.Cancel
        '    End If

        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
        Throw New ApplicationException("Exception Occured")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class