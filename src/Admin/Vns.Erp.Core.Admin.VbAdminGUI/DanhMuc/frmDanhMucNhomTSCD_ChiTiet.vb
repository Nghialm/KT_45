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

Public Class frmDanhMucNhomTSCD_ChiTiet
    Inherits FrmBaseDmChiTiet
    Dim _DmNhomTscdService As IDmNhomTscdService
    Public Property DmNhomTscdService() As IDmNhomTscdService
        Get
            Return _DmNhomTscdService
        End Get
        Set(ByVal value As IDmNhomTscdService)
            _DmNhomTscdService = value
        End Set
    End Property
    Private objDM_NHOM_TSCD As DmNhomTscd = New DmNhomTscd()
    Private m_InputState As FormGlobals.DataInputState
    Private m_NHOM_TSCD As String
    Private p_MaNhom_TSCD As String

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal NHOM_TSCD_ID As String, ByVal eState As DataInputState) As DmNhomTscd
        Try
            Form_InitDialog(Me)
            m_InputState = eState
            m_NHOM_TSCD = NHOM_TSCD_ID
            If (eState = DataInputState.AddMode) Then
                Me.txtLOAI_NHOM.Text = ""
                Me.txtMA_NHOM_TSCD.Text = ""
                Me.txtTEN_NHOM_TSCD.Text = ""
                m_NHOM_TSCD = Guid.NewGuid().ToString
            End If
            'Panel_InitControl(pnNHOM_TSCD, "DM_NHOM_TSCD")
            Control_SetRequire(txtLOAI_NHOM, True)
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If Me.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return objDM_NHOM_TSCD
        Else
            Return Nothing
        End If
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.EditMode
                SetObjectToControl()
        End Select
    End Sub

    Private Sub GetControlToObject()
        'Panel_GetControlValue(pnNHOM_TSCD, objDM_NHOM_TSCD)
        Select Case m_InputState
            Case DataInputState.AddMode
                objDM_NHOM_TSCD = New DmNhomTscd()
                objDM_NHOM_TSCD.Id = Guid.Empty
                objDM_NHOM_TSCD.NguoiTao = Generals.USER.Id
                objDM_NHOM_TSCD.NgayTao = DateTime.Now
                objDM_NHOM_TSCD.NgaySua = DateTime.Now
            Case DataInputState.EditMode
                objDM_NHOM_TSCD.NguoiSua = Generals.USER.Id
                objDM_NHOM_TSCD.NgaySua = DateTime.Now
        End Select
        objDM_NHOM_TSCD.MaNhomTscd = Me.txtMA_NHOM_TSCD.Text
        objDM_NHOM_TSCD.LoaiNhom = Double.Parse(Me.txtLOAI_NHOM.Text)
        objDM_NHOM_TSCD.TenNhomTscd = Me.txtTEN_NHOM_TSCD.Text
        objDM_NHOM_TSCD.DonviId = Generals.DON_VI.Id
        DmNhomTscdService.SaveOrUpdate(objDM_NHOM_TSCD)
    End Sub

    Private Sub SetObjectToControl()
        objDM_NHOM_TSCD = DmNhomTscdService.GetById(New Guid(m_NHOM_TSCD))
        p_MaNhom_TSCD = objDM_NHOM_TSCD.MaNhomTscd
        Me.txtLOAI_NHOM.Text = objDM_NHOM_TSCD.LoaiNhom
        Me.txtMA_NHOM_TSCD.Text = objDM_NHOM_TSCD.MaNhomTscd
        Me.txtTEN_NHOM_TSCD.Text = objDM_NHOM_TSCD.TenNhomTscd
        'Panel_SetControlValue(pnNHOM_TSCD, objDM_NHOM_TSCD)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim ma_Nhom_tscd As String = ""
            Select Case m_InputState
                Case DataInputState.AddMode
                    ma_Nhom_tscd = txtMA_NHOM_TSCD.Text
                Case DataInputState.EditMode
                    If Not p_MaNhom_TSCD.Equals(txtMA_NHOM_TSCD.Text) Then
                        ma_Nhom_tscd = txtMA_NHOM_TSCD.Text
                    Else
                        ma_Nhom_tscd = ""
                    End If
            End Select

            If txtMA_NHOM_TSCD.Text.Trim = "" Then
                Message_Warning("Bạn chưa nhập mã nhóm TSCD")
                txtMA_NHOM_TSCD.Focus()
                Return
            End If

            If txtTEN_NHOM_TSCD.Text.Trim = "" Then
                Message_Warning("Bạn chưa nhập tên nhóm TSCD")
                txtTEN_NHOM_TSCD.Focus()
                Return
            End If
            If txtLOAI_NHOM.Text = "" Then
                Message_Warning("Bạn chưa nhập loại nhóm TSCD")
                txtLOAI_NHOM.Focus()

                Return
            End If

            If (Panel_CheckError(pnNHOM_TSCD) And CheckMa(ma_Nhom_tscd)) Then
                frmProgress.Instance.Thread = AddressOf GetControlToObject
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Date saved")
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnXoaTrang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaTrang.Click
        Try
            txtLOAI_NHOM.Text = String.Empty
            txtTEN_NHOM_TSCD.Text = String.Empty
            txtMA_NHOM_TSCD.Text = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function CheckMa(ByVal Ma_nhom As String) As Boolean
        Try
            Dim dt As IList(Of DmNhomTscd) = DmNhomTscdService.GetMA_NHOM_TSCD(Ma_nhom)
            If (dt.Count <> 0) Then
                Message_Information("Mã nhóm tài khoản đã tồn tại!")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Function

End Class
