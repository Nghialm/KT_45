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
	public partial class DmPtqt : DomainObject<Guid>, INotifyPropertyChanged
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
		private Guid _ptqt_id; 
		private string _ma_ptqt; 
		private string _ky_hieu; 
		private string _ten_ptqt; 
		private string _mo_ta; 
		private Guid _ptqt_id_cha; 
		private decimal _chi_tiet; 
		private Guid _donvi_id; 
		private string _ma_donvi; 
		private string _ma_tk; 
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
		public DmPtqt()
		{
				_ptqt_id =  new Guid(); 
				_ma_ptqt =  String.Empty; 
				_ky_hieu =  String.Empty; 
				_ten_ptqt =  String.Empty; 
				_mo_ta =  String.Empty; 
				_ptqt_id_cha =  new Guid(); 
				_chi_tiet = 0; 
				_donvi_id =  new Guid(); 
				_ma_donvi =  String.Empty; 
				_ma_tk =  String.Empty; 
				_cho_phep_sua = 0; 
				_co_su_dung = 0; 
				_cap = 0; 
				_nguoi_tao = new Guid(); 
				_ngay_tao = DateTime.MaxValue; 
				_nguoi_sua = new Guid(); 
				_ngay_sua = DateTime.MaxValue; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid PtqtId
		{
			get { return _ptqt_id; }
			set { _isChanged |= (_ptqt_id != value); _ptqt_id = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaPtqt
		{
			get { return _ma_ptqt; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaPtqt", value, value.ToString());
				
				_isChanged |= (_ma_ptqt != value); _ma_ptqt = value;
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
		public  string TenPtqt
		{
			get { return _ten_ptqt; }
			set	
			{
				if ( value != null)
					if( value.Length > 128)
						throw new ArgumentOutOfRangeException("Invalid value for TenPtqt", value, value.ToString());
				
				_isChanged |= (_ten_ptqt != value); _ten_ptqt = value;
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
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for MoTa", value, value.ToString());
				
				_isChanged |= (_mo_ta != value); _mo_ta = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid PtqtIdCha
		{
			get { return _ptqt_id_cha; }
			set { _isChanged |= (_ptqt_id_cha != value); _ptqt_id_cha = value; }
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
		public  string MaTk
		{
			get { return _ma_tk; }
			set	
			{
				if ( value != null)
					if( value.Length > 32)
						throw new ArgumentOutOfRangeException("Invalid value for MaTk", value, value.ToString());
				
				_isChanged |= (_ma_tk != value); _ma_tk = value;
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
			DmPtqt castObj = (DmPtqt)obj; 
			return ( castObj != null ) &&
				( this._ptqt_id == castObj.PtqtId);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _ptqt_id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
