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
	public interface ITsLsKhauhaoService:IErpService<TsLsKhauhao, System.Guid>
	{
        [OperationContract]
        IList<TsLsKhauhao> GetByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
        [OperationContract]
        IList<TsLsKhauhao> GetByDonviId(Guid DonviId);
        [OperationContract]
        IList<TsLsKhauhao> GetByID_CHA(Guid IdCha);
        void DeleteByThangNam_TscdId(Decimal Thang, Decimal Nam, Guid DmTscdId);
        [OperationContract]
        void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
	}
}
