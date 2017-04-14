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
	public interface ISxDmQuytrinhDao:IDao<SxDmQuytrinh,System.Guid>
	{
        IList<SxDmQuytrinh> GetByDonviId(Guid DonviId);
        void DeleteAllByDonviId(Guid DonviId);
	}
}