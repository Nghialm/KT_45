<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupHMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupHMenu))
        Me.splitMain = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.treeGroupFunct = New DevExpress.XtraTreeList.TreeList()
        Me.GROUP_TEN = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.GROUP_ID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.listForm = New DevExpress.XtraTreeList.TreeList()
        Me.GFNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAllForm = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveForm = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.popAddNew = New DevExpress.XtraBars.BarButtonItem()
        Me.popEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.popDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.popClose = New DevExpress.XtraBars.BarButtonItem()
        Me.popAddNewParent = New DevExpress.XtraBars.BarButtonItem()
        Me.popControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.treeGroupFunct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.listForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitMain
        '
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.Location = New System.Drawing.Point(0, 0)
        Me.splitMain.Name = "splitMain"
        Me.splitMain.Panel1.Controls.Add(Me.GroupControl1)
        Me.splitMain.Panel1.Controls.Add(Me.PanelControl1)
        Me.splitMain.Panel1.Text = "Panel1"
        Me.splitMain.Panel2.Controls.Add(Me.GroupControl3)
        Me.splitMain.Panel2.Controls.Add(Me.PanelControl2)
        Me.splitMain.Panel2.Text = "Panel2"
        Me.splitMain.Size = New System.Drawing.Size(709, 602)
        Me.splitMain.SplitterPosition = 282
        Me.splitMain.TabIndex = 0
        Me.splitMain.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.treeGroupFunct)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(282, 557)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Nhóm chức năng trên Horizontal Menu"
        '
        'treeGroupFunct
        '
        Me.treeGroupFunct.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GROUP_TEN, Me.GROUP_ID})
        Me.treeGroupFunct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGroupFunct.KeyFieldName = "Id"
        Me.treeGroupFunct.Location = New System.Drawing.Point(2, 20)
        Me.treeGroupFunct.Name = "treeGroupFunct"
        Me.treeGroupFunct.OptionsBehavior.Editable = False
        Me.treeGroupFunct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeGroupFunct.OptionsView.ShowColumns = False
        Me.treeGroupFunct.ParentFieldName = "ParentId"
        Me.treeGroupFunct.Size = New System.Drawing.Size(278, 535)
        Me.treeGroupFunct.TabIndex = 1
        '
        'GROUP_TEN
        '
        Me.GROUP_TEN.Caption = "Tên"
        Me.GROUP_TEN.FieldName = "GroupTen"
        Me.GROUP_TEN.Name = "GROUP_TEN"
        Me.GROUP_TEN.Visible = True
        Me.GROUP_TEN.VisibleIndex = 0
        '
        'GROUP_ID
        '
        Me.GROUP_ID.Caption = "Mã"
        Me.GROUP_ID.FieldName = "Id"
        Me.GROUP_ID.Name = "GROUP_ID"
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 557)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(282, 45)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.listForm)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(421, 557)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Danh sách chức năng"
        '
        'listForm
        '
        Me.listForm.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GFNAME})
        Me.listForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listForm.KeyFieldName = "GFID"
        Me.listForm.Location = New System.Drawing.Point(2, 20)
        Me.listForm.Name = "listForm"
        Me.listForm.OptionsBehavior.Editable = False
        Me.listForm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listForm.OptionsView.ShowCheckBoxes = True
        Me.listForm.OptionsView.ShowColumns = False
        Me.listForm.OptionsView.ShowIndicator = False
        Me.listForm.ParentFieldName = "GFPARENT"
        Me.listForm.SelectImageList = Me.imgAll
        Me.listForm.Size = New System.Drawing.Size(417, 535)
        Me.listForm.TabIndex = 0
        '
        'GFNAME
        '
        Me.GFNAME.Caption = "GFNAME"
        Me.GFNAME.FieldName = "GFNAME"
        Me.GFNAME.MinWidth = 35
        Me.GFNAME.Name = "GFNAME"
        Me.GFNAME.Visible = True
        Me.GFNAME.VisibleIndex = 0
        Me.GFNAME.Width = 108
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnAllForm)
        Me.PanelControl2.Controls.Add(Me.btnSaveForm)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 557)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(421, 45)
        Me.PanelControl2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 31
        Me.btnClose.ImageList = Me.imglImporter
        Me.btnClose.Location = New System.Drawing.Point(327, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Đóng"
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
        'btnAllForm
        '
        Me.btnAllForm.ImageIndex = 21
        Me.btnAllForm.ImageList = Me.imglImporter
        Me.btnAllForm.Location = New System.Drawing.Point(167, 6)
        Me.btnAllForm.Name = "btnAllForm"
        Me.btnAllForm.Size = New System.Drawing.Size(154, 30)
        Me.btnAllForm.TabIndex = 5
        Me.btnAllForm.Text = "Chọn tất cả chức năng"
        '
        'btnSaveForm
        '
        Me.btnSaveForm.Enabled = False
        Me.btnSaveForm.ImageIndex = 9
        Me.btnSaveForm.ImageList = Me.imglImporter
        Me.btnSaveForm.Location = New System.Drawing.Point(5, 6)
        Me.btnSaveForm.Name = "btnSaveForm"
        Me.btnSaveForm.Size = New System.Drawing.Size(156, 30)
        Me.btnSaveForm.TabIndex = 4
        Me.btnSaveForm.Text = "Lưu thiết lập chức năng"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.imglImporter
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popAddNew, Me.popEdit, Me.popDelete, Me.popClose, Me.popAddNewParent})
        Me.BarManager1.LargeImages = Me.imglImporter
        Me.BarManager1.MaxItemId = 5
        '
        'popAddNew
        '
        Me.popAddNew.Caption = "Thêm mới nhóm chức năng"
        Me.popAddNew.Id = 0
        Me.popAddNew.ImageIndex = 18
        Me.popAddNew.Name = "popAddNew"
        '
        'popEdit
        '
        Me.popEdit.Caption = "Sửa nhóm chức năng"
        Me.popEdit.Id = 1
        Me.popEdit.ImageIndex = 15
        Me.popEdit.Name = "popEdit"
        '
        'popDelete
        '
        Me.popDelete.Caption = "Xóa nhóm chức năng"
        Me.popDelete.Id = 2
        Me.popDelete.ImageIndex = 3
        Me.popDelete.Name = "popDelete"
        '
        'popClose
        '
        Me.popClose.Caption = "Đóng"
        Me.popClose.Id = 3
        Me.popClose.ImageIndex = 31
        Me.popClose.Name = "popClose"
        '
        'popAddNewParent
        '
        Me.popAddNewParent.Caption = "Thêm nhóm chức năng cha"
        Me.popAddNewParent.Id = 4
        Me.popAddNewParent.ImageIndex = 16
        Me.popAddNewParent.Name = "popAddNewParent"
        '
        'popControl
        '
        Me.popControl.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popAddNewParent), New DevExpress.XtraBars.LinkPersistInfo(Me.popAddNew), New DevExpress.XtraBars.LinkPersistInfo(Me.popEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.popDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.popClose)})
        Me.popControl.Manager = Me.BarManager1
        Me.popControl.Name = "popControl"
        '
        'frmSetupHMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(709, 602)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupHMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập Horizontal Menu"
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.treeGroupFunct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.listForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitMain As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents treeGroupFunct As DevExpress.XtraTreeList.TreeList
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GROUP_TEN As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popAddNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents popClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents GROUP_ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listForm As DevExpress.XtraTreeList.TreeList
    Friend WithEvents GFNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents popAddNewParent As DevExpress.XtraBars.BarButtonItem
End Class
