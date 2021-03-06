Imports System
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmDonviGroupBaocao

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
    Dim _AppDvBcService As IAppDvBcService
    Public Property AppDvBcService() As IAppDvBcService
        Get
            Return _AppDvBcService
        End Get
        Set(value As IAppDvBcService)
            _AppDvBcService = value
        End Set
    End Property
    Dim _HtBaocaoService As IHtBaocaoService
    Public Property HtBaocaoService() As IHtBaocaoService
        Get
            Return _HtBaocaoService
        End Get
        Set(value As IHtBaocaoService)
            _HtBaocaoService = value
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
    Dim _AppDvGroupBcService As IAppDvGroupBcService
    Public Property AppDvGroupBcService() As IAppDvGroupBcService
        Get
            Return _AppDvGroupBcService
        End Get
        Set(value As IAppDvGroupBcService)
            _AppDvGroupBcService = value
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
    Private LIST_REPORT As List(Of String)
    Private LIST_ORIGINAL As List(Of String)

    Private USER_LOGGED_ID As Guid
    Private USER_LOGGED_NAME As String
    Private USER_LOGGED_FULLNAME As String

    Private DONVIIDF As String 'DONVI ID
    Private GROUPIDF As String 'GROUP ID
    Private ALL_REPORT As Boolean 'IS CHECK ALL
    Private DONVINAMEP As String 'DONVI NAME
    Private GROUPNAMEP As String 'GROUP NAME
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
            Dim listDVByUSer As New List(Of String)
            Dim dtDVByUser As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetByUser(user_id)
            For Each rowDVByUser As AppDvGroupUser In dtDVByUser
                Dim donvi_id As String = rowDVByUser.DvId.ToString
                Dim group_id As String = rowDVByUser.GroupId.ToString
                'If (IsExistedItemInList(listDVByUSer, donvi_id) = False) AndAlso (group_id.Equals("1")) Then
                If (IsExistedItemInList(listDVByUSer, donvi_id) = False) Then
                    listDVByUSer.Add(donvi_id)
                End If
            Next

            Dim listDVG As New List(Of DVGInfo)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            If (Globals.IS_ADMIN_TONG) Then
                For Each row As DmDonvi In dt
                    listDVG.Add(New DVGInfo(row.Id.ToString, row.TenDonvi))
                Next
            Else
                For Each row As DmDonvi In dt
                    If IsExistedItemInList(listDVByUSer, row.Id.ToString) = True Then
                        listDVG.Add(New DVGInfo(row.Id.ToString, row.TenDonvi))
                    End If
                Next
            End If

            lookDonVi.Properties.DataSource = listDVG
        Catch ex As Exception
            Message_Error(ex)
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
    Private Sub GetGroupByDV(ByVal donvi_id As String)
        Try
            Dim listGroupDVG As New List(Of DVGInfo)
            Dim dt As IList(Of AppDvGroup) = _AppDvGroupService.GetByDV(New Guid(donvi_id))
            For Each r As AppDvGroup In dt
                Dim group_id As Guid = r.GroupId
                Dim gInfo As AppGroups = _AppGroupsService.GetById(group_id)
                Dim dvg_info As New DVGInfo
                dvg_info.DVGID = group_id.ToString
                dvg_info.DVGNAME = gInfo.Grouptext
                ' if group is admin of DONVI, not add
                If Not group_id.Equals("1") Then
                    listGroupDVG.Add(dvg_info)
                End If
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
    ' Method:    IsExistedInfoInList
    ' FullName:  frmDonviGroupBaocao.IsExistedInfoInList
    ' Body:		 Check info existed in list
    ' Access:    private 
    ' Returns:   Decimal)
    ' Parameter: ByVal list As List
    ' Parameter: Of HtBaocao
    ' Parameter: ByVal checkValue As Decimal
    '//////////////////////////////////////////////////
    Private Function IsExistedInfoInList(ByVal list As List(Of HtBaocao), ByVal checkValue As Guid) As Boolean
        Dim bReturn As Boolean = False
        For Each item As HtBaocao In list
            If item.Id = checkValue Then
                bReturn = True
                Exit For
            End If
        Next
        Return bReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    LoadReportByDV
    ' FullName:  frmDonviGroupBaocao.LoadReportByDV
    ' Body:		 Load list report by DONVI
    ' Access:    private 
    ' Returns:   String)
    ' Parameter: ByVal donvi_id As String
    '//////////////////////////////////////////////////
    Private Sub LoadReportByDV(ByVal donvi_id As String)
        'This way is quite slow for run
        'Maybe optimize later
        'Code is quite 'chicken' but never wrong
        Try
            Dim listAll As IList(Of HtBaocao) = _HtBaocaoService.GetAll()
            Dim dt As IList(Of HtBaocao) = _AppDvBcService.GetBCByDV(New Guid(donvi_id))

            'Get list all report
            'Dim listAll As New List(Of HtBaocao)
            'listAll = CType(DataHelper.DataTableToList(dtAll, GetType(HtBaocao), New List(Of HtBaocao)), List(Of HtBaocao))

            'Get list report by DONVI
            Dim listTest As New List(Of HtBaocao)
            listTest.AddRange(dt)
            'listTest = CType(DataHelper.DataTableToList(dt, GetType(HtBaocao), New List(Of HtBaocao)), List(Of HtBaocao))

            'Create list that include any parent node of any node in listTest above
            Dim listParent As List(Of HtBaocao) = FindParentNode(listAll, listTest)

            'Add and filter list parent to list Virtual
            For Each itemParent As HtBaocao In listParent
                If IsExistedInfoInList(listTest, itemParent.Id) = False Then
                    listTest.Add(itemParent)
                End If
            Next

            'Bind to TreeList
            listBC.DataSource = listTest
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    FindParentNode
    ' FullName:  frmDonviGroupBaocao.FindParentNode
    ' Body:		 Find list parent node of list child node
    ' Access:    private 
    ' Returns:   List(Of HtBaocao)) As List(Of HtBaocao)
    ' Parameter: ByVal listAll As List
    ' Parameter: Of HtBaocao
    ' Parameter: ByVal listTest As List
    ' Parameter: Of HtBaocao
    '//////////////////////////////////////////////////
    Private Function FindParentNode(ByVal listAll As IList(Of HtBaocao), ByVal listTest As IList(Of HtBaocao)) As List(Of HtBaocao)
        Dim listParent As New List(Of HtBaocao)
        Dim listReturn As New List(Of HtBaocao)
