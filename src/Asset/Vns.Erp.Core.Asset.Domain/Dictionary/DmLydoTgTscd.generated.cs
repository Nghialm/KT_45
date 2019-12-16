/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
namespace Vns.Erp.Core.Asset.Domain
{
    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo And Modified By Hoang Quoc Dung
    /// </summary>


    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Asset.Domain", IsReference = true)]
    public partial class DmLydoTgTscd : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _lydo_tg_tscd_id;
        private string _ma_lydo_tg_tscd;
        private string _ky_hieu;
        private string _ten_lydo_tg_tscd;
        private decimal _loai_lg;
        private decimal _gia_tri;
        private Guid _donvi_id;
        private string _ma_donvi;
        private decimal _cho_phep_sua;
        private decimal _co_su_dung;
        private DateTime _SynDate;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public DmLydoTgTscd()
        {
            _lydo_tg_tscd_id = new Guid();
            _ma_lydo_tg_tscd = String.Empty;
            _ky_hieu = String.Empty;
            _ten_lydo_tg_tscd = String.Empty;
            _loai_lg = 0;
            _gia_tri = 0;
            _donvi_id = new Guid();
            _ma_donvi = String.Empty;
            _cho_phep_sua = 0;
            _co_su_dung = 0;
            _SynDate = Null.MIN_DATE;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid LydoTgTscdId
        {
            get { return _lydo_tg_tscd_id; }
            set { _isChanged |= (_lydo_tg_tscd_id != value); _lydo_tg_tscd_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaLydoTgTscd
        {
            get { return _ma_lydo_tg_tscd; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaLydoTgTscd", value, value.ToString());

                _isChanged |= (_ma_lydo_tg_tscd != value); _ma_lydo_tg_tscd = value;
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
        public string TenLydoTgTscd
        {
            get { return _ten_lydo_tg_tscd; }
            set
            {
                if (value != null)
                    if (value.Length > 128)
                        throw new ArgumentOutOfRangeException("Invalid value for TenLydoTgTscd", value, value.ToString());

                _isChanged |= (_ten_lydo_tg_tscd != value); _ten_lydo_tg_tscd = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal LoaiLg
        {
            get { return _loai_lg; }
            set { _isChanged |= (_loai_lg != value); _loai_lg = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal GiaTri
        {
            get { return _gia_tri; }
            set { _isChanged |= (_gia_tri != value); _gia_tri = value; }
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
            DmLydoTgTscd castObj = (DmLydoTgTscd)obj;
            return (castObj != null) &&
                (this._lydo_tg_tscd_id == castObj.LydoTgTscdId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _lydo_tg_tscd_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
