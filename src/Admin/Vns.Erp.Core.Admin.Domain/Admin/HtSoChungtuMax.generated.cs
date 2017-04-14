using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class HtSoChungtuMax : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _LoaichungtuId = new Guid();
		private decimal _SoChungtuMax = default(Decimal);
		private decimal _Thang = default(Decimal);
		private decimal _Nam = default(Decimal);
		private System.Guid _DonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public HtSoChungtuMax() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LoaichungtuId);
			sb.Append(_SoChungtuMax);
			sb.Append(_Thang);
			sb.Append(_Nam);
			sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public HtSoChungtuMax Clone()
        {
            return (HtSoChungtuMax)this.MemberwiseClone();
        }
		
		public void SetProperty(HtSoChungtuMax des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LoaichungtuId = des.LoaichungtuId;
			_SoChungtuMax = des.SoChungtuMax;
			_Thang = des.Thang;
			_Nam = des.Nam;
			_DonviId = des.DonviId;
		}

        #endregion

        #region Properties

		public virtual System.Guid LoaichungtuId
        {
            get { return _LoaichungtuId; }
			set
			{
				OnLoaichungtuIdChanging();
				_LoaichungtuId = value;
				OnLoaichungtuIdChanged();
			}
        }
		partial void OnLoaichungtuIdChanging();
		partial void OnLoaichungtuIdChanged();
		
		public virtual decimal SoChungtuMax
        {
            get { return _SoChungtuMax; }
			set
			{
				OnSoChungtuMaxChanging();
				_SoChungtuMax = value;
				OnSoChungtuMaxChanged();
			}
        }
		partial void OnSoChungtuMaxChanging();
		partial void OnSoChungtuMaxChanged();
		
		public virtual decimal Thang
        {
            get { return _Thang; }
			set
			{
				OnThangChanging();
				_Thang = value;
				OnThangChanged();
			}
        }
		partial void OnThangChanging();
		partial void OnThangChanged();
		
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
