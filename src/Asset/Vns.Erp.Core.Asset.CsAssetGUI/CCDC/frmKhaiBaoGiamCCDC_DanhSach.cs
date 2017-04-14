using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;

using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Asset.Domain;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoGiamCCDC_DanhSach
    {

        #region "Properties"

        private ICcCtCcdcService _CcCtCcdcService;
        public ICcCtCcdcService CcCtCcdcService
        {
            get { return _CcCtCcdcService; }
            set { _CcCtCcdcService = value; }
        }

        private ICcDmCcdcService _CcDmCcdcService;
        public ICcDmCcdcService CcDmCcdcService
        {
            get { return _CcDmCcdcService; }
            set { _CcDmCcdcService = value; }
        }

        #endregion

        #region "Variables"
        private Guid CT_CCDC_id;
        #endregion
        private CcCtCcdc objCtcdc;

        #region "Contructor"

        private void AddEvents()
        {
            this.Load +=new EventHandler(frmKhaiBaoGiamCCDC_DanhSach_Load);
            btnAdd.Click +=new EventHandler(btnAdd_Click);
            btnModify.Click += new EventHandler(btnModify_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
        }

        public frmKhaiBaoGiamCCDC_DanhSach()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }
        #endregion

        #region "Functions"

        private void DoLoadData()
        {
            List<CcCtCcdc> lstCT_CCDC = new List<CcCtCcdc>();
            lstCT_CCDC.AddRange(_CcCtCcdcService.GetByTrangThai(2));
            _gridControl.DataSource = lstCT_CCDC;
        }

        private void grv_focus()
        {
            TNCommon.GridView_SetRowFocus(_gridView, "MaCcdc", objCtcdc.MaCcdc);
        }

        private void DoCreate()
        {
            frmKhaiBaoGiamCCDC_ChiTiet frm = (frmKhaiBaoGiamCCDC_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoGiamCCDC_ChiTiet");
            objCtcdc = frm.Show_Form(Null.NullGuid, FormGlobals.DataInputState.AddMode);
            if (objCtcdc != null)
            {
                this.DoLoadData();
                grv_focus();
            }
        }

        private void DoModify()
        {
            if (_gridView.RowCount != 0)
            {
                int i = _gridView.FocusedRowHandle;

                if (i < 0)
                {
                    FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                    return;
                }
                CT_CCDC_id = ((CcCtCcdc)_gridView.GetRow(i)).Id;
                frmKhaiBaoGiamCCDC_ChiTiet frm = (frmKhaiBaoGiamCCDC_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoGiamCCDC_ChiTiet");
                objCtcdc = frm.Show_Form(CT_CCDC_id, FormGlobals.DataInputState.EditMode);
                if (objCtcdc != null)
                {
                    this.DoLoadData();
                    _gridView.FocusedRowHandle = i;
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
            }
        }

        private void DoDelete()
        {

            if (_gridView.RowCount != 0)
            {
                int i = _gridView.FocusedRowHandle;

                if (i < 0)
                {
                    FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                    return;
                }
                CT_CCDC_id = ((CcCtCcdc)_gridView.GetRow(i)).Id;
                if (FormGlobals.Message_Confirm("Bạn chắc chắn muốn xóa bản ghi này?"))
                {
                    CcDmCcdcService.DeleteKhaiBaoGiamCcdc(CT_CCDC_id, 2);
                    this.DoLoadData();
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
            }
        }

        #endregion

        #region "Events"

        private void frmKhaiBaoGiamCCDC_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                DoLoadData();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DoCreate();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnModify_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DoModify();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DoDelete();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnClose_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}