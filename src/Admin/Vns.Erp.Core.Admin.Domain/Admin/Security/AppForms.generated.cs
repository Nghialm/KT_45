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
	public partial class AppForms : DomainObject<Guid>, INotifyPropertyChanged
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
		private decimal _formid; 
		private string _formname; 
		private string _formtext; 
		private string _parentname; 
		private string _menuname; 
		private string _menutext; 
		private string _formparam; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public AppForms()
		{
				_formid = 0; 
				_formname =  String.Empty; 
				_formtext =  String.Empty; 
				_parentname =  String.Empty; 
				_menuname =  String.Empty; 
				_menutext =  String.Empty; 
				_formparam =  String.Empty; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal FormId
		{
			get { return _formid; }
			set { _isChanged |= (_formid != value); _formid = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string FormName
		{
			get { return _formname; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for FormName", value, value.ToString());
				
				_isChanged |= (_formname != value); _formname = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string FormText
		{
			get { return _formtext; }
			set	
			{
				if ( value != null)
					if( value.Length > 250)
						throw new ArgumentOutOfRangeException("Invalid value for FormText", value, value.ToString());
				
				_isChanged |= (_formtext != value); _formtext = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string ParentName
		{
			get { return _parentname; }
			set	
			{
				if ( value != null)
					if( value.Length > 50)
						throw new ArgumentOutOfRangeException("Invalid value for ParentName", value, value.ToString());
				
				_isChanged |= (_parentname != value); _parentname = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MenuName
		{
			get { return _menuname; }
			set	
			{
				if ( value != null)
					if( value.Length > 50)
						throw new ArgumentOutOfRangeException("Invalid value for MenuName", value, value.ToString());
				
				_isChanged |= (_menuname != value); _menuname = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MenuText
		{
			get { return _menutext; }
			set	
			{
				if ( value != null)
					if( value.Length > 250)
						throw new ArgumentOutOfRangeException("Invalid value for MenuText", value, value.ToString());
				
				_isChanged |= (_menutext != value); _menutext = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string FormParam
		{
			get { return _formparam; }
			set	
			{
				if ( value != null)
					if( value.Length > 500)
						throw new ArgumentOutOfRangeException("Invalid value for FormParam", value, value.ToString());
				
				_isChanged |= (_formparam != value); _formparam = value;
			}
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
			AppForms castObj = (AppForms)obj; 
			return ( castObj != null ) &&
				( this._formid == castObj.FormId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _formid.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
