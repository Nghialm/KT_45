<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKT_H_BAOCAO_ChiTiet
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
        Me.grc_KT_H_BAOCAO = New DevExpress.XtraEditors.GroupControl
        Me.txtSO_COT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtMA_BAOCAO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtSO_DONG = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtTITLE = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnKhaiBaoChiTieu = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnXacNhan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grc_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grc_KT_H_BAOCAO.SuspendLayout()
        CType(Me.txtSO_COT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_BAOCAO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_DONG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTITLE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grc_KT_H_BAOCAO
        '
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.txtSO_COT)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.LabelControl3)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.txtMA_BAOCAO)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.LabelControl4)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.txtSO_DONG)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.LabelControl2)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.txtTITLE)
        Me.grc_KT_H_BAOCAO.Controls.Add(Me.LabelControl1)
        Me.grc_KT_H_BAOCAO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grc_KT_H_BAOCAO.Location = New System.Drawing.Point(4, 4)
        Me.grc_KT_H_BAOCAO.Name = "grc_KT_H_BAOCAO"
        Me.grc_KT_H_BAOCAO.ShowCaption = False
        Me.grc_KT_H_BAOCAO.Size = New System.Drawing.Size(365, 110)
        Me.grc_KT_H_BAOCAO.TabIndex = 0
        Me.grc_KT_H_BAOCAO.Text = "GroupControl1"
        '
        'txtSO_COT
        '
        Me.txtSO_COT.EnterMoveNextControl = True
        Me.txtSO_COT.Location = New System.Drawing.Point(90, 84)
        Me.txtSO_COT.Name = "txtSO_COT"
        Me.txtSO_COT.Properties.Mask.EditMask = "[0-9]{0,4}"
        Me.txtSO_COT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSO_COT.Size = New System.Drawing.Size(62, 20)
        Me.txtSO_COT.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Số cột"
        '
        'txtMA_BAOCAO
        '
        Me.txtMA_BAOCAO.EnterMoveNextControl = True
        Me.txtMA_BAOCAO.Location = New System.Drawing.Point(90, 6)
        Me.txtMA_BAOCAO.Name = "txtMA_BAOCAO"
        Me.txtMA_BAOCAO.Size = New System.Drawing.Size(62, 20)
        Me.txtMA_BAOCAO.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(17, 9)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Mã báo cáo"
        '
        'txtSO_DONG
        '
        Me.txtSO_DONG.EnterMoveNextControl = True
        Me.txtSO_DONG.Location = New System.Drawing.Point(90, 58)
        Me.txtSO_DONG.Name = "txtSO_DONG"
        Me.txtSO_DONG.Properties.Mask.EditMask = "[0-9]{0,4}"
        Me.txtSO_DONG.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSO_DONG.Size = New System.Drawing.Size(62, 20)
        Me.txtSO_DONG.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Số dòng"
        '
        'txtTITLE
        '
        Me.txtTITLE.EnterMoveNextControl = True
        Me.txtTITLE.Location = New System.Drawing.Point(90, 32)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(263, 20)
        Me.txtTITLE.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên báo cáo"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnKhaiBaoChiTieu)
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnXacNhan)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 114)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(365, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'btnKhaiBaoChiTieu
        '
        Me.btnKhaiBaoChiTieu.Location = New System.Drawing.Point(100, 4)
        Me.btnKhaiBaoChiTieu.Name = "btnKhaiBaoChiTieu"
        Me.btnKhaiBaoChiTieu.Size = New System.Drawing.Size(94, 30)
        Me.btnKhaiBaoChiTieu.TabIndex = 2
        Me.btnKhaiBaoChiTieu.Text = "Khai báo chỉ tiêu"
        Me.btnKhaiBaoChiTieu.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ImageIndex = 24
        Me.btnClose.Location = New System.Drawing.Point(286, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Đ&óng"
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan.ImageIndex = 13
        Me.btnXacNhan.Location = New System.Drawing.Point(200, 4)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(80, 30)
        Me.btnXacNhan.TabIndex = 0
        Me.btnXacNhan.Text = "&Lưu"
        '
        'frmKT_H_BAOCAO_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 152)
        Me.Controls.Add(Me.grc_KT_H_BAOCAO)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKT_H_BAOCAO_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Danh sách báo cáo"
        CType(Me.grc_KT_H_BAOCAO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grc_KT_H_BAOCAO.ResumeLayout(False)
        Me.grc_KT_H_BAOCAO.PerformLayout()
        CType(Me.txtSO_COT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_BAOCAO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_DONG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTITLE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grc_KT_H_BAOCAO As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSO_COT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSO_DONG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTITLE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXacNhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKhaiBaoChiTieu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMA_BAOCAO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
