<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupEdit))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.imglImporterEdit = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grpGroupInfo = New DevExpress.XtraEditors.GroupControl()
        Me.lblDonVi = New DevExpress.XtraEditors.LabelControl()
        Me.treeDV = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblImporter = New DevExpress.XtraEditors.LabelControl()
        Me.txtGROUPTEXT = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpGroupInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroupInfo.SuspendLayout()
        CType(Me.treeDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGROUPTEXT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.imgList.Images.SetKeyName(19, "cube_blue.png")
        Me.imgList.Images.SetKeyName(20, "cube_green.png")
        Me.imgList.Images.SetKeyName(21, "cube_yellow.png")
        '
        'imglImporterEdit
        '
        Me.imglImporterEdit.ImageStream = CType(resources.GetObject("imglImporterEdit.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporterEdit.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporterEdit.Images.SetKeyName(0, "Add.bmp")
        Me.imglImporterEdit.Images.SetKeyName(1, "pcCloseButton.png")
        Me.imglImporterEdit.Images.SetKeyName(2, "ButtonRefresh.png")
        Me.imglImporterEdit.Images.SetKeyName(3, "ButtonSave.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(8, 221)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(471, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.ImageIndex = 1
        Me.btnClose.ImageList = Me.imglImporterEdit
        Me.btnClose.Location = New System.Drawing.Point(246, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 29)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Đóng"
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 3
        Me.btnSave.ImageList = Me.imglImporterEdit
        Me.btnSave.Location = New System.Drawing.Point(156, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 29)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'grpGroupInfo
        '
        Me.grpGroupInfo.Controls.Add(Me.lblDonVi)
        Me.grpGroupInfo.Controls.Add(Me.treeDV)
        Me.grpGroupInfo.Controls.Add(Me.LabelControl1)
        Me.grpGroupInfo.Controls.Add(Me.lblImporter)
        Me.grpGroupInfo.Controls.Add(Me.txtGROUPTEXT)
        Me.grpGroupInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpGroupInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpGroupInfo.Name = "grpGroupInfo"
        Me.grpGroupInfo.Size = New System.Drawing.Size(471, 213)
        Me.grpGroupInfo.TabIndex = 0
        Me.grpGroupInfo.Text = "Thông tin nhóm người dùng"
        '
        'lblDonVi
        '
        Me.lblDonVi.Location = New System.Drawing.Point(78, 71)
        Me.lblDonVi.Name = "lblDonVi"
        Me.lblDonVi.Size = New System.Drawing.Size(66, 13)
        Me.lblDonVi.TabIndex = 5
        Me.lblDonVi.Text = "LabelControl2"
        Me.lblDonVi.Visible = False
        '
        'treeDV
        '
        Me.treeDV.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3})
        Me.treeDV.Location = New System.Drawing.Point(78, 70)
        Me.treeDV.Name = "treeDV"
        Me.treeDV.OptionsBehavior.Editable = False
        Me.treeDV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeDV.OptionsView.ShowCheckBoxes = True
        Me.treeDV.OptionsView.ShowIndicator = False
        Me.treeDV.Size = New System.Drawing.Size(375, 132)
        Me.treeDV.TabIndex = 3
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "ID"
        Me.TreeListColumn1.FieldName = "Id"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.Width = 20
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "Ký hiệu"
        Me.TreeListColumn2.FieldName = "KyHieu"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 0
        Me.TreeListColumn2.Width = 105
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "Tên đơn vị"
        Me.TreeListColumn3.FieldName = "TenDonvi"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.Visible = True
        Me.TreeListColumn3.VisibleIndex = 1
        Me.TreeListColumn3.Width = 250
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Đơn vị"
        '
        'lblImporter
        '
        Me.lblImporter.Location = New System.Drawing.Point(15, 41)
        Me.lblImporter.Name = "lblImporter"
        Me.lblImporter.Size = New System.Drawing.Size(47, 13)
        Me.lblImporter.TabIndex = 0
        Me.lblImporter.Text = "Tên nhóm"
        '
        'txtGROUPTEXT
        '
        Me.txtGROUPTEXT.Location = New System.Drawing.Point(78, 38)
        Me.txtGROUPTEXT.Name = "txtGROUPTEXT"
        Me.txtGROUPTEXT.Size = New System.Drawing.Size(375, 20)
        Me.txtGROUPTEXT.TabIndex = 1
        '
        'frmGroupEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 267)
        Me.Controls.Add(Me.grpGroupInfo)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGroupEdit"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Cập nhật thông tin nhóm người dùng"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpGroupInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroupInfo.ResumeLayout(False)
        Me.grpGroupInfo.PerformLayout()
        CType(Me.treeDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGROUPTEXT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NAMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents imglImporterEdit As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpGroupInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblImporter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGROUPTEXT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents treeDV As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lblDonVi As DevExpress.XtraEditors.LabelControl
End Class
