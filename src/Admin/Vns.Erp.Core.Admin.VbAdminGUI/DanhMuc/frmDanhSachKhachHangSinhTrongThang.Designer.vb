<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachKhachHangSinhTrongThang
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
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        Me.dteDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.dteTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TenLoaikhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenKhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgaySinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MaSoThue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MatkLienquan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTaikhoan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btExport = New Vns.Erp.Core.MultiExportButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me.dteDenNgay)
        Me._GroupControlSearch.Controls.Add(Me.dteTuNgay)
        Me._GroupControlSearch.Controls.Add(Me.btnSearch)
        Me._GroupControlSearch.Controls.Add(Me.LabelControl2)
        Me._GroupControlSearch.Controls.Add(Me.labelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(1000, 68)
        Me._GroupControlSearch.TabIndex = 0
        Me._GroupControlSearch.Text = "Tìm kiếm"
        '
        'dteDenNgay
        '
        Me.dteDenNgay.EditValue = Nothing
        Me.dteDenNgay.EnterMoveNextControl = True
        Me.dteDenNgay.Location = New System.Drawing.Point(241, 32)
        Me.dteDenNgay.Name = "dteDenNgay"
        Me.dteDenNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteDenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteDenNgay.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteDenNgay.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.MinValue = New Date(1989, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteDenNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteDenNgay.TabIndex = 1
        '
        'dteTuNgay
        '
        Me.dteTuNgay.EditValue = Nothing
        Me.dteTuNgay.EnterMoveNextControl = True
        Me.dteTuNgay.Location = New System.Drawing.Point(59, 32)
        Me.dteTuNgay.Name = "dteTuNgay"
        Me.dteTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteTuNgay.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteTuNgay.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.MinValue = New Date(1989, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteTuNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteTuNgay.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(383, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Tìm kiếm"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(188, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Đến ngày"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(13, 36)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(40, 13)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Từ ngày"
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(4, 72)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me._GridControl.Size = New System.Drawing.Size(1000, 502)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TenLoaikhang, Me.TenKhang, Me.KyHieu, Me.NgaySinh, Me.MaSoThue, Me.MatkLienquan, Me.DiaChi, Me.Tel, Me.Fax, Me.SoTaikhoan})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsView.ShowAutoFilterRow = True
        Me._GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'TenLoaikhang
        '
        Me.TenLoaikhang.Caption = "Tên loại khách hàng"
        Me.TenLoaikhang.FieldName = "TenLoaikhang"
        Me.TenLoaikhang.Name = "TenLoaikhang"
        Me.TenLoaikhang.Visible = True
        Me.TenLoaikhang.VisibleIndex = 0
        Me.TenLoaikhang.Width = 110
        '
        'TenKhang
        '
        Me.TenKhang.Caption = "Tên khách hàng"
        Me.TenKhang.FieldName = "TenKhang"
        Me.TenKhang.Name = "TenKhang"
        Me.TenKhang.Visible = True
        Me.TenKhang.VisibleIndex = 1
        Me.TenKhang.Width = 96
        '
        'KyHieu
        '
        Me.KyHieu.Caption = "Ký hiệu"
        Me.KyHieu.FieldName = "KyHieu"
        Me.KyHieu.Name = "KyHieu"
        Me.KyHieu.Visible = True
        Me.KyHieu.VisibleIndex = 2
        Me.KyHieu.Width = 96
        '
        'NgaySinh
        '
        Me.NgaySinh.Caption = "Ngày sinh"
        Me.NgaySinh.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.NgaySinh.FieldName = "NgaySinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.Visible = True
        Me.NgaySinh.VisibleIndex = 3
        Me.NgaySinh.Width = 96
        '
        'MaSoThue
        '
        Me.MaSoThue.Caption = "Mã số thuế"
        Me.MaSoThue.FieldName = "MaSoThue"
        Me.MaSoThue.Name = "MaSoThue"
        Me.MaSoThue.Visible = True
        Me.MaSoThue.VisibleIndex = 6
        Me.MaSoThue.Width = 96
        '
        'MatkLienquan
        '
        Me.MatkLienquan.Caption = "Mã TK liên quan"
        Me.MatkLienquan.FieldName = "MatkLienquan"
        Me.MatkLienquan.Name = "MatkLienquan"
        Me.MatkLienquan.Visible = True
        Me.MatkLienquan.VisibleIndex = 7
        Me.MatkLienquan.Width = 96
        '
        'DiaChi
        '
        Me.DiaChi.Caption = "Địa chỉ"
        Me.DiaChi.FieldName = "DiaChi"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.Visible = True
        Me.DiaChi.VisibleIndex = 4
        Me.DiaChi.Width = 190
        '
        'Tel
        '
        Me.Tel.Caption = "SĐT"
        Me.Tel.FieldName = "Tel"
        Me.Tel.Name = "Tel"
        Me.Tel.Visible = True
        Me.Tel.VisibleIndex = 5
        Me.Tel.Width = 63
        '
        'Fax
        '
        Me.Fax.Caption = "Fax"
        Me.Fax.FieldName = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 8
        Me.Fax.Width = 63
        '
        'SoTaikhoan
        '
        Me.SoTaikhoan.Caption = "Số tài khoản"
        Me.SoTaikhoan.FieldName = "SoTaikhoan"
        Me.SoTaikhoan.Name = "SoTaikhoan"
        Me.SoTaikhoan.Visible = True
        Me.SoTaikhoan.VisibleIndex = 9
        Me.SoTaikhoan.Width = 74
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btExport)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 574)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(1000, 34)
        Me._ActionPanel.TabIndex = 2
        '
        'btExport
        '
        Me.btExport.GRID_VIEW = Nothing
        Me.btExport.Location = New System.Drawing.Point(0, 3)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(135, 30)
        Me.btExport.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(919, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Ðó&ng"
        '
        'frmDanhSachKhachHangSinhTrongThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me._GridControl)
        Me.Controls.Add(Me._GroupControlSearch)
        Me.Controls.Add(Me._ActionPanel)
        Me.Name = "frmDanhSachKhachHangSinhTrongThang"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Sinh nhật khách hàng"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TenLoaikhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenKhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgaySinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MaSoThue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MatkLienquan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiaChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTaikhoan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btExport As Vns.Erp.Core.MultiExportButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dteDenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteTuNgay As DevExpress.XtraEditors.DateEdit
    Private WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
