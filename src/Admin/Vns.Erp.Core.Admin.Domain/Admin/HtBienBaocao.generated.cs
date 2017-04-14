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
	public partial class HtBienBaocao : DomainObject<Guid>, INotifyPropertyChanged
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
		private decimal _id_ht_bien_baocao; 
		private Guid _id_ht_baocao; 
		private string _ma_ht_baocao; 
		private string _ten_bien; 
		private string _kieu_bien; 
		private string _ten_parameter; 
		private string _gia_tri_bien; 
		private decimal _thu_tu; 
		private decimal _co_gia_tri; 
		private string _mo_ta; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public HtBienBaocao()
		{
				_id_ht_bien_baocao = 0; 
				_id_ht_baocao = new Guid(); 
				_ma_ht_baocao =  String.Empty; 
				_ten_bien =  String.Empty; 
				_kieu_bien =  String.Empty; 
				_ten_parameter =  String.Empty; 
				_gia_tri_bien =  String.Empty; 
				_thu_tu = 0; 
				_co_gia_tri = 0; 
				_mo_ta =  String.Empty; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid IdHtBaocao
		{
			get { return _id_ht_baocao; }
			set { _isChanged |= (_id_ht_baocao != value); _id_ht_baocao = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaHtBaocao
		{
			get { return _ma_ht_baocao; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for MaHtBaocao", value, value.ToString());
				
				_isChanged |= (_ma_ht_baocao != value); _ma_ht_baocao = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenBien
		{
			get { return _ten_bien; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for TenBien", value, value.ToString());
				
				_isChanged |= (_ten_bien != value); _ten_bien = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string KieuBien
		{
			get { return _kieu_bien; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for KieuBien", value, value.ToString());
				
				_isChanged |= (_kieu_bien != value); _kieu_bien = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenParameter
		{
			get { return _ten_parameter; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for TenParameter", value, value.ToString());
				
				_isChanged |= (_ten_parameter != value); _ten_parameter = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string GiaTriBien
		{
			get { return _gia_tri_bien; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for GiaTriBien", value, value.ToString());
				
				_isChanged |= (_gia_tri_bien != value); _gia_tri_bien = value;
			}
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
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal CoGiaTri
		{
			get { return _co_gia_tri; }
			set { _isChanged |= (_co_gia_tri != value); _co_gia_tri = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MoTa
		{
			get { return _mo_ta; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for MoTa", value, value.ToString());
				
				_isChanged |= (_mo_ta != value); _mo_ta = value;
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
			HtBienBaocao castObj = (HtBienBaocao)obj; 
			return ( castObj != null ) &&
                (this.Id == castObj.Id);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_ht_bien_baocao.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}