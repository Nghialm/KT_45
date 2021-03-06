Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Collections.Generic
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmLS_TyGiaNgoaiTe_ChiTiet
    Inherits FrmBaseDmChiTiet

    Dim _LsTygiaService As ILsTygiaService

    Public Property LsTygiaService() As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(ByVal value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property
    Dim _DmNgoaiteService As IDmNgoaiteService

    Public Property DmNgoaiteService() As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(ByVal value As IDmNgoaiteService)
            _DmNgoaiteService = value
        End Set
    End Property
    Private m_InputState As FormGlobals.DataInputState
    Private _NgoaiTeId As Guid
    Private objLSNTe As LsTygia = New LsTygia()

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal LS_TYGIA_ID As Guid, ByVal eState As DataInputState) As Boolean
        Form_SetText(Me, "Lịch sử ngoại tệ", eState)
        Form_InitDialog(Me)
        m_InputState = eState
        _NgoaiTeId = LS_TYGIA_ID
        Control_SetRequire(dteNgay, True)
        Control_SetRequire(grlNGOAITE_ID, True)
        Control_SetRequire(txtSO_TIEN_QUYDOI, True)
        Control_SetRequire(cboTG, True)
        frmProgress.Instance.Thread = AddressOf Init_Data
        frmProgress.Instance.Show_Progress()
        Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLoookUpNX()
            Case Else
                BindLoookUpNX()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub BindLoookUpNX()
        Dim lstTNT As List(Of DmNgoaite) = DmNgoaiteService.GetAll  '(Generals.DON_VI.DONVI_ID.Replace("-", ""))

        Dim lst_temp As List(Of DmNgoaite) = New List(Of DmNgoaite)
        'Dim noite As DmNgoaite = DmNgoaiteService.GetById(New Guid(Generals.TS_NoiTe_ID.GiaTri))
        Dim lstTHT_temp As List(Of DmNgoaite) = New List(Of DmNgoaite)

        For Each obj As DmNgoaite In lstTNT
            'If obj.TyGia <> Generals.TS_NoiTe_ID.GiaTri Then
            If Not obj.Id.ToString().Equals((Generals.TS_NoiTe_ID.GiaTri)) Then
                lst_temp.Add(obj)
            Else
                lstTHT_temp.Add(obj)
            End If
        Next

        grlNGOAITE_ID.Properties.DisplayMember = "KyHieu"
        grlNGOAITE_ID.Properties.ValueMember = "Id"
        grlNGOAITE_ID.Properties.DataSource = lst_temp
        Dim ColumnDefine As ArrayList = New ArrayList()

        Dim col As ColumnInfo
        'col = New ColumnInfo("Id", "Id", 0, False, "")
        'ColumnDefine.Add(col)Vns.Erp.Core.Admin.Domain.DmNgoaite.MaNte
        col = New ColumnInfo("KyHieu", "Ký hiệu", 0, False, "")
        ColumnDefine.Add(col)
        col = New ColumnInfo("MaNte", "Mã ngoại tệ", 0, False, "")
        ColumnDefine.Add(col)

        TNCommon.BindData_GridLookUp(grlNGOAITE_ID, lst_temp, "KyHieu", "Id", ColumnDefine, True, False)


        If lst_temp.Count <> 0 Then
            TNCommon.SelectFirst(grlNGOAITE_ID)
        End If
        'cboTG.Properties.DisplayMember = "KyHieu"
        'cboTG.Properties.ValueMember = "Id"
        'cboTG.Properties.DataSource = lstTHT_temp

        TNCommon.BindData_GridLookUp(cboTG, lstTHT_temp, "KyHieu", "Id", ColumnDefine, True, False)
        If lstTHT_temp.Count <> 0 Then
            TNCommon.SelectFirst(cboTG)
        End If
    End Sub

    Private Sub GetControlToOBject()
        Dim drNte As DmNgoaite = CType(ComboHelper.GetSelectData(grlNGOAITE_ID), DmNgoaite)
        If drNte IsNot Nothing Then
            objLSNTe.NgoaiteId = drNte.Id
            objLSNTe.TenNgoaite = drNte.TenNte
            objLSNTe.NgoaiteHtId = drNte.Id
        End If
        Dim drNteHT As DmNgoaite = CType(ComboHelper.GetSelectData(cboTG), DmNgoaite)
        If drNteHT IsNot Nothing Then
            objLSNTe.TenNgoaiteHt = drNteHT.KyHieu
            objLSNTe.NgoaiteHtId = drNteHT.Id
        End If

        objLSNTe.NgayQuydoi = dteNgay.DateTime
        objLSNTe.SoTienQuydoi = Decimal.Parse(txtSO_TIEN_QUYDOI.Text)

        Select Case m_InputState
            Case DataInputState.AddMode
                objLSNTe = InsertLS_Nte(objLSNTe)
            Case Else
                UpdateLS_Nte(objLSNTe)
        End Select

    End Sub

    Private Function Check_input() As Boolean
        If DB_GetString(DB_GetNull(dteNgay.DateTime)) = "" Then
            Message_Warning("Bạn chưa nhập ngày quy đổi!")
            dteNgay.Focus()
            Return False
        End If

        If DB_GetString(grlNGOAITE_ID.EditValue) = "" Then
            Message_Warning("Bạn chưa chọn ngoại tệ!")
            grlNGOAITE_ID.Focus()
            Return False
        End If

        If DB_GetString(cboTG.EditValue) = "" Then
            Message_Warning("Bạn chưa chọn tiền hoạch toán!")
            cboTG.Focus()
            Return False
        End If

        If txtSO_TIEN_QUYDOI.Text = "" Then
            Message_Warning("Bạn chưa nhập số tiền quy đổi!")
            txtSO_TIEN_QUYDOI.Focus()
            Return False
        End If

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtSO_TIEN_QUYDOI.Text)) Then
            Message_Warning("Giá trị số tiền quy đổi không hợp lệ!")
            txtSO_TIEN_QUYDOI.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub SetObjectToControl()
        objLSNTe = LsTygiaService.GetById(_NgoaiTeId)
        grlNGOAITE_ID.EditValue = objLSNTe.NgoaiteId
        'grlNGOAITE_ID.EditValue = objLSNTe.NGOAITE_HT_ID
        dteNgay.DateTime = objLSNTe.NgayQuydoi
        txtSO_TIEN_QUYDOI.Text = objLSNTe.SoTienQuydoi.ToString()
        cboTG.EditValue = objLSNTe.NgoaiteHtId
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_input() Then
                Return
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Đã lưu dữ liệu")
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function InsertLS_Nte(ByVal _objLS_TyGia As LsTygia) As LsTygia
        Return LsTygiaService.Save(_objLS_TyGia)
    End Function

    Private Sub UpdateLS_Nte(ByVal _objLS_TyGia As LsTygia)
        LsTygiaService.SaveOrUpdate(_objLS_TyGia)
    End Sub

    Private Sub frmLS_TyGiaNgoaiTe_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
