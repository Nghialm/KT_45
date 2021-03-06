Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Reflection

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface

Public Class frmLichSuHaoMon_ThangNguonVon

#Region "variables"

    ''list danh mục tai san co dinh
    Private lst_DM_TSCD As List(Of DmTscd) = New List(Of DmTscd)

    'object info lich su hao mon
    Private obj_LS_HM As TsLsKhauhao

    Private lst_LS_HM As List(Of TsLsKhauhao) = New List(Of TsLsKhauhao)
    'list chứa tất cả tai san lich su khau hao da tinh
    Private lst_fist_LS As List(Of TsLsKhauhao) = New List(Of TsLsKhauhao)

    'list chua lich su tai san da bi xoa
    Private lst_del As List(Of TsLsKhauhao) = New List(Of TsLsKhauhao)

    'cờ nhan biet xem co xoa du lieu cu hay ko
    Private flag As Boolean = False

    'phuong phap tinh khau hao la ntn(o day tinh theo tung thang)
    Private PP_Tinh As Boolean = False 'true= khau hao  , false = khau hao theo thang
    Private fn As Function_KH

    'object info CT_H
    Private obj_CTH As CtH

    'list CT_D
    Private lst_CTD As IList(Of CtD) = New List(Of CtD)

    Private lst_del_cth As List(Of Guid) = New List(Of Guid)
    Private LOAI_CT As String
    Private lst_KH_Thang As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)

    Dim lst_temp_kh_thang As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)

    Private NGAY_TINH As DateTime

    'list khấu hao nguon
    Private lst_kh_thang_nguon As List(Of Ts_Ls_KhauHao_ThangNGuonVoninfo) = New List(Of Ts_Ls_KhauHao_ThangNGuonVoninfo)

    Private lst_del_khNguon As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)

    Private dt As List(Of DmTaikhoan)
    'Quy định
    ''obj_LSHM.BAO_CAO=1(Tất cả cha) (Phục vụ báo cáo)
    ''obj_LSHM.CHITIET=1 (Con) (Phục vụ tính định khoản)
    ''Nếu không có chi tiết(ko được phân bổ theo nguồn vốn):obj_LSHM.BAO_CAO=obj_LSHM.CHITIET=1
#End Region

#Region "Property"
    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Private _TsLsKhauhaoService As ITsLsKhauhaoService
    Public Property TsLsKhauhaoService As ITsLsKhauhaoService
        Get
            Return _TsLsKhauhaoService
        End Get
        Set(ByVal value As ITsLsKhauhaoService)
            _TsLsKhauhaoService = value
        End Set
    End Property

    Private _TsCtTscdNvonService As ITsCtTscdNvonService
    Public Property TsCtTscdNvonService As ITsCtTscdNvonService
        Get
            Return _TsCtTscdNvonService
        End Get
        Set(ByVal value As ITsCtTscdNvonService)
            _TsCtTscdNvonService = value
        End Set
    End Property

    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _CtHService As ICtHService
    Public Property CtHService As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property

    Private _CtDService As ICtDService
    Public Property CtDService As ICtDService
        Get
            Return _CtDService
        End Get
        Set(ByVal value As ICtDService)
            _CtDService = value
        End Set
    End Property

    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
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

    Private _CtTscdService As ICtTscdService
    Public Property CtTscdService As ICtTscdService
        Get
            Return _CtTscdService
        End Get
        Set(ByVal value As ICtTscdService)
            _CtTscdService = value
        End Set
    End Property

    Private _KtKhoasoThangService As IKtKhoasoThangService
    Public Property KtKhoasoThangService As IKtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As IKtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property
#End Region

