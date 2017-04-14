using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    partial class frmKhaiBaoGiamTaiSan_ChiTiet : DevExpress.XtraEditors.XtraForm
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
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtGTCL = new DevExpress.XtraEditors.TextEdit();
            this.txtSO_CT = new DevExpress.XtraEditors.TextEdit();
            this.txtNGAY_KT_KH = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAY_CT = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGAY_KT_KH1 = new DevExpress.XtraEditors.LabelControl();
            this.ckeGIAM_TS = new DevExpress.XtraEditors.CheckEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grlLY_DO_GIAM = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHMLK = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGAY_BDKH = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNGAY_MUA = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKY_HIEU = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txttenlydo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTaiSan = new DevExpress.XtraEditors.TextEdit();
            this.txtMA_TS = new DevExpress.XtraEditors.TextEdit();
            this.s = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDINH_KHOAN = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcDINH_KHOAN = new DevExpress.XtraGrid.GridControl();
            this.grvDINH_KHOAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMA_TK_NO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TEN_TK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMA_TK_CO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TEN_TK_CO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDM_NGUON_TSCD_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboLY_DO_TANGGIAM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_TAISAN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTK_CHIPHI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtGTCL.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtSO_CT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_KT_KH.Properties.VistaTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_KT_KH.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_CT.Properties.VistaTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_CT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.ckeGIAM_TS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grlLY_DO_GIAM.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtHMLK.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_BDKH.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_MUA.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtKY_HIEU.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txttenlydo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTaiSan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_TS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.grcDINH_KHOAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.grvDINH_KHOAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMA_TK_NO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMA_TK_CO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboDM_NGUON_TSCD_ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboLY_DO_TANGGIAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboTK_TAISAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboTK_CHIPHI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl2).BeginInit();
            this.SuspendLayout();
            //
            //GroupControl1
            //
            this.GroupControl1.Controls.Add(this.txtGTCL);
            this.GroupControl1.Controls.Add(this.txtSO_CT);
            this.GroupControl1.Controls.Add(this.txtNGAY_KT_KH);
            this.GroupControl1.Controls.Add(this.dteNGAY_CT);
            this.GroupControl1.Controls.Add(this.LabelControl7);
            this.GroupControl1.Controls.Add(this.LabelControl1);
            this.GroupControl1.Controls.Add(this.txtNGAY_KT_KH1);
            this.GroupControl1.Controls.Add(this.ckeGIAM_TS);
            this.GroupControl1.Controls.Add(this.LabelControl6);
            this.GroupControl1.Controls.Add(this.grlLY_DO_GIAM);
            this.GroupControl1.Controls.Add(this.LabelControl2);
            this.GroupControl1.Controls.Add(this.txtHMLK);
            this.GroupControl1.Controls.Add(this.LabelControl9);
            this.GroupControl1.Controls.Add(this.LabelControl8);
            this.GroupControl1.Controls.Add(this.txtNGAY_BDKH);
            this.GroupControl1.Controls.Add(this.LabelControl5);
            this.GroupControl1.Controls.Add(this.txtNGAY_MUA);
            this.GroupControl1.Controls.Add(this.LabelControl4);
            this.GroupControl1.Controls.Add(this.txtKY_HIEU);
            this.GroupControl1.Controls.Add(this.LabelControl3);
            this.GroupControl1.Controls.Add(this.txttenlydo);
            this.GroupControl1.Controls.Add(this.txtTenTaiSan);
            this.GroupControl1.Controls.Add(this.txtMA_TS);
            this.GroupControl1.Controls.Add(this.s);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl1.Location = new System.Drawing.Point(4, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.ShowCaption = false;
            this.GroupControl1.Size = new System.Drawing.Size(847, 174);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "GroupControl1";
            //
            //txtGTCL
            //
            this.txtGTCL.Location = new System.Drawing.Point(708, 113);
            this.txtGTCL.Name = "txtGTCL";
            this.txtGTCL.Properties.Mask.EditMask = "n0";
            this.txtGTCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGTCL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGTCL.Properties.ReadOnly = true;
            this.txtGTCL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGTCL.Size = new System.Drawing.Size(125, 20);
            this.txtGTCL.TabIndex = 12;
            this.txtGTCL.TabStop = false;
            //
            //txtSO_CT
            //
            this.txtSO_CT.EnterMoveNextControl = true;
            this.txtSO_CT.Location = new System.Drawing.Point(88, 89);
            this.txtSO_CT.Name = "txtSO_CT";
            this.txtSO_CT.Size = new System.Drawing.Size(125, 20);
            this.txtSO_CT.TabIndex = 4;
            //
            //txtNGAY_KT_KH
            //
            this.txtNGAY_KT_KH.EditValue = null;
            this.txtNGAY_KT_KH.EnterMoveNextControl = true;
            this.txtNGAY_KT_KH.Location = new System.Drawing.Point(708, 61);
            this.txtNGAY_KT_KH.Name = "txtNGAY_KT_KH";
            this.txtNGAY_KT_KH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.txtNGAY_KT_KH.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtNGAY_KT_KH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtNGAY_KT_KH.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.txtNGAY_KT_KH.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtNGAY_KT_KH.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            this.txtNGAY_KT_KH.Size = new System.Drawing.Size(125, 20);
            this.txtNGAY_KT_KH.TabIndex = 10;
            //
            //dteNGAY_CT
            //
            this.dteNGAY_CT.EditValue = null;
            this.dteNGAY_CT.EnterMoveNextControl = true;
            this.dteNGAY_CT.Location = new System.Drawing.Point(88, 62);
            this.dteNGAY_CT.Name = "dteNGAY_CT";
            this.dteNGAY_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteNGAY_CT.Properties.MaxValue = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            this.dteNGAY_CT.Size = new System.Drawing.Size(125, 20);
            this.dteNGAY_CT.TabIndex = 3;
            //
            //LabelControl7
            //
            this.LabelControl7.Location = new System.Drawing.Point(36, 91);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(28, 13);
            this.LabelControl7.TabIndex = 6;
            this.LabelControl7.Text = "Số CT";
            //
            //LabelControl1
            //
            this.LabelControl1.Location = new System.Drawing.Point(23, 64);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(41, 13);
            this.LabelControl1.TabIndex = 6;
            this.LabelControl1.Text = "Ngày CT";
            //
            //txtNGAY_KT_KH1
            //
            this.txtNGAY_KT_KH1.Location = new System.Drawing.Point(631, 64);
            this.txtNGAY_KT_KH1.Name = "txtNGAY_KT_KH1";
            this.txtNGAY_KT_KH1.Size = new System.Drawing.Size(53, 13);
            this.txtNGAY_KT_KH1.TabIndex = 6;
            this.txtNGAY_KT_KH1.Text = "Ngày KTKH";
            //
            //ckeGIAM_TS
            //
            this.ckeGIAM_TS.EditValue = true;
            this.ckeGIAM_TS.Location = new System.Drawing.Point(86, 115);
            this.ckeGIAM_TS.Name = "ckeGIAM_TS";
            this.ckeGIAM_TS.Properties.Caption = "";
            this.ckeGIAM_TS.Size = new System.Drawing.Size(26, 19);
            this.ckeGIAM_TS.TabIndex = 5;
            //
            //LabelControl6
            //
            this.LabelControl6.Location = new System.Drawing.Point(6, 121);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(58, 13);
            this.LabelControl6.TabIndex = 4;
            this.LabelControl6.Text = "Giảm tài sản";
            //
            //grlLY_DO_GIAM
            //
            this.grlLY_DO_GIAM.EditValue = "";
            this.grlLY_DO_GIAM.EnterMoveNextControl = true;
            this.grlLY_DO_GIAM.Location = new System.Drawing.Point(88, 141);
            this.grlLY_DO_GIAM.Name = "grlLY_DO_GIAM";
            this.grlLY_DO_GIAM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.grlLY_DO_GIAM.Properties.NullText = "";
            this.grlLY_DO_GIAM.Properties.View = this.GridLookUpEdit1View;
            this.grlLY_DO_GIAM.Size = new System.Drawing.Size(125, 20);
            this.grlLY_DO_GIAM.TabIndex = 6;
            //
            //GridLookUpEdit1View
            //
            this.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit1View.Name = "GridLookUpEdit1View";
            this.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            //
            //LabelControl2
            //
            this.LabelControl2.Location = new System.Drawing.Point(13, 144);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(51, 13);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Lý do giảm";
            //
            //txtHMLK
            //
            this.txtHMLK.EnterMoveNextControl = true;
            this.txtHMLK.Location = new System.Drawing.Point(708, 87);
            this.txtHMLK.Name = "txtHMLK";
            this.txtHMLK.Properties.Mask.EditMask = "n0";
            this.txtHMLK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHMLK.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHMLK.Properties.ReadOnly = true;
            this.txtHMLK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHMLK.Size = new System.Drawing.Size(125, 20);
            this.txtHMLK.TabIndex = 11;
            this.txtHMLK.TabStop = false;
            //
            //LabelControl9
            //
            this.LabelControl9.Location = new System.Drawing.Point(611, 90);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(73, 13);
            this.LabelControl9.TabIndex = 0;
            this.LabelControl9.Text = "Hao mòn lũy kế";
            //
            //LabelControl8
            //
            this.LabelControl8.Location = new System.Drawing.Point(623, 116);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(61, 13);
            this.LabelControl8.TabIndex = 0;
            this.LabelControl8.Text = "Giá trị còn lại";
            //
            //txtNGAY_BDKH
            //
            this.txtNGAY_BDKH.EnterMoveNextControl = true;
            this.txtNGAY_BDKH.Location = new System.Drawing.Point(708, 35);
            this.txtNGAY_BDKH.Name = "txtNGAY_BDKH";
            this.txtNGAY_BDKH.Properties.ReadOnly = true;
            this.txtNGAY_BDKH.Size = new System.Drawing.Size(125, 20);
            this.txtNGAY_BDKH.TabIndex = 9;
            this.txtNGAY_BDKH.TabStop = false;
            //
            //LabelControl5
            //
            this.LabelControl5.Location = new System.Drawing.Point(635, 38);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(54, 13);
            this.LabelControl5.TabIndex = 0;
            this.LabelControl5.Text = "Ngày BDKH";
            //
            //txtNGAY_MUA
            //
            this.txtNGAY_MUA.EnterMoveNextControl = true;
            this.txtNGAY_MUA.Location = new System.Drawing.Point(708, 9);
            this.txtNGAY_MUA.Name = "txtNGAY_MUA";
            this.txtNGAY_MUA.Properties.ReadOnly = true;
            this.txtNGAY_MUA.Size = new System.Drawing.Size(125, 20);
            this.txtNGAY_MUA.TabIndex = 8;
            this.txtNGAY_MUA.TabStop = false;
            //
            //LabelControl4
            //
            this.LabelControl4.Location = new System.Drawing.Point(641, 12);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(48, 13);
            this.LabelControl4.TabIndex = 0;
            this.LabelControl4.Text = "Ngày mua";
            //
            //txtKY_HIEU
            //
            this.txtKY_HIEU.EnterMoveNextControl = true;
            this.txtKY_HIEU.Location = new System.Drawing.Point(88, 35);
            this.txtKY_HIEU.Name = "txtKY_HIEU";
            this.txtKY_HIEU.Properties.ReadOnly = true;
            this.txtKY_HIEU.Size = new System.Drawing.Size(125, 20);
            this.txtKY_HIEU.TabIndex = 2;
            this.txtKY_HIEU.TabStop = false;
            //
            //LabelControl3
            //
            this.LabelControl3.Location = new System.Drawing.Point(29, 38);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(35, 13);
            this.LabelControl3.TabIndex = 0;
            this.LabelControl3.Text = "Ký hiệu";
            //
            //txttenlydo
            //
            this.txttenlydo.EnterMoveNextControl = true;
            this.txttenlydo.Location = new System.Drawing.Point(219, 141);
            this.txttenlydo.Name = "txttenlydo";
            this.txttenlydo.Properties.ReadOnly = true;
            this.txttenlydo.Size = new System.Drawing.Size(244, 20);
            this.txttenlydo.TabIndex = 7;
            this.txttenlydo.TabStop = false;
            //
            //txtTenTaiSan
            //
            this.txtTenTaiSan.EnterMoveNextControl = true;
            this.txtTenTaiSan.Location = new System.Drawing.Point(219, 9);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Properties.ReadOnly = true;
            this.txtTenTaiSan.Size = new System.Drawing.Size(244, 20);
            this.txtTenTaiSan.TabIndex = 1;
            this.txtTenTaiSan.TabStop = false;
            //
            //txtMA_TS
            //
            this.txtMA_TS.EnterMoveNextControl = true;
            this.txtMA_TS.Location = new System.Drawing.Point(88, 9);
            this.txtMA_TS.Name = "txtMA_TS";
            this.txtMA_TS.Properties.ReadOnly = true;
            this.txtMA_TS.Size = new System.Drawing.Size(125, 20);
            this.txtMA_TS.TabIndex = 0;
            this.txtMA_TS.TabStop = false;
            //
            //s
            //
            this.s.Location = new System.Drawing.Point(15, 12);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(49, 13);
            this.s.TabIndex = 0;
            this.s.Text = "Mã tài sản";
            //
            //PanelControl1
            //
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.btnDINH_KHOAN);
            this.PanelControl1.Controls.Add(this.btnCancel);
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(4, 411);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(847, 34);
            this.PanelControl1.TabIndex = 1;
            //
            //btnDINH_KHOAN
            //
            this.btnDINH_KHOAN.Location = new System.Drawing.Point(88, 3);
            this.btnDINH_KHOAN.Name = "btnDINH_KHOAN";
            this.btnDINH_KHOAN.Size = new System.Drawing.Size(80, 30);
            this.btnDINH_KHOAN.TabIndex = 1;
            this.btnDINH_KHOAN.Text = "&Định khoản";
            //
            //btnCancel
            //
            this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnCancel.ImageIndex = 24;
            this.btnCancel.Location = new System.Drawing.Point(763, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ð&óng";
            //
            //btnSave
            //
            this.btnSave.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnSave.ImageIndex = 13;
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            //
            //err
            //
            this.err.ContainerControl = this;
            //
            //GroupControl2
            //
            this.GroupControl2.Controls.Add(this.grcDINH_KHOAN);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(4, 182);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.ShowCaption = false;
            this.GroupControl2.Size = new System.Drawing.Size(847, 229);
            this.GroupControl2.TabIndex = 2;
            this.GroupControl2.Text = "GroupControl2";
            //
            //grcDINH_KHOAN
            //
            this.grcDINH_KHOAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDINH_KHOAN.Location = new System.Drawing.Point(2, 2);
            this.grcDINH_KHOAN.MainView = this.grvDINH_KHOAN;
            this.grcDINH_KHOAN.Name = "grcDINH_KHOAN";
            this.grcDINH_KHOAN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
			this.cboDM_NGUON_TSCD_ID,
			this.cboLY_DO_TANGGIAM,
			this.cboTK_TAISAN,
			this.cboTK_CHIPHI,
			this.cboMA_TK_NO,
			this.cboMA_TK_CO
		});
            this.grcDINH_KHOAN.Size = new System.Drawing.Size(843, 225);
            this.grcDINH_KHOAN.TabIndex = 5009;
            this.grcDINH_KHOAN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.grvDINH_KHOAN });
            //
            //grvDINH_KHOAN
            //
            this.grvDINH_KHOAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
			this.MA_TK_NO,
			this.TEN_TK_NO,
			this.MA_TK_CO,
			this.TEN_TK_CO,
			this.SO_TIEN
		});
            this.grvDINH_KHOAN.GridControl = this.grcDINH_KHOAN;
            this.grvDINH_KHOAN.Name = "grvDINH_KHOAN";
            this.grvDINH_KHOAN.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDINH_KHOAN.OptionsView.ShowGroupPanel = false;
            //
            //MA_TK_NO
            //
            this.MA_TK_NO.Caption = "Mã TK nợ";
            this.MA_TK_NO.ColumnEdit = this.cboMA_TK_NO;
            this.MA_TK_NO.FieldName = "TkNoId";
            this.MA_TK_NO.Name = "MA_TK_NO";
            this.MA_TK_NO.Visible = true;
            this.MA_TK_NO.VisibleIndex = 0;
            this.MA_TK_NO.Width = 96;
            //
            //cboMA_TK_NO
            //
            this.cboMA_TK_NO.AutoHeight = false;
            this.cboMA_TK_NO.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMA_TK_NO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboMA_TK_NO.Name = "cboMA_TK_NO";
            this.cboMA_TK_NO.NullText = "";
            //
            //TEN_TK_NO
            //
            this.TEN_TK_NO.Caption = "Tên TK nợ";
            this.TEN_TK_NO.FieldName = "TenTkNo";
            this.TEN_TK_NO.Name = "TEN_TK_NO";
            this.TEN_TK_NO.Visible = true;
            this.TEN_TK_NO.VisibleIndex = 1;
            this.TEN_TK_NO.Width = 217;
            //
            //MA_TK_CO
            //
            this.MA_TK_CO.Caption = "Mã TK có";
            this.MA_TK_CO.ColumnEdit = this.cboMA_TK_CO;
            this.MA_TK_CO.FieldName = "TkCoId";
            this.MA_TK_CO.Name = "MA_TK_CO";
            this.MA_TK_CO.Visible = true;
            this.MA_TK_CO.VisibleIndex = 2;
            this.MA_TK_CO.Width = 112;
            //
            //cboMA_TK_CO
            //
            this.cboMA_TK_CO.AutoHeight = false;
            this.cboMA_TK_CO.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboMA_TK_CO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboMA_TK_CO.Name = "cboMA_TK_CO";
            this.cboMA_TK_CO.NullText = "";
            //
            //TEN_TK_CO
            //
            this.TEN_TK_CO.Caption = "Tên TK có";
            this.TEN_TK_CO.FieldName = "TenTkCo";
            this.TEN_TK_CO.Name = "TEN_TK_CO";
            this.TEN_TK_CO.Visible = true;
            this.TEN_TK_CO.VisibleIndex = 3;
            this.TEN_TK_CO.Width = 233;
            //
            //SO_TIEN
            //
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.DisplayFormat.FormatString = "n0";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN.FieldName = "SoTien";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 4;
            this.SO_TIEN.Width = 164;
            //
            //cboDM_NGUON_TSCD_ID
            //
            this.cboDM_NGUON_TSCD_ID.AutoHeight = false;
            this.cboDM_NGUON_TSCD_ID.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboDM_NGUON_TSCD_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboDM_NGUON_TSCD_ID.Name = "cboDM_NGUON_TSCD_ID";
            this.cboDM_NGUON_TSCD_ID.NullText = "";
            //
            //cboLY_DO_TANGGIAM
            //
            this.cboLY_DO_TANGGIAM.AutoHeight = false;
            this.cboLY_DO_TANGGIAM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboLY_DO_TANGGIAM.Name = "cboLY_DO_TANGGIAM";
            this.cboLY_DO_TANGGIAM.NullText = "";
            //
            //cboTK_TAISAN
            //
            this.cboTK_TAISAN.AutoHeight = false;
            this.cboTK_TAISAN.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_TAISAN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboTK_TAISAN.Name = "cboTK_TAISAN";
            this.cboTK_TAISAN.NullText = "";
            //
            //cboTK_CHIPHI
            //
            this.cboTK_CHIPHI.AutoHeight = false;
            this.cboTK_CHIPHI.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboTK_CHIPHI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.cboTK_CHIPHI.Name = "cboTK_CHIPHI";
            this.cboTK_CHIPHI.NullText = "";
            //
            //PanelControl2
            //
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl2.Location = new System.Drawing.Point(4, 178);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(847, 4);
            this.PanelControl2.TabIndex = 3;
            //
            //frmKhaiBaoGiamTaiSan_ChiTiet
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(855, 449);
            this.Controls.Add(this.GroupControl2);
            this.Controls.Add(this.PanelControl2);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.PanelControl1);
            this.KeyPreview = true;
            this.Name = "frmKhaiBaoGiamTaiSan_ChiTiet";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Khai báo giảm giá tài sản";
            ((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtGTCL.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtSO_CT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_KT_KH.Properties.VistaTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_KT_KH.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_CT.Properties.VistaTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dteNGAY_CT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.ckeGIAM_TS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grlLY_DO_GIAM.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtHMLK.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_BDKH.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtNGAY_MUA.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtKY_HIEU.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txttenlydo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtTenTaiSan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtMA_TS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.err).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.grcDINH_KHOAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.grvDINH_KHOAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMA_TK_NO).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboMA_TK_CO).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboDM_NGUON_TSCD_ID).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboLY_DO_TANGGIAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboTK_TAISAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboTK_CHIPHI).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PanelControl2).EndInit();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.GridLookUpEdit grlLY_DO_GIAM;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtMA_TS;
        internal DevExpress.XtraEditors.LabelControl s;
        internal DevExpress.XtraEditors.CheckEdit ckeGIAM_TS;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.TextEdit txtNGAY_BDKH;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.TextEdit txtNGAY_MUA;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.TextEdit txtKY_HIEU;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.LabelControl txtNGAY_KT_KH1;
        internal DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        internal DevExpress.XtraEditors.TextEdit txtTenTaiSan;
        internal DevExpress.XtraEditors.TextEdit txttenlydo;
        internal DevExpress.XtraEditors.TextEdit txtSO_CT;
        internal DevExpress.XtraEditors.DateEdit dteNGAY_CT;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl8;
        internal DevExpress.XtraEditors.TextEdit txtHMLK;
        internal DevExpress.XtraEditors.LabelControl LabelControl9;
        internal DevExpress.XtraEditors.TextEdit txtGTCL;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraGrid.GridControl grcDINH_KHOAN;
        internal DevExpress.XtraGrid.Views.Grid.GridView grvDINH_KHOAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboDM_NGUON_TSCD_ID;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_TAISAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTK_CHIPHI;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboLY_DO_TANGGIAM;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_NO;
        internal DevExpress.XtraGrid.Columns.GridColumn MA_TK_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn TEN_TK_CO;
        internal DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        internal DevExpress.XtraEditors.SimpleButton btnDINH_KHOAN;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_NO;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMA_TK_CO;
        internal DevExpress.XtraEditors.DateEdit txtNGAY_KT_KH;
       
    }
}