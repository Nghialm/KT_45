using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Dao
{
	public interface ISxKehoachMDao:IDao<SxKehoachM,System.Guid>
	{
        IList<SxKehoachM> getByMaCt(string MaLoaiCt, Guid DonviId);
        IList<SxKehoachM> GetByDonviId(Guid DonviId);
	}
}