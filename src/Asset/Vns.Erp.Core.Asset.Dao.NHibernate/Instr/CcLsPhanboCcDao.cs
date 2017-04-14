
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
	[Serializable]
	public sealed class CcLsPhanboCcDao:GenericDao<CcLsPhanboCc,System.Guid>,ICcLsPhanboCcDao
	{
        public void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            string sql = "Delete from CcLsPhanboCc a where a.DonviId = :DonviId " +
                                      " And a.Thang = :Thang " +
                                      " And a.Nam = :Nam ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            q.ExecuteUpdate();
        }
	}
}
