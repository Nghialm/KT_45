using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS06DetailDTO
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
        public virtual Decimal DuNoCk
        {
            get
            {
                Decimal du_no = DuNoDk  - DuCoDk + PsNoTk - PsCoTk;
                return du_no >= 0 ? du_no : 0;
            }
        }

        public virtual Decimal DuCoCk
        {
            get
            {
                Decimal du_co = DuCoDk - DuNoDk + PsCoTk - PsNoTk;
                return du_co >= 0 ? du_co : 0;
            }
        }

        public virtual Guid KHangId { get; set; }
        public virtual String KyHieuKhang { get; set; }
        public virtual String TenKhachHang { get; set; }

        public RpLedgerS06DetailDTO()
        { }

        public RpLedgerS06DetailDTO(DmKhang dm)
        {
            KHangId = dm.Id;
            KyHieuKhang = dm.KyHieu;
            TenKhachHang = dm.TenKhang;
        }
        
    }
}
