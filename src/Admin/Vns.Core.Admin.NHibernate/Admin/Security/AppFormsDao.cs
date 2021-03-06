/*
insert license info here
*/
using System;
using NHibernate;
using NHibernate.Cfg;
using Nullables;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using Spring.Transaction.Interceptor;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>
	[Serializable]
	public sealed class AppFormsDao:GenericDao<AppForms,Guid>,IAppFormsDao
	{
        [Transaction(ReadOnly = true)]
        public IList<AppForms> GetByHGroup(Guid group_id)
        {
            //String nHQL = " Select f.Id,f.FormName,f.FormText,f.ParentName,f.MenuName, f.MenuText,f.FormParam  " +
            //              " From AppHGroupForm gf inner join gf.AppForms f " +
            //              " Where gf.GroupId = :GroupId " +
            //              " Order by gf.FormOrder ASC";
            String nHQL = " Select f " +
                          " From AppHGroupForm gf inner join gf.AppForms f " +
                          " Where gf.GroupId = :GroupId " +
                          " Order by gf.FormOrder ASC";
            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("GroupId", group_id);

            return query.List<AppForms>();
        }

        [Transaction(ReadOnly = true)]
        public IList<AppForms> GetByGroup(Guid group_id)
        {
            String nHQL = " Select f " +
                          " From AppGroupForms gf inner join gf.AppForms f " +
                          " Where gf.GroupId = :GroupId " +
                          " Order by gf.FormsOrder ASC";
            //String nHQL = " Select f " +
            //  " From AppGroupForms as gf inner join gf.AppForms as f " +
            //  " Where gf.GroupId = :GroupId " +
            //  " Order by gf.FormsOrder ASC";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("GroupId", group_id);

            return query.List<AppForms>();
        }
	}
}
