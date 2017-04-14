using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class KtKhoasoThang : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private decimal _Thang1 = default(Decimal);
		private decimal _Thang2 = default(Decimal);
		private decimal _Thang3 = default(Decimal);
		private decimal _Thang4 = default(Decimal);
		private decimal _Thang5 = default(Decimal);
		private decimal _Thang6 = default(Decimal);
		private decimal _Thang7 = default(Decimal);
		private decimal _Thang8 = default(Decimal);
		private decimal _Thang9 = default(Decimal);
		private decimal _Thang10 = default(Decimal);
		private decimal _Thang11 = default(Decimal);
		private decimal _Thang12 = default(Decimal);
		private decimal _Nam = default(Decimal);
		private System.Guid _DonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public KtKhoasoThang() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Thang1);
			sb.Append(_Thang2);
			sb.Append(_Thang3);
			sb.Append(_Thang4);
			sb.Append(_Thang5);
			sb.Append(_Thang6);
			sb.Append(_Thang7);
			sb.Append(_Thang8);
			sb.Append(_Thang9);
			sb.Append(_Thang10);
			sb.Append(_Thang11);
			sb.Append(_Thang12);
			sb.Append(_Nam);
			sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public KtKhoasoThang Clone()
        {
            return (KtKhoasoThang)this.MemberwiseClone();
        }
		
		public void SetProperty(KtKhoasoThang des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Thang1 = des.Thang1;
			_Thang2 = des.Thang2;
			_Thang3 = des.Thang3;
			_Thang4 = des.Thang4;
			_Thang5 = des.Thang5;
			_Thang6 = des.Thang6;
			_Thang7 = des.Thang7;
			_Thang8 = des.Thang8;
			_Thang9 = des.Thang9;
			_Thang10 = des.Thang10;
			_Thang11 = des.Thang11;
			_Thang12 = des.Thang12;
			_Nam = des.Nam;
			_DonviId = des.DonviId;
		}

        #endregion

        #region Properties

		public virtual decimal Thang1
        {
            get { return _Thang1; }
			set
			{
				OnThang1Changing();
				_Thang1 = value;
				OnThang1Changed();
			}
        }
		partial void OnThang1Changing();
		partial void OnThang1Changed();
		
		public virtual decimal Thang2
        {
            get { return _Thang2; }
			set
			{
				OnThang2Changing();
				_Thang2 = value;
				OnThang2Changed();
			}
        }
		partial void OnThang2Changing();
		partial void OnThang2Changed();
		
		public virtual decimal Thang3
        {
            get { return _Thang3; }
			set
			{
				OnThang3Changing();
				_Thang3 = value;
				OnThang3Changed();
			}
        }
		partial void OnThang3Changing();
		partial void OnThang3Changed();
		
		public virtual decimal Thang4
        {
            get { return _Thang4; }
			set
			{
				OnThang4Changing();
				_Thang4 = value;
				OnThang4Changed();
			}
        }
		partial void OnThang4Changing();
		partial void OnThang4Changed();
		
		public virtual decimal Thang5
        {
            get { return _Thang5; }
			set
			{
				OnThang5Changing();
				_Thang5 = value;
				OnThang5Changed();
			}
        }
		partial void OnThang5Changing();
		partial void OnThang5Changed();
		
		public virtual decimal Thang6
        {
            get { return _Thang6; }
			set
			{
				OnThang6Changing();
				_Thang6 = value;
				OnThang6Changed();
			}
        }
		partial void OnThang6Changing();
		partial void OnThang6Changed();
		
		public virtual decimal Thang7
        {
            get { return _Thang7; }
			set
			{
				OnThang7Changing();
				_Thang7 = value;
				OnThang7Changed();
			}
        }
		partial void OnThang7Changing();
		partial void OnThang7Changed();
		
		public virtual decimal Thang8
        {
            get { return _Thang8; }
			set
			{
				OnThang8Changing();
				_Thang8 = value;
				OnThang8Changed();
			}
        }
		partial void OnThang8Changing();
		partial void OnThang8Changed();
		
		public virtual decimal Thang9
        {
            get { return _Thang9; }
			set
			{
				OnThang9Changing();
				_Thang9 = value;
				OnThang9Changed();
			}
        }
		partial void OnThang9Changing();
		partial void OnThang9Changed();
		
		public virtual decimal Thang10
        {
            get { return _Thang10; }
			set
			{
				OnThang10Changing();
				_Thang10 = value;
				OnThang10Changed();
			}
        }
		partial void OnThang10Changing();
		partial void OnThang10Changed();
		
		public virtual decimal Thang11
        {
            get { return _Thang11; }
			set
			{
				OnThang11Changing();
				_Thang11 = value;
				OnThang11Changed();
			}
        }
		partial void OnThang11Changing();
		partial void OnThang11Changed();
		
		public virtual decimal Thang12
        {
            get { return _Thang12; }
			set
			{
				OnThang12Changing();
				_Thang12 = value;
				OnThang12Changed();
			}
        }
		partial void OnThang12Changing();
		partial void OnThang12Changed();
		
		public virtual decimal Nam
        {
            get { return _Nam; }
			set
			{
				OnNamChanging();
				_Nam = value;
				OnNamChanged();
			}
        }
		partial void OnNamChanging();
		partial void OnNamChanged();
		
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
