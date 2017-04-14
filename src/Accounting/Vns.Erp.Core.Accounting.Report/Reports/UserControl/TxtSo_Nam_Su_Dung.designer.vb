<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TxtSo_Nam_Su_Dung
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
        Me.LblSoNamSuDung = New DevExpress.XtraEditors.LabelControl
        Me.txtNam = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSoNamSuDung
        '
        Me.LblSoNamSuDung.Location = New System.Drawing.Point(3, 5)
        Me.LblSoNamSuDung.Name = "LblSoNamSuDung"
        Me.LblSoNamSuDung.Size = New System.Drawing.Size(77, 13)
        Me.LblSoNamSuDung.TabIndex = 5
        Me.LblSoNamSuDung.Text = "Số năm sử dụng"
        '
        'txtNam
        '
        Me.txtNam.EnterMoveNextControl = True
        Me.txtNam.Location = New System.Drawing.Point(122, 3)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Properties.Mask.EditMask = "[0-9]+"
        Me.txtNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNam.Size = New System.Drawing.Size(184, 20)
        Me.txtNam.TabIndex = 6
        '
        'TxtSo_Nam_Su_Dung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.LblSoNamSuDung)
        Me.Name = "TxtSo_Nam_Su_Dung"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSoNamSuDung As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNam As DevExpress.XtraEditors.TextEdit

End Class
