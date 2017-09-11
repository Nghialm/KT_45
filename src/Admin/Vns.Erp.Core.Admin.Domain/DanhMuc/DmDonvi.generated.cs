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
    [DataContract(Namespace = "http://Vns.Erp.Core.Admin", IsReference = true)]
    public partial class DmDonvi : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _donvi_id;
        private string _ma_donvi;
        private string _ky_hieu;
        private string _ten_donvi;
        private string _dia_chi;
        private string _quan_huyen;
        private string _tinh_tp;
        private string _dien_thoai;
        private string _fax;
        private string _email;
        private decimal _chi_tiet;
        private string _so_taikhoan_nh;
        private string _ten_nganhang;
        private string _dia_chi_nh;
        private string _ma_so_thue;
        private Guid _donvi_id_cha;
        private decimal _ty_le_gop;
        private decimal _ty_le_cdts;
        private Guid _tien_noite;
        private Guid _tien_ht_phu;
        private string _nguoi_lap_bieu;
        private string _thu_quy;
        private string _kt_truong;
        private string _giam_doc;
        private decimal _che_do_kt;
        private decimal _hinh_thuc_kt;
        private decimal _cap;
        private Guid _nguoi_tao;
        private DateTime _ngay_tao;
        private Guid _nguoi_sua;
        private DateTime _ngay_sua;
        private decimal _bo_phan_tt;
        private decimal _donvi_id1;
        private DateTime _SynDate;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public DmDonvi()
        {
            _donvi_id = new Guid();
            _ma_donvi = String.Empty;
            _ky_hieu = String.Empty;
            _ten_donvi = String.Empty;
            _dia_chi = String.Empty;
            _quan_huyen = String.Empty;
            _tinh_tp = String.Empty;
            _dien_thoai = String.Empty;
            _fax = String.Empty;
            _email = String.Empty;
            _chi_tiet = 0;
            _so_taikhoan_nh = String.Empty;
            _ten_nganhang = String.Empty;
            _dia_chi_nh = String.Empty;
            _ma_so_thue = String.Empty;
            _donvi_id_cha = new Guid();
            _ty_le_gop = 0;
            _ty_le_cdts = 0;
            _tien_noite = new Guid();
            _tien_ht_phu = new Guid();
            _nguoi_lap_bieu = String.Empty;
            _thu_quy = String.Empty;
            _kt_truong = String.Empty;
            _giam_doc = String.Empty;
            _che_do_kt = 0;
            _hinh_thuc_kt = 0;
            _cap = 0;
            _nguoi_tao = new Guid();
            _ngay_tao = DateTime.MaxValue;
            _nguoi_sua = new Guid();
            _ngay_sua = DateTime.MaxValue;
            _bo_phan_tt = 0;
            _donvi_id1 = 0;
            _SynDate = Null.MIN_DATE;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

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
        public string KyHieu
        {
            get { return _ky_hieu; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieu", value, value.ToString());

                _isChanged |= (_ky_hieu != value); _ky_hieu = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenDonvi
        {
            get { return _ten_donvi; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenDonvi", value, value.ToString());

                _isChanged |= (_ten_donvi != value); _ten_donvi = value;
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
        public string QuanHuyen
        {
            get { return _quan_huyen; }
            set
            {
                if (value != null)
                    if (value.Length > 30)
                        throw new ArgumentOutOfRangeException("Invalid value for QuanHuyen", value, value.ToString());

                _isChanged |= (_quan_huyen != value); _quan_huyen = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TinhTp
        {
            get { return _tinh_tp; }
            set
            {
                if (value != null)
                    if (value.Length > 30)
                        throw new ArgumentOutOfRangeException("Invalid value for TinhTp", value, value.ToString());

                _isChanged |= (_tinh_tp != value); _tinh_tp = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string DienThoai
        {
            get { return _dien_thoai; }
            set
            {
                if (value != null)
                    if (value.Length > 20)
                        throw new ArgumentOutOfRangeException("Invalid value for DienThoai", value, value.ToString());

                _isChanged |= (_dien_thoai != value); _dien_thoai = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Fax
        {
            get { return _fax; }
            set
            {
                if (value != null)
                    if (value.Length > 20)
                        throw new ArgumentOutOfRangeException("Invalid value for Fax", value, value.ToString());

                _isChanged |= (_fax != value); _fax = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Email
        {
            get { return _email; }
            set
            {
                if (value != null)
                    if (value.Length > 30)
                        throw new ArgumentOutOfRangeException("Invalid value for Email", value, value.ToString());

                _isChanged |= (_email != value); _email = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal ChiTiet
        {
            get { return _chi_tiet; }
            set { _isChanged |= (_chi_tiet != value); _chi_tiet = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string SoTaikhoanNh
        {
            get { return _so_taikhoan_nh; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for SoTaikhoanNh", value, value.ToString());

                _isChanged |= (_so_taikhoan_nh != value); _so_taikhoan_nh = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenNganhang
        {
            get { return _ten_nganhang; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenNganhang", value, value.ToString());

                _isChanged |= (_ten_nganhang != value); _ten_nganhang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string DiaChiNh
        {
            get { return _dia_chi_nh; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for DiaChiNh", value, value.ToString());

                _isChanged |= (_dia_chi_nh != value); _dia_chi_nh = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaSoThue
        {
            get { return _ma_so_thue; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for MaSoThue", value, value.ToString());

                _isChanged |= (_ma_so_thue != value); _ma_so_thue = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid DonviIdCha
        {
            get { return _donvi_id_cha; }
            set { _isChanged |= (_donvi_id_cha != value); _donvi_id_cha = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal TyLeGop
        {
            get { return _ty_le_gop; }
            set { _isChanged |= (_ty_le_gop != value); _ty_le_gop = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal TyLeCdts
        {
            get { return _ty_le_cdts; }
            set { _isChanged |= (_ty_le_cdts != value); _ty_le_cdts = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid TienNoite
        {
            get { return _tien_noite; }
            set { _isChanged |= (_tien_noite != value); _tien_noite = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid TienHtPhu
        {
            get { return _tien_ht_phu; }
            set { _isChanged |= (_tien_ht_phu != value); _tien_ht_phu = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string NguoiLapBieu
        {
            get { return _nguoi_lap_bieu; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for NguoiLapBieu", value, value.ToString());

                _isChanged |= (_nguoi_lap_bieu != value); _nguoi_lap_bieu = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string ThuQuy
        {
            get { return _thu_quy; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for ThuQuy", value, value.ToString());

                _isChanged |= (_thu_quy != value); _thu_quy = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string KtTruong
        {
            get { return _kt_truong; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for KtTruong", value, value.ToString());

                _isChanged |= (_kt_truong != value); _kt_truong = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string GiamDoc
        {
            get { return _giam_doc; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for GiamDoc", value, value.ToString());

                _isChanged |= (_giam_doc != value); _giam_doc = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal CheDoKt
        {
            get { return _che_do_kt; }
            set { _isChanged |= (_che_do_kt != value); _che_do_kt = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal HinhThucKt
        {
            get { return _hinh_thuc_kt; }
            set { _isChanged |= (_hinh_thuc_kt != value); _hinh_thuc_kt = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal Cap
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
        public DateTime NgayTao
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
        public DateTime NgaySua
        {
            get { return _ngay_sua; }
            set { _isChanged |= (_ngay_sua != value); _ngay_sua = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal BoPhanTt
        {
            get { return _bo_phan_tt; }
            set { _isChanged |= (_bo_phan_tt != value); _bo_phan_tt = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DonviId1
        {
            get { return _donvi_id1; }
            set { _isChanged |= (_donvi_id1 != value); _donvi_id1 = value; }
        }

        [DataMember]
        public DateTime SynDate
        {
            get { return _SynDate; }
            set { _isChanged |= (_SynDate != value); _SynDate = value; }
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
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            DmDonvi castObj = (DmDonvi)obj;
            return (castObj != null) &&
                (this._donvi_id == castObj.DonviId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _donvi_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}