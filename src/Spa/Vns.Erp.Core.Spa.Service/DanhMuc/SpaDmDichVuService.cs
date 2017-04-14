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
	public class SpaDmDichVuService:GenericService<SpaDmDichVu,System.Guid>, ISpaDmDichVuService
	{
	    public ISpaDmDichVuDao SpaDmDichVuDao
        {
            get { return (ISpaDmDichVuDao)Dao; }
            set { Dao = value; }
        }

        public IList<SpaDmDichVu> GetAllByDonviID(Guid DonviId)
        {
            return SpaDmDichVuDao.GetAllByDonviID(DonviId);
        }
	}
}