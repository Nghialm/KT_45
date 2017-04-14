using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtStatusCtService:GenericService<KtStatusCt,decimal>, IKtStatusCtService
	{
	     public IKtStatusCtDao KtStatusCtDao
        {
            get { return (IKtStatusCtDao)Dao; }
            set { Dao = value; }
        }
	}
}
