<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecurity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnEncrypt = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInput = New DevExpress.XtraEditors.TextEdit()
        Me.txtDecrypted = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDecrypt = New DevExpress.XtraEditors.SimpleButton()
        Me.txtError = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDecrypted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(411, 23)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(114, 23)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "Encrypt"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Input String"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(99, 26)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(306, 20)
        Me.txtInput.TabIndex = 2
        '
        'txtDecrypted
        '
        Me.txtDecrypted.Location = New System.Drawing.Point(99, 64)
        Me.txtDecrypted.Name = "txtDecrypted"
        Me.txtDecrypted.Size = New System.Drawing.Size(306, 20)
        Me.txtDecrypted.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Decrypted String"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(411, 61)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(114, 23)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Decrypt"
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(12, 101)
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(513, 20)
        Me.txtError.TabIndex = 6
        '
        'frmSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 191)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.txtDecrypted)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "frmSecurity"
        Me.Text = "Security Generator"
        CType(Me.txtInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDecrypted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDecrypted As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDecrypt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtError As DevExpress.XtraEditors.TextEdit
End Class
