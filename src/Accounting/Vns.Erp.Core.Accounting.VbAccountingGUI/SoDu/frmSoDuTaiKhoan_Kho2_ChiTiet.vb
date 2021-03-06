Imports System
Imports System.Windows.Forms

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmSoDuTaiKhoan_Kho2_ChiTiet
#Region "Property"
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
    Private _DmDvtService As IDmDvtService

    Public Property DmDvtService() As IDmDvtService
        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
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
    Private _DmKhoService As IDmKhoService

    Public Property DmKhoService() As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Private obj_ct_h_nx As CtHNx = New CtHNx()
    Private obj_ct_d_nx As CtDNx = New CtDNx()
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_NX As Guid
    Private m_MA_LOAI_CT As String
    Private TK_DATA_SOURCE As DataTable = Nothing
    Private KHANG_DATA_SOURCE As DataTable = Nothing
    Private HANGHOA_DATA_SOURCE As DataTable = Nothing
#End Region

#Region "Load form"

    'xu ly load form
    Public Function Show_Form(ByVal CTH_NX As Guid, ByVal MA_LOAI_CT As String, ByVal TEN_LOAI_CT As String, ByVal lstcthg As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As CtHNx
        Try
            Form_InitDialog(Me)

            m_InputState = eState
            m_CTH_NX = CTH_NX
            m_MA_LOAI_CT = MA_LOAI_CT
            txtDON_GIA_VON_NTE.Text = 0
            Control_SetRequire(cFilterTaiKhoan, True)
            Control_SetRequire(txtSO_LUONG, True)
            Control_SetRequire(CFilterHangHoa, True)
            Control_SetRequire(txtDON_GIA_VON, True)
            Control_SetRequire(grlKHO_ID, True)

            ' Set read-only
            txtTHANH_TIEN.Properties.ReadOnly = False

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return obj_ct_h_nx
        Else
            Return Nothing
        End If
    End Function

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Private Funcion and Procedure"

    Private Sub Init_Data()
        'grlTaiKhoan.EditValue =
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLoookUpNX()
                dteNam.DateTime = New Date(Generals.Nam_Ke_Toan, 1, 1)

            Case Else
                BindLoookUpNX()
                SetObjectToControl()

        End Select
    End Sub

    Private Sub SetObjectToControl()
        ' Lay thong tin header tu DB
        obj_ct_h_nx = _CtHNxService.GetById(m_CTH_NX)

        grlNGOAI_TE_ID.EditValue = obj_ct_h_nx.NteId
        txtTY_GIA.Text = obj_ct_h_nx.TyGia

        dteNam.EditValue = obj_ct_h_nx.NgayCt.Value.AddYears(1)

        ' Lay thong tin Detail tu DB
        Dim lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
        lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(m_CTH_NX))
        ' Kiem tra thong tin lay tu db
        If lstobj_ct_d_nx IsNot Nothing Then
            If lstobj_ct_d_nx.Count > 0 Then
                obj_ct_d_nx = lstobj_ct_d_nx(0)

                'grlTAIKHOAN_ID.EditValue = obj_ct_d_nx.TKN_GIAVON
                'grlHANGHOA_ID.EditValue = obj_ct_d_nx.HANGHOA_ID
                cFilterTaiKhoan.Tag = obj_ct_d_nx.TknGiavon
                cFilterTaiKhoan.Text = obj_ct_d_nx.MaTknGiavon
                cFilterTaiKhoan.AfterSetTag()
                txtTEN_TAIKHOAN.Text = cFilterTaiKhoan.ListEditValue(2)

                CFilterHangHoa.Tag = obj_ct_d_nx.HanghoaId
                CFilterHangHoa.Text = obj_ct_d_nx.KyHieuHanghoa
                grlDVT_ID.EditValue = obj_ct_d_nx.DvtId
                grlKHO_ID.EditValue = obj_ct_d_nx.KhoNhapId
                grlID_DM_HOPDONG.EditValue = obj_ct_d_nx.HopdongId
                grlID_DM_PTQT.EditValue = obj_ct_d_nx.IdDmPtqtNo
                grlID_DM_PHONGBAN.EditValue = obj_ct_d_nx.IdDmPhongbanNo

                'grlID_KHANG.EditValue = obj_ct_d_nx.ID_KHANG
                cFilter.Tag = obj_ct_d_nx.IdKhang
                cFilter.Text = obj_ct_d_nx.TenKhang

                grlID_DM_VUVIEC.EditValue = obj_ct_d_nx.VuviecId
                grlID_DM_TUDO_1.EditValue = obj_ct_d_nx.IdDmTudo1No
                grlID_DM_TUDO_2.EditValue = obj_ct_d_nx.IdDmTudo2No
                grlID_DM_TUDO_3.EditValue = obj_ct_d_nx.IdDmTudo3No
                grlID_DM_TUDO_4.EditValue = obj_ct_d_nx.IdDmTudo4No
                grlID_DM_TUDO_5.EditValue = obj_ct_d_nx.IdDmTudo5No

                txtNOI_DUNG.Text = obj_ct_d_nx.NoiDung
                txtTEN_HANGHOA.Text = obj_ct_d_nx.TenHanghoa
                txtSO_LUONG.Text = obj_ct_d_nx.SoLuong
                txtDON_GIA_VON.Text = obj_ct_d_nx.DonGiaVon
                txtDON_GIA_VON_NTE.Text = obj_ct_d_nx.DonGiaVonNte
                txtTHANH_TIEN.Text = obj_ct_d_nx.GiaVon
                txtTHU_TU.Text = obj_ct_d_nx.ThuTu
            End If
        End If

    End Sub

    Private Sub BindLoookUpNX()
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
        txtTY_GIA.Text = "1"

        'Bind đơn vị tính
        Dim lstDM_DVT As List(Of DmDvt) = New List(Of DmDvt)
        lstDM_DVT.AddRange(_DmDvtService.GetAll())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDvt", "Tên đơn vị tính"))
        GridLookupEdit_BindData(grlDVT_ID, lstDM_DVT, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind kho
        Dim lstKho As List(Of DmKho) = New List(Of DmKho)
        lstKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenKho", "Tên kho"))
        GridLookupEdit_BindData(grlKHO_ID, lstKho, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind DM Hợp đồng
        Dim lstDM_HopDong As List(Of DmHopdong) = New List(Of DmHopdong)
        lstDM_HopDong.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_hd As DmHopdong = New DmHopdong
        Dim lstDM_HopDong_Temp As List(Of DmHopdong) = New List(Of DmHopdong)
        lstDM_HopDong_Temp.Add(obj_hd)
        lstDM_HopDong_Temp.AddRange(lstDM_HopDong)
        grlID_DM_HOPDONG.Properties.DataSource = lstDM_HopDong_Temp
        grlID_DM_HOPDONG.Properties.ValueMember = "Id"
        grlID_DM_HOPDONG.Properties.DisplayMember = "KyHieu"

        'Bind DM PTQT
        Dim lstDM_PTQT As List(Of DmPtqt) = New List(Of DmPtqt)
        lstDM_PTQT.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_ptqt As DmPtqt = New DmPtqt
        Dim lstDM_PTQT_Temp As List(Of DmPtqt) = New List(Of DmPtqt)
        lstDM_PTQT_Temp.Add(obj_ptqt)
        lstDM_PTQT_Temp.AddRange(lstDM_PTQT)
        grlID_DM_PTQT.Properties.DataSource = lstDM_PTQT_Temp
        grlID_DM_PTQT.Properties.ValueMember = "Id"
        grlID_DM_PTQT.Properties.DisplayMember = "KyHieu"

        'Bind DM Phong ban
        Dim lstDM_PBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstDM_PBan.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_dm_phongBan As DmPhongban = New DmPhongban
        Dim lstDm_PBan_temp As List(Of DmPhongban) = New List(Of DmPhongban)
        lstDm_PBan_temp.Add(obj_dm_phongBan)
        lstDm_PBan_temp.AddRange(lstDM_PBan)
        grlID_DM_PHONGBAN.Properties.DataSource = lstDm_PBan_temp
        grlID_DM_PHONGBAN.Properties.ValueMember = "Id"
        grlID_DM_PHONGBAN.Properties.DisplayMember = "KyHieu"


        'Bind DM Vụ việc
        Dim lstDM_VuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstDM_VuViec.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_Vv As DmVuviec = New DmVuviec
        Dim lstDM_VuViec_TemP As List(Of DmVuviec) = New List(Of DmVuviec)
        lstDM_VuViec_TemP.Add(obj_Vv)
        lstDM_VuViec_TemP.AddRange(lstDM_VuViec)
        grlID_DM_VUVIEC.Properties.DataSource = lstDM_VuViec_TemP
        grlID_DM_VUVIEC.Properties.ValueMember = "Id"
        grlID_DM_VUVIEC.Properties.DisplayMember = "KyHieu"

        'Bind tu do 1
        Dim lstTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_TD1 As DmTudo1 = New DmTudo1
        Dim lstTuDo1_Temp As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1_Temp.Add(obj_TD1)
        lstTuDo1_Temp.AddRange(lstTuDo1)
        grlID_DM_TUDO_1.Properties.DataSource = lstTuDo1_Temp
        grlID_DM_TUDO_1.Properties.ValueMember = "Id"
        grlID_DM_TUDO_1.Properties.DisplayMember = "KyHieu"

        'Bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim obj_TD2 As DmTudo2 = New DmTudo2
        Dim lstTuDo2_Temp As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2_Temp.Add(obj_TD2)
        lstTuDo2_Temp.AddRange(lstTuDo2)
        grlID_DM_TUDO_2.Properties.DataSource = lstTuDo2_Temp
        grlID_DM_TUDO_2.Properties.ValueMember = "Id"
        grlID_DM_TUDO_2.Properties.DisplayMember = "KyHieu"

        'Bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_TD3 As DmTudo3 = New DmTudo3
        Dim lstTuDo3_Temp As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3_Temp.Add(obj_TD3)
        lstTuDo3_Temp.AddRange(lstTuDo3)
        grlID_DM_TUDO_3.Properties.DataSource = lstTuDo3_Temp
        grlID_DM_TUDO_3.Properties.ValueMember = "Id"
        grlID_DM_TUDO_3.Properties.DisplayMember = "KyHieu"

        ''Bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        _DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id)

        Dim obj_TD4 As DmTudo4 = New DmTudo4
        Dim lstTuDo4_Temp As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4_Temp.Add(obj_TD4)
        lstTuDo4_Temp.AddRange(lstTuDo4)
        grlID_DM_TUDO_4.Properties.DataSource = lstTuDo4_Temp
        grlID_DM_TUDO_4.Properties.ValueMember = "Id"
        grlID_DM_TUDO_4.Properties.DisplayMember = "KyHieu"

        ''Bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim obj_TD5 As DmTudo5 = New DmTudo5
        Dim lstTuDo5_Temp As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5_Temp.Add(obj_TD5)
        lstTuDo5_Temp.AddRange(lstTuDo5)
        grlID_DM_TUDO_5.Properties.DataSource = lstTuDo5_Temp
        grlID_DM_TUDO_5.Properties.ValueMember = "Id"
        grlID_DM_TUDO_5.Properties.DisplayMember = "KyHieu"
    End Sub

    Private Sub GetControlToOBject()
        Dim objCT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
        Dim NamSoDu As Integer = dteNam.DateTime.Year

        Dim NgaySoDu As Date = New Date(NamSoDu - 1, 12, 31)

        obj_ct_h_nx.NgayCt = NgaySoDu
        obj_ct_h_nx.DonviId = Generals.DON_VI.Id
        obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
        obj_ct_h_nx.SoTien = txtTHANH_TIEN.Text.Trim
        obj_ct_h_nx.TyGia = txtTY_GIA.Text.Trim()
        obj_ct_h_nx.KyHieuLoaiCt = objCT.KyHieu
        obj_ct_h_nx.MaLoaiCt = objCT.MaLoaiCt
        obj_ct_h_nx.IdLoaiCt = objCT.Id
        obj_ct_h_nx.NgayGhi = NgaySoDu
        obj_ct_h_nx.CtSo = "1"

        If (String.IsNullOrEmpty(txtTHU_TU.Text)) Then
            txtTHU_TU.Text = 1
        End If
        'obj_ct_h_nx.THU_TU = Decimal.Parse(txtTHU_TU.Text)
        obj_ct_h_nx.SoDu = 1
        obj_ct_h_nx.NteId = VnsConvert.CGuid(grlNGOAI_TE_ID.EditValue)
        Dim drNgoaiTe As DmNgoaite = CType(ComboHelper.GetSelectData(grlNGOAI_TE_ID), DmNgoaite)
        If (drNgoaiTe IsNot Nothing) Then
            obj_ct_h_nx.MaNte = drNgoaiTe.MaNte
        End If

        'Select Case m_InputState
        '    Case DataInputState.AddMode
        '        obj_ct_h_nx = InsertCT_H_NX(obj_ct_h_nx)
        '    Case Else
        '        UpdateCT_H_NX(obj_ct_h_nx)
        'End Select
        'Math.Round()
        obj_ct_d_nx.CthNxId = obj_ct_h_nx.Id
        obj_ct_d_nx.NgayTao = DateTime.Now
        obj_ct_d_nx.ThuTu = Decimal.Parse(txtTHU_TU.Text)
        obj_ct_d_nx.SoDu = 1
        obj_ct_d_nx.SoLuong = txtSO_LUONG.Text.Trim()
        obj_ct_d_nx.DonGiaVon = txtDON_GIA_VON.Text.Trim()
        obj_ct_d_nx.DonGiaVonNte = txtDON_GIA_VON_NTE.Text.Trim()
        obj_ct_d_nx.GiaVon = txtTHANH_TIEN.Text.Trim()
        obj_ct_d_nx.SoTienCl = obj_ct_d_nx.GiaVon
        obj_ct_d_nx.DuLuong = obj_ct_d_nx.SoLuong
        obj_ct_d_nx.NoiDung = txtNOI_DUNG.Text.Trim
        
        obj_ct_d_nx.HanghoaId = VnsConvert.CGuid(CFilterHangHoa.ListEditValue(0))
        obj_ct_d_nx.KyHieuHanghoa = CFilterHangHoa.ListEditValue(3)
        obj_ct_d_nx.MaHanghoa = CFilterHangHoa.ListEditValue(2)
        obj_ct_d_nx.TenHanghoa = CFilterHangHoa.ListEditValue(1)
        'End If
        obj_ct_d_nx.DvtId = VnsConvert.CGuid(grlDVT_ID.EditValue)
        Dim drDVT As DmDvt = CType(ComboHelper.GetSelectData(grlDVT_ID), DmDvt)
        If (drDVT IsNot Nothing) Then
            obj_ct_d_nx.MaDvt = drDVT.MaDvt
            obj_ct_d_nx.TenDvt = drDVT.TenDvt
        End If

        obj_ct_d_nx.MaTknGiavon = cFilterTaiKhoan.ListEditValue(1)
        obj_ct_d_nx.TknGiavon = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))

        obj_ct_d_nx.HopdongId = VnsConvert.CGuid(grlID_DM_HOPDONG.EditValue)
        obj_ct_d_nx.IdDmHopdongNo = VnsConvert.CGuid(grlID_DM_HOPDONG.EditValue)
        Dim drHDong As DmHopdong = CType(ComboHelper.GetSelectData(grlID_DM_HOPDONG), DmHopdong)
        If (drHDong IsNot Nothing) Then
            obj_ct_d_nx.MaHopdong = drHDong.MaHopdong
            obj_ct_d_nx.TenHopdong = drHDong.TenHopdong
            obj_ct_d_nx.KyHieuHopdong = drHDong.KyHieu
            obj_ct_d_nx.MaDmHopdongNo = drHDong.MaHopdong
            obj_ct_d_nx.TenDmHopdongNo = drHDong.TenHopdong
        End If
        obj_ct_d_nx.VuviecId = VnsConvert.CGuid(grlID_DM_VUVIEC.EditValue)
        obj_ct_d_nx.IdDmVuviecNo = VnsConvert.CGuid(grlID_DM_VUVIEC.EditValue)
        Dim drVuViec As DmVuviec = CType(ComboHelper.GetSelectData(grlID_DM_VUVIEC), DmVuviec)
        If (drVuViec IsNot Nothing) Then
            obj_ct_d_nx.MaVuviec = drVuViec.MaVuviec
            obj_ct_d_nx.KyHieuVuviec = drVuViec.KyHieu
            obj_ct_d_nx.TenVuviec = drVuViec.TenVuviec
            obj_ct_d_nx.MaDmVuviecNo = drVuViec.MaVuviec
            obj_ct_d_nx.TenDmVuviecNo = drVuViec.TenVuviec
        End If

        obj_ct_d_nx.IdDmKhangNo = VnsConvert.CGuid(cFilter.ListEditValue(0))
        obj_ct_d_nx.MaDmKhangNo = cFilter.ListEditValue(2)
        obj_ct_d_nx.TenDmKhangNo = cFilter.ListEditValue(1)
        obj_ct_d_nx.KyHieuDmKhangNo = cFilter.ListEditValue(3)
        obj_ct_d_nx.IdKhang = VnsConvert.CGuid(cFilter.ListEditValue(0))
        obj_ct_d_nx.TenKhang = cFilter.ListEditValue(1)
        obj_ct_d_nx.MaKhang = cFilter.ListEditValue(2)
        obj_ct_d_nx.KyHieuKhang = cFilter.ListEditValue(3)
        obj_ct_d_nx.IdDmKhangNo = VnsConvert.CGuid(cFilter.ListEditValue(0))
        'End If

        obj_ct_d_nx.IdDmPhongbanNo = VnsConvert.CGuid(grlID_DM_PHONGBAN.EditValue)
        obj_ct_d_nx.IdDmPtqtNo = VnsConvert.CGuid(grlID_DM_PTQT.EditValue)
        obj_ct_d_nx.IdDmTudo1No = VnsConvert.CGuid(grlID_DM_TUDO_1.EditValue)
        obj_ct_d_nx.IdDmTudo2No = VnsConvert.CGuid(grlID_DM_TUDO_2.EditValue)
        obj_ct_d_nx.IdDmTudo3No = VnsConvert.CGuid(grlID_DM_TUDO_3.EditValue)
        obj_ct_d_nx.IdDmTudo4No = VnsConvert.CGuid(grlID_DM_TUDO_4.EditValue)
        obj_ct_d_nx.IdDmTudo5No = VnsConvert.CGuid(grlID_DM_TUDO_5.EditValue)
        obj_ct_d_nx.KhoNhapId = VnsConvert.CGuid(grlKHO_ID.EditValue)
        obj_ct_d_nx.XUAT = 0

        Dim flgUpdate = True
        Select Case m_InputState
            Case DataInputState.AddMode
                flgUpdate = False
            Case Else
        End Select
        Dim lstctd As List(Of CtDNx) = New List(Of CtDNx)()
        lstctd.Add(obj_ct_d_nx)
        _CtHNxService.SaveChungTuKho(flgUpdate, obj_ct_h_nx, lstctd, Nothing)
    End Sub

    Private Function InsertCT_H_NX(ByVal _obj_ct_h_nx As CtHNx) As CtHNx
        Return _CtHNxService.Save(_obj_ct_h_nx)
    End Function

    Private Sub UpdateCT_H_NX(ByVal _obj_ct_h_nx As CtHNx)
        _CtHNxService.SaveOrUpdate(_obj_ct_h_nx)
    End Sub

    Private Sub InsertCT_D_NX(ByVal _obj_ct_d_nx As CtDNx)
        _CtDNxService.Save(_obj_ct_d_nx)
    End Sub

    Private Sub UpdateCT_D_NX(ByVal _obj_ct_d_nx As CtDNx)
        _CtDNxService.SaveOrUpdate(_obj_ct_d_nx)
    End Sub

    Private Function ThanhTien() As Decimal
        Dim soLuong As Decimal
        Dim donGia As Decimal

        ' Lay gia tri Don Gia
        If String.IsNullOrEmpty(txtDON_GIA_VON.Text.Trim()) Then
            donGia = 0
        Else
            donGia = Convert.ToDecimal(txtDON_GIA_VON.Text.Trim())
        End If

        ' Lay gia tri So Luong
        If String.IsNullOrEmpty(txtSO_LUONG.Text.Trim()) Then
            soLuong = 0
        Else
            soLuong = Convert.ToDecimal(txtSO_LUONG.Text.Trim())
        End If

        ' Kiem tra gia tri nhap vao
        Try
            ' Tinh toan TT
            ThanhTien = soLuong * donGia
        Catch ex As Exception
            Message_Warning("Giá trị thành tiền quá lớn!")
        End Try

        Return ThanhTien
    End Function
