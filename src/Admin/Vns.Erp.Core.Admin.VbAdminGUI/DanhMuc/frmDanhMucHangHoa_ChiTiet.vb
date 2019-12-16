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

Partial Public Class frmDanhMucHangHoa_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Dim _DmNhomVattu1Service As IDmNhomvattu1Service
    Public Property DmNhomVattu1Service() As IDmNhomvattu1Service
        Get
            Return _DmNhomVattu1Service
        End Get
        Set(ByVal value As IDmNhomvattu1Service)
            _DmNhomVattu1Service = value
        End Set
    End Property
    Dim _DmDvtService As IDmDvtService
    Public Property DmDvtService() As IDmDvtService
        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
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

    Dim _DmHanghoaService As IDmHanghoaService
    Public Property DmHanghoaService() As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property

    Public Property ObjectInfo() As DmHanghoa
        'Lay du lieu tu các truong du lieu trên form gán cho thuoc tính tuong ung cua doi tuong Info roi tra ve doi tuong Info dó
        Get
            Dim info As DmHanghoa = New DmHanghoa()
            If Not ID Is Nothing Then
                info = DmHanghoaService.Get(ID)
            End If
            info.HanghoaIdCha = Guid.Empty
            info.KyHieu = txtKY_HIEU.Text
            info.HanghoaIdCha = VnsConvert.CGuid(txtDmVatTuCha.Tag)
            info.TenHanghoa = txtTEN_HANGHOA.Text
            info.MaHanghoa = txtMaHanghoa.Text
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.ThanVo = TNCommon.ParseDecimal(chkTHAN_VO.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.NuocSanxuat = txtNUOC_SANXUAT.Text
            Dim drDVT As DmDvt = CType(ComboHelper.GetSelectData(grlDVT_ID), DmDvt)
            If drDVT IsNot Nothing Then
                info.MaDvt = drDVT.MaDvt
                info.TenDvt = drDVT.TenDvt
                info.DvtId = drDVT.Id
            End If
            info.IdNhomVt1 = VnsConvert.CGuid(grlID_NHOM_VT_1.EditValue)
            info.IdNhomVt2 = VnsConvert.CGuid(grlID_NHOM_VT_2.EditValue)
            info.IdNhomVt3 = VnsConvert.CGuid(grlID_NHOM_VT_3.EditValue)

            info.PpKtHtk = Decimal.Parse(grlTEN_PP_HTK1.EditValue.ToString())
            If txtNAM_SANXUAT1.Text.Trim <> "" Then
                info.NamSanxuat = Decimal.Parse(txtNAM_SANXUAT1.Text)
            End If
            info.TenPpHtk = grlTEN_PP_HTK1.Text
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id

            info.MdTkKho = txtMD_TK_KHO.Text
            info.MdTkGiavon = txtMD_TK_GIAVON.Text
            info.MdTkGiaban = txtMD_TK_GIABAN.Text
            info.MdTkHbTralai = txtMD_TK_HB_TRALAI.Text
            info.MdTkSpDd = txtMD_TK_SP_DD.Text
            info.MdTkDiduong = txtMdTkDiduong.Text
            '--------------------------
            info.LoaiHangHoa = VnsConvert.CDecimal(cboLOAI_HANG_HOA.EditValue)
            '--------------------------
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1
                Case FormGlobals.DataInputState.EditMode
                    info.ChiTiet = _temp.ChiTiet
            End Select
            info.ChiTiet = TNCommon.ParseDecimal(chkChiTiet.Checked)
            info.SynDate = Null.MIN_DATE
            MyBase.ResultObject = info
            Return info
        End Get

        'Lay du lieu tu các thuoc tính cua doi tuong Info gán cho các truong tuong ung trên form
        Set(ByVal value As DmHanghoa)
            If Not value Is Nothing Then
                Dim obj As DmHanghoa = _temp
                Me.txtKY_HIEU.Text = _temp.KyHieu
                Me.txtTEN_HANGHOA.Text = _temp.TenHanghoa
                Me.txtNUOC_SANXUAT.Text = _temp.NuocSanxuat

                Me.txtDmVatTuCha.Tag = _temp.HanghoaIdCha
                Me.txtDmVatTuCha.HasCheck = True
                Me.txtDmVatTuCha.Text = txtDmVatTuCha.ListEditValue(3)
                Me.txtDmVatTuCha.HasCheck = False

                Me.txtMaHanghoa.Text = _temp.MaHanghoa

                If _temp.NamSanxuat <> 0 Then
                    Me.txtNAM_SANXUAT1.Text = _temp.NamSanxuat
                End If
                grlID_NHOM_VT_1.EditValue = _temp.IdNhomVt1
                grlID_NHOM_VT_2.EditValue = _temp.IdNhomVt2
                grlID_NHOM_VT_3.EditValue = _temp.IdNhomVt3

                txtMD_TK_KHO.Text = _temp.MdTkKho
                txtMD_TK_GIAVON.Text = _temp.MdTkGiavon
                txtMD_TK_GIABAN.Text = _temp.MdTkGiaban
                txtMD_TK_HB_TRALAI.Text = _temp.MdTkHbTralai
                txtMD_TK_SP_DD.Text = _temp.MdTkSpDd
                txtMdTkDiduong.Text = _temp.MdTkDiduong

                'Add more here
                grlDVT_ID.EditValue = obj.DvtId
                grlTEN_PP_HTK1.EditValue = obj.PpKtHtk.ToString()
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(obj.ChoPhepSua)
                chkTHAN_VO.Checked = TNCommon.ParseBool(obj.ThanVo)

                cboLOAI_HANG_HOA.EditValue = Convert.ToInt32(obj.LoaiHangHoa)

            End If
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

    Private KiHieu As String = String.Empty
    Private nhom1 As String = String.Empty
    Private nhom2 As String = String.Empty
    Private nhom3 As String = String.Empty
    Private _temp As DmHanghoa = New DmHanghoa()

#Region "Load Form"
    Public Overrides Sub InitProperty()
        RequireInputControls = New Control() {txtKY_HIEU, txtTEN_HANGHOA, grlTEN_PP_HTK1, txtMD_TK_KHO}
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        grlID_NHOM_VT_1.Focus()
    End Sub

    Public Overrides Sub BindLookUpEdit()
        '//Bind Đon v? tính
        Dim dtDonViTinh As IList(Of DmDvt) = DmDvtService().GetAllByDonviID(Generals.DonviID)
        Dim _DonViTinhColumnDefine As ArrayList = New ArrayList()
        _DonViTinhColumnDefine.Add(New ColumnInfo("TenDvt", "Tên đơn vị tính", 0, True, ""))
        TNCommon.BindData_GridLookUp(grlDVT_ID, dtDonViTinh, "TenDvt", "Id", _DonViTinhColumnDefine, True, True)

        'ơ'Bind phuong phap tinh gia	
        Dim dtPPTinhGia As IList(Of HtDanhmuc) = HtDanhmucService().GetByDoiTuong("PP_TINHGIA_KHO")
        Dim _PPTinhGiaColumnDefine As ArrayList = New ArrayList()
        _PPTinhGiaColumnDefine.Add(New ColumnInfo("TenDanhmuc", "Phương pháp tính giá", 0, True, ""))
        TNCommon.BindData_GridLookUp(grlTEN_PP_HTK1, dtPPTinhGia, "TenDanhmuc", "GiaTri", _PPTinhGiaColumnDefine, True, True)

        'Bind nhom vat tu 1
        Dim objColumnDefine As ArrayList
        Dim DON_VI_ID As String = Generals.DON_VI.Id.ToString
        Dim dt_VTLoai1 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        dt_VTLoai1.AddRange(DmNhomVattu1Service.GetAllByNhom(Generals.DON_VI.Id, 1))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã nhóm vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên nhóm vật tư"))
        GridLookupEdit_BindData(grlID_NHOM_VT_1, dt_VTLoai1, "MaNhomVt1", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind nhom vat tu 2
        Dim dt_VTLoai2 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        dt_VTLoai2.AddRange(DmNhomVattu1Service.GetAllByNhom(Generals.DON_VI.Id, 2))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã nhóm vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên nhóm vật tư"))
        GridLookupEdit_BindData(grlID_NHOM_VT_2, dt_VTLoai2, "MaNhomVt1", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind nhom vat tu 3
        Dim dt_VTLoai3 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        dt_VTLoai3.AddRange(DmNhomVattu1Service.GetAllByNhom(Generals.DON_VI.Id, 3))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã nhóm vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên nhóm vật tư"))
        GridLookupEdit_BindData(grlID_NHOM_VT_3, dt_VTLoai3, "MaNhomVt1", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        Dim dt As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt.AddRange(DmTaikhoanService().GetAllByDonviID(Generals.DON_VI.Id))

        Dim dtTK_Kho As DataTable = New DataTable()
        dtTK_Kho = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_KHO As ArrayList = New ArrayList()
        columnDefineTK_KHO.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_KHO.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_KHO, "MaTaikhoan", dtTK_Kho, columnDefineTK_KHO)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)
        'AddHandler txtMD_TK_KHO.Validating, AddressOf ValidateData

        'hieen popup tai khoan gia von
        Dim dtTK_GiaVon As DataTable = New DataTable()
        dtTK_GiaVon = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_GVon As ArrayList = New ArrayList()
        columnDefineTK_GVon.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_GVon.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim begv As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_GIAVON, "MaTaikhoan", dtTK_GiaVon, columnDefineTK_GVon)
        begv.Text = "Chọn tài khoản"
        begv.Size = New Size(500, 300)
        'AddHandler txtMD_TK_GIAVON.Validating, AddressOf ValidateData

        'hien popup tai khoan gia ban
        Dim dtTK_GiaBan As DataTable = New DataTable()
        dtTK_GiaBan = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_GBan As ArrayList = New ArrayList()
        columnDefineTK_GBan.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_GBan.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim begv1 As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_GIABAN, "MaTaikhoan", dtTK_GiaBan, columnDefineTK_GBan)
        begv1.Text = "Chọn tài khoản"
        begv1.Size = New Size(500, 300)
        'AddHandler txtMD_TK_GIABAN.Validating, AddressOf ValidateData

        'hien popup tai khoan gia noi bo
        Dim dtTK_GiaBanNB As DataTable = New DataTable()
        dtTK_GiaBanNB = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_GBanNB As ArrayList = New ArrayList()
        columnDefineTK_GBanNB.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_GBanNB.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim begv2 As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_GIABAN_NB, "MaTaikhoan", dtTK_GiaBanNB, columnDefineTK_GBanNB)
        begv2.Text = "Chọn tài khoản"
        begv2.Size = New Size(500, 300)
        'AddHandler txtMD_TK_GIABAN_NB.Validating, AddressOf ValidateData

        'hien popup tai khoan gia ban tra lai
        Dim dtTK_TL As DataTable = New DataTable()
        dtTK_TL = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_HBTL As ArrayList = New ArrayList()
        columnDefineTK_HBTL.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_HBTL.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim begv3 As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_HB_TRALAI, "MaTaikhoan", dtTK_TL, columnDefineTK_HBTL)
        begv3.Text = "Chọn tài khoản"
        begv3.Size = New Size(500, 300)
        ' AddHandler txtMD_TK_HB_TRALAI.Validating, AddressOf ValidateData

        'hien popup tai khoan gia ban do dang
        Dim dtTK_DD As DataTable = New DataTable()
        dtTK_DD = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)
        Dim columnDefineTK_SPDD As ArrayList = New ArrayList()
        columnDefineTK_SPDD.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefineTK_SPDD.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim begv4 As BaseGridPopupForm = New BaseGridPopupForm(txtMD_TK_SP_DD, "MaTaikhoan", dtTK_DD, columnDefineTK_SPDD)
        begv4.Text = "Chọn tài khoản"
        begv4.Size = New Size(500, 300)

        Dim dsLKH As IList(Of HtDanhmuc) = HtDanhmucService().GetByDoiTuong("LOAI_HANG_HOA")
        cboLOAI_HANG_HOA.Properties.DataSource = dsLKH
    End Sub

    Public Overrides Sub BindData()
        Select Case Mode
            Case DataInputState.EditMode
                _temp = DmHanghoaService().Get(ID)
                ObjectInfo = _temp
            Case DataInputState.AddMode
                Dim obj As DmHanghoa = New DmHanghoa
                ObjectInfo = obj
        End Select
    End Sub

    Public Overrides Sub Saving()
        If Not CheckInput() Then Return

        Dim info As DmHanghoa = ObjectInfo
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = DmHanghoaService.SaveOrUpdate(info).Id

            Case FormGlobals.DataInputState.EditMode
                ID = DmHanghoaService.SaveOrUpdate(info).Id
        End Select
        'Tra gia tri ve ham Overrides
        ObjectInfo = info
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Modify here"
    Public Sub UpdateFormToObject(ByRef info As DmHanghoa)
        info.HanghoaIdCha = Guid.Empty
        info.KyHieu = Me.txtKY_HIEU.Text
        info.DonviId = Generals.DON_VI.Id
        info.MaDonvi = Generals.DON_VI.MaDonvi
        info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
        info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
        info.ThanVo = TNCommon.ParseDecimal(chkTHAN_VO.Checked)

        Dim drDVT As DmDvt = CType(ComboHelper.GetSelectData(grlDVT_ID), DmDvt)
        If drDVT IsNot Nothing Then
            info.MaDvt = drDVT.MaDvt
            info.TenDvt = drDVT.TenDvt
            info.DvtId = drDVT.Id
        End If
        info.PpKtHtk = Decimal.Parse(grlTEN_PP_HTK1.EditValue.ToString())
        info.NamSanxuat = Decimal.Parse(txtNAM_SANXUAT1.Text)
        info.TenPpHtk = grlTEN_PP_HTK1.Text
        info.NguoiTao = Generals.USER.Id
        info.NguoiSua = Generals.USER.Id

        Dim tmpdm As HtDanhmuc = New HtDanhmuc()
        tmpdm = CType(ComboHelper.GetSelectData(cboLOAI_HANG_HOA), HtDanhmuc)
        If (tmpdm IsNot Nothing) Then
            info.LoaiHangHoa = tmpdm.GiaTri
        End If
        '--------------------------
        If String.IsNullOrEmpty(_temp.MaHanghoa) Then
            info.MaHanghoa = txtKY_HIEU.Text.Trim
        Else
            info.MaHanghoa = txtKY_HIEU.Text.Trim
        End If
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                info.ChiTiet = 1

            Case FormGlobals.DataInputState.EditMode
                info.ChiTiet = _temp.ChiTiet
        End Select


    End Sub

    Private Sub SetDefaultValue()
        txtMD_TK_KHO.Text = Generals.Df_Tk_Kho.GiaTri
        txtMD_TK_GIABAN.Text = Generals.Df_Tk_DoanhThu.GiaTri
        txtMD_TK_GIAVON.Text = Generals.Df_Tk_GiaVon.GiaTri

        Dim t As Decimal = 1
        Decimal.TryParse(Generals.Df_PP_TinhGiaKho.GiaTri, t)
        grlTEN_PP_HTK1.EditValue = t
    End Sub
