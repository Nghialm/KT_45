Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Xml
Imports System.Security.AccessControl
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports RSADecrypt

'*************************************************************************
'	created:	2011/09/26
'	created:	26:9:2011   15:10
'	filename: 	D:\TRINAM\KeToan\v51\KTY.Security\Forms\Admin\frmLogin.vb
'	file path:	D:\TRINAM\KeToan\v51\KTY.Security\Forms\Admin
'	file base:	frmLogin
'	file ext:	vb
'	author:		Nguyen Quyet Tien
'	
'	purpose:	Login system
'*************************************************************************

''' <summary>
''' Login system
''' </summary>
''' <remarks></remarks>
Public Class frmLogin

#Region "Variables"
    Private m_UserID As Guid 'USER ID
    Private m_Return As DialogResult 'DIALOG RESULT
    Private keyEncrypted As String = "hko98f8flKfOeiIlLjL" 'KEY FOR ENCRYPT AND DECRYPT
    Dim WcfAuthenticationService As Wcf.Client.WcfAuthenticationService = New Wcf.Client.WcfAuthenticationService()
    Dim _AppUsersService As IAppUsersService
    Public Property AppUsersService As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService
        Get
            Return _AppUsersService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService)
            _AppUsersService = value
        End Set
    End Property
    Dim _DmDonviService As IDmDonviService
    Public Property DmDonviService As Vns.Erp.Core.Admin.Service.Interface.IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IDmDonviService)
            _DmDonviService = value
        End Set
    End Property
    Dim _AppDvGroupUserService As IAppDvGroupUserService

    Public Property AppDvGroupUserService As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupUserService
        Get
            Return _AppDvGroupUserService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupUserService)
            _AppDvGroupUserService = value
        End Set
    End Property
#End Region

