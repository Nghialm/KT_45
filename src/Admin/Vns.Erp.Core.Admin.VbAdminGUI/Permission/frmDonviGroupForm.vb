Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports System
Imports System.Windows.Forms
Imports System.Linq
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

'Grant permission for GROUP - DONVI
Public Class frmDonviGroupForm

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
    Dim _AppDvGroupService As IAppDvGroupService
    Public Property AppDvGroupService() As IAppDvGroupService
        Get
            Return _AppDvGroupService
        End Get
        Set(value As IAppDvGroupService)
            _AppDvGroupService = value
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
    Dim _AppDvGroupFormService As IAppDvGroupFormService
    Public Property AppDvGroupFormService() As IAppDvGroupFormService
        Get
            Return _AppDvGroupFormService
        End Get
        Set(value As IAppDvGroupFormService)
            _AppDvGroupFormService = value
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
    Dim _AppGroupFunctionService As IAppGroupFunctionService
    Public Property AppGroupFunctionService() As IAppGroupFunctionService
        Get
            Return _AppGroupFunctionService
        End Get
        Set(value As IAppGroupFunctionService)
            _AppGroupFunctionService = value
        End Set
    End Property
    'Lay tat danh sach AGF trong db
    Private lstAGF As IList(Of AppGroupFunction)
    Private lstAGForm As IList(Of AppForms)
    Private lstAGroupForm As IList(Of AppGroupForms)

    Private LIST_DVGF As IList(Of String)
    Private LIST_ORIGINAL As IList(Of String)
    Private USER_LOGGED_ID As Guid
    Private USER_LOGGED_NAME As String
    Private USER_LOGGED_FULLNAME As String
    Private _USER_EDIT_FULLNAME As String
    Private LIST_LEVEL1 As IList(Of Guid)
    Private LIST_LEVEL2 As IList(Of Guid)
    Private LIST_LEVEL3 As IList(Of AppGroupForms)

    Private DONVIIDF As Guid 'DONVI ID
    Private GROUPIDF As Guid 'GROUP ID
    Private FORMIDF As Decimal 'FORM ID
    Private ISALL As Boolean 'Check ALL
    Private DONVINAMEP As String 'DONVI NAME
    Private GROUPNAMEP As String 'GROUP NAME

    Public _USER_ID_EDIT As Decimal = 0 'USER ID
    Public GROUP_ID_EDIT As Decimal = 0 'GROUP ID
    Public Property USER_EDIT_FULLNAME() As String
        Get
            Return _USER_EDIT_FULLNAME
        End Get
        Set(ByVal value As String)
            _USER_EDIT_FULLNAME = value
        End Set
    End Property
    Public Property USER_ID_EDIT() As Decimal
        Get
            Return _USER_ID_EDIT
        End Get
        Set(ByVal value As Decimal)
            _USER_ID_EDIT = value
        End Set
    End Property

#End Region

