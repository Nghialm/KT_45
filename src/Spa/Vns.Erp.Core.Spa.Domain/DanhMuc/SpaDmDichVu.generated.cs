using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class SpaDmDichVu : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations


        private string _Ma = string.Empty;
        private string _Kyhieu = string.Empty;
        private string _Ten = string.Empty;
        private string _Ten2 = string.Empty;
        private string _MoTa = string.Empty;
		private decimal _DonGia = 0;
		private bool _CoSuDung = default(Boolean);
		private System.DateTime _NgayTao = new DateTime();
        private Guid _NguoiTao = new Guid();
		private System.Guid _DonviId = new Guid();
		private System.Guid _DichvuIdCha = new Guid();
		private bool _ChiTiet = default(Boolean);
		private int _Cap = 0;
		
		
		
        #endregion

        #region Constructors

        public SpaDmDichVu() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_Kyhieu);
			sb.Append(_Ten);
			sb.Append(_Ten2);
			sb.Append(_MoTa);
			sb.Append(_DonGia);
			sb.Append(_CoSuDung);
			sb.Append(_NgayTao);
			sb.Append(_NguoiTao);
			sb.Append(_DonviId);
			sb.Append(_DichvuIdCha);
			sb.Append(_ChiTiet);
			sb.Append(_Cap);

            return sb.ToString().GetHashCode();
        }
		
		public SpaDmDichVu Clone()
        {
            return (SpaDmDichVu)this.MemberwiseClone();
        }
		
		public void SetProperty(SpaDmDichVu des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_Kyhieu = des.Kyhieu;
			_Ten = des.Ten;
			_Ten2 = des.Ten2;
			_MoTa = des.MoTa;
			_DonGia = des.DonGia;
			_CoSuDung = des.CoSuDung;
			_NgayTao = des.NgayTao;
			_NguoiTao = des.NguoiTao;
			_DonviId = des.DonviId;
			_DichvuIdCha = des.DichvuIdCha;
			_ChiTiet = des.ChiTiet;
			_Cap = des.Cap;
		}

        #endregion

        #region Properties

		public virtual string Ma
        {
            get { return _Ma; }
			set
			{
				OnMaChanging();
				_Ma = value;
				OnMaChanged();
			}
        }
		partial void OnMaChanging();
		partial void OnMaChanged();
		
		public virtual string Kyhieu
        {
            get { return _Kyhieu; }
			set
			{
				OnKyhieuChanging();
				_Kyhieu = value;
				OnKyhieuChanged();
			}
        }
		partial void OnKyhieuChanging();
		partial void OnKyhieuChanged();
		
		public virtual string Ten
        {
            get { return _Ten; }
			set
			{
				OnTenChanging();
				_Ten = value;
				OnTenChanged();
			}
        }
		partial void OnTenChanging();
		partial void OnTenChanged();
		
		public virtual string Ten2
        {
            get { return _Ten2; }
			set
			{
				OnTen2Changing();
				_Ten2 = value;
				OnTen2Changed();
			}
        }
		partial void OnTen2Changing();
		partial void OnTen2Changed();
		
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
		
		public virtual decimal DonGia
        {
            get { return _DonGia; }
			set
			{
				OnDonGiaChanging();
				_DonGia = value;
				OnDonGiaChanged();
			}
        }
		partial void OnDonGiaChanging();
		partial void OnDonGiaChanged();
		
		public virtual bool CoSuDung
        {
            get { return _CoSuDung; }
			set
			{
				OnCoSuDungChanging();
				_CoSuDung = value;
				OnCoSuDungChanged();
			}
        }
		partial void OnCoSuDungChanging();
		partial void OnCoSuDungChanged();
		
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
		
		public virtual Guid NguoiTao
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
		
		public virtual System.Guid DichvuIdCha
        {
            get { return _DichvuIdCha; }
			set
			{
				OnDichvuIdChaChanging();
				_DichvuIdCha = value;
				OnDichvuIdChaChanged();
			}
        }
		partial void OnDichvuIdChaChanging();
		partial void OnDichvuIdChaChanged();
		
		public virtual bool ChiTiet
        {
            get { return _ChiTiet; }
			set
			{
				OnChiTietChanging();
				_ChiTiet = value;
				OnChiTietChanged();
			}
        }
		partial void OnChiTietChanging();
		partial void OnChiTietChanged();
		
		public virtual int Cap
        {
            get { return _Cap; }
			set
			{
				OnCapChanging();
				_Cap = value;
				OnCapChanged();
			}
        }
		partial void OnCapChanging();
		partial void OnCapChanged();
		
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
