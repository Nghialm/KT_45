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

Public Class frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet
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
    Private obj_ct_h_nx As CtHNx = New CtHNx()
    Private obj_ct_d_nx As CtDNx = New CtDNx()
    Private lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private del_lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private maCT As String
    Private closeForm As Boolean = False
    Public obj_lct As HtLoaichungtu = New HtLoaichungtu()
    Public lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Private Kry_DATASOURE As DataTable
    Private Ji_DATASOURE As DataTable
    Private OnLoadData = False
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    Dim msgTTChungTu As String = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!"
    Private m_LoaiCtID As Guid
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
            m_LoaiCtID = obj_lct.Id
            If lstcthg IsNot Nothing Then
                lstobj_ct_h_gg = lstcthg
            End If
            'Control_SetRequire(dteNGAY_GHI, True)
            UR_STATUS.LCT_STATUS = obj_lct.Id
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
    Private Sub Init_Data()
        OnLoadData = True
        Try
            Select Case m_InputState
                Case DataInputState.AddMode
                    BindLookUpNX()
                    SetColNgoaiTe(chkNGOAI_TE.Checked)
                    lstobj_ct_d_nx.Add(New CtDNx())
                    grcPhieuTraHang.DataSource = lstobj_ct_d_nx
                    SetVisible()
                    dteNGAY_GHI.EditValue = DateTime.Now
                    dteNGAY_CT.EditValue = DateTime.Now
                    DatTrangThaiControl()
                Case Else
                    BindLookUpNX()
                    SetObjectToControl()
                    SetVisible()
                    DatTrangThaiControl()
                    'TongTien()
            End Select
            Load_Grid(lstobj_ct_h_gg)
        Catch ex As Exception
            Message_Error(ex)
        End Try
        OnLoadData = False
    End Sub

    Private Sub SetVisible()
        If obj_lct.DmPhongban <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmPhongbanCo").Visible = False
        End If
        If obj_lct.DmKhoanphi <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmKhoanphiCo").Visible = False
        End If
        If obj_lct.DmTudo1 <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmTudo1Co").Visible = False
        End If
        If obj_lct.DmTudo2 <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmTudo2Co").Visible = False
        End If
        If obj_lct.DmTudo3 <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmTudo3Co").Visible = False
        End If
        If obj_lct.DmTudo4 <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmTudo4Co").Visible = False
        End If
        If obj_lct.DmTudo5 <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmTudo5Co").Visible = False
        End If
        If obj_lct.DmVuviec <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmVuviecCo").Visible = False
        End If
        If obj_lct.DmPtqt <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmPtqtCo").Visible = False
        End If
        If obj_lct.DmHopdong <> 1 Then
            grcPhieuTraHang_View.Columns("IdDmHopdongCo").Visible = False
        End If
        txtTienHang.Enabled = False
        txtTongCong.Enabled = False
        txtThueTTDB.Enabled = False

    End Sub

    Private Sub BindLookUpNX()
        Try

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

            Dim tklienquan = obj_lct.MaTkNoLq
            GFilter_TK.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tklienquan)

            'GFilter.C_DATA_SOURCE = DM_KhangBO.Instance().GetAllBy_CO_SU_DUNG_DS(Generals.DON_VI.Id).Tables(0)

            'Kry_DATASOURE = DM_HanghoaBO.Instance.GetAllByDonviID(Generals.DON_VI.Id).Tables(0)
            Ji_DATASOURE = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            'GFilter_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
            GFilter_MA_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE

            GFilter_TK.C_DATA_SOURCE = Ji_DATASOURE
            Dim tkthuegtgt As String = obj_lct.TkThueNgamdinh
            GfilterTKN_THUE_GTGT.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tkthuegtgt)
            GfilterTKN_THUE_GTGT.C_DATA_SOURCE = Ji_DATASOURE

            'Bind mã hàng
            Dim lstMaHang As List(Of DmHanghoa) = New List(Of DmHanghoa)
            lstMaHang.AddRange(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
            cboHANGHOA_ID.DataSource = lstMaHang
            cboHANGHOA_ID.DisplayMember = "KyHieu"
            cboHANGHOA_ID.ValueMember = "Id"
            cboHANGHOA_ID.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã hàng hóa"))
            cboHANGHOA_ID.Columns.Add(New LookUpColumnInfo("TenHanghoa", "Tên hàng hóa"))

            'Bind Số hợp đồng
            Dim lsthopdongTemp As List(Of DmHopdong) = New List(Of DmHopdong)
            lsthopdongTemp.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lsthopdong As List(Of DmHopdong) = New List(Of DmHopdong)
            Dim objhopdong As DmHopdong = New DmHopdong
            lsthopdong.Add(objhopdong)
            lsthopdong.AddRange(lsthopdongTemp)
            cboHopDong.DataSource = lsthopdong
            cboHopDong.DisplayMember = "KyHieu"
            cboHopDong.ValueMember = "Id"
            cboHopDong.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã hợp đồng"))
            cboHopDong.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

            'Bind TK No
            Dim lstTKNo As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
            lstTKNo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            cboMA_TKC_GIAVON.DataSource = lstTKNo
            cboMA_TKC_GIAVON.DisplayMember = "MaTaikhoan"
            cboMA_TKC_GIAVON.ValueMember = "Id"
            cboMA_TKC_GIAVON.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
            cboMA_TKC_GIAVON.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))

            ''Bind mã kho
            Dim lstMaKho As List(Of DmKho) = New List(Of DmKho)()
            lstMaKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
            cboMaKho.DataSource = lstMaKho
            cboMaKho.DisplayMember = "KyHieu"
            cboMaKho.ValueMember = "Id"
            cboMaKho.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã kho"))
            cboMaKho.Columns.Add(New LookUpColumnInfo("TenKho", "Tên kho"))

            'Bind danh muc ngoai te
            Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
            lstNgoaite.AddRange(_DmNgoaiteService.GetAllByDonviID(Generals.DonviID))
            cboNgoaiTe.Properties.DisplayMember = "KyHieu"
            cboNgoaiTe.Properties.ValueMember = "Id"
            cboNgoaiTe.Properties.DataSource = lstNgoaite
            cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            txtTY_GIA.Text = "1"

            'Bind vụ việc
            Dim lstVuViecTemp As List(Of DmVuviec) = New List(Of DmVuviec)
            lstVuViecTemp.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
            Dim lstVuviec As List(Of DmVuviec) = New List(Of DmVuviec)
            Dim objvuviec As DmVuviec = New DmVuviec
            lstVuviec.Add(objvuviec)
            lstVuviec.AddRange(lstVuViecTemp)
            cboVuviec.DataSource = lstVuviec
            cboVuviec.DisplayMember = "KyHieu"
            cboVuviec.ValueMember = "Id"
            cboVuviec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
            cboVuviec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))

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
            Dim lstPhongBanTemp As List(Of DmPhongban) = New List(Of DmPhongban)()
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
            Dim lstkhoanphiTemp As List(Of DmKhoanphi) = New List(Of DmKhoanphi)()
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

    Private Function BindTaiKhoan(ByVal tklienquan As String) As List(Of DmTaikhoan)
        Dim ListTK As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        ListTK.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))
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
            ListTKFilter.AddRange(From i As DmTaikhoan In ListTK _
                                 Where i.MaTaikhoan.StartsWith(matk) _
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
            If (GFilter.ListEditValue.Count > 0) Then
                obj_ct_h_nx.KhangId = VnsConvert.CGuid(GFilter.ListEditValue(0))
                obj_ct_h_nx.MaKhang = GFilter.ListEditValue(2)
                obj_ct_h_nx.KyHieuKhang = GFilter.ListEditValue(3)
            End If

            'obj_ct_h_nx.MST_KHANG = GFilter.ListEditValue(4)
            'obj_ct_h_nx.TEN_KHANG = GFilter.ListEditValue(1)
            obj_ct_h_nx.MstKhang = txtMA_SO_THUE.Text.Trim
            obj_ct_h_nx.TenKhang = txtTEN_KHANG.Text.Trim
            obj_ct_h_nx.DiaChi = txtDIA_CHI.Text

            obj_ct_h_nx.MaLoaiCt = obj_lct.MaLoaiCt
            obj_ct_h_nx.IdLoaiCt = obj_lct.Id
            obj_ct_h_nx.KyHieuLoaiCt = obj_lct.KyHieu

            obj_ct_h_nx.TyGia = VnsConvert.CDecimal(txtTY_GIA.Text)
            obj_ct_h_nx.MaNte = cboNgoaiTe.Text
            obj_ct_h_nx.NteId = VnsConvert.CGuid(cboNgoaiTe.EditValue)
            obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(Not (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))

            obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text.Trim()
            obj_ct_h_nx.NgayGhi = dteNGAY_GHI.DateTime
            obj_ct_h_nx.NgayCt = dteNGAY_CT.DateTime
            'obj_ct_h_nx.NGAY_TAO = DateTime.Now
            obj_ct_h_nx.DonviId = Generals.DON_VI.Id
            obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi
            obj_ct_h_nx.SoDu = 0
            'obj_ct_h_nx.GHI = txtGHI.Text
            obj_ct_h_nx.Ghi = Convert.ToDecimal(UR_STATUS.Value_info.ParameterValue)
            obj_ct_h_nx.SoTien = Decimal.Parse(txtTongCong.Text)
            obj_ct_h_nx.BxDiengiai2 = txtBX_DIENGIAI_2.Text.Trim()

            Dim flgUpdate = True
            Select Case m_InputState
                Case DataInputState.AddMode
                    Dim strmMonth As String
                    strmMonth = Month(dteNGAY_CT.DateTime).ToString
                    Dim strYear As String
                    strYear = Year(dteNGAY_CT.DateTime).ToString
                    C_SoChungTu_RP.r_SoCTPREFIX(obj_lct.Id, strmMonth, strYear, Generals.DON_VI.Id)
                    obj_ct_h_nx.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                    obj_ct_h_nx.PrefixCt = C_SoChungTu_RP.PREFIX
                    flgUpdate = False
                    'obj_ct_h_nx = InsertCT_H_Nx(obj_ct_h_nx)
                Case Else
                    'UpdateCT_H_Nx(obj_ct_h_nx)
            End Select

            'lay gia trị control tren luoi gan cho obj

            For Each objctdnx As CtDNx In lstobj_ct_d_nx
                'objctdnx.CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID

                If (String.IsNullOrEmpty(GFilter_TK.ListEditValue(0))) Then
                Else
                    objctdnx.MaTknGiavon = GFilter_TK.ListEditValue(1)
                    objctdnx.TknGiavon = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
                    objctdnx.MaTknThueGtgt = GFilter_TK.ListEditValue(1)
                    objctdnx.TknThueGtgt = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
                End If

                objctdnx.MaTkcThueGtgt = GfilterTKN_THUE_GTGT.ListEditValue(1)
                objctdnx.TkcThueGtgt = VnsConvert.CGuid(GfilterTKN_THUE_GTGT.ListEditValue(0))

                If (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) Then
                    objctdnx.DonGiaVonNte = 0
                End If

                objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang
                objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId
                objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang
                objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang

                objctdnx.IdDmKhoanphiNo = objctdnx.IdDmKhoanphiCo
                objctdnx.IdDmTudo1No = objctdnx.IdDmTudo1Co
                objctdnx.IdDmTudo2No = objctdnx.IdDmTudo2Co
                objctdnx.IdDmTudo3No = objctdnx.IdDmTudo3Co
                objctdnx.IdDmTudo4No = objctdnx.IdDmTudo4Co
                objctdnx.IdDmTudo5No = objctdnx.IdDmTudo5Co
                objctdnx.IdDmHopdongNo = objctdnx.IdDmHopdongCo
                objctdnx.IdDmPtqtNo = objctdnx.IdDmPtqtCo
                objctdnx.IdDmVuviecNo = objctdnx.IdDmVuviecCo
                objctdnx.IdDmPhongbanNo = objctdnx.IdDmPhongbanCo
                objctdnx.Xuat = obj_lct.KhoXuat
                objctdnx.SoDu = 0
                'If objctdnx.CTD_NX_ID = Null.NullGuid.ToString Or objctdnx.CTD_NX_ID Is Nothing Then
                '    InsertCT_D_Nx(objctdnx)
                'Else
                '    UpdateCT_D_Nx(objctdnx)
                'End If
            Next
            'gan lại gia tri sct sau khi lưu dl
            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
            _CtHNxService.SaveChungTuKho(flgUpdate, obj_ct_h_nx, lstobj_ct_d_nx, del_lstobj_ct_d_nx)
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

            SetColNgoaiTe(chkNGOAI_TE.Checked)
            GFilter.Text = obj_ct_h_nx.KyHieuKhang
            GFilter.Tag = obj_ct_h_nx.KhangId
            'grlMA_HOPDONG.EditValue = obj_ct_d_nx.HOPDONG_ID
            C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo
            txtDIA_CHI.Text = obj_ct_h_nx.DiaChi
            txtMA_SO_THUE.Text = obj_ct_h_nx.MstKhang
            txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai
            txtBX_DIENGIAI_2.Text = obj_ct_h_nx.BxDiengiai2
            dteNGAY_CT.DateTime = obj_ct_h_nx.NgayCt
            dteNGAY_GHI.DateTime = obj_ct_h_nx.NgayGhi

            cboNgoaiTe.EditValue = obj_ct_h_nx.NteId
            txtTY_GIA.Text = obj_ct_h_nx.TyGia
            UR_STATUS.Set_Status(obj_ct_h_nx.Ghi)
            txtTEN_KHANG.Text = obj_ct_h_nx.TenKhang
            lstobj_ct_d_nx = New List(Of CtDNx)
            lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(m_CTH_ID))
            If (lstobj_ct_d_nx.Count > 0) Then
                'grlMA_HOPDONG.EditValue = lstobj_ct_d_nx(0).HOPDONG_ID

                GFilter_TK.Text = lstobj_ct_d_nx(0).MaTknGiavon
                GFilter_TK.Tag = lstobj_ct_d_nx(0).TknGiavon

                GfilterTKN_THUE_GTGT.Text = lstobj_ct_d_nx(0).MaTkcThueGtgt
                GfilterTKN_THUE_GTGT.Tag = lstobj_ct_d_nx(0).TkcThueGtgt
            End If
            grcPhieuTraHang.DataSource = lstobj_ct_d_nx
            TongTien()
            ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + maCT, grcPhieuTraHang_View.Name, grcPhieuTraHang_View)

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

    Private Sub TongTien()
        Dim sum As Decimal = 0
        Dim sum1 As Decimal = 0
        Dim sum2 As Decimal = 0

        For i = 0 To grcPhieuTraHang_View.RowCount - 1
            sum = sum + grcPhieuTraHang_View.GetRowCellValue(i, "GiaVon")
            sum2 = sum2 + grcPhieuTraHang_View.GetRowCellValue(i, "SoTienThueGtgt")
        Next
        sum1 = sum + sum2
        txtTienHang.EditValue = sum
        txtThueTTDB.EditValue = sum2
        txtTongCong.EditValue = sum1

    End Sub

    Public Sub ClearPage()
        Control_ClearData(groupControl1)
        txtTEN_KHANG.Text = Nothing
        Control_ClearData(groupControl2)
        lstobj_ct_d_nx = New List(Of CtDNx)
        lstobj_ct_d_nx.Add(New CtDNx)
        grcPhieuTraHang.DataSource = lstobj_ct_d_nx
        grcPhieuTraHang_View.RefreshData()
        UR_STATUS.Set_Status(1)
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA.Text = "1"
        txtTienHang.EditValue = 0
        txtTongCong.EditValue = 0
        txtThueTTDB.EditValue = 0
        C_SoChungTu_RP.Text = ""
        C_SoChungTu_RP.SO_CHUNG_TU = ""
        C_SoChungTu_RP.PREFIX = ""
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
            Return False
        End If

        If (dteNGAY_GHI.DateTime.Date > dteNGAY_CT.DateTime.Date) Then
            Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ")
            Return False
        End If

        If (String.IsNullOrEmpty(GFilter_TK.ListEditValue(0))) Then
            Message_Warning("Tài khoản nợ không hợp lệ")
            Return False
        End If
        If LimitValue.CheckTyGia(Decimal.Parse(txtTY_GIA.Text.Trim)) = False Then
            Message_Warning("Tỷ giá không hợp lệ")
            Return False
        End If

        If txtThueTTDB.Text <> "" And ckeNhapTienThue.Checked Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtThueTTDB.Text)) Then
                Message_Warning("Giá trị nhập vào không hợp lệ!")
                txtThueTTDB.Focus()
                Return False
            End If
        End If
        'vong lap kiem tra cac cot tren luoi
        If grcPhieuTraHang_View.RowCount <> 0 Then
            For Each objctd As CtDNx In lstobj_ct_d_nx
                'kiem tra gia tri null cua cot Hang hoa
                If (objctd.HanghoaId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập mã hàng hóa")
                    Return False
                End If
                'kiem tra gia tri null cua cot kho nhap
                If (objctd.KhoXuatId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa lựa chọn kho xuất")
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

                If LimitValue.CheckFCurrency(objctd.GiaVonNt) = False Then
                    Message_Warning("Đơn giá bán ngoại tệ không hợp lệ")
                    Return False
                End If

                ' kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
                If (objctd.TkcGiavon = Null.NullGuid) Then
                    Message_Warning("Định khoản chưa nhập đủ")
                    Return False
                End If

                'Kiem tra các giá trị số trên lưới
                If LimitValue.CheckQuantity(objctd.SoLuong) = False Then
                    Message_Warning("Số lượng không hợp lệ")
                    Return False
                End If

                If LimitValue.CheckCurrency(objctd.GiaVon) = False Then
                    Message_Warning("Đơn giá vốn không hợp lệ")
                    Return False
                End If
                If LimitValue.CheckTaxRate(objctd.TyLeThueGtgt) = False Then
                    Message_Warning("Tỷ lệ thuế không hợp lệ")
                    Return False
                End If
            Next
        Else
            Message_Warning("Dữ liệu trên lưới chưa có")
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Events"

    Private Sub txtTY_GIA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA.EditValueChanged
        Try
            Try
                For Each gridctdnx As CtDNx In lstobj_ct_d_nx

                    If VnsConvert.CGuid(cboNgoaiTe.EditValue) <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                        gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.GiaVonNt) * Decimal.Parse(txtTY_GIA.Text)
                        gridctdnx.DonGiaVon = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(txtTY_GIA.Text)
                    Else
                        gridctdnx.GiaVon = Decimal.Parse(gridctdnx.DonGiaVon) * Decimal.Parse(gridctdnx.SoLuong)
                    End If

                    gridctdnx.GiaVonNt = Decimal.Parse(gridctdnx.DonGiaVonNte) * Decimal.Parse(gridctdnx.SoLuong)
                    gridctdnx.SoTienThueGtgt = Decimal.Parse(gridctdnx.GiaVon) * Decimal.Parse(gridctdnx.TyLeThueGtgt) / 100

                    TongTien()
                Next
            Catch ex As OverflowException
                Message_Warning("Giá trị quá lớn!")
            End Try
            grcPhieuTraHang_View.RefreshData()
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

    Private Sub grcPhieuTraHang_View_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grcPhieuTraHang_View.CellValueChanged
        Try
            Dim gridctdnx As CtDNx = CType(grcPhieuTraHang_View.GetRow(grcPhieuTraHang_View.FocusedRowHandle), CtDNx)
            Select Case e.Column.Name
                Case "KHO_XUAT_ID"
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
                        gridctdnx.TenThue = dmThue.TenThue
                        grcPhieuTraHang_View.SetRowCellValue(grcPhieuTraHang_View.FocusedRowHandle, "TyLeThueGtgt", dmThue.TyLe)
                    End If

                End If

                If VnsConvert.CGuid(cboNgoaiTe.EditValue) <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                    If e.Column.FieldName.Equals("DonGiaVonNte") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaVonNte _
                                             * gridctdnx.SoLuong
                        gridctdnx.GiaVonNt = Total
                        gridctdnx.GiaVon = Total * Decimal.Parse(txtTY_GIA.Text)

                    End If
                    If e.Column.FieldName.Equals("DonGiaVonNte") Then
                        Dim GiaVND As Decimal = Decimal.Parse(txtTY_GIA.Text) * gridctdnx.DonGiaVonNte
                        gridctdnx.DonGiaVon = GiaVND
                    End If

                Else
                    If e.Column.FieldName.Equals("DonGiaVon") Or e.Column.FieldName.Equals("SoLuong") Then
                        Dim Total As Decimal = gridctdnx.DonGiaVon _
                                             * gridctdnx.SoLuong
                        gridctdnx.GiaVon = Total
                    End If
                End If

                If e.Column.FieldName.Equals("DonGiaVonNte") Or e.Column.FieldName.Equals("SoLuong") Then
                    Dim Total As Decimal = gridctdnx.DonGiaVonNte _
                                         * gridctdnx.SoLuong
                    gridctdnx.GiaVonNt = Total
                End If

                If String.IsNullOrEmpty(gridctdnx.GiaVon) Or String.IsNullOrEmpty(gridctdnx.TyLeThueGtgt) Then
                Else
                    Dim Total1 As Decimal = gridctdnx.TyLeThueGtgt _
                                         * gridctdnx.GiaVon / 100
                    gridctdnx.SoTienThueGtgt = Total1
                End If

                TongTien()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào quá lớn!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetColNgoaiTe(ByVal ngoaite As Boolean)
        grcPhieuTraHang_View.Columns("DonGiaVon").ColumnEdit.ReadOnly = ngoaite
        grcPhieuTraHang_View.Columns("DonGiaVonNte").Visible = ngoaite
        grcPhieuTraHang_View.Columns("GiaVonNt").Visible = ngoaite
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
            AddHandler grcPhieuTraHang_View.RowCellStyle, AddressOf grcPhieuTraHang_View_RowCellStyle
            Me.ValidateChildren()
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
                Exit Sub
            End If

            Dim lst As List(Of DmKho) = New List(Of DmKho)()
            lst = cboMaKho.DataSource
            If Not (_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, lstobj_ct_d_nx, lst, Generals.DON_VI.Id)) Then
                Message_Warning("Không cho phép xuất âm")
                grcPhieuTraHang_View.RefreshData()
                Exit Sub
            End If

            If txtThueTTDB.Text Is Nothing Or txtThueTTDB.Text = "0" Then
            Else
                If (String.IsNullOrEmpty(GfilterTKN_THUE_GTGT.ListEditValue(0))) Then
                    Message_Warning("Nhập tỷ lệ thuế nhưng không nhập tài khoản thuế")
                    Exit Sub
                End If
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")

            ckeNhapTienThue.Checked = False

            'Refesh Grid
            m_CTH_ID = obj_ct_h_nx.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h_nx)
            GridHelper.RefreshLeftGrid(grvLPX_Hnx, lstobj_ct_h_gg, editObject, m_InputState)

            'DialogResult = System.Windows.Forms.DialogResult.OK
            m_InputState = DataInputState.ViewMode
            DatTrangThaiControl()
            RemoveHandler grcPhieuTraHang_View.RowCellStyle, AddressOf grcPhieuTraHang_View_RowCellStyle
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteRow()
        Dim gridctdnx As CtDNx = CType(grcPhieuTraHang_View.GetRow(grcPhieuTraHang_View.FocusedRowHandle), CtDNx)
        del_lstobj_ct_d_nx.Add(gridctdnx)
        grcPhieuTraHang_View.DeleteSelectedRows()
        'Message_Information("Xóa thành công")
        TongTien()
    End Sub

    Private Sub grcPhieuTraHang_View_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcPhieuTraHang_View.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(grcPhieuTraHang_View)) Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        grcPhieuTraHang_View.RefreshData()
                        SetFocus_FirstCell()
                    End If
                Case Keys.F12
                    Dim FormID As String = Me.Name + "?" + "MA_LOAI_CT=" + maCT
                    Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                    ConfigGrid.GetGridColInfo(grcPhieuTraHang_View, lstColInfo)
                    Dim f As New ConfigGrid
                    If f.Show_Form(grcPhieuTraHang_View.Name, FormID, lstColInfo) Then
                        ConfigGrid.GridConfig(FormID, grcPhieuTraHang_View.Name, grcPhieuTraHang_View)
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
        Try
            grcPhieuTraHang_View.FocusedRowHandle = grcPhieuTraHang_View.RowCount - 1
            grcPhieuTraHang_View.SelectRow(Handle)

            grcPhieuTraHang_View.FocusedColumn = grcPhieuTraHang_View.VisibleColumns(0)
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
                    Exit Select

                Case Keys.F4
                    If m_InputState <> DataInputState.ViewMode Then
                        lstobj_ct_d_nx.Add(New CtDNx)
                        SetFocus_FirstCell()
                        grcPhieuTraHang_View.RefreshData()
                    End If
                    Exit Select

                Case Keys.F8
                    If m_InputState <> DataInputState.ViewMode Then
                        If grcPhieuTraHang_View.RowCount <> 0 Then
                            DeleteRow()
                            TongTien()
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
            TongTien()
            If obj_ct_h_nx.DaKhoaSo = 0 Then

                m_InputState = DataInputState.EditMode

                DatTrangThaiControl()
            Else
                Message_Information("Chứng từ đã được khóa nên không thể sửa!")
            End If

            groupControl1.Focus()
            dteNGAY_CT.Focus()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = _HtLoaichungtuService.GetById(m_LoaiCtID)
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
                'Control_SetState(GrcHoaDonBanHang, DataInputState.AddMode)
                Control_SetState(groupControl2, DataInputState.AddMode)
                grcPhieuTraHang_View.OptionsBehavior.Editable = True

                GFilter.ENABLES = True
                GFilter_TK.ENABLES = True
                GfilterTKN_THUE_GTGT.ENABLES = True

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
                Control_SetState(groupControl1, DataInputState.EditMode)
                'Control_SetState(GrcHoaDonBanHang, DataInputState.EditMode)
                Control_SetState(groupControl2, DataInputState.EditMode)
                grcPhieuTraHang_View.OptionsBehavior.Editable = True

                GFilter.ENABLES = True
                GFilter_TK.ENABLES = True
                GfilterTKN_THUE_GTGT.ENABLES = True

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
                Control_SetState(groupControl1, DataInputState.ViewMode)
                'Control_SetState(GrcHoaDonBanHang, DataInputState.ViewMode)
                Control_SetState(groupControl2, DataInputState.ViewMode)
                grcPhieuTraHang_View.OptionsBehavior.Editable = False

                GFilter.ENABLES = False
                GFilter_TK.ENABLES = False
                GfilterTKN_THUE_GTGT.ENABLES = False

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

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Try
            If lstobj_ct_h_gg.Count > 0 Then
                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
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
                'DatTrangThaiControl()
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            AddHandler grcPhieuTraHang_View.RowCellStyle, AddressOf grcPhieuTraHang_View_RowCellStyle
            obj_ct_h_nx = New CtHNx
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            ClearPage()
            groupControl1.Focus()
            dteNGAY_CT.Focus()

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
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuXuatTraLaiHangChoNhaSX_ChiTiet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
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
                    grcPhieuTraHang_View.RefreshData()
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

    Private Sub EnterNext(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkNGOAI_TE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkNGOAI_TE.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub checkEdit4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckeNhapTienThue.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub GFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.AfterFilter
        Try
            txtMA_SO_THUE.Text = GFilter.ListEditValue(4)
            txtTEN_KHANG.Text = GFilter.ListEditValue(1)
            txtDIA_CHI.Text = GFilter.ListEditValue(5)
            GFilter.Tag = VnsConvert.CGuid(GFilter.ListEditValue(0))
            If GFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_TK_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter_TK.AfterFilter
        Try
            GFilter_TK.Tag = VnsConvert.CGuid(GFilter_TK.ListEditValue(0))
            If GFilter_TK.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GfilterTKN_THUE_GTGT_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GfilterTKN_THUE_GTGT.AfterFilter
        Try
            GfilterTKN_THUE_GTGT.Tag = VnsConvert.CGuid(GfilterTKN_THUE_GTGT.ListEditValue(0))
            If GfilterTKN_THUE_GTGT.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.ClearFilterData
        txtMA_SO_THUE.Text = String.Empty
        txtTEN_KHANG.Text = String.Empty
        txtDIA_CHI.Text = String.Empty
        GFilter.Tag = VnsConvert.CGuid(String.Empty)
        GFilter.Text = ""
    End Sub

    Private Sub GFilter_HANGHOA_ID_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilter_HANGHOA_ID.AfterFilter, GFilter_MA_TKC_GIAVON.AfterFilter
        Try
            Dim rowHandle As Integer = grcPhieuTraHang_View.FocusedRowHandle
            Dim columnName As String = grcPhieuTraHang_View.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(grcPhieuTraHang_View.GetRow(grcPhieuTraHang_View.FocusedRowHandle), CtDNx)
            Select Case columnName
                Case "HANGHOA_ID"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    'Gan vao GridView
                    If GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.TenHanghoa = GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(2)
                        gridctdnx.MaHanghoa = GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(3)
                        gridctdnx.KyHieuHanghoa = GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                        gridctdnx.TenDvt = GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(4)

                        If (gridctdnx.KhoXuatId = Null.NullGuid) Then
                        Else
                            gridctdnx.TonKho = _CtDNxService.TinhSLTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, gridctdnx.HanghoaId, gridctdnx.KhoXuatId, Generals.DON_VI.Id)
                        End If

                        Dim strMaTaiKhoan As String = GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(5)
                        If String.IsNullOrEmpty(strMaTaiKhoan) Then
                        Else
                            Dim strMTK() As String = strMaTaiKhoan.Split(";")
                            strMaTaiKhoan = strMTK(0)
                            Dim obj_taikhoan As DmTaikhoan = New DmTaikhoan()
                            obj_taikhoan = _DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id)
                            gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan
                            gridctdnx.TkcGiavon = obj_taikhoan.Id
                        End If
                    End If
                    grcPhieuTraHang_View.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa)

                Case "MA_TKC_GIAVON"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        gridctdnx.MaTkcGiavon = GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(1)
                        gridctdnx.TkcGiavon = VnsConvert.CGuid(GFilter_MA_TKC_GIAVON.OwnerEdit.A_LIST_VALUES(0))
                    End If
                    grcPhieuTraHang_View.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon)
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GFilter_HANGHOA_ID_ClearFilter(ByVal senders As Object, ByVal e As EventArgs) Handles GFilter_HANGHOA_ID.ClearDataFilter, GFilter_MA_TKC_GIAVON.ClearDataFilter
        Try
            Dim rowHandle As Integer = grcPhieuTraHang_View.FocusedRowHandle
            Dim columnName As String = grcPhieuTraHang_View.FocusedColumn().Name
            Dim gridctdnx As CtDNx = CType(grcPhieuTraHang_View.GetRow(grcPhieuTraHang_View.FocusedRowHandle), CtDNx)
            Select Case columnName
                Case "HANGHOA_ID"
                    If (gridctdnx Is Nothing) Then
                        Return
                    End If
                    If GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                        'Gan vao GridView
                        gridctdnx.HanghoaId = VnsConvert.CGuid(GFilter_HANGHOA_ID.OwnerEdit.A_LIST_VALUES(0))
                    End If
                Case "MA_TKC_GIAVON"
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

    'REPOSITORY IN GRID
    Private Sub MyRepositoryItem_FirstBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles GFilter_HANGHOA_ID.FisrtBinddata
        Try
            Dim rowHandle As Integer = grcPhieuTraHang_View.FocusedRowHandle
            Dim columnName As String = grcPhieuTraHang_View.FocusedColumn().Name
            LoadDataInGrid(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadDataInGrid(ByVal colName As String)
        Select Case colName
            Case "HANGHOA_ID"
                If GFilter_HANGHOA_ID.C_DATA_SOURCE Is Nothing Then
                    If Kry_DATASOURE Is Nothing Then
                        GFilter_HANGHOA_ID.C_DATA_SOURCE = DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        GFilter_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
                    End If
                    GFilter_HANGHOA_ID.Editors.A_DATA_SOURCE = GFilter_HANGHOA_ID.C_DATA_SOURCE
                End If
            Case Else
        End Select
    End Sub

    'KHANG
    Private Sub GFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFilter.FirstBinddata, GFilter.AfterQuickAdd
        Try
            GFilter.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub GfilterTKN_THUE_GTGT_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GfilterTKN_THUE_GTGT.ClearFilterData
        GfilterTKN_THUE_GTGT.Tag = VnsConvert.CGuid(String.Empty)
        GfilterTKN_THUE_GTGT.Text = ""
    End Sub

#End Region

    Private Sub ckeNhapTienThue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeNhapTienThue.CheckedChanged
        Try
            If ckeNhapTienThue.Checked Then
                txtThueTTDB.Enabled = True
                txtThueTTDB.TabStop = True
                grcPhieuTraHang_View.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = False
            Else
                txtThueTTDB.Enabled = False
                txtThueTTDB.TabStop = True
                grcPhieuTraHang_View.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtThueTTDB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThueTTDB.TextChanged
        Try
            Try
                If Not ckeNhapTienThue.Checked Then
                    Return
                End If

                If txtThueTTDB.Text = "" Or txtTienHang.Text = "" Then
                    Return
                End If

                Dim Tien_Thue_GTGT As Decimal = Decimal.Parse(txtThueTTDB.Text)
                Dim Tien_hang As Decimal = Decimal.Parse(txtTienHang.Text)

                txtTongCong.EditValue = Tien_hang + Tien_Thue_GTGT
                'Phân bổ           
                Dim fn As PhanBoHelper = New PhanBoHelper
                Dim lst_phanBo As List(Of PhanBoHelperInfo) = New List(Of PhanBoHelperInfo)
                Dim obj_phanBo As PhanBoHelperInfo
                lst_phanBo.Clear()
                For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                    obj_phanBo = New PhanBoHelperInfo
                    obj_phanBo.THU_TU = i
                    obj_phanBo.TONG_SO_TIEN = Tien_Thue_GTGT
                    obj_phanBo.TIEN_PB = 0
                    obj_phanBo.SO_TIEN = lstobj_ct_d_nx(i).GiaVon
                    obj_phanBo.HE_SO = 0
                    lst_phanBo.Add(obj_phanBo)
                Next

                lst_phanBo = fn.PhanBo(lst_phanBo)

                For i As Integer = 0 To lstobj_ct_d_nx.Count - 1
                    For Each obj As PhanBoHelperInfo In lst_phanBo
                        If obj.THU_TU = i Then
                            lstobj_ct_d_nx(i).SoTienThueGtgt = obj.TIEN_PB
                            lstobj_ct_d_nx(i).TyLeThueGtgt = Tien_Thue_GTGT / Tien_hang * 100
                            Exit For
                        End If
                    Next
                Next
                grcPhieuTraHang_View.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grcPhieuTraHang_View_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            Dim val As Object = grcPhieuTraHang_View.GetRowCellValue(e.RowHandle, e.Column)
            Select Case e.Column.FieldName
                Case "KyHieuHanghoa"
                    If val = "" Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                    'them ma kho nua
                Case "SoLuong"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "DonGiaVon"
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

