<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhoaSoNgay
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnClo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLastCloseBook = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNewCloseBook = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtLastCloseBook.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastCloseBook.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewCloseBook.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewCloseBook.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNewCloseBook)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtLastCloseBook)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(347, 132)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnClo)
        Me.GroupControl2.Controls.Add(Me.btnSav)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(4, 102)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(347, 34)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'btnClo
        '
        Me.btnClo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClo.ImageIndex = 2
        Me.btnClo.Location = New System.Drawing.Point(177, 2)
        Me.btnClo.Name = "btnClo"
        Me.btnClo.Size = New System.Drawing.Size(80, 30)
        Me.btnClo.TabIndex = 21
        Me.btnClo.Text = "Thoát"
        '
        'btnSav
        '
        Me.btnSav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(91, 2)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(80, 30)
        Me.btnSav.TabIndex = 19
        Me.btnSav.Text = "&Lưu"
        '
        'txtLastCloseBook
        '
        Me.txtLastCloseBook.EditValue = Nothing
        Me.txtLastCloseBook.EnterMoveNextControl = True
        Me.txtLastCloseBook.Location = New System.Drawing.Point(129, 21)
        Me.txtLastCloseBook.Name = "txtLastCloseBook"
        Me.txtLastCloseBook.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLastCloseBook.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.txtLastCloseBook.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtLastCloseBook.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtLastCloseBook.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtLastCloseBook.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLastCloseBook.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.txtLastCloseBook.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtLastCloseBook.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtLastCloseBook.Size = New System.Drawing.Size(118, 20)
        Me.txtLastCloseBook.TabIndex = 12
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Ngày khóa sổ trước đó"
        '
        'txtNewCloseBook
        '
        Me.txtNewCloseBook.EditValue = Nothing
        Me.txtNewCloseBook.EnterMoveNextControl = True
        Me.txtNewCloseBook.Location = New System.Drawing.Point(129, 56)
        Me.txtNewCloseBook.Name = "txtNewCloseBook"
        Me.txtNewCloseBook.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNewCloseBook.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.txtNewCloseBook.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNewCloseBook.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtNewCloseBook.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtNewCloseBook.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNewCloseBook.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.txtNewCloseBook.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtNewCloseBook.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNewCloseBook.Size = New System.Drawing.Size(118, 20)
        Me.txtNewCloseBook.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Chọn ngày khóa sổ mới"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmKhoaSoNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(355, 140)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.KeyPreview = True
        Me.Name = "frmKhoaSoNgay"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khóa sổ kế toán"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtLastCloseBook.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastCloseBook.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewCloseBook.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewCloseBook.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNewCloseBook As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLastCloseBook As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
