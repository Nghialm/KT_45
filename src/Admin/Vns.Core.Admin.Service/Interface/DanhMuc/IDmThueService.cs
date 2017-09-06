
	/*
	insert license info here
	*/
	using System.Collections;
	using System.ComponentModel;
	using System.Data;	
	using System;
	using Vns.Erp.Core.Admin.Service;
	using Vns.Erp.Core.Admin.Domain;	
	using Vns.Erp.Core.Service.Interface;
using System.ServiceModel;
using System.Collections.Generic;
	namespace Vns.Erp.Core.Admin.Service.Interface
	{
        [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
		public interface IDmThueService:IErpService<DmThue, Guid>
		{
            [OperationContract]
            int GetNumberDmThueByMaThue(String MaThue);

            [OperationContract]
            IList<DmThue> GetDmThueByabc(HtLoaichungtu obj);
            IList<DmThue> GetDmThueByabc(decimal XuatKhau,decimal MuaHang);
		}
	}
	