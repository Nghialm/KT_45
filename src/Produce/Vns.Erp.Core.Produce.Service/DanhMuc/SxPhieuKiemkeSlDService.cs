using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;

namespace Vns.Erp.Core.Produce.Service
{
	public class SxPhieuKiemkeSlDService:GenericService<SxPhieuKiemkeSlD,System.Guid>, ISxPhieuKiemkeSlDService
	{
	    public ISxPhieuKiemkeSlDDao SxPhieuKiemkeSlDDao
        {
            get { return (ISxPhieuKiemkeSlDDao)Dao; }
            set { Dao = value; }
        }
	}
}