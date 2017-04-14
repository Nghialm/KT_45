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
	public interface IHtBaocaoService:IErpService<HtBaocao, Guid>
	{
        [OperationContract]
        IList<HtBaocao> GetByIDCha(Guid ParentId);
        [OperationContract]
        IList<HtBaocao> GetAllWithOrder();
        [OperationContract]
        HtBaocao GetByMa(String MaBaocao);
	}
}
