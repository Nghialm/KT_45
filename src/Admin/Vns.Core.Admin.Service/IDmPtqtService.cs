
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
		public interface IDmPtqtService:IErpService<DmPtqt, Guid>
		{
            [OperationContract]
            IList<DmPtqt> GetAllByDonviID(Guid DONVI_ID);
            [OperationContract]
            IList<DmPtqt> GetByKyHieu(String KyHieu, Guid DonviId);
		}
        
	}
	