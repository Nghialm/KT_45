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
	public interface ITsTscdPtungDao:IDao<TsTscdPtung,System.Guid>
	{
        void DeleteByTscdId(Guid DmTscdId);

        IList<TsTscdPtung> GetByTscdId(Guid DmTscdId);
    }
}