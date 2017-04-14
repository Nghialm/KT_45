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
	public sealed class KtCtHKhacDao:GenericDao<KtCtHKhac,System.Guid>,IKtCtHKhacDao
	{
        public IList<KtCtHKhac> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult)
        {
            String nHQL = " Select h " +
                                     " From KtCtHKhac h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt Desc";
            String countHQL = " Select count(h) " +
                                     " From KtCtHKhac h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt ";
            IQuery query = NHibernateSession.CreateQuery(nHQL);
            IQuery countQuery = NHibernateSession.CreateQuery(countHQL);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));

            countQuery.SetParameter("DonviId", DonviId);
            countQuery.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int startRescord = (PageIndex - 1) * PageSize;
                query.SetFirstResult(startRescord);
                query.SetMaxResults(PageSize);
            }
            long numberRet = (long)countQuery.UniqueResult();
            TotalResult = (int)numberRet;
            return query.List<KtCtHKhac>();
        }
	}
}
