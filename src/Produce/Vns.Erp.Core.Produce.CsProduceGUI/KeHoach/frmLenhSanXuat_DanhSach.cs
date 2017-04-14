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
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmLenhSanXuat_DanhSach : DevExpress.XtraEditors.XtraForm
    {

        #region Variable
        public ISxLenhsanxuatService SxLenhsanxuatService;

        private IDmHanghoaService _DmHanghoaService;
        public IDmHanghoaService DmHanghoaService;

        private ISxDmQuytrinhService _SxDmQuytrinhService;
        public ISxDmQuytrinhService SxDmQuytrinhService
        {
            get { return _SxDmQuytrinhService; }
            set { _SxDmQuytrinhService = value; }
        }

        private IDmDvtService _DmDvtService;
        public IDmDvtService DmDvtService
        {
            get { return _DmDvtService; }
            set { _DmDvtService = value; }
        }

        private IHtDanhmucService _HtDanhmucService;
        public IHtDanhmucService HtDanhmucService
        {
            get { return _HtDanhmucService; }
            set { _HtDanhmucService = value; }
        }

        private bool _IsMenu;
        public bool IsMenu
        {
            get { return _IsMenu; }
            set { _IsMenu = value; }
        }

        IList<HtDanhmuc> lstDanhMuc = new List<HtDanhmuc>();
        private Guid PhanCongId = new Guid();
        #endregion

        #region Contructor

        public frmLenhSanXuat_DanhSach()
        {
            IsMenu = true;
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        public frmLenhSanXuat_DanhSach(Guid _Id)
        {
            IsMenu = false;
            PhanCongId = _Id;
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Private function

        private void LoadData()
        {
            btnAddNew.Visible = IsMenu;
            btnModify.Visible = IsMenu;
            btnDelete.Visible = IsMenu;

            if (SxLenhsanxuatService == null)
            {
                SxLenhsanxuatService = (ISxLenhsanxuatService)ObjectFactory.GetObject("SxLenhsanxuatService");
            }
            if (DmHanghoaService == null)
            {
                DmHanghoaService = (IDmHanghoaService)ObjectFactory.GetObject("DmHanghoaService");
            }

            if (DmDvtService == null)
            {
                DmDvtService = (IDmDvtService)ObjectFactory.GetObject("DmDvtService");
            }

            if (HtDanhmucService == null)
            {
                HtDanhmucService = (IHtDanhmucService)ObjectFactory.GetObject("HtDanhmucService");
            }

            if (SxDmQuytrinhService == null)
            {
                SxDmQuytrinhService = (ISxDmQuytrinhService)ObjectFactory.GetObject("SxDmQuytrinhService");
            }
            cboQuyTrinh.DataSource = SxDmQuytrinhService.GetAll();
            lstDanhMuc = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            IList<HtDanhmuc> lstTrangThaiLenh = HtDanhmucService.GetByDoiTuong("TT_KEHOACH");
            cboTrangThaiLenh.DataSource = lstTrangThaiLenh;

            IList<SxLenhsanxuat> lstLenhSx = new List<SxLenhsanxuat>();
            if (IsMenu)
                lstLenhSx = SxLenhsanxuatService.GetbyDonviId(Generals.DonviID);
            else
                lstLenhSx = SxLenhsanxuatService.LoadByPhanCongId(PhanCongId);
            grcDanhSach.DataSource = lstLenhSx;
        }

        private HtDanhmuc getDoiTuongByGt(int gt)
        {
            foreach (HtDanhmuc obj in lstDanhMuc)
            {
                if (obj.GiaTri == gt)
                {
                    return obj;
                }
            }
            return null;
        }

        private void LoadDataDetail()
        {
            SxLenhsanxuat obj = (SxLenhsanxuat)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            if (obj != null)
            {
                IList<KeHoachDetail> lstDetail = new List<KeHoachDetail>();
                KeHoachDetail objTemp;
                foreach (SxLenhsanxuatD objD in obj.LstLenhSanXuatDetail)
                {
                    objTemp = new KeHoachDetail();
                    if (objD.LoaiLenh == (int)FormGlobals.DinhMucType.VatTu)
                    {
                        objTemp.LoaiKeHoach = "Kế hoạch vật tư";
                    }
                    else if (objD.LoaiLenh == (int)FormGlobals.DinhMucType.SanPham)
                    {
                        objTemp.LoaiKeHoach = "Kế hoạch sản xuất";
                    }

                    DmHanghoa objHangHoa = DmHanghoaService.GetById(objD.VatlieuDauraId == new Guid() ? objD.VatlieuDauvaoId : objD.VatlieuDauraId);
                    if (objHangHoa != null)
                    {
                        objTemp.MaVatLieu = objHangHoa.KyHieu;
                        objTemp.TenVatLieu = objHangHoa.TenHanghoa;
                    }

                    DmDvt objDvt = DmDvtService.GetById(objD.DvtId);
                    if (objDvt != null)
                    {
                        objTemp.TenDvt = objDvt.TenDvt;
                    }

                    HtDanhmuc objLoaiVatLieu = getDoiTuongByGt(objD.LoaiChiPhi);
                    if (objLoaiVatLieu != null)
                    {
                        objTemp.LoaiVatLieu = objLoaiVatLieu.TenDanhmuc;
                    }
                    objTemp.MoTa = objD.MoTa;
                    objTemp.SoLuong = objD.SoLuong;

                    lstDetail.Add(objTemp);
                }
                grcChiTiet.DataSource = lstDetail;
            }
        }

        private void Edit()
        {
            if (grvDanhSach.RowCount == 0)
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                return;
            }

            int i = grvDanhSach.FocusedRowHandle;
            SxLenhsanxuat obj = (SxLenhsanxuat)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            frmLenhSanXuat_ChiTiet frm = (frmLenhSanXuat_ChiTiet)ObjectFactory.GetObject("frmLenhSanXuat_ChiTiet");
            SxLenhsanxuat objReturn = frm.Show_Form(obj, FormGlobals.DataInputState.EditMode);
            if (objReturn != null)
            {
                LoadData();
                grvDanhSach.FocusedRowHandle = i;
            }
        }

        private void AddNew()
        {
            frmLenhSanXuat_ChiTiet frm = (frmLenhSanXuat_ChiTiet)ObjectFactory.GetObject("frmLenhSanXuat_ChiTiet");
            SxLenhsanxuat obj = frm.Show_Form(new SxLenhsanxuat(), FormGlobals.DataInputState.AddMode);
            if (obj != null)
            {
                LoadData();
            }
        }

        private void Delete()
        {
            if (grvDanhSach.RowCount == 0)
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                return;
            }

            SxLenhsanxuat obj = (SxLenhsanxuat)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?"))
            {
                SxLenhsanxuatService.DeleteById(obj.Id);
                LoadData();
            }
        }

        #endregion

        #region Event

        private void frmKeHoach_DanhSach_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddNew();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvKeHoach_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LoadDataDetail();
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