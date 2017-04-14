using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Spa.Domain
{
    public class SpaRpThanhToanTheDTO
    {
        public virtual DateTime Ngayphathanh { get; set; }
        public virtual DateTime Ngayban { get; set; }
        public virtual DateTime Ngayhethan { get; set; }
        public virtual Guid TheId { get; set; }
        public virtual String MaThe { get; set; }

        public virtual Decimal SoTien { get; set; }
        public virtual Decimal MenhGia { get; set; }

        public virtual DateTime Ngaythanhtoan { get; set; }
        public virtual Decimal TienThe { get; set; }
        public virtual Decimal TienKhuyenMai { get; set; }
        public virtual String Tenkhachhang { get; set; }
        public virtual String NoiDungThanhToan { get; set; }
    }
}
