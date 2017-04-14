using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS07DnDTO
    {
        public virtual Guid CthId { get; set; }
        public virtual Guid CtdId { get; set; }
        //private DateTime _NgayCt = DateTime.Now.Date;
        public virtual DateTime NgayCt
        {
            get;
            set;
        }
        public virtual DateTime NgayGhi { get; set; }
        public virtual String MaTk { get; set; }
        public virtual String MaTkDu { get; set; }
        public virtual Guid DonviId { get; set; }
        public virtual String CtSoNo { get; set; }
        public virtual String CtSoCo { get; set; }
        public virtual String CtSo
        {
            get { return String.IsNullOrEmpty(CtSoNo) ? CtSoCo : CtSoNo; }
        }
        public virtual String DienGiai { get; set; }
        public virtual Decimal PsNo { get; set; }
        public virtual Decimal PsCo { get; set; }
        public virtual Decimal SoTon { get; set; }
        public virtual Decimal DuNo { get; set; }
        public virtual Decimal DuCo { get; set; }
        public virtual Int32 Nhom { get; set; }
        public virtual Guid IdLoaiCt { get; set; }
    }

    public class RpLedgerComparer : IComparer<RpLedgerS07DnDTO>
    {
        public int Compare(RpLedgerS07DnDTO x, RpLedgerS07DnDTO y)
        {
            if (x == null)
            {
                if (y == null)
                    //x = null, y = null => x = y
                    return 0;
                else
                    return -1;
            }
            else
            {
                //x <> null, y = null => x > y
                if (y == null) return 1;
                else
                {
                    if (x.NgayCt.Date >= y.NgayCt.Date)
                        if (x.NgayCt.Date == y.NgayCt.Date)
                        {
                            if (x.PsNo > y.PsNo)
                                //x.PsNo > y.PsNo => x < y
                                return -1;
                            else
                                //x.PsNo = y.PsNo => x = y
                                if (x.PsNo == y.PsNo) return 0;
                                else return 1; // x > y
                        }
                        else
                            return 1; //x > y
                    else
                        return -1; //x < y
                }
            }
        }
    }
}
