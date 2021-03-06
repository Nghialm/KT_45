Imports System.Data
Imports System.Windows.Forms
Imports System
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports System.Collections.Generic
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmDonviGroupUser
#Region "Variables"
    Dim _AppUsersService As IAppUsersService
    Public Property AppUsersService() As IAppUsersService
        Get
            Return _AppUsersService
        End Get
        Set(value As IAppUsersService)
            _AppUsersService = value
        End Set
    End Property
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
    Dim _AppDvGroupService As IAppDvGroupService
    Public Property AppDvGroupService() As IAppDvGroupService
        Get
            Return _AppDvGroupService
        End Get
        Set(value As IAppDvGroupService)
            _AppDvGroupService = value
        End Set
    End Property
    Dim _AppDvGroupUserService As IAppDvGroupUserService
    Public Property AppDvGroupUserService() As IAppDvGroupUserService
        Get
            Return _AppDvGroupUserService
        End Get
        Set(value As IAppDvGroupUserService)
            _AppDvGroupUserService = value
        End Set
    End Property
    Private _ISALL As Boolean
    Private _GROUPNAME As String
    Private _DONVINAME As String
    Private _USERNAMEP As String
    Private _USERIDP As String
    Private _FULLNAMEP As String
    Public LIST_DVGU As List(Of String)

    Public Property USERIDP() As String
        Get
            Return _USERIDP
        End Get
        Set(ByVal value As String)
            _USERIDP = value
        End Set
    End Property

    Public Property USERNAMEP() As String
        Get
            Return _USERNAMEP
        End Get
        Set(ByVal value As String)
            _USERNAMEP = value
        End Set
    End Property

    Public Property FULLNAMEP() As String
        Get
            Return _FULLNAMEP
        End Get
        Set(ByVal value As String)
            _FULLNAMEP = value
        End Set
    End Property

    Public Property ISALL() As Boolean
        Get
            Return _ISALL
        End Get
        Set(ByVal value As Boolean)
            _ISALL = value
        End Set
    End Property

    Public Property GROUPNAME() As String
        Get
            Return _GROUPNAME
        End Get
        Set(ByVal value As String)
            _GROUPNAME = value
        End Set
    End Property

    Public Property DONVINAME() As String
        Get
            Return _DONVINAME
        End Get
        Set(ByVal value As String)
            _DONVINAME = value
        End Set
    End Property
#End Region

