Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.Utils
Imports Vns.Erp.Core.Controls.Commons

Public Class frmOpecPhieuNhapXuat_ChiTiet

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

    Private _LsTygiaService As ILsTygiaService
    Public Property LsTygiaService As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(ByVal value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        UR_STATUS.Visible = Generals.Ts_PheDuyetChungTu
        UR_STATUS.Enabled = Generals.Ts_PheDuyetChungTu
        'Validate control
        Commons.RequireInputControls = New Control() {txtNgayCt}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

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
    ''' khao bao bien chua ID dung de load du lieu cho bang duoi theo ID bang tren
    ''' </summary>
    ''' <remarks></remarks>
    Dim CTHNXID As Guid

    ''' <summary>
    ''' khai bao 1 bien chua ID de truyen sang form chi tiet de xu ly
    ''' </summary>
    ''' <remarks></remarks>
    Dim mCTHNXID As Guid

    ''' <summary>
    ''' khai bao bien chua ma loai chung tu truyen vao tu form list
    ''' </summary>
    ''' <remarks></remarks>
    Dim m_Ma_Loai_CT As String

    ''' <summary>
    ''' khai bao 1 kieu obj de su dung lay ma loai chung tu tuong ung ung voi loai phieu,xet trang thai cho cac cot tren luoi
    ''' </summary>
    ''' <remarks></remarks>
    Public obj_lct As HtLoaichungtu = New HtLoaichungtu()

    ''' <summary>
    ''' khai bao 1 bien luu ten form
    ''' </summary>
    ''' <remarks></remarks>
    Private m_setText As String

    ''' <summary>
    ''' khai bao 1 list obj chua list obj da dc conver
    ''' </summary>
    ''' <remarks></remarks>
    Private lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Private closeForm As Boolean = False
    Private objLoaiChungTu As HtLoaichungtu = New HtLoaichungtu()
    'DataTable Hang Hoa
    Private Kry_DATASOURE As DataTable
    'DataTable Tai khoan
    Private Ji_DATASOURE As DataTable
    'Bien xac dinh thoi diem load ty gia ngoai te
    Private OnLoadData = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"

#End Region

#Region "Load Form"

    ''' <summary>
    ''' xu ly khi load form
    ''' </summary>
    ''' <param name="ID_CT"></param>
    ''' <param name="eState"></param>
    ''' <param name="Ten_Loai_CT"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Show_Form(ByVal ID_CT As Guid, ByVal Ma_Loai_CT As String, ByVal Ten_Loai_CT As String, ByVal lstCTH_G As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As Boolean
        Try
            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            objLoaiChungTu = _HtLoaichungtuService.GetByMA_LOAI_CT(Ma_Loai_CT, Generals.DON_VI.Id)
            'xet loai phieu de hien thi cot kho tren luoi            
            If objLoaiChungTu.KhoXuat = 1 Then
                grvPhieuNhapKho.Columns("KhoXuatId").Visible = True
                grvPhieuNhapKho.Columns("KhoNhapId").Visible = False
                grvPhieuNhapKho.Columns("MaTknGiavon").Visible = False
                grvPhieuNhapKho.Columns("MaTkcGiavon").Visible = False
                lblTK.Text = "TK nợ"
            Else
                grvPhieuNhapKho.Columns("KhoXuatId").Visible = False
                grvPhieuNhapKho.Columns("KhoNhapId").Visible = True
                grvPhieuNhapKho.Columns("MaTkcGiavon").Visible = False
                grvPhieuNhapKho.Columns("MaTknGiavon").Visible = False
                lblTK.Text = "TK có"
            End If
            UR_STATUS.LCT_STATUS = objLoaiChungTu.Id
            If lstCTH_G IsNot Nothing Then
                lstobj_ct_h_gg = lstCTH_G
            End If

            mCTHNXID = ID_CT
            m_Ma_Loai_CT = Ma_Loai_CT

            m_setText = Ten_Loai_CT
            'hien thi ten header form theo loai phieu va xet cac icon cho nut            
            'TNCommon.setIconControl(Me)
            Form_SetText(Me, Ten_Loai_CT, eState)
            Form_InitDialog(Me)
            'dat cac truong not null
            'Control_SetRequire(grlKHANG_ID, True)
            'Control_SetRequire(dteNGAY_GHI, True)

            ' gan cho bien trang thai form dang xu ly
            m_InputState = eState

            ' goi khoi xu ly form
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
            Return False
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
                    ' goi ham xu ly cac control trong form
                    DatTrangThaiControl()

                    'gan gia tri cho combox
                    grlLoaiPhieuNhap.EditValue = obj_lct.MaLoaiCt

                    'gan 1 list obj
                    ' lstobj_ct_d_nx.Add(New CtDNx())

                    'bind list obj len luoi
                    grcPhieuPhapKho.DataSource = lstobj_ct_d_nx

                    'gan tri mac dinh cho o text , o chon ngay thang , ty gia ,gia tri mac dinh combobox ma ngoai te
                    'txtGHI.Text = "1"                    
                    'txtTY_GIA.Text = 1                    
                    SetVisible()
                    'txtCT_SO.Text = Nothing
                    'txtCT_SO.Properties.ReadOnly = True
                    ClearPage()
                    cboMaTk.EditValue = obj_lct.MaTkCoLq
                    'cboTyGia.EditValue = "81E00955D56B450FB937245655101B9F"
                    ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT, grvPhieuNhapKho.Name, grvPhieuNhapKho)

                Case DataInputState.EditMode
                    DatTrangThaiControl()
                    'goi ham load data theo gia tri truyen vao trang thai la Edit
                    SetObjectToControl()
                    'TongTien()
                    SetVisible()
                    'txtCT_SO.Properties.ReadOnly = True

            End Select
            Load_Grid(lstobj_ct_h_gg)

        Catch ex As Exception
            Message_Error(ex)
        End Try
        OnLoadData = False
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
    ''' bind data vao comobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindLoookUpNX()
        Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstKhang As List(Of DmKhang) = _DmKhangService.GetAllByDonviID(Generals.DON_VI.Id)
        cboDmKhachHang.Properties.DataSource = lstKhang

        Dim lstHanghoa As List(Of DmHanghoa) = _DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id)
        cboHanghoa.DataSource = lstHanghoa

        ' Bind loại chứng từ
        Dim listLCTu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        listLCTu.AddRange(_HtLoaichungtuService.GetAll())
        grlLoaiPhieuNhap.Properties.DataSource = listLCTu
        grlLoaiPhieuNhap.Properties.DisplayMember = "KyHieu"
        grlLoaiPhieuNhap.Properties.ValueMember = "MaLoaiCt"

        'Bind ngoai te
        Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
        lstNgoaite.AddRange(_DmNgoaiteService.GetAllByDonviID(Generals.DON_VI.Id))
        cboTyGia.Properties.DisplayMember = "KyHieu"
        cboTyGia.Properties.ValueMember = "Id"
        cboTyGia.Properties.DataSource = lstNgoaite
        cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA.Text = "1"

        'Bind TK No
        Dim lstTKNo As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        lstTKNo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        cboMaTk.Properties.DataSource = lstTKNo
        cboMaTk.EditValue = obj_lct.MaTkCoLq

        cboTKno.DataSource = lstTKNo
        cboTKno.DisplayMember = "MaTaikhoan"
        cboTKno.ValueMember = "Id"
        cboTKno.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboTKno.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))


        'Bind TK Có
        Dim lstTKCo As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        lstTKCo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        cboTKco.DataSource = lstTKCo
        cboTKco.DisplayMember = "MaTaikhoan"
        cboTKco.ValueMember = "Id"
        cboTKco.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboTKco.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))

        ''Bind mã kho nhap
        Dim lstMaKho As List(Of DmKho) = New List(Of DmKho)
        lstMaKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        cboMaKho.DataSource = lstMaKho
        cboMaKho.DisplayMember = "KyHieu"
        cboMaKho.ValueMember = "Id"
        cboMaKho.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboMaKho.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

        ''Bind mã kho xuat
        Dim lstMaKhoXuat As List(Of DmKho) = New List(Of DmKho)
        lstMaKhoXuat.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        cboMakhoxuat.DataSource = lstMaKhoXuat
        cboMakhoxuat.DisplayMember = "KyHieu"
        cboMakhoxuat.ValueMember = "Id"
        cboMakhoxuat.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboMakhoxuat.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

        'Bind vụ việc
        Dim lstVuViecTemp As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecTemp.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstVuviec As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim objvuviec As DmVuviec = New DmVuviec
        lstVuviec.Add(objvuviec)
        lstVuviec.AddRange(lstVuViecTemp)

        rcboVuviecId.DataSource = lstVuviec

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

        'Bind tu do 5
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
        Dim lstPhongBan1 As List(Of DmPhongban) = New List(Of DmPhongban)
        Dim objphongban As DmPhongban = New DmPhongban
        lstPhongBan1.Add(objphongban)
        lstPhongBan1.AddRange(lstPhongBanTemp)
        cboPhongban.DataSource = lstPhongBan1
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
    ''' xu ly hien thi mot so truong
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetVisible()
        If obj_lct.DmPhongban <> 1 Then
            grvPhieuNhapKho.Columns("IdDmPhongbanCo").Visible = False
        End If
        If obj_lct.DmKhoanphi <> 1 Then
            grvPhieuNhapKho.Columns("IdDmKhoanphiCo").Visible = False
        End If
        If obj_lct.DmTudo1 <> 1 Then
            grvPhieuNhapKho.Columns("IdDmTudo1Co").Visible = False
        End If
        If obj_lct.DmTudo2 <> 1 Then
            grvPhieuNhapKho.Columns("IdDmTudo2Co").Visible = False
        End If
        If obj_lct.DmTudo3 <> 1 Then
            grvPhieuNhapKho.Columns("IdDmTudo3Co").Visible = False
        End If
        If obj_lct.DmTudo4 <> 1 Then
            grvPhieuNhapKho.Columns("IdDmTudo4Co").Visible = False
        End If
        If obj_lct.DmTudo5 <> 1 Then
            grvPhieuNhapKho.Columns("IdDmTudo5Co").Visible = False
        End If
        If obj_lct.DmVuviec <> 1 Then
            grvPhieuNhapKho.Columns("VuviecId").Visible = False
        End If
        If obj_lct.DmPtqt <> 1 Then
            grvPhieuNhapKho.Columns("IdDmPtqtCo").Visible = False
        End If
        If obj_lct.DmHopdong <> 1 Then
            grvPhieuNhapKho.Columns("IdDmHopdongCo").Visible = False
        End If
    End Sub

    ''' <summary>
    ''' ham xu ly lay data tren form de su ly insert va update
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetControlToOBject()
        Try
            'lay nhieu gia tri trong 1 table khac
            Dim drLPNhap As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)
            obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt
            obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu
            obj_ct_h_nx.IdLoaiCt = drLPNhap.Id
            'add cac truong can vao obj
            'obj_ct_h_nx.NTE_ID = cboTyGia.EditValue
            'obj_ct_h_nx.TY_GIA = txtTY_GIA.Text

            obj_ct_h_nx.TyGia = txtTY_GIA.Text.Trim()
            obj_ct_h_nx.MaNte = cboTyGia.Text
            obj_ct_h_nx.NteId = cboTyGia.EditValue
            obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(Not (cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))

            Dim objKhang As DmKhang = CType(ComboHelper.GetSelectData(cboDmKhachHang), DmKhang)
            If (objKhang IsNot Nothing) Then
                obj_ct_h_nx.KhangId = objKhang.Id
                obj_ct_h_nx.MaKhang = objKhang.MaKhang
                obj_ct_h_nx.KyHieuKhang = objKhang.KyHieu
                obj_ct_h_nx.TenKhang = objKhang.TenKhang
            Else
                obj_ct_h_nx.KhangId = Null.NullGuid
                obj_ct_h_nx.MaKhang = String.Empty
                obj_ct_h_nx.KyHieuKhang = String.Empty
                obj_ct_h_nx.TenKhang = String.Empty
            End If

            obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text
            obj_ct_h_nx.NgayGhi = txtNgayCt.DateTime
            obj_ct_h_nx.NgayCt = txtNgayCt.DateTime
            'obj_ct_h_nx.GHI = txtGHI.Text
            obj_ct_h_nx.Ghi = Convert.ToDecimal(UR_STATUS.Value_info.ParameterValue)
            obj_ct_h_nx.NguoiTao = Generals.USER.Id.ToString
            obj_ct_h_nx.NguoiSua = Generals.USER.Id.ToString
            obj_ct_h_nx.DonviId = Generals.DON_VI.Id
            obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
            obj_ct_h_nx.SoDu = 0

            Dim flgUpdate = True
            ' Sử lý insert,update
            Select Case m_InputState
                Case DataInputState.AddMode
                    Dim strmMonth As String
                    strmMonth = Month(txtNgayCt.DateTime).ToString
                    Dim strYear As String
                    strYear = Year(txtNgayCt.DateTime).ToString
                    C_SoChungTu_RP.r_SoCTPREFIX(obj_ct_h_nx.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id)
                    obj_ct_h_nx.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                    obj_ct_h_nx.PrefixCt = C_SoChungTu_RP.PREFIX
                    flgUpdate = False
                Case Else
            End Select

            'lay gia trị control tren luoi gan cho obj
            For Each objctdnx As CtDNx In lstobj_ct_d_nx
                'objctdnx.CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID
                objctdnx.Xuat = drLPNhap.KhoXuat
                '
                objctdnx.IdKhang = obj_ct_h_nx.KhangId
                objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang
                objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang
                '
                objctdnx.MaHopdong = txtMaHopDong.Text
                objctdnx.MaDmHopdongNo = objctdnx.MaHopdong
                objctdnx.MaDmHopdongCo = objctdnx.MaHopdong

                objctdnx.IdDmKhoanphiNo = objctdnx.IdDmKhoanphiCo
                objctdnx.IdDmTudo1No = objctdnx.IdDmTudo1Co
                objctdnx.IdDmTudo2No = objctdnx.IdDmTudo2Co
                objctdnx.IdDmTudo3No = objctdnx.IdDmTudo3Co
                objctdnx.IdDmTudo4No = objctdnx.IdDmTudo4Co
                objctdnx.IdDmTudo5No = objctdnx.IdDmTudo5Co
                objctdnx.IdDmPtqtNo = objctdnx.IdDmPtqtCo
                objctdnx.IdDmVuviecCo = objctdnx.VuviecId
                objctdnx.IdDmVuviecNo = objctdnx.VuviecId

                Dim objTk As DmTaikhoan = CType(ComboHelper.GetSelectData(cboMaTk), DmTaikhoan)
                If (objTk IsNot Nothing) Then
                    If objLoaiChungTu.KhoXuat = 1 Then
                        objctdnx.MaTknGiavon = objTk.MaTaikhoan
                        objctdnx.TknGiavon = objTk.Id
                    Else
                        objctdnx.MaTkcGiavon = objTk.MaTaikhoan
                        objctdnx.TkcGiavon = objTk.Id

                        'Rieng nhap kho cua opec kho xuat = kho nhap (Co hang di duong luoi nhu cho)
                        'objctdnx.KhoXuatId = objctdnx.KhoNhapId
                    End If
                End If

            Next

            _CtHNxService.SaveChungTuKho(flgUpdate, obj_ct_h_nx, lstobj_ct_d_nx, del_lstobj_ct_d_nx)
            'Gán lại giá trị so chung tu sau khi luu
            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' ham xu ly load data len form theo Id tuong ung
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetObjectToControl()
        'load data theo Id truyen vao
        obj_ct_h_nx = _CtHNxService.GetById(mCTHNXID)
        If obj_ct_h_nx Is Nothing Then
            closeForm = True
            Return
        Else
            closeForm = False
        End If
        grlLoaiPhieuNhap.EditValue = obj_ct_h_nx.MaLoaiCt
        'grlKHANG_ID.EditValue = obj_ct_h_nx.KHANG_ID
        '
        cboDmKhachHang.EditValue = obj_ct_h_nx.KhangId


        txtTY_GIA.Text = obj_ct_h_nx.TyGia
        cboTyGia.EditValue = obj_ct_h_nx.NteId
        'txtGHI.Text = obj_ct_h_nx.GHI
        UR_STATUS.Set_Status(obj_ct_h_nx.Ghi)
        UR_STATUS.cboStatus.EditValue = obj_ct_h_nx.Ghi
        txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai
        txtNgayCt.DateTime = obj_ct_h_nx.NgayCt

        C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
        cboTyGia.EditValue = obj_ct_h_nx.NteId
        txtTY_GIA.Text = obj_ct_h_nx.TyGia
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(mCTHNXID))

        If lstobj_ct_d_nx.Count <> 0 Then
            grcPhieuPhapKho.DataSource = lstobj_ct_d_nx
            TongTien()
            txtMaHopDong.Text = lstobj_ct_d_nx(0).MaHopdong
            'If objLoaiChungTu.KhoXuat = 1 Then
            '    cboMaTk.EditValue = lstobj_ct_d_nx(0).MaTknGiavon
            'Else
            '    cboMaTk.EditValue = lstobj_ct_d_nx(0).MaTkcGiavon
            'End If
        End If
        TongTien()
        '
        ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT, grvPhieuNhapKho.Name, grvPhieuNhapKho)
        ''Kiểm tra trạng thái có cho phép sửa hay không
        If Not (UR_STATUS.ChoPhepSuaCT) Then
            UR_STATUS.Enabled = False
        Else
            UR_STATUS.Enabled = True
        End If
    End Sub


    ''' <summary>
    ''' ham tinh tong tien cot trong luoi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TongTien()
        Dim sumTongTien As Decimal
        Dim sumTongSoLuong As Decimal
        Dim i As Integer
        For i = 0 To grvPhieuNhapKho.RowCount - 1
            Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(i), CtDNx)

            sumTongTien = sumTongTien + gridctdnx.GiaVon
            sumTongSoLuong = sumTongSoLuong + gridctdnx.SoLuong
        Next
        TxtTongTien.EditValue = sumTongTien 'Format(CLng(sumTongTien.ToString), "n0")
        txtTongSoLuong.EditValue = sumTongSoLuong 'Format(CLng(sumTongSoLuong.ToString), "n0")
    End Sub

    ''' <summary>
    ''' xu ly btn LUU
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            AddHandler grvPhieuNhapKho.RowCellStyle, AddressOf grvPhieuNhapKho_RowCellStyle
            Me.ValidateChildren()
            ''check trang thai co thuoc quyen cua user hay ko
            If Not UR_STATUS.ChoPhepSuaCT Then
                Message_Warning(msgTTChungTu)
                Return
            End If

            If (obj_ct_h_nx Is Nothing) Then
                obj_ct_h_nx = New CtHNx()
            End If

            If (obj_ct_h_nx.DaKhoaSo = 1) Then
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

            Try
                'xu ly check so luong ton kho trong phieu xuat kho
                If (objLoaiChungTu.KhoXuat = 1) Then
                    Dim lst As List(Of DmKho) = New List(Of DmKho)()
                    lst = cboMaKho.DataSource
                    If Not (_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, txtNgayCt.EditValue, lstobj_ct_d_nx, lst, Generals.DON_VI.Id)) Then
                        Message_Warning("Kho không cho phép xuất âm")
                        grvPhieuNhapKho.RefreshData()
                        Exit Sub
                    End If
                End If

                'goi ham xu ly data tren form
                frmProgress.Instance.Thread = AddressOf GetControlToOBject
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Data saved")

                'Refesh Grid
                mCTHNXID = obj_ct_h_nx.Id
                Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h_nx)
                GridHelper.RefreshLeftGrid(grvLPX_Hnx, lstobj_ct_h_gg, editObject, m_InputState)

                m_InputState = DataInputState.ViewMode
                DatTrangThaiControl()
                btnAdd.Focus()
                RemoveHandler grvPhieuNhapKho.RowCellStyle, AddressOf grvPhieuNhapKho_RowCellStyle
            Catch ex As Exception
                Message_Error(ex)
            End Try

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' ham kiem tra null cua form
    ''' </summary>
    ''' <param name="lstobj_ct_d_nx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckNull(ByVal lstobj_ct_d_nx As List(Of CtDNx)) As Boolean
        'kiem tra null cua comobox ngay hach toan
        If (txtNgayCt.DateTime = Nothing) Then
            Message_Warning("Bạn chưa nhập ngày hạch toán.")
            txtNgayCt.Focus()
            Return False
        End If

        If LimitValue.CheckTyGia(Decimal.Parse(txtTY_GIA.Text.Trim)) = False Then
            Message_Warning("Tỷ giá không hợp lệ")
            txtTY_GIA.Focus()
            Return False
        End If

        'vong lap kiem tra cac cot tren luoi
        If grvPhieuNhapKho.RowCount <> 0 Then

            For Each objctd As CtDNx In lstobj_ct_d_nx

                'kiem tra gia tri null cua cot Hang hoa
                If objctd.HanghoaId = Null.NullGuid Then
                    Message_Warning("Bạn chưa nhập mã hàng hóa.")
                    Return False
                End If

                If String.IsNullOrEmpty(objctd.KyHieuHanghoa) Then
                    Message_Warning("Bạn để trống cột mã hàng hóa")
                    Return False
                End If

                'xet loai phieu de hien thi cot kho tren luoi
                If obj_lct.KhoXuat = 0 Then
                    'kiem tra gia tri null cua cot kho nhap
                    If VnsCheck.IsNullGuid(objctd.KhoNhapId) Then
                        Message_Warning("Bạn chưa lựa chọn kho nhập.")
                        Return False
                    End If
                ElseIf obj_lct.KhoXuat = 1 Then
                    'kiem tra gia tri null cua cot kho xuat
                    If VnsCheck.IsNullGuid(objctd.KhoXuatId) Then
                        Message_Warning("Bạn chưa lựa chọn kho xuất.")
                        Return False
                    End If
                End If

                'kiem tra gia tri cua cot so luong
                If objctd.SoLuong = 0 Then

                    Message_Warning("Bạn chưa nhập số lượng.")
                    Return False
                End If

                'kiem tra gia tri cua cot don gia
                If objctd.DonGiaVon = 0 Then

                    Message_Warning("Bạn chưa nhập đơn giá.")
                    Return False
                End If

                'kiem tra gia tri cot tong tien
                If LimitValue.CheckCurrency(objctd.GiaVon) = False Then
                    Message_Warning("Giá vốn không hợp lệ")
                    Return False
                End If

                ' kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                If VnsCheck.IsNullGuid(objctd.TkcGiavon) And VnsCheck.IsNullGuid(objctd.TknGiavon) Then
                    Message_Warning("Định khoản chưa nhập đủ.")
                    Return False
                End If

                'Kiem tra các giá trị số trên lưới
                If LimitValue.CheckQuantity(objctd.SoLuong) = False Then
                    Message_Warning("Giá trị số lượng không hợp lệ")
                    Return False
                End If
                ' Kiem tra length nhap lieu
                ' Vi tri
                If objctd.ViTri.Trim().Length > 128 Then

                    Message_Warning("Độ dài ký tự nhập liệu cho [Vị trí] quá lớn.")
                    Return False
                End If

            Next
        Else
            Message_Warning("Chi tiết định khoản không được để trống")
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' xu ly btn Delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
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

                mCTHNXID = GridHelper.RemoveLeftGrid(lstobj_ct_h_gg, mCTHNXID)
                If Not (mCTHNXID = Null.NullGuid) Then
                    SetObjectToControl()
                End If

                'refresh lai data tren luoi
                grvLPX_Hnx.RefreshData()

                m_InputState = DataInputState.ViewMode

                'txtCT_SO.Properties.ReadOnly = True
            End If

            If lstobj_ct_h_gg.Count = 0 Then
                ClearPage()
                m_InputState = DataInputState.AddMode
            End If
            btnAdd.Focus()
            DatTrangThaiControl()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' ham xu ly delete record tren luoi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DeleteRow()
        Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle), CtDNx)
        del_lstobj_ct_d_nx.Add(gridctdnx)
        grvPhieuNhapKho.DeleteSelectedRows()
        'Message_Information("Xóa thành công")
    End Sub

    ''' <summary>
    ''' xu ly btn quay ra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Try
            Me.Close()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly btn search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        Try
            Dim fr As frmTimKiemChungTuKho = ObjectFactory.GetObject("frmTimKiemChungTuKho")
            fr.MaCT = obj_lct.MaLoaiCt
            fr.ShowDialog()

            If fr.lstobj_ct_h_g.Count > 0 Then
                '
                lstobj_ct_h_gg = fr.lstobj_ct_h_g
                mCTHNXID = lstobj_ct_h_gg(0).Id
                '
                Load_Grid(lstobj_ct_h_gg)
                '
                SetObjectToControl()
                TongTien()
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

    ''' <summary>
    ''' xu ly btn Huy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler grvPhieuNhapKho.RowCellStyle, AddressOf grvPhieuNhapKho_RowCellStyle
            obj_ct_h_nx = New CtHNx
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            'txtCT_SO.Text = Nothing
            'txtCT_SO.Properties.ReadOnly = True
            grlLoaiPhieuNhap.Properties.ReadOnly = True
            ClearPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly btn Sua
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            If obj_ct_h_nx.DaKhoaSo = 0 Then
                Try
                    ' Set state
                    m_InputState = DataInputState.EditMode

                    ' Set trang thai control
                    DatTrangThaiControl()
                    TongTien()

                Catch ex As Exception
                    Message_Error(ex)
                End Try
            Else
                Message_Information("Chứng từ đã được khóa nên không thể sửa!")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly btn in chung tu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInCtu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLoaiPhieuNhap), HtLoaichungtu)
            Dim obj_form As Form = CType(ObjectFactory.GetObject("frmKho_Input", New Object() {mCTHNXID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
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
                'Control_SetState(GroupControl3, DataInputState.AddMode)
                Control_SetState(GroupControl4, DataInputState.AddMode)
                grvPhieuNhapKho.OptionsBehavior.Editable = True
                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = False
                btnPri.Enabled = False
                btnCan.Enabled = True
                btnSea.Enabled = False
                grcLPN_Hnx.Enabled = False
                'txtCT_SO.Properties.ReadOnly = True
                grlLoaiPhieuNhap.Properties.ReadOnly = True
                navWelding1.Enabled = False

            Case DataInputState.EditMode
                Control_SetState(GroupControl1, DataInputState.EditMode)
                Control_SetState(GroupControl2, DataInputState.EditMode)
                'Control_SetState(GroupControl3, DataInputState.EditMode)
                Control_SetState(GroupControl4, DataInputState.EditMode)
                grvPhieuNhapKho.OptionsBehavior.Editable = True
                btnAdd.Enabled = False
                btnMod.Enabled = False
                btnSav.Enabled = True
                btnDel.Enabled = True
                btnPri.Enabled = True
                btnCan.Enabled = True
                btnSea.Enabled = False
                grcLPN_Hnx.Enabled = False
                'txtCT_SO.Properties.ReadOnly = True
                grlLoaiPhieuNhap.Properties.ReadOnly = True
                navWelding1.Enabled = False
            Case Else
                Control_SetState(GroupControl1, DataInputState.ViewMode)
                Control_SetState(GroupControl2, DataInputState.ViewMode)
                'Control_SetState(GroupControl3, DataInputState.ViewMode)
                Control_SetState(GroupControl4, DataInputState.ViewMode)
                grvPhieuNhapKho.OptionsBehavior.Editable = False
                btnAdd.Enabled = True
                btnMod.Enabled = True
                btnSav.Enabled = False
                btnPri.Enabled = True
                btnDel.Enabled = True
                btnCan.Enabled = False
                btnSea.Enabled = True
                grcLPN_Hnx.Enabled = True
                grlLoaiPhieuNhap.Properties.ReadOnly = True
                navWelding1.Enabled = True
        End Select
        GroupControl1.Focus()
        txtTongSoLuong.Properties.ReadOnly = True
        TxtTongTien.Properties.ReadOnly = True
        grlLoaiPhieuNhap.Focus()
    End Sub

    ''' <summary>
    ''' ham xoa trang data tren form
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearPage()

        Control_ClearData(GroupControl1)
        Control_ClearData(GroupControl2)
        cboDmKhachHang.EditValue = Nothing
        C_SoChungTu_RP.Text = ""
        txtDIEN_GIAI.Text = ""
        txtNgayCt.EditValue = DateTime.Now
        cboTyGia.ItemIndex = 2
        txtTY_GIA.Text = 1
        TxtTongTien.Text = Nothing
        txtTongSoLuong.Text = Nothing
        'UR_STATUS.cboStatus.EditValue = 1
        UR_STATUS.Set_Status(1)
        txtTongSoLuong.Enabled = False
        TxtTongTien.Enabled = False
        grlLoaiPhieuNhap.EditValue = obj_lct.MaLoaiCt
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.Add(New CtDNx)
        grcPhieuPhapKho.DataSource = lstobj_ct_d_nx
        grvPhieuNhapKho.RefreshData()

    End Sub

#End Region

#Region "Events"

    ''' <summary>
    ''' xu ly bind data vao luoi khac khi dang focus row hien tai
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
    ''' trong su kien cua luoi xu ly cac gia tri tren luoi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuNhapKho_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvPhieuNhapKho.CellValueChanged
        Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle), CtDNx)
        Select Case e.Column.Name
            Case "HanghoaId"
                Dim objHanghoa As DmHanghoa = CType(ComboHelper.GetSelectData(cboHanghoa, gridctdnx.HanghoaId), DmHanghoa)
                If (objHanghoa IsNot Nothing) Then
                    gridctdnx.KyHieuHanghoa = objHanghoa.KyHieu
                    gridctdnx.MaHanghoa = objHanghoa.MaHanghoa
                    gridctdnx.TenHanghoa = objHanghoa.TenHanghoa
                    gridctdnx.TenDvt = objHanghoa.TenDvt
                    gridctdnx.ViTri = objHanghoa.ViTri

                    Dim strMaTaiKhoan As String = objHanghoa.MdTkKho
                    If String.IsNullOrEmpty(strMaTaiKhoan) Then
                    Else
                        Dim strMTK() As String = strMaTaiKhoan.Split(";")
                        strMaTaiKhoan = strMTK(0)
                        Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                        obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                        ' kiem tra loai phieu xuat hay nhap kho de bind ma tai khoan kho lien quan
                        If objLoaiChungTu.KhoXuat = 1 Then
                            gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiavon = obj_taikhoan.Id
                        Else
                            gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TknGiavon = obj_taikhoan.Id
                        End If

                    End If
                End If
            Case "KhoNhapId"
                Dim cboKhoNhap As DmKho = CType(cboMaKho.GetDataSourceRowByKeyValue(gridctdnx.KhoNhapId), DmKho)
                If (gridctdnx Is Nothing) Then
                    Return
                End If

            Case "KhoXuatId"
                Dim cboKhoXuat As DmKho = CType(cboMakhoxuat.GetDataSourceRowByKeyValue(gridctdnx.KhoXuatId), DmKho)
                If (gridctdnx Is Nothing) Then
                    Return
                End If
                If (gridctdnx.HanghoaId = Null.NullGuid) Then
                Else
                    gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, txtNgayCt.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                End If
            Case "TKN_GIAVON"
                Dim cboTKNGiaVon As DmTaikhoan = CType(cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TknGiavon), DmTaikhoan)
                If (gridctdnx Is Nothing) Then
                    Return
                End If
                gridctdnx.MaTknGiavon = cboTKNGiaVon.MaTaikhoan
                'gridctdnx.TKN_GIAVON = cboTKNGiaVon.TAIKHOAN_ID

            Case "TKC_GIAVON"
                Dim cboTKCGiaVon As DmTaikhoan = CType(cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TkcGiavon), DmTaikhoan)
                If (gridctdnx Is Nothing) Then
                    Return
                End If
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
            Case "ID_DM_KHOANPHI_CO"
                Dim cboKPhi As DmKhoanphi = CType(cboKhoanphi.GetDataSourceRowByKeyValue(gridctdnx.IdDmKhoanphiCo), DmKhoanphi)
                If (gridctdnx Is Nothing) Then
                    Return
                End If
                ' gridctdnx.MA_TKC_GIAVON = cboKPhi.MA_TAIKHOAN

        End Select

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
                    grvPhieuNhapKho.RefreshData()
                End If
            Else
                If Not (OnLoadData) Then
                    txtTY_GIA.Text = _LsTygiaService.GetTyGiaNgoaiTe(cboTyGia.EditValue, txtNgayCt.EditValue)
                End If
                SetColNgoaiTe(True)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        grvPhieuNhapKho.Columns("DonGiaVonNte").Visible = ngoaite
        grvPhieuNhapKho.Columns("GiaVonNt").Visible = ngoaite
        grvPhieuNhapKho.Columns("DonGiaVon").ColumnEdit.ReadOnly = ngoaite
        If (ngoaite) Then
            txtTY_GIA.Enabled = True
        Else
            txtTY_GIA.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' xu ly su kien enter xuong dong tren luoi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuNhapKho_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvPhieuNhapKho.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If (GridHelper.CheckAddNewRow(grvPhieuNhapKho)) Then
                    lstobj_ct_d_nx.Add(New CtDNx)
                    grvPhieuNhapKho.RefreshData()
                    SetFocus_FirstCell()
                End If
        End Select
        '
        If e.KeyCode = Keys.F12 Then
            Dim FormID As String = Me.Name + "?" + "MA_LOAI_CT=" + m_Ma_Loai_CT
            Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
            ConfigGrid.GetGridColInfo(grvPhieuNhapKho, lstColInfo)
            Dim f As New ConfigGrid
            If f.Show_Form(grvPhieuNhapKho.Name, FormID, lstColInfo) Then
                ConfigGrid.GridConfig(FormID, grvPhieuNhapKho.Name, grvPhieuNhapKho)
            End If
        End If
    End Sub

    Private Sub SetFocus_FirstCell()
        grvPhieuNhapKho.FocusedRowHandle = grvPhieuNhapKho.RowCount - 1
        grvPhieuNhapKho.SelectRow(Handle)
        Try
            grvPhieuNhapKho.FocusedColumn = grvPhieuNhapKho.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' xu ly phim tat tren form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuNhapKho_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If Commons.CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
                    Exit Select
                Case Keys.F4
                    'Try
                    'kiem tra dang o trang thai gi de xet xem co su dung them dong ko
                    If m_InputState <> DataInputState.ViewMode Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        SetFocus_FirstCell()
                        grvPhieuNhapKho.RefreshData()
                    End If
                    'Catch ex As Exception
                    '    Message_Error(ex)
                    'End Try
                    Exit Select
                Case Keys.F8
                    'Try
                    'kiem tra dang o trang thai gi de xet xem co su dung xoa dong ko
                    If m_InputState <> DataInputState.ViewMode Then
                        If grvPhieuNhapKho.RowCount <> 0 Then
                            DeleteRow()
                            TongTien()
                        Else
                            Message_Warning("Không có bản ghi nào được chọn!")
                        End If
                    End If
                    'Catch ex As Exception
                    '    Message_Error(ex)
                    'End Try
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
    ''' ham xu ly cua form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuNhapKho_ChiTiet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GFilter_HANGHOA_ID_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.AfterFilter, Gfilter_MA_TKC_GIAVON.AfterFilter, Gfilter_MA_TKN_GIAVON.AfterFilter
        Try
            Dim rowHandle As Integer = grvPhieuNhapKho.FocusedRowHandle
            Dim columnName As String = grvPhieuNhapKho.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle), CtDNx)
            Select Case columnName
                Case "HanghoaId"
                    'Gan vao GridView
                    gridctdnx.TenHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(2)
                    gridctdnx.MaHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(3)
                    gridctdnx.KyHieuHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(1)
                    gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                    gridctdnx.TenDvt = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(4)
                    gridctdnx.ViTri = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(9)
                    ' bind ma tai khoan no va co theo hang hoa co ma TK kho
                    Dim strMaTaiKhoan As String = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(8)
                    If String.IsNullOrEmpty(strMaTaiKhoan) Then
                    Else
                        Dim strMTK() As String = strMaTaiKhoan.Split(";")
                        strMaTaiKhoan = strMTK(0)
                        Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                        obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                        ' kiem tra loai phieu xuat hay nhap kho de bind ma tai khoan kho lien quan
                        If objLoaiChungTu.KhoXuat = 1 Then
                            gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiavon = obj_taikhoan.Id
                        Else
                            gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TknGiavon = obj_taikhoan.Id
                        End If

                    End If

                    If (gridctdnx.HanghoaId = Null.NullGuid) Then
                    Else
                        gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, txtNgayCt.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                    End If

                    grvPhieuNhapKho.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa)
                Case "MaTknGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTknGiavon = Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    grvPhieuNhapKho.SetRowCellValue(rowHandle, "MaTknGiavon", gridctdnx.MaTknGiavon)
                Case "MaTkcGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTkcGiavon = Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    grvPhieuNhapKho.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon)
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GFilter_HANGHOA_ID_ClearFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilterEdit_HANGHOA_ID.ClearDataFilter, Gfilter_MA_TKC_GIAVON.ClearDataFilter, Gfilter_MA_TKN_GIAVON.ClearDataFilter
        Try

            Dim rowHandle As Integer = grvPhieuNhapKho.FocusedRowHandle
            Dim columnName As String = grvPhieuNhapKho.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle), CtDNx)
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
                    If Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_MA_TKN_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MaTkcGiavon"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckEdit1.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub EnterNext(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTY_GIA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA.EditValueChanged
        Try
            Try
                For Each gridctdnx As CtDNx In lstobj_ct_d_nx

                    If cboTyGia.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                        gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.GiaVonNt) * Decimal.Parse(txtTY_GIA.Text)
                        gridctdnx.DonGiaVon = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(txtTY_GIA.Text)
                    Else
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.DonGiaVon) * Decimal.Parse(gridctdnx.SoLuong)
                    End If

                    gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)

                    TongTien()
                Next
                grvPhieuNhapKho.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị quá lớn!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub GFilterEdit_HANGHOA_ID_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles GFilterEdit_HANGHOA_ID.FisrtBinddata
        Try
            Dim gridctdnx As CtDNx = CType(grvPhieuNhapKho.GetRow(grvPhieuNhapKho.FocusedRowHandle), CtDNx)
            Select Case grvPhieuNhapKho.FocusedColumn().Name
                Case "HanghoaId"
                    If GFilterEdit_HANGHOA_ID.C_DATA_SOURCE Is Nothing Then
                        If Kry_DATASOURE Is Nothing Then
                            GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                        Else
                            GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
                        End If
                        If (gridctdnx.KhoXuatId = Null.NullGuid) Then
                        Else
                            gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, txtNgayCt.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                        End If
                        GFilterEdit_HANGHOA_ID.Editors.A_DATA_SOURCE = GFilterEdit_HANGHOA_ID.C_DATA_SOURCE
                    End If
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


    Private Sub Gfilter_MA_TKN_GIAVON_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles Gfilter_MA_TKN_GIAVON.FisrtBinddata, Gfilter_MA_TKC_GIAVON.FisrtBinddata
        Try
            Select Case grvPhieuNhapKho.FocusedColumn().Name
                Case "MaTknGiavon"
                    If Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE Is Nothing Then
                        If Ji_DATASOURE Is Nothing Then
                            Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                        Else
                            Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
                        End If
                        Gfilter_MA_TKN_GIAVON.Editors.A_DATA_SOURCE = Gfilter_MA_TKN_GIAVON.C_DATA_SOURCE
                    End If
                Case "MaTkcGiavon"
                    If Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE Is Nothing Then
                        If Ji_DATASOURE Is Nothing Then
                            Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                        Else
                            Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE
                        End If
                        Gfilter_MA_TKC_GIAVON.Editors.A_DATA_SOURCE = Gfilter_MA_TKC_GIAVON.C_DATA_SOURCE
                    End If
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvPhieuNhapKho_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = grvPhieuNhapKho.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "KyHieuHanghoa"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "KhoXuatId"
                    If VnsCheck.IsNullGuid(VnsConvert.CGuid(val.ToString)) Then
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


