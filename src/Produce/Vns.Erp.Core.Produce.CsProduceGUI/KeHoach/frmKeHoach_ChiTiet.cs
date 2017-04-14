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
    public partial class frmKeHoach_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
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

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
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

        private ISxLenhsanxuatService _SxLenhsanxuatService;
        public ISxLenhsanxuatService SxLenhsanxuatService
        {
            get { return _SxLenhsanxuatService; }
            set { _SxLenhsanxuatService = value; }
        }
        private ISxPhancongService _SxPhancongService;
        public ISxPhancongService SxPhancongService
        {
            get { return _SxPhancongService; }
            set { _SxPhancongService = value; }
        }

        private SxKehoachM _objKeHoach = null;
        private IList<SxKehoachD> lstSanXuat = new List<SxKehoachD>();
        private IList<SxKehoachD> lstVatTu = new List<SxKehoachD>();
        private IList<SxPhancong> lstKeHoach = new List<SxPhancong>();
        private IList<SxKehoachD> lstDelSanXuat = new List<SxKehoachD>();
        private IList<SxKehoachD> lstDelVatTu = new List<SxKehoachD>();
        private IList<SxPhancong> lstDelKeHoach = new List<SxPhancong>();

        private FormGlobals.DataInputState _state;
        private HtLoaichungtu _objLoaiCt = new HtLoaichungtu();
        #endregion

        #region Contructor

        public frmKeHoach_ChiTiet()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Show form

        public SxKehoachM Show_Form(FormGlobals.DataInputState pFormStatus, SxKehoachM objectKeHoach, HtLoaichungtu objCt)
        {
            try
            {
                _objLoaiCt = objCt;
                _objKeHoach = objectKeHoach;
                _state = pFormStatus;

                this.Text = objCt.TenLoaiCt;
                txtNgayKh.DateTime = DateTime.Now;
                BindDataToCbo();
                if (_state == FormGlobals.DataInputState.EditMode)
                    SetObject();

                if (ShowDialog() == DialogResult.OK)
                {
                    return _objKeHoach;
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
            if (_objKeHoach == null) _objKeHoach = new SxKehoachM();

            HtLoaichungtu objCt = (HtLoaichungtu)ComboHelper.GetSelectData(cboLoaiChungTu);
            if (objCt != null)
            {
                _objKeHoach.IdLoaiCt = objCt.Id;
                _objKeHoach.KyHieuLoaiCt = objCt.TenLoaiCt;//Lay tam ky hieu vao ten :v
                _objKeHoach.MaLoaiCt = objCt.MaLoaiCt;
            }

            _objKeHoach.LstKhThucHien = null;
            _objKeHoach.LstKeHoachDetail = null;

            _objKeHoach.NgayKeHoach = txtNgayKh.DateTime;
            if (_state == FormGlobals.DataInputState.AddMode)
            {
                int strmMonth = 0;
                strmMonth = txtNgayKh.DateTime.Month;
                int strYear = 0;
                strYear = txtNgayKh.DateTime.Year;
                C_SoChungTu_RP.r_SoCTPREFIX(_objKeHoach.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id);
                _objKeHoach.SoLenh = C_SoChungTu_RP.SoChungTu;
                //_objKeHoach.PrefixCt = C_SoChungTu_RP.PREFIX;
            }

            _objKeHoach.NguoiLap = Globals.LoginUserName;

            DmHanghoa objHangHoa = (DmHanghoa)ComboHelper.GetSelectData(cboSanPhamM);
            if (objHangHoa != null)
            {
                _objKeHoach.SanphamId = objHangHoa.Id;
                _objKeHoach.MaSanpham = objHangHoa.KyHieu;
                _objKeHoach.TenSanpham = objHangHoa.TenHanghoa;
            }

            DmKhang objKhachHang = (DmKhang)ComboHelper.GetSelectData(cboKhachHang);
            if (objKhachHang != null)
            {
                _objKeHoach.KhachhangId = objKhachHang.Id;
                _objKeHoach.TenKhachhang = objKhachHang.TenKhang;
                _objKeHoach.MaKhachhang = objKhachHang.MaKhang;
            }
            C_SoChungTu_RP.Text = _objKeHoach.SoLenh;
            _objKeHoach.MoTa = txtMoTa.Text;
            _objKeHoach.DonviId = Generals.DON_VI.Id;

            _objKeHoach.NgayBatDau = txtNgayBatDau.DateTime;
            _objKeHoach.NgayKetThuc = txtNgayKetThuc.DateTime;

            SxKehoachMService.SaveKeHoach(_objKeHoach, lstSanXuat, lstVatTu, lstKeHoach, lstDelSanXuat, lstDelVatTu, lstDelKeHoach);
        }

        private void SetObject()
        {
            cboLoaiChungTu.EditValue = _objKeHoach.IdLoaiCt;
            txtNgayKh.DateTime = _objKeHoach.NgayKeHoach;
            txtNgayBatDau.DateTime = _objKeHoach.NgayBatDau;
            txtNgayKetThuc.DateTime = _objKeHoach.NgayKetThuc;
            cboKhachHang.EditValue = _objKeHoach.KhachhangId;
            cboSanPhamM.EditValue = _objKeHoach.SanphamId;
            C_SoChungTu_RP.Text = _objKeHoach.SoLenh;
            txtMoTa.Text = _objKeHoach.MoTa;

            IList<SxKehoachD> lstTemp = _objKeHoach.LstKeHoachDetail;
            if (lstTemp != null)
            {
                foreach (SxKehoachD obj in lstTemp)
                {
                    if (obj.LoaiKeHoach == (int)FormGlobals.DinhMucType.VatTu)
                    {
                        lstVatTu.Add(obj);
                    }
                    else if (obj.LoaiKeHoach == (int)FormGlobals.DinhMucType.SanPham)
                    {
                        lstSanXuat.Add(obj);
                    }
                }
            }

            grcKhSanPham.DataSource = lstSanXuat;
            grcVatTu.DataSource = lstVatTu;

            lstKeHoach = _objKeHoach.LstKhThucHien;
            foreach (SxPhancong obj in lstKeHoach)
            {
                SxLenhsanxuat objLenhSx = SxLenhsanxuatService.GetById(obj.LenhsanxuatId);
                if (objLenhSx == null) objLenhSx = new SxLenhsanxuat();
                obj.LenhSanXuat = objLenhSx;
            }
            grcKeHoach.DataSource = lstKeHoach;
        }

        private void BindDataToCbo()
        {
            IList<DmHanghoa> lstHangHoa = DmHanghoaService.GetAll();
            grlCtSanPham.DataSource = lstHangHoa;
            grlSanPham.DataSource = lstHangHoa;
            grlVatTu.DataSource = lstHangHoa;

            cboSanPhamM.Properties.DataSource = lstHangHoa;
            cboSanPhamM.Properties.ValueMember = "Id";
            cboSanPhamM.Properties.DisplayMember = "TenHanghoa";

            IList<HtDanhmuc> lstThamSo = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            cboLoaiVatTu.DataSource = lstThamSo;

            IList<DmDvt> lstDvt = DmDvtService.GetAll();
            cboDvt.DataSource = lstDvt;
            cboDvt1.DataSource = lstDvt;
            cboCtDvt.DataSource = lstDvt;

            IList<HtLoaichungtu> lstLoaiCt = HtLoaichungtuService.LikeObjetMA_LOAI_CT("KEHOACH", Generals.DonviID);
            cboLoaiChungTu.Properties.DataSource = lstLoaiCt;
            cboLoaiChungTu.Properties.ValueMember = "Id";
            cboLoaiChungTu.Properties.DisplayMember = "TenLoaiCt";
            if (_objLoaiCt != null)
            {
                cboLoaiChungTu.Properties.ReadOnly = true;
                cboLoaiChungTu.EditValue = _objLoaiCt.Id;
            }

            IList<DmKhang> lstKhachHang = DmKhangService.GetAll();
            cboKhachHang.Properties.DataSource = lstKhachHang;
            cboKhachHang.Properties.ValueMember = "Id";
            cboKhachHang.Properties.DisplayMember = "TenKhang";

            IList<DmPhongban> lstPhongBan = DmPhongbanService.GetAll();
            grlToPhanCong.DataSource = lstPhongBan;

            IList<SxDmQuytrinh> lstQuytrinh = SxDmQuytrinhService.GetAll();
            grlQuyTrinh.DataSource = lstQuytrinh;
        }

        private bool CheckInput()
        {
            if (cboLoaiChungTu.EditValue == null)
            {
                FormGlobals.Message_Warning("Chưa chọn loại chứng từ");
                cboLoaiChungTu.Focus();
                return false;
            }

            if (txtNgayKh.DateTime == null)
            {
                FormGlobals.Message_Warning("Chưa nhập ngày kế hoạch");
                txtNgayKh.Focus();
                return false;
            }

            if (cboSanPhamM.EditValue == null)
            {
                FormGlobals.Message_Warning("Chưa chọn sản phẩm");
                cboSanPhamM.Focus();
                return false;
            }

            if (cboKhachHang.EditValue == null)
            {
                FormGlobals.Message_Warning("Chưa chọn khách hàng");
                cboKhachHang.Focus();
                return false;
            }

            if (grvVatTu.RowCount == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa kế hoạch vật tư");
                xrMainTab.SelectedTabPage = xrVatTu;
                return false;
            }

            if (grvKhSanPham.RowCount == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa kế hoạch sản phẩm");
                xrMainTab.SelectedTabPage = xrSanXuat;
                return false;
            }

            foreach (SxKehoachD obj in lstVatTu)
            {
                if (obj.LoaiChiPhi == 0)
                {
                    FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn loại vật tư");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.VatlieuDauvaoId == new Guid())
                {
                    FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn vật tư");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.SoLuong == 0)
                {
                    FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa nhập số lượng");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }

                if (obj.DvtId == new Guid())
                {
                    FormGlobals.Message_Warning("Kế hoạch vật tư :Bạn chưa chọn đơn vị tính");
                    xrMainTab.SelectedTabPage = xrVatTu;
                    return false;
                }
            }


            foreach (SxKehoachD obj in lstSanXuat)
            {
                if (obj.VatlieuDauraId == new Guid())
                {
                    FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa chọn sản phẩm");
                    xrMainTab.SelectedTabPage = xrSanXuat;
                    return false;
                }

                if (obj.SoLuong == 0)
                {
                    FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa nhập số lượng");
                    xrMainTab.SelectedTabPage = xrSanXuat;
                    return false;
                }

                if (obj.DvtId == new Guid())
                {
                    FormGlobals.Message_Warning("Kế hoạch sản phẩm :Bạn chưa chọn đơn vị tính");
                    xrMainTab.SelectedTabPage = xrSanXuat;
                    return false;
                }
            }

            return true;
        }

        private void AddRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (lstVatTu == null) lstVatTu = new List<SxKehoachD>();                
                lstVatTu.Add(new SxKehoachD());
                grcVatTu.DataSource = lstVatTu;
                grcVatTu.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvVatTu, grvVatTu.RowCount - 1);
            }
            if (xrMainTab.SelectedTabPage == xrSanXuat)
            {
                if (lstSanXuat == null) lstSanXuat = new List<SxKehoachD>();
                var objadd = new SxKehoachD();
                objadd.LoaiChiPhi = 3;
                lstSanXuat.Add(objadd);
                grcKhSanPham.DataSource = lstSanXuat;
                grcKhSanPham.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvKhSanPham, grvKhSanPham.RowCount - 1);
            }

            if (xrMainTab.SelectedTabPage == xrKeHoach)
            {
                if (lstKeHoach == null) lstKeHoach = new List<SxPhancong>();
                SxPhancong objPc = new SxPhancong();
                objPc.ThuTu = grvKeHoach.RowCount + 1;
                objPc.LenhSanXuat = new SxLenhsanxuat();
                objPc.LenhSanXuat.LstLenhSanXuatDetail = new List<SxLenhsanxuatD>();
                lstKeHoach.Add(objPc);
                grcKeHoach.DataSource = lstKeHoach;
                grcKeHoach.RefreshDataSource();
                GridHelper.SetFocus_AfterAddRow(grvKeHoach, grvKeHoach.RowCount - 1);
            }
        }

        private void DeleteRow()
        {
            if (xrMainTab.SelectedTabPage == xrVatTu)
            {
                if (grvVatTu.FocusedRowHandle < 0) return;
                if (lstDelVatTu == null)
                    lstDelVatTu = new List<SxKehoachD>();

                SxKehoachD dm = (SxKehoachD)grvVatTu.GetRow(grvVatTu.FocusedRowHandle);
                lstDelVatTu.Add(dm);
                grvVatTu.DeleteSelectedRows();
                grvVatTu.RefreshData();
            }

            if (xrMainTab.SelectedTabPage == xrSanXuat)
            {
                if (grvKhSanPham.FocusedRowHandle < 0) return;
                if (lstDelSanXuat == null)
                    lstDelSanXuat = new List<SxKehoachD>();

                SxKehoachD dm = (SxKehoachD)grvKhSanPham.GetRow(grvKhSanPham.FocusedRowHandle);
                lstDelSanXuat.Add(dm);
                grvKhSanPham.DeleteSelectedRows();
                grvKhSanPham.RefreshData();
            }

            if (xrMainTab.SelectedTabPage == xrKeHoach)
            {
                if (grvKeHoach.FocusedRowHandle < 0) return;
                if (lstDelKeHoach == null)
                    lstDelKeHoach = new List<SxPhancong>();

                SxPhancong dm = (SxPhancong)grvKeHoach.GetRow(grvKeHoach.FocusedRowHandle);
                lstDelKeHoach.Add(dm);
                grvKeHoach.DeleteSelectedRows();
                grvKeHoach.RefreshData();
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

        private void grvKeHoach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (GridHelper.CheckAddNewRow(grvKeHoach))
            {
                AddRow();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLenhSanXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = grvKeHoach.FocusedRowHandle;
            SxPhancong obj = (SxPhancong)grvKeHoach.GetRow(grvKeHoach.FocusedRowHandle);
            if (obj.Id != new Guid())
            {
                frmLenhSanXuat_DanhSach frm = new frmLenhSanXuat_DanhSach(obj.Id);
                frm.ShowDialog();
            }
            else
            {
                FormGlobals.Message_Information("Kế hoạch phân công chưa được tạo");
            }
        }

        private void grvKhSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvKhSanPham.FocusedRowHandle < 0) return;
            SxKehoachD tmp = (SxKehoachD)grvKhSanPham.GetRow(grvKhSanPham.FocusedRowHandle);
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
            SxKehoachD tmp = (SxKehoachD)grvVatTu.GetRow(grvVatTu.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colVatLieu":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.VatlieuDauvaoId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        private void grvKeHoach_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvKeHoach.FocusedRowHandle < 0) return;
            SxPhancong tmp = (SxPhancong)grvKeHoach.GetRow(grvVatTu.FocusedRowHandle);
            switch (e.Column.Name)
            {
                case "colPhanCongSanPham":
                    DmHanghoa tmpHh = (DmHanghoa)grlSanPham.GetRowByKeyValue(tmp.SanphamId);
                    tmp.DvtId = tmpHh.DvtId;
                    break;
            }
        }

        #endregion

        private void frmKeHoach_ChiTiet_Load(object sender, EventArgs e)
        {

        }
               
    }
}