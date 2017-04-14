
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;
using NHibernate;

namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class SpaDmGuongdvDao:GenericDao<SpaDmGuongdv,System.Guid>,ISpaDmGuongdvDao
	{
        public IList<SpaDmGuongdv> GetAllByDonviID(Guid DonviId)
        {
            string sql = "from  SpaDmGuongdv a where (a.Donviid=:DonviId)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            return q.List<SpaDmGuongdv>();
        }
	}
}
