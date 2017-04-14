using System;
using System.Collections;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class CcDmCcdc : DomainObject<System.Guid>
    {
        #region Declarations

		
		private string _MaCcdc = String.Empty;
		private string _KyHieu = String.Empty;
		private string _TenCcdc = String.Empty;
		private string _NuocSx = String.Empty;
		private decimal _NamSx = 0;
		private string _ThongsoKythuat = String.Empty;
		private System.DateTime _NgayMua = new DateTime();
		private System.DateTime _NgayBdsd = new DateTime();
		private System.DateTime _NgayBdpb = new DateTime();
		private System.DateTime _NgayKtpb = new DateTime();
		private decimal _SoKyPhanbo = 0;
		private decimal _SoTienDaPhanbo = 0;
		private decimal _GiaTriCl = 0;
		private System.Guid _PhongbanId = new Guid();
		private string _MaPhongban = String.Empty;
		private string _TenPhongban = String.Empty;
		private decimal _LoaiPhanbo = 0;
		private string _TenLoaiPhanbo = String.Empty;
		private System.Guid _DvtId = new Guid();
		private string _MaDvt = String.Empty;
		private string _TenDvt = String.Empty;
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = String.Empty;
		private decimal _ChoPhepSua = 0;
		private decimal _CoSuDung = 0;
		private string _MdTkCcdc = String.Empty;
		private string _MdTkPhanbo = String.Empty;
		private string _MdTkChiphi = String.Empty;
		private decimal _GiamCcdc = 0;
		private System.Guid _Nhom1 = new Guid();
		private System.Guid _Nhom2 = new Guid();
		private System.Guid _Nhom3 = new Guid();
		private decimal _SoLuong = 0;
		private System.DateTime _NgayTang = new DateTime();
		private decimal _ChiphiMua = 0;
		private decimal _ChiphiDvSd = 0;
		private System.DateTime _NgayGiam = new DateTime();
		private decimal _NguyenGia = 0;
		
		
		
        #endregion

        #region Constructors

        public CcDmCcdc() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_MaCcdc);
			sb.Append(_KyHieu);
			sb.Append(_TenCcdc);
			sb.Append(_NuocSx);
			sb.Append(_NamSx);
			sb.Append(_ThongsoKythuat);
			sb.Append(_NgayMua);
			sb.Append(_NgayBdsd);
			sb.Append(_NgayBdpb);
			sb.Append(_NgayKtpb);
			sb.Append(_SoKyPhanbo);
			sb.Append(_SoTienDaPhanbo);
			sb.Append(_GiaTriCl);
			sb.Append(_PhongbanId);
			sb.Append(_MaPhongban);
			sb.Append(_TenPhongban);
			sb.Append(_LoaiPhanbo);
			sb.Append(_TenLoaiPhanbo);
			sb.Append(_DvtId);
			sb.Append(_MaDvt);
			sb.Append(_TenDvt);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);
			sb.Append(_ChoPhepSua);
			sb.Append(_CoSuDung);
			sb.Append(_MdTkCcdc);
			sb.Append(_MdTkPhanbo);
			sb.Append(_MdTkChiphi);
			sb.Append(_GiamCcdc);
			sb.Append(_Nhom1);
			sb.Append(_Nhom2);
			sb.Append(_Nhom3);
			sb.Append(_SoLuong);
			sb.Append(_NgayTang);
			sb.Append(_ChiphiMua);
			sb.Append(_ChiphiDvSd);
			sb.Append(_NgayGiam);
			sb.Append(_NguyenGia);

            return sb.ToString().GetHashCode();
        }
		
		public CcDmCcdc Clone()
        {
            return (CcDmCcdc)this.MemberwiseClone();
        }
		
		public void SetProperty(CcDmCcdc des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_MaCcdc = des.MaCcdc;
			_KyHieu = des.KyHieu;
			_TenCcdc = des.TenCcdc;
			_NuocSx = des.NuocSx;
			_NamSx = des.NamSx;
			_ThongsoKythuat = des.ThongsoKythuat;
			_NgayMua = des.NgayMua;
			_NgayBdsd = des.NgayBdsd;
			_NgayBdpb = des.NgayBdpb;
			_NgayKtpb = des.NgayKtpb;
			_SoKyPhanbo = des.SoKyPhanbo;
			_SoTienDaPhanbo = des.SoTienDaPhanbo;
			_GiaTriCl = des.GiaTriCl;
			_PhongbanId = des.PhongbanId;
			_MaPhongban = des.MaPhongban;
			_TenPhongban = des.TenPhongban;
			_LoaiPhanbo = des.LoaiPhanbo;
			_TenLoaiPhanbo = des.TenLoaiPhanbo;
			_DvtId = des.DvtId;
			_MaDvt = des.MaDvt;
			_TenDvt = des.TenDvt;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
			_ChoPhepSua = des.ChoPhepSua;
			_CoSuDung = des.CoSuDung;
			_MdTkCcdc = des.MdTkCcdc;
			_MdTkPhanbo = des.MdTkPhanbo;
			_MdTkChiphi = des.MdTkChiphi;
			_GiamCcdc = des.GiamCcdc;
			_Nhom1 = des.Nhom1;
			_Nhom2 = des.Nhom2;
			_Nhom3 = des.Nhom3;
			_SoLuong = des.SoLuong;
			_NgayTang = des.NgayTang;
			_ChiphiMua = des.ChiphiMua;
			_ChiphiDvSd = des.ChiphiDvSd;
			_NgayGiam = des.NgayGiam;
			_NguyenGia = des.NguyenGia;
		}

        #endregion

        #region Properties

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
		
		public virtual string KyHieu
        {
            get { return _KyHieu; }
			set
			{
				OnKyHieuChanging();
				_KyHieu = value;
				OnKyHieuChanged();
			}
        }
		partial void OnKyHieuChanging();
		partial void OnKyHieuChanged();
		
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
		
		public virtual string NuocSx
        {
            get { return _NuocSx; }
			set
			{
				OnNuocSxChanging();
				_NuocSx = value;
				OnNuocSxChanged();
			}
        }
		partial void OnNuocSxChanging();
		partial void OnNuocSxChanged();
		
		public virtual decimal NamSx
        {
            get { return _NamSx; }
			set
			{
				OnNamSxChanging();
				_NamSx = value;
				OnNamSxChanged();
			}
        }
		partial void OnNamSxChanging();
		partial void OnNamSxChanged();
		
		public virtual string ThongsoKythuat
        {
            get { return _ThongsoKythuat; }
			set
			{
				OnThongsoKythuatChanging();
				_ThongsoKythuat = value;
				OnThongsoKythuatChanged();
			}
        }
		partial void OnThongsoKythuatChanging();
		partial void OnThongsoKythuatChanged();
		
		public virtual System.DateTime NgayMua
        {
            get { return _NgayMua; }
			set
			{
				OnNgayMuaChanging();
				_NgayMua = value;
				OnNgayMuaChanged();
			}
        }
		partial void OnNgayMuaChanging();
		partial void OnNgayMuaChanged();
		
		public virtual System.DateTime NgayBdsd
        {
            get { return _NgayBdsd; }
			set
			{
				OnNgayBdsdChanging();
				_NgayBdsd = value;
				OnNgayBdsdChanged();
			}
        }
		partial void OnNgayBdsdChanging();
		partial void OnNgayBdsdChanged();
		
		public virtual System.DateTime NgayBdpb
        {
            get { return _NgayBdpb; }
			set
			{
				OnNgayBdpbChanging();
				_NgayBdpb = value;
				OnNgayBdpbChanged();
			}
        }
		partial void OnNgayBdpbChanging();
		partial void OnNgayBdpbChanged();
		
		public virtual System.DateTime NgayKtpb
        {
            get { return _NgayKtpb; }
			set
			{
				OnNgayKtpbChanging();
				_NgayKtpb = value;
				OnNgayKtpbChanged();
			}
        }
		partial void OnNgayKtpbChanging();
		partial void OnNgayKtpbChanged();
		
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
		
		public virtual string TenPhongban
        {
            get { return _TenPhongban; }
			set
			{
				OnTenPhongbanChanging();
				_TenPhongban = value;
				OnTenPhongbanChanged();
			}
        }
		partial void OnTenPhongbanChanging();
		partial void OnTenPhongbanChanged();
		
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
		
		public virtual string MaDonvi
        {
            get { return _MaDonvi; }
			set
			{
				OnMaDonviChanging();
				_MaDonvi = value;
				OnMaDonviChanged();
			}
        }
		partial void OnMaDonviChanging();
		partial void OnMaDonviChanged();
		
		public virtual decimal ChoPhepSua
        {
            get { return _ChoPhepSua; }
			set
			{
				OnChoPhepSuaChanging();
				_ChoPhepSua = value;
				OnChoPhepSuaChanged();
			}
        }
		partial void OnChoPhepSuaChanging();
		partial void OnChoPhepSuaChanged();
		
		public virtual decimal CoSuDung
        {
            get { return _CoSuDung; }
			set
			{
				OnCoSuDungChanging();
				_CoSuDung = value;
				OnCoSuDungChanged();
			}
        }
		partial void OnCoSuDungChanging();
		partial void OnCoSuDungChanged();
		
		public virtual string MdTkCcdc
        {
            get { return _MdTkCcdc; }
			set
			{
				OnMdTkCcdcChanging();
				_MdTkCcdc = value;
				OnMdTkCcdcChanged();
			}
        }
		partial void OnMdTkCcdcChanging();
		partial void OnMdTkCcdcChanged();
		
		public virtual string MdTkPhanbo
        {
            get { return _MdTkPhanbo; }
			set
			{
				OnMdTkPhanboChanging();
				_MdTkPhanbo = value;
				OnMdTkPhanboChanged();
			}
        }
		partial void OnMdTkPhanboChanging();
		partial void OnMdTkPhanboChanged();
		
		public virtual string MdTkChiphi
        {
            get { return _MdTkChiphi; }
			set
			{
				OnMdTkChiphiChanging();
				_MdTkChiphi = value;
				OnMdTkChiphiChanged();
			}
        }
		partial void OnMdTkChiphiChanging();
		partial void OnMdTkChiphiChanged();
		
		public virtual decimal GiamCcdc
        {
            get { return _GiamCcdc; }
			set
			{
				OnGiamCcdcChanging();
				_GiamCcdc = value;
				OnGiamCcdcChanged();
			}
        }
		partial void OnGiamCcdcChanging();
		partial void OnGiamCcdcChanged();
		
		public virtual System.Guid Nhom1
        {
            get { return _Nhom1; }
			set
			{
				OnNhom1Changing();
				_Nhom1 = value;
				OnNhom1Changed();
			}
        }
		partial void OnNhom1Changing();
		partial void OnNhom1Changed();
		
		public virtual System.Guid Nhom2
        {
            get { return _Nhom2; }
			set
			{
				OnNhom2Changing();
				_Nhom2 = value;
				OnNhom2Changed();
			}
        }
		partial void OnNhom2Changing();
		partial void OnNhom2Changed();
		
		public virtual System.Guid Nhom3
        {
            get { return _Nhom3; }
			set
			{
				OnNhom3Changing();
				_Nhom3 = value;
				OnNhom3Changed();
			}
        }
		partial void OnNhom3Changing();
		partial void OnNhom3Changed();
		
		public virtual decimal SoLuong
        {
            get { return _SoLuong; }
			set
			{
				OnSoLuongChanging();
				_SoLuong = value;
				OnSoLuongChanged();
			}
        }
		partial void OnSoLuongChanging();
		partial void OnSoLuongChanged();
		
		public virtual System.DateTime NgayTang
        {
            get { return _NgayTang; }
			set
			{
				OnNgayTangChanging();
				_NgayTang = value;
				OnNgayTangChanged();
			}
        }
		partial void OnNgayTangChanging();
		partial void OnNgayTangChanged();
		
		public virtual decimal ChiphiMua
        {
            get { return _ChiphiMua; }
			set
			{
				OnChiphiMuaChanging();
				_ChiphiMua = value;
				OnChiphiMuaChanged();
			}
        }
		partial void OnChiphiMuaChanging();
		partial void OnChiphiMuaChanged();
		
		public virtual decimal ChiphiDvSd
        {
            get { return _ChiphiDvSd; }
			set
			{
				OnChiphiDvSdChanging();
				_ChiphiDvSd = value;
				OnChiphiDvSdChanged();
			}
        }
		partial void OnChiphiDvSdChanging();
		partial void OnChiphiDvSdChanged();
		
		public virtual System.DateTime NgayGiam
        {
            get { return _NgayGiam; }
			set
			{
				OnNgayGiamChanging();
				_NgayGiam = value;
				OnNgayGiamChanged();
			}
        }
		partial void OnNgayGiamChanging();
		partial void OnNgayGiamChanged();
		
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
		
        #endregion
		
		
    }
}
