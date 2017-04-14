
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class KtKhoaSoNgayDao:GenericDao<KtKhoaSoNgay,System.Guid>,IKtKhoaSoNgayDao
	{
        public KtKhoaSoNgay GetByDonvi(Guid DonviId)
        {
            String sql = "Select a from KtKhoaSoNgay a " +
                           " where a.DonViId = :DonviId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);

            IList<KtKhoaSoNgay> ls = q.List<KtKhoaSoNgay>();
            if (ls == null || ls.Count == 0)
                return null;
            else
                return ls[0];
        }
	}
}
