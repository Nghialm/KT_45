<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtNumber
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
        Me.lblma_taikhoan = New DevExpress.XtraEditors.LabelControl
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtma_tk = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtma_tk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblma_taikhoan
        '
        Me.lblma_taikhoan.Location = New System.Drawing.Point(3, 5)
        Me.lblma_taikhoan.Name = "lblma_taikhoan"
        Me.lblma_taikhoan.Size = New System.Drawing.Size(96, 13)
        Me.lblma_taikhoan.TabIndex = 0
        Me.lblma_taikhoan.Text = "Chọn mã tài khoản :"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "Id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'txtma_tk
        '
        Me.txtma_tk.EnterMoveNextControl = True
        Me.txtma_tk.Location = New System.Drawing.Point(122, 3)
        Me.txtma_tk.Name = "txtma_tk"
        Me.txtma_tk.Properties.Mask.EditMask = "\d{0,5}"
        Me.txtma_tk.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtma_tk.Size = New System.Drawing.Size(184, 20)
        Me.txtma_tk.TabIndex = 2
        '
        'txtNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtma_tk)
        Me.Controls.Add(Me.lblma_taikhoan)
        Me.Name = "txtNumber"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.txtma_tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblma_taikhoan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtma_tk As DevExpress.XtraEditors.TextEdit

End Class
