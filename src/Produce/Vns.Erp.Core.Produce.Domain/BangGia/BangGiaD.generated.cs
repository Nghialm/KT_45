using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class BangGiaD : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _BangGiaHId = new Guid();
        private string _MaNghiepVu = String.Empty;
        private string _MaVanChuyen = String.Empty;
        private int _Cang = 0;
		private System.Guid _KhoId = new Guid();
		private System.Guid _HanghoaId = new Guid();
		private decimal _SoLuongTon = 0;
		private decimal _DonGia = 0;
		private decimal _DonGiaUsd = 0;
		private string _GhiChu = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public BangGiaD() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_BangGiaHId);
			sb.Append(_MaNghiepVu);
			sb.Append(_MaVanChuyen);
            sb.Append(_Cang);
			sb.Append(_KhoId);
			sb.Append(_HanghoaId);
			sb.Append(_SoLuongTon);
			sb.Append(_DonGia);
			sb.Append(_DonGiaUsd);
			sb.Append(_GhiChu);

            return sb.ToString().GetHashCode();
        }
		
		public BangGiaD Clone()
        {
            return (BangGiaD)this.MemberwiseClone();
        }
		
		public void SetProperty(BangGiaD des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_BangGiaHId = des.BangGiaHId;
			_MaNghiepVu = des.MaNghiepVu;
            _MaVanChuyen = des.MaVanChuyen;
            _Cang = des.Cang;
			_KhoId = des.KhoId;
			_HanghoaId = des.HanghoaId;
			_SoLuongTon = des.SoLuongTon;
			_DonGia = des.DonGia;
			_DonGiaUsd = des.DonGiaUsd;
			_GhiChu = des.GhiChu;
		}

        #endregion

        #region Properties

		public virtual System.Guid BangGiaHId
        {
            get { return _BangGiaHId; }
			set
			{
				OnBangGiaHIdChanging();
				_BangGiaHId = value;
				OnBangGiaHIdChanged();
			}
        }
		partial void OnBangGiaHIdChanging();
		partial void OnBangGiaHIdChanged();
		
		public virtual string MaNghiepVu
        {
            get { return _MaNghiepVu; }
			set
			{
				OnMaNghiepVuChanging();
				_MaNghiepVu = value;
				OnMaNghiepVuChanged();
			}
        }
		partial void OnMaNghiepVuChanging();
		partial void OnMaNghiepVuChanged();

        public virtual string MaVanChuyen
        {
            get { return _MaVanChuyen; }
            set
            {
                _MaVanChuyen = value;
            }
        }

        public virtual int Cang
        {
            get { return _Cang; }
			set
			{
				OnCangChanging();
				_Cang = value;
				OnCangChanged();
			}
        }
		partial void OnCangChanging();
		partial void OnCangChanged();
		
		public virtual System.Guid KhoId
        {
            get { return _KhoId; }
			set
			{
				OnKhoIdChanging();
				_KhoId = value;
				OnKhoIdChanged();
			}
        }
		partial void OnKhoIdChanging();
		partial void OnKhoIdChanged();
		
		public virtual System.Guid HanghoaId
        {
            get { return _HanghoaId; }
			set
			{
				OnHanghoaIdChanging();
				_HanghoaId = value;
				OnHanghoaIdChanged();
			}
        }
		partial void OnHanghoaIdChanging();
		partial void OnHanghoaIdChanged();
		
		public virtual decimal SoLuongTon
        {
            get { return _SoLuongTon; }
			set
			{
				OnSoLuongTonChanging();
				_SoLuongTon = value;
				OnSoLuongTonChanged();
			}
        }
		partial void OnSoLuongTonChanging();
		partial void OnSoLuongTonChanged();
		
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
		
		public virtual decimal DonGiaUsd
        {
            get { return _DonGiaUsd; }
			set
			{
				OnDonGiaUsdChanging();
				_DonGiaUsd = value;
				OnDonGiaUsdChanged();
			}
        }
		partial void OnDonGiaUsdChanging();
		partial void OnDonGiaUsdChanged();
		
		public virtual string GhiChu
        {
            get { return _GhiChu; }
			set
			{
				OnGhiChuChanging();
				_GhiChu = value;
				OnGhiChuChanged();
			}
        }
		partial void OnGhiChuChanging();
		partial void OnGhiChuChanged();
		
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
