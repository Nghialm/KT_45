using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;

namespace Vns.Erp.Core.Produce.Dao.NHibernate
{
	[Serializable]
	public sealed class SxPhancongDao:GenericDao<SxPhancong,System.Guid>,ISxPhancongDao
	{
        public IList<SxPhancong> LoadByKeHoachId(Guid KeHoachId)
        {
            String sql = "from SxPhancong pc where pc.KehoachMId =:KeHoachId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("KeHoachId", KeHoachId);
            return q.List<SxPhancong>();
        }
	}
}
