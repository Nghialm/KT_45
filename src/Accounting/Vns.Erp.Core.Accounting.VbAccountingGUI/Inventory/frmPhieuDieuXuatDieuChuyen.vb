Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports DevExpress.Utils

Public Class PhieuDieuXuatDieuChuyen

#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Private _CtHNxService As ICtHNxService
    Public Property CtHNxService As ICtHNxService
        Get
            Return _CtHNxService
        End Get
        Set(ByVal value As ICtHNxService)
            _CtHNxService = value
        End Set
    End Property

    Private _CtDNxService As ICtDNxService
    Public Property CtDNxService As ICtDNxService
        Get
            Return _CtDNxService
        End Get
        Set(ByVal value As ICtDNxService)
            _CtDNxService = value
        End Set
    End Property

    Private _DmKhoService As IDmKhoService
    Public Property DmKhoService As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property

    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService

        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService As IDmVuviecService

        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
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

    Private _LsTygiaService As ILsTygiaService
    Public Property LsTygiaService As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(ByVal value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property

    Private _DmHanghoaService As IDmHanghoaService
    Public Property DmHanghoaService As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property

    Private _KtKhoasoThangService As IKtKhoasoThangService
    Public Property KtKhoasoThangService As KtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As KtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"

    'Private originEntity As DBLogParamInfo = New DBLogParamInfo()

    Dim CTHNXID As Guid
    Dim mCTHNXID As Guid
    Dim m_Ma_Loai_CT As String
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()

    ''' <summary>
    '''  khai bao 1 obj de Set,Get data tren form cua bang CT_H_NX va insert,update
    ''' </summary>
    ''' <remarks></remarks>
    Private obj_ct_h_nx As CtHNx = New CtHNx()

    ''' <summary>
    ''' khai bao 1 list obj de chua cac obj la cac record trong bang CT_D_NX dung de su ly insert,update
    ''' </summary>
    ''' <remarks></remarks>
    Private lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)

    ''' <summary>
    ''' khai bao 1 list obj chua cac record delete cua bang CT_D_NX
    ''' </summary>
    ''' <remarks></remarks>
    Private del_lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)

    ''' <summary>
    ''' khai bao bien kieu truyen vao cua trang thai tu ben list
    ''' </summary>
    ''' <remarks></remarks>
    Private m_InputState As FormGlobals.DataInputState

    ''' <summary>
    ''' khai bao 1 list obj chua list obj da dc conver
    ''' </summary>
    ''' <remarks></remarks>
    Private lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)

    Private Kry_DATASOURE As DataTable
    Private Ji_DATASOURE As DataTable
    Private closeForm As Boolean = False
    Private OnLoadData = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"

#End Region

