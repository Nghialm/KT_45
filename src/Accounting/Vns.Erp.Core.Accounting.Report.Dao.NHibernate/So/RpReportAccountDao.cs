using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Accounting.Domain;
using System.Data;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Accounting.Report.Dao.NHibernate
{
    public class RpReportAccountDao : GenericDao<BcKetoan, System.Guid>, IRpReportAccountDao
    {
        public DataTable GetDataB01Dn(IList<KtHDong> lstBaocao, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            foreach (KtHDong tmpDong in lstBaocao)
            {
 
            }
            return null;
        }

        
    }
}
