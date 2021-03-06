Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucLyDoTGTSCD_ChiTiet
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
        Me.txtMA_LYDO_TG_TSCD = New DevExpress.XtraEditors.TextEdit
        Me.cboLOAI_LG1 = New DevExpress.XtraEditors.LookUpEdit
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTEN_LYDO_TG_TSCD = New DevExpress.XtraEditors.TextEdit
        Me.lblValue = New DevExpress.XtraEditors.LabelControl
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMA_LYDO_TG_TSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLOAI_LG1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_LYDO_TG_TSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_LYDO_TG_TSCD)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboLOAI_LG1)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_LYDO_TG_TSCD)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(6, 6)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(334, 143)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'txtMA_LYDO_TG_TSCD
        '
        Me.txtMA_LYDO_TG_TSCD.EnterMoveNextControl = True
        Me.txtMA_LYDO_TG_TSCD.Location = New System.Drawing.Point(119, 14)
        Me.txtMA_LYDO_TG_TSCD.Name = "txtMA_LYDO_TG_TSCD"
        Me.txtMA_LYDO_TG_TSCD.Properties.Mask.EditMask = "[a-zA-Z0-9_]+"
        Me.txtMA_LYDO_TG_TSCD.Properties.Mask.IgnoreMaskBlank = False
        Me.txtMA_LYDO_TG_TSCD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMA_LYDO_TG_TSCD.Properties.Mask.ShowPlaceHolders = False
        Me.txtMA_LYDO_TG_TSCD.Properties.MaxLength = 32
        Me.txtMA_LYDO_TG_TSCD.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_LYDO_TG_TSCD.TabIndex = 0
        '
        'cboLOAI_LG1
        '
        Me.cboLOAI_LG1.EnterMoveNextControl = True
        Me.cboLOAI_LG1.Location = New System.Drawing.Point(119, 92)
        Me.cboLOAI_LG1.Name = "cboLOAI_LG1"
        Me.cboLOAI_LG1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboLOAI_LG1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAI_LG1.Properties.ImmediatePopup = True
        Me.cboLOAI_LG1.Properties.NullText = ""
        Me.cboLOAI_LG1.Size = New System.Drawing.Size(200, 20)
        Me.cboLOAI_LG1.TabIndex = 3
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(83, 95)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(19, 13)
        Me.labelControl1.TabIndex = 8
        Me.labelControl1.Text = "Loại"
        '
        'txtTEN_LYDO_TG_TSCD
        '
        Me.txtTEN_LYDO_TG_TSCD.EnterMoveNextControl = True
        Me.txtTEN_LYDO_TG_TSCD.Location = New System.Drawing.Point(119, 40)
        Me.txtTEN_LYDO_TG_TSCD.Name = "txtTEN_LYDO_TG_TSCD"
        Me.txtTEN_LYDO_TG_TSCD.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_LYDO_TG_TSCD.TabIndex = 1
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(13, 43)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(89, 13)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "Tên lý do TG TSCD"
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(119, 66)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(200, 20)
        Me.txtKY_HIEU.TabIndex = 2
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(117, 118)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(79, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(67, 69)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl17.TabIndex = 6
        Me.LabelControl17.Text = "Ký hiệu"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(47, 121)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 4
        Me.labelControl4.Text = "Có sử dụng"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(17, 17)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(85, 13)
        Me.lblCarFarmily_Code.TabIndex = 0
        Me.lblCarFarmily_Code.Text = "Mă lý do TG TSCD"
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
        Me._ActionPanel.Location = New System.Drawing.Point(6, 149)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(334, 40)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(254, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(119, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucLyDoTGTSCD_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(346, 195)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucLyDoTGTSCD_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục lý do tăng giảm tài sản cố định"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMA_LYDO_TG_TSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLOAI_LG1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_LYDO_TG_TSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Private txtTEN_LYDO_TG_TSCD As DevExpress.XtraEditors.TextEdit
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend cboLOAI_LG1 As DevExpress.XtraEditors.LookUpEdit
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private txtMA_LYDO_TG_TSCD As DevExpress.XtraEditors.TextEdit
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
