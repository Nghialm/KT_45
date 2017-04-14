using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IAppDvFormService:IErpService<AppDvForm, decimal>
	{
        [OperationContract]
        IList<AppDvForm> GetByDV(Guid DV_ID);
        [OperationContract]
        void DeleteByDVF(Guid DV_ID, decimal FORM_ID);
        [OperationContract]
        void DeleteByForm(decimal FORM_ID);
        [OperationContract]
        IList<AppGroupForms> GetByDonviID(Guid DonviID);
	}
}
