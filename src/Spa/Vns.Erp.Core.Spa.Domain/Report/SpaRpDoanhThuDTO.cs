using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Spa.Domain
{
    public class SpaRpDoanhThuDTO
    {
        public virtual Guid CtHHddvId { get; set; }
        public virtual Guid CtDHddvId { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual String CtSo { get; set; }
        public virtual Guid KhangId { get; set; }
        public virtual String TenKhachHang { get; set; }
        public virtual Guid NhomKhang1 { get; set; }
        public virtual String TenNhomKhang1 { get; set; }

        public virtual Decimal DoanhThu { get; set; }
        public virtual Decimal TtTienMat { get; set; }
        public virtual Decimal TtTienNh { get; set; }

        public virtual String MaThe { get; set; }
        public virtual Decimal TtTienThe1 { get; set; }
        public virtual Decimal TheTienThe1 { get; set; }
        public virtual Decimal TheTienKm1 { get; set; }

        public virtual Decimal SoTienGiamGia { get; set; }
        public virtual Decimal SoTienHh { get; set; }

        public virtual String TenHhDv { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DonGia { get; set; }
        public virtual Decimal DoanhThuChiTiet { get; set; }
        public virtual Decimal SoTienGiamGiaChiTiet { get; set; }

        public virtual Decimal LoaiNghiepVu { get; set; }
    }
}
