Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Nodes
Imports System.Data
Imports System.Linq
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmSetupHMenu

#Region "Variables"
    Private frmPop As frmHPopupOfSetup
    Dim _bo_app_form As IAppFormsService
    Private _isExistedItemInList As Boolean

    Public Property AppFormsService As IAppFormsService
        Get
            Return _bo_app_form
        End Get
        Set(ByVal value As IAppFormsService)
            _bo_app_form = value
        End Set
    End Property

    Dim bo_h_gf As IAppHGroupFormService
    Public Property AppHGroupFormService
        Get
            Return bo_h_gf
        End Get
        Set(ByVal value)
            bo_h_gf = value
        End Set
    End Property

    Dim bo_h_group As IAppHGroupFunctService
    Public Property AppHGroupFunctService
        Get
            Return bo_h_group
        End Get
        Set(ByVal value)
            bo_h_group = value
        End Set
    End Property

    Dim bo_app_group_form As IAppGroupFormsService
    Public Property AppGroupFormsService
        Get
            Return bo_app_group_form
        End Get
        Set(ByVal value)
            bo_app_group_form = value
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

    Private list_Form As New List(Of Guid)
    Private list_Original As New List(Of Guid)
    Private P_GROUP_ID As Guid
    Private P_GROUP_TEN As String
    Private ISALLFORM As Boolean
    Private LIST_GROUP As List(Of Guid)
#End Region

