using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS03Dn_BanHangDTO
    {
        public virtual Guid CthId { get; set; }
        public virtual Guid CtdId { get; set; }
        public virtual String CtSo { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual DateTime NgayGhi { get; set; }
        public virtual Guid DonviId { get; set; }
        public virtual Guid IdLoaiCt { get; set; }

        public virtual String MaTk { get; set; }
        public virtual String MaTkDoanhThu { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DonGiaBan { get; set; }
        public virtual Decimal TienHang { get; set; }

        public virtual String MaTkThueGtgt { get; set; }
        public virtual Decimal TyLeThueGtgt { get; set; }
        public virtual Decimal SoTienThueGtgt { get; set; }

        public virtual String MaTkChiPhi { get; set; }
        public virtual Decimal SoTienChiPhi { get; set; }

        public virtual String MaTkGiaVon { get; set; }
        public virtual Decimal DonGiaVon {get;set;}
        public virtual Decimal SoTienGiaVon { get; set; }

        public virtual Guid KhangId { get; set; }
        public virtual String TenKhang { get; set; }
        public virtual String DienGiai { get; set; }

        public virtual Guid HanghoaId { get; set; }
        public virtual String TenHanghoa { get; set; }

        public virtual Decimal SoTienPhaiThu { get { return TienHang; } }
        public virtual Decimal SoTienHangHoa { get { return TienHang; } }
        public virtual Decimal SoTienThanhPham { get; set; }
        public virtual Decimal SoTienDichVu { get; set; }
    }
}
