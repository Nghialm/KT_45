using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpPhieuKeToanDTO
    {
        public virtual String CtSo { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual String MaTkNo { get; set; }
        public virtual String MaTkCo { get; set; }
        public virtual String NguoiNhanNopTien { get; set; }
        public virtual String DiaChi { get; set; }
        public virtual String DienGiai { get; set; }
        public virtual Decimal SoTien { get; set; }
        public virtual Decimal SoTienNte { get; set; }
        public virtual String TenKhHang { get; set; }

        public RpPhieuKeToanDTO(CtH objCtH, IList<CtD> lstCtD)
        {
            CtSo = objCtH.CtSo;
            NguoiNhanNopTien = objCtH.NguoiNhanNopTien;
            DiaChi = objCtH.DiaChi;
            DienGiai = objCtH.DienGiai;
            TenKhHang =objCtH.TenKhang;
            NgayCt = objCtH.NgayCt.Value;
            foreach (CtD tmp in lstCtD)
            {
                SoTien += tmp.SoTien;
                SoTienNte += tmp.SoTienNte;
                MaTkNo += tmp.MaTkNo + ";";
                MaTkCo += tmp.MaTkCo + ";";
            }
            MaTkNo = MaTkNo.Substring(0, MaTkNo.Length - 1);
            MaTkCo = MaTkCo.Substring(0, MaTkCo.Length - 1);
        }
    }
}
