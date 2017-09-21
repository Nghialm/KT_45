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
	public sealed class SxPhieuKiemkeDao:GenericDao<SxPhieuKiemke,System.Guid>,ISxPhieuKiemkeDao
	{
        public IList<SxPhieuKiemke> getByMaCt(string MaLoaiCt, Guid DonviId)
        {
            String sql = "from SxPhieuKiemke lsx where lsx.MaLoaiPhieu like :MaLoaiCt and lsx.DonviId = :DonviId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("MaLoaiCt", MaLoaiCt + "%");
            q.SetParameter("DonviId", DonviId);
            return q.List<SxPhieuKiemke>();
        }

        public IList<SxPhieuKiemke> getByMaCt(int PageIndex, int PageSize, string MaLoaiCt, Guid DonviId, out int TotalResult)
        {
            String sql = "from SxPhieuKiemke h where h.MaLoaiPhieu like :MaLoaiCt and h.DonviId = :DonviId";
            String countsql = "select count(h) from SxPhieuKiemke h where h.MaLoaiPhieu like :MaLoaiCt and h.DonviId = :DonviId";
            
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
            return query.List<SxPhieuKiemke>();
        }
    }
}
