using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpKtHDong
    {
        public virtual Decimal ThuTu { get; set; }
        public virtual String ChiTieu { get; set; }
        public virtual String MaSo { get; set; }
        public virtual String ThuyetMinh { get; set; }
        public virtual Decimal C1 { get; set; }
        public virtual Decimal InDong { get; set; }
        public virtual Decimal KieuChu { get; set; }
        public virtual String CachTinh { get; set; }
        public virtual String HamTinh { get; set; }
        public virtual Guid IdDong { get; set; }
        public virtual Decimal Nhom { get; set; }
        public virtual String NhomCot { get; set; } //TS_Khahc

        public RpKtHDong(KtHDong objDong)
        {
            ThuTu = objDong.ThuTu;
            ChiTieu = objDong.ChiTieu;
            MaSo = objDong.MaSo;
            ThuyetMinh = objDong.ThuyetMinh;
            InDong = objDong.InDong;
            KieuChu = objDong.KieuChu;
            CachTinh = objDong.CachTinh;
            HamTinh = objDong.HamTinh;
            IdDong = objDong.Id;
            Nhom = objDong.Nhom;
            NhomCot = objDong.TsKhac;
        }
    }
}
