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
	public interface IHtTaikhoanMauService:IErpService<HtTaikhoanMau, System.Guid>
	{
        [OperationContract]
        Boolean ImportDmTaiKhoan(Decimal Loai, Guid DonviId);
	}
}
