using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtCtDKhacDao:GenericDao<KtCtDKhac,System.Guid>,IKtCtDKhacDao
	{
        public Boolean DeleteByCtH(Guid CthId)
        {
            return DeleteByCtH(CthId, -1);
        }

        public Boolean DeleteByCtH(Guid CthId, decimal Nhom)
        {
            String sql = " delete from KtCtDKhac a where " +
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
