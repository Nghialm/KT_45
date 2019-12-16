/*
insert license info here
*/
using System;
using NHibernate;
using NHibernate.Cfg;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Spring.Transaction.Interceptor;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
    /// </summary>
    [Serializable]
    public sealed class DmNhomTscdDao : GenericDao<DmNhomTscd, Guid>, IDmNhomTscdDao
    {
        #region IDao
        DmNhomTscd IDao<DmNhomTscd, Guid>.Merge(DmNhomTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmNhomTscd IDao<DmNhomTscd, Guid>.Save(DmNhomTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmNhomTscd IDao<DmNhomTscd, Guid>.SaveOrUpdate(DmNhomTscd entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public IList<DmNhomTscd> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }
        public IList<DmNhomTscd> GetMA_NHOM_TSCD(string MaNhom)
        {
            string sql = "from DmNhomTscd a where a.MaNhomTscd like (:MaNhom)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("MaNhom", MaNhom);
            return q.List<DmNhomTscd>();
        }
    }
}
