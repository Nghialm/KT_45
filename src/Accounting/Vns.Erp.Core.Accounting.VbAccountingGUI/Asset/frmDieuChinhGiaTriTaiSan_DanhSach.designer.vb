<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDieuChinhGiaTriTaiSan_DanhSach
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grc_CT_TSCD = New DevExpress.XtraGrid.GridControl()
        Me.grvCT_TSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TANG_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_LYDO_TANGGIAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGUYEN_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GIA_TRI_CL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HAO_MON_LUY_KE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TY_LE_HAOMON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grcDM_TSCD = New DevExpress.XtraGrid.GridControl()
        Me.grvDM_TSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_NAM_SD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MD_TK_TS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMD_TK_TS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MD_TK_KHAUHAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMD_TK_KHAUHAO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MD_TK_CHIPHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMD_TK_CHIPHI = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grc_CT_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCT_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDM_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDM_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMD_TK_TS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMD_TK_KHAUHAO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMD_TK_CHIPHI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnModify)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(919, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(86, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 10
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(0, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(172, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Xóa"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grc_CT_TSCD)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(4, 294)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1000, 280)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Thông tin điều chỉnh"
        '
        'grc_CT_TSCD
        '
        Me.grc_CT_TSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grc_CT_TSCD.Location = New System.Drawing.Point(2, 22)
        Me.grc_CT_TSCD.MainView = Me.grvCT_TSCD
        Me.grc_CT_TSCD.Name = "grc_CT_TSCD"
        Me.grc_CT_TSCD.Size = New System.Drawing.Size(996, 256)
        Me.grc_CT_TSCD.TabIndex = 0
        Me.grc_CT_TSCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCT_TSCD})
        '
        'grvCT_TSCD
        '
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.Empty.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvCT_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvCT_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvCT_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvCT_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvCT_TSCD.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.OddRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvCT_TSCD.Appearance.OddRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvCT_TSCD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvCT_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvCT_TSCD.Appearance.Preview.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.Preview.Options.UseFont = True
        Me.grvCT_TSCD.Appearance.Preview.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.Row.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.Row.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvCT_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvCT_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvCT_TSCD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvCT_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvCT_TSCD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvCT_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvCT_TSCD.Appearance.VertLine.Options.UseBackColor = True
        Me.grvCT_TSCD.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvCT_TSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TANG_TSCD, Me.TEN_LYDO_TANGGIAM, Me.NGUYEN_GIA, Me.GIA_TRI_CL, Me.HAO_MON_LUY_KE, Me.TY_LE_HAOMON, Me.GridColumn2})
        Me.grvCT_TSCD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvCT_TSCD.GridControl = Me.grc_CT_TSCD
        Me.grvCT_TSCD.Name = "grvCT_TSCD"
        Me.grvCT_TSCD.OptionsView.EnableAppearanceEvenRow = True
        Me.grvCT_TSCD.OptionsView.EnableAppearanceOddRow = True
        Me.grvCT_TSCD.OptionsView.ShowGroupPanel = False
        '
        'TANG_TSCD
        '
        Me.TANG_TSCD.Caption = "Tăng/giảm"
        Me.TANG_TSCD.FieldName = "TangTscd"
        Me.TANG_TSCD.Name = "TANG_TSCD"
        Me.TANG_TSCD.OptionsColumn.ReadOnly = True
        Me.TANG_TSCD.Visible = True
        Me.TANG_TSCD.VisibleIndex = 0
        Me.TANG_TSCD.Width = 105
        '
        'TEN_LYDO_TANGGIAM
        '
        Me.TEN_LYDO_TANGGIAM.Caption = "Lý do tăng giảm"
        Me.TEN_LYDO_TANGGIAM.FieldName = "TenLydoTanggiam"
        Me.TEN_LYDO_TANGGIAM.Name = "TEN_LYDO_TANGGIAM"
        Me.TEN_LYDO_TANGGIAM.OptionsColumn.ReadOnly = True
        Me.TEN_LYDO_TANGGIAM.Visible = True
        Me.TEN_LYDO_TANGGIAM.VisibleIndex = 1
        Me.TEN_LYDO_TANGGIAM.Width = 243
        '
        'NGUYEN_GIA
        '
        Me.NGUYEN_GIA.Caption = "Nguyên giá"
        Me.NGUYEN_GIA.DisplayFormat.FormatString = "#,###0"
        Me.NGUYEN_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NGUYEN_GIA.FieldName = "NguyenGia"
        Me.NGUYEN_GIA.Name = "NGUYEN_GIA"
        Me.NGUYEN_GIA.OptionsColumn.ReadOnly = True
        Me.NGUYEN_GIA.Visible = True
        Me.NGUYEN_GIA.VisibleIndex = 2
        Me.NGUYEN_GIA.Width = 102
        '
        'GIA_TRI_CL
        '
        Me.GIA_TRI_CL.Caption = "Giá trị còn lại"
        Me.GIA_TRI_CL.DisplayFormat.FormatString = "#,###0"
        Me.GIA_TRI_CL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GIA_TRI_CL.FieldName = "GiaTriCl"
        Me.GIA_TRI_CL.Name = "GIA_TRI_CL"
        Me.GIA_TRI_CL.OptionsColumn.ReadOnly = True
        Me.GIA_TRI_CL.Visible = True
        Me.GIA_TRI_CL.VisibleIndex = 3
        Me.GIA_TRI_CL.Width = 103
        '
        'HAO_MON_LUY_KE
        '
        Me.HAO_MON_LUY_KE.Caption = "Hao mòn lũy kế"
        Me.HAO_MON_LUY_KE.DisplayFormat.FormatString = "#,###"
        Me.HAO_MON_LUY_KE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.HAO_MON_LUY_KE.FieldName = "HaoMonLuyKe"
        Me.HAO_MON_LUY_KE.Name = "HAO_MON_LUY_KE"
        Me.HAO_MON_LUY_KE.OptionsColumn.ReadOnly = True
        Me.HAO_MON_LUY_KE.Visible = True
        Me.HAO_MON_LUY_KE.VisibleIndex = 4
        Me.HAO_MON_LUY_KE.Width = 113
        '
        'TY_LE_HAOMON
        '
        Me.TY_LE_HAOMON.Caption = "Tỷ lệ hao mòn"
        Me.TY_LE_HAOMON.FieldName = "TyLeHaomon"
        Me.TY_LE_HAOMON.Name = "TY_LE_HAOMON"
        Me.TY_LE_HAOMON.OptionsColumn.ReadOnly = True
        Me.TY_LE_HAOMON.Visible = True
        Me.TY_LE_HAOMON.VisibleIndex = 5
        Me.TY_LE_HAOMON.Width = 96
        '
        'GridColumn2
        '
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 396
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.grcDM_TSCD
        Me.GridView4.Name = "GridView4"
        '
        'grcDM_TSCD
        '
        Me.grcDM_TSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcDM_TSCD.Location = New System.Drawing.Point(2, 22)
        Me.grcDM_TSCD.MainView = Me.grvDM_TSCD
        Me.grcDM_TSCD.Name = "grcDM_TSCD"
        Me.grcDM_TSCD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboMD_TK_TS, Me.cboMD_TK_KHAUHAO, Me.cboMD_TK_CHIPHI})
        Me.grcDM_TSCD.Size = New System.Drawing.Size(996, 266)
        Me.grcDM_TSCD.TabIndex = 0
        Me.grcDM_TSCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDM_TSCD, Me.GridView5, Me.GridView4})
        '
        'grvDM_TSCD
        '
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.Empty.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvDM_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvDM_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvDM_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvDM_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvDM_TSCD.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.OddRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvDM_TSCD.Appearance.OddRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvDM_TSCD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvDM_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvDM_TSCD.Appearance.Preview.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.Preview.Options.UseFont = True
        Me.grvDM_TSCD.Appearance.Preview.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.Row.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.Row.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvDM_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvDM_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvDM_TSCD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvDM_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvDM_TSCD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvDM_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvDM_TSCD.Appearance.VertLine.Options.UseBackColor = True
        Me.grvDM_TSCD.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvDM_TSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TSCD, Me.TEN_TSCD, Me.NGAY_BDSD, Me.SO_NAM_SD, Me.MD_TK_TS, Me.MD_TK_KHAUHAO, Me.MD_TK_CHIPHI, Me.GridColumn1})
        Me.grvDM_TSCD.GridControl = Me.grcDM_TSCD
        Me.grvDM_TSCD.Name = "grvDM_TSCD"
        Me.grvDM_TSCD.OptionsView.EnableAppearanceEvenRow = True
        Me.grvDM_TSCD.OptionsView.EnableAppearanceOddRow = True
        Me.grvDM_TSCD.OptionsView.ShowGroupPanel = False
        '
        'MA_TSCD
        '
        Me.MA_TSCD.Caption = "Mã tài sản"
        Me.MA_TSCD.FieldName = "MaTscd"
        Me.MA_TSCD.Name = "MA_TSCD"
        Me.MA_TSCD.OptionsColumn.FixedWidth = True
        Me.MA_TSCD.OptionsColumn.ReadOnly = True
        Me.MA_TSCD.Visible = True
        Me.MA_TSCD.VisibleIndex = 0
        Me.MA_TSCD.Width = 114
        '
        'TEN_TSCD
        '
        Me.TEN_TSCD.Caption = "Tên tài sản"
        Me.TEN_TSCD.FieldName = "TenTscd"
        Me.TEN_TSCD.Name = "TEN_TSCD"
        Me.TEN_TSCD.OptionsColumn.FixedWidth = True
        Me.TEN_TSCD.OptionsColumn.ReadOnly = True
        Me.TEN_TSCD.Visible = True
        Me.TEN_TSCD.VisibleIndex = 1
        Me.TEN_TSCD.Width = 300
        '
        'NGAY_BDSD
        '
        Me.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng"
        Me.NGAY_BDSD.FieldName = "NgayBdsd"
        Me.NGAY_BDSD.Name = "NGAY_BDSD"
        Me.NGAY_BDSD.OptionsColumn.FixedWidth = True
        Me.NGAY_BDSD.OptionsColumn.ReadOnly = True
        Me.NGAY_BDSD.Visible = True
        Me.NGAY_BDSD.VisibleIndex = 2
        Me.NGAY_BDSD.Width = 135
        '
        'SO_NAM_SD
        '
        Me.SO_NAM_SD.Caption = "Số tháng sử dụng"
        Me.SO_NAM_SD.FieldName = "SoThangSd"
        Me.SO_NAM_SD.Name = "SO_NAM_SD"
        Me.SO_NAM_SD.OptionsColumn.FixedWidth = True
        Me.SO_NAM_SD.OptionsColumn.ReadOnly = True
        Me.SO_NAM_SD.Visible = True
        Me.SO_NAM_SD.VisibleIndex = 3
        Me.SO_NAM_SD.Width = 111
        '
        'MD_TK_TS
        '
        Me.MD_TK_TS.Caption = "Tài khoản tài sản"
        Me.MD_TK_TS.ColumnEdit = Me.cboMD_TK_TS
        Me.MD_TK_TS.FieldName = "MdTkTs"
        Me.MD_TK_TS.Name = "MD_TK_TS"
        Me.MD_TK_TS.OptionsColumn.FixedWidth = True
        Me.MD_TK_TS.OptionsColumn.ReadOnly = True
        Me.MD_TK_TS.Visible = True
        Me.MD_TK_TS.VisibleIndex = 4
        Me.MD_TK_TS.Width = 111
        '
        'cboMD_TK_TS
        '
        Me.cboMD_TK_TS.AutoHeight = False
        Me.cboMD_TK_TS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMD_TK_TS.Name = "cboMD_TK_TS"
        Me.cboMD_TK_TS.NullText = ""
        '
        'MD_TK_KHAUHAO
        '
        Me.MD_TK_KHAUHAO.Caption = "Tài khoản khấu hao"
        Me.MD_TK_KHAUHAO.ColumnEdit = Me.cboMD_TK_KHAUHAO
        Me.MD_TK_KHAUHAO.FieldName = "MdTkKhauhao"
        Me.MD_TK_KHAUHAO.Name = "MD_TK_KHAUHAO"
        Me.MD_TK_KHAUHAO.OptionsColumn.FixedWidth = True
        Me.MD_TK_KHAUHAO.OptionsColumn.ReadOnly = True
        Me.MD_TK_KHAUHAO.Visible = True
        Me.MD_TK_KHAUHAO.VisibleIndex = 5
        Me.MD_TK_KHAUHAO.Width = 120
        '
        'cboMD_TK_KHAUHAO
        '
        Me.cboMD_TK_KHAUHAO.AutoHeight = False
        Me.cboMD_TK_KHAUHAO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMD_TK_KHAUHAO.Name = "cboMD_TK_KHAUHAO"
        Me.cboMD_TK_KHAUHAO.NullText = ""
        '
        'MD_TK_CHIPHI
        '
        Me.MD_TK_CHIPHI.Caption = "Tài khoản chi phí"
        Me.MD_TK_CHIPHI.ColumnEdit = Me.cboMD_TK_CHIPHI
        Me.MD_TK_CHIPHI.FieldName = "MdTkChiphi"
        Me.MD_TK_CHIPHI.Name = "MD_TK_CHIPHI"
        Me.MD_TK_CHIPHI.OptionsColumn.FixedWidth = True
        Me.MD_TK_CHIPHI.OptionsColumn.ReadOnly = True
        Me.MD_TK_CHIPHI.Visible = True
        Me.MD_TK_CHIPHI.VisibleIndex = 6
        Me.MD_TK_CHIPHI.Width = 121
        '
        'cboMD_TK_CHIPHI
        '
        Me.cboMD_TK_CHIPHI.AutoHeight = False
        Me.cboMD_TK_CHIPHI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMD_TK_CHIPHI.Name = "cboMD_TK_CHIPHI"
        Me.cboMD_TK_CHIPHI.NullText = ""
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 146
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.grcDM_TSCD
        Me.GridView5.Name = "GridView5"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcDM_TSCD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 290)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Thông tin tài sản cố định"
        '
        'frmDieuChinhGiaTriTaiSan_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmDieuChinhGiaTriTaiSan_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Điều chỉnh giá trị tài sản"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grc_CT_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCT_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDM_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDM_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMD_TK_TS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMD_TK_KHAUHAO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMD_TK_CHIPHI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grc_CT_TSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCT_TSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TANG_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_LYDO_TANGGIAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGUYEN_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIA_TRI_CL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HAO_MON_LUY_KE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_HAOMON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grcDM_TSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDM_TSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NAM_SD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_TS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_KHAUHAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MD_TK_CHIPHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboMD_TK_TS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMD_TK_KHAUHAO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMD_TK_CHIPHI As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
