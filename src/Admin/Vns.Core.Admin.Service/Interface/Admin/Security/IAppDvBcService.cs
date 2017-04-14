using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IAppDvBcService : IErpService<AppDvBc, Guid>
	{
        [OperationContract]
        IList<AppDvBc> GetByDV(Guid DV_ID);
        [OperationContract]
        IList<HtBaocao> GetBCByDV(Guid DV_ID);
        [OperationContract]
        void DeleteByBC(decimal BC_ID);
        [OperationContract]
        void DeleteByDVBC(Guid DV_ID, decimal BC_ID);
	}
}
