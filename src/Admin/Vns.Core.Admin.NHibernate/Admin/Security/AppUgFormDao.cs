
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
using System.Collections;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppUgFormDao:GenericDao<AppUgForm,Guid>,IAppUgFormDao
	{
        public void DeleteByGF(Guid GROUP_ID, Guid FORM_ID)
        {
            /*
             * Delete APP_UG_FORMS where GROUP_ID= p_GROUP_ID AND FORM_ID= p_FORM_ID;
             */
            String sql = "Delete from AppUgForm a where a.GroupId=:GroupId and a.FormId=:FormId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("GroupId", GROUP_ID);
            q.SetParameter("FormId", FORM_ID);
            q.ExecuteUpdate();
        }
        public void DeleteByFormID(Guid FormId)
        {
            String sql = "Delete from AppUgForm a where a.FormId=:FormId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FormId);
            q.ExecuteUpdate();

        }
        public void DeleteByGroup(Guid GroupId)
        {
            String sql = "Delete from AppUgForm a where a.GroupId=:GroupId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("GroupId", GroupId);
            q.ExecuteUpdate();
        }
        public IList<AppUgForm> GetByGroupId(Guid GROUP_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("GroupId");
            values.Add(GROUP_ID);
            return List(-1, -1, props, values, null);
        }
	}
}
