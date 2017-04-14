<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiExportButton
    Inherits System.Windows.Forms.UserControl

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiExportButton))
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.ImageIndex = 0
        Me.btnExport.ImageList = Me.imgList
        Me.btnExport.Location = New System.Drawing.Point(3, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(131, 30)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Xuất dữ liệu (Alt+E)"
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "icon-excel-16x16.gif")
        '
        'MultiExportButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExport)
        Me.Name = "MultiExportButton"
        Me.Size = New System.Drawing.Size(135, 30)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList

End Class
