Imports GemBox.Spreadsheet
Public Class GemboxExportExcel

#Region "Variable"

    Public gridData As DevExpress.XtraGrid.GridControl

    'File template location
    Public fileTemplate As String = String.Empty

    'Directory File
    Public file As String = "A1"

    'Insert the data from DataTable to the worksheet starting at cell default "A1".
    Public startCell As String

#End Region

#Region "Function"
    Private Sub ExportData()
        'Try
        '    SetLicenseSpreadsheet()
        '    If Not gridData Is Nothing Then

        '        Dim currentLocation As String = Application.ExecutablePath
        '        currentLocation = currentLocation.Replace(currentLocation.Substring(currentLocation.LastIndexOf("\"c)), "") & "\Template\ExportTemplate"

        '        Dim ex As New ExcelFile
        '        '

        '        ex.LoadXls(currentLocation & "\" & fileTemplate & ".xls")


        '        Dim dt As DataTable = gridData.DataSource
        '        If dt.Columns.Contains("ROWNUM") Then
        '            dt.Columns.Remove(dt.Columns("ROWNUM"))
        '        End If
        '        If dt.Columns.Contains("ID") Then
        '            dt.Columns.Remove(dt.Columns("ID"))
        '        End If
        '        Dim ws As ExcelWorksheet = ex.Worksheets(0)
        '        ws.InsertDataTable(dt, startCell, True)
        '        '
        '        ex.SaveXls(file)
        '    End If

        '    DialogResult = Windows.Forms.DialogResult.OK
        'Catch ex As Exception
        'End Try
    End Sub
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        'Try
        '    If txtPath.Text.Trim = String.Empty Then
        '        Message_Information("Invalid directory.")
        '        Return
        '    End If

        '    If Not My.Computer.FileSystem.DirectoryExists(txtPath.Text) Then
        '        Message_Information("File path is incorrect")
        '        Return
        '    End If

        '    If txtFileName.Text.Trim = String.Empty Then
        '        Message_Information("File name can not be blank.")
        '        Return
        '    End If

        '    file = txtPath.Text.Trim("\") & "\" & txtFileName.Text.Trim & ".xls"
        '    If My.Computer.FileSystem.FileExists(file) Then
        '        If (MessageBox.Show(txtFileName.Text.Trim & ".xls already exist. Do you want to replace it?", "Confirmation", _
        '                MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
        '    End If
        '    frmProgress.Instance.Thread = AddressOf ExportData
        '    frmProgress.Instance.Show_Progress()
        '    DialogResult = Windows.Forms.DialogResult.OK
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