#Region "Common Functions"

    '//////////////////////////////////////////////////
    ' Method:    InitInfo
    ' FullName:  frmDonviGroupForm.InitInfo
    ' Body:		 Get info from Globals
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub InitInfo()
        USER_LOGGED_ID = Globals.LoginUserID
        USER_LOGGED_NAME = Globals.LoginUserName
        USER_LOGGED_FULLNAME = Globals.LoginFullName
        btnSave.Enabled = False
        btnAll.Enabled = False
        lstAGF = _AppGroupFunctionService.GetAll()
        lstAGForm = _AppFormsService.GetAll()
        lstAGroupForm = _AppGroupFormsService.GetAll()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadDonViAndGroup
    ' FullName:  frmDonviGroupForm.LoadDonViAndGroup
    ' Body:		 Load list DONVI and USER GROUP for TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadDonViAndGroup()
        Try
            Dim listDVG As New List(Of DVGInfo)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            For Each row As DmDonvi In dt
                listDVG.Add(New DVGInfo(row.Id, row.TenDonvi))
            Next
            listGroup.DataSource = listDVG

            For Each node As TreeListNode In listGroup.Nodes
                Dim dvgGetInfo As DVGInfo = CType(listGroup.GetDataRecordByNode(node), DVGInfo)
                Dim dtDVG As IList(Of AppDvGroup) = _AppDvGroupService.GetByDV(dvgGetInfo.DVGID)
                For Each r As AppDvGroup In dtDVG
                    Dim group_id As Guid = r.GroupId
                    Dim gInfo As AppGroups = AppGroupsService.GetById(group_id)
                    Dim dvg_info As New GFInfo
                    dvg_info.GFID = group_id
                    dvg_info.GFNAME = gInfo.Grouptext
                    listGroup.AppendNode(New Object() {dvg_info.GFID, dvg_info.GFNAME}, node.Id, 1, 1, 1)
                Next
            Next
        Catch
        End Try
    End Sub

    'Lay gia tri cua chuc nang
    Private Function GetAppGroupFInfo(ByVal i As Guid) As AppGroupFunction

        For Each item As AppGroupFunction In lstAGF
            If (i = item.Id) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    'Lay gia tri cua chuc nang
    Private Function GetAppFormInfo(ByVal i As Guid) As AppForms

        For Each item As AppForms In lstAGForm
            If (i = item.Id) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    '//////////////////////////////////////////////////
    ' Method:    LoadDonViAndGroupByUser
    ' FullName:  frmDonviGroupForm.LoadDonViAndGroupByUser
    ' Body:		 Load list DONVI and USER GROUP by User
    ' Access:    private 
    ' Returns:   Decimal)
    ' Parameter: ByVal user_id As Decimal
    '//////////////////////////////////////////////////
    Private Sub LoadDonViAndGroupByUser(ByVal user_id As Guid)
        Try
            Dim listDVByUSer As New List(Of Guid)
            Dim dtDVByUser As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetByUser(user_id)
            For Each rowDVByUser As AppDvGroupUser In dtDVByUser
                Dim donvi_id As Guid = rowDVByUser.DvId
                Dim group_id As String = rowDVByUser.GroupId.ToString
                If (IsExistedItemInList(listDVByUSer, donvi_id) = False) AndAlso (group_id.Equals("1")) Then
                    listDVByUSer.Add(donvi_id)
                End If
            Next

            Dim listDVG As New List(Of DVGInfo)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            For Each row As DmDonvi In dt
                If IsExistedItemInList(listDVByUSer, row.Id) = True Then
                    listDVG.Add(New DVGInfo(row.Id, row.TenDonvi))
                End If
            Next
            listGroup.DataSource = listDVG

            For Each node As TreeListNode In listGroup.Nodes
                Dim info As DVGInfo = CType(listGroup.GetDataRecordByNode(node), DVGInfo)
                Dim donvi_id As Guid = info.DVGID
                Dim dt1 As IList(Of AppDvGroup) = _AppDvGroupService.GetByDV(donvi_id)
                For Each r As AppDvGroup In dt1
                    Dim group_id As Guid = r.GroupId
                    Dim gInfo As AppGroups = AppGroupsService.GetById(group_id)
                    Dim dvg_info As New GFInfo
                    dvg_info.GFID = group_id
                    dvg_info.GFNAME = gInfo.Grouptext
                    listGroup.AppendNode(New Object() {dvg_info.GFID, dvg_info.GFNAME}, node.Id, 1, 1, 1)
                Next
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadGroupAndForm
    ' FullName:  frmDonviGroupForm.LoadGroupAndForm
    ' Body:		 Load list group function and form
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadGroupAndForm()
        Try
            'Group Function Level 1
            Dim listGroupFunction As New List(Of GFInfo)
            Dim dtGrantParent As IList(Of AppGroupFunction) = _AppGroupFunctionService.GetByPId(Guid.Empty)
            For Each rowParent As AppGroupFunction In dtGrantParent
                listGroupFunction.Add(New GFInfo(rowParent.Id, rowParent.GroupTen))
            Next
            listForm.DataSource = listGroupFunction

            'Group Function Level 2
            For Each node As TreeListNode In listForm.Nodes
                Dim getInfo As GFInfo = CType(listForm.GetDataRecordByNode(node), GFInfo)
                Dim dtParent As IList(Of AppGroupFunction) = _AppGroupFunctionService.GetByPId(getInfo.GFID)
                For Each rParent As AppGroupFunction In dtParent
                    Dim functionInfo As New GFInfo
                    functionInfo.GFID = rParent.Id
                    functionInfo.GFNAME = rParent.GroupTen
                    Dim parentNode As TreeListNode = listForm.AppendNode(New Object() {functionInfo.GFID, functionInfo.GFNAME}, node.Id, 1, 1, 1)

                    'Function Level 3
                    Dim dtGroupForm As IList(Of AppGroupForms) = _AppGroupFormsService.GetByGroupId(functionInfo.GFID)
                    If dtGroupForm.Count > 0 Then
                        For Each rowForm As AppGroupForms In dtGroupForm
                            Dim f_info As AppForms = GetAppFormInfo(rowForm.Id)
                            Dim formInfo As New GFInfo
                            formInfo.GFID = f_info.Id
                            formInfo.GFNAME = f_info.Formtext
                            listForm.AppendNode(New Object() {formInfo.GFID, formInfo.GFNAME}, parentNode.Id, 2, 2, 1)
                        Next
                    End If
                Next
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    BuildFormTreeByDV
    ' FullName:  frmDonviGroupForm.BuildFormTreeByDV
    ' Body:		 Build tree function by DONVI
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub BuildFormTreeByDV()
        Try
            'Get Level 3
            LIST_LEVEL3 = New List(Of AppGroupForms)
            Dim dt3 As IList(Of AppGroupForms) = _AppDvFormService.GetByDonviID(DONVIIDF)

            Dim dt_3 = (From ele In dt3
                    Select ele)
            For Each row3 In dt_3
                LIST_LEVEL3.Add(row3)
            Next

            'Get Level 2
            Dim dt_2 = (From ele2 In dt3
                    Select ele2.GroupId).Distinct()

            LIST_LEVEL2 = New List(Of Guid)
            For Each info2 As Guid In dt_2
                LIST_LEVEL2.Add(info2)
            Next

            'Get Level 1
            LIST_LEVEL1 = New List(Of Guid)
            For Each info2 As Guid In LIST_LEVEL2
                Dim gf_info_1 As AppGroupFunction = GetAppGroupFInfo(info2)
                If (gf_info_1 Is Nothing) Then Continue For
                If IsExistedItemInList(LIST_LEVEL1, gf_info_1.ParentId) = False Then
                    LIST_LEVEL1.Add(gf_info_1.ParentId)
                End If
            Next

            'Get Tree Of DonVi
            Dim LIST_BUILD_TREE As New List(Of BuildTree)
            'Get Level 3 Build Tree
            For Each item3 As AppGroupForms In LIST_LEVEL3
                'Dim bt3_info As AppForms = GetAppFormInfo(Integer.Parse(item3))
                'If (bt3_info IsNot Nothing) Then
                Dim bt3_id As Guid = item3.Id
                Dim bt3_name As String = item3.AppForms.FormText
                'Dim btt3 As AppGroupForms = _AppGroupFormsService.GetByFormId(bt3_id)
                Dim bt3_pid As Guid = item3.GroupId
                LIST_BUILD_TREE.Add(New BuildTree(bt3_id.ToString, bt3_name, bt3_pid.ToString))
                'End If

            Next

            'Get Level 2 Build Tree
            For Each item2 As Guid In LIST_LEVEL2
                Dim bt2_info As AppGroupFunction = GetAppGroupFInfo(item2)
                If (bt2_info IsNot Nothing) Then
                    Dim bt2_id As String = bt2_info.Id.ToString
                    Dim bt2_name As String = bt2_info.GroupTen
                    Dim bt2_pid As String = bt2_info.ParentId.ToString
                    LIST_BUILD_TREE.Add(New BuildTree(bt2_id, bt2_name, bt2_pid))
                End If
            Next

            'Get Level 1 Build Tree
            For Each item1 As Guid In LIST_LEVEL1
                Dim bt1_info As AppGroupFunction = GetAppGroupFInfo(item1)
                If (bt1_info IsNot Nothing) Then
                    Dim bt1_id As String = bt1_info.Id.ToString
                    Dim bt1_name As String = bt1_info.GroupTen
                    Dim bt1_pid As String = bt1_info.ParentId.ToString
                    LIST_BUILD_TREE.Add(New BuildTree(bt1_id, bt1_name, bt1_pid))
                End If
            Next

            'Get Tree Of DonVi
            listForm.DataSource = LIST_BUILD_TREE
            For Each level1 As TreeListNode In listForm.Nodes
                level1.ImageIndex = 0
                level1.SelectImageIndex = 0
                For Each level2 As TreeListNode In level1.Nodes
                    level2.ImageIndex = 1
                    level2.SelectImageIndex = 1
                    For Each level3 As TreeListNode In level2.Nodes
                        level3.ImageIndex = 2
                        level3.SelectImageIndex = 2
                    Next
                Next
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    BuildFormTreeByDV2
    ' FullName:  frmDonviGroupForm.BuildFormTreeByDV2
    ' Body:		 Build tree function by DONVI
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    'Private Sub BuildFormTreeByDV2()
    '    Try
    '        'List Build Tree
    '        Dim LIST_BUILD_TREE As New List(Of BuildTree)

    '        'Get Level 3
    '        LIST_LEVEL3 = New List(Of AppGroupForms)
    '        Dim dt3 As IList(Of AppGroupForms) = _AppDvFormService.GetByDV(DONVIIDF)
    '        For Each row3 As AppGroupForms In dt3
    '            'If IsExistedItemInListDecimal(LIST_LEVEL3, row3.FormId) = False Then
    '            LIST_LEVEL3.Add(row3)
    '            'End If
    '        Next

    '        'Get Level 2
    '        LIST_LEVEL2 = New List(Of Decimal)
    '        For Each info3 As String In LIST_LEVEL3
    '            Dim gf_info_2 As AppGroupForms = _AppGroupFormsService.GetByFormId(Integer.Parse(info3))
    '            If (gf_info_2 IsNot Nothing) And (IsExistedItemInListDecimal(LIST_LEVEL2, gf_info_2.GroupId) = False) Then
    '                LIST_LEVEL2.Add(gf_info_2.GroupId.ToString)
    '            End If
    '        Next

    '        'Get Level 1
    '        LIST_LEVEL1 = New List(Of Decimal)
    '        For Each info2 As String In LIST_LEVEL2
    '            Dim gf_info_1 As AppGroupFunction = GetAppGroupFInfo(Integer.Parse(info2))
    '            If (gf_info_1 IsNot Nothing) And IsExistedItemInListDecimal(LIST_LEVEL1, gf_info_1.ParentId) = False Then
    '                LIST_LEVEL1.Add(gf_info_1.ParentId.ToString)
    '            End If
    '        Next

    '        'Get Level 3 Build Tree
    '        For Each item3 As String In LIST_LEVEL3
    '            Dim bt3_info As AppForms = GetAppFormInfo(Integer.Parse(item3))
    '            If (bt3_info IsNot Nothing) Then
    '                Dim bt3_id As Decimal = bt3_info.Id
    '                Dim bt3_name As String = bt3_info.FORMTEXT
    '                Dim btt3 As AppGroupForms = _AppGroupFormsService.GetByFormId(bt3_id)
    '                Dim bt3_pid As String = btt3.Id.ToString
    '                LIST_BUILD_TREE.Add(New BuildTree(bt3_id, bt3_name, bt3_pid))
    '            End If

    '        Next

    '        'Get Level 2 Build Tree
    '        For Each item2 As String In LIST_LEVEL2
    '            Dim bt2_info As AppGroupFunction = GetAppGroupFInfo(Integer.Parse(item2))
    '            If (bt2_info IsNot Nothing) Then
    '                Dim bt2_id As String = bt2_info.Id.ToString
    '                Dim bt2_name As String = bt2_info.GroupTen
    '                Dim bt2_pid As String = bt2_info.ParentId.ToString
    '                LIST_BUILD_TREE.Add(New BuildTree(bt2_id, bt2_name, bt2_pid))
    '            End If
    '        Next

    '        'Get Level 1 Build Tree
    '        For Each item1 As String In LIST_LEVEL1
    '            Dim bt1_info As AppGroupFunction = GetAppGroupFInfo(Integer.Parse(item1))
    '            If (bt1_info IsNot Nothing) Then
    '                Dim bt1_id As String = bt1_info.Id.ToString
    '                Dim bt1_name As String = bt1_info.GroupTen
    '                Dim bt1_pid As String = bt1_info.ParentId.ToString
    '                LIST_BUILD_TREE.Add(New BuildTree(bt1_id, bt1_name, bt1_pid))
    '            End If
    '        Next

    '        'Get Tree Of DonVi
    '        listForm.DataSource = LIST_BUILD_TREE
    '        For Each level1 As TreeListNode In listForm.Nodes
    '            level1.ImageIndex = 0
    '            level1.SelectImageIndex = 0
    '            For Each level2 As TreeListNode In level1.Nodes
    '                level2.ImageIndex = 1
    '                level2.SelectImageIndex = 1
    '                For Each level3 As TreeListNode In level2.Nodes
    '                    level3.ImageIndex = 2
    '                    level3.SelectImageIndex = 2
    '                Next
    '            Next
    '        Next
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub

    '//////////////////////////////////////////////////
    ' Method:    BuildFormTree
    ' FullName:  frmDonviGroupForm.BuildFormTree
    ' Body:		 Build tree
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub BuildFormTree()
        LoadGroupAndForm()
        BuildFormTreeByDV()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetFocusForFirstGroup
    ' FullName:  frmDonviGroupForm.SetFocusForFirstGroup
    ' Body:		 Select first group if have in tree
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SetFocusForFirstGroup()
        Try
            If listGroup.Nodes.Count > 0 Then
                If listGroup.Nodes(0).Nodes.Count > 0 Then
                    Dim node As TreeListNode = listGroup.Nodes(0).Nodes(0)
                    listGroup.SetFocusedNode(node)
                End If
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadListDVGFByGroup
    ' FullName:  frmDonviGroupForm.LoadListDVGFByGroup
    ' Body:		 Load permission of GROUP
    ' Access:    private 
    ' Returns:   String, ByVal group_id As String)
    ' Parameter: ByVal donvi_id As String
    ' Parameter: ByVal group_id As String
    '//////////////////////////////////////////////////
    Private Sub LoadListDVGFByGroup(ByVal donvi_id As Guid, ByVal group_id As Guid)
        Try
            LIST_DVGF = New List(Of String)
            LIST_ORIGINAL = New List(Of String)
            Dim dt As IList(Of AppDvGroupForm) = _AppDvGroupFormService.GetByDVG(donvi_id, group_id)
            For Each row As AppDvGroupForm In dt
                Dim item As String = donvi_id.ToString() + ";" + group_id.ToString + ";" + row.FormId.ToString
                LIST_DVGF.Add(item)
                LIST_ORIGINAL.Add(item)
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetSelectedFormForGroup
    ' FullName:  frmDonviGroupForm.SetSelectedFormForGroup
    ' Body:		 Display permission of GROUP in TreeList
    ' Access:    private 
    ' Returns:   String, ByVal group_id As String)
    ' Parameter: ByVal donvi_id As String
    ' Parameter: ByVal group_id As String
    '//////////////////////////////////////////////////
    Private Sub SetSelectedFormForGroup(ByVal donvi_id As Guid, ByVal group_id As Guid)
        Try
            For Each gpNode As TreeListNode In listForm.Nodes
                Dim gpCheck As Boolean = False
                For Each pNode As TreeListNode In gpNode.Nodes
                    Dim pCheck As Boolean = False
                    For Each node As TreeListNode In pNode.Nodes
                        Dim info As BuildTree = CType(listForm.GetDataRecordByNode(node), BuildTree)
                        Dim itemCheck As String = donvi_id.ToString() + ";" + group_id.ToString + ";" + info.BTID
                        If IsExistedItemInListString(LIST_DVGF, itemCheck) = True Then
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
    ' FullName:  frmDonviGroupForm.ResetSelectedForm
    ' Body:		 Clear checked for all of TreeListNode
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
    ' Method:    SavePermission
    ' FullName:  frmDonviGroupForm.SavePermission
    ' Body:		 Save permission for GROUP - DONVI
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SavePermission()
        Try
            'SELECT ALL
            If ISALL = True Then
                LIST_DVGF = New List(Of String)
                Dim dtFormDV As IList(Of AppDvForm) = _AppDvFormService.GetByDV(DONVIIDF)
                For Each row As AppDvForm In dtFormDV
                    Dim form_id As String = row.FormId.ToString
                    Dim item As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString + ";" + form_id
                    LIST_DVGF.Add(item)
                Next
            End If

            'DO ADD
            For Each itemAdd As String In LIST_DVGF
                If IsExistedItemInListString(LIST_ORIGINAL, itemAdd) = False Then
                    Dim arrParamAdd As String() = itemAdd.Split(Char.Parse(";"))
                    Dim infoAdd As New AppDvGroupForm
                    infoAdd.DvId = New Guid(arrParamAdd(0))
                    infoAdd.GroupId = New Guid(arrParamAdd(1))
                    infoAdd.FormId = New Guid(arrParamAdd(2))
                    infoAdd.FormOrder = 0
                    _AppDvGroupFormService.Save(infoAdd)
                End If
            Next

            'DO DELETE
            For Each itemDelete As String In LIST_ORIGINAL
                If IsExistedItemInListString(LIST_DVGF, itemDelete) = False Then
                    Dim arrParamDel As String() = itemDelete.Split(Char.Parse(";"))
                    _AppDvGroupFormService.DeleteByDVGF(New Guid(arrParamDel(0)), New Guid(arrParamDel(1)), New Guid(arrParamDel(2)))
                End If
            Next

            'REFRESH
            ISALL = False
            btnAll.Enabled = ISALL
            btnSave.Enabled = False
            SetSelectedFormForGroup(DONVIIDF, GROUPIDF)
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetGroupByDV
    ' FullName:  frmDonviGroupForm.GetGroupByDV
    ' Body:		 Get list GROUP by DONVI
    ' Access:    private 
    ' Returns:   String)
    ' Parameter: ByVal donvi_id As String
    '//////////////////////////////////////////////////
    Private Sub GetGroupByDV(ByVal donvi_id As Guid)
        Try
            Dim listGroupDVG As New List(Of GFInfo)
            Dim dt As IList(Of AppDvGroup) = _AppDvGroupService.GetByDV(donvi_id)
            For Each r As AppDvGroup In dt
                'Dim group_id As Decimal = r.GroupId
                'Dim gInfo As AppGroups = AppGroupsService.GetById(group_id)
                Dim dvg_info As New GFInfo
                dvg_info.GFID = r.GroupId
                dvg_info.GFNAME = r.AppGroup.Grouptext
                listGroupDVG.Add(dvg_info)
            Next
            listGroup.DataSource = listGroupDVG
            For Each node As TreeListNode In listGroup.Nodes
                node.ImageIndex = 6
                node.SelectImageIndex = 6
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadDonViByUser
    ' FullName:  frmDonviGroupForm.LoadDonViByUser
    ' Body:		 Load list DONVI that USER logged manage
    ' Access:    private 
    ' Returns:   Decimal)
    ' Parameter: ByVal user_id As Decimal
    '//////////////////////////////////////////////////
    Private Sub LoadDonViByUser(ByVal user_id As Guid)
        Try
            Dim listDVByUSer As New List(Of Guid)
            Dim dtDVByUser As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetByUser(user_id)
            For Each rowDVByUser As AppDvGroupUser In dtDVByUser
                Dim donvi_id As Guid = rowDVByUser.DvId
                Dim group_id As Guid = rowDVByUser.GroupId
                'If (IsExistedItemInList(listDVByUSer, donvi_id) = False) AndAlso (group_id.Equals("1")) Then
                If (IsExistedItemInList(listDVByUSer, donvi_id) = False) Then
                    listDVByUSer.Add(donvi_id)
                End If
            Next

            Dim listDVG As New List(Of DVGInfo)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            If (Globals.LoginUserName.Contains("admin")) Then
                For Each row As DmDonvi In dt
                    listDVG.Add(New DVGInfo(row.Id, row.TenDonvi))
                Next
            Else
                For Each row As DmDonvi In dt
                    If IsExistedItemInList(listDVByUSer, row.Id) = True Then
                        listDVG.Add(New DVGInfo(row.Id, row.TenDonvi))
                    End If
                Next
            End If

            lookDonVi.Properties.DataSource = listDVG
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    IsExistedItemInList
    ' FullName:  frmDonviGroupForm.IsExistedItemInList
    ' Body:		 Check item existed in List(Of String)
    ' Access:    private 
    ' Returns:   String) As Boolean
    ' Parameter: ByVal list As List
    ' Parameter: Of String
    ' Parameter: ByVal item As String
    '//////////////////////////////////////////////////
    Private Function IsExistedItemInList(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info = item Then
                    bReturn = True
                    Return bReturn
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
                    Return bReturn
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    Private Function IsExistedItemInListString(ByVal list As List(Of String), ByVal item As String) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As String In list
                If info = item Then
                    bReturn = True
                    Return bReturn
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function
    '//////////////////////////////////////////////////
    ' Method:    UncheckParentByChild
    ' FullName:  frmDonviGroupForm.UncheckParentByChild
    ' Body:		 Check parent have any child node checked
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub UncheckParentByChildLevel2(ByVal node As TreeListNode)
        Try
            'ByVal node : node is Level 2 (App_Forms)
            Dim pChecked As Boolean = False
            Dim gpChecked As Boolean = False

            'Get node Level 1
            Dim pNode As TreeListNode = node.ParentNode
            For Each cNode As TreeListNode In pNode.Nodes
                If cNode.Checked = True Then
                    pChecked = True
                    Exit For
                End If
            Next
            pNode.Checked = pChecked

            'Get Node Level 0
            Dim gpNode As TreeListNode = node.ParentNode.ParentNode
            For Each ccNode As TreeListNode In gpNode.Nodes
                If ccNode.Checked = True Then
                    gpChecked = True
                    Exit For
                End If
            Next
            gpNode.Checked = gpChecked
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    UncheckParentByChildLevel1
    ' FullName:  frmDonviGroupForm.UncheckParentByChildLevel1
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub UncheckParentByChildLevel1(ByVal node As TreeListNode)
        Try
            'ByVal node : node is Level 1 (App_Group_Function)
            Dim pChecked As Boolean = False

            'Get node Level 0
            Dim pNode As TreeListNode = node.ParentNode
            For Each cNode As TreeListNode In pNode.Nodes
                If cNode.Checked = True Then
                    pChecked = True
                    Exit For
                End If
            Next
            pNode.Checked = pChecked
        Catch
        End Try
    End Sub

#End Region

#Region "Event Handles"

    '//////////////////////////////////////////////////
    ' Method:    frmDonviGroupForm_Load
    ' FullName:  frmDonviGroupForm.frmDonviGroupForm_Load
    ' Body:		 Form load and inti control, data
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmDonviGroupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitInfo()
            groupDVG.Text = "Danh sách quản lý của Quản trị: " + USER_LOGGED_FULLNAME
            LoadDonViByUser(USER_LOGGED_ID)
            'LoadDonViByUser(USER_ID_EDIT)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listForm_BeforeCheckNode
    ' FullName:  frmDonviGroupForm.listForm_BeforeCheckNode
    ' Body: Check select group
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles listForm.BeforeCheckNode
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs
    '//////////////////////////////////////////////////
    Private Sub listForm_BeforeCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles listForm.BeforeCheckNode
        'If GROUPIDF Is Nothing Then
        '    Message_Warning("Bạn chưa chọn nhóm để phân quyền.")
        '    Return
        'End If
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listForm_AfterCheckNode
    ' FullName:  frmDonviGroupForm.listForm_AfterCheckNode
    ' Body:		 Add/Remove any function of group before save to database
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listForm.AfterCheckNode
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.NodeEventArgs
    '//////////////////////////////////////////////////
    Private Sub listForm_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listForm.AfterCheckNode
        Try
            If GROUPIDF = Guid.Empty Then
                Message_Warning("Bạn chưa chọn nhóm để phân quyền.")
                e.Node.Checked = False
                Exit Sub
            End If

            Dim info As BuildTree

            If e.Node.Level = 0 Then '***************** LEVEL 0 ******************************
                'Checked = True
                If e.Node.Checked = True Then
                    e.Node.ExpandAll()
                    For Each pNode As TreeListNode In e.Node.Nodes
                        pNode.Checked = True
                        For Each node As TreeListNode In pNode.Nodes
                            node.Checked = True
                            info = CType(listForm.GetDataRecordByNode(node), BuildTree)
                            Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                            If IsExistedItemInListString(LIST_DVGF, itemCheck) = False Then
                                LIST_DVGF.Add(itemCheck)
                            End If
                        Next
                    Next
                Else 'Checked = False
                    e.Node.Expanded = False
                    For Each pNode As TreeListNode In e.Node.Nodes
                        pNode.Checked = False
                        For Each node As TreeListNode In pNode.Nodes
                            node.Checked = False
                            info = CType(listForm.GetDataRecordByNode(node), BuildTree)
                            Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                            If IsExistedItemInListString(LIST_DVGF, itemCheck) = True Then
                                LIST_DVGF.Remove(itemCheck)
                            End If
                        Next
                    Next
                End If
            ElseIf e.Node.Level = 1 Then '***************** LEVEL 1 ******************************
                'Checked = True
                If e.Node.Checked = True Then
                    e.Node.ExpandAll()
                    For Each node As TreeListNode In e.Node.Nodes
                        node.Checked = True
                        info = CType(listForm.GetDataRecordByNode(node), BuildTree)
                        Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                        If IsExistedItemInListString(LIST_DVGF, itemCheck) = False Then
                            LIST_DVGF.Add(itemCheck)
                        End If
                    Next
                Else 'Checked = False
                    e.Node.Expanded = False
                    For Each node As TreeListNode In e.Node.Nodes
                        node.Checked = False
                        info = CType(listForm.GetDataRecordByNode(node), BuildTree)
                        Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                        If IsExistedItemInListString(LIST_DVGF, itemCheck) = True Then
                            LIST_DVGF.Remove(itemCheck)
                        End If
                    Next
                End If
                UncheckParentByChildLevel1(e.Node)
            ElseIf e.Node.Level = 2 Then '***************** LEVEL 2 ******************************
                'Checked = True
                If e.Node.Checked = True Then
                    info = CType(listForm.GetDataRecordByNode(e.Node), BuildTree)
                    Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                    If IsExistedItemInListString(LIST_DVGF, itemCheck) = False Then
                        LIST_DVGF.Add(itemCheck)
                    End If
                Else 'Checked = False
                    info = CType(listForm.GetDataRecordByNode(e.Node), BuildTree)
                    Dim itemCheck As String = DONVIIDF.ToString() + ";" + GROUPIDF.ToString() + ";" + info.BTID
                    If IsExistedItemInListString(LIST_DVGF, itemCheck) = True Then
                        LIST_DVGF.Remove(itemCheck)
                    End If
                End If
                'Set State for Parent Node by list child node state
                UncheckParentByChildLevel2(e.Node)
            End If

            btnSave.Enabled = True
            btnSave.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listGroup_FocusedNodeChanged
    ' FullName:  frmDonviGroupForm.listGroup_FocusedNodeChanged
    ' Body:		 Select GROUP for grant permission
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listGroup.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listGroup_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listGroup.FocusedNodeChanged
        Try
            Dim info As GFInfo = CType(listGroup.GetDataRecordByNode(e.Node), GFInfo)
            GROUPIDF = info.GFID
            GROUPNAMEP = info.GFNAME
            LoadListDVGFByGroup(DONVIIDF, GROUPIDF)
            ResetSelectedForm()
            SetSelectedFormForGroup(DONVIIDF, GROUPIDF)

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSave_Click
    ' FullName:  frmDonviGroupForm.btnSave_Click
    ' Body:		 Do save permission for GROUP - DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập ...")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnAll_Click
    ' FullName:  frmDonviGroupForm.btnAll_Click
    ' Body:		 Select all function for GROUP
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Chức năng cho " + Environment.NewLine + "Nhóm: " + GROUPNAMEP + Environment.NewLine + "Đơn vị: " + DONVINAMEP, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ISALL = True
                btnSave.Enabled = True
                btnAll.Enabled = False
                btnSave.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  frmDonviGroupForm.btnClose_Click
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
    ' Method:    lookDonVi_EditValueChanged
    ' FullName:  frmDonviGroupForm.lookDonVi_EditValueChanged
    ' Body:		 Select DONVI in list managed by USER logged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles lookDonVi.EditValueChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub lookDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookDonVi.EditValueChanged
        Try
            DONVIIDF = lookDonVi.EditValue
            DONVINAMEP = lookDonVi.Text

            GetGroupByDV(DONVIIDF)
            groupFunctionForm.Text = "Danh sách chức năng của Đơn vị: " + DONVINAMEP
            If listGroup.Nodes.Count > 0 Then
                btnSave.Enabled = True
                btnAll.Enabled = True
            Else
                btnSave.Enabled = False
                btnAll.Enabled = False
                GROUPIDF = Guid.Empty
            End If

            frmProgress.Instance.Thread = AddressOf BuildFormTreeByDV
            frmProgress.Instance.Show_Progress("Đang tạo danh mục chức năng ...")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Common Class Info"
    Class DVGInfo
#Region "Fields"
        Private _DVGID As Guid
        Private _DVGNAME As String
#End Region

#Region "Property"
        Public Property DVGID() As Guid
            Get
                Return _DVGID
            End Get
            Set(ByVal value As Guid)
                _DVGID = value
            End Set
        End Property

        Public Property DVGNAME() As String
            Get
                Return _DVGNAME
            End Get
            Set(ByVal value As String)
                _DVGNAME = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal DVGID As Guid, ByVal DVGNAME As String)
            Me.DVGID = DVGID
            Me.DVGNAME = DVGNAME
        End Sub
#End Region
    End Class

    Class GFInfo
#Region "Fields"
        Private _GFID As Guid
        Private _GFNAME As String
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
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal GFID As Guid, ByVal GFNAME As String)
            Me.GFID = GFID
            Me.GFNAME = GFNAME
        End Sub
#End Region
    End Class

    Class BuildTree
#Region "Fields"
        Private _BTID As String
        Private _BTNAME As String
        Private _BTPID As String
#End Region

#Region "Property"
        Public Property BTID() As String
            Get
                Return _BTID
            End Get
            Set(ByVal value As String)
                _BTID = value
            End Set
        End Property

        Public Property BTNAME() As String
            Get
                Return _BTNAME
            End Get
            Set(ByVal value As String)
                _BTNAME = value
            End Set
        End Property

        Public Property BTPID() As String
            Get
                Return _BTPID
            End Get
            Set(ByVal value As String)
                _BTPID = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal BTID As String, ByVal BTNAME As String, ByVal BTPID As String)
            Me.BTID = BTID
            Me.BTNAME = BTNAME
            Me.BTPID = BTPID
        End Sub
#End Region
    End Class
#End Region


End Class