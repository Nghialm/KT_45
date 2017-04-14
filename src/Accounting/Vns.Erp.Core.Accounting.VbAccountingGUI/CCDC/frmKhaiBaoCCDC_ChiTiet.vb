
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports System.Data.SqlTypes

Public Class frmKhaiBaoCCDC_ChiTiet

#Region "properties"

    Private _CcCtCcdcNvonService As ICcCtCcdcNvonService
    Public Property CcCtCcdcNvonService() As ICcCtCcdcNvonService
        Get
            Return _CcCtCcdcNvonService
        End Get
        Set(ByVal value As ICcCtCcdcNvonService)
            _CcCtCcdcNvonService = value
        End Set
    End Property

    Private _CcDmCcdcService As ICcDmCcdcService
    Public Property CcDmCcdcService() As ICcDmCcdcService
        Get
            Return _CcDmCcdcService
        End Get
        Set(ByVal value As ICcDmCcdcService)
            _CcDmCcdcService = value
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

    Private _DmDvtService As IDmDvtService
    Public Property DmDvtService() As IDmDvtService
        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
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


    Private _CcCtCcdcService As ICcCtCcdcService
    Public Property CcCtCcdcService() As ICcCtCcdcService
        Get
            Return _CcCtCcdcService
        End Get
        Set(ByVal value As ICcCtCcdcService)
            _CcCtCcdcService = value
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

#End Region

#Region "Variables"
    Private m_InputState As DataInputState
    Private m_CCDC_Id As Guid
    Private m_obj_CCDC As CcDmCcdc
    Private m_Obj_CCDC_CT As CcCtCcdc
    Private m_lstNguonVon As List(Of CcCtCcdcNvon)
    Private m_lstDelNguonVon As List(Of CcCtCcdcNvon) = New List(Of CcCtCcdcNvon)
    Private m_MaCcdcOld As String = ""
    Private lstTaiKhoan As List(Of DmTaikhoan)
#End Region

