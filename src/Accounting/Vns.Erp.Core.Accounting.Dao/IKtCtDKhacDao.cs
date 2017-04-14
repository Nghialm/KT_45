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
	public interface IKtCtDKhacDao:IDao<KtCtDKhac,System.Guid>
	{
        Boolean DeleteByCtH(Guid CthId);
        Boolean DeleteByCtH(Guid CthId, decimal Nhom);
	}
}