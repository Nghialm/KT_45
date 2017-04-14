using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Spa.Service.Interface
{
	public interface ISpaBangLuongService:IErpService<SpaBangLuong, string>
	{
        IList<SpaBangLuong> BangLuongThang(Guid DonViId, DateTime ThangLuong, Guid NhanVienId);
        Boolean SaveBangLuongThang(IList<SpaBangLuong> lstBangLuong, DateTime ThangLuong);
        Boolean DeleteBangLuongThang(DateTime ThangLuong);
	}
}
