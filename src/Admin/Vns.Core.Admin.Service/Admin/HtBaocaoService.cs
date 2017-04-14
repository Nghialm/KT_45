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
    public class HtBaocaoService : GenericService<HtBaocao, Guid>, IHtBaocaoService
    {
        public IHtBaocaoDao HtBaocaoDao
        {
            get { return (IHtBaocaoDao)Dao; }
            set { Dao = value; }
        }

        public IList<HtBaocao> GetAllWithOrder()
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();

            List<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Core.Domain.VnsOrder>();
            lstOrder.Add(new Vns.Erp.Core.Domain.VnsOrder(true, "ThuTu"));
            return HtBaocaoDao.List(-1, -1, null, null, lstOrder);
        }

        public IList<HtBaocao> GetByIDCha(Guid ParentId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("IdCha");
            values.Add(ParentId);

            List<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Core.Domain.VnsOrder>();
            lstOrder.Add(new Vns.Erp.Core.Domain.VnsOrder(true, "ThuTu"));
            return HtBaocaoDao.List(-1, -1, props, values, lstOrder);
        }

        public HtBaocao GetByMa(String MaBaocao)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaBaocao");
            values.Add(MaBaocao);

            IList<HtBaocao> lst = HtBaocaoDao.List(-1, -1, props, values, null);
            if (lst != null && lst.Count > 0)
                return lst[0];

            return null;
        }
    }
}
