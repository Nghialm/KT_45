Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucKhachHang_ChiTiet
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
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCheck = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Color = New DevExpress.XtraEditors.LabelControl()
        Me.cboKHANG_ID_CHA = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTEN_LOAIKHANG = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFAX = New DevExpress.XtraEditors.TextEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_SO_THUE = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEL = New DevExpress.XtraEditors.TextEdit()
        Me.txtSO_TAIKHOAN = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMATK_LIENQUAN = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grlNHOM_KHANG_1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TEN_NHOM_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_NHOM_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KY_HIEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grlNHOM_KHANG_3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ten_nhom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grlNHOM_KHANG_2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_NHOM_KHANG2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_NHOM_KHANG_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.chkTHEO_DOI_CN = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCMTND = New DevExpress.XtraEditors.TextEdit()
        Me.txtEMAIL = New DevExpress.XtraEditors.TextEdit()
        Me.txtWEBSITE = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl()
        Me.dteNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNGUOI_DAI_DIEN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.cboKHANG_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTEN_LOAIKHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFAX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_SO_THUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_TAIKHOAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMATK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grlNHOM_KHANG_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlNHOM_KHANG_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlNHOM_KHANG_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTHEO_DOI_CN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCMTND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMAIL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWEBSITE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.dteNgaySinh.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGUOI_DAI_DIEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnCheck)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(6, 291)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Size = New System.Drawing.Size(718, 40)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(409, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(323, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCheck.ImageIndex = 13
        Me.btnCheck.Location = New System.Drawing.Point(91, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(80, 30)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "&Kiểm tra"
        Me.btnCheck.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(237, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(64, 62)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 1
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tên khách hàng"
        '
        'Color
        '
        Me.Color.Location = New System.Drawing.Point(444, 114)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(32, 13)
        Me.Color.TabIndex = 21
        Me.Color.Text = "Ðịa chỉ"
        '
        'cboKHANG_ID_CHA
        '
        Me.cboKHANG_ID_CHA.AllowDrop = True
        Me.cboKHANG_ID_CHA.EditValue = "0"
        Me.cboKHANG_ID_CHA.EnterMoveNextControl = True
        Me.cboKHANG_ID_CHA.Location = New System.Drawing.Point(494, 291)
        Me.cboKHANG_ID_CHA.Name = "cboKHANG_ID_CHA"
        Me.cboKHANG_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboKHANG_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboKHANG_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboKHANG_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboKHANG_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKHANG_ID_CHA.Properties.ImmediatePopup = True
        Me.cboKHANG_ID_CHA.Properties.NullText = ""
        Me.cboKHANG_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboKHANG_ID_CHA.Size = New System.Drawing.Size(200, 20)
        Me.cboKHANG_ID_CHA.TabIndex = 12
        Me.cboKHANG_ID_CHA.Visible = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(458, 140)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl16.TabIndex = 23
        Me.LabelControl16.Text = "Fax"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(419, 218)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(55, 13)
        Me.labelControl4.TabIndex = 30
        Me.labelControl4.Text = "Có sử dụng"
        '
        'cboTEN_LOAIKHANG
        '
        Me.cboTEN_LOAIKHANG.EditValue = "0"
        Me.cboTEN_LOAIKHANG.EnterMoveNextControl = True
        Me.cboTEN_LOAIKHANG.Location = New System.Drawing.Point(496, 59)
        Me.cboTEN_LOAIKHANG.Name = "cboTEN_LOAIKHANG"
        Me.cboTEN_LOAIKHANG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboTEN_LOAIKHANG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTEN_LOAIKHANG.Properties.ImmediatePopup = True
        Me.cboTEN_LOAIKHANG.Properties.NullText = ""
        Me.cboTEN_LOAIKHANG.Size = New System.Drawing.Size(200, 20)
        Me.cboTEN_LOAIKHANG.TabIndex = 8
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(382, 294)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl17.TabIndex = 27
        Me.LabelControl17.Text = "Mã khách hàng cha"
        Me.LabelControl17.Visible = False
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(46, 166)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(53, 13)
        Me.labelControl1.TabIndex = 9
        Me.labelControl1.Text = "Mã số thuế"
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(492, 216)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = ""
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(45, 19)
        Me.chkCO_SU_DUNG.TabIndex = 14
        '
        'txtFAX
        '
        Me.txtFAX.EnterMoveNextControl = True
        Me.txtFAX.Location = New System.Drawing.Point(496, 137)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(200, 20)
        Me.txtFAX.TabIndex = 11
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(119, 59)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Properties.MaxLength = 64
        Me.txtKY_HIEU.Size = New System.Drawing.Size(200, 20)
        Me.txtKY_HIEU.TabIndex = 1
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(119, 85)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_KHANG.TabIndex = 2
        '
        'txtMA_SO_THUE
        '
        Me.txtMA_SO_THUE.EnterMoveNextControl = True
        Me.txtMA_SO_THUE.Location = New System.Drawing.Point(119, 163)
        Me.txtMA_SO_THUE.Name = "txtMA_SO_THUE"
        Me.txtMA_SO_THUE.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_SO_THUE.TabIndex = 4
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(496, 111)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.Size = New System.Drawing.Size(200, 20)
        Me.txtDIA_CHI.TabIndex = 10
        '
        'txtTEL
        '
        Me.txtTEL.EnterMoveNextControl = True
        Me.txtTEL.Location = New System.Drawing.Point(119, 111)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(200, 20)
        Me.txtTEL.TabIndex = 3
        '
        'txtSO_TAIKHOAN
        '
        Me.txtSO_TAIKHOAN.EnterMoveNextControl = True
        Me.txtSO_TAIKHOAN.Location = New System.Drawing.Point(496, 163)
        Me.txtSO_TAIKHOAN.Name = "txtSO_TAIKHOAN"
        Me.txtSO_TAIKHOAN.Size = New System.Drawing.Size(200, 20)
        Me.txtSO_TAIKHOAN.TabIndex = 12
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(37, 114)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(62, 13)
        Me.labelControl5.TabIndex = 7
        Me.labelControl5.Text = "Số điện thoại"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(417, 166)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(59, 13)
        Me.labelControl6.TabIndex = 25
        Me.labelControl6.Text = "Số tài khoản"
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(399, 62)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(77, 13)
        Me.labelControl7.TabIndex = 17
        Me.labelControl7.Text = "Loại khách hàng"
        '
        'txtMATK_LIENQUAN
        '
        Me.txtMATK_LIENQUAN.EnterMoveNextControl = True
        Me.txtMATK_LIENQUAN.Location = New System.Drawing.Point(496, 189)
        Me.txtMATK_LIENQUAN.Name = "txtMATK_LIENQUAN"
        Me.txtMATK_LIENQUAN.Size = New System.Drawing.Size(200, 20)
        Me.txtMATK_LIENQUAN.TabIndex = 13
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(384, 192)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(92, 13)
        Me.labelControl11.TabIndex = 26
        Me.labelControl11.Text = "Tài khoản liên quan"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grlNHOM_KHANG_1)
        Me.GroupControl1.Controls.Add(Me.grlNHOM_KHANG_3)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.grlNHOM_KHANG_2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(718, 43)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grlNHOM_KHANG_1
        '
        Me.grlNHOM_KHANG_1.EnterMoveNextControl = True
        Me.grlNHOM_KHANG_1.Location = New System.Drawing.Point(117, 12)
        Me.grlNHOM_KHANG_1.Name = "grlNHOM_KHANG_1"
        Me.grlNHOM_KHANG_1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlNHOM_KHANG_1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlNHOM_KHANG_1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlNHOM_KHANG_1.Properties.NullText = ""
        Me.grlNHOM_KHANG_1.Properties.View = Me.GridView1
        Me.grlNHOM_KHANG_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlNHOM_KHANG_1.Size = New System.Drawing.Size(150, 20)
        Me.grlNHOM_KHANG_1.TabIndex = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TEN_NHOM_KHANG, Me.MA_NHOM_KHANG, Me.KY_HIEU})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'TEN_NHOM_KHANG
        '
        Me.TEN_NHOM_KHANG.Caption = "Tên nhóm"
        Me.TEN_NHOM_KHANG.FieldName = "TenNhomKhang"
        Me.TEN_NHOM_KHANG.Name = "TEN_NHOM_KHANG"
        Me.TEN_NHOM_KHANG.Visible = True
        Me.TEN_NHOM_KHANG.VisibleIndex = 0
        '
        'MA_NHOM_KHANG
        '
        Me.MA_NHOM_KHANG.Caption = "Mã nhóm "
        Me.MA_NHOM_KHANG.FieldName = "MaNhomKhang"
        Me.MA_NHOM_KHANG.Name = "MA_NHOM_KHANG"
        Me.MA_NHOM_KHANG.Visible = True
        Me.MA_NHOM_KHANG.VisibleIndex = 1
        '
        'KY_HIEU
        '
        Me.KY_HIEU.Caption = "Ký hiệu"
        Me.KY_HIEU.FieldName = "KyHieu"
        Me.KY_HIEU.Name = "KY_HIEU"
        Me.KY_HIEU.Visible = True
        Me.KY_HIEU.VisibleIndex = 2
        '
        'grlNHOM_KHANG_3
        '
        Me.grlNHOM_KHANG_3.EnterMoveNextControl = True
        Me.grlNHOM_KHANG_3.Location = New System.Drawing.Point(548, 12)
        Me.grlNHOM_KHANG_3.Name = "grlNHOM_KHANG_3"
        Me.grlNHOM_KHANG_3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlNHOM_KHANG_3.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlNHOM_KHANG_3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlNHOM_KHANG_3.Properties.NullText = ""
        Me.grlNHOM_KHANG_3.Properties.View = Me.GridView3
        Me.grlNHOM_KHANG_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlNHOM_KHANG_3.Size = New System.Drawing.Size(150, 20)
        Me.grlNHOM_KHANG_3.TabIndex = 2
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA, Me.Ten_nhom, Me.GridColumn2})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'MA
        '
        Me.MA.Caption = "Mã nhóm"
        Me.MA.FieldName = "MaNhomKhang"
        Me.MA.Name = "MA"
        Me.MA.Visible = True
        Me.MA.VisibleIndex = 0
        '
        'Ten_nhom
        '
        Me.Ten_nhom.Caption = "Tên nhóm"
        Me.Ten_nhom.FieldName = "TenNhomKhang"
        Me.Ten_nhom.Name = "Ten_nhom"
        Me.Ten_nhom.Visible = True
        Me.Ten_nhom.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ký hiệu"
        Me.GridColumn2.FieldName = "KyHieu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(494, 16)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "Nhóm 3"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(61, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Nhóm 1"
        '
        'grlNHOM_KHANG_2
        '
        Me.grlNHOM_KHANG_2.EnterMoveNextControl = True
        Me.grlNHOM_KHANG_2.Location = New System.Drawing.Point(333, 12)
        Me.grlNHOM_KHANG_2.Name = "grlNHOM_KHANG_2"
        Me.grlNHOM_KHANG_2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlNHOM_KHANG_2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlNHOM_KHANG_2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlNHOM_KHANG_2.Properties.NullText = ""
        Me.grlNHOM_KHANG_2.Properties.View = Me.GridView2
        Me.grlNHOM_KHANG_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlNHOM_KHANG_2.Size = New System.Drawing.Size(150, 20)
        Me.grlNHOM_KHANG_2.TabIndex = 1
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_NHOM_KHANG2, Me.TEN_NHOM_KHANG_2, Me.GridColumn1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'MA_NHOM_KHANG2
        '
        Me.MA_NHOM_KHANG2.Caption = "Mã nhóm"
        Me.MA_NHOM_KHANG2.FieldName = "MaNhomKhang"
        Me.MA_NHOM_KHANG2.Name = "MA_NHOM_KHANG2"
        Me.MA_NHOM_KHANG2.Visible = True
        Me.MA_NHOM_KHANG2.VisibleIndex = 0
        '
        'TEN_NHOM_KHANG_2
        '
        Me.TEN_NHOM_KHANG_2.Caption = "Tên nhóm"
        Me.TEN_NHOM_KHANG_2.FieldName = "TenNhomKhang"
        Me.TEN_NHOM_KHANG_2.Name = "TEN_NHOM_KHANG_2"
        Me.TEN_NHOM_KHANG_2.Visible = True
        Me.TEN_NHOM_KHANG_2.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ký hiệu"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(277, 16)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "Nhóm 2"
        '
        'chkTHEO_DOI_CN
        '
        Me.chkTHEO_DOI_CN.EditValue = True
        Me.chkTHEO_DOI_CN.Location = New System.Drawing.Point(649, 216)
        Me.chkTHEO_DOI_CN.Name = "chkTHEO_DOI_CN"
        Me.chkTHEO_DOI_CN.Properties.Caption = ""
        Me.chkTHEO_DOI_CN.Size = New System.Drawing.Size(45, 19)
        Me.chkTHEO_DOI_CN.TabIndex = 15
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(548, 218)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 32
        Me.LabelControl10.Text = "Theo dõi công nợ"
        '
        'txtCMTND
        '
        Me.txtCMTND.EnterMoveNextControl = True
        Me.txtCMTND.Location = New System.Drawing.Point(119, 189)
        Me.txtCMTND.Name = "txtCMTND"
        Me.txtCMTND.Size = New System.Drawing.Size(200, 20)
        Me.txtCMTND.TabIndex = 5
        '
        'txtEMAIL
        '
        Me.txtEMAIL.EnterMoveNextControl = True
        Me.txtEMAIL.Location = New System.Drawing.Point(119, 215)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(200, 20)
        Me.txtEMAIL.TabIndex = 6
        '
        'txtWEBSITE
        '
        Me.txtWEBSITE.EnterMoveNextControl = True
        Me.txtWEBSITE.Location = New System.Drawing.Point(119, 241)
        Me.txtWEBSITE.Name = "txtWEBSITE"
        Me.txtWEBSITE.Size = New System.Drawing.Size(200, 20)
        Me.txtWEBSITE.TabIndex = 7
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(64, 192)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl12.TabIndex = 11
        Me.LabelControl12.Text = "CMTND"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(75, 218)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl13.TabIndex = 13
        Me.LabelControl13.Text = "Email"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(60, 244)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl14.TabIndex = 15
        Me.LabelControl14.Text = "Website"
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.dteNgaySinh)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl15)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtNGUOI_DAI_DIEN)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl14)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl13)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl12)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtWEBSITE)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtEMAIL)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtCMTND)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl10)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkTHEO_DOI_CN)
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl11)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMATK_LIENQUAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl7)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl18)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl5)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtSO_TAIKHOAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEL)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtDIA_CHI)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_SO_THUE)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_KHANG)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtKY_HIEU)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtFAX)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl17)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboTEN_LOAIKHANG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl4)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl16)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboKHANG_ID_CHA)
        Me._GroupControlObjectInfo.Controls.Add(Me.Color)
        Me._GroupControlObjectInfo.Controls.Add(Me.LabelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(6, 6)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(718, 285)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'dteNgaySinh
        '
        Me.dteNgaySinh.EditValue = Nothing
        Me.dteNgaySinh.Location = New System.Drawing.Point(119, 137)
        Me.dteNgaySinh.Name = "dteNgaySinh"
        Me.dteNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNgaySinh.Properties.MaxValue = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dteNgaySinh.Properties.MinValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dteNgaySinh.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNgaySinh.Size = New System.Drawing.Size(198, 20)
        Me.dteNgaySinh.TabIndex = 33
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(408, 88)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Người đại diện"
        '
        'txtNGUOI_DAI_DIEN
        '
        Me.txtNGUOI_DAI_DIEN.EnterMoveNextControl = True
        Me.txtNGUOI_DAI_DIEN.Location = New System.Drawing.Point(496, 85)
        Me.txtNGUOI_DAI_DIEN.Name = "txtNGUOI_DAI_DIEN"
        Me.txtNGUOI_DAI_DIEN.Size = New System.Drawing.Size(200, 20)
        Me.txtNGUOI_DAI_DIEN.TabIndex = 9
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(52, 140)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl18.TabIndex = 7
        Me.LabelControl18.Text = "Ngày sinh"
        '
        'frmDanhMucKhachHang_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(730, 337)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucKhachHang_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục khách hàng"
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.cboKHANG_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTEN_LOAIKHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFAX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_SO_THUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_TAIKHOAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMATK_LIENQUAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grlNHOM_KHANG_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlNHOM_KHANG_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlNHOM_KHANG_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTHEO_DOI_CN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCMTND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMAIL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWEBSITE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.dteNgaySinh.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGUOI_DAI_DIEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboKHANG_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTEN_LOAIKHANG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private WithEvents txtFAX As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtMA_SO_THUE As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtTEL As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtSO_TAIKHOAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMATK_LIENQUAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grlNHOM_KHANG_1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KY_HIEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grlNHOM_KHANG_3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grlNHOM_KHANG_2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkTHEO_DOI_CN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtCMTND As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtEMAIL As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtWEBSITE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtNGUOI_DAI_DIEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MA_NHOM_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_NHOM_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten_nhom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_NHOM_KHANG2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_NHOM_KHANG_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dteNgaySinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
End Class
