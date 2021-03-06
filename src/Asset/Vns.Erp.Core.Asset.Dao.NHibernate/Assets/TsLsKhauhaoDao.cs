
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
	[Serializable]
	public sealed class TsLsKhauhaoDao:GenericDao<TsLsKhauhao,System.Guid>,ITsLsKhauhaoDao
	{
        public IList<TsLsKhauhao> GetByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            string sql = "from TsLsKhauhao a where a.DonviId = :DonviId " +
                           " And a.Thang = :Thang " +
                           " And a.Nam = :Nam ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            IList<TsLsKhauhao> lst = q.List<TsLsKhauhao>();

            return lst;
        }

        public void DeleteByTscdId(Guid DmTscdId)
        {
            string sql = "Delete from TsLsKhauhao a where a.DmTscdId = :DmTscdId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DmTscdId", DmTscdId);
            q.ExecuteUpdate();
        }

        public void DeleteByThangNam_TscdId(Decimal Thang, Decimal Nam, Guid DmTscdId)
        {
            string sql = "Delete from TsLsKhauhao a where a.DmTscdId = :DmTscdId " +
                                      " And a.Thang = :Thang " +
                                      " And a.Nam = :Nam ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DmTscdId", DmTscdId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            q.ExecuteUpdate();
        }

        public void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            string sql = "Delete from TsLsKhauhao a where a.DonviId = :DonviId " +
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
