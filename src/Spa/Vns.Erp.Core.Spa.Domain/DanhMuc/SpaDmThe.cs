using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Domain
{
	public partial class SpaDmThe : DomainObject<System.Guid>
    {
        public virtual IList<SpaLsThe> LstLsThe { get; set; }

        public virtual BcKetoan GenBcKetoan(DmTaikhoan TkTien, DmTaikhoan TkDoanhThu, DmNgoaite NteDefault, HtLoaichungtu htLct)
        {
            BcKetoan objKeToan = new BcKetoan();

            objKeToan.CthId = Id;
            objKeToan.CtdId = Null.NullGuid;

            objKeToan.CtSo = _Ma;
            objKeToan.NgayCt = _Ngayphathanh;
            objKeToan.DonviId = TkTien.DonviId;
            //objKeToan.MaDonvi = objCtH.MaDonvi;
            //objKeToan.IdLoaiCt = objCtH.IdLoaiCt;
            //objKeToan.MaLoaiCt = objCtH.MaLoaiCt;
            //objKeToan.KyHieuLoaiCt = objCtH.KyHieuLoaiCt;
            objKeToan.NgayGhi = _Ngayphathanh;
            objKeToan.NteId = NteDefault.Id;
            objKeToan.MaNte = NteDefault.MaNte;
            objKeToan.TyGia = 0;
            objKeToan.IdKhangCo = _Khachhangid;
            //objKeToan.MaKhangCo = objCtH.MaKhang;

            objKeToan.SoTien = _Giatien;

            objKeToan.TkNoId = TkTien.Id;
            objKeToan.MaTkNo = TkTien.MaTaikhoan;

            objKeToan.TkCoId = TkDoanhThu.Id;
            objKeToan.MaTkCo = TkDoanhThu.MaTaikhoan;

            objKeToan.DienGiai = "Doanh thu the";
            objKeToan.SoDu = 0;

            return objKeToan;
        }
	}
}