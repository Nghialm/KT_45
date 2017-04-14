using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Domain.Extend
{
    public class SoDuTaiKhoanInfo
    {
        public virtual Decimal SoDu { get; set; }
        public virtual DateTime NgayCt { get; set; }

        public virtual Guid CtHId { get; set; }
        public virtual Guid CtDId { get; set; }

        public virtual Guid TaiKhoanId { get; set; }
        public virtual String MaTaiKhoan { get; set; }
        public virtual String TenTaiKhoan { get; set; }

        public virtual Decimal DuNo { get; set; }
        public virtual Decimal DuCo { get; set; }

        public virtual Decimal DuNoNte { get; set; }
        public virtual Decimal DuCoNte { get; set; }

        public virtual Guid KhachHangId { get; set; }
        public virtual String MaKhachHang { get; set; }
        public virtual String TenKhachHang { get; set; }

        public virtual String NoiDung { get; set; }

        public SoDuTaiKhoanInfo()
        { }

        public SoDuTaiKhoanInfo(CtH objCtH, CtD objCtD)
        {
            SoDu = 1;
            CtHId = objCtH.Id;
            CtDId = objCtD.Id;

            NgayCt = objCtH.NgayCt.Value;

            if (String.IsNullOrEmpty(objCtD.MaTkNo))
            {
                TaiKhoanId = objCtD.TkCoId;
                MaTaiKhoan = objCtD.MaTkCo;
                TenTaiKhoan = objCtD.TenTkCo;

                KhachHangId = objCtD.IdKhangCo;
                MaKhachHang = objCtD.MaKhangCo;
                TenKhachHang = objCtD.TenKhangCo;

                DuCo = objCtD.SoTien;
                DuCoNte = objCtD.SoTienNte;
            }
            else
            {
                TaiKhoanId = objCtD.TkNoId;
                MaTaiKhoan = objCtD.MaTkNo;
                TenTaiKhoan = objCtD.TenTkNo;

                KhachHangId = objCtD.IdKhangNo;
                MaKhachHang = objCtD.MaKhangNo;
                TenKhachHang = objCtD.TenKhangNo;

                DuNo = objCtD.SoTien;
                DuNoNte = objCtD.SoTienNte;
            }

            NoiDung = objCtD.NoiDung;
        }
    }
}
