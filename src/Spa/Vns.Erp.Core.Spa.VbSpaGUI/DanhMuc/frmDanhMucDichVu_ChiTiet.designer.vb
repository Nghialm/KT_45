Imports Vns.Erp.Core.Spa.Domain

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucDichVu_ChiTiet
    Inherits FrmBaseDmChiTiet



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
        Me.cboDMCha = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTenThe = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtMa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtGia = New DevExpress.XtraEditors.TextEdit
        Me.txtKyHieu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtMota = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.cboDMCha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenThe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKyHieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.cboDMCha)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTenThe)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMa)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtGia)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKyHieu)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMota)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl19)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(334, 112)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin dịch vụ"
        '
        'cboDMCha
        '
        Me.cboDMCha.EnterMoveNextControl = True
        Me.cboDMCha.Location = New System.Drawing.Point(206, 85)
        Me.cboDMCha.Name = "cboDMCha"
        Me.cboDMCha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMCha.Properties.NullText = ""
        Me.cboDMCha.Size = New System.Drawing.Size(117, 20)
        Me.cboDMCha.TabIndex = 5
        '
        'txtTenThe
        '
        Me.txtTenThe.EnterMoveNextControl = True
        Me.txtTenThe.Location = New System.Drawing.Point(76, 33)
        Me.txtTenThe.Name = "txtTenThe"
        Me.txtTenThe.Size = New System.Drawing.Size(247, 20)
        Me.txtTenThe.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã DV"
        '
        'txtMa
        '
        Me.txtMa.EnterMoveNextControl = True
        Me.txtMa.Location = New System.Drawing.Point(76, 7)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(83, 20)
        Me.txtMa.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Tên DV"
        '
        'txtGia
        '
        Me.txtGia.EnterMoveNextControl = True
        Me.txtGia.Location = New System.Drawing.Point(76, 85)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGia.Properties.Mask.EditMask = "n0"
        Me.txtGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGia.Size = New System.Drawing.Size(83, 20)
        Me.txtGia.TabIndex = 4
        '
        'txtKyHieu
        '
        Me.txtKyHieu.EnterMoveNextControl = True
        Me.txtKyHieu.Location = New System.Drawing.Point(206, 7)
        Me.txtKyHieu.Name = "txtKyHieu"
        Me.txtKyHieu.Size = New System.Drawing.Size(117, 20)
        Me.txtKyHieu.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(165, 10)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Ký hiệu"
        '
        'txtMota
        '
        Me.txtMota.EnterMoveNextControl = True
        Me.txtMota.Location = New System.Drawing.Point(76, 59)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Size = New System.Drawing.Size(247, 20)
        Me.txtMota.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Mô tả"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Đơn giá"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(165, 88)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl19.TabIndex = 0
        Me.LabelControl19.Text = "DM gốc"
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Controls.Add(Me.LabelControl13)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 116)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me._ActionPanel.Size = New System.Drawing.Size(334, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(253, 3)
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
        Me.btnClear.Location = New System.Drawing.Point(137, 3)
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
        Me.btnSave.Location = New System.Drawing.Point(0, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl13.TabIndex = 4
        '
        'frmDanhMucDichVu_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 154)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucDichVu_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin dịch vụ"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.cboDMCha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenThe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKyHieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me._ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenThe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKyHieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDMCha As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtGia As DevExpress.XtraEditors.TextEdit
End Class
