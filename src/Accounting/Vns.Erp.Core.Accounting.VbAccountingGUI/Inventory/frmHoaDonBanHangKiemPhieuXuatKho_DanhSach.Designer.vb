<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDonBanHangKiemPhieuXuatKho_DanhSach
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
        Me.btnClo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.grcLPN_Dnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPN_Dnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.KyHieuHanghoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenHanghoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DonGiaBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTienBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoXuatId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKHO_XUAT_ID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MaTkcThueGtgt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTienThueGtgt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CtSo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieuKhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenKhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MstKhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayGhi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DienGiai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NguoiGiaoNhanHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PagerControl1 = New Vns.Erp.Core.Common.Controls.PagerControl()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHO_XUAT_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClo
        '
        Me.btnClo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClo.ImageIndex = 1
        Me.btnClo.Location = New System.Drawing.Point(918, 3)
        Me.btnClo.Name = "btnClo"
        Me.btnClo.Size = New System.Drawing.Size(80, 30)
        Me.btnClo.TabIndex = 6
        Me.btnClo.Text = "&Thoát"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(1, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Mới"
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(87, 3)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(80, 30)
        Me.btnMod.TabIndex = 4
        Me.btnMod.Text = "&Sửa"
        '
        'grcLPN_Dnx
        '
        Me.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Dnx.Location = New System.Drawing.Point(2, 22)
        Me.grcLPN_Dnx.MainView = Me.grvLPN_Dnx
        Me.grcLPN_Dnx.Name = "grcLPN_Dnx"
        Me.grcLPN_Dnx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboKHO_XUAT_ID})
        Me.grcLPN_Dnx.Size = New System.Drawing.Size(996, 268)
        Me.grcLPN_Dnx.TabIndex = 1
        Me.grcLPN_Dnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPN_Dnx})
        '
        'grvLPN_Dnx
        '
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.Empty.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.OddRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Appearance.OddRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvLPN_Dnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.Preview.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.Preview.Options.UseFont = True
        Me.grvLPN_Dnx.Appearance.Preview.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.Row.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.Row.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPN_Dnx.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvLPN_Dnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvLPN_Dnx.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPN_Dnx.Appearance.VertLine.Options.UseBackColor = True
        Me.grvLPN_Dnx.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvLPN_Dnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KyHieuHanghoa, Me.TenHanghoa, Me.TenDvt, Me.SoLuong, Me.DonGiaBan, Me.SoTienBan, Me.KhoXuatId, Me.MaTkcThueGtgt, Me.SoTienThueGtgt})
        Me.grvLPN_Dnx.GridControl = Me.grcLPN_Dnx
        Me.grvLPN_Dnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPN_Dnx.Name = "grvLPN_Dnx"
        Me.grvLPN_Dnx.OptionsBehavior.Editable = False
        Me.grvLPN_Dnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPN_Dnx.OptionsView.ShowGroupPanel = False
        '
        'KyHieuHanghoa
        '
        Me.KyHieuHanghoa.Caption = "Mã hàng hóa"
        Me.KyHieuHanghoa.FieldName = "KyHieuHanghoa"
        Me.KyHieuHanghoa.Name = "KyHieuHanghoa"
        Me.KyHieuHanghoa.Visible = True
        Me.KyHieuHanghoa.VisibleIndex = 0
        Me.KyHieuHanghoa.Width = 97
        '
        'TenHanghoa
        '
        Me.TenHanghoa.Caption = "Tên hàng/ vật tư"
        Me.TenHanghoa.FieldName = "TenHanghoa"
        Me.TenHanghoa.Name = "TenHanghoa"
        Me.TenHanghoa.Visible = True
        Me.TenHanghoa.VisibleIndex = 1
        Me.TenHanghoa.Width = 150
        '
        'TenDvt
        '
        Me.TenDvt.Caption = "Đơn vị tính"
        Me.TenDvt.FieldName = "TenDvt"
        Me.TenDvt.Name = "TenDvt"
        Me.TenDvt.Visible = True
        Me.TenDvt.VisibleIndex = 2
        '
        'SoLuong
        '
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.DisplayFormat.FormatString = "n2"
        Me.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 3
        Me.SoLuong.Width = 100
        '
        'DonGiaBan
        '
        Me.DonGiaBan.Caption = "Giá bán"
        Me.DonGiaBan.DisplayFormat.FormatString = "n2"
        Me.DonGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaBan.FieldName = "DonGiaBan"
        Me.DonGiaBan.Name = "DonGiaBan"
        Me.DonGiaBan.Visible = True
        Me.DonGiaBan.VisibleIndex = 4
        Me.DonGiaBan.Width = 100
        '
        'SoTienBan
        '
        Me.SoTienBan.Caption = "Thành tiền"
        Me.SoTienBan.DisplayFormat.FormatString = "n0"
        Me.SoTienBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienBan.FieldName = "SoTienBan"
        Me.SoTienBan.Name = "SoTienBan"
        Me.SoTienBan.Visible = True
        Me.SoTienBan.VisibleIndex = 5
        Me.SoTienBan.Width = 120
        '
        'KhoXuatId
        '
        Me.KhoXuatId.Caption = "Mã kho"
        Me.KhoXuatId.ColumnEdit = Me.cboKHO_XUAT_ID
        Me.KhoXuatId.FieldName = "KhoXuatId"
        Me.KhoXuatId.Name = "KhoXuatId"
        Me.KhoXuatId.OptionsColumn.ReadOnly = True
        Me.KhoXuatId.Visible = True
        Me.KhoXuatId.VisibleIndex = 6
        '
        'cboKHO_XUAT_ID
        '
        Me.cboKHO_XUAT_ID.AutoHeight = False
        Me.cboKHO_XUAT_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHO_XUAT_ID.Name = "cboKHO_XUAT_ID"
        Me.cboKHO_XUAT_ID.NullText = ""
        '
        'MaTkcThueGtgt
        '
        Me.MaTkcThueGtgt.Caption = "Mã TK thuế GTGT"
        Me.MaTkcThueGtgt.FieldName = "MaTkcThueGtgt"
        Me.MaTkcThueGtgt.Name = "MaTkcThueGtgt"
        Me.MaTkcThueGtgt.Visible = True
        Me.MaTkcThueGtgt.VisibleIndex = 7
        Me.MaTkcThueGtgt.Width = 120
        '
        'SoTienThueGtgt
        '
        Me.SoTienThueGtgt.Caption = "Tiền thuế GTGT"
        Me.SoTienThueGtgt.DisplayFormat.FormatString = "n0"
        Me.SoTienThueGtgt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienThueGtgt.FieldName = "SoTienThueGtgt"
        Me.SoTienThueGtgt.GroupFormat.FormatString = "n0"
        Me.SoTienThueGtgt.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienThueGtgt.Name = "SoTienThueGtgt"
        Me.SoTienThueGtgt.Visible = True
        Me.SoTienThueGtgt.VisibleIndex = 8
        Me.SoTienThueGtgt.Width = 120
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnSea)
        Me.PanelControl2.Controls.Add(Me.btnClo)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl2.TabIndex = 26
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(173, 3)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(80, 30)
        Me.btnSea.TabIndex = 9
        Me.btnSea.Text = "Tìm kiếm"
        Me.btnSea.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(259, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "Xóa"
        Me.btnDel.Visible = False
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.grcLPN_Dnx)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupControl2.Location = New System.Drawing.Point(0, 0)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Size = New System.Drawing.Size(1000, 292)
        Me.groupControl2.TabIndex = 23
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 570)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.TabIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcLPN_Hnx)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 236)
        Me.GroupControl1.TabIndex = 24
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 22)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(996, 212)
        Me.grcLPN_Hnx.TabIndex = 1
        Me.grcLPN_Hnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPX_Hnx})
        '
        'grvLPX_Hnx
        '
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.Empty.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvLPX_Hnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseFont = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.Row.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Row.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.NgayCt, Me.CtSo, Me.KyHieuKhang, Me.TenKhang, Me.MstKhang, Me.NgayGhi, Me.SoTien, Me.GridColumn4, Me.DienGiai, Me.NguoiGiaoNhanHang})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", Nothing, "Tổng {0:n0}")})
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowFooter = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Trạng thái"
        Me.GridColumn1.FieldName = "Ghi"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'NgayCt
        '
        Me.NgayCt.Caption = "Ngày CT"
        Me.NgayCt.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayCt.FieldName = "NgayCt"
        Me.NgayCt.Name = "NgayCt"
        Me.NgayCt.Visible = True
        Me.NgayCt.VisibleIndex = 1
        Me.NgayCt.Width = 84
        '
        'CtSo
        '
        Me.CtSo.Caption = "Số CT"
        Me.CtSo.FieldName = "CtSo"
        Me.CtSo.Name = "CtSo"
        Me.CtSo.Visible = True
        Me.CtSo.VisibleIndex = 2
        Me.CtSo.Width = 106
        '
        'KyHieuKhang
        '
        Me.KyHieuKhang.Caption = "Mã khách hàng"
        Me.KyHieuKhang.FieldName = "KyHieuKhang"
        Me.KyHieuKhang.Name = "KyHieuKhang"
        Me.KyHieuKhang.Visible = True
        Me.KyHieuKhang.VisibleIndex = 3
        Me.KyHieuKhang.Width = 120
        '
        'TenKhang
        '
        Me.TenKhang.Caption = "Tên khách hàng"
        Me.TenKhang.FieldName = "TenKhang"
        Me.TenKhang.Name = "TenKhang"
        Me.TenKhang.Visible = True
        Me.TenKhang.VisibleIndex = 4
        Me.TenKhang.Width = 150
        '
        'MstKhang
        '
        Me.MstKhang.Caption = "Mã số thuế"
        Me.MstKhang.FieldName = "MstKhang"
        Me.MstKhang.Name = "MstKhang"
        Me.MstKhang.Visible = True
        Me.MstKhang.VisibleIndex = 5
        Me.MstKhang.Width = 100
        '
        'NgayGhi
        '
        Me.NgayGhi.Caption = "Ngày hạch toán"
        Me.NgayGhi.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayGhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayGhi.FieldName = "NgayGhi"
        Me.NgayGhi.Name = "NgayGhi"
        Me.NgayGhi.Visible = True
        Me.NgayGhi.VisibleIndex = 6
        Me.NgayGhi.Width = 100
        '
        'SoTien
        '
        Me.SoTien.Caption = "Tổng tiền"
        Me.SoTien.DisplayFormat.FormatString = "n0"
        Me.SoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTien.FieldName = "SoTien"
        Me.SoTien.Name = "SoTien"
        Me.SoTien.SummaryItem.DisplayFormat = "{0:n0}"
        Me.SoTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SoTien.Visible = True
        Me.SoTien.VisibleIndex = 7
        Me.SoTien.Width = 200
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tổng tiền thuế"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'DienGiai
        '
        Me.DienGiai.Caption = "Diễn giải"
        Me.DienGiai.FieldName = "DienGiai"
        Me.DienGiai.Name = "DienGiai"
        Me.DienGiai.Visible = True
        Me.DienGiai.VisibleIndex = 8
        Me.DienGiai.Width = 150
        '
        'NguoiGiaoNhanHang
        '
        Me.NguoiGiaoNhanHang.Caption = "Người giao hàng"
        Me.NguoiGiaoNhanHang.FieldName = "NguoiGiaoNhanHang"
        Me.NguoiGiaoNhanHang.Name = "NguoiGiaoNhanHang"
        Me.NguoiGiaoNhanHang.Visible = True
        Me.NguoiGiaoNhanHang.VisibleIndex = 9
        Me.NguoiGiaoNhanHang.Width = 150
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PagerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 236)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 38)
        Me.PanelControl1.TabIndex = 23
        '
        'PagerControl1
        '
        Me.PagerControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PagerControl1.Location = New System.Drawing.Point(512, 2)
        Me.PagerControl1.Name = "PagerControl1"
        Me.PagerControl1.PageIndex = 1
        Me.PagerControl1.PageSize = 100
        Me.PagerControl1.Size = New System.Drawing.Size(486, 34)
        Me.PagerControl1.TabIndex = 0
        Me.PagerControl1.TotalPage = 0
        Me.PagerControl1.TotalResult = 0
        '
        'frmHoaDonBanHangKiemPhieuXuatKho_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmHoaDonBanHangKiemPhieuXuatKho_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "frmHoaDonBanHangKiemPhieuXuatKho_DanhSach"
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHO_XUAT_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcLPN_Dnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPN_Dnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KY_HIEU_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_BAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIEN_GIAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGUOI_GIAO_NHAN_HANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_XUAT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKHO_XUAT_ID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MST_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MA_TKC_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_BAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieuHanghoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenHanghoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenDvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGiaBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KhoXuatId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaTkcThueGtgt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienThueGtgt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PagerControl1 As Vns.Erp.Core.Common.Controls.PagerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CtSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieuKhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenKhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MstKhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayGhi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DienGiai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NguoiGiaoNhanHang As DevExpress.XtraGrid.Columns.GridColumn
End Class
