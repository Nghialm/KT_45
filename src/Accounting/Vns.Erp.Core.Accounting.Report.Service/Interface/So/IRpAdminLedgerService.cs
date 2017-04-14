using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Service.Interface;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Report.Domain;

namespace Vns.Erp.Core.Accounting.Report.Service.Interface
{
    public interface IRpAdminLedgerService : IErpService<BcKetoan, System.Guid>
    {
        IList<RpLedgerAdminDTO> GetDataDetail(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, Guid KhachHangId, Guid HopDongId);
    }
}
