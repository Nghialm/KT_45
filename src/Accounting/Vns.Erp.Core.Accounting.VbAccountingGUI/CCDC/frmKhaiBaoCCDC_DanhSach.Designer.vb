<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhaiBaoCCDC_DanhSach
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcCCDC = New DevExpress.XtraGrid.GridControl()
        Me.grvCCDC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MaCcdc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenCcdc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NuocSx = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NamSx = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayMua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayBdsd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.SoKyPhanbo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenLoaiPhanbo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NguyenGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaTriCl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MdTkCcdc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MdTkPhanbo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MdTkChiphi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.MultiExportButton1 = New Vns.Erp.Core.MultiExportButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcCCDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCCDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcCCDC)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 568)
        Me.GroupControl1.TabIndex = 28
        Me.GroupControl1.Text = "Thông tin công cụ dụng cụ"
        '
        'grcCCDC
        '
        Me.grcCCDC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCCDC.Location = New System.Drawing.Point(2, 22)
        Me.grcCCDC.MainView = Me.grvCCDC
        Me.grcCCDC.Name = "grcCCDC"
        Me.grcCCDC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemDateEdit1})
        Me.grcCCDC.Size = New System.Drawing.Size(996, 544)
        Me.grcCCDC.TabIndex = 0
        Me.grcCCDC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCCDC})
        '
        'grvCCDC
        '
        Me.grvCCDC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaCcdc, Me.TenCcdc, Me.SoLuong, Me.NuocSx, Me.NamSx, Me.NgayMua, Me.NgayBdsd, Me.SoKyPhanbo, Me.TenLoaiPhanbo, Me.NguyenGia, Me.GiaTriCl, Me.MdTkCcdc, Me.MdTkPhanbo, Me.MdTkChiphi, Me.GridColumn1})
        Me.grvCCDC.GridControl = Me.grcCCDC
        Me.grvCCDC.Name = "grvCCDC"
        Me.grvCCDC.OptionsView.ColumnAutoWidth = False
        Me.grvCCDC.OptionsView.ShowAutoFilterRow = True
        Me.grvCCDC.OptionsView.ShowGroupPanel = False
        '
        'MaCcdc
        '
        Me.MaCcdc.Caption = "Mã công cụ"
        Me.MaCcdc.FieldName = "MaCcdc"
        Me.MaCcdc.Name = "MaCcdc"
        Me.MaCcdc.OptionsColumn.ReadOnly = True
        Me.MaCcdc.Visible = True
        Me.MaCcdc.VisibleIndex = 0
        Me.MaCcdc.Width = 100
        '
        'TenCcdc
        '
        Me.TenCcdc.Caption = "Tên công cụ"
        Me.TenCcdc.FieldName = "TenCcdc"
        Me.TenCcdc.Name = "TenCcdc"
        Me.TenCcdc.OptionsColumn.ReadOnly = True
        Me.TenCcdc.Visible = True
        Me.TenCcdc.VisibleIndex = 1
        Me.TenCcdc.Width = 214
        '
        'SoLuong
        '
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.OptionsColumn.ReadOnly = True
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 2
        Me.SoLuong.Width = 148
        '
        'NuocSx
        '
        Me.NuocSx.Caption = "Nước sản xuất"
        Me.NuocSx.FieldName = "NuocSx"
        Me.NuocSx.Name = "NuocSx"
        Me.NuocSx.OptionsColumn.ReadOnly = True
        Me.NuocSx.Width = 102
        '
        'NamSx
        '
        Me.NamSx.Caption = "Năm sản xuất"
        Me.NamSx.FieldName = "NamSx"
        Me.NamSx.Name = "NamSx"
        Me.NamSx.OptionsColumn.ReadOnly = True
        Me.NamSx.Width = 118
        '
        'NgayMua
        '
        Me.NgayMua.Caption = "Ngày mua"
        Me.NgayMua.FieldName = "NgayMua"
        Me.NgayMua.Name = "NgayMua"
        Me.NgayMua.OptionsColumn.ReadOnly = True
        Me.NgayMua.Width = 111
        '
        'NgayBdsd
        '
        Me.NgayBdsd.Caption = "Ngày BĐSD"
        Me.NgayBdsd.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.NgayBdsd.FieldName = "NgayBdsd"
        Me.NgayBdsd.Name = "NgayBdsd"
        Me.NgayBdsd.OptionsColumn.AllowEdit = False
        Me.NgayBdsd.OptionsColumn.ReadOnly = True
        Me.NgayBdsd.Visible = True
        Me.NgayBdsd.VisibleIndex = 4
        Me.NgayBdsd.Width = 135
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'SoKyPhanbo
        '
        Me.SoKyPhanbo.Caption = "Số kỳ phân bổ"
        Me.SoKyPhanbo.FieldName = "SoKyPhanbo"
        Me.SoKyPhanbo.Name = "SoKyPhanbo"
        Me.SoKyPhanbo.OptionsColumn.AllowEdit = False
        Me.SoKyPhanbo.OptionsColumn.ReadOnly = True
        Me.SoKyPhanbo.Visible = True
        Me.SoKyPhanbo.VisibleIndex = 3
        Me.SoKyPhanbo.Width = 93
        '
        'TenLoaiPhanbo
        '
        Me.TenLoaiPhanbo.Caption = "Kiểu phân bổ"
        Me.TenLoaiPhanbo.FieldName = "TenLoaiPhanbo"
        Me.TenLoaiPhanbo.Name = "TenLoaiPhanbo"
        Me.TenLoaiPhanbo.OptionsColumn.AllowEdit = False
        Me.TenLoaiPhanbo.OptionsColumn.ReadOnly = True
        Me.TenLoaiPhanbo.Visible = True
        Me.TenLoaiPhanbo.VisibleIndex = 5
        Me.TenLoaiPhanbo.Width = 142
        '
        'NguyenGia
        '
        Me.NguyenGia.Caption = "Nguyên giá"
        Me.NguyenGia.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.NguyenGia.FieldName = "NguyenGia"
        Me.NguyenGia.Name = "NguyenGia"
        Me.NguyenGia.OptionsColumn.ReadOnly = True
        Me.NguyenGia.Visible = True
        Me.NguyenGia.VisibleIndex = 7
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GiaTriCl
        '
        Me.GiaTriCl.Caption = "Số tiền còn lại"
        Me.GiaTriCl.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GiaTriCl.FieldName = "GiaTriCl"
        Me.GiaTriCl.Name = "GiaTriCl"
        Me.GiaTriCl.OptionsColumn.ReadOnly = True
        Me.GiaTriCl.Visible = True
        Me.GiaTriCl.VisibleIndex = 6
        Me.GiaTriCl.Width = 172
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'MdTkCcdc
        '
        Me.MdTkCcdc.Caption = "TK công cụ"
        Me.MdTkCcdc.FieldName = "MdTkCcdc"
        Me.MdTkCcdc.Name = "MdTkCcdc"
        Me.MdTkCcdc.OptionsColumn.ReadOnly = True
        Me.MdTkCcdc.Visible = True
        Me.MdTkCcdc.VisibleIndex = 8
        Me.MdTkCcdc.Width = 99
        '
        'MdTkPhanbo
        '
        Me.MdTkPhanbo.Caption = "TK phân bổ"
        Me.MdTkPhanbo.FieldName = "MdTkPhanbo"
        Me.MdTkPhanbo.Name = "MdTkPhanbo"
        Me.MdTkPhanbo.OptionsColumn.ReadOnly = True
        Me.MdTkPhanbo.Visible = True
        Me.MdTkPhanbo.VisibleIndex = 9
        Me.MdTkPhanbo.Width = 91
        '
        'MdTkChiphi
        '
        Me.MdTkChiphi.Caption = "TK chi phí"
        Me.MdTkChiphi.FieldName = "MdTkChiphi"
        Me.MdTkChiphi.Name = "MdTkChiphi"
        Me.MdTkChiphi.OptionsColumn.ReadOnly = True
        Me.MdTkChiphi.Visible = True
        Me.MdTkChiphi.VisibleIndex = 10
        Me.MdTkChiphi.Width = 111
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ghi chú"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 11
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Controls.Add(Me.MultiExportButton1)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Controls.Add(Me.btnAdd)
        Me._ActionPanel.Controls.Add(Me.btnPrint)
        Me._ActionPanel.Controls.Add(Me.btnXem)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 572)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(1000, 36)
        Me._ActionPanel.TabIndex = 29
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.Location = New System.Drawing.Point(172, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Xóa"
        '
        'MultiExportButton1
        '
        Me.MultiExportButton1.GRID_VIEW = Me.grvCCDC
        Me.MultiExportButton1.Location = New System.Drawing.Point(528, 4)
        Me.MultiExportButton1.Name = "MultiExportButton1"
        Me.MultiExportButton1.Size = New System.Drawing.Size(135, 30)
        Me.MultiExportButton1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(919, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Ðó&ng"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 3
        Me.btnModify.Location = New System.Drawing.Point(86, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(2, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ImageIndex = 5
        Me.btnPrint.Location = New System.Drawing.Point(258, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "&In"
        '
        'btnXem
        '
        Me.btnXem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXem.ImageIndex = 5
        Me.btnXem.Location = New System.Drawing.Point(344, 4)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(80, 30)
        Me.btnXem.TabIndex = 2
        Me.btnXem.Text = "X&em"
        Me.btnXem.Visible = False
        '
        'frmKhaiBaoCCDC_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me._ActionPanel)
        Me.Name = "frmKhaiBaoCCDC_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Khai báo CCDC"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcCCDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCCDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcCCDC As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCCDC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MaCcdc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenCcdc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NuocSx As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamSx As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayMua As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayBdsd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoKyPhanbo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenLoaiPhanbo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GiaTriCl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MdTkCcdc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MdTkPhanbo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MdTkChiphi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MultiExportButton1 As Vns.Erp.Core.MultiExportButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents NguyenGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
