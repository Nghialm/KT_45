<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet))
        Dim ValueInfo2 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.ThuTu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTaikhoanno = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTaiKhoanKho = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMaKho = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMaHang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTaikhoandoanhthu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboPTQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboPhongBan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhoanphi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboHopdong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.grpSMQR = New DevExpress.XtraEditors.GroupControl()
        Me.C_SO_CT_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit()
        Me.GFilter_TK = New Vns.Erp.Core.CustomFilter()
        Me.GFilter = New Vns.Erp.Core.CustomFilter()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.txtMST_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.grlPHONGBAN_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dteNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.dteNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkNGOAI_TE = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.grlID_LOAI_CT = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSO_SERI = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.txtNGUOI_NHAN_NOP_TIEN = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeNhapTienThue = New DevExpress.XtraEditors.CheckEdit()
        Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.labelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GFilter_TKN_CK = New Vns.Erp.Core.CustomFilter()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GFilter_TKN_THUE_GTGT = New Vns.Erp.Core.CustomFilter()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GFilter_TKC_CK = New Vns.Erp.Core.CustomFilter()
        Me.GFilter_TKC_THUE_GTGT = New Vns.Erp.Core.CustomFilter()
        Me.UR_STATUS = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
        Me.txtSO_NGAY_THANH_TOAN = New DevExpress.XtraEditors.TextEdit()
        Me.txtTong = New DevExpress.XtraEditors.TextEdit()
        Me.txtTaiKhoanChietKhau = New DevExpress.XtraEditors.TextEdit()
        Me.txtTienThue = New DevExpress.XtraEditors.TextEdit()
        Me.txtTienHang = New DevExpress.XtraEditors.TextEdit()
        Me.txtTienVon = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.VuviecId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTienBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaTknGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_MA_TKN_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.MaTkcGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_MA_TKC_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.KhoXuatId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.navCTHG = New DevExpress.XtraEditors.ControlNavigator()
        Me.grcLPN_Hnx = New DevExpress.XtraGrid.GridControl()
        Me.grvLPX_Hnx = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Ghi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CtSo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayCt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NgayGhi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSea = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCan = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQui = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.GrcHoaDonBanHang = New DevExpress.XtraGrid.GridControl()
        Me.GrcHoaDonBanHang_View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HanghoaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilterEdit_HANGHOA_ID = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TenHanghoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DonGiaBanNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoTienBanNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoTienCk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ThueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMthue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TyLeThueGtgt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SoTienThueGtgt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaTkcGiaban = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_MA_TKC_GIABAN = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.IdDmPtqtCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo1Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo2Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo3Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo4Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmTudo5Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmPhongbanCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmKhoanphiCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdDmHopdongCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.depCT_H_Nx = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaikhoanno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaiKhoanKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaikhoandoanhthu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopdong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMQR.SuspendLayout()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlPHONGBAN_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlID_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SERI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.txtSO_NGAY_THANH_TOAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaiKhoanChietKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienVon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrcHoaDonBanHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrcHoaDonBanHang_View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_MA_TKC_GIABAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThuTu
        '
        Me.ThuTu.Caption = "THU_TU"
        Me.ThuTu.FieldName = "ThuTu"
        Me.ThuTu.Name = "ThuTu"
        '
        'cboVuViec
        '
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'cboTaikhoanno
        '
        Me.cboTaikhoanno.AutoHeight = False
        Me.cboTaikhoanno.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaikhoanno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaikhoanno.Name = "cboTaikhoanno"
        Me.cboTaikhoanno.NullText = ""
        '
        'cboTaiKhoanKho
        '
        Me.cboTaiKhoanKho.AutoHeight = False
        Me.cboTaiKhoanKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaiKhoanKho.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaiKhoanKho.Name = "cboTaiKhoanKho"
        Me.cboTaiKhoanKho.NullText = ""
        '
        'cboMaKho
        '
        Me.cboMaKho.AutoHeight = False
        Me.cboMaKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaKho.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.NullText = ""
        '
        'cboMaHang
        '
        Me.cboMaHang.AutoHeight = False
        Me.cboMaHang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaHang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaHang.Name = "cboMaHang"
        Me.cboMaHang.NullText = ""
        '
        'cboTaikhoandoanhthu
        '
        Me.cboTaikhoandoanhthu.AutoHeight = False
        Me.cboTaikhoandoanhthu.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaikhoandoanhthu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaikhoandoanhthu.Name = "cboTaikhoandoanhthu"
        Me.cboTaikhoandoanhthu.NullText = ""
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
        'cboPhongBan
        '
        Me.cboPhongBan.AutoHeight = False
        Me.cboPhongBan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongBan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.NullText = ""
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
        'grpSMQR
        '
        Me.grpSMQR.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grpSMQR.Appearance.BorderColor = System.Drawing.Color.White
        Me.grpSMQR.Appearance.Options.UseBackColor = True
        Me.grpSMQR.Appearance.Options.UseBorderColor = True
        Me.grpSMQR.Controls.Add(Me.C_SO_CT_RP)
        Me.grpSMQR.Controls.Add(Me.txtTY_GIA)
        Me.grpSMQR.Controls.Add(Me.GFilter_TK)
        Me.grpSMQR.Controls.Add(Me.GFilter)
        Me.grpSMQR.Controls.Add(Me.LabelControl4)
        Me.grpSMQR.Controls.Add(Me.txtTEN_KHANG)
        Me.grpSMQR.Controls.Add(Me.txtMST_KHANG)
        Me.grpSMQR.Controls.Add(Me.grlPHONGBAN_ID)
        Me.grpSMQR.Controls.Add(Me.dteNGAY_CT)
        Me.grpSMQR.Controls.Add(Me.dteNGAY_GHI)
        Me.grpSMQR.Controls.Add(Me.cboNgoaiTe)
        Me.grpSMQR.Controls.Add(Me.chkNGOAI_TE)
        Me.grpSMQR.Controls.Add(Me.LabelControl24)
        Me.grpSMQR.Controls.Add(Me.grlID_LOAI_CT)
        Me.grpSMQR.Controls.Add(Me.txtSO_SERI)
        Me.grpSMQR.Controls.Add(Me.txtDIA_CHI)
        Me.grpSMQR.Controls.Add(Me.txtDIEN_GIAI)
        Me.grpSMQR.Controls.Add(Me.txtNGUOI_NHAN_NOP_TIEN)
        Me.grpSMQR.Controls.Add(Me.labelControl3)
        Me.grpSMQR.Controls.Add(Me.labelControl15)
        Me.grpSMQR.Controls.Add(Me.labelControl16)
        Me.grpSMQR.Controls.Add(Me.labelControl11)
        Me.grpSMQR.Controls.Add(Me.labelControl2)
        Me.grpSMQR.Controls.Add(Me.labelControl12)
        Me.grpSMQR.Controls.Add(Me.labelControl10)
        Me.grpSMQR.Controls.Add(Me.LabelControl5)
        Me.grpSMQR.Controls.Add(Me.labelControl35)
        Me.grpSMQR.Controls.Add(Me.labelControl19)
        Me.grpSMQR.Controls.Add(Me.labelControl6)
        Me.grpSMQR.Controls.Add(Me.LabelControl1)
        Me.grpSMQR.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSMQR.Location = New System.Drawing.Point(0, 0)
        Me.grpSMQR.Name = "grpSMQR"
        Me.grpSMQR.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSMQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpSMQR.ShowCaption = False
        Me.grpSMQR.Size = New System.Drawing.Size(801, 188)
        Me.grpSMQR.TabIndex = 0
        Me.grpSMQR.Text = "Thông tin chính"
        '
        'C_SO_CT_RP
        '
        Me.C_SO_CT_RP.Enabled = False
        Me.C_SO_CT_RP.HtLoaichungtuService = Nothing
        Me.C_SO_CT_RP.Location = New System.Drawing.Point(68, 89)
        Me.C_SO_CT_RP.Name = "C_SO_CT_RP"
        Me.C_SO_CT_RP.PREFIX = Nothing
        Me.C_SO_CT_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SO_CT_RP.SO_CHUNG_TU = Nothing
        Me.C_SO_CT_RP.TabIndex = 3
        '
        'txtTY_GIA
        '
        Me.txtTY_GIA.EnterMoveNextControl = True
        Me.txtTY_GIA.Location = New System.Drawing.Point(698, 37)
        Me.txtTY_GIA.Name = "txtTY_GIA"
        Me.txtTY_GIA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA.Properties.DisplayFormat.FormatString = "n"
        Me.txtTY_GIA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTY_GIA.Properties.EditFormat.FormatString = "n"
        Me.txtTY_GIA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTY_GIA.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.txtTY_GIA.Properties.Mask.EditMask = "n"
        Me.txtTY_GIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA.Properties.MaxLength = 12
        Me.txtTY_GIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTY_GIA.Size = New System.Drawing.Size(95, 20)
        Me.txtTY_GIA.TabIndex = 14
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
        Me.GFilter_TK.Location = New System.Drawing.Point(68, 141)
        Me.GFilter_TK.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TK.Name = "GFilter_TK"
        Me.GFilter_TK.NEXT_TAB = 0
        Me.GFilter_TK.Size = New System.Drawing.Size(100, 20)
        Me.GFilter_TK.TabIndex = 5
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
        Me.GFilter.ENABLES = True
        Me.GFilter.IsNotTextChanged = True
        Me.GFilter.ListEditValue = CType(resources.GetObject("GFilter.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter.Location = New System.Drawing.Point(287, 11)
        Me.GFilter.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter.Name = "GFilter"
        Me.GFilter.NEXT_TAB = 0
        Me.GFilter.Size = New System.Drawing.Size(124, 20)
        Me.GFilter.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(222, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Tên khách"
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(287, 37)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.Properties.MaxLength = 128
        Me.txtTEN_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(301, 20)
        Me.txtTEN_KHANG.TabIndex = 8
        '
        'txtMST_KHANG
        '
        Me.txtMST_KHANG.EnterMoveNextControl = True
        Me.txtMST_KHANG.Location = New System.Drawing.Point(476, 11)
        Me.txtMST_KHANG.Name = "txtMST_KHANG"
        Me.txtMST_KHANG.Properties.MaxLength = 32
        Me.txtMST_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMST_KHANG.Size = New System.Drawing.Size(112, 20)
        Me.txtMST_KHANG.TabIndex = 7
        '
        'grlPHONGBAN_ID
        '
        Me.grlPHONGBAN_ID.EnterMoveNextControl = True
        Me.grlPHONGBAN_ID.Location = New System.Drawing.Point(287, 141)
        Me.grlPHONGBAN_ID.Name = "grlPHONGBAN_ID"
        Me.grlPHONGBAN_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlPHONGBAN_ID.Properties.NullText = ""
        Me.grlPHONGBAN_ID.Properties.View = Me.GridView9
        Me.grlPHONGBAN_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlPHONGBAN_ID.Size = New System.Drawing.Size(301, 20)
        Me.grlPHONGBAN_ID.TabIndex = 12
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ký hiệu"
        Me.GridColumn3.FieldName = "KyHieu"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên phòng ban"
        Me.GridColumn4.FieldName = "TenPhongban"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'dteNGAY_CT
        '
        Me.dteNGAY_CT.EditValue = Nothing
        Me.dteNGAY_CT.EnterMoveNextControl = True
        Me.dteNGAY_CT.Location = New System.Drawing.Point(68, 37)
        Me.dteNGAY_CT.Name = "dteNGAY_CT"
        Me.dteNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_CT.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_CT.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_CT.TabIndex = 1
        '
        'dteNGAY_GHI
        '
        Me.dteNGAY_GHI.EditValue = Nothing
        Me.dteNGAY_GHI.EnterMoveNextControl = True
        Me.dteNGAY_GHI.Location = New System.Drawing.Point(68, 63)
        Me.dteNGAY_GHI.Name = "dteNGAY_GHI"
        Me.dteNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dteNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteNGAY_GHI.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.dteNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteNGAY_GHI.Size = New System.Drawing.Size(100, 20)
        Me.dteNGAY_GHI.TabIndex = 2
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(698, 11)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.Size = New System.Drawing.Size(95, 20)
        Me.cboNgoaiTe.TabIndex = 13
        '
        'chkNGOAI_TE
        '
        Me.chkNGOAI_TE.Location = New System.Drawing.Point(717, 63)
        Me.chkNGOAI_TE.Name = "chkNGOAI_TE"
        Me.chkNGOAI_TE.Properties.Caption = "Ngoại tệ"
        Me.chkNGOAI_TE.Size = New System.Drawing.Size(70, 19)
        Me.chkNGOAI_TE.TabIndex = 13
        Me.chkNGOAI_TE.Visible = False
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(654, 40)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl24.TabIndex = 25
        Me.LabelControl24.Text = "Tỷ giá"
        '
        'grlID_LOAI_CT
        '
        Me.grlID_LOAI_CT.Enabled = False
        Me.grlID_LOAI_CT.EnterMoveNextControl = True
        Me.grlID_LOAI_CT.Location = New System.Drawing.Point(68, 11)
        Me.grlID_LOAI_CT.Name = "grlID_LOAI_CT"
        Me.grlID_LOAI_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlID_LOAI_CT.Properties.NullText = ""
        Me.grlID_LOAI_CT.Properties.View = Me.GridView2
        Me.grlID_LOAI_CT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grlID_LOAI_CT.Size = New System.Drawing.Size(100, 20)
        Me.grlID_LOAI_CT.TabIndex = 0
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn22})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Ký hiệu"
        Me.GridColumn21.FieldName = "KyHieu"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Tên loại chứng từ"
        Me.GridColumn22.FieldName = "TenLoaiCt"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        '
        'txtSO_SERI
        '
        Me.txtSO_SERI.EnterMoveNextControl = True
        Me.txtSO_SERI.Location = New System.Drawing.Point(68, 115)
        Me.txtSO_SERI.Name = "txtSO_SERI"
        Me.txtSO_SERI.Properties.MaxLength = 32
        Me.txtSO_SERI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSO_SERI.Size = New System.Drawing.Size(100, 20)
        Me.txtSO_SERI.TabIndex = 4
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(287, 63)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.Properties.MaxLength = 256
        Me.txtDIA_CHI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIA_CHI.Size = New System.Drawing.Size(301, 20)
        Me.txtDIA_CHI.TabIndex = 9
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(287, 115)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.Properties.MaxLength = 256
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(301, 20)
        Me.txtDIEN_GIAI.TabIndex = 11
        '
        'txtNGUOI_NHAN_NOP_TIEN
        '
        Me.txtNGUOI_NHAN_NOP_TIEN.EnterMoveNextControl = True
        Me.txtNGUOI_NHAN_NOP_TIEN.Location = New System.Drawing.Point(287, 89)
        Me.txtNGUOI_NHAN_NOP_TIEN.Name = "txtNGUOI_NHAN_NOP_TIEN"
        Me.txtNGUOI_NHAN_NOP_TIEN.Properties.MaxLength = 128
        Me.txtNGUOI_NHAN_NOP_TIEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNGUOI_NHAN_NOP_TIEN.Size = New System.Drawing.Size(301, 20)
        Me.txtNGUOI_NHAN_NOP_TIEN.TabIndex = 10
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(246, 146)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(25, 13)
        Me.labelControl3.TabIndex = 24
        Me.labelControl3.Text = "BPKD"
        '
        'labelControl15
        '
        Me.labelControl15.Location = New System.Drawing.Point(26, 144)
        Me.labelControl15.Name = "labelControl15"
        Me.labelControl15.Size = New System.Drawing.Size(26, 13)
        Me.labelControl15.TabIndex = 20
        Me.labelControl15.Text = "Tk nợ"
        '
        'labelControl16
        '
        Me.labelControl16.Location = New System.Drawing.Point(231, 118)
        Me.labelControl16.Name = "labelControl16"
        Me.labelControl16.Size = New System.Drawing.Size(40, 13)
        Me.labelControl16.TabIndex = 19
        Me.labelControl16.Text = "Diễn giải"
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(217, 92)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(54, 13)
        Me.labelControl11.TabIndex = 18
        Me.labelControl11.Text = "Người mua "
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(417, 14)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(53, 13)
        Me.labelControl2.TabIndex = 17
        Me.labelControl2.Text = "Mã số thuế"
        '
        'labelControl12
        '
        Me.labelControl12.Location = New System.Drawing.Point(239, 66)
        Me.labelControl12.Name = "labelControl12"
        Me.labelControl12.Size = New System.Drawing.Size(32, 13)
        Me.labelControl12.TabIndex = 16
        Me.labelControl12.Text = "Địa chỉ"
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(11, 40)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 22
        Me.labelControl10.Text = "Ngày CT"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(226, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Mã khách"
        '
        'labelControl35
        '
        Me.labelControl35.Location = New System.Drawing.Point(20, 118)
        Me.labelControl35.Name = "labelControl35"
        Me.labelControl35.Size = New System.Drawing.Size(32, 13)
        Me.labelControl35.TabIndex = 25
        Me.labelControl35.Text = "Số seri"
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(24, 92)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(28, 13)
        Me.labelControl19.TabIndex = 23
        Me.labelControl19.Text = "Số CT"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(11, 66)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(41, 13)
        Me.labelControl6.TabIndex = 21
        Me.labelControl6.Text = "Ngày HT"
        '
        'LabelControl1
        '
        Me.LabelControl1.Enabled = False
        Me.LabelControl1.Location = New System.Drawing.Point(17, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Loại CT"
        '
        'checkEdit4
        '
        Me.checkEdit4.Location = New System.Drawing.Point(7, 3)
        Me.checkEdit4.Name = "checkEdit4"
        Me.checkEdit4.Properties.Caption = "Xuất theo giá vốn đích danh VT cho TB "
        Me.checkEdit4.Size = New System.Drawing.Size(205, 19)
        Me.checkEdit4.TabIndex = 0
        Me.checkEdit4.Visible = False
        '
        'checkEdit3
        '
        Me.checkEdit3.Location = New System.Drawing.Point(670, 61)
        Me.checkEdit3.Name = "checkEdit3"
        Me.checkEdit3.Properties.Caption = "Nhập tiền chiết khấu"
        Me.checkEdit3.Size = New System.Drawing.Size(123, 19)
        Me.checkEdit3.TabIndex = 9
        '
        'ckeNhapTienThue
        '
        Me.ckeNhapTienThue.Location = New System.Drawing.Point(670, 34)
        Me.ckeNhapTienThue.Name = "ckeNhapTienThue"
        Me.ckeNhapTienThue.Properties.Caption = "Nhập tiền thuế"
        Me.ckeNhapTienThue.Size = New System.Drawing.Size(123, 19)
        Me.ckeNhapTienThue.TabIndex = 7
        '
        'checkEdit1
        '
        Me.checkEdit1.Location = New System.Drawing.Point(670, 8)
        Me.checkEdit1.Name = "checkEdit1"
        Me.checkEdit1.Properties.Caption = "Sửa HT thuế"
        Me.checkEdit1.Size = New System.Drawing.Size(123, 19)
        Me.checkEdit1.TabIndex = 5
        Me.checkEdit1.Visible = False
        '
        'labelControl34
        '
        Me.labelControl34.Location = New System.Drawing.Point(5, 63)
        Me.labelControl34.Name = "labelControl34"
        Me.labelControl34.Size = New System.Drawing.Size(94, 13)
        Me.labelControl34.TabIndex = 4
        Me.labelControl34.Text = "TK có/nợ chiết khấu"
        '
        'labelControl44
        '
        Me.labelControl44.Location = New System.Drawing.Point(432, 37)
        Me.labelControl44.Name = "labelControl44"
        Me.labelControl44.Size = New System.Drawing.Size(45, 13)
        Me.labelControl44.TabIndex = 5
        Me.labelControl44.Text = "Tiền thuế"
        '
        'labelControl30
        '
        Me.labelControl30.Location = New System.Drawing.Point(32, 38)
        Me.labelControl30.Name = "labelControl30"
        Me.labelControl30.Size = New System.Drawing.Size(67, 13)
        Me.labelControl30.TabIndex = 2
        Me.labelControl30.Text = "TK có/nợ thuế"
        '
        'labelControl42
        '
        Me.labelControl42.Location = New System.Drawing.Point(430, 11)
        Me.labelControl42.Name = "labelControl42"
        Me.labelControl42.Size = New System.Drawing.Size(47, 13)
        Me.labelControl42.TabIndex = 5
        Me.labelControl42.Text = "Tiền hàng"
        '
        'labelControl46
        '
        Me.labelControl46.Location = New System.Drawing.Point(58, 11)
        Me.labelControl46.Name = "labelControl46"
        Me.labelControl46.Size = New System.Drawing.Size(41, 13)
        Me.labelControl46.TabIndex = 1
        Me.labelControl46.Text = "Tiền vốn"
        Me.labelControl46.Visible = False
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.GFilter_TKN_CK)
        Me.groupControl2.Controls.Add(Me.LabelControl8)
        Me.groupControl2.Controls.Add(Me.GFilter_TKN_THUE_GTGT)
        Me.groupControl2.Controls.Add(Me.LabelControl7)
        Me.groupControl2.Controls.Add(Me.GFilter_TKC_CK)
        Me.groupControl2.Controls.Add(Me.GFilter_TKC_THUE_GTGT)
        Me.groupControl2.Controls.Add(Me.UR_STATUS)
        Me.groupControl2.Controls.Add(Me.txtSO_NGAY_THANH_TOAN)
        Me.groupControl2.Controls.Add(Me.txtTong)
        Me.groupControl2.Controls.Add(Me.txtTaiKhoanChietKhau)
        Me.groupControl2.Controls.Add(Me.txtTienThue)
        Me.groupControl2.Controls.Add(Me.txtTienHang)
        Me.groupControl2.Controls.Add(Me.txtTienVon)
        Me.groupControl2.Controls.Add(Me.checkEdit3)
        Me.groupControl2.Controls.Add(Me.ckeNhapTienThue)
        Me.groupControl2.Controls.Add(Me.checkEdit1)
        Me.groupControl2.Controls.Add(Me.labelControl46)
        Me.groupControl2.Controls.Add(Me.labelControl26)
        Me.groupControl2.Controls.Add(Me.labelControl48)
        Me.groupControl2.Controls.Add(Me.labelControl45)
        Me.groupControl2.Controls.Add(Me.labelControl34)
        Me.groupControl2.Controls.Add(Me.labelControl44)
        Me.groupControl2.Controls.Add(Me.labelControl30)
        Me.groupControl2.Controls.Add(Me.labelControl42)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupControl2.Location = New System.Drawing.Point(0, 449)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.groupControl2.ShowCaption = False
        Me.groupControl2.Size = New System.Drawing.Size(801, 118)
        Me.groupControl2.TabIndex = 1
        Me.groupControl2.Text = "Thông tin tổng hợp"
        '
        'GFilter_TKN_CK
        '
        Me.GFilter_TKN_CK.AllowNull = True
        Me.GFilter_TKN_CK.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TKN_CK.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TKN_CK.C_DATA_SOURCE = Nothing
        Me.GFilter_TKN_CK.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TKN_CK.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TKN_CK.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TKN_CK.C_IS_CHECK_OTHER = "="
        Me.GFilter_TKN_CK.C_IS_CHECK_STRING = "="
        Me.GFilter_TKN_CK.C_IS_FILTER_STRING = ""
        Me.GFilter_TKN_CK.C_IS_QUICKADD = False
        Me.GFilter_TKN_CK.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TKN_CK.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TKN_CK.EditValue = ""
        Me.GFilter_TKN_CK.EditValues = ""
        Me.GFilter_TKN_CK.ENABLES = True
        Me.GFilter_TKN_CK.IsNotTextChanged = True
        Me.GFilter_TKN_CK.ListEditValue = CType(resources.GetObject("GFilter_TKN_CK.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TKN_CK.Location = New System.Drawing.Point(225, 60)
        Me.GFilter_TKN_CK.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TKN_CK.Name = "GFilter_TKN_CK"
        Me.GFilter_TKN_CK.NEXT_TAB = 0
        Me.GFilter_TKN_CK.Size = New System.Drawing.Size(105, 20)
        Me.GFilter_TKN_CK.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(216, 64)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "/"
        '
        'GFilter_TKN_THUE_GTGT
        '
        Me.GFilter_TKN_THUE_GTGT.AllowNull = True
        Me.GFilter_TKN_THUE_GTGT.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TKN_THUE_GTGT.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TKN_THUE_GTGT.C_DATA_SOURCE = Nothing
        Me.GFilter_TKN_THUE_GTGT.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TKN_THUE_GTGT.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TKN_THUE_GTGT.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TKN_THUE_GTGT.C_IS_CHECK_OTHER = "="
        Me.GFilter_TKN_THUE_GTGT.C_IS_CHECK_STRING = "="
        Me.GFilter_TKN_THUE_GTGT.C_IS_FILTER_STRING = ""
        Me.GFilter_TKN_THUE_GTGT.C_IS_QUICKADD = False
        Me.GFilter_TKN_THUE_GTGT.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TKN_THUE_GTGT.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TKN_THUE_GTGT.EditValue = ""
        Me.GFilter_TKN_THUE_GTGT.EditValues = ""
        Me.GFilter_TKN_THUE_GTGT.ENABLES = True
        Me.GFilter_TKN_THUE_GTGT.IsNotTextChanged = True
        Me.GFilter_TKN_THUE_GTGT.ListEditValue = CType(resources.GetObject("GFilter_TKN_THUE_GTGT.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TKN_THUE_GTGT.Location = New System.Drawing.Point(225, 34)
        Me.GFilter_TKN_THUE_GTGT.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TKN_THUE_GTGT.Name = "GFilter_TKN_THUE_GTGT"
        Me.GFilter_TKN_THUE_GTGT.NEXT_TAB = 0
        Me.GFilter_TKN_THUE_GTGT.Size = New System.Drawing.Size(105, 20)
        Me.GFilter_TKN_THUE_GTGT.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(216, 38)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "/"
        '
        'GFilter_TKC_CK
        '
        Me.GFilter_TKC_CK.AllowNull = True
        Me.GFilter_TKC_CK.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TKC_CK.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TKC_CK.C_DATA_SOURCE = Nothing
        Me.GFilter_TKC_CK.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TKC_CK.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TKC_CK.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TKC_CK.C_IS_CHECK_OTHER = "="
        Me.GFilter_TKC_CK.C_IS_CHECK_STRING = "="
        Me.GFilter_TKC_CK.C_IS_FILTER_STRING = ""
        Me.GFilter_TKC_CK.C_IS_QUICKADD = False
        Me.GFilter_TKC_CK.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TKC_CK.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TKC_CK.EditValue = ""
        Me.GFilter_TKC_CK.EditValues = ""
        Me.GFilter_TKC_CK.ENABLES = True
        Me.GFilter_TKC_CK.IsNotTextChanged = True
        Me.GFilter_TKC_CK.ListEditValue = CType(resources.GetObject("GFilter_TKC_CK.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TKC_CK.Location = New System.Drawing.Point(105, 60)
        Me.GFilter_TKC_CK.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TKC_CK.Name = "GFilter_TKC_CK"
        Me.GFilter_TKC_CK.NEXT_TAB = 0
        Me.GFilter_TKC_CK.Size = New System.Drawing.Size(105, 20)
        Me.GFilter_TKC_CK.TabIndex = 3
        '
        'GFilter_TKC_THUE_GTGT
        '
        Me.GFilter_TKC_THUE_GTGT.AllowNull = True
        Me.GFilter_TKC_THUE_GTGT.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_TKC_THUE_GTGT.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_TKC_THUE_GTGT.C_DATA_SOURCE = Nothing
        Me.GFilter_TKC_THUE_GTGT.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_TKC_THUE_GTGT.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_TKC_THUE_GTGT.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_TKC_THUE_GTGT.C_IS_CHECK_OTHER = "="
        Me.GFilter_TKC_THUE_GTGT.C_IS_CHECK_STRING = "="
        Me.GFilter_TKC_THUE_GTGT.C_IS_FILTER_STRING = ""
        Me.GFilter_TKC_THUE_GTGT.C_IS_QUICKADD = False
        Me.GFilter_TKC_THUE_GTGT.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_TKC_THUE_GTGT.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_TKC_THUE_GTGT.EditValue = ""
        Me.GFilter_TKC_THUE_GTGT.EditValues = ""
        Me.GFilter_TKC_THUE_GTGT.ENABLES = True
        Me.GFilter_TKC_THUE_GTGT.IsNotTextChanged = True
        Me.GFilter_TKC_THUE_GTGT.ListEditValue = CType(resources.GetObject("GFilter_TKC_THUE_GTGT.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.GFilter_TKC_THUE_GTGT.Location = New System.Drawing.Point(105, 34)
        Me.GFilter_TKC_THUE_GTGT.MessageWarning = "Giá trị không hợp lệ"
        Me.GFilter_TKC_THUE_GTGT.Name = "GFilter_TKC_THUE_GTGT"
        Me.GFilter_TKC_THUE_GTGT.NEXT_TAB = 0
        Me.GFilter_TKC_THUE_GTGT.Size = New System.Drawing.Size(105, 20)
        Me.GFilter_TKC_THUE_GTGT.TabIndex = 1
        '
        'UR_STATUS
        '
        Me.UR_STATUS.CheckStatus = True
        Me.UR_STATUS.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_STATUS.Location = New System.Drawing.Point(45, 87)
        Me.UR_STATUS.Name = "UR_STATUS"
        Me.UR_STATUS.Size = New System.Drawing.Size(314, 20)
        Me.UR_STATUS.TabIndex = 12
        ValueInfo2.Den_Ngay = Nothing
        ValueInfo2.ID_DM = Nothing
        ValueInfo2.Ky_Hieu = Nothing
        ValueInfo2.MA_DM = Nothing
        ValueInfo2.ParameterValue = Nothing
        ValueInfo2.Ten = Nothing
        ValueInfo2.Tu_Ngay = Nothing
        Me.UR_STATUS.Value_info = ValueInfo2
        '
        'txtSO_NGAY_THANH_TOAN
        '
        Me.txtSO_NGAY_THANH_TOAN.EnterMoveNextControl = True
        Me.txtSO_NGAY_THANH_TOAN.Location = New System.Drawing.Point(740, 86)
        Me.txtSO_NGAY_THANH_TOAN.Name = "txtSO_NGAY_THANH_TOAN"
        Me.txtSO_NGAY_THANH_TOAN.Properties.Mask.EditMask = "[0-9]{0,4}"
        Me.txtSO_NGAY_THANH_TOAN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSO_NGAY_THANH_TOAN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSO_NGAY_THANH_TOAN.Size = New System.Drawing.Size(40, 20)
        Me.txtSO_NGAY_THANH_TOAN.TabIndex = 11
        Me.txtSO_NGAY_THANH_TOAN.Visible = False
        '
        'txtTong
        '
        Me.txtTong.Enabled = False
        Me.txtTong.EnterMoveNextControl = True
        Me.txtTong.Location = New System.Drawing.Point(502, 87)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTong.Properties.Appearance.Options.UseFont = True
        Me.txtTong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTong.Properties.Mask.EditMask = "n0"
        Me.txtTong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTong.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTong.Properties.ReadOnly = True
        Me.txtTong.Size = New System.Drawing.Size(152, 20)
        Me.txtTong.TabIndex = 9
        '
        'txtTaiKhoanChietKhau
        '
        Me.txtTaiKhoanChietKhau.Enabled = False
        Me.txtTaiKhoanChietKhau.EnterMoveNextControl = True
        Me.txtTaiKhoanChietKhau.Location = New System.Drawing.Point(502, 61)
        Me.txtTaiKhoanChietKhau.Name = "txtTaiKhoanChietKhau"
        Me.txtTaiKhoanChietKhau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTaiKhoanChietKhau.Properties.Appearance.Options.UseFont = True
        Me.txtTaiKhoanChietKhau.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTaiKhoanChietKhau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTaiKhoanChietKhau.Properties.Mask.EditMask = "n0"
        Me.txtTaiKhoanChietKhau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTaiKhoanChietKhau.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTaiKhoanChietKhau.Properties.ReadOnly = True
        Me.txtTaiKhoanChietKhau.Size = New System.Drawing.Size(152, 20)
        Me.txtTaiKhoanChietKhau.TabIndex = 10
        '
        'txtTienThue
        '
        Me.txtTienThue.Enabled = False
        Me.txtTienThue.EnterMoveNextControl = True
        Me.txtTienThue.Location = New System.Drawing.Point(502, 35)
        Me.txtTienThue.Name = "txtTienThue"
        Me.txtTienThue.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTienThue.Properties.Appearance.Options.UseFont = True
        Me.txtTienThue.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienThue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienThue.Properties.Mask.EditMask = "n0"
        Me.txtTienThue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienThue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienThue.Properties.ReadOnly = True
        Me.txtTienThue.Size = New System.Drawing.Size(152, 20)
        Me.txtTienThue.TabIndex = 8
        '
        'txtTienHang
        '
        Me.txtTienHang.Enabled = False
        Me.txtTienHang.EnterMoveNextControl = True
        Me.txtTienHang.Location = New System.Drawing.Point(502, 9)
        Me.txtTienHang.Name = "txtTienHang"
        Me.txtTienHang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTienHang.Properties.Appearance.Options.UseFont = True
        Me.txtTienHang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienHang.Properties.Mask.EditMask = "n0"
        Me.txtTienHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienHang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienHang.Properties.ReadOnly = True
        Me.txtTienHang.Size = New System.Drawing.Size(152, 20)
        Me.txtTienHang.TabIndex = 6
        '
        'txtTienVon
        '
        Me.txtTienVon.EnterMoveNextControl = True
        Me.txtTienVon.Location = New System.Drawing.Point(105, 8)
        Me.txtTienVon.Name = "txtTienVon"
        Me.txtTienVon.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienVon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienVon.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienVon.Properties.ReadOnly = True
        Me.txtTienVon.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTienVon.Size = New System.Drawing.Size(152, 20)
        Me.txtTienVon.TabIndex = 0
        Me.txtTienVon.Visible = False
        '
        'labelControl26
        '
        Me.labelControl26.Location = New System.Drawing.Point(672, 90)
        Me.labelControl26.Name = "labelControl26"
        Me.labelControl26.Size = New System.Drawing.Size(56, 13)
        Me.labelControl26.TabIndex = 13
        Me.labelControl26.Text = "Hạn t.toán:"
        Me.labelControl26.Visible = False
        '
        'labelControl48
        '
        Me.labelControl48.Location = New System.Drawing.Point(438, 89)
        Me.labelControl48.Name = "labelControl48"
        Me.labelControl48.Size = New System.Drawing.Size(39, 13)
        Me.labelControl48.TabIndex = 5
        Me.labelControl48.Text = "Tổng TT"
        '
        'labelControl45
        '
        Me.labelControl45.Location = New System.Drawing.Point(405, 64)
        Me.labelControl45.Name = "labelControl45"
        Me.labelControl45.Size = New System.Drawing.Size(72, 13)
        Me.labelControl45.TabIndex = 5
        Me.labelControl45.Text = "Tiền chiết khấu"
        '
        'VuviecId
        '
        Me.VuviecId.Caption = "Vụ việc"
        Me.VuviecId.ColumnEdit = Me.cboVuViec
        Me.VuviecId.FieldName = "VuviecId"
        Me.VuviecId.Name = "VuviecId"
        Me.VuviecId.Visible = True
        Me.VuviecId.VisibleIndex = 13
        '
        'SoTienBan
        '
        Me.SoTienBan.AppearanceCell.Options.UseTextOptions = True
        Me.SoTienBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SoTienBan.Caption = "Thành tiền"
        Me.SoTienBan.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.SoTienBan.DisplayFormat.FormatString = "n"
        Me.SoTienBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienBan.FieldName = "SoTienBan"
        Me.SoTienBan.Name = "SoTienBan"
        Me.SoTienBan.OptionsColumn.ReadOnly = True
        Me.SoTienBan.Visible = True
        Me.SoTienBan.VisibleIndex = 9
        Me.SoTienBan.Width = 79
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'DonGiaBan
        '
        Me.DonGiaBan.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaBan.Caption = "Giá bán VND"
        Me.DonGiaBan.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.DonGiaBan.DisplayFormat.FormatString = "n2"
        Me.DonGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaBan.FieldName = "DonGiaBan"
        Me.DonGiaBan.Name = "DonGiaBan"
        Me.DonGiaBan.Visible = True
        Me.DonGiaBan.VisibleIndex = 8
        Me.DonGiaBan.Width = 81
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'SoLuong
        '
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.SoLuong.DisplayFormat.FormatString = "n2"
        Me.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 5
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'MaTknGiavon
        '
        Me.MaTknGiavon.Caption = "TK giá vốn"
        Me.MaTknGiavon.ColumnEdit = Me.GFilter_MA_TKN_GIAVON
        Me.MaTknGiavon.FieldName = "MaTknGiavon"
        Me.MaTknGiavon.Name = "MaTknGiavon"
        Me.MaTknGiavon.Visible = True
        Me.MaTknGiavon.VisibleIndex = 19
        Me.MaTknGiavon.Width = 86
        '
        'GFilter_MA_TKN_GIAVON
        '
        Me.GFilter_MA_TKN_GIAVON.AutoHeight = False
        Me.GFilter_MA_TKN_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilter_MA_TKN_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_MA_TKN_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_MA_TKN_GIAVON.C_DATA_SOURCE = Nothing
        Me.GFilter_MA_TKN_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_MA_TKN_GIAVON.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_MA_TKN_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_MA_TKN_GIAVON.C_IS_CHECK_OTHER = "="
        Me.GFilter_MA_TKN_GIAVON.C_IS_CHECK_STRING = "="
        Me.GFilter_MA_TKN_GIAVON.C_IS_CHI_TIET = ""
        Me.GFilter_MA_TKN_GIAVON.C_IS_FILTER_STRING = ""
        Me.GFilter_MA_TKN_GIAVON.C_IS_QUICKADD = False
        Me.GFilter_MA_TKN_GIAVON.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_MA_TKN_GIAVON.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_MA_TKN_GIAVON.Editors = Nothing
        Me.GFilter_MA_TKN_GIAVON.EditValues = ""
        Me.GFilter_MA_TKN_GIAVON.ListEditValues = CType(resources.GetObject("GFilter_MA_TKN_GIAVON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilter_MA_TKN_GIAVON.Name = "GFilter_MA_TKN_GIAVON"
        Me.GFilter_MA_TKN_GIAVON.NEXT_TAB = 0
        Me.GFilter_MA_TKN_GIAVON.OBJ_CONDITITION = Nothing
        '
        'MaTkcGiavon
        '
        Me.MaTkcGiavon.Caption = "TK kho"
        Me.MaTkcGiavon.ColumnEdit = Me.GFilter_MA_TKC_GIAVON
        Me.MaTkcGiavon.FieldName = "MaTkcGiavon"
        Me.MaTkcGiavon.Name = "MaTkcGiavon"
        Me.MaTkcGiavon.Visible = True
        Me.MaTkcGiavon.VisibleIndex = 18
        '
        'GFilter_MA_TKC_GIAVON
        '
        Me.GFilter_MA_TKC_GIAVON.AutoHeight = False
        Me.GFilter_MA_TKC_GIAVON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilter_MA_TKC_GIAVON.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_MA_TKC_GIAVON.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_MA_TKC_GIAVON.C_DATA_SOURCE = Nothing
        Me.GFilter_MA_TKC_GIAVON.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_MA_TKC_GIAVON.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_OTHER = "="
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHECK_STRING = "="
        Me.GFilter_MA_TKC_GIAVON.C_IS_CHI_TIET = ""
        Me.GFilter_MA_TKC_GIAVON.C_IS_FILTER_STRING = ""
        Me.GFilter_MA_TKC_GIAVON.C_IS_QUICKADD = False
        Me.GFilter_MA_TKC_GIAVON.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_MA_TKC_GIAVON.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_MA_TKC_GIAVON.Editors = Nothing
        Me.GFilter_MA_TKC_GIAVON.EditValues = ""
        Me.GFilter_MA_TKC_GIAVON.ListEditValues = CType(resources.GetObject("GFilter_MA_TKC_GIAVON.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilter_MA_TKC_GIAVON.Name = "GFilter_MA_TKC_GIAVON"
        Me.GFilter_MA_TKC_GIAVON.NEXT_TAB = 0
        Me.GFilter_MA_TKC_GIAVON.OBJ_CONDITITION = Nothing
        '
        'TonKho
        '
        Me.TonKho.Caption = "Tồn kho"
        Me.TonKho.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.TonKho.FieldName = "TonKho"
        Me.TonKho.Name = "TonKho"
        Me.TonKho.OptionsColumn.ReadOnly = True
        Me.TonKho.Visible = True
        Me.TonKho.VisibleIndex = 4
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'KhoXuatId
        '
        Me.KhoXuatId.Caption = "Mã kho"
        Me.KhoXuatId.ColumnEdit = Me.cboMaKho
        Me.KhoXuatId.FieldName = "KhoXuatId"
        Me.KhoXuatId.Name = "KhoXuatId"
        Me.KhoXuatId.Visible = True
        Me.KhoXuatId.VisibleIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navCTHG)
        Me.PanelControl2.Controls.Add(Me.btnSea)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Controls.Add(Me.btnCan)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnQui)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSav)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelControl2.Size = New System.Drawing.Size(996, 34)
        Me.PanelControl2.TabIndex = 0
        '
        'navCTHG
        '
        Me.navCTHG.Buttons.Append.Visible = False
        Me.navCTHG.Buttons.CancelEdit.Visible = False
        Me.navCTHG.Buttons.Edit.Visible = False
        Me.navCTHG.Buttons.EndEdit.Visible = False
        Me.navCTHG.Buttons.NextPage.Visible = False
        Me.navCTHG.Buttons.PrevPage.Visible = False
        Me.navCTHG.Buttons.Remove.Visible = False
        Me.navCTHG.Location = New System.Drawing.Point(0, 2)
        Me.navCTHG.Name = "navCTHG"
        Me.navCTHG.NavigatableControl = Me.grcLPN_Hnx
        Me.navCTHG.Size = New System.Drawing.Size(195, 30)
        Me.navCTHG.TabIndex = 34
        Me.navCTHG.Text = "ControlNavigator4"
        Me.navCTHG.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navCTHG.TextStringFormat = " {0} / {1}"
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(0, 0)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(194, 567)
        Me.grcLPN_Hnx.TabIndex = 3
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
        Me.grvLPX_Hnx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ghi, Me.CtSo, Me.NgayCt, Me.NgayGhi, Me.SoTien})
        Me.grvLPX_Hnx.GridControl = Me.grcLPN_Hnx
        Me.grvLPX_Hnx.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grvLPX_Hnx.Name = "grvLPX_Hnx"
        Me.grvLPX_Hnx.OptionsBehavior.Editable = False
        Me.grvLPX_Hnx.OptionsView.ColumnAutoWidth = False
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceEvenRow = True
        Me.grvLPX_Hnx.OptionsView.EnableAppearanceOddRow = True
        Me.grvLPX_Hnx.OptionsView.ShowGroupPanel = False
        '
        'Ghi
        '
        Me.Ghi.Caption = "Trạng thái"
        Me.Ghi.FieldName = "Ghi"
        Me.Ghi.Name = "Ghi"
        Me.Ghi.Visible = True
        Me.Ghi.VisibleIndex = 0
        '
        'CtSo
        '
        Me.CtSo.Caption = "Số chứng từ"
        Me.CtSo.FieldName = "CtSo"
        Me.CtSo.Name = "CtSo"
        Me.CtSo.Visible = True
        Me.CtSo.VisibleIndex = 1
        Me.CtSo.Width = 90
        '
        'NgayCt
        '
        Me.NgayCt.Caption = "Ngày CT"
        Me.NgayCt.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayCt.FieldName = "NgayCt"
        Me.NgayCt.Name = "NgayCt"
        Me.NgayCt.Visible = True
        Me.NgayCt.VisibleIndex = 2
        Me.NgayCt.Width = 100
        '
        'NgayGhi
        '
        Me.NgayGhi.Caption = "Ngày hạch toán"
        Me.NgayGhi.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.NgayGhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NgayGhi.FieldName = "NgayGhi"
        Me.NgayGhi.Name = "NgayGhi"
        Me.NgayGhi.Visible = True
        Me.NgayGhi.VisibleIndex = 3
        Me.NgayGhi.Width = 90
        '
        'SoTien
        '
        Me.SoTien.Caption = "Tổng tiền"
        Me.SoTien.DisplayFormat.FormatString = "n0"
        Me.SoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTien.FieldName = "SoTien"
        Me.SoTien.Name = "SoTien"
        Me.SoTien.Visible = True
        Me.SoTien.VisibleIndex = 4
        Me.SoTien.Width = 120
        '
        'btnSea
        '
        Me.btnSea.ImageIndex = 3
        Me.btnSea.Location = New System.Drawing.Point(551, 2)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(80, 30)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm kiếm"
        '
        'btnDel
        '
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(379, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "&Xóa bản ghi"
        '
        'btnCan
        '
        Me.btnCan.ImageIndex = 4
        Me.btnCan.Location = New System.Drawing.Point(637, 2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(80, 30)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "&Hủy"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(207, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnMod
        '
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(293, 2)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(80, 30)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Sửa"
        '
        'btnQui
        '
        Me.btnQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQui.ImageIndex = 8
        Me.btnQui.Location = New System.Drawing.Point(914, 2)
        Me.btnQui.Name = "btnQui"
        Me.btnQui.Size = New System.Drawing.Size(80, 30)
        Me.btnQui.TabIndex = 7
        Me.btnQui.Text = "&Quay ra"
        '
        'btnPri
        '
        Me.btnPri.ImageIndex = 2
        Me.btnPri.Location = New System.Drawing.Point(723, 2)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 6
        Me.btnPri.Text = "&In ctừ"
        '
        'btnSav
        '
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(465, 2)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(80, 30)
        Me.btnSav.TabIndex = 3
        Me.btnSav.Text = "&Lưu"
        '
        'GrcHoaDonBanHang
        '
        Me.GrcHoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Bottom
        GridLevelNode2.RelationName = "Level1"
        Me.GrcHoaDonBanHang.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GrcHoaDonBanHang.Location = New System.Drawing.Point(6, 23)
        Me.GrcHoaDonBanHang.MainView = Me.GrcHoaDonBanHang_View
        Me.GrcHoaDonBanHang.Name = "GrcHoaDonBanHang"
        Me.GrcHoaDonBanHang.Padding = New System.Windows.Forms.Padding(4)
        Me.GrcHoaDonBanHang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GFilterEdit_HANGHOA_ID, Me.GFilter_MA_TKC_GIABAN, Me.GFilter_MA_TKN_GIAVON, Me.GFilter_MA_TKC_GIAVON, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.cboDMthue})
        Me.GrcHoaDonBanHang.Size = New System.Drawing.Size(789, 232)
        Me.GrcHoaDonBanHang.TabIndex = 1
        Me.GrcHoaDonBanHang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrcHoaDonBanHang_View})
        '
        'GrcHoaDonBanHang_View
        '
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.Empty.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.EvenRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FixedLine.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupButton.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.GroupRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.HorzLine.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Appearance.OddRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GrcHoaDonBanHang_View.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.Preview.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.Preview.Options.UseFont = True
        Me.GrcHoaDonBanHang_View.Appearance.Preview.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.Row.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.Row.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GrcHoaDonBanHang_View.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GrcHoaDonBanHang_View.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GrcHoaDonBanHang_View.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GrcHoaDonBanHang_View.Appearance.VertLine.Options.UseBackColor = True
        Me.GrcHoaDonBanHang_View.Appearance.VertLine.Options.UseBorderColor = True
        Me.GrcHoaDonBanHang_View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.HanghoaId, Me.TenHanghoa, Me.TenDvt, Me.KhoXuatId, Me.TonKho, Me.SoLuong, Me.DonGiaBanNte, Me.SoTienBanNte, Me.DonGiaBan, Me.SoTienBan, Me.DonGiaVon, Me.GiaVon, Me.SoTienCk, Me.VuviecId, Me.ThueId, Me.TyLeThueGtgt, Me.SoTienThueGtgt, Me.MaTkcGiaban, Me.MaTkcGiavon, Me.MaTknGiavon, Me.IdDmPtqtCo, Me.IdDmTudo1Co, Me.IdDmTudo2Co, Me.IdDmTudo3Co, Me.IdDmTudo4Co, Me.IdDmTudo5Co, Me.IdDmPhongbanCo, Me.IdDmKhoanphiCo, Me.IdDmHopdongCo, Me.ThuTu})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseBorderColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.ThuTu
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = New Decimal(New Integer() {13, 0, 0, 0})
        Me.GrcHoaDonBanHang_View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GrcHoaDonBanHang_View.GridControl = Me.GrcHoaDonBanHang
        Me.GrcHoaDonBanHang_View.Name = "GrcHoaDonBanHang_View"
        Me.GrcHoaDonBanHang_View.OptionsNavigation.AutoFocusNewRow = True
        Me.GrcHoaDonBanHang_View.OptionsNavigation.EnterMoveNextColumn = True
        Me.GrcHoaDonBanHang_View.OptionsView.ColumnAutoWidth = False
        Me.GrcHoaDonBanHang_View.OptionsView.EnableAppearanceEvenRow = True
        Me.GrcHoaDonBanHang_View.OptionsView.EnableAppearanceOddRow = True
        Me.GrcHoaDonBanHang_View.OptionsView.ShowGroupPanel = False
        '
        'HanghoaId
        '
        Me.HanghoaId.Caption = "Mã hàng"
        Me.HanghoaId.ColumnEdit = Me.GFilterEdit_HANGHOA_ID
        Me.HanghoaId.FieldName = "KyHieuHanghoa"
        Me.HanghoaId.Name = "HanghoaId"
        Me.HanghoaId.Visible = True
        Me.HanghoaId.VisibleIndex = 0
        Me.HanghoaId.Width = 91
        '
        'GFilterEdit_HANGHOA_ID
        '
        Me.GFilterEdit_HANGHOA_ID.AutoHeight = False
        Me.GFilterEdit_HANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" & _
            "nDvt--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0"
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban"
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
        Me.TenHanghoa.Caption = "Tên hàng"
        Me.TenHanghoa.FieldName = "TenHanghoa"
        Me.TenHanghoa.Name = "TenHanghoa"
        Me.TenHanghoa.OptionsColumn.ReadOnly = True
        Me.TenHanghoa.Visible = True
        Me.TenHanghoa.VisibleIndex = 1
        Me.TenHanghoa.Width = 117
        '
        'TenDvt
        '
        Me.TenDvt.Caption = "ĐVT"
        Me.TenDvt.FieldName = "TenDvt"
        Me.TenDvt.Name = "TenDvt"
        Me.TenDvt.OptionsColumn.ReadOnly = True
        Me.TenDvt.Visible = True
        Me.TenDvt.VisibleIndex = 2
        Me.TenDvt.Width = 84
        '
        'DonGiaBanNte
        '
        Me.DonGiaBanNte.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaBanNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaBanNte.Caption = "Giá bán NTE"
        Me.DonGiaBanNte.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DonGiaBanNte.DisplayFormat.FormatString = "n"
        Me.DonGiaBanNte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaBanNte.FieldName = "DonGiaBanNte"
        Me.DonGiaBanNte.Name = "DonGiaBanNte"
        Me.DonGiaBanNte.Visible = True
        Me.DonGiaBanNte.VisibleIndex = 6
        Me.DonGiaBanNte.Width = 89
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
        'SoTienBanNte
        '
        Me.SoTienBanNte.AppearanceCell.Options.UseTextOptions = True
        Me.SoTienBanNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SoTienBanNte.Caption = "Thành tiền NTE"
        Me.SoTienBanNte.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.SoTienBanNte.DisplayFormat.FormatString = "n0"
        Me.SoTienBanNte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SoTienBanNte.FieldName = "SoTienBanNte"
        Me.SoTienBanNte.Name = "SoTienBanNte"
        Me.SoTienBanNte.OptionsColumn.ReadOnly = True
        Me.SoTienBanNte.Visible = True
        Me.SoTienBanNte.VisibleIndex = 7
        Me.SoTienBanNte.Width = 107
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'DonGiaVon
        '
        Me.DonGiaVon.Caption = "Giá vốn VND"
        Me.DonGiaVon.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.DonGiaVon.DisplayFormat.FormatString = "n2"
        Me.DonGiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaVon.FieldName = "DonGiaVon"
        Me.DonGiaVon.Name = "DonGiaVon"
        Me.DonGiaVon.Visible = True
        Me.DonGiaVon.VisibleIndex = 10
        Me.DonGiaVon.Width = 89
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GiaVon
        '
        Me.GiaVon.Caption = "Tiền vốn"
        Me.GiaVon.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GiaVon.DisplayFormat.FormatString = "n0"
        Me.GiaVon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GiaVon.FieldName = "GiaVon"
        Me.GiaVon.Name = "GiaVon"
        Me.GiaVon.OptionsColumn.ReadOnly = True
        Me.GiaVon.Visible = True
        Me.GiaVon.VisibleIndex = 11
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'SoTienCk
        '
        Me.SoTienCk.Caption = "Số tiền CK"
        Me.SoTienCk.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.SoTienCk.FieldName = "SoTienCk"
        Me.SoTienCk.Name = "SoTienCk"
        Me.SoTienCk.Visible = True
        Me.SoTienCk.VisibleIndex = 12
        Me.SoTienCk.Width = 120
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'ThueId
        '
        Me.ThueId.Caption = "Danh mục thuế"
        Me.ThueId.ColumnEdit = Me.cboDMthue
        Me.ThueId.FieldName = "ThueId"
        Me.ThueId.Name = "ThueId"
        Me.ThueId.Visible = True
        Me.ThueId.VisibleIndex = 14
        Me.ThueId.Width = 118
        '
        'cboDMthue
        '
        Me.cboDMthue.AutoHeight = False
        Me.cboDMthue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMthue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMthue.Name = "cboDMthue"
        '
        'TyLeThueGtgt
        '
        Me.TyLeThueGtgt.Caption = "% thuế GTGT"
        Me.TyLeThueGtgt.ColumnEdit = Me.RepositoryItemTextEdit11
        Me.TyLeThueGtgt.FieldName = "TyLeThueGtgt"
        Me.TyLeThueGtgt.Name = "TyLeThueGtgt"
        Me.TyLeThueGtgt.Visible = True
        Me.TyLeThueGtgt.VisibleIndex = 15
        Me.TyLeThueGtgt.Width = 100
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'SoTienThueGtgt
        '
        Me.SoTienThueGtgt.Caption = "Tiền thuế GTGT"
        Me.SoTienThueGtgt.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.SoTienThueGtgt.FieldName = "SoTienThueGtgt"
        Me.SoTienThueGtgt.Name = "SoTienThueGtgt"
        Me.SoTienThueGtgt.OptionsColumn.ReadOnly = True
        Me.SoTienThueGtgt.Visible = True
        Me.SoTienThueGtgt.VisibleIndex = 16
        Me.SoTienThueGtgt.Width = 150
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'MaTkcGiaban
        '
        Me.MaTkcGiaban.Caption = "TK doanh thu"
        Me.MaTkcGiaban.ColumnEdit = Me.GFilter_MA_TKC_GIABAN
        Me.MaTkcGiaban.FieldName = "MaTkcGiaban"
        Me.MaTkcGiaban.Name = "MaTkcGiaban"
        Me.MaTkcGiaban.Visible = True
        Me.MaTkcGiaban.VisibleIndex = 17
        Me.MaTkcGiaban.Width = 120
        '
        'GFilter_MA_TKC_GIABAN
        '
        Me.GFilter_MA_TKC_GIABAN.AutoHeight = False
        Me.GFilter_MA_TKC_GIABAN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilter_MA_TKC_GIABAN.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.GFilter_MA_TKC_GIABAN.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.GFilter_MA_TKC_GIABAN.C_DATA_SOURCE = Nothing
        Me.GFilter_MA_TKC_GIABAN.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.GFilter_MA_TKC_GIABAN.C_FORM_TITLE = "Chọn tài khoản"
        Me.GFilter_MA_TKC_GIABAN.C_IS_CHECK_NUMBER = "ChiTiet=1"
        Me.GFilter_MA_TKC_GIABAN.C_IS_CHECK_OTHER = "="
        Me.GFilter_MA_TKC_GIABAN.C_IS_CHECK_STRING = "="
        Me.GFilter_MA_TKC_GIABAN.C_IS_CHI_TIET = ""
        Me.GFilter_MA_TKC_GIABAN.C_IS_FILTER_STRING = ""
        Me.GFilter_MA_TKC_GIABAN.C_IS_QUICKADD = False
        Me.GFilter_MA_TKC_GIABAN.C_IS_SORT_ORDER_STRING = ""
        Me.GFilter_MA_TKC_GIABAN.C_KEY_NAME = "MaTaikhoan"
        Me.GFilter_MA_TKC_GIABAN.Editors = Nothing
        Me.GFilter_MA_TKC_GIABAN.EditValues = ""
        Me.GFilter_MA_TKC_GIABAN.ListEditValues = CType(resources.GetObject("GFilter_MA_TKC_GIABAN.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.GFilter_MA_TKC_GIABAN.Name = "GFilter_MA_TKC_GIABAN"
        Me.GFilter_MA_TKC_GIABAN.NEXT_TAB = 0
        Me.GFilter_MA_TKC_GIABAN.OBJ_CONDITITION = Nothing
        '
        'IdDmPtqtCo
        '
        Me.IdDmPtqtCo.Caption = "PTQT"
        Me.IdDmPtqtCo.ColumnEdit = Me.cboPTQT
        Me.IdDmPtqtCo.FieldName = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Name = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Visible = True
        Me.IdDmPtqtCo.VisibleIndex = 20
        '
        'IdDmTudo1Co
        '
        Me.IdDmTudo1Co.Caption = "DM tự do 1"
        Me.IdDmTudo1Co.ColumnEdit = Me.cboTudo1
        Me.IdDmTudo1Co.FieldName = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Name = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Visible = True
        Me.IdDmTudo1Co.VisibleIndex = 21
        Me.IdDmTudo1Co.Width = 92
        '
        'IdDmTudo2Co
        '
        Me.IdDmTudo2Co.Caption = "DM tự do 2"
        Me.IdDmTudo2Co.ColumnEdit = Me.cboTudo2
        Me.IdDmTudo2Co.FieldName = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Name = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Visible = True
        Me.IdDmTudo2Co.VisibleIndex = 22
        '
        'IdDmTudo3Co
        '
        Me.IdDmTudo3Co.Caption = "DM tự do 3"
        Me.IdDmTudo3Co.ColumnEdit = Me.cboTudo3
        Me.IdDmTudo3Co.FieldName = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Name = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Visible = True
        Me.IdDmTudo3Co.VisibleIndex = 23
        '
        'IdDmTudo4Co
        '
        Me.IdDmTudo4Co.Caption = "DM tự do 4"
        Me.IdDmTudo4Co.ColumnEdit = Me.cboTudo4
        Me.IdDmTudo4Co.FieldName = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Name = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Visible = True
        Me.IdDmTudo4Co.VisibleIndex = 24
        '
        'IdDmTudo5Co
        '
        Me.IdDmTudo5Co.Caption = "DM tự do 5"
        Me.IdDmTudo5Co.ColumnEdit = Me.cboTudo5
        Me.IdDmTudo5Co.FieldName = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Name = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Visible = True
        Me.IdDmTudo5Co.VisibleIndex = 25
        '
        'IdDmPhongbanCo
        '
        Me.IdDmPhongbanCo.Caption = "Phòng ban"
        Me.IdDmPhongbanCo.ColumnEdit = Me.cboPhongBan
        Me.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Name = "IdDmPhongbanCo"
        '
        'IdDmKhoanphiCo
        '
        Me.IdDmKhoanphiCo.Caption = "Khoản phí"
        Me.IdDmKhoanphiCo.ColumnEdit = Me.cboKhoanphi
        Me.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Visible = True
        Me.IdDmKhoanphiCo.VisibleIndex = 26
        '
        'IdDmHopdongCo
        '
        Me.IdDmHopdongCo.Caption = "Hợp đồng"
        Me.IdDmHopdongCo.ColumnEdit = Me.cboHopdong
        Me.IdDmHopdongCo.FieldName = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Name = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Visible = True
        Me.IdDmHopdongCo.VisibleIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.GrcHoaDonBanHang)
        Me.GroupControl1.Controls.Add(Me.checkEdit4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 188)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(801, 261)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Chi tiết hạch toán"
        '
        'LabelControl20
        '
        Me.LabelControl20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl20.Location = New System.Drawing.Point(451, 6)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl20.TabIndex = 27
        Me.LabelControl20.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'depCT_H_Nx
        '
        Me.depCT_H_Nx.ContainerControl = Me
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grcLPN_Hnx)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpSMQR)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 567)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 19
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.PanelControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(4, 570)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(1000, 38)
        Me.GroupControl3.TabIndex = 20
        Me.GroupControl3.Text = "GroupControl3"
        '
        'frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet"
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaikhoanno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaiKhoanKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaikhoandoanhthu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopdong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMQR.ResumeLayout(False)
        Me.grpSMQR.PerformLayout()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlPHONGBAN_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlID_LOAI_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SERI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.groupControl2.PerformLayout()
        CType(Me.txtSO_NGAY_THANH_TOAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaiKhoanChietKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienVon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_MA_TKC_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrcHoaDonBanHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrcHoaDonBanHang_View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_MA_TKC_GIABAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSMQR As DevExpress.XtraEditors.GroupControl
    Friend WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents checkEdit4 As DevExpress.XtraEditors.CheckEdit
    Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
    Private WithEvents ckeNhapTienThue As DevExpress.XtraEditors.CheckEdit
    Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents labelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl46 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents labelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl45 As DevExpress.XtraEditors.LabelControl
    Private WithEvents VUVIEC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SO_TIEN_BAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DON_GIA_BAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MA_TKN_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MA_TKC_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TON_KHO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents KHO_XUAT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQui As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GrcHoaDonBanHang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrcHoaDonBanHang_View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNGUOI_NHAN_NOP_TIEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTaiKhoanChietKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTienThue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTienHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTienVon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSO_SERI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grlID_LOAI_CT As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkNGOAI_TE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Private WithEvents dteNGAY_CT As DevExpress.XtraEditors.DateEdit
    Private WithEvents dteNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents depCT_H_Nx As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents grlPHONGBAN_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HANGHOA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMST_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MA_TKC_GIABAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_HOPDONG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTaikhoanno As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTaiKhoanKho As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMaKho As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMaHang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTaikhoandoanhthu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPTQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPhongBan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoanphi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboHopdong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TY_LE_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DON_GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSO_NGAY_THANH_TOAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navCTHG As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents UR_STATUS As Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT
    Friend WithEvents THU_TU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_BAN_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_BAN_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GFilter As Vns.Erp.Core.CustomFilter
    Friend WithEvents GFilterEdit_HANGHOA_ID As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_MA_TKC_GIABAN As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_MA_TKN_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_MA_TKC_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_TK As Vns.Erp.Core.CustomFilter
    Friend WithEvents GFilter_TKC_CK As Vns.Erp.Core.CustomFilter
    Friend WithEvents GFilter_TKC_THUE_GTGT As Vns.Erp.Core.CustomFilter
    Friend WithEvents GFilter_TKN_THUE_GTGT As Vns.Erp.Core.CustomFilter
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTY_GIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SO_TIEN_CK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GFilter_TKN_CK As Vns.Erp.Core.CustomFilter
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SO_CT_RP As Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ThuTu As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VuviecId As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SoTienBan As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DonGiaBan As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MaTknGiavon As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MaTkcGiavon As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TonKho As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents KhoXuatId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CtSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayGhi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HanghoaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenHanghoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenDvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGiaBanNte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienBanNte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DonGiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienCk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TyLeThueGtgt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTienThueGtgt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaTkcGiaban As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPtqtCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo1Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo2Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo3Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo4Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmTudo5Co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmPhongbanCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmKhoanphiCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDmHopdongCo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ghi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ThueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDMthue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
