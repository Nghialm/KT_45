using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;
using Vns.Erp.Core.Accounting.Report.Dao;
using System.Data;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Report.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RpTheTscdS23DnService : GenericService<BcKetoan, System.Guid>, IRpTheTscdS23DnService
    {
        public IRpLedgerAssetDao RpLedgerAssetDao
        {
            get { return (IRpLedgerAssetDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            Guid TscdId;
            TscdId = VnsConvert.CGuid(lstValues[0].ToString());

            return RpLedgerAssetDao.GetTheTscd(TscdId);
        }

        public DataTable GetData(Guid TscdId)
        {
            return RpLedgerAssetDao.GetTheTscd(TscdId);
        }
    }
}
