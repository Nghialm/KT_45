
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppGroupFormsDao:GenericDao<AppGroupForms,Guid>,IAppGroupFormsDao
	{
        public void DeleteById(Guid GROUP_ID, Guid FORMS_ID)
        {
            String sql = "delete from AppGroupForms a where a.AppForms.Id=:FormId and a.GroupId=:GroupId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FORMS_ID);
            q.SetParameter("GroupId", GROUP_ID);            ;
            q.ExecuteUpdate();
        }
	}
}
