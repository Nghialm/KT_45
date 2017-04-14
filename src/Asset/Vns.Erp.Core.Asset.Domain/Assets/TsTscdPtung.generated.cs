using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
    public partial class TsTscdPtung : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _TenPtung = String.Empty;
		private string _TenDvt = String.Empty;
		private decimal _SoLuong = default(Decimal);
		private decimal _SoTien = default(Decimal);
		private decimal _SoTienNte = default(Decimal);
		private string _QuyCach = String.Empty;
		private string _DienGiai = String.Empty;
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = String.Empty;
		private System.Guid _DmTscdId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public TsTscdPtung() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_TenPtung);
			sb.Append(_TenDvt);
			sb.Append(_SoLuong);
			sb.Append(_SoTien);
			sb.Append(_SoTienNte);
			sb.Append(_QuyCach);
			sb.Append(_DienGiai);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);
			sb.Append(_DmTscdId);

            return sb.ToString().GetHashCode();
        }
		
		public TsTscdPtung Clone()
        {
            return (TsTscdPtung)this.MemberwiseClone();
        }
		
		public void SetProperty(TsTscdPtung des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_TenPtung = des.TenPtung;
			_TenDvt = des.TenDvt;
			_SoLuong = des.SoLuong;
			_SoTien = des.SoTien;
			_SoTienNte = des.SoTienNte;
			_QuyCach = des.QuyCach;
			_DienGiai = des.DienGiai;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
			_DmTscdId = des.DmTscdId;
		}

        #endregion

        #region Properties

		public virtual string TenPtung
        {
            get { return _TenPtung; }
			set
			{
				OnTenPtungChanging();
				_TenPtung = value;
				OnTenPtungChanged();
			}
        }
		partial void OnTenPtungChanging();
		partial void OnTenPtungChanged();
		
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
		
		public virtual decimal SoTien
        {
            get { return _SoTien; }
			set
			{
				OnSoTienChanging();
				_SoTien = value;
				OnSoTienChanged();
			}
        }
		partial void OnSoTienChanging();
		partial void OnSoTienChanged();
		
		public virtual decimal SoTienNte
        {
            get { return _SoTienNte; }
			set
			{
				OnSoTienNteChanging();
				_SoTienNte = value;
				OnSoTienNteChanged();
			}
        }
		partial void OnSoTienNteChanging();
		partial void OnSoTienNteChanged();
		
		public virtual string QuyCach
        {
            get { return _QuyCach; }
			set
			{
				OnQuyCachChanging();
				_QuyCach = value;
				OnQuyCachChanged();
			}
        }
		partial void OnQuyCachChanging();
		partial void OnQuyCachChanged();
		
		public virtual string DienGiai
        {
            get { return _DienGiai; }
			set
			{
				OnDienGiaiChanging();
				_DienGiai = value;
				OnDienGiaiChanged();
			}
        }
		partial void OnDienGiaiChanging();
		partial void OnDienGiaiChanged();
		
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
		
		public virtual System.Guid DmTscdId
        {
            get { return _DmTscdId; }
			set
			{
				OnDmTscdIdChanging();
				_DmTscdId = value;
				OnDmTscdIdChanged();
			}
        }
		partial void OnDmTscdIdChanging();
		partial void OnDmTscdIdChanged();
		
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
