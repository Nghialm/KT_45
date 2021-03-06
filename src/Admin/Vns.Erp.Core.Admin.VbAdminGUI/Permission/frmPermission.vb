Imports System.Data
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Columns
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
'*************************************************************************
'	created:	2011/08/18
'	created:	18:8:2011   14:31
'	filename: 	D:\TRINAM\KeToan\v39\KTY.Main\Form\Menu\frmPermission.vb
'	file path:	D:\TRINAM\KeToan\v39\KTY.Main\Form\Menu
'	file base:	frmPermission
'	file ext:	vb
'	author:		Nguyễn Quyết Tiến
'	
'	purpose:	
'*************************************************************************
Public Class frmPermission

#Region "Variables"
    Dim bo_app_forms As IAppFormsService
    Public Property AppFormsService
        Get
            Return bo_app_forms
        End Get
        Set(ByVal value)
            bo_app_forms = value
        End Set
    End Property

    Dim bo_app_group_function As IAppGroupFunctionService
    Public Property AppGroupFunctionService
        Get
            Return bo_app_group_function
        End Get
        Set(ByVal value)
            bo_app_group_function = value
        End Set
    End Property

    Dim bo_app_group_forms As IAppGroupFormsService
    Public Property AppGroupFormsService
        Get
            Return bo_app_group_forms
        End Get
        Set(ByVal value)
            bo_app_group_forms = value
        End Set
    End Property

    Dim bo_user As IAppUsersService
    Public Property AppUsersService
        Get
            Return bo_user
        End Get
        Set(ByVal value)
            bo_user = value
        End Set
    End Property

    Dim bo_user_group As IAppGroupsService
    Public Property AppGroupsService
        Get
            Return bo_user_group
        End Get
        Set(ByVal value)
            bo_user_group = value
        End Set
    End Property

    Dim bo_usergroup_form As IAppUgFormService
    Public Property AppUgFormService
        Get
            Return bo_usergroup_form
        End Get
        Set(ByVal value)
            bo_usergroup_form = value
        End Set
    End Property

    Dim frmPopup As frmPopupOfPermission
    Public list_form As List(Of Guid)
    Public list_level2 As List(Of Guid)
    Public list_level1 As List(Of Guid)
#End Region

