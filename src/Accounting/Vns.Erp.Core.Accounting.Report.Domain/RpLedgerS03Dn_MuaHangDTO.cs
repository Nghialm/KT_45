using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerS03Dn_MuaHangDTO
    {
        public virtual Guid CthId { get; set; }
        public virtual Guid CtdId { get; set; }
        public virtual String CtSo { get; set; }
        public virtual DateTime NgayCt { get; set; }
        public virtual DateTime NgayGhi { get; set; }
        public virtual Guid DonviId { get; set; }
        public virtual Guid IdLoaiCt { get; set; }
        public virtual String MaTk { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DonGia { get; set; }
        public virtual Decimal TienHang { get; set; }
        public virtual String MaTkKho { get; set; }
        
        public virtual String MaTkThueGtgt { get; set; }
        public virtual Decimal TyLeThueGtgt { get; set; }
        public virtual Decimal SoTienThueGtgt { get; set; }

        public virtual String MaTkThueTtdb { get; set; }
        public virtual Decimal TyLeThueTtdb { get; set; }
        public virtual Decimal SoTienThueTtdb { get; set; }

        public virtual String MaTkThueXnk { get; set; }
        public virtual Decimal TyLeThueXnk { get; set; }
        public virtual Decimal SoTienThueXnk { get; set; }

        public virtual String MaTkChiPhi { get; set; }
        public virtual Decimal SoTienChiPhi { get; set; }

        public virtual Guid KhangId { get; set; }
        public virtual String TenKhang { get; set; }
        public virtual String DienGiai { get; set; }

        public virtual Guid HanghoaId { get; set; }
        public virtual String TenHanghoa { get; set; }

        public virtual Decimal SoTienHangHoa
        {
            get
            { return  MaTk.StartsWith("156") ? TienHang: 0; }
        }

        public virtual Decimal SoTienVatLieu
        {
            get
            { return MaTk.StartsWith("152") ? TienHang : 0; }
        }

        public virtual Decimal SoTienKhac
        {
            get
            {
                if (!MaTk.StartsWith("156") && !MaTk.StartsWith("152"))
                    return TienHang;
                else
                    return 0;
            }
        }

        public virtual Decimal SoTienPhaiTra { get { return TienHang; } }
    }
}
