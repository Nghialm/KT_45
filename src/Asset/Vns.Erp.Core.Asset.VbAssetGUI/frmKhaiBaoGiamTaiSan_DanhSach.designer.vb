<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhaiBaoGiamTaiSan_DanhSach
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GIAM_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grc_TSCD = New DevExpress.XtraGrid.GridControl()
        Me.grv_TSCD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_TSCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_LOAITAISAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_MUA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_BDKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_KTKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_NAM_SD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGiam = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.PagerControl1 = New Vns.Erp.Core.Common.Controls.PagerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grc_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv_TSCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GIAM_TSCD
        '
        Me.GIAM_TSCD.Caption = "Trạng thái"
        Me.GIAM_TSCD.FieldName = "GiamTscd"
        Me.GIAM_TSCD.Name = "GIAM_TSCD"
        Me.GIAM_TSCD.OptionsColumn.FixedWidth = True
        Me.GIAM_TSCD.OptionsColumn.ReadOnly = True
        Me.GIAM_TSCD.Visible = True
        Me.GIAM_TSCD.VisibleIndex = 8
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grc_TSCD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 534)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh sách tài sản cố định"
        '
        'grc_TSCD
        '
        Me.grc_TSCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grc_TSCD.Location = New System.Drawing.Point(2, 22)
        Me.grc_TSCD.MainView = Me.grv_TSCD
        Me.grc_TSCD.Name = "grc_TSCD"
        Me.grc_TSCD.Size = New System.Drawing.Size(1004, 510)
        Me.grc_TSCD.TabIndex = 1
        Me.grc_TSCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grv_TSCD})
        '
        'grv_TSCD
        '
        Me.grv_TSCD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.Empty.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grv_TSCD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grv_TSCD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.EvenRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.EvenRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grv_TSCD.Appearance.FixedLine.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grv_TSCD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grv_TSCD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupButton.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grv_TSCD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.GroupRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.GroupRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grv_TSCD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grv_TSCD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grv_TSCD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grv_TSCD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grv_TSCD.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grv_TSCD.Appearance.HorzLine.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.OddRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.OddRow.Options.UseBorderColor = True
        Me.grv_TSCD.Appearance.OddRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grv_TSCD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grv_TSCD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grv_TSCD.Appearance.Preview.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.Preview.Options.UseFont = True
        Me.grv_TSCD.Appearance.Preview.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.Row.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.Row.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grv_TSCD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grv_TSCD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grv_TSCD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grv_TSCD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grv_TSCD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grv_TSCD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grv_TSCD.Appearance.VertLine.Options.UseBackColor = True
        Me.grv_TSCD.Appearance.VertLine.Options.UseBorderColor = True
        Me.grv_TSCD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TSCD, Me.TEN_TSCD, Me.KY_HIEU, Me.TEN_LOAITAISAN, Me.NGAY_MUA, Me.NGAY_BDKH, Me.NGAY_KTKH, Me.SO_NAM_SD, Me.GIAM_TSCD, Me.GridColumn1})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.GIAM_TSCD
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 1
        StyleFormatCondition1.Value2 = 1
        Me.grv_TSCD.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grv_TSCD.GridControl = Me.grc_TSCD
        Me.grv_TSCD.Name = "grv_TSCD"
        Me.grv_TSCD.OptionsView.EnableAppearanceEvenRow = True
        Me.grv_TSCD.OptionsView.EnableAppearanceOddRow = True
        Me.grv_TSCD.OptionsView.ShowGroupPanel = False
        '
        'MA_TSCD
        '
        Me.MA_TSCD.Caption = "Mã TSCD"
        Me.MA_TSCD.FieldName = "MaTscd"
        Me.MA_TSCD.Name = "MA_TSCD"
        Me.MA_TSCD.OptionsColumn.FixedWidth = True
        Me.MA_TSCD.OptionsColumn.ReadOnly = True
        Me.MA_TSCD.Visible = True
        Me.MA_TSCD.VisibleIndex = 0
        Me.MA_TSCD.Width = 88
        '
        'TEN_TSCD
        '
        Me.TEN_TSCD.Caption = "Tên TSCD"
        Me.TEN_TSCD.FieldName = "TenTscd"
        Me.TEN_TSCD.Name = "TEN_TSCD"
        Me.TEN_TSCD.OptionsColumn.FixedWidth = True
        Me.TEN_TSCD.OptionsColumn.ReadOnly = True
        Me.TEN_TSCD.Visible = True
        Me.TEN_TSCD.VisibleIndex = 2
        Me.TEN_TSCD.Width = 255
        '
        'KY_HIEU
        '
        Me.KY_HIEU.Caption = "Ký hiệu"
        Me.KY_HIEU.FieldName = "KyHieu"
        Me.KY_HIEU.Name = "KY_HIEU"
        Me.KY_HIEU.OptionsColumn.FixedWidth = True
        Me.KY_HIEU.OptionsColumn.ReadOnly = True
        Me.KY_HIEU.Visible = True
        Me.KY_HIEU.VisibleIndex = 1
        Me.KY_HIEU.Width = 193
        '
        'TEN_LOAITAISAN
        '
        Me.TEN_LOAITAISAN.Caption = "Tên loại TSCD"
        Me.TEN_LOAITAISAN.FieldName = "TenLoaitaisan"
        Me.TEN_LOAITAISAN.Name = "TEN_LOAITAISAN"
        Me.TEN_LOAITAISAN.OptionsColumn.FixedWidth = True
        Me.TEN_LOAITAISAN.OptionsColumn.ReadOnly = True
        Me.TEN_LOAITAISAN.Visible = True
        Me.TEN_LOAITAISAN.VisibleIndex = 3
        Me.TEN_LOAITAISAN.Width = 225
        '
        'NGAY_MUA
        '
        Me.NGAY_MUA.Caption = "Ngày mua"
        Me.NGAY_MUA.FieldName = "NgayMua"
        Me.NGAY_MUA.Name = "NGAY_MUA"
        Me.NGAY_MUA.OptionsColumn.FixedWidth = True
        Me.NGAY_MUA.OptionsColumn.ReadOnly = True
        Me.NGAY_MUA.Visible = True
        Me.NGAY_MUA.VisibleIndex = 4
        Me.NGAY_MUA.Width = 114
        '
        'NGAY_BDKH
        '
        Me.NGAY_BDKH.Caption = "Ngày BDKH"
        Me.NGAY_BDKH.FieldName = "NgayBdkh"
        Me.NGAY_BDKH.Name = "NGAY_BDKH"
        Me.NGAY_BDKH.OptionsColumn.FixedWidth = True
        Me.NGAY_BDKH.OptionsColumn.ReadOnly = True
        Me.NGAY_BDKH.Visible = True
        Me.NGAY_BDKH.VisibleIndex = 5
        Me.NGAY_BDKH.Width = 105
        '
        'NGAY_KTKH
        '
        Me.NGAY_KTKH.Caption = "Ngày giảm"
        Me.NGAY_KTKH.FieldName = "NgayKtkh"
        Me.NGAY_KTKH.Name = "NGAY_KTKH"
        Me.NGAY_KTKH.OptionsColumn.FixedWidth = True
        Me.NGAY_KTKH.OptionsColumn.ReadOnly = True
        Me.NGAY_KTKH.Visible = True
        Me.NGAY_KTKH.VisibleIndex = 6
        Me.NGAY_KTKH.Width = 95
        '
        'SO_NAM_SD
        '
        Me.SO_NAM_SD.Caption = "Số năm sử dụng"
        Me.SO_NAM_SD.FieldName = "SoNamSd"
        Me.SO_NAM_SD.Name = "SO_NAM_SD"
        Me.SO_NAM_SD.OptionsColumn.FixedWidth = True
        Me.SO_NAM_SD.OptionsColumn.ReadOnly = True
        Me.SO_NAM_SD.Visible = True
        Me.SO_NAM_SD.VisibleIndex = 7
        Me.SO_NAM_SD.Width = 103
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 20
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnModify)
        Me.PanelControl1.Controls.Add(Me.btnGiam)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 574)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 38)
        Me.PanelControl1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(928, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(89, 7)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 10
        Me.btnModify.Text = "&Sửa"
        '
        'btnGiam
        '
        Me.btnGiam.ImageIndex = 2
        Me.btnGiam.Location = New System.Drawing.Point(3, 7)
        Me.btnGiam.Name = "btnGiam"
        Me.btnGiam.Size = New System.Drawing.Size(80, 30)
        Me.btnGiam.TabIndex = 9
        Me.btnGiam.Text = "&Giảm TS"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(175, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Xóa"
        '
        'PagerControl1
        '
        Me.PagerControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PagerControl1.Location = New System.Drawing.Point(520, 2)
        Me.PagerControl1.Name = "PagerControl1"
        Me.PagerControl1.PageIndex = 1
        Me.PagerControl1.PageSize = 5
        Me.PagerControl1.Size = New System.Drawing.Size(486, 36)
        Me.PagerControl1.TabIndex = 13
        Me.PagerControl1.TotalPage = 0
        Me.PagerControl1.TotalResult = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PagerControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 534)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(1008, 40)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "GroupControl2"
        '
        'frmKhaiBaoGiamTaiSan_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmKhaiBaoGiamTaiSan_DanhSach"
        Me.Text = "Khai báo giảm tài sản"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grc_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv_TSCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGiam As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grc_TSCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents grv_TSCD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_LOAITAISAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_MUA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_BDKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_NAM_SD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIAM_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_KTKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PagerControl1 As Vns.Erp.Core.Common.Controls.PagerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
