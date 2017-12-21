using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Asset.Domain", IsReference = true)]
    public partial class DmTscd : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _LoaitaisanId = new Guid();
		private string _MaLoaitaisan = String.Empty;
		private string _TenLoaitaisan = String.Empty;
		private string _MaTscd = String.Empty;
		private string _KyHieu = String.Empty;
		private string _TenTscd = String.Empty;
		private string _NuocSx = String.Empty;
		private decimal _NamSx = default(Decimal);
		private string _ThongsoKythuat = String.Empty;
		private System.DateTime? _NgayMua = Null.MIN_DATE;
		private System.DateTime? _NgayBdsd = Null.MIN_DATE;
        private System.DateTime? _NgayBdkh = Null.MIN_DATE;
        private System.DateTime? _NgayKtkh = Null.MIN_DATE;
        private decimal _SoNamSd = default(Decimal);
		private decimal _TyleKh = default(Decimal);
		private decimal _HeSoDieuChinh = default(Decimal);
		private decimal _TyleKhNhanh = default(Decimal);
		private decimal _HaoMonNam = default(Decimal);
		private decimal _HaoMonNamNte = default(Decimal);
		private decimal _HaoMonLk = default(Decimal);
		private decimal _HaoMonLkNte = default(Decimal);
		private decimal _GiaTriCl = default(Decimal);
		private decimal _GiaTriClNte = default(Decimal);
		private decimal _SanluongCongsuat = default(Decimal);
		private System.Guid _PhongbanId = new Guid();
		private string _MaPhongban = String.Empty;
		private string _TenPhongban = String.Empty;
		private decimal _LoaiPpKh = default(Decimal);
		private string _TenPpKh = String.Empty;
		private System.Guid _DvtId = new Guid();
		private string _MaDvt = String.Empty;
		private string _TenDvt = String.Empty;
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = String.Empty;
		private decimal _ChoPhepSua = default(Decimal);
		private decimal _CoSuDung = default(Decimal);
		private string _MdTkTs = String.Empty;
		private string _MdTkKhauhao = String.Empty;
		private string _MdTkChiphi = String.Empty;
		private decimal _GiamTscd = default(Decimal);
		private System.Guid _Nhom1 = new Guid();
		private System.Guid _Nhom2 = new Guid();
		private System.Guid _Nhom3 = new Guid();
		private decimal _SoLuong = default(Decimal);
		private decimal _SoThangSd = default(Decimal);
		private System.DateTime? _NgayTang = null;
		private decimal _ChiphiMua = default(Decimal);
		private decimal _ChiphiDvSd = default(Decimal);
		private System.DateTime? _NgayGiam = Null.MIN_DATE;
        private decimal _NguyenGia = default(Decimal);

        private DateTime _SynDate = Null.MIN_DATE;
        private decimal? _IsDeleted = 0;

        #endregion

        #region Constructors

        public DmTscd() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LoaitaisanId);
			sb.Append(_MaLoaitaisan);
			sb.Append(_TenLoaitaisan);
			sb.Append(_MaTscd);
			sb.Append(_KyHieu);
			sb.Append(_TenTscd);
			sb.Append(_NuocSx);
			sb.Append(_NamSx);
			sb.Append(_ThongsoKythuat);
			sb.Append(_NgayMua);
			sb.Append(_NgayBdsd);
			sb.Append(_NgayBdkh);
			sb.Append(_NgayKtkh);
			sb.Append(_SoNamSd);
			sb.Append(_TyleKh);
			sb.Append(_HeSoDieuChinh);
			sb.Append(_TyleKhNhanh);
			sb.Append(_HaoMonNam);
			sb.Append(_HaoMonNamNte);
			sb.Append(_HaoMonLk);
			sb.Append(_HaoMonLkNte);
			sb.Append(_GiaTriCl);
			sb.Append(_GiaTriClNte);
			sb.Append(_SanluongCongsuat);
			sb.Append(_PhongbanId);
			sb.Append(_MaPhongban);
			sb.Append(_TenPhongban);
			sb.Append(_LoaiPpKh);
			sb.Append(_TenPpKh);
			sb.Append(_DvtId);
			sb.Append(_MaDvt);
			sb.Append(_TenDvt);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);
			sb.Append(_ChoPhepSua);
			sb.Append(_CoSuDung);
			sb.Append(_MdTkTs);
			sb.Append(_MdTkKhauhao);
			sb.Append(_MdTkChiphi);
			sb.Append(_GiamTscd);
			sb.Append(_Nhom1);
			sb.Append(_Nhom2);
			sb.Append(_Nhom3);
			sb.Append(_SoLuong);
			sb.Append(_SoThangSd);
			sb.Append(_NgayTang);
			sb.Append(_ChiphiMua);
			sb.Append(_ChiphiDvSd);
			sb.Append(_NgayGiam);
            sb.Append(_NguyenGia);

            return sb.ToString().GetHashCode();
        }
		
		public DmTscd Clone()
        {
            return (DmTscd)this.MemberwiseClone();
        }
		
		public void SetProperty(DmTscd des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LoaitaisanId = des.LoaitaisanId;
			_MaLoaitaisan = des.MaLoaitaisan;
			_TenLoaitaisan = des.TenLoaitaisan;
			_MaTscd = des.MaTscd;
			_KyHieu = des.KyHieu;
			_TenTscd = des.TenTscd;
			_NuocSx = des.NuocSx;
			_NamSx = des.NamSx;
			_ThongsoKythuat = des.ThongsoKythuat;
			_NgayMua = des.NgayMua;
			_NgayBdsd = des.NgayBdsd;
			_NgayBdkh = des.NgayBdkh;
			_NgayKtkh = des.NgayKtkh;
			_SoNamSd = des.SoNamSd;
			_TyleKh = des.TyleKh;
			_HeSoDieuChinh = des.HeSoDieuChinh;
			_TyleKhNhanh = des.TyleKhNhanh;
			_HaoMonNam = des.HaoMonNam;
			_HaoMonNamNte = des.HaoMonNamNte;
			_HaoMonLk = des.HaoMonLk;
			_HaoMonLkNte = des.HaoMonLkNte;
			_GiaTriCl = des.GiaTriCl;
			_GiaTriClNte = des.GiaTriClNte;
			_SanluongCongsuat = des.SanluongCongsuat;
			_PhongbanId = des.PhongbanId;
			_MaPhongban = des.MaPhongban;
			_TenPhongban = des.TenPhongban;
			_LoaiPpKh = des.LoaiPpKh;
			_TenPpKh = des.TenPpKh;
			_DvtId = des.DvtId;
			_MaDvt = des.MaDvt;
			_TenDvt = des.TenDvt;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
			_ChoPhepSua = des.ChoPhepSua;
			_CoSuDung = des.CoSuDung;
			_MdTkTs = des.MdTkTs;
			_MdTkKhauhao = des.MdTkKhauhao;
			_MdTkChiphi = des.MdTkChiphi;
			_GiamTscd = des.GiamTscd;
			_Nhom1 = des.Nhom1;
			_Nhom2 = des.Nhom2;
			_Nhom3 = des.Nhom3;
			_SoLuong = des.SoLuong;
			_SoThangSd = des.SoThangSd;
			_NgayTang = des.NgayTang;
			_ChiphiMua = des.ChiphiMua;
			_ChiphiDvSd = des.ChiphiDvSd;
			_NgayGiam = des.NgayGiam;
            _NguyenGia = des.NguyenGia;
		}

        #endregion

        #region Properties

        [DataMember]
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
		
        [DataMember]
		public virtual string MaLoaitaisan
        {
            get { return _MaLoaitaisan; }
			set
			{
				OnMaLoaitaisanChanging();
				_MaLoaitaisan = value;
				OnMaLoaitaisanChanged();
			}
        }
		partial void OnMaLoaitaisanChanging();
		partial void OnMaLoaitaisanChanged();
		
        [DataMember]
		public virtual string TenLoaitaisan
        {
            get { return _TenLoaitaisan; }
			set
			{
				OnTenLoaitaisanChanging();
				_TenLoaitaisan = value;
				OnTenLoaitaisanChanged();
			}
        }
		partial void OnTenLoaitaisanChanging();
		partial void OnTenLoaitaisanChanged();
		
        [DataMember]
		public virtual string MaTscd
        {
            get { return _MaTscd; }
			set
			{
				OnMaTscdChanging();
				_MaTscd = value;
				OnMaTscdChanged();
			}
        }
		partial void OnMaTscdChanging();
		partial void OnMaTscdChanged();
		
        [DataMember]
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
		
        [DataMember]
		public virtual string TenTscd
        {
            get { return _TenTscd; }
			set
			{
				OnTenTscdChanging();
				_TenTscd = value;
				OnTenTscdChanged();
			}
        }
		partial void OnTenTscdChanging();
		partial void OnTenTscdChanged();
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
		public virtual System.DateTime? NgayMua
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
		
        [DataMember]
		public virtual System.DateTime? NgayBdsd
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
		
        [DataMember]
		public virtual System.DateTime? NgayBdkh
        {
            get { return _NgayBdkh; }
			set
			{
				OnNgayBdkhChanging();
				_NgayBdkh = value;
				OnNgayBdkhChanged();
			}
        }
		partial void OnNgayBdkhChanging();
		partial void OnNgayBdkhChanged();
		
        [DataMember]
		public virtual System.DateTime? NgayKtkh
        {
            get { return _NgayKtkh; }
			set
			{
				OnNgayKtkhChanging();
				_NgayKtkh = value;
				OnNgayKtkhChanged();
			}
        }
		partial void OnNgayKtkhChanging();
		partial void OnNgayKtkhChanged();
		
        [DataMember]
		public virtual decimal SoNamSd
        {
            get { return _SoNamSd; }
			set
			{
				OnSoNamSdChanging();
				_SoNamSd = value;
				OnSoNamSdChanged();
			}
        }
		partial void OnSoNamSdChanging();
		partial void OnSoNamSdChanged();
		
        [DataMember]
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
		
        [DataMember]
		public virtual decimal HeSoDieuChinh
        {
            get { return _HeSoDieuChinh; }
			set
			{
				OnHeSoDieuChinhChanging();
				_HeSoDieuChinh = value;
				OnHeSoDieuChinhChanged();
			}
        }
		partial void OnHeSoDieuChinhChanging();
		partial void OnHeSoDieuChinhChanged();
		
        [DataMember]
		public virtual decimal TyleKhNhanh
        {
            get { return _TyleKhNhanh; }
			set
			{
				OnTyleKhNhanhChanging();
				_TyleKhNhanh = value;
				OnTyleKhNhanhChanged();
			}
        }
		partial void OnTyleKhNhanhChanging();
		partial void OnTyleKhNhanhChanged();
		
        [DataMember]
		public virtual decimal HaoMonNam
        {
            get { return _HaoMonNam; }
			set
			{
				OnHaoMonNamChanging();
				_HaoMonNam = value;
				OnHaoMonNamChanged();
			}
        }
		partial void OnHaoMonNamChanging();
		partial void OnHaoMonNamChanged();
		
        [DataMember]
		public virtual decimal HaoMonNamNte
        {
            get { return _HaoMonNamNte; }
			set
			{
				OnHaoMonNamNteChanging();
				_HaoMonNamNte = value;
				OnHaoMonNamNteChanged();
			}
        }
		partial void OnHaoMonNamNteChanging();
		partial void OnHaoMonNamNteChanged();
		
        [DataMember]
		public virtual decimal HaoMonLk
        {
            get { return _HaoMonLk; }
			set
			{
				OnHaoMonLkChanging();
				_HaoMonLk = value;
				OnHaoMonLkChanged();
			}
        }
		partial void OnHaoMonLkChanging();
		partial void OnHaoMonLkChanged();
		
        [DataMember]
		public virtual decimal HaoMonLkNte
        {
            get { return _HaoMonLkNte; }
			set
			{
				OnHaoMonLkNteChanging();
				_HaoMonLkNte = value;
				OnHaoMonLkNteChanged();
			}
        }
		partial void OnHaoMonLkNteChanging();
		partial void OnHaoMonLkNteChanged();
		
        [DataMember]
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
		
        [DataMember]
		public virtual decimal GiaTriClNte
        {
            get { return _GiaTriClNte; }
			set
			{
				OnGiaTriClNteChanging();
				_GiaTriClNte = value;
				OnGiaTriClNteChanged();
			}
        }
		partial void OnGiaTriClNteChanging();
		partial void OnGiaTriClNteChanged();
		
        [DataMember]
		public virtual decimal SanluongCongsuat
        {
            get { return _SanluongCongsuat; }
			set
			{
				OnSanluongCongsuatChanging();
				_SanluongCongsuat = value;
				OnSanluongCongsuatChanged();
			}
        }
		partial void OnSanluongCongsuatChanging();
		partial void OnSanluongCongsuatChanged();
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
		public virtual decimal LoaiPpKh
        {
            get { return _LoaiPpKh; }
			set
			{
				OnLoaiPpKhChanging();
				_LoaiPpKh = value;
				OnLoaiPpKhChanged();
			}
        }
		partial void OnLoaiPpKhChanging();
		partial void OnLoaiPpKhChanged();
		
        [DataMember]
		public virtual string TenPpKh
        {
            get { return _TenPpKh; }
			set
			{
				OnTenPpKhChanging();
				_TenPpKh = value;
				OnTenPpKhChanged();
			}
        }
		partial void OnTenPpKhChanging();
		partial void OnTenPpKhChanged();
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
		public virtual string MdTkTs
        {
            get { return _MdTkTs; }
			set
			{
				OnMdTkTsChanging();
				_MdTkTs = value;
				OnMdTkTsChanged();
			}
        }
		partial void OnMdTkTsChanging();
		partial void OnMdTkTsChanged();
		
        [DataMember]
		public virtual string MdTkKhauhao
        {
            get { return _MdTkKhauhao; }
			set
			{
				OnMdTkKhauhaoChanging();
				_MdTkKhauhao = value;
				OnMdTkKhauhaoChanged();
			}
        }
		partial void OnMdTkKhauhaoChanging();
		partial void OnMdTkKhauhaoChanged();
		
        [DataMember]
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
		
        [DataMember]
		public virtual decimal GiamTscd
        {
            get { return _GiamTscd; }
			set
			{
				OnGiamTscdChanging();
				_GiamTscd = value;
				OnGiamTscdChanged();
			}
        }
		partial void OnGiamTscdChanging();
		partial void OnGiamTscdChanged();
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
		public virtual decimal SoThangSd
        {
            get { return _SoThangSd; }
			set
			{
				OnSoThangSdChanging();
				_SoThangSd = value;
				OnSoThangSdChanged();
			}
        }
		partial void OnSoThangSdChanging();
		partial void OnSoThangSdChanged();
		
        [DataMember]
		public virtual System.DateTime? NgayTang
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
		
        [DataMember]
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
		
        [DataMember]
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
		
        [DataMember]
		public virtual System.DateTime? NgayGiam
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
		
        [DataMember]
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

        /// <summary>
        /// Returns whether or not the object has changed it's values.
        /// </summary>
        [DataMember]
        public Decimal? IsDeleted
        {
            get { return _IsDeleted; }
            set
            {
                if (value == null)
                    _IsDeleted = 0;
                else
                    _IsDeleted = value;
            }
        }

        [DataMember]
        public DateTime SynDate
        {
            get { return _SynDate; }
            set { _SynDate = value; }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
		#endregion
    }
}
