Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Spa.Common

Public Class SpaApplicationInit
    Inherits ApplicationInitGlobal

    Public Property DmTaikhoanService As IDmTaikhoanService
    Public Property DmNgoaiteService As IDmNgoaiteService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
    Public Property DmKhoService As IDmKhoService
    Public Overrides Sub InitGlobal()
        If (SpaGeneral.TkKhoInfo IsNot Nothing) Then Return

        SpaGeneral.TkChietKhauDichVuTheInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TKChietKhauDichVuThe, Generals.DON_VI.Id)
        SpaGeneral.TkDoanhThuDichVuInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkDoanhThuDichVu, Generals.DON_VI.Id)
        SpaGeneral.TkDoanThuBanHangInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkDoanThuBanHang, Generals.DON_VI.Id)
        SpaGeneral.TkTienMatInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkTienMat, Generals.DON_VI.Id)
        SpaGeneral.TkTienNganHangInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkTienNganHang, Generals.DON_VI.Id)
        SpaGeneral.TkTienPhaiThuKhachInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkTienPhaiThuKhach, Generals.DON_VI.Id)
        SpaGeneral.TkDoanhThuChuaThucHienInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkDoanhThuChuaThucHien, Generals.DON_VI.Id)
        SpaGeneral.TkHangHoaInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkHangHoa, Generals.DON_VI.Id)
        SpaGeneral.TkGiaVonInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkGiaVon, Generals.DON_VI.Id)
        SpaGeneral.TkKhoInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkKho, Generals.DON_VI.Id)
        SpaGeneral.TkLuongInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TkLuong, Generals.DON_VI.Id)
        'SpaGeneral.NoiTe = DmNgoaiteService.Get(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri))
        SpaGeneral.LctLuong = HtLoaichungtuService.GetByMA_LOAI_CT(SpaGeneral.MaBangLuong, Generals.DON_VI.Id)
        SpaGeneral.TKChietKhauGiamGiaDvInfo = DmTaikhoanService.GetObjectByMaTK(SpaGeneral.TKChietKhauGiamGiaDv, Generals.DON_VI.Id)

        Dim lst As IList(Of DmKho) = DmKhoService.GetAllByDonviID(Generals.DON_VI.Id)
        If lst Is Nothing Or lst.Count = 0 Then Return

        SpaGeneral.ObjDmKhoDefault = lst(0)
    End Sub
End Class
