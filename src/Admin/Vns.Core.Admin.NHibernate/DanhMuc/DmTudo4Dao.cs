
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class DmTudo4Dao:GenericDao<DmTudo4,System.Guid>,IDmTudo4Dao
	{
        #region IDao
        DmTudo4 IDao<DmTudo4, Guid>.Merge(DmTudo4 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmTudo4 IDao<DmTudo4, Guid>.Save(DmTudo4 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmTudo4 IDao<DmTudo4, Guid>.SaveOrUpdate(DmTudo4 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion
    }
}
