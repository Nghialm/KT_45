using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class uc_DanhMucQuyTrinh_ChiTiet : DevExpress.XtraEditors.XtraUserControl
    {
        private SxDmQuytrinh _objQuyTrinh;

        public SxDmQuytrinh objQuyTrinh
        {
            get { return _objQuyTrinh; }
            set { _objQuyTrinh = value; }
        }

        public uc_DanhMucQuyTrinh_ChiTiet()
        {
            InitializeComponent();
        }

        private void uc_DanhMucQuyTrinh_ChiTiet_Load(object sender, EventArgs e)
        {
            SetObject();
        }

        private void GetObject()
        {
            if (_objQuyTrinh == null)
                _objQuyTrinh = new SxDmQuytrinh();

            _objQuyTrinh.TenQuytrinh = txtTenQt.Text;
            _objQuyTrinh.MaQuytrinh = txtMaQt.Text;
            _objQuyTrinh.MoTa = txtMoTa.Text;
            if (ckeCoSuDung.Checked)
                _objQuyTrinh.CoSuDung = 1;
            else
                _objQuyTrinh.CoSuDung = 0;
            ISxDmQuytrinhService _SxDmQuytrinhService = (ISxDmQuytrinhService)ObjectFactory.GetObject("SxDmQuytrinhService");
            _SxDmQuytrinhService.SaveOrUpdate(_objQuyTrinh);
        }

        private void SetObject()
        {
            txtMaQt.Text = _objQuyTrinh.MaQuytrinh;
            txtTenQt.Text = _objQuyTrinh.TenQuytrinh;
            txtMoTa.Text = _objQuyTrinh.MoTa;
            ckeCoSuDung.Checked = TNCommon.ParseBool(_objQuyTrinh.CoSuDung);
        }

        private bool CheckInput()
        {
            if (String.IsNullOrEmpty(txtMaQt.Text.Trim()))
            {
                FormGlobals.Message_Warning("Chưa nhập mã quy trình");
                txtMaQt.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtTenQt.Text.Trim()))
            {
                FormGlobals.Message_Warning("Chưa nhập tên quy trình");
                txtTenQt.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                frmProgress.Instance().Thread = GetObject;
                frmProgress.Instance().Show_Progress("Đang lưu dữ liệu");               
            }   
        }
    }
}
