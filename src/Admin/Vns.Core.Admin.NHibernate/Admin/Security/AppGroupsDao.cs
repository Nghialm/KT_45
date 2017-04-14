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
//using Erp.NHibernateConnectionFramework.Business.Helper;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>
	[Serializable]
	public sealed class AppGroupsDao:GenericDao<AppGroups,Guid>,IAppGroupsDao
	{					
        public IList<AppGroups> GetByDV(Guid DonViId){

            /*
             *     Select g.GROUPID,g.GROUPTEXT
                From APP_GROUPS g
                inner join APP_DV_GROUP dg on dg.GROUP_ID = g.GROUPID
                inner join DM_DONVI d on cast(d.DONVI_ID AS VARCHAR2(32))=cast(dg.DV_ID AS VARCHAR2(32))
                and cast(d.DONVI_ID AS VARCHAR2(32))=p_DVID
                order by g.GROUPID asc;
             * */
            string sql ="select b from AppDvGroup a inner join a.AppGroup b where a.DvId=:DonViId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonViId", DonViId);  
            return q.List<AppGroups>();
        }
	}
}
