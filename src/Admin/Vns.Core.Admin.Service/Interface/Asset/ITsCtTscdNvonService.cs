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
	public interface ITsCtTscdNvonService:IErpService<TsCtTscdNvon, System.Guid>
	{
        [OperationContract]
        IList<TsCtTscdNvon> GetAllByCT_TSCD_ID(Guid CtTscdId);
        [OperationContract]
        IList<TsCtTscdNvon> GetAllByDonviId(Guid DonviId);
	}
}
