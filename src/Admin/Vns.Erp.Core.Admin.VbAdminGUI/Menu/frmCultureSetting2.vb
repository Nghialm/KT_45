Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmCultureSetting2
    Dim objData As CultureManagement

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        objData = New CultureManagement()
    End Sub

    Private Sub frmCultureSetting2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindToControl()
            InitForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCode.SelectedIndexChanged
        Try
            If cboCode.SelectedIndex = 0 Then
                lblCode.Text = "vi-VN"
            ElseIf cboCode.SelectedIndex = 1 Then
                lblCode.Text = "en-US"
            ElseIf cboCode.SelectedIndex = 2 Then
                lblCode.Text = "fr-FR"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub InitForm()
        If cboCode.Properties.Items.Count > 0 Then
            If cboCode.SelectedIndex >= 0 Then
                If cboCode.SelectedIndex = 0 Then
                    lblCode.Text = "vi-VN"
                ElseIf cboCode.SelectedIndex = 1 Then
                    lblCode.Text = "en-US"
                ElseIf cboCode.SelectedIndex = 2 Then
                    lblCode.Text = "fr-FR"
                End If
            End If
        Else
            lblCode.Text = ""
        End If
    End Sub

    Private Sub BindToControl()
        Dim info As CultureSettingInfo = objData.GetInfo_2()
        txtName.Text = info.Name
        If info.Code.Equals("vi-VN") Then
            cboCode.SelectedIndex = 0
        ElseIf info.Code.Equals("en-US") Then
            cboCode.SelectedIndex = 1
        ElseIf info.Code.Equals("fr-FR") Then
            cboCode.SelectedIndex = 2
        End If
        cboDateFormat.EditValue = info.DateFormat
        cboDateSeparator.EditValue = info.DateSeparator
        cboTimeFormat.EditValue = info.TimeFormat
        cboTimeSeparator.EditValue = info.TimeSeparator
        cboGroupSeparator.EditValue = info.GroupSeparator
        cboDecimalSeparator.EditValue = info.DecimalSeparator
    End Sub

    Private Function GetInfo() As CultureSettingInfo
        Dim info As New CultureSettingInfo
        info.Name = txtName.Text
        info.Code = lblCode.Text
        info.DateFormat = cboDateFormat.EditValue.ToString
        info.DateSeparator = cboDateSeparator.EditValue.ToString
        info.TimeFormat = cboTimeFormat.EditValue.ToString
        info.TimeSeparator = cboTimeSeparator.EditValue.ToString
        info.DecimalSeparator = cboDecimalSeparator.EditValue.ToString
        info.GroupSeparator = cboGroupSeparator.EditValue.ToString
        info.CalendarLanguage = lblCode.Text
        info.Extend1 = ""
        info.Extend2 = ""
        info.Extend3 = ""
        info.Extend4 = ""
        info.Extend5 = ""
        info.Extend6 = ""
        info.Extend7 = ""
        info.Extend8 = ""
        info.Extend9 = ""
        info.Extend10 = ""
        Return info
    End Function

    Private Function CheckSave() As Boolean
        Dim bReturn As Boolean = True
        If cboDecimalSeparator.EditValue.ToString.Equals(cboGroupSeparator.EditValue.ToString) Then
            bReturn = False
        End If
        If txtName.Text.Equals("") Then
            bReturn = False
        End If
        Return bReturn
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If CheckSave() Then
                If objData.Update_2(GetInfo()) Then
                    Message_Information("Hệ thống sẽ khởi động lại để thiết lập có hiệu lực.")
                    Application.Restart()
                End If
            Else
                Dim str As String = "Thông tin không hợp lệ !" + vbNewLine
                str = str + vbTab + " - Hoặc tên để trống" + vbNewLine
                str = str + vbTab + " - Hoặc ký tự phân cách phần nghìn trùng với ký tự phân cách phần thập phân" + vbNewLine
                Message_Information(str)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmCultureSetting2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class