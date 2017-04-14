
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Criterion;
using NHibernate.Transform;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtCtHHddvDao:GenericDao<KtCtHHddv,System.Guid>,IKtCtHHddvDao
	{
        public IList<KtCtHHddv> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, int SoCTHienThi)
        {
            String nHQL = " Select h " +
                                     " From KtCtHHddv h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt Desc";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("MaLoaiCt", String.Format("{0}%", MaLoaiCt));
            if (SoCTHienThi > 0)
                query.SetMaxResults(SoCTHienThi);

            return query.List<KtCtHHddv>();
        }

        public IList<KtCtHHddv> GetByLoaiChungTu(int PageIndex,int PageSize,Guid DonviId, string MaLoaiCt, int SoCTHienThi,out int TotalResult)
        {
            String nHQL = " Select h " +
                                     " From KtCtHHddv h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt " +
                                     " Order by h.NgayCt Desc";
            String countHQL = " Select count(h) " +
                                     " From KtCtHHddv h" +
                                     " Where h.DonviId = :DonviId " +
                                     " And h.MaLoaiCt like :MaLoaiCt "+
                                     " Order by h.NgayCt Desc";
                                     

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
                int startRescord = (PageIndex - 1) * PageSize;
                query.SetFirstResult(startRescord);
                query.SetMaxResults(PageSize);
            }
            long numberRet = (long)countQuery.UniqueResult();
            TotalResult = (int)numberRet;
            return query.List<KtCtHHddv>();
        }

        public IList<KtCtHHddv> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string TenKhachHang, string MA_TK_NO, string MA_TK_CO, string Ma_tk_thue,
                                   decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa,
                                   Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                   Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<KtCtHHddv>().CreateAlias("LstCtDHddv", "d");

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
            if (!(SO_TIEN_TU == SO_TIEN_DEN && SO_TIEN_DEN == 0))
            {
                isearch.Add(Restrictions.Between("d.SoTien", SO_TIEN_TU, SO_TIEN_DEN));
            }
            if (!String.IsNullOrEmpty(NOI_DUNG))
            {
                isearch.Add(Restrictions.Like("d.NoiDung", NOI_DUNG, MatchMode.Anywhere));
            }
            if (!String.IsNullOrEmpty(TenHangHoa))
            {
                isearch.Add(Restrictions.Like("d.TenHanghoa", TenHangHoa, MatchMode.Anywhere));
            }
            if (!String.IsNullOrEmpty(TenKhachHang))
            {
                isearch.Add(Restrictions.Like("TenKhang", TenKhachHang, MatchMode.Anywhere));
            }
            if (!String.IsNullOrEmpty(MA_TK_NO))
            {
                Disjunction resTkNo = new Disjunction();
                String[] arr = MA_TK_NO.Split(';');
                for (int i = 0; i < arr.Length; i++)
                    if (arr [i] !="")
                        resTkNo.Add(Restrictions.Like("d.MaTkNo", arr[i], MatchMode.Start));

                isearch.Add(resTkNo);
            }
            if (!String.IsNullOrEmpty(MA_TK_CO))
            {
                Disjunction resTkCo = new Disjunction();
                String[] arr = MA_TK_CO.Split(';');
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != "")
                        resTkCo.Add(Restrictions.Like("d.MaTkCo", arr[i], MatchMode.Start));

                isearch.Add(resTkCo);
            }
            if (!String.IsNullOrEmpty(Ma_tk_thue))
            {
                Disjunction resTkThue = new Disjunction();
                String[] arr = Ma_tk_thue.Split(';');
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != "")
                    {
                        resTkThue.Add(Restrictions.Like("d.MaTkNoGtgt", arr[i], MatchMode.Start));
                        resTkThue.Add(Restrictions.Like("d.MaTkCoGtgt", arr[i], MatchMode.Start));
                    }
                }

                isearch.Add(resTkThue);
            }

            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            return isearch.List<KtCtHHddv>();
        }
	}
}
