using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IKtHCotService:IErpService<KtHCot, System.Guid>
	{
        [OperationContract]
        IList<KtHCot> GetBy_Dong_Id(System.Guid DongId);
    }
}
