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
	public interface ICtThueDao:IDao<CtThue,System.Guid>
	{
        Boolean DeleteByCtD(Guid CtdId);
        Boolean DeleteByHoaDon(Guid CtHoadonId);
        Boolean DeleteByCtDNx(Guid CtdNxId);
        IList<CtThue> GetObjectbyCtHoaDon(Guid CtHoadonId);
	}
}