using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Produce.Service.Interface
{
	public interface ISxPhancongService:IErpService<SxPhancong, System.Guid>
	{
        IList<SxPhancong> LoadByKeHoachId(Guid KeHoachId);
	}
}
