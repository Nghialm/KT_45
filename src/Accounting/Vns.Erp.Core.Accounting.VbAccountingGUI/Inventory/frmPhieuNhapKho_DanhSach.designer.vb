<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuNhapKho_DanhSach
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.grvLPN_Dnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.KHO_NHAP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoNhap1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KHO_XUAT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoXuat1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KY_HIEU_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_LUONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GIA_VON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grcLPN_Dnx = New DevExpress.XtraGrid.GridControl()
        Me.cboKhoNhap = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhoXuat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MST_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIEN_GIAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGUOI_GIAO_NHAN_HANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PagerControl1 = New Vns.Erp.Core.Common.Controls.PagerControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoNhap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoXuat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoXuat, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnClo)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl2.TabIndex = 24
        '
        'btnClo
        '
        Me.btnClo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClo.ImageIndex = 1
        Me.btnClo.Location = New System.Drawing.Point(919, 3)
        Me.btnClo.Name = "btnClo"
        Me.btnClo.Size = New System.Drawing.Size(80, 30)
        Me.btnClo.TabIndex = 6
        Me.btnClo.Text = "&Đóng"
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
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(1, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Mới"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(173, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "Xóa"
        Me.btnDel.Visible = False
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
        Me.grvLPN_Dnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KHO_NHAP_ID, Me.KHO_XUAT_ID, Me.KY_HIEU_HANGHOA, Me.TEN_HANGHOA, Me.TEN_DVT, Me.SO_LUONG, Me.GridColumn1, Me.GIA_VON})
        Me.grvLPN_Dnx.GridControl = Me.grcLPN_Dnx
        Me.grvLPN_Dnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPN_Dnx.Name = "grvLPN_Dnx"
        Me.grvLPN_Dnx.OptionsBehavior.Editable = False
        Me.grvLPN_Dnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPN_Dnx.OptionsView.ShowGroupPanel = False
        '
        'KHO_NHAP_ID
        '
        Me.KHO_NHAP_ID.Caption = "Mã kho nhập"
        Me.KHO_NHAP_ID.ColumnEdit = Me.cboKhoNhap1
        Me.KHO_NHAP_ID.FieldName = "KhoNhapId"
        Me.KHO_NHAP_ID.Name = "KHO_NHAP_ID"
        Me.KHO_NHAP_ID.OptionsColumn.ReadOnly = True
        Me.KHO_NHAP_ID.Visible = True
        Me.KHO_NHAP_ID.VisibleIndex = 0
        Me.KHO_NHAP_ID.Width = 90
        '
        'cboKhoNhap1
        '
        Me.cboKhoNhap1.AutoHeight = False
        Me.cboKhoNhap1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoNhap1.Name = "cboKhoNhap1"
        Me.cboKhoNhap1.NullText = ""
        '
        'KHO_XUAT_ID
        '
        Me.KHO_XUAT_ID.Caption = "Mã kho xuất"
        Me.KHO_XUAT_ID.ColumnEdit = Me.cboKhoXuat1
        Me.KHO_XUAT_ID.FieldName = "KhoXuatId"
        Me.KHO_XUAT_ID.Name = "KHO_XUAT_ID"
        Me.KHO_XUAT_ID.OptionsColumn.ReadOnly = True
        Me.KHO_XUAT_ID.Visible = True
        Me.KHO_XUAT_ID.VisibleIndex = 1
        Me.KHO_XUAT_ID.Width = 90
        '
        'cboKhoXuat1
        '
        Me.cboKhoXuat1.AutoHeight = False
        Me.cboKhoXuat1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoXuat1.Name = "cboKhoXuat1"
        Me.cboKhoXuat1.NullText = ""
        '
        'KY_HIEU_HANGHOA
        '
        Me.KY_HIEU_HANGHOA.Caption = "Mã hàng"
        Me.KY_HIEU_HANGHOA.FieldName = "KyHieuHanghoa"
        Me.KY_HIEU_HANGHOA.Name = "KY_HIEU_HANGHOA"
        Me.KY_HIEU_HANGHOA.Visible = True
        Me.KY_HIEU_HANGHOA.VisibleIndex = 2
        Me.KY_HIEU_HANGHOA.Width = 120
        '
        'TEN_HANGHOA
        '
        Me.TEN_HANGHOA.Caption = "Tên hàng / Vật tư"
        Me.TEN_HANGHOA.FieldName = "TenHanghoa"
        Me.TEN_HANGHOA.Name = "TEN_HANGHOA"
        Me.TEN_HANGHOA.Visible = True
        Me.TEN_HANGHOA.VisibleIndex = 3
        Me.TEN_HANGHOA.Width = 120
        '
        'TEN_DVT
        '
        Me.TEN_DVT.Caption = "ĐVT"
        Me.TEN_DVT.FieldName = "TenDvt"
        Me.TEN_DVT.Name = "TEN_DVT"
        Me.TEN_DVT.Visible = True
        Me.TEN_DVT.VisibleIndex = 4
        '
        'SO_LUONG
        '
        Me.SO_LUONG.Caption = "Số lượng"
        Me.SO_LUONG.DisplayFormat.FormatString = "n2"
        Me.SO_LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_LUONG.FieldName = "SoLuong"
        Me.SO_LUONG.Name = "SO_LUONG"
        Me.SO_LUONG.Visible = True
        Me.SO_LUONG.VisibleIndex = 5
        Me.SO_LUONG.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Đơn giá"
        Me.GridColumn1.DisplayFormat.FormatString = "n2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "DonGiaVon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        '
        'GIA_VON
        '
        Me.GIA_VON.Caption = "Tổng tiền"
        Me.GIA_VON.DisplayFormat.FormatString = "n0"
        Me.GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GIA_VON.FieldName = "GiaVon"
        Me.GIA_VON.Name = "GIA_VON"
        Me.GIA_VON.Visible = True
        Me.GIA_VON.VisibleIndex = 7
        Me.GIA_VON.Width = 150
        '
        'grcLPN_Dnx
        '
        Me.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Dnx.Location = New System.Drawing.Point(2, 22)
        Me.grcLPN_Dnx.MainView = Me.grvLPN_Dnx
        Me.grcLPN_Dnx.Name = "grcLPN_Dnx"
        Me.grcLPN_Dnx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboKhoNhap, Me.cboKhoXuat, Me.cboKhoNhap1, Me.cboKhoXuat1})
        Me.grcLPN_Dnx.Size = New System.Drawing.Size(996, 263)
        Me.grcLPN_Dnx.TabIndex = 1
        Me.grcLPN_Dnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPN_Dnx})
        '
        'cboKhoNhap
        '
        Me.cboKhoNhap.AutoHeight = False
        Me.cboKhoNhap.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoNhap.Name = "cboKhoNhap"
        Me.cboKhoNhap.NullText = ""
        '
        'cboKhoXuat
        '
        Me.cboKhoXuat.AutoHeight = False
        Me.cboKhoXuat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoXuat.Name = "cboKhoXuat"
        Me.cboKhoXuat.NullText = ""
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.grcLPN_Dnx)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupControl2.Location = New System.Drawing.Point(0, 0)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Size = New System.Drawing.Size(1000, 287)
        Me.groupControl2.TabIndex = 23
        Me.groupControl2.Text = "Danh sách..."
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
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 25
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcLPN_Hnx)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 242)
        Me.GroupControl1.TabIndex = 24
        Me.GroupControl1.Text = "Danh sách..."
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 22)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(996, 218)
        Me.grcLPN_Hnx.TabIndex = 2
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
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GHI, Me.CT_SO, Me.NGAY_CT, Me.TEN_KHANG, Me.NGAY_GHI, Me.KY_HIEU_KHANG, Me.MST_KHANG, Me.DIEN_GIAI, Me.NGUOI_GIAO_NHAN_HANG})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'GHI
        '
        Me.GHI.Caption = "Trạng thái"
        Me.GHI.FieldName = "Ghi"
        Me.GHI.Name = "GHI"
        Me.GHI.Visible = True
        Me.GHI.VisibleIndex = 0
        '
        'CT_SO
        '
        Me.CT_SO.Caption = "Số chứng từ"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 1
        Me.CT_SO.Width = 80
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày chứng từ"
        Me.NGAY_CT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NGAY_CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 2
        Me.NGAY_CT.Width = 100
        '
        'TEN_KHANG
        '
        Me.TEN_KHANG.Caption = "Tên khách hàng"
        Me.TEN_KHANG.FieldName = "TenKhang"
        Me.TEN_KHANG.Name = "TEN_KHANG"
        Me.TEN_KHANG.Visible = True
        Me.TEN_KHANG.VisibleIndex = 4
        Me.TEN_KHANG.Width = 220
        '
        'NGAY_GHI
        '
        Me.NGAY_GHI.Caption = "Ngày hạch toán"
        Me.NGAY_GHI.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NGAY_GHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NGAY_GHI.FieldName = "NgayGhi"
        Me.NGAY_GHI.Name = "NGAY_GHI"
        Me.NGAY_GHI.Visible = True
        Me.NGAY_GHI.VisibleIndex = 6
        Me.NGAY_GHI.Width = 112
        '
        'KY_HIEU_KHANG
        '
        Me.KY_HIEU_KHANG.Caption = "Mã khách "
        Me.KY_HIEU_KHANG.FieldName = "KyHieuKhang"
        Me.KY_HIEU_KHANG.Name = "KY_HIEU_KHANG"
        Me.KY_HIEU_KHANG.Visible = True
        Me.KY_HIEU_KHANG.VisibleIndex = 3
        Me.KY_HIEU_KHANG.Width = 100
        '
        'MST_KHANG
        '
        Me.MST_KHANG.Caption = "Mã số thuế"
        Me.MST_KHANG.FieldName = "MstKhang"
        Me.MST_KHANG.Name = "MST_KHANG"
        Me.MST_KHANG.Visible = True
        Me.MST_KHANG.VisibleIndex = 5
        Me.MST_KHANG.Width = 100
        '
        'DIEN_GIAI
        '
        Me.DIEN_GIAI.Caption = "Diễn giải"
        Me.DIEN_GIAI.FieldName = "DienGiai"
        Me.DIEN_GIAI.Name = "DIEN_GIAI"
        Me.DIEN_GIAI.Visible = True
        Me.DIEN_GIAI.VisibleIndex = 7
        Me.DIEN_GIAI.Width = 150
        '
        'NGUOI_GIAO_NHAN_HANG
        '
        Me.NGUOI_GIAO_NHAN_HANG.Caption = "Người giao hàng"
        Me.NGUOI_GIAO_NHAN_HANG.FieldName = "NguoiGiaoNhanHang"
        Me.NGUOI_GIAO_NHAN_HANG.Name = "NGUOI_GIAO_NHAN_HANG"
        Me.NGUOI_GIAO_NHAN_HANG.Visible = True
        Me.NGUOI_GIAO_NHAN_HANG.VisibleIndex = 8
        Me.NGUOI_GIAO_NHAN_HANG.Width = 130
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PagerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 242)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 37)
        Me.PanelControl1.TabIndex = 23
        '
        'PagerControl1
        '
        Me.PagerControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PagerControl1.Location = New System.Drawing.Point(514, 2)
        Me.PagerControl1.Name = "PagerControl1"
        Me.PagerControl1.PageIndex = 1
        Me.PagerControl1.PageSize = 100
        Me.PagerControl1.Size = New System.Drawing.Size(484, 33)
        Me.PagerControl1.TabIndex = 0
        Me.PagerControl1.TotalPage = 0
        Me.PagerControl1.TotalResult = 0
        '
        'frmPhieuNhapKho_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmPhieuNhapKho_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại phiếu nhập kho"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoNhap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoXuat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoXuat, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grvLPN_Dnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grcLPN_Dnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents KY_HIEU_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_NHAP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_XUAT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKhoNhap As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoXuat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoNhap1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoXuat1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PagerControl1 As Vns.Erp.Core.Common.Controls.PagerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MST_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIEN_GIAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGUOI_GIAO_NHAN_HANG As DevExpress.XtraGrid.Columns.GridColumn
End Class
