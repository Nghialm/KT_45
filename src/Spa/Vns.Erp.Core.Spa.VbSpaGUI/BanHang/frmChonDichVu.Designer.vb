<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChonDichVu
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
        Me.grcDichVu = New DevExpress.XtraGrid.GridControl
        Me.grvDichVu = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckeCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnQuayRa = New DevExpress.XtraEditors.SimpleButton
        Me.btnHoanThanh = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grcDichVu
        '
        Me.grcDichVu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcDichVu.Location = New System.Drawing.Point(2, 20)
        Me.grcDichVu.MainView = Me.grvDichVu
        Me.grcDichVu.Name = "grcDichVu"
        Me.grcDichVu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ckeCheck})
        Me.grcDichVu.Size = New System.Drawing.Size(682, 352)
        Me.grcDichVu.TabIndex = 0
        Me.grcDichVu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDichVu})
        '
        'grvDichVu
        '
        Me.grvDichVu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3})
        Me.grvDichVu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grvDichVu.GridControl = Me.grcDichVu
        Me.grvDichVu.Name = "grvDichVu"
        Me.grvDichVu.OptionsCustomization.AllowQuickHideColumns = False
        Me.grvDichVu.OptionsMenu.EnableColumnMenu = False
        Me.grvDichVu.OptionsMenu.EnableFooterMenu = False
        Me.grvDichVu.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvDichVu.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.grvDichVu.OptionsNavigation.AutoMoveRowFocus = False
        Me.grvDichVu.OptionsNavigation.UseTabKey = False
        Me.grvDichVu.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvDichVu.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "...."
        Me.GridColumn4.ColumnEdit = Me.ckeCheck
        Me.GridColumn4.FieldName = "Check"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowSize = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 31
        '
        'ckeCheck
        '
        Me.ckeCheck.AutoHeight = False
        Me.ckeCheck.Name = "ckeCheck"
        Me.ckeCheck.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ckeCheck.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã dịch vụ"
        Me.GridColumn1.FieldName = "MaDv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowSize = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 98
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ký hiệu"
        Me.GridColumn5.FieldName = "Kh"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowSize = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 113
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên dịch vụ"
        Me.GridColumn2.FieldName = "TenDv"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowSize = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 269
        '
        'GridColumn3
        '
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 150
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grcDichVu)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(686, 374)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh sách dịch vụ"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnQuayRa)
        Me.PanelControl1.Controls.Add(Me.btnHoanThanh)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 378)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(686, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'btnQuayRa
        '
        Me.btnQuayRa.Location = New System.Drawing.Point(606, 4)
        Me.btnQuayRa.Name = "btnQuayRa"
        Me.btnQuayRa.Size = New System.Drawing.Size(80, 30)
        Me.btnQuayRa.TabIndex = 2
        Me.btnQuayRa.Text = "Quay ra"
        '
        'btnHoanThanh
        '
        Me.btnHoanThanh.Location = New System.Drawing.Point(0, 4)
        Me.btnHoanThanh.Name = "btnHoanThanh"
        Me.btnHoanThanh.Size = New System.Drawing.Size(80, 30)
        Me.btnHoanThanh.TabIndex = 1
        Me.btnHoanThanh.Text = "Hoàn thành"
        '
        'frmChonDichVu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 416)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmChonDichVu"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn dịch vụ"
        CType(Me.grcDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grcDichVu As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDichVu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQuayRa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHoanThanh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckeCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
