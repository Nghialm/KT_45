Imports Vns.Erp.Core.Admin.Domain

Public Class KTY_UserControl
    Inherits UserControl

    Public Parameter_info As HtBienBaocao = New HtBienBaocao()
    Public Value_info As ValueInfo = New ValueInfo()
    Public NotAllowSendTab As Boolean = False

    Public Overridable Sub ReLoad(ByVal objID As Object)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.Name = "KTY_UserControl"
        Me.ResumeLayout(False)

    End Sub

    Private Sub KTY_UserControl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If Not NotAllowSendTab Then
                        SendKeys.Send("{TAB}")
                    End If
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
