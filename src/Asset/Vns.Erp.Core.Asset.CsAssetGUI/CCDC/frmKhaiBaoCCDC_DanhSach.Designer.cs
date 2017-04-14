using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{

    partial class frmKhaiBaoCCDC_DanhSach : DevExpress.XtraEditors.XtraForm
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
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcCCDC = new DevExpress.XtraGrid.GridControl();
            this.grvCCDC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCcdc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCcdc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NuocSx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBdsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.SoKyPhanbo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiPhanbo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguyenGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GiaTriCl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MdTkCcdc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MdTkPhanbo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MdTkChiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this._ActionPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.MultiExportButton1 = new Vns.Erp.Core.MultiExportButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCCDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCCDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).BeginInit();
            this._ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.grcCCDC);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1000, 568);
            this.GroupControl1.TabIndex = 28;
            this.GroupControl1.Text = "Thông tin công cụ dụng cụ";
            // 
            // grcCCDC
            // 
            this.grcCCDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCCDC.Location = new System.Drawing.Point(2, 22);
            this.grcCCDC.MainView = this.grvCCDC;
            this.grcCCDC.Name = "grcCCDC";
            this.grcCCDC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2,
            this.RepositoryItemDateEdit1});
            this.grcCCDC.Size = new System.Drawing.Size(996, 544);
            this.grcCCDC.TabIndex = 0;
            this.grcCCDC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCCDC});
            // 
            // grvCCDC
            // 
            this.grvCCDC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCcdc,
            this.TenCcdc,
            this.SoLuong,
            this.NuocSx,
            this.NamSx,
            this.NgayMua,
            this.NgayBdsd,
            this.SoKyPhanbo,
            this.TenLoaiPhanbo,
            this.NguyenGia,
            this.GiaTriCl,
            this.MdTkCcdc,
            this.MdTkPhanbo,
            this.MdTkChiphi,
            this.GridColumn1});
            this.grvCCDC.GridControl = this.grcCCDC;
            this.grvCCDC.Name = "grvCCDC";
            this.grvCCDC.OptionsView.ColumnAutoWidth = false;
            this.grvCCDC.OptionsView.ShowAutoFilterRow = true;
            this.grvCCDC.OptionsView.ShowGroupPanel = false;
            // 
            // MaCcdc
            // 
            this.MaCcdc.Caption = "Mã công cụ";
            this.MaCcdc.FieldName = "MaCcdc";
            this.MaCcdc.Name = "MaCcdc";
            this.MaCcdc.OptionsColumn.ReadOnly = true;
            this.MaCcdc.Visible = true;
            this.MaCcdc.VisibleIndex = 0;
            this.MaCcdc.Width = 100;
            // 
            // TenCcdc
            // 
            this.TenCcdc.Caption = "Tên công cụ";
            this.TenCcdc.FieldName = "TenCcdc";
            this.TenCcdc.Name = "TenCcdc";
            this.TenCcdc.OptionsColumn.ReadOnly = true;
            this.TenCcdc.Visible = true;
            this.TenCcdc.VisibleIndex = 1;
            this.TenCcdc.Width = 214;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 148;
            // 
            // NuocSx
            // 
            this.NuocSx.Caption = "Nước sản xuất";
            this.NuocSx.FieldName = "NuocSx";
            this.NuocSx.Name = "NuocSx";
            this.NuocSx.OptionsColumn.ReadOnly = true;
            this.NuocSx.Width = 102;
            // 
            // NamSx
            // 
            this.NamSx.Caption = "Năm sản xuất";
            this.NamSx.FieldName = "NamSx";
            this.NamSx.Name = "NamSx";
            this.NamSx.OptionsColumn.ReadOnly = true;
            this.NamSx.Width = 118;
            // 
            // NgayMua
            // 
            this.NgayMua.Caption = "Ngày mua";
            this.NgayMua.FieldName = "NgayMua";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.OptionsColumn.ReadOnly = true;
            this.NgayMua.Width = 111;
            // 
            // NgayBdsd
            // 
            this.NgayBdsd.Caption = "Ngày BĐSD";
            this.NgayBdsd.ColumnEdit = this.RepositoryItemDateEdit1;
            this.NgayBdsd.FieldName = "NgayBdsd";
            this.NgayBdsd.Name = "NgayBdsd";
            this.NgayBdsd.OptionsColumn.AllowEdit = false;
            this.NgayBdsd.OptionsColumn.ReadOnly = true;
            this.NgayBdsd.Visible = true;
            this.NgayBdsd.VisibleIndex = 4;
            this.NgayBdsd.Width = 135;
            // 
            // RepositoryItemDateEdit1
            // 
            this.RepositoryItemDateEdit1.AutoHeight = false;
            this.RepositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1";
            this.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // SoKyPhanbo
            // 
            this.SoKyPhanbo.Caption = "Số kỳ phân bổ";
            this.SoKyPhanbo.FieldName = "SoKyPhanbo";
            this.SoKyPhanbo.Name = "SoKyPhanbo";
            this.SoKyPhanbo.OptionsColumn.AllowEdit = false;
            this.SoKyPhanbo.OptionsColumn.ReadOnly = true;
            this.SoKyPhanbo.Visible = true;
            this.SoKyPhanbo.VisibleIndex = 3;
            this.SoKyPhanbo.Width = 93;
            // 
            // TenLoaiPhanbo
            // 
            this.TenLoaiPhanbo.Caption = "Kiểu phân bổ";
            this.TenLoaiPhanbo.FieldName = "TenLoaiPhanbo";
            this.TenLoaiPhanbo.Name = "TenLoaiPhanbo";
            this.TenLoaiPhanbo.OptionsColumn.AllowEdit = false;
            this.TenLoaiPhanbo.OptionsColumn.ReadOnly = true;
            this.TenLoaiPhanbo.Visible = true;
            this.TenLoaiPhanbo.VisibleIndex = 5;
            this.TenLoaiPhanbo.Width = 142;
            // 
            // NguyenGia
            // 
            this.NguyenGia.Caption = "Nguyên giá";
            this.NguyenGia.ColumnEdit = this.RepositoryItemTextEdit1;
            this.NguyenGia.FieldName = "NguyenGia";
            this.NguyenGia.Name = "NguyenGia";
            this.NguyenGia.OptionsColumn.ReadOnly = true;
            this.NguyenGia.Visible = true;
            this.NguyenGia.VisibleIndex = 7;
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // GiaTriCl
            // 
            this.GiaTriCl.Caption = "Số tiền còn lại";
            this.GiaTriCl.ColumnEdit = this.RepositoryItemTextEdit2;
            this.GiaTriCl.FieldName = "GiaTriCl";
            this.GiaTriCl.Name = "GiaTriCl";
            this.GiaTriCl.OptionsColumn.ReadOnly = true;
            this.GiaTriCl.Visible = true;
            this.GiaTriCl.VisibleIndex = 6;
            this.GiaTriCl.Width = 172;
            // 
            // RepositoryItemTextEdit2
            // 
            this.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepositoryItemTextEdit2.AutoHeight = false;
            this.RepositoryItemTextEdit2.Mask.EditMask = "n0";
            this.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2";
            // 
            // MdTkCcdc
            // 
            this.MdTkCcdc.Caption = "TK công cụ";
            this.MdTkCcdc.FieldName = "MdTkCcdc";
            this.MdTkCcdc.Name = "MdTkCcdc";
            this.MdTkCcdc.OptionsColumn.ReadOnly = true;
            this.MdTkCcdc.Visible = true;
            this.MdTkCcdc.VisibleIndex = 8;
            this.MdTkCcdc.Width = 99;
            // 
            // MdTkPhanbo
            // 
            this.MdTkPhanbo.Caption = "TK phân bổ";
            this.MdTkPhanbo.FieldName = "MdTkPhanbo";
            this.MdTkPhanbo.Name = "MdTkPhanbo";
            this.MdTkPhanbo.OptionsColumn.ReadOnly = true;
            this.MdTkPhanbo.Visible = true;
            this.MdTkPhanbo.VisibleIndex = 9;
            this.MdTkPhanbo.Width = 91;
            // 
            // MdTkChiphi
            // 
            this.MdTkChiphi.Caption = "TK chi phí";
            this.MdTkChiphi.FieldName = "MdTkChiphi";
            this.MdTkChiphi.Name = "MdTkChiphi";
            this.MdTkChiphi.OptionsColumn.ReadOnly = true;
            this.MdTkChiphi.Visible = true;
            this.MdTkChiphi.VisibleIndex = 10;
            this.MdTkChiphi.Width = 111;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Ghi chú";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 11;
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
            this._ActionPanel.TabIndex = 29;
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
            this.MultiExportButton1.GRID_VIEW = this.grvCCDC;
            this.MultiExportButton1.Location = new System.Drawing.Point(527, 4);
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
            // 
            // frmKhaiBaoCCDC_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this._ActionPanel);
            this.Name = "frmKhaiBaoCCDC_DanhSach";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Khai báo CCDC";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcCCDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCCDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ActionPanel)).EndInit();
            this._ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraGrid.GridControl grcCCDC;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvCCDC;
        internal DevExpress.XtraGrid.Columns.GridColumn MaCcdc;
        internal DevExpress.XtraGrid.Columns.GridColumn TenCcdc;
        internal DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        internal DevExpress.XtraGrid.Columns.GridColumn NuocSx;
        internal DevExpress.XtraGrid.Columns.GridColumn NamSx;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayMua;
        internal DevExpress.XtraGrid.Columns.GridColumn NgayBdsd;
        internal DevExpress.XtraGrid.Columns.GridColumn SoKyPhanbo;
        internal DevExpress.XtraGrid.Columns.GridColumn TenLoaiPhanbo;
        internal DevExpress.XtraGrid.Columns.GridColumn GiaTriCl;
        internal DevExpress.XtraGrid.Columns.GridColumn MdTkCcdc;
        internal DevExpress.XtraGrid.Columns.GridColumn MdTkPhanbo;
        internal DevExpress.XtraGrid.Columns.GridColumn MdTkChiphi;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraEditors.PanelControl _ActionPanel;
        internal DevExpress.XtraEditors.SimpleButton btnDelete;
        internal Vns.Erp.Core.MultiExportButton MultiExportButton1;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnModify;
        internal DevExpress.XtraEditors.SimpleButton btnAdd;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnXem;
        internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit1;
        internal DevExpress.XtraGrid.Columns.GridColumn NguyenGia;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;

    }
}