<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrantStatusGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrantStatusGroup))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.treeGroup = New DevExpress.XtraTreeList.TreeList()
        Me.GROUPTEXT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imgAll = New System.Windows.Forms.ImageList()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lookUpDV = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.treeLoaiCT = New DevExpress.XtraTreeList.TreeList()
        Me.MA_LOAI_CT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TEN_LOAI_CT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.panelMainDetail = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMota = New DevExpress.XtraEditors.MemoEdit()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.imglImporter = New System.Windows.Forms.ImageList()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lookUpDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.treeLoaiCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.panelMainDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMainDetail.SuspendLayout()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(866, 420)
        Me.SplitContainerControl1.SplitterPosition = 217
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.treeGroup)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 51)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(217, 324)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Danh sách nhóm người dùng"
        '
        'treeGroup
        '
        Me.treeGroup.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GROUPTEXT})
        Me.treeGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGroup.KeyFieldName = "GROUPID"
        Me.treeGroup.Location = New System.Drawing.Point(2, 22)
        Me.treeGroup.Name = "treeGroup"
        Me.treeGroup.OptionsBehavior.Editable = False
        Me.treeGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeGroup.OptionsView.ShowColumns = False
        Me.treeGroup.OptionsView.ShowIndicator = False
        Me.treeGroup.SelectImageList = Me.imgAll
        Me.treeGroup.Size = New System.Drawing.Size(213, 300)
        Me.treeGroup.TabIndex = 0
        '
        'GROUPTEXT
        '
        Me.GROUPTEXT.Caption = "Tên nhóm"
        Me.GROUPTEXT.FieldName = "Grouptext"
        Me.GROUPTEXT.Name = "GROUPTEXT"
        Me.GROUPTEXT.Visible = True
        Me.GROUPTEXT.VisibleIndex = 0
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lookUpDV)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(217, 51)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Danh sách đơn vị"
        '
        'lookUpDV
        '
        Me.lookUpDV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookUpDV.Location = New System.Drawing.Point(2, 22)
        Me.lookUpDV.Name = "lookUpDV"
        Me.lookUpDV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpDV.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonvi", 100, "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonvi", 300, "Tên đơn vị")})
        Me.lookUpDV.Properties.DropDownRows = 15
        Me.lookUpDV.Properties.NullText = ""
        Me.lookUpDV.Properties.PopupWidth = 400
        Me.lookUpDV.Size = New System.Drawing.Size(213, 20)
        Me.lookUpDV.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 375)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(217, 45)
        Me.PanelControl1.TabIndex = 1
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(643, 420)
        Me.SplitContainerControl2.SplitterPosition = 346
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.treeLoaiCT)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(346, 375)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Danh sách loại chứng từ"
        '
        'treeLoaiCT
        '
        Me.treeLoaiCT.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.MA_LOAI_CT, Me.TEN_LOAI_CT})
        Me.treeLoaiCT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeLoaiCT.KeyFieldName = "Id"
        Me.treeLoaiCT.Location = New System.Drawing.Point(2, 22)
        Me.treeLoaiCT.Name = "treeLoaiCT"
        Me.treeLoaiCT.OptionsBehavior.Editable = False
        Me.treeLoaiCT.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeLoaiCT.OptionsView.ShowCheckBoxes = True
        Me.treeLoaiCT.OptionsView.ShowIndicator = False
        Me.treeLoaiCT.SelectImageList = Me.imgAll
        Me.treeLoaiCT.Size = New System.Drawing.Size(342, 351)
        Me.treeLoaiCT.TabIndex = 1
        '
        'MA_LOAI_CT
        '
        Me.MA_LOAI_CT.Caption = "Ký hiệu"
        Me.MA_LOAI_CT.FieldName = "MaLoaiCt"
        Me.MA_LOAI_CT.MinWidth = 35
        Me.MA_LOAI_CT.Name = "MA_LOAI_CT"
        Me.MA_LOAI_CT.Visible = True
        Me.MA_LOAI_CT.VisibleIndex = 0
        Me.MA_LOAI_CT.Width = 91
        '
        'TEN_LOAI_CT
        '
        Me.TEN_LOAI_CT.Caption = "Tên loại chứng từ"
        Me.TEN_LOAI_CT.FieldName = "TenLoaiCt"
        Me.TEN_LOAI_CT.Name = "TEN_LOAI_CT"
        Me.TEN_LOAI_CT.Visible = True
        Me.TEN_LOAI_CT.VisibleIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 375)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(346, 45)
        Me.PanelControl2.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.panelMainDetail)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(291, 375)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Chi tiết trạng thái"
        '
        'panelMainDetail
        '
        Me.panelMainDetail.Controls.Add(Me.LabelControl2)
        Me.panelMainDetail.Controls.Add(Me.txtMota)
        Me.panelMainDetail.Controls.Add(Me.txtStatus)
        Me.panelMainDetail.Controls.Add(Me.LabelControl1)
        Me.panelMainDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainDetail.Location = New System.Drawing.Point(2, 22)
        Me.panelMainDetail.Name = "panelMainDetail"
        Me.panelMainDetail.Size = New System.Drawing.Size(287, 351)
        Me.panelMainDetail.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Mô tả"
        '
        'txtMota
        '
        Me.txtMota.Location = New System.Drawing.Point(15, 110)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Properties.MaxLength = 512
        Me.txtMota.Size = New System.Drawing.Size(258, 135)
        Me.txtMota.TabIndex = 2
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(15, 37)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.MaxLength = 32
        Me.txtStatus.Size = New System.Drawing.Size(258, 20)
        Me.txtStatus.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Trạng thái"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnClose)
        Me.PanelControl3.Controls.Add(Me.btnDelete)
        Me.PanelControl3.Controls.Add(Me.btnUpdate)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 375)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(291, 45)
        Me.PanelControl3.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 7
        Me.btnClose.ImageList = Me.imglImporter
        Me.btnClose.Location = New System.Drawing.Point(194, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Đóng"
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(5, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(6, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(7, "Close-32.png")
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 0
        Me.btnDelete.ImageList = Me.imglImporter
        Me.btnDelete.Location = New System.Drawing.Point(100, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 30)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Xóa"
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageIndex = 4
        Me.btnUpdate.ImageList = Me.imglImporter
        Me.btnUpdate.Location = New System.Drawing.Point(6, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 30)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Cập nhật"
        '
        'frmGrantStatusGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(866, 420)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrantStatusGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập trạng thái loại chứng từ"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lookUpDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.treeLoaiCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.panelMainDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMainDetail.ResumeLayout(False)
        Me.panelMainDetail.PerformLayout()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents treeGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents treeLoaiCT As DevExpress.XtraTreeList.TreeList
    Friend WithEvents panelMainDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GROUPTEXT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents MA_LOAI_CT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TEN_LOAI_CT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgAll As System.Windows.Forms.ImageList
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lookUpDV As DevExpress.XtraEditors.LookUpEdit
End Class
