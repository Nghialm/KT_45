using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Common
{
    public enum LoaiKeHoach : int
    {
        KeHoachDauVao = 1,
        KeHoachDauRa = 2
    }

    public enum LoaiVatTu : int
    {
        VatTu = 1,
        NguyenVatLieu = 2
    }

    public class Common
    {
        public static List<String> lstMtkVatTu()
        {
            List<String> lst = new List<string>();
            lst.Add("152;");
            lst.Add("155;");
            lst.Add("156;");

            return lst;
        }

        public static List<String> lstMtkNvl()
        {
            List<String> lst = new List<string>();
            lst.Add("153;");

            return lst;
        }
    }
}
