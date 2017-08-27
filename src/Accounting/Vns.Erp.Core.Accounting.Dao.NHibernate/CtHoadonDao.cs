
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Criterion;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class CtHoadonDao:GenericDao<CtHoadon,System.Guid>,ICtHoadonDao
	{
        public Boolean DeleteByChungTu(Guid CtLienQuan, Decimal Loai)
        {
            String sql = " delete from CtHoadon a where " +
                         " a.CtLienQuan=:CtLienQuan and a.Loai=:Loai";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CtLienQuan", CtLienQuan);
            q.SetParameter("Loai", Loai);
            int i = q.ExecuteUpdate();

            return true;
        }

        public IList<CtHoadon> SearchBy(DateTime TuNgay, DateTime DenNgay, Guid DonviId, String SoHoadon)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<CtHoadon>();

            isearch.Add(Restrictions.Eq("DonviId", DonviId));
            if (!string.IsNullOrEmpty(SoHoadon))
            {
                isearch.Add(Restrictions.Like("SoHoadon", SoHoadon, MatchMode.Anywhere));
            }

            if (TuNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Ge("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay)));
            }

            if (DenNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Le("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay)));
            }

            isearch.AddOrder(new Order("NgayHoadon", true));
            isearch.AddOrder(new Order("SoHoadon", true));

            return isearch.List<CtHoadon>();
        }

        public IList<CtHoadon> SearchBy(int PageIndex, int PageSize, 
            DateTime TuNgay, DateTime DenNgay, Guid DonviId, String SoHoadon,
            String MaSoThue, String TenKhachhang,
            out int totalResult)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<CtHoadon>();
            ICriteria iCount = NHibernateSession.CreateCriteria<CtHoadon>();

            isearch.Add(Restrictions.Eq("DonviId", DonviId));
            if (!string.IsNullOrEmpty(SoHoadon))
            {
                isearch.Add(Restrictions.Like("SoHoadon", SoHoadon, MatchMode.Anywhere));
                iCount.Add(Restrictions.Like("SoHoadon", SoHoadon, MatchMode.Anywhere));
            }

            if (!string.IsNullOrEmpty(MaSoThue))
            {
                isearch.Add(Restrictions.Like("MaSoThue", MaSoThue, MatchMode.Anywhere));
                iCount.Add(Restrictions.Like("MaSoThue", MaSoThue, MatchMode.Anywhere));
            }

            if (!string.IsNullOrEmpty(TenKhachhang))
            {
                isearch.Add(Restrictions.Like("TenKhachhang", TenKhachhang, MatchMode.Anywhere));
                iCount.Add(Restrictions.Like("TenKhachhang", TenKhachhang, MatchMode.Anywhere));
            }

            if (TuNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Ge("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay)));
                iCount.Add(Restrictions.Ge("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay)));
            }

            if (DenNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Le("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay)));
                iCount.Add(Restrictions.Le("NgayHoadon", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay)));
            }

            isearch.AddOrder(new Order("NgayHoadon", true));
            isearch.AddOrder(new Order("SoHoadon", true));

            iCount.SetProjection(Projections.Count(Projections.Id()));
            totalResult = (int)iCount.UniqueResult();
            if ((PageIndex > 0) && (PageSize > 0))
            {
                isearch.SetFirstResult((PageIndex - 1) * PageSize);
                isearch.SetMaxResults(PageSize);
            }

            return isearch.List<CtHoadon>();
        }

    }
}
