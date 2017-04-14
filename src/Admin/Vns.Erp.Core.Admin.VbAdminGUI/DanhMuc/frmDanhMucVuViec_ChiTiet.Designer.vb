Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucVuViec_ChiTiet
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
        Me.txtMA_TK_LIENQUAN = New DevExpress.XtraEditors.TextEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_VUVIEC = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_VUVIEC = New DevExpress.XtraEditors.TextEdit()
        Me.chkCO_SU_DUNG1 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMA_TK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_TK_LIENQUAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_VUVIEC)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_VUVIEC)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(410, 155)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'txtMA_TK_LIENQUAN
        '
        Me.txtMA_TK_LIENQUAN.EnterMoveNextControl = True
        Me.txtMA_TK_LIENQUAN.Location = New System.Drawing.Point(131, 92)
        Me.txtMA_TK_LIENQUAN.Name = "txtMA_TK_LIENQUAN"
        Me.txtMA_TK_LIENQUAN.Size = New System.Drawing.Size(257, 20)
        Me.txtMA_TK_LIENQUAN.TabIndex = 3
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(131, 37)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(257, 20)
        Me.txtKY_HIEU.TabIndex = 1
        '
        'txtMA_VUVIEC
        '
        Me.txtMA_VUVIEC.EnterMoveNextControl = True
        Me.txtMA_VUVIEC.Location = New System.Drawing.Point(131, 11)
        Me.txtMA_VUVIEC.Name = "txtMA_VUVIEC"
        Me.txtMA_VUVIEC.Size = New System.Drawing.Size(257, 20)
        Me.txtMA_VUVIEC.TabIndex = 0
        '
        'txtTEN_VUVIEC
        '
        Me.txtTEN_VUVIEC.EnterMoveNextControl = True
        Me.txtTEN_VUVIEC.Location = New System.Drawing.Point(131, 66)
        Me.txtTEN_VUVIEC.Name = "txtTEN_VUVIEC"
        Me.txtTEN_VUVIEC.Size = New System.Drawing.Size(257, 20)
        Me.txtTEN_VUVIEC.TabIndex = 2
        '
        'chkCO_SU_DUNG1
        '
        Me.chkCO_SU_DUNG1.EditValue = True
        Me.chkCO_SU_DUNG1.Location = New System.Drawing.Point(371, 125)
        Me.chkCO_SU_DUNG1.Name = "chkCO_SU_DUNG1"
        Me.chkCO_SU_DUNG1.Properties.Caption = ""
        Me.chkCO_SU_DUNG1.Size = New System.Drawing.Size(32, 19)
        Me.chkCO_SU_DUNG1.TabIndex = 5
        Me.chkCO_SU_DUNG1.Visible = False
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(126, 124)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(32, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(83, 40)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl17.TabIndex = 7
        Me.LabelControl17.Text = "Ký hiệu"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(63, 127)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 10
        Me.labelControl4.Text = "Có sử dụng"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(293, 126)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 11
        Me.labelControl3.Text = "Cho phép sửa"
        Me.labelControl3.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 97)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mã tài khoản liên quan"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(63, 73)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(55, 13)
        Me.lblValue.TabIndex = 8
        Me.lblValue.Text = "Tên vụ việc"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(67, 14)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(51, 13)
        Me.lblCarFarmily_Code.TabIndex = 6
        Me.lblCarFarmily_Code.Text = "Mã vụ việc"
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
        Me._ActionPanel.Location = New System.Drawing.Point(4, 159)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(410, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(330, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(159, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        Me.btnClear.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucVuViec_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(418, 197)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.Name = "frmDanhMucVuViec_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục vụ việc"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMA_TK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private txtTEN_VUVIEC As DevExpress.XtraEditors.TextEdit
    Private txtMA_VUVIEC As DevExpress.XtraEditors.TextEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private chkCO_SU_DUNG1 As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Private txtMA_TK_LIENQUAN As DevExpress.XtraEditors.TextEdit
    Friend btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend btnClear As DevExpress.XtraEditors.SimpleButton
    Friend btnSave As DevExpress.XtraEditors.SimpleButton
End Class
