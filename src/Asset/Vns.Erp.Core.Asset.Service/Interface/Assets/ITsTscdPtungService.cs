using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Asset.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ITsTscdPtungService:IErpService<TsTscdPtung, System.Guid>
	{
        [OperationContract]
        IList<TsTscdPtung> GetAllByCT_TSCD_ID(Guid CtTscdId);
        [OperationContract]
        IList<TsTscdPtung> GetAllByTSCD_ID(Guid DmTscdId);

        IList<TsTscdPtung> GetByTscdId(Guid DmTscdId);
    }
}
