<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuKeToanKhac2_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuKeToanKhac2_ChiTiet))
        Dim ValueInfo1 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCan = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pfeTaiKhoan = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TEN_TK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pfeKhang = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PS_NO_NT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PS_CO_NT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PS_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.NOI_DUNG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ID_DM_PTQT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPTQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MA_VUVIEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_PHONGBAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPhongBan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_KHOANPHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoanPhi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTuDo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTuDo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTuDo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTuDo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTuDo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MA_HOADON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_HOADON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.NHOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
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
        Me.cboTaiKhoan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTaiKhoanCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhachHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhachHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ffhfh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKHCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.grcCT_Thue = New DevExpress.XtraEditors.GroupControl()
        Me.btnCopy = New DevExpress.XtraEditors.SimpleButton()
        Me.UC_Status = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
        Me.btnThue = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTongPSco = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTongPSno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.pncbtn = New DevExpress.XtraEditors.PanelControl()
        Me.navWelding1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.GRC_CTH = New DevExpress.XtraGrid.GridControl()
        Me.GRV_CTH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TY_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnPrinter = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.grpSMQR = New DevExpress.XtraEditors.GroupControl()
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.chkNgoaiTe = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTY_GIA1 = New DevExpress.XtraEditors.TextEdit()
        Me.daeNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.daeNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfeTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfeKhang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTuDo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTuDo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTuDo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTuDo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTuDo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_HOADON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cboTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaiKhoanCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ffhfh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcCT_Thue.SuspendLayout()
        CType(Me.txtTongPSco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongPSno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pncbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pncbtn.SuspendLayout()
        CType(Me.GRC_CTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRV_CTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMQR.SuspendLayout()
        CType(Me.chkNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSea.ImageIndex = 0
        Me.btnSea.Location = New System.Drawing.Point(544, 0)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(80, 30)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(286, 0)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(200, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Thêm"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(372, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Xóa"
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCan.ImageIndex = 8
        Me.btnCan.Location = New System.Drawing.Point(630, 0)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(80, 30)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "Hủy"
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.CausesValidation = False
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 75)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(801, 469)
        Me.GroupControl1.TabIndex = 5008
        Me.GroupControl1.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(0, 0)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grlKhachHangNo, Me.txtNoiDung, Me.grlTaiKhoanCo, Me.txtSoTien, Me.txtSoTienNT, Me.grlHopDong, Me.grlVuViec, Me.grlKhachHangCo, Me.grlTaiKhoanNo, Me.txtTenTkNo, Me.cboTaiKhoan, Me.cboTaiKhoanCo, Me.cboHopDong, Me.cboVuViec, Me.cboKhachHangNo, Me.cboKhachHangCo, Me.cboPTQT, Me.cboKHangNo, Me.cboKHangCo, Me.ffhfh, Me.cboKH, Me.cboKHCo, Me.cboPhongBan, Me.cboKhoanPhi, Me.cboTuDo1, Me.cboTuDo2, Me.cboTuDo3, Me.cboTuDo4, Me.cboTuDo5, Me.pfeTaiKhoan, Me.pfeKhang, Me.MyRepositoryItem_MA_HOADON, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me._GridControl.Size = New System.Drawing.Size(801, 469)
        Me._GridControl.TabIndex = 1
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
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TK, Me.TEN_TK, Me.KY_HIEU_KHANG, Me.TEN_KHANG, Me.PS_NO_NT, Me.PS_NO, Me.PS_CO_NT, Me.PS_CO, Me.NOI_DUNG, Me.ID_DM_PTQT, Me.MA_VUVIEC, Me.ID_DM_PHONGBAN, Me.ID_DM_KHOANPHI, Me.ID_DM_TUDO_1, Me.ID_DM_TUDO_2, Me.ID_DM_TUDO_3, Me.ID_DM_TUDO_4, Me.ID_DM_TUDO_5, Me.MA_HOADON, Me.NHOM})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsDetail.EnableMasterViewMode = False
        Me._GridView.OptionsDetail.ShowDetailTabs = False
        Me._GridView.OptionsNavigation.AutoFocusNewRow = True
        Me._GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.EnableAppearanceEvenRow = True
        Me._GridView.OptionsView.EnableAppearanceOddRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'MA_TK
        '
        Me.MA_TK.Caption = "Tài khoản"
        Me.MA_TK.ColumnEdit = Me.pfeTaiKhoan
        Me.MA_TK.FieldName = "MA_TK"
        Me.MA_TK.Name = "MA_TK"
        Me.MA_TK.Visible = True
        Me.MA_TK.VisibleIndex = 0
        '
        'pfeTaiKhoan
        '
        Me.pfeTaiKhoan.AutoHeight = False
        Me.pfeTaiKhoan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.pfeTaiKhoan.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.pfeTaiKhoan.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.pfeTaiKhoan.C_DATA_SOURCE = Nothing
        Me.pfeTaiKhoan.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.pfeTaiKhoan.C_FORM_TITLE = "Chọn tài khoản"
        Me.pfeTaiKhoan.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.pfeTaiKhoan.C_IS_CHECK_OTHER = "="
        Me.pfeTaiKhoan.C_IS_CHECK_STRING = "="
        Me.pfeTaiKhoan.C_IS_CHI_TIET = ""
        Me.pfeTaiKhoan.C_IS_FILTER_STRING = ""
        Me.pfeTaiKhoan.C_IS_QUICKADD = False
        Me.pfeTaiKhoan.C_IS_SORT_ORDER_STRING = ""
        Me.pfeTaiKhoan.C_KEY_NAME = "MaTaikhoan"
        Me.pfeTaiKhoan.Editors = Nothing
        Me.pfeTaiKhoan.EditValues = ""
        Me.pfeTaiKhoan.ListEditValues = Nothing
        Me.pfeTaiKhoan.Name = "pfeTaiKhoan"
        Me.pfeTaiKhoan.NEXT_TAB = 0
        Me.pfeTaiKhoan.OBJ_CONDITITION = Nothing
        '
        'TEN_TK
        '
        Me.TEN_TK.Caption = "Tên tài khoản"
        Me.TEN_TK.FieldName = "TEN_TK"
        Me.TEN_TK.Name = "TEN_TK"
        Me.TEN_TK.OptionsColumn.AllowEdit = False
        Me.TEN_TK.OptionsColumn.ReadOnly = True
        Me.TEN_TK.Visible = True
        Me.TEN_TK.VisibleIndex = 1
        Me.TEN_TK.Width = 232
        '
        'KY_HIEU_KHANG
        '
        Me.KY_HIEU_KHANG.Caption = "Mã khách hàng"
        Me.KY_HIEU_KHANG.ColumnEdit = Me.pfeKhang
        Me.KY_HIEU_KHANG.FieldName = "KY_HIEU_KHANG"
        Me.KY_HIEU_KHANG.Name = "KY_HIEU_KHANG"
        Me.KY_HIEU_KHANG.Visible = True
        Me.KY_HIEU_KHANG.VisibleIndex = 2
        Me.KY_HIEU_KHANG.Width = 120
        '
        'pfeKhang
        '
        Me.pfeKhang.AutoHeight = False
        Me.pfeKhang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.pfeKhang.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MaKhang--0-0;MaSoThue--0-0;DiaChi-" & _
            "-0-0"
        Me.pfeKhang.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.pfeKhang.C_DATA_SOURCE = Nothing
        Me.pfeKhang.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.pfeKhang.C_FORM_TITLE = "Chọn khách hàng"
        Me.pfeKhang.C_IS_CHECK_NUMBER = "="
        Me.pfeKhang.C_IS_CHECK_OTHER = "="
        Me.pfeKhang.C_IS_CHECK_STRING = "="
        Me.pfeKhang.C_IS_CHI_TIET = ""
        Me.pfeKhang.C_IS_FILTER_STRING = ""
        Me.pfeKhang.C_IS_QUICKADD = True
        Me.pfeKhang.C_IS_SORT_ORDER_STRING = ""
        Me.pfeKhang.C_KEY_NAME = "KyHieu"
        Me.pfeKhang.Editors = Nothing
        Me.pfeKhang.EditValues = ""
        Me.pfeKhang.ListEditValues = CType(resources.GetObject("pfeKhang.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.pfeKhang.Name = "pfeKhang"
        Me.pfeKhang.NEXT_TAB = 0
        Me.pfeKhang.OBJ_CONDITITION = Nothing
        '
        'TEN_KHANG
        '
        Me.TEN_KHANG.Caption = "Tên KH"
        Me.TEN_KHANG.FieldName = "TEN_KHANG"
        Me.TEN_KHANG.Name = "TEN_KHANG"
        Me.TEN_KHANG.OptionsColumn.ReadOnly = True
        Me.TEN_KHANG.Visible = True
        Me.TEN_KHANG.VisibleIndex = 3
        Me.TEN_KHANG.Width = 254
        '
        'PS_NO_NT
        '
        Me.PS_NO_NT.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_NO_NT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PS_NO_NT.Caption = "PS nợ ngoại tệ"
        Me.PS_NO_NT.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.PS_NO_NT.FieldName = "PS_NO_NT"
        Me.PS_NO_NT.Name = "PS_NO_NT"
        Me.PS_NO_NT.Visible = True
        Me.PS_NO_NT.VisibleIndex = 4
        Me.PS_NO_NT.Width = 100
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PS_NO
        '
        Me.PS_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PS_NO.Caption = "PS nợ"
        Me.PS_NO.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.PS_NO.FieldName = "PS_NO"
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.Visible = True
        Me.PS_NO.VisibleIndex = 5
        Me.PS_NO.Width = 100
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'PS_CO_NT
        '
        Me.PS_CO_NT.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_CO_NT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PS_CO_NT.Caption = "PS có ngoại tệ"
        Me.PS_CO_NT.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.PS_CO_NT.FieldName = "PS_CO_NT"
        Me.PS_CO_NT.Name = "PS_CO_NT"
        Me.PS_CO_NT.Visible = True
        Me.PS_CO_NT.VisibleIndex = 6
        Me.PS_CO_NT.Width = 100
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'PS_CO
        '
        Me.PS_CO.AppearanceHeader.Options.UseTextOptions = True
        Me.PS_CO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PS_CO.Caption = "PS có"
        Me.PS_CO.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.PS_CO.FieldName = "PS_CO"
        Me.PS_CO.Name = "PS_CO"
        Me.PS_CO.Visible = True
        Me.PS_CO.VisibleIndex = 7
        Me.PS_CO.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'NOI_DUNG
        '
        Me.NOI_DUNG.Caption = "Diễn giải"
        Me.NOI_DUNG.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.NOI_DUNG.FieldName = "NOI_DUNG"
        Me.NOI_DUNG.Name = "NOI_DUNG"
        Me.NOI_DUNG.Visible = True
        Me.NOI_DUNG.VisibleIndex = 8
        Me.NOI_DUNG.Width = 298
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.MaxLength = 256
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'ID_DM_PTQT
        '
        Me.ID_DM_PTQT.Caption = "Loại dòng tiền"
        Me.ID_DM_PTQT.ColumnEdit = Me.cboPTQT
        Me.ID_DM_PTQT.FieldName = "ID_DM_PTQT"
        Me.ID_DM_PTQT.Name = "ID_DM_PTQT"
        Me.ID_DM_PTQT.Visible = True
        Me.ID_DM_PTQT.VisibleIndex = 9
        Me.ID_DM_PTQT.Width = 120
        '
        'cboPTQT
        '
        Me.cboPTQT.AutoHeight = False
        Me.cboPTQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPTQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQT.Name = "cboPTQT"
        Me.cboPTQT.NullText = ""
        '
        'MA_VUVIEC
        '
        Me.MA_VUVIEC.Caption = "Vụ việc"
        Me.MA_VUVIEC.ColumnEdit = Me.cboVuViec
        Me.MA_VUVIEC.FieldName = "ID_DM_VUVIEC"
        Me.MA_VUVIEC.Name = "MA_VUVIEC"
        Me.MA_VUVIEC.Visible = True
        Me.MA_VUVIEC.VisibleIndex = 10
        Me.MA_VUVIEC.Width = 80
        '
        'cboVuViec
        '
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'ID_DM_PHONGBAN
        '
        Me.ID_DM_PHONGBAN.Caption = "Phòng ban"
        Me.ID_DM_PHONGBAN.ColumnEdit = Me.cboPhongBan
        Me.ID_DM_PHONGBAN.FieldName = "ID_DM_PHONGBAN"
        Me.ID_DM_PHONGBAN.Name = "ID_DM_PHONGBAN"
        Me.ID_DM_PHONGBAN.Visible = True
        Me.ID_DM_PHONGBAN.VisibleIndex = 11
        Me.ID_DM_PHONGBAN.Width = 120
        '
        'cboPhongBan
        '
        Me.cboPhongBan.AutoHeight = False
        Me.cboPhongBan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongBan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.NullText = ""
        '
        'ID_DM_KHOANPHI
        '
        Me.ID_DM_KHOANPHI.Caption = "Khoản phí"
        Me.ID_DM_KHOANPHI.ColumnEdit = Me.cboKhoanPhi
        Me.ID_DM_KHOANPHI.FieldName = "ID_DM_KHOANPHI"
        Me.ID_DM_KHOANPHI.Name = "ID_DM_KHOANPHI"
        Me.ID_DM_KHOANPHI.Visible = True
        Me.ID_DM_KHOANPHI.VisibleIndex = 12
        Me.ID_DM_KHOANPHI.Width = 100
        '
        'cboKhoanPhi
        '
        Me.cboKhoanPhi.AutoHeight = False
        Me.cboKhoanPhi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanPhi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanPhi.Name = "cboKhoanPhi"
        Me.cboKhoanPhi.NullText = ""
        '
        'ID_DM_TUDO_1
        '
        Me.ID_DM_TUDO_1.Caption = "Danh mục tự do 1"
        Me.ID_DM_TUDO_1.ColumnEdit = Me.cboTuDo1
        Me.ID_DM_TUDO_1.FieldName = "ID_DM_TUDO_1"
        Me.ID_DM_TUDO_1.Name = "ID_DM_TUDO_1"
        Me.ID_DM_TUDO_1.Visible = True
        Me.ID_DM_TUDO_1.VisibleIndex = 13
        Me.ID_DM_TUDO_1.Width = 130
        '
        'cboTuDo1
        '
        Me.cboTuDo1.AutoHeight = False
        Me.cboTuDo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTuDo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTuDo1.Name = "cboTuDo1"
        Me.cboTuDo1.NullText = ""
        '
        'ID_DM_TUDO_2
        '
        Me.ID_DM_TUDO_2.Caption = "Danh mục tự do 2"
        Me.ID_DM_TUDO_2.ColumnEdit = Me.cboTuDo2
        Me.ID_DM_TUDO_2.FieldName = "ID_DM_TUDO_2"
        Me.ID_DM_TUDO_2.Name = "ID_DM_TUDO_2"
        Me.ID_DM_TUDO_2.Visible = True
        Me.ID_DM_TUDO_2.VisibleIndex = 14
        Me.ID_DM_TUDO_2.Width = 130
        '
        'cboTuDo2
        '
        Me.cboTuDo2.AutoHeight = False
        Me.cboTuDo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTuDo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTuDo2.Name = "cboTuDo2"
        Me.cboTuDo2.NullText = ""
        '
        'ID_DM_TUDO_3
        '
        Me.ID_DM_TUDO_3.Caption = "Danh mục tự do 3"
        Me.ID_DM_TUDO_3.ColumnEdit = Me.cboTuDo3
        Me.ID_DM_TUDO_3.FieldName = "ID_DM_TUDO_3"
        Me.ID_DM_TUDO_3.Name = "ID_DM_TUDO_3"
        Me.ID_DM_TUDO_3.Visible = True
        Me.ID_DM_TUDO_3.VisibleIndex = 15
        Me.ID_DM_TUDO_3.Width = 130
        '
        'cboTuDo3
        '
        Me.cboTuDo3.AutoHeight = False
        Me.cboTuDo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTuDo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTuDo3.Name = "cboTuDo3"
        Me.cboTuDo3.NullText = ""
        '
        'ID_DM_TUDO_4
        '
        Me.ID_DM_TUDO_4.Caption = "Danh mục tự do 4"
        Me.ID_DM_TUDO_4.ColumnEdit = Me.cboTuDo4
        Me.ID_DM_TUDO_4.FieldName = "ID_DM_TUDO_4"
        Me.ID_DM_TUDO_4.Name = "ID_DM_TUDO_4"
        Me.ID_DM_TUDO_4.Visible = True
        Me.ID_DM_TUDO_4.VisibleIndex = 16
        Me.ID_DM_TUDO_4.Width = 130
        '
        'cboTuDo4
        '
        Me.cboTuDo4.AutoHeight = False
        Me.cboTuDo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTuDo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTuDo4.Name = "cboTuDo4"
        Me.cboTuDo4.NullText = ""
        '
        'ID_DM_TUDO_5
        '
        Me.ID_DM_TUDO_5.Caption = "Danh mục tự do 5"
        Me.ID_DM_TUDO_5.ColumnEdit = Me.cboTuDo5
        Me.ID_DM_TUDO_5.FieldName = "ID_DM_TUDO_5"
        Me.ID_DM_TUDO_5.Name = "ID_DM_TUDO_5"
        Me.ID_DM_TUDO_5.Visible = True
        Me.ID_DM_TUDO_5.VisibleIndex = 17
        Me.ID_DM_TUDO_5.Width = 130
        '
        'cboTuDo5
        '
        Me.cboTuDo5.AutoHeight = False
        Me.cboTuDo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTuDo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTuDo5.Name = "cboTuDo5"
        Me.cboTuDo5.NullText = ""
        '
        'MA_HOADON
        '
        Me.MA_HOADON.Caption = "CT Hóa đơn"
        Me.MA_HOADON.ColumnEdit = Me.MyRepositoryItem_MA_HOADON
        Me.MA_HOADON.FieldName = "MA_HOADON"
        Me.MA_HOADON.Name = "MA_HOADON"
        Me.MA_HOADON.Width = 100
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
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_NUMBER = ""
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_OTHER = ""
        Me.MyRepositoryItem_MA_HOADON.C_IS_CHECK_STRING = ""
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
        'NHOM
        '
        Me.NHOM.AppearanceHeader.Options.UseTextOptions = True
        Me.NHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NHOM.Caption = "Nhóm"
        Me.NHOM.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.NHOM.FieldName = "NHOM"
        Me.NHOM.Name = "NHOM"
        Me.NHOM.Visible = True
        Me.NHOM.VisibleIndex = 18
        Me.NHOM.Width = 50
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "[0-9]{0,4}"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
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
        Me.grlTaiKhoanCo.DisplayMember = "KY_HIEU"
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
        'cboTaiKhoan
        '
        Me.cboTaiKhoan.AutoHeight = False
        Me.cboTaiKhoan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaiKhoan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaiKhoan.Name = "cboTaiKhoan"
        Me.cboTaiKhoan.NullText = ""
        '
        'cboTaiKhoanCo
        '
        Me.cboTaiKhoanCo.AutoHeight = False
        Me.cboTaiKhoanCo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaiKhoanCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaiKhoanCo.Name = "cboTaiKhoanCo"
        Me.cboTaiKhoanCo.NullText = ""
        '
        'cboHopDong
        '
        Me.cboHopDong.AutoHeight = False
        Me.cboHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopDong.Name = "cboHopDong"
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
        'cboKHangNo
        '
        Me.cboKHangNo.AutoHeight = False
        Me.cboKHangNo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKHangNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHangNo.Name = "cboKHangNo"
        Me.cboKHangNo.NullText = ""
        '
        'cboKHangCo
        '
        Me.cboKHangCo.AutoHeight = False
        Me.cboKHangCo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKHangCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHangCo.Name = "cboKHangCo"
        Me.cboKHangCo.NullText = ""
        '
        'ffhfh
        '
        Me.ffhfh.AutoHeight = False
        Me.ffhfh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ffhfh.Name = "ffhfh"
        '
        'cboKH
        '
        Me.cboKH.AutoHeight = False
        Me.cboKH.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKH.Name = "cboKH"
        Me.cboKH.NullText = ""
        '
        'cboKHCo
        '
        Me.cboKHCo.AutoHeight = False
        Me.cboKHCo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKHCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHCo.Name = "cboKHCo"
        Me.cboKHCo.NullText = ""
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(4, 7)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 5
        Me.labelControl10.Text = "Ngày HT"
        '
        'grcCT_Thue
        '
        Me.grcCT_Thue.Controls.Add(Me.btnCopy)
        Me.grcCT_Thue.Controls.Add(Me.UC_Status)
        Me.grcCT_Thue.Controls.Add(Me.btnThue)
        Me.grcCT_Thue.Controls.Add(Me.txtTongPSco)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl2)
        Me.grcCT_Thue.Controls.Add(Me.txtTongPSno)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl4)
        Me.grcCT_Thue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grcCT_Thue.Location = New System.Drawing.Point(0, 544)
        Me.grcCT_Thue.Name = "grcCT_Thue"
        Me.grcCT_Thue.ShowCaption = False
        Me.grcCT_Thue.Size = New System.Drawing.Size(801, 30)
        Me.grcCT_Thue.TabIndex = 5009
        Me.grcCT_Thue.Text = "Chi tiết...."
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.Location = New System.Drawing.Point(627, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(80, 30)
        Me.btnCopy.TabIndex = 70
        Me.btnCopy.Text = "Copy"
        '
        'UC_Status
        '
        Me.UC_Status.CheckStatus = True
        Me.UC_Status.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UC_Status.Location = New System.Drawing.Point(5, 5)
        Me.UC_Status.Name = "UC_Status"
        Me.UC_Status.Size = New System.Drawing.Size(214, 20)
        Me.UC_Status.TabIndex = 69
        ValueInfo1.Den_Ngay = Nothing
        ValueInfo1.ID_DM = Nothing
        ValueInfo1.Ky_Hieu = Nothing
        ValueInfo1.MA_DM = Nothing
        ValueInfo1.ParameterValue = Nothing
        ValueInfo1.Ten = Nothing
        ValueInfo1.Tu_Ngay = Nothing
        Me.UC_Status.Value_info = ValueInfo1
        '
        'btnThue
        '
        Me.btnThue.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnThue.ImageIndex = 8
        Me.btnThue.Location = New System.Drawing.Point(712, 2)
        Me.btnThue.Name = "btnThue"
        Me.btnThue.Size = New System.Drawing.Size(87, 26)
        Me.btnThue.TabIndex = 68
        Me.btnThue.Text = "Chi tiết thuế"
        '
        'txtTongPSco
        '
        Me.txtTongPSco.Location = New System.Drawing.Point(475, 5)
        Me.txtTongPSco.Name = "txtTongPSco"
        Me.txtTongPSco.Properties.AllowFocused = False
        Me.txtTongPSco.Properties.Mask.EditMask = "n0"
        Me.txtTongPSco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongPSco.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongPSco.Properties.ReadOnly = True
        Me.txtTongPSco.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongPSco.Size = New System.Drawing.Size(100, 20)
        Me.txtTongPSco.TabIndex = 67
        Me.txtTongPSco.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(416, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 66
        Me.LabelControl2.Text = "Tổng PS có"
        '
        'txtTongPSno
        '
        Me.txtTongPSno.Location = New System.Drawing.Point(284, 5)
        Me.txtTongPSno.Name = "txtTongPSno"
        Me.txtTongPSno.Properties.AllowFocused = False
        Me.txtTongPSno.Properties.Mask.EditMask = "n0"
        Me.txtTongPSno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongPSno.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongPSno.Properties.ReadOnly = True
        Me.txtTongPSno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongPSno.Size = New System.Drawing.Size(100, 20)
        Me.txtTongPSno.TabIndex = 61
        Me.txtTongPSno.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(224, 9)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 60
        Me.LabelControl4.Text = "Tổng PS nợ"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.ImageIndex = 8
        Me.btnQuit.Location = New System.Drawing.Point(920, 0)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quay ra"
        '
        'labelControl20
        '
        Me.labelControl20.Location = New System.Drawing.Point(670, 32)
        Me.labelControl20.Name = "labelControl20"
        Me.labelControl20.Size = New System.Drawing.Size(29, 13)
        Me.labelControl20.TabIndex = 5
        Me.labelControl20.Text = "Tỷ giá"
        '
        'pncbtn
        '
        Me.pncbtn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pncbtn.Controls.Add(Me.navWelding1)
        Me.pncbtn.Controls.Add(Me.btnSea)
        Me.pncbtn.Controls.Add(Me.btnModify)
        Me.pncbtn.Controls.Add(Me.btnAdd)
        Me.pncbtn.Controls.Add(Me.btnDelete)
        Me.pncbtn.Controls.Add(Me.btnCan)
        Me.pncbtn.Controls.Add(Me.btnQuit)
        Me.pncbtn.Controls.Add(Me.btnPrinter)
        Me.pncbtn.Controls.Add(Me.btnSav)
        Me.pncbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pncbtn.Location = New System.Drawing.Point(4, 578)
        Me.pncbtn.Name = "pncbtn"
        Me.pncbtn.Size = New System.Drawing.Size(1000, 30)
        Me.pncbtn.TabIndex = 1
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
        Me.navWelding1.Location = New System.Drawing.Point(2, 0)
        Me.navWelding1.Name = "navWelding1"
        Me.navWelding1.NavigatableControl = Me.GRC_CTH
        Me.navWelding1.Size = New System.Drawing.Size(192, 30)
        Me.navWelding1.TabIndex = 18
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
        Me.GRV_CTH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GHI, Me.NGAY_CT, Me.CT_SO, Me.grv1_SO_TIEN, Me.TY_GIA, Me.grv1_KY_HIEU_KHANG, Me.grv1_TEN_KHANG})
        Me.GRV_CTH.GridControl = Me.GRC_CTH
        Me.GRV_CTH.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GRV_CTH.Name = "GRV_CTH"
        Me.GRV_CTH.OptionsBehavior.Editable = False
        Me.GRV_CTH.OptionsView.ColumnAutoWidth = False
        Me.GRV_CTH.OptionsView.EnableAppearanceEvenRow = True
        Me.GRV_CTH.OptionsView.EnableAppearanceOddRow = True
        Me.GRV_CTH.OptionsView.ShowGroupPanel = False
        '
        'GHI
        '
        Me.GHI.Caption = "Trạng thái"
        Me.GHI.FieldName = "Ghi"
        Me.GHI.Name = "GHI"
        Me.GHI.Visible = True
        Me.GHI.VisibleIndex = 0
        Me.GHI.Width = 71
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày chứng từ"
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.OptionsColumn.FixedWidth = True
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 2
        Me.NGAY_CT.Width = 100
        '
        'CT_SO
        '
        Me.CT_SO.AppearanceCell.Options.UseTextOptions = True
        Me.CT_SO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CT_SO.Caption = "Số chứng từ"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.OptionsColumn.FixedWidth = True
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 1
        Me.CT_SO.Width = 85
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
        'TY_GIA
        '
        Me.TY_GIA.Caption = "Tỷ giá"
        Me.TY_GIA.DisplayFormat.FormatString = "n0"
        Me.TY_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TY_GIA.FieldName = "TyGia"
        Me.TY_GIA.Name = "TY_GIA"
        Me.TY_GIA.OptionsColumn.FixedWidth = True
        Me.TY_GIA.Width = 100
        '
        'grv1_KY_HIEU_KHANG
        '
        Me.grv1_KY_HIEU_KHANG.Caption = "Mã khách hàng"
        Me.grv1_KY_HIEU_KHANG.FieldName = "KY_HIEU_KHANG"
        Me.grv1_KY_HIEU_KHANG.Name = "grv1_KY_HIEU_KHANG"
        Me.grv1_KY_HIEU_KHANG.Width = 104
        '
        'grv1_TEN_KHANG
        '
        Me.grv1_TEN_KHANG.Caption = "Tên khách hàng"
        Me.grv1_TEN_KHANG.FieldName = "TEN_KHANG"
        Me.grv1_TEN_KHANG.Name = "grv1_TEN_KHANG"
        Me.grv1_TEN_KHANG.Width = 144
        '
        'btnPrinter
        '
        Me.btnPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrinter.ImageIndex = 5
        Me.btnPrinter.Location = New System.Drawing.Point(716, 0)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(80, 30)
        Me.btnPrinter.TabIndex = 6
        Me.btnPrinter.Text = "In"
        '
        'btnSav
        '
        Me.btnSav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(458, 0)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(80, 30)
        Me.btnSav.TabIndex = 3
        Me.btnSav.Text = "&Lưu"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(235, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Ghi chú"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Mã tài khoản"
        Me.GridColumn16.FieldName = "MA_TAIKHOAN"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(284, 28)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(291, 20)
        Me.txtDIEN_GIAI.TabIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tên khách hàng"
        Me.GridColumn11.FieldName = "TEN_KHANG"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Tên tài khoản"
        Me.GridColumn17.FieldName = "TEN_TAIKHOAN"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tên khách hàng"
        Me.GridColumn13.FieldName = "TEN_KHANG"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(242, 7)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(28, 13)
        Me.labelControl19.TabIndex = 56
        Me.labelControl19.Text = "Số CT"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Ký hiệu"
        Me.GridColumn12.FieldName = "KY_HIEU"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Ký hiệu"
        Me.GridColumn10.FieldName = "KY_HIEU"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(713, 5)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.Size = New System.Drawing.Size(82, 20)
        Me.cboNgoaiTe.TabIndex = 4
        '
        'grpSMQR
        '
        Me.grpSMQR.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grpSMQR.Appearance.BorderColor = System.Drawing.Color.White
        Me.grpSMQR.Appearance.Options.UseBackColor = True
        Me.grpSMQR.Appearance.Options.UseBorderColor = True
        Me.grpSMQR.Controls.Add(Me.C_SoChungTu_RP)
        Me.grpSMQR.Controls.Add(Me.txtDIEN_GIAI)
        Me.grpSMQR.Controls.Add(Me.LabelControl1)
        Me.grpSMQR.Controls.Add(Me.labelControl19)
        Me.grpSMQR.Controls.Add(Me.cboNgoaiTe)
        Me.grpSMQR.Controls.Add(Me.chkNgoaiTe)
        Me.grpSMQR.Controls.Add(Me.txtTY_GIA1)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_GHI)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_CT)
        Me.grpSMQR.Controls.Add(Me.labelControl20)
        Me.grpSMQR.Controls.Add(Me.labelControl10)
        Me.grpSMQR.Controls.Add(Me.labelControl6)
        Me.grpSMQR.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSMQR.Location = New System.Drawing.Point(0, 0)
        Me.grpSMQR.Name = "grpSMQR"
        Me.grpSMQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpSMQR.ShowCaption = False
        Me.grpSMQR.Size = New System.Drawing.Size(801, 54)
        Me.grpSMQR.TabIndex = 0
        Me.grpSMQR.Text = "Chi tiết...."
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(284, 5)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 2
        '
        'chkNgoaiTe
        '
        Me.chkNgoaiTe.Location = New System.Drawing.Point(636, 5)
        Me.chkNgoaiTe.Name = "chkNgoaiTe"
        Me.chkNgoaiTe.Properties.Caption = "Ngoại tệ"
        Me.chkNgoaiTe.Size = New System.Drawing.Size(63, 19)
        Me.chkNgoaiTe.TabIndex = 3
        Me.chkNgoaiTe.Visible = False
        '
        'txtTY_GIA1
        '
        Me.txtTY_GIA1.EnterMoveNextControl = True
        Me.txtTY_GIA1.Location = New System.Drawing.Point(713, 29)
        Me.txtTY_GIA1.Name = "txtTY_GIA1"
        Me.txtTY_GIA1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA1.Properties.Mask.EditMask = "n2"
        Me.txtTY_GIA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTY_GIA1.Size = New System.Drawing.Size(82, 20)
        Me.txtTY_GIA1.TabIndex = 5
        '
        'daeNGAY_GHI
        '
        Me.daeNGAY_GHI.EditValue = Nothing
        Me.daeNGAY_GHI.EnterMoveNextControl = True
        Me.daeNGAY_GHI.Location = New System.Drawing.Point(59, 4)
        Me.daeNGAY_GHI.Name = "daeNGAY_GHI"
        Me.daeNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_GHI.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_GHI.Size = New System.Drawing.Size(93, 20)
        Me.daeNGAY_GHI.TabIndex = 0
        '
        'daeNGAY_CT
        '
        Me.daeNGAY_CT.EditValue = Nothing
        Me.daeNGAY_CT.EnterMoveNextControl = True
        Me.daeNGAY_CT.Location = New System.Drawing.Point(59, 28)
        Me.daeNGAY_CT.Name = "daeNGAY_CT"
        Me.daeNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_CT.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_CT.Size = New System.Drawing.Size(93, 20)
        Me.daeNGAY_CT.TabIndex = 1
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(4, 32)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(41, 13)
        Me.labelControl6.TabIndex = 1
        Me.labelControl6.Text = "Ngày CT"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 54)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(801, 21)
        Me.PanelControl1.TabIndex = 5011
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
        Me.GroupControl2.TabIndex = 24
        '
        'frmPhieuKeToanKhac2_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.pncbtn)
        Me.KeyPreview = True
        Me.Name = "frmPhieuKeToanKhac2_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu kế toán khác"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfeTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfeKhang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTuDo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTuDo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTuDo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTuDo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTuDo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_HOADON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cboTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaiKhoanCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ffhfh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcCT_Thue.ResumeLayout(False)
        Me.grcCT_Thue.PerformLayout()
        CType(Me.txtTongPSco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongPSno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pncbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pncbtn.ResumeLayout(False)
        CType(Me.GRC_CTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRV_CTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMQR.ResumeLayout(False)
        Me.grpSMQR.PerformLayout()
        CType(Me.chkNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents grcCT_Thue As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents labelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pncbtn As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPrinter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpSMQR As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkNgoaiTe As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTY_GIA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents daeNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents daeNGAY_CT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThue As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTongPSco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongPSno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTaiKhoan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TEN_TK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO_NT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_CO_NT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PS_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPTQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MA_VUVIEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_PHONGBAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPhongBan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_KHOANPHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKhoanPhi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTuDo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTuDo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTuDo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTuDo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTuDo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NHOM As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents txtTenTkNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboTaiKhoanCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboHopDong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKHangNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKHangCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ffhfh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKHCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UC_Status As Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GRC_CTH As DevExpress.XtraGrid.GridControl
    Friend WithEvents GRV_CTH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navWelding1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pfeTaiKhoan As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents pfeKhang As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents MA_HOADON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MyRepositoryItem_MA_HOADON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SoChungTu_RP As Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
