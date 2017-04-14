using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IDmTudo1Service:IErpService<DmTudo1, System.Guid>
	{
        [OperationContract]
        IList<DmTudo1> GetAllByDonviID(Guid DonviId);
	}
}
