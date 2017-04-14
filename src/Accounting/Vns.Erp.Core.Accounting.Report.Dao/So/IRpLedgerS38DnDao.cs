using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Accounting.Domain;
using System.Data;

namespace Vns.Erp.Core.Accounting.Report.Dao
{
    public interface IRpLedgerS38DnDao : IDao<BcKetoan, System.Guid>
    {
        DataTable GetDataS38Dn(String p_Ma_Tk, Guid p_DonviId, DateTime p_Tu_Ngay, DateTime p_Den_Ngay);
    }
}
