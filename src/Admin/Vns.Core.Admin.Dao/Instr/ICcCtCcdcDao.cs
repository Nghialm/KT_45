using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Dao
{
	public interface ICcCtCcdcDao:IDao<CcCtCcdc,System.Guid>
	{
        IList<CcCtCcdc> GetByCCDCId(Guid CcdcId);
        IList<CcCtCcdc> GetByCCDCIdAndTT(Guid CcdcId);
        Boolean DeleteByCcdcId(Guid CcdcId);
        IList<CcCtCcdc> GetByTrangThai(decimal GiamCcdc);
        Boolean DeleteByTrangThai(Guid CcdcId, Decimal GiamCcdc);
        IList<CcCtCcdc> GetByCcDcId_TrangThai(Guid CcdcId, decimal GiamCcdc);
	}
}