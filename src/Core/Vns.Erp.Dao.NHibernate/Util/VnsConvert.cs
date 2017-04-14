using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Dao.NHibernate.Util
{
    public static class VnsConvert
    {
        public static System.DateTime CStartOfDate(System.DateTime value)
        {
            System.DateTime dt = new System.DateTime(value.Year, value.Month, value.Day, 0, 0, 0, 0);
            return dt;
        }

        public static System.DateTime CEndOfDate(System.DateTime value)
        {
            System.DateTime dt = new System.DateTime(value.Year, value.Month, value.Day, 23, 59, 59, 999);
            return dt;
        }
    }
}
