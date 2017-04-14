using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Dao
{
	public interface IAppDvFormDao:IDao<AppDvForm,decimal>
	{        
        void DeleteByForm(decimal FORM_ID);
        void DeleteByDVF(Guid DV_ID, decimal FormId);
        IList<AppGroupForms> GetByDonviID(Guid DonviID);
	}
}