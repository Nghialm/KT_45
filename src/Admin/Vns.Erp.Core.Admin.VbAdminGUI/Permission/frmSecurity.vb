Imports System

Public Class frmSecurity

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Try
            txtDecrypted.Text = Crypto.EncryptString128Bit(txtInput.Text, "kty2011")
        Catch ex As Exception
            txtError.Text = ex.Message
        End Try
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Try
            txtInput.Text = Crypto.DecryptString128Bit(txtDecrypted.Text, "kty2011")
        Catch ex As Exception
            txtError.Text = ex.Message
        End Try
    End Sub

End Class