
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class CtThueDao:GenericDao<CtThue,System.Guid>,ICtThueDao
	{
        #region IDao
        CtThue IDao<CtThue, Guid>.Merge(CtThue entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        CtThue IDao<CtThue, Guid>.Save(CtThue entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        CtThue IDao<CtThue, Guid>.SaveOrUpdate(CtThue entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public Boolean DeleteByCtD(Guid CtdId)
        {
            String sql = " delete from CtThue a where " +
                         " a.CtdId=:CtdId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtdId", CtdId);
            int i = q.ExecuteUpdate();

            return true;
        }

        public Boolean DeleteByHoaDon(Guid CtHoadonId)
        {
            String sql = " delete from CtThue a where " +
                                    " a.CtHoadonId=:CtHoadonId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtHoadonId", CtHoadonId);
            int i = q.ExecuteUpdate();

            return true;
        }

        public Boolean DeleteByCtDNx(Guid CtdNxId)
        {
            String sql = " delete from CtThue a where " +
                                               " a.CtdNxId=:CtdNxId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtdNxId", CtdNxId);
            int i = q.ExecuteUpdate();

            return true;
        }

        public IList<CtThue> GetObjectbyCtHoaDon(Guid CtHoadonId)
        {
            String sql = " select a from CtThue a where " +
                           " a.CtHoadonId=:CtHoadonId " +
                           "Order by SoThuTu";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtHoadonId", CtHoadonId);

            return q.List<CtThue>();
        }
	}
}
