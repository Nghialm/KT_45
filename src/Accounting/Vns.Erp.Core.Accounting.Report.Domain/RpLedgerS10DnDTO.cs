using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS10DnDTO
    {
        public virtual String SoCtNhap
        {
            get
            {
                switch (Convert.ToInt32(Xuat))
                {
                    case 0:
                        return CtSo;
                    case 1:
                        return "";
                }
                return "";
            }
        }
        public virtual String SoCtXuat
        {
            get
            {
                switch (Convert.ToInt32(Xuat))
                {
                    case 1:
                        return CtSo;
                    case 0:
                        return "";
                }
                return "";
            }
        }
        public virtual String CtSo { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual String DienGiai { get; set; }
        public virtual String MaTk { get; set; }
        public virtual String MaTkDu { get; set; }
        public virtual Decimal DonGia { get { return DonGiaVon; } }
        public virtual Decimal DonGiaVon { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal SlNhap { get; set; }
        public virtual Decimal SoTienNhap { get; set; }
        public virtual Decimal SlXuat { get; set; }
        public virtual Decimal SoTienXuat { get; set; }
        public virtual Decimal SlTon { get; set; }
        public virtual Decimal SoTienTon { get; set; }
        public virtual Guid CthId { get; set; }
        public virtual Guid CtdId { get; set; }
        public virtual Guid HanghoaId { get; set; }
        public virtual String MaHanghoa { get; set; }
        public virtual String TenHanghoa { get; set; }
        public virtual Guid DonviId { get; set; }
        public virtual Guid IdLoaiCt { get; set; }
        public virtual Int32 Nhom { get; set; }
        public virtual Decimal Xuat { get; set; }

    }
}
