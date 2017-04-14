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
	public interface IAppCtStatusService:IErpService<AppCtStatus, System.Guid>
	{
        [OperationContract]
        IList<AppCtStatus> GetAllByDonviID(Guid DONVI_ID);
        [OperationContract]
        IList<AppCtStatus> GetByDVGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId);
        [OperationContract]
        void DeleteByDGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId);
        [OperationContract]
        IList<HtLoaichungtu> GetLCTByDVG(Guid donvi_id, Guid group_id);
	}
}
