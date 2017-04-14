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
	public class CtDHddvService:GenericService<CtDHddv,System.Guid>, ICtDHddvService
	{
	    public ICtDHddvDao CtDHddvDao
        {
            get { return (ICtDHddvDao)Dao; }
            set { Dao = value; }
        }

        public IList<CtDHddv> GetCtdBycth(Guid CTH_HDDV_ID)
        {
            return CtDHddvDao.GetCtdBycth(CTH_HDDV_ID);
        }

        public IList<CtDHddv> GetCtdByLoaiNV(Guid cthId, int LoaiNghiepVu)
        {
            return CtDHddvDao.GetCtdByLoaiNV(cthId, LoaiNghiepVu);
        }

        
	}
}