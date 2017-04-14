using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxPhieuKiemkeSlD : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _KiemkemId = new Guid();
		private System.Guid _LenhSanXuatId = new Guid();
		private System.Guid _SanPhamId = new Guid();
		private int _LoaiKiemKe = 0;
		private string _TenLoaiKiemKe = String.Empty;
		private decimal _SoLuong = 0;
		private System.Guid _DvtId = new Guid();
		private int _DanhGia = 0;
		private string _MoTa = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public SxPhieuKiemkeSlD() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_KiemkemId);
			sb.Append(_LenhSanXuatId);
			sb.Append(_SanPhamId);
			sb.Append(_LoaiKiemKe);
			sb.Append(_TenLoaiKiemKe);
			sb.Append(_SoLuong);
			sb.Append(_DvtId);
			sb.Append(_DanhGia);
			sb.Append(_MoTa);

            return sb.ToString().GetHashCode();
        }
		
		public SxPhieuKiemkeSlD Clone()
        {
            return (SxPhieuKiemkeSlD)this.MemberwiseClone();
        }
		
		public void SetProperty(SxPhieuKiemkeSlD des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_KiemkemId = des.KiemkemId;
			_LenhSanXuatId = des.LenhSanXuatId;
			_SanPhamId = des.SanPhamId;
			_LoaiKiemKe = des.LoaiKiemKe;
			_TenLoaiKiemKe = des.TenLoaiKiemKe;
			_SoLuong = des.SoLuong;
			_DvtId = des.DvtId;
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
		
		public virtual System.Guid SanPhamId
        {
            get { return _SanPhamId; }
			set
			{
				OnSanPhamIdChanging();
				_SanPhamId = value;
				OnSanPhamIdChanged();
			}
        }
		partial void OnSanPhamIdChanging();
		partial void OnSanPhamIdChanged();
		
		public virtual int LoaiKiemKe
        {
            get { return _LoaiKiemKe; }
			set
			{
				OnLoaiKiemKeChanging();
				_LoaiKiemKe = value;
				OnLoaiKiemKeChanged();
			}
        }
		partial void OnLoaiKiemKeChanging();
		partial void OnLoaiKiemKeChanged();
		
		public virtual string TenLoaiKiemKe
        {
            get { return _TenLoaiKiemKe; }
			set
			{
				OnTenLoaiKiemKeChanging();
				_TenLoaiKiemKe = value;
				OnTenLoaiKiemKeChanged();
			}
        }
		partial void OnTenLoaiKiemKeChanging();
		partial void OnTenLoaiKiemKeChanged();
		
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
