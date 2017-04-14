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
	public class KtDieukienBcService:GenericService<KtDieukienBc,System.Guid>, IKtDieukienBcService
	{
	    public IKtDieukienBcDao KtDieukienBcDao
        {
            get { return (IKtDieukienBcDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtDieukienBc> GetBy_Dong_Id(System.Guid DongId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("IdDong");
            values.Add(DongId);
            IList<KtDieukienBc> lst = List(-1, -1, props, values, null);

            return lst;
        }
	}
}