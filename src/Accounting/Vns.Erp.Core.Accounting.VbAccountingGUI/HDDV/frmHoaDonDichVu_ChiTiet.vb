Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.Utils

Public Class frmHoaDonDichVu_ChiTiet

#Region "Property"
    Public Property HtLoaichungtuService As IHtLoaichungtuService
    Public Property KtCtHHddvService As IKtCtHHddvService
    Public Property KtCtDHddvService As IKtCtDHddvService
    Public Property DmNgoaiteService As IDmNgoaiteService
    Public Property LsTygiaService As ILsTygiaService
    Public Property CtHoadonService As ICtHoadonService
    Public Property DmHopdongService As IDmHopdongService
    Public Property DmVuviecService As IDmVuviecService
    Public Property DmPhongbanService As IDmPhongbanService
    Public Property DmKhoanphiService As IDmKhoanphiService
    Public Property DmTudo1Service As IDmTudo1Service
    Public Property DmTudo2Service As IDmTudo2Service
    Public Property DmTudo3Service As IDmTudo3Service
    Public Property DmTudo4Service As IDmTudo4Service
    Public Property DmTudo5Service As IDmTudo5Service
    Public Property DmPtqtService As IDmPtqtService
    Public Property DmTaikhoanService As IDmTaikhoanService
    Public Property KtKhoasoThangService As IKtKhoasoThangService
    Public Property DmKhangService As IDmKhangService
    Public Property DmThueService As IDmThueService

#End Region

#Region "Variables and Messages"
    Private obj_ct_h As KtCtHHddv = New KtCtHHddv()
    Private lstobj_ct_d As List(Of KtCtDHddv) = New List(Of KtCtDHddv)
    Private lstobj_ct_dThue As List(Of KtCtDHddv) = New List(Of KtCtDHddv)
    Private del_lstobj_ct_d As List(Of KtCtDHddv) = New List(Of KtCtDHddv)
    'Private lstobj_ct_h As List(Of KtCtHHddv)
    Private m_InputState As FormGlobals.DataInputState
    Private m_CTH_ID As Guid
    Private m_MA_LOAI_CT As String
    Private lstTKLQ As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
    'Private sotien As Decimal
    Private tongtienthue As Decimal
    'Public lstobj_ct_thue As List(Of CT_ThueInfo) = New List(Of CT_ThueInfo)
    'Public del_lstobj_ct_thue As List(Of CT_ThueInfo) = New List(Of CT_ThueInfo)
    Private obj_ct_hd As CtHoadon
    Private ma_tkthue As String
    Private id_tkthue As String
    Private objHTCT As HtLoaichungtu
    'Private objHT_LoaiCT As HtLoaichungtu = New HtLoaichungtu()
    Public lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Private TK_DATA_SOURCE As DataTable = Nothing
    Private KHANG_DATA_SOURCE As DataTable = Nothing
    Dim msgKhoaSo As String = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!"
    ''' <summary>
    ''' Bien phan biet dang trong trang thai load du lieu
    ''' </summary>
    ''' <remarks></remarks>
    Private OnLoadData As Boolean = False
    Private _PhieuXuat As Decimal = 0
    Private flagDG As Decimal = 0
#End Region

