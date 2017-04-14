Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmDanhMucHangHoa_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhMucHangHoa_ChiTiet))
        Me._GroupControlObjectInfo = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLOAI_HANG_HOA = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaHanghoa = New DevExpress.XtraEditors.TextEdit()
        Me.chkChiTiet = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDmVatTuCha = New Vns.Erp.Core.CustomFilter()
        Me.txtVI_TRI = New DevExpress.XtraEditors.TextEdit()
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.Color = New DevExpress.XtraEditors.LabelControl()
        Me.grlDVT_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTHAN_VO = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_HANGHOA = New DevExpress.XtraEditors.TextEdit()
        Me.txtKY_HIEU = New DevExpress.XtraEditors.TextEdit()
        Me.txtNUOC_SANXUAT = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNAM_SANXUAT1 = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.grlTEN_PP_HTK1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_KHO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_HB_TRALAI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_SP_DD = New DevExpress.XtraEditors.TextEdit()
        Me.txtMD_TK_GIABAN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_GIAVON = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_GIABAN_NB = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_NHOM_VT_1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_NHOM_VT_2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_NHOM_VT_3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.TEN_NHOM_VT_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_NHOM_VT_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboLOAI_HANG_HOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaHanghoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChiTiet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVI_TRI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlDVT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTHAN_VO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_HANGHOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNUOC_SANXUAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNAM_SANXUAT1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTEN_PP_HTK1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtMD_TK_KHO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_HB_TRALAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_SP_DD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIABAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIAVON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIABAN_NB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grlID_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlID_NHOM_VT_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlID_NHOM_VT_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_GroupControlObjectInfo
        '
        Me._GroupControlObjectInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.PanelControl2)
        Me._GroupControlObjectInfo.Controls.Add(Me.PanelControl1)
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupControl3)
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupControl2)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(4, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(735, 347)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cboLOAI_HANG_HOA)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtMaHanghoa)
        Me.GroupControl1.Controls.Add(Me.chkChiTiet)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtDmVatTuCha)
        Me.GroupControl1.Controls.Add(Me.txtVI_TRI)
        Me.GroupControl1.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.Color)
        Me.GroupControl1.Controls.Add(Me.grlDVT_ID)
        Me.GroupControl1.Controls.Add(Me.chkCO_SU_DUNG)
        Me.GroupControl1.Controls.Add(Me.chkTHAN_VO)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.lblCarFarmily_Code)
        Me.GroupControl1.Controls.Add(Me.txtTEN_HANGHOA)
        Me.GroupControl1.Controls.Add(Me.txtKY_HIEU)
        Me.GroupControl1.Controls.Add(Me.txtNUOC_SANXUAT)
        Me.GroupControl1.Controls.Add(Me.labelControl5)
        Me.GroupControl1.Controls.Add(Me.txtNAM_SANXUAT1)
        Me.GroupControl1.Controls.Add(Me.labelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.grlTEN_PP_HTK1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 38)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(735, 186)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.UseDisabledStatePainter = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(385, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Loại hàng hóa"
        '
        'cboLOAI_HANG_HOA
        '
        Me.cboLOAI_HANG_HOA.EditValue = ""
        Me.cboLOAI_HANG_HOA.EnterMoveNextControl = True
        Me.cboLOAI_HANG_HOA.Location = New System.Drawing.Point(469, 59)
        Me.cboLOAI_HANG_HOA.Name = "cboLOAI_HANG_HOA"
        Me.cboLOAI_HANG_HOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboLOAI_HANG_HOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAI_HANG_HOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDanhmuc", "Loại vật tư/ hàng hóa")})
        Me.cboLOAI_HANG_HOA.Properties.DisplayMember = "TenDanhmuc"
        Me.cboLOAI_HANG_HOA.Properties.ImmediatePopup = True
        Me.cboLOAI_HANG_HOA.Properties.NullText = ""
        Me.cboLOAI_HANG_HOA.Properties.ValueMember = "GiaTri"
        Me.cboLOAI_HANG_HOA.Size = New System.Drawing.Size(243, 20)
        Me.cboLOAI_HANG_HOA.TabIndex = 26
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Location = New System.Drawing.Point(33, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Mã vật tư"
        '
        'txtMaHanghoa
        '
        Me.txtMaHanghoa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMaHanghoa.EnterMoveNextControl = True
        Me.txtMaHanghoa.Location = New System.Drawing.Point(97, 34)
        Me.txtMaHanghoa.Name = "txtMaHanghoa"
        Me.txtMaHanghoa.Properties.MaxLength = 64
        Me.txtMaHanghoa.Size = New System.Drawing.Size(243, 20)
        Me.txtMaHanghoa.TabIndex = 1
        '
        'chkChiTiet
        '
        Me.chkChiTiet.EditValue = True
        Me.chkChiTiet.Location = New System.Drawing.Point(467, 164)
        Me.chkChiTiet.Name = "chkChiTiet"
        Me.chkChiTiet.Properties.Caption = "Chi tiết"
        Me.chkChiTiet.Size = New System.Drawing.Size(117, 19)
        Me.chkChiTiet.TabIndex = 12
        Me.chkChiTiet.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl11.Location = New System.Drawing.Point(20, 12)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl11.TabIndex = 24
        Me.LabelControl11.Text = "Nhóm vật tư"
        '
        'txtDmVatTuCha
        '
        Me.txtDmVatTuCha.AllowNull = True
        Me.txtDmVatTuCha.C_ARR_COLS_DISPLAY = "MaHanghoa-Mã hàng hóa-80-1;KyHieu-Ký hiệu-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--" & _
            "0-0"
        Me.txtDmVatTuCha.C_ARR_COLS_RETURN = "Id;MaHanghoa;KyHieu;TenHanghoa"
        Me.txtDmVatTuCha.C_DATA_SOURCE = Nothing
        Me.txtDmVatTuCha.C_FORM_DANHSACH = ""
        Me.txtDmVatTuCha.C_FORM_TITLE = "Chọn vật tư, hàng hóa"
        Me.txtDmVatTuCha.C_IS_CHECK_NUMBER = ""
        Me.txtDmVatTuCha.C_IS_CHECK_OTHER = ""
        Me.txtDmVatTuCha.C_IS_CHECK_STRING = ""
        Me.txtDmVatTuCha.C_IS_FILTER_STRING = ""
        Me.txtDmVatTuCha.C_IS_QUICKADD = False
        Me.txtDmVatTuCha.C_IS_SORT_ORDER_STRING = ""
        Me.txtDmVatTuCha.C_KEY_NAME = "Id"
        Me.txtDmVatTuCha.EditValue = ""
        Me.txtDmVatTuCha.EditValues = ""
        Me.txtDmVatTuCha.ENABLES = True
        Me.txtDmVatTuCha.IsNotTextChanged = True
        Me.txtDmVatTuCha.ListEditValue = CType(resources.GetObject("txtDmVatTuCha.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.txtDmVatTuCha.Location = New System.Drawing.Point(97, 8)
        Me.txtDmVatTuCha.MessageWarning = "Giá trị không hợp lệ"
        Me.txtDmVatTuCha.Name = "txtDmVatTuCha"
        Me.txtDmVatTuCha.NEXT_TAB = 0
        Me.txtDmVatTuCha.Size = New System.Drawing.Size(243, 20)
        Me.txtDmVatTuCha.TabIndex = 0
        '
        'txtVI_TRI
        '
        Me.txtVI_TRI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVI_TRI.EnterMoveNextControl = True
        Me.txtVI_TRI.Location = New System.Drawing.Point(97, 138)
        Me.txtVI_TRI.Name = "txtVI_TRI"
        Me.txtVI_TRI.Properties.MaxLength = 64
        Me.txtVI_TRI.Size = New System.Drawing.Size(243, 20)
        Me.txtVI_TRI.TabIndex = 9
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(335, 164)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = "Cho phép sửa"
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(117, 19)
        Me.chkCHO_PHEP_SUA.TabIndex = 11
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl15.Location = New System.Drawing.Point(59, 141)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl15.TabIndex = 20
        Me.LabelControl15.Text = "Vị trí"
        '
        'Color
        '
        Me.Color.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Color.Location = New System.Drawing.Point(28, 90)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(52, 13)
        Me.Color.TabIndex = 6
        Me.Color.Text = "Đơn vị tính"
        '
        'grlDVT_ID
        '
        Me.grlDVT_ID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlDVT_ID.EnterMoveNextControl = True
        Me.grlDVT_ID.Location = New System.Drawing.Point(97, 86)
        Me.grlDVT_ID.Name = "grlDVT_ID"
        Me.grlDVT_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlDVT_ID.Properties.NullText = ""
        Me.grlDVT_ID.Properties.View = Me.gridLookUpEdit1View
        Me.grlDVT_ID.Size = New System.Drawing.Size(243, 20)
        Me.grlDVT_ID.TabIndex = 4
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(95, 164)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = "Sử dụng"
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(81, 19)
        Me.chkCO_SU_DUNG.TabIndex = 10
        '
        'chkTHAN_VO
        '
        Me.chkTHAN_VO.EditValue = True
        Me.chkTHAN_VO.Location = New System.Drawing.Point(467, 113)
        Me.chkTHAN_VO.Name = "chkTHAN_VO"
        Me.chkTHAN_VO.Properties.Caption = "Thân vỏ"
        Me.chkTHAN_VO.Size = New System.Drawing.Size(141, 19)
        Me.chkTHAN_VO.TabIndex = 8
        Me.chkTHAN_VO.Visible = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl17.Location = New System.Drawing.Point(417, 38)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl17.TabIndex = 0
        Me.LabelControl17.Text = "Ký hiệu"
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(10, 63)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(66, 13)
        Me.lblCarFarmily_Code.TabIndex = 2
        Me.lblCarFarmily_Code.Text = "Tên hàng hóa"
        '
        'txtTEN_HANGHOA
        '
        Me.txtTEN_HANGHOA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTEN_HANGHOA.EnterMoveNextControl = True
        Me.txtTEN_HANGHOA.Location = New System.Drawing.Point(97, 59)
        Me.txtTEN_HANGHOA.Name = "txtTEN_HANGHOA"
        Me.txtTEN_HANGHOA.Properties.MaxLength = 128
        Me.txtTEN_HANGHOA.Size = New System.Drawing.Size(243, 20)
        Me.txtTEN_HANGHOA.TabIndex = 3
        '
        'txtKY_HIEU
        '
        Me.txtKY_HIEU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtKY_HIEU.EnterMoveNextControl = True
        Me.txtKY_HIEU.Location = New System.Drawing.Point(469, 34)
        Me.txtKY_HIEU.Name = "txtKY_HIEU"
        Me.txtKY_HIEU.Properties.MaxLength = 64
        Me.txtKY_HIEU.Size = New System.Drawing.Size(243, 20)
        Me.txtKY_HIEU.TabIndex = 2
        '
        'txtNUOC_SANXUAT
        '
        Me.txtNUOC_SANXUAT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNUOC_SANXUAT.EnterMoveNextControl = True
        Me.txtNUOC_SANXUAT.Location = New System.Drawing.Point(97, 112)
        Me.txtNUOC_SANXUAT.Name = "txtNUOC_SANXUAT"
        Me.txtNUOC_SANXUAT.Properties.MaxLength = 64
        Me.txtNUOC_SANXUAT.Size = New System.Drawing.Size(109, 20)
        Me.txtNUOC_SANXUAT.TabIndex = 6
        '
        'labelControl5
        '
        Me.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl5.Location = New System.Drawing.Point(10, 116)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(70, 13)
        Me.labelControl5.TabIndex = 8
        Me.labelControl5.Text = "Nước sản xuất"
        '
        'txtNAM_SANXUAT1
        '
        Me.txtNAM_SANXUAT1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNAM_SANXUAT1.EnterMoveNextControl = True
        Me.txtNAM_SANXUAT1.Location = New System.Drawing.Point(299, 112)
        Me.txtNAM_SANXUAT1.Name = "txtNAM_SANXUAT1"
        Me.txtNAM_SANXUAT1.Properties.Mask.EditMask = "[0-9]{4}"
        Me.txtNAM_SANXUAT1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNAM_SANXUAT1.Properties.Mask.ShowPlaceHolders = False
        Me.txtNAM_SANXUAT1.Properties.MaxLength = 4
        Me.txtNAM_SANXUAT1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNAM_SANXUAT1.Size = New System.Drawing.Size(41, 20)
        Me.txtNAM_SANXUAT1.TabIndex = 7
        '
        'labelControl6
        '
        Me.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl6.Location = New System.Drawing.Point(212, 116)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(66, 13)
        Me.labelControl6.TabIndex = 10
        Me.labelControl6.Text = "Năm sản xuất"
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl16.Location = New System.Drawing.Point(398, 90)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl16.TabIndex = 18
        Me.LabelControl16.Text = "PP tính giá"
        '
        'grlTEN_PP_HTK1
        '
        Me.grlTEN_PP_HTK1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlTEN_PP_HTK1.EnterMoveNextControl = True
        Me.grlTEN_PP_HTK1.Location = New System.Drawing.Point(469, 86)
        Me.grlTEN_PP_HTK1.Name = "grlTEN_PP_HTK1"
        Me.grlTEN_PP_HTK1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTEN_PP_HTK1.Properties.NullText = ""
        Me.grlTEN_PP_HTK1.Properties.View = Me.gridView1
        Me.grlTEN_PP_HTK1.Size = New System.Drawing.Size(243, 20)
        Me.grlTEN_PP_HTK1.TabIndex = 5
        '
        'gridView1
        '
        Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 34)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(735, 4)
        Me.PanelControl2.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 224)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(735, 4)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.labelControl7)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_KHO)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_HB_TRALAI)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_SP_DD)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_GIABAN)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_GIAVON)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.txtMD_TK_GIABAN_NB)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 228)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(735, 119)
        Me.GroupControl3.TabIndex = 2
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(48, 11)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(32, 13)
        Me.labelControl7.TabIndex = 20
        Me.labelControl7.Text = "TK kho"
        '
        'txtMD_TK_KHO
        '
        Me.txtMD_TK_KHO.EnterMoveNextControl = True
        Me.txtMD_TK_KHO.Location = New System.Drawing.Point(97, 7)
        Me.txtMD_TK_KHO.Name = "txtMD_TK_KHO"
        Me.txtMD_TK_KHO.Properties.MaxLength = 32
        Me.txtMD_TK_KHO.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_KHO.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "TK doanh thu"
        '
        'txtMD_TK_HB_TRALAI
        '
        Me.txtMD_TK_HB_TRALAI.EnterMoveNextControl = True
        Me.txtMD_TK_HB_TRALAI.Location = New System.Drawing.Point(469, 33)
        Me.txtMD_TK_HB_TRALAI.Name = "txtMD_TK_HB_TRALAI"
        Me.txtMD_TK_HB_TRALAI.Properties.MaxLength = 64
        Me.txtMD_TK_HB_TRALAI.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_HB_TRALAI.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "TK giá vốn"
        '
        'txtMD_TK_SP_DD
        '
        Me.txtMD_TK_SP_DD.EnterMoveNextControl = True
        Me.txtMD_TK_SP_DD.Location = New System.Drawing.Point(469, 59)
        Me.txtMD_TK_SP_DD.Name = "txtMD_TK_SP_DD"
        Me.txtMD_TK_SP_DD.Properties.MaxLength = 128
        Me.txtMD_TK_SP_DD.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_SP_DD.TabIndex = 5
        '
        'txtMD_TK_GIABAN
        '
        Me.txtMD_TK_GIABAN.EnterMoveNextControl = True
        Me.txtMD_TK_GIABAN.Location = New System.Drawing.Point(97, 59)
        Me.txtMD_TK_GIABAN.Name = "txtMD_TK_GIABAN"
        Me.txtMD_TK_GIABAN.Properties.MaxLength = 128
        Me.txtMD_TK_GIABAN.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_GIABAN.TabIndex = 4
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(362, 37)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "TK hàng bán trả lại"
        '
        'txtMD_TK_GIAVON
        '
        Me.txtMD_TK_GIAVON.EnterMoveNextControl = True
        Me.txtMD_TK_GIAVON.Location = New System.Drawing.Point(97, 33)
        Me.txtMD_TK_GIAVON.Name = "txtMD_TK_GIAVON"
        Me.txtMD_TK_GIAVON.Properties.MaxLength = 64
        Me.txtMD_TK_GIAVON.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_GIAVON.TabIndex = 2
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(359, 63)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl14.TabIndex = 34
        Me.LabelControl14.Text = "TK S.Phẩm dở dang"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(356, 11)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "TK doanh thu nội bộ"
        '
        'txtMD_TK_GIABAN_NB
        '
        Me.txtMD_TK_GIABAN_NB.EnterMoveNextControl = True
        Me.txtMD_TK_GIABAN_NB.Location = New System.Drawing.Point(469, 7)
        Me.txtMD_TK_GIABAN_NB.Name = "txtMD_TK_GIABAN_NB"
        Me.txtMD_TK_GIABAN_NB.Properties.MaxLength = 64
        Me.txtMD_TK_GIABAN_NB.Size = New System.Drawing.Size(243, 20)
        Me.txtMD_TK_GIABAN_NB.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.labelControl8)
        Me.GroupControl2.Controls.Add(Me.grlID_NHOM_VT_1)
        Me.GroupControl2.Controls.Add(Me.labelControl9)
        Me.GroupControl2.Controls.Add(Me.grlID_NHOM_VT_2)
        Me.GroupControl2.Controls.Add(Me.labelControl10)
        Me.GroupControl2.Controls.Add(Me.grlID_NHOM_VT_3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(735, 34)
        Me.GroupControl2.TabIndex = 0
        '
        'labelControl8
        '
        Me.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl8.Location = New System.Drawing.Point(33, 10)
        Me.labelControl8.Name = "labelControl8"
        Me.labelControl8.Size = New System.Drawing.Size(48, 13)
        Me.labelControl8.TabIndex = 12
        Me.labelControl8.Text = "Nhóm VT1"
        '
        'grlID_NHOM_VT_1
        '
        Me.grlID_NHOM_VT_1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlID_NHOM_VT_1.EditValue = ""
        Me.grlID_NHOM_VT_1.EnterMoveNextControl = True
        Me.grlID_NHOM_VT_1.Location = New System.Drawing.Point(97, 6)
        Me.grlID_NHOM_VT_1.Name = "grlID_NHOM_VT_1"
        Me.grlID_NHOM_VT_1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_NHOM_VT_1.Properties.NullText = ""
        Me.grlID_NHOM_VT_1.Properties.View = Me.gridView2
        Me.grlID_NHOM_VT_1.Size = New System.Drawing.Size(145, 20)
        Me.grlID_NHOM_VT_1.TabIndex = 0
        '
        'gridView2
        '
        Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TEN_NHOM_VT_1, Me.MA_NHOM_VT_1})
        Me.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView2.Name = "gridView2"
        Me.gridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView2.OptionsView.ShowGroupPanel = False
        '
        'labelControl9
        '
        Me.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl9.Location = New System.Drawing.Point(265, 10)
        Me.labelControl9.Name = "labelControl9"
        Me.labelControl9.Size = New System.Drawing.Size(48, 13)
        Me.labelControl9.TabIndex = 14
        Me.labelControl9.Text = "Nhóm VT2"
        '
        'grlID_NHOM_VT_2
        '
        Me.grlID_NHOM_VT_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlID_NHOM_VT_2.EditValue = ""
        Me.grlID_NHOM_VT_2.EnterMoveNextControl = True
        Me.grlID_NHOM_VT_2.Location = New System.Drawing.Point(334, 6)
        Me.grlID_NHOM_VT_2.Name = "grlID_NHOM_VT_2"
        Me.grlID_NHOM_VT_2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_NHOM_VT_2.Properties.NullText = ""
        Me.grlID_NHOM_VT_2.Properties.View = Me.gridView3
        Me.grlID_NHOM_VT_2.Size = New System.Drawing.Size(138, 20)
        Me.grlID_NHOM_VT_2.TabIndex = 1
        '
        'gridView3
        '
        Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3})
        Me.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView3.Name = "gridView3"
        Me.gridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView3.OptionsView.ShowGroupPanel = False
        '
        'labelControl10
        '
        Me.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl10.Location = New System.Drawing.Point(494, 10)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(48, 13)
        Me.labelControl10.TabIndex = 16
        Me.labelControl10.Text = "Nhóm VT3"
        '
        'grlID_NHOM_VT_3
        '
        Me.grlID_NHOM_VT_3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlID_NHOM_VT_3.EnterMoveNextControl = True
        Me.grlID_NHOM_VT_3.Location = New System.Drawing.Point(561, 6)
        Me.grlID_NHOM_VT_3.Name = "grlID_NHOM_VT_3"
        Me.grlID_NHOM_VT_3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_NHOM_VT_3.Properties.NullText = ""
        Me.grlID_NHOM_VT_3.Properties.View = Me.gridView4
        Me.grlID_NHOM_VT_3.Size = New System.Drawing.Size(151, 20)
        Me.grlID_NHOM_VT_3.TabIndex = 2
        '
        'gridView4
        '
        Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn4})
        Me.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView4.Name = "gridView4"
        Me.gridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView4.OptionsView.ShowGroupPanel = False
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
        Me._ActionPanel.Location = New System.Drawing.Point(4, 318)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me._ActionPanel.Size = New System.Drawing.Size(735, 33)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(413, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Đ&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(327, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(241, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'TEN_NHOM_VT_1
        '
        Me.TEN_NHOM_VT_1.Caption = "Tên nhóm vật tư"
        Me.TEN_NHOM_VT_1.FieldName = "TenNhomVt1"
        Me.TEN_NHOM_VT_1.Name = "TEN_NHOM_VT_1"
        Me.TEN_NHOM_VT_1.Visible = True
        Me.TEN_NHOM_VT_1.VisibleIndex = 0
        '
        'MA_NHOM_VT_1
        '
        Me.MA_NHOM_VT_1.Caption = "GridColumn3"
        Me.MA_NHOM_VT_1.FieldName = "MaNhomVt1"
        Me.MA_NHOM_VT_1.Name = "MA_NHOM_VT_1"
        Me.MA_NHOM_VT_1.Visible = True
        Me.MA_NHOM_VT_1.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tên nhóm vật tư"
        Me.GridColumn1.FieldName = "TenNhomVt1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "MaNhomVt1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên nhóm vật tư"
        Me.GridColumn2.FieldName = "TenNhomVt1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "MaNhomVt1"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'frmDanhMucHangHoa_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(743, 355)
        Me.Controls.Add(Me._ActionPanel)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDanhMucHangHoa_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục hàng hóa"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboLOAI_HANG_HOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaHanghoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChiTiet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVI_TRI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlDVT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTHAN_VO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_HANGHOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKY_HIEU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNUOC_SANXUAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNAM_SANXUAT1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTEN_PP_HTK1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtMD_TK_KHO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_HB_TRALAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_SP_DD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIABAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIAVON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIABAN_NB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.grlID_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlID_NHOM_VT_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlID_NHOM_VT_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend Color As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private txtTEN_HANGHOA As DevExpress.XtraEditors.TextEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend labelControl6 As DevExpress.XtraEditors.LabelControl
    Private txtNAM_SANXUAT1 As DevExpress.XtraEditors.TextEdit
    Friend labelControl5 As DevExpress.XtraEditors.LabelControl
    Private txtNUOC_SANXUAT As DevExpress.XtraEditors.TextEdit
    Private txtKY_HIEU As DevExpress.XtraEditors.TextEdit
    Friend labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMD_TK_KHO As DevExpress.XtraEditors.TextEdit
    Friend labelControl10 As DevExpress.XtraEditors.LabelControl
    Friend labelControl9 As DevExpress.XtraEditors.LabelControl
    Friend labelControl8 As DevExpress.XtraEditors.LabelControl
    Private grlDVT_ID As DevExpress.XtraEditors.GridLookUpEdit
    Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private grlTEN_PP_HTK1 As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents grlID_NHOM_VT_3 As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents grlID_NHOM_VT_2 As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents grlID_NHOM_VT_1 As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend _ActionPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txtMD_TK_GIABAN_NB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMD_TK_GIAVON As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtMD_TK_GIABAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMD_TK_HB_TRALAI As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtMD_TK_SP_DD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TEN_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents txtVI_TRI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Private WithEvents chkTHAN_VO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDmVatTuCha As Vns.Erp.Core.CustomFilter
    Private WithEvents chkChiTiet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMaHanghoa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLOAI_HANG_HOA As DevExpress.XtraEditors.LookUpEdit
End Class
