using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtThueService : GenericService<CtThue, System.Guid>, ICtThueService
    {
        public ICtThueDao CtThueDao
        {
            get { return (ICtThueDao)Dao; }
            set { Dao = value; }
        }

        public IList<CtThue> GetObjectAllByCTD_ID(Guid CtdId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtdId");
            values.Add(CtdId);
            return List(-1, -1, props, values, null);
        }

        public CtThue GetObjectAllByCTDNX_ID(Guid CtdNxId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtdNxId");
            values.Add(CtdNxId);
            IList<CtThue> lst = List(-1, -1, props, values, null);
            if (lst.Count > 0)
                return lst[0];
            else
                return null;
        }

        public IList<CtThue> GetObjectbyCtHoaDon(Guid CtHoadonId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtHoadonId");
            values.Add(CtHoadonId);

            IList<VnsOrder> lstOrder = new List<VnsOrder>();
            lstOrder.Add(new VnsOrder(true,"SoThuTu"));
            return List(-1, -1, props, values, lstOrder);
        }
    }
}
