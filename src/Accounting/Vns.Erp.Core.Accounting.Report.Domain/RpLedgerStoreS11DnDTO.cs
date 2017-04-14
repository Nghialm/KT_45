using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerStoreS11DnDTO
    {
        public virtual Guid HangHoaId { get; set; }
        public virtual String TenHangHoa { get; set; }
        public virtual Decimal SlTonDauKy { get; set; }
        public virtual Decimal SlNhapTrongKy { get; set; }
        public virtual Decimal SlXuatTrongKy { get; set; }
        public virtual Decimal SlTonCuoiKy
        {
            get
            {
                Decimal tmp = SlTonDauKy + SlNhapTrongKy - SlXuatTrongKy;
                return tmp;
            }
        }

        public virtual Decimal StTonDauKy { get; set; }
        public virtual Decimal StNhapTrongKy { get; set; }
        public virtual Decimal StXuatTrongKy { get; set; }
        public virtual Decimal StTonCuoiKy
        {
            get
            {
                Decimal tmp = StTonDauKy + StNhapTrongKy - StXuatTrongKy;
                return tmp;
            }
        }
        public virtual Guid KhoId { get; set; }
        public virtual String TenKho { get; set; }
    }
}