#Region "Common Functions"
    Public Sub LoadUsers()
        Try
            Dim dt As IList(Of AppUsers) = _AppUsersService.GetAll()
            listUser.DataSource = dt
            For Each node As TreeListNode In listUser.Nodes
                node.ImageIndex = 7
                node.SelectImageIndex = 7
            Next
        Catch
        End Try
    End Sub

    Public Sub LoadDonVi()
        Try
            Dim dt As IList(Of AppUsers) = _AppUsersService.GetAll()
            listGroup.DataSource = dt
            For Each node As TreeListNode In listGroup.Nodes
                node.HasChildren = True
            Next
        Catch
        End Try
    End Sub

    Public Sub LoadDonViAndGroup()
        Try
            Dim listDVG As New List(Of DVGInfo)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            For Each row As DmDonvi In dt
                listDVG.Add(New DVGInfo(row.Id.ToString, row.TenDonvi.ToString))
            Next
            listGroup.DataSource = listDVG

            For Each node As TreeListNode In listGroup.Nodes
                Dim dvgGetInfo As DVGInfo = CType(listGroup.GetDataRecordByNode(node), DVGInfo)
                Dim dtDVG As IList(Of AppDvGroup) = _AppDvGroupService.GetByDV(New Guid(dvgGetInfo.DVGID))
                For Each r As AppDvGroup In dtDVG
                    Dim group_id As String = r.GroupId.ToString
                    Dim gInfo As AppGroups = _AppGroupsService.GetById(New Guid(group_id))
                    Dim dvg_info As New DVGInfo
                    dvg_info.DVGID = group_id
                    dvg_info.DVGNAME = gInfo.Grouptext
                    listGroup.AppendNode(New Object() {dvg_info.DVGID, dvg_info.DVGNAME}, node.Id, 1, 1, 1)
                Next
            Next

            For Each pNode As TreeListNode In listGroup.Nodes
                pNode.ImageIndex = 5
                pNode.SelectImageIndex = 5
                For Each cNode As TreeListNode In pNode.Nodes
                    cNode.ImageIndex = 6
                    cNode.SelectImageIndex = 6
                Next
            Next
        Catch
        End Try
    End Sub

    Public Sub LoadListDVGUByUser(ByVal user_id As String)
        Try
            LIST_DVGU = New List(Of String)
            Dim dt As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetByUser(New Guid(user_id))
            For Each row As AppDvGroupUser In dt
                LIST_DVGU.Add(row.DvId.ToString + ";" + row.GroupId.ToString + ";" + row.UserId.ToString)
            Next
        Catch
        End Try
    End Sub

    Public Sub LoadGroupByDonVi(ByVal node As TreeListNode, ByVal tree As TreeList)
        Try
            node.Nodes.Clear()
            Dim dvgGetInfo As DVGInfo = CType(listGroup.GetDataRecordByNode(node), DVGInfo)
            Dim dt As IList(Of AppDvGroupUser) = _AppDvGroupService.GetByDV(New Guid(dvgGetInfo.DVGID))

            For Each r As AppDvGroupUser In dt
                Dim group_id As String = r.GroupId.ToString
                Dim gInfo As AppGroups = _AppGroupsService.GetById(New Guid(group_id))
                Dim dvg_info As New DVGInfo
                dvg_info.DVGID = group_id
                dvg_info.DVGNAME = gInfo.GROUPTEXT
                tree.AppendNode(New Object() {dvg_info.DVGID, dvg_info.DVGNAME}, node.Id, 1, 1, 1)
            Next
        Catch
        End Try
    End Sub

    Public Sub SavePermission()
        Try
            Dim list_original As New List(Of String)
            Dim dt As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetByUser(New Guid(USERIDP))
            For Each row As AppDvGroupUser In dt
                Dim item_original As String = row.DvId.ToString + ";" + row.GroupId.ToString + ";" + row.UserId.ToString
                list_original.Add(item_original)
            Next
            If ISALL = True Then
                LIST_DVGU = New List(Of String)
                Dim dtDV As IList(Of AppDvGroupUser) = _DmDonviService.GetAll()
                For Each rowDV As AppDvGroupUser In dtDV
                    Dim donvi_id As String = rowDV.DvId.ToString
                    Dim dtDVG As IList(Of AppDvGroupUser) = _AppDvGroupService.GetByDV(New Guid(donvi_id))
                    For Each rowDVG As AppDvGroupUser In dtDVG
                        Dim group_id As String = rowDVG.GroupId.ToString
                        Dim itemAll As String = donvi_id + ";" + group_id + ";" + USERIDP
                        LIST_DVGU.Add(itemAll)
                    Next
                Next
            End If
            'Tạo list để chứa các phần tử sẽ được ADD hoặc DELETE
            Dim listAdd As New List(Of String)
            Dim listDelete As New List(Of String)
            'Lấy ra danh sách được ADD
            For Each item2 As String In LIST_DVGU
                If IsExistedItemInList(list_original, item2) = False Then
                    listAdd.Add(item2)
                End If
            Next
            'Lấy ra danh sách bị DELETE
            For Each item1 As String In list_original
                If IsExistedItemInList(LIST_DVGU, item1) = False Then
                    listDelete.Add(item1)
                End If
            Next
            'Xóa danh sách nằm trong listDELETE
            For Each itemDelete As String In listDelete
                Dim arrParamDel As String() = itemDelete.Split(Char.Parse(";"))
                _AppDvGroupUserService.DeleteByDVGU(New Guid(arrParamDel(0)), New Guid(arrParamDel(1)), New Guid(arrParamDel(2)))
            Next
            'Thêm danh sách nằm trong listADD
            For Each itemAdd As String In listAdd
                Dim arrParamAdd As String() = itemAdd.Split(Char.Parse(";"))
                Dim infoAdd As New AppDvGroupUser
                infoAdd.DvId = New Guid(arrParamAdd(0))
                infoAdd.GroupId = New Guid(arrParamAdd(1))
                infoAdd.UserId = New Guid(arrParamAdd(2))
                infoAdd.UserOrder = 0
                _AppDvGroupUserService.SaveOrUpdate(infoAdd)
            Next
            'Refresh Data
            ISALL = False
            btnSave.Enabled = False
            SetSelectedGroupForUser(USERIDP)
        Catch
        End Try
    End Sub

    Public Sub SetSelectedGroupForUser(ByVal user_id As String)
        Try
            For Each nodeParent As TreeListNode In listGroup.Nodes
                Dim parentHasCheckedNode As Boolean = False
                Dim infoParent As DVGInfo = CType(listGroup.GetDataRecordByNode(nodeParent), DVGInfo)
                Dim donvi_id As String = infoParent.DVGID
                For Each nodeChild As TreeListNode In nodeParent.Nodes
                    Dim infoChild As DVGInfo = CType(listGroup.GetDataRecordByNode(nodeChild), DVGInfo)
                    Dim group_id As String = infoChild.DVGID
                    Dim itemCheck As String = donvi_id + ";" + group_id + ";" + user_id
                    If IsExistedItemInList(LIST_DVGU, itemCheck) = True Then
                        nodeChild.Checked = True
                        nodeParent.Checked = True
                        parentHasCheckedNode = True
                    End If
                Next
                nodeParent.Checked = parentHasCheckedNode
            Next
        Catch
        End Try
    End Sub

    Public Sub ResetSelectedGroup()
        Try
            For Each pNode As TreeListNode In listGroup.Nodes
                pNode.Checked = False
                For Each node As TreeListNode In pNode.Nodes
                    node.Checked = False
                Next
            Next
        Catch
        End Try
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
#End Region

