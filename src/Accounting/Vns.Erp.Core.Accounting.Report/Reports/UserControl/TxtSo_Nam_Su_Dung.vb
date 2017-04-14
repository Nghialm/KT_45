Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class TxtSo_Nam_Su_Dung

    Public Sub New(ByVal ht_bienBaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = ht_bienBaoCao
        If (Parameter_info.TenBien <> "") Then
            LblSoNamSuDung.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNam.EditValueChanged
        Try
            Value_info.ParameterValue = txtNam.Text
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
