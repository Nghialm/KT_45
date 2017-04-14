Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core

Public Class Status_LoaiCT
    Public Property Value_info As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()

#Region "Init Service"
    Private Sub InitService()
        bo_ct_status = CType(ObjectFactory.GetObject("AppCtStatusService"), IAppCtStatusService)
        bo_status_detail = CType(ObjectFactory.GetObject("KtStatusCtService"), IKtStatusCtService)
    End Sub

#End Region

#Region "Variables"
    Dim bo_ct_status As IAppCtStatusService
    Dim bo_status_detail As IKtStatusCtService
    Private info_detail As New KtStatusCt
    Private DONVI_ID As Guid = New Guid()
    Private LIST_UG As New List(Of Guid)

    Private LISTBIND As New List(Of KtStatusCt)

    Private _LCT_STATUS As Guid = New Guid

    Public Property LCT_STATUS() As Guid
        Get
            Return _LCT_STATUS
        End Get
        Set(ByVal value As Guid)
            _LCT_STATUS = value
        End Set
    End Property

    Private _STATUS_UPDATE As String = "-1"

    Public ReadOnly Property STATUS_UPDATE() As String
        Get
            Return _STATUS_UPDATE
        End Get
    End Property

    Public Sub Set_Status(ByVal _ss As String)
        If Not (HasBindData) Then Loaddata()

        _STATUS_UPDATE = _ss
        cboStatus.EditValue = _ss
        If (_LIST_STATUS_ALL Is Nothing) And Not (_ss = "-1") Then
            _LIST_STATUS_ALL = bo_status_detail.GetAll()
        End If
        LayTenTrangThai()
    End Sub

    Private _CheckStatus As Boolean = True

    Public Property CheckStatus() As Boolean
        Get
            Return _CheckStatus
        End Get
        Set(ByVal value As Boolean)
            _CheckStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Danh sach cac trang thai trong he thong
    ''' </summary>
    ''' <remarks></remarks>
    Private _LIST_STATUS_ALL As List(Of KtStatusCt)

#End Region

#Region "Common Functions"
    Public Sub Status_LoaiCT()
        InitService()
    End Sub

    Private Sub InitData()
        DONVI_ID = Generals.DON_VI.Id
        LIST_UG = Vns.Erp.Core.Globals.LIST_USER_GROUP
        'lblName.Text = ""

    End Sub

    ''' <summary>
    ''' Lay danh sach tat ca trang thai chung tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetListFilter() As List(Of KtStatusCt)
        Return _LIST_STATUS_ALL
    End Function

    ''' <summary>
    ''' Gan danh sach trang thai duoc phan quyen bind len combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetListStatusFilter()
        Try
            Dim listFilter As List(Of KtStatusCt) = GetListFilter()
            If Not LIST_UG Is Nothing Then
                If LIST_UG.Count > 0 Then
                    For i As Integer = 0 To LIST_UG.Count - 1
                        Dim group_id As Guid = LIST_UG(i)
                        Dim dt As IList(Of AppCtStatus) = bo_ct_status.GetByDVGCT(DONVI_ID, group_id, LCT_STATUS)
                        If dt.Count > 0 Then
                            Dim ds_status As String = dt(0).DsStatus
                            Dim arr() As String = ds_status.Split(";")
                            For Each lct_status As String In arr
                                If (IsExistedItemInList(LISTBIND, lct_status) = False) Then
                                    Dim obj As KtStatusCt = GetDataItem(lct_status)
                                    If Not (obj Is Nothing) Then
                                        LISTBIND.Add(GetDataItem(lct_status))
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Private Sub BindData()
        Try
            cboStatus.Properties.DataSource = LISTBIND
            cboStatus.Properties.ValueMember = "Id"
            cboStatus.Properties.DisplayMember = "Id"
            If LISTBIND.Count > 0 Then
                cboStatus.EditValue = LISTBIND(0).Id
            End If
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Private Sub CheckUpdate()
        If Not STATUS_UPDATE.Equals("-1") Then
            cboStatus.EditValue = STATUS_UPDATE
        End If
    End Sub

    Public Function IsExistedItemInList(ByVal list As List(Of String), ByVal item As String) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As String In list
                If info.Equals(item) Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Public Function IsExistedItemInList(ByVal list As List(Of KtStatusCt), ByVal item As String) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As KtStatusCt In list
                If info.Id.Equals(item) Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Private Function GetDataItem(ByVal _Trang_thai As String)
        For Each temp As KtStatusCt In _LIST_STATUS_ALL
            If (temp.Id.ToString() = _Trang_thai) Then
                Return temp
            End If
        Next
        Return Nothing
    End Function
#End Region

#Region "Event Handles"
    Private Sub Status_LoaiCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Me.DesignMode) Then Return

        Try
            InitService()
            If Not (HasBindData) Then Loaddata()
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Dim HasBindData As Boolean = False

    Private Sub Loaddata()
        'Try
        If (Me.DesignMode) Then Return
        If bo_ct_status Is Nothing Then
            InitService()
        End If
        If (_LIST_STATUS_ALL Is Nothing) Then
            _LIST_STATUS_ALL = New List(Of KtStatusCt)
            _LIST_STATUS_ALL.AddRange(bo_status_detail.GetAll())
        End If
        InitData()
        GetListStatusFilter()
        BindData()
        CheckUpdate()
        HasBindData = True
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub cboStatus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.EditValueChanged
        Try
            If Not Generals.Ts_PheDuyetChungTu Then
                Value_info.ParameterValue = 1
                _STATUS_UPDATE = ""
                Return
            End If
            Value_info.ParameterValue = cboStatus.EditValue
            _STATUS_UPDATE = Value_info.ParameterValue.ToString()
            'info_detail = bo_status_detail.GetById(Decimal.Parse(cboStatus.EditValue))
            LayTenTrangThai()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Public Sub selectFirst()
        Dim lst As List(Of KtStatusCt) = cboStatus.Properties.DataSource
        If lst.Count <> 0 Then
            TNCommon.SelectFirst(cboStatus)
        End If
    End Sub

    Public Function ChoPhepSuaCT() As Boolean
        Return True 'Tam thoi

        Dim _bTemp As Boolean = False
        For Each i As KtStatusCt In LISTBIND
            If (_STATUS_UPDATE = i.Id.ToString()) Then
                _bTemp = True
                Exit For
            End If
        Next
        Return (_bTemp And _CheckStatus)
    End Function

    Private Function LayTenTrangThai() As String
        If (_LIST_STATUS_ALL Is Nothing) Then
            Return ""
        End If

        For Each obj As KtStatusCt In _LIST_STATUS_ALL
            If (STATUS_UPDATE = obj.Id.ToString()) Then
                lblName.Text = obj.Ten
                Return obj.Ten
            End If
        Next
        lblName.Text = ""
        Return ""
    End Function
End Class
