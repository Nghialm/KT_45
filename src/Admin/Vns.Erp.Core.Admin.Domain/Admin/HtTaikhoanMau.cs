using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class HtTaikhoanMau : DomainObject<System.Guid>
    {
        public DmTaikhoan GenToDmTaikhoan()
        {
            DmTaikhoan objTaikhoan = new DmTaikhoan();

            objTaikhoan.MaTaikhoan = _MaTaikhoan;
            objTaikhoan.TenTaikhoan = _TenTaikhoan;
            objTaikhoan.TinhChat = _TinhChat;
            objTaikhoan.TkNb = _TkNb;
            objTaikhoan.Cap = _Cap;
            objTaikhoan.ChiTiet = _ChiTiet;
            objTaikhoan.ChoPhepSua = _ChoPhepSua;
            objTaikhoan.CoSuDung = _CoSuDung;
            objTaikhoan.InBcd = _InBcd;
            objTaikhoan.MoTa = _MoTa;

            return objTaikhoan;
        }
	}
}