using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Accounting.Domain;
using System.Data;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Accounting.Report.Dao
{
    public interface IRpLedgerTaxDao : IDao<BcKetoan, System.Guid>
    {
        DataTable GetDataBangKeThue(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
    }
}
