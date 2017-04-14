
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class CtDDao:GenericDao<CtD,System.Guid>,ICtDDao
	{
        public Boolean DeleteByCtH(Guid CthId)
        {
            return DeleteByCtH(CthId, -1);
        }

        public Boolean DeleteByCtH(Guid CthId, decimal Nhom)
        {
            String sql = " delete from CtD a where " +
                         " a.CthId=:CthId " + 
                         (Nhom == Convert.ToDecimal(-1) ? "" : " and (a.Nhom = :Nhom)");
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CthId", CthId);
            if (Nhom != Convert.ToDecimal(-1)) q.SetParameter("Nhom", Nhom);
            int i = q.ExecuteUpdate();

            return true;
        }
	}
}
