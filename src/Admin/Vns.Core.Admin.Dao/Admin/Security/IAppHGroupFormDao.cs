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
    public interface IAppHGroupFormDao : IDao<AppHGroupForm, Guid>
	{
        void DeleteByGroup(Guid GroupId);
        void DeleteByGroupForm(Guid GroupId, Guid FormId);
	}
}