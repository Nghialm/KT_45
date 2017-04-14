using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS03DnDTO
    {
        public virtual Guid CthId { get; set; }
        public virtual Guid CtdId { get; set; }
        public virtual String CtSo { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual DateTime NgayGhi { get; set; }
        public virtual String MaTk { get; set; }
        public virtual String MaTkDu { get; set; }
        public virtual Guid DonviId { get; set; }
        public virtual Guid KHangId { get; set; }
        public virtual String TenKHang { get; set; }
        public virtual String DienGiai { get; set; }
        public virtual Decimal PsNo { get; set; }
        public virtual Decimal PsCo { get; set; }
        public virtual Decimal SoTon { get; set; }
        public virtual Decimal DuNo { get; set; }
        public virtual Decimal DuCo { get; set; }
        public virtual Int32 Nhom { get; set; }
        public virtual Guid IdLoaiCt { get; set; }
    }
}
