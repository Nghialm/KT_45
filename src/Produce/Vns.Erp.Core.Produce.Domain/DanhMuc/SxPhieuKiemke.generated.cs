using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxPhieuKiemke : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _LoaiPhieuId = new Guid();
		private string _MaLoaiPhieu = String.Empty;
		private System.Guid _TosanxuatId = new Guid();
		private System.DateTime _NgayKiemKe = Null.MIN_DATE;
		private int _CaKiemKe = 0;
		private string _NguoiLienQuan = String.Empty;
		private string _NguoiKiemKe = String.Empty;
		private string _SoKiemKe = String.Empty;
		private string _MoTa = String.Empty;
		private int _TrangThai = 0;
		private System.Guid _DonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public SxPhieuKiemke() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LoaiPhieuId);
			sb.Append(_MaLoaiPhieu);
			sb.Append(_TosanxuatId);
			sb.Append(_NgayKiemKe);
			sb.Append(_CaKiemKe);
			sb.Append(_NguoiLienQuan);
			sb.Append(_NguoiKiemKe);
			sb.Append(_SoKiemKe);
			sb.Append(_MoTa);
			sb.Append(_TrangThai);
			sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public SxPhieuKiemke Clone()
        {
            return (SxPhieuKiemke)this.MemberwiseClone();
        }
		
		public void SetProperty(SxPhieuKiemke des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LoaiPhieuId = des.LoaiPhieuId;
			_MaLoaiPhieu = des.MaLoaiPhieu;
			_TosanxuatId = des.TosanxuatId;
			_NgayKiemKe = des.NgayKiemKe;
			_CaKiemKe = des.CaKiemKe;
			_NguoiLienQuan = des.NguoiLienQuan;
			_NguoiKiemKe = des.NguoiKiemKe;
			_SoKiemKe = des.SoKiemKe;
			_MoTa = des.MoTa;
			_TrangThai = des.TrangThai;
			_DonviId = des.DonviId;
		}

        #endregion

        #region Properties

		public virtual System.Guid LoaiPhieuId
        {
            get { return _LoaiPhieuId; }
			set
			{
				OnLoaiPhieuIdChanging();
				_LoaiPhieuId = value;
				OnLoaiPhieuIdChanged();
			}
        }
		partial void OnLoaiPhieuIdChanging();
		partial void OnLoaiPhieuIdChanged();
		
		public virtual string MaLoaiPhieu
        {
            get { return _MaLoaiPhieu; }
			set
			{
				OnMaLoaiPhieuChanging();
				_MaLoaiPhieu = value;
				OnMaLoaiPhieuChanged();
			}
        }
		partial void OnMaLoaiPhieuChanging();
		partial void OnMaLoaiPhieuChanged();
		
		public virtual System.Guid TosanxuatId
        {
            get { return _TosanxuatId; }
			set
			{
				OnTosanxuatIdChanging();
				_TosanxuatId = value;
				OnTosanxuatIdChanged();
			}
        }
		partial void OnTosanxuatIdChanging();
		partial void OnTosanxuatIdChanged();
		
		public virtual System.DateTime NgayKiemKe
        {
            get { return _NgayKiemKe; }
			set
			{
				OnNgayKiemKeChanging();
				_NgayKiemKe = value;
				OnNgayKiemKeChanged();
			}
        }
		partial void OnNgayKiemKeChanging();
		partial void OnNgayKiemKeChanged();
		
		public virtual int CaKiemKe
        {
            get { return _CaKiemKe; }
			set
			{
				OnCaKiemKeChanging();
				_CaKiemKe = value;
				OnCaKiemKeChanged();
			}
        }
		partial void OnCaKiemKeChanging();
		partial void OnCaKiemKeChanged();
		
		public virtual string NguoiLienQuan
        {
            get { return _NguoiLienQuan; }
			set
			{
				OnNguoiLienQuanChanging();
				_NguoiLienQuan = value;
				OnNguoiLienQuanChanged();
			}
        }
		partial void OnNguoiLienQuanChanging();
		partial void OnNguoiLienQuanChanged();
		
		public virtual string NguoiKiemKe
        {
            get { return _NguoiKiemKe; }
			set
			{
				OnNguoiKiemKeChanging();
				_NguoiKiemKe = value;
				OnNguoiKiemKeChanged();
			}
        }
		partial void OnNguoiKiemKeChanging();
		partial void OnNguoiKiemKeChanged();
		
		public virtual string SoKiemKe
        {
            get { return _SoKiemKe; }
			set
			{
				OnSoKiemKeChanging();
				_SoKiemKe = value;
				OnSoKiemKeChanged();
			}
        }
		partial void OnSoKiemKeChanging();
		partial void OnSoKiemKeChanged();
		
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
		
		public virtual int TrangThai
        {
            get { return _TrangThai; }
			set
			{
				OnTrangThaiChanging();
				_TrangThai = value;
				OnTrangThaiChanged();
			}
        }
		partial void OnTrangThaiChanging();
		partial void OnTrangThaiChanged();
		
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
