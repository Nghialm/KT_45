Imports System.Reflection

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class Function_KH

#Region "Property"
    Private _CtTscdService As ICtTscdService
    Public Property CtTscdService As ICtTscdService
        Get
            Return _CtTscdService
        End Get
        Set(ByVal value As ICtTscdService)
            _CtTscdService = value
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
#End Region
    ''' <summary>
    ''' Lọc ra vệt cuối của chi tiết TSCD có ngày bắt đầu khấu hao nhỏ hơn ngày tính khấu hao
    ''' </summary>
    ''' <param name="NGAY_TINH"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Vet_Cuoi_CT_TSCD(ByVal NGAY_TINH As Date, ByVal lst_DM_TSCD As List(Of DmTscd)) As List(Of CtTscd)
        'list CT_TSCD ứng với 1 TSCD_ID
        'Dim lst_temp_CT_TSCD As List(Of CtTscd) = New List(Of CtTscd)
        Dim obj_temp_CT_TSCD As CtTscd = New CtTscd
        'List chứa vệt cuối của TSCD
        Dim lst_vc_ct_tscd As List(Of CtTscd) = New List(Of CtTscd)

        If (lst_DM_TSCD Is Nothing) Then
            Dim TotalResult As Integer
            lst_DM_TSCD = _DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, TotalResult)
        End If

        'Lay tat ca vet cuoi cua TSCD theo thang truyen vao
        'Loc lay vet cuoi cua ct_tscd
        'Loai tru: 
        'Giam
        'Lấy ra thứ tự max tính đến ngày tính
        Dim Thu_Tu_Max As Integer = 0
        'Ngay bat dau khau hao khi lam tron
        For Each obj_ct As DmTscd In lst_DM_TSCD
            obj_temp_CT_TSCD = _CtTscdService.GetObject_TOP1(obj_ct.Id, NGAY_TINH)
            Dim NGAY_KH As DateTime
            If (obj_temp_CT_TSCD IsNot Nothing) Then
                NGAY_KH = Dt(obj_temp_CT_TSCD.NgayBdKh)
                'If (lst_temp_CT_TSCD(i).THU_TU = lst_temp_CT_TSCD.Count And NGAY_KH < NGAY_TINH And lst_temp_CT_TSCD(i).TANG_TSCD <> 4) Then
                obj_temp_CT_TSCD.NgayBdKh = NGAY_KH
                lst_vc_ct_tscd.Add(obj_temp_CT_TSCD)
            End If
            'End If
        Next
        Return lst_vc_ct_tscd
    End Function

    Private Function Dt(ByVal p_dt As DateTime)
        Dim dt_ktkh As DateTime = Nothing

        If p_dt.Day < 15 Then
            dt_ktkh = New DateTime(p_dt.Year, p_dt.Month, 1)
        Else
            dt_ktkh = New DateTime(p_dt.Year, p_dt.Month, 1).AddMonths(1)
        End If

        Return dt_ktkh
    End Function

    ''' <summary>
    ''' Tính khấu hao từng tháng một
    ''' </summary>
    ''' <param name="Thang">Truyền vào ngày tháng cần tính</param>
    ''' <param name="CT_TSCD">Truyền vào CT_TSCD</param>
    ''' <param name="PPT">True : tính HAO MÒN THÁNG theo Vệt cuối của CT_TSCD; Fasle: tính HAO MÒN THÁNG theo Vệt cuối của LS_KHAUHAO</param>
    ''' <remarks></remarks>

    Public Function Khau_Hao_Tung_Thang(ByVal Thang As DateTime, ByVal CT_TSCD As CtTscd, ByVal PPT As Boolean, ByVal lst_first_KH As Object) As TsLsKhauhao
        Dim obj_LS_TSCD As New TsLsKhauhao
        Dim str As String = ""
        Dim obj_temp_LS_TSCD As New TsLsKhauhao

        If Not (String.IsNullOrEmpty(DB_GetString(DB_GetNull(CT_TSCD.NgayKtKh)))) Then
            Dim N_KTKH = Dt(CT_TSCD.NgayKtKh)
            If (N_KTKH <= Thang) Then
                obj_LS_TSCD.CtTscdId = CT_TSCD.Id
                obj_LS_TSCD.DmTscdId = CT_TSCD.TscdId
                obj_LS_TSCD.NguyenGia = 0
                obj_LS_TSCD.HaoMonThang = 0
                obj_LS_TSCD.HaoMonNam = 0
                obj_LS_TSCD.HaoMonLk = 0
                obj_LS_TSCD.Thang = Thang.Month
                obj_LS_TSCD.Nam = Thang.Year
                Return obj_LS_TSCD
            End If
        End If

        'Lấy ra giá trị cần thiết để tính khấu hao
        obj_temp_LS_TSCD = LS_KH_First(Thang, CT_TSCD, lst_first_KH)

        ''nếu hao mòn tháng =0 trả về giá trị trắng chứa ID_TSCD
        'gán các giá trị cần thiết cho object lịch sử hao mòn trả về
        obj_LS_TSCD.CtTscdId = CT_TSCD.Id
        obj_LS_TSCD.DmTscdId = CT_TSCD.TscdId
        obj_LS_TSCD.NguyenGia = CT_TSCD.NguyenGia
        obj_LS_TSCD.MaDonvi = Generals.DON_VI.MaDonvi
        obj_LS_TSCD.DonviId = Generals.DON_VI.Id
        obj_LS_TSCD.Thang = Thang.Month
        obj_LS_TSCD.Nam = Thang.Year
        obj_LS_TSCD.NguoiTao = Generals.USER.Id


        ''PPT=false :Hao mòn thang sẽ tính gối theo tháng trước nếu có thay đổi (không xóa dữ liệu cũ)
        ''PPT=true :Hao mòn tháng sẽ tính theo vệt cuối của CT_TSCD (Xóa dữ liệu cũ)
        If (PPT = False) Then
            obj_LS_TSCD.HaoMonThang = obj_temp_LS_TSCD.HaoMonThang
        Else
            If (CT_TSCD.SoThangSd <> 0) Then
                obj_LS_TSCD.HaoMonThang = Math.Round(CT_TSCD.GiaTriCl / CT_TSCD.SoThangSd, 0)
            Else
                obj_LS_TSCD.HaoMonThang = 0
            End If
        End If

        If (obj_temp_LS_TSCD.HaoMonThang = 0 Or obj_temp_LS_TSCD.GiaTriCl = 0) Then
            'obj_LS_TSCD.DM_TSCD_ID = obj_temp_LS_TSCD.DM_TSCD_ID
            Return obj_LS_TSCD
        End If

        'Tính các giá trị còn lại(hao mòn năm, giá trị còn lại, hao mòn lũy kế, giá trị còn lại)
        obj_LS_TSCD.HaoMonNam = obj_temp_LS_TSCD.HaoMonNam

        If (obj_temp_LS_TSCD.GiaTriCl > obj_LS_TSCD.HaoMonThang) Then
            obj_LS_TSCD.GiaTriCl = obj_temp_LS_TSCD.GiaTriCl - obj_LS_TSCD.HaoMonThang
            obj_LS_TSCD.HaoMonLk = obj_temp_LS_TSCD.HaoMonLk + obj_LS_TSCD.HaoMonThang
        Else
            'If (Math.Round(obj_temp_LS_TSCD.GIA_TRI_CL, 0) <> 0) Then
            '    obj_LS_TSCD.GIA_TRI_CL = 0
            '    obj_LS_TSCD.HAO_MON_LK = obj_temp_LS_TSCD.HAO_MON_LK + obj_LS_TSCD.HAO_MON_THANG
            'Else
            '    Return Nothing
            'End If
            If (obj_temp_LS_TSCD.GiaTriCl > 0) Then
                obj_LS_TSCD.HaoMonThang = obj_temp_LS_TSCD.GiaTriCl
                obj_LS_TSCD.HaoMonLk = obj_temp_LS_TSCD.HaoMonLk + obj_LS_TSCD.HaoMonThang
                obj_LS_TSCD.GiaTriCl = 0
            Else
                obj_LS_TSCD.HaoMonThang = 0
                obj_LS_TSCD.HaoMonLk = 0
                obj_LS_TSCD.GiaTriCl = 0
            End If
        End If

        Return obj_LS_TSCD
    End Function

    ''' <summary>
    ''' Lấy ra số liệu để tính khấu hao tháng truyền vào
    ''' </summary>
    ''' <param name="NGAY_KH"></param>
    ''' <param name="obj_CT_TSCD_ID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LS_KH_First(ByVal NGAY_KH As Date, ByVal obj_CT_TSCD_ID As CtTscd, ByVal lst_first_KH As Object) As TsLsKhauhao

        Dim obj_LS_KH_First As TsLsKhauhao = New TsLsKhauhao
        'Lấy ra ngày của obj_all
        Dim NGAY As DateTime
        Dim year As Integer
        Dim month As Integer
        'Lấy ra lịch sử tài sản khấu hao ứng với một chi tiết TSCD
        Dim lst_LS_CT_TSCD As List(Of TsLsKhauhao) = New List(Of TsLsKhauhao)
        For Each obj_all As TsLsKhauhao In lst_first_KH
            If (obj_all.CtTscdId = obj_CT_TSCD_ID.Id) Then
                lst_LS_CT_TSCD.Add(obj_all)
            End If
        Next

        If (NGAY_KH = obj_CT_TSCD_ID.NgayBdKh) Then
            'Lấy dữ liệu cho của vệt cuối ct_TSCD
            If (obj_CT_TSCD_ID.SoThangSd <> 0) Then
                obj_LS_KH_First.HaoMonThang = Math.Round(obj_CT_TSCD_ID.GiaTriCl / obj_CT_TSCD_ID.SoThangSd, 0)
                obj_LS_KH_First.HaoMonNam = Math.Round(obj_CT_TSCD_ID.GiaTriCl / (obj_CT_TSCD_ID.SoThangSd / 12), 0)
                obj_LS_KH_First.HaoMonLk = obj_CT_TSCD_ID.HaoMonLuyKe
            Else
                obj_LS_KH_First.HaoMonThang = 0
                obj_LS_KH_First.HaoMonNam = 0
            End If
            'Hao mòn năm =giá trị còn lại/tỷ lệ hao mòn
            obj_LS_KH_First.GiaTriCl = obj_CT_TSCD_ID.GiaTriCl
        Else
            For Each obj As TsLsKhauhao In lst_LS_CT_TSCD
                year = Integer.Parse(obj.Nam)
                month = Integer.Parse(obj.Thang)
                NGAY = New DateTime(year, month, 1)
                If (NGAY = NGAY_KH.AddMonths(-1) And (obj.IdCha = Null.NullGuid)) Then
                    obj_LS_KH_First = obj
                    Exit For
                End If
            Next
        End If

        Return obj_LS_KH_First

    End Function

