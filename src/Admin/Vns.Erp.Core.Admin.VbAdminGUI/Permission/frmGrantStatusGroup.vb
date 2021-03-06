Imports System
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmGrantStatusGroup

#Region "Variables"
    Dim _AppGroupsService As IAppGroupsService
    Public Property AppGroupsService() As IAppGroupsService
        Get
            Return _AppGroupsService
        End Get
        Set(value As IAppGroupsService)
            _AppGroupsService = value
        End Set
    End Property
    Dim _DmDonviService As IDmDonviService
    Public Property DmDonviService() As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property
    Dim _AppCtStatusService As IAppCtStatusService
    Public Property AppCtStatusService() As IAppCtStatusService
        Get
            Return _AppCtStatusService
        End Get
        Set(value As IAppCtStatusService)
            _AppCtStatusService = value
        End Set
    End Property
    Dim _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService() As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Private DONVI_ID As String
    Private GROUP_ID As Guid
    Private LOAI_CT_ID As Guid
    Private LIST_LCT_ID As New List(Of String)
    Private ACTION_STATUS As String = "ADDNEW"
#End Region

#Region "Common Functions"
    Private Sub BindDV()
        'Try
        Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
        If dt.Count > 0 Then
            lookUpDV.Properties.ValueMember = "Id"
            lookUpDV.Properties.DisplayMember = "TenDonvi"
            lookUpDV.Properties.DataSource = dt

            lookUpDV.EditValue = Generals.DON_VI.Id
            DONVI_ID = Generals.DON_VI.Id.ToString
            lookUpDV.Enabled = False
            'lookUpDV.ItemIndex = 0
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub LoadGroupByDV()
        'Try
        Dim dtGroup As IList(Of AppGroups) = _AppGroupsService.GetByDV(Generals.DON_VI.Id)
        treeGroup.DataSource = dtGroup

        For Each node As TreeListNode In treeGroup.Nodes
            node.ImageIndex = 6
            node.SelectImageIndex = 6
        Next

        If dtGroup.Count > 0 Then
            GROUP_ID = dtGroup(0).Id
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub LoadLoaiCT()
        'Try
        Dim dt As IList(Of HtLoaichungtu) = _HtLoaichungtuService.GetAll()
        treeLoaiCT.DataSource = dt

        For Each node As TreeListNode In treeLoaiCT.Nodes
            node.ImageIndex = 4
            node.SelectImageIndex = 4
        Next
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub BindListLCT()
        'Try
        Dim dt As IList(Of HtLoaichungtu) = _AppCtStatusService.GetLCTByDVG(New Guid(DONVI_ID), GROUP_ID)

        If dt.Count > 0 Then
            For Each row As HtLoaichungtu In dt
                If IsExistedItemInList(LIST_LCT_ID, row.Id.ToString) = False Then
                    LIST_LCT_ID.Add(row.Id.ToString)
                End If
            Next
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub SetChecked()
        'Try
        For Each node As TreeListNode In treeLoaiCT.Nodes
            Dim row As HtLoaichungtu = CType(treeLoaiCT.GetDataRecordByNode(node), HtLoaichungtu)
            Dim lct_id As String = row.Id.ToString
            If IsExistedItemInList(LIST_LCT_ID, lct_id) = True Then
                node.Checked = True
            Else
                node.Checked = False
            End If
        Next
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub SetControlStatus()
        Dim dt As IList(Of AppCtStatus) = _AppCtStatusService.GetByDVGCT(New Guid(DONVI_ID), GROUP_ID, LOAI_CT_ID)

        If dt.Count > 0 Then
            txtStatus.Text = dt.Item(0).DsStatus
            txtMota.Text = dt.Item(0).MoTa
            ACTION_STATUS = "UPDATE"
            btnUpdate.Text = "Cập nhật"
            btnDelete.Enabled = True
        Else
            txtStatus.Text = ""
            txtMota.Text = ""
            ACTION_STATUS = "ADDNEW"
            btnUpdate.Text = "Thêm mới"
            btnDelete.Enabled = False
        End If
    End Sub

    Public Function IsExistedItemInList(ByVal list As List(Of String), ByVal item As String) As Boolean
        'Try
        Dim bReturn As Boolean = False
        For Each info As String In list
            If info.Equals(item) Then
                bReturn = True
            End If
        Next
        Return bReturn
        'Catch
        '    Return False
        'End Try
    End Function

    Private Sub SavePermission()
        'Try
        Dim info As New AppCtStatus()
        info.DonviId = New Guid(DONVI_ID)
        info.GroupId = GROUP_ID
        info.LoaiCtId = LOAI_CT_ID
        info.DsStatus = txtStatus.Text
        info.MoTa = txtMota.Text
        info.MoTa1 = ""

        If ACTION_STATUS.Equals("ADDNEW") Then
            _AppCtStatusService.SaveOrUpdate(info)
        ElseIf ACTION_STATUS.Equals("UPDATE") Then
            _AppCtStatusService.SaveOrUpdate(info)
        End If

        'Refresh
        BindListLCT()
        SetChecked()
        ACTION_STATUS = "UPDATE"
        btnUpdate.Text = "Cập nhật"
        btnDelete.Enabled = True
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub
#End Region

#Region "Event Handles"
    Private Sub frmGrantStatusGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindDV()
            LoadLoaiCT()
            LoadGroupByDV()
            BindListLCT() 'Load List(Of String)
            SetChecked()

            AddHandler treeGroup.FocusedNodeChanged, AddressOf treeGroup_FocusedNodeChanged
            AddHandler treeLoaiCT.FocusedNodeChanged, AddressOf treeLoaiCT_FocusedNodeChanged
            AddHandler lookUpDV.EditValueChanged, AddressOf lookUpDV_EditValueChanged
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub lookUpDV_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DONVI_ID = lookUpDV.EditValue.ToString
            LoadGroupByDV()
            LIST_LCT_ID = New List(Of String)
            BindListLCT()
            SetChecked()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeGroup_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        Try
            Dim info As AppGroups = CType(treeGroup.GetDataRecordByNode(e.Node), AppGroups)
            GROUP_ID = info.Id
            LIST_LCT_ID = New List(Of String)
            BindListLCT()
            SetChecked()
            SetControlStatus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeLoaiCT_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        Try
            Dim info As HtLoaichungtu = CType(treeLoaiCT.GetDataRecordByNode(e.Node), HtLoaichungtu)
            LOAI_CT_ID = info.Id
            SetControlStatus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeLoaiCT_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeLoaiCT.AfterCheckNode
        Try
            e.Node.Checked = False
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập ...")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Bạn có chắc sắn xóa trạng thái của loại chứng từ này không ?", "XÓA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                _AppCtStatusService.DeleteByDGCT(New Guid(DONVI_ID), GROUP_ID, LOAI_CT_ID)
                ACTION_STATUS = "ADDNEW"
                btnUpdate.Text = "Thêm mới"
                btnDelete.Enabled = False
                LIST_LCT_ID = New List(Of String)
                BindListLCT()
                SetChecked()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub frmGrantStatusGroup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class