<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonviGroupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonviGroupForm))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.groupDVG = New DevExpress.XtraEditors.GroupControl()
        Me.listGroup = New DevExpress.XtraTreeList.TreeList()
        Me.DVGNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList()
        Me.lookDonVi = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.groupFunctionForm = New DevExpress.XtraEditors.GroupControl()
        Me.listForm = New DevExpress.XtraTreeList.TreeList()
        Me.BTNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imgList = New System.Windows.Forms.ImageList()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.groupDVG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupDVG.SuspendLayout()
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookDonVi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupFunctionForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFunctionForm.SuspendLayout()
        CType(Me.listForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.groupDVG)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupFunctionForm)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(749, 610)
        Me.SplitContainerControl1.SplitterPosition = 315
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'groupDVG
        '
        Me.groupDVG.Controls.Add(Me.listGroup)
        Me.groupDVG.Controls.Add(Me.lookDonVi)
        Me.groupDVG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupDVG.Location = New System.Drawing.Point(0, 0)
        Me.groupDVG.Name = "groupDVG"
        Me.groupDVG.Size = New System.Drawing.Size(315, 565)
        Me.groupDVG.TabIndex = 1
        Me.groupDVG.Text = "Danh sách nhóm theo đơn vị"
        '
        'listGroup
        '
        Me.listGroup.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.DVGNAME})
        Me.listGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listGroup.KeyFieldName = ""
        Me.listGroup.Location = New System.Drawing.Point(2, 42)
        Me.listGroup.Name = "listGroup"
        Me.listGroup.OptionsBehavior.Editable = False
        Me.listGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listGroup.OptionsView.ShowColumns = False
        Me.listGroup.OptionsView.ShowIndicator = False
        Me.listGroup.ParentFieldName = ""
        Me.listGroup.SelectImageList = Me.imgAll
        Me.listGroup.Size = New System.Drawing.Size(311, 521)
        Me.listGroup.TabIndex = 6
        '
        'DVGNAME
        '
        Me.DVGNAME.Caption = "DVGNAME"
        Me.DVGNAME.FieldName = "GFNAME"
        Me.DVGNAME.Name = "DVGNAME"
        Me.DVGNAME.Visible = True
        Me.DVGNAME.VisibleIndex = 0
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
        'lookDonVi
        '
        Me.lookDonVi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lookDonVi.Location = New System.Drawing.Point(2, 22)
        Me.lookDonVi.Name = "lookDonVi"
        Me.lookDonVi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookDonVi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DVGID", "Mã đơn vị", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DVGNAME", 150, "Tên đơn vị")})
        Me.lookDonVi.Properties.DisplayMember = "DVGNAME"
        Me.lookDonVi.Properties.NullText = "Chọn đơn vị để tạo danh sách chức năng"
        Me.lookDonVi.Properties.ValueMember = "DVGID"
        Me.lookDonVi.Size = New System.Drawing.Size(311, 20)
        Me.lookDonVi.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 565)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(315, 45)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Visible = False
        '
        'groupFunctionForm
        '
        Me.groupFunctionForm.Controls.Add(Me.listForm)
        Me.groupFunctionForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupFunctionForm.Location = New System.Drawing.Point(0, 0)
        Me.groupFunctionForm.Name = "groupFunctionForm"
        Me.groupFunctionForm.Size = New System.Drawing.Size(428, 565)
        Me.groupFunctionForm.TabIndex = 1
        Me.groupFunctionForm.Text = "Danh sách chức năng"
        '
        'listForm
        '
        Me.listForm.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.BTNAME})
        Me.listForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listForm.KeyFieldName = "BTID"
        Me.listForm.Location = New System.Drawing.Point(2, 22)
        Me.listForm.Name = "listForm"
        Me.listForm.OptionsBehavior.Editable = False
        Me.listForm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listForm.OptionsView.ShowCheckBoxes = True
        Me.listForm.OptionsView.ShowColumns = False
        Me.listForm.OptionsView.ShowIndicator = False
        Me.listForm.ParentFieldName = "BTPID"
        Me.listForm.SelectImageList = Me.imgAll
        Me.listForm.Size = New System.Drawing.Size(424, 541)
        Me.listForm.TabIndex = 0
        '
        'BTNAME
        '
        Me.BTNAME.Caption = "BTNAME"
        Me.BTNAME.FieldName = "BTNAME"
        Me.BTNAME.MinWidth = 35
        Me.BTNAME.Name = "BTNAME"
        Me.BTNAME.Visible = True
        Me.BTNAME.VisibleIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Controls.Add(Me.btnAll)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 565)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(428, 45)
        Me.PanelControl2.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 0
        Me.btnClose.ImageList = Me.imgList
        Me.btnClose.Location = New System.Drawing.Point(232, 6)
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
        Me.btnSave.ImageIndex = 1
        Me.btnSave.ImageList = Me.imgList
        Me.btnSave.Location = New System.Drawing.Point(5, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Lưu thiết lập"
        '
        'btnAll
        '
        Me.btnAll.Enabled = False
        Me.btnAll.ImageIndex = 2
        Me.btnAll.ImageList = Me.imgList
        Me.btnAll.Location = New System.Drawing.Point(121, 6)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(105, 30)
        Me.btnAll.TabIndex = 1
        Me.btnAll.Text = "Chọn tất cả"
        '
        'frmDonviGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(749, 610)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonviGroupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Phân chức năng cho nhóm [Dành cho Quản trị Đơn vị]"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.groupDVG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupDVG.ResumeLayout(False)
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookDonVi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupFunctionForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFunctionForm.ResumeLayout(False)
        CType(Me.listForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents groupDVG As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents groupFunctionForm As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents listForm As DevExpress.XtraTreeList.TreeList
    Friend WithEvents BTNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents lookDonVi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents listGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents DVGNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
End Class
