
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class HtThamsoDao:GenericDao<HtThamso,Guid>,IHtThamsoDao
	{					
        public void DeleteByDonviId(Guid DonviId)
        {
            string sql = "delete from HtThamso a where a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            q.ExecuteUpdate(); 
        }
           
	}
}
