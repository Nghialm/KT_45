using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Dao
{
	public interface IHtSoChungtuMaxDao:IDao<HtSoChungtuMax,System.Guid>
	{
        HtSoChungtuMax GetByThangNamEtc(Guid LOAICHUNGTU_ID, Decimal THANG, Decimal NAM, Guid DONVI_ID);
	}
}