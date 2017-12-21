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
    public partial class DmLoaitaisan : DomainObject<Guid>, INotifyPropertyChanged
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
        private Guid _loaitaisan_id;
        private string _ma_loaitaisan;
        private string _ky_hieu;
        private string _ten_loaitaisan;
        private decimal _khung_tgsd;
        private Guid _loaitaisan_id_cha;
        private decimal _chi_tiet;
        private decimal _cho_phep_sua;
        private decimal _co_su_dung;
        private decimal _cap;
        private DateTime _SynDate;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public DmLoaitaisan()
        {
            _loaitaisan_id = new Guid();
            _ma_loaitaisan = String.Empty;
            _ky_hieu = String.Empty;
            _ten_loaitaisan = String.Empty;
            _khung_tgsd = 0;
            _loaitaisan_id_cha = new Guid();
            _chi_tiet = 0;
            _cho_phep_sua = 0;
            _co_su_dung = 0;
            _cap = 0;
            _SynDate = Null.MIN_DATE;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid LoaitaisanId
        {
            get { return _loaitaisan_id; }
            set { _isChanged |= (_loaitaisan_id != value); _loaitaisan_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public string MaLoaitaisan
        {
            get { return _ma_loaitaisan; }
            set
            {
                if (value != null)
                    if (value.Length > 32)
                        throw new ArgumentOutOfRangeException("Invalid value for MaLoaitaisan", value, value.ToString());

                _isChanged |= (_ma_loaitaisan != value); _ma_loaitaisan = value;
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
        public string TenLoaitaisan
        {
            get { return _ten_loaitaisan; }
            set
            {
                if (value != null)
                    if (value.Length > 256)
                        throw new ArgumentOutOfRangeException("Invalid value for TenLoaitaisan", value, value.ToString());

                _isChanged |= (_ten_loaitaisan != value); _ten_loaitaisan = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal KhungTgsd
        {
            get { return _khung_tgsd; }
            set { _isChanged |= (_khung_tgsd != value); _khung_tgsd = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid LoaitaisanIdCha
        {
            get { return _loaitaisan_id_cha; }
            set { _isChanged |= (_loaitaisan_id_cha != value); _loaitaisan_id_cha = value; }
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
            DmLoaitaisan castObj = (DmLoaitaisan)obj;
            return (castObj != null) &&
                (this._loaitaisan_id == castObj.LoaitaisanId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _loaitaisan_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
