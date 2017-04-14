using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Produce.Common;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmDanhMucQuyTrinh_DinhMuc : DevExpress.XtraEditors.XtraForm
    {
        #region Variales

        private ISxDmQuytrinhService _SxDmQuytrinhService;
        public ISxDmQuytrinhService SxDmQuytrinhService
        {
            get { return _SxDmQuytrinhService; }
            set { _SxDmQuytrinhService = value; }
        }

        private IDmHanghoaService _DmHanghoaService;
        public IDmHanghoaService DmHanghoaService
        {
            get { return _DmHanghoaService; }
            set { _DmHanghoaService = value; }
        }

        private IHtDanhmucService _HtDanhmucService;
        public IHtDanhmucService HtDanhmucService
        {
            get { return _HtDanhmucService; }
            set { _HtDanhmucService = value; }
        }

        private IDmDvtService _DmDvtService;
        public IDmDvtService DmDvtService
        {
            get { return _DmDvtService; }
            set { _DmDvtService = value; }
        }

        private SxDmQuytrinh _objQuyTrinh = null;
        private FormGlobals.DataInputState _state;
        private IList<SxQuytrinhDinhmuc> lstSanPham = new List<SxQuytrinhDinhmuc>();
        private IList<SxQuytrinhDinhmuc> lstVatTu = new List<SxQuytrinhDinhmuc>();
        private IList<SxQuytrinhDinhmuc> lstDelSanPham = new List<SxQuytrinhDinhmuc>();
        private IList<SxQuytrinhDinhmuc> lstDelVatTu = new List<SxQuytrinhDinhmuc>();
        #endregion

        #region Contructor

        public frmDanhMucQuyTrinh_DinhMuc()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Show_form

        public SxDmQuytrinh Show_Form(FormGlobals.DataInputState pFormStatus, SxDmQuytrinh objectQuyTrinh)
        {
            try
            {
                _objQuyTrinh = objectQuyTrinh;
                _state = pFormStatus;
                BindDataToCbo();
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

        #region Functions

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

            _SxDmQuytrinhService.SaveQuyTrinhDinhMuc(_objQuyTrinh, lstVatTu, lstSanPham, lstDelVatTu, lstDelSanPham);
        }

        private void SetObject()
        {
            txtMaQt.Text = _objQuyTrinh.MaQuytrinh;
            txtTenQt.Text = _objQuyTrinh.TenQuytrinh;
            txtMoTa.Text = _objQuyTrinh.MoTa;
            ckeCoSuDung.Checked = TNCommon.ParseBool(_objQuyTrinh.CoSuDung);

            IList<SxQuytrinhDinhmuc> lstTemp = _objQuyTrinh.LstDinhMuc;
            if (lstTemp != null)
            {
                foreach (SxQuytrinhDinhmuc objDinhMuc in lstTemp)
                {
                    if (objDinhMuc.LoaiQuyTrinh == (int)FormGlobals.DinhMucType.SanPham)
                    {
                        lstSanPham.Add(objDinhMuc);
                    }
                    else
                    {
                        lstVatTu.Add(objDinhMuc);
                    }
                }
            }
            grcSanPham.DataSource = lstSanPham;
            grcVatLieu.DataSource = lstVatTu;
        }

        private void BindDataToCbo()
        {
            IList<DmHanghoa> lstHangHoa = DmHanghoaService.GetAll();
            grlVatTu.DataSource = lstHangHoa;
            grlSanPham.DataSource = lstHangHoa;

            IList<HtDanhmuc> lstThamSo = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            cboLoaiVatLieu.DataSource = lstThamSo;

            IList<DmDvt> lstDvt = DmDvtService.GetAll();
            cboDvt.DataSource = lstDvt;
            cboDvt1.DataSource = lstDvt;
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

            if (grvSanPham.RowCount == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa nhập định mức sản phẩm");
                xrMainTab.SelectedTabPage = xrSanPham;
                return false;
            }

            if (grvVatLieu.RowCount == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa nhập định mức vật tư");
                xrMainTab.SelectedTabPage = xrVatTu;
                return false;
            }

            foreach (SxQuytrinhDinhmuc obj in lstVatTu)
            {
                if (obj.LoaiChiPhi == 0)
                {
                    FormGlobals.Message_Warning("Định mức vật tư :Bạn chưa chọn loại vật tư");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.VatlieuDauvaoId == new Guid())
                {
                    FormGlobals.Message_Warning("Định mức vật tư :Bạn chưa chọn vật tư");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.SoLuong == 0)
                {
                    FormGlobals.Message_Warning("Định mức vật tư :Bạn chưa nhập số lượng");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.DvtId == new Guid())
                {
                    FormGlobals.Message_Warning("Định mức vật tư :Bạn chưa chọn đơn vị tính");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }
            }


            foreach (SxQuytrinhDinhmuc obj in lstSanPham)
            {
                if (obj.VatlieuDauraId == new Guid())
                {
                    FormGlobals.Message_Warning("Định mức sản phẩm :Bạn chưa chọn sản phẩm");
                    xrMainTab.SelectedTabPage = xrSanPham;
                    return false;
                }

                if (obj.SoLuong == 0)
                {
                    FormGlobals.Message_Warning("Định mức sản phẩm :Bạn chưa nhập số lượng");
                    xrMainTab.SelectedTabPage = xrSanPham;
                    return false;
                }

                if (obj.DvtId == new Guid())
                {
                    FormGlobals.Message_Warning("Định mức sản phẩm :Bạn chưa chọn đơn vị tính");
                    xrMainTab.SelectedTabPage = xrSanPham;
                    return false;
                }
            }

            return true;
        }

        private void AddRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (lstVatTu == null) lstVatTu = new List<SxQuytrinhDinhmuc>();
                lstVatTu.Add(new SxQuytrinhDinhmuc());
                grcVatLieu.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvVatLieu, grvVatLieu.RowCount - 1);
            }
            if (xrMainTab.SelectedTabPage == xrSanPham)
            {
                if (lstSanPham == null) lstSanPham = new List<SxQuytrinhDinhmuc>();
                lstSanPham.Add(new SxQuytrinhDinhmuc());
                grcSanPham.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvSanPham, grvSanPham.RowCount - 1);
            }
        }

        private void DeleteRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (grvVatLieu.FocusedRowHandle < 0) return;
                if (lstDelVatTu == null)
                    lstDelVatTu = new List<SxQuytrinhDinhmuc>();

                SxQuytrinhDinhmuc dm = (SxQuytrinhDinhmuc)grvVatLieu.GetRow(grvVatLieu.FocusedRowHandle);
                lstDelVatTu.Add(dm);
                grvVatLieu.DeleteSelectedRows();
                grvVatLieu.RefreshData();
            }

            if (xrMainTab.SelectedTabPage == xrSanPham)
            {
                if (grvSanPham.FocusedRowHandle < 0) return;
                if (lstDelSanPham == null)
                    lstDelSanPham = new List<SxQuytrinhDinhmuc>();

                SxQuytrinhDinhmuc dm = (SxQuytrinhDinhmuc)grvSanPham.GetRow(grvSanPham.FocusedRowHandle);
                lstDelSanPham.Add(dm);
                grvSanPham.DeleteSelectedRows();
                grvSanPham.RefreshData();
            }
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

        private void grcVatLieu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    AddRow();
                    break;
                case Keys.F8:
                    DeleteRow();
                    break;
            }
        }

        private void grcSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    AddRow();
                    break;
                case Keys.F8:
                    DeleteRow();
                    break;
            }
        }

        private void grvSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (GridHelper.CheckAddNewRow(grvSanPham))
            {
                AddRow();
            }
        }

        private void grvVatLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (GridHelper.CheckAddNewRow(grvVatLieu))
            {
                AddRow();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grvVatLieu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvVatLieu.FocusedRowHandle < 0) return;
            SxQuytrinhDinhmuc tmp = (SxQuytrinhDinhmuc)grvVatLieu.GetRow(grvVatLieu.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colVatLieu":
                    DmHanghoa tmpHh = (DmHanghoa)grlVatTu.GetRowByKeyValue(tmp.VatlieuDauvaoId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        private void grvSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvSanPham.FocusedRowHandle < 0) return;
            SxQuytrinhDinhmuc tmp = (SxQuytrinhDinhmuc)grvSanPham.GetRow(grvSanPham.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colSanPham":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.VatlieuDauraId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }
        #endregion
    }
}