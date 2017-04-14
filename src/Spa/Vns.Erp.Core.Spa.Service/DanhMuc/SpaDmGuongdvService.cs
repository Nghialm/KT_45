using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Spa.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Service
{
	public class SpaDmGuongdvService:GenericService<SpaDmGuongdv,System.Guid>, ISpaDmGuongdvService
	{
	    public ISpaDmGuongdvDao SpaDmGuongdvDao
        {
            get { return (ISpaDmGuongdvDao)Dao; }
            set { Dao = value; }
        }

        public IList<SpaDmGuongdv> GetAllByDonviID(Guid DonviId)
        {
            return SpaDmGuongdvDao.GetAllByDonviID(DonviId);
        }
	}
}