Imports System
Imports System.Windows.Forms
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmSoDuTaiKhoan2_ChiTiet
#Region "Property"
    Private _CtHService As ICtHService

    Public Property CtHService() As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property
    Private _CtDService As ICtDService

    Public Property CtDService() As ICtDService
        Get
            Return _CtDService
        End Get
        Set(ByVal value As ICtDService)
            _CtDService = value
        End Set
    End Property
    Private _DmNgoaiteService As IDmNgoaiteService

    Public Property DmNgoaiteService() As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(ByVal value As IDmNgoaiteService)
            _DmNgoaiteService = value
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
    Private _DmPtqtService As IDmPtqtService

    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
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
    Private _DmVuviecService As IDmVuviecService

    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
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
    Private _DmKhangService As IDmKhangService

    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Private obj_ct_h As CtH = New CtH()
    Private obj_ct_d As CtD = New CtD()
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private m_MA_LOAI_CT As String
    Private TK_DATA_SOURCE As DataTable = Nothing
    Private KHANG_DATA_SOURCE As DataTable = Nothing
#End Region

#Region "Load form"

    Public Function Show_Form(ByVal CTH_ID As Guid, ByVal MA_LOAI_CT As String, ByVal Obj1 As Object, ByVal obj2 As Object, ByVal eState As DataInputState) As CtH
        Try
            Form_InitDialog(Me)
            Panel_InitControl(_GRC, "CT_H")
            'Control_SetRequire(txtNGUOI_NHAN_NOP_TIEN, True)
            m_InputState = eState
            m_CTH_ID = CTH_ID
            m_MA_LOAI_CT = MA_LOAI_CT

            Control_SetRequire(cFilterTaiKhoan, True)
            Control_SetRequire(grlNGOAI_TE_ID, True)
            Control_SetRequire(txtTY_GIA1, True)
            'frmProgress.Instance.Thread = AddressOf Init_Data
            'frmProgress.Instance.Show_Progress()

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        If (Me.ShowDialog = DialogResult.OK) Then
            Return obj_ct_h
        Else
            Return Nothing
        End If
    End Function

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Private Funcion"

    Private Sub Init_Data()
        'grlTaiKhoan.EditValue =
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLoookUp()
                dteNam.EditValue = Decimal.Parse(Generals.Nam_Ke_Toan)

            Case Else
                BindLoookUp()
                SetObjectToControl()

        End Select
    End Sub

    Private Sub SetObjectToControl()
        obj_ct_h = _CtHService.GetById(m_CTH_ID)
        grlNGOAI_TE_ID.EditValue = obj_ct_h.NteId
        dteNam.EditValue = Integer.Parse(obj_ct_h.NgayCt.Value.Date.Year) + 1
        txtTY_GIA1.Text = obj_ct_h.TyGia
        Dim lstobj_ct_d As List(Of CtD) = New List(Of CtD)
        lstobj_ct_d.AddRange(_CtDService.GetByCtHandNghiepVu(m_CTH_ID, 0))
        If lstobj_ct_d IsNot Nothing Then
            If lstobj_ct_d.Count > 0 Then
                obj_ct_d = lstobj_ct_d(0)
                txtNOI_DUNG.Text = obj_ct_d.NoiDung
                'txtten()
                If Not String.IsNullOrEmpty(obj_ct_d.MaTkCo) Then
                    cFilterTaiKhoan.Tag = obj_ct_d.TkCoId
                    cFilterTaiKhoan.Text = obj_ct_d.MaTkCo
                    txtTEN_TK_NO.Text = obj_ct_d.TenTkCo
                    RemoveHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged
                    tdcSO_TIEN1.Text = obj_ct_d.SoTien
                    AddHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged

                    RemoveHandler tdcSO_TIEN_NTE1.TextChanged, AddressOf txtDU_CO_NTE_TextChanged
                    tdcSO_TIEN_NTE1.Text = obj_ct_d.SoTienNte
                    AddHandler tdcSO_TIEN_NTE1.TextChanged, AddressOf txtDU_CO_NTE_TextChanged

                    RemoveHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged
                    tdnSO_TIEN1.Text = 0
                    AddHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged

                    RemoveHandler tdnSO_TIEN_NTE1.TextChanged, AddressOf txtDU_NO_NTE_TextChanged
                    tdnSO_TIEN_NTE1.Text = 0
                    AddHandler tdnSO_TIEN_NTE1.TextChanged, AddressOf txtDU_NO_NTE_TextChanged
                    grlID_DM_HOPDONG.EditValue = obj_ct_d.IdDmHopdongCo
                    grlID_DM_PTQT.EditValue = obj_ct_d.IdDmHopdongCo
                    grlID_DM_PTQT.EditValue = obj_ct_d.IdDmPtqtCo
                    grlID_DM_PHONGBAN.EditValue = obj_ct_d.IdDmPhongbanCo
                    grlID_DM_VUVIEC.EditValue = obj_ct_d.IdDmVuviecCo
                    cFilter.Tag = obj_ct_d.IdKhangCo
                    cFilter.Text = obj_ct_d.TenKhangCo
                    grlID_DM_TUDO_1.EditValue = obj_ct_d.IdDmTudo1Co
                    grlID_DM_TUDO_2.EditValue = obj_ct_d.IdDmTudo2Co
                    grlID_DM_TUDO_3.EditValue = obj_ct_d.IdDmTudo3Co
                    grlID_DM_TUDO_4.EditValue = obj_ct_d.IdDmTudo4Co
                    grlID_DM_TUDO_5.EditValue = obj_ct_d.IdDmTudo5Co
                Else
                    'grlTK_NO_ID.EditValue = obj_ct_d.TK_NO_ID
                    cFilterTaiKhoan.Text = obj_ct_d.MaTkNo
                    cFilterTaiKhoan.Tag = obj_ct_d.TkNoId
                    txtTEN_TK_NO.Text = obj_ct_d.TenTkNo

                    RemoveHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged
                    tdnSO_TIEN1.Text = obj_ct_d.SoTien
                    AddHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged

                    RemoveHandler tdnSO_TIEN_NTE1.TextChanged, AddressOf txtDU_NO_NTE_TextChanged
                    tdnSO_TIEN_NTE1.Text = obj_ct_d.SoTienNte
                    AddHandler tdnSO_TIEN_NTE1.TextChanged, AddressOf txtDU_NO_NTE_TextChanged

                    RemoveHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged
                    tdcSO_TIEN1.Text = 0
                    AddHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged

                    RemoveHandler tdcSO_TIEN_NTE1.TextChanged, AddressOf txtDU_CO_NTE_TextChanged
                    tdcSO_TIEN_NTE1.Text = 0
                    AddHandler tdcSO_TIEN_NTE1.TextChanged, AddressOf txtDU_CO_NTE_TextChanged
                    grlID_DM_HOPDONG.EditValue = obj_ct_d.IdDmHopdongNo
                    grlID_DM_PTQT.EditValue = obj_ct_d.IdDmHopdongNo
                    grlID_DM_PTQT.EditValue = obj_ct_d.IdDmPtqtNo
                    grlID_DM_PHONGBAN.EditValue = obj_ct_d.IdDmPhongbanNo
                    grlID_DM_VUVIEC.EditValue = obj_ct_d.IdDmVuviecNo
                    cFilter.Tag = obj_ct_d.IdKhangNo
                    cFilter.Text = obj_ct_d.TenKhangNo
                    grlID_DM_TUDO_1.EditValue = obj_ct_d.IdDmTudo1No
                    grlID_DM_TUDO_2.EditValue = obj_ct_d.IdDmTudo2No
                    grlID_DM_TUDO_3.EditValue = obj_ct_d.IdDmTudo3No
                    grlID_DM_TUDO_4.EditValue = obj_ct_d.IdDmTudo4No
                    grlID_DM_TUDO_5.EditValue = obj_ct_d.IdDmTudo5No
                End If
            End If
        End If

    End Sub

    Private Sub SetNoCo(ByVal No As Boolean)
        If No Then
            obj_ct_d.TkCoId = Nothing
            obj_ct_d.MaTkCo = Nothing
            obj_ct_d.TenTkCo = Nothing
            obj_ct_d.IdDmHopdongCo = Nothing
            obj_ct_d.KyHieuHopdongCo = Nothing
            obj_ct_d.MaHopdongCo = Nothing
            obj_ct_d.IdDmPtqtCo = Nothing
            obj_ct_d.IdDmPhongbanCo = Nothing
            obj_ct_d.IdDmVuviecCo = Nothing
            obj_ct_d.KyHieuVuviecCo = Nothing
            obj_ct_d.MaVuviecCo = Nothing
            obj_ct_d.KyHieuKhangCo = Nothing
            obj_ct_d.IdKhangCo = Nothing
            obj_ct_d.MaKhangCo = Nothing
            obj_ct_d.TenKhangCo = Nothing
            obj_ct_d.IdDmTudo1Co = Nothing
            obj_ct_d.IdDmTudo2Co = Nothing
            obj_ct_d.IdDmTudo3Co = Nothing
            obj_ct_d.IdDmTudo4Co = Nothing
            obj_ct_d.IdDmTudo5Co = Nothing
        Else
            obj_ct_d.TkNoId = Nothing
            obj_ct_d.MaTkNo = Nothing
            obj_ct_d.TenTkNo = Nothing
            obj_ct_d.IdDmHopdongNo = Nothing
            obj_ct_d.KyHieuHopdongNo = Nothing
            obj_ct_d.MaHopdongNo = Nothing
            obj_ct_d.IdDmPtqtNo = Nothing
            obj_ct_d.IdDmPhongbanNo = Nothing
            obj_ct_d.IdDmVuviecNo = Nothing
            obj_ct_d.KyHieuVuviecNo = Nothing
            obj_ct_d.MaVuviecNo = Nothing
            obj_ct_d.KyHieuKhangNo = Nothing
            obj_ct_d.IdKhangNo = Nothing
            obj_ct_d.MaKhangNo = Nothing
            obj_ct_d.TenKhangNo = Nothing
            obj_ct_d.IdDmTudo1No = Nothing
            obj_ct_d.IdDmTudo2No = Nothing
            obj_ct_d.IdDmTudo3No = Nothing
            obj_ct_d.IdDmTudo4No = Nothing
            obj_ct_d.IdDmTudo5No = Nothing

        End If

    End Sub

    Private Sub BindLoookUp()
        Dim objColumnDefine As ArrayList
        'Bind ngoại tệ
        Dim lstNTe As List(Of DmNgoaite) = New List(Of DmNgoaite)
        lstNTe.AddRange(_DmNgoaiteService.GetAll())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNte", "Mã ngoại tệ"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNte", "Tên ngoại tệ"))

        GridLookupEdit_BindData(grlNGOAI_TE_ID, lstNTe, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
        grlNGOAI_TE_ID.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA1.Text = "1"

        'Bind DM Hợp đồng
        Dim lstDM_HopDong As List(Of DmHopdong) = New List(Of DmHopdong)
        lstDM_HopDong.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenHopdong", "Tên hợp đồng"))

        Dim lstDM_HopDong_temp As List(Of DmHopdong) = New List(Of DmHopdong)
        Dim obj_HD As DmHopdong = New DmHopdong
        lstDM_HopDong_temp.Add(obj_HD)
        lstDM_HopDong_temp.AddRange(lstDM_HopDong)
        GridLookupEdit_BindData(grlID_DM_HOPDONG, lstDM_HopDong_temp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)


        'Bind DM PTQT
        Dim lstDM_PTQT As List(Of DmPtqt) = New List(Of DmPtqt)
        lstDM_PTQT.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenPtqt", "Tên phương thức quản trị"))

        Dim lstDM_PTQT_temp As List(Of DmPtqt) = New List(Of DmPtqt)
        Dim obj_PTQT As DmPtqt = New DmPtqt
        lstDM_PTQT_temp.Add(obj_PTQT)
        lstDM_PTQT_temp.AddRange(lstDM_PTQT)

        GridLookupEdit_BindData(grlID_DM_PTQT, lstDM_PTQT_temp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind DM Phong ban
        Dim lstDM_PBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstDM_PBan.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"))

        Dim lstDM_PBan_temp As List(Of DmPhongban) = New List(Of DmPhongban)
        Dim obj_PB As DmPhongban = New DmPhongban
        lstDM_PBan_temp.Add(obj_PB)
        lstDM_PBan_temp.AddRange(lstDM_PBan)

        GridLookupEdit_BindData(grlID_DM_PHONGBAN, lstDM_PBan_temp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind DM Khách hàng
        'Dim lstDM_Khang As List(Of DM_KhangInfo) = DM_KhangBO.Instance.GetAllByDonviID(Generals.DON_VI.Id)
        'objColumnDefine = New ArrayList
        'objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        'objColumnDefine.Add(New LookupEdit_ColumnInfo("TEN_KHANG", "Tên khách hàng"))
        'GridLookupEdit_BindData(grlID_KHANG, lstDM_Khang, "KyHieu", "KHANG_ID", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind DM Vụ việc
        Dim lstDM_VuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstDM_VuViec.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenVuviec", "Tên vụ việc"))

        Dim lstDM_VuViec_temp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim obj_VV As DmVuviec = New DmVuviec
        lstDM_VuViec_temp.Add(obj_VV)
        lstDM_VuViec_temp.AddRange(lstDM_VuViec)

        GridLookupEdit_BindData(grlID_DM_VUVIEC, lstDM_VuViec_temp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind tu do 1
        Dim lstTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo1", "Tên loại hình kinh doanh"))

        Dim lstTuDo1_temp As List(Of DmTudo1) = New List(Of DmTudo1)
        Dim obj_TD1 As DmTudo1 = New DmTudo1
        lstTuDo1_temp.Add(obj_TD1)
        lstTuDo1_temp.AddRange(lstTuDo1)

        GridLookupEdit_BindData(grlID_DM_TUDO_1, lstTuDo1_temp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstTuDo2_temp As List(Of DmTudo2) = New List(Of DmTudo2)
        Dim obj_td2 As DmTudo2 = New DmTudo2
        lstTuDo2_temp.Add(obj_td2)
        lstTuDo2_temp.AddRange(lstTuDo2)
        grlID_DM_TUDO_2.Properties.DataSource = lstTuDo2_temp
        grlID_DM_TUDO_2.Properties.DisplayMember = "KyHieu"
        grlID_DM_TUDO_2.Properties.ValueMember = "Id"

        'Bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstTuDo3_temp As List(Of DmTudo3) = New List(Of DmTudo3)
        Dim obj_td3 As DmTudo3 = New DmTudo3
        lstTuDo3_temp.Add(obj_td3)
        lstTuDo3_temp.AddRange(lstTuDo3)

        grlID_DM_TUDO_3.Properties.DataSource = lstTuDo3_temp
        grlID_DM_TUDO_3.Properties.DisplayMember = "KyHieu"
        grlID_DM_TUDO_3.Properties.ValueMember = "Id"
        'GridLookupEdit_BindData(grlID_DM_TUDO_3, lstTuDo3, "KyHieu", "DM_TUDO_3_ID", COMBO_ITEM_REQUIRE, objColumnDefine)

        ''Bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstTuDo4_temp As List(Of DmTudo4) = New List(Of DmTudo4)
        Dim obj_td4 As DmTudo4 = New DmTudo4
        lstTuDo4_temp.Add(obj_td4)
        lstTuDo4_temp.AddRange(lstTuDo4)
        grlID_DM_TUDO_4.Properties.DataSource = lstTuDo4_temp
        grlID_DM_TUDO_4.Properties.DisplayMember = "KyHieu"
        grlID_DM_TUDO_4.Properties.ValueMember = "Id"
        'GridLookupEdit_BindData(grlID_DM_TUDO_4, lstTuDo4, "KyHieu", "DM_TUDO_4_ID", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstTuDo5_temp As List(Of DmTudo5) = New List(Of DmTudo5)
        Dim obj_td5 As DmTudo5 = New DmTudo5
        lstTuDo5_temp.Add(obj_td5)
        lstTuDo5_temp.AddRange(lstTuDo5)

        grlID_DM_TUDO_5.Properties.DataSource = lstTuDo5_temp
        grlID_DM_TUDO_5.Properties.DisplayMember = "KyHieu"
        grlID_DM_TUDO_5.Properties.ValueMember = "Id"
        'GridLookupEdit_BindData(grlID_DM_TUDO_5, lstTuDo5, "KyHieu", "DM_TUDO_5_ID", COMBO_ITEM_REQUIRE, objColumnDefine)

        Dim dt_nam As DataTable = New DataTable

        dt_nam.Columns.Add("NAM", GetType(Decimal))

        For i As Decimal = 2010 To 2030
            dt_nam.Rows.Add(i)
        Next
        dteNam.Properties.DataSource = dt_nam
        dteNam.Properties.ValueMember = "NAM"
        dteNam.Properties.DisplayMember = "NAM"
    End Sub

    Private Sub GetControlToOBject()
        Dim objCT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
        Dim NamSoDu As Integer = dteNam.EditValue
        Dim NgaySoDu As Date = New Date(NamSoDu - 1, 12, 31)
        obj_ct_h.NgayCt = NgaySoDu
        obj_ct_h.DonviId = Generals.DON_VI.Id
        obj_ct_h.MaDonvi = Generals.DON_VI.MaDonvi
        If tdcSO_TIEN1.Text.Trim() <> 0 Then
            obj_ct_h.SoTien = tdcSO_TIEN1.Text.Trim()
        Else
            obj_ct_h.SoTien = tdnSO_TIEN1.Text.Trim()
        End If
        obj_ct_h.KyHieuLoaiCt = objCT.KyHieu
        obj_ct_h.MaLoaiCt = objCT.MaLoaiCt
        obj_ct_h.IdLoaiCt = objCT.Id
        obj_ct_h.NgayGhi = NgaySoDu
        obj_ct_h.NgayCt = NgaySoDu
        obj_ct_h.NgayTao = Date.Now
        obj_ct_h.NguoiTao = Generals.USER.Id
        obj_ct_h.NgaySua = Date.Now
        obj_ct_h.NguoiSua = Generals.USER.Id
        obj_ct_h.CtSo = "1"
        obj_ct_h.SoDu = 1
        obj_ct_h.NteId = grlNGOAI_TE_ID.EditValue
        obj_ct_h.TyGia = txtTY_GIA1.Text.Trim()
        Dim drNgoaiTe As DmNgoaite = CType(ComboHelper.GetSelectData(grlNGOAI_TE_ID), DmNgoaite)
        If (drNgoaiTe IsNot Nothing) Then
            obj_ct_h.MaNte = drNgoaiTe.MaNte
        End If

        

        'obj_ct_d.CthId = obj_ct_h.Id
        obj_ct_d.SoDu = 1
        obj_ct_d.NoiDung = txtNOI_DUNG.Text.Trim()

        If tdcSO_TIEN1.Text.Trim() <> 0 Then
            SetNoCo(False)
            obj_ct_d.SoTien = tdcSO_TIEN1.Text.Trim()
            obj_ct_d.SoTienNte = tdcSO_TIEN_NTE1.Text.Trim()
            obj_ct_d.TkCoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            obj_ct_d.MaTkCo = cFilterTaiKhoan.ListEditValue(1)
            obj_ct_d.TenTkCo = cFilterTaiKhoan.ListEditValue(2)
            'End If
            Dim drHDong As DmHopdong = CType(ComboHelper.GetSelectData(grlID_DM_HOPDONG), DmHopdong)
            If (drHDong IsNot Nothing) Then
                obj_ct_d.IdDmHopdongCo = grlID_DM_HOPDONG.EditValue
                obj_ct_d.MaHopdongCo = drHDong.MaHopdong
                obj_ct_d.TenHopdongCo = drHDong.TenHopdong
                obj_ct_d.KyHieuHopdongCo = drHDong.KyHieu
            End If

            Dim drVuViec As DmVuviec = CType(ComboHelper.GetSelectData(grlID_DM_VUVIEC), DmVuviec)
            If (drVuViec IsNot Nothing) Then
                obj_ct_d.IdDmVuviecCo = grlID_DM_VUVIEC.EditValue
                obj_ct_d.MaVuviecCo = drVuViec.MaVuviec
                obj_ct_d.KyHieuVuviecCo = drVuViec.KyHieu
            End If
            obj_ct_d.IdDmPtqtCo = VnsConvert.CGuid(grlID_DM_PTQT.EditValue)
            obj_ct_d.IdDmPhongbanCo = VnsConvert.CGuid(grlID_DM_PHONGBAN.EditValue)

            obj_ct_d.IdKhangCo = VnsConvert.CGuid(cFilter.ListEditValue(0))
            obj_ct_d.MaKhangCo = cFilter.ListEditValue(2)
            obj_ct_d.TenKhangCo = cFilter.ListEditValue(1)
            obj_ct_d.KyHieuKhangCo = cFilter.ListEditValue(3)
            'End If
            obj_ct_d.IdDmTudo1Co = VnsConvert.CGuid(grlID_DM_TUDO_1.EditValue)
            obj_ct_d.IdDmTudo2Co = VnsConvert.CGuid(grlID_DM_TUDO_2.EditValue)
            obj_ct_d.IdDmTudo3Co = VnsConvert.CGuid(grlID_DM_TUDO_3.EditValue)
            obj_ct_d.IdDmTudo4Co = VnsConvert.CGuid(grlID_DM_TUDO_4.EditValue)
            obj_ct_d.IdDmTudo5Co = VnsConvert.CGuid(grlID_DM_TUDO_5.EditValue)
        Else
            SetNoCo(True)
            obj_ct_d.SoTien = tdnSO_TIEN1.Text.Trim()
            obj_ct_d.SoTienNte = tdnSO_TIEN_NTE1.Text.Trim()
            
            obj_ct_d.TkNoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            obj_ct_d.MaTkNo = cFilterTaiKhoan.ListEditValue(1)
            obj_ct_d.TenTkNo = cFilterTaiKhoan.ListEditValue(2)
            'End If
            Dim drHDong As DmHopdong = CType(ComboHelper.GetSelectData(grlID_DM_HOPDONG), DmHopdong)
            If (drHDong IsNot Nothing) Then
                obj_ct_d.IdDmHopdongNo = grlID_DM_HOPDONG.EditValue
                obj_ct_d.MaHopdongNo = drHDong.MaHopdong
                obj_ct_d.TenHopdongNo = drHDong.TenHopdong
                obj_ct_d.KyHieuHopdongNo = drHDong.KyHieu
            End If

            Dim drVuViec As DmVuviec = CType(ComboHelper.GetSelectData(grlID_DM_VUVIEC), DmVuviec)
            If (drVuViec IsNot Nothing) Then
                obj_ct_d.IdDmVuviecNo = grlID_DM_VUVIEC.EditValue
                obj_ct_d.MaVuviecNo = drVuViec.MaVuviec
                obj_ct_d.KyHieuVuviecNo = drVuViec.KyHieu
            End If

            obj_ct_d.IdDmPtqtNo = VnsConvert.CGuid(grlID_DM_PTQT.EditValue)
            obj_ct_d.IdDmPhongbanNo = VnsConvert.CGuid(grlID_DM_PHONGBAN.EditValue)

            If (cFilter.ListEditValue.Count > 0) Then
                obj_ct_d.IdKhangNo = VnsConvert.CGuid(cFilter.ListEditValue(0))
                obj_ct_d.MaKhangNo = cFilter.ListEditValue(2)
                obj_ct_d.TenKhangNo = cFilter.ListEditValue(1)
                obj_ct_d.KyHieuKhangNo = cFilter.ListEditValue(3)
            End If
            
            'End If
            obj_ct_d.IdDmTudo1No = VnsConvert.CGuid(grlID_DM_TUDO_1.EditValue)
            obj_ct_d.IdDmTudo2No = VnsConvert.CGuid(grlID_DM_TUDO_2.EditValue)
            obj_ct_d.IdDmTudo3No = VnsConvert.CGuid(grlID_DM_TUDO_3.EditValue)
            obj_ct_d.IdDmTudo4No = VnsConvert.CGuid(grlID_DM_TUDO_4.EditValue)
            obj_ct_d.IdDmTudo5No = VnsConvert.CGuid(grlID_DM_TUDO_5.EditValue)
            End If

        Dim InsertFlg As Boolean = False
        Select Case m_InputState
            Case DataInputState.AddMode
                InsertFlg = True
            Case Else
        End Select
        Dim lstCtD As IList(Of CtD) = New List(Of CtD)
        lstCtD.Add(obj_ct_d)
        _CtHService.SaveChungTuKeToan(InsertFlg, Nothing, obj_ct_h, lstCtD, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Function InsertCT_H(ByVal _obj_ct_h As CtH) As CtH
        Return _CtHService.Save(_obj_ct_h)
    End Function

    Private Sub UpdateCT_H(ByVal _obj_ct_h As CtH)
        _CtHService.SaveOrUpdate(_obj_ct_h)
    End Sub

    Private Sub InsertCT_D(ByVal _obj_ct_d As CtD)
        _CtDService.Save(_obj_ct_d)
    End Sub

    Private Sub UpdateCT_D(ByVal _obj_ct_d As CtD)
        _CtDService.SaveOrUpdate(_obj_ct_d)
    End Sub

#End Region

#Region "Events"

    Private Sub frmSoDuTaiKhoan2_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                Exit Select

        End Select
    End Sub

    Private Function Check_Input() As Boolean

        If VnsConvert.CGuid(cFilterTaiKhoan.Tag) = Null.NullGuid Then
            Message_Warning("Bạn chưa chọn tài khoản!")
            cFilterTaiKhoan.Focus()
            Return False
        End If

        If tdcSO_TIEN1.Text.Trim().Equals("0") And tdnSO_TIEN1.Text.Trim().Equals("0") Then
            Message_Warning("Bạn chưa nhập số tiền")
            Return False
        End If

        If cFilterTaiKhoan.Text = "" Or VnsConvert.CGuid(grlNGOAI_TE_ID.EditValue) = Null.NullGuid Or String.IsNullOrEmpty(txtTY_GIA1.Text) Then
            Message_Warning("Bạn chưa nhập giá trị cho trường bắt buộc")
            Return False
        End If

        If txtTY_GIA1.Text <> "" Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtTY_GIA1.Text)) Then
                Message_Warning("Giá trị tỷ giá không hợp lệ")
                txtTY_GIA1.Focus()
                Return False
            End If
        End If

        If tdnSO_TIEN_NTE1.Text <> "" Then
            If Not LimitValue.CheckFCurrency(Decimal.Parse(tdnSO_TIEN_NTE1.Text)) Then
                Message_Warning("Giá trị dư nợ ngoại tệ không hợp lệ")
                tdnSO_TIEN_NTE1.Focus()
                Return False
            End If
        End If

        If tdcSO_TIEN_NTE1.Text <> "" Then
            If Not LimitValue.CheckFCurrency(Decimal.Parse(tdcSO_TIEN_NTE1.Text)) Then
                Message_Warning("Giá trị dư có ngoại tệ không hợp lệ")
                tdcSO_TIEN_NTE1.Focus()
                Return False
            End If
        End If

        If tdnSO_TIEN1.Text <> "" Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(tdnSO_TIEN1.Text)) Then
                Message_Warning("Giá trị dư nợ không hợp lệ")
                tdnSO_TIEN1.Focus()
                Return False
            End If
        End If

        If tdcSO_TIEN1.Text <> "" Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(tdcSO_TIEN1.Text)) Then
                Message_Warning("Giá trị dư có không hợp lệ")
                tdnSO_TIEN1.Focus()
                Return False
            End If
        End If

        If txtNOI_DUNG.Text.Length > 256 Then
            Message_Warning("Độ dài nội dung quá lớn!")
            txtNOI_DUNG.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            If Not Check_Input() Then
                Return
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công") '"Data saved"
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub txtDU_NO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdnSO_TIEN1.TextChanged
        tdcSO_TIEN1.Text = 0
        tdcSO_TIEN_NTE1.Text = 0
    End Sub

    Private Sub txtDU_CO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdcSO_TIEN1.TextChanged
        tdnSO_TIEN1.Text = 0
        tdnSO_TIEN_NTE1.Text = 0
    End Sub

    Private Sub txtDU_NO_NTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdnSO_TIEN_NTE1.TextChanged
        Try
            Dim tygia As String = txtTY_GIA1.Text.Trim()
            Dim dunont As String = tdnSO_TIEN_NTE1.Text.Trim()

            tdcSO_TIEN1.Text = 0
            tdcSO_TIEN_NTE1.Text = 0

            If Not String.IsNullOrEmpty(tygia) Then
                If Not String.IsNullOrEmpty(dunont) Then
                    Try
                        tdnSO_TIEN1.Text = Math.Round(Convert.ToDecimal(tygia) * Convert.ToDecimal(dunont))
                    Catch ex As OverflowException
                        Message_Warning("Giá trị nhập vào quá lớn!")
                    End Try
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDU_CO_NTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdcSO_TIEN_NTE1.TextChanged
        Try
            Dim tygia As String = txtTY_GIA1.Text.Trim()
            Dim ducont As String = tdcSO_TIEN_NTE1.Text.Trim()
            tdnSO_TIEN1.Text = 0
            tdnSO_TIEN_NTE1.Text = 0

            If Not String.IsNullOrEmpty(tygia) Then
                If Not String.IsNullOrEmpty(ducont) Then
                    Try
                        tdcSO_TIEN1.Text = Math.Round(Convert.ToDecimal(tygia) * Convert.ToDecimal(ducont))
                    Catch ex As Exception
                        Message_Warning("Giá trị bạn nhập vào quá lớn!")
                    End Try
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlNGOAI_TE_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlNGOAI_TE_ID.EditValueChanged
        Try
            If grlNGOAI_TE_ID.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                txtTY_GIA1.Text = "1"
                txtTY_GIA1.Properties.Enabled = False
                tdnSO_TIEN_NTE1.Properties.Enabled = False
                tdcSO_TIEN_NTE1.Properties.Enabled = False
                tdnSO_TIEN_NTE1.Text = "0"
                tdcSO_TIEN_NTE1.Text = "0"
            Else
                txtTY_GIA1.Properties.Enabled = True
                tdnSO_TIEN_NTE1.Properties.Enabled = True
                tdcSO_TIEN_NTE1.Properties.Enabled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA1.TextChanged
        Try
            Dim tygia As String = txtTY_GIA1.Text.Trim()
            Dim ducont As String = tdcSO_TIEN_NTE1.Text.Trim()
            Dim dunont As String = tdnSO_TIEN_NTE1.Text.Trim()

            If Not String.IsNullOrEmpty(tygia) Then
                Try
                    If Not String.IsNullOrEmpty(dunont) Then
                        RemoveHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged
                        tdnSO_TIEN1.Text = Math.Round(Convert.ToDecimal(tygia) * Convert.ToDecimal(dunont))
                        AddHandler tdnSO_TIEN1.TextChanged, AddressOf txtDU_NO_TextChanged
                    End If
                    If Not String.IsNullOrEmpty(ducont) Then
                        RemoveHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged
                        tdcSO_TIEN1.Text = Math.Round(Convert.ToDecimal(tygia) * Convert.ToDecimal(ducont))
                        AddHandler tdcSO_TIEN1.TextChanged, AddressOf txtDU_CO_TextChanged
                    End If
                Catch ex As OverflowException
                    Message_Warning("Giá trị nhập vào quá lớn!")
                End Try
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SavingMemory(ByVal _option As Integer)
        If _option = 1 Then 'TK
            If TK_DATA_SOURCE Is Nothing Then
                TK_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 2 Then 'KHANG
            If KHANG_DATA_SOURCE Is Nothing Then
                KHANG_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If

        ElseIf _option = 10 Then 'ALL
            If TK_DATA_SOURCE Is Nothing Then
                TK_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If KHANG_DATA_SOURCE Is Nothing Then
                KHANG_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        End If
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        Try
            cFilterTaiKhoan.Tag = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            txtTEN_TK_NO.Text = cFilterTaiKhoan.ListEditValue(2)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterFilter
        If cFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData
        Try
            cFilterTaiKhoan.Tag = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            txtTEN_TK_NO.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            cFilterTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.FirstBinddata
        Try
            cFilter.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.ClearFilterData
        Try
            cFilter.Tag = ""
            cFilter.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
End Class