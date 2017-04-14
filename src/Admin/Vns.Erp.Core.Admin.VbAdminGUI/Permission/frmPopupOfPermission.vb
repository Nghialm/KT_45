Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmPopupOfPermission
#Region "Variables"
    Dim bo_user_group As IAppGroupsService
    Public Property AppGroupsService
        Get
            Return bo_user_group
        End Get
        Set(ByVal value)
            bo_user_group = value
        End Set
    End Property
#End Region

    Private Sub frmPopupOfPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            bo_user_group.SaveOrUpdate(New AppGroups(New Guid(txtID.Text), txtName.Text))
            frmPermission.CommonInfo.user_group_name = txtName.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch
        End Try
    End Sub
End Class