#End Region

#Region "Events"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Panel_CheckError(GroupControl2, True) Then
                Message_Warning("Chưa nhập đủ thông tin")
                Exit Sub
            End If

            ' Kiem tra length cua input string
            ' numeric 18,4 in DB, set only 2 decimal digits in Scrn
            If Convert.ToDecimal(txtTY_GIA.Text.Trim()).ToString().Length > 16 Then
                Message_Warning("Giá trị nhập liệu quá lớn!")
                txtTY_GIA.Focus()
                Exit Sub
            End If

            ' numeric 18,4 in DB, set only 2 decimal digits in Scrn
            If Convert.ToDecimal(txtDON_GIA_VON_NTE.Text.Trim()).ToString().Length > 16 Then
                Message_Warning("Giá trị nhập liệu quá lớn!")
                txtDON_GIA_VON_NTE.Focus()
                Exit Sub
            End If

            ' numeric 18,4 in DB, set only 0 decimal digits in Scrn
            If Convert.ToDecimal(txtSO_LUONG.Text.Trim()).ToString().Length > 14 Then
                Message_Warning("Giá trị nhập liệu quá lớn!")
                txtSO_LUONG.Focus()
                Exit Sub
            End If

            ' numeric 18,4 in DB, set only 0 decimal digits in Scrn
            If Convert.ToDecimal(txtDON_GIA_VON.Text.Trim()).ToString().Length > 14 Then
                Message_Warning("Giá trị nhập liệu quá lớn!")
                txtDON_GIA_VON.Focus()
                Exit Sub
            End If

            ' Kiem tra gia tri TT cuoi cung
            ' numeric 18,0 in DB, set only 0 decimal digits in Scrn
            If txtTHANH_TIEN.Text.Trim() = "0" Or Convert.ToDecimal(txtTHANH_TIEN.Text.Trim()).ToString().Length > 18 Then
                Message_Warning("Giá trị thành tiền quá lớn hoặc chưa xác định!")
                txtSO_LUONG.Focus()
                Exit Sub
            End If

            Dim stemp As String
            stemp = cFilterTaiKhoan.Tag.ToString()
            If (String.IsNullOrEmpty(stemp)) Then
                Message_Warning("Mã tài khoản bắt buộc!")
                cFilterTaiKhoan.Focus()
                Exit Sub
            End If

            stemp = CFilterHangHoa.Tag.ToString()
            If (String.IsNullOrEmpty(stemp)) Then
                Message_Warning("Mã hàng hóa bắt buộc nhập!")
                CFilterHangHoa.Focus()
                Exit Sub
            End If

            ' Save record process
            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công") '"Data saved"
            DialogResult = System.Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtSO_LUONG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSO_LUONG.TextChanged
        Try
            ' Tinh TT
            txtTHANH_TIEN.Text = ThanhTien()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDONGIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDON_GIA_VON.TextChanged
        Try
            ' Tinh TT
            txtTHANH_TIEN.Text = ThanhTien()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSoDuTaiKhoan_Kho2_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlNGOAI_TE_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlNGOAI_TE_ID.EditValueChanged
        Try
            ' Chon ngoai te la VND
            If grlNGOAI_TE_ID.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                txtTY_GIA.Text = "1"
                txtTY_GIA.Properties.Enabled = False
                txtDON_GIA_VON_NTE.Properties.Enabled = False
                ' Cho phep edit Don gia von
                txtDON_GIA_VON.Properties.ReadOnly = False
            Else
                ' Chon ngoai te khac VND
                txtTY_GIA.Properties.Enabled = True
                txtDON_GIA_VON_NTE.Properties.Enabled = True
                ' Khong cho phep edit Don gia von
                txtDON_GIA_VON.Properties.ReadOnly = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA.TextChanged
        Try
            Dim tyGia As String = txtTY_GIA.Text.Trim()
            Dim donGiaNT As String = txtDON_GIA_VON_NTE.Text.Trim()

            If Not String.IsNullOrEmpty(tyGia) Then
                If Not String.IsNullOrEmpty(donGiaNT) Then
                    txtDON_GIA_VON.Text = Math.Round(Convert.ToDecimal(tyGia) * Convert.ToDecimal(donGiaNT))
                End If
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDON_GIA_VON_NTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDON_GIA_VON_NTE.TextChanged
        Try
            Dim donGiaNT As String = txtDON_GIA_VON_NTE.Text.Trim()
            Dim tyGia As String = txtTY_GIA.Text.Trim()

            If Not String.IsNullOrEmpty(tyGia) Then
                If Not String.IsNullOrEmpty(donGiaNT) Then
                    txtDON_GIA_VON.Text = Math.Round(Convert.ToDecimal(tyGia) * Convert.ToDecimal(donGiaNT))
                End If
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub SavingMemory(ByVal _option As Integer)
        Select Case (_option)
            Case 1
                If TK_DATA_SOURCE Is Nothing Then
                    TK_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
            Case 2
                If KHANG_DATA_SOURCE Is Nothing Then
                    KHANG_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
            Case 3
                If HANGHOA_DATA_SOURCE Is Nothing Then
                    HANGHOA_DATA_SOURCE = DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
            Case 10
                If TK_DATA_SOURCE Is Nothing Then
                    TK_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
                If KHANG_DATA_SOURCE Is Nothing Then
                    KHANG_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
                If HANGHOA_DATA_SOURCE Is Nothing Then
                    HANGHOA_DATA_SOURCE = DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                End If
            Case Else
        End Select
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        Try
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            txtTEN_TAIKHOAN.Text = cFilterTaiKhoan.ListEditValue(2)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterFilter
        Try
            If cFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterHANGHOA_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFilterHangHoa.AfterFilter
        Try
            ' Hien thi ten cua hang hoa trong textbox
            CFilterHangHoa.Tag = CFilterHangHoa.ListEditValue(0)
            txtTEN_HANGHOA.Text = CFilterHangHoa.ListEditValue(1)

            ' Hien thi DVT cua hang hoa trong combobox
            grlDVT_ID.EditValue = CFilterHangHoa.ListEditValue(4)

            ' Switch tab to next control
            If CFilterHangHoa.IsNotTextChanged Then SendKeys.Send("{TAB}")

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterQuickAdd
        Try
            cFilterTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterQuickAdd
        Try
            cFilter.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData, CFilterHangHoa.ClearFilterData
        Dim ctl As Vns.Erp.Core.CustomFilter
        ctl = sender

        ctl.Tag = ""
    End Sub

    Private Sub cFilter_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) 'Handles cFilterTaiKhoan.Validating, CFilterHangHoa.Validating
        Dim ctl As Vns.Erp.Core.CustomFilter
        ctl = sender
        If ctl.Tag = Nothing Then
            Message_Warning("Thông tin bắt buộc nhập!")
            e.Cancel = True
        End If
    End Sub

    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            SavingMemory(1)
            cFilterTaiKhoan.C_DATA_SOURCE = TK_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CFilterHangHoa_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFilterHangHoa.FirstBinddata
        Try
            SavingMemory(3)
            CFilterHangHoa.C_DATA_SOURCE = HANGHOA_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.FirstBinddata
        Try
            SavingMemory(2)
            cFilter.C_DATA_SOURCE = KHANG_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    
End Class