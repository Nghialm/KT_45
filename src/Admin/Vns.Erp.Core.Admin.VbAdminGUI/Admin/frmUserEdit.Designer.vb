<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserEdit))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.imglImporterEdit = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.lblImporter = New DevExpress.XtraEditors.LabelControl()
        Me.lblImporterSeriesName = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFamilyID = New DevExpress.XtraEditors.LabelControl()
        Me.lblSeriesID = New DevExpress.XtraEditors.LabelControl()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtRetype = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtTel = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDONVI_ID = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grpUserInfo = New DevExpress.XtraEditors.GroupControl()
        Me.treeGroup = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDONVI_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserInfo.SuspendLayout()
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(9, 471)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(428, 47)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.ImageIndex = 1
        Me.btnClose.ImageList = Me.imglImporterEdit
        Me.btnClose.Location = New System.Drawing.Point(272, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 36)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Đóng"
        '
        'btnClear
        '
        Me.btnClear.ImageIndex = 2
        Me.btnClear.ImageList = Me.imglImporterEdit
        Me.btnClear.Location = New System.Drawing.Point(166, 10)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 36)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 3
        Me.btnSave.ImageList = Me.imglImporterEdit
        Me.btnSave.Location = New System.Drawing.Point(59, 10)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(139, 46)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(269, 22)
        Me.txtUserName.TabIndex = 1
        '
        'lblImporter
        '
        Me.lblImporter.Location = New System.Drawing.Point(61, 49)
        Me.lblImporter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblImporter.Name = "lblImporter"
        Me.lblImporter.Size = New System.Drawing.Size(59, 17)
        Me.lblImporter.TabIndex = 0
        Me.lblImporter.Text = "Tài khoản"
        '
        'lblImporterSeriesName
        '
        Me.lblImporterSeriesName.Location = New System.Drawing.Point(29, 153)
        Me.lblImporterSeriesName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblImporterSeriesName.Name = "lblImporterSeriesName"
        Me.lblImporterSeriesName.Size = New System.Drawing.Size(94, 17)
        Me.lblImporterSeriesName.TabIndex = 6
        Me.lblImporterSeriesName.Text = "Gõ lại mật khẩu"
        '
        'lblCarFamilyID
        '
        Me.lblCarFamilyID.Location = New System.Drawing.Point(59, 84)
        Me.lblCarFamilyID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCarFamilyID.Name = "lblCarFamilyID"
        Me.lblCarFamilyID.Size = New System.Drawing.Size(60, 17)
        Me.lblCarFamilyID.TabIndex = 2
        Me.lblCarFamilyID.Text = "Họ và tên"
        '
        'lblSeriesID
        '
        Me.lblSeriesID.Location = New System.Drawing.Point(63, 118)
        Me.lblSeriesID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblSeriesID.Name = "lblSeriesID"
        Me.lblSeriesID.Size = New System.Drawing.Size(56, 17)
        Me.lblSeriesID.TabIndex = 4
        Me.lblSeriesID.Text = "Mật khẩu"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(139, 80)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(269, 22)
        Me.txtFullName.TabIndex = 3
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(139, 114)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(269, 22)
        Me.txtUserPassword.TabIndex = 5
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(139, 149)
        Me.txtRetype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetype.Size = New System.Drawing.Size(269, 22)
        Me.txtRetype.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(98, 222)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(18, 16)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Tel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(86, 187)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(139, 183)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(269, 22)
        Me.txtEmail.TabIndex = 9
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(139, 218)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(269, 22)
        Me.txtTel.TabIndex = 11
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(78, 256)
        Me.labelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(40, 17)
        Me.labelControl11.TabIndex = 12
        Me.labelControl11.Text = "Đơn vị"
        '
        'cboDONVI_ID
        '
        Me.cboDONVI_ID.EnterMoveNextControl = True
        Me.cboDONVI_ID.Location = New System.Drawing.Point(139, 252)
        Me.cboDONVI_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDONVI_ID.Name = "cboDONVI_ID"
        Me.cboDONVI_ID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboDONVI_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDONVI_ID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Mã", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonvi", "Tên đơn vị")})
        Me.cboDONVI_ID.Properties.DisplayMember = "TenDonvi"
        Me.cboDONVI_ID.Properties.ImmediatePopup = True
        Me.cboDONVI_ID.Properties.NullText = ""
        Me.cboDONVI_ID.Properties.ValueMember = "Id"
        Me.cboDONVI_ID.Size = New System.Drawing.Size(269, 22)
        Me.cboDONVI_ID.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(83, 290)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Nhóm"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.treeGroup)
        Me.grpUserInfo.Controls.Add(Me.LabelControl3)
        Me.grpUserInfo.Controls.Add(Me.cboDONVI_ID)
        Me.grpUserInfo.Controls.Add(Me.labelControl11)
        Me.grpUserInfo.Controls.Add(Me.txtTel)
        Me.grpUserInfo.Controls.Add(Me.txtEmail)
        Me.grpUserInfo.Controls.Add(Me.LabelControl1)
        Me.grpUserInfo.Controls.Add(Me.LabelControl2)
        Me.grpUserInfo.Controls.Add(Me.txtRetype)
        Me.grpUserInfo.Controls.Add(Me.txtUserPassword)
        Me.grpUserInfo.Controls.Add(Me.txtFullName)
        Me.grpUserInfo.Controls.Add(Me.lblSeriesID)
        Me.grpUserInfo.Controls.Add(Me.lblCarFamilyID)
        Me.grpUserInfo.Controls.Add(Me.lblImporterSeriesName)
        Me.grpUserInfo.Controls.Add(Me.lblImporter)
        Me.grpUserInfo.Controls.Add(Me.txtUserName)
        Me.grpUserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUserInfo.Location = New System.Drawing.Point(9, 10)
        Me.grpUserInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(428, 461)
        Me.grpUserInfo.TabIndex = 0
        Me.grpUserInfo.Text = "Thông tin người dùng"
        '
        'treeGroup
        '
        Me.treeGroup.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2})
        Me.treeGroup.KeyFieldName = "Id"
        Me.treeGroup.Location = New System.Drawing.Point(139, 290)
        Me.treeGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.treeGroup.Name = "treeGroup"
        Me.treeGroup.OptionsBehavior.Editable = False
        Me.treeGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeGroup.OptionsView.ShowCheckBoxes = True
        Me.treeGroup.OptionsView.ShowIndicator = False
        Me.treeGroup.ParentFieldName = ""
        Me.treeGroup.Size = New System.Drawing.Size(269, 155)
        Me.treeGroup.TabIndex = 17
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "Ký hiệu"
        Me.TreeListColumn1.FieldName = "Id"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.Width = 20
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "Tên"
        Me.TreeListColumn2.FieldName = "Grouptext"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 0
        '
        'frmUserEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 528)
        Me.Controls.Add(Me.grpUserInfo)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserEdit"
        Me.Padding = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Text = "Cập nhật thông tin người dùng"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDONVI_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        CType(Me.treeGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NAMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents imglImporterEdit As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImporter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImporterSeriesName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCarFamilyID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSeriesID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRetype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDONVI_ID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpUserInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents treeGroup As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
