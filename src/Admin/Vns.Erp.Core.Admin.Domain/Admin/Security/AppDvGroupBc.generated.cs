/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
namespace Vns.Erp.Core.Admin.Domain
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo And Modified By Hoang Quoc Dung
	/// </summary>

	
	[Serializable]
	[DataContract(Namespace ="http://Vns.Erp.Core.Admin",IsReference=true)]
	public partial class AppDvGroupBc : DomainObject<Guid>, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }		
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private Guid _dgb_id; 
		private Guid _dv_id; 
		private Guid _group_id; 
		private Guid _bc_id; 
		private decimal _bc_order; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public AppDvGroupBc()
		{
				_dgb_id =  new Guid(); 
				_dv_id =  new Guid(); 
				_group_id = new Guid(); 
				_bc_id = new Guid(); 
				_bc_order = 0; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid DgbId
		{
			get { return _dgb_id; }
			set { _isChanged |= (_dgb_id != value); _dgb_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid DvId
		{
			get { return _dv_id; }
			set { _isChanged |= (_dv_id != value); _dv_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid GroupId
		{
			get { return _group_id; }
			set { _isChanged |= (_group_id != value); _group_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid BcId
		{
			get { return _bc_id; }
			set { _isChanged |= (_bc_id != value); _bc_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal BcOrder
		{
			get { return _bc_order; }
			set { _isChanged |= (_bc_order != value); _bc_order = value; }
			}
			
			
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public bool IsChanged
		{
			get { return _isChanged; }
		}
		
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public bool IsDeleted
		{
			get { return _isDeleted; }
		}
		
		#endregion 
		
		
		#region Public Functions
		
		/// <summary>
		/// mark the item as deleted
		/// </summary>
		public void MarkAsDeleted()
		{
			_isDeleted = true;
			_isChanged = true;
		}
		
		
		#endregion
		
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			AppDvGroupBc castObj = (AppDvGroupBc)obj; 
			return ( castObj != null ) &&
				( this._dgb_id == castObj.DgbId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _dgb_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
