Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class Lookup_Tai_Khoan
    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private currentView As List(Of DmTaikhoan)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal htbienbaocao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = htbienbaocao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_Tai_Khoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Me.NotAllowSendTab = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_TaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_TaiKhoan.AfterFilter
        Try
            If c_TaiKhoan.Text <> "" Then
                Value_info.ParameterValue = c_TaiKhoan.ListEditValue(1)
                Value_info.Ten = c_TaiKhoan.ListEditValue(1) & " - " & c_TaiKhoan.ListEditValue(2)
            Else
                Value_info.ParameterValue = Nothing
                Value_info.Ten = Nothing
            End If
            If c_TaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_TaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_TaiKhoan.ClearFilterData
        Try
            Value_info.ParameterValue = Nothing
            Value_info.Ten = Nothing
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_TaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_TaiKhoan.FirstBinddata
        Try
            Dim dt As DataTable = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            c_TaiKhoan.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
