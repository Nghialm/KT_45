
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class HtTaikhoanMauDao:GenericDao<HtTaikhoanMau,System.Guid>,IHtTaikhoanMauDao
	{
        public IList<HtTaikhoanMau> GetByLoai(Decimal Loai)
        {
            String sql = "Select a from HtTaikhoanMau a " +
                           " where a.Loai = :Loai " + 
                           " Order by MaTaikhoan ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Loai", Loai);

            IList<HtTaikhoanMau> ls = q.List<HtTaikhoanMau>();
            return ls;
        }
	}
}