#Region "Event Handles"

    Private Property IsExistedItemInList(ByVal list_Form As List(Of Guid), ByVal itemDelete As Guid) As Boolean
        Get
            Return _isExistedItemInList
        End Get
        Set(ByVal value As Boolean)
            _isExistedItemInList = value
        End Set
    End Property

    Private Sub frmSetupHMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindTreeGroup()
            LoadListFormByGroup(P_GROUP_ID)
            LoadGroupAndForm()
            SetSelectedNodeForForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeGroupFunct_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeGroupFunct.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                popControl.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popAddNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popAddNew.ItemClick
        Try
            Dim obj As AppHGroupFunct = GetNodeFocusing()
            'frmPop = New frmHPopupOfSetup(1, obj, obj.Id)
            frmPop = ObjectFactory.GetObject("frmHPopupOfSetup") '(1, obj, obj.Id)
            frmPop.STATUS = 1
            frmPop.INFO_REF = obj
            frmPop.PARENT_ID = obj.Id
            If frmPop.ShowDialog() = DialogResult.OK Then
                BindTreeGroup()
                SetFocusedNodeForTree(frmPop.INFO_RETURN.Id)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popAddNewParent_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popAddNewParent.ItemClick
        Try
            frmPop = New frmHPopupOfSetup(1, Nothing, Guid.Empty)
            If frmPop.ShowDialog() = DialogResult.OK Then
                BindTreeGroup()
                SetFocusedNodeForTree(frmPop.INFO_RETURN.Id)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popEdit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popEdit.ItemClick
        Try
            Dim obj As AppHGroupFunct = GetNodeFocusing()
            frmPop = ObjectFactory.GetObject("frmHPopupOfSetup")
            frmPop.STATUS = 2
            frmPop.INFO_REF = obj
            frmPop.PARENT_ID = obj.Id
            If frmPop.ShowDialog() = DialogResult.OK Then
                BindTreeGroup()
                SetFocusedNodeForTree(frmPop.INFO_RETURN.Id)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popDelete.ItemClick
        Try
            Dim obj As AppHGroupFunct = GetNodeFocusing()
            If MessageBox.Show("Bạn chắc chắn xóa nhóm chức năng này" + Microsoft.VisualBasic.Constants.vbCrLf + "Xóa nhóm chức năng cha sẽ xóa theo toàn bộ các chức năng con", "XÓA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                DeleteAllChildOf(obj.Id)
                BindTreeGroup()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteAllChildOf(ByVal group_parent_id As Guid)
        LIST_GROUP = New List(Of Guid)
        GetAllChildOf(group_parent_id)
        For Each item As Guid In LIST_GROUP
            bo_h_gf.DeleteByGroup(item)
            Dim t1 As AppHGroupFunct = New AppHGroupFunct()
            t1.Id = item
            bo_h_group.Delete(t1)
        Next
        Dim t2 As AppHGroupFunct = New AppHGroupFunct()
        t2.Id = group_parent_id
        bo_h_group.Delete(t2)
    End Sub

    Private Sub GetAllChildOf(ByVal group_parent_id As Guid)
        Dim dt As IList(Of AppHGroupFunct) = bo_h_group.GetByParent(group_parent_id)
        For Each row As AppHGroupFunct In dt
            Dim group_id As Guid = row.Id
            If IsExistedItemInList(LIST_GROUP, group_id) = False Then
                LIST_GROUP.Add(group_id)
            End If
            GetAllChildOf(group_id)
        Next
    End Sub

    Private Sub popClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub listForm_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listForm.AfterCheckNode
        Try
            Dim info As GFInfo

            If e.Node.Level = 0 Then '***************** LEVEL 0 ******************************
                'Checked = True
                If e.Node.Checked = True Then
                    e.Node.ExpandAll()
                    For Each pNode As TreeListNode In e.Node.Nodes
                        pNode.Checked = True
                        For Each node As TreeListNode In pNode.Nodes
                            node.Checked = True
                            info = CType(listForm.GetDataRecordByNode(node), GFInfo)
                            If IsExistedItemInList(list_Form, info.GFID) = False Then
                                list_Form.Add(info.GFID)
                            End If
                        Next
                    Next
                Else 'Checked = False
                    e.Node.Expanded = False
                    For Each pNode As TreeListNode In e.Node.Nodes
                        pNode.Checked = False
                        For Each node As TreeListNode In pNode.Nodes
                            node.Checked = False
                            info = CType(listForm.GetDataRecordByNode(node), GFInfo)
                            If IsExistedItemInList(list_Form, info.GFID) = True Then
                                list_Form.Remove(info.GFID)
                            End If
                        Next
                    Next
                End If
            ElseIf e.Node.Level = 1 Then '*************** LEVEL 1 ******************************
                'Checked = True
                If e.Node.Checked = True Then
                    e.Node.ExpandAll()
                    For Each node As TreeListNode In e.Node.Nodes
                        node.Checked = True
                        info = CType(listForm.GetDataRecordByNode(node), GFInfo)
                        If IsExistedItemInList(list_Form, info.GFID) = False Then
                            list_Form.Add(info.GFID)
                        End If
                    Next
                Else 'Checked = False
                    e.Node.Expanded = False
                    For Each node As TreeListNode In e.Node.Nodes
                        node.Checked = False
                        info = CType(listForm.GetDataRecordByNode(node), GFInfo)
                        If IsExistedItemInList(list_Form, info.GFID) = True Then
                            list_Form.Remove(info.GFID)
                        End If
                    Next
                End If
                UncheckParentByChild(e.Node)
            ElseIf e.Node.Level = 2 Then '******************* LEVEL 2 ********************************
                'Checked = True
                If e.Node.Checked = True Then
                    info = CType(listForm.GetDataRecordByNode(e.Node), GFInfo)
                    If IsExistedItemInList(list_Form, info.GFID) = False Then
                        list_Form.Add(info.GFID)
                    End If
                Else 'Checked = False
                    info = CType(listForm.GetDataRecordByNode(e.Node), GFInfo)
                    If IsExistedItemInList(list_Form, info.GFID) = True Then
                        list_Form.Remove(info.GFID)
                    End If
                End If
                'Set State for Parent Node by list child node state
                UncheckParentByChild(e.Node)
            End If

            btnSaveForm.Enabled = True
            btnSaveForm.Focus()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeGroupFunct_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeGroupFunct.FocusedNodeChanged
        Try
            Dim info As AppHGroupFunct = CType(treeGroupFunct.GetDataRecordByNode(e.Node), AppHGroupFunct)
            P_GROUP_ID = info.Id
            P_GROUP_TEN = info.GroupTen

            LoadListFormByGroup(P_GROUP_ID)
            ResetSelectedForm()
            SetSelectedNodeForForm()

            If e.Node.HasChildren Then
                listForm.Visible = False
                btnSaveForm.Enabled = False
                btnAllForm.Enabled = False
            Else
                listForm.Visible = True
                btnAllForm.Enabled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSaveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveForm.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermissionForm
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập chức năng ...")
            LoadListFormByGroup(P_GROUP_ID)
            SetSelectedNodeForForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAllForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllForm.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Chức năng cho " + Environment.NewLine + "Nhóm: " + P_GROUP_TEN, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ISALLFORM = True
                btnSaveForm.Enabled = True
                btnSaveForm.Focus()
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

#Region "Common Function"
    Private Sub BindTreeGroup()
        Dim listData As IList(Of AppHGroupFunct) = bo_h_group.GetAll()
        treeGroupFunct.DataSource = listData
    End Sub

    Private Sub LoadGroupAndForm()
        Try
            'Group Function Level 1
            Dim listGroupFunction As New List(Of GFInfo)
            Dim dtGrantParent As IList(Of AppGroupFunction) = bo_app_group_function.GetAll()
            Dim dtGroupForm As IList(Of AppGroupForms) = bo_app_group_form.GetAll()

            'Dim dtGrantParent As IList(Of AppGroupFunction) = bo_app_group_function.GetByPId(0)
            'Dim dt_GrantParent = From AGF In dtGrantParent
            '                     Where AGF.ParentId = 0
            For Each rowParent As AppGroupFunction In dtGrantParent
                listGroupFunction.Add(New GFInfo(rowParent.Id, rowParent.GroupTen, rowParent.ParentId))
                If (rowParent.ParentId <> Null.NullGuid) Then
                    'Dim dt_form_in_group = (From AGroupForm In dtGroupForm
                    '                       Where AGroupForm.GroupId = rowParent.Id
                    '                       Select AGroupForm)
                    'For Each tmp As AppGroupForms In dt_form_in_group
                    '    listGroupFunction.Add(New GFInfo(tmp.Id, tmp.AppForms.FormText, tmp.GroupId))
                    'Next
                End If

            Next
            listForm.DataSource = listGroupFunction

            'Group Function Level 2
            'For Each node As TreeListNode In listForm.Nodes
            '    Dim getInfo As GFInfo = CType(listForm.GetDataRecordByNode(node), GFInfo)
            '    Dim dtParent As IList(Of AppGroupFunction) = bo_app_group_function.GetByPId(Integer.Parse(getInfo.GFID))
            '    For Each rParent As AppGroupFunction In dtParent
            '        Dim functionInfo As New GFInfo
            '        functionInfo.GFID = rParent.Id
            '        functionInfo.GFNAME = rParent.GroupTen
            '        Dim parentNode As TreeListNode = listForm.AppendNode(New Object() {functionInfo.GFID, functionInfo.GFNAME}, node.Id, 1, 1, 1)

            '        'Function Level 3
            '        Dim dtGroupForm As IList(Of AppGroupForms) = bo_app_group_form.GetByGroupId(Integer.Parse(functionInfo.GFID))
            '        If dtGroupForm.Count > 0 Then
            '            For Each rowForm As AppGroupForms In dtGroupForm
            '                Dim f_info As AppForms = _bo_app_form.GetById(rowForm.Id)
            '                Dim formInfo As New GFInfo
            '                formInfo.GFID = f_info.Id
            '                formInfo.GFNAME = f_info.FormText
            '                listForm.AppendNode(New Object() {formInfo.GFID, formInfo.GFNAME}, parentNode.Id, 2, 2, 1)
            '            Next
            '        End If
            '    Next
            'Next

            For Each gpNode As TreeListNode In listForm.Nodes
                gpNode.ImageIndex = 0
                gpNode.SelectImageIndex = 0
                For Each pNode As TreeListNode In gpNode.Nodes
                    pNode.ImageIndex = 1
                    pNode.SelectImageIndex = 1
                    For Each cNode As TreeListNode In pNode.Nodes
                        cNode.ImageIndex = 2
                        cNode.SelectImageIndex = 2
                    Next
                Next
            Next
        Catch
        End Try
    End Sub

    Private Sub LoadListFormByGroup(ByVal GROUP_ID As Guid)
        Try
            list_Form = New List(Of Guid)
            list_Original = New List(Of Guid)
            Dim dt As IList(Of AppHGroupForm) = bo_h_gf.GetByGroup(GROUP_ID)
            For Each row As AppHGroupForm In dt
                list_Form.Add(row.FormId)
                list_Original.Add(row.FormId)
            Next
        Catch
        End Try
    End Sub

    Private Sub SetFocusedNodeForTree(ByVal GROUP_ID As Guid)
        Dim nodeFocused As TreeListNode = treeGroupFunct.FindNodeByFieldValue("GROUP_ID", GROUP_ID)
        treeGroupFunct.SetFocusedNode(nodeFocused)
    End Sub

    Private Function GetNodeFocusing() As AppHGroupFunct
        Dim obj As New AppHGroupFunct
        Dim node As TreeListNode
        Try
            node = treeGroupFunct.FindNodeByID(treeGroupFunct.FocusedNode.Id)
            obj = CType(treeGroupFunct.GetDataRecordByNode(node), AppHGroupFunct)
        Catch ex As Exception
        End Try
        Return obj
    End Function

    Private Function IsExistedItemInListGuid(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info = item Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Private Function IsExistedItemInListDecimal(ByVal list As List(Of Decimal), ByVal item As Decimal) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Decimal In list
                If info = item Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Private Sub ResetSelectedForm()
        Try
            For Each gpNode As TreeListNode In listForm.Nodes
                gpNode.Checked = False
                For Each pNode As TreeListNode In gpNode.Nodes
                    pNode.Checked = False
                    For Each node As TreeListNode In pNode.Nodes
                        node.Checked = False
                    Next
                Next
            Next
        Catch
        End Try
    End Sub

    Private Sub SetSelectedNodeForForm()
        Try
            For Each gpNode As TreeListNode In listForm.Nodes
                Dim gpCheck As Boolean = False
                For Each pNode As TreeListNode In gpNode.Nodes
                    Dim pCheck As Boolean = False
                    For Each node As TreeListNode In pNode.Nodes
                        Dim info As GFInfo = CType(listForm.GetDataRecordByNode(node), GFInfo)
                        If IsExistedItemInList(list_Form, info.GFID) = True Then
                            node.Checked = True
                            pNode.Checked = True
                            pCheck = True
                            gpNode.Checked = True
                            gpCheck = True
                        End If
                    Next
                    pNode.Checked = pCheck
                Next
                gpNode.Checked = gpCheck
            Next
        Catch
        End Try
    End Sub

    Private Sub UncheckParentByChild(ByVal node As TreeListNode)
        Try
            Dim haveChildenChecked As Boolean = False
            Dim pNode As TreeListNode = node.ParentNode
            For Each cNode As TreeListNode In pNode.Nodes
                If cNode.Checked = True Then
                    haveChildenChecked = True
                    Exit For
                End If
            Next
            If haveChildenChecked = True Then
                pNode.Checked = True
            Else
                pNode.Checked = False
            End If
        Catch
        End Try
    End Sub

    Private Sub SavePermissionForm()
        Try
            'SELECT ALL
            If ISALLFORM = True Then
                list_Form = New List(Of Guid)
                Dim dtAll As IList(Of AppGroupForms) = bo_app_group_form.GetAll()
                For Each rowAll As AppGroupForms In dtAll
                    list_Form.Add(rowAll.Id)
                Next
            End If

            'DO ADDED
            For Each itemAdd As Guid In list_Form
                Dim forms As AppForms = Me.AppFormsService.Get(itemAdd)
                If IsExistedItemInList(list_Original, itemAdd) = False Then
                    Dim infoAdd As New AppHGroupForm
                    infoAdd.GroupId = P_GROUP_ID
                    'infoAdd.FormId = Decimal.Parse(itemAdd)
                    infoAdd.AppForms = forms
                    infoAdd.FormOrder = 0
                    infoAdd.ImageIndex = "-1"
                    infoAdd.Note1 = ""
                    infoAdd.Note2 = ""
                    infoAdd.Note3 = ""
                    bo_h_gf.Save(infoAdd)
                End If
            Next

            'DO DELETED
            For Each itemDelete As Guid In list_Original
                If IsExistedItemInList(list_Form, itemDelete) = False Then
                    bo_h_gf.DeleteByGroupForm(P_GROUP_ID, itemDelete)
                    'bo_dv_group_form.DeleteByDVF(MADONVI, Integer.Parse(itemDelete))
                    'bo_dv_form.DeleteByDVF(MADONVI, Decimal.Parse(itemDelete))
                End If
            Next

            'DO REFRESH
            ISALLFORM = False
            btnSaveForm.Enabled = False
        Catch
        End Try
    End Sub
#End Region

#Region "Class Info"
    Class GFInfo

#Region "Fields"
        Private _GFID As Guid
        Private _GFNAME As String
        Private _GFParent As Guid
#End Region

#Region "Property"
        Public Property GFID() As Guid
            Get
                Return _GFID
            End Get
            Set(ByVal value As Guid)
                _GFID = value
            End Set
        End Property

        Public Property GFNAME() As String
            Get
                Return _GFNAME
            End Get
            Set(ByVal value As String)
                _GFNAME = value
            End Set
        End Property

        Public Property GFPARENT As Guid
            Get
                Return _GFParent
            End Get
            Set(ByVal value As Guid)
                _GFParent = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub

        Public Sub New(ByVal GFID As Guid, ByVal GFNAME As String, ByVal GFPARENT As Guid)
            Me.GFID = GFID
            Me.GFNAME = GFNAME
            Me.GFPARENT = GFPARENT
        End Sub
#End Region

    End Class
#End Region

End Class