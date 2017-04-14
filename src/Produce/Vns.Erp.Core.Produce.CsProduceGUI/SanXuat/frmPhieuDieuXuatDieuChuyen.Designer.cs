using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    partial class PhieuDieuXuatDieuChuyen : DevExpress.XtraEditors.XtraForm
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            Vns.Erp.Core.ValueInfo valueInfo1 = new Vns.Erp.Core.ValueInfo();
            this.ThuTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcLPN_Hnx = new DevExpress.XtraGrid.GridControl();
            this.grvLPX_Hnx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ghi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CtSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayGhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSea = new DevExpress.XtraEditors.SimpleButton();
            this.btnCan = new DevExpress.XtraEditors.SimpleButton();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnMod = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSav = new DevExpress.XtraEditors.SimpleButton();
            this.navWelding1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GroupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.grcPhieuDieuChuyen = new DevExpress.XtraGrid.GridControl();
            this.grvPhieuDieuChuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HangHoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GFilterEdit_HANGHOA_ID = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.TEN_HANGHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHO_NHAP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMaKhoNhap = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.KHO_XUAT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMaKhoXuat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SO_LUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DON_GIA_VON_NTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GIA_VON_NT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DON_GIA_VON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GIA_VON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MA_TKC_GIAVON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gfilter_TKC_GIAVON = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.MA_TKN_GIAVON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gfilter_TKN_GIAVON = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.VUVIEC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboVuViec = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TON_KHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.LenhSanXuatXuatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLenhSanXuatXuatId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhanXuongXuatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPXXuat = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LenhSanXuatNhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLenhSanXuatNhapId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhanXuongNhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPXNhap = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMaHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTKno = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTKco = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spdSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.spdDonGia = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.spdTongTien = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.cboLenhSxXuat = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLenhSxNhap = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPhanXuongNhap = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPhanXuongXuat = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.GroupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.urcGhi = new Vns.Erp.Core.Controls.UserControl.Status_LoaiCT();
            this.txtTongSL = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.GroupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblKhoXuat = new DevExpress.XtraEditors.LabelControl();
            this.lblKhoNhap = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoXuat = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhoNhap = new DevExpress.XtraEditors.LookUpEdit();
            this.C_SoChungTu_RP = new Vns.Erp.Core.Controls.UserControl.C_SoChungTu();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTY_GIA = new DevExpress.XtraEditors.TextEdit();
            this.cboTyGia = new DevExpress.XtraEditors.LookUpEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.grlLoaiPhieuNhap = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteNGAY_CT = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_GHI = new DevExpress.XtraEditors.DateEdit();
            this.txtNGUOI_GIAO_NHAN_HANG = new DevExpress.XtraEditors.TextEdit();
            this.txtDIEN_GIAI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).BeginInit();
            this.GroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl6)).BeginInit();
            this.GroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuDieuChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuDieuChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GFilterEdit_HANGHOA_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKhoNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKhoXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_TKC_GIAVON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_TKN_GIAVON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVuViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSanXuatXuatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPXXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSanXuatNhapId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPXNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl5)).BeginInit();
            this.GroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl4)).BeginInit();
            this.GroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTY_GIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTyGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUOI_GIAO_NHAN_HANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIEN_GIAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThuTu
            // 
            this.ThuTu.Caption = "ThuTu";
            this.ThuTu.FieldName = "ThuTu";
            this.ThuTu.Name = "ThuTu";
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.grcLPN_Hnx);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(194, 574);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "Danh sách";
            // 
            // grcLPN_Hnx
            // 
            this.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLPN_Hnx.Location = new System.Drawing.Point(2, 22);
            this.grcLPN_Hnx.MainView = this.grvLPX_Hnx;
            this.grcLPN_Hnx.Name = "grcLPN_Hnx";
            this.grcLPN_Hnx.Size = new System.Drawing.Size(190, 550);
            this.grcLPN_Hnx.TabIndex = 1;
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
            this.Ghi,
            this.CtSo,
            this.NgayGhi,
            this.NgayCt});
            this.grvLPX_Hnx.GridControl = this.grcLPN_Hnx;
            this.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvLPX_Hnx.Name = "grvLPX_Hnx";
            this.grvLPX_Hnx.OptionsBehavior.Editable = false;
            this.grvLPX_Hnx.OptionsView.ColumnAutoWidth = false;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = true;
            this.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = true;
            this.grvLPX_Hnx.OptionsView.ShowGroupPanel = false;
            // 
            // Ghi
            // 
            this.Ghi.Caption = "Trạng thái";
            this.Ghi.FieldName = "Ghi";
            this.Ghi.Name = "Ghi";
            this.Ghi.Visible = true;
            this.Ghi.VisibleIndex = 0;
            // 
            // CtSo
            // 
            this.CtSo.Caption = "Số chứng từ";
            this.CtSo.FieldName = "CtSo";
            this.CtSo.Name = "CtSo";
            this.CtSo.Visible = true;
            this.CtSo.VisibleIndex = 1;
            this.CtSo.Width = 90;
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
            this.NgayGhi.Width = 90;
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
            this.NgayCt.Width = 100;
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.btnSea);
            this.PanelControl2.Controls.Add(this.btnCan);
            this.PanelControl2.Controls.Add(this.btnPri);
            this.PanelControl2.Controls.Add(this.btnAdd);
            this.PanelControl2.Controls.Add(this.btnMod);
            this.PanelControl2.Controls.Add(this.btnDel);
            this.PanelControl2.Controls.Add(this.btnSav);
            this.PanelControl2.Controls.Add(this.navWelding1);
            this.PanelControl2.Controls.Add(this.btnQuit);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(4, 578);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(1000, 30);
            this.PanelControl2.TabIndex = 24;
            // 
            // btnSea
            // 
            this.btnSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSea.ImageIndex = 3;
            this.btnSea.Location = new System.Drawing.Point(542, 0);
            this.btnSea.Name = "btnSea";
            this.btnSea.Size = new System.Drawing.Size(80, 30);
            this.btnSea.TabIndex = 4;
            this.btnSea.Text = "Tìm kiếm";
            // 
            // btnCan
            // 
            this.btnCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCan.ImageIndex = 4;
            this.btnCan.Location = new System.Drawing.Point(628, 0);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(80, 30);
            this.btnCan.TabIndex = 5;
            this.btnCan.Text = "Hủy";
            // 
            // btnPri
            // 
            this.btnPri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPri.ImageIndex = 15;
            this.btnPri.Location = new System.Drawing.Point(714, 0);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(80, 30);
            this.btnPri.TabIndex = 6;
            this.btnPri.Text = "&In phiếu";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(198, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Mới";
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMod.ImageIndex = 4;
            this.btnMod.Location = new System.Drawing.Point(284, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(80, 30);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Sửa";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.ImageIndex = 3;
            this.btnDel.Location = new System.Drawing.Point(370, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "&Xóa";
            // 
            // btnSav
            // 
            this.btnSav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSav.ImageIndex = 0;
            this.btnSav.Location = new System.Drawing.Point(456, 0);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(80, 30);
            this.btnSav.TabIndex = 2;
            this.btnSav.Text = "&Lưu";
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
            this.navWelding1.Location = new System.Drawing.Point(-2, 0);
            this.navWelding1.Name = "navWelding1";
            this.navWelding1.NavigatableControl = this.grcLPN_Hnx;
            this.navWelding1.Size = new System.Drawing.Size(196, 30);
            this.navWelding1.TabIndex = 15;
            this.navWelding1.Text = "ControlNavigator4";
            this.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.navWelding1.TextStringFormat = " {0} / {1}";
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.ImageIndex = 1;
            this.btnQuit.Location = new System.Drawing.Point(920, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "&Đóng";
            // 
            // GridView1
            // 
            this.GridView1.Name = "GridView1";
            // 
            // GroupControl2
            // 
            this.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GroupControl2.Controls.Add(this.GroupControl3);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(0, 0);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.ShowCaption = false;
            this.GroupControl2.Size = new System.Drawing.Size(801, 574);
            this.GroupControl2.TabIndex = 25;
            this.GroupControl2.Text = "Danh sách...";
            // 
            // GroupControl3
            // 
            this.GroupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GroupControl3.Controls.Add(this.GroupControl6);
            this.GroupControl3.Controls.Add(this.GroupControl5);
            this.GroupControl3.Controls.Add(this.GroupControl4);
            this.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl3.Location = new System.Drawing.Point(0, 0);
            this.GroupControl3.Name = "GroupControl3";
            this.GroupControl3.Size = new System.Drawing.Size(801, 574);
            this.GroupControl3.TabIndex = 26;
            this.GroupControl3.Text = "Chi Tiết";
            // 
            // GroupControl6
            // 
            this.GroupControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GroupControl6.Controls.Add(this.grcPhieuDieuChuyen);
            this.GroupControl6.Controls.Add(this.PanelControl1);
            this.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl6.Location = new System.Drawing.Point(0, 157);
            this.GroupControl6.Name = "GroupControl6";
            this.GroupControl6.ShowCaption = false;
            this.GroupControl6.Size = new System.Drawing.Size(801, 382);
            this.GroupControl6.TabIndex = 1;
            this.GroupControl6.Text = "GroupControl6";
            // 
            // grcPhieuDieuChuyen
            // 
            this.grcPhieuDieuChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPhieuDieuChuyen.Location = new System.Drawing.Point(0, 21);
            this.grcPhieuDieuChuyen.MainView = this.grvPhieuDieuChuyen;
            this.grcPhieuDieuChuyen.Name = "grcPhieuDieuChuyen";
            this.grcPhieuDieuChuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboMaHang,
            this.cboTKno,
            this.cboMaKhoNhap,
            this.cboVuViec,
            this.cboDVT,
            this.cboTKco,
            this.cboMaKhoXuat,
            this.spdSoLuong,
            this.spdDonGia,
            this.spdTongTien,
            this.GFilterEdit_HANGHOA_ID,
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2,
            this.RepositoryItemTextEdit3,
            this.RepositoryItemTextEdit4,
            this.RepositoryItemTextEdit5,
            this.Gfilter_TKC_GIAVON,
            this.Gfilter_TKN_GIAVON,
            this.RepositoryItemTextEdit6,
            this.cboLenhSxXuat,
            this.cboLenhSxNhap,
            this.cboPhanXuongNhap,
            this.cboPhanXuongXuat,
            this.cboLenhSanXuatXuatId,
            this.cboLenhSanXuatNhapId,
            this.cboPXXuat,
            this.cboPXNhap});
            this.grcPhieuDieuChuyen.Size = new System.Drawing.Size(801, 361);
            this.grcPhieuDieuChuyen.TabIndex = 1;
            this.grcPhieuDieuChuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuDieuChuyen});
            // 
            // grvPhieuDieuChuyen
            // 
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.Empty.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvPhieuDieuChuyen.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.grvPhieuDieuChuyen.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.EvenRow.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuDieuChuyen.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.grvPhieuDieuChuyen.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvPhieuDieuChuyen.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.grvPhieuDieuChuyen.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuDieuChuyen.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.grvPhieuDieuChuyen.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.grvPhieuDieuChuyen.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvPhieuDieuChuyen.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvPhieuDieuChuyen.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuDieuChuyen.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.HorzLine.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.OddRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.OddRow.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Appearance.OddRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.grvPhieuDieuChuyen.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.grvPhieuDieuChuyen.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.grvPhieuDieuChuyen.Appearance.Preview.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.Preview.Options.UseFont = true;
            this.grvPhieuDieuChuyen.Appearance.Preview.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.Row.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.Row.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.grvPhieuDieuChuyen.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.grvPhieuDieuChuyen.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvPhieuDieuChuyen.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvPhieuDieuChuyen.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvPhieuDieuChuyen.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.grvPhieuDieuChuyen.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.grvPhieuDieuChuyen.Appearance.VertLine.Options.UseBackColor = true;
            this.grvPhieuDieuChuyen.Appearance.VertLine.Options.UseBorderColor = true;
            this.grvPhieuDieuChuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HangHoaId,
            this.TEN_HANGHOA,
            this.TEN_DVT,
            this.KHO_NHAP_ID,
            this.KHO_XUAT_ID,
            this.SO_LUONG,
            this.DON_GIA_VON_NTE,
            this.GIA_VON_NT,
            this.DON_GIA_VON,
            this.GIA_VON,
            this.MA_TKC_GIAVON,
            this.MA_TKN_GIAVON,
            this.VUVIEC_ID,
            this.ThuTu,
            this.TON_KHO,
            this.LenhSanXuatXuatId,
            this.PhanXuongXuatId,
            this.LenhSanXuatNhapId,
            this.PhanXuongNhapId});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.ThuTu;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "13";
            this.grvPhieuDieuChuyen.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.grvPhieuDieuChuyen.GridControl = this.grcPhieuDieuChuyen;
            this.grvPhieuDieuChuyen.Name = "grvPhieuDieuChuyen";
            this.grvPhieuDieuChuyen.OptionsNavigation.AutoFocusNewRow = true;
            this.grvPhieuDieuChuyen.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvPhieuDieuChuyen.OptionsView.ColumnAutoWidth = false;
            this.grvPhieuDieuChuyen.OptionsView.EnableAppearanceEvenRow = true;
            this.grvPhieuDieuChuyen.OptionsView.EnableAppearanceOddRow = true;
            this.grvPhieuDieuChuyen.OptionsView.ShowGroupPanel = false;
            // 
            // HangHoaId
            // 
            this.HangHoaId.Caption = "Mã hàng ";
            this.HangHoaId.ColumnEdit = this.GFilterEdit_HANGHOA_ID;
            this.HangHoaId.FieldName = "KyHieuHanghoa";
            this.HangHoaId.Name = "HangHoaId";
            this.HangHoaId.Visible = true;
            this.HangHoaId.VisibleIndex = 0;
            this.HangHoaId.Width = 130;
            // 
            // GFilterEdit_HANGHOA_ID
            // 
            this.GFilterEdit_HANGHOA_ID.AutoHeight = false;
            this.GFilterEdit_HANGHOA_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" +
                "nDvt--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0";
            this.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban";
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
            this.GFilterEdit_HANGHOA_ID.ListEditValues = null;
            this.GFilterEdit_HANGHOA_ID.Name = "GFilterEdit_HANGHOA_ID";
            this.GFilterEdit_HANGHOA_ID.NEXT_TAB = 0;
            this.GFilterEdit_HANGHOA_ID.OBJ_CONDITITION = null;
            // 
            // TEN_HANGHOA
            // 
            this.TEN_HANGHOA.Caption = "Tên hàng / Vật tư";
            this.TEN_HANGHOA.FieldName = "TenHanghoa";
            this.TEN_HANGHOA.Name = "TEN_HANGHOA";
            this.TEN_HANGHOA.OptionsColumn.ReadOnly = true;
            this.TEN_HANGHOA.Visible = true;
            this.TEN_HANGHOA.VisibleIndex = 1;
            this.TEN_HANGHOA.Width = 120;
            // 
            // TEN_DVT
            // 
            this.TEN_DVT.Caption = "ĐVT";
            this.TEN_DVT.FieldName = "TenDvt";
            this.TEN_DVT.Name = "TEN_DVT";
            this.TEN_DVT.OptionsColumn.ReadOnly = true;
            this.TEN_DVT.Visible = true;
            this.TEN_DVT.VisibleIndex = 2;
            this.TEN_DVT.Width = 70;
            // 
            // KHO_NHAP_ID
            // 
            this.KHO_NHAP_ID.Caption = "Mã kho nhập";
            this.KHO_NHAP_ID.ColumnEdit = this.cboMaKhoNhap;
            this.KHO_NHAP_ID.FieldName = "KhoNhapId";
            this.KHO_NHAP_ID.Name = "KHO_NHAP_ID";
            this.KHO_NHAP_ID.Visible = true;
            this.KHO_NHAP_ID.VisibleIndex = 3;
            this.KHO_NHAP_ID.Width = 100;
            // 
            // cboMaKhoNhap
            // 
            this.cboMaKhoNhap.AutoHeight = false;
            this.cboMaKhoNhap.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMaKhoNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaKhoNhap.Name = "cboMaKhoNhap";
            this.cboMaKhoNhap.NullText = "";
            // 
            // KHO_XUAT_ID
            // 
            this.KHO_XUAT_ID.Caption = "Mã kho xuất";
            this.KHO_XUAT_ID.ColumnEdit = this.cboMaKhoXuat;
            this.KHO_XUAT_ID.FieldName = "KhoXuatId";
            this.KHO_XUAT_ID.Name = "KHO_XUAT_ID";
            this.KHO_XUAT_ID.Visible = true;
            this.KHO_XUAT_ID.VisibleIndex = 4;
            this.KHO_XUAT_ID.Width = 100;
            // 
            // cboMaKhoXuat
            // 
            this.cboMaKhoXuat.AutoHeight = false;
            this.cboMaKhoXuat.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMaKhoXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaKhoXuat.Name = "cboMaKhoXuat";
            this.cboMaKhoXuat.NullText = "";
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.Caption = "Số lượng";
            this.SO_LUONG.ColumnEdit = this.RepositoryItemTextEdit1;
            this.SO_LUONG.FieldName = "SoLuong";
            this.SO_LUONG.Name = "SO_LUONG";
            this.SO_LUONG.Visible = true;
            this.SO_LUONG.VisibleIndex = 5;
            this.SO_LUONG.Width = 70;
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
            // DON_GIA_VON_NTE
            // 
            this.DON_GIA_VON_NTE.Caption = "Giá NTE";
            this.DON_GIA_VON_NTE.ColumnEdit = this.RepositoryItemTextEdit2;
            this.DON_GIA_VON_NTE.FieldName = "DonGiaVonNte";
            this.DON_GIA_VON_NTE.Name = "DON_GIA_VON_NTE";
            this.DON_GIA_VON_NTE.Width = 70;
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
            // GIA_VON_NT
            // 
            this.GIA_VON_NT.Caption = "Tiền NTE";
            this.GIA_VON_NT.ColumnEdit = this.RepositoryItemTextEdit3;
            this.GIA_VON_NT.FieldName = "GiaVonNt";
            this.GIA_VON_NT.Name = "GIA_VON_NT";
            this.GIA_VON_NT.OptionsColumn.ReadOnly = true;
            this.GIA_VON_NT.Width = 70;
            // 
            // RepositoryItemTextEdit3
            // 
            this.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit3.AutoHeight = false;
            this.RepositoryItemTextEdit3.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3";
            // 
            // DON_GIA_VON
            // 
            this.DON_GIA_VON.Caption = "Đơn giá";
            this.DON_GIA_VON.ColumnEdit = this.RepositoryItemTextEdit4;
            this.DON_GIA_VON.DisplayFormat.FormatString = "####0";
            this.DON_GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DON_GIA_VON.FieldName = "DonGiaVon";
            this.DON_GIA_VON.Name = "DON_GIA_VON";
            this.DON_GIA_VON.Width = 70;
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
            // GIA_VON
            // 
            this.GIA_VON.Caption = "Tổng tiền";
            this.GIA_VON.ColumnEdit = this.RepositoryItemTextEdit5;
            this.GIA_VON.DisplayFormat.FormatString = "#,###0";
            this.GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIA_VON.FieldName = "GiaVon";
            this.GIA_VON.Name = "GIA_VON";
            this.GIA_VON.OptionsColumn.ReadOnly = true;
            this.GIA_VON.Width = 100;
            // 
            // RepositoryItemTextEdit5
            // 
            this.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit5.AutoHeight = false;
            this.RepositoryItemTextEdit5.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5";
            // 
            // MA_TKC_GIAVON
            // 
            this.MA_TKC_GIAVON.Caption = "TK có giá vốn";
            this.MA_TKC_GIAVON.ColumnEdit = this.Gfilter_TKC_GIAVON;
            this.MA_TKC_GIAVON.FieldName = "MaTkcGiavon";
            this.MA_TKC_GIAVON.Name = "MA_TKC_GIAVON";
            this.MA_TKC_GIAVON.Width = 120;
            // 
            // Gfilter_TKC_GIAVON
            // 
            this.Gfilter_TKC_GIAVON.AutoHeight = false;
            this.Gfilter_TKC_GIAVON.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Gfilter_TKC_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.Gfilter_TKC_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.Gfilter_TKC_GIAVON.C_DATA_SOURCE = null;
            this.Gfilter_TKC_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.Gfilter_TKC_GIAVON.C_FORM_TITLE = "Chọn tài khoản";
            this.Gfilter_TKC_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.Gfilter_TKC_GIAVON.C_IS_CHECK_OTHER = "=";
            this.Gfilter_TKC_GIAVON.C_IS_CHECK_STRING = "=";
            this.Gfilter_TKC_GIAVON.C_IS_CHI_TIET = "";
            this.Gfilter_TKC_GIAVON.C_IS_FILTER_STRING = "";
            this.Gfilter_TKC_GIAVON.C_IS_QUICKADD = false;
            this.Gfilter_TKC_GIAVON.C_IS_SORT_ORDER_STRING = "";
            this.Gfilter_TKC_GIAVON.C_KEY_NAME = "MaTaikhoan";
            this.Gfilter_TKC_GIAVON.Editors = null;
            this.Gfilter_TKC_GIAVON.EditValues = "";
            this.Gfilter_TKC_GIAVON.ListEditValues = null;
            this.Gfilter_TKC_GIAVON.Name = "Gfilter_TKC_GIAVON";
            this.Gfilter_TKC_GIAVON.NEXT_TAB = 0;
            this.Gfilter_TKC_GIAVON.OBJ_CONDITITION = null;
            // 
            // MA_TKN_GIAVON
            // 
            this.MA_TKN_GIAVON.Caption = "TK nợ giá vốn";
            this.MA_TKN_GIAVON.ColumnEdit = this.Gfilter_TKN_GIAVON;
            this.MA_TKN_GIAVON.FieldName = "MaTknGiavon";
            this.MA_TKN_GIAVON.Name = "MA_TKN_GIAVON";
            this.MA_TKN_GIAVON.Width = 120;
            // 
            // Gfilter_TKN_GIAVON
            // 
            this.Gfilter_TKN_GIAVON.AutoHeight = false;
            this.Gfilter_TKN_GIAVON.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Gfilter_TKN_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0";
            this.Gfilter_TKN_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa";
            this.Gfilter_TKN_GIAVON.C_DATA_SOURCE = null;
            this.Gfilter_TKN_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.Gfilter_TKN_GIAVON.C_FORM_TITLE = "Chọn tài khoản";
            this.Gfilter_TKN_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.Gfilter_TKN_GIAVON.C_IS_CHECK_OTHER = "=";
            this.Gfilter_TKN_GIAVON.C_IS_CHECK_STRING = "=";
            this.Gfilter_TKN_GIAVON.C_IS_CHI_TIET = "";
            this.Gfilter_TKN_GIAVON.C_IS_FILTER_STRING = "";
            this.Gfilter_TKN_GIAVON.C_IS_QUICKADD = false;
            this.Gfilter_TKN_GIAVON.C_IS_SORT_ORDER_STRING = "";
            this.Gfilter_TKN_GIAVON.C_KEY_NAME = "MaTaikhoan";
            this.Gfilter_TKN_GIAVON.Editors = null;
            this.Gfilter_TKN_GIAVON.EditValues = "";
            this.Gfilter_TKN_GIAVON.ListEditValues = null;
            this.Gfilter_TKN_GIAVON.Name = "Gfilter_TKN_GIAVON";
            this.Gfilter_TKN_GIAVON.NEXT_TAB = 0;
            this.Gfilter_TKN_GIAVON.OBJ_CONDITITION = null;
            // 
            // VUVIEC_ID
            // 
            this.VUVIEC_ID.Caption = "Vụ Việc";
            this.VUVIEC_ID.ColumnEdit = this.cboVuViec;
            this.VUVIEC_ID.FieldName = "VuviecId";
            this.VUVIEC_ID.Name = "VUVIEC_ID";
            this.VUVIEC_ID.Visible = true;
            this.VUVIEC_ID.VisibleIndex = 6;
            this.VUVIEC_ID.Width = 120;
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
            // TON_KHO
            // 
            this.TON_KHO.Caption = "Tồn kho";
            this.TON_KHO.ColumnEdit = this.RepositoryItemTextEdit6;
            this.TON_KHO.FieldName = "TonKho";
            this.TON_KHO.Name = "TON_KHO";
            // 
            // RepositoryItemTextEdit6
            // 
            this.RepositoryItemTextEdit6.AutoHeight = false;
            this.RepositoryItemTextEdit6.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6";
            // 
            // LenhSanXuatXuatId
            // 
            this.LenhSanXuatXuatId.Caption = "Lệnh sản xuất xuất";
            this.LenhSanXuatXuatId.ColumnEdit = this.cboLenhSanXuatXuatId;
            this.LenhSanXuatXuatId.FieldName = "LenhSanXuatXuatId";
            this.LenhSanXuatXuatId.Name = "LenhSanXuatXuatId";
            this.LenhSanXuatXuatId.Visible = true;
            this.LenhSanXuatXuatId.VisibleIndex = 7;
            // 
            // cboLenhSanXuatXuatId
            // 
            this.cboLenhSanXuatXuatId.AutoHeight = false;
            this.cboLenhSanXuatXuatId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSanXuatXuatId.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSanXuatXuatId.ImmediatePopup = true;
            this.cboLenhSanXuatXuatId.Name = "cboLenhSanXuatXuatId";
            this.cboLenhSanXuatXuatId.NullText = "";
            this.cboLenhSanXuatXuatId.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSanXuatXuatId.ValueMember = "Id";
            this.cboLenhSanXuatXuatId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Ngày giao lệnh";
            this.gridColumn14.FieldName = "NgayGiaoLenh";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Số lệnh sản xuất";
            this.gridColumn15.FieldName = "SoLenhSanXuat";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Tổ sản xuất";
            this.gridColumn16.FieldName = "MaToSanXuat";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 2;
            // 
            // PhanXuongXuatId
            // 
            this.PhanXuongXuatId.Caption = "Phân xưởng xuất";
            this.PhanXuongXuatId.ColumnEdit = this.cboPXXuat;
            this.PhanXuongXuatId.FieldName = "PhanXuongXuatId";
            this.PhanXuongXuatId.Name = "PhanXuongXuatId";
            this.PhanXuongXuatId.Visible = true;
            this.PhanXuongXuatId.VisibleIndex = 10;
            // 
            // cboPXXuat
            // 
            this.cboPXXuat.AutoHeight = false;
            this.cboPXXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPXXuat.DisplayMember = "KyHieu";
            this.cboPXXuat.Name = "cboPXXuat";
            this.cboPXXuat.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboPXXuat.ValueMember = "Id";
            this.cboPXXuat.View = this.gridView7;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn21});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Ký hiệu";
            this.gridColumn20.FieldName = "KyHieu";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Tên phòng ban";
            this.gridColumn21.FieldName = "TenPhongban";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            // 
            // LenhSanXuatNhapId
            // 
            this.LenhSanXuatNhapId.Caption = "Lệnh sản xuất nhập";
            this.LenhSanXuatNhapId.ColumnEdit = this.cboLenhSanXuatNhapId;
            this.LenhSanXuatNhapId.FieldName = "LenhSanXuatNhapId";
            this.LenhSanXuatNhapId.Name = "LenhSanXuatNhapId";
            this.LenhSanXuatNhapId.Visible = true;
            this.LenhSanXuatNhapId.VisibleIndex = 8;
            // 
            // cboLenhSanXuatNhapId
            // 
            this.cboLenhSanXuatNhapId.AutoHeight = false;
            this.cboLenhSanXuatNhapId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSanXuatNhapId.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSanXuatNhapId.ImmediatePopup = true;
            this.cboLenhSanXuatNhapId.Name = "cboLenhSanXuatNhapId";
            this.cboLenhSanXuatNhapId.NullText = "";
            this.cboLenhSanXuatNhapId.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSanXuatNhapId.ValueMember = "Id";
            this.cboLenhSanXuatNhapId.View = this.gridView6;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Ngày giao lệnh";
            this.gridColumn17.FieldName = "NgayGiaoLenh";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Số lệnh sản xuất";
            this.gridColumn18.FieldName = "SoLenhSanXuat";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Mã tổ sản xuất";
            this.gridColumn19.FieldName = "MaToSanXuat";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 2;
            // 
            // PhanXuongNhapId
            // 
            this.PhanXuongNhapId.Caption = "Phân xưởng nhập";
            this.PhanXuongNhapId.ColumnEdit = this.cboPXNhap;
            this.PhanXuongNhapId.FieldName = "PhanXuongNhapId";
            this.PhanXuongNhapId.Name = "PhanXuongNhapId";
            this.PhanXuongNhapId.Visible = true;
            this.PhanXuongNhapId.VisibleIndex = 9;
            // 
            // cboPXNhap
            // 
            this.cboPXNhap.AutoHeight = false;
            this.cboPXNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPXNhap.DisplayMember = "KyHieu";
            this.cboPXNhap.ImmediatePopup = true;
            this.cboPXNhap.Name = "cboPXNhap";
            this.cboPXNhap.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboPXNhap.ValueMember = "Id";
            this.cboPXNhap.View = this.gridView8;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn22,
            this.gridColumn23});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Ký hiệu";
            this.gridColumn22.FieldName = "KyHieu";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 0;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Tên phân xưởng";
            this.gridColumn23.FieldName = "TenPhongban";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 1;
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
            // cboTKno
            // 
            this.cboTKno.AutoHeight = false;
            this.cboTKno.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTKno.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTKno.Name = "cboTKno";
            this.cboTKno.NullText = "";
            // 
            // cboDVT
            // 
            this.cboDVT.Name = "cboDVT";
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
            // spdDonGia
            // 
            this.spdDonGia.AutoHeight = false;
            this.spdDonGia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spdDonGia.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.spdDonGia.Name = "spdDonGia";
            // 
            // spdTongTien
            // 
            this.spdTongTien.AutoHeight = false;
            this.spdTongTien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spdTongTien.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.spdTongTien.Name = "spdTongTien";
            // 
            // cboLenhSxXuat
            // 
            this.cboLenhSxXuat.AutoHeight = false;
            this.cboLenhSxXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSxXuat.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSxXuat.Name = "cboLenhSxXuat";
            this.cboLenhSxXuat.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSxXuat.ValueMember = "Id";
            this.cboLenhSxXuat.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày giao lệnh";
            this.gridColumn1.FieldName = "NgayGiaoLenh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số lệnh sản xuất";
            this.gridColumn5.FieldName = "SoLenhSanXuat";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã phân xưởng";
            this.gridColumn6.FieldName = "MaToSanXuat";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // cboLenhSxNhap
            // 
            this.cboLenhSxNhap.AutoHeight = false;
            this.cboLenhSxNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLenhSxNhap.DisplayMember = "SoLenhSanXuat";
            this.cboLenhSxNhap.Name = "cboLenhSxNhap";
            this.cboLenhSxNhap.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLenhSxNhap.ValueMember = "Id";
            this.cboLenhSxNhap.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày giao lệnh";
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
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã phân xưởng";
            this.gridColumn9.FieldName = "MaToSanXuat";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // cboPhanXuongNhap
            // 
            this.cboPhanXuongNhap.AutoHeight = false;
            this.cboPhanXuongNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhanXuongNhap.DisplayMember = "KyHieu";
            this.cboPhanXuongNhap.Name = "cboPhanXuongNhap";
            this.cboPhanXuongNhap.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboPhanXuongNhap.ValueMember = "Id";
            this.cboPhanXuongNhap.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ký hiệu";
            this.gridColumn12.FieldName = "KyHieu";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Tên phân xưởng";
            this.gridColumn13.FieldName = "TenPhongban";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // cboPhanXuongXuat
            // 
            this.cboPhanXuongXuat.AutoHeight = false;
            this.cboPhanXuongXuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhanXuongXuat.DisplayMember = "KyHieu";
            this.cboPhanXuongXuat.Name = "cboPhanXuongXuat";
            this.cboPhanXuongXuat.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboPhanXuongXuat.ValueMember = "Id";
            this.cboPhanXuongXuat.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ký hiệu";
            this.gridColumn10.FieldName = "KyHieu";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên phân xưởng";
            this.gridColumn11.FieldName = "TenPhongban";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.LabelControl10);
            this.PanelControl1.Controls.Add(this.CheckEdit1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(801, 21);
            this.PanelControl1.TabIndex = 0;
            // 
            // LabelControl10
            // 
            this.LabelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl10.Location = new System.Drawing.Point(456, 5);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(342, 13);
            this.LabelControl10.TabIndex = 104;
            this.LabelControl10.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán";
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
            // 
            // GroupControl5
            // 
            this.GroupControl5.Controls.Add(this.urcGhi);
            this.GroupControl5.Controls.Add(this.txtTongSL);
            this.GroupControl5.Controls.Add(this.LabelControl14);
            this.GroupControl5.Controls.Add(this.TxtTongTien);
            this.GroupControl5.Controls.Add(this.labelControl22);
            this.GroupControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl5.Location = new System.Drawing.Point(0, 539);
            this.GroupControl5.Name = "GroupControl5";
            this.GroupControl5.ShowCaption = false;
            this.GroupControl5.Size = new System.Drawing.Size(801, 35);
            this.GroupControl5.TabIndex = 2;
            this.GroupControl5.Text = "GroupControl5";
            // 
            // urcGhi
            // 
            this.urcGhi.CheckStatus = true;
            this.urcGhi.LCT_STATUS = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.urcGhi.Location = new System.Drawing.Point(16, 6);
            this.urcGhi.Name = "urcGhi";
            this.urcGhi.Size = new System.Drawing.Size(297, 20);
            this.urcGhi.TabIndex = 0;
            valueInfo1.Den_Ngay = null;
            valueInfo1.ID_DM = null;
            valueInfo1.Ky_Hieu = null;
            valueInfo1.MA_DM = null;
            valueInfo1.ParameterValue = null;
            valueInfo1.Ten = null;
            valueInfo1.Tu_Ngay = null;
            this.urcGhi.Value_info = valueInfo1;
            // 
            // txtTongSL
            // 
            this.txtTongSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongSL.Enabled = false;
            this.txtTongSL.Location = new System.Drawing.Point(415, 6);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongSL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongSL.Properties.Mask.EditMask = "n2";
            this.txtTongSL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongSL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTongSL.Size = new System.Drawing.Size(115, 20);
            this.txtTongSL.TabIndex = 1;
            this.txtTongSL.TabStop = false;
            // 
            // LabelControl14
            // 
            this.LabelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl14.Location = new System.Drawing.Point(330, 11);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(68, 13);
            this.LabelControl14.TabIndex = 69;
            this.LabelControl14.Text = "Tổng số lượng";
            // 
            // TxtTongTien
            // 
            this.TxtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTongTien.Enabled = false;
            this.TxtTongTien.Location = new System.Drawing.Point(609, 6);
            this.TxtTongTien.Name = "TxtTongTien";
            this.TxtTongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTongTien.Properties.Mask.EditMask = "n0";
            this.TxtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtTongTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtTongTien.Size = new System.Drawing.Size(172, 20);
            this.TxtTongTien.TabIndex = 2;
            this.TxtTongTien.TabStop = false;
            // 
            // labelControl22
            // 
            this.labelControl22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl22.Location = new System.Drawing.Point(546, 11);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(45, 13);
            this.labelControl22.TabIndex = 2;
            this.labelControl22.Text = "Tổng tiền";
            // 
            // GroupControl4
            // 
            this.GroupControl4.Controls.Add(this.lblKhoXuat);
            this.GroupControl4.Controls.Add(this.lblKhoNhap);
            this.GroupControl4.Controls.Add(this.cboKhoXuat);
            this.GroupControl4.Controls.Add(this.cboKhoNhap);
            this.GroupControl4.Controls.Add(this.C_SoChungTu_RP);
            this.GroupControl4.Controls.Add(this.LabelControl1);
            this.GroupControl4.Controls.Add(this.txtTY_GIA);
            this.GroupControl4.Controls.Add(this.cboTyGia);
            this.GroupControl4.Controls.Add(this.LabelControl4);
            this.GroupControl4.Controls.Add(this.LabelControl6);
            this.GroupControl4.Controls.Add(this.LabelControl7);
            this.GroupControl4.Controls.Add(this.LabelControl15);
            this.GroupControl4.Controls.Add(this.grlLoaiPhieuNhap);
            this.GroupControl4.Controls.Add(this.dteNGAY_CT);
            this.GroupControl4.Controls.Add(this.dteNGAY_GHI);
            this.GroupControl4.Controls.Add(this.txtNGUOI_GIAO_NHAN_HANG);
            this.GroupControl4.Controls.Add(this.txtDIEN_GIAI);
            this.GroupControl4.Controls.Add(this.labelControl33);
            this.GroupControl4.Controls.Add(this.labelControl5);
            this.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl4.Location = new System.Drawing.Point(0, 0);
            this.GroupControl4.Name = "GroupControl4";
            this.GroupControl4.Size = new System.Drawing.Size(801, 157);
            this.GroupControl4.TabIndex = 0;
            this.GroupControl4.Text = "Chi tiết";
            // 
            // lblKhoXuat
            // 
            this.lblKhoXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKhoXuat.Location = new System.Drawing.Point(198, 107);
            this.lblKhoXuat.Name = "lblKhoXuat";
            this.lblKhoXuat.Size = new System.Drawing.Size(43, 13);
            this.lblKhoXuat.TabIndex = 108;
            this.lblKhoXuat.Text = "Kho xuất";
            // 
            // lblKhoNhap
            // 
            this.lblKhoNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKhoNhap.Location = new System.Drawing.Point(421, 107);
            this.lblKhoNhap.Name = "lblKhoNhap";
            this.lblKhoNhap.Size = new System.Drawing.Size(45, 13);
            this.lblKhoNhap.TabIndex = 107;
            this.lblKhoNhap.Text = "Kho nhập";
            // 
            // cboKhoXuat
            // 
            this.cboKhoXuat.EnterMoveNextControl = true;
            this.cboKhoXuat.Location = new System.Drawing.Point(256, 104);
            this.cboKhoXuat.Name = "cboKhoXuat";
            this.cboKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoXuat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho")});
            this.cboKhoXuat.Properties.NullText = "";
            this.cboKhoXuat.Size = new System.Drawing.Size(118, 20);
            this.cboKhoXuat.TabIndex = 7;
            // 
            // cboKhoNhap
            // 
            this.cboKhoNhap.EnterMoveNextControl = true;
            this.cboKhoNhap.Location = new System.Drawing.Point(481, 104);
            this.cboKhoNhap.Name = "cboKhoNhap";
            this.cboKhoNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoNhap.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho")});
            this.cboKhoNhap.Properties.NullText = "";
            this.cboKhoNhap.Size = new System.Drawing.Size(118, 20);
            this.cboKhoNhap.TabIndex = 6;
            // 
            // C_SoChungTu_RP
            // 
            this.C_SoChungTu_RP.Enabled = false;
            this.C_SoChungTu_RP.HtLoaichungtuService = null;
            this.C_SoChungTu_RP.Location = new System.Drawing.Point(73, 105);
            this.C_SoChungTu_RP.Name = "C_SoChungTu_RP";
            this.C_SoChungTu_RP.PREFIX = null;
            this.C_SoChungTu_RP.Size = new System.Drawing.Size(100, 20);
            this.C_SoChungTu_RP.SO_CHUNG_TU = null;
            this.C_SoChungTu_RP.TabIndex = 3;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl1.Location = new System.Drawing.Point(631, 55);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(32, 13);
            this.LabelControl1.TabIndex = 103;
            this.LabelControl1.Text = "Tỷ giá ";
            this.LabelControl1.Visible = false;
            // 
            // txtTY_GIA
            // 
            this.txtTY_GIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTY_GIA.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTY_GIA.EnterMoveNextControl = true;
            this.txtTY_GIA.Location = new System.Drawing.Point(681, 52);
            this.txtTY_GIA.Name = "txtTY_GIA";
            this.txtTY_GIA.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTY_GIA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTY_GIA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTY_GIA.Properties.Mask.EditMask = "n";
            this.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTY_GIA.Properties.MaxLength = 12;
            this.txtTY_GIA.Size = new System.Drawing.Size(99, 20);
            this.txtTY_GIA.TabIndex = 9;
            this.txtTY_GIA.Visible = false;
            // 
            // cboTyGia
            // 
            this.cboTyGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTyGia.EnterMoveNextControl = true;
            this.cboTyGia.Location = new System.Drawing.Point(681, 26);
            this.cboTyGia.Name = "cboTyGia";
            this.cboTyGia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboTyGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTyGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTyGia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", 30, "Tên ngoại tệ")});
            this.cboTyGia.Properties.ImmediatePopup = true;
            this.cboTyGia.Properties.NullText = "";
            this.cboTyGia.Size = new System.Drawing.Size(99, 20);
            this.cboTyGia.TabIndex = 8;
            this.cboTyGia.Visible = false;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl4.Location = new System.Drawing.Point(29, 107);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(28, 13);
            this.LabelControl4.TabIndex = 89;
            this.LabelControl4.Text = "Số CT";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl6.Location = new System.Drawing.Point(16, 55);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(41, 13);
            this.LabelControl6.TabIndex = 88;
            this.LabelControl6.Text = "Ngày CT";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl7.Location = new System.Drawing.Point(16, 81);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(41, 13);
            this.LabelControl7.TabIndex = 87;
            this.LabelControl7.Text = "Ngày HT";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl15.Location = new System.Drawing.Point(22, 29);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(35, 13);
            this.LabelControl15.TabIndex = 86;
            this.LabelControl15.Text = "Loại CT";
            // 
            // grlLoaiPhieuNhap
            // 
            this.grlLoaiPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grlLoaiPhieuNhap.EnterMoveNextControl = true;
            this.grlLoaiPhieuNhap.Location = new System.Drawing.Point(73, 26);
            this.grlLoaiPhieuNhap.Name = "grlLoaiPhieuNhap";
            this.grlLoaiPhieuNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLoaiPhieuNhap.Properties.NullText = "";
            this.grlLoaiPhieuNhap.Properties.View = this.GridView2;
            this.grlLoaiPhieuNhap.Size = new System.Drawing.Size(100, 20);
            this.grlLoaiPhieuNhap.TabIndex = 0;
            // 
            // GridView2
            // 
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn2,
            this.GridColumn3,
            this.GridColumn4});
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
            // GridColumn4
            // 
            this.GridColumn4.Caption = "Mã loại chứng từ";
            this.GridColumn4.FieldName = "MaLoaiCt";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 2;
            // 
            // dteNGAY_CT
            // 
            this.dteNGAY_CT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dteNGAY_CT.EditValue = null;
            this.dteNGAY_CT.EnterMoveNextControl = true;
            this.dteNGAY_CT.Location = new System.Drawing.Point(73, 52);
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
            // 
            // dteNGAY_GHI
            // 
            this.dteNGAY_GHI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dteNGAY_GHI.EditValue = null;
            this.dteNGAY_GHI.EnterMoveNextControl = true;
            this.dteNGAY_GHI.Location = new System.Drawing.Point(73, 78);
            this.dteNGAY_GHI.Name = "dteNGAY_GHI";
            this.dteNGAY_GHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_GHI.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNGAY_GHI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNGAY_GHI.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
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
            // txtNGUOI_GIAO_NHAN_HANG
            // 
            this.txtNGUOI_GIAO_NHAN_HANG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNGUOI_GIAO_NHAN_HANG.EnterMoveNextControl = true;
            this.txtNGUOI_GIAO_NHAN_HANG.Location = new System.Drawing.Point(257, 26);
            this.txtNGUOI_GIAO_NHAN_HANG.Name = "txtNGUOI_GIAO_NHAN_HANG";
            this.txtNGUOI_GIAO_NHAN_HANG.Properties.MaxLength = 128;
            this.txtNGUOI_GIAO_NHAN_HANG.Size = new System.Drawing.Size(343, 20);
            this.txtNGUOI_GIAO_NHAN_HANG.TabIndex = 4;
            // 
            // txtDIEN_GIAI
            // 
            this.txtDIEN_GIAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDIEN_GIAI.EnterMoveNextControl = true;
            this.txtDIEN_GIAI.Location = new System.Drawing.Point(256, 52);
            this.txtDIEN_GIAI.Name = "txtDIEN_GIAI";
            this.txtDIEN_GIAI.Properties.MaxLength = 256;
            this.txtDIEN_GIAI.Size = new System.Drawing.Size(343, 20);
            this.txtDIEN_GIAI.TabIndex = 5;
            // 
            // labelControl33
            // 
            this.labelControl33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl33.Location = new System.Drawing.Point(201, 55);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(40, 13);
            this.labelControl33.TabIndex = 73;
            this.labelControl33.Text = "Diễn giải";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Location = new System.Drawing.Point(190, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Người giao";
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(4, 4);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.GroupControl1);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.GroupControl2);
            this.SplitContainerControl1.Panel2.MinSize = 800;
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(1000, 574);
            this.SplitContainerControl1.SplitterPosition = 194;
            this.SplitContainerControl1.TabIndex = 1;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // PhieuDieuXuatDieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.PanelControl2);
            this.KeyPreview = true;
            this.Name = "PhieuDieuXuatDieuChuyen";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu điều chuyển ";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLPN_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLPX_Hnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl3)).EndInit();
            this.GroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl6)).EndInit();
            this.GroupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuDieuChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuDieuChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GFilterEdit_HANGHOA_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKhoNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKhoXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_TKC_GIAVON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gfilter_TKN_GIAVON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVuViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSanXuatXuatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPXXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSanXuatNhapId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPXNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTKco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLenhSxNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanXuongXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl5)).EndInit();
            this.GroupControl5.ResumeLayout(false);
            this.GroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl4)).EndInit();
            this.GroupControl4.ResumeLayout(false);
            this.GroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTY_GIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTyGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_GHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUOI_GIAO_NHAN_HANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIEN_GIAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl grcLPN_Hnx;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvLPX_Hnx;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_GHI;
        internal DevExpress.XtraGrid.Columns.GridColumn CT_SO;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_CT;
        internal DevExpress.XtraEditors.SimpleButton btnQuit;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraEditors.GroupControl GroupControl3;
        internal DevExpress.XtraEditors.GroupControl GroupControl4;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtTY_GIA;
        private DevExpress.XtraEditors.LookUpEdit cboTyGia;
        private DevExpress.XtraEditors.LabelControl LabelControl4;
        private DevExpress.XtraEditors.LabelControl LabelControl6;
        private DevExpress.XtraEditors.LabelControl LabelControl7;
        private DevExpress.XtraEditors.LabelControl LabelControl15;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLoaiPhieuNhap;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        private DevExpress.XtraEditors.DateEdit dteNGAY_CT;
        private DevExpress.XtraEditors.DateEdit dteNGAY_GHI;
        internal DevExpress.XtraEditors.TextEdit txtNGUOI_GIAO_NHAN_HANG;
        internal DevExpress.XtraEditors.TextEdit txtDIEN_GIAI;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.GroupControl GroupControl5;
        internal DevExpress.XtraEditors.TextEdit txtTongSL;
        private DevExpress.XtraEditors.LabelControl LabelControl14;
        internal DevExpress.XtraEditors.TextEdit TxtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        internal DevExpress.XtraEditors.GroupControl GroupControl6;
        internal DevExpress.XtraGrid.GridControl grcPhieuDieuChuyen;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvPhieuDieuChuyen;
        internal DevExpress.XtraGrid.Columns.GridColumn HANGHOA_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMaHang;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_HANGHOA;
        internal DevExpress.XtraGrid.Columns.GridColumn DVT_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDVT;
        internal DevExpress.XtraGrid.Columns.GridColumn KHO_NHAP_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMaKhoNhap;
        internal DevExpress.XtraGrid.Columns.GridColumn KHO_XUAT_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMaKhoXuat;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_LUONG;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spdSoLuong;
        internal DevExpress.XtraGrid.Columns.GridColumn DON_GIA_VON;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spdDonGia;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spdTongTien;
        internal DevExpress.XtraGrid.Columns.GridColumn DON_GIA_VON_NTE;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_VON_NT;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TKC_GIAVON;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTKco;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TKN_GIAVON;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTKno;
        internal DevExpress.XtraGrid.Columns.GridColumn VUVIEC_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboVuViec;
        internal DevExpress.XtraEditors.CheckEdit CheckEdit1;
        internal DevExpress.XtraEditors.ControlNavigator navWelding1;
        internal DevExpress.XtraEditors.SimpleButton btnSea;
        internal DevExpress.XtraEditors.SimpleButton btnCan;
        internal DevExpress.XtraEditors.SimpleButton btnPri;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraEditors.SimpleButton btnMod;
        internal DevExpress.XtraEditors.SimpleButton btnDel;
        internal DevExpress.XtraEditors.SimpleButton btnSav;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl10;
        internal Vns.Erp.Core.Controls.UserControl.Status_LoaiCT urcGhi;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit GFilterEdit_HANGHOA_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn THU_TU;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit5;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_DVT;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit Gfilter_TKC_GIAVON;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit Gfilter_TKN_GIAVON;
        internal Vns.Erp.Core.Controls.UserControl.C_SoChungTu C_SoChungTu_RP;
        private DevExpress.XtraEditors.LabelControl lblKhoXuat;
        private DevExpress.XtraEditors.LabelControl lblKhoNhap;
        internal DevExpress.XtraEditors.LookUpEdit cboKhoXuat;
        internal DevExpress.XtraEditors.LookUpEdit cboKhoNhap;
        internal DevExpress.XtraGrid.Columns.GridColumn TON_KHO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit6;
        internal DevExpress.XtraGrid.Columns.GridColumn ThuTu;
        internal DevExpress.XtraGrid.Columns.GridColumn CtSo;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayGhi;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayCt;
        internal DevExpress.XtraGrid.Columns.GridColumn HangHoaId;
        internal DevExpress.XtraGrid.Columns.GridColumn Ghi;
        private DevExpress.XtraGrid.Columns.GridColumn LenhSanXuatXuatId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboLenhSxXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn LenhSanXuatNhapId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboLenhSxNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn PhanXuongXuatId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboPhanXuongXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn PhanXuongNhapId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboPhanXuongNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboLenhSanXuatXuatId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboPXXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboLenhSanXuatNhapId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboPXNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        //public PhieuDieuXuatDieuChuyen()
        //{
        //    InitializeComponent();
        //}
    }
}