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
	public interface IKtCtDHddvService:IErpService<KtCtDHddv, System.Guid>
	{
        [OperationContract]
        IList<KtCtDHddv> GetByCtHandNghiepVu(Guid CthId);
        
	}
}
