<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemHoaDon
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
        Me.ucDateTime = New Vns.Erp.Core.Accounting.Report.DateTimeInput()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoHoaDon = New DevExpress.XtraEditors.TextEdit()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrinter = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NgayHoadon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoHoadon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenKhachhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MaSoThue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DoanhThu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TienThue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TongTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grcLPN_Dnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPN_Dnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ThuTu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenHanghoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DonGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ThanhTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKHO_NHAP_ID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtSoHoaDon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKHO_NHAP_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ucDateTime)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Controls.Add(Me.btnModify)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtSoHoaDon)
        Me.PanelControl1.Controls.Add(Me.btnSea)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Controls.Add(Me.btnPrinter)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1178, 119)
        Me.PanelControl1.TabIndex = 0
        '
        'ucDateTime
        '
        Me.ucDateTime.EndDate = New Date(CType(0, Long))
        Me.ucDateTime.Location = New System.Drawing.Point(47, 4)
        Me.ucDateTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucDateTime.Name = "ucDateTime"
        Me.ucDateTime.Size = New System.Drawing.Size(693, 31)
        Me.ucDateTime.StartDate = New Date(CType(0, Long))
        Me.ucDateTime.TabIndex = 52
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(589, 69)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 37)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.Visible = False
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.Location = New System.Drawing.Point(288, 69)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 37)
        Me.btnModify.TabIndex = 50
        Me.btnModify.Text = "Sửa"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(47, 42)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 17)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "Số hóa đơn"
        '
        'txtSoHoaDon
        '
        Me.txtSoHoaDon.Location = New System.Drawing.Point(188, 39)
        Me.txtSoHoaDon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSoHoaDon.Name = "txtSoHoaDon"
        Me.txtSoHoaDon.Size = New System.Drawing.Size(187, 22)
        Me.txtSoHoaDon.TabIndex = 48
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSea.Location = New System.Drawing.Point(188, 69)
        Me.btnSea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(93, 37)
        Me.btnSea.TabIndex = 47
        Me.btnSea.Text = "Tìm"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(489, 69)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(93, 37)
        Me.btnQuit.TabIndex = 46
        Me.btnQuit.Text = "Hủy bỏ"
        '
        'btnPrinter
        '
        Me.btnPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrinter.Location = New System.Drawing.Point(389, 69)
        Me.btnPrinter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(93, 37)
        Me.btnPrinter.TabIndex = 45
        Me.btnPrinter.Text = "In"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.grcLPN_Hnx)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(5, 124)
        Me.PanelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1178, 477)
        Me.PanelControl5.TabIndex = 2
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 2)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(1174, 473)
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
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NgayHoadon, Me.SoHoadon, Me.TenKhachhang, Me.MaSoThue, Me.DoanhThu, Me.TienThue, Me.TongTien})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'NgayHoadon
        '
        Me.NgayHoadon.Caption = "Ngày hóa đơn"
        Me.NgayHoadon.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayHoadon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayHoadon.FieldName = "NgayHoadon"
        Me.NgayHoadon.Name = "NgayHoadon"
        Me.NgayHoadon.OptionsColumn.ReadOnly = True
        Me.NgayHoadon.Visible = True
        Me.NgayHoadon.VisibleIndex = 0
        Me.NgayHoadon.Width = 100
        '
        'SoHoadon
        '
        Me.SoHoadon.Caption = "Số hóa đơn"
        Me.SoHoadon.FieldName = "SoHoadon"
        Me.SoHoadon.Name = "SoHoadon"
        Me.SoHoadon.OptionsColumn.ReadOnly = True
        Me.SoHoadon.Visible = True
        Me.SoHoadon.VisibleIndex = 1
        Me.SoHoadon.Width = 100
        '
        'TenKhachhang
        '
        Me.TenKhachhang.Caption = "Tên khách hàng"
        Me.TenKhachhang.FieldName = "TenKhachhang"
        Me.TenKhachhang.Name = "TenKhachhang"
        Me.TenKhachhang.Visible = True
        Me.TenKhachhang.VisibleIndex = 2
        Me.TenKhachhang.Width = 216
        '
        'MaSoThue
        '
        Me.MaSoThue.Caption = "Mã số thuế"
        Me.MaSoThue.FieldName = "MaSoThue"
        Me.MaSoThue.Name = "MaSoThue"
        Me.MaSoThue.Visible = True
        Me.MaSoThue.VisibleIndex = 3
        Me.MaSoThue.Width = 120
        '
        'DoanhThu
        '
        Me.DoanhThu.Caption = "Doanh thu"
        Me.DoanhThu.DisplayFormat.FormatString = "n0"
        Me.DoanhThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DoanhThu.FieldName = "DoanhThu"
        Me.DoanhThu.Name = "DoanhThu"
        Me.DoanhThu.OptionsColumn.ReadOnly = True
        Me.DoanhThu.Visible = True
        Me.DoanhThu.VisibleIndex = 4
        Me.DoanhThu.Width = 150
        '
        'TienThue
        '
        Me.TienThue.Caption = "Tiền thuế"
        Me.TienThue.DisplayFormat.FormatString = "n0"
        Me.TienThue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TienThue.FieldName = "TienThue"
        Me.TienThue.Name = "TienThue"
        Me.TienThue.OptionsColumn.ReadOnly = True
        Me.TienThue.Visible = True
        Me.TienThue.VisibleIndex = 5
        Me.TienThue.Width = 100
        '
        'TongTien
        '
        Me.TongTien.Caption = "Tổng tiền"
        Me.TongTien.DisplayFormat.FormatString = "n0"
        Me.TongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TongTien.FieldName = "TongTien"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.OptionsColumn.ReadOnly = True
        Me.TongTien.Visible = True
        Me.TongTien.VisibleIndex = 6
        Me.TongTien.Width = 120
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.grcLPN_Dnx)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(5, 601)
        Me.PanelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1178, 160)
        Me.PanelControl4.TabIndex = 4
        '
        'grcLPN_Dnx
        '
        Me.grcLPN_Dnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Dnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Dnx.Location = New System.Drawing.Point(2, 2)
        Me.grcLPN_Dnx.MainView = Me.grvLPN_Dnx
        Me.grcLPN_Dnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Dnx.Name = "grcLPN_Dnx"
        Me.grcLPN_Dnx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboKHO_NHAP_ID})
        Me.grcLPN_Dnx.Size = New System.Drawing.Size(1174, 156)
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
        Me.grvLPN_Dnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ThuTu, Me.TenHanghoa, Me.TenDvt, Me.SoLuong, Me.DonGia, Me.ThanhTien})
        Me.grvLPN_Dnx.GridControl = Me.grcLPN_Dnx
        Me.grvLPN_Dnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPN_Dnx.Name = "grvLPN_Dnx"
        Me.grvLPN_Dnx.OptionsBehavior.Editable = False
        Me.grvLPN_Dnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPN_Dnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPN_Dnx.OptionsView.ShowGroupPanel = False
        '
        'ThuTu
        '
        Me.ThuTu.Caption = "Thứ tự"
        Me.ThuTu.FieldName = "SoThuTu"
        Me.ThuTu.Name = "ThuTu"
        Me.ThuTu.Visible = True
        Me.ThuTu.VisibleIndex = 0
        '
        'TenHanghoa
        '
        Me.TenHanghoa.Caption = "Tên hàng hóa, dịch vụ"
        Me.TenHanghoa.FieldName = "TenHanghoa"
        Me.TenHanghoa.Name = "TenHanghoa"
        Me.TenHanghoa.Visible = True
        Me.TenHanghoa.VisibleIndex = 1
        Me.TenHanghoa.Width = 230
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
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.DisplayFormat.FormatString = "n2"
        Me.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.OptionsColumn.ReadOnly = True
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 3
        Me.SoLuong.Width = 100
        '
        'DonGia
        '
        Me.DonGia.Caption = "Đơn giá"
        Me.DonGia.DisplayFormat.FormatString = "n0"
        Me.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGia.FieldName = "DonGia"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.OptionsColumn.ReadOnly = True
        Me.DonGia.Visible = True
        Me.DonGia.VisibleIndex = 4
        Me.DonGia.Width = 100
        '
        'ThanhTien
        '
        Me.ThanhTien.Caption = "Thành tiền"
        Me.ThanhTien.DisplayFormat.FormatString = "n0"
        Me.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ThanhTien.FieldName = "DoanhSo"
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.Visible = True
        Me.ThanhTien.VisibleIndex = 5
        '
        'cboKHO_NHAP_ID
        '
        Me.cboKHO_NHAP_ID.AutoHeight = False
        Me.cboKHO_NHAP_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHO_NHAP_ID.Name = "cboKHO_NHAP_ID"
        Me.cboKHO_NHAP_ID.NullText = ""
        '
        'frmTimKiemHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 766)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemHoaDon"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm chứng từ - Kho"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtSoHoaDon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.grcLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPN_Dnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKHO_NHAP_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NgayHoadon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoHoadon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenKhachhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaSoThue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DoanhThu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TienThue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TongTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcLPN_Dnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPN_Dnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TenHanghoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenDvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ThanhTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKHO_NHAP_ID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrinter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoHoaDon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ThuTu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ucDateTime As Vns.Erp.Core.Accounting.Report.DateTimeInput
End Class
