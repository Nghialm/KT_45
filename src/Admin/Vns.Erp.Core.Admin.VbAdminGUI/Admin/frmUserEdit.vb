Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports System.Text.RegularExpressions
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

''' <summary>
''' Update user info
''' </summary>
''' <remarks></remarks>
Public Class frmUserEdit

#Region "Variables"
    Private m_InputState As FormGlobals.DataInputState 'State mode
    Private m_UserID As Guid  'User ID
    Private m_Return As DialogResult 'Dialog Result
    Private LIST_DV_GROUP As List(Of String) 'List tem DONVI - GROUP

    Dim _UserService As IAppUsersService
    Public Property AppUserService As IAppUsersService
        Get
            Return _UserService
        End Get
        Set(ByVal value As IAppUsersService)
            _UserService = value
        End Set
    End Property

    Dim _AppGroupsService As IAppGroupsService
    Public Property AppGroupsService As IAppGroupsService
        Get
            Return _AppGroupsService
        End Get
        Set(ByVal value As IAppGroupsService)
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

    Dim _AppDvGroupUserService As IAppDvGroupUserService
    Public Property AppDvGroupUserService As IAppDvGroupUserService
        Get
            Return _AppDvGroupUserService
        End Get
        Set(ByVal value As IAppDvGroupUserService)
            _AppDvGroupUserService = value
        End Set
    End Property

    Dim Gen_DonviID As Guid = New Guid()
#End Region

