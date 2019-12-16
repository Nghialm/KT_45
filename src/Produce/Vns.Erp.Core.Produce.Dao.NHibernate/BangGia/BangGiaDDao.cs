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
    public sealed class BangGiaDDao : GenericDao<BangGiaD, System.Guid>, IBangGiaDDao
    {
        public IList<BangGiaD> GetByH(Guid BangGiaHId)
        {
            String sqlBangGia = "FROM BangGiaD d " +
                          " WHERE d.BangGiaHId = :BangGiaHId ";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlBangGia);
            qbcketoan.SetParameter("BangGiaHId", BangGiaHId);

            IList<BangGiaD> lstBanggiaD = qbcketoan.List<BangGiaD>();
            return lstBanggiaD;
        }

    }
}
