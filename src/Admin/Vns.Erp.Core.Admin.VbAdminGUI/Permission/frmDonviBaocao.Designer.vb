<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonviBaocao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonviBaocao))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.listDonvi = New DevExpress.XtraTreeList.TreeList()
        Me.TEN_DONVI = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.pnForm = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.listBC = New DevExpress.XtraTreeList.TreeList()
        Me.TenBaocao = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imgList = New System.Windows.Forms.ImageList()
        Me.btnAllForm = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveForm = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.listDonvi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnForm.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.listBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
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
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnForm)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(777, 581)
        Me.SplitContainerControl1.SplitterPosition = 298
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.listDonvi)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(298, 536)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách đơn vị"
        '
        'listDonvi
        '
        Me.listDonvi.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TEN_DONVI})
        Me.listDonvi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listDonvi.KeyFieldName = "TenDonvi"
        Me.listDonvi.Location = New System.Drawing.Point(2, 22)
        Me.listDonvi.Name = "listDonvi"
        Me.listDonvi.OptionsBehavior.Editable = False
        Me.listDonvi.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.listDonvi.OptionsView.ShowColumns = False
        Me.listDonvi.OptionsView.ShowIndicator = False
        Me.listDonvi.SelectImageList = Me.imgAll
        Me.listDonvi.Size = New System.Drawing.Size(294, 512)
        Me.listDonvi.TabIndex = 0
        '
        'TEN_DONVI
        '
        Me.TEN_DONVI.Caption = "TEN_DONVI"
        Me.TEN_DONVI.FieldName = "TenDonvi"
        Me.TEN_DONVI.Name = "TEN_DONVI"
        Me.TEN_DONVI.Visible = True
        Me.TEN_DONVI.VisibleIndex = 0
        Me.TEN_DONVI.Width = 250
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
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 536)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(298, 45)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Visible = False
        '
        'pnForm
        '
        Me.pnForm.Controls.Add(Me.GroupControl3)
        Me.pnForm.Controls.Add(Me.PanelControl4)
        Me.pnForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnForm.Location = New System.Drawing.Point(0, 0)
        Me.pnForm.Name = "pnForm"
        Me.pnForm.Size = New System.Drawing.Size(473, 581)
        Me.pnForm.TabIndex = 4
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.listBC)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(469, 532)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Danh sách báo cáo"
        '
        'listBC
        '
        Me.listBC.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TenBaocao})
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
        Me.listBC.Size = New System.Drawing.Size(465, 508)
        Me.listBC.TabIndex = 0
        '
        'TenBaocao
        '
        Me.TenBaocao.Caption = "TEN_BAOCAO"
        Me.TenBaocao.FieldName = "TenBaocao"
        Me.TenBaocao.MinWidth = 35
        Me.TenBaocao.Name = "TenBaocao"
        Me.TenBaocao.Visible = True
        Me.TenBaocao.VisibleIndex = 0
        Me.TenBaocao.Width = 105
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnClose)
        Me.PanelControl4.Controls.Add(Me.btnAllForm)
        Me.PanelControl4.Controls.Add(Me.btnSaveForm)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 534)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(469, 45)
        Me.PanelControl4.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 0
        Me.btnClose.ImageList = Me.imgList
        Me.btnClose.Location = New System.Drawing.Point(260, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 30)
        Me.btnClose.TabIndex = 3
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
        'btnAllForm
        '
        Me.btnAllForm.ImageIndex = 2
        Me.btnAllForm.ImageList = Me.imgList
        Me.btnAllForm.Location = New System.Drawing.Point(116, 10)
        Me.btnAllForm.Name = "btnAllForm"
        Me.btnAllForm.Size = New System.Drawing.Size(138, 30)
        Me.btnAllForm.TabIndex = 1
        Me.btnAllForm.Text = "Chọn tất cả báo cáo"
        '
        'btnSaveForm
        '
        Me.btnSaveForm.Enabled = False
        Me.btnSaveForm.ImageIndex = 1
        Me.btnSaveForm.ImageList = Me.imgList
        Me.btnSaveForm.Location = New System.Drawing.Point(8, 10)
        Me.btnSaveForm.Name = "btnSaveForm"
        Me.btnSaveForm.Size = New System.Drawing.Size(102, 30)
        Me.btnSaveForm.TabIndex = 0
        Me.btnSaveForm.Text = "Lưu thiết lập"
        '
        'frmDonviBaocao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(777, 581)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonviBaocao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Phân quyền báo cáo"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.listDonvi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnForm.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.listBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listDonvi As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TEN_DONVI As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnForm As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listBC As DevExpress.XtraTreeList.TreeList
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents btnAllForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TenBaocao As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
