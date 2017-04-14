using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerAdminDTO
    {
        public Guid CthId
        { get; set; }

        public Guid CtdId
        { get; set; }

        public string MaTk
        { get; set; }

        public string MaTkDu
        { get; set; }

        public DateTime NgayGhi
        { get; set; }

        public DateTime NgayCt
        { get; set; }

        public String CtSo
        { get; set; }

        public String DienGiai
        { get; set; }

        public Decimal PsNo
        { get; set; }

        public Decimal PsCo
        { get; set; }

        public Guid IdLoaiCt
        { get; set; }

        public Guid IdKhang
        { get; set; }

        public Guid IdKhangDu
        { get; set; }
    }
}
