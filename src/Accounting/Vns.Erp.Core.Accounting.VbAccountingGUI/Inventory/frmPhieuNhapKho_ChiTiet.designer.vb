<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuNhapKho_ChiTiet
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuNhapKho_ChiTiet))
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
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.GFilter_TK = New Vns.Erp.Core.CustomFilter()
        Me.lblTK = New DevExpress.XtraEditors.LabelControl()
        Me.GFilter = New Vns.Erp.Core.CustomFilter()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.dteHDPN = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.lblNgayHDPN = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHDPN = New DevExpress.XtraEditors.TextEdit()
        Me.lblHDPN = New DevExpress.XtraEditors.LabelControl()
        Me.txtMST_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.grlLoaiPhieuNhap = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit()
        Me.dteNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.dteNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.cboTyGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtNGUOI_GIAO_NHAN_HANG = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grcPhieuPhapKho = New DevExpress.XtraGrid.GridControl()
        Me.grvPhieuNhapKho = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HanghoaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilterEdit_HANGHOA_ID = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TenHanghoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ViTri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoNhapId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoXuatId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVonNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVonNt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaTknGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gfilter_MA_TKN_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.VuviecId = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.UR_STATUS = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
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
        CType(Me.dteHDPN.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteHDPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHDPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLoaiPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTyGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGUOI_GIAO_NHAN_HANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grcPhieuPhapKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPhieuNhapKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gfilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gfilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.Controls.Add(Me.C_SoChungTu_RP)
        Me.GroupControl1.Controls.Add(Me.GFilter_TK)
        Me.GroupControl1.Controls.Add(Me.lblTK)
        Me.GroupControl1.Controls.Add(Me.GFilter)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.dteHDPN)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.txtTEN_KHANG)
        Me.GroupControl1.Controls.Add(Me.lblNgayHDPN)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.txtHDPN)
        Me.GroupControl1.Controls.Add(Me.lblHDPN)
        Me.GroupControl1.Controls.Add(Me.txtMST_KHANG)
        Me.GroupControl1.Controls.Add(Me.grlLoaiPhieuNhap)
        Me.GroupControl1.Controls.Add(Me.txtTY_GIA)
        Me.GroupControl1.Controls.Add(Me.dteNGAY_CT)
        Me.GroupControl1.Controls.Add(Me.dteNGAY_GHI)
        Me.GroupControl1.Controls.Add(Me.cboTyGia)
        Me.GroupControl1.Controls.Add(Me.labelControl11)
        Me.GroupControl1.Controls.Add(Me.labelControl10)
        Me.GroupControl1.Controls.Add(Me.labelControl9)
        Me.GroupControl1.Controls.Add(Me.txtDIA_CHI)
        Me.GroupControl1.Controls.Add(Me.txtNGUOI_GIAO_NHAN_HANG)
        Me.GroupControl1.Controls.Add(Me.txtDIEN_GIAI)
        Me.GroupControl1.Controls.Add(Me.labelControl33)
        Me.GroupControl1.Controls.Add(Me.labelControl5)
        Me.GroupControl1.Controls.Add(Me.labelControl3)
        Me.GroupControl1.Controls.Add(Me.labelControl2)
        Me.GroupControl1.Controls.Add(Me.labelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(800, 139)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(72, 83)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 3
        '
        'GFilter_TK
        '
        Me.GFilter_TK.AllowNull = True
        Me.GFilter_TK.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TK.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TK.C_DATA_SOURCE = Nothing
        Me.GFilter_TK.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TK.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TK.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TK.C_IS_CHECK_OTHER = "="
        Me.GFilter_TK.C_IS_CHECK_STRING = "="
        Me.GFilter_TK.C_IS_FILTER_STRING = ""
        Me.GFilter_TK.C_IS_QUICKADD = False
        Me.GFilter_TK.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TK.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TK.EditValue = ""
        Me.GFilter_TK.EditValues = ""
        Me.GFilter_TK.ENABLES = True
        Me.GFilter_TK.IsNotTextChanged = True
        Me.GFilter_TK.ListEditValue = CType(resources.GetObject("GFilter_TK.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TK.Location = New System.Drawing.Point(72, 109)
        Me.GFilter_TK.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TK.Name = "GFilter_TK"
        Me.GFilter_TK.NEXT_TAB = 0
        Me.GFilter_TK.Size = New System.Drawing.Size(100, 20)
        Me.GFilter_TK.TabIndex = 4
        '
        'lblTK
        '
        Me.lblTK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTK.Location = New System.Drawing.Point(24, 112)
        Me.lblTK.Name = "lblTK"
        Me.lblTK.Size = New System.Drawing.Size(30, 13)
        Me.lblTK.TabIndex = 99
        Me.lblTK.Text = "Ghi nợ"
        '
        'GFilter
        '
        Me.GFilter.AllowNull = True
        Me.GFilter.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MaKhang--0-0;MaSoThue--0-0;DiaChi-" & _
            "-0-0"
        Me.GFilter.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.GFilter.C_DATA_SOURCE = Nothing
        Me.GFilter.C_FORM_DANHSACH = "frmDanhMucKhachHang_DanhSach"
        Me.GFilter.C_FORM_TITLE = "Chọn khách hàng"
        Me.GFilter.C_IS_CHECK_NUMBER = "="
        Me.GFilter.C_IS_CHECK_OTHER = "="
        Me.GFilter.C_IS_CHECK_STRING = "="
        Me.GFilter.C_IS_FILTER_STRING = ""
        Me.GFilter.C_IS_QUICKADD = True
        Me.GFilter.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter.C_KEY_NAME = "KyHieu"
        Me.GFilter.EditValue = ""
        Me.GFilter.EditValues = ""
        Me.GFilter.ENABLES = False
        Me.GFilter.IsNotTextChanged = True
        Me.GFilter.ListEditValue = CType(resources.GetObject("GFilter.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter.Location = New System.Drawing.Point(278, 5)
        Me.GFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.GFilter.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter.Name = "GFilter"
        Me.GFilter.NEXT_TAB = 0
        Me.GFilter.Size = New System.Drawing.Size(124, 20)
        Me.GFilter.TabIndex = 5
        Me.GFilter.TabStop = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(415, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl13.TabIndex = 97
        Me.LabelControl13.Text = "Mã số thuế"
        '
        'dteHDPN
        '
        Me.dteHDPN.EditValue = Nothing
        Me.dteHDPN.EnterMoveNextControl = True
        Me.dteHDPN.Location = New System.Drawing.Point(701, 83)
        Me.dteHDPN.Name = "dteHDPN"
        Me.dteHDPN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteHDPN.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteHDPN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteHDPN.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteHDPN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteHDPN.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteHDPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteHDPN.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteHDPN.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteHDPN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dteHDPN.Size = New System.Drawing.Size(92, 20)
        Me.dteHDPN.TabIndex = 14
        Me.dteHDPN.Visible = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(229, 34)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl18.TabIndex = 96
        Me.LabelControl18.Text = "Tên KH"
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(278, 31)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.Properties.MaxLength = 128
        Me.txtTEN_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(331, 20)
        Me.txtTEN_KHANG.TabIndex = 7
        '
        'lblNgayHDPN
        '
        Me.lblNgayHDPN.Location = New System.Drawing.Point(626, 86)
        Me.lblNgayHDPN.Name = "lblNgayHDPN"
        Me.lblNgayHDPN.Size = New System.Drawing.Size(60, 13)
        Me.lblNgayHDPN.TabIndex = 93
        Me.lblNgayHDPN.Text = "Ngày HĐ/PN"
        Me.lblNgayHDPN.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(654, 34)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl14.TabIndex = 89
        Me.LabelControl14.Text = "Tỷ giá "
        '
        'txtHDPN
        '
        Me.txtHDPN.EnterMoveNextControl = True
        Me.txtHDPN.Location = New System.Drawing.Point(701, 57)
        Me.txtHDPN.Name = "txtHDPN"
        Me.txtHDPN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHDPN.Size = New System.Drawing.Size(92, 20)
        Me.txtHDPN.TabIndex = 13
        Me.txtHDPN.Visible = False
        '
        'lblHDPN
        '
        Me.lblHDPN.Location = New System.Drawing.Point(637, 60)
        Me.lblHDPN.Name = "lblHDPN"
        Me.lblHDPN.Size = New System.Drawing.Size(49, 13)
        Me.lblHDPN.TabIndex = 88
        Me.lblHDPN.Text = " HĐ/PN số"
        Me.lblHDPN.Visible = False
        '
        'txtMST_KHANG
        '
        Me.txtMST_KHANG.EnterMoveNextControl = True
        Me.txtMST_KHANG.Location = New System.Drawing.Point(474, 5)
        Me.txtMST_KHANG.Name = "txtMST_KHANG"
        Me.txtMST_KHANG.Properties.MaxLength = 32
        Me.txtMST_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMST_KHANG.Size = New System.Drawing.Size(135, 20)
        Me.txtMST_KHANG.TabIndex = 6
        '
        'grlLoaiPhieuNhap
        '
        Me.grlLoaiPhieuNhap.EnterMoveNextControl = True
        Me.grlLoaiPhieuNhap.Location = New System.Drawing.Point(72, 5)
        Me.grlLoaiPhieuNhap.Name = "grlLoaiPhieuNhap"
        Me.grlLoaiPhieuNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLoaiPhieuNhap.Properties.NullText = ""
        Me.grlLoaiPhieuNhap.Properties.ReadOnly = True
        Me.grlLoaiPhieuNhap.Properties.View = Me.GridView2
        Me.grlLoaiPhieuNhap.Size = New System.Drawing.Size(100, 20)
        Me.grlLoaiPhieuNhap.TabIndex = 0
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
        Me.txtTY_GIA.Location = New System.Drawing.Point(701, 31)
        Me.txtTY_GIA.Name = "txtTY_GIA"
        Me.txtTY_GIA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA.Properties.Mask.EditMask = "n2"
        Me.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA.Size = New System.Drawing.Size(92, 20)
        Me.txtTY_GIA.TabIndex = 12
        '
        'dteNGAY_CT
        '
        Me.dteNGAY_CT.EditValue = Nothing
        Me.dteNGAY_CT.EnterMoveNextControl = True
        Me.dteNGAY_CT.Location = New System.Drawing.Point(72, 31)
        Me.dteNGAY_CT.Name = "dteNGAY_CT"
        Me.dteNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_CT.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_CT.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_CT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dteNGAY_CT.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_CT.TabIndex = 1
        '
        'dteNGAY_GHI
        '
        Me.dteNGAY_GHI.EditValue = Nothing
        Me.dteNGAY_GHI.EnterMoveNextControl = True
        Me.dteNGAY_GHI.Location = New System.Drawing.Point(72, 57)
        Me.dteNGAY_GHI.Name = "dteNGAY_GHI"
        Me.dteNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_GHI.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_GHI.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_GHI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dteNGAY_GHI.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_GHI.TabIndex = 2
        '
        'cboTyGia
        '
        Me.cboTyGia.EnterMoveNextControl = True
        Me.cboTyGia.Location = New System.Drawing.Point(701, 5)
        Me.cboTyGia.Name = "cboTyGia"
        Me.cboTyGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTyGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTyGia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboTyGia.Properties.NullText = ""
        Me.cboTyGia.Size = New System.Drawing.Size(92, 20)
        Me.cboTyGia.TabIndex = 11
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(29, 86)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(28, 13)
        Me.labelControl11.TabIndex = 84
        Me.labelControl11.Text = "Số CT"
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(16, 34)
        Me.labelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 83
        Me.labelControl10.Text = "Ngày CT"
        '
        'labelControl9
        '
        Me.labelControl9.Location = New System.Drawing.Point(16, 60)
        Me.labelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelControl9.Name = "labelControl9"
        Me.labelControl9.Size = New System.Drawing.Size(41, 13)
        Me.labelControl9.TabIndex = 82
        Me.labelControl9.Text = "Ngày HT"
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(278, 57)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.Properties.MaxLength = 256
        Me.txtDIA_CHI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIA_CHI.Size = New System.Drawing.Size(331, 20)
        Me.txtDIA_CHI.TabIndex = 8
        '
        'txtNGUOI_GIAO_NHAN_HANG
        '
        Me.txtNGUOI_GIAO_NHAN_HANG.EnterMoveNextControl = True
        Me.txtNGUOI_GIAO_NHAN_HANG.Location = New System.Drawing.Point(278, 83)
        Me.txtNGUOI_GIAO_NHAN_HANG.Name = "txtNGUOI_GIAO_NHAN_HANG"
        Me.txtNGUOI_GIAO_NHAN_HANG.Properties.MaxLength = 128
        Me.txtNGUOI_GIAO_NHAN_HANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNGUOI_GIAO_NHAN_HANG.Size = New System.Drawing.Size(331, 20)
        Me.txtNGUOI_GIAO_NHAN_HANG.TabIndex = 9
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(278, 109)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.Properties.MaxLength = 256
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(331, 20)
        Me.txtDIEN_GIAI.TabIndex = 10
        '
        'labelControl33
        '
        Me.labelControl33.Location = New System.Drawing.Point(223, 112)
        Me.labelControl33.Name = "labelControl33"
        Me.labelControl33.Size = New System.Drawing.Size(40, 13)
        Me.labelControl33.TabIndex = 73
        Me.labelControl33.Text = "Diễn giải"
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(184, 86)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(79, 13)
        Me.labelControl5.TabIndex = 71
        Me.labelControl5.Text = "Người giao/nhận"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(231, 60)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(32, 13)
        Me.labelControl3.TabIndex = 70
        Me.labelControl3.Text = "Địa chỉ"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(233, 8)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(30, 13)
        Me.labelControl2.TabIndex = 69
        Me.labelControl2.Text = "Mã KH"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(22, 8)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(35, 13)
        Me.labelControl1.TabIndex = 8
        Me.labelControl1.Text = "Loại CT"
        '
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl2.Controls.Add(Me.grcPhieuPhapKho)
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 139)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(800, 396)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'grcPhieuPhapKho
        '
        Me.grcPhieuPhapKho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcPhieuPhapKho.Location = New System.Drawing.Point(0, 21)
        Me.grcPhieuPhapKho.MainView = Me.grvPhieuNhapKho
        Me.grcPhieuPhapKho.Name = "grcPhieuPhapKho"
        Me.grcPhieuPhapKho.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAlignment1, Me.GFilterEdit_HANGHOA_ID, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.Gfilter_MA_TKN_GIAVON, Me.Gfilter_MA_TKC_GIAVON, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.grcPhieuPhapKho.Size = New System.Drawing.Size(800, 375)
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
        Me.grvPhieuNhapKho.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.HanghoaId, Me.TenHanghoa, Me.TenDvt, Me.ViTri, Me.KhoNhapId, Me.KhoXuatId, Me.TonKho, Me.SoLuong, Me.DonGiaVonNte, Me.GiaVonNt, Me.DonGiaVon, Me.GiaVon, Me.MaTknGiavon, Me.VuviecId, Me.MaTkcGiavon, Me.IdDmPtqtCo, Me.IdDmTudo1Co, Me.IdDmTudo2Co, Me.IdDmTudo3Co, Me.IdDmTudo4Co, Me.IdDmTudo5Co, Me.IdDmPhongbanCo, Me.IdDmKhoanphiCo, Me.IdDmHopdongCo})
        Me.grvPhieuNhapKho.GridControl = Me.grcPhieuPhapKho
        Me.grvPhieuNhapKho.Name = "grvPhieuNhapKho"
        Me.grvPhieuNhapKho.OptionsNavigation.AutoFocusNewRow = True
        Me.grvPhieuNhapKho.OptionsNavigation.EnterMoveNextColumn = True
        Me.grvPhieuNhapKho.OptionsView.ColumnAutoWidth = False
        Me.grvPhieuNhapKho.OptionsView.EnableAppearanceEvenRow = True
        Me.grvPhieuNhapKho.OptionsView.EnableAppearanceOddRow = True
        Me.grvPhieuNhapKho.OptionsView.ShowGroupPanel = False
        '
        'HanghoaId
        '
        Me.HanghoaId.Caption = " Mã hàng "
        Me.HanghoaId.ColumnEdit = Me.GFilterEdit_HANGHOA_ID
        Me.HanghoaId.FieldName = "KyHieuHanghoa"
        Me.HanghoaId.Name = "HanghoaId"
        Me.HanghoaId.Visible = True
        Me.HanghoaId.VisibleIndex = 0
        Me.HanghoaId.Width = 130
        '
        'GFilterEdit_HANGHOA_ID
        '
        Me.GFilterEdit_HANGHOA_ID.AutoHeight = False
        Me.GFilterEdit_HANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" & _
            "nDvt--80-0;ViTri--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0"
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban;MdTkKho;ViTri" & _
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
        'TenHanghoa
        '
        Me.TenHanghoa.Caption = "Tên hàng / Vật tư"
        Me.TenHanghoa.FieldName = "TenHanghoa"
        Me.TenHanghoa.Name = "TenHanghoa"
        Me.TenHanghoa.OptionsColumn.ReadOnly = True
        Me.TenHanghoa.Visible = True
        Me.TenHanghoa.VisibleIndex = 1
        Me.TenHanghoa.Width = 120
        '
        'TenDvt
        '
        Me.TenDvt.Caption = "ĐVT"
        Me.TenDvt.FieldName = "TenDvt"
        Me.TenDvt.Name = "TenDvt"
        Me.TenDvt.OptionsColumn.ReadOnly = True
        Me.TenDvt.Visible = True
        Me.TenDvt.VisibleIndex = 2
        Me.TenDvt.Width = 70
        '
        'ViTri
        '
        Me.ViTri.Caption = "Vị trí"
        Me.ViTri.FieldName = "ViTri"
        Me.ViTri.Name = "ViTri"
        Me.ViTri.Visible = True
        Me.ViTri.VisibleIndex = 3
        '
        'KhoNhapId
        '
        Me.KhoNhapId.Caption = "Mã kho nhập"
        Me.KhoNhapId.ColumnEdit = Me.cboMaKho
        Me.KhoNhapId.FieldName = "KhoNhapId"
        Me.KhoNhapId.Name = "KhoNhapId"
        Me.KhoNhapId.Visible = True
        Me.KhoNhapId.VisibleIndex = 4
        Me.KhoNhapId.Width = 100
        '
        'KhoXuatId
        '
        Me.KhoXuatId.Caption = "Mã kho xuất"
        Me.KhoXuatId.ColumnEdit = Me.cboMakhoxuat
        Me.KhoXuatId.FieldName = "KhoXuatId"
        Me.KhoXuatId.Name = "KhoXuatId"
        Me.KhoXuatId.Visible = True
        Me.KhoXuatId.VisibleIndex = 5
        Me.KhoXuatId.Width = 100
        '
        'TonKho
        '
        Me.TonKho.Caption = "Tồn kho"
        Me.TonKho.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.TonKho.FieldName = "TonKho"
        Me.TonKho.Name = "TonKho"
        Me.TonKho.OptionsColumn.ReadOnly = True
        Me.TonKho.Visible = True
        Me.TonKho.VisibleIndex = 6
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
        Me.SoLuong.VisibleIndex = 7
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
        'DonGiaVonNte
        '
        Me.DonGiaVonNte.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaVonNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaVonNte.Caption = "Giá NTE"
        Me.DonGiaVonNte.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DonGiaVonNte.FieldName = "DonGiaVonNte"
        Me.DonGiaVonNte.Name = "DonGiaVonNte"
        Me.DonGiaVonNte.Visible = True
        Me.DonGiaVonNte.VisibleIndex = 8
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
        Me.GiaVonNt.VisibleIndex = 9
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
        'DonGiaVon
        '
        Me.DonGiaVon.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaVon.Caption = "Đơn giá"
        Me.DonGiaVon.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.DonGiaVon.DisplayFormat.FormatString = "#,###0"
        Me.DonGiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaVon.FieldName = "DonGiaVon"
        Me.DonGiaVon.Name = "DonGiaVon"
        Me.DonGiaVon.Visible = True
        Me.DonGiaVon.VisibleIndex = 10
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
        Me.GiaVon.VisibleIndex = 11
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
        'MaTknGiavon
        '
        Me.MaTknGiavon.Caption = "TK nợ"
        Me.MaTknGiavon.ColumnEdit = Me.Gfilter_MA_TKN_GIAVON
        Me.MaTknGiavon.FieldName = "MaTknGiavon"
        Me.MaTknGiavon.Name = "MaTknGiavon"
        Me.MaTknGiavon.Visible = True
        Me.MaTknGiavon.VisibleIndex = 12
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
        'VuviecId
        '
        Me.VuviecId.Caption = "Vụ việc"
        Me.VuviecId.ColumnEdit = Me.cboVuViec
        Me.VuviecId.FieldName = "VuviecId"
        Me.VuviecId.Name = "VuviecId"
        Me.VuviecId.Visible = True
        Me.VuviecId.VisibleIndex = 13
        Me.VuviecId.Width = 120
        '
        'MaTkcGiavon
        '
        Me.MaTkcGiavon.Caption = "Tk có"
        Me.MaTkcGiavon.ColumnEdit = Me.Gfilter_MA_TKC_GIAVON
        Me.MaTkcGiavon.FieldName = "MaTkcGiavon"
        Me.MaTkcGiavon.Name = "MaTkcGiavon"
        Me.MaTkcGiavon.Visible = True
        Me.MaTkcGiavon.VisibleIndex = 14
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
        Me.IdDmPtqtCo.VisibleIndex = 15
        '
        'IdDmTudo1Co
        '
        Me.IdDmTudo1Co.Caption = "DM Tự do 1"
        Me.IdDmTudo1Co.ColumnEdit = Me.cboTudo1
        Me.IdDmTudo1Co.FieldName = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Name = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Visible = True
        Me.IdDmTudo1Co.VisibleIndex = 16
        '
        'IdDmTudo2Co
        '
        Me.IdDmTudo2Co.Caption = "DM Tự do 2"
        Me.IdDmTudo2Co.ColumnEdit = Me.cboTudo2
        Me.IdDmTudo2Co.FieldName = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Name = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Visible = True
        Me.IdDmTudo2Co.VisibleIndex = 17
        '
        'IdDmTudo3Co
        '
        Me.IdDmTudo3Co.Caption = "DM Tự do 3"
        Me.IdDmTudo3Co.ColumnEdit = Me.cboTudo3
        Me.IdDmTudo3Co.FieldName = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Name = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Visible = True
        Me.IdDmTudo3Co.VisibleIndex = 18
        '
        'IdDmTudo4Co
        '
        Me.IdDmTudo4Co.Caption = "DM Tự do 4"
        Me.IdDmTudo4Co.ColumnEdit = Me.cboTudo4
        Me.IdDmTudo4Co.FieldName = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Name = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Visible = True
        Me.IdDmTudo4Co.VisibleIndex = 19
        '
        'IdDmTudo5Co
        '
        Me.IdDmTudo5Co.Caption = "DM Tự do 5"
        Me.IdDmTudo5Co.ColumnEdit = Me.cboTudo5
        Me.IdDmTudo5Co.FieldName = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Name = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Visible = True
        Me.IdDmTudo5Co.VisibleIndex = 20
        '
        'IdDmPhongbanCo
        '
        Me.IdDmPhongbanCo.Caption = "DM Phòng ban"
        Me.IdDmPhongbanCo.ColumnEdit = Me.cboPhongban
        Me.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Name = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Visible = True
        Me.IdDmPhongbanCo.VisibleIndex = 21
        '
        'IdDmKhoanphiCo
        '
        Me.IdDmKhoanphiCo.Caption = "DM Khoản phí"
        Me.IdDmKhoanphiCo.ColumnEdit = Me.cboKhoanphi
        Me.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Visible = True
        Me.IdDmKhoanphiCo.VisibleIndex = 22
        '
        'IdDmHopdongCo
        '
        Me.IdDmHopdongCo.Caption = "DM Hợp đồng"
        Me.IdDmHopdongCo.ColumnEdit = Me.cboHopdong
        Me.IdDmHopdongCo.FieldName = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Name = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Visible = True
        Me.IdDmHopdongCo.VisibleIndex = 23
        '
        'RepositoryItemAlignment1
        '
        Me.RepositoryItemAlignment1.AutoHeight = False
        Me.RepositoryItemAlignment1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAlignment1.Name = "RepositoryItemAlignment1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(800, 21)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(385, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckEdit1.Location = New System.Drawing.Point(2, 2)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Nhập theo giá TB cho VT tính giá TB                                              " & _
            "                                             "
        Me.CheckEdit1.Size = New System.Drawing.Size(229, 19)
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
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 571)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grcLPN_Hnx)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(194, 571)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Danh sách..."
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(2, 22)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(190, 547)
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
        Me.GroupControl3.Location = New System.Drawing.Point(0, 535)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(800, 36)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "GroupControl3"
        '
        'UR_STATUS
        '
        Me.UR_STATUS.CheckStatus = True
        Me.UR_STATUS.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_STATUS.Location = New System.Drawing.Point(5, 6)
        Me.UR_STATUS.Margin = New System.Windows.Forms.Padding(4)
        Me.UR_STATUS.Name = "UR_STATUS"
        Me.UR_STATUS.Size = New System.Drawing.Size(314, 20)
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
        Me.txtTongSoLuong.Location = New System.Drawing.Point(410, 7)
        Me.txtTongSoLuong.Name = "txtTongSoLuong"
        Me.txtTongSoLuong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongSoLuong.Properties.Mask.EditMask = "n2"
        Me.txtTongSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongSoLuong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongSoLuong.Properties.ReadOnly = True
        Me.txtTongSoLuong.Size = New System.Drawing.Size(138, 20)
        Me.txtTongSoLuong.TabIndex = 1
        Me.txtTongSoLuong.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(326, 10)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl6.TabIndex = 66
        Me.LabelControl6.Text = "Tổng số lượng"
        '
        'TxtTongTien
        '
        Me.TxtTongTien.Location = New System.Drawing.Point(633, 6)
        Me.TxtTongTien.Name = "TxtTongTien"
        Me.TxtTongTien.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtTongTien.Properties.Mask.EditMask = "n0"
        Me.TxtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtTongTien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtTongTien.Properties.ReadOnly = True
        Me.TxtTongTien.Size = New System.Drawing.Size(149, 20)
        Me.TxtTongTien.TabIndex = 2
        Me.TxtTongTien.TabStop = False
        '
        'labelControl22
        '
        Me.labelControl22.Location = New System.Drawing.Point(571, 9)
        Me.labelControl22.Name = "labelControl22"
        Me.labelControl22.Size = New System.Drawing.Size(45, 13)
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
        Me.PanelControl2.Location = New System.Drawing.Point(4, 575)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 30)
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
        Me.navWelding1.Name = "navWelding1"
        Me.navWelding1.NavigatableControl = Me.grcLPN_Hnx
        Me.navWelding1.Size = New System.Drawing.Size(194, 30)
        Me.navWelding1.TabIndex = 1
        Me.navWelding1.Text = "ControlNavigator4"
        Me.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navWelding1.TextStringFormat = " {0} / {1}"
        '
        'btnSea
        '
        Me.btnSea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(541, 0)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(80, 30)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm kiếm"
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCan.ImageIndex = 4
        Me.btnCan.Location = New System.Drawing.Point(713, 0)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(80, 30)
        Me.btnCan.TabIndex = 6
        Me.btnCan.Text = "&Hủy"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(197, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(283, 0)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(80, 30)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Sửa"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(369, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "&Xóa"
        '
        'btnQui
        '
        Me.btnQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQui.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQui.ImageIndex = 8
        Me.btnQui.Location = New System.Drawing.Point(920, 0)
        Me.btnQui.Name = "btnQui"
        Me.btnQui.Size = New System.Drawing.Size(80, 30)
        Me.btnQui.TabIndex = 7
        Me.btnQui.Text = "&Quay ra"
        '
        'btnPri
        '
        Me.btnPri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPri.ImageIndex = 15
        Me.btnPri.Location = New System.Drawing.Point(627, 0)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 5
        Me.btnPri.Text = "&In phiếu"
        '
        'btnSav
        '
        Me.btnSav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(455, 0)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(80, 30)
        Me.btnSav.TabIndex = 2
        Me.btnSav.Text = "&Lưu"
        '
        'frmPhieuNhapKho_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 609)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmPhieuNhapKho_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
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
        CType(Me.dteHDPN.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteHDPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHDPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLoaiPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTyGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGUOI_GIAO_NHAN_HANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grcPhieuPhapKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPhieuNhapKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gfilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gfilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNGUOI_GIAO_NHAN_HANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl9 As DevExpress.XtraEditors.LabelControl
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
    Private WithEvents dteNGAY_CT As DevExpress.XtraEditors.DateEdit
    Private WithEvents dteNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grlLoaiPhieuNhap As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TKC_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMST_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHDPN As DevExpress.XtraEditors.TextEdit
    Private WithEvents lblHDPN As DevExpress.XtraEditors.LabelControl
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
    Private WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Private WithEvents lblNgayHDPN As DevExpress.XtraEditors.LabelControl
    Private WithEvents dteHDPN As DevExpress.XtraEditors.DateEdit
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
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GFilter As Vns.Erp.Core.CustomFilter
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents UR_STATUS As Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT
    Friend WithEvents Gfilter_MA_TKN_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents Gfilter_MA_TKC_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VI_TRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GFilter_TK As Vns.Erp.Core.CustomFilter
    Friend WithEvents lblTK As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TON_KHO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents HanghoaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenHanghoa As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents VuviecId As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents C_SoChungTu_RP As Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu
End Class
