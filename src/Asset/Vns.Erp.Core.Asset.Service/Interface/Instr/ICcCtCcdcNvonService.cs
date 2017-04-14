using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Asset.Service.Interface
{
	public interface ICcCtCcdcNvonService:IErpService<CcCtCcdcNvon, System.Guid>
	{
        IList<CcCtCcdcNvon> GetByCtCcdcId(Guid CtCcdcId);
        Boolean DeleteByCtCcdcId(Guid CtCcdcId);
	}
}
