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
    public interface IAppDvGroupFormService : IErpService<AppDvGroupForm, Guid>
	{
        [OperationContract]
        void DeleteByGroup(Guid groupid);
        [OperationContract]
        IList<AppDvGroupForm> GetByDVG(Guid donvi_id, Guid group_id);
        [OperationContract]
        void DeleteByDVGF(Guid DonViId, Guid GroupId, Guid FormId);
        [OperationContract]
        void DeleteByDVF(Guid DonViId, Guid FormId);
        [OperationContract]
        void DeleteByF(Guid FormId);
	}
}
