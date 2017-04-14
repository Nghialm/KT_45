Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Spa.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain.Extend
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmHDDV_ChiTiet

#Region "Properties"

    Private _CtHHddvService As ICtHHddvService
    Public Property CtHHddvService() As ICtHHddvService
        Get
            Return _CtHHddvService
        End Get
        Set(ByVal value As ICtHHddvService)
            _CtHHddvService = value
        End Set
    End Property

    Private _CtDHddvService As ICtDHddvService
    Public Property CtDHddvService() As ICtDHddvService
        Get
            Return _CtDHddvService
        End Get
        Set(ByVal value As ICtDHddvService)
            _CtDHddvService = value
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

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _SpaDmTheService As ISpaDmTheService
    Public Property SpaDmTheService() As ISpaDmTheService
        Get
            Return _SpaDmTheService
        End Get
        Set(ByVal value As ISpaDmTheService)
            _SpaDmTheService = value
        End Set
    End Property

    Private _SpaDmGuongdvService As ISpaDmGuongdvService
    Public Property SpaDmGuongdvService() As ISpaDmGuongdvService
        Get
            Return _SpaDmGuongdvService
        End Get
        Set(ByVal value As ISpaDmGuongdvService)
            _SpaDmGuongdvService = value
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

    Private _SpaDmNhanvienService As ISpaDmNhanvienService
    Public Property SpaDmNhanvienService() As ISpaDmNhanvienService
        Get
            Return _SpaDmNhanvienService
        End Get
        Set(ByVal value As ISpaDmNhanvienService)
            _SpaDmNhanvienService = value
        End Set
    End Property

    Private _SpaDmDichVuService As ISpaDmDichVuService
    Public Property SpaDmDichVuService() As ISpaDmDichVuService
        Get
            Return _SpaDmDichVuService
        End Get
        Set(ByVal value As ISpaDmDichVuService)
            _SpaDmDichVuService = value
        End Set
    End Property


    Private _SpaLsTheService As ISpaLsTheService
    Public Property SpaLsTheService() As ISpaLsTheService
        Get
            Return _SpaLsTheService
        End Get
        Set(ByVal value As ISpaLsTheService)
            _SpaLsTheService = value
        End Set
    End Property

#End Region

#Region "Variables"

    Private m_InputState As DataInputState
    Private m_CTH_ID As Guid
    Private m_MA_LOAI_CT As String
    Private m_OnLoadData = False 'Bien phan biet dang trong trang thai load du lieu

    Private m_CT_HInfo As CtHHddv = New CtHHddv()
    Private m_HT_CT_Info As HtLoaichungtu

    Private m_LstCT_H_GInfo As List(Of CT_H_GInfo) = New List(Of CT_H_GInfo)
    Private m_lstDichVu As List(Of CtDHddv) = New List(Of CtDHddv)
    Private m_lstHangHoa As List(Of CtDHddv) = New List(Of CtDHddv)
    Private m_lstDelCtd As List(Of CtDHddv) = New List(Of CtDHddv)
    Private m_TTTheThuc As Decimal
    Private m_TTTheKM As Decimal
#End Region

#Region "Constructors"

#End Region