#Region "Common Functions"
    ''' <summary>
    ''' Show Form Login
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowForm() As Boolean
        Form_InitDialog(Me)
        grpUserInfo.Text = AdminMessage.USER_LOGIN_INFORMATION
        btnLogin.Text = AdminMessage.LOGIN
        btnCancel.Text = AdminMessage.CANCEL
        chkRemember.Text = AdminMessage.REMEMBER_PASSWORD
        Me.Text = AdminMessage.LOGIN
        lblImporter.Text = AdminMessage.USERNAME
        lblSeriesID.Text = AdminMessage.PASSWORD
        frmProgress.Instance.Thread = AddressOf InitForm
        frmProgress.Instance.Show_Progress() '        
        Return (ShowDialog() = Windows.Forms.DialogResult.OK)
    End Function

    ''' <summary>
    ''' Init form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        InitControl()
    End Sub

    ''' <summary>
    ''' Set user data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetUserData()
        Try
            Dim oUserInfo As AppUsers = _AppUsersService.Get(m_UserID)
            Panel_SetControlValue(grpUserInfo, oUserInfo)
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
    End Sub

    ''' <summary>
    ''' Load list DONVI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadDonVi()
        Try
            'Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            Dim dt As List(Of DmDonvi) = New List(Of DmDonvi)()
            dt.Add(New DmDonvi())
            dt.AddRange(_DmDonviService.GetListDonVi())

            lookUpDonVi.Properties.DataSource = dt
            lookUpDonVi.Properties.ValueMember = "Id"
            lookUpDonVi.Properties.DisplayMember = "TenDonvi"
            If dt.Count > 0 Then
                TNCommon.SelectFirst(lookUpDonVi)
            Else
                lookUpDonVi.ItemIndex = -1
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Check exist user in DONVI
    ''' </summary>
    ''' <param name="dv_id"></param>
    ''' <param name="user_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsExistUserInDV(ByVal dv_id As Guid, ByVal user_id As Guid)
        Try
            'Dim dt As DataTable = bo_dv_group_user.GetDVUser(dv_id, user_id).Tables(0)
            Dim dt As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetDVUser(dv_id, user_id)
            If dt.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Login to system
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Login() As Boolean
        Dim bRet As Boolean = False
        Try
            If Not lookUpDonVi.ItemIndex = -1 Then
                Generals.DON_VI.Id = VnsConvert.CGuid(lookUpDonVi.EditValue)
                Generals.DON_VI.TenDonvi = lookUpDonVi.Text
                Generals.DonviID = VnsConvert.CGuid(lookUpDonVi.EditValue)
            Else
                Generals.DON_VI.Id = New Guid()
                Generals.DON_VI.TenDonvi = ""
            End If

            Dim ObjInfo As AppUsers = New AppUsers()
            If (VnsCheck.IsNullGuid(Generals.DonviID)) Then
                ObjInfo = AppUsersService.LoginWithoutDonvi(txtUserName.Text, txtUserPassword.Text)

                Dim tmp As DmDonvi = _DmDonviService.Get(ObjInfo.DonviId)
                Generals.DON_VI.Id = ObjInfo.DonviId
                Generals.DON_VI.TenDonvi = tmp.TenDonvi
                Generals.DonviID = ObjInfo.DonviId
            Else
                ObjInfo = AppUsersService.Login(txtUserName.Text, txtUserPassword.Text, Generals.DonviID)
            End If

            If ObjInfo IsNot Nothing Then
                LoginUserID = ObjInfo.Id
                LoginUserName = ObjInfo.Username
                LoginFullName = ObjInfo.Fullname
                

                If chkRemember.Checked Then
                    Try
                        'Write information to XML Config file
                        WriteInfo(LoginUserID.ToString, LoginUserName, Me.txtUserPassword.Text, Generals.DON_VI.Id.ToString(), Generals.DON_VI.TenDonvi, "", "", "", "", "")
                    Catch ex As Exception
                    End Try
                Else
                    ClearInfo()
                End If

                Return True
            Else
                MessageBox.Show(AdminMessage.INVALID_USERNAME_OR_PASSWORD, AdminMessage.NOTYFY, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
            Message_Warning("Kết nối tới máy chủ thất bại. Vui lòng thiết lập lại kết nối !")
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Read info from XML file and bind to control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadInfo()
        Try
            'Remove Lock
            'RemoveLock()

            'Get Document XML
            Dim doc As XmlDocument = XMLConfig.XmlReader("KTYConfig.xml")
            'Get Root Element named "config"
            Dim root As XmlElement = doc.DocumentElement
            'Get element named "login_info"
            Dim loginNode As XmlNode = root.SelectSingleNode("login_info")
            Dim userid As String = loginNode.SelectSingleNode("userid").InnerText
            Dim username As String = loginNode.SelectSingleNode("username").InnerText
            Dim password As String = loginNode.SelectSingleNode("password").InnerText
            Dim donvi_id As String = loginNode.SelectSingleNode("donvi_id").InnerText
            Dim ten_donvi As String = loginNode.SelectSingleNode("ten_donvi").InnerText
            Dim other1 As String = loginNode.SelectSingleNode("other1").InnerText
            Dim other2 As String = loginNode.SelectSingleNode("other2").InnerText
            Dim other3 As String = loginNode.SelectSingleNode("other3").InnerText
            Dim other4 As String = loginNode.SelectSingleNode("other4").InnerText
            Dim other5 As String = loginNode.SelectSingleNode("other5").InnerText

            'Decrypt info
            userid = Crypto.DecryptString128Bit(userid, keyEncrypted)
            username = Crypto.DecryptString128Bit(username, keyEncrypted)
            password = Crypto.DecryptString128Bit(password, keyEncrypted)
            donvi_id = Crypto.DecryptString128Bit(donvi_id, keyEncrypted)
            ten_donvi = Crypto.DecryptString128Bit(ten_donvi, keyEncrypted)

            'Set info to control
            txtUserName.Text = username
            txtUserPassword.Text = password
            If Not VnsCheck.IsNullGuid(donvi_id) Then
                lookUpDonVi.EditValue = VnsConvert.CGuid(donvi_id)
            End If

            'Add Lock
            'AddLock()
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Write info to XML file and save data
    ''' </summary>
    ''' <param name="userid"></param>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <param name="donvi_id"></param>
    ''' <param name="ten_donvi"></param>
    ''' <param name="other1"></param>
    ''' <param name="other2"></param>
    ''' <param name="other3"></param>
    ''' <param name="other4"></param>
    ''' <param name="other5"></param>
    ''' <remarks></remarks>
    Private Sub WriteInfo(ByVal userid As String, ByVal username As String, ByVal password As String, ByVal donvi_id As String, ByVal ten_donvi As String, ByVal other1 As String, ByVal other2 As String, ByVal other3 As String, ByVal other4 As String, ByVal other5 As String)
        Try
            'Remove Lock
            'RemoveLock()

            'Encrypt info
            userid = Crypto.EncryptString128Bit(userid, keyEncrypted)
            username = Crypto.EncryptString128Bit(username, keyEncrypted)
            password = Crypto.EncryptString128Bit(password, keyEncrypted)
            donvi_id = Crypto.EncryptString128Bit(donvi_id, keyEncrypted)
            ten_donvi = Crypto.EncryptString128Bit(ten_donvi, keyEncrypted)

            'Get Document XML
            Dim doc As XmlDocument = XMLConfig.XmlReader("KTYConfig.xml")
            'Get Root Element : Is element named "config"
            Dim root As XmlElement = doc.DocumentElement
            'Get element named "login_info" include Login information
            Dim loginNode As XmlNode = root.SelectSingleNode("login_info")
            loginNode.SelectSingleNode("userid").InnerText = userid
            loginNode.SelectSingleNode("username").InnerText = username
            loginNode.SelectSingleNode("password").InnerText = password
            loginNode.SelectSingleNode("donvi_id").InnerText = donvi_id
            loginNode.SelectSingleNode("ten_donvi").InnerText = ten_donvi

            'Save info to file
            doc.Save("KTYConfig.xml")

            'Add Lock
            'AddLock()
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Clear info from XML file if user not check to remember
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearInfo()
        Try
            'Get Document XML
            Dim doc As XmlDocument = XMLConfig.XmlReader("KTYConfig.xml")
            'Get Root Element : Is element named "config"
            Dim root As XmlElement = doc.DocumentElement
            'Get element named "login_info" include Login information
            Dim loginNode As XmlNode = root.SelectSingleNode("login_info")
            loginNode.SelectSingleNode("userid").InnerText = ""
            loginNode.SelectSingleNode("username").InnerText = ""
            loginNode.SelectSingleNode("password").InnerText = ""
            loginNode.SelectSingleNode("donvi_id").InnerText = ""
            loginNode.SelectSingleNode("ten_donvi").InnerText = ""
            doc.Save("KTYConfig.xml")
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Add Permission to config file
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddLock()
        Crypto.AddLockFile("KTYConfig.xml")
    End Sub

    ''' <summary>
    ''' Remove Permission from config file
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RemoveLock()
        Crypto.RemoveLockFile("KTYConfig.xml")
    End Sub
