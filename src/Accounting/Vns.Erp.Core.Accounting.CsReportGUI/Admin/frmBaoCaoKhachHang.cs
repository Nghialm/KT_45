using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Report.Service.Interface;
using Vns.Erp.Core.Accounting.Report.Domain;

namespace Vns.Erp.Core.Accounting.CsReportGUI.Admin
{
    public partial class frmBaoCaoKhachHang : DevExpress.XtraEditors.XtraForm
    {
        #region Property
        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private IDmKhangService _DmKhangService;
        public IDmKhangService DmKhangService
        {
            get { return _DmKhangService; }
            set { _DmKhangService = value; }
        }

        private IRpAdminLedgerService _RpAdminLedgerService;
        public IRpAdminLedgerService RpAdminLedgerService
        {
            get { return _RpAdminLedgerService; }
            set { _RpAdminLedgerService = value; }
        }
         
        #endregion

        public frmBaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            BindCombo();
        }

        private void BindCombo()
        {
            IList<DmKhang> lstKhang = _DmKhangService.GetAllByDonviID(Generals.DON_VI.Id);
            IList<DmTaikhoan> lstTaiKhoan = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id);

            cboKhachHang.Properties.DataSource = lstKhang;
            cboTaiKhoan.Properties.DataSource = lstTaiKhoan;
            cboKhang.DataSource = lstKhang;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            BindData();
        }

        private void BindData()
        {
            DmTaikhoan objTk = (DmTaikhoan)ComboHelper.GetSelectData(cboTaiKhoan);
            DateTime TuNgay = DateTime.Now;
            DateTime DenNgay = DateTime.Now;

            TuNgay = ucDate.StartDate;
            DenNgay = ucDate.EndDate;

            String MaTk = objTk.MaTaikhoan;

            DmKhang objKhang = (DmKhang)ComboHelper.GetSelectData(cboKhachHang);
            Guid idKhang = (objKhang == null ? Vns.Erp.Core.Null.NullGuid : objKhang.Id); 

            IList<RpLedgerAdminDTO> lstData = new List<RpLedgerAdminDTO>();
            lstData = _RpAdminLedgerService.GetDataDetail(MaTk, "", TuNgay, DenNgay, Generals.DON_VI.Id, idKhang, Null.NullGuid);

            grcData.DataSource = lstData;
        }

        private void cboTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            if (cboTaiKhoan.EditValue == null)
            {
                dxErrorProvider1.SetError((Control)sender, "Yeu cau chon gia tri!");
                e.Cancel = true;
            }
            else
            {
                dxErrorProvider1.SetError((Control)sender, "");
            }
        }
    }
}