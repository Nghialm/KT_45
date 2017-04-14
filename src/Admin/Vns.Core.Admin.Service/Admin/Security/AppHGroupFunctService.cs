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
    public class AppHGroupFunctService : GenericService<AppHGroupFunct, Guid>, IAppHGroupFunctService
    {
        public IAppHGroupFunctDao AppHGroupFunctDao
        {
            get { return (IAppHGroupFunctDao)Dao; }
            set { Dao = value; }
        }

        public IList<AppHGroupFunct> GetByParent(Guid parrentid)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("ParentId");
            values.Add(parrentid);
            return AppHGroupFunctDao.List(-1, -1, props, values, null);
        }
    }
}
