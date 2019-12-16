
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class DmTudo3Dao:GenericDao<DmTudo3,System.Guid>,IDmTudo3Dao
	{
        #region IDao
        DmTudo3 IDao<DmTudo3, Guid>.Merge(DmTudo3 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmTudo3 IDao<DmTudo3, Guid>.Save(DmTudo3 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmTudo3 IDao<DmTudo3, Guid>.SaveOrUpdate(DmTudo3 entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

    }
}
