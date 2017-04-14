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
	public partial class DmNgoaite : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _nte_id; 
		private string _ma_nte; 
		private string _ky_hieu; 
		private string _ten_nte; 
		private decimal _ty_gia; 
		private Guid _nguoi_tao; 
		private DateTime _ngay_tao;
        private Guid _nguoi_sua; 
		private DateTime _ngay_sua; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DmNgoaite()
		{
				_nte_id =  new Guid(); 
				_ma_nte =  String.Empty; 
				_ky_hieu =  String.Empty; 
				_ten_nte =  String.Empty; 
				_ty_gia = 0; 
				_nguoi_tao = Guid.Empty; 
				_ngay_tao = DateTime.MaxValue; 
				_nguoi_sua = Guid.Empty; 
				_ngay_sua = DateTime.MaxValue; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid NteId
		{
			get { return _nte_id; }
			set { _isChanged |= (_nte_id != value); _nte_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaNte
		{
			get { return _ma_nte; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaNte", value, value.ToString());
				
				_isChanged |= (_ma_nte != value); _ma_nte = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string KyHieu
		{
			get { return _ky_hieu; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for KyHieu", value, value.ToString());
				
				_isChanged |= (_ky_hieu != value); _ky_hieu = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenNte
		{
			get { return _ten_nte; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for TenNte", value, value.ToString());
				
				_isChanged |= (_ten_nte != value); _ten_nte = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal TyGia
		{
			get { return _ty_gia; }
			set { _isChanged |= (_ty_gia != value); _ty_gia = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
        public Guid NguoiTao
		{
			get { return _nguoi_tao; }
			set { _isChanged |= (_nguoi_tao != value); _nguoi_tao = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  DateTime NgayTao
		{
			get { return _ngay_tao; }
			set { _isChanged |= (_ngay_tao != value); _ngay_tao = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
        public Guid NguoiSua
		{
			get { return _nguoi_sua; }
			set { _isChanged |= (_nguoi_sua != value); _nguoi_sua = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  DateTime NgaySua
		{
			get { return _ngay_sua; }
			set { _isChanged |= (_ngay_sua != value); _ngay_sua = value; }
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
			DmNgoaite castObj = (DmNgoaite)obj; 
			return ( castObj != null ) &&
				( this._nte_id == castObj.NteId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _nte_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}