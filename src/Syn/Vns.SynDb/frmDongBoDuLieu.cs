using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Vns.Erp.Core.SynDb
{
    public partial class frmDongBoDuLieu : DevExpress.XtraEditors.XtraForm
    {
        #region Property
        private SynDbHelper _SynDbHelper;
        private SynAccountingHelper _SynAccountingHelper;
        #endregion

        public frmDongBoDuLieu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            _SynDbHelper = (SynDbHelper)ObjectFactory.GetObject("Vns.Erp.Core.SynDb.SynDbHelper");
            _SynAccountingHelper = (SynAccountingHelper)ObjectFactory.GetObject("Vns.Erp.Core.SynDb.SynAccountingHelper");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbkSynDanhMuc.Checked)
            {
                DongBoDanhMuc();
            }

            if (cbkDongBoCt.Checked)
            {
                DongBoKeToan();
            }
        }

        private void DongBoDanhMuc()
        {
            _SynDbHelper.IsSynAll = true;
            //Dong bo danh muc he thong
            _SynDbHelper.SynDmDonvi(Generals.DonviID);

            //Dong bo danh muc ke toan
            _SynDbHelper.SynDmTaiKhoan(Generals.DonviID);
            _SynDbHelper.SynDmNhomKhang(Generals.DonviID);
            _SynDbHelper.SynDmKhang(Generals.DonviID);
            _SynDbHelper.SynDmHopdong(Generals.DonviID);
            _SynDbHelper.SynDmKhoanphi(Generals.DonviID);
            _SynDbHelper.SynDmPhongban(Generals.DonviID);
            _SynDbHelper.SynDmTudo1(Generals.DonviID);
            _SynDbHelper.SynDmTudo2(Generals.DonviID);
            _SynDbHelper.SynDmTudo3(Generals.DonviID);
            _SynDbHelper.SynDmTudo4(Generals.DonviID);
            _SynDbHelper.SynDmTudo5(Generals.DonviID);
            _SynDbHelper.SynDmPtqt(Generals.DonviID);
            _SynDbHelper.SynDmVuviec(Generals.DonviID);
            //_SynDbHelper.SynDmNgoaite(Generals.DonviID);

            //Dong bo danh muc kho
            _SynDbHelper.SynDmKho(Generals.DonviID);
            _SynDbHelper.SynDmDvt(Generals.DonviID);
            _SynDbHelper.SynDmNhomvattu1(Generals.DonviID);
            _SynDbHelper.SynDmHanghoa(Generals.DonviID);

            //Dong bo danh muc tai san co dinh
            _SynDbHelper.SynDmNhomTscd(Generals.DonviID);
            _SynDbHelper.SynDmLydoTgTscd(Generals.DonviID);
            _SynDbHelper.SynDmNguonTscd(Generals.DonviID);
        }

        private void DongBoKeToan()
        {
            _SynAccountingHelper.IsSynAll = true;
            //_SynAccountingHelper.SynCtH(Generals.DonviID);

            //_SynAccountingHelper.SynCtHoadon(Generals.DonviID);

            //_SynAccountingHelper.SynKtCtHKhac(Generals.DonviID);

            _SynAccountingHelper.SynKtCtHHddv(Generals.DonviID);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}