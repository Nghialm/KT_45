Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmKhoaSoNgay
#Region "Property"
    Public Property KtKhoaSoNgayService As IKtKhoaSoNgayService
#End Region
    Dim objKtKhoaSo As KtKhoasoThang = New KtKhoasoThang

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClo.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            If Not Me.ValidateChildren Then Return

            frmProgress.Instance.Thread = AddressOf GetData
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")
            Message_Information("Đã thực hiện thành công!")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmKhoaSoThang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TNCommon.setIconControl(Me)
            Control_ClearData(GroupControl1)
            SetData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GetData()
        Try
            Dim KhoaSoNgay As New KtKhoaSoNgay
            KhoaSoNgay = KtKhoaSoNgayService.GetByDonvi(Generals.DON_VI.Id)

            If (KhoaSoNgay Is Nothing) Then KhoaSoNgay = New KtKhoaSoNgay
            KhoaSoNgay.NgayKhoaSo = txtNewCloseBook.DateTime
            KhoaSoNgay.DonViId = Generals.DON_VI.Id

            If VnsCheck.IsNullGuid(KhoaSoNgay.Id) Then
                KtKhoaSoNgayService.Save(KhoaSoNgay)
            Else
                KtKhoaSoNgayService.SaveOrUpdate(KhoaSoNgay)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub SetData()
        Dim KhoaSoNgay As New KtKhoaSoNgay
        KhoaSoNgay = KtKhoaSoNgayService.GetByDonvi(Generals.DON_VI.Id)

        If KhoaSoNgay Is Nothing Then
            txtLastCloseBook.EditValue = ""
        Else
            txtLastCloseBook.EditValue = KhoaSoNgay.NgayKhoaSo
        End If
        txtNewCloseBook.EditValue = ""
    End Sub


    Private Sub frmKhoaSoThang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNewCloseBook_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewCloseBook.Validating
        If (txtNewCloseBook.Text = "") Then
            DxErrorProvider1.SetError(txtNewCloseBook, "Bạn phải nhập ngày")
            e.Cancel = True
        Else
            DxErrorProvider1.SetError(txtNewCloseBook, "")
            e.Cancel = False
        End If

    End Sub
End Class