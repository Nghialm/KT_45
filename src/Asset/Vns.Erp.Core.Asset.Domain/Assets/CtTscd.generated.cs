using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
    public partial class CtTscd : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _LoaiTaikhoan = String.Empty;
		private System.Guid _TaikhoanId = new Guid();
		private string _MaTaikhoan = String.Empty;
		private System.Guid _CtdId = new Guid();
		private System.Guid _TscdId = new Guid();
		private string _MaTscd = String.Empty;
		private string _KyHieuTscd = String.Empty;
		private string _TenTscd = String.Empty;
		private decimal _SoTien = default(Decimal);
		private decimal _SoTienNte = default(Decimal);
		private System.Guid _KhangId = new Guid();
		private string _MaKhang = String.Empty;
		private string _KyHieuKhang = String.Empty;
		private string _TenKhang = String.Empty;
		private System.Guid _LydoTanggiam = new Guid();
		private string _TenLydoTanggiam = String.Empty;
		private System.Guid _DvtId = new Guid();
		private string _MaDvt = String.Empty;
		private string _TenDvt = String.Empty;
		private System.Guid _LoaitaisanId = new Guid();
		private string _MaLoaitaisan = String.Empty;
		private decimal _NguyenGia = default(Decimal);
		private decimal _GiaTriCl = default(Decimal);
		private decimal _HaoMonLuyKe = default(Decimal);
		private decimal _TyLeHaomon = default(Decimal);
		private decimal _LoaiNghiepvu = default(Decimal);
		private decimal _TangTscd = default(Decimal);
		private decimal _ThuTu = default(Decimal);
		private System.DateTime? _NgayCt = null;
		private System.DateTime? _NgayBdKh = null;
		private System.DateTime? _NgayKtKh = null;
		private decimal _SoNamSd = default(Decimal);
		private decimal _SoThangSd = default(Decimal);
		private string _SoCt = String.Empty;
		private System.Guid _CthId = new Guid();
		private System.Guid _TkChiphi = new Guid();
		private string _MaTkChiphi = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public CtTscd() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LoaiTaikhoan);
			sb.Append(_TaikhoanId);
			sb.Append(_MaTaikhoan);
			sb.Append(_CtdId);
			sb.Append(_TscdId);
			sb.Append(_MaTscd);
			sb.Append(_KyHieuTscd);
			sb.Append(_TenTscd);
			sb.Append(_SoTien);
			sb.Append(_SoTienNte);
			sb.Append(_KhangId);
			sb.Append(_MaKhang);
			sb.Append(_KyHieuKhang);
			sb.Append(_TenKhang);
			sb.Append(_LydoTanggiam);
			sb.Append(_TenLydoTanggiam);
			sb.Append(_DvtId);
			sb.Append(_MaDvt);
			sb.Append(_TenDvt);
			sb.Append(_LoaitaisanId);
			sb.Append(_MaLoaitaisan);
			sb.Append(_NguyenGia);
			sb.Append(_GiaTriCl);
			sb.Append(_HaoMonLuyKe);
			sb.Append(_TyLeHaomon);
			sb.Append(_LoaiNghiepvu);
			sb.Append(_TangTscd);
			sb.Append(_ThuTu);
			sb.Append(_NgayCt);
			sb.Append(_NgayBdKh);
			sb.Append(_NgayKtKh);
			sb.Append(_SoNamSd);
			sb.Append(_SoThangSd);
			sb.Append(_SoCt);
			sb.Append(_CthId);
			sb.Append(_TkChiphi);
			sb.Append(_MaTkChiphi);

            return sb.ToString().GetHashCode();
        }
		
		public CtTscd Clone()
        {
            return (CtTscd)this.MemberwiseClone();
        }
		
		public void SetProperty(CtTscd des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LoaiTaikhoan = des.LoaiTaikhoan;
			_TaikhoanId = des.TaikhoanId;
			_MaTaikhoan = des.MaTaikhoan;
			_CtdId = des.CtdId;
			_TscdId = des.TscdId;
			_MaTscd = des.MaTscd;
			_KyHieuTscd = des.KyHieuTscd;
			_TenTscd = des.TenTscd;
			_SoTien = des.SoTien;
			_SoTienNte = des.SoTienNte;
			_KhangId = des.KhangId;
			_MaKhang = des.MaKhang;
			_KyHieuKhang = des.KyHieuKhang;
			_TenKhang = des.TenKhang;
			_LydoTanggiam = des.LydoTanggiam;
			_TenLydoTanggiam = des.TenLydoTanggiam;
			_DvtId = des.DvtId;
			_MaDvt = des.MaDvt;
			_TenDvt = des.TenDvt;
			_LoaitaisanId = des.LoaitaisanId;
			_MaLoaitaisan = des.MaLoaitaisan;
			_NguyenGia = des.NguyenGia;
			_GiaTriCl = des.GiaTriCl;
			_HaoMonLuyKe = des.HaoMonLuyKe;
			_TyLeHaomon = des.TyLeHaomon;
			_LoaiNghiepvu = des.LoaiNghiepvu;
			_TangTscd = des.TangTscd;
			_ThuTu = des.ThuTu;
			_NgayCt = des.NgayCt;
			_NgayBdKh = des.NgayBdKh;
			_NgayKtKh = des.NgayKtKh;
			_SoNamSd = des.SoNamSd;
			_SoThangSd = des.SoThangSd;
			_SoCt = des.SoCt;
			_CthId = des.CthId;
			_TkChiphi = des.TkChiphi;
			_MaTkChiphi = des.MaTkChiphi;
		}

        #endregion

        #region Properties

		public virtual string LoaiTaikhoan
        {
            get { return _LoaiTaikhoan; }
			set
			{
				OnLoaiTaikhoanChanging();
				_LoaiTaikhoan = value;
				OnLoaiTaikhoanChanged();
			}
        }
		partial void OnLoaiTaikhoanChanging();
		partial void OnLoaiTaikhoanChanged();
		
		public virtual System.Guid TaikhoanId
        {
            get { return _TaikhoanId; }
			set
			{
				OnTaikhoanIdChanging();
				_TaikhoanId = value;
				OnTaikhoanIdChanged();
			}
        }
		partial void OnTaikhoanIdChanging();
		partial void OnTaikhoanIdChanged();
		
		public virtual string MaTaikhoan
        {
            get { return _MaTaikhoan; }
			set
			{
				OnMaTaikhoanChanging();
				_MaTaikhoan = value;
				OnMaTaikhoanChanged();
			}
        }
		partial void OnMaTaikhoanChanging();
		partial void OnMaTaikhoanChanged();
		
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
		
		public virtual decimal SoTien
        {
            get { return _SoTien; }
			set
			{
				OnSoTienChanging();
				_SoTien = value;
				OnSoTienChanged();
			}
        }
		partial void OnSoTienChanging();
		partial void OnSoTienChanged();
		
		public virtual decimal SoTienNte
        {
            get { return _SoTienNte; }
			set
			{
				OnSoTienNteChanging();
				_SoTienNte = value;
				OnSoTienNteChanged();
			}
        }
		partial void OnSoTienNteChanging();
		partial void OnSoTienNteChanged();
		
		public virtual System.Guid KhangId
        {
            get { return _KhangId; }
			set
			{
				OnKhangIdChanging();
				_KhangId = value;
				OnKhangIdChanged();
			}
        }
		partial void OnKhangIdChanging();
		partial void OnKhangIdChanged();
		
		public virtual string MaKhang
        {
            get { return _MaKhang; }
			set
			{
				OnMaKhangChanging();
				_MaKhang = value;
				OnMaKhangChanged();
			}
        }
		partial void OnMaKhangChanging();
		partial void OnMaKhangChanged();
		
		public virtual string KyHieuKhang
        {
            get { return _KyHieuKhang; }
			set
			{
				OnKyHieuKhangChanging();
				_KyHieuKhang = value;
				OnKyHieuKhangChanged();
			}
        }
		partial void OnKyHieuKhangChanging();
		partial void OnKyHieuKhangChanged();
		
		public virtual string TenKhang
        {
            get { return _TenKhang; }
			set
			{
				OnTenKhangChanging();
				_TenKhang = value;
				OnTenKhangChanged();
			}
        }
		partial void OnTenKhangChanging();
		partial void OnTenKhangChanged();
		
		public virtual System.Guid LydoTanggiam
        {
            get { return _LydoTanggiam; }
			set
			{
				OnLydoTanggiamChanging();
				_LydoTanggiam = value;
				OnLydoTanggiamChanged();
			}
        }
		partial void OnLydoTanggiamChanging();
		partial void OnLydoTanggiamChanged();
		
		public virtual string TenLydoTanggiam
        {
            get { return _TenLydoTanggiam; }
			set
			{
				OnTenLydoTanggiamChanging();
				_TenLydoTanggiam = value;
				OnTenLydoTanggiamChanged();
			}
        }
		partial void OnTenLydoTanggiamChanging();
		partial void OnTenLydoTanggiamChanged();
		
		public virtual System.Guid DvtId
        {
            get { return _DvtId; }
			set
			{
				OnDvtIdChanging();
				_DvtId = value;
				OnDvtIdChanged();
			}
        }
		partial void OnDvtIdChanging();
		partial void OnDvtIdChanged();
		
		public virtual string MaDvt
        {
            get { return _MaDvt; }
			set
			{
				OnMaDvtChanging();
				_MaDvt = value;
				OnMaDvtChanged();
			}
        }
		partial void OnMaDvtChanging();
		partial void OnMaDvtChanged();
		
		public virtual string TenDvt
        {
            get { return _TenDvt; }
			set
			{
				OnTenDvtChanging();
				_TenDvt = value;
				OnTenDvtChanged();
			}
        }
		partial void OnTenDvtChanging();
		partial void OnTenDvtChanged();
		
		public virtual System.Guid LoaitaisanId
        {
            get { return _LoaitaisanId; }
			set
			{
				OnLoaitaisanIdChanging();
				_LoaitaisanId = value;
				OnLoaitaisanIdChanged();
			}
        }
		partial void OnLoaitaisanIdChanging();
		partial void OnLoaitaisanIdChanged();
		
		public virtual string MaLoaitaisan
        {
            get { return _MaLoaitaisan; }
			set
			{
				OnMaLoaitaisanChanging();
				_MaLoaitaisan = value;
				OnMaLoaitaisanChanged();
			}
        }
		partial void OnMaLoaitaisanChanging();
		partial void OnMaLoaitaisanChanged();
		
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
		
		public virtual decimal HaoMonLuyKe
        {
            get { return _HaoMonLuyKe; }
			set
			{
				OnHaoMonLuyKeChanging();
				_HaoMonLuyKe = value;
				OnHaoMonLuyKeChanged();
			}
        }
		partial void OnHaoMonLuyKeChanging();
		partial void OnHaoMonLuyKeChanged();
		
		public virtual decimal TyLeHaomon
        {
            get { return _TyLeHaomon; }
			set
			{
				OnTyLeHaomonChanging();
				_TyLeHaomon = value;
				OnTyLeHaomonChanged();
			}
        }
		partial void OnTyLeHaomonChanging();
		partial void OnTyLeHaomonChanged();
		
		public virtual decimal LoaiNghiepvu
        {
            get { return _LoaiNghiepvu; }
			set
			{
				OnLoaiNghiepvuChanging();
				_LoaiNghiepvu = value;
				OnLoaiNghiepvuChanged();
			}
        }
		partial void OnLoaiNghiepvuChanging();
		partial void OnLoaiNghiepvuChanged();
		
		public virtual decimal TangTscd
        {
            get { return _TangTscd; }
			set
			{
				OnTangTscdChanging();
				_TangTscd = value;
				OnTangTscdChanged();
			}
        }
		partial void OnTangTscdChanging();
		partial void OnTangTscdChanged();
		
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
		
		public virtual System.DateTime? NgayCt
        {
            get { return _NgayCt; }
			set
			{
				OnNgayCtChanging();
				_NgayCt = value;
				OnNgayCtChanged();
			}
        }
		partial void OnNgayCtChanging();
		partial void OnNgayCtChanged();
		
		public virtual System.DateTime? NgayBdKh
        {
            get { return _NgayBdKh; }
			set
			{
				OnNgayBdKhChanging();
				_NgayBdKh = value;
				OnNgayBdKhChanged();
			}
        }
		partial void OnNgayBdKhChanging();
		partial void OnNgayBdKhChanged();
		
		public virtual System.DateTime? NgayKtKh
        {
            get { return _NgayKtKh; }
			set
			{
				OnNgayKtKhChanging();
				_NgayKtKh = value;
				OnNgayKtKhChanged();
			}
        }
		partial void OnNgayKtKhChanging();
		partial void OnNgayKtKhChanged();
		
		public virtual decimal SoNamSd
        {
            get { return _SoNamSd; }
			set
			{
				OnSoNamSdChanging();
				_SoNamSd = value;
				OnSoNamSdChanged();
			}
        }
		partial void OnSoNamSdChanging();
		partial void OnSoNamSdChanged();
		
		public virtual decimal SoThangSd
        {
            get { return _SoThangSd; }
			set
			{
				OnSoThangSdChanging();
				_SoThangSd = value;
				OnSoThangSdChanged();
			}
        }
		partial void OnSoThangSdChanging();
		partial void OnSoThangSdChanged();
		
		public virtual string SoCt
        {
            get { return _SoCt; }
			set
			{
				OnSoCtChanging();
				_SoCt = value;
				OnSoCtChanged();
			}
        }
		partial void OnSoCtChanging();
		partial void OnSoCtChanged();
		
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
		
		public virtual System.Guid TkChiphi
        {
            get { return _TkChiphi; }
			set
			{
				OnTkChiphiChanging();
				_TkChiphi = value;
				OnTkChiphiChanged();
			}
        }
		partial void OnTkChiphiChanging();
		partial void OnTkChiphiChanged();
		
		public virtual string MaTkChiphi
        {
            get { return _MaTkChiphi; }
			set
			{
				OnMaTkChiphiChanging();
				_MaTkChiphi = value;
				OnMaTkChiphiChanged();
			}
        }
		partial void OnMaTkChiphiChanging();
		partial void OnMaTkChiphiChanged();
		
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
