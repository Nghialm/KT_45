using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
    [Serializable]
    [DataContract(Namespace = "http://Vns.Erp.Core.Accounting.Domain", IsReference = true)]
    public partial class KtCtHHddv : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations
        private System.Guid _DonviId = new Guid();
        private string _MaDonvi = String.Empty;
        private System.Guid _IdLoaiCt = new Guid();
        private string _MaLoaiCt = String.Empty;
        private string _KyHieuLoaiCt = String.Empty;
        private System.DateTime _NgayGhi = Null.MIN_DATE;
        private string _CtSo = String.Empty;
        private string _QuyenSo = String.Empty;
        private System.DateTime _NgayCt = Null.MIN_DATE;
        private System.Guid _NteId = new Guid();
        private string _MaNte = String.Empty;
        private decimal _TyGia = 0;
        private decimal _SoTien = 0;
        private decimal _SoTienNte = 0;
        private System.DateTime _NgayTao = Null.MIN_DATE;
        private System.Guid _NguoiTao = new Guid();
        private System.Guid _NguoiSua = new Guid();
        private System.DateTime _NgaySua = Null.MIN_DATE;
        private System.Guid _NguoiPd = new Guid();
        private System.DateTime _NgayPd = Null.MIN_DATE;
        private string _DienGiai = String.Empty;
        private System.Guid _PhongbanId = new Guid();
        private string _MaPhongban = String.Empty;
        private string _KyHieuPhongban = String.Empty;
        private string _TenPhongban = String.Empty;
        private string _NguoiNhanNopTien = String.Empty;
        private string _NguoiGiaoNhanHang = String.Empty;
        private System.Guid _KhangId = new Guid();
        private string _MaKhang = String.Empty;
        private string _KyHieuKhang = String.Empty;
        private string _TenKhang = String.Empty;
        private string _MstKhang = String.Empty;
        private string _DiaChi = String.Empty;
        private System.Guid _CbnvId = new Guid();
        private string _KyHieuCbnv = String.Empty;
        private string _MaCbnv = String.Empty;
        private string _TenCbnv = String.Empty;
        private decimal _Ghi = 0;
        private string _Attachfile = String.Empty;
        private decimal _NgoaiTe = 0;
        private System.Guid _DonviCt = new Guid();
        private string _MaDonviCt = String.Empty;
        private decimal _DaKhoaSo = 0;
        private System.DateTime _NgayKhoaSo = Null.MIN_DATE;
        private decimal _BtTudong = 0;
        private System.DateTime _BxNgay1 = Null.MIN_DATE;
        private System.DateTime _BxNgay2 = Null.MIN_DATE;
        private System.DateTime _BxNgay3 = Null.MIN_DATE;
        private decimal _BxNumber1 = 0;
        private decimal _BxNumber2 = 0;
        private decimal _BxNumber3 = 0;
        private string _BxDiengiai1 = String.Empty;
        private string _BxDiengiai2 = String.Empty;
        private string _BxDiengiai3 = String.Empty;
        private string _SoSeriHd = String.Empty;
        private string _SoHd = String.Empty;
        private System.Guid _IdDoituongHoadon = new Guid();
        private string _PrefixCt = String.Empty;

        private DateTime _SynDate = Null.MIN_DATE;
        private decimal? _IsDeleted = 0;

        private IList<KtCtDHddv> _ktCtDHddvs = new List<KtCtDHddv>();

        #endregion

        #region Constructors

        public KtCtHHddv() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.GetType().FullName);
            sb.Append(_DonviId);
            sb.Append(_MaDonvi);
            sb.Append(_IdLoaiCt);
            sb.Append(_MaLoaiCt);
            sb.Append(_KyHieuLoaiCt);
            sb.Append(_NgayGhi);
            sb.Append(_CtSo);
            sb.Append(_QuyenSo);
            sb.Append(_NgayCt);
            sb.Append(_NteId);
            sb.Append(_MaNte);
            sb.Append(_TyGia);
            sb.Append(_SoTien);
            sb.Append(_SoTienNte);
            sb.Append(_NgayTao);
            sb.Append(_NguoiTao);
            sb.Append(_NguoiSua);
            sb.Append(_NgaySua);
            sb.Append(_NguoiPd);
            sb.Append(_NgayPd);
            sb.Append(_DienGiai);
            sb.Append(_PhongbanId);
            sb.Append(_MaPhongban);
            sb.Append(_KyHieuPhongban);
            sb.Append(_TenPhongban);
            sb.Append(_NguoiNhanNopTien);
            sb.Append(_NguoiGiaoNhanHang);
            sb.Append(_KhangId);
            sb.Append(_MaKhang);
            sb.Append(_KyHieuKhang);
            sb.Append(_TenKhang);
            sb.Append(_MstKhang);
            sb.Append(_DiaChi);
            sb.Append(_CbnvId);
            sb.Append(_KyHieuCbnv);
            sb.Append(_MaCbnv);
            sb.Append(_TenCbnv);
            sb.Append(_Ghi);
            sb.Append(_Attachfile);
            sb.Append(_NgoaiTe);
            sb.Append(_DonviCt);
            sb.Append(_MaDonviCt);
            sb.Append(_DaKhoaSo);
            sb.Append(_NgayKhoaSo);
            sb.Append(_BtTudong);
            sb.Append(_BxNgay1);
            sb.Append(_BxNgay2);
            sb.Append(_BxNgay3);
            sb.Append(_BxNumber1);
            sb.Append(_BxNumber2);
            sb.Append(_BxNumber3);
            sb.Append(_BxDiengiai1);
            sb.Append(_BxDiengiai2);
            sb.Append(_BxDiengiai3);
            sb.Append(_SoSeriHd);
            sb.Append(_SoHd);
            sb.Append(_IdDoituongHoadon);
            sb.Append(_PrefixCt);

            return sb.ToString().GetHashCode();
        }

        public KtCtHHddv Clone()
        {
            return (KtCtHHddv)this.MemberwiseClone();
        }

        public void SetProperty(KtCtHHddv des)
        {
            //ID Field
            Id = des.Id;
            //Non ID Field
            _DonviId = des.DonviId;
            _MaDonvi = des.MaDonvi;
            _IdLoaiCt = des.IdLoaiCt;
            _MaLoaiCt = des.MaLoaiCt;
            _KyHieuLoaiCt = des.KyHieuLoaiCt;
            _NgayGhi = des.NgayGhi;
            _CtSo = des.CtSo;
            _QuyenSo = des.QuyenSo;
            _NgayCt = des.NgayCt;
            _NteId = des.NteId;
            _MaNte = des.MaNte;
            _TyGia = des.TyGia;
            _SoTien = des.SoTien;
            _SoTienNte = des.SoTienNte;
            _NgayTao = des.NgayTao;
            _NguoiTao = des.NguoiTao;
            _NguoiSua = des.NguoiSua;
            _NgaySua = des.NgaySua;
            _NguoiPd = des.NguoiPd;
            _NgayPd = des.NgayPd;
            _DienGiai = des.DienGiai;
            _PhongbanId = des.PhongbanId;
            _MaPhongban = des.MaPhongban;
            _KyHieuPhongban = des.KyHieuPhongban;
            _TenPhongban = des.TenPhongban;
            _NguoiNhanNopTien = des.NguoiNhanNopTien;
            _NguoiGiaoNhanHang = des.NguoiGiaoNhanHang;
            _KhangId = des.KhangId;
            _MaKhang = des.MaKhang;
            _KyHieuKhang = des.KyHieuKhang;
            _TenKhang = des.TenKhang;
            _MstKhang = des.MstKhang;
            _DiaChi = des.DiaChi;
            _CbnvId = des.CbnvId;
            _KyHieuCbnv = des.KyHieuCbnv;
            _MaCbnv = des.MaCbnv;
            _TenCbnv = des.TenCbnv;
            _Ghi = des.Ghi;
            _Attachfile = des.Attachfile;
            _NgoaiTe = des.NgoaiTe;
            _DonviCt = des.DonviCt;
            _MaDonviCt = des.MaDonviCt;
            _DaKhoaSo = des.DaKhoaSo;
            _NgayKhoaSo = des.NgayKhoaSo;
            _BtTudong = des.BtTudong;
            _BxNgay1 = des.BxNgay1;
            _BxNgay2 = des.BxNgay2;
            _BxNgay3 = des.BxNgay3;
            _BxNumber1 = des.BxNumber1;
            _BxNumber2 = des.BxNumber2;
            _BxNumber3 = des.BxNumber3;
            _BxDiengiai1 = des.BxDiengiai1;
            _BxDiengiai2 = des.BxDiengiai2;
            _BxDiengiai3 = des.BxDiengiai3;
            _SoSeriHd = des.SoSeriHd;
            _SoHd = des.SoHd;
            _IdDoituongHoadon = des.IdDoituongHoadon;
            _PrefixCt = des.PrefixCt;
        }

        #endregion

        #region Properties
        [DataMember]
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

        [DataMember]
        public virtual string MaDonvi
        {
            get { return _MaDonvi; }
            set
            {
                OnMaDonviChanging();
                _MaDonvi = value;
                OnMaDonviChanged();
            }
        }
        partial void OnMaDonviChanging();
        partial void OnMaDonviChanged();

        [DataMember]
        public virtual System.Guid IdLoaiCt
        {
            get { return _IdLoaiCt; }
            set
            {
                OnIdLoaiCtChanging();
                _IdLoaiCt = value;
                OnIdLoaiCtChanged();
            }
        }
        partial void OnIdLoaiCtChanging();
        partial void OnIdLoaiCtChanged();

        [DataMember]
        public virtual string MaLoaiCt
        {
            get { return _MaLoaiCt; }
            set
            {
                OnMaLoaiCtChanging();
                _MaLoaiCt = value;
                OnMaLoaiCtChanged();
            }
        }
        partial void OnMaLoaiCtChanging();
        partial void OnMaLoaiCtChanged();

        [DataMember]
        public virtual string KyHieuLoaiCt
        {
            get { return _KyHieuLoaiCt; }
            set
            {
                OnKyHieuLoaiCtChanging();
                _KyHieuLoaiCt = value;
                OnKyHieuLoaiCtChanged();
            }
        }
        partial void OnKyHieuLoaiCtChanging();
        partial void OnKyHieuLoaiCtChanged();

        [DataMember]
        public virtual System.DateTime NgayGhi
        {
            get { return _NgayGhi; }
            set
            {
                OnNgayGhiChanging();
                _NgayGhi = value;
                OnNgayGhiChanged();
            }
        }
        partial void OnNgayGhiChanging();
        partial void OnNgayGhiChanged();

        [DataMember]
        public virtual string CtSo
        {
            get { return _CtSo; }
            set
            {
                OnCtSoChanging();
                _CtSo = value;
                OnCtSoChanged();
            }
        }
        partial void OnCtSoChanging();
        partial void OnCtSoChanged();

        [DataMember]
        public virtual string QuyenSo
        {
            get { return _QuyenSo; }
            set
            {
                OnQuyenSoChanging();
                _QuyenSo = value;
                OnQuyenSoChanged();
            }
        }
        partial void OnQuyenSoChanging();
        partial void OnQuyenSoChanged();

        [DataMember]
        public virtual System.DateTime NgayCt
        {
            get { return _NgayCt; }
            set
            {
                OnNgayCtChanging();
                _NgayCt = value;
                OnNgayCtChanged();
            }
        }
        partial void OnNgayCtChanging();
        partial void OnNgayCtChanged();

        [DataMember]
        public virtual System.Guid NteId
        {
            get { return _NteId; }
            set
            {
                OnNteIdChanging();
                _NteId = value;
                OnNteIdChanged();
            }
        }
        partial void OnNteIdChanging();
        partial void OnNteIdChanged();

        [DataMember]
        public virtual string MaNte
        {
            get { return _MaNte; }
            set
            {
                OnMaNteChanging();
                _MaNte = value;
                OnMaNteChanged();
            }
        }
        partial void OnMaNteChanging();
        partial void OnMaNteChanged();

        [DataMember]
        public virtual decimal TyGia
        {
            get { return _TyGia; }
            set
            {
                OnTyGiaChanging();
                _TyGia = value;
                OnTyGiaChanged();
            }
        }
        partial void OnTyGiaChanging();
        partial void OnTyGiaChanged();

        [DataMember]
        public virtual decimal SoTien
        {
            get { return _SoTien; }
            set
            {
                OnSoTienChanging();
                _SoTien = value;
                OnSoTienChanged();
            }
        }
        partial void OnSoTienChanging();
        partial void OnSoTienChanged();

        [DataMember]
        public virtual decimal SoTienNte
        {
            get { return _SoTienNte; }
            set
            {
                OnSoTienNteChanging();
                _SoTienNte = value;
                OnSoTienNteChanged();
            }
        }
        partial void OnSoTienNteChanging();
        partial void OnSoTienNteChanged();

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public virtual System.Guid NguoiPd
        {
            get { return _NguoiPd; }
            set
            {
                OnNguoiPdChanging();
                _NguoiPd = value;
                OnNguoiPdChanged();
            }
        }
        partial void OnNguoiPdChanging();
        partial void OnNguoiPdChanged();

        [DataMember]
        public virtual System.DateTime NgayPd
        {
            get { return _NgayPd; }
            set
            {
                OnNgayPdChanging();
                _NgayPd = value;
                OnNgayPdChanged();
            }
        }
        partial void OnNgayPdChanging();
        partial void OnNgayPdChanged();

        [DataMember]
        public virtual string DienGiai
        {
            get { return _DienGiai; }
            set
            {
                OnDienGiaiChanging();
                _DienGiai = value;
                OnDienGiaiChanged();
            }
        }
        partial void OnDienGiaiChanging();
        partial void OnDienGiaiChanged();

        [DataMember]
        public virtual System.Guid PhongbanId
        {
            get { return _PhongbanId; }
            set
            {
                OnPhongbanIdChanging();
                _PhongbanId = value;
                OnPhongbanIdChanged();
            }
        }
        partial void OnPhongbanIdChanging();
        partial void OnPhongbanIdChanged();

        [DataMember]
        public virtual string MaPhongban
        {
            get { return _MaPhongban; }
            set
            {
                OnMaPhongbanChanging();
                _MaPhongban = value;
                OnMaPhongbanChanged();
            }
        }
        partial void OnMaPhongbanChanging();
        partial void OnMaPhongbanChanged();

        [DataMember]
        public virtual string KyHieuPhongban
        {
            get { return _KyHieuPhongban; }
            set
            {
                OnKyHieuPhongbanChanging();
                _KyHieuPhongban = value;
                OnKyHieuPhongbanChanged();
            }
        }
        partial void OnKyHieuPhongbanChanging();
        partial void OnKyHieuPhongbanChanged();

        [DataMember]
        public virtual string TenPhongban
        {
            get { return _TenPhongban; }
            set
            {
                OnTenPhongbanChanging();
                _TenPhongban = value;
                OnTenPhongbanChanged();
            }
        }
        partial void OnTenPhongbanChanging();
        partial void OnTenPhongbanChanged();

        [DataMember]
        public virtual string NguoiNhanNopTien
        {
            get { return _NguoiNhanNopTien; }
            set
            {
                OnNguoiNhanNopTienChanging();
                _NguoiNhanNopTien = value;
                OnNguoiNhanNopTienChanged();
            }
        }
        partial void OnNguoiNhanNopTienChanging();
        partial void OnNguoiNhanNopTienChanged();

        [DataMember]
        public virtual string NguoiGiaoNhanHang
        {
            get { return _NguoiGiaoNhanHang; }
            set
            {
                OnNguoiGiaoNhanHangChanging();
                _NguoiGiaoNhanHang = value;
                OnNguoiGiaoNhanHangChanged();
            }
        }
        partial void OnNguoiGiaoNhanHangChanging();
        partial void OnNguoiGiaoNhanHangChanged();

        [DataMember]
        public virtual System.Guid KhangId
        {
            get { return _KhangId; }
            set
            {
                OnKhangIdChanging();
                _KhangId = value;
                OnKhangIdChanged();
            }
        }
        partial void OnKhangIdChanging();
        partial void OnKhangIdChanged();

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public virtual string MstKhang
        {
            get { return _MstKhang; }
            set
            {
                OnMstKhangChanging();
                _MstKhang = value;
                OnMstKhangChanged();
            }
        }
        partial void OnMstKhangChanging();
        partial void OnMstKhangChanged();

        [DataMember]
        public virtual string DiaChi
        {
            get { return _DiaChi; }
            set
            {
                OnDiaChiChanging();
                _DiaChi = value;
                OnDiaChiChanged();
            }
        }
        partial void OnDiaChiChanging();
        partial void OnDiaChiChanged();

        [DataMember]
        public virtual System.Guid CbnvId
        {
            get { return _CbnvId; }
            set
            {
                OnCbnvIdChanging();
                _CbnvId = value;
                OnCbnvIdChanged();
            }
        }
        partial void OnCbnvIdChanging();
        partial void OnCbnvIdChanged();

        [DataMember]
        public virtual string KyHieuCbnv
        {
            get { return _KyHieuCbnv; }
            set
            {
                OnKyHieuCbnvChanging();
                _KyHieuCbnv = value;
                OnKyHieuCbnvChanged();
            }
        }
        partial void OnKyHieuCbnvChanging();
        partial void OnKyHieuCbnvChanged();

        [DataMember]
        public virtual string MaCbnv
        {
            get { return _MaCbnv; }
            set
            {
                OnMaCbnvChanging();
                _MaCbnv = value;
                OnMaCbnvChanged();
            }
        }
        partial void OnMaCbnvChanging();
        partial void OnMaCbnvChanged();

        [DataMember]
        public virtual string TenCbnv
        {
            get { return _TenCbnv; }
            set
            {
                OnTenCbnvChanging();
                _TenCbnv = value;
                OnTenCbnvChanged();
            }
        }
        partial void OnTenCbnvChanging();
        partial void OnTenCbnvChanged();

        [DataMember]
        public virtual decimal Ghi
        {
            get { return _Ghi; }
            set
            {
                OnGHIChanging();
                _Ghi = value;
                OnGHIChanged();
            }
        }
        partial void OnGHIChanging();
        partial void OnGHIChanged();

        [DataMember]
        public virtual string Attachfile
        {
            get { return _Attachfile; }
            set
            {
                OnATTACHFILEChanging();
                _Attachfile = value;
                OnATTACHFILEChanged();
            }
        }
        partial void OnATTACHFILEChanging();
        partial void OnATTACHFILEChanged();

        [DataMember]
        public virtual decimal NgoaiTe
        {
            get { return _NgoaiTe; }
            set
            {
                OnNgoaiTeChanging();
                _NgoaiTe = value;
                OnNgoaiTeChanged();
            }
        }
        partial void OnNgoaiTeChanging();
        partial void OnNgoaiTeChanged();

        [DataMember]
        public virtual System.Guid DonviCt
        {
            get { return _DonviCt; }
            set
            {
                OnDonviCtChanging();
                _DonviCt = value;
                OnDonviCtChanged();
            }
        }
        partial void OnDonviCtChanging();
        partial void OnDonviCtChanged();

        [DataMember]
        public virtual string MaDonviCt
        {
            get { return _MaDonviCt; }
            set
            {
                OnMaDonviCtChanging();
                _MaDonviCt = value;
                OnMaDonviCtChanged();
            }
        }
        partial void OnMaDonviCtChanging();
        partial void OnMaDonviCtChanged();

        [DataMember]
        public virtual decimal DaKhoaSo
        {
            get { return _DaKhoaSo; }
            set
            {
                OnDaKhoaSoChanging();
                _DaKhoaSo = value;
                OnDaKhoaSoChanged();
            }
        }
        partial void OnDaKhoaSoChanging();
        partial void OnDaKhoaSoChanged();

        [DataMember]
        public virtual System.DateTime NgayKhoaSo
        {
            get { return _NgayKhoaSo; }
            set
            {
                OnNgayKhoaSoChanging();
                _NgayKhoaSo = value;
                OnNgayKhoaSoChanged();
            }
        }
        partial void OnNgayKhoaSoChanging();
        partial void OnNgayKhoaSoChanged();

        [DataMember]
        public virtual decimal BtTudong
        {
            get { return _BtTudong; }
            set
            {
                OnBtTudongChanging();
                _BtTudong = value;
                OnBtTudongChanged();
            }
        }
        partial void OnBtTudongChanging();
        partial void OnBtTudongChanged();

        [DataMember]
        public virtual System.DateTime BxNgay1
        {
            get { return _BxNgay1; }
            set
            {
                OnBxNgay1Changing();
                _BxNgay1 = value;
                OnBxNgay1Changed();
            }
        }
        partial void OnBxNgay1Changing();
        partial void OnBxNgay1Changed();

        [DataMember]
        public virtual System.DateTime BxNgay2
        {
            get { return _BxNgay2; }
            set
            {
                OnBxNgay2Changing();
                _BxNgay2 = value;
                OnBxNgay2Changed();
            }
        }
        partial void OnBxNgay2Changing();
        partial void OnBxNgay2Changed();

        [DataMember]
        public virtual System.DateTime BxNgay3
        {
            get { return _BxNgay3; }
            set
            {
                OnBxNgay3Changing();
                _BxNgay3 = value;
                OnBxNgay3Changed();
            }
        }
        partial void OnBxNgay3Changing();
        partial void OnBxNgay3Changed();

        [DataMember]
        public virtual decimal BxNumber1
        {
            get { return _BxNumber1; }
            set
            {
                OnBxNumber1Changing();
                _BxNumber1 = value;
                OnBxNumber1Changed();
            }
        }
        partial void OnBxNumber1Changing();
        partial void OnBxNumber1Changed();

        [DataMember]
        public virtual decimal BxNumber2
        {
            get { return _BxNumber2; }
            set
            {
                OnBxNumber2Changing();
                _BxNumber2 = value;
                OnBxNumber2Changed();
            }
        }
        partial void OnBxNumber2Changing();
        partial void OnBxNumber2Changed();

        [DataMember]
        public virtual decimal BxNumber3
        {
            get { return _BxNumber3; }
            set
            {
                OnBxNumber3Changing();
                _BxNumber3 = value;
                OnBxNumber3Changed();
            }
        }
        partial void OnBxNumber3Changing();
        partial void OnBxNumber3Changed();

        [DataMember]
        public virtual string BxDiengiai1
        {
            get { return _BxDiengiai1; }
            set
            {
                OnBxDiengiai1Changing();
                _BxDiengiai1 = value;
                OnBxDiengiai1Changed();
            }
        }
        partial void OnBxDiengiai1Changing();
        partial void OnBxDiengiai1Changed();

        [DataMember]
        public virtual string BxDiengiai2
        {
            get { return _BxDiengiai2; }
            set
            {
                OnBxDiengiai2Changing();
                _BxDiengiai2 = value;
                OnBxDiengiai2Changed();
            }
        }
        partial void OnBxDiengiai2Changing();
        partial void OnBxDiengiai2Changed();

        [DataMember]
        public virtual string BxDiengiai3
        {
            get { return _BxDiengiai3; }
            set
            {
                OnBxDiengiai3Changing();
                _BxDiengiai3 = value;
                OnBxDiengiai3Changed();
            }
        }
        partial void OnBxDiengiai3Changing();
        partial void OnBxDiengiai3Changed();

        [DataMember]
        public virtual string SoSeriHd
        {
            get { return _SoSeriHd; }
            set
            {
                OnSoSeriHdChanging();
                _SoSeriHd = value;
                OnSoSeriHdChanged();
            }
        }
        partial void OnSoSeriHdChanging();
        partial void OnSoSeriHdChanged();

        [DataMember]
        public virtual string SoHd
        {
            get { return _SoHd; }
            set
            {
                OnSoHdChanging();
                _SoHd = value;
                OnSoHdChanged();
            }
        }
        partial void OnSoHdChanging();
        partial void OnSoHdChanged();

        [DataMember]
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

        [DataMember]
        public virtual string PrefixCt
        {
            get { return _PrefixCt; }
            set
            {
                OnPrefixCtChanging();
                _PrefixCt = value;
                OnPrefixCtChanged();
            }
        }
        partial void OnPrefixCtChanging();
        partial void OnPrefixCtChanged();

        [DataMember]
        public Decimal? IsDeleted
        {
            get { return _IsDeleted; }
            set
            {
                if (value == null)
                    _IsDeleted = 0;
                else
                    _IsDeleted = value;
            }
        }

        [DataMember]
        public DateTime SynDate
        {
            get { return _SynDate; }
            set { _SynDate = value; }
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
