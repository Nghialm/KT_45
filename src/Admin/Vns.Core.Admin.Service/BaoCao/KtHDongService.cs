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
	public class KtHDongService:GenericService<KtHDong,System.Guid>, IKtHDongService
	{
	    public IKtHDongDao KtHDongDao
        {
            get { return (IKtHDongDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtHDong> GetBy_BAOCAO_Id(System.Guid BaocaoId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("BaocaoId");
            values.Add(BaocaoId);
            IList<Core.Domain.VnsOrder> lstorder = new List<Core.Domain.VnsOrder>();
            lstorder.Add(new Core.Domain.VnsOrder(true, "ThuTu"));
            lstorder.Add(new Core.Domain.VnsOrder(true, "MaSo"));
            IList<KtHDong> lst = List(-1, -1, props, values, lstorder);

            return lst;
        }

        public void DeleteByBaoCaoId(System.Guid BaocaoId)
        {
            KtHDongDao.DeleteByBaoCaoId(BaocaoId);
        }

	}
}