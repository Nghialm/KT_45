Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucThue_ChiTiet
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
        Me.chkCHI_TIET = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkXUAT_KHAU = New DevExpress.XtraEditors.CheckEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_THUE = New DevExpress.XtraEditors.TextEdit()
        Me.txtTY_LE = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_THUE = New DevExpress.XtraEditors.TextEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTHUE_ID_CHA = New DevExpress.XtraEditors.LookUpEdit()
        Me.Color = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.chkMuaHang = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkXUAT_KHAU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_THUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_LE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_THUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTHUE_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.chkMuaHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.chkMuaHang)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHI_TIET)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl5)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkXUAT_KHAU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_THUE)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTY_LE)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_THUE)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboTHUE_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.Color)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(6, 6)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.Padding = New System.Windows.Forms.Padding(4)
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(310, 199)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'chkCHI_TIET
        '
        Me.chkCHI_TIET.EditValue = True
        Me.chkCHI_TIET.Location = New System.Drawing.Point(175, 144)
        Me.chkCHI_TIET.Name = "chkCHI_TIET"
        Me.chkCHI_TIET.Properties.Caption = ""
        Me.chkCHI_TIET.Size = New System.Drawing.Size(27, 19)
        Me.chkCHI_TIET.TabIndex = 6
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(135, 147)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(34, 13)
        Me.labelControl5.TabIndex = 12
        Me.labelControl5.Text = "Chi tiết"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(27, 148)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(48, 13)
        Me.labelControl1.TabIndex = 10
        Me.labelControl1.Text = "Xuất khẩu"
        '
        'chkXUAT_KHAU
        '
        Me.chkXUAT_KHAU.EditValue = True
        Me.chkXUAT_KHAU.Location = New System.Drawing.Point(92, 144)
        Me.chkXUAT_KHAU.Name = "chkXUAT_KHAU"
        Me.chkXUAT_KHAU.Properties.Caption = ""
        Me.chkXUAT_KHAU.Size = New System.Drawing.Size(26, 19)
        Me.chkXUAT_KHAU.TabIndex = 5
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(94, 61)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(200, 20)
        Me.txtKY_HIEU.TabIndex = 2
        '
        'txtTEN_THUE
        '
        Me.txtTEN_THUE.EnterMoveNextControl = True
        Me.txtTEN_THUE.Location = New System.Drawing.Point(94, 35)
        Me.txtTEN_THUE.Name = "txtTEN_THUE"
        Me.txtTEN_THUE.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_THUE.TabIndex = 1
        '
        'txtTY_LE
        '
        Me.txtTY_LE.EnterMoveNextControl = True
        Me.txtTY_LE.Location = New System.Drawing.Point(94, 89)
        Me.txtTY_LE.Name = "txtTY_LE"
        Me.txtTY_LE.Properties.Mask.EditMask = "n2"
        Me.txtTY_LE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_LE.Properties.MaxLength = 3
        Me.txtTY_LE.Size = New System.Drawing.Size(200, 20)
        Me.txtTY_LE.TabIndex = 3
        '
        'txtMA_THUE
        '
        Me.txtMA_THUE.EnterMoveNextControl = True
        Me.txtMA_THUE.Location = New System.Drawing.Point(94, 9)
        Me.txtMA_THUE.Name = "txtMA_THUE"
        Me.txtMA_THUE.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_THUE.TabIndex = 0
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(277, 142)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(26, 19)
        Me.chkCO_SU_DUNG.TabIndex = 7
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 120)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl17.TabIndex = 8
        Me.LabelControl17.Text = "Mã thuế cha"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(216, 146)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 14
        Me.labelControl4.Text = "Có sử dụng"
        '
        'cboTHUE_ID_CHA
        '
        Me.cboTHUE_ID_CHA.AllowDrop = True
        Me.cboTHUE_ID_CHA.EditValue = "0"
        Me.cboTHUE_ID_CHA.EnterMoveNextControl = True
        Me.cboTHUE_ID_CHA.Location = New System.Drawing.Point(94, 116)
        Me.cboTHUE_ID_CHA.Name = "cboTHUE_ID_CHA"
        Me.cboTHUE_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboTHUE_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboTHUE_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboTHUE_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboTHUE_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTHUE_ID_CHA.Properties.ImmediatePopup = True
        Me.cboTHUE_ID_CHA.Properties.NullText = ""
        Me.cboTHUE_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboTHUE_ID_CHA.Size = New System.Drawing.Size(200, 20)
        Me.cboTHUE_ID_CHA.TabIndex = 4
        '
        'Color
        '
        Me.Color.Location = New System.Drawing.Point(52, 93)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(23, 13)
        Me.Color.TabIndex = 6
        Me.Color.Text = "Tỷ lệ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Tên thuế"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(36, 13)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(39, 13)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Mã thuế"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(40, 65)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 4
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(170, -3)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(22, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 8
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(86, 0)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 16
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
        Me._ActionPanel.Controls.Add(Me.labelControl3)
        Me._ActionPanel.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(6, 205)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(4)
        Me._ActionPanel.Size = New System.Drawing.Size(310, 38)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(230, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Đ&óng"
        '
        'btnClear
        '
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(122, 8)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'chkMuaHang
        '
        Me.chkMuaHang.EditValue = True
        Me.chkMuaHang.Location = New System.Drawing.Point(92, 163)
        Me.chkMuaHang.Name = "chkMuaHang"
        Me.chkMuaHang.Properties.Caption = ""
        Me.chkMuaHang.Size = New System.Drawing.Size(26, 19)
        Me.chkMuaHang.TabIndex = 15
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(31, 167)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Mua hàng"
        '
        'frmDanhMucThue_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(322, 249)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucThue_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục thuế"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkXUAT_KHAU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_THUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_LE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_THUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTHUE_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me._ActionPanel.PerformLayout()
        CType(Me.chkMuaHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend cboTHUE_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend Color As DevExpress.XtraEditors.LabelControl
    Friend LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private txtMA_THUE As DevExpress.XtraEditors.TextEdit
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Private txtTY_LE As DevExpress.XtraEditors.TextEdit
    Private txtTEN_THUE As DevExpress.XtraEditors.TextEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Private chkCHI_TIET As DevExpress.XtraEditors.CheckEdit
    Friend labelControl5 As DevExpress.XtraEditors.LabelControl
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private chkXUAT_KHAU As DevExpress.XtraEditors.CheckEdit
    Friend btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend btnClear As DevExpress.XtraEditors.SimpleButton
    Friend btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents chkMuaHang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
