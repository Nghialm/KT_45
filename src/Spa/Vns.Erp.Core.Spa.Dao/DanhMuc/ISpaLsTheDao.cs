using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Dao
{
	public interface ISpaLsTheDao:IDao<SpaLsThe,string>
	{
        void DeleteByPhieu(Guid Mphieuid);
        void DeleteByThe(Guid Theid);
        IList<SpaLsThe> GetHistoryCard(Guid Theid);
	}
}