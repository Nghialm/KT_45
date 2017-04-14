
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
	public sealed class SpaLsTheDao:GenericDao<SpaLsThe,string>,ISpaLsTheDao
	{
        public void DeleteByPhieu(Guid Mphieuid)
        {
            string sql = "Delete SpaLsThe a where a.Mphieuid = :Mphieuid";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Mphieuid", Mphieuid);
            q.ExecuteUpdate();
        }

        public void DeleteByThe(Guid Theid)
        {
            string sql = "Delete SpaLsThe a where a.Theid = :Theid";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Theid", Theid);
            q.ExecuteUpdate();
        }

        public IList<SpaLsThe> GetHistoryCard(Guid Theid)
        {
            string sql = "Select a From SpaLsThe a where a.Theid = :Theid";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Theid", Theid);
            return q.List<SpaLsThe>();
        }
	}
}
