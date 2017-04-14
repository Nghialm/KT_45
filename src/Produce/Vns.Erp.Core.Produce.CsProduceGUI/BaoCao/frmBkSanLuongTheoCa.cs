using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Service.Interface.Report;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Produce.Domain.Report;

namespace Vns.Erp.Core.Produce.CsProduceGUI.BaoCao
{
    public partial class frmBkSanLuongTheoCa : DevExpress.XtraEditors.XtraForm
    {
        private IProduceReportService _ProduceReportService;
        public IProduceReportService ProduceReportService
        {
            get { return _ProduceReportService; }
            set { _ProduceReportService = value; }
        }

        //private ISxKehoachMService _SxKehoachMService;
        //public ISxKehoachMService SxKehoachMService
        //{
        //    get { return _SxKehoachMService; }
        //    set { _SxKehoachMService = value; }
        //}

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private IDmDvtService _DmDvtService;
        public IDmDvtService DmDvtService
        {
            get { return _DmDvtService; }
            set { _DmDvtService = value; }
        }

        public frmBkSanLuongTheoCa()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadData(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmBcSanXuatTheoNgay_Load(object sender, EventArgs e)
        {
            dteTuNgay.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dteDenNgay.DateTime = new DateTime(DateTime.Now.Year, 12, 31);

            bindDataToCbo();
        }

        private void bindDataToCbo()
        {
            //IList<SxKehoachM> lstKeHoach = SxKehoachMService.GetAll();
            //cboKeHoachSx.Properties.DataSource = lstKeHoach;
            //cboKeHoachSx.Properties.ValueMember = "Id";
            //cboKeHoachSx.Properties.DisplayMember = "SoLenh";
            //if (lstKeHoach.Count > 0)
            //{
            //    cboKeHoachSx.EditValue = lstKeHoach[0].Id;
            //}

            IList<DmPhongban> lstPhongban = _DmPhongbanService.GetAllByDonviID(Generals.DonviID);
            cboPhanXuong.DataSource = lstPhongban;
            cboToSanXuat.Properties.DataSource = lstPhongban;

            IList<DmDvt> lstdvt = _DmDvtService.GetAllByDonviID(Generals.DonviID);
            cboDvt.DataSource = lstdvt;

            //cboLoaiVatLieu.SelectedIndex = 0;
        }

        private void loadData(DateTime p_tuNgay, DateTime p_denNgay)
        {
            DmPhongban tmppb = (DmPhongban)ComboHelper.GetSelectData(cboToSanXuat);
            if (tmppb == null) tmppb = new DmPhongban();

            IList<SxBkSanLuongDTO> lstData = new List<SxBkSanLuongDTO>();
            lstData = ProduceReportService.GetBangKeSanLuong(p_tuNgay, p_denNgay, Null.NullGuid, Null.NullGuid, Null.NullGuid, tmppb.Id, Null.NullGuid, Generals.DonviID);
            grcReport.DataSource = lstData;

        }
    }
}