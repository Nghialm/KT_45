Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class TxtNgay

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        lblNgay.Text = Parameter_info.TenBien
    End Sub

    Private Sub dtTuNgay_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTuNgay.EditValueChanged
        Try
            Value_info.ParameterValue = Convert.ToDateTime(dtTuNgay.EditValue)
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TxtNgay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtTuNgay.DateTime = DateTime.Now.Date
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetValue()
        Dim tmpDate As Date = dtTuNgay.EditValue
        Value_info.Ten = "Ngày: " & tmpDate.Day.ToString() & "/" & tmpDate.Month.ToString() & "/" & tmpDate.Year.ToString()
    End Sub
End Class