#Region "Common Function"
    Public Sub LoadUserGroup()
        Try
            Dim dt As IList(Of AppGroups) = bo_user_group.GetAll()
            If dt.Count > 0 Then
                Dim indexIcon As Integer = 0
                For Each row As AppGroups In dt
                    If indexIcon >= 3 Then
                        indexIcon = indexIcon Mod 3
                    End If
                    Dim user_group_id As Guid = row.Id
                    Dim user_group_name As String = row.Grouptext
                    Dim valueStr As String = user_group_id.ToString + " - " + user_group_name
                    imgListBoxControlGroup.Items.Add(valueStr, indexIcon)
                    indexIcon = indexIcon + 1
                Next
            End If
        Catch
        End Try
    End Sub

    Public Sub BindTreeGroup(ByVal tree As TreeList)
        Try
            tree.Nodes.Clear()
            Dim dt As IList(Of AppGroupFunction) = bo_app_group_function.GetAll()
            tree.DataSource = dt
        Catch
        End Try
    End Sub

    Public Sub BindTreeForm(ByVal gId As Guid, ByVal listForm As TreeList)
        Try
            Dim list As New List(Of AppForms)
            Dim dt As IList(Of AppGroupForms) = bo_app_group_forms.GetAll()
            For Each row As AppGroupForms In dt
                Dim group_id As Guid = row.GroupId
                Dim forms_id As Guid = row.Id
                If group_id = gId Then
                    Dim info As AppForms = bo_app_forms.GetById(forms_id)
                    list.Add(info)
                End If
            Next
            treeFunction.DataSource = list
        Catch
        End Try
    End Sub

    Public Function GetAllForms() As List(Of Guid)
        Try
            Dim list As New List(Of Guid)
            Dim dt As IList(Of AppForms) = bo_app_forms.GetAll()
            For Each rowAll As AppForms In dt
                list.Add(rowAll.Id)
            Next
            Return list
        Catch
            Return Nothing
        End Try
    End Function

    Public Sub SavePermission()
        Try
            Dim list_original As New List(Of Guid)
            Dim userid As Decimal = Decimal.Parse(txtUserGroupId.Text)
            Dim dt As IList(Of AppUgForm) = bo_usergroup_form.GetByKey("GroupId", userid)
            For Each row As AppUgForm In dt
                list_original.Add(row.FormId)
            Next
            If chkAll.Checked = True Then
                list_form = New List(Of Guid)
                Dim dtAll As IList(Of AppGroupForms) = bo_app_group_forms.GetAll()
                For Each rowAll As AppGroupForms In dtAll
                    list_form.Add(rowAll.Id)
                Next
            End If
            'Tạo list để chứa các phần tử sẽ được ADD hoặc DELETE
            Dim listAdd As New List(Of Guid)
            Dim listDelete As New List(Of Guid)
            'Lấy ra danh sách được ADD
            For Each item2 As Guid In list_form
                If IsExistedItemInList(list_original, item2) = False Then
                    listAdd.Add(item2)
                End If
            Next
            'Lấy ra danh sách bị DELETE
            For Each item1 As Guid In list_original
                If IsExistedItemInList(list_form, item1) = False Then
                    listDelete.Add(item1)
                End If
            Next
            'Xóa danh sách nằm trong listDELETE
            For Each itemDelete As Guid In listDelete
                bo_usergroup_form.DeleteByGF(New Guid(txtUserGroupId.Text), itemDelete)
            Next
            'Thêm danh sách nằm trong listADD
            For Each itemAdd As Guid In listAdd
                Dim infoAdd As New AppUgForm
                infoAdd.FormId = itemAdd
                infoAdd.GroupId = Decimal.Parse(txtUserGroupId.Text)
                infoAdd.FormOrder = 0
                bo_usergroup_form.Save(infoAdd)
            Next
            'Refresh Data
            chkAll.Checked = False
            btnSavePermission.Enabled = False
        Catch
        End Try
    End Sub

    Public Sub ReLoadCheckedNode(ByVal tree As TreeList)
        Try
            For Each node As TreeListNode In tree.Nodes
                Dim info As AppForms = CType(tree.GetDataRecordByNode(node), AppForms)
                If IsExistedItemInList(list_form, info.Id) = True Then
                    node.Checked = True
                End If
            Next
        Catch
        End Try
    End Sub

    Public Sub LoadListForm(ByVal group_id As Decimal)
        Try
            list_form = New List(Of Guid)
            Dim dt As IList(Of AppUgForm) = bo_usergroup_form.GetByKey("GroupId", group_id)
            For Each row As AppUgForm In dt
                list_form.Add(row.FormId)
            Next
        Catch
        End Try
    End Sub

    Public Sub GetLevel2()
        Try
            list_level2 = New List(Of Guid)
            For Each info As Guid In list_form
                Dim gf_info As AppGroupForms = bo_app_group_forms.GetByFormId(info)
                If IsExistedItemInList(list_level2, gf_info.GroupId) = False Then
                    list_level2.Add(gf_info.GroupId)
                End If
            Next
        Catch
        End Try
    End Sub

    Public Sub GetLevel1()
        Try
            list_level1 = New List(Of Guid)
            For Each info As Guid In list_level2
                Dim group_function As AppGroupFunction = bo_app_group_function.GetById(info)
                If IsExistedItemInList(list_level1, group_function.ParentId) = False Then
                    list_level1.Add(group_function.ParentId)
                End If
            Next
        Catch
        End Try
    End Sub

    Public Function IsExistedItemInList(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info.Equals(item) Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Public Sub SetSelectedNodeForGroup(ByVal tree As TreeList)
        Try
            For Each node1 As TreeListNode In tree.Nodes
                Dim info1 As AppGroupFunction = CType(tree.GetDataRecordByNode(node1), AppGroupFunction)
                'If IsExistedItemInList(list_level1, info1("GROUP_ID").ToString) = True Then
                If IsExistedItemInList(list_level1, info1.Id) = True Then
                    'node1.Checked = True
                    node1.CheckState = CheckState.Checked
                    node1.SelectImageIndex = 0
                    For Each node2 As TreeListNode In node1.Nodes
                        Dim info2 As AppGroupFunction = CType(tree.GetDataRecordByNode(node2), AppGroupFunction)
                        'If IsExistedItemInList(list_level2, info2("GROUP_ID").ToString) = True Then
                        If IsExistedItemInList(list_level2, info2.Id) = True Then
                            'node2.Checked = True
                            node2.CheckState = CheckState.Checked
                            node2.SelectImageIndex = 1
                        End If
                    Next
                End If
            Next
        Catch
        End Try
    End Sub

    Public Sub ReLoad()
        BindTreeGroup(treeGroup)
        LoadListForm(Integer.Parse(txtUserGroupId.Text))
        GetLevel2()
        GetLevel1()
        SetSelectedNodeForGroup(treeGroup)
    End Sub
#End Region

#Region "Event Handles"
    Private Sub frmPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadUserGroup()
        Catch
        End Try
    End Sub

    Private Sub imgListBoxControlGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgListBoxControlGroup.SelectedIndexChanged
        Try
            Dim valueStr As String = imgListBoxControlGroup.SelectedValue.ToString
            Dim groupId As String = valueStr.Substring(0, valueStr.LastIndexOf("-")).Trim
            Dim groupName As String = valueStr.Substring(valueStr.LastIndexOf("-") + 1).Trim
            txtUserGroupId.Text = groupId
            txtUserGroupName.Text = groupName
            ReLoad()
        Catch
        End Try
    End Sub

    Private Sub treeGroup_BeforeCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles treeGroup.BeforeCheckNode
        Try
            e.CanCheck = False
        Catch
        End Try
    End Sub

    Private Sub treeGroup_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeGroup.FocusedNodeChanged
        Try
            Dim info As DataRowView = CType(treeGroup.GetDataRecordByNode(e.Node), DataRowView)
            Dim group_id As Guid = New Guid(info("GROUP_ID").ToString)
            BindTreeForm(group_id, treeFunction)
            ReLoadCheckedNode(treeFunction)
        Catch
        End Try
    End Sub

    Private Sub treeFunction_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFunction.AfterCheckNode
        Try
            Dim item As AppForms = CType(treeFunction.GetDataRecordByNode(e.Node), AppForms)
            Dim form_id_of_item As Guid = item.Id
            If e.Node.Checked = True Then
                list_form.Add(form_id_of_item)
            Else
                list_form.Remove(form_id_of_item)
            End If
            btnSavePermission.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            frmPopup = ObjectFactory.GetObject("frmPopupOfPermission")
            frmPopup.txtID.Text = txtUserGroupId.Text
            frmPopup.txtName.Text = txtUserGroupName.Text
            If frmPopup.ShowDialog() = DialogResult.OK Then
                imgListBoxControlGroup.Items(imgListBoxControlGroup.SelectedIndex).Value = txtUserGroupId.Text + " - " + CommonInfo.user_group_name
                txtUserGroupName.Text = CommonInfo.user_group_name
            End If
        Catch
        End Try
    End Sub

    Private Sub btnSavePermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePermission.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu quyền hạn ...")
            btnSavePermission.Enabled = False
        Catch
        End Try
    End Sub

    Private Sub btnFull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFull.Click
        Try
            If MessageBox.Show("Bạn muốn gán toàn quyền cho nhóm : " + Environment.NewLine + " - Mã nhóm : " + txtUserGroupId.Text + Environment.NewLine + " - Tên nhóm  : " + txtUserGroupName.Text, "PHÂN QUYỀN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                chkAll.Checked = True
                btnSavePermission.Enabled = True
            Else
                chkAll.Checked = False
            End If
        Catch
        End Try
    End Sub
#End Region

#Region "Common Info Class"
    Class CommonInfo
        Public Shared user_group_name As String
    End Class
#End Region
End Class