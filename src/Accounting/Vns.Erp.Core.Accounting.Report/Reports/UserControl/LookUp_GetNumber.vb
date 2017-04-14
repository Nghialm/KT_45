Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class LookUp_GetNumber

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub txtOLDSTORE_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOLDSTORE.EditValueChanged
        Try
            Value_info.ParameterValue = txtOLDSTORE.Text
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
