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


Public Class frmDanhMucNhomVatTu1_ChiTiet
    Inherits FrmBaseDmChiTiet
    Private objDMNVT1 As DmNhomvattu1 = New DmNhomvattu1()


    Private m_InputState As FormGlobals.DataInputState
    Private m_nvt1 As String
    Dim _DmNhomvattu1Service As IDmNhomvattu1Service
    Public Property DmNhomvattu1Service() As IDmNhomvattu1Service
        Get
            Return _DmNhomvattu1Service
        End Get
        Set(ByVal value As IDmNhomvattu1Service)
            _DmNhomvattu1Service = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal ID_NHOM_VT_1 As String, ByVal eState As DataInputState) As Boolean
        Try
            Form_SetText(Me, "Danh mục nhóm vật tư/hàng hóa", eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_nvt1 = ID_NHOM_VT_1
            Control_SetRequire(txtMA_NHOM_VT_1, True)
            Control_SetRequire(txtTEN_NHOM_VT_1, True)
            Control_SetRequire(txtLOAI, True)
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
            Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                ' BindLookUpNX()
                ClearObjectToControl()
            Case Else
                'Reset Field Here

                SetObjectToControl()
        End Select
    End Sub

    Private Sub GetControlToObject()
        'lấy dữ liệu từ nhiều bảng
        objDMNVT1.LoaiNhom = CType(txtLOAI.Text.ToString(), Integer)
        objDMNVT1.MaNhomVt1 = txtMA_NHOM_VT_1.Text
        objDMNVT1.TenNhomVt1 = txtTEN_NHOM_VT_1.Text
        objDMNVT1.DonviId = Generals.DON_VI.Id
        objDMNVT1.CoSuDung = TNCommon.ParseDecimal(ckbCO_SU_DUNG.Checked)
        objDMNVT1.ChoPhepSua = TNCommon.ParseDecimal(ckbCHO_PHEP_SUA.Checked)
        objDMNVT1.MaDonvi = Generals.DON_VI.MaDonvi
        objDMNVT1.NguoiTao = Generals.USER.Id
        objDMNVT1.NguoiSua = Generals.USER.Id
        'su lý insert, update
        Select Case m_InputState
            Case DataInputState.AddMode
                InsertDM_NhomVT1(objDMNVT1)
            Case Else
                UpdateDM_NhomVT1(objDMNVT1)
        End Select

    End Sub
    Private Ma_VT_Old As String
    Private Sub SetObjectToControl()
        objDMNVT1 = DmNhomvattu1Service.GetById(New Guid(m_nvt1))
        txtMA_NHOM_VT_1.Text = objDMNVT1.MaNhomVt1
        txtTEN_NHOM_VT_1.Text = objDMNVT1.TenNhomVt1
        txtLOAI.Text = CType(objDMNVT1.LoaiNhom, String)
        ckbCO_SU_DUNG.Checked = TNCommon.ParseBool(objDMNVT1.CoSuDung)
        ckbCHO_PHEP_SUA.Checked = TNCommon.ParseBool(objDMNVT1.ChoPhepSua)
        Ma_VT_Old = objDMNVT1.MaNhomVt1
    End Sub
    Private Sub ClearObjectToControl()
        m_nvt1 = ""
        txtMA_NHOM_VT_1.Text = ""
        txtTEN_NHOM_VT_1.Text = ""
        txtLOAI.Text = ""
        ckbCO_SU_DUNG.Checked = False
        ckbCHO_PHEP_SUA.Checked = False
    End Sub
    Private Function Check_ma() As Boolean
        Dim Ma_VT_New As String = ""
        Select Case m_InputState
            Case DataInputState.AddMode
                Ma_VT_New = txtMA_NHOM_VT_1.Text.Trim
            Case DataInputState.EditMode
                If Ma_VT_Old.Trim <> txtMA_NHOM_VT_1.Text.Trim Then
                    Ma_VT_New = txtMA_NHOM_VT_1.Text.Trim
                End If
        End Select

        Dim dt As IList(Of DmNhomvattu1) = DmNhomvattu1Service.GetByMaNhomVT(Ma_VT_New, Generals.DON_VI.Id)
        If dt.Count <> 0 Then
            Message_Warning("Mã nhóm vật tư này đã tồn tại!")
            Return False
        End If

        Return True
    End Function

    Private Function InsertDM_NhomVT1(ByVal _objDMNhomVT1 As DmNhomvattu1) As DmNhomvattu1
        _objDMNhomVT1.Id = Guid.NewGuid()
        Return DmNhomvattu1Service.Save(_objDMNhomVT1)
    End Function

    Private Sub UpdateDM_NhomVT1(ByVal _objDMNhomVT1 As DmNhomvattu1)
        Try
            DmNhomvattu1Service.SaveOrUpdate(_objDMNhomVT1)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function Check_input() As Boolean
        If txtMA_NHOM_VT_1.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập mã nhóm vật tư!")
            txtMA_NHOM_VT_1.Focus()
            Return False
        End If

        If txtTEN_NHOM_VT_1.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập tên nhóm vật tư!")
            txtTEN_NHOM_VT_1.Focus()
            Return False
        End If

        If txtLOAI.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập loại nhóm vật tư!")
            txtLOAI.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_input() Then
                Return
            End If

            If Not Check_ma() Then
                Return
            End If
            depDM_NVT1.ClearErrors()
            If Not ValidateChildren(ValidationConstraints.Enabled) Then
                Return
            End If
            frmProgress.Instance.Thread = AddressOf GetControlToObject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Date saved")
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnXoaTrang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaTrang.Click
        Try
            txtMA_NHOM_VT_1.Text = Nothing
            txtTEN_NHOM_VT_1.Text = Nothing
            ckbCO_SU_DUNG.CheckState = CheckState.Unchecked
            ckbCHO_PHEP_SUA.CheckState = CheckState.Unchecked
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
