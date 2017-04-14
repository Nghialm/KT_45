
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
    public interface IDmNguonTscdService : IErpService<DmNguonTscd, Guid>
    {
        [OperationContract]
        IList<DmNguonTscd> GetByMaNguon(string MaDmNguonTscd, Guid DonviId);
        [OperationContract]
        IList<DmNguonTscd> GetAllByDonviID(Guid DonviId);
    }
}
