<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookup_MulTai_Khoan
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtMA_TK_LIENQUAN = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtMA_TK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn tên tài khoản "
        '
        'txtMA_TK_LIENQUAN
        '
        Me.txtMA_TK_LIENQUAN.EnterMoveNextControl = True
        Me.txtMA_TK_LIENQUAN.Location = New System.Drawing.Point(123, 3)
        Me.txtMA_TK_LIENQUAN.Name = "txtMA_TK_LIENQUAN"
        Me.txtMA_TK_LIENQUAN.Size = New System.Drawing.Size(184, 20)
        Me.txtMA_TK_LIENQUAN.TabIndex = 4
        '
        'Lookup_MulTai_Khoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtMA_TK_LIENQUAN)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Lookup_MulTai_Khoan"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.txtMA_TK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMA_TK_LIENQUAN As DevExpress.XtraEditors.TextEdit

End Class