End Class

Public Class Khau_hao_tung_thangInfo

#Region "Private Variable"

    Private _TS_LS_KHAUHAO_ID As Guid
    Private _DM_TSCD_ID As Guid
    Private _MA_TSCD As String
    Private _TEN_TSCD As String
    Private _CT_TSCD_ID As Guid
    Private _HAO_MON_LK As Decimal
    Private _HAO_MON_THANG As Decimal
    Private _HAO_MON_NAM As Decimal
    Private _NGUYEN_GIA As Decimal
    Private _GIA_TRI_CL As Decimal
    Private _THANG As Decimal
    Private _NAM As Decimal
    Private _NgayKhauHao As DateTime
    Private _DONVI_ID As Guid
    Private _MA_DONVI As String
    Private _CTD_ID As Guid
    Private _NGAY_TAO As DateTime?
    Private _NGUOI_TAO As Guid
    Private _NGAY_SUA As DateTime?
    Private _NGUOI_SUA As Guid
    Private _CTH_ID As Guid
    Private _HE_SO As Decimal
    Private _BAO_CAO As Decimal
    Private _CHI_TIET As Decimal
    Private _ID_CHA As Guid
    Private _IS_INSERT As Decimal
    Private _IS_UPDATE As Decimal
    Private _IS_DELETE As Decimal
    Private _NGUON_VON_ID As Guid
    Private _NGAY_KT_KH As DateTime
    Private _NGAY_BD_KH As DateTime
