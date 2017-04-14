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
	public class AppDvFormService:GenericService<AppDvForm,decimal>, IAppDvFormService
	{
	     public IAppDvFormDao AppDvFormDao
        {
            get { return (IAppDvFormDao)Dao; }
            set { Dao = value; }
        }
         #region "BO Functions"
         public IList<AppDvForm> GetByDV(Guid DV_ID)
         {
             ArrayList props = new ArrayList();
             ArrayList values = new ArrayList();
             props.Add("DvId");
             values.Add(DV_ID);
             return AppDvFormDao.List(-1, -1, props, values, null);             
         }

         public void DeleteByForm(decimal FORM_ID)
         {
             AppDvFormDao.DeleteByForm(FORM_ID);
         }

         public void DeleteByDVF(Guid DV_ID, decimal FORM_ID)
         {
             AppDvFormDao.DeleteByDVF(DV_ID, FORM_ID);
         }
         public IList<AppGroupForms> GetByDonviID(Guid DonviID)
         {
             return AppDvFormDao.GetByDonviID(DonviID);
         }
         #endregion
	}
}
