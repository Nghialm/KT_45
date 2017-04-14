using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class KtHBaocao : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Title = String.Empty;
		private decimal _SoDong = 0;
		private decimal _SoCot = 0;
		private string _MaBaocao = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public KtHBaocao() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Title);
			sb.Append(_SoDong);
			sb.Append(_SoCot);
			sb.Append(_MaBaocao);

            return sb.ToString().GetHashCode();
        }
		
		public KtHBaocao Clone()
        {
            return (KtHBaocao)this.MemberwiseClone();
        }
		
		public void SetProperty(KtHBaocao des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Title = des.Title;
			_SoDong = des.SoDong;
			_SoCot = des.SoCot;
			_MaBaocao = des.MaBaocao;
		}

        #endregion

        #region Properties

		public virtual string Title
        {
            get { return _Title; }
			set
			{
				OnTitleChanging();
				_Title = value;
				OnTitleChanged();
			}
        }
		partial void OnTitleChanging();
		partial void OnTitleChanged();
		
		public virtual decimal SoDong
        {
            get { return _SoDong; }
			set
			{
				OnSoDongChanging();
				_SoDong = value;
				OnSoDongChanged();
			}
        }
		partial void OnSoDongChanging();
		partial void OnSoDongChanged();
		
		public virtual decimal SoCot
        {
            get { return _SoCot; }
			set
			{
				OnSoCotChanging();
				_SoCot = value;
				OnSoCotChanged();
			}
        }
		partial void OnSoCotChanging();
		partial void OnSoCotChanged();
		
		public virtual string MaBaocao
        {
            get { return _MaBaocao; }
			set
			{
				OnMaBaocaoChanging();
				_MaBaocao = value;
				OnMaBaocaoChanged();
			}
        }
		partial void OnMaBaocaoChanging();
		partial void OnMaBaocaoChanged();
		
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
