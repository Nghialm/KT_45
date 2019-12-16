using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Dao
{
	public interface ICtHoadonDao:IDao<CtHoadon,System.Guid>
	{
        #region Syn data
        void UpdateSynFlag(Guid id);
        #endregion

        Boolean DeleteByChungTu(Guid CtLienQuan, Decimal Loai);
        IList<CtHoadon> SearchBy(int PageIndex, int PageSize,
            DateTime TuNgay, DateTime DenNgay, Guid DonviId, String SoHoadon,
            String MaSoThue, String TenKhachhang,
            out int totalResult);

    }
}