<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCultureSetting2
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cboGroupSeparator = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboCode = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboDateFormat = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboDecimalSeparator = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboTimeSeparator = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboTimeFormat = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboDateSeparator = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCode = New DevExpress.XtraEditors.LabelControl
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboGroupSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDecimalSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTimeSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTimeFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.cboGroupSeparator)
        Me.GroupBox1.Controls.Add(Me.cboCode)
        Me.GroupBox1.Controls.Add(Me.cboDateFormat)
        Me.GroupBox1.Controls.Add(Me.cboDecimalSeparator)
        Me.GroupBox1.Controls.Add(Me.cboTimeSeparator)
        Me.GroupBox1.Controls.Add(Me.cboTimeFormat)
        Me.GroupBox1.Controls.Add(Me.cboDateSeparator)
        Me.GroupBox1.Controls.Add(Me.lblCode)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thiết lập thông số"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(61, 57)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Ngôn ngữ hiển thị của Lịch"
        '
        'cboGroupSeparator
        '
        Me.cboGroupSeparator.EditValue = "."
        Me.cboGroupSeparator.EnterMoveNextControl = True
        Me.cboGroupSeparator.Location = New System.Drawing.Point(197, 209)
        Me.cboGroupSeparator.Name = "cboGroupSeparator"
        Me.cboGroupSeparator.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGroupSeparator.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroupSeparator.Properties.Appearance.Options.UseBackColor = True
        Me.cboGroupSeparator.Properties.Appearance.Options.UseFont = True
        Me.cboGroupSeparator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGroupSeparator.Properties.Items.AddRange(New Object() {".", ",", "space"})
        Me.cboGroupSeparator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGroupSeparator.Size = New System.Drawing.Size(116, 20)
        Me.cboGroupSeparator.TabIndex = 6
        '
        'cboCode
        '
        Me.cboCode.EditValue = "Việt Nam"
        Me.cboCode.EnterMoveNextControl = True
        Me.cboCode.Location = New System.Drawing.Point(197, 54)
        Me.cboCode.Name = "cboCode"
        Me.cboCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCode.Properties.Items.AddRange(New Object() {"Việt Nam", "Anh Mỹ", "Pháp"})
        Me.cboCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCode.Size = New System.Drawing.Size(116, 20)
        Me.cboCode.TabIndex = 1
        '
        'cboDateFormat
        '
        Me.cboDateFormat.EditValue = "dd/MM/yyyy"
        Me.cboDateFormat.EnterMoveNextControl = True
        Me.cboDateFormat.Location = New System.Drawing.Point(197, 85)
        Me.cboDateFormat.Name = "cboDateFormat"
        Me.cboDateFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateFormat.Properties.Items.AddRange(New Object() {"dd/MM/yyyy", "MM/dd/yyyy", "yyyy/MM/dd", "dd/MMM/yyyy", "MMM/dd/yyyy", "yyyy/MMM/dd", "dd-MM-yyyy", "MM-dd-yyyy", "yyyy-MM-dd", "dd-MMM-yyyy", "MMM-dd-yyyy", "yyyy-MMM-dd"})
        Me.cboDateFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDateFormat.Size = New System.Drawing.Size(116, 20)
        Me.cboDateFormat.TabIndex = 2
        '
        'cboDecimalSeparator
        '
        Me.cboDecimalSeparator.EditValue = ","
        Me.cboDecimalSeparator.EnterMoveNextControl = True
        Me.cboDecimalSeparator.Location = New System.Drawing.Point(197, 240)
        Me.cboDecimalSeparator.Name = "cboDecimalSeparator"
        Me.cboDecimalSeparator.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDecimalSeparator.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDecimalSeparator.Properties.Appearance.Options.UseBackColor = True
        Me.cboDecimalSeparator.Properties.Appearance.Options.UseFont = True
        Me.cboDecimalSeparator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDecimalSeparator.Properties.Items.AddRange(New Object() {",", "."})
        Me.cboDecimalSeparator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDecimalSeparator.Size = New System.Drawing.Size(116, 20)
        Me.cboDecimalSeparator.TabIndex = 7
        '
        'cboTimeSeparator
        '
        Me.cboTimeSeparator.EditValue = ":"
        Me.cboTimeSeparator.EnterMoveNextControl = True
        Me.cboTimeSeparator.Location = New System.Drawing.Point(197, 178)
        Me.cboTimeSeparator.Name = "cboTimeSeparator"
        Me.cboTimeSeparator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTimeSeparator.Properties.Items.AddRange(New Object() {":", "."})
        Me.cboTimeSeparator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTimeSeparator.Size = New System.Drawing.Size(116, 20)
        Me.cboTimeSeparator.TabIndex = 5
        '
        'cboTimeFormat
        '
        Me.cboTimeFormat.EditValue = "HH:mm:ss"
        Me.cboTimeFormat.EnterMoveNextControl = True
        Me.cboTimeFormat.Location = New System.Drawing.Point(197, 147)
        Me.cboTimeFormat.Name = "cboTimeFormat"
        Me.cboTimeFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTimeFormat.Properties.Items.AddRange(New Object() {"HH:mm:ss"})
        Me.cboTimeFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTimeFormat.Size = New System.Drawing.Size(116, 20)
        Me.cboTimeFormat.TabIndex = 4
        '
        'cboDateSeparator
        '
        Me.cboDateSeparator.EditValue = "/"
        Me.cboDateSeparator.EnterMoveNextControl = True
        Me.cboDateSeparator.Location = New System.Drawing.Point(197, 116)
        Me.cboDateSeparator.Name = "cboDateSeparator"
        Me.cboDateSeparator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateSeparator.Properties.Items.AddRange(New Object() {"/", "-"})
        Me.cboDateSeparator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDateSeparator.Size = New System.Drawing.Size(116, 20)
        Me.cboDateSeparator.TabIndex = 3
        '
        'lblCode
        '
        Me.lblCode.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCode.Appearance.Options.UseFont = True
        Me.lblCode.Appearance.Options.UseForeColor = True
        Me.lblCode.Location = New System.Drawing.Point(319, 57)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(41, 13)
        Me.lblCode.TabIndex = 16
        Me.lblCode.Text = "lblCode"
        '
        'txtName
        '
        Me.txtName.EnterMoveNextControl = True
        Me.txtName.Location = New System.Drawing.Point(197, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtName.Properties.Appearance.Options.UseBackColor = True
        Me.txtName.Size = New System.Drawing.Size(116, 20)
        Me.txtName.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(119, 26)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Tên định dạng"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(6, 243)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(181, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Ký tự phân cách phần thập phân"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(32, 212)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(155, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Ký tự phân cách phần nghìn"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(65, 181)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Ký tự phân cách thời gian"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(94, 150)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Định dạng thời gian"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(82, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Ký tự phân cách ngày"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(111, 88)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Định dạng ngày"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(150, 285)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Lưu"
        '
        'frmCultureSetting2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 322)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCultureSetting2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập định dạng hệ thống"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboGroupSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDecimalSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTimeSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTimeFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDateFormat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDecimalSeparator As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboTimeSeparator As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboTimeFormat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDateSeparator As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboGroupSeparator As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
