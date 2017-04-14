Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
'***************************************************************************************
' Author : HoaTV
' Created: 15-Feb-2011
' Purpose: frmChangePassword class containing functions and procedures to work with the UI and BO
' Modification History:
' Date         Author           Description
' -----------  ---------------  ----------------------------------------------------------
' 15-Feb-2011  HoaTV           Create class
'***************************************************************************************
Public Class frmChangePassword
    Private m_InputState As FormGlobals.DataInputState
    Private m_UserID As Guid
    Private m_OldPassword As String = ""
    Private m_Return As DialogResult

    Private _AppUsersService As IAppUsersService
    Public Property AppUsersService As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService
        Get
            Return _AppUsersService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService)
            _AppUsersService = value
        End Set
    End Property
    Public Function ShowForm(ByVal UserID As Guid) As Boolean
        Form_InitDialog(Me)
        m_UserID = UserID '
        Dim list As IList(Of AppUsers) = Me.AppUsersService.List(-1, -1, Nothing, Nothing, Nothing)
        frmProgress.Instance.Thread = AddressOf InitForm
        frmProgress.Instance.Show_Progress()
        Return (ShowDialog() = Windows.Forms.DialogResult.OK)
    End Function

    Private Sub InitForm()
        InitControl()
        Me.txtUserName.Properties.ReadOnly = True
        Me.txtFullName.Properties.ReadOnly = True
        SetUserData()
        m_OldPassword = txtUserPassword.Text
        txtRetype.Text = ""
        txtUserPassword.Text = ""
    End Sub

    Private Sub SetUserData()
        Try
            Dim oUserInfo As AppUsers = _AppUsersService.Get(m_UserID)
            Me.txtUserName.Text = oUserInfo.Username
            Me.txtFullName.Text = oUserInfo.Fullname
            'Panel_SetControlValue(grpUserInfo, oUserInfo)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub InitControl()
        Control_SetFont(Me, CS_FONT_NAME)
        '
        Panel_InitControl(grpUserInfo, "APP_USERS")
        ''
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            If Message_Confirm(ConstantMsgs.MESSAGE_SAVE_CONFIRM) Then
                btnSave.PerformClick()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Control_ClearData(grpUserInfo)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Panel_CheckError(Me.grpUserInfo) Then
                Return
            End If
            If Me.txtUserPassword.Text <> Me.txtRetype.Text Then
                Message_Information("Password and Retype Password must the same value!")
                Return
            End If
            If Not ValidOldPassword() Then
                Message_Information("Old Password not valid!")
                Return
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

    Private Function ValidOldPassword() As Boolean
        Dim sType As String = _AppUsersService.EncryptPassword(Me.txtUserName.Text, Me.txtOldPassword.Text)
        Return sType = m_OldPassword
    End Function

    Private Sub SaveData()
        Try
            Dim ObjInfo As New AppUsers
            Panel_GetControlValue(grpUserInfo, ObjInfo, "APP_USERS")
            ObjInfo.Id = m_UserID

            _AppUsersService.ChangePassword(ObjInfo)
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Sub

    
End Class