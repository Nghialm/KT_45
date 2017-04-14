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
    public interface IAppDvGroupBcService : IErpService<AppDvGroupBc, Guid>
	{
        [OperationContract]
        IList<HtBaocao> GetBCByDV(Guid DV_ID);
        [OperationContract]
        IList<HtBaocao> GetBCByDVU(Guid DV_ID, Guid USER_ID);
        [OperationContract]
        IList<AppDvGroupBc> GetByDV(Guid DV_ID);
        [OperationContract]
        IList<AppDvGroupBc> GetByDVG(Guid DV_ID, Guid GROUP_ID);
        [OperationContract]
        void DeleteByDVB(Guid DV_ID, Guid BC_ID);
        [OperationContract]
        void DeleteByDGB(Guid DV_ID, Guid GROUP_ID, Guid BC_ID);
	}
}
