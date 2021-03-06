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


Partial Public Class frmDanhMucKhachHang_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmKhangService As IDmKhangService
    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Dim _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property

    Public Property DmTaikhoanService As IDmTaikhoanService

    Private objDMKH As DmKhang = New DmKhang()
    Private KH_Old As String = ""

    Public Property DmNhomKhangService As IDmNhomKhangService

    Private IsLoadData As Boolean = False
    Public Property ObjectInfo() As DmKhang
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmKhang = New DmKhang()
            If Not ID Is Nothing Then
                info.Id = ID
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.KyHieu = txtKY_HIEU.Text
            info.TenKhang = txtTEN_KHANG.Text
            info.SoTaikhoan = txtSO_TAIKHOAN.Text
            info.MaSoThue = txtMA_SO_THUE.Text
            info.DiaChi = txtDIA_CHI.Text
            info.Tel = txtTEL.Text
            info.Fax = txtFAX.Text
            info.MatkLienquan = txtMATK_LIENQUAN.Text
            info.Tel = txtTEL.Text
            info.Email = txtEMAIL.Text
            info.NgaySinh = dteNgaySinh.DateTime
            If VnsCheck.IsNullGuid(cboKHANG_ID_CHA.EditValue) Then
                info.KhangIdCha = Null.NullGuid
            Else
                info.KhangIdCha = VnsConvert.CGuid(cboKHANG_ID_CHA.EditValue)
            End If
            info.TenLoaikhang = cboTEN_LOAIKHANG.Text
            info.Cmtnd = txtCMTND.Text
            info.Email = txtEMAIL.Text
            info.Website = txtWEBSITE.Text
            info.NguoiDaiDien = txtNGUOI_DAI_DIEN.Text
            If DB_GetString(cboTEN_LOAIKHANG.EditValue) <> "" Then
                info.LoaiKhang = Decimal.Parse(cboTEN_LOAIKHANG.EditValue.ToString())
            End If
            'info.NHOM_KHANG_1 = grlNHOM_KHANG_1.EditValue.ToString()
            If (DB_GetString(grlNHOM_KHANG_1.EditValue) <> "") Then
                Dim drNKH1 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_1), DmNhomKhang)
                If (Not drNKH1 Is Nothing) Then
                    info.NhomKhang1 = drNKH1.Id
                End If
            End If

            If (DB_GetString(grlNHOM_KHANG_2.EditValue) <> "") Then
                Dim drNKH2 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_2), DmNhomKhang)
                If (Not drNKH2 Is Nothing) Then
                    info.NhomKhang2 = drNKH2.Id
                End If
            End If

            If DB_GetString(grlNHOM_KHANG_3.EditValue) <> "" Then
                Dim drNKH3 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_3), DmNhomKhang)
                If (Not drNKH3 Is Nothing) Then
                    info.NhomKhang3 = drNKH3.Id
                End If
            End If
            'ký hiệu khách hàng
            'objDMKH.KY_HIEU = txtKY_HIEU.Text
            'info.LOAI_KHANG = decimal.Parse(cboLOAI_KHANG.Text);
            'Them moi
            If String.IsNullOrEmpty(_temp.MaKhang) Then
                info.MaKhang = " "
            Else
                info.MaKhang = _temp.MaKhang
            End If
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1

                Case FormGlobals.DataInputState.EditMode
                    info.ChiTiet = _temp.ChiTiet
            End Select
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.TheoDoiCn = TNCommon.ParseDecimal(chkTHEO_DOI_CN.Checked)
            MyBase.ResultObject = info
            Return info
        End Get

        'Lay du lieu tu cac thuoc tinh cua doi tuong Info gán cho các truong tuong ung trên form
        Set(ByVal value As DmKhang)
            If Not value Is Nothing Then
                IsLoadData = True
                Dim obj As DmKhang = TryCast(value, DmKhang)
                Me.txtCMTND.Text = obj.Cmtnd
                Me.txtDIA_CHI.Text = obj.DiaChi
                Me.txtEMAIL.Text = obj.Email
                Me.txtFAX.Text = obj.Fax
                Me.txtKY_HIEU.Text = obj.KyHieu
                Me.txtTEN_KHANG.Text = obj.TenKhang
                Me.txtTEL.Text = obj.Tel
                Me.txtMA_SO_THUE.Text = obj.MaSoThue
                Me.txtWEBSITE.Text = obj.Website
                Me.txtNGUOI_DAI_DIEN.Text = obj.NguoiDaiDien
                Me.txtSO_TAIKHOAN.Text = obj.SoTaikhoan
                Me.txtMATK_LIENQUAN.Text = obj.MatkLienquan
                Me.dteNgaySinh.DateTime = obj.NgaySinh
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                chkTHEO_DOI_CN.Checked = TNCommon.ParseBool(obj.TheoDoiCn)
                cboKHANG_ID_CHA.EditValue = obj.KhangIdCha

                cboTEN_LOAIKHANG.EditValue = obj.LoaiKhang
                grlNHOM_KHANG_1.EditValue = obj.NhomKhang1
                grlNHOM_KHANG_2.EditValue = obj.NhomKhang2
                grlNHOM_KHANG_3.EditValue = obj.NhomKhang3
                KH_Old = obj.KyHieu

                IsLoadData = False
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
    Public Overrides Sub InitProperty()
        TNCommon.setIconControl(Me)
        RequireInputControls = New Control() {txtKY_HIEU, txtTEN_KHANG}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        Me.ActiveControl = grlNHOM_KHANG_1
    End Sub

    Public Overrides Sub BindLookUpEdit()
        IsLoadData = True
        RemoveHandler grlNHOM_KHANG_1.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged
        RemoveHandler grlNHOM_KHANG_2.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged
        RemoveHandler grlNHOM_KHANG_3.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged

        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim dtTaikhoan As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(DmTaikhoanService().GetAllByDonviID(Generals.DON_VI.Id))
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMATK_LIENQUAN, "MaTaikhoan", dtTaikhoan, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)

        'Bind danh m?c cha
        Dim dr As DataRow

        Dim dt As List(Of DmKhang) = New List(Of DmKhang)
        dt.AddRange(DmKhangService().GetAllByDonviID(Generals.DON_VI.Id))
        Dim root As DmKhang = New DmKhang()
        root.Id = Guid.Empty
        root.TenKhang = "Khách hàng gốc"
        root.MaKhang = ""
        'dr["CAP"] = 1;
        dt.Insert(0, root)
        Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
        DanhMucChaColumnDefine.Add(New ColumnInfo("TenKhang", "Tên khách hàng", 0, True, ""))

        TNCommon.BindData_LookupEdit(cboKHANG_ID_CHA, dt, "TenKhang", "Id", DanhMucChaColumnDefine, True, True)


        'Bind tên loa?i kha´ch ha`ng

        Dim dsLKH As IList(Of HtDanhmuc) = HtDanhmucService().GetByDoiTuong("LOAI_KHACH_HANG")

        Dim LoaiKhachHangColumnDefine As ArrayList = New ArrayList()
        LoaiKhachHangColumnDefine.Add(New ColumnInfo("TenDanhmuc", "Tên loại khách hàng", 0, True, ""))

        TNCommon.BindData_LookupEdit(cboTEN_LOAIKHANG, dsLKH, "TenDanhmuc", "GiaTri", LoaiKhachHangColumnDefine, True, True)

        'bind nhóm khách hàng (khách hàng loại 1)
        Dim lstNKH1 As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        Dim lst1 As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
        For Each obj As DmNhomKhang In lstNKH1
            If (obj.Loai = 1) Then
                lst1.Add(obj)
            End If
        Next
        grlNHOM_KHANG_1.Properties.DataSource = lst1
        grlNHOM_KHANG_1.Properties.DisplayMember = "KyHieu"
        grlNHOM_KHANG_1.Properties.ValueMember = "Id"

        'bind nhóm khách hàng (khách hàng loại 2)
        Dim lstNKH2 As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        Dim lst2 As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
        For Each obj As DmNhomKhang In lstNKH2
            If (obj.Loai = 2) Then
                lst2.Add(obj)
            End If
        Next
        grlNHOM_KHANG_2.Properties.DataSource = lst2
        grlNHOM_KHANG_2.Properties.DisplayMember = "KyHieu"
        grlNHOM_KHANG_2.Properties.ValueMember = "Id"

        'bind nhóm khách hàng (khách hàng loại 3)
        Dim lstNKH3 As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        Dim lst3 As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
        For Each obj As DmNhomKhang In lstNKH3
            If (obj.Loai = 3) Then
                lst3.Add(obj)
            End If
        Next
        'textbox ky hieu tu dong

        grlNHOM_KHANG_3.Properties.DataSource = lst3
        grlNHOM_KHANG_3.Properties.DisplayMember = "KyHieu"
        grlNHOM_KHANG_3.Properties.ValueMember = "Id"

        AddHandler grlNHOM_KHANG_1.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged
        AddHandler grlNHOM_KHANG_2.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged
        AddHandler grlNHOM_KHANG_3.EditValueChanged, AddressOf grlNHOM_KHANG_EditValueChanged
        IsLoadData = False
    End Sub

    Private _temp As DmKhang = New DmKhang()
    Public Overrides Sub BindData()
        'Them moi
        _temp = DmKhangService.GetById(ID)
        ObjectInfo = _temp
    End Sub

    Public Overrides Sub Saving()
        If Not Check_Input() Then
            Return
        End If

        Dim info As DmKhang = ObjectInfo
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                info.Id = Guid.NewGuid()
                info.NgaySua = System.DateTime.Now
                info.NgayTao = System.DateTime.Now
                ID = DmKhangService().Save(info).Id

            Case FormGlobals.DataInputState.EditMode
                info.NgaySua = System.DateTime.Now
                DmKhangService().SaveOrUpdate(info)
        End Select
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Private Function and Procedures"
    Private Function GetNumKhangByKyHieu(ByVal str As String, ByVal number As Integer) As String
        

        Dim val As String = ""
        Dim num As Integer

        Dim dm1 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_1), DmNhomKhang)
        If dm1 Is Nothing Then
            dm1 = New DmNhomKhang
        End If

        Dim dm2 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_2), DmNhomKhang)
        If dm2 Is Nothing Then
            dm2 = New DmNhomKhang
        End If

        Dim dm3 As DmNhomKhang = CType(ComboHelper.GetSelectData(grlNHOM_KHANG_3), DmNhomKhang)
        If dm3 Is Nothing Then
            dm3 = New DmNhomKhang
        End If

        str = dm1.KyHieu + dm2.KyHieu + dm3.KyHieu
        'So khach hang trung nhom
        Try
            num = DmKhangService.GetNumberKhachHangByKyHieu(str, Generals.DON_VI.Id)
        Catch ex As Exception
        End Try


        'Dem so ky tu tra ve
        Dim s_num() As Char = CType(num.ToString, Char())
        Dim c_num As Integer = s_num.Length

        'Do dai so nhan dc tu db
        Dim f_num As Integer = number - c_num

        'Neu so tra ve tu db co do dai lon do dai truyen vao thi gan chuoi bang so nhan dc
        'Neu do dai truyen vao lon hon so tra ve tu db thi them 000 o dang trc thanh format: 000xx
        If f_num > 0 Then

            For index As Integer = 1 To f_num
                val = val + "0"
            Next

            val = val + num.ToString
        Else
            val = num.ToString
        End If
        Return str + val
    End Function

    Private Function Check_Input() As Boolean
        'If txtKY_HIEU.Text.Trim = "" Then
        '    Message_Warning("Bạn chưa nhập dữ liệu cho trường bắt buộc")
        '    Return False
        'End If
        Dim KH_New As String = ""
        Select Case Mode
            Case DataInputState.AddMode
                KH_New = txtKY_HIEU.Text
            Case DataInputState.EditMode
                If KH_Old <> txtKY_HIEU.Text.Trim Then
                    KH_New = txtKY_HIEU.Text.Trim
                End If
        End Select

        'Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_KHANG", "KY_HIEU", KH_New, Generals.DON_VI.Id)
        'If (Not kiemtra) Then
        '    Message_Warning("Ký hiệu khách hàng này đã tồn tại!")
        '    Return
        'End If

        Return True
    End Function
#End Region

#Region "Events"
    Private Sub frmDanhMucKhachHang_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grlNHOM_KHANG_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not Generals.Ts_Auto_gen_KyHieu Then
                Return
            End If

            If IsLoadData Then
                Return
            End If
            txtKY_HIEU.Text = GetNumKhangByKyHieu(String.Empty, 5)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            'Dim rs As DataTable = DmKhangService.CheckExistKhang(txtCMTND.Text, txtMA_SO_THUE.Text, txtDIA_CHI.Text, Generals.DON_VI.Id)
            'If rs.Rows.Count > 0 Then
            '    Message_Warning("Có " + (rs.Rows.Count - 1).ToString + " khách hàng đã sử dụng thông tin vừa nhập!")
            'Else
            '    Message_Information("Không có khách hàng nào trùng thông tin.")
            'End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            Control_ClearData(GroupControl1)
            Control_ClearData(_GroupControlObjectInfo)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
End Class
