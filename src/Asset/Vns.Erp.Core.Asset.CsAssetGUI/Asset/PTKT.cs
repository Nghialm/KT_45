using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Asset.Domain;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class PTKT
    {
        #region "Property"
        private ITsTscdPtungService _TsTscdPtungService;
        public ITsTscdPtungService TsTscdPtungService
        {
            get { return _TsTscdPtungService; }
            set { _TsTscdPtungService = value; }
        }
        #endregion

        public DataTable GetData(Guid TSCD_ID)
        {
            DataTable dt = new DataTable();
            dt = DataHelper.ToDataTable<TsTscdPtung>(_TsTscdPtungService.GetAllByTSCD_ID(TSCD_ID));
            return dt;
        }

    }
}