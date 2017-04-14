<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridExport
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.lblType = New DevExpress.XtraEditors.LabelControl
        Me.lblPath = New DevExpress.XtraEditors.LabelControl
        Me.cboType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtPath = New DevExpress.XtraEditors.TextEdit
        Me.btnPath = New DevExpress.XtraEditors.SimpleButton
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.lblFileName = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 131)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(378, 39)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFileName)
        Me.GroupControl1.Controls.Add(Me.lblFileName)
        Me.GroupControl1.Controls.Add(Me.btnPath)
        Me.GroupControl1.Controls.Add(Me.txtPath)
        Me.GroupControl1.Controls.Add(Me.cboType)
        Me.GroupControl1.Controls.Add(Me.lblPath)
        Me.GroupControl1.Controls.Add(Me.lblType)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(378, 131)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Options"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.ImageIndex = 3
        Me.btnExport.Location = New System.Drawing.Point(172, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(92, 28)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageIndex = 3
        Me.btnCancel.Location = New System.Drawing.Point(275, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(23, 37)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(24, 13)
        Me.lblType.TabIndex = 5
        Me.lblType.Text = "Type"
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(23, 70)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(22, 13)
        Me.lblPath.TabIndex = 6
        Me.lblPath.Text = "Path"
        '
        'cboType
        '
        Me.cboType.Location = New System.Drawing.Point(76, 34)
        Me.cboType.Name = "cboType"
        Me.cboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType.Properties.Items.AddRange(New Object() {"XLS", "PDF", "RTF", "HTML", "CSV"})
        Me.cboType.Size = New System.Drawing.Size(121, 20)
        Me.cboType.TabIndex = 7
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(76, 67)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(256, 20)
        Me.txtPath.TabIndex = 8
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(336, 66)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(25, 23)
        Me.btnPath.TabIndex = 9
        Me.btnPath.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(76, 99)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(121, 20)
        Me.txtFileName.TabIndex = 11
        '
        'lblFileName
        '
        Me.lblFileName.Location = New System.Drawing.Point(23, 102)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(46, 13)
        Me.lblFileName.TabIndex = 10
        Me.lblFileName.Text = "File Name"
        '
        'frmGridExport
        '
        Me.AcceptButton = Me.btnExport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(378, 170)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGridExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Data"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPath As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPath As DevExpress.XtraEditors.SimpleButton
End Class
