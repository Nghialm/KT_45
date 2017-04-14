<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucNhomVatTu1_DanhSach
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_NHOM_VT_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenNhomVt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LoaiNhom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CoSuDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChoPhepSua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._GroupControlSearch = New DevExpress.XtraEditors.GroupControl()
        Me.txtKeyword = New DevExpress.XtraEditors.TextEdit()
        Me.chkColum = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btExport = New Vns.Erp.Core.MultiExportButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlSearch.SuspendLayout()
        CType(Me.txtKeyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me._GroupControlSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 566)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 71)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(992, 493)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(0, 0)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.Size = New System.Drawing.Size(992, 493)
        Me._GridControl.TabIndex = 0
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_NHOM_VT_1, Me.TenNhomVt1, Me.LoaiNhom, Me.CoSuDung, Me.ChoPhepSua})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsView.ShowAutoFilterRow = True
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'MA_NHOM_VT_1
        '
        Me.MA_NHOM_VT_1.Caption = "Mã nhóm vật tư"
        Me.MA_NHOM_VT_1.FieldName = "MaNhomVt1"
        Me.MA_NHOM_VT_1.Name = "MA_NHOM_VT_1"
        Me.MA_NHOM_VT_1.Visible = True
        Me.MA_NHOM_VT_1.VisibleIndex = 0
        Me.MA_NHOM_VT_1.Width = 118
        '
        'TenNhomVt1
        '
        Me.TenNhomVt1.Caption = "Tên nhóm vật tư"
        Me.TenNhomVt1.FieldName = "TenNhomVt1"
        Me.TenNhomVt1.Name = "TenNhomVt1"
        Me.TenNhomVt1.Visible = True
        Me.TenNhomVt1.VisibleIndex = 1
        Me.TenNhomVt1.Width = 109
        '
        'LoaiNhom
        '
        Me.LoaiNhom.Caption = "Loại nhóm"
        Me.LoaiNhom.FieldName = "LoaiNhom"
        Me.LoaiNhom.Name = "LoaiNhom"
        Me.LoaiNhom.Visible = True
        Me.LoaiNhom.VisibleIndex = 2
        '
        'CoSuDung
        '
        Me.CoSuDung.Caption = "Có sử dụng"
        Me.CoSuDung.FieldName = "CoSuDung"
        Me.CoSuDung.Name = "CoSuDung"
        Me.CoSuDung.Visible = True
        Me.CoSuDung.VisibleIndex = 3
        Me.CoSuDung.Width = 86
        '
        'ChoPhepSua
        '
        Me.ChoPhepSua.Caption = "Cho phép sửa"
        Me.ChoPhepSua.FieldName = "ChoPhepSua"
        Me.ChoPhepSua.Name = "ChoPhepSua"
        Me.ChoPhepSua.Visible = True
        Me.ChoPhepSua.VisibleIndex = 4
        Me.ChoPhepSua.Width = 120
        '
        '_GroupControlSearch
        '
        Me._GroupControlSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._GroupControlSearch.Appearance.BorderColor = System.Drawing.Color.White
        Me._GroupControlSearch.Appearance.Options.UseBackColor = True
        Me._GroupControlSearch.Appearance.Options.UseBorderColor = True
        Me._GroupControlSearch.Controls.Add(Me.txtKeyword)
        Me._GroupControlSearch.Controls.Add(Me.chkColum)
        Me._GroupControlSearch.Controls.Add(Me.labelControl1)
        Me._GroupControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlSearch.Location = New System.Drawing.Point(2, 2)
        Me._GroupControlSearch.Name = "_GroupControlSearch"
        Me._GroupControlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._GroupControlSearch.Size = New System.Drawing.Size(992, 69)
        Me._GroupControlSearch.TabIndex = 0
        Me._GroupControlSearch.Text = "Tìm kiếm"
        Me._GroupControlSearch.Visible = False
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(258, 32)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKeyword.Size = New System.Drawing.Size(175, 20)
        Me.txtKeyword.TabIndex = 0
        '
        'chkColum
        '
        Me.chkColum.Location = New System.Drawing.Point(86, 32)
        Me.chkColum.Name = "chkColum"
        Me.chkColum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.chkColum.Size = New System.Drawing.Size(166, 20)
        Me.chkColum.TabIndex = 1
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(8, 35)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(65, 13)
        Me.labelControl1.TabIndex = 2
        Me.labelControl1.Text = "Tìm kiếm theo"
        '
        '_ActionPanel
        '
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnDelete)
        Me._ActionPanel.Controls.Add(Me.btExport)
        Me._ActionPanel.Controls.Add(Me.btnPri)
        Me._ActionPanel.Controls.Add(Me.btnClose)
        Me._ActionPanel.Controls.Add(Me.btnCreate)
        Me._ActionPanel.Controls.Add(Me.btnModify)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(6, 572)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(996, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 5
        Me.btnDelete.Location = New System.Drawing.Point(174, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Xóa"
        '
        'btExport
        '
        Me.btExport.GRID_VIEW = Me._GridView
        Me.btExport.Location = New System.Drawing.Point(260, 3)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(135, 30)
        Me.btExport.TabIndex = 11
        Me.btExport.Visible = False
        '
        'btnPri
        '
        Me.btnPri.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPri.ImageIndex = 5
        Me.btnPri.Location = New System.Drawing.Point(560, 3)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 3
        Me.btnPri.Text = "&In"
        Me.btnPri.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 6
        Me.btnClose.Location = New System.Drawing.Point(913, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Ð&óng"
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
        'frmDanhMucNhomVatTu1_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me._ActionPanel)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucNhomVatTu1_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "Danh mục nhóm vật tư/hàng hóa [Danh Sách]"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlSearch.ResumeLayout(False)
        Me._GroupControlSearch.PerformLayout()
        CType(Me.txtKeyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOAI_NHOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CO_SU_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CHO_PHEP_SUA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _GroupControlSearch As DevExpress.XtraEditors.GroupControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkColum As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents txtKeyword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btExport As MultiExportButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TenNhomVt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoaiNhom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CoSuDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChoPhepSua As DevExpress.XtraGrid.Columns.GridColumn
End Class
