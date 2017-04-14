Imports System.Reflection
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class Lookup_Hang_Hoa
    Private _DmHanghoaService As IDmHanghoaService
    Public Property DmHanghoaService As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property
    Private currentView As List(Of DmHanghoa)

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_Hang_Hoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Me.NotAllowSendTab = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_HangHoa_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_HangHoa.AfterFilter
        Try
            If c_HangHoa.Text <> "" Then
                Value_info.ParameterValue = c_HangHoa.ListEditValue(0)
                Value_info.Ten = c_HangHoa.ListEditValue(3)
            Else
                Value_info.ParameterValue = Nothing
                Value_info.Ten = Nothing
            End If

            If c_HangHoa.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_HangHoa_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_HangHoa.FirstBinddata
        Try
            Dim dt As DataTable = DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
            c_HangHoa.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub c_HangHoa_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_HangHoa.ClearFilterData
        Try
            Value_info.ParameterValue = Nothing
            Value_info.Ten = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
