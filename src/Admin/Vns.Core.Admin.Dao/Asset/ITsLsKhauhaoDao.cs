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
	public interface ITsLsKhauhaoDao:IDao<TsLsKhauhao,System.Guid>
	{
        IList<TsLsKhauhao> GetByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
        void DeleteByThangNam_TscdId(Decimal Thang, Decimal Nam, Guid DmTscdId);
        void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
	}
}