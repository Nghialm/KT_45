Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucKhachHang_DanhSach
    Inherits FrmBaseDmDanhSach
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me._GroupControlList = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TenLoaikhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenKhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgaySinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaSoThue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MatkLienquan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTaikhoan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CtlPagerControl = New Vns.Erp.Core.Common.Controls.PagerControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        Me._FieldChooser = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._SearchHelper = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btExport = New Vns.Erp.Core.MultiExportButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._GroupControlList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlList.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlList
        '
        Me._GroupControlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._GroupControlList.Controls.Add(Me._GridControl)
        Me._GroupControlList.Controls.Add(Me.PanelControl1)
        Me._GroupControlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlList.Location = New System.Drawing.Point(6, 67)
        Me._GroupControlList.Name = "_GroupControlList"
        Me._GroupControlList.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me._GroupControlList.Size = New System.Drawing.Size(996, 499)
        Me._GroupControlList.TabIndex = 2
        Me._GroupControlList.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(0, 4)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me._GridControl.Size = New System.Drawing.Size(996, 455)
        Me._GridControl.TabIndex = 3
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CtlPagerControl)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 459)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 36)
        Me.PanelControl1.TabIndex = 1
        '
        'CtlPagerControl
        '
        Me.CtlPagerControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.CtlPagerControl.Location = New System.Drawing.Point(508, 2)
        Me.CtlPagerControl.Name = "CtlPagerControl"
        Me.CtlPagerControl.PageIndex = 1
        Me.CtlPagerControl.PageSize = 50
        Me.CtlPagerControl.Size = New System.Drawing.Size(486, 32)
        Me.CtlPagerControl.TabIndex = 0
        Me.CtlPagerControl.TotalPage = 0
        Me.CtlPagerControl.TotalResult = 0
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me._FieldChooser)
        Me._GroupControlSearch.Controls.Add(Me._SearchHelper)
        Me._GroupControlSearch.Controls.Add(Me.labelControl2)
        Me._GroupControlSearch.Controls.Add(Me.labelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(6, 6)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(996, 61)
        Me._GroupControlSearch.TabIndex = 0
        Me._GroupControlSearch.Text = "Tìm kiếm"
        Me._GroupControlSearch.Visible = False
        '
        '_FieldChooser
        '
        Me._FieldChooser.EditValue = ""
        Me._FieldChooser.Location = New System.Drawing.Point(90, 29)
        Me._FieldChooser.Name = "_FieldChooser"
        Me._FieldChooser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FieldChooser.Properties.ImmediatePopup = True
        Me._FieldChooser.Properties.View = Me.gridView1
        Me._FieldChooser.Size = New System.Drawing.Size(141, 20)
        Me._FieldChooser.TabIndex = 1
        '
        'gridView1
        '
        Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        '_SearchHelper
        '
        Me._SearchHelper.EditValue = ""
        Me._SearchHelper.Location = New System.Drawing.Point(292, 29)
        Me._SearchHelper.Name = "_SearchHelper"
        Me._SearchHelper.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._SearchHelper.Properties.ImmediatePopup = True
        Me._SearchHelper.Properties.View = Me.gridLookUpEdit1View
        Me._SearchHelper.Size = New System.Drawing.Size(141, 20)
        Me._SearchHelper.TabIndex = 3
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(251, 33)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(28, 13)
        Me.labelControl2.TabIndex = 2
        Me.labelControl2.Text = "Giá trị"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(13, 33)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(65, 13)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Tìm kiếm theo"
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Controls.Add(Me.btExport)
        Me._ActionPanel.Controls.Add(Me.btnPri)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Controls.Add(Me.btnCreate)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(6, 566)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(996, 40)
        Me._ActionPanel.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.Location = New System.Drawing.Point(174, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Xóa"
        '
        'btExport
        '
        Me.btExport.GRID_VIEW = Nothing
        Me.btExport.Location = New System.Drawing.Point(260, 6)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(135, 30)
        Me.btExport.TabIndex = 10
        '
        'btnPri
        '
        Me.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPri.ImageIndex = 5
        Me.btnPri.Location = New System.Drawing.Point(553, 6)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 3
        Me.btnPri.Text = "&In"
        Me.btnPri.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(911, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Ðó&ng"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 3
        Me.btnModify.Location = New System.Drawing.Point(88, 6)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.ImageIndex = 2
        Me.btnCreate.Location = New System.Drawing.Point(2, 6)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 30)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Mới"
        '
        'frmDanhMucKhachHang_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me._GroupControlList)
        Me.Controls.Add(Me._ActionPanel)
        Me.Controls.Add(Me._GroupControlSearch)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucKhachHang_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục khách hàng"
        CType(Me._GroupControlList, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlList.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlList As DevExpress.XtraEditors.GroupControl
    Friend GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private _SearchHelper As DevExpress.XtraEditors.GridLookUpEdit
    Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private labelControl2 As DevExpress.XtraEditors.LabelControl
    Private _FieldChooser As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btExport As MultiExportButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CtlPagerControl As Vns.Erp.Core.Common.Controls.PagerControl
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
    'Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton

End Class
