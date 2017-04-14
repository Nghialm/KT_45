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

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucNhomTSCD_ChiTiet : FrmBaseDmChiTiet
    {
        IDmNhomTscdService _DmNhomTscdService;
        public IDmNhomTscdService DmNhomTscdService
        {
            get { return _DmNhomTscdService; }
            set { _DmNhomTscdService = value; }
        }
        private DmNhomTscd objDM_NHOM_TSCD = new DmNhomTscd();
        private FormGlobals.DataInputState m_InputState;
        private string m_NHOM_TSCD;

        private string p_MaNhom_TSCD;
        public frmDanhMucNhomTSCD_ChiTiet()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        public DmNhomTscd Show_Form(string NHOM_TSCD_ID, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_NHOM_TSCD = NHOM_TSCD_ID;
                if ((eState == FormGlobals.DataInputState.AddMode))
                {
                    this.txtLOAI_NHOM.Text = "";
                    this.txtMA_NHOM_TSCD.Text = "";
                    this.txtTEN_NHOM_TSCD.Text = "";
                    m_NHOM_TSCD = Guid.NewGuid().ToString();
                }
                //Panel_InitControl(pnNHOM_TSCD, "DM_NHOM_TSCD")
                FormGlobals.Control_SetRequire(txtLOAI_NHOM, true);
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            if (this.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return objDM_NHOM_TSCD;
            }
            else
            {
                return null;
            }
        }

        private void Init_Data()
        {
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.EditMode:
                    SetObjectToControl();
                    break;
            }
        }

        private void GetControlToObject()
        {
            //Panel_GetControlValue(pnNHOM_TSCD, objDM_NHOM_TSCD)
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    objDM_NHOM_TSCD = new DmNhomTscd();
                    objDM_NHOM_TSCD.Id = Guid.Empty;
                    objDM_NHOM_TSCD.NguoiTao = Generals.USER.Id;
                    objDM_NHOM_TSCD.NgayTao = DateTime.Now;
                    objDM_NHOM_TSCD.NgaySua = DateTime.Now;
                    break;
                case FormGlobals.DataInputState.EditMode:
                    objDM_NHOM_TSCD.NguoiSua = Generals.USER.Id;
                    objDM_NHOM_TSCD.NgaySua = DateTime.Now;
                    break;
            }
            objDM_NHOM_TSCD.MaNhomTscd = this.txtMA_NHOM_TSCD.Text;
            objDM_NHOM_TSCD.LoaiNhom = Decimal.Parse(this.txtLOAI_NHOM.Text);
            objDM_NHOM_TSCD.TenNhomTscd = this.txtTEN_NHOM_TSCD.Text;
            objDM_NHOM_TSCD.DonviId = Generals.DON_VI.Id;
            DmNhomTscdService.SaveOrUpdate(objDM_NHOM_TSCD);
        }

        private void SetObjectToControl()
        {
            objDM_NHOM_TSCD = DmNhomTscdService.GetById(new Guid(m_NHOM_TSCD));
            p_MaNhom_TSCD = objDM_NHOM_TSCD.MaNhomTscd;
            this.txtLOAI_NHOM.EditValue = objDM_NHOM_TSCD.LoaiNhom;
            this.txtMA_NHOM_TSCD.Text = objDM_NHOM_TSCD.MaNhomTscd;
            this.txtTEN_NHOM_TSCD.Text = objDM_NHOM_TSCD.TenNhomTscd;
            //Panel_SetControlValue(pnNHOM_TSCD, objDM_NHOM_TSCD)
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string ma_Nhom_tscd = "";
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        ma_Nhom_tscd = txtMA_NHOM_TSCD.Text;
                        break;
                    case FormGlobals.DataInputState.EditMode:
                        if (!p_MaNhom_TSCD.Equals(txtMA_NHOM_TSCD.Text))
                        {
                            ma_Nhom_tscd = txtMA_NHOM_TSCD.Text;
                        }
                        else
                        {
                            ma_Nhom_tscd = "";
                        }
                        break;
                }

                if (String.IsNullOrEmpty(txtMA_NHOM_TSCD.Text))
                {
                    FormGlobals.Message_Warning("Bạn chưa nhập mã nhóm TSCD");
                    txtMA_NHOM_TSCD.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtTEN_NHOM_TSCD.Text))
                {
                    FormGlobals.Message_Warning("Bạn chưa nhập tên nhóm TSCD");
                    txtTEN_NHOM_TSCD.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtLOAI_NHOM.Text))
                {
                    FormGlobals.Message_Warning("Bạn chưa nhập loại nhóm TSCD");
                    txtLOAI_NHOM.Focus();

                    return;
                }

                if ((FormGlobals.Panel_CheckError(pnNHOM_TSCD) & CheckMa(ma_Nhom_tscd)))
                {
                    frmProgress.Instance().Thread = GetControlToObject;
                    frmProgress.Instance().Show_Progress();
                    frmProgress.Instance().SetFinishText("Date saved");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnXoaTrang_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                txtLOAI_NHOM.Text = string.Empty;
                txtTEN_NHOM_TSCD.Text = string.Empty;
                txtMA_NHOM_TSCD.Text = string.Empty;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnClose_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private bool CheckMa(string Ma_nhom)
        {
            try
            {
                IList<DmNhomTscd> dt = DmNhomTscdService.GetMA_NHOM_TSCD(Ma_nhom);
                if ((dt.Count != 0))
                {
                    FormGlobals.Message_Information("Mã nhóm tài khoản đã tồn tại!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
                return false;
            }
        }

    }
}