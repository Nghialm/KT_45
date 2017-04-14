using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IKtThBtPhanboService:IErpService<KtThBtPhanbo, System.Guid>
	{
        [OperationContract]
        IList<KtThBtPhanbo> GetObjectAllByThangNam(decimal Thang, decimal Nam, System.Guid DonviId);
        [OperationContract]
        List<KtThBtPhanbo> ConvertListDM2THButToanPhanBo(List<KtDmBtPhanbo> lstConvert);
        [OperationContract]
        void DeleteByThangNam(decimal Thang, decimal Nam, System.Guid DonviId);
    }
}
