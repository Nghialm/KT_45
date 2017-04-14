
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
    public sealed class AppHGroupFormDao : GenericDao<AppHGroupForm, Guid>, IAppHGroupFormDao
	{
        public void DeleteByGroup(Guid GroupId)
        {
            String sql = "delete from AppHGroupForm a where a.GroupId=:GroupID";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("GroupID", GroupId);
            q.ExecuteUpdate();
        }

        public void DeleteByGroupForm(Guid GroupId, Guid FormId)
        {
            String sql = "delete from AppHGroupForm a where a.GroupId=:GroupId and a.FormId=:FormId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("GroupID", GroupId);
            q.SetParameter("FormId", FormId);
            q.ExecuteUpdate();
        }


    }
}
