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
	}
}
