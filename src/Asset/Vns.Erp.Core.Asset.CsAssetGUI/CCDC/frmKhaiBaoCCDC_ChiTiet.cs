using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using System.Data.SqlTypes;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoCCDC_ChiTiet
    {

        #region "properties"

        private ICcCtCcdcNvonService _CcCtCcdcNvonService;
        public ICcCtCcdcNvonService CcCtCcdcNvonService
        {
            get { return _CcCtCcdcNvonService; }
            set { _CcCtCcdcNvonService = value; }
        }

        private ICcDmCcdcService _CcDmCcdcService;
        public ICcDmCcdcService CcDmCcdcService
        {
            get { return _CcDmCcdcService; }
            set { _CcDmCcdcService = value; }
        }

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

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }


        private ICcCtCcdcService _CcCtCcdcService;
        public ICcCtCcdcService CcCtCcdcService
        {
            get { return _CcCtCcdcService; }
            set { _CcCtCcdcService = value; }
        }


        private IDmNguonTscdService _DmNguonTscdService;
        public IDmNguonTscdService DmNguonTscdService
        {
            get { return _DmNguonTscdService; }
            set { _DmNguonTscdService = value; }
        }

        #endregion

        #region "Variables"
        private FormGlobals.DataInputState m_InputState;
        private Guid m_CCDC_Id;
        private CcDmCcdc m_obj_CCDC;
        private CcCtCcdc m_Obj_CCDC_CT;
        private List<CcCtCcdcNvon> m_lstNguonVon;
        private List<CcCtCcdcNvon> m_lstDelNguonVon = new List<CcCtCcdcNvon>();
        private string m_MaCcdcOld = "";
        #endregion
        private IList<DmTaikhoan> lstTaiKhoan;

        #region "Show_form"

        public void AddEvents()
        {
            //this.Load +=new EventHandler(frmKhaiBaoCCDC_ChiTiet_Load);
            this.KeyDown += frmKhaiBaoCCDC_ChiTiet_KeyDown;
            btnSave.Click +=new EventHandler(btnSave_Click);
            btnQuit.Click +=new EventHandler(btnQuit_Click);
            grvNGUON_VON.KeyDown +=new KeyEventHandler(grvNGUON_VON_KeyDown);
            C_filter_TKCC.AfterFilter += new CustomFilter.FilterCustomEventHandler(C_filter_TKCC_AfterFilter);
            C_filter_TKCC.FirstBinddata += new CustomFilter.FilterCustomEventHandler(C_filter_TKCC_FirstBinddata);
            C_filter_TKCC.ClearFilterData += new CustomFilter.FilterCustomEventHandler(C_filter_TKCC_ClearFilterData);
            C_filter_TKPB.AfterFilter += new CustomFilter.FilterCustomEventHandler(C_filter_TKPB_AfterFilter);
            C_filter_TKPB.ClearFilterData += new CustomFilter.FilterCustomEventHandler(C_filter_TKPB_ClearFilterData);
            C_filter_TKPB.FirstBinddata += new CustomFilter.FilterCustomEventHandler(C_filter_TKPB_FirstBinddata);
            C_filter_TKCP.AfterFilter += new CustomFilter.FilterCustomEventHandler(C_filter_TKCP_AfterFilter);
            C_filter_TKCP.FirstBinddata += new CustomFilter.FilterCustomEventHandler(C_filter_TKCP_FirstBinddata);
            C_filter_TKCP.ClearFilterData += new CustomFilter.FilterCustomEventHandler(C_filter_TKCP_ClearFilterData);
            rpTkCP.AfterFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(rpTkCP_AfterFilter);
            rpTkCP.ClearDataFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(rpTkCP_ClearDataFilter);
            rpTkCP.FisrtBinddata +=new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(rpTkCP_FisrtBinddata);
        }

        public frmKhaiBaoCCDC_ChiTiet()
        {
            InitializeComponent();

            AddEvents();

            TNCommon.setIconControl(this);
        }

        public CcDmCcdc Show_Form(Guid p_CCDC_Id, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_CCDC_Id = p_CCDC_Id;
                m_InputState = eState;
                this.ActiveControl = txtMaCC;
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            if ((this.ShowDialog() == DialogResult.OK))
            {
                return m_obj_CCDC;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region "Functions"

        private void Init_Data()
        {
            BindDataToCbo();
            lstTaiKhoan = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id);
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    m_lstNguonVon = new List<CcCtCcdcNvon>();
                    grcNGUON_VON.DataSource = m_lstNguonVon;
                    break;
                case FormGlobals.DataInputState.EditMode:
                    SetObject();
                    break;
            }
        }

        private void BindDataToCbo()
        {
            //Bind ĐVT
            List<DmDvt> _lstDVT = new List<DmDvt>();
            _lstDVT.Add(new DmDvt());
            _lstDVT.AddRange(DmDvtService.GetAll());
            grlDVT.Properties.DataSource = _lstDVT;
            grlDVT.Properties.ValueMember = "Id";
            grlDVT.Properties.DisplayMember = "TenDvt";

            //Bind phong ban
            List<DmPhongban> _lstPhongBan = new List<DmPhongban>();
            _lstPhongBan.Add(new DmPhongban());
            _lstPhongBan.AddRange(DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id));
            grlBoPhanSd.Properties.DataSource = _lstPhongBan;
            grlBoPhanSd.Properties.ValueMember = "Id";
            grlBoPhanSd.Properties.DisplayMember = "TenPhongban";

            //bind Loai phan bo
            DataTable table = new DataTable();
            // Create four typed columns in the DataTable.
            table.Columns.Add("Id", typeof(decimal));
            table.Columns.Add("Ten", typeof(string));

            table.Rows.Add(1, "Phân bổ theo kỳ");
            table.Rows.Add(2, "Phân bổ 2 lần");
            grlKieuPb.Properties.DataSource = table;
            grlKieuPb.Properties.ValueMember = "Id";
            grlKieuPb.Properties.DisplayMember = "Ten";

            //Bind Nguon von
            List<DmNguonTscd> lstNguonVon = new List<DmNguonTscd>();
            lstNguonVon.AddRange(_DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id));
            cboNguonVon.DataSource = lstNguonVon;
        }

        private void GetObject()
        {
            bool bInsert = false;

            if (m_InputState == FormGlobals.DataInputState.AddMode)
            {
                bInsert = true;
            }
            //dm_CCDC
            if (m_obj_CCDC == null)
            {
                m_obj_CCDC = new CcDmCcdc();
            }

            m_obj_CCDC.MaCcdc = txtMaCC.Text;
            m_obj_CCDC.TenCcdc = txtTenCC.Text;
            m_obj_CCDC.SoLuong = VnsConvert.CDecimal(txtSoLuong.Text);

            if (!VnsCheck.IsNullGuid(grlDVT.EditValue))
            {
                DmDvt objDvt = (DmDvt)ComboHelper.GetSelectData(grlDVT);
                m_obj_CCDC.DvtId = objDvt.Id;
                m_obj_CCDC.TenDvt = objDvt.TenDvt;
                m_obj_CCDC.MaDvt = objDvt.MaDvt;
            }

            if (!VnsCheck.IsNullGuid(grlBoPhanSd.EditValue))
            {
                DmPhongban objPhongban = (DmPhongban)ComboHelper.GetSelectData(grlBoPhanSd);
                m_obj_CCDC.PhongbanId = objPhongban.Id;
                m_obj_CCDC.TenPhongban = objPhongban.TenPhongban;
                m_obj_CCDC.MaPhongban = objPhongban.MaPhongban;
            }

            //SqlDateTime getDate = default(SqlDateTime);
            //getDate = SqlDateTime.Null;

            m_obj_CCDC.MdTkCcdc = C_filter_TKCC.ListEditValue[1];
            m_obj_CCDC.MdTkChiphi = C_filter_TKCP.ListEditValue[1];
            m_obj_CCDC.MdTkPhanbo = C_filter_TKPB.ListEditValue[1];
            m_obj_CCDC.SoKyPhanbo = VnsConvert.CDecimal(txtSoKyPb.Text);
            m_obj_CCDC.LoaiPhanbo = (decimal)grlKieuPb.EditValue;
            m_obj_CCDC.TenLoaiPhanbo = grlKieuPb.Text;
            m_obj_CCDC.NgayBdpb = dteNgayBDSD.DateTime;
            m_obj_CCDC.NgayBdsd = dteNgayBDSD.DateTime;
            m_obj_CCDC.NgayMua = dteNgayBDSD.DateTime;
            m_obj_CCDC.NgayKtpb = Null.MIN_SQL_DATE;
            m_obj_CCDC.NgayGiam = Null.MIN_SQL_DATE;
            m_obj_CCDC.NguyenGia = VnsConvert.CDecimal(txtNguyenGia.Text);
            m_obj_CCDC.GiaTriCl = VnsConvert.CDecimal(txtGTCL.Text);
            m_obj_CCDC.Nhom1 = VnsConvert.CGuid(grlNhom1.EditValue);
            m_obj_CCDC.Nhom2 = VnsConvert.CGuid(grlNhom2.EditValue);
            m_obj_CCDC.Nhom3 = VnsConvert.CGuid(grlNhom3.EditValue);
            m_obj_CCDC.DonviId = Generals.DON_VI.Id;
            m_obj_CCDC.MaDonvi = Generals.DON_VI.MaDonvi;
            m_obj_CCDC.NuocSx = txtNuocSx.Text;
            m_obj_CCDC.NgayTang = dteNgayBDSD.DateTime;

            if (!string.IsNullOrEmpty(txtNamSx.Text))
            {
                m_obj_CCDC.NamSx = VnsConvert.CDecimal(txtNamSx.Text);
            }
            m_obj_CCDC.ThongsoKythuat = txtTskt.Text;
            //CT_CCDC
            if (m_Obj_CCDC_CT == null)
            {
                m_Obj_CCDC_CT = new CcCtCcdc();
            }

            m_Obj_CCDC_CT.MaCcdc = m_obj_CCDC.MaCcdc;
            m_Obj_CCDC_CT.TenCcdc = m_obj_CCDC.TenCcdc;
            m_Obj_CCDC_CT.NuocSx = m_obj_CCDC.NuocSx;
            m_Obj_CCDC_CT.NamSx = m_obj_CCDC.NamSx;
            m_Obj_CCDC_CT.ThongsoKythuat = m_obj_CCDC.ThongsoKythuat;
            m_Obj_CCDC_CT.NgayMua = m_obj_CCDC.NgayMua;
            m_Obj_CCDC_CT.NgayBdsd = m_obj_CCDC.NgayBdsd;
            m_Obj_CCDC_CT.NgayBdpb = m_obj_CCDC.NgayBdpb;
            m_Obj_CCDC_CT.NgayKtpb = m_obj_CCDC.NgayKtpb;
            m_Obj_CCDC_CT.NgayGiam = m_obj_CCDC.NgayGiam;
            m_Obj_CCDC_CT.NgayTang = m_obj_CCDC.NgayTang;
            m_Obj_CCDC_CT.SoKyPhanbo = m_obj_CCDC.SoKyPhanbo;
            m_Obj_CCDC_CT.SoTienDaPhanbo = m_obj_CCDC.SoTienDaPhanbo;
            m_Obj_CCDC_CT.GiaTriCl = m_obj_CCDC.GiaTriCl;
            m_Obj_CCDC_CT.PhongbanId = m_obj_CCDC.PhongbanId;
            m_Obj_CCDC_CT.MaPhongban = m_obj_CCDC.MaPhongban;
            m_Obj_CCDC_CT.TenPhongban = m_obj_CCDC.TenPhongban;
            m_Obj_CCDC_CT.TenLoaiPhanbo = m_obj_CCDC.TenLoaiPhanbo;
            m_Obj_CCDC_CT.DvtId = m_obj_CCDC.DvtId;
            m_Obj_CCDC_CT.MaDvt = m_obj_CCDC.MaDvt;
            m_Obj_CCDC_CT.TenDvt = m_obj_CCDC.TenDvt;
            m_Obj_CCDC_CT.DonviId = Generals.DON_VI.Id;
            m_Obj_CCDC_CT.MaDonvi = Generals.DON_VI.MaDonvi;
            m_Obj_CCDC_CT.MdTkCcdc = m_obj_CCDC.MdTkCcdc;
            m_Obj_CCDC_CT.MdTkChiphi = m_obj_CCDC.MdTkChiphi;
            m_Obj_CCDC_CT.MdTkPhanbo = m_obj_CCDC.MdTkPhanbo;
            m_Obj_CCDC_CT.Nhom1 = m_obj_CCDC.Nhom1;
            m_Obj_CCDC_CT.Nhom2 = m_obj_CCDC.Nhom2;
            m_Obj_CCDC_CT.Nhom3 = m_obj_CCDC.Nhom3;
            m_Obj_CCDC_CT.SoLuong = m_obj_CCDC.SoLuong;
            m_Obj_CCDC_CT.NguyenGia = m_obj_CCDC.NguyenGia;
            m_Obj_CCDC_CT.ThuTu = 1;

            _CcDmCcdcService.SaveCCDC(bInsert, ref m_obj_CCDC, m_Obj_CCDC_CT, m_lstNguonVon, m_lstDelNguonVon);

        }

        private void SetObject()
        {
            //Lay dm_ccdc
            m_obj_CCDC = CcDmCcdcService.GetById(m_CCDC_Id);

            m_MaCcdcOld = m_obj_CCDC.MaCcdc;

            txtMaCC.Text = m_obj_CCDC.MaCcdc;
            txtTenCC.Text = m_obj_CCDC.TenCcdc;
            txtSoLuong.Text = m_obj_CCDC.SoLuong.ToString();
            grlDVT.EditValue = m_obj_CCDC.DvtId;
            grlBoPhanSd.EditValue = m_obj_CCDC.PhongbanId;
            C_filter_TKCC.Tag = ReturnIdTk(m_obj_CCDC.MdTkCcdc);
            C_filter_TKCC.Text = m_obj_CCDC.MdTkCcdc;
            C_filter_TKCP.Tag = ReturnIdTk(m_obj_CCDC.MdTkChiphi);
            C_filter_TKCP.Text = m_obj_CCDC.MdTkChiphi;
            C_filter_TKPB.Tag = ReturnIdTk(m_obj_CCDC.MdTkPhanbo);
            C_filter_TKPB.Text = m_obj_CCDC.MdTkPhanbo;
            txtSoKyPb.Text = m_obj_CCDC.SoKyPhanbo.ToString();
            grlKieuPb.EditValue = m_obj_CCDC.LoaiPhanbo;
            dteNgayBDSD.DateTime = m_obj_CCDC.NgayBdpb;
            txtNguyenGia.Text = m_obj_CCDC.NguyenGia.ToString();
            txtGTCL.EditValue = m_obj_CCDC.GiaTriCl;
            grlNhom1.EditValue = m_obj_CCDC.Nhom1;
            grlNhom2.EditValue = m_obj_CCDC.Nhom2;
            grlNhom3.EditValue = m_obj_CCDC.Nhom3;
            txtNuocSx.Text = m_obj_CCDC.NuocSx;
            if (m_obj_CCDC.NamSx != 0)
            {
                txtNamSx.EditValue = m_obj_CCDC.NamSx;
            }
            txtTskt.Text = m_obj_CCDC.ThongsoKythuat;
            //CT_CCDC
            m_Obj_CCDC_CT = _CcCtCcdcService.GetByCCDCId(m_CCDC_Id)[0];

            //NV_CCDC
            m_lstNguonVon = new List<CcCtCcdcNvon>();
            m_lstNguonVon.AddRange(CcCtCcdcNvonService.GetAll());
            grcNGUON_VON.DataSource = m_lstNguonVon;
        }

        private bool Check_input()
        {
            if (string.IsNullOrEmpty(txtMaCC.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập mã CCDC");
                txtMaCC.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenCC.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập tên CCDC");
                txtTenCC.Focus();
                return false;
            }

            if (VnsConvert.CDecimal(txtSoLuong.Text) == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa nhập số lượng CCDC");
                txtTenCC.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(C_filter_TKCC.Tag.ToString()))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập tài khoản công cụ");
                C_filter_TKCC.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(C_filter_TKCP.Tag.ToString()))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập tài khoản chi phí");
                C_filter_TKCP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(C_filter_TKPB.Tag.ToString()))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập tài khoản phân bổ");
                C_filter_TKPB.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSoKyPb.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập số kỳ Pb");
                txtSoKyPb.Focus();
                return false;
            }

            if (grlKieuPb.EditValue == null)
            {
                FormGlobals.Message_Warning("Bạn chưa chọn kiểu Pb");
                grlKieuPb.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dteNgayBDSD.Text) | VnsCheck.IsNullDate(dteNgayBDSD.DateTime))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập bắt đầu phân bổ ccdc");
                dteNgayBDSD.Focus();
                return false;
            }

            if (VnsConvert.CDecimal(txtNguyenGia.Text) == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa nhập nguyên giá");
                txtNguyenGia.Focus();
                return false;
            }

            if (VnsConvert.CDecimal(txtGTCL.Text) == 0)
            {
                FormGlobals.Message_Warning("Bạn chưa nhập giá trị còn lại");
                txtGTCL.Focus();
                return false;
            }

            if (VnsConvert.CDecimal(txtNguyenGia.Text) < VnsConvert.CDecimal(txtGTCL.Text))
            {
                FormGlobals.Message_Warning("Giá trị nguyên giá phải lớn hơn hoặc bằng giá trị còn lại");
                txtNguyenGia.Focus();
                return false;
            }

            return true;
        }

        private bool CheckInputNguonVon()
        {
            decimal he_so = 0;
            List<CcCtCcdcNvon> lstNguonVonTemp = new List<CcCtCcdcNvon>();
            lstNguonVonTemp.AddRange((List<CcCtCcdcNvon>)grvNGUON_VON.DataSource);
            if ((lstNguonVonTemp.Count != 0))
            {

                foreach (CcCtCcdcNvon drv in lstNguonVonTemp)
                {
                    if ((drv.DmNguonTscdId == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa chọn nguồn cho nguồn vốn");
                        return false;
                    }

                    if ((drv.TkChiphi == Null.NullGuid))
                    {
                        FormGlobals.Message_Warning("Bạn chưa nhập tài khoản chi phí cho nguồn vốn");
                        return false;
                    }

                    if (drv.HeSoPbKh < 0)
                    {
                        FormGlobals.Message_Warning("Hệ số phải lớn hơn 0");
                        return false;
                    }
                    else
                    {
                        he_so = he_so + drv.HeSoPbKh;
                    }

                    if (string.IsNullOrEmpty(drv.MaTkChiphi))
                    {
                        FormGlobals.Message_Warning("Tài khoản chi phí không được để trống");
                        return false;
                    }
                }

                if ((he_so != 100))
                {
                    FormGlobals.Message_Warning("Tổng hệ số phân bổ của nguồn vốn phải bằng 100%");
                    return false;
                }
            }

            return true;
        }

        private bool CheckMaCcdc(string MaOld, string MaNew)
        {
            string Ma_temp = "";
            if (m_InputState == FormGlobals.DataInputState.AddMode)
            {
                Ma_temp = MaNew.ToUpper();
            }
            else
            {
                if (MaOld.ToUpper().Equals(MaNew.ToUpper()))
                {
                    return true;
                }
                else
                {
                    Ma_temp = MaNew;
                }
            }

            List<CcDmCcdc> lstByMa = new List<CcDmCcdc>();
            lstByMa.AddRange(CcDmCcdcService.GetByMaCCDC(Ma_temp));
            if (lstByMa.Count > 0)
            {
                return false;
            }
            return true;
        }

        private void Grid_AddNewRow()
        {
            if (m_lstNguonVon == null)
            {
                m_lstNguonVon = new List<CcCtCcdcNvon>();
            }
            CcCtCcdcNvon objNV = new CcCtCcdcNvon();
            objNV.TkCcdc = VnsConvert.CGuid(C_filter_TKCC.ListEditValue[0]);
            objNV.MaTkCcdc = C_filter_TKCC.ListEditValue[1];
            objNV.TkChiphi = VnsConvert.CGuid(C_filter_TKCP.ListEditValue[0]);
            objNV.MaTkChiphi = C_filter_TKCP.ListEditValue[1];

            objNV.TkPhanbo = VnsConvert.CGuid(C_filter_TKPB.ListEditValue[0]);
            objNV.MaTkPhanbo = C_filter_TKPB.ListEditValue[1];

            m_lstNguonVon.Add(objNV);
            grvNGUON_VON.RefreshData();

        }

        private void Grid_DelRow()
        {
            if (grvNGUON_VON.RowCount != 0)
            {
                if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa?"))
                {
                    CcCtCcdcNvon delnv = (CcCtCcdcNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                    m_lstDelNguonVon.Add(delnv);
                    FormGlobals.Grid_DeleteSelectRows(grvNGUON_VON);
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
            }
        }

        private void SetFocusAfterAddRow()
        {
            if (grvNGUON_VON.RowCount > 0)
            {
                grvNGUON_VON.FocusedRowHandle = grvNGUON_VON.RowCount - 1;
                grvNGUON_VON.FocusedColumn = grvNGUON_VON.VisibleColumns[0];
            }
        }

        private Guid ReturnIdTk(string matk)
        {
            foreach (DmTaikhoan obj in lstTaiKhoan)
            {
                if (obj.MaTaikhoan.Equals(matk))
                {
                    return obj.Id;
                }
            }

            return Null.NullGuid;
        }

        #endregion

        #region "Events"

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!Check_input())
                {
                    return;
                }

                if (!CheckInputNguonVon())
                {
                    return;
                }

                if (!CheckMaCcdc(m_MaCcdcOld, txtMaCC.Text))
                {
                    FormGlobals.Message_Warning("Mã Ccdc đã tồn tại");
                    txtMaCC.Focus();
                    return;
                }

                frmProgress.Instance().Thread = GetObject;
                frmProgress.Instance().Show_Progress();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnQuit_Click(System.Object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmKhaiBaoCCDC_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F4:
                        Grid_AddNewRow();
                        SetFocusAfterAddRow();
                        break;
                    case Keys.F8:
                        Grid_DelRow();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvNGUON_VON_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if ((GridHelper.CheckAddNewRow(grvNGUON_VON)))
                    {
                        Grid_AddNewRow();
                        SetFocusAfterAddRow();
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        #region "CustomFilter"

        private void C_filter_TKCC_AfterFilter(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKCC.Tag = C_filter_TKCC.ListEditValue[0];

                if ((grvNGUON_VON.RowCount != 0))
                {
                    List<CcCtCcdcNvon> dv = (List<CcCtCcdcNvon>)grvNGUON_VON.DataSource;
                    foreach (CcCtCcdcNvon drv in dv)
                    {
                        drv.TkCcdc = VnsConvert.CGuid(C_filter_TKCC.ListEditValue[0]);
                        drv.MaTkCcdc = C_filter_TKCC.ListEditValue[0];
                    }
                    grvNGUON_VON.RefreshData();
                }

                if (C_filter_TKCC.IsNotTextChanged)
                    SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKCC_FirstBinddata(System.Object sender, System.EventArgs e)
        {
            try
            {
                DataTable Ds = DataHelper.ToDataTable(lstTaiKhoan);
                C_filter_TKCC.C_DATA_SOURCE = Ds;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKCC_ClearFilterData(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKCC.Tag = C_filter_TKCC.ListEditValue[0];
                C_filter_TKCC.Text = C_filter_TKCC.ListEditValue[2];
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKPB_AfterFilter(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKPB.Tag = C_filter_TKPB.ListEditValue[0];
                if ((grvNGUON_VON.RowCount != 0))
                {
                    List<CcCtCcdcNvon> dv = (List<CcCtCcdcNvon>)grvNGUON_VON.DataSource;
                    foreach (CcCtCcdcNvon drv in dv)
                    {
                        drv.TkPhanbo = VnsConvert.CGuid(C_filter_TKPB.ListEditValue[0]);
                        drv.MaTkPhanbo = C_filter_TKPB.ListEditValue[1];
                    }
                    grvNGUON_VON.RefreshData();
                }
                if (C_filter_TKPB.IsNotTextChanged)
                    SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKPB_ClearFilterData(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKPB.Tag = C_filter_TKCC.ListEditValue[0];
                C_filter_TKPB.Text = C_filter_TKCC.ListEditValue[2];
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKPB_FirstBinddata(System.Object sender, System.EventArgs e)
        {
            try
            {
                DataTable Ds = DataHelper.ToDataTable(lstTaiKhoan);
                C_filter_TKPB.C_DATA_SOURCE = Ds;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKCP_AfterFilter(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKCP.Tag = C_filter_TKCP.ListEditValue[0];
                if ((grvNGUON_VON.RowCount != 0))
                {
                    List<CcCtCcdcNvon> dv = (List<CcCtCcdcNvon>)grvNGUON_VON.DataSource;
                    foreach (CcCtCcdcNvon drv in dv)
                    {
                        drv.TkChiphi = VnsConvert.CGuid(C_filter_TKCP.ListEditValue[0]);
                        drv.MaTkChiphi = C_filter_TKCP.ListEditValue[1];
                    }
                    grvNGUON_VON.RefreshData();
                }
                if (C_filter_TKCP.IsNotTextChanged)
                    SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKCP_FirstBinddata(System.Object sender, System.EventArgs e)
        {
            try
            {
                DataTable Ds = DataHelper.ToDataTable(lstTaiKhoan);
                C_filter_TKCP.C_DATA_SOURCE = Ds;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void C_filter_TKCP_ClearFilterData(System.Object sender, System.EventArgs e)
        {
            try
            {
                C_filter_TKCP.Tag = C_filter_TKCC.ListEditValue[0];
                C_filter_TKCP.Text = C_filter_TKCC.ListEditValue[2];
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpTkCP_AfterFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                CcCtCcdcNvon dr_grv_NGUONVON = (CcCtCcdcNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                int rowHandle = grvNGUON_VON.FocusedRowHandle;
                string columnName = grvNGUON_VON.FocusedColumn.Name;
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                switch (columnName)
                {
                    case "MaTkChiphi":
                        List<string> arr = rpTkCP.OwnerEdit.A_LIST_VALUES;
                        grvNGUON_VON.BeginDataUpdate();
                        if ((arr.Count > 1))
                        {
                            dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(arr[0]);
                            dr_grv_NGUONVON.MaTkChiphi = arr[1];
                            grvNGUON_VON.SetRowCellValue(rowHandle, "MaTkChiphi", arr[1]);
                        }
                        grvNGUON_VON.EndDataUpdate();
                        break;
                }
                SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpTkCP_ClearDataFilter(System.Object senders, System.EventArgs e)
        {
            try
            {
                CcCtCcdcNvon dr_grv_NGUONVON = (CcCtCcdcNvon)grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle);
                int rowHandle = grvNGUON_VON.FocusedRowHandle;
                if (dr_grv_NGUONVON == null)
                {
                    return;
                }
                if (rpTkCP.OwnerEdit.A_LIST_VALUES.Count != 0)
                {
                    rpTkCP.Tag = rpTkCP.OwnerEdit.A_LIST_VALUES[0];
                    dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpTkCP.OwnerEdit.A_LIST_VALUES[0]);
                    dr_grv_NGUONVON.MaTkChiphi = rpTkCP.OwnerEdit.A_LIST_VALUES[1];
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void rpTkCP_FisrtBinddata(System.Object senders, System.EventArgs e)
        {
            try
            {
                rpTkCP.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(lstTaiKhoan);
                rpTkCP.Editors.A_DATA_SOURCE = rpTkCP.C_DATA_SOURCE;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion

    }
}