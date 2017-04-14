using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxPhieuKiemkeVtD : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _KiemkemId = new Guid();
		private System.Guid _LenhSanXuatId = new Guid();
		private System.Guid _VatTuId = new Guid();
		private int _LoaiChiPhi = 0;
		private string _TenChiPhi = String.Empty;
		private decimal _SoLuong = 0;
		private System.Guid _DvtId = new Guid();
		private decimal _TyleHaohut = 0;
		private int _DanhGia = 0;
		private string _MoTa = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public SxPhieuKiemkeVtD() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_KiemkemId);
			sb.Append(_LenhSanXuatId);
			sb.Append(_VatTuId);
			sb.Append(_LoaiChiPhi);
			sb.Append(_TenChiPhi);
			sb.Append(_SoLuong);
			sb.Append(_DvtId);
			sb.Append(_TyleHaohut);
			sb.Append(_DanhGia);
			sb.Append(_MoTa);

            return sb.ToString().GetHashCode();
        }
		
		public SxPhieuKiemkeVtD Clone()
        {
            return (SxPhieuKiemkeVtD)this.MemberwiseClone();
        }
		
		public void SetProperty(SxPhieuKiemkeVtD des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_KiemkemId = des.KiemkemId;
			_LenhSanXuatId = des.LenhSanXuatId;
			_VatTuId = des.VatTuId;
			_LoaiChiPhi = des.LoaiChiPhi;
			_TenChiPhi = des.TenChiPhi;
			_SoLuong = des.SoLuong;
			_DvtId = des.DvtId;
			_TyleHaohut = des.TyleHaohut;
			_DanhGia = des.DanhGia;
			_MoTa = des.MoTa;
		}

        #endregion

        #region Properties

		public virtual System.Guid KiemkemId
        {
            get { return _KiemkemId; }
			set
			{
				OnKiemkemIdChanging();
				_KiemkemId = value;
				OnKiemkemIdChanged();
			}
        }
		partial void OnKiemkemIdChanging();
		partial void OnKiemkemIdChanged();
		
		public virtual System.Guid LenhSanXuatId
        {
            get { return _LenhSanXuatId; }
			set
			{
				OnLenhSanXuatIdChanging();
				_LenhSanXuatId = value;
				OnLenhSanXuatIdChanged();
			}
        }
		partial void OnLenhSanXuatIdChanging();
		partial void OnLenhSanXuatIdChanged();
		
		public virtual System.Guid VatTuId
        {
            get { return _VatTuId; }
			set
			{
				OnVatTuIdChanging();
				_VatTuId = value;
				OnVatTuIdChanged();
			}
        }
		partial void OnVatTuIdChanging();
		partial void OnVatTuIdChanged();
		
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
		
		public virtual int DanhGia
        {
            get { return _DanhGia; }
			set
			{
				OnDanhGiaChanging();
				_DanhGia = value;
				OnDanhGiaChanged();
			}
        }
		partial void OnDanhGiaChanging();
		partial void OnDanhGiaChanged();
		
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
