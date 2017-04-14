using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmThongTinTaiSan_DanhSach : DevExpress.XtraEditors.XtraForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcTSCD = new DevExpress.XtraGrid.GridControl();
            this.grvTSCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTscd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaitaisan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MD_TK_TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MD_TK_KHAUHAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MD_TK_CHIPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KTKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_NAM_SD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NUOC_SX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM_SX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THONGSO_KYTHUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.MultiExportButton1 = new Vns.Erp.Core.MultiExportButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this._GroupControlSearch = new DevExpress.XtraEditors.GroupControl();
            this.txttenLoaiTS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTS = new DevExpress.XtraEditors.TextEdit();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.grlLoaiTSCD = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTSCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTSCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).BeginInit();
            this._GroupControlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenLoaiTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiTSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.grcTSCD);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 117);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1000, 455);
            this.GroupControl1.TabIndex = 1;
            this.GroupControl1.Text = "Thông tin tài sản cố định";
            // 
            // grcTSCD
            // 
            this.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTSCD.Location = new System.Drawing.Point(2, 22);
            this.grcTSCD.MainView = this.grvTSCD;
            this.grcTSCD.Name = "grcTSCD";
            this.grcTSCD.Size = new System.Drawing.Size(996, 431);
            this.grcTSCD.TabIndex = 0;
            this.grcTSCD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTSCD});
            // 
            // grvTSCD
            // 
            this.grvTSCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTscd,
            this.TenTscd,
            this.KyHieu,
            this.TenLoaitaisan,
            this.NgayMua,
            this.MD_TK_TS,
            this.MD_TK_KHAUHAO,
            this.MD_TK_CHIPHI,
            this.NGAY_BDSD,
            this.NGAY_BDKH,
            this.NGAY_KTKH,
            this.SO_NAM_SD,
            this.NUOC_SX,
            this.NAM_SX,
            this.THONGSO_KYTHUAT});
            this.grvTSCD.GridControl = this.grcTSCD;
            this.grvTSCD.Name = "grvTSCD";
            this.grvTSCD.OptionsView.ColumnAutoWidth = false;
            this.grvTSCD.OptionsView.ShowGroupPanel = false;
            // 
            // MaTscd
            // 
            this.MaTscd.Caption = "Mã TSCD";
            this.MaTscd.FieldName = "MaTscd";
            this.MaTscd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaTscd.Name = "MaTscd";
            this.MaTscd.OptionsColumn.ReadOnly = true;
            this.MaTscd.Visible = true;
            this.MaTscd.VisibleIndex = 0;
            this.MaTscd.Width = 100;
            // 
            // TenTscd
            // 
            this.TenTscd.Caption = "Tên TSCD";
            this.TenTscd.FieldName = "TenTscd";
            this.TenTscd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenTscd.Name = "TenTscd";
            this.TenTscd.OptionsColumn.ReadOnly = true;
            this.TenTscd.Visible = true;
            this.TenTscd.VisibleIndex = 1;
            this.TenTscd.Width = 214;
            // 
            // KyHieu
            // 
            this.KyHieu.Caption = "Ký hiệu";
            this.KyHieu.FieldName = "KyHieu";
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.OptionsColumn.ReadOnly = true;
            this.KyHieu.Visible = true;
            this.KyHieu.VisibleIndex = 2;
            this.KyHieu.Width = 179;
            // 
            // TenLoaitaisan
            // 
            this.TenLoaitaisan.Caption = "Tên loại TSCD";
            this.TenLoaitaisan.FieldName = "TenLoaitaisan";
            this.TenLoaitaisan.Name = "TenLoaitaisan";
            this.TenLoaitaisan.OptionsColumn.ReadOnly = true;
            this.TenLoaitaisan.Visible = true;
            this.TenLoaitaisan.VisibleIndex = 3;
            this.TenLoaitaisan.Width = 187;
            // 
            // NgayMua
            // 
            this.NgayMua.Caption = "Ngày mua";
            this.NgayMua.FieldName = "NgayMua";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.OptionsColumn.AllowEdit = false;
            this.NgayMua.OptionsColumn.ReadOnly = true;
            this.NgayMua.Visible = true;
            this.NgayMua.VisibleIndex = 4;
            this.NgayMua.Width = 101;
            // 
            // MD_TK_TS
            // 
            this.MD_TK_TS.Caption = "Tài khoản tài sản";
            this.MD_TK_TS.FieldName = "MaMdTkTs";
            this.MD_TK_TS.Name = "MD_TK_TS";
            this.MD_TK_TS.OptionsColumn.ReadOnly = true;
            this.MD_TK_TS.Visible = true;
            this.MD_TK_TS.VisibleIndex = 10;
            this.MD_TK_TS.Width = 102;
            // 
            // MD_TK_KHAUHAO
            // 
            this.MD_TK_KHAUHAO.Caption = "Tài khoản khấu hao";
            this.MD_TK_KHAUHAO.FieldName = "MaMdTkKhauhao";
            this.MD_TK_KHAUHAO.Name = "MD_TK_KHAUHAO";
            this.MD_TK_KHAUHAO.OptionsColumn.ReadOnly = true;
            this.MD_TK_KHAUHAO.Visible = true;
            this.MD_TK_KHAUHAO.VisibleIndex = 9;
            this.MD_TK_KHAUHAO.Width = 118;
            // 
            // MD_TK_CHIPHI
            // 
            this.MD_TK_CHIPHI.Caption = "Tài khoản chi phí";
            this.MD_TK_CHIPHI.FieldName = "MaMdTkChiphi";
            this.MD_TK_CHIPHI.Name = "MD_TK_CHIPHI";
            this.MD_TK_CHIPHI.OptionsColumn.ReadOnly = true;
            this.MD_TK_CHIPHI.Visible = true;
            this.MD_TK_CHIPHI.VisibleIndex = 8;
            this.MD_TK_CHIPHI.Width = 111;
            // 
            // NGAY_BDSD
            // 
            this.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng";
            this.NGAY_BDSD.FieldName = "NgayBdsd";
            this.NGAY_BDSD.Name = "NGAY_BDSD";
            this.NGAY_BDSD.OptionsColumn.AllowEdit = false;
            this.NGAY_BDSD.OptionsColumn.ReadOnly = true;
            this.NGAY_BDSD.Visible = true;
            this.NGAY_BDSD.VisibleIndex = 6;
            this.NGAY_BDSD.Width = 135;
            // 
            // NGAY_BDKH
            // 
            this.NGAY_BDKH.Caption = "Ngày bắt đầu khấu hao";
            this.NGAY_BDKH.FieldName = "NgayBdkh";
            this.NGAY_BDKH.Name = "NGAY_BDKH";
            this.NGAY_BDKH.OptionsColumn.AllowEdit = false;
            this.NGAY_BDKH.OptionsColumn.ReadOnly = true;
            this.NGAY_BDKH.Visible = true;
            this.NGAY_BDKH.VisibleIndex = 5;
            this.NGAY_BDKH.Width = 134;
            // 
            // NGAY_KTKH
            // 
            this.NGAY_KTKH.Caption = "Ngày kết thúc khấu hao";
            this.NGAY_KTKH.FieldName = "NgayKtkh";
            this.NGAY_KTKH.Name = "NGAY_KTKH";
            this.NGAY_KTKH.OptionsColumn.AllowEdit = false;
            this.NGAY_KTKH.OptionsColumn.ReadOnly = true;
            this.NGAY_KTKH.Visible = true;
            this.NGAY_KTKH.VisibleIndex = 7;
            this.NGAY_KTKH.Width = 142;
            // 
            // SO_NAM_SD
            // 
            this.SO_NAM_SD.Caption = "Số tháng sử dụng";
            this.SO_NAM_SD.FieldName = "SoThangSd";
            this.SO_NAM_SD.Name = "SO_NAM_SD";
            this.SO_NAM_SD.OptionsColumn.ReadOnly = true;
            this.SO_NAM_SD.Visible = true;
            this.SO_NAM_SD.VisibleIndex = 14;
            this.SO_NAM_SD.Width = 172;
            // 
            // NUOC_SX
            // 
            this.NUOC_SX.Caption = "Nước sản xuất";
            this.NUOC_SX.FieldName = "NuocSx";
            this.NUOC_SX.Name = "NUOC_SX";
            this.NUOC_SX.OptionsColumn.ReadOnly = true;
            this.NUOC_SX.Visible = true;
            this.NUOC_SX.VisibleIndex = 12;
            this.NUOC_SX.Width = 99;
            // 
            // NAM_SX
            // 
            this.NAM_SX.Caption = "Năm sản xuất";
            this.NAM_SX.FieldName = "NamSx";
            this.NAM_SX.Name = "NAM_SX";
            this.NAM_SX.OptionsColumn.ReadOnly = true;
            this.NAM_SX.Visible = true;
            this.NAM_SX.VisibleIndex = 11;
            this.NAM_SX.Width = 91;
            // 
            // THONGSO_KYTHUAT
            // 
            this.THONGSO_KYTHUAT.Caption = "Thông số kỹ thuật";
            this.THONGSO_KYTHUAT.FieldName = "ThongsoKythuat";
            this.THONGSO_KYTHUAT.Name = "THONGSO_KYTHUAT";
            this.THONGSO_KYTHUAT.OptionsColumn.ReadOnly = true;
            this.THONGSO_KYTHUAT.Visible = true;
            this.THONGSO_KYTHUAT.VisibleIndex = 13;
            this.THONGSO_KYTHUAT.Width = 111;
            // 
            // _ActionPanel
            // 
            this._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ActionPanel.Controls.Add(this.btnDelete);
            this._ActionPanel.Controls.Add(this.MultiExportButton1);
            this._ActionPanel.Controls.Add(this.btnClose);
            this._ActionPanel.Controls.Add(this.btnModify);
            this._ActionPanel.Controls.Add(this.btnAdd);
            this._ActionPanel.Controls.Add(this.btnPrint);
            this._ActionPanel.Controls.Add(this.btnXem);
            this._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ActionPanel.Location = new System.Drawing.Point(4, 572);
            this._ActionPanel.Name = "_ActionPanel";
            this._ActionPanel.Size = new System.Drawing.Size(1000, 36);
            this._ActionPanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.ImageIndex = 5;
            this.btnDelete.Location = new System.Drawing.Point(172, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Xóa";
            // 
            // MultiExportButton1
            // 
            this.MultiExportButton1.GRID_VIEW = this.grvTSCD;
            this.MultiExportButton1.Location = new System.Drawing.Point(528, 4);
            this.MultiExportButton1.Name = "MultiExportButton1";
            this.MultiExportButton1.Size = new System.Drawing.Size(135, 30);
            this.MultiExportButton1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 6;
            this.btnClose.Location = new System.Drawing.Point(919, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Ðó&ng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.ImageIndex = 3;
            this.btnModify.Location = new System.Drawing.Point(86, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Sửa";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(2, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Mới";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.ImageIndex = 5;
            this.btnPrint.Location = new System.Drawing.Point(258, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&In";
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXem.ImageIndex = 5;
            this.btnXem.Location = new System.Drawing.Point(344, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(80, 30);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "X&em";
            this.btnXem.Visible = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // _GroupControlSearch
            // 
            this._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White;
            this._GroupControlSearch.Appearance.Options.UseBackColor = true;
            this._GroupControlSearch.Appearance.Options.UseBorderColor = true;
            this._GroupControlSearch.Controls.Add(this.txttenLoaiTS);
            this._GroupControlSearch.Controls.Add(this.txtTenTS);
            this._GroupControlSearch.Controls.Add(this.dteDenNgay);
            this._GroupControlSearch.Controls.Add(this.LabelControl5);
            this._GroupControlSearch.Controls.Add(this.dteTuNgay);
            this._GroupControlSearch.Controls.Add(this.LabelControl4);
            this._GroupControlSearch.Controls.Add(this.btnSearch);
            this._GroupControlSearch.Controls.Add(this.grlLoaiTSCD);
            this._GroupControlSearch.Controls.Add(this.LabelControl3);
            this._GroupControlSearch.Controls.Add(this.LabelControl1);
            this._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this._GroupControlSearch.Location = new System.Drawing.Point(4, 4);
            this._GroupControlSearch.Name = "_GroupControlSearch";
            this._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._GroupControlSearch.Size = new System.Drawing.Size(1000, 109);
            this._GroupControlSearch.TabIndex = 0;
            this._GroupControlSearch.Text = "Tìm kiếm";
            // 
            // txttenLoaiTS
            // 
            this.txttenLoaiTS.Location = new System.Drawing.Point(181, 53);
            this.txttenLoaiTS.Name = "txttenLoaiTS";
            this.txttenLoaiTS.Properties.ReadOnly = true;
            this.txttenLoaiTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttenLoaiTS.Size = new System.Drawing.Size(172, 20);
            this.txttenLoaiTS.TabIndex = 14;
            this.txttenLoaiTS.TabStop = false;
            // 
            // txtTenTS
            // 
            this.txtTenTS.EnterMoveNextControl = true;
            this.txtTenTS.Location = new System.Drawing.Point(75, 77);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenTS.Size = new System.Drawing.Size(278, 20);
            this.txtTenTS.TabIndex = 3;
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = null;
            this.dteDenNgay.EnterMoveNextControl = true;
            this.dteDenNgay.Location = new System.Drawing.Point(253, 27);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteDenNgay.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dteDenNgay.TabIndex = 1;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(194, 30);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(47, 13);
            this.LabelControl5.TabIndex = 11;
            this.LabelControl5.Text = "Đến ngày";
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.EnterMoveNextControl = true;
            this.dteTuNgay.Location = new System.Drawing.Point(75, 27);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteTuNgay.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dteTuNgay.TabIndex = 0;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(20, 30);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(40, 13);
            this.LabelControl4.TabIndex = 10;
            this.LabelControl4.Text = "Từ ngày";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // grlLoaiTSCD
            // 
            this.grlLoaiTSCD.EnterMoveNextControl = true;
            this.grlLoaiTSCD.Location = new System.Drawing.Point(75, 53);
            this.grlLoaiTSCD.Name = "grlLoaiTSCD";
            this.grlLoaiTSCD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLoaiTSCD.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.grlLoaiTSCD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLoaiTSCD.Properties.ImmediatePopup = true;
            this.grlLoaiTSCD.Properties.NullText = "";
            this.grlLoaiTSCD.Properties.View = this.GridView2;
            this.grlLoaiTSCD.Size = new System.Drawing.Size(100, 20);
            this.grlLoaiTSCD.TabIndex = 2;
            // 
            // GridView2
            // 
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(12, 56);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(48, 13);
            this.LabelControl3.TabIndex = 6;
            this.LabelControl3.Text = "Loại TSCD";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(13, 80);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(47, 13);
            this.LabelControl1.TabIndex = 7;
            this.LabelControl1.Text = "Tên TSCD";
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(4, 113);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1000, 4);
            this.PanelControl1.TabIndex = 27;
            // 
            // frmThongTinTaiSan_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this._GroupControlSearch);
            this.Controls.Add(this._ActionPanel);
            this.KeyPreview = true;
            this.Name = "frmThongTinTaiSan_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Thông tin tài sản cố định";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcTSCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTSCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GroupControlSearch)).EndInit();
            this._GroupControlSearch.ResumeLayout(false);
            this._GroupControlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenLoaiTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLoaiTSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl grcTSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvTSCD;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        //Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TSCD;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LOAITAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn NUOC_SX;
        internal DevExpress.XtraGrid.Columns.GridColumn NAM_SX;
        internal DevExpress.XtraGrid.Columns.GridColumn THONGSO_KYTHUAT;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_MUA;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDSD;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_BDKH;
        internal DevExpress.XtraGrid.Columns.GridColumn NGAY_KTKH;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_NAM_SD;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_TS;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_KHAUHAO;
        internal DevExpress.XtraGrid.Columns.GridColumn MD_TK_CHIPHI;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.GroupControl _GroupControlSearch;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.TextEdit txttenLoaiTS;
        internal DevExpress.XtraEditors.TextEdit txtTenTS;
        internal DevExpress.XtraEditors.DateEdit dteDenNgay;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.DateEdit dteTuNgay;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.SimpleButton btnSearch;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLoaiTSCD;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal Vns.Erp.Core.MultiExportButton MultiExportButton1;
        internal DevExpress.XtraEditors.SimpleButton btnXem;
        internal DevExpress.XtraGrid.Columns.GridColumn MaTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn TenTscd;
        internal DevExpress.XtraGrid.Columns.GridColumn KyHieu;
        internal DevExpress.XtraGrid.Columns.GridColumn TenLoaitaisan;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayMua;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}