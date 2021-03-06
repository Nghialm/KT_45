Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class frmKhaiBaoGiamTaiSan_ChiTiet
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

    Private _DmLydoTgTscdService As IDmLydoTgTscdService
    Public Property DmLydoTgTscdService As IDmLydoTgTscdService
        Get
            Return _DmLydoTgTscdService
        End Get
        Set(ByVal value As IDmLydoTgTscdService)
            _DmLydoTgTscdService = value
        End Set
    End Property

    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
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
#End Region

#Region "Variables"

    Private m_DM_TSCD_ID As Guid
    Private m_InputState As FormGlobals.DataInputState
    Private m_CT_TSCD_ID As Guid
    Private m_CT_GIAM_TSCD As String
    Private dm_tscd As DmTscd = New DmTscd()
    Private ct_tscd As CtTscd = New CtTscd()
    Private lst_CTD As List(Of CtD) = New List(Of CtD)
    Private obj_CTH As CtH
    Dim LS_TSCD As TsLsKhauhao = New TsLsKhauhao()
    Dim lst_tk As New List(Of DmTaikhoan)
#End Region

#Region "Show_form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_DM_TSCD_ID As Guid, ByVal eState As DataInputState, ByVal p_CT_GIAM_TSCD As String) As Boolean
        Try
            Form_SetText(Me, "Khai báo giảm trị tài sản", eState)
            Form_InitDialog(Me)
            m_DM_TSCD_ID = p_DM_TSCD_ID
            m_InputState = eState
            m_CT_GIAM_TSCD = p_CT_GIAM_TSCD
            Control_SetRequire(dteNGAY_CT, True)
            Control_SetRequire(txtNGAY_KT_KH, True)
            Control_SetRequire(txtSO_CT, True)
            Control_SetRequire(ckeGIAM_TS, True)

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        Return (Me.ShowDialog = DialogResult.OK)
    End Function
#End Region

