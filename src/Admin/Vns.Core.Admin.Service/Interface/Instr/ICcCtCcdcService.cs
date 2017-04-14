using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Admin.Service.Interface
{
	public interface ICcCtCcdcService:IErpService<CcCtCcdc, System.Guid>
	{
        IList<CcCtCcdc> GetByCCDCId(Guid CcdcId);
        Boolean DeleteByCcdcId(Guid CcdcId);
        IList<CcCtCcdc> GetByTrangThai(decimal GiamCcdc);
        Decimal GetThuTuMax(Guid CcdcId);
        Boolean DeleteByTrangThai(Guid CcdcId, Decimal GiamCcdc);
        IList<CcCtCcdc> GetByCcDcId_TrangThai(Guid CcdcId, decimal GiamCcdc);
	}
}
