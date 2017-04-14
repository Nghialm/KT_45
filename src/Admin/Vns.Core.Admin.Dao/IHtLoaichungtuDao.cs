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
	public interface IHtLoaichungtuDao:IDao<HtLoaichungtu,System.Guid>
	{
        IList<HtLoaichungtu> LikeObjetMA_LOAI_CT(string p_MA_CT, Guid DonviId);
        void DeleteByDonViId(Guid DonViId);
	}
}