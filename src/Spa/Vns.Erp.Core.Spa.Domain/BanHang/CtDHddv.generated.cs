using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
    public partial class CtDHddv : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _CthHddvId = new Guid();
		private System.Guid _IdHanghoa = new Guid();
		private System.Guid _IdDichvu = new Guid();
		private string _TenHhDv = String.Empty;
		private decimal _SoLuong = 0;
		private decimal _DonGia = 0;
		private decimal _DoanhThu = 0;
		private decimal _TyLeGiamGia = 0;
		private decimal _SoTienGiamGia = 0;
		private decimal _TyLeHh = 0;
		private decimal _SoTienHh = 0;
		private decimal _SoTienMg = 0;
		private decimal _TyLeThueGtgt = 0;
		private decimal _SoTienThueGtgt = 0;
		private string _Dvt = String.Empty;
		private string _NoiDung = String.Empty;
		private decimal _LoaiNghiepVu = 0;
		private decimal _Nhom = 0;
		private decimal _PhanHe = 0;
		private System.Guid _IdDoituong1 = new Guid();
		private System.Guid _IdDoituong2 = new Guid();
		
		
		
        #endregion

        #region Constructors

        public CtDHddv() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_CthHddvId);
			sb.Append(_IdHanghoa);
			sb.Append(_IdDichvu);
			sb.Append(_TenHhDv);
			sb.Append(_SoLuong);
			sb.Append(_DonGia);
			sb.Append(_DoanhThu);
			sb.Append(_TyLeGiamGia);
			sb.Append(_SoTienGiamGia);
			sb.Append(_TyLeHh);
			sb.Append(_SoTienHh);
			sb.Append(_SoTienMg);
			sb.Append(_TyLeThueGtgt);
			sb.Append(_SoTienThueGtgt);
			sb.Append(_Dvt);
			sb.Append(_NoiDung);
			sb.Append(_LoaiNghiepVu);
			sb.Append(_Nhom);
			sb.Append(_PhanHe);
			sb.Append(_IdDoituong1);
			sb.Append(_IdDoituong2);

            return sb.ToString().GetHashCode();
        }
		
		public CtDHddv Clone()
        {
            return (CtDHddv)this.MemberwiseClone();
        }
		
		public void SetProperty(CtDHddv des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_CthHddvId = des.CthHddvId;
			_IdHanghoa = des.IdHanghoa;
			_IdDichvu = des.IdDichvu;
			_TenHhDv = des.TenHhDv;
			_SoLuong = des.SoLuong;
			_DonGia = des.DonGia;
			_DoanhThu = des.DoanhThu;
			_TyLeGiamGia = des.TyLeGiamGia;
			_SoTienGiamGia = des.SoTienGiamGia;
			_TyLeHh = des.TyLeHh;
			_SoTienHh = des.SoTienHh;
			_SoTienMg = des.SoTienMg;
			_TyLeThueGtgt = des.TyLeThueGtgt;
			_SoTienThueGtgt = des.SoTienThueGtgt;
			_Dvt = des.Dvt;
			_NoiDung = des.NoiDung;
			_LoaiNghiepVu = des.LoaiNghiepVu;
			_Nhom = des.Nhom;
			_PhanHe = des.PhanHe;
			_IdDoituong1 = des.IdDoituong1;
			_IdDoituong2 = des.IdDoituong2;
		}

        #endregion

        #region Properties

		public virtual System.Guid CthHddvId
        {
            get { return _CthHddvId; }
			set
			{
				OnCthHddvIdChanging();
				_CthHddvId = value;
				OnCthHddvIdChanged();
			}
        }
		partial void OnCthHddvIdChanging();
		partial void OnCthHddvIdChanged();
		
		public virtual System.Guid IdHanghoa
        {
            get { return _IdHanghoa; }
			set
			{
				OnIdHanghoaChanging();
				_IdHanghoa = value;
				OnIdHanghoaChanged();
			}
        }
		partial void OnIdHanghoaChanging();
		partial void OnIdHanghoaChanged();
		
		public virtual System.Guid IdDichvu
        {
            get { return _IdDichvu; }
			set
			{
				OnIdDichvuChanging();
				_IdDichvu = value;
				OnIdDichvuChanged();
			}
        }
		partial void OnIdDichvuChanging();
		partial void OnIdDichvuChanged();
		
		public virtual string TenHhDv
        {
            get { return _TenHhDv; }
			set
			{
				OnTenHhDvChanging();
				_TenHhDv = value;
				OnTenHhDvChanged();
			}
        }
		partial void OnTenHhDvChanging();
		partial void OnTenHhDvChanged();
		
		public virtual decimal SoLuong
        {
            get { return _SoLuong; }
			set
			{
				OnSoLuongChanging();
                _SoLuong = Decimal.Round(value, 2);
				OnSoLuongChanged();
			}
        }
		partial void OnSoLuongChanging();
		partial void OnSoLuongChanged();
		
		public virtual decimal DonGia
        {
            get { return _DonGia; }
			set
			{
				OnDonGiaChanging();
                _DonGia = Decimal.Round(value, 2);
				OnDonGiaChanged();
			}
        }
		partial void OnDonGiaChanging();
		partial void OnDonGiaChanged();
		
		public virtual decimal DoanhThu
        {
            get { return _DoanhThu; }
			set
			{
				OnDoanhThuChanging();
                _DoanhThu = Decimal.Round(value);
				OnDoanhThuChanged();
			}
        }
		partial void OnDoanhThuChanging();
		partial void OnDoanhThuChanged();
		
		public virtual decimal TyLeGiamGia
        {
            get { return _TyLeGiamGia; }
			set
			{
				OnTyLeGiamGiaChanging();
				_TyLeGiamGia = value;
				OnTyLeGiamGiaChanged();
			}
        }
		partial void OnTyLeGiamGiaChanging();
		partial void OnTyLeGiamGiaChanged();
		
		public virtual decimal SoTienGiamGia
        {
            get { return _SoTienGiamGia; }
			set
			{
				OnSoTienGiamGiaChanging();
                _SoTienGiamGia = Decimal.Round(value);
				OnSoTienGiamGiaChanged();
			}
        }
		partial void OnSoTienGiamGiaChanging();
		partial void OnSoTienGiamGiaChanged();
		
		public virtual decimal TyLeHh
        {
            get { return _TyLeHh; }
			set
			{
				OnTyLeHhChanging();
				_TyLeHh = value;
				OnTyLeHhChanged();
			}
        }
		partial void OnTyLeHhChanging();
		partial void OnTyLeHhChanged();
		
		public virtual decimal SoTienHh
        {
            get { return _SoTienHh; }
			set
			{
				OnSoTienHhChanging();
                _SoTienHh = Decimal.Round(value);
				OnSoTienHhChanged();
			}
        }
		partial void OnSoTienHhChanging();
		partial void OnSoTienHhChanged();
		
		public virtual decimal SoTienMg
        {
            get { return _SoTienMg; }
			set
			{
				OnSoTienMgChanging();
                _SoTienMg = Decimal.Round(value);
				OnSoTienMgChanged();
			}
        }
		partial void OnSoTienMgChanging();
		partial void OnSoTienMgChanged();
		
		public virtual decimal TyLeThueGtgt
        {
            get { return _TyLeThueGtgt; }
			set
			{
				OnTyLeThueGtgtChanging();
				_TyLeThueGtgt = value;
				OnTyLeThueGtgtChanged();
			}
        }
		partial void OnTyLeThueGtgtChanging();
		partial void OnTyLeThueGtgtChanged();
		
		public virtual decimal SoTienThueGtgt
        {
            get { return _SoTienThueGtgt; }
			set
			{
				OnSoTienThueGtgtChanging();
                _SoTienThueGtgt = Decimal.Round(value);
				OnSoTienThueGtgtChanged();
			}
        }
		partial void OnSoTienThueGtgtChanging();
		partial void OnSoTienThueGtgtChanged();
		
		public virtual string Dvt
        {
            get { return _Dvt; }
			set
			{
				OnDvtChanging();
				_Dvt = value;
				OnDvtChanged();
			}
        }
		partial void OnDvtChanging();
		partial void OnDvtChanged();
		
		public virtual string NoiDung
        {
            get { return _NoiDung; }
			set
			{
				OnNoiDungChanging();
				_NoiDung = value;
				OnNoiDungChanged();
			}
        }
		partial void OnNoiDungChanging();
		partial void OnNoiDungChanged();
		
        /// <summary>
        /// 1. Hang hoa
        /// 2. Dich vu
        /// </summary>
		public virtual decimal LoaiNghiepVu
        {
            get { return _LoaiNghiepVu; }
			set
			{
				OnLoaiNghiepVuChanging();
				_LoaiNghiepVu = value;
				OnLoaiNghiepVuChanged();
			}
        }
		partial void OnLoaiNghiepVuChanging();
		partial void OnLoaiNghiepVuChanged();
		
		public virtual decimal Nhom
        {
            get { return _Nhom; }
			set
			{
				OnNhomChanging();
				_Nhom = value;
				OnNhomChanged();
			}
        }
		partial void OnNhomChanging();
		partial void OnNhomChanged();
		
		public virtual decimal PhanHe
        {
            get { return _PhanHe; }
			set
			{
				OnPhanHeChanging();
				_PhanHe = value;
				OnPhanHeChanged();
			}
        }
		partial void OnPhanHeChanging();
		partial void OnPhanHeChanged();
		
		public virtual System.Guid IdDoituong1
        {
            get { return _IdDoituong1; }
			set
			{
				OnIdDoituong1Changing();
				_IdDoituong1 = value;
				OnIdDoituong1Changed();
			}
        }
		partial void OnIdDoituong1Changing();
		partial void OnIdDoituong1Changed();
		
		public virtual System.Guid IdDoituong2
        {
            get { return _IdDoituong2; }
			set
			{
				OnIdDoituong2Changing();
				_IdDoituong2 = value;
				OnIdDoituong2Changed();
			}
        }
		partial void OnIdDoituong2Changing();
		partial void OnIdDoituong2Changed();
		
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
