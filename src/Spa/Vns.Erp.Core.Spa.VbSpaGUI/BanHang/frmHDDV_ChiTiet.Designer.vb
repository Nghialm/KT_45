<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHDDV_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHDDV_ChiTiet))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grcCth_hddv = New DevExpress.XtraGrid.GridControl()
        Me.grvCth_hddv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.C_SoChungTu = New C_SoChungTu()
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpHangHoa = New DevExpress.XtraTab.XtraTabPage()
        Me.grcHangHoa = New DevExpress.XtraGrid.GridControl()
        Me.grvHangHoa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_HH_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cfilter_HangHoa = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.SO_LUONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DON_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DOANH_THU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TY_LE_GIAM_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_GIAM_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TY_LE_HH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_HH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_MG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOI_DUNG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtpDichVu = New DevExpress.XtraTab.XtraTabPage()
        Me.grcDichVu = New DevExpress.XtraGrid.GridControl()
        Me.grvDichVu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TEN_HH_DV_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cfilter_DichVu = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.DON_GIA_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DOANH_THU_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TY_LE_GIAM_GIA_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_GIAM_GIA_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TY_LE_HH_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_HH_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_MG_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.NOI_DUNG_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.cboChonDichVu = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cFilterThe = New Vns.Erp.Core.CustomFilter()
        Me.txtConNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTongTT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTTThe = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTTTheNh = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTTTienMat = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me._pnVatTu = New DevExpress.XtraEditors.PanelControl()
        Me.txtGiamGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTienHang = New DevExpress.XtraEditors.TextEdit()
        Me.txtTongCong = New DevExpress.XtraEditors.TextEdit()
        Me._pnTongCong = New DevExpress.XtraEditors.PanelControl()
        Me.txtTongTienTT = New DevExpress.XtraEditors.TextEdit()
        Me.txtGiamGiaTong = New DevExpress.XtraEditors.TextEdit()
        Me.txtTongTienHang = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me._pnTienCong = New DevExpress.XtraEditors.PanelControl()
        Me.txtTongCongSC = New DevExpress.XtraEditors.TextEdit()
        Me.txtGiamGiaSC = New DevExpress.XtraEditors.TextEdit()
        Me.txtTienCongSC = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDenGio = New DevExpress.XtraEditors.TimeEdit()
        Me.txtTuGio = New DevExpress.XtraEditors.TimeEdit()
        Me.cFilterKhachHang = New Vns.Erp.Core.CustomFilter()
        Me.cboGiuongDV = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Ma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboNhanVien = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Manhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tennhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboLoaiCT = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MaLoaiCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenLoaiCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTenNhanVien = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenKH = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.dteNgayCT = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrinter = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grcCth_hddv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCth_hddv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpHangHoa.SuspendLayout()
        CType(Me.grcHangHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHangHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfilter_HangHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDichVu.SuspendLayout()
        CType(Me.grcDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfilter_DichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtConNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTTThe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTTTheNh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTTTienMat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pnVatTu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._pnVatTu.SuspendLayout()
        CType(Me.txtGiamGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongCong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pnTongCong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._pnTongCong.SuspendLayout()
        CType(Me.txtTongTienTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGiamGiaTong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTienHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pnTienCong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._pnTienCong.SuspendLayout()
        CType(Me.txtTongCongSC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGiamGiaSC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienCongSC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDenGio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTuGio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGiuongDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLoaiCT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenKH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayCT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayCT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grcCth_hddv)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl4)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 570)
        Me.SplitContainerControl1.SplitterPosition = 221
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grcCth_hddv
        '
        Me.grcCth_hddv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCth_hddv.Location = New System.Drawing.Point(0, 0)
        Me.grcCth_hddv.MainView = Me.grvCth_hddv
        Me.grcCth_hddv.Name = "grcCth_hddv"
        Me.grcCth_hddv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit16})
        Me.grcCth_hddv.Size = New System.Drawing.Size(221, 570)
        Me.grcCth_hddv.TabIndex = 0
        Me.grcCth_hddv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCth_hddv})
        '
        'grvCth_hddv
        '
        Me.grvCth_hddv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn24, Me.GridColumn17})
        Me.grvCth_hddv.GridControl = Me.grcCth_hddv
        Me.grvCth_hddv.Name = "grvCth_hddv"
        Me.grvCth_hddv.OptionsView.ColumnAutoWidth = False
        Me.grvCth_hddv.OptionsView.ShowAutoFilterRow = True
        Me.grvCth_hddv.OptionsView.ShowGroupPanel = False
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Mã loại CT"
        Me.GridColumn23.FieldName = "MaLoaiCt"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        Me.GridColumn23.Width = 95
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Số CT"
        Me.GridColumn24.FieldName = "CtSo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 1
        Me.GridColumn24.Width = 105
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Ngày CT"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemTextEdit16
        Me.GridColumn17.FieldName = "NgayCt"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 2
        Me.GridColumn17.Width = 97
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.AutoHeight = False
        Me.RepositoryItemTextEdit16.Mask.EditMask = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit16.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemTextEdit16.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 165)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpHangHoa
        Me.XtraTabControl1.Size = New System.Drawing.Size(774, 257)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpHangHoa, Me.xtpDichVu})
        '
        'xtpHangHoa
        '
        Me.xtpHangHoa.Controls.Add(Me.grcHangHoa)
        Me.xtpHangHoa.Name = "xtpHangHoa"
        Me.xtpHangHoa.Size = New System.Drawing.Size(768, 230)
        Me.xtpHangHoa.Text = "&Hàng hóa"
        '
        'grcHangHoa
        '
        Me.grcHangHoa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcHangHoa.Location = New System.Drawing.Point(0, 0)
        Me.grcHangHoa.MainView = Me.grvHangHoa
        Me.grcHangHoa.Name = "grcHangHoa"
        Me.grcHangHoa.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.cfilter_HangHoa, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8})
        Me.grcHangHoa.Size = New System.Drawing.Size(768, 230)
        Me.grcHangHoa.TabIndex = 1
        Me.grcHangHoa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHangHoa})
        '
        'grvHangHoa
        '
        Me.grvHangHoa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID_HANGHOA, Me.TEN_HH_DV, Me.SO_LUONG, Me.DON_GIA, Me.DOANH_THU, Me.TY_LE_GIAM_GIA, Me.SO_TIEN_GIAM_GIA, Me.TY_LE_HH, Me.SO_TIEN_HH, Me.SO_TIEN_MG, Me.DVT, Me.NOI_DUNG})
        Me.grvHangHoa.GridControl = Me.grcHangHoa
        Me.grvHangHoa.Name = "grvHangHoa"
        Me.grvHangHoa.OptionsNavigation.EnterMoveNextColumn = True
        Me.grvHangHoa.OptionsView.ColumnAutoWidth = False
        Me.grvHangHoa.OptionsView.ShowGroupPanel = False
        '
        'ID_HANGHOA
        '
        Me.ID_HANGHOA.Caption = "Mã hàng hóa"
        Me.ID_HANGHOA.FieldName = "ID_HANGHOA"
        Me.ID_HANGHOA.Name = "ID_HANGHOA"
        Me.ID_HANGHOA.Width = 83
        '
        'TEN_HH_DV
        '
        Me.TEN_HH_DV.Caption = "Tên hàng hóa"
        Me.TEN_HH_DV.ColumnEdit = Me.cfilter_HangHoa
        Me.TEN_HH_DV.FieldName = "TenHhDv"
        Me.TEN_HH_DV.Name = "TEN_HH_DV"
        Me.TEN_HH_DV.Visible = True
        Me.TEN_HH_DV.VisibleIndex = 0
        Me.TEN_HH_DV.Width = 132
        '
        'cfilter_HangHoa
        '
        Me.cfilter_HangHoa.AutoHeight = False
        Me.cfilter_HangHoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cfilter_HangHoa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cfilter_HangHoa.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" & _
            "nDvt--80-0"
        Me.cfilter_HangHoa.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt"
        Me.cfilter_HangHoa.C_DATA_SOURCE = Nothing
        Me.cfilter_HangHoa.C_FORM_DANHSACH = "frmDanhMucHangHoa_DanhSach"
        Me.cfilter_HangHoa.C_FORM_TITLE = "Chọn hàng hóa"
        Me.cfilter_HangHoa.C_IS_CHECK_NUMBER = "="
        Me.cfilter_HangHoa.C_IS_CHECK_OTHER = "="
        Me.cfilter_HangHoa.C_IS_CHECK_STRING = "="
        Me.cfilter_HangHoa.C_IS_CHI_TIET = ""
        Me.cfilter_HangHoa.C_IS_FILTER_STRING = ""
        Me.cfilter_HangHoa.C_IS_QUICKADD = True
        Me.cfilter_HangHoa.C_IS_SORT_ORDER_STRING = ""
        Me.cfilter_HangHoa.C_KEY_NAME = "TenHanghoa"
        Me.cfilter_HangHoa.Editors = Nothing
        Me.cfilter_HangHoa.EditValues = ""
        Me.cfilter_HangHoa.ListEditValues = Nothing
        Me.cfilter_HangHoa.Name = "cfilter_HangHoa"
        Me.cfilter_HangHoa.NEXT_TAB = 0
        Me.cfilter_HangHoa.OBJ_CONDITITION = Nothing
        '
        'SO_LUONG
        '
        Me.SO_LUONG.Caption = "Số lượng"
        Me.SO_LUONG.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.SO_LUONG.FieldName = "SoLuong"
        Me.SO_LUONG.Name = "SO_LUONG"
        Me.SO_LUONG.Visible = True
        Me.SO_LUONG.VisibleIndex = 2
        Me.SO_LUONG.Width = 72
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'DON_GIA
        '
        Me.DON_GIA.Caption = "Đơn giá"
        Me.DON_GIA.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DON_GIA.FieldName = "DonGia"
        Me.DON_GIA.Name = "DON_GIA"
        Me.DON_GIA.Visible = True
        Me.DON_GIA.VisibleIndex = 3
        Me.DON_GIA.Width = 88
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'DOANH_THU
        '
        Me.DOANH_THU.Caption = "Doanh thu"
        Me.DOANH_THU.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.DOANH_THU.FieldName = "DoanhThu"
        Me.DOANH_THU.Name = "DOANH_THU"
        Me.DOANH_THU.OptionsColumn.AllowEdit = False
        Me.DOANH_THU.OptionsColumn.ReadOnly = True
        Me.DOANH_THU.Visible = True
        Me.DOANH_THU.VisibleIndex = 4
        Me.DOANH_THU.Width = 94
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'TY_LE_GIAM_GIA
        '
        Me.TY_LE_GIAM_GIA.Caption = "% giảm giá"
        Me.TY_LE_GIAM_GIA.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.TY_LE_GIAM_GIA.FieldName = "TyLeGiamGia"
        Me.TY_LE_GIAM_GIA.Name = "TY_LE_GIAM_GIA"
        Me.TY_LE_GIAM_GIA.Visible = True
        Me.TY_LE_GIAM_GIA.VisibleIndex = 5
        Me.TY_LE_GIAM_GIA.Width = 69
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'SO_TIEN_GIAM_GIA
        '
        Me.SO_TIEN_GIAM_GIA.Caption = "Số tiền giảm giá"
        Me.SO_TIEN_GIAM_GIA.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.SO_TIEN_GIAM_GIA.FieldName = "SoTienGiamGia"
        Me.SO_TIEN_GIAM_GIA.Name = "SO_TIEN_GIAM_GIA"
        Me.SO_TIEN_GIAM_GIA.OptionsColumn.AllowEdit = False
        Me.SO_TIEN_GIAM_GIA.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_GIAM_GIA.Visible = True
        Me.SO_TIEN_GIAM_GIA.VisibleIndex = 6
        Me.SO_TIEN_GIAM_GIA.Width = 111
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'TY_LE_HH
        '
        Me.TY_LE_HH.Caption = "% hoa hồng"
        Me.TY_LE_HH.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.TY_LE_HH.FieldName = "TyLeHh"
        Me.TY_LE_HH.Name = "TY_LE_HH"
        Me.TY_LE_HH.Visible = True
        Me.TY_LE_HH.VisibleIndex = 7
        Me.TY_LE_HH.Width = 88
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'SO_TIEN_HH
        '
        Me.SO_TIEN_HH.Caption = "Số tiền hoa hồng"
        Me.SO_TIEN_HH.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.SO_TIEN_HH.FieldName = "SoTienHh"
        Me.SO_TIEN_HH.Name = "SO_TIEN_HH"
        Me.SO_TIEN_HH.OptionsColumn.AllowEdit = False
        Me.SO_TIEN_HH.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_HH.Visible = True
        Me.SO_TIEN_HH.VisibleIndex = 8
        Me.SO_TIEN_HH.Width = 109
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'SO_TIEN_MG
        '
        Me.SO_TIEN_MG.Caption = "Số tiền môi giới"
        Me.SO_TIEN_MG.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.SO_TIEN_MG.FieldName = "SoTienMg"
        Me.SO_TIEN_MG.Name = "SO_TIEN_MG"
        Me.SO_TIEN_MG.Visible = True
        Me.SO_TIEN_MG.VisibleIndex = 9
        Me.SO_TIEN_MG.Width = 106
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'DVT
        '
        Me.DVT.Caption = "ĐVT"
        Me.DVT.FieldName = "Dvt"
        Me.DVT.Name = "DVT"
        Me.DVT.Visible = True
        Me.DVT.VisibleIndex = 1
        Me.DVT.Width = 66
        '
        'NOI_DUNG
        '
        Me.NOI_DUNG.Caption = "Nội dung"
        Me.NOI_DUNG.FieldName = "NoiDung"
        Me.NOI_DUNG.Name = "NOI_DUNG"
        Me.NOI_DUNG.Visible = True
        Me.NOI_DUNG.VisibleIndex = 10
        Me.NOI_DUNG.Width = 201
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'xtpDichVu
        '
        Me.xtpDichVu.Controls.Add(Me.grcDichVu)
        Me.xtpDichVu.Name = "xtpDichVu"
        Me.xtpDichVu.Size = New System.Drawing.Size(768, 230)
        Me.xtpDichVu.Text = "&Dịch vụ"
        '
        'grcDichVu
        '
        Me.grcDichVu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcDichVu.Location = New System.Drawing.Point(0, 0)
        Me.grcDichVu.MainView = Me.grvDichVu
        Me.grcDichVu.Name = "grcDichVu"
        Me.grcDichVu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemTextEdit12, Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit14, Me.RepositoryItemTextEdit15, Me.cfilter_DichVu})
        Me.grcDichVu.Size = New System.Drawing.Size(768, 230)
        Me.grcDichVu.TabIndex = 2
        Me.grcDichVu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDichVu})
        '
        'grvDichVu
        '
        Me.grvDichVu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TEN_HH_DV_DV, Me.DON_GIA_DV, Me.DOANH_THU_DV, Me.TY_LE_GIAM_GIA_DV, Me.SO_TIEN_GIAM_GIA_DV, Me.TY_LE_HH_DV, Me.SO_TIEN_HH_DV, Me.SO_TIEN_MG_DV, Me.NOI_DUNG_DV})
        Me.grvDichVu.GridControl = Me.grcDichVu
        Me.grvDichVu.Name = "grvDichVu"
        Me.grvDichVu.OptionsNavigation.EnterMoveNextColumn = True
        Me.grvDichVu.OptionsView.ColumnAutoWidth = False
        Me.grvDichVu.OptionsView.ShowGroupPanel = False
        '
        'TEN_HH_DV_DV
        '
        Me.TEN_HH_DV_DV.Caption = "Tên dịch vụ"
        Me.TEN_HH_DV_DV.ColumnEdit = Me.cfilter_DichVu
        Me.TEN_HH_DV_DV.FieldName = "TenHhDv"
        Me.TEN_HH_DV_DV.Name = "TEN_HH_DV_DV"
        Me.TEN_HH_DV_DV.Visible = True
        Me.TEN_HH_DV_DV.VisibleIndex = 0
        Me.TEN_HH_DV_DV.Width = 140
        '
        'cfilter_DichVu
        '
        Me.cfilter_DichVu.AutoHeight = False
        Me.cfilter_DichVu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cfilter_DichVu.C_ARR_COLS_DISPLAY = "Ma-Mã dịch vụ-80-1;Ten-Tên dịch vụ-200-1;Id--80-0;Ma--80-0"
        Me.cfilter_DichVu.C_ARR_COLS_RETURN = "Id;Kyhieu;Ten;Ma;DonGia"
        Me.cfilter_DichVu.C_DATA_SOURCE = Nothing
        Me.cfilter_DichVu.C_FORM_DANHSACH = ""
        Me.cfilter_DichVu.C_FORM_TITLE = "Chọn dịch vụ"
        Me.cfilter_DichVu.C_IS_CHECK_NUMBER = "="
        Me.cfilter_DichVu.C_IS_CHECK_OTHER = "="
        Me.cfilter_DichVu.C_IS_CHECK_STRING = "="
        Me.cfilter_DichVu.C_IS_CHI_TIET = ""
        Me.cfilter_DichVu.C_IS_FILTER_STRING = ""
        Me.cfilter_DichVu.C_IS_QUICKADD = True
        Me.cfilter_DichVu.C_IS_SORT_ORDER_STRING = ""
        Me.cfilter_DichVu.C_KEY_NAME = "Ten"
        Me.cfilter_DichVu.Editors = Nothing
        Me.cfilter_DichVu.EditValues = ""
        Me.cfilter_DichVu.ListEditValues = Nothing
        Me.cfilter_DichVu.Name = "cfilter_DichVu"
        Me.cfilter_DichVu.NEXT_TAB = 0
        Me.cfilter_DichVu.OBJ_CONDITITION = Nothing
        '
        'DON_GIA_DV
        '
        Me.DON_GIA_DV.Caption = "Đơn giá"
        Me.DON_GIA_DV.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.DON_GIA_DV.FieldName = "DonGia"
        Me.DON_GIA_DV.Name = "DON_GIA_DV"
        Me.DON_GIA_DV.Visible = True
        Me.DON_GIA_DV.VisibleIndex = 1
        Me.DON_GIA_DV.Width = 103
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'DOANH_THU_DV
        '
        Me.DOANH_THU_DV.Caption = "Doanh thu"
        Me.DOANH_THU_DV.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.DOANH_THU_DV.FieldName = "DoanhThu"
        Me.DOANH_THU_DV.Name = "DOANH_THU_DV"
        Me.DOANH_THU_DV.OptionsColumn.AllowEdit = False
        Me.DOANH_THU_DV.OptionsColumn.ReadOnly = True
        Me.DOANH_THU_DV.Visible = True
        Me.DOANH_THU_DV.VisibleIndex = 2
        Me.DOANH_THU_DV.Width = 94
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'TY_LE_GIAM_GIA_DV
        '
        Me.TY_LE_GIAM_GIA_DV.Caption = "% giảm giá"
        Me.TY_LE_GIAM_GIA_DV.ColumnEdit = Me.RepositoryItemTextEdit11
        Me.TY_LE_GIAM_GIA_DV.FieldName = "TyLeGiamGia"
        Me.TY_LE_GIAM_GIA_DV.Name = "TY_LE_GIAM_GIA_DV"
        Me.TY_LE_GIAM_GIA_DV.Visible = True
        Me.TY_LE_GIAM_GIA_DV.VisibleIndex = 3
        Me.TY_LE_GIAM_GIA_DV.Width = 88
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'SO_TIEN_GIAM_GIA_DV
        '
        Me.SO_TIEN_GIAM_GIA_DV.Caption = "Số tiền giảm giá"
        Me.SO_TIEN_GIAM_GIA_DV.ColumnEdit = Me.RepositoryItemTextEdit12
        Me.SO_TIEN_GIAM_GIA_DV.FieldName = "SoTienGiamGia"
        Me.SO_TIEN_GIAM_GIA_DV.Name = "SO_TIEN_GIAM_GIA_DV"
        Me.SO_TIEN_GIAM_GIA_DV.OptionsColumn.AllowEdit = False
        Me.SO_TIEN_GIAM_GIA_DV.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_GIAM_GIA_DV.Visible = True
        Me.SO_TIEN_GIAM_GIA_DV.VisibleIndex = 4
        Me.SO_TIEN_GIAM_GIA_DV.Width = 117
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'TY_LE_HH_DV
        '
        Me.TY_LE_HH_DV.Caption = "% hoa hồng"
        Me.TY_LE_HH_DV.ColumnEdit = Me.RepositoryItemTextEdit13
        Me.TY_LE_HH_DV.FieldName = "TyLeHh"
        Me.TY_LE_HH_DV.Name = "TY_LE_HH_DV"
        Me.TY_LE_HH_DV.Visible = True
        Me.TY_LE_HH_DV.VisibleIndex = 5
        Me.TY_LE_HH_DV.Width = 99
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit13.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'SO_TIEN_HH_DV
        '
        Me.SO_TIEN_HH_DV.Caption = "Số tiền hoa hồng"
        Me.SO_TIEN_HH_DV.ColumnEdit = Me.RepositoryItemTextEdit14
        Me.SO_TIEN_HH_DV.FieldName = "SoTienHh"
        Me.SO_TIEN_HH_DV.Name = "SO_TIEN_HH_DV"
        Me.SO_TIEN_HH_DV.OptionsColumn.AllowEdit = False
        Me.SO_TIEN_HH_DV.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_HH_DV.Visible = True
        Me.SO_TIEN_HH_DV.VisibleIndex = 6
        Me.SO_TIEN_HH_DV.Width = 116
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit14.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit14.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'SO_TIEN_MG_DV
        '
        Me.SO_TIEN_MG_DV.Caption = "Số tiền môi giới"
        Me.SO_TIEN_MG_DV.ColumnEdit = Me.RepositoryItemTextEdit15
        Me.SO_TIEN_MG_DV.FieldName = "SoTienMg"
        Me.SO_TIEN_MG_DV.Name = "SO_TIEN_MG_DV"
        Me.SO_TIEN_MG_DV.Visible = True
        Me.SO_TIEN_MG_DV.VisibleIndex = 7
        Me.SO_TIEN_MG_DV.Width = 108
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit15.AutoHeight = False
        Me.RepositoryItemTextEdit15.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit15.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit15.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
        '
        'NOI_DUNG_DV
        '
        Me.NOI_DUNG_DV.Caption = "Nội dung"
        Me.NOI_DUNG_DV.FieldName = "NoiDung"
        Me.NOI_DUNG_DV.Name = "NOI_DUNG_DV"
        Me.NOI_DUNG_DV.Visible = True
        Me.NOI_DUNG_DV.VisibleIndex = 8
        Me.NOI_DUNG_DV.Width = 116
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.cboChonDichVu)
        Me.PanelControl4.Controls.Add(Me.LabelControl7)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 135)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(774, 30)
        Me.PanelControl4.TabIndex = 1
        '
        'cboChonDichVu
        '
        Me.cboChonDichVu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboChonDichVu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChonDichVu.Appearance.Options.UseFont = True
        Me.cboChonDichVu.ImageIndex = 5
        Me.cboChonDichVu.Location = New System.Drawing.Point(0, 1)
        Me.cboChonDichVu.Name = "cboChonDichVu"
        Me.cboChonDichVu.Size = New System.Drawing.Size(80, 30)
        Me.cboChonDichVu.TabIndex = 0
        Me.cboChonDichVu.Text = "Chọn dịch vụ"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(425, 10)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cFilterThe)
        Me.GroupControl3.Controls.Add(Me.txtConNo)
        Me.GroupControl3.Controls.Add(Me.LabelControl28)
        Me.GroupControl3.Controls.Add(Me.txtTongTT)
        Me.GroupControl3.Controls.Add(Me.LabelControl27)
        Me.GroupControl3.Controls.Add(Me.txtTTThe)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl26)
        Me.GroupControl3.Controls.Add(Me.txtTTTheNh)
        Me.GroupControl3.Controls.Add(Me.LabelControl25)
        Me.GroupControl3.Controls.Add(Me.txtTTTienMat)
        Me.GroupControl3.Controls.Add(Me.LabelControl24)
        Me.GroupControl3.Controls.Add(Me.LabelControl31)
        Me.GroupControl3.Controls.Add(Me.labelControl21)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me._pnVatTu)
        Me.GroupControl3.Controls.Add(Me._pnTongCong)
        Me.GroupControl3.Controls.Add(Me._pnTienCong)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 422)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(774, 148)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "GroupControl2"
        '
        'cFilterThe
        '
        Me.cFilterThe.AllowNull = True
        Me.cFilterThe.C_ARR_COLS_DISPLAY = "Kyhieu-Mã thẻ-80-1;Ten-Tên thẻ-80-1;Sotienconlai-Số tiền còn lại-80-1;Id--0-0"
        Me.cFilterThe.C_ARR_COLS_RETURN = "id;Ma;Ten;Sotienconlai"
        Me.cFilterThe.C_DATA_SOURCE = Nothing
        Me.cFilterThe.C_FORM_DANHSACH = ""
        Me.cFilterThe.C_FORM_TITLE = "Chọn thẻ dịch vụ"
        Me.cFilterThe.C_IS_CHECK_NUMBER = "="
        Me.cFilterThe.C_IS_CHECK_OTHER = "="
        Me.cFilterThe.C_IS_CHECK_STRING = "="
        Me.cFilterThe.C_IS_FILTER_STRING = ""
        Me.cFilterThe.C_IS_QUICKADD = False
        Me.cFilterThe.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterThe.C_KEY_NAME = "Ma"
        Me.cFilterThe.EditValue = ""
        Me.cFilterThe.EditValues = ""
        Me.cFilterThe.ENABLES = True
        Me.cFilterThe.IsNotTextChanged = True
        Me.cFilterThe.ListEditValue = CType(resources.GetObject("cFilterThe.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterThe.Location = New System.Drawing.Point(483, 12)
        Me.cFilterThe.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterThe.Name = "cFilterThe"
        Me.cFilterThe.NEXT_TAB = 0
        Me.cFilterThe.Size = New System.Drawing.Size(106, 20)
        Me.cFilterThe.TabIndex = 0
        '
        'txtConNo
        '
        Me.txtConNo.Location = New System.Drawing.Point(666, 116)
        Me.txtConNo.Name = "txtConNo"
        Me.txtConNo.Properties.Mask.EditMask = "n0"
        Me.txtConNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtConNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtConNo.Properties.ReadOnly = True
        Me.txtConNo.Size = New System.Drawing.Size(100, 20)
        Me.txtConNo.TabIndex = 5
        Me.txtConNo.TabStop = False
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(607, 119)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl28.TabIndex = 47
        Me.LabelControl28.Text = "Còn nợ"
        '
        'txtTongTT
        '
        Me.txtTongTT.Location = New System.Drawing.Point(666, 90)
        Me.txtTongTT.Name = "txtTongTT"
        Me.txtTongTT.Properties.Mask.EditMask = "n0"
        Me.txtTongTT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTT.Properties.ReadOnly = True
        Me.txtTongTT.Size = New System.Drawing.Size(100, 20)
        Me.txtTongTT.TabIndex = 4
        Me.txtTongTT.TabStop = False
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(607, 93)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl27.TabIndex = 47
        Me.LabelControl27.Text = "Tổng"
        '
        'txtTTThe
        '
        Me.txtTTThe.EnterMoveNextControl = True
        Me.txtTTThe.Location = New System.Drawing.Point(666, 12)
        Me.txtTTThe.Name = "txtTTThe"
        Me.txtTTThe.Properties.Mask.EditMask = "n0"
        Me.txtTTThe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTTThe.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTTThe.Size = New System.Drawing.Size(100, 20)
        Me.txtTTThe.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(433, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 47
        Me.LabelControl6.Text = "Chọn thẻ"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(606, 15)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl26.TabIndex = 47
        Me.LabelControl26.Text = "TT thẻ"
        '
        'txtTTTheNh
        '
        Me.txtTTTheNh.EnterMoveNextControl = True
        Me.txtTTTheNh.Location = New System.Drawing.Point(666, 38)
        Me.txtTTTheNh.Name = "txtTTTheNh"
        Me.txtTTTheNh.Properties.Mask.EditMask = "n0"
        Me.txtTTTheNh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTTTheNh.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTTTheNh.Size = New System.Drawing.Size(100, 20)
        Me.txtTTTheNh.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(607, 41)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl25.TabIndex = 47
        Me.LabelControl25.Text = "TT thẻ NH"
        '
        'txtTTTienMat
        '
        Me.txtTTTienMat.EnterMoveNextControl = True
        Me.txtTTTienMat.Location = New System.Drawing.Point(666, 64)
        Me.txtTTTienMat.Name = "txtTTTienMat"
        Me.txtTTTienMat.Properties.Mask.EditMask = "n0"
        Me.txtTTTienMat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTTTienMat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTTTienMat.Size = New System.Drawing.Size(100, 20)
        Me.txtTTTienMat.TabIndex = 3
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(606, 67)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl24.TabIndex = 47
        Me.LabelControl24.Text = "TT tiền mặt"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Location = New System.Drawing.Point(8, 67)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl31.TabIndex = 45
        Me.LabelControl31.Text = "Giảm giá"
        '
        'labelControl21
        '
        Me.labelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl21.Location = New System.Drawing.Point(8, 43)
        Me.labelControl21.Name = "labelControl21"
        Me.labelControl21.Size = New System.Drawing.Size(55, 13)
        Me.labelControl21.TabIndex = 43
        Me.labelControl21.Text = "Tiền hàng"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(8, 92)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl22.TabIndex = 46
        Me.LabelControl22.Text = "Tổng TT"
        '
        '_pnVatTu
        '
        Me._pnVatTu.Controls.Add(Me.txtGiamGia)
        Me._pnVatTu.Controls.Add(Me.LabelControl23)
        Me._pnVatTu.Controls.Add(Me.txtTienHang)
        Me._pnVatTu.Controls.Add(Me.txtTongCong)
        Me._pnVatTu.Location = New System.Drawing.Point(66, 6)
        Me._pnVatTu.Name = "_pnVatTu"
        Me._pnVatTu.Size = New System.Drawing.Size(114, 110)
        Me._pnVatTu.TabIndex = 40
        '
        'txtGiamGia
        '
        Me.txtGiamGia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGiamGia.EnterMoveNextControl = True
        Me.txtGiamGia.Location = New System.Drawing.Point(5, 55)
        Me.txtGiamGia.Name = "txtGiamGia"
        Me.txtGiamGia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiamGia.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtGiamGia.Properties.Appearance.Options.UseFont = True
        Me.txtGiamGia.Properties.Appearance.Options.UseForeColor = True
        Me.txtGiamGia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGiamGia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGiamGia.Properties.Mask.EditMask = "n0"
        Me.txtGiamGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGiamGia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGiamGia.Properties.ReadOnly = True
        Me.txtGiamGia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGiamGia.Size = New System.Drawing.Size(100, 20)
        Me.txtGiamGia.TabIndex = 2
        Me.txtGiamGia.TabStop = False
        '
        'LabelControl23
        '
        Me.LabelControl23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl23.TabIndex = 36
        Me.LabelControl23.Text = "Tiền hàng"
        '
        'txtTienHang
        '
        Me.txtTienHang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTienHang.EnterMoveNextControl = True
        Me.txtTienHang.Location = New System.Drawing.Point(5, 28)
        Me.txtTienHang.Name = "txtTienHang"
        Me.txtTienHang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTienHang.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTienHang.Properties.Appearance.Options.UseFont = True
        Me.txtTienHang.Properties.Appearance.Options.UseForeColor = True
        Me.txtTienHang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienHang.Properties.Mask.EditMask = "n0"
        Me.txtTienHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienHang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienHang.Properties.ReadOnly = True
        Me.txtTienHang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTienHang.Size = New System.Drawing.Size(100, 20)
        Me.txtTienHang.TabIndex = 1
        Me.txtTienHang.TabStop = False
        '
        'txtTongCong
        '
        Me.txtTongCong.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTongCong.EnterMoveNextControl = True
        Me.txtTongCong.Location = New System.Drawing.Point(5, 83)
        Me.txtTongCong.Name = "txtTongCong"
        Me.txtTongCong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongCong.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTongCong.Properties.Appearance.Options.UseFont = True
        Me.txtTongCong.Properties.Appearance.Options.UseForeColor = True
        Me.txtTongCong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongCong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongCong.Properties.Mask.EditMask = "n0"
        Me.txtTongCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongCong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongCong.Properties.ReadOnly = True
        Me.txtTongCong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTongCong.Size = New System.Drawing.Size(100, 20)
        Me.txtTongCong.TabIndex = 3
        Me.txtTongCong.TabStop = False
        '
        '_pnTongCong
        '
        Me._pnTongCong.Controls.Add(Me.txtTongTienTT)
        Me._pnTongCong.Controls.Add(Me.txtGiamGiaTong)
        Me._pnTongCong.Controls.Add(Me.txtTongTienHang)
        Me._pnTongCong.Controls.Add(Me.labelControl64)
        Me._pnTongCong.Location = New System.Drawing.Point(311, 6)
        Me._pnTongCong.Name = "_pnTongCong"
        Me._pnTongCong.Size = New System.Drawing.Size(114, 110)
        Me._pnTongCong.TabIndex = 42
        '
        'txtTongTienTT
        '
        Me.txtTongTienTT.EnterMoveNextControl = True
        Me.txtTongTienTT.Location = New System.Drawing.Point(5, 82)
        Me.txtTongTienTT.Name = "txtTongTienTT"
        Me.txtTongTienTT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongTienTT.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTongTienTT.Properties.Appearance.Options.UseFont = True
        Me.txtTongTienTT.Properties.Appearance.Options.UseForeColor = True
        Me.txtTongTienTT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongTienTT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongTienTT.Properties.Mask.EditMask = "n0"
        Me.txtTongTienTT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTienTT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTienTT.Properties.ReadOnly = True
        Me.txtTongTienTT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTongTienTT.Size = New System.Drawing.Size(100, 20)
        Me.txtTongTienTT.TabIndex = 2
        Me.txtTongTienTT.TabStop = False
        '
        'txtGiamGiaTong
        '
        Me.txtGiamGiaTong.EnterMoveNextControl = True
        Me.txtGiamGiaTong.Location = New System.Drawing.Point(5, 56)
        Me.txtGiamGiaTong.Name = "txtGiamGiaTong"
        Me.txtGiamGiaTong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiamGiaTong.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtGiamGiaTong.Properties.Appearance.Options.UseFont = True
        Me.txtGiamGiaTong.Properties.Appearance.Options.UseForeColor = True
        Me.txtGiamGiaTong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGiamGiaTong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGiamGiaTong.Properties.Mask.EditMask = "n0"
        Me.txtGiamGiaTong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGiamGiaTong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGiamGiaTong.Properties.ReadOnly = True
        Me.txtGiamGiaTong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGiamGiaTong.Size = New System.Drawing.Size(100, 20)
        Me.txtGiamGiaTong.TabIndex = 0
        Me.txtGiamGiaTong.TabStop = False
        '
        'txtTongTienHang
        '
        Me.txtTongTienHang.EnterMoveNextControl = True
        Me.txtTongTienHang.Location = New System.Drawing.Point(5, 29)
        Me.txtTongTienHang.Name = "txtTongTienHang"
        Me.txtTongTienHang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongTienHang.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTongTienHang.Properties.Appearance.Options.UseFont = True
        Me.txtTongTienHang.Properties.Appearance.Options.UseForeColor = True
        Me.txtTongTienHang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongTienHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongTienHang.Properties.Mask.EditMask = "n0"
        Me.txtTongTienHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTienHang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTienHang.Properties.ReadOnly = True
        Me.txtTongTienHang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTongTienHang.Size = New System.Drawing.Size(100, 20)
        Me.txtTongTienHang.TabIndex = 0
        Me.txtTongTienHang.TabStop = False
        '
        'labelControl64
        '
        Me.labelControl64.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl64.Location = New System.Drawing.Point(5, 8)
        Me.labelControl64.Name = "labelControl64"
        Me.labelControl64.Size = New System.Drawing.Size(58, 13)
        Me.labelControl64.TabIndex = 114
        Me.labelControl64.Text = "Tổng cộng"
        '
        '_pnTienCong
        '
        Me._pnTienCong.Controls.Add(Me.txtTongCongSC)
        Me._pnTienCong.Controls.Add(Me.txtGiamGiaSC)
        Me._pnTienCong.Controls.Add(Me.txtTienCongSC)
        Me._pnTienCong.Controls.Add(Me.labelControl63)
        Me._pnTienCong.Location = New System.Drawing.Point(191, 6)
        Me._pnTienCong.Name = "_pnTienCong"
        Me._pnTienCong.Size = New System.Drawing.Size(114, 110)
        Me._pnTienCong.TabIndex = 41
        '
        'txtTongCongSC
        '
        Me.txtTongCongSC.EnterMoveNextControl = True
        Me.txtTongCongSC.Location = New System.Drawing.Point(5, 83)
        Me.txtTongCongSC.Name = "txtTongCongSC"
        Me.txtTongCongSC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongCongSC.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTongCongSC.Properties.Appearance.Options.UseFont = True
        Me.txtTongCongSC.Properties.Appearance.Options.UseForeColor = True
        Me.txtTongCongSC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongCongSC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongCongSC.Properties.Mask.EditMask = "n0"
        Me.txtTongCongSC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongCongSC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongCongSC.Properties.ReadOnly = True
        Me.txtTongCongSC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTongCongSC.Size = New System.Drawing.Size(100, 20)
        Me.txtTongCongSC.TabIndex = 2
        Me.txtTongCongSC.TabStop = False
        '
        'txtGiamGiaSC
        '
        Me.txtGiamGiaSC.EnterMoveNextControl = True
        Me.txtGiamGiaSC.Location = New System.Drawing.Point(5, 56)
        Me.txtGiamGiaSC.Name = "txtGiamGiaSC"
        Me.txtGiamGiaSC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiamGiaSC.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtGiamGiaSC.Properties.Appearance.Options.UseFont = True
        Me.txtGiamGiaSC.Properties.Appearance.Options.UseForeColor = True
        Me.txtGiamGiaSC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGiamGiaSC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGiamGiaSC.Properties.Mask.EditMask = "n0"
        Me.txtGiamGiaSC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGiamGiaSC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGiamGiaSC.Properties.ReadOnly = True
        Me.txtGiamGiaSC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGiamGiaSC.Size = New System.Drawing.Size(100, 20)
        Me.txtGiamGiaSC.TabIndex = 0
        Me.txtGiamGiaSC.TabStop = False
        '
        'txtTienCongSC
        '
        Me.txtTienCongSC.EnterMoveNextControl = True
        Me.txtTienCongSC.Location = New System.Drawing.Point(5, 29)
        Me.txtTienCongSC.Name = "txtTienCongSC"
        Me.txtTienCongSC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTienCongSC.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTienCongSC.Properties.Appearance.Options.UseFont = True
        Me.txtTienCongSC.Properties.Appearance.Options.UseForeColor = True
        Me.txtTienCongSC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienCongSC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienCongSC.Properties.Mask.EditMask = "n0"
        Me.txtTienCongSC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienCongSC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienCongSC.Properties.ReadOnly = True
        Me.txtTienCongSC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTienCongSC.Size = New System.Drawing.Size(100, 20)
        Me.txtTienCongSC.TabIndex = 0
        Me.txtTienCongSC.TabStop = False
        '
        'labelControl63
        '
        Me.labelControl63.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl63.Location = New System.Drawing.Point(5, 8)
        Me.labelControl63.Name = "labelControl63"
        Me.labelControl63.Size = New System.Drawing.Size(67, 13)
        Me.labelControl63.TabIndex = 113
        Me.labelControl63.Text = "Tiền dịch vụ"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtDenGio)
        Me.GroupControl1.Controls.Add(Me.txtTuGio)
        Me.GroupControl1.Controls.Add(Me.cFilterKhachHang)
        Me.GroupControl1.Controls.Add(Me.cboGiuongDV)
        Me.GroupControl1.Controls.Add(Me.cboNhanVien)
        Me.GroupControl1.Controls.Add(Me.cboLoaiCT)
        Me.GroupControl1.Controls.Add(Me.txtGhiChu)
        Me.GroupControl1.Controls.Add(Me.txtTenNhanVien)
        Me.GroupControl1.Controls.Add(Me.txtTenKH)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.dteNgayCT)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(774, 135)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'txtDenGio
        '
        Me.txtDenGio.EditValue = New Date(2013, 5, 21, 0, 0, 0, 0)
        Me.txtDenGio.EnterMoveNextControl = True
        Me.txtDenGio.Location = New System.Drawing.Point(66, 109)
        Me.txtDenGio.Name = "txtDenGio"
        Me.txtDenGio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDenGio.Properties.Mask.EditMask = "HH:mm"
        Me.txtDenGio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtDenGio.Size = New System.Drawing.Size(100, 20)
        Me.txtDenGio.TabIndex = 4
        '
        'txtTuGio
        '
        Me.txtTuGio.EditValue = New Date(2013, 5, 21, 0, 0, 0, 0)
        Me.txtTuGio.EnterMoveNextControl = True
        Me.txtTuGio.Location = New System.Drawing.Point(66, 84)
        Me.txtTuGio.Name = "txtTuGio"
        Me.txtTuGio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTuGio.Properties.Mask.EditMask = "HH:mm"
        Me.txtTuGio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtTuGio.Size = New System.Drawing.Size(100, 20)
        Me.txtTuGio.TabIndex = 3
        '
        'cFilterKhachHang
        '
        Me.cFilterKhachHang.AllowNull = True
        Me.cFilterKhachHang.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MA_KHANG--0-0;MaSoThue--0-0;DiaChi" & _
            "--0-0"
        Me.cFilterKhachHang.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.cFilterKhachHang.C_DATA_SOURCE = Nothing
        Me.cFilterKhachHang.C_FORM_DANHSACH = "Admin.VbAdminGUI.DanhMuc.frmDanhMucKhachHang_ChiTiet"
        Me.cFilterKhachHang.C_FORM_TITLE = "Chọn khách hàng"
        Me.cFilterKhachHang.C_IS_CHECK_NUMBER = "="
        Me.cFilterKhachHang.C_IS_CHECK_OTHER = "="
        Me.cFilterKhachHang.C_IS_CHECK_STRING = "="
        Me.cFilterKhachHang.C_IS_FILTER_STRING = ""
        Me.cFilterKhachHang.C_IS_QUICKADD = False
        Me.cFilterKhachHang.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterKhachHang.C_KEY_NAME = "KyHieu"
        Me.cFilterKhachHang.EditValue = ""
        Me.cFilterKhachHang.EditValues = ""
        Me.cFilterKhachHang.ENABLES = True
        Me.cFilterKhachHang.IsNotTextChanged = True
        Me.cFilterKhachHang.ListEditValue = CType(resources.GetObject("cFilterKhachHang.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterKhachHang.Location = New System.Drawing.Point(315, 10)
        Me.cFilterKhachHang.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterKhachHang.Name = "cFilterKhachHang"
        Me.cFilterKhachHang.NEXT_TAB = 0
        Me.cFilterKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.cFilterKhachHang.TabIndex = 5
        '
        'cboGiuongDV
        '
        Me.cboGiuongDV.EnterMoveNextControl = True
        Me.cboGiuongDV.Location = New System.Drawing.Point(315, 59)
        Me.cboGiuongDV.Name = "cboGiuongDV"
        Me.cboGiuongDV.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboGiuongDV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGiuongDV.Properties.NullText = ""
        Me.cboGiuongDV.Properties.View = Me.GridView3
        Me.cboGiuongDV.Size = New System.Drawing.Size(100, 20)
        Me.cboGiuongDV.TabIndex = 7
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ma, Me.Ten})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'Ma
        '
        Me.Ma.Caption = "Mã giường DV"
        Me.Ma.FieldName = "Ma"
        Me.Ma.Name = "Ma"
        Me.Ma.Visible = True
        Me.Ma.VisibleIndex = 0
        '
        'Ten
        '
        Me.Ten.Caption = "Tên giường DV"
        Me.Ten.FieldName = "Ten"
        Me.Ten.Name = "Ten"
        Me.Ten.Visible = True
        Me.Ten.VisibleIndex = 1
        '
        'cboNhanVien
        '
        Me.cboNhanVien.EnterMoveNextControl = True
        Me.cboNhanVien.Location = New System.Drawing.Point(315, 33)
        Me.cboNhanVien.Name = "cboNhanVien"
        Me.cboNhanVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboNhanVien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNhanVien.Properties.NullText = ""
        Me.cboNhanVien.Properties.View = Me.GridView2
        Me.cboNhanVien.Size = New System.Drawing.Size(100, 20)
        Me.cboNhanVien.TabIndex = 6
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Manhanvien, Me.Tennhanvien})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Manhanvien
        '
        Me.Manhanvien.Caption = "Mã nhân viên"
        Me.Manhanvien.FieldName = "Ma"
        Me.Manhanvien.Name = "Manhanvien"
        Me.Manhanvien.Visible = True
        Me.Manhanvien.VisibleIndex = 0
        '
        'Tennhanvien
        '
        Me.Tennhanvien.Caption = "Tên nhân viên"
        Me.Tennhanvien.FieldName = "Ten"
        Me.Tennhanvien.Name = "Tennhanvien"
        Me.Tennhanvien.Visible = True
        Me.Tennhanvien.VisibleIndex = 1
        '
        'cboLoaiCT
        '
        Me.cboLoaiCT.EnterMoveNextControl = True
        Me.cboLoaiCT.Location = New System.Drawing.Point(66, 8)
        Me.cboLoaiCT.Name = "cboLoaiCT"
        Me.cboLoaiCT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoaiCT.Properties.NullText = ""
        Me.cboLoaiCT.Properties.View = Me.GridLookUpEdit1View
        Me.cboLoaiCT.Size = New System.Drawing.Size(100, 20)
        Me.cboLoaiCT.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaLoaiCt, Me.TenLoaiCt})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'MaLoaiCt
        '
        Me.MaLoaiCt.Caption = "Mã loại CT"
        Me.MaLoaiCt.FieldName = "MaLoaiCt"
        Me.MaLoaiCt.Name = "MaLoaiCt"
        Me.MaLoaiCt.Visible = True
        Me.MaLoaiCt.VisibleIndex = 0
        '
        'TenLoaiCt
        '
        Me.TenLoaiCt.Caption = "Tên loại CT"
        Me.TenLoaiCt.FieldName = "TenLoaiCt"
        Me.TenLoaiCt.Name = "TenLoaiCt"
        Me.TenLoaiCt.Visible = True
        Me.TenLoaiCt.VisibleIndex = 1
        '
        'txtGhiChu
        '
        Me.txtGhiChu.EnterMoveNextControl = True
        Me.txtGhiChu.Location = New System.Drawing.Point(315, 85)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(451, 45)
        Me.txtGhiChu.TabIndex = 8
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.EnterMoveNextControl = True
        Me.txtTenNhanVien.Location = New System.Drawing.Point(503, 33)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Properties.ReadOnly = True
        Me.txtTenNhanVien.Size = New System.Drawing.Size(263, 20)
        Me.txtTenNhanVien.TabIndex = 3
        Me.txtTenNhanVien.TabStop = False
        '
        'txtTenKH
        '
        Me.txtTenKH.EnterMoveNextControl = True
        Me.txtTenKH.Location = New System.Drawing.Point(503, 7)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Properties.ReadOnly = True
        Me.txtTenKH.Size = New System.Drawing.Size(263, 20)
        Me.txtTenKH.TabIndex = 3
        Me.txtTenKH.TabStop = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(13, 114)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl16.TabIndex = 0
        Me.LabelControl16.Text = "Đến giờ"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(236, 88)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "Ghi chú"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(424, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Tên nhân viên"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(13, 88)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl15.TabIndex = 0
        Me.LabelControl15.Text = "Từ giờ"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(424, 11)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Tên khách hàng"
        '
        'dteNgayCT
        '
        Me.dteNgayCT.EditValue = Nothing
        Me.dteNgayCT.EnterMoveNextControl = True
        Me.dteNgayCT.Location = New System.Drawing.Point(66, 32)
        Me.dteNgayCT.Name = "dteNgayCT"
        Me.dteNgayCT.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteNgayCT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayCT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNgayCT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNgayCT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNgayCT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNgayCT.Size = New System.Drawing.Size(100, 20)
        Me.dteNgayCT.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Số CT"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(236, 37)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Nhân viên"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(236, 64)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "Giường"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(236, 11)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Mã khách hàng"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Ngày CT"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Loại CT"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.ControlNavigator1)
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.btnModify)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnQuit)
        Me.PanelControl2.Controls.Add(Me.btnPrinter)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl2.TabIndex = 1
        '
        'ControlNavigator1
        '
        Me.ControlNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ControlNavigator1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlNavigator1.Appearance.Options.UseFont = True
        Me.ControlNavigator1.Buttons.Append.Visible = False
        Me.ControlNavigator1.Buttons.CancelEdit.Visible = False
        Me.ControlNavigator1.Buttons.Edit.Visible = False
        Me.ControlNavigator1.Buttons.EndEdit.Visible = False
        Me.ControlNavigator1.Buttons.NextPage.Visible = False
        Me.ControlNavigator1.Buttons.PrevPage.Visible = False
        Me.ControlNavigator1.Buttons.Remove.Visible = False
        Me.ControlNavigator1.Location = New System.Drawing.Point(0, 4)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.grcCth_hddv
        Me.ControlNavigator1.Size = New System.Drawing.Size(221, 30)
        Me.ControlNavigator1.TabIndex = 18
        Me.ControlNavigator1.Text = "ControlNavigator4"
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.ControlNavigator1.TextStringFormat = " {0} / {1}"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ImageIndex = 0
        Me.btnSearch.Location = New System.Drawing.Point(600, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Tìm"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Appearance.Options.UseFont = True
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(342, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(256, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Thêm"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(428, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Xóa"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageIndex = 8
        Me.btnCancel.Location = New System.Drawing.Point(691, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "H&ủy"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Appearance.Options.UseFont = True
        Me.btnQuit.ImageIndex = 8
        Me.btnQuit.Location = New System.Drawing.Point(920, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "&Quay ra"
        '
        'btnPrinter
        '
        Me.btnPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrinter.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrinter.Appearance.Options.UseFont = True
        Me.btnPrinter.ImageIndex = 5
        Me.btnPrinter.Location = New System.Drawing.Point(777, 4)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(80, 30)
        Me.btnPrinter.TabIndex = 6
        Me.btnPrinter.Text = "&In"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(514, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Lưu"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "ĐVT"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Width = 56
        '
        'frmHDDV_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmHDDV_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Hóa đơn dịch vụ"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grcCth_hddv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCth_hddv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpHangHoa.ResumeLayout(False)
        CType(Me.grcHangHoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHangHoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfilter_HangHoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDichVu.ResumeLayout(False)
        CType(Me.grcDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfilter_DichVu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtConNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTTThe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTTTheNh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTTTienMat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pnVatTu, System.ComponentModel.ISupportInitialize).EndInit()
        Me._pnVatTu.ResumeLayout(False)
        Me._pnVatTu.PerformLayout()
        CType(Me.txtGiamGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongCong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pnTongCong, System.ComponentModel.ISupportInitialize).EndInit()
        Me._pnTongCong.ResumeLayout(False)
        Me._pnTongCong.PerformLayout()
        CType(Me.txtTongTienTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGiamGiaTong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTienHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pnTienCong, System.ComponentModel.ISupportInitialize).EndInit()
        Me._pnTienCong.ResumeLayout(False)
        Me._pnTienCong.PerformLayout()
        CType(Me.txtTongCongSC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGiamGiaSC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienCongSC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDenGio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTuGio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGiuongDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLoaiCT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenKH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayCT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayCT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrinter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Private WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpHangHoa As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDichVu As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grcCth_hddv As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCth_hddv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dteNgayCT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenKH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHangHoa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHangHoa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_HH_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOANH_THU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_GIAM_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_GIAM_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_HH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_HH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_MG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDichVu As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDichVu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_HH_DV_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOANH_THU_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_GIAM_GIA_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_GIAM_GIA_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_HH_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_HH_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_MG_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG_DV As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl21 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _pnVatTu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtGiamGia As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTienHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongCong As DevExpress.XtraEditors.TextEdit
    Private WithEvents _pnTongCong As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTongTienTT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGiamGiaTong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongTienHang As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl64 As DevExpress.XtraEditors.LabelControl
    Private WithEvents _pnTienCong As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTongCongSC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGiamGiaSC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTienCongSC As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongTT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTTThe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTTTheNh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTTTienMat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenNhanVien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboChonDichVu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboLoaiCT As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboNhanVien As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboGiuongDV As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cFilterKhachHang As CustomFilter
    Friend WithEvents cfilter_HangHoa As RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cFilterThe As CustomFilter
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDenGio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtTuGio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents MaLoaiCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenLoaiCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Manhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tennhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_SoChungTu As C_SoChungTu
    Friend WithEvents cfilter_DichVu As RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
