Imports System
Imports System.Data
Imports System.Windows.Forms

Imports System.Reflection
Imports DevExpress.XtraTreeList.Nodes

Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

''' <summary>
''' Manage user and group
''' </summary>
''' <remarks></remarks>
Public Class frmUserRightList

#Region "Define Variable "
    Private USER_ID_EDIT As Guid  'USER ID
    Private GROUP_ID_EDIT As Guid  'GROUP ID
    Private MA_DON_VI As Guid = New Guid() 'MA DONVI
    'Dim bo_user As UserBO = UserBO.Instance
    'Dim bo_user As Vns.Erp.Core.Admin. = UserBO.Instance
    'Dim bo_group As GroupBO = GroupBO.Instance
    Private _AppUsersService As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService

    Public Property AppUsersService As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService
        Get
            Return _AppUsersService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService)
            _AppUsersService = value
        End Set
    End Property

    Private _AppGroupsService As Vns.Erp.Core.Admin.Service.Interface.IAppGroupsService
    Public Property AppGroupsService As Vns.Erp.Core.Admin.Service.Interface.IAppGroupsService
        Get
            Return _AppGroupsService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppGroupsService)
            _AppGroupsService = value
        End Set
    End Property

    Dim _DmDonviService As IDmDonviService
    Public Property DmDonviService As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property

    'Dim bo_dv_group As APP_Dv_GroupBO = APP_Dv_GroupBO.Instance
    Private _AppDvGroupService As IAppDvGroupService
    Public Property AppDvGroupService As IAppDvGroupService
        Get
            Return _AppDvGroupService
        End Get
        Set(ByVal value As IAppDvGroupService)
            _AppDvGroupService = value
        End Set
    End Property


    'Dim bo_dv_group_user As APP_Dv_Group_UserBO = APP_Dv_Group_UserBO.Instance
    Private _AppDvGroupUserService As IAppDvGroupUserService
    Public Property AppDvGroupUserService As IAppDvGroupUserService
        Get
            Return _AppDvGroupUserService
        End Get
        Set(ByVal value As IAppDvGroupUserService)
            _AppDvGroupUserService = value
        End Set
    End Property

    Private _AppDvGroupFormService As IAppDvGroupFormService
    Public Property AppDvGroupFormService As IAppDvGroupFormService
        Get
            Return _AppDvGroupFormService
        End Get
        Set(ByVal value As IAppDvGroupFormService)
            _AppDvGroupFormService = value
        End Set
    End Property

    Private _frmUserEdit As frmUserEdit
    Public Property frmUserEdit As frmUserEdit
        Get
            Return _frmUserEdit
        End Get
        Set(ByVal value As frmUserEdit)
            _frmUserEdit = value
        End Set
    End Property
#End Region

