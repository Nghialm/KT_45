<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhaiBaoChiTieu_DanhSach
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.IN_DONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KIEU_CHU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grc_ChiTieu = New DevExpress.XtraGrid.GridControl()
        Me.grv_ChiTieu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.STT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHI_TIEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CACH_TINH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHI_TIEU_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DK_MA_TK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DK_MA_TK_DU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HAM_TINH_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grc_ChiTieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv_ChiTieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IN_DONG
        '
        Me.IN_DONG.FieldName = "InDong"
        Me.IN_DONG.Name = "IN_DONG"
        Me.IN_DONG.OptionsColumn.AllowEdit = False
        Me.IN_DONG.OptionsColumn.ReadOnly = True
        '
        'KIEU_CHU
        '
        Me.KIEU_CHU.FieldName = "KieuChu"
        Me.KIEU_CHU.Name = "KIEU_CHU"
        Me.KIEU_CHU.OptionsColumn.AllowEdit = False
        Me.KIEU_CHU.OptionsColumn.ReadOnly = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grc_ChiTieu)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(986, 570)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh sách chỉ tiêu"
        '
        'grc_ChiTieu
        '
        Me.grc_ChiTieu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grc_ChiTieu.Location = New System.Drawing.Point(2, 22)
        Me.grc_ChiTieu.MainView = Me.grv_ChiTieu
        Me.grc_ChiTieu.Name = "grc_ChiTieu"
        Me.grc_ChiTieu.Size = New System.Drawing.Size(982, 546)
        Me.grc_ChiTieu.TabIndex = 0
        Me.grc_ChiTieu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grv_ChiTieu})
        '
        'grv_ChiTieu
        '
        Me.grv_ChiTieu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.STT, Me.MA_SO, Me.CHI_TIEU, Me.CACH_TINH, Me.CHI_TIEU_2, Me.DK_MA_TK, Me.DK_MA_TK_DU, Me.HAM_TINH_1, Me.KIEU_CHU, Me.IN_DONG})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.IN_DONG
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.KIEU_CHU
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        Me.grv_ChiTieu.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grv_ChiTieu.GridControl = Me.grc_ChiTieu
        Me.grv_ChiTieu.Name = "grv_ChiTieu"
        Me.grv_ChiTieu.OptionsView.ColumnAutoWidth = False
        Me.grv_ChiTieu.OptionsView.ShowGroupPanel = False
        '
        'STT
        '
        Me.STT.AppearanceCell.Options.UseTextOptions = True
        Me.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.STT.Caption = "STT"
        Me.STT.FieldName = "ThuTu"
        Me.STT.Name = "STT"
        Me.STT.OptionsColumn.AllowEdit = False
        Me.STT.OptionsColumn.FixedWidth = True
        Me.STT.OptionsColumn.ReadOnly = True
        Me.STT.Visible = True
        Me.STT.VisibleIndex = 0
        Me.STT.Width = 42
        '
        'MA_SO
        '
        Me.MA_SO.Caption = "Mã chỉ tiêu"
        Me.MA_SO.FieldName = "MaSo"
        Me.MA_SO.Name = "MA_SO"
        Me.MA_SO.OptionsColumn.AllowEdit = False
        Me.MA_SO.OptionsColumn.FixedWidth = True
        Me.MA_SO.OptionsColumn.ReadOnly = True
        Me.MA_SO.Visible = True
        Me.MA_SO.VisibleIndex = 1
        '
        'CHI_TIEU
        '
        Me.CHI_TIEU.Caption = "Chỉ tiêu"
        Me.CHI_TIEU.FieldName = "ChiTieu"
        Me.CHI_TIEU.Name = "CHI_TIEU"
        Me.CHI_TIEU.OptionsColumn.AllowEdit = False
        Me.CHI_TIEU.OptionsColumn.FixedWidth = True
        Me.CHI_TIEU.OptionsColumn.ReadOnly = True
        Me.CHI_TIEU.Visible = True
        Me.CHI_TIEU.VisibleIndex = 2
        Me.CHI_TIEU.Width = 250
        '
        'CACH_TINH
        '
        Me.CACH_TINH.Caption = "Cách tính"
        Me.CACH_TINH.FieldName = "CachTinh"
        Me.CACH_TINH.Name = "CACH_TINH"
        Me.CACH_TINH.OptionsColumn.AllowEdit = False
        Me.CACH_TINH.OptionsColumn.FixedWidth = True
        Me.CACH_TINH.OptionsColumn.ReadOnly = True
        Me.CACH_TINH.Visible = True
        Me.CACH_TINH.VisibleIndex = 3
        Me.CACH_TINH.Width = 192
        '
        'CHI_TIEU_2
        '
        Me.CHI_TIEU_2.Caption = "Chỉ tiêu 2"
        Me.CHI_TIEU_2.FieldName = "ChiTieu2"
        Me.CHI_TIEU_2.Name = "CHI_TIEU_2"
        Me.CHI_TIEU_2.OptionsColumn.AllowEdit = False
        Me.CHI_TIEU_2.OptionsColumn.FixedWidth = True
        Me.CHI_TIEU_2.OptionsColumn.ReadOnly = True
        Me.CHI_TIEU_2.Visible = True
        Me.CHI_TIEU_2.VisibleIndex = 4
        Me.CHI_TIEU_2.Width = 247
        '
        'DK_MA_TK
        '
        Me.DK_MA_TK.Caption = "Tài khoản"
        Me.DK_MA_TK.FieldName = "DkMaTk"
        Me.DK_MA_TK.Name = "DK_MA_TK"
        Me.DK_MA_TK.OptionsColumn.AllowEdit = False
        Me.DK_MA_TK.OptionsColumn.ReadOnly = True
        Me.DK_MA_TK.Visible = True
        Me.DK_MA_TK.VisibleIndex = 5
        Me.DK_MA_TK.Width = 118
        '
        'DK_MA_TK_DU
        '
        Me.DK_MA_TK_DU.Caption = "Tài khoản đối ứng"
        Me.DK_MA_TK_DU.FieldName = "DkMaTkDu"
        Me.DK_MA_TK_DU.Name = "DK_MA_TK_DU"
        Me.DK_MA_TK_DU.OptionsColumn.AllowEdit = False
        Me.DK_MA_TK_DU.OptionsColumn.ReadOnly = True
        Me.DK_MA_TK_DU.Visible = True
        Me.DK_MA_TK_DU.VisibleIndex = 6
        Me.DK_MA_TK_DU.Width = 156
        '
        'HAM_TINH_1
        '
        Me.HAM_TINH_1.Caption = "Hàm tính"
        Me.HAM_TINH_1.FieldName = "HamTinh"
        Me.HAM_TINH_1.Name = "HAM_TINH_1"
        Me.HAM_TINH_1.OptionsColumn.AllowEdit = False
        Me.HAM_TINH_1.OptionsColumn.ReadOnly = True
        Me.HAM_TINH_1.Visible = True
        Me.HAM_TINH_1.VisibleIndex = 7
        Me.HAM_TINH_1.Width = 133
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
        Me.PanelControl1.TabIndex = 2
        '
        'btnImport
        '
        Me.btnImport.ImageIndex = 2
        Me.btnImport.Location = New System.Drawing.Point(344, 6)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 30)
        Me.btnImport.TabIndex = 11
        Me.btnImport.Text = "&Nhập dữ liệu"
        '
        'btnExport
        '
        Me.btnExport.ImageIndex = 2
        Me.btnExport.Location = New System.Drawing.Point(258, 6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(80, 30)
        Me.btnExport.TabIndex = 10
        Me.btnExport.Text = "&Xuất dữ liệu"
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
        'frmKhaiBaoChiTieu_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmKhaiBaoChiTieu_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khai báo chỉ tiêu"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grc_ChiTieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv_ChiTieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grc_ChiTieu As DevExpress.XtraGrid.GridControl
    Friend WithEvents grv_ChiTieu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents STT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CHI_TIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CACH_TINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CHI_TIEU_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KIEU_CHU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IN_DONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DK_MA_TK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DK_MA_TK_DU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HAM_TINH_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
End Class
