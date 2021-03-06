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

Public Class frmKhoaSoThang
#Region "Property"
    Public Property KtKhoasoThangService As IKtKhoasoThangService
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
            BindYear()
            Control_ClearData(GroupControl1)
            SetData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GetData()
        Try
            If cmbYear.EditValue Is Nothing Then
            Else
                Dim objKtKhoaSo1 As KtKhoasoThang = New KtKhoasoThang
                objKtKhoaSo1.Thang1 = TNCommon.ParseDecimal(chkTHANG_1.Checked)
                objKtKhoaSo1.Thang2 = TNCommon.ParseDecimal(chkTHANG_2.Checked)
                objKtKhoaSo1.Thang3 = TNCommon.ParseDecimal(chkTHANG_3.Checked)
                objKtKhoaSo1.Thang4 = TNCommon.ParseDecimal(chkTHANG_4.Checked)
                objKtKhoaSo1.Thang5 = TNCommon.ParseDecimal(chkTHANG_5.Checked)
                objKtKhoaSo1.Thang6 = TNCommon.ParseDecimal(chkTHANG_6.Checked)
                objKtKhoaSo1.Thang7 = TNCommon.ParseDecimal(chkTHANG_7.Checked)
                objKtKhoaSo1.Thang8 = TNCommon.ParseDecimal(chkTHANG_8.Checked)
                objKtKhoaSo1.Thang9 = TNCommon.ParseDecimal(chkTHANG_9.Checked)
                objKtKhoaSo1.Thang10 = TNCommon.ParseDecimal(chkTHANG_10.Checked)
                objKtKhoaSo1.Thang11 = TNCommon.ParseDecimal(chkTHANG_11.Checked)
                objKtKhoaSo1.Thang12 = TNCommon.ParseDecimal(chkTHANG_12.Checked)
                objKtKhoaSo1.Nam = Decimal.Parse(cmbYear.EditValue)
                objKtKhoaSo1.DonviId = Generals.DON_VI.Id
                If objKtKhoaSo Is Nothing Then
                    objKtKhoaSo = New KtKhoasoThang
                Else
                    If VnsCheck.IsNullGuid(objKtKhoaSo.Id) Then
                    Else
                        objKtKhoaSo1.Id = objKtKhoaSo.Id
                    End If
                End If
                'If objKtKhoaSo1.Thang1 = objKtKhoaSo.Thang1 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang1, 1, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang2 = objKtKhoaSo.Thang2 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang2, 2, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang3 = objKtKhoaSo.Thang3 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang3, 3, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang4 = objKtKhoaSo.Thang4 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang4, 4, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang5 = objKtKhoaSo.Thang5 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang5, 5, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang6 = objKtKhoaSo.Thang6 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang6, 6, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang7 = objKtKhoaSo.Thang7 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang7, 7, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang8 = objKtKhoaSo.Thang8 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang8, 8, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang9 = objKtKhoaSo.Thang9 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang9, 9, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang10 = objKtKhoaSo.Thang10 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang10, 10, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang11 = objKtKhoaSo.Thang11 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang11, 11, objKtKhoaSo1.Nam)
                'End If

                'If objKtKhoaSo1.Thang12 = objKtKhoaSo.Thang12 Then
                'Else
                '    KtKhoasoThangService.UpdateKhoaSoThang(Nothing, objKtKhoaSo1.Thang12, 12, objKtKhoaSo1.Nam)
                'End If
                objKtKhoaSo = objKtKhoaSo1

                If VnsCheck.IsNullGuid(objKtKhoaSo1.Id) Then
                    KtKhoasoThangService.Save(objKtKhoaSo1)
                Else
                    KtKhoasoThangService.SaveOrUpdate(objKtKhoaSo1)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub SetData()
        If String.IsNullOrEmpty(cmbYear.EditValue) Then
        Else
            objKtKhoaSo = KtKhoasoThangService.GetByNam(cmbYear.EditValue, Generals.DON_VI.Id)
            If objKtKhoaSo Is Nothing Then
            Else
                chkTHANG_1.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang1)
                chkTHANG_2.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang2)
                chkTHANG_3.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang3)
                chkTHANG_4.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang4)
                chkTHANG_5.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang5)
                chkTHANG_6.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang6)
                chkTHANG_7.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang7)
                chkTHANG_8.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang8)
                chkTHANG_9.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang9)
                chkTHANG_10.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang10)
                chkTHANG_11.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang11)
                chkTHANG_12.Checked = TNCommon.ParseBool(objKtKhoaSo.Thang12)
            End If
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYear.SelectedItem.ToString)
            Control_ClearData(GroupControl1)
            SetData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub BindYear()
        For i As Integer = Generals.Nam_Ke_Toan To 2000 Step -1
            cmbYear.Properties.Items.Add(i)
        Next
        cmbYear.EditValue = Date.Now.Year
        'cmbYear.SelectedIndex = 0
    End Sub

    Private Sub frmKhoaSoThang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class