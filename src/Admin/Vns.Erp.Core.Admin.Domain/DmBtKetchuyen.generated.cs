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
	public partial class DmBtKetchuyen : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _dm_bt_ketchuyen_id; 
		private decimal _thang; 
		private decimal _nam; 
		private string _ten_bt_ketchuyen; 
		private Guid _id_tk_no; 
		private string _ma_tk_no; 
		private string _ten_tk_no; 
		private Guid _id_tk_co; 
		private string _ma_tk_co; 
		private string _ten_tk_co; 
		private decimal _loai_ketchuyen; 
		private decimal _kc_kh; 
		private decimal _kc_vuviec; 
		private decimal _kc_phi; 
		private decimal _kc_congtrinh; 
		private decimal _kc_hopdong; 
		private decimal _kc_bpht; 
		private decimal _kc_tudo_1; 
		private decimal _thu_tu; 
		private Guid _donvi_id; 
		private Guid _nguoi_tao; 
		private DateTime _ngay_tao;
        private Guid _nguoi_sua; 
		private DateTime _ngay_sua; 
		private decimal _kc_tudo_2; 
		private decimal _kc_tudo_3; 
		private decimal _kc_tudo_4; 
		private decimal _kc_tudo_5; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DmBtKetchuyen()
		{
				_dm_bt_ketchuyen_id =  new Guid(); 
				_thang = 0; 
				_nam = 0; 
				_ten_bt_ketchuyen =  String.Empty; 
				_id_tk_no =  new Guid(); 
				_ma_tk_no =  String.Empty; 
				_ten_tk_no =  String.Empty; 
				_id_tk_co =  new Guid(); 
				_ma_tk_co =  String.Empty; 
				_ten_tk_co =  String.Empty; 
				_loai_ketchuyen = 0; 
				_kc_kh = 0; 
				_kc_vuviec = 0; 
				_kc_phi = 0; 
				_kc_congtrinh = 0; 
				_kc_hopdong = 0; 
				_kc_bpht = 0; 
				_kc_tudo_1 = 0; 
				_thu_tu = 0; 
				_donvi_id =  new Guid(); 
				_nguoi_tao = new Guid(); 
				_ngay_tao = DateTime.MaxValue; 
				_nguoi_sua = new Guid(); 
				_ngay_sua = DateTime.MaxValue; 
				_kc_tudo_2 = 0; 
				_kc_tudo_3 = 0; 
				_kc_tudo_4 = 0; 
				_kc_tudo_5 = 0; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid DmBtKetchuyenId
		{
			get { return _dm_bt_ketchuyen_id; }
			set { _isChanged |= (_dm_bt_ketchuyen_id != value); _dm_bt_ketchuyen_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal Thang
		{
			get { return _thang; }
			set { _isChanged |= (_thang != value); _thang = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal Nam
		{
			get { return _nam; }
			set { _isChanged |= (_nam != value); _nam = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenBtKetchuyen
		{
			get { return _ten_bt_ketchuyen; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for TenBtKetchuyen", value, value.ToString());
				
				_isChanged |= (_ten_bt_ketchuyen != value); _ten_bt_ketchuyen = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid IdTkNo
		{
			get { return _id_tk_no; }
			set { _isChanged |= (_id_tk_no != value); _id_tk_no = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaTkNo
		{
			get { return _ma_tk_no; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaTkNo", value, value.ToString());
				
				_isChanged |= (_ma_tk_no != value); _ma_tk_no = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenTkNo
		{
			get { return _ten_tk_no; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for TenTkNo", value, value.ToString());
				
				_isChanged |= (_ten_tk_no != value); _ten_tk_no = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid IdTkCo
		{
			get { return _id_tk_co; }
			set { _isChanged |= (_id_tk_co != value); _id_tk_co = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaTkCo
		{
			get { return _ma_tk_co; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaTkCo", value, value.ToString());
				
				_isChanged |= (_ma_tk_co != value); _ma_tk_co = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenTkCo
		{
			get { return _ten_tk_co; }
			set	
			{
				if ( value != null)
					if( value.Length > 64)
						throw new ArgumentOutOfRangeException("Invalid value for TenTkCo", value, value.ToString());
				
				_isChanged |= (_ten_tk_co != value); _ten_tk_co = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal LoaiKetchuyen
		{
			get { return _loai_ketchuyen; }
			set { _isChanged |= (_loai_ketchuyen != value); _loai_ketchuyen = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcKh
		{
			get { return _kc_kh; }
			set { _isChanged |= (_kc_kh != value); _kc_kh = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcVuviec
		{
			get { return _kc_vuviec; }
			set { _isChanged |= (_kc_vuviec != value); _kc_vuviec = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcPhi
		{
			get { return _kc_phi; }
			set { _isChanged |= (_kc_phi != value); _kc_phi = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcCongtrinh
		{
			get { return _kc_congtrinh; }
			set { _isChanged |= (_kc_congtrinh != value); _kc_congtrinh = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcHopdong
		{
			get { return _kc_hopdong; }
			set { _isChanged |= (_kc_hopdong != value); _kc_hopdong = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcBpht
		{
			get { return _kc_bpht; }
			set { _isChanged |= (_kc_bpht != value); _kc_bpht = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcTudo1
		{
			get { return _kc_tudo_1; }
			set { _isChanged |= (_kc_tudo_1 != value); _kc_tudo_1 = value; }
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
		public  Guid DonviId
		{
			get { return _donvi_id; }
			set { _isChanged |= (_donvi_id != value); _donvi_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid  NguoiTao
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
		public  Guid NguoiSua
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
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcTudo2
		{
			get { return _kc_tudo_2; }
			set { _isChanged |= (_kc_tudo_2 != value); _kc_tudo_2 = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcTudo3
		{
			get { return _kc_tudo_3; }
			set { _isChanged |= (_kc_tudo_3 != value); _kc_tudo_3 = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcTudo4
		{
			get { return _kc_tudo_4; }
			set { _isChanged |= (_kc_tudo_4 != value); _kc_tudo_4 = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal KcTudo5
		{
			get { return _kc_tudo_5; }
			set { _isChanged |= (_kc_tudo_5 != value); _kc_tudo_5 = value; }
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
			DmBtKetchuyen castObj = (DmBtKetchuyen)obj; 
			return ( castObj != null ) &&
				( this._dm_bt_ketchuyen_id == castObj.DmBtKetchuyenId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _dm_bt_ketchuyen_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}