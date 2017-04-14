using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaLsThe : DomainObject<string>, INotifyPropertyChanged
    {
        #region Declarations

		private System.Guid _Theid = new Guid();
		private System.Guid _Mphieuid = new Guid();
		
		private string _Mathe = String.Empty;
		private string _Tenkhachhang = String.Empty;
		private System.DateTime _Ngaythanhtoan = new DateTime();
		private decimal _Sotien = 0;
		private string _Noidung = String.Empty;
        private decimal _TienThe = 0;
        private decimal _TienKhuyenMai = 0;
		
		
        #endregion

        #region Constructors

        public SpaLsThe() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Mathe);
			sb.Append(_Tenkhachhang);
			sb.Append(_Ngaythanhtoan);
			sb.Append(_Sotien);
			sb.Append(_Noidung);
            sb.Append(_TienThe);
            sb.Append(_TienKhuyenMai);

            return sb.ToString().GetHashCode();
        }
		
		public SpaLsThe Clone()
        {
            return (SpaLsThe)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaLsThe des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Mathe = des.Mathe;
			_Tenkhachhang = des.Tenkhachhang;
			_Ngaythanhtoan = des.Ngaythanhtoan;
			_Sotien = des.Sotien;
			_Noidung = des.Noidung;
            _TienThe = des.TienThe;
            _TienKhuyenMai = des.TienKhuyenMai;
        }

        #endregion

        #region Properties

		public override string Id
		{
			get
			{
				System.Text.StringBuilder uniqueId = new System.Text.StringBuilder();
				uniqueId.Append(_Theid.ToString());
				uniqueId.Append("^");
				uniqueId.Append(_Mphieuid.ToString());
				return uniqueId.ToString();
			}
		}
		
		public virtual System.Guid Theid
        {
            get { return _Theid; }
			set
			{
				
				OnTheidChanging();
				_Theid = value;
				OnTheidChanged();
			}
        }
		partial void OnTheidChanging();
		partial void OnTheidChanged();
		
		public virtual System.Guid Mphieuid
        {
            get { return _Mphieuid; }
			set
			{
				
				OnMphieuidChanging();
				_Mphieuid = value;
				OnMphieuidChanged();
			}
        }
		partial void OnMphieuidChanging();
		partial void OnMphieuidChanged();
		
		public virtual string Mathe
        {
            get { return _Mathe; }
			set
			{
				OnMatheChanging();
				_Mathe = value;
				OnMatheChanged();
			}
        }
		partial void OnMatheChanging();
		partial void OnMatheChanged();
		
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
		
		public virtual System.DateTime Ngaythanhtoan
        {
            get { return _Ngaythanhtoan; }
			set
			{
				OnNgaythanhtoanChanging();
				_Ngaythanhtoan = value;
				OnNgaythanhtoanChanged();
			}
        }
		partial void OnNgaythanhtoanChanging();
		partial void OnNgaythanhtoanChanged();
		
		public virtual decimal Sotien
        {
            get { return _Sotien; }
			set
			{
				OnSotienChanging();
				_Sotien = value;
				OnSotienChanged();
			}
        }
		partial void OnSotienChanging();
		partial void OnSotienChanged();
		
		public virtual string Noidung
        {
            get { return _Noidung; }
			set
			{
				OnNoidungChanging();
				_Noidung = value;
				OnNoidungChanged();
			}
        }
		partial void OnNoidungChanging();
		partial void OnNoidungChanged();

        public virtual decimal TienThe
        {
            get { return _TienThe; }
            set
            {
                OnTienTheChanging();
                _TienThe = value;
                OnTienTheChanged();
            }
        }
        partial void OnTienTheChanging();
        partial void OnTienTheChanged();

        public virtual decimal TienKhuyenMai
        {
            get { return _TienKhuyenMai; }
            set
            {
                OnTienKhuyenMaiChanging();
                _TienKhuyenMai = value;
                OnTienKhuyenMaiChanged();
            }
        }
        partial void OnTienKhuyenMaiChanging();
        partial void OnTienKhuyenMaiChanged();
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
