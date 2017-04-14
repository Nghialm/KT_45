using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxPhancong : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _KehoachMId = new Guid();
		private System.Guid _QuytrinhId = new Guid();
		private int _ThuTu = 0;
		private System.Guid _LenhsanxuatId = new Guid();
		private System.Guid _SanphamId = new Guid();
		private decimal _SoLuong = 0;
		private System.Guid _DvtId = new Guid();
        private System.Guid _ToPhanCongId = new Guid();
        private String _GhiChu = String.Empty;
        private String _SoLenhSanXuat = String.Empty;
        #endregion

        #region Constructors

        public SxPhancong() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_KehoachMId);
			sb.Append(_QuytrinhId);
			sb.Append(_ThuTu);
			sb.Append(_LenhsanxuatId);
			sb.Append(_SanphamId);
			sb.Append(_SoLuong);
			sb.Append(_DvtId);
            sb.Append(_ToPhanCongId);
            sb.Append(_GhiChu);
            sb.Append(_SoLenhSanXuat);            
            return sb.ToString().GetHashCode();
        }
		
		public SxPhancong Clone()
        {
            return (SxPhancong)this.MemberwiseClone();
        }
		
		public void SetProperty(SxPhancong des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_KehoachMId = des.KehoachMId;
			_QuytrinhId = des.QuytrinhId;
			_ThuTu = des.ThuTu;
			_LenhsanxuatId = des.LenhsanxuatId;
			_SanphamId = des.SanphamId;
			_SoLuong = des.SoLuong;
			_DvtId = des.DvtId;
            _ToPhanCongId = des.ToPhanCongId;
            _GhiChu = des.GhiChu;
            _SoLenhSanXuat = des.SoLenhSanXuat;
		}

        #endregion

        #region Properties

		public virtual System.Guid KehoachMId
        {
            get { return _KehoachMId; }
			set
			{
				OnKehoachMIdChanging();
				_KehoachMId = value;
				OnKehoachMIdChanged();
			}
        }
		partial void OnKehoachMIdChanging();
		partial void OnKehoachMIdChanged();

        public virtual System.Guid ToPhanCongId
        {
            get { return _ToPhanCongId; }
            set
            {
                OnToPhanCongIdChanging();
                _ToPhanCongId = value;
                OnToPhanCongIdChanged();
            }
        }
        partial void OnToPhanCongIdChanging();
        partial void OnToPhanCongIdChanged();
		
		public virtual System.Guid QuytrinhId
        {
            get { return _QuytrinhId; }
			set
			{
				OnQuytrinhIdChanging();
				_QuytrinhId = value;
				OnQuytrinhIdChanged();
			}
        }
		partial void OnQuytrinhIdChanging();
		partial void OnQuytrinhIdChanged();
		
		public virtual int ThuTu
        {
            get { return _ThuTu; }
			set
			{
				OnThuTuChanging();
				_ThuTu = value;
				OnThuTuChanged();
			}
        }
		partial void OnThuTuChanging();
		partial void OnThuTuChanged();
		
		public virtual System.Guid LenhsanxuatId
        {
            get { return _LenhsanxuatId; }
			set
			{
				OnLenhsanxuatIdChanging();
				_LenhsanxuatId = value;
				OnLenhsanxuatIdChanged();
			}
        }
		partial void OnLenhsanxuatIdChanging();
		partial void OnLenhsanxuatIdChanged();
		
		public virtual System.Guid SanphamId
        {
            get { return _SanphamId; }
			set
			{
				OnSanphamIdChanging();
				_SanphamId = value;
				OnSanphamIdChanged();
			}
        }
		partial void OnSanphamIdChanging();
		partial void OnSanphamIdChanged();
		
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


        public virtual string SoLenhSanXuat
        {
            get { return _SoLenhSanXuat; }
            set
            {
                OnSoLenhSanXuatChanging();
                _SoLenhSanXuat = value;
                OnSoLenhSanXuatChanged();
            }
        }
        partial void OnSoLenhSanXuatChanging();
        partial void OnSoLenhSanXuatChanged();

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
