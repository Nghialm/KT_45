<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class In_The_TSCD
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
        Me.grcTSCD = New DevExpress.XtraGrid.GridControl()
        Me.grvTSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_LOAITAISAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_MUA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_KTKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_NAM_SD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkChon = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txttenLoaiTS = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenTS = New DevExpress.XtraEditors.TextEdit()
        Me.dteDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dteTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.grlLoaiTSCD = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txttenLoaiTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLoaiTSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcTSCD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 116)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(887, 369)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách tài sản cố định"
        '
        'grcTSCD
        '
        Me.grcTSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcTSCD.Location = New System.Drawing.Point(2, 22)
        Me.grcTSCD.MainView = Me.grvTSCD
        Me.grcTSCD.Name = "grcTSCD"
        Me.grcTSCD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkChon})
        Me.grcTSCD.Size = New System.Drawing.Size(883, 345)
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
        Me.grvTSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TSCD, Me.TEN_TSCD, Me.KY_HIEU, Me.TEN_LOAITAISAN, Me.NGAY_MUA, Me.NGAY_BDSD, Me.NGAY_BDKH, Me.NGAY_KTKH, Me.SO_NAM_SD})
        Me.grvTSCD.GridControl = Me.grcTSCD
        Me.grvTSCD.Name = "grvTSCD"
        Me.grvTSCD.OptionsView.ColumnAutoWidth = False
        Me.grvTSCD.OptionsView.EnableAppearanceEvenRow = True
        Me.grvTSCD.OptionsView.EnableAppearanceOddRow = True
        Me.grvTSCD.OptionsView.ShowGroupPanel = False
        '
        'MA_TSCD
        '
        Me.MA_TSCD.Caption = "Mã TSCD"
        Me.MA_TSCD.FieldName = "MaTscd"
        Me.MA_TSCD.Name = "MA_TSCD"
        Me.MA_TSCD.OptionsColumn.ReadOnly = True
        Me.MA_TSCD.Visible = True
        Me.MA_TSCD.VisibleIndex = 0
        Me.MA_TSCD.Width = 145
        '
        'TEN_TSCD
        '
        Me.TEN_TSCD.Caption = "Tên TSCD"
        Me.TEN_TSCD.FieldName = "TenTscd"
        Me.TEN_TSCD.Name = "TEN_TSCD"
        Me.TEN_TSCD.OptionsColumn.ReadOnly = True
        Me.TEN_TSCD.Visible = True
        Me.TEN_TSCD.VisibleIndex = 1
        Me.TEN_TSCD.Width = 191
        '
        'KY_HIEU
        '
        Me.KY_HIEU.Caption = "Ký hiệu"
        Me.KY_HIEU.FieldName = "KyHieu"
        Me.KY_HIEU.Name = "KY_HIEU"
        Me.KY_HIEU.OptionsColumn.ReadOnly = True
        Me.KY_HIEU.Visible = True
        Me.KY_HIEU.VisibleIndex = 2
        Me.KY_HIEU.Width = 150
        '
        'TEN_LOAITAISAN
        '
        Me.TEN_LOAITAISAN.Caption = "Tên loại TSCD"
        Me.TEN_LOAITAISAN.FieldName = "TenLoaitaisan"
        Me.TEN_LOAITAISAN.Name = "TEN_LOAITAISAN"
        Me.TEN_LOAITAISAN.OptionsColumn.ReadOnly = True
        Me.TEN_LOAITAISAN.Visible = True
        Me.TEN_LOAITAISAN.VisibleIndex = 3
        Me.TEN_LOAITAISAN.Width = 187
        '
        'NGAY_MUA
        '
        Me.NGAY_MUA.Caption = "Ngày mua"
        Me.NGAY_MUA.FieldName = "NgayMua"
        Me.NGAY_MUA.Name = "NGAY_MUA"
        Me.NGAY_MUA.OptionsColumn.AllowEdit = False
        Me.NGAY_MUA.OptionsColumn.ReadOnly = True
        Me.NGAY_MUA.Visible = True
        Me.NGAY_MUA.VisibleIndex = 4
        Me.NGAY_MUA.Width = 122
        '
        'NGAY_BDSD
        '
        Me.NGAY_BDSD.Caption = "Ngày bắt đầu sử dụng"
        Me.NGAY_BDSD.FieldName = "NgayBdsd"
        Me.NGAY_BDSD.Name = "NGAY_BDSD"
        Me.NGAY_BDSD.OptionsColumn.AllowEdit = False
        Me.NGAY_BDSD.OptionsColumn.ReadOnly = True
        Me.NGAY_BDSD.Visible = True
        Me.NGAY_BDSD.VisibleIndex = 5
        Me.NGAY_BDSD.Width = 167
        '
        'NGAY_BDKH
        '
        Me.NGAY_BDKH.Caption = "Ngày bắt đầu khấu hao"
        Me.NGAY_BDKH.FieldName = "NgayBdkh"
        Me.NGAY_BDKH.Name = "NGAY_BDKH"
        Me.NGAY_BDKH.OptionsColumn.AllowEdit = False
        Me.NGAY_BDKH.OptionsColumn.ReadOnly = True
        Me.NGAY_BDKH.Visible = True
        Me.NGAY_BDKH.VisibleIndex = 6
        Me.NGAY_BDKH.Width = 147
        '
        'NGAY_KTKH
        '
        Me.NGAY_KTKH.Caption = "Ngày kết thúc khấu hao"
        Me.NGAY_KTKH.FieldName = "NgayKtkh"
        Me.NGAY_KTKH.Name = "NGAY_KTKH"
        Me.NGAY_KTKH.OptionsColumn.AllowEdit = False
        Me.NGAY_KTKH.OptionsColumn.ReadOnly = True
        Me.NGAY_KTKH.Visible = True
        Me.NGAY_KTKH.VisibleIndex = 7
        Me.NGAY_KTKH.Width = 167
        '
        'SO_NAM_SD
        '
        Me.SO_NAM_SD.Caption = "Số tháng sử dụng"
        Me.SO_NAM_SD.FieldName = "SoThangSd"
        Me.SO_NAM_SD.Name = "SO_NAM_SD"
        Me.SO_NAM_SD.OptionsColumn.ReadOnly = True
        Me.SO_NAM_SD.Visible = True
        Me.SO_NAM_SD.VisibleIndex = 8
        Me.SO_NAM_SD.Width = 172
        '
        'chkChon
        '
        Me.chkChon.AutoHeight = False
        Me.chkChon.Name = "chkChon"
        Me.chkChon.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.chkChon.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Controls.Add(Me.btnPrint)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 485)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(887, 34)
        Me.PanelControl1.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(807, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "&Quay ra"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(0, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "&In"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txttenLoaiTS)
        Me.GroupControl2.Controls.Add(Me.txtTenTS)
        Me.GroupControl2.Controls.Add(Me.dteDenNgay)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.dteTuNgay)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.btnSearch)
        Me.GroupControl2.Controls.Add(Me.grlLoaiTSCD)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(887, 108)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Tìm kiếm"
        '
        'txttenLoaiTS
        '
        Me.txttenLoaiTS.Location = New System.Drawing.Point(182, 55)
        Me.txttenLoaiTS.Name = "txttenLoaiTS"
        Me.txttenLoaiTS.Properties.ReadOnly = True
        Me.txttenLoaiTS.Size = New System.Drawing.Size(172, 20)
        Me.txttenLoaiTS.TabIndex = 3
        Me.txttenLoaiTS.TabStop = False
        '
        'txtTenTS
        '
        Me.txtTenTS.EnterMoveNextControl = True
        Me.txtTenTS.Location = New System.Drawing.Point(76, 79)
        Me.txtTenTS.Name = "txtTenTS"
        Me.txtTenTS.Size = New System.Drawing.Size(278, 20)
        Me.txtTenTS.TabIndex = 4
        '
        'dteDenNgay
        '
        Me.dteDenNgay.EditValue = Nothing
        Me.dteDenNgay.EnterMoveNextControl = True
        Me.dteDenNgay.Location = New System.Drawing.Point(254, 29)
        Me.dteDenNgay.Name = "dteDenNgay"
        Me.dteDenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteDenNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteDenNgay.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteDenNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteDenNgay.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(195, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Đến ngày"
        '
        'dteTuNgay
        '
        Me.dteTuNgay.EditValue = Nothing
        Me.dteTuNgay.EnterMoveNextControl = True
        Me.dteTuNgay.Location = New System.Drawing.Point(76, 29)
        Me.dteTuNgay.Name = "dteTuNgay"
        Me.dteTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteTuNgay.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteTuNgay.Size = New System.Drawing.Size(100, 20)
        Me.dteTuNgay.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Từ ngày"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(360, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Tìm kiếm"
        '
        'grlLoaiTSCD
        '
        Me.grlLoaiTSCD.EnterMoveNextControl = True
        Me.grlLoaiTSCD.Location = New System.Drawing.Point(76, 55)
        Me.grlLoaiTSCD.Name = "grlLoaiTSCD"
        Me.grlLoaiTSCD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlLoaiTSCD.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlLoaiTSCD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLoaiTSCD.Properties.ImmediatePopup = True
        Me.grlLoaiTSCD.Properties.NullText = ""
        Me.grlLoaiTSCD.Properties.View = Me.GridView2
        Me.grlLoaiTSCD.Size = New System.Drawing.Size(100, 20)
        Me.grlLoaiTSCD.TabIndex = 2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Loại TSCD"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên TSCD"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(4, 112)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(887, 4)
        Me.PanelControl2.TabIndex = 3
        '
        'In_The_TSCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 523)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "In_The_TSCD"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In thẻ tài sản cố định"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grcTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvTSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txttenLoaiTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLoaiTSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcTSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvTSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_LOAITAISAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_MUA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_KTKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NAM_SD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkChon As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grlLoaiTSCD As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dteDenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteTuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttenLoaiTS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenTS As DevExpress.XtraEditors.TextEdit
End Class
