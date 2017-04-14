using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain.Report
{
    public class SxRpQtSanXuatDTO
    {
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

        /*
         * 1. Ke hoach
         * 2. Thuc te
         */
        public int LoaiKeHoach { get; set; }

        public Guid KeHoachId { get; set; }
        public String SoKeHoach { get; set; }
        public Guid PhanCongId { get; set; }

        public Guid LenhSanXuatId { get; set; }
        public String SoLenhSanXuat { get; set; }

        public Guid CthNxId { get; set; }
        public Guid CtdNxId { get; set; }

        public Guid IdLoaiCt { get; set; }
        public String SoChungTu { get; set; }
        /*Neu loai = 1 se su dung ngay ke hoach*/
        public DateTime NgayKeHoach { get; set; }
        /*Neu loai = 2 se su dung ngay chung tu*/
        private DateTime _NgayChungTu = DateTime.Now.Date;
        public DateTime NgayChungTu 
        {
            get
            {
                return _NgayChungTu.Date;
            }
            set
            {
                _NgayChungTu = value;
            }
        }

        public String DienGiai { get; set; }

        public Guid KhoNhapId { get; set; }
        public Guid KhoXuatId { get; set; }

        public Guid LenhSanXuatNhapId { get; set; }
        public String SoLenhSanXuatNhap { get; set; }
        public Guid LenhSanXuatXuatId { get; set; }
        public String SoLenhSanXuatXuat { get; set; }

        public Guid PhanXuongId { get; set; }
        public String MaPhanXuong { get; set; }
        public Guid PhanXuongNhapId { get; set; }
        public String MaPhanXuongNhap { get; set; }
        public Guid PhanXuongXuatId { get; set; }
        public String MaPhanXuongXuat { get; set; }

        public Guid HanghoaId { get; set; }
        public String MaHanghoa { get; set; }
        public String TenHanghoa { get; set; }
        public String TenDvt { get; set; }

        public Decimal SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal SoTien { get; set; }

        public Decimal SoLuongNhap
        {
            get
            {
                return Xuat == 0 ? SoLuong : 0;
            }
        }


        public Decimal SoTienNhap { get; set; }

        public Decimal SoLuongXuat
        {
            get
            {
                return Xuat == 1 ? SoLuong : 0;
            }
        }

        public Decimal SoTienXuat { get; set; }

        public Guid DonviId { get; set; }
        public String TenSanpham { get; set; }
        /*
         * 0: Nhap kho
         * 1: Xuat kho
         */
        public decimal Xuat { get; set; }

        

        public String LoaiNghiepVu
        {
            get;
            set;
        }

        public String TenQuytrinh
        { get; set; }

        #region Display Extend
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

        public String LenhSanXuat_QuyTrinh
        {
            get 
            {
                return SoLenhSanXuat + " - " + TenQuytrinh;
            }
        }
        #endregion
        #region So sanh
        public static int CompareGroupId(SxRpQtSanXuatDTO x, SxRpQtSanXuatDTO y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval_GroupId = 0;
                    //int revalSoChungTu = 0;
                    retval_GroupId = x.IdGroup.CompareTo(y.IdGroup);
                    return retval_GroupId;
                }
            }
        }
        #endregion
        
    }
}
