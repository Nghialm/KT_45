using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtCtDHddvService:GenericService<KtCtDHddv,System.Guid>, IKtCtDHddvService
	{
	    public IKtCtDHddvDao KtCtDHddvDao
        {
            get { return (IKtCtDHddvDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtCtDHddv> GetByCtHandNghiepVu(Guid CthId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CthHddvId");
            values.Add(CthId);
            
            return List(-1, -1, props, values, null);
        }
	}
}