ComeBack:
        Dim isChanged As Boolean = False
        For Each itemTest As HtBaocao In listTest
            For Each itemAll As HtBaocao In listAll
                If (itemAll.Id = itemTest.IdCha) AndAlso (IsExistedInfoInList(listParent, itemAll.Id) = False) Then
                    listParent.Add(itemAll)
                    isChanged = True
                End If
            Next
        Next

        listTest = listParent
        For Each info As HtBaocao In listParent
            listReturn.Add(info)
        Next
        listParent = New List(Of HtBaocao)
        If isChanged = True Then
            GoTo ComeBack
        End If

        Return listReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    CreateTree
    ' FullName:  frmDonviGroupBaocao.CreateTree
    ' Body:		 Build tree report of DONVI
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub BuildTree()
        LoadReportByDV(DONVIIDF)
        listBC.CollapseAll()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadListReportByDVG
    ' FullName:  frmDonviGroupBaocao.LoadListReportByDVG
    ' Body:		 Load data of group about report permission and bind to list
    ' Access:    private 
    ' Returns:   String, ByVal group_id As Decimal)
    ' Parameter: ByVal donvi_id As String
    ' Parameter: ByVal group_id As Decimal
    '//////////////////////////////////////////////////
    Private Sub LoadListReportByDVG(ByVal donvi_id As String, ByVal group_id As String)
        Try
            LIST_REPORT = New List(Of String)
            LIST_ORIGINAL = New List(Of String)
            Dim dt As IList(Of AppDvGroupBc) = _AppDvGroupBcService.GetByDVG(New Guid(donvi_id), VnsConvert.CGuid(group_id))
            For Each row As AppDvGroupBc In dt
                LIST_REPORT.Add(row.BcId.ToString)
                LIST_ORIGINAL.Add(row.BcId.ToString())
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetStateChildNodeOf
    ' FullName:  frmDonviBaocao.SetStateChildNodeOf
    ' Body:		 Check or Uncheck all child nodes of Node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateChildNodeOf(ByVal node As TreeListNode)
        Dim pInfo As HtBaocao
        Dim info As HtBaocao
        'Checked = True
        If node.Checked = True Then
            pInfo = CType(listBC.GetDataRecordByNode(node), HtBaocao)
            If IsExistedItemInList(LIST_REPORT, pInfo.ID.ToString) = False Then
                LIST_REPORT.Add(pInfo.ID.ToString)
            End If
            node.ExpandAll()
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = True
                info = CType(listBC.GetDataRecordByNode(cNode), HtBaocao)
                If IsExistedItemInList(LIST_REPORT, info.ID.ToString) = False Then
                    LIST_REPORT.Add(info.ID.ToString)
                End If
                SetStateChildNodeOf(cNode)
            Next
        Else 'Checked = False
            pInfo = CType(listBC.GetDataRecordByNode(node), HtBaocao)
            If IsExistedItemInList(LIST_REPORT, pInfo.ID.ToString) = True Then
                LIST_REPORT.Remove(pInfo.ID.ToString)
            End If
            node.Expanded = False
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = False
                info = CType(listBC.GetDataRecordByNode(cNode), HtBaocao)
                If IsExistedItemInList(LIST_REPORT, info.ID.ToString) = True Then
                    LIST_REPORT.Remove(info.ID.ToString)
                End If
                SetStateChildNodeOf(cNode)
            Next
        End If
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetStateParentByChild2
    ' FullName:  frmDonviBaocao.SetStateParentByChild2
    ' Body:		 Set state parent node along child nodes and Only set first-parent
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateParentByChild2(ByVal node As TreeListNode)
        Try
            If Not node.ParentNode Is Nothing Then
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
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    UncheckParentByChild
    ' FullName:  frmDonviBaocao.UncheckParentByChild
    ' Body:		 Set state parent node along child nodes
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateParentByChild(ByVal node As TreeListNode)
        Try
            'if node level = 0, it has no parent
            If node.Level > 0 Then
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
            End If
            'call again
            SetStateParentByChild(node.ParentNode)
        Catch 'ex As Exception
            'Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    ClearCheck
    ' FullName:  frmDonviBaocao.ClearCheck
    ' Body:		 Clear all node checked state in TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub ClearCheck()
        For Each node As TreeListNode In listBC.Nodes
            ResetSelected(node)
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetCheck
    ' FullName:  frmDonviBaocao.SetCheck
    ' Body:		 Set check for nodes of TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SetCheck()
        For Each node As TreeListNode In listBC.Nodes
            SetSelectedNode(node)
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    ResetSelected
    ' FullName:  frmDonviBaocao.ResetSelected
    ' Body:		 Clear check all child node of parent node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub ResetSelected(ByVal node As TreeListNode)
        Try
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = False
                ResetSelected(cNode)
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetSelectedNode
    ' FullName:  frmDonviBaocao.SetSelectedNode
    ' Body:		 Set checked for child node of parent node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetSelectedNode(ByVal node As TreeListNode)
        Try
            'node : is node level 0
            'we have 2 case
            'case 1 : if node has ID existed in LIST_REPORT, certainly it checked
            'case 2 : if node has ID not existed in LIST_REPORT, but it has any child ID existed
            'in LIST_REPORT, it also checked. in other case, it unchecked.
            Dim pInfo As HtBaocao = CType(listBC.GetDataRecordByNode(node), HtBaocao)
            If IsExistedItemInList(LIST_REPORT, pInfo.ID.ToString) = True Then
                node.Checked = True
            Else
                node.Checked = False
            End If

            For Each cNode As TreeListNode In node.Nodes
                Dim info As HtBaocao = CType(listBC.GetDataRecordByNode(cNode), HtBaocao)
                If IsExistedItemInList(LIST_REPORT, info.ID.ToString) = True Then
                    cNode.Checked = True
                Else
                    cNode.Checked = False
                End If

                'If node has child, call again method
                If cNode.HasChildren = True Then
                    SetSelectedNode(cNode)
                End If

                'Set state of parent of node
                SetStateParentByChild2(cNode)
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SavePermission
    ' FullName:  frmDonviBaocao.SavePermission
    ' Body:		 Save permission to database
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SavePermission()
        Try
            'SELECT ALL
            If ALL_REPORT = True Then
                LIST_REPORT = New List(Of String)
                Dim dtAll As List(Of AppDvBc) = _AppDvBcService.GetByDV(New Guid(DONVIIDF))
                For Each rowAll As AppDvBc In dtAll
                    LIST_REPORT.Add(rowAll.BcId.ToString)
                Next
            End If

            'DO ADDED
            For Each itemAdd As String In LIST_REPORT
                If IsExistedItemInList(LIST_ORIGINAL, itemAdd) = False Then
                    Dim infoAdd As New AppDvGroupBc
                    infoAdd.DvId = VnsConvert.CGuid(DONVIIDF)
                    infoAdd.GroupId = VnsConvert.CGuid(GROUPIDF)
                    infoAdd.BcId = VnsConvert.CGuid(itemAdd)
                    infoAdd.BcOrder = 0
                    _AppDvGroupBcService.SaveOrUpdate(infoAdd)
                End If
            Next

            'DO DELETED
            For Each itemDelete As String In LIST_ORIGINAL
                If IsExistedItemInList(LIST_REPORT, itemDelete) = False Then
                    'Delete BC_ID in GROUP of DONVI before delete it in DONVI
                    'bo_dv_group_form.DeleteByF(Integer.Parse(itemDelete))
                    _AppDvGroupBcService.DeleteByDGB(VnsConvert.CGuid(DONVIIDF), VnsConvert.CGuid(GROUPIDF), VnsConvert.CGuid(itemDelete))
                End If
            Next

            'DO REFRESH
            ALL_REPORT = False
            btnSave.Enabled = False
        Catch ex As Exception
            Message_Error(ex)
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

