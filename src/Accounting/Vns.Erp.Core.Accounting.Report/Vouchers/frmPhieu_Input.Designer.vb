<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieu_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieu_Input))
        Me.rdoNgonngu = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtNguoiNhan = New DevExpress.XtraEditors.TextEdit()
        Me.rdoTienTe = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoCtuKem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoLien = New DevExpress.XtraEditors.TextEdit()
        Me.txtTieude = New DevExpress.XtraEditors.TextEdit()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.lkeTemplate = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkOption = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtThuquy = New DevExpress.XtraEditors.TextEdit()
        Me.txtKTtt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKT = New DevExpress.XtraEditors.TextEdit()
        Me.txtThutruong = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDCcty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.rdoNgonngu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNguoiNhan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoTienTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoCtuKem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTieude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtThuquy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKTtt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThutruong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDCcty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoNgonngu
        '
        Me.rdoNgonngu.Location = New System.Drawing.Point(348, 28)
        Me.rdoNgonngu.Name = "rdoNgonngu"
        Me.rdoNgonngu.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tiếng việt"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tiếng Anh")})
        Me.rdoNgonngu.Size = New System.Drawing.Size(114, 48)
        Me.rdoNgonngu.TabIndex = 7
        Me.rdoNgonngu.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tiêu đề báo cáo"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNguoiNhan)
        Me.GroupControl1.Controls.Add(Me.rdoTienTe)
        Me.GroupControl1.Controls.Add(Me.rdoNgonngu)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtSoCtuKem)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtSoLien)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 38)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(482, 113)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Tùy chọn"
        '
        'txtNguoiNhan
        '
        Me.txtNguoiNhan.Location = New System.Drawing.Point(153, 82)
        Me.txtNguoiNhan.Name = "txtNguoiNhan"
        Me.txtNguoiNhan.Size = New System.Drawing.Size(309, 20)
        Me.txtNguoiNhan.TabIndex = 5
        '
        'rdoTienTe
        '
        Me.rdoTienTe.Location = New System.Drawing.Point(228, 28)
        Me.rdoTienTe.Name = "rdoTienTe"
        Me.rdoTienTe.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("VNĐ", "Mẫu VNĐ"), New DevExpress.XtraEditors.Controls.RadioGroupItem("USD", "Mẫu USD")})
        Me.rdoTienTe.Size = New System.Drawing.Size(114, 48)
        Me.rdoTienTe.TabIndex = 6
        Me.rdoTienTe.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(74, 85)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl13.TabIndex = 4
        Me.LabelControl13.Text = "Người giao dịch"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Số chứng từ gốc kèm theo"
        '
        'txtSoCtuKem
        '
        Me.txtSoCtuKem.EditValue = "2"
        Me.txtSoCtuKem.Location = New System.Drawing.Point(153, 55)
        Me.txtSoCtuKem.Name = "txtSoCtuKem"
        Me.txtSoCtuKem.Properties.Mask.EditMask = "\d{1}"
        Me.txtSoCtuKem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSoCtuKem.Size = New System.Drawing.Size(43, 20)
        Me.txtSoCtuKem.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(116, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Số liên"
        '
        'txtSoLien
        '
        Me.txtSoLien.EditValue = "2"
        Me.txtSoLien.Location = New System.Drawing.Point(153, 27)
        Me.txtSoLien.Name = "txtSoLien"
        Me.txtSoLien.Properties.Mask.EditMask = "\d{1}"
        Me.txtSoLien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSoLien.Size = New System.Drawing.Size(43, 20)
        Me.txtSoLien.TabIndex = 1
        '
        'txtTieude
        '
        Me.txtTieude.EditValue = ""
        Me.txtTieude.Location = New System.Drawing.Point(105, 12)
        Me.txtTieude.Name = "txtTieude"
        Me.txtTieude.Size = New System.Drawing.Size(385, 20)
        Me.txtTieude.TabIndex = 1
        '
        'btnXem
        '
        Me.btnXem.ImageIndex = 7
        Me.btnXem.ImageList = Me.imglImporter
        Me.btnXem.Location = New System.Drawing.Point(368, 6)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(92, 28)
        Me.btnXem.TabIndex = 2
        Me.btnXem.Text = "Xem"
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "save-as-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "close-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "copy-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "edit-32x32.png")
        Me.imglImporter.Images.SetKeyName(5, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(6, "open-32x32.png")
        Me.imglImporter.Images.SetKeyName(7, "preview-32x32.png")
        Me.imglImporter.Images.SetKeyName(8, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(9, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(10, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(11, "save-and-close-32x32.png")
        '
        'lkeTemplate
        '
        Me.lkeTemplate.Location = New System.Drawing.Point(195, 10)
        Me.lkeTemplate.Name = "lkeTemplate"
        Me.lkeTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeTemplate.Properties.NullText = ""
        Me.lkeTemplate.Size = New System.Drawing.Size(167, 20)
        Me.lkeTemplate.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.chkOption)
        Me.PanelControl1.Controls.Add(Me.btnXem)
        Me.PanelControl1.Controls.Add(Me.lkeTemplate)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 157)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(482, 40)
        Me.PanelControl1.TabIndex = 3
        '
        'chkOption
        '
        Me.chkOption.Location = New System.Drawing.Point(27, 10)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Properties.Caption = "Mở rộng"
        Me.chkOption.Size = New System.Drawing.Size(60, 19)
        Me.chkOption.TabIndex = 0
        Me.chkOption.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtThuquy)
        Me.PanelControl2.Controls.Add(Me.txtKTtt)
        Me.PanelControl2.Controls.Add(Me.LabelControl12)
        Me.PanelControl2.Controls.Add(Me.txtKT)
        Me.PanelControl2.Controls.Add(Me.txtThutruong)
        Me.PanelControl2.Controls.Add(Me.LabelControl9)
        Me.PanelControl2.Controls.Add(Me.txtDCcty)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txtCty)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 203)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(482, 118)
        Me.PanelControl2.TabIndex = 4
        '
        'txtThuquy
        '
        Me.txtThuquy.EditValue = ""
        Me.txtThuquy.Location = New System.Drawing.Point(323, 61)
        Me.txtThuquy.Name = "txtThuquy"
        Me.txtThuquy.Size = New System.Drawing.Size(137, 20)
        Me.txtThuquy.TabIndex = 9
        '
        'txtKTtt
        '
        Me.txtKTtt.EditValue = ""
        Me.txtKTtt.Location = New System.Drawing.Point(323, 87)
        Me.txtKTtt.Name = "txtKTtt"
        Me.txtKTtt.Size = New System.Drawing.Size(137, 20)
        Me.txtKTtt.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(278, 64)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl12.TabIndex = 8
        Me.LabelControl12.Text = "Thủ quỹ"
        '
        'txtKT
        '
        Me.txtKT.EditValue = ""
        Me.txtKT.Location = New System.Drawing.Point(97, 87)
        Me.txtKT.Name = "txtKT"
        Me.txtKT.Size = New System.Drawing.Size(142, 20)
        Me.txtKT.TabIndex = 7
        '
        'txtThutruong
        '
        Me.txtThutruong.EditValue = ""
        Me.txtThutruong.Location = New System.Drawing.Point(97, 61)
        Me.txtThutruong.Name = "txtThutruong"
        Me.txtThutruong.Size = New System.Drawing.Size(142, 20)
        Me.txtThutruong.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(272, 90)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Người lập"
        '
        'txtDCcty
        '
        Me.txtDCcty.EditValue = ""
        Me.txtDCcty.Location = New System.Drawing.Point(97, 35)
        Me.txtDCcty.Name = "txtDCcty"
        Me.txtDCcty.Size = New System.Drawing.Size(363, 20)
        Me.txtDCcty.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 89)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "Kế toán trưởng"
        '
        'txtCty
        '
        Me.txtCty.EditValue = ""
        Me.txtCty.Location = New System.Drawing.Point(97, 9)
        Me.txtCty.Name = "txtCty"
        Me.txtCty.Size = New System.Drawing.Size(363, 20)
        Me.txtCty.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 64)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Thủ trưởng đơn vị"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(59, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Địa chỉ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(34, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Tên công ty"
        '
        'frmPhieu_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 331)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtTieude)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhieu_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin phiếu"
        CType(Me.rdoNgonngu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtNguoiNhan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoTienTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoCtuKem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTieude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.chkOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtThuquy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKTtt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThutruong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDCcty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoNgonngu As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoCtuKem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoLien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTieude As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkeTemplate As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtThutruong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDCcty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNguoiNhan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtThuquy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKTtt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkOption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents rdoTienTe As DevExpress.XtraEditors.RadioGroup
End Class
