Public Class frmChonNam 
    Public NamPB As Integer
    Private Sub frmChonNam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtChonNam.Text = Date.Today.Year
    End Sub

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    NamPB = Integer.Parse(txtChonNam.Text)
    '    Dim frm As New frmButToanPhanBoTuDong()
    '    frm.Show()
    'End Sub
End Class