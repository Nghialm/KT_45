<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuKeToanKhac2_DanhSach
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
        Me.cboVuviecNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TY_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIEN_GIAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CtlPagerControl = New Vns.Erp.Core.Common.Controls.PagerControl()
        Me.ID_DM_VUVIEC_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_DM_PTQT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPTQTNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_VUVIEC_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOI_DUNG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TK_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_TK_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_KHANG_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_KHANG_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU_VUVIEC_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_DM_VUVIEC_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuviecCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_PTQT_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPTQTCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.cboVuviecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboPTQTNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuviecCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQTCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboVuviecNo
        '
        Me.cboVuviecNo.AutoHeight = False
        Me.cboVuviecNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuviecNo.Name = "cboVuviecNo"
        Me.cboVuviecNo.NullText = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 404)
        Me.GroupControl1.TabIndex = 22
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 22)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.Size = New System.Drawing.Size(996, 340)
        Me._GridControl.TabIndex = 2
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
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GHI, Me.NGAY_CT, Me.CT_SO, Me.grv1_SO_TIEN, Me.MA_NTE, Me.TY_GIA, Me.grv1_KY_HIEU_KHANG, Me.grv1_TEN_KHANG, Me.DIEN_GIAI})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsBehavior.Editable = False
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.EnableAppearanceEvenRow = True
        Me._GridView.OptionsView.EnableAppearanceOddRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'GHI
        '
        Me.GHI.Caption = "Trạng thái"
        Me.GHI.FieldName = "Ghi"
        Me.GHI.Name = "GHI"
        Me.GHI.Visible = True
        Me.GHI.VisibleIndex = 0
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày chứng từ"
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.OptionsColumn.FixedWidth = True
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 2
        Me.NGAY_CT.Width = 100
        '
        'CT_SO
        '
        Me.CT_SO.AppearanceCell.Options.UseTextOptions = True
        Me.CT_SO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CT_SO.Caption = "Số chứng từ"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.OptionsColumn.FixedWidth = True
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 1
        Me.CT_SO.Width = 100
        '
        'grv1_SO_TIEN
        '
        Me.grv1_SO_TIEN.Caption = "Số tiền"
        Me.grv1_SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.grv1_SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grv1_SO_TIEN.FieldName = "SoTien"
        Me.grv1_SO_TIEN.Name = "grv1_SO_TIEN"
        Me.grv1_SO_TIEN.Visible = True
        Me.grv1_SO_TIEN.VisibleIndex = 3
        Me.grv1_SO_TIEN.Width = 100
        '
        'MA_NTE
        '
        Me.MA_NTE.Caption = "Mã NT"
        Me.MA_NTE.FieldName = "MaNte"
        Me.MA_NTE.Name = "MA_NTE"
        Me.MA_NTE.Visible = True
        Me.MA_NTE.VisibleIndex = 4
        Me.MA_NTE.Width = 50
        '
        'TY_GIA
        '
        Me.TY_GIA.Caption = "Tỷ giá"
        Me.TY_GIA.DisplayFormat.FormatString = "n0"
        Me.TY_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TY_GIA.FieldName = "TyGia"
        Me.TY_GIA.Name = "TY_GIA"
        Me.TY_GIA.OptionsColumn.FixedWidth = True
        Me.TY_GIA.Visible = True
        Me.TY_GIA.VisibleIndex = 5
        Me.TY_GIA.Width = 100
        '
        'grv1_KY_HIEU_KHANG
        '
        Me.grv1_KY_HIEU_KHANG.Caption = "Mã khách hàng"
        Me.grv1_KY_HIEU_KHANG.FieldName = "KyHieuKhang"
        Me.grv1_KY_HIEU_KHANG.Name = "grv1_KY_HIEU_KHANG"
        Me.grv1_KY_HIEU_KHANG.Width = 104
        '
        'grv1_TEN_KHANG
        '
        Me.grv1_TEN_KHANG.Caption = "Tên khách hàng"
        Me.grv1_TEN_KHANG.FieldName = "TenKhang"
        Me.grv1_TEN_KHANG.Name = "grv1_TEN_KHANG"
        Me.grv1_TEN_KHANG.Width = 144
        '
        'DIEN_GIAI
        '
        Me.DIEN_GIAI.Caption = "Diễn giải"
        Me.DIEN_GIAI.FieldName = "DienGiai"
        Me.DIEN_GIAI.Name = "DIEN_GIAI"
        Me.DIEN_GIAI.Visible = True
        Me.DIEN_GIAI.VisibleIndex = 6
        Me.DIEN_GIAI.Width = 418
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CtlPagerControl)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 362)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 40)
        Me.PanelControl1.TabIndex = 1
        '
        'CtlPagerControl
        '
        Me.CtlPagerControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.CtlPagerControl.Location = New System.Drawing.Point(512, 2)
        Me.CtlPagerControl.Name = "CtlPagerControl"
        Me.CtlPagerControl.PageIndex = 1
        Me.CtlPagerControl.PageSize = 10
        Me.CtlPagerControl.Size = New System.Drawing.Size(482, 36)
        Me.CtlPagerControl.TabIndex = 0
        Me.CtlPagerControl.TotalPage = 0
        Me.CtlPagerControl.TotalResult = 0
        '
        'ID_DM_VUVIEC_NO
        '
        Me.ID_DM_VUVIEC_NO.Caption = "Tên vụ việc"
        Me.ID_DM_VUVIEC_NO.ColumnEdit = Me.cboVuviecNo
        Me.ID_DM_VUVIEC_NO.FieldName = "IdDmVuviecNo"
        Me.ID_DM_VUVIEC_NO.Name = "ID_DM_VUVIEC_NO"
        Me.ID_DM_VUVIEC_NO.Visible = True
        Me.ID_DM_VUVIEC_NO.VisibleIndex = 7
        Me.ID_DM_VUVIEC_NO.Width = 141
        '
        'ID_DM_PTQT_NO
        '
        Me.ID_DM_PTQT_NO.Caption = "Loại dòng tiền"
        Me.ID_DM_PTQT_NO.ColumnEdit = Me.cboPTQTNo
        Me.ID_DM_PTQT_NO.FieldName = "IdDmPtqtNo"
        Me.ID_DM_PTQT_NO.Name = "ID_DM_PTQT_NO"
        Me.ID_DM_PTQT_NO.Visible = True
        Me.ID_DM_PTQT_NO.VisibleIndex = 8
        Me.ID_DM_PTQT_NO.Width = 106
        '
        'cboPTQTNo
        '
        Me.cboPTQTNo.AutoHeight = False
        Me.cboPTQTNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQTNo.Name = "cboPTQTNo"
        Me.cboPTQTNo.NullText = ""
        '
        'SO_TIEN
        '
        Me.SO_TIEN.Caption = "Số tiền"
        Me.SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SO_TIEN.FieldName = "SoTien"
        Me.SO_TIEN.Name = "SO_TIEN"
        Me.SO_TIEN.Visible = True
        Me.SO_TIEN.VisibleIndex = 4
        Me.SO_TIEN.Width = 100
        '
        'KY_HIEU_VUVIEC_NO
        '
        Me.KY_HIEU_VUVIEC_NO.Caption = "Mã vụ việc"
        Me.KY_HIEU_VUVIEC_NO.FieldName = "KyHieuVuviecNo"
        Me.KY_HIEU_VUVIEC_NO.Name = "KY_HIEU_VUVIEC_NO"
        Me.KY_HIEU_VUVIEC_NO.Visible = True
        Me.KY_HIEU_VUVIEC_NO.VisibleIndex = 6
        Me.KY_HIEU_VUVIEC_NO.Width = 113
        '
        'NOI_DUNG
        '
        Me.NOI_DUNG.Caption = "Diễn giải"
        Me.NOI_DUNG.FieldName = "NoiDung"
        Me.NOI_DUNG.Name = "NOI_DUNG"
        Me.NOI_DUNG.Visible = True
        Me.NOI_DUNG.VisibleIndex = 5
        Me.NOI_DUNG.Width = 150
        '
        'gridControl1
        '
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.Location = New System.Drawing.Point(2, 22)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboVuviecNo, Me.cboPTQTNo, Me.cboVuviecCo, Me.cboPTQTCo})
        Me.gridControl1.Size = New System.Drawing.Size(996, 138)
        Me.gridControl1.TabIndex = 0
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
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TK_NO, Me.MA_TK_CO, Me.KY_HIEU_KHANG_NO, Me.KY_HIEU_KHANG_CO, Me.SO_TIEN, Me.NOI_DUNG, Me.KY_HIEU_VUVIEC_NO, Me.ID_DM_VUVIEC_NO, Me.ID_DM_PTQT_NO, Me.KY_HIEU_VUVIEC_CO, Me.ID_DM_VUVIEC_CO, Me.ID_DM_PTQT_CO})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsBehavior.Editable = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.EnableAppearanceOddRow = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'MA_TK_NO
        '
        Me.MA_TK_NO.Caption = "TK nợ"
        Me.MA_TK_NO.FieldName = "MaTkNo"
        Me.MA_TK_NO.Name = "MA_TK_NO"
        Me.MA_TK_NO.Visible = True
        Me.MA_TK_NO.VisibleIndex = 0
        '
        'MA_TK_CO
        '
        Me.MA_TK_CO.Caption = "TK có"
        Me.MA_TK_CO.FieldName = "MaTkCo"
        Me.MA_TK_CO.Name = "MA_TK_CO"
        Me.MA_TK_CO.Visible = True
        Me.MA_TK_CO.VisibleIndex = 1
        '
        'KY_HIEU_KHANG_NO
        '
        Me.KY_HIEU_KHANG_NO.Caption = "Khách hàng nợ"
        Me.KY_HIEU_KHANG_NO.FieldName = "TenKhangNo"
        Me.KY_HIEU_KHANG_NO.Name = "KY_HIEU_KHANG_NO"
        Me.KY_HIEU_KHANG_NO.Visible = True
        Me.KY_HIEU_KHANG_NO.VisibleIndex = 2
        Me.KY_HIEU_KHANG_NO.Width = 232
        '
        'KY_HIEU_KHANG_CO
        '
        Me.KY_HIEU_KHANG_CO.Caption = "Khách hàng có"
        Me.KY_HIEU_KHANG_CO.FieldName = "TenKhangCo"
        Me.KY_HIEU_KHANG_CO.Name = "KY_HIEU_KHANG_CO"
        Me.KY_HIEU_KHANG_CO.Visible = True
        Me.KY_HIEU_KHANG_CO.VisibleIndex = 3
        Me.KY_HIEU_KHANG_CO.Width = 245
        '
        'KY_HIEU_VUVIEC_CO
        '
        Me.KY_HIEU_VUVIEC_CO.Caption = "Mã vụ việc"
        Me.KY_HIEU_VUVIEC_CO.FieldName = "KyHieuVuviecCo"
        Me.KY_HIEU_VUVIEC_CO.Name = "KY_HIEU_VUVIEC_CO"
        Me.KY_HIEU_VUVIEC_CO.Width = 90
        '
        'ID_DM_VUVIEC_CO
        '
        Me.ID_DM_VUVIEC_CO.Caption = "Tên vụ việc"
        Me.ID_DM_VUVIEC_CO.ColumnEdit = Me.cboVuviecCo
        Me.ID_DM_VUVIEC_CO.FieldName = "IdDmVuviecCo"
        Me.ID_DM_VUVIEC_CO.Name = "ID_DM_VUVIEC_CO"
        Me.ID_DM_VUVIEC_CO.Width = 97
        '
        'cboVuviecCo
        '
        Me.cboVuviecCo.AutoHeight = False
        Me.cboVuviecCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuviecCo.Name = "cboVuviecCo"
        Me.cboVuviecCo.NullText = ""
        '
        'ID_DM_PTQT_CO
        '
        Me.ID_DM_PTQT_CO.Caption = "Loại dòng tiền"
        Me.ID_DM_PTQT_CO.ColumnEdit = Me.cboPTQTCo
        Me.ID_DM_PTQT_CO.FieldName = "IdDmPtqtCo"
        Me.ID_DM_PTQT_CO.Name = "ID_DM_PTQT_CO"
        Me.ID_DM_PTQT_CO.Width = 93
        '
        'cboPTQTCo
        '
        Me.cboPTQTCo.AutoHeight = False
        Me.cboPTQTCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQTCo.Name = "cboPTQTCo"
        Me.cboPTQTCo.NullText = ""
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.gridControl1)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupControl2.Location = New System.Drawing.Point(0, 0)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Size = New System.Drawing.Size(1000, 162)
        Me.groupControl2.TabIndex = 23
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(919, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnModify)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 34)
        Me.PanelControl2.TabIndex = 26
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 5
        Me.btnAdd.Location = New System.Drawing.Point(0, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Thêm"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(86, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "Sửa"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(172, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.Visible = False
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 570)
        Me.SplitContainer1.SplitterDistance = 404
        Me.SplitContainer1.TabIndex = 27
        '
        'frmPhieuKeToanKhac2_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmPhieuKeToanKhac2_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu kế toán khác 2"
        CType(Me.cboVuviecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cboPTQTNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuviecCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQTCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboVuviecNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ID_DM_VUVIEC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPTQTNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_VUVIEC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboVuviecCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPTQTCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KY_HIEU_KHANG_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU_KHANG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIEN_GIAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CtlPagerControl As Vns.Erp.Core.Common.Controls.PagerControl
End Class
