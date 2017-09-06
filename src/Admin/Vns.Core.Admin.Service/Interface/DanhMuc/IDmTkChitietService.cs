
	/*
	insert license info here
	*/
	using System.Collections;
	using System.ComponentModel;
	using System.Data;	
	using Vns.Erp.Core.Admin.Service;
	using Vns.Erp.Core.Admin.Domain;	
	using Vns.Erp.Core.Service.Interface;
    using System;
using System.Collections.Generic;
using System.ServiceModel;
	namespace Vns.Erp.Core.Admin.Service.Interface
	{
        [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
		public interface IDmTkChitietService:IErpService<DmTkChitiet, Guid>
		{
            [OperationContract]
            void DeleteByTKID(Guid TaikhoanId, string DmLienquan);
            [OperationContract]
            IList<DmTkChitiet> SelectAllListByTaiKhoanID(Guid TaikhoanId);
		}
	}
	