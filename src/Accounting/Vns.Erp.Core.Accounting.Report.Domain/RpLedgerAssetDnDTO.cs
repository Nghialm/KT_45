using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpLedgerAssetDnDTO
    {
        public virtual Guid DmTscdId { get; set; }
        public virtual Guid CtTscdId { get; set; }
        public virtual String MaTscd { get; set; }
        public virtual String KyHieu { get; set; }
        public virtual String TenTscd { get; set; }
        public virtual String NuocSx { get; set; }
        public virtual DateTime NgayBdKh { get; set; }
        public virtual DateTime NgayKtKh { get; set; }
        public virtual Decimal SoThangSd { get; set; }
        public virtual Decimal TyLeHaomon
        {
            get
            {
                if (SoThangSd == 0) return 0;

                Decimal tyle = (1 / SoThangSd) * 100 * 12;
                return Decimal.Round(tyle, 2);
            }
        }
        public virtual Decimal HaoMonThang { get; set; }
        public virtual Decimal HaoMonLk { get; set; }
        public virtual Decimal GiaTriCl
        {
            get
            {
                Decimal tmp = NguyenGia - HaoMonLk;
                return tmp;
            }
        }
        public virtual Decimal NguyenGia { get; set; }
        public virtual Decimal Thang { get; set; }
        public virtual Decimal Nam { get; set; }

        private String _SoCt = String.Empty;
        public virtual String SoCt
        {
            get { return _SoCt; }
            set { _SoCt = value; }
        }
        
        public virtual String SoCtTang
        {
            get
            {
                if (_TangTscd != 4)
                    return _SoCt;
                else
                    return String.Empty;
            }
        }

        public virtual String SoCtGiam
        {
            get
            {
                if (_TangTscd == 4)
                    return _SoCt;
                else
                    return String.Empty;
            }
        }
        private DateTime _NgayCt;
        public virtual DateTime NgayCt
        {
            get { return _NgayCt; }
            set { _NgayCt = value; }
        }
        
        public virtual DateTime? NgayCtTang
        {
            get
            {
                if (_TangTscd != 4)
                    return _NgayCt;
                else
                    return null;
            }
        }
        public virtual DateTime? NgayCtGiam
        {
            get
            {
                if (_TangTscd == 4)
                    return _NgayCt;
                else
                    return null;
            }
        }

        public virtual Decimal Nhom { get; set; }

        public virtual Guid LoaitaisanId { get; set; }
        public virtual String MaLoaitaisan { get; set; }

        private Decimal _TangTscd;
        public virtual Decimal TangTscd
        {
            get { return _TangTscd; }
            set { _TangTscd = value; }
        }

        public virtual Guid LydoTanggiam { get; set; }
        public virtual String TenLydoTanggiam { get; set; }

        public virtual Decimal MucKhauHao
        {
            get
            {
                if (_TangTscd != 4 && SoThangSd != 0)
                    return NguyenGia / SoThangSd;
                else
                    return 0;
            }
        }

        public virtual String MaLoaiTs { get; set; }
        public virtual String TenLoaiTs { get; set; }
    }
}
