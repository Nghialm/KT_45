<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpecPhieuMuaHang_Danhsach
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.grvLPN_Dnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_HANGHOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KHO_NHAP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKHO_NHAP_ID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TEN_DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_LUONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DON_GIA_VON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GIA_VON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colLSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grcLPN_Dnx = New DevExpress.XtraGrid.GridControl()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIEN_GIAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPtThanhtoan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colNgoaiTe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboNte = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PagerControl1 = New Vns.Erp.Core.Common.Controls.PagerControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHO_NHAP_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPtThanhtoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(103, 4)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(93, 37)
        Me.btnMod.TabIndex = 4
        Me.btnMod.Text = "Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(2, 4)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 37)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Mới"
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 711)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1176, 42)
        Me.PanelControl2.TabIndex = 0
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(203, 4)
        Me.btnSea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(93, 37)
        Me.btnSea.TabIndex = 8
        Me.btnSea.Text = "Tìm kiếm"
        Me.btnSea.Visible = False
        '
        'btnClo
        '
        Me.btnClo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClo.ImageIndex = 1
        Me.btnClo.Location = New System.Drawing.Point(1081, 4)
        Me.btnClo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClo.Name = "btnClo"
        Me.btnClo.Size = New System.Drawing.Size(93, 37)
        Me.btnClo.TabIndex = 7
        Me.btnClo.Text = "&Đóng"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(303, 4)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(93, 37)
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
        Me.grvLPN_Dnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.KY_HIEU_HANGHOA, Me.TEN_HANGHOA, Me.KHO_NHAP_ID, Me.TEN_DVT, Me.SO_LUONG, Me.DON_GIA_VON, Me.GIA_VON, Me.colCang, Me.colETD, Me.colETA, Me.colLSD})
        Me.grvLPN_Dnx.GridControl = Me.grcLPN_Dnx
        Me.grvLPN_Dnx.Name = "grvLPN_Dnx"
        Me.grvLPN_Dnx.OptionsBehavior.Editable = False
        Me.grvLPN_Dnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPN_Dnx.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Code"
        Me.GridColumn2.FieldName = "MaVuviec"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 72
        '
        'KY_HIEU_HANGHOA
        '
        Me.KY_HIEU_HANGHOA.Caption = "Mã hàng"
        Me.KY_HIEU_HANGHOA.FieldName = "KyHieuHanghoa"
        Me.KY_HIEU_HANGHOA.Name = "KY_HIEU_HANGHOA"
        Me.KY_HIEU_HANGHOA.Visible = True
        Me.KY_HIEU_HANGHOA.VisibleIndex = 1
        Me.KY_HIEU_HANGHOA.Width = 91
        '
        'TEN_HANGHOA
        '
        Me.TEN_HANGHOA.Caption = "Tên hàng"
        Me.TEN_HANGHOA.FieldName = "TenHanghoa"
        Me.TEN_HANGHOA.Name = "TEN_HANGHOA"
        Me.TEN_HANGHOA.OptionsColumn.ReadOnly = True
        Me.TEN_HANGHOA.Visible = True
        Me.TEN_HANGHOA.VisibleIndex = 2
        Me.TEN_HANGHOA.Width = 248
        '
        'KHO_NHAP_ID
        '
        Me.KHO_NHAP_ID.Caption = "Mã kho"
        Me.KHO_NHAP_ID.ColumnEdit = Me.cboKHO_NHAP_ID
        Me.KHO_NHAP_ID.FieldName = "KhoNhapId"
        Me.KHO_NHAP_ID.Name = "KHO_NHAP_ID"
        Me.KHO_NHAP_ID.OptionsColumn.ReadOnly = True
        Me.KHO_NHAP_ID.Width = 125
        '
        'cboKHO_NHAP_ID
        '
        Me.cboKHO_NHAP_ID.AutoHeight = False
        Me.cboKHO_NHAP_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHO_NHAP_ID.Name = "cboKHO_NHAP_ID"
        Me.cboKHO_NHAP_ID.NullText = ""
        '
        'TEN_DVT
        '
        Me.TEN_DVT.Caption = "Đơn vị tính"
        Me.TEN_DVT.FieldName = "TenDvt"
        Me.TEN_DVT.Name = "TEN_DVT"
        '
        'SO_LUONG
        '
        Me.SO_LUONG.Caption = "Số lượng"
        Me.SO_LUONG.DisplayFormat.FormatString = "n2"
        Me.SO_LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_LUONG.FieldName = "SoLuong"
        Me.SO_LUONG.Name = "SO_LUONG"
        Me.SO_LUONG.OptionsColumn.ReadOnly = True
        Me.SO_LUONG.Visible = True
        Me.SO_LUONG.VisibleIndex = 3
        Me.SO_LUONG.Width = 100
        '
        'DON_GIA_VON
        '
        Me.DON_GIA_VON.Caption = "Giá"
        Me.DON_GIA_VON.DisplayFormat.FormatString = "n2"
        Me.DON_GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DON_GIA_VON.FieldName = "DonGiaVon"
        Me.DON_GIA_VON.Name = "DON_GIA_VON"
        Me.DON_GIA_VON.OptionsColumn.ReadOnly = True
        Me.DON_GIA_VON.Visible = True
        Me.DON_GIA_VON.VisibleIndex = 4
        Me.DON_GIA_VON.Width = 100
        '
        'GIA_VON
        '
        Me.GIA_VON.Caption = "Tổng tiền"
        Me.GIA_VON.DisplayFormat.FormatString = "n0"
        Me.GIA_VON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GIA_VON.FieldName = "GiaVon"
        Me.GIA_VON.Name = "GIA_VON"
        Me.GIA_VON.Visible = True
        Me.GIA_VON.VisibleIndex = 5
        Me.GIA_VON.Width = 120
        '
        'colCang
        '
        Me.colCang.Caption = "Cảng"
        Me.colCang.ColumnEdit = Me.cboCang
        Me.colCang.FieldName = "Cang"
        Me.colCang.Name = "colCang"
        Me.colCang.Visible = True
        Me.colCang.VisibleIndex = 9
        Me.colCang.Width = 159
        '
        'cboCang
        '
        Me.cboCang.AutoHeight = False
        Me.cboCang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCang.DisplayMember = "TenDanhmuc"
        Me.cboCang.Name = "cboCang"
        Me.cboCang.ValueMember = "GiaTri"
        '
        'colLSD
        '
        Me.colLSD.Caption = "LSD"
        Me.colLSD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colLSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLSD.FieldName = "LsdDate"
        Me.colLSD.Name = "colLSD"
        Me.colLSD.Visible = True
        Me.colLSD.VisibleIndex = 8
        Me.colLSD.Width = 98
        '
        'colETD
        '
        Me.colETD.Caption = "ETD"
        Me.colETD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colETD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colETD.FieldName = "ETD"
        Me.colETD.Name = "colETD"
        Me.colETD.Visible = True
        Me.colETD.VisibleIndex = 6
        Me.colETD.Width = 92
        '
        'colETA
        '
        Me.colETA.Caption = "ETA"
        Me.colETA.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colETA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colETA.FieldName = "EtaDate"
        Me.colETA.Name = "colETA"
        Me.colETA.Visible = True
        Me.colETA.VisibleIndex = 7
        Me.colETA.Width = 110
        '
        'grcLPN_Dnx
        '
        Me.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Dnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Dnx.Location = New System.Drawing.Point(2, 24)
        Me.grcLPN_Dnx.MainView = Me.grvLPN_Dnx
        Me.grcLPN_Dnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Dnx.Name = "grcLPN_Dnx"
        Me.grcLPN_Dnx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboKHO_NHAP_ID, Me.cboCang})
        Me.grcLPN_Dnx.Size = New System.Drawing.Size(1172, 335)
        Me.grcLPN_Dnx.TabIndex = 0
        Me.grcLPN_Dnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPN_Dnx})
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.grcLPN_Dnx)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupControl2.Location = New System.Drawing.Point(0, 0)
        Me.groupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Size = New System.Drawing.Size(1176, 361)
        Me.groupControl2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1176, 711)
        Me.SplitContainer1.SplitterDistance = 345
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcLPN_Hnx)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1176, 296)
        Me.GroupControl1.TabIndex = 24
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 24)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboPtThanhtoan, Me.cboNte})
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(1172, 270)
        Me.grcLPN_Hnx.TabIndex = 0
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
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.NGAY_CT, Me.CT_SO, Me.KY_HIEU_KHANG, Me.TEN_KHANG, Me.SO_TIEN, Me.DIEN_GIAI, Me.GridColumn3, Me.GridColumn4, Me.colNgoaiTe})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", Nothing, "Tổng {0:n0}")})
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
        Me.GridColumn1.Width = 92
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày CT"
        Me.NGAY_CT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NGAY_CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.OptionsColumn.ReadOnly = True
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 1
        Me.NGAY_CT.Width = 120
        '
        'CT_SO
        '
        Me.CT_SO.Caption = "Số CT"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.OptionsColumn.ReadOnly = True
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 2
        Me.CT_SO.Width = 105
        '
        'KY_HIEU_KHANG
        '
        Me.KY_HIEU_KHANG.Caption = "Mã nhà cung cấp"
        Me.KY_HIEU_KHANG.FieldName = "KyHieuKhang"
        Me.KY_HIEU_KHANG.Name = "KY_HIEU_KHANG"
        Me.KY_HIEU_KHANG.Visible = True
        Me.KY_HIEU_KHANG.VisibleIndex = 5
        Me.KY_HIEU_KHANG.Width = 128
        '
        'TEN_KHANG
        '
        Me.TEN_KHANG.Caption = "Tên nhà cung cấp"
        Me.TEN_KHANG.FieldName = "TenKhang"
        Me.TEN_KHANG.Name = "TEN_KHANG"
        Me.TEN_KHANG.Visible = True
        Me.TEN_KHANG.VisibleIndex = 6
        Me.TEN_KHANG.Width = 345
        '
        'SO_TIEN
        '
        Me.SO_TIEN.Caption = "Tổng tiền"
        Me.SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_TIEN.FieldName = "SoTien"
        Me.SO_TIEN.Name = "SO_TIEN"
        Me.SO_TIEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoTien", "{0:n0}")})
        Me.SO_TIEN.Visible = True
        Me.SO_TIEN.VisibleIndex = 7
        Me.SO_TIEN.Width = 126
        '
        'DIEN_GIAI
        '
        Me.DIEN_GIAI.Caption = "Diễn giải"
        Me.DIEN_GIAI.FieldName = "DienGiai"
        Me.DIEN_GIAI.Name = "DIEN_GIAI"
        Me.DIEN_GIAI.OptionsColumn.ReadOnly = True
        Me.DIEN_GIAI.Visible = True
        Me.DIEN_GIAI.VisibleIndex = 9
        Me.DIEN_GIAI.Width = 556
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Mã hợp đồng"
        Me.GridColumn3.FieldName = "BxDiengiai1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 121
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "PT thanh toán"
        Me.GridColumn4.ColumnEdit = Me.cboPtThanhtoan
        Me.GridColumn4.FieldName = "PpThanhtoan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 155
        '
        'cboPtThanhtoan
        '
        Me.cboPtThanhtoan.AutoHeight = False
        Me.cboPtThanhtoan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPtThanhtoan.DisplayMember = "TenDanhmuc"
        Me.cboPtThanhtoan.Name = "cboPtThanhtoan"
        Me.cboPtThanhtoan.NullText = ""
        Me.cboPtThanhtoan.ValueMember = "GiaTri"
        '
        'colNgoaiTe
        '
        Me.colNgoaiTe.Caption = "Ngoại tệ"
        Me.colNgoaiTe.ColumnEdit = Me.cboNte
        Me.colNgoaiTe.FieldName = "NteId"
        Me.colNgoaiTe.Name = "colNgoaiTe"
        Me.colNgoaiTe.Visible = True
        Me.colNgoaiTe.VisibleIndex = 8
        Me.colNgoaiTe.Width = 65
        '
        'cboNte
        '
        Me.cboNte.AutoHeight = False
        Me.cboNte.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNte.DisplayMember = "KyHieu"
        Me.cboNte.Name = "cboNte"
        Me.cboNte.NullText = ""
        Me.cboNte.ValueMember = "Id"
        Me.cboNte.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PagerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 296)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1176, 49)
        Me.PanelControl1.TabIndex = 23
        '
        'PagerControl1
        '
        Me.PagerControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PagerControl1.Location = New System.Drawing.Point(605, 2)
        Me.PagerControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.PagerControl1.Name = "PagerControl1"
        Me.PagerControl1.PageIndex = 1
        Me.PagerControl1.PageSize = 100
        Me.PagerControl1.Size = New System.Drawing.Size(569, 45)
        Me.PagerControl1.TabIndex = 0
        Me.PagerControl1.TotalPage = 0
        Me.PagerControl1.TotalResult = 0
        '
        'frmOpecPhieuMuaHang_Danhsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 753)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOpecPhieuMuaHang_Danhsach"
        Me.ShowInTaskbar = False
        Me.Text = "frmPhieuNhapKhau_Danhsach"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHO_NHAP_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPtThanhtoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grvLPN_Dnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcLPN_Dnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KY_HIEU_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_NHAP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKHO_NHAP_ID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIEN_GIAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PagerControl1 As Vns.Erp.Core.Common.Controls.PagerControl
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPtThanhtoan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colLSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgoaiTe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboNte As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
