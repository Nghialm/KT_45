
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
	}
}
