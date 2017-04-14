using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Accounting.Dao;
using System.Data;
using Vns.Erp.Core.Accounting.Report.Dao;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Report.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RpLedgerS03DnService : GenericService<BcKetoan, System.Guid>, IRpLedgerS07DnService
    {
        public IRpLedgerAccountDao RpLedgerAccountDao
        {
            get { return (IRpLedgerAccountDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime TuNgay, DenNgay;
            String MaTk, MaTkDu;
            Guid DonviId;
            TuNgay = (DateTime)lstValues[0];
            DenNgay = (DateTime)lstValues[1];
            MaTk = (String)lstValues[2];
            MaTkDu = (String)lstValues[3];
            DonviId = (Guid)lstValues[4];

            return RpLedgerAccountDao.GetDataS03a_SoNhatKyChung(MaTk, MaTkDu, TuNgay, DenNgay, DonviId);
        }
    }
}
