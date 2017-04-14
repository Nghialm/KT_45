<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.Timer_Event = New System.Windows.Forms.Timer(Me.components)
        Me.lbDescription = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.LoadingCircle = New FAMP.LoadingCircle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Event
        '
        Me.Timer_Event.Interval = 50
        '
        'lbDescription
        '
        Me.lbDescription.AutoSize = True
        Me.lbDescription.Location = New System.Drawing.Point(38, 10)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(59, 13)
        Me.lbDescription.TabIndex = 1
        Me.lbDescription.Text = "Loading ..."
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(211, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.Visible = False
        '
        'LoadingCircle
        '
        Me.LoadingCircle.Active = False
        Me.LoadingCircle.Color = System.Drawing.Color.Green
        Me.LoadingCircle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingCircle.InnerCircleRadius = 8
        Me.LoadingCircle.Location = New System.Drawing.Point(0, 0)
        Me.LoadingCircle.Name = "LoadingCircle"
        Me.LoadingCircle.NumberSpoke = 10
        Me.LoadingCircle.OuterCircleRadius = 10
        Me.LoadingCircle.RotationSpeed = 150
        Me.LoadingCircle.Size = New System.Drawing.Size(38, 35)
        Me.LoadingCircle.SpokeThickness = 4
        Me.LoadingCircle.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LoadingCircle)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.lbDescription)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 36)
        Me.Panel1.TabIndex = 0
        '
        'frmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 36)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProgress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progress"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer_Event As System.Windows.Forms.Timer
    Public WithEvents lbDescription As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents LoadingCircle As FAMP.LoadingCircle
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
