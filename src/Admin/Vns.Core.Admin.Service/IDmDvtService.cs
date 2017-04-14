
/*
insert license info here
*/
using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel;
using System.Collections.Generic;
namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IDmDvtService : IErpService<DmDvt, Guid>
    {
        IList<DmDvt> GetAllByDonviID(Guid DonviId);
    }
}
