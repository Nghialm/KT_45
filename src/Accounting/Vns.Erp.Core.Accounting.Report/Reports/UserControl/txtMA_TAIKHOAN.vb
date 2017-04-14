Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class txtMA_TAIKHOAN
    Public Sub New(ByVal ht_bienBaoCao As HtBienBaocao)
        InitializeComponent()

        Parameter_info = ht_bienBaoCao
        If (Parameter_info.TenBien <> "") Then
            lblma_taikhoan.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub txtma_tk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtma_tk.EditValueChanged
        Try
            Value_info.ParameterValue = txtma_tk.Text
            Value_info.Ten = txtma_tk.Text
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
