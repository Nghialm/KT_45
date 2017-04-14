using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaDmGuongdv : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
        private string _Kyhieu = String.Empty;
		private string _Ten = String.Empty;
		private string _Mota = String.Empty;
        private System.DateTime? _Ngaytao;
        private Guid _Nguoitao = new Guid();
		private System.Guid _Donviid = new Guid();
		private bool _Cosudung = default(Boolean);
		
		
		
        #endregion

        #region Constructors

        public SpaDmGuongdv() { }

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
			sb.Append(_Ngaytao);
			sb.Append(_Nguoitao);
			sb.Append(_Donviid);
			sb.Append(_Cosudung);

            return sb.ToString().GetHashCode();
        }
		
		public SpaDmGuongdv Clone()
        {
            return (SpaDmGuongdv)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaDmGuongdv des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_Kyhieu = des.Kyhieu;
			_Ten = des.Ten;
			_Mota = des.Mota;
			_Ngaytao = des.Ngaytao;
			_Nguoitao = des.Nguoitao;
			_Donviid = des.Donviid;
			_Cosudung = des.Cosudung;
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
		
		public virtual System.Guid Donviid
        {
            get { return _Donviid; }
			set
			{
				OnDonviidChanging();
				_Donviid = value;
				OnDonviidChanged();
			}
        }
		partial void OnDonviidChanging();
		partial void OnDonviidChanged();
		
		public virtual bool Cosudung
        {
            get { return _Cosudung; }
			set
			{
				OnCosudungChanging();
				_Cosudung = value;
				OnCosudungChanged();
			}
        }
		partial void OnCosudungChanging();
		partial void OnCosudungChanged();
		
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
