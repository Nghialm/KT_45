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
    public interface IAppDvBcDao : IDao<AppDvBc, Guid>
	{
        IList<AppDvBc> GetByDV(Guid DV_ID);
        IList<HtBaocao> GetBCByDV(Guid DV_ID);
        void DeleteByBC(decimal BC_ID);
        void DeleteByDVBC(Guid DV_ID, decimal BC_ID);
	}
}