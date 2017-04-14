using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class KtStatusCt : DomainObject<decimal>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ten = String.Empty;
		private string _MoTa = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public KtStatusCt() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ten);
			sb.Append(_MoTa);

            return sb.ToString().GetHashCode();
        }
		
		public KtStatusCt Clone()
        {
            return (KtStatusCt)this.MemberwiseClone();
        }
		
		public void SetProperty(KtStatusCt des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ten = des.Ten;
			_MoTa = des.MoTa;
		}

        #endregion

        #region Properties

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
