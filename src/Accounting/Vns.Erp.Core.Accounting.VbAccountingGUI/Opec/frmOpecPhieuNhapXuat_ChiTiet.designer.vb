﻿Imports Vns.Erp.Core.Controls.UserControl

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpecPhieuNhapXuat_ChiTiet
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpecPhieuNhapXuat_ChiTiet))
        Dim ValueInfo1 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Me.cboMaHang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDVT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMaKho = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMakhoxuat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.spdSoLuong = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.cboTKno = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTKco = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboPTQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboPhongban = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhoanphi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboHopdong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboMaTk = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDmKhachHang = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMaHopDong = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Controls.UserControl.C_SoChungTu()
        Me.lblTK = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.grlLoaiPhieuNhap = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit()
        Me.txtNgayCt = New DevExpress.XtraEditors.DateEdit()
        Me.cboTyGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grcPhieuPhapKho = New DevExpress.XtraGrid.GridControl()
        Me.grvPhieuNhapKho = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HanghoaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboHanghoa = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ViTri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoNhapId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoXuatId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVonNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVonNt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaTknGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gfilter_MA_TKN_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.MaTkcGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gfilter_MA_TKC_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.IdDmPtqtCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo1Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo2Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo3Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo4Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo5Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmPhongbanCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmKhoanphiCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmHopdongCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAlignment1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GFilterEdit_HANGHOA_ID = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.rcboVuviecId = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.depCT_H_Nx = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CtSo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayGhi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ghi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.UR_STATUS = New Vns.Erp.Core.Controls.UserControl.Status_LoaiCT()
        Me.txtTongSoLuong = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTongTien = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.navWelding1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCan = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQui = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cboMaHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMakhoxuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spdSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTKno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTKco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopdong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboMaTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDmKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaHopDong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLoaiPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayCt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayCt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTyGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grcPhieuPhapKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPhieuNhapKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHanghoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gfilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gfilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcboVuviecId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtTongSoLuong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTongTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMaHang
        '
        Me.cboMaHang.AutoHeight = False
        Me.cboMaHang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaHang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaHang.Name = "cboMaHang"
        Me.cboMaHang.NullText = ""
        '
        'cboDVT
        '
        Me.cboDVT.AutoHeight = False
        Me.cboDVT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDVT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDVT.Name = "cboDVT"
        Me.cboDVT.NullText = ""
        '
        'cboMaKho
        '
        Me.cboMaKho.AutoHeight = False
        Me.cboMaKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaKho.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.NullText = ""
        '
        'cboMakhoxuat
        '
        Me.cboMakhoxuat.AutoHeight = False
        Me.cboMakhoxuat.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMakhoxuat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMakhoxuat.Name = "cboMakhoxuat"
        Me.cboMakhoxuat.NullText = ""
        '
        'spdSoLuong
        '
        Me.spdSoLuong.AutoHeight = False
        Me.spdSoLuong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spdSoLuong.MaxValue = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.spdSoLuong.Name = "spdSoLuong"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit2.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'cboTKno
        '
        Me.cboTKno.AutoHeight = False
        Me.cboTKno.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTKno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTKno.Name = "cboTKno"
        Me.cboTKno.NullText = ""
        '
        'cboVuViec
        '
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'cboTKco
        '
        Me.cboTKco.AutoHeight = False
        Me.cboTKco.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTKco.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTKco.Name = "cboTKco"
        Me.cboTKco.NullText = ""
        '
        'cboPTQT
        '
        Me.cboPTQT.AutoHeight = False
        Me.cboPTQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPTQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQT.Name = "cboPTQT"
        Me.cboPTQT.NullText = ""
        '
        'cboTudo1
        '
        Me.cboTudo1.AutoHeight = False
        Me.cboTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo1.Name = "cboTudo1"
        Me.cboTudo1.NullText = ""
        '
        'cboTudo2
        '
        Me.cboTudo2.AutoHeight = False
        Me.cboTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo2.Name = "cboTudo2"
        Me.cboTudo2.NullText = ""
        '
        'cboTudo3
        '
        Me.cboTudo3.AutoHeight = False
        Me.cboTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo3.Name = "cboTudo3"
        Me.cboTudo3.NullText = ""
        '
        'cboTudo4
        '
        Me.cboTudo4.AutoHeight = False
        Me.cboTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo4.Name = "cboTudo4"
        Me.cboTudo4.NullText = ""
        '
        'cboTudo5
        '
        Me.cboTudo5.AutoHeight = False
        Me.cboTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo5.Name = "cboTudo5"
        Me.cboTudo5.NullText = ""
        '
        'cboPhongban
        '
        Me.cboPhongban.AutoHeight = False
        Me.cboPhongban.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongban.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongban.Name = "cboPhongban"
        Me.cboPhongban.NullText = ""
        '
        'cboKhoanphi
        '
        Me.cboKhoanphi.AutoHeight = False
        Me.cboKhoanphi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanphi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanphi.Name = "cboKhoanphi"
        Me.cboKhoanphi.NullText = ""
        '
        'cboHopdong
        '
        Me.cboHopdong.AutoHeight = False
        Me.cboHopdong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboHopdong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopdong.Name = "cboHopdong"
        Me.cboHopdong.NullText = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cboMaTk)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cboDmKhachHang)
        Me.GroupControl1.Controls.Add(Me.txtMaHopDong)
        Me.GroupControl1.Controls.Add(Me.labelControl7)
        Me.GroupControl1.Controls.Add(Me.C_SoChungTu_RP)
        Me.GroupControl1.Controls.Add(Me.lblTK)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.grlLoaiPhieuNhap)
        Me.GroupControl1.Controls.Add(Me.txtTY_GIA)
        Me.GroupControl1.Controls.Add(Me.txtNgayCt)
        Me.GroupControl1.Controls.Add(Me.cboTyGia)
        Me.GroupControl1.Controls.Add(Me.labelControl11)
        Me.GroupControl1.Controls.Add(Me.labelControl10)
        Me.GroupControl1.Controls.Add(Me.txtDIEN_GIAI)
        Me.GroupControl1.Controls.Add(Me.labelControl33)
        Me.GroupControl1.Controls.Add(Me.labelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(967, 128)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'cboMaTk
        '
        Me.cboMaTk.EnterMoveNextControl = True
        Me.cboMaTk.Location = New System.Drawing.Point(829, 94)
        Me.cboMaTk.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMaTk.Name = "cboMaTk"
        Me.cboMaTk.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaTk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaTk.Properties.DisplayMember = "MaTaikhoan"
        Me.cboMaTk.Properties.NullText = ""
        Me.cboMaTk.Properties.ValueMember = "MaTaikhoan"
        Me.cboMaTk.Properties.View = Me.GridView1
        Me.cboMaTk.Size = New System.Drawing.Size(96, 22)
        Me.cboMaTk.TabIndex = 5018
        Me.cboMaTk.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Mã hợp đồng"
        Me.GridColumn10.FieldName = "KyHieu"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tên hợp đồng"
        Me.GridColumn11.FieldName = "TenHopdong"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(300, 10)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl3.TabIndex = 5017
        Me.LabelControl3.Text = "Khách hàng"
        '
        'cboDmKhachHang
        '
        Me.cboDmKhachHang.EnterMoveNextControl = True
        Me.cboDmKhachHang.Location = New System.Drawing.Point(374, 7)
        Me.cboDmKhachHang.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDmKhachHang.Name = "cboDmKhachHang"
        Me.cboDmKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDmKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDmKhachHang.Properties.DisplayMember = "KyHieu"
        Me.cboDmKhachHang.Properties.NullText = ""
        Me.cboDmKhachHang.Properties.ValueMember = "Id"
        Me.cboDmKhachHang.Properties.View = Me.gridLookUpEdit1View
        Me.cboDmKhachHang.Size = New System.Drawing.Size(358, 22)
        Me.cboDmKhachHang.TabIndex = 3
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Mã khách hàng"
        Me.GridColumn8.FieldName = "KyHieu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tên khách hàng"
        Me.GridColumn9.FieldName = "TenKhang"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'txtMaHopDong
        '
        Me.txtMaHopDong.EnterMoveNextControl = True
        Me.txtMaHopDong.Location = New System.Drawing.Point(105, 39)
        Me.txtMaHopDong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMaHopDong.Name = "txtMaHopDong"
        Me.txtMaHopDong.Properties.MaxLength = 128
        Me.txtMaHopDong.Size = New System.Drawing.Size(156, 22)
        Me.txtMaHopDong.TabIndex = 2
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(14, 42)
        Me.labelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(83, 17)
        Me.labelControl7.TabIndex = 5014
        Me.labelControl7.Text = "Số Hợp Đồng"
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(633, 97)
        Me.C_SoChungTu_RP.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(117, 25)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 3
        Me.C_SoChungTu_RP.Visible = False
        '
        'lblTK
        '
        Me.lblTK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTK.Location = New System.Drawing.Point(778, 96)
        Me.lblTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTK.Name = "lblTK"
        Me.lblTK.Size = New System.Drawing.Size(39, 17)
        Me.lblTK.TabIndex = 99
        Me.lblTK.Text = "Ghi nợ"
        Me.lblTK.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(763, 42)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(41, 17)
        Me.LabelControl14.TabIndex = 89
        Me.LabelControl14.Text = "Tỷ giá "
        '
        'grlLoaiPhieuNhap
        '
        Me.grlLoaiPhieuNhap.EnterMoveNextControl = True
        Me.grlLoaiPhieuNhap.Location = New System.Drawing.Point(432, 96)
        Me.grlLoaiPhieuNhap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlLoaiPhieuNhap.Name = "grlLoaiPhieuNhap"
        Me.grlLoaiPhieuNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLoaiPhieuNhap.Properties.NullText = ""
        Me.grlLoaiPhieuNhap.Properties.ReadOnly = True
        Me.grlLoaiPhieuNhap.Properties.View = Me.GridView2
        Me.grlLoaiPhieuNhap.Size = New System.Drawing.Size(117, 22)
        Me.grlLoaiPhieuNhap.TabIndex = 0
        Me.grlLoaiPhieuNhap.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ký hiệu"
        Me.GridColumn2.FieldName = "KyHieu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên loại chứng từ"
        Me.GridColumn3.FieldName = "TenLoaiCt"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'txtTY_GIA
        '
        Me.txtTY_GIA.EnterMoveNextControl = True
        Me.txtTY_GIA.Location = New System.Drawing.Point(818, 38)
        Me.txtTY_GIA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTY_GIA.Name = "txtTY_GIA"
        Me.txtTY_GIA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA.Properties.Mask.EditMask = "n2"
        Me.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA.Size = New System.Drawing.Size(107, 22)
        Me.txtTY_GIA.TabIndex = 6
        '
        'txtNgayCt
        '
        Me.txtNgayCt.EditValue = Nothing
        Me.txtNgayCt.EnterMoveNextControl = True
        Me.txtNgayCt.Location = New System.Drawing.Point(105, 7)
        Me.txtNgayCt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNgayCt.Name = "txtNgayCt"
        Me.txtNgayCt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayCt.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayCt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayCt.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayCt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayCt.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtNgayCt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtNgayCt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNgayCt.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.txtNgayCt.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.txtNgayCt.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNgayCt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNgayCt.Size = New System.Drawing.Size(156, 22)
        Me.txtNgayCt.TabIndex = 1
        '
        'cboTyGia
        '
        Me.cboTyGia.EnterMoveNextControl = True
        Me.cboTyGia.Location = New System.Drawing.Point(818, 6)
        Me.cboTyGia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTyGia.Name = "cboTyGia"
        Me.cboTyGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTyGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTyGia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboTyGia.Properties.NullText = ""
        Me.cboTyGia.Size = New System.Drawing.Size(107, 22)
        Me.cboTyGia.TabIndex = 5
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(583, 101)
        Me.labelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(37, 17)
        Me.labelControl11.TabIndex = 84
        Me.labelControl11.Text = "Số CT"
        Me.labelControl11.Visible = False
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(64, 10)
        Me.labelControl10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(28, 16)
        Me.labelControl10.TabIndex = 83
        Me.labelControl10.Text = "Ngày"
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(374, 36)
        Me.txtDIEN_GIAI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.Properties.MaxLength = 256
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(358, 22)
        Me.txtDIEN_GIAI.TabIndex = 4
        '
        'labelControl33
        '
        Me.labelControl33.Location = New System.Drawing.Point(310, 40)
        Me.labelControl33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl33.Name = "labelControl33"
        Me.labelControl33.Size = New System.Drawing.Size(50, 17)
        Me.labelControl33.TabIndex = 73
        Me.labelControl33.Text = "Diễn giải"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(374, 100)
        Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(45, 17)
        Me.labelControl1.TabIndex = 8
        Me.labelControl1.Text = "Loại CT"
        Me.labelControl1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl2.Controls.Add(Me.grcPhieuPhapKho)
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 128)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(967, 531)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'grcPhieuPhapKho
        '
        Me.grcPhieuPhapKho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcPhieuPhapKho.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcPhieuPhapKho.Location = New System.Drawing.Point(0, 26)
        Me.grcPhieuPhapKho.MainView = Me.grvPhieuNhapKho
        Me.grcPhieuPhapKho.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcPhieuPhapKho.Name = "grcPhieuPhapKho"
        Me.grcPhieuPhapKho.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAlignment1, Me.GFilterEdit_HANGHOA_ID, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.Gfilter_MA_TKN_GIAVON, Me.Gfilter_MA_TKC_GIAVON, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.rcboVuviecId, Me.cboHanghoa})
        Me.grcPhieuPhapKho.Size = New System.Drawing.Size(967, 505)
        Me.grcPhieuPhapKho.TabIndex = 1
        Me.grcPhieuPhapKho.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPhieuNhapKho})
        '
        'grvPhieuNhapKho
        '
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.Empty.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.OddRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Appearance.OddRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvPhieuNhapKho.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.Preview.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.Preview.Options.UseFont = True
        Me.grvPhieuNhapKho.Appearance.Preview.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.Row.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.Row.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvPhieuNhapKho.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvPhieuNhapKho.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvPhieuNhapKho.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvPhieuNhapKho.Appearance.VertLine.Options.UseBackColor = True
        Me.grvPhieuNhapKho.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvPhieuNhapKho.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.HanghoaId, Me.TenDvt, Me.ViTri, Me.KhoNhapId, Me.KhoXuatId, Me.TonKho, Me.SoLuong, Me.DonGiaVon, Me.GiaVon, Me.DonGiaVonNte, Me.GiaVonNt, Me.MaTknGiavon, Me.MaTkcGiavon, Me.IdDmPtqtCo, Me.IdDmTudo1Co, Me.IdDmTudo2Co, Me.IdDmTudo3Co, Me.IdDmTudo4Co, Me.IdDmTudo5Co, Me.IdDmPhongbanCo, Me.IdDmKhoanphiCo, Me.IdDmHopdongCo})
        Me.grvPhieuNhapKho.GridControl = Me.grcPhieuPhapKho
        Me.grvPhieuNhapKho.Name = "grvPhieuNhapKho"
        Me.grvPhieuNhapKho.OptionsNavigation.AutoFocusNewRow = True
        Me.grvPhieuNhapKho.OptionsNavigation.EnterMoveNextColumn = True
        Me.grvPhieuNhapKho.OptionsView.ColumnAutoWidth = False
        Me.grvPhieuNhapKho.OptionsView.EnableAppearanceEvenRow = True
        Me.grvPhieuNhapKho.OptionsView.EnableAppearanceOddRow = True
        Me.grvPhieuNhapKho.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Code"
        Me.GridColumn1.FieldName = "MaVuviec"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'HanghoaId
        '
        Me.HanghoaId.Caption = "Tên hàng "
        Me.HanghoaId.ColumnEdit = Me.cboHanghoa
        Me.HanghoaId.FieldName = "HanghoaId"
        Me.HanghoaId.Name = "HanghoaId"
        Me.HanghoaId.Visible = True
        Me.HanghoaId.VisibleIndex = 1
        Me.HanghoaId.Width = 391
        '
        'cboHanghoa
        '
        Me.cboHanghoa.AutoHeight = False
        Me.cboHanghoa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHanghoa.DisplayMember = "TenHienThi"
        Me.cboHanghoa.ImmediatePopup = True
        Me.cboHanghoa.Name = "cboHanghoa"
        Me.cboHanghoa.NullText = ""
        Me.cboHanghoa.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboHanghoa.PopupFormSize = New System.Drawing.Size(600, 0)
        Me.cboHanghoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboHanghoa.ValueMember = "Id"
        Me.cboHanghoa.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tên hàng hóa"
        Me.GridColumn13.FieldName = "TenHienThi"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'TenDvt
        '
        Me.TenDvt.Caption = "ĐVT"
        Me.TenDvt.FieldName = "TenDvt"
        Me.TenDvt.Name = "TenDvt"
        Me.TenDvt.OptionsColumn.ReadOnly = True
        Me.TenDvt.Width = 70
        '
        'ViTri
        '
        Me.ViTri.Caption = "Vị trí"
        Me.ViTri.FieldName = "ViTri"
        Me.ViTri.Name = "ViTri"
        '
        'KhoNhapId
        '
        Me.KhoNhapId.Caption = "Mã kho nhập"
        Me.KhoNhapId.ColumnEdit = Me.cboMaKho
        Me.KhoNhapId.FieldName = "KhoNhapId"
        Me.KhoNhapId.Name = "KhoNhapId"
        Me.KhoNhapId.Visible = True
        Me.KhoNhapId.VisibleIndex = 2
        Me.KhoNhapId.Width = 100
        '
        'KhoXuatId
        '
        Me.KhoXuatId.Caption = "Mã kho xuất"
        Me.KhoXuatId.ColumnEdit = Me.cboMakhoxuat
        Me.KhoXuatId.FieldName = "KhoXuatId"
        Me.KhoXuatId.Name = "KhoXuatId"
        Me.KhoXuatId.Visible = True
        Me.KhoXuatId.VisibleIndex = 3
        Me.KhoXuatId.Width = 100
        '
        'TonKho
        '
        Me.TonKho.Caption = "Tồn kho"
        Me.TonKho.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.TonKho.FieldName = "TonKho"
        Me.TonKho.Name = "TonKho"
        Me.TonKho.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'SoLuong
        '
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 4
        Me.SoLuong.Width = 70
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'DonGiaVon
        '
        Me.DonGiaVon.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaVon.Caption = "Giá"
        Me.DonGiaVon.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.DonGiaVon.DisplayFormat.FormatString = "#,###0"
        Me.DonGiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaVon.FieldName = "DonGiaVon"
        Me.DonGiaVon.Name = "DonGiaVon"
        Me.DonGiaVon.Visible = True
        Me.DonGiaVon.VisibleIndex = 7
        Me.DonGiaVon.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GiaVon
        '
        Me.GiaVon.AppearanceCell.Options.UseTextOptions = True
        Me.GiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GiaVon.Caption = "Tổng tiền"
        Me.GiaVon.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GiaVon.DisplayFormat.FormatString = "#,###0"
        Me.GiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GiaVon.FieldName = "GiaVon"
        Me.GiaVon.Name = "GiaVon"
        Me.GiaVon.OptionsColumn.ReadOnly = True
        Me.GiaVon.Visible = True
        Me.GiaVon.VisibleIndex = 8
        Me.GiaVon.Width = 120
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'DonGiaVonNte
        '
        Me.DonGiaVonNte.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaVonNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaVonNte.Caption = "Giá NTE"
        Me.DonGiaVonNte.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DonGiaVonNte.FieldName = "DonGiaVonNte"
        Me.DonGiaVonNte.Name = "DonGiaVonNte"
        Me.DonGiaVonNte.Visible = True
        Me.DonGiaVonNte.VisibleIndex = 5
        Me.DonGiaVonNte.Width = 70
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GiaVonNt
        '
        Me.GiaVonNt.AppearanceCell.Options.UseTextOptions = True
        Me.GiaVonNt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GiaVonNt.Caption = "Tiền NTE"
        Me.GiaVonNt.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GiaVonNt.FieldName = "GiaVonNt"
        Me.GiaVonNt.Name = "GiaVonNt"
        Me.GiaVonNt.Visible = True
        Me.GiaVonNt.VisibleIndex = 6
        Me.GiaVonNt.Width = 70
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'MaTknGiavon
        '
        Me.MaTknGiavon.Caption = "TK nợ"
        Me.MaTknGiavon.ColumnEdit = Me.Gfilter_MA_TKN_GIAVON
        Me.MaTknGiavon.FieldName = "MaTknGiavon"
        Me.MaTknGiavon.Name = "MaTknGiavon"
        Me.MaTknGiavon.Width = 120
        '
        'Gfilter_MA_TKN_GIAVON
        '
        Me.Gfilter_MA_TKN_GIAVON.AutoHeight = False
        Me.Gfilter_MA_TKN_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Gfilter_MA_TKN_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.Gfilter_MA_TKN_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Nothing
        Me.Gfilter_MA_TKN_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.Gfilter_MA_TKN_GIAVON.C_FORM_TITLE = "Chọn tài khoản"
        Me.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_OTHER = "="
        Me.Gfilter_MA_TKN_GIAVON.C_IS_CHECK_STRING = "="
        Me.Gfilter_MA_TKN_GIAVON.C_IS_CHI_TIET = ""
        Me.Gfilter_MA_TKN_GIAVON.C_IS_FILTER_STRING = ""
        Me.Gfilter_MA_TKN_GIAVON.C_IS_QUICKADD = False
        Me.Gfilter_MA_TKN_GIAVON.C_IS_SORT_ORDER_STRING = ""
        Me.Gfilter_MA_TKN_GIAVON.C_KEY_NAME = "MaTaikhoan"
        Me.Gfilter_MA_TKN_GIAVON.Editors = Nothing
        Me.Gfilter_MA_TKN_GIAVON.EditValues = ""
        Me.Gfilter_MA_TKN_GIAVON.ListEditValues = CType(resources.GetObject("Gfilter_MA_TKN_GIAVON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.Gfilter_MA_TKN_GIAVON.Name = "Gfilter_MA_TKN_GIAVON"
        Me.Gfilter_MA_TKN_GIAVON.NEXT_TAB = 0
        Me.Gfilter_MA_TKN_GIAVON.OBJ_CONDITITION = Nothing
        '
        'MaTkcGiavon
        '
        Me.MaTkcGiavon.Caption = "Tk có"
        Me.MaTkcGiavon.ColumnEdit = Me.Gfilter_MA_TKC_GIAVON
        Me.MaTkcGiavon.FieldName = "MaTkcGiavon"
        Me.MaTkcGiavon.Name = "MaTkcGiavon"
        Me.MaTkcGiavon.Width = 120
        '
        'Gfilter_MA_TKC_GIAVON
        '
        Me.Gfilter_MA_TKC_GIAVON.AutoHeight = False
        Me.Gfilter_MA_TKC_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Gfilter_MA_TKC_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.Gfilter_MA_TKC_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Nothing
        Me.Gfilter_MA_TKC_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.Gfilter_MA_TKC_GIAVON.C_FORM_TITLE = "Chọn tài khoản"
        Me.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_OTHER = "="
        Me.Gfilter_MA_TKC_GIAVON.C_IS_CHECK_STRING = "="
        Me.Gfilter_MA_TKC_GIAVON.C_IS_CHI_TIET = ""
        Me.Gfilter_MA_TKC_GIAVON.C_IS_FILTER_STRING = ""
        Me.Gfilter_MA_TKC_GIAVON.C_IS_QUICKADD = False
        Me.Gfilter_MA_TKC_GIAVON.C_IS_SORT_ORDER_STRING = ""
        Me.Gfilter_MA_TKC_GIAVON.C_KEY_NAME = "MaTaikhoan"
        Me.Gfilter_MA_TKC_GIAVON.Editors = Nothing
        Me.Gfilter_MA_TKC_GIAVON.EditValues = ""
        Me.Gfilter_MA_TKC_GIAVON.ListEditValues = CType(resources.GetObject("Gfilter_MA_TKC_GIAVON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.Gfilter_MA_TKC_GIAVON.Name = "Gfilter_MA_TKC_GIAVON"
        Me.Gfilter_MA_TKC_GIAVON.NEXT_TAB = 0
        Me.Gfilter_MA_TKC_GIAVON.OBJ_CONDITITION = Nothing
        '
        'IdDmPtqtCo
        '
        Me.IdDmPtqtCo.Caption = "PTQT"
        Me.IdDmPtqtCo.ColumnEdit = Me.cboPTQT
        Me.IdDmPtqtCo.FieldName = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Name = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Visible = True
        Me.IdDmPtqtCo.VisibleIndex = 9
        '
        'IdDmTudo1Co
        '
        Me.IdDmTudo1Co.Caption = "DM Tự do 1"
        Me.IdDmTudo1Co.ColumnEdit = Me.cboTudo1
        Me.IdDmTudo1Co.FieldName = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Name = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Visible = True
        Me.IdDmTudo1Co.VisibleIndex = 10
        '
        'IdDmTudo2Co
        '
        Me.IdDmTudo2Co.Caption = "DM Tự do 2"
        Me.IdDmTudo2Co.ColumnEdit = Me.cboTudo2
        Me.IdDmTudo2Co.FieldName = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Name = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Visible = True
        Me.IdDmTudo2Co.VisibleIndex = 11
        '
        'IdDmTudo3Co
        '
        Me.IdDmTudo3Co.Caption = "DM Tự do 3"
        Me.IdDmTudo3Co.ColumnEdit = Me.cboTudo3
        Me.IdDmTudo3Co.FieldName = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Name = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Visible = True
        Me.IdDmTudo3Co.VisibleIndex = 12
        '
        'IdDmTudo4Co
        '
        Me.IdDmTudo4Co.Caption = "DM Tự do 4"
        Me.IdDmTudo4Co.ColumnEdit = Me.cboTudo4
        Me.IdDmTudo4Co.FieldName = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Name = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Visible = True
        Me.IdDmTudo4Co.VisibleIndex = 13
        '
        'IdDmTudo5Co
        '
        Me.IdDmTudo5Co.Caption = "DM Tự do 5"
        Me.IdDmTudo5Co.ColumnEdit = Me.cboTudo5
        Me.IdDmTudo5Co.FieldName = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Name = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Visible = True
        Me.IdDmTudo5Co.VisibleIndex = 14
        '
        'IdDmPhongbanCo
        '
        Me.IdDmPhongbanCo.Caption = "DM Phòng ban"
        Me.IdDmPhongbanCo.ColumnEdit = Me.cboPhongban
        Me.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Name = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Visible = True
        Me.IdDmPhongbanCo.VisibleIndex = 15
        '
        'IdDmKhoanphiCo
        '
        Me.IdDmKhoanphiCo.Caption = "DM Khoản phí"
        Me.IdDmKhoanphiCo.ColumnEdit = Me.cboKhoanphi
        Me.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Visible = True
        Me.IdDmKhoanphiCo.VisibleIndex = 16
        '
        'IdDmHopdongCo
        '
        Me.IdDmHopdongCo.Caption = "DM Hợp đồng"
        Me.IdDmHopdongCo.ColumnEdit = Me.cboHopdong
        Me.IdDmHopdongCo.FieldName = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Name = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Visible = True
        Me.IdDmHopdongCo.VisibleIndex = 17
        '
        'RepositoryItemAlignment1
        '
        Me.RepositoryItemAlignment1.AutoHeight = False
        Me.RepositoryItemAlignment1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAlignment1.Name = "RepositoryItemAlignment1"
        '
        'GFilterEdit_HANGHOA_ID
        '
        Me.GFilterEdit_HANGHOA_ID.AutoHeight = False
        Me.GFilterEdit_HANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" &
    "nDvt--80-0;ViTri--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0"
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban;MdTkKho;ViTri" &
    ""
        Me.GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Nothing
        Me.GFilterEdit_HANGHOA_ID.C_FORM_DANHSACH = "frmDanhMucHangHoa_DanhSach"
        Me.GFilterEdit_HANGHOA_ID.C_FORM_TITLE = "Chọn hàng hóa"
        Me.GFilterEdit_HANGHOA_ID.C_IS_CHECK_NUMBER = "="
        Me.GFilterEdit_HANGHOA_ID.C_IS_CHECK_OTHER = "="
        Me.GFilterEdit_HANGHOA_ID.C_IS_CHECK_STRING = "="
        Me.GFilterEdit_HANGHOA_ID.C_IS_CHI_TIET = ""
        Me.GFilterEdit_HANGHOA_ID.C_IS_FILTER_STRING = ""
        Me.GFilterEdit_HANGHOA_ID.C_IS_QUICKADD = True
        Me.GFilterEdit_HANGHOA_ID.C_IS_SORT_ORDER_STRING = ""
        Me.GFilterEdit_HANGHOA_ID.C_KEY_NAME = "KyHieu"
        Me.GFilterEdit_HANGHOA_ID.Editors = Nothing
        Me.GFilterEdit_HANGHOA_ID.EditValues = ""
        Me.GFilterEdit_HANGHOA_ID.ListEditValues = CType(resources.GetObject("GFilterEdit_HANGHOA_ID.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilterEdit_HANGHOA_ID.Name = "GFilterEdit_HANGHOA_ID"
        Me.GFilterEdit_HANGHOA_ID.NEXT_TAB = 0
        Me.GFilterEdit_HANGHOA_ID.OBJ_CONDITITION = Nothing
        '
        'rcboVuviecId
        '
        Me.rcboVuviecId.AutoHeight = False
        Me.rcboVuviecId.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcboVuviecId.DisplayMember = "KyHieu"
        Me.rcboVuviecId.Name = "rcboVuviecId"
        Me.rcboVuviecId.NullText = ""
        Me.rcboVuviecId.ValueMember = "Id"
        Me.rcboVuviecId.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Mã"
        Me.GridColumn6.FieldName = "KyHieu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tên"
        Me.GridColumn7.FieldName = "TenVuviec"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(967, 26)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(483, 2)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(443, 17)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckEdit1.Location = New System.Drawing.Point(2, 2)
        Me.CheckEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Nhập theo giá TB cho VT tính giá TB                                              " &
    "                                             "
        Me.CheckEdit1.Size = New System.Drawing.Size(267, 22)
        Me.CheckEdit1.TabIndex = 0
        Me.CheckEdit1.Visible = False
        '
        'depCT_H_Nx
        '
        Me.depCT_H_Nx.ContainerControl = Me
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1166, 703)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grcLPN_Hnx)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(194, 703)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Danh sách..."
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 24)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(190, 677)
        Me.grcLPN_Hnx.TabIndex = 0
        Me.grcLPN_Hnx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLPX_Hnx})
        '
        'grvLPX_Hnx
        '
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.Empty.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.EvenRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FixedLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.GroupRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Appearance.OddRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grvLPX_Hnx.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseFont = True
        Me.grvLPX_Hnx.Appearance.Preview.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.Row.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.Row.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvLPX_Hnx.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grvLPX_Hnx.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBackColor = True
        Me.grvLPX_Hnx.Appearance.VertLine.Options.UseBorderColor = True
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CtSo, Me.NgayCt, Me.NgayGhi, Me.Ghi})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'CtSo
        '
        Me.CtSo.Caption = "Số chứng từ"
        Me.CtSo.FieldName = "CtSo"
        Me.CtSo.Name = "CtSo"
        Me.CtSo.Visible = True
        Me.CtSo.VisibleIndex = 1
        Me.CtSo.Width = 114
        '
        'NgayCt
        '
        Me.NgayCt.Caption = "Ngày chứng từ"
        Me.NgayCt.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayCt.FieldName = "NgayCt"
        Me.NgayCt.Name = "NgayCt"
        Me.NgayCt.Visible = True
        Me.NgayCt.VisibleIndex = 3
        Me.NgayCt.Width = 117
        '
        'NgayGhi
        '
        Me.NgayGhi.Caption = "Ngày hạch toán"
        Me.NgayGhi.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayGhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayGhi.FieldName = "NgayGhi"
        Me.NgayGhi.Name = "NgayGhi"
        Me.NgayGhi.Visible = True
        Me.NgayGhi.VisibleIndex = 2
        Me.NgayGhi.Width = 112
        '
        'Ghi
        '
        Me.Ghi.Caption = "Trạng thái"
        Me.Ghi.FieldName = "Ghi"
        Me.Ghi.Name = "Ghi"
        Me.Ghi.Visible = True
        Me.Ghi.VisibleIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.UR_STATUS)
        Me.GroupControl3.Controls.Add(Me.txtTongSoLuong)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.TxtTongTien)
        Me.GroupControl3.Controls.Add(Me.labelControl22)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 659)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(967, 44)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "GroupControl3"
        '
        'UR_STATUS
        '
        Me.UR_STATUS.CheckStatus = True
        Me.UR_STATUS.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_STATUS.Location = New System.Drawing.Point(6, 7)
        Me.UR_STATUS.Margin = New System.Windows.Forms.Padding(5)
        Me.UR_STATUS.Name = "UR_STATUS"
        Me.UR_STATUS.Size = New System.Drawing.Size(366, 25)
        Me.UR_STATUS.TabIndex = 67
        ValueInfo1.Den_Ngay = Nothing
        ValueInfo1.ID_DM = Nothing
        ValueInfo1.Ky_Hieu = Nothing
        ValueInfo1.MA_DM = Nothing
        ValueInfo1.ParameterValue = Nothing
        ValueInfo1.Ten = Nothing
        ValueInfo1.Tu_Ngay = Nothing
        Me.UR_STATUS.Value_info = ValueInfo1
        '
        'txtTongSoLuong
        '
        Me.txtTongSoLuong.Location = New System.Drawing.Point(478, 9)
        Me.txtTongSoLuong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTongSoLuong.Name = "txtTongSoLuong"
        Me.txtTongSoLuong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongSoLuong.Properties.Mask.EditMask = "n2"
        Me.txtTongSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongSoLuong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongSoLuong.Properties.ReadOnly = True
        Me.txtTongSoLuong.Size = New System.Drawing.Size(161, 22)
        Me.txtTongSoLuong.TabIndex = 1
        Me.txtTongSoLuong.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(380, 12)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl6.TabIndex = 66
        Me.LabelControl6.Text = "Tổng số lượng"
        '
        'TxtTongTien
        '
        Me.TxtTongTien.Location = New System.Drawing.Point(738, 7)
        Me.TxtTongTien.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTongTien.Name = "TxtTongTien"
        Me.TxtTongTien.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtTongTien.Properties.Mask.EditMask = "n0"
        Me.TxtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtTongTien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtTongTien.Properties.ReadOnly = True
        Me.TxtTongTien.Size = New System.Drawing.Size(174, 22)
        Me.TxtTongTien.TabIndex = 2
        Me.TxtTongTien.TabStop = False
        '
        'labelControl22
        '
        Me.labelControl22.Location = New System.Drawing.Point(666, 11)
        Me.labelControl22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl22.Name = "labelControl22"
        Me.labelControl22.Size = New System.Drawing.Size(58, 17)
        Me.labelControl22.TabIndex = 2
        Me.labelControl22.Text = "Tổng tiền"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navWelding1)
        Me.PanelControl2.Controls.Add(Me.btnSea)
        Me.PanelControl2.Controls.Add(Me.btnCan)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Controls.Add(Me.btnQui)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSav)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(5, 708)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1166, 37)
        Me.PanelControl2.TabIndex = 1
        '
        'navWelding1
        '
        Me.navWelding1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.navWelding1.Buttons.Append.Visible = False
        Me.navWelding1.Buttons.CancelEdit.Visible = False
        Me.navWelding1.Buttons.Edit.Visible = False
        Me.navWelding1.Buttons.EndEdit.Visible = False
        Me.navWelding1.Buttons.NextPage.Visible = False
        Me.navWelding1.Buttons.PrevPage.Visible = False
        Me.navWelding1.Buttons.Remove.Visible = False
        Me.navWelding1.Location = New System.Drawing.Point(0, 0)
        Me.navWelding1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navWelding1.Name = "navWelding1"
        Me.navWelding1.NavigatableControl = Me.grcLPN_Hnx
        Me.navWelding1.Size = New System.Drawing.Size(226, 37)
        Me.navWelding1.TabIndex = 1
        Me.navWelding1.Text = "ControlNavigator4"
        Me.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navWelding1.TextStringFormat = " {0} / {1}"
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(631, 0)
        Me.btnSea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(93, 37)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm kiếm"
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCan.ImageIndex = 4
        Me.btnCan.Location = New System.Drawing.Point(832, 0)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(93, 37)
        Me.btnCan.TabIndex = 6
        Me.btnCan.Text = "&Hủy"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(230, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(330, 0)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(93, 37)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Sửa"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(430, 0)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(93, 37)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "&Xóa"
        '
        'btnQui
        '
        Me.btnQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQui.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQui.ImageIndex = 8
        Me.btnQui.Location = New System.Drawing.Point(1072, 0)
        Me.btnQui.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQui.Name = "btnQui"
        Me.btnQui.Size = New System.Drawing.Size(93, 37)
        Me.btnQui.TabIndex = 7
        Me.btnQui.Text = "&Quay ra"
        '
        'btnPri
        '
        Me.btnPri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPri.ImageIndex = 15
        Me.btnPri.Location = New System.Drawing.Point(731, 0)
        Me.btnPri.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(93, 37)
        Me.btnPri.TabIndex = 5
        Me.btnPri.Text = "&In phiếu"
        '
        'btnSav
        '
        Me.btnSav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(531, 0)
        Me.btnSav.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(93, 37)
        Me.btnSav.TabIndex = 2
        Me.btnSav.Text = "&Lưu"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ký hiệu"
        Me.GridColumn4.FieldName = "KyHieu"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên"
        Me.GridColumn5.FieldName = "TenVuviec"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'frmOpecPhieuNhapXuat_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 750)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOpecPhieuNhapXuat_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "phieu nhap kho CT"
        CType(Me.cboMaHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMakhoxuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spdSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTKno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTKco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopdong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboMaTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDmKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaHopDong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLoaiPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayCt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayCt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTyGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grcPhieuPhapKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPhieuNhapKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHanghoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gfilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gfilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcboVuviecId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtTongSoLuong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTongTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcPhieuPhapKho As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPhieuNhapKho As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboTyGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents HANGHOA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_NHAP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_VON_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIA_VON_NT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TKN_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VUVIEC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTY_GIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grlLoaiPhieuNhap As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TKC_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KHO_XUAT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents depCT_H_Nx As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_HOPDONG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTongSoLuong As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTongTien As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMaHang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDVT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMaKho As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMakhoxuat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spdSoLuong As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents cboTKno As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTKco As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPTQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPhongban As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoanphi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboHopdong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents navWelding1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQui As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GFilterEdit_HANGHOA_ID As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemAlignment1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents UR_STATUS As Status_LoaiCT
    Friend WithEvents Gfilter_MA_TKN_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents Gfilter_MA_TKC_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VI_TRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTK As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TON_KHO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents HanghoaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenDvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViTri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KhoNhapId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KhoXuatId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TonKho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGiaVonNte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GiaVonNt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaTknGiavon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaTkcGiavon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPtqtCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo1Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo2Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo3Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo4Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo5Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPhongbanCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmKhoanphiCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmHopdongCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CtSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayGhi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ghi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_SoChungTu_RP As C_SoChungTu
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rcboVuviecId As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents txtNgayCt As DevExpress.XtraEditors.DateEdit
    Private WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboDmKhachHang As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMaHopDong As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboMaTk As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboHanghoa As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class