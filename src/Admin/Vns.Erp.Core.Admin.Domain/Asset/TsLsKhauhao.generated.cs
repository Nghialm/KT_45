using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class TsLsKhauhao : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _DmTscdId = new Guid();
		private System.Guid _CtTscdId = new Guid();
		private decimal _HaoMonLk = 0;
		private decimal _HaoMonThang = 0;
		private decimal _HaoMonNam = 0;
		private decimal _NguyenGia = 0;
		private decimal _GiaTriCl = 0;
		private decimal _Thang = 0;
		private decimal _Nam = 0;
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = "";
		private System.Guid _CtdId = new Guid();
		private System.DateTime? _NgayTao = null;
		private Guid _NguoiTao = Guid.Empty;
		private System.DateTime? _NgaySua = null;
		private Guid _NguoiSua = Guid.Empty;
		private System.Guid _CthId = new Guid();
		private System.Guid _IdCha = new Guid();
		private decimal _BaoCao = 0;
		private decimal _ChiTiet = 0;
		private decimal _HeSo = 0;
		private System.Guid _NguonVonId = new Guid();
        private System.DateTime? _NgayKhauHao = null;
		
		
        #endregion

        #region Constructors

        public TsLsKhauhao() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_DmTscdId);
			sb.Append(_CtTscdId);
			sb.Append(_HaoMonLk);
			sb.Append(_HaoMonThang);
			sb.Append(_HaoMonNam);
			sb.Append(_NguyenGia);
			sb.Append(_GiaTriCl);
			sb.Append(_Thang);
			sb.Append(_Nam);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);
			sb.Append(_CtdId);
			sb.Append(_NgayTao);
			sb.Append(_NguoiTao);
			sb.Append(_NgaySua);
			sb.Append(_NguoiSua);
			sb.Append(_CthId);
			sb.Append(_IdCha);
			sb.Append(_BaoCao);
			sb.Append(_ChiTiet);
			sb.Append(_HeSo);
			sb.Append(_NguonVonId);

            return sb.ToString().GetHashCode();
        }
		
		public TsLsKhauhao Clone()
        {
            return (TsLsKhauhao)this.MemberwiseClone();
        }
		
		public void SetProperty(TsLsKhauhao des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_DmTscdId = des.DmTscdId;
			_CtTscdId = des.CtTscdId;
			_HaoMonLk = des.HaoMonLk;
			_HaoMonThang = des.HaoMonThang;
			_HaoMonNam = des.HaoMonNam;
			_NguyenGia = des.NguyenGia;
			_GiaTriCl = des.GiaTriCl;
			_Thang = des.Thang;
			_Nam = des.Nam;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
			_CtdId = des.CtdId;
			_NgayTao = des.NgayTao;
			_NguoiTao = des.NguoiTao;
			_NgaySua = des.NgaySua;
			_NguoiSua = des.NguoiSua;
			_CthId = des.CthId;
			_IdCha = des.IdCha;
			_BaoCao = des.BaoCao;
			_ChiTiet = des.ChiTiet;
			_HeSo = des.HeSo;
			_NguonVonId = des.NguonVonId;
		}

        #endregion

        #region Properties

		public virtual System.Guid DmTscdId
        {
            get { return _DmTscdId; }
			set
			{
				OnDmTscdIdChanging();
				_DmTscdId = value;
				OnDmTscdIdChanged();
			}
        }
		partial void OnDmTscdIdChanging();
		partial void OnDmTscdIdChanged();
		
		public virtual System.Guid CtTscdId
        {
            get { return _CtTscdId; }
			set
			{
				OnCtTscdIdChanging();
				_CtTscdId = value;
				OnCtTscdIdChanged();
			}
        }
		partial void OnCtTscdIdChanging();
		partial void OnCtTscdIdChanged();
		
		public virtual decimal HaoMonLk
        {
            get { return _HaoMonLk; }
			set
			{
				OnHaoMonLkChanging();
				_HaoMonLk = value;
				OnHaoMonLkChanged();
			}
        }
		partial void OnHaoMonLkChanging();
		partial void OnHaoMonLkChanged();
		
		public virtual decimal HaoMonThang
        {
            get { return _HaoMonThang; }
			set
			{
				OnHaoMonThangChanging();
				_HaoMonThang = value;
				OnHaoMonThangChanged();
			}
        }
		partial void OnHaoMonThangChanging();
		partial void OnHaoMonThangChanged();
		
		public virtual decimal HaoMonNam
        {
            get { return _HaoMonNam; }
			set
			{
				OnHaoMonNamChanging();
				_HaoMonNam = value;
				OnHaoMonNamChanged();
			}
        }
		partial void OnHaoMonNamChanging();
		partial void OnHaoMonNamChanged();
		
		public virtual decimal NguyenGia
        {
            get { return _NguyenGia; }
			set
			{
				OnNguyenGiaChanging();
				_NguyenGia = value;
				OnNguyenGiaChanged();
			}
        }
		partial void OnNguyenGiaChanging();
		partial void OnNguyenGiaChanged();
		
		public virtual decimal GiaTriCl
        {
            get { return _GiaTriCl; }
			set
			{
				OnGiaTriClChanging();
				_GiaTriCl = value;
				OnGiaTriClChanged();
			}
        }
		partial void OnGiaTriClChanging();
		partial void OnGiaTriClChanged();
		
		public virtual decimal Thang
        {
            get { return _Thang; }
			set
			{
				OnThangChanging();
				_Thang = value;
				OnThangChanged();
			}
        }
		partial void OnThangChanging();
		partial void OnThangChanged();
		
		public virtual decimal Nam
        {
            get { return _Nam; }
			set
			{
				OnNamChanging();
				_Nam = value;
				OnNamChanged();
			}
        }
		partial void OnNamChanging();
		partial void OnNamChanged();
		
		public virtual System.Guid DonviId
        {
            get { return _DonviId; }
			set
			{
				OnDonviIdChanging();
				_DonviId = value;
				OnDonviIdChanged();
			}
        }
		partial void OnDonviIdChanging();
		partial void OnDonviIdChanged();
		
		public virtual string MaDonvi
        {
            get { return _MaDonvi; }
			set
			{
				OnMaDonviChanging();
				_MaDonvi = value;
				OnMaDonviChanged();
			}
        }
		partial void OnMaDonviChanging();
		partial void OnMaDonviChanged();
		
		public virtual System.Guid CtdId
        {
            get { return _CtdId; }
			set
			{
				OnCtdIdChanging();
				_CtdId = value;
				OnCtdIdChanged();
			}
        }
		partial void OnCtdIdChanging();
		partial void OnCtdIdChanged();
		
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
		
		public virtual System.Guid CthId
        {
            get { return _CthId; }
			set
			{
				OnCthIdChanging();
				_CthId = value;
				OnCthIdChanged();
			}
        }
		partial void OnCthIdChanging();
		partial void OnCthIdChanged();
		
		public virtual System.Guid IdCha
        {
            get { return _IdCha; }
			set
			{
				OnIdChaChanging();
				_IdCha = value;
				OnIdChaChanged();
			}
        }
		partial void OnIdChaChanging();
		partial void OnIdChaChanged();
		
		public virtual decimal BaoCao
        {
            get { return _BaoCao; }
			set
			{
				OnBaoCaoChanging();
				_BaoCao = value;
				OnBaoCaoChanged();
			}
        }
		partial void OnBaoCaoChanging();
		partial void OnBaoCaoChanged();
		
		public virtual decimal ChiTiet
        {
            get { return _ChiTiet; }
			set
			{
				OnChiTietChanging();
				_ChiTiet = value;
				OnChiTietChanged();
			}
        }
		partial void OnChiTietChanging();
		partial void OnChiTietChanged();
		
		public virtual decimal HeSo
        {
            get { return _HeSo; }
			set
			{
				OnHeSoChanging();
				_HeSo = value;
				OnHeSoChanged();
			}
        }
		partial void OnHeSoChanging();
		partial void OnHeSoChanged();
		
		public virtual System.Guid NguonVonId
        {
            get { return _NguonVonId; }
			set
			{
				OnNguonVonIdChanging();
				_NguonVonId = value;
				OnNguonVonIdChanged();
			}
        }
		partial void OnNguonVonIdChanging();
		partial void OnNguonVonIdChanged();

        public virtual System.DateTime? NgayKhauHao
        {
            get { return _NgayKhauHao; }
            set
            {
                OnNgayKhauHaoChanging();
                _NgayKhauHao = value;
                OnNgayKhauHaoChanged();
            }
        }
        partial void OnNgayKhauHaoChanging();
        partial void OnNgayKhauHaoChanged();
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
