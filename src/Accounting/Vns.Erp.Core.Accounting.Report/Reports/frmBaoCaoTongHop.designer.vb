<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoTongHop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoTongHop))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TreeDsBang = New DevExpress.XtraTreeList.TreeList()
        Me.TEN_BAOCAO = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TEN_BANG_DULIEU = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.THU_TU = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpHeader = New DevExpress.XtraEditors.GroupControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcMain = New DevExpress.XtraGrid.GridControl()
        Me.grvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowSearchOption = New DevExpress.XtraEditors.SimpleButton()
        Me.MultiExportButton1 = New Vns.Erp.Core.MultiExportButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnxem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReportSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTemplate = New DevExpress.XtraEditors.LookUpEdit()
        Me.popupControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.popDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.popRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.popClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TreeDsBang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grpHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHeader.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cboTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "find_selection.png")
        Me.imgList.Images.SetKeyName(1, "selection.png")
        Me.imgList.Images.SetKeyName(2, "document_add.png")
        Me.imgList.Images.SetKeyName(3, "document_edit.png")
        Me.imgList.Images.SetKeyName(4, "document_view.png")
        Me.imgList.Images.SetKeyName(5, "document_delete.png")
        Me.imgList.Images.SetKeyName(6, "pcCloseButton.png")
        Me.imgList.Images.SetKeyName(7, "BtnSave.png")
        Me.imgList.Images.SetKeyName(8, "ButtonSaveAndClose.png")
        Me.imgList.Images.SetKeyName(9, "Copy of save-32x32.png")
        Me.imgList.Images.SetKeyName(10, "copy.png")
        Me.imgList.Images.SetKeyName(11, "export1.png")
        Me.imgList.Images.SetKeyName(12, "cashier.png")
        Me.imgList.Images.SetKeyName(13, "printer.png")
        Me.imgList.Images.SetKeyName(14, "EDITITEM.GIF")
        Me.imgList.Images.SetKeyName(15, "icon-excel-16x16.gif")
        Me.imgList.Images.SetKeyName(16, "cubes_yellow.png")
        Me.imgList.Images.SetKeyName(17, "cubes.png")
        Me.imgList.Images.SetKeyName(18, "cubes_blue.png")
        Me.imgList.Images.SetKeyName(19, "cubes_green.png")
        Me.imgList.Images.SetKeyName(20, "cube_blue.png")
        Me.imgList.Images.SetKeyName(21, "cube_green.png")
        Me.imgList.Images.SetKeyName(22, "cube_yellow.png")
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
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1101, 508)
        Me.SplitContainerControl2.SplitterPosition = 366
        Me.SplitContainerControl2.TabIndex = 3
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TreeDsBang)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(366, 508)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Danh mục báo cáo"
        '
        'TreeDsBang
        '
        Me.TreeDsBang.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TEN_BAOCAO, Me.TEN_BANG_DULIEU, Me.ID, Me.THU_TU})
        Me.TreeDsBang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeDsBang.KeyFieldName = "Id"
        Me.TreeDsBang.Location = New System.Drawing.Point(2, 22)
        Me.TreeDsBang.Name = "TreeDsBang"
        Me.TreeDsBang.OptionsBehavior.Editable = False
        Me.TreeDsBang.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.TreeDsBang.OptionsView.ShowColumns = False
        Me.TreeDsBang.ParentFieldName = "IdCha"
        Me.TreeDsBang.Size = New System.Drawing.Size(362, 484)
        Me.TreeDsBang.StateImageList = Me.ImageList1
        Me.TreeDsBang.TabIndex = 0
        '
        'TEN_BAOCAO
        '
        Me.TEN_BAOCAO.Caption = "TreeListColumn1"
        Me.TEN_BAOCAO.FieldName = "TenBaocao"
        Me.TEN_BAOCAO.Name = "TEN_BAOCAO"
        Me.TEN_BAOCAO.Visible = True
        Me.TEN_BAOCAO.VisibleIndex = 0
        '
        'TEN_BANG_DULIEU
        '
        Me.TEN_BANG_DULIEU.Caption = "TreeListColumn1"
        Me.TEN_BANG_DULIEU.FieldName = "TenBangDulieu"
        Me.TEN_BANG_DULIEU.Name = "TEN_BANG_DULIEU"
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "Id"
        Me.ID.Name = "ID"
        '
        'THU_TU
        '
        Me.THU_TU.Caption = "TreeListColumn1"
        Me.THU_TU.FieldName = "ThuTu"
        Me.THU_TU.Name = "THU_TU"
        Me.THU_TU.SortOrder = System.Windows.Forms.SortOrder.Ascending
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.gif")
        Me.ImageList1.Images.SetKeyName(1, "folder_delete.gif")
        Me.ImageList1.Images.SetKeyName(2, "folder_images.gif")
        Me.ImageList1.Images.SetKeyName(3, "folder_lock.gif")
        Me.ImageList1.Images.SetKeyName(4, "folder_new.gif")
        Me.ImageList1.Images.SetKeyName(5, "folder_page.gif")
        Me.ImageList1.Images.SetKeyName(6, "icon_airmail.gif")
        Me.ImageList1.Images.SetKeyName(7, "icon_alert.gif")
        Me.ImageList1.Images.SetKeyName(8, "icon_padlock.gif")
        Me.ImageList1.Images.SetKeyName(9, "note.gif")
        Me.ImageList1.Images.SetKeyName(10, "note_delete.gif")
        Me.ImageList1.Images.SetKeyName(11, "note_new.gif")
        Me.ImageList1.Images.SetKeyName(12, "page_edit.gif")
        Me.ImageList1.Images.SetKeyName(13, "action_save.gif")
        Me.ImageList1.Images.SetKeyName(14, "action_stop.gif")
        Me.ImageList1.Images.SetKeyName(15, "add.png")
        Me.ImageList1.Images.SetKeyName(16, "report.png")
        Me.ImageList1.Images.SetKeyName(17, "delete.png")
        Me.ImageList1.Images.SetKeyName(18, "script.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(729, 508)
        Me.PanelControl1.TabIndex = 8
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grpHeader)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(729, 508)
        Me.SplitContainerControl1.SplitterPosition = 170
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.FlowLayoutPanel1)
        Me.grpHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpHeader.Location = New System.Drawing.Point(0, 0)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(729, 170)
        Me.grpHeader.TabIndex = 0
        Me.grpHeader.Text = "Bảng dữ liệu"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.FlowLayoutPanel1.AllowDrop = True
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 22)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(725, 146)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcMain)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 40)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(729, 292)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grcMain
        '
        Me.grcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcMain.Location = New System.Drawing.Point(2, 2)
        Me.grcMain.MainView = Me.grvMain
        Me.grcMain.Name = "grcMain"
        Me.grcMain.Size = New System.Drawing.Size(725, 288)
        Me.grcMain.TabIndex = 0
        Me.grcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMain})
        '
        'grvMain
        '
        Me.grvMain.GridControl = Me.grcMain
        Me.grvMain.GroupPanelText = "Kéo một tiêu đề cột vào đây để nhóm theo cột đó"
        Me.grvMain.Name = "grvMain"
        Me.grvMain.OptionsBehavior.AllowIncrementalSearch = True
        Me.grvMain.OptionsBehavior.Editable = False
        Me.grvMain.OptionsCustomization.AllowRowSizing = True
        Me.grvMain.OptionsSelection.MultiSelect = True
        Me.grvMain.OptionsView.ColumnAutoWidth = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnShowSearchOption)
        Me.PanelControl2.Controls.Add(Me.MultiExportButton1)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.btnxem)
        Me.PanelControl2.Controls.Add(Me.btnReportSubmit)
        Me.PanelControl2.Controls.Add(Me.cboTemplate)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(729, 40)
        Me.PanelControl2.TabIndex = 7
        '
        'btnShowSearchOption
        '
        Me.btnShowSearchOption.ImageIndex = 5
        Me.btnShowSearchOption.ImageList = Me.imglImporter
        Me.btnShowSearchOption.Location = New System.Drawing.Point(369, 4)
        Me.btnShowSearchOption.Name = "btnShowSearchOption"
        Me.btnShowSearchOption.Size = New System.Drawing.Size(145, 30)
        Me.btnShowSearchOption.TabIndex = 8
        Me.btnShowSearchOption.Text = "Hộp tìm kiếm (Alt+Z)"
        '
        'MultiExportButton1
        '
        Me.MultiExportButton1.GRID_VIEW = Me.grvMain
        Me.MultiExportButton1.Location = New System.Drawing.Point(109, 4)
        Me.MultiExportButton1.Name = "MultiExportButton1"
        Me.MultiExportButton1.Size = New System.Drawing.Size(138, 30)
        Me.MultiExportButton1.TabIndex = 7
        Me.MultiExportButton1.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(538, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Mẫu"
        '
        'btnxem
        '
        Me.btnxem.ImageIndex = 8
        Me.btnxem.ImageList = Me.imglImporter
        Me.btnxem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnxem.Location = New System.Drawing.Point(2, 4)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(104, 30)
        Me.btnxem.TabIndex = 0
        Me.btnxem.Text = "Nhận (Alt+A)"
        '
        'btnReportSubmit
        '
        Me.btnReportSubmit.ImageIndex = 7
        Me.btnReportSubmit.ImageList = Me.imglImporter
        Me.btnReportSubmit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnReportSubmit.Location = New System.Drawing.Point(250, 4)
        Me.btnReportSubmit.Name = "btnReportSubmit"
        Me.btnReportSubmit.Size = New System.Drawing.Size(112, 30)
        Me.btnReportSubmit.TabIndex = 2
        Me.btnReportSubmit.Text = "Báo Cáo (Alt+R)"
        Me.btnReportSubmit.Visible = False
        '
        'cboTemplate
        '
        Me.cboTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTemplate.Location = New System.Drawing.Point(564, 10)
        Me.cboTemplate.Name = "cboTemplate"
        Me.cboTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTemplate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenFileBaocao", "Chọn mẫu báo cáo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUONG_DAN", "DUONG_DAN", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboTemplate.Properties.DisplayMember = "TenFileBaocao"
        Me.cboTemplate.Properties.NullText = ""
        Me.cboTemplate.Size = New System.Drawing.Size(160, 20)
        Me.cboTemplate.TabIndex = 1
        '
        'popupControl
        '
        Me.popupControl.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.popRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.popClose)})
        Me.popupControl.Manager = Me.BarManager1
        Me.popupControl.Name = "popupControl"
        '
        'popDetail
        '
        Me.popDetail.Caption = "Chi tiết chứng từ"
        Me.popDetail.Id = 0
        Me.popDetail.ImageIndex = 15
        Me.popDetail.Name = "popDetail"
        '
        'popRefresh
        '
        Me.popRefresh.Caption = "Làm mới danh sách"
        Me.popRefresh.Id = 1
        Me.popRefresh.ImageIndex = 8
        Me.popRefresh.Name = "popRefresh"
        '
        'popClose
        '
        Me.popClose.Caption = "Đóng"
        Me.popClose.Id = 2
        Me.popClose.ImageIndex = 31
        Me.popClose.Name = "popClose"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.imglImporter
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popDetail, Me.popRefresh, Me.popClose})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1101, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 508)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1101, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 508)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1101, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 508)
        '
        'frmBaoCaoTongHop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 508)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmBaoCaoTongHop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo tổng hợp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.TreeDsBang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grpHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHeader.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cboTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TreeDsBang As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TEN_BAOCAO As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TEN_BANG_DULIEU As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnxem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReportSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTemplate As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents popupControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MultiExportButton1 As MultiExportButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnShowSearchOption As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents THU_TU As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
