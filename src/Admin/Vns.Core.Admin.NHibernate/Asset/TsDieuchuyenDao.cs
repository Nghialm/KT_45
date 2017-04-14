
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
    [Serializable]
    public sealed class TsDieuchuyenDao : GenericDao<TsDieuchuyen, System.Guid>, ITsDieuchuyenDao
    {
        public IList<TsDieuchuyen> GetObjectByTSCD_ID(Guid TscdId)
        {
            string sql = "from TsDieuchuyen a where a.TscdId = :TscdId order by ThuTu";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TscdId", TscdId);
            return q.List<TsDieuchuyen>();
        }
    }
}
