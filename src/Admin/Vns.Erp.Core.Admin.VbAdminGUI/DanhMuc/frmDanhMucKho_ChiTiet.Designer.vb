Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucKho_ChiTiet
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
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.chkXUAT_AM = New DevExpress.XtraEditors.CheckEdit
        Me.cboLOAI_KHO = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtDIA_CHI = New DevExpress.XtraEditors.MemoEdit
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit
        Me.txtTEN_KHO = New DevExpress.XtraEditors.TextEdit
        Me.lblValue = New DevExpress.XtraEditors.LabelControl
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.chkXUAT_AM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLOAI_KHO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl5)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkXUAT_AM)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboLOAI_KHO)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtDIA_CHI)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_KHO)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(363, 166)
        Me._GroupControlObjectInfo.TabIndex = 2
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(143, 139)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl5.TabIndex = 87
        Me.LabelControl5.Text = "Cho phép xuất âm"
        '
        'chkXUAT_AM
        '
        Me.chkXUAT_AM.EditValue = True
        Me.chkXUAT_AM.Location = New System.Drawing.Point(237, 136)
        Me.chkXUAT_AM.Name = "chkXUAT_AM"
        Me.chkXUAT_AM.Properties.Caption = ""
        Me.chkXUAT_AM.Size = New System.Drawing.Size(19, 19)
        Me.chkXUAT_AM.TabIndex = 86
        '
        'cboLOAI_KHO
        '
        Me.cboLOAI_KHO.EditValue = "0"
        Me.cboLOAI_KHO.EnterMoveNextControl = True
        Me.cboLOAI_KHO.Location = New System.Drawing.Point(85, 59)
        Me.cboLOAI_KHO.Name = "cboLOAI_KHO"
        Me.cboLOAI_KHO.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboLOAI_KHO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAI_KHO.Properties.ImmediatePopup = True
        Me.cboLOAI_KHO.Properties.NullText = ""
        Me.cboLOAI_KHO.Size = New System.Drawing.Size(264, 20)
        Me.cboLOAI_KHO.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 85
        Me.LabelControl2.Text = "Loại kho"
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(85, 85)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.Size = New System.Drawing.Size(264, 45)
        Me.txtDIA_CHI.TabIndex = 3
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(85, 8)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(101, 20)
        Me.txtKY_HIEU.TabIndex = 0
        '
        'txtTEN_KHO
        '
        Me.txtTEN_KHO.EnterMoveNextControl = True
        Me.txtTEN_KHO.Location = New System.Drawing.Point(85, 33)
        Me.txtTEN_KHO.Name = "txtTEN_KHO"
        Me.txtTEN_KHO.Size = New System.Drawing.Size(264, 20)
        Me.txtTEN_KHO.TabIndex = 1
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(30, 36)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(38, 13)
        Me.lblValue.TabIndex = 41
        Me.lblValue.Text = "Tên kho"
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(83, 137)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(19, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(34, 87)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(32, 13)
        Me.labelControl1.TabIndex = 83
        Me.labelControl1.Text = "Địa chỉ"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(33, 11)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl17.TabIndex = 83
        Me.LabelControl17.Text = "Ký hiệu"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(13, 138)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 79
        Me.labelControl4.Text = "Có sử dụng"
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(524, 10)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(19, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 3
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(549, 13)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 5
        Me.labelControl3.Text = "Cho phép sửa"
        Me.labelControl3.Visible = False
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._ActionPanel.Controls.Add(Me.labelControl3)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 170)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me._ActionPanel.Size = New System.Drawing.Size(363, 34)
        Me._ActionPanel.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(283, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(141, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucKho_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(371, 208)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.Name = "frmDanhMucKho_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục kho"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.chkXUAT_AM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLOAI_KHO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me._ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private txtTEN_KHO As DevExpress.XtraEditors.TextEdit
    Private txtDIA_CHI As DevExpress.XtraEditors.MemoEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLOAI_KHO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents chkXUAT_AM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
