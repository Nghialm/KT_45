<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonviGroupUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonviGroupUser))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.listUser = New DevExpress.XtraTreeList.TreeList()
        Me.USERNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.FULLNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.listGroup = New DevExpress.XtraTreeList.TreeList()
        Me.DVGNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.panelGroupBottom = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imgList = New System.Windows.Forms.ImageList()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.listUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelGroupBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGroupBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.panelGroupBottom)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(878, 534)
        Me.SplitContainerControl1.SplitterPosition = 339
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.listUser)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(339, 489)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách người dùng"
        '
        'listUser
        '
        Me.listUser.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.USERNAME, Me.FULLNAME})
        Me.listUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listUser.KeyFieldName = "Username"
        Me.listUser.Location = New System.Drawing.Point(2, 22)
        Me.listUser.Name = "listUser"
        Me.listUser.OptionsBehavior.Editable = False
        Me.listUser.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listUser.OptionsView.ShowColumns = False
        Me.listUser.OptionsView.ShowIndicator = False
        Me.listUser.SelectImageList = Me.imgAll
        Me.listUser.Size = New System.Drawing.Size(335, 465)
        Me.listUser.TabIndex = 0
        '
        'USERNAME
        '
        Me.USERNAME.Caption = "USERNAME"
        Me.USERNAME.FieldName = "Username"
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Visible = True
        Me.USERNAME.VisibleIndex = 0
        Me.USERNAME.Width = 120
        '
        'FULLNAME
        '
        Me.FULLNAME.Caption = "FULLNAME"
        Me.FULLNAME.FieldName = "Fullname"
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.Visible = True
        Me.FULLNAME.VisibleIndex = 1
        Me.FULLNAME.Width = 211
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
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 489)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(339, 45)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.listGroup)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(533, 489)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Nhóm người dùng theo đơn vị"
        '
        'listGroup
        '
        Me.listGroup.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.DVGNAME})
        Me.listGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listGroup.KeyFieldName = "TEN_DONVI"
        Me.listGroup.Location = New System.Drawing.Point(2, 22)
        Me.listGroup.Name = "listGroup"
        Me.listGroup.OptionsBehavior.Editable = False
        Me.listGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listGroup.OptionsView.ShowCheckBoxes = True
        Me.listGroup.OptionsView.ShowColumns = False
        Me.listGroup.OptionsView.ShowIndicator = False
        Me.listGroup.SelectImageList = Me.imgAll
        Me.listGroup.Size = New System.Drawing.Size(529, 465)
        Me.listGroup.TabIndex = 0
        '
        'DVGNAME
        '
        Me.DVGNAME.Caption = "DVGNAME"
        Me.DVGNAME.FieldName = "DVGNAME"
        Me.DVGNAME.MinWidth = 35
        Me.DVGNAME.Name = "DVGNAME"
        Me.DVGNAME.Visible = True
        Me.DVGNAME.VisibleIndex = 0
        Me.DVGNAME.Width = 92
        '
        'panelGroupBottom
        '
        Me.panelGroupBottom.Controls.Add(Me.btnClose)
        Me.panelGroupBottom.Controls.Add(Me.btnSave)
        Me.panelGroupBottom.Controls.Add(Me.btnAll)
        Me.panelGroupBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelGroupBottom.Location = New System.Drawing.Point(0, 489)
        Me.panelGroupBottom.Name = "panelGroupBottom"
        Me.panelGroupBottom.Size = New System.Drawing.Size(533, 45)
        Me.panelGroupBottom.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 0
        Me.btnClose.ImageList = Me.imgList
        Me.btnClose.Location = New System.Drawing.Point(217, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Đóng"
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "pcCloseButton.png")
        Me.imgList.Images.SetKeyName(1, "BtnSave.png")
        Me.imgList.Images.SetKeyName(2, "Copy of save-32x32.png")
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.ImageIndex = 1
        Me.btnSave.ImageList = Me.imgList
        Me.btnSave.Location = New System.Drawing.Point(5, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Lưu thiết lập"
        '
        'btnAll
        '
        Me.btnAll.ImageIndex = 2
        Me.btnAll.ImageList = Me.imgList
        Me.btnAll.Location = New System.Drawing.Point(111, 6)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(100, 30)
        Me.btnAll.TabIndex = 1
        Me.btnAll.Text = "Chọn tất cả"
        '
        'frmDonviGroupUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(878, 534)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonviGroupUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Phân nhóm cho người dùng"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.listUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelGroupBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGroupBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelGroupBottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents listUser As DevExpress.XtraTreeList.TreeList
    Friend WithEvents FULLNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents listGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents DVGNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents USERNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
End Class
