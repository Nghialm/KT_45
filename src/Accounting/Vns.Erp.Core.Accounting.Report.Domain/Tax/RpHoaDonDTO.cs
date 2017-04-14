using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpHoaDonDTO
    {
        public virtual String SoHoadon { get; set; }
        public virtual String SoSeri { get; set; }
        public virtual DateTime NgayHoadon { get; set; }
        public virtual String TenKhachhang { get; set; }
        public virtual String MaSoThue { get; set; }
        public virtual String DienGiai { get; set; }
        public virtual Decimal DoanhThu { get; set; }
        public virtual Decimal TienThue { get; set; }
        public virtual String SoTaiKhoanNh { get; set; }
        public virtual String DiaChiKh { get; set; }
        public virtual String HinhThucTT { get; set; }

        public RpHoaDonDTO(CtHoadon obj)
        {
            SoHoadon = obj.SoHoadon;
            SoSeri = obj.SoSeri;
            NgayHoadon = obj.NgayHoadon.Value;
            TenKhachhang = obj.TenKhachhang;
            MaSoThue = obj.MaSoThue;
            DienGiai = obj.DienGiai;
            DoanhThu = obj.DoanhThu;
            TienThue = obj.TienThue;
            SoTaiKhoanNh = obj.SoTaiKhoanNh;
            DiaChiKh = obj.DiaChi;
            HinhThucTT = obj.HinhThucTt;
        }

        public virtual Int32 SoDongThueKhiIn(IList<RpThueDTO> lstThue, int MaxLengPerRow)
        {
            int RowPerCt = 0;
            foreach (RpThueDTO tmp in lstThue)
            {
                string tenHH = tmp.TenHanghoa;
                int rowperrow = tenHH.Length / MaxLengPerRow;
                RowPerCt += rowperrow + 1;
            }
            return RowPerCt;
        }

        public virtual IList<RpThueDTO> GenBy(CtThue obj, int MaxLengPerRow)
        {
            IList<RpThueDTO> lstThue = new List<RpThueDTO>();
            string tenHH = obj.TenHanghoa;
            int rowperrow = tenHH.Length / MaxLengPerRow;
            rowperrow++;

            for (int i = 1; i <= rowperrow; i++)
            {
                RpThueDTO tmp = new RpThueDTO();
                if (i == 1)
                {
                    tmp = new RpThueDTO(obj);
                    tmp.TenHanghoa = GetString(obj.TenHanghoa, MaxLengPerRow, i);
                }
                else
                {
                    tmp = new RpThueDTO();
                    tmp.TenHanghoa = GetString(obj.TenHanghoa, MaxLengPerRow, i);

                }
                lstThue.Add(tmp);
            }

            return lstThue;
        }

        public virtual string GetString(string source, int maxleng, int index)
        {
            string[] arrstr = source.Split(' ');

            string des = string.Empty;
            int lengdes = 0;
            int curindex = 1;
            for (int i = 0; i < arrstr.Length; i++)
            {
                lengdes = des.Length;
                if ((lengdes + arrstr[i].Length) <= maxleng)
                {
                    des = des + " " + arrstr[i];
                }
                else
                {
                    if (curindex == index)
                        return des;
                    else
                    {
                        des = string.Empty;
                        des = des + arrstr[i];
                        curindex++;
                    }
                }
            }

            return des;
        }
    }
}
