using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmPhieuNhapKho_ChiTiet : DevExpress.XtraEditors.XtraForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapKho_ChiTiet));
            Vns.Erp.Core.ValueInfo valueInfo1 = new Vns.Erp.Core.ValueInfo();
            this.cboMaHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMaKho = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboMakhoxuat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spdSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.RepositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.RepositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.cboTKno = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboVuViec = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTKco = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboPTQT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTudo1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTudo2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTudo3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTudo4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTudo5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboPhongban = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboKhoanphi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboHopdong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.C_SoChungTu_RP = new Vns.Erp.Core.Controls.UserControl.C_SoChungTu();
            this.GFilter_TK = new Vns.Erp.Core.CustomFilter();
            this.lblTK = new DevExpress.XtraEditors.LabelControl();
            this.dteHDPN = new DevExpress.XtraEditors.DateEdit();
            this.lblNgayHDPN = new DevExpress.XtraEditors.LabelControl();
            this.txtHDPN = new DevExpress.XtraEditors.TextEdit();
            this.lblHDPN = new DevExpress.XtraEditors.LabelControl();
            this.grlLoaiPhieuNhap = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteNGAY_CT = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_GHI = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDIA_CHI = new DevExpress.XtraEditors.TextEdit();
            this.txtNGUOI_GIAO_NHAN_HANG = new DevExpress.XtraEditors.TextEdit();
            this.txtDIEN_GIAI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcPhieuPhapKho = new DevExpress.XtraGrid.GridControl();
            this.grvPhieuNhapKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GFilterEdit_HANGHOA_ID = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.TenHanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoNhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoXuatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DonGiaVonNte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GiaVonNt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DonGiaVon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GiaVon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MaTknGiavon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gfilter_MA_TKN_GIAVON = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.VuviecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTkcGiavon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gfilter_MA_TKC_GIAVON = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.IdDmPtqtCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmTudo1Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmTudo2Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmTudo3Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmTudo4Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmTudo5Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmPhongbanCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmKhoanphiCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDmHopdongCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLenhSxXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLenhSxXuat = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLenhSxNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLenhSxNhap = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanXuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPhanXuongNhap = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanXuongXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPhanXuongXuat = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemAlignment1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.depCT_H_Nx = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.GroupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.grcLPN_Hnx = new DevExpress.XtraGrid.GridControl();
            this.grvLPX_Hnx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CtSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayGhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ghi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTongSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.navWelding1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnSea = new DevExpress.XtraEditors.SimpleButton();
            this.btnCan = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnMod = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQui = new DevExpress.XtraEditors.SimpleButton();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSav = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UR_STATUS = new Vns.Erp.Core.Controls.UserControl.Status_LoaiCT();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMakhoxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVuViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPTQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoanphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHopdong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteHDPN.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteHDPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHDPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIA_CHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUOI_GIAO_NHAN_HANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIEN_GIAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuPhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GFilterEdit_HANGHOA_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_MA_TKN_GIAVON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_MA_TKC_GIAVON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemAlignment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depCT_H_Nx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl4)).BeginInit();
            this.GroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).BeginInit();
            this.GroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaHang
            // 
            this.cboMaHang.AutoHeight = false;
            this.cboMaHang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMaHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.NullText = "";
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
            // cboMaKho
            // 
            this.cboMaKho.AutoHeight = false;
            this.cboMaKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMaKho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.NullText = "";
            // 
            // cboMakhoxuat
            // 
            this.cboMakhoxuat.AutoHeight = false;
            this.cboMakhoxuat.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMakhoxuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMakhoxuat.Name = "cboMakhoxuat";
            this.cboMakhoxuat.NullText = "";
            // 
            // spdSoLuong
            // 
            this.spdSoLuong.AutoHeight = false;
            this.spdSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spdSoLuong.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.spdSoLuong.Name = "spdSoLuong";
            // 
            // RepositoryItemSpinEdit1
            // 
            this.RepositoryItemSpinEdit1.AutoHeight = false;
            this.RepositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.RepositoryItemSpinEdit1.Mask.EditMask = "n2";
            this.RepositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1";
            // 
            // RepositoryItemSpinEdit2
            // 
            this.RepositoryItemSpinEdit2.AutoHeight = false;
            this.RepositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.RepositoryItemSpinEdit2.Mask.EditMask = "n2";
            this.RepositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2";
            // 
            // cboTKno
            // 
            this.cboTKno.AutoHeight = false;
            this.cboTKno.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTKno.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTKno.Name = "cboTKno";
            this.cboTKno.NullText = "";
            // 
            // cboVuViec
            // 
            this.cboVuViec.AutoHeight = false;
            this.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboVuViec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVuViec.Name = "cboVuViec";
            this.cboVuViec.NullText = "";
            // 
            // cboTKco
            // 
            this.cboTKco.AutoHeight = false;
            this.cboTKco.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTKco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTKco.Name = "cboTKco";
            this.cboTKco.NullText = "";
            // 
            // cboPTQT
            // 
            this.cboPTQT.AutoHeight = false;
            this.cboPTQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboPTQT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPTQT.Name = "cboPTQT";
            this.cboPTQT.NullText = "";
            // 
            // cboTudo1
            // 
            this.cboTudo1.AutoHeight = false;
            this.cboTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTudo1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTudo1.Name = "cboTudo1";
            this.cboTudo1.NullText = "";
            // 
            // cboTudo2
            // 
            this.cboTudo2.AutoHeight = false;
            this.cboTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTudo2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTudo2.Name = "cboTudo2";
            this.cboTudo2.NullText = "";
            // 
            // cboTudo3
            // 
            this.cboTudo3.AutoHeight = false;
            this.cboTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTudo3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTudo3.Name = "cboTudo3";
            this.cboTudo3.NullText = "";
            // 
            // cboTudo4
            // 
            this.cboTudo4.AutoHeight = false;
            this.cboTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTudo4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTudo4.Name = "cboTudo4";
            this.cboTudo4.NullText = "";
            // 
            // cboTudo5
            // 
            this.cboTudo5.AutoHeight = false;
            this.cboTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTudo5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTudo5.Name = "cboTudo5";
            this.cboTudo5.NullText = "";
            // 
            // cboPhongban
            // 
            this.cboPhongban.AutoHeight = false;
            this.cboPhongban.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboPhongban.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.NullText = "";
            // 
            // cboKhoanphi
            // 
            this.cboKhoanphi.AutoHeight = false;
            this.cboKhoanphi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboKhoanphi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoanphi.Name = "cboKhoanphi";
            this.cboKhoanphi.NullText = "";
            // 
            // cboHopdong
            // 
            this.cboHopdong.AutoHeight = false;
            this.cboHopdong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboHopdong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHopdong.Name = "cboHopdong";
            this.cboHopdong.NullText = "";
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.C_SoChungTu_RP);
            this.GroupControl1.Controls.Add(this.GFilter_TK);
            this.GroupControl1.Controls.Add(this.lblTK);
            this.GroupControl1.Controls.Add(this.dteHDPN);
            this.GroupControl1.Controls.Add(this.lblNgayHDPN);
            this.GroupControl1.Controls.Add(this.txtHDPN);
            this.GroupControl1.Controls.Add(this.lblHDPN);
            this.GroupControl1.Controls.Add(this.grlLoaiPhieuNhap);
            this.GroupControl1.Controls.Add(this.dteNGAY_CT);
            this.GroupControl1.Controls.Add(this.dteNGAY_GHI);
            this.GroupControl1.Controls.Add(this.labelControl11);
            this.GroupControl1.Controls.Add(this.labelControl10);
            this.GroupControl1.Controls.Add(this.labelControl9);
            this.GroupControl1.Controls.Add(this.txtDIA_CHI);
            this.GroupControl1.Controls.Add(this.txtNGUOI_GIAO_NHAN_HANG);
            this.GroupControl1.Controls.Add(this.txtDIEN_GIAI);
            this.GroupControl1.Controls.Add(this.labelControl33);
            this.GroupControl1.Controls.Add(this.labelControl5);
            this.GroupControl1.Controls.Add(this.labelControl3);
            this.GroupControl1.Controls.Add(this.labelControl1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.ShowCaption = false;
            this.GroupControl1.Size = new System.Drawing.Size(801, 118);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "GroupControl1";
            // 
            // C_SoChungTu_RP
            // 
            this.C_SoChungTu_RP.Enabled = false;
            this.C_SoChungTu_RP.HtLoaichungtuService = null;
            this.C_SoChungTu_RP.Location = new System.Drawing.Point(72, 83);
            this.C_SoChungTu_RP.Name = "C_SoChungTu_RP";
            this.C_SoChungTu_RP.PREFIX = null;
            this.C_SoChungTu_RP.Size = new System.Drawing.Size(100, 20);
            this.C_SoChungTu_RP.SO_CHUNG_TU = null;
            this.C_SoChungTu_RP.TabIndex = 3;
            // 
            // GFilter_TK
            // 
            this.GFilter_TK.AllowNull = true;
            this.GFilter_TK.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.GFilter_TK.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.GFilter_TK.C_DATA_SOURCE = null;
            this.GFilter_TK.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.GFilter_TK.C_FORM_TITLE = "Chọn tài khoản";
            this.GFilter_TK.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.GFilter_TK.C_IS_CHECK_OTHER = "=";
            this.GFilter_TK.C_IS_CHECK_STRING = "=";
            this.GFilter_TK.C_IS_FILTER_STRING = "";
            this.GFilter_TK.C_IS_QUICKADD = false;
            this.GFilter_TK.C_IS_SORT_ORDER_STRING = "";
            this.GFilter_TK.C_KEY_NAME = "MaTaikhoan";
            this.GFilter_TK.EditValue = "";
            this.GFilter_TK.EditValues = "";
            this.GFilter_TK.ENABLES = true;
            this.GFilter_TK.IsNotTextChanged = true;
            this.GFilter_TK.ListEditValue = ((System.Collections.Generic.List<string>)(resources.GetObject("GFilter_TK.ListEditValue")));
            this.GFilter_TK.Location = new System.Drawing.Point(285, 83);
            this.GFilter_TK.MessageWarning = "Giá trị không hợp lệ";
            this.GFilter_TK.Name = "GFilter_TK";
            this.GFilter_TK.NEXT_TAB = 0;
            this.GFilter_TK.Size = new System.Drawing.Size(100, 20);
            this.GFilter_TK.TabIndex = 4;
            this.GFilter_TK.Visible = false;
            this.GFilter_TK.AfterFilter += new Vns.Erp.Core.CustomFilter.FilterCustomEventHandler(this.GFilter_TK_AfterFilter);
            this.GFilter_TK.ClearFilterData += new Vns.Erp.Core.CustomFilter.FilterCustomEventHandler(this.GFilter_TK_ClearFilterData);
            this.GFilter_TK.FirstBinddata += new Vns.Erp.Core.CustomFilter.FilterCustomEventHandler(this.GFilter_TK_FirstBinddata);
            // 
            // lblTK
            // 
            this.lblTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTK.Location = new System.Drawing.Point(237, 86);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(30, 13);
            this.lblTK.TabIndex = 99;
            this.lblTK.Text = "Ghi nợ";
            this.lblTK.Visible = false;
            // 
            // dteHDPN
            // 
            this.dteHDPN.EditValue = null;
            this.dteHDPN.EnterMoveNextControl = true;
            this.dteHDPN.Location = new System.Drawing.Point(703, 31);
            this.dteHDPN.Name = "dteHDPN";
            this.dteHDPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteHDPN.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteHDPN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteHDPN.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteHDPN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteHDPN.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteHDPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteHDPN.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteHDPN.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteHDPN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dteHDPN.Size = new System.Drawing.Size(92, 20);
            this.dteHDPN.TabIndex = 14;
            this.dteHDPN.Visible = false;
            // 
            // lblNgayHDPN
            // 
            this.lblNgayHDPN.Location = new System.Drawing.Point(628, 34);
            this.lblNgayHDPN.Name = "lblNgayHDPN";
            this.lblNgayHDPN.Size = new System.Drawing.Size(60, 13);
            this.lblNgayHDPN.TabIndex = 93;
            this.lblNgayHDPN.Text = "Ngày HĐ/PN";
            this.lblNgayHDPN.Visible = false;
            // 
            // txtHDPN
            // 
            this.txtHDPN.EnterMoveNextControl = true;
            this.txtHDPN.Location = new System.Drawing.Point(703, 5);
            this.txtHDPN.Name = "txtHDPN";
            this.txtHDPN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHDPN.Size = new System.Drawing.Size(92, 20);
            this.txtHDPN.TabIndex = 13;
            this.txtHDPN.Visible = false;
            // 
            // lblHDPN
            // 
            this.lblHDPN.Location = new System.Drawing.Point(639, 8);
            this.lblHDPN.Name = "lblHDPN";
            this.lblHDPN.Size = new System.Drawing.Size(49, 13);
            this.lblHDPN.TabIndex = 88;
            this.lblHDPN.Text = " HĐ/PN số";
            this.lblHDPN.Visible = false;
            // 
            // grlLoaiPhieuNhap
            // 
            this.grlLoaiPhieuNhap.EnterMoveNextControl = true;
            this.grlLoaiPhieuNhap.Location = new System.Drawing.Point(72, 5);
            this.grlLoaiPhieuNhap.Name = "grlLoaiPhieuNhap";
            this.grlLoaiPhieuNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLoaiPhieuNhap.Properties.NullText = "";
            this.grlLoaiPhieuNhap.Properties.ReadOnly = true;
            this.grlLoaiPhieuNhap.Properties.View = this.GridView2;
            this.grlLoaiPhieuNhap.Size = new System.Drawing.Size(100, 20);
            this.grlLoaiPhieuNhap.TabIndex = 0;
            // 
            // GridView2
            // 
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn2,
            this.GridColumn3});
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Ký hiệu";
            this.GridColumn2.FieldName = "KyHieu";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 0;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Tên loại chứng từ";
            this.GridColumn3.FieldName = "TenLoaiCt";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 1;
            // 
            // dteNGAY_CT
            // 
            this.dteNGAY_CT.EditValue = null;
            this.dteNGAY_CT.EnterMoveNextControl = true;
            this.dteNGAY_CT.Location = new System.Drawing.Point(72, 31);
            this.dteNGAY_CT.Name = "dteNGAY_CT";
            this.dteNGAY_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_CT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_CT.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_CT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNGAY_CT.Properties.MaxValue = new System.DateTime(2088, 1, 5, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.MinValue = new System.DateTime(1988, 1, 5, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_CT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dteNGAY_CT.Size = new System.Drawing.Size(100, 20);
            this.dteNGAY_CT.TabIndex = 1;
            this.dteNGAY_CT.EditValueChanged += new System.EventHandler(this.dteNGAY_CT_EditValueChanged);
            // 
            // dteNGAY_GHI
            // 
            this.dteNGAY_GHI.EditValue = null;
            this.dteNGAY_GHI.EnterMoveNextControl = true;
            this.dteNGAY_GHI.Location = new System.Drawing.Point(72, 57);
            this.dteNGAY_GHI.Name = "dteNGAY_GHI";
            this.dteNGAY_GHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_GHI.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_GHI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNGAY_GHI.Properties.MaxValue = new System.DateTime(2088, 1, 5, 0, 0, 0, 0);
            this.dteNGAY_GHI.Properties.MinValue = new System.DateTime(1988, 1, 5, 0, 0, 0, 0);
            this.dteNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_GHI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dteNGAY_GHI.Size = new System.Drawing.Size(100, 20);
            this.dteNGAY_GHI.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(29, 86);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 13);
            this.labelControl11.TabIndex = 84;
            this.labelControl11.Text = "Số CT";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 34);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 13);
            this.labelControl10.TabIndex = 83;
            this.labelControl10.Text = "Ngày CT";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 60);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 82;
            this.labelControl9.Text = "Ngày HT";
            // 
            // txtDIA_CHI
            // 
            this.txtDIA_CHI.EnterMoveNextControl = true;
            this.txtDIA_CHI.Location = new System.Drawing.Point(285, 5);
            this.txtDIA_CHI.Name = "txtDIA_CHI";
            this.txtDIA_CHI.Properties.MaxLength = 256;
            this.txtDIA_CHI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDIA_CHI.Size = new System.Drawing.Size(331, 20);
            this.txtDIA_CHI.TabIndex = 8;
            // 
            // txtNGUOI_GIAO_NHAN_HANG
            // 
            this.txtNGUOI_GIAO_NHAN_HANG.EnterMoveNextControl = true;
            this.txtNGUOI_GIAO_NHAN_HANG.Location = new System.Drawing.Point(285, 31);
            this.txtNGUOI_GIAO_NHAN_HANG.Name = "txtNGUOI_GIAO_NHAN_HANG";
            this.txtNGUOI_GIAO_NHAN_HANG.Properties.MaxLength = 128;
            this.txtNGUOI_GIAO_NHAN_HANG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNGUOI_GIAO_NHAN_HANG.Size = new System.Drawing.Size(331, 20);
            this.txtNGUOI_GIAO_NHAN_HANG.TabIndex = 9;
            // 
            // txtDIEN_GIAI
            // 
            this.txtDIEN_GIAI.EnterMoveNextControl = true;
            this.txtDIEN_GIAI.Location = new System.Drawing.Point(285, 57);
            this.txtDIEN_GIAI.Name = "txtDIEN_GIAI";
            this.txtDIEN_GIAI.Properties.MaxLength = 256;
            this.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDIEN_GIAI.Size = new System.Drawing.Size(331, 20);
            this.txtDIEN_GIAI.TabIndex = 10;
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(230, 60);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(40, 13);
            this.labelControl33.TabIndex = 73;
            this.labelControl33.Text = "Diễn giải";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(191, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 13);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Người giao/nhận";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(238, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 70;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Loại CT";
            // 
            // GroupControl2
            // 
            this.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GroupControl2.Controls.Add(this.grcPhieuPhapKho);
            this.GroupControl2.Controls.Add(this.PanelControl1);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(0, 118);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.ShowCaption = false;
            this.GroupControl2.Size = new System.Drawing.Size(801, 417);
            this.GroupControl2.TabIndex = 1;
            this.GroupControl2.Text = "GroupControl2";
            // 
            // grcPhieuPhapKho
            // 
            this.grcPhieuPhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPhieuPhapKho.Location = new System.Drawing.Point(0, 21);
            this.grcPhieuPhapKho.MainView = this.grvPhieuNhapKho;
            this.grcPhieuPhapKho.Name = "grcPhieuPhapKho";
            this.grcPhieuPhapKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemAlignment1,
            this.GFilterEdit_HANGHOA_ID,
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2,
            this.RepositoryItemTextEdit3,
            this.RepositoryItemTextEdit4,
            this.Gfilter_MA_TKN_GIAVON,
            this.Gfilter_MA_TKC_GIAVON,
            this.RepositoryItemTextEdit5,
            this.RepositoryItemTextEdit6,
            this.cboLenhSxNhap,
            this.cboLenhSxXuat,
            this.cboPhanXuongNhap,
            this.cboPhanXuongXuat});
            this.grcPhieuPhapKho.Size = new System.Drawing.Size(801, 396);
            this.grcPhieuPhapKho.TabIndex = 1;
            this.grcPhieuPhapKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuNhapKho});
            // 
            // grvPhieuNhapKho
            // 
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.Empty.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvPhieuNhapKho.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvPhieuNhapKho.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuNhapKho.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.grvPhieuNhapKho.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuNhapKho.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvPhieuNhapKho.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvPhieuNhapKho.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuNhapKho.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuNhapKho.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuNhapKho.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuNhapKho.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuNhapKho.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuNhapKho.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.grvPhieuNhapKho.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvPhieuNhapKho.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvPhieuNhapKho.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuNhapKho.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.OddRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Appearance.OddRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.grvPhieuNhapKho.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.grvPhieuNhapKho.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvPhieuNhapKho.Appearance.Preview.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.Preview.Options.UseFont = true;
            this.grvPhieuNhapKho.Appearance.Preview.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.Row.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.Row.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuNhapKho.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.grvPhieuNhapKho.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuNhapKho.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvPhieuNhapKho.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvPhieuNhapKho.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvPhieuNhapKho.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuNhapKho.Appearance.VertLine.Options.UseBackColor = true;
            this.grvPhieuNhapKho.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvPhieuNhapKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HanghoaId,
            this.TenHanghoa,
            this.TenDvt,
            this.ViTri,
            this.KhoNhapId,
            this.KhoXuatId,
            this.TonKho,
            this.SoLuong,
            this.DonGiaVonNte,
            this.GiaVonNt,
            this.DonGiaVon,
            this.GiaVon,
            this.MaTknGiavon,
            this.VuviecId,
            this.MaTkcGiavon,
            this.IdDmPtqtCo,
            this.IdDmTudo1Co,
            this.IdDmTudo2Co,
            this.IdDmTudo3Co,
            this.IdDmTudo4Co,
            this.IdDmTudo5Co,
            this.IdDmPhongbanCo,
            this.IdDmKhoanphiCo,
            this.IdDmHopdongCo,
            this.colLenhSxXuat,
            this.colLenhSxNhap,
            this.colPhanXuongNhap,
            this.colPhanXuongXuat,
            this.gridColumn17});
            this.grvPhieuNhapKho.GridControl = this.grcPhieuPhapKho;
            this.grvPhieuNhapKho.Name = "grvPhieuNhapKho";
            this.grvPhieuNhapKho.OptionsNavigation.AutoFocusNewRow = true;
            this.grvPhieuNhapKho.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvPhieuNhapKho.OptionsView.ColumnAutoWidth = false;
            this.grvPhieuNhapKho.OptionsView.EnableAppearanceEvenRow = true;
            this.grvPhieuNhapKho.OptionsView.EnableAppearanceOddRow = true;
            this.grvPhieuNhapKho.OptionsView.ShowGroupPanel = false;
            this.grvPhieuNhapKho.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvPhieuNhapKho_CellValueChanged);
            this.grvPhieuNhapKho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvPhieuNhapKho_KeyDown);
            // 
            // HanghoaId
            // 
            this.HanghoaId.Caption = " Mã hàng ";
            this.HanghoaId.ColumnEdit = this.GFilterEdit_HANGHOA_ID;
            this.HanghoaId.FieldName = "KyHieuHanghoa";
            this.HanghoaId.Name = "HanghoaId";
            this.HanghoaId.Visible = true;
            this.HanghoaId.VisibleIndex = 0;
            this.HanghoaId.Width = 130;
            // 
            // GFilterEdit_HANGHOA_ID
            // 
            this.GFilterEdit_HANGHOA_ID.AutoHeight = false;
            this.GFilterEdit_HANGHOA_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" +
                "nDvt--80-0;ViTri--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0";
            this.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban;MdTkKho;ViTri" +
                "";
            this.GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = null;
            this.GFilterEdit_HANGHOA_ID.C_FORM_DANHSACH = "frmDanhMucHangHoa_DanhSach";
            this.GFilterEdit_HANGHOA_ID.C_FORM_TITLE = "Chọn hàng hóa";
            this.GFilterEdit_HANGHOA_ID.C_IS_CHECK_NUMBER = "=";
            this.GFilterEdit_HANGHOA_ID.C_IS_CHECK_OTHER = "=";
            this.GFilterEdit_HANGHOA_ID.C_IS_CHECK_STRING = "=";
            this.GFilterEdit_HANGHOA_ID.C_IS_CHI_TIET = "";
            this.GFilterEdit_HANGHOA_ID.C_IS_FILTER_STRING = "";
            this.GFilterEdit_HANGHOA_ID.C_IS_QUICKADD = true;
            this.GFilterEdit_HANGHOA_ID.C_IS_SORT_ORDER_STRING = "";
            this.GFilterEdit_HANGHOA_ID.C_KEY_NAME = "KyHieu";
            this.GFilterEdit_HANGHOA_ID.Editors = null;
            this.GFilterEdit_HANGHOA_ID.EditValues = "";
            this.GFilterEdit_HANGHOA_ID.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("GFilterEdit_HANGHOA_ID.ListEditValues")));
            this.GFilterEdit_HANGHOA_ID.Name = "GFilterEdit_HANGHOA_ID";
            this.GFilterEdit_HANGHOA_ID.NEXT_TAB = 0;
            this.GFilterEdit_HANGHOA_ID.OBJ_CONDITITION = null;
            this.GFilterEdit_HANGHOA_ID.AfterFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_AfterFilter);
            this.GFilterEdit_HANGHOA_ID.ClearDataFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_ClearFilter);
            this.GFilterEdit_HANGHOA_ID.FisrtBinddata += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilterEdit_HANGHOA_ID_FisrtBinddata);
            // 
            // TenHanghoa
            // 
            this.TenHanghoa.Caption = "Tên hàng / Vật tư";
            this.TenHanghoa.FieldName = "TenHanghoa";
            this.TenHanghoa.Name = "TenHanghoa";
            this.TenHanghoa.OptionsColumn.ReadOnly = true;
            this.TenHanghoa.Visible = true;
            this.TenHanghoa.VisibleIndex = 1;
            this.TenHanghoa.Width = 120;
            // 
            // TenDvt
            // 
            this.TenDvt.Caption = "ĐVT";
            this.TenDvt.FieldName = "TenDvt";
            this.TenDvt.Name = "TenDvt";
            this.TenDvt.OptionsColumn.ReadOnly = true;
            this.TenDvt.Visible = true;
            this.TenDvt.VisibleIndex = 2;
            this.TenDvt.Width = 70;
            // 
            // ViTri
            // 
            this.ViTri.Caption = "Vị trí";
            this.ViTri.FieldName = "ViTri";
            this.ViTri.Name = "ViTri";
            this.ViTri.Visible = true;
            this.ViTri.VisibleIndex = 3;
            // 
            // KhoNhapId
            // 
            this.KhoNhapId.Caption = "Mã kho nhập";
            this.KhoNhapId.ColumnEdit = this.cboMaKho;
            this.KhoNhapId.FieldName = "KhoNhapId";
            this.KhoNhapId.Name = "KhoNhapId";
            this.KhoNhapId.Visible = true;
            this.KhoNhapId.VisibleIndex = 4;
            this.KhoNhapId.Width = 100;
            // 
            // KhoXuatId
            // 
            this.KhoXuatId.Caption = "Mã kho xuất";
            this.KhoXuatId.ColumnEdit = this.cboMakhoxuat;
            this.KhoXuatId.FieldName = "KhoXuatId";
            this.KhoXuatId.Name = "KhoXuatId";
            this.KhoXuatId.Visible = true;
            this.KhoXuatId.VisibleIndex = 5;
            this.KhoXuatId.Width = 100;
            // 
            // TonKho
            // 
            this.TonKho.Caption = "Tồn kho";
            this.TonKho.ColumnEdit = this.RepositoryItemTextEdit6;
            this.TonKho.FieldName = "TonKho";
            this.TonKho.Name = "TonKho";
            this.TonKho.OptionsColumn.ReadOnly = true;
            this.TonKho.Visible = true;
            this.TonKho.VisibleIndex = 6;
            // 
            // RepositoryItemTextEdit6
            // 
            this.RepositoryItemTextEdit6.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit6.AutoHeight = false;
            this.RepositoryItemTextEdit6.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6";
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.ColumnEdit = this.RepositoryItemTextEdit5;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 7;
            this.SoLuong.Width = 70;
            // 
            // RepositoryItemTextEdit5
            // 
            this.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit5.AutoHeight = false;
            this.RepositoryItemTextEdit5.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5";
            // 
            // DonGiaVonNte
            // 
            this.DonGiaVonNte.AppearanceCell.Options.UseTextOptions = true;
            this.DonGiaVonNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DonGiaVonNte.Caption = "Giá NTE";
            this.DonGiaVonNte.ColumnEdit = this.RepositoryItemTextEdit1;
            this.DonGiaVonNte.FieldName = "DonGiaVonNte";
            this.DonGiaVonNte.Name = "DonGiaVonNte";
            this.DonGiaVonNte.Visible = true;
            this.DonGiaVonNte.VisibleIndex = 8;
            this.DonGiaVonNte.Width = 70;
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // GiaVonNt
            // 
            this.GiaVonNt.AppearanceCell.Options.UseTextOptions = true;
            this.GiaVonNt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GiaVonNt.Caption = "Tiền NTE";
            this.GiaVonNt.ColumnEdit = this.RepositoryItemTextEdit2;
            this.GiaVonNt.FieldName = "GiaVonNt";
            this.GiaVonNt.Name = "GiaVonNt";
            this.GiaVonNt.Visible = true;
            this.GiaVonNt.VisibleIndex = 9;
            this.GiaVonNt.Width = 70;
            // 
            // RepositoryItemTextEdit2
            // 
            this.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit2.AutoHeight = false;
            this.RepositoryItemTextEdit2.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2";
            // 
            // DonGiaVon
            // 
            this.DonGiaVon.AppearanceCell.Options.UseTextOptions = true;
            this.DonGiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DonGiaVon.Caption = "Đơn giá";
            this.DonGiaVon.ColumnEdit = this.RepositoryItemTextEdit4;
            this.DonGiaVon.DisplayFormat.FormatString = "#,###0";
            this.DonGiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaVon.FieldName = "DonGiaVon";
            this.DonGiaVon.Name = "DonGiaVon";
            this.DonGiaVon.Visible = true;
            this.DonGiaVon.VisibleIndex = 10;
            this.DonGiaVon.Width = 100;
            // 
            // RepositoryItemTextEdit4
            // 
            this.RepositoryItemTextEdit4.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit4.AutoHeight = false;
            this.RepositoryItemTextEdit4.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4";
            // 
            // GiaVon
            // 
            this.GiaVon.AppearanceCell.Options.UseTextOptions = true;
            this.GiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GiaVon.Caption = "Tổng tiền";
            this.GiaVon.ColumnEdit = this.RepositoryItemTextEdit3;
            this.GiaVon.DisplayFormat.FormatString = "#,###0";
            this.GiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaVon.FieldName = "GiaVon";
            this.GiaVon.Name = "GiaVon";
            this.GiaVon.OptionsColumn.ReadOnly = true;
            this.GiaVon.Visible = true;
            this.GiaVon.VisibleIndex = 11;
            this.GiaVon.Width = 120;
            // 
            // RepositoryItemTextEdit3
            // 
            this.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit3.AutoHeight = false;
            this.RepositoryItemTextEdit3.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3";
            // 
            // MaTknGiavon
            // 
            this.MaTknGiavon.Caption = "TK nợ";
            this.MaTknGiavon.ColumnEdit = this.Gfilter_MA_TKN_GIAVON;
            this.MaTknGiavon.FieldName = "MaTknGiavon";
            this.MaTknGiavon.Name = "MaTknGiavon";
            this.MaTknGiavon.Visible = true;
            this.MaTknGiavon.VisibleIndex = 12;
            this.MaTknGiavon.Width = 120;
            // 
            // Gfilter_MA_TKN_GIAVON
            // 
            this.Gfilter_MA_TKN_GIAVON.AutoHeight = false;
            this.Gfilter_MA_TKN_GIAVON.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Gfilter_MA_TKN_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.Gfilter_MA_TKN_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = null;
            this.Gfilter_MA_TKN_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.Gfilter_MA_TKN_GIAVON.C_FORM_TITLE = "Chọn tài khoản";
            this.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_OTHER = "=";
            this.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_STRING = "=";
            this.Gfilter_MA_TKN_GIAVON.C_IS_CHI_TIET = "";
            this.Gfilter_MA_TKN_GIAVON.C_IS_FILTER_STRING = "";
            this.Gfilter_MA_TKN_GIAVON.C_IS_QUICKADD = false;
            this.Gfilter_MA_TKN_GIAVON.C_IS_SORT_ORDER_STRING = "";
            this.Gfilter_MA_TKN_GIAVON.C_KEY_NAME = "MaTaikhoan";
            this.Gfilter_MA_TKN_GIAVON.Editors = null;
            this.Gfilter_MA_TKN_GIAVON.EditValues = "";
            this.Gfilter_MA_TKN_GIAVON.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("Gfilter_MA_TKN_GIAVON.ListEditValues")));
            this.Gfilter_MA_TKN_GIAVON.Name = "Gfilter_MA_TKN_GIAVON";
            this.Gfilter_MA_TKN_GIAVON.NEXT_TAB = 0;
            this.Gfilter_MA_TKN_GIAVON.OBJ_CONDITITION = null;
            this.Gfilter_MA_TKN_GIAVON.AfterFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_AfterFilter);
            this.Gfilter_MA_TKN_GIAVON.ClearDataFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_ClearFilter);
            this.Gfilter_MA_TKN_GIAVON.FisrtBinddata += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.Gfilter_MA_TKN_GIAVON_FisrtBinddata);
            // 
            // VuviecId
            // 
            this.VuviecId.Caption = "Vụ việc";
            this.VuviecId.ColumnEdit = this.cboVuViec;
            this.VuviecId.FieldName = "VuviecId";
            this.VuviecId.Name = "VuviecId";
            this.VuviecId.Visible = true;
            this.VuviecId.VisibleIndex = 13;
            this.VuviecId.Width = 120;
            // 
            // MaTkcGiavon
            // 
            this.MaTkcGiavon.Caption = "Tk có";
            this.MaTkcGiavon.ColumnEdit = this.Gfilter_MA_TKC_GIAVON;
            this.MaTkcGiavon.FieldName = "MaTkcGiavon";
            this.MaTkcGiavon.Name = "MaTkcGiavon";
            this.MaTkcGiavon.Visible = true;
            this.MaTkcGiavon.VisibleIndex = 14;
            this.MaTkcGiavon.Width = 120;
            // 
            // Gfilter_MA_TKC_GIAVON
            // 
            this.Gfilter_MA_TKC_GIAVON.AutoHeight = false;
            this.Gfilter_MA_TKC_GIAVON.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Gfilter_MA_TKC_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.Gfilter_MA_TKC_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = null;
            this.Gfilter_MA_TKC_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.Gfilter_MA_TKC_GIAVON.C_FORM_TITLE = "Chọn tài khoản";
            this.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_OTHER = "=";
            this.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_STRING = "=";
            this.Gfilter_MA_TKC_GIAVON.C_IS_CHI_TIET = "";
            this.Gfilter_MA_TKC_GIAVON.C_IS_FILTER_STRING = "";
            this.Gfilter_MA_TKC_GIAVON.C_IS_QUICKADD = false;
            this.Gfilter_MA_TKC_GIAVON.C_IS_SORT_ORDER_STRING = "";
            this.Gfilter_MA_TKC_GIAVON.C_KEY_NAME = "MaTaikhoan";
            this.Gfilter_MA_TKC_GIAVON.Editors = null;
            this.Gfilter_MA_TKC_GIAVON.EditValues = "";
            this.Gfilter_MA_TKC_GIAVON.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("Gfilter_MA_TKC_GIAVON.ListEditValues")));
            this.Gfilter_MA_TKC_GIAVON.Name = "Gfilter_MA_TKC_GIAVON";
            this.Gfilter_MA_TKC_GIAVON.NEXT_TAB = 0;
            this.Gfilter_MA_TKC_GIAVON.OBJ_CONDITITION = null;
            this.Gfilter_MA_TKC_GIAVON.AfterFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_AfterFilter);
            this.Gfilter_MA_TKC_GIAVON.ClearDataFilter += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.GFilter_HANGHOA_ID_ClearFilter);
            this.Gfilter_MA_TKC_GIAVON.FisrtBinddata += new Vns.Erp.Core.RepositoryItemPopupFilterEdit.FilterCustomEventHandler(this.Gfilter_MA_TKN_GIAVON_FisrtBinddata);
            // 
            // IdDmPtqtCo
            // 
            this.IdDmPtqtCo.Caption = "PTQT";
            this.IdDmPtqtCo.ColumnEdit = this.cboPTQT;
            this.IdDmPtqtCo.FieldName = "IdDmPtqtCo";
            this.IdDmPtqtCo.Name = "IdDmPtqtCo";
            this.IdDmPtqtCo.Visible = true;
            this.IdDmPtqtCo.VisibleIndex = 15;
            // 
            // IdDmTudo1Co
            // 
            this.IdDmTudo1Co.Caption = "DM Tự do 1";
            this.IdDmTudo1Co.ColumnEdit = this.cboTudo1;
            this.IdDmTudo1Co.FieldName = "IdDmTudo1Co";
            this.IdDmTudo1Co.Name = "IdDmTudo1Co";
            this.IdDmTudo1Co.Visible = true;
            this.IdDmTudo1Co.VisibleIndex = 16;
            // 
            // IdDmTudo2Co
            // 
            this.IdDmTudo2Co.Caption = "DM Tự do 2";
            this.IdDmTudo2Co.ColumnEdit = this.cboTudo2;
            this.IdDmTudo2Co.FieldName = "IdDmTudo2Co";
            this.IdDmTudo2Co.Name = "IdDmTudo2Co";
            this.IdDmTudo2Co.Visible = true;
            this.IdDmTudo2Co.VisibleIndex = 17;
            // 
            // IdDmTudo3Co
            // 
            this.IdDmTudo3Co.Caption = "DM Tự do 3";
            this.IdDmTudo3Co.ColumnEdit = this.cboTudo3;
            this.IdDmTudo3Co.FieldName = "IdDmTudo3Co";
            this.IdDmTudo3Co.Name = "IdDmTudo3Co";
            this.IdDmTudo3Co.Visible = true;
            this.IdDmTudo3Co.VisibleIndex = 18;
            // 
            // IdDmTudo4Co
            // 
            this.IdDmTudo4Co.Caption = "DM Tự do 4";
            this.IdDmTudo4Co.ColumnEdit = this.cboTudo4;
            this.IdDmTudo4Co.FieldName = "IdDmTudo4Co";
            this.IdDmTudo4Co.Name = "IdDmTudo4Co";
            this.IdDmTudo4Co.Visible = true;
            this.IdDmTudo4Co.VisibleIndex = 19;
            // 
            // IdDmTudo5Co
            // 
            this.IdDmTudo5Co.Caption = "DM Tự do 5";
            this.IdDmTudo5Co.ColumnEdit = this.cboTudo5;
            this.IdDmTudo5Co.FieldName = "IdDmTudo5Co";
            this.IdDmTudo5Co.Name = "IdDmTudo5Co";
            this.IdDmTudo5Co.Visible = true;
            this.IdDmTudo5Co.VisibleIndex = 20;
            // 
            // IdDmPhongbanCo
            // 
            this.IdDmPhongbanCo.Caption = "DM Phòng ban";
            this.IdDmPhongbanCo.ColumnEdit = this.cboPhongban;
            this.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo";
            this.IdDmPhongbanCo.Name = "IdDmPhongbanCo";
            this.IdDmPhongbanCo.Visible = true;
            this.IdDmPhongbanCo.VisibleIndex = 21;
            // 
            // IdDmKhoanphiCo
            // 
            this.IdDmKhoanphiCo.Caption = "DM Khoản phí";
            this.IdDmKhoanphiCo.ColumnEdit = this.cboKhoanphi;
            this.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo";
            this.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo";
            this.IdDmKhoanphiCo.Visible = true;
            this.IdDmKhoanphiCo.VisibleIndex = 22;
            // 
            // IdDmHopdongCo
            // 
            this.IdDmHopdongCo.Caption = "DM Hợp đồng";
            this.IdDmHopdongCo.ColumnEdit = this.cboHopdong;
            this.IdDmHopdongCo.FieldName = "IdDmHopdongCo";
            this.IdDmHopdongCo.Name = "IdDmHopdongCo";
            this.IdDmHopdongCo.Visible = true;
            this.IdDmHopdongCo.VisibleIndex = 23;
            // 
            // colLenhSxXuat
            // 
            this.colLenhSxXuat.Caption = "Lệnh sản xuất";
            this.colLenhSxXuat.ColumnEdit = this.cboLenhSxXuat;
            this.colLenhSxXuat.FieldName = "LenhSanXuatXuatId";
            this.colLenhSxXuat.Name = "colLenhSxXuat";
            this.colLenhSxXuat.Visible = true;
            this.colLenhSxXuat.VisibleIndex = 24;
            this.colLenhSxXuat.Width = 101;
            // 
            // cboLenhSxXuat
            // 
            this.cboLenhSxXuat.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboLenhSxXuat.AutoHeight = false;
            this.cboLenhSxXuat.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboLenhSxXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSxXuat.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSxXuat.ImmediatePopup = true;
            this.cboLenhSxXuat.Name = "cboLenhSxXuat";
            this.cboLenhSxXuat.NullText = "";
            this.cboLenhSxXuat.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSxXuat.ValueMember = "Id";
            this.cboLenhSxXuat.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn15,
            this.gridColumn18});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit2View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn15, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày tạo lệnh";
            this.gridColumn4.FieldName = "NgayGiaoLenh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số lệnh sản xuất";
            this.gridColumn1.FieldName = "SoLenhSanXuat";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Tổ, phân xưởng";
            this.gridColumn15.FieldName = "MaToSanXuat";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Mô tả";
            this.gridColumn18.FieldName = "MoTa";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 3;
            // 
            // colLenhSxNhap
            // 
            this.colLenhSxNhap.Caption = "Lệnh sản xuất";
            this.colLenhSxNhap.ColumnEdit = this.cboLenhSxNhap;
            this.colLenhSxNhap.FieldName = "LenhSanXuatNhapId";
            this.colLenhSxNhap.Name = "colLenhSxNhap";
            this.colLenhSxNhap.Visible = true;
            this.colLenhSxNhap.VisibleIndex = 25;
            this.colLenhSxNhap.Width = 102;
            // 
            // cboLenhSxNhap
            // 
            this.cboLenhSxNhap.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboLenhSxNhap.AutoHeight = false;
            this.cboLenhSxNhap.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboLenhSxNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSxNhap.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSxNhap.ImmediatePopup = true;
            this.cboLenhSxNhap.Name = "cboLenhSxNhap";
            this.cboLenhSxNhap.NullText = "";
            this.cboLenhSxNhap.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSxNhap.ValueMember = "Id";
            this.cboLenhSxNhap.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn16,
            this.gridColumn19});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn16, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn10, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ngày tạo lệnh";
            this.gridColumn9.FieldName = "NgayGiaoLenh";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số lệnh sản xuất";
            this.gridColumn10.FieldName = "SoLenhSanXuat";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Tổ, phân xưởng";
            this.gridColumn16.FieldName = "MaToSanXuat";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 2;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Mô tả";
            this.gridColumn19.FieldName = "MoTa";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            // 
            // colPhanXuongNhap
            // 
            this.colPhanXuongNhap.Caption = "Phân xưởng";
            this.colPhanXuongNhap.ColumnEdit = this.cboPhanXuongNhap;
            this.colPhanXuongNhap.FieldName = "PhanXuongNhapId";
            this.colPhanXuongNhap.Name = "colPhanXuongNhap";
            this.colPhanXuongNhap.Visible = true;
            this.colPhanXuongNhap.VisibleIndex = 26;
            // 
            // cboPhanXuongNhap
            // 
            this.cboPhanXuongNhap.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboPhanXuongNhap.AutoHeight = false;
            this.cboPhanXuongNhap.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboPhanXuongNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhanXuongNhap.DisplayMember = "KyHieu";
            this.cboPhanXuongNhap.ImmediatePopup = true;
            this.cboPhanXuongNhap.Name = "cboPhanXuongNhap";
            this.cboPhanXuongNhap.NullText = "";
            this.cboPhanXuongNhap.ValueMember = "Id";
            this.cboPhanXuongNhap.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Mã phân xưởng";
            this.gridColumn11.FieldName = "KyHieu";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tên phân xưởng";
            this.gridColumn12.FieldName = "TenPhongban";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // colPhanXuongXuat
            // 
            this.colPhanXuongXuat.Caption = "Phân xưởng";
            this.colPhanXuongXuat.ColumnEdit = this.cboPhanXuongXuat;
            this.colPhanXuongXuat.FieldName = "PhanXuongXuatId";
            this.colPhanXuongXuat.Name = "colPhanXuongXuat";
            this.colPhanXuongXuat.Visible = true;
            this.colPhanXuongXuat.VisibleIndex = 27;
            // 
            // cboPhanXuongXuat
            // 
            this.cboPhanXuongXuat.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboPhanXuongXuat.AutoHeight = false;
            this.cboPhanXuongXuat.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboPhanXuongXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhanXuongXuat.DisplayMember = "KyHieu";
            this.cboPhanXuongXuat.ImmediatePopup = true;
            this.cboPhanXuongXuat.Name = "cboPhanXuongXuat";
            this.cboPhanXuongXuat.NullText = "";
            this.cboPhanXuongXuat.ValueMember = "Id";
            this.cboPhanXuongXuat.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Mã phòng ban";
            this.gridColumn13.FieldName = "KyHieu";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Tên phòng ban";
            this.gridColumn14.FieldName = "TenPhongban";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn17.Caption = "Nội dung";
            this.gridColumn17.FieldName = "NoiDung";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 28;
            this.gridColumn17.Width = 307;
            // 
            // RepositoryItemAlignment1
            // 
            this.RepositoryItemAlignment1.AutoHeight = false;
            this.RepositoryItemAlignment1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemAlignment1.Name = "RepositoryItemAlignment1";
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.LabelControl4);
            this.PanelControl1.Controls.Add(this.CheckEdit1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(801, 21);
            this.PanelControl1.TabIndex = 0;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl4.Location = new System.Drawing.Point(386, 2);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(342, 13);
            this.LabelControl4.TabIndex = 1;
            this.LabelControl4.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán";
            // 
            // CheckEdit1
            // 
            this.CheckEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckEdit1.Location = new System.Drawing.Point(2, 2);
            this.CheckEdit1.Name = "CheckEdit1";
            this.CheckEdit1.Properties.Caption = "Nhập theo giá TB cho VT tính giá TB                                              " +
                "                                             ";
            this.CheckEdit1.Size = new System.Drawing.Size(229, 19);
            this.CheckEdit1.TabIndex = 0;
            this.CheckEdit1.Visible = false;
            this.CheckEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEdit1_KeyDown);
            // 
            // depCT_H_Nx
            // 
            this.depCT_H_Nx.ContainerControl = this;
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(4, 4);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.GroupControl4);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.GroupControl2);
            this.SplitContainerControl1.Panel2.Controls.Add(this.GroupControl3);
            this.SplitContainerControl1.Panel2.Controls.Add(this.GroupControl1);
            this.SplitContainerControl1.Panel2.MinSize = 800;
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(1000, 571);
            this.SplitContainerControl1.SplitterPosition = 194;
            this.SplitContainerControl1.TabIndex = 0;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // GroupControl4
            // 
            this.GroupControl4.Controls.Add(this.grcLPN_Hnx);
            this.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl4.Location = new System.Drawing.Point(0, 0);
            this.GroupControl4.Name = "GroupControl4";
            this.GroupControl4.Size = new System.Drawing.Size(194, 571);
            this.GroupControl4.TabIndex = 0;
            this.GroupControl4.Text = "Danh sách...";
            // 
            // grcLPN_Hnx
            // 
            this.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLPN_Hnx.Location = new System.Drawing.Point(2, 22);
            this.grcLPN_Hnx.MainView = this.grvLPX_Hnx;
            this.grcLPN_Hnx.Name = "grcLPN_Hnx";
            this.grcLPN_Hnx.Size = new System.Drawing.Size(190, 547);
            this.grcLPN_Hnx.TabIndex = 0;
            this.grcLPN_Hnx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLPX_Hnx});
            // 
            // grvLPX_Hnx
            // 
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.Empty.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvLPX_Hnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvLPX_Hnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvLPX_Hnx.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.grvLPX_Hnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvLPX_Hnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvLPX_Hnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvLPX_Hnx.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvLPX_Hnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvLPX_Hnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvLPX_Hnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvLPX_Hnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvLPX_Hnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvLPX_Hnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.grvLPX_Hnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvLPX_Hnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvLPX_Hnx.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.OddRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Appearance.OddRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.grvLPX_Hnx.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.grvLPX_Hnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvLPX_Hnx.Appearance.Preview.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.Preview.Options.UseFont = true;
            this.grvLPX_Hnx.Appearance.Preview.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.Row.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.Row.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvLPX_Hnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.grvLPX_Hnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvLPX_Hnx.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvLPX_Hnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvLPX_Hnx.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvLPX_Hnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvLPX_Hnx.Appearance.VertLine.Options.UseBackColor = true;
            this.grvLPX_Hnx.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvLPX_Hnx.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CtSo,
            this.NgayCt,
            this.NgayGhi,
            this.Ghi});
            this.grvLPX_Hnx.GridControl = this.grcLPN_Hnx;
            this.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvLPX_Hnx.Name = "grvLPX_Hnx";
            this.grvLPX_Hnx.OptionsBehavior.Editable = false;
            this.grvLPX_Hnx.OptionsView.ColumnAutoWidth = false;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = true;
            this.grvLPX_Hnx.OptionsView.ShowGroupPanel = false;
            this.grvLPX_Hnx.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvLPX_Hnx_FocusedRowChanged);
            // 
            // CtSo
            // 
            this.CtSo.Caption = "Số chứng từ";
            this.CtSo.FieldName = "CtSo";
            this.CtSo.Name = "CtSo";
            this.CtSo.Visible = true;
            this.CtSo.VisibleIndex = 1;
            this.CtSo.Width = 114;
            // 
            // NgayCt
            // 
            this.NgayCt.Caption = "Ngày chứng từ";
            this.NgayCt.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayCt.FieldName = "NgayCt";
            this.NgayCt.Name = "NgayCt";
            this.NgayCt.Visible = true;
            this.NgayCt.VisibleIndex = 3;
            this.NgayCt.Width = 117;
            // 
            // NgayGhi
            // 
            this.NgayGhi.Caption = "Ngày hạch toán";
            this.NgayGhi.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayGhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayGhi.FieldName = "NgayGhi";
            this.NgayGhi.Name = "NgayGhi";
            this.NgayGhi.Visible = true;
            this.NgayGhi.VisibleIndex = 2;
            this.NgayGhi.Width = 112;
            // 
            // Ghi
            // 
            this.Ghi.Caption = "Trạng thái";
            this.Ghi.FieldName = "Ghi";
            this.Ghi.Name = "Ghi";
            this.Ghi.Visible = true;
            this.Ghi.VisibleIndex = 0;
            // 
            // GroupControl3
            // 
            this.GroupControl3.Controls.Add(this.txtTongSoLuong);
            this.GroupControl3.Controls.Add(this.LabelControl6);
            this.GroupControl3.Controls.Add(this.TxtTongTien);
            this.GroupControl3.Controls.Add(this.labelControl22);
            this.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl3.Location = new System.Drawing.Point(0, 535);
            this.GroupControl3.Name = "GroupControl3";
            this.GroupControl3.ShowCaption = false;
            this.GroupControl3.Size = new System.Drawing.Size(801, 36);
            this.GroupControl3.TabIndex = 2;
            this.GroupControl3.Text = "GroupControl3";
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Location = new System.Drawing.Point(410, 7);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongSoLuong.Properties.Mask.EditMask = "n2";
            this.txtTongSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongSoLuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTongSoLuong.Properties.ReadOnly = true;
            this.txtTongSoLuong.Size = new System.Drawing.Size(138, 20);
            this.txtTongSoLuong.TabIndex = 1;
            this.txtTongSoLuong.TabStop = false;
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(326, 10);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(68, 13);
            this.LabelControl6.TabIndex = 66;
            this.LabelControl6.Text = "Tổng số lượng";
            // 
            // TxtTongTien
            // 
            this.TxtTongTien.Location = new System.Drawing.Point(633, 6);
            this.TxtTongTien.Name = "TxtTongTien";
            this.TxtTongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTongTien.Properties.Mask.EditMask = "n0";
            this.TxtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtTongTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtTongTien.Properties.ReadOnly = true;
            this.TxtTongTien.Size = new System.Drawing.Size(149, 20);
            this.TxtTongTien.TabIndex = 2;
            this.TxtTongTien.TabStop = false;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(571, 9);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(45, 13);
            this.labelControl22.TabIndex = 2;
            this.labelControl22.Text = "Tổng tiền";
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.navWelding1);
            this.PanelControl2.Controls.Add(this.btnSea);
            this.PanelControl2.Controls.Add(this.btnCan);
            this.PanelControl2.Controls.Add(this.btnAdd);
            this.PanelControl2.Controls.Add(this.btnMod);
            this.PanelControl2.Controls.Add(this.btnDel);
            this.PanelControl2.Controls.Add(this.btnQui);
            this.PanelControl2.Controls.Add(this.btnPri);
            this.PanelControl2.Controls.Add(this.btnSav);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(4, 575);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(1000, 30);
            this.PanelControl2.TabIndex = 1;
            // 
            // navWelding1
            // 
            this.navWelding1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navWelding1.Buttons.Append.Visible = false;
            this.navWelding1.Buttons.CancelEdit.Visible = false;
            this.navWelding1.Buttons.Edit.Visible = false;
            this.navWelding1.Buttons.EndEdit.Visible = false;
            this.navWelding1.Buttons.NextPage.Visible = false;
            this.navWelding1.Buttons.PrevPage.Visible = false;
            this.navWelding1.Buttons.Remove.Visible = false;
            this.navWelding1.Location = new System.Drawing.Point(0, 0);
            this.navWelding1.Name = "navWelding1";
            this.navWelding1.NavigatableControl = this.grcLPN_Hnx;
            this.navWelding1.Size = new System.Drawing.Size(194, 30);
            this.navWelding1.TabIndex = 1;
            this.navWelding1.Text = "ControlNavigator4";
            this.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.navWelding1.TextStringFormat = " {0} / {1}";
            // 
            // btnSea
            // 
            this.btnSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSea.ImageIndex = 3;
            this.btnSea.Location = new System.Drawing.Point(541, 0);
            this.btnSea.Name = "btnSea";
            this.btnSea.Size = new System.Drawing.Size(80, 30);
            this.btnSea.TabIndex = 4;
            this.btnSea.Text = "&Tìm kiếm";
            this.btnSea.Click += new System.EventHandler(this.btnSea_Click);
            // 
            // btnCan
            // 
            this.btnCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCan.ImageIndex = 4;
            this.btnCan.Location = new System.Drawing.Point(713, 0);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(80, 30);
            this.btnCan.TabIndex = 6;
            this.btnCan.Text = "&Hủy";
            this.btnCan.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(197, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMod.ImageIndex = 4;
            this.btnMod.Location = new System.Drawing.Point(283, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(80, 30);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "&Sửa";
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.ImageIndex = 3;
            this.btnDel.Location = new System.Drawing.Point(369, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "&Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQui
            // 
            this.btnQui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQui.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQui.ImageIndex = 8;
            this.btnQui.Location = new System.Drawing.Point(920, 0);
            this.btnQui.Name = "btnQui";
            this.btnQui.Size = new System.Drawing.Size(80, 30);
            this.btnQui.TabIndex = 7;
            this.btnQui.Text = "&Quay ra";
            this.btnQui.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPri
            // 
            this.btnPri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPri.ImageIndex = 15;
            this.btnPri.Location = new System.Drawing.Point(627, 0);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(80, 30);
            this.btnPri.TabIndex = 5;
            this.btnPri.Text = "&In phiếu";
            this.btnPri.Click += new System.EventHandler(this.btnInCtu_Click);
            // 
            // btnSav
            // 
            this.btnSav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSav.ImageIndex = 0;
            this.btnSav.Location = new System.Drawing.Point(455, 0);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(80, 30);
            this.btnSav.TabIndex = 2;
            this.btnSav.Text = "&Lưu";
            this.btnSav.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày tạo lệnh";
            this.gridColumn5.FieldName = "NgayGiaoLenh";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lệnh sản xuất";
            this.gridColumn6.FieldName = "SoLenhSanXuat";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày tạo lệnh";
            this.gridColumn7.FieldName = "NgayGiaoLenh";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số lệnh sản xuất";
            this.gridColumn8.FieldName = "SoLenhSanXuat";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // UR_STATUS
            // 
            this.UR_STATUS.CheckStatus = true;
            this.UR_STATUS.LCT_STATUS = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.UR_STATUS.Location = new System.Drawing.Point(0, 0);
            this.UR_STATUS.Name = "UR_STATUS";
            this.UR_STATUS.Size = new System.Drawing.Size(314, 20);
            this.UR_STATUS.TabIndex = 0;
            valueInfo1.Den_Ngay = null;
            valueInfo1.ID_DM = null;
            valueInfo1.Ky_Hieu = null;
            valueInfo1.MA_DM = null;
            valueInfo1.ParameterValue = null;
            valueInfo1.Ten = null;
            valueInfo1.Tu_Ngay = null;
            this.UR_STATUS.Value_info = valueInfo1;
            // 
            // frmPhieuNhapKho_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.PanelControl2);
            this.KeyPreview = true;
            this.Name = "frmPhieuNhapKho_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "phieu nhap kho CT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhieuNhapKho_ChiTiet_FormClosed);
            this.Load += new System.EventHandler(this.frmPhieuNhapKho_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMakhoxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVuViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPTQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTudo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoanphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHopdong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteHDPN.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteHDPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHDPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIA_CHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUOI_GIAO_NHAN_HANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIEN_GIAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuPhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GFilterEdit_HANGHOA_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_MA_TKN_GIAVON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_MA_TKC_GIAVON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemAlignment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depCT_H_Nx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl4)).EndInit();
            this.GroupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).EndInit();
            this.GroupControl3.ResumeLayout(false);
            this.GroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraGrid.GridControl grcPhieuPhapKho;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvPhieuNhapKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        internal DevExpress.XtraEditors.TextEdit txtDIA_CHI;
        internal DevExpress.XtraEditors.TextEdit txtNGUOI_GIAO_NHAN_HANG;
        internal DevExpress.XtraEditors.TextEdit txtDIEN_GIAI;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        internal DevExpress.XtraGrid.Columns.GridColumn HANGHOA_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_HANGHOA;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_DVT;
        internal DevExpress.XtraGrid.Columns.GridColumn KHO_NHAP_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_LUONG;
        internal DevExpress.XtraGrid.Columns.GridColumn DON_GIA_VON_NTE;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON_NT;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TKN_GIAVON;
        internal DevExpress.XtraGrid.Columns.GridColumn DON_GIA_VON;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON;
        internal DevExpress.XtraGrid.Columns.GridColumn VUVIEC_ID;
        private DevExpress.XtraEditors.DateEdit dteNGAY_CT;
        private DevExpress.XtraEditors.DateEdit dteNGAY_GHI;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLoaiPhieuNhap;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TKC_GIAVON;
        internal DevExpress.XtraEditors.TextEdit txtHDPN;
        private DevExpress.XtraEditors.LabelControl lblHDPN;
        internal DevExpress.XtraGrid.Columns.GridColumn KHO_XUAT_ID;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider depCT_H_Nx;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_PTQT_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_TUDO_1_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_TUDO_2_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_TUDO_3_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_TUDO_4_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_TUDO_5_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_PHONGBAN_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_KHOANPHI_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn ID_DM_HOPDONG_CO;
        private DevExpress.XtraEditors.LabelControl lblNgayHDPN;
        private DevExpress.XtraEditors.DateEdit dteHDPN;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl3;
        internal DevExpress.XtraEditors.TextEdit txtTongSoLuong;
        private DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.TextEdit TxtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMaHang;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDVT;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMaKho;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMakhoxuat;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spdSoLuong;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepositoryItemSpinEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepositoryItemSpinEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTKno;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboVuViec;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTKco;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPTQT;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTudo1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTudo2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTudo3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTudo4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTudo5;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPhongban;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboKhoanphi;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboHopdong;
        internal DevExpress.XtraEditors.GroupControl GroupControl4;
        internal DevExpress.XtraGrid.GridControl grcLPN_Hnx;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvLPX_Hnx;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_GHI;
        internal DevExpress.XtraGrid.Columns.GridColumn CT_SO;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_CT;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.ControlNavigator navWelding1;
        internal DevExpress.XtraEditors.SimpleButton btnSea;
        internal DevExpress.XtraEditors.SimpleButton btnCan;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraEditors.SimpleButton btnMod;
        internal DevExpress.XtraEditors.SimpleButton btnDel;
        internal DevExpress.XtraEditors.SimpleButton btnQui;
        internal DevExpress.XtraEditors.SimpleButton btnPri;
        internal DevExpress.XtraEditors.SimpleButton btnSav;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.CheckEdit CheckEdit1;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit GFilterEdit_HANGHOA_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepositoryItemAlignment1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit3;
        internal Vns.Erp.Core.Controls.UserControl.Status_LoaiCT UR_STATUS;
        
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit Gfilter_MA_TKN_GIAVON;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit Gfilter_MA_TKC_GIAVON;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit5;
        internal DevExpress.XtraGrid.Columns.GridColumn VI_TRI;
        internal Vns.Erp.Core.CustomFilter GFilter_TK;
        internal DevExpress.XtraEditors.LabelControl lblTK;
        internal DevExpress.XtraGrid.Columns.GridColumn TON_KHO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit6;
        internal DevExpress.XtraGrid.Columns.GridColumn HanghoaId;
        internal DevExpress.XtraGrid.Columns.GridColumn TenHanghoa;
        internal DevExpress.XtraGrid.Columns.GridColumn TenDvt;
        internal DevExpress.XtraGrid.Columns.GridColumn ViTri;
        internal DevExpress.XtraGrid.Columns.GridColumn KhoNhapId;
        internal DevExpress.XtraGrid.Columns.GridColumn KhoXuatId;
        internal DevExpress.XtraGrid.Columns.GridColumn TonKho;
        internal DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        internal DevExpress.XtraGrid.Columns.GridColumn DonGiaVonNte;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaVonNt;
        internal DevExpress.XtraGrid.Columns.GridColumn DonGiaVon;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaVon;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTknGiavon;
        internal DevExpress.XtraGrid.Columns.GridColumn VuviecId;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTkcGiavon;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmPtqtCo;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmTudo1Co;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmTudo2Co;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmTudo3Co;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmTudo4Co;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmTudo5Co;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmPhongbanCo;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmKhoanphiCo;
        internal DevExpress.XtraGrid.Columns.GridColumn IdDmHopdongCo;
        internal DevExpress.XtraGrid.Columns.GridColumn CtSo;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayCt;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayGhi;
        internal DevExpress.XtraGrid.Columns.GridColumn Ghi;
        internal Vns.Erp.Core.Controls.UserControl.C_SoChungTu C_SoChungTu_RP;
        private DevExpress.XtraGrid.Columns.GridColumn colLenhSxXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboLenhSxXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colLenhSxNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboLenhSxNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanXuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanXuongXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboPhanXuongNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboPhanXuongXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
    }
}