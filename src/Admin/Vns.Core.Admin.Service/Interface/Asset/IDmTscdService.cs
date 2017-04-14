using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IDmTscdService:IErpService<DmTscd, System.Guid>
	{
        [OperationContract]
        IList<DmTscd> GetbyParameter(DateTime TuNgay, DateTime DenNgay, String TenTscd, Guid LoaitaisanId, Guid DonviId);
        [OperationContract]
        DmTscd GetByMaTSCD(String MaTscd, Guid DonviId);
        [OperationContract]
        IList<DmTscd> GetObjectAllByDonviID(int PageIndex, int PageSize, Guid DonviId, out int TotalResult);
	}
}
