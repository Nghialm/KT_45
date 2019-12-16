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
	public interface IDmTscdDao:IDao<DmTscd,System.Guid>
	{
        IList<DmTscd> GetbyParameter(DateTime TuNgay, DateTime DenNgay, String TenTscd, Guid LoaitaisanId, Guid DonviId);

        void UpdateSynFlag(Guid id);

    }
}