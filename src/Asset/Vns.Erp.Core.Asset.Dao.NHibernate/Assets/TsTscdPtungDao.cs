
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
    public sealed class TsTscdPtungDao : GenericDao<TsTscdPtung, System.Guid>, ITsTscdPtungDao
    {
        #region IDao
        TsTscdPtung IDao<TsTscdPtung, Guid>.Merge(TsTscdPtung entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        TsTscdPtung IDao<TsTscdPtung, Guid>.Save(TsTscdPtung entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        TsTscdPtung IDao<TsTscdPtung, Guid>.SaveOrUpdate(TsTscdPtung entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public void DeleteByTscdId(Guid DmTscdId)
        {
            string sql = "Delete from TsTscdPtung a where a.DmTscdId = :DmTscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DmTscdId", DmTscdId);
            q.ExecuteUpdate();
        }

        public IList<TsTscdPtung> GetByTscdId(Guid DmTscdId)
        {
            string sql = "Select a from TsTscdPtung a where a.DmTscdId = :DmTscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DmTscdId", DmTscdId);
            IList<TsTscdPtung> lst = q.List<TsTscdPtung>();

            return lst;
        }
    }
}
