using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoCCDC_DanhSach
    {

        #region "Properties"
        private ICcDmCcdcService _CcDmCcdcService;
        public ICcDmCcdcService CcDmCcdcService
        {
            get { return _CcDmCcdcService; }
            set { _CcDmCcdcService = value; }
        }


        private ICcCtCcdcService _CcCtCcdcService;
        public ICcCtCcdcService CcCtCcdcService
        {
            get { return _CcCtCcdcService; }
            set { _CcCtCcdcService = value; }
        }


        private ICcCtCcdcNvonService _CcCtCcdcNvonService;
        public ICcCtCcdcNvonService CcCtCcdcNvonService
        {
            get { return _CcCtCcdcNvonService; }
            set { _CcCtCcdcNvonService = value; }
        }


        #endregion

        #region "Variables"
        private Guid CCDC_id;
        #endregion
        private CcDmCcdc objDmCcdc;

        #region "Contructor"
        public frmKhaiBaoCCDC_DanhSach()
        {
            InitializeComponent();

            LoadEvents();

            TNCommon.setIconControl(this);
        }

        private void LoadEvents()
        {
            this.Load += frmKhaiBaoCCDC_DanhSach_Load;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnModify.Click += new EventHandler(btnModify_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
        }
        #endregion

        #region "Functions"

        private void DoLoadData()
        {
            List<CcDmCcdc> lstCCDC = new List<CcDmCcdc>();
            lstCCDC.AddRange(_CcDmCcdcService.GetAllByDonviID(Generals.DON_VI.Id));
            grcCCDC.DataSource = lstCCDC;
        }

        private void grv_focus()
        {
            TNCommon.GridView_SetRowFocus(grvCCDC, "MaCcdc", objDmCcdc.MaCcdc);
        }

        private void DoCreate()
        {
            frmKhaiBaoCCDC_ChiTiet frm = (frmKhaiBaoCCDC_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoCCDC_ChiTiet");
            objDmCcdc = frm.Show_Form(Null.NullGuid, FormGlobals.DataInputState.AddMode);
            if (objDmCcdc != null)
            {
                this.DoLoadData();
                grv_focus();
            }
        }

        private void DoModify()
        {
            if (grvCCDC.RowCount != 0)
            {
                int i = grvCCDC.FocusedRowHandle;

                if (i < 0)
                {
                    FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                    return;
                }

                CCDC_id = ((CcDmCcdc)grvCCDC.GetRow(i)).Id;

                frmKhaiBaoCCDC_ChiTiet frm = (frmKhaiBaoCCDC_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoCCDC_ChiTiet");
                objDmCcdc = frm.Show_Form(CCDC_id, FormGlobals.DataInputState.EditMode);
                if (objDmCcdc != null)
                {
                    this.DoLoadData();
                    grvCCDC.FocusedRowHandle = i;
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
            }
        }

        private void DoDelete()
        {

            if (grvCCDC.RowCount != 0)
            {
                int i = grvCCDC.FocusedRowHandle;

                if (i < 0)
                {
                    FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                    return;
                }
                CCDC_id = ((CcDmCcdc)grvCCDC.GetRow(i)).Id;
                if (FormGlobals.Message_Confirm("Bạn chắc chắn muốn xóa bản ghi này?"))
                {
                    CcDmCcdcService.DeleteCCDC(CCDC_id);
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

        private void frmKhaiBaoCCDC_DanhSach_Load(System.Object sender, System.EventArgs e)
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
