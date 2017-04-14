<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TxtNgay
    Inherits KTY_UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtTuNgay = New DevExpress.XtraEditors.DateEdit
        Me.lblNgay = New DevExpress.XtraEditors.LabelControl
        CType(Me.dtTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTuNgay
        '
        Me.dtTuNgay.EditValue = Nothing
        Me.dtTuNgay.EnterMoveNextControl = True
        Me.dtTuNgay.Location = New System.Drawing.Point(122, 3)
        Me.dtTuNgay.Name = "dtTuNgay"
        Me.dtTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtTuNgay.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtTuNgay.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dtTuNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtTuNgay.Size = New System.Drawing.Size(184, 20)
        Me.dtTuNgay.TabIndex = 0
        '
        'lblNgay
        '
        Me.lblNgay.Location = New System.Drawing.Point(3, 5)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(47, 13)
        Me.lblNgay.TabIndex = 1
        Me.lblNgay.Text = "Từ ngày :"
        '
        'TxtNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNgay)
        Me.Controls.Add(Me.dtTuNgay)
        Me.Name = "TxtNgay"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.dtTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtTuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblNgay As DevExpress.XtraEditors.LabelControl

End Class