#Region "Private function"

    Private Sub Init_Data()
        LoadCBO()
        SetObjectToControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                dteNGAY_CT.DateTime = Date.Now.Date
        End Select
    End Sub

    ''Lay gia tri tu Control gan cho object
    ''Thuc hien insert, update, delele
    Private Sub GetControlToOBject()
        'Lay gia tri tu DM_TSCD gan vao CT_TSCD va insert và CT_TSCD
        Dim thu_tu As Integer = _CtTscdService.GetObjectByIdDM_TSCD_DC(dm_tscd.Id).Count + 1

        If (grlLY_DO_GIAM.EditValue <> Null.NullGuid) Then
            Dim obj_LDTG As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlLY_DO_GIAM), DmLydoTgTscd)
            ct_tscd.TenLydoTanggiam = obj_LDTG.TenLydoTgTscd
            ct_tscd.LydoTanggiam = obj_LDTG.Id
        End If

        ct_tscd.NgayBdKh = txtNGAY_KT_KH.DateTime
        ct_tscd.NgayCt = dteNGAY_CT.DateTime
        ct_tscd.NgayKtKh = txtNGAY_KT_KH.DateTime
        ct_tscd.SoCt = txtSO_CT.Text

        dm_tscd.NgayKtkh = txtNGAY_KT_KH.DateTime
        dm_tscd.NgayGiam = dteNGAY_CT.DateTime

        Select Case m_InputState
            Case DataInputState.AddMode
                If (ckeGIAM_TS.Checked) Then
                    'insert CT_TSCD
                    ct_tscd.TscdId = dm_tscd.Id
                    ct_tscd.MaTscd = dm_tscd.MaTscd
                    ct_tscd.KyHieuTscd = dm_tscd.KyHieu
                    ct_tscd.TenTscd = dm_tscd.TenTscd

                    ct_tscd.DvtId = dm_tscd.DvtId
                    ct_tscd.TenDvt = dm_tscd.TenDvt
                    ct_tscd.MaDvt = dm_tscd.MaDvt
                    ct_tscd.LoaitaisanId = dm_tscd.LoaitaisanId
                    ct_tscd.MaLoaitaisan = dm_tscd.MaLoaitaisan
                    ct_tscd.ThuTu = thu_tu

                    ct_tscd.TangTscd = 4
                    ct_tscd.HaoMonLuyKe = 0

                    dm_tscd.GiamTscd = 1
                    'update DM_TSCD
                    _DmTscdService.SaveOrUpdate(dm_tscd)
                    'insert CT_DM_TSCD
                    _CtTscdService.Save(ct_tscd)
                    'insert CT_H
                End If
            Case Else
                _CtTscdService.SaveOrUpdate(ct_tscd)
                _DmTscdService.SaveOrUpdate(dm_tscd)
        End Select
        CTH_CTD()
    End Sub
    ''insert , update CTH, CTD
    Private Sub CTH_CTD()
        If (obj_CTH IsNot Nothing) Then
            obj_CTH.NgayTao = DateTime.Now
            obj_CTH.NguoiTao = Generals.USER.Id

            obj_CTH.NgaySua = DateTime.Now
            obj_CTH.NguoiSua = Generals.USER.Id

            If obj_CTH.Id = Null.NullGuid Then
                _CtHService.SaveChungTuKeToan(True, obj_CTH, lst_CTD)
            Else
                _CtHService.SaveChungTuKeToan(False, obj_CTH, lst_CTD)
            End If

            ''update lai ct_tscd
            ct_tscd.CthId = obj_CTH.Id
            _CtTscdService.SaveOrUpdate(ct_tscd)
        End If
    End Sub

    ''Lay gia tri tu object gan cho control khi update
    Private Sub SetObjectToControl()
        'Lay thong tin tu DM_TSCD gan vao control
        dm_tscd = _DmTscdService.GetById(m_DM_TSCD_ID)
        txtMA_TS.Text = dm_tscd.MaTscd
        txtTenTaiSan.Text = dm_tscd.TenTscd
        txtKY_HIEU.Text = dm_tscd.KyHieu
        txtNGAY_BDKH.Text = dm_tscd.NgayBdkh
        txtNGAY_MUA.Text = dm_tscd.NgayMua
        'txtNGAY_KT_KH.Text = dm_tscd.NGAY_KTKH

        If (dm_tscd.GiamTscd = 1) Then
            ckeGIAM_TS.Checked = True
            ckeGIAM_TS.Enabled = False
        Else
            ckeGIAM_TS.Checked = False
            ckeGIAM_TS.Enabled = True
        End If

        'lay ly do ung voi trang thai giam
        If (dm_tscd.GiamTscd = 1) Then
            ct_tscd = _CtTscdService.GetByTRANG_THAI(m_DM_TSCD_ID, 4)
            If (ct_tscd IsNot Nothing) Then
                grlLY_DO_GIAM.EditValue = ct_tscd.LydoTanggiam
                dteNGAY_CT.DateTime = ct_tscd.NgayCt
                txtNGAY_KT_KH.DateTime = ct_tscd.NgayKtKh
                txtSO_CT.Text = ct_tscd.SoCt
            End If

            'Lay gia tri con lại va hao mon luy ke
            LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(dm_tscd.Id, ct_tscd.NgayKtKh)
            If (LS_TSCD IsNot Nothing) Then
                'If (ct_tscd.NGAY_KT_KH.Month = LS_TSCD.THANG And ct_tscd.NGAY_KT_KH.Year = LS_TSCD.NAM) Then
                txtGTCL.EditValue = LS_TSCD.GiaTriCl
                txtHMLK.EditValue = LS_TSCD.HaoMonLk
                'End If
            End If
            'lay ctd ung với CT_TSCD
            obj_CTH = _CtHService.GetById(ct_tscd.CthId)
            lst_CTD = _CtDService.GetByCtHandNghiepVu(ct_tscd.CthId, 0)

            grcDINH_KHOAN.DataSource = lst_CTD

        End If
    End Sub

    ''Lay ra gia tri con lai va hao mon luy ke 
    Private Sub TS_LS_KHAUHAO()
        If DB_GetString(txtNGAY_KT_KH.Text) <> "" Then
            LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(dm_tscd.Id, txtNGAY_KT_KH.DateTime)
        Else
            Exit Sub
        End If

        Dim dt As String = DB_GetString(txtNGAY_KT_KH.DateTime)

        If LS_TSCD Is Nothing Then
            Message_Warning("Bạn chưa tính khấu hao cho TSCD")
            Exit Sub
        End If
        If DB_GetString(txtNGAY_KT_KH.Text) <> "" And LS_TSCD IsNot Nothing Then
            Dim ngay As DateTime = DateTime.Parse(dt)
            If ngay.Day < 15 Then
                ngay = ngay.AddMonths(-1)
            End If

            Dim ngay_tinh As DateTime = New DateTime(LS_TSCD.Nam, LS_TSCD.Thang, ngay.Day)

            If (ngay_tinh.Year = ngay.Year And ngay_tinh.Month = ngay.Month) Then
                txtGTCL.EditValue = LS_TSCD.GiaTriCl
                txtHMLK.EditValue = LS_TSCD.HaoMonLk
            End If

            If (ngay_tinh < ngay) Then
                If (LS_TSCD.GiaTriCl = 0) Then
                    txtGTCL.Text = "0"
                    txtHMLK.EditValue = LS_TSCD.HaoMonLk
                Else
                    Message_Warning("Khấu hao được tính đến tháng " + LS_TSCD.Thang.ToString + " năm " + LS_TSCD.Nam.ToString)
                    txtGTCL.Text = ""
                    txtHMLK.Text = 0
                End If
            End If

            If (ngay_tinh > ngay) Then
                Message_Warning("Khấu hao được tính đến tháng " + LS_TSCD.Thang.ToString + " năm " + LS_TSCD.Nam.ToString)
                txtGTCL.Text = "0"
                txtHMLK.EditValue = 0
            End If

        End If
    End Sub

    Private Sub Save()
        If (DB_GetString(DB_GetNull(dteNGAY_CT.DateTime)) = "" Or DB_GetString(DB_GetNull(txtNGAY_KT_KH.DateTime)) = "" Or txtSO_CT.Text = "") Then
            Message_Warning("Bạn chưa nhập giá trị cho trường bắt buộc!")
            Exit Sub
        End If

        Dim ngay_BDKH As Date = Convert.ToDateTime(txtNGAY_BDKH.Text)
        If (txtNGAY_KT_KH.DateTime < ngay_BDKH) Then
            Message_Warning("Ngày kết thúc khấu hao >= ngày bắt đầu khấu hao")
            txtNGAY_KT_KH.Focus()
            Exit Sub
        ElseIf txtNGAY_KT_KH.DateTime > dteNGAY_CT.DateTime Then
            Message_Warning("Ngày kết thúc khấu hao phải <= ngày chứng từ")
            txtNGAY_KT_KH.Focus()
            Exit Sub
        End If

        If (ckeGIAM_TS.Checked = True) Then
            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công")
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Message_Warning("Bạn chưa chọn khai báo giảm tài sản")
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub ckeGIAM_TS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckeGIAM_TS.CheckedChanged
        Try
            If (ckeGIAM_TS.Checked) Then
                grlLY_DO_GIAM.Enabled = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Bind grlLY_DO_TG
    Private Sub LoadCBO()
        Dim lst_LDG_TSCD As List(Of DmLydoTgTscd) = New List(Of DmLydoTgTscd)
        lst_LDG_TSCD.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(4, Generals.DON_VI.Id))
        Dim objColumnDefine As ArrayList = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenLydoTgTscd", "Tên lý do giảm tài sản"))
        GridLookupEdit_BindData(grlLY_DO_GIAM, lst_LDG_TSCD, "KyHieu", "Id", COMBO_ITEM_REQUIRE, "TenLydoTgTscd", txttenlydo, objColumnDefine)

        lst_tk = New List(Of DmTaikhoan)()
        lst_tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        'lst_tk = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

        Dim dt_TK_CO As New List(Of DmTaikhoan)
        dt_TK_CO.AddRange(lst_tk)
        cboMA_TK_CO.DataSource = dt_TK_CO
        cboMA_TK_CO.DisplayMember = "MaTaikhoan"
        cboMA_TK_CO.ValueMember = "Id"
        cboMA_TK_CO.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboMA_TK_CO.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))

        Dim dt_TK_NO As New List(Of DmTaikhoan)
        dt_TK_NO.AddRange(lst_tk)
        cboMA_TK_NO.DataSource = dt_TK_NO
        cboMA_TK_NO.DisplayMember = "MaTaikhoan"
        cboMA_TK_NO.ValueMember = "Id"
        cboMA_TK_NO.Columns.Add(New LookUpColumnInfo("MaTaikhoan", "Mã tài khoản"))
        cboMA_TK_NO.Columns.Add(New LookUpColumnInfo("TenTaikhoan", "Tên tài khoản"))
    End Sub

    Private Function Tai_Khoan(ByVal TAI_KHOAN_ID As Guid) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each obj As DmTaikhoan In lst_tk
            If obj.Id = TAI_KHOAN_ID Then
                obj_tk = obj
            End If
        Next
        Return obj_tk
    End Function

    Private Function Tai_Khoan(ByVal Ma_Taikhoan As String) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each obj As DmTaikhoan In lst_tk
            If obj.MaTaikhoan = Ma_Taikhoan Then
                obj_tk = obj
            End If
        Next
        Return obj_tk
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Save()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmKhaiBaoGiamTaiSan_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ckeGIAM_TS.Checked = False
            grlLY_DO_GIAM.EditValue = Nothing
            txttenlydo.Text = String.Empty
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLY_DO_GIAM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLY_DO_GIAM.EditValueChanged
        Try
            Dim obj_LDTG As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlLY_DO_GIAM), DmLydoTgTscd)
            If Not (obj_LDTG Is Nothing) Then
                txttenlydo.Text = obj_LDTG.TenLydoTgTscd
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtNGAY_KT_KH_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNGAY_KT_KH.Validated
        Try
            TS_LS_KHAUHAO()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDINH_KHOAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDINH_KHOAN.Click
        'CT_H
        Try
            frmProgress.Instance.Thread = AddressOf DINH_KHOAN
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Hoàn thành")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DINH_KHOAN()
        If ct_tscd.CthId = Null.NullGuid Then
            obj_CTH = New CtH
            obj_CTH.DonviId = Generals.DON_VI.Id
            obj_CTH.MaDonvi = Generals.DON_VI.MaDonvi
            obj_CTH.NgayCt = dteNGAY_CT.DateTime
            obj_CTH.NgayGhi = dteNGAY_CT.DateTime

            Dim obj_HT_LOAICT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(m_CT_GIAM_TSCD, Generals.DON_VI.Id)
            obj_CTH.IdLoaiCt = obj_HT_LOAICT.Id
            obj_CTH.KyHieuLoaiCt = obj_HT_LOAICT.KyHieu
            obj_CTH.MaLoaiCt = obj_HT_LOAICT.MaLoaiCt
            obj_CTH.SoTienNte = 0
            obj_CTH.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
            obj_CTH.MaNte = _DmNgoaiteService.GetById(VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)).MaNte
            lst_CTD.Clear()
            'CT_D(CT_D gia tri con lai)
            Dim obj_CTD_GTCL As CtD = New CtD
            obj_CTD_GTCL.PhanHe = 4
            'obj_CTD.CTH_ID = obj_CTH.CTH_ID id lấy sau khi nhấn lưu
            Dim obj_tk_No_CL As DmTaikhoan = _DmTaikhoanService.GetObjectByMaTK("411", Generals.DON_VI.Id)
            obj_CTD_GTCL.TkNoId = obj_tk_No_CL.Id
            obj_CTD_GTCL.TenTkNo = obj_tk_No_CL.TenTaikhoan
            obj_CTD_GTCL.MaTkNo = obj_tk_No_CL.MaTaikhoan

            Dim obj_tk_CO_CL As DmTaikhoan = Tai_Khoan(dm_tscd.MdTkTs)

            If (obj_tk_CO_CL IsNot Nothing) Then
                obj_CTD_GTCL.MaTkCo = obj_tk_CO_CL.MaTaikhoan
                obj_CTD_GTCL.TkCoId = obj_tk_CO_CL.Id
                obj_CTD_GTCL.TenTkCo = obj_tk_CO_CL.TenTaikhoan
                If txtGTCL.Text <> "" Then
                    obj_CTD_GTCL.SoTien = txtGTCL.Text
                End If
                lst_CTD.Add(obj_CTD_GTCL)
            End If
            'CT_D(CT_D Hao mon luy ke)
            Dim obj_CTD_HMLK As CtD = New CtD
            obj_CTD_HMLK.PhanHe = 4
            Dim obj_tk_no_LK As DmTaikhoan = Tai_Khoan(dm_tscd.MdTkKhauhao)
            If obj_tk_no_LK IsNot Nothing Then
                obj_CTD_HMLK.MaTkNo = obj_tk_no_LK.MaTaikhoan
                obj_CTD_HMLK.TenTkNo = obj_tk_no_LK.TenTaikhoan
                obj_CTD_HMLK.TkNoId = obj_tk_no_LK.Id
            End If

            If (obj_tk_CO_CL IsNot Nothing) Then
                obj_CTD_HMLK.TkCoId = obj_tk_CO_CL.Id
                obj_CTD_HMLK.MaTkCo = obj_tk_CO_CL.MaTaikhoan
                obj_CTD_HMLK.TenTkCo = obj_tk_CO_CL.TenTaikhoan
                If txtHMLK.Text <> "" Then
                    obj_CTD_HMLK.SoTien = txtHMLK.Text
                    lst_CTD.Add(obj_CTD_HMLK)
                End If
            End If
        Else
            obj_CTH = _CtHService.GetById(ct_tscd.CthId)
            lst_CTD = _CtDService.GetByCtHandNghiepVu(ct_tscd.CthId, 0)
        End If

        Dim so_tien As Decimal = 0

        For Each obj As CtD In lst_CTD
            If Not String.IsNullOrEmpty(obj.SoTien) Then
                so_tien = so_tien + obj.SoTien
            End If
        Next

        obj_CTH.SoTien = so_tien
        grcDINH_KHOAN.DataSource = lst_CTD
        grvDINH_KHOAN.RefreshData()
    End Sub

    Private Sub grvDINH_KHOAN_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvDINH_KHOAN.CellValueChanged
        Try
            Dim obj_grv_DINH_KHOAN As CtD = CType(grvDINH_KHOAN.GetRow(grvDINH_KHOAN.FocusedRowHandle), CtD)
            Select Case e.Column.Name
                Case "MA_TK_NO"
                    Dim cboTK_NO As DmTaikhoan = CType(cboMA_TK_NO.GetDataSourceRowByKeyValue(obj_grv_DINH_KHOAN.TkNoId), DmTaikhoan)
                    obj_grv_DINH_KHOAN.MaTkNo = cboTK_NO.MaTaikhoan
                    obj_grv_DINH_KHOAN.TenTkNo = cboTK_NO.TenTaikhoan
                Case "MA_TK_CO"
                    Dim cboTK_CO As DmTaikhoan = CType(cboMA_TK_CO.GetDataSourceRowByKeyValue(obj_grv_DINH_KHOAN.TkCoId), DmTaikhoan)
                    obj_grv_DINH_KHOAN.MaTkCo = cboTK_CO.MaTaikhoan
                    obj_grv_DINH_KHOAN.TenTkCo = cboTK_CO.TenTaikhoan
            End Select
            grvDINH_KHOAN.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class