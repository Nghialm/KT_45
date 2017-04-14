Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmDanhMucDonViTinh_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmDvtService As IDmDvtService

    Public Property DmDvtService() As IDmDvtService

        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
        End Set
    End Property


    Public Property ObjectInfo() As DmDvt
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmDvt = New DmDvt()
            If Not ID Is Nothing Then
                info.Id = VnsConvert.CGuid(ID)
            End If

            info.MaDvt = txtMA_DVT.Text
            info.KyHieu = txtKY_HIEU.Text
            info.TenDvt = txtTEN_DVT.Text
            info.MoTa = txtMO_TA.Text

            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.DonviId = Generals.DonviID

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmDvt)
            If Not value Is Nothing Then
                Dim obj As DmDvt = TryCast(value, DmDvt)

                MaCu = txtMA_DVT.Text
                txtMA_DVT.Text = obj.MaDvt
                txtKY_HIEU.Text = obj.KyHieu
                txtTEN_DVT.Text = obj.TenDvt
                txtMO_TA.Text = obj.MoTa
                chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(obj.ChoPhepSua)
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
            End If
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Private MaCu As String
    Public Overrides Sub InitProperty()
        TNCommon.setIconControl(Me)
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục đơn vị tính"

        'Tên b?ng truy v?n trong DB
        TableName = "DM_DVT"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtMA_DVT, txtKY_HIEU, txtTEN_DVT}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Dim _temp As DmDvt
    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case DataInputState.EditMode
                    _temp = DmDvtService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Dim info As DmDvt = CType(ObjectInfo, DmDvt)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = DmDvtService.Save(info).Id
            Case FormGlobals.DataInputState.EditMode
                DmDvtService.SaveOrUpdate(info)
        End Select
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Events"
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        'Dim Ma_DVT1 As String = txtMA_DVT.Text
        'Select Case Mode
        '    Case FormGlobals.DataInputState.AddMode
        '        KiemTraMa(Ma_DVT1, e)

        '    Case FormGlobals.DataInputState.EditMode
        '        If MaCu <> Ma_DVT1 Then
        '            KiemTraMa(Ma_DVT1, e)
        '        End If
        'End Select
    End Sub

    Private Sub KiemTraMa(ByVal Ma_DVT1 As String, ByVal e As CancelEventArgs)
        'Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_DVT", "MA_DVT", Ma_DVT1)
        'If (Not kiemtra) Then
        '    ErrorProvider.SetError(txtMA_DVT, "Mã đã tồn tại")
        '    e.Cancel = True

        'End If
    End Sub
#End Region

End Class