#Region "Common Functions"

    ''' <summary>
    ''' Show Form User
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="state"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowForm(ByVal UserID As Guid, ByVal state As DataInputState) As Boolean
        Form_SetText(Me, "User", state)
        Form_InitDialog(Me)
        m_InputState = state
        m_UserID = UserID

        frmProgress.Instance.Thread = AddressOf InitForm
        frmProgress.Instance.Show_Progress() '
        Return (ShowDialog() = Windows.Forms.DialogResult.OK)
    End Function

    ''' <summary>
    ''' Init Form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        InitControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                Me.Text = "Người dùng [Thêm mới]"
                SetPro(False)
                CleanData()
            Case DataInputState.EditMode
                Me.Text = "Người dùng [Cập nhật]"
                SetPro(False)
                Me.txtUserName.Properties.ReadOnly = True
                Me.txtUserPassword.Properties.ReadOnly = True
                Me.txtRetype.Properties.ReadOnly = True
                SetUserData()
                txtRetype.Text = txtUserPassword.Text
            Case DataInputState.VersionMode
                Me.Text = "Người dùng [Thay đổi mật khẩu]"
                SetPro(True)
                Me.txtUserName.Properties.ReadOnly = True
                Me.txtFullName.Properties.ReadOnly = True
                SetUserData()
                Me.txtUserPassword.Properties.ReadOnly = False
                Me.txtRetype.Properties.ReadOnly = False
                txtRetype.Text = ""
                txtUserPassword.Text = ""
        End Select
    End Sub

    Private Sub SetPro(ByVal b As Boolean)
        Me.txtUserName.Properties.ReadOnly = b
        Me.txtFullName.Properties.ReadOnly = b
        Me.txtUserPassword.Properties.ReadOnly = b
        Me.txtRetype.Properties.ReadOnly = b
        Me.txtEmail.Properties.ReadOnly = b
        Me.txtTel.Properties.ReadOnly = b
        Me.cboDONVI_ID.Enabled = Not b
        treeGroup.Enabled = Not b
    End Sub

    Private Sub CleanData()
        Me.txtUserName.EditValue = ""
        Me.txtFullName.EditValue = ""
        Me.txtUserPassword.EditValue = ""
        Me.txtRetype.EditValue = ""
        Me.txtEmail.EditValue = ""
        Me.txtTel.EditValue = ""
    End Sub

    ''' <summary>
    ''' Set user data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetUserData()
        Try
            Dim oUserInfo As AppUsers = _UserService.Get(m_UserID)
            'Panel_SetControlValue(grpUserInfo, oUserInfo)
            txtUserName.Text = oUserInfo.Username
            txtFullName.Text = oUserInfo.Fullname
            txtUserPassword.Text = oUserInfo.Userpassword
            txtUserPassword.Tag = oUserInfo.Userpassword
            txtEmail.Text = oUserInfo.Email
            txtTel.Text = oUserInfo.Tel
            cboDONVI_ID.EditValue = oUserInfo.DonviId
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
        'Panel_InitControl(grpUserInfo, "APP_USERS")
    End Sub

    ''' <summary>
    ''' Check user is existed
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsExistedUser(ByVal username As String) As Boolean
        Dim objCheck As AppUsers = _UserService.GetByUserName(txtUserName.Text)
        If objCheck Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Check item existed in list DONVI
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsExistedInListDV() As Boolean
        If LIST_DV_GROUP.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Save data to database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()
        Try
            Dim ObjInfo As New AppUsers
            Dim objLast As New AppUsers
            Dim infoDGU As New AppDvGroupUser
            Dim GuidcboDonvi As Guid = CType(ComboHelper.GetSelectData(cboDONVI_ID), DmDonvi).Id
            'Panel_GetControlValue(grpUserInfo, ObjInfo, "APP_USERS")
            ObjInfo.Userpassword = _UserService.EncryptPassword(Me.txtUserName.Text.Trim, txtUserPassword.Text)
            ObjInfo.Username = txtUserName.Text
            ObjInfo.Fullname = txtFullName.Text
            ObjInfo.Email = txtEmail.Text
            ObjInfo.Tel = txtTel.Text
            ObjInfo.DonviId = GuidcboDonvi
            ObjInfo.Id = m_UserID

            Select Case m_InputState
                '***************************************************
                '************* ADD MODE ****************************
                '***************************************************
                Case DataInputState.AddMode, DataInputState.CopyMode
                    ObjInfo.DonviId = GuidcboDonvi
                    _UserService.Save(ObjInfo)
                    objLast = _UserService.GetLast
                    'Add list groups for User
                    'Add Mode need at least is ONE group
                    For Each itemAdd As String In LIST_DV_GROUP
                        Dim donvi_id As String = itemAdd.Split(";")(0).ToString
                        Dim group_id As String = itemAdd.Split(";")(1).ToString
                        infoDGU = New AppDvGroupUser()
                        infoDGU.DvId = VnsConvert.CGuid(donvi_id)
                        infoDGU.GroupId = New Guid(group_id)
                        infoDGU.UserId = objLast.Id
                        infoDGU.UserOrder = 0
                        _AppDvGroupUserService.Save(infoDGU)
                    Next
                    '******************************************************************
                    '************* UPDATE MODE ****************************************
                    '******************************************************************
                Case DataInputState.EditMode
                    ObjInfo.Userpassword = txtUserPassword.Tag.ToString()
                    _UserService.SaveOrUpdate(ObjInfo)
                    'Delete groups of user
                    If Globals.IS_ADMIN_TONG = True Then
                        _AppDvGroupUserService.DeleteByU(ObjInfo.Id)
                    ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
                        _AppDvGroupUserService.DeleteByDU(GuidcboDonvi, ObjInfo.Id)
                    End If
                    'Add new groups for user
                    For Each itemUpdate As String In LIST_DV_GROUP
                        Dim donvi_id As String = itemUpdate.Split(";")(0).ToString
                        Dim group_id As String = itemUpdate.Split(";")(1).ToString
                        infoDGU = New AppDvGroupUser()
                        infoDGU.DvId = VnsConvert.CGuid(donvi_id)
                        infoDGU.GroupId = New Guid(group_id)
                        infoDGU.UserId = ObjInfo.Id
                        infoDGU.UserOrder = 0
                        _AppDvGroupUserService.Save(infoDGU)
                    Next
                Case DataInputState.VersionMode
                    _UserService.ChangePassword(ObjInfo)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Bind data to LookupEdit
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindDV()
        Try
            Dim dt As List(Of DmDonvi) = New List(Of DmDonvi)()
            dt.AddRange(_DmDonviService.GetAll())
            'If (Globals.IS_ADMIN_TONG = True) Then
            'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            '    'Dim props As ArrayList = New ArrayList()
            '    'Dim values As ArrayList = New ArrayList()
            '    'props.Add("DonViId")
            '    'values.Add(Generals.DonviID)
            '    'dt = _DmDonviService.List(-1, -1, Nothing, Nothing, Nothing)
            '    dt = New List(Of DmDonvi)
            '    dt.Add(_DmDonviService.Get(Generals.DonviID))
            'End If

            If ((dt IsNot Nothing) And (dt.Count > 0)) Then
                cboDONVI_ID.Properties.DataSource = dt
                cboDONVI_ID.Properties.DisplayMember = "TenDonvi"
                cboDONVI_ID.Properties.ValueMember = "Id"
                cboDONVI_ID.ItemIndex = 0
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Bind data to TreeList
    ''' </summary>
    ''' <param name="donvi_id"></param>
    ''' <remarks></remarks>
    Private Sub BindGroup(ByVal donvi_id As Guid)
        Try
            'Dim dt As DataTable = _AppGroupsService.GetByDV(donvi_id).Tables(0)
            Dim dt As List(Of AppGroups) = New List(Of AppGroups)()
            dt.AddRange(_AppGroupsService.GetByDV(donvi_id))
            '.GetByDV(donvi_id)
            If ((dt IsNot Nothing) And (dt.Count > 0)) Then
                treeGroup.DataSource = dt
                treeGroup.SetFocusedNode(treeGroup.Nodes(0))
            Else
                treeGroup.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Load list DONVI - GROUP
    ''' </summary>
    ''' <param name="user_id"></param>
    ''' <remarks></remarks>
    Private Sub LoadListDVG(ByVal user_id As Guid)
        Try
            If user_id = Guid.Empty Then 'ADD
                LIST_DV_GROUP = New List(Of String)
            Else 'UPDATE
                LIST_DV_GROUP = New List(Of String)
                Dim dt As List(Of AppDvGroupUser) = New List(Of AppDvGroupUser)
                dt.AddRange(_AppDvGroupUserService.GetByUser(user_id))
                For Each row As AppDvGroupUser In dt
                    LIST_DV_GROUP.Add(row.DvId.ToString + ";" + row.GroupId.ToString)
                Next
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Select list group of user
    ''' </summary>
    ''' <param name="donvi_id"></param>
    ''' <remarks></remarks>
    Private Sub SelectGroupForUser(ByVal donvi_id As Guid)
        Try
            For Each node As TreeListNode In treeGroup.Nodes
                Dim itemCheck As String = donvi_id.ToString() + ";" + node.GetValue(0).ToString
                If IsExistedItemInList(LIST_DV_GROUP, itemCheck) = True Then
                    node.Checked = True
                End If
            Next
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

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmUserEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindDV() 'DonVi


            If Globals.IS_ADMIN_TONG = True Then
                Gen_DonviID = New Guid(cboDONVI_ID.EditValue.ToString())
            Else
                'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
                Gen_DonviID = New Guid(Generals.DonviID.ToString())
            End If
            BindGroup(Gen_DonviID) 'Group
            LoadListDVG(m_UserID) 'Load DonVi and Group of user if EditMode
            SelectGroupForUser(Gen_DonviID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' LookupEdit event handles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboDONVI_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDONVI_ID.EditValueChanged
        Try
            Dim donvi_id As Guid = New Guid(cboDONVI_ID.EditValue.ToString)
            BindGroup(donvi_id)
            SelectGroupForUser(donvi_id)
            Gen_DonviID = donvi_id
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Exit from user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Clear info from control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            Control_ClearData(grpUserInfo)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Do save
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Panel_CheckError(Me.grpUserInfo) Then
                Return
            End If

            Dim s_username As String = txtUserName.Text
            Dim matches As MatchCollection = Regex.Matches(s_username, "[a-zA-Z0-9_]", _
     RegexOptions.IgnoreCase)



            'match.NextMatch()
            If (s_username.Length > matches.Count) Then
                Message_Information("Tên người dùng chỉ được ký tự không dấu, không có ký tự đặc biệt!")
                Return
            End If

            If Me.txtUserPassword.Text <> Me.txtRetype.Text Then
                Message_Information("Xác nhận mật khẩu không khớp !")
                Return
            End If

            If m_InputState = DataInputState.AddMode Then
                If IsExistedUser(txtUserName.Text) = True Then
                    Message_Information("Tài khoản đã tồn tại trong hệ thống !")
                    Return
                End If

                If IsExistedInListDV() = False Then
                    Message_Information("Bạn cần chọn ít nhất một nhóm cho người dùng !")
                    Return
                End If
            End If
            frmProgress.Instance.Thread = AddressOf SaveData
            frmProgress.Instance.Show_Progress("Saving data")
            frmProgress.Instance.SetFinishText(ConstantMsgs.MESSAGE_SAVE_SUCCESS)
            Me.Tag = Me.txtUserName.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' TreeList event handles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub treeGroup_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeGroup.AfterCheckNode
        Try
            Dim rowView As AppGroups = CType(treeGroup.GetDataRecordByNode(e.Node), AppGroups)
            Dim group_id As String = rowView.Id.ToString()
            If e.Node.Checked = True Then
                LIST_DV_GROUP.Add(Gen_DonviID.ToString() + ";" + group_id)
            Else
                LIST_DV_GROUP.Remove(Gen_DonviID.ToString() + ";" + group_id)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class