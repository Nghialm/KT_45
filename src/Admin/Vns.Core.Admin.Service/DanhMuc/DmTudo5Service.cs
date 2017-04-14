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
    public class DmTudo5Service : GenericService<DmTudo5, System.Guid>, IDmTudo5Service
    {
        public IDmTudo5Dao DmTudo5Dao
        {
            get { return (IDmTudo5Dao)Dao; }
            set { Dao = value; }
        }

        public IList<DmTudo5> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return DmTudo5Dao.List(-1, -1, props, values, null);
        }
    }
}
