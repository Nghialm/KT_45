using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Produce.Service.Interface
{
    public interface IBangGiaHService : IErpService<BangGiaH, System.Guid>
    {
        Boolean SaveBangGia(BangGiaH banggiaH);
        BangGiaH GetBangGiaLastest(Guid Donviid);
        IList<BangGiaH> GetBangGia(Guid DonviId);
    }
}
