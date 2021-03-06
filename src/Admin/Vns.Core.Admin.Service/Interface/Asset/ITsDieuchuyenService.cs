using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ITsDieuchuyenService:IErpService<TsDieuchuyen, System.Guid>
	{
        [OperationContract]
        IList<TsDieuchuyen> GetObjectByTSCD_ID(Guid TscdId);
	}
}