#Region "Show_form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_CCDC_Id As Guid, ByVal eState As DataInputState) As CcDmCcdc
        Try
            Form_InitDialog(Me)
            m_InputState = eState
            m_CCDC_Id = p_CCDC_Id
            m_InputState = eState
            Me.ActiveControl = txtMaCC
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return m_obj_CCDC
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Functions"

    Private Sub Init_Data()
        BindDataToCbo()
        lstTaiKhoan = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        Select Case m_InputState
            Case DataInputState.AddMode
                m_lstNguonVon = New List(Of CcCtCcdcNvon)
                grcNGUON_VON.DataSource = m_lstNguonVon
            Case DataInputState.EditMode
                SetObject()
        End Select
    End Sub

    Private Sub BindDataToCbo()
        'Bind ĐVT
        Dim _lstDVT As List(Of DmDvt) = New List(Of DmDvt)
        _lstDVT.Add(New DmDvt)
        _lstDVT.AddRange(DmDvtService.GetAll())
        grlDVT.Properties.DataSource = _lstDVT
        grlDVT.Properties.ValueMember = "Id"
        grlDVT.Properties.DisplayMember = "TenDvt"

        'Bind phong ban
        Dim _lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
        _lstPhongBan.Add(New DmPhongban)
        _lstPhongBan.AddRange(DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
        grlBoPhanSd.Properties.DataSource = _lstPhongBan
        grlBoPhanSd.Properties.ValueMember = "Id"
        grlBoPhanSd.Properties.DisplayMember = "TenPhongban"

        'bind Loai phan bo
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("Id", GetType(Decimal))
        table.Columns.Add("Ten", GetType(String))

        table.Rows.Add(1, "Phân bổ theo kỳ")
        table.Rows.Add(2, "Phân bổ 2 lần")
        grlKieuPb.Properties.DataSource = table
        grlKieuPb.Properties.ValueMember = "Id"
        grlKieuPb.Properties.DisplayMember = "Ten"

        'Bind Nguon von
        Dim lstNguonVon As List(Of DmNguonTscd) = New List(Of DmNguonTscd)
        lstNguonVon.AddRange(_DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id))
        cboNguonVon.DataSource = lstNguonVon
    End Sub

    Private Sub GetObject()
        Dim bInsert As Boolean = False

        If m_InputState = DataInputState.AddMode Then
            bInsert = True
        End If
        'dm_CCDC
        If m_obj_CCDC Is Nothing Then
            m_obj_CCDC = New CcDmCcdc()
        End If

        m_obj_CCDC.MaCcdc = txtMaCC.Text
        m_obj_CCDC.TenCcdc = txtTenCC.Text
        m_obj_CCDC.SoLuong = VnsConvert.CDecimal(txtSoLuong.Text)

        If Not VnsCheck.IsNullGuid(grlDVT.EditValue) Then
            Dim objDvt As DmDvt = CType(ComboHelper.GetSelectData(grlDVT), DmDvt)
            m_obj_CCDC.DvtId = objDvt.Id
            m_obj_CCDC.TenDvt = objDvt.TenDvt
            m_obj_CCDC.MaDvt = objDvt.MaDvt
        End If

        If Not VnsCheck.IsNullGuid(grlBoPhanSd.EditValue) Then
            Dim objPhongban As DmPhongban = CType(ComboHelper.GetSelectData(grlBoPhanSd), DmPhongban)
            m_obj_CCDC.PhongbanId = objPhongban.Id
            m_obj_CCDC.TenPhongban = objPhongban.TenPhongban
            m_obj_CCDC.MaPhongban = objPhongban.MaPhongban
        End If

        Dim getDate As SqlDateTime
        getDate = SqlDateTime.Null

        m_obj_CCDC.MdTkCcdc = C_filter_TKCC.ListEditValue(1)
        m_obj_CCDC.MdTkChiphi = C_filter_TKCP.ListEditValue(1)
        m_obj_CCDC.MdTkPhanbo = C_filter_TKPB.ListEditValue(1)
        m_obj_CCDC.SoKyPhanbo = VnsConvert.CDecimal(txtSoKyPb.Text)
        m_obj_CCDC.LoaiPhanbo = grlKieuPb.EditValue
        m_obj_CCDC.TenLoaiPhanbo = grlKieuPb.Text
        m_obj_CCDC.NgayBdpb = dteNgayBDSD.DateTime
        m_obj_CCDC.NgayBdsd = dteNgayBDSD.DateTime
        m_obj_CCDC.NgayMua = dteNgayBDSD.DateTime
        m_obj_CCDC.NgayKtpb = getDate
        m_obj_CCDC.NgayGiam = getDate
        m_obj_CCDC.NguyenGia = VnsConvert.CDecimal(txtNguyenGia.Text)
        m_obj_CCDC.GiaTriCl = VnsConvert.CDecimal(txtGTCL.Text)
        m_obj_CCDC.Nhom1 = VnsConvert.CGuid(grlNhom1.EditValue)
        m_obj_CCDC.Nhom2 = VnsConvert.CGuid(grlNhom2.EditValue)
        m_obj_CCDC.Nhom3 = VnsConvert.CGuid(grlNhom3.EditValue)
        m_obj_CCDC.DonviId = Generals.DON_VI.Id
        m_obj_CCDC.MaDonvi = Generals.DON_VI.MaDonvi
        m_obj_CCDC.NuocSx = txtNuocSx.Text
        m_obj_CCDC.NgayTang = dteNgayBDSD.DateTime

        If txtNamSx.Text.Trim <> "" Then
            m_obj_CCDC.NamSx = VnsConvert.CDecimal(txtNamSx.Text)
        End If
        m_obj_CCDC.ThongsoKythuat = txtTskt.Text
        'CT_CCDC
        If m_Obj_CCDC_CT Is Nothing Then
            m_Obj_CCDC_CT = New CcCtCcdc
        End If

        m_Obj_CCDC_CT.MaCcdc = m_obj_CCDC.MaCcdc
        m_Obj_CCDC_CT.TenCcdc = m_obj_CCDC.TenCcdc
        m_Obj_CCDC_CT.NuocSx = m_obj_CCDC.NuocSx
        m_Obj_CCDC_CT.NamSx = m_obj_CCDC.NamSx
        m_Obj_CCDC_CT.ThongsoKythuat = m_obj_CCDC.ThongsoKythuat
        m_Obj_CCDC_CT.NgayMua = m_obj_CCDC.NgayMua
        m_Obj_CCDC_CT.NgayBdsd = m_obj_CCDC.NgayBdsd
        m_Obj_CCDC_CT.NgayBdpb = m_obj_CCDC.NgayBdpb
        m_Obj_CCDC_CT.NgayKtpb = m_obj_CCDC.NgayKtpb
        m_Obj_CCDC_CT.NgayGiam = m_obj_CCDC.NgayGiam
        m_Obj_CCDC_CT.NgayTang = m_obj_CCDC.NgayTang
        m_Obj_CCDC_CT.SoKyPhanbo = m_obj_CCDC.SoKyPhanbo
        m_Obj_CCDC_CT.SoTienDaPhanbo = m_obj_CCDC.SoTienDaPhanbo
        m_Obj_CCDC_CT.GiaTriCl = m_obj_CCDC.GiaTriCl
        m_Obj_CCDC_CT.PhongbanId = m_obj_CCDC.PhongbanId
        m_Obj_CCDC_CT.MaPhongban = m_obj_CCDC.MaPhongban
        m_Obj_CCDC_CT.TenPhongban = m_obj_CCDC.TenPhongban
        m_Obj_CCDC_CT.TenLoaiPhanbo = m_obj_CCDC.TenLoaiPhanbo
        m_Obj_CCDC_CT.DvtId = m_obj_CCDC.DvtId
        m_Obj_CCDC_CT.MaDvt = m_obj_CCDC.MaDvt
        m_Obj_CCDC_CT.TenDvt = m_obj_CCDC.TenDvt
        m_Obj_CCDC_CT.DonviId = Generals.DON_VI.Id
        m_Obj_CCDC_CT.MaDonvi = Generals.DON_VI.MaDonvi
        m_Obj_CCDC_CT.MdTkCcdc = m_obj_CCDC.MdTkCcdc
        m_Obj_CCDC_CT.MdTkChiphi = m_obj_CCDC.MdTkChiphi
        m_Obj_CCDC_CT.MdTkPhanbo = m_obj_CCDC.MdTkPhanbo
        m_Obj_CCDC_CT.Nhom1 = m_obj_CCDC.Nhom1
        m_Obj_CCDC_CT.Nhom2 = m_obj_CCDC.Nhom2
        m_Obj_CCDC_CT.Nhom3 = m_obj_CCDC.Nhom3
        m_Obj_CCDC_CT.SoLuong = m_obj_CCDC.SoLuong
        m_Obj_CCDC_CT.NguyenGia = m_obj_CCDC.NguyenGia
        m_Obj_CCDC_CT.ThuTu = 1

        _CcDmCcdcService.SaveCCDC(bInsert, m_obj_CCDC, m_Obj_CCDC_CT, m_lstNguonVon, m_lstDelNguonVon)

    End Sub

    Private Sub SetObject()
        'Lay dm_ccdc
        m_obj_CCDC = CcDmCcdcService.GetById(m_CCDC_Id)

        m_MaCcdcOld = m_obj_CCDC.MaCcdc

        txtMaCC.Text = m_obj_CCDC.MaCcdc
        txtTenCC.Text = m_obj_CCDC.TenCcdc
        txtSoLuong.Text = m_obj_CCDC.SoLuong.ToString()
        grlDVT.EditValue = m_obj_CCDC.DvtId
        grlBoPhanSd.EditValue = m_obj_CCDC.PhongbanId
        C_filter_TKCC.Tag = ReturnIdTk(m_obj_CCDC.MdTkCcdc)
        C_filter_TKCC.Text = m_obj_CCDC.MdTkCcdc
        C_filter_TKCP.Tag = ReturnIdTk(m_obj_CCDC.MdTkChiphi)
        C_filter_TKCP.Text = m_obj_CCDC.MdTkChiphi
        C_filter_TKPB.Tag = ReturnIdTk(m_obj_CCDC.MdTkPhanbo)
        C_filter_TKPB.Text = m_obj_CCDC.MdTkPhanbo
        txtSoKyPb.Text = m_obj_CCDC.SoKyPhanbo.ToString
        grlKieuPb.EditValue = m_obj_CCDC.LoaiPhanbo
        dteNgayBDSD.DateTime = m_obj_CCDC.NgayBdpb
        txtNguyenGia.Text = m_obj_CCDC.NguyenGia
        txtGTCL.Text = m_obj_CCDC.GiaTriCl
        grlNhom1.EditValue = m_obj_CCDC.Nhom1
        grlNhom2.EditValue = m_obj_CCDC.Nhom2
        grlNhom3.EditValue = m_obj_CCDC.Nhom3
        txtNuocSx.Text = m_obj_CCDC.NuocSx
        If m_obj_CCDC.NamSx <> 0 Then
            txtNamSx.Text = m_obj_CCDC.NamSx
        End If
        txtTskt.Text = m_obj_CCDC.ThongsoKythuat
        'CT_CCDC
        m_Obj_CCDC_CT = _CcCtCcdcService.GetByCCDCId(m_CCDC_Id)(0)

        'NV_CCDC
        m_lstNguonVon = New List(Of CcCtCcdcNvon)
        m_lstNguonVon.AddRange(CcCtCcdcNvonService.GetAll())
        grcNGUON_VON.DataSource = m_lstNguonVon
    End Sub

    Private Function Check_input() As Boolean
        If txtMaCC.Text = "" Then
            Message_Warning("Bạn chưa nhập mã CCDC")
            txtMaCC.Focus()
            Return False
        End If

        If txtTenCC.Text = "" Then
            Message_Warning("Bạn chưa nhập tên CCDC")
            txtTenCC.Focus()
            Return False
        End If

        If VnsConvert.CDecimal(txtSoLuong.Text) = 0 Then
            Message_Warning("Bạn chưa nhập số lượng CCDC")
            txtTenCC.Focus()
            Return False
        End If

        If C_filter_TKCC.Tag = "" Then
            Message_Warning("Bạn chưa nhập tài khoản công cụ")
            C_filter_TKCC.Focus()
            Return False
        End If

        If C_filter_TKCP.Tag = "" Then
            Message_Warning("Bạn chưa nhập tài khoản chi phí")
            C_filter_TKCP.Focus()
            Return False
        End If

        If C_filter_TKPB.Tag = "" Then
            Message_Warning("Bạn chưa nhập tài khoản phân bổ")
            C_filter_TKPB.Focus()
            Return False
        End If

        If txtSoKyPb.Text = "" Then
            Message_Warning("Bạn chưa nhập số kỳ Pb")
            txtSoKyPb.Focus()
            Return False
        End If

        If grlKieuPb.EditValue Is Nothing Then
            Message_Warning("Bạn chưa chọn kiểu Pb")
            grlKieuPb.Focus()
            Return False
        End If

        If dteNgayBDSD.Text = "" Or VnsCheck.IsNullDate(dteNgayBDSD.DateTime) Then
            Message_Warning("Bạn chưa nhập bắt đầu phân bổ ccdc")
            dteNgayBDSD.Focus()
            Return False
        End If

        If VnsConvert.CDecimal(txtNguyenGia.Text) = 0 Then
            Message_Warning("Bạn chưa nhập nguyên giá")
            txtNguyenGia.Focus()
            Return False
        End If

        If VnsConvert.CDecimal(txtGTCL.Text) = 0 Then
            Message_Warning("Bạn chưa nhập giá trị còn lại")
            txtGTCL.Focus()
            Return False
        End If

        If VnsConvert.CDecimal(txtNguyenGia.Text) < VnsConvert.CDecimal(txtGTCL.Text) Then
            Message_Warning("Giá trị nguyên giá phải lớn hơn hoặc bằng giá trị còn lại")
            txtNguyenGia.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function CheckInputNguonVon() As Boolean
        Dim he_so As Decimal = 0
        Dim lstNguonVonTemp As List(Of CcCtCcdcNvon) = New List(Of CcCtCcdcNvon)
        lstNguonVonTemp.AddRange(CType(grvNGUON_VON.DataSource, List(Of CcCtCcdcNvon)))
        If (lstNguonVonTemp.Count <> 0) Then
            For Each drv As CcCtCcdcNvon In lstNguonVonTemp

                If (drv.DmNguonTscdId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa chọn nguồn cho nguồn vốn")
                    Return False
                End If

                If (drv.TkChiphi = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập tài khoản chi phí cho nguồn vốn")
                    Return False
                End If

                If drv.HeSoPbKh < 0 Then
                    Message_Warning("Hệ số phải lớn hơn 0")
                    Return False
                Else
                    he_so = he_so + drv.HeSoPbKh
                End If

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

        Return True
    End Function

    Private Function CheckMaCcdc(ByVal MaOld As String, ByVal MaNew As String) As Boolean
        Dim Ma_temp As String = ""
        If m_InputState = DataInputState.AddMode Then
            Ma_temp = MaNew.ToUpper()
        Else
            If MaOld.ToUpper().Equals(MaNew.ToUpper) Then
                Return True
            Else
                Ma_temp = MaNew
            End If
        End If

        Dim lstByMa As List(Of CcDmCcdc) = New List(Of CcDmCcdc)
        lstByMa.AddRange(CcDmCcdcService.GetByMaCCDC(Ma_temp))
        If lstByMa.Count > 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub Grid_AddNewRow()
        If m_lstNguonVon Is Nothing Then
            m_lstNguonVon = New List(Of CcCtCcdcNvon)()
        End If
        Dim objNV As CcCtCcdcNvon = New CcCtCcdcNvon
        objNV.TkCcdc = VnsConvert.CGuid(C_filter_TKCC.ListEditValue(0))
        objNV.MaTkCcdc = C_filter_TKCC.ListEditValue(1)
        objNV.TkChiphi = VnsConvert.CGuid(C_filter_TKCP.ListEditValue(0))
        objNV.MaTkChiphi = C_filter_TKCP.ListEditValue(1)

        objNV.TkPhanbo = VnsConvert.CGuid(C_filter_TKPB.ListEditValue(0))
        objNV.MaTkPhanbo = C_filter_TKPB.ListEditValue(1)

        m_lstNguonVon.Add(objNV)
        grvNGUON_VON.RefreshData()

    End Sub

    Private Sub Grid_DelRow()
        If grvNGUON_VON.RowCount <> 0 Then
            If Message_Confirm("Bạn có chắc chắn muốn xóa?") Then
                Dim delnv As CcCtCcdcNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), CcCtCcdcNvon)
                m_lstDelNguonVon.Add(delnv)
                Grid_DeleteSelectRows(grvNGUON_VON)
            End If
        Else
            Message_Warning("Không có bản ghi nào được chọn!")
        End If
    End Sub

    Private Sub SetFocusAfterAddRow()
        If grvNGUON_VON.RowCount > 0 Then
            grvNGUON_VON.FocusedRowHandle = grvNGUON_VON.RowCount - 1
            grvNGUON_VON.FocusedColumn = grvNGUON_VON.VisibleColumns(0)
        End If
    End Sub

    Private Function ReturnIdTk(ByVal matk As String) As Guid
        For Each obj As DmTaikhoan In lstTaiKhoan
            If obj.MaTaikhoan.Equals(matk) Then
                Return obj.Id
            End If
        Next

        Return Null.NullGuid
    End Function

