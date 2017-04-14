<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_Ma_Loai_Tai_San
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
        Me.lblTenLoaiTanSan = New DevExpress.XtraEditors.LabelControl
        Me.cboLoaiTaiSan = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cboLoaiTaiSan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Chọn loại tài sản :"
        '
        'lblTenLoaiTanSan
        '
        Me.lblTenLoaiTanSan.Location = New System.Drawing.Point(318, 5)
        Me.lblTenLoaiTanSan.Name = "lblTenLoaiTanSan"
        Me.lblTenLoaiTanSan.Size = New System.Drawing.Size(0, 13)
        Me.lblTenLoaiTanSan.TabIndex = 4
        '
        'cboLoaiTaiSan
        '
        Me.cboLoaiTaiSan.EnterMoveNextControl = True
        Me.cboLoaiTaiSan.Location = New System.Drawing.Point(122, 3)
        Me.cboLoaiTaiSan.Name = "cboLoaiTaiSan"
        Me.cboLoaiTaiSan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboLoaiTaiSan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLoaiTaiSan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoaiTaiSan.Properties.ImmediatePopup = True
        Me.cboLoaiTaiSan.Properties.NullText = ""
        Me.cboLoaiTaiSan.Properties.View = Me.GridLookUpEdit1View
        Me.cboLoaiTaiSan.Size = New System.Drawing.Size(184, 20)
        Me.cboLoaiTaiSan.TabIndex = 6
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
        Me.GridColumn1.Caption = "Mã loại tài sản"
        Me.GridColumn1.FieldName = "MaLoaitaisan"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên loại tài sản"
        Me.GridColumn2.FieldName = "TenLoaitaisan"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'LookUp_Ma_Loai_Tai_San
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboLoaiTaiSan)
        Me.Controls.Add(Me.lblTenLoaiTanSan)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "LookUp_Ma_Loai_Tai_San"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboLoaiTaiSan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenLoaiTanSan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLoaiTaiSan As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