#End Region

#Region "Property"
    Public Property NGAY_BD_KH() As DateTime
        Get
            Return _NGAY_BD_KH
        End Get
        Set(ByVal value As DateTime)
            _NGAY_BD_KH = value
        End Set
    End Property


    Public Property NGAY_KTKH() As DateTime
        Get
            Return _NGAY_KT_KH
        End Get
        Set(ByVal value As DateTime)
            _NGAY_KT_KH = value
        End Set
    End Property


    Public Property NGUON_VON_ID() As Guid
        Get
            Return _NGUON_VON_ID
        End Get
        Set(ByVal value As Guid)
            _NGUON_VON_ID = value
        End Set
    End Property


    Public Property IS_DELETE() As Decimal
        Get
            Return _IS_DELETE
        End Get
        Set(ByVal value As Decimal)
            _IS_DELETE = value
        End Set
    End Property

    Public Property IS_UPDATE() As Decimal
        Get
            Return _IS_UPDATE
        End Get
        Set(ByVal value As Decimal)
            _IS_UPDATE = value
        End Set
    End Property

    Public Property IS_INSERT() As Decimal
        Get
            Return _IS_INSERT
        End Get
        Set(ByVal value As Decimal)
            _IS_INSERT = value
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

    Public Property TS_LS_KHAUHAO_ID() As Guid
        Get
            Return _TS_LS_KHAUHAO_ID
        End Get
        Set(ByVal Value As Guid)
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

    Public Property NGAY_TAO() As DateTime?
        Get
            Return _NGAY_TAO
        End Get
        Set(ByVal Value As DateTime?)
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

    Public Property NGAY_SUA() As DateTime?
        Get
            Return _NGAY_SUA
        End Get
        Set(ByVal Value As DateTime?)
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

    Public Property CTH_ID() As Guid
        Get
            Return _CTH_ID
        End Get
        Set(ByVal Value As Guid)
            _CTH_ID = Value
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

    Public Property MA_TSCD() As String
        Get
            Return _MA_TSCD
        End Get
        Set(ByVal value As String)
            _MA_TSCD = value
        End Set
    End Property

    Public ReadOnly Property NgayKhauHao As Date
        Get
            Try
                Dim tmpngay As Date = New Date(_NAM, _THANG, 1)
                tmpngay = tmpngay.AddMonths(1).AddDays(-1)
                Return tmpngay
            Catch ex As Exception
                Return Date.Today
            End Try
        End Get
    End Property

