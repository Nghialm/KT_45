using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtHCotService:GenericService<KtHCot,System.Guid>, IKtHCotService
	{
	    public IKtHCotDao KtHCotDao
        {
            get { return (IKtHCotDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtHCot> GetBy_Dong_Id(System.Guid DongId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("BaocaoId");
            values.Add(DongId);
            IList<KtHCot> lst = List(-1, -1, props, values, null);

            return lst;
        }
	}
}