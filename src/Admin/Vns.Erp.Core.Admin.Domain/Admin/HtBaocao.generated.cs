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
	public partial class HtBaocao : DomainObject<Guid>, INotifyPropertyChanged
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
		private string _ma_baocao; 
		private string _ten_baocao; 
		private string _ten_bang_dulieu; 
		private string _ten_procedure; 
		private decimal _id; 
		private Guid _id_cha; 
		private decimal _chi_tiet; 
		private string _cot_hienthi; 
		private string _ten_hienthi; 
		private decimal _loai_baocao; 
		private string _ghi_chu; 
		private string _ghi_chu_2; 
		private string _ghi_chu_3; 
		private decimal _thu_tu; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public HtBaocao()
		{
				_ma_baocao =  String.Empty; 
				_ten_baocao =  String.Empty; 
				_ten_bang_dulieu =  String.Empty; 
				_ten_procedure =  String.Empty; 
				_id_cha = new Guid(); 
				_chi_tiet = 0; 
				_cot_hienthi =  String.Empty; 
				_ten_hienthi =  String.Empty; 
				_loai_baocao = 0; 
				_ghi_chu =  String.Empty; 
				_ghi_chu_2 =  String.Empty; 
				_ghi_chu_3 =  String.Empty; 
				_thu_tu = 0; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string MaBaocao
		{
			get { return _ma_baocao; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for MaBaocao", value, value.ToString());
				
				_isChanged |= (_ma_baocao != value); _ma_baocao = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenBaocao
		{
			get { return _ten_baocao; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for TenBaocao", value, value.ToString());
				
				_isChanged |= (_ten_baocao != value); _ten_baocao = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenBangDulieu
		{
			get { return _ten_bang_dulieu; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for TenBangDulieu", value, value.ToString());
				
				_isChanged |= (_ten_bang_dulieu != value); _ten_bang_dulieu = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenProcedure
		{
			get { return _ten_procedure; }
			set	
			{
				if ( value != null)
					if( value.Length > 256)
						throw new ArgumentOutOfRangeException("Invalid value for TenProcedure", value, value.ToString());
				
				_isChanged |= (_ten_procedure != value); _ten_procedure = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  Guid IdCha
		{
			get { return _id_cha; }
			set { _isChanged |= (_id_cha != value); _id_cha = value; }
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
		public  string CotHienthi
		{
			get { return _cot_hienthi; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for CotHienthi", value, value.ToString());
				
				_isChanged |= (_cot_hienthi != value); _cot_hienthi = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string TenHienthi
		{
			get { return _ten_hienthi; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for TenHienthi", value, value.ToString());
				
				_isChanged |= (_ten_hienthi != value); _ten_hienthi = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  decimal LoaiBaocao
		{
			get { return _loai_baocao; }
			set { _isChanged |= (_loai_baocao != value); _loai_baocao = value; }
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string GhiChu
		{
			get { return _ghi_chu; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for GhiChu", value, value.ToString());
				
				_isChanged |= (_ghi_chu != value); _ghi_chu = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string GhiChu2
		{
			get { return _ghi_chu_2; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for GhiChu2", value, value.ToString());
				
				_isChanged |= (_ghi_chu_2 != value); _ghi_chu_2 = value;
			}
			}
			
			
		/// <summary>
		/// 
		/// </summary>		
		
		[DataMember]
		public  string GhiChu3
		{
			get { return _ghi_chu_3; }
			set	
			{
				if ( value != null)
					if( value.Length > 512)
						throw new ArgumentOutOfRangeException("Invalid value for GhiChu3", value, value.ToString());
				
				_isChanged |= (_ghi_chu_3 != value); _ghi_chu_3 = value;
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
			HtBaocao castObj = (HtBaocao)obj; 
			return ( castObj != null ) &&
				( this.Id == castObj.Id);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
