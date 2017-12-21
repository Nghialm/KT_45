
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
    [Serializable]
    public sealed class TsDieuchuyenDao : GenericDao<TsDieuchuyen, System.Guid>, ITsDieuchuyenDao
    {
        #region IDao
        TsDieuchuyen IDao<TsDieuchuyen, Guid>.Merge(TsDieuchuyen entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        TsDieuchuyen IDao<TsDieuchuyen, Guid>.Save(TsDieuchuyen entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        TsDieuchuyen IDao<TsDieuchuyen, Guid>.SaveOrUpdate(TsDieuchuyen entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public IList<TsDieuchuyen> GetObjectByTSCD_ID(Guid TscdId)
        {
            string sql = "from TsDieuchuyen a where a.TscdId = :TscdId order by ThuTu";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", TscdId);
            return q.List<TsDieuchuyen>();
        }

        public Boolean DeleteByDmTscdId(Guid TscdId)
        {
            string sql = "Delete from TsDieuChuyen a where a.TscdId = :TscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", TscdId);
            q.ExecuteUpdate();

            return true;
        }

        public IList<TsDieuchuyen> GetByDmTscdId(Guid DmTscdId)
        {
            string sql = "Select a from TsDieuChuyen a where a.TscdId = :TscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", DmTscdId);
            IList<TsDieuchuyen> lst = q.List<TsDieuchuyen>();

            return lst;
        }

    }
}