#End Region

#Region "Event Handles"

    Private Sub frmDonviGroupBaocao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitInfo()
            groupDVG.Text = "Danh sách quản lý của Quản trị: " + USER_LOGGED_FULLNAME
            LoadDonViByUser(USER_LOGGED_ID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập báo cáo ...")
            LoadListReportByDVG(DONVIIDF, GROUPIDF)
            'SetCheck()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Báo cáo cho " + Environment.NewLine + "Nhóm: " + GROUPNAMEP + Environment.NewLine + "Đơn vị: " + DONVINAMEP, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ALL_REPORT = True
                btnAll.Enabled = ALL_REPORT
                btnSave.Enabled = True
                btnSave.Focus()
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

    Private Sub lookDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookDonVi.EditValueChanged
        Try
            DONVIIDF = lookDonVi.EditValue.ToString
            DONVINAMEP = lookDonVi.Text

            frmProgress.Instance.Thread = AddressOf BuildTree
            frmProgress.Instance.Show_Progress("Đang tạo danh mục báo cáo ...")
            GetGroupByDV(DONVIIDF)
            groupFunctionForm.Text = "Danh sách báo cáo của Đơn vị: " + DONVINAMEP
            If listGroup.Nodes.Count > 0 Then
                btnSave.Enabled = True
                btnAll.Enabled = True
            Else
                btnSave.Enabled = False
                btnAll.Enabled = False
                GROUPIDF = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub listGroup_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listGroup.FocusedNodeChanged
        Try
            Dim info As DVGInfo = CType(listGroup.GetDataRecordByNode(e.Node), DVGInfo)
            GROUPIDF = info.DVGID
            GROUPNAMEP = info.DVGNAME

            LoadListReportByDVG(DONVIIDF, GROUPIDF)
            'ClearCheck()
            frmProgress.Instance.Thread = AddressOf SetCheck
            frmProgress.Instance.Show_Progress("Đang tải dữ liệu ...")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub listBC_GetSelectImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles listBC.GetSelectImage
        Try
            If e.Node.Level < 5 Then
                e.Node.ImageIndex = e.Node.Level
                e.Node.SelectImageIndex = e.Node.Level
            Else
                e.Node.ImageIndex = 4
                e.Node.SelectImageIndex = 4
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub listBC_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listBC.AfterCheckNode
        Try
            If GROUPIDF Is Nothing Then
                Message_Warning("Bạn chưa chọn nhóm để phân quyền.")
                e.Node.Checked = False
                Exit Sub
            End If

            SetStateChildNodeOf(e.Node)
            SetStateParentByChild(e.Node)
            btnSave.Enabled = True
            btnSave.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Common Class Info"

    Class DVGInfo
#Region "Fields"
        Private _DVGID As String
        Private _DVGNAME As String
#End Region

#Region "Property"
        Public Property DVGID() As String
            Get
                Return _DVGID
            End Get
            Set(ByVal value As String)
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
        Public Sub New(ByVal DVGID As String, ByVal DVGNAME As String)
            Me.DVGID = DVGID
            Me.DVGNAME = DVGNAME
        End Sub
#End Region
    End Class

    Class ReportInfo
    End Class

#End Region

End Class