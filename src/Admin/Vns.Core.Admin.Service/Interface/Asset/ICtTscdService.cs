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
	public interface ICtTscdService:IErpService<CtTscd, System.Guid>
	{
        [OperationContract]
        CtTscd GetByIdDM_TSCD(Guid TscdId);
        [OperationContract]
        IList<CtTscd> GetObjectByIdDM_TSCD_DC(Guid TscdId);
        [OperationContract]
        CtTscd GetObject_TOP1(Guid TscdId, DateTime NgayTinh);
        [OperationContract]
        CtTscd GetByTRANG_THAI(Guid TscdId, Decimal TangTscd);
        [OperationContract]
        TsLsKhauhao KHAUHAO_VET_CUOI(Guid DmTscdId, DateTime Ngay);
	}
}
