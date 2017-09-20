
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class CtHNxDao:GenericDao<CtHNx,System.Guid>,ICtHNxDao
	{
        #region IDao
        CtHNx IDao<CtHNx, Guid>.Merge(CtHNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        CtHNx IDao<CtHNx, Guid>.Save(CtHNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        CtHNx IDao<CtHNx, Guid>.SaveOrUpdate(CtHNx entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }

        void IDao<CtHNx, Guid>.DeleteById(Guid id)
        {
            String sql = " update CtHNx set IsDeleted = 1, SynDate = :SynDate " +
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
            String sql = " update CtHNx set SynDate = :SynDate " +
                         " where Id = :Id ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("SynDate", Null.MIN_DATE);
            q.SetParameter("Id", id);
            int i = q.ExecuteUpdate();
        }
        #endregion

        public IList<CtHNx> GetByLoaiChungTu( Guid DonviId, string MaLoaiCt, int SoCTHienThi)
        {
            String nHQL = " Select h " +
                                     " From CtHNx h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt Desc";

           

            IQuery query = NHibernateSession.CreateQuery(nHQL);
           
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));
            if (SoCTHienThi > 0)
                query.SetMaxResults(SoCTHienThi);

           
            return query.List<CtHNx>();
        }
        public IList<CtHNx> GetByLoaiChungTu(int PageIndex,int PageSize,Guid DonviId, string MaLoaiCt, int SoCTHienThi,out int TotalResult)
        {
            String nHQL = " Select h " +
                                     " From CtHNx h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " Order by h.NgayCt Desc";

            String countHQL = " Select count(h) " +
                                     " From CtHNx h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " And h.MaLoaiCt like :MaLoaiCt ";
                                    

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            IQuery countQuery = NHibernateSession.CreateQuery(countHQL);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));

            countQuery.SetParameter("DonviId", DonviId);
            countQuery.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));

            if (SoCTHienThi > 0)
                query.SetMaxResults(SoCTHienThi);

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int start = (PageIndex - 1) * PageSize;
                query.SetFirstResult(start);
                query.SetMaxResults(PageSize);
            }
            long ret = (long)countQuery.UniqueResult();
            TotalResult = (int)ret;
            return query.List<CtHNx>();
        }

        public IList<CtDNx> GetAllSoDu(int PageIndex, int PageSize,Guid DonviId, int NamKeToan, out int TotalResult)
        {
            String nHQL = " Select d " +
                                     " From CtDNx d inner join d.ObjCtHNx h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And year(h.NgayCt) = :NgayCt" +
                                     " And h.SoDu = :SoDu" +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " Order by h.NgayCt ASC";
            String countHQL = " Select count(d) " +
                                     " From CtDNx d inner join d.ObjCtHNx h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And year(h.NgayCt) = :NgayCt" +
                                     " And (h.IsDeleted <> 1 or h.IsDeleted is null) " +
                                     " And h.SoDu = :SoDu";
            IQuery query = NHibernateSession.CreateQuery(nHQL);
            IQuery countQuery = NHibernateSession.CreateQuery(countHQL);
            query.SetParameter("DonviId", DonviId);
            countQuery.SetParameter("DonviId", DonviId);
            DateTime _nam = new DateTime(NamKeToan, 1, 1);
            query.SetParameter("NgayCt", _nam.Year);
            query.SetParameter("SoDu", 1);

            countQuery.SetParameter("NgayCt", _nam.Year);
            countQuery.SetParameter("SoDu", 1);

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int start = (PageIndex - 1) * PageSize;
                query.SetFirstResult(start);
                query.SetMaxResults(PageSize);
            }
            long ret = (long)countQuery.UniqueResult();
            TotalResult = (int)ret;
            return query.List<CtDNx>();
        }

        public IList<CtHNx> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5, Guid KhoId, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<CtHNx>().CreateAlias("LstCtDNx", "d");

            isearch.Add(Restrictions.Eq("DonviId", DONVI_ID));
            if (!VnsCheck.IsNullDate(NGAY_CT_DEN))
                isearch.Add(Restrictions.Le("NgayCt", VnsConvert.CEndOfDate(NGAY_CT_DEN)));
            if (!VnsCheck.IsNullDate(NGAY_CT_TU))
                isearch.Add(Restrictions.Ge("NgayCt", VnsConvert.CStartOfDate(NGAY_CT_TU)));

            if (!string.IsNullOrEmpty(MA_LOAI_CT))
            {
                isearch.Add(Restrictions.Eq("MaLoaiCt", MA_LOAI_CT));
            }
            if (GHI != 0)
            {
                isearch.Add(Restrictions.Eq("Ghi", GHI));
            }
            if (!String.IsNullOrEmpty(MA_KHANG))
            {
                isearch.Add(Restrictions.Eq("KyHieuKhang", MA_KHANG));
            }
            if (!(SO_TIEN_TU == SO_TIEN_DEN && SO_TIEN_DEN == 0))
            {
                isearch.Add(Restrictions.Between("d.DonGiaVon", SO_TIEN_TU, SO_TIEN_DEN));
            }
            if (!String.IsNullOrEmpty(NOI_DUNG))
            {
                isearch.Add(Restrictions.Like("DienGiai", NOI_DUNG, MatchMode.Anywhere));
            }
            if (!String.IsNullOrEmpty(TenHangHoa))
            {
                isearch.Add(Restrictions.Like("d.TenHanghoa", TenHangHoa, MatchMode.Anywhere));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_KHOANPHI))
            {
                isearch.Add(Restrictions.Eq("d.IdDmKhoanphiCo", ID_DM_KHOANPHI));
                //isearch.Add(Restrictions.Eq("d.IdDmKhoanphiNo", ID_DM_KHOANPHI));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_VUVIEC))
            {
                isearch.Add(Restrictions.Eq("d.VuviecId", ID_DM_VUVIEC));
                //isearch.Add(Restrictions.Eq("d.IdDmVuviecNo", ID_DM_VUVIEC));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_HOPDONG))
            {
                isearch.Add(Restrictions.Eq("d.IdDmHopdongCo", ID_DM_HOPDONG));
                //isearch.Add(Restrictions.Eq("d.IdDmHopdongNo", ID_DM_HOPDONG));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_PHONGBAN))
            {
                isearch.Add(Restrictions.Eq("d.IdDmPhongbanCo", ID_DM_PHONGBAN));
                //isearch.Add(Restrictions.Eq("d.IdDmPhongbanNo", ID_DM_PHONGBAN));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_1))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo1Co", ID_DM_TUDO_1));
                //isearch.Add(Restrictions.Eq("d.IdDmTudo1No", ID_DM_TUDO_1));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_2))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo2Co", ID_DM_TUDO_2));
                //isearch.Add(Restrictions.Eq("d.IdDmTudo2No", ID_DM_TUDO_2));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_3))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo3Co", ID_DM_TUDO_3));
                //isearch.Add(Restrictions.Eq("d.IdDmTudo3No", ID_DM_TUDO_3));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_4))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo4Co", ID_DM_TUDO_4));
                //isearch.Add(Restrictions.Eq("d.IdDmTudo4No", ID_DM_TUDO_4));
            }
            if (!VnsCheck.IsNullGuid(ID_DM_TUDO_5))
            {
                isearch.Add(Restrictions.Eq("d.IdDmTudo5Co", ID_DM_TUDO_5));
                //isearch.Add(Restrictions.Eq("d.IdDmTudo5No", ID_DM_TUDO_5));
            }
            if (!VnsCheck.IsNullGuid(KhoId))
            {
                Disjunction resKho = new Disjunction();
                resKho.Add(Restrictions.Eq("d.KhoNhapId", KhoId));
                resKho.Add(Restrictions.Eq("d.KhoXuatId", KhoId));
                isearch.Add(resKho);
            }
            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            return isearch.List<CtHNx>();
        }
	}
}
