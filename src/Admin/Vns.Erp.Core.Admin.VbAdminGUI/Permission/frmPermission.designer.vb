<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermission))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.imgListBoxControlGroup = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.imgList = New System.Windows.Forms.ImageList()
        Me.pnControl = New DevExpress.XtraEditors.PanelControl()
        Me.txtUserGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserGroupId = New DevExpress.XtraEditors.TextEdit()
        Me.btnSavePermission = New DevExpress.XtraEditors.SimpleButton()
        Me.imgButton = New System.Windows.Forms.ImageList()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.groupFunction = New DevExpress.XtraEditors.GroupControl()
        Me.treeFunction = New DevExpress.XtraTreeList.TreeList()
        Me.FORMTEXT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgList2 = New System.Windows.Forms.ImageList()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.treeGroup = New DevExpress.XtraTreeList.TreeList()
        Me.GROUP_TEN = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.pnInfo = New DevExpress.XtraEditors.PanelControl()
        Me.lblDonVi = New DevExpress.XtraEditors.LabelControl()
        Me.lblUserGroup = New DevExpress.XtraEditors.LabelControl()
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkAll = New DevExpress.XtraEditors.CheckEdit()
        Me.btnFull = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.imgListBoxControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnControl.SuspendLayout()
        CType(Me.txtUserGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserGroupId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.groupFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFunction.SuspendLayout()
        CType(Me.treeFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnInfo.SuspendLayout()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.pnControl)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnInfo)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(986, 523)
        Me.SplitContainerControl1.SplitterPosition = 278
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.imgListBoxControlGroup)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(278, 429)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Nhóm người dùng"
        '
        'imgListBoxControlGroup
        '
        Me.imgListBoxControlGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgListBoxControlGroup.ImageList = Me.imgList
        Me.imgListBoxControlGroup.Location = New System.Drawing.Point(2, 22)
        Me.imgListBoxControlGroup.Name = "imgListBoxControlGroup"
        Me.imgListBoxControlGroup.Size = New System.Drawing.Size(274, 405)
        Me.imgListBoxControlGroup.TabIndex = 0
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "cube_blue.png")
        Me.imgList.Images.SetKeyName(1, "cube_yellow.png")
        Me.imgList.Images.SetKeyName(2, "cube_green.png")
        '
        'pnControl
        '
        Me.pnControl.Controls.Add(Me.txtUserGroupName)
        Me.pnControl.Controls.Add(Me.txtUserGroupId)
        Me.pnControl.Controls.Add(Me.btnSavePermission)
        Me.pnControl.Controls.Add(Me.btnEdit)
        Me.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnControl.Location = New System.Drawing.Point(0, 429)
        Me.pnControl.Name = "pnControl"
        Me.pnControl.Size = New System.Drawing.Size(278, 94)
        Me.pnControl.TabIndex = 0
        '
        'txtUserGroupName
        '
        Me.txtUserGroupName.Enabled = False
        Me.txtUserGroupName.Location = New System.Drawing.Point(51, 62)
        Me.txtUserGroupName.Name = "txtUserGroupName"
        Me.txtUserGroupName.Properties.ReadOnly = True
        Me.txtUserGroupName.Size = New System.Drawing.Size(222, 20)
        Me.txtUserGroupName.TabIndex = 4
        '
        'txtUserGroupId
        '
        Me.txtUserGroupId.Enabled = False
        Me.txtUserGroupId.Location = New System.Drawing.Point(12, 62)
        Me.txtUserGroupId.Name = "txtUserGroupId"
        Me.txtUserGroupId.Properties.ReadOnly = True
        Me.txtUserGroupId.Size = New System.Drawing.Size(33, 20)
        Me.txtUserGroupId.TabIndex = 3
        '
        'btnSavePermission
        '
        Me.btnSavePermission.Enabled = False
        Me.btnSavePermission.ImageIndex = 7
        Me.btnSavePermission.ImageList = Me.imgButton
        Me.btnSavePermission.Location = New System.Drawing.Point(97, 17)
        Me.btnSavePermission.Name = "btnSavePermission"
        Me.btnSavePermission.Size = New System.Drawing.Size(120, 30)
        Me.btnSavePermission.TabIndex = 2
        Me.btnSavePermission.Text = "Lưu phân quyền"
        '
        'imgButton
        '
        Me.imgButton.ImageStream = CType(resources.GetObject("imgButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgButton.TransparentColor = System.Drawing.Color.Transparent
        Me.imgButton.Images.SetKeyName(0, "find_selection.png")
        Me.imgButton.Images.SetKeyName(1, "selection.png")
        Me.imgButton.Images.SetKeyName(2, "document_add.png")
        Me.imgButton.Images.SetKeyName(3, "document_edit.png")
        Me.imgButton.Images.SetKeyName(4, "document_view.png")
        Me.imgButton.Images.SetKeyName(5, "document_delete.png")
        Me.imgButton.Images.SetKeyName(6, "pcCloseButton.png")
        Me.imgButton.Images.SetKeyName(7, "BtnSave.png")
        Me.imgButton.Images.SetKeyName(8, "ButtonSaveAndClose.png")
        Me.imgButton.Images.SetKeyName(9, "Copy of save-32x32.png")
        Me.imgButton.Images.SetKeyName(10, "copy.png")
        Me.imgButton.Images.SetKeyName(11, "export1.png")
        Me.imgButton.Images.SetKeyName(12, "cashier.png")
        Me.imgButton.Images.SetKeyName(13, "printer.png")
        Me.imgButton.Images.SetKeyName(14, "EDITITEM.GIF")
        Me.imgButton.Images.SetKeyName(15, "icon-excel-16x16.gif")
        Me.imgButton.Images.SetKeyName(16, "cubes_yellow.png")
        Me.imgButton.Images.SetKeyName(17, "cubes.png")
        Me.imgButton.Images.SetKeyName(18, "cubes_blue.png")
        Me.imgButton.Images.SetKeyName(19, "cubes_green.png")
        Me.imgButton.Images.SetKeyName(20, "cube_blue.png")
        Me.imgButton.Images.SetKeyName(21, "cube_green.png")
        Me.imgButton.Images.SetKeyName(22, "cube_yellow.png")
        '
        'btnEdit
        '
        Me.btnEdit.ImageIndex = 3
        Me.btnEdit.ImageList = Me.imgButton
        Me.btnEdit.Location = New System.Drawing.Point(11, 17)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 30)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Sửa"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.groupFunction)
        Me.GroupControl2.Controls.Add(Me.SplitterControl1)
        Me.GroupControl2.Controls.Add(Me.treeGroup)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(702, 429)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Danh sách chức năng"
        '
        'groupFunction
        '
        Me.groupFunction.Controls.Add(Me.treeFunction)
        Me.groupFunction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupFunction.Location = New System.Drawing.Point(326, 22)
        Me.groupFunction.Name = "groupFunction"
        Me.groupFunction.Size = New System.Drawing.Size(374, 405)
        Me.groupFunction.TabIndex = 2
        Me.groupFunction.Text = "Chức năng"
        '
        'treeFunction
        '
        Me.treeFunction.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.FORMTEXT})
        Me.treeFunction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeFunction.Location = New System.Drawing.Point(2, 22)
        Me.treeFunction.Name = "treeFunction"
        Me.treeFunction.OptionsBehavior.Editable = False
        Me.treeFunction.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeFunction.OptionsView.ShowCheckBoxes = True
        Me.treeFunction.OptionsView.ShowColumns = False
        Me.treeFunction.SelectImageList = Me.imgList2
        Me.treeFunction.Size = New System.Drawing.Size(370, 381)
        Me.treeFunction.TabIndex = 0
        '
        'FORMTEXT
        '
        Me.FORMTEXT.Caption = "FORMTEXT"
        Me.FORMTEXT.FieldName = "Formtext"
        Me.FORMTEXT.MinWidth = 51
        Me.FORMTEXT.Name = "FORMTEXT"
        Me.FORMTEXT.Visible = True
        Me.FORMTEXT.VisibleIndex = 0
        Me.FORMTEXT.Width = 91
        '
        'imgList2
        '
        Me.imgList2.ImageStream = CType(resources.GetObject("imgList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList2.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList2.Images.SetKeyName(0, "cube_green.png")
        Me.imgList2.Images.SetKeyName(1, "cube_yellow.png")
        Me.imgList2.Images.SetKeyName(2, "cube_blue.png")
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(320, 22)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 405)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'treeGroup
        '
        Me.treeGroup.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GROUP_TEN})
        Me.treeGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.treeGroup.KeyFieldName = "GROUP_ID"
        Me.treeGroup.Location = New System.Drawing.Point(2, 22)
        Me.treeGroup.Name = "treeGroup"
        Me.treeGroup.OptionsBehavior.Editable = False
        Me.treeGroup.OptionsBehavior.KeepSelectedOnClick = False
        Me.treeGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeGroup.OptionsView.ShowCheckBoxes = True
        Me.treeGroup.OptionsView.ShowColumns = False
        Me.treeGroup.ParentFieldName = "PARENT_ID"
        Me.treeGroup.PreviewFieldName = "GROUP_ID"
        Me.treeGroup.SelectImageList = Me.imgList
        Me.treeGroup.Size = New System.Drawing.Size(318, 405)
        Me.treeGroup.TabIndex = 0
        '
        'GROUP_TEN
        '
        Me.GROUP_TEN.Caption = "GROUP_TEN"
        Me.GROUP_TEN.FieldName = "GroupTen"
        Me.GROUP_TEN.MinWidth = 35
        Me.GROUP_TEN.Name = "GROUP_TEN"
        Me.GROUP_TEN.Visible = True
        Me.GROUP_TEN.VisibleIndex = 0
        Me.GROUP_TEN.Width = 88
        '
        'pnInfo
        '
        Me.pnInfo.Controls.Add(Me.lblDonVi)
        Me.pnInfo.Controls.Add(Me.lblUserGroup)
        Me.pnInfo.Controls.Add(Me.lblUserName)
        Me.pnInfo.Controls.Add(Me.LabelControl3)
        Me.pnInfo.Controls.Add(Me.LabelControl2)
        Me.pnInfo.Controls.Add(Me.LabelControl1)
        Me.pnInfo.Controls.Add(Me.chkAll)
        Me.pnInfo.Controls.Add(Me.btnFull)
        Me.pnInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnInfo.Location = New System.Drawing.Point(0, 429)
        Me.pnInfo.Name = "pnInfo"
        Me.pnInfo.Size = New System.Drawing.Size(702, 94)
        Me.pnInfo.TabIndex = 0
        '
        'lblDonVi
        '
        Me.lblDonVi.Location = New System.Drawing.Point(243, 62)
        Me.lblDonVi.Name = "lblDonVi"
        Me.lblDonVi.Size = New System.Drawing.Size(37, 13)
        Me.lblDonVi.TabIndex = 21
        Me.lblDonVi.Text = "lblDonVi"
        '
        'lblUserGroup
        '
        Me.lblUserGroup.Location = New System.Drawing.Point(243, 36)
        Me.lblUserGroup.Name = "lblUserGroup"
        Me.lblUserGroup.Size = New System.Drawing.Size(61, 13)
        Me.lblUserGroup.TabIndex = 20
        Me.lblUserGroup.Text = "lblUserGroup"
        '
        'lblUserName
        '
        Me.lblUserName.Location = New System.Drawing.Point(243, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(59, 13)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.Text = "lblUserName"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(162, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 18
        Me.LabelControl3.Text = "Thuộc đơn vị :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(165, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Thuộc nhóm :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(168, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Người dùng :"
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(12, 6)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkAll.Properties.Appearance.Options.UseFont = True
        Me.chkAll.Properties.Appearance.Options.UseForeColor = True
        Me.chkAll.Properties.Caption = "Toàn quyền"
        Me.chkAll.Properties.ReadOnly = True
        Me.chkAll.Size = New System.Drawing.Size(101, 19)
        Me.chkAll.TabIndex = 15
        '
        'btnFull
        '
        Me.btnFull.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFull.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnFull.Appearance.Options.UseFont = True
        Me.btnFull.Appearance.Options.UseForeColor = True
        Me.btnFull.Location = New System.Drawing.Point(12, 33)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(99, 42)
        Me.btnFull.TabIndex = 14
        Me.btnFull.Text = "Toàn quyền"
        '
        'frmPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 523)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmPermission"
        Me.Text = "Phân quyền"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.imgListBoxControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnControl.ResumeLayout(False)
        CType(Me.txtUserGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserGroupId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.groupFunction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFunction.ResumeLayout(False)
        CType(Me.treeFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnInfo.ResumeLayout(False)
        Me.pnInfo.PerformLayout()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents imgListBoxControlGroup As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents treeGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents btnSavePermission As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUserGroupId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GROUP_TEN As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents groupFunction As DevExpress.XtraEditors.GroupControl
    Friend WithEvents treeFunction As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents FORMTEXT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtUserGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents imgButton As System.Windows.Forms.ImageList
    Friend WithEvents chkFull As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnFull As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList2 As System.Windows.Forms.ImageList
    Friend WithEvents chkAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDonVi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUserGroup As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
