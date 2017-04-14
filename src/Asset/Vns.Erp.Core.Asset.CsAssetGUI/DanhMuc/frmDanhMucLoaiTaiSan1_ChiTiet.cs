using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLoaiTaiSan1_ChiTiet : DevExpress.XtraEditors.XtraForm
    {

        #region "Variables and Messages"
        private FormGlobals.DataInputState m_InputState;
        private Guid m_ID;
        private DmLoaitaisan objInfo;
        private string p_ma;
        IDmLoaitaisanService _DmLoaiTaisanService;
        public Guid ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public virtual IDmLoaitaisanService DmLoaiTaisanService
        {
            get { return _DmLoaiTaisanService; }
            set { _DmLoaiTaisanService = value; }
        }
        #endregion

        #region "Load Form"

        public frmDanhMucLoaiTaiSan1_ChiTiet()
        {
            InitializeComponent();
            KeyDown += frmDanhMucTuDo1_ChiTiet_KeyDown;
            TNCommon.setIconControl(this);
        }

        public Guid Show_Form(string iID, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_SetText(this, "Danh mục loại tài sản chi tiết", FormGlobals.DataInputState.NoCaption);
                FormGlobals.Form_InitDialog(this);

                m_InputState = eState;
                if ((eState.Equals(FormGlobals.DataInputState.EditMode)))
                {
                    m_ID = new Guid(iID);
                }
                else
                {
                    m_ID = Guid.NewGuid();
                }

                frmProgress.Instance().Thread = Init_Form;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            if ((this.ShowDialog() == DialogResult.OK))
            {
                return m_ID;
            }
            else
            {
                return Null.NullGuid;
            }
        }

        #endregion

        #region "Private Function and Procedures"

        private void Init_Control()
        {
            FormGlobals.Control_SetRequire(txtKy_Hieu, true);
            FormGlobals.Control_SetRequire(cboLOAITAISAN_ID_CHA, true);
            FormGlobals.Control_SetRequire(txtTEN_LOAITAISAN, true);
            FormGlobals.Control_SetFont(this, FormGlobals.CS_FONT_NAME);
            //Panel_InitControl(Me._GroupControlObjectInfo, "DM_LOAITAISAN")
        }

        private void Init_Form()
        {
            Init_Control();
            Init_Data();
        }
        private void ClearForm()
        {
            this.txtKHUNG_TGSD1.Text = "";
            this.txtKy_Hieu.Text = "";
            this.txtTEN_LOAITAISAN.Text = "";
        }
        private void Init_Data()
        {
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    BindLookUpEdit();
                    ClearForm();
                    TNCommon.SelectFirst(cboLOAITAISAN_ID_CHA);
                    break;
                case FormGlobals.DataInputState.EditMode:
                    BindLookUpEdit();
                    Load_Data();
                    break;
            }
        }

        private void Load_Data()
        {
            objInfo = DmLoaiTaisanService.GetById(m_ID);
            p_ma = objInfo.KyHieu;
            this.txtKy_Hieu.Text = objInfo.KyHieu;
            this.txtTEN_LOAITAISAN.Text = objInfo.TenLoaitaisan;
            this.txtKHUNG_TGSD1.Text = objInfo.KhungTgsd.ToString();
            this.cboLOAITAISAN_ID_CHA.EditValue = objInfo.LoaitaisanIdCha.ToString();
            //Panel_SetControlValue(Me._GroupControlObjectInfo, objInfo, True)
            txtKHUNG_TGSD1.Text = objInfo.KhungTgsd.ToString();
            if (objInfo.LoaitaisanIdCha == null)
            {
                cboLOAITAISAN_ID_CHA.EditValue = null;
            }
            else
            {
                cboLOAITAISAN_ID_CHA.EditValue = objInfo.LoaitaisanIdCha;
            }

            chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objInfo.CoSuDung);
        }

        private void Save_Data()
        {
            if (objInfo == null)
            {
                objInfo = new DmLoaitaisan();
            }
            objInfo.KyHieu = this.txtKy_Hieu.Text;
            objInfo.TenLoaitaisan = txtTEN_LOAITAISAN.Text;
            objInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked);
            objInfo.LoaitaisanIdCha = VnsConvert.CGuid(cboLOAITAISAN_ID_CHA.EditValue);
            if (!string.IsNullOrEmpty(txtKHUNG_TGSD1.Text))
            {
                objInfo.KhungTgsd = decimal.Parse(txtKHUNG_TGSD1.Text);
            }

            //Try
            if (m_InputState == FormGlobals.DataInputState.AddMode || m_InputState == FormGlobals.DataInputState.CopyMode)
            {
                objInfo.MaLoaitaisan = " ";
                objInfo.Id = new Guid();
                DmLoaiTaisanService.SaveOrUpdate(objInfo);
                m_ID = objInfo.Id;
            }
            else
            {
                DmLoaiTaisanService.SaveOrUpdate(objInfo);
                m_ID = objInfo.Id;
            }
            frmProgress.Instance().SetFinishText("Data saved");
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try

        }

        private void BindLookUpEdit()
        {
            //Bind danh muc cha
            DmLoaitaisan dr = default(DmLoaitaisan);
            List<DmLoaitaisan> dt = new List<DmLoaitaisan>();
            dt.AddRange(DmLoaiTaisanService.GetAll());
            dr = new DmLoaitaisan();
            dr.TenLoaitaisan = "Danh mục gốc";
            dr.Id = Guid.Empty;
            dr.MaLoaitaisan = "";
            dr.Cap = 1;
            dt.Insert(0, dr);


            cboLOAITAISAN_ID_CHA.Properties.ValueMember = "Id";
            cboLOAITAISAN_ID_CHA.Properties.DisplayMember = "TenLoaitaisan";
            cboLOAITAISAN_ID_CHA.Properties.DataSource = dt;
        }

        private bool Check_KH(string KH)
        {
            List<DmLoaitaisan> dt = new List<DmLoaitaisan>();
            dt.AddRange(DmLoaiTaisanService.GetByKyHieu(KH));
            if (dt.Count != 0)
            {
                FormGlobals.Message_Warning("Ký hiệu loại tài sản đã tồn tại");
                txtKy_Hieu.Focus();
                return false;
            }
            return true;
        }

        private bool Check_input()
        {
            if (string.IsNullOrEmpty(txtKy_Hieu.Text) ||
                string.IsNullOrEmpty(txtTEN_LOAITAISAN.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập giá trị cho các trường bắt buộc");
                return false;
            }

            if (!string.IsNullOrEmpty(txtKHUNG_TGSD1.Text))
            {
                decimal Nam = decimal.Parse(txtKHUNG_TGSD1.Text);
                if (Nam < 0 | Nam > 9999)
                {
                    FormGlobals.Message_Warning("Số Năm sử dụng không hợp lệ!");
                    txtKHUNG_TGSD1.Focus();
                    return false;
                }
            }

            //if (VnsCheck.IsNullGuid(cboLOAITAISAN_ID_CHA.EditValue))
            //{
            //    FormGlobals.Message_Warning("Bạn chưa chọn danh mục cha!");
            //    cboLOAITAISAN_ID_CHA.Focus();
            //    return false;
            //}

            return true;
        }
        #endregion

        #region "Events"

        private void btnCancel_Click(System.Object sender, System.EventArgs e)
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

        private void btnClear_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                FormGlobals.Control_ClearData(_GroupControlObjectInfo);
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string kh = "";
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        kh = txtKy_Hieu.Text;
                        break;
                    case FormGlobals.DataInputState.EditMode:
                        if (!p_ma.Equals(txtKy_Hieu.Text))
                        {
                            kh = txtKy_Hieu.Text;
                        }
                        else
                        {
                            kh = "";
                        }
                        break;
                }

                if (!Check_KH(kh))
                {
                    return;
                }

                if (Check_input())
                {
                    frmProgress.Instance().Thread = Save_Data;
                    frmProgress.Instance().Show_Progress("Saving data");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmDanhMucTuDo1_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }



    }

}