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
using Vns.Erp.Core.Controls.Commons;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmKiemKe_SanLuong_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private ISxPhieuKiemkeService _SxPhieuKiemkeService;
        public ISxPhieuKiemkeService SxPhieuKiemkeService
        {
            get { return _SxPhieuKiemkeService; }
            set { _SxPhieuKiemkeService = value; }
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

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private ISxPhieuKiemkeSlDService _SxPhieuKiemkeSlDService;
        public ISxPhieuKiemkeSlDService SxPhieuKiemkeSlDService
        {
            get { return _SxPhieuKiemkeSlDService; }
            set { _SxPhieuKiemkeSlDService = value; }
        }

        private ISxLenhsanxuatService _SxLenhsanxuatService;
        public ISxLenhsanxuatService SxLenhsanxuatService
        {
            get { return _SxLenhsanxuatService; }
            set { _SxLenhsanxuatService = value; }
        }
        private ISxPhieuKiemkeVtDService _SxPhieuKiemkeVtDService;
        public ISxPhieuKiemkeVtDService SxPhieuKiemkeVtDService
        {
            get { return _SxPhieuKiemkeVtDService; }
            set { _SxPhieuKiemkeVtDService = value; }
        }

        private SxPhieuKiemke _objKiemKe = null;
        private IList<SxPhieuKiemkeSlD> lstKiemKeSl = new List<SxPhieuKiemkeSlD>();
        private IList<SxPhieuKiemkeSlD> lstDelKiemKeSl = new List<SxPhieuKiemkeSlD>(); 
        private IList<SxPhieuKiemkeVtD> lstKiemKeVt = new List<SxPhieuKiemkeVtD>();
        private IList<SxPhieuKiemkeVtD> lstDelKiemKeVt = new List<SxPhieuKiemkeVtD>();
       
        private FormGlobals.DataInputState _state;
        private HtLoaichungtu _objLoaiCt = new HtLoaichungtu();
        #endregion

        #region Contructor

        public frmKiemKe_SanLuong_ChiTiet()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Show form

        public SxPhieuKiemke Show_Form(FormGlobals.DataInputState pFormStatus, SxPhieuKiemke objectKiemKe, HtLoaichungtu objCt)
        {
            try
            {
                _objLoaiCt = objCt;
                _objKiemKe = objectKiemKe;
                _state = pFormStatus;
                dteNgayKiemKe.DateTime = DateTime.Now;
                BindDataToCbo();
                if (_state == FormGlobals.DataInputState.EditMode)
                    SetObject();

                if (ShowDialog() == DialogResult.OK)
                {
                    return _objKiemKe;
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
            if (_objKiemKe == null) _objKiemKe = new SxPhieuKiemke();

            HtLoaichungtu objCt = (HtLoaichungtu)ComboHelper.GetSelectData(cboLoaiChungTu);
            if (objCt != null)
            {
                _objKiemKe.LoaiPhieuId = objCt.Id;
                _objKiemKe.MaLoaiPhieu = objCt.MaLoaiCt;//Lay tam ky hieu vao ten :v
            }

            _objKiemKe.LstSxPhieuKiemkeSlD = null;
            _objKiemKe.LstSxPhieuKiemkeVtD = null;

            _objKiemKe.NgayKiemKe = dteNgayKiemKe.DateTime;
            _objKiemKe.NguoiKiemKe = txtNguoiKiemKe.Text;
            _objKiemKe.NguoiLienQuan = txtNguoiLienQuan.Text;
            _objKiemKe.CaKiemKe = Int16.Parse(txtCaKiemKe.Text);
            _objKiemKe.MoTa = txtMoTa.Text;
            _objKiemKe.DonviId = Generals.DonviID;
            if (_state == FormGlobals.DataInputState.AddMode)
            {
                int strmMonth = 0;
                strmMonth = dteNgayKiemKe.DateTime.Month;
                int strYear = 0;
                strYear = dteNgayKiemKe.DateTime.Year;
                C_SoChungTu_RP.r_SoCTPREFIX(_objKiemKe.LoaiPhieuId, strmMonth, strYear, Generals.DON_VI.Id);
                _objKiemKe.SoKiemKe = C_SoChungTu_RP.SoChungTu;
                //_objKiemKe.SoKiemKe = C_SoChungTu_RP.SO_CHUNG_TU;
            }

            DmPhongban objToSanXuat = (DmPhongban)ComboHelper.GetSelectData(cboToSanXuat);
            if (objToSanXuat != null)
            {
                _objKiemKe.TosanxuatId = objToSanXuat.Id;
            }

            //HtDanhmuc objTrangThai = (HtDanhmuc)ComboHelper.GetSelectData(cbotrangThai);
            //if (objTrangThai != null)
            //{
            //    _objKiemKe.TrangThai = objTrangThai.GiaTri;
            //}
            C_SoChungTu_RP.Text = _objKiemKe.SoKiemKe;
            SxPhieuKiemkeService.saveKiemKe(_objKiemKe, lstKiemKeSl, lstKiemKeVt, lstDelKiemKeSl,lstDelKiemKeVt);
        }

        private void SetObject()
        {
            cboLoaiChungTu.EditValue = _objKiemKe.LoaiPhieuId;
            dteNgayKiemKe.DateTime = _objKiemKe.NgayKiemKe;
            cboToSanXuat.EditValue = _objKiemKe.TosanxuatId;
            //cbotrangThai.EditValue = _objKiemKe.TrangThai;
            txtNguoiKiemKe.Text = _objKiemKe.NguoiKiemKe;
            txtNguoiLienQuan.Text = _objKiemKe.NguoiLienQuan;
            txtCaKiemKe.Text = _objKiemKe.CaKiemKe.ToString();
            C_SoChungTu_RP.Text = _objKiemKe.SoKiemKe;
            txtMoTa.Text = _objKiemKe.MoTa;

            lstKiemKeSl = _objKiemKe.LstSxPhieuKiemkeSlD;
            lstKiemKeVt = _objKiemKe.LstSxPhieuKiemkeVtD;
            grcKiemKeSl.DataSource = lstKiemKeSl;
            grcKiemKeVt.DataSource = lstKiemKeVt;
        }

        private void BindDataToCbo()
        {
            IList<DmHanghoa> lstHangHoa = DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id);
            grlSanPham.DataSource = lstHangHoa;
            grlVatTu.DataSource = lstHangHoa;

            //IList<HtDanhmuc> lstTrangThaiLenh = HtDanhmucService.GetByDoiTuong("TT_KEHOACH");
            //cbotrangThai.Properties.DataSource = lstTrangThaiLenh;
            //cbotrangThai.Properties.ValueMember = "GiaTri";
            //cbotrangThai.Properties.DisplayMember = "TenDanhmuc";

            IList<DmPhongban> lstPhongBan = DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id);
            cboToSanXuat.Properties.DataSource = lstPhongBan;
            cboToSanXuat.Properties.ValueMember = "Id";
            cboToSanXuat.Properties.DisplayMember = "TenPhongban";

            IList<HtDanhmuc> lstThamSo = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            cboLoaiVatTu.DataSource = lstThamSo;

            IList<DmDvt> lstDvt = DmDvtService.GetAllByDonviID(Generals.DON_VI.Id);
            cboDvt.DataSource = lstDvt;
            cboDvt1.DataSource = lstDvt;

            IList<SxLenhsanxuat> lstLenhSx = SxLenhsanxuatService.GetbyDonviId(Generals.DON_VI.Id);
            cboLenhSanXuat.DataSource = lstLenhSx;
            cboLenhSanXuatVt.DataSource = lstLenhSx;

            IList<HtLoaichungtu> lstLoaiCt = HtLoaichungtuService.LikeObjetMA_LOAI_CT("KK_SANXUAT", Generals.DonviID);
            cboLoaiChungTu.Properties.DataSource = lstLoaiCt;
            cboLoaiChungTu.Properties.ValueMember = "Id";
            cboLoaiChungTu.Properties.DisplayMember = "TenLoaiCt";

            IList<HtDanhmuc> lstNghiepVuSL = HtDanhmucService.GetByDoiTuong("XULY_SANLUONG");
            cboNghiepVuSl.DataSource = lstNghiepVuSL;

            IList<HtDanhmuc> lstNghiepVuVt = HtDanhmucService.GetByDoiTuong("XULY_NVL");
            cboNghiepVuVt.DataSource = lstNghiepVuVt;


            if (_objLoaiCt != null)
            {
                cboLoaiChungTu.Properties.ReadOnly = true;
                cboLoaiChungTu.EditValue = _objLoaiCt.Id;
            }  
        }

        private bool CheckInput()
        {
            if (cboLoaiChungTu.EditValue == null)
            {
                FormGlobals.Message_Warning("Chưa chọn loại chứng từ");
                cboLoaiChungTu.Focus();
                return false;
            }

            if (dteNgayKiemKe.DateTime == null)
            {
                FormGlobals.Message_Warning("Chưa nhập ngày kiểm kê");
                dteNgayKiemKe.Focus();
                return false;
            }

            if (cboToSanXuat.EditValue == null)
            {
                FormGlobals.Message_Warning("Chưa chọn tổ sản xuất");
                cboToSanXuat.Focus();
                return false;
            }

            //if (cbotrangThai.EditValue == null)
            //{
            //    FormGlobals.Message_Warning("Chưa chọn trạng thái");
            //    cbotrangThai.Focus();
            //    return false;
            //}

            if (grvKiemKeVt.RowCount == 0 && grvKiemKeSl.RowCount == 0)
            {
                FormGlobals.Message_Warning("Bạn phải nhập sản lượng hoặc vật tư");
                xrMainTab.SelectedTabPage = xrVatTu;
                return false;
            }

            //if (grvKiemKeSl.RowCount == 0)
            //{
            //    FormGlobals.Message_Warning("Bạn chưa nhập kiểm kê sản lượng");
            //    xrMainTab.SelectedTabPage = xrSanLuong;
            //    return false;
            //}

            //foreach (SxKehoachD obj in lstKiemKeVt)
            //{
            //    if (obj.LoaiChiPhi == 0)
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn loại vật tư");
            //        xrMainTab.SelectedTabPage = xrVatTu;
            //        return false;
            //    }

            //    if (obj.VatlieuDauvaoId == new Guid())
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn vật tư");
            //        xrMainTab.SelectedTabPage = xrVatTu;
            //        return false;
            //    }

            //    if (obj.SoLuong == 0)
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa nhập số lượng");
            //        xrMainTab.SelectedTabPage = xrVatTu;
            //        return false;
            //    }

            //    if (obj.DvtId == new Guid())
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn đơn vị tính");
            //        xrMainTab.SelectedTabPage = xrVatTu;
            //        return false;
            //    }
            //}


            //foreach (SxKehoachD obj in lstKiemKeSl)
            //{
            //    if (obj.VatlieuDauraId == new Guid())
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa chọn sản phẩm");
            //        xrMainTab.SelectedTabPage = xrSanXuat;
            //        return false;
            //    }

            //    if (obj.SoLuong == 0)
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa nhập số lượng");
            //        xrMainTab.SelectedTabPage = xrSanXuat;
            //        return false;
            //    }

            //    if (obj.DvtId == new Guid())
            //    {
            //        FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa chọn đơn vị tính");
            //        xrMainTab.SelectedTabPage = xrSanXuat;
            //        return false;
            //    }
            //}

            return true;
        }

        private void AddRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (lstKiemKeVt == null) lstKiemKeVt = new List<SxPhieuKiemkeVtD>();
                lstKiemKeVt.Add(new SxPhieuKiemkeVtD());
                grcKiemKeVt.DataSource = lstKiemKeVt;
                grcKiemKeVt.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvKiemKeVt, grvKiemKeVt.RowCount - 1);
            }
            if (xrMainTab.SelectedTabPage == xrSanLuong)
            {
                if (lstKiemKeSl == null) lstKiemKeSl = new List<SxPhieuKiemkeSlD>();
                var objadd = new SxPhieuKiemkeSlD();
                lstKiemKeSl.Add(objadd);
                grcKiemKeSl.DataSource = lstKiemKeSl;
                grcKiemKeSl.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvKiemKeSl, grvKiemKeSl.RowCount - 1);
            }

        }

        private void DeleteRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (grvKiemKeVt.FocusedRowHandle < 0) return;
                if (lstDelKiemKeVt == null)
                    lstDelKiemKeVt = new List<SxPhieuKiemkeVtD>();

                SxPhieuKiemkeVtD dm = (SxPhieuKiemkeVtD)grvKiemKeVt.GetRow(grvKiemKeVt.FocusedRowHandle);
                lstDelKiemKeVt.Add(dm);
                grvKiemKeVt.DeleteSelectedRows();
                grvKiemKeVt.RefreshData();
            }

            if (xrMainTab.SelectedTabPage == xrSanLuong)
            {
                if (grvKiemKeSl.FocusedRowHandle < 0) return;
                if (lstDelKiemKeSl == null)
                    lstDelKiemKeSl = new List<SxPhieuKiemkeSlD>();

                SxPhieuKiemkeSlD dm = (SxPhieuKiemkeSlD)grvKiemKeSl.GetRow(grvKiemKeSl.FocusedRowHandle);
                lstDelKiemKeSl.Add(dm);
                grvKiemKeSl.DeleteSelectedRows();
                grvKiemKeSl.RefreshData();
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

            if (GridHelper.CheckAddNewRow(grvKiemKeSl))
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

            if (GridHelper.CheckAddNewRow(grvKiemKeVt))
            {
                AddRow();
            }
        }

        private void grcKeHoach_KeyDown(object sender, KeyEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grvKhSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvKiemKeSl.FocusedRowHandle < 0) return;
            SxPhieuKiemkeSlD tmp = (SxPhieuKiemkeSlD)grvKiemKeSl.GetRow(grvKiemKeSl.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colSanPham":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.SanPhamId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        private void grvVatTu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvKiemKeVt.FocusedRowHandle < 0) return;
            SxPhieuKiemkeVtD tmp = (SxPhieuKiemkeVtD)grvKiemKeVt.GetRow(grvKiemKeVt.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colVatLieu":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.VatTuId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        private void cboToSanXuat_EditValueChanged(object sender, EventArgs e)
        {
            DmPhongban cbo = (DmPhongban)ComboHelper.GetSelectData(cboToSanXuat);
            if (cbo != null)
            {
                IList<SxLenhsanxuat> lstLenhSx = SxLenhsanxuatService.LoadByToSanXuat(cbo.Id);
                cboLenhSanXuat.DataSource = lstLenhSx;
                cboLenhSanXuatVt.DataSource = lstLenhSx;
            }            
        }

        #endregion               

        
    }
}