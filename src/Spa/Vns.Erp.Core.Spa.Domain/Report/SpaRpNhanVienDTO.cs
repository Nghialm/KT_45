using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Spa.Domain
{
    public class SpaRpNhanVienDTO
    {
        public virtual Guid CtHId { get; set; }
        public virtual Guid CtDId { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual Guid NhanVienID { get; set; }
        public virtual String TenNhanVien { get; set; }
        public virtual Guid KhachHangID { get; set; }
        public virtual String TenKhachHang { get; set; }
        public virtual DateTime TuGio { get; set; }
        public virtual DateTime DenGio { get; set; }
        public virtual Guid GuongID { get; set; }
        public virtual String TenGuong { get; set; }
        public virtual String TenDichVu { get; set; }
        public virtual String NoiDung { get; set; }
        public virtual Decimal DoanhThu { get; set; }
        public virtual Decimal SoTienGiamGia { get; set; }
        public virtual Decimal SoTienHh { get; set; }
        public virtual Decimal TienThuong { get; set; }
        public virtual Decimal ThanhTien { get; set; }
    }
}
