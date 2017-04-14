Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Public Class frmDanhMucDonVi_ChiTietOnline
    'Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Private _DmDonviService As IDmDonviService
    Private ID As String
    Private Mode As DataInputState
    Private obj As DmDonvi = New DmDonvi()

    Public Property DmDonviService() As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property


#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        ID = Generals.DON_VI.Id.ToString
        Mode = DataInputState.EditMode
    End Sub

    Public Sub New(ByVal p_Id As String, ByVal p_Mode As DataInputState)
        InitializeComponent()
        TNCommon.setIconControl(Me)

        ID = p_Id
        Mode = p_Mode
    End Sub
#End Region

#Region "Load Form"

    Private Sub GetObject()
        obj.TenDonvi = Me.txtTEN_DONVI.Text
        obj.KyHieu = Me.txtKY_HIEU.Text
        obj.DonviIdCha = New Guid(cboDONVI_ID_CHA1.EditValue.ToString())
        obj.NguoiTao = Generals.USER.Id
        obj.NguoiSua = Generals.USER.Id
        obj.BoPhanTt = TNCommon.ParseDecimal(chkBO_PHAN_TT.Checked)
        obj.QuanHuyen = Me.txtQUAN_HUYEN.Text
        obj.NguoiLapBieu = Me.txtNGUOI_LAP_BIEU.Text
        obj.GiamDoc = Me.txtGIAM_DOC.Text
        obj.ThuQuy = Me.txtTHU_QUY.Text
        obj.KtTruong = Me.txtKT_TRUONG.Text
        obj.TinhTp = Me.txtTINH_TP.Text
        obj.DienThoai = Me.txtDIEN_THOAI.Text
        obj.MaSoThue = Me.txtMA_SO_THUE.Text
        obj.Fax = Me.txtFAX.Text
        obj.Email = Me.txtEMAIL.Text
        obj.DiaChi = Me.txtDIA_CHI.Text
        obj.SoTaikhoanNh = Me.txtSO_TAIKHOAN_NH.Text
        obj.TenNganhang = Me.txtTEN_NGANHANG.Text
        obj.DiaChiNh = Me.txtDIA_CHI_NH.Text
    End Sub

    Private Sub SetObject()
        'If Not value Is Nothing Then
        'Dim obj As DmDonvi = TryCast(value, DmDonvi)
        'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
        obj = DmDonviService.GetById(New Guid(ID.ToString()))

        Me.txtDIA_CHI.Text = obj.DiaChi
        Me.txtDIA_CHI_NH.Text = obj.DiaChiNh
        Me.txtDIEN_THOAI.Text = obj.DienThoai
        Me.txtEMAIL.Text = obj.Email
        Me.txtFAX.Text = obj.Fax
        Me.txtKY_HIEU.Text = obj.KyHieu
        Me.txtKT_TRUONG.Text = obj.KtTruong
        Me.txtMA_SO_THUE.Text = obj.MaSoThue
        Me.txtGIAM_DOC.Text = obj.GiamDoc
        Me.txtNGUOI_LAP_BIEU.Text = obj.NguoiLapBieu
        Me.txtTEN_DONVI.Text = obj.TenDonvi
        Me.txtQUAN_HUYEN.Text = obj.QuanHuyen
        Me.txtTINH_TP.Text = obj.TinhTp
        Me.txtTHU_QUY.Text = obj.ThuQuy
        Me.txtKT_TRUONG.Text = obj.KtTruong
        Me.txtGIAM_DOC.Text = obj.GiamDoc
        Me.txtTEN_NGANHANG.Text = obj.TenNganhang
        Me.txtSO_TAIKHOAN_NH.Text = obj.SoTaikhoanNh
        cboDONVI_ID_CHA1.EditValue = obj.DonviIdCha.ToString

        'End If
        'End Set
    End Sub

    Public Sub BindData()
        Try
            SetObject()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Sub Saving()
        Try
            GetObject()
            'Dim info As DmDonvi = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmDonviService.SaveOrUpdate(obj).Id.ToString()

                Case FormGlobals.DataInputState.EditMode
                    ID = DmDonviService.SaveOrUpdate(obj).Id.ToString()
            End Select
            'AfterSaveSuccess()
            'Me.DialogResult = System.Windows.Forms.DialogResult.OK
            'Me.Close()
            Generals.DON_VI = obj
            Message_Information("Lưu dữ liệu thành công")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Private Function and Procedures"

#End Region

#Region "Events"

#End Region

    Private Sub frmDanhMucDonVi_ChiTietOnline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    Saving()
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveData.Click
        Saving()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
