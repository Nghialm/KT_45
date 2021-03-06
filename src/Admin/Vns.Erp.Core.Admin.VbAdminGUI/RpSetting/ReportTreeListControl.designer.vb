<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportTreeListControl
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
        Me.TreeListMain = New DevExpress.XtraTreeList.TreeList()
        Me.TEN_BAOCAO = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.MA_BAOCAO = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.lblChoose = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TreeListMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeListMain
        '
        Me.TreeListMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeListMain.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TEN_BAOCAO, Me.MA_BAOCAO})
        Me.TreeListMain.KeyFieldName = "Id"
        Me.TreeListMain.Location = New System.Drawing.Point(0, 22)
        Me.TreeListMain.Name = "TreeListMain"
        Me.TreeListMain.OptionsBehavior.Editable = False
        Me.TreeListMain.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.TreeListMain.OptionsView.ShowColumns = False
        Me.TreeListMain.ParentFieldName = "IdCha"
        Me.TreeListMain.Size = New System.Drawing.Size(328, 425)
        Me.TreeListMain.TabIndex = 0
        '
        'TEN_BAOCAO
        '
        Me.TEN_BAOCAO.Caption = "Tên báo cáo"
        Me.TEN_BAOCAO.FieldName = "TenBaocao"
        Me.TEN_BAOCAO.Name = "TEN_BAOCAO"
        Me.TEN_BAOCAO.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.TEN_BAOCAO.Visible = True
        Me.TEN_BAOCAO.VisibleIndex = 0
        '
        'MA_BAOCAO
        '
        Me.MA_BAOCAO.Caption = "TreeListColumn1"
        Me.MA_BAOCAO.FieldName = "MaBaocao"
        Me.MA_BAOCAO.Name = "MA_BAOCAO"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExit)
        Me.PanelControl1.Controls.Add(Me.btnSubmit)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 453)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(326, 42)
        Me.PanelControl1.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(234, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Hủy"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Location = New System.Drawing.Point(148, 7)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 30)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Đồng ý"
        '
        'lblChoose
        '
        Me.lblChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblChoose.Location = New System.Drawing.Point(4, 3)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(0, 13)
        Me.lblChoose.TabIndex = 1
        '
        'ReportTreeListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 495)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.TreeListMain)
        Me.KeyPreview = True
        Me.Name = "ReportTreeListControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục báo cáo"
        CType(Me.TreeListMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeListMain As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TEN_BAOCAO As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents MA_BAOCAO As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblChoose As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
End Class
