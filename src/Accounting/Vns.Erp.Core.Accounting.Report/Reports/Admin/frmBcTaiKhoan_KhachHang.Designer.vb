<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBcTaiKhoan_KhachHang
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dteDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.dteTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboKhachHang = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(955, 498)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.GridLookUpEdit1)
        Me.Panel1.Controls.Add(Me.cboKhachHang)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.labelControl3)
        Me.Panel1.Controls.Add(Me.labelControl2)
        Me.Panel1.Controls.Add(Me.dteDenNgay)
        Me.Panel1.Controls.Add(Me.dteTuNgay)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 138)
        Me.Panel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nghiệp vụ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 348)
        Me.Panel2.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(949, 348)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(292, 12)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(47, 13)
        Me.labelControl3.TabIndex = 5
        Me.labelControl3.Text = "Đến ngày"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(12, 12)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(40, 13)
        Me.labelControl2.TabIndex = 6
        Me.labelControl2.Text = "Từ ngày"
        '
        'dteDenNgay
        '
        Me.dteDenNgay.EditValue = Nothing
        Me.dteDenNgay.EnterMoveNextControl = True
        Me.dteDenNgay.Location = New System.Drawing.Point(359, 9)
        Me.dteDenNgay.Name = "dteDenNgay"
        Me.dteDenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteDenNgay.Properties.MaxValue = New Date(2999, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteDenNgay.Size = New System.Drawing.Size(153, 20)
        Me.dteDenNgay.TabIndex = 4
        '
        'dteTuNgay
        '
        Me.dteTuNgay.EditValue = Nothing
        Me.dteTuNgay.EnterMoveNextControl = True
        Me.dteTuNgay.Location = New System.Drawing.Point(96, 9)
        Me.dteTuNgay.Name = "dteTuNgay"
        Me.dteTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteTuNgay.Properties.MaxValue = New Date(2999, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteTuNgay.Size = New System.Drawing.Size(153, 20)
        Me.dteTuNgay.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 76)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Khách hàng"
        '
        'cboKhachHang
        '
        Me.cboKhachHang.Location = New System.Drawing.Point(96, 73)
        Me.cboKhachHang.Name = "cboKhachHang"
        Me.cboKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhachHang.Properties.NullText = ""
        Me.cboKhachHang.Properties.View = Me.gridView4
        Me.cboKhachHang.Size = New System.Drawing.Size(270, 20)
        Me.cboKhachHang.TabIndex = 8
        '
        'gridView4
        '
        Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn7, Me.gridColumn8})
        Me.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView4.Name = "gridView4"
        Me.gridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView4.OptionsView.ShowAutoFilterRow = True
        Me.gridView4.OptionsView.ShowGroupPanel = False
        '
        'gridColumn7
        '
        Me.gridColumn7.Caption = "Mã khách hàng"
        Me.gridColumn7.FieldName = "KyHieu"
        Me.gridColumn7.Name = "gridColumn7"
        Me.gridColumn7.Visible = True
        Me.gridColumn7.VisibleIndex = 0
        '
        'gridColumn8
        '
        Me.gridColumn8.Caption = "Tên khách hàng"
        Me.gridColumn8.FieldName = "TenKhang"
        Me.gridColumn8.Name = "gridColumn8"
        Me.gridColumn8.Visible = True
        Me.gridColumn8.VisibleIndex = 1
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(96, 40)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.View = Me.GridView2
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(270, 20)
        Me.GridLookUpEdit1.TabIndex = 9
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã khách hàng"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên khách hàng"
        Me.GridColumn2.FieldName = "TenKhang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.ImageIndex = 20
        Me.btnSearch.Location = New System.Drawing.Point(96, 99)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "&Tìm kiếm"
        '
        'frmBcTaiKhoan_KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 498)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmBcTaiKhoan_KhachHang"
        Me.Text = "Báo cáo quản trị Tài khoản - Khách hàng"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents dteDenNgay As DevExpress.XtraEditors.DateEdit
    Private WithEvents dteTuNgay As DevExpress.XtraEditors.DateEdit
    Private WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents cboKhachHang As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
End Class
