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
    public class RpBangKeThueMuaVaoService : GenericService<BcKetoan, System.Guid>, IRpBangKeThueMuaVaoService
    {
        public IRpLedgerTaxDao RpLedgerTaxDao
        {
            get { return (IRpLedgerTaxDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime NgayDk, NgayCk;
            //String MaTk = "333";
            String MaTk = Generals.TS_ThueGTGTDauVao.GiaTri;
            Guid DonviId;
            NgayDk = (DateTime)lstValues[0];
            NgayCk = (DateTime)lstValues[1];
            DonviId = VnsConvert.CGuid(lstValues[2].ToString());

            return RpLedgerTaxDao.GetDataBangKeThue(MaTk, NgayDk, NgayCk, DonviId);
        }
    }
}
