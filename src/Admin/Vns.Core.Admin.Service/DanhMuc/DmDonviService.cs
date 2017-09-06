using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DmDonviService : GenericService<DmDonvi, System.Guid>, IDmDonviService
    {
        public IDmDonviDao DmDonviDao
        {
            get { return (IDmDonviDao)Dao; }
            set { Dao = value; }
        }
        
        public IList<DmDonvi> GetListDonVi()
        {
            return DmDonviDao.GetAll();
        }
    }
}
