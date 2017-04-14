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
using System.Collections.Generic;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtHBaocaoService:GenericService<KtHBaocao,System.Guid>, IKtHBaocaoService
	{
	    public IKtHBaocaoDao KtHBaocaoDao
        {
            get { return (IKtHBaocaoDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtHBaocao> GetAllSort()
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            ArrayList expressions = new ArrayList();

            IList<VnsOrder> lstorder = new List<VnsOrder>();
            lstorder.Add(new VnsOrder(true, "Title"));

            return KtHBaocaoDao.List(-1, -1, null, null, lstorder);
        }
	}
}