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
	public class SxPhieuKiemkeVtDService:GenericService<SxPhieuKiemkeVtD,System.Guid>, ISxPhieuKiemkeVtDService
	{
	    public ISxPhieuKiemkeVtDDao SxPhieuKiemkeVtDDao
        {
            get { return (ISxPhieuKiemkeVtDDao)Dao; }
            set { Dao = value; }
        }
	}
}