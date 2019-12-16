
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class HtThamsoDao:GenericDao<HtThamso,Guid>,IHtThamsoDao
	{
        #region IDao
        HtThamso IDao<HtThamso, Guid>.Merge(HtThamso entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        HtThamso IDao<HtThamso, Guid>.Save(HtThamso entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        HtThamso IDao<HtThamso, Guid>.SaveOrUpdate(HtThamso entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public void DeleteByDonviId(Guid DonviId)
        {
            string sql = "delete from HtThamso a where a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            q.ExecuteUpdate(); 
        }
           
	}
}
