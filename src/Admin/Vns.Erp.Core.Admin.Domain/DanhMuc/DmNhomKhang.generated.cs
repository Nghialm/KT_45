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
    public partial class DmNhomKhang : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _dm_nhom_khang_id;
        private string _ma_nhom_khang;
        private string _ky_hieu;
        private string _ten_nhom_khang;
        private decimal _loai;
        private Guid _donvi_id;
        private string _ma_donvi;
        private Guid _nguoi_tao;
        private DateTime _ngay_tao;
        private Guid _nguoi_sua;
        private DateTime _ngay_sua;
        private DateTime _SynDate;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public DmNhomKhang()
        {
            _dm_nhom_khang_id = new Guid();
            _ma_nhom_khang = String.Empty;
            _ky_hieu = String.Empty;
            _ten_nhom_khang = String.Empty;
            _loai = 0;
            _donvi_id = new Guid();
            _ma_donvi = String.Empty;
            _nguoi_tao = new Guid();
            _ngay_tao = DateTime.MaxValue;
            _nguoi_sua = new Guid();
            _ngay_sua = DateTime.MaxValue;
            _SynDate = Null.MIN_DATE;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid DmNhomKhangId
        {
            get { return _dm_nhom_khang_id; }
            set { _isChanged |= (_dm_nhom_khang_id != value); _dm_nhom_khang_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaNhomKhang
        {
            get { return _ma_nhom_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaNhomKhang", value, value.ToString());

                _isChanged |= (_ma_nhom_khang != value); _ma_nhom_khang = value;
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
        public string TenNhomKhang
        {
            get { return _ten_nhom_khang; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenNhomKhang", value, value.ToString());

                _isChanged |= (_ten_nhom_khang != value); _ten_nhom_khang = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal Loai
        {
            get { return _loai; }
            set { _isChanged |= (_loai != value); _loai = value; }
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
            DmNhomKhang castObj = (DmNhomKhang)obj;
            return (castObj != null) &&
                (this._dm_nhom_khang_id == castObj.DmNhomKhangId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _dm_nhom_khang_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}