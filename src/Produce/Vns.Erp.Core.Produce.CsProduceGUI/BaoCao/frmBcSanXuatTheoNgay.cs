using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core.Produce.Service.Interface.Report;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Domain.Report;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmBcSanXuatTheoNgay : DevExpress.XtraEditors.XtraForm
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

        public frmBcSanXuatTheoNgay()
        {
            InitializeComponent();
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

        private void frmBcSanXuatTheoNgay_Load(object sender, EventArgs e)
        {
            bindDataToCbo();
        }

        private void bindDataToCbo()
        {
            IList<SxKehoachM> lstKeHoach = SxKehoachMService.GetByDonviId(Generals.DON_VI.Id);
            cboKeHoachSx.Properties.DataSource = lstKeHoach;
            cboKeHoachSx.Properties.ValueMember = "Id";
            cboKeHoachSx.Properties.DisplayMember = "SoLenh";
            if (lstKeHoach.Count > 0)
            {
                cboKeHoachSx.EditValue = lstKeHoach[0].Id;
            }

            IList<DmPhongban> lstPhongban = _DmPhongbanService.GetAllByDonviID(Generals.DonviID);
            cboPhanXuong.DataSource = lstPhongban;

            cboLoaiVatLieu.SelectedIndex = 0;
        }

        private void loadData(Guid p_keHoachSanXuatId, DateTime p_tuNgay, DateTime p_denNgay)
        {
            IList<SxRpQtSanXuatDTO> lstData = new List<SxRpQtSanXuatDTO>();
            lstData = ProduceReportService.GetDataSanXuat(p_tuNgay, p_denNgay, p_keHoachSanXuatId, new Guid(), new Guid(), new Guid(), new Guid(), Generals.DonviID, cboLoaiVatLieu.SelectedIndex);
            gvKeHoach.DataSource = lstData;
        }

        private void gvKeHoach_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            if (e.RowValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Value && Convert.ToSingle(e.Value) <= 0)
                e.DisplayText = "-";

            if (e.RowValueType != DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal ||
                    e.ColumnValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal ||
                    e.ColumnValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Total) return;
        }

        private void gvKeHoach_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            if (e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal && e.DisplayText == "Grand Total")
                e.DisplayText = "Tổng";  
        }

        private void frmBcSanXuatTheoNgay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break; // TODO: might not be correct. Was : Exit Select
            }
        }
    }
}