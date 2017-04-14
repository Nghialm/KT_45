using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using System.Windows.Forms;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Accounting.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmTinhKhauHaoCCDC
    {
        #region Property
        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }

        private ICcDmCcdcService _CcDmCcdcService;
        public ICcDmCcdcService CcDmCcdcService
        {
            get { return _CcDmCcdcService; }
            set { _CcDmCcdcService = value; }
        }

        private ICcCtCcdcService _CcCtCcdcService;
        public ICcCtCcdcService CcCtCcdcService
        {
            get { return _CcCtCcdcService; }
            set { _CcCtCcdcService = value; }
        }

        private ICcCtCcdcNvonService _CcCtCcdcNvonService;
        public ICcCtCcdcNvonService CcCtCcdcNvonService
        {
            get { return _CcCtCcdcNvonService; }
            set { _CcCtCcdcNvonService = value; }
        }

        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }

        private ICtHService _CtHService;
        public ICtHService CtHService
        {
            get { return _CtHService; }
            set { _CtHService = value; }
        }

        private ICcLsPhanboCcService _CcLsPhanboCcService;
        public ICcLsPhanboCcService CcLsPhanboCcService
        {
            get { return _CcLsPhanboCcService; }
            set { _CcLsPhanboCcService = value; }
        }
        #endregion
        
        private List<DmTaikhoan> dt;
        private String LOAI_CT;
        private HtLoaichungtu obj_LoaiCT = new HtLoaichungtu();

        #region Contruction
        public frmTinhKhauHaoCCDC()
        {
            InitializeComponent();

            AddEvents();

            TNCommon.setIconControl(this);
        }
        #endregion

        #region Function
        ///' <summary>
        ///' 
        ///' </summary>
        ///' <remarks></remarks>
        private void BindData()
        {
            dt = new List<DmTaikhoan>();
            dt.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
        }

        private List<CcLsPhanboCc> lstPhanBo = new List<CcLsPhanboCc>();
        private void TinhKhauHao()
        {
            IList<CcCtCcdc> lst = new List<CcCtCcdc>();
            lstCtD = new List<CtD>();
            lstPhanBo = new List<CcLsPhanboCc>();
            int Thang = int.Parse(txtTHANG.Text);
            int Nam = int.Parse(txtNAM.Text);
            DateTime NgayTinh = new DateTime(Nam, Thang, 1);
            NgayTinh = NgayTinh.AddMonths(1).AddDays(-1);
            lst = _CcCtCcdcService.GetByNgayThangKhauhao(NgayTinh, Generals.DonviID);

            Decimal TongTien = 0;
            foreach (CcCtCcdc tmp in lst)
            {
                CcLsPhanboCc lsPhanBo = new CcLsPhanboCc();

                CtD objCtd = new CtD();

                lsPhanBo.CcdcId = tmp.Id;
                lsPhanBo.TenCcdc = tmp.TenCcdc;
                lsPhanBo.MaCcdc = tmp.MaCcdc;
                lsPhanBo.NguyenGia = tmp.NguyenGia;

                DateTime tempdate = tmp.NgayBdpb.AddMonths(Convert.ToInt32(tmp.SoKyPhanbo - 1));
                DateTime Enddate = new DateTime(tempdate.Year, tempdate.Month, 1).AddMonths(1).AddDays(-1);
                DateTime Startdate = new DateTime(tmp.NgayBdpb.Year, tmp.NgayBdpb.Month, 1);

                if (Enddate < NgayTinh || Startdate > NgayTinh) continue;

                if (NgayTinh.Month == tempdate.Month && NgayTinh.Year == tempdate.Year)
                {
                    lsPhanBo.SoTienPb = tmp.NguyenGia - (tmp.SoKyPhanbo - 1) * Decimal.Round(tmp.NguyenGia / tmp.SoKyPhanbo);
                }
                else
                {
                    lsPhanBo.SoTienPb = Decimal.Round(tmp.NguyenGia / tmp.SoKyPhanbo);
                }

                lsPhanBo.Thang = Thang;
                lsPhanBo.Nam = Nam;
                lsPhanBo.DonviId = tmp.DonviId;
                lstPhanBo.Add(lsPhanBo);

                DmTaikhoan tkNo = GetTen_TK(tmp.MdTkChiphi);
                DmTaikhoan tkCo = GetTen_TK(tmp.MdTkPhanbo);

                objCtd.TkNoId = tkNo.Id;
                objCtd.MaTkNo = tkNo.MaTaikhoan;
                objCtd.TenTkNo = tkNo.TenTaikhoan;

                objCtd.TkCoId = tkCo.Id;
                objCtd.MaTkCo = tkCo.MaTaikhoan;
                objCtd.TenTkCo = tkCo.TenTaikhoan;

                objCtd.SoTien = lsPhanBo.SoTienPb;
                objCtd.SoTienNte = 0;
                objCtd.NoiDung = String.Format("Trich chi phi CCDC {0}", tmp.TenCcdc);
                objCtd.LoaiNghiepVu = 9;
                objCtd.SoDu = 0;
                objCtd.PhanHe = 0;

                lstCtD.Add(objCtd);
                TongTien += lsPhanBo.SoTienPb;
            }

            objCtH = new CtH();
            objCtH.DonviId = Generals.DON_VI.Id;
            objCtH.MaDonvi = Generals.DON_VI.MaDonvi;
            objCtH.NgayCt = NgayTinh;
            objCtH.NgayGhi = NgayTinh;
            objCtH.NgaySua = NgayTinh;
            objCtH.NgayTao = NgayTinh;
            objCtH.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID);
            objCtH.TyGia = 1;
            objCtH.SoTien = TongTien;
            objCtH.SoTienNte = TongTien;
            objCtH.DienGiai = string.Format("Phan bo cong cu dung cu thang {0} nam {1}", Thang, Nam);
            objCtH.BtTudong = 1;
            objCtH.SoDu = 0;

            objCtH.IdLoaiCt = obj_LoaiCT.Id;
            objCtH.MaLoaiCt = obj_LoaiCT.MaLoaiCt;
            objCtH.KyHieuLoaiCt = obj_LoaiCT.KyHieu;

            _TreeList.DataSource = lstPhanBo;
            grcDINH_KHOAN.DataSource = lstCtD;
        }

        private CtH objCtH = new CtH();
        private List<CtD> lstCtD = new List<CtD>();

        private void AddEvents()
        {
            rpeMA_TK_CO.ClearDataFilter += MyRepositoryItem_CleanDFilter;
            rpeMA_TK_NO.ClearDataFilter += MyRepositoryItem_CleanDFilter;
            rpeMA_TK_CO.AfterFilter += MyRepositoryItem_AfterFilter;
            rpeMA_TK_NO.AfterFilter += MyRepositoryItem_AfterFilter;
            rpeMA_TK_CO.FisrtBinddata += rpeMA_TK_CO_FisrtBinddata;
            rpeMA_TK_NO.FisrtBinddata += rpeMA_TK_NO_FisrtBinddata;
        }

        private DmTaikhoan GetTen_TK(Guid TAI_KHOAN_ID)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.Id == TAI_KHOAN_ID)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }

        private DmTaikhoan GetTen_TK(string MaTaikhoan)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.MaTaikhoan == MaTaikhoan)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }
        #endregion

        #region Events
        private void MyRepositoryItem_AfterFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                CtD obj_grv_DINH_KHOAN = (CtD)grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle);
                int rowHandle = grvDINH_KHOAN.FocusedRowHandle;
                string columnName = grvDINH_KHOAN.FocusedColumn.Name;
                switch (columnName)
                {
                    case "MA_TK_NO":
                        List<string> arr = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES;
                        if ((arr.Count > 1))
                        {
                            //grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_NO", arr(2))
                            obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr[0]);
                            obj_grv_DINH_KHOAN.MaTkNo = arr[1];
                            obj_grv_DINH_KHOAN.TenTkNo = arr[2];
                            grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkNo", arr[1]);
                            SendKeys.Send("{TAB}");
                        }
                        break;
                    case "MA_TK_CO":
                        List<string> arr1 = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES;
                        if ((arr1.Count > 1))
                        {
                            //grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_CO", arr(2))
                            obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr1[0]);
                            obj_grv_DINH_KHOAN.MaTkCo = arr1[1];
                            obj_grv_DINH_KHOAN.TenTkCo = arr1[2];
                            grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkCo", arr1[1]);
                            SendKeys.Send("{TAB}");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmTinhKhauHaoCCDC_Load(object sender, EventArgs e)
        {
            BindData();
            string para_str = this.AccessibleDescription;
            List<ParamInfo> lst_para = DataMining.GetParams(para_str);
            if (lst_para.Count > 0)
            {
                LOAI_CT = lst_para[0].PARAMVALUE;
                obj_LoaiCT = _HtLoaichungtuService.GetByMA_LOAI_CT(LOAI_CT, Generals.DON_VI.Id);
            }
        }

        private void btnDINH_KHOAN_Click(object sender, EventArgs e)
        {

        }

        private void rpeMA_TK_CO_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                //rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt);
                rpeMA_TK_CO.Editors.A_DATA_SOURCE = rpeMA_TK_CO.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpeMA_TK_NO_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                //rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt);
                rpeMA_TK_NO.Editors.A_DATA_SOURCE = rpeMA_TK_NO.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void MyRepositoryItem_CleanDFilter(System.Object senders, System.EventArgs e)
        {
            CtD obj_grv_DINH_KHOAN = (CtD)grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle);
            int rowHandle = grvDINH_KHOAN.FocusedRowHandle;
            string columnName = grvDINH_KHOAN.FocusedColumn.Name;
            List<string> arr = new List<string>();
            switch (columnName)
            {
                case "MA_TK_NO":
                    arr = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES;
                    obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr[0]);
                    obj_grv_DINH_KHOAN.MaTkNo = arr[1];
                    obj_grv_DINH_KHOAN.TenTkNo = arr[2];
                    break;
                case "MA_TK_CO":
                    arr = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES;
                    obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr[0]);
                    obj_grv_DINH_KHOAN.MaTkCo = arr[1];
                    obj_grv_DINH_KHOAN.TenTkCo = arr[2];
                    break;
            }
        }

        private void btnKHThang_Click(object sender, EventArgs e)
        {
            TinhKhauHao();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmProgress.Instance().Thread = SaveData;
            frmProgress.Instance().Show_Progress();
            frmProgress.Instance().SetFinishText("Luu du lieu thanh cong!");
        }

        private void SaveData()
        {
            int Thang = int.Parse(txtTHANG.Text);
            int Nam = int.Parse(txtNAM.Text);
            DateTime NgayTinh = new DateTime(Nam, Thang, 1);
            NgayTinh = NgayTinh.AddMonths(1).AddDays(-1);

            _CtHService.DeleteMa(obj_LoaiCT.Id, NgayTinh, Generals.DON_VI.Id);
            _CcLsPhanboCcService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam);

            _CtHService.SaveChungTuKeToan(false, ref objCtH, ref lstCtD);
            _CcLsPhanboCcService.SavePhanBoThang(lstPhanBo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmProgress.Instance().Thread = XoaAll;
            frmProgress.Instance().Show_Progress();
            frmProgress.Instance().SetFinishText("Xoa du lieu thanh cong!");

            grcDINH_KHOAN.DataSource = null;
            _TreeList.DataSource = null;
        }

        private void XoaAll()
        {
            int Thang = int.Parse(txtTHANG.Text);
            int Nam = int.Parse(txtNAM.Text);
            DateTime NgayTinh = new DateTime(Nam, Thang, 1);
            NgayTinh = NgayTinh.AddMonths(1).AddDays(-1);

            _CtHService.DeleteMa(obj_LoaiCT.Id, NgayTinh, Generals.DON_VI.Id);
            _CcLsPhanboCcService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam);
        }
    }

}