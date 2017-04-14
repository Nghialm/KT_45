using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;

namespace Vns.Erp.Core.Asset.Service.Interface
{
	public interface ICcLsPhanboCcService:IErpService<CcLsPhanboCc, System.Guid>
	{
        void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
        void SavePhanBoThang(List<CcLsPhanboCc> lstPhanbo);
	}
}
