<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonviGroupBaocao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonviGroupBaocao))
        Me.imgAll = New System.Windows.Forms.ImageList()
        Me.imgList = New System.Windows.Forms.ImageList()
        Me.groupFunctionForm = New DevExpress.XtraEditors.GroupControl()
        Me.listBC = New DevExpress.XtraTreeList.TreeList()
        Me.TEN_BAOCAO = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.groupDVG = New DevExpress.XtraEditors.GroupControl()
        Me.listGroup = New DevExpress.XtraTreeList.TreeList()
        Me.DVGNAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.lookDonVi = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.groupFunctionForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFunctionForm.SuspendLayout()
        CType(Me.listBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.groupDVG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupDVG.SuspendLayout()
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookDonVi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgAll
        '
        Me.imgAll.ImageStream = CType(resources.GetObject("imgAll.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAll.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAll.Images.SetKeyName(0, "report_blue.png")
        Me.imgAll.Images.SetKeyName(1, "report_green.png")
        Me.imgAll.Images.SetKeyName(2, "report_yellow.png")
        Me.imgAll.Images.SetKeyName(3, "report_violet.png")
        Me.imgAll.Images.SetKeyName(4, "group32.png")
        Me.imgAll.Images.SetKeyName(5, "donvi32.png")
        Me.imgAll.Images.SetKeyName(6, "user_group32.png")
        Me.imgAll.Images.SetKeyName(7, "user32.png")
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "pcCloseButton.png")
        Me.imgList.Images.SetKeyName(1, "BtnSave.png")
        Me.imgList.Images.SetKeyName(2, "Copy of save-32x32.png")
        '
        'groupFunctionForm
        '
        Me.groupFunctionForm.Controls.Add(Me.listBC)
        Me.groupFunctionForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupFunctionForm.Location = New System.Drawing.Point(0, 0)
        Me.groupFunctionForm.Name = "groupFunctionForm"
        Me.groupFunctionForm.Size = New System.Drawing.Size(428, 565)
        Me.groupFunctionForm.TabIndex = 1
        Me.groupFunctionForm.Text = "Danh sách báo cáo"
        '
        'listBC
        '
        Me.listBC.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TEN_BAOCAO})
        Me.listBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBC.KeyFieldName = "Id"
        Me.listBC.Location = New System.Drawing.Point(2, 22)
        Me.listBC.Name = "listBC"
        Me.listBC.OptionsBehavior.Editable = False
        Me.listBC.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listBC.OptionsView.ShowCheckBoxes = True
        Me.listBC.OptionsView.ShowColumns = False
        Me.listBC.OptionsView.ShowIndicator = False
        Me.listBC.ParentFieldName = "IdCha"
        Me.listBC.SelectImageList = Me.imgAll
        Me.listBC.Size = New System.Drawing.Size(424, 541)
        Me.listBC.TabIndex = 0
        '
        'TEN_BAOCAO
        '
        Me.TEN_BAOCAO.Caption = "TEN_BAOCAO"
        Me.TEN_BAOCAO.FieldName = "TenBaocao"
        Me.TEN_BAOCAO.MinWidth = 35
        Me.TEN_BAOCAO.Name = "TEN_BAOCAO"
        Me.TEN_BAOCAO.Visible = True
        Me.TEN_BAOCAO.VisibleIndex = 0
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
        Me.SplitContainerControl1.TabIndex = 1
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
        Me.listGroup.KeyFieldName = "GROUPID"
        Me.listGroup.Location = New System.Drawing.Point(2, 42)
        Me.listGroup.Name = "listGroup"
        Me.listGroup.OptionsBehavior.Editable = False
        Me.listGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listGroup.OptionsView.ShowColumns = False
        Me.listGroup.OptionsView.ShowIndicator = False
        Me.listGroup.SelectImageList = Me.imgAll
        Me.listGroup.Size = New System.Drawing.Size(311, 521)
        Me.listGroup.TabIndex = 6
        '
        'DVGNAME
        '
        Me.DVGNAME.Caption = "DVGNAME"
        Me.DVGNAME.FieldName = "DVGNAME"
        Me.DVGNAME.Name = "DVGNAME"
        Me.DVGNAME.Visible = True
        Me.DVGNAME.VisibleIndex = 0
        '
        'lookDonVi
        '
        Me.lookDonVi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lookDonVi.Location = New System.Drawing.Point(2, 22)
        Me.lookDonVi.Name = "lookDonVi"
        Me.lookDonVi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookDonVi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DVGID", "Mã đơn vị", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DVGNAME", 150, "Tên đơn vị")})
        Me.lookDonVi.Properties.DisplayMember = "DVGNAME"
        Me.lookDonVi.Properties.NullText = "Chọn đơn vị để tạo danh sách báo cáo"
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
        'frmDonviGroupBaocao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(749, 610)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonviGroupBaocao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Thiết lập báo cáo"
        CType(Me.groupFunctionForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFunctionForm.ResumeLayout(False)
        CType(Me.listBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.groupDVG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupDVG.ResumeLayout(False)
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookDonVi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents groupFunctionForm As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listBC As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TEN_BAOCAO As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents groupDVG As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents DVGNAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lookDonVi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
