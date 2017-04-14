
/*
insert license info here
*/
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
    public interface IAppFormsService : IErpService<AppForms, Guid>
    {
        [OperationContract]
        IList<AppForms> GetByDV(Guid DV_ID);
        [OperationContract]
        IList<AppForms> GetByGroup(Guid group_id);
        [OperationContract]
        IList<AppForms> GetByHGroup(Guid group_id);
    }
}
