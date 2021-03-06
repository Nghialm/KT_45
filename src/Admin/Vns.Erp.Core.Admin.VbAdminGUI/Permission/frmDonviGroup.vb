Imports System.Data
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Nodes
Imports System.Windows.Forms
Imports System
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
'Grant permission for DONVI
Public Class frmDonviGroup

#Region "Variables"
    Dim _DmDonviService As IDmDonviService
    Public Property DmDonviService() As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property
    Dim _AppFormsService As IAppFormsService
    Public Property AppFormsService() As IAppFormsService
        Get
            Return _AppFormsService
        End Get
        Set(value As IAppFormsService)
            _AppFormsService = value
        End Set
    End Property
    Dim _AppDvFormService As IAppDvFormService
    Public Property AppDvFormService() As IAppDvFormService
        Get
            Return _AppDvFormService
        End Get
        Set(value As IAppDvFormService)
            _AppDvFormService = value
        End Set
    End Property
    Dim _AppGroupFormsService As IAppGroupFormsService
    Public Property AppGroupFormsService() As IAppGroupFormsService
        Get
            Return _AppGroupFormsService
        End Get
        Set(value As IAppGroupFormsService)
            _AppGroupFormsService = value
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
    Dim _AppDvGroupFormService As IAppDvGroupFormService
    Public Property AppDvGroupFormService() As IAppDvGroupFormService
        Get
            Return _AppDvGroupFormService
        End Get
        Set(value As IAppDvGroupFormService)
            _AppDvGroupFormService = value
        End Set
    End Property
    Dim _AppGroupFunctionService As IAppGroupFunctionService
    Public Property AppGroupFunctionService() As IAppGroupFunctionService
        Get
            Return _AppGroupFunctionService
        End Get
        Set(value As IAppGroupFunctionService)
            _AppGroupFunctionService = value
        End Set
    End Property
    Private list_Form As List(Of String)
    Private list_Original As List(Of String)
    Private DonviId As Guid 'DONVI ID
    Private TENDONVI As String 'DONVI NAME
    Private ISALLFORM As Boolean 'IS CHECK ALL
#End Region

#Region "Common Functions"

    '//////////////////////////////////////////////////
    ' Method:    LoadDV
    ' FullName:  frmDonviGroup.LoadDV
    ' Body:		 Load list DONVI to TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadDV()
        Try
            Dim dt As List(Of DmDonvi) = New List(Of DmDonvi)()
            dt.AddRange(_DmDonviService.GetAll())
            listDonvi.DataSource = dt
            For Each node As TreeListNode In listDonvi.Nodes
                node.ImageIndex = 5
                node.SelectImageIndex = 5
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadListFormByDV
    ' FullName:  frmDonviGroup.LoadListFormByDV
    ' Body:		 Load list form by DONVI, use for update permission
    ' Access:    private 
    ' Returns:   String)
    ' Parameter: ByVal DV_ID As String
    '//////////////////////////////////////////////////
    Private Sub LoadListFormByDV(ByVal DV_ID As Guid)
        Try
            list_Form = New List(Of String)
            list_Original = New List(Of String)
            Dim dt As List(Of AppDvForm) = New List(Of AppDvForm)
            dt.AddRange(_AppDvFormService.GetByDV(DV_ID))
            For Each row As AppDvForm In dt
                list_Form.Add(row.FormId.ToString)
                list_Original.Add(row.FormId.ToString)
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetSelectedNodeForForm
    ' FullName:  frmDonviGroup.SetSelectedNodeForForm
    ' Body:		 Set node checked after commit DONVI permission 
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
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

    '//////////////////////////////////////////////////
    ' Method:    ResetSelectedForm
    ' FullName:  frmDonviGroup.ResetSelectedForm
    ' Body:		 Clear checked for all of node in TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
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

    '//////////////////////////////////////////////////
    ' Method:    SavePermissionForm
    ' FullName:  frmDonviGroup.SavePermissionForm
    ' Body:		 Save permission for DONVI
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SavePermissionForm()
        Try
            'SELECT ALL
            If ISALLFORM = True Then
                list_Form = New List(Of String)
                Dim dtAll As List(Of AppGroupForms) = New List(Of AppGroupForms)()
                dtAll.AddRange(_AppGroupFormsService.GetAll())
                For Each rowAll As AppGroupForms In dtAll
                    list_Form.Add(rowAll.Id.ToString)
                Next
            End If

            'DO ADDED
            For Each itemAdd As String In list_Form
                If IsExistedItemInList(list_Original, itemAdd) = False Then
                    Dim infoAdd As New AppDvForm
                    infoAdd.DvId = DonviId
                    infoAdd.FormId = VnsConvert.CGuid(itemAdd)
                    infoAdd.FormOrder = 0
                    _AppDvFormService.SaveOrUpdate(infoAdd)
                End If
            Next

            'DO DELETED
            For Each itemDelete As String In list_Original
                If IsExistedItemInList(list_Form, itemDelete) = False Then
                    _AppDvGroupFormService.DeleteByDVF(DonviId, New Guid(itemDelete))
                    _AppDvFormService.DeleteByDVF(DonviId, Decimal.Parse(itemDelete))
                End If
            Next

            'DO REFRESH
            ISALLFORM = False
            btnSaveForm.Enabled = False
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    IsExistedItemInList
    ' FullName:  frmDonviGroup.IsExistedItemInList
    ' Body:		 Check item exsited in List(Of String)
    ' Access:    private 
    ' Returns:   String) As Boolean
    ' Parameter: ByVal list As List
    ' Parameter: Of String
    ' Parameter: ByVal item As String
    '//////////////////////////////////////////////////
    Private Function IsExistedItemInList(ByVal list As List(Of String), ByVal item As String) As Boolean
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

    '//////////////////////////////////////////////////
    ' Method:    LoadGroupAndForm
    ' FullName:  frmDonviGroup.LoadGroupAndForm
    ' Body:		 Load Group Function and Forms for creating tree
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadGroupAndForm()
        Try
            'Group Function Level 1
            Dim listGroupFunction As New List(Of GFInfo)
            Dim dtGrantParent As List(Of AppGroupFunction) = New List(Of AppGroupFunction)()
            dtGrantParent.AddRange(_AppGroupFunctionService.GetByPId(New Guid))
            For Each rowParent As AppGroupFunction In dtGrantParent
                listGroupFunction.Add(New GFInfo(rowParent.Id.ToString, rowParent.GroupTen))
            Next
            listForm.DataSource = listGroupFunction

            'Group Function Level 2
            For Each node As TreeListNode In listForm.Nodes
                Dim getInfo As GFInfo = CType(listForm.GetDataRecordByNode(node), GFInfo)
                Dim dtParent As List(Of AppGroupFunction) = New List(Of AppGroupFunction)()
                dtParent.AddRange(_AppGroupFunctionService.GetByPId(New Guid(getInfo.GFID)))
                For Each rParent As AppGroupFunction In dtParent
                    Dim functionInfo As New GFInfo
                    functionInfo.GFID = rParent.Id.ToString
                    functionInfo.GFNAME = rParent.GroupTen
                    Dim parentNode As TreeListNode = listForm.AppendNode(New Object() {functionInfo.GFID, functionInfo.GFNAME}, node.Id, 1, 1, 1)

                    'Function Level 3
                    Dim dtGroupForm As List(Of AppGroupForms) = New List(Of AppGroupForms)()
                    dtGroupForm.AddRange(_AppGroupFormsService.GetByGroupId(New Guid(functionInfo.GFID)))
                    If dtGroupForm.Count > 0 Then
                        For Each rowForm As AppGroupForms In dtGroupForm
                            Dim f_info As AppForms = _AppFormsService.GetById(rowForm.Id)
                            Dim formInfo As New GFInfo
                            formInfo.GFID = f_info.Id.ToString
                            formInfo.GFNAME = f_info.FORMTEXT
                            listForm.AppendNode(New Object() {formInfo.GFID, formInfo.GFNAME}, parentNode.Id, 2, 2, 1)
                        Next
                    End If
                Next
            Next

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

    '//////////////////////////////////////////////////
    ' Method:    UncheckParentByChild
    ' FullName:  frmDonviGroupForm.UncheckParentByChild
    ' Body:		 Check parent have any child node checked
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
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
#End Region

