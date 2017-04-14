Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucPhuongThucQuanTri_ChiTiet
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
        Me.txtMA_TK = New DevExpress.XtraEditors.TextEdit
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtTEN_PTQT = New DevExpress.XtraEditors.TextEdit
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cboPTQT_ID_CHA = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMA_TK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_PTQT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_TK)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl7)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_PTQT)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboPTQT_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.Padding = New System.Windows.Forms.Padding(4)
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(404, 201)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'txtMA_TK
        '
        Me.txtMA_TK.EnterMoveNextControl = True
        Me.txtMA_TK.Location = New System.Drawing.Point(178, 65)
        Me.txtMA_TK.Name = "txtMA_TK"
        Me.txtMA_TK.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_TK.TabIndex = 2
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(178, 117)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(200, 45)
        Me.txtMO_TA.TabIndex = 4
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(100, 69)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(61, 13)
        Me.labelControl7.TabIndex = 8
        Me.labelControl7.Text = "Mã tài khoản"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(134, 133)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(27, 13)
        Me.labelControl6.TabIndex = 10
        Me.labelControl6.Text = "Mô tả"
        '
        'txtTEN_PTQT
        '
        Me.txtTEN_PTQT.EnterMoveNextControl = True
        Me.txtTEN_PTQT.Location = New System.Drawing.Point(178, 39)
        Me.txtTEN_PTQT.Name = "txtTEN_PTQT"
        Me.txtTEN_PTQT.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_PTQT.TabIndex = 1
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(178, 13)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(200, 20)
        Me.txtKY_HIEU.TabIndex = 0
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(176, 168)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(202, 19)
        Me.chkCO_SU_DUNG.TabIndex = 5
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(22, 94)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(139, 13)
        Me.LabelControl17.TabIndex = 9
        Me.LabelControl17.Text = "Mã phương thức quản trị cha"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(106, 171)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 11
        Me.labelControl4.Text = "Có sử dụng"
        '
        'cboPTQT_ID_CHA
        '
        Me.cboPTQT_ID_CHA.AllowDrop = True
        Me.cboPTQT_ID_CHA.EditValue = "0"
        Me.cboPTQT_ID_CHA.EnterMoveNextControl = True
        Me.cboPTQT_ID_CHA.Location = New System.Drawing.Point(178, 91)
        Me.cboPTQT_ID_CHA.Name = "cboPTQT_ID_CHA"
        Me.cboPTQT_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboPTQT_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboPTQT_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboPTQT_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboPTQT_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQT_ID_CHA.Properties.ImmediatePopup = True
        Me.cboPTQT_ID_CHA.Properties.NullText = ""
        Me.cboPTQT_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboPTQT_ID_CHA.Size = New System.Drawing.Size(200, 20)
        Me.cboPTQT_ID_CHA.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(38, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Tên phương thức quản trị"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(126, 16)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 6
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
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
        Me._ActionPanel.Location = New System.Drawing.Point(4, 205)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(404, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(324, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(156, 0)
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
        Me.btnSave.Location = New System.Drawing.Point(0, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucPhuongThucQuanTri_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(412, 243)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucPhuongThucQuanTri_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục phương thức quản trị"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMA_TK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_PTQT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend cboPTQT_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Private txtTEN_PTQT As DevExpress.XtraEditors.TextEdit
    Friend labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend labelControl7 As DevExpress.XtraEditors.LabelControl
    Private txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Private txtMA_TK As DevExpress.XtraEditors.TextEdit
    Friend btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend btnClear As DevExpress.XtraEditors.SimpleButton
    Friend btnSave As DevExpress.XtraEditors.SimpleButton
End Class
