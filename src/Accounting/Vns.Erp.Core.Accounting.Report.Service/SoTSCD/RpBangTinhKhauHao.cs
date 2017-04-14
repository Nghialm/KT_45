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
    public class RpBangTinhKhauHao : GenericService<BcKetoan, System.Guid>, IRpBangTinhKhauHao
    {
        public IRpLedgerAssetDao RpLedgerAssetDao
        {
            get { return (IRpLedgerAssetDao)Dao; }
            set { Dao = value; }
        }

        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime NgayDk, NgayCk;
            String MaTk;
            Guid DonviId, KhoId, HanghoaId;
            NgayDk = (DateTime)lstValues[0];
            NgayCk = (DateTime)lstValues[1];
            //MaTk = (String)lstValues[2];
            //KhoId =  VnsConvert.CGuid( lstValues[3].ToString());
            //HanghoaId = VnsConvert.CGuid( lstValues[4].ToString());
            DonviId = VnsConvert.CGuid( lstValues[7].ToString());

            return RpLedgerAssetDao.GetBangTinhKhauHao(NgayDk, NgayCk, DonviId);
        }
        
    }
}
