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
	public class TsDieuchuyenService:GenericService<TsDieuchuyen,System.Guid>, ITsDieuchuyenService
	{
	    public ITsDieuchuyenDao TsDieuchuyenDao
        {
            get { return (ITsDieuchuyenDao)Dao; }
            set { Dao = value; }
        }

        public IList<TsDieuchuyen> GetObjectByTSCD_ID(Guid TscdId)
        {
            return TsDieuchuyenDao.GetObjectByTSCD_ID(TscdId);
        }
	}
}