#Region "Event Handles"
    Private Sub frmDonviGroupUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadUsers()
            LoadListDVGUByUser(USERIDP)
            LoadDonViAndGroup()
            SetSelectedGroupForUser(USERIDP)
        Catch
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập ...")
        Catch
        End Try
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Nhóm cho " + Environment.NewLine + "Người dùng: " + FULLNAMEP, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ISALL = True
                btnSave.Enabled = True
                btnSave.Focus()
            End If
        Catch
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub listGroup_BeforeCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles listGroup.BeforeCheckNode
        Try
            If e.Node.Level = 0 Then
                e.CanCheck = False
            End If
        Catch
        End Try
    End Sub

    Private Sub listGroup_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listGroup.AfterCheckNode
        Try
            Dim info As DVGInfo = CType(listGroup.GetDataRecordByNode(e.Node), DVGInfo)
            Dim pInfo As DVGInfo = CType(listGroup.GetDataRecordByNode(e.Node.ParentNode), DVGInfo)
            Dim item As String = pInfo.DVGID + ";" + info.DVGID + ";" + USERIDP
            If e.Node.Checked = True Then
                LIST_DVGU.Add(item)
            Else
                LIST_DVGU.Remove(item)
            End If
            btnSave.Enabled = True
            btnSave.Focus()
        Catch
        End Try
    End Sub

    Private Sub listUser_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listUser.FocusedNodeChanged
        Try
            Dim row As DataRowView = CType(listUser.GetDataRecordByNode(e.Node), DataRowView)
            USERIDP = row("USERID").ToString
            FULLNAMEP = row("FULLNAME").ToString
            LoadListDVGUByUser(USERIDP)
            ResetSelectedGroup()
            SetSelectedGroupForUser(USERIDP)
        Catch
        End Try
    End Sub
#End Region

#Region "Class Info"
    Class DVGInfo
        Private _DVGID As String
        Public Property DVGID() As String
            Get
                Return _DVGID
            End Get
            Set(ByVal value As String)
                _DVGID = value
            End Set
        End Property
        Private _DVGNAME As String
        Public Property DVGNAME() As String
            Get
                Return _DVGNAME
            End Get
            Set(ByVal value As String)
                _DVGNAME = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal DVGID As String, ByVal DVGNAME As String)
            Me.DVGID = DVGID
            Me.DVGNAME = DVGNAME
        End Sub
    End Class
#End Region

End Class