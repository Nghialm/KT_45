Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service
Imports Vns.Erp.Core.Spa.Common
Imports Vns.Erp.Core.Spa.Service.Interface

Public Class frmLSThe

#Region "Properties"

    Private _SpaLsTheService As ISpaLsTheService
    Public Property SpaLsTheService() As ISpaLsTheService
        Get
            Return _SpaLsTheService
        End Get
        Set(ByVal value As ISpaLsTheService)
            _SpaLsTheService = value
        End Set
    End Property

    Public Property TheId As Guid
        Get
            Return m_TheId
        End Get
        Set(ByVal value As Guid)
            m_TheId = value
        End Set
    End Property

#End Region

#Region "Variables"
    Private m_TheId As Guid
#End Region

#Region "Functions"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal TheID As Guid)
        InitializeComponent()
        m_TheId = TheID
    End Sub

    Private Sub LoadData()
        Dim lstLsThe As List(Of SpaLsThe) = _SpaLsTheService.GetHistoryCard(m_TheId)
        grcLSThe.DataSource = lstLsThe
    End Sub

#End Region

#Region "Events"

    Private Sub frmLSThe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region

End Class