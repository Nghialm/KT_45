using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmThongTinTSCD_ChiTiet : DevExpress.XtraEditors.XtraForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTSCD_ChiTiet));
            this.xtpMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtpTHONG_TIN_CHINH = new DevExpress.XtraTab.XtraTabPage();
            this.pn_TSCD_1 = new DevExpress.XtraEditors.PanelControl();
            this.dteNGAY_CT = new DevExpress.XtraEditors.DateEdit();
            this.grlNHOM2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlPHONGBAN_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLyDoTang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTKChiPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtSO_CT = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTKKhauHao = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTKTaiSan = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTaiSan = new DevExpress.XtraEditors.TextEdit();
            this.txtKY_HIEU = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.txtMA_TSCD1 = new DevExpress.XtraEditors.TextEdit();
            this.grlLYDO_TANGGIAM = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.grlMD_TK_CHIPHI = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grlDVT_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlMD_TK_KHAUHAO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grlNHOM3 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grlMD_TK_TS = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grlLOAITAISAN_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.grlNHOM1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pn_TSCD_2 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.dteNGAY_TANG1 = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_BDSD1 = new DevExpress.XtraEditors.DateEdit();
            this.dtxNGAY_MUA1 = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_KTKH1 = new DevExpress.XtraEditors.DateEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.dtxNGAY_BDKH1 = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSO_THANG_SD1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.pn_CT_TSCD = new DevExpress.XtraEditors.PanelControl();
            this.txtTY_LE_HAOMON1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.txtGIA_TRI_CL1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGUYEN_GIA1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.txtLAM_TRON_SO = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtSO_LUONG1 = new DevExpress.XtraEditors.TextEdit();
            this.xtpTHONG_TIN_BO_XUNG = new DevExpress.XtraTab.XtraTabPage();
            this.grc_PTKT = new DevExpress.XtraEditors.GroupControl();
            this.txtCHIPHI_DV_SD1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtCHIPHI_MUA1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.grlLOAI_PP_KH = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtSANLUONG_CONGSUAT = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtGIA_TRI_CL_NTE = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.txtHAO_MON_LK_NTE = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtHAO_MON_LK = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtHAO_MON_NAM_NTE = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtHAO_MON_NAM = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtTYLE_KH_NHANH = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtHE_SO_DIEU_CHINH = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtNAM_SX1 = new DevExpress.XtraEditors.TextEdit();
            this.txtNUOC_SX = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtTHONGSO_KYTHUAT = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.xtpPHU_TUNG_KEM_THEO = new DevExpress.XtraTab.XtraTabPage();
            this.grcPHU_TUNG_KEM_THEO = new DevExpress.XtraGrid.GridControl();
            this.grvPHU_TUNG_KEM_THEO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenPtung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TenDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SoTienNte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DIEN_GIAI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RepositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnDELETE_PHUTUNG = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grc_nguonVon = new DevExpress.XtraEditors.GroupControl();
            this.Label1 = new System.Windows.Forms.Label();
            this.grcNGUON_VON = new DevExpress.XtraGrid.GridControl();
            this.grvNGUON_VON = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DM_NGUON_TSCD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDM_NGUON_TSCD_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TenNguon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TkTaisan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboTK_TAISAN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TkKhauhao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboTK_KHAUHAO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaTkChiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeTK_CHIPHI = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.HeSoPbKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NguyenGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HaoMonLuyKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTriConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboTK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboLY_DO_TANGGIAM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pfeTK_TAISAN = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.pfeTK_CHIPHI = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuiss = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnRow = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeRow = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.xtpMain)).BeginInit();
            this.xtpMain.SuspendLayout();
            this.xtpTHONG_TIN_CHINH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_TSCD_1)).BeginInit();
            this.pn_TSCD_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlPHONGBAN_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLyDoTang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKChiPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKKhauHao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKTaiSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKY_HIEU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_TSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_TSCD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLYDO_TANGGIAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_CHIPHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlDVT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_KHAUHAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_TS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLOAITAISAN_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_TSCD_2)).BeginInit();
            this.pn_TSCD_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_TANG1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_TANG1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_BDSD1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_BDSD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_MUA1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_MUA1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KTKH1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KTKH1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_BDKH1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_BDKH1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_THANG_SD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_CT_TSCD)).BeginInit();
            this.pn_CT_TSCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTY_LE_HAOMON1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUYEN_GIA1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAM_TRON_SO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_LUONG1.Properties)).BeginInit();
            this.xtpTHONG_TIN_BO_XUNG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_PTKT)).BeginInit();
            this.grc_PTKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHIPHI_DV_SD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHIPHI_MUA1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLOAI_PP_KH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSANLUONG_CONGSUAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL_NTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LK_NTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_NAM_NTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_NAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTYLE_KH_NHANH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHE_SO_DIEU_CHINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM_SX1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNUOC_SX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHONGSO_KYTHUAT.Properties)).BeginInit();
            this.xtpPHU_TUNG_KEM_THEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPHU_TUNG_KEM_THEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPHU_TUNG_KEM_THEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDELETE_PHUTUNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_nguonVon)).BeginInit();
            this.grc_nguonVon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_KHAUHAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfeTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfeTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // xtpMain
            // 
            this.xtpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtpMain.Location = new System.Drawing.Point(4, 4);
            this.xtpMain.Name = "xtpMain";
            this.xtpMain.SelectedTabPage = this.xtpTHONG_TIN_CHINH;
            this.xtpMain.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.xtpMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtpMain.Size = new System.Drawing.Size(851, 325);
            this.xtpMain.TabIndex = 0;
            this.xtpMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpTHONG_TIN_CHINH,
            this.xtpTHONG_TIN_BO_XUNG,
            this.xtpPHU_TUNG_KEM_THEO});
            this.xtpMain.TabStop = false;
            // 
            // xtpTHONG_TIN_CHINH
            // 
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.pn_TSCD_1);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.pn_TSCD_2);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.pn_CT_TSCD);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.txtLAM_TRON_SO);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.LabelControl12);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.LabelControl13);
            this.xtpTHONG_TIN_CHINH.Controls.Add(this.txtSO_LUONG1);
            this.xtpTHONG_TIN_CHINH.Name = "xtpTHONG_TIN_CHINH";
            this.xtpTHONG_TIN_CHINH.Size = new System.Drawing.Size(844, 296);
            this.xtpTHONG_TIN_CHINH.Text = "Thông tin chính";
            // 
            // pn_TSCD_1
            // 
            this.pn_TSCD_1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pn_TSCD_1.Controls.Add(this.dteNGAY_CT);
            this.pn_TSCD_1.Controls.Add(this.grlNHOM2);
            this.pn_TSCD_1.Controls.Add(this.grlPHONGBAN_ID);
            this.pn_TSCD_1.Controls.Add(this.LabelControl23);
            this.pn_TSCD_1.Controls.Add(this.txtTenLyDoTang);
            this.pn_TSCD_1.Controls.Add(this.txtTenTKChiPhi);
            this.pn_TSCD_1.Controls.Add(this.txtSO_CT);
            this.pn_TSCD_1.Controls.Add(this.LabelControl35);
            this.pn_TSCD_1.Controls.Add(this.txtTenTKKhauHao);
            this.pn_TSCD_1.Controls.Add(this.txtTenTKTaiSan);
            this.pn_TSCD_1.Controls.Add(this.txtTenTaiSan);
            this.pn_TSCD_1.Controls.Add(this.txtKY_HIEU);
            this.pn_TSCD_1.Controls.Add(this.txtTEN_TSCD);
            this.pn_TSCD_1.Controls.Add(this.txtMA_TSCD1);
            this.pn_TSCD_1.Controls.Add(this.grlLYDO_TANGGIAM);
            this.pn_TSCD_1.Controls.Add(this.LabelControl17);
            this.pn_TSCD_1.Controls.Add(this.grlMD_TK_CHIPHI);
            this.pn_TSCD_1.Controls.Add(this.LabelControl3);
            this.pn_TSCD_1.Controls.Add(this.grlDVT_ID);
            this.pn_TSCD_1.Controls.Add(this.grlMD_TK_KHAUHAO);
            this.pn_TSCD_1.Controls.Add(this.grlNHOM3);
            this.pn_TSCD_1.Controls.Add(this.LabelControl8);
            this.pn_TSCD_1.Controls.Add(this.grlMD_TK_TS);
            this.pn_TSCD_1.Controls.Add(this.LabelControl15);
            this.pn_TSCD_1.Controls.Add(this.LabelControl7);
            this.pn_TSCD_1.Controls.Add(this.LabelControl14);
            this.pn_TSCD_1.Controls.Add(this.LabelControl6);
            this.pn_TSCD_1.Controls.Add(this.grlLOAITAISAN_ID);
            this.pn_TSCD_1.Controls.Add(this.LabelControl5);
            this.pn_TSCD_1.Controls.Add(this.grlNHOM1);
            this.pn_TSCD_1.Controls.Add(this.LabelControl4);
            this.pn_TSCD_1.Controls.Add(this.LabelControl2);
            this.pn_TSCD_1.Controls.Add(this.LabelControl1);
            this.pn_TSCD_1.Location = new System.Drawing.Point(2, 4);
            this.pn_TSCD_1.Name = "pn_TSCD_1";
            this.pn_TSCD_1.Size = new System.Drawing.Size(498, 287);
            this.pn_TSCD_1.TabIndex = 0;
            // 
            // dteNGAY_CT
            // 
            this.dteNGAY_CT.EditValue = null;
            this.dteNGAY_CT.EnterMoveNextControl = true;
            this.dteNGAY_CT.Location = new System.Drawing.Point(108, 262);
            this.dteNGAY_CT.Name = "dteNGAY_CT";
            this.dteNGAY_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_CT.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_CT.Size = new System.Drawing.Size(113, 20);
            this.dteNGAY_CT.TabIndex = 18;
            // 
            // grlNHOM2
            // 
            this.grlNHOM2.EnterMoveNextControl = true;
            this.grlNHOM2.Location = new System.Drawing.Point(235, 2);
            this.grlNHOM2.Name = "grlNHOM2";
            this.grlNHOM2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlNHOM2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNHOM2.Properties.ImmediatePopup = true;
            this.grlNHOM2.Properties.NullText = "";
            this.grlNHOM2.Properties.View = this.GridView1;
            this.grlNHOM2.Size = new System.Drawing.Size(100, 20);
            this.grlNHOM2.TabIndex = 1;
            // 
            // GridView1
            // 
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grlPHONGBAN_ID
            // 
            this.grlPHONGBAN_ID.EnterMoveNextControl = true;
            this.grlPHONGBAN_ID.Location = new System.Drawing.Point(337, 236);
            this.grlPHONGBAN_ID.Name = "grlPHONGBAN_ID";
            this.grlPHONGBAN_ID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlPHONGBAN_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlPHONGBAN_ID.Properties.ImmediatePopup = true;
            this.grlPHONGBAN_ID.Properties.NullText = "";
            this.grlPHONGBAN_ID.Properties.View = this.GridView9;
            this.grlPHONGBAN_ID.Size = new System.Drawing.Size(128, 20);
            this.grlPHONGBAN_ID.TabIndex = 17;
            // 
            // GridView9
            // 
            this.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView9.Name = "GridView9";
            this.GridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView9.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl23
            // 
            this.LabelControl23.Location = new System.Drawing.Point(52, 265);
            this.LabelControl23.Name = "LabelControl23";
            this.LabelControl23.Size = new System.Drawing.Size(37, 13);
            this.LabelControl23.TabIndex = 73;
            this.LabelControl23.Text = "Ngày ct";
            // 
            // txtTenLyDoTang
            // 
            this.txtTenLyDoTang.EnterMoveNextControl = true;
            this.txtTenLyDoTang.Location = new System.Drawing.Point(214, 210);
            this.txtTenLyDoTang.Name = "txtTenLyDoTang";
            this.txtTenLyDoTang.Properties.ReadOnly = true;
            this.txtTenLyDoTang.Size = new System.Drawing.Size(251, 20);
            this.txtTenLyDoTang.TabIndex = 15;
            this.txtTenLyDoTang.TabStop = false;
            // 
            // txtTenTKChiPhi
            // 
            this.txtTenTKChiPhi.EnterMoveNextControl = true;
            this.txtTenTKChiPhi.Location = new System.Drawing.Point(214, 184);
            this.txtTenTKChiPhi.Name = "txtTenTKChiPhi";
            this.txtTenTKChiPhi.Properties.ReadOnly = true;
            this.txtTenTKChiPhi.Size = new System.Drawing.Size(251, 20);
            this.txtTenTKChiPhi.TabIndex = 13;
            this.txtTenTKChiPhi.TabStop = false;
            // 
            // txtSO_CT
            // 
            this.txtSO_CT.EnterMoveNextControl = true;
            this.txtSO_CT.Location = new System.Drawing.Point(337, 262);
            this.txtSO_CT.Name = "txtSO_CT";
            this.txtSO_CT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSO_CT.Size = new System.Drawing.Size(128, 20);
            this.txtSO_CT.TabIndex = 19;
            // 
            // LabelControl35
            // 
            this.LabelControl35.Location = new System.Drawing.Point(292, 265);
            this.LabelControl35.Name = "LabelControl35";
            this.LabelControl35.Size = new System.Drawing.Size(24, 13);
            this.LabelControl35.TabIndex = 72;
            this.LabelControl35.Text = "Số ct";
            // 
            // txtTenTKKhauHao
            // 
            this.txtTenTKKhauHao.EnterMoveNextControl = true;
            this.txtTenTKKhauHao.Location = new System.Drawing.Point(214, 158);
            this.txtTenTKKhauHao.Name = "txtTenTKKhauHao";
            this.txtTenTKKhauHao.Properties.ReadOnly = true;
            this.txtTenTKKhauHao.Size = new System.Drawing.Size(251, 20);
            this.txtTenTKKhauHao.TabIndex = 11;
            this.txtTenTKKhauHao.TabStop = false;
            // 
            // txtTenTKTaiSan
            // 
            this.txtTenTKTaiSan.EnterMoveNextControl = true;
            this.txtTenTKTaiSan.Location = new System.Drawing.Point(214, 132);
            this.txtTenTKTaiSan.Name = "txtTenTKTaiSan";
            this.txtTenTKTaiSan.Properties.ReadOnly = true;
            this.txtTenTKTaiSan.Size = new System.Drawing.Size(251, 20);
            this.txtTenTKTaiSan.TabIndex = 9;
            this.txtTenTKTaiSan.TabStop = false;
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.EnterMoveNextControl = true;
            this.txtTenTaiSan.Location = new System.Drawing.Point(214, 106);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Properties.ReadOnly = true;
            this.txtTenTaiSan.Size = new System.Drawing.Size(251, 20);
            this.txtTenTaiSan.TabIndex = 7;
            this.txtTenTaiSan.TabStop = false;
            // 
            // txtKY_HIEU
            // 
            this.txtKY_HIEU.EnterMoveNextControl = true;
            this.txtKY_HIEU.Location = new System.Drawing.Point(108, 80);
            this.txtKY_HIEU.Name = "txtKY_HIEU";
            this.txtKY_HIEU.Size = new System.Drawing.Size(357, 20);
            this.txtKY_HIEU.TabIndex = 5;
            // 
            // txtTEN_TSCD
            // 
            this.txtTEN_TSCD.EnterMoveNextControl = true;
            this.txtTEN_TSCD.Location = new System.Drawing.Point(108, 54);
            this.txtTEN_TSCD.Name = "txtTEN_TSCD";
            this.txtTEN_TSCD.Size = new System.Drawing.Size(357, 20);
            this.txtTEN_TSCD.TabIndex = 4;
            // 
            // txtMA_TSCD1
            // 
            this.txtMA_TSCD1.EnterMoveNextControl = true;
            this.txtMA_TSCD1.Location = new System.Drawing.Point(108, 28);
            this.txtMA_TSCD1.Name = "txtMA_TSCD1";
            this.txtMA_TSCD1.Properties.MaxLength = 32;
            this.txtMA_TSCD1.Size = new System.Drawing.Size(357, 20);
            this.txtMA_TSCD1.TabIndex = 3;
            // 
            // grlLYDO_TANGGIAM
            // 
            this.grlLYDO_TANGGIAM.EnterMoveNextControl = true;
            this.grlLYDO_TANGGIAM.Location = new System.Drawing.Point(108, 210);
            this.grlLYDO_TANGGIAM.Name = "grlLYDO_TANGGIAM";
            this.grlLYDO_TANGGIAM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLYDO_TANGGIAM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLYDO_TANGGIAM.Properties.ImmediatePopup = true;
            this.grlLYDO_TANGGIAM.Properties.NullText = "";
            this.grlLYDO_TANGGIAM.Properties.View = this.GridView7;
            this.grlLYDO_TANGGIAM.Size = new System.Drawing.Size(100, 20);
            this.grlLYDO_TANGGIAM.TabIndex = 14;
            // 
            // GridView7
            // 
            this.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView7.Name = "GridView7";
            this.GridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView7.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl17
            // 
            this.LabelControl17.Location = new System.Drawing.Point(24, 83);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(66, 13);
            this.LabelControl17.TabIndex = 47;
            this.LabelControl17.Text = "Kí hiệu tài sản";
            // 
            // grlMD_TK_CHIPHI
            // 
            this.grlMD_TK_CHIPHI.EnterMoveNextControl = true;
            this.grlMD_TK_CHIPHI.Location = new System.Drawing.Point(108, 184);
            this.grlMD_TK_CHIPHI.Name = "grlMD_TK_CHIPHI";
            this.grlMD_TK_CHIPHI.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlMD_TK_CHIPHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlMD_TK_CHIPHI.Properties.ImmediatePopup = true;
            this.grlMD_TK_CHIPHI.Properties.NullText = "";
            this.grlMD_TK_CHIPHI.Properties.View = this.GridView6;
            this.grlMD_TK_CHIPHI.Size = new System.Drawing.Size(100, 20);
            this.grlMD_TK_CHIPHI.TabIndex = 12;
            // 
            // GridView6
            // 
            this.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView6.Name = "GridView6";
            this.GridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView6.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(37, 57);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(53, 13);
            this.LabelControl3.TabIndex = 51;
            this.LabelControl3.Text = "Tên tài sản";
            // 
            // grlDVT_ID
            // 
            this.grlDVT_ID.EnterMoveNextControl = true;
            this.grlDVT_ID.Location = new System.Drawing.Point(108, 236);
            this.grlDVT_ID.Name = "grlDVT_ID";
            this.grlDVT_ID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlDVT_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlDVT_ID.Properties.ImmediatePopup = true;
            this.grlDVT_ID.Properties.NullText = "";
            this.grlDVT_ID.Properties.View = this.GridView8;
            this.grlDVT_ID.Size = new System.Drawing.Size(113, 20);
            this.grlDVT_ID.TabIndex = 16;
            // 
            // GridView8
            // 
            this.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView8.Name = "GridView8";
            this.GridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView8.OptionsView.ShowGroupPanel = false;
            // 
            // grlMD_TK_KHAUHAO
            // 
            this.grlMD_TK_KHAUHAO.EnterMoveNextControl = true;
            this.grlMD_TK_KHAUHAO.Location = new System.Drawing.Point(108, 158);
            this.grlMD_TK_KHAUHAO.Name = "grlMD_TK_KHAUHAO";
            this.grlMD_TK_KHAUHAO.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlMD_TK_KHAUHAO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlMD_TK_KHAUHAO.Properties.ImmediatePopup = true;
            this.grlMD_TK_KHAUHAO.Properties.NullText = "";
            this.grlMD_TK_KHAUHAO.Properties.View = this.GridView5;
            this.grlMD_TK_KHAUHAO.Size = new System.Drawing.Size(100, 20);
            this.grlMD_TK_KHAUHAO.TabIndex = 10;
            // 
            // GridView5
            // 
            this.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView5.Name = "GridView5";
            this.GridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView5.OptionsView.ShowGroupPanel = false;
            // 
            // grlNHOM3
            // 
            this.grlNHOM3.EnterMoveNextControl = true;
            this.grlNHOM3.Location = new System.Drawing.Point(365, 2);
            this.grlNHOM3.Name = "grlNHOM3";
            this.grlNHOM3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlNHOM3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNHOM3.Properties.ImmediatePopup = true;
            this.grlNHOM3.Properties.NullText = "";
            this.grlNHOM3.Properties.View = this.GridView2;
            this.grlNHOM3.Size = new System.Drawing.Size(100, 20);
            this.grlNHOM3.TabIndex = 2;
            // 
            // GridView2
            // 
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(39, 213);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(51, 13);
            this.LabelControl8.TabIndex = 48;
            this.LabelControl8.Text = "Lý do tăng";
            // 
            // grlMD_TK_TS
            // 
            this.grlMD_TK_TS.EnterMoveNextControl = true;
            this.grlMD_TK_TS.Location = new System.Drawing.Point(108, 132);
            this.grlMD_TK_TS.Name = "grlMD_TK_TS";
            this.grlMD_TK_TS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlMD_TK_TS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlMD_TK_TS.Properties.ImmediatePopup = true;
            this.grlMD_TK_TS.Properties.NullText = "";
            this.grlMD_TK_TS.Properties.View = this.GridView4;
            this.grlMD_TK_TS.Size = new System.Drawing.Size(100, 20);
            this.grlMD_TK_TS.TabIndex = 8;
            // 
            // GridView4
            // 
            this.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView4.Name = "GridView4";
            this.GridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView4.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl15
            // 
            this.LabelControl15.Location = new System.Drawing.Point(235, 239);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(81, 13);
            this.LabelControl15.TabIndex = 12;
            this.LabelControl15.Text = "Bộ phận sử dụng";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(45, 187);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(45, 13);
            this.LabelControl7.TabIndex = 49;
            this.LabelControl7.Text = "TK chi phí";
            // 
            // LabelControl14
            // 
            this.LabelControl14.Location = new System.Drawing.Point(37, 239);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(52, 13);
            this.LabelControl14.TabIndex = 56;
            this.LabelControl14.Text = "Đơn vị tính";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(32, 161);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(58, 13);
            this.LabelControl6.TabIndex = 57;
            this.LabelControl6.Text = "Tk khấu hao";
            // 
            // grlLOAITAISAN_ID
            // 
            this.grlLOAITAISAN_ID.EnterMoveNextControl = true;
            this.grlLOAITAISAN_ID.Location = new System.Drawing.Point(108, 106);
            this.grlLOAITAISAN_ID.Name = "grlLOAITAISAN_ID";
            this.grlLOAITAISAN_ID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLOAITAISAN_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLOAITAISAN_ID.Properties.ImmediatePopup = true;
            this.grlLOAITAISAN_ID.Properties.NullText = "";
            this.grlLOAITAISAN_ID.Properties.View = this.GridView3;
            this.grlLOAITAISAN_ID.Size = new System.Drawing.Size(100, 20);
            this.grlLOAITAISAN_ID.TabIndex = 6;
            // 
            // GridView3
            // 
            this.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView3.Name = "GridView3";
            this.GridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView3.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(43, 135);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(47, 13);
            this.LabelControl5.TabIndex = 54;
            this.LabelControl5.Text = "TK tài sản";
            // 
            // grlNHOM1
            // 
            this.grlNHOM1.EnterMoveNextControl = true;
            this.grlNHOM1.Location = new System.Drawing.Point(108, 2);
            this.grlNHOM1.Name = "grlNHOM1";
            this.grlNHOM1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlNHOM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlNHOM1.Properties.ImmediatePopup = true;
            this.grlNHOM1.Properties.NullText = "";
            this.grlNHOM1.Properties.View = this.GridLookUpEdit1View;
            this.grlNHOM1.Size = new System.Drawing.Size(100, 20);
            this.grlNHOM1.TabIndex = 0;
            // 
            // GridLookUpEdit1View
            // 
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(36, 109);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(54, 13);
            this.LabelControl4.TabIndex = 52;
            this.LabelControl4.Text = "Loại tài sản";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(41, 31);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(49, 13);
            this.LabelControl2.TabIndex = 53;
            this.LabelControl2.Text = "Mã tài sản";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(63, 5);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(27, 13);
            this.LabelControl1.TabIndex = 55;
            this.LabelControl1.Text = "Nhóm";
            // 
            // pn_TSCD_2
            // 
            this.pn_TSCD_2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pn_TSCD_2.Controls.Add(this.LabelControl33);
            this.pn_TSCD_2.Controls.Add(this.LabelControl31);
            this.pn_TSCD_2.Controls.Add(this.dteNGAY_TANG1);
            this.pn_TSCD_2.Controls.Add(this.dteNGAY_BDSD1);
            this.pn_TSCD_2.Controls.Add(this.dtxNGAY_MUA1);
            this.pn_TSCD_2.Controls.Add(this.dteNGAY_KTKH1);
            this.pn_TSCD_2.Controls.Add(this.lbl);
            this.pn_TSCD_2.Controls.Add(this.dtxNGAY_BDKH1);
            this.pn_TSCD_2.Controls.Add(this.LabelControl10);
            this.pn_TSCD_2.Controls.Add(this.LabelControl9);
            this.pn_TSCD_2.Controls.Add(this.txtSO_THANG_SD1);
            this.pn_TSCD_2.Controls.Add(this.LabelControl11);
            this.pn_TSCD_2.Location = new System.Drawing.Point(506, 0);
            this.pn_TSCD_2.Name = "pn_TSCD_2";
            this.pn_TSCD_2.Size = new System.Drawing.Size(336, 156);
            this.pn_TSCD_2.TabIndex = 1;
            // 
            // LabelControl33
            // 
            this.LabelControl33.Location = new System.Drawing.Point(57, 57);
            this.LabelControl33.Name = "LabelControl33";
            this.LabelControl33.Size = new System.Drawing.Size(107, 13);
            this.LabelControl33.TabIndex = 68;
            this.LabelControl33.Text = "Ngày bắt đầu sử dụng";
            // 
            // LabelControl31
            // 
            this.LabelControl31.Location = new System.Drawing.Point(117, 6);
            this.LabelControl31.Name = "LabelControl31";
            this.LabelControl31.Size = new System.Drawing.Size(48, 13);
            this.LabelControl31.TabIndex = 69;
            this.LabelControl31.Text = "Ngày mua";
            // 
            // dteNGAY_TANG1
            // 
            this.dteNGAY_TANG1.EditValue = null;
            this.dteNGAY_TANG1.EnterMoveNextControl = true;
            this.dteNGAY_TANG1.Location = new System.Drawing.Point(183, 28);
            this.dteNGAY_TANG1.Name = "dteNGAY_TANG1";
            this.dteNGAY_TANG1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_TANG1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_TANG1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_TANG1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_TANG1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_TANG1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_TANG1.Size = new System.Drawing.Size(129, 20);
            this.dteNGAY_TANG1.TabIndex = 1;
            // 
            // dteNGAY_BDSD1
            // 
            this.dteNGAY_BDSD1.EditValue = null;
            this.dteNGAY_BDSD1.EnterMoveNextControl = true;
            this.dteNGAY_BDSD1.Location = new System.Drawing.Point(183, 54);
            this.dteNGAY_BDSD1.Name = "dteNGAY_BDSD1";
            this.dteNGAY_BDSD1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_BDSD1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_BDSD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_BDSD1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_BDSD1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_BDSD1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_BDSD1.Size = new System.Drawing.Size(129, 20);
            this.dteNGAY_BDSD1.TabIndex = 2;
            // 
            // dtxNGAY_MUA1
            // 
            this.dtxNGAY_MUA1.EditValue = null;
            this.dtxNGAY_MUA1.EnterMoveNextControl = true;
            this.dtxNGAY_MUA1.Location = new System.Drawing.Point(184, 3);
            this.dtxNGAY_MUA1.Name = "dtxNGAY_MUA1";
            this.dtxNGAY_MUA1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtxNGAY_MUA1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtxNGAY_MUA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtxNGAY_MUA1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtxNGAY_MUA1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtxNGAY_MUA1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtxNGAY_MUA1.Size = new System.Drawing.Size(129, 20);
            this.dtxNGAY_MUA1.TabIndex = 0;
            // 
            // dteNGAY_KTKH1
            // 
            this.dteNGAY_KTKH1.EditValue = null;
            this.dteNGAY_KTKH1.EnterMoveNextControl = true;
            this.dteNGAY_KTKH1.Location = new System.Drawing.Point(184, 107);
            this.dteNGAY_KTKH1.Name = "dteNGAY_KTKH1";
            this.dteNGAY_KTKH1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_KTKH1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_KTKH1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_KTKH1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_KTKH1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_KTKH1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_KTKH1.Size = new System.Drawing.Size(128, 20);
            this.dteNGAY_KTKH1.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(52, 110);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 13);
            this.lbl.TabIndex = 62;
            this.lbl.Text = "Ngày kết thúc khấu hao";
            // 
            // dtxNGAY_BDKH1
            // 
            this.dtxNGAY_BDKH1.EditValue = null;
            this.dtxNGAY_BDKH1.EnterMoveNextControl = true;
            this.dtxNGAY_BDKH1.Location = new System.Drawing.Point(184, 80);
            this.dtxNGAY_BDKH1.Name = "dtxNGAY_BDKH1";
            this.dtxNGAY_BDKH1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtxNGAY_BDKH1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtxNGAY_BDKH1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtxNGAY_BDKH1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtxNGAY_BDKH1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtxNGAY_BDKH1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtxNGAY_BDKH1.Size = new System.Drawing.Size(128, 20);
            this.dtxNGAY_BDKH1.TabIndex = 3;
            // 
            // LabelControl10
            // 
            this.LabelControl10.Location = new System.Drawing.Point(54, 83);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(112, 13);
            this.LabelControl10.TabIndex = 62;
            this.LabelControl10.Text = "Ngày bắt đầu khấu hao";
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(115, 30);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(50, 13);
            this.LabelControl9.TabIndex = 63;
            this.LabelControl9.Text = "Ngày tăng";
            // 
            // txtSO_THANG_SD1
            // 
            this.txtSO_THANG_SD1.EnterMoveNextControl = true;
            this.txtSO_THANG_SD1.Location = new System.Drawing.Point(184, 132);
            this.txtSO_THANG_SD1.Name = "txtSO_THANG_SD1";
            this.txtSO_THANG_SD1.Properties.Mask.EditMask = "[0-9]{0,4}";
            this.txtSO_THANG_SD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSO_THANG_SD1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSO_THANG_SD1.Size = new System.Drawing.Size(128, 20);
            this.txtSO_THANG_SD1.TabIndex = 5;
            // 
            // LabelControl11
            // 
            this.LabelControl11.Location = new System.Drawing.Point(80, 135);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(85, 13);
            this.LabelControl11.TabIndex = 57;
            this.LabelControl11.Text = "Số tháng sử dụng";
            // 
            // pn_CT_TSCD
            // 
            this.pn_CT_TSCD.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pn_CT_TSCD.Controls.Add(this.txtTY_LE_HAOMON1);
            this.pn_CT_TSCD.Controls.Add(this.LabelControl48);
            this.pn_CT_TSCD.Controls.Add(this.txtGIA_TRI_CL1);
            this.pn_CT_TSCD.Controls.Add(this.LabelControl16);
            this.pn_CT_TSCD.Controls.Add(this.txtNGUYEN_GIA1);
            this.pn_CT_TSCD.Controls.Add(this.LabelControl34);
            this.pn_CT_TSCD.Location = new System.Drawing.Point(506, 156);
            this.pn_CT_TSCD.Name = "pn_CT_TSCD";
            this.pn_CT_TSCD.Size = new System.Drawing.Size(336, 80);
            this.pn_CT_TSCD.TabIndex = 2;
            // 
            // txtTY_LE_HAOMON1
            // 
            this.txtTY_LE_HAOMON1.EnterMoveNextControl = true;
            this.txtTY_LE_HAOMON1.Location = new System.Drawing.Point(185, 56);
            this.txtTY_LE_HAOMON1.Name = "txtTY_LE_HAOMON1";
            this.txtTY_LE_HAOMON1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTY_LE_HAOMON1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTY_LE_HAOMON1.Properties.Mask.EditMask = "n0";
            this.txtTY_LE_HAOMON1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTY_LE_HAOMON1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTY_LE_HAOMON1.Size = new System.Drawing.Size(128, 20);
            this.txtTY_LE_HAOMON1.TabIndex = 2;
            this.txtTY_LE_HAOMON1.Visible = false;
            // 
            // LabelControl48
            // 
            this.LabelControl48.Location = new System.Drawing.Point(99, 59);
            this.LabelControl48.Name = "LabelControl48";
            this.LabelControl48.Size = new System.Drawing.Size(67, 13);
            this.LabelControl48.TabIndex = 70;
            this.LabelControl48.Text = "Tỷ lệ hao mòn";
            this.LabelControl48.Visible = false;
            // 
            // txtGIA_TRI_CL1
            // 
            this.txtGIA_TRI_CL1.EnterMoveNextControl = true;
            this.txtGIA_TRI_CL1.Location = new System.Drawing.Point(184, 30);
            this.txtGIA_TRI_CL1.Name = "txtGIA_TRI_CL1";
            this.txtGIA_TRI_CL1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGIA_TRI_CL1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGIA_TRI_CL1.Properties.Mask.BeepOnError = true;
            this.txtGIA_TRI_CL1.Properties.Mask.EditMask = "n0";
            this.txtGIA_TRI_CL1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGIA_TRI_CL1.Properties.Mask.ShowPlaceHolders = false;
            this.txtGIA_TRI_CL1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGIA_TRI_CL1.Properties.MaxLength = 18;
            this.txtGIA_TRI_CL1.Size = new System.Drawing.Size(128, 20);
            this.txtGIA_TRI_CL1.TabIndex = 1;
            // 
            // LabelControl16
            // 
            this.LabelControl16.Location = new System.Drawing.Point(105, 33);
            this.LabelControl16.Name = "LabelControl16";
            this.LabelControl16.Size = new System.Drawing.Size(61, 13);
            this.LabelControl16.TabIndex = 69;
            this.LabelControl16.Text = "Giá trị còn lại";
            // 
            // txtNGUYEN_GIA1
            // 
            this.txtNGUYEN_GIA1.EnterMoveNextControl = true;
            this.txtNGUYEN_GIA1.Location = new System.Drawing.Point(183, 4);
            this.txtNGUYEN_GIA1.Name = "txtNGUYEN_GIA1";
            this.txtNGUYEN_GIA1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNGUYEN_GIA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNGUYEN_GIA1.Properties.Mask.BeepOnError = true;
            this.txtNGUYEN_GIA1.Properties.Mask.EditMask = "n0";
            this.txtNGUYEN_GIA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNGUYEN_GIA1.Properties.Mask.ShowPlaceHolders = false;
            this.txtNGUYEN_GIA1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNGUYEN_GIA1.Size = new System.Drawing.Size(128, 20);
            this.txtNGUYEN_GIA1.TabIndex = 0;
            // 
            // LabelControl34
            // 
            this.LabelControl34.Location = new System.Drawing.Point(111, 7);
            this.LabelControl34.Name = "LabelControl34";
            this.LabelControl34.Size = new System.Drawing.Size(54, 13);
            this.LabelControl34.TabIndex = 68;
            this.LabelControl34.Text = "Nguyên giá";
            // 
            // txtLAM_TRON_SO
            // 
            this.txtLAM_TRON_SO.EnterMoveNextControl = true;
            this.txtLAM_TRON_SO.Location = new System.Drawing.Point(690, 242);
            this.txtLAM_TRON_SO.Name = "txtLAM_TRON_SO";
            this.txtLAM_TRON_SO.Size = new System.Drawing.Size(128, 20);
            this.txtLAM_TRON_SO.TabIndex = 6;
            this.txtLAM_TRON_SO.Visible = false;
            // 
            // LabelControl12
            // 
            this.LabelControl12.Location = new System.Drawing.Point(615, 246);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new System.Drawing.Size(56, 13);
            this.LabelControl12.TabIndex = 56;
            this.LabelControl12.Text = "Làm tròn số";
            this.LabelControl12.Visible = false;
            // 
            // LabelControl13
            // 
            this.LabelControl13.Location = new System.Drawing.Point(629, 271);
            this.LabelControl13.Name = "LabelControl13";
            this.LabelControl13.Size = new System.Drawing.Size(42, 13);
            this.LabelControl13.TabIndex = 58;
            this.LabelControl13.Text = "Số lượng";
            this.LabelControl13.Visible = false;
            // 
            // txtSO_LUONG1
            // 
            this.txtSO_LUONG1.EnterMoveNextControl = true;
            this.txtSO_LUONG1.Location = new System.Drawing.Point(690, 268);
            this.txtSO_LUONG1.Name = "txtSO_LUONG1";
            this.txtSO_LUONG1.Properties.Mask.EditMask = "[0-9]{0,5}";
            this.txtSO_LUONG1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSO_LUONG1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSO_LUONG1.Size = new System.Drawing.Size(128, 20);
            this.txtSO_LUONG1.TabIndex = 7;
            this.txtSO_LUONG1.Visible = false;
            // 
            // xtpTHONG_TIN_BO_XUNG
            // 
            this.xtpTHONG_TIN_BO_XUNG.Controls.Add(this.grc_PTKT);
            this.xtpTHONG_TIN_BO_XUNG.Name = "xtpTHONG_TIN_BO_XUNG";
            this.xtpTHONG_TIN_BO_XUNG.Size = new System.Drawing.Size(844, 296);
            this.xtpTHONG_TIN_BO_XUNG.Text = "Thông tin bổ sung";
            // 
            // grc_PTKT
            // 
            this.grc_PTKT.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grc_PTKT.Controls.Add(this.txtCHIPHI_DV_SD1);
            this.grc_PTKT.Controls.Add(this.LabelControl36);
            this.grc_PTKT.Controls.Add(this.txtCHIPHI_MUA1);
            this.grc_PTKT.Controls.Add(this.LabelControl32);
            this.grc_PTKT.Controls.Add(this.grlLOAI_PP_KH);
            this.grc_PTKT.Controls.Add(this.LabelControl27);
            this.grc_PTKT.Controls.Add(this.txtSANLUONG_CONGSUAT);
            this.grc_PTKT.Controls.Add(this.LabelControl26);
            this.grc_PTKT.Controls.Add(this.txtGIA_TRI_CL_NTE);
            this.grc_PTKT.Controls.Add(this.LabelControl25);
            this.grc_PTKT.Controls.Add(this.txtHAO_MON_LK_NTE);
            this.grc_PTKT.Controls.Add(this.LabelControl28);
            this.grc_PTKT.Controls.Add(this.txtHAO_MON_LK);
            this.grc_PTKT.Controls.Add(this.LabelControl29);
            this.grc_PTKT.Controls.Add(this.txtHAO_MON_NAM_NTE);
            this.grc_PTKT.Controls.Add(this.LabelControl30);
            this.grc_PTKT.Controls.Add(this.txtHAO_MON_NAM);
            this.grc_PTKT.Controls.Add(this.LabelControl18);
            this.grc_PTKT.Controls.Add(this.txtTYLE_KH_NHANH);
            this.grc_PTKT.Controls.Add(this.LabelControl19);
            this.grc_PTKT.Controls.Add(this.txtHE_SO_DIEU_CHINH);
            this.grc_PTKT.Controls.Add(this.LabelControl20);
            this.grc_PTKT.Controls.Add(this.LabelControl22);
            this.grc_PTKT.Controls.Add(this.txtNAM_SX1);
            this.grc_PTKT.Controls.Add(this.txtNUOC_SX);
            this.grc_PTKT.Controls.Add(this.LabelControl21);
            this.grc_PTKT.Controls.Add(this.txtTHONGSO_KYTHUAT);
            this.grc_PTKT.Controls.Add(this.LabelControl24);
            this.grc_PTKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_PTKT.Location = new System.Drawing.Point(0, 0);
            this.grc_PTKT.Name = "grc_PTKT";
            this.grc_PTKT.Size = new System.Drawing.Size(844, 296);
            this.grc_PTKT.TabIndex = 0;
            this.grc_PTKT.Text = "GroupControl2";
            // 
            // txtCHIPHI_DV_SD1
            // 
            this.txtCHIPHI_DV_SD1.EnterMoveNextControl = true;
            this.txtCHIPHI_DV_SD1.Location = new System.Drawing.Point(158, 45);
            this.txtCHIPHI_DV_SD1.Name = "txtCHIPHI_DV_SD1";
            this.txtCHIPHI_DV_SD1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCHIPHI_DV_SD1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCHIPHI_DV_SD1.Properties.Mask.BeepOnError = true;
            this.txtCHIPHI_DV_SD1.Properties.Mask.EditMask = "n0";
            this.txtCHIPHI_DV_SD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCHIPHI_DV_SD1.Properties.Mask.ShowPlaceHolders = false;
            this.txtCHIPHI_DV_SD1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCHIPHI_DV_SD1.Size = new System.Drawing.Size(166, 20);
            this.txtCHIPHI_DV_SD1.TabIndex = 1;
            // 
            // LabelControl36
            // 
            this.LabelControl36.Location = new System.Drawing.Point(50, 48);
            this.LabelControl36.Name = "LabelControl36";
            this.LabelControl36.Size = new System.Drawing.Size(91, 13);
            this.LabelControl36.TabIndex = 84;
            this.LabelControl36.Text = "Chi phí đưa vào SD";
            // 
            // txtCHIPHI_MUA1
            // 
            this.txtCHIPHI_MUA1.EnterMoveNextControl = true;
            this.txtCHIPHI_MUA1.Location = new System.Drawing.Point(158, 19);
            this.txtCHIPHI_MUA1.Name = "txtCHIPHI_MUA1";
            this.txtCHIPHI_MUA1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCHIPHI_MUA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCHIPHI_MUA1.Properties.Mask.BeepOnError = true;
            this.txtCHIPHI_MUA1.Properties.Mask.EditMask = "n0";
            this.txtCHIPHI_MUA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCHIPHI_MUA1.Properties.Mask.ShowPlaceHolders = false;
            this.txtCHIPHI_MUA1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCHIPHI_MUA1.Size = new System.Drawing.Size(166, 20);
            this.txtCHIPHI_MUA1.TabIndex = 0;
            // 
            // LabelControl32
            // 
            this.LabelControl32.Location = new System.Drawing.Point(70, 22);
            this.LabelControl32.Name = "LabelControl32";
            this.LabelControl32.Size = new System.Drawing.Size(71, 13);
            this.LabelControl32.TabIndex = 84;
            this.LabelControl32.Text = "Số tiền mua TS";
            // 
            // grlLOAI_PP_KH
            // 
            this.grlLOAI_PP_KH.EnterMoveNextControl = true;
            this.grlLOAI_PP_KH.Location = new System.Drawing.Point(158, 149);
            this.grlLOAI_PP_KH.Name = "grlLOAI_PP_KH";
            this.grlLOAI_PP_KH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLOAI_PP_KH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLOAI_PP_KH.Properties.ImmediatePopup = true;
            this.grlLOAI_PP_KH.Properties.NullText = "";
            this.grlLOAI_PP_KH.Properties.View = this.GridView10;
            this.grlLOAI_PP_KH.Size = new System.Drawing.Size(166, 20);
            this.grlLOAI_PP_KH.TabIndex = 5;
            this.grlLOAI_PP_KH.Visible = false;
            // 
            // GridView10
            // 
            this.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView10.Name = "GridView10";
            this.GridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView10.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl27
            // 
            this.LabelControl27.Location = new System.Drawing.Point(8, 152);
            this.LabelControl27.Name = "LabelControl27";
            this.LabelControl27.Size = new System.Drawing.Size(133, 13);
            this.LabelControl27.TabIndex = 82;
            this.LabelControl27.Text = "Loại phương pháp khấu hao";
            this.LabelControl27.Visible = false;
            // 
            // txtSANLUONG_CONGSUAT
            // 
            this.txtSANLUONG_CONGSUAT.EnterMoveNextControl = true;
            this.txtSANLUONG_CONGSUAT.Location = new System.Drawing.Point(653, 71);
            this.txtSANLUONG_CONGSUAT.Name = "txtSANLUONG_CONGSUAT";
            this.txtSANLUONG_CONGSUAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSANLUONG_CONGSUAT.Size = new System.Drawing.Size(166, 20);
            this.txtSANLUONG_CONGSUAT.TabIndex = 8;
            this.txtSANLUONG_CONGSUAT.Visible = false;
            // 
            // LabelControl26
            // 
            this.LabelControl26.Location = new System.Drawing.Point(537, 74);
            this.LabelControl26.Name = "LabelControl26";
            this.LabelControl26.Size = new System.Drawing.Size(99, 13);
            this.LabelControl26.TabIndex = 81;
            this.LabelControl26.Text = "Sản lượng công xuất";
            this.LabelControl26.Visible = false;
            // 
            // txtGIA_TRI_CL_NTE
            // 
            this.txtGIA_TRI_CL_NTE.EnterMoveNextControl = true;
            this.txtGIA_TRI_CL_NTE.Location = new System.Drawing.Point(653, 45);
            this.txtGIA_TRI_CL_NTE.Name = "txtGIA_TRI_CL_NTE";
            this.txtGIA_TRI_CL_NTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGIA_TRI_CL_NTE.Size = new System.Drawing.Size(166, 20);
            this.txtGIA_TRI_CL_NTE.TabIndex = 7;
            this.txtGIA_TRI_CL_NTE.Visible = false;
            // 
            // LabelControl25
            // 
            this.LabelControl25.Location = new System.Drawing.Point(533, 48);
            this.LabelControl25.Name = "LabelControl25";
            this.LabelControl25.Size = new System.Drawing.Size(103, 13);
            this.LabelControl25.TabIndex = 80;
            this.LabelControl25.Text = "Giá trị còn lại ngoại tệ";
            this.LabelControl25.Visible = false;
            // 
            // txtHAO_MON_LK_NTE
            // 
            this.txtHAO_MON_LK_NTE.EnterMoveNextControl = true;
            this.txtHAO_MON_LK_NTE.Location = new System.Drawing.Point(653, 19);
            this.txtHAO_MON_LK_NTE.Name = "txtHAO_MON_LK_NTE";
            this.txtHAO_MON_LK_NTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHAO_MON_LK_NTE.Size = new System.Drawing.Size(166, 20);
            this.txtHAO_MON_LK_NTE.TabIndex = 6;
            this.txtHAO_MON_LK_NTE.Visible = false;
            // 
            // LabelControl28
            // 
            this.LabelControl28.Location = new System.Drawing.Point(498, 22);
            this.LabelControl28.Name = "LabelControl28";
            this.LabelControl28.Size = new System.Drawing.Size(138, 13);
            this.LabelControl28.TabIndex = 79;
            this.LabelControl28.Text = "Hao mòn năm lũy kế ngoại tệ";
            this.LabelControl28.Visible = false;
            // 
            // txtHAO_MON_LK
            // 
            this.txtHAO_MON_LK.EditValue = "";
            this.txtHAO_MON_LK.EnterMoveNextControl = true;
            this.txtHAO_MON_LK.Location = new System.Drawing.Point(653, 205);
            this.txtHAO_MON_LK.Name = "txtHAO_MON_LK";
            this.txtHAO_MON_LK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHAO_MON_LK.Size = new System.Drawing.Size(166, 20);
            this.txtHAO_MON_LK.TabIndex = 13;
            this.txtHAO_MON_LK.Visible = false;
            // 
            // LabelControl29
            // 
            this.LabelControl29.Location = new System.Drawing.Point(540, 209);
            this.LabelControl29.Name = "LabelControl29";
            this.LabelControl29.Size = new System.Drawing.Size(96, 13);
            this.LabelControl29.TabIndex = 78;
            this.LabelControl29.Text = "Hao mòn năm lũy kế";
            this.LabelControl29.Visible = false;
            // 
            // txtHAO_MON_NAM_NTE
            // 
            this.txtHAO_MON_NAM_NTE.EnterMoveNextControl = true;
            this.txtHAO_MON_NAM_NTE.Location = new System.Drawing.Point(653, 179);
            this.txtHAO_MON_NAM_NTE.Name = "txtHAO_MON_NAM_NTE";
            this.txtHAO_MON_NAM_NTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHAO_MON_NAM_NTE.Size = new System.Drawing.Size(166, 20);
            this.txtHAO_MON_NAM_NTE.TabIndex = 12;
            this.txtHAO_MON_NAM_NTE.Visible = false;
            // 
            // LabelControl30
            // 
            this.LabelControl30.Location = new System.Drawing.Point(529, 183);
            this.LabelControl30.Name = "LabelControl30";
            this.LabelControl30.Size = new System.Drawing.Size(107, 13);
            this.LabelControl30.TabIndex = 77;
            this.LabelControl30.Text = "Hao mòn năm ngọai tệ";
            this.LabelControl30.Visible = false;
            // 
            // txtHAO_MON_NAM
            // 
            this.txtHAO_MON_NAM.EnterMoveNextControl = true;
            this.txtHAO_MON_NAM.Location = new System.Drawing.Point(653, 153);
            this.txtHAO_MON_NAM.Name = "txtHAO_MON_NAM";
            this.txtHAO_MON_NAM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHAO_MON_NAM.Size = new System.Drawing.Size(166, 20);
            this.txtHAO_MON_NAM.TabIndex = 11;
            this.txtHAO_MON_NAM.Visible = false;
            // 
            // LabelControl18
            // 
            this.LabelControl18.Location = new System.Drawing.Point(571, 156);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(65, 13);
            this.LabelControl18.TabIndex = 69;
            this.LabelControl18.Text = "Hao mòn năm";
            this.LabelControl18.Visible = false;
            // 
            // txtTYLE_KH_NHANH
            // 
            this.txtTYLE_KH_NHANH.EnterMoveNextControl = true;
            this.txtTYLE_KH_NHANH.Location = new System.Drawing.Point(653, 127);
            this.txtTYLE_KH_NHANH.Name = "txtTYLE_KH_NHANH";
            this.txtTYLE_KH_NHANH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTYLE_KH_NHANH.Size = new System.Drawing.Size(166, 20);
            this.txtTYLE_KH_NHANH.TabIndex = 10;
            this.txtTYLE_KH_NHANH.Visible = false;
            // 
            // LabelControl19
            // 
            this.LabelControl19.Location = new System.Drawing.Point(537, 134);
            this.LabelControl19.Name = "LabelControl19";
            this.LabelControl19.Size = new System.Drawing.Size(99, 13);
            this.LabelControl19.TabIndex = 70;
            this.LabelControl19.Text = "Tỉ lệ khấu hao nhanh";
            this.LabelControl19.Visible = false;
            // 
            // txtHE_SO_DIEU_CHINH
            // 
            this.txtHE_SO_DIEU_CHINH.EnterMoveNextControl = true;
            this.txtHE_SO_DIEU_CHINH.Location = new System.Drawing.Point(653, 101);
            this.txtHE_SO_DIEU_CHINH.Name = "txtHE_SO_DIEU_CHINH";
            this.txtHE_SO_DIEU_CHINH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHE_SO_DIEU_CHINH.Size = new System.Drawing.Size(166, 20);
            this.txtHE_SO_DIEU_CHINH.TabIndex = 9;
            this.txtHE_SO_DIEU_CHINH.Visible = false;
            // 
            // LabelControl20
            // 
            this.LabelControl20.Location = new System.Drawing.Point(558, 107);
            this.LabelControl20.Name = "LabelControl20";
            this.LabelControl20.Size = new System.Drawing.Size(78, 13);
            this.LabelControl20.TabIndex = 68;
            this.LabelControl20.Text = "Hệ số điều chỉnh";
            this.LabelControl20.Visible = false;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Location = new System.Drawing.Point(75, 126);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(66, 13);
            this.LabelControl22.TabIndex = 64;
            this.LabelControl22.Text = "Năm sản xuất";
            // 
            // txtNAM_SX1
            // 
            this.txtNAM_SX1.EnterMoveNextControl = true;
            this.txtNAM_SX1.Location = new System.Drawing.Point(158, 123);
            this.txtNAM_SX1.Name = "txtNAM_SX1";
            this.txtNAM_SX1.Properties.Mask.EditMask = "[0-9]{4}";
            this.txtNAM_SX1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNAM_SX1.Properties.Mask.ShowPlaceHolders = false;
            this.txtNAM_SX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNAM_SX1.Size = new System.Drawing.Size(166, 20);
            this.txtNAM_SX1.TabIndex = 4;
            // 
            // txtNUOC_SX
            // 
            this.txtNUOC_SX.EnterMoveNextControl = true;
            this.txtNUOC_SX.Location = new System.Drawing.Point(158, 97);
            this.txtNUOC_SX.Name = "txtNUOC_SX";
            this.txtNUOC_SX.Size = new System.Drawing.Size(166, 20);
            this.txtNUOC_SX.TabIndex = 3;
            // 
            // LabelControl21
            // 
            this.LabelControl21.Location = new System.Drawing.Point(71, 100);
            this.LabelControl21.Name = "LabelControl21";
            this.LabelControl21.Size = new System.Drawing.Size(70, 13);
            this.LabelControl21.TabIndex = 66;
            this.LabelControl21.Text = "Nước sản xuất";
            // 
            // txtTHONGSO_KYTHUAT
            // 
            this.txtTHONGSO_KYTHUAT.EnterMoveNextControl = true;
            this.txtTHONGSO_KYTHUAT.Location = new System.Drawing.Point(158, 71);
            this.txtTHONGSO_KYTHUAT.Name = "txtTHONGSO_KYTHUAT";
            this.txtTHONGSO_KYTHUAT.Size = new System.Drawing.Size(166, 20);
            this.txtTHONGSO_KYTHUAT.TabIndex = 2;
            // 
            // LabelControl24
            // 
            this.LabelControl24.Location = new System.Drawing.Point(54, 74);
            this.LabelControl24.Name = "LabelControl24";
            this.LabelControl24.Size = new System.Drawing.Size(87, 13);
            this.LabelControl24.TabIndex = 67;
            this.LabelControl24.Text = "Thông số kỹ thuật";
            // 
            // xtpPHU_TUNG_KEM_THEO
            // 
            this.xtpPHU_TUNG_KEM_THEO.Controls.Add(this.grcPHU_TUNG_KEM_THEO);
            this.xtpPHU_TUNG_KEM_THEO.Name = "xtpPHU_TUNG_KEM_THEO";
            this.xtpPHU_TUNG_KEM_THEO.Size = new System.Drawing.Size(844, 296);
            this.xtpPHU_TUNG_KEM_THEO.Text = "Phụ tùng kèm theo";
            // 
            // grcPHU_TUNG_KEM_THEO
            // 
            this.grcPHU_TUNG_KEM_THEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPHU_TUNG_KEM_THEO.Location = new System.Drawing.Point(0, 0);
            this.grcPHU_TUNG_KEM_THEO.MainView = this.grvPHU_TUNG_KEM_THEO;
            this.grcPHU_TUNG_KEM_THEO.Name = "grcPHU_TUNG_KEM_THEO";
            this.grcPHU_TUNG_KEM_THEO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboDVT,
            this.RepositoryItemPictureEdit1,
            this.btnDELETE_PHUTUNG,
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2,
            this.RepositoryItemTextEdit3,
            this.RepositoryItemTextEdit4,
            this.RepositoryItemTextEdit5,
            this.RepositoryItemTextEdit6,
            this.RepositoryItemTextEdit7});
            this.grcPHU_TUNG_KEM_THEO.Size = new System.Drawing.Size(844, 296);
            this.grcPHU_TUNG_KEM_THEO.TabIndex = 1;
            this.grcPHU_TUNG_KEM_THEO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPHU_TUNG_KEM_THEO});
            // 
            // grvPHU_TUNG_KEM_THEO
            // 
            this.grvPHU_TUNG_KEM_THEO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenPtung,
            this.TenDvt,
            this.SoLuong,
            this.SoTien,
            this.SoTienNte,
            this.QuyCach,
            this.DIEN_GIAI1});
            this.grvPHU_TUNG_KEM_THEO.GridControl = this.grcPHU_TUNG_KEM_THEO;
            this.grvPHU_TUNG_KEM_THEO.Name = "grvPHU_TUNG_KEM_THEO";
            this.grvPHU_TUNG_KEM_THEO.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvPHU_TUNG_KEM_THEO.OptionsView.ShowGroupPanel = false;
            // 
            // TenPtung
            // 
            this.TenPtung.Caption = "Tên phụ tùng";
            this.TenPtung.ColumnEdit = this.RepositoryItemTextEdit6;
            this.TenPtung.FieldName = "TenPtung";
            this.TenPtung.Name = "TenPtung";
            this.TenPtung.Visible = true;
            this.TenPtung.VisibleIndex = 0;
            // 
            // RepositoryItemTextEdit6
            // 
            this.RepositoryItemTextEdit6.AutoHeight = false;
            this.RepositoryItemTextEdit6.MaxLength = 128;
            this.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6";
            // 
            // TenDvt
            // 
            this.TenDvt.Caption = "Đơn vị tính";
            this.TenDvt.ColumnEdit = this.RepositoryItemTextEdit7;
            this.TenDvt.FieldName = "TenDvt";
            this.TenDvt.Name = "TenDvt";
            this.TenDvt.Visible = true;
            this.TenDvt.VisibleIndex = 1;
            // 
            // RepositoryItemTextEdit7
            // 
            this.RepositoryItemTextEdit7.AutoHeight = false;
            this.RepositoryItemTextEdit7.MaxLength = 128;
            this.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7";
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.ColumnEdit = this.RepositoryItemTextEdit1;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit1.MaxLength = 6;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // SoTien
            // 
            this.SoTien.Caption = "Tiền VND";
            this.SoTien.ColumnEdit = this.RepositoryItemTextEdit2;
            this.SoTien.FieldName = "SoTien";
            this.SoTien.Name = "SoTien";
            this.SoTien.Visible = true;
            this.SoTien.VisibleIndex = 3;
            // 
            // RepositoryItemTextEdit2
            // 
            this.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit2.AutoHeight = false;
            this.RepositoryItemTextEdit2.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit2.MaxLength = 18;
            this.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2";
            // 
            // SoTienNte
            // 
            this.SoTienNte.Caption = "Tiền ngoại tệ";
            this.SoTienNte.ColumnEdit = this.RepositoryItemTextEdit3;
            this.SoTienNte.FieldName = "SoTienNte";
            this.SoTienNte.Name = "SoTienNte";
            this.SoTienNte.Visible = true;
            this.SoTienNte.VisibleIndex = 4;
            // 
            // RepositoryItemTextEdit3
            // 
            this.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit3.AutoHeight = false;
            this.RepositoryItemTextEdit3.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit3.MaxLength = 18;
            this.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3";
            // 
            // QuyCach
            // 
            this.QuyCach.Caption = "Quy cách";
            this.QuyCach.ColumnEdit = this.RepositoryItemTextEdit4;
            this.QuyCach.FieldName = "QuyCach";
            this.QuyCach.Name = "QuyCach";
            this.QuyCach.Visible = true;
            this.QuyCach.VisibleIndex = 5;
            // 
            // RepositoryItemTextEdit4
            // 
            this.RepositoryItemTextEdit4.AutoHeight = false;
            this.RepositoryItemTextEdit4.MaxLength = 128;
            this.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4";
            // 
            // DIEN_GIAI1
            // 
            this.DIEN_GIAI1.Caption = "Diễn giải";
            this.DIEN_GIAI1.ColumnEdit = this.RepositoryItemTextEdit5;
            this.DIEN_GIAI1.FieldName = "DienGiai";
            this.DIEN_GIAI1.Name = "DIEN_GIAI1";
            this.DIEN_GIAI1.Visible = true;
            this.DIEN_GIAI1.VisibleIndex = 6;
            // 
            // RepositoryItemTextEdit5
            // 
            this.RepositoryItemTextEdit5.AutoHeight = false;
            this.RepositoryItemTextEdit5.MaxLength = 128;
            this.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5";
            // 
            // cboDVT
            // 
            this.cboDVT.AutoHeight = false;
            this.cboDVT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.NullText = "";
            // 
            // RepositoryItemPictureEdit1
            // 
            this.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1";
            // 
            // btnDELETE_PHUTUNG
            // 
            this.btnDELETE_PHUTUNG.AutoHeight = false;
            this.btnDELETE_PHUTUNG.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDELETE_PHUTUNG.Name = "btnDELETE_PHUTUNG";
            // 
            // grc_nguonVon
            // 
            this.grc_nguonVon.Controls.Add(this.Label1);
            this.grc_nguonVon.Controls.Add(this.grcNGUON_VON);
            this.grc_nguonVon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_nguonVon.Location = new System.Drawing.Point(4, 333);
            this.grc_nguonVon.Name = "grc_nguonVon";
            this.grc_nguonVon.Size = new System.Drawing.Size(851, 182);
            this.grc_nguonVon.TabIndex = 1;
            this.grc_nguonVon.Text = "Nguồn vốn";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(547, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(296, 13);
            this.Label1.TabIndex = 5006;
            this.Label1.Text = "Sử dụng phím tắt: F4 – Thêm dòng; F8 – Xóa dòng; F2 - Lưu";
            // 
            // grcNGUON_VON
            // 
            this.grcNGUON_VON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNGUON_VON.Location = new System.Drawing.Point(2, 22);
            this.grcNGUON_VON.MainView = this.grvNGUON_VON;
            this.grcNGUON_VON.Name = "grcNGUON_VON";
            this.grcNGUON_VON.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemTextEdit8,
            this.RepositoryItemTextEdit9});
            this.grcNGUON_VON.Size = new System.Drawing.Size(847, 158);
            this.grcNGUON_VON.TabIndex = 2;
            this.grcNGUON_VON.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNGUON_VON});
            // 
            // grvNGUON_VON
            // 
            this.grvNGUON_VON.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DM_NGUON_TSCD_ID,
            this.TenNguon,
            this.GridColumn2,
            this.GridColumn1,
            this.TkTaisan,
            this.TkKhauhao,
            this.MaTkChiphi,
            this.HeSoPbKh,
            this.NguyenGia,
            this.HaoMonLuyKe,
            this.GiaTriConLai,
            this.GridColumn3,
            this.DienGiai});
            this.grvNGUON_VON.GridControl = this.grcNGUON_VON;
            this.grvNGUON_VON.Name = "grvNGUON_VON";
            this.grvNGUON_VON.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvNGUON_VON.OptionsView.ColumnAutoWidth = false;
            this.grvNGUON_VON.OptionsView.ShowGroupPanel = false;
            // 
            // DM_NGUON_TSCD_ID
            // 
            this.DM_NGUON_TSCD_ID.Caption = "Nguồn";
            this.DM_NGUON_TSCD_ID.ColumnEdit = this.cboDM_NGUON_TSCD_ID;
            this.DM_NGUON_TSCD_ID.FieldName = "DmNguonTscdId";
            this.DM_NGUON_TSCD_ID.Name = "DM_NGUON_TSCD_ID";
            this.DM_NGUON_TSCD_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DM_NGUON_TSCD_ID.Visible = true;
            this.DM_NGUON_TSCD_ID.VisibleIndex = 0;
            this.DM_NGUON_TSCD_ID.Width = 82;
            // 
            // cboDM_NGUON_TSCD_ID
            // 
            this.cboDM_NGUON_TSCD_ID.AutoHeight = false;
            this.cboDM_NGUON_TSCD_ID.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboDM_NGUON_TSCD_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDM_NGUON_TSCD_ID.Name = "cboDM_NGUON_TSCD_ID";
            this.cboDM_NGUON_TSCD_ID.NullText = "";
            // 
            // TenNguon
            // 
            this.TenNguon.Caption = "Tên nguồn";
            this.TenNguon.FieldName = "TenNguon";
            this.TenNguon.Name = "TenNguon";
            this.TenNguon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.TenNguon.OptionsColumn.ReadOnly = true;
            this.TenNguon.Width = 241;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Ngày chứng từ";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn2.Width = 109;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Số chứng từ";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn1.Width = 110;
            // 
            // TkTaisan
            // 
            this.TkTaisan.Caption = "TK tài sản";
            this.TkTaisan.ColumnEdit = this.cboTK_TAISAN;
            this.TkTaisan.FieldName = "TkTaisan";
            this.TkTaisan.Name = "TkTaisan";
            this.TkTaisan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.TkTaisan.OptionsColumn.ReadOnly = true;
            this.TkTaisan.OptionsColumn.TabStop = false;
            this.TkTaisan.Width = 128;
            // 
            // cboTK_TAISAN
            // 
            this.cboTK_TAISAN.AutoHeight = false;
            this.cboTK_TAISAN.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_TAISAN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_TAISAN.Name = "cboTK_TAISAN";
            this.cboTK_TAISAN.NullText = "";
            // 
            // TkKhauhao
            // 
            this.TkKhauhao.Caption = "TK khấu hao";
            this.TkKhauhao.ColumnEdit = this.cboTK_KHAUHAO;
            this.TkKhauhao.FieldName = "TkKhauhao";
            this.TkKhauhao.Name = "TkKhauhao";
            this.TkKhauhao.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.TkKhauhao.OptionsColumn.ReadOnly = true;
            this.TkKhauhao.Width = 130;
            // 
            // cboTK_KHAUHAO
            // 
            this.cboTK_KHAUHAO.AutoHeight = false;
            this.cboTK_KHAUHAO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_KHAUHAO.Name = "cboTK_KHAUHAO";
            this.cboTK_KHAUHAO.NullText = "";
            // 
            // MaTkChiphi
            // 
            this.MaTkChiphi.Caption = "TK chi phí";
            this.MaTkChiphi.ColumnEdit = this.rpeTK_CHIPHI;
            this.MaTkChiphi.FieldName = "MaTkChiphi";
            this.MaTkChiphi.Name = "MaTkChiphi";
            this.MaTkChiphi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.MaTkChiphi.Visible = true;
            this.MaTkChiphi.VisibleIndex = 1;
            this.MaTkChiphi.Width = 144;
            // 
            // rpeTK_CHIPHI
            // 
            this.rpeTK_CHIPHI.AutoHeight = false;
            this.rpeTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpeTK_CHIPHI.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tk chi phí-80-1;TenTaikhoan-Tên tk chi phí-200-1;Id-Tkid-80-0";
            this.rpeTK_CHIPHI.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan";
            this.rpeTK_CHIPHI.C_DATA_SOURCE = null;
            this.rpeTK_CHIPHI.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.rpeTK_CHIPHI.C_FORM_TITLE = "Chọn tài khoản";
            this.rpeTK_CHIPHI.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.rpeTK_CHIPHI.C_IS_CHECK_OTHER = "=";
            this.rpeTK_CHIPHI.C_IS_CHECK_STRING = "=";
            this.rpeTK_CHIPHI.C_IS_CHI_TIET = "";
            this.rpeTK_CHIPHI.C_IS_FILTER_STRING = "";
            this.rpeTK_CHIPHI.C_IS_QUICKADD = false;
            this.rpeTK_CHIPHI.C_IS_SORT_ORDER_STRING = "";
            this.rpeTK_CHIPHI.C_KEY_NAME = "MaTaikhoan";
            this.rpeTK_CHIPHI.Editors = null;
            this.rpeTK_CHIPHI.EditValues = "";
            this.rpeTK_CHIPHI.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("rpeTK_CHIPHI.ListEditValues")));
            this.rpeTK_CHIPHI.Name = "rpeTK_CHIPHI";
            this.rpeTK_CHIPHI.NEXT_TAB = 0;
            this.rpeTK_CHIPHI.OBJ_CONDITITION = null;
            // 
            // HeSoPbKh
            // 
            this.HeSoPbKh.Caption = "Hệ số phân bổ";
            this.HeSoPbKh.ColumnEdit = this.RepositoryItemTextEdit9;
            this.HeSoPbKh.FieldName = "HeSoPbKh";
            this.HeSoPbKh.Name = "HeSoPbKh";
            this.HeSoPbKh.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.HeSoPbKh.Visible = true;
            this.HeSoPbKh.VisibleIndex = 2;
            this.HeSoPbKh.Width = 141;
            // 
            // RepositoryItemTextEdit9
            // 
            this.RepositoryItemTextEdit9.AutoHeight = false;
            this.RepositoryItemTextEdit9.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9";
            // 
            // NguyenGia
            // 
            this.NguyenGia.Caption = "Nguyên giá";
            this.NguyenGia.DisplayFormat.FormatString = "#,###0";
            this.NguyenGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NguyenGia.FieldName = "NguyenGia";
            this.NguyenGia.Name = "NguyenGia";
            this.NguyenGia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NguyenGia.Width = 108;
            // 
            // HaoMonLuyKe
            // 
            this.HaoMonLuyKe.Caption = "Giá trị đã khấu hao";
            this.HaoMonLuyKe.FieldName = "HaoMonLuyKe";
            this.HaoMonLuyKe.Name = "HaoMonLuyKe";
            this.HaoMonLuyKe.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.HaoMonLuyKe.Width = 119;
            // 
            // GiaTriConLai
            // 
            this.GiaTriConLai.Caption = "Giá trị còn lại";
            this.GiaTriConLai.FieldName = "GiaTriConLai";
            this.GiaTriConLai.Name = "GiaTriConLai";
            this.GiaTriConLai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.GiaTriConLai.Width = 110;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Giá trị KH 1 tháng";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn3.Width = 113;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn giải";
            this.DienGiai.ColumnEdit = this.RepositoryItemTextEdit8;
            this.DienGiai.FieldName = "DienGiai";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 3;
            this.DienGiai.Width = 302;
            // 
            // RepositoryItemTextEdit8
            // 
            this.RepositoryItemTextEdit8.AutoHeight = false;
            this.RepositoryItemTextEdit8.MaxLength = 256;
            this.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8";
            // 
            // cboTK_CHIPHI
            // 
            this.cboTK_CHIPHI.AutoHeight = false;
            this.cboTK_CHIPHI.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_CHIPHI.Name = "cboTK_CHIPHI";
            this.cboTK_CHIPHI.NullText = "";
            // 
            // cboLY_DO_TANGGIAM
            // 
            this.cboLY_DO_TANGGIAM.AutoHeight = false;
            this.cboLY_DO_TANGGIAM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLY_DO_TANGGIAM.Name = "cboLY_DO_TANGGIAM";
            this.cboLY_DO_TANGGIAM.NullText = "";
            // 
            // pfeTK_TAISAN
            // 
            this.pfeTK_TAISAN.AutoHeight = false;
            this.pfeTK_TAISAN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pfeTK_TAISAN.C_ARR_COLS_DISPLAY = "Id-Tài khoản ID-100-0;MaTaikhoan-Mã tài khoản-100-1;TenTaikhoan-Tên tài khoản-200" +
                "-1";
            this.pfeTK_TAISAN.C_ARR_COLS_RETURN = "Id;MaTaikhoan";
            this.pfeTK_TAISAN.C_DATA_SOURCE = null;
            this.pfeTK_TAISAN.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.pfeTK_TAISAN.C_FORM_TITLE = "Tìm kiếm tài khoản tài sản";
            this.pfeTK_TAISAN.C_IS_CHECK_NUMBER = "=";
            this.pfeTK_TAISAN.C_IS_CHECK_OTHER = "=";
            this.pfeTK_TAISAN.C_IS_CHECK_STRING = "=";
            this.pfeTK_TAISAN.C_IS_CHI_TIET = "";
            this.pfeTK_TAISAN.C_IS_FILTER_STRING = "";
            this.pfeTK_TAISAN.C_IS_QUICKADD = false;
            this.pfeTK_TAISAN.C_IS_SORT_ORDER_STRING = "";
            this.pfeTK_TAISAN.C_KEY_NAME = "MaTaikhoan";
            this.pfeTK_TAISAN.Editors = null;
            this.pfeTK_TAISAN.EditValues = "";
            this.pfeTK_TAISAN.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("pfeTK_TAISAN.ListEditValues")));
            this.pfeTK_TAISAN.Name = "pfeTK_TAISAN";
            this.pfeTK_TAISAN.NEXT_TAB = 0;
            this.pfeTK_TAISAN.OBJ_CONDITITION = null;
            // 
            // pfeTK_CHIPHI
            // 
            this.pfeTK_CHIPHI.AutoHeight = false;
            this.pfeTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pfeTK_CHIPHI.C_ARR_COLS_DISPLAY = "";
            this.pfeTK_CHIPHI.C_ARR_COLS_RETURN = "";
            this.pfeTK_CHIPHI.C_DATA_SOURCE = null;
            this.pfeTK_CHIPHI.C_FORM_DANHSACH = "";
            this.pfeTK_CHIPHI.C_FORM_TITLE = "";
            this.pfeTK_CHIPHI.C_IS_CHECK_NUMBER = "=";
            this.pfeTK_CHIPHI.C_IS_CHECK_OTHER = "=";
            this.pfeTK_CHIPHI.C_IS_CHECK_STRING = "=";
            this.pfeTK_CHIPHI.C_IS_CHI_TIET = "";
            this.pfeTK_CHIPHI.C_IS_FILTER_STRING = "";
            this.pfeTK_CHIPHI.C_IS_QUICKADD = false;
            this.pfeTK_CHIPHI.C_IS_SORT_ORDER_STRING = "";
            this.pfeTK_CHIPHI.C_KEY_NAME = "";
            this.pfeTK_CHIPHI.Editors = null;
            this.pfeTK_CHIPHI.EditValues = "";
            this.pfeTK_CHIPHI.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("pfeTK_CHIPHI.ListEditValues")));
            this.pfeTK_CHIPHI.Name = "pfeTK_CHIPHI";
            this.pfeTK_CHIPHI.NEXT_TAB = 0;
            this.pfeTK_CHIPHI.OBJ_CONDITITION = null;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnPrint);
            this.PanelControl2.Controls.Add(this.btnQuit);
            this.PanelControl2.Controls.Add(this.btnQuiss);
            this.PanelControl2.Controls.Add(this.btnClear);
            this.PanelControl2.Controls.Add(this.btnRow);
            this.PanelControl2.Controls.Add(this.btnDeRow);
            this.PanelControl2.Controls.Add(this.btnSave);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(4, 519);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(851, 34);
            this.PanelControl2.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(86, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "In thẻ";
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.ImageIndex = 8;
            this.btnQuit.Location = new System.Drawing.Point(769, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "&Quay ra";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnQuiss
            // 
            this.btnQuiss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuiss.ImageIndex = 8;
            this.btnQuiss.Location = new System.Drawing.Point(919, 4);
            this.btnQuiss.Name = "btnQuiss";
            this.btnQuiss.Size = new System.Drawing.Size(80, 30);
            this.btnQuiss.TabIndex = 6;
            this.btnQuiss.Text = "&Quay ra";
            // 
            // btnClear
            // 
            this.btnClear.ImageIndex = 2;
            this.btnClear.Location = new System.Drawing.Point(344, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Xóa &trắng";
            this.btnClear.Visible = false;
            // 
            // btnRow
            // 
            this.btnRow.ImageIndex = 2;
            this.btnRow.Location = new System.Drawing.Point(172, 3);
            this.btnRow.Name = "btnRow";
            this.btnRow.Size = new System.Drawing.Size(80, 30);
            this.btnRow.TabIndex = 2;
            this.btnRow.Text = "&Thêm dòng";
            this.btnRow.Visible = false;
            // 
            // btnDeRow
            // 
            this.btnDeRow.ImageIndex = 3;
            this.btnDeRow.Location = new System.Drawing.Point(258, 3);
            this.btnDeRow.Name = "btnDeRow";
            this.btnDeRow.Size = new System.Drawing.Size(80, 30);
            this.btnDeRow.TabIndex = 3;
            this.btnDeRow.Text = "&Xóa dòng";
            this.btnDeRow.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(4, 329);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(851, 4);
            this.PanelControl1.TabIndex = 3;
            // 
            // PanelControl4
            // 
            this.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl4.Location = new System.Drawing.Point(4, 515);
            this.PanelControl4.Name = "PanelControl4";
            this.PanelControl4.Size = new System.Drawing.Size(851, 4);
            this.PanelControl4.TabIndex = 7;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmThongTinTSCD_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(859, 557);
            this.Controls.Add(this.grc_nguonVon);
            this.Controls.Add(this.PanelControl4);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.xtpMain);
            this.KeyPreview = true;
            this.Name = "frmThongTinTSCD_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Thông tin tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)(this.xtpMain)).EndInit();
            this.xtpMain.ResumeLayout(false);
            this.xtpTHONG_TIN_CHINH.ResumeLayout(false);
            this.xtpTHONG_TIN_CHINH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_TSCD_1)).EndInit();
            this.pn_TSCD_1.ResumeLayout(false);
            this.pn_TSCD_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlPHONGBAN_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLyDoTang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKChiPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKKhauHao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTKTaiSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKY_HIEU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN_TSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_TSCD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLYDO_TANGGIAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_CHIPHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlDVT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_KHAUHAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlMD_TK_TS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLOAITAISAN_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlNHOM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_TSCD_2)).EndInit();
            this.pn_TSCD_2.ResumeLayout(false);
            this.pn_TSCD_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_TANG1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_TANG1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_BDSD1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_BDSD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_MUA1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_MUA1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KTKH1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KTKH1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_BDKH1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtxNGAY_BDKH1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_THANG_SD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_CT_TSCD)).EndInit();
            this.pn_CT_TSCD.ResumeLayout(false);
            this.pn_CT_TSCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTY_LE_HAOMON1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUYEN_GIA1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAM_TRON_SO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_LUONG1.Properties)).EndInit();
            this.xtpTHONG_TIN_BO_XUNG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grc_PTKT)).EndInit();
            this.grc_PTKT.ResumeLayout(false);
            this.grc_PTKT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHIPHI_DV_SD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHIPHI_MUA1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLOAI_PP_KH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSANLUONG_CONGSUAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL_NTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LK_NTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_NAM_NTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_NAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTYLE_KH_NHANH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHE_SO_DIEU_CHINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAM_SX1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNUOC_SX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHONGSO_KYTHUAT.Properties)).EndInit();
            this.xtpPHU_TUNG_KEM_THEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPHU_TUNG_KEM_THEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPHU_TUNG_KEM_THEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDELETE_PHUTUNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_nguonVon)).EndInit();
            this.grc_nguonVon.ResumeLayout(false);
            this.grc_nguonVon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_KHAUHAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfeTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfeTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraTab.XtraTabControl xtpMain;
        internal DevExpress.XtraTab.XtraTabPage xtpTHONG_TIN_CHINH;
        internal DevExpress.XtraTab.XtraTabPage xtpTHONG_TIN_BO_XUNG;
        internal DevExpress.XtraEditors.GroupControl grc_nguonVon;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnQuiss;
        internal DevExpress.XtraEditors.SimpleButton btnClear;
        internal DevExpress.XtraEditors.SimpleButton btnRow;
        internal DevExpress.XtraEditors.SimpleButton btnDeRow;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnQuit;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraTab.XtraTabPage xtpPHU_TUNG_KEM_THEO;
        internal DevExpress.XtraGrid.GridControl grcNGUON_VON;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvNGUON_VON;
        internal DevExpress.XtraGrid.Columns.GridColumn DM_NGUON_TSCD_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDM_NGUON_TSCD_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn NGUYEN_GIA;
        internal DevExpress.XtraGrid.Columns.GridColumn HAO_MON_LUY_KE;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_TRI_CON_LAI;
        internal DevExpress.XtraGrid.Columns.GridColumn DIEN_GIAI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboLY_DO_TANGGIAM;
        internal DevExpress.XtraGrid.GridControl grcPHU_TUNG_KEM_THEO;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvPHU_TUNG_KEM_THEO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_PTUNG;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_DVT;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDVT;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_LUONG;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_NTE;
        internal DevExpress.XtraGrid.Columns.GridColumn QUY_CACH;
        internal DevExpress.XtraGrid.Columns.GridColumn DIEN_GIAI1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit RepositoryItemPictureEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDELETE_PHUTUNG;
        internal DevExpress.XtraEditors.GroupControl grc_PTKT;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLOAI_PP_KH;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView10;
        internal DevExpress.XtraEditors.LabelControl LabelControl27;
        internal DevExpress.XtraEditors.TextEdit txtSANLUONG_CONGSUAT;
        internal DevExpress.XtraEditors.LabelControl LabelControl26;
        internal DevExpress.XtraEditors.TextEdit txtGIA_TRI_CL_NTE;
        internal DevExpress.XtraEditors.LabelControl LabelControl25;
        internal DevExpress.XtraEditors.TextEdit txtHAO_MON_LK_NTE;
        internal DevExpress.XtraEditors.LabelControl LabelControl28;
        internal DevExpress.XtraEditors.TextEdit txtHAO_MON_NAM_NTE;
        internal DevExpress.XtraEditors.LabelControl LabelControl30;
        internal DevExpress.XtraEditors.TextEdit txtHAO_MON_NAM;
        internal DevExpress.XtraEditors.LabelControl LabelControl18;
        internal DevExpress.XtraEditors.TextEdit txtTYLE_KH_NHANH;
        internal DevExpress.XtraEditors.LabelControl LabelControl19;
        internal DevExpress.XtraEditors.TextEdit txtHE_SO_DIEU_CHINH;
        internal DevExpress.XtraEditors.LabelControl LabelControl20;
        internal DevExpress.XtraEditors.LabelControl LabelControl22;
        internal DevExpress.XtraEditors.TextEdit txtNUOC_SX;
        internal DevExpress.XtraEditors.LabelControl LabelControl21;
        internal DevExpress.XtraEditors.TextEdit txtTHONGSO_KYTHUAT;
        internal DevExpress.XtraEditors.LabelControl LabelControl24;
        internal DevExpress.XtraEditors.PanelControl PanelControl4;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraEditors.TextEdit txtNAM_SX1;
        internal DevExpress.XtraEditors.PanelControl pn_TSCD_1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNHOM2;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlPHONGBAN_ID;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView9;
        internal DevExpress.XtraEditors.TextEdit txtTenLyDoTang;
        internal DevExpress.XtraEditors.TextEdit txtTenTaiSan;
        internal DevExpress.XtraEditors.TextEdit txtKY_HIEU;
        internal DevExpress.XtraEditors.TextEdit txtTEN_TSCD;
        internal DevExpress.XtraEditors.TextEdit txtMA_TSCD1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLYDO_TANGGIAM;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView7;
        internal DevExpress.XtraEditors.LabelControl LabelControl17;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.GridLookUpEdit grlDVT_ID;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView8;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNHOM3;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal DevExpress.XtraEditors.LabelControl LabelControl15;
        internal DevExpress.XtraEditors.LabelControl LabelControl14;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLOAITAISAN_ID;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        internal DevExpress.XtraEditors.GridLookUpEdit grlNHOM1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.PanelControl pn_TSCD_2;
        internal DevExpress.XtraEditors.LabelControl LabelControl33;
        internal DevExpress.XtraEditors.LabelControl LabelControl31;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_BDSD1;
        internal DevExpress.XtraEditors.DateEdit dtxNGAY_MUA1;
        internal DevExpress.XtraEditors.DateEdit dtxNGAY_BDKH1;
        internal DevExpress.XtraEditors.LabelControl LabelControl10;
        internal DevExpress.XtraEditors.LabelControl LabelControl9;
        internal DevExpress.XtraEditors.TextEdit txtSO_LUONG1;
        internal DevExpress.XtraEditors.TextEdit txtLAM_TRON_SO;
        internal DevExpress.XtraEditors.TextEdit txtSO_THANG_SD1;
        internal DevExpress.XtraEditors.LabelControl LabelControl13;
        internal DevExpress.XtraEditors.LabelControl LabelControl12;
        internal DevExpress.XtraEditors.LabelControl LabelControl11;
        internal DevExpress.XtraEditors.PanelControl pn_CT_TSCD;
        internal DevExpress.XtraEditors.TextEdit txtTY_LE_HAOMON1;
        internal DevExpress.XtraEditors.LabelControl LabelControl48;
        internal DevExpress.XtraEditors.TextEdit txtGIA_TRI_CL1;
        internal DevExpress.XtraEditors.LabelControl LabelControl16;
        internal DevExpress.XtraEditors.TextEdit txtNGUYEN_GIA1;
        internal DevExpress.XtraEditors.LabelControl LabelControl34;
        internal DevExpress.XtraEditors.TextEdit txtHAO_MON_LK;
        internal DevExpress.XtraEditors.LabelControl LabelControl29;
        internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraEditors.LabelControl LabelControl23;
        internal DevExpress.XtraEditors.TextEdit txtSO_CT;
        internal DevExpress.XtraEditors.LabelControl LabelControl35;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_CT;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraGrid.Columns.GridColumn TK_TAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_CHIPHI;
        internal DevExpress.XtraGrid.Columns.GridColumn HE_SO_PB_KH;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_TAISAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_CHIPHI;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_TANG1;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit pfeTK_TAISAN;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit pfeTK_CHIPHI;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_KTKH1;
        internal DevExpress.XtraEditors.LabelControl lbl;
        internal DevExpress.XtraEditors.TextEdit txtCHIPHI_DV_SD1;
        internal DevExpress.XtraEditors.LabelControl LabelControl36;
        internal DevExpress.XtraEditors.TextEdit txtCHIPHI_MUA1;
        internal DevExpress.XtraEditors.LabelControl LabelControl32;
        internal DevExpress.XtraGrid.Columns.GridColumn TK_KHAUHAO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_KHAUHAO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_NGUON;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeTK_CHIPHI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit6;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit7;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit5;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit8;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit9;
        internal DevExpress.XtraGrid.Columns.GridColumn TenPtung;
        internal DevExpress.XtraGrid.Columns.GridColumn TenDvt;
        internal DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        internal DevExpress.XtraGrid.Columns.GridColumn SoTien;
        internal DevExpress.XtraGrid.Columns.GridColumn SoTienNte;
        internal DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        internal DevExpress.XtraGrid.Columns.GridColumn TenNguon;
        internal DevExpress.XtraGrid.Columns.GridColumn TkTaisan;
        internal DevExpress.XtraGrid.Columns.GridColumn TkKhauhao;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTkChiphi;
        internal DevExpress.XtraGrid.Columns.GridColumn HeSoPbKh;
        internal DevExpress.XtraGrid.Columns.GridColumn NguyenGia;
        internal DevExpress.XtraGrid.Columns.GridColumn HaoMonLuyKe;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaTriConLai;
        internal DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        internal DevExpress.XtraEditors.TextEdit txtTenTKChiPhi;
        internal DevExpress.XtraEditors.TextEdit txtTenTKKhauHao;
        internal DevExpress.XtraEditors.TextEdit txtTenTKTaiSan;
        internal DevExpress.XtraEditors.GridLookUpEdit grlMD_TK_CHIPHI;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView6;
        internal DevExpress.XtraEditors.GridLookUpEdit grlMD_TK_KHAUHAO;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView5;
        internal DevExpress.XtraEditors.GridLookUpEdit grlMD_TK_TS;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        
    }
}