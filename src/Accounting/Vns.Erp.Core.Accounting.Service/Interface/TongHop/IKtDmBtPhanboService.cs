using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IKtDmBtPhanboService:IErpService<KtDmBtPhanbo, System.Guid>
	{
        [OperationContract]
        IList<KtDmBtPhanbo> GetByDonviId(Guid DonviId);
        [OperationContract]
        void DeleteByNhom(Decimal NHOM, Guid DonviId);
        [OperationContract]
        KtDmBtPhanbo GetNhomMax(Guid DonviId);
	}
}
