/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
namespace Vns.Erp.Core.Accounting.Domain
{
    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo And Modified By Hoang Quoc Dung
    /// </summary>


    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Accounting.Domain", IsReference = true)]
    public partial class CtH : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _cth_id;
        private Guid _donvi_id;
        private string _ma_donvi;
        private Guid _id_loai_ct;
        private string _ma_loai_ct;
        private string _ky_hieu_loai_ct;
        private DateTime? _ngay_ghi;
        private string _ct_so;
        private string _quyen_so;
        private DateTime? _ngay_ct;
        private Guid _nte_id;
        private string _ma_nte;
        private decimal _ty_gia;
        private decimal _so_tien;
        private decimal _so_tien_nte;
        private DateTime? _ngay_tao;
        private Guid _nguoi_tao;
        private Guid _nguoi_sua;
        private DateTime? _ngay_sua;
        private Guid _nguoi_pd;
        private DateTime? _ngay_pd;
        private string _dien_giai;
        private Guid _phongban_id;
        private string _ma_phongban;
        private string _ky_hieu_phongban;
        private string _ten_phongban;
        private string _nguoi_nhan_nop_tien;
        private string _nguoi_giao_nhan_hang;
        private Guid _khang_id;
        private string _ma_khang;
        private string _ky_hieu_khang;
        private string _ten_khang;
        private string _mst_khang;
        private string _dia_chi;
        private Guid _cbnv_id;
        private string _ky_hieu_cbnv;
        private string _ma_cbnv;
        private string _ten_cbnv;
        private decimal _ghi;
        private string _attachfile;
        private decimal _ngoai_te;
        private Guid _donvi_ct;
        private string _ma_donvi_ct;
        private decimal _da_khoa_so;
        private DateTime? _ngay_khoa_so;
        private decimal _bt_tudong;
        private DateTime? _bx_ngay_1;
        private DateTime? _bx_ngay_2;
        private DateTime? _bx_ngay_3;
        private decimal _bx_number_1;
        private decimal _bx_number_2;
        private decimal _bx_number_3;
        private string _bx_diengiai_1;
        private string _bx_diengiai_2;
        private string _bx_diengiai_3;
        private decimal _so_du;
        private string _prefix_ct;

