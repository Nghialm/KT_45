<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhaiBaoCacButToanPBTD_DanhSach
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
        Me.pcbottom = New DevExpress.XtraEditors.PanelControl
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.grcCha = New DevExpress.XtraEditors.GroupControl
        Me._GridControl = New DevExpress.XtraGrid.GridControl
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NHOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOAI_PHANBO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_BT_PHANBO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MA_TK_PHANBO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_TK_PHANBO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcCon = New DevExpress.XtraEditors.GroupControl
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MA_TK_DICH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_TK_DICH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_KH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_KH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_PHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_PHI = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_CONGTRINH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_CONGTRINH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_VUVIEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_VUVIEC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_HOPDONG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_HOPDONG = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_BPHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_BPHT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KC_TUDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboKC_TUDO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.pcbottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcbottom.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grcCha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcCha.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcCon.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_KH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_PHI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_CONGTRINH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_VUVIEC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_HOPDONG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_BPHT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKC_TUDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbottom
        '
        Me.pcbottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcbottom.Controls.Add(Me.btnClose)
        Me.pcbottom.Controls.Add(Me.btnModify)
        Me.pcbottom.Controls.Add(Me.btnAdd)
        Me.pcbottom.Controls.Add(Me.btnDelete)
        Me.pcbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pcbottom.Location = New System.Drawing.Point(4, 570)
        Me.pcbottom.Name = "pcbottom"
        Me.pcbottom.Size = New System.Drawing.Size(1000, 38)
        Me.pcbottom.TabIndex = 25
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(917, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(89, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(175, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Xóa"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grcCha)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grcCon)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 566)
        Me.SplitContainerControl1.SplitterPosition = 227
        Me.SplitContainerControl1.TabIndex = 27
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grcCha
        '
        Me.grcCha.Controls.Add(Me._GridControl)
        Me.grcCha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCha.Location = New System.Drawing.Point(0, 0)
        Me.grcCha.Name = "grcCha"
        Me.grcCha.Size = New System.Drawing.Size(1000, 227)
        Me.grcCha.TabIndex = 24
        Me.grcCha.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 20)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.Size = New System.Drawing.Size(996, 205)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me._GridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.Empty.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.EvenRow.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.Options.UseBorderColor = True
        Me._GridView.Appearance.EvenRow.Options.UseForeColor = True
        Me._GridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me._GridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FilterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.FixedLine.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.Options.UseForeColor = True
        Me._GridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me._GridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedRow.Options.UseForeColor = True
        Me._GridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.Options.UseBackColor = True
        Me._GridView.Appearance.GroupButton.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupFooter.Options.UseBackColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseForeColor = True
        Me._GridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupPanel.Options.UseBackColor = True
        Me._GridView.Appearance.GroupPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupRow.Options.UseBackColor = True
        Me._GridView.Appearance.GroupRow.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupRow.Options.UseForeColor = True
        Me._GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me._GridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me._GridView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me._GridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.HorzLine.Options.UseBackColor = True
        Me._GridView.Appearance.HorzLine.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.OddRow.Options.UseBackColor = True
        Me._GridView.Appearance.OddRow.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.Options.UseForeColor = True
        Me._GridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me._GridView.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me._GridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.Preview.Options.UseBackColor = True
        Me._GridView.Appearance.Preview.Options.UseFont = True
        Me._GridView.Appearance.Preview.Options.UseForeColor = True
        Me._GridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.Row.Options.UseBackColor = True
        Me._GridView.Appearance.Row.Options.UseForeColor = True
        Me._GridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.RowSeparator.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me._GridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.SelectedRow.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.Options.UseForeColor = True
        Me._GridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.TopNewRow.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.VertLine.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.Options.UseBorderColor = True
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NHOM, Me.LOAI_PHANBO, Me.TEN_BT_PHANBO, Me.MA_TK_PHANBO, Me.TEN_TK_PHANBO, Me.GridColumn1})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsView.EnableAppearanceEvenRow = True
        Me._GridView.OptionsView.EnableAppearanceOddRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'NHOM
        '
        Me.NHOM.Caption = "Nhóm"
        Me.NHOM.FieldName = "Nhom"
        Me.NHOM.Name = "NHOM"
        Me.NHOM.OptionsColumn.AllowEdit = False
        Me.NHOM.OptionsColumn.FixedWidth = True
        Me.NHOM.Visible = True
        Me.NHOM.VisibleIndex = 0
        '
        'LOAI_PHANBO
        '
        Me.LOAI_PHANBO.Caption = "Loại kết chuyển"
        Me.LOAI_PHANBO.FieldName = "LoaiPhanbo"
        Me.LOAI_PHANBO.Name = "LOAI_PHANBO"
        Me.LOAI_PHANBO.OptionsColumn.FixedWidth = True
        Me.LOAI_PHANBO.Visible = True
        Me.LOAI_PHANBO.VisibleIndex = 1
        Me.LOAI_PHANBO.Width = 144
        '
        'TEN_BT_PHANBO
        '
        Me.TEN_BT_PHANBO.Caption = "Tên bút toán phân bổ"
        Me.TEN_BT_PHANBO.FieldName = "TenBtPhanbo"
        Me.TEN_BT_PHANBO.Name = "TEN_BT_PHANBO"
        Me.TEN_BT_PHANBO.OptionsColumn.AllowEdit = False
        Me.TEN_BT_PHANBO.OptionsColumn.FixedWidth = True
        Me.TEN_BT_PHANBO.Visible = True
        Me.TEN_BT_PHANBO.VisibleIndex = 2
        Me.TEN_BT_PHANBO.Width = 207
        '
        'MA_TK_PHANBO
        '
        Me.MA_TK_PHANBO.Caption = "Mã tài khoản phân bổ"
        Me.MA_TK_PHANBO.FieldName = "MaTkPhanbo"
        Me.MA_TK_PHANBO.Name = "MA_TK_PHANBO"
        Me.MA_TK_PHANBO.OptionsColumn.AllowEdit = False
        Me.MA_TK_PHANBO.OptionsColumn.FixedWidth = True
        Me.MA_TK_PHANBO.Visible = True
        Me.MA_TK_PHANBO.VisibleIndex = 3
        Me.MA_TK_PHANBO.Width = 131
        '
        'TEN_TK_PHANBO
        '
        Me.TEN_TK_PHANBO.Caption = "Tài khoản phân bổ"
        Me.TEN_TK_PHANBO.FieldName = "TenTkPhanbo"
        Me.TEN_TK_PHANBO.Name = "TEN_TK_PHANBO"
        Me.TEN_TK_PHANBO.OptionsColumn.AllowEdit = False
        Me.TEN_TK_PHANBO.OptionsColumn.FixedWidth = True
        Me.TEN_TK_PHANBO.Visible = True
        Me.TEN_TK_PHANBO.VisibleIndex = 4
        Me.TEN_TK_PHANBO.Width = 681
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 20
        '
        'grcCon
        '
        Me.grcCon.Controls.Add(Me.gridControl1)
        Me.grcCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCon.Location = New System.Drawing.Point(0, 0)
        Me.grcCon.Name = "grcCon"
        Me.grcCon.Size = New System.Drawing.Size(1000, 333)
        Me.grcCon.TabIndex = 25
        Me.grcCon.Text = "Danh sách..."
        '
        'gridControl1
        '
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.Location = New System.Drawing.Point(2, 20)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboKC_KH, Me.cboKC_PHI, Me.cboKC_CONGTRINH, Me.cboKC_HOPDONG, Me.cboKC_BPHT, Me.cboKC_TUDO, Me.cboKC_VUVIEC})
        Me.gridControl1.Size = New System.Drawing.Size(996, 311)
        Me.gridControl1.TabIndex = 1
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gridView1.Appearance.Empty.Options.UseBackColor = True
        Me.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.gridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.gridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.gridView1.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.gridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gridView1.Appearance.Preview.Options.UseBackColor = True
        Me.gridView1.Appearance.Preview.Options.UseFont = True
        Me.gridView1.Appearance.Preview.Options.UseForeColor = True
        Me.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.Row.Options.UseBackColor = True
        Me.gridView1.Appearance.Row.Options.UseForeColor = True
        Me.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.gridView1.Appearance.VertLine.Options.UseBorderColor = True
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TK_DICH, Me.TEN_TK_DICH, Me.KC_KH, Me.KC_PHI, Me.KC_CONGTRINH, Me.KC_VUVIEC, Me.KC_HOPDONG, Me.KC_BPHT, Me.KC_TUDO})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.EnableAppearanceOddRow = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'MA_TK_DICH
        '
        Me.MA_TK_DICH.Caption = "Mã tài khoản đích"
        Me.MA_TK_DICH.FieldName = "MaTkDich"
        Me.MA_TK_DICH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.MA_TK_DICH.Name = "MA_TK_DICH"
        Me.MA_TK_DICH.OptionsColumn.AllowEdit = False
        Me.MA_TK_DICH.Visible = True
        Me.MA_TK_DICH.VisibleIndex = 0
        Me.MA_TK_DICH.Width = 135
        '
        'TEN_TK_DICH
        '
        Me.TEN_TK_DICH.Caption = "Tên tài khoản đích"
        Me.TEN_TK_DICH.FieldName = "TenTkDich"
        Me.TEN_TK_DICH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.TEN_TK_DICH.Name = "TEN_TK_DICH"
        Me.TEN_TK_DICH.OptionsColumn.AllowEdit = False
        Me.TEN_TK_DICH.Visible = True
        Me.TEN_TK_DICH.VisibleIndex = 1
        Me.TEN_TK_DICH.Width = 242
        '
        'KC_KH
        '
        Me.KC_KH.Caption = "Phân bổ theo khách hàng"
        Me.KC_KH.ColumnEdit = Me.cboKC_KH
        Me.KC_KH.FieldName = "KcKh"
        Me.KC_KH.Name = "KC_KH"
        Me.KC_KH.OptionsColumn.AllowEdit = False
        Me.KC_KH.Visible = True
        Me.KC_KH.VisibleIndex = 2
        Me.KC_KH.Width = 208
        '
        'cboKC_KH
        '
        Me.cboKC_KH.AutoHeight = False
        Me.cboKC_KH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_KH.Name = "cboKC_KH"
        Me.cboKC_KH.NullText = ""
        '
        'KC_PHI
        '
        Me.KC_PHI.Caption = "Phân bổ theo khoản phí"
        Me.KC_PHI.ColumnEdit = Me.cboKC_PHI
        Me.KC_PHI.FieldName = "KcPhi"
        Me.KC_PHI.Name = "KC_PHI"
        Me.KC_PHI.OptionsColumn.AllowEdit = False
        Me.KC_PHI.Visible = True
        Me.KC_PHI.VisibleIndex = 3
        Me.KC_PHI.Width = 174
        '
        'cboKC_PHI
        '
        Me.cboKC_PHI.AutoHeight = False
        Me.cboKC_PHI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_PHI.Name = "cboKC_PHI"
        Me.cboKC_PHI.NullText = ""
        '
        'KC_CONGTRINH
        '
        Me.KC_CONGTRINH.Caption = "Phân bổ theo công trình"
        Me.KC_CONGTRINH.ColumnEdit = Me.cboKC_CONGTRINH
        Me.KC_CONGTRINH.FieldName = "KcCongtrinh"
        Me.KC_CONGTRINH.Name = "KC_CONGTRINH"
        Me.KC_CONGTRINH.OptionsColumn.AllowEdit = False
        Me.KC_CONGTRINH.Visible = True
        Me.KC_CONGTRINH.VisibleIndex = 4
        Me.KC_CONGTRINH.Width = 167
        '
        'cboKC_CONGTRINH
        '
        Me.cboKC_CONGTRINH.AutoHeight = False
        Me.cboKC_CONGTRINH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_CONGTRINH.Name = "cboKC_CONGTRINH"
        Me.cboKC_CONGTRINH.NullText = ""
        '
        'KC_VUVIEC
        '
        Me.KC_VUVIEC.Caption = "Phân bổ theo vụ việc"
        Me.KC_VUVIEC.ColumnEdit = Me.cboKC_VUVIEC
        Me.KC_VUVIEC.FieldName = "KcVuviec"
        Me.KC_VUVIEC.Name = "KC_VUVIEC"
        Me.KC_VUVIEC.OptionsColumn.AllowEdit = False
        Me.KC_VUVIEC.Visible = True
        Me.KC_VUVIEC.VisibleIndex = 5
        Me.KC_VUVIEC.Width = 160
        '
        'cboKC_VUVIEC
        '
        Me.cboKC_VUVIEC.AutoHeight = False
        Me.cboKC_VUVIEC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_VUVIEC.Name = "cboKC_VUVIEC"
        Me.cboKC_VUVIEC.NullText = ""
        '
        'KC_HOPDONG
        '
        Me.KC_HOPDONG.Caption = "Phân bổ theo hợp  đồng"
        Me.KC_HOPDONG.ColumnEdit = Me.cboKC_HOPDONG
        Me.KC_HOPDONG.FieldName = "KcHopdong"
        Me.KC_HOPDONG.Name = "KC_HOPDONG"
        Me.KC_HOPDONG.OptionsColumn.AllowEdit = False
        Me.KC_HOPDONG.Visible = True
        Me.KC_HOPDONG.VisibleIndex = 6
        Me.KC_HOPDONG.Width = 208
        '
        'cboKC_HOPDONG
        '
        Me.cboKC_HOPDONG.AutoHeight = False
        Me.cboKC_HOPDONG.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_HOPDONG.Name = "cboKC_HOPDONG"
        Me.cboKC_HOPDONG.NullText = ""
        '
        'KC_BPHT
        '
        Me.KC_BPHT.Caption = "Phân bổ theo BPHT"
        Me.KC_BPHT.ColumnEdit = Me.cboKC_BPHT
        Me.KC_BPHT.FieldName = "KcBpht"
        Me.KC_BPHT.Name = "KC_BPHT"
        Me.KC_BPHT.OptionsColumn.AllowEdit = False
        Me.KC_BPHT.Visible = True
        Me.KC_BPHT.VisibleIndex = 7
        Me.KC_BPHT.Width = 215
        '
        'cboKC_BPHT
        '
        Me.cboKC_BPHT.AutoHeight = False
        Me.cboKC_BPHT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_BPHT.Name = "cboKC_BPHT"
        Me.cboKC_BPHT.NullText = ""
        '
        'KC_TUDO
        '
        Me.KC_TUDO.Caption = "Phân bổ theo danh mục tự do"
        Me.KC_TUDO.ColumnEdit = Me.cboKC_TUDO
        Me.KC_TUDO.FieldName = "KcTudo"
        Me.KC_TUDO.Name = "KC_TUDO"
        Me.KC_TUDO.OptionsColumn.AllowEdit = False
        Me.KC_TUDO.Visible = True
        Me.KC_TUDO.VisibleIndex = 8
        Me.KC_TUDO.Width = 207
        '
        'cboKC_TUDO
        '
        Me.cboKC_TUDO.AutoHeight = False
        Me.cboKC_TUDO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKC_TUDO.Name = "cboKC_TUDO"
        Me.cboKC_TUDO.NullText = ""
        '
        'frmKhaiBaoCacButToanPBTD_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.pcbottom)
        Me.KeyPreview = True
        Me.Name = "frmKhaiBaoCacButToanPBTD_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khai báo bút toán phân bổ tự động"
        CType(Me.pcbottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcbottom.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grcCha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcCha.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcCon.ResumeLayout(False)
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_KH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_PHI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_CONGTRINH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_VUVIEC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_HOPDONG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_BPHT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKC_TUDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grcCha As DevExpress.XtraEditors.GroupControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NHOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_BT_PHANBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_PHANBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TK_PHANBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcCon As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TK_DICH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TK_DICH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_KH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_PHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_PHI As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_CONGTRINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_CONGTRINH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_VUVIEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_VUVIEC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_HOPDONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_HOPDONG As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_BPHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_BPHT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KC_TUDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKC_TUDO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOAI_PHANBO As DevExpress.XtraGrid.Columns.GridColumn
End Class
