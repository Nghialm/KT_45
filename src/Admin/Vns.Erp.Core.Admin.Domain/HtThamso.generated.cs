using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class HtThamso : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations


        private string _MaThamso = String.Empty;
        private string _TenThamso = String.Empty;
        private string _GiaTri = String.Empty;
        private string _GiaTriMd = String.Empty;
        private string _MoTa = String.Empty;
		private System.Guid _GroupId = new Guid();
		private System.Guid _DonviId = new Guid();
        private string _MaDonvi = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public HtThamso() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_MaThamso);
			sb.Append(_TenThamso);
			sb.Append(_GiaTri);
			sb.Append(_GiaTriMd);
			sb.Append(_MoTa);
			sb.Append(_GroupId);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);

            return sb.ToString().GetHashCode();
        }
		
		public HtThamso Clone()
        {
            return (HtThamso)this.MemberwiseClone();
        }
		
		public void SetProperty(HtThamso des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_MaThamso = des.MaThamso;
			_TenThamso = des.TenThamso;
			_GiaTri = des.GiaTri;
			_GiaTriMd = des.GiaTriMd;
			_MoTa = des.MoTa;
			_GroupId = des.GroupId;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
		}

        #endregion

        #region Properties

		public virtual string MaThamso
        {
            get { return _MaThamso; }
			set
			{
				OnMaThamsoChanging();
				_MaThamso = value;
				OnMaThamsoChanged();
			}
        }
		partial void OnMaThamsoChanging();
		partial void OnMaThamsoChanged();
		
		public virtual string TenThamso
        {
            get { return _TenThamso; }
			set
			{
				OnTenThamsoChanging();
				_TenThamso = value;
				OnTenThamsoChanged();
			}
        }
		partial void OnTenThamsoChanging();
		partial void OnTenThamsoChanged();
		
		public virtual string GiaTri
        {
            get { return _GiaTri; }
			set
			{
				OnGiaTriChanging();
				_GiaTri = value;
				OnGiaTriChanged();
			}
        }
		partial void OnGiaTriChanging();
		partial void OnGiaTriChanged();
		
		public virtual string GiaTriMd
        {
            get { return _GiaTriMd; }
			set
			{
				OnGiaTriMdChanging();
				_GiaTriMd = value;
				OnGiaTriMdChanged();
			}
        }
		partial void OnGiaTriMdChanging();
		partial void OnGiaTriMdChanged();
		
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
		
		public virtual System.Guid GroupId
        {
            get { return _GroupId; }
			set
			{
				OnGroupIdChanging();
				_GroupId = value;
				OnGroupIdChanged();
			}
        }
		partial void OnGroupIdChanging();
		partial void OnGroupIdChanged();
		
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
