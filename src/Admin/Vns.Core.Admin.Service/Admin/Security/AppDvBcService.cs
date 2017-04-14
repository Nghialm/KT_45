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
    public class AppDvBcService : GenericService<AppDvBc, Guid>, IAppDvBcService
	{
	    public IAppDvBcDao AppDvBcDao
        {
            get { return (IAppDvBcDao)Dao; }
            set { Dao = value; }
        }
        public IList<AppDvBc> GetByDV(Guid DV_ID)
        {
            return AppDvBcDao.GetByDV(DV_ID);
        }

        public IList<HtBaocao> GetBCByDV(Guid DV_ID)
        {
            return AppDvBcDao.GetBCByDV(DV_ID);
        }
        public void DeleteByBC(decimal BC_ID)
        {
            AppDvBcDao.DeleteByBC(BC_ID);
        }

        public void DeleteByDVBC(Guid DV_ID, decimal BC_ID)
        {
            AppDvBcDao.DeleteByDVBC(DV_ID, BC_ID);
        }
	}
}
