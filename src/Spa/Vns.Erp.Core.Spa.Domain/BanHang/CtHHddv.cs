using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
	public partial class CtHHddv : DomainObject<System.Guid>
    {
        public virtual IList<CtDHddv> LstCtHHddv{get;set;}

        public virtual SpaDmGuongdv ObjDmGuong { get; set; }
        public virtual DmKhang ObjDmKhachhang { get; set; }
        public virtual SpaDmThe ObjSpaDmThe { get; set; }

        public virtual BcKetoan GenNghiepVuKeToan(CtHHddv objCtH, IList<CtDHddv> lstCtD)
        {
            BcKetoan objKeToan = new BcKetoan();

            objKeToan.CthId = objCtH.Id;
            objKeToan.CtdId = Null.NullGuid;
            objKeToan.CtSo = objCtH.CtSo;
            objKeToan.NgayCt = objCtH.NgayCt;
            objKeToan.DonviId = objCtH.DonviId;
            objKeToan.MaDonvi = objCtH.MaDonvi;
            objKeToan.IdLoaiCt = objCtH.IdLoaiCt;
            objKeToan.MaLoaiCt = objCtH.MaLoaiCt;
            objKeToan.KyHieuLoaiCt = objCtH.KyHieuLoaiCt;
            objKeToan.NgayGhi = objCtH.NgayGhi;
            objKeToan.NteId = objCtH.NteId;
            objKeToan.MaNte = objCtH.MaNte;
            objKeToan.TyGia = objCtH.TyGia;
            objKeToan.IdKhangCo = objCtH.KhangId;
            objKeToan.MaKhangCo = objCtH.MaKhang;

            objKeToan.DienGiai = objCtH.DienGiai;
            objKeToan.SoDu = 0;

            return objKeToan;
        }

        public virtual IList<BcKetoanKho> GenNghiepVuKeToanKho(CtHHddv objCtH, IList<CtDHddv> lstCtD, DmTaikhoan tkKho, DmTaikhoan tkGiaVon, 
            DmTaikhoan tkDoanhThu, DmTaikhoan tkThanhToan, DmKho objKhoXuat)
        {
            IList<BcKetoanKho> lstBcKho = new List<BcKetoanKho>();
            foreach (CtDHddv tmpD in lstCtD)
            {
                BcKetoanKho bcKho = new BcKetoanKho();
                bcKho.CthNxId = tmpD.CthHddvId;
                bcKho.CtdNxId = tmpD.Id;
                bcKho.DonviId = objCtH.DonviId;
                bcKho.MaDonvi = objCtH.MaDonvi;

                bcKho.IdLoaiCt = objCtH.IdLoaiCt;
                bcKho.MaLoaiCt = objCtH.MaLoaiCt;
                bcKho.KyHieuLoaiCt = objCtH.KyHieuLoaiCt;

                bcKho.NgayGhi = objCtH.NgayGhi;
                bcKho.NgayCt = objCtH.NgayCt;

                bcKho.NteId = objCtH.NteId;
                bcKho.MaNte = objCtH.MaNte;
                bcKho.TyGia = objCtH.TyGia;

                bcKho.DienGiai = objCtH.DienGiai;

                bcKho.Ghi = 1;
                bcKho.XuatKhau = 0;
                bcKho.NgoaiTe = 0;

                bcKho.KhoXuatId = objKhoXuat.Id;
                bcKho.HanghoaId = tmpD.IdHanghoa;
                bcKho.MaHanghoa = string.Empty;
                bcKho.KyHieuHanghoa = string.Empty;
                bcKho.TenHanghoa = tmpD.TenHhDv;
                
                bcKho.SoLuong = tmpD.SoLuong;
                bcKho.DonGiaVon = 0;
                bcKho.DonGiaVonNte = 0;
                bcKho.GiaVon = 0;
                bcKho.GiaVonNt = 0;

                bcKho.DvtId = Null.NullGuid;
                bcKho.Xuat = 1;
                bcKho.SoDu = 0;
                bcKho.DuLuong = tmpD.SoLuong;

                bcKho.IdDmKhangCo = objCtH.KhangId;
                bcKho.TenDmKhangCo = objCtH.TenKhang;

                bcKho.TkcGiavon = tkKho.Id;
                bcKho.MaTkcGiavon = tkKho.MaTaikhoan;

                bcKho.TknGiavon = tkGiaVon.Id;
                bcKho.MaTknGiavon = tkGiaVon.MaTaikhoan;

                lstBcKho.Add(bcKho);
            }

            return lstBcKho;
        }
	}
}