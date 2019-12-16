Imports Microsoft.VisualBasic
Imports System
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmOpecDanhMucHangHoa_ChiTiet
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.grlTEN_PP_HTK1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cboLOAI_HANG_HOA = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtMD_TK_GIABAN_NB = New DevExpress.XtraEditors.TextEdit()
        Me.txtMdTkDiduong = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_KHO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_GIAVON = New DevExpress.XtraEditors.TextEdit()
        Me.txtMD_TK_HB_TRALAI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMD_TK_GIABAN = New DevExpress.XtraEditors.TextEdit()
        Me.txtMD_TK_SP_DD = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCO_SU_DUNG = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCHO_PHEP_SUA = New DevExpress.XtraEditors.CheckEdit()
        Me.chkChiTiet = New DevExpress.XtraEditors.CheckEdit()
        Me.Color = New DevExpress.XtraEditors.LabelControl()
        Me.grlDVT_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaHanghoa = New DevExpress.XtraEditors.TextEdit()
        Me.lblCarFarmily_Code = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_HANGHOA = New DevExpress.XtraEditors.TextEdit()
        Me.txtNUOC_SANXUAT = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_NHOM_VT_1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TEN_NHOM_VT_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_NHOM_VT_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_NHOM_VT_2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._ActionPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._GroupControlObjectInfo.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grlTEN_PP_HTK1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLOAI_HANG_HOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIABAN_NB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMdTkDiduong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_KHO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIAVON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_HB_TRALAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_GIABAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMD_TK_SP_DD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChiTiet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlDVT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaHanghoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_HANGHOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNUOC_SANXUAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grlID_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlID_NHOM_VT_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me._GroupControlObjectInfo.Controls.Add(Me.GroupControl2)
        Me._GroupControlObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GroupControlObjectInfo.Location = New System.Drawing.Point(5, 5)
        Me._GroupControlObjectInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._GroupControlObjectInfo.Name = "_GroupControlObjectInfo"
        Me._GroupControlObjectInfo.ShowCaption = False
        Me._GroupControlObjectInfo.Size = New System.Drawing.Size(857, 208)
        Me._GroupControlObjectInfo.TabIndex = 0
        Me._GroupControlObjectInfo.Text = "Thông tin Mă danh m?c t? do 2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtMaHanghoa)
        Me.GroupControl1.Controls.Add(Me.lblCarFarmily_Code)
        Me.GroupControl1.Controls.Add(Me.txtTEN_HANGHOA)
        Me.GroupControl1.Controls.Add(Me.txtNUOC_SANXUAT)
        Me.GroupControl1.Controls.Add(Me.labelControl5)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 47)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(857, 156)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.UseDisabledStatePainter = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.labelControl7)
        Me.GroupBox2.Controls.Add(Me.LabelControl18)
        Me.GroupBox2.Controls.Add(Me.grlTEN_PP_HTK1)
        Me.GroupBox2.Controls.Add(Me.cboLOAI_HANG_HOA)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_GIABAN_NB)
        Me.GroupBox2.Controls.Add(Me.txtMdTkDiduong)
        Me.GroupBox2.Controls.Add(Me.LabelControl16)
        Me.GroupBox2.Controls.Add(Me.LabelControl12)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_KHO)
        Me.GroupBox2.Controls.Add(Me.LabelControl14)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_GIAVON)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_HB_TRALAI)
        Me.GroupBox2.Controls.Add(Me.LabelControl13)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_GIABAN)
        Me.GroupBox2.Controls.Add(Me.txtMD_TK_SP_DD)
        Me.GroupBox2.Location = New System.Drawing.Point(610, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(678, 94)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        Me.GroupBox2.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(422, 115)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(86, 17)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Loại hàng hóa"
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(29, 23)
        Me.labelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(39, 16)
        Me.labelControl7.TabIndex = 20
        Me.labelControl7.Text = "TK kho"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(4, 51)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl18.TabIndex = 36
        Me.LabelControl18.Text = "TK đi đường"
        '
        'grlTEN_PP_HTK1
        '
        Me.grlTEN_PP_HTK1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlTEN_PP_HTK1.EnterMoveNextControl = True
        Me.grlTEN_PP_HTK1.Location = New System.Drawing.Point(723, 15)
        Me.grlTEN_PP_HTK1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlTEN_PP_HTK1.Name = "grlTEN_PP_HTK1"
        Me.grlTEN_PP_HTK1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTEN_PP_HTK1.Properties.NullText = ""
        Me.grlTEN_PP_HTK1.Properties.View = Me.gridView1
        Me.grlTEN_PP_HTK1.Size = New System.Drawing.Size(283, 22)
        Me.grlTEN_PP_HTK1.TabIndex = 5
        '
        'gridView1
        '
        Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'cboLOAI_HANG_HOA
        '
        Me.cboLOAI_HANG_HOA.EditValue = ""
        Me.cboLOAI_HANG_HOA.EnterMoveNextControl = True
        Me.cboLOAI_HANG_HOA.Location = New System.Drawing.Point(520, 112)
        Me.cboLOAI_HANG_HOA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboLOAI_HANG_HOA.Name = "cboLOAI_HANG_HOA"
        Me.cboLOAI_HANG_HOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboLOAI_HANG_HOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLOAI_HANG_HOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDanhmuc", "Loại vật tư/ hàng hóa")})
        Me.cboLOAI_HANG_HOA.Properties.DisplayMember = "TenDanhmuc"
        Me.cboLOAI_HANG_HOA.Properties.ImmediatePopup = True
        Me.cboLOAI_HANG_HOA.Properties.NullText = ""
        Me.cboLOAI_HANG_HOA.Properties.ValueMember = "GiaTri"
        Me.cboLOAI_HANG_HOA.Size = New System.Drawing.Size(283, 22)
        Me.cboLOAI_HANG_HOA.TabIndex = 26
        '
        'txtMD_TK_GIABAN_NB
        '
        Me.txtMD_TK_GIABAN_NB.EnterMoveNextControl = True
        Me.txtMD_TK_GIABAN_NB.Location = New System.Drawing.Point(520, 18)
        Me.txtMD_TK_GIABAN_NB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_GIABAN_NB.Name = "txtMD_TK_GIABAN_NB"
        Me.txtMD_TK_GIABAN_NB.Properties.MaxLength = 64
        Me.txtMD_TK_GIABAN_NB.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_GIABAN_NB.TabIndex = 1
        '
        'txtMdTkDiduong
        '
        Me.txtMdTkDiduong.EditValue = "151"
        Me.txtMdTkDiduong.EnterMoveNextControl = True
        Me.txtMdTkDiduong.Location = New System.Drawing.Point(87, 48)
        Me.txtMdTkDiduong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMdTkDiduong.Name = "txtMdTkDiduong"
        Me.txtMdTkDiduong.Properties.MaxLength = 32
        Me.txtMdTkDiduong.Size = New System.Drawing.Size(283, 22)
        Me.txtMdTkDiduong.TabIndex = 35
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl16.Location = New System.Drawing.Point(640, 20)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl16.TabIndex = 18
        Me.LabelControl16.Text = "PP tính giá"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(388, 23)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(126, 17)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "TK doanh thu nội bộ"
        '
        'txtMD_TK_KHO
        '
        Me.txtMD_TK_KHO.EditValue = "152"
        Me.txtMD_TK_KHO.EnterMoveNextControl = True
        Me.txtMD_TK_KHO.Location = New System.Drawing.Point(86, 18)
        Me.txtMD_TK_KHO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_KHO.Name = "txtMD_TK_KHO"
        Me.txtMD_TK_KHO.Properties.MaxLength = 32
        Me.txtMD_TK_KHO.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_KHO.TabIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(392, 87)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(122, 17)
        Me.LabelControl14.TabIndex = 34
        Me.LabelControl14.Text = "TK S.Phẩm dở dang"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(-8, 119)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "TK doanh thu"
        '
        'txtMD_TK_GIAVON
        '
        Me.txtMD_TK_GIAVON.EditValue = "632"
        Me.txtMD_TK_GIAVON.EnterMoveNextControl = True
        Me.txtMD_TK_GIAVON.Location = New System.Drawing.Point(86, 82)
        Me.txtMD_TK_GIAVON.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_GIAVON.Name = "txtMD_TK_GIAVON"
        Me.txtMD_TK_GIAVON.Properties.MaxLength = 64
        Me.txtMD_TK_GIAVON.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_GIAVON.TabIndex = 2
        '
        'txtMD_TK_HB_TRALAI
        '
        Me.txtMD_TK_HB_TRALAI.EnterMoveNextControl = True
        Me.txtMD_TK_HB_TRALAI.Location = New System.Drawing.Point(520, 50)
        Me.txtMD_TK_HB_TRALAI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_HB_TRALAI.Name = "txtMD_TK_HB_TRALAI"
        Me.txtMD_TK_HB_TRALAI.Properties.MaxLength = 64
        Me.txtMD_TK_HB_TRALAI.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_HB_TRALAI.TabIndex = 3
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(395, 55)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(114, 17)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "TK hàng bán trả lại"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 87)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "TK giá vốn"
        '
        'txtMD_TK_GIABAN
        '
        Me.txtMD_TK_GIABAN.EditValue = "5111"
        Me.txtMD_TK_GIABAN.EnterMoveNextControl = True
        Me.txtMD_TK_GIABAN.Location = New System.Drawing.Point(86, 114)
        Me.txtMD_TK_GIABAN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_GIABAN.Name = "txtMD_TK_GIABAN"
        Me.txtMD_TK_GIABAN.Properties.MaxLength = 128
        Me.txtMD_TK_GIABAN.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_GIABAN.TabIndex = 4
        '
        'txtMD_TK_SP_DD
        '
        Me.txtMD_TK_SP_DD.EnterMoveNextControl = True
        Me.txtMD_TK_SP_DD.Location = New System.Drawing.Point(520, 82)
        Me.txtMD_TK_SP_DD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMD_TK_SP_DD.Name = "txtMD_TK_SP_DD"
        Me.txtMD_TK_SP_DD.Properties.MaxLength = 128
        Me.txtMD_TK_SP_DD.Size = New System.Drawing.Size(283, 22)
        Me.txtMD_TK_SP_DD.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCO_SU_DUNG)
        Me.GroupBox1.Controls.Add(Me.chkCHO_PHEP_SUA)
        Me.GroupBox1.Controls.Add(Me.chkChiTiet)
        Me.GroupBox1.Controls.Add(Me.Color)
        Me.GroupBox1.Controls.Add(Me.grlDVT_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'chkCO_SU_DUNG
        '
        Me.chkCO_SU_DUNG.EditValue = True
        Me.chkCO_SU_DUNG.Location = New System.Drawing.Point(21, 23)
        Me.chkCO_SU_DUNG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCO_SU_DUNG.Name = "chkCO_SU_DUNG"
        Me.chkCO_SU_DUNG.Properties.Caption = "Sử dụng"
        Me.chkCO_SU_DUNG.Size = New System.Drawing.Size(94, 22)
        Me.chkCO_SU_DUNG.TabIndex = 10
        '
        'chkCHO_PHEP_SUA
        '
        Me.chkCHO_PHEP_SUA.EditValue = True
        Me.chkCHO_PHEP_SUA.Location = New System.Drawing.Point(21, 53)
        Me.chkCHO_PHEP_SUA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCHO_PHEP_SUA.Name = "chkCHO_PHEP_SUA"
        Me.chkCHO_PHEP_SUA.Properties.Caption = "Cho phép sửa"
        Me.chkCHO_PHEP_SUA.Size = New System.Drawing.Size(136, 22)
        Me.chkCHO_PHEP_SUA.TabIndex = 11
        Me.chkCHO_PHEP_SUA.Visible = False
        '
        'chkChiTiet
        '
        Me.chkChiTiet.EditValue = True
        Me.chkChiTiet.Location = New System.Drawing.Point(75, 23)
        Me.chkChiTiet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkChiTiet.Name = "chkChiTiet"
        Me.chkChiTiet.Properties.Caption = "Chi tiết"
        Me.chkChiTiet.Size = New System.Drawing.Size(136, 22)
        Me.chkChiTiet.TabIndex = 12
        Me.chkChiTiet.Visible = False
        '
        'Color
        '
        Me.Color.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Color.Location = New System.Drawing.Point(41, 27)
        Me.Color.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(67, 17)
        Me.Color.TabIndex = 6
        Me.Color.Text = "Đơn vị tính"
        '
        'grlDVT_ID
        '
        Me.grlDVT_ID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlDVT_ID.EnterMoveNextControl = True
        Me.grlDVT_ID.Location = New System.Drawing.Point(121, 22)
        Me.grlDVT_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlDVT_ID.Name = "grlDVT_ID"
        Me.grlDVT_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlDVT_ID.Properties.NullText = ""
        Me.grlDVT_ID.Properties.View = Me.gridLookUpEdit1View
        Me.grlDVT_ID.Size = New System.Drawing.Size(283, 22)
        Me.grlDVT_ID.TabIndex = 4
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Location = New System.Drawing.Point(38, 14)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Mã hàng"
        '
        'txtMaHanghoa
        '
        Me.txtMaHanghoa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMaHanghoa.EnterMoveNextControl = True
        Me.txtMaHanghoa.Location = New System.Drawing.Point(113, 8)
        Me.txtMaHanghoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMaHanghoa.Name = "txtMaHanghoa"
        Me.txtMaHanghoa.Properties.MaxLength = 64
        Me.txtMaHanghoa.Size = New System.Drawing.Size(283, 22)
        Me.txtMaHanghoa.TabIndex = 1
        '
        'lblCarFarmily_Code
        '
        Me.lblCarFarmily_Code.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCarFarmily_Code.Location = New System.Drawing.Point(12, 43)
        Me.lblCarFarmily_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCarFarmily_Code.Name = "lblCarFarmily_Code"
        Me.lblCarFarmily_Code.Size = New System.Drawing.Size(79, 16)
        Me.lblCarFarmily_Code.TabIndex = 2
        Me.lblCarFarmily_Code.Text = "Tên hàng hóa"
        '
        'txtTEN_HANGHOA
        '
        Me.txtTEN_HANGHOA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTEN_HANGHOA.EnterMoveNextControl = True
        Me.txtTEN_HANGHOA.Location = New System.Drawing.Point(113, 38)
        Me.txtTEN_HANGHOA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTEN_HANGHOA.Name = "txtTEN_HANGHOA"
        Me.txtTEN_HANGHOA.Properties.MaxLength = 128
        Me.txtTEN_HANGHOA.Size = New System.Drawing.Size(559, 22)
        Me.txtTEN_HANGHOA.TabIndex = 3
        '
        'txtNUOC_SANXUAT
        '
        Me.txtNUOC_SANXUAT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNUOC_SANXUAT.EnterMoveNextControl = True
        Me.txtNUOC_SANXUAT.Location = New System.Drawing.Point(113, 68)
        Me.txtNUOC_SANXUAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNUOC_SANXUAT.Name = "txtNUOC_SANXUAT"
        Me.txtNUOC_SANXUAT.Properties.MaxLength = 64
        Me.txtNUOC_SANXUAT.Size = New System.Drawing.Size(283, 22)
        Me.txtNUOC_SANXUAT.TabIndex = 6
        '
        'labelControl5
        '
        Me.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl5.Location = New System.Drawing.Point(47, 70)
        Me.labelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(44, 16)
        Me.labelControl5.TabIndex = 8
        Me.labelControl5.Text = "Xuất xứ"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 42)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(857, 5)
        Me.PanelControl2.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 203)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(857, 5)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.labelControl8)
        Me.GroupControl2.Controls.Add(Me.grlID_NHOM_VT_1)
        Me.GroupControl2.Controls.Add(Me.labelControl9)
        Me.GroupControl2.Controls.Add(Me.grlID_NHOM_VT_2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(857, 42)
        Me.GroupControl2.TabIndex = 0
        '
        'labelControl8
        '
        Me.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl8.Location = New System.Drawing.Point(26, 10)
        Me.labelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl8.Name = "labelControl8"
        Me.labelControl8.Size = New System.Drawing.Size(65, 16)
        Me.labelControl8.TabIndex = 12
        Me.labelControl8.Text = "Nhóm hàng"
        '
        'grlID_NHOM_VT_1
        '
        Me.grlID_NHOM_VT_1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlID_NHOM_VT_1.EditValue = ""
        Me.grlID_NHOM_VT_1.EnterMoveNextControl = True
        Me.grlID_NHOM_VT_1.Location = New System.Drawing.Point(113, 7)
        Me.grlID_NHOM_VT_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlID_NHOM_VT_1.Name = "grlID_NHOM_VT_1"
        Me.grlID_NHOM_VT_1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_NHOM_VT_1.Properties.NullText = ""
        Me.grlID_NHOM_VT_1.Properties.View = Me.gridView2
        Me.grlID_NHOM_VT_1.Size = New System.Drawing.Size(169, 22)
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
        'labelControl9
        '
        Me.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelControl9.Location = New System.Drawing.Point(436, 9)
        Me.labelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl9.Name = "labelControl9"
        Me.labelControl9.Size = New System.Drawing.Size(55, 16)
        Me.labelControl9.TabIndex = 14
        Me.labelControl9.Text = "Ứng dụng"
        '
        'grlID_NHOM_VT_2
        '
        Me.grlID_NHOM_VT_2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grlID_NHOM_VT_2.EditValue = ""
        Me.grlID_NHOM_VT_2.EnterMoveNextControl = True
        Me.grlID_NHOM_VT_2.Location = New System.Drawing.Point(511, 6)
        Me.grlID_NHOM_VT_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlID_NHOM_VT_2.Name = "grlID_NHOM_VT_2"
        Me.grlID_NHOM_VT_2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_NHOM_VT_2.Properties.NullText = ""
        Me.grlID_NHOM_VT_2.Properties.View = Me.gridView3
        Me.grlID_NHOM_VT_2.Size = New System.Drawing.Size(161, 22)
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
        '_ActionPanel
        '
        Me._ActionPanel.Appearance.ForeColor = System.Drawing.Color.Black
        Me._ActionPanel.Appearance.Options.UseForeColor = True
        Me._ActionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._ActionPanel.Controls.Add(Me.btnCancel)
        Me._ActionPanel.Controls.Add(Me.btnClear)
        Me._ActionPanel.Controls.Add(Me.btnSave)
        Me._ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._ActionPanel.Location = New System.Drawing.Point(5, 172)
        Me._ActionPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._ActionPanel.Name = "_ActionPanel"
        Me._ActionPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me._ActionPanel.Size = New System.Drawing.Size(857, 41)
        Me._ActionPanel.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageIndex = 24
        Me.btnCancel.Location = New System.Drawing.Point(482, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Đ&óng"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.ImageIndex = 32
        Me.btnClear.Location = New System.Drawing.Point(381, 2)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 37)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Xóa trắng"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageIndex = 13
        Me.btnSave.Location = New System.Drawing.Point(281, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 37)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Lưu"
        '
        'frmOpecDanhMucHangHoa_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(867, 218)
        Me.Controls.Add(Me._ActionPanel)
        Me.Controls.Add(Me._GroupControlObjectInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpecDanhMucHangHoa_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục hàng hóa"
        CType(Me._GroupControlObjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._GroupControlObjectInfo.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grlTEN_PP_HTK1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLOAI_HANG_HOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIABAN_NB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMdTkDiduong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_KHO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIAVON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_HB_TRALAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_GIABAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMD_TK_SP_DD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkCO_SU_DUNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCHO_PHEP_SUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChiTiet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlDVT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaHanghoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_HANGHOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNUOC_SANXUAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.grlID_NHOM_VT_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlID_NHOM_VT_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ActionPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._ActionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend _GroupControlObjectInfo As DevExpress.XtraEditors.GroupControl
    Friend LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend Color As DevExpress.XtraEditors.LabelControl
    Friend lblCarFarmily_Code As DevExpress.XtraEditors.LabelControl
    Private txtTEN_HANGHOA As DevExpress.XtraEditors.TextEdit
    Private chkCO_SU_DUNG As DevExpress.XtraEditors.CheckEdit
    Private chkCHO_PHEP_SUA As DevExpress.XtraEditors.CheckEdit
    Friend labelControl5 As DevExpress.XtraEditors.LabelControl
    Private txtNUOC_SANXUAT As DevExpress.XtraEditors.TextEdit
    Friend labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMD_TK_KHO As DevExpress.XtraEditors.TextEdit
    Friend labelControl9 As DevExpress.XtraEditors.LabelControl
    Friend labelControl8 As DevExpress.XtraEditors.LabelControl
    Private grlDVT_ID As DevExpress.XtraEditors.GridLookUpEdit
    Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private grlTEN_PP_HTK1 As DevExpress.XtraEditors.GridLookUpEdit
    Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TEN_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_NHOM_VT_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents chkChiTiet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMaHanghoa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLOAI_HANG_HOA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtMdTkDiduong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
