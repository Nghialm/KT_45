using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmDieuChinhGiaTriTaiSan_ChiTiet : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuChinhGiaTriTaiSan_ChiTiet));
            this.grcTHONG_TIN_CHINH = new DevExpress.XtraEditors.GroupControl();
            this.txtSO_CT1 = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAY_CT1 = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_KT_KH1 = new DevExpress.XtraEditors.DateEdit();
            this.dteNgay_BD_KH1 = new DevExpress.XtraEditors.DateEdit();
            this.grlLYDO_TANGGIAM = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KY_HIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LYDO_TG_TSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grlTANG_TSCD1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHAO_MON_LUY_KE1 = new DevExpress.XtraEditors.TextEdit();
            this.txtSO_THANG_SD1 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGUYEN_GIA1 = new DevExpress.XtraEditors.TextEdit();
            this.txtGIA_TRI_CL1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLyDo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTangGiam = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTS = new DevExpress.XtraEditors.TextEdit();
            this.txtMA_TSCD = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcNGUON_VON = new DevExpress.XtraGrid.GridControl();
            this.grvNGUON_VON = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DM_NGUON_TSCD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDM_NGUON_TSCD_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_TK_KHAUHAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeTK_TAISAN = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.MA_TK_CHIPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpeTK_CHIPHI = new Vns.Erp.Core.RepositoryItemPopupFilterEdit();
            this.HE_SO_PB_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NGUYEN_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HAO_MON_LUY_KE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIA_TRI_CON_LAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEN_GIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboLY_DO_TANGGIAM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_TAISAN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcTHONG_TIN_CHINH)).BeginInit();
            this.grcTHONG_TIN_CHINH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_CT1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KT_KH1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KT_KH1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay_BD_KH1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay_BD_KH1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLYDO_TANGGIAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlTANG_TSCD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LUY_KE1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_THANG_SD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUYEN_GIA1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTangGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_TSCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // grcTHONG_TIN_CHINH
            // 
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtSO_CT1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.dteNGAY_CT1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.dteNGAY_KT_KH1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.dteNgay_BD_KH1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.grlLYDO_TANGGIAM);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl10);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl7);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.grlTANG_TSCD1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl8);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl4);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtHAO_MON_LUY_KE1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtSO_THANG_SD1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl11);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtNGUYEN_GIA1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtGIA_TRI_CL1);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtTenLyDo);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtTenTangGiam);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtTenTS);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.txtMA_TSCD);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl6);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl2);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl9);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl3);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl5);
            this.grcTHONG_TIN_CHINH.Controls.Add(this.LabelControl1);
            this.grcTHONG_TIN_CHINH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcTHONG_TIN_CHINH.Location = new System.Drawing.Point(4, 4);
            this.grcTHONG_TIN_CHINH.Name = "grcTHONG_TIN_CHINH";
            this.grcTHONG_TIN_CHINH.Size = new System.Drawing.Size(907, 133);
            this.grcTHONG_TIN_CHINH.TabIndex = 0;
            this.grcTHONG_TIN_CHINH.Text = "Thông tin điều chỉnh giá trị TSCD";
            // 
            // txtSO_CT1
            // 
            this.txtSO_CT1.EnterMoveNextControl = true;
            this.txtSO_CT1.Location = new System.Drawing.Point(102, 51);
            this.txtSO_CT1.Name = "txtSO_CT1";
            this.txtSO_CT1.Properties.MaxLength = 32;
            this.txtSO_CT1.Size = new System.Drawing.Size(100, 20);
            this.txtSO_CT1.TabIndex = 1;
            // 
            // dteNGAY_CT1
            // 
            this.dteNGAY_CT1.EditValue = null;
            this.dteNGAY_CT1.EnterMoveNextControl = true;
            this.dteNGAY_CT1.Location = new System.Drawing.Point(102, 25);
            this.dteNGAY_CT1.Name = "dteNGAY_CT1";
            this.dteNGAY_CT1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_CT1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_CT1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_CT1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_CT1.Size = new System.Drawing.Size(100, 20);
            this.dteNGAY_CT1.TabIndex = 0;
            // 
            // dteNGAY_KT_KH1
            // 
            this.dteNGAY_KT_KH1.EditValue = null;
            this.dteNGAY_KT_KH1.EnterMoveNextControl = true;
            this.dteNGAY_KT_KH1.Location = new System.Drawing.Point(102, 105);
            this.dteNGAY_KT_KH1.Name = "dteNGAY_KT_KH1";
            this.dteNGAY_KT_KH1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY_KT_KH1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_KT_KH1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_KT_KH1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_KT_KH1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_KT_KH1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNGAY_KT_KH1.Size = new System.Drawing.Size(100, 20);
            this.dteNGAY_KT_KH1.TabIndex = 3;
            // 
            // dteNgay_BD_KH1
            // 
            this.dteNgay_BD_KH1.EditValue = null;
            this.dteNgay_BD_KH1.EnterMoveNextControl = true;
            this.dteNgay_BD_KH1.Location = new System.Drawing.Point(102, 79);
            this.dteNgay_BD_KH1.Name = "dteNgay_BD_KH1";
            this.dteNgay_BD_KH1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay_BD_KH1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgay_BD_KH1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNgay_BD_KH1.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNgay_BD_KH1.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNgay_BD_KH1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgay_BD_KH1.Size = new System.Drawing.Size(100, 20);
            this.dteNgay_BD_KH1.TabIndex = 2;
            // 
            // grlLYDO_TANGGIAM
            // 
            this.grlLYDO_TANGGIAM.EnterMoveNextControl = true;
            this.grlLYDO_TANGGIAM.Location = new System.Drawing.Point(319, 75);
            this.grlLYDO_TANGGIAM.Name = "grlLYDO_TANGGIAM";
            this.grlLYDO_TANGGIAM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlLYDO_TANGGIAM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlLYDO_TANGGIAM.Properties.ImmediatePopup = true;
            this.grlLYDO_TANGGIAM.Properties.NullText = "";
            this.grlLYDO_TANGGIAM.Properties.ReadOnly = true;
            this.grlLYDO_TANGGIAM.Properties.View = this.GridView1;
            this.grlLYDO_TANGGIAM.Size = new System.Drawing.Size(100, 20);
            this.grlLYDO_TANGGIAM.TabIndex = 5;
            // 
            // GridView1
            // 
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KY_HIEU,
            this.TEN_LYDO_TG_TSCD});
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            // 
            // KY_HIEU
            // 
            this.KY_HIEU.Caption = "Ký hiệu";
            this.KY_HIEU.FieldName = "KyHieu";
            this.KY_HIEU.Name = "KY_HIEU";
            this.KY_HIEU.Visible = true;
            this.KY_HIEU.VisibleIndex = 0;
            // 
            // TEN_LYDO_TG_TSCD
            // 
            this.TEN_LYDO_TG_TSCD.Caption = "Tên lý do tăng giảm";
            this.TEN_LYDO_TG_TSCD.FieldName = "TenLydoTgTscd";
            this.TEN_LYDO_TG_TSCD.Name = "TEN_LYDO_TG_TSCD";
            this.TEN_LYDO_TG_TSCD.Visible = true;
            this.TEN_LYDO_TG_TSCD.VisibleIndex = 1;
            // 
            // LabelControl10
            // 
            this.LabelControl10.Location = new System.Drawing.Point(42, 28);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(41, 13);
            this.LabelControl10.TabIndex = 0;
            this.LabelControl10.Text = "Ngày CT";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(29, 106);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(53, 13);
            this.LabelControl7.TabIndex = 0;
            this.LabelControl7.Text = "Ngày KTKH";
            // 
            // grlTANG_TSCD1
            // 
            this.grlTANG_TSCD1.EnterMoveNextControl = true;
            this.grlTANG_TSCD1.Location = new System.Drawing.Point(319, 49);
            this.grlTANG_TSCD1.Name = "grlTANG_TSCD1";
            this.grlTANG_TSCD1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlTANG_TSCD1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlTANG_TSCD1.Properties.ImmediatePopup = true;
            this.grlTANG_TSCD1.Properties.NullText = "";
            this.grlTANG_TSCD1.Properties.View = this.GridLookUpEdit1View;
            this.grlTANG_TSCD1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grlTANG_TSCD1.Size = new System.Drawing.Size(100, 20);
            this.grlTANG_TSCD1.TabIndex = 4;
            // 
            // GridLookUpEdit1View
            // 
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(29, 80);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(54, 13);
            this.LabelControl8.TabIndex = 0;
            this.LabelControl8.Text = "Ngày BDKH";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(223, 78);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(77, 13);
            this.LabelControl4.TabIndex = 0;
            this.LabelControl4.Text = "Lý do điều chỉnh";
            // 
            // txtHAO_MON_LUY_KE1
            // 
            this.txtHAO_MON_LUY_KE1.EnterMoveNextControl = true;
            this.txtHAO_MON_LUY_KE1.Location = new System.Drawing.Point(793, 79);
            this.txtHAO_MON_LUY_KE1.Name = "txtHAO_MON_LUY_KE1";
            this.txtHAO_MON_LUY_KE1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHAO_MON_LUY_KE1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHAO_MON_LUY_KE1.Properties.Mask.EditMask = "n0";
            this.txtHAO_MON_LUY_KE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHAO_MON_LUY_KE1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHAO_MON_LUY_KE1.Properties.ReadOnly = true;
            this.txtHAO_MON_LUY_KE1.Size = new System.Drawing.Size(100, 20);
            this.txtHAO_MON_LUY_KE1.TabIndex = 8;
            // 
            // txtSO_THANG_SD1
            // 
            this.txtSO_THANG_SD1.EnterMoveNextControl = true;
            this.txtSO_THANG_SD1.Location = new System.Drawing.Point(793, 105);
            this.txtSO_THANG_SD1.Name = "txtSO_THANG_SD1";
            this.txtSO_THANG_SD1.Properties.Mask.EditMask = "[0-9]{0,4}";
            this.txtSO_THANG_SD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSO_THANG_SD1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSO_THANG_SD1.Size = new System.Drawing.Size(100, 20);
            this.txtSO_THANG_SD1.TabIndex = 9;
            // 
            // LabelControl11
            // 
            this.LabelControl11.Location = new System.Drawing.Point(55, 55);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(28, 13);
            this.LabelControl11.TabIndex = 0;
            this.LabelControl11.Text = "Số CT";
            // 
            // txtNGUYEN_GIA1
            // 
            this.txtNGUYEN_GIA1.EnterMoveNextControl = true;
            this.txtNGUYEN_GIA1.Location = new System.Drawing.Point(793, 25);
            this.txtNGUYEN_GIA1.Name = "txtNGUYEN_GIA1";
            this.txtNGUYEN_GIA1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNGUYEN_GIA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNGUYEN_GIA1.Properties.Mask.EditMask = "n0";
            this.txtNGUYEN_GIA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNGUYEN_GIA1.Properties.Mask.ShowPlaceHolders = false;
            this.txtNGUYEN_GIA1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNGUYEN_GIA1.Properties.ReadOnly = true;
            this.txtNGUYEN_GIA1.Size = new System.Drawing.Size(100, 20);
            this.txtNGUYEN_GIA1.TabIndex = 7;
            // 
            // txtGIA_TRI_CL1
            // 
            this.txtGIA_TRI_CL1.EnterMoveNextControl = true;
            this.txtGIA_TRI_CL1.Location = new System.Drawing.Point(793, 51);
            this.txtGIA_TRI_CL1.Name = "txtGIA_TRI_CL1";
            this.txtGIA_TRI_CL1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGIA_TRI_CL1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGIA_TRI_CL1.Properties.Mask.EditMask = "n0";
            this.txtGIA_TRI_CL1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGIA_TRI_CL1.Properties.Mask.ShowPlaceHolders = false;
            this.txtGIA_TRI_CL1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGIA_TRI_CL1.Properties.ReadOnly = true;
            this.txtGIA_TRI_CL1.Size = new System.Drawing.Size(100, 20);
            this.txtGIA_TRI_CL1.TabIndex = 7;
            // 
            // txtTenLyDo
            // 
            this.txtTenLyDo.EnterMoveNextControl = true;
            this.txtTenLyDo.Location = new System.Drawing.Point(425, 76);
            this.txtTenLyDo.Name = "txtTenLyDo";
            this.txtTenLyDo.Properties.ReadOnly = true;
            this.txtTenLyDo.Size = new System.Drawing.Size(248, 20);
            this.txtTenLyDo.TabIndex = 0;
            this.txtTenLyDo.TabStop = false;
            // 
            // txtTenTangGiam
            // 
            this.txtTenTangGiam.EnterMoveNextControl = true;
            this.txtTenTangGiam.Location = new System.Drawing.Point(425, 50);
            this.txtTenTangGiam.Name = "txtTenTangGiam";
            this.txtTenTangGiam.Properties.ReadOnly = true;
            this.txtTenTangGiam.Size = new System.Drawing.Size(248, 20);
            this.txtTenTangGiam.TabIndex = 0;
            this.txtTenTangGiam.TabStop = false;
            // 
            // txtTenTS
            // 
            this.txtTenTS.EnterMoveNextControl = true;
            this.txtTenTS.Location = new System.Drawing.Point(425, 24);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Properties.ReadOnly = true;
            this.txtTenTS.Size = new System.Drawing.Size(248, 20);
            this.txtTenTS.TabIndex = 0;
            this.txtTenTS.TabStop = false;
            // 
            // txtMA_TSCD
            // 
            this.txtMA_TSCD.Enabled = false;
            this.txtMA_TSCD.EnterMoveNextControl = true;
            this.txtMA_TSCD.Location = new System.Drawing.Point(319, 23);
            this.txtMA_TSCD.Name = "txtMA_TSCD";
            this.txtMA_TSCD.Size = new System.Drawing.Size(100, 20);
            this.txtMA_TSCD.TabIndex = 4;
            this.txtMA_TSCD.TabStop = false;
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(701, 83);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(73, 13);
            this.LabelControl6.TabIndex = 0;
            this.LabelControl6.Text = "Hao mòn lũy kế";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(723, 26);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(54, 13);
            this.LabelControl2.TabIndex = 0;
            this.LabelControl2.Text = "Nguyên giá";
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(692, 106);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(85, 13);
            this.LabelControl9.TabIndex = 0;
            this.LabelControl9.Text = "Số tháng sử dụng";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(247, 52);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(53, 13);
            this.LabelControl3.TabIndex = 0;
            this.LabelControl3.Text = "Tăng /giảm";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(716, 52);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(61, 13);
            this.LabelControl5.TabIndex = 0;
            this.LabelControl5.Text = "Giá trị còn lại";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(257, 28);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(43, 13);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Mã TSCD";
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnCancel);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 447);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(907, 34);
            this.PanelControl1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(827, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Ð&óng";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(1, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.grcNGUON_VON);
            this.GroupControl1.Controls.Add(this.Label1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(4, 141);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(907, 306);
            this.GroupControl1.TabIndex = 1;
            this.GroupControl1.Text = "Nguồn vốn";
            // 
            // grcNGUON_VON
            // 
            this.grcNGUON_VON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNGUON_VON.Location = new System.Drawing.Point(2, 22);
            this.grcNGUON_VON.MainView = this.grvNGUON_VON;
            this.grcNGUON_VON.Name = "grcNGUON_VON";
            this.grcNGUON_VON.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboDM_NGUON_TSCD_ID,
            this.cboLY_DO_TANGGIAM,
            this.cboTK_TAISAN,
            this.cboTK_CHIPHI,
            this.rpeTK_TAISAN,
            this.rpeTK_CHIPHI,
            this.RepositoryItemTextEdit1,
            this.RepositoryItemTextEdit2});
            this.grcNGUON_VON.Size = new System.Drawing.Size(903, 282);
            this.grcNGUON_VON.TabIndex = 0;
            this.grcNGUON_VON.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNGUON_VON});
            // 
            // grvNGUON_VON
            // 
            this.grvNGUON_VON.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DM_NGUON_TSCD_ID,
            this.GridColumn2,
            this.GridColumn1,
            this.MA_TK_KHAUHAO,
            this.MA_TK_CHIPHI,
            this.HE_SO_PB_KH,
            this.NGUYEN_GIA,
            this.HAO_MON_LUY_KE,
            this.GIA_TRI_CON_LAI,
            this.GridColumn3,
            this.DIEN_GIAI});
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
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Ngày chứng từ";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Width = 109;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Số chứng từ";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Width = 110;
            // 
            // MA_TK_KHAUHAO
            // 
            this.MA_TK_KHAUHAO.Caption = "TK khấu hao";
            this.MA_TK_KHAUHAO.ColumnEdit = this.rpeTK_TAISAN;
            this.MA_TK_KHAUHAO.FieldName = "MaTkKhauhao";
            this.MA_TK_KHAUHAO.Name = "MA_TK_KHAUHAO";
            this.MA_TK_KHAUHAO.Visible = true;
            this.MA_TK_KHAUHAO.VisibleIndex = 1;
            this.MA_TK_KHAUHAO.Width = 163;
            // 
            // rpeTK_TAISAN
            // 
            this.rpeTK_TAISAN.AutoHeight = false;
            this.rpeTK_TAISAN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpeTK_TAISAN.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tài khoản-80-1;TenTaikhoan-Tên tài khoản-200-1;Id-tkid-20-0";
            this.rpeTK_TAISAN.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan";
            this.rpeTK_TAISAN.C_DATA_SOURCE = null;
            this.rpeTK_TAISAN.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach";
            this.rpeTK_TAISAN.C_FORM_TITLE = "Chọn tài khoản";
            this.rpeTK_TAISAN.C_IS_CHECK_NUMBER = "ChiTiet=1";
            this.rpeTK_TAISAN.C_IS_CHECK_OTHER = "=";
            this.rpeTK_TAISAN.C_IS_CHECK_STRING = "=";
            this.rpeTK_TAISAN.C_IS_CHI_TIET = "";
            this.rpeTK_TAISAN.C_IS_FILTER_STRING = "";
            this.rpeTK_TAISAN.C_IS_QUICKADD = false;
            this.rpeTK_TAISAN.C_IS_SORT_ORDER_STRING = "";
            this.rpeTK_TAISAN.C_KEY_NAME = "MaTaikhoan";
            this.rpeTK_TAISAN.Editors = null;
            this.rpeTK_TAISAN.EditValues = "";
            this.rpeTK_TAISAN.ListEditValues = ((System.Collections.Generic.List<string>)(resources.GetObject("rpeTK_TAISAN.ListEditValues")));
            this.rpeTK_TAISAN.Name = "rpeTK_TAISAN";
            this.rpeTK_TAISAN.NEXT_TAB = 0;
            this.rpeTK_TAISAN.OBJ_CONDITITION = null;
            // 
            // MA_TK_CHIPHI
            // 
            this.MA_TK_CHIPHI.Caption = "TK chi phí";
            this.MA_TK_CHIPHI.ColumnEdit = this.rpeTK_CHIPHI;
            this.MA_TK_CHIPHI.FieldName = "MaTkChiphi";
            this.MA_TK_CHIPHI.Name = "MA_TK_CHIPHI";
            this.MA_TK_CHIPHI.Visible = true;
            this.MA_TK_CHIPHI.VisibleIndex = 2;
            this.MA_TK_CHIPHI.Width = 144;
            // 
            // rpeTK_CHIPHI
            // 
            this.rpeTK_CHIPHI.AutoHeight = false;
            this.rpeTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpeTK_CHIPHI.C_ARR_COLS_DISPLAY = "MaTaikhoan-Mã tài khoản-80-1;TenTaikhoan-Tên tài khoản-200-1;Id-tkid-80-0";
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
            // HE_SO_PB_KH
            // 
            this.HE_SO_PB_KH.Caption = "Hệ số phân bổ";
            this.HE_SO_PB_KH.ColumnEdit = this.RepositoryItemTextEdit1;
            this.HE_SO_PB_KH.FieldName = "HeSoPbKh";
            this.HE_SO_PB_KH.Name = "HE_SO_PB_KH";
            this.HE_SO_PB_KH.Visible = true;
            this.HE_SO_PB_KH.VisibleIndex = 3;
            this.HE_SO_PB_KH.Width = 141;
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Mask.EditMask = "n2";
            this.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // NGUYEN_GIA
            // 
            this.NGUYEN_GIA.Caption = "Nguyên giá";
            this.NGUYEN_GIA.DisplayFormat.FormatString = "#,###0";
            this.NGUYEN_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGUYEN_GIA.FieldName = "NguyenGia";
            this.NGUYEN_GIA.Name = "NGUYEN_GIA";
            this.NGUYEN_GIA.Width = 108;
            // 
            // HAO_MON_LUY_KE
            // 
            this.HAO_MON_LUY_KE.Caption = "Giá trị đã khấu hao";
            this.HAO_MON_LUY_KE.FieldName = "HaoMonLuyKe";
            this.HAO_MON_LUY_KE.Name = "HAO_MON_LUY_KE";
            this.HAO_MON_LUY_KE.Width = 119;
            // 
            // GIA_TRI_CON_LAI
            // 
            this.GIA_TRI_CON_LAI.Caption = "Giá trị còn lại";
            this.GIA_TRI_CON_LAI.FieldName = "GiaTriConLai";
            this.GIA_TRI_CON_LAI.Name = "GIA_TRI_CON_LAI";
            this.GIA_TRI_CON_LAI.Width = 110;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Giá trị KH 1 tháng";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Width = 113;
            // 
            // DIEN_GIAI
            // 
            this.DIEN_GIAI.Caption = "Diễn giải";
            this.DIEN_GIAI.ColumnEdit = this.RepositoryItemTextEdit2;
            this.DIEN_GIAI.FieldName = "DienGiai";
            this.DIEN_GIAI.Name = "DIEN_GIAI";
            this.DIEN_GIAI.Visible = true;
            this.DIEN_GIAI.VisibleIndex = 4;
            this.DIEN_GIAI.Width = 302;
            // 
            // RepositoryItemTextEdit2
            // 
            this.RepositoryItemTextEdit2.AutoHeight = false;
            this.RepositoryItemTextEdit2.MaxLength = 256;
            this.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2";
            // 
            // cboLY_DO_TANGGIAM
            // 
            this.cboLY_DO_TANGGIAM.AutoHeight = false;
            this.cboLY_DO_TANGGIAM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLY_DO_TANGGIAM.Name = "cboLY_DO_TANGGIAM";
            this.cboLY_DO_TANGGIAM.NullText = "";
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
            // cboTK_CHIPHI
            // 
            this.cboTK_CHIPHI.AutoHeight = false;
            this.cboTK_CHIPHI.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTK_CHIPHI.Name = "cboTK_CHIPHI";
            this.cboTK_CHIPHI.NullText = "";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(653, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(249, 13);
            this.Label1.TabIndex = 5007;
            this.Label1.Text = "Sử dụng phím tắt: F4 – Thêm dòng; F8 – Xóa dòng";
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl2.Location = new System.Drawing.Point(4, 137);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(907, 4);
            this.PanelControl2.TabIndex = 3;
            // 
            // frmDieuChinhGiaTriTaiSan_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(915, 485);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.grcTHONG_TIN_CHINH);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDieuChinhGiaTriTaiSan_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "frmDieuChinhGiaTriTaiSan_ChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.grcTHONG_TIN_CHINH)).EndInit();
            this.grcTHONG_TIN_CHINH.ResumeLayout(false);
            this.grcTHONG_TIN_CHINH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_CT1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_CT1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KT_KH1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY_KT_KH1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay_BD_KH1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay_BD_KH1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlLYDO_TANGGIAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grlTANG_TSCD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHAO_MON_LUY_KE1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSO_THANG_SD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGUYEN_GIA1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIA_TRI_CL1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTangGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMA_TSCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNGUON_VON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDM_NGUON_TSCD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpeTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLY_DO_TANGGIAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_TAISAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTK_CHIPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl grcTHONG_TIN_CHINH;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlTANG_TSCD1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraEditors.TextEdit txtMA_TSCD;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLYDO_TANGGIAM;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.TextEdit txtHAO_MON_LUY_KE1;
        internal DevExpress.XtraEditors.TextEdit txtGIA_TRI_CL1;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        internal DevExpress.XtraEditors.DateEdit dteNgay_BD_KH1;
        internal DevExpress.XtraEditors.TextEdit txtTenLyDo;
        internal DevExpress.XtraEditors.TextEdit txtTenTangGiam;
        internal DevExpress.XtraEditors.TextEdit txtTenTS;
        internal DevExpress.XtraEditors.TextEdit txtSO_THANG_SD1;
        internal DevExpress.XtraEditors.LabelControl LabelControl9;
        internal DevExpress.XtraEditors.LabelControl LabelControl10;
        internal DevExpress.XtraEditors.LabelControl LabelControl11;
        internal DevExpress.XtraEditors.TextEdit txtSO_CT1;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_CT1;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraGrid.GridControl grcNGUON_VON;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvNGUON_VON;
        internal DevExpress.XtraGrid.Columns.GridColumn DM_NGUON_TSCD_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDM_NGUON_TSCD_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_KHAUHAO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_TAISAN;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_CHIPHI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_CHIPHI;
        internal DevExpress.XtraGrid.Columns.GridColumn HE_SO_PB_KH;
        internal DevExpress.XtraGrid.Columns.GridColumn NGUYEN_GIA;
        internal DevExpress.XtraGrid.Columns.GridColumn HAO_MON_LUY_KE;
        internal DevExpress.XtraGrid.Columns.GridColumn GIA_TRI_CON_LAI;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn DIEN_GIAI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboLY_DO_TANGGIAM;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_KT_KH1;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraGrid.Columns.GridColumn KY_HIEU;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_LYDO_TG_TSCD;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeTK_TAISAN;
        internal Vns.Erp.Core.RepositoryItemPopupFilterEdit rpeTK_CHIPHI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit2;
        internal DevExpress.XtraEditors.TextEdit txtNGUYEN_GIA1;
    }
}