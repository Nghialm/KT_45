<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUp_LoaiKHang
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
        Me.lblNhomKhachHang = New DevExpress.XtraEditors.LabelControl
        Me.lblTenNhomKH = New DevExpress.XtraEditors.LabelControl
        Me.cboLoaiKhachHang = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cboLoaiKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNhomKhachHang
        '
        Me.lblNhomKhachHang.Location = New System.Drawing.Point(3, 5)
        Me.lblNhomKhachHang.Name = "lblNhomKhachHang"
        Me.lblNhomKhachHang.Size = New System.Drawing.Size(85, 13)
        Me.lblNhomKhachHang.TabIndex = 0
        Me.lblNhomKhachHang.Text = "Nhóm khách hàng"
        '
        'lblTenNhomKH
        '
        Me.lblTenNhomKH.Location = New System.Drawing.Point(318, 5)
        Me.lblTenNhomKH.Name = "lblTenNhomKH"
        Me.lblTenNhomKH.Size = New System.Drawing.Size(0, 13)
        Me.lblTenNhomKH.TabIndex = 0
        '
        'cboLoaiKhachHang
        '
        Me.cboLoaiKhachHang.EnterMoveNextControl = True
        Me.cboLoaiKhachHang.Location = New System.Drawing.Point(122, 3)
        Me.cboLoaiKhachHang.Name = "cboLoaiKhachHang"
        Me.cboLoaiKhachHang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboLoaiKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLoaiKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoaiKhachHang.Properties.ImmediatePopup = True
        Me.cboLoaiKhachHang.Properties.NullText = ""
        Me.cboLoaiKhachHang.Properties.View = Me.GridLookUpEdit1View
        Me.cboLoaiKhachHang.Size = New System.Drawing.Size(184, 20)
        Me.cboLoaiKhachHang.TabIndex = 5
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
        Me.GridColumn1.Caption = "Mã nhóm khách hàng"
        Me.GridColumn1.FieldName = "Id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên nhóm khách hàng"
        Me.GridColumn2.FieldName = "TenDanhmuc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'LookUp_LoaiKHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboLoaiKhachHang)
        Me.Controls.Add(Me.lblTenNhomKH)
        Me.Controls.Add(Me.lblNhomKhachHang)
        Me.Name = "LookUp_LoaiKHang"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboLoaiKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNhomKhachHang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenNhomKH As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLoaiKhachHang As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
