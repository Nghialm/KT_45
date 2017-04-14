using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Service.Interface
{
	public interface ISpaLsTheService:IErpService<SpaLsThe, string>
	{
        Decimal GetRemainCard(Guid TheId, Guid CtHId);
        SpaLsThe GetRemainCardInfo(Guid TheId, Guid CtHId);
        IList<SpaLsThe> GetHistoryCard(Guid Theid);
	}
}
