using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Dao
{
	public interface ICtDHddvDao:IDao<CtDHddv,System.Guid>
	{
        IList<CtDHddv> GetCtdBycth(Guid CTH_HDDV_ID);
        IList<CtDHddv> GetCtdByLoaiNV(Guid cthId, int LoaiNghiepVu);
        Boolean DeleteByCtH(Guid CthHddvId);
	}
}