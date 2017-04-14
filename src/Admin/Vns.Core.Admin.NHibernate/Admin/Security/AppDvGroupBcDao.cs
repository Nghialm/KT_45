
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
    public sealed class AppDvGroupBcDao : GenericDao<AppDvGroupBc, Guid>, IAppDvGroupBcDao
	{


        public IList<HtBaocao> GetBCByDV(Guid DV_ID)
        {
            /*             
             * PROCEDURE APP_DV_GROUP_BC_GetBCByDV(
                    p_DV_ID VARCHAR2,
                    cur OUT sys_refcursor)
                IS
                BEGIN
                OPEN cur FOR
                    Select b.*
                    From HT_BAOCAO b
                    INNER JOIN APP_DV_GROUP_BC d ON b.ID = d.BC_ID
                    AND d.DV_ID= p_DV_ID;
                END;
             * */
            string sql = "select b from AppDvGroupBc a inner join a.HtBaocao b where a.DvId=:DvId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DvId", DV_ID);            
            return q.List<HtBaocao>(); 


        }

        public IList<HtBaocao> GetBCByDVU(Guid DV_ID, Guid USER_ID)
        {
            //string sql = "select a.ListHtBaoCao as b from AppDvGroupBc a  where (a.DvId =:DvId) and a.GroupId in (select b.GroupId from AppDvGroupUser c where c.DvId=:DvId and c.UserId=:UserId)";
            string sql = "select b from AppDvGroupBc a inner join a.HtBaocao b where (a.DvId =:DvId) and a.GroupId in (select c.GroupId from AppDvGroupUser c where c.DvId=:DvId and c.UserId=:UserId) Order by b.Id";
            /*
             *  Select bc.*
                From HT_BAOCAO bc
                INNER JOIN APP_DV_GROUP_BC dgb ON dgb.BC_ID = bc.ID
                AND dgb.GROUP_ID IN (select g.GROUPID
                from APP_GROUPS g INNER JOIN APP_DV_GROUP_USER dgu ON dgu.GROUP_ID = g.GROUPID
                and dgu.USER_ID = p_USER_ID and dgu.DV_ID = p_DV_ID);
             */

            IQuery query = NHibernateSession.CreateQuery(sql);
            query.SetParameter("DvId", DV_ID);
            query.SetParameter("UserId", USER_ID);
            return query.List<HtBaocao>();
            //return List(-1, -1, props, values, null); ;
        }

        public IList<AppDvGroupBc> GetByDV(Guid DV_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            values.Add(DV_ID);
            return List(-1, -1, props, values, null);
        }

        public IList<AppDvGroupBc> GetByDVG(Guid DV_ID, Guid GROUP_ID)
        {

            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            values.Add(DV_ID);
            props.Add("GroupId");
            values.Add(GROUP_ID);
            return List(-1, -1, props, values, null);
        }

        public void DeleteByDVB(Guid DV_ID, Guid BC_ID)
        {
            string sql = "delete from AppDvGroupBc a where a.DvId =:DvId and a.BcId=:BcId";
            IQuery query = NHibernateSession.CreateQuery(sql);
            query.SetParameter("DvId", DV_ID);
            query.SetParameter("BcId", BC_ID);
            query.ExecuteUpdate(); 
        }

        public void DeleteByDGB(Guid DV_ID, Guid GROUP_ID, Guid BC_ID)
        {
            string sql = "delete from AppDvGroupBc a where a.DvId =:DvId and a.BcId=:BcId and a.GroupId=:GroupId";
            IQuery query = NHibernateSession.CreateQuery(sql);
            query.SetParameter("DvId", DV_ID);
            query.SetParameter("BcId", BC_ID);
            query.SetParameter("GroupId", GROUP_ID);
            query.ExecuteUpdate();
        }
    }
}
