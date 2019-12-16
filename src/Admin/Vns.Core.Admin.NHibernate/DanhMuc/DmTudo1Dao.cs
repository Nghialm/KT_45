
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class DmTudo1Dao:GenericDao<DmTudo1,System.Guid>,IDmTudo1Dao
	{
        #region IDao
        DmTudo1 IDao<DmTudo1, Guid>.Merge(DmTudo1 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmTudo1 IDao<DmTudo1, Guid>.Save(DmTudo1 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmTudo1 IDao<DmTudo1, Guid>.SaveOrUpdate(DmTudo1 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion
    }
}
