Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain


Partial Public Class frmDanhMucTaiKhoan_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhMucTaiKhoan_ChiTiet))
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl()
        Me.cFilterTaiKhoan = New Vns.Erp.Core.CustomFilter()
        Me.chkCHI_TIET = New DevExpress.XtraEditors.CheckEdit()
        Me.lblNhomTaiKhoan = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMA_TAIKHOAN1 = New DevExpress.XtraEditors.TextEdit()
        Me.chkTB_NB = New DevExpress.XtraEditors.CheckEdit()
        Me.chkIN_BCD = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTINH_CHAT1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mmeMO_TA = New DevExpress.XtraEditors.MemoEdit()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_TAIKHOAN = New DevExpress.XtraEditors.TextEdit()
        Me.txtMA_TAIKHOAN_CHA1 = New DevExpress.XtraEditors.TextEdit()
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.chkDM_Khang = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Khoanphi = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_PTQT = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Phongban = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Vuviec = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_HopDong = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Tudo5 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Tudo4 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Tudo3 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Tudo2 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_Tudo1 = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtbChiTiet = New DevExpress.XtraTab.XtraTabPage()
        Me.xtbBoSung = New DevExpress.XtraTab.XtraTabPage()
        Me.ErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Me.cboChiTiet = New DevExpress.XtraEditors.CheckEdit()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TAIKHOAN1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTB_NB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIN_BCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTINH_CHAT1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_TAIKHOAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TAIKHOAN_CHA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkDM_Khang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Khoanphi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_PTQT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Phongban.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Vuviec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_HopDong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Tudo5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Tudo4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Tudo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Tudo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_Tudo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtbChiTiet.SuspendLayout()
        Me.xtbBoSung.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboChiTiet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._GroupControlObjectInfo.Controls.Add(Me.cboChiTiet)
        Me._GroupControlObjectInfo.Controls.Add(Me.cFilterTaiKhoan)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHI_TIET)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblNhomTaiKhoan)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl11)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_TAIKHOAN1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkTB_NB)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkIN_BCD)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.cboTINH_CHAT1)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.mmeMO_TA)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl6)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl5)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtTEN_TAIKHOAN)
        Me._GroupControlObjectInfo.Controls.Add(Me.txtMA_TAIKHOAN_CHA1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Controls.Add(Me.labelControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.lblCarFarmily_Code)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(0, 0)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.Padding = New System.Windows.Forms.Padding(4)
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(686, 115)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh mục tự do 2"
        '
        'cFilterTaiKhoan
        '
        Me.cFilterTaiKhoan.AllowNull = True
        Me.cFilterTaiKhoan.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.cFilterTaiKhoan.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;Mota;Cap"
        Me.cFilterTaiKhoan.C_DATA_SOURCE = Nothing
        Me.cFilterTaiKhoan.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.cFilterTaiKhoan.C_FORM_TITLE = "Chọn tài khoản"
        Me.cFilterTaiKhoan.C_IS_CHECK_NUMBER = ""
        Me.cFilterTaiKhoan.C_IS_CHECK_OTHER = ""
        Me.cFilterTaiKhoan.C_IS_CHECK_STRING = ""
        Me.cFilterTaiKhoan.C_IS_FILTER_STRING = ""
        Me.cFilterTaiKhoan.C_IS_QUICKADD = True
        Me.cFilterTaiKhoan.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterTaiKhoan.C_KEY_NAME = "MaTaikhoan"
        Me.cFilterTaiKhoan.EditValue = ""
        Me.cFilterTaiKhoan.EditValues = ""
        Me.cFilterTaiKhoan.ENABLES = True
        Me.cFilterTaiKhoan.IsNotTextChanged = True
        Me.cFilterTaiKhoan.ListEditValue = CType(resources.GetObject("cFilterTaiKhoan.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterTaiKhoan.Location = New System.Drawing.Point(108, 11)
        Me.cFilterTaiKhoan.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterTaiKhoan.Name = "cFilterTaiKhoan"
        Me.cFilterTaiKhoan.NEXT_TAB = 0
        Me.cFilterTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilterTaiKhoan.Size = New System.Drawing.Size(130, 20)
        Me.cFilterTaiKhoan.TabIndex = 0
        '
        'chkCHI_TIET
        '
        Me.chkCHI_TIET.EditValue = True
        Me.chkCHI_TIET.Enabled = False
        Me.chkCHI_TIET.Location = New System.Drawing.Point(402, 210)
        Me.chkCHI_TIET.Name = "chkCHI_TIET"
        Me.chkCHI_TIET.Properties.Caption = ""
        Me.chkCHI_TIET.Size = New System.Drawing.Size(32, 19)
        Me.chkCHI_TIET.TabIndex = 121
        '
        'lblNhomTaiKhoan
        '
        Me.lblNhomTaiKhoan.Location = New System.Drawing.Point(203, 18)
        Me.lblNhomTaiKhoan.Name = "lblNhomTaiKhoan"
        Me.lblNhomTaiKhoan.Size = New System.Drawing.Size(0, 13)
        Me.lblNhomTaiKhoan.TabIndex = 120
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(17, 16)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(74, 13)
        Me.labelControl11.TabIndex = 0
        Me.labelControl11.Text = "Nhóm tài khoản"
        '
        'txtMA_TAIKHOAN1
        '
        Me.txtMA_TAIKHOAN1.EnterMoveNextControl = True
        Me.txtMA_TAIKHOAN1.Location = New System.Drawing.Point(203, 37)
        Me.txtMA_TAIKHOAN1.Name = "txtMA_TAIKHOAN1"
        Me.txtMA_TAIKHOAN1.Properties.Mask.EditMask = "[a-zA-Z0-9_]{0,3}"
        Me.txtMA_TAIKHOAN1.Properties.Mask.IgnoreMaskBlank = False
        Me.txtMA_TAIKHOAN1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMA_TAIKHOAN1.Properties.MaxLength = 32
        Me.txtMA_TAIKHOAN1.Size = New System.Drawing.Size(105, 20)
        Me.txtMA_TAIKHOAN1.TabIndex = 2
        '
        'chkTB_NB
        '
        Me.chkTB_NB.EditValue = True
        Me.chkTB_NB.Location = New System.Drawing.Point(462, 89)
        Me.chkTB_NB.Name = "chkTB_NB"
        Me.chkTB_NB.Properties.Caption = "Tk ngoại bảng"
        Me.chkTB_NB.Size = New System.Drawing.Size(97, 19)
        Me.chkTB_NB.TabIndex = 8
        '
        'chkIN_BCD
        '
        Me.chkIN_BCD.EditValue = True
        Me.chkIN_BCD.Enabled = False
        Me.chkIN_BCD.Location = New System.Drawing.Point(633, 117)
        Me.chkIN_BCD.Name = "chkIN_BCD"
        Me.chkIN_BCD.Properties.Caption = ""
        Me.chkIN_BCD.Size = New System.Drawing.Size(32, 19)
        Me.chkIN_BCD.TabIndex = 6
        Me.chkIN_BCD.Visible = False
        '
        'labelControl2
        '
        Me.labelControl2.Enabled = False
        Me.labelControl2.Location = New System.Drawing.Point(534, 120)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(88, 13)
        Me.labelControl2.TabIndex = 11
        Me.labelControl2.Text = "In trong cân đối tk"
        Me.labelControl2.Visible = False
        '
        'cboTINH_CHAT1
        '
        Me.cboTINH_CHAT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTINH_CHAT1.EnterMoveNextControl = True
        Me.cboTINH_CHAT1.Location = New System.Drawing.Point(464, 13)
        Me.cboTINH_CHAT1.Name = "cboTINH_CHAT1"
        Me.cboTINH_CHAT1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboTINH_CHAT1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTINH_CHAT1.Properties.ImmediatePopup = True
        Me.cboTINH_CHAT1.Properties.NullText = ""
        Me.cboTINH_CHAT1.Size = New System.Drawing.Size(200, 20)
        Me.cboTINH_CHAT1.TabIndex = 4
        '
        'labelControl1
        '
        Me.labelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelControl1.Location = New System.Drawing.Point(403, 19)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(44, 13)
        Me.labelControl1.TabIndex = 7
        Me.labelControl1.Text = "Tính chất"
        '
        'mmeMO_TA
        '
        Me.mmeMO_TA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mmeMO_TA.EnterMoveNextControl = True
        Me.mmeMO_TA.Location = New System.Drawing.Point(464, 43)
        Me.mmeMO_TA.Name = "mmeMO_TA"
        Me.mmeMO_TA.Properties.MaxLength = 256
        Me.mmeMO_TA.Size = New System.Drawing.Size(200, 41)
        Me.mmeMO_TA.TabIndex = 5
        '
        'labelControl6
        '
        Me.labelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelControl6.Location = New System.Drawing.Point(417, 47)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(27, 13)
        Me.labelControl6.TabIndex = 9
        Me.labelControl6.Text = "Mô tả"
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(26, 66)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(65, 13)
        Me.labelControl5.TabIndex = 5
        Me.labelControl5.Text = "Tên tài khoản"
        '
        'txtTEN_TAIKHOAN
        '
        Me.txtTEN_TAIKHOAN.EnterMoveNextControl = True
        Me.txtTEN_TAIKHOAN.Location = New System.Drawing.Point(108, 63)
        Me.txtTEN_TAIKHOAN.Name = "txtTEN_TAIKHOAN"
        Me.txtTEN_TAIKHOAN.Properties.MaxLength = 128
        Me.txtTEN_TAIKHOAN.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_TAIKHOAN.TabIndex = 3
        '
        'txtMA_TAIKHOAN_CHA1
        '
        Me.txtMA_TAIKHOAN_CHA1.Enabled = False
        Me.txtMA_TAIKHOAN_CHA1.Location = New System.Drawing.Point(108, 37)
        Me.txtMA_TAIKHOAN_CHA1.Name = "txtMA_TAIKHOAN_CHA1"
        Me.txtMA_TAIKHOAN_CHA1.Size = New System.Drawing.Size(89, 20)
        Me.txtMA_TAIKHOAN_CHA1.TabIndex = 1
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Enabled = False
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(443, 118)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = ""
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(32, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 9
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(106, 89)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = "Có sử dụng"
        Me.chkCO_SU_DUNG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(91, 19)
        Me.chkCO_SU_DUNG.TabIndex = 6
        '
        'labelControl3
        '
        Me.labelControl3.Enabled = False
        Me.labelControl3.Location = New System.Drawing.Point(370, 120)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(67, 13)
        Me.labelControl3.TabIndex = 17
        Me.labelControl3.Text = "Cho phép sửa"
        Me.labelControl3.Visible = False
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(30, 40)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(61, 13)
        Me.lblCarFarmily_Code.TabIndex = 2
        Me.lblCarFarmily_Code.Text = "Mã tài khoản"
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 148)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(4)
        Me._ActionPanel.Size = New System.Drawing.Size(693, 46)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(348, 13)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Ð&óng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(262, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.Controls.Add(Me.chkDM_Khang)
        Me.GroupControl1.Controls.Add(Me.chkDM_Khoanphi)
        Me.GroupControl1.Controls.Add(Me.chkDM_PTQT)
        Me.GroupControl1.Controls.Add(Me.chkDM_Phongban)
        Me.GroupControl1.Controls.Add(Me.chkDM_Vuviec)
        Me.GroupControl1.Controls.Add(Me.chkDM_HopDong)
        Me.GroupControl1.Controls.Add(Me.chkDM_Tudo5)
        Me.GroupControl1.Controls.Add(Me.chkDM_Tudo4)
        Me.GroupControl1.Controls.Add(Me.chkDM_Tudo3)
        Me.GroupControl1.Controls.Add(Me.chkDM_Tudo2)
        Me.GroupControl1.Controls.Add(Me.chkDM_Tudo1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(686, 126)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'chkDM_Khang
        '
        Me.chkDM_Khang.Location = New System.Drawing.Point(24, 17)
        Me.chkDM_Khang.Name = "chkDM_Khang"
        Me.chkDM_Khang.Properties.Caption = "Danh mục khách hàng"
        Me.chkDM_Khang.Size = New System.Drawing.Size(135, 19)
        Me.chkDM_Khang.TabIndex = 0
        '
        'chkDM_Khoanphi
        '
        Me.chkDM_Khoanphi.Location = New System.Drawing.Point(182, 42)
        Me.chkDM_Khoanphi.Name = "chkDM_Khoanphi"
        Me.chkDM_Khoanphi.Properties.Caption = "Danh mục khoản phí"
        Me.chkDM_Khoanphi.Size = New System.Drawing.Size(130, 19)
        Me.chkDM_Khoanphi.TabIndex = 4
        '
        'chkDM_PTQT
        '
        Me.chkDM_PTQT.Location = New System.Drawing.Point(182, 17)
        Me.chkDM_PTQT.Name = "chkDM_PTQT"
        Me.chkDM_PTQT.Properties.Caption = "Danh mục PTQT"
        Me.chkDM_PTQT.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_PTQT.TabIndex = 3
        '
        'chkDM_Phongban
        '
        Me.chkDM_Phongban.Location = New System.Drawing.Point(24, 67)
        Me.chkDM_Phongban.Name = "chkDM_Phongban"
        Me.chkDM_Phongban.Properties.Caption = "Danh mục phòng ban"
        Me.chkDM_Phongban.Size = New System.Drawing.Size(135, 19)
        Me.chkDM_Phongban.TabIndex = 2
        '
        'chkDM_Vuviec
        '
        Me.chkDM_Vuviec.Location = New System.Drawing.Point(182, 67)
        Me.chkDM_Vuviec.Name = "chkDM_Vuviec"
        Me.chkDM_Vuviec.Properties.Caption = "Danh mục vụ việc"
        Me.chkDM_Vuviec.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Vuviec.TabIndex = 5
        '
        'chkDM_HopDong
        '
        Me.chkDM_HopDong.Location = New System.Drawing.Point(24, 42)
        Me.chkDM_HopDong.Name = "chkDM_HopDong"
        Me.chkDM_HopDong.Properties.Caption = "Danh mục hợp đồng"
        Me.chkDM_HopDong.Size = New System.Drawing.Size(126, 19)
        Me.chkDM_HopDong.TabIndex = 1
        '
        'chkDM_Tudo5
        '
        Me.chkDM_Tudo5.Location = New System.Drawing.Point(561, 42)
        Me.chkDM_Tudo5.Name = "chkDM_Tudo5"
        Me.chkDM_Tudo5.Properties.Caption = "Danh mục tự do 5"
        Me.chkDM_Tudo5.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Tudo5.TabIndex = 10
        '
        'chkDM_Tudo4
        '
        Me.chkDM_Tudo4.Location = New System.Drawing.Point(561, 17)
        Me.chkDM_Tudo4.Name = "chkDM_Tudo4"
        Me.chkDM_Tudo4.Properties.Caption = "Danh mục tự do 4"
        Me.chkDM_Tudo4.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Tudo4.TabIndex = 9
        '
        'chkDM_Tudo3
        '
        Me.chkDM_Tudo3.Location = New System.Drawing.Point(420, 67)
        Me.chkDM_Tudo3.Name = "chkDM_Tudo3"
        Me.chkDM_Tudo3.Properties.Caption = "Danh mục tự do 3"
        Me.chkDM_Tudo3.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Tudo3.TabIndex = 8
        '
        'chkDM_Tudo2
        '
        Me.chkDM_Tudo2.Location = New System.Drawing.Point(420, 42)
        Me.chkDM_Tudo2.Name = "chkDM_Tudo2"
        Me.chkDM_Tudo2.Properties.Caption = "Danh mục tự do 2"
        Me.chkDM_Tudo2.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Tudo2.TabIndex = 7
        '
        'chkDM_Tudo1
        '
        Me.chkDM_Tudo1.Location = New System.Drawing.Point(420, 17)
        Me.chkDM_Tudo1.Name = "chkDM_Tudo1"
        Me.chkDM_Tudo1.Properties.Caption = "Danh mục tự do 1"
        Me.chkDM_Tudo1.Size = New System.Drawing.Size(115, 19)
        Me.chkDM_Tudo1.TabIndex = 6
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtbChiTiet
        Me.XtraTabControl1.Size = New System.Drawing.Size(693, 144)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtbChiTiet, Me.xtbBoSung})
        '
        'xtbChiTiet
        '
        Me.xtbChiTiet.Controls.Add(Me._GroupControlObjectInfo)
        Me.xtbChiTiet.Name = "xtbChiTiet"
        Me.xtbChiTiet.Size = New System.Drawing.Size(686, 115)
        Me.xtbChiTiet.Text = "Thông tin chi tiết"
        '
        'xtbBoSung
        '
        Me.xtbBoSung.Controls.Add(Me.GroupControl1)
        Me.xtbBoSung.Name = "xtbBoSung"
        Me.xtbBoSung.Size = New System.Drawing.Size(686, 126)
        Me.xtbBoSung.Text = "Thông tin bổ sung"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'cboChiTiet
        '
        Me.cboChiTiet.EditValue = True
        Me.cboChiTiet.Location = New System.Drawing.Point(309, 89)
        Me.cboChiTiet.Name = "cboChiTiet"
        Me.cboChiTiet.Properties.Caption = "Tk Chi tiết"
        Me.cboChiTiet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboChiTiet.Size = New System.Drawing.Size(91, 19)
        Me.cboChiTiet.TabIndex = 7
        '
        'frmDanhMucTaiKhoan_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(701, 198)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me._ActionPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucTaiKhoan_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục tài khoản"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        Me._GroupControlObjectInfo.PerformLayout()
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TAIKHOAN1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTB_NB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIN_BCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTINH_CHAT1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_TAIKHOAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TAIKHOAN_CHA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkDM_Khang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Khoanphi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_PTQT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Phongban.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Vuviec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_HopDong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Tudo5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Tudo4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Tudo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Tudo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_Tudo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtbChiTiet.ResumeLayout(False)
        Me.xtbBoSung.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboChiTiet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Private txtMA_TAIKHOAN_CHA1 As DevExpress.XtraEditors.TextEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Friend labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend labelControl5 As DevExpress.XtraEditors.LabelControl
    Private txtTEN_TAIKHOAN As DevExpress.XtraEditors.TextEdit
    Private chkTB_NB As DevExpress.XtraEditors.CheckEdit
    Private chkIN_BCD As DevExpress.XtraEditors.CheckEdit
    Friend labelControl2 As DevExpress.XtraEditors.LabelControl
    Friend cboTINH_CHAT1 As DevExpress.XtraEditors.LookUpEdit
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private mmeMO_TA As DevExpress.XtraEditors.MemoEdit
    Private WithEvents txtMA_TAIKHOAN1 As DevExpress.XtraEditors.TextEdit
    Friend labelControl11 As DevExpress.XtraEditors.LabelControl
    Private lblNhomTaiKhoan As DevExpress.XtraEditors.LabelControl
    Private chkCHI_TIET As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkDM_Tudo5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Tudo4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Tudo3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Tudo2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Tudo1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Khang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Khoanphi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_PTQT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Phongban As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_Vuviec As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDM_HopDong As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtbChiTiet As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtbBoSung As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents cFilterTaiKhoan As CustomFilter
    Private WithEvents cboChiTiet As DevExpress.XtraEditors.CheckEdit
End Class
