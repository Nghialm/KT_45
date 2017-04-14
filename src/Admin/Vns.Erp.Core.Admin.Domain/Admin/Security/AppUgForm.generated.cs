using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Admin.Domain
{

    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Admin", IsReference = true)]
    public partial class AppUgForm : DomainObject<decimal>, INotifyPropertyChanged
    {
        #region Declarations

		
		private decimal _groupId = default(Decimal);
		private Guid _formId = default(Guid);
		private decimal _formOrder = default(Decimal);
		
		
		
        #endregion

        #region Constructors

        public AppUgForm() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_groupId);
			sb.Append(_formId);
			sb.Append(_formOrder);

            return sb.ToString().GetHashCode();
        }
		
		public AppUgForm Clone()
        {
            return (AppUgForm)this.MemberwiseClone();
        }
		
		public void SetProperty(AppUgForm des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_groupId = des.GroupId;
			_formId = des.FormId;
			_formOrder = des.FormOrder;
		}

        #endregion

        #region Properties

		public virtual decimal GroupId
        {
            get { return _groupId; }
			set
			{
				OnGroupIdChanging();
				_groupId = value;
				OnGroupIdChanged();
			}
        }
		partial void OnGroupIdChanging();
		partial void OnGroupIdChanged();
		
		public virtual Guid FormId
        {
            get { return _formId; }
			set
			{
				OnFormIdChanging();
				_formId = value;
				OnFormIdChanged();
			}
        }
		partial void OnFormIdChanging();
		partial void OnFormIdChanged();
		
		public virtual decimal FormOrder
        {
            get { return _formOrder; }
			set
			{
				OnFormOrderChanging();
				_formOrder = value;
				OnFormOrderChanged();
			}
        }
		partial void OnFormOrderChanging();
		partial void OnFormOrderChanged();
		
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
