using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Accounting.Dao;
using System.Data;
using Vns.Erp.Core.Accounting.Report.Dao;
using System.ServiceModel.Activation;
using Vns.Erp.Core.Accounting.Report.Domain;

namespace Vns.Erp.Core.Accounting.Report.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RpAdminLedgerService : GenericService<BcKetoan, System.Guid>, IRpAdminLedgerService
    {
        public IRpLedgerAccountDao RpLedgerAccountDao
        {
            get { return (IRpLedgerAccountDao)Dao; }
            set { Dao = value; }
        }

        public IList<RpLedgerAdminDTO> GetDataDetail(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, Guid KhachHangId, Guid HopDongId)
        {
            return RpLedgerAccountDao.GetDataDetail(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, KhachHangId, HopDongId);
        }
    }
}
