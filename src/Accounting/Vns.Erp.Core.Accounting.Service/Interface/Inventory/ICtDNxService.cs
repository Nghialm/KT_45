using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtDNxService:IErpService<CtDNx, System.Guid>
	{
        [OperationContract]
        IList<CtDNx> GetObjectByCTHId(System.Guid CtHNxId);
        [OperationContract]
        Boolean KiemTraLuongTonKho(Guid cthnx_id, System.DateTime ngayct, ref List<CtDNx> lstNX, List<DmKho> lstKho, Guid DonviId);
        [OperationContract]
        Decimal TinhSLTonKho(Guid cthnx_id, DateTime ngayct, Guid hanghoaid, Guid KhoId, Guid DonviId);
	}
}
