using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain.Report
{
    public class SxBkSanLuongDTO
    {
        public Guid KiemKeHId { get; set; }
        public Guid KiemKeDId { get; set; }
        public int LoaiKiemKe { get; set; }
        public Guid LenhSanXuatId { get; set; }
        public String SoLenhSanXuat { get; set; }

        public Guid ToSanXuatId { get; set; }
        public Guid MaToSanXuat { get; set; }
        public Guid TenToSanXUat { get; set; }

        private DateTime _NgayKiemKe;
        public DateTime NgayKiemKe 
        {
            get
            {
                return _NgayKiemKe.Date;
            }
            set
            {
                _NgayKiemKe = value;
            }
        }
        public int CaKiemKe { get; set; }

        public int NghiepVu { get; set; }
        public Guid HanghoaId { get; set; }
        public String MaHanghoa { get; set; }
        public String TenHanghoa { get; set; }

        public Guid DvtId { get; set; }

        public Decimal SoLuong { get; set; }

        public Decimal SoLuongSanXuat
        {
            get
            {
                if (LoaiKiemKe == 1) return SoLuong;
                else return 0;
            }
        } //1
        public Decimal SoLuongHong
        {
            get
            {
                if (LoaiKiemKe == 3) return SoLuong;
                else return 0;
            }
        } //3
        public Decimal SoLuongNhapKho
        {
            get
            {
                if (LoaiKiemKe == 2) return SoLuong;
                else return 0;
            }
        } //2

        public Decimal DanhGia { get; set; }
        public String MoTa { get; set; }

    }
}
