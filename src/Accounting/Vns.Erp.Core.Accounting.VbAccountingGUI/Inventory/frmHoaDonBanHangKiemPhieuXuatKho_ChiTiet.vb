Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Controls.Commons

Public Class frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet

#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService

    Public Property HtLoaichungtuService() As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Private _DmTaikhoanService As IDmTaikhoanService

    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private _DmKhoService As IDmKhoService

    Public Property DmKhoService() As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property
    Private _DmVuviecService As IDmVuviecService

    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property
    Private _DmPtqtService As IDmPtqtService

    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
    Private _DmTudo1Service As IDmTudo1Service

    Public Property DmTudo1Service() As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property
    Private _DmTudo2Service As IDmTudo2Service

    Public Property DmTudo2Service() As IDmTudo2Service
        Get
            Return _DmTudo2Service
        End Get
        Set(ByVal value As IDmTudo2Service)
            _DmTudo2Service = value
        End Set
    End Property
    Private _DmTudo3Service As IDmTudo3Service

    Public Property DmTudo3Service() As IDmTudo3Service
        Get
            Return _DmTudo3Service
        End Get
        Set(ByVal value As IDmTudo3Service)
            _DmTudo3Service = value
        End Set
    End Property
    Private _DmTudo4Service As IDmTudo4Service

    Public Property DmTudo4Service() As IDmTudo4Service
        Get
            Return _DmTudo4Service
        End Get
        Set(ByVal value As IDmTudo4Service)
            _DmTudo4Service = value
        End Set
    End Property
    Private _DmTudo5Service As IDmTudo5Service

    Public Property DmTudo5Service() As IDmTudo5Service
        Get
            Return _DmTudo5Service
        End Get
        Set(ByVal value As IDmTudo5Service)
            _DmTudo5Service = value
        End Set
    End Property
    Private _DmPhongbanService As IDmPhongbanService

    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property
    Private _DmKhoanphiService As IDmKhoanphiService

    Public Property DmKhoanphiService() As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property
    Private _DmHopdongService As IDmHopdongService

    Public Property DmHopdongService() As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property
    Private _CtHNxService As ICtHNxService

    Public Property CtHNxService() As ICtHNxService
        Get
            Return _CtHNxService
        End Get
        Set(ByVal value As ICtHNxService)
            _CtHNxService = value
        End Set
    End Property
    Private _CtDNxService As ICtDNxService

    Public Property CtDNxService() As ICtDNxService
        Get
            Return _CtDNxService
        End Get
        Set(ByVal value As ICtDNxService)
            _CtDNxService = value
        End Set
    End Property
    Private _HtSoChungtuMaxService As IHtSoChungtuMaxService

    Public Property HtSoChungtuMaxService() As IHtSoChungtuMaxService
        Get
            Return _HtSoChungtuMaxService
        End Get
        Set(ByVal value As IHtSoChungtuMaxService)
            _HtSoChungtuMaxService = value
        End Set
    End Property
    Private _KtKhoasoThangService As IKtKhoasoThangService

    Public Property KtKhoasoThangService() As IKtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As IKtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property
    Private _DmHanghoaService As IDmHanghoaService

    Public Property DmHanghoaService() As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property
    Private _DmKhangService As IDmKhangService

    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _DmNgoaiteService As IDmNgoaiteService
    Public Property DmNgoaiteService As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(ByVal value As IDmNgoaiteService)
            _DmNgoaiteService = value
        End Set
    End Property

    Private _CtHoadonService As ICtHoadonService
    Public Property CtHoadonService As ICtHoadonService
        Get
            Return _CtHoadonService
        End Get
        Set(ByVal value As ICtHoadonService)
            _CtHoadonService = value
        End Set
    End Property

    Private _CtThueService As ICtThueService
    Public Property CtThueService As ICtThueService
        Get
            Return _CtThueService
        End Get
        Set(ByVal value As ICtThueService)
            _CtThueService = value
        End Set
    End Property

    Private _LsTygiaService As ILsTygiaService
    Public Property LsTygiaService As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(ByVal value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property

    Public Property DmThueService As IDmThueService
#End Region

#Region "Variables and Messages"
    Private obj_ct_h_nx As CtHNx = New CtHNx()
    Private obj_ct_d_nx As CtDNx = New CtDNx()
    Private lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private del_lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private m_MaCT As String
    Public lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Public obj_lct As HtLoaichungtu = New HtLoaichungtu()
    Public lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    Dim flag As Boolean = True
    Private closeForm As Boolean = False
    Private Kry_DATASOURE As DataTable
    Private Ji_DATASOURE As DataTable
    Private objcthoadon As CtHoadon = New CtHoadon
    Private OnLoadData = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"

#End Region

#Region "Load form"
    Public Function Show_Form(ByVal CTH_XN_ID As Guid, ByVal Ma_CT As String, ByVal name As String, ByVal lstcthg As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As Boolean
        Try
            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            Form_SetText(Me, name, eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_CTH_ID = CTH_XN_ID
            m_MaCT = Ma_CT
            obj_lct = _HtLoaichungtuService.GetByMA_LOAI_CT(Ma_CT, Generals.DON_VI.Id)
            If lstcthg IsNot Nothing Then
                lstobj_ct_h_gg = lstcthg
            End If
            'Control_SetRequire(dteNGAY_GHI, True)
            If obj_lct IsNot Nothing Then
                LoadInfoBy(obj_lct)
                UR_STATUS.LCT_STATUS = obj_lct.Id
            End If

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
            AddHandler grvLPX_Hnx.FocusedRowChanged, AddressOf grvLPX_Hnx_FocusedRowChanged
            grpSMQR.Focus()
            dteNGAY_CT.Focus()

            If closeForm = True Then
                Message_Warning(ConstantMsgs.MSG_ALERT_FOR_RECENT_DELETE)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Return True
            Else
                Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Function

    Private Sub LoadInfoBy(objChungTu As HtLoaichungtu)
        GrcHoaDonBanHang_View.Columns("ThueId").Visible = objChungTu.SdTkThueNgamdinh
        GrcHoaDonBanHang_View.Columns("TyLeThueGtgt").Visible = objChungTu.SdTkThueNgamdinh
        GrcHoaDonBanHang_View.Columns("SoTienThueGtgt").Visible = objChungTu.SdTkThueNgamdinh
        GrcHoaDonBanHang_View.Columns("SoTienCk").Visible = objChungTu.SdTkThueNgamdinh
        labelControl30.Visible = objChungTu.SdTkThueNgamdinh
        GFilter_TKC_THUE_GTGT.Visible = objChungTu.SdTkThueNgamdinh
        GFilter_TKN_THUE_GTGT.Visible = objChungTu.SdTkThueNgamdinh
        labelControl44.Visible = objChungTu.SdTkThueNgamdinh
        txtTienThue.Visible = objChungTu.SdTkThueNgamdinh
        ckeNhapTienThue.Visible = objChungTu.SdTkThueNgamdinh
        labelControl34.Visible = objChungTu.SdTkThueNgamdinh
        GFilter_TKC_CK.Visible = objChungTu.SdTkThueNgamdinh
        GFilter_TKN_CK.Visible = objChungTu.SdTkThueNgamdinh
        labelControl45.Visible = objChungTu.SdTkThueNgamdinh
        txtTaiKhoanChietKhau.Visible = objChungTu.SdTkThueNgamdinh
        chkChietKhau.Visible = objChungTu.SdTkThueNgamdinh
        LabelControl7.Visible = objChungTu.SdTkThueNgamdinh
        LabelControl8.Visible = objChungTu.SdTkThueNgamdinh
    End Sub
#End Region

#Region "Private Function and Procedures"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        UR_STATUS.Visible = Generals.Ts_PheDuyetChungTu
        UR_STATUS.Enabled = Generals.Ts_PheDuyetChungTu
        'Validate control
        Commons.RequireInputControls = New Control() {dteNGAY_CT, dteNGAY_GHI}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

    Private Sub Load_Grid(ByVal lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo))
        If lstobj_ct_h_gg IsNot Nothing And lstobj_ct_h_gg.Count > 0 Then
            grcLPN_Hnx.DataSource = Nothing
            grcLPN_Hnx.DataSource = lstobj_ct_h_gg
            For i = 0 To lstobj_ct_h_gg.Count - 1
                If m_CTH_ID = lstobj_ct_h_gg(i).Id Then
                    Me.grvLPX_Hnx.FocusedRowHandle = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                grcLPN_Hnx.Enabled = False
                Control_SetState(grpSMQR, DataInputState.AddMode)
                Control_SetState(groupControl2, DataInputState.AddMode)
                GrcHoaDonBanHang_View.OptionsBehavior.Editable = True

                GFilter.ENABLES = True
                GFilter_TK.ENABLES = True
                GFilter_TKC_THUE_GTGT.ENABLES = True
                GFilter_TKN_THUE_GTGT.ENABLES = True
                GFilter_TKC_CK.ENABLES = True
                GFilter_TKN_CK.ENABLES = True

                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = False
                btnPri.Enabled = False
                btnCan.Enabled = True
                btnSea.Enabled = False
                navCTHG.Enabled = False
                GFilter.ENABLES = True
            Case DataInputState.EditMode
                grcLPN_Hnx.Enabled = False
                Control_SetState(grpSMQR, DataInputState.EditMode)
                Control_SetState(groupControl2, DataInputState.EditMode)
                GrcHoaDonBanHang_View.OptionsBehavior.Editable = True

                GFilter.ENABLES = True
                GFilter_TK.ENABLES = True
                GFilter_TKC_THUE_GTGT.ENABLES = True
                GFilter_TKN_THUE_GTGT.ENABLES = True
                GFilter_TKC_CK.ENABLES = True
                GFilter_TKN_CK.ENABLES = True

                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = True
                btnPri.Enabled = True
                btnCan.Enabled = True
                btnSea.Enabled = False
                navCTHG.Enabled = False
                GFilter.ENABLES = True
            Case Else
                grcLPN_Hnx.Enabled = True
                Control_SetState(grpSMQR, DataInputState.ViewMode)
                Control_SetState(groupControl2, DataInputState.ViewMode)
                GrcHoaDonBanHang_View.OptionsBehavior.Editable = False

                GFilter.ENABLES = False
                GFilter_TK.ENABLES = False
                GFilter_TKC_THUE_GTGT.ENABLES = False
                GFilter_TKN_THUE_GTGT.ENABLES = False
                GFilter_TKC_CK.ENABLES = False
                GFilter_TKN_CK.ENABLES = False

                btnAdd.Enabled = True
                btnMod.Enabled = True
                btnSav.Enabled = False
                btnDel.Enabled = True
                btnPri.Enabled = True
                btnCan.Enabled = False
                btnSea.Enabled = True
                navCTHG.Enabled = True
                GFilter.ENABLES = False
        End Select
    End Sub

    Private Sub Init_Data()
        Try
            OnLoadData = True
            GrcHoaDonBanHang_View.Columns("DonGiaVon").Visible = False
            GrcHoaDonBanHang_View.Columns("GiaVon").Visible = False
            Select Case m_InputState
                Case DataInputState.AddMode
                    SetColNgoaiTe(chkNGOAI_TE.Checked)
                    lstobj_ct_d_nx.Add(New CtDNx())
                    GrcHoaDonBanHang.DataSource = lstobj_ct_d_nx
                    BindLookUpNX()
                    grlID_LOAI_CT.EditValue = obj_lct.Id
                    SetVisible()
                    dteNGAY_CT.EditValue = DateTime.Now
                    dteNGAY_GHI.EditValue = DateTime.Now
                    DatTrangThaiControl()
                Case Else
                    BindLookUpNX()
                    SetObjectToControl()
                    SetVisible()
                    DatTrangThaiControl()
                    'TongTien()
            End Select
            Load_Grid(lstobj_ct_h_gg)
            grlID_LOAI_CT.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        OnLoadData = False
    End Sub

    Private Sub SetVisible()
        'If obj_lct.DM_PHONGBAN <> 1 Then
        '    GrcHoaDonBanHang_View.Columns("ID_DM_PHONGBAN_CO").Visible = False
        'End If
        If obj_lct.DmKhoanphi <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmKhoanphiCo").Visible = False
        End If
        If obj_lct.DmTudo1 <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmTudo1Co").Visible = False
        End If
        If obj_lct.DmTudo2 <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmTudo2Co").Visible = False
        End If
        If obj_lct.DmTudo3 <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmTudo3Co").Visible = False
        End If
        If obj_lct.DmTudo4 <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmTudo4Co").Visible = False
        End If
        If obj_lct.DmTudo5 <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmTudo5Co").Visible = False
        End If
        If obj_lct.DmVuviec <> 1 Then
            GrcHoaDonBanHang_View.Columns("VuviecId").Visible = False
        End If
        If obj_lct.DmPtqt <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmPtqtCo").Visible = False
        End If
        If obj_lct.DmHopdong <> 1 Then
            GrcHoaDonBanHang_View.Columns("IdDmHopdongCo").Visible = False
        End If
    End Sub

    Private Sub BindLookUpNX()
        Try

            'Bind danh muc thue
            Dim lstDMThue As List(Of DmThue) = New List(Of DmThue)
            lstDMThue.Add(New DmThue)
            'lstDMThue.AddRange(_DmThueService.GetAll
            lstDMThue.AddRange(_DmThueService.GetDmThueByabc(obj_lct))
            cboDMthue.DataSource = lstDMThue
            cboDMthue.DisplayMember = "TenThue"
            cboDMthue.ValueMember = "Id"
            cboDMthue.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboDMthue.Columns.Add(New LookUpColumnInfo("TenThue", "Tên thuế"))

            Dim tklienquan = obj_lct.MaTkNoLq
            GFilter_TK.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tklienquan)
            Dim tk_thue_gtgt = obj_lct.TkThueNgamdinh
            GFilter_TKC_THUE_GTGT.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_thue_gtgt)

            'Kry_DATASOURE = DM_HanghoaBO.Instance.GetAllByDonviID(Generals.DON_VI.Id).Tables(0)
            'GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE

            Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            GFilter_MA_TKC_GIABAN.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_MA_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_MA_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE

            GFilter_TK.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_TKC_THUE_GTGT.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_TKN_THUE_GTGT.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_TKC_CK.C_DATA_SOURCE = Ji_DATASOURE
            GFilter_TKN_CK.C_DATA_SOURCE = Ji_DATASOURE

            'GFilter.C_DATA_SOURCE = DM_KhangBO.Instance().GetAllBy_CO_SU_DUNG_DS(Generals.DON_VI.Id).Tables(0)
            'Bind loại chứng từ
            Dim lstLoaiChungTu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
            lstLoaiChungTu.AddRange(_HtLoaichungtuService.GetAll())
            grlID_LOAI_CT.Properties.DataSource = lstLoaiChungTu
            grlID_LOAI_CT.Properties.DisplayMember = "TenLoaiCt"
            grlID_LOAI_CT.Properties.ValueMember = "Id"

            ''Bind mã kho
            Dim lstMaKho As List(Of DmKho) = New List(Of DmKho)
            lstMaKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
            cboMaKho.DataSource = lstMaKho
            cboMaKho.DisplayMember = "KyHieu"
            cboMaKho.ValueMember = "Id"
            cboMaKho.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã kho"))
            cboMaKho.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

            'Bind vụ việc
            Dim lstVuViecTemp As List(Of DmVuviec) = New List(Of DmVuviec)
            lstVuViecTemp.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstVuviec As List(Of DmVuviec) = New List(Of DmVuviec)
            Dim objvuviec As DmVuviec = New DmVuviec
            lstVuviec.Add(objvuviec)
            lstVuviec.AddRange(lstVuViecTemp)
            cboVuViec.DataSource = lstVuviec
            'cboVuViec.DisplayMember = "KyHieu"
            'cboVuViec.ValueMember = "Id"
            'cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
            'cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))
            rcboDmVuviec.DataSource = lstVuviec

            'Bind danh muc ngoai te
            Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
            lstNgoaite.AddRange(_DmNgoaiteService.GetAllByDonviID(Generals.DonviID))
            'Dim listNgoaite As List(Of DM_NgoaiteInfo) = New List(Of DM_NgoaiteInfo)
            cboNgoaiTe.Properties.DataSource = lstNgoaite
            cboNgoaiTe.Properties.DisplayMember = "KyHieu"
            cboNgoaiTe.Properties.ValueMember = "Id"
            cboNgoaiTe.Properties.DataSource = lstNgoaite
            cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            txtTY_GIA.Text = "1"

            'Bind Phòng ban
            Dim lstPhongBanTemp As List(Of DmPhongban) = New List(Of DmPhongban)()
            lstPhongBanTemp.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
            Dim objphongban As DmPhongban = New DmPhongban
            lstPhongBan.Add(objphongban)
            lstPhongBan.AddRange(lstPhongBanTemp)
            grlPHONGBAN_ID.Properties.DataSource = lstPhongBan
            grlPHONGBAN_ID.Properties.DisplayMember = "TenPhongban"
            grlPHONGBAN_ID.Properties.ValueMember = "Id"

            'Bind PTQT
            Dim lstPTQTTemp As List(Of DmPtqt) = New List(Of DmPtqt)
            lstPTQTTemp.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstPTQT As List(Of DmPtqt) = New List(Of DmPtqt)
            Dim objPTQT As DmPtqt = New DmPtqt
            lstPTQT.Add(objPTQT)
            lstPTQT.AddRange(lstPTQTTemp)
            cboPTQT.DataSource = lstPTQT
            cboPTQT.DisplayMember = "KyHieu"
            cboPTQT.ValueMember = "Id"
            cboPTQT.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã PTQT"))
            cboPTQT.Columns.Add(New LookUpColumnInfo("TenPtqt", "Tên PTQT"))

            'Bind tu do1
            Dim lsttudo1Temp As List(Of DmTudo1) = New List(Of DmTudo1)
            lsttudo1Temp.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsttudo1 As List(Of DmTudo1) = New List(Of DmTudo1)
            Dim objTudo1 As DmTudo1 = New DmTudo1
            lsttudo1.Add(objTudo1)
            lsttudo1.AddRange(lsttudo1Temp)
            cboTudo1.DataSource = lsttudo1
            cboTudo1.DisplayMember = "KyHieu"
            cboTudo1.ValueMember = "Id"
            cboTudo1.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã tự do 1"))
            cboTudo1.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục 1"))

            'Bind tu do 2
            Dim lsttudo2Temp As List(Of DmTudo2) = New List(Of DmTudo2)
            lsttudo2Temp.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsttudo2 As List(Of DmTudo2) = New List(Of DmTudo2)
            Dim objTudo2 As DmTudo2 = New DmTudo2
            lsttudo2.Add(objTudo2)
            lsttudo2.AddRange(lsttudo2Temp)
            cboTudo2.DataSource = lsttudo2
            cboTudo2.DisplayMember = "KyHieu"
            cboTudo2.ValueMember = "Id"
            cboTudo2.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã tự do 2"))
            cboTudo2.Columns.Add(New LookUpColumnInfo("TenDmTudo2", "Tên danh mục 2"))

            'Bind tu do 3
            Dim lsttudo3Temp As List(Of DmTudo3) = New List(Of DmTudo3)
            lsttudo3Temp.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsttudo3 As List(Of DmTudo3) = New List(Of DmTudo3)
            Dim objtudo3 As DmTudo3 = New DmTudo3
            lsttudo3.Add(objtudo3)
            lsttudo3.AddRange(lsttudo3Temp)
            cboTudo3.DataSource = lsttudo3
            cboTudo3.DisplayMember = "KyHieu"
            cboTudo3.ValueMember = "Id"
            cboTudo3.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã tự do 3"))
            cboTudo3.Columns.Add(New LookUpColumnInfo("TenDmTudo3", "Tên danh mục 3"))

            'Bind tu do 4
            Dim lsttudo4Temp As List(Of DmTudo4) = New List(Of DmTudo4)
            lsttudo4Temp.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsttudo4 As List(Of DmTudo4) = New List(Of DmTudo4)
            Dim objtudo4 As DmTudo4 = New DmTudo4
            lsttudo4.Add(objtudo4)
            lsttudo4.AddRange(lsttudo4Temp)
            cboTudo4.DataSource = lsttudo4
            cboTudo4.DisplayMember = "KyHieu"
            cboTudo4.ValueMember = "Id"
            cboTudo4.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã tự do 4"))
            cboTudo4.Columns.Add(New LookUpColumnInfo("TenDmTudo4", "Tên danh mục 4"))

            ''Bind tu do 5
            Dim lsttudo5Temp As List(Of DmTudo5) = New List(Of DmTudo5)
            lsttudo5Temp.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsttudo5 As List(Of DmTudo5) = New List(Of DmTudo5)
            Dim objtudo5 As DmTudo5 = New DmTudo5
            lsttudo5.Add(objtudo5)
            lsttudo5.AddRange(lsttudo5Temp)
            cboTudo5.DataSource = lsttudo5
            cboTudo5.DisplayMember = "KyHieu"
            cboTudo5.ValueMember = "Id"
            cboTudo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã tự do 5"))
            cboTudo5.Columns.Add(New LookUpColumnInfo("TenDmTudo5", "Tên danh mục 5"))

            'Dim lstquytrinh As List(Of DM_Quytrinh_SxInfo) = DM_Quytrinh_SxBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.Id)
            'cboTudo5.DataSource = lstquytrinh
            'cboTudo5.DisplayMember = "TEN_QUYTRINH"
            'cboTudo5.ValueMember = "DM_QUYTRINH_SX_ID"
            'cboTudo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã quy trình"))
            'cboTudo5.Columns.Add(New LookUpColumnInfo("TEN_QUYTRINH", "Tên quy trình"))

            ''Bind phong ban
            'Dim lstphongban1 As List(Of DmPhongban) = DM_PhongbanBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.Id)
            'cboPhongBan.DataSource = lstphongban1
            'cboPhongBan.DisplayMember = "KyHieu"
            'cboPhongBan.ValueMember = "PHONGBAN_ID"
            'cboPhongBan.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã phòng ban"))
            'cboPhongBan.Columns.Add(New LookUpColumnInfo("TEN_PHONGBAN", "Tên phòng ban"))


            'Bind khoan phi
            Dim lstkhoanphiTemp As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
            lstkhoanphiTemp.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstkhoanphi As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
            Dim objkhoanphi As DmKhoanphi = New DmKhoanphi
            lstkhoanphi.Add(objkhoanphi)
            lstkhoanphi.AddRange(lstkhoanphiTemp)
            cboKhoanphi.DataSource = lstkhoanphi
            cboKhoanphi.DisplayMember = "KyHieu"
            cboKhoanphi.ValueMember = "Id"
            cboKhoanphi.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã khoản phí"))
            cboKhoanphi.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))

            'Bind hợp đồng
            Dim lsthopdongTemp As List(Of DmHopdong) = New List(Of DmHopdong)
            lsthopdongTemp.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsthopdong As List(Of DmHopdong) = New List(Of DmHopdong)
            Dim objhopdong As DmHopdong = New DmHopdong
            lsthopdong.Add(objhopdong)
            lsthopdong.AddRange(lsthopdongTemp)
            cboHopdong.DataSource = lsthopdong
            cboHopdong.DisplayMember = "KyHieu"
            cboHopdong.ValueMember = "Id"
            cboHopdong.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã hợp đồng"))
            cboHopdong.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Function BindTaiKhoan(ByVal tklienquan As String) As List(Of DmTaikhoan)
        Dim ListTK As List(Of DmTaikhoan) = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim ListTKFilter As List(Of DmTaikhoan) = New List(Of DmTaikhoan)

        Dim tks As String() = tklienquan.Split(New Char() {";"c})
        Dim tkFilter As String = String.Empty

        For Each tk As String In tks

            If tkFilter.Length = 0 Then
                tkFilter = String.Format("{0}", tk)
            Else
                Dim tksFilter As String() = tkFilter.Split(New Char() {";"c})
                Dim exits As Boolean = False
                For Each i As String In tksFilter
                    If Convert.ToString(tk).Length >= Convert.ToString(i).Length Then
                        If tk.StartsWith(i) Then
                            exits = True
                        End If
                    Else
                        If i.StartsWith(tk) Then
                            exits = True
                        End If
                    End If
                    If exits = True Then
                        Exit For
                    End If
                Next
                If exits = False Then
                    tkFilter = String.Format("{0};{1}", tkFilter, tk)
                End If
            End If
        Next

        Dim matk As String
        For Each matk In tkFilter.Split(New Char() {";"c})
            ListTKFilter.AddRange(From i As DmTaikhoan In ListTK
                                  Where i.MaTaikhoan.StartsWith(matk)
                                  Select i)
        Next

        If ListTKFilter.Count > 0 Then
            Return ListTKFilter
        Else
            Return ListTK
        End If
    End Function

    Private Sub GetControlToOBject()
        Try
            obj_ct_h_nx.KhangId = VnsConvert.CGuid(GFilter.ListEditValue(0))
            obj_ct_h_nx.MaKhang = GFilter.ListEditValue(2)
            obj_ct_h_nx.KyHieuKhang = GFilter.ListEditValue(3)
            'obj_ct_h_nx.MST_KHANG = GFilter.ListEditValue(4)
            'obj_ct_h_nx.TEN_KHANG = GFilter.ListEditValue(1)
            obj_ct_h_nx.MstKhang = txtMST_KHANG.Text.Trim()
            obj_ct_h_nx.TenKhang = txtTEN_KHANG.Text.Trim()
            obj_ct_h_nx.DiaChi = txtDIA_CHI.Text.Trim()
            obj_ct_h_nx.NguoiGiaoNhanHang = txtNGUOI_NHAN_NOP_TIEN.Text.Trim()
            Dim drLPNhap As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlID_LOAI_CT), HtLoaichungtu)
            obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt
            obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu
            obj_ct_h_nx.IdLoaiCt = drLPNhap.Id

            Dim drPBan As DmPhongban = CType(ComboHelper.GetSelectData(grlPHONGBAN_ID), DmPhongban)
            If drPBan Is Nothing Then
                drPBan = New DmPhongban
            End If
            obj_ct_h_nx.PhongbanId = drPBan.Id
            obj_ct_h_nx.MaPhongban = drPBan.MaPhongban
            obj_ct_h_nx.KyHieuPhongban = drPBan.KyHieu
            obj_ct_h_nx.TenPhongban = drPBan.TenPhongban
            'End If
            obj_ct_h_nx.TyGia = txtTY_GIA.Text.Trim()
            obj_ct_h_nx.MaNte = cboNgoaiTe.Text
            obj_ct_h_nx.NteId = cboNgoaiTe.EditValue
            obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(Not (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))
            obj_ct_h_nx.MstKhang = txtMST_KHANG.EditValue
            obj_ct_h_nx.NguoiNhanNopTien = txtNGUOI_NHAN_NOP_TIEN.Text.Trim()
            obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text.Trim()
            obj_ct_h_nx.NgayGhi = dteNGAY_GHI.DateTime
            obj_ct_h_nx.NgayCt = dteNGAY_CT.DateTime
            obj_ct_h_nx.DonviId = Generals.DON_VI.Id
            obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
            obj_ct_h_nx.SoDu = 0
            obj_ct_h_nx.Ghi = Convert.ToDecimal(UR_STATUS.Value_info.ParameterValue)
            obj_ct_h_nx.SoSeri = txtSO_SERI.Text.Trim()

            'Lấy dữ liệu để insert vào CT_HOADON
            If objcthoadon Is Nothing Then
                objcthoadon = New CtHoadon
            End If

            obj_ct_h_nx.SoTien = Decimal.Parse(txtTong.Text)
            objcthoadon.TongTien = obj_ct_h_nx.SoTien

            objcthoadon.SoSeri = txtSO_SERI.Text.Trim()
            'objcthoadon.SoHoadon = txt
            objcthoadon.TenKhachhang = obj_ct_h_nx.TenKhang
            objcthoadon.DiaChi = txtDIA_CHI.Text.Trim()
            objcthoadon.NgayHoadon = dteNGAY_CT.DateTime
            objcthoadon.MaSoThue = obj_ct_h_nx.MstKhang
            objcthoadon.DienGiai = obj_ct_h_nx.DienGiai
            objcthoadon.DonviId = obj_ct_h_nx.DonviId
            objcthoadon.MaDonvi = obj_ct_h_nx.MaDonvi
            objcthoadon.DoanhThu = Decimal.Parse(txtTienHang.Text)
            objcthoadon.TienThue = Decimal.Parse(txtTienThue.Text)

            If txtSO_NGAY_THANH_TOAN.Text = "" Then
                objcthoadon.SoNgayThanhToan = 0
            Else
                objcthoadon.SoNgayThanhToan = Decimal.Parse(txtSO_NGAY_THANH_TOAN.Text)
            End If

            Select Case m_InputState
                Case DataInputState.AddMode
                    Dim strmMonth As String
                    strmMonth = Month(dteNGAY_CT.DateTime).ToString
                    Dim strYear As String
                    strYear = Year(dteNGAY_CT.DateTime).ToString
                    C_SO_CT_RP.r_SoCTPREFIX(obj_ct_h_nx.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id)
                    obj_ct_h_nx.CtSo = C_SO_CT_RP.SO_CHUNG_TU
                    obj_ct_h_nx.PrefixCt = C_SO_CT_RP.PREFIX
                Case Else
                    'UpdateCT_H_Nx(obj_ct_h_nx)
                    'CT_HoadonBO.Instance.Update(objcthoadon)
            End Select
            Dim obj_ct_t As CtThue = New CtThue
            'lay gia trị control tren luoi gan cho obj
            For Each objctdnx As CtDNx In lstobj_ct_d_nx
                objctdnx.TkcCk = VnsConvert.CGuid(GFilter_TKC_CK.ListEditValue(0))
                objctdnx.MaTkcCk = GFilter_TKC_CK.ListEditValue(1)

                objctdnx.TknCk = VnsConvert.CGuid(GFilter_TKN_CK.ListEditValue(0))
                objctdnx.MaTknCk = GFilter_TKN_CK.ListEditValue(1)

                objctdnx.TknGiaban = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
                objctdnx.MaTknGiaban = GFilter_TK.ListEditValue(1)

                objctdnx.TknThueGtgt = VnsConvert.CGuid(GFilter_TKN_THUE_GTGT.ListEditValue(0))
                objctdnx.MaTknThueGtgt = GFilter_TKN_THUE_GTGT.ListEditValue(1)

                objctdnx.TkcThueGtgt = VnsConvert.CGuid(GFilter_TKC_THUE_GTGT.ListEditValue(0))
                objctdnx.MaTkcThueGtgt = GFilter_TKC_THUE_GTGT.ListEditValue(1)
                obj_ct_t.MaTaikhoan = GFilter_TKC_THUE_GTGT.ListEditValue(1)
                obj_ct_t.TaikhoanId = VnsConvert.CGuid(GFilter_TKC_THUE_GTGT.ListEditValue(0))

                objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang
                objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang
                objctdnx.SoDu = 0
                objctdnx.ThuTu = 0
                objctdnx.PpTinhGiaXuat = TNCommon.ParseDecimal(checkEdit4.Checked)
                'objctdnx.SoTienCk = txtTaiKhoanChietKhau.EditValue

                objctdnx.IdDmHopdongNo = objctdnx.IdDmHopdongCo
                objctdnx.IdDmKhoanphiNo = objctdnx.IdDmKhoanphiCo
                objctdnx.IdDmTudo1No = objctdnx.IdDmTudo1Co
                objctdnx.IdDmTudo2No = objctdnx.IdDmTudo2Co
                objctdnx.IdDmTudo3No = objctdnx.IdDmTudo3Co
                objctdnx.IdDmTudo4No = objctdnx.IdDmTudo4Co
                objctdnx.IdDmTudo5No = objctdnx.IdDmTudo5Co
                objctdnx.IdDmPtqtNo = objctdnx.IdDmPtqtCo
                objctdnx.IdDmVuviecCo = objctdnx.VuviecId
                objctdnx.IdDmVuviecNo = objctdnx.VuviecId
                objctdnx.Xuat = obj_lct.KhoXuat
                objctdnx.IdDoituongHoadon = objcthoadon.Id
                If objctdnx.IdDmPhongbanCo = Null.NullGuid Then
                    objctdnx.IdDmPhongbanCo = obj_ct_h_nx.PhongbanId
                    objctdnx.IdDmPhongbanNo = obj_ct_h_nx.PhongbanId
                Else
                    objctdnx.IdDmPhongbanNo = objctdnx.IdDmPhongbanCo
                End If

                'Lấy giá trị cho chứng từ thuế
                obj_ct_t.SoLuong = objctdnx.SoLuong
                obj_ct_t.KhangId = obj_ct_h_nx.KhangId
                obj_ct_t.TenKhang = obj_ct_h_nx.TenKhang
                obj_ct_t.Mst = obj_ct_h_nx.MstKhang
                obj_ct_t.NgayHoadon = obj_ct_h_nx.NgayCt
                obj_ct_t.DoanhSo = objctdnx.SoTienBan
                obj_ct_t.SoTien = objctdnx.SoTienThueGtgt
                obj_ct_t.TyLe = objctdnx.TyLeThueGtgt
                obj_ct_t.NgayTao = obj_ct_h_nx.NgayTao
                obj_ct_t.LoaiTaikhoan = "C"
                obj_ct_t.DonviId = Generals.DON_VI.Id
                obj_ct_t.TenHanghoa = objctdnx.TenHanghoa
                obj_ct_t.CtHoadonId = objcthoadon.Id
                obj_ct_t.CthId = obj_ct_h_nx.Id
                obj_ct_t.PhanHe = 1
            Next

            C_SO_CT_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
            Dim IsUpdate As Boolean = False
            If m_InputState = DataInputState.EditMode Then
                IsUpdate = True
            End If
            _CtHNxService.SaveChungTuMuaBan(IsUpdate, obj_ct_h_nx, lstobj_ct_d_nx, del_lstobj_ct_d_nx, objcthoadon, obj_lct.PhieuXuat)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetObjectToControl()
        Try
            obj_ct_h_nx = _CtHNxService.GetById(m_CTH_ID)
            If obj_ct_h_nx Is Nothing Then
                closeForm = True
                Return
            Else
                closeForm = False
            End If

            grlID_LOAI_CT.EditValue = obj_ct_h_nx.IdLoaiCt
            SetColNgoaiTe(chkNGOAI_TE.Checked)
            'grlMA_KHANG.EditValue = obj_ct_h_nx.KHANG_ID
            GFilter.Text = obj_ct_h_nx.KyHieuKhang
            GFilter.Tag = obj_ct_h_nx.KhangId
            txtDIA_CHI.Text = obj_ct_h_nx.DiaChi
            txtNGUOI_NHAN_NOP_TIEN.Text = obj_ct_h_nx.NguoiGiaoNhanHang
            txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai
            txtMST_KHANG.Text = obj_ct_h_nx.MstKhang
            txtSO_SERI.Text = obj_ct_h_nx.SoSeri
            dteNGAY_CT.DateTime = obj_ct_h_nx.NgayCt
            dteNGAY_GHI.DateTime = obj_ct_h_nx.NgayGhi

            C_SO_CT_RP.Text = obj_ct_h_nx.PrefixCt & obj_ct_h_nx.CtSo
            grlPHONGBAN_ID.EditValue = obj_ct_h_nx.PhongbanId
            cboNgoaiTe.EditValue = obj_ct_h_nx.NteId
            txtTY_GIA.Text = obj_ct_h_nx.TyGia
            txtTEN_KHANG.Text = obj_ct_h_nx.TenKhang
            UR_STATUS.Set_Status(obj_ct_h_nx.Ghi)
            lstobj_ct_d_nx = New List(Of CtDNx)
            lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(m_CTH_ID))
            If (lstobj_ct_d_nx.Count > 0) Then
                GFilter_TK.Text = lstobj_ct_d_nx(0).MaTknGiaban
                GFilter_TK.Tag = lstobj_ct_d_nx(0).TknGiaban
                GFilter_TKC_THUE_GTGT.Text = lstobj_ct_d_nx(0).MaTkcThueGtgt
                GFilter_TKC_THUE_GTGT.Tag = lstobj_ct_d_nx(0).TkcThueGtgt

                GFilter_TKC_CK.Text = lstobj_ct_d_nx(0).MaTkcCk
                GFilter_TKC_CK.Tag = lstobj_ct_d_nx(0).TkcCk

                GFilter_TKN_CK.Text = lstobj_ct_d_nx(0).MaTknCk
                GFilter_TKN_CK.Tag = lstobj_ct_d_nx(0).TknCk

                GFilter_TKN_THUE_GTGT.Text = lstobj_ct_d_nx(0).MaTknThueGtgt
                GFilter_TKN_THUE_GTGT.Tag = lstobj_ct_d_nx(0).TknThueGtgt

                checkEdit4.Checked = TNCommon.ParseBool(lstobj_ct_d_nx(0).PpTinhGiaXuat)
                objcthoadon = _CtHoadonService.GetById(lstobj_ct_d_nx(0).IdDoituongHoadon)

                If objcthoadon IsNot Nothing Then
                    txtSO_NGAY_THANH_TOAN.Text = objcthoadon.SoNgayThanhToan.ToString
                Else
                    txtSO_NGAY_THANH_TOAN.Text = 0
                End If
            End If
            GrcHoaDonBanHang.DataSource = lstobj_ct_d_nx
            TongTien()
            ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_MaCT, GrcHoaDonBanHang_View.Name, GrcHoaDonBanHang_View)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TongTien()
        Dim sum As Decimal
        Dim sum1 As Decimal
        Dim sum2 As Decimal
        Dim sum3 As Decimal

        For i = 0 To GrcHoaDonBanHang_View.RowCount - 1
            Dim gridctdnx As CtDNx = CType(GrcHoaDonBanHang_View.GetRow(i), CtDNx)
            sum = sum + gridctdnx.SoTienBan
            sum1 = sum1 + gridctdnx.SoTienCk
            sum2 = sum2 + gridctdnx.SoTienThueGtgt
        Next
        sum3 = sum + sum2 - sum1
        txtTienHang.EditValue = sum
        txtTienThue.EditValue = sum2
        txtTong.EditValue = sum3
        txtTaiKhoanChietKhau.EditValue = sum1

    End Sub

    ''' <summary>
    ''' ham kiem tra null cua form
    ''' </summary>
    ''' <param name="lstobj_ct_d_nx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckNull(ByVal lstobj_ct_d_nx As List(Of CtDNx)) As Boolean

        ' kiem tra null cua comobox ma khach
        'If (String.IsNullOrEmpty(GFilter.ListEditValue(0))) Then
        '    Message_Warning("Bạn chưa nhập mã khách hàng")
        '    Return False
        'End If

        'kiem tra null cua comobox ngay hach toan
        If (dteNGAY_GHI.DateTime = Nothing) Then
            Message_Warning("Bạn chưa nhập ngày hạch toán ")
            dteNGAY_GHI.Focus()
            Return False
        End If

        If (dteNGAY_GHI.DateTime.Date > dteNGAY_CT.DateTime.Date) Then
            Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ")
            dteNGAY_GHI.Focus()
            Return False
        End If

        'Kiem tra TKN_GIABAN
        If (VnsCheck.IsNullGuid(GFilter_TK.ListEditValue(0))) Then
            Message_Warning("Bạn chưa nhập Tk nợ")
            GFilter_TK.Focus()
            Return False
        End If
        'If Decimal.Parse(txtTY_GIA.Text) <= 0 Then
        If LimitValue.CheckTyGia(Decimal.Parse(txtTY_GIA.Text.Trim)) = False Then
            Message_Warning("Tỷ giá không hợp lệ")
            txtTY_GIA.Focus()
            Return False
        End If
        'Kiem tra CK
        If LimitValue.CheckVNDCurrency(Decimal.Parse(txtTaiKhoanChietKhau.Text.Trim)) = False Then
            Message_Warning("Số tiền chiết khấu không hợp lệ")
            txtTaiKhoanChietKhau.Focus()
            Return False
        End If
        'Kiem tra tai khoan co va tai khoan no
        If (GFilter_TKC_THUE_GTGT.ListEditValue(0) = GFilter_TKN_THUE_GTGT.ListEditValue(0)) And (Not VnsCheck.IsNullGuid(GFilter_TKC_THUE_GTGT.ListEditValue(0))) Then
            Message_Warning("Mã tài khoản nợ và có thuế GTGT phải khác nhau")
            Return False
        End If
        If (GFilter_TKC_CK.ListEditValue(0) = GFilter_TKN_CK.ListEditValue(0)) And (Not VnsCheck.IsNullGuid(GFilter_TKN_CK.ListEditValue(0))) Then
            Message_Warning("Mã tài khoản nợ và có chiết khấu phải khác nhau")
            Return False
        End If

        If txtTienThue.Text <> "" And ckeNhapTienThue.Checked Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtTienThue.Text)) Then
                Message_Warning("Giá trị tiền thuế nhập vào không hợp lệ!")
                txtTienThue.Focus()
                Return False
            End If
        End If
        'vong lap kiem tra cac cot tren luoi
        If GrcHoaDonBanHang_View.RowCount <> 0 Then
            For Each objctd As CtDNx In lstobj_ct_d_nx
                'kiem tra gia tri null cua cot Hang hoa
                If (VnsCheck.IsNullGuid(objctd.HanghoaId)) Then
                    Message_Warning("Bạn chưa nhập mã hàng hóa")
                    Return False
                End If

                If String.IsNullOrEmpty(objctd.KyHieuHanghoa) Then
                    Message_Warning("Bạn để trống cột mã hàng hóa")
                    Return False
                End If
                'kiem tra gia tri null cua cot kho nhap
                If (VnsCheck.IsNullGuid(objctd.KhoXuatId)) Then
                    Message_Warning("Bạn chưa chọn kho xuất")
                    Return False
                End If
                'kiem tra gia tri cua cot so luong
                If objctd.SoLuong = 0 Then
                    Message_Warning("Bạn chưa nhập số lượng")
                    Return False
                End If
                'Kiem tra các giá trị số trên lưới
                If LimitValue.CheckQuantity(objctd.SoLuong) = False Then
                    Message_Warning("Số lượng không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckCurrency(objctd.SoTienBan) = False Then
                    Message_Warning("Giá trị đơn giá bán không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckVNDCurrency(objctd.GiaVon) = False Then
                    Message_Warning("Đơn giá vốn không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckFCurrency(objctd.SoTienBanNte) = False Then
                    Message_Warning("Đơn giá bán ngoại tệ không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckTaxRate(objctd.TyLeThueGtgt) = False Then
                    Message_Warning("Tỷ lệ thuế không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckVNDCurrency(objctd.SoTienThueGtgt) = False Then

                    Message_Warning("Số tiền thuế giá trị gia tăng không hợp lệ")
                    Return False
                End If
                'kiem tra gia tri cua cot don gia
                If objctd.DonGiaBan = 0 Then
                    Message_Warning("Bạn chưa nhập đơn giá")
                    Return False
                End If
                'kiem tra gia tri cot tong tien
                If (objctd.GiaVon = 0 And objctd.SoTienBan = 0) Then
                    Message_Warning("Bạn chưa nhập tổng tiền")
                    Return False
                End If
                ' kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                If (VnsCheck.IsNullGuid(objctd.TkcGiaban)) Then
                    Message_Warning("Bạn chưa nhập đủ Tk doanh thu")
                    Return False
                End If
                If (VnsCheck.IsNullGuid(objctd.TknGiavon)) Then
                    Message_Warning("Bạn chưa nhập Tk giá vốn")
                    Return False
                End If
            Next
        Else
            Message_Warning("Dữ liệu trên lưới chưa có")
            Return False

        End If

        Return True
    End Function

    ''' <summary>
    ''' lay ID cua row dang focus
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (grvLPX_Hnx.GetSelectedRows().Length > 0) Then
            If (grvLPX_Hnx.RowCount <> 0) Then
                Dim grtCTHG As Extend.CT_H_GInfo = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows(0)), Extend.CT_H_GInfo)
                m_CTH_ID = grtCTHG.Id
                Return True
            End If
        End If
        Return False
    End Function
#End Region

#Region "Events"

    Private Sub GrcHoaDonBanHang_View_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GrcHoaDonBanHang_View.CellValueChanged
        Try
            Dim gridctdnx As CtDNx = CType(GrcHoaDonBanHang_View.GetRow(GrcHoaDonBanHang_View.FocusedRowHandle), CtDNx)
            Select Case e.Column.Name
                Case "VuviecId"
                    Dim cboVViec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctdnx.VuviecId), DmVuviec)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    'Gan vao GridView
                    gridctdnx.VuviecId = cboVViec.Id
                    gridctdnx.KyHieuVuviec = cboVViec.KyHieu
                    gridctdnx.TenVuviec = cboVViec.TenVuviec
                    gridctdnx.MaVuviec = cboVViec.MaVuviec
                Case "KhoXuatId"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If (gridctdnx.HanghoaId = Null.NullGuid) Then
                    Else
                        gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                    End If
            End Select
            Try
                If e.Column.Name.Equals("ThueId") Then
                    Dim dmThue As DmThue = CType(cboDMthue.GetDataSourceRowByKeyValue(gridctdnx.ThueId), DmThue)
                    If dmThue IsNot Nothing Then
                        GrcHoaDonBanHang_View.SetRowCellValue(GrcHoaDonBanHang_View.FocusedRowHandle, "TyLeThueGtgt", dmThue.TyLe)
                        gridctdnx.TenThue = dmThue.TenThue
                    End If
                End If

                If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                    If e.Column.FieldName.Equals("DonGiaBanNte") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaBanNte * gridctdnx.SoLuong
                        gridctdnx.SoTienBanNte = Total
                        gridctdnx.SoTienBan = Total * Decimal.Parse(txtTY_GIA.Text)

                    End If

                    If e.Column.FieldName.Equals("DonGiaBanNte") Then
                        Dim GiaVND As Decimal = Decimal.Parse(txtTY_GIA.Text) * gridctdnx.DonGiaBanNte
                        gridctdnx.DonGiaBan = GiaVND
                    End If

                Else
                    If e.Column.FieldName.Equals("DonGiaBan") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaBan * gridctdnx.SoLuong
                        gridctdnx.SoTienBan = Total
                    End If
                End If
                If e.Column.FieldName.Equals("DonGiaBanNte") Or e.Column.FieldName.Equals("SoLuong") Then
                    Dim Total As Decimal = gridctdnx.DonGiaBanNte * gridctdnx.SoLuong
                    gridctdnx.SoTienBanNte = Total
                End If

                If e.Column.FieldName.Equals("SoLuong") Or e.Column.FieldName.Equals("DonGiaVon") Then
                    Dim Total As Decimal = gridctdnx.SoLuong * gridctdnx.DonGiaVon
                    gridctdnx.GiaVon = Total
                End If

                If String.IsNullOrEmpty(gridctdnx.SoTienBan) Or String.IsNullOrEmpty(gridctdnx.TyLeThueGtgt) Then
                Else
                    Dim Total As Decimal = gridctdnx.SoTienBan * gridctdnx.TyLeThueGtgt / 100
                    gridctdnx.SoTienThueGtgt = Decimal.Round(Total)
                End If
                TongTien()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào quá lớn!")
            End Try

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA.EditValueChanged
        Try
            Try

                For Each gridctdnx As CtDNx In lstobj_ct_d_nx
                    If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                        gridctdnx.SoTienBanNte = Decimal.Parse(gridctdnx.DonGiaBanNte) * Decimal.Parse(gridctdnx.SoLuong)
                        gridctdnx.SoTienBan = Decimal.Parse(gridctdnx.SoTienBanNte) * Decimal.Parse(txtTY_GIA.Text)
                        gridctdnx.DonGiaBan = Decimal.Parse(gridctdnx.DonGiaBanNte) * Decimal.Parse(txtTY_GIA.Text)
                    Else
                        gridctdnx.SoTienBan = Decimal.Parse(gridctdnx.DonGiaBan) * Decimal.Parse(gridctdnx.SoLuong)
                    End If

                    gridctdnx.SoTienBanNte = Decimal.Parse(gridctdnx.DonGiaBanNte) * Decimal.Parse(gridctdnx.SoLuong)

                    gridctdnx.SoTienThueGtgt = Decimal.Round(Decimal.Parse(gridctdnx.SoTienBan) * Decimal.Parse(gridctdnx.TyLeThueGtgt) / 100)
                    gridctdnx.GiaVon = Decimal.Round(Decimal.Parse(gridctdnx.DonGiaVon) * Decimal.Parse(gridctdnx.SoLuong))

                    TongTien()
                Next
            Catch ex As OverflowException
                Message_Warning("Giá trị quá lớn!")
            End Try

            GrcHoaDonBanHang_View.RefreshData()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        GrcHoaDonBanHang_View.Columns("DonGiaBanNte").Visible = ngoaite
        GrcHoaDonBanHang_View.Columns("SoTienBanNte").Visible = ngoaite
        GrcHoaDonBanHang_View.Columns("DonGiaBan").ColumnEdit.ReadOnly = ngoaite
        If (ngoaite) Then
            txtTY_GIA.Enabled = True
        Else
            txtTY_GIA.Enabled = False
        End If
    End Sub

    Private Sub chkNgoaiTe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNGOAI_TE.CheckedChanged
        Try
            SetColNgoaiTe(chkNGOAI_TE.Checked)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            AddHandler GrcHoaDonBanHang_View.RowCellStyle, AddressOf GrcHoaDonBanHang_View_RowCellStyle
            Me.ValidateChildren()

            ''check trang thai co thuoc quyen cua user hay ko
            If Not UR_STATUS.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If

            If obj_ct_h_nx Is Nothing Then
                obj_ct_h_nx = New CtHNx
            End If

            If obj_ct_h_nx.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            'Check khoa so thang
            If _KtKhoasoThangService.KiemTraKhoaSo(dteNGAY_CT.DateTime, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            ' goi ham check null cac gia tri cua form
            If Not CheckNull(lstobj_ct_d_nx) Then
                Exit Sub
            End If

            depCT_H_Nx.ClearErrors()
            If Not ValidateChildren(ValidationConstraints.Enabled) Then
                Return
            End If

            'Kiem tra so luong xuat kho
            Dim lst As List(Of DmKho) = New List(Of DmKho)()
            lst = cboMaKho.DataSource
            If Not (_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, lstobj_ct_d_nx, lst, Generals.DON_VI.Id)) Then
                Message_Warning("Kho không cho phép xuất âm")
                GrcHoaDonBanHang_View.RefreshData()
                Exit Sub
            End If

            If txtTienThue.Text Is Nothing Or txtTienThue.Text = "0" Then
            Else
                If (VnsCheck.IsNullGuid(GFilter_TKC_THUE_GTGT.ListEditValue(0))) Or (VnsCheck.IsNullGuid(GFilter_TKN_THUE_GTGT.ListEditValue(0))) Then
                    Message_Warning("Nhập tỷ lệ thuế nhưng không nhập tài khoản thuế")
                    Exit Sub
                End If
            End If
            If txtTaiKhoanChietKhau.Text Is Nothing Or txtTaiKhoanChietKhau.Text = "0" Then
            Else
                If (VnsCheck.IsNullGuid(GFilter_TKC_CK.ListEditValue(0))) Or (VnsCheck.IsNullGuid(GFilter_TKN_CK.ListEditValue(0))) Then
                    Message_Warning("Nhập tiền chiết khấu nhưng không nhập tài khoản chiết khấu")
                    Exit Sub
                End If
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            ckeNhapTienThue.Checked = False

            'Refresh left grid
            m_CTH_ID = obj_ct_h_nx.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h_nx)
            GridHelper.RefreshLeftGrid(grvLPX_Hnx, lstobj_ct_h_gg, editObject, m_InputState)

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
            RemoveHandler GrcHoaDonBanHang_View.RowCellStyle, AddressOf GrcHoaDonBanHang_View_RowCellStyle
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnThemMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            lstobj_ct_d_nx.Add(New CtDNx)
            GrcHoaDonBanHang_View.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteRow()
        Dim gridctdnx As CtDNx = CType(GrcHoaDonBanHang_View.GetRow(GrcHoaDonBanHang_View.FocusedRowHandle), CtDNx)
        del_lstobj_ct_d_nx.Add(gridctdnx)
        GrcHoaDonBanHang_View.DeleteSelectedRows()
        'Message_Information("Xóa thành công")
        TongTien()
    End Sub

    Private Sub GrcHoaDonBanHang_View_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrcHoaDonBanHang_View.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(GrcHoaDonBanHang_View)) Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        GrcHoaDonBanHang_View.RefreshData()
                        SetFocus_FirstCell()
                    End If
                Case Keys.F12
                    Dim FormID As String = Me.Name + "?" + "MA_LOAI_CT=" + m_MaCT
                    Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                    ConfigGrid.GetGridColInfo(GrcHoaDonBanHang_View, lstColInfo)
                    Dim f As New ConfigGrid
                    If f.Show_Form(GrcHoaDonBanHang_View.Name, FormID, lstColInfo) Then
                        ConfigGrid.GridConfig(FormID, GrcHoaDonBanHang_View.Name, GrcHoaDonBanHang_View)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Try
            Me.Close()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetFocus_FirstCell()
        GrcHoaDonBanHang_View.FocusedRowHandle = GrcHoaDonBanHang_View.RowCount - 1
        GrcHoaDonBanHang_View.SelectRow(Handle)
        Try
            GrcHoaDonBanHang_View.FocusedColumn = GrcHoaDonBanHang_View.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Try
                        If m_InputState <> DataInputState.ViewMode Then

                            lstobj_ct_d_nx.Add(New CtDNx)
                            SetFocus_FirstCell()
                            GrcHoaDonBanHang_View.RefreshData()
                        End If
                    Catch ex As Exception
                        Message_Error(ex)
                    End Try
                    Exit Select
                Case Keys.F8
                    If m_InputState <> DataInputState.ViewMode Then
                        If GrcHoaDonBanHang_View.RowCount <> 0 Then
                            DeleteRow()
                            TongTien()
                        Else
                            Message_Warning("Không có bản ghi nào được chọn!")
                        End If
                    End If
                    Exit Select
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
                    Exit Select
                Case e.Control And Keys.F11
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            TongTien()

            If obj_ct_h_nx.DaKhoaSo = 0 Then
                Try
                    m_InputState = DataInputState.EditMode
                    chkChietKhau.Checked = False
                    DatTrangThaiControl()
                Catch ex As Exception
                    Message_Error(ex)
                End Try
            Else
                Message_Information("Chứng từ đã được khóa nên không thể sửa!")
            End If

            grpSMQR.Focus()
            dteNGAY_CT.Focus()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Try
            'If m_InputState = DataInputState.AddMode Then
            If lstobj_ct_h_gg.Count > 0 Then

                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
                    grvLPX_Hnx.FocusedRowHandle = lstobj_ct_h_gg.Count - 1
                End If

                TongTien()
                SetObjectToControl()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If
            'End If
            DatTrangThaiControl()
            'PanelControl2.Focus()
            btnAdd.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler GrcHoaDonBanHang_View.RowCellStyle, AddressOf GrcHoaDonBanHang_View_RowCellStyle
            obj_ct_h_nx = New CtHNx
            objcthoadon = New CtHoadon
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            ClearPage()
            grpSMQR.Focus()
            dteNGAY_CT.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Sub ClearPage()
        Control_ClearData(grpSMQR)
        Control_ClearData(groupControl2)
        txtTEN_KHANG.Text = Nothing
        txtMST_KHANG.Text = Nothing
        txtDIA_CHI.Text = Nothing
        grlPHONGBAN_ID.EditValue = Nothing
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA.Text = "1"
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.Add(New CtDNx)
        GrcHoaDonBanHang.DataSource = lstobj_ct_d_nx
        GrcHoaDonBanHang_View.RefreshData()
        'txtGHI.Text = "1"
        'UR_STATUS.cboStatus.EditValue = 1
        UR_STATUS.Set_Status(1)
        grlID_LOAI_CT.EditValue = obj_lct.Id
        txtTienHang.EditValue = 0
        txtTienThue.EditValue = 0
        txtTaiKhoanChietKhau.EditValue = 0
        txtTong.EditValue = 0
        'BindLookUpNX()
        C_SO_CT_RP.Text = ""
        txtSO_SERI.Text = ""
        GFilter_TK.Tag = Null.NullGuid
        GFilter_TK.Text = ""
        GFilter.Text = ""
        GFilter.Tag = Null.NullGuid
        txtNGUOI_NHAN_NOP_TIEN.Text = ""
        txtDIEN_GIAI.Text = ""
        GFilter_TKC_THUE_GTGT.Text = ""
        GFilter_TKC_THUE_GTGT.Tag = Null.NullGuid
        GFilter_TKN_THUE_GTGT.Text = ""
        GFilter_TKN_THUE_GTGT.Tag = Null.NullGuid
        GFilter_TKC_CK.Text = ""
        GFilter_TKC_CK.Tag = Null.NullGuid
        GFilter_TKN_CK.Text = ""
        GFilter_TKN_CK.Tag = Null.NullGuid
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If Not UR_STATUS.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If
            'Check kho'a so? tha'ng
            If obj_ct_h_nx.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            'Dim state As New DataInputState
            'state = m_InputState
            If lstobj_ct_h_gg.Count > 0 Then
                If Not (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
                    Exit Sub
                End If

                _CtHNxService.DeleteChungTu(obj_ct_h_nx)

                m_CTH_ID = GridHelper.RemoveLeftGrid(lstobj_ct_h_gg, m_CTH_ID)
                If Not (m_CTH_ID = Null.NullGuid) Then
                    SetObjectToControl()
                End If
                'refresh lai data tren luoi
                grvLPX_Hnx.RefreshData()

                m_InputState = DataInputState.ViewMode
                DatTrangThaiControl()
            End If

            If lstobj_ct_h_gg.Count = 0 Then
                ClearPage()
                m_InputState = DataInputState.AddMode
                DatTrangThaiControl()
            End If
            btnAdd.Focus()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlID_LOAI_CT), HtLoaichungtu)
            Dim obj_form = CType(ObjectFactory.GetObject("frmKho_Input", New Object() {m_CTH_ID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkNGOAI_TE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkNGOAI_TE.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub checkEdit4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles checkEdit4.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub checkEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles checkEdit1.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub checkEdit3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkChietKhau.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub checkEdit2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckeNhapTienThue.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub EnterNext(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        Try
            Dim fr As frmTimKiemChungTuKho = ObjectFactory.GetObject("frmTimKiemChungTuKho")
            fr.MaCT = obj_lct.MaLoaiCt
            fr.ShowDialog()
            If fr.lstobj_ct_h_g.Count > 0 Then
                lstobj_ct_h_gg = fr.lstobj_ct_h_g
                Load_Grid(lstobj_ct_h_gg)
                m_CTH_ID = lstobj_ct_h_gg(0).Id
                SetObjectToControl()
                TongTien()
            Else
                'ClearPage()
            End If

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub checkEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEdit4.CheckedChanged
        Try
            SetColGiaVon(checkEdit4.Checked)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetColGiaVon(ByVal giavon As Boolean)
        If (giavon) Then
            GrcHoaDonBanHang_View.Columns("DonGiaVon").VisibleIndex = 10
            GrcHoaDonBanHang_View.Columns("GiaVon").VisibleIndex = 11
        Else
            GrcHoaDonBanHang_View.Columns("DonGiaVon").Visible = False
            GrcHoaDonBanHang_View.Columns("GiaVon").Visible = False
        End If
    End Sub

    Private Sub frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cboNgoaiTe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNgoaiTe.EditValueChanged
        Try
            If cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                txtTY_GIA.Text = "1"
                SetColNgoaiTe(False)
                If lstobj_ct_d_nx.Count > 0 Then
                    For Each objctdnx As CtDNx In lstobj_ct_d_nx
                        objctdnx.DonGiaBanNte = 0
                        objctdnx.DonGiaVonNte = 0
                        objctdnx.GiaVonNt = 0
                        objctdnx.SoTienBanNte = 0
                    Next
                    GrcHoaDonBanHang_View.RefreshData()
                End If
            Else
                If Not (OnLoadData) Then
                    txtTY_GIA.Text = _LsTygiaService.GetTyGiaNgoaiTe(cboNgoaiTe.EditValue, dteNGAY_CT.EditValue)
                End If
                SetColNgoaiTe(True)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly khi dang focus row hien tai cua luoi ben trai
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Try
            If (grvLPX_Hnx.RowCount <> 0) Then
                If (btnMod.Enabled = False) And ((m_InputState = DataInputState.AddMode) Or (m_InputState = DataInputState.EditMode)) Then
                    'SetObjectToControl()
                Else
                    If GetRowSelect() Then
                        SetObjectToControl()
                    End If
                End If
            Else
                'MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dteNGAY_CT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteNGAY_CT.EditValueChanged
        Try
            If dteNGAY_GHI Is Nothing Then
            Else
                dteNGAY_GHI.EditValue = dteNGAY_CT.EditValue
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.AfterFilter
        txtMST_KHANG.Text = GFilter.ListEditValue(4)
        txtTEN_KHANG.Text = GFilter.ListEditValue(1)
        txtDIA_CHI.Text = GFilter.ListEditValue(5)
        GFilter.Tag = VnsConvert.CGuid(GFilter.ListEditValue(0))
        If GFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub GFilter_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.ClearFilterData
        txtMST_KHANG.Text = ""
        txtTEN_KHANG.Text = ""
        'txtDIA_CHI.Text = ""
        GFilter.Tag = ""
    End Sub

    Private Sub GFilter_HANGHOA_ID_ClearFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.ClearDataFilter, GFilter_MA_TKC_GIABAN.ClearDataFilter, GFilter_MA_TKC_GIAVON.ClearDataFilter, GFilter_MA_TKN_GIAVON.ClearDataFilter
        Try

            Dim rowHandle As Integer = GrcHoaDonBanHang_View.FocusedRowHandle
            Dim columnName As String = GrcHoaDonBanHang_View.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(GrcHoaDonBanHang_View.GetRow(GrcHoaDonBanHang_View.FocusedRowHandle), CtDNx)
            Select Case columnName
                Case "HanghoaId"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        'Gan vao GridView
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MaTknGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TknGiavon = VnsConvert.CGuid(GFilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MaTkcGiaban"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKC_GIABAN.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TkcGiaban = VnsConvert.CGuid(GFilter_MA_TKC_GIABAN.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MaTkcGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_HANGHOA_ID_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.AfterFilter, GFilter_MA_TKC_GIABAN.AfterFilter, GFilter_MA_TKC_GIAVON.AfterFilter, GFilter_MA_TKN_GIAVON.AfterFilter
        Try
            Dim rowHandle As Integer = GrcHoaDonBanHang_View.FocusedRowHandle
            Dim columnName As String = GrcHoaDonBanHang_View.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(GrcHoaDonBanHang_View.GetRow(GrcHoaDonBanHang_View.FocusedRowHandle), CtDNx)
            Select Case columnName
                Case "HanghoaId"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        'Gan vao GridView
                        gridctdnx.TenHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(2)
                        gridctdnx.MaHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(3)
                        gridctdnx.KyHieuHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                        gridctdnx.TenDvt = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(4)
                        If (gridctdnx.KhoXuatId = Null.NullGuid) Then
                        Else
                            gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                        End If
                        Dim strMaTaiKhoan As String = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(5)
                        If String.IsNullOrEmpty(strMaTaiKhoan) Then
                        Else
                            Dim strMTK() As String = strMaTaiKhoan.Split(";")
                            strMaTaiKhoan = strMTK(0)
                            Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                            obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                            gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiavon = obj_taikhoan.Id
                        End If

                        strMaTaiKhoan = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(6)
                        If String.IsNullOrEmpty(strMaTaiKhoan) Then
                        Else
                            Dim strMTK1() As String = strMaTaiKhoan.Split(";")
                            strMaTaiKhoan = strMTK1(0)
                            Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                            obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                            gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TknGiavon = obj_taikhoan.Id
                        End If

                        strMaTaiKhoan = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(7)
                        If String.IsNullOrEmpty(strMaTaiKhoan) Then
                        Else
                            Dim strMTK2() As String = strMaTaiKhoan.Split(";")
                            strMaTaiKhoan = strMTK2(0)
                            Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                            obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                            gridctdnx.MaTkcGiaban = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiaban = obj_taikhoan.Id
                        End If
                    End If
                    GrcHoaDonBanHang_View.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa)
                Case "MaTknGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTknGiavon = GFilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TknGiavon = VnsConvert.CGuid(GFilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    GrcHoaDonBanHang_View.SetRowCellValue(rowHandle, "MaTknGiavon", gridctdnx.MaTknGiavon)
                Case "MaTkcGiaban"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKC_GIABAN.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTkcGiaban = GFilter_MA_TKC_GIABAN.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TkcGiaban = VnsConvert.CGuid(GFilter_MA_TKC_GIABAN.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    GrcHoaDonBanHang_View.SetRowCellValue(rowHandle, "MaTkcGiaban", gridctdnx.MaTkcGiaban)
                Case "MaTkcGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTkcGiavon = GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    GrcHoaDonBanHang_View.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon)
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_TK_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TK.AfterFilter
        GFilter_TK.Tag = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
        If GFilter_TK.IsNotTextChanged Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub GFilter_TK_ClearFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TK.ClearFilterData
        GFilter_TK.Tag = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
    End Sub

    Private Sub GFilter_TKC_THUE_GTGT_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKC_THUE_GTGT.AfterFilter
        GFilter_TKC_THUE_GTGT.Tag = VnsConvert.CGuid(GFilter_TKC_THUE_GTGT.ListEditValue(0))
        If GFilter_TKC_THUE_GTGT.IsNotTextChanged Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub GFilter_TKC_CK_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKC_CK.AfterFilter
        GFilter_TKC_CK.Tag = VnsConvert.CGuid(GFilter_TKC_CK.ListEditValue(0))
        If GFilter_TKC_CK.IsNotTextChanged Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub GFilter_TKN_THUE_GTGT_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKN_THUE_GTGT.AfterFilter
        GFilter_TKN_THUE_GTGT.Tag = VnsConvert.CGuid(GFilter_TKN_THUE_GTGT.ListEditValue(0))
        If GFilter_TKN_THUE_GTGT.IsNotTextChanged Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub GFilter_TKN_CK_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKN_CK.AfterFilter
        GFilter_TKN_CK.Tag = VnsConvert.CGuid(GFilter_TKN_CK.ListEditValue(0))
        If GFilter_TKN_CK.IsNotTextChanged Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub checkEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeNhapTienThue.CheckedChanged
        If ckeNhapTienThue.Checked = True Then
            txtTienThue.Enabled = True
            GrcHoaDonBanHang_View.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = False
        Else
            txtTienThue.Enabled = False
            GrcHoaDonBanHang_View.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = True
        End If
    End Sub

    Private Sub checkEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChietKhau.CheckedChanged
        If chkChietKhau.Checked = True Then
            txtTaiKhoanChietKhau.Enabled = True
        Else
            txtTaiKhoanChietKhau.Enabled = False
        End If
    End Sub

    'REPOSITORY IN GRID
    Private Sub MyRepositoryItem_FirstBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.FisrtBinddata
        Try
            Dim rowHandle As Integer = GrcHoaDonBanHang_View.FocusedRowHandle
            Dim columnName As String = GrcHoaDonBanHang_View.FocusedColumn().Name
            LoadDataInGrid(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadDataInGrid(ByVal colName As String)
        Select Case colName
            Case "HanghoaId"
                If GFilterEdit_HANGHOA_ID.C_DATA_SOURCE Is Nothing Then
                    If Kry_DATASOURE Is Nothing Then
                        GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
                    End If
                    GFilterEdit_HANGHOA_ID.Editors.A_DATA_SOURCE = GFilterEdit_HANGHOA_ID.C_DATA_SOURCE
                End If
            Case Else
        End Select
    End Sub

    'KHANG
    Private Sub GFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.FirstBinddata, GFilter.AfterQuickAdd
        Try
            'LoadDataInGroup(1)
            GFilter.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_TKN_CK_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKN_CK.ClearFilterData
        GFilter_TKN_CK.Tag = VnsConvert.CGuid(String.Empty)
        GFilter_TKN_CK.Text = ""
    End Sub

    Private Sub GFilter_TKC_CK_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKC_CK.ClearFilterData
        GFilter_TKC_CK.Tag = VnsConvert.CGuid(String.Empty)
        GFilter_TKC_CK.Text = ""
    End Sub

    Private Sub Gfilter_TKN_THUE_GTGT_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKN_THUE_GTGT.ClearFilterData
        GFilter_TKN_THUE_GTGT.Tag = VnsConvert.CGuid(String.Empty)
        GFilter_TKN_THUE_GTGT.Text = ""
    End Sub

    Private Sub Gfilter_TKC_THUE_GTGT_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TKC_THUE_GTGT.ClearFilterData
        GFilter_TKC_THUE_GTGT.Tag = VnsConvert.CGuid(String.Empty)
        GFilter_TKC_THUE_GTGT.Text = ""
    End Sub

    Private Sub txtTaiKhoanChietKhau_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaiKhoanChietKhau.TextChanged
        Try
            If Not chkChietKhau.Checked Then
                Exit Sub
            End If
            Try
                If String.IsNullOrEmpty(txtTong.EditValue) Or String.IsNullOrEmpty(txtTaiKhoanChietKhau.EditValue) Then
                Else
                    txtTong.EditValue = txtTienHang.EditValue + txtTienThue.EditValue - txtTaiKhoanChietKhau.EditValue
                End If
                Dim fn As PhanBoHelper = New PhanBoHelper
                Dim lst_phanBo As List(Of PhanBoHelperInfo) = New List(Of PhanBoHelperInfo)
                Dim obj_phanBo As PhanBoHelperInfo
                lst_phanBo.Clear()
                If Not String.IsNullOrEmpty(txtTaiKhoanChietKhau.Text) Then
                    ' txtTienCK.EditValue = Format(CLng(txtTienCK.Text), "n0")
                    For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                        obj_phanBo = New PhanBoHelperInfo
                        obj_phanBo.THU_TU = i
                        obj_phanBo.TONG_SO_TIEN = Decimal.Parse(txtTaiKhoanChietKhau.Text)
                        obj_phanBo.TIEN_PB = 0
                        obj_phanBo.SO_TIEN = lstobj_ct_d_nx(i).SoTienBan
                        obj_phanBo.HE_SO = 0
                        lst_phanBo.Add(obj_phanBo)
                    Next
                End If
                lst_phanBo = fn.PhanBo(lst_phanBo)

                For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                    For Each obj As PhanBoHelperInfo In lst_phanBo
                        If obj.THU_TU = i Then
                            lstobj_ct_d_nx(i).SoTienCk = obj.TIEN_PB
                            Exit For
                        End If
                    Next
                Next
                GrcHoaDonBanHang_View.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Sua tien thue
    Private Sub txtTienThue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTienThue.TextChanged
        Try
            If Not ckeNhapTienThue.Checked Then
                Return
            End If

            If txtTienThue.Text = "" Or txtTienHang.Text = "" Then
                Return
            End If

            Dim Tien_Thue As Decimal = Decimal.Parse(txtTienThue.Text)
            Dim Tien_hang As Decimal = Decimal.Parse(txtTienHang.Text)
            Dim Tien_CK As Decimal = 0
            If txtTaiKhoanChietKhau.Text <> "" Then
                Tien_CK = Decimal.Parse(txtTaiKhoanChietKhau.Text)
            End If
            'Sua tien thue
            Try
                'Tính lại tổng TT
                txtTong.EditValue = Tien_hang + Tien_Thue - Tien_CK
                'Phân bổ           
                Dim fn As PhanBoHelper = New PhanBoHelper
                Dim lst_phanBo As List(Of PhanBoHelperInfo) = New List(Of PhanBoHelperInfo)
                Dim obj_phanBo As PhanBoHelperInfo
                lst_phanBo.Clear()
                For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                    obj_phanBo = New PhanBoHelperInfo
                    obj_phanBo.THU_TU = i
                    obj_phanBo.TONG_SO_TIEN = Tien_Thue
                    obj_phanBo.TIEN_PB = 0
                    obj_phanBo.SO_TIEN = lstobj_ct_d_nx(i).SoTienBan
                    obj_phanBo.HE_SO = 0
                    lst_phanBo.Add(obj_phanBo)
                Next

                lst_phanBo = fn.PhanBo(lst_phanBo)

                For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                    For Each obj As PhanBoHelperInfo In lst_phanBo
                        If obj.THU_TU = i Then
                            lstobj_ct_d_nx(i).SoTienThueGtgt = obj.TIEN_PB
                            lstobj_ct_d_nx(i).TyLeThueGtgt = Tien_Thue / Tien_hang * 100
                            Exit For
                        End If
                    Next
                Next
                GrcHoaDonBanHang_View.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub GrcHoaDonBanHang_View_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = GrcHoaDonBanHang_View.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "KyHieuHanghoa"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "MaTkcGiaban"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "MaTknGiavon"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "SoLuong"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "DonGiaBan"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "KhoXuatId"
                    If VnsCheck.IsNullGuid(VnsConvert.CGuid(val.ToString)) Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class