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
    public class AppCtStatusService : GenericService<AppCtStatus, System.Guid>, IAppCtStatusService
    {
        public IAppCtStatusDao AppCtStatusDao
        {
            get { return (IAppCtStatusDao)Dao; }
            set { Dao = value; }
        }

        public System.Collections.Generic.IList<AppCtStatus> GetAllByDonviID(Guid DONVI_ID)
        {
            return AppCtStatusDao.GetAllByDonviID(DONVI_ID);
        }

        public System.Collections.Generic.IList<AppCtStatus> GetByDVGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId)
        {
            return AppCtStatusDao.GetByDVGCT(donvi_id, group_id, LoaiCtId);
        }

        public void DeleteByDGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId)
        {
            AppCtStatusDao.DeleteByDGCT(donvi_id, group_id, LoaiCtId);
        }
        public IList<HtLoaichungtu> GetLCTByDVG(Guid donvi_id, Guid  group_id)
        {
            return AppCtStatusDao.GetLCTByDVG(donvi_id, group_id);
        }
    }
}
