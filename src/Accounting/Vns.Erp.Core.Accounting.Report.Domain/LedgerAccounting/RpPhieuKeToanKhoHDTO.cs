using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpPhieuKeToanKhoHDTO
    {
        public virtual Guid CtHId { get; set; }
        public virtual String TenKhang { get; set; }
        public virtual String CtSo { get; set; }
        public virtual String DiaChi { get; set; }
        public virtual String DienGiai { get; set; }

        public RpPhieuKeToanKhoHDTO(CtHNx objCtHNx)
        {
            CtHId = objCtHNx.Id;
            CtSo = objCtHNx.CtSo;
            DiaChi = objCtHNx.DiaChi;
            DienGiai = objCtHNx.DienGiai;
            TenKhang = objCtHNx.TenKhang;
        }

        public RpPhieuKeToanKhoHDTO(KtCtHHddv  objCthHddv)
        {
            CtHId = objCthHddv.Id;
            CtSo = objCthHddv.CtSo;
            DiaChi = objCthHddv.DiaChi;
            DienGiai = objCthHddv.DienGiai;
            TenKhang = objCthHddv.TenKhang;
        }
    }
}
