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
	public interface IAppDvGroupFormDao:IDao<AppDvGroupForm,Guid>
	{
        void DeleteByGroupId(Guid GroupId);
        void DeleteByFormId(Guid FORM_ID);
        void DeleteByDVGF(Guid DonViId, Guid GroupId, Guid FormId);
        void DeleteByDVF(Guid DonViId, Guid FormId);
        void DeleteByF(Guid FormId);
	}
}