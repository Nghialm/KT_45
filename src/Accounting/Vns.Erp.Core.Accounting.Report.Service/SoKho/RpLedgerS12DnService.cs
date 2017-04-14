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
    public class RpLedgerS12DnService : GenericService<BcKetoan, System.Guid>, IRpLedgerS10DnService
    {
        public IRpLedgerStoreDao RpLedgerStoreDao
        {
            get { return (IRpLedgerStoreDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime NgayDk, NgayCk;
            String MaTk = "";
            Guid DonviId, KhoId, HanghoaId;
            NgayDk = (DateTime)lstValues[0];
            NgayCk = (DateTime)lstValues[1];
            //MaTk = (String)lstValues[2];
            KhoId = VnsConvert.CGuid(lstValues[2].ToString());
            HanghoaId = VnsConvert.CGuid(lstValues[3].ToString());
            DonviId = VnsConvert.CGuid(lstValues[4].ToString());

            return RpLedgerStoreDao.GetDataS10Dn(NgayDk, NgayCk, MaTk, KhoId, HanghoaId, DonviId);
        }
    }
}
