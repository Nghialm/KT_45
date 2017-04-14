using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS06DnDTO
    {

        public virtual Guid TkId { get; set; }
        public virtual String MaTk { get; set; }
        public virtual String TenTk { get; set; }
        public virtual String MaTkDu { get; set; }
        public virtual String TenTkDu { get; set; }
        public virtual Decimal DuNoDk { get; set; }
        public virtual Decimal DuCoDk { get; set; }
        public virtual Decimal PsNoTk { get; set; }
        public virtual Decimal PsCoTk { get; set; }
        public virtual Decimal DuNoCk { get; set; }
        public virtual Decimal DuCoCk { get; set; }
        public virtual Decimal Cap { get; set; }
        public virtual Decimal ChiTiet { get; set; }
        public virtual Int32 SortOrder { get; set; }
    }
}
