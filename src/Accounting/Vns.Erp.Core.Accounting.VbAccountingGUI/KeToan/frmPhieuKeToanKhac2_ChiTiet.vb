Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.Utils

Public Class frmPhieuKeToanKhac2_ChiTiet

#Region "Property"
    Private _CtThueService As ICtThueService
    Public Property CtThueService() As ICtThueService
        Get
            Return _CtThueService
        End Get
        Set(ByVal value As ICtThueService)
            _CtThueService = value
        End Set
    End Property

    Private _CtHoadonService As ICtHoadonService
    Public Property CtHoadonService() As ICtHoadonService
        Get
            Return _CtHoadonService
        End Get
        Set(ByVal value As ICtHoadonService)
            _CtHoadonService = value
        End Set
    End Property

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

    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
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

    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
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

    Private _DmPtqtService As IDmPtqtService
    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
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

    Private _KtKhoasoThangService As IKtKhoasoThangService
    Public Property KtKhoasoThangService() As IKtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As IKtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property

    Private _LsTygiaService As ILsTygiaService
    Public Property LsTygiaService() As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(ByVal value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Private obj_ct_h As CtH = New CtH()
    Private lstobj_ct_d_k As List(Of Extend.CT_D_KInfo) = New List(Of Extend.CT_D_KInfo)
    Private del_lstobj_ct_d_k As List(Of Extend.CT_D_KInfo) = New List(Of Extend.CT_D_KInfo)
    'Private lstobj_ct_h As List(Of CtH) = New List(Of CtH)
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private m_MA_LOAI_CT As String
    Private TongPSNO As Decimal
    Private TongPSCO As Decimal
    Private TongPSNONT As Decimal
    Private TongPSCONT As Decimal
    Private objHTCT As HtLoaichungtu
    Private obj_ct_d As Extend.CT_D_KInfo
    Private sotien As Decimal
    Public lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Private KHANG_DATA_SOURCE As DataTable = Nothing
    Private CT_HOADON_DATA_SOURCE As DataTable = Nothing
    Private TK_DATA_SOURCE As DataTable = Nothing
    Private Flag_copy As Boolean = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgChuaKeThue As String = "Thông tin tài khoản thuế chhưa được khai báo!"
    Dim msgDinhKhoanKoHopLe As String = "Định khoản không hợp lệ!"
    ''' <summary>
    ''' Bien quy dinh dang trong trang thai load data
    ''' </summary>
    ''' <remarks></remarks>
    Private OnLoadData = False
    Private FlagDG As Decimal = 0
#End Region

#Region "Load Form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        UC_Status.Visible = Generals.Ts_PheDuyetChungTu
        UC_Status.Enabled = Generals.Ts_PheDuyetChungTu
        btnCopy.Visible = False
        btnCopy.Enabled = False
        GRV_CTH.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
        'Validate control
        Commons.RequireInputControls = New Control() {daeNGAY_GHI, daeNGAY_CT}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

    Public Function Show_Form(ByVal CTH_ID As Guid, ByVal MA_LOAI_CT As String, ByVal TEN_LOAI_CT As String, ByVal lstcthg As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As CtH
        Try
            Form_SetText(Me, TEN_LOAI_CT, DataInputState.NoCaption)
            Form_InitDialog(Me)
            Panel_InitControl(grpSMQR, "CT_H")
            m_InputState = eState
            m_CTH_ID = CTH_ID
            If lstcthg IsNot Nothing Then
                lstobj_ct_h_gg = lstcthg
            End If
            m_MA_LOAI_CT = MA_LOAI_CT
            Dim objHTCT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
            UC_Status.LCT_STATUS = objHTCT.Id
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()

            AddHandler GRV_CTH.FocusedRowChanged, AddressOf GRV_CTH_FocusedRowChanged
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return obj_ct_h
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Private Function and Procedures"

    Private Sub Load_Grid(ByVal lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo))
        If lstobj_ct_h_gg IsNot Nothing And lstobj_ct_h_gg.Count > 0 Then
            GRC_CTH.DataSource = Nothing
            GRC_CTH.DataSource = lstobj_ct_h_gg
            For i = 0 To lstobj_ct_h_gg.Count - 1
                If m_CTH_ID = lstobj_ct_h_gg(i).Id Then
                    Me.GRV_CTH.FocusedRowHandle = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (GRV_CTH.GetSelectedRows().Length > 0) Then
            If (GRV_CTH.RowCount <> 0) Then
                Dim grtCTHG As Extend.CT_H_GInfo = CType(GRV_CTH.GetRow(GRV_CTH.GetSelectedRows(0)), Extend.CT_H_GInfo)
                m_CTH_ID = grtCTHG.Id
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub grv_focus()
        Dim lst As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
        lst = GRV_CTH.DataSource
        For i As Integer = 0 To GRV_CTH.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                GRV_CTH.FocusedRowHandle = i
                lst(i).Ghi = obj_ct_h.Ghi
                GRV_CTH.RefreshData()
            End If
        Next
    End Sub

    Private Sub Init_Data()
        OnLoadData = True
        Select Case m_InputState
            Case DataInputState.AddMode
                DatTrangThaiControl()
                BindLookup()
                daeNGAY_GHI.DateTime = DateTime.Now
                'SetColNgoaiTe(chkNgoaiTe.Checked)
                objHTCT = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
                SetCol(objHTCT)
                lstobj_ct_d_k.Add(New Extend.CT_D_KInfo())
                _GridControl.DataSource = lstobj_ct_d_k
                TongSoTien()
            Case Else
                DatTrangThaiControl()
                BindLookup()
                SetObjectToControl()
                TongSoTien()
        End Select
        Load_Grid(lstobj_ct_h_gg)
        OnLoadData = False
    End Sub

    Private Sub SaveData()
        GetControlToOBject()
        'LoadDB()
    End Sub

    Private Sub LoadDB()
        'lstobj_ct_h = CT_HBO.Instance.GetObjectGetObjectAllByLoaiChungTu(Generals.DON_VI.Id,m_MA_LOAI_CT)
        SetObjectToControl()
        TongSoTien()
    End Sub

    Private Function Check_tien_Thue() As Boolean
        Dim tien_thue_new As Decimal = 0
        Dim count_tkthue As Integer = 0
        Dim tien_thue_old As Decimal = 0

        If lstobj_ct_d_k.Count = 0 Then
            Return True
        End If

        'Lay list nhom(chua list cua tung nhom)
        Dim lstNhom As List(Of List(Of Extend.CT_D_KInfo)) = _CtDService.GetLstNhom(lstobj_ct_d_k)

        For Each ObjLst_nhom As List(Of Extend.CT_D_KInfo) In lstNhom
            tien_thue_new = 0
            tien_thue_old = 0
            count_tkthue = 0
            'Dem so tai khoan thue
            count_tkthue = _CtDService.Count_tk_thue(ObjLst_nhom)
            If count_tkthue <> 1 Then
                Return True
            End If
            For Each obj As Extend.CT_D_KInfo In ObjLst_nhom
                'Kiem tra xem co phai la tai khoan thue thoa man hay ko
                If (obj.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) Or (obj.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)) Then
                    If obj.LstCtThue IsNot Nothing Then
                        If obj.LstCtThue.Count <> 0 Then
                            For Each obj_thue As CtThue In obj.LstCtThue
                                tien_thue_new = tien_thue_new + obj_thue.SoTien
                            Next
                        End If
                    End If
                    If obj.PS_CO = 0 Then
                        tien_thue_old = obj.PS_NO
                    Else
                        tien_thue_old = obj.PS_CO
                    End If
                End If
            Next

            If tien_thue_new <> 0 Then
                If tien_thue_new <> tien_thue_old Then
                    Message_Warning("Tổng tiền thuế trong chi tiết thuế không hợp lệ!")
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Private Sub GetControlToOBject()
        'Xet truong hop copy du lieu
        If Flag_copy Then
            m_CTH_ID = Nothing
            obj_ct_h.Id = Nothing
            Flag_copy = False
        End If

        'lay nhieu gia tri trong 1 table khac
        obj_ct_h.MaLoaiCt = m_MA_LOAI_CT
        obj_ct_h.TyGia = txtTY_GIA1.Text

        obj_ct_h.SoDu = 0
        obj_ct_h.MaNte = cboNgoaiTe.Text
        obj_ct_h.NteId = VnsConvert.CGuid(cboNgoaiTe.EditValue)
        obj_ct_h.NgoaiTe = TNCommon.ParseDecimal(Not (VnsConvert.CGuid(cboNgoaiTe.EditValue) = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))
        obj_ct_h.NgayCt = daeNGAY_CT.DateTime
        obj_ct_h.NgayGhi = daeNGAY_GHI.DateTime
        obj_ct_h.SoTien = TongPSNO
        obj_ct_h.SoTienNte = TongPSNONT
        obj_ct_h.DienGiai = txtDIEN_GIAI.Text.Trim()
        obj_ct_h.IdLoaiCt = objHTCT.Id
        obj_ct_h.KyHieuLoaiCt = objHTCT.KyHieu
        obj_ct_h.Ghi = Convert.ToDecimal(UC_Status.Value_info.ParameterValue)

        If Generals.DON_VI.BoPhanTt = 1 Then
            obj_ct_h.DonviCt = Generals.DON_VI.DonviIdCha
        End If

        obj_ct_h.DonviId = Generals.DON_VI.Id
        obj_ct_h.MaDonvi = Generals.DON_VI.MaDonvi

        Select Case m_InputState
            Case DataInputState.AddMode
                Dim strmMonth As String
                strmMonth = Month(daeNGAY_GHI.DateTime).ToString
                Dim strYear As String
                strYear = Year(daeNGAY_GHI.DateTime).ToString

                C_SoChungTu_RP.r_SoCTPREFIX(obj_ct_h.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id)
                obj_ct_h.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                obj_ct_h.PrefixCt = C_SoChungTu_RP.PREFIX
                obj_ct_h.NguoiTao = Generals.USER.Id
            Case Else
                obj_ct_h.NguoiSua = Generals.USER.Id
        End Select

        For Each ctDKInfo As Extend.CT_D_KInfo In del_lstobj_ct_d_k
            For Each dKInfo As Extend.CT_D_KInfo In lstobj_ct_d_k
                If dKInfo.NHOM = ctDKInfo.NHOM Then
                    dKInfo.CTD_ID = Nothing
                End If
            Next
        Next

        'Save du lieu
        _CtHService.SaveCTDK(m_InputState, obj_ct_h, lstobj_ct_d_k, del_lstobj_ct_d_k)

        'gán giá trị so chung tu lai cho form
        C_SoChungTu_RP.Text = obj_ct_h.PrefixCt + obj_ct_h.CtSo
    End Sub

    Private Sub SetObjectToControl()
        'Lay lai Id trong truong hop Copy 
        If VnsCheck.IsNullGuid(m_CTH_ID) Then
            m_CTH_ID = obj_ct_h.Id
        End If

        obj_ct_h = _CtHService.GetById(m_CTH_ID)

        cboNgoaiTe.EditValue = obj_ct_h.NteId
        daeNGAY_GHI.DateTime = obj_ct_h.NgayGhi
        daeNGAY_CT.DateTime = obj_ct_h.NgayCt
        C_SoChungTu_RP.Text = obj_ct_h.PrefixCt + obj_ct_h.CtSo
        txtTY_GIA1.Text = obj_ct_h.TyGia
        txtDIEN_GIAI.Text = obj_ct_h.DienGiai
        UC_Status.Set_Status(obj_ct_h.Ghi)
        'UC_Status.cboStatus.EditValue = obj_ct_h.GHI.ToString()
        chkNgoaiTe.Checked = TNCommon.ParseBool(obj_ct_h.NgoaiTe)

        'SetColNgoaiTe(chkNgoaiTe.Checked)
        objHTCT = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
        SetCol(objHTCT)
        Dim lsttmp As List(Of CtD) = New List(Of CtD)
        lsttmp.AddRange(_CtDService.GetByCtHandNghiepVu(m_CTH_ID, 0))
        lstobj_ct_d_k = New List(Of Extend.CT_D_KInfo)
        lstobj_ct_d_k.AddRange(_CtDService.ConvertToCtDK(lsttmp))
        _GridControl.DataSource = lstobj_ct_d_k

        ''Kiểm tra trạng thái có cho phép sửa hay không
        If Not (UC_Status.ChoPhepSuaCT) Then
            UC_Status.Enabled = False
        Else
            UC_Status.Enabled = True
        End If
    End Sub

    Private Sub BindLookup()
        'Bind danh muc ngoai te
        Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
        lstNgoaite.AddRange(_DmNgoaiteService.GetAll())
        cboNgoaiTe.Properties.DisplayMember = "KyHieu"
        cboNgoaiTe.Properties.ValueMember = "Id"
        cboNgoaiTe.Properties.DataSource = lstNgoaite
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA1.Text = "1"
        pfeTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

        'Bind vụ việc       
        Dim lstVuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViec.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstVuViec_temp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim obj_VV As DmVuviec = New DmVuviec
        lstVuViec_temp.Add(obj_VV)
        lstVuViec_temp.AddRange(lstVuViec)

        cboVuViec.DataSource = lstVuViec_temp
        cboVuViec.DisplayMember = "KyHieu"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))

        'Bind Phương pháp quả trị

        Dim lstPPQT As List(Of DmPtqt) = New List(Of DmPtqt)

        lstPPQT.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstPPQT_temp As List(Of DmPtqt) = New List(Of DmPtqt)
        Dim obj_PTQT As DmPtqt = New DmPtqt
        lstPPQT_temp.Add(obj_PTQT)
        lstPPQT_temp.AddRange(lstPPQT)

        cboPTQT.DataSource = lstPPQT_temp
        cboPTQT.DisplayMember = "KyHieu"
        cboPTQT.ValueMember = "Id"
        cboPTQT.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã PTQT"))
        cboPTQT.Columns.Add(New LookUpColumnInfo("TenPtqt", "Tên PTQT"))

        'Bind phong ban
        Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstPhongBan.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstPhongBan_temp As List(Of DmPhongban) = New List(Of DmPhongban)
        Dim obj_PB As DmPhongban = New DmPhongban
        lstPhongBan_temp.Add(obj_PB)
        lstPhongBan_temp.AddRange(lstPhongBan)

        cboPhongBan.DataSource = lstPhongBan_temp
        cboPhongBan.DisplayMember = "KyHieu"
        cboPhongBan.ValueMember = "Id"
        cboPhongBan.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã phòng ban"))
        cboPhongBan.Columns.Add(New LookUpColumnInfo("TenPhongban", "Tên phòng ban"))

        'Bind khoan phi
        Dim lstKhoanPhi As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        lstKhoanPhi.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstKhoanPhi_temp As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        Dim obj_KP As DmKhoanphi = New DmKhoanphi
        lstKhoanPhi_temp.Add(obj_KP)
        lstKhoanPhi_temp.AddRange(lstKhoanPhi)

        cboKhoanPhi.DataSource = lstKhoanPhi_temp
        cboKhoanPhi.DisplayMember = "KyHieu"
        cboKhoanPhi.ValueMember = "Id"
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã khoản phí"))
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))

        'Bind tu do 1
        Dim lstTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo1_temp As List(Of DmTudo1) = New List(Of DmTudo1)
        Dim obj_TD1 As DmTudo1 = New DmTudo1
        lstTuDo1_temp.Add(obj_TD1)
        lstTuDo1_temp.AddRange(lstTuDo1)

        cboTuDo1.DataSource = lstTuDo1_temp
        cboTuDo1.DisplayMember = "KyHieu"
        cboTuDo1.ValueMember = "Id"
        cboTuDo1.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboTuDo1.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục"))
        'Bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo2_temp As List(Of DmTudo2) = New List(Of DmTudo2)
        Dim obj_TD2 As DmTudo2 = New DmTudo2
        lstTuDo2_temp.Add(obj_TD2)
        lstTuDo2_temp.AddRange(lstTuDo2)

        cboTuDo2.DataSource = lstTuDo2_temp
        cboTuDo2.DisplayMember = "KyHieu"
        cboTuDo2.ValueMember = "Id"
        cboTuDo2.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboTuDo2.Columns.Add(New LookUpColumnInfo("TenDmTudo2", "Tên danh mục"))

        'Bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo3_temp As List(Of DmTudo3) = New List(Of DmTudo3)
        Dim obj_TD3 As DmTudo3 = New DmTudo3
        lstTuDo3_temp.Add(obj_TD3)
        lstTuDo3_temp.AddRange(lstTuDo3)

        cboTuDo3.DataSource = lstTuDo3_temp
        cboTuDo3.DisplayMember = "KyHieu"
        cboTuDo3.ValueMember = "Id"
        cboTuDo3.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboTuDo3.Columns.Add(New LookUpColumnInfo("TenDmTudo3", "Tên danh mục"))

        'Bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo4_temp As List(Of DmTudo4) = New List(Of DmTudo4)
        Dim obj_TD4 As DmTudo4 = New DmTudo4
        lstTuDo4_temp.Add(obj_TD4)
        lstTuDo4_temp.AddRange(lstTuDo4)

        cboTuDo4.DataSource = lstTuDo4_temp
        cboTuDo4.DisplayMember = "KyHieu"
        cboTuDo4.ValueMember = "Id"
        cboTuDo4.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboTuDo4.Columns.Add(New LookUpColumnInfo("TenDmTudo4", "Tên danh mục"))

        'Bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo5_temp As List(Of DmTudo5) = New List(Of DmTudo5)
        Dim obj_TD5 As DmTudo5 = New DmTudo5
        lstTuDo5_temp.Add(obj_TD5)
        lstTuDo5_temp.AddRange(lstTuDo5)

        cboTuDo5.DataSource = lstTuDo5_temp
        cboTuDo5.DisplayMember = "KyHieu"
        cboTuDo5.ValueMember = "Id"
        cboTuDo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboTuDo5.Columns.Add(New LookUpColumnInfo("TenDmTudo5", "Tên danh mục"))
    End Sub

    Private Sub SetFocus_AfterAddRow()
        _GridView.FocusedRowHandle = _GridView.RowCount - 1
        _GridView.SelectRow(Handle)
        Try
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ThemDong()
        Dim obj As Extend.CT_D_KInfo = New Extend.CT_D_KInfo
        obj.NOI_DUNG = txtDIEN_GIAI.Text.Trim
        lstobj_ct_d_k.Add(obj)
        _GridView.RefreshData()

        SetFocus_AfterAddRow()
    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        If (ngoaite) Then
            txtTY_GIA1.Enabled = True
            _GridView.Columns("PS_NO").ColumnEdit.ReadOnly = True
            _GridView.Columns("PS_CO").ColumnEdit.ReadOnly = True
            _GridView.Columns("PS_NO_NT").VisibleIndex = 4
            _GridView.Columns("PS_NO").VisibleIndex = 5
            _GridView.Columns("PS_CO_NT").VisibleIndex = 6
            _GridView.Columns("PS_CO").VisibleIndex = 7


            '_GridView.Columns("NOI_DUNG").VisibleIndex = 8

        Else
            txtTY_GIA1.Enabled = False
            _GridView.Columns("PS_NO").ColumnEdit.ReadOnly = False
            _GridView.Columns("PS_CO").ColumnEdit.ReadOnly = False
            _GridView.Columns("PS_CO_NT").Visible = False
            _GridView.Columns("PS_NO_NT").Visible = False
        End If
    End Sub

    Private Sub DeleteRow()
        If _GridView.RowCount > 0 Then
            Dim gridctdk As Extend.CT_D_KInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), Extend.CT_D_KInfo)
            del_lstobj_ct_d_k.Add(gridctdk)
            _GridView.DeleteSelectedRows()
            TongSoTien()
        Else
            Message_Warning("Không có bản ghi nào ở chi tiết định khoản!")
        End If
    End Sub

    Private Sub TongSoTien()
        'tinh tong so tien
        Dim sumPSNO As Decimal
        Dim sumPSCO As Decimal
        Dim sumPSNONT As Decimal
        Dim sumPSCONT As Decimal
        Dim i As Integer
        For i = 0 To _GridView.RowCount - 1
            sumPSNO = sumPSNO + _GridView.GetRowCellValue(i, "PS_NO")
            sumPSCO = sumPSCO + _GridView.GetRowCellValue(i, "PS_CO")
            sumPSNONT = sumPSNONT + _GridView.GetRowCellValue(i, "PS_NO_NT")
            sumPSCONT = sumPSCONT + _GridView.GetRowCellValue(i, "PS_CO_NT")
        Next
        TongPSNO = sumPSNO.ToString
        TongPSCO = sumPSCO.ToString
        TongPSNONT = sumPSNONT.ToString
        TongPSCONT = sumPSCONT.ToString
        txtTongPSno.Text = TongPSNO
        txtTongPSco.Text = TongPSCO
    End Sub

    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                Control_SetState(grpSMQR, DataInputState.AddMode)
                Control_SetState(grcCT_Thue, DataInputState.AddMode)
                _GridView.OptionsBehavior.Editable = True

                GRC_CTH.Enabled = False
                navWelding1.Enabled = False

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnSav.Enabled = True
                btnDelete.Enabled = False
                btnPrinter.Enabled = False

                btnCan.Enabled = True
                btnThue.Enabled = True
                btnSea.Enabled = False

                txtTongPSco.Properties.ReadOnly = True
                txtTongPSno.Properties.ReadOnly = True

            Case DataInputState.EditMode
                Control_SetState(grpSMQR, DataInputState.EditMode)
                Control_SetState(grcCT_Thue, DataInputState.EditMode)
                _GridView.OptionsBehavior.Editable = True

                GRC_CTH.Enabled = False
                navWelding1.Enabled = False

                btnAdd.Enabled = False
                btnModify.Enabled = False

                btnSav.Enabled = True
                btnDelete.Enabled = True
                btnPrinter.Enabled = True

                btnCan.Enabled = True
                btnThue.Enabled = True
                btnSea.Enabled = False

                txtTongPSco.Properties.ReadOnly = True
                txtTongPSno.Properties.ReadOnly = True

            Case DataInputState.ViewMode
                Control_SetState(grpSMQR, DataInputState.ViewMode)
                Control_SetState(grcCT_Thue, DataInputState.ViewMode)
                _GridView.OptionsBehavior.Editable = False

                GRC_CTH.Enabled = True
                navWelding1.Enabled = True

                btnAdd.Enabled = True
                btnModify.Enabled = True

                btnSav.Enabled = False
                btnDelete.Enabled = True

                btnPrinter.Enabled = True

                btnCan.Enabled = False
                btnThue.Enabled = False
                btnSea.Enabled = True

                txtTongPSco.Properties.ReadOnly = True
                txtTongPSno.Properties.ReadOnly = True
        End Select
    End Sub

    Private Sub XoaTrang()
        'Try
        m_CTH_ID = Nothing
        UC_Status.Set_Status(1)
        txtDIEN_GIAI.Text = String.Empty
        C_SoChungTu_RP.Text = ""
        C_SoChungTu_RP.SO_CHUNG_TU = ""
        C_SoChungTu_RP.PREFIX = ""
        chkNgoaiTe.Checked = False
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA1.Text = "1"
        txtTongPSno.Text = "0"
        txtTongPSco.Text = "0"

        daeNGAY_GHI.DateTime = DateTime.Now
        daeNGAY_CT.DateTime = DateTime.Now
        _GridControl.DataSource = Nothing
        lstobj_ct_d_k = New List(Of Extend.CT_D_KInfo)
        lstobj_ct_d_k.Add(New Extend.CT_D_KInfo)
        del_lstobj_ct_d_k = New List(Of Extend.CT_D_KInfo)
        _GridControl.DataSource = lstobj_ct_d_k
        _GridView.RefreshData()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub SetFocus_FirstCell()
        ' _GridView.FocusedRowHandle = 0
        '_GridView.SelectRow(Handle)
        'Try
        _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub SetCol(ByVal _htLoaiCT As HtLoaichungtu)
        If _htLoaiCT Is Nothing Then
            Return
        End If

        _GridView.Columns("ID_DM_PTQT").Visible = _htLoaiCT.DmPtqt
        _GridView.Columns("ID_DM_PHONGBAN").Visible = _htLoaiCT.DmPhongban
        _GridView.Columns("ID_DM_KHOANPHI").Visible = _htLoaiCT.DmKhoanphi

        _GridView.Columns("ID_DM_VUVIEC").Visible = _htLoaiCT.DmVuviec
        _GridView.Columns("ID_DM_TUDO_1").Visible = _htLoaiCT.DmTudo1
        _GridView.Columns("ID_DM_TUDO_2").Visible = _htLoaiCT.DmTudo2
        _GridView.Columns("ID_DM_TUDO_3").Visible = _htLoaiCT.DmTudo3
        _GridView.Columns("ID_DM_TUDO_4").Visible = _htLoaiCT.DmTudo4
        _GridView.Columns("ID_DM_TUDO_5").Visible = _htLoaiCT.DmTudo5
        _GridView.Columns("TEN_KHANG").Visible = _htLoaiCT.DmKhang

    End Sub

    Private Function Check_input() As Boolean

        If String.IsNullOrEmpty(DB_GetString(DB_GetNull(daeNGAY_CT.DateTime))) Then
            Message_Warning("Bạn chưa nhập ngày chứng từ!")
            Return False
        End If

        If String.IsNullOrEmpty(DB_GetString(DB_GetNull(daeNGAY_GHI.DateTime))) Then
            Message_Warning("Bạn chưa nhập ngày hoạch toán!")
            Return False
        End If

        If daeNGAY_GHI.DateTime.Date > daeNGAY_CT.DateTime.Date Then
            Message_Warning("Ngày hoạch toán <= ngày chứng từ!")
            daeNGAY_GHI.Focus()
            Return False
        End If

        If _GridView.RowCount = 0 Then
            Message_Warning("Định khoản không được để trống!")
            Return False
        End If

        For Each obj As Extend.CT_D_KInfo In lstobj_ct_d_k
            If VnsCheck.IsNullGuid(obj.TK_ID) Then
                Message_Warning("Bạn chưa nhập đủ tài khoản cho chi tiết định khoản!")
                Return False
            End If

            If VnsCheck.IsNullGuid(obj.ID_KHANG) And obj.KY_HIEU_KHANG <> "" Then
                Message_Warning("Giá trị mã khách hàng nhập vào không đúng!")
                Return False
            End If

            If VnsConvert.CGuid(cboNgoaiTe.EditValue) <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                If obj.PS_CO_NT = 0 And obj.PS_NO_NT = 0 Then
                    Message_Warning("Giá trị phát sinh nợ ngoại tệ hoặc phát sinh có ngoại tệ không hợp lệ!")
                    Return False
                End If
            End If

            If obj.PS_CO = 0 And obj.PS_NO = 0 Then
                Message_Warning("Giá trị phát sinh nợ hoặc phát sinh có không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckFCurrency(obj.PS_CO_NT) Then
                Message_Warning("Giá trị phát sinh có NT không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(obj.PS_CO) Then
                Message_Warning("Giá trị phát sinh có không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckFCurrency(obj.PS_NO_NT) Then
                Message_Warning("Giá trị phát sinh nợ NT không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(obj.PS_NO) Then
                Message_Warning("Giá trị phát sinh nợ không hợp lệ!")
                Return False
            End If

        Next

        If txtTongPSco.Text <> txtTongPSno.Text Then
            Message_Warning("Giá trị phát sinh nợ và phát sinh có phải bằng nhau")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "Events"

    Private Sub _GridView_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles _GridView.CellValueChanged
        Try
            Try
                Dim gridctdk As Extend.CT_D_KInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), Extend.CT_D_KInfo)

                If gridctdk Is Nothing Then
                    Return
                End If

                Dim tygia As Decimal = 0
                If txtTY_GIA1.Text.Trim <> "" Then
                    tygia = Convert.ToDecimal(txtTY_GIA1.Text.Trim())
                End If

                Select Case e.Column.Name
                    Case "PS_NO"
                        'Gan vao GridView
                        If gridctdk.PS_NO <> 0 Then
                            gridctdk.PS_CO = 0
                        End If
                    Case "PS_CO"
                        'Gan vao GridView
                        If gridctdk.PS_CO <> 0 Then
                            gridctdk.PS_NO = 0
                        End If
                    Case "MA_VUVIEC"
                        Dim cbovu_viec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctdk.ID_DM_VUVIEC),  _
                                                                 DmVuviec)
                        gridctdk.ID_DM_VUVIEC = cbovu_viec.Id
                        gridctdk.MA_VUVIEC = cbovu_viec.MaVuviec
                        gridctdk.KY_HIEU_VUVIEC = cbovu_viec.KyHieu
                    Case "ID_DM_PTQT"
                        Dim cboPTQT As DmPtqt = CType(_cboPTQT.GetDataSourceRowByKeyValue(gridctdk.ID_DM_PTQT),  _
                                                            DmPtqt)
                        gridctdk.ID_DM_PTQT = cboPTQT.Id
                    Case "PS_NO_NT"
                        Dim ps_no_nt As Decimal = gridctdk.PS_NO_NT
                        gridctdk.PS_NO = Math.Round(ps_no_nt * tygia, 0)
                        If gridctdk.PS_NO_NT <> 0 Then
                            gridctdk.PS_CO_NT = 0
                            gridctdk.PS_CO = 0
                        End If
                    Case "PS_CO_NT"
                        Dim ps_co_nt As Decimal = gridctdk.PS_CO_NT '_GridView.GetRowCellValue(_GridView.FocusedRowHandle, "PS_CO_NT")
                        gridctdk.PS_CO = Math.Round(ps_co_nt * tygia, 0) '_GridView.SetRowCellValue(_GridView.FocusedRowHandle, "PS_CO", Math.Round(ps_co_nt * tygia))
                        'Gan vao GridView
                        If gridctdk.PS_CO_NT <> 0 Then
                            gridctdk.PS_NO_NT = 0
                            gridctdk.PS_NO = 0
                        End If
                End Select

                TongSoTien()
            Catch ex As OverflowException
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkNgoaiTe_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNgoaiTe.CheckedChanged
        'SetColNgoaiTe(chkNgoaiTe.Checked)
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _GridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (GridHelper.CheckAddNewRow(_GridView)) Then
                    ThemDong()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub daeNGAY_CT_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles daeNGAY_GHI.EditValueChanged
        Try
            daeNGAY_CT.DateTime = daeNGAY_GHI.DateTime
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSav.Click
        Try
            AddHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            Me.ValidateChildren()
            If Not UC_Status.ChoPhepSuaCT Then
                Message_Warning("Bạn không được phép sửa chứng từ này!")
                Return
            End If

            If obj_ct_h Is Nothing Then
                obj_ct_h = New CtH
            End If

            'Check khoa so thang
            If obj_ct_h.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            If _KtKhoasoThangService.KiemTraKhoaSo(daeNGAY_CT.DateTime, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            'Check du lieu input
            If Not Check_input() Then
                'Message_Warning(msgDinhKhoanKoHopLe)
                Return
            End If

            If Not _CtDService.CheckValidateCTDK(lstobj_ct_d_k, True) Then
                Return
            End If

            'check tien thue GTGT dau vao
            If Not Check_tien_Thue() Then
                Message_Warning(msgChuaKeThue)
                Return
            End If

            frmProgress.Instance.Thread = AddressOf SaveData
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            'Refresh left grid
            m_CTH_ID = obj_ct_h.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h)
            GridHelper.RefreshLeftGrid(GRV_CTH, lstobj_ct_h_gg, editObject, m_InputState)

            If m_InputState = DataInputState.EditMode Then
                LoadDB()
            End If

            m_InputState = DataInputState.ViewMode

            DatTrangThaiControl()

            btnAdd.Focus()
            grv_focus()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuit.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub frmChungTuBuTruCongNo_ChiTiet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
                    Exit Select
                Case Keys.F4
                    If m_InputState = DataInputState.EditMode Or m_InputState = DataInputState.AddMode Then
                        ThemDong()
                    End If
                    Exit Select

                Case Keys.F8
                    If m_InputState = DataInputState.EditMode Or m_InputState = DataInputState.AddMode Then
                        DeleteRow()
                    End If
                    Exit Select
                Case e.Control And Keys.F11
                    'Dim frm_log As Global.KTY.Security.frmViewLog_DanhSach
                    'If m_InputState <> DataInputState.AddMode Then
                    '    frm_log = New Global.KTY.Security.frmViewLog_DanhSach(m_CTH_ID, obj_ct_h.ID_LOAI_CT, obj_ct_h.CT_SO)
                    '    frm_log.ShowDialog()
                    'End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPrinter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrinter.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
            Dim obj_form = CType(ObjectFactory.GetObject("frmPhieu_Input", New Object() {m_CTH_ID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            obj_ct_h = New CtH
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            XoaTrang()
            daeNGAY_GHI.Focus()
            FlagDG = 0
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        Try
            m_InputState = DataInputState.EditMode

            DatTrangThaiControl()

            SetFocus_FirstCell()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click_(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            If Not UC_Status.ChoPhepSuaCT Then
                Message_Warning("Bạn không được phép xóa chứng từ này!")
                Return
            End If

            'Check kho'a so? tha'ng
            If obj_ct_h.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            Dim currentStatus As DataInputState = m_InputState
            If lstobj_ct_h_gg.Count > 0 Then
                If Not (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
                    Exit Sub
                End If

                _CtHService.DeleteChungTuCTHK(obj_ct_h, lstobj_ct_d_k)

                m_CTH_ID = GridHelper.RemoveLeftGrid(lstobj_ct_h_gg, m_CTH_ID)
                If Not VnsCheck.IsNullGuid(m_CTH_ID) Then
                    LoadDB()
                End If
                GRV_CTH.RefreshData()

                m_InputState = currentStatus
                DatTrangThaiControl()
            End If

            If lstobj_ct_h_gg.Count = 0 Then
                XoaTrang()
                m_InputState = DataInputState.AddMode
                DatTrangThaiControl()
                GRC_CTH.DataSource = Nothing
            End If
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCan.Click
        Try
            Flag_copy = False
            If GRV_CTH.RowCount <> 0 Then
                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
                    GRV_CTH.FocusedRowHandle = lstobj_ct_h_gg.Count - 1
                End If
                SetObjectToControl()
                TongSoTien()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If

            DatTrangThaiControl()

            If GRV_CTH.RowCount = 0 Then
                btnModify.Enabled = False
                btnDelete.Enabled = False
            Else
                btnModify.Enabled = True
                btnDelete.Enabled = True
            End If
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkNgoaiTe_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles chkNgoaiTe.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmChungTuBuTruCongNo_ChiTiet_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = DialogResult.OK
    End Sub

    Private Sub _GridView_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles _GridView.GotFocus
        Try
            'SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuKeToanKhac2_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("ID_DM_TUDO_1").Caption = Generals.TS_TuDo1.GiaTri
            _GridView.Columns("ID_DM_TUDO_2").Caption = Generals.TS_TuDo2.GiaTri
            _GridView.Columns("ID_DM_TUDO_3").Caption = Generals.TS_TuDo3.GiaTri
            _GridView.Columns("ID_DM_TUDO_4").Caption = Generals.TS_TuDo4.GiaTri
            _GridView.Columns("ID_DM_TUDO_5").Caption = Generals.TS_TuDo5.GiaTri

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function GetRowSelect1() As Extend.CT_D_KInfo
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim grinkh As Extend.CT_D_KInfo = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), Extend.CT_D_KInfo)
                Return grinkh
            End If
        End If
        Return Nothing
    End Function

    Private Sub btnThueGTGT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThue.Click
        Try
            If _GridView.RowCount = 0 Then
                Message_Warning("Chi tiết định khoản không được để trống!")
                Return
            End If

            Dim tempobjctdk As Extend.CT_D_KInfo = GetRowSelect1()

            If tempobjctdk Is Nothing Then
                Message_Warning("Bạn chưa chọn đúng định khoản thuế!")
                Return
            End If

            If tempobjctdk.PS_NO <> 0 Then
                sotien = tempobjctdk.PS_NO
            Else
                sotien = tempobjctdk.PS_CO
            End If

            Dim lstnhomctdk As List(Of List(Of Extend.CT_D_KInfo)) = _CtDService.GetLstNhom(lstobj_ct_d_k)

            For Each lstctdkbynhom As List(Of Extend.CT_D_KInfo) In lstnhomctdk
                If lstctdkbynhom(0).NHOM = tempobjctdk.NHOM Then
                    Dim count As Integer = 0
                    For Each ctDKInfo As Extend.CT_D_KInfo In lstctdkbynhom
                        If ctDKInfo.MA_TK Is Nothing Then
                            ctDKInfo.MA_TK = ""
                        End If

                        If ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) Or ctDKInfo.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri) Then
                            count = count + 1
                        End If
                    Next
                    If count > 1 Then
                        'Message_Warning("Dữ liệu không hợp lệ")
                        Return
                    End If
                End If
            Next

            If tempobjctdk.MA_TK Is Nothing Then
                tempobjctdk.MA_TK = ""
            End If
            If tempobjctdk.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) Or tempobjctdk.MA_TK.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri) Then
                Dim f As frmChungTuThue2 = CType(ObjectFactory.GetObject("frmChungTuThue2"), frmChungTuThue2)
                Dim thue As Boolean

                'Dau vao: mua hang
                If tempobjctdk.MA_TK.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) Then
                    thue = True
                Else
                    thue = False
                End If
                f.Show_Form(tempobjctdk, sotien, daeNGAY_GHI.DateTime, thue)
                _GridView.RefreshData()
            Else
                Message_Warning("Bạn chọn chưa đúng định khoản thuế!")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GRV_CTH_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Try
            If GetRowSelect() Then
                LoadDB()
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        'Try
        '    Dim frmSearchCT As frmTimKiemChungTuKeToan = CType(ObjectFactory.GetObject("frmTimKiemChungTuKeToan"), frmTimKiemChungTuKeToan)

        '    If f.Show_Form(m_MA_LOAI_CT) IsNot Nothing Then
        '        lstobj_ct_h_gg = f.Show_Form(m_MA_LOAI_CT)
        '    Else
        '        Return
        '    End If

        '    If lstobj_ct_h_gg IsNot Nothing Then
        '        'Try
        '        If lstobj_ct_h_gg.Count <> 0 Then
        '            m_CTH_ID = lstobj_ct_h_gg(0).CTH_NX_ID
        '            Load_Grid(lstobj_ct_h_gg)
        '            SetObjectToControl()
        '            'SetTongTienThue()
        '            TongSoTien()
        '        End If
        '        'Catch ex As Exception
        '        '    Message_Error(ex)
        '        'End Try
        '    End If

        '    m_InputState = DataInputState.ViewMode
        '    DatTrangThaiControl()

        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try

        Try
            Dim frmSearchCT As frmTimKiemChungTuKeToan = CType(ObjectFactory.GetObject("frmTimKiemChungTuKeToan"), frmTimKiemChungTuKeToan)

            Dim m_LstCT_H_GInfo_temp As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)

            'Dim tmploaict As HtLoaichungtu = ComboHelper.GetSelectData(grlLOAI_CT_ID)
            m_LstCT_H_GInfo_temp = frmSearchCT.Show_Form(m_MA_LOAI_CT)

            If m_LstCT_H_GInfo_temp Is Nothing Then
                Return
            End If

            lstobj_ct_h_gg = m_LstCT_H_GInfo_temp
            If lstobj_ct_h_gg.Count > 0 Then
                m_CTH_ID = lstobj_ct_h_gg(0).Id
                Load_Grid(lstobj_ct_h_gg)
                SetObjectToControl()
                'SetTongTienThue()
                TongSoTien()
            End If
            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA1.TextChanged
        Try
            If _GridView.Columns("PS_NO_NT").Visible And _GridView.Columns("PS_CO_NT").Visible Then
                Dim tygia As String = txtTY_GIA1.Text.Trim()
                If String.IsNullOrEmpty(tygia) Then
                    Return
                End If

                For Each ctDKInfo As Extend.CT_D_KInfo In lstobj_ct_d_k
                    'If ctDKInfo.PS_NO_NT <> 0 Then
                    Try
                        ctDKInfo.PS_NO = Math.Round(ctDKInfo.PS_NO_NT * tygia, 0)
                        'End If
                        'If PS_CO_NT <> 0 Then
                        ctDKInfo.PS_CO = Math.Round(ctDKInfo.PS_CO_NT * tygia, 0)
                        ' End If
                    Catch ex As OverflowException
                        Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                        'txtTY_GIA1.Text = "1"
                        Return
                    End Try
                Next
                _GridView.RefreshData()
            End If

            TongSoTien()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboNgoaiTe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNgoaiTe.EditValueChanged
        Try
            If VnsConvert.CGuid(cboNgoaiTe.EditValue) = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                SetColNgoaiTe(False)
                For Each obj As Extend.CT_D_KInfo In lstobj_ct_d_k
                    obj.PS_CO_NT = 0
                    obj.PS_NO_NT = 0
                Next
                txtTY_GIA1.Text = "1"
            Else
                SetColNgoaiTe(True)
                If Not (OnLoadData) Then
                    txtTY_GIA1.Text = _LsTygiaService.GetTyGiaNgoaiTe(cboNgoaiTe.EditValue, daeNGAY_CT.EditValue)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            C_SoChungTu_RP.Text = ""
            Flag_copy = True
            del_lstobj_ct_d_k = New List(Of Extend.CT_D_KInfo)
            For Each obj As Extend.CT_D_KInfo In lstobj_ct_d_k
                obj.CTD_ID = Nothing
                obj.CTH_ID = Nothing
                obj.CT_HOADON = Nothing
                obj.LstDelCtThue = New List(Of CtThue)
                obj.LstCtThue = New List(Of CtThue)
            Next

            obj_ct_h.DaKhoaSo = 0
            TongSoTien()
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
        ElseIf _option = 3 Then 'CT_HOADON
            If CT_HOADON_DATA_SOURCE Is Nothing Then
                CT_HOADON_DATA_SOURCE = DataHelper.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 10 Then 'ALL
            If TK_DATA_SOURCE Is Nothing Then
                TK_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If KHANG_DATA_SOURCE Is Nothing Then
                KHANG_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If CT_HOADON_DATA_SOURCE Is Nothing Then
                CT_HOADON_DATA_SOURCE = DataHelper.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        End If
    End Sub

    Private Sub SavingMemoryForRepository(ByVal colName As String)
        Select Case colName
            Case "MA_TK"
                If pfeTaiKhoan.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If TK_DATA_SOURCE Is Nothing Then
                        pfeTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        pfeTaiKhoan.C_DATA_SOURCE = TK_DATA_SOURCE
                    End If
                    pfeTaiKhoan.Editors.A_DATA_SOURCE = pfeTaiKhoan.C_DATA_SOURCE
                End If

            Case "KY_HIEU_KHANG"
                If pfeKhang.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If KHANG_DATA_SOURCE Is Nothing Then
                        pfeKhang.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        pfeKhang.C_DATA_SOURCE = KHANG_DATA_SOURCE
                    End If
                    pfeKhang.Editors.A_DATA_SOURCE = pfeKhang.C_DATA_SOURCE
                End If
            Case "MA_HOADON"
                If MyRepositoryItem_MA_HOADON.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If CT_HOADON_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_HOADON.C_DATA_SOURCE = DataHelper.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_HOADON.C_DATA_SOURCE = CT_HOADON_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_HOADON.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_HOADON.C_DATA_SOURCE
                End If
            Case Else
        End Select
    End Sub

    Private Sub MyRepositoryItem_FirstBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles pfeTaiKhoan.FisrtBinddata, pfeKhang.FisrtBinddata, pfeKhang.AfterQuickAdd, MyRepositoryItem_MA_HOADON.FisrtBinddata
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            SavingMemoryForRepository(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles pfeTaiKhoan.AfterFilter, pfeKhang.AfterFilter, MyRepositoryItem_MA_HOADON.AfterFilter
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            Dim gridctdk As Extend.CT_D_KInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), Extend.CT_D_KInfo)
            If gridctdk Is Nothing Then
                Return
            End If
            Select Case columnName
                Case "MA_TK"
                    If (pfeTaiKhoan.OwnerEdit.A_LIST_VALUES.Count <> 0) Then
                        pfeTaiKhoan.Tag = pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(0)
                        gridctdk.TK_ID = VnsConvert.CGuid(pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(0))
                        gridctdk.MA_TK = pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(1)
                        gridctdk.TEN_TK = pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(2)
                        '_GridView.SetRowCellValue(rowHandle, "MA_TK_NO", arr(1))
                        _GridView.SetRowCellValue(rowHandle, "MA_TK", gridctdk.MA_TK)
                    End If

                Case "KY_HIEU_KHANG"
                    If (pfeKhang.OwnerEdit.A_LIST_VALUES.Count <> 0) Then
                        pfeKhang.Tag = pfeKhang.OwnerEdit.A_LIST_VALUES(0)
                        gridctdk.KY_HIEU_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(3)
                        gridctdk.ID_KHANG = VnsConvert.CGuid(pfeKhang.OwnerEdit.A_LIST_VALUES(0))
                        gridctdk.MA_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(2)
                        gridctdk.TEN_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(1)
                        _GridView.SetRowCellValue(rowHandle, "KY_HIEU_KHANG", gridctdk.KY_HIEU_KHANG)
                    End If
                Case "MA_HOADON"
                    If (MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES.Count <> 0) Then
                        MyRepositoryItem_MA_HOADON.Tag = VnsConvert.CGuid(MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(0))
                        gridctdk.ID_DOITUONG_HOADON = VnsConvert.CGuid(MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(0))
                        gridctdk.MA_HOADON = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdk.KY_HIEU_HOADON = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(2)
                        _GridView.SetRowCellValue(rowHandle, "MA_HOADON", gridctdk.MA_HOADON)
                    End If
                Case Else
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub pfeTaiKhoan_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles pfeTaiKhoan.ClearDataFilter, pfeKhang.ClearDataFilter
        Try
            Dim obj As Extend.CT_D_KInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), Extend.CT_D_KInfo)
            If obj IsNot Nothing Then
                Select Case _GridView.FocusedColumn().Name
                    Case "MA_TK"
                        If pfeTaiKhoan.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                            obj.TK_ID = VnsConvert.CGuid(pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(0))
                            obj.MA_TK = pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(1)
                            obj.TEN_TK = pfeTaiKhoan.OwnerEdit.A_LIST_VALUES(2)
                        End If
                    Case "KY_HIEU_KHANG"
                        If pfeKhang.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                            obj.ID_KHANG = VnsConvert.CGuid(pfeKhang.OwnerEdit.A_LIST_VALUES(0))
                            obj.TEN_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(1)
                            obj.MA_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(2)
                            obj.KY_HIEU_KHANG = pfeKhang.OwnerEdit.A_LIST_VALUES(3)
                        End If
                    Case "MA_HOADON"
                        If (MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES.Count <> 0) Then
                            MyRepositoryItem_MA_HOADON.Tag = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(0)
                            obj.ID_DOITUONG_HOADON = VnsConvert.CGuid(MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(0))
                            obj.MA_HOADON = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(1)
                            obj.KY_HIEU_HOADON = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES(2)
                        End If
                End Select
            End If
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDIEN_GIAI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDIEN_GIAI.Leave
        Try
            If FlagDG = 0 Then
                If m_InputState = DataInputState.AddMode Then
                    If _GridView.RowCount > 0 Then
                        Dim obj As Extend.CT_D_KInfo = CType(_GridView.GetRow(0), Extend.CT_D_KInfo)
                        obj.NOI_DUNG = txtDIEN_GIAI.Text
                        _GridView.RefreshData()
                        FlagDG = FlagDG + 1
                    End If
                End If
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub _GridView_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = _GridView.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "MA_TK"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                    'Case "KY_HIEU_KHANG"
                    '    If val = "" Then
                    '        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    '    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class