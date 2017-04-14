using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class SxDmQuytrinh : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _MaQuytrinh = String.Empty;
		private string _KyHieu = String.Empty;
		private string _TenQuytrinh = String.Empty;
		private string _MoTa = String.Empty;
		private int _CoSuDung = 0;
		private int _ChoPhepSua = 0;
		private System.Guid _DonviId = new Guid();
		private string _MaDonvi = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public SxDmQuytrinh() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_MaQuytrinh);
			sb.Append(_KyHieu);
			sb.Append(_TenQuytrinh);
			sb.Append(_MoTa);
			sb.Append(_CoSuDung);
			sb.Append(_ChoPhepSua);
			sb.Append(_DonviId);
			sb.Append(_MaDonvi);

            return sb.ToString().GetHashCode();
        }
		
		public SxDmQuytrinh Clone()
        {
            return (SxDmQuytrinh)this.MemberwiseClone();
        }
		
		public void SetProperty(SxDmQuytrinh des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_MaQuytrinh = des.MaQuytrinh;
			_KyHieu = des.KyHieu;
			_TenQuytrinh = des.TenQuytrinh;
			_MoTa = des.MoTa;
			_CoSuDung = des.CoSuDung;
			_ChoPhepSua = des.ChoPhepSua;
			_DonviId = des.DonviId;
			_MaDonvi = des.MaDonvi;
		}

        #endregion

        #region Properties

		public virtual string MaQuytrinh
        {
            get { return _MaQuytrinh; }
			set
			{
				OnMaQuytrinhChanging();
				_MaQuytrinh = value;
				OnMaQuytrinhChanged();
			}
        }
		partial void OnMaQuytrinhChanging();
		partial void OnMaQuytrinhChanged();
		
		public virtual string KyHieu
        {
            get { return _KyHieu; }
			set
			{
				OnKyHieuChanging();
				_KyHieu = value;
				OnKyHieuChanged();
			}
        }
		partial void OnKyHieuChanging();
		partial void OnKyHieuChanged();
		
		public virtual string TenQuytrinh
        {
            get { return _TenQuytrinh; }
			set
			{
				OnTenQuytrinhChanging();
				_TenQuytrinh = value;
				OnTenQuytrinhChanged();
			}
        }
		partial void OnTenQuytrinhChanging();
		partial void OnTenQuytrinhChanged();
		
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
		
		public virtual int CoSuDung
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
		
		public virtual int ChoPhepSua
        {
            get { return _ChoPhepSua; }
			set
			{
				OnChoPhepSuaChanging();
				_ChoPhepSua = value;
				OnChoPhepSuaChanged();
			}
        }
		partial void OnChoPhepSuaChanging();
		partial void OnChoPhepSuaChanged();
		
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
