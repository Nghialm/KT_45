Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucKhoanPhi_ChiTiet
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
        Me.txtMATK_LIENQUAN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMA_DM_KHOANPHI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTEN_DM_KHOANPHI = New DevExpress.XtraEditors.TextEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDM_KHOANPHI_ID_CHA = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtMATK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_DM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_DM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDM_KHOANPHI_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMATK_LIENQUAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_DM_KHOANPHI)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl16)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_DM_KHOANPHI)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboDM_KHOANPHI_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(345, 200)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh mục tự do 2"
        '
        'txtMATK_LIENQUAN
        '
        Me.txtMATK_LIENQUAN.EnterMoveNextControl = True
        Me.txtMATK_LIENQUAN.Location = New System.Drawing.Point(96, 90)
        Me.txtMATK_LIENQUAN.Name = "txtMATK_LIENQUAN"
        Me.txtMATK_LIENQUAN.Size = New System.Drawing.Size(230, 20)
        Me.txtMATK_LIENQUAN.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 93)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Mã tài khoản"
        '
        'txtMA_DM_KHOANPHI
        '
        Me.txtMA_DM_KHOANPHI.Enabled = False
        Me.txtMA_DM_KHOANPHI.EnterMoveNextControl = True
        Me.txtMA_DM_KHOANPHI.Location = New System.Drawing.Point(485, 12)
        Me.txtMA_DM_KHOANPHI.Name = "txtMA_DM_KHOANPHI"
        Me.txtMA_DM_KHOANPHI.Properties.ReadOnly = True
        Me.txtMA_DM_KHOANPHI.Size = New System.Drawing.Size(230, 20)
        Me.txtMA_DM_KHOANPHI.TabIndex = 0
        Me.txtMA_DM_KHOANPHI.Visible = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(407, 14)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl16.TabIndex = 6
        Me.LabelControl16.Text = "Mã khoản phí"
        Me.LabelControl16.Visible = False
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(96, 12)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Size = New System.Drawing.Size(230, 20)
        Me.txtKY_HIEU.TabIndex = 1
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(46, 16)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 7
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(96, 116)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(230, 54)
        Me.txtMO_TA.TabIndex = 5
        '
        'txtTEN_DM_KHOANPHI
        '
        Me.txtTEN_DM_KHOANPHI.EnterMoveNextControl = True
        Me.txtTEN_DM_KHOANPHI.Location = New System.Drawing.Point(96, 38)
        Me.txtTEN_DM_KHOANPHI.Name = "txtTEN_DM_KHOANPHI"
        Me.txtTEN_DM_KHOANPHI.Size = New System.Drawing.Size(230, 20)
        Me.txtTEN_DM_KHOANPHI.TabIndex = 2
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(94, 176)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(19, 19)
        Me.chkCO_SU_DUNG.TabIndex = 6
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(54, 118)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(27, 13)
        Me.labelControl1.TabIndex = 10
        Me.labelControl1.Text = "Mô tả"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(14, 67)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl17.TabIndex = 9
        Me.LabelControl17.Text = "Danh mục cha"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(26, 178)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 11
        Me.labelControl4.Text = "Có sử dụng"
        '
        'cboDM_KHOANPHI_ID_CHA
        '
        Me.cboDM_KHOANPHI_ID_CHA.AllowDrop = True
        Me.cboDM_KHOANPHI_ID_CHA.EditValue = "0"
        Me.cboDM_KHOANPHI_ID_CHA.EnterMoveNextControl = True
        Me.cboDM_KHOANPHI_ID_CHA.Location = New System.Drawing.Point(96, 64)
        Me.cboDM_KHOANPHI_ID_CHA.Name = "cboDM_KHOANPHI_ID_CHA"
        Me.cboDM_KHOANPHI_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboDM_KHOANPHI_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboDM_KHOANPHI_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboDM_KHOANPHI_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboDM_KHOANPHI_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDM_KHOANPHI_ID_CHA.Properties.ImmediatePopup = True
        Me.cboDM_KHOANPHI_ID_CHA.Properties.NullText = ""
        Me.cboDM_KHOANPHI_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboDM_KHOANPHI_ID_CHA.Size = New System.Drawing.Size(230, 20)
        Me.cboDM_KHOANPHI_ID_CHA.TabIndex = 3
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(14, 41)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(67, 13)
        Me.lblValue.TabIndex = 8
        Me.lblValue.Text = "Tên danh mục"
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 204)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(345, 34)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(264, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(1, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDanhMucKhoanPhi_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(353, 242)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucKhoanPhi_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục khoản phí"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtMATK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_DM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_DM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDM_KHOANPHI_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend cboDM_KHOANPHI_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private txtTEN_DM_KHOANPHI As DevExpress.XtraEditors.TextEdit
    Private txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend labelControl4 As DevExpress.XtraEditors.LabelControl
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMA_DM_KHOANPHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txtMATK_LIENQUAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
