using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Asset.Domain", IsReference = true)]
    public partial class TsCtTscdNvon : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _CtTscdId = new Guid();
		private System.Guid _DmNguonTscdId = new Guid();
		private decimal _SoTien = default(Decimal);
		private decimal _SoTienNte = default(Decimal);
		private decimal _NguyenGia = default(Decimal);
		private decimal _GiaTriConLai = default(Decimal);
		private decimal _HaoMonLuyKe = default(Decimal);
		private decimal _TyLeHaoMon = default(Decimal);
		private System.Guid _LyDoTanggiam = new Guid();
		private string _TenLyDoTanggiam = String.Empty;
		private string _DienGiai = String.Empty;
		private decimal _TangTscd = default(Decimal);
		private decimal _HeSoPbKh = default(Decimal);
		private System.Guid _TkTaisan = new Guid();
		private System.Guid _TkChiphi = new Guid();
		private string _MaTkTaisan = String.Empty;
		private string _MaTkChiphi = String.Empty;
		private System.Guid _TkKhauhao = new Guid();
		private string _MaTkKhauhao = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public TsCtTscdNvon() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_CtTscdId);
			sb.Append(_DmNguonTscdId);
			sb.Append(_SoTien);
			sb.Append(_SoTienNte);
			sb.Append(_NguyenGia);
			sb.Append(_GiaTriConLai);
			sb.Append(_HaoMonLuyKe);
			sb.Append(_TyLeHaoMon);
			sb.Append(_LyDoTanggiam);
			sb.Append(_TenLyDoTanggiam);
			sb.Append(_DienGiai);
			sb.Append(_TangTscd);
			sb.Append(_HeSoPbKh);
			sb.Append(_TkTaisan);
			sb.Append(_TkChiphi);
			sb.Append(_MaTkTaisan);
			sb.Append(_MaTkChiphi);
			sb.Append(_TkKhauhao);
			sb.Append(_MaTkKhauhao);

            return sb.ToString().GetHashCode();
        }
		
		public TsCtTscdNvon Clone()
        {
            return (TsCtTscdNvon)this.MemberwiseClone();
        }
		
		public void SetProperty(TsCtTscdNvon des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_CtTscdId = des.CtTscdId;
			_DmNguonTscdId = des.DmNguonTscdId;
			_SoTien = des.SoTien;
			_SoTienNte = des.SoTienNte;
			_NguyenGia = des.NguyenGia;
			_GiaTriConLai = des.GiaTriConLai;
			_HaoMonLuyKe = des.HaoMonLuyKe;
			_TyLeHaoMon = des.TyLeHaoMon;
			_LyDoTanggiam = des.LyDoTanggiam;
			_TenLyDoTanggiam = des.TenLyDoTanggiam;
			_DienGiai = des.DienGiai;
			_TangTscd = des.TangTscd;
			_HeSoPbKh = des.HeSoPbKh;
			_TkTaisan = des.TkTaisan;
			_TkChiphi = des.TkChiphi;
			_MaTkTaisan = des.MaTkTaisan;
			_MaTkChiphi = des.MaTkChiphi;
			_TkKhauhao = des.TkKhauhao;
			_MaTkKhauhao = des.MaTkKhauhao;
		}

        #endregion

        #region Properties

        [DataMember]
		public virtual System.Guid CtTscdId
        {
            get { return _CtTscdId; }
			set
			{
				OnCtTscdIdChanging();
				_CtTscdId = value;
				OnCtTscdIdChanged();
			}
        }
		partial void OnCtTscdIdChanging();
		partial void OnCtTscdIdChanged();
		
        [DataMember]
		public virtual System.Guid DmNguonTscdId
        {
            get { return _DmNguonTscdId; }
			set
			{
				OnDmNguonTscdIdChanging();
				_DmNguonTscdId = value;
				OnDmNguonTscdIdChanged();
			}
        }
		partial void OnDmNguonTscdIdChanging();
		partial void OnDmNguonTscdIdChanged();
		
        [DataMember]
		public virtual decimal SoTien
        {
            get { return _SoTien; }
			set
			{
				OnSoTienChanging();
				_SoTien = value;
				OnSoTienChanged();
			}
        }
		partial void OnSoTienChanging();
		partial void OnSoTienChanged();
		
        [DataMember]
		public virtual decimal SoTienNte
        {
            get { return _SoTienNte; }
			set
			{
				OnSoTienNteChanging();
				_SoTienNte = value;
				OnSoTienNteChanged();
			}
        }
		partial void OnSoTienNteChanging();
		partial void OnSoTienNteChanged();
		
        [DataMember]
		public virtual decimal NguyenGia
        {
            get { return _NguyenGia; }
			set
			{
				OnNguyenGiaChanging();
				_NguyenGia = value;
				OnNguyenGiaChanged();
			}
        }
		partial void OnNguyenGiaChanging();
		partial void OnNguyenGiaChanged();
		
        [DataMember]
		public virtual decimal GiaTriConLai
        {
            get { return _GiaTriConLai; }
			set
			{
				OnGiaTriConLaiChanging();
				_GiaTriConLai = value;
				OnGiaTriConLaiChanged();
			}
        }
		partial void OnGiaTriConLaiChanging();
		partial void OnGiaTriConLaiChanged();
		
        [DataMember]
		public virtual decimal HaoMonLuyKe
        {
            get { return _HaoMonLuyKe; }
			set
			{
				OnHaoMonLuyKeChanging();
				_HaoMonLuyKe = value;
				OnHaoMonLuyKeChanged();
			}
        }
		partial void OnHaoMonLuyKeChanging();
		partial void OnHaoMonLuyKeChanged();
		
        [DataMember]
		public virtual decimal TyLeHaoMon
        {
            get { return _TyLeHaoMon; }
			set
			{
				OnTyLeHaoMonChanging();
				_TyLeHaoMon = value;
				OnTyLeHaoMonChanged();
			}
        }
		partial void OnTyLeHaoMonChanging();
		partial void OnTyLeHaoMonChanged();
		
        [DataMember]
		public virtual System.Guid LyDoTanggiam
        {
            get { return _LyDoTanggiam; }
			set
			{
				OnLyDoTanggiamChanging();
				_LyDoTanggiam = value;
				OnLyDoTanggiamChanged();
			}
        }
		partial void OnLyDoTanggiamChanging();
		partial void OnLyDoTanggiamChanged();
		
        [DataMember]
		public virtual string TenLyDoTanggiam
        {
            get { return _TenLyDoTanggiam; }
			set
			{
				OnTenLyDoTanggiamChanging();
				_TenLyDoTanggiam = value;
				OnTenLyDoTanggiamChanged();
			}
        }
		partial void OnTenLyDoTanggiamChanging();
		partial void OnTenLyDoTanggiamChanged();
		
        [DataMember]
		public virtual string DienGiai
        {
            get { return _DienGiai; }
			set
			{
				OnDienGiaiChanging();
				_DienGiai = value;
				OnDienGiaiChanged();
			}
        }
		partial void OnDienGiaiChanging();
		partial void OnDienGiaiChanged();
		
        [DataMember]
		public virtual decimal TangTscd
        {
            get { return _TangTscd; }
			set
			{
				OnTangTscdChanging();
				_TangTscd = value;
				OnTangTscdChanged();
			}
        }
		partial void OnTangTscdChanging();
		partial void OnTangTscdChanged();
		
        [DataMember]
		public virtual decimal HeSoPbKh
        {
            get { return _HeSoPbKh; }
			set
			{
				OnHeSoPbKhChanging();
				_HeSoPbKh = value;
				OnHeSoPbKhChanged();
			}
        }
		partial void OnHeSoPbKhChanging();
		partial void OnHeSoPbKhChanged();
		
        [DataMember]
		public virtual System.Guid TkTaisan
        {
            get { return _TkTaisan; }
			set
			{
				OnTkTaisanChanging();
				_TkTaisan = value;
				OnTkTaisanChanged();
			}
        }
		partial void OnTkTaisanChanging();
		partial void OnTkTaisanChanged();
		
        [DataMember]
		public virtual System.Guid TkChiphi
        {
            get { return _TkChiphi; }
			set
			{
				OnTkChiphiChanging();
				_TkChiphi = value;
				OnTkChiphiChanged();
			}
        }
		partial void OnTkChiphiChanging();
		partial void OnTkChiphiChanged();
		
        [DataMember]
		public virtual string MaTkTaisan
        {
            get { return _MaTkTaisan; }
			set
			{
				OnMaTkTaisanChanging();
				_MaTkTaisan = value;
				OnMaTkTaisanChanged();
			}
        }
		partial void OnMaTkTaisanChanging();
		partial void OnMaTkTaisanChanged();
		
        [DataMember]
		public virtual string MaTkChiphi
        {
            get { return _MaTkChiphi; }
			set
			{
				OnMaTkChiphiChanging();
				_MaTkChiphi = value;
				OnMaTkChiphiChanged();
			}
        }
		partial void OnMaTkChiphiChanging();
		partial void OnMaTkChiphiChanged();
		
        [DataMember]
		public virtual System.Guid TkKhauhao
        {
            get { return _TkKhauhao; }
			set
			{
				OnTkKhauhaoChanging();
				_TkKhauhao = value;
				OnTkKhauhaoChanged();
			}
        }
		partial void OnTkKhauhaoChanging();
		partial void OnTkKhauhaoChanged();
		
        [DataMember]
		public virtual string MaTkKhauhao
        {
            get { return _MaTkKhauhao; }
			set
			{
				OnMaTkKhauhaoChanging();
				_MaTkKhauhao = value;
				OnMaTkKhauhaoChanged();
			}
        }
		partial void OnMaTkKhauhaoChanging();
		partial void OnMaTkKhauhaoChanged();
		
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
