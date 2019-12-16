Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports DevExpress.Utils
Imports Vns.Erp.Core.Controls.Commons
Public Class frmOpecPhieuMuaHang_ChiTiet

#Region "Property"
    Public Property DmThueService As IDmThueService
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

    Public Property HtDanhmucService As IHtDanhmucService
#End Region

#Region "Variables and Messages"
    Private obj_ct_h_nx As CtHNx = New CtHNx()
    Private obj_ct_d_nx As CtDNx = New CtDNx()
    Private lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private del_lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private m_InputState As FormGlobals.DataInputState
    Public lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Private m_CTH_ID As Guid
    Private maCT As String
    Public obj_lct As HtLoaichungtu = New HtLoaichungtu()
    Private obj_ct_t As CtThue = New CtThue
    Public lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    Private closeForm As Boolean = False
    Private Kry_DATASOURE As DataTable
    Private Ji_DATASOURE As DataTable
    Private objcthoadon As CtHoadon = New CtHoadon()
    Private OnLoadData = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"
#End Region

#Region "Load form"
    Public Function Show_Form(ByVal CTH_XN_ID As Guid, ByVal ma_CT As String, ByVal name As String, ByVal lstcthg As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As Boolean
        Try
            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            Form_SetText(Me, name, eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_CTH_ID = CTH_XN_ID
            maCT = ma_CT
            obj_lct = _HtLoaichungtuService.GetByMA_LOAI_CT(ma_CT, Generals.DON_VI.Id)
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

    Private Sub SetColumnOrder()
        grcPhieuNhapKhau_View.Columns("MaVuviec").VisibleIndex = 0
        grcPhieuNhapKhau_View.Columns("HanghoaId").VisibleIndex = 1
        'grcPhieuNhapKhau_View.Columns("TenHanghoa").VisibleIndex = 2
        grcPhieuNhapKhau_View.Columns("SoLuong").VisibleIndex = 3
        grcPhieuNhapKhau_View.Columns("GiaVonNt").VisibleIndex = 4
        grcPhieuNhapKhau_View.Columns("DonGiaVonNte").VisibleIndex = 5
        grcPhieuNhapKhau_View.Columns("DonGiaVonNte").VisibleIndex = 6
        grcPhieuNhapKhau_View.Columns("GiaVonNt").VisibleIndex = 7

        grcPhieuNhapKhau_View.Columns("EtaDate").VisibleIndex = 8
        grcPhieuNhapKhau_View.Columns("EtdDate").VisibleIndex = 9
        grcPhieuNhapKhau_View.Columns("LsdDate").VisibleIndex = 10

        grcPhieuNhapKhau_View.Columns("Cang").VisibleIndex = 11
    End Sub

    Private Sub LoadInfoBy(objChungTu As HtLoaichungtu)
        'grcPhieuNhapKhau_View.Columns("ThueId").Visible = objChungTu.SdTkThueNgamdinh
        'grcPhieuNhapKhau_View.Columns("TyLeThueGtgt").Visible = objChungTu.SdTkThueNgamdinh
        'grcPhieuNhapKhau_View.Columns("SoTienThueGtgt").Visible = objChungTu.SdTkThueNgamdinh
        'grcPhieuNhapKhau_View.Columns("SoTienThueXnk").Visible = objChungTu.SdTkThueNgamdinh
        'grcPhieuNhapKhau_View.Columns("TyLeThueTtdb").Visible = objChungTu.SdTkThueNgamdinh
        'grcPhieuNhapKhau_View.Columns("SoTienThueTtdb").Visible = objChungTu.SdTkThueNgamdinh
    End Sub
#End Region

#Region "Private Function and Procedures"
    ''' <summary>
    ''' ham kiem tra null cua form
    ''' </summary>
    ''' <param name="lstobj_ct_d_nx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckNull(ByVal lstobj_ct_d_nx As List(Of CtDNx)) As Boolean
        If LimitValue.CheckTyGia(Decimal.Parse(txtTY_GIA.Text.Trim)) = False Then
            Message_Warning("Tỷ giá không hợp lệ")
            txtTY_GIA.Focus()
            Return False
        End If

        'vong lap kiem tra cac cot tren luoi
        If grcPhieuNhapKhau_View.RowCount <> 0 Then
            For Each objctd As CtDNx In lstobj_ct_d_nx
                'kiem tra gia tri null cua cot Hang hoa
                If (objctd.HanghoaId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập mã hàng hóa")
                    Return False
                End If

                'kiem tra gia tri null cua cot kho nhap
                If Not (objctd.MaTknGiavon = "151") Then
                    If (objctd.KhoNhapId = Null.NullGuid) Then
                        Message_Warning("Bạn chưa lựa chọn mã kho (kho nhập)")
                        Return False
                    End If
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
                'If LimitValue.CheckCurrency(objctd.SO_TIEN_BAN) = False Then
                '    Message_Warning("Giá trị số tiền bán không hợp lệ")
                '    Return False
                'End If
                If LimitValue.CheckCurrency(objctd.GiaVon) = False Then
                    Message_Warning("Giá vốn không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckFCurrency(objctd.GiaVonNt) = False Then
                    Message_Warning("Đơn giá bán ngoại tệ không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckTaxRate(objctd.TyLeThueGtgt) = False Then
                    Message_Warning("Giá trị tỷ lệ thuế GTGT không hợp lệ")
                    Return False
                End If

                If Not LimitValue.CheckTaxRate(objctd.TyLeThueXnk) Then
                    Message_Warning("Giá trị tỷ lệ thuế XNK không hợp lệ!")
                    Return False
                End If

                If Not LimitValue.CheckTaxRate(objctd.TyLeThueTtdb) Then
                    Message_Warning("Giá trị tỷ lệ thuế TTDB không hợp lệ!")
                    Return False
                End If

                'kiem tra gia tri cua cot don gia
                If objctd.DonGiaVon = 0 Then
                    Message_Warning("Bạn chưa nhập đơn giá")
                    Return False
                End If
                ' kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                If (objctd.TknGiavon = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập tài khoản kho")
                    Return False
                End If

                ' Vi tri
                If objctd.ViTri.Length > 128 Then
                    Message_Warning("Độ dài ký tự nhập liệu cho [Vị trí] quá lớn.")
                    Return False
                End If

            Next
        Else
            Message_Warning("Dữ liệu trên lưới chưa có")
            Return False

        End If

        Return True
    End Function

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        UR_STATUS.Visible = Generals.Ts_PheDuyetChungTu
        UR_STATUS.Enabled = Generals.Ts_PheDuyetChungTu
        'Validate control
        'Commons.RequireInputControls = New Control() {dteNGAY_CT, dteNGAY_GHI, dteNGAY_HOADON}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

    Private Sub Init_Data()
        Try
            OnLoadData = True
            'If obj_lct.MaLoaiCt = "P_NKHO_MH_TN" Then
            '    'grcPhieuNhapKhau_View.Columns("TyLeThueXnk").Visible = False
            '    'grcPhieuNhapKhau_View.Columns("SoTienThueXnk").Visible = False
            '    grcPhieuNhapKhau_View.Columns("DonGiaVonNte").Visible = False
            '    grcPhieuNhapKhau_View.Columns("GiaVonNt").Visible = False

            'Else
            '    'grcPhieuNhapKhau_View.Columns("TyLeThueXnk").Visible = True
            '    'grcPhieuNhapKhau_View.Columns("SoTienThueXnk").Visible = True
            '    grcPhieuNhapKhau_View.Columns("DonGiaVonNte").Visible = True
            '    grcPhieuNhapKhau_View.Columns("GiaVonNt").Visible = True
            '    txtTY_GIA.Enabled = True
            '    cboNgoaiTe.Enabled = True
            '    chkNGOAI_TE.CheckState = CheckState.Checked
            'End If
            Select Case m_InputState
                Case DataInputState.AddMode
                    grcPhieuNhapKhau.DataSource = lstobj_ct_d_nx

                    lstobj_ct_d_nx.Add(New CtDNx())
                    grlLOAI_CT_ID.EditValue = obj_lct.MaLoaiCt

                    txtNgayCt.EditValue = DateTime.Now
                    BindLookUpNX()
                    grlLOAI_CT_ID.EditValue = obj_lct.MaLoaiCt
                    SetVisible()
                    DatTrangThaiControl()
                Case Else
                    BindLookUpNX()
                    SetObjectToControl()
                    SetVisible()
                    DatTrangThaiControl()
                    'TongSoTien()
            End Select
            SetColumnOrder()
            SetColNgoaiTe(chkNGOAI_TE.Checked)
            Load_Grid(lstobj_ct_h_gg)
        Catch ex As Exception
            Message_Error(ex)
        End Try
        OnLoadData = False
    End Sub

    Private Sub SetVisible()
        Try
            If obj_lct.DmPhongban <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmPhongbanCo").Visible = False
            End If
            If obj_lct.DmKhoanphi <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmKhoanphiCo").Visible = False
            End If
            If obj_lct.DmTudo1 <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmTudo1Co").Visible = False
            End If
            If obj_lct.DmTudo2 <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmTudo2Co").Visible = False
            End If
            If obj_lct.DmTudo3 <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmTudo3Co").Visible = False
            End If
            If obj_lct.DmTudo4 <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmTudo4Co").Visible = False
            End If
            If obj_lct.DmTudo5 <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmTudo5Co").Visible = False
            End If
            If obj_lct.DmVuviec <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmVuviecCo").Visible = False
            End If
            If obj_lct.DmPtqt <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmPtqtCo").Visible = False
            End If
            If obj_lct.DmHopdong <> 1 Then
                grcPhieuNhapKhau_View.Columns("IdDmHopdongCo").Visible = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub BindLookUpNX()
        Try
            Dim lstPpThanhtoan As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
            lstPpThanhtoan.Add(New HtDanhmuc)
            lstPpThanhtoan.AddRange(HtDanhmucService.GetByDoiTuong("HINHTHUC_THANHTOAN"))
            cboPPThanhtoan.Properties.DataSource = lstPpThanhtoan

            Dim lstCang As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
            'lstPpThanhtoan.Add(New HtDanhmuc)
            lstCang.AddRange(HtDanhmucService.GetByDoiTuong("CANG"))
            cboCang.DataSource = lstCang

            'Bind danh muc thue
            Dim lstDMThue As List(Of DmThue) = New List(Of DmThue)
            lstDMThue.Add(New DmThue)
            'lstDMThue.AddRange(_DmThueService.GetAll())
            lstDMThue.AddRange(_DmThueService.GetDmThueByabc(obj_lct))
            cboDMthue.DataSource = lstDMThue
            cboDMthue.DisplayMember = "TenThue"
            cboDMthue.ValueMember = "Id"
            cboDMthue.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboDMthue.Columns.Add(New LookUpColumnInfo("TenThue", "Tên thuế"))

            Dim tklienquan = obj_lct.MaTkCoLq

            Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstDmTaikhoan = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

            GFilter_MA_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
            cboMaTkCo.Properties.DataSource = lstDmTaikhoan
            cboMaTkCo.EditValue = tklienquan
            'Bind loại chứng từ
            Dim lstLoaiChungTu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
            lstLoaiChungTu.AddRange(_HtLoaichungtuService.GetAll())
            grlLOAI_CT_ID.Properties.DataSource = lstLoaiChungTu
            grlLOAI_CT_ID.Properties.DisplayMember = "TenLoaiCt"
            grlLOAI_CT_ID.Properties.ValueMember = "MaLoaiCt"

            'Bind mã hàng
            Dim lstMaHang As List(Of DmHanghoa) = New List(Of DmHanghoa)
            lstMaHang.AddRange(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
            cboDmHanghoa.DataSource = lstMaHang
            'Bind Số hợp đồng
            Dim lstKhachHangTemp As List(Of DmKhang) = New List(Of DmKhang)
            lstKhachHangTemp.AddRange(_DmKhangService.GetAllByDonviId(Generals.DON_VI.Id, LoaiDoiTuong.NhaCungCap))
            Dim lstKhachHang As List(Of DmKhang) = New List(Of DmKhang)
            Dim objhopdong As DmKhang = New DmKhang
            lstKhachHang.Add(objhopdong)
            lstKhachHang.AddRange(lstKhachHangTemp)
            cboDmKhachHang.Properties.DataSource = lstKhachHang

            'Bind TK No
            Dim lstTKNo As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
            lstTKNo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            cboTK_NO.DataSource = lstTKNo
            cboTK_NO.DisplayMember = "MaTaikhoan"
            cboTK_NO.ValueMember = "Id"
            cboTK_NO.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
            cboTK_NO.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))

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

            rcboDmVuviec.DataSource = lstVuviec

            'Bind danh muc ngoai te
            Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
            lstNgoaite.AddRange(_DmNgoaiteService.GetAllByDonviID(Generals.DonviID))
            cboNgoaiTe.Properties.DisplayMember = "KyHieu"
            cboNgoaiTe.Properties.ValueMember = "Id"
            cboNgoaiTe.Properties.DataSource = lstNgoaite
            cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            txtTY_GIA.Text = "1"

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

            'Bind phong ban
            Dim lstPhongBanTemp As List(Of DmPhongban) = New List(Of DmPhongban)
            lstPhongBanTemp.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
            Dim objphongban As DmPhongban = New DmPhongban
            lstPhongBan.Add(objphongban)
            lstPhongBan.AddRange(lstPhongBanTemp)
            cboPhongban.DataSource = lstPhongBan
            cboPhongban.DisplayMember = "KyHieu"
            cboPhongban.ValueMember = "Id"
            cboPhongban.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã phòng ban"))
            cboPhongban.Columns.Add(New LookUpColumnInfo("TenPhongban", "Tên phòng ban"))


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

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GetControlToOBject()
        Try
            Dim objDmKhang As DmKhang = CType(ComboHelper.GetSelectData(cboDmKhachHang), DmKhang)
            If (objDmKhang IsNot Nothing) Then
                obj_ct_h_nx.KhangId = objDmKhang.Id
                obj_ct_h_nx.MaKhang = objDmKhang.MaKhang
                obj_ct_h_nx.KyHieuKhang = objDmKhang.KyHieu
                obj_ct_h_nx.TenKhang = objDmKhang.TenKhang
            End If

            Dim drLPNhap As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt
            obj_ct_h_nx.IdLoaiCt = drLPNhap.Id
            obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu


            obj_ct_h_nx.TyGia = txtTY_GIA.Text.Trim()
            obj_ct_h_nx.MaNte = cboNgoaiTe.Text.Trim()
            obj_ct_h_nx.NteId = cboNgoaiTe.EditValue
            obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(Not (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))

            Dim objPpThanhToan As HtDanhmuc = CType(ComboHelper.GetSelectData(cboPPThanhtoan), HtDanhmuc)
            If (objPpThanhToan IsNot Nothing) Then
                obj_ct_h_nx.PpThanhtoan = cboPPThanhtoan.EditValue
            Else
                obj_ct_h_nx.PpThanhtoan = 0
            End If

            obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text.Trim()
            obj_ct_h_nx.NgayGhi = txtNgayCt.DateTime
            obj_ct_h_nx.NgayCt = txtNgayCt.DateTime
            obj_ct_h_nx.BxDiengiai1 = txtSoHopDong.Text

            obj_ct_h_nx.DonviId = Generals.DON_VI.Id
            obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
            obj_ct_h_nx.SoDu = 0
            obj_ct_h_nx.Ghi = Convert.ToDecimal(UR_STATUS.Value_info.ParameterValue)


            'Lấy dữ liệu để insert vào CT_HOADON
            If objcthoadon Is Nothing Then
                objcthoadon = New CtHoadon
            End If

            obj_ct_h_nx.SoTien = Decimal.Parse(txtTienHang.Text)
            objcthoadon.TongTien = obj_ct_h_nx.SoTien

            objcthoadon.TenKhachhang = obj_ct_h_nx.TenKhang
            objcthoadon.NgayHoadon = txtNgayCt.DateTime
            objcthoadon.MaSoThue = obj_ct_h_nx.MstKhang
            objcthoadon.DienGiai = obj_ct_h_nx.DienGiai
            objcthoadon.DonviId = obj_ct_h_nx.DonviId
            objcthoadon.MaDonvi = obj_ct_h_nx.MaDonvi


            objcthoadon.DoanhThu = Decimal.Parse(txtTienHang.Text)

            Select Case m_InputState
                Case DataInputState.AddMode
                    Dim strmMonth As String
                    strmMonth = Month(txtNgayCt.DateTime).ToString
                    Dim strYear As String
                    strYear = Year(txtNgayCt.DateTime).ToString
                    C_SoChungTu.r_SoCTPREFIX(obj_ct_h_nx.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id)
                    obj_ct_h_nx.CtSo = C_SoChungTu.SO_CHUNG_TU
                    obj_ct_h_nx.PrefixCt = C_SoChungTu.PREFIX
                Case Else
                    'UpdateCT_H_Nx(obj_ct_h_nx)
                    'CT_HoadonBO.Instance.Update(objcthoadon)
            End Select
            Dim obj_ct_t As CtThue = New CtThue
            'lay gia trị control tren luoi gan cho obj
            For Each objctdnx As CtDNx In lstobj_ct_d_nx
                objctdnx.CthNxId = obj_ct_h_nx.Id

                If VnsCheck.IsNullGuid(objctdnx.Id) Then
                    obj_ct_t = New CtThue
                Else
                    obj_ct_t = _CtThueService.GetObjectAllByCTDNX_ID(objctdnx.Id)
                    If obj_ct_t Is Nothing Then
                        obj_ct_t = New CtThue
                    End If
                End If
                'set khach hàng cho CTDNX
                obj_ct_d_nx.MaKhang = obj_ct_h_nx.MaKhang
                obj_ct_d_nx.IdKhang = obj_ct_h_nx.KhangId


                Dim objTkCo As DmTaikhoan = CType(ComboHelper.GetSelectData(cboMaTkCo), DmTaikhoan)
                If (objTkCo IsNot Nothing) Then
                    objctdnx.TkcGiavon = objTkCo.Id
                    objctdnx.MaTkcGiavon = objTkCo.MaTaikhoan
                End If

                'objctdnx.ID_DM_HOPDONG_NO = objctdnx.ID_DM_HOPDONG_CO
                If (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) Then
                    objctdnx.DonGiaVonNte = 0
                End If

                If (objctdnx.IdKhang = Null.NullGuid) Then

                    objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId
                    objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang
                    objctdnx.KyHieuDmKhangCo = obj_ct_h_nx.KyHieuKhang
                    objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang

                    objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId
                    objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang
                    objctdnx.KyHieuDmKhangNo = obj_ct_h_nx.KyHieuKhang
                    objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang

                    objctdnx.IdKhang = obj_ct_h_nx.KhangId
                    objctdnx.MaKhang = obj_ct_h_nx.MaKhang
                    objctdnx.KyHieuKhang = obj_ct_h_nx.KyHieuKhang
                    objctdnx.TenKhang = obj_ct_h_nx.TenKhang
                Else
                    Dim drKhachHang1 As DmKhang = _DmKhangService.GetById(objctdnx.IdKhang)
                    objctdnx.IdDmKhangCo = drKhachHang1.Id
                    objctdnx.MaDmKhangCo = drKhachHang1.MaKhang
                    objctdnx.KyHieuDmKhangCo = drKhachHang1.KyHieu
                    objctdnx.TenDmKhangCo = drKhachHang1.TenKhang

                    objctdnx.IdDmKhangNo = drKhachHang1.Id
                    objctdnx.MaDmKhangNo = drKhachHang1.MaKhang
                    objctdnx.KyHieuDmKhangNo = drKhachHang1.KyHieu
                    objctdnx.TenDmKhangNo = drKhachHang1.TenKhang

                    objctdnx.IdKhang = drKhachHang1.Id
                    objctdnx.MaKhang = drKhachHang1.MaKhang
                    objctdnx.KyHieuKhang = drKhachHang1.KyHieu
                    objctdnx.TenKhang = drKhachHang1.TenKhang

                End If

                objctdnx.MaHopdong = txtSoHopDong.Text
                objctdnx.MaDmHopdongNo = txtSoHopDong.Text
                objctdnx.MaDmHopdongCo = txtSoHopDong.Text

                objctdnx.IdDmKhoanphiNo = objctdnx.IdDmKhoanphiCo
                objctdnx.IdDmTudo1No = objctdnx.IdDmTudo1Co
                objctdnx.IdDmTudo2No = objctdnx.IdDmTudo2Co
                objctdnx.IdDmTudo3No = objctdnx.IdDmTudo3Co
                objctdnx.IdDmTudo4No = objctdnx.IdDmTudo4Co
                objctdnx.IdDmTudo5No = objctdnx.IdDmTudo5Co
                objctdnx.IdDmPtqtNo = objctdnx.IdDmPtqtCo

                objctdnx.IdDmVuviecCo = objctdnx.VuviecId
                objctdnx.IdDmVuviecNo = objctdnx.VuviecId

                objctdnx.MaDmVuviecCo = objctdnx.MaVuviec
                objctdnx.MaDmVuviecNo = objctdnx.MaVuviec

                objctdnx.IdDmPhongbanNo = objctdnx.IdDmPhongbanCo
                objctdnx.Xuat = obj_lct.KhoXuat
                objctdnx.SoDu = 0
                objctdnx.DuLuong = objctdnx.SoLuong
                objctdnx.SoTienCl = objctdnx.GiaVon

                'Lấy giá trị cho chứng từ thuế
                obj_ct_t.MaTaikhoan = objctdnx.MaTknThueGtgt
                obj_ct_t.TaikhoanId = objctdnx.TknThueGtgt
                obj_ct_t.SoLuong = objctdnx.SoLuong
                obj_ct_t.KhangId = obj_ct_h_nx.KhangId
                obj_ct_t.TenKhang = obj_ct_h_nx.TenKhang
                obj_ct_t.Mst = obj_ct_h_nx.MstKhang
                obj_ct_t.NgayHoadon = obj_ct_h_nx.NgayCt
                obj_ct_t.DoanhSo = objctdnx.GiaVon
                obj_ct_t.SoTien = objctdnx.SoTienThueGtgt
                obj_ct_t.TyLe = objctdnx.TyLeThueGtgt
                'obj_ct_t.SO_TIEN = objctdnx.GIA_VON
                obj_ct_t.NgayTao = obj_ct_h_nx.NgayTao
                obj_ct_t.DonviId = Generals.DON_VI.Id
                obj_ct_t.LoaiTaikhoan = "C"
                obj_ct_t.TenHanghoa = objctdnx.TenHanghoa
                obj_ct_t.CtHoadonId = objcthoadon.Id
                obj_ct_t.CthId = obj_ct_h_nx.Id
                obj_ct_t.PhanHe = 1
            Next
            Dim isUpdate As Boolean = False
            If (m_InputState = DataInputState.EditMode) Then
                isUpdate = True
            End If
            _CtHNxService.SaveChungTuMuaBan(isUpdate, obj_ct_h_nx, lstobj_ct_d_nx, del_lstobj_ct_d_nx, objcthoadon, obj_lct.PhieuXuat)
            'Gan lai gia tri so chung tu sau khi lưu
            C_SoChungTu.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
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
            grlLOAI_CT_ID.EditValue = obj_ct_h_nx.MaLoaiCt
            cboDmKhachHang.EditValue = obj_ct_h_nx.KhangId

            C_SoChungTu.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo

            txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai
            'txtSO_SERI.Text = obj_ct_h_nx.SoSeri
            'txtSO_HOADON.Text = obj_ct_h_nx.SoHoadon
            txtNgayCt.DateTime = obj_ct_h_nx.NgayCt
            txtSoHopDong.Text = obj_ct_h_nx.BxDiengiai1

            UR_STATUS.Set_Status(obj_ct_h_nx.Ghi)
            'UR_STATUS.cboStatus.EditValue = obj_ct_h_nx.GHI.ToString()

            cboNgoaiTe.EditValue = obj_ct_h_nx.NteId
            txtTY_GIA.Text = obj_ct_h_nx.TyGia
            chkNGOAI_TE.Checked = VnsConvert.CBoolean(obj_ct_h_nx.NgoaiTe)
            'SetColNgoaiTe(chkNGOAI_TE.Checked)

            cboPPThanhtoan.EditValue = obj_ct_h_nx.PpThanhtoan
            'chkNGOAI_TE.Checked = TNCommon.ParseBool(obj_ct_h_nx.NGOAI_TE)
            lstobj_ct_d_nx = New List(Of CtDNx)
            lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(m_CTH_ID))
            If (lstobj_ct_d_nx.Count > 0) Then
                cboMaTkCo.EditValue = lstobj_ct_d_nx(0).MaTkcGiavon
            End If
            grcPhieuNhapKhau.DataSource = lstobj_ct_d_nx
            If (lstobj_ct_d_nx.Count > 0) Then
                cboDmKhachHang.EditValue = lstobj_ct_d_nx(0).IdKhang
            End If
            TongSoTien()
            'ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + maCT, grcPhieuNhapKhau_View.Name, grcPhieuNhapKhau_View)
            ''Kiểm tra trạng thái có cho phép sửa hay không
            If Not (UR_STATUS.ChoPhepSuaCT) Then
                UR_STATUS.Enabled = False
            Else
                UR_STATUS.Enabled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function BindTaiKhoan(ByVal tklienquan As String) As List(Of DmTaikhoan)
        Dim ListTK As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        ListTK.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
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

    Private Sub TongSoTien()

        Dim sum As Decimal
        Dim sum2 As Decimal
        Dim sum3 As Decimal
        Dim sum4 As Decimal
        Dim sum5 As Decimal
        Dim i As Integer

        For i = 0 To grcPhieuNhapKhau_View.RowCount - 1
            Dim gridctdnx As CtDNx = CType(grcPhieuNhapKhau_View.GetRow(i), CtDNx)
            sum = sum + gridctdnx.GiaVon
            sum2 = sum2 + gridctdnx.SoTienThueGtgt
            sum3 = sum3 + gridctdnx.SoTienThueXnk
            sum4 = sum4 + gridctdnx.SoTienThueTtdb
        Next
        sum5 = sum + sum2 + sum3 + sum4
        txtTienHang.EditValue = sum
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

    ''' <summary>
    ''' lay ID cua row dang focus
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
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

    Private Sub EnterNext(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Events"

    Private Sub grcPhieuNhapKhau_View_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grcPhieuNhapKhau_View.CellValueChanged
        Try
            Dim gridctdnx As CtDNx = CType(grcPhieuNhapKhau_View.GetRow(grcPhieuNhapKhau_View.FocusedRowHandle), CtDNx)
            Select Case e.Column.Name
                Case "KhoNhapId"
                    Dim cboKhoNhap As DmKho = CType(cboMaKho.GetDataSourceRowByKeyValue(gridctdnx.KhoNhapId), DmKho)
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                Case "HanghoaId"
                    Dim objHanghoa As DmHanghoa = CType(ComboHelper.GetSelectData(cboDmHanghoa, gridctdnx.HanghoaId), DmHanghoa)
                    gridctdnx.MaHanghoa = objHanghoa.MaHanghoa
                    gridctdnx.TenHanghoa = objHanghoa.TenHanghoa
                    gridctdnx.KyHieuHanghoa = objHanghoa.KyHieu
                    gridctdnx.TenDvt = objHanghoa.TenDvt

                    Dim strMaTaiKhoan As String = objHanghoa.MdTkDiduong
                    If String.IsNullOrEmpty(strMaTaiKhoan) Then
                    Else
                        Dim strMTK() As String = strMaTaiKhoan.Split(";")
                        strMaTaiKhoan = strMTK(0)
                        Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                        obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                        gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan
                        gridctdnx.TknGiavon = obj_taikhoan.Id
                    End If
            End Select

            Try
                If e.Column.Name.Equals("ThueId") Then
                    Dim dmThue As DmThue = CType(cboDMthue.GetDataSourceRowByKeyValue(gridctdnx.ThueId), DmThue)
                    If dmThue IsNot Nothing Then
                        gridctdnx.TenThue = dmThue.TenThue
                        grcPhieuNhapKhau_View.SetRowCellValue(grcPhieuNhapKhau_View.FocusedRowHandle, "TyLeThueGtgt", dmThue.TyLe)
                    End If
                End If
                If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
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

                If String.IsNullOrEmpty(gridctdnx.GiaVon) Or String.IsNullOrEmpty(gridctdnx.TyLeThueGtgt) Then
                Else
                    Dim Total1 As Decimal = gridctdnx.TyLeThueGtgt * gridctdnx.GiaVon / 100
                    gridctdnx.SoTienThueGtgt = Decimal.Round(Total1)
                End If

                If String.IsNullOrEmpty(gridctdnx.GiaVon) Or String.IsNullOrEmpty(gridctdnx.TyLeThueXnk) Then
                Else
                    Dim Total2 As Decimal = gridctdnx.TyLeThueXnk * gridctdnx.GiaVon / 100
                    gridctdnx.SoTienThueXnk = Total2
                End If

                If String.IsNullOrEmpty(gridctdnx.GiaVon) Or String.IsNullOrEmpty(gridctdnx.TyLeThueTtdb) Then
                Else
                    Dim Total3 As Decimal = gridctdnx.TyLeThueTtdb * gridctdnx.GiaVon / 100
                    gridctdnx.SoTienThueTtdb = Total3
                End If
                TongSoTien()
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
                        gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.GiaVonNt) * Decimal.Parse(txtTY_GIA.Text)
                        gridctdnx.DonGiaVon = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(txtTY_GIA.Text)
                    Else
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.DonGiaVon) * Decimal.Parse(gridctdnx.SoLuong)
                    End If

                    gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)

                    gridctdnx.SoTienThueGtgt = Decimal.Round(Decimal.Parse(gridctdnx.GiaVon) * Decimal.Parse(gridctdnx.TyLeThueGtgt) / 100)
                    gridctdnx.SoTienThueXnk = Decimal.Round(Decimal.Parse(gridctdnx.GiaVon) * Decimal.Parse(gridctdnx.TyLeThueXnk) / 100)
                    gridctdnx.SoTienThueTtdb = Decimal.Round(Decimal.Parse(gridctdnx.GiaVon) * Decimal.Parse(gridctdnx.TyLeThueTtdb) / 100)

                    TongSoTien()
                Next
            Catch ex As OverflowException
                Message_Warning("Giá trị quá lớn!")
            End Try
            grcPhieuNhapKhau_View.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        grcPhieuNhapKhau_View.Columns("DonGiaVon").Visible = Not ngoaite
        grcPhieuNhapKhau_View.Columns("GiaVon").Visible = Not ngoaite
        grcPhieuNhapKhau_View.Columns("DonGiaVonNte").Visible = ngoaite
        grcPhieuNhapKhau_View.Columns("GiaVonNt").Visible = ngoaite
        If (ngoaite) Then
            txtTY_GIA.Enabled = True
            grcPhieuNhapKhau_View.Columns("DonGiaVonNte").VisibleIndex = 4
            grcPhieuNhapKhau_View.Columns("GiaVonNt").VisibleIndex = 5
        Else
            txtTY_GIA.Enabled = False
            grcPhieuNhapKhau_View.Columns("DonGiaVon").VisibleIndex = 4
            grcPhieuNhapKhau_View.Columns("GiaVon").VisibleIndex = 5
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
            AddHandler grcPhieuNhapKhau_View.RowCellStyle, AddressOf grcPhieuNhapKhau_View_RowCellStyle
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
            If _KtKhoasoThangService.KiemTraKhoaSo(txtNgayCt.DateTime, Generals.DON_VI.Id) Then
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

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            'Refesh Grid
            m_CTH_ID = obj_ct_h_nx.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h_nx)
            GridHelper.RefreshLeftGrid(grvLPX_Hnx, lstobj_ct_h_gg, editObject, m_InputState)

            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
            RemoveHandler grcPhieuNhapKhau_View.RowCellStyle, AddressOf grcPhieuNhapKhau_View_RowCellStyle
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteRow()
        Dim gridctdnx As CtDNx = CType(grcPhieuNhapKhau_View.GetRow(grcPhieuNhapKhau_View.FocusedRowHandle), CtDNx)
        del_lstobj_ct_d_nx.Add(gridctdnx)
        '_CtThueService.DeleteByCTDNX(gridctdnx.Id)
        grcPhieuNhapKhau_View.DeleteSelectedRows()
        'Message_Information("Xóa thành công")
        TongSoTien()
    End Sub

    Private Sub grcPhieuNhapKhau_View_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcPhieuNhapKhau_View.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(grcPhieuNhapKhau_View)) Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        grcPhieuNhapKhau_View.RefreshData()
                        SetFocus_FirstCell()
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuayRa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Try
            Me.Close()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetFocus_FirstCell()
        grcPhieuNhapKhau_View.FocusedRowHandle = grcPhieuNhapKhau_View.RowCount - 1
        grcPhieuNhapKhau_View.SelectRow(Handle)
        Try
            grcPhieuNhapKhau_View.FocusedColumn = grcPhieuNhapKhau_View.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmHoaDonBanHangKiemPhieuXuatKho_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If

                Case Keys.F4
                    'Try
                    If m_InputState <> DataInputState.ViewMode Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        SetFocus_FirstCell()
                        grcPhieuNhapKhau_View.RefreshData()
                    End If
                    'Catch ex As Exception
                    '    Message_Error(ex)
                    'End Try
                    Exit Select

                Case Keys.F8
                    If m_InputState <> DataInputState.ViewMode Then
                        If grcPhieuNhapKhau_View.RowCount <> 0 Then
                            DeleteRow()
                            grcPhieuNhapKhau_View.RefreshData()
                            TongSoTien()
                        Else
                            Message_Warning("Không có bản ghi nào được chọn!")
                        End If
                    End If
                    Exit Select

                Case e.Control And Keys.F11
                    'Dim frm_log As KTY.Security.frmViewLog_DanhSach
                    'If m_InputState <> DataInputState.AddMode Then
                    '    frm_log = New KTY.Security.frmViewLog_DanhSach(m_CTH_ID, obj_ct_h_nx.ID_LOAI_CT, obj_ct_h_nx.CT_SO)
                    '    frm_log.ShowDialog()
                    'End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            TongSoTien()
            If obj_ct_h_nx.DaKhoaSo = 0 Then
                m_InputState = DataInputState.EditMode

                DatTrangThaiControl()
            Else
                Message_Information("Chứng từ đã được khóa nên không thể sửa!")
            End If

            groupControl1.Focus()
            txtNgayCt.Focus()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            'Dim obj_htchungtu As HtLoaichungtu = CType(grlLOAI_CT_ID.Properties.View.GetRow(grlLOAI_CT_ID.Properties.GetIndexByKeyValue(grlLOAI_CT_ID.EditValue)), HtLoaichungtu)
            'Dim obj_form = New frmKho_Input(Me.m_CTH_ID, obj_htchungtu)
            'obj_form.ShowDialog()

            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            Dim obj_form = CType(ObjectFactory.GetObject("frmKho_Input", New Object() {m_CTH_ID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                grcLPN_Hnx.Enabled = False
                Control_SetState(groupControl1, DataInputState.AddMode)
                Control_SetState(groupControl2, DataInputState.AddMode)
                grcPhieuNhapKhau_View.OptionsBehavior.Editable = True

                cboDmKhachHang.Enabled = True
                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = False
                btnPri.Enabled = False
                btnCan.Enabled = True
                btnSea.Enabled = False
                navCTHG.Enabled = False
                cboDmKhachHang.Enabled = True
            Case DataInputState.EditMode
                grcLPN_Hnx.Enabled = False
                Control_SetState(groupControl1, DataInputState.EditMode)
                Control_SetState(groupControl2, DataInputState.EditMode)
                grcPhieuNhapKhau_View.OptionsBehavior.Editable = True

                cboDmKhachHang.Enabled = True

                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = True
                btnPri.Enabled = True
                btnCan.Enabled = True
                btnSea.Enabled = False
                navCTHG.Enabled = False
                cboDmKhachHang.Enabled = True
            Case Else
                grcLPN_Hnx.Enabled = True
                Control_SetState(groupControl1, DataInputState.ViewMode)
                Control_SetState(groupControl2, DataInputState.ViewMode)

                cboDmKhachHang.Enabled = False
                grcPhieuNhapKhau_View.OptionsBehavior.Editable = False
                btnAdd.Enabled = True
                btnMod.Enabled = True
                btnSav.Enabled = False
                btnDel.Enabled = True
                btnPri.Enabled = True
                btnCan.Enabled = False
                btnSea.Enabled = True
                navCTHG.Enabled = True
                cboDmKhachHang.Enabled = False
        End Select
    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Try
            'If m_InputState = DataInputState.AddMode Then
            If lstobj_ct_h_gg.Count > 0 Then
                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
                    grvLPX_Hnx.FocusedRowHandle = lstobj_ct_h_gg.Count - 1
                End If
                SetObjectToControl()
                TongSoTien()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If
            'End If
            DatTrangThaiControl()
            btnAdd.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
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

            End If

            If lstobj_ct_h_gg.Count = 0 Then
                ClearPage()
                m_InputState = DataInputState.AddMode
            End If
            DatTrangThaiControl()
            btnAdd.Focus()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Sub ClearPage()
        Control_ClearData(groupControl1)
        Control_ClearData(groupControl2)
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA.Text = "1"
        grlLOAI_CT_ID.EditValue = obj_lct.MaLoaiCt
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.Add(New CtDNx)
        grcPhieuNhapKhau.DataSource = lstobj_ct_d_nx
        'UR_STATUS.cboStatus.EditValue = 1
        UR_STATUS.Set_Status(1)
        grcPhieuNhapKhau_View.RefreshData()
        txtTienHang.EditValue = 0

        C_SoChungTu.Text = ""
        'BindLookUpNX()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler grcPhieuNhapKhau_View.RowCellStyle, AddressOf grcPhieuNhapKhau_View_RowCellStyle
            obj_ct_h_nx = New CtHNx
            objcthoadon = New CtHoadon

            m_InputState = DataInputState.AddMode

            DatTrangThaiControl()
            ClearPage()
            grcPhieuNhapKhau_View.FocusedRowHandle = 0
            grcPhieuNhapKhau_View.FocusedColumn = grcPhieuNhapKhau_View.VisibleColumns(0)
            groupControl1.Focus()
            txtNgayCt.Focus()
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
                TongSoTien()
            Else
                'ClearPage()
            End If

            'ClearPage()
            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuNhapKhau_ChiTiet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboNgoaiTe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNgoaiTe.EditValueChanged
        Try
            txtTY_GIA.Text = "1"
            If cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                SetColNgoaiTe(False)
                If lstobj_ct_d_nx.Count > 0 Then
                    For Each objctdnx As CtDNx In lstobj_ct_d_nx
                        objctdnx.DonGiaBanNte = 0
                        objctdnx.DonGiaVonNte = 0
                        objctdnx.GiaVonNt = 0
                        objctdnx.SoTienBanNte = 0
                    Next
                    grcPhieuNhapKhau_View.RefreshData()
                End If
            Else
                If Not (OnLoadData) Then
                    txtTY_GIA.Text = _LsTygiaService.GetTyGiaNgoaiTe(cboNgoaiTe.EditValue, txtNgayCt.EditValue)
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
            If (grvLPX_Hnx.RowCount > 0) Then
                If (btnMod.Enabled = False) And ((m_InputState = DataInputState.AddMode) Or (m_InputState = DataInputState.EditMode)) Then
                    'SetObjectToControl()
                Else
                    If GetRowSelect() Then
                        SetObjectToControl()
                    End If
                End If
            Else
                'MessageBox.Show("Không có bản ghi nào trong lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'REPOSITORY IN GRID
    Private Sub MyRepositoryItem_FirstBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.FisrtBinddata
        Try
            Dim rowHandle As Integer = grcPhieuNhapKhau_View.FocusedRowHandle
            Dim columnName As String = grcPhieuNhapKhau_View.FocusedColumn().Name
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

    Private Sub ckeNhapTienThue_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        EnterNext(sender, e)
    End Sub
#End Region

    Private Sub grcPhieuNhapKhau_View_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = grcPhieuNhapKhau_View.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "KyHieuHanghoa"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "KhoNhapId"
                    If VnsCheck.IsNullGuid(VnsConvert.CGuid(val.ToString)) Then
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