using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpThueDTO
    {
        public virtual String STT { get; set; }
        public virtual String SoHoadon { get; set; }
        public virtual String SoSeri { get; set; }
        public virtual DateTime NgayHoadon { get; set; }
        public virtual String TenKhachhang { get; set; }
        public virtual String MaSoThue { get; set; }
        public virtual String TenHanghoa { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DoanhSo { get; set; }
        public virtual Decimal TyLe { get; set; }
        public virtual Decimal SoTien { get; set; }
        public virtual Decimal DonGia { get; set; }
        public virtual String GhiChu { get; set; }

        /// <summary>
        /// Dung ke khai thue
        /// </summary>
        public virtual Guid ThueId { get; set; }

        /// <summary>
        /// Dung ke khai thue
        /// </summary>
        public virtual String TenThue { get; set; }

        public virtual String Dvt { get; set; }

        public RpThueDTO(CtThue obj)
        {
            TenHanghoa = obj.TenHanghoa;
            SoLuong = obj.SoLuong;
            DoanhSo = obj.DoanhSo;
            TyLe = obj.TyLe;
            SoTien = obj.SoTien;
            DonGia = obj.DonGia;
            GhiChu = obj.GhiChu;
            STT = obj.SoThuTu;
            Dvt = obj.TenDvt;
        }

        public RpThueDTO()
        {
            TenHanghoa = string.Empty;
            SoLuong = Int32.MinValue;
            DoanhSo = Int32.MinValue;
            TyLe = Int32.MinValue;
            SoTien = Int32.MinValue;
            DonGia = Int32.MinValue;
            GhiChu = string.Empty;
            STT = string.Empty;
            Dvt = string.Empty;
        }

       
    }
}
