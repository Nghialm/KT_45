

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLS_TyGiaNgoaiTe_ChiTiet
    Inherits FrmBaseDmChiTiet

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
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.dteNgay = New DevExpress.XtraEditors.DateEdit
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtSO_TIEN_QUYDOI = New DevExpress.XtraEditors.TextEdit
        Me.cboTG = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grlNGOAITE_ID = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MA_NTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TY_GIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_NTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KY_HIEU = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.dteNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtSO_TIEN_QUYDOI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlNGOAITE_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(6, 120)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(325, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(245, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(16, 63)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(71, 13)
        Me.labelControl7.TabIndex = 26
        Me.labelControl7.Text = "Tiền hạch toán"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(28, 10)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(59, 13)
        Me.labelControl6.TabIndex = 22
        Me.labelControl6.Text = "Ngày qui đổi"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(25, 37)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl17.TabIndex = 24
        Me.LabelControl17.Text = "Tiền ngoại tệ"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(20, 89)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl16.TabIndex = 28
        Me.LabelControl16.Text = "Số tiền qui đổi"
        '
        'dteNgay
        '
        Me.dteNgay.EditValue = Nothing
        Me.dteNgay.EnterMoveNextControl = True
        Me.dteNgay.Location = New System.Drawing.Point(107, 7)
        Me.dteNgay.Name = "dteNgay"
        Me.dteNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNgay.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteNgay.Size = New System.Drawing.Size(200, 20)
        Me.dteNgay.TabIndex = 0
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtSO_TIEN_QUYDOI)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboTG)
        Me._GroupControlObjectInfo.Controls.Add(Me.grlNGOAITE_ID)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.dteNgay)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl7)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl16)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(6, 6)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(325, 114)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'txtSO_TIEN_QUYDOI
        '
        Me.txtSO_TIEN_QUYDOI.EnterMoveNextControl = True
        Me.txtSO_TIEN_QUYDOI.Location = New System.Drawing.Point(107, 87)
        Me.txtSO_TIEN_QUYDOI.Name = "txtSO_TIEN_QUYDOI"
        Me.txtSO_TIEN_QUYDOI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSO_TIEN_QUYDOI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSO_TIEN_QUYDOI.Properties.Mask.EditMask = "n0"
        Me.txtSO_TIEN_QUYDOI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSO_TIEN_QUYDOI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSO_TIEN_QUYDOI.Size = New System.Drawing.Size(200, 20)
        Me.txtSO_TIEN_QUYDOI.TabIndex = 3
        '
        'cboTG
        '
        Me.cboTG.EnterMoveNextControl = True
        Me.cboTG.Location = New System.Drawing.Point(107, 61)
        Me.cboTG.Name = "cboTG"
        Me.cboTG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTG.Properties.NullText = ""
        Me.cboTG.Properties.View = Me.GridView1
        Me.cboTG.Size = New System.Drawing.Size(200, 20)
        Me.cboTG.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'grlNGOAITE_ID
        '
        Me.grlNGOAITE_ID.EnterMoveNextControl = True
        Me.grlNGOAITE_ID.Location = New System.Drawing.Point(107, 34)
        Me.grlNGOAITE_ID.Name = "grlNGOAITE_ID"
        Me.grlNGOAITE_ID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlNGOAITE_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlNGOAITE_ID.Properties.NullText = ""
        Me.grlNGOAITE_ID.Properties.View = Me.GridLookUpEdit1View
        Me.grlNGOAITE_ID.Size = New System.Drawing.Size(200, 20)
        Me.grlNGOAITE_ID.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_NTE, Me.TY_GIA, Me.TEN_NTE, Me.KY_HIEU})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã ngoại tệ"
        Me.GridColumn1.FieldName = "MA_NTE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tỷ giá"
        Me.GridColumn2.FieldName = "TY_GIA"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên ngoại tệ"
        Me.GridColumn3.FieldName = "TEN_NTE"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ký hiệu"
        Me.GridColumn4.FieldName = "KY_HIEU"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'MA_NTE
        '
        Me.MA_NTE.Caption = "Mã ngoại tệ"
        Me.MA_NTE.FieldName = "MA_NTE"
        Me.MA_NTE.Name = "MA_NTE"
        Me.MA_NTE.Visible = True
        Me.MA_NTE.VisibleIndex = 0
        '
        'TY_GIA
        '
        Me.TY_GIA.Caption = "Tỷ giá"
        Me.TY_GIA.FieldName = "TY_GIA"
        Me.TY_GIA.Name = "TY_GIA"
        Me.TY_GIA.Visible = True
        Me.TY_GIA.VisibleIndex = 1
        '
        'TEN_NTE
        '
        Me.TEN_NTE.Caption = "Tên ngoại tệ"
        Me.TEN_NTE.FieldName = "TEN_NTE"
        Me.TEN_NTE.Name = "TEN_NTE"
        Me.TEN_NTE.Visible = True
        Me.TEN_NTE.VisibleIndex = 2
        '
        'KY_HIEU
        '
        Me.KY_HIEU.Caption = "Ký hiệu"
        Me.KY_HIEU.FieldName = "KY_HIEU"
        Me.KY_HIEU.Name = "KY_HIEU"
        Me.KY_HIEU.Visible = True
        Me.KY_HIEU.VisibleIndex = 3
        '
        'frmLS_TyGiaNgoaiTe_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 160)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLS_TyGiaNgoaiTe_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "Lịch sử tỷ giá ngoại tệ"
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.dteNgay.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtSO_TIEN_QUYDOI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlNGOAITE_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grlNGOAITE_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MA_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSO_TIEN_QUYDOI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTG As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
