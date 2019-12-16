using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class BcKetoanKho : DomainObject<System.Guid>
    {
        #region Extend Property
        public virtual Decimal SoTienConLai { get; set; }
        public virtual Decimal DonGiaXuat
        {
            get
            {
                Decimal DonGiaXuat = GiaVon + SoTienThueXnk + SoTienThueTtdb;
                return DonGiaXuat / SoLuong;
            }
        }

        public virtual Decimal SoTienXuat
        {
            get
            {
                Decimal SoTienXuat = GiaVon + SoTienThueXnk + SoTienThueTtdb;
                return SoTienXuat;
            }
        }
        #endregion

        public BcKetoanKho(CtHNx objcth, CtDNx objctd)
        {
            CthNxId = objcth.Id;
            DonviId = objcth.DonviId;
            MaDonvi = objcth.MaDonvi;
            DonviCt = objcth.DonviCt;
            MaDonviCt = objcth.MaDonviCt;
            IdLoaiCt = objcth.IdLoaiCt;
            MaLoaiCt = objcth.MaLoaiCt;
            KyHieuLoaiCt = objcth.KyHieuLoaiCt;
            NgayGhi = objcth.NgayGhi;
            CtSo = objcth.CtSo;
            QuyenSo = objcth.QuyenSo;
            NgayCt = objcth.NgayCt;
            NteId = objcth.NteId;
            MaNte = objcth.MaNte;
            TyGia = objcth.TyGia;
            DienGiai = objcth.DienGiai;
            NguoiNhanNopTien = objcth.NguoiNhanNopTien;
            NguoiGiaoNhanHang = objcth.NguoiGiaoNhanHang;
            SoHoadon = objcth.SoHoadon;
            SoSeri = objcth.SoSeri;
            NgayHoadon = objcth.NgayHoadon;
            Ghi = objcth.Ghi;
            XuatKhau = objcth.XuatKhau;
            NgoaiTe = objcth.NgoaiTe;

            CtdNxId = objctd.Id;
            HanghoaId = objctd.HanghoaId;
            MaHanghoa = objctd.MaHanghoa;
            KyHieuHanghoa = objctd.KyHieuHanghoa;
            TenHanghoa = objctd.TenHanghoa;
            DonGiaVon = objctd.DonGiaVon;
            DonGiaVonNte = objctd.DonGiaVonNte;
            SoLuong = objctd.SoLuong;
            GiaVon = objctd.GiaVon;
            GiaVonNt = objctd.GiaVonNt;
            DvtId = objctd.DvtId;
            MaDvt = objctd.MaDvt;
            TenDvt = objctd.TenDvt;
            NgayTao = objctd.NgayTao;
            NgaySx = objctd.NgaySx;
            Xuat = objctd.Xuat;
            TknGiavon = objctd.TknGiavon;
            MaTknGiavon = objctd.MaTknGiavon;
            TkcGiavon = objctd.TkcGiavon;
            MaTkcGiavon = objctd.MaTkcGiavon;
            TknGiaban = objctd.TknGiaban;
            MaTknGiaban = objctd.MaTknGiaban;
            TkcGiaban = objctd.TkcGiaban;
            MaTkcGiaban = objctd.MaTkcGiaban;
            TyLeThueGtgt = objctd.TyLeThueGtgt;
            SoTienThueGtgt = objctd.SoTienThueGtgt;
            TknThueGtgt = objctd.TknThueGtgt;
            MaTknThueGtgt = objctd.MaTknThueGtgt;
            TkcThueGtgt = objctd.TkcThueGtgt;
            MaTkcThueGtgt = objctd.MaTkcThueGtgt;
            TyLeThueXnk = objctd.TyLeThueXnk;
            SoTienThueXnk = objctd.SoTienThueXnk;
            TknThueXnk = objctd.TknThueXnk;
            MaTknThueXnk = objctd.MaTknThueXnk;
            TkcThueXnk = objctd.TkcThueXnk;
            MaTkcThueXnk = objctd.MaTkcThueXnk;
            TyLeThueTtdb = objctd.TyLeThueTtdb;
            SoTienThueTtdb = objctd.SoTienThueTtdb;
            TknThueTtdb = objctd.TknThueTtdb;
            MaTknThueTtdb = objctd.MaTknThueTtdb;
            TkcThueTtdb = objctd.TkcThueTtdb;
            MaTkcThueTtdb = objctd.MaTkcThueTtdb;
            SoTienCk = objctd.SoTienCk;
            TknCk = objctd.TknCk;
            MaTknCk = objctd.MaTknCk;
            TkcCk = objctd.TkcCk;
            MaTkcCk = objctd.MaTkcCk;
            SoTienGiamgia = objctd.SoTienGiamgia;
            TknGiamgia = objctd.TknGiamgia;
            MaTknGiamgia = objctd.MaTknGiamgia;
            TkcGiamgia = objctd.TkcGiamgia;
            MaTkcGiamgia = objctd.MaTkcGiamgia;
            SoTienHoahong = objctd.SoTienHoahong;
            TknHoahong = objctd.TknHoahong;
            MaTknHoahong = objctd.MaTknHoahong;
            TkcHoahong = objctd.TkcHoahong;
            MaTkcHoahong = objctd.MaTkcHoahong;
            SoTienLephi = objctd.SoTienLephi;
            TknLephi = objctd.TknLephi;
            MaTknLephi = objctd.MaTknLephi;
            TkcLephi = objctd.TkcLephi;
            MaTkcLephi = objctd.MaTkcLephi;
            IdKhang = objctd.IdKhang;
            MaKhang = objctd.MaKhang;
            HopdongId = objctd.HopdongId;
            MaHopdong = objctd.MaHopdong;
            KyHieuHopdong = objctd.KyHieuHopdong;
            TenHopdong = objctd.TenHopdong;

            IdDmPtqtNo = objctd.IdDmPtqtNo;
            //MADMPTQTNO =	OBJDMPTQTNO.MADM;
            //KYHIEUDMPTQTNO =	OBJDMPTQTNO.KYHIEU;
            //TENDMPTQTNO =	OBJDMPTQTNO.TEN;
            IdDmPtqtCo = objctd.IdDmPtqtCo;
            //MADMPTQTCO =	OBJDMPTQTCO.MADM;
            //KYHIEUDMPTQTCO =	OBJDMPTQTCO.KYHIEU;
            //TENDMPTQTCO =	OBJDMPTQTCO.TEN;
            IdDmPhongbanNo = objctd.IdDmPhongbanNo;
            IdDmPhongbanCo = objctd.IdDmPhongbanCo;
            IdCtGhiso = objctd.IdCtGhiso;
            MaCtGhisoSo = objctd.MaCtGhisoSo;
            CtGhisoTrichyeu = objctd.CtGhisoTrichyeu;
            CtGhisoNgay = objctd.CtGhisoNgay;
            DaGhiso = objctd.DaGhiso;
            VuviecId = objctd.VuviecId;
            KyHieuVuviec = objctd.KyHieuVuviec;
            MaVuviec = objctd.MaVuviec;
            TenVuviec = objctd.TenVuviec;
            IdDmTudo1No = objctd.IdDmTudo1No;
            //MADMTUDO1NO =	OBJDMTUDO1NO.MADM;
            //KYHIEUDMTUDO1NO =	OBJDMTUDO1NO.KYHIEU;
            //TENDMTUDO1NO =	OBJDMTUDO1NO.TEN;
            IdDmTudo1Co = objctd.IdDmTudo1Co;
            //MADMTUDO1CO =	OBJDMTUDO1CO.MADM;
            //KYHIEUDMTUDO1CO =	OBJDMTUDO1CO.KYHIEU;
            //TENDMTUDO1CO =	OBJDMTUDO1CO.TEN;
            IdDmTudo2No = objctd.IdDmTudo2No;
            //MADMTUDO2NO =	OBJDMTUDO2NO.MADM;
            //KYHIEUDMTUDO2NO =	OBJDMTUDO2NO.KYHIEU;
            //TENDMTUDO2NO =	OBJDMTUDO2NO.TEN;
            IdDmTudo2Co = objctd.IdDmTudo2Co;
            //MADMTUDO2CO =	OBJDMTUDO2CO.MADM;
            //KYHIEUDMTUDO2CO =	OBJDMTUDO2CO.KYHIEU;
            //TENDMTUDO2CO =	OBJDMTUDO2CO.TEN;
            IdDmTudo3No = objctd.IdDmTudo3No;
            //MADMTUDO3NO =	OBJDMTUDO3NO.MADM;
            //KYHIEUDMTUDO3NO =	OBJDMTUDO3NO.KYHIEU;
            //TENDMTUDO3NO =	OBJDMTUDO3NO.TEN;
            IdDmTudo3Co = objctd.IdDmTudo3Co;
            //MADMTUDO3CO =	OBJDMTUDO3CO.MADM;
            //KYHIEUDMTUDO3CO =	OBJDMTUDO3CO.KYHIEU;
            //TENDMTUDO3CO =	OBJDMTUDO3CO.TEN;
            IdDmTudo4No = objctd.IdDmTudo4No;
            //MADMTUDO4NO =	OBJDMTUDO4NO.MADM;
            //KYHIEUDMTUDO4NO =	OBJDMTUDO4NO.KYHIEU;
            //TENDMTUDO4NO =	OBJDMTUDO4NO.TEN;
            IdDmTudo4Co = objctd.IdDmTudo4Co;
            //MaDmTudo4Co =	OBJDMTUDO4CO.MADM;
            //KYHIEUDMTUDO4CO =	OBJDMTUDO4CO.KYHIEU;
            //TENDMTUDO4CO =	OBJDMTUDO4CO.TEN;
            IdDmTudo5No = objctd.IdDmTudo5No;
            //MADMTUDO5NO =	OBJDMTUDO5NO.MADM;
            //KYHIEUDMTUDO5NO =	OBJDMTUDO5NO.KYHIEU;
            //TENDMTUDO5NO =	OBJDMTUDO5NO.TEN;
            IdDmTudo5Co = objctd.IdDmTudo5Co;
            //MADMTUDO5CO =	OBJDMTUDO5CO.MADM;
            //KYHIEUDMTUDO5CO =	OBJDMTUDO5CO.KYHIEU;
            //TENDMTUDO5CO =	OBJDMTUDO5CO.TEN;
            KhoXuatId = objctd.KhoXuatId;
            KhoNhapId = objctd.KhoNhapId;
            DonGiaBan = objctd.DonGiaBan;
            DonGiaBanNte = objctd.DonGiaBanNte;
            SoTienBan = objctd.SoTienBan;
            SoTienBanNte = objctd.SoTienBanNte;
            DuLuong = objctd.SoLuong; //Gan mac dinh khi gen lai BcKeToanKho
            IdDoituong1 = objctd.IdDoituong1;
            MaDoituong1 = objctd.MaDoituong1;
            TenDoituong1 = objctd.TenDoituong1;
            IdDoituong2 = objctd.IdDoituong2;
            MaDoituong2 = objctd.MaDoituong2;
            TenDoituong2 = objctd.TenDoituong2;
            IdDoituong3 = objctd.IdDoituong3;
            MaDoituong3 = objctd.MaDoituong3;
            TenDoituong3 = objctd.TenDoituong3;
            IdDmKhangNo = objctd.IdDmKhangNo;
            MaDmKhangNo = objctd.MaDmKhangNo;
            TenDmKhangNo = objctd.TenDmKhangNo;
            IdDmKhangCo = objctd.IdDmKhangCo;
            MaDmKhangCo = objctd.MaDmKhangCo;
            TenDmKhangCo = objctd.TenDmKhangCo;
            IdDmVuviecNo = objctd.IdDmVuviecNo;
            MaDmVuviecNo = objctd.MaDmVuviecNo;
            TenDmVuviecNo = objctd.TenDmVuviecNo;
            IdDmVuviecCo = objctd.IdDmVuviecCo;
            MaDmVuviecCo = objctd.MaDmVuviecCo;
            TenDmVuviecCo = objctd.TenDmVuviecCo;
            IdDmHopdongNo = objctd.IdDmHopdongNo;
            MaDmHopdongNo = objctd.MaDmHopdongNo;
            //KyHieuDmHopdongNo =	OBJDMHOPDONGNO.KYHIEU;
            TenDmHopdongNo = objctd.TenDmHopdongNo;
            IdDmHopdongCo = objctd.IdDmHopdongCo;
            MaDmHopdongCo = objctd.MaDmHopdongCo;
            //KyHieuDmHopdongCo =	OBJDMHOPDONGCO.KYHIEU;
            TenDmHopdongCo = objctd.TenDmHopdongCo;
            IdDmKhoanphiNo = objctd.IdDmKhoanphiNo;
            //MaDmKhoanphiNo =	OBJDMKHOANPHINO.MADM;
            //KyHieuDmKhoanphiNo =	OBJDMKHOANPHINO.KYHIEU;
            //TenDmKhoanphiNo =	OBJDMKHOANPHINO.TEN;
            IdDmKhoanphiCo = objctd.IdDmKhoanphiCo;
            //MaDmKhoanphiCo =	OBJDMKHOANPHICO.MADM;
            //KyHieuDmKhoanphiCo =	OBJDMKHOANPHICO.KYHIEU;
            //TenDmKhoanphiCo =	OBJDMKHOANPHICO.TEN;
            SoDu = objctd.SoDu;
            IdDoituongHoadon = objctd.IdDoituongHoadon;

            LenhSanXuatNhapId = objctd.LenhSanXuatNhapId;
            LenhSanXuatXuatId = objctd.LenhSanXuatXuatId;
            MaLenhSanXuatNhap = objctd.MaLenhSanXuatNhap;
            MaLenhSanXuatXuat = objctd.MaLenhSanXuatXuat;

            PhanXuongNhapId = objctd.PhanXuongNhapId;
            PhanXuongXuatId = objctd.PhanXuongXuatId;
            MaPhanXuongNhap = objctd.MaPhanXuongNhap;
            MaPhanXuongXuat = objctd.MaPhanXuongXuat;

            Cang = objctd.Cang;
        }

        public List<BcKetoan> GenBcKetoan()
        {
            List<DinhKhoanInfo> lsdk = new List<DinhKhoanInfo>();
            lsdk.Add(new DinhKhoanInfo(TknGiavon, MaTknGiavon, "",
                              TkcGiavon, MaTkcGiavon, "",
                              GiaVon, GiaVonNt, 3));

            if (SoDu == 0 && !String.IsNullOrEmpty(MaTknGiaban))
            {
                lsdk.Add(new DinhKhoanInfo(TknGiaban, MaTknGiaban, "",
                              TkcGiaban, MaTkcGiaban, "",
                              SoTienBan, SoTienBanNte, 4));
            }

            if (SoTienThueGtgt != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknThueGtgt, MaTknThueGtgt, "",
                              TkcThueGtgt, MaTkcThueGtgt, "",
                              SoTienThueGtgt, 0, 1));
            }

            if (SoTienThueTtdb != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknThueTtdb, MaTknThueTtdb, "",
                              TkcThueTtdb, MaTkcThueTtdb, "",
                              SoTienThueTtdb, 0, 6));
            }

            if (SoTienThueXnk != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknThueXnk, MaTknThueXnk, "",
                              TkcThueXnk, MaTkcThueXnk, "",
                              SoTienThueXnk, 0, 5));
            }

            if (SoTienCk != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknCk, MaTknCk, "",
                              TkcCk, MaTkcCk, "",
                              SoTienCk, 0, 7));
            }

            if (SoTienGiamgia != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknGiamgia, MaTknGiamgia, "",
                              TkcGiamgia, MaTkcGiamgia, "",
                              SoTienGiamgia, 0, 0));
            }

            if (SoTienHoahong != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknHoahong, MaTknHoahong, "",
                              TkcHoahong, MaTkcHoahong, "",
                              SoTienHoahong, 0, 0));
            }

            if (SoTienLephi != 0)
            {
                lsdk.Add(new DinhKhoanInfo(TknLephi, MaTknLephi, "",
                              TkcLephi, MaTkcLephi, "",
                              SoTienLephi, 0, 0));
            }

            List<BcKetoan> lstKetoan = new List<BcKetoan>();
            foreach (DinhKhoanInfo tmp in lsdk)
            {
                BcKetoan objkt = new BcKetoan();

                objkt.CthId = CthNxId;
                objkt.CtdId = CtdNxId;
                objkt.DonviId = DonviId;
                objkt.MaDonvi = MaDonvi;
                objkt.IdLoaiCt = IdLoaiCt;
                objkt.MaLoaiCt = MaLoaiCt;
                objkt.KyHieuLoaiCt = KyHieuLoaiCt;
                objkt.NgayGhi = NgayGhi;
                objkt.CtSo = CtSo;
                objkt.NgayCt = NgayCt;
                objkt.NteId = NteId;
                objkt.MaNte = MaNte;
                objkt.TyGia = TyGia;
                objkt.SoTien = tmp.SoTien;
                objkt.SoTienNte = tmp.SoTienNte;
                objkt.TkNoId = tmp.IdTkNo;
                objkt.MaTkNo = tmp.MaTkNo;
                //objkt.TenTkNo = lsdk(indx).TENTKNO;
                objkt.TkCoId = tmp.IdTkCo;
                objkt.MaTkCo = tmp.MaTkCo;
                //objkt.TenTkCo = lsdk(indx).TENTKCO;
                objkt.IdPtqtNo = IdDmPtqtNo;
                //objkt.MAPTQTNO = OBJDMPTQTNO.MADM;
                //objkt.IDPTQTCO = IDDMPTQTCO;

                //objkt.MaPtqtCo = 	OBJDMPTQTCO.MADM;
                objkt.IdPhongbanNo = IdDmPhongbanNo;
                //objkt.MaPhongbanNo = 	OBJDMPHONGBANNO.MADM;
                objkt.IdPhongbanCo = IdDmPhongbanCo;
                //objkt.MaPhongbanCo = 	OBJDMPHONGBANCO.MADM;
                objkt.IdVuviecNo = IdDmVuviecNo;
                //objkt.MaVuviecNo = 	MaDmVuviecNo;
                objkt.IdVuviecCo = IdDmVuviecCo;
                //objkt.MaVuviecCo = 	MaDmVuviecCo;
                objkt.IdDmTudo1No = IdDmTudo1No;
                //objkt.MaDmTudo1No = 	OBJDMTUDO1NO.MADM;
                objkt.IdDmTudo1Co = IdDmTudo1Co;
                //objkt.MaDmTudo1Co = 	OBJDMTUDO1CO.MADM;
                objkt.IdDmTudo2No = IdDmTudo2No;
                //objkt.MaDmTudo2No = 	OBJDMTUDO2NO.MADM;
                objkt.IdDmTudo2Co = IdDmTudo2Co;
                //objkt.MaDmTudo2Co = 	OBJDMTUDO2CO.MADM;
                objkt.IdDmTudo3No = IdDmTudo3No;
                //objkt.MaDmTudo3No = 	OBJDMTUDO3NO.MADM;
                objkt.IdDmTudo3Co = IdDmTudo3Co;
                //objkt.MaDmTudo3Co = 	OBJDMTUDO3CO.MADM;
                objkt.IdDmTudo4No = IdDmTudo4No;
                //objkt.MaDmTudo4No = 	OBJDMTUDO4NO.MADM;
                objkt.IdDmTudo4Co = IdDmTudo4Co;
                //objkt.MaDmTudo4Co = 	OBJDMTUDO4CO.MADM;
                objkt.IdDmTudo5No = IdDmTudo5No;
                //objkt.MaDmTudo5No = 	OBJDMTUDO5NO.MADM;
                objkt.IdDmTudo5Co = IdDmTudo5Co;
                //objkt.MaDmTudo5Co = 	OBJDMTUDO5CO.MADM;
                objkt.LoaiNghiepVu = tmp.LoaiNghiepVu;
                objkt.IdHopdongNo = IdDmHopdongNo;
                //objkt.MaHopdongNo = 	MaDmHopdongNo;
                objkt.IdHopdongCo = IdDmHopdongCo;
                //objkt.MaHopdongCo = 	MaDmHopdongCo;
                objkt.IdKhangNo = IdDmKhangNo;
                objkt.MaKhangNo = MaDmKhangNo;
                objkt.TenKhangNo = TenDmKhangNo;
                objkt.IdKhangCo = IdDmKhangCo;
                objkt.MaKhangCo = MaDmKhangCo;
                objkt.TenKhangCo = TenDmKhangCo;
                objkt.DienGiai = DienGiai;
                objkt.DonviCt = DonviCt;
                objkt.MaDonviCt = MaDonviCt;
                objkt.PhanHe = 1;
                objkt.IdDmKhoanphiNo = IdDmKhoanphiNo;
                //objkt.MaDmKhoanphiNo = 	OBJDMKHOANPHINO.MADM;
                //objkt.KyHieuKhoanphiNo = 	OBJDMKHOANPHINO.KYHIEU;
                //objkt.TenDmKhoanphiNo = 	OBJDMKHOANPHINO.TEN;
                objkt.IdDmKhoanphiCo = IdDmKhoanphiCo;
                //objkt.MaDmKhoanphiCo = 	OBJDMKHOANPHICO.MADM;
                //objkt.KyHieuKhoanphiCo = 	OBJDMKHOANPHICO.KYHIEU;
                //objkt.TenDmKhoanphiCo = 	OBJDMKHOANPHICO.TEN;
                objkt.SoDu = SoDu;
                objkt.IdDoituongHoadon = IdDoituongHoadon;
                //objkt.TongTien = 	Sotie;
                //objkt.TongTienNte = 	H.SOTIENNTE

                lstKetoan.Add(objkt);
            }

            return lstKetoan;
        }

        #region Shipping
        private Int32 _Cang = 0;
        public Int32 Cang
        {
            get { return _Cang; }
            set { _isChanged |= (_Cang != value); _Cang = value; }
        }
        #endregion
    }

    public class DinhKhoanInfo
    {
        public Guid IdTkNo { get; set; }
        public String MaTkNo { get; set; }
        public String TenTkNo { get; set; }
        public Guid IdTkCo { get; set; }
        public String MaTkCo { get; set; }
        public String TenTkCo { get; set; }
        public Decimal SoTien { get; set; }
        public Decimal SoTienNte { get; set; }
        public Decimal LoaiNghiepVu { get; set; }

        public DinhKhoanInfo()
        { }

        public DinhKhoanInfo(Guid _IdTkNo, String _MaTkNo, String _TenTkNo,
            Guid _IdTkCo, String _MaTkCo, String _TenTkCo,
            Decimal _SoTien, Decimal _SoTienNte, Decimal _LoaiNghiepVu)
        {
            IdTkNo = _IdTkNo;
            MaTkNo = _MaTkNo;
            TenTkNo = _TenTkNo;
            IdTkCo = _IdTkCo;
            MaTkCo = _MaTkCo;
            TenTkCo = _TenTkCo;
            SoTien = _SoTien;
            SoTienNte = _SoTienNte;
            LoaiNghiepVu = _LoaiNghiepVu;
        }
    }
}