<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDieuChuyenTaiSan_ChiTiet
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtLY_DO_DC = New DevExpress.XtraEditors.TextEdit()
        Me.dteNGAY_DC = New DevExpress.XtraEditors.DateEdit()
        Me.grlPHONG_BAN_DC = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPHONG_BAN_HT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNGAY_MUA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenTS = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_TSCD = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtLY_DO_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_DC.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlPHONG_BAN_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPHONG_BAN_HT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGAY_MUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TSCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.txtLY_DO_DC)
        Me.GroupControl1.Controls.Add(Me.dteNGAY_DC)
        Me.GroupControl1.Controls.Add(Me.grlPHONG_BAN_DC)
        Me.GroupControl1.Controls.Add(Me.txtPHONG_BAN_HT)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtNGAY_MUA)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtTenTS)
        Me.GroupControl1.Controls.Add(Me.txtMA_TSCD)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(573, 123)
        Me.GroupControl1.TabIndex = 0
        '
        'txtLY_DO_DC
        '
        Me.txtLY_DO_DC.EnterMoveNextControl = True
        Me.txtLY_DO_DC.Location = New System.Drawing.Point(127, 92)
        Me.txtLY_DO_DC.Name = "txtLY_DO_DC"
        Me.txtLY_DO_DC.Size = New System.Drawing.Size(434, 20)
        Me.txtLY_DO_DC.TabIndex = 5
        '
        'dteNGAY_DC
        '
        Me.dteNGAY_DC.EditValue = Nothing
        Me.dteNGAY_DC.EnterMoveNextControl = True
        Me.dteNGAY_DC.Location = New System.Drawing.Point(127, 65)
        Me.dteNGAY_DC.Name = "dteNGAY_DC"
        Me.dteNGAY_DC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_DC.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_DC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_DC.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.dteNGAY_DC.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteNGAY_DC.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_DC.Size = New System.Drawing.Size(112, 20)
        Me.dteNGAY_DC.TabIndex = 2
        '
        'grlPHONG_BAN_DC
        '
        Me.grlPHONG_BAN_DC.EnterMoveNextControl = True
        Me.grlPHONG_BAN_DC.Location = New System.Drawing.Point(384, 66)
        Me.grlPHONG_BAN_DC.Name = "grlPHONG_BAN_DC"
        Me.grlPHONG_BAN_DC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlPHONG_BAN_DC.Properties.NullText = ""
        Me.grlPHONG_BAN_DC.Properties.View = Me.GridLookUpEdit1View
        Me.grlPHONG_BAN_DC.Size = New System.Drawing.Size(177, 20)
        Me.grlPHONG_BAN_DC.TabIndex = 4
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtPHONG_BAN_HT
        '
        Me.txtPHONG_BAN_HT.EnterMoveNextControl = True
        Me.txtPHONG_BAN_HT.Location = New System.Drawing.Point(384, 39)
        Me.txtPHONG_BAN_HT.Name = "txtPHONG_BAN_HT"
        Me.txtPHONG_BAN_HT.Properties.ReadOnly = True
        Me.txtPHONG_BAN_HT.Size = New System.Drawing.Size(177, 20)
        Me.txtPHONG_BAN_HT.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Lý do điều chuyển"
        '
        'txtNGAY_MUA
        '
        Me.txtNGAY_MUA.EnterMoveNextControl = True
        Me.txtNGAY_MUA.Location = New System.Drawing.Point(127, 39)
        Me.txtNGAY_MUA.Name = "txtNGAY_MUA"
        Me.txtNGAY_MUA.Properties.ReadOnly = True
        Me.txtNGAY_MUA.Size = New System.Drawing.Size(112, 20)
        Me.txtNGAY_MUA.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Ngày điều chuyển"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(266, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Phòng ban điều chuyển"
        '
        'txtTenTS
        '
        Me.txtTenTS.EnterMoveNextControl = True
        Me.txtTenTS.Location = New System.Drawing.Point(245, 11)
        Me.txtTenTS.Name = "txtTenTS"
        Me.txtTenTS.Properties.ReadOnly = True
        Me.txtTenTS.Size = New System.Drawing.Size(318, 20)
        Me.txtTenTS.TabIndex = 0
        Me.txtTenTS.TabStop = False
        '
        'txtMA_TSCD
        '
        Me.txtMA_TSCD.EnterMoveNextControl = True
        Me.txtMA_TSCD.Location = New System.Drawing.Point(127, 11)
        Me.txtMA_TSCD.Name = "txtMA_TSCD"
        Me.txtMA_TSCD.Properties.ReadOnly = True
        Me.txtMA_TSCD.Size = New System.Drawing.Size(112, 20)
        Me.txtMA_TSCD.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(289, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Phòng ban hiện tại"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(51, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Ngày mua"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Mã tài sản"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(4, 127)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(573, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(492, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnSave
        '
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(0, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmDieuChuyenTaiSan_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 165)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmDieuChuyenTaiSan_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "frmDieuChuyenTaiSan_ChiTiet"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtLY_DO_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_DC.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlPHONG_BAN_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPHONG_BAN_HT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGAY_MUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TSCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grlPHONG_BAN_DC As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPHONG_BAN_HT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNGAY_MUA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMA_TSCD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dteNGAY_DC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenTS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLY_DO_DC As DevExpress.XtraEditors.TextEdit
End Class
