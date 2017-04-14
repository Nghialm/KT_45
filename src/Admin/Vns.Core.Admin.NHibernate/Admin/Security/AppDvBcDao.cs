
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
using Spring.Transaction.Interceptor;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppDvBcDao:GenericDao<AppDvBc,Guid>,IAppDvBcDao
	{

        public IList<AppDvBc> GetByDV(Guid DV_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            values.Add(DV_ID);
            return List(-1, -1, props, values, null); 
        }

        public IList<HtBaocao> GetBCByDV(Guid DV_ID)
        {
            /*
             *    Select b.*
                From HT_BAOCAO b
                INNER JOIN APP_DV_BC db ON db.BC_ID = b.ID
                AND cast (db.DV_ID AS VARCHAR2(32)) = p_DV_ID
                order by b.ID asc;
             */
            string sql = "select b from AppDvBc a inner join a.HtBaocao b where a.DvId=:DvId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DvId", DV_ID);
            return q.List<HtBaocao>(); 
        }
        [Transaction]
        public void DeleteByBC(decimal BC_ID)
        {
            /* 
             * Delete APP_DV_BC where BC_ID= p_BC_ID;
             */
            string sql = "delete  from AppDvBc  a where a.BcId=:BcId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("BcId", BC_ID);  
            q.ExecuteUpdate(); 
        }
        [Transaction]
        public void DeleteByDVBC(Guid DV_ID, decimal BC_ID)
        {
            /*Delete APP_DV_BC where DV_ID= p_DV_ID and BC_ID= p_BC_ID;*/
            string sql = "delete  from AppDvBc  a where a.BcId=:BcId and a.DvId=:DvId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("BcId", BC_ID);
            q.SetParameter("DvId", DV_ID);
            q.ExecuteUpdate();             
        }
    }
}