#Region "Form Function "

    ''' <summary>
    ''' Display data selected node
    ''' </summary>
    ''' <param name="SelectedNode"></param>
    ''' <remarks></remarks>
    Private Sub DisplaySelectedNode(ByVal SelectedNode As TreeListNode)
        If Not SelectedNode Is Nothing Then
            If SelectedNode.Level = 0 Then 'USER_KEY or GROUP_KEY
                If SelectedNode.GetValue(0).ToString.Equals("USER_KEY") Then
                    pnlUser.Visible = True
                    pnlGroup.Visible = False
                    ClearUserInfo()
                ElseIf SelectedNode.GetValue(0).ToString.Equals("GROUP_KEY") Then
                    pnlGroup.Visible = True
                    pnlUser.Visible = False
                    ClearGroupInfo()
                End If
            ElseIf SelectedNode.Level = 1 Then 'USER or GROUP
                Dim idValue As Guid = VnsConvert.CGuid(SelectedNode.GetValue(0))
                Dim isObject As Integer = IsUserOrGroupObject(SelectedNode)
                If isObject = 1 Then '1 = User
                    pnlUser.Visible = True
                    pnlGroup.Visible = False
                    USER_ID_EDIT = idValue
                    DisplayUser(USER_ID_EDIT)
                ElseIf isObject = 2 Then '2 = Group
                    pnlGroup.Visible = True
                    pnlUser.Visible = False
                    GROUP_ID_EDIT = idValue
                    DisplayGroup(GROUP_ID_EDIT)
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Remove child node
    ''' </summary>
    ''' <param name="ParentNode"></param>
    ''' <remarks></remarks>
    Private Sub RemoveChildNode(ByVal ParentNode As TreeListNode)
        'Dim Node As TreeListNode = Nothing
        trlAdmin.BeginUnboundLoad()
        ParentNode.Nodes.Clear()
        trlAdmin.EndUnboundLoad()
    End Sub

    ''' <summary>
    ''' Display data of node
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="ParentNode"></param>
    ''' <param name="type"></param>
    ''' <remarks></remarks>
    Private Sub DisplayNode(ByVal lstUser As IList(Of AppUsers), ByVal lstGroup As IList(Of AppGroups), ByVal ParentNode As TreeListNode, ByVal type As String)
        Dim Node As TreeListNode = Nothing
        Dim imgIndex As Integer = 0
        Dim selectedImgIndex As Integer = 0

        Dim list As New List(Of UGInfo)
        If type.Equals("user") Then
            imgIndex = 7
            selectedImgIndex = 7
            list = ConvertToListUser(lstUser)
        ElseIf type.Equals("group") Then
            list = ConvertToListGroup(lstGroup)
            imgIndex = 6
            selectedImgIndex = 6
        End If

        RemoveChildNode(ParentNode)

        trlAdmin.BeginUnboundLoad()
        Try
            For Each info As UGInfo In list
                Dim Values As Object() = {info.UGID, info.UGNAME}
                Node = trlAdmin.AppendNode(Values, ParentNode)
                Node.ImageIndex = imgIndex
                Node.SelectImageIndex = selectedImgIndex
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
        trlAdmin.EndUnboundLoad()
    End Sub

    ''' <summary>
    ''' Init form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        InitControl()
        InitData()
        InitTitle()
    End Sub

    ''' <summary>
    ''' Init title of form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitTitle()
        If (Globals.IS_ADMIN_TONG = True) Then
            Me.Text = "Quản lý người dùng [Quản trị cấp cao]"
        ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            Me.Text = "Quản lý người dùng [Quản trị đơn vị]"
        End If
    End Sub

    ''' <summary>
    ''' Init data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitData()
        Dim ds As IList(Of AppUsers) = Nothing
        Dim lstUser As IList(Of AppUsers) = New List(Of AppUsers)()
        Dim lstGroup As IList(Of AppGroups) = New List(Of AppGroups)()
        Try
            'Load User to TreeView
            'If (Globals.IS_ADMIN_TONG = True) Then
            '    ds = bo_user.GetUserByDV(lookUpDONVI.EditValue.ToString)
            'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            '    ds = bo_user.GetUserByDV(Generals.DON_VI.ID)
            'End If
            If (lookUpDONVI.EditValue <> Nothing) Then
                Dim donviid As Guid = VnsConvert.CGuid(lookUpDONVI.EditValue)
                lstUser = AppUsersService.GetUserByDV(donviid)

                DisplayNode(lstUser, Nothing, trlAdmin.Nodes(0), "user")

                lstGroup = AppGroupsService.GetByDV(donviid) '  .List(1, 100, GroupPros, GroupValues, Nothing)
                DisplayNode(Nothing, lstGroup, trlAdmin.Nodes(1), "group")
            End If
            'Expand All
            trlAdmin.ExpandAll()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Reload list user in treeList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReloadUser()
        'Dim ds As DataSet = Nothing
        Dim lstUser As IList(Of AppUsers) = New List(Of AppUsers)


        Dim donviid As Guid

        Try
            donviid = CType(ComboHelper.GetSelectData(lookUpDONVI), DmDonvi).Id

            lstUser = AppUsersService.GetUserByDV(donviid)

            DisplayNode(lstUser, Nothing, trlAdmin.Nodes(0), "user")
            trlAdmin.ExpandAll()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Reload list group in treeList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReloadGroup()
        Dim lstGroup As IList(Of AppGroups) = New List(Of AppGroups)
        Dim donviid As Guid
        Try
            donviid = CType(ComboHelper.GetSelectData(lookUpDONVI), DmDonvi).Id

            lstGroup = AppGroupsService.GetByDV(donviid)

            DisplayNode(Nothing, lstGroup, trlAdmin.Nodes(1), "group")
            trlAdmin.ExpandAll()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Init control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitControl()
        Control_SetFont(Me, CS_FONT_NAME)
        pnlUser.Dock = DockStyle.Fill
        pnlGroup.Dock = DockStyle.Fill
        Control_SetState(grpUser, DataInputState.ViewMode)
        Control_SetState(grpGroup, DataInputState.ViewMode)
        Panel_InitControl(grpUser, "APP_USERS")
    End Sub

    ''' <summary>
    ''' Load list DONVI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindDV()
        Try
            'Dim dt As DataTable = bo_dv.GetAll().Tables(0)
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            lookUpDONVI.Properties.DataSource = dt
            If Globals.IS_ADMIN_TONG = True Then
                If dt.Count > 0 Then
                    lookUpDONVI.ItemIndex = 0
                End If
                'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            Else
                gControlDV.Visible = False
                lookUpDONVI.EditValue = Generals.DonviID
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Check item existed in list
    ''' </summary>
    ''' <param name="list"></param>
    ''' <param name="item"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Delete group
    ''' </summary>
    ''' <param name="group_id"></param>
    ''' <remarks></remarks>
    Private Sub DeleteGroup(ByVal group_id As Guid)
        Try
            Dim tmp As AppGroups = New AppGroups()
            tmp.Id = group_id
            AppGroupsService.Delete(tmp)
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Convert dataTable to list user
    ''' </summary>
    ''' <param name="dtUser"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ConvertToListUser(ByVal dtUser As IList(Of AppUsers))
        Try
            Dim list As New List(Of UGInfo)
            If dtUser.Count > 0 Then
                For Each row As AppUsers In dtUser
                    list.Add(New UGInfo(row.Id.ToString, row.Fullname))
                Next
            End If
            Return list
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Convert dataTable to list group
    ''' </summary>
    ''' <param name="dtGroup"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ConvertToListGroup(ByVal dtGroup As IList(Of AppGroups))
        Try
            Dim list As New List(Of UGInfo)
            If dtGroup.Count > 0 Then
                For Each row As AppGroups In dtGroup
                    list.Add(New UGInfo(row.Id.ToString, row.Grouptext))
                Next
            End If
            Return list
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Specify object is user or group
    ''' </summary>
    ''' <param name="node"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsUserOrGroupObject(ByVal node As TreeListNode) As Integer
        '1 = User
        '2 = Group
        Try
            Dim key As String = node.ParentNode.GetValue(0).ToString
            If key.Equals("USER_KEY") Then
                Return 1
            ElseIf key.Equals("GROUP_KEY") Then
                Return 2
            Else
                Return 1
            End If
        Catch
            Return 1
        End Try
    End Function

