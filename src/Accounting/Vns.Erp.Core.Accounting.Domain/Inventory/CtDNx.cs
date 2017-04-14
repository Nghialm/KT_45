using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class CtDNx : DomainObject<System.Guid>
    {
        #region Extend Property
        private CtHNx _ObjCtHNx;
        [DataMember]
        public virtual CtHNx ObjCtHNx
        {
            get { return _ObjCtHNx; }
            set { _ObjCtHNx = value; }
        }
        #endregion

        #region Sort
        public static int CompareLenhSX(CtDNx x, CtDNx y)
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
                    String xlsx = x.MaLenhSanXuatNhap + ";" + x.MaLenhSanXuatXuat;
                    String xlsy = y.MaLenhSanXuatNhap + ";" + y.MaLenhSanXuatXuat;

                    int retvalSoQuyetToan = 0;
                    //int revalSoChungTu = 0;
                    retvalSoQuyetToan = xlsx.CompareTo(xlsy);
                    return retvalSoQuyetToan;
                }
            }
        }

        public static int ComparePhanXuongSX(CtDNx x, CtDNx y)
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
                    String xlsx = x.MaPhanXuongNhap + ";" + x.MaPhanXuongXuat;
                    String xlsy = y.MaPhanXuongNhap + ";" + y.MaPhanXuongXuat;

                    int retvalSoQuyetToan = 0;
                    //int revalSoChungTu = 0;
                    retvalSoQuyetToan = xlsx.CompareTo(xlsy);
                    return retvalSoQuyetToan;
                }
            }
        }
        #endregion
    }
}