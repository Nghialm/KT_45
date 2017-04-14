using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class TsDieuchuyen : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _TscdId = new Guid();
		private string _MaTscd = "";
        private string _KyHieuTscd = "";
        private string _TenTscd = "";
		private System.Guid _BoPhanDcId = new Guid();       
		private System.DateTime? _NgayDc = null;
        private string _LyDoDc = "";
		private decimal _ThuTu = 0;
		private System.DateTime? _NgayTao = null;
        private Guid _NguoiTao = Guid.Empty;
		private System.DateTime? _NgaySua = null;
        private Guid _NguoiSua = Guid.Empty;
		
		
		
        #endregion

        #region Constructors

        public TsDieuchuyen() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_TscdId);
			sb.Append(_MaTscd);
			sb.Append(_KyHieuTscd);
			sb.Append(_TenTscd);
			sb.Append(_BoPhanDcId);
			sb.Append(_NgayDc);
			sb.Append(_LyDoDc);
			sb.Append(_ThuTu);
			sb.Append(_NgayTao);
			sb.Append(_NguoiTao);
			sb.Append(_NgaySua);
			sb.Append(_NguoiSua);

            return sb.ToString().GetHashCode();
        }
		
		public TsDieuchuyen Clone()
        {
            return (TsDieuchuyen)this.MemberwiseClone();
        }
		
		public void SetProperty(TsDieuchuyen des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_TscdId = des.TscdId;
			_MaTscd = des.MaTscd;
			_KyHieuTscd = des.KyHieuTscd;
			_TenTscd = des.TenTscd;
			_BoPhanDcId = des.BoPhanDcId;
			_NgayDc = des.NgayDc;
			_LyDoDc = des.LyDoDc;
			_ThuTu = des.ThuTu;
			_NgayTao = des.NgayTao;
			_NguoiTao = des.NguoiTao;
			_NgaySua = des.NgaySua;
			_NguoiSua = des.NguoiSua;
		}

        #endregion

        #region Properties

		public virtual System.Guid TscdId
        {
            get { return _TscdId; }
			set
			{
				OnTscdIdChanging();
				_TscdId = value;
				OnTscdIdChanged();
			}
        }
		partial void OnTscdIdChanging();
		partial void OnTscdIdChanged();
		
		public virtual string MaTscd
        {
            get { return _MaTscd; }
			set
			{
				OnMaTscdChanging();
				_MaTscd = value;
				OnMaTscdChanged();
			}
        }
		partial void OnMaTscdChanging();
		partial void OnMaTscdChanged();
		
		public virtual string KyHieuTscd
        {
            get { return _KyHieuTscd; }
			set
			{
				OnKyHieuTscdChanging();
				_KyHieuTscd = value;
				OnKyHieuTscdChanged();
			}
        }
		partial void OnKyHieuTscdChanging();
		partial void OnKyHieuTscdChanged();
		
		public virtual string TenTscd
        {
            get { return _TenTscd; }
			set
			{
				OnTenTscdChanging();
				_TenTscd = value;
				OnTenTscdChanged();
			}
        }
		partial void OnTenTscdChanging();
		partial void OnTenTscdChanged();
		
		public virtual System.Guid BoPhanDcId
        {
            get { return _BoPhanDcId; }
			set
			{
				OnBoPhanDcIdChanging();
				_BoPhanDcId = value;
				OnBoPhanDcIdChanged();
			}
        }
		partial void OnBoPhanDcIdChanging();
		partial void OnBoPhanDcIdChanged();
		
		public virtual System.DateTime? NgayDc
        {
            get { return _NgayDc; }
			set
			{
				OnNgayDcChanging();
				_NgayDc = value;
				OnNgayDcChanged();
			}
        }
		partial void OnNgayDcChanging();
		partial void OnNgayDcChanged();
		
		public virtual string LyDoDc
        {
            get { return _LyDoDc; }
			set
			{
				OnLyDoDcChanging();
				_LyDoDc = value;
				OnLyDoDcChanged();
			}
        }
		partial void OnLyDoDcChanging();
		partial void OnLyDoDcChanged();
		
		public virtual decimal ThuTu
        {
            get { return _ThuTu; }
			set
			{
				OnThuTuChanging();
				_ThuTu = value;
				OnThuTuChanged();
			}
        }
		partial void OnThuTuChanging();
		partial void OnThuTuChanged();
		
		public virtual System.DateTime? NgayTao
        {
            get { return _NgayTao; }
			set
			{
				OnNgayTaoChanging();
				_NgayTao = value;
				OnNgayTaoChanged();
			}
        }
		partial void OnNgayTaoChanging();
		partial void OnNgayTaoChanged();

        public virtual Guid NguoiTao
        {
            get { return _NguoiTao; }
			set
			{
				OnNguoiTaoChanging();
				_NguoiTao = value;
				OnNguoiTaoChanged();
			}
        }
		partial void OnNguoiTaoChanging();
		partial void OnNguoiTaoChanged();
		
		public virtual System.DateTime? NgaySua
        {
            get { return _NgaySua; }
			set
			{
				OnNgaySuaChanging();
				_NgaySua = value;
				OnNgaySuaChanged();
			}
        }
		partial void OnNgaySuaChanging();
		partial void OnNgaySuaChanged();

        public virtual Guid NguoiSua
        {
            get { return _NguoiSua; }
			set
			{
				OnNguoiSuaChanging();
				_NguoiSua = value;
				OnNguoiSuaChanged();
			}
        }
		partial void OnNguoiSuaChanging();
		partial void OnNguoiSuaChanged();
		
        #endregion
		
		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
		#endregion
    }
}
