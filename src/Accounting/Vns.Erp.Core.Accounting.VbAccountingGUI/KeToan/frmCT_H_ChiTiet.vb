Imports System
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.Utils

Public Class frmCT_H_ChiTiet

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
    'Public variable
    Public m_LstCT_ThueInfo As List(Of CtThue) = New List(Of CtThue)
    Public m_CT_HoadonInfo As CtHoadon
    Public m_Del_LstCT_ThueInfo As List(Of CtThue) = New List(Of CtThue)
    Public m_LstCT_H_GInfo As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)

    'Public variable
    Private m_CT_HInfo As CtH = New CtH()
    Private m_LstCT_DInfo As List(Of CtD) = New List(Of CtD)
    Private m_LstCT_DInfo_Thue As List(Of CtD) = New List(Of CtD)
    Private m_Del_LstCT_DInfo As List(Of CtD) = New List(Of CtD)
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private m_MA_LOAI_CT As String
    Private m_LstTKLQ_Info As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
    Private m_Tongtien As Decimal
    Private m_TongtienThue As Decimal
    Private m_TKThue As String
    Private m_TKThue_ID As String
    Private m_HT_CT_Info As HtLoaichungtu
    Private m_HT_LoaiCT_Info As HtLoaichungtu = New HtLoaichungtu()
    Private m_TK_DATA_SOURCE As DataTable = Nothing
    Private m_KHANG_DATA_SOURCE As DataTable = Nothing
    Private m_CT_HOADON_DATA_SOURCE As DataTable = Nothing
    Private m_SD_CT_THUE As Boolean = False
    Private m_OnLoadData = False 'Bien phan biet dang trong trang thai load du lieu
    Private FlagDG As Decimal = 0

    Dim m_chk_Hoadon As Boolean = True
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"

#End Region

