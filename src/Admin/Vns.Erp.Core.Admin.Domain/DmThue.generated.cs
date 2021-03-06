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
	public partial class DmThue : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _thue_id; 
		private string _ma_thue; 
		private string _ky_hieu; 
		private string _ten_thue; 
		private decimal _ty_le; 
		private Guid _thue_id_cha; 
		private decimal _xuat_khau; 
		private decimal _chi_tiet; 
		private decimal _cho_phep_sua; 
		private decimal _co_su_dung; 
		private decimal _cap;
        private Guid _nguoi_tao; 
		private DateTime _ngay_tao;
        private Guid _nguoi_sua; 
		private DateTime _ngay_sua;
        private decimal _mua_hang;
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DmThue()
		{
				_thue_id =  new Guid(); 
				_ma_thue =  String.Empty; 
				_ky_hieu =  String.Empty; 
				_ten_thue =  String.Empty; 
				_ty_le = 0; 
				_thue_id_cha =  new Guid(); 
				_xuat_khau = 0; 
				_chi_tiet = 0; 
				_cho_phep_sua = 0; 
				_co_su_dung = 0; 
				_cap = 0;
                _nguoi_tao = Guid.Empty; 
				_ngay_tao = DateTime.MaxValue; 
				_nguoi_sua = Guid.Empty; 
				_ngay_sua = DateTime.MaxValue;
                _mua_hang = 0;
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid ThueId
		{
			get { return _thue_id; }
			set { _isChanged |= (_thue_id != value); _thue_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaThue
		{
			get { return _ma_thue; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaThue", value, value.ToString());
				
				_isChanged |= (_ma_thue != value); _ma_thue = value;
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
		public  string TenThue
		{
			get { return _ten_thue; }
			set	
			{
				if ( value != null)
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for TenThue", value, value.ToString());
				
				_isChanged |= (_ten_thue != value); _ten_thue = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal TyLe
		{
			get { return _ty_le; }
			set { _isChanged |= (_ty_le != value); _ty_le = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid ThueIdCha
		{
			get { return _thue_id_cha; }
			set { _isChanged |= (_thue_id_cha != value); _thue_id_cha = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal XuatKhau
		{
			get { return _xuat_khau; }
			set { _isChanged |= (_xuat_khau != value); _xuat_khau = value; }
			}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal MuaHang
        {
            get { return _mua_hang; }
            set { _isChanged |= (_mua_hang != value); _mua_hang = value; }
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
			DmThue castObj = (DmThue)obj; 
			return ( castObj != null ) &&
				( this._thue_id == castObj.ThueId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _thue_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
