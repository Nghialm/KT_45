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
    public class TsCtTscdNvonService : GenericService<TsCtTscdNvon, System.Guid>, ITsCtTscdNvonService
    {
        public ITsCtTscdNvonDao TsCtTscdNvonDao
        {
            get { return (ITsCtTscdNvonDao)Dao; }
            set { Dao = value; }
        }

        public IList<TsCtTscdNvon> GetAllByCT_TSCD_ID(Guid CtTscdId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CtTscdId");
            values.Add(CtTscdId);
            return List(-1, -1, props, values, null);
        }

        public IList<TsCtTscdNvon> GetAllByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<TsCtTscdNvon> GetByDmTscdId(Guid DmTscdId)
        {
            return TsCtTscdNvonDao.GetByDmTscdId(DmTscdId);
        }
        
    }
}
