

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucNguonVon_tscd_DanhSach
    Inherits FrmBaseDmDanhSach

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
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MaDmNguonTscd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KyHieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDmNguonTscd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MoTa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CoSuDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChoPhepSua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        Me._FieldChooser = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._SearchHelper = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btExport = New Vns.Erp.Core.MultiExportButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me._GridControl)
        Me.PanelControl1.Controls.Add(Me._GroupControlSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(950, 457)
        Me.PanelControl1.TabIndex = 2
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 57)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.Size = New System.Drawing.Size(946, 398)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView, Me.GridView1})
        '
        '_GridView
        '
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MaDmNguonTscd, Me.KyHieu, Me.TenDmNguonTscd, Me.MoTa, Me.CoSuDung, Me.ChoPhepSua})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsBehavior.Editable = False
        Me._GridView.OptionsView.ShowAutoFilterRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'MaDmNguonTscd
        '
        Me.MaDmNguonTscd.Caption = "Mã nguồn vốn TSCD"
        Me.MaDmNguonTscd.FieldName = "MaDmNguonTscd"
        Me.MaDmNguonTscd.Name = "MaDmNguonTscd"
        Me.MaDmNguonTscd.OptionsColumn.ReadOnly = True
        Me.MaDmNguonTscd.Visible = True
        Me.MaDmNguonTscd.VisibleIndex = 0
        Me.MaDmNguonTscd.Width = 100
        '
        'KyHieu
        '
        Me.KyHieu.Caption = "Ký hiệu"
        Me.KyHieu.FieldName = "KyHieu"
        Me.KyHieu.Name = "KyHieu"
        Me.KyHieu.OptionsColumn.ReadOnly = True
        Me.KyHieu.Visible = True
        Me.KyHieu.VisibleIndex = 1
        Me.KyHieu.Width = 100
        '
        'TenDmNguonTscd
        '
        Me.TenDmNguonTscd.Caption = "Tên nguồn vốn TSCD"
        Me.TenDmNguonTscd.FieldName = "TenDmNguonTscd"
        Me.TenDmNguonTscd.Name = "TenDmNguonTscd"
        Me.TenDmNguonTscd.OptionsColumn.ReadOnly = True
        Me.TenDmNguonTscd.Visible = True
        Me.TenDmNguonTscd.VisibleIndex = 2
        Me.TenDmNguonTscd.Width = 100
        '
        'MoTa
        '
        Me.MoTa.Caption = "Mô tả"
        Me.MoTa.FieldName = "MoTa"
        Me.MoTa.Name = "MoTa"
        Me.MoTa.OptionsColumn.ReadOnly = True
        Me.MoTa.Visible = True
        Me.MoTa.VisibleIndex = 3
        Me.MoTa.Width = 100
        '
        'CoSuDung
        '
        Me.CoSuDung.Caption = "Có sử dụng"
        Me.CoSuDung.FieldName = "CoSuDung"
        Me.CoSuDung.Name = "CoSuDung"
        Me.CoSuDung.OptionsColumn.ReadOnly = True
        Me.CoSuDung.Visible = True
        Me.CoSuDung.VisibleIndex = 4
        Me.CoSuDung.Width = 100
        '
        'ChoPhepSua
        '
        Me.ChoPhepSua.Caption = "Cho phép sửa"
        Me.ChoPhepSua.FieldName = "ChoPhepSua"
        Me.ChoPhepSua.Name = "ChoPhepSua"
        Me.ChoPhepSua.OptionsColumn.ReadOnly = True
        Me.ChoPhepSua.Visible = True
        Me.ChoPhepSua.VisibleIndex = 5
        Me.ChoPhepSua.Width = 152
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me._GridControl
        Me.GridView1.Name = "GridView1"
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me._FieldChooser)
        Me._GroupControlSearch.Controls.Add(Me._SearchHelper)
        Me._GroupControlSearch.Controls.Add(Me.labelControl2)
        Me._GroupControlSearch.Controls.Add(Me.labelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(2, 2)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(946, 55)
        Me._GroupControlSearch.TabIndex = 2
        Me._GroupControlSearch.Text = "Tìm kiếm"
        Me._GroupControlSearch.Visible = False
        '
        '_FieldChooser
        '
        Me._FieldChooser.EditValue = ""
        Me._FieldChooser.Location = New System.Drawing.Point(84, 25)
        Me._FieldChooser.Name = "_FieldChooser"
        Me._FieldChooser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FieldChooser.Properties.ImmediatePopup = True
        Me._FieldChooser.Properties.NullText = ""
        Me._FieldChooser.Properties.View = Me.GridView2
        Me._FieldChooser.Size = New System.Drawing.Size(141, 20)
        Me._FieldChooser.TabIndex = 0
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        '_SearchHelper
        '
        Me._SearchHelper.EditValue = ""
        Me._SearchHelper.Location = New System.Drawing.Point(280, 25)
        Me._SearchHelper.Name = "_SearchHelper"
        Me._SearchHelper.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._SearchHelper.Properties.ImmediatePopup = True
        Me._SearchHelper.Properties.NullText = ""
        Me._SearchHelper.Properties.View = Me.gridLookUpEdit1View
        Me._SearchHelper.Size = New System.Drawing.Size(141, 20)
        Me._SearchHelper.TabIndex = 1
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(242, 28)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(28, 13)
        Me.labelControl2.TabIndex = 4
        Me.labelControl2.Text = "Giá trị"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(9, 28)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(65, 13)
        Me.labelControl1.TabIndex = 3
        Me.labelControl1.Text = "Tím kiếm theo"
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btExport)
        Me._ActionPanel.Controls.Add(Me.btnPri)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Controls.Add(Me.btnCreate)
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(0, 457)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(950, 34)
        Me._ActionPanel.TabIndex = 3
        '
        'btExport
        '
        Me.btExport.GRID_VIEW = Me._GridView
        Me.btExport.Location = New System.Drawing.Point(261, 3)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(135, 30)
        Me.btExport.TabIndex = 11
        Me.btExport.Visible = False
        '
        'btnPri
        '
        Me.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPri.ImageIndex = 5
        Me.btnPri.Location = New System.Drawing.Point(530, 3)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 7
        Me.btnPri.Text = "&In"
        Me.btnPri.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(869, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Ðó&ng"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 3
        Me.btnModify.Location = New System.Drawing.Point(88, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.ImageIndex = 2
        Me.btnCreate.Location = New System.Drawing.Point(2, 3)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 30)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(175, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Xóa"
        '
        'frmDanhMucNguonVon_tscd_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(950, 491)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me._ActionPanel)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucNguonVon_tscd_DanhSach"
        Me.Text = "Danh mục nguồn vốn tài sản cố định"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        CType(Me._FieldChooser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SearchHelper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_DM_NGUON_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DM_NGUON_TSCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MO_TA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_SU_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CHO_PHEP_SUA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Private WithEvents _FieldChooser As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents _SearchHelper As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btExport As MultiExportButton
    Friend WithEvents MaDmNguonTscd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KyHieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenDmNguonTscd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MoTa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CoSuDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChoPhepSua As DevExpress.XtraGrid.Columns.GridColumn
End Class
