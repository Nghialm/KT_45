Imports Vns.Erp.Core.Spa.Domain

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucCBNV_ChiTiet
    Inherits FrmBaseDmChiTiet

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
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.ckeDaNghi = New DevExpress.XtraEditors.CheckEdit
        Me.dteNgaySinh = New DevExpress.XtraEditors.DateEdit
        Me.txtTenNhanVien = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtMa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtKyHieu = New DevExpress.XtraEditors.TextEdit
        Me.txtSDT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtMota = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.ckeDaNghi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKyHieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.ckeDaNghi)
        Me._GroupControlObjectInfo.Controls.Add(Me.dteNgaySinh)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTenNhanVien)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMa)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKyHieu)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtSDT)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMota)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl5)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl19)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(346, 133)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin nhân viên"
        '
        'ckeDaNghi
        '
        Me.ckeDaNghi.Location = New System.Drawing.Point(85, 111)
        Me.ckeDaNghi.Name = "ckeDaNghi"
        Me.ckeDaNghi.Properties.Caption = ""
        Me.ckeDaNghi.Size = New System.Drawing.Size(19, 19)
        Me.ckeDaNghi.TabIndex = 6
        '
        'dteNgaySinh
        '
        Me.dteNgaySinh.EditValue = Nothing
        Me.dteNgaySinh.EnterMoveNextControl = True
        Me.dteNgaySinh.Location = New System.Drawing.Point(88, 59)
        Me.dteNgaySinh.Name = "dteNgaySinh"
        Me.dteNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNgaySinh.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteNgaySinh.Size = New System.Drawing.Size(83, 20)
        Me.dteNgaySinh.TabIndex = 3
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.EnterMoveNextControl = True
        Me.txtTenNhanVien.Location = New System.Drawing.Point(88, 33)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(247, 20)
        Me.txtTenNhanVien.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã nhân viên"
        '
        'txtMa
        '
        Me.txtMa.EnterMoveNextControl = True
        Me.txtMa.Location = New System.Drawing.Point(88, 7)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(83, 20)
        Me.txtMa.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Tên nhân viên"
        '
        'txtKyHieu
        '
        Me.txtKyHieu.EnterMoveNextControl = True
        Me.txtKyHieu.Location = New System.Drawing.Point(238, 7)
        Me.txtKyHieu.Name = "txtKyHieu"
        Me.txtKyHieu.Size = New System.Drawing.Size(97, 20)
        Me.txtKyHieu.TabIndex = 1
        '
        'txtSDT
        '
        Me.txtSDT.EnterMoveNextControl = True
        Me.txtSDT.Location = New System.Drawing.Point(238, 59)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSDT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSDT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSDT.Size = New System.Drawing.Size(97, 20)
        Me.txtSDT.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(178, 10)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Ký hiệu"
        '
        'txtMota
        '
        Me.txtMota.EnterMoveNextControl = True
        Me.txtMota.Location = New System.Drawing.Point(88, 85)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Size = New System.Drawing.Size(247, 20)
        Me.txtMota.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Ngày sinh"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(178, 62)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "SĐT"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(7, 113)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Đã nghỉ việc"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(7, 88)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl19.TabIndex = 0
        Me.LabelControl19.Text = "Mô tả"
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._ActionPanel.Controls.Add(Me.LabelControl13)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 137)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me._ActionPanel.Size = New System.Drawing.Size(346, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(266, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Appearance.Options.UseFont = True
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(143, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(524, 10)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(19, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 3
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(549, 13)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl13.TabIndex = 5
        Me.LabelControl13.Text = "Cho phép sửa"
        Me.LabelControl13.Visible = False
        '
        'frmDanhMucCBNV_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 175)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucCBNV_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin nhân viên"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.ckeDaNghi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKyHieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me._ActionPanel.PerformLayout()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenNhanVien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKyHieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSDT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeDaNghi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dteNgaySinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