#Region "private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    '''' <summary>
    '''' Bind data vào cbo tk có và tk nợ
    '''' </summary>
    '''' <remarks></remarks>
    Private Sub BindData()
        dt = New List(Of DmTaikhoan)
        dt.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        lst_DM_TSCD = New List(Of DmTscd)
        Dim TotalResult As Integer
        lst_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, TotalResult))
    End Sub

    Private Function GetTen_TK(ByVal TAI_KHOAN_ID As Guid) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each dr As DmTaikhoan In dt
            If dr.Id = TAI_KHOAN_ID Then
                obj_tk.Id = dr.Id
                obj_tk.TenTaikhoan = dr.TenTaikhoan
                obj_tk.MaTaikhoan = dr.MaTaikhoan
            End If
        Next
        Return obj_tk
    End Function

    Private Function GetTen_TK(ByVal MaTaikhoan As String) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each dr As DmTaikhoan In dt
            If dr.MaTaikhoan = MaTaikhoan Then
                obj_tk.Id = dr.Id
                obj_tk.TenTaikhoan = dr.TenTaikhoan
                obj_tk.MaTaikhoan = dr.MaTaikhoan
            End If
        Next
        Return obj_tk
    End Function

    ''' <summary>
    ''' Tính khấu hao cho TSCD
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub KHAU_HAO()

        If (ckeXoaDL.Checked) Then
            flag = True
        Else
            flag = False
        End If
        'Lấy ra ngày tính khấu hao ứng với tháng,năm nhập vào
        Dim p_year As Integer
        Dim p_month As Integer
        p_year = Integer.Parse(txtNAM.Text)
        p_month = Integer.Parse(txtTHANG.Text)

        NGAY_TINH = New DateTime(p_year, p_month, 1)

        fn = New Function_KH
        fn.DmTscdService = _DmTscdService
        fn.CtTscdService = _CtTscdService
        ''List chứa vệt cuối của TSCD ứng với ngày tính khấu hao

        Dim lst_vc_ct_tscd As List(Of CtTscd) = New List(Of CtTscd)

        lst_fist_LS.AddRange(_TsLsKhauhaoService.GetByThangNam(Generals.DON_VI.Id, NGAY_TINH.AddMonths(-1).Month, NGAY_TINH.AddMonths(-1).Year))
        lst_KH_Thang.Clear()
        lst_LS_HM.Clear()
        


        If (flag) Then ''truong hop ghi de (tính mới từ đầu)
            'lấy list dm_tscd
            'lst_DM_TSCD = _DmTscdService.GetObjectAllByDonviID(Generals.DON_VI.Id)
            'lay list vet cuoi
            lst_vc_ct_tscd = fn.Vet_Cuoi_CT_TSCD(NGAY_TINH, lst_DM_TSCD)

            'If lst_vc_ct_tscd.Count = 0 Then
            '    Exit Sub
            'End If
            'lấy ra CTH_ID
            'For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
            '    If Not VnsCheck.IsNullGuid(obj.CTH_ID) Then
            '        lst_del_cth.Add(obj.CTH_ID)
            '    End If
            '    obj.CTD_ID = Nothing
            '    obj.CTH_ID = Nothing
            'Next
            'tính lại khấu hao
            Dim lstTmp As IList(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)
            For Each obj_VC As CtTscd In lst_vc_ct_tscd
                obj_LS_HM = New TsLsKhauhao
                obj_LS_HM = fn.Khau_Hao_Tung_Thang(NGAY_TINH, obj_VC, PP_Tinh, lst_fist_LS)
                If (obj_LS_HM IsNot Nothing) Then
                    obj_LS_HM.BaoCao = 1
                    obj_LS_HM.ChiTiet = 1
                    lst_LS_HM.Add(obj_LS_HM)
                    obj_LS_HM.Id = Guid.NewGuid()
                    lstTmp.Add(New Khau_hao_tung_thangInfo(obj_LS_HM, obj_VC))
                End If
            Next

            'Tính tiếp khấu hao theo nguồn vốn
            lst_KH_Thang = Khau_Hao_Nguon(lstTmp)
        Else ''truong hop khong ghi de(Tính tscd được thêm mới)
            'tính khấu hao tscd ứng từ list vc tscd
            lst_KH_Thang = LoadTSCD(NGAY_TINH.Month, NGAY_TINH.Year)
            'list ts_ls_khauhao 
            ''truyen dc vet cuoi sang, lay dc ts_ls_khau_hao
            Dim obj_tscd As DmTscd
            Dim not_define_tscd As IList(Of DmTscd) = New List(Of DmTscd)

            'lấy ra những danh mục tài sản cố định chưa được tính khấu hao
            For Each tmpTSCD As DmTscd In lst_DM_TSCD
                Dim flg As Boolean = True
                For Each obj_kh_thang As Khau_hao_tung_thangInfo In lst_KH_Thang
                    If tmpTSCD.Id = obj_kh_thang.DM_TSCD_ID Then
                        flg = False
                        Exit For
                    Else
                        flg = True
                    End If
                Next
                If flg Then
                    not_define_tscd.Add(tmpTSCD)
                End If
            Next
            

            'lấy vệt cuối tscd ứng với list dm tscd (lst_vc_ct_tscd)
            lst_vc_ct_tscd = fn.Vet_Cuoi_CT_TSCD(NGAY_TINH, not_define_tscd)

            'tính khấu hao với list vệt cuối
            Dim lstTmp As IList(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)
            For Each obj_VC As CtTscd In lst_vc_ct_tscd
                obj_LS_HM = New TsLsKhauhao
                obj_LS_HM = fn.Khau_Hao_Tung_Thang(NGAY_TINH, obj_VC, PP_Tinh, lst_fist_LS)
                If (obj_LS_HM IsNot Nothing) Then
                    obj_LS_HM.BaoCao = 1
                    obj_LS_HM.ChiTiet = 1
                    lst_LS_HM.Add(obj_LS_HM)
                    obj_LS_HM.Id = Guid.NewGuid()
                    lstTmp.Add(New Khau_hao_tung_thangInfo(obj_LS_HM, obj_VC))
                End If
            Next

            lstTmp = Khau_Hao_Nguon(lstTmp)

            lst_KH_Thang.AddRange(lstTmp)
        End If

        If (ckeXoaDL.Checked And obj_CTH IsNot Nothing) Then
            obj_CTH = Nothing
            lst_CTD.Clear()
        End If

        If (ckeXoaDL.Checked) Then
            
        End If

        lst_temp_kh_thang.Clear()
        For Each obj_thang As Khau_hao_tung_thangInfo In lst_KH_Thang
            If (obj_thang.HAO_MON_THANG <> 0) Then
                lst_temp_kh_thang.Add(obj_thang)
            End If
        Next

        If (ckeHienThi.Checked) Then
            _TreeList.DataSource = lst_temp_kh_thang
        Else
            _TreeList.DataSource = lst_KH_Thang
        End If
        _TreeList.RefreshDataSource()
        grvDINH_KHOAN.RefreshData()
    End Sub

    ''' <summary>
    ''' Khấu hao phân bổ theo nguồn
    ''' </summary>
    ''' <remarks></remarks>
    Private Function Khau_Hao_Nguon(ByVal lstKhauHaoThang As IList(Of Khau_hao_tung_thangInfo)) As IList(Of Khau_hao_tung_thangInfo)

        ''list_nguonvon ung voi TSCD
        Dim lst_Nguon As List(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
        'lấy giá trị list nguồn 
        lst_Nguon.AddRange(_TsCtTscdNvonService.GetAll())

        'list temp là list sau khi đã được phân bổ theo các nguồn vốn
        Dim lst_temp_Nguon As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)
        
        lst_temp_Nguon = Tinh_khau_hao_nguon(lstKhauHaoThang, lst_Nguon, flag)
        'add list temp vào list all nguon
        For Each obj As Khau_hao_tung_thangInfo In lst_temp_Nguon
            lstKhauHaoThang.Add(obj)
        Next

        Return lstKhauHaoThang
    End Function

    ''' <summary>
    ''' Tính khấu hao nguồn
    ''' </summary>
    ''' <param name="p_lst_KH_Thang"></param>
    ''' <param name="p_lst_Nguon"></param>
    ''' <param name="p_flag"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Tinh_khau_hao_nguon(ByVal p_lst_KH_Thang As List(Of Khau_hao_tung_thangInfo), ByVal p_lst_Nguon As List(Of TsCtTscdNvon), ByVal p_flag As Boolean) As List(Of Khau_hao_tung_thangInfo)
        Dim obj_kh_nguon As Khau_hao_tung_thangInfo
        Dim lst_temp As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)

        For Each obj_ts As Khau_hao_tung_thangInfo In p_lst_KH_Thang
            'Nếu không xóa dữ liệu cũ thì lấy từ CSDL lên
            'If Not p_flag Then
            '    lst_nguon_ID_cha = _TsLsKhauhaoService.GetByID_CHA(obj_ts.TS_LS_KHAUHAO_ID)
            'End If
            'Nếu ko xóa dữ liệu cũ mà chưa được tính thì tính tiếp
            'Nếu xóa dữ liệu cũ thì tính lại
            For Each obj As TsCtTscdNvon In p_lst_Nguon
                If (obj.CtTscdId = VnsConvert.CGuid(obj_ts.CT_TSCD_ID) And VnsCheck.IsNullGuid(obj_ts.ID_CHA)) Then
                    obj_ts.CHI_TIET = 0
                    obj_kh_nguon = New Khau_hao_tung_thangInfo
                    obj_kh_nguon.TS_LS_KHAUHAO_ID = Guid.NewGuid()
                    obj_kh_nguon.IS_INSERT = 1
                    obj_kh_nguon.HE_SO = obj.HeSoPbKh
                    obj_kh_nguon.DM_TSCD_ID = obj_ts.DM_TSCD_ID
                    obj_kh_nguon.THANG = obj_ts.THANG
                    obj_kh_nguon.NAM = obj_ts.NAM
                    obj_kh_nguon.HAO_MON_THANG = obj_ts.HAO_MON_THANG * obj_kh_nguon.HE_SO / 100
                    obj_kh_nguon.ID_CHA = obj_ts.TS_LS_KHAUHAO_ID
                    obj_kh_nguon.CHI_TIET = 1
                    obj_kh_nguon.BAO_CAO = 0
                    obj_kh_nguon.CT_TSCD_ID = obj_ts.CT_TSCD_ID
                    obj_kh_nguon.DONVI_ID = obj_ts.DONVI_ID
                    obj_kh_nguon.MA_DONVI = obj_ts.MA_DONVI
                    obj_kh_nguon.MA_TSCD = obj_ts.MA_TSCD
                    obj_kh_nguon.TEN_TSCD = obj_ts.TEN_TSCD
                    obj_kh_nguon.NGUON_VON_ID = obj.Id
                    lst_temp.Add(obj_kh_nguon)
                End If
            Next

        Next
        Return lst_temp
    End Function

    ''' <summary>
    ''' Load TSCD và convert sang list object
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="nam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadTSCD(ByVal thang, ByVal nam)
        Dim dt As List(Of TsLsKhauhao) = New List(Of TsLsKhauhao)
        dt.AddRange(_TsLsKhauhaoService.GetByThangNam(Generals.DON_VI.Id, thang, nam))
        'dt = Nothing
        Dim lst As List(Of Khau_hao_tung_thangInfo) = New List(Of Khau_hao_tung_thangInfo)
        ''convert datatable sang list
        Dim obj As Khau_hao_tung_thangInfo
        lst.Clear()
        For Each dr As DmTscd In lst_DM_TSCD
            For Each tmp As TsLsKhauhao In dt
                If (tmp.DmTscdId = dr.Id) Then
                    obj = New Khau_hao_tung_thangInfo(tmp, dr)
                    lst.Add(obj)
                End If
            Next
        Next
        Return lst
    End Function

    Private Function Check_list(ByVal obj As TsLsKhauhao, ByVal lst_All_LS As Object) As Boolean
        Dim bo As Boolean = False
        For Each obj_all As TsLsKhauhao In lst_All_LS
            If (obj_all.CtTscdId = obj.CtTscdId And obj.Thang = obj_all.Thang And obj.Nam = obj_all.Nam) Then
                bo = True
            End If
        Next
        Return bo
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Function Check_Input() As Boolean
        If (txtTHANG.Text = "") Then
            Message_Information("Bạn chưa nhập tháng")
            txtTHANG.Focus()
            Return False
        End If

        If (Decimal.Parse(txtTHANG.Text) > 12) Or (Decimal.Parse(txtTHANG.Text) <= 0) Then
            Message_Information("Tháng nhập vào không hợp lệ!")
            txtTHANG.Focus()
            Return False
        End If

        If (txtNAM.Text = "") Then
            Message_Information("bạn chưa nhập năm")
            txtNAM.Focus()
            Return False
        ElseIf (Decimal.Parse(txtNAM.Text) > 2999 Or Decimal.Parse(txtNAM.Text) < 2000) Then
            Message_Information("Năm nhập vào không hợp lệ!")
            txtNAM.Focus()
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Save data vào CSDL
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveData()
        Dim Thang As Decimal = VnsConvert.CDecimal(txtTHANG.Text)
        Dim Nam As Decimal = VnsConvert.CDecimal(txtNAM.Text)
        Dim lastdateofmonth As Date = New Date(Nam, Thang, 1)
        lastdateofmonth = lastdateofmonth.AddMonths(1).AddDays(-1)

        _CtHService.DeleteMa(obj_LoaiCT.Id, lastdateofmonth, Generals.DON_VI.Id)

        _TsLsKhauhaoService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam)

        ''insert, update CT_H
        If (obj_CTH IsNot Nothing) Then
            _CtHService.SaveChungTuKeToan(False, obj_CTH, lst_CTD)

            For Each obj As TsLsKhauhao In lst_LS_HM
                If (obj_CTH.NgayCt.Value.Year = obj.Nam And obj_CTH.NgayCt.Value.Month = obj.Thang And obj.ChiTiet = 1) Then
                    obj.CthId = obj_CTH.Id
                End If
            Next

            ''insert, update CTD
            For Each obj As CtD In lst_CTD
                If (obj.CthId = Null.NullGuid) Then
                    obj.CthId = obj_CTH.Id
                Else
                End If
            Next

            For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
                If obj.CHI_TIET = 1 Then
                    obj.CTH_ID = obj_CTH.Id
                End If
            Next
        End If


        ''chuyen tu list khau hao thang (Lst_kh_Thang)-> obj_ls_hm de luu vao csdl
        'lst_LS_HM.Clear()
        For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
            If (obj.HAO_MON_THANG <> 0) Then
                obj_LS_HM = obj.GenTsLsKhauhao()
                lst_LS_HM.Add(obj_LS_HM)

                If VnsCheck.IsNullGuid(obj_LS_HM.Id) Then
                    _TsLsKhauhaoService.Save(obj_LS_HM)
                    obj.IS_INSERT = 0
                    obj.TS_LS_KHAUHAO_ID = obj_LS_HM.Id
                Else
                    obj_LS_HM.NguoiSua = Generals.USER.Id
                    _TsLsKhauhaoService.SaveOrUpdate(obj_LS_HM)
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' DELETE khấu hao tháng
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Delete()
        Dim Thang As Decimal = VnsConvert.CDecimal(txtTHANG.Text)
        Dim Nam As Decimal = VnsConvert.CDecimal(txtNAM.Text)
        _CtHService.DeleteChungTuKhauHao(Thang, Nam, Generals.DON_VI.Id, LOAI_CT)

        _TsLsKhauhaoService.DeleteByThangNam(Generals.DON_VI.Id, Thang, Nam)

        lst_KH_Thang.Clear()
        '_TreeList.RefreshDataSource()
        _TreeList.DataSource = Nothing
        lst_CTD.Clear()
        grvDINH_KHOAN.RefreshData()
        obj_CTH = Nothing
    End Sub

    Dim obj_LoaiCT As HtLoaichungtu = New HtLoaichungtu()
    ''' <summary>
    ''' ĐỊNH KHOẢN
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DINH_KHOAN()
        _Control.SelectedTabPage = xtrDINH_KHOAN
        Dim don_vi_id As Guid = Generals.DON_VI.Id
        Dim obj_CTD As CtD

        'CT_H
        Dim ngay_CT As DateTime = New DateTime(Decimal.Parse(txtNAM.Text), Decimal.Parse(txtTHANG.Text), 1).AddMonths(1).AddDays(-1)
        'obj_CTH = New CtH
        If Not flag Then
            obj_CTH = _CtHService.GetByLoaiChungTu(don_vi_id, LOAI_CT, ngay_CT)
        End If

        If obj_CTH Is Nothing Then
            obj_CTH = New CtH
        End If

        If (VnsCheck.IsNullGuid(obj_CTH.Id)) Then
            obj_CTH.NgayCt = ngay_CT
            obj_CTH.NgayGhi = ngay_CT
            obj_CTH.DonviId = don_vi_id
            obj_CTH.NgayTao = Date.Now
            obj_CTH.NgaySua = Date.Now
            obj_CTH.MaDonvi = Generals.DON_VI.MaDonvi

            obj_LoaiCT = _HtLoaichungtuService.GetByMA_LOAI_CT(LOAI_CT)
            obj_CTH.IdLoaiCt = obj_LoaiCT.Id
            obj_CTH.MaLoaiCt = obj_LoaiCT.MaLoaiCt
            obj_CTH.KyHieuLoaiCt = obj_LoaiCT.KyHieu
            obj_CTH.SoTienNte = 0
            obj_CTH.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            obj_CTH.MaNte = _DmNgoaiteService.GetById(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)).MaNte
        End If

        'CT_D
        lst_CTD.Clear()
        If (VnsCheck.IsNullGuid(obj_CTH.Id)) Then
            For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
                If (obj.CHI_TIET = 1 And obj.HAO_MON_THANG > 0) Then
                    If (obj.THANG = Decimal.Parse(txtTHANG.Text) And obj.NAM = Decimal.Parse(txtNAM.Text)) Then
                        obj_CTD = New CtD

                        obj_CTD.SoTien = obj.HAO_MON_THANG

                        'Lay tài khoản nợ (Tài khoản chi phí)
                        'Lay tai khoan co(tk khấu hao)
                        If VnsCheck.IsNullGuid(obj.ID_CHA) Then
                            Dim obj_tscd As DmTscd = _DmTscdService.GetById(VnsConvert.CGuid(obj.DM_TSCD_ID))
                            Dim dmno As DmTaikhoan = GetTen_TK(obj_tscd.MdTkChiphi)
                            Dim dmco As DmTaikhoan = GetTen_TK(obj_tscd.MdTkKhauhao)
                            obj_CTD.TkNoId = dmno.Id
                            obj_CTD.MaTkNo = dmno.MaTaikhoan
                            obj_CTD.TenTkNo = dmno.TenTaikhoan

                            obj_CTD.TkCoId = dmco.Id
                            obj_CTD.TenTkCo = dmco.TenTaikhoan
                            obj_CTD.MaTkCo = dmco.MaTaikhoan
                        Else
                            Dim obj_tsnv As TsCtTscdNvon = _TsCtTscdNvonService.GetById(VnsConvert.CGuid(obj.NGUON_VON_ID))
                            Dim dmno As DmTaikhoan = GetTen_TK(obj_tsnv.TkChiphi)
                            Dim dmco As DmTaikhoan = GetTen_TK(obj_tsnv.TkKhauhao)
                            obj_CTD.TkNoId = dmno.Id
                            obj_CTD.MaTkNo = dmno.MaTaikhoan
                            obj_CTD.TenTkNo = dmno.TenTaikhoan

                            obj_CTD.TkCoId = dmco.Id
                            obj_CTD.TenTkCo = dmco.TenTaikhoan
                            obj_CTD.MaTkCo = dmco.MaTaikhoan
                        End If
                        obj_CTD.NoiDung = "CT khấu hao tháng " + obj.THANG.ToString + " Năm " + obj.NAM.ToString + " của TSCD: " + obj.TEN_TSCD.ToString
                        obj_CTD.PhanHe = 4

                        lst_CTD.Add(obj_CTD)
                    End If

                End If
            Next
        Else
            lst_CTD.Clear()
            For Each tmp As CtD In obj_CTH.LstCtD
                lst_CTD.Add(tmp)
            Next
            'lst_CTD = obj_CTH.LstCtD
        End If

        grcDINH_KHOAN.DataSource = lst_CTD
        grvDINH_KHOAN.RefreshData()

        If lst_CTD Is Nothing Then
            Return
        End If

        Dim so_tien As Decimal = 0
        If lst_CTD.Count > 0 Then
            For Each obj As CtD In lst_CTD
                If obj IsNot Nothing Then
                    so_tien = so_tien + Decimal.Parse(obj.SoTien)
                End If
            Next
        End If

        obj_CTH.SoTien = so_tien
    End Sub

#End Region

#Region "Events"

    Private Sub frmLichSuHaoMon_ChiTiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindData()
            Dim para_str As String = Me.AccessibleDescription
            Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
            If lst_para.Count > 0 Then
                LOAI_CT = lst_para(0).PARAMVALUE
            End If

            txtTHANG.Text = Date.Now.Month.ToString
            txtNAM.Text = Date.Now.Year.ToString
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Tính khấu hao 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnTinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            PP_Tinh = True
            If Check_Input() Then
                frmProgress.Instance.Thread = AddressOf KHAU_HAO
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Hoàn thành") '"Data saved"
                'load_LS_TSCD(DM_TSCD_ID)
                _Control.SelectedTabPage = xtrLSHM
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _TreeList_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles _TreeList.CellValueChanged
        Try
            Dim obj_LT As TsLsKhauhao = New TsLsKhauhao

            Dim obj_KH As Khau_hao_tung_thangInfo = CType(_TreeList.GetDataRecordByNode(e.Node), Khau_hao_tung_thangInfo)

            Dim obj_ct_TSCD As CtTscd = _CtTscdService.GetById(VnsConvert.CGuid(obj_KH.CT_TSCD_ID))

            If (obj_ct_TSCD Is Nothing) Then
                Exit Sub
            End If

            Dim year_KH = obj_ct_TSCD.NgayBdKh.Value.Year
            Dim month_KH = obj_ct_TSCD.NgayBdKh.Value.Month
            If (obj_ct_TSCD.NgayBdKh.Value.Day < 15) Then
                obj_ct_TSCD.NgayBdKh = New DateTime(year_KH, month_KH, 1)
            Else
                obj_ct_TSCD.NgayBdKh = New DateTime(year_KH, month_KH, 1).AddMonths(1)
            End If

            obj_LT = fn.LS_KH_First(New Date(obj_KH.NAM, obj_KH.THANG, 1), obj_ct_TSCD, lst_fist_LS)

            Try
                If (e.Column.Name.Equals("HAO_MON_THANG")) Then 'Or e.Column.Name.Equals("HAO_MON_NAM") Or e.Column.Name.Equals("HAO_MON_LK") Or e.Column.Name.Equals("GIA_TRI_CL")) Then
                    If (_TreeList.FocusedNode("HAO_MON_THANG").ToString <> "") Then
                        Dim HMT As Decimal = Decimal.Parse(_TreeList.FocusedNode("HAO_MON_THANG"))
                        'If (obj_LT.CT_TSCD_ID IsNot Nothing) Then
                        For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
                            If (obj.ID_CHA = TNCommon.TreeList_FocusKeyValue(_TreeList)) Then
                                obj.HAO_MON_THANG = _TreeList.FocusedNode("HAO_MON_THANG") * obj.HE_SO / 100
                            End If
                        Next
                        _TreeList.FocusedNode.SetValue("HAO_MON_NAM", HMT * 12)
                        _TreeList.FocusedNode.SetValue("HAO_MON_LK", obj_LT.HaoMonLk + HMT)
                        If obj_LT.GiaTriCl - HMT > 0 Then
                            _TreeList.FocusedNode.SetValue("GIA_TRI_CL", obj_LT.GiaTriCl - HMT)
                        Else
                            _TreeList.FocusedNode.SetValue("GIA_TRI_CL", 0)
                        End If
                        _TreeList.RefreshDataSource()
                    Else
                        Message_Warning("Giá trị hao mòn tháng không được trống")
                    End If
                End If
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _TreeList_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles _TreeList.FocusedNodeChanged
        Try
            Dim obj_KH As Khau_hao_tung_thangInfo = CType(_TreeList.GetDataRecordByNode(e.Node), Khau_hao_tung_thangInfo)
            If Not obj_KH Is Nothing Then
                If obj_KH.CHI_TIET = 1 Then
                    _TreeList.Columns.Item("HAO_MON_THANG").OptionsColumn.AllowEdit = True
                Else
                    _TreeList.Columns.Item("HAO_MON_THANG").OptionsColumn.AllowEdit = False
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function check_grid() As Boolean
        'Kiem tra ct_d hop le
        For Each obj As CtD In lst_CTD
            If (obj.TkNoId = Null.NullGuid Or obj.TkCoId = Null.NullGuid) Then
                Message_Information("Bạn phải nhập đầy đủ tài khoản mới lưu được bút toán Khấu hao!")
                _Control.SelectedTabPage = xtrDINH_KHOAN
                Return False
            End If
        Next

        For Each obj As Khau_hao_tung_thangInfo In lst_KH_Thang
            If Not LimitValue.CheckVNDCurrency(obj.HAO_MON_THANG) Or obj.HAO_MON_THANG < 0 Then
                Message_Warning("Giá trị hao mòn tháng không hợp lệ")
                _Control.SelectedTabPage = xtrLSHM
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If _KtKhoasoThangService.KiemTraKhoaSo(NGAY_TINH, Generals.DON_VI.Id) Then
                Message_Warning("Tháng này đã được khóa sổ bạn không thể lưu dữ liệu!")
                Exit Sub
            End If

            If _TreeList.Nodes.Count = 0 Then
                Message_Warning("Không tồn tại bản ghi nào!")
                Exit Sub
            End If
            If check_grid() Then
                frmProgress.Instance.Thread = AddressOf SaveData
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Lưu dữ liệu thành công") '"Data saved" 
                flag = False
                ckeXoaDL.Checked = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmLichSuHaoMon_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnRod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Try
            If _TreeList.Nodes.Count <> 0 Then

                If _KtKhoasoThangService.KiemTraKhoaSo(NGAY_TINH, Generals.DON_VI.Id) Then
                    Message_Warning("Tháng này đã được khóa sổ bạn không thể xóa dữ liệu!")
                    Exit Sub
                End If

                If Message_Confirm("Bạn có chắc chắn muốn xóa tháng khấu hao này?") Then
                    Delete()
                End If
            Else
                Message_Warning("Không tồn tại bản ghi nào")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnKHThang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKHThang.Click
        Try
            PP_Tinh = False
            If Check_Input() Then
                frmProgress.Instance.Thread = AddressOf KHAU_HAO
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Hoàn thành") '"Data saved"
                'load_LS_TSCD(DM_TSCD_ID)
                _Control.SelectedTabPage = xtrLSHM
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDINH_KHOAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDINH_KHOAN.Click
        Try
            If _TreeList.Nodes.Count = 0 Then
                Message_Warning("Bạn phải tính khấu hao trước!")
                Return
            End If

            If Not Check_Input() Then
                Exit Sub
            End If

            frmProgress.Instance.Thread = AddressOf DINH_KHOAN
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Hoàn thành")
        Catch ex As Exception
            'Message_Warning("Dữ liệu không hợp lệ đề nghị bạn xóa dữ liệu cũ và định khoản lại")
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _Control_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles _Control.SelectedPageChanged
        Try
            Select Case _Control.SelectedTabPageIndex
                Case 0
                    btnXoa.Enabled = True
                Case 1
                    btnXoa.Enabled = False
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_CleanDFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeMA_TK_CO.ClearDataFilter, rpeMA_TK_NO.ClearDataFilter
        Dim obj_grv_DINH_KHOAN As CtD = CType(grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle), CtD)
        Dim rowHandle As Integer = grvDINH_KHOAN.FocusedRowHandle
        Dim columnName As String = grvDINH_KHOAN.FocusedColumn().Name
        Dim arr As List(Of String) = New List(Of String)()
        Select Case columnName
            Case "MA_TK_NO"
                arr = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES
                obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr(0))
                obj_grv_DINH_KHOAN.MaTkNo = arr(1)
                obj_grv_DINH_KHOAN.TenTkNo = arr(2)
            Case "MA_TK_CO"
                arr = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES
                obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr(0))
                obj_grv_DINH_KHOAN.MaTkCo = arr(1)
                obj_grv_DINH_KHOAN.TenTkCo = arr(2)
        End Select
    End Sub

    Private Sub MyRepositoryItem_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeMA_TK_CO.AfterFilter, rpeMA_TK_NO.AfterFilter
        Try
            Dim obj_grv_DINH_KHOAN As CtD = CType(grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle), CtD)
            Dim rowHandle As Integer = grvDINH_KHOAN.FocusedRowHandle
            Dim columnName As String = grvDINH_KHOAN.FocusedColumn().Name
            Select Case columnName
                Case "MA_TK_NO"
                    Dim arr As List(Of String) = rpeMA_TK_NO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        'grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_NO", arr(2))
                        obj_grv_DINH_KHOAN.TkNoId = VnsConvert.CGuid(arr(0))
                        obj_grv_DINH_KHOAN.MaTkNo = arr(1)
                        obj_grv_DINH_KHOAN.TenTkNo = arr(2)
                        grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkNo", arr(1))
                        SendKeys.Send("{TAB}")
                    End If
                Case "MA_TK_CO"
                    Dim arr As List(Of String) = rpeMA_TK_CO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        'grvDINH_KHOAN.SetRowCellValue(rowHandle, "TEN_TK_CO", arr(2))
                        obj_grv_DINH_KHOAN.TkCoId = VnsConvert.CGuid(arr(0))
                        obj_grv_DINH_KHOAN.MaTkCo = arr(1)
                        obj_grv_DINH_KHOAN.TenTkCo = arr(2)
                        grvDINH_KHOAN.SetRowCellValue(rowHandle, "MaTkCo", arr(1))
                        SendKeys.Send("{TAB}")
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ckeHienThi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeHienThi.CheckedChanged
        Try
            If (ckeHienThi.Checked) Then
                _TreeList.DataSource = lst_temp_kh_thang
            Else
                _TreeList.DataSource = lst_KH_Thang
            End If
            _TreeList.RefreshDataSource()
            _Control.SelectedTabPage = xtrLSHM
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeMA_TK_CO_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeMA_TK_CO.FisrtBinddata
        Try
            'rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            rpeMA_TK_CO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt)
            rpeMA_TK_CO.Editors.A_DATA_SOURCE = rpeMA_TK_CO.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeMA_TK_NO_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeMA_TK_NO.FisrtBinddata
        Try
            'rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            rpeMA_TK_NO.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt)
            rpeMA_TK_NO.Editors.A_DATA_SOURCE = rpeMA_TK_NO.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


End Class

Public Class Ts_Ls_KhauHao_ThangNGuonVoninfo

#Region "Private Variable"
    Private _TS_LS_KHAUHAO_ID As String
    Private _DM_TSCD_ID As Guid
    Private _TEN_TSCD As String
    Private _MA_TSCD As String
    Private _CT_TSCD_ID As Guid
    Private _HAO_MON_LK As Decimal
    Private _HAO_MON_THANG As Decimal
    Private _HAO_MON_NAM As Decimal
    Private _NGUYEN_GIA As Decimal
    Private _GIA_TRI_CL As Decimal
    Private _THANG As Decimal
    Private _NAM As Decimal
    Private _DONVI_ID As Guid
    Private _MA_DONVI As String
    Private _CTD_ID As Guid
    Private _CTH_ID As Guid
    Private _NGAY_TAO As DateTime
    Private _NGUOI_TAO As Guid
    Private _NGAY_SUA As DateTime
    Private _NGUOI_SUA As Guid
    Private _ID_CHA As Guid
    Private _HE_SO As Decimal
    Private _BAO_CAO As Decimal
    Private _CHI_TIET As Decimal
#End Region

#Region "Property"

    Public Property CTH_ID() As Guid
        Get
            Return _CTH_ID
        End Get
        Set(ByVal value As Guid)
            _CTH_ID = value
        End Set
    End Property


    Public Property MA_TSCD() As String
        Get
            Return _MA_TSCD
        End Get
        Set(ByVal value As String)
            _MA_TSCD = value
        End Set
    End Property

    Public Property TEN_TSCD() As String
        Get
            Return _TEN_TSCD
        End Get
        Set(ByVal value As String)
            _TEN_TSCD = value
        End Set
    End Property


    Public Property CHI_TIET() As Decimal
        Get
            Return _CHI_TIET
        End Get
        Set(ByVal value As Decimal)
            _CHI_TIET = value
        End Set
    End Property

    Public Property BAO_CAO() As Decimal
        Get
            Return _BAO_CAO
        End Get
        Set(ByVal value As Decimal)
            _BAO_CAO = value
        End Set
    End Property

    Public Property HE_SO() As Decimal
        Get
            Return _HE_SO
        End Get
        Set(ByVal value As Decimal)
            _HE_SO = value
        End Set
    End Property

    Public Property TS_LS_KHAUHAO_ID() As String
        Get
            Return _TS_LS_KHAUHAO_ID
        End Get
        Set(ByVal Value As String)
            _TS_LS_KHAUHAO_ID = Value
        End Set
    End Property

    Public Property DM_TSCD_ID() As Guid
        Get
            Return _DM_TSCD_ID
        End Get
        Set(ByVal Value As Guid)
            _DM_TSCD_ID = Value
        End Set
    End Property

    Public Property CT_TSCD_ID() As Guid
        Get
            Return _CT_TSCD_ID
        End Get
        Set(ByVal Value As Guid)
            _CT_TSCD_ID = Value
        End Set
    End Property

    Public Property HAO_MON_LK() As Decimal
        Get
            Return _HAO_MON_LK
        End Get
        Set(ByVal Value As Decimal)
            _HAO_MON_LK = Value
        End Set
    End Property

    Public Property HAO_MON_THANG() As Decimal
        Get
            Return _HAO_MON_THANG
        End Get
        Set(ByVal Value As Decimal)
            _HAO_MON_THANG = Value
        End Set
    End Property

    Public Property HAO_MON_NAM() As Decimal
        Get
            Return _HAO_MON_NAM
        End Get
        Set(ByVal Value As Decimal)
            _HAO_MON_NAM = Value
        End Set
    End Property

    Public Property NGUYEN_GIA() As Decimal
        Get
            Return _NGUYEN_GIA
        End Get
        Set(ByVal Value As Decimal)
            _NGUYEN_GIA = Value
        End Set
    End Property

    Public Property GIA_TRI_CL() As Decimal
        Get
            Return _GIA_TRI_CL
        End Get
        Set(ByVal Value As Decimal)
            _GIA_TRI_CL = Value
        End Set
    End Property

    Public Property THANG() As Decimal
        Get
            Return _THANG
        End Get
        Set(ByVal Value As Decimal)
            _THANG = Value
        End Set
    End Property

    Public Property NAM() As Decimal
        Get
            Return _NAM
        End Get
        Set(ByVal Value As Decimal)
            _NAM = Value
        End Set
    End Property

    Public Property DONVI_ID() As Guid
        Get
            Return _DONVI_ID
        End Get
        Set(ByVal Value As Guid)
            _DONVI_ID = Value
        End Set
    End Property

    Public Property MA_DONVI() As String
        Get
            Return _MA_DONVI
        End Get
        Set(ByVal Value As String)
            _MA_DONVI = Value
        End Set
    End Property

    Public Property CTD_ID() As Guid
        Get
            Return _CTD_ID
        End Get
        Set(ByVal Value As Guid)
            _CTD_ID = Value
        End Set
    End Property

    Public Property NGAY_TAO() As DateTime
        Get
            Return _NGAY_TAO
        End Get
        Set(ByVal Value As DateTime)
            _NGAY_TAO = Value
        End Set
    End Property

    Public Property NGUOI_TAO() As Guid
        Get
            Return _NGUOI_TAO
        End Get
        Set(ByVal Value As Guid)
            _NGUOI_TAO = Value
        End Set
    End Property

    Public Property NGAY_SUA() As DateTime
        Get
            Return _NGAY_SUA
        End Get
        Set(ByVal Value As DateTime)
            _NGAY_SUA = Value
        End Set
    End Property

    Public Property NGUOI_SUA() As Guid
        Get
            Return _NGUOI_SUA
        End Get
        Set(ByVal Value As Guid)
            _NGUOI_SUA = Value
        End Set
    End Property

    Public Property ID_CHA() As Guid
        Get
            Return _ID_CHA
        End Get
        Set(ByVal value As Guid)
            _ID_CHA = value
        End Set
    End Property
#End Region

#Region "Init Class"
    Public Sub New()
    End Sub

    Public Sub New(ByVal obj As Khau_hao_tung_thangInfo)
        ' Me.TS_LS_KHAUHAO_ID = Guid.NewGuid().ToString().Replace("-", "").ToUpper
        Me.DM_TSCD_ID = obj.DM_TSCD_ID
        Me.TEN_TSCD = obj.TEN_TSCD
        Me.MA_TSCD = obj.MA_TSCD
        Me.CT_TSCD_ID = obj.CT_TSCD_ID
        Me.HAO_MON_LK = obj.HAO_MON_LK
        Me.HAO_MON_THANG = obj.HAO_MON_THANG
        Me.HAO_MON_NAM = obj.HAO_MON_NAM
        Me.NGUYEN_GIA = obj.NGUYEN_GIA
        Me.GIA_TRI_CL = obj.GIA_TRI_CL
        Me.THANG = obj.THANG
        Me.NAM = obj.NAM
        Me.DONVI_ID = obj.DONVI_ID
        Me.MA_DONVI = obj.MA_DONVI
        Me.CTD_ID = obj.CTD_ID
        Me.NGAY_TAO = obj.NGAY_TAO
        Me.NGUOI_TAO = obj.NGUOI_TAO
        Me.NGAY_SUA = obj.NGAY_SUA
        Me.NGUOI_SUA = obj.NGUOI_SUA
        Me.ID_CHA = obj.ID_CHA
        Me.HE_SO = obj.HE_SO
        Me.BAO_CAO = obj.BAO_CAO
        Me.CHI_TIET = obj.CHI_TIET
        Me.CTH_ID = obj.CTH_ID
    End Sub

    Public Sub New(ByVal obj As TsCtTscdNvon)
        Me.TS_LS_KHAUHAO_ID = Guid.NewGuid().ToString
        Me.HE_SO = obj.HeSoPbKh
    End Sub
#End Region

End Class