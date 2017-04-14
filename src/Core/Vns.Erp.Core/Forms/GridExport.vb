Public Class frmGridExport
    Public gridData As DevExpress.XtraGrid.GridControl
    Public file As String = ""

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
            cboType.SelectedIndex = 0
            txtFileName.Text = gridData.Name
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExportData()
        Try
            If Not gridData Is Nothing Then
                file = txtPath.Text.Trim("\") & "\" & txtFileName.Text & "." & cboType.Text
                Select Case cboType.Text
                    'Case "XLSX" : gridData.ExportToXls(file)
                    Case "XLS" : gridData.ExportToXls(file)
                    Case "PDF" : gridData.ExportToPdf(file)
                    Case "RTF" : gridData.ExportToText(file)
                    Case "HTML" : gridData.ExportToHtml(file)
                    Case Else : gridData.ExportToText(file)
                End Select
            End If

            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            frmProgress.Instance.Thread = AddressOf ExportData
            frmProgress.Instance.Show_Progress()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class