using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Dao
{
	public interface ISpaDmGuongdvDao:IDao<SpaDmGuongdv,System.Guid>
	{
        IList<SpaDmGuongdv> GetAllByDonviID(Guid DonviId);
	}
}