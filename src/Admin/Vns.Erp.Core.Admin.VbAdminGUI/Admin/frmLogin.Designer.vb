<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.imglImporterEdit = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.grpUserInfo = New DevExpress.XtraEditors.GroupControl()
        Me.lookUpDonVi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkRemember = New DevExpress.XtraEditors.CheckEdit()
        Me.txtUserPassword = New DevExpress.XtraEditors.TextEdit()
        Me.lblSeriesID = New DevExpress.XtraEditors.LabelControl()
        Me.lblImporter = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserInfo.SuspendLayout()
        CType(Me.lookUpDonVi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRemember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imglImporterEdit
        '
        Me.imglImporterEdit.ImageStream = CType(resources.GetObject("imglImporterEdit.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporterEdit.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporterEdit.Images.SetKeyName(0, "key1.png")
        Me.imglImporterEdit.Images.SetKeyName(1, "keys.png")
        Me.imglImporterEdit.Images.SetKeyName(2, "delete2.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnLogin)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(8, 191)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(344, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageIndex = 2
        Me.btnCancel.ImageList = Me.imglImporterEdit
        Me.btnCancel.Location = New System.Drawing.Point(168, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 29)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Bỏ qua"
        '
        'btnLogin
        '
        Me.btnLogin.ImageIndex = 1
        Me.btnLogin.ImageList = Me.imglImporterEdit
        Me.btnLogin.Location = New System.Drawing.Point(81, 6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(83, 29)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "&Đăng nhập"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.lookUpDonVi)
        Me.grpUserInfo.Controls.Add(Me.LabelControl1)
        Me.grpUserInfo.Controls.Add(Me.chkRemember)
        Me.grpUserInfo.Controls.Add(Me.txtUserPassword)
        Me.grpUserInfo.Controls.Add(Me.lblSeriesID)
        Me.grpUserInfo.Controls.Add(Me.lblImporter)
        Me.grpUserInfo.Controls.Add(Me.txtUserName)
        Me.grpUserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUserInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(344, 183)
        Me.grpUserInfo.TabIndex = 0
        Me.grpUserInfo.Text = "Thông tin đăng nhập"
        '
        'lookUpDonVi
        '
        Me.lookUpDonVi.EnterMoveNextControl = True
        Me.lookUpDonVi.Location = New System.Drawing.Point(114, 107)
        Me.lookUpDonVi.Name = "lookUpDonVi"
        Me.lookUpDonVi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpDonVi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonvi", "Mã", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", 80, "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonvi", 150, "Tên")})
        Me.lookUpDonVi.Properties.DisplayMember = "TenDonvi"
        Me.lookUpDonVi.Properties.NullText = "Lựa chọn đơn vị"
        Me.lookUpDonVi.Properties.PopupWidth = 350
        Me.lookUpDonVi.Properties.ValueMember = "Id"
        Me.lookUpDonVi.Size = New System.Drawing.Size(197, 20)
        Me.lookUpDonVi.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(59, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Đơn vị"
        '
        'chkRemember
        '
        Me.chkRemember.Location = New System.Drawing.Point(114, 142)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Properties.Caption = "Ghi nhớ nhật khẩu"
        Me.chkRemember.Size = New System.Drawing.Size(197, 19)
        Me.chkRemember.TabIndex = 6
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(114, 74)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(197, 20)
        Me.txtUserPassword.TabIndex = 3
        '
        'lblSeriesID
        '
        Me.lblSeriesID.Location = New System.Drawing.Point(46, 77)
        Me.lblSeriesID.Name = "lblSeriesID"
        Me.lblSeriesID.Size = New System.Drawing.Size(44, 13)
        Me.lblSeriesID.TabIndex = 2
        Me.lblSeriesID.Text = "Mật khẩu"
        '
        'lblImporter
        '
        Me.lblImporter.Location = New System.Drawing.Point(44, 42)
        Me.lblImporter.Name = "lblImporter"
        Me.lblImporter.Size = New System.Drawing.Size(46, 13)
        Me.lblImporter.TabIndex = 0
        Me.lblImporter.Text = "Tài khoản"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(114, 39)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 20)
        Me.txtUserName.TabIndex = 1
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(360, 237)
        Me.Controls.Add(Me.grpUserInfo)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Đăng nhập"
        Me.TopMost = True
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        CType(Me.lookUpDonVi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRemember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NAMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imglImporterEdit As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpUserInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSeriesID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImporter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkRemember As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookUpDonVi As DevExpress.XtraEditors.LookUpEdit
End Class
