/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
namespace Vns.Erp.Core.Asset.Domain
{
    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Asset.Domain", IsReference = true)]
    public partial class DmNhomTscd : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _id_nhom_tscd;
        private string _ma_nhom_tscd;
        private string _ten_nhom_tscd;
        private decimal _cho_phep_sua;
        private decimal _co_su_dung;
        private decimal _loai_nhom;
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
        public DmNhomTscd()
        {
            _id_nhom_tscd = new Guid();
            _ma_nhom_tscd = String.Empty;
            _ten_nhom_tscd = String.Empty;
            _cho_phep_sua = 0;
            _co_su_dung = 0;
            _loai_nhom = 0;
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
        public Guid IdNhomTscd
        {
            get { return _id_nhom_tscd; }
            set { _isChanged |= (_id_nhom_tscd != value); _id_nhom_tscd = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaNhomTscd
        {
            get { return _ma_nhom_tscd; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaNhomTscd", value, value.ToString());

                _isChanged |= (_ma_nhom_tscd != value); _ma_nhom_tscd = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenNhomTscd
        {
            get { return _ten_nhom_tscd; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for TenNhomTscd", value, value.ToString());

                _isChanged |= (_ten_nhom_tscd != value); _ten_nhom_tscd = value;
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
        public decimal LoaiNhom
        {
            get { return _loai_nhom; }
            set { _isChanged |= (_loai_nhom != value); _loai_nhom = value; }
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
            DmNhomTscd castObj = (DmNhomTscd)obj;
            return (castObj != null) &&
                (this._id_nhom_tscd == castObj.IdNhomTscd);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _id_nhom_tscd.GetHashCode();
            return hash;
        }
        #endregion

    }
}
