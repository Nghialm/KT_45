using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class BcKetoan : DomainObject<System.Guid>
    {
        public BcKetoan(CtH objcth, CtD objctd)
        {
            this.CthId = objcth.Id;
            this.CtdId = objctd.Id;
            this.DonviId = objcth.DonviId;
            this.MaDonvi = objcth.MaDonvi;
            this.IdLoaiCt = objcth.IdLoaiCt;
            MaLoaiCt = objcth.MaLoaiCt;
            KyHieuLoaiCt = objcth.KyHieuLoaiCt;
            NgayGhi = objcth.NgayGhi.HasValue ?  objcth.NgayGhi.Value : DateTime.Today;
            CtSo = objcth.CtSo;
            NgayCt = objcth.NgayCt.HasValue ? objcth.NgayCt.Value : DateTime.Today;
            NteId = objcth.NteId;
            MaNte = objcth.MaNte;
            TyGia = objcth.TyGia;
            SoTien = objctd.SoTien;
            SoTienNte = objctd.SoTienNte;
            TkNoId = objctd.TkNoId;
            MaTkNo = objctd.MaTkNo;
            TenTkNo = objctd.TenTkNo;
            TkCoId = objctd.TkCoId;
            MaTkCo = objctd.MaTkCo;
            TenTkCo = objctd.TenTkCo;
            IdPtqtNo = objctd.IdDmPtqtNo;
            //MaPtqtNo = objctd.MaDmPtqtNo;
            IdPtqtCo = objctd.IdDmPtqtCo;
            //MaPtqtCo = objctd.MaDmPtqtCo;
            IdPhongbanNo = objctd.IdDmPhongbanNo;
            //MaPhongbanNo = objctd.MaDmPhongbanNo;
            IdPhongbanCo = objctd.IdDmPhongbanCo;
            //MaPhongbanCo = objctd.MaDmPhongbanCo;
            IdVuviecNo = objctd.IdDmVuviecNo;
            MaVuviecNo = objctd.MaVuviecNo;
            IdVuviecCo = objctd.IdDmVuviecCo;
            MaVuviecCo = objctd.MaVuviecCo;
            IdDmTudo1No = objctd.IdDmTudo1No;
            //MaDmTudo1No = objctd.MaDmTuDo1No;
            IdDmTudo1Co = objctd.IdDmTudo1Co;
            //MaDmTudo1Co = objctd.MADM;
            IdDmTudo2No = objctd.IdDmTudo2No;
            //MaDmTudo2No = objctd.MADM;
            IdDmTudo2Co = objctd.IdDmTudo2Co;
            //MaDmTudo2Co = objctd.MADM;
            IdDmTudo3No = objctd.IdDmTudo3No;
            //MaDmTudo3No = objctd.MADM;
            IdDmTudo3Co = objctd.IdDmTudo3Co;
            //MaDmTudo3Co = objctd.MADM;
            IdDmTudo4No = objctd.IdDmTudo4No;
            //MaDmTudo4No = OBJDMTUDO4NO.MADM;
            IdDmTudo4Co = objctd.IdDmTudo4Co;
            //MaDmTudo4Co = objctd.MADM;
            IdDmTudo5No = objctd.IdDmTudo5No;
            //MaDmTudo5No = objctd.MADM;
            IdDmTudo5Co = objctd.IdDmTudo5Co;
            //MaDmTudo5Co = objctd.MADM;
            LoaiNghiepVu = objctd.LoaiNghiepVu;
            IdHopdongNo = objctd.IdDmHopdongNo;
            MaHopdongNo = objctd.MaHopdongNo;
            IdHopdongCo = objctd.IdDmHopdongCo;
            MaHopdongCo = objctd.MaHopdongCo;
            IdKhangNo = objctd.IdKhangNo;
            MaKhangNo = objctd.MaKhangNo;
            TenKhangNo = objctd.TenKhangNo;
            IdKhangCo = objctd.IdKhangCo;
            MaKhangCo = objctd.MaKhangCo;
            TenKhangCo = objctd.TenKhangCo;
            DienGiai = objcth.DienGiai;
            DonviCt = objcth.DonviCt;
            MaDonviCt = objcth.MaDonviCt;
            PhanHe = 0;
            IdDmKhoanphiNo = objctd.IdDmKhoanphiNo;
            //MaDmKhoanphiNo = objctd.Ma;
            //KyHieuKhoanphiNo = objctd.KYHIEU;
            //TenDmKhoanphiNo = objctd.TEN;
            IdDmKhoanphiCo = objctd.IdDmKhoanphiCo;
            //MaDmKhoanphiCo = objctd.MADM;
            //KyHieuKhoanphiCo = objctd.KYHIEU;
            //TenDmKhoanphiCo = objctd.TEN;
            SoDu = objctd.SoDu;
            NguoiNhanNopTien = objcth.NguoiNhanNopTien;
            IdDoituongHoadon = objctd.IdDoituongHoadon;
            TongTien = objcth.SoTien;
            TongTienNte = objcth.SoTienNte;
        }

        public BcKetoan(KtCtHHddv objcth, KtCtDHddv objctd)
        {
 
        }

        public BcKetoan(KtCtHKhac objcth, CtD objctd)
        {
            this.CthId = objcth.Id;
            this.CtdId = objctd.Id;
            this.DonviId = objcth.DonviId;
            this.MaDonvi = objcth.MaDonvi;
            this.IdLoaiCt = objcth.IdLoaiCt;
            MaLoaiCt = objcth.MaLoaiCt;
            KyHieuLoaiCt = objcth.KyHieuLoaiCt;
            NgayGhi = objcth.NgayGhi;
            CtSo = objcth.CtSo;
            NgayCt = objcth.NgayCt;
            NteId = objcth.NteId;
            MaNte = objcth.MaNte;
            TyGia = objcth.TyGia;
            SoTien = objctd.SoTien;
            SoTienNte = objctd.SoTienNte;
            TkNoId = objctd.TkNoId;
            MaTkNo = objctd.MaTkNo;
            TenTkNo = objctd.TenTkNo;
            TkCoId = objctd.TkCoId;
            MaTkCo = objctd.MaTkCo;
            TenTkCo = objctd.TenTkCo;
            IdPtqtNo = objctd.IdDmPtqtNo;
            //MaPtqtNo = objctd.MaDmPtqtNo;
            IdPtqtCo = objctd.IdDmPtqtCo;
            //MaPtqtCo = objctd.MaDmPtqtCo;
            IdPhongbanNo = objctd.IdDmPhongbanNo;
            //MaPhongbanNo = objctd.MaDmPhongbanNo;
            IdPhongbanCo = objctd.IdDmPhongbanCo;
            //MaPhongbanCo = objctd.MaDmPhongbanCo;
            IdVuviecNo = objctd.IdDmVuviecNo;
            MaVuviecNo = objctd.MaVuviecNo;
            IdVuviecCo = objctd.IdDmVuviecCo;
            MaVuviecCo = objctd.MaVuviecCo;
            IdDmTudo1No = objctd.IdDmTudo1No;
            //MaDmTudo1No = objctd.MaDmTuDo1No;
            IdDmTudo1Co = objctd.IdDmTudo1Co;
            //MaDmTudo1Co = objctd.MADM;
            IdDmTudo2No = objctd.IdDmTudo2No;
            //MaDmTudo2No = objctd.MADM;
            IdDmTudo2Co = objctd.IdDmTudo2Co;
            //MaDmTudo2Co = objctd.MADM;
            IdDmTudo3No = objctd.IdDmTudo3No;
            //MaDmTudo3No = objctd.MADM;
            IdDmTudo3Co = objctd.IdDmTudo3Co;
            //MaDmTudo3Co = objctd.MADM;
            IdDmTudo4No = objctd.IdDmTudo4No;
            //MaDmTudo4No = OBJDMTUDO4NO.MADM;
            IdDmTudo4Co = objctd.IdDmTudo4Co;
            //MaDmTudo4Co = objctd.MADM;
            IdDmTudo5No = objctd.IdDmTudo5No;
            //MaDmTudo5No = objctd.MADM;
            IdDmTudo5Co = objctd.IdDmTudo5Co;
            //MaDmTudo5Co = objctd.MADM;
            LoaiNghiepVu = objctd.LoaiNghiepVu;
            IdHopdongNo = objctd.IdDmHopdongNo;
            MaHopdongNo = objctd.MaHopdongNo;
            IdHopdongCo = objctd.IdDmHopdongCo;
            MaHopdongCo = objctd.MaHopdongCo;
            IdKhangNo = objctd.IdKhangNo;
            MaKhangNo = objctd.MaKhangNo;
            TenKhangNo = objctd.TenKhangNo;
            IdKhangCo = objctd.IdKhangCo;
            MaKhangCo = objctd.MaKhangCo;
            TenKhangCo = objctd.TenKhangCo;
            DienGiai = objcth.DienGiai;
            DonviCt = objcth.DonviCt;
            MaDonviCt = objcth.MaDonviCt;
            PhanHe = 0;
            IdDmKhoanphiNo = objctd.IdDmKhoanphiNo;
            //MaDmKhoanphiNo = objctd.Ma;
            //KyHieuKhoanphiNo = objctd.KYHIEU;
            //TenDmKhoanphiNo = objctd.TEN;
            IdDmKhoanphiCo = objctd.IdDmKhoanphiCo;
            //MaDmKhoanphiCo = objctd.MADM;
            //KyHieuKhoanphiCo = objctd.KYHIEU;
            //TenDmKhoanphiCo = objctd.TEN;
            SoDu = objctd.SoDu;
            NguoiNhanNopTien = objcth.NguoiNhanNopTien;
            IdDoituongHoadon = objctd.IdDoituongHoadon;
            TongTien = objcth.SoTien;
            TongTienNte = objcth.SoTienNte;
        }
    }
}