#Region "Load Form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        UR_Status.Visible = Generals.Ts_PheDuyetChungTu
        UR_Status.Enabled = Generals.Ts_PheDuyetChungTu
        btnCopy.Visible = False
        btnCopy.Enabled = False
        GRV_CTH.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
        'Validate control
        Commons.RequireInputControls = New Control() {daeNGAY_CT, daeNGAY_GHI}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

    Public Function Show_Form(ByVal CTH_ID As Guid, ByVal MA_LOAI_CT As String, ByVal TEN_LOAI_CT As String, _
                               ByVal lstCT_H_GInfo As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As CtH
        Try
            Form_SetText(Me, TEN_LOAI_CT, DataInputState.NoCaption)
            Form_InitDialog(Me)
            Panel_InitControl(grpSMQR, "CT_H")
            Control_SetRequire(grlLOAI_CT_ID, True)
            Control_SetRequire(cFilterTaiKhoan, True)

            m_InputState = eState
            m_CTH_ID = CTH_ID
            If lstCT_H_GInfo IsNot Nothing Then
                m_LstCT_H_GInfo = lstCT_H_GInfo
            End If
            m_MA_LOAI_CT = MA_LOAI_CT
            Dim objHTCT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
            m_SD_CT_THUE = TNCommon.ParseBool(objHTCT.SdTkThueNgamdinh)

            UR_Status.LCT_STATUS = objHTCT.Id

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
            AddHandler GRV_CTH.FocusedRowChanged, AddressOf GRV_CTH_FocusedRowChanged
        Catch ex As Exception
            Message_Error(ex)
        End Try
        If (Me.ShowDialog = DialogResult.OK) Then
            Return m_CT_HInfo
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Private Function and Procedures"

    Private Sub Init_Data()
        m_OnLoadData = True

        If m_InputState = DataInputState.AddMode Then
            DatTrangThaiControl()
            BindLookup()
            daeNGAY_CT.DateTime = DateTime.Now
            m_HT_CT_Info = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            m_HT_LoaiCT_Info = m_HT_CT_Info

            If m_HT_CT_Info IsNot Nothing Then
                ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_HT_CT_Info.MaLoaiCt, _GridView.Name, _GridView)
            End If

            TNCommon.SelectFirst(grlLOAI_CT_ID)
            m_LstCT_DInfo.Add(New CtD())
            _GridControl.DataSource = m_LstCT_DInfo

            SetColNgoaiTe()
            SetTongTienThue()
            TongSoTien()
        Else
            DatTrangThaiControl()
            BindLookup()
            SetObjectToControl()
            SetTongTienThue()
            TongSoTien()
        End If

        Load_Grid(m_LstCT_H_GInfo)

        If _GridView.RowCount <> 0 Then
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        End If

        m_OnLoadData = False
    End Sub

    Private Sub Check_ColHoaDon(ByVal chk_Hoadon As Boolean)
        If Not chk_Hoadon Then
            'ko hien thi
            _GridView.Columns("MaHoadon").Visible = False
        Else
            'hien thi
            _GridView.Columns("MaTkNo").VisibleIndex = 0
            _GridView.Columns("TenTkNo").VisibleIndex = 1
            _GridView.Columns("MaTkCo").VisibleIndex = 2
            _GridView.Columns("TenTkCo").VisibleIndex = 3
            _GridView.Columns("KyHieuKhangCo").VisibleIndex = 4
            _GridView.Columns("TenKhangCo").VisibleIndex = 5
            _GridView.Columns("SoTienNte").VisibleIndex = 6
            _GridView.Columns("SoTien").VisibleIndex = 7
            _GridView.Columns("MaHoadon").VisibleIndex = 8
            _GridView.Columns("IdDmPtqtCo").VisibleIndex = 9
            _GridView.Columns("NoiDung").VisibleIndex = 10
            _GridView.Columns("IdDmVuviecCo").VisibleIndex = 11
            _GridView.Columns("IdDmKhoanphiCo").VisibleIndex = 12
            _GridView.Columns("IdDmPhongbanCo").VisibleIndex = 13
            _GridView.Columns("IdDmTudo1Co").VisibleIndex = 14
            _GridView.Columns("IdDmTudo2Co").VisibleIndex = 15
            _GridView.Columns("IdDmTudo3Co").VisibleIndex = 16
            _GridView.Columns("IdDmTudo4Co").VisibleIndex = 17
            _GridView.Columns("IdDmTudo5Co").VisibleIndex = 18
            _GridView.Columns("IdDmHopdongCo").VisibleIndex = 19
        End If
    End Sub

    Private Sub SaveData()
        GetControlToOBject()
        'LoadDB()
    End Sub

    Private Function KiemTraDuLieuTKChiTiet() As Boolean
        'Kiem tra du lieu
        'Gan du lieu lien quan vao CT_H
        'GetCTHToObj()

        For Each objctd As CtD In m_LstCT_DInfo
            If m_InputState = DataInputState.CopyMode Then
                objctd.Id = Nothing
            End If
            objctd.CthId = m_CT_HInfo.Id
            objctd.SoDu = 0
            objctd.PhanHe = 1
            If _GridView.Columns("KyHieuKhangCo").Visible = True Then
                objctd.IdKhangNo = objctd.IdKhangCo
                objctd.KyHieuKhangNo = objctd.KyHieuKhangCo
                objctd.TenKhangNo = objctd.TenKhangCo
                objctd.MaKhangNo = objctd.MaKhangCo
            Else
                objctd.IdKhangCo = m_CT_HInfo.KhangId
                objctd.KyHieuKhangCo = m_CT_HInfo.KyHieuKhang
                objctd.TenKhangCo = m_CT_HInfo.TenKhang
                objctd.MaKhangCo = m_CT_HInfo.MaKhang

                objctd.IdKhangNo = objctd.IdKhangCo
                objctd.KyHieuKhangNo = objctd.KyHieuKhangCo
                objctd.TenKhangNo = objctd.TenKhangCo
                objctd.MaKhangNo = objctd.MaKhangCo
            End If
            If (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) Then
                objctd.SoTienNte = 0
            End If
            'Vu viec no- chu dung den
            objctd.IdDmVuviecNo = objctd.IdDmVuviecCo
            objctd.MaVuviecNo = objctd.MaVuviecCo
            objctd.KyHieuVuviecNo = objctd.KyHieuVuviecCo

            objctd.IdDmHopdongNo = objctd.IdDmHopdongCo
            objctd.KyHieuHopdongNo = objctd.KyHieuHopdongCo
            objctd.IdDmKhoanphiNo = objctd.IdDmKhoanphiCo
            objctd.IdDmPtqtNo = objctd.IdDmPtqtCo
            objctd.IdDmPhongbanNo = objctd.IdDmPhongbanCo
            objctd.IdDmPtqtNo = objctd.IdDmPtqtCo
            objctd.IdDmTudo1No = objctd.IdDmTudo1Co
            objctd.IdDmTudo2No = objctd.IdDmTudo2Co
            objctd.IdDmTudo3No = objctd.IdDmTudo3Co
            objctd.IdDmTudo4No = objctd.IdDmTudo4Co
            objctd.IdDmTudo5No = objctd.IdDmTudo5Co

            Dim ErrorMessage As String = ""
            If Not (_CtDService.KiemTraChiTietDinhKhoan(ErrorMessage, objctd)) Then
                Message_Information(ErrorMessage)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub GetControlToOBject()
        GetCTHToObj()

        Dim strmMonth As String
        Dim strYear As String
        Dim bInsert As Boolean = True
        Select Case m_InputState
            Case DataInputState.AddMode
                strmMonth = Month(daeNGAY_GHI.DateTime).ToString
                strYear = Year(daeNGAY_GHI.DateTime).ToString
                C_SoChungTu_RP.r_SoCTPREFIX(m_HT_LoaiCT_Info.LoaiCtIdCha, strmMonth, strYear, Generals.DON_VI.Id)
                m_CT_HInfo.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                m_CT_HInfo.PrefixCt = C_SoChungTu_RP.PREFIX
                'm_CT_HInfo = InsertCT_H(m_CT_HInfo)
            Case DataInputState.CopyMode
                strmMonth = Month(daeNGAY_GHI.DateTime).ToString
                strYear = Year(daeNGAY_GHI.DateTime).ToString
                C_SoChungTu_RP.r_SoCTPREFIX(m_HT_LoaiCT_Info.LoaiCtIdCha, strmMonth, strYear, Generals.DON_VI.Id)
                m_CT_HInfo.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                m_CT_HInfo.PrefixCt = C_SoChungTu_RP.PREFIX
                ' m_CT_HInfo = InsertCT_H(m_CT_HInfo)
            Case Else
                bInsert = False
                'UpdateCT_H(m_CT_HInfo)
        End Select

        'Insert update CT_D
        For Each objctd As CtD In m_LstCT_DInfo
            If m_InputState = DataInputState.CopyMode Then
                objctd.Id = Nothing
            End If
            'objctd. = m_CT_HInfo.CTH_ID
            objctd.SoDu = 0
            objctd.PhanHe = 1
            If _GridView.Columns("KyHieuKhangCo").Visible = True Then
                objctd.IdKhangNo = objctd.IdKhangCo
                objctd.KyHieuKhangNo = objctd.KyHieuKhangCo
                objctd.TenKhangNo = objctd.TenKhangCo
                objctd.MaKhangNo = objctd.MaKhangCo
            Else
                'Khach hang CO'
                objctd.IdKhangCo = m_CT_HInfo.KhangId
                objctd.KyHieuKhangCo = m_CT_HInfo.KyHieuKhang
                objctd.TenKhangCo = m_CT_HInfo.TenKhang
                objctd.MaKhangCo = m_CT_HInfo.MaKhang
                'Khach hang NO*
                objctd.IdKhangNo = objctd.IdKhangCo
                objctd.KyHieuKhangNo = objctd.KyHieuKhangCo
                objctd.TenKhangNo = objctd.TenKhangCo
                objctd.MaKhangNo = objctd.MaKhangCo
            End If
            If (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) Then
                objctd.SoTienNte = 0
            End If
            'Vu viec no- chu dung den
            objctd.IdDmVuviecNo = objctd.IdDmVuviecCo
            objctd.MaVuviecNo = objctd.MaVuviecCo
            objctd.KyHieuVuviecNo = objctd.KyHieuVuviecCo
            objctd.IdDmHopdongNo = objctd.IdDmKhoanphiCo
            objctd.KyHieuHopdongNo = objctd.KyHieuHopdongCo
            objctd.IdDmKhoanphiNo = objctd.IdDmKhoanphiCo
            objctd.IdDmPtqtNo = objctd.IdDmPtqtCo
            objctd.IdDmPhongbanNo = objctd.IdDmPhongbanCo
            objctd.IdDmPtqtNo = objctd.IdDmPtqtCo
            objctd.IdDmTudo1No = objctd.IdDmTudo1Co
            objctd.IdDmTudo2No = objctd.IdDmTudo2Co
            objctd.IdDmTudo3No = objctd.IdDmTudo3Co
            objctd.IdDmTudo4No = objctd.IdDmTudo4Co
            objctd.IdDmTudo5No = objctd.IdDmTudo5Co
        Next

        'insert ctdthue
        Dim objctdthue As CtD = New CtD

        If Not (cFilterTaiKhoanThue.Tag = Nothing) Then
            'objctdthue.CTH_ID = m_CT_HInfo.CTH_ID
            objctdthue.IdKhangCo = m_CT_HInfo.KhangId
            If (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) Then
                objctdthue.SoTienNte = 0
            End If

            'Vu viec no- chu dung den
            objctdthue.LoaiNghiepVu = 1
            objctdthue.NoiDung = "Chứng từ thuế"

            'Kiem tra la phieu xuat = 0 de gan gia tri tham so
            If (m_HT_CT_Info.PhieuXuat = 0) Then
                objctdthue.MaTkCo = cFilterTaiKhoan.ListEditValue(1)
                objctdthue.TkCoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                objctdthue.TenTkCo = cFilterTaiKhoan.ListEditValue(2)

                objctdthue.MaTkNo = cFilterTaiKhoanThue.ListEditValue(1)
                objctdthue.TkNoId = VnsConvert.CGuid(cFilterTaiKhoanThue.ListEditValue(0))
                objctdthue.TenTkNo = cFilterTaiKhoanThue.ListEditValue(2)
            Else
                objctdthue.MaTkNo = cFilterTaiKhoan.ListEditValue(1)
                objctdthue.TkNoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                objctdthue.TenTkNo = cFilterTaiKhoan.ListEditValue(2)

                objctdthue.MaTkCo = cFilterTaiKhoanThue.ListEditValue(1)
                objctdthue.TkCoId = VnsConvert.CGuid(cFilterTaiKhoanThue.ListEditValue(0))
                objctdthue.TenTkCo = cFilterTaiKhoanThue.ListEditValue(2)
            End If

            objctdthue.SoTien = Convert.ToDecimal(txtTongTienThue.Text)

            If m_CT_HoadonInfo IsNot Nothing Then
                objctdthue.IdDoituongHoadon = m_CT_HoadonInfo.Id
                objctdthue.KyHieuHoadon = m_CT_HoadonInfo.SoSeri
                objctdthue.MaHoadon = m_CT_HoadonInfo.SoHoadon
            End If
            objctdthue.IdDmVuviecNo = objctdthue.IdDmVuviecCo
            objctdthue.MaVuviecNo = objctdthue.MaVuviecCo
            objctdthue.KyHieuVuviecNo = objctdthue.KyHieuVuviecCo

            If (m_LstCT_DInfo_Thue.Count <> 0) Then
                objctdthue.Id = m_LstCT_DInfo_Thue(0).Id
            End If

            'insert update chung tu thue
            If m_LstCT_ThueInfo.Count = 0 Then
                If m_LstCT_DInfo_Thue IsNot Nothing Then
                    If m_LstCT_DInfo_Thue.Count <> 0 Then
                        m_LstCT_ThueInfo = _CtThueService.GetObjectAllByCTD_ID(m_LstCT_DInfo_Thue(0).Id)
                    End If
                End If
            End If

            For Each objcthue As CtThue In m_LstCT_ThueInfo
                objcthue.MaTaikhoan = cFilterTaiKhoanThue.ListEditValue(1)
                objcthue.TaikhoanId = VnsConvert.CGuid(cFilterTaiKhoanThue.ListEditValue(0))
                'Them CTH_ID vao chung tu thue
                objcthue.CthId = m_CT_HInfo.Id
                objcthue.PhanHe = 0
            Next
        End If

        _CtHService.SaveChungTuKeToan(bInsert, m_CT_HoadonInfo, m_CT_HInfo, m_LstCT_DInfo, m_Del_LstCT_DInfo, VnsConvert.CGuid(cFilterTaiKhoanThue.Tag), _
                                          m_LstCT_DInfo_Thue, objctdthue, m_LstCT_ThueInfo, m_Del_LstCT_ThueInfo)

        'Gan lai gia tri so chung tu sau khi luu dl
        C_SoChungTu_RP.Text = m_CT_HInfo.PrefixCt + m_CT_HInfo.CtSo
    End Sub

    Private Function Check_Tien_Thue() As Boolean
        Dim lst_CT_ThueInfo As List(Of CtThue) = New List(Of CtThue)
        Dim TienHang_Thue As Decimal = 0
        Dim Tien_Hang As Decimal = 0

        If (cFilterTaiKhoanThue.Tag = Nothing) Then
            Return True

        End If

        If m_LstCT_DInfo_Thue.Count <> 0 Then
            If m_LstCT_ThueInfo.Count = 0 Then
                lst_CT_ThueInfo = _CtThueService.GetObjectAllByCTD_ID(m_LstCT_DInfo_Thue(0).Id)
            Else
                lst_CT_ThueInfo = m_LstCT_ThueInfo
            End If
        Else
            lst_CT_ThueInfo = m_LstCT_ThueInfo
        End If

        'Tinh tien hang trong Form khai thue
        For Each objThueInfo As CtThue In lst_CT_ThueInfo
            TienHang_Thue = TienHang_Thue + objThueInfo.DoanhSo
        Next

        'Tien hang ngoai Phieu
        If txtTongSoTien.Text <> "" Then
            Tien_Hang = Decimal.Parse(txtTongSoTien.Text)
        End If

        If Tien_Hang <> TienHang_Thue Then
            Message_Warning("Tiền hàng trong kê khai thuế và tiền hàng ở chi tiết định khoản không hợp lệ!")
            Return False
        End If
        'End If

        Return True
    End Function

    Private Sub GetCTHToObj()
        If m_CT_HInfo Is Nothing Then
            m_CT_HInfo = New CtH
        End If
        m_CT_HInfo.SoDu = 0
        m_CT_HInfo.KhangId = VnsConvert.CGuid(cFilter.ListEditValue(0))
        m_CT_HInfo.MaKhang = cFilter.ListEditValue(2)
        m_CT_HInfo.KyHieuKhang = cFilter.ListEditValue(3)
        m_CT_HInfo.MstKhang = txtMST_KHANG.Text.Trim()
        m_CT_HInfo.TenKhang = txtTEN_KHANG.Text.Trim()
        m_CT_HInfo.DiaChi = txtDIA_CHI.Text.Trim()
        m_CT_HInfo.TyGia = txtTY_GIA1.Text.Trim()

        Select Case m_InputState
            Case DataInputState.AddMode
                m_CT_HInfo.NguoiTao = Generals.USER.Id
                m_CT_HInfo.DaKhoaSo = 0
                m_CT_HInfo.BtTudong = 0
            Case DataInputState.CopyMode
                m_CT_HInfo.NguoiTao = Generals.USER.Id
                m_CT_HInfo.DaKhoaSo = 0
                m_CT_HInfo.BtTudong = 0
            Case Else
                m_CT_HInfo.NguoiSua = Generals.USER.Id
        End Select

        m_CT_HInfo.Ghi = Convert.ToDecimal(UR_Status.Value_info.ParameterValue)
        m_CT_HInfo.SoTien = txtTongTien.Text
        m_CT_HInfo.MaNte = cboNgoaiTe.Text
        m_CT_HInfo.NteId = cboNgoaiTe.EditValue
        m_CT_HInfo.NgoaiTe = TNCommon.ParseDecimal(Not (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))
        m_CT_HInfo.NguoiNhanNopTien = txtNGUOI_NHAN_NOP_TIEN.Text
        m_CT_HInfo.DienGiai = txtDIEN_GIAI.Text
        m_CT_HInfo.NgayCt = daeNGAY_CT.DateTime
        m_CT_HInfo.NgayGhi = daeNGAY_GHI.DateTime

        If Generals.DON_VI.BoPhanTt = 1 Then
            m_CT_HInfo.DonviCt = Generals.DON_VI.DonviIdCha
        End If

        m_CT_HInfo.DonviId = Generals.DON_VI.Id
        m_CT_HInfo.MaDonvi = Generals.DON_VI.MaDonvi
        Dim drChungTu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
        m_CT_HInfo.IdLoaiCt = drChungTu.Id
        m_CT_HInfo.KyHieuLoaiCt = drChungTu.KyHieu
        m_CT_HInfo.MaLoaiCt = drChungTu.MaLoaiCt
    End Sub

    ''' <summary>
    ''' Check gia tri so tien va so luong nhap vao tren form xem co nam trong khoang hop le khong
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function check_NumberInput() As Boolean
        If txtTY_GIA1.Text <> "" Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtTY_GIA1.Text)) Then
                Message_Warning("Giá trị tỷ giá nhập vào không hợp lệ!")
                txtTY_GIA1.Focus()
                Return False
            End If
        End If

        For Each objCT_DInfo As CtD In m_LstCT_DInfo
            If Not LimitValue.CheckFCurrency(objCT_DInfo.SoTienNte) Then
                Message_Warning("Giá trị số tiền ngoại tệ bạn nhập vào không hợp lệ!")
                Return False
            End If

            If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                If objCT_DInfo.SoTienNte = 0 Then
                    Message_Warning("Giá trị số tiền ngoại tệ nhập vào không hợp lệ!")
                    Return False
                End If
            End If

            If objCT_DInfo.SoTien = 0 Then
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(objCT_DInfo.SoTien) Then
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub SetObjectToControl()
        If m_InputState = DataInputState.CopyMode Then
            m_CTH_ID = Nothing
        End If
        If m_CTH_ID = Null.NullGuid Then
            m_CTH_ID = m_CT_HInfo.Id
        End If

        'Lay CT_H
        m_CT_HInfo = _CtHService.GetById(m_CTH_ID)
        If (m_CT_HInfo Is Nothing) Then
            Return
        End If

        'assign value to control
        cboNgoaiTe.EditValue = m_CT_HInfo.NteId
        cFilter.Text = m_CT_HInfo.KyHieuKhang
        cFilter.Tag = m_CT_HInfo.KhangId
        UR_Status.Set_Status(m_CT_HInfo.Ghi.ToString())
        txtDIA_CHI.Text = m_CT_HInfo.DiaChi
        txtNGUOI_NHAN_NOP_TIEN.Text = m_CT_HInfo.NguoiNhanNopTien
        txtDIEN_GIAI.Text = m_CT_HInfo.DienGiai
        daeNGAY_CT.DateTime = m_CT_HInfo.NgayCt
        daeNGAY_GHI.DateTime = m_CT_HInfo.NgayGhi
        C_SoChungTu_RP.Text = m_CT_HInfo.PrefixCt + m_CT_HInfo.CtSo
        txtTEN_KHANG.Text = m_CT_HInfo.TenKhang
        txtMST_KHANG.Text = m_CT_HInfo.MstKhang
        txtTY_GIA1.Text = m_CT_HInfo.TyGia

        m_HT_LoaiCT_Info = _HtLoaichungtuService.GetById(m_CT_HInfo.IdLoaiCt)
        ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_HT_LoaiCT_Info.MaLoaiCt, _GridView.Name, _GridView)
        SetCol(m_HT_LoaiCT_Info)

        'Lay CT_D
        m_LstCT_DInfo = New List(Of CtD)()
        m_LstCT_DInfo.AddRange(_CtDService.GetByCtHandNghiepVu(m_CTH_ID, 0))

        If m_LstCT_DInfo.Count <> 0 Then
            If m_HT_LoaiCT_Info.PhieuXuat = 1 Then
                cFilterTaiKhoan.Text = m_LstCT_DInfo(0).MaTkNo
                cFilterTaiKhoan.Tag = m_LstCT_DInfo(0).TkNoId
            Else
                cFilterTaiKhoan.Text = m_LstCT_DInfo(0).MaTkCo
                cFilterTaiKhoan.Tag = m_LstCT_DInfo(0).TkCoId
            End If
        End If

        'Lay CTD_Thue(Loai nghiep vu =1)
        m_LstCT_DInfo_Thue = New List(Of CtD)
        m_LstCT_DInfo_Thue.AddRange(_CtDService.GetByCtHandNghiepVu(m_CTH_ID, 1))

        'Lay CT_HOADON, ct_thue
        If m_LstCT_DInfo_Thue.Count <> 0 Then

            m_LstCT_ThueInfo = New List(Of CtThue)
            m_LstCT_ThueInfo.AddRange(_CtThueService.GetObjectAllByCTD_ID(m_LstCT_DInfo_Thue(0).Id))

            m_CT_HoadonInfo = _CtHoadonService.GetById(m_LstCT_ThueInfo(0).CtHoadonId)

            If m_HT_LoaiCT_Info.PhieuXuat = 0 Then
                cFilterTaiKhoanThue.Text = m_LstCT_DInfo_Thue(0).MaTkNo
                cFilterTaiKhoanThue.Tag = m_LstCT_DInfo_Thue(0).TkNoId
            Else
                cFilterTaiKhoanThue.Text = m_LstCT_DInfo_Thue(0).MaTkCo
                cFilterTaiKhoanThue.Tag = m_LstCT_DInfo_Thue(0).TkCoId
            End If
        Else
            cFilterTaiKhoanThue.Text = ""
            cFilterTaiKhoanThue.Tag = Null.NullGuid
            txtTongTienThue.Text = 0
        End If
        _GridControl.DataSource = m_LstCT_DInfo
        grlLOAI_CT_ID.EditValue = m_CT_HInfo.IdLoaiCt
        grlLOAI_CT_ID.Properties.ReadOnly = True

        SetColNgoaiTe()

        ''Kiểm tra trạng thái có cho phép sửa hay không
        If Not (UR_Status.ChoPhepSuaCT) Then
            UR_Status.Enabled = False
        Else
            UR_Status.Enabled = True
        End If
    End Sub

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

    Private Sub BindLookup()
        'Bind loại chứng từ
        RemoveHandler grlLOAI_CT_ID.EditValueChanged, AddressOf grlLOAI_CT_ID_EditValueChanged
        If String.IsNullOrEmpty(m_MA_LOAI_CT) Then
            m_MA_LOAI_CT = ""
        End If

        Dim lstLoaiChungTu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        lstLoaiChungTu.AddRange(_HtLoaichungtuService.LikeObjetMA_LOAI_CT(m_MA_LOAI_CT, Generals.DonviID))
        grlLOAI_CT_ID.Properties.DataSource = lstLoaiChungTu
        grlLOAI_CT_ID.Properties.DisplayMember = "KyHieu"
        grlLOAI_CT_ID.Properties.ValueMember = "Id"
        AddHandler grlLOAI_CT_ID.EditValueChanged, AddressOf grlLOAI_CT_ID_EditValueChanged

        'Bind danh muc ngoai te
        Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
        lstNgoaite.AddRange(_DmNgoaiteService.GetAll())
        cboNgoaiTe.Properties.DisplayMember = "KyHieu"
        cboNgoaiTe.Properties.ValueMember = "Id"
        cboNgoaiTe.Properties.DataSource = lstNgoaite
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA1.Text = "1"

        'Bind hợp đồng
        Dim lstHopDong As List(Of DmHopdong) = New List(Of DmHopdong)
        lstHopDong.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstHopDong_temp As List(Of DmHopdong) = New List(Of DmHopdong)
        Dim obj_HD As DmHopdong = New DmHopdong()
        lstHopDong_temp.Add(obj_HD)
        lstHopDong_temp.AddRange(lstHopDong)
        cboHopDong.DataSource = lstHopDong_temp

        cboHopDong.DisplayMember = "KyHieu"
        cboHopDong.ValueMember = "Id"
        cboHopDong.Columns.Add(New LookUpColumnInfo("MaHopdong", "Mã hợp đồng"))
        cboHopDong.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

        ''Bind vu viec
        Dim lstVuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViec.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstVuViec_temp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim obj_VV As DmVuviec = New DmVuviec()
        lstVuViec_temp.Add(obj_VV)
        lstVuViec_temp.AddRange(lstVuViec)

        cboVuViec.DataSource = lstVuViec_temp
        cboVuViec.DisplayMember = "KyHieu"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("MaVuviec", "Mã vụ việc"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))

        'Bind phong ban
        Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstPhongBan.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstPhongBan_temp As List(Of DmPhongban) = New List(Of DmPhongban)
        Dim obj_PB As DmPhongban = New DmPhongban()
        lstPhongBan_temp.Add(obj_PB)
        lstPhongBan_temp.AddRange(lstPhongBan)

        cboPhongBan.DataSource = lstPhongBan_temp
        cboPhongBan.DisplayMember = "KyHieu"
        cboPhongBan.ValueMember = "Id"
        cboPhongBan.Columns.Add(New LookUpColumnInfo("MaPhongban", "Mã phòng ban"))
        cboPhongBan.Columns.Add(New LookUpColumnInfo("TenPhongban", "Tên phòng ban"))

        ''Bind khoan phi
        Dim lstKhoanPhi As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        lstKhoanPhi.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstKhoanPhi_temp As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        Dim obj_KP As DmKhoanphi = New DmKhoanphi()
        lstKhoanPhi_temp.Add(obj_KP)
        lstKhoanPhi_temp.AddRange(lstKhoanPhi)

        cboKhoanPhi.DataSource = lstKhoanPhi_temp
        cboKhoanPhi.DisplayMember = "KyHieu"
        cboKhoanPhi.ValueMember = "Id"
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("MaDmKhoanphi", "Mã khoản phí"))
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))

        'Bind tu do 1
        Dim lstTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo1_temp As List(Of DmTudo1) = New List(Of DmTudo1)
        Dim obj_TD1 As DmTudo1 = New DmTudo1()
        lstTuDo1_temp.Add(obj_TD1)
        lstTuDo1_temp.AddRange(lstTuDo1)

        cboDMTudo1.DataSource = lstTuDo1_temp
        cboDMTudo1.DisplayMember = "KyHieu"
        cboDMTudo1.ValueMember = "Id"
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục"))

        'Bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo2_temp As List(Of DmTudo2) = New List(Of DmTudo2)
        Dim obj_TD2 As DmTudo2 = New DmTudo2()
        lstTuDo2_temp.Add(obj_TD2)
        lstTuDo2_temp.AddRange(lstTuDo2)

        cboDMTudo2.DataSource = lstTuDo2_temp
        cboDMTudo2.DisplayMember = "KyHieu"
        cboDMTudo2.ValueMember = "Id"
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("TenDmTudo2", "Tên danh mục"))

        'Bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo3_temp As List(Of DmTudo3) = New List(Of DmTudo3)
        Dim obj_TD3 As DmTudo3 = New DmTudo3
        lstTuDo3_temp.Add(obj_TD3)
        lstTuDo3_temp.AddRange(lstTuDo3)

        cboDMTudo3.DataSource = lstTuDo3_temp
        cboDMTudo3.DisplayMember = "KyHieu"
        cboDMTudo3.ValueMember = "Id"
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("TenDmTudo3", "Tên danh mục"))

        'Bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo4_temp As List(Of DmTudo4) = New List(Of DmTudo4)
        Dim obj_TD4 As DmTudo4 = New DmTudo4()
        lstTuDo4_temp.Add(obj_TD4)
        lstTuDo4_temp.AddRange(lstTuDo4)

        cboDMTudo4.DataSource = lstTuDo4_temp
        cboDMTudo4.DisplayMember = "KyHieu"
        cboDMTudo4.ValueMember = "Id"
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("TenDmTudo4", "Tên danh mục"))

        'Bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo5_temp As List(Of DmTudo5) = New List(Of DmTudo5)
        Dim obj_TD5 As DmTudo5 = New DmTudo5
        lstTuDo5_temp.Add(obj_TD5)
        lstTuDo5_temp.AddRange(lstTuDo5)

        cboDMTudo5.DataSource = lstTuDo5_temp
        cboDMTudo5.DisplayMember = "KyHieu"
        cboDMTudo5.ValueMember = "Id"
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("TenDmTudo5", "Tên danh mục"))

        ''Bind Phương pháp quả trị

        Dim lstPPQT As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQT.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))


        Dim lstPPQT_temp As List(Of DmPtqt) = New List(Of DmPtqt)
        Dim obj_PTQT As DmPtqt = New DmPtqt
        lstPPQT_temp.Add(obj_PTQT)
        lstPPQT_temp.AddRange(lstPPQT)

        cboPPQT.DataSource = lstPPQT_temp
        cboPPQT.DisplayMember = "KyHieu"
        cboPPQT.ValueMember = "Id"
        cboPPQT.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã PTQT"))
        cboPPQT.Columns.Add(New LookUpColumnInfo("TenPtqt", "Tên PTQT"))
    End Sub

    Private Sub SetColNgoaiTe()
        If cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
            txtTY_GIA1.Text = 1
            txtTY_GIA1.Enabled = False
            _GridView.Columns("SoTienNte").Visible = False
            _GridView.Columns("SoTien").OptionsColumn.ReadOnly = False
        Else
            txtTY_GIA1.Enabled = True
            _GridView.Columns("SoTienNte").VisibleIndex = _GridView.Columns("SoTien").VisibleIndex
            _GridView.Columns("SoTien").OptionsColumn.ReadOnly = True
        End If
    End Sub

    Private Sub SetCol(ByVal _htLoaiCT As HtLoaichungtu)
        If _htLoaiCT Is Nothing Then
            Return
        End If
        If _htLoaiCT.KyHieu = "2" Then
            cFilter.ENABLES = False
            txtMST_KHANG.Properties.Enabled = False
            txtMST_KHANG.Text = ""
            txtTEN_KHANG.Properties.Enabled = False
            txtTEN_KHANG.Text = ""
            txtDIA_CHI.Properties.Enabled = False
            txtDIA_CHI.Text = ""
            cFilter.Text = ""
        Else
            If m_InputState <> DataInputState.ViewMode Then
                cFilter.ENABLES = True
            End If
            txtMST_KHANG.Properties.Enabled = True
            txtTEN_KHANG.Properties.Enabled = True
            txtDIA_CHI.Properties.Enabled = True
        End If
        _GridView.Columns("IdDmPtqtCo").Visible = _htLoaiCT.DmPtqt
        _GridView.Columns("IdDmPhongbanCo").Visible = _htLoaiCT.DmPhongban
        _GridView.Columns("IdDmKhoanphiCo").Visible = _htLoaiCT.DmKhoanphi

        _GridView.Columns("IdDmVuviecCo").Visible = _htLoaiCT.DmVuviec
        _GridView.Columns("IdDmTudo1Co").Visible = _htLoaiCT.DmTudo1
        _GridView.Columns("IdDmTudo2Co").Visible = _htLoaiCT.DmTudo2
        _GridView.Columns("IdDmTudo3Co").Visible = _htLoaiCT.DmTudo3
        _GridView.Columns("IdDmTudo4Co").Visible = _htLoaiCT.DmTudo4
        _GridView.Columns("IdDmTudo5Co").Visible = _htLoaiCT.DmTudo5
        _GridView.Columns("KyHieuKhangCo").Visible = _htLoaiCT.DmKhang
        _GridView.Columns("TenKhangCo").Visible = _htLoaiCT.DmKhang
        _GridView.Columns("IdDmHopdongCo").Visible = _htLoaiCT.DmHopdong

        SetColNgoaiTe()
    End Sub

    Private Sub DeleteRow()
        Try
            Dim gridctd As CtD = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtD)
            m_Del_LstCT_DInfo.Add(gridctd)
            _GridView.DeleteSelectedRows()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetFocus_AfterAddRow()
        _GridView.FocusedRowHandle = m_LstCT_DInfo.Count - 1
        _GridView.SelectRow(Handle)
        Try
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ThemDong()
        If Not String.IsNullOrEmpty(cFilterTaiKhoan.Tag) Then
            Try
                Dim ct_DInfor As CtD = New CtD

                If m_HT_CT_Info.PhieuXuat = 0 Then
                    ct_DInfor.MaTkCo = cFilterTaiKhoan.ListEditValue(1)
                    ct_DInfor.TkCoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                    ct_DInfor.TenTkCo = cFilterTaiKhoan.ListEditValue(2)
                    ct_DInfor.NoiDung = txtDIEN_GIAI.Text.Trim()
                Else
                    ct_DInfor.MaTkNo = cFilterTaiKhoan.ListEditValue(1)
                    ct_DInfor.TkNoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                    ct_DInfor.TenTkNo = cFilterTaiKhoan.ListEditValue(2)
                    ct_DInfor.NoiDung = txtDIEN_GIAI.Text.Trim()
                End If
                m_LstCT_DInfo.Add(ct_DInfor)
                _GridView.RefreshData()
                SetFocus_AfterAddRow()
            Catch ex As Exception
                Message_Error(ex)
            End Try
        Else
            Message_Warning("Bạn chưa chọn tài khoản nợ/có")
            cFilterTaiKhoan.Focus()
        End If
    End Sub

    Private Sub SetMaTk()
        Try
            If (m_HT_CT_Info.PhieuXuat = 1) Then
                'SetObjectToControl(0)
                Me.MA_TK_NO.OptionsColumn.ReadOnly = True
                Me.MA_TK_CO.OptionsColumn.ReadOnly = False
                If _GridView.RowCount > 0 Then
                    cFilterTaiKhoan.Text = m_LstCT_DInfo(0).MaTkNo
                    cFilterTaiKhoan.Tag = m_LstCT_DInfo(0).TkNoId

                End If
            ElseIf (m_HT_CT_Info.PhieuXuat = 0) Then
                'SetObjectToControl(1)
                Me.MA_TK_NO.OptionsColumn.ReadOnly = False
                Me.MA_TK_CO.OptionsColumn.ReadOnly = True
                If _GridView.RowCount > 0 Then
                    cFilterTaiKhoan.Text = m_LstCT_DInfo(0).MaTkCo
                    cFilterTaiKhoan.Tag = m_LstCT_DInfo(0).TkCoId
                End If
            Else
                Me.MA_TK_NO.OptionsColumn.ReadOnly = False
                Me.MA_TK_CO.OptionsColumn.ReadOnly = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bind_DanhMuc(ByVal MA_TK As String)
        If _GridView.Columns("IdDmPtqtCo").Visible = True Then
            'Bind_PPTT(MA_TK)
        End If

        If _GridView.Columns("IdDmTudo1Co").Visible = True Then
            'Bind_TD1(MA_TK)
        End If

        If _GridView.Columns("IdDmTudo2Co").Visible = True Then
            'Bind_TD2(MA_TK)
        End If

        If _GridView.Columns("IdDmTudo3Co").Visible = True Then
            'Bind_TD3(MA_TK)
        End If

        If _GridView.Columns("IdDmTudo4Co").Visible = True Then
            'Bind_TD4(MA_TK)
        End If

        If _GridView.Columns("IdDmTudo5Co").Visible = True Then
            'Bind_TD5(MA_TK)
        End If

        If _GridView.Columns("IdDmVuviecCo").Visible = True Then
            'Bind_VuViec(MA_TK)
        End If

        If _GridView.Columns("IdDmKhoanphiCo").Visible = True Then
            'Bind_KhoanPhi(MA_TK)
        End If

    End Sub

    Private Sub TongSoTien()
        'tinh tong so tien
        Dim sum As Decimal = 0
        Dim i As Integer
        For i = 0 To _GridView.RowCount - 1
            sum = sum + _GridView.GetRowCellValue(i, "SoTien")
        Next
        'sotien = sum.ToString
        txtTongSoTien.Text = sum.ToString 'sotien
        If txtTongTienThue.Text = "" Then
            txtTongTien.Text = Convert.ToString(Convert.ToDecimal(txtTongSoTien.Text))
        Else
            txtTongTien.Text = _
                Convert.ToString(Convert.ToDecimal(txtTongSoTien.Text) + Convert.ToDecimal(txtTongTienThue.Text))
        End If
    End Sub

    Private Sub SetTongTienThue()

        If m_LstCT_DInfo_Thue.Count = 0 Then
            txtTongTienThue.Text = 0
        Else
            txtTongTienThue.Text = m_LstCT_DInfo_Thue(0).SoTien
        End If
    End Sub

    Private Sub SetFocus_FirstCell()
        Try
            If _GridView.RowCount <> 0 Then
                _GridView.FocusedColumn = _GridView.VisibleColumns(0)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                GRC_CTH.Enabled = False
                navWelding1.Enabled = False
                Control_SetState(grpSMQR, DataInputState.AddMode)
                Control_SetState(grcCT_Thue, DataInputState.AddMode)
                _GridView.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
                btnPri.Enabled = False
                btnCancel.Enabled = True
                btnHoaDon.Enabled = True
                btnThue.Enabled = True
                btnCopy.Enabled = False
                btnSearch.Enabled = False
                'CustomViewLog1.Enabled = False

                txtTongSoTien.Properties.ReadOnly = True
                'txtCT_SO.Properties.ReadOnly = True
                txtTongTienThue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                cFilter.ENABLES = True
                cFilterTaiKhoan.ENABLES = True
                cFilterTaiKhoanThue.ENABLES = True
            Case DataInputState.EditMode
                GRC_CTH.Enabled = False
                navWelding1.Enabled = False
                Control_SetState(grpSMQR, DataInputState.EditMode)
                grlLOAI_CT_ID.Properties.ReadOnly = True
                Control_SetState(grcCT_Thue, DataInputState.EditMode)
                _GridView.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnCopy.Enabled = True
                btnSave.Enabled = True
                btnDelete.Enabled = True
                btnPri.Enabled = True
                btnCancel.Enabled = True
                btnHoaDon.Enabled = True
                btnThue.Enabled = True
                btnSearch.Enabled = False
                'CustomViewLog1.Enabled = True

                txtTongSoTien.Properties.ReadOnly = True
                'txtCT_SO.Properties.ReadOnly = True
                txtTongTienThue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                cFilter.ENABLES = True
                cFilterTaiKhoan.ENABLES = True
                cFilterTaiKhoanThue.ENABLES = True
            Case DataInputState.ViewMode
                GRC_CTH.Enabled = True
                navWelding1.Enabled = True
                Control_SetState(grpSMQR, DataInputState.ViewMode)
                Control_SetState(grcCT_Thue, DataInputState.ViewMode)
                _GridView.OptionsBehavior.Editable = False

                btnAdd.Enabled = True
                'btnModify.Enabled = True
                If GRV_CTH.RowCount = 0 Then
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                Else
                    btnModify.Enabled = True
                    btnDelete.Enabled = True
                End If
                btnCopy.Enabled = True
                btnSave.Enabled = False
                'btnDelete.Enabled = True
                btnPri.Enabled = True
                btnCancel.Enabled = False
                btnHoaDon.Enabled = False
                btnThue.Enabled = False
                btnSearch.Enabled = True
                'CustomViewLog1.Enabled = True

                txtTongSoTien.Properties.ReadOnly = True
                'txtCT_SO.Properties.ReadOnly = True
                txtTongTienThue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                cFilter.ENABLES = False
                cFilterTaiKhoan.ENABLES = False
                cFilterTaiKhoanThue.ENABLES = False
            Case DataInputState.CopyMode
                GRC_CTH.Enabled = False
                navWelding1.Enabled = False
                Control_SetState(grpSMQR, DataInputState.CopyMode)
                Control_SetState(grcCT_Thue, DataInputState.CopyMode)
                _GridView.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
                btnPri.Enabled = False
                btnCancel.Enabled = True
                btnHoaDon.Enabled = True
                btnThue.Enabled = True
                btnCopy.Enabled = False
                btnSearch.Enabled = False
                'CustomViewLog1.Enabled = False
                txtTongSoTien.Properties.ReadOnly = True
                'txtCT_SO.Properties.ReadOnly = True
                txtTongTienThue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True

                cFilter.ENABLES = True
                SetCol(m_HT_LoaiCT_Info)
                cFilterTaiKhoan.ENABLES = True
                cFilterTaiKhoanThue.ENABLES = True
        End Select
    End Sub

    Private Sub XoaTrang()
        Try
            cFilter.Text = ""
            cFilter.Tag = ""
            cFilterTaiKhoan.Text = ""
            cFilterTaiKhoan.Tag = ""
            cFilterTaiKhoanThue.Text = ""
            cFilterTaiKhoanThue.Tag = ""
            UR_Status.Set_Status(1)

            txtDIA_CHI.Text = String.Empty
            txtMST_KHANG.Text = String.Empty
            txtTEN_KHANG.Text = String.Empty
            txtNGUOI_NHAN_NOP_TIEN.Text = String.Empty
            txtDIEN_GIAI.Text = String.Empty

            C_SoChungTu_RP.Text = ""
            C_SoChungTu_RP.PREFIX = ""
            C_SoChungTu_RP.SO_CHUNG_TU = ""

            txtTongSoTien.Text = "0"
            txtTongTienThue.Text = "0"
            txtTongTien.Text = "0"
            cboNgoaiTe.EditValue = Generals.TS_NoiTe_ID.GiaTri
            txtTY_GIA1.Text = "1"
            daeNGAY_GHI.DateTime = DateTime.Now
            daeNGAY_CT.DateTime = DateTime.Now

            _GridControl.DataSource = Nothing
            m_LstCT_DInfo = New List(Of CtD)
            m_LstCT_DInfo.Add(New CtD)
            m_Del_LstCT_DInfo = New List(Of CtD)
            m_LstCT_DInfo_Thue = New List(Of CtD)
            m_TongtienThue = 0
            m_LstCT_ThueInfo = New List(Of CtThue)
            m_Del_LstCT_ThueInfo = New List(Of CtThue)
            m_CTH_ID = Nothing

            _GridControl.DataSource = m_LstCT_DInfo
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub XuLyThue()
        m_TKThue = cFilterTaiKhoanThue.ListEditValue(1)
        m_TKThue_ID = cFilterTaiKhoanThue.ListEditValue(0)
        m_Tongtien = 0
        If txtTongSoTien.Text <> "" Then
            m_Tongtien = Decimal.Parse(txtTongSoTien.Text)
        End If
        Dim frmCT_Thue As frmChungTuThue = CType(ObjectFactory.GetObject("frmChungTuThue"), frmChungTuThue)

        If m_LstCT_DInfo_Thue.Count = 0 Then
            frmCT_Thue.u_lstobj_ct_thue = m_LstCT_ThueInfo
            frmCT_Thue.u_del_lstobj_ct_thue = m_Del_LstCT_ThueInfo
            frmCT_Thue.u_objct_ct_hd = m_CT_HoadonInfo
            If frmCT_Thue.Show_Form(m_CT_HInfo, m_Tongtien, m_TKThue, VnsConvert.CGuid(m_TKThue_ID), Nothing, m_HT_LoaiCT_Info) Then
                If (frmCT_Thue.Duoc_Xac_Nhan) Then
                    m_LstCT_ThueInfo = frmCT_Thue.r_lstobj_ct_thue
                    m_CT_HoadonInfo = frmCT_Thue.r_objct_ct_hd
                    m_Del_LstCT_ThueInfo = frmCT_Thue.r_del_lstobj_ct_thue
                    m_TongtienThue = frmCT_Thue.tongtienthue
                    txtTongTienThue.Text = m_TongtienThue
                    TongSoTien()
                End If
            End If
        Else
            frmCT_Thue.u_lstobj_ct_thue = m_LstCT_ThueInfo
            frmCT_Thue.u_del_lstobj_ct_thue = m_Del_LstCT_ThueInfo
            frmCT_Thue.u_objct_ct_hd = m_CT_HoadonInfo
            If frmCT_Thue.Show_Form(m_CT_HInfo, m_Tongtien, m_TKThue, VnsConvert.CGuid(m_TKThue_ID), m_LstCT_DInfo_Thue(0).Id, m_HT_LoaiCT_Info) Then
                If (frmCT_Thue.Duoc_Xac_Nhan) Then
                    m_LstCT_ThueInfo = frmCT_Thue.r_lstobj_ct_thue
                    m_Del_LstCT_ThueInfo = frmCT_Thue.r_del_lstobj_ct_thue
                    m_TongtienThue = frmCT_Thue.tongtienthue
                    m_CT_HoadonInfo = frmCT_Thue.r_objct_ct_hd
                    txtTongTienThue.Text = m_TongtienThue
                    TongSoTien()
                End If
            End If
        End If
    End Sub

    Private Function ValidateCTD(ByVal lstobj_ct_d As List(Of CtD)) As Boolean
        For Each objctd As CtD In lstobj_ct_d
            If m_HT_CT_Info.PhieuXuat = 1 Then
                If objctd.TkCoId = Null.NullGuid Then
                    Message_Warning("Chưa nhập tài khoản có trong chi tiết định khoản")
                    Return False
                End If
            ElseIf m_HT_CT_Info.PhieuXuat = 0 Then
                If objctd.TkNoId = Null.NullGuid Then
                    Message_Warning("Chưa nhập tài khoản nợ trong chi tiết định khoản")
                    Return False
                End If
            End If
            If objctd.SoTien <= 0 And objctd.SoTien >= Decimal.MaxValue Then
                Message_Warning("Bạn chưa nhập số tiền trong chi tiết định khoản")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub grv_focus()
        Dim lst As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
        lst = GRV_CTH.DataSource
        For i As Integer = 0 To GRV_CTH.RowCount - 1
            If (lst(i).Id = m_CT_HInfo.Id) Then
                GRV_CTH.FocusedRowHandle = i
                lst(i).Ghi = m_CT_HInfo.Ghi
                GRV_CTH.RefreshData()
            End If
        Next
    End Sub

    Private Sub LoadDB()
        m_LstCT_DInfo_Thue = New List(Of CtD)
        m_TongtienThue = 0
        m_LstCT_ThueInfo = New List(Of CtThue)
        m_CT_HoadonInfo = Nothing
        m_Del_LstCT_ThueInfo = New List(Of CtThue)
        SetObjectToControl()
        SetTongTienThue()
        TongSoTien()
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

    Private Function Check_Input() As Boolean

        If String.IsNullOrEmpty(DB_GetString(DB_GetNull(daeNGAY_CT.DateTime))) Then
            Message_Warning("Bạn chưa nhập ngày chứng từ!")
            daeNGAY_CT.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(DB_GetString(DB_GetNull(daeNGAY_GHI.DateTime))) Then
            Message_Warning("Bạn chưa nhập ngày HT !")
            daeNGAY_GHI.Focus()
            Return False
        End If

        If daeNGAY_GHI.DateTime.Date > daeNGAY_CT.DateTime.Date Then
            Message_Warning("Ngày hoạch toán <= ngày chứng từ!")
            daeNGAY_GHI.Focus()
            Return False
        End If

        'If m_HT_CT_Info IsNot Nothing Then
        '    If m_HT_CT_Info.KY_HIEU = "1" Then
        '        If String.IsNullOrEmpty(cFilter.Tag) Then
        '            Message_Warning("Bạn chưa nhập khách hàng!")
        '            cFilter.Focus()
        '            Return False
        '        End If
        '    Else
        '        For Each obj_ctd As CT_DInfo In m_LstCT_DInfo
        '            If String.IsNullOrEmpty(obj_ctd.ID_KHANG_CO) Then
        '                Message_Warning("Chi tiết định khoản chưa nhập đủ!")
        '                Return False
        '            End If
        '        Next
        '    End If
        'End If

        If _GridView.RowCount = 0 Then
            Message_Warning("Bạn chưa nhập định khoản!")
            Return False
        End If

        If cFilterTaiKhoanThue.Tag = Nothing Then
            If cFilterTaiKhoanThue.Text <> "" Then
                Message_Warning("Giá trị tài khoản thuế không hợp lệ!")
                Return False
            End If
        End If

        If cFilterTaiKhoan.Tag = Nothing Then
            Message_Warning("Bạn chưa nhập " + lblTaikhoan.Text + "!")
            cFilterTaiKhoan.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Refresh_Data(ByVal i As Integer, ByVal ColumnName As String)
        Dim gridctd As CtD = CType(_GridView.GetRow(i), CtD)
        Select Case ColumnName
            Case "MaTkNo"
                'Dim cbotaikhoan As DM_TaikhoanInfo = CType(cboTaiKhoanNo.GetDataSourceRowByKeyValue(gridctd.MA_TK_NO),  _
                '                                            DM_TaikhoanInfo)
                Dim rowTK As DataRow = DataHelper.GetDataRowByKey(m_TK_DATA_SOURCE, "MaTaikhoan", gridctd.MaTkNo)
                If (gridctd Is Nothing) Then
                    Return
                End If
                'Gan vao GridView
                If Not rowTK Is Nothing Then
                    gridctd.TenTkNo = rowTK("TenTaikhoan").ToString
                    gridctd.TkNoId = VnsConvert.CGuid((rowTK("Id").ToString))
                    gridctd.MaTkNo = rowTK("MaTaikhoan").ToString
                End If


            Case "MaTkCo"
                'Dim cbotaikhoan As DM_TaikhoanInfo = CType(cboTaiKhoanCo.GetDataSourceRowByKeyValue(gridctd.MA_TK_CO),  _
                '                                            DM_TaikhoanInfo)
                Dim rowTK As DataRow = DataHelper.GetDataRowByKey(m_TK_DATA_SOURCE, "MaTaikhoan", gridctd.MaTkCo)
                If (gridctd Is Nothing) Then
                    Return
                End If
                'Gan vao GridView
                If Not rowTK Is Nothing Then
                    gridctd.TenTkCo = rowTK("TenTaikhoan").ToString
                    gridctd.TkCoId = VnsConvert.CGuid((rowTK("Id").ToString))
                    gridctd.MaTkCo = rowTK("MaTaikhoan").ToString
                End If
            Case "MaVuviecCo"
                Dim cbovu_viec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctd.IdDmVuviecCo),  _
                                                         DmVuviec)
                gridctd.IdDmVuviecCo = cbovu_viec.Id
                gridctd.MaVuviecCo = cbovu_viec.MaVuviec
                gridctd.KyHieuVuviecCo = cbovu_viec.KyHieu
            Case "IdDmPtqtCo"
                Dim cboPTQT As DmPtqt = CType(cboPPQT.GetDataSourceRowByKeyValue(gridctd.IdDmPtqtCo), DmPtqt)
                gridctd.IdDmPtqtCo = cboPTQT.Id
                gridctd.IdDmPtqtNo = cboPTQT.Id
        End Select
    End Sub

    Private Function BindTaiKhoan(ByVal tklienquan As String) As List(Of DmTaikhoan)
        Dim ListTK As List(Of DmTaikhoan) = _
                _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
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

        For Each matk As String In tkFilter.Split(New Char() {";"c})
            Dim stw As String = matk
            ListTKFilter.AddRange(From i As DmTaikhoan In ListTK _
                                      Where i.MaTaikhoan.StartsWith(stw) _
                                      Select i)
        Next

        If ListTKFilter.Count > 0 Then
            Return ListTKFilter
        Else
            Return ListTK
        End If
    End Function

    Private Sub Bind_PPTT(ByVal TK_LQ_NO As String)
        Dim lstPPQT As List(Of DmPtqt) = _
                _DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id)
        cboPPQT.Columns.Clear()
        cboPPQT.DataSource = RefreshPPQT(lstPPQT, TK_LQ_NO)
        cboPPQT.DisplayMember = "KyHieu"
        cboPPQT.ValueMember = "Id"
        cboPPQT.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã PTQT"))
        cboPPQT.Columns.Add(New LookUpColumnInfo("TenPtqt", "Tên PTQT"))
    End Sub

    Private Sub Bind_TD1(ByVal TK_LQ_NO As String)
        Dim lstTD1 As List(Of DmTudo1) = _
                _DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboDMTudo1.Columns.Clear()
        cboDMTudo1.DataSource = RefreshTD1(lstTD1, TK_LQ_NO)
        cboDMTudo1.DisplayMember = "KyHieu"
        cboDMTudo1.ValueMember = "Id"
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục"))
    End Sub

    Private Sub Bind_TD2(ByVal TK_LQ_NO As String)
        Dim lstTD2 As List(Of DmTudo2) = _
                _DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboDMTudo2.Columns.Clear()
        cboDMTudo2.DataSource = RefreshTD2(lstTD2, TK_LQ_NO)
        cboDMTudo2.DisplayMember = "KyHieu"
        cboDMTudo2.ValueMember = "Id"
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("TenDmTudo2", "Tên danh mục"))
    End Sub

    Private Sub Bind_TD3(ByVal TK_LQ_NO As String)
        Dim lstTD3 As List(Of DmTudo3) = _
                _DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboDMTudo3.Columns.Clear()
        cboDMTudo3.DataSource = RefreshTD3(lstTD3, TK_LQ_NO)
        cboDMTudo3.DisplayMember = "KyHieu"
        cboDMTudo3.ValueMember = "Id"
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("TenDmTudo3", "Tên danh mục"))
    End Sub

    Private Sub Bind_TD4(ByVal TK_LQ_NO As String)
        Dim lstTD4 As List(Of DmTudo4) = _
                _DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboDMTudo4.Columns.Clear()
        cboDMTudo4.DataSource = RefreshTD4(lstTD4, TK_LQ_NO)
        cboDMTudo4.DisplayMember = "KyHieu"
        cboDMTudo4.ValueMember = "Id"
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("TenDmTudo4", "Tên danh mục"))
    End Sub

    Private Sub Bind_TD5(ByVal TK_LQ_NO As String)
        Dim lstTD5 As List(Of DmTudo5) = _
                _DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboDMTudo5.Columns.Clear()
        cboDMTudo5.DataSource = RefreshTD5(lstTD5, TK_LQ_NO)
        cboDMTudo5.DisplayMember = "KyHieu"
        cboDMTudo5.ValueMember = "Id"
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("TenDmTudo5", "Tên danh mục"))
    End Sub

    Private Sub Bind_VuViec(ByVal TK_LQ_NO As String)
        Dim lstVuViec As List(Of DmVuviec) = _
                _DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstVuViec_temp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim obj_vv As DmVuviec = New DmVuviec
        lstVuViec_temp.Add(obj_vv)
        lstVuViec_temp.AddRange(lstVuViec)
        cboVuViec.Columns.Clear()
        cboVuViec.DataSource = RefreshVuviec(lstVuViec_temp, TK_LQ_NO)
        cboVuViec.DisplayMember = "KyHieu"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))
    End Sub

    Private Sub Bind_KhoanPhi(ByVal TK_LQ_NO As String)
        Dim lstKhoanPhi As List(Of DmKhoanphi) = _DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKhoanPhi.Columns.Clear()
        cboKhoanPhi.DataSource = RefreshKhoanphi(lstKhoanPhi, TK_LQ_NO)
        cboKhoanPhi.DisplayMember = "KyHieu"
        cboKhoanPhi.ValueMember = "Id"
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("MaDmKhoanphi", "Mã khoản phí"))
        cboKhoanPhi.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))
    End Sub

    Private Function RefreshPPQT(ByVal lstPPQT As List(Of DmPtqt), ByVal TK_LQ_NO As String) _
        As List(Of DmPtqt)
        Dim listDM_PtqtInfo As List(Of DmPtqt) = New List(Of DmPtqt)

        For Each item As DmPtqt In lstPPQT

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                listDM_PtqtInfo.Add(item)
            End If
        Next

        If listDM_PtqtInfo.Count = 0 Then
            Return lstPPQT
        Else
            Return listDM_PtqtInfo
        End If
    End Function

    Private Function RefreshTD1(ByVal lstTD1 As List(Of DmTudo1), ByVal TK_LQ_NO As String) _
        As List(Of DmTudo1)
        Dim ls As List(Of DmTudo1) = New List(Of DmTudo1)

        For Each item As DmTudo1 In lstTD1

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstTD1
        Else
            Return ls
        End If
    End Function

    Private Function RefreshTD2(ByVal lstTD2 As List(Of DmTudo2), ByVal TK_LQ_NO As String) _
        As List(Of DmTudo2)
        Dim ls As List(Of DmTudo2) = New List(Of DmTudo2)

        For Each item As DmTudo2 In lstTD2

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstTD2
        Else
            Return ls
        End If
    End Function

    Private Function RefreshTD3(ByVal lstTD3 As List(Of DmTudo3), ByVal TK_LQ_NO As String) _
        As List(Of DmTudo3)
        Dim ls As List(Of DmTudo3) = New List(Of DmTudo3)

        For Each item As DmTudo3 In lstTD3

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstTD3
        Else
            Return ls
        End If
    End Function

    Private Function RefreshTD4(ByVal lstTD4 As List(Of DmTudo4), ByVal TK_LQ_NO As String) _
        As List(Of DmTudo4)
        Dim ls As List(Of DmTudo4) = New List(Of DmTudo4)

        For Each item As DmTudo4 In lstTD4

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstTD4
        Else
            Return ls
        End If
    End Function

    Private Function RefreshTD5(ByVal lstTD5 As List(Of DmTudo5), ByVal TK_LQ_NO As String) _
        As List(Of DmTudo5)
        Dim ls As List(Of DmTudo5) = New List(Of DmTudo5)

        For Each item As DmTudo5 In lstTD5

            Dim matks As String() = item.MaTk.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstTD5
        Else
            Return ls
        End If
    End Function

    Private Function RefreshVuviec(ByVal lstVuviec As List(Of DmVuviec), ByVal TK_LQ_NO As String) _
        As List(Of DmVuviec)
        Dim ls As List(Of DmVuviec) = New List(Of DmVuviec)

        For Each item As DmVuviec In lstVuviec

            Dim matks As String() = item.MaTkLienquan.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstVuviec
        Else
            Return ls
        End If
    End Function

    Private Function RefreshKhoanphi(ByVal lstKhoanphi As List(Of DmKhoanphi), ByVal TK_LQ_NO As String) _
        As List(Of DmKhoanphi)
        Dim ls As List(Of DmKhoanphi) = New List(Of DmKhoanphi)

        For Each item As DmKhoanphi In lstKhoanphi

            Dim matks As String() = item.MatkLienquan.Split(New Char() {";"c})
            Dim count As Integer = (From i As String In matks Where i.StartsWith(Convert.ToString(TK_LQ_NO))).Count

            If count > 0 Then
                ls.Add(item)
            End If
        Next

        If ls.Count = 0 Then
            Return lstKhoanphi
        Else
            Return ls
        End If
    End Function
