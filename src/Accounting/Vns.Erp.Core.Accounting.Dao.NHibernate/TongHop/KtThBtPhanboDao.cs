
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtThBtPhanboDao:GenericDao<KtThBtPhanbo,System.Guid>,IKtThBtPhanboDao
	{
        public void DeleteByThangNam(decimal Thang, decimal Nam, System.Guid DonviId)
        {
            String sql = "delete from KtThBtPhanbo a where a.Thang=:Thang and a.Nam = :Nam and a.DonviId = :DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            q.SetParameter("DonviId", DonviId);
            q.ExecuteUpdate();
        }
	}
}
