using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class KtCtDKhac : DomainObject<Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _CthId = new Guid();
		private System.Guid _TkId = new Guid();
		private string _MaTk = String.Empty;
		private string _TenTk = String.Empty;
		private decimal _PsNo = 0;
		private decimal _PsCo = 0;
		private decimal _PsNoNt = 0;
		private decimal _PsCoNt = 0;
		private string _NoiDung = String.Empty;
		private System.Guid _IdDmHopdong = new Guid();
		private string _MaHopdong = String.Empty;
		private string _KyHieuHopdong = String.Empty;
		private string _TenHopdong = String.Empty;
		private System.Guid _IdDmPtqt = new Guid();
		private System.Guid _IdDmPhongban = new Guid();
		private System.Guid _IdCtGhiso = new Guid();
		private string _MaCtGhisoSo = String.Empty;
		private string _CtGhisoTrichyeu = String.Empty;
		private System.DateTime _CtGhisoNgay = new DateTime();
		private decimal _DaGhiso = 0;
		private System.Guid _IdDmVuviec = new Guid();
		private string _MaVuviec = String.Empty;
		private string _KyHieuVuviec = String.Empty;
		private System.Guid _IdDmTudo1 = new Guid();
		private System.Guid _IdDmTudo2 = new Guid();
		private System.Guid _IdDmTudo3 = new Guid();
		private System.Guid _IdDmTudo4 = new Guid();
		private System.Guid _IdDmTudo5 = new Guid();
		private decimal _LoaiNghiepVu = 0;
		private System.Guid _IdKhang = new Guid();
		private string _MaKhang = String.Empty;
		private System.Guid _IdDoituong1 = new Guid();
		private string _MaDoituong1 = String.Empty;
		private string _TenDoituong1 = String.Empty;
		private System.Guid _IdDoituong2 = new Guid();
		private string _MaDoituong2 = String.Empty;
		private string _TenDoituong2 = String.Empty;
		private System.Guid _IdDoituong3 = new Guid();
		private string _MaDoituong3 = String.Empty;
		private string _TenDoituong3 = String.Empty;
		private System.Guid _IdDmKhoanphi = new Guid();
		private decimal _TyGiaChenhlech = 0;
		private decimal _NHOM = 0;
		private decimal _SoDu = 0;
		private System.Guid _IdDoituongHoadon = new Guid();
		private string _MaHoadon = String.Empty;
		private string _KyHieuHoadon = String.Empty;
		private string _MaRo = String.Empty;
		private string _TenRo = String.Empty;
		private string _KyHieuKhang = String.Empty;
		private string _TenKhang = String.Empty;
		private decimal _PhanHe = 0;
		private string _Bx1 = String.Empty;
		private string _Bx2 = String.Empty;
		private string _Bx3 = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public KtCtDKhac() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_CthId);
			sb.Append(_TkId);
			sb.Append(_MaTk);
			sb.Append(_TenTk);
			sb.Append(_PsNo);
			sb.Append(_PsCo);
			sb.Append(_PsNoNt);
			sb.Append(_PsCoNt);
			sb.Append(_NoiDung);
			sb.Append(_IdDmHopdong);
			sb.Append(_MaHopdong);
			sb.Append(_KyHieuHopdong);
			sb.Append(_TenHopdong);
			sb.Append(_IdDmPtqt);
			sb.Append(_IdDmPhongban);
			sb.Append(_IdCtGhiso);
			sb.Append(_MaCtGhisoSo);
			sb.Append(_CtGhisoTrichyeu);
			sb.Append(_CtGhisoNgay);
			sb.Append(_DaGhiso);
			sb.Append(_IdDmVuviec);
			sb.Append(_MaVuviec);
			sb.Append(_KyHieuVuviec);
			sb.Append(_IdDmTudo1);
			sb.Append(_IdDmTudo2);
			sb.Append(_IdDmTudo3);
			sb.Append(_IdDmTudo4);
			sb.Append(_IdDmTudo5);
			sb.Append(_LoaiNghiepVu);
			sb.Append(_IdKhang);
			sb.Append(_MaKhang);
			sb.Append(_IdDoituong1);
			sb.Append(_MaDoituong1);
			sb.Append(_TenDoituong1);
			sb.Append(_IdDoituong2);
			sb.Append(_MaDoituong2);
			sb.Append(_TenDoituong2);
			sb.Append(_IdDoituong3);
			sb.Append(_MaDoituong3);
			sb.Append(_TenDoituong3);
			sb.Append(_IdDmKhoanphi);
			sb.Append(_TyGiaChenhlech);
			sb.Append(_NHOM);
			sb.Append(_SoDu);
			sb.Append(_IdDoituongHoadon);
			sb.Append(_MaHoadon);
			sb.Append(_KyHieuHoadon);
			sb.Append(_MaRo);
			sb.Append(_TenRo);
			sb.Append(_KyHieuKhang);
			sb.Append(_TenKhang);
			sb.Append(_PhanHe);
			sb.Append(_Bx1);
			sb.Append(_Bx2);
			sb.Append(_Bx3);

            return sb.ToString().GetHashCode();
        }
		
		public KtCtDKhac Clone()
        {
            return (KtCtDKhac)this.MemberwiseClone();
        }
		
		public void SetProperty(KtCtDKhac des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_CthId = des.CthId;
			_TkId = des.TkId;
			_MaTk = des.MaTk;
			_TenTk = des.TenTk;
			_PsNo = des.PsNo;
			_PsCo = des.PsCo;
			_PsNoNt = des.PsNoNt;
			_PsCoNt = des.PsCoNt;
			_NoiDung = des.NoiDung;
			_IdDmHopdong = des.IdDmHopdong;
			_MaHopdong = des.MaHopdong;
			_KyHieuHopdong = des.KyHieuHopdong;
			_TenHopdong = des.TenHopdong;
			_IdDmPtqt = des.IdDmPtqt;
			_IdDmPhongban = des.IdDmPhongban;
			_IdCtGhiso = des.IdCtGhiso;
			_MaCtGhisoSo = des.MaCtGhisoSo;
			_CtGhisoTrichyeu = des.CtGhisoTrichyeu;
			_CtGhisoNgay = des.CtGhisoNgay;
			_DaGhiso = des.DaGhiso;
			_IdDmVuviec = des.IdDmVuviec;
			_MaVuviec = des.MaVuviec;
			_KyHieuVuviec = des.KyHieuVuviec;
			_IdDmTudo1 = des.IdDmTudo1;
			_IdDmTudo2 = des.IdDmTudo2;
			_IdDmTudo3 = des.IdDmTudo3;
			_IdDmTudo4 = des.IdDmTudo4;
			_IdDmTudo5 = des.IdDmTudo5;
			_LoaiNghiepVu = des.LoaiNghiepVu;
			_IdKhang = des.IdKhang;
			_MaKhang = des.MaKhang;
			_IdDoituong1 = des.IdDoituong1;
			_MaDoituong1 = des.MaDoituong1;
			_TenDoituong1 = des.TenDoituong1;
			_IdDoituong2 = des.IdDoituong2;
			_MaDoituong2 = des.MaDoituong2;
			_TenDoituong2 = des.TenDoituong2;
			_IdDoituong3 = des.IdDoituong3;
			_MaDoituong3 = des.MaDoituong3;
			_TenDoituong3 = des.TenDoituong3;
			_IdDmKhoanphi = des.IdDmKhoanphi;
			_TyGiaChenhlech = des.TyGiaChenhlech;
			_NHOM = des.NHOM;
			_SoDu = des.SoDu;
			_IdDoituongHoadon = des.IdDoituongHoadon;
			_MaHoadon = des.MaHoadon;
			_KyHieuHoadon = des.KyHieuHoadon;
			_MaRo = des.MaRo;
			_TenRo = des.TenRo;
			_KyHieuKhang = des.KyHieuKhang;
			_TenKhang = des.TenKhang;
			_PhanHe = des.PhanHe;
			_Bx1 = des.Bx1;
			_Bx2 = des.Bx2;
			_Bx3 = des.Bx3;
		}

        #endregion

        #region Properties

		public virtual System.Guid CthId
        {
            get { return _CthId; }
			set
			{
				OnCthIdChanging();
				_CthId = value;
				OnCthIdChanged();
			}
        }
		partial void OnCthIdChanging();
		partial void OnCthIdChanged();
		
		public virtual System.Guid TkId
        {
            get { return _TkId; }
			set
			{
				OnTkIdChanging();
				_TkId = value;
				OnTkIdChanged();
			}
        }
		partial void OnTkIdChanging();
		partial void OnTkIdChanged();
		
		public virtual string MaTk
        {
            get { return _MaTk; }
			set
			{
				OnMaTkChanging();
				_MaTk = value;
				OnMaTkChanged();
			}
        }
		partial void OnMaTkChanging();
		partial void OnMaTkChanged();
		
		public virtual string TenTk
        {
            get { return _TenTk; }
			set
			{
				OnTenTkChanging();
				_TenTk = value;
				OnTenTkChanged();
			}
        }
		partial void OnTenTkChanging();
		partial void OnTenTkChanged();
		
		public virtual decimal PsNo
        {
            get { return _PsNo; }
			set
			{
				OnPsNoChanging();
				_PsNo = value;
				OnPsNoChanged();
			}
        }
		partial void OnPsNoChanging();
		partial void OnPsNoChanged();
		
		public virtual decimal PsCo
        {
            get { return _PsCo; }
			set
			{
				OnPsCoChanging();
				_PsCo = value;
				OnPsCoChanged();
			}
        }
		partial void OnPsCoChanging();
		partial void OnPsCoChanged();
		
		public virtual decimal PsNoNt
        {
            get { return _PsNoNt; }
			set
			{
				OnPsNoNtChanging();
				_PsNoNt = value;
				OnPsNoNtChanged();
			}
        }
		partial void OnPsNoNtChanging();
		partial void OnPsNoNtChanged();
		
		public virtual decimal PsCoNt
        {
            get { return _PsCoNt; }
			set
			{
				OnPsCoNtChanging();
				_PsCoNt = value;
				OnPsCoNtChanged();
			}
        }
		partial void OnPsCoNtChanging();
		partial void OnPsCoNtChanged();
		
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
		
		public virtual System.Guid IdDmHopdong
        {
            get { return _IdDmHopdong; }
			set
			{
				OnIdDmHopdongChanging();
				_IdDmHopdong = value;
				OnIdDmHopdongChanged();
			}
        }
		partial void OnIdDmHopdongChanging();
		partial void OnIdDmHopdongChanged();
		
		public virtual string MaHopdong
        {
            get { return _MaHopdong; }
			set
			{
				OnMaHopdongChanging();
				_MaHopdong = value;
				OnMaHopdongChanged();
			}
        }
		partial void OnMaHopdongChanging();
		partial void OnMaHopdongChanged();
		
		public virtual string KyHieuHopdong
        {
            get { return _KyHieuHopdong; }
			set
			{
				OnKyHieuHopdongChanging();
				_KyHieuHopdong = value;
				OnKyHieuHopdongChanged();
			}
        }
		partial void OnKyHieuHopdongChanging();
		partial void OnKyHieuHopdongChanged();
		
		public virtual string TenHopdong
        {
            get { return _TenHopdong; }
			set
			{
				OnTenHopdongChanging();
				_TenHopdong = value;
				OnTenHopdongChanged();
			}
        }
		partial void OnTenHopdongChanging();
		partial void OnTenHopdongChanged();
		
		public virtual System.Guid IdDmPtqt
        {
            get { return _IdDmPtqt; }
			set
			{
				OnIdDmPtqtChanging();
				_IdDmPtqt = value;
				OnIdDmPtqtChanged();
			}
        }
		partial void OnIdDmPtqtChanging();
		partial void OnIdDmPtqtChanged();
		
		public virtual System.Guid IdDmPhongban
        {
            get { return _IdDmPhongban; }
			set
			{
				OnIdDmPhongbanChanging();
				_IdDmPhongban = value;
				OnIdDmPhongbanChanged();
			}
        }
		partial void OnIdDmPhongbanChanging();
		partial void OnIdDmPhongbanChanged();
		
		public virtual System.Guid IdCtGhiso
        {
            get { return _IdCtGhiso; }
			set
			{
				OnIdCtGhisoChanging();
				_IdCtGhiso = value;
				OnIdCtGhisoChanged();
			}
        }
		partial void OnIdCtGhisoChanging();
		partial void OnIdCtGhisoChanged();
		
		public virtual string MaCtGhisoSo
        {
            get { return _MaCtGhisoSo; }
			set
			{
				OnMaCtGhisoSoChanging();
				_MaCtGhisoSo = value;
				OnMaCtGhisoSoChanged();
			}
        }
		partial void OnMaCtGhisoSoChanging();
		partial void OnMaCtGhisoSoChanged();
		
		public virtual string CtGhisoTrichyeu
        {
            get { return _CtGhisoTrichyeu; }
			set
			{
				OnCtGhisoTrichyeuChanging();
				_CtGhisoTrichyeu = value;
				OnCtGhisoTrichyeuChanged();
			}
        }
		partial void OnCtGhisoTrichyeuChanging();
		partial void OnCtGhisoTrichyeuChanged();
		
		public virtual System.DateTime CtGhisoNgay
        {
            get { return _CtGhisoNgay; }
			set
			{
				OnCtGhisoNgayChanging();
				_CtGhisoNgay = value;
				OnCtGhisoNgayChanged();
			}
        }
		partial void OnCtGhisoNgayChanging();
		partial void OnCtGhisoNgayChanged();
		
		public virtual decimal DaGhiso
        {
            get { return _DaGhiso; }
			set
			{
				OnDaGhisoChanging();
				_DaGhiso = value;
				OnDaGhisoChanged();
			}
        }
		partial void OnDaGhisoChanging();
		partial void OnDaGhisoChanged();
		
		public virtual System.Guid IdDmVuviec
        {
            get { return _IdDmVuviec; }
			set
			{
				OnIdDmVuviecChanging();
				_IdDmVuviec = value;
				OnIdDmVuviecChanged();
			}
        }
		partial void OnIdDmVuviecChanging();
		partial void OnIdDmVuviecChanged();
		
		public virtual string MaVuviec
        {
            get { return _MaVuviec; }
			set
			{
				OnMaVuviecChanging();
				_MaVuviec = value;
				OnMaVuviecChanged();
			}
        }
		partial void OnMaVuviecChanging();
		partial void OnMaVuviecChanged();
		
		public virtual string KyHieuVuviec
        {
            get { return _KyHieuVuviec; }
			set
			{
				OnKyHieuVuviecChanging();
				_KyHieuVuviec = value;
				OnKyHieuVuviecChanged();
			}
        }
		partial void OnKyHieuVuviecChanging();
		partial void OnKyHieuVuviecChanged();
		
		public virtual System.Guid IdDmTudo1
        {
            get { return _IdDmTudo1; }
			set
			{
				OnIdDmTudo1Changing();
				_IdDmTudo1 = value;
				OnIdDmTudo1Changed();
			}
        }
		partial void OnIdDmTudo1Changing();
		partial void OnIdDmTudo1Changed();
		
		public virtual System.Guid IdDmTudo2
        {
            get { return _IdDmTudo2; }
			set
			{
				OnIdDmTudo2Changing();
				_IdDmTudo2 = value;
				OnIdDmTudo2Changed();
			}
        }
		partial void OnIdDmTudo2Changing();
		partial void OnIdDmTudo2Changed();
		
		public virtual System.Guid IdDmTudo3
        {
            get { return _IdDmTudo3; }
			set
			{
				OnIdDmTudo3Changing();
				_IdDmTudo3 = value;
				OnIdDmTudo3Changed();
			}
        }
		partial void OnIdDmTudo3Changing();
		partial void OnIdDmTudo3Changed();
		
		public virtual System.Guid IdDmTudo4
        {
            get { return _IdDmTudo4; }
			set
			{
				OnIdDmTudo4Changing();
				_IdDmTudo4 = value;
				OnIdDmTudo4Changed();
			}
        }
		partial void OnIdDmTudo4Changing();
		partial void OnIdDmTudo4Changed();
		
		public virtual System.Guid IdDmTudo5
        {
            get { return _IdDmTudo5; }
			set
			{
				OnIdDmTudo5Changing();
				_IdDmTudo5 = value;
				OnIdDmTudo5Changed();
			}
        }
		partial void OnIdDmTudo5Changing();
		partial void OnIdDmTudo5Changed();
		
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
		
		public virtual System.Guid IdKhang
        {
            get { return _IdKhang; }
			set
			{
				OnIdKhangChanging();
				_IdKhang = value;
				OnIdKhangChanged();
			}
        }
		partial void OnIdKhangChanging();
		partial void OnIdKhangChanged();
		
		public virtual string MaKhang
        {
            get { return _MaKhang; }
			set
			{
				OnMaKhangChanging();
				_MaKhang = value;
				OnMaKhangChanged();
			}
        }
		partial void OnMaKhangChanging();
		partial void OnMaKhangChanged();
		
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
		
		public virtual string MaDoituong1
        {
            get { return _MaDoituong1; }
			set
			{
				OnMaDoituong1Changing();
				_MaDoituong1 = value;
				OnMaDoituong1Changed();
			}
        }
		partial void OnMaDoituong1Changing();
		partial void OnMaDoituong1Changed();
		
		public virtual string TenDoituong1
        {
            get { return _TenDoituong1; }
			set
			{
				OnTenDoituong1Changing();
				_TenDoituong1 = value;
				OnTenDoituong1Changed();
			}
        }
		partial void OnTenDoituong1Changing();
		partial void OnTenDoituong1Changed();
		
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
		
		public virtual string MaDoituong2
        {
            get { return _MaDoituong2; }
			set
			{
				OnMaDoituong2Changing();
				_MaDoituong2 = value;
				OnMaDoituong2Changed();
			}
        }
		partial void OnMaDoituong2Changing();
		partial void OnMaDoituong2Changed();
		
		public virtual string TenDoituong2
        {
            get { return _TenDoituong2; }
			set
			{
				OnTenDoituong2Changing();
				_TenDoituong2 = value;
				OnTenDoituong2Changed();
			}
        }
		partial void OnTenDoituong2Changing();
		partial void OnTenDoituong2Changed();
		
		public virtual System.Guid IdDoituong3
        {
            get { return _IdDoituong3; }
			set
			{
				OnIdDoituong3Changing();
				_IdDoituong3 = value;
				OnIdDoituong3Changed();
			}
        }
		partial void OnIdDoituong3Changing();
		partial void OnIdDoituong3Changed();
		
		public virtual string MaDoituong3
        {
            get { return _MaDoituong3; }
			set
			{
				OnMaDoituong3Changing();
				_MaDoituong3 = value;
				OnMaDoituong3Changed();
			}
        }
		partial void OnMaDoituong3Changing();
		partial void OnMaDoituong3Changed();
		
		public virtual string TenDoituong3
        {
            get { return _TenDoituong3; }
			set
			{
				OnTenDoituong3Changing();
				_TenDoituong3 = value;
				OnTenDoituong3Changed();
			}
        }
		partial void OnTenDoituong3Changing();
		partial void OnTenDoituong3Changed();
		
		public virtual System.Guid IdDmKhoanphi
        {
            get { return _IdDmKhoanphi; }
			set
			{
				OnIdDmKhoanphiChanging();
				_IdDmKhoanphi = value;
				OnIdDmKhoanphiChanged();
			}
        }
		partial void OnIdDmKhoanphiChanging();
		partial void OnIdDmKhoanphiChanged();
		
		public virtual decimal TyGiaChenhlech
        {
            get { return _TyGiaChenhlech; }
			set
			{
				OnTyGiaChenhlechChanging();
				_TyGiaChenhlech = value;
				OnTyGiaChenhlechChanged();
			}
        }
		partial void OnTyGiaChenhlechChanging();
		partial void OnTyGiaChenhlechChanged();
		
		public virtual decimal NHOM
        {
            get { return _NHOM; }
			set
			{
				OnNHOMChanging();
				_NHOM = value;
				OnNHOMChanged();
			}
        }
		partial void OnNHOMChanging();
		partial void OnNHOMChanged();
		
		public virtual decimal SoDu
        {
            get { return _SoDu; }
			set
			{
				OnSoDuChanging();
				_SoDu = value;
				OnSoDuChanged();
			}
        }
		partial void OnSoDuChanging();
		partial void OnSoDuChanged();
		
		public virtual System.Guid IdDoituongHoadon
        {
            get { return _IdDoituongHoadon; }
			set
			{
				OnIdDoituongHoadonChanging();
				_IdDoituongHoadon = value;
				OnIdDoituongHoadonChanged();
			}
        }
		partial void OnIdDoituongHoadonChanging();
		partial void OnIdDoituongHoadonChanged();
		
		public virtual string MaHoadon
        {
            get { return _MaHoadon; }
			set
			{
				OnMaHoadonChanging();
				_MaHoadon = value;
				OnMaHoadonChanged();
			}
        }
		partial void OnMaHoadonChanging();
		partial void OnMaHoadonChanged();
		
		public virtual string KyHieuHoadon
        {
            get { return _KyHieuHoadon; }
			set
			{
				OnKyHieuHoadonChanging();
				_KyHieuHoadon = value;
				OnKyHieuHoadonChanged();
			}
        }
		partial void OnKyHieuHoadonChanging();
		partial void OnKyHieuHoadonChanged();
		
		public virtual string MaRo
        {
            get { return _MaRo; }
			set
			{
				OnMaRoChanging();
				_MaRo = value;
				OnMaRoChanged();
			}
        }
		partial void OnMaRoChanging();
		partial void OnMaRoChanged();
		
		public virtual string TenRo
        {
            get { return _TenRo; }
			set
			{
				OnTenRoChanging();
				_TenRo = value;
				OnTenRoChanged();
			}
        }
		partial void OnTenRoChanging();
		partial void OnTenRoChanged();
		
		public virtual string KyHieuKhang
        {
            get { return _KyHieuKhang; }
			set
			{
				OnKyHieuKhangChanging();
				_KyHieuKhang = value;
				OnKyHieuKhangChanged();
			}
        }
		partial void OnKyHieuKhangChanging();
		partial void OnKyHieuKhangChanged();
		
		public virtual string TenKhang
        {
            get { return _TenKhang; }
			set
			{
				OnTenKhangChanging();
				_TenKhang = value;
				OnTenKhangChanged();
			}
        }
		partial void OnTenKhangChanging();
		partial void OnTenKhangChanged();
		
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
		
		public virtual string Bx1
        {
            get { return _Bx1; }
			set
			{
				OnBx1Changing();
				_Bx1 = value;
				OnBx1Changed();
			}
        }
		partial void OnBx1Changing();
		partial void OnBx1Changed();
		
		public virtual string Bx2
        {
            get { return _Bx2; }
			set
			{
				OnBx2Changing();
				_Bx2 = value;
				OnBx2Changed();
			}
        }
		partial void OnBx2Changing();
		partial void OnBx2Changed();
		
		public virtual string Bx3
        {
            get { return _Bx3; }
			set
			{
				OnBx3Changing();
				_Bx3 = value;
				OnBx3Changed();
			}
        }
		partial void OnBx3Changing();
		partial void OnBx3Changed();
		
        #endregion
		
		
    }
}