#End Region

#Region "Events"
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            AddHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            Me.ValidateChildren()
            'Check trang thai ct
            If Not UR_Status.ChoPhepSuaCT Then
                'Message_Warning(msgTTChungTu)
                'Return
            End If

            If m_CT_HInfo Is Nothing Then
                m_CT_HInfo = New CtH
            End If

            'Check khoa so thang
            If m_CT_HInfo.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If
            If _KtKhoasoThangService.KiemTraKhoaSo(daeNGAY_CT.DateTime, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            If Not Check_Input() Then
                Return
            End If

            If Not ValidateCTD(m_LstCT_DInfo) Then
                'Message_Warning("Chi tiết định khoản chưa nhập đủ")
                Exit Sub
            End If

            If Not (KiemTraDuLieuTKChiTiet()) Then
                Return
            End If

            If Not check_NumberInput() Then
                Return
            End If

            If m_HT_CT_Info.SdTkThueNgamdinh = 1 Then
                If Not Check_Tien_Thue() Then
                    Return
                End If
            End If

            frmProgress.Instance.Thread = AddressOf SaveData
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            'Refresh left grid
            m_CTH_ID = m_CT_HInfo.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(m_CT_HInfo)
            GridHelper.RefreshLeftGrid(GRV_CTH, m_LstCT_H_GInfo, editObject, m_InputState)

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()

            btnAdd.Focus()
            grv_focus()
            RemoveHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuit.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub grlLOAI_CT_ID_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grlLOAI_CT_ID.EditValueChanged
        Try
            'Search lookup
            m_HT_CT_Info = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            m_HT_LoaiCT_Info = m_HT_CT_Info

            If (m_HT_CT_Info Is Nothing) Then
                Return
            Else
                'Dim flag As Boolean
                If m_HT_CT_Info.DmHoadon = 1 Then
                    m_chk_Hoadon = True
                Else
                    m_chk_Hoadon = False
                End If
                Check_ColHoaDon(m_chk_Hoadon)
                ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_HT_CT_Info.MaLoaiCt, _GridView.Name, _GridView)
                m_LstTKLQ_Info.Clear()
                SetCol(m_HT_LoaiCT_Info)
                'Khai bao loai tai khoan
                Dim tklienquan As String = Nothing
                'Khai bao tk_lq voi loai chung tu tuong ung
                Dim tk_lq_no As String = Nothing
                Dim tk_lq_co As String = Nothing
                Dim tk_lq_thue As String = Nothing

                ''Kiem tra ma chung thu
                If m_HT_CT_Info.PhieuXuat = 1 Then
                    tklienquan = m_HT_CT_Info.MaTkNoLq
                    lblTaikhoan.Text = "Tài khoản nợ"
                    _GridView.Columns("MaTkNo").Visible = False
                    _GridView.Columns("TenTkNo").Visible = False
                    _GridView.Columns("MaTkCo").Visible = True
                    _GridView.Columns("TenTkCo").Visible = True
                ElseIf m_HT_CT_Info.PhieuXuat = 0 Then
                    tklienquan = m_HT_CT_Info.MaTkCoLq
                    lblTaikhoan.Text = "Tài khoản có"
                    _GridView.Columns("MaTkCo").Visible = False
                    _GridView.Columns("TenTkCo").Visible = False
                    _GridView.Columns("MaTkNo").Visible = True
                    _GridView.Columns("TenTkNo").Visible = True
                End If

                cFilterTaiKhoan.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tklienquan)
                tk_lq_thue = m_HT_CT_Info.TkThueNgamdinh
                If Not tk_lq_thue Is Nothing Or Not tk_lq_thue = String.Empty Then
                    cFilterTaiKhoanThue.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_thue)
                End If

                'Bind data trong grid tuy theo tk lien quan no hay co
                tk_lq_no = m_HT_CT_Info.MaTkNoLq
                tk_lq_co = m_HT_CT_Info.MaTkCoLq

                If Not tk_lq_no Is Nothing Or Not tk_lq_no = String.Empty Then
                    MyRepositoryItem_MA_TK_NO.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_no)
                End If

                If Not tk_lq_co Is Nothing Or Not tk_lq_co = String.Empty Then
                    MyRepositoryItem_MA_TK_CO.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_co)
                End If

                _GridView.RefreshData()

            End If

            SetMaTk()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _GridView.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(_GridView)) Then
                        ThemDong()
                    End If
                Case Keys.F12
                    Dim FormID As String = Me.Name + "?" + "MA_LOAI_CT=" + m_HT_LoaiCT_Info.MaLoaiCt
                    Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                    ConfigGrid.GetGridColInfo(_GridView, lstColInfo)
                    Dim f As New ConfigGrid
                    If f.Show_Form(_GridView.Name, FormID, lstColInfo) Then
                        ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)

                        m_HT_CT_Info = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
                        If (m_HT_CT_Info Is Nothing) Then
                            Return
                        Else
                            SetCol(m_HT_CT_Info)
                        End If
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles _GridView.CellValueChanged
        Try
            Dim gridctd As CtD = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtD)
            If gridctd Is Nothing Then
                Return
            End If
            Try
                Select Case e.Column.Name
                    Case "MaVuviecCo"
                        Dim cbovu_viec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctd.IdDmVuviecCo),  _
                                                                 DmVuviec)
                        gridctd.IdDmVuviecCo = cbovu_viec.Id
                        gridctd.MaVuviecCo = cbovu_viec.MaVuviec
                        gridctd.KyHieuVuviecCo = cbovu_viec.KyHieu
                    Case "IdDmPtqtCo"
                        Dim cboPTQT As DmPtqt = CType(cboPPQT.GetDataSourceRowByKeyValue(gridctd.IdDmPtqtCo),  _
                                                            DmPtqt)
                        gridctd.IdDmPtqtCo = cboPTQT.Id
                        gridctd.IdDmPtqtNo = cboPTQT.Id
                    Case "SoTienNte"
                        Dim so_tien_nt As Decimal = _GridView.GetRowCellValue(_GridView.FocusedRowHandle, "SoTienNte")
                        Dim tygia As Decimal = Convert.ToDecimal(txtTY_GIA1.Text.Trim())
                        _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "SoTien", Math.Round(so_tien_nt * tygia))
                End Select
                TongSoTien()
            Catch ex As OverflowException
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                gridctd.SoTienNte = 0
                gridctd.SoTien = 0
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmCT_H_ChiTiet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
                    Exit Select
                Case Keys.F4
                    If m_InputState = DataInputState.EditMode Or m_InputState = DataInputState.AddMode Or m_InputState = DataInputState.CopyMode Then
                        ThemDong()
                    End If
                    Exit Select
                Case Keys.F8
                    If m_InputState = DataInputState.EditMode Or m_InputState = DataInputState.AddMode Or m_InputState = DataInputState.CopyMode Then
                        If _GridView.RowCount > 0 Then
                            DeleteRow()
                            TongSoTien()
                        Else
                            Message_Warning("Không có bản ghi nào được chọn")
                        End If
                    End If
                    Exit Select
                Case e.Control And Keys.F11

            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnInCTu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            Dim obj_form = CType(ObjectFactory.GetObject("frmPhieu_Input", New Object() {m_CTH_ID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnChiTietThue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThue.Click
        Try
            If _GridView.RowCount = 0 Then
                Message_Warning("Định khoản không được để trống!")
                Return
            End If
            If (cFilterTaiKhoanThue.Tag = Nothing) Then
                Message_Warning("Chưa chọn tài khoản thuế")
                Return
            End If
            Dim g As Guid = VnsConvert.CGuid(cFilterTaiKhoanThue.Tag.ToString())
            If Not (g = Null.NullGuid) Then
                GetCTHToObj()
                TongSoTien()
                XuLyThue()
            Else
                Message_Warning("Chưa chọn tài khoản thuế")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkHDGTGT_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles chkHDGTGT.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmCT_H_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("IdDmTudo1Co").Caption = Generals.TS_TuDo1.GiaTri
            _GridView.Columns("IdDmTudo2Co").Caption = Generals.TS_TuDo2.GiaTri
            _GridView.Columns("IdDmTudo3Co").Caption = Generals.TS_TuDo3.GiaTri
            _GridView.Columns("IdDmTudo4Co").Caption = Generals.TS_TuDo4.GiaTri
            _GridView.Columns("IdDmTudo5Co").Caption = Generals.TS_TuDo5.GiaTri

            If m_HT_CT_Info.SdTkThueNgamdinh = 0 Then
                cFilterTaiKhoanThue.Visible = False
                btnThue.Visible = False
                lblTkThue.Visible = False
                lblTongTienThue.Visible = False
                txtTongTienThue.Visible = False
                txtTongTien.Visible = False
                lblTongTien.Visible = False

            ElseIf m_HT_CT_Info.SdTkThueNgamdinh = 1 Then
                cFilterTaiKhoanThue.Visible = True
                btnThue.Visible = True
                lblTkThue.Visible = True
                lblTongTienThue.Visible = True
                txtTongTienThue.Visible = True
                txtTongTien.Visible = True
                lblTongTien.Visible = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub daeNGAY_CT_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles daeNGAY_CT.EditValueChanged
        Try
            daeNGAY_GHI.DateTime = daeNGAY_CT.DateTime
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnHoaDon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHoaDon.Click
        'Try
        '    Dim f As New frmPhanBoSoTien_ChiTiet
        '    f.Show_Form()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnCan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Try
            _GridView.HideEditor()
            If m_LstCT_H_GInfo.Count <> 0 Then
                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = m_LstCT_H_GInfo(m_LstCT_H_GInfo.Count - 1).Id
                    GRV_CTH.FocusedRowHandle = m_LstCT_H_GInfo.Count - 1
                End If
                LoadDB()
                SetMaTk()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If
            DatTrangThaiControl()

            If m_HT_CT_Info.KyHieu = "2" Then
                cFilter.ENABLES = False
            End If
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            FlagDG = 0
            m_CT_HInfo = New CtH
            m_CT_HoadonInfo = New CtHoadon
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            XoaTrang()
            grlLOAI_CT_ID.Focus()
            TNCommon.SelectFirst(grlLOAI_CT_ID)
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnRow_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ThemDong()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDeR_Click(ByVal sender As Object, ByVal e As EventArgs)
        DeleteRow()
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        Try
            m_InputState = DataInputState.EditMode

            DatTrangThaiControl()

            SetMaKhachHangByLoaiCT(m_HT_LoaiCT_Info)

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetMaKhachHangByLoaiCT(ByVal _ht_loaichungtu As HtLoaichungtu)
        If (m_InputState = DataInputState.ViewMode) Then
        Else
            If (_ht_loaichungtu.DmKhang = 1) Then
                cFilter.ENABLES = False
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            If Not UR_Status.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If

            'Check kho'a so? tha'ng
            If m_CT_HInfo.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            Dim currentStatus As DataInputState = m_InputState
            If m_LstCT_H_GInfo.Count > 0 Then
                If Not (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
                    Exit Sub
                End If

                'Xóa CT_H
                _CtHService.DeleteChungTuCTH(m_CT_HInfo, m_LstCT_DInfo, m_CT_HoadonInfo)
                'Xoa CT_HOADON
                'If m_CT_HoadonInfo IsNot Nothing Then
                '    '_CtThueService.DeleteByHoaDon(m_CT_HoadonInfo.Id)
                '    _CtHoadonService.Delete(m_CT_HoadonInfo)
                'End If

                m_CTH_ID = Vns.Erp.Core.Accounting.VbAccountingGUI.GridHelper.RemoveLeftGrid(m_LstCT_H_GInfo, m_CTH_ID)
                RemoveHandler GRV_CTH.FocusedRowChanged, AddressOf GRV_CTH_FocusedRowChanged
                GRV_CTH.RefreshData()
                AddHandler GRV_CTH.FocusedRowChanged, AddressOf GRV_CTH_FocusedRowChanged
                If Not (m_CTH_ID = Null.NullGuid) Then
                    LoadDB()
                End If

                m_InputState = currentStatus
            End If

            If m_LstCT_H_GInfo.Count = 0 Then
                XoaTrang()
                m_InputState = DataInputState.AddMode
                GRC_CTH.DataSource = Nothing
            End If

            TNCommon.SelectFirst(grlLOAI_CT_ID)

            DatTrangThaiControl()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If m_InputState = DataInputState.EditMode Then
                If m_CT_HInfo.MaLoaiCt IsNot Nothing Then
                    m_HT_CT_Info = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
                End If

                If (m_HT_CT_Info Is Nothing) Then Return

                If _GridView.RowCount > 0 Then
                    Dim gridctd As CtD = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtD)
                    Dim MA_TK As String
                    If m_HT_CT_Info.PhieuXuat = 0 Then
                        MA_TK = gridctd.MaTkCo
                    Else
                        MA_TK = gridctd.MaTkNo
                    End If
                    Bind_DanhMuc(MA_TK)
                End If

            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Try
            Dim frmSearchCT As frmTimKiemChungTuKeToan = CType(ObjectFactory.GetObject("frmTimKiemChungTuKeToan"), frmTimKiemChungTuKeToan)

            Dim m_LstCT_H_GInfo_temp As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)

            Dim tmploaict As HtLoaichungtu = ComboHelper.GetSelectData(grlLOAI_CT_ID)
            m_LstCT_H_GInfo_temp = frmSearchCT.Show_Form(tmploaict.MaLoaiCt)

            If m_LstCT_H_GInfo_temp Is Nothing Then
                Return
            End If

            m_LstCT_H_GInfo = m_LstCT_H_GInfo_temp
            If m_LstCT_H_GInfo.Count > 0 Then
                m_CTH_ID = m_LstCT_H_GInfo(0).Id
                Load_Grid(m_LstCT_H_GInfo)
                SetObjectToControl()
                SetTongTienThue()
                TongSoTien()
            End If
            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmCT_H_ChiTiet_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = DialogResult.OK
    End Sub

    Private Sub GRV_CTH_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Try
            If GRV_CTH.RowCount = 0 Then
                Return
            End If

            If (m_InputState = DataInputState.AddMode Or m_InputState = DataInputState.CopyMode Or m_InputState = DataInputState.EditMode) And (btnModify.Enabled = False) Then
                Return
            Else
                If GetRowSelect() Then
                    LoadDB()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ' check validate tren luoi    
    Private Sub _GridView_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles _GridView.ValidatingEditor
        Try
            If _GridView.FocusedColumn.Name <> "MaTkNo" And _GridView.FocusedColumn.Name <> "MaTkCo" Then Exit Sub

            If String.IsNullOrEmpty(DB_GetString(e.Value)) Then
                Return
            End If

            If (e.Value = cFilterTaiKhoan.ListEditValue(1)) Then
                e.Valid = False
                e.ErrorText = "Tài khoản có và tài khoản nợ không được giống nhau"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboNgoaiTe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNgoaiTe.EditValueChanged
        Try
            SetColNgoaiTe()
            If Not (m_OnLoadData) Then
                txtTY_GIA1.Text = _LsTygiaService.GetTyGiaNgoaiTe(VnsConvert.CGuid(cboNgoaiTe.EditValue.ToString()), CType(daeNGAY_CT.EditValue, DateTime))
            End If
            txtTY_GIA_TextChanged(txtTY_GIA1, e)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            m_InputState = DataInputState.CopyMode

            DatTrangThaiControl()

            m_CT_HInfo.DaKhoaSo = 0
            txtTongTienThue.Text = 0
            'grlTaiKhoanThue.EditValue = Nothing
            cFilterTaiKhoanThue.Text = ""
            cFilterTaiKhoanThue.Tag = ""
            m_Del_LstCT_DInfo = New List(Of CtD)
            m_LstCT_DInfo_Thue = New List(Of CtD)
            m_TongtienThue = 0
            m_LstCT_ThueInfo = New List(Of CtThue)
            m_Del_LstCT_ThueInfo = New List(Of CtThue)
            C_SoChungTu_RP.Text = ""
            TongSoTien()
            UR_Status.Enabled = True
            UR_Status.selectFirst()
            'gán lại giá trị originEntity
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA1.TextChanged
        Try
            If DB_GetString(cboNgoaiTe.EditValue) <> Generals.TS_NoiTe_ID.GiaTri Then
                Dim ty_gia As String = txtTY_GIA1.Text.Trim()

                If String.IsNullOrEmpty(ty_gia) Then
                    Return
                End If
                Try
                    For Each ctDInfo As CtD In m_LstCT_DInfo
                        ctDInfo.SoTien = Math.Round(Convert.ToDecimal(ty_gia) * ctDInfo.SoTienNte)
                    Next
                Catch ex As OverflowException
                    Message_Warning("Giá trị số tiền nhập vào không hợp lệ")
                    txtTY_GIA1.Text = 1
                End Try
            Else
                For Each ctDInfo As CtD In m_LstCT_DInfo
                    ctDInfo.SoTienNte = 0
                Next
                'txtTY_GIA1.Text = "1"
            End If
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        TongSoTien()
    End Sub
#End Region

#Region "UserControl Handles"
    Private Sub SavingMemory(ByVal _option As Integer)
        If _option = 1 Then 'TK
            If m_TK_DATA_SOURCE Is Nothing Then
                m_TK_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 2 Then 'KHANG
            If m_KHANG_DATA_SOURCE Is Nothing Then
                m_KHANG_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 3 Then 'CT_HOADON
            If m_CT_HOADON_DATA_SOURCE Is Nothing Then
                m_CT_HOADON_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 10 Then 'ALL
            If m_TK_DATA_SOURCE Is Nothing Then
                m_TK_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If m_KHANG_DATA_SOURCE Is Nothing Then
                m_KHANG_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If m_CT_HOADON_DATA_SOURCE Is Nothing Then
                m_CT_HOADON_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        End If
    End Sub

    Private Sub SavingMemoryForRepository(ByVal colName As String)
        Select Case colName
            Case "MaTkNo"
                If MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If m_TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = m_TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_NO.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE
                End If
            Case "MaTkCo"
                If MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If m_TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = m_TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_CO.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE
                End If
            Case "KyHieuKhangCo"
                If MyRepositoryItem_KY_HIEU_KHANG_CO.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If m_KHANG_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_KY_HIEU_KHANG_CO.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_KY_HIEU_KHANG_CO.C_DATA_SOURCE = m_KHANG_DATA_SOURCE
                    End If
                    MyRepositoryItem_KY_HIEU_KHANG_CO.Editors.A_DATA_SOURCE = MyRepositoryItem_KY_HIEU_KHANG_CO.C_DATA_SOURCE
                End If
            Case "MaHoadon"
                If MyRepositoryItem_MA_HOADON.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If m_CT_HOADON_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_HOADON.C_DATA_SOURCE = DataHelper.ToDataTable(_CtHoadonService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_HOADON.C_DATA_SOURCE = m_CT_HOADON_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_HOADON.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_HOADON.C_DATA_SOURCE
                End If
            Case Else
        End Select
    End Sub

    'REPOSITORY IN GRID
    Private Sub MyRepositoryItem_FirstBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles MyRepositoryItem_MA_TK_NO.FisrtBinddata, MyRepositoryItem_MA_TK_CO.FisrtBinddata, MyRepositoryItem_KY_HIEU_KHANG_CO.FisrtBinddata, MyRepositoryItem_MA_HOADON.FisrtBinddata
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            SavingMemoryForRepository(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles MyRepositoryItem_MA_TK_NO.AfterFilter, MyRepositoryItem_MA_TK_CO.AfterFilter, MyRepositoryItem_KY_HIEU_KHANG_CO.AfterFilter, MyRepositoryItem_MA_HOADON.AfterFilter
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            Dim objCtd As CtD = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtD)
            Select Case columnName
                Case "MaTkNo"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_NO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) AndAlso (MyRepositoryItem_MA_TK_NO.OwnerEdit.A_USER_CHOISE_OK = True) Then
                        objCtd.TkNoId = VnsConvert.CGuid(arr(0))
                        objCtd.MaTkNo = arr(1)
                        objCtd.TenTkNo = arr(2)
                        _GridView.SetRowCellValue(rowHandle, "MaTkNo", arr(1))
                    End If

                    'Dim value1 As String = ""
                    'Dim value2 As String = ""
                    'Try
                    '    value1 = _GridView.GetRowCellValue(rowHandle, "MA_TK_NO").ToString
                    '    value2 = _GridView.GetRowCellValue(rowHandle, "TEN_TK_NO").ToString
                    'Catch
                    'End Try
                    'If (arr.Count > 1) AndAlso (MyRepositoryItem_MA_TK_NO.OwnerEdit.A_USER_CHOISE_OK = True) Then
                    '    _GridView.SetRowCellValue(rowHandle, "MA_TK_NO", arr(1))
                    '    _GridView.SetRowCellValue(rowHandle, "TEN_TK_NO", arr(2))
                    '    SendKeys.Send("{TAB}")
                    'ElseIf MyRepositoryItem_MA_TK_NO.OwnerEdit.A_USER_CHOISE_OK = False Then
                    '    _GridView.SetRowCellValue(rowHandle, "MA_TK_NO", value1)
                    '    _GridView.SetRowCellValue(rowHandle, "TEN_TK_NO", value2)
                    '    SendKeys.Send("{TAB}")
                    'End If
                Case "MaTkCo"

                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_CO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) AndAlso (MyRepositoryItem_MA_TK_CO.OwnerEdit.A_USER_CHOISE_OK = True) Then
                        objCtd.TkCoId = VnsConvert.CGuid(arr(0))
                        objCtd.MaTkCo = arr(1)
                        objCtd.TenTkCo = arr(2)
                        _GridView.SetRowCellValue(rowHandle, "MaTkCo", arr(1))
                    End If
                Case "KyHieuKhangCo"
                    Dim arr As List(Of String) = MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) AndAlso (MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_USER_CHOISE_OK = True) Then
                        objCtd.IdKhangCo = VnsConvert.CGuid(arr(0))
                        objCtd.TenKhangCo = arr(1)
                        objCtd.KyHieuKhangCo = arr(3)
                        objCtd.MaKhangCo = arr(2)
                        _GridView.SetRowCellValue(rowHandle, "KyHieuKhangCo", arr(3))
                    End If
                Case "MaHoadon"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_HOADON.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) AndAlso (MyRepositoryItem_MA_HOADON.OwnerEdit.A_USER_CHOISE_OK = True) Then
                        objCtd.MaHoadon = arr(1)
                        objCtd.IdDoituongHoadon = VnsConvert.CGuid(arr(0))
                        objCtd.KyHieuHoadon = arr(2)
                        _GridView.SetRowCellValue(rowHandle, "MaHoadon", arr(1))
                    End If
                Case Else
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'KHANG
    Private Sub cFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.FirstBinddata
        SavingMemory(2)
        cFilter.C_DATA_SOURCE = m_KHANG_DATA_SOURCE
    End Sub

    Private Sub cFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterFilter
        txtMST_KHANG.Text = cFilter.ListEditValue(4)
        txtTEN_KHANG.Text = cFilter.ListEditValue(1)
        txtDIA_CHI.Text = cFilter.ListEditValue(5)
        cFilter.Tag = VnsConvert.CGuid(cFilter.ListEditValue(0))
        If cFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cFilter_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterQuickAdd
        cFilter.C_DATA_SOURCE = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
    End Sub

    Private Sub cFilter_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.ClearFilterData
        Try
            txtMST_KHANG.Text = cFilter.ListEditValue(4)
            txtTEN_KHANG.Text = cFilter.ListEditValue(1)
            txtDIA_CHI.Text = cFilter.ListEditValue(5)
            cFilter.Tag = VnsConvert.CGuid(cFilter.ListEditValue(0))
            cFilter.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'TK
    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            SavingMemory(1)
            cFilterTaiKhoan.C_DATA_SOURCE = m_TK_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        If cFilterTaiKhoan.Text IsNot Nothing Then
            RemoveHandler _GridView.CellValueChanged, AddressOf _GridView_CellValueChanged
            For i As Integer = 0 To _GridView.RowCount - 1
                If m_HT_CT_Info.PhieuXuat = 1 Then
                    _GridView.SetRowCellValue(i, "MaTkNo", cFilterTaiKhoan.ListEditValue(1))
                    Refresh_Data(i, "MaTkNo")
                ElseIf m_HT_CT_Info.PhieuXuat = 0 Then
                    _GridView.SetRowCellValue(i, "MaTkCo", cFilterTaiKhoan.ListEditValue(1))
                    Refresh_Data(i, "MaTkCo")
                End If
            Next
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
            _GridView.RefreshData()
            AddHandler _GridView.CellValueChanged, AddressOf _GridView_CellValueChanged
        End If
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData
        Try
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            cFilterTaiKhoan.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterQuickAdd
        cFilterTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
    End Sub

    'TK THUE
    Private Sub cFilterTaiKhoanThue_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.FirstBinddata
        Try
            SavingMemory(1)
            cFilterTaiKhoanThue.C_DATA_SOURCE = m_TK_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_KY_HIEU_KHANG_CO.AfterQuickAdd
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            SavingMemoryForRepository(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoanThue_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.AfterFilter
        Try
            m_TKThue = cFilterTaiKhoanThue.ListEditValue(1)
            m_TKThue_ID = cFilterTaiKhoanThue.ListEditValue(0)
            cFilterTaiKhoanThue.Tag = cFilterTaiKhoanThue.ListEditValue(0)

            'Xu ly cho trường hợp người dùng xóa tài khoản thuế này và điền tài khoản thuế khác
            Dim Tien_thue As Decimal = 0
            If m_LstCT_ThueInfo IsNot Nothing Then
                If m_LstCT_ThueInfo.Count > 0 Then
                    For Each obj As CtThue In m_LstCT_ThueInfo
                        Tien_thue = Tien_thue + obj.SoTien
                    Next
                End If
            End If
            txtTongTienThue.Text = Tien_thue.ToString
            If Not String.IsNullOrEmpty(txtTongSoTien.Text) Then
                txtTongTien.Text = (Decimal.Parse(txtTongSoTien.Text) + Tien_thue).ToString
            Else
                txtTongTien.Text = Tien_thue.ToString
            End If
            If cFilterTaiKhoanThue.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoanThue_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.ClearFilterData
        Try
            cFilterTaiKhoanThue.Tag = Null.NullGuid
            cFilterTaiKhoanThue.Text = ""
            txtTongTienThue.Text = "0"
            Dim tong_tien As Decimal = 0
            If txtTongSoTien.Text.Length > 0 Then
                tong_tien = Decimal.Parse(txtTongSoTien.Text)
            End If
            txtTongTien.Text = tong_tien.ToString
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_MA_TK_NO_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_MA_TK_NO.ClearDataFilter, MyRepositoryItem_MA_TK_CO.ClearDataFilter, MyRepositoryItem_KY_HIEU_KHANG_CO.ClearDataFilter
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            Dim gridctd As CtD = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtD)
            If (gridctd Is Nothing) Then
                Return
            End If
            Select Case columnName
                Case "MaTkNo"
                    If MyRepositoryItem_MA_TK_NO.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        'Gan vao GridView
                        gridctd.TkNoId = VnsConvert.CGuid(MyRepositoryItem_MA_TK_NO.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MaTkCo"
                    If MyRepositoryItem_MA_TK_CO.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctd.TkCoId = VnsConvert.CGuid(MyRepositoryItem_MA_TK_CO.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "KyHieuKhangCo"
                    If MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctd.IdKhangCo = VnsConvert.CGuid(MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_LIST_VALUES(0))
                        gridctd.KyHieuKhangCo = MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_LIST_VALUES(3)
                        gridctd.TenKhangCo = MyRepositoryItem_KY_HIEU_KHANG_CO.OwnerEdit.A_LIST_VALUES(1)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTongSoTien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTongSoTien.TextChanged
        Try
            If cFilterTaiKhoanThue.Tag = Nothing Then
                m_chk_Hoadon = False
                Return
            End If
            Dim g As Guid = VnsConvert.CGuid(cFilterTaiKhoanThue.Tag.ToString())
            If (g = Null.NullGuid) Then
                m_chk_Hoadon = False
            Else
                m_chk_Hoadon = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtDIEN_GIAI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDIEN_GIAI.Leave
        Try
            If FlagDG = 0 Then
                If m_InputState = DataInputState.AddMode Then
                    If _GridView.RowCount > 0 Then
                        Dim obj As CtD = CType(_GridView.GetRow(0), CtD)
                        obj.NoiDung = txtDIEN_GIAI.Text
                        _GridView.RefreshData()
                    End If
                End If
            End If
            FlagDG = FlagDG + 1
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Private appError As AppearanceDefault = New AppearanceDefault(Color.White, Color.LightCoral, Color.Empty, Color.Pink, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)
    Private Sub _GridView_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = _GridView.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "MaTkCo"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "MaTkNo"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "SoTien"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class