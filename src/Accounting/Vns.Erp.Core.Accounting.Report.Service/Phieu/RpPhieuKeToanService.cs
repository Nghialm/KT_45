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

namespace Vns.Erp.Core.Accounting.Report.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RpPhieuKeToanService : GenericService<BcKetoan, System.Guid>, IRpPhieuKeToanService
    {
        public IRpLedgerAccountDao RpLedgerAccountDao
        {
            get { return (IRpLedgerAccountDao)Dao; }
            set { Dao = value; }
        }

    }
}
