<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongTinTaiSan_DanhSach
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcTSCD = New DevExpress.XtraGrid.GridControl()
        Me.grvTSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MaTscd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenTscd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenLoaitaisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayMua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MD_TK_TS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MD_TK_KHAUHAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MD_TK_CHIPHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_KTKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_NAM_SD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUOC_SX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NAM_SX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.THONGSO_KYTHUAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.MultiExportButton1 = New Vns.Erp.Core.MultiExportButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        Me.txttenLoaiTS = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenTS = New DevExpress.XtraEditors.TextEdit()
        Me.dteDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dteTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.grlLoaiTSCD = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        CType(Me.txttenLoaiTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLoaiTSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcTSCD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 117)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 455)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Thông tin tài sản cố định"
        '
        'grcTSCD
        '
        Me.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcTSCD.Location = New System.Drawing.Point(2, 22)
        Me.grcTSCD.MainView = Me.grvTSCD
        Me.grcTSCD.Name = "grcTSCD"
        Me.grcTSCD.Size = New System.Drawing.Size(996, 431)
        Me.grcTSCD.TabIndex = 0
        Me.grcTSCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvTSCD})
        '
        'grvTSCD
        '
        Me.grvTSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaTscd, Me.TenTscd, Me.KyHieu, Me.TenLoaitaisan, Me.NgayMua, Me.MD_TK_TS, Me.MD_TK_KHAUHAO, Me.MD_TK_CHIPHI, Me.NGAY_BDSD, Me.NGAY_BDKH, Me.NGAY_KTKH, Me.SO_NAM_SD, Me.NUOC_SX, Me.NAM_SX, Me.THONGSO_KYTHUAT})
        Me.grvTSCD.GridControl = Me.grcTSCD
        Me.grvTSCD.Name = "grvTSCD"
        Me.grvTSCD.OptionsView.ColumnAutoWidth = False
        Me.grvTSCD.OptionsView.ShowGroupPanel = False
        '
        'MaTscd
        '
        Me.MaTscd.Caption = "Mã TSCD"
        Me.MaTscd.FieldName = "MaTscd"
        Me.MaTscd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.MaTscd.Name = "MaTscd"
        Me.MaTscd.OptionsColumn.ReadOnly = True
        Me.MaTscd.Visible = True
        Me.MaTscd.VisibleIndex = 0
        Me.MaTscd.Width = 100
        '
        'TenTscd
        '
        Me.TenTscd.Caption = "Tên TSCD"
        Me.TenTscd.FieldName = "TenTscd"
        Me.TenTscd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.TenTscd.Name = "TenTscd"
        Me.TenTscd.OptionsColumn.ReadOnly = True
        Me.TenTscd.Visible = True
        Me.TenTscd.VisibleIndex = 1
        Me.TenTscd.Width = 214
        '
        'KyHieu
        '
        Me.KyHieu.Caption = "Ký hiệu"
        Me.KyHieu.FieldName = "KyHieu"
        Me.KyHieu.Name = "KyHieu"
        Me.KyHieu.OptionsColumn.ReadOnly = True
        Me.KyHieu.Visible = True
        Me.KyHieu.VisibleIndex = 2
        Me.KyHieu.Width = 179
        '
        'TenLoaitaisan
        '
        Me.TenLoaitaisan.Caption = "Tên loại TSCD"
        Me.TenLoaitaisan.FieldName = "TenLoaitaisan"
        Me.TenLoaitaisan.Name = "TenLoaitaisan"
        Me.TenLoaitaisan.OptionsColumn.ReadOnly = True
        Me.TenLoaitaisan.Visible = True
        Me.TenLoaitaisan.VisibleIndex = 3
        Me.TenLoaitaisan.Width = 187
        '
        'NgayMua
        '
        Me.NgayMua.Caption = "Ngày mua"
        Me.NgayMua.FieldName = "NgayMua"
        Me.NgayMua.Name = "NgayMua"
        Me.NgayMua.OptionsColumn.AllowEdit = False
        Me.NgayMua.OptionsColumn.ReadOnly = True
        Me.NgayMua.Visible = True
        Me.NgayMua.VisibleIndex = 4
        Me.NgayMua.Width = 101
        '
        'MD_TK_TS
        '
        Me.MD_TK_TS.Caption = "Tài khoản tài sản"
        Me.MD_TK_TS.FieldName = "MaMdTkTs"
        Me.MD_TK_TS.Name = "MD_TK_TS"
        Me.MD_TK_TS.OptionsColumn.ReadOnly = True
        Me.MD_TK_TS.Visible = True
        Me.MD_TK_TS.VisibleIndex = 10
        Me.MD_TK_TS.Width = 102
        '
        'MD_TK_KHAUHAO
        '
        Me.MD_TK_KHAUHAO.Caption = "Tài khoản khấu hao"
        Me.MD_TK_KHAUHAO.FieldName = "MaMdTkKhauhao"
        Me.MD_TK_KHAUHAO.Name = "MD_TK_KHAUHAO"
        Me.MD_TK_KHAUHAO.OptionsColumn.ReadOnly = True
        Me.MD_TK_KHAUHAO.Visible = True
        Me.MD_TK_KHAUHAO.VisibleIndex = 9
        Me.MD_TK_KHAUHAO.Width = 118
        '
        'MD_TK_CHIPHI
        '
        Me.MD_TK_CHIPHI.Caption = "Tài khoản chi phí"
        Me.MD_TK_CHIPHI.FieldName = "MaMdTkChiphi"
        Me.MD_TK_CHIPHI.Name = "MD_TK_CHIPHI"
        Me.MD_TK_CHIPHI.OptionsColumn.ReadOnly = True
        Me.MD_TK_CHIPHI.Visible = True
        Me.MD_TK_CHIPHI.VisibleIndex = 8
        Me.MD_TK_CHIPHI.Width = 111
        '
        'NGAY_BDSD
        '
        Me.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng"
        Me.NGAY_BDSD.FieldName = "NgayBdsd"
        Me.NGAY_BDSD.Name = "NGAY_BDSD"
        Me.NGAY_BDSD.OptionsColumn.AllowEdit = False
        Me.NGAY_BDSD.OptionsColumn.ReadOnly = True
        Me.NGAY_BDSD.Visible = True
        Me.NGAY_BDSD.VisibleIndex = 6
        Me.NGAY_BDSD.Width = 135
        '
        'NGAY_BDKH
        '
        Me.NGAY_BDKH.Caption = "Ngày bắt đầu khấu hao"
        Me.NGAY_BDKH.FieldName = "NgayBdkh"
        Me.NGAY_BDKH.Name = "NGAY_BDKH"
        Me.NGAY_BDKH.OptionsColumn.AllowEdit = False
        Me.NGAY_BDKH.OptionsColumn.ReadOnly = True
        Me.NGAY_BDKH.Visible = True
        Me.NGAY_BDKH.VisibleIndex = 5
        Me.NGAY_BDKH.Width = 134
        '
        'NGAY_KTKH
        '
        Me.NGAY_KTKH.Caption = "Ngày kết thúc khấu hao"
        Me.NGAY_KTKH.FieldName = "NgayKtkh"
        Me.NGAY_KTKH.Name = "NGAY_KTKH"
        Me.NGAY_KTKH.OptionsColumn.AllowEdit = False
        Me.NGAY_KTKH.OptionsColumn.ReadOnly = True
        Me.NGAY_KTKH.Visible = True
        Me.NGAY_KTKH.VisibleIndex = 7
        Me.NGAY_KTKH.Width = 142
        '
        'SO_NAM_SD
        '
        Me.SO_NAM_SD.Caption = "Số tháng sử dụng"
        Me.SO_NAM_SD.FieldName = "SoThangSd"
        Me.SO_NAM_SD.Name = "SO_NAM_SD"
        Me.SO_NAM_SD.OptionsColumn.ReadOnly = True
        Me.SO_NAM_SD.Visible = True
        Me.SO_NAM_SD.VisibleIndex = 14
        Me.SO_NAM_SD.Width = 172
        '
        'NUOC_SX
        '
        Me.NUOC_SX.Caption = "Nước sản xuất"
        Me.NUOC_SX.FieldName = "NuocSx"
        Me.NUOC_SX.Name = "NUOC_SX"
        Me.NUOC_SX.OptionsColumn.ReadOnly = True
        Me.NUOC_SX.Visible = True
        Me.NUOC_SX.VisibleIndex = 12
        Me.NUOC_SX.Width = 99
        '
        'NAM_SX
        '
        Me.NAM_SX.Caption = "Năm sản xuất"
        Me.NAM_SX.FieldName = "NamSx"
        Me.NAM_SX.Name = "NAM_SX"
        Me.NAM_SX.OptionsColumn.ReadOnly = True
        Me.NAM_SX.Visible = True
        Me.NAM_SX.VisibleIndex = 11
        Me.NAM_SX.Width = 91
        '
        'THONGSO_KYTHUAT
        '
        Me.THONGSO_KYTHUAT.Caption = "Thông số kỹ thuật"
        Me.THONGSO_KYTHUAT.FieldName = "ThongsoKythuat"
        Me.THONGSO_KYTHUAT.Name = "THONGSO_KYTHUAT"
        Me.THONGSO_KYTHUAT.OptionsColumn.ReadOnly = True
        Me.THONGSO_KYTHUAT.Visible = True
        Me.THONGSO_KYTHUAT.VisibleIndex = 13
        Me.THONGSO_KYTHUAT.Width = 111
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Controls.Add(Me.MultiExportButton1)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Controls.Add(Me.btnAdd)
        Me._ActionPanel.Controls.Add(Me.btnPrint)
        Me._ActionPanel.Controls.Add(Me.btnXem)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 572)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(1000, 36)
        Me._ActionPanel.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.Location = New System.Drawing.Point(172, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Xóa"
        '
        'MultiExportButton1
        '
        Me.MultiExportButton1.GRID_VIEW = Me.grvTSCD
        Me.MultiExportButton1.Location = New System.Drawing.Point(528, 4)
        Me.MultiExportButton1.Name = "MultiExportButton1"
        Me.MultiExportButton1.Size = New System.Drawing.Size(135, 30)
        Me.MultiExportButton1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(919, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Ðó&ng"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 3
        Me.btnModify.Location = New System.Drawing.Point(86, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(2, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ImageIndex = 5
        Me.btnPrint.Location = New System.Drawing.Point(258, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "&In"
        '
        'btnXem
        '
        Me.btnXem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXem.ImageIndex = 5
        Me.btnXem.Location = New System.Drawing.Point(344, 4)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(80, 30)
        Me.btnXem.TabIndex = 2
        Me.btnXem.Text = "X&em"
        Me.btnXem.Visible = False
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me.txttenLoaiTS)
        Me._GroupControlSearch.Controls.Add(Me.txtTenTS)
        Me._GroupControlSearch.Controls.Add(Me.dteDenNgay)
        Me._GroupControlSearch.Controls.Add(Me.LabelControl5)
        Me._GroupControlSearch.Controls.Add(Me.dteTuNgay)
        Me._GroupControlSearch.Controls.Add(Me.LabelControl4)
        Me._GroupControlSearch.Controls.Add(Me.btnSearch)
        Me._GroupControlSearch.Controls.Add(Me.grlLoaiTSCD)
        Me._GroupControlSearch.Controls.Add(Me.LabelControl3)
        Me._GroupControlSearch.Controls.Add(Me.LabelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(1000, 109)
        Me._GroupControlSearch.TabIndex = 0
        Me._GroupControlSearch.Text = "Tìm kiếm"
        '
        'txttenLoaiTS
        '
        Me.txttenLoaiTS.Location = New System.Drawing.Point(181, 53)
        Me.txttenLoaiTS.Name = "txttenLoaiTS"
        Me.txttenLoaiTS.Properties.ReadOnly = True
        Me.txttenLoaiTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttenLoaiTS.Size = New System.Drawing.Size(172, 20)
        Me.txttenLoaiTS.TabIndex = 14
        Me.txttenLoaiTS.TabStop = False
        '
        'txtTenTS
        '
        Me.txtTenTS.EnterMoveNextControl = True
        Me.txtTenTS.Location = New System.Drawing.Point(75, 77)
        Me.txtTenTS.Name = "txtTenTS"
        Me.txtTenTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTenTS.Size = New System.Drawing.Size(278, 20)
        Me.txtTenTS.TabIndex = 3
        '
        'dteDenNgay
        '
        Me.dteDenNgay.EditValue = Nothing
        Me.dteDenNgay.EnterMoveNextControl = True
        Me.dteDenNgay.Location = New System.Drawing.Point(253, 27)
        Me.dteDenNgay.Name = "dteDenNgay"
        Me.dteDenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteDenNgay.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteDenNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteDenNgay.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(194, 30)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Đến ngày"
        '
        'dteTuNgay
        '
        Me.dteTuNgay.EditValue = Nothing
        Me.dteTuNgay.EnterMoveNextControl = True
        Me.dteTuNgay.Location = New System.Drawing.Point(75, 27)
        Me.dteTuNgay.Name = "dteTuNgay"
        Me.dteTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteTuNgay.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteTuNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteTuNgay.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Từ ngày"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(359, 67)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Tìm kiếm"
        '
        'grlLoaiTSCD
        '
        Me.grlLoaiTSCD.EnterMoveNextControl = True
        Me.grlLoaiTSCD.Location = New System.Drawing.Point(75, 53)
        Me.grlLoaiTSCD.Name = "grlLoaiTSCD"
        Me.grlLoaiTSCD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlLoaiTSCD.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlLoaiTSCD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLoaiTSCD.Properties.ImmediatePopup = True
        Me.grlLoaiTSCD.Properties.NullText = ""
        Me.grlLoaiTSCD.Properties.View = Me.GridView2
        Me.grlLoaiTSCD.Size = New System.Drawing.Size(100, 20)
        Me.grlLoaiTSCD.TabIndex = 2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Loại TSCD"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Tên TSCD"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(4, 113)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 4)
        Me.PanelControl1.TabIndex = 27
        '
        'frmThongTinTaiSan_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me._GroupControlSearch)
        Me.Controls.Add(Me._ActionPanel)
        Me.KeyPreview = True
        Me.Name = "frmThongTinTaiSan_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Thông tin tài sản cố định"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        CType(Me.txttenLoaiTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLoaiTSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcTSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvTSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MA_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_LOAITAISAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUOC_SX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NAM_SX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents THONGSO_KYTHUAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_MUA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_KTKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NAM_SD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_TS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_KHAUHAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_CHIPHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txttenLoaiTS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenTS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteDenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteTuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grlLoaiTSCD As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MultiExportButton1 As Vns.Erp.Core.MultiExportButton
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MaTscd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenTscd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenLoaitaisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayMua As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
End Class
