<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCauHinhTaiKhoan
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
        Dim GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grlQuyetDinh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grlQuyetDinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Controls.Add(Me.grlQuyetDinh)
        Me.GroupControl1.Controls.Add(Me.labelControl12)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(297, 142)
        Me.GroupControl1.TabIndex = 28
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grlQuyetDinh
        '
        Me.grlQuyetDinh.EditValue = ""
        Me.grlQuyetDinh.Location = New System.Drawing.Point(111, 24)
        Me.grlQuyetDinh.Name = "grlQuyetDinh"
        Me.grlQuyetDinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlQuyetDinh.Properties.NullText = ""
        Me.grlQuyetDinh.Properties.View = GridView3
        Me.grlQuyetDinh.Size = New System.Drawing.Size(159, 20)
        Me.grlQuyetDinh.TabIndex = 2
        '
        'GridView3
        '
        GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridView3.Name = "GridView3"
        GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView3.OptionsView.ShowGroupPanel = False
        '
        'labelControl12
        '
        Me.labelControl12.Location = New System.Drawing.Point(13, 27)
        Me.labelControl12.Name = "labelControl12"
        Me.labelControl12.Size = New System.Drawing.Size(92, 13)
        Me.labelControl12.TabIndex = 4
        Me.labelControl12.Text = "Quyết định kế toán"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnOk)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 106)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(293, 34)
        Me.PanelControl2.TabIndex = 21
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ImageIndex = 2
        Me.btnCancel.Location = New System.Drawing.Point(144, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Hủy bỏ"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(58, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 30)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Xác nhận"
        '
        'frmCauHinhTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 142)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmCauHinhTaiKhoan"
        Me.Text = "Lựa chọn hệ thống tài khoản"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grlQuyetDinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grlQuyetDinh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents labelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
End Class
