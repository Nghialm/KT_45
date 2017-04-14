using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtDuluongDaukyService:GenericService<KtDuluongDauky,String>, IKtDuluongDaukyService
	{
	    public IKtDuluongDaukyDao KtDuluongDaukyDao
        {
            get { return (IKtDuluongDaukyDao)Dao; }
            set { Dao = value; }
        }
	}
}