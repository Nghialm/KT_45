<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KT_H_Baocao
    Inherits KTY_UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cboKTHBaoCao = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TITLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MA_BAOCAO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblTenKTBaoCao = New DevExpress.XtraEditors.LabelControl
        CType(Me.cboKTHBaoCao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Chọn loại báo cáo"
        '
        'cboKTHBaoCao
        '
        Me.cboKTHBaoCao.EnterMoveNextControl = True
        Me.cboKTHBaoCao.Location = New System.Drawing.Point(122, 3)
        Me.cboKTHBaoCao.Name = "cboKTHBaoCao"
        Me.cboKTHBaoCao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKTHBaoCao.Properties.NullText = ""
        Me.cboKTHBaoCao.Properties.View = Me.GridLookUpEdit1View
        Me.cboKTHBaoCao.Size = New System.Drawing.Size(184, 20)
        Me.cboKTHBaoCao.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TITLE, Me.MA_BAOCAO})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'TITLE
        '
        Me.TITLE.Caption = "Tên loại"
        Me.TITLE.FieldName = "Title"
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Visible = True
        Me.TITLE.VisibleIndex = 0
        '
        'MA_BAOCAO
        '
        Me.MA_BAOCAO.Caption = "Mã Báo cáo"
        Me.MA_BAOCAO.FieldName = "MaBaocao"
        Me.MA_BAOCAO.Name = "MA_BAOCAO"
        '
        'lblTenKTBaoCao
        '
        Me.lblTenKTBaoCao.Location = New System.Drawing.Point(318, 6)
        Me.lblTenKTBaoCao.Name = "lblTenKTBaoCao"
        Me.lblTenKTBaoCao.Size = New System.Drawing.Size(0, 13)
        Me.lblTenKTBaoCao.TabIndex = 2
        '
        'KT_H_Baocao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTenKTBaoCao)
        Me.Controls.Add(Me.cboKTHBaoCao)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "KT_H_Baocao"
        Me.Size = New System.Drawing.Size(520, 25)
        CType(Me.cboKTHBaoCao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboKTHBaoCao As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblTenKTBaoCao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_BAOCAO As DevExpress.XtraGrid.Columns.GridColumn

End Class
