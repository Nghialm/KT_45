using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

namespace Vns.Erp.Core.Controls.UserControl
{
    public partial class C_SoChungTu
    {

        #region "Properties"

        private string _PREPIX;

        private string _SO_CHUNG_TU;
        #region "Property"
        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }
        #endregion

        public string SO_CHUNG_TU
        {
            get { return _SO_CHUNG_TU; }
            set { _SO_CHUNG_TU = value; }
        }

        public string SoChungTu
        {
            get
            {
                if (String.IsNullOrEmpty(_PREPIX)) 
                    return _SO_CHUNG_TU;
                else
                    return String.Format(_PREPIX, _SO_CHUNG_TU);
            }
        }

        public string PREFIX
        {
            get { return _PREPIX; }
            set { _PREPIX = value; }
        }

        public override string Text
        {
            get { return txtSO_CT.Text; }
            set { txtSO_CT.Text = value; }
        }
        #endregion

        #region "Events"

        public void r_SoCTPREFIX(Guid p_LOAICHUNGTU_ID, decimal p_THANG, decimal p_NAM, Guid p_DONVI_ID)
        {
            if ((_HtLoaichungtuService == null))
            {
                _HtLoaichungtuService = (IHtLoaichungtuService)ObjectFactory.GetObject("HtLoaichungtuService");
            }
            List<string> lst = _HtLoaichungtuService.GetSoCT_prefix(p_LOAICHUNGTU_ID, p_THANG, p_NAM, p_DONVI_ID);
            if (lst != null)
            {
                _PREPIX = lst[0];
                _SO_CHUNG_TU = lst[1];
            }
        }

        public void SetReadOnly()
        {
            txtSO_CT.Properties.ReadOnly = true;
        }

        private void C_SoChungTu_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (this.DesignMode)
                {
                    return;
                }
                //txtSO_CT.Text = _SO_CHUNG_TU
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        public C_SoChungTu()
        {
            InitializeComponent();
        }
        #endregion

    }
}