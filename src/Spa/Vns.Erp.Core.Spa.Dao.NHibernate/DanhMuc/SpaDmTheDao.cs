
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class SpaDmTheDao:GenericDao<SpaDmThe,System.Guid>,ISpaDmTheDao
	{
        public IList<SpaDmThe> GetAllByDonviID(Guid DonviId)
        {
            string sql = "from  SpaDmThe a where (a.DonviId=:DonviId)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            return q.List<SpaDmThe>();
        }
	}
}
