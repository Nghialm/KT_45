<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRightList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserRightList))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.splAdmin = New DevExpress.XtraEditors.SplitContainerControl()
        Me.panelAll = New DevExpress.XtraEditors.PanelControl()
        Me.panelTree = New DevExpress.XtraEditors.PanelControl()
        Me.trlAdmin = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn9 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList(Me.components)
        Me.panelGrant = New DevExpress.XtraEditors.PanelControl()
        Me.btnGrantReport = New DevExpress.XtraEditors.SimpleButton()
        Me.imgOption = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGrantFunction = New DevExpress.XtraEditors.SimpleButton()
        Me.gControlDV = New DevExpress.XtraEditors.GroupControl()
        Me.lookUpDONVI = New DevExpress.XtraEditors.LookUpEdit()
        Me.pnlUser = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSetPassword = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.grpUser = New DevExpress.XtraEditors.GroupControl()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.lblCode = New DevExpress.XtraEditors.LabelControl()
        Me.pnlGroup = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.btnGEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.grpGroup = New DevExpress.XtraEditors.GroupControl()
        Me.txtGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.splAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splAdmin.SuspendLayout()
        CType(Me.panelAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAll.SuspendLayout()
        CType(Me.panelTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTree.SuspendLayout()
        CType(Me.trlAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelGrant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGrant.SuspendLayout()
        CType(Me.gControlDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gControlDV.SuspendLayout()
        CType(Me.lookUpDONVI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUser.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUser.SuspendLayout()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGroup.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "pcCloseButton.png")
        Me.imgList.Images.SetKeyName(1, "BtnSave.png")
        Me.imgList.Images.SetKeyName(2, "ButtonSaveAndClose.png")
        Me.imgList.Images.SetKeyName(3, "find_selection.png")
        Me.imgList.Images.SetKeyName(4, "Copy of save-32x32.png")
        Me.imgList.Images.SetKeyName(5, "document_delete.png")
        Me.imgList.Images.SetKeyName(6, "document_edit.png")
        Me.imgList.Images.SetKeyName(7, "selection.png")
        Me.imgList.Images.SetKeyName(8, "copy.png")
        Me.imgList.Images.SetKeyName(9, "document_add.png")
        Me.imgList.Images.SetKeyName(10, "export1.png")
        Me.imgList.Images.SetKeyName(11, "cashier.png")
        Me.imgList.Images.SetKeyName(12, "printer.png")
        Me.imgList.Images.SetKeyName(13, "EDITITEM.GIF")
        Me.imgList.Images.SetKeyName(14, "icon-excel-16x16.gif")
        Me.imgList.Images.SetKeyName(15, "cubes_yellow.png")
        Me.imgList.Images.SetKeyName(16, "cubes.png")
        Me.imgList.Images.SetKeyName(17, "cubes_blue.png")
        Me.imgList.Images.SetKeyName(18, "cubes_green.png")
        Me.imgList.Images.SetKeyName(19, "cube_green.png")
        Me.imgList.Images.SetKeyName(20, "cube_blue.png")
        Me.imgList.Images.SetKeyName(21, "cube_yellow.png")
        Me.imgList.Images.SetKeyName(22, "users1.png")
        Me.imgList.Images.SetKeyName(23, "users3.png")
        Me.imgList.Images.SetKeyName(24, "user2.png")
        Me.imgList.Images.SetKeyName(25, "user3.png")
        Me.imgList.Images.SetKeyName(26, "book_green.png")
        '
        'splAdmin
        '
        Me.splAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splAdmin.Location = New System.Drawing.Point(8, 8)
        Me.splAdmin.Name = "splAdmin"
        Me.splAdmin.Panel1.Controls.Add(Me.panelAll)
        Me.splAdmin.Panel1.Controls.Add(Me.gControlDV)
        Me.splAdmin.Panel1.Text = "Panel1"
        Me.splAdmin.Panel2.Controls.Add(Me.pnlUser)
        Me.splAdmin.Panel2.Controls.Add(Me.pnlGroup)
        Me.splAdmin.Panel2.Text = "Panel2"
        Me.splAdmin.Size = New System.Drawing.Size(1012, 473)
        Me.splAdmin.SplitterPosition = 316
        Me.splAdmin.TabIndex = 6
        Me.splAdmin.Text = "SplitContainerControl1"
        '
        'panelAll
        '
        Me.panelAll.Controls.Add(Me.panelTree)
        Me.panelAll.Controls.Add(Me.panelGrant)
        Me.panelAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAll.Location = New System.Drawing.Point(0, 49)
        Me.panelAll.Name = "panelAll"
        Me.panelAll.Size = New System.Drawing.Size(316, 424)
        Me.panelAll.TabIndex = 3
        '
        'panelTree
        '
        Me.panelTree.Controls.Add(Me.trlAdmin)
        Me.panelTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTree.Location = New System.Drawing.Point(2, 2)
        Me.panelTree.Name = "panelTree"
        Me.panelTree.Size = New System.Drawing.Size(312, 375)
        Me.panelTree.TabIndex = 1
        '
        'trlAdmin
        '
        Me.trlAdmin.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn3, Me.TreeListColumn9})
        Me.trlAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trlAdmin.Location = New System.Drawing.Point(2, 2)
        Me.trlAdmin.Name = "trlAdmin"
        Me.trlAdmin.BeginUnboundLoad()
        Me.trlAdmin.AppendNode(New Object() {"USER_KEY", "Người dùng"}, -1, 7, 7, -1)
        Me.trlAdmin.AppendNode(New Object() {"GROUP_KEY", "Nhóm"}, -1, 6, 6, -1)
        Me.trlAdmin.EndUnboundLoad()
        Me.trlAdmin.OptionsBehavior.Editable = False
        Me.trlAdmin.OptionsBehavior.PopulateServiceColumns = True
        Me.trlAdmin.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.trlAdmin.SelectImageList = Me.imgAll
        Me.trlAdmin.Size = New System.Drawing.Size(308, 371)
        Me.trlAdmin.TabIndex = 2
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "Key"
        Me.TreeListColumn3.FieldName = "UGID"
        Me.TreeListColumn3.MinWidth = 37
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.Width = 92
        '
        'TreeListColumn9
        '
        Me.TreeListColumn9.Caption = "Tên"
        Me.TreeListColumn9.FieldName = "UGNAME"
        Me.TreeListColumn9.MinWidth = 37
        Me.TreeListColumn9.Name = "TreeListColumn9"
        Me.TreeListColumn9.Visible = True
        Me.TreeListColumn9.VisibleIndex = 0
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
        'panelGrant
        '
        Me.panelGrant.Controls.Add(Me.btnGrantReport)
        Me.panelGrant.Controls.Add(Me.btnGrantFunction)
        Me.panelGrant.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelGrant.Location = New System.Drawing.Point(2, 377)
        Me.panelGrant.Name = "panelGrant"
        Me.panelGrant.Size = New System.Drawing.Size(312, 45)
        Me.panelGrant.TabIndex = 0
        '
        'btnGrantReport
        '
        Me.btnGrantReport.ImageIndex = 3
        Me.btnGrantReport.ImageList = Me.imgOption
        Me.btnGrantReport.Location = New System.Drawing.Point(165, 8)
        Me.btnGrantReport.Name = "btnGrantReport"
        Me.btnGrantReport.Size = New System.Drawing.Size(142, 30)
        Me.btnGrantReport.TabIndex = 1
        Me.btnGrantReport.Text = "Phân quyền báo cáo"
        '
        'imgOption
        '
        Me.imgOption.ImageStream = CType(resources.GetObject("imgOption.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgOption.TransparentColor = System.Drawing.Color.Transparent
        Me.imgOption.Images.SetKeyName(0, "folder.gif")
        Me.imgOption.Images.SetKeyName(1, "folder_lock.gif")
        Me.imgOption.Images.SetKeyName(2, "icon_padlock.gif")
        Me.imgOption.Images.SetKeyName(3, "report.png")
        '
        'btnGrantFunction
        '
        Me.btnGrantFunction.ImageIndex = 1
        Me.btnGrantFunction.ImageList = Me.imgOption
        Me.btnGrantFunction.Location = New System.Drawing.Point(5, 8)
        Me.btnGrantFunction.Name = "btnGrantFunction"
        Me.btnGrantFunction.Size = New System.Drawing.Size(154, 30)
        Me.btnGrantFunction.TabIndex = 0
        Me.btnGrantFunction.Text = "Phân quyền chức năng"
        '
        'gControlDV
        '
        Me.gControlDV.Controls.Add(Me.lookUpDONVI)
        Me.gControlDV.Dock = System.Windows.Forms.DockStyle.Top
        Me.gControlDV.Location = New System.Drawing.Point(0, 0)
        Me.gControlDV.Name = "gControlDV"
        Me.gControlDV.Size = New System.Drawing.Size(316, 49)
        Me.gControlDV.TabIndex = 0
        Me.gControlDV.Text = "Danh sách đơn vị"
        '
        'lookUpDONVI
        '
        Me.lookUpDONVI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookUpDONVI.Location = New System.Drawing.Point(2, 22)
        Me.lookUpDONVI.Name = "lookUpDONVI"
        Me.lookUpDONVI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpDONVI.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Ký hiệu", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonvi", "Tên đơn vị")})
        Me.lookUpDONVI.Properties.DisplayMember = "TenDonvi"
        Me.lookUpDONVI.Properties.NullText = ""
        Me.lookUpDONVI.Properties.ValueMember = "Id"
        Me.lookUpDONVI.Size = New System.Drawing.Size(312, 20)
        Me.lookUpDONVI.TabIndex = 1
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.PanelControl7)
        Me.pnlUser.Controls.Add(Me.grpUser)
        Me.pnlUser.Location = New System.Drawing.Point(21, 23)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(593, 143)
        Me.pnlUser.TabIndex = 2
        '
        'PanelControl7
        '
        Me.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl7.Controls.Add(Me.btnSetPassword)
        Me.PanelControl7.Controls.Add(Me.btnUEdit)
        Me.PanelControl7.Controls.Add(Me.btnUAdd)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl7.Location = New System.Drawing.Point(2, 64)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(589, 38)
        Me.PanelControl7.TabIndex = 17
        '
        'btnSetPassword
        '
        Me.btnSetPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetPassword.ImageIndex = 25
        Me.btnSetPassword.ImageList = Me.imgList
        Me.btnSetPassword.Location = New System.Drawing.Point(206, 8)
        Me.btnSetPassword.Name = "btnSetPassword"
        Me.btnSetPassword.Size = New System.Drawing.Size(103, 28)
        Me.btnSetPassword.TabIndex = 2
        Me.btnSetPassword.Text = "Đặt &mật khẩu"
        '
        'btnUEdit
        '
        Me.btnUEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUEdit.ImageIndex = 6
        Me.btnUEdit.ImageList = Me.imgList
        Me.btnUEdit.Location = New System.Drawing.Point(102, 8)
        Me.btnUEdit.Name = "btnUEdit"
        Me.btnUEdit.Size = New System.Drawing.Size(92, 28)
        Me.btnUEdit.TabIndex = 1
        Me.btnUEdit.Text = "&Cập nhật"
        '
        'btnUAdd
        '
        Me.btnUAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUAdd.ImageIndex = 9
        Me.btnUAdd.ImageList = Me.imgList
        Me.btnUAdd.Location = New System.Drawing.Point(-1, 8)
        Me.btnUAdd.Name = "btnUAdd"
        Me.btnUAdd.Size = New System.Drawing.Size(92, 28)
        Me.btnUAdd.TabIndex = 0
        Me.btnUAdd.Text = "&Thêm"
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.txtFullName)
        Me.grpUser.Controls.Add(Me.LabelControl1)
        Me.grpUser.Controls.Add(Me.txtUserName)
        Me.grpUser.Controls.Add(Me.lblCode)
        Me.grpUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpUser.Location = New System.Drawing.Point(2, 2)
        Me.grpUser.Margin = New System.Windows.Forms.Padding(0)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpUser.Size = New System.Drawing.Size(589, 62)
        Me.grpUser.TabIndex = 16
        Me.grpUser.Text = "Thông tin người dùng"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(310, 30)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFullName.Size = New System.Drawing.Size(256, 20)
        Me.txtFullName.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(249, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Họ và tên"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(87, 30)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserName.Size = New System.Drawing.Size(131, 20)
        Me.txtUserName.TabIndex = 3
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(19, 34)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(46, 13)
        Me.lblCode.TabIndex = 2
        Me.lblCode.Text = "Tài khoản"
        '
        'pnlGroup
        '
        Me.pnlGroup.Controls.Add(Me.PanelControl9)
        Me.pnlGroup.Controls.Add(Me.grpGroup)
        Me.pnlGroup.Location = New System.Drawing.Point(21, 186)
        Me.pnlGroup.Name = "pnlGroup"
        Me.pnlGroup.Size = New System.Drawing.Size(593, 156)
        Me.pnlGroup.TabIndex = 3
        '
        'PanelControl9
        '
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.btnGEdit)
        Me.PanelControl9.Controls.Add(Me.btnGAdd)
        Me.PanelControl9.Controls.Add(Me.btnGDelete)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl9.Location = New System.Drawing.Point(2, 64)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(589, 38)
        Me.PanelControl9.TabIndex = 12
        '
        'btnGEdit
        '
        Me.btnGEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGEdit.ImageIndex = 6
        Me.btnGEdit.ImageList = Me.imgList
        Me.btnGEdit.Location = New System.Drawing.Point(102, 8)
        Me.btnGEdit.Name = "btnGEdit"
        Me.btnGEdit.Size = New System.Drawing.Size(92, 28)
        Me.btnGEdit.TabIndex = 1
        Me.btnGEdit.Text = "&Cập nhật"
        '
        'btnGAdd
        '
        Me.btnGAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGAdd.ImageIndex = 9
        Me.btnGAdd.ImageList = Me.imgList
        Me.btnGAdd.Location = New System.Drawing.Point(-1, 8)
        Me.btnGAdd.Name = "btnGAdd"
        Me.btnGAdd.Size = New System.Drawing.Size(92, 28)
        Me.btnGAdd.TabIndex = 0
        Me.btnGAdd.Text = "&Thêm"
        '
        'btnGDelete
        '
        Me.btnGDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGDelete.ImageIndex = 5
        Me.btnGDelete.ImageList = Me.imgList
        Me.btnGDelete.Location = New System.Drawing.Point(204, 8)
        Me.btnGDelete.Name = "btnGDelete"
        Me.btnGDelete.Size = New System.Drawing.Size(92, 28)
        Me.btnGDelete.TabIndex = 2
        Me.btnGDelete.Text = "&Xóa"
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.txtGroupName)
        Me.grpGroup.Controls.Add(Me.LabelControl3)
        Me.grpGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpGroup.Location = New System.Drawing.Point(2, 2)
        Me.grpGroup.Name = "grpGroup"
        Me.grpGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpGroup.Size = New System.Drawing.Size(589, 62)
        Me.grpGroup.TabIndex = 11
        Me.grpGroup.Text = "Thông tin nhóm người dùng"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(87, 31)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupName.Size = New System.Drawing.Size(479, 20)
        Me.txtGroupName.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Tên nhóm"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'frmUserRightList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 489)
        Me.Controls.Add(Me.splAdmin)
        Me.KeyPreview = True
        Me.Name = "frmUserRightList"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Quản lý người dùng"
        CType(Me.splAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splAdmin.ResumeLayout(False)
        CType(Me.panelAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAll.ResumeLayout(False)
        CType(Me.panelTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTree.ResumeLayout(False)
        CType(Me.trlAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelGrant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGrant.ResumeLayout(False)
        CType(Me.gControlDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gControlDV.ResumeLayout(False)
        CType(Me.lookUpDONVI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUser.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGroup.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        Me.grpGroup.PerformLayout()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NAMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents splAdmin As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents trlAdmin As DevExpress.XtraTreeList.TreeList
    Friend WithEvents pnlUser As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlGroup As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpGroup As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpUser As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSetPassword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gControlDV As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lookUpDONVI As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents panelAll As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn9 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents panelTree As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panelGrant As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGrantReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGrantFunction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgOption As System.Windows.Forms.ImageList
End Class
