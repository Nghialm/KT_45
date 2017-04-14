<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomFilter
    'Inherits KTY_UserControl
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
        Me.btnShowPopup = New DevExpress.XtraEditors.SimpleButton
        Me.pcMain = New DevExpress.XtraEditors.PanelControl
        Me.pcTextBox = New DevExpress.XtraEditors.PanelControl
        Me.txtKeyWord = New DevExpress.XtraEditors.TextEdit
        Me.pcButton = New DevExpress.XtraEditors.PanelControl
        Me.dx = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcMain.SuspendLayout()
        CType(Me.pcTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcTextBox.SuspendLayout()
        CType(Me.txtKeyWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcButton.SuspendLayout()
        CType(Me.dx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowPopup
        '
        Me.btnShowPopup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShowPopup.Location = New System.Drawing.Point(0, 0)
        Me.btnShowPopup.Name = "btnShowPopup"
        Me.btnShowPopup.Size = New System.Drawing.Size(40, 20)
        Me.btnShowPopup.TabIndex = 1
        Me.btnShowPopup.TabStop = False
        Me.btnShowPopup.Text = "..."
        '
        'pcMain
        '
        Me.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcMain.Controls.Add(Me.pcTextBox)
        Me.pcMain.Controls.Add(Me.pcButton)
        Me.pcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcMain.Location = New System.Drawing.Point(0, 0)
        Me.pcMain.Name = "pcMain"
        Me.pcMain.Size = New System.Drawing.Size(200, 20)
        Me.pcMain.TabIndex = 2
        '
        'pcTextBox
        '
        Me.pcTextBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcTextBox.Controls.Add(Me.txtKeyWord)
        Me.pcTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcTextBox.Location = New System.Drawing.Point(0, 0)
        Me.pcTextBox.Name = "pcTextBox"
        Me.pcTextBox.Size = New System.Drawing.Size(160, 20)
        Me.pcTextBox.TabIndex = 0
        '
        'txtKeyWord
        '
        Me.txtKeyWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKeyWord.Location = New System.Drawing.Point(0, 0)
        Me.txtKeyWord.Name = "txtKeyWord"
        Me.txtKeyWord.Size = New System.Drawing.Size(160, 20)
        Me.txtKeyWord.TabIndex = 0
        '
        'pcButton
        '
        Me.pcButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcButton.Controls.Add(Me.btnShowPopup)
        Me.pcButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcButton.Location = New System.Drawing.Point(160, 0)
        Me.pcButton.Name = "pcButton"
        Me.pcButton.Size = New System.Drawing.Size(40, 20)
        Me.pcButton.TabIndex = 1
        '
        'dx
        '
        Me.dx.ContainerControl = Me
        '
        'CustomFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pcMain)
        Me.Name = "CustomFilter"
        Me.Size = New System.Drawing.Size(200, 20)
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcMain.ResumeLayout(False)
        CType(Me.pcTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcTextBox.ResumeLayout(False)
        CType(Me.txtKeyWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcButton.ResumeLayout(False)
        CType(Me.dx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowPopup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pcMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcTextBox As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtKeyWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dx As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

End Class
