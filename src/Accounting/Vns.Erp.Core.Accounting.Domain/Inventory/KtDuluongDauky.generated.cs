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
    [DataContract(Namespace = "http://Vns.Erp.Core.Accounting", IsReference = true)]
    public partial class KtDuluongDauky : DomainObject<string>, INotifyPropertyChanged
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
        private Guid _ctd_nx_id;
        private DateTime _ngay_tinh;
        private decimal _du_luong;
        private decimal _pp_tinh;
        private decimal _don_gia;
        private decimal _so_tien_ton;
        private Guid _hanghoa_id;
        private Guid _kho_id;
        private DateTime _ngay_ct;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public KtDuluongDauky()
        {
            _donvi_id = new Guid();
            _ctd_nx_id = new Guid();
            _ngay_tinh = DateTime.MaxValue;
            _du_luong = 0;
            _pp_tinh = 0;
            _don_gia = 0;
            _so_tien_ton = 0;
            _hanghoa_id = new Guid();
            _kho_id = new Guid();
            _ngay_ct = DateTime.MaxValue;
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
        public Guid CtdNxId
        {
            get { return _ctd_nx_id; }
            set { _isChanged |= (_ctd_nx_id != value); _ctd_nx_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime NgayTinh
        {
            get { return _ngay_tinh; }
            set { _isChanged |= (_ngay_tinh != value); _ngay_tinh = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DuLuong
        {
            get { return _du_luong; }
            set { _isChanged |= (_du_luong != value); _du_luong = Decimal.Round(value, 2); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal PpTinh
        {
            get { return _pp_tinh; }
            set { _isChanged |= (_pp_tinh != value); _pp_tinh = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal DonGia
        {
            get { return _don_gia; }
            set { _isChanged |= (_don_gia != value); _don_gia = Decimal.Round(value, 0); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public decimal SoTienTon
        {
            get { return _so_tien_ton; }
            set { _isChanged |= (_so_tien_ton != value); _so_tien_ton = Decimal.Round(value, 0); }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid HanghoaId
        {
            get { return _hanghoa_id; }
            set { _isChanged |= (_hanghoa_id != value); _hanghoa_id = value; }
        }


        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public Guid KhoId
        {
            get { return _kho_id; }
            set { _isChanged |= (_kho_id != value); _kho_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>		

        [DataMember]
        public DateTime NgayCt
        {
            get { return _ngay_ct; }
            set { _isChanged |= (_ngay_ct != value); _ngay_ct = value; }
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
            KtDuluongDauky castObj = (KtDuluongDauky)obj;
            return (castObj != null) &&
                (this._donvi_id == castObj.DonviId) &&
                (this._ngay_tinh == castObj.NgayTinh) &&
                (this._hanghoa_id == castObj.HanghoaId) &&
                (this._kho_id == castObj.KhoId);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * _donvi_id.GetHashCode();
            hash = 27 * hash * _ngay_tinh.GetHashCode();
            hash = 27 * hash * _hanghoa_id.GetHashCode();
            hash = 27 * hash * _kho_id.GetHashCode();
            return hash;
        }
        #endregion

    }
}
