<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThamSoHeThong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThamSoHeThong))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grcSettings = New DevExpress.XtraGrid.GridControl()
        Me.grvSettings = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DONVI_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_DONVI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.imglImporter = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRollBack = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNhapXml = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXuatXml = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._FieldChooser = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._SearchHelper = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me._TreeList = New DevExpress.XtraTreeList.TreeList()
        Me.TEN_THAMSO = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me._TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grcSettings)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 86)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(819, 682)
        Me.PanelControl2.TabIndex = 1
        '
        'grcSettings
        '
        Me.grcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcSettings.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcSettings.Location = New System.Drawing.Point(2, 2)
        Me.grcSettings.MainView = Me.grvSettings
        Me.grcSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcSettings.Name = "grcSettings"
        Me.grcSettings.Size = New System.Drawing.Size(815, 678)
        Me.grcSettings.TabIndex = 0
        Me.grcSettings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvSettings})
        '
        'grvSettings
        '
        Me.grvSettings.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grvSettings.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grvSettings.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.DONVI_ID, Me.MA_DONVI, Me.GridColumn4})
        Me.grvSettings.GridControl = Me.grcSettings
        Me.grvSettings.Name = "grvSettings"
        Me.grvSettings.OptionsNavigation.EnterMoveNextColumn = True
        Me.grvSettings.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tên tham số"
        Me.GridColumn1.FieldName = "TenThamso"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 91
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Giá trị"
        Me.GridColumn2.FieldName = "GiaTri"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 160
        '
        'DONVI_ID
        '
        Me.DONVI_ID.Caption = "Đơn vị"
        Me.DONVI_ID.FieldName = "DonviId"
        Me.DONVI_ID.Name = "DONVI_ID"
        Me.DONVI_ID.Width = 94
        '
        'MA_DONVI
        '
        Me.MA_DONVI.Caption = "Mã đơn vị"
        Me.MA_DONVI.FieldName = "MaDonvi"
        Me.MA_DONVI.Name = "MA_DONVI"
        Me.MA_DONVI.Width = 81
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Mô tả"
        Me.GridColumn4.FieldName = "MoTa"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 100
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnCancel)
        Me.PanelControl3.Controls.Add(Me.btnRollBack)
        Me.PanelControl3.Controls.Add(Me.btnNhapXml)
        Me.PanelControl3.Controls.Add(Me.btnXuatXml)
        Me.PanelControl3.Controls.Add(Me.btnSave)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 624)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(972, 44)
        Me.PanelControl3.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.ImageList = Me.imglImporter
        Me.btnCancel.Location = New System.Drawing.Point(857, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 34)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Ð&óng"
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
        'btnRollBack
        '
        Me.btnRollBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRollBack.ImageIndex = 8
        Me.btnRollBack.ImageList = Me.imglImporter
        Me.btnRollBack.Location = New System.Drawing.Point(743, 4)
        Me.btnRollBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollBack.Name = "btnRollBack"
        Me.btnRollBack.Size = New System.Drawing.Size(107, 34)
        Me.btnRollBack.TabIndex = 4
        Me.btnRollBack.Text = "&Khôi phục"
        '
        'btnNhapXml
        '
        Me.btnNhapXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNhapXml.ImageIndex = 33
        Me.btnNhapXml.ImageList = Me.imglImporter
        Me.btnNhapXml.Location = New System.Drawing.Point(118, 4)
        Me.btnNhapXml.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNhapXml.Name = "btnNhapXml"
        Me.btnNhapXml.Size = New System.Drawing.Size(107, 34)
        Me.btnNhapXml.TabIndex = 0
        Me.btnNhapXml.Text = "&Nhập XML"
        '
        'btnXuatXml
        '
        Me.btnXuatXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXuatXml.ImageIndex = 9
        Me.btnXuatXml.ImageList = Me.imglImporter
        Me.btnXuatXml.Location = New System.Drawing.Point(3, 4)
        Me.btnXuatXml.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnXuatXml.Name = "btnXuatXml"
        Me.btnXuatXml.Size = New System.Drawing.Size(107, 34)
        Me.btnXuatXml.TabIndex = 0
        Me.btnXuatXml.Text = "&Xuất  XML"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageIndex = 0
        Me.btnSave.ImageList = Me.imglImporter
        Me.btnSave.Location = New System.Drawing.Point(629, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 34)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me._FieldChooser)
        Me.GroupControl1.Controls.Add(Me._SearchHelper)
        Me.GroupControl1.Controls.Add(Me.labelControl2)
        Me.GroupControl1.Controls.Add(Me.labelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(819, 86)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Tìm kiếm"
        '
        '_FieldChooser
        '
        Me._FieldChooser.EditValue = ""
        Me._FieldChooser.Location = New System.Drawing.Point(104, 43)
        Me._FieldChooser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._FieldChooser.Name = "_FieldChooser"
        Me._FieldChooser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me._FieldChooser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FieldChooser.Properties.ImmediatePopup = True
        Me._FieldChooser.Properties.NullText = ""
        Me._FieldChooser.Properties.View = Me.gridView1
        Me._FieldChooser.Size = New System.Drawing.Size(134, 22)
        Me._FieldChooser.TabIndex = 0
        '
        'gridView1
        '
        Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        '_SearchHelper
        '
        Me._SearchHelper.EditValue = ""
        Me._SearchHelper.Location = New System.Drawing.Point(329, 43)
        Me._SearchHelper.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._SearchHelper.Name = "_SearchHelper"
        Me._SearchHelper.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me._SearchHelper.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._SearchHelper.Properties.ImmediatePopup = True
        Me._SearchHelper.Properties.NullText = ""
        Me._SearchHelper.Properties.View = Me.gridLookUpEdit1View
        Me._SearchHelper.Size = New System.Drawing.Size(164, 22)
        Me._SearchHelper.TabIndex = 1
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn5})
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên tham số"
        Me.GridColumn3.FieldName = "TenThamso"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Giá trị"
        Me.GridColumn5.FieldName = "GiaTri"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(282, 47)
        Me.labelControl2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(34, 17)
        Me.labelControl2.TabIndex = 8
        Me.labelControl2.Text = "Giá trị"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(16, 47)
        Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(86, 17)
        Me.labelControl1.TabIndex = 7
        Me.labelControl1.Text = "Tìm kiếm theo"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me._TreeList)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(972, 624)
        Me.SplitContainerControl1.SplitterPosition = 265
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        '_TreeList
        '
        Me._TreeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TEN_THAMSO})
        Me._TreeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TreeList.Location = New System.Drawing.Point(0, 0)
        Me._TreeList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._TreeList.Name = "_TreeList"
        Me._TreeList.OptionsBehavior.Editable = False
        Me._TreeList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me._TreeList.Size = New System.Drawing.Size(309, 768)
        Me._TreeList.TabIndex = 0
        '
        'TEN_THAMSO
        '
        Me.TEN_THAMSO.Caption = "Danh mục hệ thống"
        Me.TEN_THAMSO.FieldName = "TenThamso"
        Me.TEN_THAMSO.Name = "TEN_THAMSO"
        Me.TEN_THAMSO.Visible = True
        Me.TEN_THAMSO.VisibleIndex = 0
        '
        'frmThamSoHeThong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 668)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmThamSoHeThong"
        Me.Text = "Tham số hệ thống"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me._TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcSettings As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvSettings As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imglImporter As System.Windows.Forms.ImageList
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRollBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXuatXml As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNhapXml As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents _TreeList As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TEN_THAMSO As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents DONVI_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_DONVI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents _FieldChooser As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents _SearchHelper As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
