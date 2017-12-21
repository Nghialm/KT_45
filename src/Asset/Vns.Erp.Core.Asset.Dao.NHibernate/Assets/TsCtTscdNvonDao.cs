
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;

namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
    [Serializable]
    public sealed class TsCtTscdNvonDao : GenericDao<TsCtTscdNvon, System.Guid>, ITsCtTscdNvonDao
    {
        #region IDao
        TsCtTscdNvon IDao<TsCtTscdNvon, Guid>.Merge(TsCtTscdNvon entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        TsCtTscdNvon IDao<TsCtTscdNvon, Guid>.Save(TsCtTscdNvon entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        TsCtTscdNvon IDao<TsCtTscdNvon, Guid>.SaveOrUpdate(TsCtTscdNvon entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public Boolean DeleteByDmTscdId(Guid TscdId)
        {
            string sql = "Delete from TsCtTscdNvon a " +
                "where a.CtTscdId in (select ct.id from CtTscd ct where ct.TscdId = :TscdId) ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", TscdId);
            q.ExecuteUpdate();

            return true;
        }

        public IList<TsCtTscdNvon> GetByDmTscdId(Guid DmTscdId)
        {
            string sql = "Select a from TsCtTscdNvon a " +
                "where a.CtTscdId in (select ct.id from CtTscd ct where ct.TscdId = :TscdId) ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", DmTscdId);
            IList<TsCtTscdNvon> lst = q.List<TsCtTscdNvon>();

            return lst;
        }

    }
}
