using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;

using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Asset.Domain;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoGiamCCDC_ChiTiet
    {

        #region "properties"

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


        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }

        #endregion

        #region "Variables"
        private FormGlobals.DataInputState m_InputState;
        private Guid m_CT_CCDC_Id;
        private CcCtCcdc m_Obj_CCDC_CT;
        private bool IsInsert = false;
        #endregion
        private bool m_OnLoadData = false;

        #region "Show_form"
        private void AddEvents()
        {
            btnSave.Click +=new EventHandler(btnSave_Click);
            grlMaCCDC.EditValueChanged +=new EventHandler(grlMaCCDC_EditValueChanged);
            btnQuit.Click +=new EventHandler(btnQuit_Click);
        }

        public frmKhaiBaoGiamCCDC_ChiTiet()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        public CcCtCcdc Show_Form(Guid p_CT_CCDC_Id, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_CT_CCDC_Id = p_CT_CCDC_Id;
                m_InputState = eState;
                // Me.ActiveControl = txtMaCC
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            if ((this.ShowDialog() == DialogResult.OK))
            {
                return m_Obj_CCDC_CT;
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
            m_OnLoadData = true;
            BindDataToCbo();
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:

                    break;
                case FormGlobals.DataInputState.EditMode:
                    SetObject();
                    break;
            }
            m_OnLoadData = false;
        }

        private void BindDataToCbo()
        {
            //'bind ly do tang giam ccdc
            List<DmLydoTgTscd> _lstLydo = new List<DmLydoTgTscd>();
            _lstLydo.Add(new DmLydoTgTscd());
            _lstLydo.AddRange(DmLydoTgTscdService.GetAllAllByLoai(4, Generals.DON_VI.Id));
            grlMaGiam.Properties.DataSource = _lstLydo;
            grlMaGiam.Properties.ValueMember = "Id";
            grlMaGiam.Properties.DisplayMember = "TenLydoTgTscd";

            //'Bind Dmtscd
            List<CcDmCcdc> _lstDmCcdc = new List<CcDmCcdc>();
            _lstDmCcdc.Add(new CcDmCcdc());
            _lstDmCcdc.AddRange(CcDmCcdcService.GetAllByDonviID(Generals.DON_VI.Id));
            grlMaCCDC.Properties.DataSource = _lstDmCcdc;
            grlMaCCDC.Properties.ValueMember = "Id";
            grlMaCCDC.Properties.DisplayMember = "MaCcdc";
        }

        private void GetObject()
        {
            if (m_Obj_CCDC_CT == null)
            {
                m_Obj_CCDC_CT = new CcCtCcdc();
            }

            CcDmCcdc obj_CCDC = (CcDmCcdc)ComboHelper.GetSelectData(grlMaCCDC);
            m_Obj_CCDC_CT.CcdcId = obj_CCDC.Id;
            m_Obj_CCDC_CT.MaCcdc = obj_CCDC.MaCcdc;
            m_Obj_CCDC_CT.TenCcdc = obj_CCDC.TenCcdc;
            m_Obj_CCDC_CT.NuocSx = obj_CCDC.NuocSx;
            m_Obj_CCDC_CT.NamSx = obj_CCDC.NamSx;
            m_Obj_CCDC_CT.ThongsoKythuat = obj_CCDC.ThongsoKythuat;
            m_Obj_CCDC_CT.NgayMua = obj_CCDC.NgayMua;
            m_Obj_CCDC_CT.NgayBdsd = obj_CCDC.NgayBdsd;
            m_Obj_CCDC_CT.NgayBdpb = obj_CCDC.NgayBdpb;
            m_Obj_CCDC_CT.NgayKtpb = obj_CCDC.NgayKtpb;
            m_Obj_CCDC_CT.NgayGiam = obj_CCDC.NgayGiam;
            m_Obj_CCDC_CT.NgayTang = obj_CCDC.NgayTang;
            m_Obj_CCDC_CT.SoKyPhanbo = obj_CCDC.SoKyPhanbo;
            m_Obj_CCDC_CT.SoTienDaPhanbo = obj_CCDC.SoTienDaPhanbo;
            m_Obj_CCDC_CT.GiaTriCl = obj_CCDC.GiaTriCl;
            m_Obj_CCDC_CT.PhongbanId = obj_CCDC.PhongbanId;
            m_Obj_CCDC_CT.MaPhongban = obj_CCDC.MaPhongban;
            m_Obj_CCDC_CT.TenPhongban = obj_CCDC.TenPhongban;
            m_Obj_CCDC_CT.TenLoaiPhanbo = obj_CCDC.TenLoaiPhanbo;
            m_Obj_CCDC_CT.DvtId = obj_CCDC.DvtId;
            m_Obj_CCDC_CT.MaDvt = obj_CCDC.MaDvt;
            m_Obj_CCDC_CT.TenDvt = obj_CCDC.TenDvt;
            m_Obj_CCDC_CT.DonviId = Generals.DON_VI.Id;
            m_Obj_CCDC_CT.MaDonvi = Generals.DON_VI.MaDonvi;
            m_Obj_CCDC_CT.MdTkCcdc = obj_CCDC.MdTkCcdc;
            m_Obj_CCDC_CT.MdTkChiphi = obj_CCDC.MdTkChiphi;
            m_Obj_CCDC_CT.MdTkPhanbo = obj_CCDC.MdTkPhanbo;
            m_Obj_CCDC_CT.Nhom1 = obj_CCDC.Nhom1;
            m_Obj_CCDC_CT.Nhom2 = obj_CCDC.Nhom2;
            m_Obj_CCDC_CT.Nhom3 = obj_CCDC.Nhom3;
            m_Obj_CCDC_CT.SoLuong = obj_CCDC.SoLuong;
            m_Obj_CCDC_CT.NguyenGia = obj_CCDC.NguyenGia;


            m_Obj_CCDC_CT.ThuTu = 1;
            m_Obj_CCDC_CT.GiamCcdc = 2;
            DmLydoTgTscd obj_Lydo = (DmLydoTgTscd)ComboHelper.GetSelectData(grlMaGiam);
            m_Obj_CCDC_CT.LyDoTangGiamId = obj_Lydo.Id;
            m_Obj_CCDC_CT.TenLyDoTangGiam = obj_Lydo.TenLydoTgTscd;
            m_Obj_CCDC_CT.GhiChu = txtGhiChu.Text;
            m_Obj_CCDC_CT.NgayKtpb = dteNgayHetPb.DateTime;
            m_Obj_CCDC_CT.SoCt = txtSoCt.Text;
            m_Obj_CCDC_CT.NgayGiam = dteNgayGiam.DateTime;

            obj_CCDC.GiamCcdc = 1;

            //Save or update 
            CcDmCcdcService.SaveKhaiBaoGiam(IsInsert, obj_CCDC, m_Obj_CCDC_CT);

        }

        private void SetObject()
        {
            m_Obj_CCDC_CT = CcCtCcdcService.GetById(m_CT_CCDC_Id);

            grlMaCCDC.EditValue = m_Obj_CCDC_CT.CcdcId;
            grlMaGiam.EditValue = m_Obj_CCDC_CT.LyDoTangGiamId;
            dteNgayGiam.DateTime = m_Obj_CCDC_CT.NgayGiam;
            dteNgayHetPb.DateTime = m_Obj_CCDC_CT.NgayKtpb;
            txtSoCt.Text = m_Obj_CCDC_CT.SoCt;
            txtGhiChu.Text = m_Obj_CCDC_CT.GhiChu;
        }

        private bool Check_input()
        {
            if (grlMaCCDC.EditValue == null)
            {
                FormGlobals.Message_Warning("Bạn chưa chọn CCDC cần khai báo giảm");
                grlMaCCDC.Focus();
                return false;
            }

            if (grlMaGiam.EditValue == null)
            {
                FormGlobals.Message_Warning("Bạn chưa chọn mã giảm");
                grlMaGiam.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dteNgayGiam.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa chọn ngày giảm");
                dteNgayGiam.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dteNgayHetPb.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa chọn kết thúc phân bổ");
                dteNgayHetPb.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSoCt.Text))
            {
                FormGlobals.Message_Warning("Bạn chưa nhập ngày ct");
                txtSoCt.Focus();
                return false;
            }

            return true;
        }

        private object GetCTId(Guid p_CcdcId)
        {
            Guid ccCtId = new Guid();
            IList<CcCtCcdc> lst = CcCtCcdcService.GetByCcDcId_TrangThai(p_CcdcId, 2);
            if (lst.Count > 0)
            {
                ccCtId = lst[0].Id;
            }
            return ccCtId;
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

                frmProgress.Instance().Thread = GetObject;
                frmProgress.Instance().Show_Progress();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlMaCCDC_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (m_OnLoadData)
                {
                    return;
                }
                CcDmCcdc obj_CCDC = (CcDmCcdc)ComboHelper.GetSelectData(grlMaCCDC);
                if (obj_CCDC.GiamCcdc == 1)
                {
                    //m_CT_CCDC_Id = obj_CCDC.Id
                    //Ly id ccdc_ct
                    m_CT_CCDC_Id = VnsConvert.CGuid(GetCTId(obj_CCDC.Id));
                    SetObject();
                    IsInsert = false;
                }
                else
                {
                    IsInsert = true;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnQuit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}