
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucNhomKhachHang_ChiTiet
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
        Me.components = New System.ComponentModel.Container()
        Me.depDM_NKH = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtLOAI = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_NHOM_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_NHOM_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.depDM_NKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtLOAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_NHOM_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_NHOM_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'depDM_NKH
        '
        Me.depDM_NKH.ContainerControl = Me
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(3, 132)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(456, 34)
        Me.PanelControl2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 8
        Me.btnClose.Location = New System.Drawing.Point(376, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Quay ra"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(0, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtLOAI)
        Me.PanelControl1.Controls.Add(Me.txtTEN_NHOM_KHANG)
        Me.PanelControl1.Controls.Add(Me.txtKY_HIEU)
        Me.PanelControl1.Controls.Add(Me.txtMA_NHOM_KHANG)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(456, 129)
        Me.PanelControl1.TabIndex = 0
        '
        'txtLOAI
        '
        Me.txtLOAI.EnterMoveNextControl = True
        Me.txtLOAI.Location = New System.Drawing.Point(139, 89)
        Me.txtLOAI.Name = "txtLOAI"
        Me.txtLOAI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI.Properties.Mask.EditMask = "[1-3]{1}"
        Me.txtLOAI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtLOAI.Properties.MaxLength = 1
        Me.txtLOAI.Size = New System.Drawing.Size(56, 20)
        Me.txtLOAI.TabIndex = 12
        '
        'txtTEN_NHOM_KHANG
        '
        Me.txtTEN_NHOM_KHANG.EnterMoveNextControl = True
        Me.txtTEN_NHOM_KHANG.Location = New System.Drawing.Point(139, 62)
        Me.txtTEN_NHOM_KHANG.Name = "txtTEN_NHOM_KHANG"
        Me.txtTEN_NHOM_KHANG.Size = New System.Drawing.Size(304, 20)
        Me.txtTEN_NHOM_KHANG.TabIndex = 11
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(139, 35)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(304, 20)
        Me.txtKY_HIEU.TabIndex = 10
        '
        'txtMA_NHOM_KHANG
        '
        Me.txtMA_NHOM_KHANG.EnterMoveNextControl = True
        Me.txtMA_NHOM_KHANG.Location = New System.Drawing.Point(139, 8)
        Me.txtMA_NHOM_KHANG.Name = "txtMA_NHOM_KHANG"
        Me.txtMA_NHOM_KHANG.Size = New System.Drawing.Size(89, 20)
        Me.txtMA_NHOM_KHANG.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(Nhập giá trị 1 hoặc 2 hoặc 3)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Loại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tên nhóm khách hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ký hiệu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã nhóm khách hàng"
        '
        'frmDanhMucNhomKhachHang_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(462, 169)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Name = "frmDanhMucNhomKhachHang_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "frmDanhMucNhomKhachHang_ChiTiet"
        CType(Me.depDM_NKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtLOAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_NHOM_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_NHOM_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents depDM_NKH As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLOAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTEN_NHOM_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMA_NHOM_KHANG As DevExpress.XtraEditors.TextEdit
End Class
