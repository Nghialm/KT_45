using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class CtHHddv : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = String.Empty;
		private System.Guid _IdLoaiCt = new Guid();
		private string _MaLoaiCt = String.Empty;
		private string _KyHieuLoaiCt = String.Empty;

        //private System.DateTime?? _NgayGhi = null;
		private System.DateTime? _NgayGhi = null;
		private string _CtSo = String.Empty;
		private System.DateTime? _NgayCt = null;
		private System.Guid _NteId = new Guid();
		private string _MaNte = String.Empty;
		private decimal _TyGia = 0;
		private decimal _DoanhThu = 0;
		private decimal _DoanhThuNte = 0;
		private decimal _TyLeGiamGia = 0;
		private decimal _SoTienGiamGia = 0;
		private System.DateTime? _NgayTao = null;
		private Guid _NguoiTao = new Guid();
        private Guid _NguoiSua = new Guid();
		private System.DateTime? _NgaySua = null;
		private string _NguoiPd = String.Empty;
		private System.DateTime? _NgayPd = null;
		private string _DienGiai = String.Empty;
		private System.Guid _PhongbanId = new Guid();
		private System.Guid _KhangId = new Guid();
		private string _MaKhang = String.Empty;
		private string _KyHieuKhang = String.Empty;
		private string _TenKhang = String.Empty;
		private string _MstKhang = String.Empty;
		private string _DiaChi = String.Empty;
		private decimal _Ghi = 0;
		private decimal _NgoaiTe = 0;
		private string _SoSeriHd = String.Empty;
		private string _SoHd = String.Empty;
		private System.Guid _IdDoituongHoadon = new Guid();
		private string _PrefixCt = String.Empty;
		private decimal _TtTienMat = 0;
		private decimal _TtTienNh = 0;
		private System.Guid _SoThe1 = new Guid();
		private decimal _TtTienThe1 = 0;
		private System.Guid _SoThe2 = new Guid();
		private decimal _TtTienThe2 = 0;
		private decimal _TtTienNo = 0;
		private System.Guid _IdGuongDichVu = new Guid();
		private System.Guid _IdNhanVien = new Guid();
		private System.DateTime? _TuGio = null;
		private System.DateTime? _DenGio = null;
        private decimal _TheTienThe1 = 0;
        private decimal _TheTienKm1 = 0;
		
		
		
        #endregion

        #region Constructors

        public CtHHddv() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);
			sb.Append(_IdLoaiCt);
			sb.Append(_MaLoaiCt);
			sb.Append(_KyHieuLoaiCt);
			sb.Append(_NgayGhi);
			sb.Append(_CtSo);
			sb.Append(_NgayCt);
			sb.Append(_NteId);
			sb.Append(_MaNte);
			sb.Append(_TyGia);
			sb.Append(_DoanhThu);
			sb.Append(_DoanhThuNte);
			sb.Append(_TyLeGiamGia);
			sb.Append(_SoTienGiamGia);
			sb.Append(_NgayTao);
			sb.Append(_NguoiTao);
			sb.Append(_NguoiSua);
			sb.Append(_NgaySua);
			sb.Append(_NguoiPd);
			sb.Append(_NgayPd);
			sb.Append(_DienGiai);
			sb.Append(_PhongbanId);
			sb.Append(_KhangId);
			sb.Append(_MaKhang);
			sb.Append(_KyHieuKhang);
			sb.Append(_TenKhang);
			sb.Append(_MstKhang);
			sb.Append(_DiaChi);
			sb.Append(_Ghi);
			sb.Append(_NgoaiTe);
			sb.Append(_SoSeriHd);
			sb.Append(_SoHd);
			sb.Append(_IdDoituongHoadon);
			sb.Append(_PrefixCt);
			sb.Append(_TtTienMat);
			sb.Append(_TtTienNh);
			sb.Append(_SoThe1);
			sb.Append(_TtTienThe1);
			sb.Append(_SoThe2);
			sb.Append(_TtTienThe2);
			sb.Append(_TtTienNo);
			sb.Append(_IdGuongDichVu);
			sb.Append(_IdNhanVien);
			sb.Append(_TuGio);
            sb.Append(_DenGio);
            sb.Append(_TheTienThe1);
            sb.Append(_TheTienKm1);

            return sb.ToString().GetHashCode();
        }
		
		public CtHHddv Clone()
        {
            return (CtHHddv)this.MemberwiseClone();
        }
		
		public void SetProperty(CtHHddv des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
			_IdLoaiCt = des.IdLoaiCt;
			_MaLoaiCt = des.MaLoaiCt;
			_KyHieuLoaiCt = des.KyHieuLoaiCt;
			_NgayGhi = des.NgayGhi;
			_CtSo = des.CtSo;
			_NgayCt = des.NgayCt;
			_NteId = des.NteId;
			_MaNte = des.MaNte;
			_TyGia = des.TyGia;
			_DoanhThu = des.DoanhThu;
			_DoanhThuNte = des.DoanhThuNte;
			_TyLeGiamGia = des.TyLeGiamGia;
			_SoTienGiamGia = des.SoTienGiamGia;
			_NgayTao = des.NgayTao;
			_NguoiTao = des.NguoiTao;
			_NguoiSua = des.NguoiSua;
			_NgaySua = des.NgaySua;
			_NguoiPd = des.NguoiPd;
			_NgayPd = des.NgayPd;
			_DienGiai = des.DienGiai;
			_PhongbanId = des.PhongbanId;
			_KhangId = des.KhangId;
			_MaKhang = des.MaKhang;
			_KyHieuKhang = des.KyHieuKhang;
			_TenKhang = des.TenKhang;
			_MstKhang = des.MstKhang;
			_DiaChi = des.DiaChi;
			_Ghi = des.Ghi;
			_NgoaiTe = des.NgoaiTe;
			_SoSeriHd = des.SoSeriHd;
			_SoHd = des.SoHd;
			_IdDoituongHoadon = des.IdDoituongHoadon;
			_PrefixCt = des.PrefixCt;
			_TtTienMat = des.TtTienMat;
			_TtTienNh = des.TtTienNh;
			_SoThe1 = des.SoThe1;
			_TtTienThe1 = des.TtTienThe1;
			_SoThe2 = des.SoThe2;
			_TtTienThe2 = des.TtTienThe2;
			_TtTienNo = des.TtTienNo;
			_IdGuongDichVu = des.IdGuongDichVu;
			_IdNhanVien = des.IdNhanVien;
			_TuGio = des.TuGio;
            _DenGio = des.DenGio;
            _TheTienThe1 = des.TheTienThe1;
            _TheTienKm1 = des.TheTienKm1;
		}

        #endregion

        #region Properties

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
		
		public virtual System.Guid IdLoaiCt
        {
            get { return _IdLoaiCt; }
			set
			{
				OnIdLoaiCtChanging();
				_IdLoaiCt = value;
				OnIdLoaiCtChanged();
			}
        }
		partial void OnIdLoaiCtChanging();
		partial void OnIdLoaiCtChanged();
		
		public virtual string MaLoaiCt
        {
            get { return _MaLoaiCt; }
			set
			{
				OnMaLoaiCtChanging();
				_MaLoaiCt = value;
				OnMaLoaiCtChanged();
			}
        }
		partial void OnMaLoaiCtChanging();
		partial void OnMaLoaiCtChanged();
		
		public virtual string KyHieuLoaiCt
        {
            get { return _KyHieuLoaiCt; }
			set
			{
				OnKyHieuLoaiCtChanging();
				_KyHieuLoaiCt = value;
				OnKyHieuLoaiCtChanged();
			}
        }
		partial void OnKyHieuLoaiCtChanging();
		partial void OnKyHieuLoaiCtChanged();
		
		public virtual System.DateTime? NgayGhi
        {
            get { return _NgayGhi; }
			set
			{
				OnNgayGhiChanging();
				_NgayGhi = value;
				OnNgayGhiChanged();
			}
        }
		partial void OnNgayGhiChanging();
		partial void OnNgayGhiChanged();
		
		public virtual string CtSo
        {
            get { return _CtSo; }
			set
			{
				OnCtSoChanging();
				_CtSo = value;
				OnCtSoChanged();
			}
        }
		partial void OnCtSoChanging();
		partial void OnCtSoChanged();
		
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
		
		public virtual System.Guid NteId
        {
            get { return _NteId; }
			set
			{
				OnNteIdChanging();
				_NteId = value;
				OnNteIdChanged();
			}
        }
		partial void OnNteIdChanging();
		partial void OnNteIdChanged();
		
		public virtual string MaNte
        {
            get { return _MaNte; }
			set
			{
				OnMaNteChanging();
				_MaNte = value;
				OnMaNteChanged();
			}
        }
		partial void OnMaNteChanging();
		partial void OnMaNteChanged();
		
		public virtual decimal TyGia
        {
            get { return _TyGia; }
			set
			{
				OnTyGiaChanging();
				_TyGia = value;
				OnTyGiaChanged();
			}
        }
		partial void OnTyGiaChanging();
		partial void OnTyGiaChanged();
		
		public virtual decimal DoanhThu
        {
            get { return _DoanhThu; }
			set
			{
				OnDoanhThuChanging();
				_DoanhThu = value;
				OnDoanhThuChanged();
			}
        }
		partial void OnDoanhThuChanging();
		partial void OnDoanhThuChanged();
		
		public virtual decimal DoanhThuNte
        {
            get { return _DoanhThuNte; }
			set
			{
				OnDoanhThuNteChanging();
				_DoanhThuNte = value;
				OnDoanhThuNteChanged();
			}
        }
		partial void OnDoanhThuNteChanging();
		partial void OnDoanhThuNteChanged();
		
		public virtual decimal TyLeGiamGia
        {
            get { return _TyLeGiamGia; }
			set
			{
				OnTyLeGiamGiaChanging();
				_TyLeGiamGia = value;
				OnTyLeGiamGiaChanged();
			}
        }
		partial void OnTyLeGiamGiaChanging();
		partial void OnTyLeGiamGiaChanged();
		
		public virtual decimal SoTienGiamGia
        {
            get { return _SoTienGiamGia; }
			set
			{
				OnSoTienGiamGiaChanging();
				_SoTienGiamGia = value;
				OnSoTienGiamGiaChanged();
			}
        }
		partial void OnSoTienGiamGiaChanging();
		partial void OnSoTienGiamGiaChanged();
		
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
		
		public virtual string NguoiPd
        {
            get { return _NguoiPd; }
			set
			{
				OnNguoiPdChanging();
				_NguoiPd = value;
				OnNguoiPdChanged();
			}
        }
		partial void OnNguoiPdChanging();
		partial void OnNguoiPdChanged();
		
		public virtual System.DateTime? NgayPd
        {
            get { return _NgayPd; }
			set
			{
				OnNgayPdChanging();
				_NgayPd = value;
				OnNgayPdChanged();
			}
        }
		partial void OnNgayPdChanging();
		partial void OnNgayPdChanged();
		
		public virtual string DienGiai
        {
            get { return _DienGiai; }
			set
			{
				OnDienGiaiChanging();
				_DienGiai = value;
				OnDienGiaiChanged();
			}
        }
		partial void OnDienGiaiChanging();
		partial void OnDienGiaiChanged();
		
		public virtual System.Guid PhongbanId
        {
            get { return _PhongbanId; }
			set
			{
				OnPhongbanIdChanging();
				_PhongbanId = value;
				OnPhongbanIdChanged();
			}
        }
		partial void OnPhongbanIdChanging();
		partial void OnPhongbanIdChanged();
		
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
		
		public virtual string MstKhang
        {
            get { return _MstKhang; }
			set
			{
				OnMstKhangChanging();
				_MstKhang = value;
				OnMstKhangChanged();
			}
        }
		partial void OnMstKhangChanging();
		partial void OnMstKhangChanged();
		
		public virtual string DiaChi
        {
            get { return _DiaChi; }
			set
			{
				OnDiaChiChanging();
				_DiaChi = value;
				OnDiaChiChanged();
			}
        }
		partial void OnDiaChiChanging();
		partial void OnDiaChiChanged();
		
		public virtual decimal Ghi
        {
            get { return _Ghi; }
			set
			{
				OnGhiChanging();
				_Ghi = value;
				OnGhiChanged();
			}
        }
		partial void OnGhiChanging();
		partial void OnGhiChanged();
		
		public virtual decimal NgoaiTe
        {
            get { return _NgoaiTe; }
			set
			{
				OnNgoaiTeChanging();
				_NgoaiTe = value;
				OnNgoaiTeChanged();
			}
        }
		partial void OnNgoaiTeChanging();
		partial void OnNgoaiTeChanged();
		
		public virtual string SoSeriHd
        {
            get { return _SoSeriHd; }
			set
			{
				OnSoSeriHdChanging();
				_SoSeriHd = value;
				OnSoSeriHdChanged();
			}
        }
		partial void OnSoSeriHdChanging();
		partial void OnSoSeriHdChanged();
		
		public virtual string SoHd
        {
            get { return _SoHd; }
			set
			{
				OnSoHdChanging();
				_SoHd = value;
				OnSoHdChanged();
			}
        }
		partial void OnSoHdChanging();
		partial void OnSoHdChanged();
		
		public virtual System.Guid IdDoituongHoadon
        {
            get { return _IdDoituongHoadon; }
			set
			{
				OnIdDoituongHoadonChanging();
				_IdDoituongHoadon = value;
				OnIdDoituongHoadonChanged();
			}
        }
		partial void OnIdDoituongHoadonChanging();
		partial void OnIdDoituongHoadonChanged();
		
		public virtual string PrefixCt
        {
            get { return _PrefixCt; }
			set
			{
				OnPrefixCtChanging();
				_PrefixCt = value;
				OnPrefixCtChanged();
			}
        }
		partial void OnPrefixCtChanging();
		partial void OnPrefixCtChanged();
		
		public virtual decimal TtTienMat
        {
            get { return _TtTienMat; }
			set
			{
				OnTtTienMatChanging();
				_TtTienMat = value;
				OnTtTienMatChanged();
			}
        }
		partial void OnTtTienMatChanging();
		partial void OnTtTienMatChanged();
		
		public virtual decimal TtTienNh
        {
            get { return _TtTienNh; }
			set
			{
				OnTtTienNhChanging();
				_TtTienNh = value;
				OnTtTienNhChanged();
			}
        }
		partial void OnTtTienNhChanging();
		partial void OnTtTienNhChanged();
		
		public virtual System.Guid SoThe1
        {
            get { return _SoThe1; }
			set
			{
				OnSoThe1Changing();
				_SoThe1 = value;
				OnSoThe1Changed();
			}
        }
		partial void OnSoThe1Changing();
		partial void OnSoThe1Changed();
		
		public virtual decimal TtTienThe1
        {
            get { return _TtTienThe1; }
			set
			{
				OnTtTienThe1Changing();
				_TtTienThe1 = value;
				OnTtTienThe1Changed();
			}
        }
		partial void OnTtTienThe1Changing();
		partial void OnTtTienThe1Changed();
		
		public virtual System.Guid SoThe2
        {
            get { return _SoThe2; }
			set
			{
				OnSoThe2Changing();
				_SoThe2 = value;
				OnSoThe2Changed();
			}
        }
		partial void OnSoThe2Changing();
		partial void OnSoThe2Changed();
		
		public virtual decimal TtTienThe2
        {
            get { return _TtTienThe2; }
			set
			{
				OnTtTienThe2Changing();
				_TtTienThe2 = value;
				OnTtTienThe2Changed();
			}
        }
		partial void OnTtTienThe2Changing();
		partial void OnTtTienThe2Changed();
		
		public virtual decimal TtTienNo
        {
            get { return _TtTienNo; }
			set
			{
				OnTtTienNoChanging();
				_TtTienNo = value;
				OnTtTienNoChanged();
			}
        }
		partial void OnTtTienNoChanging();
		partial void OnTtTienNoChanged();
		
		public virtual System.Guid IdGuongDichVu
        {
            get { return _IdGuongDichVu; }
			set
			{
				OnIdGuongDichVuChanging();
				_IdGuongDichVu = value;
				OnIdGuongDichVuChanged();
			}
        }
		partial void OnIdGuongDichVuChanging();
		partial void OnIdGuongDichVuChanged();
		
		public virtual System.Guid IdNhanVien
        {
            get { return _IdNhanVien; }
			set
			{
				OnIdNhanVienChanging();
				_IdNhanVien = value;
				OnIdNhanVienChanged();
			}
        }
		partial void OnIdNhanVienChanging();
		partial void OnIdNhanVienChanged();
		
		public virtual System.DateTime? TuGio
        {
            get { return _TuGio; }
			set
			{
				OnTuGioChanging();
				_TuGio = value;
				OnTuGioChanged();
			}
        }
		partial void OnTuGioChanging();
		partial void OnTuGioChanged();
		
		public virtual System.DateTime? DenGio
        {
            get { return _DenGio; }
			set
			{
				OnDenGioChanging();
				_DenGio = value;
				OnDenGioChanged();
			}
        }
		partial void OnDenGioChanging();
		partial void OnDenGioChanged();

        public virtual decimal TheTienThe1
        {
            get { return _TheTienThe1; }
            set
            {
                OnTheTienThe1Changing();
                _TheTienThe1 = value;
                OnTheTienThe1Changed();
            }
        }
        partial void OnTheTienThe1Changing();
        partial void OnTheTienThe1Changed();

        public virtual decimal TheTienKm1
        {
            get { return _TheTienKm1; }
            set
            {
                OnTheTienKm1Changing();
                _TheTienKm1 = value;
                OnTheTienKm1Changed();
            }
        }
        partial void OnTheTienKm1Changing();
        partial void OnTheTienKm1Changed();
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
