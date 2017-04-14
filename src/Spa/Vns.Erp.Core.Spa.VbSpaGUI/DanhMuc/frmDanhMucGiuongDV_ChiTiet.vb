Imports Vns.Erp.Core.Spa.Domain
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports Vns.Erp.Core
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports Vns.Erp.Core.Spa.Service.Interface

Public Class frmDanhMucGiuongDV_ChiTiet
    Inherits FrmBaseDmChiTiet

    Private _SpaDmGuongdvService As ISpaDmGuongdvService
    Public Property SpaDmGuongdvService() As ISpaDmGuongdvService
        Get
            Return _SpaDmGuongdvService
        End Get
        Set(ByVal value As ISpaDmGuongdvService)
            _SpaDmGuongdvService = value
        End Set
    End Property


#Region "Variables and Messages"

    Private MaCu As String

    Public Property ObjectInfo() As SpaDmGuongdv
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As SpaDmGuongdv = New SpaDmGuongdv()
            If Not ID Is Nothing Then
                info.Id = VnsConvert.CGuid(ID)
            End If

            info.Ma = txtMa.Text
            info.Kyhieu = txtKH.Text
            info.Mota = txtMota.Text
            info.Ten = txtTenGiuong.Text

            info.Cosudung = 1
            info.Donviid = Generals.DON_VI.Id

            info.Nguoitao = Generals.USER.Id
            info.Ngaytao = Date.Now
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As SpaDmGuongdv)
            If Not value Is Nothing Then
                Dim obj As SpaDmGuongdv = TryCast(value, SpaDmGuongdv)

                MaCu = txtMa.Text
                txtMa.Text = obj.Ma
                txtKH.Text = obj.Kyhieu
                txtMota.Text = obj.Mota
                txtTenGiuong.Text = obj.Ten

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
    Public Overrides Function GetEditObject() As Object
        Return ObjectInfo()
    End Function

    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục thẻ"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtMa, txtKH, txtTenGiuong}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Dim _temp As SpaDmGuongdv
    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case DataInputState.EditMode
                    _temp = _SpaDmGuongdvService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Dim info As SpaDmGuongdv = CType(ObjectInfo, SpaDmGuongdv)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = _SpaDmGuongdvService.Save(info).Id
            Case FormGlobals.DataInputState.EditMode
                _SpaDmGuongdvService.SaveOrUpdate(info)
        End Select
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Events"
    Private Sub KiemTraMa(ByVal Ma_DVT1 As String, ByVal e As CancelEventArgs)
        'Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_DVT", "MA_DVT", Ma_DVT1)
        'If (Not kiemtra) Then
        '    ErrorProvider.SetError(txtMA_DVT, "Mã đã tồn tại")
        '    e.Cancel = True

        'End If
    End Sub
#End Region

End Class