#Region "Load form"

    ''' <summary>
    ''' ham xet icon cho cac button
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        urcGhi.Visible = Generals.Ts_PheDuyetChungTu
        urcGhi.Enabled = Generals.Ts_PheDuyetChungTu
        'Validate control
        Commons.RequireInputControls = New Control() {dteNGAY_CT, dteNGAY_GHI, cboKhoNhap, cboKhoXuat}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub


    ''' <summary>
    ''' xu ly load form
    ''' </summary>
    ''' <param name="ID_CT"></param>
    ''' <param name="eState"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Show_Form(ByVal ID_CT As Guid, ByVal Ma_Loai_CT As String, ByVal Ten_Loai_CT As String, ByVal lstCTH_G As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As Boolean
        Try
            'hien thi header cua form
            Form_SetText(Me, "Phiếu điều chuyển", eState)
            Form_InitDialog(Me)

            'gan cho bien trang thai cua form
            m_InputState = eState

            'lay ID duoc truyen vao
            mCTHNXID = ID_CT
            m_Ma_Loai_CT = Ma_Loai_CT

            obj_loaichungtu = HtLoaichungtuService.GetByMA_LOAI_CT(Ma_Loai_CT, Generals.DON_VI.Id)
            urcGhi.LCT_STATUS = obj_loaichungtu.Id

            If lstCTH_G IsNot Nothing Then
                lstobj_ct_h_gg = lstCTH_G
            End If

            'xet cac gia tri not null
            'Control_SetRequire(grlMA_KHANG, True)
            'Control_SetRequire(dteNGAY_GHI, True)

            'goi ham xu ly
            frmProgress.Instance.Thread = AddressOf InitForm
            frmProgress.Instance.Show_Progress()
            AddHandler grvLPX_Hnx.FocusedRowChanged, AddressOf grvLPX_Hnx_FocusedRowChanged

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

#End Region

#Region "Private Function and Procedures"
    ''' <summary>
    ''' khoi xu ly form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        Try
            '
            InitControl()
            ' 
            InitData()

            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' khoi xu ly control 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitControl()
        '
        BindLoookUpNX()

    End Sub

    ''' <summary>
    ''' khoi xu ly data tren form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitData()
        Try
            OnLoadData = True
            Select Case m_InputState
                Case DataInputState.AddMode
                    ' dat gia tri mac dinh khi them moi
                    m_InputState = DataInputState.AddMode
                    'grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx
                    DatTrangThaiControl()
                    'txtCT_SO.Text = Nothing
                    'txtCT_SO.Properties.ReadOnly = True
                    ClearPage()
                    ConfigGrid.GridConfig(Me.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen)
                    SetControlKho()

                Case DataInputState.EditMode
                    DatTrangThaiControl()
                    'goi ham load data len form theo trang thai edit
                    SetObjectToControl()
                    'Load_Grid()
            End Select

            AddHandler grlLoaiPhieuNhap.EditValueChanged, AddressOf grlLoaiPhieuNhap_EditValueChanged

            Load_Grid(lstobj_ct_h_gg)
        Catch ex As Exception
            Message_Error(ex)
        End Try
        OnLoadData = False
    End Sub

    ''' <summary>
    ''' bind du lieu vao cac comobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindLoookUpNX()
        Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Gfilter_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
        Gfilter_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE

        'GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
        'GFilter.C_DATA_SOURCE = DM_KhangBO.Instance().GetAllBy_CO_SU_DUNG_DS(Generals.DON_VI.DONVI_ID.Replace("-", "")).Tables(0)
        ' Bind loại chứng từ
        Dim listLCTu As List(Of HtLoaichungtu) = HtLoaichungtuService.LikeObjetMA_LOAI_CT(m_Ma_Loai_CT, Generals.DonviID)
        grlLoaiPhieuNhap.Properties.DataSource = listLCTu
        grlLoaiPhieuNhap.Properties.DisplayMember = "KyHieu"
        grlLoaiPhieuNhap.Properties.ValueMember = "MaLoaiCt"
        TNCommon.SelectFirst(grlLoaiPhieuNhap)

        'Bind ngoai te
        Dim lstNgoaite As List(Of DmNgoaite) = _DmNgoaiteService.GetAllByDonviID(Generals.DonviID)
        cboTyGia.Properties.DisplayMember = "KyHieu"
        cboTyGia.Properties.ValueMember = "Id"
        cboTyGia.Properties.DataSource = lstNgoaite
        cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA.Text = "1"

        'Bind TK No
        Dim lstTKNo As List(Of DmTaikhoan) = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        cboTKno.DataSource = lstTKNo
        cboTKno.DisplayMember = "MaTaiKhoan"
        cboTKno.ValueMember = "Id"
        cboTKno.Columns.Add(New LookUpColumnInfo("MaTaiKhoan", "Mã tài khoản"))
        cboTKno.Columns.Add(New LookUpColumnInfo("TenTaiKhoan", "Tên tài khoản"))

        'Bind TK Có
        Dim lstTKCo As List(Of DmTaikhoan) = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        cboTKco.DataSource = lstTKCo
        cboTKco.DisplayMember = "MaTaiKhoan"
        cboTKco.ValueMember = "Id"
        cboTKco.Columns.Add(New LookUpColumnInfo("MaTaiKhoan", "Mã tài khoản"))
        cboTKco.Columns.Add(New LookUpColumnInfo("TenTaiKhoan", "Tên tài khoản"))

        'Bind kho
        Dim lstMaKho As List(Of DmKho) = _DmKhoService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstMaKhoXuat As List(Of DmKho) = lstMaKho

        cboKhoNhap.Properties.DataSource = lstMaKho
        cboKhoNhap.Properties.DisplayMember = "KyHieu"
        cboKhoNhap.Properties.ValueMember = "Id"

        cboKhoXuat.Properties.DataSource = lstMaKhoXuat
        cboKhoXuat.Properties.DisplayMember = "KyHieu"
        cboKhoXuat.Properties.ValueMember = "Id"

        ''Bind mã kho nhập
        cboMaKhoNhap.DataSource = lstMaKho
        cboMaKhoNhap.DisplayMember = "KyHieu"
        cboMaKhoNhap.ValueMember = "Id"
        cboMaKhoNhap.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã kho nhập"))
        cboMaKhoNhap.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

        ''Bind mã kho xuất
        cboMaKhoXuat.DataSource = lstMaKhoXuat
        cboMaKhoXuat.DisplayMember = "KyHieu"
        cboMaKhoXuat.ValueMember = "Id"
        cboMaKhoXuat.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã kho xuất"))
        cboMaKhoXuat.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

        'Bind vụ việc
        Dim lstVuViecTemp As List(Of DmVuviec) = DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstVuviec As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim objvuviec As DmVuviec = New DmVuviec
        lstVuviec.Add(objvuviec)
        lstVuviec.AddRange(lstVuViecTemp)
        cboVuViec.DataSource = lstVuviec
        cboVuViec.DisplayMember = "KyHieu"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))

    End Sub

    ''' <summary>
    ''' ham xu ly load form danh sach
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Load_Grid(ByVal lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo))

        If lstobj_ct_h_gg IsNot Nothing And lstobj_ct_h_gg.Count > 0 Then
            grcLPN_Hnx.DataSource = lstobj_ct_h_gg
            For i = 0 To lstobj_ct_h_gg.Count - 1
                If mCTHNXID = lstobj_ct_h_gg(i).Id Then
                    Me.grvLPX_Hnx.FocusedRowHandle = i
                    Exit For
                End If
            Next
        End If

    End Sub

    ''' <summary>
    ''' lay ID cua row dang focus
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetRowSelect() As Boolean
        If (grvLPX_Hnx.GetSelectedRows().Length > 0) Then
            If (grvLPX_Hnx.RowCount <> 0) Then
                Dim grtCTH_NX As Extend.CT_H_GInfo = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows(0)), Extend.CT_H_GInfo)
                ' DMBTKC = grtCTH_NX
                mCTHNXID = grtCTH_NX.Id
                Return True
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' ham xu ly lay data tren form de insert va update
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetControlToOBject()
        Try
            'lay nhieu gia tri trong 1 table khac
            Dim drLPNhap As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)

            'lay cac truogn con thieu 
            obj_ct_h_nx.TyGia = txtTY_GIA.Text.Trim()
            obj_ct_h_nx.MaNte = cboTyGia.Text
            obj_ct_h_nx.NteId = cboTyGia.EditValue
            obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(Not (cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))

            obj_ct_h_nx.NguoiGiaoNhanHang = txtNGUOI_GIAO_NHAN_HANG.Text
            obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text
            obj_ct_h_nx.NgayGhi = dteNGAY_GHI.DateTime
            obj_ct_h_nx.NgayCt = dteNGAY_CT.DateTime
            obj_ct_h_nx.NgayTao = DateTime.Now
            'obj_ct_h_nx.CT_SO = txtCT_SO.Text
            obj_ct_h_nx.DonviId = Generals.DON_VI.Id
            obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
            obj_ct_h_nx.Ghi = Decimal.Parse(urcGhi.Value_info.ParameterValue)
            obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt
            obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu
            obj_ct_h_nx.IdLoaiCt = drLPNhap.Id
            obj_ct_h_nx.SoDu = 0

            Dim flgUpdate = True
            'Xử lý insert,update
            Select Case m_InputState
                Case DataInputState.AddMode
                    Dim strmMonth As String
                    strmMonth = Month(dteNGAY_CT.DateTime).ToString
                    Dim strYear As String
                    strYear = Year(dteNGAY_CT.DateTime).ToString

                    C_SoChungTu_RP.r_SoCTPREFIX(obj_loaichungtu.Id, strmMonth, strYear, Generals.DON_VI.Id)
                    obj_ct_h_nx.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                    obj_ct_h_nx.PrefixCt = C_SoChungTu_RP.PREFIX
                    flgUpdate = False
                Case Else
            End Select
            'lay gia trị control tren luoi gan cho obj
            For Each objctdnx As CtDNx In lstobj_ct_d_nx
                'objctdnx.CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID
                'objctdnx.NGAY_TAO = DateTime.Now
                objctdnx.Xuat = drLPNhap.KhoXuat
                '
                objctdnx.IdKhang = obj_ct_h_nx.KhangId
                objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang
                objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang
                objctdnx.ThuTu = 0
            Next

            _CtHNxService.SaveChungTuKho(flgUpdate, obj_ct_h_nx, lstobj_ct_d_nx, del_lstobj_ct_d_nx)
            'Gán lại số chứng từ sau khi lưu xong
            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt.ToString + obj_ct_h_nx.CtSo.ToString
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' ham xu ly load data len form theo ID tuong ung
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetObjectToControl()
        Try
            obj_ct_h_nx = CtHNxService.GetById(mCTHNXID)
            If obj_ct_h_nx Is Nothing Then
                closeForm = True
                Return
            Else
                closeForm = False
            End If

            grlLoaiPhieuNhap.EditValue = obj_ct_h_nx.MaLoaiCt

            Dim objLoaiCT As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)
            txtNGUOI_GIAO_NHAN_HANG.Text = obj_ct_h_nx.NguoiGiaoNhanHang
            txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai
            dteNGAY_CT.DateTime = obj_ct_h_nx.NgayCt
            dteNGAY_GHI.DateTime = obj_ct_h_nx.NgayGhi
            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt.ToString + obj_ct_h_nx.CtSo.ToString
            cboTyGia.EditValue = obj_ct_h_nx.NteId
            txtTY_GIA.Text = obj_ct_h_nx.TyGia

            urcGhi.Set_Status(obj_ct_h_nx.Ghi)
            urcGhi.cboStatus.EditValue = obj_ct_h_nx.Ghi.ToString

            lstobj_ct_d_nx = CtDNxService.GetObjectByCTHId(mCTHNXID)

            grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx
            TongTien()
            '
            ConfigGrid.GridConfig(Me.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen)
            SetControlKho()

            If cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                SetColNgoaiTe(False)
            Else
                SetColNgoaiTe(True)
            End If

            If objLoaiCT.DmCbnv = 1 Then
                If (Not lstobj_ct_d_nx Is Nothing And lstobj_ct_d_nx.Count > 0) Then
                    cboKhoNhap.EditValue = lstobj_ct_d_nx(0).KhoNhapId
                    cboKhoXuat.EditValue = lstobj_ct_d_nx(0).KhoXuatId
                End If
            End If

            ''Kiểm tra trạng thái có cho phép sửa hay không
            If Not (urcGhi.ChoPhepSuaCT) Then
                urcGhi.Enabled = False
            Else
                urcGhi.Enabled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' ham xet trang thai control tren form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                Control_SetState(GroupControl1, DataInputState.AddMode)
                Control_SetState(GroupControl2, DataInputState.AddMode)
                grvPhieuDieuChuyen.OptionsBehavior.Editable = True
                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = False
                btnPri.Enabled = False
                navWelding1.Enabled = False
                btnCan.Enabled = True
                grcLPN_Hnx.Enabled = False
                'txtCT_SO.Properties.ReadOnly = True
                grlLoaiPhieuNhap.Properties.ReadOnly = False
                navWelding1.Enabled = False
            Case DataInputState.EditMode
                Control_SetState(GroupControl1, DataInputState.EditMode)
                Control_SetState(GroupControl2, DataInputState.EditMode)
                grvPhieuDieuChuyen.OptionsBehavior.Editable = True
                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = True
                navWelding1.Enabled = False
                btnPri.Enabled = True
                btnCan.Enabled = True
                grcLPN_Hnx.Enabled = False
                'txtCT_SO.Properties.ReadOnly = True
                grlLoaiPhieuNhap.Properties.ReadOnly = True
                navWelding1.Enabled = False
            Case Else
                Control_SetState(GroupControl1, DataInputState.ViewMode)
                Control_SetState(GroupControl2, DataInputState.ViewMode)
                grvPhieuDieuChuyen.OptionsBehavior.Editable = False
                btnAdd.Enabled = True
                btnMod.Enabled = True
                btnSav.Enabled = False
                btnPri.Enabled = True
                navWelding1.Enabled = True
                btnDel.Enabled = True
                btnCan.Enabled = False
                grcLPN_Hnx.Enabled = True
                grlLoaiPhieuNhap.Properties.ReadOnly = True
                navWelding1.Enabled = True
        End Select
        GroupControl1.Focus()
        grlLoaiPhieuNhap.Focus()
    End Sub

    ''' <summary>
    ''' ham kiem tra null cua form
    ''' </summary>
    ''' <param name="lstobj_ct_d_nx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckNull(ByVal lstobj_ct_d_nx As List(Of CtDNx)) As Boolean

        ' kiem tra null cua comobox ma khach
        'kiem tra null cua comobox ngay hach toan
        If (dteNGAY_GHI.DateTime = Nothing) Then
            Message_Warning("Bạn chưa nhập ngày hạch toán")
            dteNGAY_GHI.Focus()
            Return False
        End If

        If (dteNGAY_GHI.DateTime.Date > dteNGAY_CT.DateTime.Date) Then
            Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ")
            dteNGAY_GHI.Focus()
            Return False
        End If

        If LimitValue.CheckTyGia(Decimal.Parse(txtTY_GIA.Text.Trim)) = False Then
            Message_Warning("Tỷ giá không hợp lệ")
            txtTY_GIA.Focus()
            Return False
        End If

        'vong lap kiem tra cac cot tren luoi
        If grvPhieuDieuChuyen.RowCount <> 0 Then
            'Try
            Dim _KhoNhapID As Guid = New Guid
            Dim _KhoXuatID As Guid = New Guid
            If (cboKhoNhap.Visible) Then
                _KhoNhapID = VnsConvert.CGuid(cboKhoNhap.EditValue)
                _KhoXuatID = VnsConvert.CGuid(cboKhoXuat.EditValue)
            Else
                _KhoNhapID = Null.NullGuid
                _KhoXuatID = Null.NullGuid
            End If
            'vong lap kiem tra cac cot tren luoi
            For Each objctd As CtDNx In lstobj_ct_d_nx

                'kiem tra gia tri null cua cot Hang hoa
                If Guid.Empty = objctd.HanghoaId Then
                    Message_Warning("Bạn chưa nhập mã hàng hóa")
                    Return False
                End If

                'kiem tra gia tri null cua cot kho nhap
                objctd.KhoNhapId = IIf(_KhoNhapID = Null.NullGuid, objctd.KhoNhapId, _KhoNhapID)
                If Guid.Empty = objctd.KhoNhapId Then
                    Message_Warning("Bạn chưa lựa chọn kho nhập")
                    Return False
                End If

                'kiem tra gia tri null cua cot kho xuat
                objctd.KhoXuatId = IIf(_KhoXuatID = Null.NullGuid, objctd.KhoXuatId, _KhoXuatID)
                If Guid.Empty = objctd.KhoXuatId Then

                    Message_Warning("Bạn chưa lựa chọn kho xuất")
                    Return False
                End If

                If (objctd.KhoNhapId = objctd.KhoXuatId) Then
                    Message_Warning("Kho nhập không được bằng kho xuất")
                    Return False
                End If

                'kiem tra gia tri cua cot so luong
                If objctd.SoLuong = 0 Then
                    Message_Warning("Bạn chưa nhập số lượng")
                    Return False
                End If

                'kiem tra gia tri cua cot don gia
                If objctd.DonGiaVon = 0 Then
                    Message_Warning("Bạn chưa nhập đơn giá")
                    Return False
                End If

                If LimitValue.CheckCurrency(objctd.GiaVon) = False Then
                    Message_Warning("Giá vốn không hợp lệ")
                    Return False
                End If

                ' kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                If String.IsNullOrEmpty(objctd.MaTkcGiavon) Or String.IsNullOrEmpty(objctd.MaTkcGiavon) Then
                    Message_Warning("Bạn chưa nhập tài khoản có giá vốn")
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
    ''' xu ly khi kick vao btn add 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler grvPhieuDieuChuyen.RowCellStyle, AddressOf grvPhieuDieuChuyen_RowCellStyle
            obj_ct_h_nx = New CtHNx
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()

            ClearPage()

            'originEntity = New DBLogParamInfo()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly khi kick vao btn Sua
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            If obj_ct_h_nx.DaKhoaSo = 0 Then
                m_InputState = DataInputState.EditMode

                DatTrangThaiControl()

                TongTien()

            Else
                Message_Information("Chứng từ đã được khóa nên không thể sửa!")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly del 1 row khi kick vao btn delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If Not urcGhi.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If
            'Check kho'a so? tha'ng
            If obj_ct_h_nx.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If
            If lstobj_ct_h_gg.Count > 0 Then
                If Not (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
                    Exit Sub
                End If

                CtHNxService.DeleteChungTu(obj_ct_h_nx)

                mCTHNXID = Vns.Erp.Core.Accounting.VbAccountingGUI.GridHelper.RemoveLeftGrid(lstobj_ct_h_gg, mCTHNXID)
                If Not Guid.Empty = mCTHNXID Then
                    SetObjectToControl()
                End If

                'refresh lai data tren luoi
                grvLPX_Hnx.RefreshData()

                m_InputState = DataInputState.ViewMode
                'DatTrangThaiControl()
            End If

            If lstobj_ct_h_gg.Count = 0 Then
                ClearPage()
                m_InputState = DataInputState.AddMode
                grlLoaiPhieuNhap.Focus()
            End If
            'btnAdd.Focus()
            DatTrangThaiControl()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly khi kick vao btn Luu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            AddHandler grvPhieuDieuChuyen.RowCellStyle, AddressOf grvPhieuDieuChuyen_RowCellStyle
            Me.ValidateChildren()

            ''check trang thai co thuoc quyen cua user hay ko
            If Not urcGhi.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If

            ' goi ham check null cac gia tri cua form
            If Not CheckNull(lstobj_ct_d_nx) Then
                Exit Sub
            End If

            If obj_ct_h_nx.DaKhoaSo = 1 Then
                Exit Sub
                Message_Information("Chứng từ này đã được khóa sổ")
            End If

            Dim intYear As Integer = Decimal.Parse(Year(dteNGAY_CT.DateTime).ToString)
            'Dim objKtKhoaSo As KtKhoasoThang = New KtKhoasoThang
            'objKtKhoaSo = KT_Khoaso_ThangBO.Instance.GetByNam(intYear, Generals.DON_VI.DONVI_ID.Replace("-", ""))

            'Check khoa so thang
            'Dim ktKhoasoThangService As KtKhoasoThangService = New KtKhoasoThangService()
            If _KtKhoasoThangService.KiemTraKhoaSo(dteNGAY_CT.DateTime, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            'Try
            Dim _KhoNhapID As Guid
            Dim _KhoXuatID As Guid
            If Not (cboKhoNhap.Visible) Then
                _KhoNhapID = cboKhoNhap.EditValue
                _KhoXuatID = cboKhoXuat.EditValue
            Else
                _KhoNhapID = Guid.Empty
                _KhoXuatID = Guid.Empty
            End If

            For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                Dim objKho As DmKho = New DmKho
                If Guid.Empty = _KhoXuatID Then
                    objKho = CType(cboMaKhoXuat.GetDataSourceRowByKeyValue(lstobj_ct_d_nx(i).KhoXuatId), DmKho)
                Else
                    lstobj_ct_d_nx(i).KhoNhapId = _KhoNhapID
                    lstobj_ct_d_nx(i).KhoXuatId = _KhoXuatID
                End If
            Next

            Dim lst As List(Of DmKho) = New List(Of DmKho)()
            lst = cboKhoXuat.Properties.DataSource
            If Not (_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, lstobj_ct_d_nx, lst, Generals.DON_VI.Id)) Then
                Message_Warning("Không cho phép xuất âm")
                grvPhieuDieuChuyen.RefreshData()
                Exit Sub
            End If

            'goi ham xu ly data tren form
            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            mCTHNXID = obj_ct_h_nx.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h_nx)
            GridHelper.RefreshLeftGrid(grvLPX_Hnx, lstobj_ct_h_gg, editObject, m_InputState)

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
            btnAdd.Focus()
            RemoveHandler grvPhieuDieuChuyen.RowCellStyle, AddressOf grvPhieuDieuChuyen_RowCellStyle
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TinhSoTonKho(ByRef objNX As CtDNx)
        If Not Guid.Empty = objNX.HanghoaId And Not Guid.Empty = objNX.KhoXuatId Then
            objNX.TonKho = CtDNxService.TinhSLTonKho(objNX.Id, dteNGAY_CT.EditValue, objNX.HanghoaId, objNX.KhoXuatId, Generals.DON_VI.Id)
        End If
    End Sub

    ''' <summary>
    ''' xu ly tiem kiem 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        Try
            Dim fr As frmTimKiemChungTuKho = ObjectFactory.GetObject("frmTimKiemChungTuKho")
            fr.MaCT = obj_loaichungtu.MaLoaiCt
            fr.ShowDialog()
            If fr.lstobj_ct_h_g.Count > 0 Then
                '
                lstobj_ct_h_gg = fr.lstobj_ct_h_g
                mCTHNXID = lstobj_ct_h_gg(0).Id

                Load_Grid(lstobj_ct_h_gg)
                '
                SetObjectToControl()
                TongTien()
            End If

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
            'txtCT_SO.Properties.ReadOnly = True
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly khi kick vao btn Huy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Try
            If lstobj_ct_h_gg.Count > 0 Then
                If m_InputState = DataInputState.AddMode Then
                    mCTHNXID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
                    grvLPX_Hnx.FocusedRowHandle = lstobj_ct_h_gg.Count - 1
                End If
                SetObjectToControl()
                TongTien()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If
            DatTrangThaiControl()
            btnAdd.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly khi kick vao btn In phieu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)
            Dim obj_form = CType(ObjectFactory.GetObject("frmKho_Input", New Object() {mCTHNXID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly xoa toan bo data tren form
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearPage()

        Control_ClearData(GroupControl1)
        Control_ClearData(GroupControl2)
        C_SoChungTu_RP.Text = ""

        dteNGAY_GHI.EditValue = Nothing
        'cboTyGia.ItemIndex = 2
        txtTY_GIA.Text = 1
        txtTongSL.Text = Nothing
        TxtTongTien.Text = Nothing
        '
        'urcGhi.cboStatus.EditValue = "1"
        urcGhi.Set_Status(1)
        dteNGAY_CT.EditValue = DateTime.Now
        dteNGAY_GHI.EditValue = DateTime.Now
        'txtTongSL.Enabled = False
        'TxtTongTien.Enabled = False
        ' SplitContainerControl1.Panel2.MinimumSize = 950
        TNCommon.SelectFirst(grlLoaiPhieuNhap)
        'grlLoaiPhieuNhap.EditValue = m_Ma_Loai_CT
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.Add(New CtDNx)
        grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx
        grvPhieuDieuChuyen.RefreshData()

    End Sub

    ''' <summary>
    ''' ham tinh tong tien cot trong luoi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TongTien()
        Dim sumTongTien As Decimal
        Dim sumTongSoLuong As Decimal
        Dim i As Integer
        For i = 0 To grvPhieuDieuChuyen.RowCount - 1
            Dim tmpCtDNx As CtDNx = CType(grvPhieuDieuChuyen.GetRow(i), CtDNx)
            sumTongTien = sumTongTien + tmpCtDNx.GiaVon
            sumTongSoLuong = sumTongSoLuong + tmpCtDNx.SoLuong
        Next
        'TxtTongTien.EditValue = Format(CLng(sumTongTien.ToString), "n0")
        'txtTongSL.EditValue = Format(CLng(sumTongSoLuong.ToString), "n0")
        TxtTongTien.EditValue = sumTongTien
        txtTongSL.EditValue = sumTongSoLuong
    End Sub

    ''' <summary>
    ''' ham xu ly delete record
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DeleteRow()
        If grvPhieuDieuChuyen.RowCount > 0 Then
            Dim gridctdnx As CtDNx = CType(grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle), CtDNx)
            del_lstobj_ct_d_nx.Add(gridctdnx)
            grvPhieuDieuChuyen.DeleteSelectedRows()
            TongTien()
        Else
            Message_Warning("Không có bản ghi nào được chọn!")
        End If

        ' Message_Information("Xóa thành công")
    End Sub

    ''' <summary>
    ''' xu ly btn dong
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Events"

    ''' <summary>
    ''' xu ly ... khi dang focus row hien tai
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvLPX_Hnx.FocusedRowChanged
        Try
            If (m_InputState = DataInputState.EditMode) And (btnMod.Enabled = False) Then
                'SetObjectToControl()
            ElseIf (m_InputState = DataInputState.AddMode) And (btnMod.Enabled = False) Then
                Return
            Else
                If GetRowSelect() Then
                    SetObjectToControl()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly su kien enter xuong dong trong luoi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuDieuChuyen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvPhieuDieuChuyen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(grvPhieuDieuChuyen)) Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        grvPhieuDieuChuyen.RefreshData()
                        SetFocus_FirstCell()
                    End If
            End Select
            '
            If e.KeyCode = Keys.F12 Then
                Dim FormID As String = Me.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT
                Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                ConfigGrid.GetGridColInfo(grvPhieuDieuChuyen, lstColInfo)
                Dim f As New ConfigGrid
                If f.Show_Form(grvPhieuDieuChuyen.Name, FormID, lstColInfo) Then
                    ConfigGrid.GridConfig(FormID, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly gan cac gia tri vao gridview 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuDieuChuyen_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvPhieuDieuChuyen.CellValueChanged
        Try
            Dim gridctdnx As CtDNx = CType(grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle), CtDNx)
            Select Case e.Column.Name
                Case "KHO_NHAP_ID"
                    Dim cboKhoNhap As DmKho = CType(cboMaKhoNhap.GetDataSourceRowByKeyValue(gridctdnx.Id), DmKho)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If

                Case "TKN_GIAVON"
                    Dim cboTKNGiaVon As DmTaikhoan = CType(cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TknGiavon), DmTaikhoan)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    'gan vao grid
                    gridctdnx.MaTknGiavon = cboTKNGiaVon.MaTaikhoan

                Case "TKC_GIAVON"
                    Dim cboTKCGiaVon As DmTaikhoan = CType(cboTKco.GetDataSourceRowByKeyValue(gridctdnx.TkcGiavon), DmTaikhoan)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    'gan vao grid
                    gridctdnx.MaTkcGiavon = cboTKCGiaVon.MaTaikhoan

                Case "VUVIEC_ID"
                    Dim cboVViec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctdnx.VuviecId), DmVuviec)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    'Gan vao GridView
                    gridctdnx.VuviecId = cboVViec.Id
                    gridctdnx.KyHieuVuviec = cboVViec.KyHieu
                    gridctdnx.TenVuviec = cboVViec.TenVuviec
                    gridctdnx.MaVuviec = cboVViec.MaVuviec

            End Select

            Try
                If cboTyGia.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                    If e.Column.FieldName.Equals("DonGiaVonNte") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong
                        gridctdnx.GiaVonNt = Total
                        gridctdnx.GiaVon = Total * Decimal.Parse(txtTY_GIA.Text)
                    End If

                    If e.Column.FieldName.Equals("DonGiaVonNte") Then
                        Dim GiaVND As Decimal = Decimal.Parse(txtTY_GIA.Text) * gridctdnx.DonGiaVonNte
                        gridctdnx.DonGiaVon = GiaVND
                    End If
                Else
                    If e.Column.FieldName.Equals("DonGiaVon") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaVon * gridctdnx.SoLuong
                        gridctdnx.GiaVon = Total
                    End If
                End If

                If e.Column.FieldName.Equals("DonGiaVonNte") Or e.Column.FieldName.Equals("SoLuong") Then
                    Dim Total As Decimal = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong
                    gridctdnx.GiaVonNt = Total
                End If

                TongTien()

            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào quá lớn!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetFocus_FirstCell()
        Try
            grvPhieuDieuChuyen.FocusedRowHandle = grvPhieuDieuChuyen.RowCount - 1
            grvPhieuDieuChuyen.SelectRow(Handle)

            grvPhieuDieuChuyen.FocusedColumn = grvPhieuDieuChuyen.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly su kien nut keys tren form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDieuXuatDieuChuyen_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
                    Exit Select

                Case Keys.F4
                    'kiem tra dang o trang thai gi de xet xem co su dung them dong ko
                    If m_InputState <> DataInputState.ViewMode Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        SetFocus_FirstCell()
                        grvPhieuDieuChuyen.RefreshData()
                    End If
                    Exit Select

                Case Keys.F8
                    'kiem tra dang o trang thai gi de xet xem co su dung xoa dong ko
                    If m_InputState <> DataInputState.ViewMode Then
                        DeleteRow()
                        ' Cap nhat lai gia tri Tong Tien trong form
                    End If
                    Exit Select
                Case e.Control And Keys.F11
                    'Dim frm_log As KTY.Security.frmViewLog_DanhSach
                    'If m_InputState <> DataInputState.AddMode Then
                    '    frm_log = New KTY.Security.frmViewLog_DanhSach(mCTHNXID, obj_ct_h_nx.ID_LOAI_CT, obj_ct_h_nx.CT_SO)
                    '    frm_log.ShowDialog()
                    'End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly su kien chi dc nhap "1" hoac "2" vao o text trang thai
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtGHI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 49) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) <> 50) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                e.Handled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA.EditValueChanged
        Try
            Try
                For Each gridctdnx As CtDNx In lstobj_ct_d_nx

                    If DB_GetString(cboTyGia.EditValue) <> Generals.TS_NoiTe_ID.GiaTri Then
                        gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.GiaVonNt) * Decimal.Parse(txtTY_GIA.Text)
                        gridctdnx.DonGiaVon = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(txtTY_GIA.Text)
                    Else
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.DonGiaVon) * Decimal.Parse(gridctdnx.SoLuong)
                    End If

                    gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)

                    TongTien()
                Next
            Catch ex As OverflowException
                Message_Warning("Giá trị quá lớn!")
            End Try
            grvPhieuDieuChuyen.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dteNGAY_CT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteNGAY_CT.EditValueChanged
        If dteNGAY_GHI Is Nothing Then
        Else
            dteNGAY_GHI.EditValue = dteNGAY_CT.EditValue
        End If
    End Sub

    Private Sub PhieuDieuXuatDieuChuyen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="senders"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GFilter_HANGHOA_ID_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.AfterFilter, Gfilter_TKN_GIAVON.AfterFilter, Gfilter_TKC_GIAVON.AfterFilter
        Try
            Dim rowHandle As Integer = grvPhieuDieuChuyen.FocusedRowHandle
            Dim columnName As String = grvPhieuDieuChuyen.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle), CtDNx)

            Select Case columnName
                Case "HangHoaId"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If

                    'Gan vao GridView
                    If GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                        gridctdnx.TenHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(2)
                        gridctdnx.MaHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(3)
                        gridctdnx.KyHieuHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                        gridctdnx.TenDvt = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(4)

                        Dim strMaTaiKhoan As String = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(5)

                        If String.IsNullOrEmpty(strMaTaiKhoan) Then
                        Else
                            Dim strMTK() As String = strMaTaiKhoan.Split(";")
                            strMaTaiKhoan = strMTK(0)
                            Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                            obj_taikhoan = DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                            gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiavon = obj_taikhoan.Id
                            gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TknGiavon = obj_taikhoan.Id
                        End If
                        grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa)
                    End If

                Case "MA_TKN_GIAVON"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTknGiavon = Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "MaTknGiavon", gridctdnx.MaTknGiavon)
                Case "MA_TKC_GIAVON"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTkcGiavon = Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon)
            End Select

            SendKeys.Send("{TAB}")

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CheckEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckEdit1.KeyDown
        Try
            EnterNext(sender, e)
        Catch ex As Exception
            Message_Error(ex)
        End Try
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

    ''' <summary>
    ''' xu ly chon vao 1 dong trong comobox se lay ra 1 truong trong do gan vao o text tuong ung
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboTyGia_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTyGia.EditValueChanged
        Try
            If cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                txtTY_GIA.Text = "1"
                SetColNgoaiTe(False)
                If lstobj_ct_d_nx.Count > 0 Then
                    For Each objctdnx As CtDNx In lstobj_ct_d_nx
                        objctdnx.DonGiaBanNte = 0
                        objctdnx.DonGiaVonNte = 0
                        objctdnx.GiaVonNt = 0
                        objctdnx.SoTienBanNte = 0
                    Next
                    grvPhieuDieuChuyen.RefreshData()
                End If
            Else
                If Not (OnLoadData) Then
                    Dim dmNgoaiTe As DmNgoaiteService = New DmNgoaiteService()
                    txtTY_GIA.Text = _LsTygiaService.GetTyGiaNgoaiTe(cboTyGia.EditValue, dteNGAY_CT.EditValue)
                End If
                SetColNgoaiTe(True)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        grvPhieuDieuChuyen.Columns("DonGiaVonNte").Visible = ngoaite
        grvPhieuDieuChuyen.Columns("GiaVonNt").Visible = ngoaite
        grvPhieuDieuChuyen.Columns("DonGiaVon").ColumnEdit.ReadOnly = ngoaite
        If (ngoaite) Then
            txtTY_GIA.Enabled = True
            'grvPhieuDieuChuyen.Columns("DON_GIA_VON_NTE").VisibleIndex = 6
            'grvPhieuDieuChuyen.Columns("GIA_VON_NT").VisibleIndex = 7
        Else
            txtTY_GIA.Enabled = False
        End If
    End Sub

    Private Sub GFilterEdit_HANGHOA_ID_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles GFilterEdit_HANGHOA_ID.FisrtBinddata
        Try
            Select Case grvPhieuDieuChuyen.FocusedColumn().Name
                Case "HangHoaId"
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
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilterEdit_HANGHOA_ID_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles GFilterEdit_HANGHOA_ID.ClearDataFilter
        Try
            Dim rowHandle As Integer = grvPhieuDieuChuyen.FocusedRowHandle
            Dim columnName As String = grvPhieuDieuChuyen.FocusedColumn().Name
            Dim obj As CtDNx = CType(grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle), CtDNx)

            Select Case columnName
                Case "HangHoaId"
                    If obj Is Nothing Then
                        Return
                    End If
                    If GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        obj.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MA_TKN_GIAVON"
                    If (obj Is Nothing) Then
                        Return
                    End If
                    If Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        obj.TknGiavon = VnsConvert.CGuid(Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MA_TKC_GIAVON"
                    If (obj Is Nothing) Then
                        Return
                    End If
                    If Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        obj.TkcGiavon = VnsConvert.CGuid(Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub grlLoaiPhieuNhap_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetControlKho()
    End Sub

    Private Sub SetControlKho()
        Dim objLoaiChungTu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)

        If objLoaiChungTu Is Nothing Then
            Return
        End If

        Dim tempV As Boolean = False
        If (objLoaiChungTu.DmCbnv = 1) Then
            tempV = True
        Else
            'grvPhieuDieuChuyen.Columns("KHO_NHAP_ID").VisibleIndex = 3
            'grvPhieuDieuChuyen.Columns("KHO_XUAT_ID").VisibleIndex = 4
        End If
        'Combo

        lblKhoNhap.Visible = tempV
        lblKhoXuat.Visible = tempV
        cboKhoNhap.Visible = tempV
        cboKhoXuat.Visible = tempV
        'Grid
        Dim Dem As Integer = 0
        Dim BVisible As Boolean = False

        For Each temp As DevExpress.XtraGrid.Columns.GridColumn In grvPhieuDieuChuyen.Columns
            Select Case temp.FieldName
                Case "KhoNhapId", "KhoXuatId"
                    grvPhieuDieuChuyen.Columns(temp.FieldName).Visible = Not tempV
                    If Not tempV Then
                        grvPhieuDieuChuyen.Columns(temp.FieldName).VisibleIndex = _
                            grvPhieuDieuChuyen.Columns(temp.FieldName).VisibleIndex
                    End If
                Case Else
                    BVisible = grvPhieuDieuChuyen.Columns(temp.FieldName).Visible
                    Dem = grvPhieuDieuChuyen.Columns(temp.FieldName).VisibleIndex

                    grvPhieuDieuChuyen.Columns(temp.FieldName).Visible = _
                        grvPhieuDieuChuyen.Columns(temp.FieldName).Visible
                    grvPhieuDieuChuyen.Columns(temp.FieldName).VisibleIndex = _
                        grvPhieuDieuChuyen.Columns(temp.FieldName).VisibleIndex
            End Select
        Next
    End Sub

    Private Sub grvPhieuDieuChuyen_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = grvPhieuDieuChuyen.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "KyHieuHanghoa"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If

                Case "SoLuong"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "DonGiaVon"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class