#Region "Event Handles"

    '//////////////////////////////////////////////////
    ' Method:    frmDonviGroup_Load
    ' FullName:  frmDonviGroup.frmDonviGroup_Load
    ' Body:		 Load form and Init control, data
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmDonviGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDV()
            LoadListFormByDV(DonviId)
            LoadGroupAndForm()
            SetSelectedNodeForForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listDonvi_FocusedNodeChanged
    ' FullName:  frmDonviGroup.listDonvi_FocusedNodeChanged
    ' Body:		 Select and load permission for DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listDonvi.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listDonvi_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listDonvi.FocusedNodeChanged
        Try
            Dim rowView As DmDonvi = CType(listDonvi.GetDataRecordByNode(e.Node), DmDonvi)
            DonviId = rowView.Id
            TENDONVI = rowView.TenDonvi

            LoadListFormByDV(DonviId)
            ResetSelectedForm()
            SetSelectedNodeForForm()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  frmDonviGroup.btnClose_Click
    ' Body:		 Close form
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSaveForm_Click
    ' FullName:  frmDonviGroup.btnSaveForm_Click
    ' Body:		 Save permission for DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSaveForm.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSaveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveForm.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermissionForm
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập chức năng ...")
            LoadListFormByDV(DonviId)
            SetSelectedNodeForForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnAllForm_Click
    ' FullName:  frmDonviGroup.btnAllForm_Click
    ' Body:		 Check all permission for DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnAllForm.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnAllForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllForm.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Chức năng cho " + Environment.NewLine + "Đơn vị: " + TENDONVI, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ISALLFORM = True
                btnSaveForm.Enabled = True
                btnSaveForm.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listForm_AfterCheckNode
    ' FullName:  frmDonviGroup.listForm_AfterCheckNode
    ' Body:		 Add or remove any function of DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listForm.AfterCheckNode
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.NodeEventArgs
    '//////////////////////////////////////////////////
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

#End Region

#Region "Class Info"
    Class GFInfo

#Region "Fields"
        Private _GFID As String
        Private _GFNAME As String
#End Region

#Region "Property"
        Public Property GFID() As String
            Get
                Return _GFID
            End Get
            Set(ByVal value As String)
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
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub

        Public Sub New(ByVal GFID As String, ByVal GFNAME As String)
            Me.GFID = GFID
            Me.GFNAME = GFNAME
        End Sub
#End Region

    End Class
#End Region

    Private Sub frmDonviGroup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class