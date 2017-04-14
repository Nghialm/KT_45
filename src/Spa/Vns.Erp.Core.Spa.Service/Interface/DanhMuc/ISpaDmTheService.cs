using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Spa.Service.Interface
{
	public interface ISpaDmTheService:IErpService<SpaDmThe, System.Guid>
	{
        IList<SpaDmThe> GetAllByDonviID(Guid DonviId);
        SpaDmThe SaveWithHis(Boolean IsInsert, SpaDmThe dmThe);
        Boolean DeleteWithHis(Guid dmThe);
	}
}
