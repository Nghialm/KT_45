using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaDmNhanvien : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations


        private string _Ma = string.Empty;
        private string _KyHieu = string.Empty;
        private string _Ten = string.Empty;
		private System.DateTime _NgaySinh = new DateTime();
        private string _SoDienThoai = string.Empty;
		private bool _DaNghiViec = default(Boolean);
        private string _MoTa = string.Empty;
        private Guid _DonviId = Null.NullGuid;
		
		
		
        #endregion

        #region Constructors

        public SpaDmNhanvien() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_KyHieu);
			sb.Append(_Ten);
			sb.Append(_NgaySinh);
			sb.Append(_SoDienThoai);
			sb.Append(_DaNghiViec);
            sb.Append(_MoTa);
            sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public SpaDmNhanvien Clone()
        {
            return (SpaDmNhanvien)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaDmNhanvien des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_KyHieu = des.KyHieu;
			_Ten = des.Ten;
			_NgaySinh = des.NgaySinh;
			_SoDienThoai = des.SoDienThoai;
			_DaNghiViec = des.DaNghiViec;
            _MoTa = des.MoTa;
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
		
		public virtual System.DateTime NgaySinh
        {
            get { return _NgaySinh; }
			set
			{
				OnNgaySinhChanging();
				_NgaySinh = value;
				OnNgaySinhChanged();
			}
        }
		partial void OnNgaySinhChanging();
		partial void OnNgaySinhChanged();
		
		public virtual string SoDienThoai
        {
            get { return _SoDienThoai; }
			set
			{
				OnSoDienThoaiChanging();
				_SoDienThoai = value;
				OnSoDienThoaiChanged();
			}
        }
		partial void OnSoDienThoaiChanging();
		partial void OnSoDienThoaiChanged();
		
		public virtual bool DaNghiViec
        {
            get { return _DaNghiViec; }
			set
			{
				OnDaNghiViecChanging();
				_DaNghiViec = value;
				OnDaNghiViecChanged();
			}
        }
		partial void OnDaNghiViecChanging();
		partial void OnDaNghiViecChanged();
		
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