#End Region

#Region "Events"
    Private Sub frmDanhMucHangHoa_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    TNCommon.SelectFirst(grlDVT_ID)
                    TNCommon.SelectFirst(grlTEN_PP_HTK1)
                    SetDefaultValue()
                Case FormGlobals.DataInputState.EditMode
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Check user's action
        Try
            Control_ClearData(GroupControl1)
            Control_ClearData(GroupControl2)
            Control_ClearData(GroupControl3)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlID_NHOM_VT_1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlID_NHOM_VT_1.EditValueChanged
        Try
            Select Case Mode
                Case DataInputState.AddMode
                    GT_KH()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlID_NHOM_VT_2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlID_NHOM_VT_2.EditValueChanged
        Try
            Select Case Mode
                Case DataInputState.AddMode
                    GT_KH()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlID_NHOM_VT_3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlID_NHOM_VT_3.EditValueChanged
        Try
            Select Case Mode
                Case DataInputState.AddMode
                    GT_KH()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private A, B, C As String
    Private Sub GT_KH()
        If Not Generals.Ts_Auto_gen_KyHieu Then
            Return
        End If

        If VnsCheck.IsNullGuid(grlID_NHOM_VT_1.EditValue) Then
            A = grlID_NHOM_VT_1.Text.ToString() + "."
        Else
            A = ""
        End If
        If VnsCheck.IsNullGuid(grlID_NHOM_VT_2.EditValue) Then
            B = grlID_NHOM_VT_2.Text.ToString() + "."
        Else
            B = ""
        End If
        If VnsCheck.IsNullGuid(grlID_NHOM_VT_3.EditValue) Then
            C = grlID_NHOM_VT_3.Text.ToString() + "."
        Else
            C = ""
        End If
        Select Case Mode
            Case DataInputState.AddMode
                Dim kh As Integer = DmHanghoaService.GetNumberHangHoaByKyHieu(A + B + C, Generals.DON_VI.Id)
                Dim str As String = ""
                If kh < 10 Then
                    str = "000" + kh.ToString
                ElseIf kh > 9 And kh < 100 Then
                    str = "00" + kh.ToString()
                ElseIf kh > 99 And kh < 1000 Then
                    str = "0" + kh.ToString
                Else
                    str = kh.ToString()
                End If
                txtKY_HIEU.Text = A + B + C + str
            Case DataInputState.EditMode
                KiHieu = _temp.KyHieu.Replace(A + B + C, "")
                txtKY_HIEU.Text = A + B + C + KiHieu
        End Select
    End Sub

    Private Function CheckInput()
        ' Kiem tra cac truong nhap lieu bat buoc
        Dim blankInputMsg As String = "Bạn chưa nhập đủ giá trị cho trường bắt buộc!"

        ' Ky hieu hang hoa
        If txtKY_HIEU.Text.Length = 0 Then
            Message_Warning(blankInputMsg)
            txtKY_HIEU.Focus()
            Return False
        End If

        ' Ten hang hoa
        If txtTEN_HANGHOA.Text.Length = 0 Then
            Message_Warning(blankInputMsg)
            txtTEN_HANGHOA.Focus()
            Return False
        End If

        ' TK kho cua hang hoa
        If txtMD_TK_KHO.Text.Length = 0 Then
            Message_Warning(blankInputMsg)
            txtMD_TK_KHO.Focus()
            Return False
        End If

        ' Ten phuong phap hach toan
        If grlTEN_PP_HTK1.Text.Length = 0 Then
            Message_Warning(blankInputMsg)
            grlTEN_PP_HTK1.Focus()
            Return False
        End If

        If VnsCheck.IsNullGuid(grlDVT_ID.EditValue) Then
            Message_Warning(blankInputMsg)
            grlDVT_ID.Focus()
            Return False
        End If

        '' Nam san xuat
        'If txtNAM_SANXUAT1.Text.Length = 0 Then
        '    Message_Warning(blankInputMsg)
        '    txtNAM_SANXUAT1.Focus()
        '    Return False
        'End If

        ' Kiem tra ky hieu ton tai trong DB
        ' Trang thai cua form la Add mode hoac Edit mode nhung co sua Ky hieu
        If (Mode = DataInputState.AddMode) Or (Mode = DataInputState.EditMode And txtKY_HIEU.Text.Trim() <> _temp.KyHieu) Then
            ' Lay so record co Ky hieu tuong tu trong DB
            Dim countKyHieuDB As Integer = DmHanghoaService.GetNumberHangHoaByKyHieu(txtKY_HIEU.Text.Trim(), Generals.DON_VI.Id)

            ' Ky hieu da duoc su dung trong DB
            If countKyHieuDB > 0 Then
                Message_Warning("Ký hiệu đã có trong cơ sở dữ liệu. Xin chọn ký hiệu khác!")
                txtKY_HIEU.Focus()
                Return False
            End If
            'ElseIf (Mode = DataInputState.EditMode And txtKY_HIEU.Text.Trim() <> _temp.KY_HIEU.Trim()) Then

        End If
        Return True
    End Function

    Private Sub txtDmVatTuCha_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDmVatTuCha.AfterFilter
        Try
            txtDmVatTuCha.Tag = txtDmVatTuCha.ListEditValue(0)
            txtDmVatTuCha.Text = txtDmVatTuCha.ListEditValue(3)
            If txtDmVatTuCha.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDmVatTuCha_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDmVatTuCha.ClearFilterData
        Try
            txtDmVatTuCha.Text = ""
            txtDmVatTuCha.Tag = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private dt_tk As IList(Of DmHanghoa) = New List(Of DmHanghoa)()
    Private Sub txtDmVatTuCha_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDmVatTuCha.FirstBinddata
        Try
            dt_tk = DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id)
            Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt_tk)
            txtDmVatTuCha.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class




