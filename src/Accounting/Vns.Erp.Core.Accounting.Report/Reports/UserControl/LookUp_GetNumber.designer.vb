<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_GetNumber
    Inherits KTY_UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtOLDSTORE = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtOLDSTORE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Tuổi kho"
        '
        'txtOLDSTORE
        '
        Me.txtOLDSTORE.EnterMoveNextControl = True
        Me.txtOLDSTORE.Location = New System.Drawing.Point(123, 3)
        Me.txtOLDSTORE.Name = "txtOLDSTORE"
        Me.txtOLDSTORE.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOLDSTORE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOLDSTORE.Properties.Mask.BeepOnError = True
        Me.txtOLDSTORE.Properties.Mask.EditMask = "\d{0,5}"
        Me.txtOLDSTORE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtOLDSTORE.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtOLDSTORE.Size = New System.Drawing.Size(184, 20)
        Me.txtOLDSTORE.TabIndex = 7
        '
        'LookUp_GetNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtOLDSTORE)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "LookUp_GetNumber"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.txtOLDSTORE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOLDSTORE As DevExpress.XtraEditors.TextEdit

End Class
