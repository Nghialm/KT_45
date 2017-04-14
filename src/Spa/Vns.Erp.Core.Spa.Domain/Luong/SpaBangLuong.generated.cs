using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaBangLuong : DomainObject<string>, INotifyPropertyChanged
    {
        #region Declarations

		private System.Guid _NhanVienId = new Guid();
		private System.DateTime _ThangLuong = new DateTime();
		
		private decimal _SoTienLuong = 0;
		private decimal _SoTienThuong = 0;
		private decimal _SoTienHoaHong = 0;
		private decimal _SoTienPhat = 0;
		private System.Guid _DonViId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public SpaBangLuong() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_SoTienLuong);
			sb.Append(_SoTienThuong);
			sb.Append(_SoTienHoaHong);
			sb.Append(_SoTienPhat);
			sb.Append(_DonViId);

            return sb.ToString().GetHashCode();
        }
		
		public SpaBangLuong Clone()
        {
            return (SpaBangLuong)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaBangLuong des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_SoTienLuong = des.SoTienLuong;
			_SoTienThuong = des.SoTienThuong;
			_SoTienHoaHong = des.SoTienHoaHong;
			_SoTienPhat = des.SoTienPhat;
			_DonViId = des.DonViId;
		}

        #endregion

        #region Properties

		public override string Id
		{
			get
			{
				System.Text.StringBuilder uniqueId = new System.Text.StringBuilder();
				uniqueId.Append(_NhanVienId.ToString());
				uniqueId.Append("^");
				uniqueId.Append(_ThangLuong.ToString());
				return uniqueId.ToString();
			}
		}
		
		public virtual System.Guid NhanVienId
        {
            get { return _NhanVienId; }
			set
			{
				
				OnNhanVienIdChanging();
				_NhanVienId = value;
				OnNhanVienIdChanged();
			}
        }
		partial void OnNhanVienIdChanging();
		partial void OnNhanVienIdChanged();
		
		public virtual System.DateTime ThangLuong
        {
            get { return _ThangLuong; }
			set
			{
				
				OnThangLuongChanging();
				_ThangLuong = value;
				OnThangLuongChanged();
			}
        }
		partial void OnThangLuongChanging();
		partial void OnThangLuongChanged();
		
		public virtual decimal SoTienLuong
        {
            get { return _SoTienLuong; }
			set
			{
				OnSoTienLuongChanging();
				_SoTienLuong = value;
				OnSoTienLuongChanged();
			}
        }
		partial void OnSoTienLuongChanging();
		partial void OnSoTienLuongChanged();
		
		public virtual decimal SoTienThuong
        {
            get { return _SoTienThuong; }
			set
			{
				OnSoTienThuongChanging();
				_SoTienThuong = value;
				OnSoTienThuongChanged();
			}
        }
		partial void OnSoTienThuongChanging();
		partial void OnSoTienThuongChanged();
		
		public virtual decimal SoTienHoaHong
        {
            get { return _SoTienHoaHong; }
			set
			{
				OnSoTienHoaHongChanging();
				_SoTienHoaHong = value;
				OnSoTienHoaHongChanged();
			}
        }
		partial void OnSoTienHoaHongChanging();
		partial void OnSoTienHoaHongChanged();
		
		public virtual decimal SoTienPhat
        {
            get { return _SoTienPhat; }
			set
			{
				OnSoTienPhatChanging();
				_SoTienPhat = value;
				OnSoTienPhatChanged();
			}
        }
		partial void OnSoTienPhatChanging();
		partial void OnSoTienPhatChanged();
		
		public virtual System.Guid DonViId
        {
            get { return _DonViId; }
			set
			{
				OnDonViIdChanging();
				_DonViId = value;
				OnDonViIdChanged();
			}
        }
		partial void OnDonViIdChanging();
		partial void OnDonViIdChanged();
		
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
