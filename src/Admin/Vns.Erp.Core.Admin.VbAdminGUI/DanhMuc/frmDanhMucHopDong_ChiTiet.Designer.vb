Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucHopDong_ChiTiet
    Inherits FrmBaseDmChiTiet
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me.cboHOPDONG_ID_CHA = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTEN_HOPDONG = New DevExpress.XtraEditors.TextEdit()
        Me.txtKy_Hieu = New DevExpress.XtraEditors.TextEdit()
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit()
        Me.cboTEN_LOAI_HOPDONG1 = New DevExpress.XtraEditors.LookUpEdit()
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtETA = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDiaLy = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboHOPDONG_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_HOPDONG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTEN_LOAI_HOPDONG1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtETA.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtETA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDiaLy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.PanelControl1)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(5, 362)
        Me._ActionPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(495, 47)
        Me._ActionPanel.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, -2)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(495, 49)
        Me.PanelControl1.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(300, 9)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(200, 9)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 37)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(100, 9)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 37)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(85, 18)
        Me.lblCarFarmily_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(45, 17)
        Me.lblCarFarmily_Code.TabIndex = 6
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(49, 49)
        Me.lblValue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(87, 17)
        Me.lblValue.TabIndex = 7
        Me.lblValue.Text = "Tên hợp đồng"
        '
        'cboHOPDONG_ID_CHA
        '
        Me.cboHOPDONG_ID_CHA.AllowDrop = True
        Me.cboHOPDONG_ID_CHA.EditValue = "0"
        Me.cboHOPDONG_ID_CHA.EnterMoveNextControl = True
        Me.cboHOPDONG_ID_CHA.Location = New System.Drawing.Point(149, 136)
        Me.cboHOPDONG_ID_CHA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboHOPDONG_ID_CHA.Name = "cboHOPDONG_ID_CHA"
        Me.cboHOPDONG_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboHOPDONG_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboHOPDONG_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboHOPDONG_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboHOPDONG_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHOPDONG_ID_CHA.Properties.ImmediatePopup = True
        Me.cboHOPDONG_ID_CHA.Properties.NullText = ""
        Me.cboHOPDONG_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboHOPDONG_ID_CHA.Size = New System.Drawing.Size(268, 22)
        Me.cboHOPDONG_ID_CHA.TabIndex = 4
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(27, 172)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(110, 17)
        Me.LabelControl16.TabIndex = 9
        Me.LabelControl16.Text = "Tên loại hợp đồng"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(62, 300)
        Me.labelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(72, 17)
        Me.labelControl4.TabIndex = 11
        Me.labelControl4.Text = "Có sử dụng"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(38, 139)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(101, 17)
        Me.LabelControl17.TabIndex = 8
        Me.LabelControl17.Text = "Nhóm hợp đồng"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(94, 216)
        Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(34, 17)
        Me.labelControl1.TabIndex = 10
        Me.labelControl1.Text = "Mô tả"
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(145, 297)
        Me.chkCO_SU_DUNG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(23, 21)
        Me.chkCO_SU_DUNG.TabIndex = 7
        '
        'txtTEN_HOPDONG
        '
        Me.txtTEN_HOPDONG.EnterMoveNextControl = True
        Me.txtTEN_HOPDONG.Location = New System.Drawing.Point(149, 46)
        Me.txtTEN_HOPDONG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTEN_HOPDONG.Name = "txtTEN_HOPDONG"
        Me.txtTEN_HOPDONG.Size = New System.Drawing.Size(268, 22)
        Me.txtTEN_HOPDONG.TabIndex = 1
        '
        'txtKy_Hieu
        '
        Me.txtKy_Hieu.EnterMoveNextControl = True
        Me.txtKy_Hieu.Location = New System.Drawing.Point(149, 15)
        Me.txtKy_Hieu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKy_Hieu.Name = "txtKy_Hieu"
        Me.txtKy_Hieu.Size = New System.Drawing.Size(268, 22)
        Me.txtKy_Hieu.TabIndex = 0
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(149, 201)
        Me.txtMO_TA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(268, 89)
        Me.txtMO_TA.TabIndex = 6
        '
        'cboTEN_LOAI_HOPDONG1
        '
        Me.cboTEN_LOAI_HOPDONG1.AllowDrop = True
        Me.cboTEN_LOAI_HOPDONG1.EditValue = "0"
        Me.cboTEN_LOAI_HOPDONG1.EnterMoveNextControl = True
        Me.cboTEN_LOAI_HOPDONG1.Location = New System.Drawing.Point(149, 169)
        Me.cboTEN_LOAI_HOPDONG1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTEN_LOAI_HOPDONG1.Name = "cboTEN_LOAI_HOPDONG1"
        Me.cboTEN_LOAI_HOPDONG1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboTEN_LOAI_HOPDONG1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboTEN_LOAI_HOPDONG1.Properties.Appearance.Options.UseBackColor = True
        Me.cboTEN_LOAI_HOPDONG1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboTEN_LOAI_HOPDONG1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTEN_LOAI_HOPDONG1.Properties.ImmediatePopup = True
        Me.cboTEN_LOAI_HOPDONG1.Properties.NullText = ""
        Me.cboTEN_LOAI_HOPDONG1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboTEN_LOAI_HOPDONG1.Size = New System.Drawing.Size(268, 22)
        Me.cboTEN_LOAI_HOPDONG1.TabIndex = 5
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtETA)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboDiaLy)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboTEN_LOAI_HOPDONG1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKy_Hieu)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_HOPDONG)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl16)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboHOPDONG_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(5, 5)
        Me._GroupControlObjectInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(495, 357)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(107, 109)
        Me.labelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(23, 16)
        Me.labelControl6.TabIndex = 24
        Me.labelControl6.Text = "ETA"
        '
        'txtETA
        '
        Me.txtETA.EditValue = Nothing
        Me.txtETA.EnterMoveNextControl = True
        Me.txtETA.Location = New System.Drawing.Point(149, 106)
        Me.txtETA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtETA.Name = "txtETA"
        Me.txtETA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtETA.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtETA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtETA.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtETA.Size = New System.Drawing.Size(268, 22)
        Me.txtETA.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(99, 79)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Cảng"
        '
        'cboDiaLy
        '
        Me.cboDiaLy.AllowDrop = True
        Me.cboDiaLy.EditValue = "0"
        Me.cboDiaLy.EnterMoveNextControl = True
        Me.cboDiaLy.Location = New System.Drawing.Point(149, 76)
        Me.cboDiaLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDiaLy.Name = "cboDiaLy"
        Me.cboDiaLy.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboDiaLy.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboDiaLy.Properties.Appearance.Options.UseBackColor = True
        Me.cboDiaLy.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboDiaLy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDiaLy.Properties.ImmediatePopup = True
        Me.cboDiaLy.Properties.NullText = ""
        Me.cboDiaLy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboDiaLy.Size = New System.Drawing.Size(268, 22)
        Me.cboDiaLy.TabIndex = 2
        '
        'frmDanhMucHopDong_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(505, 414)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucHopDong_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục hợp đồng"
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cboHOPDONG_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_HOPDONG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTEN_LOAI_HOPDONG1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtETA.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtETA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDiaLy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboHOPDONG_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private WithEvents txtTEN_HOPDONG As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtKy_Hieu As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboTEN_LOAI_HOPDONG1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDiaLy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtETA As DevExpress.XtraEditors.DateEdit
End Class
