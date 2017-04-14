
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class CtHHddvDao:GenericDao<CtHHddv,System.Guid>,ICtHHddvDao
	{
        public IList<CtHHddv> GetCthByDonViID(Guid DonviId)
        {
            string sql = "from CtHHddv a where (a.DonviId=:DonviId)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            return q.List<CtHHddv>();
        }

        public IList<CtHHddv> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, int SoCTHienThi)
        {
            String nHQL = " Select h " +
                                     " From CtHHddv h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt ASC";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));
            if (SoCTHienThi > 0)
                query.SetMaxResults(SoCTHienThi);

            return query.List<CtHHddv>();
        }
	}
}
