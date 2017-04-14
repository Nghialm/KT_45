
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppDvFormDao:GenericDao<AppDvForm,decimal>,IAppDvFormDao
	{
        public void DeleteByDVF(Guid DV_ID, decimal FormId)
        {
            String sql = "delete from AppDvForm a where a.FormId=:FormId and a.DvId=:DvId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FormId);
            q.SetParameter("DvId", DV_ID);
            q.ExecuteUpdate();

        }
        public void DeleteByForm(decimal FORM_ID)
        {
            String sql = "delete from AppDvForm a where a.FormId=:FormId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("FormId", FORM_ID);            
            q.ExecuteUpdate();
        }

        public IList<AppGroupForms> GetByDonviID(Guid DonviID)
        {
            String sql = "Select b from AppDvForm a inner join a.AppGroupForms b " +
                            " where a.DvId = :DonviID";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviID", DonviID);
            return q.List<AppGroupForms>();
        }

	}
}
