
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
    [Serializable]
    public sealed class CtHDao : GenericDao<CtH, System.Guid>, ICtHDao
    {
        #region IDao
        CtH IDao<CtH, Guid>.Merge(CtH entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        CtH IDao<CtH, Guid>.Save(CtH entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        CtH IDao<CtH, Guid>.SaveOrUpdate(CtH entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }

        void IDao<CtH, Guid>.DeleteById(Guid id)
        {
            String sql = " update CtH set IsDeleted = 1, SynDate = :SynDate " +
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
            String sql = " update CtH set SynDate = :SynDate " +
                         " where Id = :Id ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("SynDate", Null.MIN_DATE);
            q.SetParameter("Id", id);
            int i = q.ExecuteUpdate();
        } 
        #endregion

        public IList<CtH> GetSoDu(Guid DonviId, int NamKeToan)
        {
            String nHQL = " Select h " +
                                     " From CtH h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And year(h.NgayCt) = :NgayCt" +
                                     " And h.SoDu = :SoDu" +
                                     " And h.IsDeleted <> 1 " +
                                     " Order by h.NgayCt ASC";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("DonviId", DonviId);
            DateTime _nam = new DateTime(NamKeToan, 1, 1);
            query.SetParameter("NgayCt", _nam.Year);
            query.SetParameter("SoDu", 1);

            return query.List<CtH>();
        }

        public IList<CtH> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult)
        {
            String nHQL = " Select h " +
                                     " From CtH h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " Order by h.NgayCt Desc";
            String countHQL = " Select count(h) " +
                                     " From CtH h" +
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
            return query.List<CtH>();
        }

        public IList<CtD> GetAllSoDu(Guid DonviId, int NamKeToan)
        {
            String nHQL = " Select d " +
                                     " From CtD d inner join d.ObjCtH h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And year(h.NgayCt) = :NgayCt" +
                                     " And h.SoDu = :SoDu" +
                                     " And h.IsDeleted <> 1 " +
                                     " Order by h.NgayCt ASC";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("DonviId", DonviId);
            DateTime _nam = new DateTime(NamKeToan, 1, 1);
            query.SetParameter("NgayCt", _nam.Year);
            query.SetParameter("SoDu", 1);

            return query.List<CtD>();
        }

        public IList<CtH> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<CtH>().CreateAlias("LstCtD", "d");

            isearch.Add(Restrictions.Not(Restrictions.Eq("IsDeleted", 1)));
            isearch.Add(Restrictions.Eq("DonviId", DONVI_ID));
            if (!string.IsNullOrEmpty(MA_LOAI_CT))
            {
                isearch.Add(Restrictions.Eq("MaLoaiCt", MA_LOAI_CT));
            }

            isearch.Add(Restrictions.Le("NgayCt", VnsConvert.CEndOfDate( NGAY_CT_DEN)));
            isearch.Add(Restrictions.Ge("NgayCt", VnsConvert.CStartOfDate(NGAY_CT_TU)));

            if (GHI != 0)
            {
                isearch.Add(Restrictions.Eq("Ghi", GHI)); 
            }
            if (!String.IsNullOrEmpty(MA_KHANG))
            {
                Disjunction resMaKhach = new Disjunction();

                resMaKhach.Add(Restrictions.Eq("d.MaKhangCo", MA_KHANG));
                resMaKhach.Add(Restrictions.Eq("d.MaKhangNo", MA_KHANG));
                resMaKhach.Add(Restrictions.Eq("KyHieuKhang", MA_KHANG));
                isearch.Add(resMaKhach);
            }
            if (!(SO_TIEN_TU == SO_TIEN_DEN && SO_TIEN_DEN == 0))
            {
                isearch.Add(Restrictions.Between("d.SoTien", SO_TIEN_TU, SO_TIEN_DEN));
            }
            if (!String.IsNullOrEmpty(NOI_DUNG))
            {
                isearch.Add(Restrictions.Like("d.NoiDung", NOI_DUNG, MatchMode.Anywhere));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_KHOANPHI))
            {
                isearch.Add(Restrictions.Eq("d.IdDmKhoanphiCo", ID_DM_KHOANPHI));
                isearch.Add(Restrictions.Eq("d.IdDmKhoanphiNo", ID_DM_KHOANPHI));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_VUVIEC))
            {
                isearch.Add(Restrictions.Eq("d.IdDmVuviecCo", ID_DM_VUVIEC));
                isearch.Add(Restrictions.Eq("d.IdDmVuviecNo", ID_DM_VUVIEC));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_HOPDONG))
            {
                isearch.Add(Restrictions.Eq("d.IdDmHopdongCo", ID_DM_HOPDONG));
                isearch.Add(Restrictions.Eq("d.IdDmHopdongNo", ID_DM_HOPDONG));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_PHONGBAN))
            {
                isearch.Add(Restrictions.Eq("d.IdDmPhongbanCo", ID_DM_PHONGBAN));
                isearch.Add(Restrictions.Eq("d.IdDmPhongbanNo", ID_DM_PHONGBAN));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_1))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo1Co", ID_DM_TUDO_1));
                isearch.Add(Restrictions.Eq("d.IdDmTudo1No", ID_DM_TUDO_1));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_2))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo2Co", ID_DM_TUDO_2));
                isearch.Add(Restrictions.Eq("d.IdDmTudo2No", ID_DM_TUDO_2));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_3))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo3Co", ID_DM_TUDO_3));
                isearch.Add(Restrictions.Eq("d.IdDmTudo3No", ID_DM_TUDO_3));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_4))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo4Co", ID_DM_TUDO_4));
                isearch.Add(Restrictions.Eq("d.IdDmTudo4No", ID_DM_TUDO_4));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_5))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo5Co", ID_DM_TUDO_5));
                isearch.Add(Restrictions.Eq("d.IdDmTudo5No", ID_DM_TUDO_5));
            }

            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            return isearch.List<CtH>();
        }

        public Boolean DeleteMa(Guid IdLoaiCt, DateTime NgayCt, Guid DonviId)
        {
            String DelBcKeToan = "Delete From BcKetoan bc Where bc.IdLoaiCt = :IdLoaiCt and bc.DonviId = :DonviId and bc.NgayCt = :NgayCt"; //
            String DelCtD = "Delete From CtD d Where d.CthId in (Select h.Id From CtH h Where h.IdLoaiCt = :IdLoaiCt and h.NgayCt = :NgayCt and h.DonviId = :DonviId)";
            String DelCtH = "Delete From CtH h Where h.IdLoaiCt = :IdLoaiCt and h.NgayCt = :NgayCt and h.DonviId = :DonviId";

            IQuery qbcketoan = NHibernateSession.CreateQuery(DelBcKeToan);
            qbcketoan.SetParameter("IdLoaiCt", IdLoaiCt);
            qbcketoan.SetParameter("NgayCt", NgayCt);
            qbcketoan.SetParameter("DonviId", DonviId);
            int r = qbcketoan.ExecuteUpdate();

            IQuery qctd = NHibernateSession.CreateQuery(DelCtD);
            qctd.SetParameter("IdLoaiCt", IdLoaiCt);
            qctd.SetParameter("NgayCt", NgayCt);
            qctd.SetParameter("DonviId", DonviId);
            qctd.ExecuteUpdate();

            IQuery qcth = NHibernateSession.CreateQuery(DelCtH);
            qcth.SetParameter("IdLoaiCt", IdLoaiCt);
            qcth.SetParameter("NgayCt", NgayCt);
            qcth.SetParameter("DonviId", DonviId);
            qcth.ExecuteUpdate(); 

            return true;
        }
    }
}
