﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Service.Interface;
using Vns.Erp.Core.Accounting.Domain;
using System.Data;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Report.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IRpBangTinhKhauHao : IErpService<BcKetoan, System.Guid>
    {
    }
}
