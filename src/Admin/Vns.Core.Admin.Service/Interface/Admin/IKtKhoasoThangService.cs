using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IKtKhoasoThangService : IErpService<KtKhoasoThang, System.Guid>
    {
        [OperationContract]
        KtKhoasoThang GetByNam(Decimal Nam, Guid DonviId);
        [OperationContract]
        bool KiemTraKhoaSo(System.DateTime NgayCT, Guid donvi_id);
    }
}
