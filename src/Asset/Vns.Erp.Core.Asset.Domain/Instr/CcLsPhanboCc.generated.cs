using System;
using System.Collections;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
    public partial class CcLsPhanboCc : DomainObject<System.Guid>
    {
        #region Declarations

		
		private System.Guid _LsCcdcId = new Guid();
		private System.Guid _CcdcId = new Guid();
		private string _MaCcdc = String.Empty;
		private string _KyHieuCcdc = String.Empty;
		private string _TenCcdc = String.Empty;
		private decimal _NguyenGia = 0;
		private System.DateTime _NgayBdKh = new DateTime();
		private System.DateTime _NgayKtKh = new DateTime();
		private decimal _SoKyPhanbo = 0;
		private decimal _TyleKh = 0;
		private decimal _SoTienDaPhanbo = 0;
		private decimal _GiaTriCl = 0;
		private System.Guid _DonviId = new Guid();
		private decimal _Thang = 0;
		private decimal _Nam = 0;
		private System.Guid _CtdId = new Guid();
		private System.Guid _CthId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public CcLsPhanboCc() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LsCcdcId);
			sb.Append(_CcdcId);
			sb.Append(_MaCcdc);
			sb.Append(_KyHieuCcdc);
			sb.Append(_TenCcdc);
			sb.Append(_NguyenGia);
			sb.Append(_NgayBdKh);
			sb.Append(_NgayKtKh);
			sb.Append(_SoKyPhanbo);
			sb.Append(_TyleKh);
			sb.Append(_SoTienDaPhanbo);
			sb.Append(_GiaTriCl);
			sb.Append(_DonviId);
			sb.Append(_Thang);
			sb.Append(_Nam);
			sb.Append(_CtdId);
			sb.Append(_CthId);

            return sb.ToString().GetHashCode();
        }
		
		public CcLsPhanboCc Clone()
        {
            return (CcLsPhanboCc)this.MemberwiseClone();
        }
		
		public void SetProperty(CcLsPhanboCc des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LsCcdcId = des.LsCcdcId;
			_CcdcId = des.CcdcId;
			_MaCcdc = des.MaCcdc;
			_KyHieuCcdc = des.KyHieuCcdc;
			_TenCcdc = des.TenCcdc;
			_NguyenGia = des.NguyenGia;
			_NgayBdKh = des.NgayBdKh;
			_NgayKtKh = des.NgayKtKh;
			_SoKyPhanbo = des.SoKyPhanbo;
			_TyleKh = des.TyleKh;
			_SoTienDaPhanbo = des.SoTienDaPhanbo;
			_GiaTriCl = des.GiaTriCl;
			_DonviId = des.DonviId;
			_Thang = des.Thang;
			_Nam = des.Nam;
			_CtdId = des.CtdId;
			_CthId = des.CthId;
		}

        #endregion

        #region Properties

		public virtual System.Guid LsCcdcId
        {
            get { return _LsCcdcId; }
			set
			{
				OnLsCcdcIdChanging();
				_LsCcdcId = value;
				OnLsCcdcIdChanged();
			}
        }
		partial void OnLsCcdcIdChanging();
		partial void OnLsCcdcIdChanged();
		
		public virtual System.Guid CcdcId
        {
            get { return _CcdcId; }
			set
			{
				OnCcdcIdChanging();
				_CcdcId = value;
				OnCcdcIdChanged();
			}
        }
		partial void OnCcdcIdChanging();
		partial void OnCcdcIdChanged();
		
		public virtual string MaCcdc
        {
            get { return _MaCcdc; }
			set
			{
				OnMaCcdcChanging();
				_MaCcdc = value;
				OnMaCcdcChanged();
			}
        }
		partial void OnMaCcdcChanging();
		partial void OnMaCcdcChanged();
		
		public virtual string KyHieuCcdc
        {
            get { return _KyHieuCcdc; }
			set
			{
				OnKyHieuCcdcChanging();
				_KyHieuCcdc = value;
				OnKyHieuCcdcChanged();
			}
        }
		partial void OnKyHieuCcdcChanging();
		partial void OnKyHieuCcdcChanged();
		
		public virtual string TenCcdc
        {
            get { return _TenCcdc; }
			set
			{
				OnTenCcdcChanging();
				_TenCcdc = value;
				OnTenCcdcChanged();
			}
        }
		partial void OnTenCcdcChanging();
		partial void OnTenCcdcChanged();
		
		public virtual decimal NguyenGia
        {
            get { return _NguyenGia; }
			set
			{
				OnNguyenGiaChanging();
				_NguyenGia = value;
				OnNguyenGiaChanged();
			}
        }
		partial void OnNguyenGiaChanging();
		partial void OnNguyenGiaChanged();
		
		public virtual System.DateTime NgayBdKh
        {
            get { return _NgayBdKh; }
			set
			{
				OnNgayBdKhChanging();
				_NgayBdKh = value;
				OnNgayBdKhChanged();
			}
        }
		partial void OnNgayBdKhChanging();
		partial void OnNgayBdKhChanged();
		
		public virtual System.DateTime NgayKtKh
        {
            get { return _NgayKtKh; }
			set
			{
				OnNgayKtKhChanging();
				_NgayKtKh = value;
				OnNgayKtKhChanged();
			}
        }
		partial void OnNgayKtKhChanging();
		partial void OnNgayKtKhChanged();
		
		public virtual decimal SoKyPhanbo
        {
            get { return _SoKyPhanbo; }
			set
			{
				OnSoKyPhanboChanging();
				_SoKyPhanbo = value;
				OnSoKyPhanboChanged();
			}
        }
		partial void OnSoKyPhanboChanging();
		partial void OnSoKyPhanboChanged();
		
		public virtual decimal TyleKh
        {
            get { return _TyleKh; }
			set
			{
				OnTyleKhChanging();
				_TyleKh = value;
				OnTyleKhChanged();
			}
        }
		partial void OnTyleKhChanging();
		partial void OnTyleKhChanged();
		
		public virtual decimal SoTienDaPhanbo
        {
            get { return _SoTienDaPhanbo; }
			set
			{
				OnSoTienDaPhanboChanging();
				_SoTienDaPhanbo = value;
				OnSoTienDaPhanboChanged();
			}
        }
		partial void OnSoTienDaPhanboChanging();
		partial void OnSoTienDaPhanboChanged();
		
		public virtual decimal GiaTriCl
        {
            get { return _GiaTriCl; }
			set
			{
				OnGiaTriClChanging();
				_GiaTriCl = value;
				OnGiaTriClChanged();
			}
        }
		partial void OnGiaTriClChanging();
		partial void OnGiaTriClChanged();
		
		public virtual System.Guid DonviId
        {
            get { return _DonviId; }
			set
			{
				OnDonviIdChanging();
				_DonviId = value;
				OnDonviIdChanged();
			}
        }
		partial void OnDonviIdChanging();
		partial void OnDonviIdChanged();
		
		public virtual decimal Thang
        {
            get { return _Thang; }
			set
			{
				OnThangChanging();
				_Thang = value;
				OnThangChanged();
			}
        }
		partial void OnThangChanging();
		partial void OnThangChanged();
		
		public virtual decimal Nam
        {
            get { return _Nam; }
			set
			{
				OnNamChanging();
				_Nam = value;
				OnNamChanged();
			}
        }
		partial void OnNamChanging();
		partial void OnNamChanged();
		
		public virtual System.Guid CtdId
        {
            get { return _CtdId; }
			set
			{
				OnCtdIdChanging();
				_CtdId = value;
				OnCtdIdChanged();
			}
        }
		partial void OnCtdIdChanging();
		partial void OnCtdIdChanged();
		
		public virtual System.Guid CthId
        {
            get { return _CthId; }
			set
			{
				OnCthIdChanging();
				_CthId = value;
				OnCthIdChanged();
			}
        }
		partial void OnCthIdChanging();
		partial void OnCthIdChanged();

        private System.Decimal _SoTienPb;
        public virtual System.Decimal SoTienPb
        {
            get {return _SoTienPb;}
            set
            {
            	_SoTienPb = value;
            }
        }
		
        #endregion
		
		
    }
}
