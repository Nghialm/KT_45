using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtThueService:IErpService<CtThue, System.Guid>
	{
        [OperationContract]
        IList<CtThue> GetObjectAllByCTD_ID(Guid CtdId);
        [OperationContract]
        IList<CtThue> GetObjectbyCtHoaDon(Guid CtHoadonId);
        [OperationContract]
        CtThue GetObjectAllByCTDNX_ID(Guid CtdNxId);
	}
}
