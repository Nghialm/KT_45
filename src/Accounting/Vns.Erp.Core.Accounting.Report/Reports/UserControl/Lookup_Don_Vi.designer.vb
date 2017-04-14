<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookup_Don_Vi
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lbltendonvi = New DevExpress.XtraEditors.LabelControl
        Me.cboDonVi = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cboDonVi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Chọn tên đơn vị :"
        '
        'lbltendonvi
        '
        Me.lbltendonvi.Location = New System.Drawing.Point(316, 5)
        Me.lbltendonvi.Name = "lbltendonvi"
        Me.lbltendonvi.Size = New System.Drawing.Size(0, 13)
        Me.lbltendonvi.TabIndex = 2
        '
        'cboDonVi
        '
        Me.cboDonVi.EnterMoveNextControl = True
        Me.cboDonVi.Location = New System.Drawing.Point(123, 3)
        Me.cboDonVi.Name = "cboDonVi"
        Me.cboDonVi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDonVi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDonVi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDonVi.Properties.ImmediatePopup = True
        Me.cboDonVi.Properties.NullText = ""
        Me.cboDonVi.Properties.PopupFormSize = New System.Drawing.Size(420, 0)
        Me.cboDonVi.Properties.View = Me.GridLookUpEdit1View
        Me.cboDonVi.Size = New System.Drawing.Size(184, 20)
        Me.cboDonVi.TabIndex = 3
        Me.cboDonVi.ToolTip = "Ấn F4 để thêm nhanh đơn vị"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã đơn vị"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên đơn vị"
        Me.GridColumn2.FieldName = "TenDonvi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 300
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "Id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'Lookup_Don_Vi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboDonVi)
        Me.Controls.Add(Me.lbltendonvi)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Lookup_Don_Vi"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboDonVi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbltendonvi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDonVi As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

End Class
