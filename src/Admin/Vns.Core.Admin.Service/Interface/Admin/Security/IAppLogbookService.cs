using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel;
using System;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IAppLogbookService:IErpService<AppLogbook, Guid>
	{
        [OperationContract]
        void UserLogin(decimal LogInUser);
        [OperationContract]
        void UserLogOut(decimal LogInUser);
        [OperationContract]
        void UserOpenScreen(decimal LogInUser, string FormDesc, string FormName);
        [OperationContract]
        void UserCloseScreen(decimal LogInUser, string FormDesc, string FormName);
	}
}
