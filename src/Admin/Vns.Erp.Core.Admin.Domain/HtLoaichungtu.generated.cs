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
    public partial class HtLoaichungtu : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _loai_ct_id;
        private string _ma_loai_ct;
        private string _ky_hieu;
        private string _ten_loai_ct;
        private string _mo_ta;
        private string _ma_tk_no_lq;
        private string _ma_tk_co_lq;
        private Guid _loai_ct_id_cha;
        private decimal _cap;
        private decimal _chi_tiet;
        private string _duong_dan;
        private string _mau_so_ct;
        private string _mau_bao_cao;
        private decimal _cho_phep_sua;
        private decimal _co_su_dung;
        private decimal _sd_tk_thue_ngamdinh;
        private string _tk_thue_ngamdinh;
        private decimal _dm_ptqt;
        private decimal _dm_phongban;
        private decimal _dm_tudo1;
        private decimal _dm_tudo2;
        private decimal _dm_tudo3;
        private decimal _dm_tudo4;
        private decimal _dm_tudo5;
        private decimal _dm_vuviec;
        private decimal _kho_xuat;
        private decimal _phieu_xuat;
        private Guid _nguoi_tao;
        private DateTime _ngay_tao;
        private Guid _nguoi_sua;
        private DateTime _ngay_sua;
        private decimal _so_ct_hienthi;
        private decimal _dm_khoanphi;
        private decimal _dm_hopdong;
        private decimal _dm_khang;
        private decimal _dm_cbnv;
        private string _mota_01;
        private string _mota_02;
        private string _mota_03;
        private string _mota_04;
        private string _mota_05;
        private string _prefix_ct;
        private decimal _dm_hoadon;
        private Guid _DonviId = new Guid();
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public HtLoaichungtu()
        {
            _loai_ct_id = new Guid();
            _ma_loai_ct = String.Empty;
            _ky_hieu = String.Empty;
            _ten_loai_ct = String.Empty;
            _mo_ta = String.Empty;
            _ma_tk_no_lq = String.Empty;
            _ma_tk_co_lq = String.Empty;
            _loai_ct_id_cha = new Guid();
            _cap = 0;
            _chi_tiet = 0;
            _duong_dan = String.Empty;
            _mau_so_ct = String.Empty;
            _mau_bao_cao = String.Empty;
            _cho_phep_sua = 0;
            _co_su_dung = 0;
            _sd_tk_thue_ngamdinh = 0;
            _tk_thue_ngamdinh = String.Empty;
            _dm_ptqt = 0;
            _dm_phongban = 0;
            _dm_tudo1 = 0;
            _dm_tudo2 = 0;
            _dm_tudo3 = 0;
            _dm_tudo4 = 0;
            _dm_tudo5 = 0;
            _dm_vuviec = 0;
            _kho_xuat = 0;
            _phieu_xuat = 0;
            _nguoi_tao = Guid.Empty;
            _ngay_tao = DateTime.MaxValue;
            _nguoi_sua = Guid.Empty;
            _ngay_sua = DateTime.MaxValue;
            _so_ct_hienthi = 0;
            _dm_khoanphi = 0;
            _dm_hopdong = 0;
            _dm_khang = 0;
            _dm_cbnv = 0;
            _mota_01 = String.Empty;
            _mota_02 = String.Empty;
            _mota_03 = String.Empty;
            _mota_04 = String.Empty;
            _mota_05 = String.Empty;
            _prefix_ct = String.Empty;
            _dm_hoadon = 0;
            _DonviId = new Guid();
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid LoaiCtId
        {
            get { return _loai_ct_id; }
            set { _isChanged |= (_loai_ct_id != value); _loai_ct_id = value; }
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
        public string KyHieu
        {
            get { return _ky_hieu; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for KyHieu", value, value.ToString());

                _isChanged |= (_ky_hieu != value); _ky_hieu = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenLoaiCt
        {
            get { return _ten_loai_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenLoaiCt", value, value.ToString());

                _isChanged |= (_ten_loai_ct != value); _ten_loai_ct = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MoTa
        {
            get { return _mo_ta; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for MoTa", value, value.ToString());

                _isChanged |= (_mo_ta != value); _mo_ta = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaTkNoLq
        {
            get { return _ma_tk_no_lq; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for MaTkNoLq", value, value.ToString());

                _isChanged |= (_ma_tk_no_lq != value); _ma_tk_no_lq = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaTkCoLq
        {
            get { return _ma_tk_co_lq; }
            set
            {
                if (value != null)
                    if (value.Length > 64)
                        throw new ArgumentOutOfRangeException("Invalid value for MaTkCoLq", value, value.ToString());

                _isChanged |= (_ma_tk_co_lq != value); _ma_tk_co_lq = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid LoaiCtIdCha
        {
            get { return _loai_ct_id_cha; }
            set { _isChanged |= (_loai_ct_id_cha != value); _loai_ct_id_cha = value; }
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
        public decimal ChiTiet
        {
            get { return _chi_tiet; }
            set { _isChanged |= (_chi_tiet != value); _chi_tiet = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string DuongDan
        {
            get { return _duong_dan; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for DuongDan", value, value.ToString());

                _isChanged |= (_duong_dan != value); _duong_dan = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MauSoCt
        {
            get { return _mau_so_ct; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MauSoCt", value, value.ToString());

                _isChanged |= (_mau_so_ct != value); _mau_so_ct = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MauBaoCao
        {
            get { return _mau_bao_cao; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for MauBaoCao", value, value.ToString());

                _isChanged |= (_mau_bao_cao != value); _mau_bao_cao = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal ChoPhepSua
        {
            get { return _cho_phep_sua; }
            set { _isChanged |= (_cho_phep_sua != value); _cho_phep_sua = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal CoSuDung
        {
            get { return _co_su_dung; }
            set { _isChanged |= (_co_su_dung != value); _co_su_dung = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal SdTkThueNgamdinh
        {
            get { return _sd_tk_thue_ngamdinh; }
            set { _isChanged |= (_sd_tk_thue_ngamdinh != value); _sd_tk_thue_ngamdinh = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TkThueNgamdinh
        {
            get { return _tk_thue_ngamdinh; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for TkThueNgamdinh", value, value.ToString());

                _isChanged |= (_tk_thue_ngamdinh != value); _tk_thue_ngamdinh = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmPtqt
        {
            get { return _dm_ptqt; }
            set { _isChanged |= (_dm_ptqt != value); _dm_ptqt = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmPhongban
        {
            get { return _dm_phongban; }
            set { _isChanged |= (_dm_phongban != value); _dm_phongban = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmTudo1
        {
            get { return _dm_tudo1; }
            set { _isChanged |= (_dm_tudo1 != value); _dm_tudo1 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmTudo2
        {
            get { return _dm_tudo2; }
            set { _isChanged |= (_dm_tudo2 != value); _dm_tudo2 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmTudo3
        {
            get { return _dm_tudo3; }
            set { _isChanged |= (_dm_tudo3 != value); _dm_tudo3 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmTudo4
        {
            get { return _dm_tudo4; }
            set { _isChanged |= (_dm_tudo4 != value); _dm_tudo4 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmTudo5
        {
            get { return _dm_tudo5; }
            set { _isChanged |= (_dm_tudo5 != value); _dm_tudo5 = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmVuviec
        {
            get { return _dm_vuviec; }
            set { _isChanged |= (_dm_vuviec != value); _dm_vuviec = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal KhoXuat
        {
            get { return _kho_xuat; }
            set { _isChanged |= (_kho_xuat != value); _kho_xuat = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal PhieuXuat
        {
            get { return _phieu_xuat; }
            set { _isChanged |= (_phieu_xuat != value); _phieu_xuat = value; }
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
        public decimal SoCtHienthi
        {
            get { return _so_ct_hienthi; }
            set { _isChanged |= (_so_ct_hienthi != value); _so_ct_hienthi = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmKhoanphi
        {
            get { return _dm_khoanphi; }
            set { _isChanged |= (_dm_khoanphi != value); _dm_khoanphi = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmHopdong
        {
            get { return _dm_hopdong; }
            set { _isChanged |= (_dm_hopdong != value); _dm_hopdong = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmKhang
        {
            get { return _dm_khang; }
            set { _isChanged |= (_dm_khang != value); _dm_khang = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmCbnv
        {
            get { return _dm_cbnv; }
            set { _isChanged |= (_dm_cbnv != value); _dm_cbnv = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Mota01
        {
            get { return _mota_01; }
            set
            {
                if (value != null)
                    if (value.Length > 1000)
                        throw new ArgumentOutOfRangeException("Invalid value for Mota01", value, value.ToString());

                _isChanged |= (_mota_01 != value); _mota_01 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Mota02
        {
            get { return _mota_02; }
            set
            {
                if (value != null)
                    if (value.Length > 1000)
                        throw new ArgumentOutOfRangeException("Invalid value for Mota02", value, value.ToString());

                _isChanged |= (_mota_02 != value); _mota_02 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Mota03
        {
            get { return _mota_03; }
            set
            {
                if (value != null)
                    if (value.Length > 1000)
                        throw new ArgumentOutOfRangeException("Invalid value for Mota03", value, value.ToString());

                _isChanged |= (_mota_03 != value); _mota_03 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Mota04
        {
            get { return _mota_04; }
            set
            {
                if (value != null)
                    if (value.Length > 1000)
                        throw new ArgumentOutOfRangeException("Invalid value for Mota04", value, value.ToString());

                _isChanged |= (_mota_04 != value); _mota_04 = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string Mota05
        {
            get { return _mota_05; }
            set
            {
                if (value != null)
                    if (value.Length > 1000)
                        throw new ArgumentOutOfRangeException("Invalid value for Mota05", value, value.ToString());

                _isChanged |= (_mota_05 != value); _mota_05 = value;
            }
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
        /// 
        /// </summary>		

        [DataMember]
        public decimal DmHoadon
        {
            get { return _dm_hoadon; }
            set { _isChanged |= (_dm_hoadon != value); _dm_hoadon = value; }
        }

        [DataMember]
        public Guid DonviId
        {
            get { return _DonviId; }
            set { _isChanged |= (_DonviId != value); _DonviId = value; }
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
            HtLoaichungtu castObj = (HtLoaichungtu)obj;
            return (castObj != null) &&
                (this._loai_ct_id == castObj.LoaiCtId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _loai_ct_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
