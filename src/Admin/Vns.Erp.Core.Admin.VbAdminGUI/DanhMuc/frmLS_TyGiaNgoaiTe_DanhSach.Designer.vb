

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLS_TyGiaNgoaiTe_DanhSach
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me._GridControl = New DevExpress.XtraGrid.GridControl
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TEN_NGOAITE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_NGOAITE_HT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NGAY_QUYDOI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SO_TIEN_QUYDOI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me._GridControl)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(912, 544)
        Me.PanelControl1.TabIndex = 3
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 2)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me._GridControl.Size = New System.Drawing.Size(908, 540)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView, Me.GridView1})
        '
        '_GridView
        '
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TEN_NGOAITE, Me.TEN_NGOAITE_HT, Me.NGAY_QUYDOI, Me.SO_TIEN_QUYDOI})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsBehavior.Editable = False
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'TEN_NGOAITE
        '
        Me.TEN_NGOAITE.Caption = "Tên ngoại tệ"
        Me.TEN_NGOAITE.FieldName = "TenNgoaite"
        Me.TEN_NGOAITE.Name = "TenNgoaite"
        Me.TEN_NGOAITE.Visible = True
        Me.TEN_NGOAITE.VisibleIndex = 0
        '
        'TEN_NGOAITE_HT
        '
        Me.TEN_NGOAITE_HT.Caption = "Tên ngoại tệ hạch toán"
        Me.TEN_NGOAITE_HT.FieldName = "TenNgoaiteHt"
        Me.TEN_NGOAITE_HT.Name = "TenNgoaiteHt"
        Me.TEN_NGOAITE_HT.Visible = True
        Me.TEN_NGOAITE_HT.VisibleIndex = 3
        '
        'NGAY_QUYDOI
        '
        Me.NGAY_QUYDOI.Caption = "Ngày quy đổi"
        Me.NGAY_QUYDOI.FieldName = "NgayQuydoi"
        Me.NGAY_QUYDOI.Name = "NgayQuydoi"
        Me.NGAY_QUYDOI.Visible = True
        Me.NGAY_QUYDOI.VisibleIndex = 1
        '
        'SO_TIEN_QUYDOI
        '
        Me.SO_TIEN_QUYDOI.Caption = "Số tiền qui đổi"
        Me.SO_TIEN_QUYDOI.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.SO_TIEN_QUYDOI.FieldName = "SoTienQuydoi"
        Me.SO_TIEN_QUYDOI.Name = "SoTienQuydoi"
        Me.SO_TIEN_QUYDOI.Visible = True
        Me.SO_TIEN_QUYDOI.VisibleIndex = 2
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me._GridControl
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnModify)
        Me.PanelControl2.Controls.Add(Me.btnClose)
        Me.PanelControl2.Controls.Add(Me.btnCreate)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 544)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(912, 39)
        Me.PanelControl2.TabIndex = 22
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(88, 5)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 8
        Me.btnClose.Location = New System.Drawing.Point(830, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Thoát"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.ImageIndex = 2
        Me.btnCreate.Location = New System.Drawing.Point(2, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 30)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(174, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Xóa"
        '
        'frmLS_TyGiaNgoaiTe_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(912, 583)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Name = "frmLS_TyGiaNgoaiTe_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lịch sử tỷ giá ngoại tệ "
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_NGOAITE_HT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEN_NGOAITE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_QUYDOI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_QUYDOI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
