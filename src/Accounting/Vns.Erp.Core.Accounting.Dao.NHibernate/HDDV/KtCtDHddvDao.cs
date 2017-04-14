
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtCtDHddvDao:GenericDao<KtCtDHddv,System.Guid>,IKtCtDHddvDao
	{
        public Boolean DeleteByCtH(Guid CthHddvId)
        {
            String sql = " delete from KtCtDHddv a where " +
                         " a.CthHddvId=:CthHddvId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CthHddvId", CthHddvId);
            int i = q.ExecuteUpdate();

            return true;
        }
	}
}
