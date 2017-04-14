
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
    public interface IDmLydoTgTscdService : IErpService<DmLydoTgTscd, Guid>
    {
        [OperationContract]
        IList<DmLydoTgTscd> GetAllByDonviID(Guid DonviId);
        [OperationContract]
        IList<DmLydoTgTscd> GetAllAllByLoai(Decimal Loai, Guid DonviId);

    }
}
