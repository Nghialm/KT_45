using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace Vns.Erp.Core.Produce.Dao
{
	public interface ISxPhancongDao:IDao<SxPhancong,System.Guid>
	{
        IList<SxPhancong> LoadByKeHoachId(Guid KeHoachId);
	}
}