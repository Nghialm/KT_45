using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucNguonVon_tscd_ChiTiet : FrmBaseDmChiTiet
    {

        #region "Variables"
        private DmNguonTscd objNguonVon = new DmNguonTscd();
        //Private objNguonVonBO As IDmBtKetchuyenService
        //Public Property DmBtKetchuyenService() As IDmBtKetchuyenService
        //    Get
        //        Return objNguonVonBO
        //    End Get
        //    Set(ByVal value As IDmBtKetchuyenService)
        //        objNguonVonBO = value
        //    End Set
        //End Property


        IDmNguonTscdService _DmNguonTscdService;
        public IDmNguonTscdService DmNguonTscdService
        {
            get { return _DmNguonTscdService; }
            set { _DmNguonTscdService = value; }
        }

        private FormGlobals.DataInputState m_InputState;
        private string m_NV_tscd;
        #endregion
        private string p_Ma_Nguon_TSCD;

        #region "Funtions"

        #region "Overrides Function and Property"
        public frmDanhMucNguonVon_tscd_ChiTiet()
        {
            InitializeComponent();
            this.Load +=new EventHandler(frmDanhMucNguonVon_tscd_ChiTiet_Load);
        }
        public DmNguonTscd ObjectInfo
        {
            get
            {
                if ((ID != null))
                {
                    objNguonVon = DmNguonTscdService.Get(VnsConvert.CGuid(ID));
                }
                else
                {
                    objNguonVon = new DmNguonTscd();
                }
                objNguonVon.MaDmNguonTscd = txtMaTSCD.Text;
                objNguonVon.TenDmNguonTscd = txtTenTSCD.Text;
                objNguonVon.KyHieu = txtKYHIEU.Text;
                objNguonVon.MoTa = txtMOTA.Text;
                objNguonVon.DonviId = Generals.DON_VI.Id;
                objNguonVon.MaDonvi = Generals.DON_VI.MaDonvi;
                objNguonVon.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked);
                objNguonVon.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked);
                base.ResultObject = objNguonVon;
                return objNguonVon;
            }
            set
            {
                if ((value != null))
                {
                    objNguonVon = value;
                    p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd;
                    txtMaTSCD.Text = objNguonVon.MaDmNguonTscd;
                    txtTenTSCD.Text = objNguonVon.TenDmNguonTscd;
                    txtKYHIEU.Text = objNguonVon.KyHieu;
                    txtMOTA.Text = objNguonVon.MoTa;
                    chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objNguonVon.CoSuDung);
                    chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(objNguonVon.ChoPhepSua);
                }
            }
        }

        public override void InitProperty()
        {
            Title = "Danh mục nguồn tài sản cố định";
            TableName = "DmNguonTscd";
            //RequireInputControls = New Control() {txtMaTSCD, txtKYHIEU, txtTenTSCD}
            ButtonSave = btnSave;
            ButtonClear = btnClear;
            ButtonCancel = btnCancel;
            //GroupControlObjectInfo = _GroupControlObjectInfo
            TNCommon.setIconControl(this);
        }

        public override void InitComponet()
        {
            //InitializeComponent() ' Not Use because of using in the design view
        }

        public override void BindLookUpEdit()
        {
            switch (Mode)
            {
                case FormGlobals.DataInputState.AddMode:
                    ClearObjectToControl();
                    break;
            }

        }

        public override void ValidateData(object sender, CancelEventArgs e)
        {
            //If txtMaTSCD.Text.Trim = "" Then
            //    Message_Warning("Bạn chưa nhập mã nguồn TSCD")
            //    txtMaTSCD.Focus()
            //    Exit Sub
            //End If

            //If txtKYHIEU.Text.Trim = "" Then
            //    Message_Information("Bạn chưa nhập ký hiệu nguồn TSCD ")
            //    txtKYHIEU.Focus()
            //    Exit Sub
            //End If

            //If txtTenTSCD.Text.Trim = "" Then
            //    Message_Information("Bạn chưa nhập tên nguồn TSCD ")
            //    txtTenTSCD.Focus()
            //    Exit Sub
            //End If
        }

        public void Save()
        {
            try
            {
                DmNguonTscd info = ObjectInfo;
                switch (Mode)
                {
                    case FormGlobals.DataInputState.AddMode:
                        ID = DmNguonTscdService.Save(info).Id;
                        break;
                    case FormGlobals.DataInputState.EditMode:
                        DmNguonTscdService.SaveOrUpdate(info);
                        break;
                }
                AfterSaveSuccess();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        public override void BindData()
        {
            try
            {
                ObjectInfo = DmNguonTscdService.GetById(VnsConvert.CGuid(ID));
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        private void frmDanhMucNguonVon_tscd_ChiTiet_Load(object sender, EventArgs e)
        {
            InitProperty();
            CommonInit();
        }

        private void ClearObjectToControl()
        {
            objNguonVon = new DmNguonTscd();
            m_NV_tscd = Guid.NewGuid().ToString();
            p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd;
            txtMaTSCD.Text = objNguonVon.MaDmNguonTscd;
            txtTenTSCD.Text = objNguonVon.TenDmNguonTscd;
            txtKYHIEU.Text = objNguonVon.KyHieu;
            txtMOTA.Text = objNguonVon.MoTa;
            chkCO_SU_DUNG.Checked = false;
            chkCHO_PHEP_SUA.Checked = false;
        }

        private void SetObjectToControl()
        {
            objNguonVon = DmNguonTscdService.GetById(new Guid(m_NV_tscd));
            p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd;
            txtMaTSCD.Text = objNguonVon.MaDmNguonTscd;
            txtTenTSCD.Text = objNguonVon.TenDmNguonTscd;
            txtKYHIEU.Text = objNguonVon.KyHieu;
            txtMOTA.Text = objNguonVon.MoTa;
            chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objNguonVon.CoSuDung);
            chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(objNguonVon.ChoPhepSua);
        }

        private bool Check_ma(string Ma_Nguon)
        {
            IList<DmNguonTscd> dt = DmNguonTscdService.GetByMaNguon(Ma_Nguon, Generals.DON_VI.Id);
            if (dt.Count != 0)
            {
                FormGlobals.Message_Warning("Mã nguồn TSCD đã tồn tại");
                txtMaTSCD.Focus();
                return false;
            }
            return true;
        }

        #endregion
        public override void Saving()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTSCD.Text.Trim()))
                {
                    FormGlobals.Message_Warning("Bạn chưa nhập mã nguồn TSCD");
                    txtMaTSCD.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtKYHIEU.Text.Trim()))
                {
                    FormGlobals.Message_Information("Bạn chưa nhập ký hiệu nguồn TSCD ");
                    txtKYHIEU.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtTenTSCD.Text.Trim()))
                {
                    FormGlobals.Message_Information("Bạn chưa nhập tên nguồn TSCD ");
                    txtTenTSCD.Focus();
                    return;
                }
                Save();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
       
    }
}