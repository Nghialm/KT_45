using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Asset.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TsTscdPtungService : GenericService<TsTscdPtung, System.Guid>, ITsTscdPtungService
    {
        public ITsTscdPtungDao TsTscdPtungDao
        {
            get { return (ITsTscdPtungDao)Dao; }
            set { Dao = value; }
        }

        public IList<TsTscdPtung> GetAllByCT_TSCD_ID(Guid CtTscdId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtTscdId");
            values.Add(CtTscdId);
            return List(-1, -1, props, values, null);
        }

        public IList<TsTscdPtung> GetAllByTSCD_ID(Guid DmTscdId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DmTscdId");
            values.Add(DmTscdId);
            return List(-1, -1, props, values, null);
        }
    }
}
