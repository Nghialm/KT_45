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

        #region Shipping
        private string _MaVanChuyen = String.Empty;
        [DataMember]
        public string MaVanChuyen
        {
            get { return _MaVanChuyen; }
            set { _isChanged |= (_MaVanChuyen != value); _MaVanChuyen = value; }
        }

        private DateTime? _EtaDate;
        [DataMember]
        public DateTime? EtaDate
        {
            get { return _EtaDate; }
            set { _isChanged |= (_EtaDate != value); _EtaDate = value; }
        }

        private DateTime? _LsdDate;
        [DataMember]
        public DateTime? LsdDate
        {
            get { return _LsdDate; }
            set { _isChanged |= (_LsdDate != value); _LsdDate = value; }
        }

        private DateTime? _EtdDate;
        [DataMember]
        public DateTime? EtdDate
        {
            get { return _EtdDate; }
            set { _isChanged |= (_EtdDate != value); _EtdDate = value; }
        }

        private Int32 _Cang = 0;
        [DataMember]
        public Int32 Cang
        {
            get { return _Cang; }
            set { _isChanged |= (_Cang != value); _Cang = value; }
        }
        #endregion
    }
}