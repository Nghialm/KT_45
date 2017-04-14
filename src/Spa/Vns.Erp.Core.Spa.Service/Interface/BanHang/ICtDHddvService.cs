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
	public interface ICtDHddvService:IErpService<CtDHddv, System.Guid>
	{
        IList<CtDHddv> GetCtdBycth(Guid CTH_HDDV_ID);
        IList<CtDHddv> GetCtdByLoaiNV(Guid cthId, int LoaiNghiepVu);
	}
}
