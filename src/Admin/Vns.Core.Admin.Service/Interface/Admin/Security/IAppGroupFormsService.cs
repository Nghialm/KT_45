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
	public interface IAppGroupFormsService:IErpService<AppGroupForms, Guid>
	{
        [OperationContract]
        AppGroupForms GetByFormId(Guid FORMS_ID);
        [OperationContract]
        IList<AppGroupForms> GetByGroupId(Guid GROUP_ID);
        [OperationContract]
        IList<AppGroupForms> GetByOption(Guid GROUP_ID, Guid FORMS_ID);
        [OperationContract(Name = "DeleteByIdAppGroupForms")]
        void DeleteById(Guid GROUP_ID, Guid FORMS_ID);
	}
}
