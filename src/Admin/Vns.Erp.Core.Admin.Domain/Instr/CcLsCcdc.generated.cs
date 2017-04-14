using System;
using System.Collections;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class CcLsCcdc : DomainObject<System.Guid>
    {
        #region Declarations

		
		private System.DateTime _NgayBiendoi = new DateTime();
		private System.Guid _CcdcId = new Guid();
		private string _MaCcdc = String.Empty;
		private string _KyHieuCcdc = String.Empty;
		private string _TenCcdc = String.Empty;
		private decimal _NguyenGia = 0;
		private System.DateTime _NgayBdSd = new DateTime();
		private System.DateTime _NgayBdKh = new DateTime();
		private System.DateTime _NgayKtKh = new DateTime();
		private decimal _SoKyPhanbo = 0;
		private decimal _SoTienDaPhanbo = 0;
		private decimal _GiaTriCl = 0;
		private System.Guid _DvtId = new Guid();
		private string _MaDvt = String.Empty;
		private string _TenDvt = String.Empty;
		private System.Guid _PhongbanId = new Guid();
		private string _MaPhongban = String.Empty;
		private System.Guid _LoaitaisanId = new Guid();
		private decimal _LoaiPhanbo = 0;
		private string _TenLoaiPhanbo = String.Empty;
		private decimal _ThuTu = 0;
		
		
		
        #endregion

        #region Constructors

        public CcLsCcdc() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_NgayBiendoi);
			sb.Append(_CcdcId);
			sb.Append(_MaCcdc);
			sb.Append(_KyHieuCcdc);
			sb.Append(_TenCcdc);
			sb.Append(_NguyenGia);
			sb.Append(_NgayBdSd);
			sb.Append(_NgayBdKh);
			sb.Append(_NgayKtKh);
			sb.Append(_SoKyPhanbo);
			sb.Append(_SoTienDaPhanbo);
			sb.Append(_GiaTriCl);
			sb.Append(_DvtId);
			sb.Append(_MaDvt);
			sb.Append(_TenDvt);
			sb.Append(_PhongbanId);
			sb.Append(_MaPhongban);
			sb.Append(_LoaitaisanId);
			sb.Append(_LoaiPhanbo);
			sb.Append(_TenLoaiPhanbo);
			sb.Append(_ThuTu);

            return sb.ToString().GetHashCode();
        }
		
		public CcLsCcdc Clone()
        {
            return (CcLsCcdc)this.MemberwiseClone();
        }
		
		public void SetProperty(CcLsCcdc des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_NgayBiendoi = des.NgayBiendoi;
			_CcdcId = des.CcdcId;
			_MaCcdc = des.MaCcdc;
			_KyHieuCcdc = des.KyHieuCcdc;
			_TenCcdc = des.TenCcdc;
			_NguyenGia = des.NguyenGia;
			_NgayBdSd = des.NgayBdSd;
			_NgayBdKh = des.NgayBdKh;
			_NgayKtKh = des.NgayKtKh;
			_SoKyPhanbo = des.SoKyPhanbo;
			_SoTienDaPhanbo = des.SoTienDaPhanbo;
			_GiaTriCl = des.GiaTriCl;
			_DvtId = des.DvtId;
			_MaDvt = des.MaDvt;
			_TenDvt = des.TenDvt;
			_PhongbanId = des.PhongbanId;
			_MaPhongban = des.MaPhongban;
			_LoaitaisanId = des.LoaitaisanId;
			_LoaiPhanbo = des.LoaiPhanbo;
			_TenLoaiPhanbo = des.TenLoaiPhanbo;
			_ThuTu = des.ThuTu;
		}

        #endregion

        #region Properties

		public virtual System.DateTime NgayBiendoi
        {
            get { return _NgayBiendoi; }
			set
			{
				OnNgayBiendoiChanging();
				_NgayBiendoi = value;
				OnNgayBiendoiChanged();
			}
        }
		partial void OnNgayBiendoiChanging();
		partial void OnNgayBiendoiChanged();
		
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
		
		public virtual System.DateTime NgayBdSd
        {
            get { return _NgayBdSd; }
			set
			{
				OnNgayBdSdChanging();
				_NgayBdSd = value;
				OnNgayBdSdChanged();
			}
        }
		partial void OnNgayBdSdChanging();
		partial void OnNgayBdSdChanged();
		
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
		
		public virtual System.Guid DvtId
        {
            get { return _DvtId; }
			set
			{
				OnDvtIdChanging();
				_DvtId = value;
				OnDvtIdChanged();
			}
        }
		partial void OnDvtIdChanging();
		partial void OnDvtIdChanged();
		
		public virtual string MaDvt
        {
            get { return _MaDvt; }
			set
			{
				OnMaDvtChanging();
				_MaDvt = value;
				OnMaDvtChanged();
			}
        }
		partial void OnMaDvtChanging();
		partial void OnMaDvtChanged();
		
		public virtual string TenDvt
        {
            get { return _TenDvt; }
			set
			{
				OnTenDvtChanging();
				_TenDvt = value;
				OnTenDvtChanged();
			}
        }
		partial void OnTenDvtChanging();
		partial void OnTenDvtChanged();
		
		public virtual System.Guid PhongbanId
        {
            get { return _PhongbanId; }
			set
			{
				OnPhongbanIdChanging();
				_PhongbanId = value;
				OnPhongbanIdChanged();
			}
        }
		partial void OnPhongbanIdChanging();
		partial void OnPhongbanIdChanged();
		
		public virtual string MaPhongban
        {
            get { return _MaPhongban; }
			set
			{
				OnMaPhongbanChanging();
				_MaPhongban = value;
				OnMaPhongbanChanged();
			}
        }
		partial void OnMaPhongbanChanging();
		partial void OnMaPhongbanChanged();
		
		public virtual System.Guid LoaitaisanId
        {
            get { return _LoaitaisanId; }
			set
			{
				OnLoaitaisanIdChanging();
				_LoaitaisanId = value;
				OnLoaitaisanIdChanged();
			}
        }
		partial void OnLoaitaisanIdChanging();
		partial void OnLoaitaisanIdChanged();
		
		public virtual decimal LoaiPhanbo
        {
            get { return _LoaiPhanbo; }
			set
			{
				OnLoaiPhanboChanging();
				_LoaiPhanbo = value;
				OnLoaiPhanboChanged();
			}
        }
		partial void OnLoaiPhanboChanging();
		partial void OnLoaiPhanboChanged();
		
		public virtual string TenLoaiPhanbo
        {
            get { return _TenLoaiPhanbo; }
			set
			{
				OnTenLoaiPhanboChanging();
				_TenLoaiPhanbo = value;
				OnTenLoaiPhanboChanged();
			}
        }
		partial void OnTenLoaiPhanboChanging();
		partial void OnTenLoaiPhanboChanged();
		
		public virtual decimal ThuTu
        {
            get { return _ThuTu; }
			set
			{
				OnThuTuChanging();
				_ThuTu = value;
				OnThuTuChanged();
			}
        }
		partial void OnThuTuChanging();
		partial void OnThuTuChanged();
		
        #endregion
		
		
    }
}