#End Region

#Region "Init Class"
    Public Sub New()
    End Sub

    Public Sub New(ByVal TS_LS_KHAUHAO_ID As Guid, ByVal DM_TSCD_ID As Guid, ByVal MA_TSCD As String, ByVal TEN_TSCD As String, ByVal CT_TSCD_ID As Guid, ByVal HAO_MON_LK As Decimal, ByVal HAO_MON_THANG As Decimal, ByVal HAO_MON_NAM As Decimal, ByVal NGUYEN_GIA As Decimal, ByVal GIA_TRI_CL As Decimal, ByVal THANG As Decimal, ByVal NAM As Decimal, ByVal DONVI_ID As Guid, ByVal MA_DONVI As String, ByVal CTD_ID As Guid, ByVal NGAY_TAO As DateTime, ByVal NGUOI_TAO As Guid, ByVal NGAY_SUA As DateTime, ByVal NGUOI_SUA As Guid, ByVal CTH_ID As Guid, ByVal HE_SO As Decimal, ByVal BAO_CAO As Decimal, ByVal CHI_TIET As Decimal, ByVal ID_CHA As Guid, ByVal NGUON_VON_ID As Guid, ByVal NGAY_KTKH As DateTime)
        Me.TS_LS_KHAUHAO_ID = TS_LS_KHAUHAO_ID
        Me.DM_TSCD_ID = DM_TSCD_ID
        Me.MA_TSCD = MA_TSCD
        Me.TEN_TSCD = TEN_TSCD
        Me.CT_TSCD_ID = CT_TSCD_ID
        Me.HAO_MON_LK = HAO_MON_LK
        Me.HAO_MON_THANG = HAO_MON_THANG
        Me.HAO_MON_NAM = HAO_MON_NAM
        Me.NGUYEN_GIA = NGUYEN_GIA
        Me.GIA_TRI_CL = GIA_TRI_CL
        Me.THANG = THANG
        Me.NAM = NAM
        Me.DONVI_ID = DONVI_ID
        Me.MA_DONVI = MA_DONVI
        Me.CTD_ID = CTD_ID
        Me.NGAY_TAO = NGAY_TAO
        Me.NGUOI_TAO = NGUOI_TAO
        Me.NGAY_SUA = NGAY_SUA
        Me.NGUOI_SUA = NGUOI_SUA
        Me.CTH_ID = CTH_ID
        Me.HE_SO = HE_SO
        Me.BAO_CAO = BAO_CAO
        Me.CHI_TIET = CHI_TIET
        Me.ID_CHA = ID_CHA
        Me.IS_INSERT = 0
        Me.NGUON_VON_ID = NGUON_VON_ID
        Me.NGAY_KTKH = NGAY_KTKH
    End Sub

    Public Sub New(ByVal obj_KhauHao As TsLsKhauhao, ByVal obj_ct As CtTscd)
        Me.TS_LS_KHAUHAO_ID = obj_KhauHao.Id
        Me.ID_CHA = obj_KhauHao.IdCha
        Me.DM_TSCD_ID = obj_ct.TscdId
        Me.MA_TSCD = obj_ct.MaTscd
        Me.TEN_TSCD = obj_ct.TenTscd
        Me.CT_TSCD_ID = obj_KhauHao.CtTscdId
        Me.HAO_MON_LK = obj_KhauHao.HaoMonLk
        Me.HAO_MON_THANG = obj_KhauHao.HaoMonThang
        Me.HAO_MON_NAM = obj_KhauHao.HaoMonNam
        Me.NGUYEN_GIA = obj_KhauHao.NguyenGia
        Me.GIA_TRI_CL = obj_KhauHao.GiaTriCl
        Me.THANG = obj_KhauHao.Thang
        Me.NAM = obj_KhauHao.NAM
        Me.DONVI_ID = obj_KhauHao.DonviId
        Me.MA_DONVI = obj_KhauHao.MaDonvi
        Me.CTD_ID = obj_KhauHao.CtdId
        Me.NGAY_TAO = IIf(obj_KhauHao.NgayTao Is Nothing, System.DateTime.Today, obj_KhauHao.NgayTao)
        Me.NGUOI_TAO = obj_KhauHao.NguoiTao
        Me.NGAY_SUA = IIf(obj_KhauHao.NgaySua Is Nothing, System.DateTime.Today, obj_KhauHao.NgaySua)
        Me.NGUOI_SUA = obj_KhauHao.NguoiSua
        Me.CTH_ID = obj_KhauHao.CthId
        Me.CHI_TIET = obj_KhauHao.ChiTiet
        Me.BAO_CAO = obj_KhauHao.BaoCao
        Me.NGUON_VON_ID = obj_KhauHao.NguonVonId
    End Sub

    Public Sub New(ByVal obj_KhauHao As TsLsKhauhao, ByVal obj_DM_Tscd As DmTscd)
        Me.TS_LS_KHAUHAO_ID = obj_KhauHao.Id
        Me.ID_CHA = obj_KhauHao.IdCha
        Me.DM_TSCD_ID = obj_DM_Tscd.Id
        Me.MA_TSCD = obj_DM_Tscd.MaTscd
        Me.TEN_TSCD = obj_DM_Tscd.TenTscd
        Me.CT_TSCD_ID = obj_KhauHao.CtTscdId
        Me.HAO_MON_LK = obj_KhauHao.HaoMonLk
        Me.HAO_MON_THANG = obj_KhauHao.HaoMonThang
        Me.HAO_MON_NAM = obj_KhauHao.HaoMonNam
        Me.NGUYEN_GIA = obj_KhauHao.NguyenGia
        Me.GIA_TRI_CL = obj_KhauHao.GiaTriCl
        Me.THANG = obj_KhauHao.Thang
        Me.NAM = obj_KhauHao.Nam
        Me.DONVI_ID = obj_KhauHao.DonviId
        Me.MA_DONVI = obj_KhauHao.MaDonvi
        Me.CTD_ID = obj_KhauHao.CtdId
        Me.NGAY_TAO = IIf(obj_KhauHao.NgayTao Is Nothing, System.DateTime.Today, obj_KhauHao.NgayTao)
        Me.NGUOI_TAO = obj_KhauHao.NguoiTao
        Me.NGAY_SUA = IIf(obj_KhauHao.NgaySua Is Nothing, System.DateTime.Today, obj_KhauHao.NgaySua)
        Me.NGUOI_SUA = obj_KhauHao.NguoiSua
        Me.CTH_ID = obj_KhauHao.CthId
        Me.CHI_TIET = obj_KhauHao.ChiTiet
        Me.BAO_CAO = obj_KhauHao.BaoCao
        Me.NGUON_VON_ID = obj_KhauHao.NguonVonId
    End Sub

