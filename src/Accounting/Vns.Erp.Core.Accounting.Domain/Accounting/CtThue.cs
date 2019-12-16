using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class CtThue : DomainObject<System.Guid>
    {
        public void SetProperty(CtThue des)
        {
            //ID Field
            //Id = des.Id;
            //Non ID Field
            LoaiTaikhoan = des.LoaiTaikhoan;
            TaikhoanId = des.TaikhoanId;
            MaTaikhoan = des.MaTaikhoan;
            CtdId = des.CtdId;
            KyHieuHd = des.KyHieuHd;
            SoSeri = des.SoSeri;
            NgayHoadon = des.NgayHoadon;
            KhangId = des.KhangId;
            TenKhang = des.TenKhang;
            Mst = des.Mst;
            HangtkId = des.HangtkId;
            TscdId = des.TscdId;
            TenHanghoa = des.TenHanghoa;
            SoLuong = des.SoLuong;
            NgayTao = des.NgayTao;
            ThueId = des.ThueId;
            TenThue = des.TenThue;
            TyLe = des.TyLe;
            ChiuThue = des.ChiuThue;
            DoanhSo = des.DoanhSo;
            DoanhSoNte = des.DoanhSoNte;
            SoTien = des.SoTien;
            SoTienNte = des.SoTienNte;
            GhiChu = des.GhiChu;
            CtTscdId = des.CtTscdId;
            CtHanghoaId = des.CtHanghoaId;
            CtBanhangId = des.CtBanhangId;
            TenNhomChiuThue = des.TenNhomChiuThue;
            NhomChiuThue = des.NhomChiuThue;
            MuaBan = des.MuaBan;
            CtdNxId = des.CtdNxId;
            DonviId = des.DonviId;
            CtHoadonId = des.CtHoadonId;
            CthId = des.CthId;
            PhanHe = des.PhanHe;
        }
        public CtThue(CtDNx tempctdnx, decimal phieuXuat)
        {
            SoLuong = tempctdnx.SoLuong;
            TenDvt = tempctdnx.TenDvt;

            TenHanghoa = tempctdnx.TenHanghoa;
            //CtHoadonId = objctHoaDon.Id;
            PhanHe = 1;
            TyLe = tempctdnx.TyLeThueGtgt;
            LoaiTaikhoan = "C";
            SoTien = tempctdnx.SoTienThueGtgt;
            ThueId = tempctdnx.ThueId;
            TenThue = tempctdnx.TenThue;
            if (phieuXuat == 1)
            {
                //Voi phieu ban hang xuat kho
                DoanhSo = tempctdnx.SoTienBan;
                DonGia = tempctdnx.DonGiaBan;
                MaTaikhoan = tempctdnx.MaTkcThueGtgt;
                TaikhoanId = tempctdnx.TkcThueGtgt;
            }
            else
            {
                //Voi phieu mua hang va mua hang nhap khau
                DoanhSo = tempctdnx.GiaVon;
                DonGia = tempctdnx.DonGiaVon;
                MaTaikhoan = tempctdnx.MaTknThueGtgt;
                TaikhoanId = tempctdnx.TknThueGtgt;
            }
        }
	}
}