#End Region

#Region "Form Event"

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmUserRightList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            BindDV()
            InitForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmUserRightList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' TreeList event handles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub trlAdmin_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles trlAdmin.FocusedNodeChanged
        Try
            DisplaySelectedNode(e.Node)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Add User
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUAdd.Click
        Try
            Dim oUsr As frmUserEdit = Me.frmUserEdit
            If oUsr.ShowForm(Guid.Empty, DataInputState.AddMode) Then
                ReloadUser()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Update user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUEdit.Click
        Try
            Dim oUsr As frmUserEdit = ObjectFactory.GetObject("frmUserEdit")
            If oUsr.ShowForm(USER_ID_EDIT, DataInputState.EditMode) Then
                ReloadUser()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Set Password
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPassword.Click
        Try
            Dim oUsr As frmUserEdit = ObjectFactory.GetObject("frmUserEdit")
            oUsr.ShowForm(USER_ID_EDIT, DataInputState.VersionMode)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Add Group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGAdd.Click
        Try
            Dim oGrp As frmGroupEdit = ObjectFactory.GetObject("frmGroupEdit")
            If oGrp.ShowForm(New Guid, DataInputState.AddMode) Then
                ReloadGroup()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Update group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGEdit.Click
        Try
            Dim oGroup As frmGroupEdit = ObjectFactory.GetObject("frmGroupEdit")
            If oGroup.ShowForm(GROUP_ID_EDIT, DataInputState.EditMode) Then
                ReloadGroup()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Delete group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGDelete.Click
        Try
            If GROUP_ID_EDIT <> Guid.Empty Then
                If Message_Confirm("Bạn thực sự muốn xóa nhóm này khỏi đơn vị ?") Then
                    Try
                        AppDvGroupFormService.DeleteByGroup(GROUP_ID_EDIT)
                        AppDvGroupUserService.DeleteByG(GROUP_ID_EDIT)
                        AppDvGroupService.DeleteByG(GROUP_ID_EDIT)
                        DeleteGroup(GROUP_ID_EDIT)
                        ReloadGroup()
                    Catch ex As Exception
                        Message_Error(ex)
                    End Try
                End If
            Else
                Message_Information("Bạn chưa chọn nhóm người dùng !")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Select DONVI, only for Global Admin
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lookUpDONVI_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookUpDONVI.EditValueChanged
        Try
            ReloadUser()
            ReloadGroup()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Display Data"

    ''' <summary>
    ''' Bind data of user to control 
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <remarks></remarks>
    Private Sub DisplayUser(ByVal UserID As Guid)
        If VnsCheck.IsNullGuid(UserID) Then
            Return
        End If
        'User Information
        Dim oUser As AppUsers = _AppUsersService.Get(UserID)
        txtUserName.Text = oUser.Username
        txtFullName.Text = oUser.Fullname
        btnUEdit.Enabled = True
        btnSetPassword.Enabled = True


    End Sub

    ''' <summary>
    ''' Bind data of group to control
    ''' </summary>
    ''' <param name="GroupID"></param>
    ''' <remarks></remarks>
    Private Sub DisplayGroup(ByVal GroupID As Guid)
        If VnsCheck.IsNullGuid(GroupID) Then
            Return
        End If
        Dim oGroup As AppGroups = AppGroupsService.GetById(GroupID)
        'Information 
        txtGroupName.Text = oGroup.Grouptext
        btnGEdit.Enabled = True
        If GROUP_ID_EDIT = Null.NullGuid Then
            btnGDelete.Enabled = False
        Else
            btnGDelete.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Clean user info along control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearUserInfo()
        USER_ID_EDIT = Guid.Empty
        txtUserName.Text = ""
        txtFullName.Text = ""
        btnUEdit.Enabled = False
        btnSetPassword.Enabled = False
    End Sub

    ''' <summary>
    ''' Clean group info along control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearGroupInfo()
        GROUP_ID_EDIT = New Guid
        txtGroupName.Text = ""
        btnGEdit.Enabled = False
        btnGDelete.Enabled = False
    End Sub

#End Region

#Region "Class Info"
    Class UGInfo
#Region "Fields"
        Private _UGID As String
        Private _UGNAME As String
#End Region

#Region "Property"
        Public Property UGID() As String
            Get
                Return _UGID
            End Get
            Set(ByVal value As String)
                _UGID = value
            End Set
        End Property

        Public Property UGNAME() As String
            Get
                Return _UGNAME
            End Get
            Set(ByVal value As String)
                _UGNAME = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal UGID As String, ByVal UGNAME As String)
            Me.UGID = UGID
            Me.UGNAME = UGNAME
        End Sub
#End Region
    End Class
#End Region

#Region "Show Grant Permission"
    Private Sub btnGrantFunction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrantFunction.Click
        Try
            'Dim m_FrmMain As Windows.Forms.Form = Me.ParentForm
            'Dim typeMain As Type = m_FrmMain.GetType()
            'Dim methodInfo As MethodInfo = Nothing
            Dim m_Frm As frmDonviGroupForm = CType(ObjectFactory.GetObject("frmDonviGroupForm"), frmDonviGroupForm)

            m_Frm.ShowDialog()

            'If Globals.IS_ADMIN_TONG = True Then
            '    'methodInfo = GetMethodByName(m_FrmMain, "ShowGrantFunctionDV")
            '    'methodInfo = GetMethodByName(m_FrmMain, "ShowGrantFunctionGlobal")
            '    m_Frm.ShowDialog()
            'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            '    'methodInfo = GetMethodByName(m_FrmMain, "ShowGrantFunctionDV")
            '    m_Frm.ShowDialog()
            'End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnGrantReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrantReport.Click
        Try
            Dim m_Frm As frmDonviGroupBaocao = CType(ObjectFactory.GetObject("frmDonviGroupBaocao"), frmDonviGroupBaocao)

            If Globals.IS_ADMIN_TONG = True Then
                'methodInfo = typeMain.GetMethod("ShowGrantReportDV")
                'methodInfo = typeMain.GetMethod("ShowGrantReportGlobal")
            ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
                'methodInfo = typeMain.GetMethod("ShowGrantReportDV")
            End If

            m_Frm.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    'Private Sub frmUserRightList_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    '    Me.Dispose()
    'End Sub
#End Region

End Class

