Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucDonViTinh_ChiTiet
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
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl()
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_DVT = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_DVT = New DevExpress.XtraEditors.TextEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_DVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_DVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_DVT)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_DVT)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(348, 165)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(102, 93)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(230, 41)
        Me.txtMO_TA.TabIndex = 3
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(102, 38)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(230, 20)
        Me.txtKY_HIEU.TabIndex = 1
        '
        'txtTEN_DVT
        '
        Me.txtTEN_DVT.EnterMoveNextControl = True
        Me.txtTEN_DVT.Location = New System.Drawing.Point(102, 67)
        Me.txtTEN_DVT.Name = "txtTEN_DVT"
        Me.txtTEN_DVT.Size = New System.Drawing.Size(230, 20)
        Me.txtTEN_DVT.TabIndex = 2
        '
        'txtMA_DVT
        '
        Me.txtMA_DVT.EnterMoveNextControl = True
        Me.txtMA_DVT.Location = New System.Drawing.Point(102, 12)
        Me.txtMA_DVT.Name = "txtMA_DVT"
        Me.txtMA_DVT.Size = New System.Drawing.Size(230, 20)
        Me.txtMA_DVT.TabIndex = 0
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(100, 140)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(31, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(262, 140)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(27, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 5
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(55, 95)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(27, 13)
        Me.labelControl1.TabIndex = 9
        Me.labelControl1.Text = "Mô tả"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(47, 43)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl17.TabIndex = 7
        Me.LabelControl17.Text = "Ký hiệu"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(27, 141)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 10
        Me.labelControl4.Text = "Có sử dụng"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(159, 143)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 11
        Me.labelControl3.Text = "Cho phép sửa"
        Me.labelControl3.Visible = False
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(15, 15)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(67, 13)
        Me.lblValue.TabIndex = 6
        Me.lblValue.Text = "Mã đơn vị tính"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(11, 68)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(71, 13)
        Me.lblCarFarmily_Code.TabIndex = 8
        Me.lblCarFarmily_Code.Text = "Tên đơn vị tính"
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
        Me._ActionPanel.Location = New System.Drawing.Point(4, 168)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(348, 40)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(228, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(142, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(56, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucDonViTinh_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(356, 212)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucDonViTinh_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục đơn vị tính"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_DVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_DVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private txtMA_DVT As DevExpress.XtraEditors.TextEdit
    Private txtTEN_DVT As DevExpress.XtraEditors.TextEdit
    Private txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend btnClear As DevExpress.XtraEditors.SimpleButton
    Friend btnSave As DevExpress.XtraEditors.SimpleButton
End Class
