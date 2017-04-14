using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain.Report
{
    public class SxBkVatLieuDTO
    {
        public Guid KiemKeHId { get; set; }
        public Guid KiemKeDId { get; set; }
        public int LoaiKiemKe { get; set; }
        public Guid LenhSanXuatId { get; set; }
        public String SoLenhSanXuat { get; set; }

        public Guid ToSanXuatId { get; set; }
        public Guid MaToSanXuat { get; set; }
        public Guid TenToSanXUat { get; set; }

        public DateTime NgayKiemKe { get; set; }
        public int CaKiemKe { get; set; }

        public int NghiepVu { get; set; }
        public Guid HanghoaId { get; set; }
        public String MaHanghoa { get; set; }
        public String TenHanghoa { get; set; }

        public Guid DvtId { get; set; }

        public Decimal SoLuong { get; set; }

        public Decimal DanhGia { get; set; }
        public String MoTa { get; set; }

        public Decimal SoLuongNhanKho
        {
            get
            {
                if (LoaiKiemKe == 1) return SoLuong;
                else return 0;
            }
        } //1

        public Decimal SoLuongTraKho
        {
            get
            {
                if (LoaiKiemKe == 2) return SoLuong;
                else return 0;
            }
        } //2

        public Decimal SoLuongSuDung
        {
            get
            {
                if (LoaiKiemKe == 3 || LoaiKiemKe == 4 || LoaiKiemKe ==5) return SoLuong;
                else return 0;
            }
        } //3, 4, 5
    }
}
