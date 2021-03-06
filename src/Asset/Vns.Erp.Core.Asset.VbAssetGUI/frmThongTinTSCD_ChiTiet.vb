Imports DevExpress.XtraEditors.Controls
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmThongTinTSCD_ChiTiet

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

    Private _DmNguonTscdService As IDmNguonTscdService

    Public Property DmNguonTscdService() As IDmNguonTscdService
        Get
            Return _DmNguonTscdService
        End Get
        Set(ByVal value As IDmNguonTscdService)
            _DmNguonTscdService = value
        End Set
    End Property
    Private _TsCtTscdNvonService As ITsCtTscdNvonService

    Public Property TsCtTscdNvonService() As ITsCtTscdNvonService
        Get
            Return _TsCtTscdNvonService
        End Get
        Set(ByVal value As ITsCtTscdNvonService)
            _TsCtTscdNvonService = value
        End Set
    End Property
    Private _TsTscdPtungService As ITsTscdPtungService

    Public Property TsTscdPtungService() As ITsTscdPtungService
        Get
            Return _TsTscdPtungService
        End Get
        Set(ByVal value As ITsTscdPtungService)
            _TsTscdPtungService = value
        End Set
    End Property
    Private _DmLoaitaisanService As IDmLoaitaisanService

    Public Property DmLoaitaisanService() As IDmLoaitaisanService
        Get
            Return _DmLoaitaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaitaisanService = value
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
    Private _DmPhongbanService As IDmPhongbanService

    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
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
    Private _HtDanhmucService As IHtDanhmucService

    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property
    Private _DmLydoTgTscdService As IDmLydoTgTscdService

    Public Property DmLydoTgTscdService() As IDmLydoTgTscdService
        Get
            Return _DmLydoTgTscdService
        End Get
        Set(ByVal value As IDmLydoTgTscdService)
            _DmLydoTgTscdService = value
        End Set
    End Property
    Private _DmNhomTscdService As IDmNhomTscdService

    Public Property DmNhomTscdService() As IDmNhomTscdService
        Get
            Return _DmNhomTscdService
        End Get
        Set(ByVal value As IDmNhomTscdService)
            _DmNhomTscdService = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Variables"
    Private m_InputState As FormGlobals.DataInputState
    Private m_TSCD_ID As Guid
    Private dm_TSCD As DmTscd = New DmTscd
    Private CT_TSCD As CtTscd = New CtTscd
    Private dt_PhuTung As List(Of TsTscdPtung) = New List(Of TsTscdPtung)
    Private lst_del_PhuTung As List(Of TsTscdPtung) = New List(Of TsTscdPtung)
    Private dt_nguonvon As List(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
    Private lst_del_nguonvon As List(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
    Private obj_nguonVon As New TsCtTscdNvon
    Private obj_PhuTung As New TsTscdPtung
    Private bo_pt As Boolean
    Private bo_nv As Boolean
    Dim tk_chi_phi As String
    Private Ki_hieu As String = ""
    Private nhom1 As String = ""
    Private nhom2 As String = ""
    Private nhom3 As String = ""
    Dim dt_tk As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
#End Region

#Region "Show_form"
    Public Function Show_Form(ByVal p_TSCD_ID As Guid, ByVal eState As DataInputState) As DmTscd
        Try
            Form_SetText(Me, "Thông tin chi tiết", eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_TSCD_ID = p_TSCD_ID
            Control_set_Require()
            Control_SetRequire(txtMA_TSCD1, True)
            Check_view()
            Me.ActiveControl = grlNHOM1
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()

        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return dm_TSCD
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "Private functions"

    Private Sub Check_view()
        If m_InputState = DataInputState.ViewMode Then
            Control_SetState(pn_TSCD_1, DataInputState.ViewMode)
            Control_SetState(pn_TSCD_2, DataInputState.ViewMode)
            Control_SetState(pn_CT_TSCD, DataInputState.ViewMode)
            Control_SetState(grc_PTKT, DataInputState.ViewMode)
            grvNGUON_VON.OptionsBehavior.Editable = False
            grvPHU_TUNG_KEM_THEO.OptionsBehavior.Editable = False
            btnSave.Enabled = False
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub Init_Data()
        BindLookup()
        Select Case m_InputState
            Case DataInputState.AddMode
                Dim obj As TsCtTscdNvon = New TsCtTscdNvon
                obj.LyDoTanggiam = VnsConvert.CGuid(grlLYDO_TANGGIAM.EditValue)

                dt_nguonvon = New List(Of TsCtTscdNvon)
                grcNGUON_VON.DataSource = dt_nguonvon

                dt_PhuTung = New List(Of TsTscdPtung)
                grcPHU_TUNG_KEM_THEO.DataSource = dt_PhuTung
            Case Else
                SetObjectToControl()
        End Select
    End Sub

    Private Sub Control_set_Require()
        Control_SetRequire(txtSO_THANG_SD1, True)
        Control_SetRequire(txtNGUYEN_GIA1, True)
        Control_SetRequire(txtGIA_TRI_CL1, True)
        Control_SetRequire(dteNGAY_BDSD1, True)
        Control_SetRequire(dteNGAY_TANG1, True)
        Control_SetRequire(dtxNGAY_BDKH1, True)
        'Control_SetRequire(txtTY_LE_HAOMON1, True)
        Control_SetRequire(dteNGAY_CT, True)
        Control_SetRequire(txtSO_CT, True)
        Control_SetRequire(dteNGAY_TANG1, True)
        Control_SetRequire(grlMD_TK_CHIPHI, True)
        Control_SetRequire(grlMD_TK_KHAUHAO, True)
        Control_SetRequire(grlMD_TK_TS, True)
    End Sub

    Private Function Check_InPut() As Boolean
        If (txtSO_THANG_SD1.Text.Trim = "" Or txtGIA_TRI_CL1.Text.Trim = "" Or txtNGUYEN_GIA1.Text.Trim = "" Or DB_GetNull(dteNGAY_BDSD1.DateTime).ToString = "" Or txtSO_CT.Text.Trim = "" Or DB_GetNull(dteNGAY_TANG1.DateTime).ToString = "" _
               Or DB_GetString(grlMD_TK_CHIPHI.EditValue) = "" Or DB_GetString(grlMD_TK_KHAUHAO.EditValue) = "" Or DB_GetString(grlMD_TK_TS.EditValue) = "" Or DB_GetNull(dteNGAY_CT.DateTime).ToString = "" Or DB_GetNull(dtxNGAY_BDKH1.DateTime).ToString = "" Or txtMA_TSCD1.Text.Trim = "") Then
            Message_Information("Bạn chưa nhập giá trị cho trường bắt buộc")
            Return False
        End If

        Dim he_so As Decimal = 0

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtNGUYEN_GIA1.Text)) Then
            Message_Warning("Giá trị nguyên giá không hợp lệ")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            txtNGUYEN_GIA1.Focus()
            Return False
        End If

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtGIA_TRI_CL1.Text)) Then
            Message_Warning("Giá trị giá trị còn lại không hợp lệ")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            txtGIA_TRI_CL1.Focus()
            Return False
        End If

        If (DB_GetNull(dtxNGAY_MUA1.DateTime).ToString <> "" And dteNGAY_BDSD1.DateTime < dtxNGAY_MUA1.DateTime) Then
            Message_Warning("Ngày bắt đầu sử dụng phải > ngày mua")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            dteNGAY_BDSD1.Focus()
            Return False
        End If

        If (DB_GetNull(dteNGAY_BDSD1.DateTime).ToString <> "" And dtxNGAY_BDKH1.DateTime < dteNGAY_BDSD1.DateTime) Then
            Message_Warning("Ngày bắt đầu khấu hao >= ngày bắt đầu sử dụng")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            dtxNGAY_BDKH1.Focus()
            Return False
        End If

        If (DB_GetNull(dtxNGAY_MUA1.DateTime).ToString <> "" And dteNGAY_TANG1.DateTime < dtxNGAY_MUA1.DateTime) Then
            Message_Warning("Ngày tăng phải >= ngày mua")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            dteNGAY_TANG1.Focus()
            Return False
        End If

        If (DB_GetNull(dteNGAY_KTKH1.DateTime).ToString <> "" And dteNGAY_KTKH1.DateTime < dtxNGAY_BDKH1.DateTime) Then
            Message_Warning("Ngày kết thúc khấu hao phải >= ngày bắt đầu khấu hao")
            xtpMain.SelectedTabPage = xtpTHONG_TIN_CHINH
            dteNGAY_KTKH1.Focus()
            Return False
        End If

        If txtNGUYEN_GIA1.Text.Trim <> "" And txtGIA_TRI_CL1.Text.Trim <> "" Then
            If Decimal.Parse(txtNGUYEN_GIA1.Text) < Decimal.Parse(txtGIA_TRI_CL1.Text) Then
                Message_Warning("Giá trị còn lại phải nhỏ hơn hoặc bằng nguyên giá!")
                txtNGUYEN_GIA1.Focus()
                Return False
            End If
        End If

        If Not String.IsNullOrEmpty(txtCHIPHI_DV_SD1.Text) Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtCHIPHI_DV_SD1.Text)) Then
                Message_Warning("Giá trị chi phí đưa vào sử dụng không hợp lệ")
                xtpMain.SelectedTabPage = xtpTHONG_TIN_BO_XUNG
                txtCHIPHI_DV_SD1.Focus()
                Return False
            End If
        End If

        If Not String.IsNullOrEmpty(txtCHIPHI_MUA1.Text) Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtCHIPHI_MUA1.Text)) Then
                Message_Warning("Giá trị chi phí mua TSCD không hợp lệ")
                xtpMain.SelectedTabPage = xtpTHONG_TIN_BO_XUNG
                txtCHIPHI_MUA1.Focus()
                Return False
            End If
        End If

        Dim dv As List(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
        dv.AddRange(CType(grvNGUON_VON.DataSource, List(Of TsCtTscdNvon)))
        If (dv.Count <> 0) Then
            For Each drv As TsCtTscdNvon In dv

                If (drv.DmNguonTscdId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa chọn nguồn cho nguồn vốn!")
                    Return False
                End If

                If (drv.TkChiphi = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập tài khoản chi phí cho nguồn vốn!")
                    Return False
                End If

                If drv.HeSoPbKh < 0 Then
                    Message_Warning("Hệ số phải lớn hơn 0")
                    Return False
                Else
                    he_so = he_so + drv.HeSoPbKh
                End If
                'If String.IsNullOrEmpty(DB_GetString(drv("HE_SO_PB_KH"))) Then
                '    Message_Warning("Hệ số phân bổ không được để trống")
                '    Return False
                'Else

                'End If

                If drv.MaTkChiphi = "" Then
                    Message_Warning("Tài khoản chi phí không được để trống")
                    Return False
                End If
            Next

            If (he_so <> 100) Then
                Message_Warning("Tổng hệ số phân bổ của nguồn vốn phải bằng 100%")
                Return False
            End If
        End If

        Dim dv_phutung As List(Of TsTscdPtung) = New List(Of TsTscdPtung)
        dv_phutung.AddRange(CType(grvPHU_TUNG_KEM_THEO.DataSource, List(Of TsTscdPtung)))
        If dv_phutung.Count <> 0 Then
            For Each drv As TsTscdPtung In dv_phutung

                If String.IsNullOrEmpty(drv.TenPtung) Then
                    Message_Warning("Tên phụ tùng không được để trống!")
                    xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO
                    Return False
                End If

                If drv.SoLuong < 0 Or drv.SoLuong >= 1000 Then
                    Message_Warning("Giá trị số lượng nhập vào không hợp lệ!")
                    xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO
                    Return False
                End If
                'If Not String.IsNullOrEmpty(DB_GetString(drv("SO_LUONG"))) Then

                'End If

                If Not LimitValue.CheckVNDCurrency(drv.SoTien) Then
                    Message_Warning("Giá trị số tiền mua vật tư phụ tùng không hợp lệ!")
                    xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO
                    Return False
                End If
                'If Not String.IsNullOrEmpty(DB_GetString(drv("SO_TIEN"))) Then

                'End If

                If Not LimitValue.CheckQuantity(drv.SoTienNte) Then
                    Message_Warning("Giá trị số tiền ngoại tệ mua vật tư phụ tùng không hợp lệ!")
                    xtpMain.SelectedTabPage = xtpPHU_TUNG_KEM_THEO
                    Return False
                End If
                'If Not String.IsNullOrEmpty(DB_GetString(drv("SO_TIEN_NTE"))) Then

                'End If
            Next
        End If
        Return True
    End Function

    Private Sub BindLookup()

        'Dim dr As DataRow

        Dim DON_VI_ID As Guid = Generals.DON_VI.Id
        Dim objColumnDefine As ArrayList

        Dim dt_DM_LoaiTS As List(Of DmLoaitaisan) = New List(Of DmLoaitaisan)
        dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAll())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenLoaitaisan", "Tên tài sản"))
        GridLookupEdit_BindData(grlLOAITAISAN_ID, dt_DM_LoaiTS, "KyHieu", "Id", COMBO_ITEM_REQUIRE, "TenLoaitaisan", txtTenTaiSan, objColumnDefine)

        'bind don vi tinh
        Dim dt_DM_DVT As List(Of DmDvt) = New List(Of DmDvt)
        dt_DM_DVT.AddRange(_DmDvtService.GetAll())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDvt", "Tên đơn vị tính"))
        GridLookupEdit_BindData(grlDVT_ID, dt_DM_DVT, "TenDvt", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
        'bind phong ban
        Dim dt_DM_PHONGBAN As List(Of DmPhongban) = New List(Of DmPhongban)
        dt_DM_PHONGBAN.AddRange(_DmPhongbanService.GetAllByDonviID(DON_VI_ID))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"))
        GridLookupEdit_BindData(grlPHONGBAN_ID, dt_DM_PHONGBAN, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
        ''gọi nhiều lần để cho tránh lặp lại phần "Chọn giá trị"

        'bind tai khoan tai san
        Dim dt As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt.AddRange(_DmTaikhoanService.GetAllByDonviID(DON_VI_ID))
        Dim dt_DM_Tkhoan As IList(Of DmTaikhoan) = dt.ToList()
        objColumnDefine = New ArrayList

        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"))
        GridLookupEdit_BindData(grlMD_TK_TS, dt_DM_Tkhoan, "MaTaikhoan", "MaTaikhoan", COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKTaiSan, objColumnDefine)
        'bind tài khoản khấu hao
        Dim dt_DM_Tkhoan_KH As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt_DM_Tkhoan_KH.AddRange(dt.ToList())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"))
        GridLookupEdit_BindData(grlMD_TK_KHAUHAO, dt_DM_Tkhoan_KH, "MaTaikhoan", "MaTaikhoan", COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKKhauHao, objColumnDefine)
        'Bind tài khoản chi phí
        Dim dt_DM_Tkhoan_CP As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt_DM_Tkhoan_CP.AddRange(dt.ToList())
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"))
        GridLookupEdit_BindData(grlMD_TK_CHIPHI, dt_DM_Tkhoan_CP, "MaTaikhoan", "MaTaikhoan", COMBO_ITEM_REQUIRE, "TenTaikhoan", txtTenTKChiPhi, objColumnDefine)

        'bind tkts nguon von
        Dim dt_tkts As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt_tkts.AddRange(dt.ToList())
        cboTK_TAISAN.DataSource = dt_tkts
        cboTK_TAISAN.DisplayMember = "MaTaikhoan"
        cboTK_TAISAN.ValueMember = "Id"
        cboTK_TAISAN.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboTK_TAISAN.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))
        'bind tkcp nguon von
        dt_tk = dt.ToList()

        Dim dt_tkkh As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        dt_tkkh.AddRange(dt.ToList())
        cboTK_KHAUHAO.DataSource = dt_tkkh
        cboTK_KHAUHAO.DisplayMember = "MaTaikhoan"
        cboTK_KHAUHAO.ValueMember = "Id"
        cboTK_KHAUHAO.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboTK_KHAUHAO.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))
        'bind dm nguon
        Dim dt_DM_nguon As List(Of DmNguonTscd) = New List(Of DmNguonTscd)
        dt_DM_nguon.AddRange(_DmNguonTscdService.GetAllByDonviID(DON_VI_ID))
        cboDM_NGUON_TSCD_ID.DataSource = dt_DM_nguon
        cboDM_NGUON_TSCD_ID.ValueMember = "Id"
        cboDM_NGUON_TSCD_ID.DisplayMember = "KyHieu"
        cboDM_NGUON_TSCD_ID.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDM_NGUON_TSCD_ID.Columns.Add(New LookUpColumnInfo("TenDmNguonTscd", "Tên nguồn vốn"))

        'bind CBO DVT
        cboDVT.DataSource = dt_DM_DVT
        cboDVT.ValueMember = "Id"
        cboDVT.DisplayMember = "KyHieu"
        cboDVT.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDVT.Columns.Add(New LookUpColumnInfo("TenDvt", "Tên đơn vị tính"))

        'bind loai phuong phap tinh khau hao
        Dim lst_KH As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        lst_KH.AddRange(_HtDanhmucService.GetByDoiTuong("PP_TINH_KHAUHAO"))
        objColumnDefine = New ArrayList
        'objColumnDefine.Add(New LookupEdit_ColumnInfo("DANHMUC_ID", "ID"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Tên phương pháp khấu hao"))
        GridLookupEdit_BindData(grlLOAI_PP_KH, lst_KH, "TenDanhmuc", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind Ly do tang giam tai san
        Dim dt_LyDo_Tang_giam As List(Of DmLydoTgTscd) = New List(Of DmLydoTgTscd)
        dt_LyDo_Tang_giam.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(1, DON_VI_ID))

        Dim drlydotg As New DmLydoTgTscd()
        drlydotg.KyHieu = "<Không xác định>"
        drlydotg.Id = Null.NullGuid
        drlydotg.TenLydoTgTscd = ""
        dt_LyDo_Tang_giam.Insert(0, drlydotg)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenLydoTgTscd", "Tên lý do tăng giảm"))
        GridLookupEdit_BindData(grlLYDO_TANGGIAM, dt_LyDo_Tang_giam, "KyHieu", "Id", COMBO_ITEM_REQUIRE, "TenLydoTgTscd", txtTenLyDoTang, objColumnDefine)

        Dim dt_NHOM1 As List(Of DmNhomTscd) = New List(Of DmNhomTscd)
        dt_NHOM1.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 1))
        Dim drnhom1 As New DmNhomTscd
        drnhom1.MaNhomTscd = "<Không xác định>"
        drnhom1.Id = Null.NullGuid
        drnhom1.TenNhomTscd = ""
        dt_NHOM1.Insert(0, drnhom1)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"))
        GridLookupEdit_BindData(grlNHOM1, dt_NHOM1, "MaNhomTscd", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind nhom 2
        Dim dt_NHOM2 As List(Of DmNhomTscd) = New List(Of DmNhomTscd)
        dt_NHOM2.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 2))

        Dim drnhom2 As New DmNhomTscd
        drnhom2.MaNhomTscd = "<Không xác định>"
        drnhom2.Id = Null.NullGuid
        drnhom2.TenNhomTscd = ""
        dt_NHOM2.Insert(0, drnhom2)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"))
        GridLookupEdit_BindData(grlNHOM2, dt_NHOM2, "MaNhomTscd", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind nhom 3
        Dim dt_NHOM3 As List(Of DmNhomTscd) = New List(Of DmNhomTscd)
        dt_NHOM3.AddRange(_DmNhomTscdService.GetbyLOAI_NHOM_TSCD(DON_VI_ID, 3))

        Dim drnhom3 As New DmNhomTscd
        drnhom3.MaNhomTscd = "<Không xác định>"
        drnhom3.Id = Null.NullGuid
        drnhom3.TenNhomTscd = ""
        dt_NHOM3.Insert(0, drnhom3)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomTscd", "Mã nhóm"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomTscd", "Tên nhóm"))
        GridLookupEdit_BindData(grlNHOM3, dt_NHOM3, "MaNhomTscd", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
    End Sub

    Private Function KiemTraMa() As DmTscd
        'Dim lst_ma As List(Of DmTscd) = New List(Of DmTscd)
        Dim ma As String = ""
        Select Case m_InputState
            Case DataInputState.AddMode
                ma = txtMA_TSCD1.Text
            Case DataInputState.EditMode
                If (dm_TSCD.MaTscd <> txtMA_TSCD1.Text) Then
                    ma = txtMA_TSCD1.Text
                End If
        End Select
        Return _DmTscdService.GetByMaTSCD(ma, Generals.DON_VI.Id)
    End Function

    Private Sub GetControlToOBject()
        dm_TSCD.Nhom1 = grlNHOM1.EditValue
        dm_TSCD.Nhom2 = grlNHOM2.EditValue
        dm_TSCD.Nhom3 = grlNHOM3.EditValue
        dm_TSCD.MaTscd = txtMA_TSCD1.Text
        dm_TSCD.TenTscd = txtTEN_TSCD.Text
        dm_TSCD.KyHieu = txtKY_HIEU.Text

        Dim dr_LTS As DmLoaitaisan = CType(ComboHelper.GetSelectData(grlLOAITAISAN_ID), DmLoaitaisan)
        dm_TSCD.LoaitaisanId = dr_LTS.Id
        dm_TSCD.TenLoaitaisan = dr_LTS.TenLoaitaisan
        dm_TSCD.MaLoaitaisan = dr_LTS.MaLoaitaisan
        CT_TSCD.LoaitaisanId = dr_LTS.Id
        CT_TSCD.MaLoaitaisan = dr_LTS.MaLoaitaisan

        Dim dr_TK_TSCD As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_TS), DmTaikhoan)
        If Not (dr_TK_TSCD Is Nothing) Then
            dm_TSCD.MdTkTs = dr_TK_TSCD.MaTaikhoan
        End If

        Dim dr_TK_KhauHao As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_KHAUHAO), DmTaikhoan)
        If Not (dr_TK_KhauHao Is Nothing) Then
            dm_TSCD.MdTkKhauhao = dr_TK_KhauHao.MaTaikhoan
        End If

        Dim dr_TK_CHI_PHI As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_CHIPHI), DmTaikhoan)
        If Not (dr_TK_CHI_PHI Is Nothing) Then
            CT_TSCD.TkChiphi = dr_TK_CHI_PHI.Id
            CT_TSCD.MaTkChiphi = dr_TK_CHI_PHI.MaTaikhoan
            dm_TSCD.MdTkChiphi = dr_TK_CHI_PHI.MaTaikhoan
        End If

        If (VnsConvert.CGuid(grlLYDO_TANGGIAM.EditValue) <> Null.NullGuid) Then
            'Dim dr_LDTG As DmLydoTgTscd = DirectCast(grlLYDO_TANGGIAM.Properties.DataSource, DataTable).Rows(iRowIdx)
            Dim dr_LDTG As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlLYDO_TANGGIAM), DmLydoTgTscd)

            CT_TSCD.LydoTanggiam = dr_LDTG.Id
            CT_TSCD.TenLydoTanggiam = dr_LDTG.TenLydoTgTscd
            CT_TSCD.LydoTanggiam = dr_LDTG.Id
        End If

        If grlDVT_ID.EditValue IsNot Nothing Then
            Dim dr_DVT As DmDvt = CType(ComboHelper.GetSelectData(grlDVT_ID), DmDvt)
            dm_TSCD.TenDvt = dr_DVT.TenDvt
            dm_TSCD.MaDvt = dr_DVT.MaDvt
            CT_TSCD.DvtId = dr_DVT.Id
            CT_TSCD.MaDvt = dr_DVT.MaDvt
            CT_TSCD.TenDvt = dr_DVT.TenDvt
        End If

        If VnsConvert.CGuid(grlPHONGBAN_ID.EditValue) <> Null.NullGuid Then
            Dim dr_PB As DmPhongban = CType(ComboHelper.GetSelectData(grlPHONGBAN_ID), DmPhongban)
            dm_TSCD.TenPhongban = dr_PB.TenPhongban
            dm_TSCD.MaPhongban = dr_PB.MaPhongban
            dm_TSCD.PhongbanId = dr_PB.Id
        End If

        CT_TSCD.NgayCt = dteNGAY_CT.DateTime
        CT_TSCD.SoCt = txtSO_CT.Text

        dm_TSCD.NgayMua = dtxNGAY_MUA1.DateTime
        dm_TSCD.NgayTang = dteNGAY_TANG1.DateTime
        dm_TSCD.NgayBdsd = dteNGAY_BDSD1.DateTime
        dm_TSCD.NgayBdkh = dtxNGAY_BDKH1.DateTime
        dm_TSCD.NgayKtkh = dteNGAY_KTKH1.DateTime
        CT_TSCD.SoThangSd = txtSO_THANG_SD1.Text
        dm_TSCD.NgayGiam = Null.NullDate
        CT_TSCD.ThuTu = 1
        CT_TSCD.TenTscd = dm_TSCD.TenTscd
        CT_TSCD.KyHieuTscd = dm_TSCD.KyHieu
        CT_TSCD.MaTscd = dm_TSCD.MaTscd
        CT_TSCD.NgayBdKh = dm_TSCD.NgayBdkh
        CT_TSCD.NgayKtKh = dteNGAY_KTKH1.DateTime
        CT_TSCD.NguyenGia = Decimal.Parse(txtNGUYEN_GIA1.Text)
        CT_TSCD.GiaTriCl = Decimal.Parse(txtGIA_TRI_CL1.Text)
        dm_TSCD.GiaTriCl = CT_TSCD.GiaTriCl
        dm_TSCD.NguyenGia = CT_TSCD.NguyenGia
        dm_TSCD.SoThangSd = CT_TSCD.SoThangSd

        'CT_TSCD.TY_LE_HAOMON = txtTY_LE_HAOMON1.Text

        'dm_TSCD.MdTkChiphi = grlMD_TK_CHIPHI.EditValue
        'dm_TSCD.MdTkKhauhao = grlMD_TK_KHAUHAO.EditValue
        'dm_TSCD.MdTkTs = grlMD_TK_TS.EditValue

        'grlDVT_ID.EditValue = CT_TSCD.DvtId
        'grlPHONGBAN_ID.EditValue = dm_TSCD.PhongbanId
        'dteNGAY_CT.EditValue = CT_TSCD.NgayCt
        'txtSO_CT.Text = CT_TSCD.SoCt

        'dm_TSCD.MaTscd = txtMA_TSCD1.Text
        'If Not String.IsNullOrEmpty(txtCHIPHI_DV_SD1.Text) Then
        '    dm_TSCD.ChiphiDvSd = Decimal.Parse(txtCHIPHI_DV_SD1.Text)
        'Else
        '    dm_TSCD.ChiphiDvSd = 0
        'End If

        'If Not String.IsNullOrEmpty(txtCHIPHI_MUA1.Text) Then
        '    dm_TSCD.ChiphiMua = Decimal.Parse(txtCHIPHI_MUA1.Text)
        'Else
        '    dm_TSCD.ChiphiMua = 0
        'End If
        'lay cac gia tri con lai
        dm_TSCD.GiamTscd = 0
        dm_TSCD.DonviId = Generals.DON_VI.Id
        dm_TSCD.MaDonvi = Generals.DON_VI.MaDonvi

        dm_TSCD.ChiphiMua = VnsConvert.CDecimal(txtCHIPHI_MUA1.Text)
        dm_TSCD.ChiphiDvSd = VnsConvert.CDecimal(txtCHIPHI_DV_SD1.Text)
        dm_TSCD.ThongsoKythuat = txtTHONGSO_KYTHUAT.Text
        dm_TSCD.NuocSx = txtNUOC_SX.Text
        dm_TSCD.NamSx = VnsConvert.CDecimal(txtNAM_SX1.Text)
        dm_TSCD.LoaiPpKh = grlLOAI_PP_KH.EditValue
        dm_TSCD.HaoMonLkNte = VnsConvert.CDecimal(txtHAO_MON_LK_NTE.Text)
        dm_TSCD.GiaTriClNte = VnsConvert.CDecimal(txtGIA_TRI_CL_NTE.Text)
        dm_TSCD.SanluongCongsuat = VnsConvert.CDecimal(txtSANLUONG_CONGSUAT.Text)
        dm_TSCD.HeSoDieuChinh = VnsConvert.CDecimal(txtHE_SO_DIEU_CHINH.Text)
        dm_TSCD.TyleKhNhanh = VnsConvert.CDecimal(txtTYLE_KH_NHANH.Text)
        dm_TSCD.HaoMonNam = VnsConvert.CDecimal(txtHAO_MON_NAM.Text)
        dm_TSCD.HaoMonNamNte = VnsConvert.CDecimal(txtHAO_MON_NAM_NTE.Text)
        dm_TSCD.HaoMonLkNte = VnsConvert.CDecimal(txtHAO_MON_LK_NTE.Text)

        dm_TSCD.HaoMonLk = VnsConvert.CDecimal(txtHAO_MON_LK.Text)
        CT_TSCD.HaoMonLuyKe = dm_TSCD.HaoMonLk
        CT_TSCD.TyLeHaomon = VnsConvert.CDecimal(txtTY_LE_HAOMON1.Text)
        dm_TSCD.TyleKh = VnsConvert.CDecimal(txtTY_LE_HAOMON1.Text)

        Dim dv_PT As IList(Of TsTscdPtung)
        Dim dv_NV As IList(Of TsCtTscdNvon)

        Select Case m_InputState
            Case DataInputState.AddMode
                dm_TSCD = _DmTscdService.Save(dm_TSCD)
                'lay gia tri DM_TSCD vua insert dua vao CT_TSCD va insert vao CSDL
                'Dim obj_dmtscd_new As DmTscd = New DmTscd()
                CT_TSCD.TscdId = dm_TSCD.Id

                If (dm_TSCD.HaoMonLk <> 0) Then
                    CT_TSCD.HaoMonLuyKe = dm_TSCD.HaoMonLk
                End If

                CT_TSCD.TangTscd = 1
                _CtTscdService.Save(CT_TSCD)

                'insert Nguon von vao CSDL
                dv_NV = CType(grvNGUON_VON.DataSource, IList(Of TsCtTscdNvon))

                If (dv_NV.Count <> 0) Then
                    For Each drv_NV As TsCtTscdNvon In dv_NV
                        'Object_GetDataRawView(obj_nguonVon, drv_NV)
                        drv_NV.CtTscdId = CT_TSCD.Id
                        _TsCtTscdNvonService.Save(drv_NV)
                    Next
                End If

                ''insert phu tung
                dv_PT = CType(grvPHU_TUNG_KEM_THEO.DataSource, IList(Of TsTscdPtung))

                If dv_PT.Count <> 0 Then
                    For Each drw_PT As TsTscdPtung In dv_PT
                        'Object_GetDataRawView(obj_PhuTung, drw_PT)
                        drw_PT.DmTscdId = dm_TSCD.Id
                        _TsTscdPtungService.Save(drw_PT)
                    Next
                End If
            Case Else
                'update DM_TSCD
                _DmTscdService.SaveOrUpdate(dm_TSCD)
                'update CT_TSCD
                _CtTscdService.SaveOrUpdate(CT_TSCD)

                ''Lấy ra những row được sửa chữa và update vào CSDL 
                dv_NV = CType(grvNGUON_VON.DataSource, List(Of TsCtTscdNvon))
                If dv_NV.Count <> 0 Then
                    For Each drw_NV_Update As TsCtTscdNvon In dv_NV
                        'Object_GetDataRawView(obj_nguonVon, drw_NV_Update)
                        drw_NV_Update.CtTscdId = CT_TSCD.Id
                        _TsCtTscdNvonService.SaveOrUpdate(drw_NV_Update)
                    Next
                End If
                ''Lấy ra những row dc delete và delete
                dv_NV = lst_del_nguonvon
                If dv_NV.Count <> 0 Then
                    For Each drw_Delete As TsCtTscdNvon In dv_NV
                        _TsCtTscdNvonService.Delete(drw_Delete)
                    Next
                End If

                ''Update phu phu tung
                ''Lấy ra những rows dc thêm mới khi update và insert vào CSDl
                'dv_PT = Grid_GetAddedRows(grvPHU_TUNG_KEM_THEO)
                'If dv_PT.Count <> 0 Then
                '    For Each drw_PT_new As TsTscdPtung In dv_PT
                '        'Object_GetDataRawView(obj_PhuTung, drw_PT_new)
                '        obj_PhuTung.DmTscdId = dm_TSCD.Id
                '        _TsTscdPtungService.Save(obj_PhuTung)
                '    Next
                'End If
                ''Lấy ra những rows được update khi update và update vào CSDL
                dv_PT = CType(grvPHU_TUNG_KEM_THEO.DataSource, List(Of TsTscdPtung))
                If dv_PT.Count <> 0 Then
                    For Each drw_PT_Update As TsTscdPtung In dv_PT
                        'Object_GetDataRawView(obj_PhuTung, drw_PT_Update)
                        drw_PT_Update.DmTscdId = dm_TSCD.Id
                        _TsTscdPtungService.SaveOrUpdate(drw_PT_Update)
                    Next
                End If
                ''Lấy ra những rows dc delete khi update và delete khỏi CSDL
                dv_PT = lst_del_PhuTung
                If dv_PT.Count <> 0 Then
                    For Each drw_Delete As TsTscdPtung In dv_PT
                        _TsTscdPtungService.Delete(drw_Delete)
                    Next
                End If

        End Select
    End Sub

    Private Sub SetObjectToControl()
        'DM_TSCD
        dm_TSCD = _DmTscdService.GetById(m_TSCD_ID)

        grlNHOM1.EditValue = dm_TSCD.Nhom1
        grlNHOM2.EditValue = dm_TSCD.Nhom2
        grlNHOM3.EditValue = dm_TSCD.Nhom3
        txtMA_TSCD1.Text = dm_TSCD.MaTscd
        txtTEN_TSCD.Text = dm_TSCD.TenTscd
        txtKY_HIEU.Text = dm_TSCD.KyHieu

        grlLOAITAISAN_ID.EditValue = dm_TSCD.LoaitaisanId
        txtTenTaiSan.Text = dm_TSCD.TenLoaitaisan

        'Lay ten tk chi phi
        grlMD_TK_CHIPHI.EditValue = dm_TSCD.MdTkChiphi
        Dim dr_CP As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_CHIPHI), DmTaikhoan)
        If dr_CP IsNot Nothing Then
            txtTenTKChiPhi.Text = dr_CP.TenTaikhoan
        End If
        grlMD_TK_KHAUHAO.EditValue = dm_TSCD.MdTkKhauhao
        'Lay ten Tk khau hao
        Dim dr_KH As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_KHAUHAO), DmTaikhoan)
        If dr_KH IsNot Nothing Then
            txtTenTKKhauHao.Text = dr_KH.TenTaikhoan
        End If

        grlMD_TK_TS.EditValue = dm_TSCD.MdTkTs
        'Lay ten tk tài sản
        Dim dr_TS As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_TS), DmTaikhoan)
        If dr_TS IsNot Nothing Then
            txtTenTKTaiSan.Text = dr_TS.TenTaikhoan
        End If

        CT_TSCD = _CtTscdService.GetByIdDM_TSCD(m_TSCD_ID)
        If (CT_TSCD.LydoTanggiam <> Null.NullGuid) Then
            grlLYDO_TANGGIAM.EditValue = CT_TSCD.LydoTanggiam
            txtTenLyDoTang.Text = CT_TSCD.TenLydoTanggiam
        End If

        grlDVT_ID.EditValue = CT_TSCD.DvtId
        grlPHONGBAN_ID.EditValue = dm_TSCD.PhongbanId
        dteNGAY_CT.EditValue = CT_TSCD.NgayCt
        txtSO_CT.Text = CT_TSCD.SoCt

        If (dm_TSCD.NgayMua Is Nothing) Then
            dtxNGAY_MUA1.EditValue = ""
        Else
            dtxNGAY_MUA1.DateTime = dm_TSCD.NgayMua
        End If
        dteNGAY_TANG1.DateTime = dm_TSCD.NgayTang
        dteNGAY_BDSD1.DateTime = dm_TSCD.NgayBdsd
        dtxNGAY_BDKH1.DateTime = dm_TSCD.NgayBdkh
        If (dm_TSCD.NgayKtkh = DateTime.MinValue) Then
            dteNGAY_KTKH1.EditValue = ""
        Else
            dteNGAY_KTKH1.DateTime = dm_TSCD.NgayKtkh
        End If
        txtSO_THANG_SD1.Text = dm_TSCD.SoThangSd
        txtNGUYEN_GIA1.EditValue = CT_TSCD.NguyenGia
        txtGIA_TRI_CL1.EditValue = CT_TSCD.GiaTriCl
        txtTY_LE_HAOMON1.EditValue = CT_TSCD.TyLeHaomon

        txtCHIPHI_DV_SD1.Text = dm_TSCD.ChiphiDvSd.ToString
        txtCHIPHI_MUA1.Text = dm_TSCD.ChiphiMua.ToString
        txtNAM_SX1.Text = dm_TSCD.NamSx.ToString

        txtCHIPHI_MUA1.Text = dm_TSCD.ChiphiMua.ToString()
        txtCHIPHI_DV_SD1.Text = dm_TSCD.ChiphiDvSd.ToString
        txtTHONGSO_KYTHUAT.Text = dm_TSCD.ThongsoKythuat
        txtNUOC_SX.Text = dm_TSCD.NuocSx
        txtNAM_SX1.Text = dm_TSCD.NamSx
        grlLOAI_PP_KH.EditValue = dm_TSCD.LoaiPpKh

        txtHAO_MON_LK_NTE.Text = ""
        txtGIA_TRI_CL_NTE.Text = ""
        txtSANLUONG_CONGSUAT.Text = ""
        txtHE_SO_DIEU_CHINH.Text = dm_TSCD.HeSoDieuChinh.ToString
        txtTYLE_KH_NHANH.Text = dm_TSCD.TyleKhNhanh.ToString
        txtHAO_MON_NAM.Text = dm_TSCD.HaoMonNam.ToString
        txtHAO_MON_NAM_NTE.Text = dm_TSCD.HaoMonNamNte.ToString
        txtHAO_MON_LK.Text = dm_TSCD.HaoMonLk.ToString()

        'PHU_TUNG
        dt_PhuTung.AddRange(_TsTscdPtungService.GetAllByTSCD_ID(m_TSCD_ID))
        grcPHU_TUNG_KEM_THEO.DataSource = dt_PhuTung
        ''NGUON_VON
        dt_nguonvon.AddRange(TsCtTscdNvonService.GetAllByCT_TSCD_ID(CT_TSCD.Id))
        grcNGUON_VON.DataSource = dt_nguonvon
    End Sub

    Private Sub Set_TK(ByVal str As String)
        Dim dr As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)

        If dr Is Nothing Then Return

        If DB_GetString(grlMD_TK_TS.EditValue) <> "" Then
            Dim dr_TS As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_TS), DmTaikhoan)

            dr.TkTaisan = dr_TS.Id
            dr.MaTkTaisan = dr_TS.MaTaikhoan
        End If

        If DB_GetString(grlMD_TK_KHAUHAO.EditValue) <> "" Then
            Dim dr_TS As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_KHAUHAO), DmTaikhoan)
            dr.TkKhauhao = dr_TS.Id
            dr.MaTkKhauhao = dr_TS.MaTaikhoan
        End If

        If DB_GetString(grlMD_TK_CHIPHI.EditValue) <> "" Then
            If String.IsNullOrEmpty(str) Then
                Dim dr_CP As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_CHIPHI), DmTaikhoan)

                If dr_CP IsNot Nothing Then
                    
                    Dim dr_Nguonvon As TsCtTscdNvon = CType(ComboHelper.GetSelectData(grvNGUON_VON), TsCtTscdNvon)
                    dr_Nguonvon.MaTkChiphi = dr_CP.MaTaikhoan
                    dr_Nguonvon.TkChiphi = dr_CP.Id
                End If
            End If
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_InPut() Then
                Exit Sub
            End If
            If (Panel_CheckError(pn_TSCD_1) And Panel_CheckError(pn_TSCD_2) And Panel_CheckError(pn_CT_TSCD)) Then
                If (err.GetError(txtMA_TSCD1) = "" And err.GetError(dteNGAY_TANG1) = "" And err.GetError(dtxNGAY_BDKH1) = "" _
                     And err.GetError(dtxNGAY_MUA1) = "" And err.GetError(dteNGAY_KTKH1) = "" And err.GetError(dteNGAY_BDSD1) = "") Then
                    frmProgress.Instance.Thread = AddressOf GetControlToOBject
                    frmProgress.Instance.Show_Progress()
                    frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công")
                    DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    Message_Warning("Bạn không thể lưu, xin kiểm tra lại dữ liệu!")
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRow.Click
        Try
            If (xtpMain.SelectedTabPageIndex = 2 And bo_pt = True And ExistError(grvPHU_TUNG_KEM_THEO)) Then
                Grid_AddRow(grvPHU_TUNG_KEM_THEO)
            ElseIf bo_nv = True And ExistError(grvNGUON_VON) Then
                Grid_AddRow(grvNGUON_VON)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDeRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeRow.Click
        Try
            If (xtpMain.SelectedTabPageIndex = 2) And bo_pt = True And ExistError(grvPHU_TUNG_KEM_THEO) Then
                grvPHU_TUNG_KEM_THEO.DeleteSelectedRows()
            ElseIf bo_nv = True And ExistError(grvNGUON_VON) Then
                grvNGUON_VON.DeleteSelectedRows()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private A, B, C As String

    Private Sub MA_TSCD()
        If VnsConvert.CGuid(grlNHOM1.EditValue) <> Null.NullGuid Then
            A = grlNHOM1.Text.ToString() + "."
        Else
            A = ""
        End If
        If VnsConvert.CGuid(grlNHOM2.EditValue) <> Null.NullGuid Then
            B = grlNHOM2.Text.ToString() + "."
        Else
            B = ""
        End If
        If VnsConvert.CGuid(grlNHOM3.EditValue) <> Null.NullGuid Then
            C = grlNHOM3.Text.ToString() + "."
        Else
            C = ""
        End If
        Dim str As String = ""
        'Dim Ma_TS As Integer = _DmTscdService.GetLikeMa(A + B + C, Generals.DON_VI.Id)
        Dim Ma_TS As Integer = 1

        Select Case m_InputState
            Case DataInputState.AddMode
                If (Ma_TS < 10) Then
                    str = "000" + Ma_TS.ToString()
                ElseIf Ma_TS > 9 And Ma_TS < 100 Then
                    str = "00" + Ma_TS.ToString()
                ElseIf Ma_TS > 99 And Ma_TS < 1000 Then
                    str = "0" + Ma_TS.ToString()
                Else
                    str = Ma_TS.ToString
                End If
                txtMA_TSCD1.Text = A + B + C + str
        End Select
    End Sub

    Private Sub grlNHOM_1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlNHOM1.EditValueChanged
        Try
            Select Case m_InputState
                Case DataInputState.AddMode
                    MA_TSCD()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlNHOM_2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlNHOM2.EditValueChanged
        Try
            Select Case m_InputState
                Case DataInputState.AddMode
                    MA_TSCD()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlNHOM_3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlNHOM3.EditValueChanged
        Try
            Select Case m_InputState
                Case DataInputState.AddMode
                    MA_TSCD()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmThongTinTSCD_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try

            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                Case Keys.F2
                    If m_InputState <> DataInputState.ViewMode Then
                        btnSave_Click(btnSave, e)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLYDO_TANGGIAM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLYDO_TANGGIAM.Validated
        Try
                Dim dr As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlLYDO_TANGGIAM), DmLydoTgTscd)
                If Not dr Is Nothing Then
                    txtTenLyDoTang.Text = dr.TenLydoTgTscd
                End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim str As String = dm_TSCD.Id.ToString()
            Dim lstTscd As List(Of DmTscd) = New List(Of DmTscd)
            lstTscd.Add(dm_TSCD)

            If (str <> "") Then
                Dim rpt As The_TSCD = ObjectFactory.GetObject("The_TSCD", New Object() {str, lstTscd})
                rpt.ShowPreview()
            Else
                Message_Information("Không có bản ghi nào được lựa chọn")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Validate"

    Private Sub txtMA_TSCD_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMA_TSCD1.Validating
        Try
            If Not (KiemTraMa() Is Nothing) Then
                err.SetError(txtMA_TSCD1, "Mã này đã tồn tại")
                err.SetIconAlignment(txtMA_TSCD1, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                err.SetError(txtMA_TSCD1, "")
                e.Cancel = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvPHU_TUNG_KEM_THEO_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grvPHU_TUNG_KEM_THEO.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub
#End Region

#Region "Danh cho grid"

    Private Function CheckGrid(ByVal grv As GridView, ByVal Column As String) As Boolean
        If grv.RowCount <> 0 Then
            Dim dv As DataView = CType(grv.DataSource, DataView)
            'Dim currentRow As DataRow = grv.GetDataRow(i)
            For Each drv As DataRowView In dv
                If DB_GetString(drv(Column).ToString) = "" Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    'Check Validate cho Grid
    Private Function ExistError(ByVal grv As GridView) As Boolean
        For Each gcol As GridColumn In grv.Columns
            If grv.GetColumnError(gcol) <> "" Or grv.GetColumnError(gcol) = Nothing Then
                Return True
            End If
        Next
        '
        Return False
    End Function
    ''' <summary>
    ''' Convert datarowview sang object info
    ''' </summary>
    ''' <param name="objInfo">object info</param>
    ''' <param name="dr">Datarowview</param>
    ''' <remarks></remarks>
    Private Sub Object_GetDataRawView(ByVal objInfo As Object, ByVal dr As DataRowView)
        Dim objPropertyInfo As PropertyInfo
        Dim fieldName As String
        Dim objValue As Object
        '
        For i As Integer = 0 To dr.Row.Table.Columns.Count - 1
            fieldName = dr.Row.Table.Columns(i).ColumnName
            If (fieldName <> "") Then
                objPropertyInfo = Object_GetProperty(objInfo.GetType, fieldName)
                If objPropertyInfo Is Nothing Then
                    Continue For
                End If
                'Kiểu của Cell  ???
                objValue = dr.Row.Item(i)

                If Not objValue Is DBNull.Value Then
                    objValue = Object_SetValueEx(objValue, objPropertyInfo.PropertyType.Name)
                    objPropertyInfo.SetValue(objInfo, objValue, Nothing)
                End If
            End If
        Next
    End Sub

    Private Sub GridAddNewRow(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal byTab As Boolean = False)
        'Chưa có DataSource
        If grv.DataSource Is Nothing Then
            Message_Warning("Chưa có thì thêm vào!!!")
            Exit Sub
        End If

        '--- Trường hợp: Là dòng dưới cùng thực sự
        Select Case grv.Name
            Case "grvNGUON_VON"
                If (GridHelper.CheckAddNewRow(grvNGUON_VON) Or Not byTab) Then
                    If dt_nguonvon Is Nothing Then
                        dt_nguonvon = New List(Of TsCtTscdNvon)()
                    End If

                    dt_nguonvon.Add(New TsCtTscdNvon())
                    grvNGUON_VON.RefreshData()
                End If
            Case "grvPHU_TUNG_KEM_THEO"
                If (GridHelper.CheckAddNewRow(grvPHU_TUNG_KEM_THEO) Or Not byTab) Then
                    If dt_PhuTung Is Nothing Then
                        dt_PhuTung = New List(Of TsTscdPtung)()
                    End If

                    dt_PhuTung.Add(New TsTscdPtung())
                    grvPHU_TUNG_KEM_THEO.RefreshData()
                End If

        End Select
    End Sub

    Private Sub grvNGUON_VON_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvNGUON_VON.KeyDown
        Try
            ''Bắt sự kiện khi enter thêm dòng mới vào gridview
            Dim view As ColumnView = CType(sender, ColumnView)

            If m_InputState = DataInputState.ViewMode Then
                Exit Sub
            End If
            ' Dim obj As DataRowView = grvNGUON_VON.GetDataRow(grvNGUON_VON.FocusedRowHandle)
            Select Case e.KeyCode
                Case Keys.Enter
                    GridAddNewRow(sender, True)
                    Dim str As String = view.GetRowCellDisplayText(grvNGUON_VON.FocusedRowHandle, view.Columns("MaTkChiphi"))
                    Set_TK(str)
                Case Keys.F4
                    If Message_Confirm("Bạn có muốn thêm dòng mới?") Then
                        'Grid_AddRow(sender)
                        GridAddNewRow(sender, False)
                        Dim str As String = view.GetRowCellDisplayText(grvNGUON_VON.FocusedRowHandle, view.Columns("MaTkChiphi"))
                        Set_TK(str)
                    End If
                Case Keys.F8
                    If grvNGUON_VON.RowCount <> 0 Then
                        If Message_Confirm("Bạn có chắc chắn muốn xóa?") Then
                            'Grid_DeleteSelectRows(grvNGUON_VON)
                            Dim delnv As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)
                            lst_del_nguonvon.Add(delnv)
                            Grid_DeleteSelectRows(grvNGUON_VON)
                        End If
                    Else
                        Message_Warning("Không có bản ghi nào được chọn!")
                    End If
                    
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvPHU_TUNG_KEM_THEO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvPHU_TUNG_KEM_THEO.KeyDown
        ''Bắt sự kiện khi enter thêm dòng mới vào gridview
        Try
            If m_InputState <> DataInputState.ViewMode Then
                Select Case e.KeyCode
                    Case Keys.Enter
                        GridAddNewRow(sender, True)
                    Case Keys.F4
                        If Message_Confirm("Bạn có muốn thêm 1 dòng mới") Then
                            GridAddNewRow(sender, False)
                            'Grid_AddRow(grvPHU_TUNG_KEM_THEO)
                        End If
                    Case Keys.F8
                        If grvPHU_TUNG_KEM_THEO.RowCount <> 0 Then
                            If Message_Confirm("Bạn có chắc chắn muốn xóa?") Then
                                Dim delpt As TsTscdPtung = CType(grvPHU_TUNG_KEM_THEO.GetRow(grvPHU_TUNG_KEM_THEO.FocusedRowHandle), TsTscdPtung)
                                lst_del_PhuTung.Add(delpt)
                                Grid_DeleteSelectRows(grvPHU_TUNG_KEM_THEO)
                            End If
                        Else
                            Message_Warning("Không có bản ghi nào được chọn!")
                        End If
                End Select
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvPHU_TUNG_KEM_THEO_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grvPHU_TUNG_KEM_THEO.MouseDown
        bo_nv = False
        bo_pt = True
    End Sub

    Private Sub grvNGUON_VON_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grvNGUON_VON.MouseDown
        bo_nv = True
        bo_pt = False
    End Sub

    Private Sub grvNGUON_VON_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvNGUON_VON.CellValueChanged
        Try
            Dim dr_view As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)
            Select Case e.Column.Name
                'Case "TK_TAISAN"
                '    Dim cboTK_TS As DataRowView = CType(cboTK_TAISAN.GetDataSourceRowByKeyValue(Grid_GetDataRowItemString(grvNGUON_VON, "TK_TAISAN")), DataRowView)
                '    If cboTK_TS IsNot Nothing Then
                '        dr_view("MA_TK_TAISAN") = cboTK_TS("MaTaikhoan")
                '    End If
                '    dr_view("TK_TAISAN") = cboTK_TS("Id")
                '    'dr_view("TK_CHIPHI") = cboTK_CP("Id")
                'Case "TK_KHAUHAO"
                '    Dim cboTK_KH As DataRowView = CType(cboTK_KHAUHAO.GetDataSourceRowByKeyValue(Grid_GetDataRowItemString(grvNGUON_VON, "TK_KHAUHAO")), DataRowView)
                '    If cboTK_KH IsNot Nothing Then
                '        dr_view("MA_TK_KHAUHAO") = cboTK_KH("MaTaikhoan")
                '    End If
                'Case "MA_TK_CHIPHI"
                Case "DM_NGUON_TSCD_ID"
                    Dim dr_nguon As DmNguonTscd = CType(ComboHelper.GetSelectData(cboDM_NGUON_TSCD_ID, dr_view.DmNguonTscdId), DmNguonTscd)
                    dr_view.DmNguonTscdId = dr_nguon.Id
                    'If dr_nguon IsNot Nothing Then
                    '    dr_view("TEN_NGUON") = dr_nguon.TenDmNguonTscd
                    'End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlMD_TK_KHAUHAO_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlMD_TK_KHAUHAO.Validated
        Try
            Dim dr_KH As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_KHAUHAO), DmTaikhoan)

            If dr_KH IsNot Nothing Then

                If dr_KH.ChiTiet <> 1 Then
                    Message_Warning("Giá trị lựa chọn không hợp lệ")
                    grlMD_TK_KHAUHAO.EditValue = Nothing
                    txtTenTKKhauHao.Text = ""
                    grlMD_TK_KHAUHAO.Focus()
                    Return
                Else
                    txtTenTKKhauHao.Text = dr_KH.TenTaikhoan
                End If

                If (grvNGUON_VON.RowCount <> 0) Then
                    Dim dv As List(Of TsCtTscdNvon) = CType(grvNGUON_VON.DataSource, List(Of TsCtTscdNvon))
                    If (dr_KH IsNot Nothing) Then
                        For Each drv As TsCtTscdNvon In dv
                            drv.TkKhauhao = dr_KH.Id
                            drv.MaTkKhauhao = dr_KH.MaTaikhoan
                        Next
                    End If
                    grvNGUON_VON.RefreshData()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlMD_TK_CHIPHI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlMD_TK_CHIPHI.Validated
        Try
            Dim dr_CP As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_CHIPHI), DmTaikhoan)

            If dr_CP IsNot Nothing Then

                If dr_CP.ChiTiet <> 1 Then
                    Message_Warning("Giá trị lựa chọn không hợp lệ")
                    grlMD_TK_CHIPHI.EditValue = Nothing
                    txtTenTKChiPhi.Text = ""
                    grlMD_TK_CHIPHI.Focus()
                    Return
                Else
                    txtTenTKChiPhi.Text = dr_CP.TenTaikhoan
                End If

                If (grvNGUON_VON.RowCount <> 0) Then
                    Dim dv As List(Of TsCtTscdNvon) = CType(grvNGUON_VON.DataSource, List(Of TsCtTscdNvon))
                    If (dr_CP IsNot Nothing) Then
                        For Each drv As TsCtTscdNvon In dv
                            drv.MaTkChiphi = dr_CP.MaTaikhoan
                            drv.TkChiphi = dr_CP.Id
                        Next
                    End If
                    grvNGUON_VON.RefreshData()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlMD_TK_TS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlMD_TK_TS.Validated
        Try
            Dim dr_TS As DmTaikhoan = CType(ComboHelper.GetSelectData(grlMD_TK_TS), DmTaikhoan)

            If dr_TS IsNot Nothing Then
                If dr_TS.ChiTiet <> 1 Then
                    Message_Warning("Giá trị lựa chọn không hợp lệ")
                    grlMD_TK_TS.EditValue = Nothing
                    txtTenTKTaiSan.Text = ""
                    grlMD_TK_TS.Focus()
                    Return
                Else
                    txtTenTKTaiSan.Text = dr_TS.TenTaikhoan
                End If

                If (grvNGUON_VON.RowCount <> 0) Then
                    Dim dv As List(Of TsCtTscdNvon) = CType(grvNGUON_VON.DataSource, List(Of TsCtTscdNvon))
                    For Each drv As TsCtTscdNvon In dv
                        drv.TkTaisan = dr_TS.Id
                        drv.MaTkTaisan = dr_TS.MaTaikhoan
                    Next
                    grvNGUON_VON.RefreshData()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLoaiTS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLOAITAISAN_ID.Validated
        Try
            Dim dr_LTS As DmLoaitaisan = CType(ComboHelper.GetSelectData(grlLOAITAISAN_ID), DmLoaitaisan)
            If dr_LTS IsNot Nothing Then
                txtTenTaiSan.Text = dr_LTS.TenLoaitaisan
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.AfterFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)
            Dim rowHandle As Integer = grvNGUON_VON.FocusedRowHandle
            Dim columnName As String = grvNGUON_VON.FocusedColumn().Name
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            Select Case columnName
                Case "MaTkChiphi"
                    Dim arr As List(Of String) = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES
                    grvNGUON_VON.BeginDataUpdate()
                    If (arr.Count > 1) Then
                        dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(arr(0))
                        dr_grv_NGUONVON.MaTkChiphi = arr(1)
                        grvNGUON_VON.SetRowCellValue(rowHandle, "MaTkChiphi", arr(1))
                    End If
                    grvNGUON_VON.EndDataUpdate()
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.ClearDataFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)
            Dim rowHandle As Integer = grvNGUON_VON.FocusedRowHandle
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            If rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.FisrtBinddata
        Try
            rpeTK_CHIPHI.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(dt_tk)
            rpeTK_CHIPHI.Editors.A_DATA_SOURCE = rpeTK_CHIPHI.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

  
End Class