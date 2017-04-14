using System.Windows.Forms;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmDanhMucQuyTrinh_Detail : DevExpress.XtraEditors.XtraForm 
    {
        public frmDanhMucQuyTrinh_Detail()
        {
            InitializeComponent();
        }
        SxDmQuytrinh objTemp = null;
        public frmDanhMucQuyTrinh_Detail(SxDmQuytrinh obj)
        {
            InitializeComponent();
            objTemp = obj;
        }

        private void frmDanhMucQuyTrinh_Detail_Load(object sender, EventArgs e)
        {
            uc_QuyTrinhDinhMuc ucDinhMuc = new uc_QuyTrinhDinhMuc();
            xrDinhMuc.Controls.Add(ucDinhMuc);
            uc_DanhMucQuyTrinh_ChiTiet ucQuyTrinh = new uc_DanhMucQuyTrinh_ChiTiet();
            ucQuyTrinh.objQuyTrinh = objTemp;
            ucQuyTrinh.Dock = DockStyle.Fill;
            xrQuyTrinh.Controls.Add(ucQuyTrinh);
        }
    }
}