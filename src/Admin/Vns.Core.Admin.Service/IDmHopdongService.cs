
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
using System.Collections.Generic;
using System.ServiceModel;
	namespace Vns.Erp.Core.Admin.Service.Interface
	{
        [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
		public interface IDmHopdongService:IErpService<DmHopdong, Guid>
		{
            [OperationContract]
            IList<DmHopdong> GetAllByDonviID(Guid DonviId);
            [OperationContract]
            IList<DmHopdong> GetAllByKy_Hieu(string KH_New, Guid DonviId);
		}
	}
	