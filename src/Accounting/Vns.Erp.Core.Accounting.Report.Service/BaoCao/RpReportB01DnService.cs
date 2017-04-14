using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;
using Vns.Erp.Core.Accounting.Report.Dao;
using Vns.Erp.Core.Admin.Dao;
using System.Data;
using Vns.Erp.Core.Accounting.Report.Domain;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Report.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RpReportB01DnService : GenericService<BcKetoan, System.Guid>, IRpReportB01DnService
    {
        public IRpReportAccountDao RpReportAccountDao
        {
            get { return (IRpReportAccountDao)Dao; }
            set { Dao = value; }
        }

        private IKtHDongDao _KtHDongDao;
        public IKtHDongDao KtHDongDao
        {
            get { return _KtHDongDao; }
            set { _KtHDongDao = value; }
        }

        private IRpLedgerAccountDao _RpLedgerAccountDao;

        public IRpLedgerAccountDao RpLedgerAccountDao
        {
            get { return _RpLedgerAccountDao; }
            set { _RpLedgerAccountDao = value; }
        }


        public override DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            DateTime TuNgay, DenNgay;
            String MaTk = "", MaTkDu = "";
            Guid DonviId;
            Guid BaoCaoId;

            BaoCaoId = VnsConvert.CGuid(lstValues[0]);
            IList<KtHDong> lstKtDong = _KtHDongDao.GetByBaocaoId4Report(BaoCaoId);

            TuNgay = (DateTime)lstValues[1];
            DenNgay = (DateTime)lstValues[2];
            DonviId = (Guid)lstValues[3];

            List<RpKtHDong> lstRp = new List<RpKtHDong>();
            foreach (KtHDong tmp in lstKtDong)
            {
                RpKtHDong rptmp = new RpKtHDong(tmp);
                //tmp.HamTinh = tmp.HamTinh + "_DK";
                rptmp.C1 = _RpLedgerAccountDao.Get_GiaTri_BaoCao(tmp, TuNgay, DenNgay, DonviId);
                
                lstRp.Add(rptmp);
            }

            ReportCommon rpCommon = new ReportCommon();
            for (int i = 0; i <  10; i++)
            {
                foreach (RpKtHDong dr in lstRp)
                {
                    if (!String.IsNullOrEmpty(dr.CachTinh) && (dr.Nhom == i))
                    {
                        dr.C1 = rpCommon.FUNC_GET_ADD_VALUE_BC(dr.CachTinh, "z", lstRp, Null.NullGuid);
                    }

                }
            }

            DataTable dt = rpCommon.FUN_PIVOT_ReportObject(lstRp);

            return dt;
        }
    }
}
