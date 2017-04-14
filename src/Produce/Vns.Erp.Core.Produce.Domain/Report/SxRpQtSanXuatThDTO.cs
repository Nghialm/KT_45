using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain.Report
{
    public class SxRpQtSanXuatThDTO
    {
        public SxRpQtSanXuatThDTO()
        { }

        public SxRpQtSanXuatThDTO(SxRpQtSanXuatDTO obj)
        {
            KeHoachId = obj.KeHoachId;
            SoKeHoach = obj.SoKeHoach;
            PhanCongId = obj.PhanCongId;

            LenhSanXuatId = obj.LenhSanXuatId;
            SoLenhSanXuat = obj.SoLenhSanXuat;

            KhoNhapId = obj.KhoNhapId;
            KhoXuatId = obj.KhoXuatId;

            HanghoaId = obj.HanghoaId;
            MaHanghoa = obj.MaHanghoa;
            TenHanghoa = obj.TenHanghoa;
            TenDvt = obj.TenDvt;
            Xuat = obj.Xuat;

            PhanXuongId = obj.PhanXuongId;
            MaPhanXuong = obj.MaPhanXuong;

            TenQuytrinh = obj.TenQuytrinh;
        }

        public Guid KeHoachId { get; set; }
        public String SoKeHoach { get; set; }
        public Guid PhanCongId { get; set; }

        public Guid LenhSanXuatId { get; set; }
        public String SoLenhSanXuat { get; set; }

        public Guid KhoNhapId { get; set; }
        public Guid KhoXuatId { get; set; }

        public Guid HanghoaId { get; set; }
        public String MaHanghoa { get; set; }
        public String TenHanghoa { get; set; }
        public String TenDvt { get; set; }

        public Guid PhanXuongId { get; set; }
        public String MaPhanXuong { get; set; }

        public String TenQuytrinh { get; set; }

        /*
         * 0: Nhap kho
         * 1: Xuat kho
         */
        public decimal Xuat { get; set; }

        public Decimal SoLuongKeHoach
        {
            get;
            set;
        }

        public Decimal SoLuongThucTe
        {
            get;
            set;
        }

        #region Extend Display
        public String LenhSanXuat_QuyTrinh
        {
            get
            {
                return SoLenhSanXuat + " - " + TenQuytrinh;
            }
        }

        public String LoaiNhapXuat
        {
            get
            {
                int tmp = Convert.ToInt32(Xuat);
                switch (tmp)
                {
                    case 0:
                        return "Đầu ra";
                    case 1:
                        return "Đầu vào";
                    default:
                        return "";
                }
            }
        }
        #endregion
        

        public string IdGroup
        {
            get
            {
                return KeHoachId.ToString() +
                    LenhSanXuatId.ToString() +
                    Convert.ToInt16(Xuat).ToString() +
                    PhanXuongId.ToString() +
                    HanghoaId.ToString();
            }
        }
    }
}
