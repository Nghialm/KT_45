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

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmBcKeHoachSanXuat : DevExpress.XtraEditors.XtraForm
    {
        private IProduceReportService _ProduceReportService;
        public IProduceReportService ProduceReportService
        {
            get { return _ProduceReportService; }
            set { _ProduceReportService = value; }
        }

        private ISxKehoachMService _SxKehoachMService;
        public ISxKehoachMService SxKehoachMService
        {
            get { return _SxKehoachMService; }
            set { _SxKehoachMService = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        public frmBcKeHoachSanXuat()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        private void frmBcKeHoachSanXuat_Load(object sender, EventArgs e)
        {
            //dteTuNgay.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            //dteDenNgay.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
            bindDataToCbo();
            loadData((Guid)cboKeHoachSx.EditValue, dateTimeInput1.StartDate, dateTimeInput1.EndDate);
        }

        private void bindDataToCbo()
        {
            IList<SxKehoachM> lstKeHoach = SxKehoachMService.GetByDonviId(Generals.DonviID);
            cboKeHoachSx.Properties.DataSource = lstKeHoach;
            cboKeHoachSx.Properties.ValueMember = "Id";
            cboKeHoachSx.Properties.DisplayMember = "SoLenh";
            if (lstKeHoach.Count > 0)
            {
                cboKeHoachSx.EditValue = lstKeHoach[0].Id;
            }

            IList<DmPhongban> lstPhongban = _DmPhongbanService.GetAllByDonviID(Generals.DonviID);
            cboPhanXuong.DataSource = lstPhongban;
        }

        private void loadData(Guid p_keHoachSanXuatId, DateTime p_tuNgay, DateTime p_denNgay)
        {
            IList<SxRpQtSanXuatDTO> lstData = new List<SxRpQtSanXuatDTO>();
            lstData = ProduceReportService.GetDataSanXuatVatTu(p_tuNgay, p_denNgay, p_keHoachSanXuatId, new Guid(), new Guid(), new Guid(), new Guid(), Generals.DonviID);
            grcReport.DataSource = lstData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadData((Guid)cboKeHoachSx.EditValue, dateTimeInput1.StartDate, dateTimeInput1.EndDate);
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