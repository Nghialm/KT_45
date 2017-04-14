using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxKehoachD : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _KehoachMId = new Guid();
		private System.Guid _VatlieuDauvaoId = new Guid();
		private System.Guid _VatlieuDauraId = new Guid();
		private string _TenChiPhi = String.Empty;
		private decimal _SoLuong = 0;
		private System.Guid _DvtId = new Guid();
		private int _LoaiChiPhi = 0;
		private decimal _TyleHaohut = 0;
		private string _MoTa = String.Empty;
        private int _LoaiKeHoach = 0;
        private decimal _DonGia = 0;
        private decimal _SoTien = 0;
        
		
		
        #endregion

        #region Constructors

        public SxKehoachD() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_KehoachMId);
			sb.Append(_VatlieuDauvaoId);
			sb.Append(_VatlieuDauraId);
			sb.Append(_TenChiPhi);
			sb.Append(_SoLuong);
			sb.Append(_DvtId);
			sb.Append(_LoaiChiPhi);
			sb.Append(_TyleHaohut);
			sb.Append(_MoTa);
            sb.Append(_LoaiKeHoach);

            return sb.ToString().GetHashCode();
        }
		
		public SxKehoachD Clone()
        {
            return (SxKehoachD)this.MemberwiseClone();
        }
		
		public void SetProperty(SxKehoachD des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_KehoachMId = des.KehoachMId;
			_VatlieuDauvaoId = des.VatlieuDauvaoId;
			_VatlieuDauraId = des.VatlieuDauraId;
			_TenChiPhi = des.TenChiPhi;
			_SoLuong = des.SoLuong;
			_DvtId = des.DvtId;
			_LoaiChiPhi = des.LoaiChiPhi;
			_TyleHaohut = des.TyleHaohut;
			_MoTa = des.MoTa;
            _LoaiKeHoach = des.LoaiKeHoach;
		}

        #endregion

        #region Properties

		public virtual System.Guid KehoachMId
        {
            get { return _KehoachMId; }
			set
			{
				OnKehoachMIdChanging();
				_KehoachMId = value;
				OnKehoachMIdChanged();
			}
        }
		partial void OnKehoachMIdChanging();
		partial void OnKehoachMIdChanged();
		
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
		
		public virtual string TenChiPhi
        {
            get { return _TenChiPhi; }
			set
			{
				OnTenChiPhiChanging();
				_TenChiPhi = value;
				OnTenChiPhiChanged();
			}
        }
		partial void OnTenChiPhiChanging();
		partial void OnTenChiPhiChanged();
		
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

        public virtual int LoaiKeHoach
        {
            get { return _LoaiKeHoach; }
			set
			{
                OnLoaiKeHoachChanging();
                _LoaiKeHoach = value;
                OnLoaiKeHoachChanged();
			}
        }
        partial void OnLoaiKeHoachChanging();
        partial void OnLoaiKeHoachChanged();
		
		public virtual decimal TyleHaohut
        {
            get { return _TyleHaohut; }
			set
			{
				OnTyleHaohutChanging();
				_TyleHaohut = value;
				OnTyleHaohutChanged();
			}
        }
		partial void OnTyleHaohutChanging();
		partial void OnTyleHaohutChanged();
		
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

        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        public decimal SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
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
