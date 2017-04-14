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
	public class AppGroupFormsService:GenericService<AppGroupForms,Guid>, IAppGroupFormsService
	{
	     public IAppGroupFormsDao AppGroupFormsDao
        {
            get { return (IAppGroupFormsDao)Dao; }
            set { Dao = value; }
        }
         #region "BO Functions"

         public AppGroupForms GetByFormId(Guid FORMS_ID)
         {
             return AppGroupFormsDao.GetByKey("FormsId", FORMS_ID);
         }

         public IList<AppGroupForms> GetByGroupId(Guid GROUP_ID)
         {
             ArrayList props = new ArrayList();
             ArrayList values = new ArrayList();
             props.Add("GroupId");
             values.Add(GROUP_ID);
             return AppGroupFormsDao.List(-1, -1, props, values, null);   
         }

         public IList<AppGroupForms> GetByOption(Guid GROUP_ID, Guid FORMS_ID)
         {
             ArrayList props = new ArrayList();
             ArrayList values = new ArrayList();
             props.Add("GroupId");
             values.Add(GROUP_ID);
             props.Add("FormId");
             values.Add(FORMS_ID);
             return AppGroupFormsDao.List(-1, -1, props, values, null);               
         }



         public void DeleteById(Guid GROUP_ID, Guid FORMS_ID)
         {
             AppGroupFormsDao.DeleteById(GROUP_ID, FORMS_ID);
         }
         #endregion
	}
}
