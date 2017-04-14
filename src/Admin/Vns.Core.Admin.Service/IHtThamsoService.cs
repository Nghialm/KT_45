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
	public interface IHtThamsoService:IErpService<HtThamso, Guid>
	{
        [OperationContract]
        HtThamso GetByMaThamSo(string MaThamSo, System.Guid DonviID);
        [OperationContract]
        IList<HtThamso> GetByGroupID_ds(Guid GroupId, Guid DonviId);
        [OperationContract]
        IList<HtThamso> GetByDonviId(Guid DonviID);
        [OperationContract]
        void DeleteByDonviId(Guid DonviId);
	}
}
