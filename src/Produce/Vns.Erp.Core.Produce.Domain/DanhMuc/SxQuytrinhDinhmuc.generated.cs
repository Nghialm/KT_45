using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxQuytrinhDinhmuc : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _QuytrinhId = new Guid();
		private System.Guid _VatlieuDauvaoId = new Guid();
		private System.Guid _VatlieuDauraId = new Guid();
		private string _TenChiphi = String.Empty;
		private System.Guid _DvtId = new Guid();
		private decimal _SoLuong = 0;
		private string _MoTa = String.Empty;
		private int _LoaiChiPhi = 0;
        private int _LoaiQuyTrinh = 0; 
		private decimal _SoTien = 0;
		private decimal _TyLeHaohut = 0;
		private System.Guid _DonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public SxQuytrinhDinhmuc() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_QuytrinhId);
			sb.Append(_VatlieuDauvaoId);
			sb.Append(_VatlieuDauraId);
			sb.Append(_TenChiphi);
			sb.Append(_DvtId);
			sb.Append(_SoLuong);
			sb.Append(_MoTa);
			sb.Append(_LoaiChiPhi);
            sb.Append(_LoaiQuyTrinh);
			sb.Append(_SoTien);
			sb.Append(_TyLeHaohut);
			sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public SxQuytrinhDinhmuc Clone()
        {
            return (SxQuytrinhDinhmuc)this.MemberwiseClone();
        }
		
		public void SetProperty(SxQuytrinhDinhmuc des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_QuytrinhId = des.QuytrinhId;
			_VatlieuDauvaoId = des.VatlieuDauvaoId;
			_VatlieuDauraId = des.VatlieuDauraId;
			_TenChiphi = des.TenChiphi;
			_DvtId = des.DvtId;
			_SoLuong = des.SoLuong;
			_MoTa = des.MoTa;
			_LoaiChiPhi = des.LoaiChiPhi;
			_SoTien = des.SoTien;
			_TyLeHaohut = des.TyLeHaohut;
			_DonviId = des.DonviId;
            _LoaiQuyTrinh = des.LoaiQuyTrinh;
		}

        #endregion

        #region Properties

		public virtual System.Guid QuytrinhId
        {
            get { return _QuytrinhId; }
			set
			{
				OnQuytrinhIdChanging();
				_QuytrinhId = value;
				OnQuytrinhIdChanged();
			}
        }
		partial void OnQuytrinhIdChanging();
		partial void OnQuytrinhIdChanged();
		
		public virtual System.Guid VatlieuDauvaoId
        {
            get { return _VatlieuDauvaoId; }
			set
			{
				OnVatlieuDauvaoIdChanging();
				_VatlieuDauvaoId = value;
				OnVatlieuDauvaoIdChanged();
			}
        }
		partial void OnVatlieuDauvaoIdChanging();
		partial void OnVatlieuDauvaoIdChanged();
		
		public virtual System.Guid VatlieuDauraId
        {
            get { return _VatlieuDauraId; }
			set
			{
				OnVatlieuDauraIdChanging();
				_VatlieuDauraId = value;
				OnVatlieuDauraIdChanged();
			}
        }
		partial void OnVatlieuDauraIdChanging();
		partial void OnVatlieuDauraIdChanged();
		
		public virtual string TenChiphi
        {
            get { return _TenChiphi; }
			set
			{
				OnTenChiphiChanging();
				_TenChiphi = value;
				OnTenChiphiChanged();
			}
        }
		partial void OnTenChiphiChanging();
		partial void OnTenChiphiChanged();
		
		public virtual System.Guid DvtId
        {
            get { return _DvtId; }
			set
			{
				OnDvtIdChanging();
				_DvtId = value;
				OnDvtIdChanged();
			}
        }
		partial void OnDvtIdChanging();
		partial void OnDvtIdChanged();
		
		public virtual decimal SoLuong
        {
            get { return _SoLuong; }
			set
			{
				OnSoLuongChanging();
				_SoLuong = value;
				OnSoLuongChanged();
			}
        }
		partial void OnSoLuongChanging();
		partial void OnSoLuongChanged();
		
		public virtual string MoTa
        {
            get { return _MoTa; }
			set
			{
				OnMoTaChanging();
				_MoTa = value;
				OnMoTaChanged();
			}
        }
		partial void OnMoTaChanging();
		partial void OnMoTaChanged();
		
		public virtual int LoaiChiPhi
        {
            get { return _LoaiChiPhi; }
			set
			{
				OnLoaiChiPhiChanging();
				_LoaiChiPhi = value;
				OnLoaiChiPhiChanged();
			}
        }
        partial void OnLoaiChiPhiChanging();
        partial void OnLoaiChiPhiChanged();
        
        public virtual int LoaiQuyTrinh
        {
            get { return _LoaiQuyTrinh; }
            set
            {
                OnLoaiQuyTrinhChanging();
                _LoaiQuyTrinh = value;
                OnLoaiQuyTrinhChanged();
            }
        }
        partial void OnLoaiQuyTrinhChanging();
        partial void OnLoaiQuyTrinhChanged();

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
		
		public virtual decimal TyLeHaohut
        {
            get { return _TyLeHaohut; }
			set
			{
				OnTyLeHaohutChanging();
				_TyLeHaohut = value;
				OnTyLeHaohutChanged();
			}
        }
		partial void OnTyLeHaohutChanging();
		partial void OnTyLeHaohutChanged();
		
		public virtual System.Guid DonviId
        {
            get { return _DonviId; }
			set
			{
				OnDonviIdChanging();
				_DonviId = value;
				OnDonviIdChanged();
			}
        }
		partial void OnDonviIdChanging();
		partial void OnDonviIdChanged();
		
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
