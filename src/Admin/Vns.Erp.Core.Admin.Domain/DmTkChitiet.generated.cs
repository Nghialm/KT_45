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
	public partial class DmTkChitiet : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _tk_chitiet_id; 
		private Guid _taikhoan_id; 
		private string _dm_lienquan; 
		private decimal _bat_buoc; 
		private decimal _thu_tu; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DmTkChitiet()
		{
				_tk_chitiet_id =  new Guid(); 
				_taikhoan_id =  new Guid(); 
				_dm_lienquan =  String.Empty; 
				_bat_buoc = 0; 
				_thu_tu = 0; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid TkChitietId
		{
			get { return _tk_chitiet_id; }
			set { _isChanged |= (_tk_chitiet_id != value); _tk_chitiet_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid TaikhoanId
		{
			get { return _taikhoan_id; }
			set { _isChanged |= (_taikhoan_id != value); _taikhoan_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string DmLienquan
		{
			get { return _dm_lienquan; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for DmLienquan", value, value.ToString());
				
				_isChanged |= (_dm_lienquan != value); _dm_lienquan = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal BatBuoc
		{
			get { return _bat_buoc; }
			set { _isChanged |= (_bat_buoc != value); _bat_buoc = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal ThuTu
		{
			get { return _thu_tu; }
			set { _isChanged |= (_thu_tu != value); _thu_tu = value; }
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
			DmTkChitiet castObj = (DmTkChitiet)obj; 
			return ( castObj != null ) &&
				( this._tk_chitiet_id == castObj.TkChitietId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _tk_chitiet_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
