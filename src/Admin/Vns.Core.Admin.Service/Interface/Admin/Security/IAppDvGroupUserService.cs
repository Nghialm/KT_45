
/*
insert license info here
*/
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;
namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IAppDvGroupUserService : IErpService<AppDvGroupUser, Guid>
    {
        [OperationContract]
        void DeleteByG(Guid groupid);
        [OperationContract]
        void DeleteByDU(Guid DV_ID, Guid USER_ID);
        [OperationContract]
        void DeleteByU(Guid USER_ID);
        [OperationContract]
        void DeleteByDVGU(Guid DV_ID, Guid GROUP_ID, Guid USER_ID);
        [OperationContract]
        void DeleteByDVG(Guid DV_ID, Guid GROUP_ID);
        [OperationContract]
        IList<AppDvGroupUser> GetByUser(Guid UserId);
        [OperationContract]
        IList<AppDvGroupUser> GetDVUser(Guid donviID, Guid UserId);
    }
}
