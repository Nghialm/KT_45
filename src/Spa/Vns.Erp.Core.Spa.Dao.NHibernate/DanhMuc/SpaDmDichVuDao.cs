
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class SpaDmDichVuDao:GenericDao<SpaDmDichVu,System.Guid>,ISpaDmDichVuDao
	{					
        public IList<SpaDmDichVu> GetAllByDonviID(Guid DonviId)
        {
            string sql = "from  SpaDmDichVu a where (a.DonviId=:DonviId)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            return q.List<SpaDmDichVu>();
        }
	}
}
