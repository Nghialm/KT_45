<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDonDichVu_ChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDonDichVu_ChiTiet))
        Dim ValueInfo1 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.navWelding1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.GRC_CTHHDDV = New DevExpress.XtraGrid.GridControl()
        Me.GRV_CTHHDDV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGAY_CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_KY_HIEU_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grv1_TEN_KHANG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grcCT_Thue = New DevExpress.XtraEditors.GroupControl()
        Me.cFilterTaiKhoanThue = New Vns.Erp.Core.CustomFilter()
        Me.ucStatus = New Vns.Erp.Core.Accounting.VbAccountingGUI.Status_LoaiCT()
        Me.ckeNhapTienCK = New DevExpress.XtraEditors.CheckEdit()
        Me.abc = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeNhapTienThue = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txttienhangchuack = New DevExpress.XtraEditors.TextEdit()
        Me.txtphantramck = New DevExpress.XtraEditors.TextEdit()
        Me.txtSO_NGAY_THANH_TOAN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTongTien = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txttienthue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txttienhangck = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTienCK = New DevExpress.XtraEditors.TextEdit()
        Me.lblTongTienThue = New DevExpress.XtraEditors.LabelControl()
        Me.grlTaiKhoanThue = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblTkThue = New DevExpress.XtraEditors.LabelControl()
        Me.grpSMQR = New DevExpress.XtraEditors.GroupControl()
        Me.C_SoChungTu_RP = New Vns.Erp.Core.Accounting.VbAccountingGUI.C_SoChungTu()
        Me.cFilterTaiKhoan = New Vns.Erp.Core.CustomFilter()
        Me.cFilter = New Vns.Erp.Core.CustomFilter()
        Me.cboBPKD = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSO_HD1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSO_SERI_HD1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTY_GIA1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMST_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.daeNGAY_GHI = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.txtNGUOI_NHAN_NOP_TIEN = New DevExpress.XtraEditors.TextEdit()
        Me.txtDIA_CHI = New DevExpress.XtraEditors.TextEdit()
        Me.txtTEN_KHANG = New DevExpress.XtraEditors.TextEdit()
        Me.lblTaikhoan = New DevExpress.XtraEditors.LabelControl()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.grlLOAI_CT_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.daeNGAY_CT = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me._GridControl = New DevExpress.XtraGrid.GridControl()
        Me._GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MA_TK_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_CO = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TEN_TK_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MA_TK_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_NO = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TEN_TK_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEN_HH_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.NOI_DUNG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_LUONG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DON_GIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DON_GIA_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DOANH_THU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DOANH_THU_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TY_LE_CK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_CK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_CK_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_NTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ThueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMthue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TY_LE_THUE_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SO_TIEN_THUE_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MA_TK_NO_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_NO_GTGT = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.MA_TK_CO_GTGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MyRepositoryItem_MA_TK_CO_GTGT = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.TIEN_MG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MA_VUVIEC_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_KHANG_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDM_KHANG = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_PTQT_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPPQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_KHOANPHI_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoanPhi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_PHONGBAN_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPhongBan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_1_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_2_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_3_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_4_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ID_DM_TUDO_5_CO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDMTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.grlKhachHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNoiDung = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grlTaiKhoanCo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSoTien = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtSoTienNT = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grlHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlKhachHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grlTaiKhoanNo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTenTkNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboTaiKhoanNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTaiKhoanCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhachHangNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboKhachHangCo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbotkthue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GRC_CTHHDDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRV_CTHHDDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcCT_Thue.SuspendLayout()
        CType(Me.ckeNhapTienCK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.abc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttienhangchuack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtphantramck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_NGAY_THANH_TOAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttienthue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttienhangck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienCK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanThue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMQR.SuspendLayout()
        CType(Me.cboBPKD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_HD1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSO_SERI_HD1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_CO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_NO_GTGT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyRepositoryItem_MA_TK_CO_GTGT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDM_KHANG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPPQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlKhachHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTienNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlKhachHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlTaiKhoanNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTkNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaiKhoanNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTaiKhoanCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbotkthue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navWelding1)
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.btnModify)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnQuit)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(4, 578)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1000, 30)
        Me.PanelControl2.TabIndex = 3
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
        Me.navWelding1.NavigatableControl = Me.GRC_CTHHDDV
        Me.navWelding1.Size = New System.Drawing.Size(194, 30)
        Me.navWelding1.TabIndex = 18
        Me.navWelding1.Text = "ControlNavigator4"
        Me.navWelding1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navWelding1.TextStringFormat = " {0} / {1}"
        '
        'GRC_CTHHDDV
        '
        Me.GRC_CTHHDDV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRC_CTHHDDV.Location = New System.Drawing.Point(2, 22)
        Me.GRC_CTHHDDV.MainView = Me.GRV_CTHHDDV
        Me.GRC_CTHHDDV.Name = "GRC_CTHHDDV"
        Me.GRC_CTHHDDV.Size = New System.Drawing.Size(190, 550)
        Me.GRC_CTHHDDV.TabIndex = 0
        Me.GRC_CTHHDDV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRV_CTHHDDV})
        '
        'GRV_CTHHDDV
        '
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.Empty.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.OddRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.OddRow.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Appearance.OddRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GRV_CTHHDDV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.Preview.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.Preview.Options.UseFont = True
        Me.GRV_CTHHDDV.Appearance.Preview.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.Row.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.Row.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GRV_CTHHDDV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GRV_CTHHDDV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GRV_CTHHDDV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GRV_CTHHDDV.Appearance.VertLine.Options.UseBackColor = True
        Me.GRV_CTHHDDV.Appearance.VertLine.Options.UseBorderColor = True
        Me.GRV_CTHHDDV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GHI, Me.CT_SO, Me.NGAY_CT, Me.grv1_SO_TIEN, Me.grv1_KY_HIEU_KHANG, Me.grv1_TEN_KHANG})
        Me.GRV_CTHHDDV.GridControl = Me.GRC_CTHHDDV
        Me.GRV_CTHHDDV.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GRV_CTHHDDV.Name = "GRV_CTHHDDV"
        Me.GRV_CTHHDDV.OptionsBehavior.Editable = False
        Me.GRV_CTHHDDV.OptionsView.ColumnAutoWidth = False
        Me.GRV_CTHHDDV.OptionsView.EnableAppearanceEvenRow = True
        Me.GRV_CTHHDDV.OptionsView.EnableAppearanceOddRow = True
        Me.GRV_CTHHDDV.OptionsView.ShowGroupPanel = False
        '
        'GHI
        '
        Me.GHI.Caption = "Trạng thái"
        Me.GHI.FieldName = "Ghi"
        Me.GHI.Name = "GHI"
        Me.GHI.Visible = True
        Me.GHI.VisibleIndex = 0
        Me.GHI.Width = 69
        '
        'CT_SO
        '
        Me.CT_SO.AppearanceCell.Options.UseTextOptions = True
        Me.CT_SO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CT_SO.Caption = "Số chứng từ"
        Me.CT_SO.FieldName = "CtSo"
        Me.CT_SO.Name = "CT_SO"
        Me.CT_SO.OptionsColumn.FixedWidth = True
        Me.CT_SO.Visible = True
        Me.CT_SO.VisibleIndex = 1
        Me.CT_SO.Width = 87
        '
        'NGAY_CT
        '
        Me.NGAY_CT.Caption = "Ngày chứng từ"
        Me.NGAY_CT.FieldName = "NgayCt"
        Me.NGAY_CT.Name = "NGAY_CT"
        Me.NGAY_CT.OptionsColumn.FixedWidth = True
        Me.NGAY_CT.Visible = True
        Me.NGAY_CT.VisibleIndex = 2
        Me.NGAY_CT.Width = 100
        '
        'grv1_SO_TIEN
        '
        Me.grv1_SO_TIEN.Caption = "Số tiền"
        Me.grv1_SO_TIEN.DisplayFormat.FormatString = "n0"
        Me.grv1_SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grv1_SO_TIEN.FieldName = "SoTien"
        Me.grv1_SO_TIEN.Name = "grv1_SO_TIEN"
        Me.grv1_SO_TIEN.Visible = True
        Me.grv1_SO_TIEN.VisibleIndex = 3
        Me.grv1_SO_TIEN.Width = 100
        '
        'grv1_KY_HIEU_KHANG
        '
        Me.grv1_KY_HIEU_KHANG.Caption = "Mã khách hàng"
        Me.grv1_KY_HIEU_KHANG.FieldName = "KyHieuKhang"
        Me.grv1_KY_HIEU_KHANG.Name = "grv1_KY_HIEU_KHANG"
        Me.grv1_KY_HIEU_KHANG.Width = 104
        '
        'grv1_TEN_KHANG
        '
        Me.grv1_TEN_KHANG.Caption = "Tên khách hàng"
        Me.grv1_TEN_KHANG.FieldName = "TenKhang"
        Me.grv1_TEN_KHANG.Name = "grv1_TEN_KHANG"
        Me.grv1_TEN_KHANG.Width = 144
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ImageIndex = 0
        Me.btnSearch.Location = New System.Drawing.Point(544, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Tìm"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModify.ImageIndex = 4
        Me.btnModify.Location = New System.Drawing.Point(286, 0)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 30)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "&Sửa"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(200, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Thêm"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.Location = New System.Drawing.Point(372, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Xóa"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ImageIndex = 8
        Me.btnCancel.Location = New System.Drawing.Point(630, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Hủy"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.ImageIndex = 8
        Me.btnQuit.Location = New System.Drawing.Point(920, 0)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(80, 30)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quay ra"
        '
        'btnPri
        '
        Me.btnPri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPri.ImageIndex = 5
        Me.btnPri.Location = New System.Drawing.Point(716, 0)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(80, 30)
        Me.btnPri.TabIndex = 6
        Me.btnPri.Text = "&In ctừ"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(458, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Lưu"
        '
        'grcCT_Thue
        '
        Me.grcCT_Thue.Controls.Add(Me.cFilterTaiKhoanThue)
        Me.grcCT_Thue.Controls.Add(Me.ucStatus)
        Me.grcCT_Thue.Controls.Add(Me.ckeNhapTienCK)
        Me.grcCT_Thue.Controls.Add(Me.abc)
        Me.grcCT_Thue.Controls.Add(Me.ckeNhapTienThue)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl21)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl18)
        Me.grcCT_Thue.Controls.Add(Me.txttienhangchuack)
        Me.grcCT_Thue.Controls.Add(Me.txtphantramck)
        Me.grcCT_Thue.Controls.Add(Me.txtSO_NGAY_THANH_TOAN)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl27)
        Me.grcCT_Thue.Controls.Add(Me.txtTongTien)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl24)
        Me.grcCT_Thue.Controls.Add(Me.txttienthue)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl23)
        Me.grcCT_Thue.Controls.Add(Me.txttienhangck)
        Me.grcCT_Thue.Controls.Add(Me.LabelControl22)
        Me.grcCT_Thue.Controls.Add(Me.txtTienCK)
        Me.grcCT_Thue.Controls.Add(Me.lblTongTienThue)
        Me.grcCT_Thue.Controls.Add(Me.grlTaiKhoanThue)
        Me.grcCT_Thue.Controls.Add(Me.lblTkThue)
        Me.grcCT_Thue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grcCT_Thue.Location = New System.Drawing.Point(0, 465)
        Me.grcCT_Thue.Name = "grcCT_Thue"
        Me.grcCT_Thue.ShowCaption = False
        Me.grcCT_Thue.Size = New System.Drawing.Size(800, 109)
        Me.grcCT_Thue.TabIndex = 2
        Me.grcCT_Thue.Text = "Chi tiết...."
        '
        'cFilterTaiKhoanThue
        '
        Me.cFilterTaiKhoanThue.AllowNull = True
        Me.cFilterTaiKhoanThue.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.cFilterTaiKhoanThue.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.cFilterTaiKhoanThue.C_DATA_SOURCE = Nothing
        Me.cFilterTaiKhoanThue.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.cFilterTaiKhoanThue.C_FORM_TITLE = "Chọn tài khoản"
        Me.cFilterTaiKhoanThue.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.cFilterTaiKhoanThue.C_IS_CHECK_OTHER = ""
        Me.cFilterTaiKhoanThue.C_IS_CHECK_STRING = ""
        Me.cFilterTaiKhoanThue.C_IS_FILTER_STRING = ""
        Me.cFilterTaiKhoanThue.C_IS_QUICKADD = False
        Me.cFilterTaiKhoanThue.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterTaiKhoanThue.C_KEY_NAME = "MaTaikhoan"
        Me.cFilterTaiKhoanThue.EditValue = ""
        Me.cFilterTaiKhoanThue.EditValues = ""
        Me.cFilterTaiKhoanThue.ENABLES = False
        Me.cFilterTaiKhoanThue.IsNotTextChanged = True
        Me.cFilterTaiKhoanThue.ListEditValue = CType(resources.GetObject("cFilterTaiKhoanThue.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterTaiKhoanThue.Location = New System.Drawing.Point(109, 6)
        Me.cFilterTaiKhoanThue.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterTaiKhoanThue.Name = "cFilterTaiKhoanThue"
        Me.cFilterTaiKhoanThue.NEXT_TAB = 0
        Me.cFilterTaiKhoanThue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilterTaiKhoanThue.Size = New System.Drawing.Size(100, 20)
        Me.cFilterTaiKhoanThue.TabIndex = 1
        Me.cFilterTaiKhoanThue.TabStop = False
        '
        'ucStatus
        '
        Me.ucStatus.CheckStatus = True
        Me.ucStatus.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.ucStatus.Location = New System.Drawing.Point(40, 35)
        Me.ucStatus.Name = "ucStatus"
        Me.ucStatus.Size = New System.Drawing.Size(313, 20)
        Me.ucStatus.TabIndex = 3
        ValueInfo1.Den_Ngay = Nothing
        ValueInfo1.ID_DM = Nothing
        ValueInfo1.Ky_Hieu = Nothing
        ValueInfo1.MA_DM = Nothing
        ValueInfo1.ParameterValue = Nothing
        ValueInfo1.Ten = Nothing
        ValueInfo1.Tu_Ngay = Nothing
        Me.ucStatus.Value_info = ValueInfo1
        '
        'ckeNhapTienCK
        '
        Me.ckeNhapTienCK.Location = New System.Drawing.Point(667, 33)
        Me.ckeNhapTienCK.Name = "ckeNhapTienCK"
        Me.ckeNhapTienCK.Properties.Caption = "Nhập tiền chiết khấu"
        Me.ckeNhapTienCK.Size = New System.Drawing.Size(125, 19)
        Me.ckeNhapTienCK.TabIndex = 7
        '
        'abc
        '
        Me.abc.Enabled = False
        Me.abc.Location = New System.Drawing.Point(667, 80)
        Me.abc.Name = "abc"
        Me.abc.Properties.Caption = ""
        Me.abc.Size = New System.Drawing.Size(21, 19)
        Me.abc.TabIndex = 5015
        Me.abc.Visible = False
        '
        'ckeNhapTienThue
        '
        Me.ckeNhapTienThue.Location = New System.Drawing.Point(667, 58)
        Me.ckeNhapTienThue.Name = "ckeNhapTienThue"
        Me.ckeNhapTienThue.Properties.Caption = "Nhập tiền thuế"
        Me.ckeNhapTienThue.Size = New System.Drawing.Size(110, 19)
        Me.ckeNhapTienThue.TabIndex = 8
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(424, 10)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl21.TabIndex = 5014
        Me.LabelControl21.Text = "Tiền hàng "
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(67, 87)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl18.TabIndex = 5014
        Me.LabelControl18.Text = "% CK"
        Me.LabelControl18.Visible = False
        '
        'txttienhangchuack
        '
        Me.txttienhangchuack.EnterMoveNextControl = True
        Me.txttienhangchuack.Location = New System.Drawing.Point(483, 6)
        Me.txttienhangchuack.Name = "txttienhangchuack"
        Me.txttienhangchuack.Properties.Appearance.Options.UseTextOptions = True
        Me.txttienhangchuack.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttienhangchuack.Properties.Mask.EditMask = "n0"
        Me.txttienhangchuack.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttienhangchuack.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttienhangchuack.Properties.ReadOnly = True
        Me.txttienhangchuack.ShowToolTips = False
        Me.txttienhangchuack.Size = New System.Drawing.Size(152, 20)
        Me.txttienhangchuack.TabIndex = 2
        Me.txttienhangchuack.TabStop = False
        '
        'txtphantramck
        '
        Me.txtphantramck.EnterMoveNextControl = True
        Me.txtphantramck.Location = New System.Drawing.Point(100, 84)
        Me.txtphantramck.Name = "txtphantramck"
        Me.txtphantramck.Properties.Appearance.Options.UseTextOptions = True
        Me.txtphantramck.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtphantramck.Properties.Mask.EditMask = "n2"
        Me.txtphantramck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtphantramck.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtphantramck.Properties.ReadOnly = True
        Me.txtphantramck.ShowToolTips = False
        Me.txtphantramck.Size = New System.Drawing.Size(131, 20)
        Me.txtphantramck.TabIndex = 1
        Me.txtphantramck.TabStop = False
        Me.txtphantramck.Visible = False
        '
        'txtSO_NGAY_THANH_TOAN
        '
        Me.txtSO_NGAY_THANH_TOAN.EnterMoveNextControl = True
        Me.txtSO_NGAY_THANH_TOAN.Location = New System.Drawing.Point(730, 7)
        Me.txtSO_NGAY_THANH_TOAN.Name = "txtSO_NGAY_THANH_TOAN"
        Me.txtSO_NGAY_THANH_TOAN.Properties.AllowFocused = False
        Me.txtSO_NGAY_THANH_TOAN.Properties.Mask.EditMask = "[0-9]{0,4}"
        Me.txtSO_NGAY_THANH_TOAN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtSO_NGAY_THANH_TOAN.Properties.Mask.ShowPlaceHolders = False
        Me.txtSO_NGAY_THANH_TOAN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSO_NGAY_THANH_TOAN.ShowToolTips = False
        Me.txtSO_NGAY_THANH_TOAN.Size = New System.Drawing.Size(47, 20)
        Me.txtSO_NGAY_THANH_TOAN.TabIndex = 6
        Me.txtSO_NGAY_THANH_TOAN.Visible = False
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(670, 11)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl27.TabIndex = 63
        Me.LabelControl27.Text = "Hạn t.toán"
        Me.LabelControl27.Visible = False
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(483, 83)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Properties.AllowFocused = False
        Me.txtTongTien.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongTien.Properties.Mask.EditMask = "n0"
        Me.txtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTien.Properties.ReadOnly = True
        Me.txtTongTien.ShowToolTips = False
        Me.txtTongTien.Size = New System.Drawing.Size(152, 20)
        Me.txtTongTien.TabIndex = 5
        Me.txtTongTien.TabStop = False
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(435, 86)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl24.TabIndex = 63
        Me.LabelControl24.Text = "Tổng TT"
        '
        'txttienthue
        '
        Me.txttienthue.Location = New System.Drawing.Point(483, 57)
        Me.txttienthue.Name = "txttienthue"
        Me.txttienthue.Properties.AllowFocused = False
        Me.txttienthue.Properties.Appearance.Options.UseTextOptions = True
        Me.txttienthue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttienthue.Properties.Mask.EditMask = "n0"
        Me.txttienthue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttienthue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttienthue.Properties.ReadOnly = True
        Me.txttienthue.ShowToolTips = False
        Me.txttienthue.Size = New System.Drawing.Size(152, 20)
        Me.txttienthue.TabIndex = 4
        Me.txttienthue.TabStop = False
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(429, 60)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl23.TabIndex = 63
        Me.LabelControl23.Text = "Tiền thuế"
        '
        'txttienhangck
        '
        Me.txttienhangck.Location = New System.Drawing.Point(100, 60)
        Me.txttienhangck.Name = "txttienhangck"
        Me.txttienhangck.Properties.AllowFocused = False
        Me.txttienhangck.Properties.Appearance.Options.UseTextOptions = True
        Me.txttienhangck.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttienhangck.Properties.Mask.EditMask = "n0"
        Me.txttienhangck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttienhangck.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttienhangck.Properties.ReadOnly = True
        Me.txttienhangck.ShowToolTips = False
        Me.txttienhangck.Size = New System.Drawing.Size(131, 20)
        Me.txttienhangck.TabIndex = 0
        Me.txttienhangck.TabStop = False
        Me.txttienhangck.Visible = False
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(31, 67)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl22.TabIndex = 63
        Me.LabelControl22.Text = "Tiền hàng CK"
        Me.LabelControl22.Visible = False
        '
        'txtTienCK
        '
        Me.txtTienCK.Location = New System.Drawing.Point(483, 32)
        Me.txtTienCK.Name = "txtTienCK"
        Me.txtTienCK.Properties.AllowFocused = False
        Me.txtTienCK.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienCK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienCK.Properties.Mask.EditMask = "n0"
        Me.txtTienCK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienCK.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienCK.Properties.ReadOnly = True
        Me.txtTienCK.ShowToolTips = False
        Me.txtTienCK.Size = New System.Drawing.Size(152, 20)
        Me.txtTienCK.TabIndex = 3
        Me.txtTienCK.TabStop = False
        '
        'lblTongTienThue
        '
        Me.lblTongTienThue.Location = New System.Drawing.Point(438, 35)
        Me.lblTongTienThue.Name = "lblTongTienThue"
        Me.lblTongTienThue.Size = New System.Drawing.Size(36, 13)
        Me.lblTongTienThue.TabIndex = 63
        Me.lblTongTienThue.Text = "Tiền CK"
        '
        'grlTaiKhoanThue
        '
        Me.grlTaiKhoanThue.EnterMoveNextControl = True
        Me.grlTaiKhoanThue.Location = New System.Drawing.Point(237, 84)
        Me.grlTaiKhoanThue.Name = "grlTaiKhoanThue"
        Me.grlTaiKhoanThue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.grlTaiKhoanThue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlTaiKhoanThue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanThue.Properties.NullText = ""
        Me.grlTaiKhoanThue.Properties.View = Me.GridView8
        Me.grlTaiKhoanThue.Size = New System.Drawing.Size(69, 20)
        Me.grlTaiKhoanThue.TabIndex = 2
        Me.grlTaiKhoanThue.TabStop = False
        Me.grlTaiKhoanThue.Visible = False
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn14})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mã tài khoản"
        Me.GridColumn9.FieldName = "MaTaikhoan"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tên tài khoản"
        Me.GridColumn14.FieldName = "TenTaikhoan"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        '
        'lblTkThue
        '
        Me.lblTkThue.Location = New System.Drawing.Point(14, 10)
        Me.lblTkThue.Name = "lblTkThue"
        Me.lblTkThue.Size = New System.Drawing.Size(89, 13)
        Me.lblTkThue.TabIndex = 55
        Me.lblTkThue.Text = "TK đ/ư với TK thuế"
        '
        'grpSMQR
        '
        Me.grpSMQR.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grpSMQR.Appearance.BorderColor = System.Drawing.Color.White
        Me.grpSMQR.Appearance.Options.UseBackColor = True
        Me.grpSMQR.Appearance.Options.UseBorderColor = True
        Me.grpSMQR.Controls.Add(Me.C_SoChungTu_RP)
        Me.grpSMQR.Controls.Add(Me.cFilterTaiKhoan)
        Me.grpSMQR.Controls.Add(Me.cFilter)
        Me.grpSMQR.Controls.Add(Me.cboBPKD)
        Me.grpSMQR.Controls.Add(Me.LabelControl17)
        Me.grpSMQR.Controls.Add(Me.txtSO_HD1)
        Me.grpSMQR.Controls.Add(Me.LabelControl15)
        Me.grpSMQR.Controls.Add(Me.txtSO_SERI_HD1)
        Me.grpSMQR.Controls.Add(Me.LabelControl13)
        Me.grpSMQR.Controls.Add(Me.txtTY_GIA1)
        Me.grpSMQR.Controls.Add(Me.txtMST_KHANG)
        Me.grpSMQR.Controls.Add(Me.LabelControl9)
        Me.grpSMQR.Controls.Add(Me.LabelControl2)
        Me.grpSMQR.Controls.Add(Me.labelControl19)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_GHI)
        Me.grpSMQR.Controls.Add(Me.labelControl10)
        Me.grpSMQR.Controls.Add(Me.txtDIEN_GIAI)
        Me.grpSMQR.Controls.Add(Me.txtNGUOI_NHAN_NOP_TIEN)
        Me.grpSMQR.Controls.Add(Me.txtDIA_CHI)
        Me.grpSMQR.Controls.Add(Me.txtTEN_KHANG)
        Me.grpSMQR.Controls.Add(Me.lblTaikhoan)
        Me.grpSMQR.Controls.Add(Me.cboNgoaiTe)
        Me.grpSMQR.Controls.Add(Me.grlLOAI_CT_ID)
        Me.grpSMQR.Controls.Add(Me.daeNGAY_CT)
        Me.grpSMQR.Controls.Add(Me.labelControl16)
        Me.grpSMQR.Controls.Add(Me.labelControl11)
        Me.grpSMQR.Controls.Add(Me.labelControl12)
        Me.grpSMQR.Controls.Add(Me.labelControl20)
        Me.grpSMQR.Controls.Add(Me.LabelControl5)
        Me.grpSMQR.Controls.Add(Me.labelControl6)
        Me.grpSMQR.Controls.Add(Me.LabelControl1)
        Me.grpSMQR.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSMQR.Location = New System.Drawing.Point(0, 0)
        Me.grpSMQR.Name = "grpSMQR"
        Me.grpSMQR.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSMQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpSMQR.ShowCaption = False
        Me.grpSMQR.Size = New System.Drawing.Size(800, 137)
        Me.grpSMQR.TabIndex = 0
        Me.grpSMQR.Text = "Chi tiết...."
        '
        'C_SoChungTu_RP
        '
        Me.C_SoChungTu_RP.Enabled = False
        Me.C_SoChungTu_RP.HtLoaichungtuService = Nothing
        Me.C_SoChungTu_RP.Location = New System.Drawing.Point(60, 83)
        Me.C_SoChungTu_RP.Name = "C_SoChungTu_RP"
        Me.C_SoChungTu_RP.PREFIX = Nothing
        Me.C_SoChungTu_RP.Size = New System.Drawing.Size(100, 20)
        Me.C_SoChungTu_RP.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu_RP.TabIndex = 3
        '
        'cFilterTaiKhoan
        '
        Me.cFilterTaiKhoan.AllowNull = True
        Me.cFilterTaiKhoan.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.cFilterTaiKhoan.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.cFilterTaiKhoan.C_DATA_SOURCE = Nothing
        Me.cFilterTaiKhoan.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.cFilterTaiKhoan.C_FORM_TITLE = "Chọn tài khoản"
        Me.cFilterTaiKhoan.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.cFilterTaiKhoan.C_IS_CHECK_OTHER = ""
        Me.cFilterTaiKhoan.C_IS_CHECK_STRING = ""
        Me.cFilterTaiKhoan.C_IS_FILTER_STRING = ""
        Me.cFilterTaiKhoan.C_IS_QUICKADD = False
        Me.cFilterTaiKhoan.C_IS_SORT_ORDER_STRING = ""
        Me.cFilterTaiKhoan.C_KEY_NAME = "MaTaikhoan"
        Me.cFilterTaiKhoan.EditValue = ""
        Me.cFilterTaiKhoan.EditValues = ""
        Me.cFilterTaiKhoan.ENABLES = False
        Me.cFilterTaiKhoan.IsNotTextChanged = True
        Me.cFilterTaiKhoan.ListEditValue = CType(resources.GetObject("cFilterTaiKhoan.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilterTaiKhoan.Location = New System.Drawing.Point(60, 109)
        Me.cFilterTaiKhoan.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilterTaiKhoan.Name = "cFilterTaiKhoan"
        Me.cFilterTaiKhoan.NEXT_TAB = 0
        Me.cFilterTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilterTaiKhoan.Size = New System.Drawing.Size(140, 20)
        Me.cFilterTaiKhoan.TabIndex = 4
        Me.cFilterTaiKhoan.TabStop = False
        '
        'cFilter
        '
        Me.cFilter.AllowNull = True
        Me.cFilter.C_ARR_COLS_DISPLAY = "KyHieu-Mã KH-80-1;TenKhang-Tên KH-80-1;Id--0-0;MaKhang--0-0;MaSoThue--0-0;DiaChi-" & _
    "-0-0"
        Me.cFilter.C_ARR_COLS_RETURN = "Id;TenKhang;MaKhang;KyHieu;MaSoThue;DiaChi"
        Me.cFilter.C_DATA_SOURCE = Nothing
        Me.cFilter.C_FORM_DANHSACH = "frmDanhMucKhachHang_Danhsach"
        Me.cFilter.C_FORM_TITLE = "Chọn khách hàng"
        Me.cFilter.C_IS_CHECK_NUMBER = ""
        Me.cFilter.C_IS_CHECK_OTHER = ""
        Me.cFilter.C_IS_CHECK_STRING = ""
        Me.cFilter.C_IS_FILTER_STRING = ""
        Me.cFilter.C_IS_QUICKADD = True
        Me.cFilter.C_IS_SORT_ORDER_STRING = ""
        Me.cFilter.C_KEY_NAME = "KyHieu"
        Me.cFilter.EditValue = ""
        Me.cFilter.EditValues = ""
        Me.cFilter.ENABLES = False
        Me.cFilter.IsNotTextChanged = True
        Me.cFilter.ListEditValue = CType(resources.GetObject("cFilter.ListEditValue"), System.Collections.Generic.List(Of String))
        Me.cFilter.Location = New System.Drawing.Point(316, 4)
        Me.cFilter.MessageWarning = "Giá trị không hợp lệ"
        Me.cFilter.Name = "cFilter"
        Me.cFilter.NEXT_TAB = 0
        Me.cFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cFilter.Size = New System.Drawing.Size(125, 20)
        Me.cFilter.TabIndex = 5
        Me.cFilter.TabStop = False
        '
        'cboBPKD
        '
        Me.cboBPKD.EnterMoveNextControl = True
        Me.cboBPKD.Location = New System.Drawing.Point(717, 109)
        Me.cboBPKD.Name = "cboBPKD"
        Me.cboBPKD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBPKD.Properties.NullText = ""
        Me.cboBPKD.Size = New System.Drawing.Size(80, 20)
        Me.cboBPKD.TabIndex = 15
        Me.cboBPKD.Visible = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(677, 109)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl17.TabIndex = 5013
        Me.LabelControl17.Text = "BPKD"
        Me.LabelControl17.Visible = False
        '
        'txtSO_HD1
        '
        Me.txtSO_HD1.EnterMoveNextControl = True
        Me.txtSO_HD1.Location = New System.Drawing.Point(717, 83)
        Me.txtSO_HD1.Name = "txtSO_HD1"
        Me.txtSO_HD1.Properties.MaxLength = 32
        Me.txtSO_HD1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSO_HD1.ShowToolTips = False
        Me.txtSO_HD1.Size = New System.Drawing.Size(80, 20)
        Me.txtSO_HD1.TabIndex = 14
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(672, 86)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl15.TabIndex = 5013
        Me.LabelControl15.Text = "Số HĐ"
        '
        'txtSO_SERI_HD1
        '
        Me.txtSO_SERI_HD1.EnterMoveNextControl = True
        Me.txtSO_SERI_HD1.Location = New System.Drawing.Point(717, 56)
        Me.txtSO_SERI_HD1.Name = "txtSO_SERI_HD1"
        Me.txtSO_SERI_HD1.Properties.MaxLength = 64
        Me.txtSO_SERI_HD1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSO_SERI_HD1.ShowToolTips = False
        Me.txtSO_SERI_HD1.Size = New System.Drawing.Size(80, 20)
        Me.txtSO_SERI_HD1.TabIndex = 13
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(669, 59)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl13.TabIndex = 5009
        Me.LabelControl13.Text = "Số Seri"
        '
        'txtTY_GIA1
        '
        Me.txtTY_GIA1.EnterMoveNextControl = True
        Me.txtTY_GIA1.Location = New System.Drawing.Point(717, 30)
        Me.txtTY_GIA1.Name = "txtTY_GIA1"
        Me.txtTY_GIA1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTY_GIA1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTY_GIA1.Properties.Mask.EditMask = "n2"
        Me.txtTY_GIA1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTY_GIA1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTY_GIA1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTY_GIA1.Size = New System.Drawing.Size(80, 20)
        Me.txtTY_GIA1.TabIndex = 12
        '
        'txtMST_KHANG
        '
        Me.txtMST_KHANG.EditValue = ""
        Me.txtMST_KHANG.EnterMoveNextControl = True
        Me.txtMST_KHANG.Location = New System.Drawing.Point(478, 6)
        Me.txtMST_KHANG.Name = "txtMST_KHANG"
        Me.txtMST_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMST_KHANG.Size = New System.Drawing.Size(116, 20)
        Me.txtMST_KHANG.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(452, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl9.TabIndex = 5006
        Me.LabelControl9.Text = "MST"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(225, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 5002
        Me.LabelControl2.Text = "Tên khách hàng"
        '
        'labelControl19
        '
        Me.labelControl19.Location = New System.Drawing.Point(17, 85)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(28, 13)
        Me.labelControl19.TabIndex = 5001
        Me.labelControl19.Text = "Số CT"
        '
        'daeNGAY_GHI
        '
        Me.daeNGAY_GHI.EditValue = Nothing
        Me.daeNGAY_GHI.EnterMoveNextControl = True
        Me.daeNGAY_GHI.Location = New System.Drawing.Point(60, 57)
        Me.daeNGAY_GHI.Name = "daeNGAY_GHI"
        Me.daeNGAY_GHI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.daeNGAY_GHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_GHI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_GHI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_GHI.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_GHI.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_GHI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_GHI.Size = New System.Drawing.Size(100, 20)
        Me.daeNGAY_GHI.TabIndex = 2
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(4, 60)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(41, 13)
        Me.labelControl10.TabIndex = 57
        Me.labelControl10.Text = "Ngày HT"
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(316, 109)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(278, 20)
        Me.txtDIEN_GIAI.TabIndex = 10
        '
        'txtNGUOI_NHAN_NOP_TIEN
        '
        Me.txtNGUOI_NHAN_NOP_TIEN.EnterMoveNextControl = True
        Me.txtNGUOI_NHAN_NOP_TIEN.Location = New System.Drawing.Point(316, 83)
        Me.txtNGUOI_NHAN_NOP_TIEN.Name = "txtNGUOI_NHAN_NOP_TIEN"
        Me.txtNGUOI_NHAN_NOP_TIEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNGUOI_NHAN_NOP_TIEN.Size = New System.Drawing.Size(278, 20)
        Me.txtNGUOI_NHAN_NOP_TIEN.TabIndex = 9
        '
        'txtDIA_CHI
        '
        Me.txtDIA_CHI.EnterMoveNextControl = True
        Me.txtDIA_CHI.Location = New System.Drawing.Point(316, 56)
        Me.txtDIA_CHI.Name = "txtDIA_CHI"
        Me.txtDIA_CHI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIA_CHI.Size = New System.Drawing.Size(278, 20)
        Me.txtDIA_CHI.TabIndex = 8
        '
        'txtTEN_KHANG
        '
        Me.txtTEN_KHANG.EnterMoveNextControl = True
        Me.txtTEN_KHANG.Location = New System.Drawing.Point(316, 30)
        Me.txtTEN_KHANG.Name = "txtTEN_KHANG"
        Me.txtTEN_KHANG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTEN_KHANG.Size = New System.Drawing.Size(278, 20)
        Me.txtTEN_KHANG.TabIndex = 7
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.Location = New System.Drawing.Point(17, 112)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(12, 13)
        Me.lblTaikhoan.TabIndex = 53
        Me.lblTaikhoan.Text = "TK"
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(717, 4)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.ImmediatePopup = True
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.Size = New System.Drawing.Size(80, 20)
        Me.cboNgoaiTe.TabIndex = 11
        '
        'grlLOAI_CT_ID
        '
        Me.grlLOAI_CT_ID.EditValue = " "
        Me.grlLOAI_CT_ID.EnterMoveNextControl = True
        Me.grlLOAI_CT_ID.Location = New System.Drawing.Point(60, 4)
        Me.grlLOAI_CT_ID.Name = "grlLOAI_CT_ID"
        Me.grlLOAI_CT_ID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlLOAI_CT_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLOAI_CT_ID.Properties.ImmediatePopup = True
        Me.grlLOAI_CT_ID.Properties.NullText = ""
        Me.grlLOAI_CT_ID.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.grlLOAI_CT_ID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.grlLOAI_CT_ID.Properties.View = Me.GridLookUpEdit1View
        Me.grlLOAI_CT_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grlLOAI_CT_ID.Size = New System.Drawing.Size(100, 20)
        Me.grlLOAI_CT_ID.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ký hiệu"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên loại chứng từ"
        Me.GridColumn2.FieldName = "TenLoaiCt"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'daeNGAY_CT
        '
        Me.daeNGAY_CT.EditValue = Nothing
        Me.daeNGAY_CT.EnterMoveNextControl = True
        Me.daeNGAY_CT.Location = New System.Drawing.Point(60, 30)
        Me.daeNGAY_CT.Name = "daeNGAY_CT"
        Me.daeNGAY_CT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.daeNGAY_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.daeNGAY_CT.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.daeNGAY_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.daeNGAY_CT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.daeNGAY_CT.Properties.MaxValue = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.daeNGAY_CT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.daeNGAY_CT.Size = New System.Drawing.Size(100, 20)
        Me.daeNGAY_CT.TabIndex = 1
        '
        'labelControl16
        '
        Me.labelControl16.Location = New System.Drawing.Point(261, 112)
        Me.labelControl16.Name = "labelControl16"
        Me.labelControl16.Size = New System.Drawing.Size(40, 13)
        Me.labelControl16.TabIndex = 28
        Me.labelControl16.Text = "Diễn giải"
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(195, 85)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(106, 13)
        Me.labelControl11.TabIndex = 24
        Me.labelControl11.Text = "Người nhận/giao hàng"
        '
        'labelControl12
        '
        Me.labelControl12.Location = New System.Drawing.Point(269, 60)
        Me.labelControl12.Name = "labelControl12"
        Me.labelControl12.Size = New System.Drawing.Size(32, 13)
        Me.labelControl12.TabIndex = 22
        Me.labelControl12.Text = "Địa chỉ"
        '
        'labelControl20
        '
        Me.labelControl20.Location = New System.Drawing.Point(658, 32)
        Me.labelControl20.Name = "labelControl20"
        Me.labelControl20.Size = New System.Drawing.Size(44, 13)
        Me.labelControl20.TabIndex = 5
        Me.labelControl20.Text = "Tỷ giá TT"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(229, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Mã khách hàng"
        '
        'labelControl6
        '
        Me.labelControl6.Location = New System.Drawing.Point(4, 33)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(41, 13)
        Me.labelControl6.TabIndex = 1
        Me.labelControl6.Text = "Ngày CT"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Loại CT"
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.CausesValidation = False
        Me.GroupControl1.Controls.Add(Me._GridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 158)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(800, 307)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Danh sách..."
        '
        '_GridControl
        '
        Me._GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._GridControl.Location = New System.Drawing.Point(0, 0)
        Me._GridControl.MainView = Me._GridView
        Me._GridControl.Name = "_GridControl"
        Me._GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grlKhachHangNo, Me.txtNoiDung, Me.grlTaiKhoanCo, Me.txtSoTien, Me.txtSoTienNT, Me.grlHopDong, Me.grlVuViec, Me.grlKhachHangCo, Me.grlTaiKhoanNo, Me.txtTenTkNo, Me.cboTaiKhoanNo, Me.cboTaiKhoanCo, Me.cboHopDong, Me.cboVuViec, Me.cboKhachHangNo, Me.cboKhachHangCo, Me.cboPPQT, Me.cboPhongBan, Me.cboDMTudo1, Me.cboDMTudo2, Me.cboDMTudo3, Me.cboDMTudo4, Me.cboDMTudo5, Me.cboKhoanPhi, Me.cboDM_KHANG, Me.cbotkthue, Me.MyRepositoryItem_MA_TK_CO, Me.MyRepositoryItem_MA_TK_CO_GTGT, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit12, Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit14, Me.RepositoryItemTextEdit15, Me.RepositoryItemTextEdit16, Me.MyRepositoryItem_MA_TK_NO_GTGT, Me.MyRepositoryItem_MA_TK_NO, Me.cboDMthue})
        Me._GridControl.Size = New System.Drawing.Size(800, 307)
        Me._GridControl.TabIndex = 0
        Me._GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._GridView})
        '
        '_GridView
        '
        Me._GridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me._GridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me._GridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.Empty.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._GridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.EvenRow.Options.UseBackColor = True
        Me._GridView.Appearance.EvenRow.Options.UseBorderColor = True
        Me._GridView.Appearance.EvenRow.Options.UseForeColor = True
        Me._GridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me._GridView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me._GridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FilterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FilterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.FixedLine.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedCell.Options.UseForeColor = True
        Me._GridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me._GridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me._GridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me._GridView.Appearance.FocusedRow.Options.UseForeColor = True
        Me._GridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._GridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me._GridView.Appearance.GroupButton.Options.UseBackColor = True
        Me._GridView.Appearance.GroupButton.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupFooter.Options.UseBackColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupFooter.Options.UseForeColor = True
        Me._GridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupPanel.Options.UseBackColor = True
        Me._GridView.Appearance.GroupPanel.Options.UseForeColor = True
        Me._GridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me._GridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.GroupRow.Options.UseBackColor = True
        Me._GridView.Appearance.GroupRow.Options.UseBorderColor = True
        Me._GridView.Appearance.GroupRow.Options.UseForeColor = True
        Me._GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me._GridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me._GridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me._GridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me._GridView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me._GridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.HorzLine.Options.UseBackColor = True
        Me._GridView.Appearance.HorzLine.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.OddRow.Options.UseBackColor = True
        Me._GridView.Appearance.OddRow.Options.UseBorderColor = True
        Me._GridView.Appearance.OddRow.Options.UseForeColor = True
        Me._GridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me._GridView.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me._GridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me._GridView.Appearance.Preview.Options.UseBackColor = True
        Me._GridView.Appearance.Preview.Options.UseFont = True
        Me._GridView.Appearance.Preview.Options.UseForeColor = True
        Me._GridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.Row.Options.UseBackColor = True
        Me._GridView.Appearance.Row.Options.UseForeColor = True
        Me._GridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me._GridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me._GridView.Appearance.RowSeparator.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me._GridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me._GridView.Appearance.SelectedRow.Options.UseBackColor = True
        Me._GridView.Appearance.SelectedRow.Options.UseForeColor = True
        Me._GridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me._GridView.Appearance.TopNewRow.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me._GridView.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me._GridView.Appearance.VertLine.Options.UseBackColor = True
        Me._GridView.Appearance.VertLine.Options.UseBorderColor = True
        Me._GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MA_TK_CO, Me.TEN_TK_CO, Me.MA_TK_NO, Me.TEN_TK_NO, Me.TEN_HH_DV, Me.NOI_DUNG, Me.DVT, Me.SO_LUONG, Me.DON_GIA, Me.DON_GIA_NTE, Me.DOANH_THU, Me.DOANH_THU_NTE, Me.TY_LE_CK, Me.SO_TIEN_CK, Me.SO_TIEN_CK_NTE, Me.SO_TIEN_NTE, Me.SO_TIEN, Me.ThueId, Me.TY_LE_THUE_GTGT, Me.SO_TIEN_THUE_GTGT, Me.MA_TK_NO_GTGT, Me.MA_TK_CO_GTGT, Me.TIEN_MG, Me.MA_VUVIEC_CO, Me.ID_KHANG_CO, Me.ID_DM_PTQT_CO, Me.ID_DM_KHOANPHI_CO, Me.ID_DM_PHONGBAN_CO, Me.ID_DM_TUDO_1_CO, Me.ID_DM_TUDO_2_CO, Me.ID_DM_TUDO_3_CO, Me.ID_DM_TUDO_4_CO, Me.ID_DM_TUDO_5_CO})
        Me._GridView.GridControl = Me._GridControl
        Me._GridView.Name = "_GridView"
        Me._GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me._GridView.OptionsView.ColumnAutoWidth = False
        Me._GridView.OptionsView.ShowGroupPanel = False
        '
        'MA_TK_CO
        '
        Me.MA_TK_CO.Caption = "TK có"
        Me.MA_TK_CO.ColumnEdit = Me.MyRepositoryItem_MA_TK_CO
        Me.MA_TK_CO.FieldName = "MaTkCo"
        Me.MA_TK_CO.Name = "MA_TK_CO"
        Me.MA_TK_CO.Visible = True
        Me.MA_TK_CO.VisibleIndex = 0
        Me.MA_TK_CO.Width = 80
        '
        'MyRepositoryItem_MA_TK_CO
        '
        Me.MyRepositoryItem_MA_TK_CO.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_CO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_CO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_CO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_CO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_CO.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_MA_TK_CO.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_CO.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_CO.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_CO.EditValues = ""
        Me.MyRepositoryItem_MA_TK_CO.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_CO.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_CO.Name = "MyRepositoryItem_MA_TK_CO"
        Me.MyRepositoryItem_MA_TK_CO.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_CO.OBJ_CONDITITION = Nothing
        '
        'TEN_TK_CO
        '
        Me.TEN_TK_CO.Caption = "Tên TK có"
        Me.TEN_TK_CO.FieldName = "TenTkCo"
        Me.TEN_TK_CO.Name = "TEN_TK_CO"
        Me.TEN_TK_CO.OptionsColumn.ReadOnly = True
        Me.TEN_TK_CO.Visible = True
        Me.TEN_TK_CO.VisibleIndex = 1
        Me.TEN_TK_CO.Width = 200
        '
        'MA_TK_NO
        '
        Me.MA_TK_NO.Caption = "TK nợ"
        Me.MA_TK_NO.ColumnEdit = Me.MyRepositoryItem_MA_TK_NO
        Me.MA_TK_NO.FieldName = "MaTkNo"
        Me.MA_TK_NO.Name = "MA_TK_NO"
        Me.MA_TK_NO.Visible = True
        Me.MA_TK_NO.VisibleIndex = 2
        '
        'MyRepositoryItem_MA_TK_NO
        '
        Me.MyRepositoryItem_MA_TK_NO.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_NO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_NO.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_NO.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_NO.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_NO.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_MA_TK_NO.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_NO.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_NO.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_NO.EditValues = ""
        Me.MyRepositoryItem_MA_TK_NO.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_NO.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_NO.Name = "MyRepositoryItem_MA_TK_NO"
        Me.MyRepositoryItem_MA_TK_NO.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_NO.OBJ_CONDITITION = Nothing
        '
        'TEN_TK_NO
        '
        Me.TEN_TK_NO.Caption = "Tên TK nợ"
        Me.TEN_TK_NO.FieldName = "TenTkNo"
        Me.TEN_TK_NO.Name = "TEN_TK_NO"
        Me.TEN_TK_NO.Visible = True
        Me.TEN_TK_NO.VisibleIndex = 3
        Me.TEN_TK_NO.Width = 215
        '
        'TEN_HH_DV
        '
        Me.TEN_HH_DV.Caption = "Tên hh/dv"
        Me.TEN_HH_DV.ColumnEdit = Me.RepositoryItemTextEdit15
        Me.TEN_HH_DV.FieldName = "TenHhDv"
        Me.TEN_HH_DV.Name = "TEN_HH_DV"
        Me.TEN_HH_DV.Visible = True
        Me.TEN_HH_DV.VisibleIndex = 4
        Me.TEN_HH_DV.Width = 200
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.AutoHeight = False
        Me.RepositoryItemTextEdit15.MaxLength = 128
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
        '
        'NOI_DUNG
        '
        Me.NOI_DUNG.Caption = "Diễn giải"
        Me.NOI_DUNG.ColumnEdit = Me.RepositoryItemTextEdit14
        Me.NOI_DUNG.FieldName = "NoiDung"
        Me.NOI_DUNG.Name = "NOI_DUNG"
        Me.NOI_DUNG.Visible = True
        Me.NOI_DUNG.VisibleIndex = 5
        Me.NOI_DUNG.Width = 200
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.MaxLength = 250
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'DVT
        '
        Me.DVT.Caption = "ĐVT"
        Me.DVT.ColumnEdit = Me.RepositoryItemTextEdit16
        Me.DVT.FieldName = "Dvt"
        Me.DVT.Name = "DVT"
        Me.DVT.Visible = True
        Me.DVT.VisibleIndex = 6
        Me.DVT.Width = 82
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.AutoHeight = False
        Me.RepositoryItemTextEdit16.MaxLength = 60
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'SO_LUONG
        '
        Me.SO_LUONG.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_LUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_LUONG.Caption = "Số lượng"
        Me.SO_LUONG.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.SO_LUONG.FieldName = "SoLuong"
        Me.SO_LUONG.Name = "SO_LUONG"
        Me.SO_LUONG.Visible = True
        Me.SO_LUONG.VisibleIndex = 7
        Me.SO_LUONG.Width = 80
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'DON_GIA
        '
        Me.DON_GIA.AppearanceHeader.Options.UseTextOptions = True
        Me.DON_GIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DON_GIA.Caption = "Đơn giá"
        Me.DON_GIA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.DON_GIA.FieldName = "DonGia"
        Me.DON_GIA.Name = "DON_GIA"
        Me.DON_GIA.Visible = True
        Me.DON_GIA.VisibleIndex = 8
        Me.DON_GIA.Width = 100
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'DON_GIA_NTE
        '
        Me.DON_GIA_NTE.AppearanceHeader.Options.UseTextOptions = True
        Me.DON_GIA_NTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DON_GIA_NTE.Caption = "Đơn giá NT"
        Me.DON_GIA_NTE.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.DON_GIA_NTE.FieldName = "DonGiaNte"
        Me.DON_GIA_NTE.Name = "DON_GIA_NTE"
        Me.DON_GIA_NTE.Visible = True
        Me.DON_GIA_NTE.VisibleIndex = 9
        Me.DON_GIA_NTE.Width = 100
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'DOANH_THU
        '
        Me.DOANH_THU.AppearanceHeader.Options.UseTextOptions = True
        Me.DOANH_THU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DOANH_THU.Caption = "Doanh thu"
        Me.DOANH_THU.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.DOANH_THU.FieldName = "DoanhThu"
        Me.DOANH_THU.Name = "DOANH_THU"
        Me.DOANH_THU.Visible = True
        Me.DOANH_THU.VisibleIndex = 10
        Me.DOANH_THU.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'DOANH_THU_NTE
        '
        Me.DOANH_THU_NTE.AppearanceHeader.Options.UseTextOptions = True
        Me.DOANH_THU_NTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DOANH_THU_NTE.Caption = "Doanh thu NT"
        Me.DOANH_THU_NTE.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.DOANH_THU_NTE.FieldName = "DoanhThuNte"
        Me.DOANH_THU_NTE.Name = "DOANH_THU_NTE"
        Me.DOANH_THU_NTE.Visible = True
        Me.DOANH_THU_NTE.VisibleIndex = 11
        Me.DOANH_THU_NTE.Width = 100
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'TY_LE_CK
        '
        Me.TY_LE_CK.AppearanceHeader.Options.UseTextOptions = True
        Me.TY_LE_CK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TY_LE_CK.Caption = "% CK"
        Me.TY_LE_CK.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.TY_LE_CK.FieldName = "TyLeCk"
        Me.TY_LE_CK.Name = "TY_LE_CK"
        Me.TY_LE_CK.Visible = True
        Me.TY_LE_CK.VisibleIndex = 12
        Me.TY_LE_CK.Width = 50
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'SO_TIEN_CK
        '
        Me.SO_TIEN_CK.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_TIEN_CK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_TIEN_CK.Caption = "Số tiền CK"
        Me.SO_TIEN_CK.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.SO_TIEN_CK.FieldName = "SoTienCk"
        Me.SO_TIEN_CK.Name = "SO_TIEN_CK"
        Me.SO_TIEN_CK.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_CK.Visible = True
        Me.SO_TIEN_CK.VisibleIndex = 13
        Me.SO_TIEN_CK.Width = 100
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'SO_TIEN_CK_NTE
        '
        Me.SO_TIEN_CK_NTE.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_TIEN_CK_NTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_TIEN_CK_NTE.Caption = "Số tiền CK NT"
        Me.SO_TIEN_CK_NTE.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.SO_TIEN_CK_NTE.FieldName = "SoTienCkNte"
        Me.SO_TIEN_CK_NTE.Name = "SO_TIEN_CK_NTE"
        Me.SO_TIEN_CK_NTE.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_CK_NTE.Visible = True
        Me.SO_TIEN_CK_NTE.VisibleIndex = 14
        Me.SO_TIEN_CK_NTE.Width = 100
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'SO_TIEN_NTE
        '
        Me.SO_TIEN_NTE.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_TIEN_NTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_TIEN_NTE.Caption = "Thành tiền NT"
        Me.SO_TIEN_NTE.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.SO_TIEN_NTE.FieldName = "SoTienNte"
        Me.SO_TIEN_NTE.Name = "SO_TIEN_NTE"
        Me.SO_TIEN_NTE.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_NTE.Visible = True
        Me.SO_TIEN_NTE.VisibleIndex = 15
        Me.SO_TIEN_NTE.Width = 100
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'SO_TIEN
        '
        Me.SO_TIEN.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_TIEN.Caption = "Thành tiền"
        Me.SO_TIEN.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.SO_TIEN.FieldName = "SoTien"
        Me.SO_TIEN.Name = "SO_TIEN"
        Me.SO_TIEN.OptionsColumn.ReadOnly = True
        Me.SO_TIEN.Visible = True
        Me.SO_TIEN.VisibleIndex = 16
        Me.SO_TIEN.Width = 100
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'ThueId
        '
        Me.ThueId.Caption = "Danh mục thuế"
        Me.ThueId.ColumnEdit = Me.cboDMthue
        Me.ThueId.FieldName = "ThueId"
        Me.ThueId.Name = "ThueId"
        Me.ThueId.Visible = True
        Me.ThueId.VisibleIndex = 17
        Me.ThueId.Width = 101
        '
        'cboDMthue
        '
        Me.cboDMthue.AutoHeight = False
        Me.cboDMthue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMthue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMthue.Name = "cboDMthue"
        '
        'TY_LE_THUE_GTGT
        '
        Me.TY_LE_THUE_GTGT.AppearanceHeader.Options.UseTextOptions = True
        Me.TY_LE_THUE_GTGT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TY_LE_THUE_GTGT.Caption = "% thuế"
        Me.TY_LE_THUE_GTGT.ColumnEdit = Me.RepositoryItemTextEdit11
        Me.TY_LE_THUE_GTGT.FieldName = "TyLeThueGtgt"
        Me.TY_LE_THUE_GTGT.Name = "TY_LE_THUE_GTGT"
        Me.TY_LE_THUE_GTGT.Visible = True
        Me.TY_LE_THUE_GTGT.VisibleIndex = 18
        Me.TY_LE_THUE_GTGT.Width = 80
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'SO_TIEN_THUE_GTGT
        '
        Me.SO_TIEN_THUE_GTGT.AppearanceHeader.Options.UseTextOptions = True
        Me.SO_TIEN_THUE_GTGT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SO_TIEN_THUE_GTGT.Caption = "Tiền thuế"
        Me.SO_TIEN_THUE_GTGT.ColumnEdit = Me.RepositoryItemTextEdit12
        Me.SO_TIEN_THUE_GTGT.FieldName = "SoTienThueGtgt"
        Me.SO_TIEN_THUE_GTGT.Name = "SO_TIEN_THUE_GTGT"
        Me.SO_TIEN_THUE_GTGT.OptionsColumn.ReadOnly = True
        Me.SO_TIEN_THUE_GTGT.Visible = True
        Me.SO_TIEN_THUE_GTGT.VisibleIndex = 19
        Me.SO_TIEN_THUE_GTGT.Width = 100
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'MA_TK_NO_GTGT
        '
        Me.MA_TK_NO_GTGT.Caption = "TK thuế"
        Me.MA_TK_NO_GTGT.ColumnEdit = Me.MyRepositoryItem_MA_TK_NO_GTGT
        Me.MA_TK_NO_GTGT.FieldName = "MaTkNoGtgt"
        Me.MA_TK_NO_GTGT.Name = "MA_TK_NO_GTGT"
        Me.MA_TK_NO_GTGT.Visible = True
        Me.MA_TK_NO_GTGT.VisibleIndex = 20
        '
        'MyRepositoryItem_MA_TK_NO_GTGT
        '
        Me.MyRepositoryItem_MA_TK_NO_GTGT.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_NO_GTGT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_NO_GTGT.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_NO_GTGT.EditValues = ""
        Me.MyRepositoryItem_MA_TK_NO_GTGT.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_NO_GTGT.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_NO_GTGT.Name = "MyRepositoryItem_MA_TK_NO_GTGT"
        Me.MyRepositoryItem_MA_TK_NO_GTGT.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_NO_GTGT.OBJ_CONDITITION = Nothing
        '
        'MA_TK_CO_GTGT
        '
        Me.MA_TK_CO_GTGT.Caption = "TK thuế"
        Me.MA_TK_CO_GTGT.ColumnEdit = Me.MyRepositoryItem_MA_TK_CO_GTGT
        Me.MA_TK_CO_GTGT.FieldName = "MaTkCoGtgt"
        Me.MA_TK_CO_GTGT.Name = "MA_TK_CO_GTGT"
        Me.MA_TK_CO_GTGT.Visible = True
        Me.MA_TK_CO_GTGT.VisibleIndex = 21
        Me.MA_TK_CO_GTGT.Width = 80
        '
        'MyRepositoryItem_MA_TK_CO_GTGT
        '
        Me.MyRepositoryItem_MA_TK_CO_GTGT.AutoHeight = False
        Me.MyRepositoryItem_MA_TK_CO_GTGT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_ARR_COLS_DISPLAY = "MaTaikhoan-Ký hiệu-80-1;TenTaikhoan-Tên tài khoản-200-1;MoTa-Mô tả-120-1;Id--0-0"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_ARR_COLS_RETURN = "Id;MaTaikhoan;TenTaikhoan;MoTa"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_DATA_SOURCE = Nothing
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_FORM_DANHSACH = "frmDanhMucTaiKhoan_DanhSach"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_FORM_TITLE = "Chọn tài khoản"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_CHECK_NUMBER = "ChiTiet = 1"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_CHECK_OTHER = "="
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_CHECK_STRING = "="
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_CHI_TIET = ""
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_FILTER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_QUICKADD = False
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_IS_SORT_ORDER_STRING = ""
        Me.MyRepositoryItem_MA_TK_CO_GTGT.C_KEY_NAME = "MaTaikhoan"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.Editors = Nothing
        Me.MyRepositoryItem_MA_TK_CO_GTGT.EditValues = ""
        Me.MyRepositoryItem_MA_TK_CO_GTGT.ListEditValues = CType(resources.GetObject("MyRepositoryItem_MA_TK_CO_GTGT.ListEditValues"), System.Collections.Generic.List(Of String))
        Me.MyRepositoryItem_MA_TK_CO_GTGT.Name = "MyRepositoryItem_MA_TK_CO_GTGT"
        Me.MyRepositoryItem_MA_TK_CO_GTGT.NEXT_TAB = 0
        Me.MyRepositoryItem_MA_TK_CO_GTGT.OBJ_CONDITITION = Nothing
        '
        'TIEN_MG
        '
        Me.TIEN_MG.AppearanceHeader.Options.UseTextOptions = True
        Me.TIEN_MG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TIEN_MG.Caption = "Tiền MG"
        Me.TIEN_MG.ColumnEdit = Me.RepositoryItemTextEdit13
        Me.TIEN_MG.FieldName = "TienMg"
        Me.TIEN_MG.Name = "TIEN_MG"
        Me.TIEN_MG.Width = 100
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit13.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'MA_VUVIEC_CO
        '
        Me.MA_VUVIEC_CO.Caption = "Vụ việc"
        Me.MA_VUVIEC_CO.ColumnEdit = Me.cboVuViec
        Me.MA_VUVIEC_CO.FieldName = "IdDmVuviecCo"
        Me.MA_VUVIEC_CO.Name = "MA_VUVIEC_CO"
        Me.MA_VUVIEC_CO.Visible = True
        Me.MA_VUVIEC_CO.VisibleIndex = 22
        Me.MA_VUVIEC_CO.Width = 120
        '
        'cboVuViec
        '
        Me.cboVuViec.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'ID_KHANG_CO
        '
        Me.ID_KHANG_CO.Caption = "Khách hàng"
        Me.ID_KHANG_CO.ColumnEdit = Me.cboDM_KHANG
        Me.ID_KHANG_CO.FieldName = "IdKhangCo"
        Me.ID_KHANG_CO.Name = "ID_KHANG_CO"
        Me.ID_KHANG_CO.Visible = True
        Me.ID_KHANG_CO.VisibleIndex = 23
        Me.ID_KHANG_CO.Width = 120
        '
        'cboDM_KHANG
        '
        Me.cboDM_KHANG.AutoHeight = False
        Me.cboDM_KHANG.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDM_KHANG.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDM_KHANG.Name = "cboDM_KHANG"
        Me.cboDM_KHANG.NullText = ""
        '
        'ID_DM_PTQT_CO
        '
        Me.ID_DM_PTQT_CO.Caption = "Loại dòng tiền"
        Me.ID_DM_PTQT_CO.ColumnEdit = Me.cboPPQT
        Me.ID_DM_PTQT_CO.FieldName = "IdDmPtqtCo"
        Me.ID_DM_PTQT_CO.Name = "ID_DM_PTQT_CO"
        Me.ID_DM_PTQT_CO.Visible = True
        Me.ID_DM_PTQT_CO.VisibleIndex = 24
        Me.ID_DM_PTQT_CO.Width = 120
        '
        'cboPPQT
        '
        Me.cboPPQT.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPPQT.AutoHeight = False
        Me.cboPPQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPPQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPPQT.Name = "cboPPQT"
        Me.cboPPQT.NullText = ""
        '
        'ID_DM_KHOANPHI_CO
        '
        Me.ID_DM_KHOANPHI_CO.Caption = "Khoản phí"
        Me.ID_DM_KHOANPHI_CO.ColumnEdit = Me.cboKhoanPhi
        Me.ID_DM_KHOANPHI_CO.FieldName = "IdDmKhoanphiCo"
        Me.ID_DM_KHOANPHI_CO.Name = "ID_DM_KHOANPHI_CO"
        Me.ID_DM_KHOANPHI_CO.Visible = True
        Me.ID_DM_KHOANPHI_CO.VisibleIndex = 25
        Me.ID_DM_KHOANPHI_CO.Width = 120
        '
        'cboKhoanPhi
        '
        Me.cboKhoanPhi.AutoHeight = False
        Me.cboKhoanPhi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanPhi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanPhi.Name = "cboKhoanPhi"
        Me.cboKhoanPhi.NullText = ""
        '
        'ID_DM_PHONGBAN_CO
        '
        Me.ID_DM_PHONGBAN_CO.Caption = "Phòng ban"
        Me.ID_DM_PHONGBAN_CO.ColumnEdit = Me.cboPhongBan
        Me.ID_DM_PHONGBAN_CO.FieldName = "IdDmPhongbanCo"
        Me.ID_DM_PHONGBAN_CO.Name = "ID_DM_PHONGBAN_CO"
        Me.ID_DM_PHONGBAN_CO.Visible = True
        Me.ID_DM_PHONGBAN_CO.VisibleIndex = 26
        Me.ID_DM_PHONGBAN_CO.Width = 120
        '
        'cboPhongBan
        '
        Me.cboPhongBan.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPhongBan.AutoHeight = False
        Me.cboPhongBan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongBan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.NullText = ""
        '
        'ID_DM_TUDO_1_CO
        '
        Me.ID_DM_TUDO_1_CO.Caption = "Danh mục tự do 1"
        Me.ID_DM_TUDO_1_CO.ColumnEdit = Me.cboDMTudo1
        Me.ID_DM_TUDO_1_CO.FieldName = "IdDmTudo1Co"
        Me.ID_DM_TUDO_1_CO.Name = "ID_DM_TUDO_1_CO"
        Me.ID_DM_TUDO_1_CO.Visible = True
        Me.ID_DM_TUDO_1_CO.VisibleIndex = 27
        Me.ID_DM_TUDO_1_CO.Width = 120
        '
        'cboDMTudo1
        '
        Me.cboDMTudo1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo1.AutoHeight = False
        Me.cboDMTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo1.Name = "cboDMTudo1"
        Me.cboDMTudo1.NullText = ""
        '
        'ID_DM_TUDO_2_CO
        '
        Me.ID_DM_TUDO_2_CO.Caption = "Danh mục tự do 2"
        Me.ID_DM_TUDO_2_CO.ColumnEdit = Me.cboDMTudo2
        Me.ID_DM_TUDO_2_CO.FieldName = "IdDmTudo2Co"
        Me.ID_DM_TUDO_2_CO.Name = "ID_DM_TUDO_2_CO"
        Me.ID_DM_TUDO_2_CO.Visible = True
        Me.ID_DM_TUDO_2_CO.VisibleIndex = 28
        Me.ID_DM_TUDO_2_CO.Width = 120
        '
        'cboDMTudo2
        '
        Me.cboDMTudo2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo2.AutoHeight = False
        Me.cboDMTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo2.Name = "cboDMTudo2"
        Me.cboDMTudo2.NullText = ""
        '
        'ID_DM_TUDO_3_CO
        '
        Me.ID_DM_TUDO_3_CO.Caption = "Danh mục tự do 3"
        Me.ID_DM_TUDO_3_CO.ColumnEdit = Me.cboDMTudo3
        Me.ID_DM_TUDO_3_CO.FieldName = "IdDmTudo3Co"
        Me.ID_DM_TUDO_3_CO.Name = "ID_DM_TUDO_3_CO"
        Me.ID_DM_TUDO_3_CO.Visible = True
        Me.ID_DM_TUDO_3_CO.VisibleIndex = 29
        Me.ID_DM_TUDO_3_CO.Width = 120
        '
        'cboDMTudo3
        '
        Me.cboDMTudo3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo3.AutoHeight = False
        Me.cboDMTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo3.Name = "cboDMTudo3"
        Me.cboDMTudo3.NullText = ""
        '
        'ID_DM_TUDO_4_CO
        '
        Me.ID_DM_TUDO_4_CO.Caption = "Danh mục tự do 4"
        Me.ID_DM_TUDO_4_CO.ColumnEdit = Me.cboDMTudo4
        Me.ID_DM_TUDO_4_CO.FieldName = "IdDmTudo4Co"
        Me.ID_DM_TUDO_4_CO.Name = "ID_DM_TUDO_4_CO"
        Me.ID_DM_TUDO_4_CO.Visible = True
        Me.ID_DM_TUDO_4_CO.VisibleIndex = 30
        Me.ID_DM_TUDO_4_CO.Width = 120
        '
        'cboDMTudo4
        '
        Me.cboDMTudo4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo4.AutoHeight = False
        Me.cboDMTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo4.Name = "cboDMTudo4"
        Me.cboDMTudo4.NullText = ""
        '
        'ID_DM_TUDO_5_CO
        '
        Me.ID_DM_TUDO_5_CO.Caption = "Danh mục tự do 5"
        Me.ID_DM_TUDO_5_CO.ColumnEdit = Me.cboDMTudo5
        Me.ID_DM_TUDO_5_CO.FieldName = "IdDmTudo5Co"
        Me.ID_DM_TUDO_5_CO.Name = "ID_DM_TUDO_5_CO"
        Me.ID_DM_TUDO_5_CO.Visible = True
        Me.ID_DM_TUDO_5_CO.VisibleIndex = 31
        Me.ID_DM_TUDO_5_CO.Width = 120
        '
        'cboDMTudo5
        '
        Me.cboDMTudo5.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDMTudo5.AutoHeight = False
        Me.cboDMTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMTudo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMTudo5.Name = "cboDMTudo5"
        Me.cboDMTudo5.NullText = ""
        '
        'grlKhachHangNo
        '
        Me.grlKhachHangNo.AutoHeight = False
        Me.grlKhachHangNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlKhachHangNo.Name = "grlKhachHangNo"
        Me.grlKhachHangNo.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtNoiDung
        '
        Me.txtNoiDung.AutoHeight = False
        Me.txtNoiDung.Name = "txtNoiDung"
        '
        'grlTaiKhoanCo
        '
        Me.grlTaiKhoanCo.AutoHeight = False
        Me.grlTaiKhoanCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanCo.DisplayMember = "KyHieu"
        Me.grlTaiKhoanCo.Name = "grlTaiKhoanCo"
        Me.grlTaiKhoanCo.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'txtSoTien
        '
        Me.txtSoTien.AutoHeight = False
        Me.txtSoTien.Name = "txtSoTien"
        '
        'txtSoTienNT
        '
        Me.txtSoTienNT.AutoHeight = False
        Me.txtSoTienNT.Name = "txtSoTienNT"
        '
        'grlHopDong
        '
        Me.grlHopDong.AutoHeight = False
        Me.grlHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlHopDong.Name = "grlHopDong"
        Me.grlHopDong.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'grlVuViec
        '
        Me.grlVuViec.AutoHeight = False
        Me.grlVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlVuViec.Name = "grlVuViec"
        Me.grlVuViec.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'grlKhachHangCo
        '
        Me.grlKhachHangCo.AutoHeight = False
        Me.grlKhachHangCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlKhachHangCo.Name = "grlKhachHangCo"
        Me.grlKhachHangCo.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'grlTaiKhoanNo
        '
        Me.grlTaiKhoanNo.AutoHeight = False
        Me.grlTaiKhoanNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlTaiKhoanNo.Name = "grlTaiKhoanNo"
        Me.grlTaiKhoanNo.View = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'txtTenTkNo
        '
        Me.txtTenTkNo.AutoHeight = False
        Me.txtTenTkNo.Name = "txtTenTkNo"
        '
        'cboTaiKhoanNo
        '
        Me.cboTaiKhoanNo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaiKhoanNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaiKhoanNo.Name = "cboTaiKhoanNo"
        Me.cboTaiKhoanNo.NullText = ""
        '
        'cboTaiKhoanCo
        '
        Me.cboTaiKhoanCo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTaiKhoanCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTaiKhoanCo.Name = "cboTaiKhoanCo"
        Me.cboTaiKhoanCo.NullText = ""
        '
        'cboHopDong
        '
        Me.cboHopDong.AutoHeight = False
        Me.cboHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopDong.Name = "cboHopDong"
        '
        'cboKhachHangNo
        '
        Me.cboKhachHangNo.AutoHeight = False
        Me.cboKhachHangNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhachHangNo.Name = "cboKhachHangNo"
        '
        'cboKhachHangCo
        '
        Me.cboKhachHangCo.AutoHeight = False
        Me.cboKhachHangCo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhachHangCo.Name = "cboKhachHangCo"
        '
        'cbotkthue
        '
        Me.cbotkthue.AutoHeight = False
        Me.cbotkthue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cbotkthue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbotkthue.Name = "cbotkthue"
        Me.cbotkthue.NullText = ""
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grcCT_Thue)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpSMQR)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 574)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GRC_CTHHDDV)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(194, 574)
        Me.GroupControl2.TabIndex = 23
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 137)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(800, 21)
        Me.PanelControl1.TabIndex = 107
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Location = New System.Drawing.Point(455, 5)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(342, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'frmHoaDonDichVu_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "frmHoaDonDichVu_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Hóa đơn dịch vụ"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GRC_CTHHDDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRV_CTHHDDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcCT_Thue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcCT_Thue.ResumeLayout(False)
        Me.grcCT_Thue.PerformLayout()
        CType(Me.ckeNhapTienCK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.abc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeNhapTienThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttienhangchuack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtphantramck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_NGAY_THANH_TOAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttienthue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttienhangck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienCK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanThue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSMQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMQR.ResumeLayout(False)
        Me.grpSMQR.PerformLayout()
        CType(Me.cboBPKD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_HD1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSO_SERI_HD1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMST_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_GHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNGUOI_NHAN_NOP_TIEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIA_CHI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEN_KHANG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daeNGAY_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me._GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_CO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_NO_GTGT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyRepositoryItem_MA_TK_CO_GTGT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDM_KHANG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPPQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanPhi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlKhachHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTienNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlKhachHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlTaiKhoanNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTkNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaiKhoanNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTaiKhoanCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhachHangCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbotkthue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModify As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents grcCT_Thue As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTienCK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTongTienThue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grlTaiKhoanThue As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTkThue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSMQR As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTY_GIA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMST_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents daeNGAY_GHI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNGUOI_NHAN_NOP_TIEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDIA_CHI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTEN_KHANG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTaikhoan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grlLOAI_CT_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents daeNGAY_CT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents labelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSO_HD1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSO_SERI_HD1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboTaiKhoanNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboTaiKhoanCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDM_KHANG As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPPQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhoanPhi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboPhongBan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDMTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grlKhachHangNo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNoiDung As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grlTaiKhoanCo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSoTien As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtSoTienNT As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grlHopDong As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlVuViec As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlKhachHangCo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grlTaiKhoanNo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTenTkNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboHopDong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboKhachHangCo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttienhangchuack As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtphantramck As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongTien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttienthue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttienhangck As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeNhapTienThue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeNhapTienCK As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents abc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSO_NGAY_THANH_TOAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MA_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TK_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_HH_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOI_DUNG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOANH_THU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOANH_THU_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_CK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_CO_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIEN_MG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_KHANG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_CK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DON_GIA_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_CK_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbotkthue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ucStatus As Status_LoaiCT
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GRC_CTHHDDV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GRV_CTHHDDV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_KY_HIEU_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grv1_TEN_KHANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navWelding1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents cboBPKD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cFilter As CustomFilter
    Friend WithEvents cFilterTaiKhoan As CustomFilter
    Friend WithEvents MyRepositoryItem_MA_TK_CO As RepositoryItemPopupFilterEdit
    Friend WithEvents cFilterTaiKhoanThue As CustomFilter
    Friend WithEvents MyRepositoryItem_MA_TK_CO_GTGT As RepositoryItemPopupFilterEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SoChungTu_RP As C_SoChungTu
    Friend WithEvents MA_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEN_TK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MA_TK_NO_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MyRepositoryItem_MA_TK_NO_GTGT As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents MyRepositoryItem_MA_TK_NO As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents ThueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDMthue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
