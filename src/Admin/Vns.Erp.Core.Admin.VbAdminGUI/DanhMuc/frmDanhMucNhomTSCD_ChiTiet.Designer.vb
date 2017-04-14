

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucNhomTSCD_ChiTiet
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
        Me.btnXoaTrang = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.pnNHOM_TSCD = New DevExpress.XtraEditors.PanelControl()
        Me.txtLOAI_NHOM = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_NHOM_TSCD = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_NHOM_TSCD = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.depDM_NKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.pnNHOM_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnNHOM_TSCD.SuspendLayout()
        CType(Me.txtLOAI_NHOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_NHOM_TSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_NHOM_TSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl2.Controls.Add(Me.btnXoaTrang)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 101)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(428, 39)
        Me.PanelControl2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 8
        Me.btnClose.Location = New System.Drawing.Point(262, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Quay ra"
        '
        'btnXoaTrang
        '
        Me.btnXoaTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnXoaTrang.ImageIndex = 24
        Me.btnXoaTrang.Location = New System.Drawing.Point(176, 8)
        Me.btnXoaTrang.Name = "btnXoaTrang"
        Me.btnXoaTrang.Size = New System.Drawing.Size(80, 30)
        Me.btnXoaTrang.TabIndex = 1
        Me.btnXoaTrang.Text = "Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(90, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'pnNHOM_TSCD
        '
        Me.pnNHOM_TSCD.Controls.Add(Me.txtLOAI_NHOM)
        Me.pnNHOM_TSCD.Controls.Add(Me.txtTEN_NHOM_TSCD)
        Me.pnNHOM_TSCD.Controls.Add(Me.txtMA_NHOM_TSCD)
        Me.pnNHOM_TSCD.Controls.Add(Me.Label5)
        Me.pnNHOM_TSCD.Controls.Add(Me.Label4)
        Me.pnNHOM_TSCD.Controls.Add(Me.Label2)
        Me.pnNHOM_TSCD.Controls.Add(Me.Label1)
        Me.pnNHOM_TSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnNHOM_TSCD.Location = New System.Drawing.Point(4, 4)
        Me.pnNHOM_TSCD.Name = "pnNHOM_TSCD"
        Me.pnNHOM_TSCD.Size = New System.Drawing.Size(428, 97)
        Me.pnNHOM_TSCD.TabIndex = 0
        '
        'txtLOAI_NHOM
        '
        Me.txtLOAI_NHOM.EnterMoveNextControl = True
        Me.txtLOAI_NHOM.Location = New System.Drawing.Point(114, 62)
        Me.txtLOAI_NHOM.Name = "txtLOAI_NHOM"
        Me.txtLOAI_NHOM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI_NHOM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI_NHOM.Properties.Mask.EditMask = "[1-3]{1}"
        Me.txtLOAI_NHOM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtLOAI_NHOM.Properties.MaxLength = 1
        Me.txtLOAI_NHOM.Size = New System.Drawing.Size(31, 20)
        Me.txtLOAI_NHOM.TabIndex = 12
        '
        'txtTEN_NHOM_TSCD
        '
        Me.txtTEN_NHOM_TSCD.EnterMoveNextControl = True
        Me.txtTEN_NHOM_TSCD.Location = New System.Drawing.Point(114, 36)
        Me.txtTEN_NHOM_TSCD.Name = "txtTEN_NHOM_TSCD"
        Me.txtTEN_NHOM_TSCD.Size = New System.Drawing.Size(304, 20)
        Me.txtTEN_NHOM_TSCD.TabIndex = 10
        '
        'txtMA_NHOM_TSCD
        '
        Me.txtMA_NHOM_TSCD.EnterMoveNextControl = True
        Me.txtMA_NHOM_TSCD.Location = New System.Drawing.Point(114, 9)
        Me.txtMA_NHOM_TSCD.Name = "txtMA_NHOM_TSCD"
        Me.txtMA_NHOM_TSCD.Size = New System.Drawing.Size(142, 20)
        Me.txtMA_NHOM_TSCD.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(Nhập giá trị 1 hoặc 2 hoặc 3)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Loại nhóm TSCD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên nhóm TSCD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã nhóm TSCD"
        '
        'frmDanhMucNhomTSCD_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(436, 144)
        Me.Controls.Add(Me.pnNHOM_TSCD)
        Me.Controls.Add(Me.PanelControl2)
        Me.Name = "frmDanhMucNhomTSCD_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục nhóm tài sản cố định"
        CType(Me.depDM_NKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.pnNHOM_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnNHOM_TSCD.ResumeLayout(False)
        Me.pnNHOM_TSCD.PerformLayout()
        CType(Me.txtLOAI_NHOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_NHOM_TSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_NHOM_TSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents depDM_NKH As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents pnNHOM_TSCD As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaTrang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLOAI_NHOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTEN_NHOM_TSCD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMA_NHOM_TSCD As DevExpress.XtraEditors.TextEdit
End Class
