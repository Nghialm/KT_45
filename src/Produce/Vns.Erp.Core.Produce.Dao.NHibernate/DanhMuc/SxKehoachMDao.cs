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
        public IList<SxKehoachM> getByMaCt(string MaLoaiCt, Guid DonviId)
        {
            String sql = "from SxKehoachM lsx where lsx.MaLoaiCt like :MaLoaiCt and lsx.DonviId = :DonviId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("MaLoaiCt", MaLoaiCt + "%");
            q.SetParameter("DonviId", DonviId);
            return q.List<SxKehoachM>();
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