        private DateTime _SynDate = Null.MIN_DATE;
        private decimal? _IsDeleted = 0;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public CtH()
        {
            _cth_id = new Guid();
            _donvi_id = new Guid();
            _ma_donvi = String.Empty;
            _id_loai_ct = new Guid();
            _ma_loai_ct = String.Empty;
            _ky_hieu_loai_ct = String.Empty;
            _ngay_ghi = DateTime.MaxValue;
            _ct_so = String.Empty;
            _quyen_so = String.Empty;
            _ngay_ct = DateTime.MaxValue;
            _nte_id = new Guid();
            _ma_nte = String.Empty;
            _ty_gia = 0;
            _so_tien = 0;
            _so_tien_nte = 0;
            _ngay_tao = DateTime.MaxValue;
            _nguoi_tao = new Guid();
            _nguoi_sua = new Guid();
            _ngay_sua = DateTime.MaxValue;
            _nguoi_pd = new Guid();
            _ngay_pd = DateTime.MaxValue;
            _dien_giai = String.Empty;
            _phongban_id = new Guid();
            _ma_phongban = String.Empty;
            _ky_hieu_phongban = String.Empty;
            _ten_phongban = String.Empty;
            _nguoi_nhan_nop_tien = String.Empty;
            _nguoi_giao_nhan_hang = String.Empty;
            _khang_id = new Guid();
            _ma_khang = String.Empty;
            _ky_hieu_khang = String.Empty;
            _ten_khang = String.Empty;
            _mst_khang = String.Empty;
            _dia_chi = String.Empty;
            _cbnv_id = new Guid();
            _ky_hieu_cbnv = String.Empty;
            _ma_cbnv = String.Empty;
            _ten_cbnv = String.Empty;
            _ghi = 0;
            _attachfile = String.Empty;
            _ngoai_te = 0;
            _donvi_ct = new Guid();
            _ma_donvi_ct = String.Empty;
            _da_khoa_so = 0;
            _ngay_khoa_so = DateTime.MaxValue;
            _bt_tudong = 0;
            _bx_ngay_1 = DateTime.MaxValue;
            _bx_ngay_2 = DateTime.MaxValue;
            _bx_ngay_3 = DateTime.MaxValue;
            _bx_number_1 = 0;
            _bx_number_2 = 0;
            _bx_number_3 = 0;
            _bx_diengiai_1 = String.Empty;
            _bx_diengiai_2 = String.Empty;
            _bx_diengiai_3 = String.Empty;
            _so_du = 0;
            _prefix_ct = String.Empty;
            _SynDate = Null.MIN_DATE;
            _IsDeleted = 0;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid CthId
        {
            get { return _cth_id; }
            set { _isChanged |= (_cth_id != value); _cth_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid DonviId
        {
            get { return _donvi_id; }
            set { _isChanged |= (_donvi_id != value); _donvi_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaDonvi
        {
            get { return _ma_donvi; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaDonvi", value, value.ToString());

                _isChanged |= (_ma_donvi != value); _ma_donvi = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid IdLoaiCt
        {
            get { return _id_loai_ct; }
            set { _isChanged |= (_id_loai_ct != value); _id_loai_ct = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaLoaiCt
        {
            get { return _ma_loai_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaLoaiCt", value, value.ToString());

                _isChanged |= (_ma_loai_ct != value); _ma_loai_ct = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string KyHieuLoaiCt
        {
            get { return _ky_hieu_loai_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieuLoaiCt", value, value.ToString());

                _isChanged |= (_ky_hieu_loai_ct != value); _ky_hieu_loai_ct = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgayGhi
        {
            get { return _ngay_ghi; }
            set { _isChanged |= (_ngay_ghi != value); _ngay_ghi = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string CtSo
        {
            get { return _ct_so; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for CtSo", value, value.ToString());

                _isChanged |= (_ct_so != value); _ct_so = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string QuyenSo
        {
            get { return _quyen_so; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for QuyenSo", value, value.ToString());

                _isChanged |= (_quyen_so != value); _quyen_so = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgayCt
        {
            get { return _ngay_ct; }
            set { _isChanged |= (_ngay_ct != value); _ngay_ct = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid NteId
        {
            get { return _nte_id; }
            set { _isChanged |= (_nte_id != value); _nte_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaNte
        {
            get { return _ma_nte; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for MaNte", value, value.ToString());

                _isChanged |= (_ma_nte != value); _ma_nte = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal TyGia
        {
            get { return _ty_gia; }
            set { _isChanged |= (_ty_gia != value); _ty_gia = Decimal.Round(value, 0); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal SoTien
        {
            get { return _so_tien; }
            set { _isChanged |= (_so_tien != value); _so_tien = Decimal.Round(value, 0); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal SoTienNte
        {
            get { return _so_tien_nte; }
            set { _isChanged |= (_so_tien_nte != value); _so_tien_nte = Decimal.Round(value, 2); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgayTao
        {
            get { return _ngay_tao; }
            set { _isChanged |= (_ngay_tao != value); _ngay_tao = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid NguoiTao
        {
            get { return _nguoi_tao; }
            set
            {
                _nguoi_tao = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid NguoiSua
        {
            get { return _nguoi_sua; }
            set
            {
                _nguoi_sua = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgaySua
        {
            get { return _ngay_sua; }
            set { _isChanged |= (_ngay_sua != value); _ngay_sua = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid NguoiPd
        {
            get { return _nguoi_pd; }
            set
            {
                _nguoi_pd = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgayPd
        {
            get { return _ngay_pd; }
            set { _isChanged |= (_ngay_pd != value); _ngay_pd = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string DienGiai
        {
            get { return _dien_giai; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for DienGiai", value, value.ToString());

                _isChanged |= (_dien_giai != value); _dien_giai = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid PhongbanId
        {
            get { return _phongban_id; }
            set { _isChanged |= (_phongban_id != value); _phongban_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaPhongban
        {
            get { return _ma_phongban; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaPhongban", value, value.ToString());

                _isChanged |= (_ma_phongban != value); _ma_phongban = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string KyHieuPhongban
        {
            get { return _ky_hieu_phongban; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieuPhongban", value, value.ToString());

                _isChanged |= (_ky_hieu_phongban != value); _ky_hieu_phongban = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenPhongban
        {
            get { return _ten_phongban; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenPhongban", value, value.ToString());

                _isChanged |= (_ten_phongban != value); _ten_phongban = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string NguoiNhanNopTien
        {
            get { return _nguoi_nhan_nop_tien; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for NguoiNhanNopTien", value, value.ToString());

                _isChanged |= (_nguoi_nhan_nop_tien != value); _nguoi_nhan_nop_tien = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string NguoiGiaoNhanHang
        {
            get { return _nguoi_giao_nhan_hang; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for NguoiGiaoNhanHang", value, value.ToString());

                _isChanged |= (_nguoi_giao_nhan_hang != value); _nguoi_giao_nhan_hang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid KhangId
        {
            get { return _khang_id; }
            set { _isChanged |= (_khang_id != value); _khang_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaKhang
        {
            get { return _ma_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaKhang", value, value.ToString());

                _isChanged |= (_ma_khang != value); _ma_khang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string KyHieuKhang
        {
            get { return _ky_hieu_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieuKhang", value, value.ToString());

                _isChanged |= (_ky_hieu_khang != value); _ky_hieu_khang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenKhang
        {
            get { return _ten_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for TenKhang", value, value.ToString());

                _isChanged |= (_ten_khang != value); _ten_khang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MstKhang
        {
            get { return _mst_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for MstKhang", value, value.ToString());

                _isChanged |= (_mst_khang != value); _mst_khang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string DiaChi
        {
            get { return _dia_chi; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for DiaChi", value, value.ToString());

                _isChanged |= (_dia_chi != value); _dia_chi = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid CbnvId
        {
            get { return _cbnv_id; }
            set { _isChanged |= (_cbnv_id != value); _cbnv_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string KyHieuCbnv
        {
            get { return _ky_hieu_cbnv; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieuCbnv", value, value.ToString());

                _isChanged |= (_ky_hieu_cbnv != value); _ky_hieu_cbnv = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaCbnv
        {
            get { return _ma_cbnv; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaCbnv", value, value.ToString());

                _isChanged |= (_ma_cbnv != value); _ma_cbnv = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenCbnv
        {
            get { return _ten_cbnv; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenCbnv", value, value.ToString());

                _isChanged |= (_ten_cbnv != value); _ten_cbnv = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal Ghi
        {
            get { return _ghi; }
            set { _isChanged |= (_ghi != value); _ghi = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Attachfile
        {
            get { return _attachfile; }
            set
            {
                if (value != null)
                    if (value.Length > 500)
                        throw new ArgumentOutOfRangeException("Invalid value for Attachfile", value, value.ToString());

                _isChanged |= (_attachfile != value); _attachfile = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal NgoaiTe
        {
            get { return _ngoai_te; }
            set { _isChanged |= (_ngoai_te != value); _ngoai_te = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid DonviCt
        {
            get { return _donvi_ct; }
            set { _isChanged |= (_donvi_ct != value); _donvi_ct = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaDonviCt
        {
            get { return _ma_donvi_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaDonviCt", value, value.ToString());

                _isChanged |= (_ma_donvi_ct != value); _ma_donvi_ct = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DaKhoaSo
        {
            get { return _da_khoa_so; }
            set { _isChanged |= (_da_khoa_so != value); _da_khoa_so = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? NgayKhoaSo
        {
            get { return _ngay_khoa_so; }
            set { _isChanged |= (_ngay_khoa_so != value); _ngay_khoa_so = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal BtTudong
        {
            get { return _bt_tudong; }
            set { _isChanged |= (_bt_tudong != value); _bt_tudong = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? BxNgay1
        {
            get { return _bx_ngay_1; }
            set { _isChanged |= (_bx_ngay_1 != value); _bx_ngay_1 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? BxNgay2
        {
            get { return _bx_ngay_2; }
            set { _isChanged |= (_bx_ngay_2 != value); _bx_ngay_2 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime? BxNgay3
        {
            get { return _bx_ngay_3; }
            set { _isChanged |= (_bx_ngay_3 != value); _bx_ngay_3 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal BxNumber1
        {
            get { return _bx_number_1; }
            set { _isChanged |= (_bx_number_1 != value); _bx_number_1 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal BxNumber2
        {
            get { return _bx_number_2; }
            set { _isChanged |= (_bx_number_2 != value); _bx_number_2 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal BxNumber3
        {
            get { return _bx_number_3; }
            set { _isChanged |= (_bx_number_3 != value); _bx_number_3 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string BxDiengiai1
        {
            get { return _bx_diengiai_1; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for BxDiengiai1", value, value.ToString());

                _isChanged |= (_bx_diengiai_1 != value); _bx_diengiai_1 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string BxDiengiai2
        {
            get { return _bx_diengiai_2; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for BxDiengiai2", value, value.ToString());

                _isChanged |= (_bx_diengiai_2 != value); _bx_diengiai_2 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string BxDiengiai3
        {
            get { return _bx_diengiai_3; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for BxDiengiai3", value, value.ToString());

                _isChanged |= (_bx_diengiai_3 != value); _bx_diengiai_3 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal SoDu
        {
            get { return _so_du; }
            set { _isChanged |= (_so_du != value); _so_du = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string PrefixCt
        {
            get { return _prefix_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for PrefixCt", value, value.ToString());

                _isChanged |= (_prefix_ct != value); _prefix_ct = value;
            }
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
        [DataMember]
        public Decimal? IsDeleted
        {
            get { return _IsDeleted; }
            set
            {
                if (value == null)
                    _IsDeleted = 0;
                else
                    _IsDeleted = value;
            }
        }

        [DataMember]
        public DateTime SynDate
        {
            get { return _SynDate; }
            set { _isChanged |= (_SynDate != value); _SynDate = value; }
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
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            CtH castObj = (CtH)obj;
            return (castObj != null) &&
                (this._cth_id == castObj.CthId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _cth_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
