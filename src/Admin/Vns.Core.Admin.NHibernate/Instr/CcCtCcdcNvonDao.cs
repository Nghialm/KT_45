
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class CcCtCcdcNvonDao:GenericDao<CcCtCcdcNvon,System.Guid>,ICcCtCcdcNvonDao
	{
        public IList<CcCtCcdcNvon> GetByCtCcdcId(Guid CtCcdcId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtCcdcId");
            values.Add(CtCcdcId);
            return List(-1, -1, props, values, null);
        }

        public Boolean DeleteByCtCcdcId(Guid CtCcdcId)
        {
            String sql = " delete from CcCtCcdcNvon a where " +
                         " a.CtCcdcId=:CtCcdcId ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtCcdcId", CtCcdcId);
            int i = q.ExecuteUpdate();

            return true;
        }
	}
}
