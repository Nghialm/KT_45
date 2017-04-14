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
	public class KtKhoaSoNgayService:GenericService<KtKhoaSoNgay,System.Guid>, IKtKhoaSoNgayService
	{
	    public IKtKhoaSoNgayDao KtKhoaSoNgayDao
        {
            get { return (IKtKhoaSoNgayDao)Dao; }
            set { Dao = value; }
        }

        public KtKhoaSoNgay GetByDonvi(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonViId");
            values.Add(DonviId);
            IList<KtKhoaSoNgay> ls = List(-1, -1, props, values, null);
            if (ls == null || ls.Count == 0)
                return null;
            else
                return ls[0];
        }
	}
}