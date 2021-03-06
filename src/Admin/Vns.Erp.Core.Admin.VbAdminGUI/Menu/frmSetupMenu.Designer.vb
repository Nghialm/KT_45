Partial Class frmSetupMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupMenu))
        Me.DefaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.panelGroupDetail = New DevExpress.XtraEditors.PanelControl()
        Me.btnNotChoise = New DevExpress.XtraEditors.SimpleButton()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFromC = New DevExpress.XtraEditors.SimpleButton()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFromR = New DevExpress.XtraEditors.SimpleButton()
        Me.txtResourceName = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.popDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.popCopy = New DevExpress.XtraBars.BarButtonItem()
        Me.popMove = New DevExpress.XtraBars.BarButtonItem()
        Me.picPreview = New DevExpress.XtraEditors.PictureEdit()
        Me.btnSaveResource = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGroupIndex = New DevExpress.XtraEditors.TextEdit()
        Me.txtGroupId = New DevExpress.XtraEditors.TextEdit()
        Me.txtGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.groupMain = New DevExpress.XtraEditors.GroupControl()
        Me.groupForms = New DevExpress.XtraEditors.GroupControl()
        Me.listForms = New DevExpress.XtraTreeList.TreeList()
        Me.FORMTEXT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList(Me.components)
        Me.listOriginal = New DevExpress.XtraTreeList.TreeList()
        Me.GROUP_TEN = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.GROUP_ORDER = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.groupDetail = New DevExpress.XtraEditors.GroupControl()
        Me.pncInput = New DevExpress.XtraEditors.PanelControl()
        Me.chkIsShowDialog = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFormName = New DevExpress.XtraEditors.TextEdit()
        Me.lblError = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGroupFormsID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFormOrder = New DevExpress.XtraEditors.TextEdit()
        Me.txtFormText = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFormID = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.popControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.panelGroupDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGroupDetail.SuspendLayout()
        CType(Me.txtResourceName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupIndex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl.SuspendLayout()
        CType(Me.groupMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupMain.SuspendLayout()
        CType(Me.groupForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupForms.SuspendLayout()
        CType(Me.listForms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupDetail.SuspendLayout()
        CType(Me.pncInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pncInput.SuspendLayout()
        CType(Me.chkIsShowDialog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupFormsID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel
        '
        Me.DefaultLookAndFeel.LookAndFeel.SkinName = "Blue"
        '
        'panelGroupDetail
        '
        Me.panelGroupDetail.Controls.Add(Me.btnNotChoise)
        Me.panelGroupDetail.Controls.Add(Me.btnFromC)
        Me.panelGroupDetail.Controls.Add(Me.btnFromR)
        Me.panelGroupDetail.Controls.Add(Me.txtResourceName)
        Me.panelGroupDetail.Controls.Add(Me.picPreview)
        Me.panelGroupDetail.Controls.Add(Me.btnSaveResource)
        Me.panelGroupDetail.Controls.Add(Me.txtGroupIndex)
        Me.panelGroupDetail.Controls.Add(Me.txtGroupId)
        Me.panelGroupDetail.Controls.Add(Me.txtGroupName)
        Me.panelGroupDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelGroupDetail.Location = New System.Drawing.Point(2, 551)
        Me.panelGroupDetail.Name = "panelGroupDetail"
        Me.panelGroupDetail.Size = New System.Drawing.Size(604, 69)
        Me.panelGroupDetail.TabIndex = 1
        '
        'btnNotChoise
        '
        Me.btnNotChoise.ImageIndex = 32
        Me.btnNotChoise.ImageList = Me.imglImporter
        Me.btnNotChoise.Location = New System.Drawing.Point(342, 31)
        Me.btnNotChoise.Name = "btnNotChoise"
        Me.btnNotChoise.Size = New System.Drawing.Size(109, 30)
        Me.btnNotChoise.TabIndex = 16
        Me.btnNotChoise.Text = "Không dùng icon"
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
        'btnFromC
        '
        Me.btnFromC.ImageIndex = 11
        Me.btnFromC.ImageList = Me.imgList
        Me.btnFromC.Location = New System.Drawing.Point(194, 31)
        Me.btnFromC.Name = "btnFromC"
        Me.btnFromC.Size = New System.Drawing.Size(142, 30)
        Me.btnFromC.TabIndex = 15
        Me.btnFromC.Text = "Chọn icon từ máy tính"
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
        'btnFromR
        '
        Me.btnFromR.ImageIndex = 6
        Me.btnFromR.ImageList = Me.imglImporter
        Me.btnFromR.Location = New System.Drawing.Point(72, 31)
        Me.btnFromR.Name = "btnFromR"
        Me.btnFromR.Size = New System.Drawing.Size(116, 30)
        Me.btnFromR.TabIndex = 14
        Me.btnFromR.Text = "Chọn icon có sẵn"
        '
        'txtResourceName
        '
        Me.txtResourceName.Location = New System.Drawing.Point(72, 6)
        Me.txtResourceName.MenuManager = Me.BarManager1
        Me.txtResourceName.Name = "txtResourceName"
        Me.txtResourceName.Size = New System.Drawing.Size(448, 20)
        Me.txtResourceName.TabIndex = 13
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popDelete, Me.popCopy, Me.popMove})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1222, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 622)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1222, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 622)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1222, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 622)
        '
        'popDelete
        '
        Me.popDelete.Caption = "&Xóa chức năng"
        Me.popDelete.Id = 0
        Me.popDelete.Name = "popDelete"
        '
        'popCopy
        '
        Me.popCopy.Caption = "&Sao chép tới ..."
        Me.popCopy.Id = 1
        Me.popCopy.Name = "popCopy"
        '
        'popMove
        '
        Me.popMove.Caption = "&Di chuyển tới ..."
        Me.popMove.Id = 2
        Me.popMove.Name = "popMove"
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(10, 6)
        Me.picPreview.MenuManager = Me.BarManager1
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(55, 55)
        Me.picPreview.TabIndex = 12
        '
        'btnSaveResource
        '
        Me.btnSaveResource.ImageIndex = 13
        Me.btnSaveResource.ImageList = Me.imglImporter
        Me.btnSaveResource.Location = New System.Drawing.Point(457, 31)
        Me.btnSaveResource.Name = "btnSaveResource"
        Me.btnSaveResource.Size = New System.Drawing.Size(63, 30)
        Me.btnSaveResource.TabIndex = 9
        Me.btnSaveResource.Text = "Lưu"
        '
        'txtGroupIndex
        '
        Me.txtGroupIndex.Enabled = False
        Me.txtGroupIndex.Location = New System.Drawing.Point(563, 42)
        Me.txtGroupIndex.Name = "txtGroupIndex"
        Me.txtGroupIndex.Size = New System.Drawing.Size(35, 20)
        Me.txtGroupIndex.TabIndex = 6
        '
        'txtGroupId
        '
        Me.txtGroupId.Enabled = False
        Me.txtGroupId.Location = New System.Drawing.Point(526, 16)
        Me.txtGroupId.Name = "txtGroupId"
        Me.txtGroupId.Size = New System.Drawing.Size(31, 20)
        Me.txtGroupId.TabIndex = 5
        '
        'txtGroupName
        '
        Me.txtGroupName.Enabled = False
        Me.txtGroupName.Location = New System.Drawing.Point(563, 16)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(35, 20)
        Me.txtGroupName.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 3
        Me.btnSave.ImageList = Me.imgList
        Me.btnSave.Location = New System.Drawing.Point(96, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Lưu"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.ImageList = Me.imgList
        Me.btnAdd.Location = New System.Drawing.Point(10, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Thêm mới"
        '
        'SplitContainerControl
        '
        Me.SplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl.Name = "SplitContainerControl"
        Me.SplitContainerControl.Panel1.Controls.Add(Me.groupMain)
        Me.SplitContainerControl.Panel1.Text = "Panel1"
        Me.SplitContainerControl.Panel2.Controls.Add(Me.groupDetail)
        Me.SplitContainerControl.Panel2.Text = "Panel2"
        Me.SplitContainerControl.Size = New System.Drawing.Size(1222, 622)
        Me.SplitContainerControl.SplitterPosition = 608
        Me.SplitContainerControl.TabIndex = 2
        Me.SplitContainerControl.Text = "SplitContainerControl1"
        '
        'groupMain
        '
        Me.groupMain.Controls.Add(Me.groupForms)
        Me.groupMain.Controls.Add(Me.listOriginal)
        Me.groupMain.Controls.Add(Me.panelGroupDetail)
        Me.groupMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupMain.Location = New System.Drawing.Point(0, 0)
        Me.groupMain.Name = "groupMain"
        Me.groupMain.Size = New System.Drawing.Size(608, 622)
        Me.groupMain.TabIndex = 2
        Me.groupMain.Text = "Danh mục nhóm chức năng"
        '
        'groupForms
        '
        Me.groupForms.Controls.Add(Me.listForms)
        Me.groupForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupForms.Location = New System.Drawing.Point(338, 22)
        Me.groupForms.Name = "groupForms"
        Me.groupForms.Size = New System.Drawing.Size(268, 529)
        Me.groupForms.TabIndex = 4
        Me.groupForms.Text = "Danh sách chức năng"
        '
        'listForms
        '
        Me.listForms.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.FORMTEXT})
        Me.listForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listForms.KeyFieldName = ""
        Me.listForms.Location = New System.Drawing.Point(2, 22)
        Me.listForms.Name = "listForms"
        Me.listForms.OptionsBehavior.Editable = False
        Me.listForms.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listForms.OptionsView.ShowColumns = False
        Me.listForms.OptionsView.ShowIndicator = False
        Me.listForms.ParentFieldName = ""
        Me.listForms.SelectImageList = Me.imgAll
        Me.listForms.Size = New System.Drawing.Size(264, 505)
        Me.listForms.TabIndex = 3
        '
        'FORMTEXT
        '
        Me.FORMTEXT.Caption = "Tên hiển thị"
        Me.FORMTEXT.FieldName = "FormText"
        Me.FORMTEXT.Name = "FORMTEXT"
        Me.FORMTEXT.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[String]
        Me.FORMTEXT.Visible = True
        Me.FORMTEXT.VisibleIndex = 0
        '
        'imgAll
        '
        Me.imgAll.ImageStream = CType(resources.GetObject("imgAll.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAll.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAll.Images.SetKeyName(0, "cube32_blue.png")
        Me.imgAll.Images.SetKeyName(1, "cube32_green.png")
        Me.imgAll.Images.SetKeyName(2, "cube32_yellow.png")
        Me.imgAll.Images.SetKeyName(3, "cube32_violet.png")
        Me.imgAll.Images.SetKeyName(4, "group32.png")
        Me.imgAll.Images.SetKeyName(5, "donvi32.png")
        Me.imgAll.Images.SetKeyName(6, "user_group32.png")
        Me.imgAll.Images.SetKeyName(7, "user32.png")
        '
        'listOriginal
        '
        Me.listOriginal.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GROUP_TEN, Me.GROUP_ORDER})
        Me.listOriginal.Dock = System.Windows.Forms.DockStyle.Left
        Me.listOriginal.KeyFieldName = "Id"
        Me.listOriginal.Location = New System.Drawing.Point(2, 22)
        Me.listOriginal.Name = "listOriginal"
        Me.listOriginal.OptionsBehavior.Editable = False
        Me.listOriginal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listOriginal.OptionsView.ShowColumns = False
        Me.listOriginal.OptionsView.ShowIndicator = False
        Me.listOriginal.ParentFieldName = "ParentId"
        Me.listOriginal.PreviewFieldName = "Id"
        Me.listOriginal.SelectImageList = Me.imgAll
        Me.listOriginal.Size = New System.Drawing.Size(336, 529)
        Me.listOriginal.TabIndex = 2
        '
        'GROUP_TEN
        '
        Me.GROUP_TEN.Caption = "Tên"
        Me.GROUP_TEN.FieldName = "GroupTen"
        Me.GROUP_TEN.Name = "GROUP_TEN"
        Me.GROUP_TEN.Visible = True
        Me.GROUP_TEN.VisibleIndex = 0
        Me.GROUP_TEN.Width = 289
        '
        'GROUP_ORDER
        '
        Me.GROUP_ORDER.Caption = "Thứ tự"
        Me.GROUP_ORDER.FieldName = "GroupOrder"
        Me.GROUP_ORDER.Name = "GROUP_ORDER"
        Me.GROUP_ORDER.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.GROUP_ORDER.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Decimal]
        '
        'groupDetail
        '
        Me.groupDetail.Controls.Add(Me.pncInput)
        Me.groupDetail.Controls.Add(Me.PanelControl2)
        Me.groupDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupDetail.Location = New System.Drawing.Point(0, 0)
        Me.groupDetail.Name = "groupDetail"
        Me.groupDetail.Size = New System.Drawing.Size(608, 622)
        Me.groupDetail.TabIndex = 4
        Me.groupDetail.Text = "Thông tin chi tiết"
        '
        'pncInput
        '
        Me.pncInput.Controls.Add(Me.chkIsShowDialog)
        Me.pncInput.Controls.Add(Me.txtFormName)
        Me.pncInput.Controls.Add(Me.lblError)
        Me.pncInput.Controls.Add(Me.LabelControl1)
        Me.pncInput.Controls.Add(Me.txtGroupFormsID)
        Me.pncInput.Controls.Add(Me.LabelControl2)
        Me.pncInput.Controls.Add(Me.txtFormOrder)
        Me.pncInput.Controls.Add(Me.txtFormText)
        Me.pncInput.Controls.Add(Me.LabelControl3)
        Me.pncInput.Controls.Add(Me.txtFormID)
        Me.pncInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pncInput.Location = New System.Drawing.Point(2, 22)
        Me.pncInput.Name = "pncInput"
        Me.pncInput.Size = New System.Drawing.Size(604, 160)
        Me.pncInput.TabIndex = 13
        '
        'chkIsShowDialog
        '
        Me.chkIsShowDialog.Location = New System.Drawing.Point(103, 126)
        Me.chkIsShowDialog.MenuManager = Me.BarManager1
        Me.chkIsShowDialog.Name = "chkIsShowDialog"
        Me.chkIsShowDialog.Properties.Caption = "Hiển thị dạng cửa sổ"
        Me.chkIsShowDialog.Size = New System.Drawing.Size(139, 19)
        Me.chkIsShowDialog.TabIndex = 13
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(103, 15)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(307, 20)
        Me.txtFormName.TabIndex = 4
        '
        'lblError
        '
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(189, 90)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(34, 13)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "lblError"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên Form :"
        '
        'txtGroupFormsID
        '
        Me.txtGroupFormsID.Enabled = False
        Me.txtGroupFormsID.Location = New System.Drawing.Point(416, 51)
        Me.txtGroupFormsID.Name = "txtGroupFormsID"
        Me.txtGroupFormsID.Size = New System.Drawing.Size(76, 20)
        Me.txtGroupFormsID.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tên hiển thị :"
        '
        'txtFormOrder
        '
        Me.txtFormOrder.Location = New System.Drawing.Point(103, 87)
        Me.txtFormOrder.Name = "txtFormOrder"
        Me.txtFormOrder.Size = New System.Drawing.Size(79, 20)
        Me.txtFormOrder.TabIndex = 10
        '
        'txtFormText
        '
        Me.txtFormText.Location = New System.Drawing.Point(103, 51)
        Me.txtFormText.Name = "txtFormText"
        Me.txtFormText.Size = New System.Drawing.Size(307, 20)
        Me.txtFormText.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Thứ tự sắp xếp :"
        '
        'txtFormID
        '
        Me.txtFormID.Enabled = False
        Me.txtFormID.Location = New System.Drawing.Point(416, 15)
        Me.txtFormID.Name = "txtFormID"
        Me.txtFormID.Size = New System.Drawing.Size(76, 20)
        Me.txtFormID.TabIndex = 7
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 580)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(604, 40)
        Me.PanelControl2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.ImageList = Me.imgList
        Me.btnClose.Location = New System.Drawing.Point(268, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Đóng"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.ImageList = Me.imgList
        Me.btnDelete.Location = New System.Drawing.Point(182, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Xóa"
        '
        'popControl
        '
        Me.popControl.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.popCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.popMove)})
        Me.popControl.Manager = Me.BarManager1
        Me.popControl.Name = "popControl"
        '
        'frmSetupMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1222, 622)
        Me.Controls.Add(Me.SplitContainerControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmSetupMenu"
        Me.Text = "Thiết lập Custom Menu"
        CType(Me.panelGroupDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGroupDetail.ResumeLayout(False)
        CType(Me.txtResourceName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupIndex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl.ResumeLayout(False)
        CType(Me.groupMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupMain.ResumeLayout(False)
        CType(Me.groupForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupForms.ResumeLayout(False)
        CType(Me.listForms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupDetail.ResumeLayout(False)
        CType(Me.pncInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pncInput.ResumeLayout(False)
        Me.pncInput.PerformLayout()
        CType(Me.chkIsShowDialog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupFormsID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents panelGroupDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtGroupId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents groupMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents groupDetail As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GROUP_TEN As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtFormName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFormText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFormID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents listForms As DevExpress.XtraTreeList.TreeList
    Friend WithEvents FORMTEXT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents groupForms As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents txtGroupIndex As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFormOrder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGroupFormsID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pncInput As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popControl As DevExpress.XtraBars.PopupMenu
    Public WithEvents popDelete As DevExpress.XtraBars.BarButtonItem
    Public WithEvents popCopy As DevExpress.XtraBars.BarButtonItem
    Public WithEvents popMove As DevExpress.XtraBars.BarButtonItem
    Public WithEvents listOriginal As DevExpress.XtraTreeList.TreeList
    Friend WithEvents btnSaveResource As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picPreview As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtResourceName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFromC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFromR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNotChoise As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkIsShowDialog As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents GROUP_ORDER As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class

