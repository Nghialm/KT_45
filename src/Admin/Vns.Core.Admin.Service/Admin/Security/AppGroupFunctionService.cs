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
using Vns.Erp.Core.Domain;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class AppGroupFunctionService:GenericService<AppGroupFunction,Guid>, IAppGroupFunctionService
	{
	    public IAppGroupFunctionDao AppGroupFunctionDao
        {
            get { return (IAppGroupFunctionDao)Dao; }
            set { Dao = value; }
        }
        public AppGroupFunction GetByGroupId(Guid GROUP_ID)
        {
            return AppGroupFunctionDao.GetByKey("GroupId",GROUP_ID);
        }

        public IList<AppGroupFunction> GetByPId(Guid PARENT_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("ParentId");
            values.Add(PARENT_ID);

            IList<VnsOrder> lstOrder = new List<VnsOrder>();
            lstOrder.Add(new VnsOrder(true, "GroupOrder"));
            return AppGroupFunctionDao.List(-1, -1, props, values, lstOrder);
        }
	}
}
