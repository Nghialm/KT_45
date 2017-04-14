using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class The_TSCD
    {

        #region "Property"
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private IRpTheTscdS23DnService _RpTheTscdS23DnService;
        public IRpTheTscdS23DnService RpTheTscdS23DnService
        {
            get { return _RpTheTscdS23DnService; }
            set { _RpTheTscdS23DnService = value; }
        }

        private ITsTscdPtungService _TsTscdPtungService;
        public ITsTscdPtungService TsTscdPtungService
        {
            get { return _TsTscdPtungService; }
            set { _TsTscdPtungService = value; }
        }
        #endregion

        private string m_TSCD_ID;
        private string LastID = "";
        private int PageNumber = 0;

        private List<DmTscd> lstDmTscd = new List<DmTscd>();
        public The_TSCD(string p_TSCD_ID)
        {
            InitializeComponent();
            BeforePrint += The_TSCD_BeforePrint;
            XrSubreport1.BeforePrint += XrSubreport1_BeforePrint;
            XrSubreport2.BeforePrint += XrSubreport2_BeforePrint;
            m_TSCD_ID = p_TSCD_ID;
        }

        public The_TSCD(string p_TSCD_ID, List<DmTscd> lstTscd)
        {
            InitializeComponent();
            BeforePrint += The_TSCD_BeforePrint;
            XrSubreport1.BeforePrint += XrSubreport1_BeforePrint;
            XrSubreport2.BeforePrint += XrSubreport2_BeforePrint;
            m_TSCD_ID = p_TSCD_ID;
            lstDmTscd = new List<DmTscd>();
            lstDmTscd.AddRange(lstTscd);
        }

        private void XrSubreport2_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            CT_TSCD prt_ts = (CT_TSCD)((XRSubreport)sender).ReportSource;
            prt_ts.RpTheTscdS23DnService = _RpTheTscdS23DnService;
            prt_ts.DataSource = prt_ts.Bindata(VnsConvert.CGuid(GetCurrentColumnValue("Id")));
        }

        private void XrSubreport1_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PTKT rpt_PT = (PTKT)((XRSubreport)sender).ReportSource;
            rpt_PT.TsTscdPtungService = _TsTscdPtungService;
            rpt_PT.DataSource = rpt_PT.GetData(VnsConvert.CGuid(this.GetCurrentColumnValue("Id")));
        }

        private void The_TSCD_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataTable ds_TSCD = DataHelper.ToDataTable(lstDmTscd);
            this.DataSource = ds_TSCD;

            lblDon_VI.Text = Generals.DON_VI.TenDonvi;
            lblDia_Chi.Text = Generals.DON_VI.DiaChi;
        }

        private void xrPage_PrintOnPage(System.Object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            //Try
            string CurID = ((XRLabel)sender).Tag.ToString();
            int PageCount = 0;

            foreach (Page MyPage in this.PrintingSystem.Pages)
            {
                BrickEnumerator BrickEnum = MyPage.GetEnumerator();

                while (BrickEnum.MoveNext())
                {
                    VisualBrick Brick = (VisualBrick)BrickEnum.Current;

                    if ((Brick != null) & object.ReferenceEquals(Brick.BrickOwner, (XRLabel)sender))
                    {
                        if (Brick.Value.ToString() == CurID)
                        {
                            PageCount += 1;
                        }
                    }
                }
            }

            if (CurID == LastID)
            {
                PageNumber += 1;
            }
            else
            {
                PageNumber = 1;
            }

            LastID = CurID;
            ((XRLabel)sender).Text = "Page " + PageNumber.ToString() + " of " + PageCount.ToString();
            //Catch ex As Exception
            //End Try
        }
    }
}