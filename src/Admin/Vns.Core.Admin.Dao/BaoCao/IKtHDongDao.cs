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
	public interface IKtHDongDao:IDao<KtHDong,System.Guid>
	{
        IList<KtHDong> GetBy_BAOCAO_Id(System.Guid BaocaoId);
        IList<KtHDong> GetByBaocaoId4Report(System.Guid BaocaoId);
        void DeleteByBaoCaoId(System.Guid BaocaoId);
	}
}