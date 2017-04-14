

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucNhomVatTu1_ChiTiet
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
        Me.depDM_NVT1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoaTrang = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.ckbCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.ckbCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.txtLOAI = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMA_NHOM_VT_1 = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_NHOM_VT_1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.depDM_NVT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.ckbCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckbCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLOAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'depDM_NVT1
        '
        Me.depDM_NVT1.ContainerControl = Me
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnXoaTrang)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 123)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(341, 34)
        Me.PanelControl2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 8
        Me.btnClose.Location = New System.Drawing.Point(261, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Quay ra"
        '
        'btnXoaTrang
        '
        Me.btnXoaTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnXoaTrang.ImageIndex = 24
        Me.btnXoaTrang.Location = New System.Drawing.Point(130, 6)
        Me.btnXoaTrang.Name = "btnXoaTrang"
        Me.btnXoaTrang.Size = New System.Drawing.Size(80, 30)
        Me.btnXoaTrang.TabIndex = 1
        Me.btnXoaTrang.Text = "Xóa trắng"
        Me.btnXoaTrang.Visible = False
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(0, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(341, 157)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.ckbCHO_PHEP_SUA)
        Me.PanelControl3.Controls.Add(Me.ckbCO_SU_DUNG)
        Me.PanelControl3.Controls.Add(Me.txtLOAI)
        Me.PanelControl3.Controls.Add(Me.Label4)
        Me.PanelControl3.Controls.Add(Me.txtMA_NHOM_VT_1)
        Me.PanelControl3.Controls.Add(Me.labelControl19)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.txtTEN_NHOM_VT_1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(341, 123)
        Me.PanelControl3.TabIndex = 0
        '
        'ckbCHO_PHEP_SUA
        '
        Me.ckbCHO_PHEP_SUA.Location = New System.Drawing.Point(240, 88)
        Me.ckbCHO_PHEP_SUA.Name = "ckbCHO_PHEP_SUA"
        Me.ckbCHO_PHEP_SUA.Properties.Caption = "Cho phép sửa"
        Me.ckbCHO_PHEP_SUA.Size = New System.Drawing.Size(92, 19)
        Me.ckbCHO_PHEP_SUA.TabIndex = 19
        '
        'ckbCO_SU_DUNG
        '
        Me.ckbCO_SU_DUNG.Location = New System.Drawing.Point(111, 88)
        Me.ckbCO_SU_DUNG.Name = "ckbCO_SU_DUNG"
        Me.ckbCO_SU_DUNG.Properties.Caption = "Có sử dụng"
        Me.ckbCO_SU_DUNG.Size = New System.Drawing.Size(77, 19)
        Me.ckbCO_SU_DUNG.TabIndex = 18
        '
        'txtLOAI
        '
        Me.txtLOAI.EnterMoveNextControl = True
        Me.txtLOAI.Location = New System.Drawing.Point(113, 63)
        Me.txtLOAI.Name = "txtLOAI"
        Me.txtLOAI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtLOAI.Properties.Mask.EditMask = "[1-3]{1}"
        Me.txtLOAI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtLOAI.Properties.MaxLength = 1
        Me.txtLOAI.Size = New System.Drawing.Size(23, 20)
        Me.txtLOAI.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Loại"
        '
        'txtMA_NHOM_VT_1
        '
        Me.txtMA_NHOM_VT_1.EnterMoveNextControl = True
        Me.txtMA_NHOM_VT_1.Location = New System.Drawing.Point(113, 11)
        Me.txtMA_NHOM_VT_1.Name = "txtMA_NHOM_VT_1"
        Me.txtMA_NHOM_VT_1.Size = New System.Drawing.Size(219, 20)
        Me.txtMA_NHOM_VT_1.TabIndex = 0
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(15, 14)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(76, 13)
        Me.labelControl19.TabIndex = 4
        Me.labelControl19.Text = "Mã nhóm vật tư"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(142, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "(Nhập giá trị 1 hoặc 2 hoặc 3)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Tên nhóm vật tư"
        '
        'txtTEN_NHOM_VT_1
        '
        Me.txtTEN_NHOM_VT_1.EnterMoveNextControl = True
        Me.txtTEN_NHOM_VT_1.Location = New System.Drawing.Point(113, 37)
        Me.txtTEN_NHOM_VT_1.Name = "txtTEN_NHOM_VT_1"
        Me.txtTEN_NHOM_VT_1.Size = New System.Drawing.Size(219, 20)
        Me.txtTEN_NHOM_VT_1.TabIndex = 1
        '
        'frmDanhMucNhomVatTu1_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(349, 165)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucNhomVatTu1_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Danh mục nhóm vật tư/Hàng hóa "
        CType(Me.depDM_NVT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.ckbCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckbCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLOAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents depDM_NVT1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaTrang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtMA_NHOM_VT_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTEN_NHOM_VT_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLOAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckbCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckbCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class

