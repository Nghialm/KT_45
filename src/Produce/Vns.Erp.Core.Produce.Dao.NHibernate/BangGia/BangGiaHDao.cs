using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;

namespace Vns.Erp.Core.Produce.Dao.NHibernate
{
    [Serializable]
    public sealed class BangGiaHDao : GenericDao<BangGiaH, System.Guid>, IBangGiaHDao
    {
        public BangGiaH GetBangGiaLastest(DateTime ToDate, Guid Donvid)
        {
            String sqlBangGia = "FROM BangGiaH h " +
                          " WHERE h.NgayBangGia <= :ToDate " +
                          " AND h.DonviId = :DonviId " + 
                          " ORDER BY h.NgayBangGia desc";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlBangGia);
            //qbcketoan.SetParameter("TuNgay", TuNgay);
            //qbcketoan.SetParameter("DenNgay", DenNgay);
            qbcketoan.SetParameter("ToDate", ToDate);
            qbcketoan.SetParameter("DonviId", Donvid);
            qbcketoan.SetMaxResults(1);

            IList<BangGiaH> lstBanggiaH = qbcketoan.List<BangGiaH>();
            if (lstBanggiaH.Count > 0)
                return lstBanggiaH[0];
            else
                return null;
        }

        public IList<BangGiaH> GetBangGia(Guid Donvid)
        {
            String sqlBangGia = "FROM BangGiaH h " +
                          " WHERE " +
                          " h.DonviId = :DonviId " +
                          " ORDER BY h.NgayBangGia desc";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlBangGia);
            qbcketoan.SetParameter("DonviId", Donvid);
            qbcketoan.SetMaxResults(100);

            IList<BangGiaH> lstBanggiaH = qbcketoan.List<BangGiaH>();
            return lstBanggiaH;
        }
    }
}
