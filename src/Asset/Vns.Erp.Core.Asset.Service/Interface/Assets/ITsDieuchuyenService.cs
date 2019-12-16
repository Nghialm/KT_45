using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Asset.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ITsDieuchuyenService:IErpService<TsDieuchuyen, System.Guid>
	{
        [OperationContract]
        IList<TsDieuchuyen> GetObjectByTSCD_ID(Guid TscdId);

        IList<TsDieuchuyen> GetByDmTscdId(Guid DmTscdId);

    }
}
