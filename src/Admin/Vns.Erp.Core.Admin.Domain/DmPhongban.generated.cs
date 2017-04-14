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
	public partial class DmPhongban : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _phongban_id; 
		private string _ma_phongban; 
		private string _ky_hieu; 
		private string _ten_phongban; 
		private Guid _phongban_id_cha; 
		private decimal _chi_tiet; 
		private string _dia_chi; 
		private Guid _donvi_id; 
		private string _ma_donvi; 
		private decimal _cho_phep_sua; 
		private decimal _co_su_dung; 
		private decimal _cap; 
		private Guid _nguoi_tao; 
		private DateTime _ngay_tao; 
		private Guid _nguoi_sua; 
		private DateTime _ngay_sua; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DmPhongban()
		{
				_phongban_id =  new Guid(); 
				_ma_phongban =  String.Empty; 
				_ky_hieu =  String.Empty; 
				_ten_phongban =  String.Empty; 
				_phongban_id_cha =  new Guid(); 
				_chi_tiet = 0; 
				_dia_chi =  String.Empty; 
				_donvi_id =  new Guid(); 
				_ma_donvi =  String.Empty; 
				_cho_phep_sua = 0; 
				_co_su_dung = 0; 
				_cap = 0; 
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
		public  Guid PhongbanId
		{
			get { return _phongban_id; }
			set { _isChanged |= (_phongban_id != value); _phongban_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaPhongban
		{
			get { return _ma_phongban; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaPhongban", value, value.ToString());
				
				_isChanged |= (_ma_phongban != value); _ma_phongban = value;
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
		public  string TenPhongban
		{
			get { return _ten_phongban; }
			set	
			{
				if ( value != null)
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for TenPhongban", value, value.ToString());
				
				_isChanged |= (_ten_phongban != value); _ten_phongban = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid PhongbanIdCha
		{
			get { return _phongban_id_cha; }
			set { _isChanged |= (_phongban_id_cha != value); _phongban_id_cha = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal ChiTiet
		{
			get { return _chi_tiet; }
			set { _isChanged |= (_chi_tiet != value); _chi_tiet = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string DiaChi
		{
			get { return _dia_chi; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for DiaChi", value, value.ToString());
				
				_isChanged |= (_dia_chi != value); _dia_chi = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid DonviId
		{
			get { return _donvi_id; }
			set { _isChanged |= (_donvi_id != value); _donvi_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaDonvi
		{
			get { return _ma_donvi; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaDonvi", value, value.ToString());
				
				_isChanged |= (_ma_donvi != value); _ma_donvi = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal ChoPhepSua
		{
			get { return _cho_phep_sua; }
			set { _isChanged |= (_cho_phep_sua != value); _cho_phep_sua = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal CoSuDung
		{
			get { return _co_su_dung; }
			set { _isChanged |= (_co_su_dung != value); _co_su_dung = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal Cap
		{
			get { return _cap; }
			set { _isChanged |= (_cap != value); _cap = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid NguoiTao
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
			DmPhongban castObj = (DmPhongban)obj; 
			return ( castObj != null ) &&
				( this._phongban_id == castObj.PhongbanId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _phongban_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
