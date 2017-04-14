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
	public interface IAppUgFormDao:IDao<AppUgForm,Guid>
	{
        void DeleteByGF(Guid GROUP_ID, Guid FORM_ID);
        void DeleteByFormID(Guid FormId);
        void DeleteByGroup(Guid GroupId);
        IList<AppUgForm> GetByGroupId(Guid GROUP_ID);
	}
}