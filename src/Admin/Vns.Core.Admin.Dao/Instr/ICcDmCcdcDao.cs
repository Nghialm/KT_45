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

	public interface ICcDmCcdcDao:IDao<CcDmCcdc,System.Guid>
	{
        IList<CcDmCcdc> GetAllByDonviID(Guid DonviId);
        IList<CcDmCcdc> GetByMaCCDC(string MaCcdc);
        void UpdateGiamCcdc(Guid CcdcId, Decimal GiamCcdc);
    }
}