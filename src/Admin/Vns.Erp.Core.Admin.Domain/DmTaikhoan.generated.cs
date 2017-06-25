/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
namespace Vns.Erp.Core.Admin.Domain
{
    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Admin", IsReference = true)]
    public partial class DmTaikhoan : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _taikhoan_id;
        private string _ma_taikhoan;
        private string _ten_taikhoan;
        private string _mo_ta;
        private string _tinh_chat;
        private Guid _taikhoan_id_cha;
        private decimal _chi_tiet;
        private Guid _donvi_id;
        private string _ma_donvi;
        private decimal _in_bcd;
        private decimal _tk_nb;
        private decimal _cho_phep_sua;
        private decimal _co_su_dung;
        private decimal _cap;
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
        public DmTaikhoan()
        {
            _taikhoan_id = new Guid();
            _ma_taikhoan = String.Empty;
            _ten_taikhoan = String.Empty;
            _mo_ta = String.Empty;
            _tinh_chat = String.Empty;
            _taikhoan_id_cha = new Guid();
            _chi_tiet = 0;
            _donvi_id = new Guid();
            _ma_donvi = String.Empty;
            _in_bcd = 0;
            _tk_nb = 0;
            _cho_phep_sua = 0;
            _co_su_dung = 0;
            _cap = 0;
            _nguoi_tao = Guid.Empty;
            _ngay_tao = DateTime.MaxValue;
            _nguoi_sua = Guid.Empty;
            _ngay_sua = DateTime.MaxValue;
            _SynDate = Null.MIN_DATE;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid TaikhoanId
        {
            get { return _taikhoan_id; }
            set { _isChanged |= (_taikhoan_id != value); _taikhoan_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaTaikhoan
        {
            get { return _ma_taikhoan; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaTaikhoan", value, value.ToString());

                _isChanged |= (_ma_taikhoan != value); _ma_taikhoan = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string TenTaikhoan
        {
            get { return _ten_taikhoan; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenTaikhoan", value, value.ToString());

                _isChanged |= (_ten_taikhoan != value); _ten_taikhoan = value;
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
        public string TinhChat
        {
            get { return _tinh_chat; }
            set
            {
                if (value != null)
                    if (value.Length > 1)
                        throw new ArgumentOutOfRangeException("Invalid value for TinhChat", value, value.ToString());

                _isChanged |= (_tinh_chat != value); _tinh_chat = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid TaikhoanIdCha
        {
            get { return _taikhoan_id_cha; }
            set { _isChanged |= (_taikhoan_id_cha != value); _taikhoan_id_cha = value; }
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
        public decimal InBcd
        {
            get { return _in_bcd; }
            set { _isChanged |= (_in_bcd != value); _in_bcd = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal TkNb
        {
            get { return _tk_nb; }
            set { _isChanged |= (_tk_nb != value); _tk_nb = value; }
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
            DmTaikhoan castObj = (DmTaikhoan)obj;
            return (castObj != null) &&
                (this._taikhoan_id == castObj.TaikhoanId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _taikhoan_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
