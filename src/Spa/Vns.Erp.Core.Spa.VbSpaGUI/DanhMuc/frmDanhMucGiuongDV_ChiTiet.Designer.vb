Imports Vns.Erp.Core.Spa.Domain

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucGiuongDV_ChiTiet
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
        Me.txtMota = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtTenGiuong = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtKH = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenGiuong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMota)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTenGiuong)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKH)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMa)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl1)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(318, 111)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "GroupControl1"
        '
        'txtMota
        '
        Me.txtMota.EnterMoveNextControl = True
        Me.txtMota.Location = New System.Drawing.Point(119, 84)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Size = New System.Drawing.Size(191, 20)
        Me.txtMota.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Mô tả"
        '
        'txtTenGiuong
        '
        Me.txtTenGiuong.EnterMoveNextControl = True
        Me.txtTenGiuong.Location = New System.Drawing.Point(119, 58)
        Me.txtTenGiuong.Name = "txtTenGiuong"
        Me.txtTenGiuong.Size = New System.Drawing.Size(191, 20)
        Me.txtTenGiuong.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Ký hiệu"
        '
        'txtKH
        '
        Me.txtKH.EnterMoveNextControl = True
        Me.txtKH.Location = New System.Drawing.Point(119, 32)
        Me.txtKH.Name = "txtKH"
        Me.txtKH.Size = New System.Drawing.Size(191, 20)
        Me.txtKH.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Tên giường DV"
        '
        'txtMa
        '
        Me.txtMa.EnterMoveNextControl = True
        Me.txtMa.Location = New System.Drawing.Point(119, 6)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(191, 20)
        Me.txtMa.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã giường DV"
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 115)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(318, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(215, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnClear.Appearance.Options.UseFont = True
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(118, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(32, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDMGiuongDV_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 153)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDMGiuongDV_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi tiết giường dịch vụ"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenGiuong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenGiuong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class

