using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain.Report
{
    public class BcKeToanKhoDTO
    {
        public String KyHieuLoaiCt { get; set; }
        public DateTime NgayCt { get; set; }
        public Guid HanghoaId { get; set; }
        public String MaTknGiavon { get; set; }
        public String MaTkcGiavon { get; set; }
        public Guid KhoNhapId { get; set; }
        public Guid KhoXuatId { get; set; }

        public String MaTk { get; set; }
        public Guid KhoId { get; set; }
        public String MaHopdong { get; set; }

        public Int32 Cang { get; set; }

        public String MaTheoDoi { get; set; }

        public String MaVuviec { get; set; }
        public Decimal SoLuongNhap { get; set; }
        public Decimal SoLuongXuat { get; set; }

        public Guid TypeId { get; set; }
        public Guid ApplicationId { get; set; }
        public Decimal DiaLy { get; set; }

        public String KhuVuc { get; set; }

    }

    public class DonGiaDTO
    {
        public Guid HanghoaId { get; set; }
        public Guid TypeId { get; set; }
        public Guid ApplicationId { get; set; }
        public String Type { get; set; }
        public String Application { get; set; }
        public String ProductName { get; set; }

        public String MaNghiepVu { get; set; }

        public Guid KhoId { get; set; }
        public String MaHopdong { get; set; }
        public String MaVuviec { get; set; }
        public String Status { get; set; }
        public Decimal SoLuongTon { get; set; }
        public Decimal Price { get; set; }
        public String Desciption { get; set; }
        public String Note { get; set; }
        public Decimal DiaLy { get; set; }

        public Int32 Cang { get; set; }

        public String KhuVuc { get; set; }

        public DonGiaDTO(BcKeToanKhoDTO nhap, BcKeToanKhoDTO xuat)
        {
            HanghoaId = nhap.HanghoaId;
            MaNghiepVu = nhap.MaTknGiavon;
            KhoId = nhap.KhoNhapId;
            MaHopdong = nhap.MaHopdong;
            MaVuviec = nhap.MaVuviec;
            SoLuongTon = nhap.SoLuongNhap - xuat.SoLuongXuat;
            Cang = nhap.Cang;
        }

        public DonGiaDTO(BcKeToanKhoDTO nhap)
        {
            HanghoaId = nhap.HanghoaId;
            MaNghiepVu = nhap.MaTknGiavon;
            KhoId = nhap.KhoNhapId;
            MaHopdong = nhap.MaHopdong;
            MaVuviec = nhap.MaVuviec;
            SoLuongTon = nhap.SoLuongNhap;
            Cang = nhap.Cang;
        }
    }
}
