using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmLenhSanXuat_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variables

        private ISxLenhsanxuatService _SxLenhsanxuatService;
        public ISxLenhsanxuatService SxLenhsanxuatService
        {
            get { return _SxLenhsanxuatService; }
            set { _SxLenhsanxuatService = value; }
        }

        private ISxKehoachMService _SxKehoachMService;
        public ISxKehoachMService SxKehoachMService
        {
            get { return _SxKehoachMService; }
            set { _SxKehoachMService = value; }
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

        private IDmKhangService _DmKhangService;
        public IDmKhangService DmKhangService
        {
            get { return _DmKhangService; }
            set { _DmKhangService = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private ISxDmQuytrinhService _SxDmQuytrinhService;
        public ISxDmQuytrinhService SxDmQuytrinhService
        {
            get { return _SxDmQuytrinhService; }
            set { _SxDmQuytrinhService = value; }
        }

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        private ISxPhancongService _SxPhancongService;
        public ISxPhancongService SxPhancongService
        {
            get { return _SxPhancongService; }
            set { _SxPhancongService = value; }
        }

        private FormGlobals.DataInputState _state;
        SxLenhsanxuat _objLenhSanXuat = new SxLenhsanxuat();
        private IList<SxLenhsanxuatD> lstSanXuat = new List<SxLenhsanxuatD>();
        private IList<SxLenhsanxuatD> lstVatTu = new List<SxLenhsanxuatD>();
        private IList<SxLenhsanxuatD> lstDel = new List<SxLenhsanxuatD>();
        #endregion

        #region Contructor

        public frmLenhSanXuat_ChiTiet()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Show form

        public SxLenhsanxuat Show_Form(SxLenhsanxuat objLenhSanXuat, FormGlobals.DataInputState state)
        {
            try
            {
                _state = state;
                _objLenhSanXuat = objLenhSanXuat;
                dteNgayTao.DateTime = DateTime.Now;
                BindDataToCbo();
                if (_state == FormGlobals.DataInputState.EditMode)
                    SetObject();

                if (ShowDialog() == DialogResult.OK)
                {
                    return _objLenhSanXuat;
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
            HtLoaichungtu objCt = (HtLoaichungtu)ComboHelper.GetSelectData(cboLoaiChungTu);
            if (objCt != null)
            {
                _objLenhSanXuat.IdLoaiCt = objCt.Id;
                _objLenhSanXuat.KyHieuLoaiCt = objCt.TenLoaiCt;//Lay tam ky hieu vao ten :v
                _objLenhSanXuat.MaLoaiCt = objCt.MaLoaiCt;
            }

            _objLenhSanXuat.NgayGiaoLenh = dteNgayTao.DateTime;
            _objLenhSanXuat.NgayBanHanh = dteNgayTao.DateTime;

            _objLenhSanXuat.MoTa = txtMoTa.Text;
            if (_state == FormGlobals.DataInputState.AddMode)
            {
                int strmMonth = 0;
                strmMonth = dteNgayTao.DateTime.Month;
                int strYear = 0;
                strYear = dteNgayTao.DateTime.Year;
                C_SoChungTu_RP.r_SoCTPREFIX(_objLenhSanXuat.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id);
                _objLenhSanXuat.SoLenhSanXuat = C_SoChungTu_RP.SoChungTu;
                //_objLenhSanXuat.PrefixCt = C_SoChungTu_RP.PREFIX;
            }

            HtDanhmuc objTrangThai = (HtDanhmuc)ComboHelper.GetSelectData(cboTrangThaiLenh);
            if (objTrangThai != null)
            {
                _objLenhSanXuat.TrangThai = objTrangThai.GiaTri;
            }
            _objLenhSanXuat.SoNhanCong = int.Parse(txtSoNhanCong.Text);

            SxKehoachM objKeHoachSx = (SxKehoachM)ComboHelper.GetSelectData(cboKeHoachSx);
            if (objKeHoachSx != null)
            {
                _objLenhSanXuat.KehoachMId = objKeHoachSx.Id;
                _objLenhSanXuat.SoKeHoach = objKeHoachSx.SoLenh;
            }

            SxPhancong objPhanCong = (SxPhancong)ComboHelper.GetSelectData(cboBuocPhanCong);
            if (objPhanCong != null)
            {
                _objLenhSanXuat.PhancongId = objPhanCong.Id;
                _objLenhSanXuat.BuocPhanCong = objPhanCong.ThuTu;
            }

            SxDmQuytrinh objQuyTrinhSx = (SxDmQuytrinh)ComboHelper.GetSelectData(cboQuyTrinhSx);
            if (objQuyTrinhSx != null)
            {
                _objLenhSanXuat.QuyTrinhId = objQuyTrinhSx.Id;
                _objLenhSanXuat.MaQuyTrinh = objQuyTrinhSx.MaQuytrinh;
            }

            DmPhongban objToSx = (DmPhongban)ComboHelper.GetSelectData(cboToSanXuat);
            if (objToSx != null)
            {
                _objLenhSanXuat.TosanxuatId = objToSx.Id;
                _objLenhSanXuat.MaToSanXuat = objToSx.KyHieu;
            }

            DmKhang objKhachHang = (DmKhang)ComboHelper.GetSelectData(cboKhachHang);
            if (objKhachHang != null)
            {
                _objLenhSanXuat.KhachHangId = objKhachHang.Id;
                _objLenhSanXuat.MaKhachHang = objKhachHang.KyHieu;
                _objLenhSanXuat.TenKhachHang = objKhachHang.TenKhang;
            }
            IList<SxLenhsanxuatD> lstDetail = new List<SxLenhsanxuatD>();
            foreach (SxLenhsanxuatD obj in lstVatTu)
            {
                lstDetail.Add(obj);
            }

            foreach (SxLenhsanxuatD obj in lstSanXuat)
            {
                lstDetail.Add(obj);
            }
            C_SoChungTu_RP.Text = _objLenhSanXuat.SoLenhSanXuat;

            _objLenhSanXuat.DonviId = Generals.DonviID;

            _objLenhSanXuat.NgayBatDau = txtNgayBatDau.DateTime;
            _objLenhSanXuat.NgayKetThuc = txtNgayKetThuc.DateTime;

            SxLenhsanxuatService.SaveLenhSanXuat(_objLenhSanXuat, lstDetail, lstDel);
        }

        private void SetObject()
        {            
            dteNgayTao.DateTime = _objLenhSanXuat.NgayGiaoLenh;
            cboLoaiChungTu.EditValue = _objLenhSanXuat.IdLoaiCt;
            C_SoChungTu_RP.Text = _objLenhSanXuat.PrefixCt + _objLenhSanXuat.SoLenhSanXuat;
            cboTrangThaiLenh.EditValue = _objLenhSanXuat.TrangThai;
            txtSoNhanCong.Text = _objLenhSanXuat.SoNhanCong.ToString();
            cboKeHoachSx.EditValue = _objLenhSanXuat.KehoachMId;
            cboQuyTrinhSx.EditValue = _objLenhSanXuat.QuyTrinhId;
            cboBuocPhanCong.EditValue = _objLenhSanXuat.PhancongId;
            cboToSanXuat.EditValue = _objLenhSanXuat.TosanxuatId;
            cboKhachHang.EditValue = _objLenhSanXuat.KhachHangId;
            txtMoTa.Text = _objLenhSanXuat.MoTa;

            txtNgayBatDau.DateTime = _objLenhSanXuat.NgayBatDau;
            txtNgayKetThuc.DateTime = _objLenhSanXuat.NgayKetThuc;

            IList<SxLenhsanxuatD> lstDetail = _objLenhSanXuat.LstLenhSanXuatDetail;
            if (lstDetail != null)
            {
                foreach (SxLenhsanxuatD obj in lstDetail)
                {
                    if (obj.LoaiLenh == (int)FormGlobals.DinhMucType.VatTu)
                    {
                        lstVatTu.Add(obj);
                    }
                    else
                    {
                        lstSanXuat.Add(obj);
                    }
                }
            }
            grcKhSanPham.DataSource = lstSanXuat;
            grcVatTu.DataSource = lstVatTu;
        }

        private void BindDataToCbo()
        {
            IList<DmHanghoa> lstHangHoa = DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id);
            grlSanPham.DataSource = lstHangHoa;
            grlVatTu.DataSource = lstHangHoa;

            IList<HtDanhmuc> lstThamSo = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            cboLoaiVatTu.DataSource = lstThamSo;

            IList<HtDanhmuc> lstTrangThaiLenh = HtDanhmucService.GetByDoiTuong("TT_KEHOACH");
            cboTrangThaiLenh.Properties.DataSource = lstTrangThaiLenh;
            cboTrangThaiLenh.Properties.ValueMember = "GiaTri";
            cboTrangThaiLenh.Properties.DisplayMember = "TenDanhmuc";

            IList<HtLoaichungtu> lstLoaiCt = HtLoaichungtuService.LikeObjetMA_LOAI_CT("SX_LENH_SX", Generals.DonviID);
            cboLoaiChungTu.Properties.DataSource = lstLoaiCt;
            cboLoaiChungTu.Properties.ValueMember = "Id";
            cboLoaiChungTu.Properties.DisplayMember = "TenLoaiCt";
            if (lstLoaiCt.Count > 0)
            {
                cboLoaiChungTu.EditValue = lstLoaiCt[0].Id;
            }

            IList<DmDvt> lstDvt = DmDvtService.GetAllByDonviID(Generals.DON_VI.Id);
            cboDvt.DataSource = lstDvt;
            cboDvt1.DataSource = lstDvt;

            IList<DmKhang> lstKhachHang = DmKhangService.GetAllByDonviID(Generals.DON_VI.Id);
            cboKhachHang.Properties.DataSource = lstKhachHang;
            cboKhachHang.Properties.ValueMember = "Id";
            cboKhachHang.Properties.DisplayMember = "TenKhang";

            IList<DmPhongban> lstPhongBan = DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id);
            cboToSanXuat.Properties.DataSource = lstPhongBan;
            cboToSanXuat.Properties.ValueMember = "Id";
            cboToSanXuat.Properties.DisplayMember = "TenPhongban";

            IList<SxDmQuytrinh> lstQuytrinh = SxDmQuytrinhService.GetByDonviId(Generals.DON_VI.Id);
            cboQuyTrinhSx.Properties.DataSource = lstQuytrinh;
            cboQuyTrinhSx.Properties.ValueMember = "Id";
            cboQuyTrinhSx.Properties.DisplayMember = "TenQuytrinh";

            IList<SxKehoachM> lstKeHoach = SxKehoachMService.GetByDonviId(Generals.DON_VI.Id);
            cboKeHoachSx.Properties.DataSource = lstKeHoach;
            cboKeHoachSx.Properties.ValueMember = "Id";
            cboKeHoachSx.Properties.DisplayMember = "SoLenh";
        }

        private bool CheckInput()
        {
            return true;
        }

        private void AddRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (lstVatTu == null) lstVatTu = new List<SxLenhsanxuatD>();
                SxLenhsanxuatD objvt = new SxLenhsanxuatD();
                objvt.LoaiLenh = (int)FormGlobals.DinhMucType.VatTu;
                lstVatTu.Add(objvt);
                grcVatTu.DataSource = lstVatTu;
                grcVatTu.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvVatTu, grvVatTu.RowCount - 1);
            }
            if (xrMainTab.SelectedTabPage == xrSanXuat)
            {
                if (lstSanXuat == null) lstSanXuat = new List<SxLenhsanxuatD>();
                SxLenhsanxuatD objSx = new SxLenhsanxuatD();
                objSx.LoaiLenh = (int)FormGlobals.DinhMucType.SanPham;
                lstSanXuat.Add(objSx);
                grcKhSanPham.DataSource = lstSanXuat;
                grcKhSanPham.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvKhSanPham, grvKhSanPham.RowCount - 1);
            }
        }

        private void DeleteRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (grvVatTu.FocusedRowHandle < 0) return;
                if (lstDel == null)
                    lstDel = new List<SxLenhsanxuatD>();

                SxLenhsanxuatD dm = (SxLenhsanxuatD)grvVatTu.GetRow(grvVatTu.FocusedRowHandle);
                lstDel.Add(dm);
                grvVatTu.DeleteSelectedRows();
                grvVatTu.RefreshData();
            }

            if (xrMainTab.SelectedTabPage == xrSanXuat)
            {
                if (grvKhSanPham.FocusedRowHandle < 0) return;
                if (lstDel == null)
                    lstDel = new List<SxLenhsanxuatD>();

                SxLenhsanxuatD dm = (SxLenhsanxuatD)grvKhSanPham.GetRow(grvKhSanPham.FocusedRowHandle);
                lstDel.Add(dm);
                grvKhSanPham.DeleteSelectedRows();
                grvKhSanPham.RefreshData();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grcKhSanPham_KeyDown(object sender, KeyEventArgs e)
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

        private void grvKhSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (GridHelper.CheckAddNewRow(grvKhSanPham))
            {
                AddRow();
            }
        }

        private void grcVatTu_KeyDown(object sender, KeyEventArgs e)
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

        private void grvVatTu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (GridHelper.CheckAddNewRow(grvVatTu))
            {
                AddRow();
            }
        }

        private void cboKeHoachSx_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SxKehoachM objKh = (SxKehoachM)ComboHelper.GetSelectData(cboKeHoachSx);
                if (objKh != null)
                {
                    IList<SxPhancong> lstPc = SxPhancongService.LoadByKeHoachId(objKh.Id);
                    cboBuocPhanCong.Properties.DataSource = lstPc;
                    cboBuocPhanCong.Properties.ValueMember = "Id";
                    cboBuocPhanCong.Properties.DisplayMember = "ThuTu";
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvKhSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvKhSanPham.FocusedRowHandle < 0) return;
            SxLenhsanxuatD tmp = (SxLenhsanxuatD)grvKhSanPham.GetRow(grvKhSanPham.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colSanPham":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.VatlieuDauraId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        private void grvVatTu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvVatTu.FocusedRowHandle < 0) return;
            SxLenhsanxuatD tmp = (SxLenhsanxuatD)grvVatTu.GetRow(grvVatTu.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colVatLieu":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.VatlieuDauvaoId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        #endregion        
    }
}