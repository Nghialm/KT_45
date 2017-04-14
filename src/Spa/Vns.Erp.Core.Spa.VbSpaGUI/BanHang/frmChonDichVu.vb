Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Spa.Service.Interface

Public Class frmChonDichVu

#Region "Properties"
    Private _SpaDmDichVuService As ISpaDmDichVuService
    Public Property SpaDmDichVuService() As ISpaDmDichVuService
        Get
            Return _SpaDmDichVuService
        End Get
        Set(ByVal value As ISpaDmDichVuService)
            _SpaDmDichVuService = value
        End Set
    End Property

#End Region

#Region "Variables"

    Private m_lstDichVuReturn As List(Of SpaDmDichVu) = New List(Of SpaDmDichVu)
    Private m_lstDichVu As List(Of SpaDmDichVu) = New List(Of SpaDmDichVu)
    Private m_lstDichVu_Temp As List(Of DichvuTempInfo) = New List(Of DichvuTempInfo)
    Private m_select As Boolean = True
#End Region

#Region "Show_form"

    Public Function Show_Form() As List(Of SpaDmDichVu)
        Try
            load_Data()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        If (Me.ShowDialog = DialogResult.OK) Then
            Return m_lstDichVuReturn
        Else
            Return Nothing
        End If

    End Function

#End Region

#Region "Functions"

    Private Sub load_Data()

        m_lstDichVu = _SpaDmDichVuService.GetAllByDonviID(Generals.DON_VI.Id)

        Dim objdvTemp As DichvuTempInfo
        For Each obj As SpaDmDichVu In m_lstDichVu
            objdvTemp = New DichvuTempInfo
            objdvTemp.ID = obj.Id
            objdvTemp.TenDv = obj.Ten
            objdvTemp.MaDv = obj.Ma
            objdvTemp.kyHieu = obj.Kyhieu
            objdvTemp.Check = 0

            m_lstDichVu_Temp.Add(objdvTemp)
        Next
        grcDichVu.DataSource = m_lstDichVu_Temp

    End Sub

    Private Function GetLstDichVuSelect() As List(Of SpaDmDichVu)
        Dim lst_dvSelect As New List(Of SpaDmDichVu)
        Dim objDichVu As SpaDmDichVu
        Dim lstDv As List(Of DichvuTempInfo) = grvDichVu.DataSource

        For Each obj As DichvuTempInfo In lstDv
            If obj.Check = 1 Then
                objDichVu = New SpaDmDichVu
                objDichVu = GetInfoDvByID(obj.ID)
                If objDichVu IsNot Nothing Then
                    lst_dvSelect.Add(objDichVu)
                End If
            End If
        Next
        Return lst_dvSelect
    End Function

    Private Function GetInfoDvByID(ByVal id As Guid) As SpaDmDichVu
        For Each obj As SpaDmDichVu In m_lstDichVu
            If obj.Id = id Then
                Return obj
            End If
        Next
        Return Nothing
    End Function

#End Region

#Region "Events"

    Private Sub btnHoanThanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoanThanh.Click
        Try
            m_lstDichVuReturn = GetLstDichVuSelect()

            DialogResult = DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuayRa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuayRa.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Class"
    Public Class DichvuTempInfo

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Guid, ByVal madv As String, ByVal kyhieu As String, ByVal tendv As String, ByVal check As Decimal)
            Me.ID = id
            Me.MaDv = madv
            Me.kyHieu = kyhieu
            Me.TenDv = tendv
            Me.Check = check
        End Sub

        Private _ID As Guid
        Public Property ID() As Guid
            Get
                Return _ID
            End Get
            Set(ByVal value As Guid)
                _ID = value
            End Set
        End Property

        Private _MaDv As String
        Public Property MaDv() As String
            Get
                Return _MaDv
            End Get
            Set(ByVal value As String)
                _MaDv = value
            End Set
        End Property

        Private _TenDv As String
        Public Property TenDv() As String
            Get
                Return _TenDv
            End Get
            Set(ByVal value As String)
                _TenDv = value
            End Set
        End Property


        Private _kyHieu As String
        Public Property kyHieu() As String
            Get
                Return _kyHieu
            End Get
            Set(ByVal value As String)
                _kyHieu = value
            End Set
        End Property

        Private _Check As Decimal
        Public Property Check() As Decimal
            Get
                Return _Check
            End Get
            Set(ByVal value As Decimal)
                _Check = value
            End Set
        End Property
    End Class
#End Region

End Class