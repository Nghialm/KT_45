using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class BangGiaH : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.DateTime _NgayBangGia = new DateTime();
		private string _MoTa = String.Empty;
        private System.Guid _NguoiLap = new Guid();
		private System.Guid _NguoiTao = new Guid();
		private System.DateTime _NgayTao = new DateTime();
		private System.Guid _NguoiSua = new Guid();
		private System.DateTime _NgaySua = new DateTime();
		private int _TrangThai = 0;
		private System.Guid _DonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public BangGiaH() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_NgayBangGia);
			sb.Append(_MoTa);
			sb.Append(_NguoiLap);
			sb.Append(_NguoiTao);
			sb.Append(_NgayTao);
			sb.Append(_NguoiSua);
			sb.Append(_NgaySua);
			sb.Append(_TrangThai);
			sb.Append(_DonviId);

            return sb.ToString().GetHashCode();
        }
		
		public BangGiaH Clone()
        {
            return (BangGiaH)this.MemberwiseClone();
        }
		
		public void SetProperty(BangGiaH des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_NgayBangGia = des.NgayBangGia;
			_MoTa = des.MoTa;
			_NguoiLap = des.NguoiLap;
			_NguoiTao = des.NguoiTao;
			_NgayTao = des.NgayTao;
			_NguoiSua = des.NguoiSua;
			_NgaySua = des.NgaySua;
			_TrangThai = des.TrangThai;
			_DonviId = des.DonviId;
		}

        #endregion

        #region Properties

		public virtual System.DateTime NgayBangGia
        {
            get { return _NgayBangGia; }
			set
			{
				OnNgayBangGiaChanging();
				_NgayBangGia = value;
				OnNgayBangGiaChanged();
			}
        }
		partial void OnNgayBangGiaChanging();
		partial void OnNgayBangGiaChanged();
		
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
		
		public virtual System.Guid NguoiLap
        {
            get { return _NguoiLap; }
			set
			{
				OnNguoiLapChanging();
				_NguoiLap = value;
				OnNguoiLapChanged();
			}
        }
		partial void OnNguoiLapChanging();
		partial void OnNguoiLapChanged();
		
		public virtual System.Guid NguoiTao
        {
            get { return _NguoiTao; }
			set
			{
				OnNguoiTaoChanging();
				_NguoiTao = value;
				OnNguoiTaoChanged();
			}
        }
		partial void OnNguoiTaoChanging();
		partial void OnNguoiTaoChanged();
		
		public virtual System.DateTime NgayTao
        {
            get { return _NgayTao; }
			set
			{
				OnNgayTaoChanging();
				_NgayTao = value;
				OnNgayTaoChanged();
			}
        }
		partial void OnNgayTaoChanging();
		partial void OnNgayTaoChanged();
		
		public virtual System.Guid NguoiSua
        {
            get { return _NguoiSua; }
			set
			{
				OnNguoiSuaChanging();
				_NguoiSua = value;
				OnNguoiSuaChanged();
			}
        }
		partial void OnNguoiSuaChanging();
		partial void OnNguoiSuaChanged();
		
		public virtual System.DateTime NgaySua
        {
            get { return _NgaySua; }
			set
			{
				OnNgaySuaChanging();
				_NgaySua = value;
				OnNgaySuaChanged();
			}
        }
		partial void OnNgaySuaChanging();
		partial void OnNgaySuaChanged();
		
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
