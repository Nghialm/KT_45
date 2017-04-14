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
    public class HtThamsoService : GenericService<HtThamso, Guid>, IHtThamsoService
    {
        public IHtThamsoDao HtThamsoDao
        {
            get { return (IHtThamsoDao)Dao; }
            set { Dao = value; }
        }

        public void DeleteByDonviId(Guid DonviId)
        {
            HtThamsoDao.DeleteByDonviId(DonviId);
        }

        public HtThamso GetByMaThamSo(string MaThamSo, System.Guid DonviID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaThamso");
            values.Add(MaThamSo);
            props.Add("DonviId");
            values.Add(DonviID);

            IList<HtThamso> lst = HtThamsoDao.List(-1, -1, props, values, null);
            if (lst == null || lst.Count == 0) return null;
            else
                return lst[0];
        }

        public IList<HtThamso> GetByGroupID_ds(Guid GroupId, Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("GroupId");
            values.Add(GroupId);
            props.Add("DonviId");
            values.Add(DonviId);

            return HtThamsoDao.List(-1, -1, props, values, null);
        }

        public IList<HtThamso> GetByDonviId(Guid DonviID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviID);

            return HtThamsoDao.List(-1, -1, props, values, null);
        }
    }
}
