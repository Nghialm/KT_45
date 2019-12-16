<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class C_SoChungTuf
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSO_CT = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtSO_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSO_CT
        '
        Me.txtSO_CT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSO_CT.Location = New System.Drawing.Point(0, 0)
        Me.txtSO_CT.Name = "txtSO_CT"
        Me.txtSO_CT.Size = New System.Drawing.Size(89, 20)
        Me.txtSO_CT.TabIndex = 0
        '
        'C_SoChungTu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtSO_CT)
        Me.Name = "C_SoChungTu"
        Me.Size = New System.Drawing.Size(90, 20)
        CType(Me.txtSO_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSO_CT As DevExpress.XtraEditors.TextEdit

End Class
