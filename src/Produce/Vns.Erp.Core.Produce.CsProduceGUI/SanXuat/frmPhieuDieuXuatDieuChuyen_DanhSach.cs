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

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmPhieuDieuXuatDieuChuyen_DanhSach : DevExpress.XtraEditors.XtraForm
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
        /// <summary>
        /// khai bao 1 bien chua ID cua luoi tren
        /// </summary>
        /// <remarks></remarks>
        /// 

        Guid CTHNXID;
        /// <summary>
        /// khai bao 1 bien chua ID dung trong ham getrow
        /// </summary>
        /// <remarks></remarks>

        Guid mCTHNXID;
        /// <summary>
        /// khai bao1 obj chua data chung tu
        /// </summary>
        /// <remarks></remarks>
        public HtLoaichungtu obj_loaichungtu = new HtLoaichungtu();
        //
        int SO_CT_HIENTHI;
        //

        private string FormID;
        #region "Load form"

        /// <summary>
        /// ham xet icon cho cac button
        /// </summary>
        /// <remarks></remarks>
        public frmPhieuDieuXuatDieuChuyen_DanhSach()
        {
            KeyDown += frmPhieuDieuXuatDieuChuyen_DanhSach_KeyDown;
            //Load += frmPhieuDieuXuatDieuChuyen_DanhSach_Load;

            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmPhieuDieuXuatDieuChuyen_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                grvLPX_Hnx.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(grvLPX_Hnx_FocusedRowChanged); 

                grvLPX_Hnx.Columns["Ghi"].Visible = Generals.Ts_PheDuyetChungTu;
                //khai bao cac bien luu ma loai chung tu khi chon tren menu truyen vao
                string para_str = this.AccessibleDescription;
                List<ParamInfo> lst_para = DataMining.GetParams(para_str);
                if (lst_para.Count > 0)
                {
                    //gan ma loai chung tu bang gia tri truyen tu menu
                    obj_loaichungtu.MaLoaiCt = lst_para[0].PARAMVALUE;
                }

                //khai bao 1 obj luu data lay duoc theo ma loai chung tu
                obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id);
                //
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
                //gan ten form theo ten quy dinh trong bang HT loai chung tu
                this.Text = obj_loaichungtu.TenLoaiCt;

                //goi ham xu ly load form
                Load_Grid();
                CtlPagerControl.display = new Vns.Erp.Core.Common.Controls.PagerControl.DisplayResult(Load_Grid);
                CtlPagerControl.RefreshPage();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        IList<CtHNx> phieudieuchuyenData = new List<CtHNx>();
        //Dim phieudieuchuyenData As List(Of CT_H_NxInfo) = New List(Of CT_H_NxInfo)()
        /// <summary>
        /// ham xu ly load form
        /// </summary>
        /// <remarks></remarks>

        private void Load_Grid()
        {
            // Lay thong tin he so nop thue
            int dem = 0;
            phieudieuchuyenData = _CtHNxService.GetByLoaiChungTu(this.CtlPagerControl.PageIndex, this.CtlPagerControl.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, SO_CT_HIENTHI, out dem );
            CtlPagerControl.TotalResult = dem;
            // load du lieu len grid
            FormGlobals.Grid_LoadData(grvLPX_Hnx, phieudieuchuyenData);

            if (grvLPX_Hnx.RowCount != 0)
            {
                btnDel.Enabled = true;
                btnMod.Enabled = true;
            }
            else
            {
                btnDel.Enabled = false;
                btnMod.Enabled = false;
            }
            //
            LoadGridConfig();

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

        private void LoadGRV(Guid CTH_XN_ID)
        {
            // Lay thong tin he so nop thue
            IList<CtDNx> phieuCT_D_NxData = _CtDNxService.GetObjectByCTHId(CTH_XN_ID);
            // load du lieu len grid
            FormGlobals.Grid_LoadData(grvLPN_Dnx, phieuCT_D_NxData);
        }

        private void Create()
        {
            PhieuDieuXuatDieuChuyen f = (PhieuDieuXuatDieuChuyen)ObjectFactory.GetObject("Produce.PhieuDieuXuatDieuChuyen");
            List<CT_H_GInfo> lstCTHG = Vns.Erp.Core.Controls.Commons.DataAccHelper.ConvertToCTHG(phieudieuchuyenData);
            //List<Extend.CT_H_GInfo> lstCTHG = Vns.Erp.Core.Controls.Commons.ConvertToCTHG(phieudieuchuyenData);
            if (f.Show_Form(Null.NullGuid, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, Vns.Erp.Core.FormGlobals.DataInputState.AddMode))
            {
                this.Load_Grid();
                if (grvLPX_Hnx.RowCount > 0)
                {
                    CTHNXID = ((CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle)).Id;
                    this.LoadGRV(CTHNXID);
                }
            }
        }

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

        private void Edit()
        {
            if ((grvLPX_Hnx.RowCount != 0))
            {
                //CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CT_H_NxInfo).CTH_NX_ID
                CTHNXID = ((CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle)).Id;
                PhieuDieuXuatDieuChuyen f = (PhieuDieuXuatDieuChuyen)ObjectFactory.GetObject("Produce.PhieuDieuXuatDieuChuyen");
                //Dim lstCTHG As List(Of CT_H_GInfo) = Commons.ConvertToCTHG(phieudieuchuyenData)
                //List<Extend.CT_H_GInfo> lstCTHG = Commons.ConvertToCTHG(phieudieuchuyenData);
                List<CT_H_GInfo> lstCTHG = Vns.Erp.Core.Controls.Commons.DataAccHelper.ConvertToCTHG(phieudieuchuyenData);
                if (f.Show_Form(CTHNXID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, Vns.Erp.Core.FormGlobals.DataInputState.EditMode))
                {
                    this.Load_Grid();
                    if (grvLPX_Hnx.RowCount > 0)
                    {
                        CTHNXID = ((CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle)).Id;
                        //CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CT_H_NxInfo).CTH_NX_ID
                        this.LoadGRV(CTHNXID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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

        private void grvLPX_Hnx_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CtHNx tmp = (CtHNx)grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle);
                if ((tmp == null))
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

        private void frmPhieuDieuXuatDieuChuyen_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                    case Keys.F3:
                        Create();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                    case Keys.F4:
                        Edit();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
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

    }
}