
	/*
	insert license info here
	*/
	using System.Collections;
	using System.ComponentModel;
	using System.Data;	
	using Vns.Erp.Core.Admin.Service;
	using Vns.Erp.Core.Admin.Domain;
    using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;
	namespace Vns.Erp.Core.Admin.Service.Interface
	{
        [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
		public interface IAppDvGroupService:IErpService<AppDvGroup, decimal>
		{
            [OperationContract]
            void DeleteByDVGroup(string DV_ID, Guid GROUP_ID);
            [OperationContract]
            void DeleteByG(Guid GROUP_ID);
            [OperationContract]
            IList<Vns.Erp.Core.Admin.Domain.AppDvGroup> GetByDV(Guid DONVI_ID);
            [OperationContract]
            IList<Vns.Erp.Core.Admin.Domain.AppDvGroup> GetByGroup(Guid GROUP_ID);
        }
	}
	