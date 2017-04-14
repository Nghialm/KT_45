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

Public Class frmDanhMucNhomKhachHang_ChiTiet
    Inherits FrmBaseDmChiTiet
    Private objDMNKH As DmNhomKhang = New DmNhomKhang()
    Private objDMNKHBO As IDmNhomKhangService
    Private m_InputState As FormGlobals.DataInputState
    Private m_nkh As String
    Private Ma As String
    Public Property DmNhomKhangService() As IDmNhomKhangService
        Get
            Return objDMNKHBO
        End Get
        Set(ByVal value As IDmNhomKhangService)
            objDMNKHBO = value
        End Set
    End Property

    Public Sub New()
        Try
            InitializeComponent()
            TNCommon.setIconControl(Me)

            Control_SetRequire(txtKY_HIEU, True)
            Control_SetRequire(txtMA_NHOM_KHANG, True)
            Control_SetRequire(txtTEN_NHOM_KHANG, True)
            Control_SetRequire(txtLOAI, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Function Show_Form(ByVal DMNKHID As String, ByVal eState As DataInputState) As Boolean
        Form_SetText(Me, "Danh mục nhóm khách hàng", eState)
        Form_InitDialog(Me)
        Control_SetRequire(txtMA_NHOM_KHANG, True)
        Control_SetRequire(txtTEN_NHOM_KHANG, True)
        Control_SetRequire(txtLOAI, True)
        Control_SetRequire(txtKY_HIEU, True)

        m_InputState = eState
        m_nkh = DMNKHID
        frmProgress.Instance.Thread = AddressOf Init_Data
        frmProgress.Instance.Show_Progress()
        Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                ' BindLookUpNX()
                ClearField()
            Case Else
                'BindLookUpNX()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub GetControlToObject()
        'lấy dữ liệu từ nhiều bảng
        objDMNKH.Loai = CType(txtLOAI.Text.ToString(), Integer)
        If (objDMNKH.Loai = 1 Or objDMNKH.Loai = 2 Or objDMNKH.Loai = 3) Then
            objDMNKH.MaNhomKhang = txtMA_NHOM_KHANG.Text
            objDMNKH.KyHieu = txtKY_HIEU.Text
            objDMNKH.TenNhomKhang = txtTEN_NHOM_KHANG.Text
            objDMNKH.DonviId = Generals.DON_VI.Id
            objDMNKH.MaDonvi = Generals.DON_VI.MaDonvi
            objDMNKH.NguoiTao = Generals.USER.Id
            objDMNKH.NguoiSua = Generals.USER.Id
        Else
            MessageBox.Show("Bạn phải nhập sai giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        'su lý insert, update
        Select Case m_InputState
            Case DataInputState.AddMode
                InsertDM_NhomKH(objDMNKH)
            Case Else
                UpdateDM_NhomKH(objDMNKH)
        End Select
    End Sub

    Private Function InsertDM_NhomKH(ByVal _objDMNKH As DmNhomKhang) As DmNhomKhang
        Return DmNhomKhangService.Save(_objDMNKH)
    End Function

    Private Sub UpdateDM_NhomKH(ByVal _objDMNKH As DmNhomKhang)
        DmNhomKhangService.SaveOrUpdate(_objDMNKH)
    End Sub

    Private Sub SetObjectToControl()
        objDMNKH = DmNhomKhangService.GetById(New Guid(m_nkh))
        txtLOAI.Text = CType(objDMNKH.Loai, String)
        objDMNKH = DmNhomKhangService.GetById(New Guid(m_nkh))
        txtKY_HIEU.Text = objDMNKH.KyHieu
        txtTEN_NHOM_KHANG.Text = objDMNKH.TenNhomKhang
        txtMA_NHOM_KHANG.Text = objDMNKH.MaNhomKhang
        Ma = txtMA_NHOM_KHANG.Text
        'txtLOAI.Text = CType(objDMNKH.LOAI, String)
    End Sub

    Private Function checkMa() As Boolean
        Dim bo As Boolean = True
        Dim lst As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectByMa(txtMA_NHOM_KHANG.Text.Trim)

        If lst.Count <> 0 Then
            bo = False
        End If
        Return bo
    End Function
    Private Sub ClearField()
        txtMA_NHOM_KHANG.Text = Nothing
        txtKY_HIEU.Text = Nothing
        txtTEN_NHOM_KHANG.Text = Nothing
        txtLOAI.Text = Nothing
    End Sub
    Private Sub btnXoaTrang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'txtMA_NHOM_KHANG.Text = Nothing
            'txtKY_HIEU.Text = Nothing
            'txtTEN_NHOM_KHANG.Text = Nothing
            'txtLOAI.Text = Nothing
            ClearField()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            depDM_NKH.ClearErrors()
            If Not ValidateChildren(ValidationConstraints.Enabled) Then
                Return
            End If

            If txtMA_NHOM_KHANG.Text = "" Then
                Message_Warning("Bạn chưa nhập mã nhóm khách hàng")
                txtMA_NHOM_KHANG.Focus()
                Exit Sub
            End If

            If txtKY_HIEU.Text = "" Then
                Message_Warning("Bạn chưa nhập ký hiệu!")
                txtKY_HIEU.Focus()
                Exit Sub
            End If

            If txtTEN_NHOM_KHANG.Text = "" Then
                Message_Warning("Bạn chưa nhập tên nhóm khách hàng")
                txtTEN_NHOM_KHANG.Focus()
                Exit Sub
            End If

            If txtLOAI.Text = "" Then
                Message_Warning("Bạn chưa nhập loại nhóm khách hàng")
                txtLOAI.Focus()
                Exit Sub
            End If

            If m_InputState = DataInputState.AddMode Then
                If Not checkMa() Then
                    Message_Warning("Mã nhóm khách hàng này đã tồn tại")
                    txtMA_NHOM_KHANG.Focus()
                    Exit Sub
                End If
            Else
                If Not Ma.Equals("") And Not Ma.Equals(txtMA_NHOM_KHANG.Text) And Not checkMa() Then
                    Message_Warning("Mã nhóm khách hàng này đã tồn tại")
                    txtMA_NHOM_KHANG.Focus()
                    Exit Sub
                End If
            End If

            If (txtLOAI.Text.ToString() = "1" Or txtLOAI.Text.ToString() = "2" Or txtLOAI.Text.ToString() = "3") Then
                frmProgress.Instance.Thread = AddressOf GetControlToObject
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Date saved")
                DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Bạn nhập sai giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
