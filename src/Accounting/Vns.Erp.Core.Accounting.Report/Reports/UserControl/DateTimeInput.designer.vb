<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTimeInput
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
        Me.cmbSelectMode = New DevExpress.XtraEditors.ComboBoxEdit
        Me.deDayStart = New DevExpress.XtraEditors.DateEdit
        Me.deDayEnd = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmbMonth = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbTerm = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbYear = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbYearMonth = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmbYearTerm = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.cmbSelectMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDayStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDayStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDayEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDayEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbYearMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbYearTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSelectMode
        '
        Me.cmbSelectMode.EditValue = "Kiểu"
        Me.cmbSelectMode.EnterMoveNextControl = True
        Me.cmbSelectMode.Location = New System.Drawing.Point(122, 3)
        Me.cmbSelectMode.Name = "cmbSelectMode"
        Me.cmbSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSelectMode.Properties.Items.AddRange(New Object() {"Ngày", "Tháng", "Quý", "Năm"})
        Me.cmbSelectMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbSelectMode.Size = New System.Drawing.Size(64, 20)
        Me.cmbSelectMode.TabIndex = 1
        '
        'deDayStart
        '
        Me.deDayStart.EditValue = Nothing
        Me.deDayStart.EnterMoveNextControl = True
        Me.deDayStart.Location = New System.Drawing.Point(204, 3)
        Me.deDayStart.Name = "deDayStart"
        Me.deDayStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deDayStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDayStart.Properties.DisplayFormat.FormatString = "g"
        Me.deDayStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDayStart.Properties.EditFormat.FormatString = "g"
        Me.deDayStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDayStart.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deDayStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDayStart.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deDayStart.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.deDayStart.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.deDayStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDayStart.Size = New System.Drawing.Size(100, 20)
        Me.deDayStart.TabIndex = 2
        '
        'deDayEnd
        '
        Me.deDayEnd.EditValue = Nothing
        Me.deDayEnd.EnterMoveNextControl = True
        Me.deDayEnd.Location = New System.Drawing.Point(322, 3)
        Me.deDayEnd.Name = "deDayEnd"
        Me.deDayEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deDayEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDayEnd.Properties.DisplayFormat.FormatString = "g"
        Me.deDayEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDayEnd.Properties.EditFormat.FormatString = "g"
        Me.deDayEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDayEnd.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deDayEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDayEnd.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deDayEnd.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.deDayEnd.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.deDayEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDayEnd.Size = New System.Drawing.Size(100, 20)
        Me.deDayEnd.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Chọn :"
        '
        'cmbMonth
        '
        Me.cmbMonth.EditValue = "1"
        Me.cmbMonth.EnterMoveNextControl = True
        Me.cmbMonth.Location = New System.Drawing.Point(122, 40)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMonth.Properties.DropDownRows = 12
        Me.cmbMonth.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbMonth.Size = New System.Drawing.Size(100, 20)
        Me.cmbMonth.TabIndex = 4
        Me.cmbMonth.Visible = False
        '
        'cmbTerm
        '
        Me.cmbTerm.EditValue = "1"
        Me.cmbTerm.EnterMoveNextControl = True
        Me.cmbTerm.Location = New System.Drawing.Point(122, 78)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTerm.Properties.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbTerm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbTerm.Size = New System.Drawing.Size(100, 20)
        Me.cmbTerm.TabIndex = 6
        Me.cmbTerm.Visible = False
        '
        'cmbYear
        '
        Me.cmbYear.EnterMoveNextControl = True
        Me.cmbYear.Location = New System.Drawing.Point(228, 114)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbYear.Size = New System.Drawing.Size(100, 20)
        Me.cmbYear.TabIndex = 8
        Me.cmbYear.Visible = False
        '
        'cmbYearMonth
        '
        Me.cmbYearMonth.EnterMoveNextControl = True
        Me.cmbYearMonth.Location = New System.Drawing.Point(228, 40)
        Me.cmbYearMonth.Name = "cmbYearMonth"
        Me.cmbYearMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbYearMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbYearMonth.Size = New System.Drawing.Size(100, 20)
        Me.cmbYearMonth.TabIndex = 5
        Me.cmbYearMonth.Visible = False
        '
        'cmbYearTerm
        '
        Me.cmbYearTerm.EnterMoveNextControl = True
        Me.cmbYearTerm.Location = New System.Drawing.Point(228, 78)
        Me.cmbYearTerm.Name = "cmbYearTerm"
        Me.cmbYearTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbYearTerm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbYearTerm.Size = New System.Drawing.Size(100, 20)
        Me.cmbYearTerm.TabIndex = 7
        Me.cmbYearTerm.Visible = False
        '
        'DateTimeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbYearTerm)
        Me.Controls.Add(Me.cmbYearMonth)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbTerm)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.deDayEnd)
        Me.Controls.Add(Me.deDayStart)
        Me.Controls.Add(Me.cmbSelectMode)
        Me.Name = "DateTimeInput"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cmbSelectMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDayStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDayStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDayEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDayEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbYearMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbYearTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSelectMode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents deDayStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDayEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbTerm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbYearMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbYearTerm As DevExpress.XtraEditors.ComboBoxEdit

End Class
