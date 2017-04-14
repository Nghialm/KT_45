using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AppDvGroupBcService : GenericService<AppDvGroupBc, Guid>, IAppDvGroupBcService
	{
	    public IAppDvGroupBcDao AppDvGroupBcDao
        {
            get { return (IAppDvGroupBcDao)Dao; }
            set { Dao = value; }
        }

        public IList<HtBaocao> GetBCByDV(Guid DV_ID)
        {
            return AppDvGroupBcDao.GetBCByDV(DV_ID);
        }

        public IList<HtBaocao> GetBCByDVU(Guid DV_ID, Guid USER_ID)
        {
            return AppDvGroupBcDao.GetBCByDVU(DV_ID, USER_ID);
        }

        public IList<AppDvGroupBc> GetByDV(Guid DV_ID)
        {
            return AppDvGroupBcDao.GetByDV(DV_ID);
        }

        public IList<AppDvGroupBc> GetByDVG(Guid DV_ID, Guid GROUP_ID)
        {
            return AppDvGroupBcDao.GetByDVG(DV_ID, GROUP_ID);
        }

        public void DeleteByDVB(Guid DV_ID, Guid BC_ID)
        {
            AppDvGroupBcDao.DeleteByDVB(DV_ID, BC_ID);
        }

        public void DeleteByDGB(Guid DV_ID, Guid GROUP_ID, Guid BC_ID)
        {
            AppDvGroupBcDao.DeleteByDGB(DV_ID, GROUP_ID, BC_ID);
        }
	}
}
