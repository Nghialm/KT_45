<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKT_H_BAOCAO_DanhSach
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
        Me.grc_KT_H_BAOCAO = New DevExpress.XtraGrid.GridControl()
        Me.grv_KT_H_BAOCAO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.STT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_BAOCAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_DONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SO_COT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grc_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grc_KT_H_BAOCAO
        '
        Me.grc_KT_H_BAOCAO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grc_KT_H_BAOCAO.Location = New System.Drawing.Point(4, 4)
        Me.grc_KT_H_BAOCAO.MainView = Me.grv_KT_H_BAOCAO
        Me.grc_KT_H_BAOCAO.Name = "grc_KT_H_BAOCAO"
        Me.grc_KT_H_BAOCAO.Size = New System.Drawing.Size(986, 570)
        Me.grc_KT_H_BAOCAO.TabIndex = 0
        Me.grc_KT_H_BAOCAO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grv_KT_H_BAOCAO})
        '
        'grv_KT_H_BAOCAO
        '
        Me.grv_KT_H_BAOCAO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.STT, Me.MA_BAOCAO, Me.TITLE, Me.SO_DONG, Me.SO_COT})
        Me.grv_KT_H_BAOCAO.GridControl = Me.grc_KT_H_BAOCAO
        Me.grv_KT_H_BAOCAO.Name = "grv_KT_H_BAOCAO"
        Me.grv_KT_H_BAOCAO.OptionsBehavior.Editable = False
        Me.grv_KT_H_BAOCAO.OptionsView.ColumnAutoWidth = False
        Me.grv_KT_H_BAOCAO.OptionsView.ShowGroupPanel = False
        '
        'STT
        '
        Me.STT.AppearanceCell.Options.UseTextOptions = True
        Me.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.STT.Caption = "STT"
        Me.STT.Name = "STT"
        Me.STT.OptionsColumn.FixedWidth = True
        Me.STT.Visible = True
        Me.STT.VisibleIndex = 0
        Me.STT.Width = 43
        '
        'MA_BAOCAO
        '
        Me.MA_BAOCAO.Caption = "Mã báo cáo"
        Me.MA_BAOCAO.FieldName = "MaBaocao"
        Me.MA_BAOCAO.Name = "MA_BAOCAO"
        Me.MA_BAOCAO.Visible = True
        Me.MA_BAOCAO.VisibleIndex = 1
        Me.MA_BAOCAO.Width = 105
        '
        'TITLE
        '
        Me.TITLE.Caption = "Tên báo cáo"
        Me.TITLE.FieldName = "Title"
        Me.TITLE.Name = "TITLE"
        Me.TITLE.OptionsColumn.FixedWidth = True
        Me.TITLE.Visible = True
        Me.TITLE.VisibleIndex = 2
        Me.TITLE.Width = 181
        '
        'SO_DONG
        '
        Me.SO_DONG.Caption = "Số dòng"
        Me.SO_DONG.FieldName = "SoDong"
        Me.SO_DONG.Name = "SO_DONG"
        Me.SO_DONG.OptionsColumn.FixedWidth = True
        Me.SO_DONG.Visible = True
        Me.SO_DONG.VisibleIndex = 3
        '
        'SO_COT
        '
        Me.SO_COT.Caption = "Số cột"
        Me.SO_COT.FieldName = "SoCot"
        Me.SO_COT.Name = "SO_COT"
        Me.SO_COT.OptionsColumn.FixedWidth = True
        Me.SO_COT.Visible = True
        Me.SO_COT.VisibleIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnImport)
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnModify)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 574)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(986, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(906, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Đó&ng"
        '
        'btnModify
        '
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(86, 5)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(0, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Mới"
        '
        'btnDelete
        '
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(172, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "&Xóa"
        '
        'btnImport
        '
        Me.btnImport.ImageIndex = 2
        Me.btnImport.Location = New System.Drawing.Point(344, 6)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 30)
        Me.btnImport.TabIndex = 13
        Me.btnImport.Text = "&Nhập dữ liệu"
        '
        'btnExport
        '
        Me.btnExport.ImageIndex = 2
        Me.btnExport.Location = New System.Drawing.Point(258, 6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(80, 30)
        Me.btnExport.TabIndex = 12
        Me.btnExport.Text = "&Xuất dữ liệu"
        '
        'frmKT_H_BAOCAO_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 612)
        Me.Controls.Add(Me.grc_KT_H_BAOCAO)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmKT_H_BAOCAO_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Danh sách các báo cáo"
        CType(Me.grc_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grc_KT_H_BAOCAO As DevExpress.XtraGrid.GridControl
    Friend WithEvents grv_KT_H_BAOCAO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents STT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_DONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_COT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_BAOCAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
End Class
