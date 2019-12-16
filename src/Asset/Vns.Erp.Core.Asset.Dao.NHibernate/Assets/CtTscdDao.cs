
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
    public sealed class CtTscdDao : GenericDao<CtTscd, System.Guid>, ICtTscdDao
    {
        #region IDao
        CtTscd IDao<CtTscd, Guid>.Merge(CtTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        CtTscd IDao<CtTscd, Guid>.Save(CtTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        CtTscd IDao<CtTscd, Guid>.SaveOrUpdate(CtTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public TsLsKhauhao KHAUHAO_VET_CUOI(Guid DmTscdId, DateTime Ngay)
        {
            string sql = "from TsLsKhauhao a where a.DmTscdId = :DmTscdId " +
                           " And a.Thang <= :Thang " +
                           " And a.Nam <= :Nam " +
                           " Order by a.Nam desc, a.Thang desc";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DmTscdId", DmTscdId);
            q.SetParameter("Thang", Ngay.Month);
            q.SetParameter("Nam", Ngay.Year);
            IList<TsLsKhauhao> lst = q.List<TsLsKhauhao>();

            if (lst == null || lst.Count == 0)
                return null;
            else
                return lst[0];
        }

        public Boolean DeleteByDmTscdId(Guid TscdId)
        {
            string sql = "Delete from CtTscd a where a.TscdId = :TscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", TscdId);
            q.ExecuteUpdate();

            return true;
        }

        public IList<CtTscd> GetByDmTscdId(Guid DmTscdId)
        {
            string sql = "Select a from CtTscd a where a.TscdId = :TscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", DmTscdId);
            IList<CtTscd> lst = q.List<CtTscd>();

            return lst;
        }

    }
}
