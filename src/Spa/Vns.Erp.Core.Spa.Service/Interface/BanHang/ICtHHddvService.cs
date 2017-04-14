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
	public interface ICtHHddvService:IErpService<CtHHddv, System.Guid>
	{
        IList<CtHHddv> GetCthByDonViID(Guid DonviId);
        IList<CtHHddv> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, int SoCTHienThi);
        Boolean DeleteChungTu(CtHHddv objCtH);
        Boolean SaveChungTu(CtHHddv objCtH, IList<CtDHddv> lst_hh, IList<CtDHddv> lst_dv, IList<CtDHddv> lst_del);

	}
}
