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
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Report.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IRpLedgerS06DnDetailService : IErpService<BcKetoan, System.Guid>
    {
    }
}
