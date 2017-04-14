using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class HtLoaichungtu : DomainObject<System.Guid>
    {
        #region Compare
        public static int CompareMaLoaiCt(HtLoaichungtu x, HtLoaichungtu y)
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
                    int retvalSoQuyetToan = 0;
                    //int revalSoChungTu = 0;
                    retvalSoQuyetToan = x.MaLoaiCt.CompareTo(y.MaLoaiCt);
                    return retvalSoQuyetToan;
                }
            }
        }
        #endregion
	}
}