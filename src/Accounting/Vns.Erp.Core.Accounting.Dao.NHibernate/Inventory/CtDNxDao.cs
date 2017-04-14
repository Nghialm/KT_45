
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class CtDNxDao:GenericDao<CtDNx,System.Guid>,ICtDNxDao
	{
        public Boolean DeleteByCtH(Guid CthNxId)
        {
            String sql = " delete from CtDNx a where " +
                         " a.ObjCtHNx.Id=:CthNxId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CthNxId", CthNxId);
            int i = q.ExecuteUpdate();

            return true;
        }
	}
}
