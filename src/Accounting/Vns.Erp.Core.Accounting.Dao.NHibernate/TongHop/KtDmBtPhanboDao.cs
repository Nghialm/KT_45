
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtDmBtPhanboDao:GenericDao<KtDmBtPhanbo,System.Guid>,IKtDmBtPhanboDao
	{
        public void DeleteByNhom(Decimal NHOM, Guid DonviId)
        {
            String sql = "delete from KtDmBtPhanbo a where a.Nhom=:Nhom and a.DonviId = :DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Nhom", NHOM);
            q.SetParameter("DonviId", DonviId);
            q.ExecuteUpdate();
        }
	}
}
