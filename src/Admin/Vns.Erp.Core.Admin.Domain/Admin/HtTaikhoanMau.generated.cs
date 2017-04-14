using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class HtTaikhoanMau : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _MaTaikhoan = String.Empty;
        private string _TenTaikhoan = String.Empty;
        private string _MoTa = String.Empty;
        private string _TinhChat = String.Empty;
		private System.Guid _TaikhoanIdCha = new Guid();
		private decimal _ChiTiet = 0;
		private decimal _InBcd = 0;
		private decimal _TkNb = 0;
		private decimal _ChoPhepSua = 0;
		private decimal _CoSuDung = 0;
		private decimal _Cap = 0;
		private decimal _Loai = 0;
		
		
		
        #endregion

        #region Constructors

        public HtTaikhoanMau() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_MaTaikhoan);
			sb.Append(_TenTaikhoan);
			sb.Append(_MoTa);
			sb.Append(_TinhChat);
			sb.Append(_TaikhoanIdCha);
			sb.Append(_ChiTiet);
			sb.Append(_InBcd);
			sb.Append(_TkNb);
			sb.Append(_ChoPhepSua);
			sb.Append(_CoSuDung);
			sb.Append(_Cap);
			sb.Append(_Loai);

            return sb.ToString().GetHashCode();
        }
		
		public HtTaikhoanMau Clone()
        {
            return (HtTaikhoanMau)this.MemberwiseClone();
        }
		
		public void SetProperty(HtTaikhoanMau des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_MaTaikhoan = des.MaTaikhoan;
			_TenTaikhoan = des.TenTaikhoan;
			_MoTa = des.MoTa;
			_TinhChat = des.TinhChat;
			_TaikhoanIdCha = des.TaikhoanIdCha;
			_ChiTiet = des.ChiTiet;
			_InBcd = des.InBcd;
			_TkNb = des.TkNb;
			_ChoPhepSua = des.ChoPhepSua;
			_CoSuDung = des.CoSuDung;
			_Cap = des.Cap;
			_Loai = des.Loai;
		}

        #endregion

        #region Properties

		public virtual string MaTaikhoan
        {
            get { return _MaTaikhoan; }
			set
			{
				OnMaTaikhoanChanging();
				_MaTaikhoan = value;
				OnMaTaikhoanChanged();
			}
        }
		partial void OnMaTaikhoanChanging();
		partial void OnMaTaikhoanChanged();
		
		public virtual string TenTaikhoan
        {
            get { return _TenTaikhoan; }
			set
			{
				OnTenTaikhoanChanging();
				_TenTaikhoan = value;
				OnTenTaikhoanChanged();
			}
        }
		partial void OnTenTaikhoanChanging();
		partial void OnTenTaikhoanChanged();
		
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
		
		public virtual string TinhChat
        {
            get { return _TinhChat; }
			set
			{
				OnTinhChatChanging();
				_TinhChat = value;
				OnTinhChatChanged();
			}
        }
		partial void OnTinhChatChanging();
		partial void OnTinhChatChanged();
		
		public virtual System.Guid TaikhoanIdCha
        {
            get { return _TaikhoanIdCha; }
			set
			{
				OnTaikhoanIdChaChanging();
				_TaikhoanIdCha = value;
				OnTaikhoanIdChaChanged();
			}
        }
		partial void OnTaikhoanIdChaChanging();
		partial void OnTaikhoanIdChaChanged();
		
		public virtual decimal ChiTiet
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
		
		public virtual decimal InBcd
        {
            get { return _InBcd; }
			set
			{
				OnInBcdChanging();
				_InBcd = value;
				OnInBcdChanged();
			}
        }
		partial void OnInBcdChanging();
		partial void OnInBcdChanged();
		
		public virtual decimal TkNb
        {
            get { return _TkNb; }
			set
			{
				OnTkNbChanging();
				_TkNb = value;
				OnTkNbChanged();
			}
        }
		partial void OnTkNbChanging();
		partial void OnTkNbChanged();
		
		public virtual decimal ChoPhepSua
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
		
		public virtual decimal CoSuDung
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
		
		public virtual decimal Cap
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
		
		public virtual decimal Loai
        {
            get { return _Loai; }
			set
			{
				OnLoaiChanging();
				_Loai = value;
				OnLoaiChanged();
			}
        }
		partial void OnLoaiChanging();
		partial void OnLoaiChanged();
		
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
