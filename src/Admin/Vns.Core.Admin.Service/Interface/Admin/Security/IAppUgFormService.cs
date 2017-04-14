using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel;
using System;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IAppUgFormService:IErpService<AppUgForm, Guid>
	{
        [OperationContract]
        void DeleteByGF(Guid GROUP_ID, Guid FORM_ID);
        [OperationContract]
        void DeleteByFormID(Guid FormId);
        [OperationContract]
        void DeleteByGroup(Guid GroupId);
        [OperationContract]
        IList<AppUgForm> GetByGroupId(Guid GROUP_ID);
	}
}
