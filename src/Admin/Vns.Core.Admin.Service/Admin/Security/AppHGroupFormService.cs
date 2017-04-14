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
    public class AppHGroupFormService : GenericService<AppHGroupForm, Guid>, IAppHGroupFormService
    {
        public IAppHGroupFormDao AppHGroupFormDao
        {
            get { return (IAppHGroupFormDao)Dao; }
            set { Dao = value; }
        }

        public void DeleteByGroup(Guid GroupId)
        {
            AppHGroupFormDao.DeleteByGroup(GroupId);
        }

        public void DeleteByGroupForm(Guid GroupId, Guid FormId)
        {
            AppHGroupFormDao.DeleteByGroupForm(GroupId, FormId);
        }

        public IList<AppHGroupForm> GetByGroup(Guid GroupId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("GroupId");
            values.Add(GroupId);
            return AppHGroupFormDao.List(-1, -1, props, values, null);
        }

    }
}
