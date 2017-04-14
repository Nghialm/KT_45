<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigGrid
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnNewRow = New DevExpress.XtraEditors.SimpleButton
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelRow = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtGridID = New DevExpress.XtraEditors.TextEdit
        Me.txtFormID = New DevExpress.XtraEditors.TextEdit
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me._GridControl = New DevExpress.XtraGrid.GridControl
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCaption = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColWidth = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColReadOnly = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkColReadOnly = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColVisible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkColVisible = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColVisibleIndex = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtGridID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColReadOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnNewRow)
        Me.PanelControl1.Controls.Add(Me.btnNew)
        Me.PanelControl1.Controls.Add(Me.btnDelRow)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtGridID)
        Me.PanelControl1.Controls.Add(Me.txtFormID)
        Me.PanelControl1.Controls.Add(Me.btnLoad)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(676, 55)
        Me.PanelControl1.TabIndex = 0
        '
        'btnNewRow
        '
        Me.btnNewRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNewRow.ImageIndex = 2
        Me.btnNewRow.Location = New System.Drawing.Point(624, 16)
        Me.btnNewRow.Name = "btnNewRow"
        Me.btnNewRow.Size = New System.Drawing.Size(52, 30)
        Me.btnNewRow.TabIndex = 3
        Me.btnNewRow.Text = "New Row"
        Me.btnNewRow.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageIndex = 2
        Me.btnNew.Location = New System.Drawing.Point(596, 8)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 30)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New"
        Me.btnNew.Visible = False
        '
        'btnDelRow
        '
        Me.btnDelRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelRow.ImageIndex = 2
        Me.btnDelRow.Location = New System.Drawing.Point(568, 8)
        Me.btnDelRow.Name = "btnDelRow"
        Me.btnDelRow.Size = New System.Drawing.Size(80, 30)
        Me.btnDelRow.TabIndex = 4
        Me.btnDelRow.Text = "Del Row"
        Me.btnDelRow.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Grid ID"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Form ID"
        '
        'txtGridID
        '
        Me.txtGridID.Location = New System.Drawing.Point(48, 30)
        Me.txtGridID.Name = "txtGridID"
        Me.txtGridID.Properties.ReadOnly = True
        Me.txtGridID.Size = New System.Drawing.Size(469, 20)
        Me.txtGridID.TabIndex = 1
        '
        'txtFormID
        '
        Me.txtFormID.Location = New System.Drawing.Point(48, 4)
        Me.txtFormID.Name = "txtFormID"
        Me.txtFormID.Properties.ReadOnly = True
        Me.txtFormID.Size = New System.Drawing.Size(469, 20)
        Me.txtFormID.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLoad.ImageIndex = 2
        Me.btnLoad.Location = New System.Drawing.Point(523, 5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(80, 30)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.Location = New System.Drawing.Point(212, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me._GridControl)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(4, 59)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(676, 319)
        Me.PanelControl2.TabIndex = 1
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 2)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkColReadOnly, Me.chkColVisible})
        Me._GridControl.Size = New System.Drawing.Size(672, 315)
        Me._GridControl.TabIndex = 0
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
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColName, Me.ColCaption, Me.ColWidth, Me.ColReadOnly, Me.ColVisible, Me.ColVisibleIndex})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.EnableAppearanceEvenRow = True
        Me._GridView.OptionsView.EnableAppearanceOddRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'ColName
        '
        Me.ColName.Caption = "Tên cột"
        Me.ColName.FieldName = "ColName"
        Me.ColName.Name = "ColName"
        Me.ColName.OptionsColumn.ReadOnly = True
        Me.ColName.Visible = True
        Me.ColName.VisibleIndex = 0
        Me.ColName.Width = 204
        '
        'ColCaption
        '
        Me.ColCaption.Caption = "Tên hiện thị"
        Me.ColCaption.FieldName = "ColCaption"
        Me.ColCaption.Name = "ColCaption"
        Me.ColCaption.Visible = True
        Me.ColCaption.VisibleIndex = 1
        Me.ColCaption.Width = 204
        '
        'ColWidth
        '
        Me.ColWidth.Caption = "Độ dài"
        Me.ColWidth.FieldName = "ColWidth"
        Me.ColWidth.Name = "ColWidth"
        Me.ColWidth.Visible = True
        Me.ColWidth.VisibleIndex = 2
        Me.ColWidth.Width = 102
        '
        'ColReadOnly
        '
        Me.ColReadOnly.Caption = "Không cho phép sửa"
        Me.ColReadOnly.ColumnEdit = Me.chkColReadOnly
        Me.ColReadOnly.FieldName = "ColReadOnly"
        Me.ColReadOnly.Name = "ColReadOnly"
        Me.ColReadOnly.Visible = True
        Me.ColReadOnly.VisibleIndex = 3
        Me.ColReadOnly.Width = 130
        '
        'chkColReadOnly
        '
        Me.chkColReadOnly.AutoHeight = False
        Me.chkColReadOnly.Name = "chkColReadOnly"
        Me.chkColReadOnly.ValueChecked = "1"
        Me.chkColReadOnly.ValueUnchecked = "0"
        '
        'ColVisible
        '
        Me.ColVisible.Caption = "Hiển thị"
        Me.ColVisible.ColumnEdit = Me.chkColVisible
        Me.ColVisible.FieldName = "ColVisible"
        Me.ColVisible.Name = "ColVisible"
        Me.ColVisible.Visible = True
        Me.ColVisible.VisibleIndex = 4
        Me.ColVisible.Width = 100
        '
        'chkColVisible
        '
        Me.chkColVisible.AutoHeight = False
        Me.chkColVisible.Name = "chkColVisible"
        Me.chkColVisible.ValueChecked = "1"
        Me.chkColVisible.ValueUnchecked = "0"
        '
        'ColVisibleIndex
        '
        Me.ColVisibleIndex.Caption = "Thứ tự"
        Me.ColVisibleIndex.FieldName = "ColVisibleIndex"
        Me.ColVisibleIndex.Name = "ColVisibleIndex"
        Me.ColVisibleIndex.Visible = True
        Me.ColVisibleIndex.VisibleIndex = 5
        Me.ColVisibleIndex.Width = 100
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnQuit)
        Me.PanelControl3.Controls.Add(Me.btnSave)
        Me.PanelControl3.Controls.Add(Me.btnDelete)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(4, 378)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(676, 30)
        Me.PanelControl3.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuit.ImageIndex = 2
        Me.btnQuit.Location = New System.Drawing.Point(384, 0)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 2
        Me.btnSave.Location = New System.Drawing.Point(298, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'ConfigGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 412)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigGrid"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cấu hình"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtGridID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColReadOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtGridID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFormID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCaption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWidth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColReadOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkColReadOnly As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColVisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkColVisible As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColVisibleIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNewRow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelRow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton

End Class
