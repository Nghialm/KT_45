using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;

namespace Vns.Erp.Core.Produce.Dao.NHibernate
{
	[Serializable]
	public sealed class SxKehoachMDao:GenericDao<SxKehoachM,System.Guid>,ISxKehoachMDao
	{
        public IList<SxKehoachM> getByMaCt(int PageIndex, int PageSize, string MaLoaiCt, Guid DonviId, out int TotalResult)
        {
            String sql = "from SxKehoachM h where h.MaLoaiCt like :MaLoaiCt and h.DonviId = :DonviId";
            String countsql = "count(h) from SxKehoachM h where h.MaLoaiCt like :MaLoaiCt and h.DonviId = :DonviId";

            IQuery query = Session.CreateQuery(sql);
            IQuery countQuery = Session.CreateQuery(countsql);

            query.SetParameter("MaLoaiCt", MaLoaiCt + "%");
            query.SetParameter("DonviId", DonviId);

            countQuery.SetParameter("MaLoaiCt", MaLoaiCt + "%");
            countQuery.SetParameter("DonviId", DonviId);

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int startRescord = (PageIndex - 1) * PageSize;
                query.SetFirstResult(startRescord);
                query.SetMaxResults(PageSize);
            }
            long numberRet = (long)countQuery.UniqueResult();
            TotalResult = (int)numberRet;
            return query.List<SxKehoachM>();
        }

        public IList<SxKehoachM> GetByDonviId(Guid DonviId)
        {
            String sql = "from SxKehoachM lsx where lsx.DonviId = :DonviId";
            IQuery q = Session.CreateQuery(sql);
            
            q.SetParameter("DonviId", DonviId);
            return q.List<SxKehoachM>();
        }
	}
}
