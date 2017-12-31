Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    '''''''''''''''''''''''''''''''
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barMenu = New DevExpress.XtraBars.Bar()
        Me.soAdmin = New DevExpress.XtraBars.BarSubItem()
        Me.soLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.siLogOut = New DevExpress.XtraBars.BarButtonItem()
        Me.siAdminChangePass = New DevExpress.XtraBars.BarButtonItem()
        Me.siUserManagement = New DevExpress.XtraBars.BarButtonItem()
        Me.siDonviGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.siDonviGroupUser = New DevExpress.XtraBars.BarButtonItem()
        Me.siDonviGroupForm = New DevExpress.XtraBars.BarButtonItem()
        Me.siDonviBaocao = New DevExpress.XtraBars.BarButtonItem()
        Me.siDonviGroupBaocao = New DevExpress.XtraBars.BarButtonItem()
        Me.siFreezeData = New DevExpress.XtraBars.BarButtonItem()
        Me.siUserActionReport = New DevExpress.XtraBars.BarButtonItem()
        Me.soAdminDatabaseSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.soExit = New DevExpress.XtraBars.BarButtonItem()
        Me.adminReport = New DevExpress.XtraBars.BarSubItem()
        Me._frmTreeBaoCao = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me._barTeamview = New DevExpress.XtraBars.BarButtonItem()
        Me.barBottom = New DevExpress.XtraBars.Bar()
        Me.barGuide = New DevExpress.XtraBars.BarStaticItem()
        Me.barClientDate = New DevExpress.XtraBars.BarStaticItem()
        Me.barClientDonVi = New DevExpress.XtraBars.BarStaticItem()
        Me.barClientNamKT = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me._KhaiBaoCacButToanPhanBoTuDong = New DevExpress.XtraBars.BarButtonItem()
        Me._KhaiBaoCacButToanKetChuyenTuDong = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTaiKhoan = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTaiKhoanNganHang = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucKhachHang = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucThueSuat = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucPhongBan = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucHangHoaVatTu = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucKhoHang = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTaiSanCoDinh = New DevExpress.XtraBars.BarButtonItem()
        Me._DieuChinhGiaTriTaiSan = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucNguonVonTSCD = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucLyDoTangGiamTSCD = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucBoPhanSuDungTSCD = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucNhomTSCD = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucPhanNhomTaiSan = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.barToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.barMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.barSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me._PhieuKeToan = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuThuTienMat = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuChiTienMat = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuNhapHangBanBiTraLai = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuThuDatCoc = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuNhapMuaHang = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuNhapKhau = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuNhapChiPhiMuaHang = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuXuatTraLaiNhaCungCap = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuThanhToanTamUng = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuNhapKho = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuXuatKho = New DevExpress.XtraBars.BarButtonItem()
        Me._PhieuDieuchuyen = New DevExpress.XtraBars.BarButtonItem()
        Me._ButToanPhanBoTuDong = New DevExpress.XtraBars.BarButtonItem()
        Me._ButToanKetChuyenTuDong = New DevExpress.XtraBars.BarButtonItem()
        Me._GiayBaoCoNganHang = New DevExpress.XtraBars.BarButtonItem()
        Me._GiayBaoNoNganHang = New DevExpress.XtraBars.BarButtonItem()
        Me._GiayBaoCoNGoaiTeTheoTiGiaHachToan = New DevExpress.XtraBars.BarButtonItem()
        Me._GiayBaoNoNgoaiTeTheoTiGiaHachToan = New DevExpress.XtraBars.BarButtonItem()
        Me._HoaDonBanHangKiemPhieuXuatKho = New DevExpress.XtraBars.BarButtonItem()
        Me._HoaDonMuaHangDichVu = New DevExpress.XtraBars.BarButtonItem()
        Me._ChungTuPhaiThuBuTruCongNo = New DevExpress.XtraBars.BarButtonItem()
        Me._ChungTuPhaiTraBuTruCongNo = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem54 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucDonViTinh = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucNgoaiTe = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucKho = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucVuViec = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucHangHoa = New DevExpress.XtraBars.BarButtonItem()
        Me._f = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem12 = New DevExpress.XtraBars.BarSubItem()
        Me._QuanLyNgoaiTe = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem13 = New DevExpress.XtraBars.BarSubItem()
        Me._TSCD = New DevExpress.XtraBars.BarSubItem()
        Me._KhaiBaoGiamTaiSan = New DevExpress.XtraBars.BarButtonItem()
        Me._DieuChuyenTSCD = New DevExpress.XtraBars.BarButtonItem()
        Me.Da = New DevExpress.XtraBars.BarSubItem()
        Me._DMNhomKHang = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucDonVi = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucKieuXe = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucXe = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucCanBoCongNhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucCongViecSuaChua = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucHopDong = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucPhuongThucQuanTri = New DevExpress.XtraBars.BarButtonItem()
        Me._DMLoaiChungTu = New DevExpress.XtraBars.BarButtonItem()
        Me._DMKhoanPhi = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem15 = New DevExpress.XtraBars.BarSubItem()
        Me._NhapSoDuTaiKhoan = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem16 = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItem17 = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItem18 = New DevExpress.XtraBars.BarSubItem()
        Me._NhapSoDuDauNam = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem19 = New DevExpress.XtraBars.BarSubItem()
        Me._TinhGiaXuatKho = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem20 = New DevExpress.XtraBars.BarSubItem()
        Me._NhomVatTu1 = New DevExpress.XtraBars.BarButtonItem()
        Me._NhomVatTu2 = New DevExpress.XtraBars.BarButtonItem()
        Me._NhomVatTu3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItem21 = New DevExpress.XtraBars.BarSubItem()
        Me._DanhMucTuDo1 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTuDo2 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTuDo3 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTuDo4 = New DevExpress.XtraBars.BarButtonItem()
        Me._DanhMucTuDo5 = New DevExpress.XtraBars.BarButtonItem()
        Me._InDanhMuc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem23 = New DevExpress.XtraBars.BarSubItem()
        Me._LenhPhuTung = New DevExpress.XtraBars.BarButtonItem()
        Me._LenhSuaChua = New DevExpress.XtraBars.BarButtonItem()
        Me._ThucHienPhanBoTuDong = New DevExpress.XtraBars.BarButtonItem()
        Me._ThietLapMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me._CloseAllVisible = New DevExpress.XtraBars.BarButtonItem()
        Me.siGrantPermission = New DevExpress.XtraBars.BarButtonItem()
        Me.siDataTransfer = New DevExpress.XtraBars.BarButtonItem()
        Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.bar4 = New DevExpress.XtraBars.Bar()
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.iStatus1 = New DevExpress.XtraBars.BarStaticItem()
        Me._barUpdateSoftware = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barManager1
        '
        Me.barManager1.AllowCustomization = False
        Me.barManager1.AllowMoveBarOnToolbar = False
        Me.barManager1.AllowQuickCustomization = False
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barMenu, Me.barBottom})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Images = Me.ImageList1
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItem1, Me.barSubItem3, Me._KhaiBaoCacButToanPhanBoTuDong, Me._KhaiBaoCacButToanKetChuyenTuDong, Me._DanhMucTaiKhoan, Me._DanhMucTaiKhoanNganHang, Me._DanhMucKhachHang, Me._DanhMucThueSuat, Me._DanhMucPhongBan, Me._DanhMucHangHoaVatTu, Me._DanhMucKhoHang, Me._DanhMucTaiSanCoDinh, Me._DieuChinhGiaTriTaiSan, Me._DanhMucNguonVonTSCD, Me._DanhMucLyDoTangGiamTSCD, Me._DanhMucBoPhanSuDungTSCD, Me._DanhMucNhomTSCD, Me.barButtonItem15, Me._DanhMucPhanNhomTaiSan, Me.barButtonItem17, Me.barButtonItem18, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barButtonItem14, Me.barButtonItem16, Me.barButtonItem19, Me.barButtonItem20, Me.barButtonItem21, Me.barButtonItem22, Me.barButtonItem23, Me.barButtonItem24, Me.barButtonItem25, Me.barButtonItem27, Me.barButtonItem28, Me.barButtonItem26, Me.barSubItem4, Me.barSubItem5, Me.barToolbarsListItem1, Me.barMdiChildrenListItem1, Me.barSubItem6, Me.barSubItem7, Me._PhieuKeToan, Me._PhieuThuTienMat, Me._PhieuChiTienMat, Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan, Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan, Me._PhieuNhapHangBanBiTraLai, Me._PhieuThuDatCoc, Me._PhieuNhapMuaHang, Me._PhieuNhapKhau, Me._PhieuNhapChiPhiMuaHang, Me._PhieuXuatTraLaiNhaCungCap, Me._PhieuThanhToanTamUng, Me._PhieuNhapKho, Me._PhieuXuatKho, Me._PhieuDieuchuyen, Me._ButToanPhanBoTuDong, Me._ButToanKetChuyenTuDong, Me._GiayBaoCoNganHang, Me._GiayBaoNoNganHang, Me._GiayBaoCoNGoaiTeTheoTiGiaHachToan, Me._GiayBaoNoNgoaiTeTheoTiGiaHachToan, Me._HoaDonBanHangKiemPhieuXuatKho, Me._HoaDonMuaHangDichVu, Me._ChungTuPhaiThuBuTruCongNo, Me._ChungTuPhaiTraBuTruCongNo, Me.barButtonItem54, Me.soAdmin, Me.soLogin, Me.siLogOut, Me.siAdminChangePass, Me.siUserManagement, Me.siFreezeData, Me.siUserActionReport, Me.soAdminDatabaseSettings, Me.soExit, Me._DanhMucDonViTinh, Me._DanhMucNgoaiTe, Me._DanhMucKho, Me._DanhMucVuViec, Me._DanhMucHangHoa, Me._f, Me.barSubItem12, Me.barSubItem13, Me._TSCD, Me.Da, Me.barSubItem15, Me.barSubItem16, Me.barSubItem17, Me.barSubItem18, Me.barSubItem19, Me.barSubItem20, Me._NhomVatTu1, Me._NhomVatTu3, Me.barSubItem21, Me._DanhMucTuDo2, Me._DanhMucTuDo3, Me._DanhMucTuDo4, Me._DanhMucTuDo5, Me._DanhMucTuDo1, Me._DanhMucDonVi, Me._DanhMucKieuXe, Me._DanhMucXe, Me._DanhMucCanBoCongNhanVien, Me._DanhMucCongViecSuaChua, Me._DanhMucHopDong, Me._DanhMucPhuongThucQuanTri, Me.adminReport, Me._InDanhMuc, Me._DMLoaiChungTu, Me._frmTreeBaoCao, Me.barGuide, Me.barClientDate, Me._DMKhoanPhi, Me.BarSubItem23, Me._LenhPhuTung, Me._LenhSuaChua, Me._ThucHienPhanBoTuDong, Me._NhomVatTu2, Me._NhapSoDuTaiKhoan, Me._QuanLyNgoaiTe, Me._DMNhomKHang, Me._ThietLapMenu, Me._KhaiBaoGiamTaiSan, Me._NhapSoDuDauNam, Me._DieuChuyenTSCD, Me.BarEditItem1, Me.BarButtonItem29, Me.BarButtonItem30, Me._TinhGiaXuatKho, Me._CloseAllVisible, Me.siGrantPermission, Me.barClientDonVi, Me.siDonviGroup, Me.siDonviGroupUser, Me.siDonviGroupForm, Me.siDonviBaocao, Me.siDonviGroupBaocao, Me.siDataTransfer, Me.barClientNamKT, Me.BarSubItem2, Me._barTeamview, Me._barUpdateSoftware})
        Me.barManager1.MainMenu = Me.barMenu
        Me.barManager1.MaxItemId = 181
        '
        'barMenu
        '
        Me.barMenu.BarName = "Main menu"
        Me.barMenu.DockCol = 0
        Me.barMenu.DockRow = 0
        Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.soAdmin), New DevExpress.XtraBars.LinkPersistInfo(Me.adminReport), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2)})
        Me.barMenu.OptionsBar.MultiLine = True
        Me.barMenu.OptionsBar.UseWholeRow = True
        Me.barMenu.Text = "Main menu"
        '
        'soAdmin
        '
        Me.soAdmin.Caption = "Hệ thống"
        Me.soAdmin.Id = 85
        Me.soAdmin.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.soLogin), New DevExpress.XtraBars.LinkPersistInfo(Me.siLogOut), New DevExpress.XtraBars.LinkPersistInfo(Me.siAdminChangePass), New DevExpress.XtraBars.LinkPersistInfo(Me.siUserManagement, True), New DevExpress.XtraBars.LinkPersistInfo(Me.siDonviGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.siDonviGroupUser), New DevExpress.XtraBars.LinkPersistInfo(Me.siDonviGroupForm), New DevExpress.XtraBars.LinkPersistInfo(Me.siDonviBaocao), New DevExpress.XtraBars.LinkPersistInfo(Me.siDonviGroupBaocao), New DevExpress.XtraBars.LinkPersistInfo(Me.siFreezeData, True), New DevExpress.XtraBars.LinkPersistInfo(Me.siUserActionReport), New DevExpress.XtraBars.LinkPersistInfo(Me.soAdminDatabaseSettings), New DevExpress.XtraBars.LinkPersistInfo(Me.soExit, True)})
        Me.soAdmin.Name = "soAdmin"
        '
        'soLogin
        '
        Me.soLogin.Caption = "Ðăng nhập"
        Me.soLogin.Id = 86
        Me.soLogin.Name = "soLogin"
        '
        'siLogOut
        '
        Me.siLogOut.Caption = "Ðăng xuất"
        Me.siLogOut.Id = 87
        Me.siLogOut.Name = "siLogOut"
        '
        'siAdminChangePass
        '
        Me.siAdminChangePass.Caption = "Ðổi mật khẩu"
        Me.siAdminChangePass.Id = 88
        Me.siAdminChangePass.Name = "siAdminChangePass"
        '
        'siUserManagement
        '
        Me.siUserManagement.Caption = "Quản lý người dùng"
        Me.siUserManagement.Enabled = False
        Me.siUserManagement.Id = 89
        Me.siUserManagement.Name = "siUserManagement"
        Me.siUserManagement.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDonviGroup
        '
        Me.siDonviGroup.Caption = "Phân quyền chức năng"
        Me.siDonviGroup.Id = 166
        Me.siDonviGroup.Name = "siDonviGroup"
        Me.siDonviGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDonviGroupUser
        '
        Me.siDonviGroupUser.Caption = "Phân nhóm cho người dùng"
        Me.siDonviGroupUser.Id = 167
        Me.siDonviGroupUser.Name = "siDonviGroupUser"
        Me.siDonviGroupUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDonviGroupForm
        '
        Me.siDonviGroupForm.Caption = "Phân quyền chức năng"
        Me.siDonviGroupForm.Id = 168
        Me.siDonviGroupForm.Name = "siDonviGroupForm"
        Me.siDonviGroupForm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDonviBaocao
        '
        Me.siDonviBaocao.Caption = "Phân quyền báo cáo"
        Me.siDonviBaocao.Id = 170
        Me.siDonviBaocao.Name = "siDonviBaocao"
        Me.siDonviBaocao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDonviGroupBaocao
        '
        Me.siDonviGroupBaocao.Caption = "Phân quyền báo cáo"
        Me.siDonviGroupBaocao.Id = 171
        Me.siDonviGroupBaocao.Name = "siDonviGroupBaocao"
        Me.siDonviGroupBaocao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siFreezeData
        '
        Me.siFreezeData.Caption = "&Freeze Data"
        Me.siFreezeData.Id = 90
        Me.siFreezeData.Name = "siFreezeData"
        Me.siFreezeData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siUserActionReport
        '
        Me.siUserActionReport.Caption = "User &Action Report"
        Me.siUserActionReport.Id = 91
        Me.siUserActionReport.Name = "siUserActionReport"
        Me.siUserActionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'soAdminDatabaseSettings
        '
        Me.soAdminDatabaseSettings.Caption = "Cấu hình CSDL"
        Me.soAdminDatabaseSettings.Id = 93
        Me.soAdminDatabaseSettings.Name = "soAdminDatabaseSettings"
        '
        'soExit
        '
        Me.soExit.Caption = "Thoát"
        Me.soExit.Id = 94
        Me.soExit.Name = "soExit"
        '
        'adminReport
        '
        Me.adminReport.Caption = "Báo cáo"
        Me.adminReport.Enabled = False
        Me.adminReport.Id = 129
        Me.adminReport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._frmTreeBaoCao)})
        Me.adminReport.Name = "adminReport"
        '
        '_frmTreeBaoCao
        '
        Me._frmTreeBaoCao.Caption = "Báo cáo tổng hợp"
        Me._frmTreeBaoCao.Id = 132
        Me._frmTreeBaoCao.ImageIndex = 0
        Me._frmTreeBaoCao.Name = "_frmTreeBaoCao"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Tiện ích"
        Me.BarSubItem2.Id = 178
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._barTeamview), New DevExpress.XtraBars.LinkPersistInfo(Me._barUpdateSoftware)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        '_barTeamview
        '
        Me._barTeamview.Caption = "Hỗ trợ từ xa bằng Teamview"
        Me._barTeamview.Id = 179
        Me._barTeamview.Name = "_barTeamview"
        '
        'barBottom
        '
        Me.barBottom.BarName = "barBottom"
        Me.barBottom.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barBottom.DockCol = 0
        Me.barBottom.DockRow = 0
        Me.barBottom.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barBottom.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barGuide, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barClientDate), New DevExpress.XtraBars.LinkPersistInfo(Me.barClientDonVi), New DevExpress.XtraBars.LinkPersistInfo(Me.barClientNamKT)})
        Me.barBottom.OptionsBar.AllowQuickCustomization = False
        Me.barBottom.OptionsBar.DrawDragBorder = False
        Me.barBottom.OptionsBar.DrawSizeGrip = True
        Me.barBottom.OptionsBar.RotateWhenVertical = False
        Me.barBottom.OptionsBar.UseWholeRow = True
        Me.barBottom.Text = "Status  Bar"
        '
        'barGuide
        '
        Me.barGuide.Id = 134
        Me.barGuide.Name = "barGuide"
        Me.barGuide.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'barClientDate
        '
        Me.barClientDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barClientDate.Caption = "Người sử dụng: "
        Me.barClientDate.Id = 135
        Me.barClientDate.Name = "barClientDate"
        Me.barClientDate.RightIndent = 2
        Me.barClientDate.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barClientDonVi
        '
        Me.barClientDonVi.Caption = "Đơn vị:"
        Me.barClientDonVi.Id = 165
        Me.barClientDonVi.Name = "barClientDonVi"
        Me.barClientDonVi.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barClientNamKT
        '
        Me.barClientNamKT.Caption = "Năm KT:"
        Me.barClientNamKT.Id = 177
        Me.barClientNamKT.Name = "barClientNamKT"
        Me.barClientNamKT.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1185, 30)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 856)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1185, 34)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 826)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1185, 30)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 826)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "book.png")
        Me.ImageList1.Images.SetKeyName(1, "book_key.png")
        Me.ImageList1.Images.SetKeyName(2, "book_open.png")
        '
        'barSubItem1
        '
        Me.barSubItem1.Caption = "Hệ thống"
        Me.barSubItem1.Id = 0
        Me.barSubItem1.Name = "barSubItem1"
        '
        'barSubItem3
        '
        Me.barSubItem3.Caption = "Giao dịch"
        Me.barSubItem3.Id = 2
        Me.barSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.barButtonItem2, "Bút toán phân b? t? d?ng", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem28)})
        Me.barSubItem3.Name = "barSubItem3"
        '
        'barButtonItem3
        '
        Me.barButtonItem3.Caption = "Bút toán kết chuyển tự động"
        Me.barButtonItem3.Id = 24
        Me.barButtonItem3.Name = "barButtonItem3"
        '
        'barButtonItem2
        '
        Me.barButtonItem2.Caption = "Bút toán phân bổ tự động"
        Me.barButtonItem2.Id = 23
        Me.barButtonItem2.Name = "barButtonItem2"
        '
        'barButtonItem4
        '
        Me.barButtonItem4.Caption = "Giấy báo có Ngân hàng"
        Me.barButtonItem4.Id = 25
        Me.barButtonItem4.Name = "barButtonItem4"
        '
        'barButtonItem5
        '
        Me.barButtonItem5.Caption = "Giấy báo nợ Ngân hàng"
        Me.barButtonItem5.Id = 26
        Me.barButtonItem5.Name = "barButtonItem5"
        '
        'barButtonItem6
        '
        Me.barButtonItem6.Caption = "Phiếu thu Tiền mặt"
        Me.barButtonItem6.Id = 27
        Me.barButtonItem6.Name = "barButtonItem6"
        '
        'barButtonItem7
        '
        Me.barButtonItem7.Caption = "Phiếu chi Tiền mặt"
        Me.barButtonItem7.Id = 28
        Me.barButtonItem7.Name = "barButtonItem7"
        '
        'barButtonItem9
        '
        Me.barButtonItem9.Caption = "Giấy báo nợ ngoại tệ theo Tỷ giá hạch toán"
        Me.barButtonItem9.Id = 30
        Me.barButtonItem9.Name = "barButtonItem9"
        '
        'barButtonItem10
        '
        Me.barButtonItem10.Caption = "Phiếu thu Tiền mặt ngoại tệ theo Tỷ giá hạch toán"
        Me.barButtonItem10.Id = 31
        Me.barButtonItem10.Name = "barButtonItem10"
        '
        'barButtonItem8
        '
        Me.barButtonItem8.Caption = "Giấy báo có ngoại tệ theo Tỷ giá hạch toán"
        Me.barButtonItem8.Id = 29
        Me.barButtonItem8.Name = "barButtonItem8"
        '
        'barButtonItem12
        '
        Me.barButtonItem12.Caption = "Phiếu sửa chữa"
        Me.barButtonItem12.Id = 33
        Me.barButtonItem12.Name = "barButtonItem12"
        '
        'barButtonItem13
        '
        Me.barButtonItem13.Caption = "Biên nhận theo lệnh"
        Me.barButtonItem13.Id = 34
        Me.barButtonItem13.Name = "barButtonItem13"
        '
        'barButtonItem14
        '
        Me.barButtonItem14.Caption = "Hóa đơn bán hàng kiêm Phiếu xuất kho"
        Me.barButtonItem14.Id = 35
        Me.barButtonItem14.Name = "barButtonItem14"
        '
        'barButtonItem16
        '
        Me.barButtonItem16.Caption = "Phiếu nhập hàng bán bị trả lại"
        Me.barButtonItem16.Id = 36
        Me.barButtonItem16.Name = "barButtonItem16"
        '
        'barButtonItem19
        '
        Me.barButtonItem19.Caption = "Hóa đơn Dịch vụ"
        Me.barButtonItem19.Id = 37
        Me.barButtonItem19.Name = "barButtonItem19"
        '
        'barButtonItem11
        '
        Me.barButtonItem11.Caption = "Phiếu chi tiền mặt ngoại tệ theo Tỷ giá hạch toán"
        Me.barButtonItem11.Id = 32
        Me.barButtonItem11.Name = "barButtonItem11"
        '
        'barButtonItem20
        '
        Me.barButtonItem20.Caption = "Phiếu thu Đặt cọc"
        Me.barButtonItem20.Id = 38
        Me.barButtonItem20.Name = "barButtonItem20"
        '
        'barButtonItem21
        '
        Me.barButtonItem21.Caption = "Chứng từ phải thu khác, Chứng từ bù trừ công nợ"
        Me.barButtonItem21.Id = 39
        Me.barButtonItem21.Name = "barButtonItem21"
        '
        'barButtonItem22
        '
        Me.barButtonItem22.Caption = "Nhập tiền Môi giới"
        Me.barButtonItem22.Id = 40
        Me.barButtonItem22.Name = "barButtonItem22"
        '
        'barButtonItem23
        '
        Me.barButtonItem23.Caption = "Phiếu nhập Mua hàng"
        Me.barButtonItem23.Id = 41
        Me.barButtonItem23.Name = "barButtonItem23"
        '
        'barButtonItem24
        '
        Me.barButtonItem24.Caption = "Phiếu nhập khẩu"
        Me.barButtonItem24.Id = 42
        Me.barButtonItem24.Name = "barButtonItem24"
        '
        'barButtonItem25
        '
        Me.barButtonItem25.Caption = "Phiếu nhập chi phí mua hàng"
        Me.barButtonItem25.Id = 43
        Me.barButtonItem25.Name = "barButtonItem25"
        '
        'barButtonItem27
        '
        Me.barButtonItem27.Caption = "Phiếu xuất trả Nhà cung cấp"
        Me.barButtonItem27.Id = 45
        Me.barButtonItem27.Name = "barButtonItem27"
        '
        'barButtonItem28
        '
        Me.barButtonItem28.Caption = "Hóa đơn mua hàng (dịch vụ)"
        Me.barButtonItem28.Id = 46
        Me.barButtonItem28.Name = "barButtonItem28"
        '
        '_KhaiBaoCacButToanPhanBoTuDong
        '
        Me._KhaiBaoCacButToanPhanBoTuDong.Caption = "Khai báo Bút toán Phân bổ tự động"
        Me._KhaiBaoCacButToanPhanBoTuDong.Id = 3
        Me._KhaiBaoCacButToanPhanBoTuDong.Name = "_KhaiBaoCacButToanPhanBoTuDong"
        '
        '_KhaiBaoCacButToanKetChuyenTuDong
        '
        Me._KhaiBaoCacButToanKetChuyenTuDong.Caption = "Khai báo Bút toán Kết chuyển tự động"
        Me._KhaiBaoCacButToanKetChuyenTuDong.Id = 4
        Me._KhaiBaoCacButToanKetChuyenTuDong.Name = "_KhaiBaoCacButToanKetChuyenTuDong"
        '
        '_DanhMucTaiKhoan
        '
        Me._DanhMucTaiKhoan.Caption = "Danh mục Tài khoản"
        Me._DanhMucTaiKhoan.Id = 5
        Me._DanhMucTaiKhoan.Name = "_DanhMucTaiKhoan"
        '
        '_DanhMucTaiKhoanNganHang
        '
        Me._DanhMucTaiKhoanNganHang.Caption = "Danh mục Tài khoản Ngân hàng"
        Me._DanhMucTaiKhoanNganHang.Id = 6
        Me._DanhMucTaiKhoanNganHang.Name = "_DanhMucTaiKhoanNganHang"
        '
        '_DanhMucKhachHang
        '
        Me._DanhMucKhachHang.Caption = "Danh mục Khách hàng"
        Me._DanhMucKhachHang.Id = 7
        Me._DanhMucKhachHang.Name = "_DanhMucKhachHang"
        '
        '_DanhMucThueSuat
        '
        Me._DanhMucThueSuat.Caption = "Danh mục Thuế suất"
        Me._DanhMucThueSuat.Id = 8
        Me._DanhMucThueSuat.Name = "_DanhMucThueSuat"
        '
        '_DanhMucPhongBan
        '
        Me._DanhMucPhongBan.Caption = "Danh mục Phòng ban"
        Me._DanhMucPhongBan.Id = 9
        Me._DanhMucPhongBan.Name = "_DanhMucPhongBan"
        '
        '_DanhMucHangHoaVatTu
        '
        Me._DanhMucHangHoaVatTu.Caption = "Danh mục hàng hóa vật tư"
        Me._DanhMucHangHoaVatTu.Id = 10
        Me._DanhMucHangHoaVatTu.Name = "_DanhMucHangHoaVatTu"
        '
        '_DanhMucKhoHang
        '
        Me._DanhMucKhoHang.Caption = "Danh mục kho hàng"
        Me._DanhMucKhoHang.Id = 11
        Me._DanhMucKhoHang.Name = "_DanhMucKhoHang"
        '
        '_DanhMucTaiSanCoDinh
        '
        Me._DanhMucTaiSanCoDinh.Caption = "Danh mục Tài sản cố định"
        Me._DanhMucTaiSanCoDinh.Id = 12
        Me._DanhMucTaiSanCoDinh.Name = "_DanhMucTaiSanCoDinh"
        '
        '_DieuChinhGiaTriTaiSan
        '
        Me._DieuChinhGiaTriTaiSan.Caption = "Ðiều chỉnh Giá trị tài sản"
        Me._DieuChinhGiaTriTaiSan.Id = 13
        Me._DieuChinhGiaTriTaiSan.Name = "_DieuChinhGiaTriTaiSan"
        '
        '_DanhMucNguonVonTSCD
        '
        Me._DanhMucNguonVonTSCD.Caption = "Danh mục Nguồn vốn"
        Me._DanhMucNguonVonTSCD.Id = 14
        Me._DanhMucNguonVonTSCD.Name = "_DanhMucNguonVonTSCD"
        '
        '_DanhMucLyDoTangGiamTSCD
        '
        Me._DanhMucLyDoTangGiamTSCD.Caption = "Danh mục Lý do tăng giảm TSCÐ"
        Me._DanhMucLyDoTangGiamTSCD.Id = 15
        Me._DanhMucLyDoTangGiamTSCD.Name = "_DanhMucLyDoTangGiamTSCD"
        '
        '_DanhMucBoPhanSuDungTSCD
        '
        Me._DanhMucBoPhanSuDungTSCD.Caption = "Danh mục Bộ phận sử dụng TSCÐ"
        Me._DanhMucBoPhanSuDungTSCD.Id = 16
        Me._DanhMucBoPhanSuDungTSCD.Name = "_DanhMucBoPhanSuDungTSCD"
        '
        '_DanhMucNhomTSCD
        '
        Me._DanhMucNhomTSCD.Caption = "Danh mục Nhóm TSCÐ"
        Me._DanhMucNhomTSCD.Id = 17
        Me._DanhMucNhomTSCD.Name = "_DanhMucNhomTSCD"
        '
        'barButtonItem15
        '
        Me.barButtonItem15.Caption = "barButtonItem15"
        Me.barButtonItem15.Id = 18
        Me.barButtonItem15.Name = "barButtonItem15"
        '
        '_DanhMucPhanNhomTaiSan
        '
        Me._DanhMucPhanNhomTaiSan.Caption = "Danh mục Phân nhóm Tài sản"
        Me._DanhMucPhanNhomTaiSan.Id = 19
        Me._DanhMucPhanNhomTaiSan.Name = "_DanhMucPhanNhomTaiSan"
        '
        'barButtonItem17
        '
        Me.barButtonItem17.Caption = "Danh mục khách hàng"
        Me.barButtonItem17.Id = 20
        Me.barButtonItem17.Name = "barButtonItem17"
        '
        'barButtonItem18
        '
        Me.barButtonItem18.Caption = "barButtonItem18"
        Me.barButtonItem18.Id = 21
        Me.barButtonItem18.Name = "barButtonItem18"
        '
        'barButtonItem1
        '
        Me.barButtonItem1.Caption = "Phiếu kế toán"
        Me.barButtonItem1.Id = 22
        Me.barButtonItem1.Name = "barButtonItem1"
        '
        'barButtonItem26
        '
        Me.barButtonItem26.Caption = "Giao dịch"
        Me.barButtonItem26.Id = 48
        Me.barButtonItem26.Name = "barButtonItem26"
        '
        'barSubItem4
        '
        Me.barSubItem4.Caption = "barSubItem4"
        Me.barSubItem4.Id = 49
        Me.barSubItem4.Name = "barSubItem4"
        '
        'barSubItem5
        '
        Me.barSubItem5.Caption = "barSubItem5"
        Me.barSubItem5.Id = 50
        Me.barSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barToolbarsListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barMdiChildrenListItem1, True)})
        Me.barSubItem5.Name = "barSubItem5"
        '
        'barToolbarsListItem1
        '
        Me.barToolbarsListItem1.Caption = "barToolbarsListItem1"
        Me.barToolbarsListItem1.Id = 51
        Me.barToolbarsListItem1.Name = "barToolbarsListItem1"
        '
        'barMdiChildrenListItem1
        '
        Me.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1"
        Me.barMdiChildrenListItem1.Id = 52
        Me.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1"
        '
        'barSubItem6
        '
        Me.barSubItem6.Caption = "gg"
        Me.barSubItem6.Id = 53
        Me.barSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem7, True)})
        Me.barSubItem6.Name = "barSubItem6"
        '
        'barSubItem7
        '
        Me.barSubItem7.Caption = "gggg]"
        Me.barSubItem7.Id = 54
        Me.barSubItem7.Name = "barSubItem7"
        '
        '_PhieuKeToan
        '
        Me._PhieuKeToan.Caption = "Phiếu kế toán"
        Me._PhieuKeToan.Id = 59
        Me._PhieuKeToan.Name = "_PhieuKeToan"
        '
        '_PhieuThuTienMat
        '
        Me._PhieuThuTienMat.Caption = "Phiếu thu tiền mặt"
        Me._PhieuThuTienMat.Id = 60
        Me._PhieuThuTienMat.Name = "_PhieuThuTienMat"
        '
        '_PhieuChiTienMat
        '
        Me._PhieuChiTienMat.Caption = "Phiếu chi Tiền mặt"
        Me._PhieuChiTienMat.Id = 61
        Me._PhieuChiTienMat.Name = "_PhieuChiTienMat"
        '
        '_PhieuThuTienMatNgoaiTeTheoTiGiaHachToan
        '
        Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan.Caption = "Phiếu thu Tiền mặt Ngoại tệ theo Tỷ giá hạch toán"
        Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan.Id = 62
        Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan.Name = "_PhieuThuTienMatNgoaiTeTheoTiGiaHachToan"
        '
        '_PhieuChiTienMatNgoaiTeTheoTiGiaHachToan
        '
        Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan.Caption = "Phiếu chi Tiền mặt ngoại tệ theo Tỷ giá hạch toán"
        Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan.Id = 63
        Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan.Name = "_PhieuChiTienMatNgoaiTeTheoTiGiaHachToan"
        '
        '_PhieuNhapHangBanBiTraLai
        '
        Me._PhieuNhapHangBanBiTraLai.Caption = "Phiếu nhập hàng bán bị trả lại"
        Me._PhieuNhapHangBanBiTraLai.Id = 64
        Me._PhieuNhapHangBanBiTraLai.Name = "_PhieuNhapHangBanBiTraLai"
        '
        '_PhieuThuDatCoc
        '
        Me._PhieuThuDatCoc.Caption = "Phiếu thu Đặt cọc"
        Me._PhieuThuDatCoc.Id = 65
        Me._PhieuThuDatCoc.Name = "_PhieuThuDatCoc"
        '
        '_PhieuNhapMuaHang
        '
        Me._PhieuNhapMuaHang.Caption = "Phiếu nhập Mua hàng"
        Me._PhieuNhapMuaHang.Id = 66
        Me._PhieuNhapMuaHang.Name = "_PhieuNhapMuaHang"
        '
        '_PhieuNhapKhau
        '
        Me._PhieuNhapKhau.Caption = "Phiếu nhập khẩu"
        Me._PhieuNhapKhau.Id = 67
        Me._PhieuNhapKhau.Name = "_PhieuNhapKhau"
        '
        '_PhieuNhapChiPhiMuaHang
        '
        Me._PhieuNhapChiPhiMuaHang.Caption = "Phiếu nhập chi phí mua hàng"
        Me._PhieuNhapChiPhiMuaHang.Id = 68
        Me._PhieuNhapChiPhiMuaHang.Name = "_PhieuNhapChiPhiMuaHang"
        '
        '_PhieuXuatTraLaiNhaCungCap
        '
        Me._PhieuXuatTraLaiNhaCungCap.Caption = "Phiếu xuất Trả lại nhà cung cấp"
        Me._PhieuXuatTraLaiNhaCungCap.Id = 69
        Me._PhieuXuatTraLaiNhaCungCap.Name = "_PhieuXuatTraLaiNhaCungCap"
        '
        '_PhieuThanhToanTamUng
        '
        Me._PhieuThanhToanTamUng.Caption = "Phiếu thanh toán Tạm ứng"
        Me._PhieuThanhToanTamUng.Id = 70
        Me._PhieuThanhToanTamUng.Name = "_PhieuThanhToanTamUng"
        '
        '_PhieuNhapKho
        '
        Me._PhieuNhapKho.Caption = "Phiếu nhập kho"
        Me._PhieuNhapKho.Id = 71
        Me._PhieuNhapKho.Name = "_PhieuNhapKho"
        '
        '_PhieuXuatKho
        '
        Me._PhieuXuatKho.Caption = "Phiếu xuất kho"
        Me._PhieuXuatKho.Id = 72
        Me._PhieuXuatKho.Name = "_PhieuXuatKho"
        '
        '_PhieuDieuchuyen
        '
        Me._PhieuDieuchuyen.Caption = "Phiếu điều chuyển"
        Me._PhieuDieuchuyen.Id = 73
        Me._PhieuDieuchuyen.Name = "_PhieuDieuchuyen"
        '
        '_ButToanPhanBoTuDong
        '
        Me._ButToanPhanBoTuDong.Caption = "Khai báo bút toán phân bổ tự động"
        Me._ButToanPhanBoTuDong.Id = 74
        Me._ButToanPhanBoTuDong.Name = "_ButToanPhanBoTuDong"
        '
        '_ButToanKetChuyenTuDong
        '
        Me._ButToanKetChuyenTuDong.Caption = "Bút toán kết chuyển tự động"
        Me._ButToanKetChuyenTuDong.Id = 75
        Me._ButToanKetChuyenTuDong.Name = "_ButToanKetChuyenTuDong"
        '
        '_GiayBaoCoNganHang
        '
        Me._GiayBaoCoNganHang.Caption = "Giấy báo có Ngân hàng"
        Me._GiayBaoCoNganHang.Id = 76
        Me._GiayBaoCoNganHang.Name = "_GiayBaoCoNganHang"
        '
        '_GiayBaoNoNganHang
        '
        Me._GiayBaoNoNganHang.Caption = "Giấy báo nợ Ngân hàng"
        Me._GiayBaoNoNganHang.Id = 77
        Me._GiayBaoNoNganHang.Name = "_GiayBaoNoNganHang"
        '
        '_GiayBaoCoNGoaiTeTheoTiGiaHachToan
        '
        Me._GiayBaoCoNGoaiTeTheoTiGiaHachToan.Caption = "Giấy báo có Ngoại tệ theo tỷ giá hạch toán"
        Me._GiayBaoCoNGoaiTeTheoTiGiaHachToan.Id = 78
        Me._GiayBaoCoNGoaiTeTheoTiGiaHachToan.Name = "_GiayBaoCoNGoaiTeTheoTiGiaHachToan"
        '
        '_GiayBaoNoNgoaiTeTheoTiGiaHachToan
        '
        Me._GiayBaoNoNgoaiTeTheoTiGiaHachToan.Caption = "Giấy báo nợ Ngoại tệ theo Tỷ giá hạch toán"
        Me._GiayBaoNoNgoaiTeTheoTiGiaHachToan.Id = 79
        Me._GiayBaoNoNgoaiTeTheoTiGiaHachToan.Name = "_GiayBaoNoNgoaiTeTheoTiGiaHachToan"
        '
        '_HoaDonBanHangKiemPhieuXuatKho
        '
        Me._HoaDonBanHangKiemPhieuXuatKho.Caption = "Hóa don bán hàng kiêm Phiếu xuất kho"
        Me._HoaDonBanHangKiemPhieuXuatKho.Id = 80
        Me._HoaDonBanHangKiemPhieuXuatKho.Name = "_HoaDonBanHangKiemPhieuXuatKho"
        '
        '_HoaDonMuaHangDichVu
        '
        Me._HoaDonMuaHangDichVu.Caption = "Hóa đơn mua hàng dịch vụ"
        Me._HoaDonMuaHangDichVu.Id = 81
        Me._HoaDonMuaHangDichVu.Name = "_HoaDonMuaHangDichVu"
        '
        '_ChungTuPhaiThuBuTruCongNo
        '
        Me._ChungTuPhaiThuBuTruCongNo.Caption = "Chứng từ phải thu, bù trừ công nợ"
        Me._ChungTuPhaiThuBuTruCongNo.Id = 82
        Me._ChungTuPhaiThuBuTruCongNo.Name = "_ChungTuPhaiThuBuTruCongNo"
        '
        '_ChungTuPhaiTraBuTruCongNo
        '
        Me._ChungTuPhaiTraBuTruCongNo.Caption = "Chứng từ phải trả, bù trừ công nợ"
        Me._ChungTuPhaiTraBuTruCongNo.Id = 83
        Me._ChungTuPhaiTraBuTruCongNo.Name = "_ChungTuPhaiTraBuTruCongNo"
        '
        'barButtonItem54
        '
        Me.barButtonItem54.Caption = "Administrator"
        Me.barButtonItem54.Id = 84
        Me.barButtonItem54.Name = "barButtonItem54"
        '
        '_DanhMucDonViTinh
        '
        Me._DanhMucDonViTinh.Caption = "Danh mục Đơn vị tính"
        Me._DanhMucDonViTinh.Id = 95
        Me._DanhMucDonViTinh.Name = "_DanhMucDonViTinh"
        '
        '_DanhMucNgoaiTe
        '
        Me._DanhMucNgoaiTe.Caption = "Danh mục Ngoại tệ"
        Me._DanhMucNgoaiTe.Id = 96
        Me._DanhMucNgoaiTe.Name = "_DanhMucNgoaiTe"
        '
        '_DanhMucKho
        '
        Me._DanhMucKho.Caption = "Danh mục Kho"
        Me._DanhMucKho.Id = 97
        Me._DanhMucKho.Name = "_DanhMucKho"
        '
        '_DanhMucVuViec
        '
        Me._DanhMucVuViec.Caption = "Danh mục Vụ việc"
        Me._DanhMucVuViec.Id = 98
        Me._DanhMucVuViec.Name = "_DanhMucVuViec"
        '
        '_DanhMucHangHoa
        '
        Me._DanhMucHangHoa.Caption = "Danh mục hàng hóa"
        Me._DanhMucHangHoa.Id = 99
        Me._DanhMucHangHoa.Name = "_DanhMucHangHoa"
        '
        '_f
        '
        Me._f.Caption = "barButtonItem29"
        Me._f.Id = 100
        Me._f.Name = "_f"
        '
        'barSubItem12
        '
        Me.barSubItem12.Caption = "Bút toán"
        Me.barSubItem12.Id = 101
        Me.barSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._KhaiBaoCacButToanPhanBoTuDong), New DevExpress.XtraBars.LinkPersistInfo(Me._KhaiBaoCacButToanKetChuyenTuDong), New DevExpress.XtraBars.LinkPersistInfo(Me._QuanLyNgoaiTe)})
        Me.barSubItem12.Name = "barSubItem12"
        '
        '_QuanLyNgoaiTe
        '
        Me._QuanLyNgoaiTe.Caption = "Quản lý tỷ giá Ngoại tệ"
        Me._QuanLyNgoaiTe.Id = 147
        Me._QuanLyNgoaiTe.Name = "_QuanLyNgoaiTe"
        '
        'barSubItem13
        '
        Me.barSubItem13.Caption = "Tài khoản"
        Me.barSubItem13.Id = 102
        Me.barSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTaiKhoan), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTaiKhoanNganHang)})
        Me.barSubItem13.Name = "barSubItem13"
        '
        '_TSCD
        '
        Me._TSCD.Caption = "Tài sản cố định"
        Me._TSCD.Id = 103
        Me._TSCD.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucNguonVonTSCD), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTaiSanCoDinh), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucNhomTSCD), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucLyDoTangGiamTSCD), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucBoPhanSuDungTSCD), New DevExpress.XtraBars.LinkPersistInfo(Me._DieuChinhGiaTriTaiSan), New DevExpress.XtraBars.LinkPersistInfo(Me._KhaiBaoGiamTaiSan), New DevExpress.XtraBars.LinkPersistInfo(Me._DieuChuyenTSCD)})
        Me._TSCD.Name = "_TSCD"
        '
        '_KhaiBaoGiamTaiSan
        '
        Me._KhaiBaoGiamTaiSan.Caption = "Khai báo giảm tài sản"
        Me._KhaiBaoGiamTaiSan.Id = 150
        Me._KhaiBaoGiamTaiSan.Name = "_KhaiBaoGiamTaiSan"
        '
        '_DieuChuyenTSCD
        '
        Me._DieuChuyenTSCD.Caption = "Điều chuyển TSCĐ"
        Me._DieuChuyenTSCD.Id = 152
        Me._DieuChuyenTSCD.Name = "_DieuChuyenTSCD"
        '
        'Da
        '
        Me.Da.Caption = "Khác"
        Me.Da.Id = 104
        Me.Da.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._DMNhomKHang), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucKhachHang), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucThueSuat), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucDonVi), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucPhongBan), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucHangHoa), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucPhanNhomTaiSan), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucDonViTinh), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucNgoaiTe), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucKho), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucVuViec), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucKieuXe), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucXe), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucCanBoCongNhanVien), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucCongViecSuaChua), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucHopDong), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucPhuongThucQuanTri), New DevExpress.XtraBars.LinkPersistInfo(Me._DMLoaiChungTu), New DevExpress.XtraBars.LinkPersistInfo(Me._DMKhoanPhi)})
        Me.Da.Name = "Da"
        '
        '_DMNhomKHang
        '
        Me._DMNhomKHang.Caption = "Danh mục nhóm khách hàng"
        Me._DMNhomKHang.Id = 148
        Me._DMNhomKHang.Name = "_DMNhomKHang"
        '
        '_DanhMucDonVi
        '
        Me._DanhMucDonVi.Caption = "Danh mục Đơn vị"
        Me._DanhMucDonVi.Id = 120
        Me._DanhMucDonVi.Name = "_DanhMucDonVi"
        '
        '_DanhMucKieuXe
        '
        Me._DanhMucKieuXe.Caption = "Danh mục Kiểu xe"
        Me._DanhMucKieuXe.Id = 121
        Me._DanhMucKieuXe.Name = "_DanhMucKieuXe"
        '
        '_DanhMucXe
        '
        Me._DanhMucXe.Caption = "Danh mục Xe"
        Me._DanhMucXe.Id = 122
        Me._DanhMucXe.Name = "_DanhMucXe"
        '
        '_DanhMucCanBoCongNhanVien
        '
        Me._DanhMucCanBoCongNhanVien.Caption = "Danh mục Nhân viên"
        Me._DanhMucCanBoCongNhanVien.Id = 123
        Me._DanhMucCanBoCongNhanVien.Name = "_DanhMucCanBoCongNhanVien"
        '
        '_DanhMucCongViecSuaChua
        '
        Me._DanhMucCongViecSuaChua.Caption = "Danh mục Công việc sửa chữa"
        Me._DanhMucCongViecSuaChua.Id = 124
        Me._DanhMucCongViecSuaChua.Name = "_DanhMucCongViecSuaChua"
        '
        '_DanhMucHopDong
        '
        Me._DanhMucHopDong.Caption = "Danh mục Hợp đồng"
        Me._DanhMucHopDong.Id = 125
        Me._DanhMucHopDong.Name = "_DanhMucHopDong"
        '
        '_DanhMucPhuongThucQuanTri
        '
        Me._DanhMucPhuongThucQuanTri.Caption = "Danh mục Phương thức Quản trị"
        Me._DanhMucPhuongThucQuanTri.Id = 126
        Me._DanhMucPhuongThucQuanTri.Name = "_DanhMucPhuongThucQuanTri"
        '
        '_DMLoaiChungTu
        '
        Me._DMLoaiChungTu.Caption = "Danh mục Loại chứng từ"
        Me._DMLoaiChungTu.Id = 131
        Me._DMLoaiChungTu.Name = "_DMLoaiChungTu"
        '
        '_DMKhoanPhi
        '
        Me._DMKhoanPhi.Caption = "Danh mục khoản chi"
        Me._DMKhoanPhi.Id = 136
        Me._DMKhoanPhi.Name = "_DMKhoanPhi"
        '
        'barSubItem15
        '
        Me.barSubItem15.Caption = "Phiếu chi"
        Me.barSubItem15.Id = 105
        Me.barSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuChiTienMat), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuChiTienMatNgoaiTeTheoTiGiaHachToan), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuNhapChiPhiMuaHang), New DevExpress.XtraBars.LinkPersistInfo(Me._NhapSoDuTaiKhoan)})
        Me.barSubItem15.Name = "barSubItem15"
        '
        '_NhapSoDuTaiKhoan
        '
        Me._NhapSoDuTaiKhoan.Caption = "Nhập số dư ban đầu tài khoản"
        Me._NhapSoDuTaiKhoan.Id = 144
        Me._NhapSoDuTaiKhoan.Name = "_NhapSoDuTaiKhoan"
        '
        'barSubItem16
        '
        Me.barSubItem16.Caption = "Phiếu thu"
        Me.barSubItem16.Id = 106
        Me.barSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuThuTienMat), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuThuTienMatNgoaiTeTheoTiGiaHachToan), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuThuDatCoc)})
        Me.barSubItem16.Name = "barSubItem16"
        '
        'barSubItem17
        '
        Me.barSubItem17.Caption = "Khác"
        Me.barSubItem17.Id = 107
        Me.barSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuThanhToanTamUng), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuKeToan), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuDieuchuyen)})
        Me.barSubItem17.Name = "barSubItem17"
        '
        'barSubItem18
        '
        Me.barSubItem18.Caption = "Phiếu nhập"
        Me.barSubItem18.Id = 108
        Me.barSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuNhapKho), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuNhapMuaHang), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuNhapKhau), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuNhapHangBanBiTraLai), New DevExpress.XtraBars.LinkPersistInfo(Me._NhapSoDuDauNam)})
        Me.barSubItem18.Name = "barSubItem18"
        '
        '_NhapSoDuDauNam
        '
        Me._NhapSoDuDauNam.Caption = "Nhập số dư kho đầu năm"
        Me._NhapSoDuDauNam.Id = 151
        Me._NhapSoDuDauNam.Name = "_NhapSoDuDauNam"
        '
        'barSubItem19
        '
        Me.barSubItem19.Caption = "Phiếu xuất"
        Me.barSubItem19.Id = 109
        Me.barSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuXuatKho), New DevExpress.XtraBars.LinkPersistInfo(Me._PhieuXuatTraLaiNhaCungCap), New DevExpress.XtraBars.LinkPersistInfo(Me._TinhGiaXuatKho)})
        Me.barSubItem19.Name = "barSubItem19"
        '
        '_TinhGiaXuatKho
        '
        Me._TinhGiaXuatKho.Caption = "Tính giá xuất kho"
        Me._TinhGiaXuatKho.Id = 161
        Me._TinhGiaXuatKho.Name = "_TinhGiaXuatKho"
        '
        'barSubItem20
        '
        Me.barSubItem20.Caption = "Nhóm vật tư"
        Me.barSubItem20.Id = 110
        Me.barSubItem20.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._NhomVatTu1), New DevExpress.XtraBars.LinkPersistInfo(Me._NhomVatTu2), New DevExpress.XtraBars.LinkPersistInfo(Me._NhomVatTu3)})
        Me.barSubItem20.Name = "barSubItem20"
        '
        '_NhomVatTu1
        '
        Me._NhomVatTu1.Caption = "Nhóm vật tư 1"
        Me._NhomVatTu1.Id = 111
        Me._NhomVatTu1.Name = "_NhomVatTu1"
        '
        '_NhomVatTu2
        '
        Me._NhomVatTu2.Caption = "Nhóm vật tư 2"
        Me._NhomVatTu2.Id = 143
        Me._NhomVatTu2.Name = "_NhomVatTu2"
        '
        '_NhomVatTu3
        '
        Me._NhomVatTu3.Caption = "Nhóm vật tư 3"
        Me._NhomVatTu3.Id = 113
        Me._NhomVatTu3.Name = "_NhomVatTu3"
        '
        'barSubItem21
        '
        Me.barSubItem21.Caption = "Danh mục tự do"
        Me.barSubItem21.Id = 114
        Me.barSubItem21.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTuDo1), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTuDo2), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTuDo3), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTuDo4), New DevExpress.XtraBars.LinkPersistInfo(Me._DanhMucTuDo5)})
        Me.barSubItem21.Name = "barSubItem21"
        '
        '_DanhMucTuDo1
        '
        Me._DanhMucTuDo1.Caption = "Danh mục Tự do 1"
        Me._DanhMucTuDo1.Id = 119
        Me._DanhMucTuDo1.Name = "_DanhMucTuDo1"
        '
        '_DanhMucTuDo2
        '
        Me._DanhMucTuDo2.Caption = "Danh mục Tự do 2"
        Me._DanhMucTuDo2.Id = 115
        Me._DanhMucTuDo2.Name = "_DanhMucTuDo2"
        '
        '_DanhMucTuDo3
        '
        Me._DanhMucTuDo3.Caption = "Danh mục Tự do 3"
        Me._DanhMucTuDo3.Id = 116
        Me._DanhMucTuDo3.Name = "_DanhMucTuDo3"
        '
        '_DanhMucTuDo4
        '
        Me._DanhMucTuDo4.Caption = "Danh mục Tự do 4"
        Me._DanhMucTuDo4.Id = 117
        Me._DanhMucTuDo4.Name = "_DanhMucTuDo4"
        '
        '_DanhMucTuDo5
        '
        Me._DanhMucTuDo5.Caption = "Danh mục Tự do 5"
        Me._DanhMucTuDo5.Id = 118
        Me._DanhMucTuDo5.Name = "_DanhMucTuDo5"
        '
        '_InDanhMuc
        '
        Me._InDanhMuc.Caption = "Dữ liệu báo cáo"
        Me._InDanhMuc.Id = 130
        Me._InDanhMuc.Name = "_InDanhMuc"
        '
        'BarSubItem23
        '
        Me.BarSubItem23.Caption = "QLBDSC"
        Me.BarSubItem23.Id = 139
        Me.BarSubItem23.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me._LenhPhuTung), New DevExpress.XtraBars.LinkPersistInfo(Me._LenhSuaChua)})
        Me.BarSubItem23.Name = "BarSubItem23"
        '
        '_LenhPhuTung
        '
        Me._LenhPhuTung.Caption = "Lệnh phụ tùng"
        Me._LenhPhuTung.Id = 140
        Me._LenhPhuTung.Name = "_LenhPhuTung"
        '
        '_LenhSuaChua
        '
        Me._LenhSuaChua.Caption = "Lệnh sửa chữa"
        Me._LenhSuaChua.Id = 141
        Me._LenhSuaChua.Name = "_LenhSuaChua"
        '
        '_ThucHienPhanBoTuDong
        '
        Me._ThucHienPhanBoTuDong.Caption = "Thực hiện phân bổ tự động"
        Me._ThucHienPhanBoTuDong.Id = 142
        Me._ThucHienPhanBoTuDong.Name = "_ThucHienPhanBoTuDong"
        '
        '_ThietLapMenu
        '
        Me._ThietLapMenu.Caption = "Thiết lập danh mục chức năng"
        Me._ThietLapMenu.Id = 150
        Me._ThietLapMenu.Name = "_ThietLapMenu"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Nothing
        Me.BarEditItem1.Id = 156
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Login"
        Me.BarButtonItem29.Id = 157
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Exit"
        Me.BarButtonItem30.Id = 158
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        '_CloseAllVisible
        '
        Me._CloseAllVisible.Caption = "Đóng tất cả công việc"
        Me._CloseAllVisible.Id = 162
        Me._CloseAllVisible.Name = "_CloseAllVisible"
        '
        'siGrantPermission
        '
        Me.siGrantPermission.Caption = "Phân quyền"
        Me.siGrantPermission.Enabled = False
        Me.siGrantPermission.Id = 163
        Me.siGrantPermission.Name = "siGrantPermission"
        Me.siGrantPermission.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'siDataTransfer
        '
        Me.siDataTransfer.Caption = "Data Transfer Demo"
        Me.siDataTransfer.Id = 175
        Me.siDataTransfer.Name = "siDataTransfer"
        '
        'xtraTabbedMdiManager1
        '
        Me.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.xtraTabbedMdiManager1.MdiParent = Me
        '
        'defaultLookAndFeel
        '
        Me.defaultLookAndFeel.LookAndFeel.SkinName = "Blue"
        '
        'bar4
        '
        Me.bar4.BarName = "StatusBar"
        Me.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar4.DockCol = 0
        Me.bar4.DockRow = 0
        Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar4.FloatLocation = New System.Drawing.Point(25, 282)
        Me.bar4.FloatSize = New System.Drawing.Size(29, 21)
        Me.bar4.OptionsBar.AllowQuickCustomization = False
        Me.bar4.OptionsBar.DrawDragBorder = False
        Me.bar4.OptionsBar.DrawSizeGrip = True
        Me.bar4.OptionsBar.RotateWhenVertical = False
        Me.bar4.OptionsBar.UseWholeRow = True
        Me.bar4.Text = "StatusBar"
        '
        'bar1
        '
        Me.bar1.BarName = "StatusBar"
        Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar1.FloatLocation = New System.Drawing.Point(25, 282)
        Me.bar1.FloatSize = New System.Drawing.Size(29, 21)
        Me.bar1.OptionsBar.AllowQuickCustomization = False
        Me.bar1.OptionsBar.DrawDragBorder = False
        Me.bar1.OptionsBar.DrawSizeGrip = True
        Me.bar1.OptionsBar.RotateWhenVertical = False
        Me.bar1.OptionsBar.UseWholeRow = True
        Me.bar1.Text = "StatusBar"
        '
        'iStatus1
        '
        Me.iStatus1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.iStatus1.Caption = "Ready"
        Me.iStatus1.CategoryGuid = New System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")
        Me.iStatus1.Id = 50
        Me.iStatus1.Name = "iStatus1"
        Me.iStatus1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.iStatus1.Width = 695
        '
        '_barUpdateSoftware
        '
        Me._barUpdateSoftware.Caption = "Cập nhật phần mềm"
        Me._barUpdateSoftware.Id = 180
        Me._barUpdateSoftware.Name = "_barUpdateSoftware"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 890)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hệ thống Kế toán"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private barSubItem1 As DevExpress.XtraBars.BarSubItem
    Private barSubItem3 As DevExpress.XtraBars.BarSubItem
    Private _KhaiBaoCacButToanPhanBoTuDong As DevExpress.XtraBars.BarButtonItem
    Private _KhaiBaoCacButToanKetChuyenTuDong As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTaiKhoan As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTaiKhoanNganHang As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucKhachHang As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucThueSuat As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucPhongBan As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucHangHoaVatTu As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucKhoHang As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTaiSanCoDinh As DevExpress.XtraBars.BarButtonItem
    Private _DieuChinhGiaTriTaiSan As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucNguonVonTSCD As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucLyDoTangGiamTSCD As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucBoPhanSuDungTSCD As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucNhomTSCD As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucPhanNhomTaiSan As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Private barSubItem4 As DevExpress.XtraBars.BarSubItem
    Private barSubItem5 As DevExpress.XtraBars.BarSubItem
    Private barToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
    Private barMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
    Private barSubItem6 As DevExpress.XtraBars.BarSubItem
    Private barSubItem7 As DevExpress.XtraBars.BarSubItem
    Private _PhieuKeToan As DevExpress.XtraBars.BarButtonItem
    Private _PhieuThuTienMat As DevExpress.XtraBars.BarButtonItem
    Private _PhieuChiTienMat As DevExpress.XtraBars.BarButtonItem
    Private _PhieuThuTienMatNgoaiTeTheoTiGiaHachToan As DevExpress.XtraBars.BarButtonItem
    Private _PhieuChiTienMatNgoaiTeTheoTiGiaHachToan As DevExpress.XtraBars.BarButtonItem
    Private _PhieuNhapHangBanBiTraLai As DevExpress.XtraBars.BarButtonItem
    Private _PhieuThuDatCoc As DevExpress.XtraBars.BarButtonItem
    Private _PhieuNhapMuaHang As DevExpress.XtraBars.BarButtonItem
    Private _PhieuNhapKhau As DevExpress.XtraBars.BarButtonItem
    Private _PhieuNhapChiPhiMuaHang As DevExpress.XtraBars.BarButtonItem
    Private _PhieuXuatTraLaiNhaCungCap As DevExpress.XtraBars.BarButtonItem
    Private _PhieuThanhToanTamUng As DevExpress.XtraBars.BarButtonItem
    Private _PhieuNhapKho As DevExpress.XtraBars.BarButtonItem
    Private _PhieuXuatKho As DevExpress.XtraBars.BarButtonItem
    Private _PhieuDieuchuyen As DevExpress.XtraBars.BarButtonItem
    Private _GiayBaoCoNganHang As DevExpress.XtraBars.BarButtonItem
    Private _GiayBaoNoNganHang As DevExpress.XtraBars.BarButtonItem
    Private _GiayBaoCoNGoaiTeTheoTiGiaHachToan As DevExpress.XtraBars.BarButtonItem
    Private _GiayBaoNoNgoaiTeTheoTiGiaHachToan As DevExpress.XtraBars.BarButtonItem
    Private _HoaDonBanHangKiemPhieuXuatKho As DevExpress.XtraBars.BarButtonItem
    Private _HoaDonMuaHangDichVu As DevExpress.XtraBars.BarButtonItem
    Private _ButToanPhanBoTuDong As DevExpress.XtraBars.BarButtonItem
    Private _ButToanKetChuyenTuDong As DevExpress.XtraBars.BarButtonItem
    Private _ChungTuPhaiThuBuTruCongNo As DevExpress.XtraBars.BarButtonItem
    Private _ChungTuPhaiTraBuTruCongNo As DevExpress.XtraBars.BarButtonItem
    Private soAdmin As DevExpress.XtraBars.BarSubItem
    Private soLogin As DevExpress.XtraBars.BarButtonItem
    Private siLogOut As DevExpress.XtraBars.BarButtonItem
    Private siAdminChangePass As DevExpress.XtraBars.BarButtonItem
    Private barButtonItem54 As DevExpress.XtraBars.BarButtonItem
    Private siUserManagement As DevExpress.XtraBars.BarButtonItem
    Private siFreezeData As DevExpress.XtraBars.BarButtonItem
    Private siUserActionReport As DevExpress.XtraBars.BarButtonItem
    Private soAdminDatabaseSettings As DevExpress.XtraBars.BarButtonItem
    Private soExit As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucDonViTinh As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucNgoaiTe As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucKho As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucVuViec As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucHangHoa As DevExpress.XtraBars.BarButtonItem
    Private _f As DevExpress.XtraBars.BarButtonItem
    Private barSubItem12 As DevExpress.XtraBars.BarSubItem
    Private barSubItem13 As DevExpress.XtraBars.BarSubItem
    Private _TSCD As DevExpress.XtraBars.BarSubItem
    Private Da As DevExpress.XtraBars.BarSubItem
    Private barSubItem15 As DevExpress.XtraBars.BarSubItem
    Private barSubItem16 As DevExpress.XtraBars.BarSubItem
    Private barSubItem17 As DevExpress.XtraBars.BarSubItem
    Private barSubItem18 As DevExpress.XtraBars.BarSubItem
    Private barSubItem19 As DevExpress.XtraBars.BarSubItem
    Private barSubItem20 As DevExpress.XtraBars.BarSubItem
    Private _NhomVatTu1 As DevExpress.XtraBars.BarButtonItem

    Private _NhomVatTu3 As DevExpress.XtraBars.BarButtonItem
    Private barSubItem21 As DevExpress.XtraBars.BarSubItem
    Private _DanhMucTuDo2 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTuDo3 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTuDo4 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTuDo5 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucTuDo1 As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucDonVi As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucKieuXe As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucXe As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucCanBoCongNhanVien As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucCongViecSuaChua As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucHopDong As DevExpress.XtraBars.BarButtonItem
    Private _DanhMucPhuongThucQuanTri As DevExpress.XtraBars.BarButtonItem
    Private adminReport As DevExpress.XtraBars.BarSubItem
    Private _InDanhMuc As DevExpress.XtraBars.BarButtonItem
    Private _DMLoaiChungTu As DevExpress.XtraBars.BarButtonItem
    Private _frmTreeBaoCao As DevExpress.XtraBars.BarButtonItem
    Public xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Public defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private bar4 As DevExpress.XtraBars.Bar
    Private bar1 As DevExpress.XtraBars.Bar
    Private barGuide As DevExpress.XtraBars.BarStaticItem
    Private barClientDate As DevExpress.XtraBars.BarStaticItem
    Private iStatus1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents _DMKhoanPhi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem23 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents _LenhPhuTung As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _LenhSuaChua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _ThucHienPhanBoTuDong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _NhomVatTu2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _NhapSoDuTaiKhoan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _QuanLyNgoaiTe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _DMNhomKHang As DevExpress.XtraBars.BarButtonItem
    Public WithEvents barMenu As DevExpress.XtraBars.Bar
    Public WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents barBottom As DevExpress.XtraBars.Bar

    Friend WithEvents _ThietLapMenu As DevExpress.XtraBars.BarButtonItem

    Friend WithEvents _KhaiBaoGiamTaiSan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _NhapSoDuDauNam As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _DieuChuyenTSCD As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    'Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _TinhGiaXuatKho As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _CloseAllVisible As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siGrantPermission As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barClientDonVi As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents siDonviGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siDonviGroupUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siDonviGroupForm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siDonviBaocao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siDonviGroupBaocao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents siDataTransfer As DevExpress.XtraBars.BarButtonItem
    Public WithEvents barClientNamKT As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents _barTeamview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _barUpdateSoftware As DevExpress.XtraBars.BarButtonItem
End Class
