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
    public interface IAppDvGroupBcDao : IDao<AppDvGroupBc, Guid>
	{
        IList<HtBaocao> GetBCByDV(Guid DV_ID);
        IList<HtBaocao> GetBCByDVU(Guid DV_ID, Guid USER_ID);
        IList<AppDvGroupBc> GetByDV(Guid DV_ID);
        IList<AppDvGroupBc> GetByDVG(Guid DV_ID, Guid GROUP_ID);
        void DeleteByDVB(Guid DV_ID, Guid BC_ID);
        void DeleteByDGB(Guid DV_ID, Guid GROUP_ID, Guid BC_ID);
	}
}