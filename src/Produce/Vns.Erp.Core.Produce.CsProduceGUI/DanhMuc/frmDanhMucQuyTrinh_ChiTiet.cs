using System.Windows.Forms;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class FrmDanhMucQuyTrinh_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private ISxDmQuytrinhService _SxDmQuytrinhService;

        public ISxDmQuytrinhService SxDmQuytrinhService
        {
            get { return _SxDmQuytrinhService; }
            set { _SxDmQuytrinhService = value; }
        }

        private SxDmQuytrinh _objQuyTrinh = null;
        private FormGlobals.DataInputState _state;

        #endregion

        #region Contructor

        public FrmDanhMucQuyTrinh_ChiTiet()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Show form

        public SxDmQuytrinh Show_Form(FormGlobals.DataInputState pFormStatus, SxDmQuytrinh objectQuyTrinh)
        {
            try
            {
                _objQuyTrinh = objectQuyTrinh;
                _state = pFormStatus;

                if (_state == FormGlobals.DataInputState.EditMode)
                    SetObject();

                if (ShowDialog() == DialogResult.OK)
                {
                    return _objQuyTrinh;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
            return null;
        }

        #endregion

        #region Function

        private void GetObject()
        {
            if (_objQuyTrinh == null)
                _objQuyTrinh = new SxDmQuytrinh();

            _objQuyTrinh.TenQuytrinh = txtTenQt.Text;
            _objQuyTrinh.MaQuytrinh = txtMaQt.Text;
            _objQuyTrinh.MoTa = txtMoTa.Text;
            _objQuyTrinh.DonviId = Generals.DonviID;

            if (ckeCoSuDung.Checked)
                _objQuyTrinh.CoSuDung = 1;
            else
                _objQuyTrinh.CoSuDung = 0;
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

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    frmProgress.Instance().Thread = GetObject;
                    frmProgress.Instance().Show_Progress("Đang lưu dữ liệu");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}