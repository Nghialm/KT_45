<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim ValueInfo1 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Me.THU_TU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.navCTHG = New DevExpress.XtraEditors.ControlNavigator()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCan = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQui = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.MA_TKC_GIAVON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_MA_TKC_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.cboMA_TKC_GIAVON = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TEN_DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KHO_XUAT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMaKho = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TEN_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DON_GIA_VON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TON_KHO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.HANGHOA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_HANGHOA_ID = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.cboHANGHOA_ID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SO_LUONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grcPhieuTraHang_View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DON_GIA_VON_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GIA_VON_NT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GIA_VON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ThueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMthue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TY_LE_THUE_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_THUE_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_DM_PTQT_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPTQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_1_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_2_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_3_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_4_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_5_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_PHONGBAN_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPhongban = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_VUVIEC_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuviec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_KHOANPHI_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoanphi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_HOPDONG_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.grcPhieuTraHang = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GfilterTKN_THUE_GTGT = New Vns.Erp.Core.CustomFilter()
        Me.UR_STATUS = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtSOLUONG = New DevExpress.XtraEditors.TextEdit()
        Me.txtThueTTDB = New DevExpress.XtraEditors.TextEdit()
        Me.txtTongCong = New DevExpress.XtraEditors.TextEdit()
        Me.txtTienHang = New DevExpress.XtraEditors.TextEdit()
        Me.ckeNhapTienThue = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.txtMA_SO_THUE = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.GFilter_TK = New Vns.Erp.Core.CustomFilter()
        Me.GFilter = New Vns.Erp.Core.CustomFilter()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBX_DIENGIAI_2 = New DevExpress.XtraEditors.TextEdit()
        Me.dteNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkNGOAI_TE = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.dteNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.depCT_H_Nx = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_HANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcPhieuTraHang_View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuviec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcPhieuTraHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSOLUONG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThueTTDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongCong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.txtMA_SO_THUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBX_DIENGIAI_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'THU_TU
        '
        Me.THU_TU.Caption = "THU_TU"
        Me.THU_TU.FieldName = "ThuTu"
        Me.THU_TU.Name = "THU_TU"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navCTHG)
        Me.PanelControl2.Controls.Add(Me.btnSea)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnCan)
        Me.PanelControl2.Controls.Add(Me.btnQui)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSav)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl2.TabIndex = 0
        '
        'navCTHG
        '
        Me.navCTHG.Buttons.Append.Visible = False
        Me.navCTHG.Buttons.CancelEdit.Visible = False
        Me.navCTHG.Buttons.Edit.Visible = False
        Me.navCTHG.Buttons.EndEdit.Visible = False
        Me.navCTHG.Buttons.NextPage.Visible = False
        Me.navCTHG.Buttons.PrevPage.Visible = False
        Me.navCTHG.Buttons.Remove.Visible = False
        Me.navCTHG.Location = New System.Drawing.Point(0, 4)
        Me.navCTHG.Name = "navCTHG"
        Me.navCTHG.NavigatableControl = Me.grcLPN_Hnx
        Me.navCTHG.Size = New System.Drawing.Size(194, 30)
        Me.navCTHG.TabIndex = 48
        Me.navCTHG.Text = "ControlNavigator4"
        Me.navCTHG.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navCTHG.TextStringFormat = " {0} / {1}"
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(0, 0)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(194, 570)
        Me.grcLPN_Hnx.TabIndex = 4
        Me.grcLPN_Hnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPX_Hnx})
        '
        'grvLPX_Hnx
        '
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.Empty.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvLPX_Hnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseFont = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.Row.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Row.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GHI, Me.CT_SO, Me.NGAY_CT, Me.NGAY_GHI, Me.SO_TIEN})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'GHI
        '
        Me.GHI.Caption = "Trạng thái"
        Me.GHI.FieldName = "Ghi"
        Me.GHI.Name = "GHI"
        Me.GHI.Visible = True
        Me.GHI.VisibleIndex = 0
        '
        'CT_SO
        '
        Me.CT_SO.Caption = "Số chứng từ"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 1
        Me.CT_SO.Width = 90
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày CT"
        Me.NGAY_CT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NGAY_CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 2
        Me.NGAY_CT.Width = 100
        '
        'NGAY_GHI
        '
        Me.NGAY_GHI.Caption = "Ngày hạch toán"
        Me.NGAY_GHI.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NGAY_GHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NGAY_GHI.FieldName = "NgayGhi"
        Me.NGAY_GHI.Name = "NGAY_GHI"
        Me.NGAY_GHI.Visible = True
        Me.NGAY_GHI.VisibleIndex = 3
        Me.NGAY_GHI.Width = 90
        '
        'SO_TIEN
        '
        Me.SO_TIEN.Caption = "Tổng tiền"
        Me.SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_TIEN.FieldName = "SoTien"
        Me.SO_TIEN.Name = "SO_TIEN"
        Me.SO_TIEN.Visible = True
        Me.SO_TIEN.VisibleIndex = 4
        Me.SO_TIEN.Width = 120
        '
        'btnSea
        '
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(550, 4)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(80, 30)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm kiếm"
        '
        'btnDel
        '
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(378, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "&Xóa bản ghi"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(206, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnCan
        '
        Me.btnCan.ImageIndex = 4
        Me.btnCan.Location = New System.Drawing.Point(636, 4)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(80, 30)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "&Hủy"
        '
        'btnQui
        '
        Me.btnQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQui.ImageIndex = 8
        Me.btnQui.Location = New System.Drawing.Point(920, 2)
        Me.btnQui.Name = "btnQui"
        Me.btnQui.Size = New System.Drawing.Size(80, 30)
        Me.btnQui.TabIndex = 7
        Me.btnQui.Text = "&Quay ra"
        '
        'btnMod
        '
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(292, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(80, 30)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Sửa"
        '
        'btnPri
        '
        Me.btnPri.ImageIndex = 2
        Me.btnPri.Location = New System.Drawing.Point(722, 4)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 6
        Me.btnPri.Text = "&In ctừ"
        '
        'btnSav
        '
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(464, 4)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(80, 30)
        Me.btnSav.TabIndex = 2
        Me.btnSav.Text = "&Lưu"
        '
        'MA_TKC_GIAVON
        '
        Me.MA_TKC_GIAVON.Caption = "TK có"
        Me.MA_TKC_GIAVON.ColumnEdit = Me.GFilter_MA_TKC_GIAVON
        Me.MA_TKC_GIAVON.FieldName = "MaTkcGiavon"
        Me.MA_TKC_GIAVON.Name = "MA_TKC_GIAVON"
        Me.MA_TKC_GIAVON.Visible = True
        Me.MA_TKC_GIAVON.VisibleIndex = 13
        '
        'GFilter_MA_TKC_GIAVON
        '
        Me.GFilter_MA_TKC_GIAVON.AutoHeight = False
        Me.GFilter_MA_TKC_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilter_MA_TKC_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô t?-120-1;Id--0-0"
        Me.GFilter_MA_TKC_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_MA_TKC_GIAVON.C_DATA_SOURCE = Nothing
        Me.GFilter_MA_TKC_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_MA_TKC_GIAVON.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_NUMBER = "="
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_OTHER = "="
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_STRING = "="
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHI_TIET = ""
        Me.GFilter_MA_TKC_GIAVON.C_IS_FILTER_STRING = ""
        Me.GFilter_MA_TKC_GIAVON.C_IS_QUICKADD = False
        Me.GFilter_MA_TKC_GIAVON.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_MA_TKC_GIAVON.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_MA_TKC_GIAVON.Editors = Nothing
        Me.GFilter_MA_TKC_GIAVON.EditValues = ""
        Me.GFilter_MA_TKC_GIAVON.ListEditValues = CType(resources.GetObject("GFilter_MA_TKC_GIAVON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilter_MA_TKC_GIAVON.Name = "GFilter_MA_TKC_GIAVON"
        Me.GFilter_MA_TKC_GIAVON.NEXT_TAB = 0
        Me.GFilter_MA_TKC_GIAVON.OBJ_CONDITITION = Nothing
        '
        'cboMA_TKC_GIAVON
        '
        Me.cboMA_TKC_GIAVON.AutoHeight = False
        Me.cboMA_TKC_GIAVON.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMA_TKC_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMA_TKC_GIAVON.Name = "cboMA_TKC_GIAVON"
        Me.cboMA_TKC_GIAVON.NullText = ""
        '
        'TEN_DVT
        '
        Me.TEN_DVT.Caption = "ĐVT"
        Me.TEN_DVT.FieldName = "TenDvt"
        Me.TEN_DVT.Name = "TEN_DVT"
        Me.TEN_DVT.OptionsColumn.ReadOnly = True
        Me.TEN_DVT.Visible = True
        Me.TEN_DVT.VisibleIndex = 2
        '
        'KHO_XUAT_ID
        '
        Me.KHO_XUAT_ID.Caption = "Mã kho"
        Me.KHO_XUAT_ID.ColumnEdit = Me.cboMaKho
        Me.KHO_XUAT_ID.FieldName = "KhoXuatId"
        Me.KHO_XUAT_ID.Name = "KHO_XUAT_ID"
        Me.KHO_XUAT_ID.Visible = True
        Me.KHO_XUAT_ID.VisibleIndex = 3
        '
        'cboMaKho
        '
        Me.cboMaKho.AutoHeight = False
        Me.cboMaKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaKho.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.NullText = ""
        '
        'TEN_HANGHOA
        '
        Me.TEN_HANGHOA.Caption = "Tên hàng"
        Me.TEN_HANGHOA.FieldName = "TenHanghoa"
        Me.TEN_HANGHOA.Name = "TEN_HANGHOA"
        Me.TEN_HANGHOA.Visible = True
        Me.TEN_HANGHOA.VisibleIndex = 1
        Me.TEN_HANGHOA.Width = 213
        '
        'DON_GIA_VON
        '
        Me.DON_GIA_VON.AppearanceCell.Options.UseTextOptions = True
        Me.DON_GIA_VON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DON_GIA_VON.Caption = "Giá VND"
        Me.DON_GIA_VON.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DON_GIA_VON.FieldName = "DonGiaVon"
        Me.DON_GIA_VON.Name = "DON_GIA_VON"
        Me.DON_GIA_VON.Visible = True
        Me.DON_GIA_VON.VisibleIndex = 8
        Me.DON_GIA_VON.Width = 119
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.MaxLength = 14
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'TON_KHO
        '
        Me.TON_KHO.Caption = "Tồn kho"
        Me.TON_KHO.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.TON_KHO.FieldName = "TonKho"
        Me.TON_KHO.Name = "TON_KHO"
        Me.TON_KHO.OptionsColumn.ReadOnly = True
        Me.TON_KHO.Visible = True
        Me.TON_KHO.VisibleIndex = 4
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'HANGHOA_ID
        '
        Me.HANGHOA_ID.Caption = "Mã hàng"
        Me.HANGHOA_ID.ColumnEdit = Me.GFilter_HANGHOA_ID
        Me.HANGHOA_ID.FieldName = "KyHieuHanghoa"
        Me.HANGHOA_ID.Name = "HANGHOA_ID"
        Me.HANGHOA_ID.Visible = True
        Me.HANGHOA_ID.VisibleIndex = 0
        Me.HANGHOA_ID.Width = 101
        '
        'GFilter_HANGHOA_ID
        '
        Me.GFilter_HANGHOA_ID.AutoHeight = False
        Me.GFilter_HANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilter_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" & _
            "nDvt--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0"
        Me.GFilter_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban"
        Me.GFilter_HANGHOA_ID.C_DATA_SOURCE = Nothing
        Me.GFilter_HANGHOA_ID.C_FORM_DANHSACH = "frmDanhMucHangHoa_DanhSach"
        Me.GFilter_HANGHOA_ID.C_FORM_TITLE = "Chọn hàng hóa"
        Me.GFilter_HANGHOA_ID.C_IS_CHECK_NUMBER = "="
        Me.GFilter_HANGHOA_ID.C_IS_CHECK_OTHER = "="
        Me.GFilter_HANGHOA_ID.C_IS_CHECK_STRING = "="
        Me.GFilter_HANGHOA_ID.C_IS_CHI_TIET = ""
        Me.GFilter_HANGHOA_ID.C_IS_FILTER_STRING = ""
        Me.GFilter_HANGHOA_ID.C_IS_QUICKADD = True
        Me.GFilter_HANGHOA_ID.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_HANGHOA_ID.C_KEY_NAME = "KyHieu"
        Me.GFilter_HANGHOA_ID.Editors = Nothing
        Me.GFilter_HANGHOA_ID.EditValues = ""
        Me.GFilter_HANGHOA_ID.ListEditValues = CType(resources.GetObject("GFilter_HANGHOA_ID.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilter_HANGHOA_ID.Name = "GFilter_HANGHOA_ID"
        Me.GFilter_HANGHOA_ID.NEXT_TAB = 0
        Me.GFilter_HANGHOA_ID.OBJ_CONDITITION = Nothing
        '
        'cboHANGHOA_ID
        '
        Me.cboHANGHOA_ID.AutoHeight = False
        Me.cboHANGHOA_ID.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboHANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHANGHOA_ID.Name = "cboHANGHOA_ID"
        Me.cboHANGHOA_ID.NullText = ""
        '
        'SO_LUONG
        '
        Me.SO_LUONG.Caption = "Số lượng"
        Me.SO_LUONG.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.SO_LUONG.FieldName = "SoLuong"
        Me.SO_LUONG.Name = "SO_LUONG"
        Me.SO_LUONG.Visible = True
        Me.SO_LUONG.VisibleIndex = 5
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'grcPhieuTraHang_View
        '
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.Empty.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.EvenRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.EvenRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FixedLine.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupButton.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.GroupRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.GroupRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.HorzLine.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.OddRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.OddRow.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Appearance.OddRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grcPhieuTraHang_View.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.Preview.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.Preview.Options.UseFont = True
        Me.grcPhieuTraHang_View.Appearance.Preview.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.Row.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.Row.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuTraHang_View.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grcPhieuTraHang_View.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grcPhieuTraHang_View.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuTraHang_View.Appearance.VertLine.Options.UseBackColor = True
        Me.grcPhieuTraHang_View.Appearance.VertLine.Options.UseBorderColor = True
        Me.grcPhieuTraHang_View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.HANGHOA_ID, Me.TEN_HANGHOA, Me.TEN_DVT, Me.KHO_XUAT_ID, Me.TON_KHO, Me.SO_LUONG, Me.DON_GIA_VON_NTE, Me.GIA_VON_NT, Me.DON_GIA_VON, Me.GIA_VON, Me.ThueId, Me.TY_LE_THUE_GTGT, Me.SO_TIEN_THUE_GTGT, Me.MA_TKC_GIAVON, Me.ID_DM_PTQT_CO, Me.ID_DM_TUDO_1_CO, Me.ID_DM_TUDO_2_CO, Me.ID_DM_TUDO_3_CO, Me.ID_DM_TUDO_4_CO, Me.ID_DM_TUDO_5_CO, Me.ID_DM_PHONGBAN_CO, Me.ID_DM_VUVIEC_CO, Me.ID_DM_KHOANPHI_CO, Me.ID_DM_HOPDONG_CO, Me.THU_TU})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseBorderColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.THU_TU
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "13"
        Me.grcPhieuTraHang_View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grcPhieuTraHang_View.GridControl = Me.grcPhieuTraHang
        Me.grcPhieuTraHang_View.Name = "grcPhieuTraHang_View"
        Me.grcPhieuTraHang_View.OptionsDetail.EnableMasterViewMode = False
        Me.grcPhieuTraHang_View.OptionsDetail.ShowDetailTabs = False
        Me.grcPhieuTraHang_View.OptionsNavigation.AutoFocusNewRow = True
        Me.grcPhieuTraHang_View.OptionsNavigation.EnterMoveNextColumn = True
        Me.grcPhieuTraHang_View.OptionsView.ColumnAutoWidth = False
        Me.grcPhieuTraHang_View.OptionsView.EnableAppearanceEvenRow = True
        Me.grcPhieuTraHang_View.OptionsView.EnableAppearanceOddRow = True
        Me.grcPhieuTraHang_View.OptionsView.ShowGroupPanel = False
        '
        'DON_GIA_VON_NTE
        '
        Me.DON_GIA_VON_NTE.Caption = "Giá NT"
        Me.DON_GIA_VON_NTE.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.DON_GIA_VON_NTE.FieldName = "DonGiaVonNte"
        Me.DON_GIA_VON_NTE.Name = "DON_GIA_VON_NTE"
        Me.DON_GIA_VON_NTE.Visible = True
        Me.DON_GIA_VON_NTE.VisibleIndex = 6
        Me.DON_GIA_VON_NTE.Width = 100
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.MaxLength = 14
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GIA_VON_NT
        '
        Me.GIA_VON_NT.Caption = "Tổng tiền NT"
        Me.GIA_VON_NT.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GIA_VON_NT.FieldName = "GiaVonNt"
        Me.GIA_VON_NT.Name = "GIA_VON_NT"
        Me.GIA_VON_NT.Visible = True
        Me.GIA_VON_NT.VisibleIndex = 7
        Me.GIA_VON_NT.Width = 94
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.MaxLength = 18
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GIA_VON
        '
        Me.GIA_VON.AppearanceCell.Options.UseTextOptions = True
        Me.GIA_VON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GIA_VON.Caption = "Tổng tiền"
        Me.GIA_VON.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GIA_VON.FieldName = "GiaVon"
        Me.GIA_VON.Name = "GIA_VON"
        Me.GIA_VON.OptionsColumn.ReadOnly = True
        Me.GIA_VON.Visible = True
        Me.GIA_VON.VisibleIndex = 9
        Me.GIA_VON.Width = 120
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ThueId
        '
        Me.ThueId.Caption = "Danh mục thuế"
        Me.ThueId.ColumnEdit = Me.cboDMthue
        Me.ThueId.FieldName = "ThueId"
        Me.ThueId.Name = "ThueId"
        Me.ThueId.Visible = True
        Me.ThueId.VisibleIndex = 10
        Me.ThueId.Width = 105
        '
        'cboDMthue
        '
        Me.cboDMthue.AutoHeight = False
        Me.cboDMthue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMthue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMthue.Name = "cboDMthue"
        '
        'TY_LE_THUE_GTGT
        '
        Me.TY_LE_THUE_GTGT.Caption = "% thuế  GTGT"
        Me.TY_LE_THUE_GTGT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.TY_LE_THUE_GTGT.FieldName = "TyLeThueGtgt"
        Me.TY_LE_THUE_GTGT.Name = "TY_LE_THUE_GTGT"
        Me.TY_LE_THUE_GTGT.Visible = True
        Me.TY_LE_THUE_GTGT.VisibleIndex = 11
        Me.TY_LE_THUE_GTGT.Width = 120
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'SO_TIEN_THUE_GTGT
        '
        Me.SO_TIEN_THUE_GTGT.Caption = "Số tiền thuế GTGT"
        Me.SO_TIEN_THUE_GTGT.DisplayFormat.FormatString = "n2"
        Me.SO_TIEN_THUE_GTGT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_TIEN_THUE_GTGT.FieldName = "SoTienThueGtgt"
        Me.SO_TIEN_THUE_GTGT.Name = "SO_TIEN_THUE_GTGT"
        Me.SO_TIEN_THUE_GTGT.Visible = True
        Me.SO_TIEN_THUE_GTGT.VisibleIndex = 12
        Me.SO_TIEN_THUE_GTGT.Width = 120
        '
        'ID_DM_PTQT_CO
        '
        Me.ID_DM_PTQT_CO.Caption = "PTQT"
        Me.ID_DM_PTQT_CO.ColumnEdit = Me.cboPTQT
        Me.ID_DM_PTQT_CO.FieldName = "IdDmPtqtCo"
        Me.ID_DM_PTQT_CO.Name = "ID_DM_PTQT_CO"
        Me.ID_DM_PTQT_CO.Visible = True
        Me.ID_DM_PTQT_CO.VisibleIndex = 14
        '
        'cboPTQT
        '
        Me.cboPTQT.AutoHeight = False
        Me.cboPTQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPTQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQT.Name = "cboPTQT"
        Me.cboPTQT.NullText = ""
        '
        'ID_DM_TUDO_1_CO
        '
        Me.ID_DM_TUDO_1_CO.Caption = "DM tự do 1"
        Me.ID_DM_TUDO_1_CO.ColumnEdit = Me.cboTudo1
        Me.ID_DM_TUDO_1_CO.FieldName = "IdDmTudo1Co"
        Me.ID_DM_TUDO_1_CO.Name = "ID_DM_TUDO_1_CO"
        Me.ID_DM_TUDO_1_CO.Visible = True
        Me.ID_DM_TUDO_1_CO.VisibleIndex = 15
        '
        'cboTudo1
        '
        Me.cboTudo1.AutoHeight = False
        Me.cboTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo1.Name = "cboTudo1"
        Me.cboTudo1.NullText = ""
        '
        'ID_DM_TUDO_2_CO
        '
        Me.ID_DM_TUDO_2_CO.Caption = "DM tự do 2"
        Me.ID_DM_TUDO_2_CO.ColumnEdit = Me.cboTudo2
        Me.ID_DM_TUDO_2_CO.FieldName = "IdDmTudo2Co"
        Me.ID_DM_TUDO_2_CO.Name = "ID_DM_TUDO_2_CO"
        Me.ID_DM_TUDO_2_CO.Visible = True
        Me.ID_DM_TUDO_2_CO.VisibleIndex = 16
        '
        'cboTudo2
        '
        Me.cboTudo2.AutoHeight = False
        Me.cboTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo2.Name = "cboTudo2"
        Me.cboTudo2.NullText = ""
        '
        'ID_DM_TUDO_3_CO
        '
        Me.ID_DM_TUDO_3_CO.Caption = "DM tự do 3"
        Me.ID_DM_TUDO_3_CO.ColumnEdit = Me.cboTudo3
        Me.ID_DM_TUDO_3_CO.FieldName = "IdDmTudo3Co"
        Me.ID_DM_TUDO_3_CO.Name = "ID_DM_TUDO_3_CO"
        Me.ID_DM_TUDO_3_CO.Visible = True
        Me.ID_DM_TUDO_3_CO.VisibleIndex = 17
        '
        'cboTudo3
        '
        Me.cboTudo3.AutoHeight = False
        Me.cboTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo3.Name = "cboTudo3"
        Me.cboTudo3.NullText = ""
        '
        'ID_DM_TUDO_4_CO
        '
        Me.ID_DM_TUDO_4_CO.Caption = "DM tự do 4"
        Me.ID_DM_TUDO_4_CO.ColumnEdit = Me.cboTudo4
        Me.ID_DM_TUDO_4_CO.FieldName = "IdDmTudo4Co"
        Me.ID_DM_TUDO_4_CO.Name = "ID_DM_TUDO_4_CO"
        Me.ID_DM_TUDO_4_CO.Visible = True
        Me.ID_DM_TUDO_4_CO.VisibleIndex = 18
        '
        'cboTudo4
        '
        Me.cboTudo4.AutoHeight = False
        Me.cboTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo4.Name = "cboTudo4"
        Me.cboTudo4.NullText = ""
        '
        'ID_DM_TUDO_5_CO
        '
        Me.ID_DM_TUDO_5_CO.Caption = "DM tự do 5"
        Me.ID_DM_TUDO_5_CO.ColumnEdit = Me.cboTudo5
        Me.ID_DM_TUDO_5_CO.FieldName = "IdDmTudo5Co"
        Me.ID_DM_TUDO_5_CO.Name = "ID_DM_TUDO_5_CO"
        Me.ID_DM_TUDO_5_CO.Visible = True
        Me.ID_DM_TUDO_5_CO.VisibleIndex = 19
        '
        'cboTudo5
        '
        Me.cboTudo5.AutoHeight = False
        Me.cboTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo5.Name = "cboTudo5"
        Me.cboTudo5.NullText = ""
        '
        'ID_DM_PHONGBAN_CO
        '
        Me.ID_DM_PHONGBAN_CO.Caption = "Phòng ban"
        Me.ID_DM_PHONGBAN_CO.ColumnEdit = Me.cboPhongban
        Me.ID_DM_PHONGBAN_CO.FieldName = "IdDmPhongbanCo"
        Me.ID_DM_PHONGBAN_CO.Name = "ID_DM_PHONGBAN_CO"
        Me.ID_DM_PHONGBAN_CO.Visible = True
        Me.ID_DM_PHONGBAN_CO.VisibleIndex = 20
        '
        'cboPhongban
        '
        Me.cboPhongban.AutoHeight = False
        Me.cboPhongban.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongban.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongban.Name = "cboPhongban"
        Me.cboPhongban.NullText = ""
        '
        'ID_DM_VUVIEC_CO
        '
        Me.ID_DM_VUVIEC_CO.Caption = "Vụ việc"
        Me.ID_DM_VUVIEC_CO.ColumnEdit = Me.cboVuviec
        Me.ID_DM_VUVIEC_CO.FieldName = "IdDmVuviecCo"
        Me.ID_DM_VUVIEC_CO.Name = "ID_DM_VUVIEC_CO"
        Me.ID_DM_VUVIEC_CO.Visible = True
        Me.ID_DM_VUVIEC_CO.VisibleIndex = 21
        '
        'cboVuviec
        '
        Me.cboVuviec.AutoHeight = False
        Me.cboVuviec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuviec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuviec.Name = "cboVuviec"
        Me.cboVuviec.NullText = ""
        '
        'ID_DM_KHOANPHI_CO
        '
        Me.ID_DM_KHOANPHI_CO.Caption = "Khoản phí"
        Me.ID_DM_KHOANPHI_CO.ColumnEdit = Me.cboKhoanphi
        Me.ID_DM_KHOANPHI_CO.FieldName = "IdDmKhoanphiCo"
        Me.ID_DM_KHOANPHI_CO.Name = "ID_DM_KHOANPHI_CO"
        Me.ID_DM_KHOANPHI_CO.Visible = True
        Me.ID_DM_KHOANPHI_CO.VisibleIndex = 22
        '
        'cboKhoanphi
        '
        Me.cboKhoanphi.AutoHeight = False
        Me.cboKhoanphi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanphi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanphi.Name = "cboKhoanphi"
        Me.cboKhoanphi.NullText = ""
        '
        'ID_DM_HOPDONG_CO
        '
        Me.ID_DM_HOPDONG_CO.Caption = "Hợp đồng"
        Me.ID_DM_HOPDONG_CO.ColumnEdit = Me.cboHopDong
        Me.ID_DM_HOPDONG_CO.FieldName = "IdDmHopdongCo"
        Me.ID_DM_HOPDONG_CO.Name = "ID_DM_HOPDONG_CO"
        Me.ID_DM_HOPDONG_CO.Visible = True
        Me.ID_DM_HOPDONG_CO.VisibleIndex = 23
        '
        'cboHopDong
        '
        Me.cboHopDong.AutoHeight = False
        Me.cboHopDong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopDong.Name = "cboHopDong"
        Me.cboHopDong.NullText = ""
        '
        'grcPhieuTraHang
        '
        Me.grcPhieuTraHang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grcPhieuTraHang.Location = New System.Drawing.Point(6, 32)
        Me.grcPhieuTraHang.MainView = Me.grcPhieuTraHang_View
        Me.grcPhieuTraHang.Name = "grcPhieuTraHang"
        Me.grcPhieuTraHang.Padding = New System.Windows.Forms.Padding(4)
        Me.grcPhieuTraHang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboHANGHOA_ID, Me.cboMaKho, Me.cboMA_TKC_GIAVON, Me.cboPTQT, Me.cboTudo1, Me.cboTudo2, Me.cboTudo3, Me.cboTudo4, Me.cboTudo5, Me.cboPhongban, Me.cboVuviec, Me.cboKhoanphi, Me.RepositoryItemCheckedComboBoxEdit1, Me.GFilter_HANGHOA_ID, Me.GFilter_MA_TKC_GIAVON, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.cboHopDong, Me.cboDMthue})
        Me.grcPhieuTraHang.Size = New System.Drawing.Size(789, 286)
        Me.grcPhieuTraHang.TabIndex = 0
        Me.grcPhieuTraHang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grcPhieuTraHang_View})
        '
        'RepositoryItemCheckedComboBoxEdit1
        '
        Me.RepositoryItemCheckedComboBoxEdit1.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1"
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.GfilterTKN_THUE_GTGT)
        Me.groupControl2.Controls.Add(Me.UR_STATUS)
        Me.groupControl2.Controls.Add(Me.TextEdit3)
        Me.groupControl2.Controls.Add(Me.txtSOLUONG)
        Me.groupControl2.Controls.Add(Me.txtThueTTDB)
        Me.groupControl2.Controls.Add(Me.txtTongCong)
        Me.groupControl2.Controls.Add(Me.txtTienHang)
        Me.groupControl2.Controls.Add(Me.ckeNhapTienThue)
        Me.groupControl2.Controls.Add(Me.labelControl18)
        Me.groupControl2.Controls.Add(Me.labelControl19)
        Me.groupControl2.Controls.Add(Me.labelControl16)
        Me.groupControl2.Controls.Add(Me.labelControl20)
        Me.groupControl2.Controls.Add(Me.labelControl22)
        Me.groupControl2.Controls.Add(Me.labelControl13)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupControl2.Location = New System.Drawing.Point(0, 477)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.groupControl2.ShowCaption = False
        Me.groupControl2.Size = New System.Drawing.Size(801, 93)
        Me.groupControl2.TabIndex = 2
        '
        'GfilterTKN_THUE_GTGT
        '
        Me.GfilterTKN_THUE_GTGT.AllowNull = True
        Me.GfilterTKN_THUE_GTGT.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GfilterTKN_THUE_GTGT.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GfilterTKN_THUE_GTGT.C_DATA_SOURCE = Nothing
        Me.GfilterTKN_THUE_GTGT.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GfilterTKN_THUE_GTGT.C_FORM_TITLE = "Chọn tài khoản"
        Me.GfilterTKN_THUE_GTGT.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GfilterTKN_THUE_GTGT.C_IS_CHECK_OTHER = "="
        Me.GfilterTKN_THUE_GTGT.C_IS_CHECK_STRING = "="
        Me.GfilterTKN_THUE_GTGT.C_IS_FILTER_STRING = ""
        Me.GfilterTKN_THUE_GTGT.C_IS_QUICKADD = False
        Me.GfilterTKN_THUE_GTGT.C_IS_SORT_ORDER_STRING = ""
        Me.GfilterTKN_THUE_GTGT.C_KEY_NAME = "MaTaikhoan"
        Me.GfilterTKN_THUE_GTGT.EditValue = ""
        Me.GfilterTKN_THUE_GTGT.EditValues = ""
        Me.GfilterTKN_THUE_GTGT.ENABLES = True
        Me.GfilterTKN_THUE_GTGT.IsNotTextChanged = True
        Me.GfilterTKN_THUE_GTGT.ListEditValue = CType(resources.GetObject("GfilterTKN_THUE_GTGT.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GfilterTKN_THUE_GTGT.Location = New System.Drawing.Point(68, 11)
        Me.GfilterTKN_THUE_GTGT.MessageWarning = "Giá trị không hợp lệ"
        Me.GfilterTKN_THUE_GTGT.Name = "GfilterTKN_THUE_GTGT"
        Me.GfilterTKN_THUE_GTGT.NEXT_TAB = 0
        Me.GfilterTKN_THUE_GTGT.Size = New System.Drawing.Size(96, 20)
        Me.GfilterTKN_THUE_GTGT.TabIndex = 0
        '
        'UR_STATUS
        '
        Me.UR_STATUS.CheckStatus = True
        Me.UR_STATUS.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_STATUS.Location = New System.Drawing.Point(8, 37)
        Me.UR_STATUS.Name = "UR_STATUS"
        Me.UR_STATUS.Size = New System.Drawing.Size(314, 20)
        Me.UR_STATUS.TabIndex = 1
        ValueInfo1.Den_Ngay = Nothing
        ValueInfo1.ID_DM = Nothing
        ValueInfo1.Ky_Hieu = Nothing
        ValueInfo1.MA_DM = Nothing
        ValueInfo1.ParameterValue = Nothing
        ValueInfo1.Ten = Nothing
        ValueInfo1.Tu_Ngay = Nothing
        Me.UR_STATUS.Value_info = ValueInfo1
        '
        'TextEdit3
        '
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(423, 64)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit3.Size = New System.Drawing.Size(55, 20)
        Me.TextEdit3.TabIndex = 2
        Me.TextEdit3.Visible = False
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.EnterMoveNextControl = True
        Me.txtSOLUONG.Location = New System.Drawing.Point(379, 34)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSOLUONG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSOLUONG.Properties.Mask.EditMask = "d"
        Me.txtSOLUONG.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSOLUONG.Properties.ReadOnly = True
        Me.txtSOLUONG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSOLUONG.Size = New System.Drawing.Size(96, 20)
        Me.txtSOLUONG.TabIndex = 0
        Me.txtSOLUONG.Visible = False
        '
        'txtThueTTDB
        '
        Me.txtThueTTDB.Location = New System.Drawing.Point(560, 37)
        Me.txtThueTTDB.Name = "txtThueTTDB"
        Me.txtThueTTDB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtThueTTDB.Properties.Appearance.Options.UseFont = True
        Me.txtThueTTDB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThueTTDB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThueTTDB.Properties.Mask.EditMask = "n0"
        Me.txtThueTTDB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtThueTTDB.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtThueTTDB.Properties.ReadOnly = True
        Me.txtThueTTDB.Size = New System.Drawing.Size(112, 20)
        Me.txtThueTTDB.TabIndex = 3
        '
        'txtTongCong
        '
        Me.txtTongCong.Location = New System.Drawing.Point(560, 63)
        Me.txtTongCong.Name = "txtTongCong"
        Me.txtTongCong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTongCong.Properties.Appearance.Options.UseFont = True
        Me.txtTongCong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongCong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongCong.Properties.Mask.EditMask = "n0"
        Me.txtTongCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongCong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongCong.Properties.ReadOnly = True
        Me.txtTongCong.Size = New System.Drawing.Size(112, 20)
        Me.txtTongCong.TabIndex = 4
        '
        'txtTienHang
        '
        Me.txtTienHang.Location = New System.Drawing.Point(560, 11)
        Me.txtTienHang.Name = "txtTienHang"
        Me.txtTienHang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTienHang.Properties.Appearance.Options.UseFont = True
        Me.txtTienHang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienHang.Properties.Mask.EditMask = "n0"
        Me.txtTienHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienHang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienHang.Properties.ReadOnly = True
        Me.txtTienHang.Size = New System.Drawing.Size(112, 20)
        Me.txtTienHang.TabIndex = 2
        '
        'ckeNhapTienThue
        '
        Me.ckeNhapTienThue.Location = New System.Drawing.Point(679, 38)
        Me.ckeNhapTienThue.Name = "ckeNhapTienThue"
        Me.ckeNhapTienThue.Properties.Caption = "Nhập tiền thuế"
        Me.ckeNhapTienThue.Size = New System.Drawing.Size(104, 19)
        Me.ckeNhapTienThue.TabIndex = 5
        '
        'labelControl18
        '
        Me.labelControl18.Location = New System.Drawing.Point(25, 14)
        Me.labelControl18.Name = "labelControl18"
        Me.labelControl18.Size = New System.Drawing.Size(37, 13)
        Me.labelControl18.TabIndex = 2
        Me.labelControl18.Text = "TK thuế"
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(515, 66)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(39, 13)
        Me.labelControl19.TabIndex = 39
        Me.labelControl19.Text = "Tổng TT"
        '
        'labelControl16
        '
        Me.labelControl16.Location = New System.Drawing.Point(331, 37)
        Me.labelControl16.Name = "labelControl16"
        Me.labelControl16.Size = New System.Drawing.Size(42, 13)
        Me.labelControl16.TabIndex = 0
        Me.labelControl16.Text = "Số lượng"
        Me.labelControl16.Visible = False
        '
        'labelControl20
        '
        Me.labelControl20.Location = New System.Drawing.Point(509, 40)
        Me.labelControl20.Name = "labelControl20"
        Me.labelControl20.Size = New System.Drawing.Size(45, 13)
        Me.labelControl20.TabIndex = 38
        Me.labelControl20.Text = "Tiền thuế"
        '
        'labelControl22
        '
        Me.labelControl22.Location = New System.Drawing.Point(507, 14)
        Me.labelControl22.Name = "labelControl22"
        Me.labelControl22.Size = New System.Drawing.Size(47, 13)
        Me.labelControl22.TabIndex = 36
        Me.labelControl22.Text = "Tiền hàng"
        '
        'labelControl13
        '
        Me.labelControl13.Location = New System.Drawing.Point(369, 67)
        Me.labelControl13.Name = "labelControl13"
        Me.labelControl13.Size = New System.Drawing.Size(48, 13)
        Me.labelControl13.TabIndex = 36
        Me.labelControl13.Text = "Thuế suất"
        Me.labelControl13.Visible = False
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.C_SoChungTu_RP)
        Me.groupControl1.Controls.Add(Me.txtMA_SO_THUE)
        Me.groupControl1.Controls.Add(Me.labelControl3)
        Me.groupControl1.Controls.Add(Me.LabelControl11)
        Me.groupControl1.Controls.Add(Me.GFilter_TK)
        Me.groupControl1.Controls.Add(Me.GFilter)
        Me.groupControl1.Controls.Add(Me.LabelControl6)
        Me.groupControl1.Controls.Add(Me.txtBX_DIENGIAI_2)
        Me.groupControl1.Controls.Add(Me.dteNGAY_CT)
        Me.groupControl1.Controls.Add(Me.txtTEN_KHANG)
        Me.groupControl1.Controls.Add(Me.cboNgoaiTe)
        Me.groupControl1.Controls.Add(Me.chkNGOAI_TE)
        Me.groupControl1.Controls.Add(Me.txtTY_GIA)
        Me.groupControl1.Controls.Add(Me.LabelControl24)
        Me.groupControl1.Controls.Add(Me.txtDIEN_GIAI)
        Me.groupControl1.Controls.Add(Me.txtDIA_CHI)
        Me.groupControl1.Controls.Add(Me.dteNGAY_GHI)
        Me.groupControl1.Controls.Add(Me.labelControl10)
        Me.groupControl1.Controls.Add(Me.labelControl9)
        Me.groupControl1.Controls.Add(Me.labelControl7)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Controls.Add(Me.labelControl2)
        Me.groupControl1.Controls.Add(Me.labelControl1)
        Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupControl1.Location = New System.Drawing.Point(0, 0)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupControl1.ShowCaption = False
        Me.groupControl1.Size = New System.Drawing.Size(801, 153)
        Me.groupControl1.TabIndex = 0
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(68, 65)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 2
        '
        'txtMA_SO_THUE
        '
        Me.txtMA_SO_THUE.EnterMoveNextControl = True
        Me.txtMA_SO_THUE.Location = New System.Drawing.Point(481, 12)
        Me.txtMA_SO_THUE.Name = "txtMA_SO_THUE"
        Me.txtMA_SO_THUE.Properties.MaxLength = 32
        Me.txtMA_SO_THUE.Size = New System.Drawing.Size(130, 20)
        Me.txtMA_SO_THUE.TabIndex = 5
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(203, 41)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(76, 13)
        Me.labelControl3.TabIndex = 30
        Me.labelControl3.Text = "Tên khách hàng"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(27, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl11.TabIndex = 29
        Me.LabelControl11.Text = "Số CT"
        '
        'GFilter_TK
        '
        Me.GFilter_TK.AllowNull = True
        Me.GFilter_TK.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TK.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TK.C_DATA_SOURCE = Nothing
        Me.GFilter_TK.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TK.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TK.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TK.C_IS_CHECK_OTHER = "="
        Me.GFilter_TK.C_IS_CHECK_STRING = "="
        Me.GFilter_TK.C_IS_FILTER_STRING = ""
        Me.GFilter_TK.C_IS_QUICKADD = False
        Me.GFilter_TK.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TK.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TK.EditValue = ""
        Me.GFilter_TK.EditValues = ""
        Me.GFilter_TK.ENABLES = True
        Me.GFilter_TK.IsNotTextChanged = True
        Me.GFilter_TK.ListEditValue = CType(resources.GetObject("GFilter_TK.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TK.Location = New System.Drawing.Point(68, 91)
        Me.GFilter_TK.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TK.Name = "GFilter_TK"
        Me.GFilter_TK.NEXT_TAB = 0
        Me.GFilter_TK.Size = New System.Drawing.Size(100, 20)
        Me.GFilter_TK.TabIndex = 3
        '
        'GFilter
        '
        Me.GFilter.AllowNull = True
        Me.GFilter.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MaKhang--0-0;MaSoThue--0-0;DiaChi-" & _
            "-0-0"
        Me.GFilter.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.GFilter.C_DATA_SOURCE = Nothing
        Me.GFilter.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.GFilter.C_FORM_TITLE = "Chọn khách hàng"
        Me.GFilter.C_IS_CHECK_NUMBER = "="
        Me.GFilter.C_IS_CHECK_OTHER = "="
        Me.GFilter.C_IS_CHECK_STRING = "="
        Me.GFilter.C_IS_FILTER_STRING = ""
        Me.GFilter.C_IS_QUICKADD = True
        Me.GFilter.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter.C_KEY_NAME = "KyHieu"
        Me.GFilter.EditValue = ""
        Me.GFilter.EditValues = ""
        Me.GFilter.ENABLES = True
        Me.GFilter.IsNotTextChanged = True
        Me.GFilter.ListEditValue = CType(resources.GetObject("GFilter.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter.Location = New System.Drawing.Point(292, 12)
        Me.GFilter.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter.Name = "GFilter"
        Me.GFilter.NEXT_TAB = 0
        Me.GFilter.Size = New System.Drawing.Size(124, 20)
        Me.GFilter.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(422, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Mã số thuế"
        '
        'txtBX_DIENGIAI_2
        '
        Me.txtBX_DIENGIAI_2.EnterMoveNextControl = True
        Me.txtBX_DIENGIAI_2.Location = New System.Drawing.Point(292, 116)
        Me.txtBX_DIENGIAI_2.Name = "txtBX_DIENGIAI_2"
        Me.txtBX_DIENGIAI_2.Properties.MaxLength = 256
        Me.txtBX_DIENGIAI_2.Size = New System.Drawing.Size(319, 20)
        Me.txtBX_DIENGIAI_2.TabIndex = 9
        '
        'dteNGAY_CT
        '
        Me.dteNGAY_CT.EditValue = Nothing
        Me.dteNGAY_CT.EnterMoveNextControl = True
        Me.dteNGAY_CT.Location = New System.Drawing.Point(68, 12)
        Me.dteNGAY_CT.Name = "dteNGAY_CT"
        Me.dteNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_CT.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_CT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dteNGAY_CT.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_CT.TabIndex = 0
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(292, 38)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.Properties.MaxLength = 128
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(319, 20)
        Me.txtTEN_KHANG.TabIndex = 6
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(705, 12)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboNgoaiTe.Size = New System.Drawing.Size(85, 20)
        Me.cboNgoaiTe.TabIndex = 10
        '
        'chkNGOAI_TE
        '
        Me.chkNGOAI_TE.Location = New System.Drawing.Point(704, 113)
        Me.chkNGOAI_TE.Name = "chkNGOAI_TE"
        Me.chkNGOAI_TE.Properties.Caption = "Ngoại tệ"
        Me.chkNGOAI_TE.Size = New System.Drawing.Size(70, 19)
        Me.chkNGOAI_TE.TabIndex = 17
        Me.chkNGOAI_TE.Visible = False
        '
        'txtTY_GIA
        '
        Me.txtTY_GIA.EnterMoveNextControl = True
        Me.txtTY_GIA.Location = New System.Drawing.Point(705, 38)
        Me.txtTY_GIA.Name = "txtTY_GIA"
        Me.txtTY_GIA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA.Properties.Mask.EditMask = "n"
        Me.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA.Properties.MaxLength = 12
        Me.txtTY_GIA.Size = New System.Drawing.Size(85, 20)
        Me.txtTY_GIA.TabIndex = 11
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(670, 41)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl24.TabIndex = 19
        Me.LabelControl24.Text = "Tỷ giá"
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(292, 90)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.Properties.MaxLength = 256
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(319, 20)
        Me.txtDIEN_GIAI.TabIndex = 8
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(292, 64)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.Properties.MaxLength = 256
        Me.txtDIA_CHI.Size = New System.Drawing.Size(319, 20)
        Me.txtDIA_CHI.TabIndex = 7
        '
        'dteNGAY_GHI
        '
        Me.dteNGAY_GHI.EditValue = Nothing
        Me.dteNGAY_GHI.EnterMoveNextControl = True
        Me.dteNGAY_GHI.Location = New System.Drawing.Point(68, 38)
        Me.dteNGAY_GHI.Name = "dteNGAY_GHI"
        Me.dteNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_GHI.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_GHI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dteNGAY_GHI.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_GHI.TabIndex = 1
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(14, 15)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 13
        Me.labelControl10.Text = "Ngày CT"
        '
        'labelControl9
        '
        Me.labelControl9.Location = New System.Drawing.Point(14, 41)
        Me.labelControl9.Name = "labelControl9"
        Me.labelControl9.Size = New System.Drawing.Size(41, 13)
        Me.labelControl9.TabIndex = 11
        Me.labelControl9.Text = "Ngày HT"
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(246, 119)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(35, 13)
        Me.labelControl7.TabIndex = 10
        Me.labelControl7.Text = "Ghi chú"
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(27, 94)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(27, 13)
        Me.labelControl5.TabIndex = 8
        Me.labelControl5.Text = "TK nợ"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(241, 93)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(40, 13)
        Me.labelControl4.TabIndex = 6
        Me.labelControl4.Text = "Diễn giải"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(249, 67)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(32, 13)
        Me.labelControl2.TabIndex = 2
        Me.labelControl2.Text = "Địa chỉ"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(236, 15)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(45, 13)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Mã khách"
        '
        'depCT_H_Nx
        '
        Me.depCT_H_Nx.ContainerControl = Me
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(451, 7)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grcPhieuTraHang)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 153)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(801, 324)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "GroupControl3"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grcLPN_Hnx)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupControl2)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 570)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_HANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcPhieuTraHang_View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuviec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcPhieuTraHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.groupControl2.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSOLUONG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThueTTDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongCong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.txtMA_SO_THUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBX_DIENGIAI_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQui As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Private WithEvents MA_TKC_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents KHO_XUAT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DON_GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TON_KHO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents HANGHOA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grcPhieuTraHang As DevExpress.XtraGrid.GridControl
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Private WithEvents ckeNhapTienThue As DevExpress.XtraEditors.CheckEdit
    Private WithEvents labelControl18 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl16 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl20 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl22 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl13 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl9 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents dteNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTienHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongCong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtThueTTDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkNGOAI_TE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTY_GIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSOLUONG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboHANGHOA_ID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMaKho As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMA_TKC_GIAVON As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents depCT_H_Nx As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Private WithEvents dteNGAY_CT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtBX_DIENGIAI_2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPTQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPhongban As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboVuviec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoanphi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnCan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navCTHG As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents UR_STATUS As Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT
    Private WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GFilter As Vns.Erp.Core.CustomFilter
    Friend WithEvents GFilter_HANGHOA_ID As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents GFilter_MA_TKC_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_TK As Vns.Erp.Core.CustomFilter
    Friend WithEvents GfilterTKN_THUE_GTGT As Vns.Erp.Core.CustomFilter
    Friend WithEvents txtCT_SO As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMA_SO_THUE As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grcPhieuTraHang_View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents THU_TU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SoChungTu_RP As Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu
    Friend WithEvents DON_GIA_VON_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIA_VON_NT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TY_LE_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ID_DM_HOPDONG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboHopDong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ThueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDMthue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
