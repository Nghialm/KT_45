
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
        #region IDao
        CtDNx IDao<CtDNx, Guid>.Merge(CtDNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        CtDNx IDao<CtDNx, Guid>.Save(CtDNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        CtDNx IDao<CtDNx, Guid>.SaveOrUpdate(CtDNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

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
