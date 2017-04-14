Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core
Public Class frmDanhMucThe_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "property"
    Private MaCu As String

    Public Property SpaDmTheService As ISpaDmTheService
    Public Property SpaDmDichVuService As ISpaDmDichVuService

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Public Property ObjectInfo() As SpaDmThe
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As SpaDmThe = New SpaDmThe()
            If Not ID Is Nothing Then
                info.Id = VnsConvert.CGuid(ID)
            End If
            info.Ma = txtMa.Text
            info.Ten = txtTenThe.Text
            info.Kyhieu = txtKyHieu.Text
            info.Mota = txtMota.Text
            info.Menhgia = Decimal.Parse(txtMenhGia.Text)
            info.Giatien = Decimal.Parse(txtGiaTien.Text)
            info.Sotienconlai = info.Giatien
            info.Ngayphathanh = dteNgayPH.DateTime
            info.Ngayban = dteNgayBan.DateTime
            info.Ngayhethan = dteNgayHH.DateTime
            info.Sobuoi = Integer.Parse(txtSoBuoi.Text)

            If Not String.IsNullOrEmpty(cboLoaiDV.EditValue.ToString) Then
                info.Loaidichvuid = VnsConvert.CGuid(cboLoaiDV.EditValue)
            End If

            info.Dasudung = TNCommon.ParseDecimal(ckeCSD.Checked)
            info.Dakhoa = TNCommon.ParseDecimal(ckeKhoaThe.Checked)
            info.Dahethan = TNCommon.ParseDecimal(CkeHetHan.Checked)

            If Not String.IsNullOrEmpty(cFilterKhachHang.Tag.ToString) Then
                info.Khachhangid = New Guid(cFilterKhachHang.Tag.ToString)
                info.Tenkhachhang = txtTenKhach.Text
                info.Diachi = txtDiaChi.Text
                info.Sodienthoai = txtSDT.Text
            End If

            info.Nguoitao = Generals.USER.Id
            info.Ngaytao = Date.Now

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As SpaDmThe)
            If Not value Is Nothing Then
                Dim obj As SpaDmThe = TryCast(value, SpaDmThe)

                txtMa.Text = obj.Ma
                txtTenThe.Text = obj.Ten
                txtKyHieu.Text = obj.Kyhieu
                txtMota.Text = obj.Mota
                txtMenhGia.Text = obj.Menhgia.ToString
                txtGiaTien.Text = obj.Giatien.ToString
                dteNgayPH.DateTime = obj.Ngayphathanh
                dteNgayBan.DateTime = obj.Ngayban
                dteNgayHH.DateTime = obj.Ngayhethan
                txtSoBuoi.Text = obj.Sobuoi.ToString
                cboLoaiDV.EditValue = obj.Loaidichvuid

                ckeCSD.Checked = TNCommon.ParseBool(obj.Dasudung)
                CkeHetHan.Checked = TNCommon.ParseBool(obj.Dahethan)
                ckeKhoaThe.Checked = TNCommon.ParseBool(obj.Dakhoa)

                Dim objKhachhang As DmKhang = _DmKhangService.GetById(obj.Khachhangid)

                If objKhachhang IsNot Nothing Then
                    cFilterKhachHang.Text = objKhachhang.KyHieu
                End If

                cFilterKhachHang.Tag = obj.Khachhangid
                txtTenKhach.Text = obj.Tenkhachhang
                txtDiaChi.Text = obj.Diachi
                txtSDT.Text = obj.Sodienthoai
            End If
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Custom filter"
    Private Sub cFilterKhachHang_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.AfterFilter
        Try
            txtTenKhach.Text = cFilterKhachHang.ListEditValue(1)
            txtDiaChi.Text = cFilterKhachHang.ListEditValue(5)
            txtSDT.Text = cFilterKhachHang.ListEditValue(6)
            cFilterKhachHang.Tag = cFilterKhachHang.ListEditValue(0)
            If cFilterKhachHang.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterKhachHang_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.FirstBinddata, cFilterKhachHang.AfterQuickAdd
        Try
            cFilterKhachHang.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterKhachHang_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.ClearFilterData
        Try
            txtTenKhach.Text = ""
            txtDiaChi.Text = ""
            txtSDT.Text = ""
            cFilterKhachHang.Tag = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Load Form"
    Public Overrides Sub BindLookUpEdit()

        '    'Bind Khach hang
        '    Dim lstKh As IList(Of DmKhang) = _DmKhangService.GetAllByDonviID(Generals.DonviID)
        '    Dim objDmKhachhang As DmKhang = New DmKhang
        '    Dim lstDmKh_temp As List(Of DmKhang) = New List(Of DmKhang)
        '    lstDmKh_temp.Add(objDmKhachhang)
        '    lstDmKh_temp.AddRange(lstKh)
        '    cboMaKhach.Properties.DataSource = lstDmKh_temp
        '    cboMaKhach.Properties.ValueMember = "Id"
        '    cboMaKhach.Properties.DisplayMember = "KyHieu"

        '    'Bind Loai Dich vu
        Dim lstLoaiDichVu As List(Of SpaDmDichVu) = New List(Of SpaDmDichVu)
        lstLoaiDichVu.Add(New SpaDmDichVu)
        lstLoaiDichVu.AddRange(SpaDmDichVuService.GetAllByDonviID(Generals.DonviID))
        cboLoaiDV.Properties.DataSource = lstLoaiDichVu
        cboLoaiDV.Properties.DisplayMember = "Ma"
        cboLoaiDV.Properties.ValueMember = "Id"

    End Sub

    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục thẻ"

        'Tên b?ng truy v?n trong DB
        'TableName = "DM_DVT"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        'RequireInputControls = New Control() {txtMa, txtKyHieu, txtTenThe, txtMenhGia, txtGiaTien, txtSoBuoi, cboLoaiDV, cboMaKhach}
        RequireInputControls = New Control() {txtMa, txtTenThe, txtMenhGia, txtGiaTien, txtSoBuoi}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        txtTenKhach.Properties.ReadOnly = True
        txtDiaChi.Properties.ReadOnly = True
        txtSDT.Properties.ReadOnly = True
    End Sub

    Dim _temp As SpaDmThe
    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case DataInputState.EditMode
                    _temp = SpaDmTheService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Dim info As SpaDmThe = CType(ObjectInfo, SpaDmThe)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = SpaDmTheService.SaveWithHis(True, info).Id
            Case FormGlobals.DataInputState.EditMode
                SpaDmTheService.SaveWithHis(False, info)
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