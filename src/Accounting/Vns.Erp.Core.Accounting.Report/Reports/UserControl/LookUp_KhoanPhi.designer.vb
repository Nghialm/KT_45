<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_KhoanPhi
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
        Me.cboKhoanPhi = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblVuViec = New DevExpress.XtraEditors.LabelControl
        CType(Me.cboKhoanPhi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboKhoanPhi
        '
        Me.cboKhoanPhi.EnterMoveNextControl = True
        Me.cboKhoanPhi.Location = New System.Drawing.Point(123, 3)
        Me.cboKhoanPhi.Name = "cboKhoanPhi"
        Me.cboKhoanPhi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKhoanPhi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanPhi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanPhi.Properties.ImmediatePopup = True
        Me.cboKhoanPhi.Properties.NullText = ""
        Me.cboKhoanPhi.Properties.View = Me.GridLookUpEdit1View
        Me.cboKhoanPhi.Size = New System.Drawing.Size(184, 20)
        Me.cboKhoanPhi.TabIndex = 7
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
        Me.GridColumn1.Caption = "Mã khoản phí"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên khoản phí"
        Me.GridColumn2.FieldName = "TenDmKhoanphi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Chọn khoản phí"
        '
        'lblVuViec
        '
        Me.lblVuViec.Location = New System.Drawing.Point(313, 5)
        Me.lblVuViec.Name = "lblVuViec"
        Me.lblVuViec.Size = New System.Drawing.Size(0, 13)
        Me.lblVuViec.TabIndex = 8
        '
        'LookUp_KhoanPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblVuViec)
        Me.Controls.Add(Me.cboKhoanPhi)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "LookUp_KhoanPhi"
        Me.Size = New System.Drawing.Size(469, 27)
        CType(Me.cboKhoanPhi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboKhoanPhi As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVuViec As DevExpress.XtraEditors.LabelControl

End Class
