<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoView))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
        Me.pcOption = New DevExpress.XtraEditors.PanelControl()
        Me.cboCheckVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.popDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.popRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.popClose = New DevExpress.XtraBars.BarButtonItem()
        Me.lblMau = New DevExpress.XtraEditors.LabelControl()
        Me.cboTemplate = New DevExpress.XtraEditors.LookUpEdit()
        Me.MultiExportButton1 = New Vns.Erp.Core.MultiExportButton()
        Me.grvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grcMain = New DevExpress.XtraGrid.GridControl()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        Me.pcClose = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.popupControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pcOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcOption.SuspendLayout()
        CType(Me.cboCheckVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcClose.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.popupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblLocation)
        Me.GroupControl1.Controls.Add(Me.pcOption)
        Me.GroupControl1.Controls.Add(Me.pcClose)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(839, 42)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Lựa chọn"
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(549, 15)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblLocation.TabIndex = 6
        '
        'pcOption
        '
        Me.pcOption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcOption.Controls.Add(Me.cboCheckVisible)
        Me.pcOption.Controls.Add(Me.lblMau)
        Me.pcOption.Controls.Add(Me.cboTemplate)
        Me.pcOption.Controls.Add(Me.MultiExportButton1)
        Me.pcOption.Controls.Add(Me.btnReport)
        Me.pcOption.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcOption.Location = New System.Drawing.Point(2, 2)
        Me.pcOption.Name = "pcOption"
        Me.pcOption.Size = New System.Drawing.Size(655, 38)
        Me.pcOption.TabIndex = 5
        '
        'cboCheckVisible
        '
        Me.cboCheckVisible.Location = New System.Drawing.Point(577, 11)
        Me.cboCheckVisible.MenuManager = Me.BarManager1
        Me.cboCheckVisible.Name = "cboCheckVisible"
        Me.cboCheckVisible.Properties.Caption = "Hiển thị"
        Me.cboCheckVisible.Size = New System.Drawing.Size(75, 19)
        Me.cboCheckVisible.TabIndex = 7
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.imglImporter
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popDetail, Me.popRefresh, Me.popClose})
        Me.BarManager1.MaxItemId = 6
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(839, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 432)
        Me.barDockControlBottom.Size = New System.Drawing.Size(839, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 432)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(839, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 432)
        '
        'imglImporter
        '
        Me.imglImporter.ImageStream = CType(resources.GetObject("imglImporter.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglImporter.TransparentColor = System.Drawing.Color.Transparent
        Me.imglImporter.Images.SetKeyName(0, "save-as-32x32.png")
        Me.imglImporter.Images.SetKeyName(1, "close-32x32.png")
        Me.imglImporter.Images.SetKeyName(2, "copy-32x32.png")
        Me.imglImporter.Images.SetKeyName(3, "delete-32x32.png")
        Me.imglImporter.Images.SetKeyName(4, "edit-32x32.png")
        Me.imglImporter.Images.SetKeyName(5, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(6, "open-32x32.png")
        Me.imglImporter.Images.SetKeyName(7, "preview-32x32.png")
        Me.imglImporter.Images.SetKeyName(8, "refresh-32x32.png")
        Me.imglImporter.Images.SetKeyName(9, "save-32x32.png")
        Me.imglImporter.Images.SetKeyName(10, "save-all-32x32.png")
        Me.imglImporter.Images.SetKeyName(11, "save-and-close-32x32.png")
        Me.imglImporter.Images.SetKeyName(12, "Add.bmp")
        Me.imglImporter.Images.SetKeyName(13, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(14, "Close.png")
        Me.imglImporter.Images.SetKeyName(15, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(16, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(17, "Add Button-32.png")
        Me.imglImporter.Images.SetKeyName(18, "Add-32(1).png")
        Me.imglImporter.Images.SetKeyName(19, "Add-32.png")
        Me.imglImporter.Images.SetKeyName(20, "Book-Edit-32.png")
        Me.imglImporter.Images.SetKeyName(21, "BtnSave.png")
        Me.imglImporter.Images.SetKeyName(22, "BtnSaveDisabled.png")
        Me.imglImporter.Images.SetKeyName(23, "Close.png")
        Me.imglImporter.Images.SetKeyName(24, "Close-32.png")
        Me.imglImporter.Images.SetKeyName(25, "Close-box-red-32.png")
        Me.imglImporter.Images.SetKeyName(26, "delete-32.png")
        Me.imglImporter.Images.SetKeyName(27, "EDITITEM.GIF")
        Me.imglImporter.Images.SetKeyName(28, "edtError.png")
        Me.imglImporter.Images.SetKeyName(29, "find-32x32.png")
        Me.imglImporter.Images.SetKeyName(30, "icon_save.bmp")
        Me.imglImporter.Images.SetKeyName(31, "pcCloseButton.png")
        Me.imglImporter.Images.SetKeyName(32, "Edit-32.png")
        Me.imglImporter.Images.SetKeyName(33, "Edit-128.png")
        '
        'popDetail
        '
        Me.popDetail.Caption = "Chi tiết chứng từ"
        Me.popDetail.Id = 0
        Me.popDetail.ImageIndex = 15
        Me.popDetail.Name = "popDetail"
        '
        'popRefresh
        '
        Me.popRefresh.Caption = "Làm mới danh sách"
        Me.popRefresh.Id = 1
        Me.popRefresh.ImageIndex = 8
        Me.popRefresh.Name = "popRefresh"
        '
        'popClose
        '
        Me.popClose.Caption = "Đóng"
        Me.popClose.Id = 2
        Me.popClose.ImageIndex = 31
        Me.popClose.Name = "popClose"
        '
        'lblMau
        '
        Me.lblMau.Location = New System.Drawing.Point(275, 13)
        Me.lblMau.Name = "lblMau"
        Me.lblMau.Size = New System.Drawing.Size(20, 13)
        Me.lblMau.TabIndex = 3
        Me.lblMau.Text = "Mẫu"
        '
        'cboTemplate
        '
        Me.cboTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTemplate.Location = New System.Drawing.Point(301, 10)
        Me.cboTemplate.Name = "cboTemplate"
        Me.cboTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTemplate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenFileBaocao", "Chọn mẫu báo cáo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUONG_DAN", "DUONG_DAN", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboTemplate.Properties.DisplayMember = "TenFileBaocao"
        Me.cboTemplate.Properties.NullText = ""
        Me.cboTemplate.Properties.ValueMember = "DuongDan"
        Me.cboTemplate.Size = New System.Drawing.Size(209, 20)
        Me.cboTemplate.TabIndex = 2
        '
        'MultiExportButton1
        '
        Me.MultiExportButton1.GRID_VIEW = Me.grvMain
        Me.MultiExportButton1.Location = New System.Drawing.Point(5, 5)
        Me.MultiExportButton1.Name = "MultiExportButton1"
        Me.MultiExportButton1.Size = New System.Drawing.Size(135, 30)
        Me.MultiExportButton1.TabIndex = 0
        '
        'grvMain
        '
        Me.grvMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.Empty.Options.UseBackColor = True
        Me.grvMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvMain.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvMain.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvMain.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvMain.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvMain.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvMain.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvMain.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvMain.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvMain.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvMain.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvMain.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvMain.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvMain.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.OddRow.Options.UseBackColor = True
        Me.grvMain.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.OddRow.Options.UseForeColor = True
        Me.grvMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvMain.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvMain.Appearance.Preview.Options.UseBackColor = True
        Me.grvMain.Appearance.Preview.Options.UseFont = True
        Me.grvMain.Appearance.Preview.Options.UseForeColor = True
        Me.grvMain.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.Row.Options.UseBackColor = True
        Me.grvMain.Appearance.Row.Options.UseForeColor = True
        Me.grvMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvMain.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvMain.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvMain.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvMain.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvMain.Appearance.VertLine.Options.UseBackColor = True
        Me.grvMain.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvMain.GridControl = Me.grcMain
        Me.grvMain.Name = "grvMain"
        Me.grvMain.OptionsBehavior.Editable = False
        Me.grvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.grvMain.OptionsView.EnableAppearanceOddRow = True
        '
        'grcMain
        '
        Me.grcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcMain.Location = New System.Drawing.Point(2, 2)
        Me.grcMain.MainView = Me.grvMain
        Me.grcMain.Name = "grcMain"
        Me.grcMain.Padding = New System.Windows.Forms.Padding(4)
        Me.grcMain.Size = New System.Drawing.Size(835, 386)
        Me.grcMain.TabIndex = 3
        Me.grcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMain})
        '
        'btnReport
        '
        Me.btnReport.ImageIndex = 7
        Me.btnReport.ImageList = Me.imglImporter
        Me.btnReport.Location = New System.Drawing.Point(146, 5)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(110, 30)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "&Xem báo cáo"
        '
        'pcClose
        '
        Me.pcClose.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcClose.Controls.Add(Me.btnClose)
        Me.pcClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcClose.Location = New System.Drawing.Point(738, 2)
        Me.pcClose.Name = "pcClose"
        Me.pcClose.Size = New System.Drawing.Size(99, 38)
        Me.pcClose.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Đó&ng"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grcMain)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 42)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(839, 390)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Nội dung báo cáo"
        '
        'popupControl
        '
        Me.popupControl.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.popRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.popClose)})
        Me.popupControl.Manager = Me.BarManager1
        Me.popupControl.Name = "popupControl"
        '
        'frmBaoCaoView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(839, 432)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmBaoCaoView"
        Me.ShowInTaskbar = False
        Me.Text = "Danh sách báo cáo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.pcOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcOption.ResumeLayout(False)
        Me.pcOption.PerformLayout()
        CType(Me.cboCheckVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcClose.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.popupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MultiExportButton1 As MultiExportButton
    Friend WithEvents pcOption As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcClose As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMau As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTemplate As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents popDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents lblLocation As DevExpress.XtraEditors.LabelControl
    Private WithEvents grcMain As DevExpress.XtraGrid.GridControl
    Private WithEvents grvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboCheckVisible As DevExpress.XtraEditors.CheckEdit
End Class