#End Region

#Region "Custom function"
    Public Function GenTsLsKhauhao() As TsLsKhauhao
        Dim obj_LS_HM As TsLsKhauhao = New TsLsKhauhao
        obj_LS_HM.Id = VnsConvert.CGuid(_TS_LS_KHAUHAO_ID)
        obj_LS_HM.DmTscdId = VnsConvert.CGuid(_DM_TSCD_ID)
        obj_LS_HM.CtTscdId = VnsConvert.CGuid(_CT_TSCD_ID)
        obj_LS_HM.HaoMonLk = _HAO_MON_LK
        obj_LS_HM.HaoMonNam = _HAO_MON_NAM
        obj_LS_HM.HaoMonThang = _HAO_MON_THANG
        obj_LS_HM.NguyenGia = _NGUYEN_GIA
        obj_LS_HM.GiaTriCl = _GIA_TRI_CL
        obj_LS_HM.Thang = _THANG
        obj_LS_HM.Nam = _NAM
        obj_LS_HM.DonviId = VnsConvert.CGuid(_DONVI_ID)
        obj_LS_HM.MaDonvi = _MA_DONVI
        obj_LS_HM.NgaySua = _NGAY_SUA
        obj_LS_HM.NguoiSua = _NGUOI_SUA
        obj_LS_HM.NguoiTao = _NGUOI_TAO
        obj_LS_HM.NgayTao = _NGAY_TAO
        obj_LS_HM.CtdId = VnsConvert.CGuid(_CTD_ID)
        obj_LS_HM.HeSo = _HE_SO
        obj_LS_HM.IdCha = VnsConvert.CGuid(_ID_CHA)
        obj_LS_HM.BaoCao = _BAO_CAO
        obj_LS_HM.ChiTiet = _CHI_TIET
        obj_LS_HM.NgayKhauHao = NgayKhauHao
        'obj_LS_HM.IS_INSERT = _IS_INSERT
        If obj_LS_HM.ChiTiet = 1 Then
            obj_LS_HM.CthId = VnsConvert.CGuid(_CTH_ID)
        End If
        obj_LS_HM.NguonVonId = VnsConvert.CGuid(_NGUON_VON_ID)

        Return obj_LS_HM
    End Function
#End Region
End Class