using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using System.Data;

namespace Vns.Erp.Core.Accounting.Report.Dao
{
    public interface IRpLedgerAssetDao : IDao<BcKetoan, System.Guid>
    {
        DataTable GetBangTinhKhauHao(DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetTheTscd(Guid TscdId);
        DataTable GetSoTscdS21(DateTime TuNgay, DateTime DenNgay, Guid DonviId);
    }
}
