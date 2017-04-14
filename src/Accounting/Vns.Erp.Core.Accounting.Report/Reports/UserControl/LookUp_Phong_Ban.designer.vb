<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_Phong_Ban
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
        Me.lblPhongBan = New DevExpress.XtraEditors.LabelControl
        Me.lblTenPhongBan = New DevExpress.XtraEditors.LabelControl
        Me.cboPhongBan = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cboPhongBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPhongBan
        '
        Me.lblPhongBan.Location = New System.Drawing.Point(3, 5)
        Me.lblPhongBan.Name = "lblPhongBan"
        Me.lblPhongBan.Size = New System.Drawing.Size(102, 13)
        Me.lblPhongBan.TabIndex = 0
        Me.lblPhongBan.Text = "Chọn tên phòng ban:"
        '
        'lblTenPhongBan
        '
        Me.lblTenPhongBan.Location = New System.Drawing.Point(318, 5)
        Me.lblTenPhongBan.Name = "lblTenPhongBan"
        Me.lblTenPhongBan.Size = New System.Drawing.Size(0, 13)
        Me.lblTenPhongBan.TabIndex = 0
        '
        'cboPhongBan
        '
        Me.cboPhongBan.EnterMoveNextControl = True
        Me.cboPhongBan.Location = New System.Drawing.Point(123, 3)
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPhongBan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongBan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongBan.Properties.ImmediatePopup = True
        Me.cboPhongBan.Properties.NullText = ""
        Me.cboPhongBan.Properties.View = Me.GridLookUpEdit1View
        Me.cboPhongBan.Size = New System.Drawing.Size(184, 20)
        Me.cboPhongBan.TabIndex = 5
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
        Me.GridColumn1.Caption = "Mã phòng ban"
        Me.GridColumn1.FieldName = "MaPhongban"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên phòng ban"
        Me.GridColumn2.FieldName = "TenPhongban"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'LookUp_Phong_Ban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboPhongBan)
        Me.Controls.Add(Me.lblTenPhongBan)
        Me.Controls.Add(Me.lblPhongBan)
        Me.Name = "LookUp_Phong_Ban"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboPhongBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPhongBan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenPhongBan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPhongBan As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
