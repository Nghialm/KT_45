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
	public class AppUgFormService:GenericService<AppUgForm,Guid>, IAppUgFormService
	{
	     public IAppUgFormDao AppUgFormDao
        {
            get { return (IAppUgFormDao)Dao; }
            set { Dao = value; }
        }

         public void DeleteByGF(Guid GROUP_ID, Guid FORM_ID)
         {
             AppUgFormDao.DeleteByGF(GROUP_ID, FORM_ID);
         }

         public void DeleteByFormID(Guid FormId)
         {
             AppUgFormDao.DeleteByFormID(FormId);
         }

         public void DeleteByGroup(Guid GroupId)
         {
             AppUgFormDao.DeleteByGroup(GroupId);
         }

         public IList<AppUgForm> GetByGroupId(Guid GROUP_ID)
         {
             return AppUgFormDao.GetByGroupId(GROUP_ID);
         }
	}
}
