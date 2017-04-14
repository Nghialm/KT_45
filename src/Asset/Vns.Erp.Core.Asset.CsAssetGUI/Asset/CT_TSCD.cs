using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Accounting.Report.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class CT_TSCD 
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
        #endregion

        public object Bindata(Guid TSCD_ID)
        {
            return _RpTheTscdS23DnService.GetData(TSCD_ID);
        }
    }
}