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
	public interface IAppCtStatusDao:IDao<AppCtStatus,System.Guid>
	{
        IList<AppCtStatus> GetAllByDonviID(Guid DONVI_ID);
        IList<AppCtStatus> GetByDVGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId);
        void DeleteByDGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId);

        IList<HtLoaichungtu> GetLCTByDVG(Guid donvi_id, Guid group_id);
    }
}