using System;
using System.Collections;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class CcCtCcdcNvon : DomainObject<System.Guid>
    {
        #region Declarations

		
		private System.Guid _CtCcdcId = new Guid();
		private System.Guid _DmNguonTscdId = new Guid();
		private decimal _SoTien = 0;
		private decimal _SoTienNte = 0;
		private decimal _NguyenGia = 0;
		private decimal _GiaTriConLai = 0;
		private decimal _HaoMonLuyKe = 0;
		private decimal _TyLeHaoMon = 0;
		private System.Guid _LyDoTanggiam = new Guid();
		private string _TenLyDoTanggiam = String.Empty;
		private string _DienGiai = String.Empty;
		private decimal _TangCcdc = 0;
		private decimal _HeSoPbKh = 0;
		private System.Guid _TkCcdc = new Guid();
		private System.Guid _TkChiphi = new Guid();
		private string _MaTkCcdc = String.Empty;
		private string _MaTkChiphi = String.Empty;
		private System.Guid _TkPhanbo = new Guid();
		private string _MaTkPhanbo = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public CcCtCcdcNvon() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_CtCcdcId);
			sb.Append(_DmNguonTscdId);
			sb.Append(_SoTien);
			sb.Append(_SoTienNte);
			sb.Append(_NguyenGia);
			sb.Append(_GiaTriConLai);
			sb.Append(_HaoMonLuyKe);
			sb.Append(_TyLeHaoMon);
			sb.Append(_LyDoTanggiam);
			sb.Append(_TenLyDoTanggiam);
			sb.Append(_DienGiai);
			sb.Append(_TangCcdc);
			sb.Append(_HeSoPbKh);
			sb.Append(_TkCcdc);
			sb.Append(_TkChiphi);
			sb.Append(_MaTkCcdc);
			sb.Append(_MaTkChiphi);
			sb.Append(_TkPhanbo);
			sb.Append(_MaTkPhanbo);

            return sb.ToString().GetHashCode();
        }
		
		public CcCtCcdcNvon Clone()
        {
            return (CcCtCcdcNvon)this.MemberwiseClone();
        }
		
		public void SetProperty(CcCtCcdcNvon des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_CtCcdcId = des.CtCcdcId;
			_DmNguonTscdId = des.DmNguonTscdId;
			_SoTien = des.SoTien;
			_SoTienNte = des.SoTienNte;
			_NguyenGia = des.NguyenGia;
			_GiaTriConLai = des.GiaTriConLai;
			_HaoMonLuyKe = des.HaoMonLuyKe;
			_TyLeHaoMon = des.TyLeHaoMon;
			_LyDoTanggiam = des.LyDoTanggiam;
			_TenLyDoTanggiam = des.TenLyDoTanggiam;
			_DienGiai = des.DienGiai;
			_TangCcdc = des.TangCcdc;
			_HeSoPbKh = des.HeSoPbKh;
			_TkCcdc = des.TkCcdc;
			_TkChiphi = des.TkChiphi;
			_MaTkCcdc = des.MaTkCcdc;
			_MaTkChiphi = des.MaTkChiphi;
			_TkPhanbo = des.TkPhanbo;
			_MaTkPhanbo = des.MaTkPhanbo;
		}

        #endregion

        #region Properties

		public virtual System.Guid CtCcdcId
        {
            get { return _CtCcdcId; }
			set
			{
				OnCtCcdcIdChanging();
				_CtCcdcId = value;
				OnCtCcdcIdChanged();
			}
        }
		partial void OnCtCcdcIdChanging();
		partial void OnCtCcdcIdChanged();
		
		public virtual System.Guid DmNguonTscdId
        {
            get { return _DmNguonTscdId; }
			set
			{
				OnDmNguonTscdIdChanging();
				_DmNguonTscdId = value;
				OnDmNguonTscdIdChanged();
			}
        }
		partial void OnDmNguonTscdIdChanging();
		partial void OnDmNguonTscdIdChanged();
		
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
		
		public virtual decimal NguyenGia
        {
            get { return _NguyenGia; }
			set
			{
				OnNguyenGiaChanging();
				_NguyenGia = value;
				OnNguyenGiaChanged();
			}
        }
		partial void OnNguyenGiaChanging();
		partial void OnNguyenGiaChanged();
		
		public virtual decimal GiaTriConLai
        {
            get { return _GiaTriConLai; }
			set
			{
				OnGiaTriConLaiChanging();
				_GiaTriConLai = value;
				OnGiaTriConLaiChanged();
			}
        }
		partial void OnGiaTriConLaiChanging();
		partial void OnGiaTriConLaiChanged();
		
		public virtual decimal HaoMonLuyKe
        {
            get { return _HaoMonLuyKe; }
			set
			{
				OnHaoMonLuyKeChanging();
				_HaoMonLuyKe = value;
				OnHaoMonLuyKeChanged();
			}
        }
		partial void OnHaoMonLuyKeChanging();
		partial void OnHaoMonLuyKeChanged();
		
		public virtual decimal TyLeHaoMon
        {
            get { return _TyLeHaoMon; }
			set
			{
				OnTyLeHaoMonChanging();
				_TyLeHaoMon = value;
				OnTyLeHaoMonChanged();
			}
        }
		partial void OnTyLeHaoMonChanging();
		partial void OnTyLeHaoMonChanged();
		
		public virtual System.Guid LyDoTanggiam
        {
            get { return _LyDoTanggiam; }
			set
			{
				OnLyDoTanggiamChanging();
				_LyDoTanggiam = value;
				OnLyDoTanggiamChanged();
			}
        }
		partial void OnLyDoTanggiamChanging();
		partial void OnLyDoTanggiamChanged();
		
		public virtual string TenLyDoTanggiam
        {
            get { return _TenLyDoTanggiam; }
			set
			{
				OnTenLyDoTanggiamChanging();
				_TenLyDoTanggiam = value;
				OnTenLyDoTanggiamChanged();
			}
        }
		partial void OnTenLyDoTanggiamChanging();
		partial void OnTenLyDoTanggiamChanged();
		
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
		
		public virtual decimal TangCcdc
        {
            get { return _TangCcdc; }
			set
			{
				OnTangCcdcChanging();
				_TangCcdc = value;
				OnTangCcdcChanged();
			}
        }
		partial void OnTangCcdcChanging();
		partial void OnTangCcdcChanged();
		
		public virtual decimal HeSoPbKh
        {
            get { return _HeSoPbKh; }
			set
			{
				OnHeSoPbKhChanging();
				_HeSoPbKh = value;
				OnHeSoPbKhChanged();
			}
        }
		partial void OnHeSoPbKhChanging();
		partial void OnHeSoPbKhChanged();
		
		public virtual System.Guid TkCcdc
        {
            get { return _TkCcdc; }
			set
			{
				OnTkCcdcChanging();
				_TkCcdc = value;
				OnTkCcdcChanged();
			}
        }
		partial void OnTkCcdcChanging();
		partial void OnTkCcdcChanged();
		
		public virtual System.Guid TkChiphi
        {
            get { return _TkChiphi; }
			set
			{
				OnTkChiphiChanging();
				_TkChiphi = value;
				OnTkChiphiChanged();
			}
        }
		partial void OnTkChiphiChanging();
		partial void OnTkChiphiChanged();
		
		public virtual string MaTkCcdc
        {
            get { return _MaTkCcdc; }
			set
			{
				OnMaTkCcdcChanging();
				_MaTkCcdc = value;
				OnMaTkCcdcChanged();
			}
        }
		partial void OnMaTkCcdcChanging();
		partial void OnMaTkCcdcChanged();
		
		public virtual string MaTkChiphi
        {
            get { return _MaTkChiphi; }
			set
			{
				OnMaTkChiphiChanging();
				_MaTkChiphi = value;
				OnMaTkChiphiChanged();
			}
        }
		partial void OnMaTkChiphiChanging();
		partial void OnMaTkChiphiChanged();
		
		public virtual System.Guid TkPhanbo
        {
            get { return _TkPhanbo; }
			set
			{
				OnTkPhanboChanging();
				_TkPhanbo = value;
				OnTkPhanboChanged();
			}
        }
		partial void OnTkPhanboChanging();
		partial void OnTkPhanboChanged();
		
		public virtual string MaTkPhanbo
        {
            get { return _MaTkPhanbo; }
			set
			{
				OnMaTkPhanboChanging();
				_MaTkPhanbo = value;
				OnMaTkPhanboChanged();
			}
        }
		partial void OnMaTkPhanboChanging();
		partial void OnMaTkPhanboChanged();
		
        #endregion
		
		
    }
}
