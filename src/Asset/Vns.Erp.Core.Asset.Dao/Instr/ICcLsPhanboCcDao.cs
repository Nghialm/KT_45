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
	public interface ICcLsPhanboCcDao:IDao<CcLsPhanboCc,System.Guid>
	{
        void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam);
	}
}