#End Region

#Region "Event Handles"

    ''' <summary>
    ''' Cancel from user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub createUser()
        Dim ObjInfo As New AppUsers
        Dim objLast As New AppUsers
        Dim infoDGU As New AppDvGroupUser
        Dim _UserService As IAppUsersService = ObjectFactory.GetObject("AppUsersService")
        Dim GuidcboDonvi As Guid = CType(ComboHelper.GetSelectData(lookUpDonVi), DmDonvi).Id
        'Panel_GetControlValue(grpUserInfo, ObjInfo, "APP_USERS")
        ObjInfo.Userpassword = _UserService.EncryptPassword(Me.txtUserName.Text.Trim, txtUserPassword.Text)
        ObjInfo.Username = "admin_abc"
        ObjInfo.Fullname = "admin_abc"
        ObjInfo.Email = "a@a.com"
        ObjInfo.Tel = "1234567"
        ObjInfo.DonviId = GuidcboDonvi
        ObjInfo.Id = m_UserID
        _UserService.Save(ObjInfo)
    End Sub
    ''' <summary>
    ''' User do login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If Me.txtUserName.Text.Trim = "" Then
                MessageBox.Show(AdminMessage.USERNAME_CAN_NOT_BE_EMPTY, AdminMessage.NOTYFY, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Me.txtUserPassword.Text = "" Then
                MessageBox.Show(AdminMessage.PASSWORD_CAN_NOT_BT_EMPTY, AdminMessage.NOTYFY, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Login() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            DecryptUtil.ReadDataFromFile("License.lic")
            LoadDonVi()
            'Read information from XML Config file
            ReadInfo()
            chkRemember.Checked = True
        Catch ex As Exception
            txtUserName.Text = ""
            txtUserPassword.Text = ""
            chkRemember.Checked = False
            Message_Error(ex)
        End Try

    End Sub

#End Region

End Class