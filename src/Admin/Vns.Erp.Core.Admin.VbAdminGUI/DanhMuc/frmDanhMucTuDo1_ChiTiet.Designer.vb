Imports Vns.Erp.Core.Admin.Domain

Partial Class frmDanhMucTuDo1_ChiTiet
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
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtKy_Hieu = New DevExpress.XtraEditors.TextEdit
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit
        Me.txtMA_TK = New DevExpress.XtraEditors.TextEdit
        Me.txtTen_Dm_Tudo_1 = New DevExpress.XtraEditors.TextEdit
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.cboDm_Tudo_1_Id_Cha = New DevExpress.XtraEditors.LookUpEdit
        Me.lblValue = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen_Dm_Tudo_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDm_Tudo_1_Id_Cha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKy_Hieu)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_TK)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTen_Dm_Tudo_1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl16)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboDm_Tudo_1_Id_Cha)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblValue)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(367, 191)
        Me._GroupControlObjectInfo.TabIndex = 2
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh mục tự do 2"
        '
        'txtKy_Hieu
        '
        Me.txtKy_Hieu.EnterMoveNextControl = True
        Me.txtKy_Hieu.Location = New System.Drawing.Point(103, 11)
        Me.txtKy_Hieu.Name = "txtKy_Hieu"
        Me.txtKy_Hieu.Size = New System.Drawing.Size(230, 20)
        Me.txtKy_Hieu.TabIndex = 0
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(53, 14)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 6
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(103, 116)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(230, 45)
        Me.txtMO_TA.TabIndex = 4
        '
        'txtMA_TK
        '
        Me.txtMA_TK.EnterMoveNextControl = True
        Me.txtMA_TK.Location = New System.Drawing.Point(103, 90)
        Me.txtMA_TK.Name = "txtMA_TK"
        Me.txtMA_TK.Size = New System.Drawing.Size(230, 20)
        Me.txtMA_TK.TabIndex = 3
        '
        'txtTen_Dm_Tudo_1
        '
        Me.txtTen_Dm_Tudo_1.EnterMoveNextControl = True
        Me.txtTen_Dm_Tudo_1.Location = New System.Drawing.Point(103, 37)
        Me.txtTen_Dm_Tudo_1.Name = "txtTen_Dm_Tudo_1"
        Me.txtTen_Dm_Tudo_1.Size = New System.Drawing.Size(230, 20)
        Me.txtTen_Dm_Tudo_1.TabIndex = 1
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(101, 167)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(99, 19)
        Me.chkCO_SU_DUNG.TabIndex = 5
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(57, 118)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(27, 13)
        Me.labelControl1.TabIndex = 10
        Me.labelControl1.Text = "Mô tả"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(21, 66)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl17.TabIndex = 8
        Me.LabelControl17.Text = "Danh mục cha"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(31, 171)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 11
        Me.labelControl4.Text = "Có sử dụng"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(27, 93)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl16.TabIndex = 9
        Me.LabelControl16.Text = "Mã tài khoản"
        '
        'cboDm_Tudo_1_Id_Cha
        '
        Me.cboDm_Tudo_1_Id_Cha.AllowDrop = True
        Me.cboDm_Tudo_1_Id_Cha.EditValue = "0"
        Me.cboDm_Tudo_1_Id_Cha.EnterMoveNextControl = True
        Me.cboDm_Tudo_1_Id_Cha.Location = New System.Drawing.Point(103, 63)
        Me.cboDm_Tudo_1_Id_Cha.Name = "cboDm_Tudo_1_Id_Cha"
        Me.cboDm_Tudo_1_Id_Cha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboDm_Tudo_1_Id_Cha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboDm_Tudo_1_Id_Cha.Properties.Appearance.Options.UseBackColor = True
        Me.cboDm_Tudo_1_Id_Cha.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboDm_Tudo_1_Id_Cha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDm_Tudo_1_Id_Cha.Properties.ImmediatePopup = True
        Me.cboDm_Tudo_1_Id_Cha.Properties.NullText = ""
        Me.cboDm_Tudo_1_Id_Cha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboDm_Tudo_1_Id_Cha.Size = New System.Drawing.Size(230, 20)
        Me.cboDm_Tudo_1_Id_Cha.TabIndex = 2
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(21, 40)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(67, 13)
        Me.lblValue.TabIndex = 7
        Me.lblValue.Text = "Tên danh mục"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(287, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(146, 4)
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
        Me._ActionPanel.Location = New System.Drawing.Point(4, 195)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(367, 34)
        Me._ActionPanel.TabIndex = 3
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
        'frmDanhMucTuDo1_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 233)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.KeyPreview = True
        Me.Name = "frmDanhMucTuDo1_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục tự do 1"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen_Dm_Tudo_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDm_Tudo_1_Id_Cha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Private WithEvents txtKy_Hieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Private WithEvents txtMA_TK As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtTen_Dm_Tudo_1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDm_Tudo_1_Id_Cha As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
