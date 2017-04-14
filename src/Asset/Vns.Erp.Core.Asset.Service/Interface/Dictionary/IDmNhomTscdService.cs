
/*
insert license info here
*/
using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Asset.Service;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel;
namespace Vns.Erp.Core.Asset.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IDmNhomTscdService : IErpService<DmNhomTscd, Guid>
    {
        [OperationContract]
        IList<DmNhomTscd> GetAllByDonviID(Guid DonviId);
        [OperationContract]
        IList<DmNhomTscd> GetMA_NHOM_TSCD(string MaNhom);
        [OperationContract]
        IList<DmNhomTscd> GetbyLOAI_NHOM_TSCD(Guid DonviId, Decimal LoaiNhom);
    }
}
