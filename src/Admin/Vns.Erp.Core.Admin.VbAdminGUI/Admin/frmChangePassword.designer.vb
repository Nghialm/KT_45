<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.imglImporterEdit = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grpUserInfo = New DevExpress.XtraEditors.GroupControl()
        Me.txtOldPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRetype = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.lblSeriesID = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFamilyID = New DevExpress.XtraEditors.LabelControl()
        Me.lblImporterSeriesName = New DevExpress.XtraEditors.LabelControl()
        Me.lblImporter = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserInfo.SuspendLayout()
        CType(Me.txtOldPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Location = New System.Drawing.Point(9, 242)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(428, 47)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.ImageIndex = 1
        Me.btnClose.ImageList = Me.imglImporterEdit
        Me.btnClose.Location = New System.Drawing.Point(209, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 36)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 3
        Me.btnSave.ImageList = Me.imglImporterEdit
        Me.btnSave.Location = New System.Drawing.Point(105, 10)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.txtOldPassword)
        Me.grpUserInfo.Controls.Add(Me.LabelControl1)
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
        Me.grpUserInfo.Size = New System.Drawing.Size(428, 232)
        Me.grpUserInfo.TabIndex = 0
        Me.grpUserInfo.Text = "User Information"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(139, 114)
        Me.txtOldPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(271, 22)
        Me.txtOldPassword.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 119)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Old Password"
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(139, 186)
        Me.txtRetype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetype.Size = New System.Drawing.Size(271, 22)
        Me.txtRetype.TabIndex = 9
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(139, 150)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(271, 22)
        Me.txtUserPassword.TabIndex = 7
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(139, 79)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(271, 22)
        Me.txtFullName.TabIndex = 3
        '
        'lblSeriesID
        '
        Me.lblSeriesID.Location = New System.Drawing.Point(63, 155)
        Me.lblSeriesID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblSeriesID.Name = "lblSeriesID"
        Me.lblSeriesID.Size = New System.Drawing.Size(55, 16)
        Me.lblSeriesID.TabIndex = 6
        Me.lblSeriesID.Text = "Password"
        '
        'lblCarFamilyID
        '
        Me.lblCarFamilyID.Location = New System.Drawing.Point(63, 84)
        Me.lblCarFamilyID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCarFamilyID.Name = "lblCarFamilyID"
        Me.lblCarFamilyID.Size = New System.Drawing.Size(57, 16)
        Me.lblCarFamilyID.TabIndex = 2
        Me.lblCarFamilyID.Text = "Full Name"
        '
        'lblImporterSeriesName
        '
        Me.lblImporterSeriesName.Location = New System.Drawing.Point(19, 191)
        Me.lblImporterSeriesName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblImporterSeriesName.Name = "lblImporterSeriesName"
        Me.lblImporterSeriesName.Size = New System.Drawing.Size(98, 16)
        Me.lblImporterSeriesName.TabIndex = 8
        Me.lblImporterSeriesName.Text = "Retype Password"
        '
        'lblImporter
        '
        Me.lblImporter.Location = New System.Drawing.Point(56, 50)
        Me.lblImporter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblImporter.Name = "lblImporter"
        Me.lblImporter.Size = New System.Drawing.Size(63, 16)
        Me.lblImporter.TabIndex = 0
        Me.lblImporter.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(139, 46)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(271, 22)
        Me.txtUserName.TabIndex = 1
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 299)
        Me.Controls.Add(Me.grpUserInfo)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.Padding = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Text = "Change User Password"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        CType(Me.txtOldPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NAMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents imglImporterEdit As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpUserInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSeriesID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCarFamilyID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImporterSeriesName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImporter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRetype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