#End Region

#Region "Events"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_input() Then
                Return
            End If

            If Not CheckInputNguonVon() Then
                Return
            End If

            If Not CheckMaCcdc(m_MaCcdcOld, txtMaCC.Text.Trim) Then
                Message_Warning("Mã Ccdc đã tồn tại")
                txtMaCC.Focus()
                Return
            End If

            frmProgress.Instance.Thread = AddressOf GetObject
            frmProgress.Instance.Show_Progress()

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub frmKhaiBaoCCDC_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Grid_AddNewRow()
                    SetFocusAfterAddRow()
                Case Keys.F8
                    Grid_DelRow()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvNGUON_VON_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvNGUON_VON.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (GridHelper.CheckAddNewRow(grvNGUON_VON)) Then
                    Grid_AddNewRow()
                    SetFocusAfterAddRow()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "CustomFilter"

    Private Sub C_filter_TKCC_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCC.AfterFilter
        Try
            C_filter_TKCC.Tag = C_filter_TKCC.ListEditValue(0)

            If (grvNGUON_VON.RowCount <> 0) Then
                Dim dv As List(Of CcCtCcdcNvon) = CType(grvNGUON_VON.DataSource, List(Of CcCtCcdcNvon))
                For Each drv As CcCtCcdcNvon In dv
                    drv.TkCcdc = VnsConvert.CGuid(C_filter_TKCC.ListEditValue(0))
                    drv.MaTkCcdc = C_filter_TKCC.ListEditValue(1)
                Next
                grvNGUON_VON.RefreshData()
            End If

            If C_filter_TKCC.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKCC_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCC.FirstBinddata
        Try
            Dim Ds As DataTable = DataHelper.ToDataTable(lstTaiKhoan)
            C_filter_TKCC.C_DATA_SOURCE = Ds
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKCC_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCC.ClearFilterData
        Try
            C_filter_TKCC.Tag = C_filter_TKCC.ListEditValue(0)
            C_filter_TKCC.Text = C_filter_TKCC.ListEditValue(2)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKPB_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKPB.AfterFilter
        Try
            C_filter_TKPB.Tag = C_filter_TKPB.ListEditValue(0)
            If (grvNGUON_VON.RowCount <> 0) Then
                Dim dv As List(Of CcCtCcdcNvon) = CType(grvNGUON_VON.DataSource, List(Of CcCtCcdcNvon))
                For Each drv As CcCtCcdcNvon In dv
                    drv.TkPhanbo = VnsConvert.CGuid(C_filter_TKPB.ListEditValue(0))
                    drv.MaTkPhanbo = C_filter_TKPB.ListEditValue(1)
                Next
                grvNGUON_VON.RefreshData()
            End If
            If C_filter_TKPB.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKPB_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKPB.ClearFilterData
        Try
            C_filter_TKPB.Tag = C_filter_TKCC.ListEditValue(0)
            C_filter_TKPB.Text = C_filter_TKCC.ListEditValue(2)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKPB_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKPB.FirstBinddata
        Try
            Dim Ds As DataTable = DataHelper.ToDataTable(lstTaiKhoan)
            C_filter_TKPB.C_DATA_SOURCE = Ds
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKCP_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCP.AfterFilter
        Try
            C_filter_TKCP.Tag = C_filter_TKCP.ListEditValue(0)
            If (grvNGUON_VON.RowCount <> 0) Then
                Dim dv As List(Of CcCtCcdcNvon) = CType(grvNGUON_VON.DataSource, List(Of CcCtCcdcNvon))
                For Each drv As CcCtCcdcNvon In dv
                    drv.TkChiphi = VnsConvert.CGuid(C_filter_TKCP.ListEditValue(0))
                    drv.MaTkChiphi = C_filter_TKCP.ListEditValue(1)
                Next
                grvNGUON_VON.RefreshData()
            End If
            If C_filter_TKCP.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKCP_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCP.FirstBinddata
        Try
            Dim Ds As DataTable = DataHelper.ToDataTable(lstTaiKhoan)
            C_filter_TKCP.C_DATA_SOURCE = Ds
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub C_filter_TKCP_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_filter_TKCP.ClearFilterData
        Try
            C_filter_TKCP.Tag = C_filter_TKCC.ListEditValue(0)
            C_filter_TKCP.Text = C_filter_TKCC.ListEditValue(2)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpTkCP_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpTkCP.AfterFilter
        Try
            Dim dr_grv_NGUONVON As CcCtCcdcNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), CcCtCcdcNvon)
            Dim rowHandle As Integer = grvNGUON_VON.FocusedRowHandle
            Dim columnName As String = grvNGUON_VON.FocusedColumn().Name
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            Select Case columnName
                Case "MaTkChiphi"
                    Dim arr As List(Of String) = rpTkCP.OwnerEdit.A_LIST_VALUES
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

    Private Sub rpTkCP_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpTkCP.ClearDataFilter
        Try
            Dim dr_grv_NGUONVON As CcCtCcdcNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), CcCtCcdcNvon)
            Dim rowHandle As Integer = grvNGUON_VON.FocusedRowHandle
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            If rpTkCP.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpTkCP.Tag = rpTkCP.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpTkCP.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkChiphi = rpTkCP.OwnerEdit.A_LIST_VALUES(1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpTkCP_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpTkCP.FisrtBinddata
        Try
            rpTkCP.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(lstTaiKhoan)
            rpTkCP.Editors.A_DATA_SOURCE = rpTkCP.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class