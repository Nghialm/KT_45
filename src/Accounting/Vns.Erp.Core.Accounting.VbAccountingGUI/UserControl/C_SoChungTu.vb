Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class C_SoChungTu

#Region "Properties"

    Private _PREPIX As String
    Private _SO_CHUNG_TU As String

#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
#End Region

    Public Property SO_CHUNG_TU() As String
        Get
            Return _SO_CHUNG_TU
        End Get
        Set(ByVal value As String)
            _SO_CHUNG_TU = value
        End Set
    End Property

    Public Property PREFIX() As String
        Get
            Return _PREPIX
        End Get
        Set(ByVal value As String)
            _PREPIX = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return txtSO_CT.Text
        End Get
        Set(ByVal value As String)
            txtSO_CT.Text = value
        End Set
    End Property
#End Region

#Region "Events"

    Public Sub r_SoCTPREFIX(ByVal p_LOAICHUNGTU_ID As Guid, ByVal p_THANG As Decimal, ByVal p_NAM As Decimal, ByVal p_DONVI_ID As Guid)
        If (_HtLoaichungtuService Is Nothing) Then
            _HtLoaichungtuService = CType(ObjectFactory.GetObject("HtLoaichungtuService"), IHtLoaichungtuService)
        End If
        Dim lst As List(Of String) = _HtLoaichungtuService.GetSoCT_prefix(p_LOAICHUNGTU_ID, p_THANG, p_NAM, p_DONVI_ID)
        If lst IsNot Nothing Then
            _PREPIX = lst(0)
            _SO_CHUNG_TU = lst(1)
        End If
    End Sub

    Private Sub C_SoChungTu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.DesignMode Then
                Return
            End If
            'txtSO_CT.Text = _SO_CHUNG_TU
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class
