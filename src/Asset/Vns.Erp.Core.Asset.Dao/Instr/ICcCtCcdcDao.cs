using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Asset.Dao
{
	public interface ICcCtCcdcDao:IDao<CcCtCcdc,System.Guid>
	{
        IList<CcCtCcdc> GetByCCDCId(Guid CcdcId);
        IList<CcCtCcdc> GetByCCDCIdAndTT(Guid CcdcId);
        Boolean DeleteByCcdcId(Guid CcdcId);
        IList<CcCtCcdc> GetByTrangThai(decimal GiamCcdc, Guid DonviId);
        Boolean DeleteByTrangThai(Guid CcdcId, Decimal GiamCcdc);
        IList<CcCtCcdc> GetByCcDcId_TrangThai(Guid CcdcId, decimal GiamCcdc);
        IList<CcCtCcdc> GetByNgayThangKhauhao(DateTime NgayTinh, Guid DonviId);
	}
}