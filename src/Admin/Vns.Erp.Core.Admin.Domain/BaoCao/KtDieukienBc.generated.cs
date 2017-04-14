using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class KtDieukienBc : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _IdDong = new Guid();
		private System.Guid _IdCot = new Guid();
		private string _ThuyetMinh = String.Empty;
		private string _CachTinh = String.Empty;
		private string _HamTinh = String.Empty;
		private string _TsThoigian = String.Empty;
		private string _TsKhac = String.Empty;
		private string _DkMaTk = String.Empty;
		private string _DkMaTkDu = String.Empty;
		private string _DkMaHopdong = String.Empty;
		private string _DkMaHopdongDu = String.Empty;
		private string _DkMaPtqt = String.Empty;
		private string _DkMaDmPtqtDu = String.Empty;
		private string _DkMaDmPhongban = String.Empty;
		private string _DkMaDmPhongbanDu = String.Empty;
		private string _DkMaDmVuviec = String.Empty;
		private string _DkMaDmVuviecDu = String.Empty;
		private string _DkMaDmTudo1 = String.Empty;
		private string _DkMaDmTudo1Du = String.Empty;
		private string _DkMaDmTudo2 = String.Empty;
		private string _DkMaDmTudo2Du = String.Empty;
		private string _DkMaDmTudo3 = String.Empty;
		private string _DkMaDmTudo3Du = String.Empty;
		private string _DkMaDmTudo4 = String.Empty;
		private string _DkMaDmTudo4Du = String.Empty;
		private string _DkMaDmTudo5 = String.Empty;
		private string _DkMaDmTudo5Du = String.Empty;
		private string _DkMaKhang = String.Empty;
		private string _DkMaKhangDu = String.Empty;
		private string _DkMaDmKhoanphi = String.Empty;
		private string _DkMaDmKhoanphiDu = String.Empty;
		private decimal _MaCot = 0;
		
		
		
        #endregion

        #region Constructors

        public KtDieukienBc() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_IdDong);
			sb.Append(_IdCot);
			sb.Append(_ThuyetMinh);
			sb.Append(_CachTinh);
			sb.Append(_HamTinh);
			sb.Append(_TsThoigian);
			sb.Append(_TsKhac);
			sb.Append(_DkMaTk);
			sb.Append(_DkMaTkDu);
			sb.Append(_DkMaHopdong);
			sb.Append(_DkMaHopdongDu);
			sb.Append(_DkMaPtqt);
			sb.Append(_DkMaDmPtqtDu);
			sb.Append(_DkMaDmPhongban);
			sb.Append(_DkMaDmPhongbanDu);
			sb.Append(_DkMaDmVuviec);
			sb.Append(_DkMaDmVuviecDu);
			sb.Append(_DkMaDmTudo1);
			sb.Append(_DkMaDmTudo1Du);
			sb.Append(_DkMaDmTudo2);
			sb.Append(_DkMaDmTudo2Du);
			sb.Append(_DkMaDmTudo3);
			sb.Append(_DkMaDmTudo3Du);
			sb.Append(_DkMaDmTudo4);
			sb.Append(_DkMaDmTudo4Du);
			sb.Append(_DkMaDmTudo5);
			sb.Append(_DkMaDmTudo5Du);
			sb.Append(_DkMaKhang);
			sb.Append(_DkMaKhangDu);
			sb.Append(_DkMaDmKhoanphi);
			sb.Append(_DkMaDmKhoanphiDu);
			sb.Append(_MaCot);

            return sb.ToString().GetHashCode();
        }
		
		public KtDieukienBc Clone()
        {
            return (KtDieukienBc)this.MemberwiseClone();
        }
		
		public void SetProperty(KtDieukienBc des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_IdDong = des.IdDong;
			_IdCot = des.IdCot;
			_ThuyetMinh = des.ThuyetMinh;
			_CachTinh = des.CachTinh;
			_HamTinh = des.HamTinh;
			_TsThoigian = des.TsThoigian;
			_TsKhac = des.TsKhac;
			_DkMaTk = des.DkMaTk;
			_DkMaTkDu = des.DkMaTkDu;
			_DkMaHopdong = des.DkMaHopdong;
			_DkMaHopdongDu = des.DkMaHopdongDu;
			_DkMaPtqt = des.DkMaPtqt;
			_DkMaDmPtqtDu = des.DkMaDmPtqtDu;
			_DkMaDmPhongban = des.DkMaDmPhongban;
			_DkMaDmPhongbanDu = des.DkMaDmPhongbanDu;
			_DkMaDmVuviec = des.DkMaDmVuviec;
			_DkMaDmVuviecDu = des.DkMaDmVuviecDu;
			_DkMaDmTudo1 = des.DkMaDmTudo1;
			_DkMaDmTudo1Du = des.DkMaDmTudo1Du;
			_DkMaDmTudo2 = des.DkMaDmTudo2;
			_DkMaDmTudo2Du = des.DkMaDmTudo2Du;
			_DkMaDmTudo3 = des.DkMaDmTudo3;
			_DkMaDmTudo3Du = des.DkMaDmTudo3Du;
			_DkMaDmTudo4 = des.DkMaDmTudo4;
			_DkMaDmTudo4Du = des.DkMaDmTudo4Du;
			_DkMaDmTudo5 = des.DkMaDmTudo5;
			_DkMaDmTudo5Du = des.DkMaDmTudo5Du;
			_DkMaKhang = des.DkMaKhang;
			_DkMaKhangDu = des.DkMaKhangDu;
			_DkMaDmKhoanphi = des.DkMaDmKhoanphi;
			_DkMaDmKhoanphiDu = des.DkMaDmKhoanphiDu;
			_MaCot = des.MaCot;
		}

        #endregion

        #region Properties

		public virtual System.Guid IdDong
        {
            get { return _IdDong; }
			set
			{
				OnIdDongChanging();
				_IdDong = value;
				OnIdDongChanged();
			}
        }
		partial void OnIdDongChanging();
		partial void OnIdDongChanged();
		
		public virtual System.Guid IdCot
        {
            get { return _IdCot; }
			set
			{
				OnIdCotChanging();
				_IdCot = value;
				OnIdCotChanged();
			}
        }
		partial void OnIdCotChanging();
		partial void OnIdCotChanged();
		
		public virtual string ThuyetMinh
        {
            get { return _ThuyetMinh; }
			set
			{
				OnThuyetMinhChanging();
				_ThuyetMinh = value;
				OnThuyetMinhChanged();
			}
        }
		partial void OnThuyetMinhChanging();
		partial void OnThuyetMinhChanged();
		
		public virtual string CachTinh
        {
            get { return _CachTinh; }
			set
			{
				OnCachTinhChanging();
				_CachTinh = value;
				OnCachTinhChanged();
			}
        }
		partial void OnCachTinhChanging();
		partial void OnCachTinhChanged();
		
		public virtual string HamTinh
        {
            get { return _HamTinh; }
			set
			{
				OnHamTinhChanging();
				_HamTinh = value;
				OnHamTinhChanged();
			}
        }
		partial void OnHamTinhChanging();
		partial void OnHamTinhChanged();
		
		public virtual string TsThoigian
        {
            get { return _TsThoigian; }
			set
			{
				OnTsThoigianChanging();
				_TsThoigian = value;
				OnTsThoigianChanged();
			}
        }
		partial void OnTsThoigianChanging();
		partial void OnTsThoigianChanged();
		
		public virtual string TsKhac
        {
            get { return _TsKhac; }
			set
			{
				OnTsKhacChanging();
				_TsKhac = value;
				OnTsKhacChanged();
			}
        }
		partial void OnTsKhacChanging();
		partial void OnTsKhacChanged();
		
		public virtual string DkMaTk
        {
            get { return _DkMaTk; }
			set
			{
				OnDkMaTkChanging();
				_DkMaTk = value;
				OnDkMaTkChanged();
			}
        }
		partial void OnDkMaTkChanging();
		partial void OnDkMaTkChanged();
		
		public virtual string DkMaTkDu
        {
            get { return _DkMaTkDu; }
			set
			{
				OnDkMaTkDuChanging();
				_DkMaTkDu = value;
				OnDkMaTkDuChanged();
			}
        }
		partial void OnDkMaTkDuChanging();
		partial void OnDkMaTkDuChanged();
		
		public virtual string DkMaHopdong
        {
            get { return _DkMaHopdong; }
			set
			{
				OnDkMaHopdongChanging();
				_DkMaHopdong = value;
				OnDkMaHopdongChanged();
			}
        }
		partial void OnDkMaHopdongChanging();
		partial void OnDkMaHopdongChanged();
		
		public virtual string DkMaHopdongDu
        {
            get { return _DkMaHopdongDu; }
			set
			{
				OnDkMaHopdongDuChanging();
				_DkMaHopdongDu = value;
				OnDkMaHopdongDuChanged();
			}
        }
		partial void OnDkMaHopdongDuChanging();
		partial void OnDkMaHopdongDuChanged();
		
		public virtual string DkMaPtqt
        {
            get { return _DkMaPtqt; }
			set
			{
				OnDkMaPtqtChanging();
				_DkMaPtqt = value;
				OnDkMaPtqtChanged();
			}
        }
		partial void OnDkMaPtqtChanging();
		partial void OnDkMaPtqtChanged();
		
		public virtual string DkMaDmPtqtDu
        {
            get { return _DkMaDmPtqtDu; }
			set
			{
				OnDkMaDmPtqtDuChanging();
				_DkMaDmPtqtDu = value;
				OnDkMaDmPtqtDuChanged();
			}
        }
		partial void OnDkMaDmPtqtDuChanging();
		partial void OnDkMaDmPtqtDuChanged();
		
		public virtual string DkMaDmPhongban
        {
            get { return _DkMaDmPhongban; }
			set
			{
				OnDkMaDmPhongbanChanging();
				_DkMaDmPhongban = value;
				OnDkMaDmPhongbanChanged();
			}
        }
		partial void OnDkMaDmPhongbanChanging();
		partial void OnDkMaDmPhongbanChanged();
		
		public virtual string DkMaDmPhongbanDu
        {
            get { return _DkMaDmPhongbanDu; }
			set
			{
				OnDkMaDmPhongbanDuChanging();
				_DkMaDmPhongbanDu = value;
				OnDkMaDmPhongbanDuChanged();
			}
        }
		partial void OnDkMaDmPhongbanDuChanging();
		partial void OnDkMaDmPhongbanDuChanged();
		
		public virtual string DkMaDmVuviec
        {
            get { return _DkMaDmVuviec; }
			set
			{
				OnDkMaDmVuviecChanging();
				_DkMaDmVuviec = value;
				OnDkMaDmVuviecChanged();
			}
        }
		partial void OnDkMaDmVuviecChanging();
		partial void OnDkMaDmVuviecChanged();
		
		public virtual string DkMaDmVuviecDu
        {
            get { return _DkMaDmVuviecDu; }
			set
			{
				OnDkMaDmVuviecDuChanging();
				_DkMaDmVuviecDu = value;
				OnDkMaDmVuviecDuChanged();
			}
        }
		partial void OnDkMaDmVuviecDuChanging();
		partial void OnDkMaDmVuviecDuChanged();
		
		public virtual string DkMaDmTudo1
        {
            get { return _DkMaDmTudo1; }
			set
			{
				OnDkMaDmTudo1Changing();
				_DkMaDmTudo1 = value;
				OnDkMaDmTudo1Changed();
			}
        }
		partial void OnDkMaDmTudo1Changing();
		partial void OnDkMaDmTudo1Changed();
		
		public virtual string DkMaDmTudo1Du
        {
            get { return _DkMaDmTudo1Du; }
			set
			{
				OnDkMaDmTudo1DuChanging();
				_DkMaDmTudo1Du = value;
				OnDkMaDmTudo1DuChanged();
			}
        }
		partial void OnDkMaDmTudo1DuChanging();
		partial void OnDkMaDmTudo1DuChanged();
		
		public virtual string DkMaDmTudo2
        {
            get { return _DkMaDmTudo2; }
			set
			{
				OnDkMaDmTudo2Changing();
				_DkMaDmTudo2 = value;
				OnDkMaDmTudo2Changed();
			}
        }
		partial void OnDkMaDmTudo2Changing();
		partial void OnDkMaDmTudo2Changed();
		
		public virtual string DkMaDmTudo2Du
        {
            get { return _DkMaDmTudo2Du; }
			set
			{
				OnDkMaDmTudo2DuChanging();
				_DkMaDmTudo2Du = value;
				OnDkMaDmTudo2DuChanged();
			}
        }
		partial void OnDkMaDmTudo2DuChanging();
		partial void OnDkMaDmTudo2DuChanged();
		
		public virtual string DkMaDmTudo3
        {
            get { return _DkMaDmTudo3; }
			set
			{
				OnDkMaDmTudo3Changing();
				_DkMaDmTudo3 = value;
				OnDkMaDmTudo3Changed();
			}
        }
		partial void OnDkMaDmTudo3Changing();
		partial void OnDkMaDmTudo3Changed();
		
		public virtual string DkMaDmTudo3Du
        {
            get { return _DkMaDmTudo3Du; }
			set
			{
				OnDkMaDmTudo3DuChanging();
				_DkMaDmTudo3Du = value;
				OnDkMaDmTudo3DuChanged();
			}
        }
		partial void OnDkMaDmTudo3DuChanging();
		partial void OnDkMaDmTudo3DuChanged();
		
		public virtual string DkMaDmTudo4
        {
            get { return _DkMaDmTudo4; }
			set
			{
				OnDkMaDmTudo4Changing();
				_DkMaDmTudo4 = value;
				OnDkMaDmTudo4Changed();
			}
        }
		partial void OnDkMaDmTudo4Changing();
		partial void OnDkMaDmTudo4Changed();
		
		public virtual string DkMaDmTudo4Du
        {
            get { return _DkMaDmTudo4Du; }
			set
			{
				OnDkMaDmTudo4DuChanging();
				_DkMaDmTudo4Du = value;
				OnDkMaDmTudo4DuChanged();
			}
        }
		partial void OnDkMaDmTudo4DuChanging();
		partial void OnDkMaDmTudo4DuChanged();
		
		public virtual string DkMaDmTudo5
        {
            get { return _DkMaDmTudo5; }
			set
			{
				OnDkMaDmTudo5Changing();
				_DkMaDmTudo5 = value;
				OnDkMaDmTudo5Changed();
			}
        }
		partial void OnDkMaDmTudo5Changing();
		partial void OnDkMaDmTudo5Changed();
		
		public virtual string DkMaDmTudo5Du
        {
            get { return _DkMaDmTudo5Du; }
			set
			{
				OnDkMaDmTudo5DuChanging();
				_DkMaDmTudo5Du = value;
				OnDkMaDmTudo5DuChanged();
			}
        }
		partial void OnDkMaDmTudo5DuChanging();
		partial void OnDkMaDmTudo5DuChanged();
		
		public virtual string DkMaKhang
        {
            get { return _DkMaKhang; }
			set
			{
				OnDkMaKhangChanging();
				_DkMaKhang = value;
				OnDkMaKhangChanged();
			}
        }
		partial void OnDkMaKhangChanging();
		partial void OnDkMaKhangChanged();
		
		public virtual string DkMaKhangDu
        {
            get { return _DkMaKhangDu; }
			set
			{
				OnDkMaKhangDuChanging();
				_DkMaKhangDu = value;
				OnDkMaKhangDuChanged();
			}
        }
		partial void OnDkMaKhangDuChanging();
		partial void OnDkMaKhangDuChanged();
		
		public virtual string DkMaDmKhoanphi
        {
            get { return _DkMaDmKhoanphi; }
			set
			{
				OnDkMaDmKhoanphiChanging();
				_DkMaDmKhoanphi = value;
				OnDkMaDmKhoanphiChanged();
			}
        }
		partial void OnDkMaDmKhoanphiChanging();
		partial void OnDkMaDmKhoanphiChanged();
		
		public virtual string DkMaDmKhoanphiDu
        {
            get { return _DkMaDmKhoanphiDu; }
			set
			{
				OnDkMaDmKhoanphiDuChanging();
				_DkMaDmKhoanphiDu = value;
				OnDkMaDmKhoanphiDuChanged();
			}
        }
		partial void OnDkMaDmKhoanphiDuChanging();
		partial void OnDkMaDmKhoanphiDuChanged();
		
		public virtual decimal MaCot
        {
            get { return _MaCot; }
			set
			{
				OnMaCotChanging();
				_MaCot = value;
				OnMaCotChanged();
			}
        }
		partial void OnMaCotChanging();
		partial void OnMaCotChanged();
		
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
