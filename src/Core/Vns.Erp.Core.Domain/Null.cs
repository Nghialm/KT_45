using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Domain
{
    public class Null
    {
        //public const System.DateTime NULL_DATE = 01/01/0001 00:00:00;
        public static DateTime MIN_DATE
        {
            get { return new DateTime(1753, 1, 1); }
        }

        public static DateTime MAX_DATE
        {
            get { return new DateTime(9999, 12, 31); }
        }

        // define application encoded null values 
        public static short NullShort
        {
            get { return short.MinValue; }
        }
        public static int NullInteger
        {
            get { return int.MinValue; }
        }

        public static long NullLong
        {
            get { return long.MinValue; }
        }

        public static float NullSingle
        {
            get { return float.MinValue; }
        }
        public static double NullDouble
        {
            get { return double.MinValue; }
        }
        public static decimal NullDecimal
        {
            get { return decimal.MinValue; }
        }
        public static System.DateTime NullDate
        {
            get { return System.DateTime.MinValue; }
        }
        public static string NullString
        {
            get { return ""; }
        }
        public static bool NullBoolean
        {
            get { return false; }
        }
        public static Guid NullGuid
        {
            get { return Guid.Empty; }
        }
        public static string NullGuidString
        {
            get { return "00000000000000000000000000000000"; }
        }


    }

    public class LimitValue
    {
        public const decimal VNDcurrency = 999999999999999999L;
        public const decimal Fcurrency = 99999999999999L;
        public const decimal quantity = 99999999999999L;

        public const decimal TyGia = 9999999999L;
        /// <summary>
        /// Kiem tra gia tri ty gia ngoai te trong khoang hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckTyGia(decimal number)
        {
            if ((number > TyGia) | (number <= 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra gia tri khong am va trong khoan hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckCurrency(decimal number)
        {
            if ((number > VNDcurrency) | (number <= 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra tien VND trong khoang hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckVNDCurrency(decimal number)
        {
            if ((number > VNDcurrency) | (number < 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra tien Ngoai trong khoang hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckFCurrency(decimal number)
        {
            if ((number > Fcurrency) | (number < 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra tien Ngoai trong khoang hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckQuantity(decimal number)
        {
            if ((number > quantity) | (number < 0))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Kiem tra ty le thue trong khoang hop le
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckTaxRate(decimal number)
        {
            if ((number >= 1000) | (number < 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiem tra do dai truong ki tu co qua 256 khong
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CheckLengthString(string Text)
        {
            if (Text.Length >= 256)
            {
                return false;
            }
            return true;
        }
    }
}
