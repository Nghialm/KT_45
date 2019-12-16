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
Public Class frmUserQuickEdit

#Region "Variables"
    Private m_InputState As FormGlobals.DataInputState 'State mode
    Private m_UserID As Guid  'User ID

    Dim _UserService As IAppUsersService
    Public Property AppUserService As IAppUsersService
        Get
            Return _UserService
        End Get
        Set(ByVal value As IAppUsersService)
            _UserService = value
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

    Dim Gen_DonviID As Guid = New Guid()
#End Region

#Region "Common Functions"
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
        Dim objCheck As AppUsers = _UserService.GetByUsername(txtUserName.Text)
        If objCheck Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Save data to database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()
        Try
            Dim ObjInfo As New AppUsers
            ObjInfo.Userpassword = _UserService.EncryptPassword(Me.txtUserName.Text.Trim, txtUserPassword.Text)
            ObjInfo.Username = txtUserName.Text
            ObjInfo.Fullname = txtFullName.Text
            ObjInfo.Email = txtEmail.Text
            ObjInfo.Tel = txtTel.Text
            ObjInfo.DonviId = Generals.DonviID
            ObjInfo.Id = m_UserID

            Select Case m_InputState
                Case DataInputState.EditMode
                    ObjInfo.Userpassword = txtUserPassword.Tag.ToString()
                    _UserService.SaveOrUpdate(ObjInfo)
                Case DataInputState.VersionMode
                    _UserService.ChangePassword(ObjInfo)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Sub
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
            Dim state As DataInputState = DataInputState.EditMode
            Form_SetText(Me, "User", state)
            m_InputState = state
            m_UserID = Generals.USER.Id

            InitForm()
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
            Dim matches As MatchCollection = Regex.Matches(s_username, "[a-zA-Z0-9_]",
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
#End Region

End Class