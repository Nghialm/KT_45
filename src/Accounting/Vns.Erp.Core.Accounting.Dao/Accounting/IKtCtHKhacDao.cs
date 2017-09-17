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
	public interface IKtCtHKhacDao:IDao<KtCtHKhac,System.Guid>
	{
        #region Syn data
        void UpdateSynFlag(Guid id);
        #endregion

        IList<KtCtHKhac> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult);
	}
}