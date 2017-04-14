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
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AppDvGroupFormService : GenericService<AppDvGroupForm, Guid>, IAppDvGroupFormService
	{
	    public IAppDvGroupFormDao AppDvGroupFormDao
        {
            get { return (IAppDvGroupFormDao)Dao; }
            set { Dao = value; }
        }

        #region "BO Functions"

        public IList<AppDvGroupForm> GetByDV(Guid DV_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            values.Add(DV_ID);
            return AppDvGroupFormDao.List(-1, -1, props,values, null);  
        }

        [Transaction]
        public void DeleteByFormId(Guid FORM_ID)
        {
            AppDvGroupFormDao.DeleteByFormId(FORM_ID);
        }

        [Transaction]
        public void DeleteByGroup(Guid groupid)
        {
            AppDvGroupFormDao.DeleteByGroupId(groupid); ;
        }

        public IList<AppDvGroupForm> GetByDVG(Guid donvi_id, Guid group_id)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            values.Add(donvi_id);
            props.Add("GroupId");
            values.Add(group_id);
            return AppDvGroupFormDao.List(-1, -1, props, values, null);  
        }
        [Transaction]
        public void DeleteByDVF(Guid DonViId, Guid FormId)
        {
            AppDvGroupFormDao.DeleteByDVF(DonViId, FormId);
        }
        [Transaction]
        public void DeleteByDVGF(Guid DonViId, Guid GroupId, Guid FormId)
        {
            AppDvGroupFormDao.DeleteByDVGF(DonViId, GroupId, FormId);
        }
        [Transaction]
        public void DeleteByF(Guid FormId)
        {
            AppDvGroupFormDao.DeleteByF(FormId);
        }
        #endregion
    }
}