#Region "Load Form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        'Validate control
        Commons.RequireInputControls = New Control() {daeNGAY_CT, daeNGAY_GHI}
        Commons.ApplyRequireInputValidate(Commons.RequireInputControls)
    End Sub

    Public Function Show_Form(ByVal CTH_ID As Guid, ByVal MA_LOAI_CT As String, ByVal TEN_LOAI_CT As String, ByVal lstcthg As List(Of Extend.CT_H_GInfo), ByVal eState As DataInputState) As KtCtHHddv
        'lstobj_ct_h = KtCtHHddvService.GetObjectGetObjectAllByLoaiChungTu(Generals.DON_VI.Id, MA_LOAI_CT)
        Try
            Form_SetText(Me, TEN_LOAI_CT, DataInputState.NoCaption)
            Form_InitDialog(Me)
            Panel_InitControl(grpSMQR, "CT_H_HDDV")

            Control_SetRequire(grlLOAI_CT_ID, True)
            m_InputState = eState
            m_CTH_ID = CTH_ID
            If lstcthg IsNot Nothing Then
                lstobj_ct_h_gg = lstcthg
            End If
            m_MA_LOAI_CT = MA_LOAI_CT
            Dim objLCT As HtLoaichungtu = HtLoaichungtuService.GetByMA_LOAI_CT(m_MA_LOAI_CT, Generals.DON_VI.Id)
            objHTCT = objLCT
            _PhieuXuat = objLCT.PhieuXuat
            ucStatus.LCT_STATUS = objLCT.Id
            ucStatus.Visible = Generals.Ts_PheDuyetChungTu
            ucStatus.Enabled = Generals.Ts_PheDuyetChungTu
            GRV_CTHHDDV.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            ConfigByLoaiCT(_PhieuXuat)
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
            AddHandler GRV_CTHHDDV.FocusedRowChanged, AddressOf GRV_CTHHDDV_FocusedRowChanged
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
            GRC_CTHHDDV.DataSource = Nothing
            GRC_CTHHDDV.DataSource = lstobj_ct_h_gg
            For i = 0 To lstobj_ct_h_gg.Count - 1
                If m_CTH_ID = lstobj_ct_h_gg(i).Id Then
                    Me.GRV_CTHHDDV.FocusedRowHandle = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub ConfigByLoaiCT(ByVal PhieuXuat As Decimal)
        'ban hang
        If PhieuXuat = 1 Then
            _GridView.Columns("MaTkNo").Visible = False
            _GridView.Columns("TenTkNo").Visible = False
            _GridView.Columns("MaTkNoGtgt").Visible = False
            _GridView.Columns("MaTkCo").Visible = True
            _GridView.Columns("TenTkCo").Visible = True
            _GridView.Columns("MaTkCoGtgt").Visible = True
            lblTaikhoan.Text = "TK Nợ"
        Else
            _GridView.Columns("MaTkNo").Visible = True
            _GridView.Columns("TenTkNo").Visible = True
            _GridView.Columns("MaTkNoGtgt").Visible = True
            _GridView.Columns("MaTkCo").Visible = False
            _GridView.Columns("TenTkCo").Visible = False
            _GridView.Columns("MaTkCoGtgt").Visible = False
            lblTaikhoan.Text = "TK Có"
        End If
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (GRV_CTHHDDV.GetSelectedRows().Length > 0) Then
            If (GRV_CTHHDDV.RowCount <> 0) Then
                Dim grtCTHG As Extend.CT_H_GInfo = CType(GRV_CTHHDDV.GetRow(GRV_CTHHDDV.GetSelectedRows(0)), Extend.CT_H_GInfo)
                m_CTH_ID = grtCTHG.Id
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub grv_focus()
        Dim lst As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
        lst = GRV_CTHHDDV.DataSource
        For i As Integer = 0 To GRV_CTHHDDV.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                GRV_CTHHDDV.FocusedRowHandle = i
                lst(i).Ghi = obj_ct_h.Ghi
                GRV_CTHHDDV.RefreshData()
            End If
        Next
    End Sub

    Private Sub Init_Data()
        OnLoadData = True
        'grlTaiKhoan.EditValue =
        Select Case m_InputState
            Case DataInputState.AddMode
                DatTrangThaiControl()
                BindLookup()
                daeNGAY_CT.DateTime = DateTime.Now
                'grlLOAI_CT_ID.EditValue = m_MA_LOAI_CT
                TNCommon.SelectFirst(grlLOAI_CT_ID)
                'SetColNgoaiTe(chkNgoaiTe.Checked)
                'Dim objHTCT As HtLoaichungtu = _
                '        grlLOAI_CT_ID.Properties.View.GetRow( _
                '            grlLOAI_CT_ID.Properties.GetIndexByKeyValue(grlLOAI_CT_ID.EditValue))
                'objHT_LoaiCT = objHTCT
                'SetCol(objHT_LoaiCT)
                lstobj_ct_d.Add(New KtCtDHddv())
                _GridControl.DataSource = lstobj_ct_d
                'ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_MA_LOAI_CT, _GridView.Name, _GridView)
                SetColNgoaiTe()
                'SetTongTienThue()
                TongSoTien()
            Case Else
                DatTrangThaiControl()
                BindLookup()
                SetObjectToControl()
                ' SetTongTienThue()
                TongSoTien()
        End Select
        Load_Grid(lstobj_ct_h_gg)
        OnLoadData = False
    End Sub

    Private Sub SaveData()
        GetControlToOBject()
        ' LoadDB()
    End Sub

    Private Sub GetControlToOBject()
        GetCthToObj()
        If obj_ct_hd Is Nothing Then
            obj_ct_hd = New CtHoadon()
        End If
        obj_ct_hd.Id = obj_ct_h.IdDoituongHoadon
        obj_ct_hd.MaDonvi = Generals.DON_VI.MaDonvi
        obj_ct_hd.MaSoThue = txtMST_KHANG.Text.Trim()
        obj_ct_hd.NgayHoadon = daeNGAY_CT.DateTime
        obj_ct_hd.SoHoadon = txtSO_HD1.Text.Trim()
        obj_ct_hd.SoSeri = txtSO_SERI_HD1.Text.Trim()
        obj_ct_hd.TenKhachhang = txtTEN_KHANG.Text.Trim()
        obj_ct_hd.TienThue = txttienthue.Text.Trim()
        obj_ct_hd.DoanhThu = txttienhangchuack.Text.Trim()
        obj_ct_hd.DiaChi = txtDIA_CHI.Text.Trim()
        obj_ct_hd.DonviId = Generals.DON_VI.Id
        obj_ct_hd.TongTien = txtTongTien.Text.Trim()
        If txtSO_NGAY_THANH_TOAN.Text <> "" Then
            obj_ct_hd.SoNgayThanhToan = Decimal.Parse(txtSO_NGAY_THANH_TOAN.Text)
        Else
            obj_ct_hd.SoNgayThanhToan = 0
        End If

        Select Case m_InputState
            Case DataInputState.AddMode
                Dim strmMonth As String
                strmMonth = Month(daeNGAY_GHI.DateTime).ToString
                Dim strYear As String
                strYear = Year(daeNGAY_GHI.DateTime).ToString
                C_SoChungTu_RP.r_SoCTPREFIX(obj_ct_h.IdLoaiCt, strmMonth, strYear, Generals.DON_VI.Id)
                obj_ct_h.CtSo = C_SoChungTu_RP.SO_CHUNG_TU
                obj_ct_h.PrefixCt = C_SoChungTu_RP.PREFIX
            Case Else
        End Select

        For Each objctd As KtCtDHddv In lstobj_ct_d
            If _PhieuXuat = 1 Then
                If cFilterTaiKhoanThue.ListEditValue.Count > 0 Then
                    objctd.TkNoIdGtgt = VnsConvert.CGuid(cFilterTaiKhoanThue.ListEditValue(0))
                    objctd.MaTkNoGtgt = cFilterTaiKhoanThue.ListEditValue(1)
                End If

                If cFilterTaiKhoan.ListEditValue.Count > 0 Then
                    objctd.TkNoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                    objctd.MaTkNo = cFilterTaiKhoan.ListEditValue(1)
                End If
            Else
                If cFilterTaiKhoanThue.ListEditValue.Count > 0 Then
                    objctd.TkCoIdGtgt = VnsConvert.CGuid(cFilterTaiKhoanThue.ListEditValue(0))
                    objctd.MaTkCoGtgt = cFilterTaiKhoanThue.ListEditValue(1)
                End If

                If cFilterTaiKhoan.ListEditValue.Count > 0 Then
                    objctd.TkCoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                    objctd.MaTkCo = cFilterTaiKhoan.ListEditValue(1)
                End If
            End If

            objctd.CthHddvId = obj_ct_h.Id
            objctd.PhanHe = 2

            objctd.IdKhangCo = obj_ct_h.KhangId
            objctd.KyHieuKhangCo = obj_ct_h.KyHieuKhang
            objctd.TenKhangCo = obj_ct_h.TenKhang
            objctd.MaKhangCo = obj_ct_h.MaKhang

            objctd.IdKhangNo = objctd.IdKhangCo
            objctd.KyHieuKhangNo = objctd.KyHieuKhangCo
            objctd.TenKhangNo = objctd.TenKhangCo
            objctd.MaKhangNo = objctd.MaKhangCo

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

        Dim IsInsert As Boolean = False
        Select Case (m_InputState)
            Case DataInputState.AddMode
                IsInsert = True
            Case DataInputState.EditMode
                IsInsert = False
        End Select
        KtCtHHddvService.SaveHDDVMuaBanHang(IsInsert, obj_ct_h, obj_ct_hd, lstobj_ct_d, del_lstobj_ct_d)

        'Gán lại số chứng từ 
        C_SoChungTu_RP.Text = obj_ct_h.PrefixCt + obj_ct_h.CtSo
    End Sub

    Private Sub GetCthToObj()

        obj_ct_h.MaLoaiCt = grlLOAI_CT_ID.EditValue

        obj_ct_h.KhangId = VnsConvert.CGuid(cFilter.ListEditValue(0))
        obj_ct_h.MaKhang = cFilter.ListEditValue(2)
        obj_ct_h.KyHieuKhang = cFilter.ListEditValue(3)

        obj_ct_h.MstKhang = txtMST_KHANG.Text.Trim()
        obj_ct_h.TenKhang = txtTEN_KHANG.Text.Trim()
        obj_ct_h.DiaChi = txtDIA_CHI.Text.Trim()

        'obj_ct_h.TEN_KHANG = txtTEN_KHANG.Text
        'obj_ct_h.DIA_CHI = txtDIA_CHI.Text
        'obj_ct_h.CT_SO = txtCT_SO.Text
        obj_ct_h.NgoaiTe = TNCommon.ParseDecimal(Not (cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)))
        'If (chkNgoaiTe.Checked) Then
        obj_ct_h.TyGia = txtTY_GIA1.Text
        'Else
        'cboNgoaiTe.EditValue = Generals.TS_NoiTe_ID.GIA_TRI
        'obj_ct_h.TY_GIA = 1
        'If cboNgoaiTe.EditValue = Generals.TS_NoiTe_ID.GIA_TRI Then
        '    obj_ct_h.SO_TIEN_NTE = 0
        'End If
        'End If
        Select Case m_InputState
            Case DataInputState.AddMode
                obj_ct_h.NguoiTao = Generals.USER.Id.ToString
                obj_ct_h.DaKhoaSo = 0
                obj_ct_h.BtTudong = 0
            Case Else
                obj_ct_h.NguoiSua = Generals.USER.Id.ToString
        End Select

        obj_ct_h.Ghi = Convert.ToDecimal(ucStatus.Value_info.ParameterValue)
        obj_ct_h.SoTien = txtTongTien.Text
        obj_ct_h.MaNte = cboNgoaiTe.Text
        obj_ct_h.NteId = cboNgoaiTe.EditValue
        'obj_ct_h.NGOAI_TE = TNCommon.ParseDecimal(chkNgoaiTe.Checked)
        obj_ct_h.NguoiNhanNopTien = txtNGUOI_NHAN_NOP_TIEN.Text
        obj_ct_h.DienGiai = txtDIEN_GIAI.Text
        obj_ct_h.NgayCt = daeNGAY_CT.DateTime
        obj_ct_h.NgayGhi = daeNGAY_GHI.DateTime
        obj_ct_h.SoHd = txtSO_HD1.Text.Trim()
        obj_ct_h.SoSeriHd = txtSO_SERI_HD1.Text.Trim()
        'obj_ct_h.NGAY_TAO = DateTime.Now
        If Generals.DON_VI.BoPhanTt = 1 Then
            obj_ct_h.DonviCt = Generals.DON_VI.DonviIdCha
            'obj_ct_h.MA_DONVI_CT = Generals.DON_VI.ma
        End If
        obj_ct_h.DonviId = Generals.DON_VI.Id
        obj_ct_h.MaDonvi = Generals.DON_VI.MaDonvi
        Dim drChungTu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
        obj_ct_h.IdLoaiCt = drChungTu.Id
        obj_ct_h.KyHieuLoaiCt = drChungTu.KyHieu
    End Sub

    Private Sub SetObjectToControl()
        If VnsCheck.IsNullGuid(m_CTH_ID) Then
            m_CTH_ID = obj_ct_h.Id
        End If

        obj_ct_h = KtCtHHddvService.GetById(m_CTH_ID)
        If (obj_ct_h Is Nothing) Then
            Return
        End If

        grlLOAI_CT_ID.EditValue = obj_ct_h.MaLoaiCt

        cboNgoaiTe.EditValue = obj_ct_h.NteId
        cFilter.Text = obj_ct_h.KyHieuKhang
        cFilter.Tag = obj_ct_h.KhangId

        ucStatus.Set_Status(obj_ct_h.Ghi)
        txtDIA_CHI.Text = obj_ct_h.DiaChi
        txtNGUOI_NHAN_NOP_TIEN.Text = obj_ct_h.NguoiNhanNopTien
        txtDIEN_GIAI.Text = obj_ct_h.DienGiai
        daeNGAY_CT.DateTime = obj_ct_h.NgayCt
        daeNGAY_GHI.DateTime = obj_ct_h.NgayGhi
        C_SoChungTu_RP.Text = obj_ct_h.PrefixCt + obj_ct_h.CtSo
        txtTEN_KHANG.Text = obj_ct_h.TenKhang
        txtMST_KHANG.Text = obj_ct_h.MstKhang
        txtTY_GIA1.Text = obj_ct_h.TyGia
        txtSO_HD1.Text = obj_ct_h.SoHd
        txtSO_SERI_HD1.Text = obj_ct_h.SoSeriHd
        lstobj_ct_d = New List(Of KtCtDHddv)
        lstobj_ct_d.AddRange(KtCtDHddvService.GetByCtHandNghiepVu(m_CTH_ID))

        If lstobj_ct_d.Count <= 0 Then Return

        If _PhieuXuat = 1 Then
            cFilterTaiKhoan.Tag = lstobj_ct_d(0).TkNoId
            cFilterTaiKhoan.Text = lstobj_ct_d(0).MaTkNo

            cFilterTaiKhoanThue.Tag = lstobj_ct_d(0).TkNoIdGtgt
            cFilterTaiKhoanThue.Text = lstobj_ct_d(0).MaTkNoGtgt
        Else
            cFilterTaiKhoan.Tag = lstobj_ct_d(0).TkCoId
            cFilterTaiKhoan.Text = lstobj_ct_d(0).MaTkCo

            cFilterTaiKhoanThue.Tag = lstobj_ct_d(0).TkCoIdGtgt
            cFilterTaiKhoanThue.Text = lstobj_ct_d(0).MaTkCoGtgt
        End If

        'End If
        _GridControl.DataSource = lstobj_ct_d
        ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_MA_LOAI_CT, _GridView.Name, _GridView)
        SetColNgoaiTe()
        grlLOAI_CT_ID.EditValue = obj_ct_h.MaLoaiCt
        grlLOAI_CT_ID.Properties.ReadOnly = True
        'objHT_LoaiCT = HtLoaichungtuService.GetById(obj_ct_h.IdLoaiCt)
        SetCol(objHTCT)

        obj_ct_hd = CtHoadonService.GetById(obj_ct_h.IdDoituongHoadon)
        If obj_ct_hd IsNot Nothing Then
            txtSO_NGAY_THANH_TOAN.Text = obj_ct_hd.SoNgayThanhToan.ToString
        Else
            txtSO_NGAY_THANH_TOAN.Text = 0
        End If

        ''Kiểm tra trạng thái có cho phép sửa hay không
        If Not (ucStatus.ChoPhepSuaCT) Then
            ucStatus.Enabled = False
        Else
            ucStatus.Enabled = True
        End If
    End Sub

    Private Sub BindLookup()

        'Bind danh muc thue
        Dim lstDMThue As List(Of DmThue) = New List(Of DmThue)
        lstDMThue.Add(New DmThue)

        lstDMThue.AddRange(_DmThueService.GetDmThueByabc(objHTCT))

        'ban hang
        'If _PhieuXuat = 1 Then
        '    lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 0))
        'Else
        '    lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 1))
        'End If

        'lstDMThue.AddRange(_DmThueService.g
        cboDMthue.DataSource = lstDMThue
        cboDMthue.DisplayMember = "TenThue"
        cboDMthue.ValueMember = "Id"
        cboDMthue.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDMthue.Columns.Add(New LookUpColumnInfo("TenThue", "Tên thuế"))

        'Bind loại chứng từ
        'Dim objColumnDefine As ArrayList
        RemoveHandler grlLOAI_CT_ID.EditValueChanged, AddressOf grlLOAI_CT_ID_EditValueChanged
        If String.IsNullOrEmpty(m_MA_LOAI_CT) Then
            m_MA_LOAI_CT = ""
        Else
            m_MA_LOAI_CT = m_MA_LOAI_CT + ""
        End If
        Dim lstLoaiChungTu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        lstLoaiChungTu.AddRange(HtLoaichungtuService.LikeObjetMA_LOAI_CT(m_MA_LOAI_CT, Generals.DonviID))
        grlLOAI_CT_ID.Properties.DataSource = lstLoaiChungTu
        grlLOAI_CT_ID.Properties.DisplayMember = "KyHieu"
        grlLOAI_CT_ID.Properties.ValueMember = "MaLoaiCt"
        AddHandler grlLOAI_CT_ID.EditValueChanged, AddressOf grlLOAI_CT_ID_EditValueChanged

        Dim lstNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
        lstNgoaite.AddRange(DmNgoaiteService.GetAll())
        'Dim listNgoaite As List(Of DmNgoaite) = New List(Of DmNgoaite)
        cboNgoaiTe.Properties.DisplayMember = "KyHieu"
        cboNgoaiTe.Properties.ValueMember = "Id"

        cboNgoaiTe.Properties.DataSource = lstNgoaite
        cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
        txtTY_GIA1.Text = "1"

        ''Bind TK No
        'Dim lstTKNo As List(Of DmTaikhoan) = DM_TaikhoanBO.Instance.GetAllByDonviID(Generals.DON_VI.Id)
        'cboTaiKhoanNo.DataSource = lstTKNo
        'cboTaiKhoanNo.DisplayMember = "MA_TAIKHOAN"
        'cboTaiKhoanNo.ValueMember = "MA_TAIKHOAN"
        'cboTaiKhoanNo.Columns.Add(New LookUpColumnInfo("MA_TAIKHOAN", "Mã tài khoản"))
        'cboTaiKhoanNo.Columns.Add(New LookUpColumnInfo("TEN_TAIKHOAN", "Tên tài khoản"))

        'Bind hợp đồng
        Dim lstHopDong As List(Of DmHopdong) = New List(Of DmHopdong)()
        lstHopDong.AddRange(DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstHopDong_temp As List(Of DmHopdong) = New List(Of DmHopdong)
        Dim obj_HD As DmHopdong = New DmHopdong
        lstHopDong_temp.Add(obj_HD)
        lstHopDong_temp.AddRange(lstHopDong)
        cboHopDong.DataSource = lstHopDong_temp

        cboHopDong.DisplayMember = "KyHieu"
        cboHopDong.ValueMember = "Id"
        cboHopDong.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã hợp đồng"))
        cboHopDong.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

        ''Bind vu viec
        Dim lstVuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViec.AddRange(DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstVuViec_temp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim obj_VV As DmVuviec = New DmVuviec
        lstVuViec_temp.Add(obj_VV)
        lstVuViec_temp.AddRange(lstVuViec)

        cboVuViec.DataSource = lstVuViec_temp
        cboVuViec.DisplayMember = "KyHieu"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã vụ việc"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))

        'Bind phong ban
        Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstPhongBan.AddRange(DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))

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
        lstKhoanPhi.AddRange(DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))

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
        lstTuDo1.AddRange(DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo1_temp As List(Of DmTudo1) = New List(Of DmTudo1)
        Dim obj_TD1 As DmTudo1 = New DmTudo1
        lstTuDo1_temp.Add(obj_TD1)
        lstTuDo1_temp.AddRange(lstTuDo1)

        cboDMTudo1.DataSource = lstTuDo1_temp
        cboDMTudo1.DisplayMember = "KyHieu"
        cboDMTudo1.ValueMember = "Id"
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo1.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục"))
        'Bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo2_temp As List(Of DmTudo2) = New List(Of DmTudo2)
        Dim obj_TD2 As DmTudo2 = New DmTudo2
        lstTuDo2_temp.Add(obj_TD2)
        lstTuDo2_temp.AddRange(lstTuDo2)

        cboDMTudo2.DataSource = lstTuDo2_temp
        cboDMTudo2.DisplayMember = "KyHieu"
        cboDMTudo2.ValueMember = "Id"
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo2.Columns.Add(New LookUpColumnInfo("TenDmTudo2", "Tên danh mục"))

        ''Bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo3_temp As List(Of DmTudo3) = New List(Of DmTudo3)
        Dim obj_TD3 As DmTudo3 = New DmTudo3
        lstTuDo3_temp.Add(obj_TD3)
        lstTuDo3_temp.AddRange(lstTuDo3)

        cboDMTudo3.DataSource = lstTuDo3_temp
        cboDMTudo3.DisplayMember = "KyHieu"
        cboDMTudo3.ValueMember = "Id"
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo3.Columns.Add(New LookUpColumnInfo("TenDmTudo3", "Tên danh mục"))

        ''Bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4.AddRange(DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo4_temp As List(Of DmTudo4) = New List(Of DmTudo4)
        Dim obj_TD4 As DmTudo4 = New DmTudo4
        lstTuDo4_temp.Add(obj_TD4)
        lstTuDo4_temp.AddRange(lstTuDo4)

        cboDMTudo4.DataSource = lstTuDo4_temp
        cboDMTudo4.DisplayMember = "KyHieu"
        cboDMTudo4.ValueMember = "Id"
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo4.Columns.Add(New LookUpColumnInfo("TenDmTudo4", "Tên danh mục"))

        ''Bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstTuDo5_temp As List(Of DmTudo5) = New List(Of DmTudo5)
        Dim obj_TD5 As DmTudo5 = New DmTudo5
        lstTuDo5_temp.Add(obj_TD5)
        lstTuDo5_temp.AddRange(lstTuDo5)

        cboDMTudo5.DataSource = lstTuDo5_temp
        cboDMTudo5.DisplayMember = "KyHieu"
        cboDMTudo5.ValueMember = "Id"
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("KyHieu", "Mã danh mục"))
        cboDMTudo5.Columns.Add(New LookUpColumnInfo("TenDmTudo5", "Tên danh mục"))

        ''Bind Phương pháp quả trị

        Dim lstPPQT As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQT.AddRange(DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))

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
            txtTY_GIA1.Enabled = False
            _GridView.Columns("DonGiaNte").Visible = False
            _GridView.Columns("DoanhThuNte").Visible = False
            _GridView.Columns("SoTienCkNte").Visible = False
            _GridView.Columns("SoTienNte").Visible = False
            'cboNgoaiTe.Enabled = True
        Else
            If Not OnLoadData Then
                txtTY_GIA1.Text = LsTygiaService.GetTyGiaNgoaiTe(cboNgoaiTe.EditValue, daeNGAY_CT.EditValue)
            End If
            txtTY_GIA1.Enabled = True
            _GridView.Columns("DonGiaNte").VisibleIndex = _GridView.Columns("DonGia").VisibleIndex
            _GridView.Columns("DoanhThuNte").VisibleIndex = _GridView.Columns("DoanhThu").VisibleIndex
            _GridView.Columns("SoTienCkNte").VisibleIndex = _GridView.Columns("SoTienCk").VisibleIndex
            _GridView.Columns("SoTienNte").VisibleIndex = _GridView.Columns("SoTien").VisibleIndex
            'cboNgoaiTe.Enabled = False
        End If
    End Sub

    Private Sub SetCol(ByVal _htLoaiCT As HtLoaichungtu)
        If _htLoaiCT Is Nothing Then
            Return
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
        _GridView.Columns("IdKhangCo").Visible = _htLoaiCT.DmKhang

    End Sub

    Private Sub DeleteRow()
        Try
            If _GridView.RowCount > 0 Then
                Dim gridctd As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
                del_lstobj_ct_d.Add(gridctd)
                _GridView.DeleteSelectedRows()
                TongSoTien()
            Else
                Message_Warning("Không tồn tại bản ghi nào ở chi tiết định khoản!")
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetFocus_AfterAddRow()
        _GridView.FocusedRowHandle = lstobj_ct_d.Count - 1
        _GridView.SelectRow(Handle)
        Try
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ThemDong()
        'If Not String.IsNullOrEmpty(cFilterTaiKhoan.Text) Then
        Try
            Dim ct_DInfor As KtCtDHddv = New KtCtDHddv

            If objHTCT.PhieuXuat = 1 Then
                ct_DInfor.MaTkCo = cFilterTaiKhoan.ListEditValue(1)
                ct_DInfor.TkCoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                ct_DInfor.TenTkCo = cFilterTaiKhoan.ListEditValue(2)
            Else
                ct_DInfor.MaTkNo = cFilterTaiKhoan.ListEditValue(1)
                ct_DInfor.TkNoId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
                ct_DInfor.TenTkNo = cFilterTaiKhoan.ListEditValue(2)
            End If
            ct_DInfor.NoiDung = txtDIEN_GIAI.Text.Trim()
            lstobj_ct_d.Add(ct_DInfor)
            _GridView.RefreshData()
            SetFocus_AfterAddRow()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        'Else
        'Message_Warning("Bạn chưa chọn tài khoản nợ/có")
        'cFilterTaiKhoan.Focus()
        'End If

    End Sub

    'Private Sub SetMaTk()
    '    Try
    '        If _GridView.RowCount > 0 Then
    '            cFilterTaiKhoan.Text = lstobj_ct_d(0).MaTkNo
    '            cFilterTaiKhoan.Tag = lstobj_ct_d(0).TkNoId
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub TongSoTien()
        Try
            Dim tienhangchuack As Decimal
            Dim TienCK As Decimal
            Dim tienhangck As Decimal
            Dim tienthue As Decimal
            Dim i As Integer
            For i = 0 To _GridView.RowCount - 1
                Dim objCT_D_H As KtCtDHddv = CType(_GridView.GetRow(i), KtCtDHddv)

                tienhangchuack = tienhangchuack + objCT_D_H.DoanhThu
                TienCK = TienCK + objCT_D_H.SoTienCk
                tienhangck = tienhangck + objCT_D_H.SoTien
                tienthue = tienthue + objCT_D_H.SoTienThueGtgt
            Next

            txttienhangchuack.Text = tienhangchuack.ToString()
            txtTienCK.Text = TienCK.ToString()
            txttienhangck.Text = tienhangck.ToString()
            txttienthue.Text = tienthue.ToString()

            txtTongTien.Text = _
                Convert.ToString(tienhangck + tienthue)
        Catch ex As OverflowException
            Message_Information("Giá trị số tiền nhập vào không hợp lệ!")
        End Try
        'tinh tong so tien
    End Sub

    Private Sub Refresh_Data(ByVal i As Integer, ByVal ColumnName As String)
        Dim gridctd As KtCtDHddv = CType(_GridView.GetRow(i), KtCtDHddv)
        Select Case ColumnName
            Case "MA_TK_NO"
                Dim cbotaikhoan As DmTaikhoan = CType(cboTaiKhoanNo.GetDataSourceRowByKeyValue(gridctd.MaTkNo),  _
                                                            DmTaikhoan)
                If (gridctd Is Nothing) Then
                    Return
                End If
                'Gan vao GridView
                If Not cbotaikhoan Is Nothing Then
                    gridctd.TenTkNo = cbotaikhoan.TenTaikhoan
                    gridctd.TkNoId = cbotaikhoan.Id
                    gridctd.MaTkNo = cbotaikhoan.MaTaikhoan
                End If


            Case "MA_TK_CO"
                'Dim cbotaikhoan As DmTaikhoan = CType(cboTaiKhoanCo.GetDataSourceRowByKeyValue(gridctd.MA_TK_CO),  _
                '                                            DmTaikhoan)
                Dim rowTK As DataRow = DataHelper.GetDataRowByKey(TK_DATA_SOURCE, "MaTaikhoan", gridctd.MaTkCo)
                If (gridctd Is Nothing) Then
                    Return
                End If
                'Gan vao GridView
                If Not rowTK Is Nothing Then
                    gridctd.TenTkCo = rowTK("TenTaikhoan").ToString
                    gridctd.TkCoId = VnsConvert.CGuid(rowTK("Id").ToString)
                    gridctd.MaTkCo = rowTK("MaTaikhoan").ToString
                End If
            Case "MA_VUVIEC_CO"
                Dim cbovu_viec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(gridctd.IdDmVuviecCo),  _
                                                         DmVuviec)
                gridctd.IdDmVuviecCo = cbovu_viec.Id
                gridctd.MaVuviecCo = cbovu_viec.MaVuviec
                gridctd.KyHieuVuviecCo = cbovu_viec.KyHieu
            Case "ID_DM_PTQT_CO"
                Dim cboPTQT As DmPtqt = CType(cboPPQT.GetDataSourceRowByKeyValue(gridctd.IdDmPtqtCo),  _
                                                    DmPtqt)
                gridctd.IdDmPtqtCo = cboPTQT.Id
                gridctd.IdDmPtqtNo = cboPTQT.Id
        End Select
    End Sub

    Private Function BindTaiKhoan(ByVal tklienquan As String) As List(Of DmTaikhoan)
        Dim ListTK As List(Of DmTaikhoan) = _
                DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
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

    Private Sub SetFocus_FirstCell()
        If _GridView.RowCount <> 0 Then
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        End If
    End Sub

    Private Sub DatTrangThaiControl()
        Select Case m_InputState
            Case DataInputState.AddMode

                GRC_CTHHDDV.Enabled = False
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
                btnSearch.Enabled = False
                txttienhangchuack.Properties.ReadOnly = True
                txtphantramck.Properties.ReadOnly = True
                txttienhangck.Properties.ReadOnly = True
                txttienthue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True

                cFilter.ENABLES = True
                cFilterTaiKhoan.ENABLES = True
                cFilterTaiKhoanThue.ENABLES = True
                txtTienCK.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
            Case DataInputState.EditMode
                GRC_CTHHDDV.Enabled = False
                navWelding1.Enabled = False
                Control_SetState(grpSMQR, DataInputState.EditMode)
                Control_SetState(grcCT_Thue, DataInputState.EditMode)
                _GridView.OptionsBehavior.Editable = True

                btnAdd.Enabled = False
                btnModify.Enabled = False

                btnSave.Enabled = True
                btnDelete.Enabled = True
                btnPri.Enabled = True
                btnCancel.Enabled = True
                btnSearch.Enabled = False
                txttienhangchuack.Properties.ReadOnly = True
                txtphantramck.Properties.ReadOnly = True
                txttienhangck.Properties.ReadOnly = True
                txttienthue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                txtTienCK.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                cFilter.ENABLES = True
                cFilterTaiKhoan.ENABLES = True
                cFilterTaiKhoanThue.ENABLES = True
            Case Else
                GRC_CTHHDDV.Enabled = True
                navWelding1.Enabled = True
                Control_SetState(grpSMQR, DataInputState.ViewMode)
                Control_SetState(grcCT_Thue, DataInputState.ViewMode)
                _GridView.OptionsBehavior.Editable = False

                btnAdd.Enabled = True
                btnModify.Enabled = True

                btnSave.Enabled = False
                btnDelete.Enabled = True

                btnPri.Enabled = True
                btnCancel.Enabled = False
                btnSearch.Enabled = True

                txttienhangchuack.Properties.ReadOnly = True
                txtphantramck.Properties.ReadOnly = True
                txttienhangck.Properties.ReadOnly = True
                txttienthue.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                txtTienCK.Properties.ReadOnly = True
                txtTongTien.Properties.ReadOnly = True
                cFilter.ENABLES = False
                cFilterTaiKhoan.ENABLES = False
                cFilterTaiKhoanThue.ENABLES = False
        End Select
    End Sub

    Private Sub XoaTrang()
        Try
            cFilter.Text = ""
            cFilterTaiKhoan.Text = ""
            ucStatus.Set_Status(1)
            m_CTH_ID = Nothing
            txtDIA_CHI.Text = String.Empty
            txtTEN_KHANG.Text = String.Empty
            txtNGUOI_NHAN_NOP_TIEN.Text = String.Empty
            txtDIEN_GIAI.Text = String.Empty
            C_SoChungTu_RP.Text = ""
            C_SoChungTu_RP.SO_CHUNG_TU = ""
            C_SoChungTu_RP.PREFIX = ""
            cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            txtTY_GIA1.Text = "1"
            txtTongTien.Text = "0"
            txttienhangchuack.Text = "0"
            txtphantramck.Text = "0"
            txtMST_KHANG.Text = String.Empty
            txtSO_HD1.Text = ""
            txtSO_SERI_HD1.Text = ""
            cFilterTaiKhoanThue.Text = ""
            txtTienCK.Text = "0"
            txttienhangck.Text = "0"
            txttienthue.Text = "0"
            daeNGAY_GHI.DateTime = DateTime.Now
            daeNGAY_CT.DateTime = DateTime.Now
            _GridControl.DataSource = Nothing
            lstobj_ct_d = New List(Of KtCtDHddv)
            lstobj_ct_d.Add(New KtCtDHddv)
            _GridControl.DataSource = lstobj_ct_d
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function ValidateCTD(ByVal lstobj_ct_d As List(Of KtCtDHddv)) As Boolean

        If daeNGAY_GHI.DateTime.Date > daeNGAY_CT.DateTime.Date Then
            Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ")
            Return False
        End If

        If VnsCheck.IsNullGuid(cFilterTaiKhoan.Tag) Then
            Message_Warning("Bạn chưa nhập TK nợ hoặc giá trị TK nợ không hợp lệ!")
            cFilterTaiKhoan.Focus()
            Return False
        End If

        If VnsCheck.IsNullGuid(cFilter.Tag) Then
            Message_Warning("Bạn chưa nhập khách hàng!")
            cFilter.Focus()
            Return False
        End If

        If _GridView.RowCount = 0 Then
            Message_Warning("Chi tiết định khoản không được để trống!")
            Return False
        End If


        If txtTY_GIA1.Text <> "" Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtTY_GIA1.Text)) Then
                Message_Warning("Giá trị tỷ giá nhập vào không hợp lệ")
                Return False
            End If
        End If

        If txtTienCK.Text <> "" And ckeNhapTienCK.Checked Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtTienCK.Text)) Then
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                txtTienCK.Focus()
                Return False
            End If
        End If

        If txttienthue.Text <> "" And ckeNhapTienThue.Checked Then
            If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txttienthue.Text)) Then
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                txttienthue.Focus()
                Return False
            End If
        End If

        For Each objctd As KtCtDHddv In lstobj_ct_d
            If _PhieuXuat = 1 Then
                If VnsCheck.IsNullGuid(objctd.TkCoId) Then
                    Message_Warning("Bạn chưa nhập TK có hoặc giá trị TK có không hợp lệ!")
                    Return False
                End If

                If VnsCheck.IsNullGuid(objctd.TkCoIdGtgt) And objctd.TyLeThueGtgt > 0 Then
                    Message_Warning("Nhập tỷ lệ thuế nhưng chưa nhập tài khoản thuế!")
                    Return False
                End If
            Else
                If VnsCheck.IsNullGuid(objctd.TkNoId) Then
                    Message_Warning("Bạn chưa nhập TK nợ hoặc giá trị TK nợ không hợp lệ!")
                    Return False
                End If

                If VnsCheck.IsNullGuid(objctd.TkNoIdGtgt) And objctd.TyLeThueGtgt > 0 Then
                    Message_Warning("Nhập tỷ lệ thuế nhưng chưa nhập tài khoản thuế!")
                    Return False
                End If
            End If


            If Not LimitValue.CheckQuantity(objctd.SoLuong) Or objctd.SoLuong = 0 Then
                Message_Warning("Giá trị số lượng không hợp lệ!")
                Return False
            End If

            If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                If objctd.DonGiaNte = 0 Then
                    Message_Warning("Giá trị đơn giá ngoại tệ không hợp lệ!")
                    Return False
                End If
            End If

            If Not LimitValue.CheckFCurrency(objctd.DonGiaNte) Then
                Message_Warning("Giá trị đơn giá ngoại tệ không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckFCurrency(objctd.DonGia) Or objctd.DonGia = 0 Then
                Message_Warning("Giá trị đơn giá không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckFCurrency(objctd.DoanhThuNte) Then
                Message_Warning("Giá trị doanh thu ngoại tệ không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(objctd.DoanhThu) And objctd.DoanhThu = 0 Then
                Message_Warning("Giá trị doanh thu không hợp lệ!")
                Return False
            End If

            If Not LimitValue.CheckTaxRate(objctd.TyLeCk) Then
                Message_Warning("Tỷ lệ chiết khấu phải nằm trong khoảng [0,1000)")
                Return False
            End If

            If Not LimitValue.CheckTaxRate(objctd.TyLeThueGtgt) Then
                Message_Warning("Tỷ lệ thuế GTGT phải nằm trong khoảng [0,1000)")
                Return False
            End If

            'If VnsCheck.IsNullGuid(objctd.TkCoIdGtgt) Then
            '    Message_Warning("Giá trị tài khoản thuế GTGT không hợp lệ!!")
            '    Return False
            'End If

            If Not LimitValue.CheckVNDCurrency(objctd.TienMg) Then
                Message_Warning("Giá trị tiền MG không hợp lệ!")
                Return False
            End If
        Next

        If txttienthue.Text <> 0 AndAlso VnsCheck.IsNullGuid(cFilterTaiKhoanThue.Tag) Then
            Message_Warning("Giá trị TK đối ứng với TK thuế không hợp lệ!")
            cFilterTaiKhoanThue.Focus()
            Return False
        End If

        If txttienthue.Text <> "" Then
            If VnsCheck.IsNullGuid(cFilterTaiKhoanThue.Tag) And Decimal.Parse(txttienthue.Text) > 0 Then
                Message_Warning("Tài khoản đối ứng với tài khoản thuế không hợp lệ hoặc chưa có giá trị")
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub LoadDB()
        'lstobj_ct_h = KtCtHHddvService.GetObjectGetObjectAllByLoaiChungTu(Generals.DON_VI.Id, _
        'm_MA_LOAI_CT)
        SetObjectToControl()
        TongSoTien()
        'SetMaTk()
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

#End Region

#Region "Events"

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            AddHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            Me.ValidateChildren()
            If Not ucStatus.ChoPhepSuaCT Then
                Message_Warning("Bạn không được phép sửa chứng từ này!")
                Return
            End If

            If obj_ct_h Is Nothing Then
                obj_ct_h = New KtCtHHddv
            End If

            If obj_ct_h.DaKhoaSo = 1 Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            'Check khoa so thang
            If KtKhoasoThangService.KiemTraKhoaSo(daeNGAY_CT.DateTime, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            If Not ValidateCTD(lstobj_ct_d) Then
                Exit Sub
            End If

            frmProgress.Instance.Thread = AddressOf SaveData
            frmProgress.Instance.Show_Progress()

            ckeNhapTienThue.Checked = False
            ckeNhapTienCK.Checked = False

            'Refresh left grid
            m_CTH_ID = obj_ct_h.Id
            Dim editObject As Extend.CT_H_GInfo = New Extend.CT_H_GInfo(obj_ct_h)
            GridHelper.RefreshLeftGrid(GRV_CTHHDDV, lstobj_ct_h_gg, editObject, m_InputState)

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
            ConfigGrid.GridConfig(Me.Name + "?" + "MA_LOAI_CT=" + m_MA_LOAI_CT, _GridView.Name, _GridView)
            lstTKLQ.Clear()
            objHTCT = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)

            'objHT_LoaiCT = objHTCT
            SetCol(objHTCT)
            If (objHTCT Is Nothing) Then
                Return
            Else
                'Khai bao loai tai khoan
                Dim tklienquan As String = Nothing

                'Khai bao tk_lq voi loai chung tu tuong ung
                Dim tk_lq_thue As String = Nothing
                Dim tk_lq_co As String = Nothing
                'end

                ConfigByLoaiCT(_PhieuXuat)

                If _PhieuXuat = 1 Then
                    tklienquan = objHTCT.MaTkNoLq
                Else
                    tklienquan = objHTCT.MaTkCoLq
                End If
                cFilterTaiKhoan.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tklienquan)
                cFilterTaiKhoanThue.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tklienquan)
                'MyRepositoryItem_MA_TK_CO_GTGT.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", objHTCT.TkThueNgamdinh)

                'Bind data trong grid tuy theo tk lien quan no hay co
                tk_lq_thue = objHTCT.TkThueNgamdinh
                tk_lq_co = objHTCT.MaTkCoLq
                If Not tk_lq_thue Is Nothing Or Not tk_lq_thue = String.Empty Then
                    If _PhieuXuat = 1 Then
                        MyRepositoryItem_MA_TK_CO_GTGT.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_thue)
                    Else
                        MyRepositoryItem_MA_TK_NO_GTGT.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_thue)
                    End If
                End If

                If _PhieuXuat = 1 Then
                    If Not tk_lq_co Is Nothing Or Not tk_lq_co = String.Empty Then
                        MyRepositoryItem_MA_TK_CO.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", tk_lq_co)
                    End If
                Else
                    If Not objHTCT.MaTkNoLq Is Nothing Or Not objHTCT.MaTkNoLq = String.Empty Then
                        MyRepositoryItem_MA_TK_NO.C_IS_FILTER_STRING = TNCommon.GenLikeString("MaTaikhoan", objHTCT.MaTkNoLq)
                    End If
                End If
                _GridView.RefreshData()
            End If
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
                    Dim FormID As String = Me.Name + "?" + "MA_LOAI_CT=" + m_MA_LOAI_CT
                    Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                    ConfigGrid.GetGridColInfo(_GridView, lstColInfo)
                    Dim f As New ConfigGrid
                    If f.Show_Form(_GridView.Name, FormID, lstColInfo) Then
                        ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)
                        objHTCT = grlLOAI_CT_ID.Properties.View.GetRow(grlLOAI_CT_ID.Properties.GetIndexByKeyValue(grlLOAI_CT_ID.EditValue))

                        'objHT_LoaiCT = objHTCT
                        SetCol(objHTCT)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles _GridView.CellValueChanged
        Try
            Dim objCT_D_H As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            Select Case e.Column.Name
                Case "MA_VUVIEC_CO"
                    Dim cbovu_viec As DmVuviec = CType(cboVuViec.GetDataSourceRowByKeyValue(objCT_D_H.IdDmVuviecCo),  _
                                                             DmVuviec)
                    objCT_D_H.IdDmVuviecCo = cbovu_viec.Id
                    objCT_D_H.MaVuviecCo = cbovu_viec.MaVuviec
                    objCT_D_H.KyHieuVuviecCo = cbovu_viec.KyHieu
                Case "ID_DM_PTQT_CO"
                    Dim cboPTQT As DmPtqt = CType(cboPPQT.GetDataSourceRowByKeyValue(objCT_D_H.IdDmPtqtCo),  _
                                                        DmPtqt)
                    objCT_D_H.IdDmPtqtCo = cboPTQT.Id
                    objCT_D_H.IdDmPtqtNo = cboPTQT.Id
            End Select
            Try
                If e.Column.Name.Equals("ThueId") Then
                    Dim dmThue As DmThue = CType(cboDMthue.GetDataSourceRowByKeyValue(objCT_D_H.ThueId), DmThue)
                    If dmThue IsNot Nothing Then
                        _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "TyLeThueGtgt", dmThue.TyLe)
                        objCT_D_H.TenThue = dmThue.TenThue
                    End If

                End If
                If e.Column.Name.Equals("SO_LUONG") Or e.Column.Name.Equals("DON_GIA_NTE") Then
                    objCT_D_H.DoanhThuNte = objCT_D_H.SoLuong * objCT_D_H.DonGiaNte
                    Dim tygia As Decimal = Convert.ToDecimal(txtTY_GIA1.Text.Trim())

                    If Not cboNgoaiTe.EditValue.Equals(Generals.TS_NoiTe_ID.GiaTriMd) Then
                        objCT_D_H.DonGia = Math.Round(objCT_D_H.DonGiaNte * tygia)
                    End If
                    objCT_D_H.DoanhThu = Math.Round(objCT_D_H.SoLuong * objCT_D_H.DonGia)
                    objCT_D_H.SoTienCkNte = objCT_D_H.DoanhThuNte * objCT_D_H.TyLeCk / 100
                    objCT_D_H.SoTienCk = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeCk / 100, 0)
                    objCT_D_H.SoTienNte = objCT_D_H.DoanhThuNte - objCT_D_H.SoTienCkNte
                    objCT_D_H.SoTien = objCT_D_H.DoanhThu - objCT_D_H.SoTienCk
                    objCT_D_H.SoTienThueGtgt = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeThueGtgt / 100)
                End If

                If e.Column.Name.Equals("DON_GIA") Then
                    objCT_D_H.DoanhThu = Math.Round(objCT_D_H.SoLuong * objCT_D_H.DonGia)
                    objCT_D_H.SoTienCk = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeCk / 100, 0)
                    objCT_D_H.SoTien = objCT_D_H.DoanhThu - objCT_D_H.SoTienCk
                    objCT_D_H.SoTienThueGtgt = Math.Round(objCT_D_H.SoTien * objCT_D_H.TyLeThueGtgt / 100)
                End If

                If e.Column.Name.Equals("DOANH_THU_NTE") Then
                    objCT_D_H.SoTienCkNte = objCT_D_H.DoanhThuNte * objCT_D_H.TyLeCk / 100
                    objCT_D_H.SoTienNte = objCT_D_H.DoanhThuNte - objCT_D_H.SoTienCkNte
                End If

                If e.Column.Name.Equals("DOANH_THU") Then
                    objCT_D_H.SoTienCk = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeCk / 100, 0)
                    objCT_D_H.SoTien = objCT_D_H.DoanhThu - objCT_D_H.SoTienCk
                    objCT_D_H.SoTienThueGtgt = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeThueGtgt / 100)
                End If

                If e.Column.Name.Equals("TY_LE_CK") Then
                    objCT_D_H.SoTienCkNte = objCT_D_H.DoanhThuNte * objCT_D_H.TyLeCk / 100
                    objCT_D_H.SoTienCk = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeCk / 100, 0)
                    objCT_D_H.SoTienNte = objCT_D_H.DoanhThuNte - objCT_D_H.SoTienCkNte
                    objCT_D_H.SoTien = objCT_D_H.DoanhThu - objCT_D_H.SoTienCk
                End If

                If e.Column.Name.Equals("TY_LE_THUE_GTGT") Then
                    objCT_D_H.SoTienThueGtgt = Math.Round(objCT_D_H.DoanhThu * objCT_D_H.TyLeThueGtgt / 100)
                End If
            Catch ex As OverflowException
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
            End Try

            _GridView.RefreshData()
            TongSoTien()

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

    Private Sub frmCT_H_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("IdDmTudo1Co").Caption = Generals.TS_TuDo1.GiaTri
            _GridView.Columns("IdDmTudo2Co").Caption = Generals.TS_TuDo2.GiaTri
            _GridView.Columns("IdDmTudo3Co").Caption = Generals.TS_TuDo3.GiaTri
            _GridView.Columns("IdDmTudo4Co").Caption = Generals.TS_TuDo4.GiaTri
            _GridView.Columns("IdDmTudo5Co").Caption = Generals.TS_TuDo5.GiaTri
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Try
            OnLoadData = True
            If lstobj_ct_h_gg.Count <> 0 Then
                If m_InputState = DataInputState.AddMode Then
                    m_CTH_ID = lstobj_ct_h_gg(lstobj_ct_h_gg.Count - 1).Id
                    GRV_CTHHDDV.FocusedRowHandle = lstobj_ct_h_gg.Count - 1
                End If
                'SetMaTk()
                SetObjectToControl()
                TongSoTien()
                m_InputState = DataInputState.ViewMode
            Else
                m_InputState = DataInputState.AddMode
            End If
            DatTrangThaiControl()
            SetFocus_FirstCell()
            OnLoadData = False
            ckeNhapTienCK.Checked = False
            ckeNhapTienThue.Checked = False
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            RemoveHandler _GridView.RowCellStyle, AddressOf _GridView_RowCellStyle
            m_InputState = DataInputState.AddMode
            DatTrangThaiControl()
            XoaTrang()
            grlLOAI_CT_ID.Focus()
            flagDG = 0
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        Try
            m_InputState = DataInputState.EditMode

            DatTrangThaiControl()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            If Not ucStatus.ChoPhepSuaCT Then
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

                KtCtHHddvService.DeleteChungTu(obj_ct_h, Nothing)
                ckeNhapTienCK.Checked = False

                m_CTH_ID = Vns.Erp.Core.Accounting.VbAccountingGUI.GridHelper.RemoveLeftGrid(lstobj_ct_h_gg, m_CTH_ID)
                If Not VnsCheck.IsNullGuid(m_CTH_ID) Then
                    LoadDB()
                End If
                GRV_CTHHDDV.RefreshData()

                m_InputState = DataInputState.ViewMode
            End If

            If lstobj_ct_h_gg.Count = 0 Then
                GRC_CTHHDDV.DataSource = Nothing
                XoaTrang()
                m_InputState = DataInputState.AddMode
            End If
            DatTrangThaiControl()
            SetFocus_FirstCell()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If m_InputState = DataInputState.EditMode Then
                If obj_ct_h.MaLoaiCt IsNot Nothing Then
                    objHTCT = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
                End If
                Dim gridctd As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
                Dim MA_TK As String
                If objHTCT.PhieuXuat = 0 Then
                    MA_TK = gridctd.MaTkCo
                Else
                    'MA_TK = gridctd.MA_TK_NO
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmCT_H_ChiTiet_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        DialogResult = DialogResult.OK
    End Sub

    Private Sub GRV_CTHHDDV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Try
            If (m_InputState = DataInputState.EditMode) And (btnModify.Enabled = False) Then
                LoadDB()
            ElseIf (m_InputState = DataInputState.AddMode) And (btnModify.Enabled = False) Then
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

    Private Sub daeNGAY_CT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles daeNGAY_CT.EditValueChanged
        Try
            daeNGAY_GHI.DateTime = daeNGAY_CT.DateTime
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTY_GIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTY_GIA1.TextChanged
        Try
            Try
                If cboNgoaiTe.EditValue <> VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                    Dim ty_gia As String = txtTY_GIA1.Text.Trim()

                    If String.IsNullOrEmpty(ty_gia) Then
                        Return
                    End If

                    For Each ctDInfo As KtCtDHddv In lstobj_ct_d
                        ctDInfo.SoTien = Decimal.Parse(ty_gia) * ctDInfo.SoTienNte
                        ctDInfo.SoTienCk = Math.Round(Decimal.Parse(ty_gia) * ctDInfo.SoTienCkNte)
                        ctDInfo.DoanhThu = Decimal.Parse(ty_gia) * ctDInfo.DoanhThuNte
                        ctDInfo.DonGia = Decimal.Parse(ty_gia) * ctDInfo.DonGiaNte
                        ctDInfo.SoTienThueGtgt = ctDInfo.SoTien * ctDInfo.TyLeThueGtgt / 100
                    Next

                    _GridView.RefreshData()
                    TongSoTien()
                End If
            Catch ex As OverflowException
                Message_Warning("Giá trị số tiền nhập vào không hợp lệ!")
                txtTY_GIA1.Text = "1"
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboNgoaiTe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNgoaiTe.EditValueChanged
        Try
            SetColNgoaiTe()
            If cboNgoaiTe.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri) Then
                For Each obj As KtCtDHddv In lstobj_ct_d
                    obj.DonGiaNte = 0
                    obj.DoanhThuNte = 0
                    obj.SoTienCkNte = 0
                    obj.SoTienNte = 0
                Next
                txtTY_GIA1.Text = 1
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ' Khach hang
    Private Sub cFilter_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.FirstBinddata
        Try
            SavingMemory(2)
            cFilter.C_DATA_SOURCE = KHANG_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterFilter
        Try
            txtMST_KHANG.Text = cFilter.ListEditValue(4)
            txtTEN_KHANG.Text = cFilter.ListEditValue(1)
            txtDIA_CHI.Text = cFilter.ListEditValue(5)
            cFilter.Tag = cFilter.ListEditValue(0)
            If cFilter.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.AfterQuickAdd
        Try
            cFilter.C_DATA_SOURCE = DataHelper.ToDataTable(DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ' Tai khoan
    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            SavingMemory(1)
            cFilterTaiKhoan.C_DATA_SOURCE = TK_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        Try
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterQuickAdd
        Try
            cFilterTaiKhoan.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SavingMemory(ByVal _option As Integer)
        If _option = 1 Then 'TK
            If TK_DATA_SOURCE Is Nothing Then
                TK_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 2 Then 'KHANG
            If KHANG_DATA_SOURCE Is Nothing Then
                KHANG_DATA_SOURCE = DataHelper.ToDataTable(DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
        ElseIf _option = 3 Then 'CT_HOADON

        ElseIf _option = 10 Then 'ALL
            If TK_DATA_SOURCE Is Nothing Then
                TK_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            End If
            If KHANG_DATA_SOURCE Is Nothing Then
                KHANG_DATA_SOURCE = DataHelper.ToDataTable(DmKhangService.GetAllByDonviID(Generals.DON_VI.Id))
            End If

        End If
    End Sub

    Private Sub SavingMemoryForRepository(ByVal colName As String)
        Select Case colName
            Case "MA_TK_CO"
                If MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE = TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_CO.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_CO.C_DATA_SOURCE
                End If
            Case "MA_TK_CO_GTGT"
                If MyRepositoryItem_MA_TK_CO_GTGT.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_CO_GTGT.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_CO_GTGT.C_DATA_SOURCE = TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_CO_GTGT.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_CO_GTGT.C_DATA_SOURCE
                End If
            Case "MA_TK_NO"
                If MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE = TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_NO.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_NO.C_DATA_SOURCE
                End If

            Case "MA_TK_NO_GTGT"
                If MyRepositoryItem_MA_TK_NO_GTGT.C_DATA_SOURCE Is Nothing Then
                    'Saving memory
                    If TK_DATA_SOURCE Is Nothing Then
                        MyRepositoryItem_MA_TK_NO_GTGT.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
                    Else
                        MyRepositoryItem_MA_TK_NO_GTGT.C_DATA_SOURCE = TK_DATA_SOURCE
                    End If
                    MyRepositoryItem_MA_TK_NO_GTGT.Editors.A_DATA_SOURCE = MyRepositoryItem_MA_TK_NO_GTGT.C_DATA_SOURCE
                End If
            Case Else
        End Select
    End Sub

    ' tren luoi
    Private Sub MyRepositoryItem_FisrtBinddata(ByVal senders As Object, ByVal e As EventArgs) Handles MyRepositoryItem_MA_TK_CO.FisrtBinddata, MyRepositoryItem_MA_TK_CO_GTGT.FisrtBinddata, MyRepositoryItem_MA_TK_NO_GTGT.FisrtBinddata, MyRepositoryItem_MA_TK_NO.FisrtBinddata
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            SavingMemoryForRepository(columnName)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_AfterFilter(ByVal senders As Object, ByVal e As EventArgs) Handles MyRepositoryItem_MA_TK_CO.AfterFilter, MyRepositoryItem_MA_TK_CO_GTGT.AfterFilter, MyRepositoryItem_MA_TK_NO.AfterFilter, MyRepositoryItem_MA_TK_NO_GTGT.AfterFilter
        Try
            Dim rowHandle As Integer = _GridView.FocusedRowHandle
            Dim columnName As String = _GridView.FocusedColumn().Name
            Dim obj As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            If obj Is Nothing Then
                Return
            End If
            Select Case columnName
                Case "MA_TK_CO"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_CO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        obj.TkCoId = VnsConvert.CGuid(arr(0))
                        obj.TenTkCo = arr(2)
                        obj.MaTkCo = arr(1)
                        _GridView.SetRowCellValue(rowHandle, "MaTkCo", arr(1))
                    End If
                Case "MA_TK_CO_GTGT"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_CO_GTGT.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        obj.TkCoIdGtgt = VnsConvert.CGuid(arr(0))
                        obj.MaTkCoGtgt = arr(1)
                        _GridView.SetRowCellValue(rowHandle, "MaTkCoGtgt", arr(1))
                    End If

                Case "MA_TK_NO_GTGT"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_NO_GTGT.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        obj.TkNoIdGtgt = VnsConvert.CGuid(arr(0))
                        obj.MaTkNoGtgt = arr(1)
                        _GridView.SetRowCellValue(rowHandle, "MaTkNoGtgt", arr(1))
                    End If
                Case "MA_TK_NO"
                    Dim arr As List(Of String) = MyRepositoryItem_MA_TK_NO.OwnerEdit.A_LIST_VALUES
                    If (arr.Count > 1) Then
                        obj.TkNoId = VnsConvert.CGuid(arr(0))
                        obj.TenTkNo = arr(2)
                        obj.MaTkNo = arr(1)
                        _GridView.SetRowCellValue(rowHandle, "MaTkNo", arr(1))
                    End If
                Case Else
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ' tk doi ung tk thue
    Private Sub cFilterTaiKhoanThue_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.FirstBinddata
        Try
            SavingMemory(1)
            cFilterTaiKhoanThue.C_DATA_SOURCE = TK_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoanThue_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.AfterFilter
        Try
            cFilterTaiKhoanThue.Tag = cFilterTaiKhoanThue.ListEditValue(0)
            If cFilterTaiKhoanThue.IsNotTextChanged Then SendKeys.Send("{TAB}")

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoanThue_AfterQuickAdd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.AfterQuickAdd
        Try
            cFilterTaiKhoanThue.C_DATA_SOURCE = DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ckeNhapTienCK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeNhapTienCK.CheckedChanged
        Try
            If ckeNhapTienCK.Checked Then
                txtTienCK.Properties.ReadOnly = False
                txtTienCK.TabStop = True
                _GridView.Columns.Item("TyLeCk").OptionsColumn.AllowEdit = False
            Else
                txtTienCK.Properties.ReadOnly = True
                txtTienCK.TabStop = True
                _GridView.Columns.Item("TyLeCk").OptionsColumn.AllowEdit = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtTienCK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTienCK.TextChanged
        Try
            If Not ckeNhapTienCK.Checked Then
                Exit Sub
            End If
            If txtTienCK.Text = "" Or txttienhangchuack.Text = "" Then
                Exit Sub
            End If

            Dim Tien_CK As Decimal = 0
            Dim Tien_Hang As Decimal = 0
            Dim Tien_thue As Decimal = 0

            Tien_CK = Decimal.Parse(txtTienCK.Text)
            Tien_Hang = Decimal.Parse(txttienhangchuack.Text)

            If txttienthue.Text <> "" Then
                Tien_thue = Decimal.Parse(txttienthue.Text)
            End If

            'tinh lai tong tien
            txtTongTien.EditValue = Tien_Hang - Tien_CK + Tien_thue

            'Phan bo tien va phan tram thue
            Dim fn As PhanBoHelper = New PhanBoHelper
            Dim lst_phanBo As List(Of PhanBoHelperInfo) = New List(Of PhanBoHelperInfo)
            Dim obj_phanBo As PhanBoHelperInfo
            lst_phanBo.Clear()
            If Not String.IsNullOrEmpty(txtTienCK.Text) Then
                For i As Integer = 0 To lstobj_ct_d.Count - 1
                    obj_phanBo = New PhanBoHelperInfo
                    obj_phanBo.THU_TU = i
                    obj_phanBo.TONG_SO_TIEN = Tien_CK
                    obj_phanBo.TIEN_PB = 0
                    obj_phanBo.SO_TIEN = lstobj_ct_d(i).DoanhThu
                    obj_phanBo.HE_SO = 0
                    lst_phanBo.Add(obj_phanBo)
                Next
            End If
            lst_phanBo = fn.PhanBo(lst_phanBo)

            Try
                For i As Integer = 0 To lstobj_ct_d.Count - 1
                    For Each obj As PhanBoHelperInfo In lst_phanBo
                        If obj.THU_TU = i Then
                            lstobj_ct_d(i).SoTienCk = obj.TIEN_PB
                            lstobj_ct_d(i).TyLeCk = Tien_CK / Tien_Hang * 100
                            lstobj_ct_d(i).SoTien = lstobj_ct_d(i).DoanhThu - lstobj_ct_d(i).SoTienCk
                            Exit For
                        End If
                    Next
                Next
            Catch ex As OverflowException
                Message_Warning("Giá trị nhập vào không hợp lệ!")
            End Try
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData
        Try
            cFilterTaiKhoan.Tag = Nothing
            cFilterTaiKhoan.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoanThue_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoanThue.ClearFilterData
        Try
            cFilterTaiKhoanThue.Tag = Nothing
            cFilterTaiKhoanThue.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeNhapTienThue.CheckedChanged
        Try
            If ckeNhapTienThue.Checked Then
                txttienthue.Properties.ReadOnly = False
                txttienthue.TabStop = True
                _GridView.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = False
            Else
                txttienthue.Properties.ReadOnly = True
                txttienthue.TabStop = True
                _GridView.Columns.Item("TyLeThueGtgt").OptionsColumn.AllowEdit = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txttienthue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttienthue.TextChanged
        Try
            If Not ckeNhapTienThue.Checked Then
                Return
            End If

            If txttienthue.Text = "" Or txttienhangchuack.Text = "" Then
                Return
            End If

            Dim Tien_Thue As Decimal = Decimal.Parse(txttienthue.Text)
            Dim Tien_hang As Decimal = Decimal.Parse(txttienhangchuack.Text)
            Dim Tien_CK As Decimal = 0
            If txtTienCK.Text <> "" Then
                Tien_CK = Decimal.Parse(txtTienCK.Text)
            End If
            'Sua tien thue
            'Try
            'Tính lại tổng TT(Chua)
            txtTongTien.EditValue = Tien_hang + Tien_Thue - Tien_CK
            'Phân bổ           
            Dim fn As PhanBoHelper = New PhanBoHelper
            Dim lst_phanBo As List(Of PhanBoHelperInfo) = New List(Of PhanBoHelperInfo)
            Dim obj_phanBo As PhanBoHelperInfo
            lst_phanBo.Clear()
            For i As Integer = 0 To lstobj_ct_d.Count - 1
                obj_phanBo = New PhanBoHelperInfo
                obj_phanBo.THU_TU = i
                obj_phanBo.TONG_SO_TIEN = Tien_Thue
                obj_phanBo.TIEN_PB = 0
                obj_phanBo.SO_TIEN = lstobj_ct_d(i).DoanhThu
                obj_phanBo.HE_SO = 0
                lst_phanBo.Add(obj_phanBo)
            Next

            lst_phanBo = fn.PhanBo(lst_phanBo)

            For i As Integer = 0 To lstobj_ct_d.Count - 1
                For Each obj As PhanBoHelperInfo In lst_phanBo
                    If obj.THU_TU = i Then
                        lstobj_ct_d(i).SoTienThueGtgt = obj.TIEN_PB
                        lstobj_ct_d(i).TyLeThueGtgt = Tien_Thue / Tien_hang * 100
                        Exit For
                    End If
                Next
            Next
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ckeNhapTienCK_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckeNhapTienCK.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub ckeNhapTienThue_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckeNhapTienThue.KeyDown
        EnterNext(sender, e)
    End Sub

    Private Sub btnInCTu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPri.Click
        Try
            Dim obj_htchungtu As HtLoaichungtu = CType(ComboHelper.GetSelectData(grlLOAI_CT_ID), HtLoaichungtu)
            Dim obj_form = CType(ObjectFactory.GetObject("frmHDDV_input", New Object() {m_CTH_ID, obj_htchungtu}), Form)
            obj_form.ShowInTaskbar = False
            obj_form.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilter_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.ClearFilterData
        Try
            cFilter.Tag = ""
            txtTEN_KHANG.Text = ""
            txtMST_KHANG.Text = ""
            txtDIA_CHI.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_MA_TK_CO_GTGT_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_MA_TK_CO_GTGT.ClearDataFilter
        Try
            Dim obj As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            Dim arr As List(Of String) = MyRepositoryItem_MA_TK_CO_GTGT.OwnerEdit.A_LIST_VALUES
            If (arr.Count > 1) Then
                obj.TkCoIdGtgt = VnsConvert.CGuid(arr(0))
                obj.MaTkCoGtgt = arr(1)
                '_GridView.SetRowCellValue(rowHandle, "MA_TK_CO_GTGT", arr(1))
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub MyRepositoryItem_MA_TK_CO_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_MA_TK_CO.ClearDataFilter
        Try
            Dim obj As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            Dim arr As List(Of String) = MyRepositoryItem_MA_TK_CO.OwnerEdit.A_LIST_VALUES
            If (arr.Count > 1) Then
                obj.TkCoId = VnsConvert.CGuid(arr(0))
                obj.TenTkCo = arr(2)
                obj.MaTkCo = arr(1)
                '_GridView.SetRowCellValue(rowHandle, "MA_TK_CO", arr(1))
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_MA_TK_CN_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_MA_TK_NO.ClearDataFilter
        Try
            Dim obj As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            Dim arr As List(Of String) = MyRepositoryItem_MA_TK_NO.OwnerEdit.A_LIST_VALUES
            If (arr.Count > 1) Then
                obj.TkNoId = VnsConvert.CGuid(arr(0))
                obj.TenTkNo = arr(2)
                obj.MaTkNo = arr(1)
                '_GridView.SetRowCellValue(rowHandle, "MA_TK_CO", arr(1))
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim fn As frmTimKiemChungTuHDDV = CType(ObjectFactory.GetObject("frmTimKiemChungTuHDDV"), frmTimKiemChungTuHDDV)

            Dim lstobj_ct_h_gg_temp As List(Of Extend.CT_H_GInfo) = fn.Show_Form(m_MA_LOAI_CT)

            If lstobj_ct_h_gg_temp Is Nothing Then
                Return
            End If

            If lstobj_ct_h_gg_temp.Count > 0 Then
                lstobj_ct_h_gg = lstobj_ct_h_gg_temp
                Load_Grid(lstobj_ct_h_gg)
                m_CTH_ID = lstobj_ct_h_gg(0).Id
                SetObjectToControl()
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MyRepositoryItem_MA_TK_NO_GTGT_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles MyRepositoryItem_MA_TK_NO_GTGT.ClearDataFilter
        Try
            Dim obj As KtCtDHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtDHddv)
            Dim arr As List(Of String) = MyRepositoryItem_MA_TK_NO_GTGT.OwnerEdit.A_LIST_VALUES
            If (arr.Count > 1) Then
                obj.TkNoIdGtgt = VnsConvert.CGuid(arr(0))
                obj.MaTkNoGtgt = arr(1)
                '_GridView.SetRowCellValue(rowHandle, "MA_TK_CO", arr(1))
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


    Private Sub txtDIA_CHI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDIEN_GIAI.Leave
        Try
            If flagDG = 0 Then
                If m_InputState = DataInputState.AddMode Then
                    If _GridView.RowCount > 0 Then
                        Dim obj As KtCtDHddv = CType(_GridView.GetRow(0), KtCtDHddv)
                        obj.NoiDung = txtDIEN_GIAI.Text
                        _GridView.RefreshData()
                        flagDG = flagDG + 1
                    End If
                End If
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


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

                Case "SoLuong"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
                Case "DonGia"
                    If val <= 0 Or val >= Decimal.MaxValue Then
                        AppearanceHelper.Apply(e.Appearance, Generals.appError)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class