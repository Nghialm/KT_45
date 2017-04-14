
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
	public sealed class HtSoChungtuMaxDao:GenericDao<HtSoChungtuMax,System.Guid>,IHtSoChungtuMaxDao
	{
        public HtSoChungtuMax GetByThangNamEtc(Guid LOAICHUNGTU_ID, Decimal THANG, Decimal NAM, Guid DONVI_ID)
        {
            String sql = "Select a from HtSoChungtuMax a " +
                            " where a.LoaichungtuId = :LoaichungtuId " +
                            " and Thang = :Thang " + 
                            " and Nam = :Nam " +
                            " and DonviId = :DonviId ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("LoaichungtuId", LOAICHUNGTU_ID);
            q.SetParameter("Thang", THANG);
            q.SetParameter("Nam", NAM);
            q.SetParameter("DonviId", DONVI_ID);
            IList<HtSoChungtuMax> ls = q.List<HtSoChungtuMax>();
            HtSoChungtuMax maxct = new HtSoChungtuMax();
            if (ls == null || ls.Count == 0)
            {
                maxct.LoaichungtuId = LOAICHUNGTU_ID;
                maxct.Thang = THANG;
                maxct.Nam = NAM;
                maxct.DonviId = DONVI_ID;
                maxct.SoChungtuMax = 1;
                Save(maxct);
            }
            else
            {
                maxct = ls[0];
                maxct.SoChungtuMax = ls[0].SoChungtuMax + 1;
                Update(maxct);
            }
            return maxct;
        }
	}
}
