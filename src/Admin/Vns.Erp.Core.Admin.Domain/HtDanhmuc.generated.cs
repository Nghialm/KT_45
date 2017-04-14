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
	public partial class HtDanhmuc : DomainObject<decimal>, INotifyPropertyChanged
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
		private decimal _danhmuc_id; 
		private string _ten_danhmuc; 
		private string _ten_danhmuc_ta; 
		private string _doituong; 
		private string _ten_viet_tat; 
		private string _mo_ta; 
		private int _cho_phep_sua; 
		private int _co_su_dung; 
		private int _loai; 
		private int _gia_tri; 
		private int _thu_tu; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public HtDanhmuc()
		{
				_danhmuc_id = 0; 
				_ten_danhmuc =  String.Empty; 
				_ten_danhmuc_ta =  String.Empty; 
				_doituong =  String.Empty; 
				_ten_viet_tat =  String.Empty; 
				_mo_ta =  String.Empty; 
				_cho_phep_sua = 0; 
				_co_su_dung = 0; 
				_loai = 0; 
				_gia_tri = 0; 
				_thu_tu = 0; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal DanhmucId
		{
			get { return _danhmuc_id; }
			set { _isChanged |= (_danhmuc_id != value); _danhmuc_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenDanhmuc
		{
			get { return _ten_danhmuc; }
			set	
			{
				if ( value != null)
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for TenDanhmuc", value, value.ToString());
				
				_isChanged |= (_ten_danhmuc != value); _ten_danhmuc = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenDanhmucTa
		{
			get { return _ten_danhmuc_ta; }
			set	
			{
				if ( value != null)
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for TenDanhmucTa", value, value.ToString());
				
				_isChanged |= (_ten_danhmuc_ta != value); _ten_danhmuc_ta = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string Doituong
		{
			get { return _doituong; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for Doituong", value, value.ToString());
				
				_isChanged |= (_doituong != value); _doituong = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenVietTat
		{
			get { return _ten_viet_tat; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for TenVietTat", value, value.ToString());
				
				_isChanged |= (_ten_viet_tat != value); _ten_viet_tat = value;
			}
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
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for MoTa", value, value.ToString());
				
				_isChanged |= (_mo_ta != value); _mo_ta = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  int ChoPhepSua
		{
			get { return _cho_phep_sua; }
			set { _isChanged |= (_cho_phep_sua != value); _cho_phep_sua = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  int CoSuDung
		{
			get { return _co_su_dung; }
			set { _isChanged |= (_co_su_dung != value); _co_su_dung = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  int Loai
		{
			get { return _loai; }
			set { _isChanged |= (_loai != value); _loai = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  int GiaTri
		{
			get { return _gia_tri; }
			set { _isChanged |= (_gia_tri != value); _gia_tri = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  int ThuTu
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
			HtDanhmuc castObj = (HtDanhmuc)obj; 
			return ( castObj != null ) &&
				( this.id == castObj.Id);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}