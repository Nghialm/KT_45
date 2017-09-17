
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
        #region IDao
        KtCtDHddv IDao<KtCtDHddv, Guid>.Merge(KtCtDHddv entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        KtCtDHddv IDao<KtCtDHddv, Guid>.Save(KtCtDHddv entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        KtCtDHddv IDao<KtCtDHddv, Guid>.SaveOrUpdate(KtCtDHddv entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

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
