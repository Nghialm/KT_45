
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
		public interface IDmNhomvattu1Service:IErpService<DmNhomvattu1, Guid>
		{
            [OperationContract]
            IList<DmNhomvattu1> GetObjectAllByDonviID(Guid DonViId);
            [OperationContract]
            IList<DmNhomvattu1> GetByMaNhomVT(string MaNhom, Guid DonViId);
            [OperationContract]
            IList<DmNhomvattu1> GetAllByNhom(Guid DonViId, Decimal LoaiNhom);
		}
	}
	