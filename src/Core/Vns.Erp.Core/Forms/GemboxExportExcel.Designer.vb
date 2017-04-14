<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GemboxExportExcel
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GemboxExportExcel))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.lblFileName = New DevExpress.XtraEditors.LabelControl
        Me.btnPath = New DevExpress.XtraEditors.SimpleButton
        Me.txtPath = New DevExpress.XtraEditors.TextEdit
        Me.lblPath = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 103)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(443, 39)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageIndex = 3
        Me.btnCancel.ImageList = Me.imglImporter
        Me.btnCancel.Location = New System.Drawing.Point(227, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "save-as-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "close-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "copy-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "edit-32x32.png")
        Me.imglImporter.Images.SetKeyName(5, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(6, "open-32x32.png")
        Me.imglImporter.Images.SetKeyName(7, "preview-32x32.png")
        Me.imglImporter.Images.SetKeyName(8, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(9, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(10, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(11, "save-and-close-32x32.png")
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.ImageIndex = 2
        Me.btnExport.ImageList = Me.imglImporter
        Me.btnExport.Location = New System.Drawing.Point(124, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(92, 28)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFileName)
        Me.GroupControl1.Controls.Add(Me.lblFileName)
        Me.GroupControl1.Controls.Add(Me.btnPath)
        Me.GroupControl1.Controls.Add(Me.txtPath)
        Me.GroupControl1.Controls.Add(Me.lblPath)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(443, 101)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Options"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(76, 62)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(168, 20)
        Me.txtFileName.TabIndex = 11
        '
        'lblFileName
        '
        Me.lblFileName.Location = New System.Drawing.Point(12, 65)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(46, 13)
        Me.lblFileName.TabIndex = 10
        Me.lblFileName.Text = "File Name"
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(403, 31)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(25, 23)
        Me.btnPath.TabIndex = 9
        Me.btnPath.Text = "..."
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(76, 32)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(321, 20)
        Me.txtPath.TabIndex = 8
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(36, 35)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(22, 13)
        Me.lblPath.TabIndex = 6
        Me.lblPath.Text = "Path"
        '
        'GemboxExportExcel
        '
        Me.AcceptButton = Me.btnExport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(443, 142)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GemboxExportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Data"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPath As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
End Class
