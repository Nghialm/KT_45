Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmDanhMucLoaiChungTu_ChiTiet
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
        Me.chkCHI_TIET = New DevExpress.XtraEditors.CheckEdit()
        Me._panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSO_CT_HIENTHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtPREFIX_CT = New DevExpress.XtraEditors.TextEdit()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValue = New DevExpress.XtraEditors.LabelControl()
        Me.txtMAU_SO_CT = New DevExpress.XtraEditors.TextEdit()
        Me.cboLOAI_CT_ID_CHA = New DevExpress.XtraEditors.LookUpEdit()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDUONG_DAN = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_LOAI_CT = New DevExpress.XtraEditors.TextEdit()
        Me.txtKy_Hieu = New DevExpress.XtraEditors.TextEdit()
        Me.txtMO_TA = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMA_TK_CO_LQ = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMA_TK_NO_LQ = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMA_LOAI_CT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTK_THUE_NGAMDINH = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtKHO_XUAT = New DevExpress.XtraEditors.TextEdit()
        Me.txtPHIEU_XUAT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDM_HOADON = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_KHANG = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_CBNV = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_HOPDONG = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_KHOANPHI = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_TUDO1 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_TUDO2 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_TUDO3 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_PTQT = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_TUDO5 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_VUVIEC = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_PHONGBAN = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDM_TUDO4 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSD_TK_THUE_NGAMDINH = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.pageMain = New DevExpress.XtraTab.XtraTabPage()
        Me.pageDM = New DevExpress.XtraTab.XtraTabPage()
        Me.grcMain = New DevExpress.XtraGrid.GridControl()
        Me.grvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.orderTHU_TU = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.chk_CO_SU_DUNG = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._panel1.SuspendLayout()
        CType(Me.txtSO_CT_HIENTHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPREFIX_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMAU_SO_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLOAI_CT_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDUONG_DAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TK_CO_LQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_TK_NO_LQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTK_THUE_NGAMDINH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtKHO_XUAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPHIEU_XUAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkDM_HOADON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_CBNV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_HOPDONG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_TUDO1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_TUDO2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_TUDO3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_PTQT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_TUDO5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_PHONGBAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDM_TUDO4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSD_TK_THUE_NGAMDINH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pageMain.SuspendLayout()
        Me.pageDM.SuspendLayout()
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderTHU_TU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_CO_SU_DUNG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCHI_TIET)
        Me._GroupControlObjectInfo.Controls.Add(Me._panel1)
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupBox2)
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupBox1)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkSD_TK_THUE_NGAMDINH)
        Me._GroupControlObjectInfo.Controls.Add(Me.chkCO_SU_DUNG)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(0, 0)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.Padding = New System.Windows.Forms.Padding(4)
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(754, 351)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mã danh m?c t? do 2"
        '
        'chkCHI_TIET
        '
        Me.chkCHI_TIET.EditValue = True
        Me.chkCHI_TIET.Location = New System.Drawing.Point(466, 315)
        Me.chkCHI_TIET.Name = "chkCHI_TIET"
        Me.chkCHI_TIET.Properties.Caption = "Chi tiết"
        Me.chkCHI_TIET.Size = New System.Drawing.Size(108, 19)
        Me.chkCHI_TIET.TabIndex = 5
        '
        '_panel1
        '
        Me._panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._panel1.Controls.Add(Me.LabelControl9)
        Me._panel1.Controls.Add(Me.txtSO_CT_HIENTHI)
        Me._panel1.Controls.Add(Me.txtPREFIX_CT)
        Me._panel1.Controls.Add(Me.lblCarFarmily_Code)
        Me._panel1.Controls.Add(Me.LabelControl8)
        Me._panel1.Controls.Add(Me.lblValue)
        Me._panel1.Controls.Add(Me.txtMAU_SO_CT)
        Me._panel1.Controls.Add(Me.cboLOAI_CT_ID_CHA)
        Me._panel1.Controls.Add(Me.labelControl6)
        Me._panel1.Controls.Add(Me.LabelControl17)
        Me._panel1.Controls.Add(Me.txtDUONG_DAN)
        Me._panel1.Controls.Add(Me.labelControl1)
        Me._panel1.Controls.Add(Me.LabelControl2)
        Me._panel1.Controls.Add(Me.txtTEN_LOAI_CT)
        Me._panel1.Controls.Add(Me.txtKy_Hieu)
        Me._panel1.Controls.Add(Me.txtMO_TA)
        Me._panel1.Controls.Add(Me.txtMA_TK_CO_LQ)
        Me._panel1.Controls.Add(Me.labelControl3)
        Me._panel1.Controls.Add(Me.txtMA_TK_NO_LQ)
        Me._panel1.Controls.Add(Me.labelControl5)
        Me._panel1.Controls.Add(Me.txtMA_LOAI_CT)
        Me._panel1.Controls.Add(Me.LabelControl4)
        Me._panel1.Controls.Add(Me.labelControl14)
        Me._panel1.Controls.Add(Me.labelControl7)
        Me._panel1.Controls.Add(Me.cboTK_THUE_NGAMDINH)
        Me._panel1.Location = New System.Drawing.Point(7, 5)
        Me._panel1.Name = "_panel1"
        Me._panel1.Size = New System.Drawing.Size(451, 333)
        Me._panel1.TabIndex = 0
        '
        'txtSO_CT_HIENTHI
        '
        Me.txtSO_CT_HIENTHI.EnterMoveNextControl = True
        Me.txtSO_CT_HIENTHI.Location = New System.Drawing.Point(121, 166)
        Me.txtSO_CT_HIENTHI.Name = "txtSO_CT_HIENTHI"
        Me.txtSO_CT_HIENTHI.Properties.Mask.EditMask = "[0-9]+"
        Me.txtSO_CT_HIENTHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSO_CT_HIENTHI.Size = New System.Drawing.Size(200, 20)
        Me.txtSO_CT_HIENTHI.TabIndex = 6
        '
        'txtPREFIX_CT
        '
        Me.txtPREFIX_CT.EnterMoveNextControl = True
        Me.txtPREFIX_CT.Location = New System.Drawing.Point(121, 115)
        Me.txtPREFIX_CT.Name = "txtPREFIX_CT"
        Me.txtPREFIX_CT.Size = New System.Drawing.Size(200, 20)
        Me.txtPREFIX_CT.TabIndex = 4
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(63, 41)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(35, 13)
        Me.lblCarFarmily_Code.TabIndex = 22
        Me.lblCarFarmily_Code.Text = "Ký hiệu"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(42, 118)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl8.TabIndex = 48
        Me.LabelControl8.Text = "Ký hiệu đầu"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(14, 66)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(84, 13)
        Me.lblValue.TabIndex = 20
        Me.lblValue.Text = "Tên loại chứng từ"
        '
        'txtMAU_SO_CT
        '
        Me.txtMAU_SO_CT.EnterMoveNextControl = True
        Me.txtMAU_SO_CT.Location = New System.Drawing.Point(121, 140)
        Me.txtMAU_SO_CT.Name = "txtMAU_SO_CT"
        Me.txtMAU_SO_CT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMAU_SO_CT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMAU_SO_CT.Properties.Mask.EditMask = "[1-9]{1}"
        Me.txtMAU_SO_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMAU_SO_CT.Size = New System.Drawing.Size(200, 20)
        Me.txtMAU_SO_CT.TabIndex = 5
        '
        'cboLOAI_CT_ID_CHA
        '
        Me.cboLOAI_CT_ID_CHA.AllowDrop = True
        Me.cboLOAI_CT_ID_CHA.EditValue = "0"
        Me.cboLOAI_CT_ID_CHA.EnterMoveNextControl = True
        Me.cboLOAI_CT_ID_CHA.Location = New System.Drawing.Point(121, 89)
        Me.cboLOAI_CT_ID_CHA.Name = "cboLOAI_CT_ID_CHA"
        Me.cboLOAI_CT_ID_CHA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboLOAI_CT_ID_CHA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboLOAI_CT_ID_CHA.Properties.Appearance.Options.UseBackColor = True
        Me.cboLOAI_CT_ID_CHA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboLOAI_CT_ID_CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAI_CT_ID_CHA.Properties.ImmediatePopup = True
        Me.cboLOAI_CT_ID_CHA.Properties.NullText = ""
        Me.cboLOAI_CT_ID_CHA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboLOAI_CT_ID_CHA.Size = New System.Drawing.Size(200, 20)
        Me.cboLOAI_CT_ID_CHA.TabIndex = 3
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(17, 143)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(81, 13)
        Me.labelControl6.TabIndex = 48
        Me.labelControl6.Text = "Mẫu số chứng từ"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(5, 92)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl17.TabIndex = 23
        Me.LabelControl17.Text = "Nhóm loại chứng từ"
        '
        'txtDUONG_DAN
        '
        Me.txtDUONG_DAN.EnterMoveNextControl = True
        Me.txtDUONG_DAN.Location = New System.Drawing.Point(121, 230)
        Me.txtDUONG_DAN.Name = "txtDUONG_DAN"
        Me.txtDUONG_DAN.Size = New System.Drawing.Size(200, 20)
        Me.txtDUONG_DAN.TabIndex = 8
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(71, 195)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(27, 13)
        Me.labelControl1.TabIndex = 25
        Me.labelControl1.Text = "Mô tả"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(44, 233)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Đường dẫn"
        '
        'txtTEN_LOAI_CT
        '
        Me.txtTEN_LOAI_CT.EnterMoveNextControl = True
        Me.txtTEN_LOAI_CT.Location = New System.Drawing.Point(121, 63)
        Me.txtTEN_LOAI_CT.Name = "txtTEN_LOAI_CT"
        Me.txtTEN_LOAI_CT.Size = New System.Drawing.Size(200, 20)
        Me.txtTEN_LOAI_CT.TabIndex = 2
        '
        'txtKy_Hieu
        '
        Me.txtKy_Hieu.EnterMoveNextControl = True
        Me.txtKy_Hieu.Location = New System.Drawing.Point(121, 38)
        Me.txtKy_Hieu.Name = "txtKy_Hieu"
        Me.txtKy_Hieu.Size = New System.Drawing.Size(200, 20)
        Me.txtKy_Hieu.TabIndex = 1
        '
        'txtMO_TA
        '
        Me.txtMO_TA.EnterMoveNextControl = True
        Me.txtMO_TA.Location = New System.Drawing.Point(121, 192)
        Me.txtMO_TA.Name = "txtMO_TA"
        Me.txtMO_TA.Size = New System.Drawing.Size(200, 32)
        Me.txtMO_TA.TabIndex = 7
        '
        'txtMA_TK_CO_LQ
        '
        Me.txtMA_TK_CO_LQ.EnterMoveNextControl = True
        Me.txtMA_TK_CO_LQ.Location = New System.Drawing.Point(121, 282)
        Me.txtMA_TK_CO_LQ.Name = "txtMA_TK_CO_LQ"
        Me.txtMA_TK_CO_LQ.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_TK_CO_LQ.TabIndex = 10
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(25, 259)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(73, 13)
        Me.labelControl3.TabIndex = 26
        Me.labelControl3.Text = "TK nợ liên quan"
        '
        'txtMA_TK_NO_LQ
        '
        Me.txtMA_TK_NO_LQ.EnterMoveNextControl = True
        Me.txtMA_TK_NO_LQ.Location = New System.Drawing.Point(121, 256)
        Me.txtMA_TK_NO_LQ.Name = "txtMA_TK_NO_LQ"
        Me.txtMA_TK_NO_LQ.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_TK_NO_LQ.TabIndex = 9
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(26, 289)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(72, 13)
        Me.labelControl5.TabIndex = 27
        Me.labelControl5.Text = "TK có liên quan"
        '
        'txtMA_LOAI_CT
        '
        Me.txtMA_LOAI_CT.EnterMoveNextControl = True
        Me.txtMA_LOAI_CT.Location = New System.Drawing.Point(121, 13)
        Me.txtMA_LOAI_CT.Name = "txtMA_LOAI_CT"
        Me.txtMA_LOAI_CT.Size = New System.Drawing.Size(200, 20)
        Me.txtMA_LOAI_CT.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 169)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Số bản ghi hiển thị"
        '
        'labelControl14
        '
        Me.labelControl14.Location = New System.Drawing.Point(18, 16)
        Me.labelControl14.Name = "labelControl14"
        Me.labelControl14.Size = New System.Drawing.Size(80, 13)
        Me.labelControl14.TabIndex = 21
        Me.labelControl14.Text = "Mã loại chứng từ"
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(15, 311)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(83, 13)
        Me.labelControl7.TabIndex = 28
        Me.labelControl7.Text = "TK thu ngầm định"
        '
        'cboTK_THUE_NGAMDINH
        '
        Me.cboTK_THUE_NGAMDINH.AllowDrop = True
        Me.cboTK_THUE_NGAMDINH.EditValue = "0"
        Me.cboTK_THUE_NGAMDINH.Enabled = False
        Me.cboTK_THUE_NGAMDINH.EnterMoveNextControl = True
        Me.cboTK_THUE_NGAMDINH.Location = New System.Drawing.Point(121, 308)
        Me.cboTK_THUE_NGAMDINH.Name = "cboTK_THUE_NGAMDINH"
        Me.cboTK_THUE_NGAMDINH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboTK_THUE_NGAMDINH.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboTK_THUE_NGAMDINH.Properties.Appearance.Options.UseBackColor = True
        Me.cboTK_THUE_NGAMDINH.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboTK_THUE_NGAMDINH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTK_THUE_NGAMDINH.Properties.ImmediatePopup = True
        Me.cboTK_THUE_NGAMDINH.Properties.NullText = ""
        Me.cboTK_THUE_NGAMDINH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboTK_THUE_NGAMDINH.Size = New System.Drawing.Size(200, 20)
        Me.cboTK_THUE_NGAMDINH.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKHO_XUAT)
        Me.GroupBox2.Controls.Add(Me.txtPHIEU_XUAT)
        Me.GroupBox2.Controls.Add(Me.LabelControl19)
        Me.GroupBox2.Controls.Add(Me.LabelControl16)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 76)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtKHO_XUAT
        '
        Me.txtKHO_XUAT.EnterMoveNextControl = True
        Me.txtKHO_XUAT.Location = New System.Drawing.Point(104, 44)
        Me.txtKHO_XUAT.Name = "txtKHO_XUAT"
        Me.txtKHO_XUAT.Properties.Mask.EditMask = "[0-9]+"
        Me.txtKHO_XUAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtKHO_XUAT.Size = New System.Drawing.Size(141, 20)
        Me.txtKHO_XUAT.TabIndex = 1
        '
        'txtPHIEU_XUAT
        '
        Me.txtPHIEU_XUAT.EnterMoveNextControl = True
        Me.txtPHIEU_XUAT.Location = New System.Drawing.Point(104, 18)
        Me.txtPHIEU_XUAT.Name = "txtPHIEU_XUAT"
        Me.txtPHIEU_XUAT.Properties.Mask.EditMask = "[0-9]+"
        Me.txtPHIEU_XUAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtPHIEU_XUAT.Size = New System.Drawing.Size(141, 20)
        Me.txtPHIEU_XUAT.TabIndex = 0
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(43, 47)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl19.TabIndex = 46
        Me.LabelControl19.Text = "Kho xuất"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(35, 21)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl16.TabIndex = 45
        Me.LabelControl16.Text = "Phiếu xuất"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDM_HOADON)
        Me.GroupBox1.Controls.Add(Me.chkDM_KHANG)
        Me.GroupBox1.Controls.Add(Me.chkDM_CBNV)
        Me.GroupBox1.Controls.Add(Me.chkDM_HOPDONG)
        Me.GroupBox1.Controls.Add(Me.chkDM_KHOANPHI)
        Me.GroupBox1.Controls.Add(Me.chkDM_TUDO1)
        Me.GroupBox1.Controls.Add(Me.chkDM_TUDO2)
        Me.GroupBox1.Controls.Add(Me.chkDM_TUDO3)
        Me.GroupBox1.Controls.Add(Me.chkDM_PTQT)
        Me.GroupBox1.Controls.Add(Me.chkDM_TUDO5)
        Me.GroupBox1.Controls.Add(Me.chkDM_VUVIEC)
        Me.GroupBox1.Controls.Add(Me.chkDM_PHONGBAN)
        Me.GroupBox1.Controls.Add(Me.chkDM_TUDO4)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 199)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh mục"
        '
        'chkDM_HOADON
        '
        Me.chkDM_HOADON.EditValue = True
        Me.chkDM_HOADON.Location = New System.Drawing.Point(14, 171)
        Me.chkDM_HOADON.Name = "chkDM_HOADON"
        Me.chkDM_HOADON.Properties.Caption = "DM hóa đơn"
        Me.chkDM_HOADON.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_HOADON.TabIndex = 5
        '
        'chkDM_KHANG
        '
        Me.chkDM_KHANG.EditValue = True
        Me.chkDM_KHANG.Location = New System.Drawing.Point(14, 146)
        Me.chkDM_KHANG.Name = "chkDM_KHANG"
        Me.chkDM_KHANG.Properties.Caption = "DM khách hàng"
        Me.chkDM_KHANG.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_KHANG.TabIndex = 5
        '
        'chkDM_CBNV
        '
        Me.chkDM_CBNV.EditValue = True
        Me.chkDM_CBNV.Location = New System.Drawing.Point(132, 146)
        Me.chkDM_CBNV.Name = "chkDM_CBNV"
        Me.chkDM_CBNV.Properties.Caption = "DM CBNV"
        Me.chkDM_CBNV.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_CBNV.TabIndex = 11
        '
        'chkDM_HOPDONG
        '
        Me.chkDM_HOPDONG.EditValue = True
        Me.chkDM_HOPDONG.Location = New System.Drawing.Point(14, 45)
        Me.chkDM_HOPDONG.Name = "chkDM_HOPDONG"
        Me.chkDM_HOPDONG.Properties.Caption = "DM hợp đồng"
        Me.chkDM_HOPDONG.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_HOPDONG.TabIndex = 1
        '
        'chkDM_KHOANPHI
        '
        Me.chkDM_KHOANPHI.EditValue = True
        Me.chkDM_KHOANPHI.Location = New System.Drawing.Point(14, 96)
        Me.chkDM_KHOANPHI.Name = "chkDM_KHOANPHI"
        Me.chkDM_KHOANPHI.Properties.Caption = "DM khoản phí"
        Me.chkDM_KHOANPHI.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_KHOANPHI.TabIndex = 3
        '
        'chkDM_TUDO1
        '
        Me.chkDM_TUDO1.EditValue = True
        Me.chkDM_TUDO1.Location = New System.Drawing.Point(132, 20)
        Me.chkDM_TUDO1.Name = "chkDM_TUDO1"
        Me.chkDM_TUDO1.Properties.Caption = "DM tự do 1"
        Me.chkDM_TUDO1.Size = New System.Drawing.Size(124, 19)
        Me.chkDM_TUDO1.TabIndex = 6
        '
        'chkDM_TUDO2
        '
        Me.chkDM_TUDO2.EditValue = True
        Me.chkDM_TUDO2.Location = New System.Drawing.Point(132, 45)
        Me.chkDM_TUDO2.Name = "chkDM_TUDO2"
        Me.chkDM_TUDO2.Properties.Caption = "DM tự do 2"
        Me.chkDM_TUDO2.Size = New System.Drawing.Size(124, 19)
        Me.chkDM_TUDO2.TabIndex = 7
        '
        'chkDM_TUDO3
        '
        Me.chkDM_TUDO3.EditValue = True
        Me.chkDM_TUDO3.Location = New System.Drawing.Point(132, 71)
        Me.chkDM_TUDO3.Name = "chkDM_TUDO3"
        Me.chkDM_TUDO3.Properties.Caption = "DM tự do 3"
        Me.chkDM_TUDO3.Size = New System.Drawing.Size(124, 19)
        Me.chkDM_TUDO3.TabIndex = 8
        '
        'chkDM_PTQT
        '
        Me.chkDM_PTQT.EditValue = True
        Me.chkDM_PTQT.Location = New System.Drawing.Point(14, 20)
        Me.chkDM_PTQT.Name = "chkDM_PTQT"
        Me.chkDM_PTQT.Properties.Caption = "DM PTQT"
        Me.chkDM_PTQT.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_PTQT.TabIndex = 0
        '
        'chkDM_TUDO5
        '
        Me.chkDM_TUDO5.EditValue = True
        Me.chkDM_TUDO5.Location = New System.Drawing.Point(132, 121)
        Me.chkDM_TUDO5.Name = "chkDM_TUDO5"
        Me.chkDM_TUDO5.Properties.Caption = "DM tự do 5"
        Me.chkDM_TUDO5.Size = New System.Drawing.Size(124, 19)
        Me.chkDM_TUDO5.TabIndex = 10
        '
        'chkDM_VUVIEC
        '
        Me.chkDM_VUVIEC.EditValue = True
        Me.chkDM_VUVIEC.Location = New System.Drawing.Point(14, 121)
        Me.chkDM_VUVIEC.Name = "chkDM_VUVIEC"
        Me.chkDM_VUVIEC.Properties.Caption = "DM vụ việc"
        Me.chkDM_VUVIEC.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_VUVIEC.TabIndex = 4
        '
        'chkDM_PHONGBAN
        '
        Me.chkDM_PHONGBAN.EditValue = True
        Me.chkDM_PHONGBAN.Location = New System.Drawing.Point(14, 71)
        Me.chkDM_PHONGBAN.Name = "chkDM_PHONGBAN"
        Me.chkDM_PHONGBAN.Properties.Caption = "DM phòng ban"
        Me.chkDM_PHONGBAN.Size = New System.Drawing.Size(95, 19)
        Me.chkDM_PHONGBAN.TabIndex = 2
        '
        'chkDM_TUDO4
        '
        Me.chkDM_TUDO4.EditValue = True
        Me.chkDM_TUDO4.Location = New System.Drawing.Point(132, 96)
        Me.chkDM_TUDO4.Name = "chkDM_TUDO4"
        Me.chkDM_TUDO4.Properties.Caption = "DM tự do 4"
        Me.chkDM_TUDO4.Size = New System.Drawing.Size(124, 19)
        Me.chkDM_TUDO4.TabIndex = 9
        '
        'chkSD_TK_THUE_NGAMDINH
        '
        Me.chkSD_TK_THUE_NGAMDINH.EditValue = True
        Me.chkSD_TK_THUE_NGAMDINH.Location = New System.Drawing.Point(466, 290)
        Me.chkSD_TK_THUE_NGAMDINH.Name = "chkSD_TK_THUE_NGAMDINH"
        Me.chkSD_TK_THUE_NGAMDINH.Properties.Caption = "SD tài khoản thuế"
        Me.chkSD_TK_THUE_NGAMDINH.Size = New System.Drawing.Size(118, 19)
        Me.chkSD_TK_THUE_NGAMDINH.TabIndex = 3
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(590, 291)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = "Có sử dụng"
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(85, 19)
        Me.chkCO_SU_DUNG.TabIndex = 4
        '
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(4, 384)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(4)
        Me._ActionPanel.Size = New System.Drawing.Size(761, 34)
        Me._ActionPanel.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(613, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Đóng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(65, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'tabMain
        '
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(4, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.pageMain
        Me.tabMain.Size = New System.Drawing.Size(761, 380)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pageMain, Me.pageDM})
        '
        'pageMain
        '
        Me.pageMain.Controls.Add(Me._GroupControlObjectInfo)
        Me.pageMain.Name = "pageMain"
        Me.pageMain.Size = New System.Drawing.Size(754, 351)
        Me.pageMain.Text = "Thông tin cơ bản"
        '
        'pageDM
        '
        Me.pageDM.Controls.Add(Me.grcMain)
        Me.pageDM.Name = "pageDM"
        Me.pageDM.PageVisible = False
        Me.pageDM.Size = New System.Drawing.Size(624, 351)
        Me.pageDM.Text = "Danh mục"
        '
        'grcMain
        '
        Me.grcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcMain.Location = New System.Drawing.Point(0, 0)
        Me.grcMain.MainView = Me.grvMain
        Me.grcMain.Name = "grcMain"
        Me.grcMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chk_CO_SU_DUNG, Me.orderTHU_TU})
        Me.grcMain.Size = New System.Drawing.Size(624, 351)
        Me.grcMain.TabIndex = 0
        Me.grcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMain})
        '
        'grvMain
        '
        Me.grvMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grvMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.Empty.Options.UseBackColor = True
        Me.grvMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grvMain.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grvMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvMain.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grvMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grvMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvMain.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grvMain.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grvMain.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvMain.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvMain.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grvMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.grvMain.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.grvMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvMain.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvMain.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvMain.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grvMain.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grvMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvMain.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvMain.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.OddRow.Options.UseBackColor = True
        Me.grvMain.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.OddRow.Options.UseForeColor = True
        Me.grvMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.grvMain.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.grvMain.Appearance.Preview.Options.UseBackColor = True
        Me.grvMain.Appearance.Preview.Options.UseFont = True
        Me.grvMain.Appearance.Preview.Options.UseForeColor = True
        Me.grvMain.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvMain.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.Row.Options.UseBackColor = True
        Me.grvMain.Appearance.Row.Options.UseForeColor = True
        Me.grvMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grvMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvMain.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvMain.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grvMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvMain.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvMain.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvMain.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvMain.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grvMain.Appearance.VertLine.Options.UseBackColor = True
        Me.grvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4})
        Me.grvMain.GridControl = Me.grcMain
        Me.grvMain.Name = "grvMain"
        Me.grvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.grvMain.OptionsView.EnableAppearanceOddRow = True
        Me.grvMain.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã danh mục"
        Me.GridColumn1.FieldName = "MA_DM"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên danh mục"
        Me.GridColumn2.FieldName = "TEN_DM"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 310
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Thứ tự"
        Me.GridColumn4.ColumnEdit = Me.orderTHU_TU
        Me.GridColumn4.FieldName = "THU_TU"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 91
        '
        'orderTHU_TU
        '
        Me.orderTHU_TU.AutoHeight = False
        Me.orderTHU_TU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.orderTHU_TU.Name = "orderTHU_TU"
        '
        'chk_CO_SU_DUNG
        '
        Me.chk_CO_SU_DUNG.AutoHeight = False
        Me.chk_CO_SU_DUNG.Name = "chk_CO_SU_DUNG"
        Me.chk_CO_SU_DUNG.ValueChecked = 1
        Me.chk_CO_SU_DUNG.ValueUnchecked = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl9.Location = New System.Drawing.Point(327, 118)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl9.TabIndex = 49
        Me.LabelControl9.Text = "xx-[yyyyMM]-{0}"
        '
        'frmDanhMucLoaiChungTu_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(769, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me._ActionPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucLoaiChungTu_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục loại chứng từ"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        CType(Me.chkCHI_TIET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._panel1.ResumeLayout(False)
        Me._panel1.PerformLayout()
        CType(Me.txtSO_CT_HIENTHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPREFIX_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMAU_SO_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLOAI_CT_ID_CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDUONG_DAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKy_Hieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMO_TA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TK_CO_LQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_TK_NO_LQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTK_THUE_NGAMDINH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtKHO_XUAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPHIEU_XUAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.chkDM_HOADON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_CBNV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_HOPDONG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_KHOANPHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_TUDO1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_TUDO2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_TUDO3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_PTQT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_TUDO5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_VUVIEC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_PHONGBAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDM_TUDO4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSD_TK_THUE_NGAMDINH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pageMain.ResumeLayout(False)
        Me.pageDM.ResumeLayout(False)
        CType(Me.grcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderTHU_TU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_CO_SU_DUNG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend cboLOAI_CT_ID_CHA As DevExpress.XtraEditors.LookUpEdit
    Friend lblValue As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend labelControl1 As DevExpress.XtraEditors.LabelControl
    Private txtTEN_LOAI_CT As DevExpress.XtraEditors.TextEdit
    Private txtKy_Hieu As DevExpress.XtraEditors.TextEdit
    Private txtMO_TA As DevExpress.XtraEditors.MemoEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private chkCHI_TIET As DevExpress.XtraEditors.CheckEdit
    Friend labelControl3 As DevExpress.XtraEditors.LabelControl
    Friend labelControl5 As DevExpress.XtraEditors.LabelControl
    Friend cboTK_THUE_NGAMDINH As DevExpress.XtraEditors.LookUpEdit
    Friend labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkSD_TK_THUE_NGAMDINH As DevExpress.XtraEditors.CheckEdit
    Private chkDM_TUDO1 As DevExpress.XtraEditors.CheckEdit
    Private chkDM_TUDO2 As DevExpress.XtraEditors.CheckEdit
    Private chkDM_TUDO4 As DevExpress.XtraEditors.CheckEdit
    Private chkDM_PTQT As DevExpress.XtraEditors.CheckEdit
    Private chkDM_PHONGBAN As DevExpress.XtraEditors.CheckEdit
    Private chkDM_TUDO3 As DevExpress.XtraEditors.CheckEdit
    Private chkDM_TUDO5 As DevExpress.XtraEditors.CheckEdit
    Private chkDM_VUVIEC As DevExpress.XtraEditors.CheckEdit
    Private txtMA_LOAI_CT As DevExpress.XtraEditors.TextEdit
    Friend labelControl14 As DevExpress.XtraEditors.LabelControl
    Private txtMA_TK_CO_LQ As DevExpress.XtraEditors.TextEdit
    Private txtMA_TK_NO_LQ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtKHO_XUAT As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtPHIEU_XUAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkDM_KHOANPHI As DevExpress.XtraEditors.CheckEdit
    Private WithEvents chkDM_HOPDONG As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents chkDM_CBNV As DevExpress.XtraEditors.CheckEdit
    Private WithEvents chkDM_KHANG As DevExpress.XtraEditors.CheckEdit
    Private WithEvents txtDUONG_DAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pageMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageDM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chk_CO_SU_DUNG As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents orderTHU_TU As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents txtMAU_SO_CT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtSO_CT_HIENTHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtPREFIX_CT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _panel1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents chkDM_HOADON As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
