<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCT_H_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCT_H_ChiTiet))
        Dim ValueInfo1 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MaTkNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_NO = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TenTkNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MaTkCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_CO = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TenTkCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieuKhangCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TenKhangCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTienNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaHoadon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_HOADON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.IdDmPtqtCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPPQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.NoiDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.IdDmVuviecCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmKhoanphiCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoanPhi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmPhongbanCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPhongBan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo1Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo2Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo3Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo4Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo5Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmHopdongCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.grlKhachHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNoiDung = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grlTaiKhoanCo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSoTien = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtSoTienNT = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grlHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlKhachHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlTaiKhoanNo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTenTkNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboKhachHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhachHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDM_KHANG = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.navWelding1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.GRC_CTH = New DevExpress.XtraGrid.GridControl()
        Me.GRV_CTH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Ghi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CtSo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TyGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.popView = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.popViewNhatKyChungTu = New DevExpress.XtraBars.BarButtonItem()
        Me.popViewNhatKyHeThong = New DevExpress.XtraBars.BarButtonItem()
        Me.barView = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grpSMQR = New DevExpress.XtraEditors.GroupControl()
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.cFilterTaiKhoan = New Vns.Erp.Core.CustomFilter()
        Me.cFilter = New Vns.Erp.Core.CustomFilter()
        Me.txtTY_GIA1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMST_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.daeNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.txtNGUOI_NHAN_NOP_TIEN = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.lblTaikhoan = New DevExpress.XtraEditors.LabelControl()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.grlLOAI_CT_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.daeNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grcCT_Thue = New DevExpress.XtraEditors.GroupControl()
        Me.cFilterTaiKhoanThue = New Vns.Erp.Core.CustomFilter()
        Me.btnCopy = New DevExpress.XtraEditors.SimpleButton()
        Me.UR_Status = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
        Me.chkHDGTGT = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTongTien = New DevExpress.XtraEditors.TextEdit()
        Me.lblTongTien = New DevExpress.XtraEditors.LabelControl()
        Me.btnHoaDon = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTongTienThue = New DevExpress.XtraEditors.TextEdit()
        Me.lblTongTienThue = New DevExpress.XtraEditors.LabelControl()
        Me.txtTongSoTien = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.grlTaiKhoanThue = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblTkThue = New DevExpress.XtraEditors.LabelControl()
        Me.btnThue = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_CO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_KY_HIEU_KHANG_CO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_HOADON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPPQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlKhachHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTienNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlKhachHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTkNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDM_KHANG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GRC_CTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRV_CTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMQR.SuspendLayout()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcCT_Thue.SuspendLayout()
        CType(Me.chkHDGTGT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTienThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSoTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelControl16
        '
        Me.labelControl16.Location = New System.Drawing.Point(270, 112)
        Me.labelControl16.Name = "labelControl16"
        Me.labelControl16.Size = New System.Drawing.Size(40, 13)
        Me.labelControl16.TabIndex = 28
        Me.labelControl16.Text = "Diễn giải"
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(231, 87)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(73, 13)
        Me.labelControl11.TabIndex = 24
        Me.labelControl11.Text = "Người giao dịch"
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.CausesValidation = False
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 157)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(801, 350)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(0, 0)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grlKhachHangNo, Me.txtNoiDung, Me.grlTaiKhoanCo, Me.txtSoTien, Me.txtSoTienNT, Me.grlHopDong, Me.grlVuViec, Me.grlKhachHangCo, Me.grlTaiKhoanNo, Me.txtTenTkNo, Me.cboHopDong, Me.cboVuViec, Me.cboKhachHangNo, Me.cboKhachHangCo, Me.cboPPQT, Me.cboPhongBan, Me.cboDMTudo1, Me.cboDMTudo2, Me.cboDMTudo3, Me.cboDMTudo4, Me.cboDMTudo5, Me.cboKhoanPhi, Me.cboDM_KHANG, Me.MyRepositoryItem_MA_TK_NO, Me.MyRepositoryItem_MA_TK_CO, Me.MyRepositoryItem_KY_HIEU_KHANG_CO, Me.MyRepositoryItem_MA_HOADON, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me._GridControl.Size = New System.Drawing.Size(801, 350)
        Me._GridControl.TabIndex = 4
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me._GridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.Empty.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.EvenRow.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.Options.UseBorderColor = True
        Me._GridView.Appearance.EvenRow.Options.UseForeColor = True
        Me._GridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me._GridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FilterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.FixedLine.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.Options.UseForeColor = True
        Me._GridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me._GridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedRow.Options.UseForeColor = True
        Me._GridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.Options.UseBackColor = True
        Me._GridView.Appearance.GroupButton.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupFooter.Options.UseBackColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseForeColor = True
        Me._GridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupPanel.Options.UseBackColor = True
        Me._GridView.Appearance.GroupPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupRow.Options.UseBackColor = True
        Me._GridView.Appearance.GroupRow.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupRow.Options.UseForeColor = True
        Me._GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me._GridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me._GridView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me._GridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.HorzLine.Options.UseBackColor = True
        Me._GridView.Appearance.HorzLine.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.OddRow.Options.UseBackColor = True
        Me._GridView.Appearance.OddRow.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.Options.UseForeColor = True
        Me._GridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me._GridView.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me._GridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.Preview.Options.UseBackColor = True
        Me._GridView.Appearance.Preview.Options.UseFont = True
        Me._GridView.Appearance.Preview.Options.UseForeColor = True
        Me._GridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.Row.Options.UseBackColor = True
        Me._GridView.Appearance.Row.Options.UseForeColor = True
        Me._GridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.RowSeparator.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me._GridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.SelectedRow.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.Options.UseForeColor = True
        Me._GridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.TopNewRow.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.VertLine.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.Options.UseBorderColor = True
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaTkNo, Me.TenTkNo, Me.MaTkCo, Me.TenTkCo, Me.KyHieuKhangCo, Me.TenKhangCo, Me.SoTienNte, Me.SoTien, Me.MaHoadon, Me.IdDmPtqtCo, Me.NoiDung, Me.IdDmVuviecCo, Me.IdDmKhoanphiCo, Me.IdDmPhongbanCo, Me.IdDmTudo1Co, Me.IdDmTudo2Co, Me.IdDmTudo3Co, Me.IdDmTudo4Co, Me.IdDmTudo5Co, Me.IdDmHopdongCo})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsNavigation.AutoFocusNewRow = True
        Me._GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.EnableAppearanceEvenRow = True
        Me._GridView.OptionsView.EnableAppearanceOddRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'MaTkNo
        '
        Me.MaTkNo.Caption = "TK nợ"
        Me.MaTkNo.ColumnEdit = Me.MyRepositoryItem_MA_TK_NO
        Me.MaTkNo.FieldName = "MaTkNo"
        Me.MaTkNo.Name = "MaTkNo"
        Me.MaTkNo.Visible = True
        Me.MaTkNo.VisibleIndex = 0
        Me.MaTkNo.Width = 71
        '
        'MyRepositoryItem_MA_TK_NO
        '
        Me.MyRepositoryItem_MA_TK_NO.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_NO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_NO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_NO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_NO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_NO.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_OTHER = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_NO.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_NO.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_NO.EditValues = ""
        Me.MyRepositoryItem_MA_TK_NO.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_NO.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_NO.Name = "MyRepositoryItem_MA_TK_NO"
        Me.MyRepositoryItem_MA_TK_NO.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_NO.OBJ_CONDITITION = Nothing
        '
        'TenTkNo
        '
        Me.TenTkNo.Caption = "Tên TK nợ"
        Me.TenTkNo.FieldName = "TenTkNo"
        Me.TenTkNo.Name = "TenTkNo"
        Me.TenTkNo.OptionsColumn.ReadOnly = True
        Me.TenTkNo.Visible = True
        Me.TenTkNo.VisibleIndex = 1
        Me.TenTkNo.Width = 176
        '
        'MaTkCo
        '
        Me.MaTkCo.Caption = "TK có"
        Me.MaTkCo.ColumnEdit = Me.MyRepositoryItem_MA_TK_CO
        Me.MaTkCo.FieldName = "MaTkCo"
        Me.MaTkCo.Name = "MaTkCo"
        Me.MaTkCo.Visible = True
        Me.MaTkCo.VisibleIndex = 2
        Me.MaTkCo.Width = 73
        '
        'MyRepositoryItem_MA_TK_CO
        '
        Me.MyRepositoryItem_MA_TK_CO.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_CO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_CO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_CO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_CO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_CO.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_OTHER = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_CO.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_CO.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_CO.EditValues = ""
        Me.MyRepositoryItem_MA_TK_CO.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_CO.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_CO.Name = "MyRepositoryItem_MA_TK_CO"
        Me.MyRepositoryItem_MA_TK_CO.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_CO.OBJ_CONDITITION = Nothing
        '
        'TenTkCo
        '
        Me.TenTkCo.Caption = "Tên TK có"
        Me.TenTkCo.FieldName = "TenTkCo"
        Me.TenTkCo.Name = "TenTkCo"
        Me.TenTkCo.OptionsColumn.ReadOnly = True
        Me.TenTkCo.Visible = True
        Me.TenTkCo.VisibleIndex = 3
        Me.TenTkCo.Width = 173
        '
        'KyHieuKhangCo
        '
        Me.KyHieuKhangCo.Caption = "Khách hàng"
        Me.KyHieuKhangCo.ColumnEdit = Me.MyRepositoryItem_KY_HIEU_KHANG_CO
        Me.KyHieuKhangCo.FieldName = "KyHieuKhangCo"
        Me.KyHieuKhangCo.Name = "KyHieuKhangCo"
        Me.KyHieuKhangCo.Visible = True
        Me.KyHieuKhangCo.VisibleIndex = 4
        Me.KyHieuKhangCo.Width = 130
        '
        'MyRepositoryItem_KY_HIEU_KHANG_CO
        '
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.AutoHeight = False
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MaKhang--0-0;MaSoThue--0-0;DiaChi-" & _
            "-0-0"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_FORM_TITLE = "Chọn khách hàng"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_CHECK_NUMBER = "="
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_QUICKADD = True
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.C_KEY_NAME = "KyHieu"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.Editors = Nothing
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.EditValues = ""
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.ListEditValues = CType(resources.GetObject("MyRepositoryItem_KY_HIEU_KHANG_CO.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.Name = "MyRepositoryItem_KY_HIEU_KHANG_CO"
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.NEXT_TAB = 0
        Me.MyRepositoryItem_KY_HIEU_KHANG_CO.OBJ_CONDITITION = Nothing
        '
        'TenKhangCo
        '
        Me.TenKhangCo.Caption = "Tên khách hàng"
        Me.TenKhangCo.FieldName = "TenKhangCo"
        Me.TenKhangCo.Name = "TenKhangCo"
        Me.TenKhangCo.OptionsColumn.ReadOnly = True
        Me.TenKhangCo.Visible = True
        Me.TenKhangCo.VisibleIndex = 5
        Me.TenKhangCo.Width = 176
        '
        'SoTienNte
        '
        Me.SoTienNte.AppearanceCell.Options.UseTextOptions = True
        Me.SoTienNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SoTienNte.Caption = "Số tiền NT"
        Me.SoTienNte.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.SoTienNte.FieldName = "SoTienNte"
        Me.SoTienNte.GroupFormat.FormatString = "n0"
        Me.SoTienNte.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienNte.Name = "SoTienNte"
        Me.SoTienNte.Visible = True
        Me.SoTienNte.VisibleIndex = 6
        Me.SoTienNte.Width = 100
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SoTien
        '
        Me.SoTien.Caption = "Số tiền"
        Me.SoTien.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.SoTien.FieldName = "SoTien"
        Me.SoTien.Name = "SoTien"
        Me.SoTien.Visible = True
        Me.SoTien.VisibleIndex = 7
        Me.SoTien.Width = 100
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'MaHoadon
        '
        Me.MaHoadon.Caption = "CT Hóa đơn"
        Me.MaHoadon.ColumnEdit = Me.MyRepositoryItem_MA_HOADON
        Me.MaHoadon.FieldName = "MaHoadon"
        Me.MaHoadon.Name = "MaHoadon"
        Me.MaHoadon.Visible = True
        Me.MaHoadon.VisibleIndex = 8
        Me.MaHoadon.Width = 100
        '
        'MyRepositoryItem_MA_HOADON
        '
        Me.MyRepositoryItem_MA_HOADON.AutoHeight = False
        Me.MyRepositoryItem_MA_HOADON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_HOADON.C_ARR_COLS_DISPLAY = "SoHoadon-Số hóa đơn-100-1;SoSeri-Số Seri-100-1;NgayHoadon-Ngày hóa đơn-100-1;TenK" & _
            "hachhang-Tên khách hàng-200-1;Id--0-0"
        Me.MyRepositoryItem_MA_HOADON.C_ARR_COLS_RETURN = "Id;SoHoadon;SoSeri"
        Me.MyRepositoryItem_MA_HOADON.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_HOADON.C_FORM_DANHSACH = ""
        Me.MyRepositoryItem_MA_HOADON.C_FORM_TITLE = "Chọn hóa đơn"
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_NUMBER = "="
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_HOADON.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_HOADON.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_HOADON.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_HOADON.C_KEY_NAME = "SoHoadon"
        Me.MyRepositoryItem_MA_HOADON.Editors = Nothing
        Me.MyRepositoryItem_MA_HOADON.EditValues = ""
        Me.MyRepositoryItem_MA_HOADON.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_HOADON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_HOADON.Name = "MyRepositoryItem_MA_HOADON"
        Me.MyRepositoryItem_MA_HOADON.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_HOADON.OBJ_CONDITITION = Nothing
        '
        'IdDmPtqtCo
        '
        Me.IdDmPtqtCo.Caption = "Loại dòng tiền"
        Me.IdDmPtqtCo.ColumnEdit = Me.cboPPQT
        Me.IdDmPtqtCo.FieldName = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Name = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Visible = True
        Me.IdDmPtqtCo.VisibleIndex = 9
        Me.IdDmPtqtCo.Width = 150
        '
        'cboPPQT
        '
        Me.cboPPQT.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPPQT.AutoHeight = False
        Me.cboPPQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPPQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPPQT.Name = "cboPPQT"
        Me.cboPPQT.NullText = ""
        '
        'NoiDung
        '
        Me.NoiDung.Caption = "Nội dung"
        Me.NoiDung.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.NoiDung.FieldName = "NoiDung"
        Me.NoiDung.Name = "NoiDung"
        Me.NoiDung.Visible = True
        Me.NoiDung.VisibleIndex = 10
        Me.NoiDung.Width = 250
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 256
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'IdDmVuviecCo
        '
        Me.IdDmVuviecCo.Caption = "Vụ việc"
        Me.IdDmVuviecCo.ColumnEdit = Me.cboVuViec
        Me.IdDmVuviecCo.FieldName = "IdDmVuviecCo"
        Me.IdDmVuviecCo.Name = "IdDmVuviecCo"
        Me.IdDmVuviecCo.Visible = True
        Me.IdDmVuviecCo.VisibleIndex = 11
        Me.IdDmVuviecCo.Width = 70
        '
        'cboVuViec
        '
        Me.cboVuViec.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'IdDmKhoanphiCo
        '
        Me.IdDmKhoanphiCo.Caption = "Khoản phí"
        Me.IdDmKhoanphiCo.ColumnEdit = Me.cboKhoanPhi
        Me.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Visible = True
        Me.IdDmKhoanphiCo.VisibleIndex = 12
        Me.IdDmKhoanphiCo.Width = 80
        '
        'cboKhoanPhi
        '
        Me.cboKhoanPhi.AutoHeight = False
        Me.cboKhoanPhi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanPhi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanPhi.Name = "cboKhoanPhi"
        Me.cboKhoanPhi.NullText = ""
        '
        'IdDmPhongbanCo
        '
        Me.IdDmPhongbanCo.Caption = "Phòng ban"
        Me.IdDmPhongbanCo.ColumnEdit = Me.cboPhongBan
        Me.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Name = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Visible = True
        Me.IdDmPhongbanCo.VisibleIndex = 13
        Me.IdDmPhongbanCo.Width = 80
        '
        'cboPhongBan
        '
        Me.cboPhongBan.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPhongBan.AutoHeight = False
        Me.cboPhongBan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongBan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.NullText = ""
        '
        'IdDmTudo1Co
        '
        Me.IdDmTudo1Co.Caption = "DM tự do 1"
        Me.IdDmTudo1Co.ColumnEdit = Me.cboDMTudo1
        Me.IdDmTudo1Co.FieldName = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Name = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Visible = True
        Me.IdDmTudo1Co.VisibleIndex = 14
        Me.IdDmTudo1Co.Width = 130
        '
        'cboDMTudo1
        '
        Me.cboDMTudo1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo1.AutoHeight = False
        Me.cboDMTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo1.Name = "cboDMTudo1"
        Me.cboDMTudo1.NullText = ""
        '
        'IdDmTudo2Co
        '
        Me.IdDmTudo2Co.Caption = "DM tự do 2"
        Me.IdDmTudo2Co.ColumnEdit = Me.cboDMTudo2
        Me.IdDmTudo2Co.FieldName = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Name = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Visible = True
        Me.IdDmTudo2Co.VisibleIndex = 15
        Me.IdDmTudo2Co.Width = 130
        '
        'cboDMTudo2
        '
        Me.cboDMTudo2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo2.AutoHeight = False
        Me.cboDMTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo2.Name = "cboDMTudo2"
        Me.cboDMTudo2.NullText = ""
        '
        'IdDmTudo3Co
        '
        Me.IdDmTudo3Co.Caption = "DM tự do 3"
        Me.IdDmTudo3Co.ColumnEdit = Me.cboDMTudo3
        Me.IdDmTudo3Co.FieldName = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Name = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Visible = True
        Me.IdDmTudo3Co.VisibleIndex = 16
        Me.IdDmTudo3Co.Width = 130
        '
        'cboDMTudo3
        '
        Me.cboDMTudo3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo3.AutoHeight = False
        Me.cboDMTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo3.Name = "cboDMTudo3"
        Me.cboDMTudo3.NullText = ""
        '
        'IdDmTudo4Co
        '
        Me.IdDmTudo4Co.Caption = "DM tự do 4"
        Me.IdDmTudo4Co.ColumnEdit = Me.cboDMTudo4
        Me.IdDmTudo4Co.FieldName = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Name = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Visible = True
        Me.IdDmTudo4Co.VisibleIndex = 17
        Me.IdDmTudo4Co.Width = 130
        '
        'cboDMTudo4
        '
        Me.cboDMTudo4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo4.AutoHeight = False
        Me.cboDMTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo4.Name = "cboDMTudo4"
        Me.cboDMTudo4.NullText = ""
        '
        'IdDmTudo5Co
        '
        Me.IdDmTudo5Co.Caption = "DM tự do 5"
        Me.IdDmTudo5Co.ColumnEdit = Me.cboDMTudo5
        Me.IdDmTudo5Co.FieldName = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Name = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Visible = True
        Me.IdDmTudo5Co.VisibleIndex = 18
        Me.IdDmTudo5Co.Width = 130
        '
        'cboDMTudo5
        '
        Me.cboDMTudo5.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo5.AutoHeight = False
        Me.cboDMTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo5.Name = "cboDMTudo5"
        Me.cboDMTudo5.NullText = ""
        '
        'IdDmHopdongCo
        '
        Me.IdDmHopdongCo.Caption = "Hợp đồng"
        Me.IdDmHopdongCo.ColumnEdit = Me.cboHopDong
        Me.IdDmHopdongCo.FieldName = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Name = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Visible = True
        Me.IdDmHopdongCo.VisibleIndex = 19
        Me.IdDmHopdongCo.Width = 130
        '
        'cboHopDong
        '
        Me.cboHopDong.AutoHeight = False
        Me.cboHopDong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopDong.Name = "cboHopDong"
        Me.cboHopDong.NullText = ""
        '
        'grlKhachHangNo
        '
        Me.grlKhachHangNo.AutoHeight = False
        Me.grlKhachHangNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlKhachHangNo.Name = "grlKhachHangNo"
        Me.grlKhachHangNo.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtNoiDung
        '
        Me.txtNoiDung.AutoHeight = False
        Me.txtNoiDung.Name = "txtNoiDung"
        '
        'grlTaiKhoanCo
        '
        Me.grlTaiKhoanCo.AutoHeight = False
        Me.grlTaiKhoanCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanCo.DisplayMember = "KyHieu"
        Me.grlTaiKhoanCo.Name = "grlTaiKhoanCo"
        Me.grlTaiKhoanCo.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'txtSoTien
        '
        Me.txtSoTien.AutoHeight = False
        Me.txtSoTien.Name = "txtSoTien"
        '
        'txtSoTienNT
        '
        Me.txtSoTienNT.AutoHeight = False
        Me.txtSoTienNT.Name = "txtSoTienNT"
        '
        'grlHopDong
        '
        Me.grlHopDong.AutoHeight = False
        Me.grlHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlHopDong.Name = "grlHopDong"
        Me.grlHopDong.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'grlVuViec
        '
        Me.grlVuViec.AutoHeight = False
        Me.grlVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlVuViec.Name = "grlVuViec"
        Me.grlVuViec.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'grlKhachHangCo
        '
        Me.grlKhachHangCo.AutoHeight = False
        Me.grlKhachHangCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlKhachHangCo.Name = "grlKhachHangCo"
        Me.grlKhachHangCo.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'grlTaiKhoanNo
        '
        Me.grlTaiKhoanNo.AutoHeight = False
        Me.grlTaiKhoanNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanNo.Name = "grlTaiKhoanNo"
        Me.grlTaiKhoanNo.View = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'txtTenTkNo
        '
        Me.txtTenTkNo.AutoHeight = False
        Me.txtTenTkNo.Name = "txtTenTkNo"
        '
        'cboKhachHangNo
        '
        Me.cboKhachHangNo.AutoHeight = False
        Me.cboKhachHangNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhachHangNo.Name = "cboKhachHangNo"
        '
        'cboKhachHangCo
        '
        Me.cboKhachHangCo.AutoHeight = False
        Me.cboKhachHangCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhachHangCo.Name = "cboKhachHangCo"
        '
        'cboDM_KHANG
        '
        Me.cboDM_KHANG.AutoHeight = False
        Me.cboDM_KHANG.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDM_KHANG.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDM_KHANG.Name = "cboDM_KHANG"
        Me.cboDM_KHANG.NullText = ""
        '
        'labelControl12
        '
        Me.labelControl12.Location = New System.Drawing.Point(278, 60)
        Me.labelControl12.Name = "labelControl12"
        Me.labelControl12.Size = New System.Drawing.Size(32, 13)
        Me.labelControl12.TabIndex = 22
        Me.labelControl12.Text = "Địa chỉ"
        '
        'labelControl20
        '
        Me.labelControl20.Location = New System.Drawing.Point(670, 32)
        Me.labelControl20.Name = "labelControl20"
        Me.labelControl20.Size = New System.Drawing.Size(29, 13)
        Me.labelControl20.TabIndex = 5
        Me.labelControl20.Text = "Tỷ giá"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(238, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Mã khách hàng"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navWelding1)
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.btnModify)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnQuit)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 578)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 30)
        Me.PanelControl2.TabIndex = 1
        '
        'navWelding1
        '
        Me.navWelding1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.navWelding1.Buttons.Append.Visible = False
        Me.navWelding1.Buttons.CancelEdit.Visible = False
        Me.navWelding1.Buttons.Edit.Visible = False
        Me.navWelding1.Buttons.EndEdit.Visible = False
        Me.navWelding1.Buttons.NextPage.Visible = False
        Me.navWelding1.Buttons.PrevPage.Visible = False
        Me.navWelding1.Buttons.Remove.Visible = False
        Me.navWelding1.Location = New System.Drawing.Point(0, 0)
        Me.navWelding1.Name = "navWelding1"
        Me.navWelding1.NavigatableControl = Me.GRC_CTH
        Me.navWelding1.Size = New System.Drawing.Size(194, 30)
        Me.navWelding1.TabIndex = 17
        Me.navWelding1.Text = "ControlNavigator4"
        Me.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navWelding1.TextStringFormat = " {0} / {1}"
        '
        'GRC_CTH
        '
        Me.GRC_CTH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRC_CTH.Location = New System.Drawing.Point(2, 22)
        Me.GRC_CTH.MainView = Me.GRV_CTH
        Me.GRC_CTH.Name = "GRC_CTH"
        Me.GRC_CTH.Size = New System.Drawing.Size(190, 550)
        Me.GRC_CTH.TabIndex = 0
        Me.GRC_CTH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRV_CTH})
        '
        'GRV_CTH
        '
        Me.GRV_CTH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.Empty.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRV_CTH.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRV_CTH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.EvenRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.EvenRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTH.Appearance.FixedLine.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GRV_CTH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupButton.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.GroupRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.GroupRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GRV_CTH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GRV_CTH.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GRV_CTH.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTH.Appearance.HorzLine.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.OddRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.OddRow.Options.UseBorderColor = True
        Me.GRV_CTH.Appearance.OddRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GRV_CTH.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GRV_CTH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GRV_CTH.Appearance.Preview.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.Preview.Options.UseFont = True
        Me.GRV_CTH.Appearance.Preview.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.Row.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.Row.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTH.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GRV_CTH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTH.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GRV_CTH.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GRV_CTH.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GRV_CTH.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTH.Appearance.VertLine.Options.UseBackColor = True
        Me.GRV_CTH.Appearance.VertLine.Options.UseBorderColor = True
        Me.GRV_CTH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ghi, Me.NgayCt, Me.CtSo, Me.grv1_SO_TIEN, Me.TyGia, Me.grv1_KY_HIEU_KHANG, Me.grv1_TEN_KHANG})
        Me.GRV_CTH.GridControl = Me.GRC_CTH
        Me.GRV_CTH.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GRV_CTH.Name = "GRV_CTH"
        Me.GRV_CTH.OptionsBehavior.Editable = False
        Me.GRV_CTH.OptionsView.ColumnAutoWidth = False
        Me.GRV_CTH.OptionsView.EnableAppearanceEvenRow = True
        Me.GRV_CTH.OptionsView.EnableAppearanceOddRow = True
        Me.GRV_CTH.OptionsView.ShowGroupPanel = False
        '
        'Ghi
        '
        Me.Ghi.Caption = "Trạng thái"
        Me.Ghi.FieldName = "Ghi"
        Me.Ghi.Name = "Ghi"
        Me.Ghi.Visible = True
        Me.Ghi.VisibleIndex = 0
        Me.Ghi.Width = 76
        '
        'NgayCt
        '
        Me.NgayCt.Caption = "Ngày chứng từ"
        Me.NgayCt.FieldName = "NgayCt"
        Me.NgayCt.Name = "NgayCt"
        Me.NgayCt.OptionsColumn.FixedWidth = True
        Me.NgayCt.Visible = True
        Me.NgayCt.VisibleIndex = 2
        Me.NgayCt.Width = 100
        '
        'CtSo
        '
        Me.CtSo.AppearanceCell.Options.UseTextOptions = True
        Me.CtSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CtSo.Caption = "Số chứng từ"
        Me.CtSo.FieldName = "CtSo"
        Me.CtSo.Name = "CtSo"
        Me.CtSo.OptionsColumn.FixedWidth = True
        Me.CtSo.Visible = True
        Me.CtSo.VisibleIndex = 1
        Me.CtSo.Width = 86
        '
        'grv1_SO_TIEN
        '
        Me.grv1_SO_TIEN.Caption = "Số tiền"
        Me.grv1_SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.grv1_SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grv1_SO_TIEN.FieldName = "SoTien"
        Me.grv1_SO_TIEN.Name = "grv1_SO_TIEN"
        Me.grv1_SO_TIEN.Visible = True
        Me.grv1_SO_TIEN.VisibleIndex = 3
        Me.grv1_SO_TIEN.Width = 100
        '
        'TyGia
        '
        Me.TyGia.Caption = "Tỷ giá"
        Me.TyGia.DisplayFormat.FormatString = "n0"
        Me.TyGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TyGia.FieldName = "TyGia"
        Me.TyGia.Name = "TyGia"
        Me.TyGia.OptionsColumn.FixedWidth = True
        Me.TyGia.Width = 100
        '
        'grv1_KY_HIEU_KHANG
        '
        Me.grv1_KY_HIEU_KHANG.Caption = "Mã khách hàng"
        Me.grv1_KY_HIEU_KHANG.FieldName = "KyHieuKhang"
        Me.grv1_KY_HIEU_KHANG.Name = "grv1_KY_HIEU_KHANG"
        Me.grv1_KY_HIEU_KHANG.Width = 104
        '
        'grv1_TEN_KHANG
        '
        Me.grv1_TEN_KHANG.Caption = "Tên khách hàng"
        Me.grv1_TEN_KHANG.FieldName = "TenKhang"
        Me.grv1_TEN_KHANG.Name = "grv1_TEN_KHANG"
        Me.grv1_TEN_KHANG.Width = 144
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ImageIndex = 0
        Me.btnSearch.Location = New System.Drawing.Point(544, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Tìm"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(286, 0)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(201, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(372, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Xóa"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ImageIndex = 8
        Me.btnCancel.Location = New System.Drawing.Point(630, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Hủy"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.ImageIndex = 8
        Me.btnQuit.Location = New System.Drawing.Point(920, 0)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "&Quay ra"
        '
        'btnPri
        '
        Me.btnPri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPri.ImageIndex = 5
        Me.btnPri.Location = New System.Drawing.Point(716, 0)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 6
        Me.btnPri.Text = "&In ctừ"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(458, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Lưu"
        '
        'popView
        '
        Me.popView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popViewNhatKyChungTu), New DevExpress.XtraBars.LinkPersistInfo(Me.popViewNhatKyHeThong)})
        Me.popView.Manager = Me.barView
        Me.popView.Name = "popView"
        '
        'popViewNhatKyChungTu
        '
        Me.popViewNhatKyChungTu.Caption = "Xem nhật ký chứng từ"
        Me.popViewNhatKyChungTu.Id = 0
        Me.popViewNhatKyChungTu.ImageIndex = 7
        Me.popViewNhatKyChungTu.Name = "popViewNhatKyChungTu"
        '
        'popViewNhatKyHeThong
        '
        Me.popViewNhatKyHeThong.Caption = "Xem nhật ký hệ thống"
        Me.popViewNhatKyHeThong.Id = 1
        Me.popViewNhatKyHeThong.ImageIndex = 5
        Me.popViewNhatKyHeThong.Name = "popViewNhatKyHeThong"
        '
        'barView
        '
        Me.barView.DockControls.Add(Me.barDockControlTop)
        Me.barView.DockControls.Add(Me.barDockControlBottom)
        Me.barView.DockControls.Add(Me.barDockControlLeft)
        Me.barView.DockControls.Add(Me.barDockControlRight)
        Me.barView.Form = Me
        Me.barView.Images = Me.imglImporter
        Me.barView.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popViewNhatKyChungTu, Me.popViewNhatKyHeThong})
        Me.barView.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(4, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1000, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(4, 608)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 604)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1004, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 604)
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "save-as-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "close-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "copy-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "edit-32x32.png")
        Me.imglImporter.Images.SetKeyName(5, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(6, "open-32x32.png")
        Me.imglImporter.Images.SetKeyName(7, "preview-32x32.png")
        Me.imglImporter.Images.SetKeyName(8, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(9, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(10, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(11, "save-and-close-32x32.png")
        Me.imglImporter.Images.SetKeyName(12, "Add.bmp")
        Me.imglImporter.Images.SetKeyName(13, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(14, "Close.png")
        Me.imglImporter.Images.SetKeyName(15, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(16, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(17, "Add Button-32.png")
        Me.imglImporter.Images.SetKeyName(18, "Add-32(1).png")
        Me.imglImporter.Images.SetKeyName(19, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(20, "Book-Edit-32.png")
        Me.imglImporter.Images.SetKeyName(21, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(22, "BtnSaveDisabled.png")
        Me.imglImporter.Images.SetKeyName(23, "Close.png")
        Me.imglImporter.Images.SetKeyName(24, "Close-32.png")
        Me.imglImporter.Images.SetKeyName(25, "Close-box-red-32.png")
        Me.imglImporter.Images.SetKeyName(26, "delete-32.png")
        Me.imglImporter.Images.SetKeyName(27, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(28, "edtError.png")
        Me.imglImporter.Images.SetKeyName(29, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(30, "icon_save.bmp")
        Me.imglImporter.Images.SetKeyName(31, "pcCloseButton.png")
        Me.imglImporter.Images.SetKeyName(32, "Edit-32.png")
        Me.imglImporter.Images.SetKeyName(33, "Edit-128.png")
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(24, 33)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(41, 13)
        Me.labelControl6.TabIndex = 1
        Me.labelControl6.Text = "Ngày CT"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Loại CT"
        '
        'grpSMQR
        '
        Me.grpSMQR.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grpSMQR.Appearance.BorderColor = System.Drawing.Color.White
        Me.grpSMQR.Appearance.Options.UseBackColor = True
        Me.grpSMQR.Appearance.Options.UseBorderColor = True
        Me.grpSMQR.Controls.Add(Me.C_SoChungTu_RP)
        Me.grpSMQR.Controls.Add(Me.cFilterTaiKhoan)
        Me.grpSMQR.Controls.Add(Me.cFilter)
        Me.grpSMQR.Controls.Add(Me.txtTY_GIA1)
        Me.grpSMQR.Controls.Add(Me.txtMST_KHANG)
        Me.grpSMQR.Controls.Add(Me.LabelControl9)
        Me.grpSMQR.Controls.Add(Me.LabelControl2)
        Me.grpSMQR.Controls.Add(Me.labelControl19)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_GHI)
        Me.grpSMQR.Controls.Add(Me.labelControl10)
        Me.grpSMQR.Controls.Add(Me.txtDIEN_GIAI)
        Me.grpSMQR.Controls.Add(Me.txtNGUOI_NHAN_NOP_TIEN)
        Me.grpSMQR.Controls.Add(Me.txtDIA_CHI)
        Me.grpSMQR.Controls.Add(Me.txtTEN_KHANG)
        Me.grpSMQR.Controls.Add(Me.lblTaikhoan)
        Me.grpSMQR.Controls.Add(Me.cboNgoaiTe)
        Me.grpSMQR.Controls.Add(Me.grlLOAI_CT_ID)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_CT)
        Me.grpSMQR.Controls.Add(Me.labelControl16)
        Me.grpSMQR.Controls.Add(Me.labelControl11)
        Me.grpSMQR.Controls.Add(Me.labelControl12)
        Me.grpSMQR.Controls.Add(Me.labelControl20)
        Me.grpSMQR.Controls.Add(Me.LabelControl5)
        Me.grpSMQR.Controls.Add(Me.labelControl6)
        Me.grpSMQR.Controls.Add(Me.LabelControl1)
        Me.grpSMQR.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSMQR.Location = New System.Drawing.Point(0, 0)
        Me.grpSMQR.Name = "grpSMQR"
        Me.grpSMQR.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSMQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpSMQR.ShowCaption = False
        Me.grpSMQR.Size = New System.Drawing.Size(801, 136)
        Me.grpSMQR.TabIndex = 0
        Me.grpSMQR.Text = "Chi tiết...."
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(80, 83)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 3
        '
        'cFilterTaiKhoan
        '
        Me.cFilterTaiKhoan.AllowNull = True
        Me.cFilterTaiKhoan.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.cFilterTaiKhoan.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.cFilterTaiKhoan.C_DATA_SOURCE = Nothing
        Me.cFilterTaiKhoan.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.cFilterTaiKhoan.C_FORM_TITLE = "Chọn tài khoản"
        Me.cFilterTaiKhoan.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.cFilterTaiKhoan.C_IS_CHECK_OTHER = ""
        Me.cFilterTaiKhoan.C_IS_CHECK_STRING = ""
        Me.cFilterTaiKhoan.C_IS_FILTER_STRING = ""
        Me.cFilterTaiKhoan.C_IS_QUICKADD = False
        Me.cFilterTaiKhoan.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterTaiKhoan.C_KEY_NAME = "MaTaikhoan"
        Me.cFilterTaiKhoan.EditValue = ""
        Me.cFilterTaiKhoan.EditValues = ""
        Me.cFilterTaiKhoan.ENABLES = False
        Me.cFilterTaiKhoan.IsNotTextChanged = True
        Me.cFilterTaiKhoan.ListEditValue = CType(resources.GetObject("cFilterTaiKhoan.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterTaiKhoan.Location = New System.Drawing.Point(80, 109)
        Me.cFilterTaiKhoan.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterTaiKhoan.Name = "cFilterTaiKhoan"
        Me.cFilterTaiKhoan.NEXT_TAB = 0
        Me.cFilterTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilterTaiKhoan.Size = New System.Drawing.Size(139, 20)
        Me.cFilterTaiKhoan.TabIndex = 4
        Me.cFilterTaiKhoan.TabStop = False
        '
        'cFilter
        '
        Me.cFilter.AllowNull = True
        Me.cFilter.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MA_KHANG--0-0;MaSoThue--0-0;DiaChi" & _
            "--0-0"
        Me.cFilter.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.cFilter.C_DATA_SOURCE = Nothing
        Me.cFilter.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.cFilter.C_FORM_TITLE = "Chọn khách hàng"
        Me.cFilter.C_IS_CHECK_NUMBER = "="
        Me.cFilter.C_IS_CHECK_OTHER = "="
        Me.cFilter.C_IS_CHECK_STRING = ""
        Me.cFilter.C_IS_FILTER_STRING = ""
        Me.cFilter.C_IS_QUICKADD = True
        Me.cFilter.C_IS_SORT_ORDER_STRING = ""
        Me.cFilter.C_KEY_NAME = "KyHieu"
        Me.cFilter.EditValue = ""
        Me.cFilter.EditValues = ""
        Me.cFilter.ENABLES = False
        Me.cFilter.IsNotTextChanged = True
        Me.cFilter.ListEditValue = CType(resources.GetObject("cFilter.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilter.Location = New System.Drawing.Point(325, 4)
        Me.cFilter.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilter.Name = "cFilter"
        Me.cFilter.NEXT_TAB = 0
        Me.cFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilter.Size = New System.Drawing.Size(125, 20)
        Me.cFilter.TabIndex = 5
        Me.cFilter.TabStop = False
        '
        'txtTY_GIA1
        '
        Me.txtTY_GIA1.EnterMoveNextControl = True
        Me.txtTY_GIA1.Location = New System.Drawing.Point(714, 30)
        Me.txtTY_GIA1.Name = "txtTY_GIA1"
        Me.txtTY_GIA1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA1.Properties.Mask.EditMask = "n2"
        Me.txtTY_GIA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTY_GIA1.Size = New System.Drawing.Size(82, 20)
        Me.txtTY_GIA1.TabIndex = 12
        '
        'txtMST_KHANG
        '
        Me.txtMST_KHANG.EnterMoveNextControl = True
        Me.txtMST_KHANG.Location = New System.Drawing.Point(484, 4)
        Me.txtMST_KHANG.Name = "txtMST_KHANG"
        Me.txtMST_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMST_KHANG.Size = New System.Drawing.Size(130, 20)
        Me.txtMST_KHANG.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(456, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl9.TabIndex = 5006
        Me.LabelControl9.Text = "MST"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(234, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 5002
        Me.LabelControl2.Text = "Tên khách hàng"
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(37, 85)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(28, 13)
        Me.labelControl19.TabIndex = 5001
        Me.labelControl19.Text = "Số CT"
        '
        'daeNGAY_GHI
        '
        Me.daeNGAY_GHI.EditValue = Nothing
        Me.daeNGAY_GHI.EnterMoveNextControl = True
        Me.daeNGAY_GHI.Location = New System.Drawing.Point(80, 57)
        Me.daeNGAY_GHI.Name = "daeNGAY_GHI"
        Me.daeNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_GHI.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_GHI.Size = New System.Drawing.Size(100, 20)
        Me.daeNGAY_GHI.TabIndex = 2
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(24, 60)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 57
        Me.labelControl10.Text = "Ngày HT"
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(325, 109)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(289, 20)
        Me.txtDIEN_GIAI.TabIndex = 10
        '
        'txtNGUOI_NHAN_NOP_TIEN
        '
        Me.txtNGUOI_NHAN_NOP_TIEN.EnterMoveNextControl = True
        Me.txtNGUOI_NHAN_NOP_TIEN.Location = New System.Drawing.Point(325, 83)
        Me.txtNGUOI_NHAN_NOP_TIEN.Name = "txtNGUOI_NHAN_NOP_TIEN"
        Me.txtNGUOI_NHAN_NOP_TIEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNGUOI_NHAN_NOP_TIEN.Size = New System.Drawing.Size(289, 20)
        Me.txtNGUOI_NHAN_NOP_TIEN.TabIndex = 9
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(325, 56)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIA_CHI.Size = New System.Drawing.Size(289, 20)
        Me.txtDIA_CHI.TabIndex = 8
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(325, 30)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(289, 20)
        Me.txtTEN_KHANG.TabIndex = 7
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.Location = New System.Drawing.Point(4, 112)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(46, 13)
        Me.lblTaikhoan.TabIndex = 53
        Me.lblTaikhoan.Text = "Tài khoản"
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(714, 4)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.ImmediatePopup = True
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.Size = New System.Drawing.Size(80, 20)
        Me.cboNgoaiTe.TabIndex = 11
        '
        'grlLOAI_CT_ID
        '
        Me.grlLOAI_CT_ID.EditValue = " "
        Me.grlLOAI_CT_ID.EnterMoveNextControl = True
        Me.grlLOAI_CT_ID.Location = New System.Drawing.Point(80, 4)
        Me.grlLOAI_CT_ID.Name = "grlLOAI_CT_ID"
        Me.grlLOAI_CT_ID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlLOAI_CT_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLOAI_CT_ID.Properties.NullText = ""
        Me.grlLOAI_CT_ID.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.grlLOAI_CT_ID.Properties.ReadOnly = True
        Me.grlLOAI_CT_ID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.grlLOAI_CT_ID.Properties.View = Me.GridLookUpEdit1View
        Me.grlLOAI_CT_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlLOAI_CT_ID.Size = New System.Drawing.Size(100, 20)
        Me.grlLOAI_CT_ID.TabIndex = 0
        Me.grlLOAI_CT_ID.TabStop = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ký hiệu"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên loại chứng từ"
        Me.GridColumn2.FieldName = "TenLoaiCt"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'daeNGAY_CT
        '
        Me.daeNGAY_CT.EditValue = Nothing
        Me.daeNGAY_CT.EnterMoveNextControl = True
        Me.daeNGAY_CT.Location = New System.Drawing.Point(80, 30)
        Me.daeNGAY_CT.Name = "daeNGAY_CT"
        Me.daeNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_CT.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_CT.Size = New System.Drawing.Size(100, 20)
        Me.daeNGAY_CT.TabIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Ký hiệu"
        Me.GridColumn10.FieldName = "KyHieu"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tên khách hàng"
        Me.GridColumn11.FieldName = "TenKhang"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Mã tài khoản"
        Me.GridColumn16.FieldName = "MaTaikhoan"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Tên tài khoản"
        Me.GridColumn17.FieldName = "TenTaikhoan"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Ký hiệu"
        Me.GridColumn12.FieldName = "KyHieu"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tên khách hàng"
        Me.GridColumn13.FieldName = "TenKhang"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên khách hàng"
        Me.GridColumn5.FieldName = "TenKhang"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 136)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(801, 21)
        Me.PanelControl1.TabIndex = 106
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(455, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl3.TabIndex = 104
        Me.LabelControl3.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grcCT_Thue)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpSMQR)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 574)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GRC_CTH)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(194, 574)
        Me.GroupControl2.TabIndex = 23
        '
        'grcCT_Thue
        '
        Me.grcCT_Thue.Controls.Add(Me.cFilterTaiKhoanThue)
        Me.grcCT_Thue.Controls.Add(Me.btnCopy)
        Me.grcCT_Thue.Controls.Add(Me.UR_Status)
        Me.grcCT_Thue.Controls.Add(Me.chkHDGTGT)
        Me.grcCT_Thue.Controls.Add(Me.txtTongTien)
        Me.grcCT_Thue.Controls.Add(Me.lblTongTien)
        Me.grcCT_Thue.Controls.Add(Me.btnHoaDon)
        Me.grcCT_Thue.Controls.Add(Me.txtTongTienThue)
        Me.grcCT_Thue.Controls.Add(Me.lblTongTienThue)
        Me.grcCT_Thue.Controls.Add(Me.txtTongSoTien)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl4)
        Me.grcCT_Thue.Controls.Add(Me.grlTaiKhoanThue)
        Me.grcCT_Thue.Controls.Add(Me.lblTkThue)
        Me.grcCT_Thue.Controls.Add(Me.btnThue)
        Me.grcCT_Thue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grcCT_Thue.Location = New System.Drawing.Point(0, 507)
        Me.grcCT_Thue.Name = "grcCT_Thue"
        Me.grcCT_Thue.ShowCaption = False
        Me.grcCT_Thue.Size = New System.Drawing.Size(801, 67)
        Me.grcCT_Thue.TabIndex = 2
        Me.grcCT_Thue.Text = "Chi tiết...."
        '
        'cFilterTaiKhoanThue
        '
        Me.cFilterTaiKhoanThue.AllowNull = True
        Me.cFilterTaiKhoanThue.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.cFilterTaiKhoanThue.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.cFilterTaiKhoanThue.C_DATA_SOURCE = Nothing
        Me.cFilterTaiKhoanThue.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.cFilterTaiKhoanThue.C_FORM_TITLE = "Chọn tài khoản"
        Me.cFilterTaiKhoanThue.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.cFilterTaiKhoanThue.C_IS_CHECK_OTHER = ""
        Me.cFilterTaiKhoanThue.C_IS_CHECK_STRING = ""
        Me.cFilterTaiKhoanThue.C_IS_FILTER_STRING = ""
        Me.cFilterTaiKhoanThue.C_IS_QUICKADD = False
        Me.cFilterTaiKhoanThue.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterTaiKhoanThue.C_KEY_NAME = "MaTaikhoan"
        Me.cFilterTaiKhoanThue.EditValue = ""
        Me.cFilterTaiKhoanThue.EditValues = ""
        Me.cFilterTaiKhoanThue.ENABLES = False
        Me.cFilterTaiKhoanThue.IsNotTextChanged = True
        Me.cFilterTaiKhoanThue.ListEditValue = CType(resources.GetObject("cFilterTaiKhoanThue.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterTaiKhoanThue.Location = New System.Drawing.Point(80, 5)
        Me.cFilterTaiKhoanThue.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterTaiKhoanThue.Name = "cFilterTaiKhoanThue"
        Me.cFilterTaiKhoanThue.NEXT_TAB = 0
        Me.cFilterTaiKhoanThue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilterTaiKhoanThue.Size = New System.Drawing.Size(125, 20)
        Me.cFilterTaiKhoanThue.TabIndex = 0
        Me.cFilterTaiKhoanThue.TabStop = False
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.Location = New System.Drawing.Point(643, 31)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(80, 30)
        Me.btnCopy.TabIndex = 68
        Me.btnCopy.Text = "Copy"
        '
        'UR_Status
        '
        Me.UR_Status.CheckStatus = True
        Me.UR_Status.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_Status.Location = New System.Drawing.Point(20, 31)
        Me.UR_Status.Name = "UR_Status"
        Me.UR_Status.Size = New System.Drawing.Size(290, 20)
        Me.UR_Status.TabIndex = 2
        ValueInfo1.Den_Ngay = Nothing
        ValueInfo1.ID_DM = Nothing
        ValueInfo1.Ky_Hieu = Nothing
        ValueInfo1.MA_DM = Nothing
        ValueInfo1.ParameterValue = Nothing
        ValueInfo1.Ten = Nothing
        ValueInfo1.Tu_Ngay = Nothing
        Me.UR_Status.Value_info = ValueInfo1
        '
        'chkHDGTGT
        '
        Me.chkHDGTGT.Location = New System.Drawing.Point(494, 32)
        Me.chkHDGTGT.Name = "chkHDGTGT"
        Me.chkHDGTGT.Properties.Caption = "HĐ GTGT"
        Me.chkHDGTGT.Size = New System.Drawing.Size(69, 19)
        Me.chkHDGTGT.TabIndex = 0
        Me.chkHDGTGT.Visible = False
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(696, 5)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Properties.AllowFocused = False
        Me.txtTongTien.Properties.Mask.EditMask = "n0"
        Me.txtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTien.Properties.ReadOnly = True
        Me.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongTien.ShowToolTips = False
        Me.txtTongTien.Size = New System.Drawing.Size(100, 20)
        Me.txtTongTien.TabIndex = 67
        Me.txtTongTien.TabStop = False
        '
        'lblTongTien
        '
        Me.lblTongTien.Location = New System.Drawing.Point(643, 8)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(39, 13)
        Me.lblTongTien.TabIndex = 66
        Me.lblTongTien.Text = "Tổng TT"
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Location = New System.Drawing.Point(570, 31)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(44, 20)
        Me.btnHoaDon.TabIndex = 1
        Me.btnHoaDon.Text = "Số HĐ"
        Me.btnHoaDon.Visible = False
        '
        'txtTongTienThue
        '
        Me.txtTongTienThue.Location = New System.Drawing.Point(325, 5)
        Me.txtTongTienThue.Name = "txtTongTienThue"
        Me.txtTongTienThue.Properties.AllowFocused = False
        Me.txtTongTienThue.Properties.Mask.EditMask = "n0"
        Me.txtTongTienThue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTienThue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTienThue.Properties.ReadOnly = True
        Me.txtTongTienThue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongTienThue.ShowToolTips = False
        Me.txtTongTienThue.Size = New System.Drawing.Size(100, 20)
        Me.txtTongTienThue.TabIndex = 64
        Me.txtTongTienThue.TabStop = False
        '
        'lblTongTienThue
        '
        Me.lblTongTienThue.Location = New System.Drawing.Point(266, 8)
        Me.lblTongTienThue.Name = "lblTongTienThue"
        Me.lblTongTienThue.Size = New System.Drawing.Size(45, 13)
        Me.lblTongTienThue.TabIndex = 63
        Me.lblTongTienThue.Text = "Tiền thuế"
        '
        'txtTongSoTien
        '
        Me.txtTongSoTien.Location = New System.Drawing.Point(514, 5)
        Me.txtTongSoTien.Name = "txtTongSoTien"
        Me.txtTongSoTien.Properties.AllowFocused = False
        Me.txtTongSoTien.Properties.Mask.EditMask = "n0"
        Me.txtTongSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongSoTien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongSoTien.Properties.ReadOnly = True
        Me.txtTongSoTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongSoTien.ShowToolTips = False
        Me.txtTongSoTien.Size = New System.Drawing.Size(100, 20)
        Me.txtTongSoTien.TabIndex = 59
        Me.txtTongSoTien.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(453, 8)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "Tiền hàng"
        '
        'grlTaiKhoanThue
        '
        Me.grlTaiKhoanThue.EnterMoveNextControl = True
        Me.grlTaiKhoanThue.Location = New System.Drawing.Point(729, 34)
        Me.grlTaiKhoanThue.Name = "grlTaiKhoanThue"
        Me.grlTaiKhoanThue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlTaiKhoanThue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlTaiKhoanThue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanThue.Properties.NullText = ""
        Me.grlTaiKhoanThue.Properties.View = Me.GridView8
        Me.grlTaiKhoanThue.Size = New System.Drawing.Size(69, 20)
        Me.grlTaiKhoanThue.TabIndex = 9
        Me.grlTaiKhoanThue.TabStop = False
        Me.grlTaiKhoanThue.Visible = False
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn14})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mã tài khoản"
        Me.GridColumn9.FieldName = "MaTaikhoan"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tên tài khoản"
        Me.GridColumn14.FieldName = "TenTaikhoan"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        '
        'lblTkThue
        '
        Me.lblTkThue.Location = New System.Drawing.Point(37, 8)
        Me.lblTkThue.Name = "lblTkThue"
        Me.lblTkThue.Size = New System.Drawing.Size(37, 13)
        Me.lblTkThue.TabIndex = 55
        Me.lblTkThue.Text = "TK thuế"
        '
        'btnThue
        '
        Me.btnThue.ImageIndex = 4
        Me.btnThue.Location = New System.Drawing.Point(345, 31)
        Me.btnThue.Name = "btnThue"
        Me.btnThue.Size = New System.Drawing.Size(80, 30)
        Me.btnThue.TabIndex = 1
        Me.btnThue.Text = "Chi tiết thuế"
        '
        'frmCT_H_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmCT_H_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu kế toán"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_CO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_KY_HIEU_KHANG_CO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_HOADON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPPQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlKhachHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTienNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlKhachHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTkNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDM_KHANG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GRC_CTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRV_CTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMQR.ResumeLayout(False)
        Me.grpSMQR.PerformLayout()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcCT_Thue.ResumeLayout(False)
        Me.grcCT_Thue.PerformLayout()
        CType(Me.chkHDGTGT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTienThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSoTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents labelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSMQR As DevExpress.XtraEditors.GroupControl
    Friend WithEvents daeNGAY_CT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grlKhachHangNo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNoiDung As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grlTaiKhoanCo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSoTien As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtSoTienNT As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grlHopDong As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlVuViec As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlKhachHangCo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlTaiKhoanNo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTenTkNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    'Friend WithEvents cboTaiKhoanNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TEN_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents cboTaiKhoanCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboHopDong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grlLOAI_CT_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPPQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SO_TIEN_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPhongBan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblTaikhoan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNGUOI_NHAN_NOP_TIEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents daeNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKhoanPhi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KY_HIEU_KHANG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDM_KHANG As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMST_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTY_GIA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents navWelding1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GRC_CTH As DevExpress.XtraGrid.GridControl
    Friend WithEvents GRV_CTH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grcCT_Thue As DevExpress.XtraEditors.GroupControl
    Friend WithEvents UR_Status As Status_LoaiCT
    Friend WithEvents chkHDGTGT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTongTien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTongTien As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnHoaDon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTongTienThue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTongTienThue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongSoTien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grlTaiKhoanThue As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTkThue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThue As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CustomFilter1 As Vns.Erp.Core.CustomFilter
    Friend WithEvents cFilter As Vns.Erp.Core.CustomFilter
    Friend WithEvents MyRepositoryItem_MA_TK_NO As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents MyRepositoryItem_MA_TK_CO As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents popView As DevExpress.XtraBars.PopupMenu
    Friend WithEvents barView As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popViewNhatKyChungTu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popViewNhatKyHeThong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents CustomViewLog1 As Vns.Erp.Core.CustomViewLog
    Friend WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cFilterTaiKhoanThue As Vns.Erp.Core.CustomFilter
    Friend WithEvents ID_DM_HOPDONG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MyRepositoryItem_KY_HIEU_KHANG_CO As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents TEN_KHANG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_HOADON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MyRepositoryItem_MA_HOADON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SoChungTu_RP As C_SoChungTu
    Friend WithEvents cFilterTaiKhoan As Vns.Erp.Core.CustomFilter
    Friend WithEvents MaTkNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenTkNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaTkCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenTkCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieuKhangCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenKhangCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienNte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaHoadon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPtqtCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoiDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmVuviecCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmKhoanphiCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPhongbanCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo1Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo2Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo3Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo4Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo5Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmHopdongCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CtSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TyGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ghi As DevExpress.XtraGrid.Columns.GridColumn
End Class

Namespace KTY

End Namespace