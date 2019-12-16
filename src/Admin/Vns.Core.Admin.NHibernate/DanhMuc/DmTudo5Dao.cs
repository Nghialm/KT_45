
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class DmTudo5Dao:GenericDao<DmTudo5,System.Guid>,IDmTudo5Dao
	{
        #region IDao
        DmTudo5 IDao<DmTudo5, Guid>.Merge(DmTudo5 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmTudo5 IDao<DmTudo5, Guid>.Save(DmTudo5 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmTudo5 IDao<DmTudo5, Guid>.SaveOrUpdate(DmTudo5 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

    }
}
