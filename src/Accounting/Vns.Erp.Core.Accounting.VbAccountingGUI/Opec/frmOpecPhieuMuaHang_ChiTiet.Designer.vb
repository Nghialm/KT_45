Imports Vns.Erp.Core.Controls.UserControl

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpecPhieuMuaHang_ChiTiet
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
        Dim ValueInfo3 As Vns.Erp.Core.ValueInfo = New Vns.Erp.Core.ValueInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpecPhieuMuaHang_ChiTiet))
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPPThanhtoan = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMaTkCo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDmKhachHang = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSoHopDong = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.C_SoChungTu = New Vns.Erp.Core.Controls.UserControl.C_SoChungTu()
        Me.txtTY_GIA = New DevExpress.XtraEditors.TextEdit()
        Me.grlLOAI_CT_ID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.chkNhapKhau = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNgayCt = New DevExpress.XtraEditors.DateEdit()
        Me.cboNgoaiTe = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkNGOAI_TE = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDIEN_GIAI = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.UR_STATUS = New Vns.Erp.Core.Controls.UserControl.Status_LoaiCT()
        Me.txtTienHang = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl22 = New DevExpress.XtraEditors.LabelControl()
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
        Me.btnQui = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMod = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPri = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSav = New DevExpress.XtraEditors.SimpleButton()
        Me.depCT_H_Nx = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grcPhieuNhapKhau = New DevExpress.XtraGrid.GridControl()
        Me.grcPhieuNhapKhau_View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDmVuviec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HanghoaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDmHanghoa = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenDvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ViTri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KhoNhapId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMaKho = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SoLuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DonGiaVonNte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GiaVonNt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MaTknGiavon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFilter_MA_TKN_GIAVON = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.IdDmPtqtCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPTQT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo1Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo2Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo3Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo4Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmTudo5Co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTudo5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmPhongbanCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPhongban = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmKhoanphiCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKhoanphi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IdDmHopdongCo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboHopDong = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colEtaDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtETA = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEtdDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtETD = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colLsdDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtLSD = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colCang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboVuViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboTK_NO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMA_HANGHOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDMVuviec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboDanhMucThue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboMaKhach = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GFilterEdit_HANGHOA_ID = New Vns.Erp.Core.RepositoryItemPopupFilterEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboDMthue = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rcboDmVuviec = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.KyHieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.cboPPThanhtoan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaTkCo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDmKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoHopDong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNhapKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayCt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayCt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grcPhieuNhapKhau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcPhieuNhapKhau_View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDmHanghoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtETA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtETA.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtETD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtETD.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLSD.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTK_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMA_HANGHOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMVuviec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDanhMucThue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaKhach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcboDmVuviec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.LabelControl1)
        Me.groupControl1.Controls.Add(Me.cboPPThanhtoan)
        Me.groupControl1.Controls.Add(Me.cboMaTkCo)
        Me.groupControl1.Controls.Add(Me.LabelControl2)
        Me.groupControl1.Controls.Add(Me.cboDmKhachHang)
        Me.groupControl1.Controls.Add(Me.txtSoHopDong)
        Me.groupControl1.Controls.Add(Me.labelControl7)
        Me.groupControl1.Controls.Add(Me.C_SoChungTu)
        Me.groupControl1.Controls.Add(Me.txtTY_GIA)
        Me.groupControl1.Controls.Add(Me.grlLOAI_CT_ID)
        Me.groupControl1.Controls.Add(Me.LabelControl13)
        Me.groupControl1.Controls.Add(Me.chkNhapKhau)
        Me.groupControl1.Controls.Add(Me.txtNgayCt)
        Me.groupControl1.Controls.Add(Me.cboNgoaiTe)
        Me.groupControl1.Controls.Add(Me.chkNGOAI_TE)
        Me.groupControl1.Controls.Add(Me.LabelControl24)
        Me.groupControl1.Controls.Add(Me.txtDIEN_GIAI)
        Me.groupControl1.Controls.Add(Me.labelControl11)
        Me.groupControl1.Controls.Add(Me.labelControl10)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupControl1.Location = New System.Drawing.Point(0, 0)
        Me.groupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.groupControl1.ShowCaption = False
        Me.groupControl1.Size = New System.Drawing.Size(967, 146)
        Me.groupControl1.TabIndex = 0
        Me.groupControl1.Text = "Thông tin chính"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(282, 14)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl1.TabIndex = 5016
        Me.LabelControl1.Text = "PT thanh toán"
        '
        'cboPPThanhtoan
        '
        Me.cboPPThanhtoan.EnterMoveNextControl = True
        Me.cboPPThanhtoan.Location = New System.Drawing.Point(366, 11)
        Me.cboPPThanhtoan.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPPThanhtoan.Name = "cboPPThanhtoan"
        Me.cboPPThanhtoan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPPThanhtoan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPPThanhtoan.Properties.DisplayMember = "TenDanhmuc"
        Me.cboPPThanhtoan.Properties.NullText = ""
        Me.cboPPThanhtoan.Properties.ValueMember = "GiaTri"
        Me.cboPPThanhtoan.Properties.View = Me.GridView3
        Me.cboPPThanhtoan.Size = New System.Drawing.Size(337, 22)
        Me.cboPPThanhtoan.TabIndex = 3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tên"
        Me.GridColumn8.FieldName = "TenDanhmuc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'cboMaTkCo
        '
        Me.cboMaTkCo.EnterMoveNextControl = True
        Me.cboMaTkCo.Location = New System.Drawing.Point(445, 103)
        Me.cboMaTkCo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMaTkCo.Name = "cboMaTkCo"
        Me.cboMaTkCo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaTkCo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaTkCo.Properties.DisplayMember = "MaTaikhoan"
        Me.cboMaTkCo.Properties.NullText = ""
        Me.cboMaTkCo.Properties.ValueMember = "MaTaikhoan"
        Me.cboMaTkCo.Properties.View = Me.GridView1
        Me.cboMaTkCo.Size = New System.Drawing.Size(96, 22)
        Me.cboMaTkCo.TabIndex = 5014
        Me.cboMaTkCo.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Mã hợp đồng"
        Me.GridColumn4.FieldName = "KyHieu"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên hợp đồng"
        Me.GridColumn5.FieldName = "TenHopdong"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(283, 43)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl2.TabIndex = 5013
        Me.LabelControl2.Text = "Nhà cung cấp"
        '
        'cboDmKhachHang
        '
        Me.cboDmKhachHang.EnterMoveNextControl = True
        Me.cboDmKhachHang.Location = New System.Drawing.Point(367, 40)
        Me.cboDmKhachHang.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDmKhachHang.Name = "cboDmKhachHang"
        Me.cboDmKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDmKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDmKhachHang.Properties.DisplayMember = "NameDisplay"
        Me.cboDmKhachHang.Properties.NullText = ""
        Me.cboDmKhachHang.Properties.ValueMember = "Id"
        Me.cboDmKhachHang.Properties.View = Me.gridLookUpEdit1View
        Me.cboDmKhachHang.Size = New System.Drawing.Size(337, 22)
        Me.cboDmKhachHang.TabIndex = 4
        '
        'gridLookUpEdit1View
        '
        Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
        Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã nhà cung cấp"
        Me.GridColumn1.FieldName = "KyHieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên nhà cung cấp"
        Me.GridColumn2.FieldName = "TenKhang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'txtSoHopDong
        '
        Me.txtSoHopDong.EnterMoveNextControl = True
        Me.txtSoHopDong.Location = New System.Drawing.Point(101, 39)
        Me.txtSoHopDong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSoHopDong.Name = "txtSoHopDong"
        Me.txtSoHopDong.Properties.MaxLength = 128
        Me.txtSoHopDong.Size = New System.Drawing.Size(117, 22)
        Me.txtSoHopDong.TabIndex = 2
        '
        'labelControl7
        '
        Me.labelControl7.Location = New System.Drawing.Point(10, 42)
        Me.labelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(80, 17)
        Me.labelControl7.TabIndex = 5010
        Me.labelControl7.Text = "Số hợp đồng"
        '
        'C_SoChungTu
        '
        Me.C_SoChungTu.Enabled = False
        Me.C_SoChungTu.HtLoaichungtuService = Nothing
        Me.C_SoChungTu.Location = New System.Drawing.Point(803, 108)
        Me.C_SoChungTu.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.C_SoChungTu.Name = "C_SoChungTu"
        Me.C_SoChungTu.PREFIX = Nothing
        Me.C_SoChungTu.Size = New System.Drawing.Size(117, 25)
        Me.C_SoChungTu.SO_CHUNG_TU = Nothing
        Me.C_SoChungTu.TabIndex = 3
        Me.C_SoChungTu.Visible = False
        '
        'txtTY_GIA
        '
        Me.txtTY_GIA.EnterMoveNextControl = True
        Me.txtTY_GIA.Location = New System.Drawing.Point(802, 37)
        Me.txtTY_GIA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.txtTY_GIA.Size = New System.Drawing.Size(115, 22)
        Me.txtTY_GIA.TabIndex = 5008
        Me.txtTY_GIA.Visible = False
        '
        'grlLOAI_CT_ID
        '
        Me.grlLOAI_CT_ID.Enabled = False
        Me.grlLOAI_CT_ID.EnterMoveNextControl = True
        Me.grlLOAI_CT_ID.Location = New System.Drawing.Point(263, 103)
        Me.grlLOAI_CT_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grlLOAI_CT_ID.Name = "grlLOAI_CT_ID"
        Me.grlLOAI_CT_ID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.grlLOAI_CT_ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grlLOAI_CT_ID.Properties.NullText = ""
        Me.grlLOAI_CT_ID.Properties.View = Me.GridView6
        Me.grlLOAI_CT_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grlLOAI_CT_ID.Size = New System.Drawing.Size(117, 22)
        Me.grlLOAI_CT_ID.TabIndex = 0
        Me.grlLOAI_CT_ID.Visible = False
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Ký hiệu"
        Me.GridColumn15.FieldName = "KyHieu"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Tên loại chứng từ"
        Me.GridColumn16.FieldName = "TenLoaiCt"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(211, 104)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Text = "Loại CT"
        Me.LabelControl13.Visible = False
        '
        'chkNhapKhau
        '
        Me.chkNhapKhau.EditValue = True
        Me.chkNhapKhau.Location = New System.Drawing.Point(376, 244)
        Me.chkNhapKhau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNhapKhau.Name = "chkNhapKhau"
        Me.chkNhapKhau.Properties.Caption = "Nhập khẩu"
        Me.chkNhapKhau.Size = New System.Drawing.Size(84, 21)
        Me.chkNhapKhau.TabIndex = 10
        Me.chkNhapKhau.Visible = False
        '
        'txtNgayCt
        '
        Me.txtNgayCt.EditValue = Nothing
        Me.txtNgayCt.EnterMoveNextControl = True
        Me.txtNgayCt.Location = New System.Drawing.Point(101, 11)
        Me.txtNgayCt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNgayCt.Name = "txtNgayCt"
        Me.txtNgayCt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayCt.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayCt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayCt.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtNgayCt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtNgayCt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNgayCt.Properties.MaxValue = New Date(2088, 1, 5, 0, 0, 0, 0)
        Me.txtNgayCt.Properties.MinValue = New Date(1988, 1, 5, 0, 0, 0, 0)
        Me.txtNgayCt.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNgayCt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNgayCt.Size = New System.Drawing.Size(117, 22)
        Me.txtNgayCt.TabIndex = 1
        '
        'cboNgoaiTe
        '
        Me.cboNgoaiTe.EnterMoveNextControl = True
        Me.cboNgoaiTe.Location = New System.Drawing.Point(803, 7)
        Me.cboNgoaiTe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNgoaiTe.Name = "cboNgoaiTe"
        Me.cboNgoaiTe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNgoaiTe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KyHieu", "Ký hiệu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNte", "Tên ngoại tệ")})
        Me.cboNgoaiTe.Properties.NullText = ""
        Me.cboNgoaiTe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboNgoaiTe.Size = New System.Drawing.Size(115, 22)
        Me.cboNgoaiTe.TabIndex = 6
        '
        'chkNGOAI_TE
        '
        Me.chkNGOAI_TE.Location = New System.Drawing.Point(800, 71)
        Me.chkNGOAI_TE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNGOAI_TE.Name = "chkNGOAI_TE"
        Me.chkNGOAI_TE.Properties.Caption = "Ngoại tệ"
        Me.chkNGOAI_TE.Size = New System.Drawing.Size(82, 22)
        Me.chkNGOAI_TE.TabIndex = 14
        Me.chkNGOAI_TE.Visible = False
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(751, 10)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl24.TabIndex = 22
        Me.LabelControl24.Text = "Ngoại tệ"
        '
        'txtDIEN_GIAI
        '
        Me.txtDIEN_GIAI.EnterMoveNextControl = True
        Me.txtDIEN_GIAI.Location = New System.Drawing.Point(366, 70)
        Me.txtDIEN_GIAI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDIEN_GIAI.Name = "txtDIEN_GIAI"
        Me.txtDIEN_GIAI.Properties.MaxLength = 256
        Me.txtDIEN_GIAI.Size = New System.Drawing.Size(337, 22)
        Me.txtDIEN_GIAI.TabIndex = 5
        '
        'labelControl11
        '
        Me.labelControl11.Location = New System.Drawing.Point(751, 112)
        Me.labelControl11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(37, 17)
        Me.labelControl11.TabIndex = 1
        Me.labelControl11.Text = "Số CT"
        Me.labelControl11.Visible = False
        '
        'labelControl10
        '
        Me.labelControl10.Location = New System.Drawing.Point(34, 14)
        Me.labelControl10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(57, 16)
        Me.labelControl10.TabIndex = 13
        Me.labelControl10.Text = "Ngày mua"
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(397, 106)
        Me.labelControl5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(32, 16)
        Me.labelControl5.TabIndex = 9
        Me.labelControl5.Text = "TK có"
        Me.labelControl5.Visible = False
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(310, 72)
        Me.labelControl4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(50, 17)
        Me.labelControl4.TabIndex = 7
        Me.labelControl4.Text = "Diễn giải"
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.UR_STATUS)
        Me.groupControl2.Controls.Add(Me.txtTienHang)
        Me.groupControl2.Controls.Add(Me.labelControl22)
        Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupControl2.Location = New System.Drawing.Point(0, 647)
        Me.groupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.groupControl2.ShowCaption = False
        Me.groupControl2.Size = New System.Drawing.Size(967, 49)
        Me.groupControl2.TabIndex = 2
        Me.groupControl2.Text = "Thông tin tổng hợp"
        '
        'UR_STATUS
        '
        Me.UR_STATUS.CheckStatus = True
        Me.UR_STATUS.LCT_STATUS = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.UR_STATUS.Location = New System.Drawing.Point(43, 7)
        Me.UR_STATUS.Margin = New System.Windows.Forms.Padding(5)
        Me.UR_STATUS.Name = "UR_STATUS"
        Me.UR_STATUS.Size = New System.Drawing.Size(337, 25)
        Me.UR_STATUS.TabIndex = 6
        ValueInfo3.Den_Ngay = Nothing
        ValueInfo3.ID_DM = Nothing
        ValueInfo3.Ky_Hieu = Nothing
        ValueInfo3.MA_DM = Nothing
        ValueInfo3.ParameterValue = Nothing
        ValueInfo3.Ten = Nothing
        ValueInfo3.Tu_Ngay = Nothing
        Me.UR_STATUS.Value_info = ValueInfo3
        '
        'txtTienHang
        '
        Me.txtTienHang.Enabled = False
        Me.txtTienHang.EnterMoveNextControl = True
        Me.txtTienHang.Location = New System.Drawing.Point(764, 11)
        Me.txtTienHang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTienHang.Name = "txtTienHang"
        Me.txtTienHang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTienHang.Properties.Appearance.Options.UseFont = True
        Me.txtTienHang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienHang.Properties.Mask.EditMask = "n0"
        Me.txtTienHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienHang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienHang.Properties.ReadOnly = True
        Me.txtTienHang.Size = New System.Drawing.Size(175, 24)
        Me.txtTienHang.TabIndex = 10
        '
        'labelControl22
        '
        Me.labelControl22.Location = New System.Drawing.Point(687, 15)
        Me.labelControl22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.labelControl22.Name = "labelControl22"
        Me.labelControl22.Size = New System.Drawing.Size(60, 17)
        Me.labelControl22.TabIndex = 36
        Me.labelControl22.Text = "Tiền hàng"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.navCTHG)
        Me.PanelControl2.Controls.Add(Me.btnSea)
        Me.PanelControl2.Controls.Add(Me.btnDel)
        Me.PanelControl2.Controls.Add(Me.btnCan)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.btnQui)
        Me.PanelControl2.Controls.Add(Me.btnMod)
        Me.PanelControl2.Controls.Add(Me.btnPri)
        Me.PanelControl2.Controls.Add(Me.btnSav)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelControl2.Size = New System.Drawing.Size(1162, 43)
        Me.PanelControl2.TabIndex = 3
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
        Me.navCTHG.Location = New System.Drawing.Point(3, 4)
        Me.navCTHG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navCTHG.Name = "navCTHG"
        Me.navCTHG.NavigatableControl = Me.grcLPN_Hnx
        Me.navCTHG.Size = New System.Drawing.Size(216, 37)
        Me.navCTHG.TabIndex = 46
        Me.navCTHG.Text = "ControlNavigator4"
        Me.navCTHG.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navCTHG.TextStringFormat = " {0} / {1}"
        '
        'grcLPN_Hnx
        '
        Me.grcLPN_Hnx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcLPN_Hnx.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Location = New System.Drawing.Point(0, 0)
        Me.grcLPN_Hnx.MainView = Me.grvLPX_Hnx
        Me.grcLPN_Hnx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcLPN_Hnx.Name = "grcLPN_Hnx"
        Me.grcLPN_Hnx.Size = New System.Drawing.Size(194, 696)
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
        Me.btnSea.ImageIndex = 2
        Me.btnSea.Location = New System.Drawing.Point(632, 4)
        Me.btnSea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(93, 37)
        Me.btnSea.TabIndex = 4
        Me.btnSea.Text = "&Tìm kiếm"
        '
        'btnDel
        '
        Me.btnDel.ImageIndex = 3
        Me.btnDel.Location = New System.Drawing.Point(432, 4)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(93, 37)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "&Xóa bản ghi"
        '
        'btnCan
        '
        Me.btnCan.ImageIndex = 4
        Me.btnCan.Location = New System.Drawing.Point(733, 4)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(93, 37)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "&Hủy"
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 2
        Me.btnAdd.Location = New System.Drawing.Point(231, 4)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Mới"
        '
        'btnQui
        '
        Me.btnQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQui.ImageIndex = 8
        Me.btnQui.Location = New System.Drawing.Point(1069, 4)
        Me.btnQui.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQui.Name = "btnQui"
        Me.btnQui.Size = New System.Drawing.Size(93, 37)
        Me.btnQui.TabIndex = 7
        Me.btnQui.Text = "&Quay ra"
        '
        'btnMod
        '
        Me.btnMod.ImageIndex = 4
        Me.btnMod.Location = New System.Drawing.Point(331, 4)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(93, 37)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Sửa"
        '
        'btnPri
        '
        Me.btnPri.ImageIndex = 2
        Me.btnPri.Location = New System.Drawing.Point(833, 4)
        Me.btnPri.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(93, 37)
        Me.btnPri.TabIndex = 6
        Me.btnPri.Text = "&In ctừ"
        '
        'btnSav
        '
        Me.btnSav.ImageIndex = 0
        Me.btnSav.Location = New System.Drawing.Point(532, 4)
        Me.btnSav.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(93, 37)
        Me.btnSav.TabIndex = 2
        Me.btnSav.Text = "&Lưu"
        '
        'depCT_H_Nx
        '
        Me.depCT_H_Nx.ContainerControl = Me
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grcPhieuNhapKhau)
        Me.GroupControl3.Controls.Add(Me.LabelControl20)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 146)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(967, 501)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Chi tiết hạch toán"
        '
        'grcPhieuNhapKhau
        '
        Me.grcPhieuNhapKhau.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grcPhieuNhapKhau.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcPhieuNhapKhau.Location = New System.Drawing.Point(7, 33)
        Me.grcPhieuNhapKhau.MainView = Me.grcPhieuNhapKhau_View
        Me.grcPhieuNhapKhau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grcPhieuNhapKhau.Name = "grcPhieuNhapKhau"
        Me.grcPhieuNhapKhau.Padding = New System.Windows.Forms.Padding(5)
        Me.grcPhieuNhapKhau.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboVuViec, Me.cboTK_NO, Me.cboMA_HANGHOA, Me.cboMaKho, Me.cboPTQT, Me.cboTudo1, Me.cboTudo2, Me.cboTudo3, Me.cboTudo4, Me.cboTudo5, Me.cboPhongban, Me.cboDMVuviec, Me.cboKhoanphi, Me.cboHopDong, Me.cboDanhMucThue, Me.cboMaKhach, Me.GFilterEdit_HANGHOA_ID, Me.GFilter_MA_TKN_GIAVON, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.cboDMthue, Me.RepositoryItemTextEdit9, Me.rcboDmVuviec, Me.cboDmHanghoa, Me.cboCang, Me.txtETA, Me.txtLSD, Me.txtETD})
        Me.grcPhieuNhapKhau.Size = New System.Drawing.Size(953, 461)
        Me.grcPhieuNhapKhau.TabIndex = 1
        Me.grcPhieuNhapKhau.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grcPhieuNhapKhau_View})
        '
        'grcPhieuNhapKhau_View
        '
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.Empty.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.EvenRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FixedLine.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupButton.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.GroupRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.HorzLine.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Appearance.OddRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grcPhieuNhapKhau_View.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.Preview.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.Preview.Options.UseFont = True
        Me.grcPhieuNhapKhau_View.Appearance.Preview.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.Row.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.Row.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grcPhieuNhapKhau_View.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grcPhieuNhapKhau_View.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grcPhieuNhapKhau_View.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grcPhieuNhapKhau_View.Appearance.VertLine.Options.UseBackColor = True
        Me.grcPhieuNhapKhau_View.Appearance.VertLine.Options.UseBorderColor = True
        Me.grcPhieuNhapKhau_View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDmVuviec, Me.HanghoaId, Me.TenDvt, Me.ViTri, Me.KhoNhapId, Me.TonKho, Me.SoLuong, Me.DonGiaVon, Me.DonGiaVonNte, Me.GiaVon, Me.GiaVonNt, Me.MaTknGiavon, Me.IdDmPtqtCo, Me.IdDmTudo1Co, Me.IdDmTudo2Co, Me.IdDmTudo3Co, Me.IdDmTudo4Co, Me.IdDmTudo5Co, Me.IdDmPhongbanCo, Me.IdDmKhoanphiCo, Me.IdDmHopdongCo, Me.colEtaDate, Me.colEtdDate, Me.colLsdDate, Me.colCang})
        Me.grcPhieuNhapKhau_View.GridControl = Me.grcPhieuNhapKhau
        Me.grcPhieuNhapKhau_View.Name = "grcPhieuNhapKhau_View"
        Me.grcPhieuNhapKhau_View.OptionsNavigation.AutoFocusNewRow = True
        Me.grcPhieuNhapKhau_View.OptionsNavigation.EnterMoveNextColumn = True
        Me.grcPhieuNhapKhau_View.OptionsView.ColumnAutoWidth = False
        Me.grcPhieuNhapKhau_View.OptionsView.EnableAppearanceEvenRow = True
        Me.grcPhieuNhapKhau_View.OptionsView.EnableAppearanceOddRow = True
        Me.grcPhieuNhapKhau_View.OptionsView.ShowGroupPanel = False
        '
        'colDmVuviec
        '
        Me.colDmVuviec.Caption = "Code"
        Me.colDmVuviec.FieldName = "MaVuviec"
        Me.colDmVuviec.Name = "colDmVuviec"
        Me.colDmVuviec.Visible = True
        Me.colDmVuviec.VisibleIndex = 0
        Me.colDmVuviec.Width = 79
        '
        'HanghoaId
        '
        Me.HanghoaId.Caption = "Tên hàng"
        Me.HanghoaId.ColumnEdit = Me.cboDmHanghoa
        Me.HanghoaId.FieldName = "HanghoaId"
        Me.HanghoaId.Name = "HanghoaId"
        Me.HanghoaId.Visible = True
        Me.HanghoaId.VisibleIndex = 1
        Me.HanghoaId.Width = 420
        '
        'cboDmHanghoa
        '
        Me.cboDmHanghoa.AutoHeight = False
        Me.cboDmHanghoa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDmHanghoa.DisplayMember = "TenHienThi"
        Me.cboDmHanghoa.ImmediatePopup = True
        Me.cboDmHanghoa.Name = "cboDmHanghoa"
        Me.cboDmHanghoa.NullText = ""
        Me.cboDmHanghoa.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboDmHanghoa.PopupFormSize = New System.Drawing.Size(600, 0)
        Me.cboDmHanghoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboDmHanghoa.ValueMember = "Id"
        Me.cboDmHanghoa.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tên"
        Me.GridColumn7.FieldName = "TenHienThi"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 1531
        '
        'TenDvt
        '
        Me.TenDvt.Caption = "ĐVT"
        Me.TenDvt.FieldName = "TenDvt"
        Me.TenDvt.Name = "TenDvt"
        Me.TenDvt.OptionsColumn.ReadOnly = True
        '
        'ViTri
        '
        Me.ViTri.Caption = "Vị trí"
        Me.ViTri.FieldName = "ViTri"
        Me.ViTri.Name = "ViTri"
        '
        'KhoNhapId
        '
        Me.KhoNhapId.Caption = "Mã kho"
        Me.KhoNhapId.ColumnEdit = Me.cboMaKho
        Me.KhoNhapId.FieldName = "KhoNhapId"
        Me.KhoNhapId.Name = "KhoNhapId"
        '
        'cboMaKho
        '
        Me.cboMaKho.AutoHeight = False
        Me.cboMaKho.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaKho.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.NullText = ""
        '
        'TonKho
        '
        Me.TonKho.Caption = "Tồn kho"
        Me.TonKho.FieldName = "TonKho"
        Me.TonKho.Name = "TonKho"
        '
        'SoLuong
        '
        Me.SoLuong.Caption = "Số lượng"
        Me.SoLuong.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.SoLuong.FieldName = "SoLuong"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Visible = True
        Me.SoLuong.VisibleIndex = 2
        Me.SoLuong.Width = 100
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
        Me.DonGiaVon.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.DonGiaVon.FieldName = "DonGiaVon"
        Me.DonGiaVon.Name = "DonGiaVon"
        Me.DonGiaVon.Visible = True
        Me.DonGiaVon.VisibleIndex = 3
        Me.DonGiaVon.Width = 110
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'DonGiaVonNte
        '
        Me.DonGiaVonNte.AppearanceCell.Options.UseTextOptions = True
        Me.DonGiaVonNte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DonGiaVonNte.Caption = "Giá"
        Me.DonGiaVonNte.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.DonGiaVonNte.DisplayFormat.FormatString = "n"
        Me.DonGiaVonNte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DonGiaVonNte.FieldName = "DonGiaVonNte"
        Me.DonGiaVonNte.Name = "DonGiaVonNte"
        Me.DonGiaVonNte.Visible = True
        Me.DonGiaVonNte.VisibleIndex = 4
        Me.DonGiaVonNte.Width = 101
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GiaVon
        '
        Me.GiaVon.AppearanceCell.Options.UseTextOptions = True
        Me.GiaVon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GiaVon.Caption = "Tổng tiền"
        Me.GiaVon.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GiaVon.FieldName = "GiaVon"
        Me.GiaVon.Name = "GiaVon"
        Me.GiaVon.OptionsColumn.ReadOnly = True
        Me.GiaVon.Visible = True
        Me.GiaVon.VisibleIndex = 5
        Me.GiaVon.Width = 120
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GiaVonNt
        '
        Me.GiaVonNt.AppearanceCell.Options.UseTextOptions = True
        Me.GiaVonNt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GiaVonNt.Caption = "Tổng tiền"
        Me.GiaVonNt.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GiaVonNt.DisplayFormat.FormatString = "n"
        Me.GiaVonNt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GiaVonNt.FieldName = "GiaVonNt"
        Me.GiaVonNt.Name = "GiaVonNt"
        Me.GiaVonNt.OptionsColumn.ReadOnly = True
        Me.GiaVonNt.Visible = True
        Me.GiaVonNt.VisibleIndex = 6
        Me.GiaVonNt.Width = 120
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'MaTknGiavon
        '
        Me.MaTknGiavon.Caption = "TK kho"
        Me.MaTknGiavon.ColumnEdit = Me.GFilter_MA_TKN_GIAVON
        Me.MaTknGiavon.FieldName = "MaTknGiavon"
        Me.MaTknGiavon.Name = "MaTknGiavon"
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
        'IdDmPtqtCo
        '
        Me.IdDmPtqtCo.Caption = "PTQT"
        Me.IdDmPtqtCo.ColumnEdit = Me.cboPTQT
        Me.IdDmPtqtCo.FieldName = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Name = "IdDmPtqtCo"
        Me.IdDmPtqtCo.Visible = True
        Me.IdDmPtqtCo.VisibleIndex = 11
        '
        'cboPTQT
        '
        Me.cboPTQT.AutoHeight = False
        Me.cboPTQT.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPTQT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPTQT.Name = "cboPTQT"
        Me.cboPTQT.NullText = ""
        '
        'IdDmTudo1Co
        '
        Me.IdDmTudo1Co.Caption = "DM tự do 1"
        Me.IdDmTudo1Co.ColumnEdit = Me.cboTudo1
        Me.IdDmTudo1Co.FieldName = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Name = "IdDmTudo1Co"
        Me.IdDmTudo1Co.Visible = True
        Me.IdDmTudo1Co.VisibleIndex = 12
        '
        'cboTudo1
        '
        Me.cboTudo1.AutoHeight = False
        Me.cboTudo1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo1.Name = "cboTudo1"
        Me.cboTudo1.NullText = ""
        '
        'IdDmTudo2Co
        '
        Me.IdDmTudo2Co.Caption = "DM tự do 2"
        Me.IdDmTudo2Co.ColumnEdit = Me.cboTudo2
        Me.IdDmTudo2Co.FieldName = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Name = "IdDmTudo2Co"
        Me.IdDmTudo2Co.Visible = True
        Me.IdDmTudo2Co.VisibleIndex = 13
        '
        'cboTudo2
        '
        Me.cboTudo2.AutoHeight = False
        Me.cboTudo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo2.Name = "cboTudo2"
        Me.cboTudo2.NullText = ""
        '
        'IdDmTudo3Co
        '
        Me.IdDmTudo3Co.Caption = "DM tự do 3"
        Me.IdDmTudo3Co.ColumnEdit = Me.cboTudo3
        Me.IdDmTudo3Co.FieldName = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Name = "IdDmTudo3Co"
        Me.IdDmTudo3Co.Visible = True
        Me.IdDmTudo3Co.VisibleIndex = 14
        '
        'cboTudo3
        '
        Me.cboTudo3.AutoHeight = False
        Me.cboTudo3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo3.Name = "cboTudo3"
        Me.cboTudo3.NullText = ""
        '
        'IdDmTudo4Co
        '
        Me.IdDmTudo4Co.Caption = "DM tự do 4"
        Me.IdDmTudo4Co.ColumnEdit = Me.cboTudo4
        Me.IdDmTudo4Co.FieldName = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Name = "IdDmTudo4Co"
        Me.IdDmTudo4Co.Visible = True
        Me.IdDmTudo4Co.VisibleIndex = 15
        '
        'cboTudo4
        '
        Me.cboTudo4.AutoHeight = False
        Me.cboTudo4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo4.Name = "cboTudo4"
        Me.cboTudo4.NullText = ""
        '
        'IdDmTudo5Co
        '
        Me.IdDmTudo5Co.Caption = "DM tự do 5"
        Me.IdDmTudo5Co.ColumnEdit = Me.cboTudo5
        Me.IdDmTudo5Co.FieldName = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Name = "IdDmTudo5Co"
        Me.IdDmTudo5Co.Visible = True
        Me.IdDmTudo5Co.VisibleIndex = 16
        '
        'cboTudo5
        '
        Me.cboTudo5.AutoHeight = False
        Me.cboTudo5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTudo5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTudo5.Name = "cboTudo5"
        Me.cboTudo5.NullText = ""
        '
        'IdDmPhongbanCo
        '
        Me.IdDmPhongbanCo.Caption = "DM phòng ban"
        Me.IdDmPhongbanCo.ColumnEdit = Me.cboPhongban
        Me.IdDmPhongbanCo.FieldName = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Name = "IdDmPhongbanCo"
        Me.IdDmPhongbanCo.Visible = True
        Me.IdDmPhongbanCo.VisibleIndex = 17
        '
        'cboPhongban
        '
        Me.cboPhongban.AutoHeight = False
        Me.cboPhongban.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboPhongban.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPhongban.Name = "cboPhongban"
        Me.cboPhongban.NullText = ""
        '
        'IdDmKhoanphiCo
        '
        Me.IdDmKhoanphiCo.Caption = "DM khoản phí"
        Me.IdDmKhoanphiCo.ColumnEdit = Me.cboKhoanphi
        Me.IdDmKhoanphiCo.FieldName = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Name = "IdDmKhoanphiCo"
        Me.IdDmKhoanphiCo.Visible = True
        Me.IdDmKhoanphiCo.VisibleIndex = 18
        '
        'cboKhoanphi
        '
        Me.cboKhoanphi.AutoHeight = False
        Me.cboKhoanphi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboKhoanphi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKhoanphi.Name = "cboKhoanphi"
        Me.cboKhoanphi.NullText = ""
        '
        'IdDmHopdongCo
        '
        Me.IdDmHopdongCo.Caption = "DM hợp đồng"
        Me.IdDmHopdongCo.ColumnEdit = Me.cboHopDong
        Me.IdDmHopdongCo.FieldName = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Name = "IdDmHopdongCo"
        Me.IdDmHopdongCo.Visible = True
        Me.IdDmHopdongCo.VisibleIndex = 19
        '
        'cboHopDong
        '
        Me.cboHopDong.AutoHeight = False
        Me.cboHopDong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboHopDong.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHopDong.Name = "cboHopDong"
        Me.cboHopDong.NullText = ""
        '
        'colEtaDate
        '
        Me.colEtaDate.Caption = "ETA"
        Me.colEtaDate.ColumnEdit = Me.txtETA
        Me.colEtaDate.FieldName = "EtaDate"
        Me.colEtaDate.Name = "colEtaDate"
        Me.colEtaDate.Visible = True
        Me.colEtaDate.VisibleIndex = 7
        '
        'txtETA
        '
        Me.txtETA.AutoHeight = False
        Me.txtETA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtETA.Mask.EditMask = "dd/MM/yyyy"
        Me.txtETA.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtETA.Mask.UseMaskAsDisplayFormat = True
        Me.txtETA.Name = "txtETA"
        Me.txtETA.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEtdDate
        '
        Me.colEtdDate.Caption = "ETD"
        Me.colEtdDate.ColumnEdit = Me.txtETD
        Me.colEtdDate.FieldName = "EtdDate"
        Me.colEtdDate.Name = "colEtdDate"
        Me.colEtdDate.Visible = True
        Me.colEtdDate.VisibleIndex = 8
        '
        'txtETD
        '
        Me.txtETD.AutoHeight = False
        Me.txtETD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtETD.Mask.EditMask = "dd/MM/yyyy"
        Me.txtETD.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtETD.Mask.UseMaskAsDisplayFormat = True
        Me.txtETD.Name = "txtETD"
        Me.txtETD.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colLsdDate
        '
        Me.colLsdDate.Caption = "LSD"
        Me.colLsdDate.ColumnEdit = Me.txtLSD
        Me.colLsdDate.FieldName = "LsdDate"
        Me.colLsdDate.Name = "colLsdDate"
        Me.colLsdDate.Visible = True
        Me.colLsdDate.VisibleIndex = 9
        '
        'txtLSD
        '
        Me.txtLSD.AutoHeight = False
        Me.txtLSD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLSD.Mask.EditMask = "dd/MM/yyyy"
        Me.txtLSD.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.txtLSD.Mask.UseMaskAsDisplayFormat = True
        Me.txtLSD.Name = "txtLSD"
        Me.txtLSD.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colCang
        '
        Me.colCang.Caption = "Cảng"
        Me.colCang.ColumnEdit = Me.cboCang
        Me.colCang.FieldName = "Cang"
        Me.colCang.Name = "colCang"
        Me.colCang.Visible = True
        Me.colCang.VisibleIndex = 10
        '
        'cboCang
        '
        Me.cboCang.AutoHeight = False
        Me.cboCang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCang.DisplayMember = "TenDanhmuc"
        Me.cboCang.Name = "cboCang"
        Me.cboCang.ValueMember = "GiaTri"
        '
        'cboVuViec
        '
        Me.cboVuViec.AutoHeight = False
        Me.cboVuViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboVuViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVuViec.Name = "cboVuViec"
        Me.cboVuViec.NullText = ""
        '
        'cboTK_NO
        '
        Me.cboTK_NO.AutoHeight = False
        Me.cboTK_NO.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTK_NO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTK_NO.Name = "cboTK_NO"
        Me.cboTK_NO.NullText = ""
        '
        'cboMA_HANGHOA
        '
        Me.cboMA_HANGHOA.AutoHeight = False
        Me.cboMA_HANGHOA.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMA_HANGHOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMA_HANGHOA.Name = "cboMA_HANGHOA"
        Me.cboMA_HANGHOA.NullText = ""
        '
        'cboDMVuviec
        '
        Me.cboDMVuviec.AutoHeight = False
        Me.cboDMVuviec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMVuviec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMVuviec.Name = "cboDMVuviec"
        Me.cboDMVuviec.NullText = ""
        '
        'cboDanhMucThue
        '
        Me.cboDanhMucThue.AutoHeight = False
        Me.cboDanhMucThue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDanhMucThue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDanhMucThue.Name = "cboDanhMucThue"
        Me.cboDanhMucThue.NullText = ""
        '
        'cboMaKhach
        '
        Me.cboMaKhach.AutoHeight = False
        Me.cboMaKhach.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMaKhach.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaKhach.Name = "cboMaKhach"
        Me.cboMaKhach.NullText = ""
        '
        'GFilterEdit_HANGHOA_ID
        '
        Me.GFilterEdit_HANGHOA_ID.AutoHeight = False
        Me.GFilterEdit_HANGHOA_ID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_DISPLAY = "KyHieu-Mã hàng hóa-80-1;TenHanghoa-Tên hàng hóa-200-1;Id--80-0;MaHanghoa--80-0;Te" &
    "nDvt--80-0;MdTkKho--80-0;MdTkGiavon--80-0;MdTkGiaban--80-0;ViTri--80-0"
        Me.GFilterEdit_HANGHOA_ID.C_ARR_COLS_RETURN = "Id;KyHieu;TenHanghoa;MaHanghoa;TenDvt;MdTkKho;MdTkGiavon;MdTkGiaban;ViTri"
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
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'cboDMthue
        '
        Me.cboDMthue.AutoHeight = False
        Me.cboDMthue.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboDMthue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDMthue.Name = "cboDMthue"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'rcboDmVuviec
        '
        Me.rcboDmVuviec.AutoHeight = False
        Me.rcboDmVuviec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcboDmVuviec.DisplayMember = "KyHieu"
        Me.rcboDmVuviec.Name = "rcboDmVuviec"
        Me.rcboDmVuviec.ValueMember = "Id"
        Me.rcboDmVuviec.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KyHieu, Me.GridColumn3})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'KyHieu
        '
        Me.KyHieu.Caption = "Mã"
        Me.KyHieu.FieldName = "KyHieu"
        Me.KyHieu.Name = "KyHieu"
        Me.KyHieu.Visible = True
        Me.KyHieu.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên"
        Me.GridColumn3.FieldName = "TenVuviec"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(517, 7)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(443, 17)
        Me.LabelControl20.TabIndex = 23
        Me.LabelControl20.Text = "F4 – Thêm dòng; F8 – Xóa dòng; Ctrl + Tab – Ra khỏi chi tiết hạch toán"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grcLPN_Hnx)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.groupControl2)
        Me.SplitContainerControl1.Panel2.MinSize = 800
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1166, 696)
        Me.SplitContainerControl1.SplitterPosition = 194
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.PanelControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(5, 701)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(1166, 47)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "GroupControl4"
        '
        'frmOpecPhieuMuaHang_ChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 753)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOpecPhieuMuaHang_ChiTiet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "frmPhieuNhapKhau_ChiTiet"
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.cboPPThanhtoan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaTkCo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDmKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoHopDong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTY_GIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlLOAI_CT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNhapKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayCt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayCt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNgoaiTe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNGOAI_TE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDIEN_GIAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.groupControl2.PerformLayout()
        CType(Me.txtTienHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcLPN_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLPX_Hnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depCT_H_Nx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.grcPhieuNhapKhau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcPhieuNhapKhau_View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDmHanghoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilter_MA_TKN_GIAVON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPTQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTudo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhongban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKhoanphi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtETA.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtETA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtETD.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtETD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLSD.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVuViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTK_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMA_HANGHOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMVuviec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDanhMucThue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaKhach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFilterEdit_HANGHOA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDMthue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcboDmVuviec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents labelControl11 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSav As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDIEN_GIAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboNgoaiTe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkNGOAI_TE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTienHang As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtNgayCt As DevExpress.XtraEditors.DateEdit
    Private WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkNhapKhau As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grlLOAI_CT_ID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents depCT_H_Nx As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents btnQui As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Private WithEvents grcPhieuNhapKhau As DevExpress.XtraGrid.GridControl
    Private WithEvents grcPhieuNhapKhau_View As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents HANGHOA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMA_HANGHOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents TEN_HANGHOA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TEN_DVT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents KHO_NHAP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMaKho As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents TON_KHO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SO_LUONG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DON_GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GIA_VON As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DON_GIA_VON_NTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GIA_VON_NT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MA_TKN_GIAVON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTK_NO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboVuViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TY_LE_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_GTGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_THUE_XNK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_XNK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TY_LE_THUE_TTDB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN_THUE_TTDB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_DM_PTQT_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPTQT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_1_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTudo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_2_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTudo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_3_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTudo3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_4_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTudo4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_TUDO_5_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTudo5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_PHONGBAN_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPhongban As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_VUVIEC_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDMVuviec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_KHOANPHI_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboKhoanphi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ID_DM_HOPDONG_CO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboHopDong As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDanhMucThue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboMaKhach As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grcLPN_Hnx As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLPX_Hnx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CT_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_GHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGAY_CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SO_TIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navCTHG As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents UR_STATUS As Status_LoaiCT
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GFilterEdit_HANGHOA_ID As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents GFilter_MA_TKN_GIAVON As Vns.Erp.Core.RepositoryItemPopupFilterEdit
    Friend WithEvents txtTY_GIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VI_TRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents C_SoChungTu As C_SoChungTu
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CtSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayCt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NgayGhi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SoTien As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents HanghoaId As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TenDvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViTri As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents KhoNhapId As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TonKho As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DonGiaVonNte As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GiaVonNt As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DonGiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GiaVon As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MaTknGiavon As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents cboDMthue As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDmVuviec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rcboDmVuviec As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KyHieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoHopDong As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboDmKhachHang As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents cboMaTkCo As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDmHanghoa As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboPPThanhtoan As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEtaDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLsdDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEtdDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtETA As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtLSD As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtETD As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
