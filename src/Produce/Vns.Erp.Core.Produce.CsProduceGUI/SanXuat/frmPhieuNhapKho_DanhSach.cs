using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;

using Vns.Erp.Core;
using System.Windows.Forms;
using Vns.Erp.Core.Accounting.Domain.Extend;
using static Vns.Erp.Core.Common.Controls.PagerControl;
//using Vns.Erp.Core.Common.Controls.PagerControl;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmPhieuNhapKho_DanhSach
    {

        #region "Property"
        private IHtLoaichungtuService _HtLoaichungtuService;
        public IHtLoaichungtuService HtLoaichungtuService
        {
            get { return _HtLoaichungtuService; }
            set { _HtLoaichungtuService = value; }
        }
        private ICtHNxService _CtHNxService;
        public ICtHNxService CtHNxService
        {
            get { return _CtHNxService; }
            set { _CtHNxService = value; }
        }

        private ICtDNxService _CtDNxService;
        public ICtDNxService CtDNxService
        {
            get { return _CtDNxService; }
            set { _CtDNxService = value; }
        }

        private IDmKhoService _DmKhoService;
        public IDmKhoService DmKhoService
        {
            get { return _DmKhoService; }
            set { _DmKhoService = value; }
        }
        #endregion

        #region "Variables and Messages"

        /// <summary>
        /// khao bao bien chua ID dung de load du lieu cho bang duoi theo ID bang tren
        /// </summary>
        /// <remarks></remarks>

        Guid CTHNXID;
        /// <summary>
        /// khai bao 1 bien chua ID de truyen sang form chi tiet de xu ly
        /// </summary>
        /// <remarks></remarks>

        Guid mCTHNXID;
        /// <summary>
        /// khai bao 1 list obj de luu data
        /// </summary>
        /// <remarks></remarks>

        public List<CtHNx> lstobj_ct_h_nx;
        /// <summary>
        /// khai bao 1 obj dung de chua cac thong tin cua loai chung tu truyen tu mennu
        /// </summary>
        /// <remarks></remarks>
        public HtLoaichungtu obj_loaichungtu = new HtLoaichungtu();
        //
        int SO_CT_HIENTHI;
        //

        private string FormID;
        #endregion

        #region "Load form"

        /// <summary>
        /// load data cho form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmPhieuNhapKho_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                LoadData();

                CtlPagerControl.display = new DisplayResult(this.LoadGrid);
                CtlPagerControl.RefreshPage();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        #region "Private Function and Procedures"
        IList<CtHNx> phieukhoData = new List<CtHNx>();

        private void LoadData()
        {
            //InitializeComponent();
            TNCommon.setIconControl(this);

            grvLPX_Hnx.Columns["Ghi"].Visible = Generals.Ts_PheDuyetChungTu;
            string para_str = this.AccessibleDescription;
            List<ParamInfo> lst_para = DataMining.GetParams(para_str);
            //
            if (lst_para.Count > 0)
            {
                obj_loaichungtu.MaLoaiCt = lst_para[0].PARAMVALUE;
            }
            //
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id);
            if (obj_loaichungtu != null)
            {
                if (obj_loaichungtu.SoCtHienthi == 0)
                {
                    SO_CT_HIENTHI = int.MinValue;
                }
                else
                {
                    SO_CT_HIENTHI = Convert.ToInt32(obj_loaichungtu.SoCtHienthi);
                }
            }
            this.Text = obj_loaichungtu.TenLoaiCt;
        }

        private void LoadGrid()
        {
            int totalresult = 0;

            phieukhoData = _CtHNxService.GetByLoaiChungTu(CtlPagerControl.PageIndex, CtlPagerControl.PageSize,
                Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, -1,
                out totalresult);
            CtlPagerControl.TotalResult = totalresult;

            // load du lieu len grid
            grvLPX_Hnx.GridControl.DataSource = phieukhoData;

            if (grvLPX_Hnx.RowCount != 0)
            {
                btnMod.Enabled = true;
            }
            else
            {
                btnMod.Enabled = false;
            }
            //
            LoadGridConfig();

        }


        private void LoadGRV(Guid CTH_XN_ID)
        {
            List<CtDNx> lstobj_ct_d_nx = new List<CtDNx>();
            lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(CTH_XN_ID));
            grcLPN_Dnx.DataSource = lstobj_ct_d_nx;

            List<DmKho> lstKhoNhap = new List<DmKho>();
            lstKhoNhap.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id));
            cboKhoNhap1.DataSource = lstKhoNhap;
            cboKhoNhap1.DisplayMember = "KyHieu";
            cboKhoNhap1.ValueMember = "Id";

            List<DmKho> lstKhoXuat = new List<DmKho>();
            lstKhoXuat.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id));
            cboKhoXuat1.DataSource = lstKhoXuat;
            cboKhoXuat1.DisplayMember = "KyHieu";
            cboKhoXuat1.ValueMember = "Id";

            if (obj_loaichungtu.KhoXuat == 1)
            {
                grvLPN_Dnx.Columns["KhoXuatId"].Visible = true;
                grvLPN_Dnx.Columns["KhoNhapId"].Visible = false;
            }
            else
            {
                grvLPN_Dnx.Columns["KhoXuatId"].Visible = false;
                grvLPN_Dnx.Columns["KhoNhapId"].Visible = true;
            }
        }

        /// <summary>
        /// lay duoc ID row hien tai (chua su dung)
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool GetRowSelect()
        {
            int selrow = 0;
            if ((grvLPX_Hnx.GetSelectedRows().Length > 0))
            {
                if ((grvLPX_Hnx.RowCount != 0))
                {
                    CtHNx grtCTH_NX = (CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows()[0]);
                    mCTHNXID = grtCTH_NX.Id;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// load config
        /// </summary>
        /// <remarks></remarks>

        private void LoadGridConfig()
        {
            FormID = this.Name + "?" + this.AccessibleDescription;
            ConfigGrid.GridConfig(FormID, grvLPX_Hnx.Name, grvLPX_Hnx);
            ConfigGrid.GridConfig(FormID, grvLPN_Dnx.Name, grvLPN_Dnx);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnCreate_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Create();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        private void Create()
        {
            frmPhieuNhapKho_ChiTiet f = (frmPhieuNhapKho_ChiTiet)ObjectFactory.GetObject("Produce.frmPhieuNhapKho_ChiTiet");
            f.obj_lct.MaLoaiCt = obj_loaichungtu.MaLoaiCt;
            f.obj_lct = obj_loaichungtu;
            List<CT_H_GInfo> lstCTHG = Vns.Erp.Core.Controls.Commons.DataAccHelper.ConvertToCTHG(phieukhoData);
            if (f.Show_Form(Null.NullGuid, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, Vns.Erp.Core.FormGlobals.DataInputState.AddMode))
            {
                this.LoadGrid();
                if (grvLPX_Hnx.RowCount > 0)
                {
                    CtHNx tmp = (CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle);
                    if (tmp == null)
                        tmp = new CtHNx();
                    CTHNXID = tmp.Id;
                    this.LoadGRV(CTHNXID);
                }
            }
        }

        private void btnModify_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void Edit()
        {
            if ((grvLPX_Hnx.RowCount != 0))
            {
                CTHNXID = ((CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle)).Id;
                frmPhieuNhapKho_ChiTiet f = (frmPhieuNhapKho_ChiTiet)ObjectFactory.GetObject("Produce.frmPhieuNhapKho_ChiTiet");
                f.obj_lct = obj_loaichungtu;
                f.obj_lct.MaLoaiCt = obj_loaichungtu.MaLoaiCt;
                //Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(CT_H_NxBO.Instance.GetObjectAllByLoaiChungTu(Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt))
                List<CT_H_GInfo> lstCTHG = Vns.Erp.Core.Controls.Commons.DataAccHelper.ConvertToCTHG(phieukhoData);
                if (f.Show_Form(CTHNXID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, Vns.Erp.Core.FormGlobals.DataInputState.EditMode))
                {
                    this.LoadGrid();
                    if (grvLPX_Hnx.RowCount > 0)
                    {
                        CtHNx tmp = (CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle);
                        if (tmp == null)
                            tmp = new CtHNx();
                        CTHNXID = tmp.Id;
                        this.LoadGRV(CTHNXID);
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnClo_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        #region "Events"

        private void grvLPX_Hnx_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CtHNx tmp = (CtHNx)grvLPX_Hnx.GetRow(e.FocusedRowHandle);
                if (tmp == null)
                {
                    tmp = new CtHNx();
                }
                CTHNXID = tmp.Id;
                LoadGRV(CTHNXID);
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmPhieuNhapKho_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select

                    case Keys.F3:
                        Create();
                        break; // TODO: might not be correct. Was : Exit Select

                    case Keys.F4:
                        Edit();
                        break; // TODO: might not be correct. Was : Exit Select

                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// Cau hinh grid view tren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void grvLPX_Hnx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F12)
                {
                    List<ColInfo> lstColInfo = new List<ColInfo>();
                    ConfigGrid.GetGridColInfo(grvLPX_Hnx, lstColInfo);
                    ConfigGrid f = new ConfigGrid();
                    if (f.Show_Form(grvLPX_Hnx.Name, FormID, lstColInfo))
                    {
                        ConfigGrid.GridConfig(FormID, grvLPX_Hnx.Name, grvLPX_Hnx);
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

        }

        /// <summary>
        /// Cau hinh grid view duoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void grvLPN_Dnx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F12)
                {
                    List<ColInfo> lstColInfo = new List<ColInfo>();
                    ConfigGrid.GetGridColInfo(grvLPN_Dnx, lstColInfo);
                    ConfigGrid f = new ConfigGrid();
                    if (f.Show_Form(grvLPN_Dnx.Name, FormID, lstColInfo))
                    {
                        ConfigGrid.GridConfig(FormID, grvLPN_Dnx.Name, grvLPN_Dnx);
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

    }
}
