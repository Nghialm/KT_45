

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMucLoaiTaiSan1_ChiTiet
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
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtKy_Hieu = New DevExpress.XtraEditors.TextEdit
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl
        Me.txtKHUNG_TGSD1 = New DevExpress.XtraEditors.TextEdit
        Me.txtTEN_LOAITAISAN = New DevExpress.XtraEditors.TextEdit
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lblValue = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.cboLOAITAISAN_ID_CHA = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TEN_LOAITAISAN = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKHUNG_TGSD1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_LOAITAISAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.cboLOAITAISAN_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.cboLOAITAISAN_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKy_Hieu)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKHUNG_TGSD1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_LOAITAISAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(317, 116)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh mục tự do 2"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(9, 90)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(77, 13)
        Me.labelControl1.TabIndex = 99
        Me.labelControl1.Text = "Số năm sử dụng"
        '
        'txtKy_Hieu
        '
        Me.txtKy_Hieu.EnterMoveNextControl = True
        Me.txtKy_Hieu.Location = New System.Drawing.Point(103, 9)
        Me.txtKy_Hieu.Name = "txtKy_Hieu"
        Me.txtKy_Hieu.Size = New System.Drawing.Size(200, 20)
        Me.txtKy_Hieu.TabIndex = 0
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(51, 12)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 98
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'txtKHUNG_TGSD1
        '
        Me.txtKHUNG_TGSD1.EnterMoveNextControl = True
        Me.txtKHUNG_TGSD1.Location = New System.Drawing.Point(103, 87)
        Me.txtKHUNG_TGSD1.Name = "txtKHUNG_TGSD1"
        Me.txtKHUNG_TGSD1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKHUNG_TGSD1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtKHUNG_TGSD1.Properties.Mask.EditMask = "n2"
        Me.txtKHUNG_TGSD1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtKHUNG_TGSD1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKHUNG_TGSD1.Size = New System.Drawing.Size(200, 20)
        Me.txtKHUNG_TGSD1.TabIndex = 3
        '
        'txtTEN_LOAITAISAN
        '
        Me.txtTEN_LOAITAISAN.EnterMoveNextControl = True
        Me.txtTEN_LOAITAISAN.Location = New System.Drawing.Point(103, 35)
        Me.txtTEN_LOAITAISAN.Name = "txtTEN_LOAITAISAN"
        Me.txtTEN_LOAITAISAN.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_LOAITAISAN.TabIndex = 1
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(101, 117)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(23, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(217, 117)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(23, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 5
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(19, 64)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl17.TabIndex = 97
        Me.LabelControl17.Text = "Danh mục cha"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(31, 119)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 96
        Me.labelControl4.Text = "Có sử dụng"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(140, 119)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 95
        Me.labelControl3.Text = "Cho phép sửa"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(11, 38)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(75, 13)
        Me.lblValue.TabIndex = 94
        Me.lblValue.Text = "Tên loại tài sản "
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(237, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(118, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 120)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(317, 38)
        Me._ActionPanel.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'cboLOAITAISAN_ID_CHA
        '
        Me.cboLOAITAISAN_ID_CHA.Location = New System.Drawing.Point(103, 62)
        Me.cboLOAITAISAN_ID_CHA.Name = "cboLOAITAISAN_ID_CHA"
        Me.cboLOAITAISAN_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboLOAITAISAN_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLOAITAISAN_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAITAISAN_ID_CHA.Properties.NullText = ""
        Me.cboLOAITAISAN_ID_CHA.Properties.View = Me.GridLookUpEdit1View
        Me.cboLOAITAISAN_ID_CHA.Size = New System.Drawing.Size(200, 20)
        Me.cboLOAITAISAN_ID_CHA.TabIndex = 100
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TEN_LOAITAISAN})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'TEN_LOAITAISAN
        '
        Me.TEN_LOAITAISAN.Caption = "Tên loại tài sản"
        Me.TEN_LOAITAISAN.FieldName = "TenLoaitaisan"
        Me.TEN_LOAITAISAN.Name = "TenLoaitaisan"
        Me.TEN_LOAITAISAN.Visible = True
        Me.TEN_LOAITAISAN.VisibleIndex = 0
        '
        'frmDanhMucLoaiTaiSan1_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 162)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucLoaiTaiSan1_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục tự do 1"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKHUNG_TGSD1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_LOAITAISAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.cboLOAITAISAN_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtKy_Hieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtTEN_LOAITAISAN As DevExpress.XtraEditors.TextEdit
    Private WithEvents chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private WithEvents chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValue As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtKHUNG_TGSD1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboLOAITAISAN_ID_CHA As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_LOAITAISAN As DevExpress.XtraGrid.Columns.GridColumn
End Class
