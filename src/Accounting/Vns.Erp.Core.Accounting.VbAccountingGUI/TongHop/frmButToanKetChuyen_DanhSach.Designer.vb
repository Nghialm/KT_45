<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmButToanKetChuyen_DanhSach
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me._GridControl = New DevExpress.XtraGrid.GridControl
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.THU_TU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TEN_BT_KETCHUYEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MA_TK_NO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MA_TK_CO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOAI_KETCHUYEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_VUVIEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_PHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_CONGTRINH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_HOPDONG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_KH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_BPHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_TUDO_1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_TUDO_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_TUDO_3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_TUDO_4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KC_TUDO_5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnClo = New DevExpress.XtraEditors.SimpleButton
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.CausesValidation = False
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(996, 560)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(2, 2)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.Size = New System.Drawing.Size(992, 556)
        Me._GridControl.TabIndex = 1
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.THU_TU, Me.TEN_BT_KETCHUYEN, Me.MA_TK_NO, Me.MA_TK_CO, Me.LOAI_KETCHUYEN, Me.KC_VUVIEC, Me.KC_PHI, Me.KC_CONGTRINH, Me.KC_HOPDONG, Me.KC_KH, Me.KC_BPHT, Me.KC_TUDO_1, Me.KC_TUDO_2, Me.KC_TUDO_3, Me.KC_TUDO_4, Me.KC_TUDO_5})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsBehavior.Editable = False
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'THU_TU
        '
        Me.THU_TU.Caption = "STT"
        Me.THU_TU.FieldName = "ThuTu"
        Me.THU_TU.Name = "THU_TU"
        Me.THU_TU.Visible = True
        Me.THU_TU.VisibleIndex = 0
        Me.THU_TU.Width = 40
        '
        'TEN_BT_KETCHUYEN
        '
        Me.TEN_BT_KETCHUYEN.Caption = "Tên bút toán"
        Me.TEN_BT_KETCHUYEN.FieldName = "TenBtKetchuyen"
        Me.TEN_BT_KETCHUYEN.Name = "TEN_BT_KETCHUYEN"
        Me.TEN_BT_KETCHUYEN.OptionsColumn.ReadOnly = True
        Me.TEN_BT_KETCHUYEN.Visible = True
        Me.TEN_BT_KETCHUYEN.VisibleIndex = 1
        Me.TEN_BT_KETCHUYEN.Width = 280
        '
        'MA_TK_NO
        '
        Me.MA_TK_NO.Caption = "Mã tài khoản"
        Me.MA_TK_NO.FieldName = "MaTkNo"
        Me.MA_TK_NO.Name = "MA_TK_NO"
        Me.MA_TK_NO.OptionsColumn.ReadOnly = True
        Me.MA_TK_NO.Visible = True
        Me.MA_TK_NO.VisibleIndex = 2
        Me.MA_TK_NO.Width = 140
        '
        'MA_TK_CO
        '
        Me.MA_TK_CO.Caption = "Tài khoản đích"
        Me.MA_TK_CO.FieldName = "MaTkCo"
        Me.MA_TK_CO.Name = "MA_TK_CO"
        Me.MA_TK_CO.Visible = True
        Me.MA_TK_CO.VisibleIndex = 3
        Me.MA_TK_CO.Width = 140
        '
        'LOAI_KETCHUYEN
        '
        Me.LOAI_KETCHUYEN.Caption = "Loại kết chuyển"
        Me.LOAI_KETCHUYEN.FieldName = "LoaiKetchuyen"
        Me.LOAI_KETCHUYEN.Name = "LOAI_KETCHUYEN"
        Me.LOAI_KETCHUYEN.Visible = True
        Me.LOAI_KETCHUYEN.VisibleIndex = 4
        Me.LOAI_KETCHUYEN.Width = 150
        '
        'KC_VUVIEC
        '
        Me.KC_VUVIEC.Caption = "Kết chuyển vụ việc"
        Me.KC_VUVIEC.FieldName = "KcVuviec"
        Me.KC_VUVIEC.Name = "KC_VUVIEC"
        Me.KC_VUVIEC.Visible = True
        Me.KC_VUVIEC.VisibleIndex = 5
        Me.KC_VUVIEC.Width = 120
        '
        'KC_PHI
        '
        Me.KC_PHI.Caption = "Kết chuyển theo phí"
        Me.KC_PHI.FieldName = "KcPhi"
        Me.KC_PHI.Name = "KC_PHI"
        Me.KC_PHI.Visible = True
        Me.KC_PHI.VisibleIndex = 6
        Me.KC_PHI.Width = 150
        '
        'KC_CONGTRINH
        '
        Me.KC_CONGTRINH.Caption = "Kết chuyển công trình"
        Me.KC_CONGTRINH.FieldName = "KcCongtrinh"
        Me.KC_CONGTRINH.Name = "KC_CONGTRINH"
        Me.KC_CONGTRINH.Visible = True
        Me.KC_CONGTRINH.VisibleIndex = 7
        Me.KC_CONGTRINH.Width = 150
        '
        'KC_HOPDONG
        '
        Me.KC_HOPDONG.Caption = "Kết chuyển hợp đồng"
        Me.KC_HOPDONG.FieldName = "KcHopdong"
        Me.KC_HOPDONG.Name = "KC_HOPDONG"
        Me.KC_HOPDONG.Visible = True
        Me.KC_HOPDONG.VisibleIndex = 8
        Me.KC_HOPDONG.Width = 150
        '
        'KC_KH
        '
        Me.KC_KH.Caption = "Kết chuyển khách hàng"
        Me.KC_KH.FieldName = "KcKh"
        Me.KC_KH.Name = "KC_KH"
        Me.KC_KH.Visible = True
        Me.KC_KH.VisibleIndex = 9
        Me.KC_KH.Width = 150
        '
        'KC_BPHT
        '
        Me.KC_BPHT.Caption = "Kết chuyển theo bộ phận hoặch toán"
        Me.KC_BPHT.FieldName = "KcBpht"
        Me.KC_BPHT.Name = "KC_BPHT"
        Me.KC_BPHT.Visible = True
        Me.KC_BPHT.VisibleIndex = 10
        Me.KC_BPHT.Width = 150
        '
        'KC_TUDO_1
        '
        Me.KC_TUDO_1.Caption = "Kết chuyển tự do 1"
        Me.KC_TUDO_1.FieldName = "KcTudo1"
        Me.KC_TUDO_1.Name = "KC_TUDO_1"
        Me.KC_TUDO_1.Visible = True
        Me.KC_TUDO_1.VisibleIndex = 11
        Me.KC_TUDO_1.Width = 140
        '
        'KC_TUDO_2
        '
        Me.KC_TUDO_2.Caption = "Kết chuyển tự do 2"
        Me.KC_TUDO_2.FieldName = "KcTudo2"
        Me.KC_TUDO_2.Name = "KC_TUDO_2"
        Me.KC_TUDO_2.Visible = True
        Me.KC_TUDO_2.VisibleIndex = 12
        Me.KC_TUDO_2.Width = 140
        '
        'KC_TUDO_3
        '
        Me.KC_TUDO_3.Caption = "Kết chuyển tự do 3"
        Me.KC_TUDO_3.FieldName = "KcTudo3"
        Me.KC_TUDO_3.Name = "KC_TUDO_3"
        Me.KC_TUDO_3.Visible = True
        Me.KC_TUDO_3.VisibleIndex = 13
        Me.KC_TUDO_3.Width = 140
        '
        'KC_TUDO_4
        '
        Me.KC_TUDO_4.Caption = "Kết chuyển tự do 4"
        Me.KC_TUDO_4.FieldName = "KcTudo4"
        Me.KC_TUDO_4.Name = "KC_TUDO_4"
        Me.KC_TUDO_4.Visible = True
        Me.KC_TUDO_4.VisibleIndex = 14
        Me.KC_TUDO_4.Width = 140
        '
        'KC_TUDO_5
        '
        Me.KC_TUDO_5.Caption = "Kết chuyển tự do 5"
        Me.KC_TUDO_5.FieldName = "KcTudo5"
        Me.KC_TUDO_5.Name = "KC_TUDO_5"
        Me.KC_TUDO_5.Visible = True
        Me.KC_TUDO_5.VisibleIndex = 15
        Me.KC_TUDO_5.Width = 140
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnClo)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(6, 566)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(996, 40)
        Me.PanelControl2.TabIndex = 20
        '
        'btnClo
        '
        Me.btnClo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClo.ImageIndex = 3
        Me.btnClo.Location = New System.Drawing.Point(904, 5)
        Me.btnClo.Name = "btnClo"
        Me.btnClo.Size = New System.Drawing.Size(80, 30)
        Me.btnClo.TabIndex = 8
        Me.btnClo.Text = "&Đóng"
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(86, 5)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(80, 30)
        Me.btnMod.TabIndex = 7
        Me.btnMod.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(0, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Mới"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(172, 5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "&Xóa"
        '
        'frmButToanKetChuyen_DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmButToanKetChuyen_DanhSach"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "Khai báo bút toán kết chuyển tự động "
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents THU_TU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_BT_KETCHUYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOAI_KETCHUYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_VUVIEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_PHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_CONGTRINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_HOPDONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_BPHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_TUDO_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KC_TUDO_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_TUDO_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_TUDO_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KC_TUDO_5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
