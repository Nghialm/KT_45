Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class LookupKH
    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookupKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub c_HangHoa_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_KHang.AfterFilter
        Try
            If c_KHang.Text <> "" Then
                Value_info.ParameterValue = c_KHang.ListEditValue(0)
                Value_info.Ten = "Mã khách hàng : " & c_KHang.ListEditValue(2) & " - " & c_KHang.ListEditValue(3)
                '   lblTenKhachHang.Text = c_KHang.ListEditValue(3)
            Else
                Value_info.ParameterValue = Nothing
                Value_info.Ten = Nothing
            End If
            If c_KHang.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_HangHoa_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_KHang.FirstBinddata
        Try
            Dim dt As DataTable = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            c_KHang.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_HangHoa_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_KHang.ClearFilterData
        Try
            Value_info.ParameterValue = Nothing
            Value_info.Ten = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
