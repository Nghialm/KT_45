using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxKehoachM : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

        private System.Guid _IdLoaiCt = new Guid();
        private string _MaLoaiCt = String.Empty;
        private string _KyHieuLoaiCt = String.Empty;
        private System.DateTime _NgayKeHoach = Null.MIN_DATE;// Null.MIN_DATE;
        private System.DateTime _NgayPheDuyet = Null.MIN_DATE;
        private System.DateTime _NgayBatDau = Null.MIN_DATE;
        private System.DateTime _NgayKetThuc = Null.MAX_DATE;
        private int _DaKetThuc = 0;
        private string _SoLenh = String.Empty;
        private System.Guid _SanphamId = new Guid();
        private System.Guid _KhachhangId = new Guid();
        private int _TrangThai = 0;
        private string _NguoiLap = String.Empty;
        private string _NguoiPheDuyet = String.Empty;
        private string _MoTa = String.Empty;
        private System.Guid _DonviId = new Guid();
        private string _MaKhachhang = String.Empty;
        private string _TenKhachhang = String.Empty;
        private string _MaSanpham = String.Empty;
        private string _TenSanpham = String.Empty;
        private string _PrefixCt = String.Empty;


        #endregion

        #region Constructors

        public SxKehoachM() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.GetType().FullName);
            sb.Append(_NgayKeHoach);
            sb.Append(_NgayPheDuyet);
            sb.Append(_NgayBatDau);
            sb.Append(_NgayKetThuc);
            sb.Append(_DaKetThuc);
            sb.Append(_SoLenh);
            sb.Append(_SanphamId);
            sb.Append(_KhachhangId);
            sb.Append(_TrangThai);
            sb.Append(_NguoiLap);
            sb.Append(_NguoiPheDuyet);
            sb.Append(_MoTa);
            sb.Append(_DonviId);
            sb.Append(_IdLoaiCt);
            sb.Append(_MaLoaiCt);
            sb.Append(_KyHieuLoaiCt);
            sb.Append(_MaKhachhang);
            sb.Append(_TenKhachhang);
            sb.Append(_MaSanpham);
            sb.Append(_TenSanpham);
            sb.Append(_PrefixCt);
            return sb.ToString().GetHashCode();
        }

        public SxKehoachM Clone()
        {
            return (SxKehoachM)this.MemberwiseClone();
        }

        public void SetProperty(SxKehoachM des)
        {
            //ID Field
            Id = des.Id;
            //Non ID Field
            _NgayKeHoach = des.NgayKeHoach;
            _NgayPheDuyet = des.NgayPheDuyet;
            _NgayBatDau = des.NgayBatDau;
            _NgayKetThuc = des.NgayKetThuc;
            _DaKetThuc = des.DaKetThuc;
            _SoLenh = des.SoLenh;
            _SanphamId = des.SanphamId;
            _KhachhangId = des.KhachhangId;
            _TrangThai = des.TrangThai;
            _NguoiLap = des.NguoiLap;
            _NguoiPheDuyet = des.NguoiPheDuyet;
            _MoTa = des.MoTa;
            _DonviId = des.DonviId;
            _IdLoaiCt = des.IdLoaiCt;
            _MaLoaiCt = des.MaLoaiCt;
            _KyHieuLoaiCt = des.KyHieuLoaiCt;
            _MaKhachhang = des.MaKhachhang;
            _TenKhachhang = des.TenKhachhang;
            _MaSanpham = des.MaSanpham;
            _TenSanpham = des.TenSanpham;
            _PrefixCt = des.PrefixCt;
        }

        #endregion

        #region Properties
        public virtual System.Guid IdLoaiCt
        {
            get { return _IdLoaiCt; }
            set { _IdLoaiCt = value; }
        }

        public virtual string MaLoaiCt
        {
            get { return _MaLoaiCt; }
            set { _MaLoaiCt = value; }
        }

        public virtual string PrefixCt
        {
            get { return _PrefixCt; }
            set { _PrefixCt = value; } 
        }

        public string KyHieuLoaiCt
        {
            get { return _KyHieuLoaiCt; }
            set { _KyHieuLoaiCt = value; }
        }

        public virtual System.DateTime NgayKeHoach
        {
            get { return _NgayKeHoach; }
            set
            {
                OnNgayKeHoachChanging();
                _NgayKeHoach = value;
                OnNgayKeHoachChanged();
            }
        }
        partial void OnNgayKeHoachChanging();
        partial void OnNgayKeHoachChanged();

        public virtual System.DateTime NgayPheDuyet
        {
            get { return _NgayPheDuyet; }
            set
            {
                OnNgayPheDuyetChanging();
                _NgayPheDuyet = value;
                OnNgayPheDuyetChanged();
            }
        }
        partial void OnNgayPheDuyetChanging();
        partial void OnNgayPheDuyetChanged();

        public virtual System.DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set
            {
                _NgayBatDau = value;
            }
        }

        public virtual System.DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set
            {
                OnNgayKetThucChanging();
                _NgayKetThuc = value;
                OnNgayKetThucChanged();
            }
        }
        partial void OnNgayKetThucChanging();
        partial void OnNgayKetThucChanged();

        public virtual int DaKetThuc
        {
            get { return _DaKetThuc; }
            set
            {
                OnDaKetThucChanging();
                _DaKetThuc = value;
                OnDaKetThucChanged();
            }
        }
        partial void OnDaKetThucChanging();
        partial void OnDaKetThucChanged();

        public virtual string SoLenh
        {
            get { return _SoLenh; }
            set
            {
                OnSoLenhChanging();
                _SoLenh = value;
                OnSoLenhChanged();
            }
        }
        partial void OnSoLenhChanging();
        partial void OnSoLenhChanged();

        public virtual System.Guid SanphamId
        {
            get { return _SanphamId; }
            set
            {
                OnSanphamIdChanging();
                _SanphamId = value;
                OnSanphamIdChanged();
            }
        }
        partial void OnSanphamIdChanging();
        partial void OnSanphamIdChanged();

        public virtual System.Guid KhachhangId
        {
            get { return _KhachhangId; }
            set
            {
                OnKhachhangIdChanging();
                _KhachhangId = value;
                OnKhachhangIdChanged();
            }
        }
        partial void OnKhachhangIdChanging();
        partial void OnKhachhangIdChanged();

        public virtual int TrangThai
        {
            get { return _TrangThai; }
            set
            {
                OnTrangThaiChanging();
                _TrangThai = value;
                OnTrangThaiChanged();
            }
        }
        partial void OnTrangThaiChanging();
        partial void OnTrangThaiChanged();

        public virtual string NguoiLap
        {
            get { return _NguoiLap; }
            set
            {
                OnNguoiLapChanging();
                _NguoiLap = value;
                OnNguoiLapChanged();
            }
        }
        partial void OnNguoiLapChanging();
        partial void OnNguoiLapChanged();

        public virtual string NguoiPheDuyet
        {
            get { return _NguoiPheDuyet; }
            set
            {
                OnNguoiPheDuyetChanging();
                _NguoiPheDuyet = value;
                OnNguoiPheDuyetChanged();
            }
        }
        partial void OnNguoiPheDuyetChanging();
        partial void OnNguoiPheDuyetChanged();

        public virtual string MoTa
        {
            get { return _MoTa; }
            set
            {
                OnMoTaChanging();
                _MoTa = value;
                OnMoTaChanged();
            }
        }
        partial void OnMoTaChanging();
        partial void OnMoTaChanged();

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

        public virtual string TenKhachhang
        {
            get { return _TenKhachhang; }
            set
            {
                OnTenKhachhangChanging();
                _TenKhachhang = value;
                OnTenKhachhangChanged();
            }
        }
        partial void OnTenKhachhangChanging();
        partial void OnTenKhachhangChanged();

        public virtual string MaKhachhang
        {
            get { return _MaKhachhang; }
            set
            {
                OnMaKhachhangChanging();
                _MaKhachhang = value;
                OnMaKhachhangChanged();
            }
        }
        partial void OnMaKhachhangChanging();
        partial void OnMaKhachhangChanged();


        public virtual string TenSanpham
        {
            get { return _TenSanpham; }
            set
            {
                OnTenSanphamChanging();
                _TenSanpham = value;
                OnTenSanphamChanged();
            }
        }
        partial void OnTenSanphamChanging();
        partial void OnTenSanphamChanged();

        public virtual string MaSanpham
        {
            get { return _MaSanpham; }
            set
            {
                OnMaSanphamChanging();
                _MaSanpham = value;
                OnMaSanphamChanged();
            }
        }
        partial void OnMaSanphamChanging();
        partial void OnMaSanphamChanged();
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
