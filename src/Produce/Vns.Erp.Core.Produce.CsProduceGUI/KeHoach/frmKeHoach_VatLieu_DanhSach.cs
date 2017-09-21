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
using static Vns.Erp.Core.Common.Controls.PagerControl;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmKeHoach_VatLieu_DanhSach : DevExpress.XtraEditors.XtraForm
    {

        #region Variable
        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        public ISxKehoachMService SxKehoachMService;

        private IDmHanghoaService _DmHanghoaService;
        public IDmHanghoaService DmHanghoaService
        {
            get { return _DmHanghoaService; }
            set { _DmHanghoaService = value; }
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

        IList<HtDanhmuc> lstDanhMuc = new List<HtDanhmuc>();
        HtLoaichungtu obj_loaichungtu = new HtLoaichungtu();
        #endregion

        #region Contructor

        public frmKeHoach_VatLieu_DanhSach()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        #endregion

        #region Private function

        protected void LoadData()
        {
            string para_str = this.AccessibleDescription;
            List<ParamInfo> lst_para = DataMining.GetParams(para_str);
            if (lst_para.Count > 0)
            {
                obj_loaichungtu.MaLoaiCt = lst_para[0].PARAMVALUE;
            }
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id);
            if (obj_loaichungtu == null) return;

            lstDanhMuc = HtDanhmucService.GetByDoiTuong("LOAI_NVL");
            
        }
        private void LoadGrid()
        {
            IList<SxKehoachM> lstQuyTrinh = new List<SxKehoachM>();
            int totalresult = 0;
            lstQuyTrinh = SxKehoachMService.getByMaCt(CtlPagerControl.PageIndex, CtlPagerControl.PageSize,
                obj_loaichungtu.MaLoaiCt, Generals.DonviID, 
                out totalresult);
            CtlPagerControl.TotalResult = totalresult;
            grcDanhSach.DataSource = lstQuyTrinh;
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
            SxKehoachM obj = (SxKehoachM)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            if (obj != null)
            {
                IList<KeHoachDetail> lstDetail = new List<KeHoachDetail>();
                KeHoachDetail objTemp;
                foreach (SxKehoachD objD in obj.LstKeHoachDetail)
                {
                    objTemp = new KeHoachDetail();
                    if (objD.LoaiKeHoach == (int)FormGlobals.DinhMucType.VatTu)
                    {
                        objTemp.LoaiKeHoach = "Kế hoạch vật tư";
                    }
                    else if (objD.LoaiKeHoach == (int)FormGlobals.DinhMucType.SanPham)
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
            SxKehoachM obj = (SxKehoachM)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            frmKeHoach_VatLieu_ChiTiet frm = (frmKeHoach_VatLieu_ChiTiet)ObjectFactory.GetObject("Produce.frmKeHoach_VatLieu_ChiTiet");
            SxKehoachM objReturn = frm.Show_Form(FormGlobals.DataInputState.EditMode, obj, obj_loaichungtu);
            if (objReturn != null)
            {
                LoadData();
                grvDanhSach.FocusedRowHandle = i;                
            }
        }

        private void AddNew()
        {
            frmKeHoach_VatLieu_ChiTiet frm = (frmKeHoach_VatLieu_ChiTiet)ObjectFactory.GetObject("Produce.frmKeHoach_VatLieu_ChiTiet");
            SxKehoachM obj = frm.Show_Form(FormGlobals.DataInputState.AddMode, null, obj_loaichungtu);
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

            SxKehoachM obj = (SxKehoachM)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?"))
            {
                SxKehoachMService.DeleteById(obj.Id);
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

                CtlPagerControl.display = new DisplayResult(this.LoadGrid);
                CtlPagerControl.RefreshPage();
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