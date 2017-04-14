using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxLenhsanxuat : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _KehoachMId = new Guid();
		private System.Guid _PhancongId = new Guid();
		private System.Guid _TosanxuatId = new Guid();
		private System.DateTime _NgayBanHanh = Null.MIN_DATE;
		private string _NguoiBanHanh = String.Empty;
		private System.DateTime _NgayGiaoLenh = Null.MIN_DATE;
		private string _NguoiGiaoLenh = String.Empty;
		private string _SoLenhSanXuat = String.Empty;
		private string _MoTa = String.Empty;
		private int _TrangThai = 0;
        private int _SoNhanCong = 0;
        private Guid _KhachHangId = new Guid();
        private string _MaKhachHang = String.Empty;
        private string _TenKhachHang = String.Empty;
        private string _SoKeHoach = String.Empty;
        private int _BuocPhanCong = 0;
        private Guid _QuyTrinhId = new Guid();
        private string _MaQuyTrinh = String.Empty;
        private string _MaToSanXuat = String.Empty;
        private Guid _IdLoaiCt = new Guid();
        private string _KyHieuLoaiCt = String.Empty;
        private string _MaLoaiCt = String.Empty;
        private string _PrefixCt = String.Empty;
        private System.Guid _DonviId = new Guid();

        private System.DateTime _NgayBatDau = Null.MIN_DATE;
        private System.DateTime _NgayKetThuc = Null.MAX_DATE;

        
        #endregion

        #region Constructors

        public SxLenhsanxuat() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_KehoachMId);
			sb.Append(_PhancongId);
			sb.Append(_TosanxuatId);
			sb.Append(_NgayBanHanh);
			sb.Append(_NguoiBanHanh);
			sb.Append(_NgayGiaoLenh);
			sb.Append(_NguoiGiaoLenh);
			sb.Append(_SoLenhSanXuat);
			sb.Append(_MoTa);
			sb.Append(_TrangThai);
            sb.Append(_SoNhanCong);
            sb.Append(_KhachHangId);
            sb.Append(_MaKhachHang);
            sb.Append(_TenKhachHang);
            sb.Append(_SoKeHoach);
            sb.Append(_BuocPhanCong);
            sb.Append(_QuyTrinhId);
            sb.Append(_MaQuyTrinh);
            sb.Append(_MaToSanXuat);
            sb.Append(_IdLoaiCt);
            sb.Append(_MaLoaiCt);
            sb.Append(_KyHieuLoaiCt);
            sb.Append(_PrefixCt);

            sb.Append(_NgayBatDau);
            sb.Append(_NgayKetThuc);


            return sb.ToString().GetHashCode();
        }
		
		public SxLenhsanxuat Clone()
        {
            return (SxLenhsanxuat)this.MemberwiseClone();
        }
		
		public void SetProperty(SxLenhsanxuat des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_KehoachMId = des.KehoachMId;
			_PhancongId = des.PhancongId;
			_TosanxuatId = des.TosanxuatId;
			_NgayBanHanh = des.NgayBanHanh;
			_NguoiBanHanh = des.NguoiBanHanh;
			_NgayGiaoLenh = des.NgayGiaoLenh;
			_NguoiGiaoLenh = des.NguoiGiaoLenh;
			_SoLenhSanXuat = des.SoLenhSanXuat;
			_MoTa = des.MoTa;
			_TrangThai = des.TrangThai;
            _SoNhanCong = des.SoNhanCong;
            _KhachHangId = des.KhachHangId;

            _MaKhachHang = des.MaKhachHang;
            _TenKhachHang = des.TenKhachHang;
            _SoKeHoach = des.SoKeHoach;
            _BuocPhanCong = des.BuocPhanCong;
            _QuyTrinhId = des.QuyTrinhId;
            _MaQuyTrinh = des.MaQuyTrinh;
            _MaToSanXuat = des.MaToSanXuat;
            _IdLoaiCt = des.IdLoaiCt;
            _MaLoaiCt = des.MaLoaiCt;
            _KyHieuLoaiCt = des.KyHieuLoaiCt;
            _PrefixCt = des.PrefixCt;

            _NgayBatDau = des.NgayBatDau;
            _NgayKetThuc = des.NgayKetThuc;
		}

        #endregion

        #region Properties

		public virtual System.Guid KehoachMId
        {
            get { return _KehoachMId; }
			set
			{
				OnKehoachMIdChanging();
				_KehoachMId = value;
				OnKehoachMIdChanged();
			}
        }
		partial void OnKehoachMIdChanging();
		partial void OnKehoachMIdChanged();


        public virtual System.Guid IdLoaiCt
        {
            get { return _IdLoaiCt; }
            set
            {
                OnIdLoaiCtChanging();
                _IdLoaiCt = value;
                OnIdLoaiCtChanged();
            }
        }
        partial void OnIdLoaiCtChanging();
        partial void OnIdLoaiCtChanged();

        public virtual System.Guid KhachHangId
        {
            get { return _KhachHangId; }
            set
            {
                OnKhachHangIdChanging();
                _KhachHangId = value;
                OnKhachHangIdChanged();
            }
        }
        partial void OnKhachHangIdChanging();
        partial void OnKhachHangIdChanged();

        public virtual System.Guid QuyTrinhId
        {
            get { return _QuyTrinhId; }
            set
            {
                OnQuyTrinhIdChanging();
                _QuyTrinhId = value;
                OnQuyTrinhIdChanged();
            }
        }
        partial void OnQuyTrinhIdChanging();
        partial void OnQuyTrinhIdChanged();

		public virtual System.Guid PhancongId
        {
            get { return _PhancongId; }
			set
			{
				OnPhancongIdChanging();
				_PhancongId = value;
				OnPhancongIdChanged();
			}
        }
		partial void OnPhancongIdChanging();
		partial void OnPhancongIdChanged();
		
		public virtual System.Guid TosanxuatId
        {
            get { return _TosanxuatId; }
			set
			{
				OnTosanxuatIdChanging();
				_TosanxuatId = value;
				OnTosanxuatIdChanged();
			}
        }
		partial void OnTosanxuatIdChanging();
		partial void OnTosanxuatIdChanged();
		
		public virtual System.DateTime NgayBanHanh
        {
            get { return _NgayBanHanh; }
			set
			{
				OnNgayBanHanhChanging();
				_NgayBanHanh = value;
				OnNgayBanHanhChanged();
			}
        }
		partial void OnNgayBanHanhChanging();
		partial void OnNgayBanHanhChanged();
		
		public virtual string NguoiBanHanh
        {
            get { return _NguoiBanHanh; }
			set
			{
				OnNguoiBanHanhChanging();
				_NguoiBanHanh = value;
				OnNguoiBanHanhChanged();
			}
        }
		partial void OnNguoiBanHanhChanging();
		partial void OnNguoiBanHanhChanged();

        public virtual string MaLoaiCt
        {
            get { return _MaLoaiCt; }
            set
            {
                OnMaLoaiCtChanging();
                _MaLoaiCt = value;
                OnMaLoaiCtChanged();
            }
        }
        partial void OnMaLoaiCtChanging();
        partial void OnMaLoaiCtChanged();


        public virtual string PrefixCt
        {
            get { return _PrefixCt; }
            set
            {
                OnPrefixCtChanging();
                _PrefixCt = value;
                OnPrefixCtChanged();
            }
        }
        partial void OnPrefixCtChanging();
        partial void OnPrefixCtChanged();


        public virtual string KyHieuLoaiCt
        {
            get { return _KyHieuLoaiCt; }
            set
            {
                OnKyHieuLoaiCtChanging();
                _KyHieuLoaiCt = value;
                OnKyHieuLoaiCtChanged();
            }
        }
        partial void OnKyHieuLoaiCtChanging();
        partial void OnKyHieuLoaiCtChanged();

		public virtual System.DateTime NgayGiaoLenh
        {
            get { return _NgayGiaoLenh; }
			set
			{
				OnNgayGiaoLenhChanging();
				_NgayGiaoLenh = value;
				OnNgayGiaoLenhChanged();
			}
        }
		partial void OnNgayGiaoLenhChanging();
		partial void OnNgayGiaoLenhChanged();
		
		public virtual string NguoiGiaoLenh
        {
            get { return _NguoiGiaoLenh; }
			set
			{
				OnNguoiGiaoLenhChanging();
				_NguoiGiaoLenh = value;
				OnNguoiGiaoLenhChanged();
			}
        }
		partial void OnNguoiGiaoLenhChanging();
		partial void OnNguoiGiaoLenhChanged();
		
		public virtual string SoLenhSanXuat
        {
            get { return _SoLenhSanXuat; }
			set
			{
				OnSoLenhSanXuatChanging();
				_SoLenhSanXuat = value;
				OnSoLenhSanXuatChanged();
			}
        }
		partial void OnSoLenhSanXuatChanging();
		partial void OnSoLenhSanXuatChanged();
		
		public virtual string MoTa
        {
            get { return _MoTa; }
			set
			{
				OnMoTaChanging();
				_MoTa = value;
				OnMoTaChanged();
			}
        }
		partial void OnMoTaChanging();
		partial void OnMoTaChanged();
		
		public virtual int TrangThai
        {
            get { return _TrangThai; }
			set
			{
				OnTrangThaiChanging();
				_TrangThai = value;
				OnTrangThaiChanged();
			}
        }
		partial void OnTrangThaiChanging();
		partial void OnTrangThaiChanged();
		
        public virtual int SoNhanCong
        {
            get { return _SoNhanCong; }
			set
			{
				OnSoNhanCongChanging();
				_SoNhanCong = value;
				OnSoNhanCongChanged();
			}
        }
		partial void OnSoNhanCongChanging();
		partial void OnSoNhanCongChanged();

        public virtual string MaKhachHang
        {
            get { return _MaKhachHang; }
            set
            {
                OnMaKhachHangChanging();
                _MaKhachHang = value;
                OnMaKhachHangChanged();
            }
        }
        partial void OnMaKhachHangChanging();
        partial void OnMaKhachHangChanged();

        public virtual string TenKhachHang
        {
            get { return _TenKhachHang; }
            set
            {
                OnTenKhachHangChanging();
                _TenKhachHang = value;
                OnTenKhachHangChanged();
            }
        }
        partial void OnTenKhachHangChanging();
        partial void OnTenKhachHangChanged();

        public virtual string MaQuyTrinh
        {
            get { return _MaQuyTrinh; }
            set
            {
                OnMaQuyTrinhChanging();
                _MaQuyTrinh = value;
                OnMaQuyTrinhChanged();
            }
        }
        partial void OnMaQuyTrinhChanging();
        partial void OnMaQuyTrinhChanged();

        public virtual string MaToSanXuat
        {
            get { return _MaToSanXuat; }
            set
            {
                OnMaToSanXuatChanging();
                _MaToSanXuat = value;
                OnMaToSanXuatChanged();
            }
        }
        partial void OnMaToSanXuatChanging();
        partial void OnMaToSanXuatChanged();


        public virtual string SoKeHoach
        {
            get { return _SoKeHoach; }
            set
            {
                OnSoKeHoachChanging();
                _SoKeHoach = value;
                OnSoKeHoachChanged();
            }
        }
        partial void OnSoKeHoachChanging();
        partial void OnSoKeHoachChanged();

        public virtual int BuocPhanCong
        {
            get { return _BuocPhanCong; }
            set
            {
                OnBuocPhanCongChanging();
                _BuocPhanCong = value;
                OnBuocPhanCongChanged();
            }
        }
        partial void OnBuocPhanCongChanging();
        partial void OnBuocPhanCongChanged();

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

        public System.DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }

        public System.DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
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
