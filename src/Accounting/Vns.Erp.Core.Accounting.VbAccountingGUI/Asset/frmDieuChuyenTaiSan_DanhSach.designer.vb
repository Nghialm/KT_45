<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDieuChuyenTaiSan_DanhSach
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
        Me.btnChuyen = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grcTSCD = New DevExpress.XtraGrid.GridControl()
        Me.grvTSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grcBoPhan = New DevExpress.XtraGrid.GridControl()
        Me.grvBoPhan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NGAY_DC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BO_PHAN_DC_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboBO_PHAN_DC_ID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LY_DO_DC = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grcBoPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvBoPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBO_PHAN_DC_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnModify)
        Me.PanelControl1.Controls.Add(Me.btnChuyen)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 570)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 42)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(923, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(89, 7)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 14
        Me.btnModify.Text = "&Sửa"
        '
        'btnChuyen
        '
        Me.btnChuyen.ImageIndex = 2
        Me.btnChuyen.Location = New System.Drawing.Point(3, 7)
        Me.btnChuyen.Name = "btnChuyen"
        Me.btnChuyen.Size = New System.Drawing.Size(80, 30)
        Me.btnChuyen.TabIndex = 13
        Me.btnChuyen.Text = "&Chuyển"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(175, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Xóa"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 570)
        Me.SplitContainerControl1.SplitterPosition = 303
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcTSCD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(303, 570)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách tài sản"
        '
        'grcTSCD
        '
        Me.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcTSCD.Location = New System.Drawing.Point(2, 22)
        Me.grcTSCD.MainView = Me.grvTSCD
        Me.grcTSCD.Name = "grcTSCD"
        Me.grcTSCD.Size = New System.Drawing.Size(299, 546)
        Me.grcTSCD.TabIndex = 0
        Me.grcTSCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvTSCD})
        '
        'grvTSCD
        '
        Me.grvTSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvTSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvTSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvTSCD.Appearance.Empty.Options.UseBackColor = True
        Me.grvTSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvTSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvTSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvTSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvTSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvTSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvTSCD.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvTSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvTSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvTSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvTSCD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvTSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvTSCD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvTSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvTSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvTSCD.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvTSCD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvTSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvTSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvTSCD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvTSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvTSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvTSCD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvTSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvTSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvTSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvTSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvTSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvTSCD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvTSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvTSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvTSCD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvTSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvTSCD.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvTSCD.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.OddRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvTSCD.Appearance.OddRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvTSCD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvTSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvTSCD.Appearance.Preview.Options.UseBackColor = True
        Me.grvTSCD.Appearance.Preview.Options.UseFont = True
        Me.grvTSCD.Appearance.Preview.Options.UseForeColor = True
        Me.grvTSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.Row.Options.UseBackColor = True
        Me.grvTSCD.Appearance.Row.Options.UseForeColor = True
        Me.grvTSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvTSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvTSCD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvTSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvTSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvTSCD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvTSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvTSCD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvTSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvTSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvTSCD.Appearance.VertLine.Options.UseBackColor = True
        Me.grvTSCD.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvTSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TSCD, Me.TEN_TSCD})
        Me.grvTSCD.GridControl = Me.grcTSCD
        Me.grvTSCD.Name = "grvTSCD"
        Me.grvTSCD.OptionsView.ColumnAutoWidth = False
        Me.grvTSCD.OptionsView.EnableAppearanceEvenRow = True
        Me.grvTSCD.OptionsView.EnableAppearanceOddRow = True
        Me.grvTSCD.OptionsView.ShowGroupPanel = False
        '
        'MA_TSCD
        '
        Me.MA_TSCD.Caption = "Mã tài sản"
        Me.MA_TSCD.FieldName = "MaTscd"
        Me.MA_TSCD.Name = "MA_TSCD"
        Me.MA_TSCD.OptionsColumn.ReadOnly = True
        Me.MA_TSCD.Visible = True
        Me.MA_TSCD.VisibleIndex = 0
        Me.MA_TSCD.Width = 124
        '
        'TEN_TSCD
        '
        Me.TEN_TSCD.Caption = "Tên tài sản"
        Me.TEN_TSCD.FieldName = "TenTscd"
        Me.TEN_TSCD.Name = "TEN_TSCD"
        Me.TEN_TSCD.OptionsColumn.ReadOnly = True
        Me.TEN_TSCD.Visible = True
        Me.TEN_TSCD.VisibleIndex = 1
        Me.TEN_TSCD.Width = 165
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grcBoPhan)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(700, 570)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Bộ phận điều chuyển"
        '
        'grcBoPhan
        '
        Me.grcBoPhan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcBoPhan.Location = New System.Drawing.Point(2, 22)
        Me.grcBoPhan.MainView = Me.grvBoPhan
        Me.grcBoPhan.Name = "grcBoPhan"
        Me.grcBoPhan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboBO_PHAN_DC_ID})
        Me.grcBoPhan.Size = New System.Drawing.Size(696, 546)
        Me.grcBoPhan.TabIndex = 0
        Me.grcBoPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvBoPhan})
        '
        'grvBoPhan
        '
        Me.grvBoPhan.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.Empty.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvBoPhan.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvBoPhan.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvBoPhan.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvBoPhan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvBoPhan.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvBoPhan.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvBoPhan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvBoPhan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvBoPhan.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvBoPhan.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvBoPhan.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvBoPhan.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.OddRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvBoPhan.Appearance.OddRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvBoPhan.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvBoPhan.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvBoPhan.Appearance.Preview.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.Preview.Options.UseFont = True
        Me.grvBoPhan.Appearance.Preview.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.Row.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.Row.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvBoPhan.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvBoPhan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvBoPhan.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvBoPhan.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvBoPhan.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvBoPhan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvBoPhan.Appearance.VertLine.Options.UseBackColor = True
        Me.grvBoPhan.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvBoPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NGAY_DC, Me.BO_PHAN_DC_ID, Me.LY_DO_DC})
        Me.grvBoPhan.GridControl = Me.grcBoPhan
        Me.grvBoPhan.Name = "grvBoPhan"
        Me.grvBoPhan.OptionsBehavior.Editable = False
        Me.grvBoPhan.OptionsView.ColumnAutoWidth = False
        Me.grvBoPhan.OptionsView.EnableAppearanceEvenRow = True
        Me.grvBoPhan.OptionsView.EnableAppearanceOddRow = True
        Me.grvBoPhan.OptionsView.ShowGroupPanel = False
        '
        'NGAY_DC
        '
        Me.NGAY_DC.Caption = "Ngày điều chuyển"
        Me.NGAY_DC.FieldName = "NgayDc"
        Me.NGAY_DC.Name = "NGAY_DC"
        Me.NGAY_DC.OptionsColumn.ReadOnly = True
        Me.NGAY_DC.Visible = True
        Me.NGAY_DC.VisibleIndex = 0
        Me.NGAY_DC.Width = 151
        '
        'BO_PHAN_DC_ID
        '
        Me.BO_PHAN_DC_ID.Caption = "Bộ phận điều chuyển"
        Me.BO_PHAN_DC_ID.ColumnEdit = Me.cboBO_PHAN_DC_ID
        Me.BO_PHAN_DC_ID.FieldName = "BoPhanDcId"
        Me.BO_PHAN_DC_ID.Name = "BO_PHAN_DC_ID"
        Me.BO_PHAN_DC_ID.OptionsColumn.ReadOnly = True
        Me.BO_PHAN_DC_ID.Visible = True
        Me.BO_PHAN_DC_ID.VisibleIndex = 1
        Me.BO_PHAN_DC_ID.Width = 157
        '
        'cboBO_PHAN_DC_ID
        '
        Me.cboBO_PHAN_DC_ID.AutoHeight = False
        Me.cboBO_PHAN_DC_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBO_PHAN_DC_ID.Name = "cboBO_PHAN_DC_ID"
        Me.cboBO_PHAN_DC_ID.NullText = ""
        '
        'LY_DO_DC
        '
        Me.LY_DO_DC.Caption = "Lý do điều chuyển"
        Me.LY_DO_DC.FieldName = "LyDoDc"
        Me.LY_DO_DC.Name = "LY_DO_DC"
        Me.LY_DO_DC.OptionsColumn.ReadOnly = True
        Me.LY_DO_DC.Visible = True
        Me.LY_DO_DC.VisibleIndex = 2
        Me.LY_DO_DC.Width = 201
        '
        'frmDieuChuyenTaiSan_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmDieuChuyenTaiSan_DanhSach"
        Me.Text = "Điều chuyển tài sản"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grcBoPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvBoPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBO_PHAN_DC_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChuyen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcTSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvTSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcBoPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvBoPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NGAY_DC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BO_PHAN_DC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBO_PHAN_DC_ID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LY_DO_DC As DevExpress.XtraGrid.Columns.GridColumn
End Class
