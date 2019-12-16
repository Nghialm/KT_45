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
        #region IDao
        KtCtHKhac IDao<KtCtHKhac, Guid>.Merge(KtCtHKhac entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        KtCtHKhac IDao<KtCtHKhac, Guid>.Save(KtCtHKhac entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        KtCtHKhac IDao<KtCtHKhac, Guid>.SaveOrUpdate(KtCtHKhac entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }

        void IDao<KtCtHKhac, Guid>.DeleteById(Guid id)
        {
            String sql = " update KtCtHKhac set IsDeleted = 1, SynDate = :SynDate " +
                         " where Id = :Id ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("SynDate", Null.MIN_DATE);
            q.SetParameter("Id", id);
            int i = q.ExecuteUpdate();
        }
        #endregion

        #region Syn data
        public void UpdateSynFlag(Guid id)
        {
            String sql = " update KtCtHKhac set SynDate = :SynDate " +
                         " where Id = :Id ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("SynDate", Null.MIN_DATE);
            q.SetParameter("Id", id);
            int i = q.ExecuteUpdate();
        }
        #endregion

        public IList<KtCtHKhac> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult)
        {
            String nHQL = " Select h " +
                                     " From KtCtHKhac h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt Desc";
            String countHQL = " Select count(h) " +
                                     " From KtCtHKhac h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
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
