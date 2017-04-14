using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Accounting.Domain.Extend
{
    public class CT_H_GInfo
    {
        #region Private Variable
        private Guid _CTH_NX_ID;
        private string _MA_LOAI_CT;
        private DateTime _NGAY_GHI;
        private string _CT_SO;
        private DateTime _NGAY_CT;
        private decimal _SO_TIEN;
        private decimal _GHI;
        #endregion
        private decimal _DA_KHOA_SO;

        #region Property
        public Guid Id
        {
            get { return _CTH_NX_ID; }
            set { _CTH_NX_ID = value; }
        }

        public string MaLoaiCt
        {
            get { return _MA_LOAI_CT; }
            set { _MA_LOAI_CT = value; }
        }

        public DateTime NgayGhi
        {
            get { return _NGAY_GHI; }
            set { _NGAY_GHI = value; }
        }

        public string CtSo
        {
            get { return _CT_SO; }
            set { _CT_SO = value; }
        }

        public DateTime NgayCt
        {
            get { return _NGAY_CT; }
            set { _NGAY_CT = value; }
        }

        public decimal SoTien
        {
            get { return _SO_TIEN; }
            set { _SO_TIEN = value; }
        }

        public decimal Ghi
        {
            get { return _GHI; }
            set { _GHI = value; }
        }

        public decimal DaKhoaSo
        {
            get { return _DA_KHOA_SO; }
            set { _DA_KHOA_SO = value; }
        }

        #endregion

        #region Init Class
        public CT_H_GInfo()
        {
        }

        public CT_H_GInfo(CtH objCth)
        {
            _CTH_NX_ID = objCth.Id;

            if (String.IsNullOrEmpty(objCth.PrefixCt))
            {
                _CT_SO = objCth.PrefixCt + objCth.CtSo;
            }
            else
            {
                _CT_SO = objCth.CtSo;
            }

            _DA_KHOA_SO = objCth.DaKhoaSo;
            _GHI = objCth.Ghi;
            _MA_LOAI_CT = objCth.MaLoaiCt;
            _NGAY_CT = objCth.NgayCt.HasValue ? objCth.NgayCt.Value : DateTime.Today;
            _NGAY_GHI = objCth.NgayGhi.HasValue ? objCth.NgayGhi.Value : DateTime.Today;
            _SO_TIEN = objCth.SoTien;
        }

        public CT_H_GInfo(KtCtHKhac objCth)
        {
            _CTH_NX_ID = objCth.Id;

            if (String.IsNullOrEmpty(objCth.PrefixCt))
            {
                _CT_SO = objCth.PrefixCt + objCth.CtSo;
            }
            else
            {
                _CT_SO = objCth.CtSo;
            }

            _DA_KHOA_SO = objCth.DaKhoaSo;
            _GHI = objCth.GHI;
            _MA_LOAI_CT = objCth.MaLoaiCt;
            _NGAY_CT = objCth.NgayCt;
            _NGAY_GHI = objCth.NgayGhi;
            _SO_TIEN = objCth.SoTien;
        }

        public CT_H_GInfo(CtHNx objCthNx)
        {
            _CTH_NX_ID = objCthNx.Id;
            _CT_SO = objCthNx.PrefixCt + objCthNx.CtSo;
            _DA_KHOA_SO = objCthNx.DaKhoaSo;
            _GHI = objCthNx.Ghi;
            _MA_LOAI_CT = objCthNx.MaLoaiCt;
            _NGAY_CT = objCthNx.NgayCt == null ? DateTime.Now.Date : objCthNx.NgayCt.Value;
            _NGAY_GHI = objCthNx.NgayGhi == null ? DateTime.Now.Date : objCthNx.NgayGhi.Value;
            _SO_TIEN = objCthNx.SoTien;
        }

        public CT_H_GInfo(KtCtHHddv obj)
        {
            _CTH_NX_ID = obj.Id;
            _CT_SO = obj.PrefixCt + obj.CtSo;
            _DA_KHOA_SO = obj.DaKhoaSo;
            _GHI = obj.Ghi;
            _MA_LOAI_CT = obj.MaLoaiCt;
            _NGAY_CT = obj.NgayCt == null ? DateTime.Now.Date : obj.NgayCt.Value;
            _NGAY_GHI = obj.NgayGhi == null ? DateTime.Now.Date : obj.NgayGhi.Value;
            //_NGAY_CT = obj.NgayCt;
            //_NGAY_GHI = obj.NgayGhi;
            _SO_TIEN = obj.SoTien;
        }
        #endregion
    }
}
