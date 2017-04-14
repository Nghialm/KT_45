using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Admin.Domain;
//using Vns.Erp.Core.ad

namespace Vns.Erp.Core.Accounting.Domain.Extend
{
    public class SoDuKhoInfo
    {
        public virtual DateTime NgayCt { get; set; }

        public virtual Guid CtHNxId { get; set; }
        public virtual Guid CtDNxId { get; set; }

        public virtual Guid KhoNhapId { get; set; }
        public virtual String KyHieuKhoNhap { get; set; }
        public virtual String TenKhoNhap { get; set; }

        public virtual Guid HangHoaId { get; set; }
        public virtual String KyHieuHangHoa { get; set; }
        public virtual String TenHangHoa { get; set; }

        public virtual Guid TkKhoId { get; set; }
        public virtual String MaTkKho { get; set; }
        public virtual String TenTkKho { get; set; }

        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DonGia { get; set; }
        public virtual Decimal ThanhTien { get; set; }

        public SoDuKhoInfo()
        { }

        public SoDuKhoInfo(CtHNx objCtHNx, CtDNx objCtDNx, DmKho objDmKho)
        {
            NgayCt = objCtHNx.NgayCt.Value;

            CtHNxId = objCtHNx.Id;
            CtDNxId = objCtDNx.Id;

            KhoNhapId = objDmKho.Id;
            KyHieuKhoNhap = objDmKho.KyHieu;
            TenKhoNhap = objDmKho.TenKho;

            HangHoaId = objCtDNx.HanghoaId;
            KyHieuHangHoa = objCtDNx.KyHieuHanghoa;
            TenHangHoa = objCtDNx.TenHanghoa;

            TkKhoId = objCtDNx.TknGiavon;
            MaTkKho = objCtDNx.MaTknGiavon;

            SoLuong = objCtDNx.SoLuong;
            DonGia = objCtDNx.DonGiaVon;
            ThanhTien = objCtDNx.GiaVon;
        }
    }
}
