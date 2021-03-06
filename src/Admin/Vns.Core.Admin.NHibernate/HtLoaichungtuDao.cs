
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class HtLoaichungtuDao:GenericDao<HtLoaichungtu,System.Guid>,IHtLoaichungtuDao
	{
        public IList<HtLoaichungtu> LikeObjetMA_LOAI_CT(string p_MA_CT, Guid DonviId)
        {
            string sql = "from HtLoaichungtu a where a.MaLoaiCt like :MaLoaiCtLike and DuongDan <> '' and DonviId = :DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("MaLoaiCtLike", String.Format("{0}%", p_MA_CT));
            q.SetParameter("DonviId", DonviId);
            return q.List<HtLoaichungtu>();
        }

        public void DeleteByDonViId(Guid DonViId)
        {
            string sql = "delete from HtLoaichungtu a where a.DonviId = :DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonViId);
            q.ExecuteUpdate();
        }
	}
}
