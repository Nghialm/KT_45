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
    public partial class frmBcChiTietHH : DevExpress.XtraEditors.XtraForm
    {
        public IProduceReportService ProduceReportService { get; set; }

        public IDmHanghoaService DmHanghoaService { get; set; }

        public IDmNhomvattu1Service DmNhomvattu1Service { get; set; }
        public IDmVuviecService DmVuviecService { get; set; }
        public IDmKhoService DmKhoService { get; set; }
        public IDmTaikhoanService DmTaikhoanService { get; set; }
        public IHtDanhmucService HtDanhmucService { get; set; }

        private IList<DmHanghoa> lstHanghoa = new List<DmHanghoa>();
        private IList<DmNhomvattu1> lstType = new List<DmNhomvattu1>();
        private IList<DmNhomvattu1> lstApplication = new List<DmNhomvattu1>();
        private IList<DmKho> lstKho = new List<DmKho>();
        private IList<DmVuviec> lstVuviec = new List<DmVuviec>();
        private IList<DmTaikhoan> lstTaikhoan = new List<DmTaikhoan>();
        private IList<HtDanhmuc> lstDiaLy = new List<HtDanhmuc>();

        public frmBcChiTietHH()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        private void frmBcKeHoachSanXuat_Load(object sender, EventArgs e)
        {
            //dteTuNgay.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            //dteDenNgay.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
            bindDataToCbo();
            loadData(dateTimeInput1.StartDate, dateTimeInput1.EndDate);
        }

        private void bindDataToCbo()
        {
            lstHanghoa = DmHanghoaService.GetAllByDonviID(Generals.DonviID);
            lstType = DmNhomvattu1Service.GetAllByNhom(Generals.DonviID, 1);
            lstApplication = DmNhomvattu1Service.GetAllByNhom(Generals.DonviID, 2);
            lstVuviec = DmVuviecService.GetAllByDonviID(Generals.DonviID);
            lstKho = DmKhoService.GetAllByDonviID(Generals.DonviID);
            lstTaikhoan = DmTaikhoanService.GetAllByDonviID(Generals.DonviID);
            lstDiaLy = HtDanhmucService.GetByDoiTuong("DIA_LY");

            cboHanghoa.DataSource = lstHanghoa;
            cboType.DataSource = lstType;
            cboApplication.DataSource = lstApplication;
            cboVuviec.DataSource = lstVuviec;
            cboKho.DataSource = lstKho;
            cboTaiKhoan.DataSource = lstTaikhoan;
            cboDiaLy.DataSource = lstDiaLy;
        }

        private void loadData(DateTime p_tuNgay, DateTime p_denNgay)
        {
            IList<BcKeToanKhoDTO> lstData = new List<BcKeToanKhoDTO>();
            lstData = ProduceReportService.GetBangKe(p_tuNgay, p_denNgay, Generals.DonviID);
            grcReport.DataSource = lstData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadData(dateTimeInput1.StartDate, dateTimeInput1.EndDate);
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

        //Liệt kê xuất kho nhập kho của lệnh sản xuất đấy

        //Tổng hợp nhiều lệnh sản xuất
        //Đk lọc:
        //+ Kế hoạch sản xuất(bắt buộc)
        //+ Từ ngày -> ngày

        //Nhóm
        //+ kế hoạch sx
        //+ lệnh sản xuất
        //+ Phân xưởng tổ đội

        //Nhóm theo định mức
        //Loại kế hoạch = 2
    }
}