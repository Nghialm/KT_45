<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_Group_Name_Kho
    Inherits KTY_UserControl

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
        Me.cboGroup = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GROUP_VALUE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GROUP_NAME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cboGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboGroup
        '
        Me.cboGroup.EnterMoveNextControl = True
        Me.cboGroup.Location = New System.Drawing.Point(122, 3)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGroup.Properties.ImmediatePopup = True
        Me.cboGroup.Properties.NullText = ""
        Me.cboGroup.Properties.View = Me.GridLookUpEdit1View
        Me.cboGroup.Size = New System.Drawing.Size(184, 20)
        Me.cboGroup.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GROUP_VALUE, Me.GROUP_NAME})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GROUP_VALUE
        '
        Me.GROUP_VALUE.Caption = "Giá trị"
        Me.GROUP_VALUE.FieldName = "GROUP_VALUE"
        Me.GROUP_VALUE.Name = "GROUP_VALUE"
        Me.GROUP_VALUE.Visible = True
        Me.GROUP_VALUE.VisibleIndex = 1
        '
        'GROUP_NAME
        '
        Me.GROUP_NAME.Caption = "Tên nhóm"
        Me.GROUP_NAME.FieldName = "GROUP_NAME"
        Me.GROUP_NAME.Name = "GROUP_NAME"
        Me.GROUP_NAME.Visible = True
        Me.GROUP_NAME.VisibleIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn nhóm:"
        '
        'LookUp_Group_Name_Kho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cboGroup)
        Me.Name = "LookUp_Group_Name_Kho"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboGroup As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GROUP_VALUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GROUP_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
