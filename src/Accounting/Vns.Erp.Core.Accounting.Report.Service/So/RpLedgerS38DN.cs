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
    public class RpLedgerS38DNService : GenericService<BcKetoan, System.Guid>, IRpLedgerS38DNService
    {
        public IRpLedgerAccountDao RpLedgerAccountDao
        {
            get { return (IRpLedgerAccountDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime TuNgay, DenNgay;
            String MaTk;
            Guid DonviId;
            TuNgay = (DateTime)lstValues[0];
            DenNgay = (DateTime)lstValues[1];
            MaTk = (String)lstValues[2];
            DonviId = (Guid)lstValues[3];

            return RpLedgerAccountDao.GetDataS38Dn(MaTk, DonviId, TuNgay, DenNgay);
        }

        

    }
}
