using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaDmThe : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
		private string _Kyhieu = String.Empty;
		private string _Ten = String.Empty;
		private string _Mota = String.Empty;
		private decimal _Menhgia = 0;
		private decimal _Giatien = 0;
		private System.DateTime? _Ngayphathanh = new DateTime();
		private System.DateTime? _Ngayban = new DateTime();
		private System.DateTime? _Ngayhethan = new DateTime();
		private bool _Dasudung = default(Boolean);
		private bool _Dakhoa = default(Boolean);
		private bool _Dahethan = default(Boolean);
		private decimal _Sotienconlai = 0;
		private System.Guid _Khachhangid = new Guid();
		private string _Tenkhachhang = String.Empty;
		private string _Diachi = String.Empty;
		private string _Sodienthoai = String.Empty;
		private Guid _Loaidichvuid = new Guid();
		private int _Sobuoi = 0;
		private System.DateTime? _Ngaytao = new DateTime();
		private Guid _Nguoitao = new Guid();
        private Guid _DonviId = Null.NullGuid;
		
		
		
        #endregion

        #region Constructors

        public SpaDmThe() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_Kyhieu);
			sb.Append(_Ten);
			sb.Append(_Mota);
			sb.Append(_Menhgia);
			sb.Append(_Giatien);
			sb.Append(_Ngayphathanh);
			sb.Append(_Ngayban);
			sb.Append(_Ngayhethan);
			sb.Append(_Dasudung);
			sb.Append(_Dakhoa);
			sb.Append(_Dahethan);
			sb.Append(_Sotienconlai);
			sb.Append(_Khachhangid);
			sb.Append(_Tenkhachhang);
			sb.Append(_Diachi);
			sb.Append(_Sodienthoai);
			sb.Append(_Loaidichvuid);
			sb.Append(_Sobuoi);
			sb.Append(_Ngaytao);
            sb.Append(_Nguoitao);
            sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public SpaDmThe Clone()
        {
            return (SpaDmThe)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaDmThe des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_Kyhieu = des.Kyhieu;
			_Ten = des.Ten;
			_Mota = des.Mota;
			_Menhgia = des.Menhgia;
			_Giatien = des.Giatien;
			_Ngayphathanh = des.Ngayphathanh;
			_Ngayban = des.Ngayban;
			_Ngayhethan = des.Ngayhethan;
			_Dasudung = des.Dasudung;
			_Dakhoa = des.Dakhoa;
			_Dahethan = des.Dahethan;
			_Sotienconlai = des.Sotienconlai;
			_Khachhangid = des.Khachhangid;
			_Tenkhachhang = des.Tenkhachhang;
			_Diachi = des.Diachi;
			_Sodienthoai = des.Sodienthoai;
			_Loaidichvuid = des.Loaidichvuid;
			_Sobuoi = des.Sobuoi;
			_Ngaytao = des.Ngaytao;
            _Nguoitao = des.Nguoitao;
            _DonviId = des.DonviId;
		}

        #endregion

        #region Properties

		public virtual string Ma
        {
            get { return _Ma; }
			set
			{
				OnMaChanging();
				_Ma = value;
				OnMaChanged();
			}
        }
		partial void OnMaChanging();
		partial void OnMaChanged();
		
		public virtual string Kyhieu
        {
            get { return _Kyhieu; }
			set
			{
				OnKyhieuChanging();
				_Kyhieu = value;
				OnKyhieuChanged();
			}
        }
		partial void OnKyhieuChanging();
		partial void OnKyhieuChanged();
		
		public virtual string Ten
        {
            get { return _Ten; }
			set
			{
				OnTenChanging();
				_Ten = value;
				OnTenChanged();
			}
        }
		partial void OnTenChanging();
		partial void OnTenChanged();
		
		public virtual string Mota
        {
            get { return _Mota; }
			set
			{
				OnMotaChanging();
				_Mota = value;
				OnMotaChanged();
			}
        }
		partial void OnMotaChanging();
		partial void OnMotaChanged();
		
		public virtual decimal Menhgia
        {
            get { return _Menhgia; }
			set
			{
				OnMenhgiaChanging();
                _Menhgia = Decimal.Round(value);
				OnMenhgiaChanged();
			}
        }
		partial void OnMenhgiaChanging();
		partial void OnMenhgiaChanged();
		
		public virtual decimal Giatien
        {
            get { return _Giatien; }
			set
			{
				OnGiatienChanging();
                _Giatien = Decimal.Round(value);
				OnGiatienChanged();
			}
        }
		partial void OnGiatienChanging();
		partial void OnGiatienChanged();
		
		public virtual System.DateTime? Ngayphathanh
        {
            get { return _Ngayphathanh; }
			set
			{
				OnNgayphathanhChanging();
				_Ngayphathanh = value;
				OnNgayphathanhChanged();
			}
        }
		partial void OnNgayphathanhChanging();
		partial void OnNgayphathanhChanged();
		
		public virtual System.DateTime? Ngayban
        {
            get { return _Ngayban; }
			set
			{
				OnNgaybanChanging();
				_Ngayban = value;
				OnNgaybanChanged();
			}
        }
		partial void OnNgaybanChanging();
		partial void OnNgaybanChanged();
		
		public virtual System.DateTime? Ngayhethan
        {
            get { return _Ngayhethan; }
			set
			{
				OnNgayhethanChanging();
				_Ngayhethan = value;
				OnNgayhethanChanged();
			}
        }
		partial void OnNgayhethanChanging();
		partial void OnNgayhethanChanged();
		
		public virtual bool Dasudung
        {
            get { return _Dasudung; }
			set
			{
				OnDasudungChanging();
				_Dasudung = value;
				OnDasudungChanged();
			}
        }
		partial void OnDasudungChanging();
		partial void OnDasudungChanged();
		
		public virtual bool Dakhoa
        {
            get { return _Dakhoa; }
			set
			{
				OnDakhoaChanging();
				_Dakhoa = value;
				OnDakhoaChanged();
			}
        }
		partial void OnDakhoaChanging();
		partial void OnDakhoaChanged();
		
		public virtual bool Dahethan
        {
            get { return _Dahethan; }
			set
			{
				OnDahethanChanging();
				_Dahethan = value;
				OnDahethanChanged();
			}
        }
		partial void OnDahethanChanging();
		partial void OnDahethanChanged();
		
		public virtual decimal Sotienconlai
        {
            get { return _Sotienconlai; }
			set
			{
				OnSotienconlaiChanging();
                _Sotienconlai = Decimal.Round(value);
				OnSotienconlaiChanged();
			}
        }
		partial void OnSotienconlaiChanging();
		partial void OnSotienconlaiChanged();
		
		public virtual System.Guid Khachhangid
        {
            get { return _Khachhangid; }
			set
			{
				OnKhachhangidChanging();
				_Khachhangid = value;
				OnKhachhangidChanged();
			}
        }
		partial void OnKhachhangidChanging();
		partial void OnKhachhangidChanged();
		
		public virtual string Tenkhachhang
        {
            get { return _Tenkhachhang; }
			set
			{
				OnTenkhachhangChanging();
				_Tenkhachhang = value;
				OnTenkhachhangChanged();
			}
        }
		partial void OnTenkhachhangChanging();
		partial void OnTenkhachhangChanged();
		
		public virtual string Diachi
        {
            get { return _Diachi; }
			set
			{
				OnDiachiChanging();
				_Diachi = value;
				OnDiachiChanged();
			}
        }
		partial void OnDiachiChanging();
		partial void OnDiachiChanged();
		
		public virtual string Sodienthoai
        {
            get { return _Sodienthoai; }
			set
			{
				OnSodienthoaiChanging();
				_Sodienthoai = value;
				OnSodienthoaiChanged();
			}
        }
		partial void OnSodienthoaiChanging();
		partial void OnSodienthoaiChanged();
		
		public virtual Guid Loaidichvuid
        {
            get { return _Loaidichvuid; }
			set
			{
				OnLoaidichvuidChanging();
				_Loaidichvuid = value;
				OnLoaidichvuidChanged();
			}
        }
		partial void OnLoaidichvuidChanging();
		partial void OnLoaidichvuidChanged();
		
		public virtual int Sobuoi
        {
            get { return _Sobuoi; }
			set
			{
				OnSobuoiChanging();
				_Sobuoi = value;
				OnSobuoiChanged();
			}
        }
		partial void OnSobuoiChanging();
		partial void OnSobuoiChanged();
		
		public virtual System.DateTime? Ngaytao
        {
            get { return _Ngaytao; }
			set
			{
				OnNgaytaoChanging();
				_Ngaytao = value;
				OnNgaytaoChanged();
			}
        }
		partial void OnNgaytaoChanging();
		partial void OnNgaytaoChanged();
		
		public virtual Guid Nguoitao
        {
            get { return _Nguoitao; }
			set
			{
				OnNguoitaoChanging();
				_Nguoitao = value;
				OnNguoitaoChanged();
			}
        }
		partial void OnNguoitaoChanging();
		partial void OnNguoitaoChanged();

        public virtual Guid DonviId
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
