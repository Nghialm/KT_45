
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppDvGroupFormDao:GenericDao<AppDvGroupForm,Guid>,IAppDvGroupFormDao
	{
        public void DeleteByGroupId(Guid GroupId)
        {
            String sql = "delete from AppDvGroupForm a where a.GroupId=:GroupId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("GroupId", GroupId);
            q.ExecuteUpdate();
        }
        public void DeleteByFormId(Guid FORM_ID)
        {
            String sql = "delete from AppDvGroupForm a where a.FormId=:FormId";
            IQuery q  = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FORM_ID);
            q.ExecuteUpdate();
        }

        public void DeleteByDVGF(Guid DonViId, Guid GroupId, Guid FormId)
        {
            String sql = "delete from AppDvGroupForm a where a.FormId=:FormId and a.GroupId=:GroupId and a.DvId=:DonViId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FormId);
            q.SetParameter("GroupId", GroupId);
            q.SetParameter("DonViId", DonViId);
            q.ExecuteUpdate();
        }
        public void DeleteByDVF(Guid DonViId, Guid FormId)
        {
            String sql = "delete from AppDvGroupForm a where a.FormId=:FormId  and a.DvId=:DonViId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FormId);            
            q.SetParameter("DonViId", DonViId);
            q.ExecuteUpdate();
        }
        public void DeleteByF(Guid FormId)
        {
            String sql = "delete from AppDvGroupForm a where a.FormId=:FormId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FormId);
            q.ExecuteUpdate();
        }
	}
}
