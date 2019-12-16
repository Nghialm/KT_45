using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Service.Interface.Report;
using Vns.Erp.Core.Produce.Domain.Report;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.CsProduceGUI.Opec
{
    public partial class frmBcTongHopHH : DevExpress.XtraEditors.XtraForm
    {
        #region Property
        public IProduceReportService ProduceReportService { get; set; }
        public IDmHanghoaService DmHanghoaService { get; set; }
        public IDmNhomvattu1Service DmNhomvattu1Service { get; set; }
        public IDmTaikhoanService DmTaikhoanService { get; set; }
        public IHtDanhmucService HtDanhmucService { get; set; }
        public IBangGiaHService BangGiaHService { get; set; }
        #endregion
        public FormGlobals.DataInputState FormStatus = FormGlobals.DataInputState.AddMode;

        private IList<DmHanghoa> lstHanghoa = new List<DmHanghoa>();
        private IList<DmNhomvattu1> lstType = new List<DmNhomvattu1>();
        private IList<DmNhomvattu1> lstApplication = new List<DmNhomvattu1>();
        private IList<DmTaikhoan> lstTaikhoan = new List<DmTaikhoan>();
        private IList<HtDanhmuc> lstDiaLy = new List<HtDanhmuc>();

        BangGiaH objBangGiaH = new BangGiaH();
        IList<BangGiaD> lstBangGiaD = new List<BangGiaD>();
        IList<BangGiaH> lstBangGiaH = new List<BangGiaH>();

        public frmBcTongHopHH()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        private void frmBcKeHoachSanXuat_Load(object sender, EventArgs e)
        {
            txtNgayBangGia.EditValue = DateTime.Now;
            bindDataToCbo();
            LoadData();
            FormStatus = FormGlobals.DataInputState.ViewMode;
            EnableControl();
            
        }

        private void LoadData()
        {
            lstBangGiaH = BangGiaHService.GetBangGia(Generals.DonviID);
            grvBangGiaH.DataSource = lstBangGiaH;
            if (lstBangGiaH.Count == 0)
                loadData(txtNgayBangGia.DateTime);
            else
                LoadDetails(lstBangGiaH[0]);

        }

        private void LoadDetails(BangGiaH banggiah)
        {

            banggiah = ProduceReportService.GetBangGia(banggiah);
            lstBangGiaD = banggiah.lstBangGiaD;
            grcReport.DataSource = lstBangGiaD;

            txtNgayBangGia.EditValue = banggiah.NgayBangGia;
        }

        private void bindDataToCbo()
        {
            lstHanghoa = DmHanghoaService.GetAllByDonviID(Generals.DonviID);
            lstType = DmNhomvattu1Service.GetAllByNhom(Generals.DonviID, 1);
            lstApplication = DmNhomvattu1Service.GetAllByNhom(Generals.DonviID, 2);
            lstTaikhoan = DmTaikhoanService.GetAllByDonviID(Generals.DonviID);
            lstDiaLy = HtDanhmucService.GetByDoiTuong("DIA_LY");

            cboHanghoa.DataSource = lstHanghoa;
            cboType.DataSource = lstType;
            cboApplication.DataSource = lstApplication;
            cboTaiKhoan.DataSource = lstTaikhoan;
            cboDiaLy.DataSource = lstDiaLy;
        }

        private void loadData(DateTime p_tuNgay)
        {
            lstBangGiaD = ProduceReportService.GetBangGiaTheoNgay(p_tuNgay, Generals.DonviID);
            
            grcReport.DataSource = lstBangGiaD;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadData(txtNgayBangGia.DateTime);
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmBcKeHoachSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break; // TODO: might not be correct. Was : Exit Select
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveBangGia();
            FormStatus = FormGlobals.DataInputState.ViewMode;
            EnableControl();
        }

        private void SaveBangGia()
        {
            switch (FormStatus)
            {
                case FormGlobals.DataInputState.AddMode:
                    objBangGiaH = new BangGiaH();
                    objBangGiaH.NgayBangGia = txtNgayBangGia.DateTime;
                    objBangGiaH.TrangThai = 9;
                    objBangGiaH.DonviId = Generals.DonviID;
                    objBangGiaH.NguoiLap = Generals.USER.Id;
                    objBangGiaH.NgayTao = DateTime.Now;
                    objBangGiaH.NguoiTao = Generals.USER.Id;
                    objBangGiaH.NguoiSua = Generals.USER.Id;
                    objBangGiaH.NgaySua = DateTime.Now;

                    objBangGiaH.lstBangGiaD = lstBangGiaD;
                    break;
                case FormGlobals.DataInputState.EditMode:
                    objBangGiaH.NgayBangGia = txtNgayBangGia.DateTime;
                    objBangGiaH.TrangThai = 9;
                    objBangGiaH.DonviId = Generals.DonviID;
                    objBangGiaH.NguoiLap = Generals.USER.Id;
                    //objBangGiaH.NgayTao = DateTime.Now;
                    //objBangGiaH.NguoiTao = Generals.USER.Id;
                    objBangGiaH.NguoiSua = Generals.USER.Id;
                    objBangGiaH.NgaySua = DateTime.Now;

                    objBangGiaH.lstBangGiaD = lstBangGiaD;
                    break;
                default:
                    return;
            }
            Boolean bcheck = BangGiaHService.SaveBangGia(objBangGiaH);
            if (FormStatus == FormGlobals.DataInputState.AddMode &&
                bcheck)
            {
                lstBangGiaH.Add(objBangGiaH);
                grvBangGiaH.DataSource = null;
                grvBangGiaH.DataSource = lstBangGiaH;
                grvBangGiaH.Refresh();

            }
        }

        private void grvLPX_Hnx_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowindex = grvLPX_Hnx.FocusedRowHandle;
            if (rowindex < 0) return;
            objBangGiaH = (BangGiaH)grvLPX_Hnx.GetRow(rowindex);
            if (objBangGiaH == null) return;
            
            LoadDetails(objBangGiaH);
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FormStatus = FormGlobals.DataInputState.AddMode;
            txtNgayBangGia.DateTime = DateTime.Now;
            EnableControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormStatus = FormGlobals.DataInputState.EditMode;
            EnableControl();
        }

        private void EnableControl()
        {
            switch (FormStatus)
            {
                case FormGlobals.DataInputState.AddMode:
                case FormGlobals.DataInputState.EditMode:
                    btnAddnew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnLuuBangGia.Enabled = true;
                    grvBangGiaH.Enabled = false;
                    break;
                case FormGlobals.DataInputState.ViewMode:
                    btnAddnew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnLuuBangGia.Enabled = false;
                    grvBangGiaH.Enabled = true;
                    break;
            }
        }

        private void grvLPX_Hnx_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowindex = grvLPX_Hnx.FocusedRowHandle;
            if (rowindex < 0) return;
            objBangGiaH = (BangGiaH)grvLPX_Hnx.GetRow(rowindex);
            if (objBangGiaH == null) return;

            LoadDetails(objBangGiaH);
        }

        private void grvReport_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int rowindex = e.RowHandle;
            if (rowindex < 0) return;
            BangGiaD obj = (BangGiaD)grvReport.GetRow(rowindex);
            if (obj == null) return;

            if (obj.MaNghiepVu == "151" && obj.Cang == 0)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
    }
}