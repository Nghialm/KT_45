using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class KtKhoaSoNgay : DomainObject<System.Guid>
    {
        #region Declarations

		
		private System.DateTime _NgayKhoaSo = new DateTime();
		private System.Guid _DonViId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public KtKhoaSoNgay() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_NgayKhoaSo);
			sb.Append(_DonViId);

            return sb.ToString().GetHashCode();
        }
		
		public KtKhoaSoNgay Clone()
        {
            return (KtKhoaSoNgay)this.MemberwiseClone();
        }
		
		public void SetProperty(KtKhoaSoNgay des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_NgayKhoaSo = des.NgayKhoaSo;
			_DonViId = des.DonViId;
		}

        #endregion

        #region Properties

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
		
		public virtual System.Guid DonViId
        {
            get { return _DonViId; }
			set
			{
				OnDonViIdChanging();
				_DonViId = value;
				OnDonViIdChanged();
			}
        }
		partial void OnDonViIdChanging();
		partial void OnDonViIdChanged();
		
        #endregion
		
		
    }
}