#Region "Load form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal CTH_ID As Guid, ByVal MA_LOAI_CT As String, ByVal TEN_LOAI_CT As String, _
                               ByVal lstCT_H_GInfo As List(Of CT_H_GInfo), ByVal eState As DataInputState) As CtHHddv
        Try
            Form_SetText(Me, TEN_LOAI_CT, DataInputState.NoCaption)
            Form_InitDialog(Me)

            m_InputState = eState
            m_CTH_ID = CTH_ID
            If lstCT_H_GInfo IsNot Nothing Then
                m_LstCT_H_GInfo = lstCT_H_GInfo
            End If
            m_MA_LOAI_CT = MA_LOAI_CT

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()

            AddHandler grvCth_hddv.FocusedRowChanged, AddressOf grvCth_hddv_FocusedRowChanged
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
        txtTuGio.Time = Nothing
        txtDenGio.Time = Nothing

        If m_InputState = DataInputState.AddMode Then
            ControlSetState()
            BindLookup()
            dteNgayCT.DateTime = DateTime.Now
            TNCommon.SelectFirst(cboLoaiCT)

            m_lstDichVu.Add(New CtDHddv())
            m_lstHangHoa.Add(New CtDHddv())
            grcHangHoa.DataSource = m_lstHangHoa
            grcDichVu.DataSource = m_lstDichVu
        Else
            ControlSetState()
            BindLookup()
            SetObjectToControl()
            TongSoTien()
        End If

        grcCth_hddv.DataSource = Nothing
        grcCth_hddv.DataSource = m_LstCT_H_GInfo
        m_OnLoadData = False
    End Sub

    Private Sub ConfigByLoaiCT(ByVal obj As HtLoaichungtu)
        If obj.KhoXuat = 1 Then
            xtpDichVu.PageVisible = False
            txtTuGio.Properties.ReadOnly = True
            txtDenGio.Properties.ReadOnly = True
            cboChonDichVu.Visible = False
        Else
            xtpDichVu.PageVisible = True
            txtTuGio.Properties.ReadOnly = False
            txtDenGio.Properties.ReadOnly = False
            cboChonDichVu.Enabled = True
        End If
    End Sub

    Private Sub ControlSetState()
       
        Select Case m_InputState
            Case DataInputState.AddMode

                grcCth_hddv.Enabled = False
                ControlNavigator1.Enabled = False
                Control_SetState(GroupControl1, DataInputState.AddMode)
                grvDichVu.OptionsBehavior.Editable = True
                grvHangHoa.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
                btnPrinter.Enabled = False
                btnCancel.Enabled = True
                btnSearch.Enabled = False

                txtTTTienMat.Properties.ReadOnly = False
                txtTTThe.Properties.ReadOnly = False
                txtTTTheNh.Properties.ReadOnly = False
                txtGhiChu.Properties.ReadOnly = False
                cFilterThe.ENABLES = True
                txtTuGio.Properties.ReadOnly = False
                txtDenGio.Properties.ReadOnly = False
            Case DataInputState.EditMode
                grcCth_hddv.Enabled = False
                ControlNavigator1.Enabled = False
                Control_SetState(GroupControl1, DataInputState.EditMode)
                grvDichVu.OptionsBehavior.Editable = True
                grvHangHoa.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = True
                btnPrinter.Enabled = True
                btnCancel.Enabled = True
                btnSearch.Enabled = False

                txtTTTienMat.Properties.ReadOnly = False
                txtTTThe.Properties.ReadOnly = False
                txtTTTheNh.Properties.ReadOnly = False
                txtGhiChu.Properties.ReadOnly = False
                cFilterThe.ENABLES = True
                txtTuGio.Properties.ReadOnly = False
                txtDenGio.Properties.ReadOnly = False
            Case DataInputState.ViewMode
                grcCth_hddv.Enabled = True
                ControlNavigator1.Enabled = False
                Control_SetState(GroupControl1, DataInputState.ViewMode)
                grvDichVu.OptionsBehavior.Editable = False
                grvHangHoa.OptionsBehavior.Editable = False

                btnAdd.Enabled = True
                ''btnModify.Enabled = True
                If grvCth_hddv.RowCount = 0 Then
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                Else
                    btnModify.Enabled = True
                    btnDelete.Enabled = True
                End If
                btnSave.Enabled = False
                btnDelete.Enabled = True
                btnPrinter.Enabled = True
                btnCancel.Enabled = False
                btnSearch.Enabled = True

                txtTTTienMat.Properties.ReadOnly = True
                txtTTThe.Properties.ReadOnly = True
                txtTTTheNh.Properties.ReadOnly = True
                txtGhiChu.Properties.ReadOnly = True
                txtTuGio.Properties.ReadOnly = True
                txtDenGio.Properties.ReadOnly = True
                cFilterThe.ENABLES = False
        End Select

        C_SoChungTu.Enabled = True
        C_SoChungTu.SetReadOnly()
        txtTenKH.Properties.ReadOnly = True
        txtTenNhanVien.Properties.ReadOnly = True
        C_SoChungTu.TabStop = False
    End Sub

    Private Sub TongSoTien()
        Dim TienHang As Decimal = 0
        Dim TienHang_gg As Decimal = 0
        Dim Tong_th As Decimal = 0
        Dim TienDV As Decimal = 0
        Dim TienDV_gg As Decimal = 0
        Dim Tong_tdv As Decimal = 0
        Dim Tong As Decimal = 0
        Dim Tong_gg As Decimal = 0
        Dim Tong_tt As Decimal = 0

        Try
            'Tien hang
            Dim i As Integer
            For i = 0 To grvHangHoa.RowCount - 1
                TienHang = TienHang + grvHangHoa.GetRowCellValue(i, "DoanhThu")
                TienHang_gg = TienHang_gg + grvHangHoa.GetRowCellValue(i, "SoTienGiamGia")
            Next

            'Tien DV
            For i = 0 To grvDichVu.RowCount - 1
                TienDV = TienDV + grvDichVu.GetRowCellValue(i, "DoanhThu")
                TienDV_gg = TienDV_gg + grvDichVu.GetRowCellValue(i, "SoTienGiamGia")
            Next

            Tong_th = TienHang - TienHang_gg
            Tong_tdv = TienDV - TienDV_gg
            Tong = TienHang + TienDV
            Tong_gg = TienHang_gg + TienDV_gg
            Tong_tt = Tong - Tong_gg
        Catch ex As OverflowException
            Message_Warning("Giá trị nhập vào không hợp lệ")
            Return
        End Try

        txtTienHang.EditValue = TienHang
        txtGiamGia.EditValue = TienHang_gg
        txtTongCong.EditValue = Tong_th

        txtTienCongSC.EditValue = TienDV
        txtGiamGiaSC.EditValue = TienDV_gg
        txtTongCongSC.EditValue = Tong_tdv

        txtTongTienHang.EditValue = Tong
        txtGiamGiaTong.EditValue = Tong_gg
        txtTongTienTT.EditValue = Tong_tt

        TienThanhToan()
    End Sub

    Private Sub BindLookup()
        'Bind loại chứng từ
        Dim lstLoaiChungTu As List(Of HtLoaichungtu) = _HtLoaichungtuService.LikeObjetMA_LOAI_CT(m_MA_LOAI_CT, Generals.DonviID)
        cboLoaiCT.Properties.DataSource = lstLoaiChungTu
        cboLoaiCT.Properties.DisplayMember = "KyHieu"
        cboLoaiCT.Properties.ValueMember = "Id"

        'bind giuong dich vu
        Dim lstGiuongDv As List(Of SpaDmGuongdv) = _SpaDmGuongdvService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstGiuongDv_temp As List(Of SpaDmGuongdv) = New List(Of SpaDmGuongdv)
        Dim obj_GiuongDv As SpaDmGuongdv = New SpaDmGuongdv
        lstGiuongDv_temp.Add(obj_GiuongDv)
        lstGiuongDv_temp.AddRange(lstGiuongDv)
        cboGiuongDV.Properties.DataSource = lstGiuongDv_temp
        cboGiuongDV.Properties.DisplayMember = "Kyhieu"
        cboGiuongDV.Properties.ValueMember = "Id"

        'bind nhan vien
        'Sau khi co list nhan vien se doi lai :D
        'Dim lstNhanVIen As List(Of SpaDmNhanvien) = _SpaDmNhanvienService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstNhanVIen As List(Of SpaDmNhanvien) = _SpaDmNhanvienService.GetByTrangThai(False)
        Dim lstNhanVien_temp As List(Of SpaDmNhanvien) = New List(Of SpaDmNhanvien)
        Dim obj_NhanVien As SpaDmNhanvien = New SpaDmNhanvien
        lstNhanVien_temp.Add(obj_NhanVien)
        lstNhanVien_temp.AddRange(lstNhanVIen)
        cboNhanVien.Properties.DataSource = lstNhanVien_temp
        cboNhanVien.Properties.DisplayMember = "KyHieu"
        cboNhanVien.Properties.ValueMember = "Id"
    End Sub

    Private Sub SetObjectToControl()
        If m_InputState = DataInputState.CopyMode Then
            m_CTH_ID = Nothing
        End If

        If m_CTH_ID = Null.NullGuid Then
            m_CTH_ID = m_CT_HInfo.Id
        End If

        'Lay CT_H
        m_CT_HInfo = _CtHHddvService.GetById(m_CTH_ID)

        If (m_CT_HInfo Is Nothing) Then
            Return
        End If

        ''assign value to control
        cboLoaiCT.EditValue = m_CT_HInfo.IdLoaiCt
        dteNgayCT.DateTime = m_CT_HInfo.NgayCt
        C_SoChungTu.Text = m_CT_HInfo.PrefixCt + m_CT_HInfo.CtSo
        txtTuGio.Time = m_CT_HInfo.TuGio
        txtDenGio.Time = m_CT_HInfo.DenGio
        cFilterKhachHang.Text = m_CT_HInfo.KyHieuKhang
        cFilterKhachHang.Tag = m_CT_HInfo.KhangId
        txtTenKH.Text = m_CT_HInfo.TenKhang
        cboNhanVien.EditValue = m_CT_HInfo.IdNhanVien
        cboGiuongDV.EditValue = m_CT_HInfo.IdGuongDichVu
        txtGhiChu.Text = m_CT_HInfo.DienGiai
        
        m_TTTheKM = m_CT_HInfo.TheTienKm1
        m_TTTheThuc = m_CT_HInfo.TheTienThe1
        Dim objthe As SpaDmThe = _SpaDmTheService.GetById(m_CT_HInfo.SoThe1)
        If objthe IsNot Nothing Then
            cFilterThe.Tag = m_CT_HInfo.SoThe1.ToString
            cFilterThe.Text = objthe.Ma
        End If

        txtTTThe.Text = m_CT_HInfo.TtTienThe1.ToString
        txtTTTheNh.Text = m_CT_HInfo.TtTienNh.ToString
        txtTTTienMat.Text = m_CT_HInfo.TtTienMat.ToString

        'Lay CT_D
        m_lstDichVu = _CtDHddvService.GetCtdByLoaiNV(m_CTH_ID, 1)
        grcDichVu.DataSource = m_lstDichVu

        m_lstHangHoa = _CtDHddvService.GetCtdByLoaiNV(m_CTH_ID, 2)
        grcHangHoa.DataSource = m_lstHangHoa

        cboLoaiCT.Properties.ReadOnly = True
    End Sub

    Private Sub GetControlToOBject()
        Select Case m_InputState
            Case DataInputState.AddMode
                m_CT_HInfo = New CtHHddv()
        End Select

        'Get cth
        Dim objLoaiCt As HtLoaichungtu = CType(ComboHelper.GetSelectData(cboLoaiCT), HtLoaichungtu)

        m_CT_HInfo.IdLoaiCt = objLoaiCt.Id
        m_CT_HInfo.MaLoaiCt = objLoaiCt.MaLoaiCt
        m_CT_HInfo.KyHieuLoaiCt = objLoaiCt.KyHieu
        m_CT_HInfo.DonviId = Generals.DON_VI.Id
        m_CT_HInfo.MaDonvi = Generals.DON_VI.MaDonvi
        m_CT_HInfo.NgayCt = dteNgayCT.DateTime
        m_CT_HInfo.NgayGhi = Date.Now
        m_CT_HInfo.NgayPd = Date.Now

        Dim strmMonth As String = Month(dteNgayCT.DateTime).ToString
        Dim strYear As String = Year(dteNgayCT.DateTime).ToString
        If m_InputState <> DataInputState.EditMode Then
            C_SoChungTu.r_SoCTPREFIX(objLoaiCt.Id, strmMonth, strYear, Generals.DON_VI.Id)
            m_CT_HInfo.CtSo = C_SoChungTu.SO_CHUNG_TU
            m_CT_HInfo.PrefixCt = C_SoChungTu.PREFIX
        End If

        m_CT_HInfo.TuGio = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, txtTuGio.Time.Hour, txtTuGio.Time.Minute, txtTuGio.Time.Second)
        m_CT_HInfo.DenGio = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, txtDenGio.Time.Hour, txtDenGio.Time.Minute, txtDenGio.Time.Second)

        m_CT_HInfo.KhangId = New Guid(cFilterKhachHang.Tag.ToString)
        m_CT_HInfo.TenKhang = txtTenKH.Text
        m_CT_HInfo.MaKhang = cFilterKhachHang.ListEditValue(3)
        m_CT_HInfo.KyHieuKhang = cFilterKhachHang.ListEditValue(3)
        m_CT_HInfo.MstKhang = cFilterKhachHang.ListEditValue(4)
        m_CT_HInfo.DiaChi = cFilterKhachHang.ListEditValue(5)
        If Not String.IsNullOrEmpty(DB_GetString(cboGiuongDV.EditValue)) Then
            m_CT_HInfo.IdGuongDichVu = cboGiuongDV.EditValue
        End If

        m_CT_HInfo.IdNhanVien = cboNhanVien.EditValue
        m_CT_HInfo.DienGiai = txtGhiChu.Text

        m_CT_HInfo.DoanhThu = Decimal.Parse(txtTongTienHang.Text)
        m_CT_HInfo.SoTienGiamGia = Decimal.Parse(txtGiamGiaTong.Text)
        If txtTTTienMat.Text <> "" Then
            m_CT_HInfo.TtTienMat = Decimal.Parse(txtTTTienMat.Text)
        End If

        If txtTTTheNh.Text <> "" Then
            m_CT_HInfo.TtTienNh = Decimal.Parse(txtTTTheNh.Text)
        End If

        If txtTTThe.Text <> "" Then
            m_CT_HInfo.TtTienThe1 = m_TTTheKM + m_TTTheThuc
            m_CT_HInfo.TheTienThe1 = m_TTTheThuc
            m_CT_HInfo.TheTienKm1 = m_TTTheKM
        End If

        If txtConNo.Text <> "" Then
            m_CT_HInfo.TtTienNo = Decimal.Parse(txtConNo.Text)
        End If

        If cFilterThe.Tag IsNot Nothing AndAlso Not String.IsNullOrEmpty(cFilterThe.Tag.ToString) Then
            m_CT_HInfo.SoThe1 = New Guid(cFilterThe.Tag.ToString)
        End If

        If m_InputState = DataInputState.AddMode Then
            m_CT_HInfo.NgayTao = Date.Now
            m_CT_HInfo.NguoiTao = Generals.USER.Id
            m_CT_HInfo.NguoiSua = Generals.USER.Id
            m_CT_HInfo.NgaySua = Date.Now
        ElseIf m_InputState = DataInputState.EditMode Then
            m_CT_HInfo.NguoiSua = Generals.USER.Id
            m_CT_HInfo.NgaySua = Date.Now
        End If

        ''Insert cth, cth, update lai gia tri tien trong the
        'Insert  or update cth
        _CtHHddvService.SaveChungTu(m_CT_HInfo, m_lstHangHoa, m_lstDichVu, m_lstDelCtd)

        'Gan lai gia tri so chung tu sau khi luu dl
        C_SoChungTu.Text = m_CT_HInfo.PrefixCt + m_CT_HInfo.CtSo
    End Sub

    Private Sub AddNew()
        m_CT_HInfo = New CtHHddv
        m_InputState = DataInputState.AddMode
        ControlSetState()
        ClearPage()
        dteNgayCT.DateTime = DateTime.Now.Date
    End Sub

    Private Sub Edit()
        Try
            If m_CT_HInfo Is Nothing Then
                Message_Warning("Dữ liệu đã bị xóa!")
                Return
            End If
            m_InputState = DataInputState.EditMode
            ControlSetState()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Delete()
        If m_CT_HInfo Is Nothing Then
            Message_Warning("Dữ liệu đã bị xóa!")
            Return
        End If

        If grvCth_hddv.RowCount > 0 Then
            If Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE) Then
                'Dim obj As CT_H_ScInfo = CType(grvCTH_SC.GetRow(grvCTH_SC.FocusedRowHandle), CT_H_ScInfo)
                '_CtHHddvService.Delete(m_CT_HInfo)
                _CtHHddvService.DeleteChungTu(m_CT_HInfo)
                'Remove objcthsc ra khoi list cthsc
                m_CTH_ID = RemoveLeftGrid(m_LstCT_H_GInfo, m_CT_HInfo.Id)

                'RemoveHandler grvCTH_SC.FocusedRowChanged, AddressOf grvCTH_SC_FocusedRowChanged
                grvCth_hddv.RefreshData()
                'AddHandler grvCTH_SC.FocusedRowChanged, AddressOf grvCTH_SC_FocusedRowChanged

                If Not String.IsNullOrEmpty(m_CTH_ID.ToString) And Not VnsCheck.IsNullGuid(m_CTH_ID) Then
                    Set_focus(m_CTH_ID)
                    SetObjectToControl()
                    TongSoTien()
                End If
                m_InputState = DataInputState.ViewMode

            Else
                Return
            End If

            If m_LstCT_H_GInfo.Count = 0 Then
                m_InputState = DataInputState.AddMode
                ClearPage()
                grcCth_hddv.DataSource = Nothing

            End If

            ControlSetState()

        End If
    End Sub

    Private Sub SaveData()

        If Not Check_input() Then
            Exit Sub
        End If

        'Check hang ton kho xem co du hang xua ko????

        frmProgress.Instance.Thread = AddressOf GetControlToOBject
        frmProgress.Instance.Show_Progress()
        frmProgress.Instance.SetFinishText("Data saved")

        'GetControlToOBject()

        Select Case m_InputState
            Case DataInputState.AddMode
                'Dim obj_temp As CT_H_ScInfo = New CT_H_ScInfo
                'Convert cth_sc sang ct_hg va add vao list
                Dim obj_temp As CT_H_GInfo = ConvertObjCtHtoCtHG(m_CT_HInfo)

                m_LstCT_H_GInfo.Add(obj_temp)

                grcCth_hddv.DataSource = m_LstCT_H_GInfo
                m_CTH_ID = m_CT_HInfo.Id

                grvCth_hddv.RefreshData()
                'SetObjectToControl()
            Case DataInputState.EditMode
                Dim i As Integer = grvCth_hddv.FocusedRowHandle
                m_LstCT_H_GInfo = UpdateListCth(m_LstCT_H_GInfo, m_CT_HInfo)
                grvCth_hddv.RefreshData()
                grvCth_hddv.FocusedRowHandle = i
        End Select

        m_InputState = DataInputState.ViewMode
        ControlSetState()

        If grvHangHoa.RowCount > 0 Then
            grvHangHoa.FocusedRowHandle = 0
        End If

        btnAdd.Focus()
        'DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Function UpdateListCth(ByVal lst As List(Of CT_H_GInfo), ByVal cth As CtHHddv) As List(Of CT_H_GInfo)
        For Each objCthInfo As CT_H_GInfo In lst
            If objCthInfo.Id = cth.Id Then
                objCthInfo.Id = cth.Id
                objCthInfo.CtSo = cth.CtSo
                objCthInfo.MaLoaiCt = cth.MaLoaiCt
                objCthInfo.NgayCt = cth.NgayCt
                objCthInfo.NgayGhi = cth.NgayGhi
                Exit For
            End If
        Next

        Return lst
    End Function

    Private Function Check_input() As Boolean

        If String.IsNullOrEmpty(cFilterKhachHang.Text) Then
            Message_Warning("Bạn chưa chọn khách hàng!")
            Return False
        End If

        If String.IsNullOrEmpty(DB_GetString(cboNhanVien.EditValue)) OrElse VnsCheck.IsNullGuid(cboNhanVien.EditValue) Then
            Message_Warning("Bạn chưa chọn nhân viên")
            Return False
        End If

        'Check hang hoa, dich vu
        For Each obj As CtDHddv In m_lstHangHoa
            If grvHangHoa.RowCount = 1 Then
                If VnsCheck.IsNullGuid(obj.IdHanghoa) And obj.SoLuong = 0 And obj.DonGia = 0 And obj.TyLeGiamGia = 0 And obj.TyLeThueGtgt = 0 And obj.NoiDung = "" Then
                    m_lstHangHoa.Clear()
                    grvHangHoa.RefreshData()
                    Exit For
                End If
            End If

            If VnsCheck.IsNullGuid(obj.IdHanghoa) Then
                Message_Warning("Bạn chưa chọn hàng hóa!")
                Return False
            End If

            If obj.SoLuong = 0 Then
                Message_Warning("Bạn chưa nhập số lượng!")
                Return False
            End If

            If obj.DonGia = 0 Then
                Message_Warning("Bạn chưa nhập đơn giá!")
                Return False
            End If
        Next

        For Each obj As CtDHddv In m_lstDichVu

            If grvDichVu.RowCount = 1 Then
                If VnsCheck.IsNullGuid(obj.IdDichvu) And obj.DonGia = 0 And obj.TyLeGiamGia = 0 And obj.TyLeThueGtgt = 0 And obj.NoiDung = "" Then
                    m_lstDichVu.Clear()
                    grvDichVu.RefreshData()
                    Exit For
                End If
            End If

            If VnsCheck.IsNullGuid(obj.IdDichvu) Then
                Message_Warning("Bạn chưa chọn loại hình dịch vụ!")
                Return False
            End If

            If obj.DonGia = 0 Then
                Message_Warning("Bạn chưa nhập đơn giá")
                Return False
            End If
        Next

        If grvDichVu.RowCount = 0 And grvHangHoa.RowCount = 0 Then
            Message_Warning("Bạn phải nhập một trong hai hàng hóa hoặc dịch vụ!")
            Return False
        End If

        Return True
    End Function

    Public Function RemoveLeftGrid(ByRef _tempList As List(Of CT_H_GInfo), ByVal _ID As Guid) As Guid
        For i = _tempList.Count - 1 To 0 Step -1
            If _tempList.Count = 1 Then
                _tempList.RemoveAt(0)
                Return Guid.Empty
            End If
            If _tempList(i).Id = _ID Then
                '
                _tempList.RemoveAt(i)
                '
                If (i = 0) Then
                    i = 1
                End If
                _ID = _tempList(i - 1).Id
                'SetObjectToControl()
                Return _ID
            End If
        Next

        Return Guid.Empty
    End Function

    Private Sub Set_focus(ByVal str_id As Guid)
        Dim lst_temp As List(Of CT_H_GInfo) = grvCth_hddv.DataSource
        For i As Integer = 0 To lst_temp.Count - 1
            If lst_temp(i).Id = str_id Then
                grvCth_hddv.FocusedRowHandle = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub ClearPage()
        TNCommon.SelectFirst(cboLoaiCT)
        dteNgayCT.EditValue = Date.Now.Date
        C_SoChungTu.Text = ""
        txtTuGio.EditValue = Nothing
        txtDenGio.EditValue = Nothing
        'dengio
        cFilterKhachHang.Tag = String.Empty
        cFilterKhachHang.Text = String.Empty
        txtTenKH.Text = String.Empty
        cboNhanVien.EditValue = String.Empty
        cboGiuongDV.EditValue = String.Empty
        txtTenNhanVien.Text = ""
        txtGhiChu.Properties.ReadOnly = False

        txtTienCongSC.EditValue = 0
        txtTongCongSC.EditValue = 0
        txtGiamGiaSC.EditValue = 0

        txtTienHang.EditValue = 0
        txtTongCong.EditValue = 0
        txtGiamGia.EditValue = 0

        txtTongTienHang.EditValue = 0
        txtTongTienTT.EditValue = 0
        txtGiamGiaTong.EditValue = 0

        txtTTThe.EditValue = 0
        txtTTTheNh.EditValue = 0
        txtTTTienMat.EditValue = 0
        cFilterThe.Tag = String.Empty
        cFilterThe.Text = String.Empty
        txtConNo.EditValue = 0
        m_lstDichVu = New List(Of CtDHddv)
        m_lstDichVu.Add(New CtDHddv)
        grcDichVu.DataSource = m_lstDichVu
        grvDichVu.RefreshData()

        m_lstHangHoa = New List(Of CtDHddv)
        m_lstHangHoa.Add(New CtDHddv)
        grcHangHoa.DataSource = m_lstHangHoa
        grvHangHoa.RefreshData()
    End Sub

    Private Sub SetFocus_AfterAddRow(ByVal _GridView As GridView, ByVal i As Integer)
        If _GridView.RowCount > 0 Then
            _GridView.FocusedRowHandle = i
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        End If
    End Sub

    Private Sub TienThanhToan()

        Dim TTTienMat As Decimal
        Dim TTTienTheNh As Decimal
        Dim TTTienThe As Decimal
        Dim TongTien As Decimal

        Try
            If txtTTTienMat.Text <> "" Then
                TTTienMat = Decimal.Parse(txtTTTienMat.Text)
            Else
                TTTienMat = 0
            End If

            If txtTTThe.Text <> "" Then
                TTTienThe = Decimal.Parse(txtTTThe.Text)
            Else
                TTTienThe = 0
            End If

            If txtTTTheNh.Text <> "" Then
                TTTienTheNh = Decimal.Parse(txtTTTheNh.Text)
            Else
                TTTienTheNh = 0
            End If

            If txtTongTienTT.Text <> "" Then
                TongTien = Decimal.Parse(txtTongTienTT.Text)
            End If

            txtTongTT.Text = (TTTienMat + TTTienThe + TTTienTheNh).ToString
            txtConNo.Text = (TongTien - TTTienMat - TTTienThe - TTTienTheNh).ToString
        Catch ex As OverflowException
            Message_Warning("Giá trị nhập vào không hợp lệ")
            Return
        End Try
    End Sub

    Private Sub DeleteRow()
        If XtraTabControl1.SelectedTabPage.Name = "xtpHangHoa" Then
            If grvHangHoa.RowCount > 0 Then
                Dim i As Integer = grvHangHoa.FocusedRowHandle
                Dim objHanghoa As CtDHddv = CType(grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle), CtDHddv)

                If Not String.IsNullOrEmpty(objHanghoa.Id.ToString) Then
                    If Not Message_Confirm("Bạn có chắc chắn muốn xóa?") Then
                        grvHangHoa.FocusedRowHandle = i
                        Return
                    End If
                End If

                grvHangHoa.FocusedRowHandle = i
                m_lstDelCtd.Add(objHanghoa)
                grvHangHoa.DeleteSelectedRows()
                grvHangHoa.RefreshData()
                TongSoTien()

            Else
                Message_Warning("Không có bản ghi nào được chọn!")
            End If
        Else
            If grvDichVu.RowCount > 0 Then

                Dim j As Integer = grvDichVu.FocusedRowHandle

                Dim objDichVu As CtDHddv = CType(grvDichVu.GetRow(grvDichVu.FocusedRowHandle), CtDHddv)
                If Not String.IsNullOrEmpty(objDichVu.Id.ToString) AndAlso Not Message_Confirm("Bạn có chắc chắn muốn xóa?") Then
                    grvDichVu.FocusedRowHandle = j
                    Return
                End If

                grvDichVu.FocusedRowHandle = j
                m_lstDelCtd.Add(objDichVu)
                grvDichVu.DeleteSelectedRows()
                grvDichVu.RefreshData()
                TongSoTien()

            Else
                Message_Warning("Không có bản ghi nào được chọn!")
            End If
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            AddNew()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            SaveData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Message_Warning("Chức năng đang được hoàn thiện!")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            If grvCth_hddv.RowCount > 0 Then
                m_InputState = DataInputState.ViewMode
                grvCth_hddv.FocusedRowHandle = 0
                grvCth_hddv_FocusedRowChanged(grvCth_hddv, Nothing)
                SetObjectToControl()
                TongSoTien()
            Else
                ClearPage()
                m_InputState = DataInputState.AddMode
            End If
            ControlSetState()
            btnAdd.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinter.Click
        Try
            If (m_MA_LOAI_CT = "SPA_BAN_HANG") Then
                Message_Warning("Chức năng đang được hoàn thiện!")
                Return
            End If
            '
            Dim rp As rpHddv = New rpHddv(m_lstHangHoa, m_lstDichVu, m_CT_HInfo)
            rp.Parameters.Item("TTThe").Value = txtTTThe.Text
            rp.Parameters.Item("TTTheNH").Value = txtTTTheNh.Text
            rp.Parameters.Item("TTTienMat").Value = txtTTTienMat.Text
            rp.Parameters.Item("TongTT").Value = txtTongTT.Text
            rp.Parameters.Item("ConNo").Value = txtConNo.Text
            rp.Parameters.Item("DonVi").Value = Generals.DON_VI.TenDonvi
            rp.Parameters.Item("DiaChi").Value = Generals.DON_VI.DiaChi
            rp.ShowPreviewDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Try
            DialogResult = DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvCth_hddv_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Try
            If grvCth_hddv.RowCount > 0 Then
                'If setFocus Then
                Dim obj As CT_H_GInfo = CType(grvCth_hddv.GetRow(grvCth_hddv.FocusedRowHandle), CT_H_GInfo)
                If obj Is Nothing Then
                    ClearPage()
                    Return
                End If
                m_CTH_ID = obj.Id
                SetObjectToControl()
                TongSoTien()

            Else
                ClearPage()
                m_InputState = DataInputState.AddMode
                ControlSetState()
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvDichVu_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvDichVu.CellValueChanged
        Try
            Try
                Dim objDichVu As CtDHddv = CType(grvDichVu.GetRow(grvDichVu.FocusedRowHandle), CtDHddv)

                If e.Column.Name.Equals("DON_GIA_DV") Then
                    objDichVu.DoanhThu = objDichVu.DonGia
                    objDichVu.SoTienGiamGia = objDichVu.DoanhThu * objDichVu.TyLeGiamGia / 100
                    objDichVu.SoTienHh = objDichVu.DoanhThu * objDichVu.TyLeHh / 100
                End If

                If e.Column.Name.Equals("TY_LE_GIAM_GIA_DV") Then
                    objDichVu.SoTienGiamGia = objDichVu.DoanhThu * objDichVu.TyLeGiamGia / 100
                End If

                If e.Column.Name.Equals("TY_LE_HH_DV") Then
                    objDichVu.SoTienHh = objDichVu.DoanhThu * objDichVu.TyLeHh / 100
                End If
                grvDichVu.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
            TongSoTien()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvHangHoa_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvHangHoa.CellValueChanged
        Try
            Try
                Dim objhanghoa As CtDHddv = CType(grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle), CtDHddv)

                If e.Column.Name.Equals("DON_GIA") OrElse e.Column.Name.Equals("SO_LUONG") Then
                    objhanghoa.DoanhThu = objhanghoa.DonGia * objhanghoa.SoLuong

                    objhanghoa.SoTienGiamGia = objhanghoa.DoanhThu * objhanghoa.TyLeGiamGia / 100
                    objhanghoa.SoTienHh = objhanghoa.DoanhThu * objhanghoa.TyLeHh / 100
                End If

                If e.Column.Name.Equals("TY_LE_GIAM_GIA") Then
                    objhanghoa.SoTienGiamGia = objhanghoa.DoanhThu * objhanghoa.TyLeGiamGia / 100
                End If

                If e.Column.Name.Equals("TY_LE_HH") Then
                    objhanghoa.SoTienHh = objhanghoa.DoanhThu * objhanghoa.TyLeHh / 100
                End If
                grvHangHoa.RefreshData()
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
            TongSoTien()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvHangHoa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvHangHoa.KeyDown
        Try
            If m_InputState = DataInputState.AddMode OrElse m_InputState = DataInputState.EditMode Then
                If e.KeyCode <> Keys.Enter Then
                    Return
                End If
                If (GridHelper.CheckAddNewRow(grvHangHoa)) Then
                    m_lstHangHoa.Add(New CtDHddv)
                    grvHangHoa.RefreshData()
                    SetFocus_AfterAddRow(grvHangHoa, m_lstHangHoa.Count - 1)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvDichVu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvDichVu.KeyDown
        Try
            If m_InputState = DataInputState.AddMode OrElse m_InputState = DataInputState.EditMode Then
                If e.KeyCode <> Keys.Enter Then
                    Return
                End If
                If (GridHelper.CheckAddNewRow(grvDichVu)) Then
                    m_lstDichVu.Add(New CtDHddv)
                    grvDichVu.RefreshData()
                    SetFocus_AfterAddRow(grvDichVu, m_lstDichVu.Count - 1)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTTTheNh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTTTheNh.TextChanged, txtTTTienMat.TextChanged, txtTTThe.TextChanged
        Try
            If m_OnLoadData Then
                Return
            End If
            TienThanhToan()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmHDDV_ChiTiet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If m_InputState <> DataInputState.ViewMode Then
                Select Case e.KeyCode
                    Case Keys.F4
                        If XtraTabControl1.SelectedTabPage.Name = "xtpHangHoa" Then
                            m_lstHangHoa.Add(New CtDHddv)
                            grvHangHoa.RefreshData()
                            grvHangHoa.FocusedRowHandle = grvHangHoa.RowCount - 1
                        Else
                            m_lstDichVu.Add(New CtDHddv)
                            grvDichVu.RefreshData()
                            grvDichVu.FocusedRowHandle = grvDichVu.RowCount - 1
                        End If
                    Case Keys.F8
                        DeleteRow()
                    Case e.Alt AndAlso Keys.H
                        XtraTabControl1.SelectedTabPage = xtpHangHoa
                        grvHangHoa.Focus()
                    Case e.Alt AndAlso Keys.D
                        XtraTabControl1.SelectedTabPage = xtpDichVu
                        grvDichVu.Focus()
                    Case e.Control AndAlso Keys.Tab
                        txtTTTienMat.Focus()
                End Select
            End If

            Select Case e.KeyCode
                Case Keys.Escape
                    If CheckStatusEscape(m_InputState) Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboNhanVien_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNhanVien.EditValueChanged
        Try
            Dim obj_nhanVien As SpaDmNhanvien = CType(ComboHelper.GetSelectData(cboNhanVien), SpaDmNhanvien)
            If obj_nhanVien IsNot Nothing Then
                txtTenNhanVien.Text = obj_nhanVien.Ten
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboLoaiChungTu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoaiCT.EditValueChanged
        Try
            Dim obj_CT As HtLoaichungtu = CType(ComboHelper.GetSelectData(cboLoaiCT), HtLoaichungtu)
            If obj_CT IsNot Nothing Then
                ConfigByLoaiCT(obj_CT)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboChonDichVu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChonDichVu.Click
        Try
            Dim frm As frmChonDichVu = CType(ObjectFactory.GetObject("frmChonDichVu"), frmChonDichVu)
            Dim lstDichVu As List(Of SpaDmDichVu) = frm.Show_Form()

            If lstDichVu Is Nothing Then
                Return
            End If

            If lstDichVu.Count > 0 Then
                XtraTabControl1.SelectedTabPage = xtpDichVu
                Dim obj As CtDHddv
                m_lstDichVu.Clear()
                For Each objdichvu As SpaDmDichVu In lstDichVu
                    obj = New CtDHddv
                    obj.IdDichvu = objdichvu.Id
                    obj.DonGia = objdichvu.DonGia
                    obj.TenHhDv = objdichvu.Ten
                    obj.DoanhThu = objdichvu.DonGia
                    m_lstDichVu.Add(obj)
                Next


                grcDichVu.DataSource = m_lstDichVu
                grvDichVu.RefreshData()
                TongSoTien()
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Customs filter"

    Private Sub cFilterKhachHang_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.AfterFilter
        Try
            txtTenKH.Text = cFilterKhachHang.ListEditValue(1)
            cFilterKhachHang.Tag = cFilterKhachHang.ListEditValue(0)
            If cFilterKhachHang.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterKhachHang_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.FirstBinddata, cFilterKhachHang.AfterQuickAdd
        Try
            cFilterKhachHang.C_DATA_SOURCE = DataHelper.ToDataTable(_DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterKhachHang_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterKhachHang.ClearFilterData
        Try
            txtTenKH.Text = String.Empty
            cFilterKhachHang.Tag = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterThe_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterThe.AfterFilter
        Try
            If (m_OnLoadData) Then
                Return
            End If
            Dim objThe As SpaLsThe = New SpaLsThe
            m_TTTheThuc = 0
            m_TTTheKM = 0
            Dim _tienThe As Decimal = 0
            Dim _tienKm As Decimal = 0
            Dim TienThanhToan As Decimal = 0
            If Not String.IsNullOrEmpty(cFilterThe.ListEditValue(0)) AndAlso Not VnsCheck.IsNullGuid(cFilterThe.ListEditValue(0)) Then
                objThe = _SpaLsTheService.GetRemainCardInfo(New Guid(cFilterThe.ListEditValue(0)), m_CTH_ID)
            End If

            _tienThe = objThe.TienThe
            _tienKm = objThe.TienKhuyenMai

            If Not String.IsNullOrEmpty(txtTongTienTT.Text) Then
                TienThanhToan = Decimal.Parse(txtTongTienTT.Text)
            End If

            If TienThanhToan <= _tienKm Then
                m_TTTheThuc = 0
                m_TTTheKM = TienThanhToan
            Else
                m_TTTheKM = _tienKm

                If TienThanhToan - _tienKm >= _tienThe Then
                    m_TTTheThuc = _tienThe
                Else
                    m_TTTheThuc = TienThanhToan - _tienKm
                End If
            End If

            txtTTThe.EditValue = m_TTTheKM + m_TTTheThuc
            cFilterThe.Tag = cFilterThe.ListEditValue(0)
            If cFilterThe.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterThe_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterThe.FirstBinddata, cFilterThe.AfterQuickAdd
        Try
            cFilterThe.C_DATA_SOURCE = DataHelper.ToDataTable(_SpaDmTheService.GetAll)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterThe_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterThe.ClearFilterData
        Try
            txtTTThe.Text = "0"
            cFilterThe.Tag = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_HangHoa_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_HangHoa.AfterFilter
        Try
            Dim obj_hanghoa As CtDHddv = CType(grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle), CtDHddv)
            If obj_hanghoa Is Nothing Then
                Return
            End If
            If cfilter_HangHoa.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                obj_hanghoa.IdHanghoa = New System.Guid(cfilter_HangHoa.OwnerEdit.A_LIST_VALUES(0))
                obj_hanghoa.TenHhDv = cfilter_HangHoa.OwnerEdit.A_LIST_VALUES(2)
                obj_hanghoa.Dvt = cfilter_HangHoa.OwnerEdit.A_LIST_VALUES(4)
                grvHangHoa.SetRowCellValue(grvHangHoa.FocusedRowHandle, "TenHhDv", obj_hanghoa.TenHhDv)
                grvHangHoa.SetRowCellValue(grvHangHoa.FocusedRowHandle, "Dvt", obj_hanghoa.Dvt)
            End If
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_HangHoa_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_HangHoa.FisrtBinddata
        Try
            If cfilter_HangHoa.C_DATA_SOURCE Is Nothing Then
                cfilter_HangHoa.C_DATA_SOURCE = DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
                cfilter_HangHoa.Editors.A_DATA_SOURCE = cfilter_HangHoa.C_DATA_SOURCE
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_HangHoa_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_HangHoa.ClearDataFilter
        Try
            Dim obj_hanghoa As CtDHddv = CType(grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle), CtDHddv)
            If obj_hanghoa Is Nothing Then
                Return
            End If
            If cfilter_HangHoa.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                obj_hanghoa.IdHanghoa = Guid.Empty
                obj_hanghoa.TenHhDv = ""
                obj_hanghoa.Dvt = ""
                grvHangHoa.RefreshData()
                'grvHangHoa.SetRowCellValue(grvHangHoa.FocusedRowHandle, "TenHhDv", obj_hanghoa.TenHhDv)
                'grvHangHoa.SetRowCellValue(grvHangHoa.FocusedRowHandle, "Dvt", obj_hanghoa.Dvt)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_DichVu_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_DichVu.AfterFilter
        Try
            Dim obj_DichVu As CtDHddv = CType(grvDichVu.GetRow(grvDichVu.FocusedRowHandle), CtDHddv)
            If obj_DichVu Is Nothing Then
                Return
            End If
            If cfilter_DichVu.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                obj_DichVu.IdDichvu = New System.Guid(cfilter_DichVu.OwnerEdit.A_LIST_VALUES(0))
                obj_DichVu.TenHhDv = cfilter_DichVu.OwnerEdit.A_LIST_VALUES(2)
                obj_DichVu.DonGia = cfilter_DichVu.OwnerEdit.A_LIST_VALUES(4)
                grvDichVu.SetRowCellValue(grvDichVu.FocusedRowHandle, "TenHhDv", obj_DichVu.TenHhDv)
                grvDichVu.SetRowCellValue(grvDichVu.FocusedRowHandle, "DonGia", cfilter_DichVu.OwnerEdit.A_LIST_VALUES(4))
            End If
            'grcPhuTung_View.RefreshData()
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_DichVu_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_DichVu.FisrtBinddata
        Try
            If cfilter_DichVu.C_DATA_SOURCE Is Nothing Then
                cfilter_DichVu.C_DATA_SOURCE = DataHelper.ToDataTable(_SpaDmDichVuService.GetAllByDonviID(Generals.DON_VI.Id))
                cfilter_DichVu.Editors.A_DATA_SOURCE = cfilter_DichVu.C_DATA_SOURCE
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cfilter_dichVu_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles cfilter_DichVu.ClearDataFilter
        Try
            Dim obj_DichVu As CtDHddv = CType(grvDichVu.GetRow(grvDichVu.FocusedRowHandle), CtDHddv)
            If obj_DichVu Is Nothing Then
                Return
            End If
            If cfilter_DichVu.OwnerEdit.A_LIST_VALUES.Count > 0 Then
                obj_DichVu.IdDichvu = Guid.Empty
                obj_DichVu.TenHhDv = ""
                obj_DichVu.DonGia = 0
                obj_DichVu.DoanhThu = 0
                grvDichVu.RefreshData()
                'grvDichVu.SetRowCellValue(grvDichVu.FocusedRowHandle, "TenHhDv", obj_DichVu.TenHhDv)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Commons"

    Function ConvertObjCtHtoCtHG(ByVal objCth As CtHHddv) As CT_H_GInfo
        Try
            Dim objCTHG As New Extend.CT_H_GInfo
            objCTHG.Id = objCth.Id
            objCTHG.CtSo = objCth.CtSo
            objCTHG.MaLoaiCt = objCth.MaLoaiCt
            objCTHG.NgayCt = objCth.NgayCt
            objCTHG.NgayGhi = objCth.NgayGhi

            Return objCTHG
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function CheckStatusEscape(ByVal inputState As DataInputState) As Boolean
        Try
            Dim m_InputState As DataInputState
            m_InputState = inputState
            If m_InputState = DataInputState.AddMode Then
                Dim dr As DialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình nhập và mọi dữ liệu chưa lưu sẽ bị xóa mất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If dr = DialogResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Message_Error(ex)
            Return False
        End Try
    End Function

#End Region

End Class